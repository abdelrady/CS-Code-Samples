/*
LEAVE THIS NOTICE IN PLACE
FI Image Resizing script - Daz - ForumImages.com
For use and distribution terms please check;
http://www.forumimages.com/terms.php

Modifications by Politics.be
-- Onclick handler is automatically handled bij JavaScript now, compatible with IE and Mozilla
*/
var imgResizeMsg = '«÷€ÿ ⁄·Ï Â–Â «·’Ê—… «·„’€—… ·„‘«Âœ Â« »ÕÃ„Â« «·√’·Ì';
var imgWidthMax = 430;
var imgWidthSizeTo = 350;
var imgClassName = 'imglimit';
//window.onload = fiImageResize;

function fiImageResize() {
if (document.images.length) {
var docImg = document.images;
   for ( var i = 0 ; i < docImg.length ; i++)
      if (docImg[i].width > imgWidthMax && docImg[i].id != 'forumlogo') {
         docImg[i].width = imgWidthSizeTo;
         docImg[i].title = imgResizeMsg;
         docImg[i].className = imgClassName;
         docImg[i].onclick = fiImageWinOpen;
      }
   }
}

function fiImageWinOpen(e) {
	if( window.event )
	   window.open(window.event.srcElement.src,'PoliticsViewer','menubar=no, toolbar=no, location=no, directories=no, fullscreen=no, titlebar=yes, hotkeys=no, status=no, scrollbars=yes, resizable=yes');
	else
	   window.open(e.target.src,'PoliticsViewer','menubar=no, toolbar=no, location=no, directories=no, fullscreen=no, titlebar=yes, hotkeys=no, status=no, scrollbars=yes, resizable=yes');
}