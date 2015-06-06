/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#include "stdafx.h"
#include "GLFont.h"

#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

CGLFont::CGLFont()
{
	m_FontType = GL_FONT_SOLID;
	m_uiListID = 0;
    m_dThick = 0.1f;
	m_dXOffset = 0.0f;     
	m_dYOffset = 0.0f;
	m_dZOffset = 0.0f;
	m_dXScale = 1.0f;
	m_dYScale = 1.0f;
	m_dZScale = 1.0f;
    m_dXRotate = 0.0f;
    m_dYRotate = 0.0f;
    m_dZRotate = 0.0f;     

	m_dMEmission[0] = 0.1f;
	m_dMEmission[1] = 0.1f;
	m_dMEmission[2] = 0.9f;
	m_dMEmission[3] = 1.0f;

	m_dMSpecular[0] = 0.9f;
	m_dMSpecular[1] = 0.1f;
	m_dMSpecular[2] = 0.1f;
	m_dMSpecular[3] = 1.0f;

	m_dMAmbient[0] = 0.1f;
	m_dMAmbient[1] = 0.9f;
	m_dMAmbient[2] = 0.1f;
	m_dMAmbient[3] = 1.0f;

	m_dMDiffuse[0] = 0.8f;
	m_dMDiffuse[1] = 0.8f;
	m_dMDiffuse[2] = 0.8f;
	m_dMDiffuse[3] = 1.0f;

	m_dMShininess = 100.0f;
}

CGLFont::~CGLFont()
{
    if(m_uiListID != 0)
        glDeleteLists(m_uiListID, FONTLIST);
}


//////////////////////////////////////////////////////////////////////
// Set the material emission of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::SetEmission(float dMEmission[4])
{
	m_dMEmission[0] = dMEmission[0];
	m_dMEmission[1] = dMEmission[1];
	m_dMEmission[2] = dMEmission[2];
	m_dMEmission[3] = dMEmission[3];
}


//////////////////////////////////////////////////////////////////////
// Get the material emission of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::GetEmission(float dMEmission[4])
{
	dMEmission[0] = m_dMEmission[0];
	dMEmission[1] = m_dMEmission[1];
	dMEmission[2] = m_dMEmission[2];
	dMEmission[3] = m_dMEmission[3];
}


//////////////////////////////////////////////////////////////////////
// Set the material specular of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::SetSpecular(float dMSpecular[4])
{
	m_dMSpecular[0] = dMSpecular[0];
	m_dMSpecular[1] = dMSpecular[1];
	m_dMSpecular[2] = dMSpecular[2];
	m_dMSpecular[3] = dMSpecular[3];
}


//////////////////////////////////////////////////////////////////////
// Get the material specular of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::GetSpecular(float dMSpecular[4])
{
	dMSpecular[0] = m_dMSpecular[0];
	dMSpecular[1] = m_dMSpecular[1];
	dMSpecular[2] = m_dMSpecular[2];
	dMSpecular[3] = m_dMSpecular[3];
}

	
//////////////////////////////////////////////////////////////////////
// Set the material ambient of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::SetAmbient(float dMAmbient[4]) 
{
	m_dMAmbient[0] = dMAmbient[0];
	m_dMAmbient[1] = dMAmbient[1];
	m_dMAmbient[2] = dMAmbient[2];
	m_dMAmbient[3] = dMAmbient[3];
}


//////////////////////////////////////////////////////////////////////
// Get the material ambient of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::GetAmbient(float dMAmbient[4]) 
{
	dMAmbient[0] = m_dMAmbient[0];
	dMAmbient[1] = m_dMAmbient[1];
	dMAmbient[2] = m_dMAmbient[2];
	dMAmbient[3] = m_dMAmbient[3];
}


//////////////////////////////////////////////////////////////////////
// Set the material diffuse of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::SetDiffuse(float dMDiffuse[4])
{
	m_dMDiffuse[0] = dMDiffuse[0];
	m_dMDiffuse[1] = dMDiffuse[1];
	m_dMDiffuse[2] = dMDiffuse[2];
	m_dMDiffuse[3] = dMDiffuse[3];
}


//////////////////////////////////////////////////////////////////////
// Get the material diffuse of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::GetDiffuse(float dMDiffuse[4])
{
	dMDiffuse[0] = m_dMDiffuse[0];
	dMDiffuse[1] = m_dMDiffuse[1];
	dMDiffuse[2] = m_dMDiffuse[2];
	dMDiffuse[3] = m_dMDiffuse[3];
}

	
//////////////////////////////////////////////////////////////////////
// Set the material shininess of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::SetShininess(float dMShininess)  
{
	m_dMShininess = dMShininess;
}


