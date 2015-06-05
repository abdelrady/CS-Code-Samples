// Copyright (c) 2008, The Code Project. All rights reserved.

var objectId, objectTypeId;
var bnoteNode;

//REVIEW: (TT) Might be a good idea to move assumptions about querystring keys and values
//				out of the javascript. In case we change any values in web.config we won't have to
//				change them here as well. They can be passed in through parameters.

function bookmarkMe(objId, objTypeId)
{
	objectId			= objId.toString();
	objectTypeId	= objTypeId.toString();
	LoadBookmarkWaitMessage();
	jx.load("/Script/Bookmarks/Ajax/Add.aspx?obtid="+ objTypeId + "&obid=" + objId + "&bma=addbookmark",
						bookmarkCallback);
	return false;
}
function watchMe(objId, objTypeId)
{
	objectId			= objId.toString();
	objectTypeId	= objTypeId.toString();
	LoadBookmarkWatchWaitMessage();
	jx.load("/Script/Bookmarks/Ajax/Add.aspx?obtid="+ objTypeId + "&obid=" + objId + "&bma=addwatch",
						bookmarkCallback);
	return false;
}

function bookmarkCallback(data)
{
	if(data.length > 0)
	{
		var re = new RegExp("<span id=\"bmResult\">(.+)<\/span>");
		var match = re.exec(data);
		if(match&&match[1]) bnoteNode.innerHTML = match[1];
	}
}

function LoadBookmarkWaitMessage()
{
	LoadWaitMessage("bm_");
}
function LoadBookmarkWatchWaitMessage()
{
	LoadWaitMessage("bmw_");
}
function LoadWaitMessage(idPrefix)
{
	var sel = document.getElementById(idPrefix + objectId + "," + objectTypeId);
	if(sel)
	{
		bnoteNode = sel.nextSibling;
		sel.parentNode.removeChild(sel);
		if(bnoteNode.style.visibility == "hidden")
		{
			bnoteNode.innerHTML = " please wait... ";
			bnoteNode.style.visibility = "visible";
		}
	}
}
