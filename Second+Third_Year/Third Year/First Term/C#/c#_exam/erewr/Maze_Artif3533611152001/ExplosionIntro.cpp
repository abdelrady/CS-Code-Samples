// ExplosionIntro.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "ExplosionIntro.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// ExplosionIntro dialog


ExplosionIntro::ExplosionIntro(CWnd* pParent /*=NULL*/)
	: CDialog(ExplosionIntro::IDD, pParent)
{
	//{{AFX_DATA_INIT(ExplosionIntro)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void ExplosionIntro::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(ExplosionIntro)
	DDX_Control(pDX, IDC_ANIMATE1, m_ani);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(ExplosionIntro, CDialog)
	//{{AFX_MSG_MAP(ExplosionIntro)
	ON_BN_CLICKED(IDC_BUTTON1, OnPlay)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// ExplosionIntro message handlers



BOOL ExplosionIntro::OnInitDialog() 
{
	CDialog::OnInitDialog();

	//On startup this window is called and loads the first frame of
	//The Splash screen animation
//	m_ani.Open("splash.avi");

	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

//As soon as the user clicks play this function runs
void ExplosionIntro::OnPlay() 
{
	//Play the already loaded AVI once from start to finish
//	m_ani.Play(0, -1, 1);

	//Play an Explosion WAV along with the animation
	//This was needed because Animation Boxes only play silent clips
	sndPlaySound("explosion.wav", SND_SYNC);

	//As soon as the sound is over close the window
	this->EndDialog(true);	
}
