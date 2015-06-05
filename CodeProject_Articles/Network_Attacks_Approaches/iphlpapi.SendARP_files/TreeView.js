var browser = '';
if (browser == ''){
if (navigator.appName.indexOf('Microsoft') != -1)
browser = 'IE'
else browser = 'Other';
}

function showFunction(modName, funcName) {
	if (browser == 'IE')
		location.href="/default.aspx/" + modName + "." + funcName;
	else
		location="/default.aspx/" + modName + "." + funcName;
}

function doSearch() {
	if (browser == 'IE')
		location.href="/search.aspx?search=" + document.all("search").value + "&namespace=" + document.all("NamespaceFilter").value;
	else
		location="/search.aspx?search=" + document.all("search").value + "&namespace=" + document.all("NamespaceFilter").value;
}

function expandModule(e) {
	if (browser == 'IE')
		url = "/GetPagesInModule.aspx?module=" + e.parentElement.children[0].id;
	else
		url = "/GetPagesInModule.aspx?module=" + e.parentNode.childNodes[0].id;
	addLinks(e, url);
}

function addLinks(e, url)
{
	if (browser == 'IE')
	{
		pic = e.parentElement.children[0];
		targ = e.parentElement.children[2];
		len = targ.children.length;
	}
	else
	{
		pic = e.parentNode.childNodes[0];
		targ = e.parentNode.childNodes[2];
		len = targ.childNodes.length;
	}

	if (targ.style.display == "none")
	{
		targ.style.display = "";
		pic.src = "/minus.gif";
	}
	else
	{
		targ.style.display = "none";
		pic.src = "/plus.gif";
	}

	if (len == 0)
	{
		if (browser == 'IE')
		{
			var root, rootNode;
			root = new ActiveXObject("Microsoft.XMLDOM");
			root.async = false;
			if (root.load(url)==true) {
				targ.innerHTML=root.documentElement.xml;
			}
			else {
				targ.innerHTML="Could not load " + url;
			}
		}
		else
		{
			var r = new XMLHttpRequest();
			r.open("GET", url, false);
			r.send(null);
			targ.innerHTML = r.responseText;
		}
	}
}