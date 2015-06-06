/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

#if !defined(AFX_MAZEWINDOW_H__11B619C0_0221_4FBD_AF6F_1BD0690C68FD__INCLUDED_)
#define AFX_MAZEWINDOW_H__11B619C0_0221_4FBD_AF6F_1BD0690C68FD__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// MazeWindow.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// MazeWindow dialog

class MazeWindow : public CDialog
{
// Construction
public:

	
	//Y Position of the player 
	int manY;
	//X Position of the player
	int manX;

	//The 2D array containing a likness of the maze grid
	char MazeGrid[20][12];

	//The char Array that will hold the string of characters that represent the maze
	char TheMaze[241];

	//Function prototype that will determine which AVI to play depending on a character
	CString DetermineAVI(char CellType);

	//Function Prototype to redraw the maze when it has changed
	void DrawScreen(char* MazeConfig);
	MazeWindow(CWnd* pParent = NULL);   // standard constructor

	bool PlayerFoundExit;
	bool ComputerSolved;

// Dialog Data
	//{{AFX_DATA(MazeWindow)
	enum { IDD = IDD_MAZEWINDOW_DIALOG };
	CAnimateCtrl	m_grid84;
	CAnimateCtrl	m_grid48;
	CAnimateCtrl	m_grid99;
	CAnimateCtrl	m_grid98;
	CAnimateCtrl	m_grid97;
	CAnimateCtrl	m_grid96;
	CAnimateCtrl	m_grid95;
	CAnimateCtrl	m_grid94;
	CAnimateCtrl	m_grid93;
	CAnimateCtrl	m_grid92;
	CAnimateCtrl	m_grid91;
	CAnimateCtrl	m_grid90;
	CAnimateCtrl	m_grid9;
	CAnimateCtrl	m_grid89;
	CAnimateCtrl	m_grid88;
	CAnimateCtrl	m_grid87;
	CAnimateCtrl	m_grid86;
	CAnimateCtrl	m_grid85;
	CAnimateCtrl	m_grid83;
	CAnimateCtrl	m_grid82;
	CAnimateCtrl	m_grid81;
	CAnimateCtrl	m_grid80;
	CAnimateCtrl	m_grid8;
	CAnimateCtrl	m_grid79;
	CAnimateCtrl	m_grid78;
	CAnimateCtrl	m_grid77;
	CAnimateCtrl	m_grid76;
	CAnimateCtrl	m_grid75;
	CAnimateCtrl	m_grid74;
	CAnimateCtrl	m_grid73;
	CAnimateCtrl	m_grid72;
	CAnimateCtrl	m_grid71;
	CAnimateCtrl	m_grid70;
	CAnimateCtrl	m_grid7;
	CAnimateCtrl	m_grid69;
	CAnimateCtrl	m_grid68;
	CAnimateCtrl	m_grid67;
	CAnimateCtrl	m_grid66;
	CAnimateCtrl	m_grid65;
	CAnimateCtrl	m_grid64;
	CAnimateCtrl	m_grid63;
	CAnimateCtrl	m_grid62;
	CAnimateCtrl	m_grid61;
	CAnimateCtrl	m_grid60;
	CAnimateCtrl	m_grid6;
	CAnimateCtrl	m_grid59;
	CAnimateCtrl	m_grid58;
	CAnimateCtrl	m_grid57;
	CAnimateCtrl	m_grid56;
	CAnimateCtrl	m_grid55;
	CAnimateCtrl	m_grid54;
	CAnimateCtrl	m_grid53;
	CAnimateCtrl	m_grid52;
	CAnimateCtrl	m_grid51;
	CAnimateCtrl	m_grid50;
	CAnimateCtrl	m_grid5;
	CAnimateCtrl	m_grid49;
	CAnimateCtrl	m_grid47;
	CAnimateCtrl	m_grid46;
	CAnimateCtrl	m_grid45;
	CAnimateCtrl	m_grid44;
	CAnimateCtrl	m_grid43;
	CAnimateCtrl	m_grid42;
	CAnimateCtrl	m_grid41;
	CAnimateCtrl	m_grid40;
	CAnimateCtrl	m_grid4;
	CAnimateCtrl	m_grid39;
	CAnimateCtrl	m_grid38;
	CAnimateCtrl	m_grid37;
	CAnimateCtrl	m_grid36;
	CAnimateCtrl	m_grid35;
	CAnimateCtrl	m_grid34;
	CAnimateCtrl	m_grid33;
	CAnimateCtrl	m_grid32;
	CAnimateCtrl	m_grid31;
	CAnimateCtrl	m_grid30;
	CAnimateCtrl	m_grid3;
	CAnimateCtrl	m_grid29;
	CAnimateCtrl	m_grid28;
	CAnimateCtrl	m_grid27;
	CAnimateCtrl	m_grid26;
	CAnimateCtrl	m_grid25;
	CAnimateCtrl	m_grid240;
	CAnimateCtrl	m_grid24;
	CAnimateCtrl	m_grid239;
	CAnimateCtrl	m_grid238;
	CAnimateCtrl	m_grid237;
	CAnimateCtrl	m_grid236;
	CAnimateCtrl	m_grid235;
	CAnimateCtrl	m_grid234;
	CAnimateCtrl	m_grid233;
	CAnimateCtrl	m_grid232;
	CAnimateCtrl	m_grid231;
	CAnimateCtrl	m_grid230;
	CAnimateCtrl	m_grid23;
	CAnimateCtrl	m_grid229;
	CAnimateCtrl	m_grid228;
	CAnimateCtrl	m_grid227;
	CAnimateCtrl	m_grid226;
	CAnimateCtrl	m_grid225;
	CAnimateCtrl	m_grid224;
	CAnimateCtrl	m_grid223;
	CAnimateCtrl	m_grid222;
	CAnimateCtrl	m_grid221;
	CAnimateCtrl	m_grid220;
	CAnimateCtrl	m_grid22;
	CAnimateCtrl	m_grid219;
	CAnimateCtrl	m_grid217;
	CAnimateCtrl	m_grid218;
	CAnimateCtrl	m_grid216;
	CAnimateCtrl	m_grid215;
	CAnimateCtrl	m_grid214;
	CAnimateCtrl	m_grid213;
	CAnimateCtrl	m_grid212;
	CAnimateCtrl	m_grid211;
	CAnimateCtrl	m_grid210;
	CAnimateCtrl	m_grid21;
	CAnimateCtrl	m_grid209;
	CAnimateCtrl	m_grid208;
	CAnimateCtrl	m_grid207;
	CAnimateCtrl	m_grid206;
	CAnimateCtrl	m_grid205;
	CAnimateCtrl	m_grid204;
	CAnimateCtrl	m_grid203;
	CAnimateCtrl	m_grid202;
	CAnimateCtrl	m_grid201;
	CAnimateCtrl	m_grid200;
	CAnimateCtrl	m_grid20;
	CAnimateCtrl	m_grid2;
	CAnimateCtrl	m_grid199;
	CAnimateCtrl	m_grid198;
	CAnimateCtrl	m_grid197;
	CAnimateCtrl	m_grid196;
	CAnimateCtrl	m_grid195;
	CAnimateCtrl	m_grid194;
	CAnimateCtrl	m_grid193;
	CAnimateCtrl	m_grid192;
	CAnimateCtrl	m_grid191;
	CAnimateCtrl	m_grid190;
	CAnimateCtrl	m_grid19;
	CAnimateCtrl	m_grid189;
	CAnimateCtrl	m_grid188;
	CAnimateCtrl	m_grid187;
	CAnimateCtrl	m_grid186;
	CAnimateCtrl	m_grid185;
	CAnimateCtrl	m_grid184;
	CAnimateCtrl	m_grid183;
	CAnimateCtrl	m_grid182;
	CAnimateCtrl	m_grid181;
	CAnimateCtrl	m_grid180;
	CAnimateCtrl	m_grid18;
	CAnimateCtrl	m_grid179;
	CAnimateCtrl	m_grid178;
	CAnimateCtrl	m_grid177;
	CAnimateCtrl	m_grid176;
	CAnimateCtrl	m_grid175;
	CAnimateCtrl	m_grid174;
	CAnimateCtrl	m_grid173;
	CAnimateCtrl	m_grid172;
	CAnimateCtrl	m_grid171;
	CAnimateCtrl	m_grid170;
	CAnimateCtrl	m_grid17;
	CAnimateCtrl	m_grid169;
	CAnimateCtrl	m_grid168;
	CAnimateCtrl	m_grid167;
	CAnimateCtrl	m_grid166;
	CAnimateCtrl	m_grid165;
	CAnimateCtrl	m_grid164;
	CAnimateCtrl	m_grid163;
	CAnimateCtrl	m_grid162;
	CAnimateCtrl	m_grid161;
	CAnimateCtrl	m_grid160;
	CAnimateCtrl	m_grid16;
	CAnimateCtrl	m_grid159;
	CAnimateCtrl	m_grid158;
	CAnimateCtrl	m_grid157;
	CAnimateCtrl	m_grid156;
	CAnimateCtrl	m_grid155;
	CAnimateCtrl	m_grid154;
	CAnimateCtrl	m_grid153;
	CAnimateCtrl	m_grid152;
	CAnimateCtrl	m_grid151;
	CAnimateCtrl	m_grid150;
	CAnimateCtrl	m_grid15;
	CAnimateCtrl	m_grid149;
	CAnimateCtrl	m_grid148;
	CAnimateCtrl	m_grid147;
	CAnimateCtrl	m_grid146;
	CAnimateCtrl	m_grid145;
	CAnimateCtrl	m_grid144;
	CAnimateCtrl	m_grid143;
	CAnimateCtrl	m_grid142;
	CAnimateCtrl	m_grid141;
	CAnimateCtrl	m_grid140;
	CAnimateCtrl	m_grid14;
	CAnimateCtrl	m_grid139;
	CAnimateCtrl	m_grid138;
	CAnimateCtrl	m_grid137;
	CAnimateCtrl	m_grid136;
	CAnimateCtrl	m_grid135;
	CAnimateCtrl	m_grid134;
	CAnimateCtrl	m_grid133;
	CAnimateCtrl	m_grid132;
	CAnimateCtrl	m_grid131;
	CAnimateCtrl	m_grid130;
	CAnimateCtrl	m_grid13;
	CAnimateCtrl	m_grid129;
	CAnimateCtrl	m_grid128;
	CAnimateCtrl	m_grid127;
	CAnimateCtrl	m_grid126;
	CAnimateCtrl	m_grid125;
	CAnimateCtrl	m_grid124;
	CAnimateCtrl	m_grid123;
	CAnimateCtrl	m_grid122;
	CAnimateCtrl	m_grid121;
	CAnimateCtrl	m_grid120;
	CAnimateCtrl	m_grid12;
	CAnimateCtrl	m_grid119;
	CAnimateCtrl	m_grid118;
	CAnimateCtrl	m_grid117;
	CAnimateCtrl	m_grid116;
	CAnimateCtrl	m_grid115;
	CAnimateCtrl	m_grid114;
	CAnimateCtrl	m_grid113;
	CAnimateCtrl	m_grid112;
	CAnimateCtrl	m_grid111;
	CAnimateCtrl	m_grid110;
	CAnimateCtrl	m_grid11;
	CAnimateCtrl	m_grid109;
	CAnimateCtrl	m_grid108;
	CAnimateCtrl	m_grid107;
	CAnimateCtrl	m_grid106;
	CAnimateCtrl	m_grid105;
	CAnimateCtrl	m_grid104;
	CAnimateCtrl	m_grid103;
	CAnimateCtrl	m_grid102;
	CAnimateCtrl	m_grid101;
	CAnimateCtrl	m_grid100;
	CAnimateCtrl	m_grid10;
	CAnimateCtrl	m_grid1;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(MazeWindow)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(MazeWindow)
	virtual BOOL OnInitDialog();
	afx_msg void OnSolve();
	afx_msg void OnClose();
	afx_msg void OnUP();
	afx_msg void OnDOWN();
	afx_msg void OnLEFT();
	afx_msg void OnRIGHT();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAZEWINDOW_H__11B619C0_0221_4FBD_AF6F_1BD0690C68FD__INCLUDED_)
