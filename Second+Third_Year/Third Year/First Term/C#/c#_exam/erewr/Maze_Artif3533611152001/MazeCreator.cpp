// MazeCreator.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "MazeCreator.h"
#include "MazeWindow.h"
#include "FileSaveLoad.h"
#include <fstream.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// MazeCreator dialog


MazeCreator::MazeCreator(CWnd* pParent /*=NULL*/)
	: CDialog(MazeCreator::IDD, pParent)
{
	//{{AFX_DATA_INIT(MazeCreator)

	MazeString = "";

	m_CellType1 = "b";
	m_CellType2 = "b";
	m_CellType3 = "b";
	m_CellType4 = "b";
	m_CellType5 = "b";
	m_CellType6 = "b";
	m_CellType7 = "b";
	m_CellType8 = "b";
	m_CellType9 = "b";
	m_CellType10 = "b";
	m_CellType11 = "b";
	m_CellType12 = "b";
	m_CellType13 = "b";
	m_CellType14 = "b";
	m_CellType15 = "b";
	m_CellType16 = "b";
	m_CellType17 = "b";
	m_CellType18 = "b";
	m_CellType19 = "b";
	m_CellType20 = "b";
	m_CellType21 = "b";
	m_CellType22 = "b";
	m_CellType23 = "b";
	m_CellType24 = "b";
	m_CellType25 = "b";
	m_CellType26 = "b";
	m_CellType27 = "b";
	m_CellType28 = "b";
	m_CellType29 = "b";
	m_CellType30 = "b";
	m_CellType31 = "b";
	m_CellType32 = "b";
	m_CellType33 = "b";
	m_CellType34 = "b";
	m_CellType35 = "b";
	m_CellType36 = "b";
	m_CellType37 = "b";
	m_CellType38 = "b";
	m_CellType39 = "b";
	m_CellType40 = "b";
	m_CellType41 = "b";
	m_CellType42 = "b";
	m_CellType43 = "b";
	m_CellType44 = "b";
	m_CellType45 = "b";
	m_CellType46 = "b";
	m_CellType47 = "b";
	m_CellType48 = "b";
	m_CellType49 = "b";
	m_CellType50 = "b";
	m_CellType51 = "b";
	m_CellType52 = "b";
	m_CellType53 = "b";
	m_CellType54 = "b";
	m_CellType55 = "b";
	m_CellType56 = "b";
	m_CellType57 = "b";
	m_CellType58 = "b";
	m_CellType59 = "b";
	m_CellType60 = "b";
	m_CellType61 = "b";
	m_CellType62 = "b";
	m_CellType63 = "b";
	m_CellType64 = "b";
	m_CellType65 = "b";
	m_CellType66 = "b";
	m_CellType67 = "b";
	m_CellType68 = "b";
	m_CellType69 = "b";
	m_CellType70 = "b";
	m_CellType71 = "b";
	m_CellType72 = "b";
	m_CellType73 = "b";
	m_CellType74 = "b";
	m_CellType75 = "b";
	m_CellType76 = "b";
	m_CellType77 = "b";
	m_CellType78 = "b";
	m_CellType79 = "b";
	m_CellType80 = "b";
	m_CellType81 = "b";
	m_CellType82 = "b";
	m_CellType83 = "b";
	m_CellType84 = "b";
	m_CellType85 = "b";
	m_CellType86 = "b";
	m_CellType87 = "b";
	m_CellType88 = "b";
	m_CellType89 = "b";
	m_CellType90 = "b";
	m_CellType91 = "b";
	m_CellType92 = "b";
	m_CellType93 = "b";
	m_CellType94 = "b";
	m_CellType95 = "b";
	m_CellType96 = "b";
	m_CellType97 = "b";
	m_CellType98 = "b";
	m_CellType99 = "b";
	m_CellType100 = "b";
	m_CellType101 = "b";
	m_CellType102 = "b";
	m_CellType103 = "b";
	m_CellType104 = "b";
	m_CellType105 = "b";
	m_CellType106 = "b";
	m_CellType107 = "b";
	m_CellType108 = "b";
	m_CellType109 = "b";
	m_CellType110 = "b";
	m_CellType111 = "b";
	m_CellType112 = "b";
	m_CellType113 = "b";
	m_CellType114 = "b";
	m_CellType115 = "b";
	m_CellType116 = "b";
	m_CellType117 = "b";
	m_CellType118 = "b";
	m_CellType119 = "b";
	m_CellType120 = "b";
	m_CellType121 = "b";
	m_CellType122 = "b";
	m_CellType123 = "b";
	m_CellType124 = "b";
	m_CellType125 = "b";
	m_CellType126 = "b";
	m_CellType127 = "b";
	m_CellType128 = "b";
	m_CellType129 = "b";
	m_CellType130 = "b";
	m_CellType131 = "b";
	m_CellType132 = "b";
	m_CellType133 = "b";
	m_CellType134 = "b";
	m_CellType135 = "b";
	m_CellType136 = "b";
	m_CellType137 = "b";
	m_CellType138 = "b";
	m_CellType139 = "b";
	m_CellType140 = "b";
	m_CellType141 = "b";
	m_CellType142 = "b";
	m_CellType143 = "b";
	m_CellType144 = "b";
	m_CellType145 = "b";
	m_CellType146 = "b";
	m_CellType147 = "b";
	m_CellType148 = "b";
	m_CellType149 = "b";
	m_CellType150 = "b";
	m_CellType151 = "b";
	m_CellType152 = "b";
	m_CellType153 = "b";
	m_CellType154 = "b";
	m_CellType155 = "b";
	m_CellType156 = "b";
	m_CellType157 = "b";
	m_CellType158 = "b";
	m_CellType159 = "b";
	m_CellType160 = "b";
	m_CellType161 = "b";
	m_CellType162 = "b";
	m_CellType163 = "b";
	m_CellType164 = "b";
	m_CellType165 = "b";
	m_CellType166 = "b";
	m_CellType167 = "b";
	m_CellType168 = "b";
	m_CellType169 = "b";
	m_CellType170 = "b";
	m_CellType171 = "b";
	m_CellType172 = "b";
	m_CellType173 = "b";
	m_CellType174 = "b";
	m_CellType175 = "b";
	m_CellType176 = "b";
	m_CellType177 = "b";
	m_CellType178 = "b";
	m_CellType179 = "b";
	m_CellType180 = "b";
	m_CellType181 = "b";
	m_CellType182 = "b";
	m_CellType183 = "b";
	m_CellType184 = "b";
	m_CellType185 = "b";
	m_CellType186 = "b";
	m_CellType187 = "b";
	m_CellType188 = "b";
	m_CellType189 = "b";
	m_CellType190 = "b";
	m_CellType191 = "b";
	m_CellType192 = "b";
	m_CellType193 = "b";
	m_CellType194 = "b";
	m_CellType195 = "b";
	m_CellType196 = "b";
	m_CellType197 = "b";
	m_CellType198 = "b";
	m_CellType199 = "b";
	m_CellType200 = "b";
	m_CellType201 = "b";
	m_CellType202 = "b";
	m_CellType203 = "b";
	m_CellType204 = "b";
	m_CellType205 = "b";
	m_CellType206 = "b";
	m_CellType207 = "b";
	m_CellType208 = "b";
	m_CellType209 = "b";
	m_CellType210 = "b";
	m_CellType211 = "b";
	m_CellType212 = "b";
	m_CellType213 = "b";
	m_CellType214 = "b";
	m_CellType215 = "b";
	m_CellType216 = "b";
	m_CellType217 = "b";
	m_CellType218 = "b";
	m_CellType219 = "b";
	m_CellType220 = "b";
	m_CellType221 = "b";
	m_CellType222 = "b";
	m_CellType223 = "b";
	m_CellType224 = "b";
	m_CellType225 = "b";
	m_CellType226 = "b";
	m_CellType227 = "b";
	m_CellType228 = "b";
	m_CellType229 = "b";
	m_CellType230 = "b";
	m_CellType231 = "b";
	m_CellType232 = "b";
	m_CellType233 = "b";
	m_CellType234 = "b";
	m_CellType235 = "b";
	m_CellType236 = "b";
	m_CellType237 = "b";
	m_CellType238 = "b";
	m_CellType239 = "b";
	m_CellType240 = "b";
	//}}AFX_DATA_INIT
}


