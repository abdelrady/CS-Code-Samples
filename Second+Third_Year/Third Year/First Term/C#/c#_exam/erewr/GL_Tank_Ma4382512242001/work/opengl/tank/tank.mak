# Microsoft Developer Studio Generated NMAKE File, Format Version 4.20
# ** DO NOT EDIT **

# TARGTYPE "Win32 (x86) Application" 0x0101

!IF "$(CFG)" == ""
CFG=tank - Win32 Debug
!MESSAGE No configuration specified.  Defaulting to tank - Win32 Debug.
!ENDIF 

!IF "$(CFG)" != "tank - Win32 Release" && "$(CFG)" != "tank - Win32 Debug"
!MESSAGE Invalid configuration "$(CFG)" specified.
!MESSAGE You can specify a configuration when running NMAKE on this makefile
!MESSAGE by defining the macro CFG on the command line.  For example:
!MESSAGE 
!MESSAGE NMAKE /f "tank.mak" CFG="tank - Win32 Debug"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "tank - Win32 Release" (based on "Win32 (x86) Application")
!MESSAGE "tank - Win32 Debug" (based on "Win32 (x86) Application")
!MESSAGE 
!ERROR An invalid configuration is specified.
!ENDIF 

!IF "$(OS)" == "Windows_NT"
NULL=
!ELSE 
NULL=nul
!ENDIF 
################################################################################
# Begin Project
MTL=mktyplib.exe
CPP=cl.exe
RSC=rc.exe

!IF  "$(CFG)" == "tank - Win32 Release"

# PROP BASE Use_MFC 0
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "Release"
# PROP BASE Intermediate_Dir "Release"
# PROP BASE Target_Dir ""
# PROP Use_MFC 2
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "Release"
# PROP Intermediate_Dir "Release"
# PROP Target_Dir ""
OUTDIR=.\Release
INTDIR=.\Release

ALL : "$(OUTDIR)\tank.exe"

CLEAN : 
	-@erase "$(INTDIR)\3DFont.obj"
	-@erase "$(INTDIR)\3DFont.res"
	-@erase "$(INTDIR)\3DFontDoc.obj"
	-@erase "$(INTDIR)\3DFontView.obj"
	-@erase "$(INTDIR)\GLFont.obj"
	-@erase "$(INTDIR)\MainFrm.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(OUTDIR)\tank.exe"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

# ADD BASE CPP /nologo /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /YX /c
# ADD CPP /nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_AFXDLL" /D "_MBCS" /YX /c
CPP_PROJ=/nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D\
 "_AFXDLL" /D "_MBCS" /Fp"$(INTDIR)/tank.pch" /YX /Fo"$(INTDIR)/" /c 
CPP_OBJS=.\Release/
CPP_SBRS=.\.
# ADD BASE MTL /nologo /D "NDEBUG" /win32
# ADD MTL /nologo /D "NDEBUG" /win32
MTL_PROJ=/nologo /D "NDEBUG" /win32 
# ADD BASE RSC /l 0x409 /d "NDEBUG"
# ADD RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
RSC_PROJ=/l 0x409 /fo"$(INTDIR)/3DFont.res" /d "NDEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
BSC32_FLAGS=/nologo /o"$(OUTDIR)/tank.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
# ADD BASE LINK32 kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib /nologo /subsystem:windows /machine:I386
# ADD LINK32 opengl32.lib glu32.lib /nologo /subsystem:windows /machine:I386
LINK32_FLAGS=opengl32.lib glu32.lib /nologo /subsystem:windows /incremental:no\
 /pdb:"$(OUTDIR)/tank.pdb" /machine:I386 /out:"$(OUTDIR)/tank.exe" 
LINK32_OBJS= \
	"$(INTDIR)\3DFont.obj" \
	"$(INTDIR)\3DFont.res" \
	"$(INTDIR)\3DFontDoc.obj" \
	"$(INTDIR)\3DFontView.obj" \
	"$(INTDIR)\GLFont.obj" \
	"$(INTDIR)\MainFrm.obj" \
	"$(INTDIR)\StdAfx.obj"

"$(OUTDIR)\tank.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

# PROP BASE Use_MFC 0
# PROP BASE Use_Debug_Libraries 1
# PROP BASE Output_Dir "Debug"
# PROP BASE Intermediate_Dir "Debug"
# PROP BASE Target_Dir ""
# PROP Use_MFC 2
# PROP Use_Debug_Libraries 1
# PROP Output_Dir "Debug"
# PROP Intermediate_Dir "Debug"
# PROP Target_Dir ""
OUTDIR=.\Debug
INTDIR=.\Debug

ALL : "$(OUTDIR)\tank.exe"

CLEAN : 
	-@erase "$(INTDIR)\3DFont.obj"
	-@erase "$(INTDIR)\3DFont.res"
	-@erase "$(INTDIR)\3DFontDoc.obj"
	-@erase "$(INTDIR)\3DFontView.obj"
	-@erase "$(INTDIR)\GLFont.obj"
	-@erase "$(INTDIR)\MainFrm.obj"
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\vc40.idb"
	-@erase "$(INTDIR)\vc40.pdb"
	-@erase "$(OUTDIR)\tank.exe"
	-@erase "$(OUTDIR)\tank.ilk"
	-@erase "$(OUTDIR)\tank.pdb"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

# ADD BASE CPP /nologo /W3 /Gm /GX /Zi /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /YX /c
# ADD CPP /nologo /MDd /W3 /Gm /GX /Zi /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_AFXDLL" /D "_MBCS" /YX /c
CPP_PROJ=/nologo /MDd /W3 /Gm /GX /Zi /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS"\
 /D "_AFXDLL" /D "_MBCS" /Fp"$(INTDIR)/tank.pch" /YX /Fo"$(INTDIR)/"\
 /Fd"$(INTDIR)/" /c 
