//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  Packet.h
//   Description : This header file contains the format details for
//				   various headers such as Ethernet,IP,ARP,TCP etc.
//				   
//
//////////////////////////////////////////////////////////////////////////////



#if !defined(AFX_PACKET_H__A2167241_1C49_11D8_888B_000B2B0F84B6__INCLUDED_)
#define AFX_PACKET_H__A2167241_1C49_11D8_888B_000B2B0F84B6__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Packet.h : header file
//
#include<pcap.h>


#define WM_PACKET_OPENDEVICE WM_USER+400
#define WM_PACKET_STARTSCAN WM_USER+410
#define WM_PACKET_STOPSCAN WM_USER+420
#define WM_PACKET_CLOSEDEVICE WM_USER+430


//  define the tcp flags....
#define   TCP_FIN   0x01
#define   TCP_SYN   0x02
#define   TCP_RST   0x04
#define   TCP_PSH   0x08
#define   TCP_ACK   0x10
#define   TCP_URG   0x20
#define   TCP_ACE   0x40
#define   TCP_CWR   0x80


//define header lengths

#define ETHER_LENGTH  14
#define IP_LENGTH     20
#define TCP_LENGTH    20
#define UDP_LENGTH    8
#define ICMP_LENGTH   8
#define ARP_LENGTH    28
#define PSEUDO_LENGTH 12
#define DATA_LENGTH   32


//Protocol
#define PROTO_ICMP    1
#define PROTO_IGMP    2
#define PROTO_TCP     6
#define PROTO_UDP     17


/////////////////////////////////////////////////////////////////////////////
// Packet thread

class Packet : public CWinThread
{
	DECLARE_DYNCREATE(Packet)
public:
	pcap_t *hdev;
	struct pcap_pkthdr *header;
	struct bpf_program fcode;
	u_char *pkt_data;
	BOOL isOpen,isStart,stopscanning;
	CStdioFile log;
	pcap_if_t *devlist;
	CListCtrl *plist;

	char destaddr[100] , ipaddress[100];
	BYTE hostmac[8],hostip[4],destmac[8],destip[4],srcip[4];
	int startportno,endportno;

	CString devname[10];
	CString description[10];
	int devcount;


	
	struct eth_header   // 14 bytes
	{
	u_char dhost[6]; //destination mac address
	u_char shost[6]; //source mac address
	u_short type;                 //IP ,ARP , RARP
	};
	
	
	// 4 byte ip address
	struct ip_address
	{
	u_char byte1;
	u_char byte2;
	u_char byte3;
	u_char byte4;
	};


	/* IPv4 header */
    struct ip_header
	{
    u_char  ver_ihl;        // Version (4 bits) + Internet header length (4 bits)
    u_char  tos;            // Type of service 
    u_short tlen;           // Total length 
    u_short identification; // Identification
    u_short flags_fo;       // Flags (3 bits) + Fragment offset (13 bits)
    u_char  ttl;            // Time to live
    u_char  proto;          // Protocol
    u_short crc;            // Header checksum
    ip_address  saddr;      // Source address
    ip_address  daddr;      // Destination address
   
	// u_int   op_pad;         // Option + Padding
	};

	
	
	struct arp_header   //28 bytes
	{
	u_short hrd;       //hardware address space=0x0001
	u_short eth_type;  //Ethernet type ....=0x0800
	u_char maclen;     //Length of mac address=6
	u_char iplen;      //Length of ip addres=4
	u_short opcode;    //Request =1 Reply=2 (highbyte)
	u_char smac[6];    //source mac address
	ip_address saddr;  //Source ip address
	u_char dmac[6];    //Destination mac address
	ip_address daddr;  //Destination ip address
	};
	

   struct udp_header   //8 bytes
   {
    u_short sport;          // Source port
    u_short dport;          // Destination port
    u_short len;            // Datagram length
    u_short crc;            // Checksum
   };

	struct tcp_header  //20 bytes
	{
	u_short sport;      //Source port
	u_short dport;      //Destination port
	u_long seqno;       //Sequence no
	u_long ackno;       //Ack no
	u_char offset;      //Higher level 4 bit indicates data offset
	u_char flag;        //Message flag
					//FIN - 0x01
					//SYN - 0x02
					//RST - 0x04 
					//PUSH- 0x08
					//ACK- 0x10
					//URG- 0x20
					//ACE- 0x40
					//CWR- 0x80

	u_short win;
	u_short checksum;
	u_short uptr;
  	};

	struct icmp_header
	{
	u_char type;
	u_char code;
	u_short checksum;
	u_short id;
	u_short seqno;
	};
	
	//For checksum calculation purpose
	struct pseudo_header  //12 bytes 
	{
    ip_address  saddr;      // Source address
    ip_address  daddr;      // Destination address
	u_char zero;
	u_char  proto;          // Protocol
	u_short tcp_len;
	tcp_header tcp;
	};


	public:	
	
	Packet();           // protected constructor used by dynamic creation

// Attributes
public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();
	
	BOOL OpenDevice(int index);
	BOOL  CloseDevice();
	
	afx_msg LRESULT StartScan(WPARAM wp,LPARAM lp);
	afx_msg LRESULT StopScan(WPARAM wp,LPARAM lp);
	LRESULT ApplyFilter(char *filter);
	u_short ComputeChecksum(u_short *data,int size);
	BOOL GetDestMacAddress();
	void GetLocalAddress();
	int GetDeviceList();


protected:
	virtual ~Packet();

	
	DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PACKET_H__A2167241_1C49_11D8_888B_000B2B0F84B6__INCLUDED_)