void MazeCreator::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(MazeCreator)
	DDX_Text(pDX, IDC_EDIT1, m_CellType1);
	DDV_MaxChars(pDX, m_CellType1, 1);
	DDX_Text(pDX, IDC_EDIT2, m_CellType2);
	DDV_MaxChars(pDX, m_CellType2, 1);
	DDX_Text(pDX, IDC_EDIT3, m_CellType3);
	DDV_MaxChars(pDX, m_CellType3, 1);
	DDX_Text(pDX, IDC_EDIT4, m_CellType4);
	DDV_MaxChars(pDX, m_CellType4, 1);
	DDX_Text(pDX, IDC_EDIT5, m_CellType5);
	DDV_MaxChars(pDX, m_CellType5, 1);
	DDX_Text(pDX, IDC_EDIT6, m_CellType6);
	DDV_MaxChars(pDX, m_CellType6, 1);
	DDX_Text(pDX, IDC_EDIT7, m_CellType7);
	DDV_MaxChars(pDX, m_CellType7, 1);
	DDX_Text(pDX, IDC_EDIT8, m_CellType8);
	DDV_MaxChars(pDX, m_CellType8, 1);
	DDX_Text(pDX, IDC_EDIT9, m_CellType9);
	DDV_MaxChars(pDX, m_CellType9, 1);
	DDX_Text(pDX, IDC_EDIT10, m_CellType10);
	DDV_MaxChars(pDX, m_CellType10, 1);
	DDX_Text(pDX, IDC_EDIT11, m_CellType11);
	DDV_MaxChars(pDX, m_CellType11, 1);
	DDX_Text(pDX, IDC_EDIT12, m_CellType12);
	DDV_MaxChars(pDX, m_CellType12, 1);
	DDX_Text(pDX, IDC_EDIT13, m_CellType13);
	DDV_MaxChars(pDX, m_CellType13, 1);
	DDX_Text(pDX, IDC_EDIT14, m_CellType14);
	DDV_MaxChars(pDX, m_CellType14, 1);
	DDX_Text(pDX, IDC_EDIT15, m_CellType15);
	DDV_MaxChars(pDX, m_CellType15, 1);
	DDX_Text(pDX, IDC_EDIT16, m_CellType16);
	DDV_MaxChars(pDX, m_CellType16, 1);
	DDX_Text(pDX, IDC_EDIT17, m_CellType17);
	DDV_MaxChars(pDX, m_CellType17, 1);
	DDX_Text(pDX, IDC_EDIT18, m_CellType18);
	DDV_MaxChars(pDX, m_CellType18, 1);
	DDX_Text(pDX, IDC_EDIT19, m_CellType19);
	DDV_MaxChars(pDX, m_CellType19, 1);
	DDX_Text(pDX, IDC_EDIT20, m_CellType20);
	DDV_MaxChars(pDX, m_CellType20, 1);
	DDX_Text(pDX, IDC_EDIT21, m_CellType21);
	DDV_MaxChars(pDX, m_CellType21, 1);
	DDX_Text(pDX, IDC_EDIT22, m_CellType22);
	DDV_MaxChars(pDX, m_CellType22, 1);
	DDX_Text(pDX, IDC_EDIT23, m_CellType23);
	DDV_MaxChars(pDX, m_CellType23, 1);
	DDX_Text(pDX, IDC_EDIT24, m_CellType24);
	DDV_MaxChars(pDX, m_CellType24, 1);
	DDX_Text(pDX, IDC_EDIT25, m_CellType25);
	DDV_MaxChars(pDX, m_CellType25, 1);
	DDX_Text(pDX, IDC_EDIT26, m_CellType26);
	DDV_MaxChars(pDX, m_CellType26, 1);
	DDX_Text(pDX, IDC_EDIT27, m_CellType27);
	DDV_MaxChars(pDX, m_CellType27, 1);
	DDX_Text(pDX, IDC_EDIT28, m_CellType28);
	DDV_MaxChars(pDX, m_CellType28, 1);
	DDX_Text(pDX, IDC_EDIT29, m_CellType29);
	DDV_MaxChars(pDX, m_CellType29, 1);
	DDX_Text(pDX, IDC_EDIT30, m_CellType30);
	DDV_MaxChars(pDX, m_CellType30, 1);
	DDX_Text(pDX, IDC_EDIT31, m_CellType31);
	DDV_MaxChars(pDX, m_CellType31, 1);
	DDX_Text(pDX, IDC_EDIT32, m_CellType32);
	DDV_MaxChars(pDX, m_CellType32, 1);
	DDX_Text(pDX, IDC_EDIT33, m_CellType33);
	DDV_MaxChars(pDX, m_CellType33, 1);
	DDX_Text(pDX, IDC_EDIT34, m_CellType34);
	DDV_MaxChars(pDX, m_CellType34, 1);
	DDX_Text(pDX, IDC_EDIT35, m_CellType35);
	DDV_MaxChars(pDX, m_CellType35, 1);
	DDX_Text(pDX, IDC_EDIT36, m_CellType36);
	DDV_MaxChars(pDX, m_CellType36, 1);
	DDX_Text(pDX, IDC_EDIT37, m_CellType37);
	DDV_MaxChars(pDX, m_CellType37, 1);
	DDX_Text(pDX, IDC_EDIT38, m_CellType38);
	DDV_MaxChars(pDX, m_CellType38, 1);
	DDX_Text(pDX, IDC_EDIT39, m_CellType39);
	DDV_MaxChars(pDX, m_CellType39, 1);
	DDX_Text(pDX, IDC_EDIT40, m_CellType40);
	DDV_MaxChars(pDX, m_CellType40, 1);
	DDX_Text(pDX, IDC_EDIT41, m_CellType41);
	DDV_MaxChars(pDX, m_CellType41, 1);
	DDX_Text(pDX, IDC_EDIT42, m_CellType42);
	DDV_MaxChars(pDX, m_CellType42, 1);
	DDX_Text(pDX, IDC_EDIT43, m_CellType43);
	DDV_MaxChars(pDX, m_CellType43, 1);
	DDX_Text(pDX, IDC_EDIT44, m_CellType44);
	DDV_MaxChars(pDX, m_CellType44, 1);
	DDX_Text(pDX, IDC_EDIT45, m_CellType45);
	DDV_MaxChars(pDX, m_CellType45, 1);
	DDX_Text(pDX, IDC_EDIT46, m_CellType46);
	DDV_MaxChars(pDX, m_CellType46, 1);
	DDX_Text(pDX, IDC_EDIT47, m_CellType47);
	DDV_MaxChars(pDX, m_CellType47, 1);
	DDX_Text(pDX, IDC_EDIT48, m_CellType48);
	DDV_MaxChars(pDX, m_CellType48, 1);
	DDX_Text(pDX, IDC_EDIT49, m_CellType49);
	DDV_MaxChars(pDX, m_CellType49, 1);
	DDX_Text(pDX, IDC_EDIT50, m_CellType50);
	DDV_MaxChars(pDX, m_CellType50, 1);
	DDX_Text(pDX, IDC_EDIT51, m_CellType51);
	DDV_MaxChars(pDX, m_CellType51, 1);
	DDX_Text(pDX, IDC_EDIT52, m_CellType52);
	DDV_MaxChars(pDX, m_CellType52, 1);
	DDX_Text(pDX, IDC_EDIT53, m_CellType53);
	DDV_MaxChars(pDX, m_CellType53, 1);
	DDX_Text(pDX, IDC_EDIT54, m_CellType54);
	DDV_MaxChars(pDX, m_CellType54, 1);
	DDX_Text(pDX, IDC_EDIT55, m_CellType55);
	DDV_MaxChars(pDX, m_CellType55, 1);
	DDX_Text(pDX, IDC_EDIT56, m_CellType56);
	DDV_MaxChars(pDX, m_CellType56, 1);
	DDX_Text(pDX, IDC_EDIT57, m_CellType57);
	DDV_MaxChars(pDX, m_CellType57, 1);
	DDX_Text(pDX, IDC_EDIT58, m_CellType58);
	DDV_MaxChars(pDX, m_CellType58, 1);
	DDX_Text(pDX, IDC_EDIT59, m_CellType59);
	DDV_MaxChars(pDX, m_CellType59, 1);
	DDX_Text(pDX, IDC_EDIT60, m_CellType60);
	DDV_MaxChars(pDX, m_CellType60, 1);
	DDX_Text(pDX, IDC_EDIT61, m_CellType61);
	DDV_MaxChars(pDX, m_CellType61, 1);
	DDX_Text(pDX, IDC_EDIT62, m_CellType62);
	DDV_MaxChars(pDX, m_CellType62, 1);
	DDX_Text(pDX, IDC_EDIT63, m_CellType63);
	DDV_MaxChars(pDX, m_CellType63, 1);
	DDX_Text(pDX, IDC_EDIT64, m_CellType64);
	DDV_MaxChars(pDX, m_CellType64, 1);
	DDX_Text(pDX, IDC_EDIT65, m_CellType65);
	DDV_MaxChars(pDX, m_CellType65, 1);
	DDX_Text(pDX, IDC_EDIT66, m_CellType66);
	DDV_MaxChars(pDX, m_CellType66, 1);
	DDX_Text(pDX, IDC_EDIT67, m_CellType67);
	DDV_MaxChars(pDX, m_CellType67, 1);
	DDX_Text(pDX, IDC_EDIT68, m_CellType68);
	DDV_MaxChars(pDX, m_CellType68, 1);
	DDX_Text(pDX, IDC_EDIT69, m_CellType69);
	DDV_MaxChars(pDX, m_CellType69, 1);
	DDX_Text(pDX, IDC_EDIT70, m_CellType70);
	DDV_MaxChars(pDX, m_CellType70, 1);
	DDX_Text(pDX, IDC_EDIT71, m_CellType71);
	DDV_MaxChars(pDX, m_CellType71, 1);
	DDX_Text(pDX, IDC_EDIT72, m_CellType72);
	DDV_MaxChars(pDX, m_CellType72, 1);
	DDX_Text(pDX, IDC_EDIT73, m_CellType73);
	DDV_MaxChars(pDX, m_CellType73, 1);
	DDX_Text(pDX, IDC_EDIT74, m_CellType74);
	DDV_MaxChars(pDX, m_CellType74, 1);
	DDX_Text(pDX, IDC_EDIT75, m_CellType75);
	DDV_MaxChars(pDX, m_CellType75, 1);
	DDX_Text(pDX, IDC_EDIT76, m_CellType76);
	DDV_MaxChars(pDX, m_CellType76, 1);
	DDX_Text(pDX, IDC_EDIT77, m_CellType77);
	DDV_MaxChars(pDX, m_CellType77, 1);
	DDX_Text(pDX, IDC_EDIT78, m_CellType78);
	DDV_MaxChars(pDX, m_CellType78, 1);
	DDX_Text(pDX, IDC_EDIT79, m_CellType79);
	DDV_MaxChars(pDX, m_CellType79, 1);
	DDX_Text(pDX, IDC_EDIT80, m_CellType80);
	DDV_MaxChars(pDX, m_CellType80, 1);
	DDX_Text(pDX, IDC_EDIT81, m_CellType81);
	DDV_MaxChars(pDX, m_CellType81, 1);
	DDX_Text(pDX, IDC_EDIT82, m_CellType82);
	DDV_MaxChars(pDX, m_CellType82, 1);
	DDX_Text(pDX, IDC_EDIT83, m_CellType83);
	DDV_MaxChars(pDX, m_CellType83, 1);
	DDX_Text(pDX, IDC_EDIT84, m_CellType84);
	DDV_MaxChars(pDX, m_CellType84, 1);
	DDX_Text(pDX, IDC_EDIT85, m_CellType85);
	DDV_MaxChars(pDX, m_CellType85, 1);
	DDX_Text(pDX, IDC_EDIT86, m_CellType86);
	DDV_MaxChars(pDX, m_CellType86, 1);
	DDX_Text(pDX, IDC_EDIT87, m_CellType87);
	DDV_MaxChars(pDX, m_CellType87, 1);
	DDX_Text(pDX, IDC_EDIT88, m_CellType88);
	DDV_MaxChars(pDX, m_CellType88, 1);
	DDX_Text(pDX, IDC_EDIT89, m_CellType89);
	DDV_MaxChars(pDX, m_CellType89, 1);
	DDX_Text(pDX, IDC_EDIT90, m_CellType90);
	DDV_MaxChars(pDX, m_CellType90, 1);
	DDX_Text(pDX, IDC_EDIT91, m_CellType91);
	DDV_MaxChars(pDX, m_CellType91, 1);
	DDX_Text(pDX, IDC_EDIT92, m_CellType92);
	DDV_MaxChars(pDX, m_CellType92, 1);
	DDX_Text(pDX, IDC_EDIT93, m_CellType93);
	DDV_MaxChars(pDX, m_CellType93, 1);
	DDX_Text(pDX, IDC_EDIT94, m_CellType94);
	DDV_MaxChars(pDX, m_CellType94, 1);
	DDX_Text(pDX, IDC_EDIT95, m_CellType95);
	DDV_MaxChars(pDX, m_CellType95, 1);
	DDX_Text(pDX, IDC_EDIT96, m_CellType96);
	DDV_MaxChars(pDX, m_CellType96, 1);
	DDX_Text(pDX, IDC_EDIT97, m_CellType97);
	DDV_MaxChars(pDX, m_CellType97, 1);
	DDX_Text(pDX, IDC_EDIT98, m_CellType98);
	DDV_MaxChars(pDX, m_CellType98, 1);
	DDX_Text(pDX, IDC_EDIT99, m_CellType99);
	DDV_MaxChars(pDX, m_CellType99, 1);
	DDX_Text(pDX, IDC_EDIT100, m_CellType100);
	DDV_MaxChars(pDX, m_CellType100, 1);
	DDX_Text(pDX, IDC_EDIT101, m_CellType101);
	DDV_MaxChars(pDX, m_CellType101, 1);
	DDX_Text(pDX, IDC_EDIT102, m_CellType102);
	DDV_MaxChars(pDX, m_CellType102, 1);
	DDX_Text(pDX, IDC_EDIT103, m_CellType103);
	DDV_MaxChars(pDX, m_CellType103, 1);
	DDX_Text(pDX, IDC_EDIT104, m_CellType104);
	DDV_MaxChars(pDX, m_CellType104, 1);
	DDX_Text(pDX, IDC_EDIT105, m_CellType105);
	DDV_MaxChars(pDX, m_CellType105, 1);
	DDX_Text(pDX, IDC_EDIT106, m_CellType106);
	DDV_MaxChars(pDX, m_CellType106, 1);
	DDX_Text(pDX, IDC_EDIT107, m_CellType107);
	DDV_MaxChars(pDX, m_CellType107, 1);
	DDX_Text(pDX, IDC_EDIT108, m_CellType108);
	DDV_MaxChars(pDX, m_CellType108, 1);
	DDX_Text(pDX, IDC_EDIT109, m_CellType109);
	DDV_MaxChars(pDX, m_CellType109, 1);
	DDX_Text(pDX, IDC_EDIT110, m_CellType110);
	DDV_MaxChars(pDX, m_CellType110, 1);
	DDX_Text(pDX, IDC_EDIT111, m_CellType111);
	DDV_MaxChars(pDX, m_CellType111, 1);
	DDX_Text(pDX, IDC_EDIT112, m_CellType112);
	DDV_MaxChars(pDX, m_CellType112, 1);
	DDX_Text(pDX, IDC_EDIT113, m_CellType113);
	DDV_MaxChars(pDX, m_CellType113, 1);
	DDX_Text(pDX, IDC_EDIT114, m_CellType114);
	DDV_MaxChars(pDX, m_CellType114, 1);
	DDX_Text(pDX, IDC_EDIT115, m_CellType115);
	DDV_MaxChars(pDX, m_CellType115, 1);
	DDX_Text(pDX, IDC_EDIT116, m_CellType116);
	DDV_MaxChars(pDX, m_CellType116, 1);
	DDX_Text(pDX, IDC_EDIT117, m_CellType117);
	DDV_MaxChars(pDX, m_CellType117, 1);
	DDX_Text(pDX, IDC_EDIT118, m_CellType118);
	DDV_MaxChars(pDX, m_CellType118, 1);
	DDX_Text(pDX, IDC_EDIT119, m_CellType119);
	DDV_MaxChars(pDX, m_CellType119, 1);
	DDX_Text(pDX, IDC_EDIT120, m_CellType120);
	DDV_MaxChars(pDX, m_CellType120, 1);
	DDX_Text(pDX, IDC_EDIT121, m_CellType121);
	DDV_MaxChars(pDX, m_CellType121, 1);
	DDX_Text(pDX, IDC_EDIT122, m_CellType122);
	DDV_MaxChars(pDX, m_CellType122, 1);
	DDX_Text(pDX, IDC_EDIT123, m_CellType123);
	DDV_MaxChars(pDX, m_CellType123, 1);
	DDX_Text(pDX, IDC_EDIT124, m_CellType124);
	DDV_MaxChars(pDX, m_CellType124, 1);
	DDX_Text(pDX, IDC_EDIT125, m_CellType125);
	DDV_MaxChars(pDX, m_CellType125, 1);
	DDX_Text(pDX, IDC_EDIT126, m_CellType126);
	DDV_MaxChars(pDX, m_CellType126, 1);
	DDX_Text(pDX, IDC_EDIT127, m_CellType127);
	DDV_MaxChars(pDX, m_CellType127, 1);
	DDX_Text(pDX, IDC_EDIT128, m_CellType128);
	DDV_MaxChars(pDX, m_CellType128, 1);
	DDX_Text(pDX, IDC_EDIT129, m_CellType129);
	DDV_MaxChars(pDX, m_CellType129, 1);
	DDX_Text(pDX, IDC_EDIT130, m_CellType130);
	DDV_MaxChars(pDX, m_CellType130, 1);
	DDX_Text(pDX, IDC_EDIT131, m_CellType131);
	DDV_MaxChars(pDX, m_CellType131, 1);
	DDX_Text(pDX, IDC_EDIT132, m_CellType132);
	DDV_MaxChars(pDX, m_CellType132, 1);
	DDX_Text(pDX, IDC_EDIT133, m_CellType133);
	DDV_MaxChars(pDX, m_CellType133, 1);
	DDX_Text(pDX, IDC_EDIT134, m_CellType134);
	DDV_MaxChars(pDX, m_CellType134, 1);
	DDX_Text(pDX, IDC_EDIT135, m_CellType135);
	DDV_MaxChars(pDX, m_CellType135, 1);
	DDX_Text(pDX, IDC_EDIT136, m_CellType136);
	DDV_MaxChars(pDX, m_CellType136, 1);
	DDX_Text(pDX, IDC_EDIT137, m_CellType137);
	DDV_MaxChars(pDX, m_CellType137, 1);
	DDX_Text(pDX, IDC_EDIT138, m_CellType138);
	DDV_MaxChars(pDX, m_CellType138, 1);
	DDX_Text(pDX, IDC_EDIT139, m_CellType139);
	DDV_MaxChars(pDX, m_CellType139, 1);
	DDX_Text(pDX, IDC_EDIT140, m_CellType140);
	DDV_MaxChars(pDX, m_CellType140, 1);
	DDX_Text(pDX, IDC_EDIT141, m_CellType141);
	DDV_MaxChars(pDX, m_CellType141, 1);
	DDX_Text(pDX, IDC_EDIT142, m_CellType142);
	DDV_MaxChars(pDX, m_CellType142, 1);
	DDX_Text(pDX, IDC_EDIT143, m_CellType143);
	DDV_MaxChars(pDX, m_CellType143, 1);
	DDX_Text(pDX, IDC_EDIT144, m_CellType144);
	DDV_MaxChars(pDX, m_CellType144, 1);
	DDX_Text(pDX, IDC_EDIT145, m_CellType145);
	DDV_MaxChars(pDX, m_CellType145, 1);
	DDX_Text(pDX, IDC_EDIT146, m_CellType146);
	DDV_MaxChars(pDX, m_CellType146, 1);
	DDX_Text(pDX, IDC_EDIT147, m_CellType147);
	DDV_MaxChars(pDX, m_CellType147, 1);
	DDX_Text(pDX, IDC_EDIT148, m_CellType148);
	DDV_MaxChars(pDX, m_CellType148, 1);
	DDX_Text(pDX, IDC_EDIT149, m_CellType149);
	DDV_MaxChars(pDX, m_CellType149, 1);
	DDX_Text(pDX, IDC_EDIT150, m_CellType150);
	DDV_MaxChars(pDX, m_CellType150, 1);
	DDX_Text(pDX, IDC_EDIT151, m_CellType151);
	DDV_MaxChars(pDX, m_CellType151, 1);
	DDX_Text(pDX, IDC_EDIT152, m_CellType152);
	DDV_MaxChars(pDX, m_CellType152, 1);
	DDX_Text(pDX, IDC_EDIT153, m_CellType153);
	DDV_MaxChars(pDX, m_CellType153, 1);
	DDX_Text(pDX, IDC_EDIT154, m_CellType154);
	DDV_MaxChars(pDX, m_CellType154, 1);
	DDX_Text(pDX, IDC_EDIT155, m_CellType155);
	DDV_MaxChars(pDX, m_CellType155, 1);
	DDX_Text(pDX, IDC_EDIT156, m_CellType156);
	DDV_MaxChars(pDX, m_CellType156, 1);
	DDX_Text(pDX, IDC_EDIT157, m_CellType157);
	DDV_MaxChars(pDX, m_CellType157, 1);
	DDX_Text(pDX, IDC_EDIT158, m_CellType158);
	DDV_MaxChars(pDX, m_CellType158, 1);
	DDX_Text(pDX, IDC_EDIT159, m_CellType159);
	DDV_MaxChars(pDX, m_CellType159, 1);
	DDX_Text(pDX, IDC_EDIT160, m_CellType160);
	DDV_MaxChars(pDX, m_CellType160, 1);
	DDX_Text(pDX, IDC_EDIT161, m_CellType161);
	DDV_MaxChars(pDX, m_CellType161, 1);
	DDX_Text(pDX, IDC_EDIT162, m_CellType162);
	DDV_MaxChars(pDX, m_CellType162, 1);
	DDX_Text(pDX, IDC_EDIT163, m_CellType163);
	DDV_MaxChars(pDX, m_CellType163, 1);
	DDX_Text(pDX, IDC_EDIT164, m_CellType164);
	DDV_MaxChars(pDX, m_CellType164, 1);
	DDX_Text(pDX, IDC_EDIT165, m_CellType165);
	DDV_MaxChars(pDX, m_CellType165, 1);
	DDX_Text(pDX, IDC_EDIT166, m_CellType166);
	DDV_MaxChars(pDX, m_CellType166, 1);
	DDX_Text(pDX, IDC_EDIT167, m_CellType167);
	DDV_MaxChars(pDX, m_CellType167, 1);
	DDX_Text(pDX, IDC_EDIT168, m_CellType168);
	DDV_MaxChars(pDX, m_CellType168, 1);
	DDX_Text(pDX, IDC_EDIT169, m_CellType169);
	DDV_MaxChars(pDX, m_CellType169, 1);
	DDX_Text(pDX, IDC_EDIT170, m_CellType170);
	DDV_MaxChars(pDX, m_CellType170, 1);
	DDX_Text(pDX, IDC_EDIT171, m_CellType171);
	DDV_MaxChars(pDX, m_CellType171, 1);
	DDX_Text(pDX, IDC_EDIT172, m_CellType172);
	DDV_MaxChars(pDX, m_CellType172, 1);
	DDX_Text(pDX, IDC_EDIT173, m_CellType173);
	DDV_MaxChars(pDX, m_CellType173, 1);
	DDX_Text(pDX, IDC_EDIT174, m_CellType174);
	DDV_MaxChars(pDX, m_CellType174, 1);
	DDX_Text(pDX, IDC_EDIT175, m_CellType175);
	DDV_MaxChars(pDX, m_CellType175, 1);
	DDX_Text(pDX, IDC_EDIT176, m_CellType176);
	DDV_MaxChars(pDX, m_CellType176, 1);
	DDX_Text(pDX, IDC_EDIT177, m_CellType177);
	DDV_MaxChars(pDX, m_CellType177, 1);
	DDX_Text(pDX, IDC_EDIT178, m_CellType178);
	DDV_MaxChars(pDX, m_CellType178, 1);
	DDX_Text(pDX, IDC_EDIT179, m_CellType179);
	DDV_MaxChars(pDX, m_CellType179, 1);
	DDX_Text(pDX, IDC_EDIT180, m_CellType180);
	DDV_MaxChars(pDX, m_CellType180, 1);
	DDX_Text(pDX, IDC_EDIT181, m_CellType181);
	DDV_MaxChars(pDX, m_CellType181, 1);
	DDX_Text(pDX, IDC_EDIT182, m_CellType182);
	DDV_MaxChars(pDX, m_CellType182, 1);
	DDX_Text(pDX, IDC_EDIT183, m_CellType183);
	DDV_MaxChars(pDX, m_CellType183, 1);
	DDX_Text(pDX, IDC_EDIT184, m_CellType184);
	DDV_MaxChars(pDX, m_CellType184, 1);
	DDX_Text(pDX, IDC_EDIT185, m_CellType185);
	DDV_MaxChars(pDX, m_CellType185, 1);
	DDX_Text(pDX, IDC_EDIT186, m_CellType186);
	DDV_MaxChars(pDX, m_CellType186, 1);
	DDX_Text(pDX, IDC_EDIT187, m_CellType187);
	DDV_MaxChars(pDX, m_CellType187, 1);
	DDX_Text(pDX, IDC_EDIT188, m_CellType188);
	DDV_MaxChars(pDX, m_CellType188, 1);
	DDX_Text(pDX, IDC_EDIT189, m_CellType189);
	DDV_MaxChars(pDX, m_CellType189, 1);
	DDX_Text(pDX, IDC_EDIT190, m_CellType190);
	DDV_MaxChars(pDX, m_CellType190, 1);
	DDX_Text(pDX, IDC_EDIT191, m_CellType191);
	DDV_MaxChars(pDX, m_CellType191, 1);
	DDX_Text(pDX, IDC_EDIT192, m_CellType192);
	DDV_MaxChars(pDX, m_CellType192, 1);
	DDX_Text(pDX, IDC_EDIT193, m_CellType193);
	DDV_MaxChars(pDX, m_CellType193, 1);
	DDX_Text(pDX, IDC_EDIT194, m_CellType194);
	DDV_MaxChars(pDX, m_CellType194, 1);
	DDX_Text(pDX, IDC_EDIT195, m_CellType195);
	DDV_MaxChars(pDX, m_CellType195, 1);
	DDX_Text(pDX, IDC_EDIT196, m_CellType196);
	DDV_MaxChars(pDX, m_CellType196, 1);
	DDX_Text(pDX, IDC_EDIT197, m_CellType197);
	DDV_MaxChars(pDX, m_CellType197, 1);
	DDX_Text(pDX, IDC_EDIT198, m_CellType198);
	DDV_MaxChars(pDX, m_CellType198, 1);
	DDX_Text(pDX, IDC_EDIT199, m_CellType199);
	DDV_MaxChars(pDX, m_CellType199, 1);
	DDX_Text(pDX, IDC_EDIT200, m_CellType200);
	DDV_MaxChars(pDX, m_CellType200, 1);
	DDX_Text(pDX, IDC_EDIT201, m_CellType201);
	DDV_MaxChars(pDX, m_CellType201, 1);
	DDX_Text(pDX, IDC_EDIT202, m_CellType202);
	DDV_MaxChars(pDX, m_CellType202, 1);
	DDX_Text(pDX, IDC_EDIT203, m_CellType203);
	DDV_MaxChars(pDX, m_CellType203, 1);
	DDX_Text(pDX, IDC_EDIT204, m_CellType204);
	DDV_MaxChars(pDX, m_CellType204, 1);
	DDX_Text(pDX, IDC_EDIT205, m_CellType205);
	DDV_MaxChars(pDX, m_CellType205, 1);
	DDX_Text(pDX, IDC_EDIT206, m_CellType206);
	DDV_MaxChars(pDX, m_CellType206, 1);
	DDX_Text(pDX, IDC_EDIT207, m_CellType207);
	DDV_MaxChars(pDX, m_CellType207, 1);
	DDX_Text(pDX, IDC_EDIT208, m_CellType208);
	DDV_MaxChars(pDX, m_CellType208, 1);
	DDX_Text(pDX, IDC_EDIT209, m_CellType209);
	DDV_MaxChars(pDX, m_CellType209, 1);
	DDX_Text(pDX, IDC_EDIT210, m_CellType210);
	DDV_MaxChars(pDX, m_CellType210, 1);
	DDX_Text(pDX, IDC_EDIT211, m_CellType211);
	DDV_MaxChars(pDX, m_CellType211, 1);
	DDX_Text(pDX, IDC_EDIT212, m_CellType212);
	DDV_MaxChars(pDX, m_CellType212, 1);
	DDX_Text(pDX, IDC_EDIT213, m_CellType213);
	DDV_MaxChars(pDX, m_CellType213, 1);
	DDX_Text(pDX, IDC_EDIT214, m_CellType214);
	DDV_MaxChars(pDX, m_CellType214, 1);
	DDX_Text(pDX, IDC_EDIT215, m_CellType215);
	DDV_MaxChars(pDX, m_CellType215, 1);
	DDX_Text(pDX, IDC_EDIT216, m_CellType216);
	DDV_MaxChars(pDX, m_CellType216, 1);
	DDX_Text(pDX, IDC_EDIT217, m_CellType217);
	DDV_MaxChars(pDX, m_CellType217, 1);
	DDX_Text(pDX, IDC_EDIT218, m_CellType218);
	DDV_MaxChars(pDX, m_CellType218, 1);
	DDX_Text(pDX, IDC_EDIT219, m_CellType219);
	DDV_MaxChars(pDX, m_CellType219, 1);
	DDX_Text(pDX, IDC_EDIT220, m_CellType220);
	DDV_MaxChars(pDX, m_CellType220, 1);
	DDX_Text(pDX, IDC_EDIT221, m_CellType221);
	DDV_MaxChars(pDX, m_CellType221, 1);
	DDX_Text(pDX, IDC_EDIT222, m_CellType222);
	DDV_MaxChars(pDX, m_CellType222, 1);
	DDX_Text(pDX, IDC_EDIT223, m_CellType223);
	DDV_MaxChars(pDX, m_CellType223, 1);
	DDX_Text(pDX, IDC_EDIT224, m_CellType224);
	DDV_MaxChars(pDX, m_CellType224, 1);
	DDX_Text(pDX, IDC_EDIT225, m_CellType225);
	DDV_MaxChars(pDX, m_CellType225, 1);
	DDX_Text(pDX, IDC_EDIT226, m_CellType226);
	DDV_MaxChars(pDX, m_CellType226, 1);
	DDX_Text(pDX, IDC_EDIT227, m_CellType227);
	DDV_MaxChars(pDX, m_CellType227, 1);
	DDX_Text(pDX, IDC_EDIT228, m_CellType228);
	DDV_MaxChars(pDX, m_CellType228, 1);
	DDX_Text(pDX, IDC_EDIT229, m_CellType229);
	DDV_MaxChars(pDX, m_CellType229, 1);
	DDX_Text(pDX, IDC_EDIT230, m_CellType230);
	DDV_MaxChars(pDX, m_CellType230, 1);
	DDX_Text(pDX, IDC_EDIT231, m_CellType231);
	DDV_MaxChars(pDX, m_CellType231, 1);
	DDX_Text(pDX, IDC_EDIT232, m_CellType232);
	DDV_MaxChars(pDX, m_CellType232, 1);
	DDX_Text(pDX, IDC_EDIT233, m_CellType233);
	DDV_MaxChars(pDX, m_CellType233, 1);
	DDX_Text(pDX, IDC_EDIT234, m_CellType234);
	DDV_MaxChars(pDX, m_CellType234, 1);
	DDX_Text(pDX, IDC_EDIT235, m_CellType235);
	DDV_MaxChars(pDX, m_CellType235, 1);
	DDX_Text(pDX, IDC_EDIT236, m_CellType236);
	DDV_MaxChars(pDX, m_CellType236, 1);
	DDX_Text(pDX, IDC_EDIT237, m_CellType237);
	DDV_MaxChars(pDX, m_CellType237, 1);
	DDX_Text(pDX, IDC_EDIT238, m_CellType238);
	DDV_MaxChars(pDX, m_CellType238, 1);
	DDX_Text(pDX, IDC_EDIT239, m_CellType239);
	DDV_MaxChars(pDX, m_CellType239, 1);
	DDX_Text(pDX, IDC_EDIT240, m_CellType240);
	DDV_MaxChars(pDX, m_CellType240, 1);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(MazeCreator, CDialog)
	//{{AFX_MSG_MAP(MazeCreator)
	ON_BN_CLICKED(IDC_BUTTON1, OnPreviewMaze)
	ON_BN_CLICKED(IDC_BUTTON2, OnSaveMaze)
	ON_BN_CLICKED(IDC_BUTTON3, OnLoadMaze)
	ON_BN_CLICKED(IDC_BUTTON6, OnClose)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// MazeCreator message handlers


