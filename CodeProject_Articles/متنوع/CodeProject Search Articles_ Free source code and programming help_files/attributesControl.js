var AttrBarNeedsUpdate = false;

// Gets a list of selected attribute versions and stores that list in a hidden field and also
// updates a human readable description
function GetSelectedVersions(CheckBoxClass, Descriptor, HiddenList)
{
	var chkelms = getAttrBarCheckboxes(CheckBoxClass, true);
	var verList = document.getElementById(Descriptor);
	var verIdList = document.getElementById(HiddenList);
	if (!verList || !chkelms) return;	
	
	var versions="",IDs="";
	for (var i = 0; i < chkelms.length; i++)
	{
		if (versions)versions+=", ";versions+=chkelms[i].getAttribute("ver");
		if (IDs)IDs+=",";IDs+=chkelms[i].value;
	}
	if (versions=='')versions='No filter selected - all articles shown';
	if (document.all) verList.innerText = versions;
	else {
		if (verList.firstChild == null) {
			var new_el = document.createTextNode(versions);
			verList.appendChild(new_el);
		} else
			verList.firstChild.nodeValue = versions;
	}
	verIdList.value = IDs
}

function OnCloseAttrBar() {
	GetSelectedVersions("AttrBarSub", "AttrBarSelVers", "AttrBarIdList");
	AttrBarNeedsUpdate = false;
}

function MakeSelect(attrId, name) {
	AttrBarNeedsUpdate = true;
	if (document.getElementById('UpdateRmdr')) document.getElementById('UpdateRmdr').style.display='';
}

function OnScrollListSelect(attrId, name) {
	//GetSelectedVersions("AttrBarSub", "AttrBarSelVers", "ScrollListVersIds");
}

// Shows/Hides attribute version list for a given attribute type
function toggleAttributePanel(button) {
	var attributes = document.getElementById("attributes");   
	if (attributes) {
		if (attributes.style.display == "none") {
			button.innerHTML = "- Hide attribute list";
			attributes.style.display = "block";
		}
		else {
			button.innerHTML = "+ Show attribute list";
			attributes.style.display = "none";
		}
	}	
}

// Shows/Hides versions checkboxes for a given attribute
function showHideVersion(element, scrollBoxId) {
	var parentNode = document.getElementById(scrollBoxId);
	if (parentNode)	{
		var versions = parentNode.getElementsByTagName("div");
		for (var i=0; i<versions.length; i++) {
			var elm=versions[i];
			if (elm && elm.attributes["parent"] && elm.attributes["parent"].value==element) {
				if (elm.style.display=="none") 
					elm.style.display="block";
				else 
					elm.style.display="none";
			}
		}
	}
	return false;
}

// checks/unchecks all checkboxes for versions of this attribute (Scroll View)
function checkVersions(parentId, checked) {
	var i,divs = document.getElementsByTagName("div"); 
	if (!divs) return;
	
	for(i=0;i<divs.length;++i) {
		if (divs[i] && divs[i].attributes["parent"] && 
			divs[i].attributes["parent"].value == parentId) {
			
			divs[i].style.display=(checked)?"block":"none";
			
//			var inp=divs[i].getElementsByTagName("input");
//			if (inp && inp.length > 0) {
//				//var span = divs[i].getElementsByTagName("span");
//				//if (span && span.length > 0 && span[0].attributes["versionId"])
//				if (inp[0] && inp[0].attributes["versionId"])
//					inp[0].checked = checked; 
//			}
		}
	}
}

// If an attribute is checked/unchecked then check/uncheck all its versions as well (Open View)
function checkAllVersions(checkbox, id) {
	var parentNode = document; //.getElementById("attributeListTable");
	if (parentNode)
	{
		var versions = parentNode.getElementsByTagName("input");
		if (!versions) return;
		for (var i=0; i<versions.length; i++) {
			var elm=versions[i];
			if (elm && elm.attributes["parentId"] && elm.type=="checkbox" && elm.attributes["parentId"].value==id) {
				if (elm.attributes["versionId"]) {
					var versionId = elm.attributes["versionId"].value;
					elm.checked = checkbox.checked;
				}
			}
		}
	}
}

function getAttrBarCheckboxes(searchClass, selectedOnly) {
	var classElements = new Array();
	var els = document.getElementsByTagName("div");
	var elsLen = els.length;
	var pattern = new RegExp('(^|\\s)'+searchClass+'(\\s|$)');
	for (i = 0, j = 0; i < elsLen; i++) {
		if ( pattern.test(els[i].className) ) {
			var subelms = els[i].getElementsByTagName("input");
			for (var k = 0; k < subelms.length; k++)
			{
				if (!selectedOnly||subelms[k].checked) classElements[j++] = subelms[k];
			}
		}
	}
	return classElements;
}

// Checks attribute version check boxes given a list of attribute versions
function SetAttrBarChecks(CheckBoxClass, versionList)
{
	var chkelms = getAttrBarCheckboxes(CheckBoxClass, false);
	for(var i = 0; i < chkelms.length; i++)
		chkelms[i].checked = false;

	if (versionList) {
		var attrIds = versionList.split(",");
		for(var i = 0; i < attrIds.length; i++)
		{
			for(var j = 0; j < chkelms.length; j++)
			{
				if (chkelms[j].value.toString() == attrIds[i]) { chkelms[j].checked=true;}
			}
		}
	}
	if (typeof(MakeSelect) != 'undefined') MakeSelect(0,"");
	if (typeof(OnCloseAttrBar) != 'undefined') OnCloseAttrBar();
}

// Checks versions based on the quick pick selector
function SetAttrBar(selector, CheckBoxClass)
{
	var selected = selector.options[selector.selectedIndex];
	if (selected)
		SetAttrBarChecks(CheckBoxClass, selected.getAttribute("attrs"));
	else
		SetAttrBarChecks(CheckBoxClass, null);
}