function jsTrim(s) {return s.replace(/(^\s+)|(\s+$)/g, "");}

function Track(trackParm, objLink)
{
    if (objLink.innerText && jsTrim(objLink.innerText))
    {
        // anchor tag, use link text
        LinkText = objLink.innerText;
    }
    else if (objLink.all && objLink.all(0).alt)
    {
        // image, use alt text
        LinkText = objLink.all(0).alt;
    }
         
    var strDomain = document.domain;
    var s = trackParm.split("|");
    var strLinkArea;
    var strLinkId;
    var strPageRegion;
    
    if (trackParm.substring(0,1) == "|")
    {
        strPageRegion = s[1];
        strLinkArea = s[2];
        strLinkId = s[2] + s[3];
    }
    else
    {
            strLinkArea = s[0];
        strLinkId = s[0] + s[1];

    }
    
    if (typeof(LinkText)=="undefined" || !LinkText || LinkText == "")
        LinkText = strLinkId;

    ctUrl = objLink.href + "?LinkId=" + strLinkId + "&LinkArea=" + strLinkArea 

    if (typeof(DCSext)!="undefined") 
    {
            DCSext.wt_strHeadlnLocale = detectedLocale;
            DCSext.wt_strCat=strLinkArea+"|"+detectedLocale;
            DCSext.wt_strUrl = window.location.href.toLowerCase();
            DCSext.wt_strArea = strPageRegion;
    }
        return false; 
}

function CopyCode(elemName)
{
    var obj = document.getElementById(elemName)
    window.clipboardData.setData("Text", obj.innerText);
}



var b = window.navigator.appName;


//	Show the languages list in the it's panel
function DDFilterOn(e)
{   
	try
	{
		//	Change Image
		ChangeDropDownImage(true);
		//	Set Position
		oMTPS_DD_PopUpDiv.style.top = oMTPS_DD_ImgArrow.height;
		
		//	Add Event Handlers
		if(oMTPS_DD_PopUpDiv.style.display != "inline")
		{
			oMTPS_DD_PopUpDiv.style.display = "inline";

            if(document.addEventListener)
            {       //  Commented for # 32609
				    //  document.addEventListener("keydown", HandleEvent, false);
				    document.addEventListener("click", TestForResizableAreaControl, false);
				    window.addEventListener("resize", TestForResizableAreaControl, false);			
            } 
            else
            { 
				    document.attachEvent("onkeydown", HandleEvent, false);
       				document.body.onclick = HideFromClick;	
            } 

		}
		else
		{
			//	oMTPS_DD_PopUpDiv.style.display = "none";
			setTimeout(HideThisMenu, 0);			
		}
		
	}
	catch(err)
	{
		throw err;
	}
	e.cancelBubble = true;
	oMTPS_DD_Div.normalize();
	return;
}

// Handle the enter key for a section of a form, binding it to the provided submit buton 
function HandleEvent(event)
{ 
    var nav = window.Event ? true : false; 
    if (nav) { 
        return NetscapeEventHandler(event); 
    } else { 
        return MicrosoftEventHandler(); 
    } 
} 

function NetscapeEventHandler(e)
{ 
//trap for enter (13), escape (27) and "t" (84)
    if ((e.which == 13 || e.which == 27 || e.which == 84) && e.target.type != 'textarea' && e.target.type != 'submit')
     { 
		setTimeout(HideThisMenu, 0);
		document.removeEventListener("keydown", HandleEvent, false);
		e.cancelBubble = true;
        e.returnValue = false; 
        e.cancel = true; 
        e.preventDefault(); 
    } 
    return; 
} 

function MicrosoftEventHandler() { 
//trap for enter (13), escape (27) and "t" (84)
    if ((event.keyCode == 13 || event.keyCode == 27 || event.keyCode == 84 )&& event.srcElement.type != 'textarea' && event.srcElement.type != 'submit') { 
        event.returnValue = false; 
        event.cancel = true;
    	setTimeout(HideThisMenu, 0);
    	document.detachEvent("onkeydown", HandleEvent, false);
    	event.cancelBubble = true;
    } 
    return; 
}


//	Only used by IE
function HideFromClick(event)
{
	var objClicked = window.event.srcElement;
	var objParent = objClicked.parentNode.parentNode;
	
	if (objParent.id != oMTPS_DD_PopUpDiv.id && objParent.id != oMTPS_DD_Div.id ) 
	{
		setTimeout(HideThisMenu, 0);
		return;
	}
	else
	{
		window.event.cancelBubble = true;
		return;
	}
}

/// FF & NN only
function TestForResizableAreaControl(e)
{
	try
	{
	//	For keydown events
	if (e.type == "keydown")
	{
		//	alert(e.which);
		if (e.which == 84 || e.which == 13)
		{
			setTimeout(HideThisMenu, 0);
			document.removeEventListener("keydown", TestForResizableAreaControl, false);
			e.cancelBubble = true;
			return;
		}
	}
	else if (e.type == "resize")
	{
		setTimeout(HideThisMenu, 0);
		window.removeEventListener("resize", TestForResizableAreaControl, false);
		e.cancelBubble = true;
		return;		
	}
	
	// for mousedown event
		if (e.type == "click")
		{
			if (e.which == 1 || e.which == 32)
			{	
				var eNode = e.target;
				if (eNode.id.length == 0)
				{	//	alert("returning false");
					setTimeout(HideThisMenu, 0);
					document.removeEventListener("click", TestForResizableAreaControl, false);
					return false;
				}
				else
				{
					var pNode = document.getElementById(eNode.id).parentNode.parentNode;
					if (eNode.id != oMTPS_DD_PopUpDiv.id)
					{
						if (pNode.id != oMTPS_DD_PopUpDiv.id)
						{
							setTimeout(HideThisMenu, 0);
							document.removeEventListener("mousedown", TestForResizableAreaControl, false);
						}
					}			
					if (e.target.id == oMTPS_DD_ImgArrow.id)
					{
						setTimeout(HideThisMenu, 0);
						document.removeEventListener("mousedown", TestForResizableAreaControl, false);
					}
					if (e.target.id == oMTPS_DD_PanelLink.id)
					{
						setTimeout(HideThisMenu, 0);
						document.removeEventListener("mousedown", TestForResizableAreaControl, false);
					}
				}
				return;
			}
		}
	}
	catch(err)
	{
		throw err;
	}
}