/**************************************************************
*	This function is used during the creation of new mazes.   *
*	It reads the users current maze configuration and then    *
*	calls the maze window to give a graphical representation  *
*	before the user decides to save it or discard it.		  *
**************************************************************/
void MazeCreator::OnPreviewMaze() 
{
	//Create an instance of the MazeWindow
	MazeWindow Preview;

	//Copy the data presently contained in the
	//MazeCreation Dialog box Edit boxes and placing it into
	//TheMaze Variable within the Preview Instance.

	//This is done by calling the GetTextBoxInfo function
	//Which returns a CString of all the boxes combined
	strcpy(Preview.TheMaze, (LPCTSTR) GetTextBoxInfo());

	int counter = 0, starts = 0, ends = 0;
	bool manValid = false;
	bool exitValid = false;


	
	//Check to make sure that a man and an exit exist in the maze
	while (Preview.TheMaze[counter] != NULL){
		if (Preview.TheMaze[counter] == 'm')
			starts++;
		if (Preview.TheMaze[counter] == 'x')
			ends++;
		counter++;
	}

	//Display the graphical preview of the maze if the man and exit exist
	if (starts == 1 && ends == 1)
		Preview.DoModal();
	else
		AfxMessageBox("Your maze must contain a single man and a single exit!");
}


