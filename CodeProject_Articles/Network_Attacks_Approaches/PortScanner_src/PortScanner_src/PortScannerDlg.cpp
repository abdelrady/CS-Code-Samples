//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  PortScannerDlg.cpp
//   Description : Displays port scanner dialog
//
//////////////////////////////////////////////////////////////////////////////


#include "stdafx.h"
#include "PortScanner.h"
#include "PortScannerDlg.h"
#include "packet.h"

#include <afxcmn.h>

#define  s6_addr 11111     //This trick is to eliminate redefinition
						   //of in6_addr in iphlpapi.h file since it is 
						   //already defined in ws2tcpip.h
#include <iphlpapi.h>


#pragma comment(lib,"iphlpapi.lib")

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif




/////////////////////////////////////////////////////////////////////////////
// CPortScannerDlg dialog

CPortScannerDlg::CPortScannerDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CPortScannerDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CPortScannerDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CPortScannerDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CPortScannerDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CPortScannerDlg, CDialog)
	//{{AFX_MSG_MAP(CPortScannerDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON2, OnButton2)
	ON_BN_CLICKED(IDC_BUTTON1, OnButton1)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPortScannerDlg message handlers

BOOL CPortScannerDlg::OnInitDialog()
{
	
	
	CDialog::OnInitDialog();

	list=(CListCtrl *)this->GetDlgItem(IDC_LIST1);
	port1=(CEdit *)this->GetDlgItem(IDC_EDIT1);
	port2=(CEdit *)this->GetDlgItem(IDC_EDIT2);

	devlist=(CComboBox*)GetDlgItem(IDC_COMBO1);
	devlist->SetWindowPos(&wndTop,0,0,250,120,SWP_SHOWWINDOW | SWP_NOMOVE);


	butstart=(CButton *)GetDlgItem(IDC_BUTTON1);
	butstop=(CButton *)GetDlgItem(IDC_BUTTON2);

	butstart->EnableWindow(TRUE);
	butstop->EnableWindow(FALSE);


	list->SetExtendedStyle(LVS_EX_FULLROWSELECT); 
	list->InsertColumn(0,"Port",LVCFMT_LEFT,150);
	list->InsertColumn(1,"Status",LVCFMT_LEFT,212);


	packet=new Packet();
	if(packet->GetDeviceList()==0)
	{
	MessageBox("No network adapters are present...");
	OnCancel();
	}
	
	// Get the device names and add to the combo box...
	for(int i=0;i<packet->devcount;i++)
	devlist->AddString(packet->description[i]);

	devlist->SetCurSel(0);

	// Now create the thread....
	packet->CreateThread();

	
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	

	//Get MAC address of LocalHost
	if(GetMacAddress()==FALSE)
	{
		MessageBox("Unable to get Source MAC address");
		OnCancel();
	}

	


	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CPortScannerDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

HCURSOR CPortScannerDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}



/**
*   Obtain the MAC address of the local host...
*
*/
BOOL CPortScannerDlg::GetMacAddress()
{
	IP_ADAPTER_INFO adapter[5];  //Maximum 5 adapters

	DWORD buflen=sizeof(adapter);

	DWORD status=GetAdaptersInfo(adapter,&buflen);

	if(status==ERROR_SUCCESS)
	{
	
	PIP_ADAPTER_INFO painfo=adapter;
    memcpy(packet->hostmac,painfo->Address,6);

	return TRUE;
	}


return FALSE;	
}




/**
*    Start the port scanner...
*
*/
void CPortScannerDlg::OnButton1() 
{

	// Open the device...
	if(packet->OpenDevice(devlist->GetCurSel())==FALSE)
	{
	MessageBox("Unable to open the specified device");
	return;
	}


	//Get Destination IP Address
	CIPAddressCtrl *cip=(CIPAddressCtrl*)this->GetDlgItem(IDC_IPADDRESS1);
	cip->GetAddress(packet->destip[0],packet->destip[1],packet->destip[2],packet->destip[3]);
	
	
	//Get the range of Port Numbers
	packet->startportno=GetDlgItemInt(IDC_EDIT1,NULL,FALSE);
	packet->endportno=GetDlgItemInt(IDC_EDIT2,NULL,FALSE);
	
	//Enable scanning
	packet->stopscanning=FALSE;

	//Clear the ListControl Box
	list->DeleteAllItems();

	butstart->EnableWindow(FALSE);
	butstop->EnableWindow(TRUE);
	
	// Start scanning...
	packet->PostThreadMessage(WM_PACKET_STARTSCAN,0,(LPARAM)this);

}


/**
*    Stop the port scanning...
*
*/
void CPortScannerDlg::OnButton2() 
{


	packet->SuspendThread();
	packet->stopscanning=TRUE;
	packet->ResumeThread();

	//Wait for thread to stop scanning....
	::Sleep(200);

	packet->CloseDevice();

	butstart->EnableWindow(TRUE);
	butstop->EnableWindow(FALSE);
}


// Exit the application
void CPortScannerDlg::OnCancel() 
{
	// Close the device...
	packet->CloseDevice();
	CDialog::OnCancel();
}
