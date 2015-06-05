/* The Javascript code in this document is copyrighted. Infringers of copyright will be prosecuted. */

function j0()
{
	if (top.frames.length>1) {
		document.write('<TABLE CELLSPACING=8 BGCOLOR=#FFFFFF BORDER=0><TR><TD><FONT STYLE="font-size:10pt; font-weight:bold;"><A HREF="http://www.websudoku.com/" TARGET="_top">www.websudoku.com</A></FONT></TD></TR></TABLE>');
	}
}

function j1()
{	
	if (!document.getElementById) 
		return true;

	p=new Array(9);
	a=new Array(9);
	m=new Array(9);
	
	for (x=0; x<9; x++) {
		p[x]=new Array(9);
		a[x]=new Array(9);
		m[x]=new Array(9);
	}
	
	c=0;
	h=cheat;

	for (x=0; x<9; x++) {
		for (y=0; y<9; y++) {
			e=document.getElementById('f'+x+y);
			v=parseInt(e.value);
			
			if ((e.value.length==1)&&(v>=1)&&(v<=9)) {
				p[x][y]=v;
				if (!e.readOnly)
					c++;
					
			} else
				p[x][y]=0;
			
			v=parseInt(h.charAt(y*9+x));
			
			if ((v>=1)&&(v<=9))
				a[x][y]=v;
			else
				a[x][y]=0;
		
			m[x][y]=0;
		}
	}
		
	for (x=0; x<9; x++) {
		s=new Array(10);
		k=false;
		
		for (y=0; y<9; y++)
			if (p[x][y]>0) {
				if (s[p[x][y]])
					k=true;
				else
					s[p[x][y]]=true;
			}
		
		if (k)
			for (y=0; y<9; y++)
				m[x][y]++;
	}
	
	for (y=0; y<9; y++) {
		s=new Array(10);
		k=false;
		
		for (x=0; x<9; x++)
			if (p[x][y]>0) {
				if (s[p[x][y]])
					k=true;
				else
					s[p[x][y]]=true;
			}
		
		if (k)
			for (x=0; x<9; x++)
				m[x][y]++;
	}
	
	for (i=0; i<3; i++)
		for (j=0; j<3; j++) {
			s=new Array(10);
			k=false;
			
			for (x=i*3; x<(i*3+3); x++)
				for (y=j*3; y<(j*3+3); y++)
					if (p[x][y]>0) {
						if (s[p[x][y]])
							k=true;
						else
							s[p[x][y]]=true;
					}
			
			if (k)
				for (x=i*3; x<(i*3+3); x++)
					for (y=j*3; y<(j*3+3); y++)
						m[x][y]++;
		}
	
	t=0;
	w=0;
	n=0;
	
	for (x=0; x<9; x++) {
		for (y=0; y<9; y++) {
			s=m[x][y];

			if (w_c)
				if ((p[x][y]>0)&&(a[x][y]>0))
					if (p[x][y]!=a[x][y]) {
						w++;
						
						if (w_s)
							s++;
					}

			if (s>3)
				s=3;
			
			t+=m[x][y];

			e=document.getElementById('f'+x+y);
			e.className=e.className.charAt(0)+s;
			e=document.getElementById('c'+x+y);
			e.className=e.className.charAt(0)+s;
			
			if (p[x][y]==0)
				n++;
		}
	}
	
	if (t>0) {
		g=m_m;
		document.getElementById('errors').value++;

	} else if (w>0) {
		g=m_w;
		g=g.replace('*', w);
		document.getElementById('errors').value++;

	} else if (n>0) {
		if (c>0) {
			g=m_i;
			g=g.replace('*', n);
		} else
			g=m_d;
	
	} else {
		document.getElementById('jscheat').value=cheat;
		return true;
	}
		
	document.getElementById('message').innerHTML=g;	
	
	j13();
	
	return false;
}

function j2()
{
	if (!document.getElementById) 
		return true;

	for (x=0; x<9; x++) {
		for (y=0; y<9; y++) {
			e=document.getElementById('f'+x+y);

			if (!e.readOnly)
				e.value='';
			
			e.className=e.className.charAt(0)+'0';
			
			e=document.getElementById('c'+x+y);
			e.className=e.className.charAt(0)+'0';
		}
	}
	
	document.getElementById('message').innerHTML=m_c;
	
	return false;
}

var t_o=0;