/**************************************************************
*	This function is also used during the creation of a new   *
*	maze.  If the user decides to do so, they have the option *
*	of saving their new maze to a file for later retrival     *
**************************************************************/
void MazeCreator::OnSaveMaze() 
{
	MazeWindow SaveTest;

	strcpy(SaveTest.TheMaze, (LPCTSTR) GetTextBoxInfo());

	int counter = 0, men = 0, exits = 0;
	bool manValid = false;
	bool exitValid = false;
	
	//Check to make sure that a man and an exit exist in the maze
	while (SaveTest.TheMaze[counter] != NULL){
		if (SaveTest.TheMaze[counter] == 'm')
			men++;
		if (SaveTest.TheMaze[counter] == 'x')
			exits++;
		counter++;
	}

	//Display the graphical preview of the maze if the man and exit exist
	if (men == 1 && exits == 1){

		/*********************************************************
		*	This line creates an instance of the CFileSaveLoad   *
		*	Class.  This class is derived from CFileDialog.      *
		*   CFileDialog allows for easy opening of files for     *
		*   reading and writing.  It is set to save the maze     *
		*   with a ".MAZ" file extension if no extension is      *
		*	provided.											 *
		*********************************************************/
		CFileSaveLoad SaveWin(false, "maz", NULL, NULL, "Maze Files (*.maz)|*.maz|");
	
		//Display the Save file window
		SaveWin.DoModal();
	
		//Create a character array to temporarily hold the text
		//box info of the newly created maze
		char NewMaze[241];
	
		//Convert the CString into a character array for sequential writting
		strcpy(NewMaze, (LPCTSTR) GetTextBoxInfo());
	
		//Create and open a file for writting using the name from CFileDialog
		ofstream NewMazeFile(SaveWin.GetFileName(), ios::out);
	
		//write all the characters to the file
		for (int x = 0; x < 241; x++)
			NewMazeFile << NewMaze[x];
	
		//Close the file
		NewMazeFile.close();

	}
	else
		AfxMessageBox("Your maze must contain a single man and a single exit!");

}


