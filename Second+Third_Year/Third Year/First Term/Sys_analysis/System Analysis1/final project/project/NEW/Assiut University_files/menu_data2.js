fixMozillaZIndex=true; //Fixes Z-Index problem  with Mozilla browsers but causes odd scrolling problem, toggle to see if it helps
_menuCloseDelay=500;
_menuOpenDelay=150;
_subOffsetTop=2;
_subOffsetLeft=-2;

with(menuStyle=new mm_style()){
bordercolor="#999999";
borderstyle="ridge";
borderwidth=1;
fontfamily="Verdana, Tahoma, Arial";
fontsize="14px";
fontstyle="bold";
headerbgcolor="#ffffff";
headercolor="#B6B6B6";
offbgcolor="#eeeeee";
offcolor="#000000";
onbgcolor="#02742D";
oncolor="#ffffff";
outfilter="randomdissolve(duration=0.3)";
overfilter="Fade(duration=0.2);Alpha(opacity=90);Shadow(color=#777777', Direction=135, Strength=5)";
padding=5;
pagebgcolor="#DD6900";
pagecolor="#ffffff";
separatorcolor="#999999";
separatorsize=1;
subimage="arrow.gif";
subimagepadding=2;
}

with(milonic=new menuname("Main Menu")){
alwaysvisible=1;
left=0;

style=menuStyle;
top=243;


aI("status=About University;text=About University;url=http://www.aun.edu.eg/asu.htm;");
aI("status=About Assiut;text=About Assiut;url=http://www.aun.edu.eg/assiut.htm;");
aI("status=Administration;text=Administration;url=http://www.aun.edu.eg/adm.htm;");
aI("status=Youth Week;text=Youth Week;url=http://www.aun.edu.eg/week/index.htm;");
aI("showmenu=Partners2;text=Faculities;");
aI("showmenu=Partners3;text=Institutes;");
aI("showmenu=Partners4;text=Academic;");
aI("status=Special Unites;text=Special Unites;url=http://www.aun.edu.eg/university_center.htm;");
aI("status=Statistics;text=Statistics;url=http://www.aun.edu.eg/stat.htm;");
aI("status=Conferences;text=Conferences;url=http://www.aun.edu.eg/conf.htm;");
aI("status=Projects;text=Projects;url=http://www.aun.edu.eg/project.htm;");
aI("status=Inventions;text=Inventions;url=http://www.aun.edu.eg/inventions.htm;");
aI("status=University Council;text=University Council;url=http://www.aun.edu.eg/unicoun.htm;");
aI("status=Favorites;text=Favorites;url=http://www.aun.edu.eg/favorites.htm;");
aI("status=Journals;text=Journals;url=http://www.aun.edu.eg/jornals.htm;");
aI("status=Tinders;text=Tinders;url=http://www.aun.edu.eg/tender/tend.htm;");
}

