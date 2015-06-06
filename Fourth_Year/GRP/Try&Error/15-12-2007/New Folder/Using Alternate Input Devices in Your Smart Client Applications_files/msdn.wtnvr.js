

function dcsNvrRu(){
	if (document.cookie.indexOf("WTLOPTOUT=")!=-1){
		return;
	}
	var gc=function(name){
		var c=document.cookie;
		var pos=c.indexOf(name+"=");
		var start,end;
		if (pos!=-1){
			start=pos+name.length+1;
			end=c.indexOf(";",start);
			if (end==-1){
				end=c.length;
			}
			return c.substring(start,end);
		}
		return null;
	};
	var cur=new Date();
	var exp=new Date(cur.getTime()+315360000000);
	var nvrRu=new DcsNvrRu(gc,exp);
	var nvr=new DcsNvr(gc,exp);
	nvrRu.run();
	nvr.run();
}

function DcsNvrRu(gc,exp){
	var cfg={
		fpcname:"WT_NVR_RU",
		fpcdom:".microsoft.com",
		domlist:"msdn.microsoft.com,msdn2.microsoft.com",		
		pathlist:"",
		paramlist:"DCSext.mtps_devcenter",
		siteid:"MSDN"
	};
	var data=[];

	this.run=function(){
		read();
		var rc=process();
		var c,i,val;
		if (rc){
			c=compose();
			for (i=0;i<c.length;i++){
				document.cookie=c[i];
			}
			val=(document.cookie.indexOf(cfg.fpcname+"=")!=-1)?"1":"2";
			if ((rc&1)||(rc&2)){
				WT.vt_nvr0=val;
			}
			if (rc&4){
				WT.vt_nvr1=val;
			}
		}
	};

	function read(){
		var num=0;
		var value=gc(cfg.fpcname);
		var levels,level,crumbs,curlevel,leveldata;
		while(value){
			levels=value.split(":");
			for (level=0;level<levels.length;level++){
				crumbs=levels[level].split("=");
				curlevel=crumbs[0];
				leveldata=[];
				if (crumbs[1].length>0){
					leveldata=crumbs[1].split("|");
				}
				if (typeof(data[curlevel])!="object"){
					data[curlevel]=leveldata;
				}
				else{
					data[curlevel]=data[curlevel].concat(leveldata);
				}
			}
			num++;
			value=gc(cfg.fpcname+num);
		}
	}

	function process(){
		var rc=0;
		var rudom=getRuDom();
		var rupath=getRuPath();
		var ruparam=getRuParam();
		if (data.length>0){
			if ((rudom.length>0)&&update(0,rudom)){
				rc|=1;
			}
			if ((rupath.length>0)&&update(1,rupath)){
				rc|=2;
			}
			if ((ruparam.length>2)&&updateParam(2,ruparam)){
				rc|=4;
			}
		}
		else{
			if (rudom.length>0){
				data[0]=[rudom];
				rc|=1;
			}
			else{
				data[0]=[];
			}
			if (rupath.length>0){
				data[1]=[rupath];
				rc|=2;
			}
			else{
				data[1]=[];
			}
			if (ruparam.length>0){
				data[2]=[ruparam];
				rc|=4;
			}
			else{
				data[2]=[];
			}
		}
		return rc;
	}

	function compose(){
		var cookies=[];
		var attr={name:cfg.fpcname,value:"",expiry:"; expires="+exp.toGMTString(),path:"; path=/",domain:"; domain="+cfg.fpcdom};
		var num=0;
		var maxval=4000;
		var newcrumb,j;
		for (var i=0;i<data.length;i++){
			newcrumb=i+"=";
			for (j=0;j<data[i].length;j++){
				newcrumb+=((j===0)?"":"|")+data[i][j];
			}
			if (((attr.name+(num||"")).length+attr.value.length+newcrumb.length+1)<=maxval){
				if (attr.value.length>0){
					attr.value+=":";
				}
				attr.value+=newcrumb;
			}
			else{
				cookies[num]=attr.name+(num||"")+"="+attr.value+attr.expiry+attr.path+attr.domain;
				attr.value=newcrumb;
				num++;
			}
		}
		cookies[num]=attr.name+(num||"")+"="+attr.value+attr.expiry+attr.path+attr.domain;
		return cookies;
	}

	function getRuDom(){
		var curdom=getCurDom();
		var doms=getDoms();
		for (var i=0;i<doms.length;i++){
			if (doms[i]==curdom){
				return doms[i];
			}
		}
		return "";
	}

	function getRuPath(){
		var curpath=getCurPath();
		var paths=getPaths();
		for (var i=0;i<paths.length;i++){
			if (curpath.indexOf(paths[i])!=-1){
				return paths[i];
			}
		}
		return "";
	}

	function getRuParam(){
		var params=getParams();
		var value,i,parts;
		for (i=0;i<params.length;i++){
			value=eval(params[i]);
			if (value&&(value.length>0)){
				return params[i]+"&"+value;
			}
		}
		var curparams=getCurParams();
		var pair,j;
		for (i=0;i<curparams.length;i++){
			pair=curparams[i].split("=");
			if (pair.length==2){
				for (j=0;j<params.length;j++){
					if (params[j]==pair[0]){
						return pair[0]+"&"+pair[1];
					}
				}
			}
		}
		return "";
	}

	function update(level,item){
		var items=data[level];
		for (var i=0;i<items.length;i++){
			if (items[i]==item){
				return false;
			}
		}
		data[level][data[level].length]=item;
		return true;
	}

	function updateParam(level,item){
		var pair=item.split("&");
		var param,j;
		for (var i=0;i<data[level].length;i++){
			param=data[level][i].split("&");
			if (param[0]==pair[0]){
				for (j=1;j<param.length;j++){
					if (param[j]==pair[1]){
						return false;
					}
				}
				data[level][i]+="&"+pair[1];
				return true;
			}
		}
		data[level][data[level].length]=pair[0]+"&"+pair[1];
		return true;
	}

	function clipDom(dom, fpcdom){
		var idx=dom?dom.indexOf(fpcdom):-1;
		return (idx!=-1)?dom.substring(0,idx):dom;
	}

	function getCurDom(){
		var dom=clipDom(window.location.hostname.toLowerCase(),cfg.fpcdom.toLowerCase());
		if (dom.length===0){
			dom="www";
		}
		return dom;
	}

	function getDoms(){
		var doms=cfg.domlist.toLowerCase().split(",");
		for (var i=0;i<doms.length;i++){
			doms[i]=clipDom(doms[i],cfg.fpcdom.toLowerCase());
			if (doms[i].length===0){
				doms[i]="www";
			}
		}
		return doms;
	}

	function getPaths(){
		var paths=cfg.pathlist.toLowerCase().split(",");
		var p;
		for (var i=0;i<paths.length;i++){
			p=paths[i];
			if (p.length===0){
				p="/";
			}
			else if (p.length>1){
				if (p.charAt(0)=="/"){
					p=p.substr(1);
				}
				if (p.charAt(p.length-1)=="/"){
					p=p.substr(0,p.length-1);
				}
			}
			if (p.length!=paths[i].length){
				paths[i]=p;
			}
			if (cfg.siteid.length>0){
				paths[i]=cfg.siteid+"&"+paths[i];
			}
		}
		return paths;
	}

	function getCurPath(){
		var p=window.location.pathname;
		p=p.substring(p.indexOf("/")+1,p.lastIndexOf("/")).toLowerCase();
		var badchars={"%09":/\t/g,"%20":/ /g,"%2C":/,/g,"%3B":/;/g};
		for (var ch in badchars){
			p=p.replace(badchars[ch],ch);
		}
		return (cfg.siteid.length>0)?cfg.siteid+"&"+p:p;
	}

	function getCurParams(){
		return (typeof(DCS.dcsqry)!="undefined")?DCS.dcsqry.substring(1).split("&"):[];
	}

	function getParams(){
		return cfg.paramlist.split(",");
	}
}

