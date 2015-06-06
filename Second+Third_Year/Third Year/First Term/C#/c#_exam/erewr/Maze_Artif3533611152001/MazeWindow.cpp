// MazeWindow.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "MazeWindow.h"
#include "Stack.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// MazeWindow dialog


MazeWindow::MazeWindow(CWnd* pParent /*=NULL*/)
	: CDialog(MazeWindow::IDD, pParent)
{
	PlayerFoundExit = false;
	ComputerSolved = false;
	//{{AFX_DATA_INIT(MazeWindow)
	//}}AFX_DATA_INIT
}


void MazeWindow::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(MazeWindow)
	DDX_Control(pDX, IDC_ANIMATE84, m_grid84);
	DDX_Control(pDX, IDC_ANIMATE48, m_grid48);
	DDX_Control(pDX, IDC_ANIMATE99, m_grid99);
	DDX_Control(pDX, IDC_ANIMATE98, m_grid98);
	DDX_Control(pDX, IDC_ANIMATE97, m_grid97);
	DDX_Control(pDX, IDC_ANIMATE96, m_grid96);
	DDX_Control(pDX, IDC_ANIMATE95, m_grid95);
	DDX_Control(pDX, IDC_ANIMATE94, m_grid94);
	DDX_Control(pDX, IDC_ANIMATE93, m_grid93);
	DDX_Control(pDX, IDC_ANIMATE92, m_grid92);
	DDX_Control(pDX, IDC_ANIMATE91, m_grid91);
	DDX_Control(pDX, IDC_ANIMATE90, m_grid90);
	DDX_Control(pDX, IDC_ANIMATE9, m_grid9);
	DDX_Control(pDX, IDC_ANIMATE89, m_grid89);
	DDX_Control(pDX, IDC_ANIMATE88, m_grid88);
	DDX_Control(pDX, IDC_ANIMATE87, m_grid87);
	DDX_Control(pDX, IDC_ANIMATE86, m_grid86);
	DDX_Control(pDX, IDC_ANIMATE85, m_grid85);
	DDX_Control(pDX, IDC_ANIMATE83, m_grid83);
	DDX_Control(pDX, IDC_ANIMATE82, m_grid82);
	DDX_Control(pDX, IDC_ANIMATE81, m_grid81);
	DDX_Control(pDX, IDC_ANIMATE80, m_grid80);
	DDX_Control(pDX, IDC_ANIMATE8, m_grid8);
	DDX_Control(pDX, IDC_ANIMATE79, m_grid79);
	DDX_Control(pDX, IDC_ANIMATE78, m_grid78);
	DDX_Control(pDX, IDC_ANIMATE77, m_grid77);
	DDX_Control(pDX, IDC_ANIMATE76, m_grid76);
	DDX_Control(pDX, IDC_ANIMATE75, m_grid75);
	DDX_Control(pDX, IDC_ANIMATE74, m_grid74);
	DDX_Control(pDX, IDC_ANIMATE73, m_grid73);
	DDX_Control(pDX, IDC_ANIMATE72, m_grid72);
	DDX_Control(pDX, IDC_ANIMATE71, m_grid71);
	DDX_Control(pDX, IDC_ANIMATE70, m_grid70);
	DDX_Control(pDX, IDC_ANIMATE7, m_grid7);
	DDX_Control(pDX, IDC_ANIMATE69, m_grid69);
	DDX_Control(pDX, IDC_ANIMATE68, m_grid68);
	DDX_Control(pDX, IDC_ANIMATE67, m_grid67);
	DDX_Control(pDX, IDC_ANIMATE66, m_grid66);
	DDX_Control(pDX, IDC_ANIMATE65, m_grid65);
	DDX_Control(pDX, IDC_ANIMATE64, m_grid64);
	DDX_Control(pDX, IDC_ANIMATE63, m_grid63);
	DDX_Control(pDX, IDC_ANIMATE62, m_grid62);
	DDX_Control(pDX, IDC_ANIMATE61, m_grid61);
	DDX_Control(pDX, IDC_ANIMATE60, m_grid60);
	DDX_Control(pDX, IDC_ANIMATE6, m_grid6);
	DDX_Control(pDX, IDC_ANIMATE59, m_grid59);
	DDX_Control(pDX, IDC_ANIMATE58, m_grid58);
	DDX_Control(pDX, IDC_ANIMATE57, m_grid57);
	DDX_Control(pDX, IDC_ANIMATE56, m_grid56);
	DDX_Control(pDX, IDC_ANIMATE55, m_grid55);
	DDX_Control(pDX, IDC_ANIMATE54, m_grid54);
	DDX_Control(pDX, IDC_ANIMATE53, m_grid53);
	DDX_Control(pDX, IDC_ANIMATE52, m_grid52);
	DDX_Control(pDX, IDC_ANIMATE51, m_grid51);
	DDX_Control(pDX, IDC_ANIMATE50, m_grid50);
	DDX_Control(pDX, IDC_ANIMATE5, m_grid5);
	DDX_Control(pDX, IDC_ANIMATE49, m_grid49);
	DDX_Control(pDX, IDC_ANIMATE47, m_grid47);
	DDX_Control(pDX, IDC_ANIMATE46, m_grid46);
	DDX_Control(pDX, IDC_ANIMATE45, m_grid45);
	DDX_Control(pDX, IDC_ANIMATE44, m_grid44);
	DDX_Control(pDX, IDC_ANIMATE43, m_grid43);
	DDX_Control(pDX, IDC_ANIMATE42, m_grid42);
	DDX_Control(pDX, IDC_ANIMATE41, m_grid41);
	DDX_Control(pDX, IDC_ANIMATE40, m_grid40);
	DDX_Control(pDX, IDC_ANIMATE4, m_grid4);
	DDX_Control(pDX, IDC_ANIMATE39, m_grid39);
	DDX_Control(pDX, IDC_ANIMATE38, m_grid38);
	DDX_Control(pDX, IDC_ANIMATE37, m_grid37);
	DDX_Control(pDX, IDC_ANIMATE36, m_grid36);
	DDX_Control(pDX, IDC_ANIMATE35, m_grid35);
	DDX_Control(pDX, IDC_ANIMATE34, m_grid34);
	DDX_Control(pDX, IDC_ANIMATE33, m_grid33);
	DDX_Control(pDX, IDC_ANIMATE32, m_grid32);
	DDX_Control(pDX, IDC_ANIMATE31, m_grid31);
	DDX_Control(pDX, IDC_ANIMATE30, m_grid30);
	DDX_Control(pDX, IDC_ANIMATE3, m_grid3);
	DDX_Control(pDX, IDC_ANIMATE29, m_grid29);
	DDX_Control(pDX, IDC_ANIMATE28, m_grid28);
	DDX_Control(pDX, IDC_ANIMATE27, m_grid27);
	DDX_Control(pDX, IDC_ANIMATE26, m_grid26);
	DDX_Control(pDX, IDC_ANIMATE25, m_grid25);
	DDX_Control(pDX, IDC_ANIMATE240, m_grid240);
	DDX_Control(pDX, IDC_ANIMATE24, m_grid24);
	DDX_Control(pDX, IDC_ANIMATE239, m_grid239);
	DDX_Control(pDX, IDC_ANIMATE238, m_grid238);
	DDX_Control(pDX, IDC_ANIMATE237, m_grid237);
	DDX_Control(pDX, IDC_ANIMATE236, m_grid236);
	DDX_Control(pDX, IDC_ANIMATE235, m_grid235);
	DDX_Control(pDX, IDC_ANIMATE234, m_grid234);
	DDX_Control(pDX, IDC_ANIMATE233, m_grid233);
	DDX_Control(pDX, IDC_ANIMATE232, m_grid232);
	DDX_Control(pDX, IDC_ANIMATE231, m_grid231);
	DDX_Control(pDX, IDC_ANIMATE230, m_grid230);
	DDX_Control(pDX, IDC_ANIMATE23, m_grid23);
	DDX_Control(pDX, IDC_ANIMATE229, m_grid229);
	DDX_Control(pDX, IDC_ANIMATE228, m_grid228);
	DDX_Control(pDX, IDC_ANIMATE227, m_grid227);
	DDX_Control(pDX, IDC_ANIMATE226, m_grid226);
	DDX_Control(pDX, IDC_ANIMATE225, m_grid225);
	DDX_Control(pDX, IDC_ANIMATE224, m_grid224);
	DDX_Control(pDX, IDC_ANIMATE223, m_grid223);
	DDX_Control(pDX, IDC_ANIMATE222, m_grid222);
	DDX_Control(pDX, IDC_ANIMATE221, m_grid221);
	DDX_Control(pDX, IDC_ANIMATE220, m_grid220);
	DDX_Control(pDX, IDC_ANIMATE22, m_grid22);
	DDX_Control(pDX, IDC_ANIMATE219, m_grid219);
	DDX_Control(pDX, IDC_ANIMATE217, m_grid217);
	DDX_Control(pDX, IDC_ANIMATE218, m_grid218);
	DDX_Control(pDX, IDC_ANIMATE216, m_grid216);
	DDX_Control(pDX, IDC_ANIMATE215, m_grid215);
	DDX_Control(pDX, IDC_ANIMATE214, m_grid214);
	DDX_Control(pDX, IDC_ANIMATE213, m_grid213);
	DDX_Control(pDX, IDC_ANIMATE212, m_grid212);
	DDX_Control(pDX, IDC_ANIMATE211, m_grid211);
	DDX_Control(pDX, IDC_ANIMATE210, m_grid210);
	DDX_Control(pDX, IDC_ANIMATE21, m_grid21);
	DDX_Control(pDX, IDC_ANIMATE209, m_grid209);
	DDX_Control(pDX, IDC_ANIMATE208, m_grid208);
	DDX_Control(pDX, IDC_ANIMATE207, m_grid207);
	DDX_Control(pDX, IDC_ANIMATE206, m_grid206);
	DDX_Control(pDX, IDC_ANIMATE205, m_grid205);
	DDX_Control(pDX, IDC_ANIMATE204, m_grid204);
	DDX_Control(pDX, IDC_ANIMATE203, m_grid203);
	DDX_Control(pDX, IDC_ANIMATE202, m_grid202);
	DDX_Control(pDX, IDC_ANIMATE201, m_grid201);
	DDX_Control(pDX, IDC_ANIMATE200, m_grid200);
	DDX_Control(pDX, IDC_ANIMATE20, m_grid20);
	DDX_Control(pDX, IDC_ANIMATE2, m_grid2);
	DDX_Control(pDX, IDC_ANIMATE199, m_grid199);
	DDX_Control(pDX, IDC_ANIMATE198, m_grid198);
	DDX_Control(pDX, IDC_ANIMATE197, m_grid197);
	DDX_Control(pDX, IDC_ANIMATE196, m_grid196);
	DDX_Control(pDX, IDC_ANIMATE195, m_grid195);
	DDX_Control(pDX, IDC_ANIMATE194, m_grid194);
	DDX_Control(pDX, IDC_ANIMATE193, m_grid193);
	DDX_Control(pDX, IDC_ANIMATE192, m_grid192);
	DDX_Control(pDX, IDC_ANIMATE191, m_grid191);
	DDX_Control(pDX, IDC_ANIMATE190, m_grid190);
	DDX_Control(pDX, IDC_ANIMATE19, m_grid19);
	DDX_Control(pDX, IDC_ANIMATE189, m_grid189);
	DDX_Control(pDX, IDC_ANIMATE188, m_grid188);
	DDX_Control(pDX, IDC_ANIMATE187, m_grid187);
	DDX_Control(pDX, IDC_ANIMATE186, m_grid186);
	DDX_Control(pDX, IDC_ANIMATE185, m_grid185);
	DDX_Control(pDX, IDC_ANIMATE184, m_grid184);
	DDX_Control(pDX, IDC_ANIMATE183, m_grid183);
	DDX_Control(pDX, IDC_ANIMATE182, m_grid182);
	DDX_Control(pDX, IDC_ANIMATE181, m_grid181);
	DDX_Control(pDX, IDC_ANIMATE180, m_grid180);
	DDX_Control(pDX, IDC_ANIMATE18, m_grid18);
	DDX_Control(pDX, IDC_ANIMATE179, m_grid179);
	DDX_Control(pDX, IDC_ANIMATE178, m_grid178);
	DDX_Control(pDX, IDC_ANIMATE177, m_grid177);
	DDX_Control(pDX, IDC_ANIMATE176, m_grid176);
	DDX_Control(pDX, IDC_ANIMATE175, m_grid175);
	DDX_Control(pDX, IDC_ANIMATE174, m_grid174);
	DDX_Control(pDX, IDC_ANIMATE173, m_grid173);
	DDX_Control(pDX, IDC_ANIMATE172, m_grid172);
	DDX_Control(pDX, IDC_ANIMATE171, m_grid171);
	DDX_Control(pDX, IDC_ANIMATE170, m_grid170);
	DDX_Control(pDX, IDC_ANIMATE17, m_grid17);
	DDX_Control(pDX, IDC_ANIMATE169, m_grid169);
	DDX_Control(pDX, IDC_ANIMATE168, m_grid168);
	DDX_Control(pDX, IDC_ANIMATE167, m_grid167);
	DDX_Control(pDX, IDC_ANIMATE166, m_grid166);
	DDX_Control(pDX, IDC_ANIMATE165, m_grid165);
	DDX_Control(pDX, IDC_ANIMATE164, m_grid164);
	DDX_Control(pDX, IDC_ANIMATE163, m_grid163);
	DDX_Control(pDX, IDC_ANIMATE162, m_grid162);
	DDX_Control(pDX, IDC_ANIMATE161, m_grid161);
	DDX_Control(pDX, IDC_ANIMATE160, m_grid160);
	DDX_Control(pDX, IDC_ANIMATE16, m_grid16);
	DDX_Control(pDX, IDC_ANIMATE159, m_grid159);
	DDX_Control(pDX, IDC_ANIMATE158, m_grid158);
	DDX_Control(pDX, IDC_ANIMATE157, m_grid157);
	DDX_Control(pDX, IDC_ANIMATE156, m_grid156);
	DDX_Control(pDX, IDC_ANIMATE155, m_grid155);
	DDX_Control(pDX, IDC_ANIMATE154, m_grid154);
	DDX_Control(pDX, IDC_ANIMATE153, m_grid153);
	DDX_Control(pDX, IDC_ANIMATE152, m_grid152);
	DDX_Control(pDX, IDC_ANIMATE151, m_grid151);
	DDX_Control(pDX, IDC_ANIMATE150, m_grid150);
	DDX_Control(pDX, IDC_ANIMATE15, m_grid15);
	DDX_Control(pDX, IDC_ANIMATE149, m_grid149);
	DDX_Control(pDX, IDC_ANIMATE148, m_grid148);
	DDX_Control(pDX, IDC_ANIMATE147, m_grid147);
	DDX_Control(pDX, IDC_ANIMATE146, m_grid146);
	DDX_Control(pDX, IDC_ANIMATE145, m_grid145);
	DDX_Control(pDX, IDC_ANIMATE144, m_grid144);
	DDX_Control(pDX, IDC_ANIMATE143, m_grid143);
	DDX_Control(pDX, IDC_ANIMATE142, m_grid142);
	DDX_Control(pDX, IDC_ANIMATE141, m_grid141);
	DDX_Control(pDX, IDC_ANIMATE140, m_grid140);
	DDX_Control(pDX, IDC_ANIMATE14, m_grid14);
	DDX_Control(pDX, IDC_ANIMATE139, m_grid139);
	DDX_Control(pDX, IDC_ANIMATE138, m_grid138);
	DDX_Control(pDX, IDC_ANIMATE137, m_grid137);
	DDX_Control(pDX, IDC_ANIMATE136, m_grid136);
	DDX_Control(pDX, IDC_ANIMATE135, m_grid135);
	DDX_Control(pDX, IDC_ANIMATE134, m_grid134);
	DDX_Control(pDX, IDC_ANIMATE133, m_grid133);
	DDX_Control(pDX, IDC_ANIMATE132, m_grid132);
	DDX_Control(pDX, IDC_ANIMATE131, m_grid131);
	DDX_Control(pDX, IDC_ANIMATE130, m_grid130);
	DDX_Control(pDX, IDC_ANIMATE13, m_grid13);
	DDX_Control(pDX, IDC_ANIMATE129, m_grid129);
	DDX_Control(pDX, IDC_ANIMATE128, m_grid128);
	DDX_Control(pDX, IDC_ANIMATE127, m_grid127);
	DDX_Control(pDX, IDC_ANIMATE126, m_grid126);
	DDX_Control(pDX, IDC_ANIMATE125, m_grid125);
	DDX_Control(pDX, IDC_ANIMATE124, m_grid124);
	DDX_Control(pDX, IDC_ANIMATE123, m_grid123);
	DDX_Control(pDX, IDC_ANIMATE122, m_grid122);
	DDX_Control(pDX, IDC_ANIMATE121, m_grid121);
	DDX_Control(pDX, IDC_ANIMATE120, m_grid120);
	DDX_Control(pDX, IDC_ANIMATE12, m_grid12);
	DDX_Control(pDX, IDC_ANIMATE119, m_grid119);
	DDX_Control(pDX, IDC_ANIMATE118, m_grid118);
	DDX_Control(pDX, IDC_ANIMATE117, m_grid117);
	DDX_Control(pDX, IDC_ANIMATE116, m_grid116);
	DDX_Control(pDX, IDC_ANIMATE115, m_grid115);
	DDX_Control(pDX, IDC_ANIMATE114, m_grid114);
	DDX_Control(pDX, IDC_ANIMATE113, m_grid113);
	DDX_Control(pDX, IDC_ANIMATE112, m_grid112);
	DDX_Control(pDX, IDC_ANIMATE111, m_grid111);
	DDX_Control(pDX, IDC_ANIMATE110, m_grid110);
	DDX_Control(pDX, IDC_ANIMATE11, m_grid11);
	DDX_Control(pDX, IDC_ANIMATE109, m_grid109);
	DDX_Control(pDX, IDC_ANIMATE108, m_grid108);
	DDX_Control(pDX, IDC_ANIMATE107, m_grid107);
	DDX_Control(pDX, IDC_ANIMATE106, m_grid106);
	DDX_Control(pDX, IDC_ANIMATE105, m_grid105);
	DDX_Control(pDX, IDC_ANIMATE104, m_grid104);
	DDX_Control(pDX, IDC_ANIMATE103, m_grid103);
	DDX_Control(pDX, IDC_ANIMATE102, m_grid102);
	DDX_Control(pDX, IDC_ANIMATE101, m_grid101);
	DDX_Control(pDX, IDC_ANIMATE100, m_grid100);
	DDX_Control(pDX, IDC_ANIMATE10, m_grid10);
	DDX_Control(pDX, IDC_ANIMATE1, m_grid1);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(MazeWindow, CDialog)
	//{{AFX_MSG_MAP(MazeWindow)
	ON_BN_CLICKED(IDC_BUTTON3, OnSolve)
	ON_BN_CLICKED(IDC_BUTTON5, OnClose)
	ON_BN_CLICKED(IDC_BUTTON6, OnUP)
	ON_BN_CLICKED(IDC_BUTTON7, OnDOWN)
	ON_BN_CLICKED(IDC_BUTTON8, OnLEFT)
	ON_BN_CLICKED(IDC_BUTTON9, OnRIGHT)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// MazeWindow message handlers

