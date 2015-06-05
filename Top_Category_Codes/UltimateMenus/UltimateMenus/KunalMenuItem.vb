
Option Explicit On 
Option Strict On

#Region " Usage Notes "

'To Use this Class simply Create a Menu Structure in Form Designer
'as you would usually create a Menu. Once you are happy with the 
'layout of your Menu, just follow the Simple Steps as Outlined Below.
'----------------------------------------------------------------------------
'                                                                           |
'1.  Save All.
'2.  Solution Explorer-->References-->Add Reference-->UltimateMenus.dll                                                              |
'3.  Expand [#Region " Windows Form Designer generated code "].             |
'4.  Press Ctrl+A.                                                          |
'5.  Press Ctrl+H.                                                          |
'6.  Type [System.Windows.Forms.MenuItem] in the [Find what:] Combobox.     |
'7.  Type [UltimateMenus.KunalMenuItem] in the [Replace with:] Combobox.                     |
'8.  Click [Replace All], then [Close].                                     |
'9.  Click On [Save All] Icon.                                              |
'10.  Click On [Build --> Rebuild Solution].                                 |
'                                                                           |
'NOTE : ALL FIELDS ARE MANDATORY. THEY MUST BE FOLLOWED.                    |                               
'----------------------------------------------------------------------------
'You will now have several new properties for each Menu Item, which can
'be accessed through the Properties Window. These new properties have
'been assigned to the Appearance Category.
'If you add any New MenuItems you will need to re-run the above steps,
'unless you want to draw them in a different style (such as the sidebar
'in the attached project).

#End Region

'Used to convert Menu Shortcut Key to String.
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices 'Used for DLLImport

Public Class KunalMenuItem
    Inherits System.Windows.Forms.MenuItem