CPP_OBJS=.\Debug/
CPP_SBRS=.\.
# ADD BASE MTL /nologo /D "_DEBUG" /win32
# ADD MTL /nologo /D "_DEBUG" /win32
MTL_PROJ=/nologo /D "_DEBUG" /win32 
# ADD BASE RSC /l 0x409 /d "_DEBUG"
# ADD RSC /l 0x409 /d "_DEBUG" /d "_AFXDLL"
RSC_PROJ=/l 0x409 /fo"$(INTDIR)/3DFont.res" /d "_DEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
BSC32_FLAGS=/nologo /o"$(OUTDIR)/tank.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
# ADD BASE LINK32 kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib /nologo /subsystem:windows /debug /machine:I386
# ADD LINK32 opengl32.lib glu32.lib /nologo /subsystem:windows /debug /machine:I386
LINK32_FLAGS=opengl32.lib glu32.lib /nologo /subsystem:windows /incremental:yes\
 /pdb:"$(OUTDIR)/tank.pdb" /debug /machine:I386 /out:"$(OUTDIR)/tank.exe" 
LINK32_OBJS= \
	"$(INTDIR)\3DFont.obj" \
	"$(INTDIR)\3DFont.res" \
	"$(INTDIR)\3DFontDoc.obj" \
	"$(INTDIR)\3DFontView.obj" \
	"$(INTDIR)\GLFont.obj" \
	"$(INTDIR)\MainFrm.obj" \
	"$(INTDIR)\StdAfx.obj"

"$(OUTDIR)\tank.exe" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ENDIF 

.c{$(CPP_OBJS)}.obj:
   $(CPP) $(CPP_PROJ) $<  

.cpp{$(CPP_OBJS)}.obj:
   $(CPP) $(CPP_PROJ) $<  

.cxx{$(CPP_OBJS)}.obj:
   $(CPP) $(CPP_PROJ) $<  

.c{$(CPP_SBRS)}.sbr:
   $(CPP) $(CPP_PROJ) $<  

.cpp{$(CPP_SBRS)}.sbr:
   $(CPP) $(CPP_PROJ) $<  

.cxx{$(CPP_SBRS)}.sbr:
   $(CPP) $(CPP_PROJ) $<  

################################################################################
# Begin Target

# Name "tank - Win32 Release"
# Name "tank - Win32 Debug"

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

################################################################################
# Begin Source File

SOURCE=.\StdAfx.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFont.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFont.rc
DEP_RSC_3DFON=\
	".\res\3DFont.ico"\
	".\res\3DFont.rc2"\
	".\res\3DFontDoc.ico"\
	".\res\Toolbar.bmp"\
	

"$(INTDIR)\3DFont.res" : $(SOURCE) $(DEP_RSC_3DFON) "$(INTDIR)"
   $(RSC) $(RSC_PROJ) $(SOURCE)


# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFontDoc.cpp
DEP_CPP_3DFONT=\
	".\3DFont.h"\
	".\3DFontDoc.h"\
	".\StdAfx.h"\
	

"$(INTDIR)\3DFontDoc.obj" : $(SOURCE) $(DEP_CPP_3DFONT) "$(INTDIR)"


# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFontDoc.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFontView.cpp
DEP_CPP_3DFONTV=\
	".\3DFont.h"\
	".\3DFontDoc.h"\
	".\3DFontView.h"\
	".\GLFont.h"\
	".\MainFrm.h"\
	".\StdAfx.h"\
	{$(INCLUDE)}"\gl\gl.h"\
	

"$(INTDIR)\3DFontView.obj" : $(SOURCE) $(DEP_CPP_3DFONTV) "$(INTDIR)"


# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFontView.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\GLFont.cpp
DEP_CPP_GLFON=\
	".\GLFont.h"\
	".\StdAfx.h"\
	

"$(INTDIR)\GLFont.obj" : $(SOURCE) $(DEP_CPP_GLFON) "$(INTDIR)"


# End Source File
################################################################################
# Begin Source File

SOURCE=.\GLFont.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\MainFrm.cpp
DEP_CPP_MAINF=\
	".\3DFont.h"\
	".\MainFrm.h"\
	".\StdAfx.h"\
	

"$(INTDIR)\MainFrm.obj" : $(SOURCE) $(DEP_CPP_MAINF) "$(INTDIR)"


# End Source File
################################################################################
# Begin Source File

SOURCE=.\MainFrm.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\resource.h

!IF  "$(CFG)" == "tank - Win32 Release"

!ELSEIF  "$(CFG)" == "tank - Win32 Debug"

!ENDIF 

# End Source File
################################################################################
# Begin Source File

SOURCE=.\StdAfx.cpp
DEP_CPP_STDAF=\
	".\StdAfx.h"\
	

"$(INTDIR)\StdAfx.obj" : $(SOURCE) $(DEP_CPP_STDAF) "$(INTDIR)"


# End Source File
################################################################################
# Begin Source File

SOURCE=.\3DFont.cpp
DEP_CPP_3DFONT_=\
	"..\common\GLFont.h"\
	".\3DFont.h"\
	".\3DFontDoc.h"\
	".\3DFontView.h"\
	".\MainFrm.h"\
	".\StdAfx.h"\
	{$(INCLUDE)}"\gl\gl.h"\
	

"$(INTDIR)\3DFont.obj" : $(SOURCE) $(DEP_CPP_3DFONT_) "$(INTDIR)"


# End Source File
# End Target
# End Project
################################################################################
