var address = document.location.href;
var breadcrumb = "You are here ";
var arrAddress = address.split("/");
document.writeln(address+"<br />")
// you want to start after the second instance of the separator character
for (var i=0; i<(arrAddress.length); i++) {
document.writeln(i+": "+arrAddress[i]+"<br />")
}
for (var i=2; i<(arrAddress.length-1); i++) {
breadcrumb +="<a href=\""+address.substring(0,address.indexOf("/"+arrAddress[i])+arrAddress[i].length+1)+"/\">"+arrAddress[i]+"</a> &gt; ";
}

i=arrAddress.length-1;
//remove the file extension html from the end of the name of the last item
endPos = (arrAddress[i].length -5)
name = arrAddress[i].substring(0,endPos)

breadcrumb +="<a href=\""+address.substring(0,address.indexOf(arrAddress[i])+arrAddress[i].length) +"\">"+name+"</a>";

document.writeln(breadcrumb);