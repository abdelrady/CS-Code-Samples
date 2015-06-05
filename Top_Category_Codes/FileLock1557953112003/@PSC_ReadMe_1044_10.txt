Title: FileLock
Description: Simple little console app which locks files by
opening them exclusively and so prevents malicious
applications from deleting/editing them.
Nothing fancy, I just wrote it for myself since
I'm a bit paranoid and afraid of rootkits.
Commands:
secure [physical path to file] - Secures the specified file
unsecure [physical path to file] - Unlocks it for write access
list - Lists all secured files
save - Saves list of secured files. Will be secured automatically
    on restart.
load - Manually loads list of secured files.
exit - Unsecures, saves and quits.
Released under the GPL.
This file came from Planet-Source-Code.com...the home millions of lines of source code
You can view comments on this code/and or vote on it at: http://www.Planet-Source-Code.com/vb/scripts/ShowCode.asp?txtCodeId=1044&lngWId=10

The author may have retained certain copyrights to this code...please observe their request and the law by reviewing all copyright conditions at the above URL.
