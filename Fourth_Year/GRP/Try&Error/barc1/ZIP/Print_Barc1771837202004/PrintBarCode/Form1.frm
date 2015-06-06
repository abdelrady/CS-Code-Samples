VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   4050
   ClientLeft      =   2415
   ClientTop       =   2880
   ClientWidth     =   5655
   LinkTopic       =   "Form1"
   ScaleHeight     =   4050
   ScaleWidth      =   5655
   Begin VB.TextBox txtUOM 
      Height          =   375
      Left            =   120
      TabIndex        =   15
      Text            =   "QUANTITY"
      Top             =   3480
      Width           =   2655
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Print"
      Height          =   495
      Left            =   4320
      TabIndex        =   14
      Top             =   3480
      Width           =   1215
   End
   Begin VB.TextBox txtDO 
      Height          =   375
      Left            =   2880
      TabIndex        =   13
      Text            =   "805275154236"
      Top             =   3000
      Width           =   2655
   End
   Begin VB.TextBox txtST 
      Height          =   375
      Left            =   120
      TabIndex        =   12
      Text            =   "015"
      Top             =   3000
      Width           =   2655
   End
   Begin VB.TextBox txtTOLine 
      Height          =   375
      Left            =   2880
      TabIndex        =   11
      Text            =   "1"
      Top             =   2520
      Width           =   2655
   End
   Begin VB.TextBox txtTO 
      Height          =   375
      Left            =   120
      TabIndex        =   10
      Text            =   "1500711315"
      Top             =   2520
      Width           =   2655
   End
   Begin VB.TextBox txtCustPart 
      Height          =   375
      Left            =   2880
      TabIndex        =   9
      Text            =   "934618964326"
      Top             =   2040
      Width           =   2655
   End
   Begin VB.TextBox txtCustRef 
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Text            =   "QWER18647"
      Top             =   2040
      Width           =   2655
   End
   Begin VB.TextBox txtLine 
      Height          =   375
      Left            =   2880
      TabIndex        =   7
      Text            =   "10"
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txtSO 
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Text            =   "6432123463"
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txtDesc 
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Text            =   "MICROSOFT CORPORATION"
      Top             =   1080
      Width           =   2655
   End
   Begin VB.TextBox txtQty 
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Text            =   "1"
      Top             =   1080
      Width           =   2655
   End
   Begin VB.TextBox txtSn 
      Height          =   375
      Left            =   2880
      TabIndex        =   3
      Text            =   "P/N34524234"
      Top             =   600
      Width           =   2655
   End
   Begin VB.TextBox txtOldPart 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Text            =   "(111111111111111111111)"
      Top             =   600
      Width           =   2655
   End
   Begin VB.TextBox txtBatch 
      Height          =   375
      Left            =   2880
      TabIndex        =   1
      Text            =   "ZA5436346"
      Top             =   120
      Width           =   2655
   End
   Begin VB.TextBox txtPart 
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Text            =   "45R32Z45S"
      Top             =   120
      Width           =   2655
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
  PrintBarCode "d", 1, 1, "s"
End Sub