/*******************************************************
*	This function places all the proper AVI animations *
*	into their proper Control Boxes.  It then starts   *
*	them playing.                                      *
*******************************************************/
void MazeWindow::DrawScreen(char* MazeConfig)
{
	//The Open function needs a file name which is
	//determined by calling the DetermineAVI function.
	m_grid1.Open(DetermineAVI(MazeConfig[0]));

	//Play the AVIs from frame 0 to end and loop continuously
	m_grid1.Play(0, -1, -1);

	//Repeat for all animation controls
	m_grid2.Open(DetermineAVI(MazeConfig[1]));
	m_grid2.Play(0, -1, -1);
	m_grid3.Open(DetermineAVI(MazeConfig[2]));
	m_grid3.Play(0, -1, -1);
	m_grid4.Open(DetermineAVI(MazeConfig[3]));
	m_grid4.Play(0, -1, -1);
	m_grid5.Open(DetermineAVI(MazeConfig[4]));
	m_grid5.Play(0, -1, -1);
	m_grid6.Open(DetermineAVI(MazeConfig[5]));
	m_grid6.Play(0, -1, -1);
	m_grid7.Open(DetermineAVI(MazeConfig[6]));
	m_grid7.Play(0, -1, -1);
	m_grid8.Open(DetermineAVI(MazeConfig[7]));
	m_grid8.Play(0, -1, -1);
	m_grid9.Open(DetermineAVI(MazeConfig[8]));
	m_grid9.Play(0, -1, -1);
	m_grid10.Open(DetermineAVI(MazeConfig[9]));
	m_grid10.Play(0, -1, -1);
	m_grid11.Open(DetermineAVI(MazeConfig[10]));
	m_grid11.Play(0, -1, -1);
	m_grid12.Open(DetermineAVI(MazeConfig[11]));
	m_grid12.Play(0, -1, -1);
	m_grid13.Open(DetermineAVI(MazeConfig[12]));
	m_grid13.Play(0, -1, -1);
	m_grid14.Open(DetermineAVI(MazeConfig[13]));
	m_grid14.Play(0, -1, -1);
	m_grid15.Open(DetermineAVI(MazeConfig[14]));
	m_grid15.Play(0, -1, -1);
	m_grid16.Open(DetermineAVI(MazeConfig[15]));
	m_grid16.Play(0, -1, -1);
	m_grid17.Open(DetermineAVI(MazeConfig[16]));
	m_grid17.Play(0, -1, -1);
	m_grid18.Open(DetermineAVI(MazeConfig[17]));
	m_grid18.Play(0, -1, -1);
	m_grid19.Open(DetermineAVI(MazeConfig[18]));
	m_grid19.Play(0, -1, -1);
	m_grid20.Open(DetermineAVI(MazeConfig[19]));
	m_grid20.Play(0, -1, -1);
	m_grid21.Open(DetermineAVI(MazeConfig[20]));
	m_grid21.Play(0, -1, -1);
	m_grid22.Open(DetermineAVI(MazeConfig[21]));
	m_grid22.Play(0, -1, -1);
	m_grid23.Open(DetermineAVI(MazeConfig[22]));
	m_grid23.Play(0, -1, -1);
	m_grid24.Open(DetermineAVI(MazeConfig[23]));
	m_grid24.Play(0, -1, -1);
	m_grid25.Open(DetermineAVI(MazeConfig[24]));
	m_grid25.Play(0, -1, -1);
	m_grid26.Open(DetermineAVI(MazeConfig[25]));
	m_grid26.Play(0, -1, -1);
	m_grid27.Open(DetermineAVI(MazeConfig[26]));
	m_grid27.Play(0, -1, -1);
	m_grid28.Open(DetermineAVI(MazeConfig[27]));
	m_grid28.Play(0, -1, -1);
	m_grid29.Open(DetermineAVI(MazeConfig[28]));
	m_grid29.Play(0, -1, -1);
	m_grid30.Open(DetermineAVI(MazeConfig[29]));
	m_grid30.Play(0, -1, -1);
	m_grid31.Open(DetermineAVI(MazeConfig[30]));
	m_grid31.Play(0, -1, -1);
	m_grid32.Open(DetermineAVI(MazeConfig[31]));
	m_grid32.Play(0, -1, -1);
	m_grid33.Open(DetermineAVI(MazeConfig[32]));
	m_grid33.Play(0, -1, -1);
	m_grid34.Open(DetermineAVI(MazeConfig[33]));
	m_grid34.Play(0, -1, -1);
	m_grid35.Open(DetermineAVI(MazeConfig[34]));
	m_grid35.Play(0, -1, -1);
	m_grid36.Open(DetermineAVI(MazeConfig[35]));
	m_grid36.Play(0, -1, -1);
	m_grid37.Open(DetermineAVI(MazeConfig[36]));
	m_grid37.Play(0, -1, -1);
	m_grid38.Open(DetermineAVI(MazeConfig[37]));
	m_grid38.Play(0, -1, -1);
	m_grid39.Open(DetermineAVI(MazeConfig[38]));
	m_grid39.Play(0, -1, -1);
	m_grid40.Open(DetermineAVI(MazeConfig[39]));
	m_grid40.Play(0, -1, -1);
	m_grid41.Open(DetermineAVI(MazeConfig[40]));
	m_grid41.Play(0, -1, -1);
	m_grid42.Open(DetermineAVI(MazeConfig[41]));
	m_grid42.Play(0, -1, -1);
	m_grid43.Open(DetermineAVI(MazeConfig[42]));
	m_grid43.Play(0, -1, -1);
	m_grid44.Open(DetermineAVI(MazeConfig[43]));
	m_grid44.Play(0, -1, -1);
	m_grid45.Open(DetermineAVI(MazeConfig[44]));
	m_grid45.Play(0, -1, -1);
	m_grid46.Open(DetermineAVI(MazeConfig[45]));
	m_grid46.Play(0, -1, -1);
	m_grid47.Open(DetermineAVI(MazeConfig[46]));
	m_grid47.Play(0, -1, -1);
	m_grid48.Open(DetermineAVI(MazeConfig[47]));
	m_grid48.Play(0, -1, -1);
	m_grid49.Open(DetermineAVI(MazeConfig[48]));
	m_grid49.Play(0, -1, -1);
	m_grid50.Open(DetermineAVI(MazeConfig[49]));
	m_grid50.Play(0, -1, -1);
	m_grid51.Open(DetermineAVI(MazeConfig[50]));
	m_grid51.Play(0, -1, -1);
	m_grid52.Open(DetermineAVI(MazeConfig[51]));
	m_grid52.Play(0, -1, -1);
	m_grid53.Open(DetermineAVI(MazeConfig[52]));
	m_grid53.Play(0, -1, -1);
	m_grid54.Open(DetermineAVI(MazeConfig[53]));
	m_grid54.Play(0, -1, -1);
	m_grid55.Open(DetermineAVI(MazeConfig[54]));
	m_grid55.Play(0, -1, -1);
	m_grid56.Open(DetermineAVI(MazeConfig[55]));
	m_grid56.Play(0, -1, -1);
	m_grid57.Open(DetermineAVI(MazeConfig[56]));
	m_grid57.Play(0, -1, -1);
	m_grid58.Open(DetermineAVI(MazeConfig[57]));
	m_grid58.Play(0, -1, -1);
	m_grid59.Open(DetermineAVI(MazeConfig[58]));
	m_grid59.Play(0, -1, -1);
	m_grid60.Open(DetermineAVI(MazeConfig[59]));
	m_grid60.Play(0, -1, -1);
	m_grid61.Open(DetermineAVI(MazeConfig[60]));
	m_grid61.Play(0, -1, -1);
	m_grid62.Open(DetermineAVI(MazeConfig[61]));
	m_grid62.Play(0, -1, -1);
	m_grid63.Open(DetermineAVI(MazeConfig[62]));
	m_grid63.Play(0, -1, -1);
	m_grid64.Open(DetermineAVI(MazeConfig[63]));
	m_grid64.Play(0, -1, -1);
	m_grid65.Open(DetermineAVI(MazeConfig[64]));
	m_grid65.Play(0, -1, -1);
	m_grid66.Open(DetermineAVI(MazeConfig[65]));
	m_grid66.Play(0, -1, -1);
	m_grid67.Open(DetermineAVI(MazeConfig[66]));
	m_grid67.Play(0, -1, -1);
	m_grid68.Open(DetermineAVI(MazeConfig[67]));
	m_grid68.Play(0, -1, -1);
	m_grid69.Open(DetermineAVI(MazeConfig[68]));
	m_grid69.Play(0, -1, -1);
	m_grid70.Open(DetermineAVI(MazeConfig[69]));
	m_grid70.Play(0, -1, -1);
	m_grid71.Open(DetermineAVI(MazeConfig[70]));
	m_grid71.Play(0, -1, -1);
	m_grid72.Open(DetermineAVI(MazeConfig[71]));
	m_grid72.Play(0, -1, -1);
	m_grid73.Open(DetermineAVI(MazeConfig[72]));
	m_grid73.Play(0, -1, -1);
	m_grid74.Open(DetermineAVI(MazeConfig[73]));
	m_grid74.Play(0, -1, -1);
	m_grid75.Open(DetermineAVI(MazeConfig[74]));
	m_grid75.Play(0, -1, -1);
	m_grid76.Open(DetermineAVI(MazeConfig[75]));
	m_grid76.Play(0, -1, -1);
	m_grid77.Open(DetermineAVI(MazeConfig[76]));
	m_grid77.Play(0, -1, -1);
	m_grid78.Open(DetermineAVI(MazeConfig[77]));
	m_grid78.Play(0, -1, -1);
	m_grid79.Open(DetermineAVI(MazeConfig[78]));
	m_grid79.Play(0, -1, -1);
	m_grid80.Open(DetermineAVI(MazeConfig[79]));
	m_grid80.Play(0, -1, -1);
	m_grid81.Open(DetermineAVI(MazeConfig[80]));
	m_grid81.Play(0, -1, -1);
	m_grid82.Open(DetermineAVI(MazeConfig[81]));
	m_grid82.Play(0, -1, -1);
	m_grid83.Open(DetermineAVI(MazeConfig[82]));
	m_grid83.Play(0, -1, -1);
	m_grid84.Open(DetermineAVI(MazeConfig[83]));
	m_grid84.Play(0, -1, -1);
	m_grid85.Open(DetermineAVI(MazeConfig[84]));
	m_grid85.Play(0, -1, -1);
	m_grid86.Open(DetermineAVI(MazeConfig[85]));
	m_grid86.Play(0, -1, -1);
	m_grid87.Open(DetermineAVI(MazeConfig[86]));
	m_grid87.Play(0, -1, -1);
	m_grid88.Open(DetermineAVI(MazeConfig[87]));
	m_grid88.Play(0, -1, -1);
	m_grid89.Open(DetermineAVI(MazeConfig[88]));
	m_grid89.Play(0, -1, -1);
	m_grid90.Open(DetermineAVI(MazeConfig[89]));
	m_grid90.Play(0, -1, -1);
	m_grid91.Open(DetermineAVI(MazeConfig[90]));
	m_grid91.Play(0, -1, -1);
	m_grid92.Open(DetermineAVI(MazeConfig[91]));
	m_grid92.Play(0, -1, -1);
	m_grid93.Open(DetermineAVI(MazeConfig[92]));
	m_grid93.Play(0, -1, -1);
	m_grid94.Open(DetermineAVI(MazeConfig[93]));
	m_grid94.Play(0, -1, -1);
	m_grid95.Open(DetermineAVI(MazeConfig[94]));
	m_grid95.Play(0, -1, -1);
	m_grid96.Open(DetermineAVI(MazeConfig[95]));
	m_grid96.Play(0, -1, -1);
	m_grid97.Open(DetermineAVI(MazeConfig[96]));
	m_grid97.Play(0, -1, -1);
	m_grid98.Open(DetermineAVI(MazeConfig[97]));
	m_grid98.Play(0, -1, -1);
	m_grid99.Open(DetermineAVI(MazeConfig[98]));
	m_grid99.Play(0, -1, -1);
	m_grid100.Open(DetermineAVI(MazeConfig[99]));
	m_grid100.Play(0, -1, -1);
	m_grid101.Open(DetermineAVI(MazeConfig[100]));
	m_grid101.Play(0, -1, -1);
	m_grid102.Open(DetermineAVI(MazeConfig[101]));
	m_grid102.Play(0, -1, -1);
	m_grid103.Open(DetermineAVI(MazeConfig[102]));
	m_grid103.Play(0, -1, -1);
	m_grid104.Open(DetermineAVI(MazeConfig[103]));
	m_grid104.Play(0, -1, -1);
	m_grid105.Open(DetermineAVI(MazeConfig[104]));
	m_grid105.Play(0, -1, -1);
	m_grid106.Open(DetermineAVI(MazeConfig[105]));
	m_grid106.Play(0, -1, -1);
	m_grid107.Open(DetermineAVI(MazeConfig[106]));
	m_grid107.Play(0, -1, -1);
	m_grid108.Open(DetermineAVI(MazeConfig[107]));
	m_grid108.Play(0, -1, -1);
	m_grid109.Open(DetermineAVI(MazeConfig[108]));
	m_grid109.Play(0, -1, -1);
	m_grid110.Open(DetermineAVI(MazeConfig[109]));
	m_grid110.Play(0, -1, -1);
	m_grid111.Open(DetermineAVI(MazeConfig[110]));
	m_grid111.Play(0, -1, -1);
	m_grid112.Open(DetermineAVI(MazeConfig[111]));
	m_grid112.Play(0, -1, -1);
	m_grid113.Open(DetermineAVI(MazeConfig[112]));
	m_grid113.Play(0, -1, -1);
	m_grid114.Open(DetermineAVI(MazeConfig[113]));
	m_grid114.Play(0, -1, -1);
	m_grid115.Open(DetermineAVI(MazeConfig[114]));
	m_grid115.Play(0, -1, -1);
	m_grid116.Open(DetermineAVI(MazeConfig[115]));
	m_grid116.Play(0, -1, -1);
	m_grid117.Open(DetermineAVI(MazeConfig[116]));
	m_grid117.Play(0, -1, -1);
	m_grid118.Open(DetermineAVI(MazeConfig[117]));
	m_grid118.Play(0, -1, -1);
	m_grid119.Open(DetermineAVI(MazeConfig[118]));
	m_grid119.Play(0, -1, -1);
	m_grid120.Open(DetermineAVI(MazeConfig[119]));
	m_grid120.Play(0, -1, -1);
	m_grid121.Open(DetermineAVI(MazeConfig[120]));
	m_grid121.Play(0, -1, -1);
	m_grid122.Open(DetermineAVI(MazeConfig[121]));
	m_grid122.Play(0, -1, -1);
	m_grid123.Open(DetermineAVI(MazeConfig[122]));
	m_grid123.Play(0, -1, -1);
	m_grid124.Open(DetermineAVI(MazeConfig[123]));
	m_grid124.Play(0, -1, -1);
	m_grid125.Open(DetermineAVI(MazeConfig[124]));
	m_grid125.Play(0, -1, -1);
	m_grid126.Open(DetermineAVI(MazeConfig[125]));
	m_grid126.Play(0, -1, -1);
	m_grid127.Open(DetermineAVI(MazeConfig[126]));
	m_grid127.Play(0, -1, -1);
	m_grid128.Open(DetermineAVI(MazeConfig[127]));
	m_grid128.Play(0, -1, -1);
	m_grid129.Open(DetermineAVI(MazeConfig[128]));
	m_grid129.Play(0, -1, -1);
	m_grid130.Open(DetermineAVI(MazeConfig[129]));
	m_grid130.Play(0, -1, -1);
	m_grid131.Open(DetermineAVI(MazeConfig[130]));
	m_grid131.Play(0, -1, -1);
	m_grid132.Open(DetermineAVI(MazeConfig[131]));
	m_grid132.Play(0, -1, -1);
	m_grid133.Open(DetermineAVI(MazeConfig[132]));
	m_grid133.Play(0, -1, -1);
	m_grid134.Open(DetermineAVI(MazeConfig[133]));
	m_grid134.Play(0, -1, -1);
	m_grid135.Open(DetermineAVI(MazeConfig[134]));
	m_grid135.Play(0, -1, -1);
	m_grid136.Open(DetermineAVI(MazeConfig[135]));
	m_grid136.Play(0, -1, -1);
	m_grid137.Open(DetermineAVI(MazeConfig[136]));
	m_grid137.Play(0, -1, -1);
	m_grid138.Open(DetermineAVI(MazeConfig[137]));
	m_grid138.Play(0, -1, -1);
	m_grid139.Open(DetermineAVI(MazeConfig[138]));
	m_grid139.Play(0, -1, -1);
	m_grid140.Open(DetermineAVI(MazeConfig[139]));
	m_grid140.Play(0, -1, -1);
	m_grid141.Open(DetermineAVI(MazeConfig[140]));
	m_grid141.Play(0, -1, -1);
	m_grid142.Open(DetermineAVI(MazeConfig[141]));
	m_grid142.Play(0, -1, -1);
	m_grid143.Open(DetermineAVI(MazeConfig[142]));
	m_grid143.Play(0, -1, -1);
	m_grid144.Open(DetermineAVI(MazeConfig[143]));
	m_grid144.Play(0, -1, -1);
	m_grid145.Open(DetermineAVI(MazeConfig[144]));
	m_grid145.Play(0, -1, -1);
	m_grid146.Open(DetermineAVI(MazeConfig[145]));
	m_grid146.Play(0, -1, -1);
	m_grid147.Open(DetermineAVI(MazeConfig[146]));
	m_grid147.Play(0, -1, -1);
	m_grid148.Open(DetermineAVI(MazeConfig[147]));
	m_grid148.Play(0, -1, -1);
	m_grid149.Open(DetermineAVI(MazeConfig[148]));
	m_grid149.Play(0, -1, -1);
	m_grid150.Open(DetermineAVI(MazeConfig[149]));
	m_grid150.Play(0, -1, -1);
	m_grid151.Open(DetermineAVI(MazeConfig[150]));
	m_grid151.Play(0, -1, -1);
	m_grid152.Open(DetermineAVI(MazeConfig[151]));
	m_grid152.Play(0, -1, -1);
	m_grid153.Open(DetermineAVI(MazeConfig[152]));
	m_grid153.Play(0, -1, -1);
	m_grid154.Open(DetermineAVI(MazeConfig[153]));
	m_grid154.Play(0, -1, -1);
	m_grid155.Open(DetermineAVI(MazeConfig[154]));
	m_grid155.Play(0, -1, -1);
	m_grid156.Open(DetermineAVI(MazeConfig[155]));
	m_grid156.Play(0, -1, -1);
	m_grid157.Open(DetermineAVI(MazeConfig[156]));
	m_grid157.Play(0, -1, -1);
	m_grid158.Open(DetermineAVI(MazeConfig[157]));
	m_grid158.Play(0, -1, -1);
	m_grid159.Open(DetermineAVI(MazeConfig[158]));
	m_grid159.Play(0, -1, -1);
	m_grid160.Open(DetermineAVI(MazeConfig[159]));
	m_grid160.Play(0, -1, -1);
	m_grid161.Open(DetermineAVI(MazeConfig[160]));
	m_grid161.Play(0, -1, -1);
	m_grid162.Open(DetermineAVI(MazeConfig[161]));
	m_grid162.Play(0, -1, -1);
	m_grid163.Open(DetermineAVI(MazeConfig[162]));
	m_grid163.Play(0, -1, -1);
	m_grid164.Open(DetermineAVI(MazeConfig[163]));
	m_grid164.Play(0, -1, -1);
	m_grid165.Open(DetermineAVI(MazeConfig[164]));
	m_grid165.Play(0, -1, -1);
	m_grid166.Open(DetermineAVI(MazeConfig[165]));
	m_grid166.Play(0, -1, -1);
	m_grid167.Open(DetermineAVI(MazeConfig[166]));
	m_grid167.Play(0, -1, -1);
	m_grid168.Open(DetermineAVI(MazeConfig[167]));
	m_grid168.Play(0, -1, -1);
	m_grid169.Open(DetermineAVI(MazeConfig[168]));
	m_grid169.Play(0, -1, -1);
	m_grid170.Open(DetermineAVI(MazeConfig[169]));
	m_grid170.Play(0, -1, -1);
	m_grid171.Open(DetermineAVI(MazeConfig[170]));
	m_grid171.Play(0, -1, -1);
	m_grid172.Open(DetermineAVI(MazeConfig[171]));
	m_grid172.Play(0, -1, -1);
	m_grid173.Open(DetermineAVI(MazeConfig[172]));
	m_grid173.Play(0, -1, -1);
	m_grid174.Open(DetermineAVI(MazeConfig[173]));
	m_grid174.Play(0, -1, -1);
	m_grid175.Open(DetermineAVI(MazeConfig[174]));
	m_grid175.Play(0, -1, -1);
	m_grid176.Open(DetermineAVI(MazeConfig[175]));
	m_grid176.Play(0, -1, -1);
	m_grid177.Open(DetermineAVI(MazeConfig[176]));
	m_grid177.Play(0, -1, -1);
	m_grid178.Open(DetermineAVI(MazeConfig[177]));
	m_grid178.Play(0, -1, -1);
	m_grid179.Open(DetermineAVI(MazeConfig[178]));
	m_grid179.Play(0, -1, -1);
	m_grid180.Open(DetermineAVI(MazeConfig[179]));
	m_grid180.Play(0, -1, -1);
	m_grid181.Open(DetermineAVI(MazeConfig[180]));
	m_grid181.Play(0, -1, -1);
	m_grid182.Open(DetermineAVI(MazeConfig[181]));
	m_grid182.Play(0, -1, -1);
	m_grid183.Open(DetermineAVI(MazeConfig[182]));
	m_grid183.Play(0, -1, -1);
	m_grid184.Open(DetermineAVI(MazeConfig[183]));
	m_grid184.Play(0, -1, -1);
	m_grid185.Open(DetermineAVI(MazeConfig[184]));
	m_grid185.Play(0, -1, -1);
	m_grid186.Open(DetermineAVI(MazeConfig[185]));
	m_grid186.Play(0, -1, -1);
	m_grid187.Open(DetermineAVI(MazeConfig[186]));
	m_grid187.Play(0, -1, -1);
	m_grid188.Open(DetermineAVI(MazeConfig[187]));
	m_grid188.Play(0, -1, -1);
	m_grid189.Open(DetermineAVI(MazeConfig[188]));
	m_grid189.Play(0, -1, -1);
	m_grid190.Open(DetermineAVI(MazeConfig[189]));
	m_grid190.Play(0, -1, -1);
	m_grid191.Open(DetermineAVI(MazeConfig[190]));
	m_grid191.Play(0, -1, -1);
	m_grid192.Open(DetermineAVI(MazeConfig[191]));
	m_grid192.Play(0, -1, -1);
	m_grid193.Open(DetermineAVI(MazeConfig[192]));
	m_grid193.Play(0, -1, -1);
	m_grid194.Open(DetermineAVI(MazeConfig[193]));
	m_grid194.Play(0, -1, -1);
	m_grid195.Open(DetermineAVI(MazeConfig[194]));
	m_grid195.Play(0, -1, -1);
	m_grid196.Open(DetermineAVI(MazeConfig[195]));
	m_grid196.Play(0, -1, -1);
	m_grid197.Open(DetermineAVI(MazeConfig[196]));
	m_grid197.Play(0, -1, -1);
	m_grid198.Open(DetermineAVI(MazeConfig[197]));
	m_grid198.Play(0, -1, -1);
	m_grid199.Open(DetermineAVI(MazeConfig[198]));
	m_grid199.Play(0, -1, -1);
	m_grid200.Open(DetermineAVI(MazeConfig[199]));
	m_grid200.Play(0, -1, -1);
	m_grid201.Open(DetermineAVI(MazeConfig[200]));
	m_grid201.Play(0, -1, -1);
	m_grid202.Open(DetermineAVI(MazeConfig[201]));
	m_grid202.Play(0, -1, -1);
	m_grid203.Open(DetermineAVI(MazeConfig[202]));
	m_grid203.Play(0, -1, -1);
	m_grid204.Open(DetermineAVI(MazeConfig[203]));
	m_grid204.Play(0, -1, -1);
	m_grid205.Open(DetermineAVI(MazeConfig[204]));
	m_grid205.Play(0, -1, -1);
	m_grid206.Open(DetermineAVI(MazeConfig[205]));
	m_grid206.Play(0, -1, -1);
	m_grid207.Open(DetermineAVI(MazeConfig[206]));
	m_grid207.Play(0, -1, -1);
	m_grid208.Open(DetermineAVI(MazeConfig[207]));
	m_grid208.Play(0, -1, -1);
	m_grid209.Open(DetermineAVI(MazeConfig[208]));
	m_grid209.Play(0, -1, -1);
	m_grid210.Open(DetermineAVI(MazeConfig[209]));
	m_grid210.Play(0, -1, -1);
	m_grid211.Open(DetermineAVI(MazeConfig[210]));
	m_grid211.Play(0, -1, -1);
	m_grid212.Open(DetermineAVI(MazeConfig[211]));
	m_grid212.Play(0, -1, -1);
	m_grid213.Open(DetermineAVI(MazeConfig[212]));
	m_grid213.Play(0, -1, -1);
	m_grid214.Open(DetermineAVI(MazeConfig[213]));
	m_grid214.Play(0, -1, -1);
	m_grid215.Open(DetermineAVI(MazeConfig[214]));
	m_grid215.Play(0, -1, -1);
	m_grid216.Open(DetermineAVI(MazeConfig[215]));
	m_grid216.Play(0, -1, -1);
	m_grid217.Open(DetermineAVI(MazeConfig[216]));
	m_grid217.Play(0, -1, -1);
	m_grid218.Open(DetermineAVI(MazeConfig[217]));
	m_grid218.Play(0, -1, -1);
	m_grid219.Open(DetermineAVI(MazeConfig[218]));
	m_grid219.Play(0, -1, -1);
	m_grid220.Open(DetermineAVI(MazeConfig[219]));
	m_grid220.Play(0, -1, -1);
	m_grid221.Open(DetermineAVI(MazeConfig[220]));
	m_grid221.Play(0, -1, -1);
	m_grid222.Open(DetermineAVI(MazeConfig[221]));
	m_grid222.Play(0, -1, -1);
	m_grid223.Open(DetermineAVI(MazeConfig[222]));
	m_grid223.Play(0, -1, -1);
	m_grid224.Open(DetermineAVI(MazeConfig[223]));
	m_grid224.Play(0, -1, -1);
	m_grid225.Open(DetermineAVI(MazeConfig[224]));
	m_grid225.Play(0, -1, -1);
	m_grid226.Open(DetermineAVI(MazeConfig[225]));
	m_grid226.Play(0, -1, -1);
	m_grid227.Open(DetermineAVI(MazeConfig[226]));
	m_grid227.Play(0, -1, -1);
	m_grid228.Open(DetermineAVI(MazeConfig[227]));
	m_grid228.Play(0, -1, -1);
	m_grid229.Open(DetermineAVI(MazeConfig[228]));
	m_grid229.Play(0, -1, -1);
	m_grid230.Open(DetermineAVI(MazeConfig[229]));
	m_grid230.Play(0, -1, -1);
	m_grid231.Open(DetermineAVI(MazeConfig[230]));
	m_grid231.Play(0, -1, -1);
	m_grid232.Open(DetermineAVI(MazeConfig[231]));
	m_grid232.Play(0, -1, -1);
	m_grid233.Open(DetermineAVI(MazeConfig[232]));
	m_grid233.Play(0, -1, -1);
	m_grid234.Open(DetermineAVI(MazeConfig[233]));
	m_grid234.Play(0, -1, -1);
	m_grid235.Open(DetermineAVI(MazeConfig[234]));
	m_grid235.Play(0, -1, -1);
	m_grid236.Open(DetermineAVI(MazeConfig[235]));
	m_grid236.Play(0, -1, -1);
	m_grid237.Open(DetermineAVI(MazeConfig[236]));
	m_grid237.Play(0, -1, -1);
	m_grid238.Open(DetermineAVI(MazeConfig[237]));
	m_grid238.Play(0, -1, -1);
	m_grid239.Open(DetermineAVI(MazeConfig[238]));
	m_grid239.Play(0, -1, -1);
	m_grid240.Open(DetermineAVI(MazeConfig[239]));
	m_grid240.Play(0, -1, -1);


}

