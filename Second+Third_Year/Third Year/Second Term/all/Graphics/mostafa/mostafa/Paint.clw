; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CPaintView
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "Paint.h"
LastPage=0

ClassCount=6
Class1=CPaintApp
Class2=CPaintDoc
Class3=CPaintView
Class4=CMainFrame

ResourceCount=5
Resource1=IDR_MAINFRAME
Class5=CAboutDlg
Resource2=IDD_SAVE
Class6=FileSavaDlg
Resource3=IDD_ABOUTBOX
Resource4=IDR_MAINFRAME (English (U.S.))
Resource5=IDD_ABOUTBOX (English (U.S.))

[CLS:CPaintApp]
Type=0
HeaderFile=Paint.h
ImplementationFile=Paint.cpp
Filter=N

[CLS:CPaintDoc]
Type=0
HeaderFile=PaintDoc.h
ImplementationFile=PaintDoc.cpp
Filter=N

[CLS:CPaintView]
Type=0
HeaderFile=PaintView.h
ImplementationFile=PaintView.cpp
Filter=C
BaseClass=CView
VirtualFilter=VWC
LastObject=ID_DRAW_CIRCLE


[CLS:CMainFrame]
Type=0
HeaderFile=MainFrm.h
ImplementationFile=MainFrm.cpp
Filter=T
LastObject=CMainFrame
BaseClass=CFrameWnd
VirtualFilter=fWC




[CLS:CAboutDlg]
Type=0
HeaderFile=Paint.cpp
ImplementationFile=Paint.cpp
Filter=D
LastObject=CAboutDlg

[DLG:IDD_ABOUTBOX]
Type=1
Class=CAboutDlg
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889

[MNU:IDR_MAINFRAME]
Type=1
Class=CMainFrame
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_FILE_SAVE_AS
Command5=ID_APP_EXIT
Command6=ID_EDIT_UNDO
Command7=ID_DRAW_LINE
Command8=ID_DRAW_CIRCLE
Command9=ID_DRAW_RECT
Command10=ID_DRAW_FREE
Command11=ID_DRAW_FILL_CIRCLE
Command12=ID_APP_ABOUT
CommandCount=12

[ACL:IDR_MAINFRAME]
Type=1
Class=CMainFrame
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_FILE_PRINT
Command5=ID_EDIT_UNDO
Command6=ID_EDIT_CUT
Command7=ID_EDIT_COPY
Command8=ID_EDIT_PASTE
Command9=ID_EDIT_UNDO
Command10=ID_EDIT_CUT
Command11=ID_EDIT_COPY
Command12=ID_EDIT_PASTE
Command13=ID_NEXT_PANE
Command14=ID_PREV_PANE
CommandCount=14

[TB:IDR_MAINFRAME]
Type=1
Class=?
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_DRAW_LINE
Command5=ID_DRAW_CIRCLE
Command6=ID_DRAW_RECT
Command7=ID_DRAW_FILL_CIRCLE
Command8=ID_APP_ABOUT
CommandCount=8

[DLG:IDD_SAVE]
Type=1
Class=FileSavaDlg
ControlCount=4
Control1=IDOK,button,1342242817
Control2=IDCANCEL,button,1342242816
Control3=IDC_STATIC,static,1342308352
Control4=IDC_FNAME,edit,1350631552

[CLS:FileSavaDlg]
Type=0
HeaderFile=FileSavaDlg.h
ImplementationFile=FileSavaDlg.cpp
BaseClass=CDialog
Filter=D
VirtualFilter=dWC
LastObject=FileSavaDlg

[MNU:IDR_MAINFRAME (English (U.S.))]
Type=1
Class=?
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_FILE_SAVE_AS
Command5=ID_APP_EXIT
Command6=ID_EDIT_UNDO
Command7=ID_DRAW_LINE
Command8=ID_DRAW_CIRCLE
Command9=ID_DRAW_RECT
Command10=ID_DRAW_FREE
Command11=ID_DRAW_FILL_CIRCLE
Command12=ID_APP_ABOUT
CommandCount=12

[DLG:IDD_ABOUTBOX (English (U.S.))]
Type=1
Class=?
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889

[TB:IDR_MAINFRAME (English (U.S.))]
Type=1
Class=?
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_DRAW_LINE
Command5=ID_DRAW_CIRCLE
Command6=ID_DRAW_RECT
Command7=ID_DRAW_FILL_CIRCLE
Command8=ID_APP_ABOUT
CommandCount=8

[ACL:IDR_MAINFRAME (English (U.S.))]
Type=1
Class=?
Command1=ID_FILE_NEW
Command2=ID_FILE_OPEN
Command3=ID_FILE_SAVE
Command4=ID_FILE_PRINT
Command5=ID_EDIT_UNDO
Command6=ID_EDIT_CUT
Command7=ID_EDIT_COPY
Command8=ID_EDIT_PASTE
Command9=ID_EDIT_UNDO
Command10=ID_EDIT_CUT
Command11=ID_EDIT_COPY
Command12=ID_EDIT_PASTE
Command13=ID_NEXT_PANE
Command14=ID_PREV_PANE
CommandCount=14