Public Sub PrintBarCode(TransNo As String, LineNo As Long, QtyStored As Long, SerialNo As String)
  'Note: No spaces is allowed in the double-qoute of barcode printing syntax
  'BarCode Printer Model : B-572-QP (Toshiba Tec)
  
  Dim ESC: Dim LF: Dim NUL
  
  ESC = Chr$(&H1B): LF = Chr$(&HA): NUL = Chr$(&H0)
  
  Open "LPT1" For Output As #1
    'Set initial setting
    Print #1, ESC; "AY;+00,0"; LF; NUL;
    Print #1, ESC; "D0980,1280,0940"; LF; NUL;

    Print #1, ESC; "C"; LF; NUL;

    Print #1, ESC; "XR;0000,0000,1280,0940,A"; LF; NUL;
    Print #1, ESC; "AX;+000,+000,+00"; LF; NUL;
    Print #1, ESC; "U2;0130"; LF; NUL;

    'Print barcode parameters
    Print #1, ESC; "XB01;0050,0150,3,1,03,03,07,07,02,0,0090,+0000000000,0,00"; LF; NUL; 'PartNo Barcode
    Print #1, ESC; "XB02;0810,0150,3,1,03,03,07,07,02,0,0090,+0000000000,0,00"; LF; NUL; 'BatchNo Barcode
    Print #1, ESC; "XB03;0050,0645,3,1,03,03,07,07,02,0,0090,+0000000000,0,00"; LF; NUL; 'Transfer Order Barcode
    Print #1, ESC; "XB04;0810,0645,3,1,03,03,07,07,02,0,0090,+0000000000,0,00"; LF; NUL; 'DeliveryNo Barcode

    'Print label heading parameters
    Print #1, ESC; "PC001;0050,0290,05,05,M,+00,00,B"; LF; NUL; 'PartNo
    Print #1, ESC; "PC002;0830,0290,05,05,M,+00,00,B"; LF; NUL; 'BatchNo
    Print #1, ESC; "PC003;0050,0340,05,05,M,+00,00,B"; LF; NUL; 'Old Part No
    Print #1, ESC; "PC004;0050,0390,05,05,M,+00,00,B"; LF; NUL; 'SerialNo
    Print #1, ESC; "PC005;0830,0390,05,05,M,+00,00,B"; LF; NUL; 'Qty + UOM
    Print #1, ESC; "PC006;0050,0440,05,05,M,+00,00,B"; LF; NUL; 'Description
    Print #1, ESC; "PC007;0050,0490,05,05,M,+00,00,B"; LF; NUL; 'Sales Order No
    Print #1, ESC; "PC008;0830,0490,05,05,M,+00,00,B"; LF; NUL; 'Sales LineNo
    Print #1, ESC; "PC009;0050,0540,05,05,M,+00,00,B"; LF; NUL; 'Cust RefNo
    Print #1, ESC; "PC010;0050,0590,05,05,M,+00,00,B"; LF; NUL; 'Cust Part No
    Print #1, ESC; "PC011;0130,0800,05,05,M,+00,00,B"; LF; NUL; 'Transfer Order
    Print #1, ESC; "PC012;0480,0800,05,05,M,+00,00,B"; LF; NUL; 'Transfer LineNo
    Print #1, ESC; "PC013;0780,0800,05,05,M,+00,00,B"; LF; NUL; 'Storage Type
    Print #1, ESC; "PC014;1080,0800,05,05,M,+00,00,B"; LF; NUL; 'DeliveryNo
    Print #1, ESC; "PC015;0070,0920,05,05,M,+00,00,B"; LF; NUL; 'Footer

    'Print label information parameters
    Print #1, ESC; "PC016;0290,0290,2,2,G,+00,00,B"; LF; NUL; 'PartNo
    Print #1, ESC; "PC017;0950,0290,2,2,G,+00,00,B"; LF; NUL; 'BatchNo
    Print #1, ESC; "PC018;0310,0340,2,2,G,+00,00,B"; LF; NUL; 'Old Part No
    Print #1, ESC; "PC019;0265,0390,2,2,G,+00,00,B"; LF; NUL; 'SerialNo
    Print #1, ESC; "PC020;0940,0390,2,2,G,+00,00,B"; LF; NUL; 'Qty + UOM
    Print #1, ESC; "PC021;0290,0440,2,2,G,+00,00,B"; LF; NUL; 'Description
    Print #1, ESC; "PC022;0445,0490,2,2,G,+00,00,B"; LF; NUL; 'Sales Order No
    Print #1, ESC; "PC023;0940,0490,2,2,G,+00,00,B"; LF; NUL; 'Sales LineNo
    Print #1, ESC; "PC024;0270,0540,2,2,G,+00,00,B"; LF; NUL; 'Cust RefNo
    Print #1, ESC; "PC025;0350,0590,2,2,G,+00,00,B"; LF; NUL; 'Cust Part No
    Print #1, ESC; "PC026;0070,0850,2,2,G,+00,00,B"; LF; NUL; 'Transfer Order
    Print #1, ESC; "PC027;0480,0850,2,2,G,+00,00,B"; LF; NUL; 'Transfer LineNo
    Print #1, ESC; "PC028;0740,0850,2,2,G,+00,00,B"; LF; NUL; 'Storage Type
    Print #1, ESC; "PC029;0980,0850,2,2,G,+00,00,B"; LF; NUL; 'DeliveryNo
    
    'Stamp heading to print
    Print #1, ESC; "RC001;Part Number:"; LF; NUL;  'PartNo
    Print #1, ESC; "RC002;Batch:"; LF; NUL;  'BatchNo
    Print #1, ESC; "RC003;Old Part No.:"; LF; NUL;  'Old Part No
    Print #1, ESC; "RC004;Serial No.:"; LF; NUL;  'SerialNo
    Print #1, ESC; "RC005;Qty.:"; LF; NUL; 'Qty + UOM
    Print #1, ESC; "RC006;Description:"; LF; NUL;  'Description
    Print #1, ESC; "RC007;MTU Sales Order No.:"; LF; NUL;  'Sales Order No
    Print #1, ESC; "RC008;Line:"; LF; NUL;  'Sales LineNo
    Print #1, ESC; "RC009;Cust. Ref.:"; LF; NUL;  'Cust RefNo
    Print #1, ESC; "RC010;Cust. Part No.:"; LF; NUL;  'Cust Part No
    Print #1, ESC; "RC011;TO"; LF; NUL; 'Transfer Order
    Print #1, ESC; "RC012;TO LINE"; LF; NUL;  'Transfer LineNo
    Print #1, ESC; "RC013;ST"; LF; NUL;  'Storage Type
    Print #1, ESC; "RC014;DN"; LF; NUL;  'DeliveryNo
    Print #1, ESC; "RC015;Proper storage and preservation of parts prolong shelf life"; LF; NUL;  'Footer

    'Stamp data to print
    Print #1, ESC; "RB01;" & txtPart & ""; LF; NUL;  'PartNo Barcode
    If txtBatch <> "" Then Print #1, ESC; "RB02;" & txtBatch & ""; LF; NUL; 'BatchNo Barcode
    Print #1, ESC; "RB03;" & txtTO & ""; LF; NUL;  'Transfer Order Barcode
    If txtDO <> "" Then Print #1, ESC; "RB04;" & txtDO & ""; LF; NUL;  'DeliveryNo Barcode

    Print #1, ESC; "RC016;" & txtPart & ""; LF; NUL;  'PartNo
    If txtBatch <> "" Then Print #1, ESC; "RC017;" & txtBatch & ""; LF; NUL;  'BatchNo
    If txtOldPart <> "" Then Print #1, ESC; "RC018;" & txtOldPart & ""; LF; NUL;  'Old Part No
    If txtSn <> "0" Then Print #1, ESC; "RC019;" & txtSn & ""; LF; NUL;  'SerialNo
    Print #1, ESC; "RC020;" & Form1 & " " & IIf(txtUOM <> "", txtUOM, "") & ""; LF; NUL; 'Qty + UOM
    If txtDesc <> "" Then Print #1, ESC; "RC021;" & txtDesc & ""; LF; NUL;  'Description
    If txtSO <> "" Then Print #1, ESC; "RC022;" & txtSO & ""; LF; NUL;  'Sales Order No
    If txtLine <> "" Then Print #1, ESC; "RC023;" & txtLine & ""; LF; NUL;  'Sales LineNo
    If txtCustRef <> "" Then Print #1, ESC; "RC024;" & txtCustRef & ""; LF; NUL;  'Cust RefNo
    If txtCustPart <> "" Then Print #1, ESC; "RC025;" & txtCustPart & ""; LF; NUL;  'Cust Part No
    Print #1, ESC; "RC026;" & txtTO & ""; LF; NUL; 'Transfer Order
    Print #1, ESC; "RC027;" & txtTOLine & ""; LF; NUL;  'Transfer LineNo
    If txtST <> "" Then Print #1, ESC; "RC028;" & txtST & ""; LF; NUL;  'Storage Type
    If txtDO <> "" Then Print #1, ESC; "RC029;" & txtDO & ""; LF; NUL;  'DeliveryNo
    
    Print #1, ESC; "LC;0050,0755,1280,0755,0,4"; LF; NUL; 'Horizontal Seperator
    Print #1, ESC; "LC;0050,0875,1280,0875,0,4"; LF; NUL; 'Horizontal Separator
    Print #1, ESC; "LC;0420,0755,0420,0875,0,4"; LF; NUL; 'Vertical Separator
    Print #1, ESC; "LC;0710,0755,0710,0875,0,4"; LF; NUL; 'Vertical Separator
    Print #1, ESC; "LC;0960,0755,0960,0875,0,4"; LF; NUL; 'Vertical Separator

    'Print barcode
    Print #1, ESC; "XS;I,0001,0003C3100"; LF; NUL;
    Print #1, ESC; "U1;0130"; LF; NUL

  Close #1
  
End Sub