/*******************************************************
*	The function that is used above to determine which *
*	AVI file is to be loaded.  The letters taken in    *
*	correspond with the INDEX used in the maze creator *
*******************************************************/
CString MazeWindow::DetermineAVI(char CellType)
{
	//Switch taking in a single char returngin the appropriate AVI file
	switch (CellType)
	{
	case 'w':
		return "water.avi";
		break;
	case 'b':
		return "brick.avi";
		break;
	case 'f':
		return "fire.avi";
		break;
	case 't':
		return "Tree.avi";
		break;
	case 'p':
		return "Path.avi";
		break;
	case 'm':
		return "Face.avi";
		break;
	case 'x':
		return "Exit.avi";
		break;
	default:
		return "brick.avi";
	}
}

//Maze Window Initilizer
BOOL MazeWindow::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	//Draw the maze graphics
	DrawScreen(TheMaze);


	//Init variable
	int counter = 0;

	for (int y = 0; y < 12; y++){
		for (int x = 0; x < 20; x++){
			//Load the Maze characters into an X Y 2D array
			MazeGrid[x][y] = TheMaze[counter];
			counter++;
			//Set the location of the MAN when it comes across him
			if (MazeGrid[x][y] == 'm'){
				manX = x;
				manY = y;
			}
		}
	}

	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}


