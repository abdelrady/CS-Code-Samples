function AD_clientWindowSize() {
	var sfMax=0;
	var sf,frameMax;
	var ad=1;
		
	if (self.innerWidth) {
		AD_windowWidth=self.innerWidth;
		AD_windowHeight=self.innerHeight;
	} else if (document.documentElement && document.documentElement.clientWidth) {
		AD_windowWidth=document.documentElement.clientWidth;
		AD_windowHeight=document.documentElement.clientHeight;
	} else if (document.body) {
		AD_windowWidth=document.body.clientWidth;
		AD_windowHeight=document.body.clientHeight;
	}
	if (document.layers||navigator.userAgent.toLowerCase().indexOf("gecko")>=0) AD_windowWidth-=16;

	if ( top !=self || (top.frames.length !=0 && (top.frames.length>self.document.getElementsByTagName('iframe').length) ) ) {
		ad=0;
		if (document.all) {
			sf=(top.document.body.clientWidth * top.document.body.clientHeight) / (self.document.body.clientWidth * self.document.body.clientHeight);
			if (sf<3) {
				ad=1;
			}
		} else {
			function getSurface(w) {
				try{
					if (!w.sf) {
						w.sf=w.innerWidth * w.innerHeight;
					}
					if ( w.sf && (w.sf >=sfMax) ) {
						sfMax=w.sf; frameMax=w;
					}
				}
				catch(err){};
			}
			function findFrameMax(w) {
				var i;
				if (w.frames.length==0) {
					getSurface(w);
				} else {
					for (i=0; i < w.frames.length; i++) {
						if (w.frames[i].frames.length > 0) {
							findFrameMax(w.frames[i]);
						} else {
							getSurface(w.frames[i]);
						}
					}
				}
			}
			if ((top !=self) || (top.frames.length==0)) {
				findFrameMax(top);
				if (frameMax==self) ad=1;
			}
		}
	}
	if (AD_windowWidth<480) ad=0;
	if (AD_windowHeight<80) ad=0;
	return ad;
}