#Region " API To Get Extra Menu Related Colors In XP "
    'Are we not supposed to write programs for XP systems?

    'EnableVisualStyles function added to VS2003, but how do we know 
    'if the user has them enabled, without resorting to API?
    <DllImport("uxtheme.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function IsAppThemed() As Boolean

    End Function

    <DllImport("user32.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function GetSysColor(ByVal index As Integer) As Integer

    End Function

    Private Const COLOR_MENUHILIGHT As Integer = 29
    Private Const COLOR_MENUBAR As Integer = 30

#End Region

#Region " Initialisation "
    'for menu sidebar iamges
    Private m_Image As Image
    Private m_ImageList As ImageList
    Private m_ImageIndex As Integer
    Private m_MakeIconTransparent As Boolean = False
    'for checked menu items
    Private m_CheckedImage As Image
    Private m_CheckedImageIndex As Integer
    Private m_CheckedImageStyle As IconStyle = IconStyle.IconShadow
    Private m_MakeCheckedIconTransparent As Boolean = False
    Private m_CheckedIconShadowColor As Color = Color.Gray
    Private m_TickMarkStyle As TickMarkStyles = TickMarkStyles.Shadow
    Private m_CheckedBorderColor As Color = SystemColors.Control
    Private m_CheckedBackColor As Color = SystemColors.Control
    Private m_CheckedTickColor As Color = SystemColors.Control
    Private m_CheckedDisabledBackColor As Color = Color.FromArgb(255, 197, 194, 184)
    Private m_CheckedItemStyle As CheckedMenuStyles = CheckedMenuStyles.CheckedItemDefault
    'the menu items font
    Private m_font As Font = SystemInformation.MenuFont
    'the menu items hilite font
    Private m_HighLightFont As Font = SystemInformation.MenuFont
    'width of the menu item
    Private w As Integer
    'height of the menu item
    Private h As Integer
    'for the menubar menu items
    Private m_SSUnderMenuBarItem As Boolean = True
    Private m_ShowBorderMenuBarItem As Boolean = False
    Private m_MenuBarBorderColor As Color = Color.Black
    Private m_FillMenuBarItem As Boolean = False
    Private m_MenuBarGradientStyle As LinearGradientMode = LinearGradientMode.Vertical
    Private m_Gradient1 As Color = SystemColors.Menu
    Private m_Gradient2 As Color = SystemColors.Menu
    Private m_MenuBarFillColor As Color = SystemColors.Menu
    Private m_MenuBarFillStyle As MenuBarFillStyles = MenuBarFillStyles.FillColor
    'for the sidebar of the menuitem
    Private m_SideBarStyle As SideBarDrawStyle = SideBarDrawStyle.DefaultGradient
    Private m_PreDefinedSideBarGradientColor As PreDefinedSideBarGradientColors = PreDefinedSideBarGradientColors.ShineyBlueYellow
    Private m_SideBarColor As Color = SystemColors.Control
    Private m_SideStartColor As Color = SystemColors.Control
    Private m_SideEndColor As Color = SystemColors.Control
    Private m_GradientMode As LinearGradientMode = LinearGradientMode.Horizontal
    Private m_ShowOverSideBar As Boolean = False

    Private m_HighLightStyle As HighLightColorDrawStyle = HighLightColorDrawStyle.DefaultScheme
    Private m_PreDefinedStyle As PreDefinedHighLightColors = PreDefinedHighLightColors.Khaki
    Private m_HiliteColor As Color = SystemColors.Highlight
    Private m_HiliteGrColor1 As Color = Color.WhiteSmoke
    Private m_HiliteGrColor2 As Color = Color.CornflowerBlue
    Private m_HiLiteGradientMode As LinearGradientMode = LinearGradientMode.Horizontal
    Private m_PreHiLiteGrColor As PreDefinedGrHighLightColors = PreDefinedGrHighLightColors.BrownWhite
    Private m_HiliteBorderColor As Color = SystemColors.ControlDark
    Private m_ForeColor As Color = SystemColors.MenuText
    Private m_HighlightForecolor As Color = SystemColors.HighlightText
    Private m_Tmp_ForeColor As Color = SystemColors.MenuText
    Private m_BackColor As Color = SystemColors.Menu
    Private m_BarColor As Color = SystemColors.Menu
    Private m_Style As IconStyle = IconStyle.IconShadow
    Private m_IconShadowColor As Color = Color.Gray
    Private m_RTLMenu As Boolean

    Public Sub New()
        MyClass.New("", Nothing, Nothing, System.Windows.Forms.Shortcut.None)
    End Sub

    Public Sub New(ByVal text As String, ByVal image As Image, ByVal onClick As EventHandler, ByVal shortcut As Shortcut)

        MyBase.New(text, onClick, shortcut)

        OwnerDraw = True
        m_Image = image

        'If Windows XP 
        If Environment.OSVersion.Version.Major >= 5 And Environment.OSVersion.Version.Minor >= 1 Then
            If IsAppThemed() Then
                'Get  MenuBar and MenuHilight colors.
                Dim c As Color = Color.FromArgb(GetSysColor(COLOR_MENUBAR))
                'Color was returned bgr instead of rgb
                m_BarColor = Color.FromArgb(255, c.B, c.G, c.R)
                c = Color.FromArgb(GetSysColor(COLOR_MENUHILIGHT))
                m_HiliteColor = Color.FromArgb(255, c.B, c.G, c.R)
            End If
        End If

    End Sub

#End Region

#Region " Custom Properties For MenuItems"

#Region " Enumeration Datatypes Needed For Custom Properties "
    'needed for drawing the icons in the menu
    Public Enum IconStyle
        IconNone
        IconShadow
        IconBump
        IconEtched
        IconFlat
        IconRaisedInner
        IconRaisedOuter
        IconSunken
        IconSunkenInner
        IconSunkenOuter
    End Enum
    'needed to determine the sidebar draw style
    Public Enum SideBarDrawStyle
        Standard
        DefaultColor
        DefaultGradient
        CustomGradient
        PredefinedGradient
        Office2003Blue
        Office2003OliveGreen
        Office2003Silver
        Office2003Classic
    End Enum
    'needed to determine the highlighted menuitem draw style
    Public Enum HighLightColorDrawStyle
        DefaultScheme 'default values will be used
        CustomScheme 'custom colors will be used
        PreDefinedSchemes 'system defined colors
        DefaultGradient 'default gradient color
        CustomGradient 'gradient colors
        PredefinedGradient 'predefined gradient colors
    End Enum
    'needed to set the predefined highlighted menuitem draw styles
    Public Enum PreDefinedHighLightColors
        LightGreen
        Khaki
        LightBlue
        LightPink
        LightGrey
        DarkSeaGreen
        YellowGreen
        LightViolet
    End Enum
    'needed to set the predefined gradient highlighted menuitem draw styles
    Public Enum PreDefinedGrHighLightColors
        BrownWhite
        GreenWhite
        OrangeWhite
        PurpleWhite
    End Enum
    'needed to set the predefined gradient sidebar
    Public Enum PreDefinedSideBarGradientColors
        BrickRedWhiteSmoke
        DarkKhakiWhite
        MetalicWhite
        MetalGreenWhiteSmoke
        FadeBrownWhite
        ShineyBlueYellow
    End Enum
    'needed to set the predefined gradient sidebar
    Public Enum CheckedMenuStyles
        CheckedItemIcon
        CheckedItemTickMark
        CheckedItemDefault
    End Enum
    'needed to set the tick mark style
    Public Enum TickMarkStyles
        Normal
        Shadow
    End Enum
    'needed to set the tick mark style
    Public Enum MenuBarFillStyles
        FillColor
        FillGradient
    End Enum
#End Region

    'Purpose : To get or set the style of drawing the menuitem icons(images)
    'IconHiLiteStyle
    <Category("Appearance"), _
    DefaultValue(GetType(IconStyle), "IconShadow"), _
    Description("The HighLight Style Of The Icon Of This MenuItem.")> _
    Public Property IconHiLiteStyle() As IconStyle
        Get
            Return m_Style
        End Get
        Set(ByVal New_Style As IconStyle)
            m_Style = New_Style
        End Set
    End Property
    'm_IconShadowColor
    'Purpose : To get or set the style of drawing the menuitem icons(images)
    <Category("Appearance"), _
    DefaultValue(GetType(IconStyle), "IconShadow"), _
    Description("The Shadow Color Of The Icon Of This MenuItem. When <IconHiLiteStyle> Property Set To <IconShadow>.")> _
    Public Property IconShadowColor() As Color
        Get
            Return m_IconShadowColor
        End Get
        Set(ByVal NewColor As Color)
            m_IconShadowColor = NewColor
        End Set
    End Property
    'Image
    'Without the DefaultValue attribute here we would not be able
    'to reset the image to None once we have set an image.
    <Category("Appearance"), _
    DefaultValue(GetType(Image), "None"), _
    Description("The Image(i.e: Icon) to be displayed in MenuItems Sidebar.")> _
    Public Property Image() As Image
        Get
            Return m_Image
        End Get
        Set(ByVal New_Image As Image)
            m_Image = New_Image
        End Set
    End Property

    'ImageList
    'Without the DefaultValue attribute here we would not be able
    'to reset the image to None once we have set an image.
    <Category("Appearance"), _
    DefaultValue(GetType(ImageList), "None"), _
    Description("The ImageList For The MenuItem Sidebar.")> _
    Public Property ImageList() As ImageList
        Get
            Return m_ImageList
        End Get
        Set(ByVal New_Image As ImageList)
            m_ImageList = New_Image
        End Set
    End Property

    'ImageIndex
    'Without the DefaultValue attribute here we would not be able
    'to reset the image to None once we have set an image.
    <Category("Appearance"), _
    DefaultValue(GetType(Integer), "None"), _
    Description("The ImageIndex For The MenuItem Sidebar.")> _
    Public Property ImageIndex() As Integer
        Get
            Return m_ImageIndex
        End Get
        Set(ByVal New_Image As Integer)
            m_ImageIndex = New_Image
        End Set
    End Property


    'Purpose : To check if we have to make the icon transparent or not.
    'because the user may supply an icon with a different background, in that
    'case we should make it transparent. otherwise no need for that. by default it is false.
    <Category("Appearance"), _
    Description("To Make The Background Of The Image(i.e: Icon) Transparent.")> _
    Public Property MakeTransparentIcon() As Boolean
        Get
            Return m_MakeIconTransparent
        End Get
        Set(ByVal NewValue As Boolean)
            m_MakeIconTransparent = NewValue
        End Set
    End Property
    'Purpose : To get or set the font for the menuitems
    'Font
    <Category("Appearance"), _
    Description("The Font that displays in this MenuItem.")> _
    Public Property Font() As Font
        Get
            Return m_font
        End Get
        Set(ByVal Value As Font)
            If Not m_font.Equals(Value) Then
                If IsNothing(Value) Then
                    ResetFont()
                Else
                    m_font = Value
                End If
            End If
        End Set
    End Property
    'Purpose : To get or set the font for the menuitems when they are highlighted
    'HighLightFont
    <Category("Appearance"), _
    Description("The Font That Displays This MenuItem When HighLighted.")> _
    Public Property HighLightFont() As Font
        Get
            Return m_HighLightFont
        End Get
        Set(ByVal Value As Font)
            If Not m_HighLightFont.Equals(Value) Then
                If IsNothing(Value) Then
                    ResetHighLightFont()
                Else
                    m_HighLightFont = Value
                End If
            End If
        End Set
    End Property
    'Purpose : To check if either the Font Property should be serialized or not
    Private Function ShouldSerializeFont() As Boolean
        Return Not (m_font.Equals(SystemInformation.MenuFont))
    End Function
    'Purpose : To check if either the HighLight Font Property should be serialized or not
    Private Function ShouldSerializeHighLightFont() As Boolean
        Return Not (m_HighLightFont.Equals(SystemInformation.MenuFont))
    End Function
    'Purpose: To reset the font property when nothing is set, as the default value
    Private Sub ResetFont()
        Font = SystemInformation.MenuFont
    End Sub
    'Purpose: To reset the highlight font property when nothing is set, as the default value
    Private Sub ResetHighLightFont()
        HighLightFont = SystemInformation.MenuFont
    End Sub
    'Purpose : To get or set the style of drawing the sidebar for the menu
    'm_SideBarStyle
    <Category("Appearance"), _
    Description("The Visual Style Of The Side Bar.")> _
    Public Property SideBarStyle() As SideBarDrawStyle
        Get
            Return m_SideBarStyle
        End Get
        Set(ByVal NewStyle As SideBarDrawStyle)
            m_SideBarStyle = NewStyle
        End Set
    End Property
    'Purpose : To get or set the style of drawing the sidebar for the menu
    <Category("Appearance"), Description("The Predefined Gradient Color Style Of The Side Bar.")> _
    Public Property PreDefinedSideBarGradientColour() As PreDefinedSideBarGradientColors
        Get
            Return m_PreDefinedSideBarGradientColor
        End Get
        Set(ByVal NewStyle As PreDefinedSideBarGradientColors)
            m_PreDefinedSideBarGradientColor = NewStyle
        End Set
    End Property
    'Purpose : To get or set the highlight forecolor for the menuitems
    'm_HighlightForecolor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The ForeColor Of The MenuItem Text When The MenuItem Is Selected (i.e : Highlighted).")> _
    Public Property HighLightForeColor() As Color
        Get
            Return m_HighlightForecolor
        End Get
        Set(ByVal NewHLFCol As Color)
            m_HighlightForecolor = NewHLFCol
        End Set
    End Property
    'Purpose : To get or set the sidebar color of the menu
    'm_SideBarColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The Color Of Side Bar Of The Menu In Standrard Mode.")> _
    Public Property SideBarColor() As Color
        Get
            Return m_SideBarColor
        End Get
        Set(ByVal NewColor As Color)
            m_SideBarColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the first gradient color for sidebar of the menu
    'SideBarStartColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The Starting Color For The Gradient Of Side Bar Of The Menu.")> _
    Public Property SideBarStartColor() As Color
        Get
            Return m_SideStartColor
        End Get
        Set(ByVal NewColor As Color)
            m_SideStartColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the second gradient color for sidebar of the menu
    'SideBarEndColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The Ending Color For The Gradient Of Side Bar Of The Menu.")> _
    Public Property SideBarEndColor() As Color
        Get
            Return m_SideEndColor
        End Get
        Set(ByVal NewColor As Color)
            m_SideEndColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the gradient style of the sidebar  of the menu
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The Gradient Mode For The Gradient Of Side Bar Of The Menu.")> _
    Public Property SideBarGradientStyle() As System.Drawing.Drawing2D.LinearGradientMode
        Get
            Return m_GradientMode
        End Get
        Set(ByVal NewGradientMode As System.Drawing.Drawing2D.LinearGradientMode)
            m_GradientMode = NewGradientMode
        End Set
    End Property

    'Purpose : To check if we have to show the hilite iver the sidebar also
    <Category("Appearance"), _
    Description("To Show HiLite Over The SideBar Of The MenuItem.")> _
    Public Property ShowHiliteOverSideBar() As Boolean
        Get
            Return m_ShowOverSideBar
        End Get
        Set(ByVal NewValue As Boolean)
            m_ShowOverSideBar = NewValue
        End Set
    End Property


    'Purpose: To get or set the highlight color of the menuitem
    'HiliteDrwaingScheme
    <Category("Appearance"), _
    Description("The Highlight Scheme For The MenuItem.")> _
    Public Property HighLightScheme() As HighLightColorDrawStyle
        Get
            Return m_HighLightStyle
        End Get
        Set(ByVal NewScheme As HighLightColorDrawStyle)
            m_HighLightStyle = NewScheme
        End Set
    End Property
    'm_PreDefinedStyle
    'Purpose: To get or set the predefined highlight color of the menuitem in case of defined color scheme
    <Category("Appearance"), _
    Description("The Highlight Scheme For The MenuItem.")> _
    Public Property PreDefinedHiLiteColors() As PreDefinedHighLightColors
        Get
            Return m_PreDefinedStyle
        End Get
        Set(ByVal NewScheme As PreDefinedHighLightColors)
            m_PreDefinedStyle = NewScheme
        End Set
    End Property
    'Purpose: To get or set the highlight color of the menuitem
    'HiliteColor
    <Category("Appearance"), _
    Description("The Highlight Color.")> _
    Public Property HiliteColor() As Color
        Get
            Return m_HiliteColor
        End Get
        Set(ByVal NewColor As Color)
            m_HiliteColor = NewColor
        End Set
    End Property
    'm_HiliteGrColor1
    'Purpose: To get or set the highlight Gradient Starting color of the menuitem
    <Category("Appearance"), _
    Description("The Highlight Gradient Starting Color.")> _
    Public Property HiliteGradientColor1() As Color
        Get
            Return m_HiliteGrColor1
        End Get
        Set(ByVal NewColor1 As Color)
            m_HiliteGrColor1 = NewColor1
        End Set
    End Property
    'm_HiliteGrColor2
    'Purpose: To get or set the highlight Gradient Ending color of the menuitem
    <Category("Appearance"), _
    Description("The Highlight Gradient Ending Color.")> _
    Public Property HiliteGradientColor2() As Color
        Get
            Return m_HiliteGrColor2
        End Get
        Set(ByVal NewColor2 As Color)
            m_HiliteGrColor2 = NewColor2
        End Set
    End Property
    'Purpose : To get or set the gradient style of the sidebar  of the menu
    'm_HiLiteGradientMode
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control"), _
    Description("The Gradient Mode For The HighLight Gradient Of The Menu.")> _
    Public Property HiLiteGradientStyle() As System.Drawing.Drawing2D.LinearGradientMode
        Get
            Return m_HiLiteGradientMode
        End Get
        Set(ByVal NewGradientMode As System.Drawing.Drawing2D.LinearGradientMode)
            m_HiLiteGradientMode = NewGradientMode
        End Set
    End Property
    'm_PreDefinedStyle
    'Purpose: To get or set the predefined gradient highlight color of the menuitem in case of defined color scheme
    <Category("Appearance"), _
    Description("The Highlight Gradient Predefined Scheme For The MenuItem.")> _
    Public Property PreDefinedHiLiteGradientColors() As PreDefinedGrHighLightColors
        Get
            Return m_PreHiLiteGrColor
        End Get
        Set(ByVal NewScheme As PreDefinedGrHighLightColors)
            m_PreHiLiteGrColor = NewScheme
        End Set
    End Property
    'Purpose: To check if to serialize the highlight color of the menuitem
    '         and also get and set the special colors if its winxp
    Private Function ShouldSerializeHiliteColor() As Boolean
        If Environment.OSVersion.Version.Major >= 5 And _
           Environment.OSVersion.Version.Minor >= 1 Then
            If IsAppThemed() Then
                Dim c As Color = Color.FromArgb(GetSysColor(COLOR_MENUHILIGHT))
                Return Not (m_HiliteColor.Equals(Color.FromArgb(255, c.B, c.G, c.R)))
            End If
        End If
        Return Not m_HiliteColor.Equals(SystemColors.Highlight)
    End Function
    'Purpose : To reset the highlight color property of the menu item
    '          and also get and set the special colors if its winxp
    Private Sub ResetHiliteColor()
        Dim c As Color = SystemColors.Highlight
        If Environment.OSVersion.Version.Major >= 5 And _
           Environment.OSVersion.Version.Minor >= 1 Then
            If IsAppThemed() Then
                Dim mc As Color = Color.FromArgb(GetSysColor(COLOR_MENUHILIGHT))
                c = Color.FromArgb(255, mc.B, mc.G, mc.R)
            End If
        End If
        m_HiliteColor = c
    End Sub
    'Purpose : to get or set the highlight border color of the menuitem
    'HiliteBorderColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "ControlDark"), _
    Description("The Highlight Border Color.")> _
    Public Property HiliteBorderColor() As Color
        Get
            Return m_HiliteBorderColor
        End Get
        Set(ByVal NewColor As Color)
            m_HiliteBorderColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the backcolor of the emnuitem
    'BackColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Menu"), _
    Description("The Background Color of the MenuItem.")> _
    Public Property BackColor() As Color
        Get
            Return m_BackColor
        End Get
        Set(ByVal NewColor As Color)
            m_BackColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the forecolor of the menuitem
    'ForeColor
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "MenuText"), _
    Description("The Text Color of the MenuItem.")> _
    Public Property ForeColor() As Color
        Get
            Return m_ForeColor
        End Get
        Set(ByVal NewColor As Color)
            m_ForeColor = NewColor
        End Set
    End Property
    'Purpose : To determine if the emenu is a windows menu
    Private ReadOnly Property WindowMenu() As Boolean
        Get
            Return CBool(TypeOf (Me.Parent) Is MainMenu)
        End Get
    End Property
    'Purpose : To determine if the emenu is a right to left aligned menu
    Public ReadOnly Property RTLMenu() As Boolean
        Get
            If IsNothing(Me.GetContextMenu) Then
                Return CBool(Me.GetMainMenu.RightToLeft)
            Else
                Return CBool(Me.GetContextMenu.RightToLeft)
            End If
        End Get
    End Property
    'Purpose : To get the width of the menuitem
    'Width
    <Browsable(False)> _
    Public ReadOnly Property Width() As Integer
        Get
            Return w
        End Get
    End Property
    'Purpose : To get the height of the menuitem
    'Height
    <Browsable(False)> _
    Public ReadOnly Property Height() As Integer
        Get
            Return h
        End Get
    End Property
    'Purpose : To get or set the style of the checked menu item
    <Category("Appearance"), _
    Description("The Indicator Style For The Checked MenuItem.")> _
    Public Property CheckedMenuItemStyle() As CheckedMenuStyles
        Get
            Return m_CheckedItemStyle
        End Get
        Set(ByVal NewStyle As CheckedMenuStyles)
            m_CheckedItemStyle = NewStyle
        End Set
    End Property
    'Purpose : To get or set the Image of the checked menu item
    <Category("Appearance"), _
    DefaultValue(GetType(Image), "None"), _
    Description("The Image For The Checked MenuItem.")> _
    Public Property CheckedMenuItemImage() As Image
        Get
            Return m_CheckedImage
        End Get
        Set(ByVal NewImage As Image)
            m_CheckedImage = NewImage
        End Set
    End Property

    'CheckedImageIndex
    'Without the DefaultValue attribute here we would not be able
    'to reset the image to None once we have set an image.
    <Category("Appearance"), _
    DefaultValue(GetType(Integer), "None"), _
    Description("The ImageIndex For The Checked MenuItem's Sidebar.")> _
    Public Property CheckedImageIndex() As Integer
        Get
            Return m_CheckedImageIndex
        End Get
        Set(ByVal New_Image As Integer)
            m_CheckedImageIndex = New_Image
        End Set
    End Property


    'Purpose : To get or set The Icon Style Of The Icon Of This Checked MenuItem
    <Category("Appearance"), _
    DefaultValue(GetType(IconStyle), "IconShadow"), _
    Description("The Icon Style Of The Icon Of This Checked MenuItem.")> _
    Public Property CheckedMenuItemIconStyle() As IconStyle
        Get
            Return m_CheckedImageStyle
        End Get
        Set(ByVal New_Style As IconStyle)
            m_CheckedImageStyle = New_Style
        End Set
    End Property
    'Purpose : To check if we have to make the supplied icon transparent or not.
    'because the user may supply an icon with a different background, in that
    'case we should make it transparent. otherwise no need for that. by default it is false.
    <Category("Appearance"), _
    Description("To Make The Background Of The Checked MenuItem Icon Transparent.")> _
    Public Property MakeCheckedMenuItemIconTransparent() As Boolean
        Get
            Return m_MakeCheckedIconTransparent
        End Get
        Set(ByVal NewValue As Boolean)
            m_MakeCheckedIconTransparent = NewValue
        End Set
    End Property
    'Purpose : To get or set The Tick Mark Style
    <Category("Appearance"), _
    DefaultValue(GetType(TickMarkStyles), "Shadow"), _
    Description("The Tick Mark Indicator Style.")> _
    Public Property TickMarkStyle() As TickMarkStyles
        Get
            Return m_TickMarkStyle
        End Get
        Set(ByVal NewStyle As TickMarkStyles)
            m_TickMarkStyle = NewStyle
        End Set
    End Property
    'Purpose : To get or set the Border Color of the checked menu item's Indicator Icon or Tick Mark
    <Category("Appearance"), _
    Description("The Shadow Color For The Checked MenuItem's Indicator Icon.")> _
    Public Property CheckedMenuItemIconShadowColor() As Color
        Get
            Return m_CheckedIconShadowColor
        End Get
        Set(ByVal NewColor As Color)
            m_CheckedIconShadowColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the Border Color of the checked menu item's Indicator Icon or Tick Mark
    <Category("Appearance"), _
    Description("The Border Color For The Checked MenuItem's Indicator Icon or Tick Mark.")> _
    Public Property CheckedMenuItemBorderColor() As Color
        Get
            Return m_CheckedBorderColor
        End Get
        Set(ByVal NewColor As Color)
            m_CheckedBorderColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the Back Color of the checked menu item's Indicator Icon or Tick Mark
    <Category("Appearance"), _
    Description("The Back Color For The Checked MenuItem's Indicator Icon or Tick Mark.")> _
    Public Property CheckedMenuItemBackColor() As Color
        Get
            Return m_CheckedBackColor
        End Get
        Set(ByVal NewColor As Color)
            m_CheckedBackColor = NewColor
        End Set
    End Property
    'Purpose : To get or set the Back Color of the checked menu item's Indicator Icon or Tick Mark When The Menu Item Is Disabled
    <Category("Appearance"), _
    Description("The Back Color For The Checked MenuItem's Indicator Icon or Tick Mark When The Menu Item Is Disabled.")> _
    Public Property CheckedMenuItemDisabledBackColor() As Color
        Get
            Return m_CheckedDisabledBackColor
        End Get
        Set(ByVal NewColor As Color)
            m_CheckedDisabledBackColor = NewColor
        End Set
    End Property
    'Purpose : To get or set The Color For The Checked MenuItem's Tick Mark Indicator.
    <Category("Appearance"), _
    Description("The Color For The Checked MenuItem's Tick Mark Indicator.")> _
    Public Property CheckedMenuItemTickMarkColor() As Color
        Get
            Return m_CheckedTickColor
        End Get
        Set(ByVal NewColor As Color)
            m_CheckedTickColor = NewColor
        End Set
    End Property

    'Purpose : To get or set The Color Of The Border If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The Color Of The Border If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemBorderColor() As Color
        Get
            Return m_MenuBarBorderColor
        End Get
        Set(ByVal NewColor As Color)
            m_MenuBarBorderColor = NewColor
        End Set
    End Property

    'Purpose : To get or set The Color Of The Background If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The Color Of The Background If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemFillColor() As Color
        Get
            Return m_MenuBarFillColor
        End Get
        Set(ByVal NewColor As Color)
            m_MenuBarFillColor = NewColor
        End Set
    End Property

    'Purpose : To get or set The Start Color Of The Gradient Effect If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The Start Color Of The Gradient Effect If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemGradientColor1() As Color
        Get
            Return m_Gradient1
        End Get
        Set(ByVal NewColor As Color)
            m_Gradient1 = NewColor
        End Set
    End Property

    'Purpose : To get or set The End Color Of The Gradient Effect If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The End Color Of The Gradient Effect If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemGradientColor2() As Color
        Get
            Return m_Gradient2
        End Get
        Set(ByVal NewColor As Color)
            m_Gradient2 = NewColor
        End Set
    End Property

    'Purpose : To check if we have To Show A Border If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("To Show A Shadow Under The MenuItem If It Is A MenuBar MenuItem.")> _
    Public Property ShowShadowUnderMenuBar() As Boolean
        Get
            Return m_SSUnderMenuBarItem
        End Get
        Set(ByVal NewValue As Boolean)
            m_SSUnderMenuBarItem = NewValue
        End Set
    End Property

    'Purpose : To check if we have To Show A Border If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("To Show A Border If It Is A MenuBar MenuItem.")> _
    Public Property ShowBorderAroundMenuBar() As Boolean
        Get
            Return m_ShowBorderMenuBarItem
        End Get
        Set(ByVal NewValue As Boolean)
            m_ShowBorderMenuBarItem = NewValue
        End Set
    End Property

    'Purpose : To check if we have To Fill A MenuItem If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("To Fill A MenuItem If It Is A MenuBar MenuItem.")> _
    Public Property FillMenuBarItem() As Boolean
        Get
            Return m_FillMenuBarItem
        End Get
        Set(ByVal NewValue As Boolean)
            m_FillMenuBarItem = NewValue
        End Set
    End Property

    'Purpose : To get or set The Filling Style Of A MenuItem If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The Filling Style Of A MenuItem If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemFillingStyle() As MenuBarFillStyles
        Get
            Return m_MenuBarFillStyle
        End Get
        Set(ByVal NewValue As MenuBarFillStyles)
            m_MenuBarFillStyle = NewValue
        End Set
    End Property

    'Purpose : To get or set The Gradient Style Of The Background Of A MenuItem If It Is A MenuBar MenuItem
    <Category("Appearance"), _
    Description("The Gradient Style Of The Background Of A MenuItem If It Is A MenuBar MenuItem.")> _
    Public Property MenuBarItemGradientStyle() As System.Drawing.Drawing2D.LinearGradientMode
        Get
            Return m_MenuBarGradientStyle
        End Get
        Set(ByVal NewValue As System.Drawing.Drawing2D.LinearGradientMode)
            m_MenuBarGradientStyle = NewValue
        End Set
    End Property


#End Region

#Region " Owner Draw Subs "

    Protected Overrides Sub OnMeasureItem(ByVal e As System.Windows.Forms.MeasureItemEventArgs)

        MyBase.OnMeasureItem(e)

        m_RTLMenu = RTLMenu

        Dim ItemText As String
        Dim sf As New StringFormat
        sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide

        'replace Chr(2) with two spaces to get overall text length.
        ItemText = JoinItemText().Replace(Chr(2), "  ")

        Select Case ItemText
            Case "-" 'Seperator
                e.ItemHeight = 3
            Case Else
                Dim szF As SizeF
                e.ItemHeight = CInt(e.Graphics.MeasureString(ItemText, m_font, szF, sf).Height)
                If e.ItemHeight < 22 Then e.ItemHeight = 22
                e.ItemWidth = CInt(e.Graphics.MeasureString(ItemText, m_font, szF, sf).Width) + 2
                'If not TopLevel MenuItem then
                If Not WindowMenu Then
                    e.ItemWidth += 44
                End If
        End Select

        h = e.ItemHeight
        w = e.ItemWidth

        sf.Dispose()

    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        MyBase.OnDrawItem(e)
        Dim SepLinePen As Pen
        If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then
            SepLinePen = New Pen(Color.FromArgb(106, 140, 203))
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then
            SepLinePen = New Pen(Color.FromArgb(96, 128, 88))
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
            SepLinePen = New Pen(Color.FromArgb(110, 109, 143))
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
            SepLinePen = New Pen(Color.FromArgb(166, 166, 166))
        Else
            SepLinePen = SystemPens.GrayText
        End If

        ClearBackGround(e)

        If WindowMenu Then 'if the menuitem is a mneubar menuitem then
            'call the sub to draw the menubar menuitem
            DrawMenuBarMenuItemHiLite(e)
            'draw the text of the menuitem
            DrawText(e)
        ElseIf Me.Text = "-" Then 'elseif it is a separator bar then
            DrawSideBar(e)
            'Draw Seperator Line
            Dim SepRect As New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width - 32, e.Bounds.Height - 3)
            If Not m_RTLMenu Then SepRect.Offset(32, 0)
            If m_Style = IconStyle.IconShadow Then
                e.Graphics.DrawLine(SepLinePen, SepRect.X, SepRect.Y, SepRect.Right, SepRect.Bottom)
            Else
                SepRect.Inflate(6, 0)
                'Raised and Sunken seem to draw opposite when the rect is so small.
                e.Graphics.DrawLine(SystemPens.ControlDark, SepRect.X, SepRect.Y, SepRect.Right, SepRect.Y)
                e.Graphics.DrawLine(SystemPens.ControlLightLight, SepRect.X, SepRect.Y + 1, SepRect.Right, SepRect.Y + 1)
            End If
        Else
            DrawSideBar(e)
            DrawHiLite(e)
            DrawText(e)
            DrawSideImage(e)
        End If

        'IN CASE OF CHECKED MENU ITEMS
        'draw the check icon or specified image if the menuitem is a checked item
        If CBool(e.State And DrawItemState.Checked) Then
            'checkout the style for the checked menu item indicator
            If m_CheckedItemStyle = CheckedMenuStyles.CheckedItemDefault Then 'if default then
                Dim nPen As System.Drawing.Pen
                Dim ChkHiLiteColorBsh As Brush
                Dim nBrush As Brush
                Dim ChkRect As New Rectangle(e.Bounds.X + 2, CInt(e.Bounds.Y + ((e.Bounds.Height - Height) / 2)) + 1, 18, 19)
                If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then get the pen and backcolor

                    If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then
                        nPen = New Pen(Color.FromArgb(0, 0, 128))
                        nBrush = New SolidBrush(Color.FromArgb(255, 192, 111))
                        ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(254, 128, 62))
                    ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then
                        nPen = New Pen(Color.FromArgb(63, 93, 56))
                        nBrush = New SolidBrush(Color.FromArgb(255, 192, 111))
                        ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(254, 128, 62))
                    ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
                        nPen = New Pen(Color.FromArgb(75, 75, 111))
                        nBrush = New SolidBrush(Color.FromArgb(255, 192, 111))
                        ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(254, 128, 62))
                    ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                        nPen = New Pen(Color.FromArgb(10, 36, 106))
                        nBrush = New SolidBrush(Color.FromArgb(212, 213, 216))
                        ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(133, 146, 181))
                    Else
                        nPen = New Pen(Color.DarkBlue)
                        nBrush = New SolidBrush(Color.FromArgb(225, 180, 200, 255))
                        ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(225, 180, 200, 255))
                    End If

                Else 'if disabled then get the pen(gray) and backcolor
                    nPen = New Pen(Color.Gray)
                    nBrush = New SolidBrush(Color.FromArgb(255, 197, 194, 184))
                    ChkHiLiteColorBsh = New SolidBrush(Color.FromArgb(255, 197, 194, 184))
                End If
                'draw the rectangle and the backcolor
                e.Graphics.FillRectangle(nBrush, ChkRect)
                e.Graphics.DrawRectangle(nPen, ChkRect)

                'show shadow under the check mark rectangle
                If CBool(e.State And DrawItemState.Selected) Then

                    If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Or m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen _
                    Or m_SideBarStyle = SideBarDrawStyle.Office2003Silver Or m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                        'draw the rectangle and the backcolor
                        e.Graphics.FillRectangle(ChkHiLiteColorBsh, ChkRect)
                        e.Graphics.DrawRectangle(nPen, ChkRect)
                    Else
                        'for the shadow draw a rectangle and fill it with gray color
                        Dim TmpRect As New Rectangle(e.Bounds.X + 2, CInt(e.Bounds.Y + ((e.Bounds.Height - Height) / 2)) + 1, 18, 19)
                        e.Graphics.FillRectangle(New SolidBrush(Color.Gray), TmpRect)
                        e.Graphics.DrawRectangle(New Pen(Color.Gray), TmpRect)
                        'now move the original rectangle to left fro displaying the shadow beneth it
                        ChkRect.Offset(-1, -1)
                        'draw the rectangle and the backcolor
                        e.Graphics.FillRectangle(ChkHiLiteColorBsh, ChkRect)
                        e.Graphics.DrawRectangle(nPen, ChkRect)
                    End If

                End If
                'drawing the tick mark
                Dim Pnts(5) As Point
                Pnts(0) = New Point(7, e.Bounds.Top + 10)
                Pnts(1) = New Point(9, e.Bounds.Top + 12)
                Pnts(2) = New Point(13, e.Bounds.Top + 8)
                Pnts(3) = New Point(13, e.Bounds.Top + 9)
                Pnts(4) = New Point(9, e.Bounds.Top + 13)
                Pnts(5) = New Point(7, e.Bounds.Top + 11)
                'now check if the checked menu item is disabled or enabled
                If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then draw with black
                    e.Graphics.DrawLines(New Pen(Color.Black, 1.5), Pnts)
                Else 'if disabled then draw with gray color
                    e.Graphics.DrawLines(New Pen(Color.Gray, 1.5), Pnts)
                End If
            ElseIf m_CheckedItemStyle = CheckedMenuStyles.CheckedItemIcon Then 'if icon then
                'call the sub to draw the checked menu items image
                DrawCheckedMenuItemImage(e)
            ElseIf m_CheckedItemStyle = CheckedMenuStyles.CheckedItemTickMark Then 'if tick mark then
                Dim nPen As System.Drawing.Pen

                Dim nBrush As Brush

                Dim ChkRect As New Rectangle(e.Bounds.X + 2, CInt(e.Bounds.Y + ((e.Bounds.Height - Height) / 2)) + 1, 18, 19)
                If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then get the pen and backcolor
                    nPen = New Pen(m_CheckedBorderColor)

                    nBrush = New SolidBrush(m_CheckedBackColor)

                Else 'if disabled then get the pen(gray) and backcolor(user specified or default)
                    nPen = New Pen(Color.Gray)

                    nBrush = New SolidBrush(m_CheckedDisabledBackColor)

                End If
                'draw the rectangle and the backcolor
                e.Graphics.FillRectangle(nBrush, ChkRect)
                e.Graphics.DrawRectangle(nPen, ChkRect)

                'drwaing the tick mark
                Dim Pnts3(5) As Point
                Pnts3(0) = New Point(7, e.Bounds.Top + 10)
                Pnts3(1) = New Point(9, e.Bounds.Top + 12)
                Pnts3(2) = New Point(13, e.Bounds.Top + 8)
                Pnts3(3) = New Point(13, e.Bounds.Top + 9)
                Pnts3(4) = New Point(9, e.Bounds.Top + 13)
                Pnts3(5) = New Point(7, e.Bounds.Top + 11)
                'now check if the checked menu item is disabled or enabled
                If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then draw with black
                    e.Graphics.DrawLines(New Pen(m_CheckedTickColor, 1.5), Pnts3)
                Else 'if disabled then draw with gray color
                    e.Graphics.DrawLines(New Pen(Color.Gray, 1.5), Pnts3)
                End If

                'show shadow under the check mark rectangle
                If CBool(e.State And DrawItemState.Selected) Then
                    If m_TickMarkStyle = TickMarkStyles.Shadow Then

                        'draw the rectangle and the backcolor
                        e.Graphics.FillRectangle(nBrush, ChkRect)
                        e.Graphics.DrawRectangle(nPen, ChkRect)

                        'drwaing the tick mark
                        Dim Pnts(5) As Point
                        Pnts(0) = New Point(7, e.Bounds.Top + 10)
                        Pnts(1) = New Point(9, e.Bounds.Top + 12)
                        Pnts(2) = New Point(13, e.Bounds.Top + 8)
                        Pnts(3) = New Point(13, e.Bounds.Top + 9)
                        Pnts(4) = New Point(9, e.Bounds.Top + 13)
                        Pnts(5) = New Point(7, e.Bounds.Top + 11)

                        Dim Pnts2(5) As Point
                        Pnts2(0) = New Point(9, e.Bounds.Top + 12)
                        Pnts2(1) = New Point(11, e.Bounds.Top + 14)
                        Pnts2(2) = New Point(15, e.Bounds.Top + 10)
                        Pnts2(3) = New Point(15, e.Bounds.Top + 11)
                        Pnts2(4) = New Point(11, e.Bounds.Top + 15)
                        Pnts2(5) = New Point(9, e.Bounds.Top + 13)

                        'now check if the checked menu item is disabled or enabled
                        If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then draw with black
                            e.Graphics.DrawLines(New Pen(Color.Gray, 1.5), Pnts2)
                            e.Graphics.DrawLines(New Pen(m_CheckedTickColor, 1.5), Pnts)
                        Else 'if disabled then draw with gray color
                            e.Graphics.DrawLines(New Pen(Color.Gray, 1.5), Pnts)
                        End If
                    ElseIf m_TickMarkStyle = TickMarkStyles.Normal Then
                        'draw the rectangle and the backcolor
                        e.Graphics.FillRectangle(nBrush, ChkRect)
                        e.Graphics.DrawRectangle(nPen, ChkRect)

                        'drwaing the tick mark
                        Dim Pnts(5) As Point
                        Pnts(0) = New Point(7, e.Bounds.Top + 10)
                        Pnts(1) = New Point(9, e.Bounds.Top + 12)
                        Pnts(2) = New Point(13, e.Bounds.Top + 8)
                        Pnts(3) = New Point(13, e.Bounds.Top + 9)
                        Pnts(4) = New Point(9, e.Bounds.Top + 13)
                        Pnts(5) = New Point(7, e.Bounds.Top + 11)
                        'now check if the checked menu item is disabled or enabled
                        If Not CBool(e.State And DrawItemState.Disabled) Then 'if enabled then draw with black
                            e.Graphics.DrawLines(New Pen(m_CheckedTickColor, 1.5), Pnts)
                        Else 'if disabled then draw with gray color
                            e.Graphics.DrawLines(New Pen(Color.Gray, 1.5), Pnts)
                        End If
                    End If

                End If

            End If
        End If

    End Sub