// Persist Menu long enough for client to click check boxes
function HideThisMenu()
{
	oMTPS_DD_PopUpDiv.style.display = "none";
	oMTPS_DD_ImgArrow.src = ArrowOffPath;
	document.body.onclick = null;
	return;
}

//	Handle Image changes
function ChangeDropDownImage(boolOnOff)
{
	if (boolOnOff == true)
	{
		oMTPS_DD_ImgArrow.src = ArrowOnPath;
	}
	else
	{
		oMTPS_DD_ImgArrow.src = ArrowOffPath;
	}
}
//LanguageFilter for robot and printer devices
function SetLangFilterAll()
{
   FilterLanguageSpecificText("nu");
}
//	Set individual checkbox
function SetLangFilter(CodeSnipID,isExistLangFilter)
{
	try
	{
		if (CodeSnipID != null)
		{
			ToggleLang(CodeSnipID);
			 oServerBool = false;
		}
		SetFilterText(isExistLangFilter);
		SetCodeSnippetLangFilterCookie();	
	}
	catch(err)
	{
		throw err;
	}
	return;
}

//	This method is only for changing the value on the client side
//	The server side code should read the cookie and set the checkbox prior to rendering 
function ToggleLang(strThis)
{
  
	var langArray = "";
	
	try
	{
		langArray = eval(strThis);
	}
	catch(err)
	{
		//	no script variables where written out by the server side code
		return;
	}
	
	try
	{
		
		for (i = 0; i < langArray.length; i++)
		{
			
			var thisCodeSnip = document.getElementById(langArray[i]);
			if(thisCodeSnip==null)
			continue;
   
			if (thisCodeSnip.className == "code")
			{
				thisCodeSnip.className = "codeHide";
				
			}
			else
			{
				thisCodeSnip.className = "code";
				
			}
		}
		if (langArray.length > 0)
		{
		  
		  var thisCodeSnipElement = document.getElementById(langArray[0]);
		  var thisCodeSnipParent = thisCodeSnipElement.parentNode.parentNode.parentNode.id;
		  thisCodeSnipParent += "_h";
		  var obj = document.getElementById(thisCodeSnipParent);
		  if(obj != null)
		  {
		    if (obj.innerHTML.indexOf("minus.gif") > 0)
		    {
		        thisCodeSnipElement.parentNode.parentNode.style.display = "block";
		    }
		    else
		    {
		        thisCodeSnipElement.parentNode.parentNode.style.display = "none";
		    }
		  }
		}		  
	}
	catch(err)
	{
		throw err;
	}
	return;
}


// set filter language test
function SetFilterText(isLangSpecTextExist)
{
	
	var spr = " : ";
	try
	{
		var intSetoMTPS_DD_PanelLinkText = 0;
		var objLastChecked = null;
		var cbxColl = oMTPS_DD_PopUpDiv.getElementsByTagName("input");
		
		for (var i = 0; i < cbxColl.length;i++)
		{
			if (cbxColl[i].checked == true)
			{
				intSetoMTPS_DD_PanelLinkText++;
				objLastChecked = cbxColl[i].value;
			}
		}
		if (intSetoMTPS_DD_PanelLinkText == 0)
		{
			oMTPS_DD_PanelLink.innerHTML = strConstLangFilterText + spr + strConstLangFilterNone;
			if (isLangSpecTextExist)
			FilterLanguageSpecificText("nu");
			
		}
		if (intSetoMTPS_DD_PanelLinkText == 1)
		{
			oMTPS_DD_PanelLink.innerHTML = strConstLangFilterText + spr + objLastChecked;
			if (isLangSpecTextExist)
			{
			  var devLang;
  			
			  switch (objLastChecked)
			  {
			    case "Visual Basic":
			    {
			       devLang = "vb"; break;
			    }
			    case "C#":
			    {
			       devLang = "cs"; break;
			    }
			    case "c#":
			    {
			       devLang = "cs"; break;
			    }
			    case "C++":
			    {
			       devLang = "cpp"; break;
			    }
			    case "c++":
			    {
			       devLang = "cpp"; break;
			    }
			    case "JScript":
			    {
			       devLang = "cs"; break;
			    }
			    case "JSharp":
			    {
			       devLang = "cs"; break;
			    }
			    case "J#":
			    {
			       devLang = "cs"; break;
			    }
			    default:
			    {
			       devLang = "nu"; break;
			    }
			  }
			  FilterLanguageSpecificText(devLang);
			} 
		}
		if (intSetoMTPS_DD_PanelLinkText > 1)
		{
			oMTPS_DD_PanelLink.innerHTML = strConstLangFilterText + spr + strConstLangFilterMulti;
			if (isLangSpecTextExist)
			FilterLanguageSpecificText("nu"); 	
		}
		if (intSetoMTPS_DD_PanelLinkText == oMTPS_DD_PopUpDiv.childNodes.length)
		{
			oMTPS_DD_PanelLink.innerHTML = strConstLangFilterText + spr + strConstLangFilterAll;
			if (isLangSpecTextExist)
			FilterLanguageSpecificText("nu"); 
		}	
		intSetoMTPS_DD_PanelLinkText = 0;
		objLastChecked = null;
	}
	catch(err)
	{
		throw err;
	}
	return;
}

// This function filters the languageSpecific Text from a page with multiple language syntax.
function FilterLanguageSpecificText(devLang)
{
  var oStyle = document.styleSheets["LanguageSpecificTextStyle"]
  if (oStyle != null)
  {
    oStyle.removeRule(0)
    oStyle.addRule("."+devLang, "display:inline", 0)
  }

}



//	This function redraws the selected code snippet controls,
//	based on the state of the check boxes in the drop down,
//	which is read from the cookie on the server side.
function CheckDropDownClientCookie(isExistLangText)
{
	var cbxColl = oMTPS_DD_PopUpDiv.getElementsByTagName("input");
	{
	  for (var i = 0; i < cbxColl.length;i++)
	  {
	    if (cbxColl[i].checked != true)
	    {
		    var tStr = cbxColl[i].getAttribute("arrayValue");
		    SetLangFilter(tStr,isExistLangText);
		  }
	  }
	}
	return;
}