with(milonic=new menuname("Samples2")){
overflow="scroll";
style=menuStyle;
aI("text=Plain Text Horizontal Style DHTML Menu Bar;url=http://www.milonic.com/menusample1.php;")
aI("text=Vertical Plain Text Menu;url=http://www.milonic.com/menusample2.php;")
aI("text=All Horizontal Menus;url=http://www.milonic.com/menusample25.php;")
aI("text=Using The Popup Menu Function Positioned by Images;url=http://www.milonic.com/menusample24.php;")
aI("text=Classic XP Style Menu;url=http://www.milonic.com/menusample82.php;")
aI("text=XP Style;url=http://www.milonic.com/menusample86.php;")
aI("text=XP Taskbar Style Menu;url=http://www.milonic.com/menusample83.php;")
aI("text=Office XP Style Menu;url=http://www.milonic.com/menusample47.php;")
aI("text=Office 2003 Style Menu;url=http://www.milonic.com/menusample46.php;")
aI("text=Apple Mac Style Menu;url=http://www.milonic.com/menusample72.php;")
aI("text=Amazon Style Tab Menu;url=http://www.milonic.com/menusample74.php;")
aI("text=Milonic Home Menu;url=http://www.milonic.com/menusample78.php;")
aI("text=Windows 98 Style Menu;url=http://www.milonic.com/menusample13.php;")
aI("text=Multiple Styles Menu;url=http://www.milonic.com/menusample5.php;")
aI("text=Multi Colored Menu Items;url=http://www.milonic.com/menusample80.php;")
aI("text=Multi Colored Menus Using Styles;url=http://www.milonic.com/menusample7.php;")
aI("text=Multi Tab;url=http://www.milonic.com/menusample50.php;")
aI("text=Tab Top;url=http://www.milonic.com/menusample52.php;")
aI("text=Multi Columns;url=http://www.milonic.com/menusample73.php;")
aI("text=100% Width Span Menu;url=http://www.milonic.com/menusample26.php;")
aI("text=Follow Scrolling Style Menu;url=http://www.milonic.com/menusample10.php;")
aI("text=Menu Positioning With Offsets;url=http://www.milonic.com/menusample23.php;")
aI("text=Table Based (Relative) Menus;url=http://www.milonic.com/menusample9.php;")
aI("text=Opening Windows and Frames with the Menu;url=http://www.milonic.com/menusample11.php;")
aI("text=Menus Over Form Selects, Flash and Java Applets;url=http://www.milonic.com/menusample14.php;")
aI("text=Activating Functions on Mouseover;url=http://www.milonic.com/menusample15.php;")
aI("text=Drag Drop Menus;url=http://www.milonic.com/menusample22.php;")
aI("text=Menus with Header Type Items;url=http://www.milonic.com/menusample8.php;")
aI("text=Right To Left Openstyle;url=http://www.milonic.com/menusample65.php;")
aI("text=Up Openstyle Featuring Headers;url=http://www.milonic.com/menusample33.php;")
aI("text=DHTML Menus and Tooltips;url=http://www.milonic.com/menusample6.php;")
aI("text=Unlimited Level Menus Example;url=http://www.milonic.com/menusample67.php;")
aI("text=Context Right Click Menu;url=http://www.milonic.com/menusample27.php;")
aI("text=Menus built entirely from images;url=http://www.milonic.com/menusample18.php;")
aI("text=Static Images Sample;url=http://www.milonic.com/menusample16.php;")
aI("text=Rollover Swap Images Sample;url=http://www.milonic.com/menusample17.php;")
aI("text=Background Item Images;url=http://www.milonic.com/menusample20.php;")
aI("text=Background Image Buttons;url=http://www.milonic.com/menusample89.php;")
aI("text=Menu Background Images;url=http://www.milonic.com/menusample76.php;")
aI("text=Creating Texture with Menu Background Images;url=http://www.milonic.com/menusample19.php;")
aI("text=Static Background Item Images;url=http://www.milonic.com/menusample71.php;")
aI("text=Vertical Static Background Item Images;url=http://www.milonic.com/menusample87.php;")
aI("text=World Map Sample;url=http://www.milonic.com/menusample92.php;")
aI("text=US Map Sample;url=http://www.milonic.com/menusample91.php;")
aI("text=Image Map Sample;url=http://www.milonic.com/menusample4.php;")
aI("text=Rounded Edges Imperial Style;url=http://www.milonic.com/menusample21.php;")
aI("text=Corporation;url=http://www.milonic.com/menusample40.php;")
aI("text=International;url=http://www.milonic.com/menusample70.php;")
aI("text=Clean;url=http://www.milonic.com/menusample32.php;")
aI("text=3D Gradient Block;url=http://www.milonic.com/menusample57.php;")
aI("text=Descreet;url=http://www.milonic.com/menusample42.php;")
aI("text=Agriculture;url=http://www.milonic.com/menusample41.php;")
aI("text=Breeze;url=http://www.milonic.com/menusample29.php;")
aI("text=Chart;url=http://www.milonic.com/menusample66.php;")
aI("text=Cartoon;url=http://www.milonic.com/menusample77.php;")
aI("text=Start Button Menu;url=http://www.milonic.com/menusample69.php;")
aI("text=Tramline;url=http://www.milonic.com/menusample54.php;")

}

