// main scratchr javascript file
var pdesc_value = null;
var MAX_PDESC_LENGTH = 50;

function el(ID)
{
	return document.getElementById(ID);
}


function initScratchPlayer() {
	if (javadetect())
		show($('projectload'));
	else
	{
	        hide($('projectload'));
		show($('downloadjava'));	
	}
}


function initProjectNotes() {
    var pdesc = document.getElementById("pdesc");
    var toggleNotes = document.getElementById("toggleNotes");
    if(pdesc_value==null)
    {
	pdesc_value = pdesc.innerHTML;
    }
    if(pdesc.innerHTML.length>MAX_PDESC_LENGTH)
    {
	pdesc.innerHTML = pdesc.innerHTML.substr(0, MAX_PDESC_LENGTH)+"...";
	toggleNotes.innerHTML="more &raquo;&raquo;";
    }
    else
    {
	toggleNotes.innerHTML="";
    }
}


function toggleProjectNotes() {
    var pdesc = document.getElementById("pdesc");
    var toggleNotes = document.getElementById("toggleNotes");
    if(pdesc.innerHTML!=pdesc_value)
    {
	pdesc.innerHTML = pdesc_value;
	toggleNotes.innerHTML="&laquo;&laquo; less";
    }
    else
    {
	if(pdesc.innerHTML.length>MAX_PDESC_LENGTH)
	{
	    pdesc.innerHTML = pdesc.innerHTML.substr(0, MAX_PDESC_LENGTH)+"...";
	    toggleNotes.innerHTML="more &raquo;&raquo;";
	}
    }
}

function activateElementScroll(element) {
	$(element).style.overflow="auto";
}

function deactivateElementScroll(element) {
	$(element).style.overflow="hidden";
}

function showProject(url) {
	new Ajax.Updater(
		"projectwrapper", 
		url+'/load', 
		{onComplete:function(){ hide($('downloadjava')); show($('projectload'));},
		asynchronous:true});
}


/* depends on prototype library; onclick=showThemeOld(mouse_event, element_id) */
function showThemesOld(event, position_element_id) {
	new Ajax.Updater(
		'themebox', 
		'/galleries/submitprojects', 
		{onComplete:function(){ 
			showThemeBox(event, position_element_id);
			//new Effect.Highlight('themebox');
			},
		asynchronous:true});
}


function setCookie(name,value,days) {
	if (days) 
	{
		var date = new Date();
		date.setTime(date.getTime()+(days*24*3600000));
		var expires = "; expires="+date.toGMTString();
	}
	else 
		var expires = "";
	document.cookie = name+"="+value+expires+"; path=/";
}


function readCookie(name) {
	var prefix = name + "=";
	var ca = document.cookie.split(';');
	for(var i=0;i < ca.length;i++) 
	{
		var c = ca[i];
		while (c.charAt(0)==' ') 
			c = c.substring(1,c.length);
		if (c.indexOf(prefix) == 0) 
			return c.substring(prefix.length,c.length);
	}
	return null;
}


// deletes all cookies with substr as a prefix
function deleteCoookiesWithPrefix(substr) {
	var prefix = substr;
	var eq = "=";
	var ca = document.cookie.split(';');
	for(var i=0;i < ca.length;i++) 
	{
		var c = ca[i];
		while (c.charAt(0)==' ') c = c.substring(1,c.length);
		if (c.indexOf(prefix) == 0)
		{ 
			
			deleteCookie(c.substring(0, c.indexOf(eq)));
		}
	}
}


/* Todo: should be called from <body onload> to delete relevant cookies */
function removeProjectSelections() {
	deleteCoookiesWithPrefix('scratchr_projectselections');
}


function deleteCookie(name) {
	setCookie(name,"",-1);
}


function selectProject(pid) {
	setCookie('scratchr_projectselections_'+pid, 1, 1);
}


function deselectProject(pid) {
	deleteCookie('scratchr_projectselections_'+pid);
} 

function toggleProjectSelection(pid) {
	var cookiename = 'scratchr_projectselections_'+pid;
	if (readCookie(cookiename))
	{
		deleteCookie(cookiename);
	}
	else
	{
		setCookie(cookiename, 1, 1);
	}
}


function toggle(element) {
	if (element.style.display == 'block')
		element.style.display == 'none';
	else
		element.style.display == 'block';
	return false;
}


function toggleMore(id,el){
	var d=document,o=(d.all)?d.all[id]:d.getElementById(id);
	if(!o.i)o.i=0;
	o.style.display=(o.i++%2)?'none':'block';
	el.innerHTML=(o.i%2)?'See less':'See more';
	return false;
}
	
	
function hide(element) {
	element.style.display = 'none';
}


function show(element) {
	element.style.display = 'block';
}


function findPos(obj) {
	var curleft = curtop = 0;
	if (obj.id) {
		curleft = obj.offsetLeft
		curtop = obj.offsetTop
		while (obj = obj.offsetParent) {
			curleft += obj.offsetLeft
			curtop += obj.offsetTop
		}
	}
	return [curleft,curtop];
}


