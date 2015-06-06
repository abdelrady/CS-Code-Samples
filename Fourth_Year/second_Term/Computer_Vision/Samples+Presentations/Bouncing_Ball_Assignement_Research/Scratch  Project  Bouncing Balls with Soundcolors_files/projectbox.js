//scrollToFit()
//scrolls the project page to accomodate for applet
function scrollToFit() {
	var arrayPageSize = getPageSize();
	var arrayPageScroll = getPageScroll();
	
	scroll(0, 400);
}

//
// getPageScroll()
// Returns array with x,y page scroll values.
// Core code from - quirksmode.org
//
function getPageScroll(){

	var yScroll;

	if (self.pageYOffset) {
		yScroll = self.pageYOffset;
	} else if (document.documentElement && document.documentElement.scrollTop){	 // Explorer 6 Strict
		yScroll = document.documentElement.scrollTop;
	} else if (document.body) {// all other Explorers
		yScroll = document.body.scrollTop;
	}

	arrayPageScroll = new Array('',yScroll) 
	return arrayPageScroll;
}

//
// getPageSize()
// Returns array with page width, height and window width, height
// Core code from - quirksmode.org
// Edit for Firefox by pHaez
//
function getPageSize(){
	
	var xScroll, yScroll;
	
	if (window.innerHeight && window.scrollMaxY) {	
		xScroll = document.body.scrollWidth;
		yScroll = window.innerHeight + window.scrollMaxY;
	} else if (document.body.scrollHeight > document.body.offsetHeight){ // all but Explorer Mac
		xScroll = document.body.scrollWidth;
		yScroll = document.body.scrollHeight;
	} else { // Explorer Mac...would also work in Explorer 6 Strict, Mozilla and Safari
		xScroll = document.body.offsetWidth;
		yScroll = document.body.offsetHeight;
	}
	
	var windowWidth, windowHeight;
	if (self.innerHeight) {	// all except Explorer
		windowWidth = self.innerWidth;
		windowHeight = self.innerHeight;
	} else if (document.documentElement && document.documentElement.clientHeight) { // Explorer 6 Strict Mode
		windowWidth = document.documentElement.clientWidth;
		windowHeight = document.documentElement.clientHeight;
	} else if (document.body) { // other Explorers
		windowWidth = document.body.clientWidth;
		windowHeight = document.body.clientHeight;
	}	
	
	// for small pages with total height less then height of the viewport
	if(yScroll < windowHeight){
		pageHeight = windowHeight;
	} else { 
		pageHeight = yScroll;
	}

	// for small pages with total width less then width of the viewport
	if(xScroll < windowWidth){	
		pageWidth = windowWidth;
	} else {
		pageWidth = xScroll;
	}


	arrayPageSize = new Array(pageWidth,pageHeight,windowWidth,windowHeight) 
	return arrayPageSize;
}


//
// initLightbox()
// Function runs on window load, going through link tags looking for rel="lightbox".
// These links receive onclick events that enable the lightbox display for their targets.
// The function also inserts html markup at the top of the page which will be used as a
// container for the overlay pattern and the inline image.
//
function initProjectbox()
{
	initLinks();
	var objBody = document.getElementsByTagName("body").item(0);
	
	//var arrayPageSize = getPageSize();
	//var arrayPageScroll = getPageScroll();

	// create lightbox div, same note about styles as above
	var objHanbox = document.getElementById("gallerybox");
	if (objHanbox == null) {
	
	} else {
		objHanbox.setAttribute('id','gallerybox');
		objHanbox.style.display = 'none';
		objHanbox.style.zIndex = '5100';	
	}
}

//
// showAddbox()
// Preloads images. Pleaces new image in lightbox then centers and displays.
//
function showGallerybox()
{
	var objAddBox = document.getElementById('gallerybox');
	
	objAddBox.style.width = 480 + 'px';
	objAddBox.style.height = 150 + 'px';
	if (objAddBox.style.display == 'none') {
		objAddBox.style.display = 'block';
	} else {
		objAddBox.style.display = 'none';
	}
}

function initLinks() {
	var objAdd = document.getElementById('gallery_project_add');
	
	
	if (objAdd == null) {
	
	} else {
		objAdd.onclick = function () {showGallerybox(); return false;};
	}
}

function hideGallerybox() {
	objAddBox = document.getElementById('gallerybox');
	
	objAddBox.style.display = 'none';
}

//
// addLoadEvent()
// Adds event to window.onload without overwriting currently assigned onload functions.
// Function found at Simon Willison's weblog - http://simon.incutio.com/
//
function addLoadEvent(func)
{	
	var oldonload = window.onload;
	if (typeof window.onload != 'function'){
    	window.onload = func;
	} else {
		window.onload = function(){
		oldonload();
		func();
		}
	}
}