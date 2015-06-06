var lastID;

function findPosX(obj)
{
	var curleft = 0;
	if (obj.offsetParent)
	{
		while (obj.offsetParent)
		{
			curleft += obj.offsetLeft
			obj = obj.offsetParent;
		}
	}
	else if (obj.x)
		curleft += obj.x;
	return curleft;
}

function findPosY(obj)
{
	var curtop = 0;
	if (obj.offsetParent)
	{
		while (obj.offsetParent)
		{
			curtop += obj.offsetTop
			obj = obj.offsetParent;
		}
	}
	else if (obj.y)
		curtop += obj.y;
	return curtop;
}

function closeMenuOpt (menuobj)
{
	if (menuobj != null) {
	    mouseX = window.event.clientX + document.body.scrollLeft;
	    mouseY = window.event.clientY + document.body.scrollTop;
		
		x1 = findPosX(menuobj) + 1;
		x2 = x1 + menuobj.childNodes[1].firstChild.clientWidth - 1;
		y1 = findPosY(menuobj) + menuobj.offsetHeight;
		y2 = y1 + menuobj.childNodes[1].lastChild.offsetTop + menuobj.childNodes[1].lastChild.offsetHeight - 1;
			
		if (mouseX <= x1 || mouseX >= x2 || mouseY <= y1 || mouseY >= y2) {
			setTimeout (menuobj.className=menuobj.className.replace(" over", ""), 80);
		}		
	}
}

function closeMenuOpt_Sub (menuobj)
{
	    mouseX = window.event.clientX + document.body.scrollLeft;
	    mouseY = window.event.clientY + document.body.scrollTop;
		
		x1 = findPosX(menuobj);
		x2 = x1 + menuobj.clientWidth;
		y1 = findPosY(menuobj);
		y2 = y1 + menuobj.offsetHeight;
			
		if (mouseX <= x1 || mouseX >= x2 || mouseY <= y1 || mouseY >= y2) {
			setTimeout (menuobj.className=menuobj.className.replace(" over", ""), 10);
		}		
}


startList = function()
{
	lastID = "";
	
	if (document.all&&document.getElementById) 
	{
		navRoot = document.getElementById("lw_menu");
		for (i=0; i<navRoot.childNodes.length; i++) 
		{
			node = navRoot.childNodes[i];
			if (node.nodeName=="LI") 
			{
				node.onmouseover=function() 
				{
					lastID = this.id;
					if (this.className.indexOf(" over") == -1) {
						this.className+=" over";
					}
				}
			 	node.onmouseout=function() 
			 	{
					setTimeout (closeMenuOpt(this), 120);
				}
				if (node.childNodes.length > 1)
				{
					for (j = 0; j < node.childNodes[1].childNodes.length; j++)
					{
						subnode = node.childNodes[1].childNodes[j];
						if (subnode.nodeName=="LI") 
						{
							subnode.onmouseover=function() 
							{
								if (this.className.indexOf(" over") == -1) {
									this.className+=" over";
								}
							}
						 	subnode.onmouseout=function() 
						 	{
								setTimeout (closeMenuOpt_Sub (this), 50);
							}
						}
					}
				}
			}
		}
	}
}

// addLoadEvent( startList );