with(milonic=new menuname("Milonic2")){
style=menuStyle;
aI("text=Product Purchasing Page;url=http://www.milonic.com/cbuy.php;");
aI("text=Contact Us;url=http://www.milonic.com/contactus.php;");
aI("text=Newsletter Subscription;url=http://www.milonic.com/newsletter.php;");
aI("text=FAQ;url=http://www.milonic.com/menufaq.php;");
aI("text=Discussion Forum;url=http://www.milonic.com/forum/;");
aI("text=Software License Agreement;url=http://www.milonic.com/license.php;");
aI("text=Privacy Policy;url=http://www.milonic.com/privacy.php;");
}

with(milonic=new menuname("Partners2")){
style=menuStyle;
aI("status=Agriculture;text=Agriculture;url=http://www.aun.edu.eg/fac_agr/index.htm;");
aI("status=Arts;text=Arts;url=http://www.aun.edu.eg/fac_art/arts.htm;");
aI("status=Commerce;text=Commerce;url=http://www.aun.edu.eg/fac_com/com.html;");
aI("status=Computers and Information;text=Computers and Information;url=http://www.aun.edu.eg/fac_compsci/index.htm;");
aI("status=Education;text=Education;url=http://www.aun.edu.eg/fac_edu/index.htm;");
aI("status=Education (New Valley);text=Education (New Valley);url=http://www.aun.edu.eg/fac_wadi/index.htm;");
aI("status=Engineering;text=Engineering;url=http://www.aun.edu.eg/fac_eng/eng/index.htm;");
aI("status=Law;text=Law;url=http://www.aun.edu.eg/fac_law/index.htm;");
aI("status=Medicine;text=Medicine;url=http://www.aun.edu.eg/fac_med/index.html;");
aI("status=Nursing;text=Nursing;url=http://www.aun.edu.eg/fac_nurs/enursing/index.html;");
aI("status=Pharmacy;text=Pharmacy;url=http://www.aun.edu.eg/fac_pharm/ph.html;");
aI("status=Physical Education;text=Physical Education;url=http://www.aun.edu.eg/fac_physical_edu/index.htm;");
aI("status=Science;text=Science;url=http://www.aun.edu.eg/fac_sci/index.htm;");
aI("status=Social Work;text=Social Work;url=http://www.aun.edu.eg/fac_soc/index.htm;");
aI("status=Specific Education;text=Specific Education;url=http://www.aun.edu.eg/fac_sedu/edu1.html;");
aI("status=Vet Medicine;text=Vet Medicine;url=http://www.aun.edu.eg/fac_vmed/index.html;");
}
with(milonic=new menuname("Partners3")){
style=menuStyle;
aI("status=South Egypt Cancer;text=South Egypt Cancer;url=http://www.seci.info;");
aI("Sugar Technology Research;text=Sugar Technology Research;url=http://www.aun.edu.eg/suger/myhomepage.html;");

}

with(milonic=new menuname("Partners4")){
style=menuStyle;
aI("status=Degrees Offered;text=Degrees Offered;url=http://www.aun.edu.eg/academic/degrees.htm;");
aI("Admission Requirements;text=Admission Requirements;url=http://www.aun.edu.eg/academic/registration.htm;");
aI("University Fees;text=University Fees;url=http://www.aun.edu.eg/academic/fees.htm;");

}


with(milonic=new menuname("My Milonic2")){
style=menuStyle;
aI("text=On Line Cource;url=http://www.aun.edu.eg/on_line_course.htm;");
aI("text=Distance Education Programs;url=http://www.aun.edu.eg/distans.htm;");
}

drawMenus();

