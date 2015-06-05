Title: SoftwareLock
Description: Hello Again!
Here is my second submission to PSC, and its a complete Software Protection System, to protect
the software you've worked on so hard to develop, from illegal copying or un-authorised use.
In the core of the system is the SoftwareLock Class, which needs to be compiled by a VB.NET compiler 
as a DLL, that done you can use it in any .NET languages to provide protection for your software.
I've also included a sample project (SoftwareLockDemo) which demonstrates how to implement the various
properties and methods SoftwareLock exposes.
The third project included in this package is the Softwarelock Key-genarator application, which
you can use to generate Serial Keys for your customers.
How does SoftwareLock work??? ... Well, you basically supply a codename (AppName property),
and a password for your application, SoftwareLock combines these strings along with your customer's
hard disk serial number and using complicated encryption algorithms from System.Security.Cryptography
namespace, it generates a customer reference for the customer, you have to display this reference
to your customer, the customer then has to contact you and quote the Reference he/she's been given.
Using the reference provided, AppName, Password, and a Hash Algorithm you specified
the SoftwareLok Key-generator generates a unique Serial Key, which you have to give to your customer to
unlock his/her software.
Thus, by supplying your custom appname and password, you protect your software from other SoftwareLock users.
By using your customer's unique Hard disk serial, you protect your software from un-authorised
copying and make it unique to the machine it was initially registered on!
Please note that SoftwareLock uses a logical disk drive's serial number supplied by the operating
system when the disk was formatted, NOT the manufacturer's serial number! 
So if your customer has to format his drive for some reason, you will have to generate a new serial 
key based on the new hdd serial number, or your program won't run.
while developing SoftwareLock I first tried to let it use the Manufacturer's HDD serial no, using
System.Management, and WMI Queries. But later i realized that the the method i was using only
worked on WinXP and Win2000 operating systems. I haven't yet figured out an API approach to the problem.
If you know anything, please share it with me!!!
Thank You. 

This file came from Planet-Source-Code.com...the home millions of lines of source code
You can view comments on this code/and or vote on it at: http://www.Planet-Source-Code.com/vb/scripts/ShowCode.asp?txtCodeId=4676&lngWId=10

The author may have retained certain copyrights to this code...please observe their request and the law by reviewing all copyright conditions at the above URL.
