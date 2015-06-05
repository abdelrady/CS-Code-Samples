var rated = false;
var newRating = -1;

function ele(eleName) {
 if(document.getElementById && document.getElementById(eleName)) {
    return document.getElementById(eleName);
  }
  else if (document.all && document.all(eleName)) {
    return document.all(eleName);
  }
  else if (document.layers && document.layers[eleName]) {
    return document.layers[eleName];
  } else {
    return false;
  }
}

function setStars(url, docId, val, location) {
  ele("rating_info_" + location).style.display = "inline";
  if (location == 'top') {
    ele('communityRating').style.display = "none";
  }
  ele("rating_info_" + location).innerHTML = MSG_ANNOTATION_SAVING;
  rated = true; 
  submitRating(url, docId, val, location);
 }

function overStars(rating, location, realRating, cell) {
  rated = false;
  cell.style.cursor='pointer';
  ele("rating_info_" + location).style.display = "inline";
  if (location == 'top') {
    ele('communityRating').style.display = "none";
  }

  ele('1_' + location).src = 'http://i.dslr.net/sc/st_pe_off_l_lg.gif';	
  ele('2_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
  ele('3_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
  ele('4_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
  ele('5_' + location).src = 'http://i.dslr.net/sc/st_pe_off_r_lg.gif';	

  if (rating >= 1) {
    ele('1_' + location).src = 'http://i.dslr.net/sc/st_pe_on_l_lg.gif';	
    if (location == 'top') {
      ele('rating_info_' + location).innerHTML = MSG_RATING_POOR;
    } else {
      ele('rating_info_' + location).innerHTML = MSG_RATING_POOR_SHORT;	
    }
  }
  if (rating >= 2) {
    ele('2_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';	
    if (location == 'top') {
      ele('rating_info_' + location).innerHTML = MSG_RATING_BELOW_AVERAGE;	
    } else {
      ele('rating_info_' + location).innerHTML = MSG_RATING_BELOW_AVERAGE_SHORT;	
    }
  }  
  if (rating >= 3) {
    ele('3_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';
    if (location == 'top') {
      ele('rating_info_' + location).innerHTML = MSG_RATING_AVERAGE;
    } else {
      ele('rating_info_' + location).innerHTML = MSG_RATING_AVERAGE_SHORT;	
    }	
  } 
  if (rating >= 4) {
    ele('4_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';	
    if (location == 'top') {
      ele('rating_info_' + location).innerHTML = MSG_RATING_ABOVE_AVERAGE;	
    } else {
      ele('rating_info_' + location).innerHTML = MSG_RATING_ABOVE_AVERAGE_SHORT;	
    }
  } 
  if (rating >= 5) {
    ele('5_' + location).src = 'http://i.dslr.net/sc/st_pe_on_r_lg.gif';	
    if (location == 'top') {
      ele('rating_info_' + location).innerHTML = MSG_RATING_EXCELLENT;
    } else {
      ele('rating_info_' + location).innerHTML = MSG_RATING_EXCELLENT_SHORT;	
    }	
  } 
}

function outStars(rating, location, realRating, cell) {
  cell.style.cursor='default';
  if (!rated) {
    ele('communityRating').style.display = "inline";
    if (newRating == -1) {
      setStarsToValueInLocation(realRating, location);
    } else { 
      setStarsToValueInLocation(newRating, location);
    }
  }
}

function submitRating(url, docId, rating, location) {
  var doc = getXmlDocument();
  var root = appendElement(doc, doc, "rating"); 
  appendElement(doc, root, "docid", docId); 
  appendElement(doc, root, "user_rating", rating);

  sendAjaxRequest(url, handleRatingResponse, doc, location, 'text/xml; charset="utf-8"');	
}

function handleRatingResponse(req, success, url, odata, loc) {   
  ele("rating_info_" + loc).style.display = "none";
  ele('communityRating').style.display = "inline";
  ele("rating_info_" + loc).innerHTML = "";

  var errObj;
  errObj = ele('rating_error_' + loc);
     
  if (!success || !req.responseXML) {
    errObj.innerHTML = MSG_UNKNOWN_ERROR;
    errObj.style.display = 'inline';
  } else {
      var root = req.responseXML.documentElement;
      if (root.tagName == 'error') {
        var msg = getElementValue(root, 'errormessage');
        errObj.innerHTML = msg;
        errObj.style.display = 'inline';
        setStarsToValueInLocation(userRating, loc);
      } else {
        var userRating = getElementValue(root, 'user_rating');
        setStarsToValueInLocation(userRating, 'top');
	      ele("rating_info_" + loc).style.display = "inline";
        if (loc == 'top') {
          ele('communityRating').style.display = "none";
        }
        ele("rating_info_" + loc).innerHTML = MSG_ANNOTATION_SAVED;
        newRating = userRating;
        setTimeout("concealRatingInfo()",5000);
     }
   }
}

function concealRatingInfo() {
  ele("rating_info_top").style.display = "none";
  ele('communityRating').style.display = "inline";
  ele("rating_info_top" ).innerHTML = "";
}

function setStarsToValueInLocation(rating, location) {
    ele('rating_info_'+ location).innerHTML = '';
    ele('rating_info_' + location).style.display = "none";
    ele('1_' + location).src = 'http://i.dslr.net/sc/st_pe_off_l_lg.gif';	
    ele('2_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
    ele('3_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
    ele('4_' + location).src = 'http://i.dslr.net/sc/st_pe_off_m_lg.gif';	
    ele('5_' + location).src = 'http://i.dslr.net/sc/st_pe_off_r_lg.gif';	
	
    if (rating >= 1) {
      ele('1_' + location).src = 'http://i.dslr.net/sc/st_pe_on_l_lg.gif';	
    }
    if (rating >= 2) {
      ele('2_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';	
    }  
    if (rating >= 3) {
      ele('3_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';	
    } 
    if (rating >= 4) {
      ele('4_' + location).src = 'http://i.dslr.net/sc/st_pe_on_m_lg.gif';	
    } 
    if (rating >= 5) {
      ele('5_' + location).src = 'http://i.dslr.net/sc/st_pe_on_r_lg.gif';	
    }
}

function createStarsHtml(stars, allowRating) {
  if (allowRating && stars > 0) {
    var imageString = '';
    for (var i = 0; i < stars; i++) {
        imageString = imageString + '<img src="http://i.dslr.net/sc/starLittle.gif">';
    }
    for (var j = stars; j < 5; j++) {
	imageString = imageString + '<img src="http://i.dslr.net/sc/starLittleEmpty.gif">';
    }
    return imageString;
  }
  return " ";
}

// method for creating XML Document
// ActiveX is for IE, all others should follow DOM rules
// For IE, find the best ActiveX object available
function getXmlDocument() {
  var ret;
  if (document.implementation && document.implementation.createDocument) {
    ret = document.implementation.createDocument("", "", null);
  } else if (window.ActiveXObject) {
    var err;
    try {
      ret = new ActiveXObject("Msxml2.DOMDocument.3.0");
    } catch (e) {
      err = e.message;
      try { 
        ret = new ActiveXObject("MSXML2.DOMDocument"); 
      } catch(e) { 
        err = e.message;
        try { 
          ret = new ActiveXObject("MSXML.DOMDocument"); 
        } catch(e) {
          err = e.message;
        }
      }
    }
    var pi = ret.createProcessingInstruction("xml",
                        "version='1.0' encoding='UTF-8'");
    ret.appendChild(pi);
  } else {
    throw "Browser is unable to create XML document: not supported by" +
     "this browser";
  }
  return ret;
}

// XML Element creation
// set parent=doc to append to doc
// set null value if sub elements
function appendElement(doc, parent, tag, value) {
  var elem = doc.createElement(tag);
  if (value) {
    elem.appendChild(doc.createTextNode(value));
  }
  parent.appendChild(elem);
  return elem;
}

// Reading XML Element value 
function getElementValue(parentElement, tag) {
  var list = parentElement.getElementsByTagName(tag);
  if (!list || list.length == 0) {
    return null;
  }
  list = list[0].childNodes;
  if (!list || list.length == 0) {
    return null;
  }
  // supporting single child node only
  return list[0].nodeValue;
}

// AJAX stuff
function getAjaxRequestType() {
  var xmlhttp;
  var activeXType;

  /*@cc_on
  @if (@_jscript_version >= 5)
    try {
      xmlhttp = new ActiveXObject(activeXType = "Msxml2.XMLHTTP");
    } catch (e) {
      try {
        xmlhttp = new ActiveXObject(activeXType = "Microsoft.XMLHTTP");
      } catch (E) {
        xmlhttp = false;
      }
    }
  @else
  xmlhttp = false;
  @end @*/

  if (!xmlhttp && typeof XMLHttpRequest != 'undefined') {
    try {
      xmlhttp = new XMLHttpRequest();
    } catch (e) {
      xmlhttp = false;
    }
  }
  return activeXType;
}

var ieActiveXType = getAjaxRequestType();

function createAjaxRequest() {
  var xmlhttp;
  
  if (ieActiveXType) {
    xmlhttp = new ActiveXObject(ieActiveXType);
  } else {
    xmlhttp = new XMLHttpRequest();
  }
  return xmlhttp;
}

function sendAjaxRequest(url, callback, opt_data, opt_opaqueId, opt_mime) {
  // use a new private instance for every request
  var req = createAjaxRequest();
  var method = 'GET';
  if (opt_data) {
    method = 'POST';
    if (!opt_mime) {
      opt_mime = 'application/x-www-form-urlencoded';
    }
  }
  req.open(method, url, true);
  if (opt_data && opt_mime) {
    req.setRequestHeader('Content-Type', opt_mime);    // must be called after open
  }
  // stick the instance data into the scope of the function literal 
  req.onreadystatechange = function() {
    if (req.readyState == 4) {
      callback(req, req.status && req.status == 200, url, opt_data, opt_opaqueId);
    }
  };
  req.send(opt_data);
}