// Set cookie on each event
// Function to set the Toc panel size
// Browser must support cookies and script
// "days" variable declared in ResizableArea Control, line # 156
function SetCodeSnippetLangFilterCookie()
{
    var daysToExpire = 60;
    var cookieDate = new Date();
	cookieDate.setTime(cookieDate.getTime()+(daysToExpire*24*360000));
    expires = "expires=" + cookieDate.toGMTString();
            
	if (window.navigator.cookieEnabled == true)
	{
		var cbxColl = oMTPS_DD_PopUpDiv.getElementsByTagName("input");
	  
		for (i = 0 ; i < cbxColl.length; i ++)
		{
			document.cookie = cbxColl[i].id + "_" + i + "=" + cbxColl[i].checked + "; " + expires;
		}
	}
	return;
}



var _expandCollapseIDPrefix;
var _expandAllText;
var _collapseAllText;
var _plusImgPath;
var _minusImgPath;
var _state; // 0=collapsed, 1=expanded

function EC_Init(ID,expandAllText,collapseAllText,plusImgPath,minusImgPath)
{
  _state = 1;
  _expandCollapseIDPrefix = ID;  
  _expandAllText = expandAllText;
  _collapseAllText = collapseAllText;
  _plusImgPath = plusImgPath;
  _minusImgPath = minusImgPath;

  // Determine initial state
  window.setTimeout(EC_InitState,0);
}

function EC_InitState()
{
  if (typeof(CollapsiblePanels) !== "undefined")
  {
    var count = CollapsiblePanels.length;
    for (var i=0; i<count; i++)
    {
      var ctrl = $find(CollapsiblePanels[i].id+"_x");
      if ( ctrl != null
        && ctrl.get_Collapsed())
      { // If any collapsible area is collapsed, set state to collapsed (i.e. display "Expand All")
          var img = $get(_expandCollapseIDPrefix+"_ECImg");
          var link = $get(_expandCollapseIDPrefix+"_ECLink");
          if ( img != null
            && link != null )
          {
            img.src = _plusImgPath;
            link.innerHTML = _expandAllText;
            _state = 0;
          }
          break;
      }
    }
  }
}

function EC_Click()
{
  var img = $get(_expandCollapseIDPrefix+"_ECImg");
  var link = $get(_expandCollapseIDPrefix+"_ECLink");
  if ( img != null
    && link != null )
  {
    if ( _state == 0 )
    {
      img.src = _minusImgPath;
      link.innerHTML = _collapseAllText;
      _state = 1;
    }
    else
    {
      img.src = _plusImgPath;
      link.innerHTML = _expandAllText;
      _state = 0;
    }
  }
  // Toggle each collapsible panel on this page
  if ( typeof(CollapsiblePanels) !== "undefined" )
  {
    var count = CollapsiblePanels.length;
    for ( var i=0; i<count; i++ )
    {
      var ctrl = $find(CollapsiblePanels[i].id+"_x");
      if ( ctrl != null )
      {
        if ( _state == 0 )
        {
          ctrl.collapsePanel();
        }
        else
        {
          ctrl.expandPanel();
        }
      }
    }
  }
}


if (typeof(Sys) !== "undefined") Sys.Application.notifyScriptLoaded();



function EyeBrowMenuBarSetHeight(TFly){
  var maxHeight = 200;
  var overflow = (TFly.DT.clientHeight > maxHeight);
    TFly.DT.style.height = ((overflow) ? maxHeight : TFly.DT.scrollHeight) + "px";
    TFly.DT.style.width = TFly.DT.scrollWidth + ((overflow) ? 20 :0) + "px";
  if(overflow) TFly.DT.style.overflow="auto"
}





function IsPageRated(objID,labelID, text, flyoutID, btn){
  obj = $get(objID)
  if (obj.Rated)
  { 
    flyout = $get(flyoutID)
    TFly_Popup(flyout,false)
    window.setTimeout(function(){btn.disabled=true}, 100);
    return true;
  }
  else
  {
    label = $get(labelID)
    
    if(label.timer){
      window.clearTimeout(label.timer)
    }else{
      label.className_ = label.className;
      label.innerHTML_ = label.innerHTML;
      label.className = 'WarningMessage';
      label.innerHTML = text;
    }

    label.timer = window.setTimeout(function(){
                            label.className = label.className_;
                            label.innerHTML = label.innerHTML_;
                            label.timer=null;
                         }
                      ,3000);
  }  
  return false;
}

function tbNavParent(navUrl)
{
    window.top.location.href = navUrl;
}
function RegisterAutoSubmit( objName, btnName,tag){
  window.onbeforeunload_autosubmit = window.onbeforeunload;
  window.onbeforeunload = function(){
                                 if(window.onbeforeunload_autosubmit)
                                    window.onbeforeunload_autosubmit()
                                 SubmitRating(objName, btnName,tag)
                              }
}

function SubmitRating(objName, btnName, tag){
  var obj = $get(objName)
  var btn = document.getElementById(btnName)
  if(obj && obj.Rated && btn){
      btn.disabled=false;
      btn.click();
      var d = new Date();
      d.setFullYear(d.getFullYear() +1)
      var CookieInfo = tag + "=" + escape("xxx") + ";expires="+d.toGMTString()+" path=/;"; 
      document.cookie = CookieInfo;
   }
}





var dragging = false;

function ra_resizeStart(e, splitter, leftSectionId)
{
  dragging = true;  
  window.ra_splitter = splitter;
  window.ra_leftSection = document.getElementById(leftSectionId);
  
  splitter.parrentOffsetX = ra_GetX(splitter.parentNode)  + e.clientX - ra_GetX(splitter)
  
  document.onmousemove = function(e) { if (!e) var e = window.event; ra_mouseMove(e) }
  document.onmouseup = function(e) { if (!e) var e = window.event; ra_resizeStop(e) }
  document.body.ondrag = function () { return !dragging; };
  document.body.onselectstart = function () { return !dragging; };
  
  return false;
}