function toggleActive(ID, ActionFormName) {
	var inputID = ActionFormName+'_'+ID;
	var actionForm = document.getElementById(ActionFormName);
	if (actionForm) {
		if (actionInput = document.getElementById(inputID)) {
			actionForm.removeChild(actionInput);
			
		} else {
			var newInput = document.createElement('input');
			newInput.setAttribute('id',inputID);
			newInput.setAttribute('name', inputID);
			newInput.setAttribute('value', inputID);
			newInput.setAttribute('type', 'hidden');
			actionForm.appendChild(newInput);
		}
	}
}


function populateUserList()
{
	var autoQuery = el('auto_query');
	var queryStr = autoQuery.value.toLowerCase().replace(/^\s+/,"");
	var userList = el('userlist');	
	var regex = new RegExp("^"+queryStr,"i");
	var len = userList.childNodes.length;
		
	for(var i=0;i<len;i++)
	{
		var user = userList.childNodes[i];
		if (!user) continue;
		
		var name = user.getAttribute('name');
		user.style.display = '';
		
		if (regex.exec(name))
		{
			user.style.display = '';
		}
		else
		{
			user.style.display = 'none';
		}
		
	}
}


function addPendingInvite(obj,parent) 
{ 
	var userlist = el('userlist');
	var inviteList = el('invitelist');
	
	var uid = obj.getAttribute('uid');
	var username = obj.getAttribute('uname');
	
	var uimg_id = "uimg_"+uid;
	var uimg_src = el(uimg_id).src;	
	
	userlist.removeChild(parent);
	
	var li = document.createElement("li");
	li.id = "puid_"+uid;
	li.innerHTML='<input type="hidden" name="'+uid+'"><a href="/users/'+username+'"><img id="puimg_'+uid+'" src="'+uimg_src+'" width="28" height="28">'+username+'</a>&nbsp;<a uid="'+uid+'" uname="'+username+'" href="#"  onclick="removePendingInvite(this, el(\'puid_'+uid+'\')); return false;">(x)</a></li>';
	inviteList.insertBefore(li, inviteList.firstChild);
} 


function removePendingInvite(obj,parent) 
{ 
	var uid = obj.getAttribute('uid');
	var uname = obj.getAttribute('uname');
	 
	insertIntoUserList(uid,uname); 
	
	var invitelist = el('invitelist'); 	
	invitelist.removeChild(parent); 
} 


function insertIntoUserList(uid,uname) 
{ 
	var userlist = el('userlist');	
	var uimg_id = "puimg_"+uid;
	var uimg_src = el(uimg_id).src;	
	var li = document.createElement('li');
	li.id = "uid_"+uid;
	li.name = uname;
	li.setAttribute('name',uname); 
	li.innerHTML='<input uid="'+uid+'" uname="'+uname+'" type="checkbox" onclick="addPendingInvite(this, el(\'uid_'+uid+'\'))"><a href="/users/'+uname+'"><img id="uimg_'+uid+'" src="'+uimg_src+'" width="28" height="28">'+uname+'</a></li>';
	userlist.insertBefore(li, userlist.firstChild);
}

//the div which contains the login form
var logincontainer=document.getElementById("logincontainer");
var toggled=false;

function showLogin(){
if(toggled==false){//is the login form not showing?
	//safari is picky here. The 'appear' effect doesn't work unless you set the final opacity to less than 1. 
	Effect.Appear('logincontainer',{duration:.4,from: 0.0001, to: 0.9999});
	//focus() doesn't work when the field is hidden, so we set a delay of .3 s
	setTimeout('document.getElementById("UserInput").focus()',300);
	toggled=true;
}
else{
	//For some reason, Effect.toggle doesn't work when opacity is not 1
	Effect.Fade('logincontainer',{duration:.4,from: 0.9999,to: 0});
	toggled=false;
}
return false;
}


function hideAnnouncement(){
	//For some reason, Effect.toggle doesn't work when opacity is not 1
	Effect.Fade('announcement',{duration:.4,from: 0.9999,to: 0});
	toggled=false;
	setCookie('announcement','hide',15);
	return false;
}


function updateNotificationsCounter() {
    var notificationscount=document.getElementById("notificationscount");
    var notificationcontainer=document.getElementById("notificationcontainer");
	var notify_count = parseInt(notificationscount.innerHTML);
	notify_count = notify_count - 1;
    if(notify_count==0)
    {
        notificationcontainer.style.display = "none";
    } else {
		notificationscount.innerHTML = notify_count.toString() + " messages";
	}
    return true;
}

function tagsubmit_ajax(keyStroke)
{
   var keyCode = (document.layers) ? keyStroke.which : event.keyCode;
   if(keyCode == 13) // enter key
   {
       var tag_submit = document.getElementById("tag_submit");
       tag_submit.click();
       return false;
   }
   return true;
}

function incrementNewShariableCount() {
    var newShariableCount=document.getElementById("newShariableCount");
    var newShariableLink=document.getElementById("newShariableLink");
    if(newShariableCount!=null)
    {
	if(newShariableCount.innerHTML==0)
	    newShariableLink.style.display='block';
	newShariableCount.innerHTML++;
    }
    return true;
}
