// JScript File

function OpenManageArticleParagraph(articleParagraphID,articleID,languageID,sortOrder)
{
       var q = '';
 
        q ="id=" + articleParagraphID;
        q+= "&languageid=" + languageID;
        q+= "&sortorder=" + sortOrder;
        q+= "&articleid=" + articleID;
 
        
	var sOption="toolbar=no,location=no,status=yes,directories=no,menubar=no,";
          sOption+="scrollbars=1,width=680,height=425,left=150,top=25";
                      					                 
     var win=window.open("ManageArticleParagraph.aspx?" + q,"Paragraphs",sOption);
 
     win.focus();
  
}

function OpenConversationReply(messageID)
{
    
	var sOption="toolbar=no,location=no,status=yes,directories=no,menubar=no,scrollbars=yes,";
          sOption+="width=625,height=450,left=375,top=125";
                      					          
     var win=window.open("/ConversationPoster.aspx?messageid=" + messageID,"Post",sOption);
 
     win.focus();
  
}

function OpenUpload()
{
    
	var sOption="toolbar=no,location=no,status=yes,directories=no,menubar=no,scrollbars=yes,";
          sOption+="width=530,height=210,left=350,top=100";
                      					          
     var win=window.open("/Upload.aspx","Upload",sOption);
 
     win.focus();
  
}

function OpenFormatSourceCode()
{
    
	var sOption="toolbar=no,location=no,status=yes,directories=no,menubar=no,scrollbars=yes,";
          sOption+="width=525,height=350,left=250,top=150";
                      					          
     var win=window.open("/FormatSourceCode.aspx","Formatter",sOption);
 
     win.focus();
  
}


       function PrintThisPage()
	   {
	          var sOption="toolbar=yes,location=no,directories=yes,menubar=yes,";
              sOption+="scrollbars=yes,width=750,height=600,left=100,top=25";
                      					                 
              var winprint=window.open("/print.aspx","Print",sOption);
                            
              winprint.focus();
 
	   }
	  
	  function searchRelated(e)
		{ 
		    
	     if (!e) var e = window.event; 
    	if (e.keyCode == 13) 
		 {	
 
		  doSearch();
		  
		  return false; 
		 }		
       }	   
       
	function doSearch()
	   {
	    srch=document.getElementById('ctl00_MiddleContent_searchRelatedText').value;	  	    
		      srch='site:eggheadcafe.com '+srch;
          window.open('http://www.eggheadcafe.com/articles/SeachRelated/SearchRelated.aspx?q='+srch,
	  null, 'left=500;toolbar=0,scrollbars=1,location=0,statusbar=1,menubar=0,resizable=1,width=500,height=600');
		} 
		
			  function searchRelatedMaster(e)
		{ 
		    
	     if (!e) var e = window.event; 
    	if (e.keyCode == 13) 
		 {	
 
		  doSearchMaster();
		  
		  return false; 
		 }		
       }	   
       
	function doSearchMaster()
    {
	    srch=document.getElementById('ctl00_searchRelatedText').value;	  	    
		ToggleSearch('Search',true,'/search.aspx?q='+srch);  
    } 
   
   	  function searchRelatedClassicMaster(e)
		{ 
		    
	     if (!e) var e = window.event; 
    	if (e.keyCode == 13) 
		 {	
 
		  doSearchClassicMaster();
		  
		  return false; 
		 }		
       }	   
       
	function doSearchClassicMaster()
    {
	    srch=document.getElementById('searchRelatedText').value;	  	    
		ToggleSearch('Search',true,'/search.aspx?q='+srch);  
    }  

 function WriteUpAdsenseTracker()
{ 
  
	var elements; 
	elements = document.getElementsByTagName("iframe"); 
	for (var i = 0; i < elements.length; i++) 
		{ 
		if(elements[i].src.indexOf('googlesyndication.com') > -1) 
			{ 
				elements[i].attachEvent("onfocus",log) 
				iFr=elements[i];
				 
			} 
		} 
}

function ShowRemoteAds()
{
 
  
   try
   {  
   
       if (document.getElementById('iframeSearch').src.substring(0,4)=='http')
       {
           window.location.href = 'http://www.eggheadcafe.com/default.aspx';
       }
    }
    catch (exception) { }  
       
}

function ToggleSearch(uniqueID,show,url)
{
 
  var img;
  var div;
  var hiddenDIV;
  
   try
   {
 
	div = document.getElementById('Card_' + uniqueID);
    hiddenDIV = document.getElementById('CardHidden_' + uniqueID);
 
    if (!show) 
    {  
      div.innerHTML = '';  
      div.style.height='5px'; 
	  div.style.visibility = 'hidden';
	  return;
	}

	div.style.height='500px'; 
	div.style.visibility = 'visible';
    div.innerHTML = hiddenDIV.innerHTML;  
	document.getElementById('iframeSearch').src = url;
 
    }
    catch (exception)  { alert(exception.message);  }   
}
 

function queryString(item, source)
{
var itemLoc=source.indexOf(item);
var newSrc=source.substring(itemLoc);
var endLoc=newSrc.indexOf("&");
 var lstSrc=newSrc.substring(0,endLoc);
 var itm=lstSrc.substring(item.length+1);
 return itm;
} 



   var winprint;

   var imgMerit0 = new Image();
       imgMerit0.src = "/graphics/merit0.gif";
   var imgMerit1 = new Image();
       imgMerit1.src = "/graphics/merit1.gif";
   var imgMerit2 = new Image();
       imgMerit2.src = "/graphics/merit2.gif";
   var imgMerit3 = new Image();
       imgMerit3.src = "/graphics/merit3.gif";
	
	

function LaunchMeritPopUp(meritID,postID) 
{ 
   var sOption='toolbar=yes,location=no,directories=yes,menubar=yes,'; 
       sOption+='scrollbars=yes,width=150,height=100,left=100,top=25'; 
       
   var url = '/forummeritmanagement.aspx?forumpostid=' + postID + '&meritid=' + meritID;

 
   CloseMeritPopUp(0,0);
    
   winprint=window.open(url,"",sOption); 
}

function DeletePost(postID)
{
   if (!confirm('Are you sure you want to delete this post?'))
   {
     return;
   }
    window.location.href = '/admin/killpost.asp?id=' + postID;
}

function CloseMeritPopUp(postID,meritID)
{
   var elem;

 

   try
   {
 
      if (parseFloat(postID) < 1)
	  {
	    winprint.close();
		return;
	  }
      
	  elem = document.getElementById('ctl00_MiddleContent_imgPost' + postID);
	  
	  switch (parseFloat(meritID))
	  {

	    case 1:
		           elem.src = imgMerit1.src;
				   break;
	    case 2:
		           elem.src = imgMerit2.src;
				   break;
		case 3:
		           elem.src = imgMerit3.src;
				   break;
		default:
	 
		       elem.src = imgMerit0.src;
			   break;
	  }
	  
      winprint.close();
   }
	catch (exception) {   }
	
}


 