//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  Packet.cpp
//   Description : It opens the device and captures the packet based on 
//				   the filter.
//				   For more information on Capture API , please refer
//				   Winpcap documentation.
//////////////////////////////////////////////////////////////////////////////


#include "stdafx.h"
#include "Packet.h"
#include "PortScannerDlg.h"


#include <pcap.h>


#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

IMPLEMENT_DYNCREATE(Packet, CWinThread)

Packet::Packet()
{
}



Packet::~Packet()
{
}



BOOL Packet::InitInstance()
{
	
	log.Open("log.txt",CFile::modeWrite | CFile::modeCreate | CFile::shareDenyWrite);
	return TRUE;
}

int Packet::ExitInstance()
{

	this->CloseDevice();
	
	// TODO:  perform any per-thread cleanup here
	return CWinThread::ExitInstance();
}

BEGIN_MESSAGE_MAP(Packet, CWinThread)
ON_THREAD_MESSAGE(WM_PACKET_OPENDEVICE  , OpenDevice)
ON_THREAD_MESSAGE(WM_PACKET_STARTSCAN, StartScan)
ON_THREAD_MESSAGE(WM_PACKET_STOPSCAN , StopScan)
ON_THREAD_MESSAGE(WM_PACKET_CLOSEDEVICE , CloseDevice)
END_MESSAGE_MAP()



/**
*     Enumerate all available devices...
*
*/
int Packet::GetDeviceList()
{
int retvalue,i;
char err[PCAP_ERRBUF_SIZE];
pcap_if_t *d;

    devcount=0;


	retvalue=pcap_findalldevs(&devlist,err);
		
	if(retvalue==-1 || devlist==NULL)
	return FALSE;
 
	
	// Enumerate available devices...
	// Store the name and decription...
	for(d=devlist,i=0; d && i<10 ;d=d->next,i++)
    {
        devname[i]=d->name;
		description[i]=d->description;
			
	}

	devcount=i;


	// determine the local ip address
	GetLocalAddress();

	return devcount;

}




/**
*    Determine the ip address of local machine
*
*/

void Packet::GetLocalAddress()
{
char name[200];
HOSTENT *h;

	gethostname(name,200);

	h=::gethostbyname(name);

	memcpy(srcip,h->h_addr_list[0],4);

	sprintf(name,"%d.%d.%d.%d",srcip[0],srcip[1],srcip[2],srcip[3]);
	
}


/**
*	Open the device...based upon the device index ...
*	This index is obtained from GetDeviceList Function...
*
*/

BOOL Packet::OpenDevice(int index)
{
char err[PCAP_ERRBUF_SIZE];

    	
	// if the device is already open
	// close the device...
	if(isOpen==TRUE)
	{
	CloseDevice();	
	}	
	
	hdev=pcap_open_live( LPCTSTR(devname[index]), //name of the device
		                 65535,		 //Capture whole packet
	                     1,			 //promiscous mode  
						 1000,       //read timeout in ms
						 err 
						 );

	

	if(hdev==NULL)
	return FALSE;
	/*
	//check the link layer to support only ethernet
	if(pcap_datalink(hdev)!=DLT_EN10MB)
	{
	log.WriteString("\n Error : Only Ethernet Network is supported");
	return FALSE;
	}

	*/

	isOpen=TRUE;


return TRUE;

}


