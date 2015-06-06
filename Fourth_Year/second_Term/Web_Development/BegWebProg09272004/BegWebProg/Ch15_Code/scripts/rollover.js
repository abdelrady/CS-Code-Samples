if (document.images) {
  image1on = new Image();
  image1on.src = "images/home_on.gif";

  image2on = new Image();
  image2on.src = "images/products_on.gif";

  image3on = new Image();
  image3on.src = "images/services_on.gif";


  image1off = new Image();
  image1off.src = "images/home.gif";

  image2off = new Image();
  image2off.src = "images/products.gif";

  image3off = new Image();
  image3off.src = "images/services.gif";

}

function changeImages() {
 if (document.images) {
  for (var i=0; i<changeImages.arguments.length; i+=2) {
   document[changeImages.arguments[i]].src = 
     eval(changeImages.arguments[i+1] + ".src");
    }
  }
}