function ra_resizeStop(e)
{
  document.onmousemove = null;
  document.onmouseup = null;
  splitter = window.ra_splitter;
  leftSection = window.ra_leftSection;

  ra_redaw(splitter, leftSection, splitter.offsetLeft)

  window.ra_element = null;
  dragging = false;
  
}
function HighlightSplitterBar(strObjName, intOnOff)
{       
   var sliderBar = document.getElementById(strObjName);
	
    if (intOnOff == 0)
    {
        sliderBar.style.backgroundImage ='url(/platform/controls/resizablearea/resources/lib_grippy1.gif)';
    }
    else
    {
        sliderBar.style.backgroundImage ='url(/platform/controls/resizablearea/resources/lib_grippy.gif)';
    }
   return;
}
function ra_redaw(splitter, leftSection, width )
{
	var date = new Date();
	date.setYear(date.getFullYear()+1); 

  if(width <= 30){//todo: add minwidth property
    leftSection.style.display = "none";
  	document.cookie = "toccollapsed=true; expires="+date.toGMTString();+"; path=/";
  	splitter.style.left ="0px";
  }else{
    leftSection.style.display = "block";
    splitter.style.left =width + "px";
  	leftSection.style.width = width + "px";
  	document.cookie = "toccollapsed=false; expires="+date.toGMTString();+"; path=/";
  	document.cookie = "tocwidth="+ width +"; expires="+date.toGMTString();+"; path=/";
   }
  if(window.ra_OnPageResize)
    ra_OnPageResize();  //rendered on the server side for IE 
}

function ra_mouseMove(e)
{
  var rightSectionMinWidth = 200;
  splitter = window.ra_splitter;
  x = e.clientX - splitter.parrentOffsetX;
  if(x <= 30) // //todo: add minwidth property
    x=0;
  else if(x >= splitter.parentNode.offsetWidth - splitter.offsetWidth - rightSectionMinWidth) 
    x = splitter.parentNode.offsetWidth - splitter.offsetWidth - rightSectionMinWidth 
  
  splitter.style.left=x + "px";
  return false;
}

function ra_GetX(oElement)
{
  var x = 0;
  while( oElement != null )
  {
    x += oElement.offsetLeft;
    oElement = oElement.offsetParent;
  }
  return x;

}


function ra_keyPress(e, splitterId, leftSectionId){
  var keyCode = (e==null) ? event.keyCode : e.which;
  
  if(keyCode == 116)
  {
		  target = (e==null) ? event.srcElement : e.target;

	    if (target.tagName.toLowerCase() != "input" && target.tagName.toLowerCase() != "textarea" )
	    {
		    ra_OpenCollapse( splitterId, leftSectionId)
      }
      if(e==null)
       event.cancelBubble = true;
      else
       e.cancelBubble = true;
  }
}

function ra_OpenCollapse( splitterId, leftSectionId)
{
  var leftSection =  document.getElementById(leftSectionId)
  var splitter = document.getElementById(splitterId)
  if(splitter.offsetLeft == 0)
    ra_redaw(splitter, leftSection , parseInt(leftSection.style.width))
  else
    ra_redaw(splitter, leftSection , 0)
}




function tabs_onFocusSearch(sender)
{
  if(sender.isActive)
    return;
  sender.originalValue = sender.value
  sender.value = "";
  sender.className = "TabStrip_SearchBoxActive";
  sender.isActive = true;
}

function tabs_onBlurSearch(sender)
{
 if(sender.value.trim()=="")
 {
    sender.value = sender.originalValue;
    sender.className = "TabStrip_SearchBox";
    sender.isActive = false;
 }
}



var _contentID;
var _contentLocale;
var _contentVersion;
var _noTagsMessage;
var _errorMessage;
var _browseByTagTooltip;
var _removeTagTooltip;
var _currentBlockID = 0;
var _originatingUrl;

function TagEditor_AddATag(url,blockID)
{
	if ( url != "" )
	{	// Need to authenticate
		document.cookie = "edit=" + blockID;
		document.cookie = "scroll=" + blockID;
		document.location.href = url;
	}
	else
	{	// Already authenticated
		showTagEditorEditPanel(blockID);
		TagEditor_GetControl(blockID,'textbox').focus();
	}
	return false;
}

function TagEditor_AddTags(blockID)
{
  var value = TagEditor_GetControl(blockID,'textbox').value;
  if ( value != "" )
  {
	  _currentBlockID = blockID;
	  Microsoft.Mtps.Web.WebServices.TagWebService.AddTags( _contentID,
                                                          _contentLocale,
                                                          _contentVersion,
                                                          value,
                                                          blockID,
                                                          _browseByTagTooltip,
                                                          _removeTagTooltip,
                                                          _originatingUrl,
                                                          tagEditorChangeComplete,
                                                          tagEditorChangeFailure
                                                          );
	  showTagEditorViewPanel(blockID);
  }
  else
  {
	  TagEditor_GetControl(blockID,'message').innerHTML = _noTagsMessage;
  }
	return false;
}

function TagEditor_BrowseTag(url,blockID)
{
	document.cookie = "scroll=" + blockID;
	document.location.href = url;
	return false;
}

function TagEditor_CancelAddTag(blockID)
{
  showTagEditorViewPanel(blockID);
	return false;
}

//function TagEditor_ClickAddTag(evt)
//{
//  TagEditor_AddTags(TagEditor_GetBlockID(evt.target.id));
//  evt.preventDefault();
//}

//function TagEditor_ClickCancelAddTag(evt)
//{
//  TagEditor_CancelAddTag(TagEditor_GetBlockID(evt.target.id));
//  evt.preventDefault();
//}

function TagEditor_GetBlockID(controlID)
{
  var count = TagEditorControls.length;
  for ( var i=0; i<count; i++ )
  {
    var value = TagEditorControls[i];
    var idx = controlID.indexOf(value['prefix']);
    if ( idx != -1 )
    {
      return value['id'];
    }
  }
  return -1;
}