/**
*		Start the port scanning process
*       For protocol format , refer Packet.h file.
*/
LRESULT Packet::StartScan(WPARAM wp,LPARAM lp)
{
int retvalue;

eth_header eh;
ip_header ih,*rih;
tcp_header th,*rth;
pseudo_header psh;

CPortScannerDlg *scan;

char str[300],destaddr[100];
u_char frame[200];

int index=0;
u_short sport;
int i,repcount=0;




	
	//If capture device not opened then return ...
	if(isOpen==FALSE)
	return FALSE;


	// Obtains the pointer to main dialog
	scan=(CPortScannerDlg*)lp;
	
	
	// Check for destination address = 127.0.0.1
	// If so then assign proper address of the host to destination
	if(destip[0]==127 && destip[1]==0 && destip[2]==0 && destip[3]==1)
	{
	memcpy(destip,srcip,4);
	}

	
	
	// Don't use real host address as source address
	// Just change the last byte of source ip address
	// This is called IP Spoofing...
	memcpy(hostip,srcip,4);
	hostip[3]=::rand()%254+1;

	
		
		// Determine the MAC address of the destination machine
		if(GetDestMacAddress()==FALSE)
		{
		AfxMessageBox("Unable to determine the destination MAC address");
		scan->butstart->EnableWindow(TRUE);
		scan->butstop->EnableWindow(FALSE);
		return FALSE;
		}


	// ***** Now apply the filter *****
	// Receive only incoming packets from the target host
	// Filter details..
	// Protocol : TCP
	// Source Address  : Target Machine
	// Destination port : same as source machine port

	sprintf(destaddr,"%d.%d.%d.%d",destip[0],destip[1],destip[2],destip[3]);
	sprintf(str,"src net %s and tcp port 6000",destaddr);
	
	ApplyFilter(str);
	




	// Prepare Ethernet Header , IP Header and TCP Header in Advance

	
	/*******************  Ethernet Header ******************/

	memset(&eh,0,sizeof(eh));
	
	//Source MAC address
	memcpy(eh.shost,hostmac,6);
	
	//Destination MAC address
	memcpy(eh.dhost,destmac,6);
	
	eh.type=htons(0x0800); //IP Frames

	memcpy(&frame,&eh,ETHER_LENGTH);


	
	/*******************  IP Header ******************/
	
	memset(&ih,0,sizeof(ih));
	
	//source address
	memcpy(&ih.saddr,hostip,4);
		
	//destination address
	memcpy(&ih.daddr,destip,4);
	
	ih.proto=PROTO_TCP;         

	ih.flags_fo=htons(0x4000);			//For TCP Flag fixed
//	ih.flags_fo=htons(0x0000);			//For ICMP Flag fixed
	ih.identification=htons(0x0150);    //Any number
	
	
	ih.tlen=htons(IP_LENGTH+TCP_LENGTH);      //Depends upon data and tcp protocol
	ih.tos=0;
	ih.ttl=32;
	ih.ver_ihl=0x45;  //Version (v4) and  header length(5 nibbles)
	ih.crc=0;
	ih.crc=ComputeChecksum((u_short *)&ih,IP_LENGTH);

	memcpy(&frame[ETHER_LENGTH],&ih,IP_LENGTH);

	
	
	
	/***************  TCP Header ****************************/

	  
	memset(&th,0,sizeof(th));
	th.sport=htons(6000);   // source port
	th.dport=htons(139);    // dest port changes dynamically
	th.ackno=htonl(0);
	th.seqno=htonl(5555l);
	th.flag=TCP_SYN;        // SYN packet
	th.offset=0x50;         // data offset
	th.uptr=0;
	th.win=htons(512) ;
	th.checksum=0;
	
	//set up the pseudo header 
	memset(&psh,0,sizeof(psh));
	psh.saddr=ih.saddr;
	psh.daddr=ih.daddr;
	psh.proto=ih.proto;
	psh.zero=0;
	psh.tcp_len=htons(TCP_LENGTH);				//Length of Tcp header + Data in OCTATES
	memcpy(&psh.tcp,&th,TCP_LENGTH);
	
	th.checksum=ComputeChecksum((u_short*)&psh,TCP_LENGTH+PSEUDO_LENGTH);

	
	// Now start scanning  for all port numbers mentioned...

	for(i=startportno;i<=endportno;i++,index++)
	{
		//Check if stop scan button is pressed
		if(stopscanning==TRUE)
		{
		stopscanning=FALSE;
		return FALSE;
		}
		
		// Update ListCtrl in the Interface Window
		sprintf(str,"%d",i);
		scan->list->InsertItem(index,str,NULL);

		//Repeatcount of waiting for the proper packet
		repcount=0;

		//TCP Header
		th.dport=htons(i); 
		th.checksum=0;


		//copy new tcp header into pseudo header
		memcpy(&psh.tcp,&th,TCP_LENGTH);
		
		//Compute Checksum for TCP Header
		th.checksum=ComputeChecksum((u_short*)&psh,TCP_LENGTH+PSEUDO_LENGTH);

		//Copy TCP Header into the frame at the end of IP Packet
		memcpy(&frame[ETHER_LENGTH+IP_LENGTH],&th,TCP_LENGTH);
	
	
		//Send the packet
		pcap_sendpacket(hdev,frame,ETHER_LENGTH+IP_LENGTH+TCP_LENGTH);

	
		//Wait for the SYN - ACK or RST-ACK packet
		//If any other packet comes then ignore it....

		//If no packet comes after trying 5 times then stop the scan and exit
		//Since target machine might have shut down...or it may be sleeping..!!!
		
			int count=0;
	

			while(true)
			{
				
				//Check if stop scan button is pressed
				if(stopscanning==TRUE)
				{
				stopscanning=FALSE;
				return FALSE;
				}

				// Wait for next packet
				retvalue=pcap_next_ex(hdev,&header,&pkt_data);
			
				if(retvalue<0)
				{
				log.WriteString("Error in capturing the packet");
				scan->butstart->EnableWindow(TRUE);
				scan->butstop->EnableWindow(FALSE);
				return FALSE;
				}
				
				if(header->caplen==0)
				{
					count++;
					
					if(count>5)
					{
						AfxMessageBox("Target Machine is  not responding");
						scan->butstart->EnableWindow(TRUE);
						scan->butstop->EnableWindow(FALSE);
						return FALSE;
					}
				
					continue;
				}
			
				
				//Now check if this packet is proper or not	
			
				count=0;
				repcount++;
					//Check only for 3 times for the proper packet
					if(repcount>3)
					{
						AfxMessageBox("Target Machine is  not responding");
						scan->butstart->EnableWindow(TRUE);
						scan->butstop->EnableWindow(FALSE);
						return FALSE;
					}

				//Get the IP Header...
				rih=(ip_header*)(pkt_data+ETHER_LENGTH);
	
	 
				//Cross check the incoming packet

				if(rih->proto==PROTO_TCP)  //check for tcp protocol
				{
		
					//Get the TCP Header
					rth=(tcp_header*)((u_char*)rih+ (rih->ver_ihl & 0x0f)*4);

					//Convert network byte order to host byte order
					sport=ntohs(rth->sport);
					
					//Check if the response is for the current port number
					if(sport==i) 
					{
							
							// Check if it is SYN+ACK packet...
							if((rth->flag & TCP_SYN) && (rth->flag & TCP_ACK) )
							{
								sprintf(str,"*** Open ***");
								scan->list->SetItemText(index,1,str);
								break;
							}
							else // Check if it is RST+ACK packet
								if((rth->flag & TCP_RST) && (rth->flag & TCP_ACK) )
								{
								sprintf(str,"Closed");
								scan->list->SetItemText(index,1,str);
								break;
								}
					}
				
				}


			}    //End of Receiving while loop

	}		//End of port scanner for loop

	// Update the button status....
	scan->butstart->EnableWindow(TRUE);
	scan->butstop->EnableWindow(FALSE);
	
	AfxMessageBox("Scanning completed...");
	return TRUE;

}


