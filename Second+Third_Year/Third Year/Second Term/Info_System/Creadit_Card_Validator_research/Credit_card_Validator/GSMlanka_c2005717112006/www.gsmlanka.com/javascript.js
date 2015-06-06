//Coloured mouseovers on left navs
function colorOn(id,nobg) {
	if(nobg != 1) {
		id.className='navtopdark';
	}
	id.style.cursor='hand';
	id.children.tags("A")[0].style.color='#777777'; 
        var html = id.innerHTML;
        if(html.match(/href="([^"]+)"/)) {
                var url = RegExp.$1;
                window.status = url;
        }		
}

//Coloured mouseovers on left navs
function colorOff(id,nobg){
	if(nobg != 1) {
		id.className='navtendark99';
		id.children.tags("A")[0].className='leftlink2';
	}
	id.children.tags("A")[0].style.color='';
	window.status = '';
}


//Coloured mouseovers on top navs
function colorOnTop(id,nobg) {
	if(nobg != 1) {
		id.className='navtoplight1';
	}
	id.style.cursor='hand';
	id.children.tags("A")[0].style.color='#777777'; 
        var html = id.innerHTML;
        if(html.match(/href="([^"]+)"/)) {
                var url = RegExp.$1;
                window.status = url;
        }		
}
//Coloured mouseovers on left navs
function colorOff(id,nobg){
	if(nobg != 1) {
		id.className='navtendark';
		id.children.tags("A")[0].className='leftlink2';
	}
	id.children.tags("A")[0].style.color='';
	window.status = '';
}

//Coloured mouseovers on top navs
function colorOnTop(id,nobg) {
	if(nobg != 1) {
		id.className='navtoplight';
	}
	id.style.cursor='hand';
	id.children.tags("A")[0].style.color='#CC0000'; 
        var html = id.innerHTML;
        if(html.match(/href="([^"]+)"/)) {
                var url = RegExp.$1;
                window.status = url;
        }		
}

//Coloured mouseovers on top navs
function colorOffTop(id,nobg){
	if(nobg != 1) {
		id.className='navtopdark';
		id.children.tags("A")[0].className='leftlink';
	}
	id.children.tags("A")[0].style.color='';
	window.status = '';
}



//Coloured mouseovers on top navs1
function colorOffTop(id,nobg){
	if(nobg != 1) {
		id.className='navtopdark1';
		id.children.tags("A")[0].className='toplink1';
	}
	id.children.tags("A")[0].style.color='';
	window.status = '';
	
}
function colorOffTop2(id,nobg){
	if(nobg != 1) {
		id.className='navtopdark99';
		id.children.tags("A")[0].className='toplink1';
	}
	id.children.tags("A")[0].style.color='';
	window.status = '';
	
}


//Coloured mouseovers on navs
function jump(id) {
	var html = id.innerHTML;
	if(html.match(/href="([^"]+)"/)) {
		var url = RegExp.$1;
		url = url.replace("amp;","");
		var win = window.open(url,"_top");
	}
}


