Copyright 1999 Taiji Software
All Rights Reserved
http://www.chez.com/taiji99
taijisoftware@hotmail.com

*******************************************************************
                      Applet Pack version 1.9.0
*******************************************************************

I)    NEW FEATURES
II)   WHAT ARE APPLETS ?
III)  USER MODE
IV)   LICENCE
V)    UPGRADES AND BUGS REPORT
VI)   FAQ


===================================================================
I)                       NEW FEATURES
===================================================================

--> In 1.9.0 :
  *) 8 new applets.

--> In 1.6.0 :
  *) 4 new applets: GuestBook, LoginBox, Navigation, WhoIsVisitor.
  *) In ButtonLink, CheckBoxLink, RandomLink and ListLink the URLs
     can now be relative (for example: '/links/links.html').

--> In 1.2.2 :
  *) A new applet: StatusBarScroller, which scrolls a choosen text 
     in the status bar.
  *) No more window in the limited version, but applets can work
     only off-line.

--> In 1.1.2 :
  *) StarsText and StarsText2 can now display a scrollbar which let
     user set the speed animation (usefull because computer speed  
     is often different on different computers)


===================================================================
II)                       WHAT ARE APPLETS ?
===================================================================

Applets are composants you add to your web pages. Because they are
written in a programmation language they are more powerful than 
scripts like Visual Basic Script or Java Script. Applets are written
in Java, an universal language which allow you to use applets on any
web browser that includes a java interpreter. It's the case for most
of the actual browsers (like Internet Explorer, Netscape Navigator...)
With Java Programming Security is maximum. Indeed applets can't read
or write on your hard disk or on the web server it stays. Applets can
only read images and sounds.


====================================================================
III)                          USER MODE        
====================================================================

First of all if you have never seen a java applet in your web browser
Java may be inactivated : you can set it in "internet options" or
"preferences".

When you want to add to your web page an applet of this pack, go to 
the corresponding directory and :
  - if you write html : copy the html fragment including the applet, 
    that is to say the text between the balises <applet and </applet>
  - if you use a html editor like FrontPage : load the html file 
    including the applet you want and copy the applet directly on the
    page and paste it on your page.
Next copy the .class file(s) in the same directory as the html file.
Then adjust the requiered parameters.


For each applet there is a text file which describes the parameters
and the defaults values (default value is used when you put a parameter)
When there is no default, you are obliged to set a value.  

Most of these applets have an other version : an in live configurable
version, including a window with scrollbars. Once you have tested the 
applet and chosen the parameters values, copy or insert them in the
html tag.

Note : don't include too much applets on one page because your site will
become slow on old computers.

For most of the applets you can can choose an image as background. You
can also choose a color. This color must be input in hexadecimal format
This format is used in HTML to describe colors. So if you want to set
the background color the same as the color page, look at the HTML and
find the balise <body bgcolor="#00FFFF"> "#00ffff" is the color number.
For example red is "#ff0000", blue is "#0000ff" ...
To get the hexadecimal number of a color, use the "HexColor" applet in
HexColor directory. 

In this applet you can use JPG and GIF images (even animated gif 
sometimes the animation flickers, depending on the type of animation)
When the images used are not in the same directory as the html file,
put the relative path, for instance : "images/name.jpg", where "images" 
is the directory including "name.jpg". 


=====================================================================
IV)                            LICENCE
=====================================================================

The Applet Pack is a shareware.
The unregistered version is for trial use only. 
Applets in a unregistered Applet Pack can only work off line.
When you register you get a password which you put as a parameter in
the html files. By doing this there is no more window and you can get
for free all the future versions of the Applet Pack (password is the
same).
If you have a full version, you don't need to register and you have
the password. To have a full version, register on line at :
http://www.chez.com/taiji99/register/register.htm


=====================================================================
V)                    UPGRADES AND BUGS REPORTS
=====================================================================

Check for upgrades at : http://www.chez.com/taiji99

Please report bugs at : taijisoftware@hotmail.com


=====================================================================
VI)                              FAQ
=====================================================================

Q) Why doesn't any applet running ?



Q) Why doesn't any applet running ?
A) -Check that java is enable on your browser (see in 'internet options'
    or 'preferences' section)
   -Check that your browser version is 4.x or higher