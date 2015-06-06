function detect(URL)
{
	thispage = window.location.href;
	if (thispage.indexOf('://') < 0)
		thispage = "://" + thispage;
	prefix = thispage.substring(0, thispage.lastIndexOf('://'));
	suffix = thispage.substring(thispage.lastIndexOf('://') + 3, thispage.length);
	if (parent.location.href == window.location.href)
		parent.location.href = "/index.htm?" + prefix + "&&&" + suffix;
	if (top.frames.length)
		top.UpdateFolder(URL)
}


function PrintThisPage() 
{ 
	var sOption="toolbar=yes,location=no,directories=yes,menubar=yes,"; 
	sOption+="scrollbars=yes,width=750,height=600,left=100,top=25"; 
	var sWinHTML = document.getElementById("contentstart").innerHTML; 
	var winprint=window.open("","",sOption); 
	winprint.document.open(); 
	winprint.document.write('<html><head><link rel="Stylesheet" href="/style.css" type="text/css"></script><title>'); 
	winprint.document.write(document.title);
	winprint.document.write('</title></head><body><h1>'); 
	winprint.document.write(document.title);
	winprint.document.write('</h1>'); 
	winprint.document.write(sWinHTML);
	winprint.document.write('</body></html>'); 
	winprint.document.close(); 
	winprint.focus(); 
}


function Go(x)
{
	if (x != "-")
	{
		if (x.indexOf("http://") == 0)
			top.location.href = x;
		else
			location.href = x;
	}
}


function OpenClose(sObject)
{
	var oObject = document.all(sObject);
	if (oObject.style.display != 'block')
		oObject.style.display = 'block';
	else
		oObject.style.display = 'none';
}