//
//  Send ARP Request packet to determine the MAC address of
//  the destination machine.
//  ARP Reply message contains the MAC address of destination
//  machine...
//  This trick also prevents the target host from sending arp packet
//  to source host when source host sends the first SYN packet.
//  From the ARP request packet , target host will come to know
//  about the MAC address of the source host...
//

BOOL Packet::GetDestMacAddress()
{

eth_header eh,*peh;
arp_header arph,*parph;

int retvalue;
u_char frame[200];
char str[100],filter[200];


	// Apply filter to receive only ARP reply packet...
	sprintf(str,"%d.%d.%d.%d",destip[0],destip[1],destip[2],destip[3]);
	sprintf(filter,"arp src net %s",str);
	ApplyFilter(filter);
	

	// Prepare ARP request packet

	/*******************  Ethernet Header ******************/

	memset(&eh,0,sizeof(eh));
	
	// Source Mac address
	memcpy(eh.shost,hostmac,6);

	// Destination MAC address ; make it all 0xff
	memset(eh.dhost,0xff,6);
	
	eh.type=htons(0x0806); //IP Frames

	memcpy(&frame,&eh,ETHER_LENGTH);


	/*******************  ARP Header ******************/
	
	arph.eth_type=htons(0x0800);
	
	memcpy(arph.smac,eh.shost,6);
	memset(arph.dmac,0,6);

	memcpy(&arph.daddr,destip,4);
	memcpy(&arph.saddr,hostip,4);
	
	arph.hrd=htons(0x0001);
	
	arph.iplen=4;
	arph.maclen=6;

	arph.opcode=0x0100;  //Request ARP packet

	memcpy(&frame[ETHER_LENGTH],&arph,ARP_LENGTH);

		
	//Send the ARP request packet
	pcap_sendpacket(hdev,frame,ETHER_LENGTH+ARP_LENGTH);

	
	//Now wait ARP reply packet
			int count=0;

			while(true)
			{
				//Check if stop scan button is pressed
				if(stopscanning==TRUE)
				{
				stopscanning=FALSE;
				return FALSE;
				}

				retvalue=pcap_next_ex(hdev,&header,&pkt_data);
			
				if(retvalue<0)
				{
				log.WriteString("Error in capturing the packet");
				return FALSE;
				}
				
				if(header->caplen==0)
				{
					count++;
					
					if(count>5)
					{
						return FALSE;
					}
				
					continue;
				}
			
				//Now this packet is the required packet..
				//So take a break and check it out....
			
				//check for ARP packet IP address checking is better

		
				//Get the Ethernet Header...
				peh=(eth_header*)pkt_data;

				if(ntohs(peh->type)==0x0806)	
				{
					// Get the ARP Header
					parph=(arp_header*)(pkt_data+ETHER_LENGTH);
				
					//check if it is Reply
					if(parph->opcode==0x0200)
					{
						memcpy(destmac,parph->smac,6);
						return TRUE;
					}
				
				}


			}
	return FALSE;
}