/***********************************************************
*	This function in for internal use to grab all the      *
*	characters from each edit box and compile them into a  *
*	single CString which it returns						   *
***********************************************************/
CString MazeCreator::GetTextBoxInfo()
{
	//Read the data off the screen
	UpdateData(true);

	//Reset the current CString to NULL
	MazeString = "";

	//Add each character to the now empty CString
	MazeString += m_CellType1;
	MazeString += m_CellType2;
	MazeString += m_CellType3;
	MazeString += m_CellType4;
	MazeString += m_CellType5;
	MazeString += m_CellType6;
	MazeString += m_CellType7;
	MazeString += m_CellType8;
	MazeString += m_CellType9;
	MazeString += m_CellType10;
	MazeString += m_CellType11;
	MazeString += m_CellType12;
	MazeString += m_CellType13;
	MazeString += m_CellType14;
	MazeString += m_CellType15;
	MazeString += m_CellType16;
	MazeString += m_CellType17;
	MazeString += m_CellType18;
	MazeString += m_CellType19;
	MazeString += m_CellType20;
	MazeString += m_CellType21;
	MazeString += m_CellType22;
	MazeString += m_CellType23;
	MazeString += m_CellType24;
	MazeString += m_CellType25;
	MazeString += m_CellType26;
	MazeString += m_CellType27;
	MazeString += m_CellType28;
	MazeString += m_CellType29;
	MazeString += m_CellType30;
	MazeString += m_CellType31;
	MazeString += m_CellType32;
	MazeString += m_CellType33;
	MazeString += m_CellType34;
	MazeString += m_CellType35;
	MazeString += m_CellType36;
	MazeString += m_CellType37;
	MazeString += m_CellType38;
	MazeString += m_CellType39;
	MazeString += m_CellType40;
	MazeString += m_CellType41;
	MazeString += m_CellType42;
	MazeString += m_CellType43;
	MazeString += m_CellType44;
	MazeString += m_CellType45;
	MazeString += m_CellType46;
	MazeString += m_CellType47;
	MazeString += m_CellType48;
	MazeString += m_CellType49;
	MazeString += m_CellType50;
	MazeString += m_CellType51;
	MazeString += m_CellType52;
	MazeString += m_CellType53;
	MazeString += m_CellType54;
	MazeString += m_CellType55;
	MazeString += m_CellType56;
	MazeString += m_CellType57;
	MazeString += m_CellType58;
	MazeString += m_CellType59;
	MazeString += m_CellType60;
	MazeString += m_CellType61;
	MazeString += m_CellType62;
	MazeString += m_CellType63;
	MazeString += m_CellType64;
	MazeString += m_CellType65;
	MazeString += m_CellType66;
	MazeString += m_CellType67;
	MazeString += m_CellType68;
	MazeString += m_CellType69;
	MazeString += m_CellType70;
	MazeString += m_CellType71;
	MazeString += m_CellType72;
	MazeString += m_CellType73;
	MazeString += m_CellType74;
	MazeString += m_CellType75;
	MazeString += m_CellType76;
	MazeString += m_CellType77;
	MazeString += m_CellType78;
	MazeString += m_CellType79;
	MazeString += m_CellType80;
	MazeString += m_CellType81;
	MazeString += m_CellType82;
	MazeString += m_CellType83;
	MazeString += m_CellType84;
	MazeString += m_CellType85;
	MazeString += m_CellType86;
	MazeString += m_CellType87;
	MazeString += m_CellType88;
	MazeString += m_CellType89;
	MazeString += m_CellType90;
	MazeString += m_CellType91;
	MazeString += m_CellType92;
	MazeString += m_CellType93;
	MazeString += m_CellType94;
	MazeString += m_CellType95;
	MazeString += m_CellType96;
	MazeString += m_CellType97;
	MazeString += m_CellType98;
	MazeString += m_CellType99;
	MazeString += m_CellType100;
	MazeString += m_CellType101;
	MazeString += m_CellType102;
	MazeString += m_CellType103;
	MazeString += m_CellType104;
	MazeString += m_CellType105;
	MazeString += m_CellType106;
	MazeString += m_CellType107;
	MazeString += m_CellType108;
	MazeString += m_CellType109;
	MazeString += m_CellType110;
	MazeString += m_CellType111;
	MazeString += m_CellType112;
	MazeString += m_CellType113;
	MazeString += m_CellType114;
	MazeString += m_CellType115;
	MazeString += m_CellType116;
	MazeString += m_CellType117;
	MazeString += m_CellType118;
	MazeString += m_CellType119;
	MazeString += m_CellType120;
	MazeString += m_CellType121;
	MazeString += m_CellType122;
	MazeString += m_CellType123;
	MazeString += m_CellType124;
	MazeString += m_CellType125;
	MazeString += m_CellType126;
	MazeString += m_CellType127;
	MazeString += m_CellType128;
	MazeString += m_CellType129;
	MazeString += m_CellType130;
	MazeString += m_CellType131;
	MazeString += m_CellType132;
	MazeString += m_CellType133;
	MazeString += m_CellType134;
	MazeString += m_CellType135;
	MazeString += m_CellType136;
	MazeString += m_CellType137;
	MazeString += m_CellType138;
	MazeString += m_CellType139;
	MazeString += m_CellType140;
	MazeString += m_CellType141;
	MazeString += m_CellType142;
	MazeString += m_CellType143;
	MazeString += m_CellType144;
	MazeString += m_CellType145;
	MazeString += m_CellType146;
	MazeString += m_CellType147;
	MazeString += m_CellType148;
	MazeString += m_CellType149;
	MazeString += m_CellType150;
	MazeString += m_CellType151;
	MazeString += m_CellType152;
	MazeString += m_CellType153;
	MazeString += m_CellType154;
	MazeString += m_CellType155;
	MazeString += m_CellType156;
	MazeString += m_CellType157;
	MazeString += m_CellType158;
	MazeString += m_CellType159;
	MazeString += m_CellType160;
	MazeString += m_CellType161;
	MazeString += m_CellType162;
	MazeString += m_CellType163;
	MazeString += m_CellType164;
	MazeString += m_CellType165;
	MazeString += m_CellType166;
	MazeString += m_CellType167;
	MazeString += m_CellType168;
	MazeString += m_CellType169;
	MazeString += m_CellType170;
	MazeString += m_CellType171;
	MazeString += m_CellType172;
	MazeString += m_CellType173;
	MazeString += m_CellType174;
	MazeString += m_CellType175;
	MazeString += m_CellType176;
	MazeString += m_CellType177;
	MazeString += m_CellType178;
	MazeString += m_CellType179;
	MazeString += m_CellType180;
	MazeString += m_CellType181;
	MazeString += m_CellType182;
	MazeString += m_CellType183;
	MazeString += m_CellType184;
	MazeString += m_CellType185;
	MazeString += m_CellType186;
	MazeString += m_CellType187;
	MazeString += m_CellType188;
	MazeString += m_CellType189;
	MazeString += m_CellType190;
	MazeString += m_CellType191;
	MazeString += m_CellType192;
	MazeString += m_CellType193;
	MazeString += m_CellType194;
	MazeString += m_CellType195;
	MazeString += m_CellType196;
	MazeString += m_CellType197;
	MazeString += m_CellType198;
	MazeString += m_CellType199;
	MazeString += m_CellType200;
	MazeString += m_CellType201;
	MazeString += m_CellType202;
	MazeString += m_CellType203;
	MazeString += m_CellType204;
	MazeString += m_CellType205;
	MazeString += m_CellType206;
	MazeString += m_CellType207;
	MazeString += m_CellType208;
	MazeString += m_CellType209;
	MazeString += m_CellType210;
	MazeString += m_CellType211;
	MazeString += m_CellType212;
	MazeString += m_CellType213;
	MazeString += m_CellType214;
	MazeString += m_CellType215;
	MazeString += m_CellType216;
	MazeString += m_CellType217;
	MazeString += m_CellType218;
	MazeString += m_CellType219;
	MazeString += m_CellType220;
	MazeString += m_CellType221;
	MazeString += m_CellType222;
	MazeString += m_CellType223;
	MazeString += m_CellType224;
	MazeString += m_CellType225;
	MazeString += m_CellType226;
	MazeString += m_CellType227;
	MazeString += m_CellType228;
	MazeString += m_CellType229;
	MazeString += m_CellType230;
	MazeString += m_CellType231;
	MazeString += m_CellType232;
	MazeString += m_CellType233;
	MazeString += m_CellType234;
	MazeString += m_CellType235;
	MazeString += m_CellType236;
	MazeString += m_CellType237;
	MazeString += m_CellType238;
	MazeString += m_CellType239;
	MazeString += m_CellType240;

	//Returns the compiled CString
	return MazeString;
}