function TagEditor_GetControl(blockID,control)
{
  var count = TagEditorControls.length;
  for ( var i=0; i<count; i++ )
  {
    var value = TagEditorControls[i];
    if ( value['id'] == blockID )
    {
      return $get(value['prefix']+control);
    }
  }
}

function TagEditor_GetTags(blockID)
{
  var tags = "";
	var tagEditorBody = TagEditor_GetControl(blockID,'tags');
	if ( tagEditorBody )
	{
	  var childElems = tagEditorBody.children;
	  if ( childElems.length > 0 )
	  {
      // Deal with DIV that is inserted when a tag is added from client
	    if ( childElems[0].tagName == "DIV" )
	    {
	       childElems = childElems[0].children;
	    }

	    if ( childElems.length > 0 )
	    {
        // Get tag values from spans (each has two hyperlinks - we need the first)
	      for ( var i=0; i<childElems.length; i++)
	      {
	        var elem = childElems[i].children[0];
	        if ( elem.tagName == "A" )
	        {
            tags += elem.innerHTML + " ";
          }
	      }
	    }
	  }
	}
  return tags;
}

function TagEditor_Init(itemID,itemLocale,itemVersion,auth, originatingUrl)
{
  _contentID = itemID;
	_contentLocale = itemLocale;
	_contentVersion = itemVersion;
	_originatingUrl = originatingUrl;

	var cookieParts = document.cookie.split("; ");
	var crumb="";
	for (var i=0; i<cookieParts.length; i++)
	{
		var crumbs = cookieParts[i].split("=");
		if (crumbs[0] == "scroll"
		 && crumbs[1] != "")
		{
			scrollToTagEditor(crumbs[1]);
			removeTagEditorCookie("scroll");
		}
		if (crumbs[0] == "edit"
		 && crumbs[1] != ""
		 && auth == "true")
		{
			showTagEditorEditPanel(crumbs[1]);
		}
	}
}

function TagEditor_InitStrings(noTagsMessage,errorMessage,browseByTagTooltip,removeTagTooltip)
{
	_noTagsMessage = noTagsMessage;
	_errorMessage = errorMessage;
  _browseByTagTooltip = browseByTagTooltip;
  _removeTagTooltip = removeTagTooltip;
}

function TagEditor_KeyDown(evt)
{
  if ( evt.keyCode == 13 )
  { // Enter pressed - add the tags
    TagEditor_AddTags(TagEditor_GetBlockID(evt.target.id));
    evt.preventDefault();
	}
	else if ( evt.keyCode == 27 )
	{ // Escape pressed - cancel the operation
	  TagEditor_CancelAddTag(TagEditor_GetBlockID(evt.target.id));
    evt.preventDefault();
	}
	else
	{
	  return true;
	}
}

function TagEditor_RemoveTag(tag,url,blockID)
{
	if ( url != "" )
	{	// Need to authenticate
		document.cookie = "remove=" + tag + ":" + blockID;
		document.cookie = "scroll=" + blockID;
		document.location.href = url;
	}
	else
	{	// Already authenticated
		_currentBlockID = blockID;
		Microsoft.Mtps.Web.WebServices.TagWebService.RemoveTag( _contentID,
                                                            _contentLocale,
                                                            _contentVersion,
                                                            tag,
                                                            blockID,
                                                            _browseByTagTooltip,
                                                            _removeTagTooltip,
                                                            _originatingUrl,
                                                            tagEditorChangeComplete,
                                                            tagEditorChangeFailure );
	}
	return false;
}

function removeTagEditorCookie(name)
{
	document.cookie = name + "=; expires=Fri, 02-Jan-1970 00:00:00 GMT";
}

function scrollToTagEditor(blockID)
{
	var ctrl = TagEditor_GetControl(blockID,'textbox');
	if (ctrl)
	{
	  ctrl.scrollIntoView(false);
	}
}

function showTagEditorEditPanel(blockID)
{
	TagEditor_GetControl(blockID,'view').style.display = "none";
	TagEditor_GetControl(blockID,'edit').style.display = "";
	TagEditor_GetControl(blockID,'textbox').value = "";
	TagEditor_GetControl(blockID,'message').innerHTML = "";
	removeTagEditorCookie("edit");
}

function showTagEditorViewPanel(blockID)
{
	TagEditor_GetControl(blockID,'view').style.display = "";
	TagEditor_GetControl(blockID,'edit').style.display = "none";
	TagEditor_GetControl(blockID,'message').innerHTML = "";
}

function tagEditorChangeComplete(result)
{
	var elem = document.createElement( "div" );
	elem.innerHTML = result;
	elem.style.display = "inline";
	var tagEditorBody = TagEditor_GetControl(_currentBlockID,'tags');
	if ( tagEditorBody )
	{
	  tagEditorBody.innerHTML = "";
	  tagEditorBody.appendChild( elem );
	}
	removeTagEditorCookie("remove");
	_currentBlockID = 0;
}

function tagEditorChangeFailure(error)
{
	TagEditor_GetControl(_currentBlockID,'message').innerHTML = _errorMessage;
	TagEditor_GetControl(_currentBlockID,'message').title = error.get_message();
	removeTagEditorCookie("remove");
}




function TFly_Init(name,  offsetLeft, offsetTop, alignment, anyIter, anyTime, staticHover, popupHover, popupLatency, hideLatency, onInit, onPopup, onHide){
  var TFly = document.getElementById(name); 
  TFly.alignment = alignment;
  TFly.DT = document.getElementById(name+"_Popup")
  TFly.F = document.getElementById(name+"_Anim")
  
  TFly.oX = offsetLeft
  TFly.oY = offsetTop;

  TFly.AnyIter = anyIter;
  TFly.AnyTime = anyTime;

  TFly.popupLatency = popupLatency;
  TFly.hideLatency = hideLatency;
  TFly.onPopup = onPopup;
  TFly.onHide = onHide;
  
  TFly.IsHover=false;
  
  TFly.className_ = TFly.className;
  TFly.DT.className_=TFly.DT.className
  
  TFly.onmouseover = function(){TFly.IsHover=true; if(staticHover!=''){TFly.className=staticHover}; TFly_Popup(TFly,true);}
  TFly.onmouseout = function(){if(staticHover!=''){TFly.className=TFly.className_};TFly_Popup(TFly,false);TFly.DT.blur();TFly.IsHover=false;}

  if(document.all){
    TFly.onactivate = function(){if(!TFly.IsHover)TFly.onmouseover();}
    TFly.ondeactivate = function(){TFly.onmouseout();}
  }else{
    TFly.onfocus = function(){TFly.onmouseover()}
    TFly.onblur = function(){TFly.onmouseout()}
  }
 
 
  TFly.DT.onmouseover = function(){ TFly.IsHover=true; if(popupHover!=''){TFly.DT.className=popupHover;};TFly_Popup(TFly,true);}
  TFly.DT.onmouseout = function(){ if(popupHover!=''){TFly.DT.className=TFly.DT.className_};TFly_Popup(TFly,false);TFly.IsHover=false; }

  TFly_CallClientFunction(onInit, TFly)
}