function j3(t)
{
	document.onkeydown=j6;
	window.onbeforeunload=j11;
	
	if (t>=0) {
		d=new Date();
		t_o=d.getTime()/1000-t;
		j4();
	}
	
	var ua=navigator && navigator.userAgent; /* back bug fix */
	if (ua && (ua.toLowerCase().indexOf('safari')>=0)) {
		j10('cheat', cheat);
		j10('prefix', prefix);
		j10('pid', pid);
	}
}

function j4()
{
	if (document.getElementById('timer'))
		if (t_o>0) {
			d=new Date();
			t=Math.round(d.getTime()/1000-t_o);
			m=Math.floor(t/60);
			s=t%60;
			
			document.getElementById('timer').innerHTML='&nbsp;<B>'+m+':'+((s<10) ? '0' : '')+s+'</B>&nbsp;';
			setTimeout("j4()", 1000);
			document.getElementById('jstimer').value=t;
		}
}

function j5(f)
{	
	if (f.value.length>3) {
		f.className='v'+f.className.substr(1,10);
	} else if (f.value.length>1) {
		f.className='w'+f.className.substr(1,10);
	} else {
		f.className='d'+f.className.substr(1,10);
	}
}

function j6(e)
{
	if (!e) e=window.event;
	
	t=e.target ? e.target : e.srcElement;
	
	if (t) {
		k=e.keyCode;
		i=t.id;
		
		if ((i.charAt(0)=='f')&&(k>=37)&&(k<=40)) {
			g=true;
			
			if ((k%2)&&(!t.readOnly)) {
				dx=k-38;
				l=t.value.length;
				
				if (l>0) {
					if (t.selectionStart || t.selectionStart=='0') {
						sp=t.selectionStart;
						ep=t.selectionEnd;
					} else if (document.selection && document.selection.createRange) {
						r=document.selection.createRange();
						sl=r.text.length;
						r.moveStart('character', -l);
						ep=r.text.length;
						sp=ep-sl;
					} else
						g=false;
						
					if ((dx<0)&&(ep>0))
						g=false;
						
					if ((dx>0)&&(sp<l))
						g=false;
				}
			}
			
			if (g) {
				x=parseInt(i.charAt(1));
				y=parseInt(i.charAt(2));
				
				for (r=1; r<9; r++) {
					if (k%2)
						x=(9+x+k-38)%9;
					else
						y=(9+y+k-39)%9;
					
					n=document.getElementById('f'+x+y);
					
					if (n) {
						n.select();
						if (n.readOnly) {
							if (n.setSelectionRange) {
								n.focus();
								n.setSelectionRange(0, 1);
							} else {
								r=n.createTextRange();
								r.collapse(true);
								r.moveStart('character', 0);
								r.moveEnd('character', 1);
								r.select();
							}
						}
					}		
				
					if (window.event) {
						window.event.cancelBubble=true; 
					}

					if (e.stopPropagation)
						e.stopPropagation();
						
					break;
				}
			}
		}
	}
}

function j7(i)
{
	if (i==1)
		s="Are you sure you want to reset the statistics for this level?";
	else if (i==2)
		s="Are you sure you want to clear the puzzle?";
	else
		s="Are you sure?";
		
	var c=confirm(s);
	
	if ((i==2) && !c)
		j13();
	
	return c;
}

function j8(f)
{
	s="         ";
	
	if (f.value.length>0)
		if (f.value==s.substring(0, f.value.length))
			f.value="";
}

function j9(u, w, h)
{
	var l=(self.screen.width-w)/2;
	var t=(self.screen.height-h)/2;
	
	var nw=window.open(u, 'ws_pop', 'height='+h+',width='+w+',left='+l+',top='+t);
	if (nw&&nw.focus)
		nw.focus();
		
	return !nw;
}

function j10(i,s)
{
	var e=document.getElementById(i);
	if (e && s)
		e.value=s;
}

function j11(e)
{
	if (s_c)
		for (x=0; x<9; x++)
			for (y=0; y<9; y++) {
				var c=document.getElementById('f'+x+y);
				if ( c && (!c.readOnly) && (c.value.length>0) ) {
					e=e||window.event;
					var m='You appear to be in the middle of a Sudoku puzzle and your hard work will be lost!';
					e.returnValue=m;
					return m;
				}
			}
}

var o_s_c;

function j12()
{
	o_s_c=s_c;
	s_c=false;
	return true;
}

function j13()
{
	s_c=o_s_c;
}