March 11, 1999


LAWRENCEVILLE PRESS LIBRARIES

The Lawrenceville Press libraries needed by most of the programs presented in
A Guide to Programming in C++ are stored in the LVP folder on this diskette. In
order for programs to have access to these library files, create a folder named
LVP in the INCLUDE folder of the compiler's root directory. For example, for
Turbo C++ version 4.5, the directory structure would appear like
C:\TCWIN45\INCLUDE\LVP. For Microsoft Visual C++ version 5,the directory
structure would appear like C:\PROGRAM FILES\DEVSTUDIO\VC\INCLUDE\LVP. For
Microsoft Visual C++ version 6,the directory structure would appear like
C:\PROGRAM FILES\MICROSOFT VISUAL STUDIO\VC98\INCLUDE\LVP. Next,
copy the files in the LVP folder on this diskette to the LVP folder created in
your compiler's INCLUDE folder.

IMPORTANT*********************************************************************
The lvp libraries are functionally equivalent to the AP libraries. Therefore,
the lvp libraries are updated when the AP libraries are updated. To insure that
you are using the most up-to-date libraries, please periodically download the
library files from the Lawrenceville Press web site by going to
http://www.lvp.com, clicking on the Download Files button, scrolling to the
bottom of the download files page, and then clicking on the appropriate link.


BORLAND TURBO C++\BORLAND C++ USERS

The programs in the PROGS_TC folder on this diskette correspond to the programs
presented in the text. The programs have been given descriptive names according
to their opening comments.

The programs in Chapter Six that use the college library require the
colleges.txt file. This file is stored in the TEXT folder on this diskette.

Many of the programs in Chapter Nine require text (.txt or .dat) files. These
files are stored in the TEXT folder on this diskette.


MICROSOFT VISUAL C++ 5.0\6.0 USERS

To create a project workspace and run an existing program, such as a program on
this diskette, use the following instructions:
1. Start Microsoft Visual C++.
2. From the File menu, select the New command.
3. Create a new Win32 console application project (Version 6.0 users create an
   empty Win32 console application project).
4. From the Project menu, select the Add To Project command and then the Files
   command.
5. Select the appropriate C++ file.

The programs in Chapter Six that use the college library require the college.txt
file. This file is stored in the TEXT folder on this diskette.

Many of the programs in Chapter Nine require text (.txt or .dat) files. These
files are stored in the TEXT folder on this diskette.

The programs in the PROGS_MC folder on this diskette correspond to the programs
presented in the text. The programs have been given descriptive names according
to their opening comments. Some of the programs have been modified to run under
Microsoft Visual C++. These changes are noted below:

doodle.cpp
Because conio.h does not support gotoxy() and clreol(), the doodle program will
not run in MSV and therefore is not included in the PROGS_MC folder.

sturecs.cpp
Because conio.h does not support getche(), the line of code in main() that reads
char Choice = getche(); in the text has been changed to the lines
char Choice;  cin >> Choice; in the program on diskette.

case3.cpp
The iostream library included with MSV requires a call to unsetf() in order to
change alignment of output, as stated in Appendix B of A Guide to Programming
in C++. Therefore, the line cout.unsetf(ios::left); was added prior to every
line that reads cout.setf(ios::right);. Three of these lines were added to
case3.cpp.

case7.cpp
Because conio.h does not support clrscr(), it was commented out in main().

case8.cpp
The iostream library included with MSV requires a call to unsetf() in order to
change alignment of output, as stated in Appendix B of A Guide to Programming
in C++. Therefore, the line cout.unsetf(ios::left); was added prior to every
line that reads cout.setf(ios::right);. Two of these lines were added to
case8.cpp: one in DisplayCandidateRow() and one in DisplayAll().

case9.cpp
Because conio.h does not support getche(), the two lines of code that read
Choice = getche();  cout << endl; needed to be changed to cin >> Choice;
cin.ignore(80, '\n'); The cin.ignore() function is needed because getline() will
read the end of line character that is still in the stream. Refer to Chapter
Three (p. 3-11). This change was made in ChangeBook() and main().

case10.cpp
Because conio.h does not support getche(), the lines of code above the case
statement that read Choice = getche();  cout << endl; needed to be changed to
cin >> Choice; cin.ignore(80, '\n'); The cin.ignore() function is needed because
getline() will read the end of line character that is still in the stream. Refer
to Chapter Three (p. 3-11.)


TECHNICAL SUPPORT

Lawrenceville Press Technical Support
(561) 451-2051  phone 9 a.m. to 5 p.m. EST
(561) 488-4436  fax 24 hours
cpphelp@lvp.com


