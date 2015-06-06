/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

#if !defined(AFX_MAZECREATOR_H__27140F63_0565_46BB_8796_92AED1323881__INCLUDED_)
#define AFX_MAZECREATOR_H__27140F63_0565_46BB_8796_92AED1323881__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// MazeCreator.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// MazeCreator dialog

class MazeCreator : public CDialog
{
// Construction
public:
	CString GetTextBoxInfo();
	CString MazeString;
	MazeCreator(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(MazeCreator)
	enum { IDD = IDD_MAZECREATOR_DIALOG };
	CString	m_CellType1;
	CString	m_CellType2;
	CString	m_CellType3;
	CString	m_CellType4;
	CString	m_CellType5;
	CString	m_CellType6;
	CString	m_CellType7;
	CString	m_CellType8;
	CString	m_CellType9;
	CString	m_CellType10;
	CString	m_CellType11;
	CString	m_CellType12;
	CString	m_CellType13;
	CString	m_CellType14;
	CString	m_CellType15;
	CString	m_CellType16;
	CString	m_CellType17;
	CString	m_CellType18;
	CString	m_CellType19;
	CString	m_CellType20;
	CString	m_CellType21;
	CString	m_CellType22;
	CString	m_CellType23;
	CString	m_CellType24;
	CString	m_CellType25;
	CString	m_CellType26;
	CString	m_CellType27;
	CString	m_CellType28;
	CString	m_CellType29;
	CString	m_CellType30;
	CString	m_CellType31;
	CString	m_CellType32;
	CString	m_CellType33;
	CString	m_CellType34;
	CString	m_CellType35;
	CString	m_CellType36;
	CString	m_CellType37;
	CString	m_CellType38;
	CString	m_CellType39;
	CString	m_CellType40;
	CString	m_CellType41;
	CString	m_CellType42;
	CString	m_CellType43;
	CString	m_CellType44;
	CString	m_CellType45;
	CString	m_CellType46;
	CString	m_CellType47;
	CString	m_CellType48;
	CString	m_CellType49;
	CString	m_CellType50;
	CString	m_CellType51;
	CString	m_CellType52;
	CString	m_CellType53;
	CString	m_CellType54;
	CString	m_CellType55;
	CString	m_CellType56;
	CString	m_CellType57;
	CString	m_CellType58;
	CString	m_CellType59;
	CString	m_CellType60;
	CString	m_CellType61;
	CString	m_CellType62;
	CString	m_CellType63;
	CString	m_CellType64;
	CString	m_CellType65;
	CString	m_CellType66;
	CString	m_CellType67;
	CString	m_CellType68;
	CString	m_CellType69;
	CString	m_CellType70;
	CString	m_CellType71;
	CString	m_CellType72;
	CString	m_CellType73;
	CString	m_CellType74;
	CString	m_CellType75;
	CString	m_CellType76;
	CString	m_CellType77;
	CString	m_CellType78;
	CString	m_CellType79;
	CString	m_CellType80;
	CString	m_CellType81;
	CString	m_CellType82;
	CString	m_CellType83;
	CString	m_CellType84;
	CString	m_CellType85;
	CString	m_CellType86;
	CString	m_CellType87;
	CString	m_CellType88;
	CString	m_CellType89;
	CString	m_CellType90;
	CString	m_CellType91;
	CString	m_CellType92;
	CString	m_CellType93;
	CString	m_CellType94;
	CString	m_CellType95;
	CString	m_CellType96;
	CString	m_CellType97;
	CString	m_CellType98;
	CString	m_CellType99;
	CString	m_CellType100;
	CString	m_CellType101;
	CString	m_CellType102;
	CString	m_CellType103;
	CString	m_CellType104;
	CString	m_CellType105;
	CString	m_CellType106;
	CString	m_CellType107;
	CString	m_CellType108;
	CString	m_CellType109;
	CString	m_CellType110;
	CString	m_CellType111;
	CString	m_CellType112;
	CString	m_CellType113;
	CString	m_CellType114;
	CString	m_CellType115;
	CString	m_CellType116;
	CString	m_CellType117;
	CString	m_CellType118;
	CString	m_CellType119;
	CString	m_CellType120;
	CString	m_CellType121;
	CString	m_CellType122;
	CString	m_CellType123;
	CString	m_CellType124;
	CString	m_CellType125;
	CString	m_CellType126;
	CString	m_CellType127;
	CString	m_CellType128;
	CString	m_CellType129;
	CString	m_CellType130;
	CString	m_CellType131;
	CString	m_CellType132;
	CString	m_CellType133;
	CString	m_CellType134;
	CString	m_CellType135;
	CString	m_CellType136;
	CString	m_CellType137;
	CString	m_CellType138;
	CString	m_CellType139;
	CString	m_CellType140;
	CString	m_CellType141;
	CString	m_CellType142;
	CString	m_CellType143;
	CString	m_CellType144;
	CString	m_CellType145;
	CString	m_CellType146;
	CString	m_CellType147;
	CString	m_CellType148;
	CString	m_CellType149;
	CString	m_CellType150;
	CString	m_CellType151;
	CString	m_CellType152;
	CString	m_CellType153;
	CString	m_CellType154;
	CString	m_CellType155;
	CString	m_CellType156;
	CString	m_CellType157;
	CString	m_CellType158;
	CString	m_CellType159;
	CString	m_CellType160;
	CString	m_CellType161;
	CString	m_CellType162;
	CString	m_CellType163;
	CString	m_CellType164;
	CString	m_CellType165;
	CString	m_CellType166;
	CString	m_CellType167;
	CString	m_CellType168;
	CString	m_CellType169;
	CString	m_CellType170;
	CString	m_CellType171;
	CString	m_CellType172;
	CString	m_CellType173;
	CString	m_CellType174;
	CString	m_CellType175;
	CString	m_CellType176;
	CString	m_CellType177;
	CString	m_CellType178;
	CString	m_CellType179;
	CString	m_CellType180;
	CString	m_CellType181;
	CString	m_CellType182;
	CString	m_CellType183;
	CString	m_CellType184;
	CString	m_CellType185;
	CString	m_CellType186;
	CString	m_CellType187;
	CString	m_CellType188;
	CString	m_CellType189;
	CString	m_CellType190;
	CString	m_CellType191;
	CString	m_CellType192;
	CString	m_CellType193;
	CString	m_CellType194;
	CString	m_CellType195;
	CString	m_CellType196;
	CString	m_CellType197;
	CString	m_CellType198;
	CString	m_CellType199;
	CString	m_CellType200;
	CString	m_CellType201;
	CString	m_CellType202;
	CString	m_CellType203;
	CString	m_CellType204;
	CString	m_CellType205;
	CString	m_CellType206;
	CString	m_CellType207;
	CString	m_CellType208;
	CString	m_CellType209;
	CString	m_CellType210;
	CString	m_CellType211;
	CString	m_CellType212;
	CString	m_CellType213;
	CString	m_CellType214;
	CString	m_CellType215;
	CString	m_CellType216;
	CString	m_CellType217;
	CString	m_CellType218;
	CString	m_CellType219;
	CString	m_CellType220;
	CString	m_CellType221;
	CString	m_CellType222;
	CString	m_CellType223;
	CString	m_CellType224;
	CString	m_CellType225;
	CString	m_CellType226;
	CString	m_CellType227;
	CString	m_CellType228;
	CString	m_CellType229;
	CString	m_CellType230;
	CString	m_CellType231;
	CString	m_CellType232;
	CString	m_CellType233;
	CString	m_CellType234;
	CString	m_CellType235;
	CString	m_CellType236;
	CString	m_CellType237;
	CString	m_CellType238;
	CString	m_CellType239;
	CString	m_CellType240;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(MazeCreator)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(MazeCreator)
	afx_msg void OnPreviewMaze();
	afx_msg void OnSaveMaze();
	afx_msg void OnLoadMaze();
	afx_msg void OnClose();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAZECREATOR_H__27140F63_0565_46BB_8796_92AED1323881__INCLUDED_)
