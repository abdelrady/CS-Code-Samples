// Copyright (c) 2008, The Code Project. All rights reserved.
var prevVal = null,timeoutId = null,slp=200,inproc=false;
function ApplyFilter(name,title){
	var filter = document.getElementById(title);
	if(timeoutId)
		window.clearTimeout(timeoutId);
	if(filter){   
		timeoutId = setTimeout("ShowFilteredArticles('" + filter.value + "','" + name + "')", slp);
	}
}

function ShowFilteredArticles(value, name)
{
	if(inproc) return;
	if(prevVal == value) return; else prevVal = value;
	inproc=true;
	var row,elems = document.getElementsByName(name);
	if(elems){
		var words = value.split(" ");
		var res = new Array(); 
		for(var i=0;i<words.length;i++)
			if (words[i].replace(" ","").length>0) 
				res.push(new RegExp("(?:.)*" + words[i] + "(?:.)*", "i"));

		for(var i = 0; i < elems.length; i++){
			var title = elems[i].innerHTML;
			var matched=true;
			if (res.length > 0) 
				for(var j=0;j<res.length;j++) if (!res[j].test(title)) {matched=false;break;}
			if(matched){
				row = elems[i].parentNode;
				while(row && row.tagName != "TR")row = row.parentNode;
				if(row && row.tagName == "TR")row.style.display = "";	
			}
			else{
				row = elems[i].parentNode;
				while(row && row.tagName != "TR")row = row.parentNode;
				if(row && row.tagName == "TR")row.style.display = "none";
			}
		}
	}
	inproc=false;
}