#Region " Common Sub-Routines for DrawItem "

    Private Sub ClearBackGround(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        Dim BackBrush As Brush = New SolidBrush(m_BackColor)
        'Dim HiLitePen As Pen = New Pen(Color.DarkGreen)
        Dim BackRect As New Rectangle(e.Bounds.X + 24, e.Bounds.Y, e.Bounds.Width - 24, e.Bounds.Height)

        If WindowMenu Then
            BackBrush = New SolidBrush(m_BarColor)
            BackRect.X -= 24
            BackRect.Width += 24
        End If

        If m_RTLMenu And Not WindowMenu Then BackRect.Offset(-24, 0)

        e.Graphics.FillRectangle(BackBrush, BackRect)
        'e.Graphics.DrawRectangle(HiLitePen, BackRect)
        BackBrush.Dispose()

    End Sub

    'Purpose: To Draw the side bar of the menu
    Private Sub DrawSideBar(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        'The recatangle of the sidebar
        Dim cRect As New Rectangle(e.Bounds.X - 1, e.Bounds.Y, 25, e.Bounds.Height)

        'ControlPaint.DrawBorder3D(e.Graphics, e.Bounds.X + 1, e.Bounds.Y, 25, e.Bounds.Height, Border3DStyle.RaisedOuter)

        'set the smoothing mode to antialias and high quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias And SmoothingMode.HighQuality

        'first determine the style of the side bar
        If m_SideBarStyle = SideBarDrawStyle.CustomGradient Then  'if custom gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, m_SideStartColor, m_SideEndColor, m_GradientMode)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.DefaultGradient Then 'if default gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.WhiteSmoke, Color.CornflowerBlue, Drawing2D.LinearGradientMode.Horizontal)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then 'if office 2003 blue gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.FromArgb(166, 196, 255), Color.FromArgb(224, 237, 254), 180.0F, False)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then 'if office 2003 OliveGreen gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.FromArgb(196, 210, 157), Color.FromArgb(237, 242, 211), 180.0F, False)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then 'if office 2003 Silver gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.FromArgb(183, 182, 203), Color.FromArgb(231, 232, 241), 180.0F, False)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then 'if office 2003 Classic gardient then
            Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.FromArgb(223, 220, 215), Color.FromArgb(242, 240, 238), 180.0F, False)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(GrdBrush, cRect)
            GrdBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.PredefinedGradient Then 'if predefined gradient colors then
            'set the gradient brush according to various color schemes
            If m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.BrickRedWhiteSmoke Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.WhiteSmoke, Color.FromArgb(128, 255, 128, 128), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            ElseIf m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.DarkKhakiWhite Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.FromArgb(178, 178, 178, 50), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            ElseIf m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.MetalGreenWhiteSmoke Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.WhiteSmoke, Color.FromArgb(178, 129, 176, 113), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            ElseIf m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.FadeBrownWhite Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.FromArgb(178, 150, 100, 100), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            ElseIf m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.ShineyBlueYellow Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.Yellow, Color.FromArgb(178, 20, 120, 180), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            ElseIf m_PreDefinedSideBarGradientColor = PreDefinedSideBarGradientColors.MetalicWhite Then
                Dim GrdBrush As Brush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.FromArgb(178, 120, 108, 150), Drawing2D.LinearGradientMode.Horizontal)
                If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
                e.Graphics.FillRectangle(GrdBrush, cRect)
                GrdBrush.Dispose()
            End If
        ElseIf m_SideBarStyle = SideBarDrawStyle.Standard Then 'if standard then
            Dim SideBrush As Brush = New SolidBrush(m_SideBarColor)
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(SideBrush, cRect)
            SideBrush.Dispose()
        ElseIf m_SideBarStyle = SideBarDrawStyle.DefaultColor Then  'if default color then
            Dim SideBrush As Brush = New SolidBrush(Lighten(Color.FromArgb(219, 216, 209), 10))
            If m_RTLMenu Then cRect.Offset(e.Bounds.Width - 24, 0)
            e.Graphics.FillRectangle(SideBrush, cRect)
            SideBrush.Dispose()
        End If

    End Sub

    Private Sub DrawHiLite(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim HiLiteBrush As Brush
        Dim HiLitePen As Pen

        'set the smoothing mode to antialias and high quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias And SmoothingMode.HighQuality

        Dim cRect As Rectangle
        'check if we need to show the hilite over the sidebar also
        If m_ShowOverSideBar = False Then
            If m_Style = IconStyle.IconRaisedInner Then 'raisedinner
                cRect = New Rectangle(e.Bounds.X + 1, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height - 1)
            Else
                cRect = New Rectangle(e.Bounds.Left + 24, e.Bounds.Y, e.Bounds.Width - 25, e.Bounds.Height - 1)
            End If
        ElseIf m_ShowOverSideBar = True Then
            cRect = New Rectangle(e.Bounds.X + 1, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height - 1)

        End If

        'determine the drawing scheme for the menuitem and get the brush and pen accordingly
        If m_HighLightStyle = HighLightColorDrawStyle.CustomScheme Then 'if custome scheme then get custome colors
            HiLiteBrush = New SolidBrush(m_HiliteColor)
            HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.DefaultScheme Then 'else use default xp style color
            If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(255, 238, 194))
                HiLitePen = New Pen(Color.FromArgb(0, 0, 128))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(255, 238, 194))
                HiLitePen = New Pen(Color.FromArgb(63, 93, 56))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(255, 238, 194))
                HiLitePen = New Pen(Color.FromArgb(75, 75, 111))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(182, 189, 210))
                HiLitePen = New Pen(Color.FromArgb(10, 36, 106))
            Else
                HiLiteBrush = New SolidBrush(Color.FromArgb(182, 189, 210))
                HiLitePen = New Pen(Color.FromArgb(10, 36, 106))
            End If

        ElseIf m_HighLightStyle = HighLightColorDrawStyle.DefaultGradient Then  'else use default gradient style
            HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.CornflowerBlue, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Horizontal)
            HiLitePen = New Pen(Color.Blue)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.CustomGradient Then   'else use custom gradient style
            HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, m_HiliteGrColor1, m_HiliteGrColor2, m_HiLiteGradientMode)
            HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.PredefinedGradient Then    'else use pre defined gradient styles
            If m_PreHiLiteGrColor = PreDefinedGrHighLightColors.BrownWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.FromArgb(241, 113, 61), Color.White, Drawing2D.LinearGradientMode.Horizontal)
                HiLitePen = New Pen(Color.Brown)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.OrangeWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.Orange, Color.White, Drawing2D.LinearGradientMode.Horizontal)
                HiLitePen = New Pen(Color.Red)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.GreenWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.YellowGreen, Color.White, Drawing2D.LinearGradientMode.Horizontal)
                HiLitePen = New Pen(Color.DarkGreen)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.PurpleWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.Pink, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Horizontal)
                HiLitePen = New Pen(Color.DarkViolet)
            End If
            'HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, m_HiliteGrColor1, m_HiliteGrColor2, m_HiLiteGradientMode)
            'HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.PreDefinedSchemes Then  'else use pre defined color styles 
            If m_PreDefinedStyle = PreDefinedHighLightColors.LightBlue Then 'if LightBlue then
                HiLiteBrush = New SolidBrush(Color.SkyBlue)
                HiLitePen = New Pen(Color.DarkViolet)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.Khaki Then 'if Khaki then
                HiLiteBrush = New SolidBrush(Color.Khaki)
                HiLitePen = New Pen(Color.DarkKhaki)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightGreen Then 'If LightGreen Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(189, 210, 100))
                HiLitePen = New Pen(Color.Green)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightPink Then 'If LightPink Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(255, 207, 203))
                HiLitePen = New Pen(Color.Tomato)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightGrey Then  'If LightGrey Then
                HiLiteBrush = New SolidBrush(Color.LightGray)
                HiLitePen = New Pen(Color.IndianRed)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.DarkSeaGreen Then  'If DarkSeaGreen Then
                HiLiteBrush = New SolidBrush(Color.DarkSeaGreen)
                HiLitePen = New Pen(Color.Green)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightViolet Then 'If LightViolet Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(229, 199, 251))
                HiLitePen = New Pen(Color.Violet)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.YellowGreen Then  'If YellowGreen Then
                HiLiteBrush = New SolidBrush(Color.YellowGreen)
                HiLitePen = New Pen(Color.DarkGreen)
            End If
        End If

        If m_Style = IconStyle.IconRaisedInner Then
            If m_RTLMenu Then
                cRect.Offset(-12, 0)
            Else
                cRect.Offset(12, 0)
            End If
            cRect.Inflate(-12, 0)
        End If

        If Not CBool(e.State And DrawItemState.Disabled) Then
            If CBool(e.State And DrawItemState.Selected) Or CBool(e.State And DrawItemState.HotLight) Then
                e.Graphics.FillRectangle(HiLiteBrush, cRect)
                e.Graphics.DrawRectangle(HiLitePen, cRect)
            End If
        End If

        HiLiteBrush.Dispose()
        HiLitePen.Dispose()

    End Sub
    Private Sub DrawMenuBarMenuItemHiLite(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim HiLiteBrush As Brush
        Dim SelectedBrush As Brush
        Dim HiLitePen As Pen

        'set the smoothing mode to antialias and high quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias And SmoothingMode.HighQuality

        Dim cRect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1)

        'determine the drawing scheme for the menuitem and get the brush and pen accordingly
        If m_HighLightStyle = HighLightColorDrawStyle.CustomScheme Then 'if custome scheme then get custome colors
            HiLiteBrush = New SolidBrush(m_HiliteColor)
            HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.DefaultScheme Then 'else use default xp style color
            Dim selRect As Rectangle
            If CBool(e.State And DrawItemState.HotLight) Then
                selRect = New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
            ElseIf CBool(e.State And DrawItemState.Selected) Then
                selRect = New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
            Else
                selRect = New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
            End If
            If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then
                HiLiteBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(255, 192, 111), 90.0F)
                SelectedBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(128, 167, 225), 90.0F)
                HiLitePen = New Pen(Color.FromArgb(0, 0, 128))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then
                HiLiteBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(255, 192, 111), 90.0F)
                SelectedBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(196, 210, 157), 90.0F)
                HiLitePen = New Pen(Color.FromArgb(63, 93, 56))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
                HiLiteBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(255, 192, 111), 90.0F)
                SelectedBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(183, 182, 203), 90.0F)
                HiLitePen = New Pen(Color.FromArgb(75, 75, 111))
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                HiLiteBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(212, 213, 216), 90.0F)
                SelectedBrush = New LinearGradientBrush(selRect, Color.White, Color.FromArgb(223, 220, 215), 90.0F)
                HiLitePen = New Pen(Color.FromArgb(10, 36, 106))
            Else
                HiLiteBrush = New SolidBrush(Color.FromArgb(182, 189, 210))
                HiLitePen = New Pen(Color.FromArgb(10, 36, 106))
            End If
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.DefaultGradient Then  'else use default gradient style
            HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.CornflowerBlue, 90.0F)
            HiLitePen = New Pen(Color.Blue)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.CustomGradient Then   'else use custom gradient style
            HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, m_HiliteGrColor1, m_HiliteGrColor2, m_HiLiteGradientMode)
            HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.PredefinedGradient Then    'else use pre defined gradient styles
            If m_PreHiLiteGrColor = PreDefinedGrHighLightColors.BrownWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.FromArgb(241, 113, 61), 90.0F)
                HiLitePen = New Pen(Color.Brown)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.OrangeWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.Orange, 90.0F)
                HiLitePen = New Pen(Color.Red)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.GreenWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.White, Color.YellowGreen, 90.0F)
                HiLitePen = New Pen(Color.DarkGreen)
            ElseIf m_PreHiLiteGrColor = PreDefinedGrHighLightColors.PurpleWhite Then
                HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, Color.WhiteSmoke, Color.Pink, 90.0F)
                HiLitePen = New Pen(Color.DarkViolet)
            End If
            'HiLiteBrush = New System.Drawing.Drawing2D.LinearGradientBrush(cRect, m_HiliteGrColor1, m_HiliteGrColor2, m_HiLiteGradientMode)
            'HiLitePen = New Pen(m_HiliteBorderColor)
        ElseIf m_HighLightStyle = HighLightColorDrawStyle.PreDefinedSchemes Then  'else use pre defined color styles 
            If m_PreDefinedStyle = PreDefinedHighLightColors.LightBlue Then 'if LightBlue then
                HiLiteBrush = New SolidBrush(Color.SkyBlue)
                HiLitePen = New Pen(Color.DarkViolet)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.Khaki Then 'if Khaki then
                HiLiteBrush = New SolidBrush(Color.Khaki)
                HiLitePen = New Pen(Color.DarkKhaki)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightGreen Then 'If LightGreen Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(189, 210, 100))
                HiLitePen = New Pen(Color.Green)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightPink Then 'If LightPink Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(255, 207, 203))
                HiLitePen = New Pen(Color.Tomato)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightGrey Then  'If LightGrey Then
                HiLiteBrush = New SolidBrush(Color.LightGray)
                HiLitePen = New Pen(Color.IndianRed)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.DarkSeaGreen Then  'If DarkSeaGreen Then
                HiLiteBrush = New SolidBrush(Color.DarkSeaGreen)
                HiLitePen = New Pen(Color.Green)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.LightViolet Then 'If LightViolet Then
                HiLiteBrush = New SolidBrush(Color.FromArgb(229, 199, 251))
                HiLitePen = New Pen(Color.Violet)
            ElseIf m_PreDefinedStyle = PreDefinedHighLightColors.YellowGreen Then  'If YellowGreen Then
                HiLiteBrush = New SolidBrush(Color.YellowGreen)
                HiLitePen = New Pen(Color.DarkGreen)
            End If
        End If

        If m_Style = IconStyle.IconRaisedInner Then
            If m_RTLMenu Then
                cRect.Offset(-12, 0)
            Else
                cRect.Offset(12, 0)
            End If
            cRect.Inflate(-12, 0)
        End If

        If Not CBool(e.State And DrawItemState.Disabled) Then
            If CBool(e.State And DrawItemState.HotLight) Then
                'occurs when mouse rolls over a menubar menuitem 
                e.Graphics.FillRectangle(HiLiteBrush, e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
                e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)

            ElseIf CBool(e.State And DrawItemState.Selected) Then
                'occurs when you select and click a menubar menuitem 
                'for the shadow draw a rectabgle and fill it with gray color
                If m_SSUnderMenuBarItem = True Then
                    Dim TmpRect As New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 6, e.Bounds.Width - 3, e.Bounds.Height - 6)
                    e.Graphics.FillRectangle(New SolidBrush(Color.Gray), TmpRect)
                    e.Graphics.DrawRectangle(New Pen(Color.Gray), TmpRect)
                    'now move the original rectangle to downleft for displaying the shadow beneath it

                    'draw the rectangle and the backcolor
                    If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Or m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen _
                    Or m_SideBarStyle = SideBarDrawStyle.Office2003Silver Or m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                        e.Graphics.FillRectangle(SelectedBrush, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
                        e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height)
                    Else
                        e.Graphics.FillRectangle(HiLiteBrush, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
                        e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height)
                    End If
                    'e.Graphics.FillRectangle(HiLiteBrush, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
                    'e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height)
                Else
                    'draw the rectangle and the backcolor
                    If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Or m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen _
                    Or m_SideBarStyle = SideBarDrawStyle.Office2003Silver Or m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                        e.Graphics.FillRectangle(SelectedBrush, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
                        e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height)
                    Else
                        e.Graphics.FillRectangle(HiLiteBrush, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 5, e.Bounds.Height)
                        e.Graphics.DrawRectangle(HiLitePen, e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height)
                    End If
                End If
            Else
                'this is the default state of the menubar menuitem 
                'here first of all i need to check if we really need to fill the menuitem
                If m_FillMenuBarItem = True Then
                    'now check the filling style of the menuitem
                    If m_MenuBarFillStyle = MenuBarFillStyles.FillColor Then 'if color fill then
                        e.Graphics.FillRectangle(New SolidBrush(m_MenuBarFillColor), e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
                    ElseIf m_MenuBarFillStyle = MenuBarFillStyles.FillGradient Then 'if gradient fill then
                        Dim LinGrBrush As System.Drawing.Drawing2D.LinearGradientBrush
                        Dim Rct As New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
                        LinGrBrush = New System.Drawing.Drawing2D.LinearGradientBrush(Rct, m_Gradient1, m_Gradient2, m_MenuBarGradientStyle)
                        e.Graphics.FillRectangle(LinGrBrush, e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
                    End If
                End If
                'now check if we need to show a border around the menuitem
                If m_ShowBorderMenuBarItem = True Then
                    'if the user wants then show a border, of specified color
                    e.Graphics.DrawRectangle(New Pen(m_MenuBarBorderColor), e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 2)
                End If
            End If
        End If

        HiLiteBrush.Dispose()
        HiLitePen.Dispose()

    End Sub

    Private Sub DrawSideImage(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        'set the smoothing mode to antialias and high quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias And SmoothingMode.HighQuality

        If Not (m_Image Is Nothing) Then
            'Create a 16 * 16 Bitmap from our Image.
            Dim bmp As Bitmap = New Bitmap(m_Image, 16, 16)

            ''select the bottom left pixels color as the
            ''transparent color (as in Toolbar Bitmaps).
            'first check if we have to make the background of the icon transparent
            If m_MakeIconTransparent Then
                Dim TransColor As Color = bmp.GetPixel(0, 15)
                bmp.MakeTransparent(TransColor)
            End If

            ''Set the rectangle for our image.
            Dim ImageRect As New Rectangle(e.Bounds.X + 4, e.Bounds.Y + (e.Bounds.Height \ 2) - 8, 16, 16)
            If m_RTLMenu Then ImageRect.Offset(e.Bounds.Width - 24, 0)

            If CBool(e.State And DrawItemState.Disabled) Then
                'Draw the bitmap in a disabled state.
                ControlPaint.DrawImageDisabled(e.Graphics, bmp, ImageRect.X, ImageRect.Y, SystemColors.GrayText)
            Else
                If CBool(e.State And DrawItemState.Selected) Then
                    If m_Style = IconStyle.IconShadow Then
                        'copy the bitmap to act as shadow.
                        Dim bmpShadow As New Bitmap(bmp)
                        Dim x As Integer, y As Integer

                        'Replace non transparent colors with
                        'ControlDarkDark Color.
                        For x = 0 To 15
                            For y = 0 To 15
                                If bmpShadow.GetPixel(x, y).A > 32 Then
                                    bmpShadow.SetPixel(x, y, m_IconShadowColor)
                                End If
                            Next
                        Next

                        'draw Shadow.
                        If Not CBool(e.State And DrawItemState.Checked) Then
                            Dim ShadowRect As Rectangle = ImageRect
                            ShadowRect.Offset(1, 1)
                            e.Graphics.DrawImage(bmpShadow, ShadowRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                            'draw bitmap.
                            ImageRect.Offset(-1, -1)
                        End If
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)

                        'Finished with bmpShadow
                        bmpShadow.Dispose()
                    ElseIf m_Style = IconStyle.IconNone Then  'none
                        'Draw bitmap.
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconRaisedInner Then 'raisedinner
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.RaisedInner)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconRaisedOuter Then 'raisedouter
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.RaisedOuter)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconSunken Then 'sunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Sunken)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconSunkenInner Then 'innersunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.SunkenInner)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconSunkenOuter Then 'outersunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.SunkenOuter)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconBump Then 'bump
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Bump)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconEtched Then 'etched
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Etched)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_Style = IconStyle.IconFlat Then 'flat
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Flat)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    End If
                Else
                    'Draw bitmap.
                    e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                End If
            End If
            'Finished with bmp.
            bmp.Dispose()
        End If

    End Sub
    Private Sub DrawCheckedMenuItemImage(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        'set the smoothing mode to antialias and high quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias And SmoothingMode.HighQuality

        If Not (m_CheckedImage Is Nothing) Then
            'Create a 16 * 16 Bitmap from our Image.
            Dim bmp As Bitmap = New Bitmap(m_CheckedImage, 16, 16)

            'select the bottom left pixels color as the
            'transparent color (as in Toolbar Bitmaps).
            'first check if we have to make the background of the icon transparent
            If m_MakeCheckedIconTransparent Then
                Dim TransColor As Color = bmp.GetPixel(0, 15)
                bmp.MakeTransparent(TransColor)
            End If

            'Set the rectangle for our image.
            Dim ImageRect As New Rectangle(e.Bounds.X + 4, CInt(e.Bounds.Y + CInt(((e.Bounds.Height - Height) / 2)) + 3.55F), 16, 16)
            Dim ImageContainerRect As New Rectangle(e.Bounds.X + 2, CInt(e.Bounds.Y + ((e.Bounds.Height - Height) / 2) + 1), 18, 19)

            'if sidebar style is either one of the xp style then fill the recatngle
            If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 192, 111)), ImageContainerRect)
                e.Graphics.DrawRectangle(New Pen(Color.FromArgb(0, 0, 128)), ImageContainerRect)
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 192, 111)), ImageContainerRect)
                e.Graphics.DrawRectangle(New Pen(Color.FromArgb(63, 93, 56)), ImageContainerRect)
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 192, 111)), ImageContainerRect)
                e.Graphics.DrawRectangle(New Pen(Color.FromArgb(75, 75, 111)), ImageContainerRect)
            ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(212, 213, 216)), ImageContainerRect)
                e.Graphics.DrawRectangle(New Pen(Color.FromArgb(10, 36, 106)), ImageContainerRect)
            End If

            If m_RTLMenu Then ImageRect.Offset(e.Bounds.Width - 24, 0)
            If m_RTLMenu Then ImageContainerRect.Offset(e.Bounds.Width - 25, 0)

            If CBool(e.State And DrawItemState.Disabled) Then
                'Draw the bitmap in a disabled state.
                ControlPaint.DrawImageDisabled(e.Graphics, bmp, ImageRect.X, ImageRect.Y, SystemColors.GrayText)
            Else
                If CBool(e.State And DrawItemState.Selected) Then
                    'if sidebar style is either one of the xp style then fill the recatngle with hilite checkbox color
                    If m_SideBarStyle = SideBarDrawStyle.Office2003Blue Or m_SideBarStyle = SideBarDrawStyle.Office2003OliveGreen _
                    Or m_SideBarStyle = SideBarDrawStyle.Office2003Silver Then
                        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(254, 128, 62)), ImageContainerRect)
                        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(75, 75, 111)), ImageContainerRect)
                        'set the checked item image style to iconnone
                        m_CheckedImageStyle = IconStyle.IconNone
                    ElseIf m_SideBarStyle = SideBarDrawStyle.Office2003Classic Then
                        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(133, 146, 181)), ImageContainerRect)
                        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(10, 36, 106)), ImageContainerRect)
                        'set the checked item image style to iconnone
                        m_CheckedImageStyle = IconStyle.IconNone
                    End If

                    If m_CheckedImageStyle = IconStyle.IconShadow Then
                        'copy the bitmap to act as shadow.
                        Dim bmpShadow As New Bitmap(bmp)
                        Dim x As Integer, y As Integer

                        'Replace non transparent colors with
                        'ControlDarkDark Color.
                        For x = 0 To 15
                            For y = 0 To 15
                                If bmpShadow.GetPixel(x, y).A > 32 Then
                                    bmpShadow.SetPixel(x, y, m_CheckedIconShadowColor)
                                End If
                            Next
                        Next

                        'draw Shadow.
                        If CBool(e.State And DrawItemState.Checked) Then
                            Dim ShadowRect As Rectangle = ImageRect
                            ShadowRect.Offset(1, 1)
                            e.Graphics.DrawImage(bmpShadow, ShadowRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                            'draw bitmap.
                            ImageRect.Offset(-1, -1)
                        End If
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)

                        'Finished with bmpShadow
                        bmpShadow.Dispose()
                    ElseIf m_CheckedImageStyle = IconStyle.IconRaisedInner Then 'raisedinner
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.RaisedInner)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconRaisedOuter Then 'raisedouter
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.RaisedOuter)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconSunken Then 'sunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Sunken)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconSunkenInner Then 'innersunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.SunkenInner)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconSunkenOuter Then 'outersunken
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.SunkenOuter)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconBump Then 'bump
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Bump)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconEtched Then 'etched
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Etched)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    ElseIf m_CheckedImageStyle = IconStyle.IconFlat Then 'flat
                        Dim SelRect As Rectangle = ImageRect
                        SelRect.Inflate(3, 3)
                        ControlPaint.DrawBorder3D(e.Graphics, SelRect, Border3DStyle.Flat)
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    Else
                        'Draw bitmap.
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    End If
                Else
                        'Draw bitmap.
                        e.Graphics.DrawImage(bmp, ImageRect, 0, 0, 16, 16, GraphicsUnit.Pixel)
                    End If
                End If
            'Finished with bmp.
            bmp.Dispose()
        End If

    End Sub

    Private Sub DrawText(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        'There's a bug in MenuItem that I can't overcome.
        'When the Menu is drawn RightToLeft the Arrow, in menuitems 
        'with children, that I have no control over is moved to the 
        'Left side of the menuitem as it should be, but it is still 
        'right-aligned within its rectangle. Maybe this is not the
        'case when actually running on a system that is set up for 
        'right to left, but since mines not, I can't test that.

        Dim TextRectF As New RectangleF(e.Bounds.X + 32, e.Bounds.Top, e.Bounds.Width - 48, e.Bounds.Height)
        Dim TextBrush As Brush = New SolidBrush(m_ForeColor)
        Dim MenuFont As Font = m_font 'default value normal menu font
        Dim sItemText() As String = Split(JoinItemText(), Chr(2))
        Dim sf As New System.Drawing.StringFormat(StringFormatFlags.NoWrap)

        'Vertical Centre Align for Text.
        sf.LineAlignment = StringAlignment.Center
        'Show Hot-Key UnderScore in Text.
        sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show

        If WindowMenu Then
            TextRectF = New RectangleF(e.Bounds.X + 8, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height)
        End If

        If m_RTLMenu Then
            If WindowMenu Then
                TextRectF.Offset(-8, 0)
            Else
                TextRectF.Offset(-10, 0)
            End If
        End If
        'if the menuitem is selected then get the highlighted forecolor
        If CBool(e.State And DrawItemState.Selected) _
        Or CBool(e.State And DrawItemState.HotLight) Then
            TextBrush = New SolidBrush(m_HighlightForecolor) 'when highlighted draw with the specified highlight font color
            MenuFont = m_HighLightFont 'when highlighted get the highlight font specified
        End If
        'if the menuitem is disabled then draw it with grey color
        If CBool(e.State And DrawItemState.Disabled) Then
            TextBrush = New SolidBrush(SystemColors.GrayText)
            MenuFont = m_font 'if diabled then draw with normal font
        End If
        'if right to left menu then alighn it properly
        If m_RTLMenu Then sf.Alignment = StringAlignment.Far
        e.Graphics.DrawString(sItemText(0), MenuFont, TextBrush, TextRectF, sf)
        'If ControlKey present then...
        If UBound(sItemText) = 1 Then
            'Right Align for Control Key Text.
            sf.Alignment = StringAlignment.Far
            If m_RTLMenu Then sf.Alignment = StringAlignment.Near
            e.Graphics.DrawString(sItemText(1), MenuFont, TextBrush, TextRectF, sf)
        End If

        'Finished with StringFormat and sItemText.
        TextBrush.Dispose()
        sf.Dispose()
        Erase sItemText

    End Sub
    Function Darken(ByVal Clr As Color, ByVal iAmount As Integer) As Color

        'Darkens a color by increasing each R, G, B value by
        'the number indicated (down to 0 min)
        '
        'ARGUMENTS:
        '[Clr]
        '   -The color to lighten
        '[iAmount]
        '   -The amount to decrease each value (0 - 255)
        '
        'RETURNS:   The new color

        Dim iR, iG, iB As Integer
        iR = 0
        iG = 0
        iB = 0
        If Clr.R > iAmount Then iR = Clr.R - iAmount
        If Clr.G > iAmount Then iG = Clr.G - iAmount
        If Clr.B > iAmount Then iB = Clr.B - iAmount

        Darken = Color.FromArgb(iR, iG, iB)
    End Function

    Function Lighten(ByVal Clr As Color, ByVal iAmount As Integer) As Color

        'Lightens a color by increasing each R, G, B value by
        'the number indicated (up to 255 max)
        '
        'ARGUMENTS:
        '[Clr]
        '   -The color to lighten
        '[iAmount]
        '   -The amount to increase each value (0 - 255)
        '
        'RETURNS:   The new color

        Dim iR, iG, iB As Integer
        iR = 255
        iG = 255
        iB = 255
        If Clr.R < 255 - iAmount Then iR = Clr.R + iAmount
        If Clr.G < 255 - iAmount Then iG = Clr.G + iAmount
        If Clr.B < 255 - iAmount Then iB = Clr.B + iAmount

        Lighten = Color.FromArgb(iR, iG, iB)
    End Function
#End Region

    Private Function JoinItemText() As String
        'Other Classes, that I've seen, join the Text and 
        'Control Key together seperated by a wide Tab.
        '(hmm...join them seperated, that makes sense.)
        'Looking at all MS MenuItems, the Control Key is 
        'actually Right Aligned in the Menu, so we will return
        'a Chr(2) delimited string containing both items to
        'enable us to draw them seperately. 
        'Chr(2) is used as it is unlikely that anyone will use
        'this character in a Menu Items caption.
        Dim ItemText As String = Me.Text

        If Me.ShowShortcut And Me.Shortcut <> Shortcut.None Then
            Dim k As Keys = CType(Me.Shortcut, Keys)
            ItemText += Chr(2) & TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(k)
        End If

        Return ItemText

    End Function

#End Region

End Class
