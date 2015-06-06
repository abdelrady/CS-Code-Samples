function hideComment(id){
	var elementID = id.toString();
	var target = document.getElementById(elementID);
	target.style.innerHTML = 'none';
}