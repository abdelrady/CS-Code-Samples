
var drawMenu = 
'<div id="navtable" style="background-image:url(http://www.coding4fun.net/images/_site/navtable_bg.jpg);">' +
'<table id="Table_01" height="298" border="0" cellpadding="0" cellspacing="0">' + 
'	<tr>' + 
'		<td colspan="2"><img id="imgLogo" src="http://www.coding4fun.net/images/_site/logo.jpg" style="cursor:pointer" alt="" width="156" height="72" border="0"></td>' +
'		<td colspan="5"><img src="http://www.coding4fun.net/images/_site/04.jpg" width="377" height="72" alt=""></td>' +
'		<td colspan="3"><img id="imgStartHere" src="http://www.coding4fun.net/images/_site/starthere.jpg" style="cursor:pointer" alt="" width="160" height="72" border="0"></td>' +
'		<td colspan="2"><img src="http://www.coding4fun.net/images/_site/06.jpg" width="123" height="72" alt=""></td>' +
'	</tr>' +
'	<tr>' +
'		<td><img src="http://www.coding4fun.net/images/_site/08.jpg" width="47" height="133" alt=""></td>' +
'		<td colspan="2"><img id="imgWindows" src="http://www.coding4fun.net/images/_site/windows_off.jpg" style="cursor:pointer" width="128" height="133" border="0"></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/windows_right.jpg" width="64" height="133" alt=""></td>' +
'		<td><img id="imgWeb" src="http://www.coding4fun.net/images/_site/web_off.jpg" style="cursor:pointer" width="130" height="133" border="0"></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/web_right.jpg" width="66" height="133" alt=""></td>' +
'		<td colspan="2"><img id="imgGaming" src="http://www.coding4fun.net/images/_site/gaming_off.jpg" style="cursor:pointer" width="132" height="133" border="0"></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/gaming_right.jpg" width="64" height="133" alt=""></td>' +
'		<td colspan="2"><img id="imgHardware" src="http://www.coding4fun.net/images/_site/hardware_off.jpg" style="cursor:pointer" width="129" height="133" border="0"></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/hardware_right.jpg" width="56" height="133" alt=""></td>' +
'	</tr>' +
'	<tr>' +
'		<td><img src="http://www.coding4fun.net/images/_site/17.jpg" width="47" height="92" alt=""></td>' +
'		<td colspan="3" valign="top" class="nav_links" style="background-image:url(http://www.coding4fun.net/images/_site/windows_bg.jpg); padding-top:10px;"></td>' +
'		<td colspan="2" valign="top" class="nav_links" style="background-image:url(http://www.coding4fun.net/images/_site/web_bg.jpg); padding-top:10px;"></td>' +
'		<td colspan="3" valign="top" class="nav_links" style="background-image:url(http://www.coding4fun.net/images/_site/gaming_bg.jpg); padding-top:10px;"></td>' +
'		<td colspan="3" valign="top" class="nav_links" style="background-image:url(http://www.coding4fun.net/images/_site/hardware_bg.jpg); padding-top:10px;"></td>' +
'	</tr>' +
'	<tr>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="47" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="109" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="19" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="64" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="130" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="66" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="98" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="34" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="64" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="62" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="67" height="1" alt=""></td>' +
'		<td><img src="http://www.coding4fun.net/images/_site/spacer.gif" width="56" height="1" alt=""></td>' +
'	</tr>' +
'</table>' +
'</div>';

$('menuContainer').innerHTML = drawMenu;

$('imgLogo').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/default.aspx' }; 
$('imgStartHere').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/pages/1994662.aspx' }; 
$('imgWindows').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/archive/tags/windows/default.aspx' }; 
$('imgWeb').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/archive/tags/web/default.aspx' }; 
$('imgGaming').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/archive/tags/gaming/default.aspx' }; 
$('imgHardware').onclick = function() { document.location.href = 'http://blogs.msdn.com/coding4fun/archive/tags/hardware/default.aspx' }; 

$('imgWindows').onmouseover = function() { $('imgWindows').src = 'http://www.coding4fun.net/images/_site/windows_on.jpg' }; 
$('imgWindows').onmouseout = function() { $('imgWindows').src = 'http://www.coding4fun.net/images/_site/windows_off.jpg' }; 

$('imgWeb').onmouseover = function() { $('imgWeb').src = 'http://www.coding4fun.net/images/_site/web_on.jpg' }; 
$('imgWeb').onmouseout = function() { $('imgWeb').src = 'http://www.coding4fun.net/images/_site/web_off.jpg' }; 

$('imgGaming').onmouseover = function() { $('imgGaming').src = 'http://www.coding4fun.net/images/_site/gaming_on.jpg' }; 
$('imgGaming').onmouseout = function() { $('imgGaming').src = 'http://www.coding4fun.net/images/_site/gaming_off.jpg' }; 

$('imgHardware').onmouseover = function() { $('imgHardware').src = 'http://www.coding4fun.net/images/_site/hardware_on.jpg' }; 
$('imgHardware').onmouseout = function() { $('imgHardware').src = 'http://www.coding4fun.net/images/_site/hardware_off.jpg' }; 

Event.observe(window, 'load', function() { 
$('header').ancestors()[1].style.backgroundPosition = "top right";
});