function TFly_Reposition(TFly){
  var clientWidth = document.body.scrollWidth - 20; //scroller width
  var width = TFly.DT.offsetWidth;
  var absX = TFly.DT.offsetLeft 
  var d = TFly.DT
  while(d = d.offsetParent)
    absX += d.offsetLeft

  if(clientWidth<(absX+width)){
   var diff = clientWidth - absX -width
   TFly.DT.style.left = TFly.DT.offsetLeft + diff + "px"
  }
}

function TFly_CallClientFunction(name, TFly){
    if(name!=null &&  name!="")
      eval( name + "(TFly);");
}

function TFly_SetPosition(TFly, obj){
  obj.style.top = TFly.oY + TFly.offsetHeight+ "px";
  obj.style.left = TFly.oX + (TFly.offsetWidth - obj.offsetWidth )*(1+TFly.alignment)/2 + "px";
}

function TFly_Popup(TFly,value){
  if(TFly.timer!=null ) window.clearTimeout(TFly.timer)
  if(value){
    if(TFly.status=="on") return
    var timeout = (TFly.status=="active") ? 0 : TFly.popupLatency
    if(TFly.AnyIter>0 && TFly.AnyTime>0)
      TFly.timer = window.setTimeout(function(){TFly_AnimateStart(TFly,true,TFly.F.curIter);},timeout)
    else
      TFly.timer = window.setTimeout(function(){TFly_SetVisibility(TFly,true);},timeout)
  }else{
    if(TFly.status=="off") return
    var timeout = (TFly.status=="active") ? 0 : TFly.hideLatency
    if(TFly.AnyIter>0 && TFly.AnyTime>0)
      TFly.timer = window.setTimeout(function(){TFly_AnimateStart(TFly,false,TFly.F.curIter);},timeout)
    else
      TFly.timer = window.setTimeout(function(){TFly_SetVisibility(TFly,false);},timeout)
  }
}

function TFly_SetVisibility(TFly, value){
      if(value==true){
        TFly_SetPosition(TFly,TFly.DT);
        TFly.DT.style.visibility = "visible"
        TFly.style.zIndex = "999"
        TFly_Reposition(TFly);
      }else{
        TFly.DT.style.visibility = "hidden"
        TFly.style.zIndex = "0"
        TFly.DT.style.left = "-10000px"
      }
}

function TFly_AnimateStart(TFly, inout, curIter){
    if(TFly.F.timer!=null) window.clearTimeout(TFly.F.timer);
    if(curIter==null) curIter=0;
    if(TFly.status !="active"){
        TFly.status ="active";
        TFly.F.style.visibility = "visible";
        TFly.DT.style.visibility="hidden";
    }
    if(curIter<0 || curIter>TFly.AnyIter ){
        TFly.F.curIter = (curIter<1) ? 0 : TFly.AnyIter;
        TFly.status = (TFly.F.curIter==TFly.AnyIter) ? "on": "off";
        TFly.F.style.visibility = "hidden";
        TFly_SetPosition(TFly,TFly.DT);
        TFly.style.zIndex=(TFly.F.curIter==TFly.AnyIter) ? "999" : "0";
        if(TFly.F.curIter==TFly.AnyIter){
          TFly.status = "on";
          TFly_SetVisibility(TFly,true);
          TFly_CallClientFunction(TFly.onPopup, TFly)
        }else{
          TFly.status = "off";
          TFly_SetVisibility(TFly,false);
          TFly_CallClientFunction(TFly.onHide, TFly)
        }
    }else{
        var per = curIter*(95/TFly.AnyIter)+ 5;
        TFly.F.style.visibility = "hidden";
        TFly.F.style.width=TFly.DT.offsetWidth/100*per + "px";
        TFly.F.style.height=TFly.DT.offsetHeight/100*per + "px";
        TFly_SetPosition(TFly, TFly.F);
        TFly.F.style.visibility = "visible";
        var timeout = (per==100 ) ? 0 : TFly.AnyTime - (TFly.AnyTime/(TFly.AnyIter)*(curIter)); 
        curIter += (inout) ? 1:-1;
        TFly.F.timer = window.setTimeout(function(){TFly_AnimateStart(TFly, inout, curIter)},timeout);
        TFly.F.curIter = curIter;
    }
}




//________________________________________________________________________________
function LoadToc()
{
  holder = document.getElementById('tocVectorTreeId');
  
  AsyncTocLoader();
}

//________________________________________________________________________________
function GetNextSegment()
{
  var segment = tocVector.nodes[tocIndex].id;
  tocIndex++;
  return segment;
}
    
//________________________________________________________________________________
function CreateHint( el )
{
  var tmp = el.parentNode;
  var s = "";
  
  while ((tmp != null) && (tmp.tagName == "LI"))
  {
    s = tmp.attributes.getNamedItem("name").value + "/" + s;
    tmp = tmp.parentNode;
    
    if ((tmp != null) && (tmp.tagName == "UL"))
    {
      tmp = tmp.parentNode;
    }
  }
  
  return s;
}

//________________________________________________________________________________
function WriteCookie( hint )
{
  document.cookie="TocHashCookie="+hint+"; expires=Wednesday, 01-Aug-2040 08:00:00 GMT";

}

