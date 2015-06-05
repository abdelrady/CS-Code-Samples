
/* Written by Christopher McCoy */
/* June 18, 2007 */

var scrollerInterval = false;
var scrollerDirection = 1;
//this value dictates how long the scrolling list stops at each end, must be at least 0
var scrollerEndPause = 5;
//higher numbers make the scroller slower, must be at least 1
var scrollSpeed = 200;
var scrollerPosition = scrollerEndPause * -1;

function resumeScroll() {
   if (!scrollerInterval) {
      scrollerInterval = setInterval("scrollDiv()", scrollSpeed);
   }
}

function stopScroll() {
   if (scrollerInterval) {
      clearInterval(scrollerInterval);
      scrollerInterval = false;
   }
}

function scrollDiv() {
   var scrollerContainer = document.getElementById("scrollerContainer");
   if (scrollerContainer) {
      scrollerPosition += scrollerDirection;
      //if we're at the end of the scroller, change the scrolling direction
      if ((scrollerPosition >= scrollerContainer.scrollTop + scrollerEndPause) || (scrollerPosition == scrollerEndPause * -1)) {
         scrollerDirection = scrollerDirection * -1;
      }
      scrollerContainer.scrollTop = scrollerPosition;
   }
}

window.onload = function () {
   resumeScroll();
   //you can add your other onload functions here
   document.getElementById('scrollerContainer').onmouseover = stopScroll;
   document.getElementById('scrollerContainer').onmouseout = resumeScroll;
};

window.onblur = function () {
   stopScroll();
   //you can add other blur functions here
}

window.onfocus = function () {
   resumeScroll();
   //you can add other focus functions here
}