/**
*    Standard checksum algorithm
*
*/
u_short Packet::ComputeChecksum(u_short *data,int size)
{
register int nleft=size;
register u_short *w=data;
register int sum=0;
u_short answer =0;



	while(nleft>1)
	{
	sum+=*w++;
	nleft-=2;
	}


	if(nleft==1)
	{

		*(u_char*) (&answer) = *(u_char*)w;
		sum+=answer;
	}


	sum= (sum>>16 )+ (sum & 0xffff);
	sum+=(sum>>16);
	answer=~sum;
	return (answer);

}



/**
*    Filter the incoming packets...
*	 For filter expression refer winpcap docs
*
*/

LRESULT Packet::ApplyFilter(char *filter)
{
u_int netmask;
int retvalue;

	//log.WriteString(strcat(mesg,filter));
	if(devlist->addresses!=NULL)
	netmask=((struct sockaddr_in *)(devlist->addresses->netmask))->sin_addr.S_un.S_addr;
	else
	netmask=0xffffffff;

	//compile the filter
	retvalue=pcap_compile(hdev,&fcode,filter,1,netmask);
	
	if(retvalue<0)
	{
	log.WriteString("\n Unable to compile the filter");
	return FALSE;
	}

	//Set the filter
	retvalue=pcap_setfilter(hdev,&fcode);
	
	if(retvalue<0)
	{
	log.WriteString("\n Unable to set the filter");
	return FALSE;
	}
	
	
	log.WriteString("\n Filter applied successfully");

return TRUE;

}






// presently not used....

LRESULT Packet::StopScan(WPARAM wp,LPARAM lp)
{
return TRUE;
}



/**
*   Before next scanning close the device...
*
*/  
BOOL  Packet::CloseDevice()
{

	if(isOpen==TRUE)
	{

	pcap_freealldevs(devlist);
	
	pcap_close(hdev);

	hdev=NULL;
	}
	
	isOpen=FALSE;


return TRUE;
}