//________________________________________________________________________________
function TocClick(e)
{
  if (window.event)
  {
    window.event.cancelBubble = true;
  }
  else
  {
    e.cancelBubble = true;
  }
     
  var srcEl = window.event ? window.event.srcElement : null;
  if ((srcEl == null) && (e.target != null))
  {
    srcEl = e.target;
  }

  if (srcEl.tagName == "IMG")
  {
    // they've clicked on one of the images
    if (srcEl.src == emptyImg)
    {
      // We've checked this node before and found nothing.  Move on, nothing to see here.
      return;
    }
    
    // adjust the image, retrieve new data as needed.
    if (srcEl.src == closedImg)
    {
      Expand( srcEl );
    }
    else
    {
      Collapse( srcEl );
    }
  }
  else if (srcEl.tagName == "A")
  {
    WriteCookie( CreateHint( srcEl ) );
  }
}

//________________________________________________________________________________
function FindHolder( container, id )
{
  var element;
  
  if (container != null)
  {
    for( x=0; x<container.childNodes.length; x++)
    {
      var elementName = container.childNodes[x].attributes.getNamedItem("name").value;
      if (elementName != null)
      {
        if ((elementName.length >= id.length) && (elementName.substr(0,id.length) == id))
        {
          return container.childNodes[x];
        }
      }
    }
  }
  return null;
}

//________________________________________________________________________________
function AsyncTocLoader()
{
  var highlightedElement = null;
  if (document.getElementById) 
  {
    if (typeof tocVector == "undefined")
    {
      return;
    }
    
    if (tocIndex < tocVector.nodes.length)
    {
      var nextUrl = hostbase + tocVector.nodes[tocIndex].url + ".aspx";
      var segment = GetNextSegment();
      holder = FindHolder( holder, segment );
      
      if (holder != null)
      {
        var i = holder.childNodes[0];
        i.src = loadingImg;

        var x = (window.ActiveXObject) ? new ActiveXObject("Microsoft.XMLHTTP") : new XMLHttpRequest();
        
        if (x)
        {
          x.onreadystatechange = function()
          {
            var id = segment;
            if (x.readyState == 4 && x.status == 200)
            {
              if (holder != null)
              {
                if (x.responseText.substr(0,4) == "<ul ")
                {
                  i.src = openImg;             
                  holder.innerHTML = holder.innerHTML + x.responseText;
                  var elements = holder.getElementsByTagName("UL");
                  // There is only one UL per Toc level.
                  holder = elements[0];
                  
                  if ((x.responseText.length > 5) && (holder != null))
                  {
                    x.abort();
                    AsyncTocLoader();
                  }
                  else
                  {
                    SetFocus(holder);
                    i.src = emptyImg;
                  }
                }
                else
                {
                    SetFocus(holder);
                    i.src = emptyImg;
                }
              }
              else
              {
                 i.src = emptyImg;
              }
            }
          }
        }
        x.open("GET", nextUrl, true);
        x.send("");
      }
    }
    else
    {
      if (holder != null)
      {
        SetFocus(holder.parentNode);
      }
    }
  }
}
//________________________________________________________________________________
function SetFocus(el)
{
  try
  {
    if (el != null)
    {
      var elements = el.getElementsByTagName("A");
      el.parentNode.parentNode.scrollIntoView(true);
      el.scrollIntoView(true);
      WriteCookie( CreateHint( elements[0] ) );
      elements[0].focus();
      elements[0].className = "tocSelected";
    }
  }
  catch(e)
  {
  }
}
     	        
//________________________________________________________________________________
function ajaxLoader(url)
{
  if (document.getElementById) 
  {
    var x = (window.ActiveXObject) ? new ActiveXObject("Microsoft.XMLHTTP") : new XMLHttpRequest();			      
  }
    
  if (x)
  {
    x.open("GET", url, false);
    x.send("");
    var el = x.responseText;
    return el;
  }
}

//________________________________________________________________________________
function GetNodeRetrievalUrl( el )
{
  var parent = el.parentNode;
  return hostbase + "/"+parent.attributes.getNamedItem("name").value + ".aspx"; 
}

//________________________________________________________________________________
function FindSection( el )
{
  var parent = el.parentNode;
  return parent;
}

//________________________________________________________________________________
function FindSubSection( el )
{
  var parent = el.parentNode;
  var sections = parent.getElementsByTagName( "UL" );
  if (sections.count == 0)
  {
    return null;
  }
  else
  {
    return sections[0];
  }
}      


//________________________________________________________________________________
function Expand( el )
{
  var section;
  var subsection = FindSubSection( el );
  
  if (subsection == null)
  {
    el.src = loadingImg;
    
    // Subsection not attached yet. Go get it.                       
    var subsectionHtml = ajaxLoader( GetNodeRetrievalUrl( el ));
    
     // if we still don't have a subsection, change the image to empty
    if ((subsectionHtml == null) || (subsectionHtml.substr(0,4) != "<ul "))
    {
      el.src = emptyImg;
      return;
    }
    
    // We got one from the web site, so insert it.
    section = FindSection( el );
    section.innerHTML = section.innerHTML+subsectionHtml;
    var elements = section.getElementsByTagName( "UL" );
    subsection = elements[0];
    
    elements =  section.getElementsByTagName( "IMG" );
    el = elements[0];           
  }

  // open up the section and make it visible
  el.src = openImg;
  subsection.style.display ="block";
  subsection.style.visibility ="visible";
}

//________________________________________________________________________________
function Collapse( el )
{
  el.src = closedImg;
  var subsection = FindSubSection( el );
 
  if (subsection != null)
  {
    subsection.style.display ="none";
    subsection.style.visibility ="hidden";
  }
}
       