/***************************************************************
*	This is where all the brains and A.I. of the program are.  *
*	This function is used to solve a maze or to determine if it*
*	is not solvable.  It uses the stack ADT to find its way    *
*   through the maze.  If there are multiple paths it usually  *
*	find the most reasonably quickest path to the end          *
***************************************************************/
void MazeWindow::OnSolve() 
{
	//IF the computer and the Player had not solved the maze yet
	if (!ComputerSolved && !PlayerFoundExit){
		//Counter variable
		int counter = 0;
	
		//Enumeration for directions to make life simpler
		enum direction
		{UP, DOWN, LEFT, RIGHT};
	
		//Create the stack for the Directions you've
		Stack Directions;
	
		//An array that will hold the grid to say where you have been
		int WhereYouHaveBeen[20][12] = {0};
	
		for (int y = 0; y < 12; y++){
			for (int x = 0; x < 20; x++){
				//Load the Maze characters into an X Y 2D array
				MazeGrid[x][y] = TheMaze[counter];
				counter++;
	
				//If it is not a path say that you have been there
				if (MazeGrid[x][y] != 'p')
					WhereYouHaveBeen[x][y] = 1;
	
				//If it is the exit say that you have not been there
				if (MazeGrid[x][y] == 'x')
					WhereYouHaveBeen[x][y] = 0;
	
				//Set the location of the MAN when it comes across him
				if (MazeGrid[x][y] == 'm'){
					WhereYouHaveBeen[x][y] = 1;
					manX = x;
					manY = y;
				}
			}
		}
	
		//Create the variable for when the maze is determined to be finished
		bool finished = false;
	
		//Variable to hold if the maze is solvable or not
		bool solvable = false;
	
		//While the maze is not solved
		while (finished == false){
	
			/************************************************************
			*	Below are 4 checks to check all 4 directions.  As long  *
			*	as you can move it continually checks RIGHT, UP, LEFT   *
			*	and DOWN.  If all directions are blocked or you have    *
			*	been there it jumps into the last ELSE where it pops    *
			*	your directions off until it finds somewhere it hasn't  *
			*	Been yet.  Then continues checknig normally				*
			************************************************************/
			//Check to move RIGHT
			//Check if allowed to move there
			if ((MazeGrid[manX + 1][manY] == 'p' || MazeGrid[manX + 1][manY] == 'x')
	
				//Have not been there yet
				&& WhereYouHaveBeen[manX + 1][manY] != 1
	
				//is not leaving the array
				&& manX + 1 <= 19){
	
				//Checks for the end of the maze
				if (MazeGrid[manX + 1][manY] == 'x'){
					ComputerSolved = true;
					solvable = true;
					finished = true;
				}
				
				//Change present cell to path
				MazeGrid[manX][manY] = 'p';
	
				//Change next Cell to MAN
				MazeGrid[manX + 1][manY] = 'm';
	
				//push the direction RIGHT onto the stack
				Directions.push(RIGHT);
	
				//Change the MAN coordinate accordingly
				manX++;
		
				//Sets present cell saying you have been there
				WhereYouHaveBeen[manX][manY] = 1;
			}
	
			else//Same as previous but for UP
			if ((MazeGrid[manX][manY - 1] == 'p' || MazeGrid[manX][manY - 1] == 'x')
				&& WhereYouHaveBeen[manX][manY - 1] != 1
				&& manY - 1 >= 0){
				if (MazeGrid[manX][manY - 1] == 'x'){
					ComputerSolved = true;
					solvable = true;
					finished = true;
				}
				MazeGrid[manX][manY] = 'p';
				MazeGrid[manX][manY - 1] = 'm';
				Directions.push(UP);
				manY--;
				WhereYouHaveBeen[manX][manY] = 1;
			}
			else	
		
			//Same as previous but for LEFT
			if ((MazeGrid[manX - 1][manY] == 'p' || MazeGrid[manX - 1][manY] == 'x')
				&& WhereYouHaveBeen[manX - 1][manY] != 1
				&& manX - 1 >= 0){
				if (MazeGrid[manX - 1][manY] == 'x'){
					ComputerSolved = true;
					finished = true;
					solvable = true;
				}
				MazeGrid[manX][manY] = 'p';
				MazeGrid[manX - 1][manY] = 'm';
				Directions.push(LEFT);
				manX--;
				WhereYouHaveBeen[manX][manY] = 1;
			}	
	
			else
			//Same as previous but for DOWN
			if ((MazeGrid[manX][manY + 1] == 'p' || MazeGrid[manX][manY + 1] == 'x')
				&& WhereYouHaveBeen[manX][manY + 1] != 1
				&& manY + 1 <= 11){
				if (MazeGrid[manX][manY + 1] == 'x'){
					ComputerSolved = true;
					finished = true;
					solvable = true;
				}
				MazeGrid[manX][manY] = 'p';
				MazeGrid[manX][manY + 1] = 'm';
				Directions.push(DOWN);
				manY++;
				WhereYouHaveBeen[manX][manY] = 1;
			}
	
			else//ELSE if you are in a dead-end or have been there
			{
			
				while (//While you cant go somewhere new and are not going orr the grid and you are not at the start
					(WhereYouHaveBeen[manX + 1][manY] == 1  || manX + 1 > 19) &&
					(WhereYouHaveBeen[manX - 1][manY] == 1  || manX - 1 < 0 ) &&
					(WhereYouHaveBeen[manX][manY + 1] == 1  || manY + 1 > 11) &&
					(WhereYouHaveBeen[manX][manY - 1] == 1  || manY - 1 < 0 ) &&
					!Directions.IsStackEmpty()
					)
				{
	
					//Variable to hold the popped directions
					int BackTrack;
	
					//Pop the top direction off the stack into BackTrack
					BackTrack = Directions.pop();
	
					//Switch to do whats needed depending on direction popped
					switch (BackTrack){
					case UP:
						//Present AVI is 'p' for path
						MazeGrid[manX][manY] = 'p';
						//Increment the guy down
						manY++;
						//The new location gets the MAN AVI set
						MazeGrid[manX][manY] = 'm';
						break;
					
					//Same as above but for DOWN
					case DOWN:
						MazeGrid[manX][manY] = 'p';
						manY--;
						MazeGrid[manX][manY] = 'm';
						break;
	
					//Same as above but for LEFT
					case LEFT:
						MazeGrid[manX][manY] = 'p';
						manX++;
						MazeGrid[manX][manY] = 'm';
						break;
	
					//Same as above but for RIGHT
					case RIGHT:
						MazeGrid[manX][manY] = 'p';
						manX--;
						MazeGrid[manX][manY] = 'm';
						break;
	
					//Never going to happen
					default:
						break;
					}
	
					//Reset the counter
					counter = 0;
	
					//Put the new Grid into a single dimentional array to draw it
					for (int y = 0; y < 12; y++){
						for (int x = 0; x < 20; x++){
							TheMaze[counter] = MazeGrid[x][y];
							counter++;
						}
					}
				}
			}
	
		
			//reset the counter
			counter = 0;
	
			//Put the new Grid into a single dimentional array to draw it
			for (int y = 0; y < 12; y++){
				for (int x = 0; x < 20; x++){
					TheMaze[counter] = MazeGrid[x][y];
					counter++;
				}
			}
	
			//If the MAN is back at the start and the maze was deemed unsolvable
			if (
				(Directions.IsStackEmpty() && !solvable) &&
				(WhereYouHaveBeen[manX + 1][manY] == 1  || manX + 1 > 19) &&
				(WhereYouHaveBeen[manX - 1][manY] == 1  || manX - 1 < 0 ) &&
				(WhereYouHaveBeen[manX][manY + 1] == 1  || manY + 1 > 11) &&
				(WhereYouHaveBeen[manX][manY - 1] == 1  || manY - 1 < 0 )
				)
	
				//The maze is finished
				finished = true;
		}
	
		while (!Directions.IsStackEmpty()){
			
			//AfxMessageBox("in the box");
	
			int Path;
	
			//Pop the top direction off the stack into BackTrack
			Path = Directions.pop();
	
			//Switch to do whats needed depending on direction popped
			switch (Path){
			case UP:
				//Increment the guy down
				manY++;
				//The new location gets the MAN AVI set
				MazeGrid[manX][manY] = 'm';
				break;
			
			//Same as above but for DOWN
			case DOWN:
				manY--;
				MazeGrid[manX][manY] = 'm';
				break;
		
			//Same as above but for LEFT
			case LEFT:
				manX++;
				MazeGrid[manX][manY] = 'm';
				break;
	
			//Same as above but for RIGHT
			case RIGHT:
				manX--;
				MazeGrid[manX][manY] = 'm';
				break;
			//Never going to happen
			default:
				break;
			}
			
	
		}
	
		counter = 0;
		//Put the new Grid into a single dimentional array to draw it
		for (int q = 0; q < 12; q++){
			for (int r = 0; r < 20; r++){
				TheMaze[counter] = MazeGrid[r][q];
				counter++;
			}
		}
	
		//Redraw the screen
		DrawScreen(TheMaze);
	
		//Tell the user if the maze was solved or deemed unsolvable
		if (solvable)
			AfxMessageBox("This path leads to the exit!");
		else
			AfxMessageBox("This maze is UNSOLVABLE!!!");

	}

	else//If the maze has already been solved already then message user
		AfxMessageBox("The maze has already been solved!  Please load another maze");
}
	

