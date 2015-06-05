var FilterBarPrefix = 'AB';
function menu_FilterbarConfig() {

this.version = "3.21";
this.MenuName = "Filter Bar";

this.BaseHref="";

this.MainHoverClass="AttrBarMainHover";
this.MainClass="AttrBarMain";
this.SubHoverClass="AttrBarSubHover";
this.SubClass="AttrBarSub";
this.ContainerClass="AttrBarCont";

this.MenuCentered="left";
this.MenuVerticalCentered="top";
this.PartOfWindow=0.7;

this.BorderWidthMain=1;
this.BorderWidthSub=2;
this.BorderBtwnMain=3;
this.BorderBtwnSub=2;

this.StartTop=0;
this.StartLeft=0;
this.VerCorrect=1;
this.HorCorrect=0;
this.LeftPaddng=5;
this.RightPadding=5;
this.TopPaddng=1;
this.FirstLineHorizontal=1;
this.TargetLoc="FilterbarPos";

this.BgImgLeftOffset=5;
this.ScaleMenu=0;
this.DistFrmFrameBrdr=0;

this.DissapearDelay=300;
this.UnfoldDelay=200;
this.ChildOverlap=0;
this.ChildVerticalOverlap=0;
this.BuildOnDemand=0;
this.OverFormElements=1;

this.BottomUp=0;
this.MenuWrap=1;
this.RightToLeft=0;
this.UnfoldsOnClick=0;
this.RememberStatus=0;

this.TakeOverBgColor=1;
this.FirstLineFrame="";
this.SecLineFrame="";
this.DocTargetFrame="";
this.MenuFramesVertical=1;
this.MenuUsesFrames=0;

this.MenuSlide="";
this.MenuOpacity=""; //"progid:DXImageTransform.Microsoft.Alpha(opacity=85)";
//this.DropMenuShadow="progid:DXImageTransform.Microsoft.Shadow(color=#999999, direction=135, strength=3)";
//this.MainMenuFilter="progid:DXImageTransform.Microsoft.Shadow(color=#000000, direction=135, strength=1)";

this.BeforeStart = function(){return;};
this.AfterBuild = function(){ OnPrepAttrBar(); return;};
this.BeforeFirstOpen = function(){return;};
this.AfterCloseAll = function(){OnCloseAttrBar(); return;};

this.Arrws=[this.BaseHref+"",,,this.BaseHref+"",,,this.BaseHref+"",,,this.BaseHref+"",,];

// MenuX=new Array("ItemText","Link","background image",number of sub elements,height,width,
// 6  = "className",
// 7  = "hover className",
// 8  = "statustext"
// For rollover images ItemText or background image format is:  "rollover?"+BaseHref+"Image1.jpg?"+BaseHref+"Image2.jpg" 

this.NoOffFirstLineMenus=5;
 
this.Menu1=new Array("<img align=\"absbottom\" src=\"/script/content/images/drop.gif\"> Language","","",22,20,80,"","","");
this.Menu1_1=new Array("<input ver=\"C++\"  name=\"AB_78\" value=\"78\" type=\"checkbox\">C++","javascript:MakeSelect(78,\'C++\');","",0,20,100,"","","");
this.Menu1_2=new Array("<input ver=\"C++/CLI\"  name=\"AB_79\" value=\"79\" type=\"checkbox\">C++/CLI","javascript:MakeSelect(79,\'C++/CLI\');","",0,20,100,"","","");
this.Menu1_3=new Array("<input ver=\"C\"  name=\"AB_80\" value=\"80\" type=\"checkbox\">C","javascript:MakeSelect(80,\'C\');","",0,20,100,"","","");
this.Menu1_4=new Array("<input ver=\"C#\"  name=\"AB_81\" value=\"81\" type=\"checkbox\">C#","javascript:MakeSelect(81,\'C#\');","",0,20,100,"","","");
this.Menu1_5=new Array("<input ver=\"VB\"  name=\"AB_83\" value=\"83\" type=\"checkbox\">VB","javascript:MakeSelect(83,\'VB\');","",0,20,100,"","","");
this.Menu1_6=new Array("<input ver=\"VBScript\"  name=\"AB_86\" value=\"86\" type=\"checkbox\">VBScript","javascript:MakeSelect(86,\'VBScript\');","",0,20,100,"","","");
this.Menu1_7=new Array("<input ver=\"JScript\"  name=\"AB_87\" value=\"87\" type=\"checkbox\">JScript","javascript:MakeSelect(87,\'JScript\');","",0,20,100,"","","");
this.Menu1_8=new Array("<input ver=\"XML\"  name=\"AB_88\" value=\"88\" type=\"checkbox\">XML","javascript:MakeSelect(88,\'XML\');","",0,20,100,"","","");
this.Menu1_9=new Array("<input ver=\"J#\"  name=\"AB_89\" value=\"89\" type=\"checkbox\">J#","javascript:MakeSelect(89,\'J#\');","",0,20,100,"","","");
this.Menu1_10=new Array("<input ver=\"CSS\"  name=\"AB_90\" value=\"90\" type=\"checkbox\">CSS","javascript:MakeSelect(90,\'CSS\');","",0,20,100,"","","");
this.Menu1_11=new Array("<input ver=\"Perl\"  name=\"AB_92\" value=\"92\" type=\"checkbox\">Perl","javascript:MakeSelect(92,\'Perl\');","",0,20,100,"","","");
this.Menu1_12=new Array("<input ver=\"SQL\"  name=\"AB_93\" value=\"93\" type=\"checkbox\">SQL","javascript:MakeSelect(93,\'SQL\');","",0,20,100,"","","");
this.Menu1_13=new Array("<input ver=\"HTML\"  name=\"AB_104\" value=\"104\" type=\"checkbox\">HTML","javascript:MakeSelect(104,\'HTML\');","",0,20,100,"","","");
this.Menu1_14=new Array("<input ver=\"XHTML\"  name=\"AB_121\" value=\"121\" type=\"checkbox\">XHTML","javascript:MakeSelect(121,\'XHTML\');","",0,20,100,"","","");
this.Menu1_15=new Array("<input ver=\"eVC\"  name=\"AB_125\" value=\"125\" type=\"checkbox\">eVC","javascript:MakeSelect(125,\'eVC\');","",0,20,100,"","","");
this.Menu1_16=new Array("<input ver=\"ASM\"  name=\"AB_134\" value=\"134\" type=\"checkbox\">ASM","javascript:MakeSelect(134,\'ASM\');","",0,20,100,"","","");
this.Menu1_17=new Array("<input ver=\"MSIL\"  name=\"AB_135\" value=\"135\" type=\"checkbox\">MSIL","javascript:MakeSelect(135,\'MSIL\');","",0,20,100,"","","");
this.Menu1_18=new Array("<input ver=\"UML\"  name=\"AB_136\" value=\"136\" type=\"checkbox\">UML","javascript:MakeSelect(136,\'UML\');","",0,20,100,"","","");
this.Menu1_19=new Array("<input ver=\"JScript .NET\"  name=\"AB_137\" value=\"137\" type=\"checkbox\">JScript .NET","javascript:MakeSelect(137,\'JScript .NET\');","",0,20,100,"","","");
this.Menu1_20=new Array("<input ver=\"Forth.NET\"  name=\"AB_141\" value=\"141\" type=\"checkbox\">Forth.NET","javascript:MakeSelect(141,\'Forth.NET\');","",0,20,100,"","","");
this.Menu1_21=new Array("<input ver=\"XSLT\"  name=\"AB_146\" value=\"146\" type=\"checkbox\">XSLT","javascript:MakeSelect(146,\'XSLT\');","",0,20,100,"","","");
this.Menu1_22=new Array("<input ver=\"LINQ\"  name=\"AB_151\" value=\"151\" type=\"checkbox\">LINQ","javascript:MakeSelect(151,\'LINQ\');","",0,20,100,"","","");
 
this.Menu2=new Array("<img align=\"absbottom\" src=\"/script/content/images/drop.gif\"> Platform","","",6,20,80,"","","");
this.Menu2_1=new Array("<input ver=\"Windows\"  name=\"AB_94\" value=\"94\" type=\"checkbox\">Windows","javascript:MakeSelect(94,\'Windows\');","",0,20,100,"","","");
this.Menu2_2=new Array("<input ver=\"WinCE\"  name=\"AB_95\" value=\"95\" type=\"checkbox\">WinCE","javascript:MakeSelect(95,\'WinCE\');","",0,20,100,"","","");
this.Menu2_3=new Array("<input ver=\".NET CF\"  name=\"AB_96\" value=\"96\" type=\"checkbox\">.NET CF","javascript:MakeSelect(96,\'.NET CF\');","",0,20,100,"","","");
this.Menu2_4=new Array("<input ver=\".NET\"  name=\"AB_98\" value=\"98\" type=\"checkbox\">.NET","javascript:MakeSelect(98,\'.NET\');","",0,20,100,"","","");
this.Menu2_5=new Array("<input ver=\"Office\"  name=\"AB_149\" value=\"149\" type=\"checkbox\">Office","javascript:MakeSelect(149,\'Office\');","",0,20,100,"","","");
this.Menu2_6=new Array("<input ver=\"XBox\"  name=\"AB_150\" value=\"150\" type=\"checkbox\">XBox","javascript:MakeSelect(150,\'XBox\');","",0,20,100,"","","");
 
this.Menu3=new Array("<img align=\"absbottom\" src=\"/script/content/images/drop.gif\"> Technology","","",27,20,95,"","","");
this.Menu3_1=new Array("<input ver=\"ASP\"  name=\"AB_84\" value=\"84\" type=\"checkbox\">ASP","javascript:MakeSelect(84,\'ASP\');","",0,20,100,"","","");
this.Menu3_2=new Array("<input ver=\"ASP.NET\"  name=\"AB_85\" value=\"85\" type=\"checkbox\">ASP.NET","javascript:MakeSelect(85,\'ASP.NET\');","",0,20,100,"","","");
this.Menu3_3=new Array("<input ver=\"Win32\"  name=\"AB_99\" value=\"99\" type=\"checkbox\">Win32","javascript:MakeSelect(99,\'Win32\');","",0,20,100,"","","");
this.Menu3_4=new Array("<input ver=\"Win64\"  name=\"AB_100\" value=\"100\" type=\"checkbox\">Win64","javascript:MakeSelect(100,\'Win64\');","",0,20,100,"","","");
this.Menu3_5=new Array("<input ver=\"SQL\"  name=\"AB_101\" value=\"101\" type=\"checkbox\">SQL","javascript:MakeSelect(101,\'SQL\');","",0,20,100,"","","");
this.Menu3_6=new Array("<input ver=\"IIS\"  name=\"AB_102\" value=\"102\" type=\"checkbox\">IIS","javascript:MakeSelect(102,\'IIS\');","",0,20,100,"","","");
this.Menu3_7=new Array("<input ver=\"VS\"  name=\"AB_103\" value=\"103\" type=\"checkbox\">VS","javascript:MakeSelect(103,\'VS\');","",0,20,100,"","","");
this.Menu3_8=new Array("<input ver=\"PDA\"  name=\"AB_105\" value=\"105\" type=\"checkbox\">PDA","javascript:MakeSelect(105,\'PDA\');","",0,20,100,"","","");
this.Menu3_9=new Array("<input ver=\"IE\"  name=\"AB_106\" value=\"106\" type=\"checkbox\">IE","javascript:MakeSelect(106,\'IE\');","",0,20,100,"","","");
this.Menu3_10=new Array("<input ver=\"MFC\"  name=\"AB_107\" value=\"107\" type=\"checkbox\">MFC","javascript:MakeSelect(107,\'MFC\');","",0,20,100,"","","");
this.Menu3_11=new Array("<input ver=\"ATL\"  name=\"AB_108\" value=\"108\" type=\"checkbox\">ATL","javascript:MakeSelect(108,\'ATL\');","",0,20,100,"","","");
this.Menu3_12=new Array("<input ver=\"WTL\"  name=\"AB_109\" value=\"109\" type=\"checkbox\">WTL","javascript:MakeSelect(109,\'WTL\');","",0,20,100,"","","");
this.Menu3_13=new Array("<input ver=\"STL\"  name=\"AB_110\" value=\"110\" type=\"checkbox\">STL","javascript:MakeSelect(110,\'STL\');","",0,20,100,"","","");
this.Menu3_14=new Array("<input ver=\"GDI\"  name=\"AB_111\" value=\"111\" type=\"checkbox\">GDI","javascript:MakeSelect(111,\'GDI\');","",0,20,100,"","","");
this.Menu3_15=new Array("<input ver=\"GDI+\"  name=\"AB_112\" value=\"112\" type=\"checkbox\">GDI+","javascript:MakeSelect(112,\'GDI+\');","",0,20,100,"","","");
this.Menu3_16=new Array("<input ver=\"OpenGL\"  name=\"AB_113\" value=\"113\" type=\"checkbox\">OpenGL","javascript:MakeSelect(113,\'OpenGL\');","",0,20,100,"","","");
this.Menu3_17=new Array("<input ver=\"DirectX\"  name=\"AB_114\" value=\"114\" type=\"checkbox\">DirectX","javascript:MakeSelect(114,\'DirectX\');","",0,20,100,"","","");
this.Menu3_18=new Array("<input ver=\"COM\"  name=\"AB_130\" value=\"130\" type=\"checkbox\">COM","javascript:MakeSelect(130,\'COM\');","",0,20,100,"","","");
this.Menu3_19=new Array("<input ver=\"COM+\"  name=\"AB_131\" value=\"131\" type=\"checkbox\">COM+","javascript:MakeSelect(131,\'COM+\');","",0,20,100,"","","");
this.Menu3_20=new Array("<input ver=\"ADO\"  name=\"AB_132\" value=\"132\" type=\"checkbox\">ADO","javascript:MakeSelect(132,\'ADO\');","",0,20,100,"","","");
this.Menu3_21=new Array("<input ver=\"ADO.NET\"  name=\"AB_133\" value=\"133\" type=\"checkbox\">ADO.NET","javascript:MakeSelect(133,\'ADO.NET\');","",0,20,100,"","","");
this.Menu3_22=new Array("<input ver=\"WCF\"  name=\"AB_138\" value=\"138\" type=\"checkbox\">WCF","javascript:MakeSelect(138,\'WCF\');","",0,20,100,"","","");
this.Menu3_23=new Array("<input ver=\"XAML\"  name=\"AB_139\" value=\"139\" type=\"checkbox\">XAML","javascript:MakeSelect(139,\'XAML\');","",0,20,100,"","","");
this.Menu3_24=new Array("<input ver=\"WPF\"  name=\"AB_140\" value=\"140\" type=\"checkbox\">WPF","javascript:MakeSelect(140,\'WPF\');","",0,20,100,"","","");
this.Menu3_25=new Array("<input ver=\"WinForms\"  name=\"AB_144\" value=\"144\" type=\"checkbox\">WinForms","javascript:MakeSelect(144,\'WinForms\');","",0,20,100,"","","");
this.Menu3_26=new Array("<input ver=\"WebForms\"  name=\"AB_145\" value=\"145\" type=\"checkbox\">WebForms","javascript:MakeSelect(145,\'WebForms\');","",0,20,100,"","","");
this.Menu3_27=new Array("<input ver=\"AJAX\"  name=\"AB_147\" value=\"147\" type=\"checkbox\">AJAX","javascript:MakeSelect(147,\'AJAX\');","",0,20,100,"","","");
 
this.Menu4=new Array("<img align=\"absbottom\" src=\"/script/content/images/drop.gif\"> Audience","","",6,20,80,"","","");
this.Menu4_1=new Array("<input ver=\"CEO\"  name=\"AB_115\" value=\"115\" type=\"checkbox\">CEO","javascript:MakeSelect(115,\'CEO\');","",0,20,100,"","","");
this.Menu4_2=new Array("<input ver=\"Arch\"  name=\"AB_116\" value=\"116\" type=\"checkbox\">Arch","javascript:MakeSelect(116,\'Arch\');","",0,20,100,"","","");
this.Menu4_3=new Array("<input ver=\"DB\"  name=\"AB_117\" value=\"117\" type=\"checkbox\">DB","javascript:MakeSelect(117,\'DB\');","",0,20,100,"","","");
this.Menu4_4=new Array("<input ver=\"Dev\"  name=\"AB_118\" value=\"118\" type=\"checkbox\">Dev","javascript:MakeSelect(118,\'Dev\');","",0,20,100,"","","");
this.Menu4_5=new Array("<input ver=\"QA\"  name=\"AB_119\" value=\"119\" type=\"checkbox\">QA","javascript:MakeSelect(119,\'QA\');","",0,20,100,"","","");
this.Menu4_6=new Array("<input ver=\"Design\"  name=\"AB_148\" value=\"148\" type=\"checkbox\">Design","javascript:MakeSelect(148,\'Design\');","",0,20,100,"","","");
 
this.Menu5=new Array("<img align=\"absbottom\" src=\"/script/content/images/drop.gif\"> Skill","","",3,20,45,"","","");
this.Menu5_1=new Array("<input ver=\"Beginner\"  name=\"AB_152\" value=\"152\" type=\"checkbox\">Beginner","javascript:MakeSelect(152,\'Beginner\');","",0,20,100,"","","");
this.Menu5_2=new Array("<input ver=\"Intermediate\"  name=\"AB_153\" value=\"153\" type=\"checkbox\">Intermediate","javascript:MakeSelect(153,\'Intermediate\');","",0,20,100,"","","");
this.Menu5_3=new Array("<input ver=\"Advanced\"  name=\"AB_154\" value=\"154\" type=\"checkbox\">Advanced","javascript:MakeSelect(154,\'Advanced\');","",0,20,100,"","","");

}