function DoSave(editorId, hfDataID, titleID, tDataID, headerID, saveID, cancelID, labelID,  lastTitle, tagTextBoxID, tagDataID, blockID)
{
  var editorObj = $find(editorId);
  var title = $get(titleID).value;
  var cont = editorObj.get_ModifiedContent();
  var label = $get(labelID);
  var tagTextBox = $get(tagTextBoxID);
  var tags = "";
  if (tagTextBox != null )
  {
	  tags = tagTextBox.value;
  }
  if(title == null || title.trim() == ""){
    label.style.display="";
    label.innerHTML = errEmptySubject;
    return false;
  }
  if(cont.trim() == ""
  || cont.trim() == '&nbsp;'
  || cont.trim() == "<br>"){
    label.style.display="";
    label.innerHTML = errEmptyContent;
    return false;
  }
  if (cont.trim() == editorObj.get_OriginalContent().trim()
   && title.trim() == lastTitle.trim()
   && tags.trim() == $get(tagDataID).value.trim()){
    label.style.display="";
    label.innerHTML = errSameContent;
    return false;
  }

  if( headerID!=null && headerID!="")
  {
    SwitchToView(headerID, editorId, titleID, saveID, cancelID, blockID);
  }
  
  $get(hfDataID).value = cont;
  $get(tDataID).value = title;
  $get(tagDataID).value = tags;
  return true;
}

function DoCancel(headerID, editorID, titleID, saveID, cancelID, labelID, blockID, hfDataID, tDataID){
  var label = $get(labelID);
  label.style.display="none";
  var bodyHF = $get(hfDataID);
  var titleHF = $get(tDataID);
  if ( bodyHF.value
    || titleHF.value )
  {
    $find(editorID).set_OriginalContent(bodyHF.value);
    $get(titleID).value = titleHF.value;
    bodyHF.value = "";
  }
  SwitchToView(headerID, editorID, titleID, saveID, cancelID, blockID);
}

function toggleEditUI(editorId, titleID, saveID, cancelID)
{   
    var titleLabel = $get(titleID);
    if (titleLabel)
    {
        if (titleLabel.style.display == "none")
            titleLabel.style.display = "block";
        else
            titleLabel.style.display = "none";
    }
    
    var saveButton = $get(saveID);
    if (saveButton)
    {
        if (saveButton.style.display == "none")
            saveButton.style.display = "";
        else
            saveButton.style.display = "none";
    }
    
    var cancelButton = $get(cancelID);
    if (cancelButton)
    {
        if (cancelButton.style.display == "none")
            cancelButton.style.display = "";
        else
            cancelButton.style.display = "none";
    }
}



function GetHistoryItems(btnLoad){
    var btn = $get(btnLoad);
    if(btn)
      //eval(btn.href)
      window.setTimeout(function() {eval(btn.href)},400);
}

function SwitchToEdit(headerID, inlineEditorID, titleID, saveID, cancelID, blockID, tagTextboxID, cpHistoryID)
{
  var tagEditor = TagEditor_GetControl(blockID,'panel');
  if ( tagEditor )
  {
  	tagEditor.style.display = "none";
  	var tagEditorTextbox = $get(tagTextboxID);
  	tagEditorTextbox.value = TagEditor_GetTags(blockID);
  }
  if ( cpHistoryID !== undefined )
  {
    var cpHistory = $find(cpHistoryID);
    cpHistory.set_Collapsed(true)
    var header =  $get(headerID);
    header.style.display = "none";
    header.parentNode.className = "wkViewerContainer_Edit";
  }
  try
  {
    $find(inlineEditorID).switchToEditMode();
    toggleEditUI(inlineEditorID, titleID, saveID, cancelID);
  }
  catch (e) {}
}

function SwitchToView(headerID, inlineEditorID, titleID, saveID, cancelID, blockID)
{
  var header =  $get(headerID);
  header.style.display = "block";
  header.parentNode.className="wkViewerContainer";

  $find(inlineEditorID).switchToViewMode();
  toggleEditUI(inlineEditorID, titleID, saveID, cancelID);

  var tagEditor = TagEditor_GetControl(blockID,'panel');
  if ( tagEditor )
  {
  	tagEditor.style.display = "";
  }
}

function wkItemHighlight(val,headerID,textID){
  var header = $get(headerID);
  var text = $get(textID);
  if(header.style.display == "none") val = false; // do not highlight in editMode
  if(val){
    header.className+="Hover";
    text.className+="Hover";
  }else{
    header.className = header.className.replace("Hover","");
    text.className = text.className.replace("Hover","");
  }
}




function wkScrollToView(elementID){
  $get(elementID).scrollIntoView();
  window.setTimeout("$get('"+elementID+"').focus()",0);
}

function wkAddNewItem(buttonID, newItemPanelID, editorID, titleID)
{
  if( $get(newItemPanelID).style.display == "block"){
      $get(newItemPanelID).scrollIntoView();
      window.setTimeout("$get('"+titleID+"').focus()",0);
    return;
  }
  $get(newItemPanelID).style.display = "block";
  $get(buttonID).className="ccAddLinkDisabled";
  $find(editorID).switchToEditMode();
  window.setTimeout("$get('"+titleID+"').focus()",0);
}

function wkRemoveNewItem(buttonID, newItemPanelID, editorID, labelID)
{
  $get(newItemPanelID).style.display = "none";
  $get(buttonID).className="ccAddLink";
  $get(buttonID).disabled = false;
  $get(labelID).innerHTML = "";
  $find(editorID).switchToViewMode();
}

function saveNewWikiItem(editorID, hfDataID, titleID, tDataID, labelID, newWikiItemPanelID, tagTextBoxID, tagDataID)
{
  var editorObj = $find(editorID);
  var title = $get(titleID).value;
  var cont = editorObj.get_ModifiedContent();
  var label = $get(labelID);
  var tagTextBox = $get(tagTextBoxID);
  var tags = "";
  if ( tagTextBox != null )
  {
  	tags = tagTextBox.value;
  }

  if(title == null || title.trim() == ""){
    label.innerHTML = errEmptySubject;
    return false;
  }
  if(cont.trim() == "" || cont.trim() == '&nbsp;'){
    label.innerHTML = errEmptyContent;
    return false
  }
  
  $get(hfDataID).value = cont;
  $get(tDataID).value = title;
  $get(titleID).value = title;
  $get(tagDataID).value = tags;
  editorObj.switchToViewMode();
  window.setTimeout(function(){$get(newWikiItemPanelID).style.display="none";},10);

  return true;
}