//Used so the user can click a button to close the window
void MazeWindow::OnClose() 
{
	//End the currently open dialog box
	this->EndDialog(true);	
}


//When the user attempts to move UP
void MazeWindow::OnUP() 
{
	//IF the user and the computer have not fount an exit
	if (!PlayerFoundExit && !ComputerSolved){

		//Start a counter
		int counter = 0;
	
		//If UPWARDS is not outside of the array
		if (manY - 1 >= 0 &&
		//AND UPWARDS is a path or an exit
		(MazeGrid[manX][manY - 1] == 'p' || MazeGrid[manX][manY - 1] == 'x'))
		{
			//If UPWARDS is an exit
			if (MazeGrid[manX][manY - 1] == 'x')
				//Set that the player has found an exit
				PlayerFoundExit = true;

			//Set the present AVI to path
			MazeGrid[manX][manY] = 'p';

			//Set the new square AVI to the MAN
			MazeGrid[manX][manY - 1] = 'm';

			//Move the Man coordinate
			manY--;
		}

		//Load the new MazeGrid into a char ARRAY for later	
		for (int y = 0; y < 12; y++){
			for (int x = 0; x < 20; x++){
				TheMaze[counter] = MazeGrid[x][y];
				counter++;
			}
		}
	
		//Draw the new screen
		DrawScreen(TheMaze);

		//Let the player know if they found the exit
		if (PlayerFoundExit){
			AfxMessageBox("You found the exit!");
		}
	}
	else
		//If the the maze has already been solved then let the user know
		AfxMessageBox("The maze has already been solved!  Please load another maze");


}

