Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem2 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem3 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem4 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem5 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem6 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem7 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem8 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem9 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem10 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem11 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem12 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem13 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem14 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem15 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem16 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem17 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem18 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem19 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem20 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem21 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem22 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem23 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem24 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem25 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem26 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem27 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem28 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem29 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem30 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem31 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem33 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem32 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem34 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem35 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem36 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem37 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem38 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem39 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem40 As UltimateMenus.KunalMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem41 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem42 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem43 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem44 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem46 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem47 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem48 As UltimateMenus.KunalMenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New UltimateMenus.KunalMenuItem
        Me.MenuItem2 = New UltimateMenus.KunalMenuItem
        Me.MenuItem3 = New UltimateMenus.KunalMenuItem
        Me.MenuItem4 = New UltimateMenus.KunalMenuItem
        Me.MenuItem13 = New UltimateMenus.KunalMenuItem
        Me.MenuItem14 = New UltimateMenus.KunalMenuItem
        Me.MenuItem25 = New UltimateMenus.KunalMenuItem
        Me.MenuItem26 = New UltimateMenus.KunalMenuItem
        Me.MenuItem15 = New UltimateMenus.KunalMenuItem
        Me.MenuItem5 = New UltimateMenus.KunalMenuItem
        Me.MenuItem6 = New UltimateMenus.KunalMenuItem
        Me.MenuItem7 = New UltimateMenus.KunalMenuItem
        Me.MenuItem8 = New UltimateMenus.KunalMenuItem
        Me.MenuItem10 = New UltimateMenus.KunalMenuItem
        Me.MenuItem9 = New UltimateMenus.KunalMenuItem
        Me.MenuItem11 = New UltimateMenus.KunalMenuItem
        Me.MenuItem12 = New UltimateMenus.KunalMenuItem
        Me.MenuItem16 = New UltimateMenus.KunalMenuItem
        Me.MenuItem17 = New UltimateMenus.KunalMenuItem
        Me.MenuItem18 = New UltimateMenus.KunalMenuItem
        Me.MenuItem19 = New UltimateMenus.KunalMenuItem
        Me.MenuItem34 = New UltimateMenus.KunalMenuItem
        Me.MenuItem33 = New UltimateMenus.KunalMenuItem
        Me.MenuItem20 = New UltimateMenus.KunalMenuItem
        Me.MenuItem21 = New UltimateMenus.KunalMenuItem
        Me.MenuItem32 = New UltimateMenus.KunalMenuItem
        Me.MenuItem22 = New UltimateMenus.KunalMenuItem
        Me.MenuItem23 = New UltimateMenus.KunalMenuItem
        Me.MenuItem24 = New UltimateMenus.KunalMenuItem
        Me.MenuItem27 = New UltimateMenus.KunalMenuItem
        Me.MenuItem28 = New UltimateMenus.KunalMenuItem
        Me.MenuItem29 = New UltimateMenus.KunalMenuItem
        Me.MenuItem30 = New UltimateMenus.KunalMenuItem
        Me.MenuItem31 = New UltimateMenus.KunalMenuItem
        Me.MenuItem35 = New UltimateMenus.KunalMenuItem
        Me.MenuItem36 = New UltimateMenus.KunalMenuItem
        Me.MenuItem37 = New UltimateMenus.KunalMenuItem
        Me.MenuItem38 = New UltimateMenus.KunalMenuItem
        Me.MenuItem39 = New UltimateMenus.KunalMenuItem
        Me.MenuItem40 = New UltimateMenus.KunalMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem41 = New UltimateMenus.KunalMenuItem
        Me.MenuItem42 = New UltimateMenus.KunalMenuItem
        Me.MenuItem43 = New UltimateMenus.KunalMenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New UltimateMenus.KunalMenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New UltimateMenus.KunalMenuItem
        Me.MenuItem47 = New UltimateMenus.KunalMenuItem
        Me.MenuItem48 = New UltimateMenus.KunalMenuItem
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem16, Me.MenuItem27, Me.MenuItem35})
        '
        'MenuItem1
        '
        Me.MenuItem1.CheckedImageIndex = 0
        Me.MenuItem1.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem1.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem1.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem1.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem1.FillMenuBarItem = False
        Me.MenuItem1.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem1.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem1.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem1.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem1.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem1.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem1.ImageIndex = 0
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem1.MakeTransparentIcon = False
        Me.MenuItem1.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem1.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem1.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem1.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        Me.MenuItem1.OwnerDraw = True
        Me.MenuItem1.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem1.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem1.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem1.ShowBorderAroundMenuBar = False
        Me.MenuItem1.ShowHiliteOverSideBar = False
        Me.MenuItem1.ShowShadowUnderMenuBar = True
        Me.MenuItem1.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem1.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.BackColor = System.Drawing.Color.White
        Me.MenuItem2.CheckedImageIndex = 0
        Me.MenuItem2.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem2.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem2.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemTickMark
        Me.MenuItem2.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem2.FillMenuBarItem = False
        Me.MenuItem2.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem2.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem2.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem2.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem2.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.MenuItem2.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconNone
        Me.MenuItem2.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem2.Image = CType(resources.GetObject("MenuItem2.Image"), System.Drawing.Image)
        Me.MenuItem2.ImageIndex = 0
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem2.MakeTransparentIcon = False
        Me.MenuItem2.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem2.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem2.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem2.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem2.OwnerDraw = True
        Me.MenuItem2.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem2.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem2.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.ShowBorderAroundMenuBar = False
        Me.MenuItem2.ShowHiliteOverSideBar = True
        Me.MenuItem2.ShowShadowUnderMenuBar = True
        Me.MenuItem2.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem2.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem2.Text = "New"
        '
        'MenuItem3
        '
        Me.MenuItem3.BackColor = System.Drawing.Color.White
        Me.MenuItem3.CheckedImageIndex = 0
        Me.MenuItem3.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem3.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem3.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem3.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem3.FillMenuBarItem = False
        Me.MenuItem3.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem3.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem3.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem3.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem3.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem3.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconNone
        Me.MenuItem3.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem3.Image = CType(resources.GetObject("MenuItem3.Image"), System.Drawing.Image)
        Me.MenuItem3.ImageIndex = 0
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem3.MakeTransparentIcon = False
        Me.MenuItem3.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem3.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem3.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem3.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem3.OwnerDraw = True
        Me.MenuItem3.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem3.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem3.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem3.ShowBorderAroundMenuBar = False
        Me.MenuItem3.ShowHiliteOverSideBar = True
        Me.MenuItem3.ShowShadowUnderMenuBar = True
        Me.MenuItem3.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem3.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem3.Text = "Open"
        '
        'MenuItem4
        '
        Me.MenuItem4.BackColor = System.Drawing.Color.White
        Me.MenuItem4.CheckedImageIndex = 0
        Me.MenuItem4.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem4.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem4.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem4.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem4.FillMenuBarItem = False
        Me.MenuItem4.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem4.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem4.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem4.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem4.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem4.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconNone
        Me.MenuItem4.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem4.Image = CType(resources.GetObject("MenuItem4.Image"), System.Drawing.Image)
        Me.MenuItem4.ImageIndex = 0
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem4.MakeTransparentIcon = False
        Me.MenuItem4.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem4.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem4.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem4.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem4.OwnerDraw = True
        Me.MenuItem4.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem4.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem4.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem4.ShowBorderAroundMenuBar = False
        Me.MenuItem4.ShowHiliteOverSideBar = True
        Me.MenuItem4.ShowShadowUnderMenuBar = True
        Me.MenuItem4.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem4.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem4.Text = "Save"
        '
        'MenuItem13
        '
        Me.MenuItem13.BackColor = System.Drawing.Color.White
        Me.MenuItem13.CheckedImageIndex = 0
        Me.MenuItem13.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem13.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem13.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem13.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem13.FillMenuBarItem = False
        Me.MenuItem13.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem13.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem13.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem13.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem13.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem13.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem13.ImageIndex = 0
        Me.MenuItem13.Index = 3
        Me.MenuItem13.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem13.MakeTransparentIcon = False
        Me.MenuItem13.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem13.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem13.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem13.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem13.OwnerDraw = True
        Me.MenuItem13.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem13.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem13.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem13.ShowBorderAroundMenuBar = False
        Me.MenuItem13.ShowHiliteOverSideBar = False
        Me.MenuItem13.ShowShadowUnderMenuBar = True
        Me.MenuItem13.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem13.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.BackColor = System.Drawing.Color.White
        Me.MenuItem14.CheckedImageIndex = 0
        Me.MenuItem14.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem14.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem14.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem14.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem14.FillMenuBarItem = False
        Me.MenuItem14.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem14.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem14.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem14.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem14.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem14.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem14.Image = CType(resources.GetObject("MenuItem14.Image"), System.Drawing.Image)
        Me.MenuItem14.ImageIndex = 0
        Me.MenuItem14.Index = 4
        Me.MenuItem14.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem14.MakeTransparentIcon = False
        Me.MenuItem14.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem14.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem14.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem14.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem14.OwnerDraw = True
        Me.MenuItem14.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem14.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem14.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem14.ShowBorderAroundMenuBar = False
        Me.MenuItem14.ShowHiliteOverSideBar = False
        Me.MenuItem14.ShowShadowUnderMenuBar = True
        Me.MenuItem14.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem14.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem14.Text = "Print"
        '
        'MenuItem25
        '
        Me.MenuItem25.CheckedImageIndex = 0
        Me.MenuItem25.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem25.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem25.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem25.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem25.FillMenuBarItem = False
        Me.MenuItem25.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem25.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem25.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem25.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem25.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem25.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem25.ImageIndex = 0
        Me.MenuItem25.Index = 0
        Me.MenuItem25.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem25.MakeTransparentIcon = False
        Me.MenuItem25.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem25.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem25.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem25.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem25.OwnerDraw = True
        Me.MenuItem25.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem25.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem25.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem25.ShowBorderAroundMenuBar = False
        Me.MenuItem25.ShowHiliteOverSideBar = False
        Me.MenuItem25.ShowShadowUnderMenuBar = True
        Me.MenuItem25.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem25.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem25.Text = "All Pages"
        '
        'MenuItem26
        '
        Me.MenuItem26.CheckedImageIndex = 0
        Me.MenuItem26.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem26.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem26.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem26.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem26.FillMenuBarItem = False
        Me.MenuItem26.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem26.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem26.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem26.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem26.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem26.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem26.ImageIndex = 0
        Me.MenuItem26.Index = 1
        Me.MenuItem26.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem26.MakeTransparentIcon = False
        Me.MenuItem26.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem26.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem26.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem26.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem26.OwnerDraw = True
        Me.MenuItem26.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem26.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem26.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem26.ShowBorderAroundMenuBar = False
        Me.MenuItem26.ShowHiliteOverSideBar = False
        Me.MenuItem26.ShowShadowUnderMenuBar = True
        Me.MenuItem26.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem26.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem26.Text = "Current Page"
        '
        'MenuItem15
        '
        Me.MenuItem15.BackColor = System.Drawing.Color.White
        Me.MenuItem15.CheckedImageIndex = 0
        Me.MenuItem15.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem15.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem15.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem15.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem15.FillMenuBarItem = False
        Me.MenuItem15.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem15.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem15.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem15.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem15.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem15.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem15.Image = CType(resources.GetObject("MenuItem15.Image"), System.Drawing.Image)
        Me.MenuItem15.ImageIndex = 0
        Me.MenuItem15.Index = 5
        Me.MenuItem15.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem15.MakeTransparentIcon = False
        Me.MenuItem15.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem15.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem15.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem15.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem15.OwnerDraw = True
        Me.MenuItem15.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem15.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem15.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem15.ShowBorderAroundMenuBar = False
        Me.MenuItem15.ShowHiliteOverSideBar = False
        Me.MenuItem15.ShowShadowUnderMenuBar = True
        Me.MenuItem15.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem15.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Blue
        Me.MenuItem15.Text = "Exit"
        '
        'MenuItem5
        '
        Me.MenuItem5.CheckedImageIndex = 0
        Me.MenuItem5.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem5.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem5.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem5.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem5.FillMenuBarItem = False
        Me.MenuItem5.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem5.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem5.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem5.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem5.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem5.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem5.ImageIndex = 0
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem5.MakeTransparentIcon = False
        Me.MenuItem5.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem5.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem5.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem5.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem10, Me.MenuItem9, Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem5.OwnerDraw = True
        Me.MenuItem5.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem5.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem5.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem5.ShowBorderAroundMenuBar = False
        Me.MenuItem5.ShowHiliteOverSideBar = False
        Me.MenuItem5.ShowShadowUnderMenuBar = True
        Me.MenuItem5.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem5.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem5.Text = "Edit"
        '
        'MenuItem6
        '
        Me.MenuItem6.BackColor = System.Drawing.Color.White
        Me.MenuItem6.CheckedImageIndex = 0
        Me.MenuItem6.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem6.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem6.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem6.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem6.FillMenuBarItem = False
        Me.MenuItem6.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem6.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem6.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem6.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem6.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem6.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem6.Image = CType(resources.GetObject("MenuItem6.Image"), System.Drawing.Image)
        Me.MenuItem6.ImageIndex = 0
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem6.MakeTransparentIcon = False
        Me.MenuItem6.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem6.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem6.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem6.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem6.OwnerDraw = True
        Me.MenuItem6.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem6.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem6.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem6.ShowBorderAroundMenuBar = False
        Me.MenuItem6.ShowHiliteOverSideBar = False
        Me.MenuItem6.ShowShadowUnderMenuBar = True
        Me.MenuItem6.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem6.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem6.Text = "Cut"
        '
        'MenuItem7
        '
        Me.MenuItem7.BackColor = System.Drawing.Color.White
        Me.MenuItem7.CheckedImageIndex = 0
        Me.MenuItem7.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem7.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem7.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem7.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem7.FillMenuBarItem = False
        Me.MenuItem7.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem7.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem7.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem7.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem7.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem7.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem7.Image = CType(resources.GetObject("MenuItem7.Image"), System.Drawing.Image)
        Me.MenuItem7.ImageIndex = 0
        Me.MenuItem7.Index = 1
        Me.MenuItem7.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem7.MakeTransparentIcon = False
        Me.MenuItem7.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem7.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem7.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem7.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem7.OwnerDraw = True
        Me.MenuItem7.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem7.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem7.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem7.ShowBorderAroundMenuBar = False
        Me.MenuItem7.ShowHiliteOverSideBar = False
        Me.MenuItem7.ShowShadowUnderMenuBar = True
        Me.MenuItem7.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem7.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem7.Text = "Copy"
        '
        'MenuItem8
        '
        Me.MenuItem8.BackColor = System.Drawing.Color.White
        Me.MenuItem8.CheckedImageIndex = 0
        Me.MenuItem8.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem8.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem8.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem8.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem8.FillMenuBarItem = False
        Me.MenuItem8.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem8.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem8.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem8.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem8.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem8.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem8.Image = CType(resources.GetObject("MenuItem8.Image"), System.Drawing.Image)
        Me.MenuItem8.ImageIndex = 0
        Me.MenuItem8.Index = 2
        Me.MenuItem8.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem8.MakeTransparentIcon = False
        Me.MenuItem8.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem8.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem8.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem8.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem8.OwnerDraw = True
        Me.MenuItem8.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem8.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem8.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem8.ShowBorderAroundMenuBar = False
        Me.MenuItem8.ShowHiliteOverSideBar = False
        Me.MenuItem8.ShowShadowUnderMenuBar = True
        Me.MenuItem8.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem8.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem8.Text = "Paste"
        '
        'MenuItem10
        '
        Me.MenuItem10.BackColor = System.Drawing.Color.White
        Me.MenuItem10.CheckedImageIndex = 0
        Me.MenuItem10.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem10.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem10.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem10.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem10.FillMenuBarItem = False
        Me.MenuItem10.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem10.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem10.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem10.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem10.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem10.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem10.ImageIndex = 0
        Me.MenuItem10.Index = 3
        Me.MenuItem10.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem10.MakeTransparentIcon = False
        Me.MenuItem10.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem10.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem10.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem10.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem10.OwnerDraw = True
        Me.MenuItem10.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem10.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem10.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem10.ShowBorderAroundMenuBar = False
        Me.MenuItem10.ShowHiliteOverSideBar = False
        Me.MenuItem10.ShowShadowUnderMenuBar = True
        Me.MenuItem10.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem10.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem10.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.BackColor = System.Drawing.Color.White
        Me.MenuItem9.Checked = True
        Me.MenuItem9.CheckedImageIndex = 0
        Me.MenuItem9.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem9.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Desktop
        Me.MenuItem9.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem9.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem9.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemTickMark
        Me.MenuItem9.CheckedMenuItemTickMarkColor = System.Drawing.Color.Red
        Me.MenuItem9.FillMenuBarItem = False
        Me.MenuItem9.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem9.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem9.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem9.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem9.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem9.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem9.ImageIndex = 0
        Me.MenuItem9.Index = 4
        Me.MenuItem9.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem9.MakeTransparentIcon = False
        Me.MenuItem9.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem9.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem9.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem9.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem9.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem9.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem9.ShowBorderAroundMenuBar = False
        Me.MenuItem9.ShowHiliteOverSideBar = True
        Me.MenuItem9.ShowShadowUnderMenuBar = True
        Me.MenuItem9.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem9.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem9.Text = "Shadow Checked Item (Custom)"
        '
        'MenuItem11
        '
        Me.MenuItem11.BackColor = System.Drawing.Color.White
        Me.MenuItem11.Checked = True
        Me.MenuItem11.CheckedImageIndex = 0
        Me.MenuItem11.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem11.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem11.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem11.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem11.FillMenuBarItem = False
        Me.MenuItem11.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem11.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem11.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem11.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem11.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem11.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem11.ImageIndex = 0
        Me.MenuItem11.Index = 5
        Me.MenuItem11.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem11.MakeTransparentIcon = False
        Me.MenuItem11.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem11.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem11.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem11.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem11.OwnerDraw = True
        Me.MenuItem11.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem11.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem11.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem11.ShowBorderAroundMenuBar = False
        Me.MenuItem11.ShowHiliteOverSideBar = True
        Me.MenuItem11.ShowShadowUnderMenuBar = True
        Me.MenuItem11.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem11.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem11.Text = "Normal Checked Item (Default)"
        '
        'MenuItem12
        '
        Me.MenuItem12.BackColor = System.Drawing.Color.White
        Me.MenuItem12.Checked = True
        Me.MenuItem12.CheckedImageIndex = 0
        Me.MenuItem12.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem12.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem12.CheckedMenuItemImage = CType(resources.GetObject("MenuItem12.CheckedMenuItemImage"), System.Drawing.Image)
        Me.MenuItem12.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemIcon
        Me.MenuItem12.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem12.FillMenuBarItem = False
        Me.MenuItem12.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem12.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem12.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem12.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem12.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem12.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem12.ImageIndex = 0
        Me.MenuItem12.Index = 6
        Me.MenuItem12.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem12.MakeTransparentIcon = False
        Me.MenuItem12.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem12.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem12.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem12.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem12.OwnerDraw = True
        Me.MenuItem12.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem12.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem12.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem12.ShowBorderAroundMenuBar = False
        Me.MenuItem12.ShowHiliteOverSideBar = True
        Me.MenuItem12.ShowShadowUnderMenuBar = True
        Me.MenuItem12.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem12.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003OliveGreen
        Me.MenuItem12.Text = "Icon Checked Item"
        Me.MenuItem12.TickMarkStyle = UltimateMenus.KunalMenuItem.TickMarkStyles.Normal
        '
        'MenuItem16
        '
        Me.MenuItem16.CheckedImageIndex = 0
        Me.MenuItem16.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem16.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem16.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem16.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem16.FillMenuBarItem = False
        Me.MenuItem16.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem16.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem16.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem16.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem16.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem16.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem16.ImageIndex = 0
        Me.MenuItem16.Index = 2
        Me.MenuItem16.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem16.MakeTransparentIcon = False
        Me.MenuItem16.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem16.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem16.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem16.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem34, Me.MenuItem33, Me.MenuItem20, Me.MenuItem21, Me.MenuItem32, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem16.OwnerDraw = True
        Me.MenuItem16.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem16.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem16.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem16.ShowBorderAroundMenuBar = False
        Me.MenuItem16.ShowHiliteOverSideBar = False
        Me.MenuItem16.ShowShadowUnderMenuBar = True
        Me.MenuItem16.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem16.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem16.Text = "Icon Styles"
        '
        'MenuItem17
        '
        Me.MenuItem17.BackColor = System.Drawing.Color.White
        Me.MenuItem17.CheckedImageIndex = 0
        Me.MenuItem17.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem17.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem17.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem17.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem17.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem17.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem17.FillMenuBarItem = False
        Me.MenuItem17.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem17.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem17.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem17.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem17.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem17.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem17.Image = CType(resources.GetObject("MenuItem17.Image"), System.Drawing.Image)
        Me.MenuItem17.ImageIndex = 0
        Me.MenuItem17.Index = 0
        Me.MenuItem17.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem17.MakeTransparentIcon = False
        Me.MenuItem17.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem17.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem17.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem17.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem17.OwnerDraw = True
        Me.MenuItem17.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem17.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem17.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem17.ShowBorderAroundMenuBar = False
        Me.MenuItem17.ShowHiliteOverSideBar = False
        Me.MenuItem17.ShowShadowUnderMenuBar = True
        Me.MenuItem17.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem17.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem17.Text = "Shadow"
        '
        'MenuItem18
        '
        Me.MenuItem18.BackColor = System.Drawing.Color.White
        Me.MenuItem18.CheckedImageIndex = 0
        Me.MenuItem18.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem18.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem18.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem18.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem18.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem18.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem18.FillMenuBarItem = False
        Me.MenuItem18.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem18.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem18.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem18.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem18.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem18.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconBump
        Me.MenuItem18.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem18.Image = CType(resources.GetObject("MenuItem18.Image"), System.Drawing.Image)
        Me.MenuItem18.ImageIndex = 0
        Me.MenuItem18.Index = 1
        Me.MenuItem18.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem18.MakeTransparentIcon = False
        Me.MenuItem18.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem18.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem18.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem18.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem18.OwnerDraw = True
        Me.MenuItem18.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem18.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem18.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem18.ShowBorderAroundMenuBar = False
        Me.MenuItem18.ShowHiliteOverSideBar = False
        Me.MenuItem18.ShowShadowUnderMenuBar = True
        Me.MenuItem18.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem18.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem18.Text = "Bump"
        '
        'MenuItem19
        '
        Me.MenuItem19.BackColor = System.Drawing.Color.White
        Me.MenuItem19.CheckedImageIndex = 0
        Me.MenuItem19.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem19.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem19.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem19.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem19.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem19.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem19.FillMenuBarItem = False
        Me.MenuItem19.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem19.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem19.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem19.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem19.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem19.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconFlat
        Me.MenuItem19.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem19.Image = CType(resources.GetObject("MenuItem19.Image"), System.Drawing.Image)
        Me.MenuItem19.ImageIndex = 0
        Me.MenuItem19.Index = 2
        Me.MenuItem19.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem19.MakeTransparentIcon = False
        Me.MenuItem19.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem19.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem19.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem19.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem19.OwnerDraw = True
        Me.MenuItem19.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem19.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem19.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem19.ShowBorderAroundMenuBar = False
        Me.MenuItem19.ShowHiliteOverSideBar = False
        Me.MenuItem19.ShowShadowUnderMenuBar = True
        Me.MenuItem19.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem19.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem19.Text = "Flat"
        '
        'MenuItem34
        '
        Me.MenuItem34.BackColor = System.Drawing.Color.White
        Me.MenuItem34.CheckedImageIndex = 0
        Me.MenuItem34.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem34.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem34.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem34.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem34.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem34.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem34.FillMenuBarItem = False
        Me.MenuItem34.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem34.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem34.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem34.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem34.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem34.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconEtched
        Me.MenuItem34.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem34.Image = CType(resources.GetObject("MenuItem34.Image"), System.Drawing.Image)
        Me.MenuItem34.ImageIndex = 0
        Me.MenuItem34.Index = 3
        Me.MenuItem34.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem34.MakeTransparentIcon = False
        Me.MenuItem34.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem34.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem34.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem34.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem34.OwnerDraw = True
        Me.MenuItem34.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem34.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem34.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem34.ShowBorderAroundMenuBar = False
        Me.MenuItem34.ShowHiliteOverSideBar = False
        Me.MenuItem34.ShowShadowUnderMenuBar = True
        Me.MenuItem34.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem34.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem34.Text = "Etched"
        '
        'MenuItem33
        '
        Me.MenuItem33.BackColor = System.Drawing.Color.White
        Me.MenuItem33.CheckedImageIndex = 0
        Me.MenuItem33.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem33.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem33.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem33.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem33.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem33.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem33.FillMenuBarItem = False
        Me.MenuItem33.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem33.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem33.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem33.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem33.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem33.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem33.ImageIndex = 0
        Me.MenuItem33.Index = 4
        Me.MenuItem33.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem33.MakeTransparentIcon = False
        Me.MenuItem33.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem33.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem33.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem33.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem33.OwnerDraw = True
        Me.MenuItem33.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem33.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem33.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem33.ShowBorderAroundMenuBar = False
        Me.MenuItem33.ShowHiliteOverSideBar = False
        Me.MenuItem33.ShowShadowUnderMenuBar = True
        Me.MenuItem33.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem33.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem33.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.BackColor = System.Drawing.Color.White
        Me.MenuItem20.CheckedImageIndex = 0
        Me.MenuItem20.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem20.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem20.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem20.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem20.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem20.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem20.FillMenuBarItem = False
        Me.MenuItem20.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem20.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem20.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem20.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem20.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem20.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconRaisedInner
        Me.MenuItem20.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem20.Image = CType(resources.GetObject("MenuItem20.Image"), System.Drawing.Image)
        Me.MenuItem20.ImageIndex = 0
        Me.MenuItem20.Index = 5
        Me.MenuItem20.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem20.MakeTransparentIcon = False
        Me.MenuItem20.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem20.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem20.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem20.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem20.OwnerDraw = True
        Me.MenuItem20.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem20.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem20.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem20.ShowBorderAroundMenuBar = False
        Me.MenuItem20.ShowHiliteOverSideBar = False
        Me.MenuItem20.ShowShadowUnderMenuBar = True
        Me.MenuItem20.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem20.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem20.Text = "Raised Inner"
        '
        'MenuItem21
        '
        Me.MenuItem21.BackColor = System.Drawing.Color.White
        Me.MenuItem21.CheckedImageIndex = 0
        Me.MenuItem21.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem21.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem21.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem21.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem21.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem21.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem21.FillMenuBarItem = False
        Me.MenuItem21.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem21.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem21.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem21.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem21.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem21.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconRaisedOuter
        Me.MenuItem21.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem21.Image = CType(resources.GetObject("MenuItem21.Image"), System.Drawing.Image)
        Me.MenuItem21.ImageIndex = 0
        Me.MenuItem21.Index = 6
        Me.MenuItem21.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem21.MakeTransparentIcon = False
        Me.MenuItem21.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem21.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem21.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem21.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem21.OwnerDraw = True
        Me.MenuItem21.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem21.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem21.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem21.ShowBorderAroundMenuBar = False
        Me.MenuItem21.ShowHiliteOverSideBar = False
        Me.MenuItem21.ShowShadowUnderMenuBar = True
        Me.MenuItem21.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem21.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem21.Text = "Raised Outer"
        '
        'MenuItem32
        '
        Me.MenuItem32.BackColor = System.Drawing.Color.White
        Me.MenuItem32.CheckedImageIndex = 0
        Me.MenuItem32.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem32.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem32.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem32.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem32.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem32.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem32.FillMenuBarItem = False
        Me.MenuItem32.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem32.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem32.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem32.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem32.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem32.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem32.ImageIndex = 0
        Me.MenuItem32.Index = 7
        Me.MenuItem32.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem32.MakeTransparentIcon = False
        Me.MenuItem32.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem32.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem32.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem32.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem32.OwnerDraw = True
        Me.MenuItem32.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem32.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem32.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem32.ShowBorderAroundMenuBar = False
        Me.MenuItem32.ShowHiliteOverSideBar = False
        Me.MenuItem32.ShowShadowUnderMenuBar = True
        Me.MenuItem32.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem32.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem32.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.BackColor = System.Drawing.Color.White
        Me.MenuItem22.CheckedImageIndex = 0
        Me.MenuItem22.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem22.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem22.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem22.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem22.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem22.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem22.FillMenuBarItem = False
        Me.MenuItem22.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem22.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem22.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem22.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem22.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem22.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconSunken
        Me.MenuItem22.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem22.Image = CType(resources.GetObject("MenuItem22.Image"), System.Drawing.Image)
        Me.MenuItem22.ImageIndex = 0
        Me.MenuItem22.Index = 8
        Me.MenuItem22.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem22.MakeTransparentIcon = False
        Me.MenuItem22.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem22.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem22.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem22.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem22.OwnerDraw = True
        Me.MenuItem22.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem22.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem22.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem22.ShowBorderAroundMenuBar = False
        Me.MenuItem22.ShowHiliteOverSideBar = False
        Me.MenuItem22.ShowShadowUnderMenuBar = True
        Me.MenuItem22.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem22.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem22.Text = "Sunken"
        '
        'MenuItem23
        '
        Me.MenuItem23.BackColor = System.Drawing.Color.White
        Me.MenuItem23.CheckedImageIndex = 0
        Me.MenuItem23.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem23.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem23.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem23.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem23.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem23.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem23.FillMenuBarItem = False
        Me.MenuItem23.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem23.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem23.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem23.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem23.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem23.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconSunkenInner
        Me.MenuItem23.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem23.Image = CType(resources.GetObject("MenuItem23.Image"), System.Drawing.Image)
        Me.MenuItem23.ImageIndex = 0
        Me.MenuItem23.Index = 9
        Me.MenuItem23.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem23.MakeTransparentIcon = False
        Me.MenuItem23.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem23.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem23.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem23.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem23.OwnerDraw = True
        Me.MenuItem23.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem23.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem23.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem23.ShowBorderAroundMenuBar = False
        Me.MenuItem23.ShowHiliteOverSideBar = False
        Me.MenuItem23.ShowShadowUnderMenuBar = True
        Me.MenuItem23.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem23.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem23.Text = "Sunken Inner"
        '
        'MenuItem24
        '
        Me.MenuItem24.BackColor = System.Drawing.Color.White
        Me.MenuItem24.CheckedImageIndex = 0
        Me.MenuItem24.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem24.CheckedMenuItemBorderColor = System.Drawing.Color.White
        Me.MenuItem24.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem24.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem24.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem24.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem24.FillMenuBarItem = False
        Me.MenuItem24.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem24.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem24.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem24.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem24.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem24.IconHiLiteStyle = UltimateMenus.KunalMenuItem.IconStyle.IconSunkenOuter
        Me.MenuItem24.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem24.Image = CType(resources.GetObject("MenuItem24.Image"), System.Drawing.Image)
        Me.MenuItem24.ImageIndex = 0
        Me.MenuItem24.Index = 10
        Me.MenuItem24.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem24.MakeTransparentIcon = False
        Me.MenuItem24.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem24.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem24.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem24.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem24.OwnerDraw = True
        Me.MenuItem24.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem24.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem24.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem24.ShowBorderAroundMenuBar = False
        Me.MenuItem24.ShowHiliteOverSideBar = False
        Me.MenuItem24.ShowShadowUnderMenuBar = True
        Me.MenuItem24.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem24.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Silver
        Me.MenuItem24.Text = "Sunken Outer"
        '
        'MenuItem27
        '
        Me.MenuItem27.CheckedImageIndex = 0
        Me.MenuItem27.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem27.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem27.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem27.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem27.FillMenuBarItem = False
        Me.MenuItem27.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem27.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem27.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem27.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem27.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem27.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem27.ImageIndex = 0
        Me.MenuItem27.Index = 3
        Me.MenuItem27.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem27.MakeTransparentIcon = False
        Me.MenuItem27.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem27.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem27.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem27.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31})
        Me.MenuItem27.OwnerDraw = True
        Me.MenuItem27.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem27.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem27.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem27.ShowBorderAroundMenuBar = False
        Me.MenuItem27.ShowHiliteOverSideBar = False
        Me.MenuItem27.ShowShadowUnderMenuBar = True
        Me.MenuItem27.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem27.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Classic
        Me.MenuItem27.Text = "Another Menu"
        '
        'MenuItem28
        '
        Me.MenuItem28.BackColor = System.Drawing.Color.White
        Me.MenuItem28.CheckedImageIndex = 0
        Me.MenuItem28.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem28.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem28.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem28.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem28.FillMenuBarItem = False
        Me.MenuItem28.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem28.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem28.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem28.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem28.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem28.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem28.ImageIndex = 0
        Me.MenuItem28.Index = 0
        Me.MenuItem28.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem28.MakeTransparentIcon = False
        Me.MenuItem28.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem28.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem28.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem28.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem28.OwnerDraw = True
        Me.MenuItem28.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem28.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem28.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem28.ShowBorderAroundMenuBar = False
        Me.MenuItem28.ShowHiliteOverSideBar = False
        Me.MenuItem28.ShowShadowUnderMenuBar = True
        Me.MenuItem28.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem28.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Classic
        Me.MenuItem28.Text = "Hello World"
        '
        'MenuItem29
        '
        Me.MenuItem29.BackColor = System.Drawing.Color.White
        Me.MenuItem29.CheckedImageIndex = 0
        Me.MenuItem29.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem29.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem29.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem29.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem29.FillMenuBarItem = False
        Me.MenuItem29.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem29.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem29.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem29.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem29.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem29.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem29.ImageIndex = 0
        Me.MenuItem29.Index = 1
        Me.MenuItem29.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem29.MakeTransparentIcon = False
        Me.MenuItem29.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem29.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem29.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem29.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem29.OwnerDraw = True
        Me.MenuItem29.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem29.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem29.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem29.ShowBorderAroundMenuBar = False
        Me.MenuItem29.ShowHiliteOverSideBar = False
        Me.MenuItem29.ShowShadowUnderMenuBar = True
        Me.MenuItem29.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem29.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Classic
        Me.MenuItem29.Text = "Do You Like This?"
        '
        'MenuItem30
        '
        Me.MenuItem30.BackColor = System.Drawing.Color.White
        Me.MenuItem30.CheckedImageIndex = 0
        Me.MenuItem30.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem30.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem30.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem30.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem30.FillMenuBarItem = False
        Me.MenuItem30.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem30.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem30.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem30.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem30.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem30.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem30.ImageIndex = 0
        Me.MenuItem30.Index = 2
        Me.MenuItem30.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem30.MakeTransparentIcon = False
        Me.MenuItem30.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem30.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem30.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem30.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem30.OwnerDraw = True
        Me.MenuItem30.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem30.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem30.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem30.ShowBorderAroundMenuBar = False
        Me.MenuItem30.ShowHiliteOverSideBar = False
        Me.MenuItem30.ShowShadowUnderMenuBar = True
        Me.MenuItem30.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem30.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Classic
        Me.MenuItem30.Text = "Simple! In't It?"
        '
        'MenuItem31
        '
        Me.MenuItem31.BackColor = System.Drawing.Color.White
        Me.MenuItem31.Checked = True
        Me.MenuItem31.CheckedImageIndex = 0
        Me.MenuItem31.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem31.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem31.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem31.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem31.FillMenuBarItem = False
        Me.MenuItem31.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem31.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.DefaultScheme
        Me.MenuItem31.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem31.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem31.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem31.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem31.ImageIndex = 0
        Me.MenuItem31.Index = 3
        Me.MenuItem31.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem31.MakeTransparentIcon = False
        Me.MenuItem31.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem31.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem31.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem31.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem31.OwnerDraw = True
        Me.MenuItem31.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem31.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem31.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem31.ShowBorderAroundMenuBar = False
        Me.MenuItem31.ShowHiliteOverSideBar = True
        Me.MenuItem31.ShowShadowUnderMenuBar = True
        Me.MenuItem31.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem31.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Office2003Classic
        Me.MenuItem31.Text = "Hi! Guys"
        '
        'MenuItem35
        '
        Me.MenuItem35.CheckedImageIndex = 0
        Me.MenuItem35.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem35.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem35.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem35.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem35.FillMenuBarItem = False
        Me.MenuItem35.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem35.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem35.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem35.HiliteGradientColor2 = System.Drawing.Color.Coral
        Me.MenuItem35.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem35.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem35.ImageIndex = 0
        Me.MenuItem35.Index = 4
        Me.MenuItem35.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem35.MakeTransparentIcon = False
        Me.MenuItem35.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem35.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem35.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem35.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem35.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40})
        Me.MenuItem35.OwnerDraw = True
        Me.MenuItem35.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem35.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.PurpleWhite
        Me.MenuItem35.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem35.ShowBorderAroundMenuBar = False
        Me.MenuItem35.ShowHiliteOverSideBar = False
        Me.MenuItem35.ShowShadowUnderMenuBar = True
        Me.MenuItem35.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem35.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem35.Text = "Custom Menu"
        '
        'MenuItem36
        '
        Me.MenuItem36.BackColor = System.Drawing.Color.White
        Me.MenuItem36.CheckedImageIndex = 0
        Me.MenuItem36.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem36.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem36.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem36.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem36.FillMenuBarItem = False
        Me.MenuItem36.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem36.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem36.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem36.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem36.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem36.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem36.ImageIndex = 0
        Me.MenuItem36.Index = 0
        Me.MenuItem36.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem36.MakeTransparentIcon = False
        Me.MenuItem36.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem36.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillGradient
        Me.MenuItem36.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem36.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem36.OwnerDraw = True
        Me.MenuItem36.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem36.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.PurpleWhite
        Me.MenuItem36.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem36.ShowBorderAroundMenuBar = False
        Me.MenuItem36.ShowHiliteOverSideBar = False
        Me.MenuItem36.ShowShadowUnderMenuBar = True
        Me.MenuItem36.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem36.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.PredefinedGradient
        Me.MenuItem36.Text = "Custom One"
        '
        'MenuItem37
        '
        Me.MenuItem37.BackColor = System.Drawing.Color.White
        Me.MenuItem37.CheckedImageIndex = 0
        Me.MenuItem37.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem37.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem37.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem37.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem37.FillMenuBarItem = False
        Me.MenuItem37.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem37.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem37.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem37.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem37.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem37.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem37.ImageIndex = 0
        Me.MenuItem37.Index = 1
        Me.MenuItem37.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem37.MakeTransparentIcon = False
        Me.MenuItem37.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem37.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem37.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem37.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem37.OwnerDraw = True
        Me.MenuItem37.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem37.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem37.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem37.ShowBorderAroundMenuBar = False
        Me.MenuItem37.ShowHiliteOverSideBar = False
        Me.MenuItem37.ShowShadowUnderMenuBar = True
        Me.MenuItem37.SideBarColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.MenuItem37.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem37.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.Standard
        Me.MenuItem37.Text = "Custom Two"
        '
        'MenuItem38
        '
        Me.MenuItem38.BackColor = System.Drawing.Color.White
        Me.MenuItem38.CheckedImageIndex = 0
        Me.MenuItem38.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem38.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem38.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem38.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem38.FillMenuBarItem = False
        Me.MenuItem38.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem38.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem38.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem38.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem38.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem38.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem38.ImageIndex = 0
        Me.MenuItem38.Index = 2
        Me.MenuItem38.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem38.MakeTransparentIcon = False
        Me.MenuItem38.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem38.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem38.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem38.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem38.OwnerDraw = True
        Me.MenuItem38.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem38.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.PurpleWhite
        Me.MenuItem38.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem38.ShowBorderAroundMenuBar = False
        Me.MenuItem38.ShowHiliteOverSideBar = False
        Me.MenuItem38.ShowShadowUnderMenuBar = True
        Me.MenuItem38.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem38.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultColor
        Me.MenuItem38.Text = "Custom Three"
        Me.MenuItem38.TickMarkStyle = UltimateMenus.KunalMenuItem.TickMarkStyles.Normal
        '
        'MenuItem39
        '
        Me.MenuItem39.BackColor = System.Drawing.Color.White
        Me.MenuItem39.CheckedImageIndex = 0
        Me.MenuItem39.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem39.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem39.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem39.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem39.FillMenuBarItem = False
        Me.MenuItem39.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem39.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem39.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem39.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem39.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem39.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem39.ImageIndex = 0
        Me.MenuItem39.Index = 3
        Me.MenuItem39.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem39.MakeTransparentIcon = False
        Me.MenuItem39.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem39.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillGradient
        Me.MenuItem39.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem39.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem39.OwnerDraw = True
        Me.MenuItem39.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem39.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.GreenWhite
        Me.MenuItem39.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem39.ShowBorderAroundMenuBar = False
        Me.MenuItem39.ShowHiliteOverSideBar = False
        Me.MenuItem39.ShowShadowUnderMenuBar = True
        Me.MenuItem39.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem39.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem39.Text = "Custom Four"
        '
        'MenuItem40
        '
        Me.MenuItem40.BackColor = System.Drawing.Color.White
        Me.MenuItem40.CheckedImageIndex = 0
        Me.MenuItem40.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem40.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem40.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem40.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem40.FillMenuBarItem = False
        Me.MenuItem40.HighLightForeColor = System.Drawing.SystemColors.HighlightText
        Me.MenuItem40.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.PredefinedGradient
        Me.MenuItem40.HiliteGradientColor1 = System.Drawing.Color.WhiteSmoke
        Me.MenuItem40.HiliteGradientColor2 = System.Drawing.Color.CornflowerBlue
        Me.MenuItem40.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem40.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem40.ImageIndex = 0
        Me.MenuItem40.Index = 4
        Me.MenuItem40.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem40.MakeTransparentIcon = False
        Me.MenuItem40.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem40.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillGradient
        Me.MenuItem40.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem40.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem40.OwnerDraw = True
        Me.MenuItem40.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem40.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.GreenWhite
        Me.MenuItem40.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem40.ShowBorderAroundMenuBar = False
        Me.MenuItem40.ShowHiliteOverSideBar = False
        Me.MenuItem40.ShowShadowUnderMenuBar = True
        Me.MenuItem40.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MenuItem40.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.DefaultGradient
        Me.MenuItem40.Text = "Custom Five"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ContextMenu = Me.ContextMenu1
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 136)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Right click on me to se the context menu."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem42, Me.MenuItem43, Me.MenuItem49, Me.MenuItem44, Me.MenuItem45, Me.MenuItem46, Me.MenuItem47, Me.MenuItem48})
        '
        'MenuItem41
        '
        Me.MenuItem41.BackColor = System.Drawing.Color.White
        Me.MenuItem41.CheckedImageIndex = 0
        Me.MenuItem41.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem41.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem41.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem41.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem41.FillMenuBarItem = False
        Me.MenuItem41.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem41.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem41.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem41.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem41.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem41.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem41.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem41.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem41.ImageIndex = 0
        Me.MenuItem41.Index = 0
        Me.MenuItem41.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem41.MakeTransparentIcon = False
        Me.MenuItem41.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem41.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem41.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem41.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem41.OwnerDraw = True
        Me.MenuItem41.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem41.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem41.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem41.ShowBorderAroundMenuBar = False
        Me.MenuItem41.ShowHiliteOverSideBar = False
        Me.MenuItem41.ShowShadowUnderMenuBar = True
        Me.MenuItem41.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem41.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem41.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem41.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem41.Text = "asd1"
        '
        'MenuItem42
        '
        Me.MenuItem42.BackColor = System.Drawing.Color.White
        Me.MenuItem42.CheckedImageIndex = 0
        Me.MenuItem42.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem42.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem42.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem42.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem42.FillMenuBarItem = False
        Me.MenuItem42.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem42.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem42.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem42.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem42.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem42.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem42.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem42.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem42.ImageIndex = 0
        Me.MenuItem42.Index = 1
        Me.MenuItem42.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem42.MakeTransparentIcon = False
        Me.MenuItem42.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem42.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem42.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem42.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem42.OwnerDraw = True
        Me.MenuItem42.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem42.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem42.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem42.ShowBorderAroundMenuBar = False
        Me.MenuItem42.ShowHiliteOverSideBar = False
        Me.MenuItem42.ShowShadowUnderMenuBar = True
        Me.MenuItem42.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem42.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem42.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem42.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem42.Text = "asd2"
        '
        'MenuItem43
        '
        Me.MenuItem43.BackColor = System.Drawing.Color.White
        Me.MenuItem43.CheckedImageIndex = 0
        Me.MenuItem43.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem43.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem43.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem43.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem43.FillMenuBarItem = False
        Me.MenuItem43.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem43.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem43.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem43.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem43.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem43.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem43.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem43.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem43.ImageIndex = 0
        Me.MenuItem43.Index = 2
        Me.MenuItem43.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem43.MakeTransparentIcon = False
        Me.MenuItem43.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem43.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem43.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem43.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem43.OwnerDraw = True
        Me.MenuItem43.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem43.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem43.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem43.ShowBorderAroundMenuBar = False
        Me.MenuItem43.ShowHiliteOverSideBar = False
        Me.MenuItem43.ShowShadowUnderMenuBar = True
        Me.MenuItem43.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem43.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem43.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem43.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem43.Text = "asd3"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 3
        Me.MenuItem49.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.BackColor = System.Drawing.Color.White
        Me.MenuItem44.CheckedImageIndex = 0
        Me.MenuItem44.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem44.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem44.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem44.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem44.FillMenuBarItem = False
        Me.MenuItem44.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem44.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem44.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem44.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem44.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem44.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem44.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem44.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem44.ImageIndex = 0
        Me.MenuItem44.Index = 4
        Me.MenuItem44.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem44.MakeTransparentIcon = False
        Me.MenuItem44.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem44.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem44.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem44.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem44.OwnerDraw = True
        Me.MenuItem44.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem44.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem44.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem44.ShowBorderAroundMenuBar = False
        Me.MenuItem44.ShowHiliteOverSideBar = False
        Me.MenuItem44.ShowShadowUnderMenuBar = True
        Me.MenuItem44.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem44.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem44.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem44.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem44.Text = "asd4"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 5
        Me.MenuItem45.Text = "-"
        '
        'MenuItem46
        '
        Me.MenuItem46.BackColor = System.Drawing.Color.White
        Me.MenuItem46.CheckedImageIndex = 0
        Me.MenuItem46.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem46.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem46.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem46.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem46.FillMenuBarItem = False
        Me.MenuItem46.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem46.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem46.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem46.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem46.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem46.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem46.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem46.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem46.ImageIndex = 0
        Me.MenuItem46.Index = 6
        Me.MenuItem46.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem46.MakeTransparentIcon = False
        Me.MenuItem46.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem46.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem46.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem46.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem46.OwnerDraw = True
        Me.MenuItem46.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem46.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem46.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem46.ShowBorderAroundMenuBar = False
        Me.MenuItem46.ShowHiliteOverSideBar = False
        Me.MenuItem46.ShowShadowUnderMenuBar = True
        Me.MenuItem46.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem46.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem46.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem46.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem46.Text = "MenuItem5"
        '
        'MenuItem47
        '
        Me.MenuItem47.BackColor = System.Drawing.Color.White
        Me.MenuItem47.CheckedImageIndex = 0
        Me.MenuItem47.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem47.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem47.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem47.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem47.FillMenuBarItem = False
        Me.MenuItem47.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem47.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem47.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem47.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem47.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem47.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem47.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem47.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem47.ImageIndex = 0
        Me.MenuItem47.Index = 7
        Me.MenuItem47.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem47.MakeTransparentIcon = False
        Me.MenuItem47.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem47.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem47.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem47.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem47.OwnerDraw = True
        Me.MenuItem47.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem47.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem47.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem47.ShowBorderAroundMenuBar = False
        Me.MenuItem47.ShowHiliteOverSideBar = False
        Me.MenuItem47.ShowShadowUnderMenuBar = True
        Me.MenuItem47.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem47.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem47.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem47.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem47.Text = "MenuItem6"
        '
        'MenuItem48
        '
        Me.MenuItem48.BackColor = System.Drawing.Color.White
        Me.MenuItem48.CheckedImageIndex = 0
        Me.MenuItem48.CheckedMenuItemBackColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.CheckedMenuItemBorderColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.CheckedMenuItemDisabledBackColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(194, Byte), CType(184, Byte))
        Me.MenuItem48.CheckedMenuItemIconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem48.CheckedMenuItemStyle = UltimateMenus.KunalMenuItem.CheckedMenuStyles.CheckedItemDefault
        Me.MenuItem48.CheckedMenuItemTickMarkColor = System.Drawing.SystemColors.Control
        Me.MenuItem48.FillMenuBarItem = False
        Me.MenuItem48.HighLightFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuItem48.HighLightForeColor = System.Drawing.Color.Black
        Me.MenuItem48.HighLightScheme = UltimateMenus.KunalMenuItem.HighLightColorDrawStyle.CustomGradient
        Me.MenuItem48.HiliteBorderColor = System.Drawing.Color.Green
        Me.MenuItem48.HiliteGradientColor1 = System.Drawing.Color.YellowGreen
        Me.MenuItem48.HiliteGradientColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.MenuItem48.HiLiteGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem48.IconShadowColor = System.Drawing.Color.Gray
        Me.MenuItem48.ImageIndex = 0
        Me.MenuItem48.Index = 8
        Me.MenuItem48.MakeCheckedMenuItemIconTransparent = False
        Me.MenuItem48.MakeTransparentIcon = False
        Me.MenuItem48.MenuBarItemBorderColor = System.Drawing.Color.Black
        Me.MenuItem48.MenuBarItemFillColor = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemFillingStyle = UltimateMenus.KunalMenuItem.MenuBarFillStyles.FillColor
        Me.MenuItem48.MenuBarItemGradientColor1 = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemGradientColor2 = System.Drawing.SystemColors.Menu
        Me.MenuItem48.MenuBarItemGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem48.OwnerDraw = True
        Me.MenuItem48.PreDefinedHiLiteColors = UltimateMenus.KunalMenuItem.PreDefinedHighLightColors.Khaki
        Me.MenuItem48.PreDefinedHiLiteGradientColors = UltimateMenus.KunalMenuItem.PreDefinedGrHighLightColors.BrownWhite
        Me.MenuItem48.PreDefinedSideBarGradientColour = UltimateMenus.KunalMenuItem.PreDefinedSideBarGradientColors.ShineyBlueYellow
        Me.MenuItem48.ShowBorderAroundMenuBar = False
        Me.MenuItem48.ShowHiliteOverSideBar = False
        Me.MenuItem48.ShowShadowUnderMenuBar = True
        Me.MenuItem48.SideBarEndColor = System.Drawing.Color.Wheat
        Me.MenuItem48.SideBarGradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.MenuItem48.SideBarStartColor = System.Drawing.Color.MediumOrchid
        Me.MenuItem48.SideBarStyle = UltimateMenus.KunalMenuItem.SideBarDrawStyle.CustomGradient
        Me.MenuItem48.Text = "MenuItem7"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 161)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UltimateMenus - By KUNAL MUKHERJEE"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UltimateMenus.KunalMenuItem()
        Dim m As UltimateMenus.KunalMenuItem

    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        MsgBox("")
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click

    End Sub
End Class