//////////////////////////////////////////////////////////////////////
// Get the material shininess of the font 
//////////////////////////////////////////////////////////////////////
void CGLFont::GetShininess(float* dMShininess)
{
	*dMShininess = m_dMShininess;
}

//////////////////////////////////////////////////////////////////////
// Create the font to display the text 
//////////////////////////////////////////////////////////////////////
BOOL CGLFont::CreateFont(CDC* pDrawDC, char* fontname)
{
	m_uiListID = glGenLists(FONTLIST);

	if(pDrawDC == NULL || m_uiListID == 0)
	{
        return FALSE;
	}

	//Create the font to display
	CFont newfont;
	CFont* oldfont;
	BOOL  bresult;
	GLYPHMETRICSFLOAT gmf[FONTLIST];

	if(fontname != NULL)
	{	
        bresult = newfont.CreateFont(-12, 0, 0, 0, FW_NORMAL, 0, 0, 0, ANSI_CHARSET, 
		       OUT_TT_ONLY_PRECIS, CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY,
               FF_DONTCARE|DEFAULT_PITCH, fontname);

	    //if new font failed to be created
	    if(!bresult)
		{
		    return FALSE;
		}

	    oldfont = pDrawDC->SelectObject(&newfont);
	}
	else
	{
	    oldfont = (CFont*)pDrawDC->SelectStockObject(SYSTEM_FONT);
	}

	if(m_FontType == GL_FONT_SOLID)
	{
        bresult = wglUseFontOutlines(pDrawDC->m_hDC, 0, FONTLIST, m_uiListID, 
			0.0f, (float)m_dThick, WGL_FONT_POLYGONS, gmf);	
	}
	else if(m_FontType == GL_FONT_LINE)
	{
        bresult = wglUseFontOutlines(pDrawDC->m_hDC, 0, FONTLIST, m_uiListID, 
			0.0f, (float)m_dThick, WGL_FONT_LINES, gmf);	
	}
	
	pDrawDC->SelectObject(oldfont);
	newfont.DeleteObject();
	
	if(!bresult)
	{
		return FALSE;
	}

	return TRUE;
}


//////////////////////////////////////////////////////////////////////
// display the text string
//////////////////////////////////////////////////////////////////////
void CGLFont::GLDrawText()
{
	if (m_uiListID == 0 || m_strText.IsEmpty() ||
		m_dXScale == 0.0 || m_dYScale == 0.0 ||
	    m_dZScale == 0.0)
	{
		return;
	}

	GLsizei size = m_strText.GetLength();
	
	glPushMatrix();
    //set material mission
	glMaterialfv(GL_FRONT_AND_BACK, GL_EMISSION, m_dMEmission);
    //set material specular
	glMaterialfv(GL_FRONT_AND_BACK, GL_SPECULAR, m_dMSpecular);
    //set material ambient
	glMaterialfv(GL_FRONT_AND_BACK, GL_AMBIENT, m_dMAmbient);
    //set material diffuse
	glMaterialfv(GL_FRONT_AND_BACK, GL_DIFFUSE, m_dMDiffuse);
    //set material shininess
	glMaterialf(GL_FRONT_AND_BACK, GL_SHININESS, m_dMShininess);

    //Translate 
	glTranslated(m_dXOffset, m_dYOffset, m_dZOffset);
	//Scale
	glScaled(m_dXScale, m_dYScale, m_dZScale); 
 	//Rotate around X-axis
	glRotated(m_dXRotate, 1.0, 0.0, 0.0);
 	//Rotate around Y-axis
	glRotated(m_dYRotate, 0.0, 1.0, 0.0);
 	//Rotate around Z-axis
	glRotated(m_dZRotate, 0.0, 0.0, 1.0);
	
	//display the letter
	glListBase(m_uiListID);
	glCallLists(size, GL_UNSIGNED_BYTE, (const GLvoid*)m_strText.GetBuffer(size)); 

 	//restore the original angle around Z-axis
	glRotated(-1.0f * m_dZRotate, 0.0, 0.0, 1.0);
 	//restore the original angle around Y-axis
	glRotated(-1.0f * m_dYRotate, 0.0, 1.0, 0.0);
 	//restore the original angle around X-axis
	glRotated(-1.0f * m_dXRotate, 1.0, 0.0, 0.0);
 	//restore the original scale
	glScaled(1.0/m_dXScale, 1.0/m_dYScale, 1.0/m_dZScale); 
	//restore the original position
    glTranslated(-m_dXOffset, -m_dYOffset, -m_dZOffset);

    glPopMatrix();

}