//Same as above except for DOWNWARDS moving
void MazeWindow::OnDOWN() 
{
	if (!PlayerFoundExit && !ComputerSolved){
		int counter = 0;
	
		if (manY + 1 <= 11 &&
		(MazeGrid[manX][manY + 1] == 'p' || MazeGrid[manX][manY + 1] == 'x'))
		{
			if (MazeGrid[manX][manY + 1] == 'x')
				PlayerFoundExit = true;
			MazeGrid[manX][manY] = 'p';
			MazeGrid[manX][manY + 1] = 'm';
			manY++;
		}
	
		for (int y = 0; y < 12; y++){
			for (int x = 0; x < 20; x++){
				TheMaze[counter] = MazeGrid[x][y];
				counter++;
			}
		}
	
		DrawScreen(TheMaze);
		if (PlayerFoundExit)
			AfxMessageBox("You found the exit!");
	}
	else
		AfxMessageBox("The maze has already been solved!  Please load another maze");

}

//Same as above except for LEFTWARDS moving
void MazeWindow::OnLEFT() 
{
	if (!PlayerFoundExit && !ComputerSolved){
		int counter = 0;
	
		if (manX - 1 >= 0 &&
		(MazeGrid[manX - 1][manY] == 'p' || MazeGrid[manX - 1][manY] == 'x'))
		{
			if (MazeGrid[manX - 1][manY] == 'x')
				PlayerFoundExit = true;
			MazeGrid[manX][manY] = 'p';
			MazeGrid[manX - 1][manY] = 'm';
			manX--;
		}
	
		for (int y = 0; y < 12; y++){
			for (int x = 0; x < 20; x++){
				TheMaze[counter] = MazeGrid[x][y];
				counter++;
			}
		}
	
		DrawScreen(TheMaze);
		if (PlayerFoundExit)
			AfxMessageBox("You found the exit!");
	}
	else
		AfxMessageBox("The maze has already been solved!  Please load another maze");

	
	
}

//Same as above except for RIGHTWARDS moving
void MazeWindow::OnRIGHT() 
{
	if (!PlayerFoundExit && !ComputerSolved){
		int counter = 0;
	
		if (manX + 1 <= 19 &&
		(MazeGrid[manX + 1][manY] == 'p' || MazeGrid[manX + 1][manY] == 'x'))
		{
			if (MazeGrid[manX + 1][manY] == 'x')
				PlayerFoundExit = true;
			MazeGrid[manX][manY] = 'p';
			MazeGrid[manX + 1][manY] = 'm';
			manX++;
		}
	
		for (int y = 0; y < 12; y++){
			for (int x = 0; x < 20; x++){
				TheMaze[counter] = MazeGrid[x][y];
				counter++;
			}
		}
	
		DrawScreen(TheMaze);
		if (PlayerFoundExit)
			AfxMessageBox("You found the exit!");
	}
	else
		AfxMessageBox("The maze has already been solved!  Please load another maze");

}

