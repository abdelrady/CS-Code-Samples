; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=RequestDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "VideoNet.h"

ClassCount=8
Class1=CVideoNetApp
Class2=CVideoNetDlg
Class3=CAboutDlg

ResourceCount=7
Resource1=IDD_VIDEONET_DIALOG
Resource2=IDR_MAINFRAME
Resource3=IDD_ABOUTBOX
Resource4=IDD_DIALOG2
Class4=ConnectDlg
Class5=DSocket
Class6=Invitation
Resource5=IDD_DIALOG3
Class7=InvitationDlg
Class8=RequestDlg
Resource6=IDD_DIALOG1
Resource7=IDR_MENU1

[CLS:CVideoNetApp]
Type=0
HeaderFile=VideoNet.h
ImplementationFile=VideoNet.cpp
Filter=N

[CLS:CVideoNetDlg]
Type=0
HeaderFile=VideoNetDlg.h
ImplementationFile=VideoNetDlg.cpp
Filter=D
BaseClass=CDialog
VirtualFilter=dWC
LastObject=AUDIO_CONTROL

[CLS:CAboutDlg]
Type=0
HeaderFile=VideoNetDlg.h
ImplementationFile=VideoNetDlg.cpp
Filter=D

[DLG:IDD_ABOUTBOX]
Type=1
Class=CAboutDlg
ControlCount=7
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889
Control5=IDC_STATIC,static,1342308352
Control6=IDC_STATIC,static,1342308352
Control7=IDC_STATIC,static,1342308352

[DLG:IDD_VIDEONET_DIALOG]
Type=1
Class=CVideoNetDlg
ControlCount=8
Control1=IDC_LOCALBORDER,button,1342177287
Control2=IDC_LOCALVIDEO,static,1350565892
Control3=IDC_REMOTEBORDER,button,1342177287
Control4=IDC_REMOTEVIDEO,static,1350565892
Control5=IDC_STATIC,button,1342177287
Control6=IDC_LIST1,listbox,1353777409
Control7=IDC_EDIT1,edit,1350631556
Control8=IDC_BUTTON1,button,1342242816

[MNU:IDR_MENU1]
Type=1
Class=?
Command1=CONF_CONNECT
Command2=CONF_DISCONNECT
Command3=CONF_EXIT
Command4=VIEW_LOCAL
Command5=VIEW_REMOTE
Command6=AUDIO_CONTROL
Command7=AUDIO_SEND
Command8=AUDIO_RECEIVE
Command9=VIDEO_SEND
Command10=VIDEO_RECEIVE
Command11=HELP_ABOUT
CommandCount=11

[DLG:IDD_DIALOG1]
Type=1
Class=ConnectDlg
ControlCount=4
Control1=IDCANCEL,button,1342242816
Control2=IDC_BUTTON1,button,1342242816
Control3=IDC_STATIC,static,1342308352
Control4=IDC_EDIT1,edit,1350631552

[CLS:ConnectDlg]
Type=0
HeaderFile=onnectDlg.h
ImplementationFile=onnectDlg.cpp
BaseClass=CDialog
Filter=D
VirtualFilter=dWC

[CLS:DSocket]
Type=0
HeaderFile=DSocket.h
ImplementationFile=DSocket.cpp
BaseClass=CSocket
Filter=N

[CLS:Invitation]
Type=0
HeaderFile=Invitation.h
ImplementationFile=Invitation.cpp
BaseClass=CDialog
Filter=D
LastObject=AUDIO_CONTROL

[DLG:IDD_DIALOG2]
Type=1
Class=RequestDlg
ControlCount=3
Control1=IDOK,button,1342242817
Control2=IDREJECT,button,1342242816
Control3=IDC_MESG,static,1342308352

[CLS:RequestDlg]
Type=0
HeaderFile=RequestDlg.h
ImplementationFile=RequestDlg.cpp
BaseClass=CDialog
Filter=D
LastObject=AUDIO_CONTROL
VirtualFilter=dWC

[DLG:IDD_DIALOG3]
Type=1
Class=?
ControlCount=5
Control1=IDOK,button,1342242817
Control2=IDC_STATIC,button,1342177287
Control3=IDC_SLIDER1,msctls_trackbar32,1342242840
Control4=IDC_STATIC,button,1342177287
Control5=IDC_SLIDER2,msctls_trackbar32,1342242840

