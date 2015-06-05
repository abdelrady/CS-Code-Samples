// This is the main DLL file.

#include "stdafx.h"

#include "wpcap_Wrapper_1.h"
#include "pcap.h"

pcap_if_t* wpcap_Wrapper_1::Class1::_tMM()
{
	char errbuf[PCAP_ERRBUF_SIZE];
	pcap_if_t *Devs;
	if(pcap_findalldevs_ex(PCAP_SRC_IF_STRING, 0 , &Devs , errbuf)!=-1)
	{
		return Devs;
	}
	return 0;
}