/******************************************************
*	This function is used to edit an already made     *
*	maze file.  It reads a user selected file and     *
*	updates the edit boxes with the proper characters *
******************************************************/
void MazeCreator::OnLoadMaze() 
{
	//Call CFileDialog to open a .MAZ file
	CFileSaveLoad LoadMazeToEdit(true, "maz", NULL, NULL, "Maze Files (*.maz)|*.maz|");

	//Display the Load File Window
	LoadMazeToEdit.DoModal();

	//Create a temporary character array to hold the file data
	char NewMaze[241];

	//Open the selected file for input without creating one if non existant
	ifstream OldMazeFile(LoadMazeToEdit.GetFileName(), ios::in | ios::nocreate);

	//Read the file into the temporary array
	for(int a = 0; a < 241; a++)
		OldMazeFile >> NewMaze[a];

	//Close the file
	OldMazeFile.close();

	//Read the data into the editboxes
	m_CellType1 = NewMaze[0];
	m_CellType2 = NewMaze[1];
	m_CellType3 = NewMaze[2];
	m_CellType4 = NewMaze[3];
	m_CellType5 = NewMaze[4];
	m_CellType6 = NewMaze[5];
	m_CellType7 = NewMaze[6];
	m_CellType8 = NewMaze[7];
	m_CellType9 = NewMaze[8];
	m_CellType10 = NewMaze[9];
	m_CellType11 = NewMaze[10];
	m_CellType12 = NewMaze[11];
	m_CellType13 = NewMaze[12];
	m_CellType14 = NewMaze[13];
	m_CellType15 = NewMaze[14];
	m_CellType16 = NewMaze[15];
	m_CellType17 = NewMaze[16];
	m_CellType18 = NewMaze[17];
	m_CellType19 = NewMaze[18];
	m_CellType20 = NewMaze[19];
	m_CellType21 = NewMaze[20];
	m_CellType22 = NewMaze[21];
	m_CellType23 = NewMaze[22];
	m_CellType24 = NewMaze[23];
	m_CellType25 = NewMaze[24];
	m_CellType26 = NewMaze[25];
	m_CellType27 = NewMaze[26];
	m_CellType28 = NewMaze[27];
	m_CellType29 = NewMaze[28];
	m_CellType30 = NewMaze[29];
	m_CellType31 = NewMaze[30];
	m_CellType32 = NewMaze[31];
	m_CellType33 = NewMaze[32];
	m_CellType34 = NewMaze[33];
	m_CellType35 = NewMaze[34];
	m_CellType36 = NewMaze[35];
	m_CellType37 = NewMaze[36];
	m_CellType38 = NewMaze[37];
	m_CellType39 = NewMaze[38];
	m_CellType40 = NewMaze[39];
	m_CellType41 = NewMaze[40];
	m_CellType42 = NewMaze[41];
	m_CellType43 = NewMaze[42];
	m_CellType44 = NewMaze[43];
	m_CellType45 = NewMaze[44];
	m_CellType46 = NewMaze[45];
	m_CellType47 = NewMaze[46];
	m_CellType48 = NewMaze[47];
	m_CellType49 = NewMaze[48];
	m_CellType50 = NewMaze[49];
	m_CellType51 = NewMaze[50];
	m_CellType52 = NewMaze[51];
	m_CellType53 = NewMaze[52];
	m_CellType54 = NewMaze[53];
	m_CellType55 = NewMaze[54];
	m_CellType56 = NewMaze[55];
	m_CellType57 = NewMaze[56];
	m_CellType58 = NewMaze[57];
	m_CellType59 = NewMaze[58];
	m_CellType60 = NewMaze[59];
	m_CellType61 = NewMaze[60];
	m_CellType62 = NewMaze[61];
	m_CellType63 = NewMaze[62];
	m_CellType64 = NewMaze[63];
	m_CellType65 = NewMaze[64];
	m_CellType66 = NewMaze[65];
	m_CellType67 = NewMaze[66];
	m_CellType68 = NewMaze[67];
	m_CellType69 = NewMaze[68];
	m_CellType70 = NewMaze[69];
	m_CellType71 = NewMaze[70];
	m_CellType72 = NewMaze[71];
	m_CellType73 = NewMaze[72];
	m_CellType74 = NewMaze[73];
	m_CellType75 = NewMaze[74];
	m_CellType76 = NewMaze[75];
	m_CellType77 = NewMaze[76];
	m_CellType78 = NewMaze[77];
	m_CellType79 = NewMaze[78];
	m_CellType80 = NewMaze[79];
	m_CellType81 = NewMaze[80];
	m_CellType82 = NewMaze[81];
	m_CellType83 = NewMaze[82];
	m_CellType84 = NewMaze[83];
	m_CellType85 = NewMaze[84];
	m_CellType86 = NewMaze[85];
	m_CellType87 = NewMaze[86];
	m_CellType88 = NewMaze[87];
	m_CellType89 = NewMaze[88];
	m_CellType90 = NewMaze[89];
	m_CellType91 = NewMaze[90];
	m_CellType92 = NewMaze[91];
	m_CellType93 = NewMaze[92];
	m_CellType94 = NewMaze[93];
	m_CellType95 = NewMaze[94];
	m_CellType96 = NewMaze[95];
	m_CellType97 = NewMaze[96];
	m_CellType98 = NewMaze[97];
	m_CellType99 = NewMaze[98];
	m_CellType100 = NewMaze[99];
	m_CellType101 = NewMaze[100];
	m_CellType102 = NewMaze[101];
	m_CellType103 = NewMaze[102];
	m_CellType104 = NewMaze[103];
	m_CellType105 = NewMaze[104];
	m_CellType106 = NewMaze[105];
	m_CellType107 = NewMaze[106];
	m_CellType108 = NewMaze[107];
	m_CellType109 = NewMaze[108];
	m_CellType110 = NewMaze[109];
	m_CellType111 = NewMaze[110];
	m_CellType112 = NewMaze[111];
	m_CellType113 = NewMaze[112];
	m_CellType114 = NewMaze[113];
	m_CellType115 = NewMaze[114];
	m_CellType116 = NewMaze[115];
	m_CellType117 = NewMaze[116];
	m_CellType118 = NewMaze[117];
	m_CellType119 = NewMaze[118];
	m_CellType120 = NewMaze[119];
	m_CellType121 = NewMaze[120];
	m_CellType122 = NewMaze[121];
	m_CellType123 = NewMaze[122];
	m_CellType124 = NewMaze[123];
	m_CellType125 = NewMaze[124];
	m_CellType126 = NewMaze[125];
	m_CellType127 = NewMaze[126];
	m_CellType128 = NewMaze[127];
	m_CellType129 = NewMaze[128];
	m_CellType130 = NewMaze[129];
	m_CellType131 = NewMaze[130];
	m_CellType132 = NewMaze[131];
	m_CellType133 = NewMaze[132];
	m_CellType134 = NewMaze[133];
	m_CellType135 = NewMaze[134];
	m_CellType136 = NewMaze[135];
	m_CellType137 = NewMaze[136];
	m_CellType138 = NewMaze[137];
	m_CellType139 = NewMaze[138];
	m_CellType140 = NewMaze[139];
	m_CellType141 = NewMaze[140];
	m_CellType142 = NewMaze[141];
	m_CellType143 = NewMaze[142];
	m_CellType144 = NewMaze[143];
	m_CellType145 = NewMaze[144];
	m_CellType146 = NewMaze[145];
	m_CellType147 = NewMaze[146];
	m_CellType148 = NewMaze[147];
	m_CellType149 = NewMaze[148];
	m_CellType150 = NewMaze[149];
	m_CellType151 = NewMaze[150];
	m_CellType152 = NewMaze[151];
	m_CellType153 = NewMaze[152];
	m_CellType154 = NewMaze[153];
	m_CellType155 = NewMaze[154];
	m_CellType156 = NewMaze[155];
	m_CellType157 = NewMaze[156];
	m_CellType158 = NewMaze[157];
	m_CellType159 = NewMaze[158];
	m_CellType160 = NewMaze[159];
	m_CellType161 = NewMaze[160];
	m_CellType162 = NewMaze[161];
	m_CellType163 = NewMaze[162];
	m_CellType164 = NewMaze[163];
	m_CellType165 = NewMaze[164];
	m_CellType166 = NewMaze[165];
	m_CellType167 = NewMaze[166];
	m_CellType168 = NewMaze[167];
	m_CellType169 = NewMaze[168];
	m_CellType170 = NewMaze[169];
	m_CellType171 = NewMaze[170];
	m_CellType172 = NewMaze[171];
	m_CellType173 = NewMaze[172];
	m_CellType174 = NewMaze[173];
	m_CellType175 = NewMaze[174];
	m_CellType176 = NewMaze[175];
	m_CellType177 = NewMaze[176];
	m_CellType178 = NewMaze[177];
	m_CellType179 = NewMaze[178];
	m_CellType180 = NewMaze[179];
	m_CellType181 = NewMaze[180];
	m_CellType182 = NewMaze[181];
	m_CellType183 = NewMaze[182];
	m_CellType184 = NewMaze[183];
	m_CellType185 = NewMaze[184];
	m_CellType186 = NewMaze[185];
	m_CellType187 = NewMaze[186];
	m_CellType188 = NewMaze[187];
	m_CellType189 = NewMaze[188];
	m_CellType190 = NewMaze[189];
	m_CellType191 = NewMaze[190];
	m_CellType192 = NewMaze[191];
	m_CellType193 = NewMaze[192];
	m_CellType194 = NewMaze[193];
	m_CellType195 = NewMaze[194];
	m_CellType196 = NewMaze[195];
	m_CellType197 = NewMaze[196];
	m_CellType198 = NewMaze[197];
	m_CellType199 = NewMaze[198];
	m_CellType200 = NewMaze[199];
	m_CellType201 = NewMaze[200];
	m_CellType202 = NewMaze[201];
	m_CellType203 = NewMaze[202];
	m_CellType204 = NewMaze[203];
	m_CellType205 = NewMaze[204];
	m_CellType206 = NewMaze[205];
	m_CellType207 = NewMaze[206];
	m_CellType208 = NewMaze[207];
	m_CellType209 = NewMaze[208];
	m_CellType210 = NewMaze[209];
	m_CellType211 = NewMaze[210];
	m_CellType212 = NewMaze[211];
	m_CellType213 = NewMaze[212];
	m_CellType214 = NewMaze[213];
	m_CellType215 = NewMaze[214];
	m_CellType216 = NewMaze[215];
	m_CellType217 = NewMaze[216];
	m_CellType218 = NewMaze[217];
	m_CellType219 = NewMaze[218];
	m_CellType220 = NewMaze[219];
	m_CellType221 = NewMaze[220];
	m_CellType222 = NewMaze[221];
	m_CellType223 = NewMaze[222];
	m_CellType224 = NewMaze[223];
	m_CellType225 = NewMaze[224];
	m_CellType226 = NewMaze[225];
	m_CellType227 = NewMaze[226];
	m_CellType228 = NewMaze[227];
	m_CellType229 = NewMaze[228];
	m_CellType230 = NewMaze[229];
	m_CellType231 = NewMaze[230];
	m_CellType232 = NewMaze[231];
	m_CellType233 = NewMaze[232];
	m_CellType234 = NewMaze[233];
	m_CellType235 = NewMaze[234];
	m_CellType236 = NewMaze[235];
	m_CellType237 = NewMaze[236];
	m_CellType238 = NewMaze[237];
	m_CellType239 = NewMaze[238];
	m_CellType240 = NewMaze[239];

	//Display the new data to the screen	
	UpdateData(false);
}

//This function is used to let the user close the window by clicking a button
void MazeCreator::OnClose() 
{
	this->EndDialog(true);	
}