function DcsNvr(gc,exp){
	var cfg={
		fpcname:"WT_NVR",
		fpcdom:window.location.hostname,
		maxlevel:3
		};
	var data=[];

	this.run=function(){
		read();
		var c,i,val;
		if (process()){
			c=compose();
			for (i=0;i<c.length;i++){
				document.cookie=c[i];
			}
			val=(document.cookie.indexOf(cfg.fpcname+"=")!=-1)?"1":"2";
			for (i=0;i<data.length;i++){
				if (data[i][1]){
					WT["vt_nvr"+(i+2)]=val;
				}
			}
		}
	};

	function read(){
		var num=0;
		var re=/,/g;
		var value=gc(cfg.fpcname);
		var levels,i,crumbs,level,paths;
		while(value){
			levels=value.split(":");
			for (i=0;i<levels.length;i++){
				crumbs=levels[i].split("=");
				level=parseInt(crumbs[0],10);
				paths=crumbs[1].replace(re,"|").split("|");
				if (typeof(data[level])!="object"){
					data[level]=[paths,false];
				}
				else{
					data[level][0]=data[level][0].concat(paths);
				}
			}
			num++;
			value=gc(cfg.fpcname+num);
		}
	}

	function process(){
		var newv=false;
		var curlevel=0;
		var splitp=[];
		var p=window.location.pathname;
		var curpath=p.substring(p.indexOf("/")+1,p.lastIndexOf("/")).toLowerCase();
		var badchars={"%09":/\t/g,"%20":/ /g,"%2C":/,/g,"%3B":/;/g};
		for (var ch in badchars){
			curpath=curpath.replace(badchars[ch],ch);
		}

		if (curpath.length>1){
			splitp=curpath.split("/",cfg.maxlevel);
			curlevel=splitp.length;
			curpath=splitp.join("/");
		}
		var found=false;
		var i;
		if (data.length>0){
			if (data.length>curlevel){
				for (i=0;i<data[curlevel][0].length;i++){
					if (data[curlevel][0][i]==curpath){
						found=true;
						break;
					}
				}
				if (!found){
					data[curlevel][0][data[curlevel][0].length]=curpath;
					data[curlevel][1]=true;
					newv=true;
				}
			}
			else{
				for (i=0;i<(curlevel+1);i++){
					if (typeof(data[i])!="object"){
						data[i]=[[(i===0)?"/":splitp.slice(0,i).join("/")],true];
					}
				}
				newv=true;
			}
		}
		else{
			for (i=0;i<(curlevel+1);i++){
				data[i]=[[(i===0)?"/":splitp.slice(0,i).join("/")],true];
			}
			newv=true;
		}
		return newv;
	}

	function compose(){
		var cookies=[];
		var attr={name:cfg.fpcname,value:"",expiry:"; expires="+exp.toGMTString(),path:"; path=/",domain:"; domain="+cfg.fpcdom};
		var paths=[];
		var num=0;
		var maxnum=10;
		var maxval=4000;
		var maxed=false;
		var newpath,j;
		for (var i=0;(i<data.length)&&!maxed;i++){
			paths=data[i][0];
			newpath=i+"=";
			for (j=0;(j<paths.length)&&!maxed;j++){
				newpath+=((j===0)?"":"|")+paths[j];
				if (((attr.name+num).length+attr.value.length+newpath.length+1)<=maxval){
					if ((attr.value.length>0)&&(j===0)){
						attr.value+=":";
					}
					attr.value+=newpath;
				}
				else if (attr.value.length>0){
					cookies[num]=attr.name+(num||"")+"="+attr.value+attr.expiry+attr.path+attr.domain;
					attr.value=i+"="+paths[j];
					if ((++num)>(maxnum-1)){
						maxed=true;
					}
				}
				newpath="";
			}
		}
		if (!maxed){
			cookies[num]=attr.name+(num||"")+"="+attr.value+attr.expiry+attr.path+attr.domain;
		}
		return cookies;
	}
}


