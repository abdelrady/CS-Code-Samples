; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CPlayVideoFilesDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "Play Video Files.h"

ClassCount=3
Class1=CPlayVideoFilesApp
Class2=CPlayVideoFilesDlg
Class3=CAboutDlg

ResourceCount=7
Resource1=IDD_ABOUTBOX
Resource2=IDR_MAINFRAME
Resource3=IDD_PLAYVIDEOFILES_DIALOG
Resource4=IDD_ABOUTBOX (Neutral)
Resource5=IDD_AVIShow (Neutral)
Resource6=IDD_PLAYVIDEOFILES_DIALOG (Neutral)
Resource7=IDR_MENU1

[CLS:CPlayVideoFilesApp]
Type=0
HeaderFile=Play Video Files.h
ImplementationFile=Play Video Files.cpp
Filter=N

[CLS:CPlayVideoFilesDlg]
Type=0
HeaderFile=Play Video FilesDlg.h
ImplementationFile=Play Video FilesDlg.cpp
Filter=C
BaseClass=CDialog
VirtualFilter=dWC
LastObject=ID_FILE_CLIP

[CLS:CAboutDlg]
Type=0
HeaderFile=Play Video FilesDlg.h
ImplementationFile=Play Video FilesDlg.cpp
Filter=D

[DLG:IDD_ABOUTBOX]
Type=1
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308352
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889
Class=CAboutDlg


[DLG:IDD_PLAYVIDEOFILES_DIALOG]
Type=1
ControlCount=3
Control1=IDOK,button,1342242817
Control2=IDCANCEL,button,1342242816
Control3=IDC_STATIC,static,1342308352
Class=CPlayVideoFilesDlg

[DLG:IDD_ABOUTBOX (Neutral)]
Type=1
Class=CAboutDlg
ControlCount=6
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889
Control5=IDC_STATIC,static,1342308352
Control6=IDC_STATIC,static,1342308352

[DLG:IDD_PLAYVIDEOFILES_DIALOG (Neutral)]
Type=1
Class=CPlayVideoFilesDlg
ControlCount=1
Control1=IDC_STATIC,static,1350565892

[DLG:IDD_AVIShow (Neutral)]
Type=1
Class=?
ControlCount=0

[MNU:IDR_MENU1]
Type=1
Class=CPlayVideoFilesDlg
Command1=ID_FILE_OPEN
Command2=ID_FILE_PLAY
Command3=ID_FILE_PUSE
Command4=ID_FILE_RESUME
Command5=ID_FILE_STOP
CommandCount=5

