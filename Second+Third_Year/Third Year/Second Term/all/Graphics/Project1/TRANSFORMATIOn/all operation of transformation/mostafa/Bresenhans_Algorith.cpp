#ÒÜÆØêÈÊxîÒÜÈÞîæ\Ð|˜¤Š¦ª˜¨@†‚˜˜„‚†–@®ÜÈ äÞÆP®œˆX@ª’œ¨X@® ‚¤‚šX@˜ ‚¤‚šRvæèÂèÒÆ@ÆÐÂä@Îæô†ØÂææœÂÚÊ¶º@z@Dšò®ÒÜÈÞî†ØÂææDvæèÂèÒÆ@’œ¦¨‚œ†Š@ÎÐ’ÜæèÂÜÆÊ@z@œª˜˜vÒÜè@®’œ‚ ’@®ÒÜšÂÒÜP’œ¦¨‚œ†Š@Ð’ÜæèÂÜÆÊX@’œ¦¨‚œ†Š@Ð äÊì’ÜæèÂÜÆÊX@˜ ¦¨¤@@@@Øà†ÚÈ˜ÒÜÊX@ÒÜè@Ü†ÚÈ¦ÐÞîRö®œˆ†˜‚¦¦Š°@®ÜÈ†ØÂææv®œˆ@ÐîÜÈvš¦Ž@šæÎvÎÐ’ÜæèÂÜÆÊ@z@Ð’ÜæèÂÜÆÊv®ÜÈ†ØÂææ\ÆÄ¦ÒôÊ@z@æÒôÊÞÌP®œˆ†˜‚¦¦Š°Rv®ÜÈ†ØÂææ\æèòØÊ@z@œª˜˜v®ÜÈ†ØÂææ\ØàÌÜ®ÜÈ äÞÆ@z@®ÜÈ äÞÆv®ÜÈ†ØÂææ\ÆÄ†ØæŠðèäÂ@z@`v®ÜÈ†ØÂææ\ÆÄ®ÜÈŠðèäÂ@z@`v®ÜÈ†ØÂææ\Ð’ÜæèÂÜce = ghInstance;
	WndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	WndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	WndClass.hbrBackground = (HBRUSH) (COLOR_WINDOW+1);
	WndClass.lpszMenuName = NULL;
	WndClass.lpszClassName = gszClassName;
	WndClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

	if(!RegisterClassEx(&WndClass) )
	{
		MessageBox( 0, "Window Registration Failed ! " , "Error!",
			 MB_ICONSTOP | MB_OK );
		return 0;
	}

	hwnd = CreateWindowEx( WS_EX_STATICEDGE, gszClassName, "Window Title", 
				WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT,
				 320, 240, NULL, NULL, ghInstance, NULL);
	if(hwnd == NULL)
	{
		MessageBox(0, "Window Creation Failed", "Error!",
			 MB_ICONSTOP | MB_OK );
		return 0;
	}

	ShowWindow( hwnd, nCmdShow);
	UpdateWindow(hwnd);
	while( GetMessage(&Msg, NULL, 0, 0) )
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}
	return Msg.wParam;
}

//=============================================================
/******* The bresenhans algorithm *******/
/*void bresenhans_Algorithm(int x1,int y1,int x2,int y2,HDC hdc)
{
	int x,y,x_end,y_end;
	COLORREF col=RGB(250,0,0);
	
	int dx=x2-x1;
	int dy=y2-y1;
	float m=float(dy)/dx;

	if(abs(m)>0&&abs(m)<1)
	{
		int inc1=2*dy;
		int inc2=2*(dy-dx);
		int d=inc1-dx;
  
		if(dx<0)
		{
			x=x2;    y=y2;    x_end=x1;
		}
		else
		{
			x=x1;   y=y1;     x_end=x2;
		}
		
		SetPixel(hdc,x,y,col);
		
		while(x<x_end)
		{
			x=x+1;
			if(d<0)
				d=d+inc1;
			else
			{
				d=d+inc2;
				y=y+1;
			}				
			SetPixel(hdc,x,y,col);			
		}
	}
	//----------
	else
	{
		int inc1=2*dx;
		int inc2=2*(dx-dy);
		int d=inc1-dy;
  
		if(dy<0)
		{
			x=x2;    y=y2;    y_end=y1;
		}
		else
		{
			x=x1;   y=y1;     y_end=y2;
		}
		
		SetPixel(hdc,x,y,col);
		
		while(y<y_end)
		{			
			y=y+1;
			if(d<0)
				d=d+inc1;
			else
			{
				d=d+inc2;
				x=x+1;
			}		
			
			SetPixel(hdc,x,y,col);
			
		}
	}
}*/
//***************************
//=============================================================
/**************** The bresenhans algorithm *******************/
void bresenhans_Algorithm(int x1,int y1,int x2,int y2,HDC hdc)
{
	COLORREF col=RGB(250,0,0); int i;
	int x,y,x_end,y_end;
	
	int dx=x2-x1;
	int dy=y2-y1;
	float m=float(dy)/dx;

	if(dx==0){
		for(i=0;i<=dy;i++)
			SetPixel(hdc,x1,min(y1,y2)+i,col);
		return;
	}
	if(dy==0){
		for(i=0;i<=dx;i++)
			SetPixel(hdc,min(x1,x2)+i,y1,col);
		return;
	}

	if(abs(m)>=1)
	{
		if(dy<0)
		{
			int inc1=2*dx;
			int inc2=2*(dx-abs(dy));
			int d=inc1-dy;
			x=x2;    y=y2;    y_end=y1;
			SetPixel(hdc,x,y,col);
	
			while(y<y_end&& x2>x1)
			{
				y=y+1;
				if(d<0)
					d=d+inc1;
				else
				{
					d=d+inc2;
					x=x-1;
				}		
				SetPixel(hdc,x,y,col);
			}
			while(y<y_end)
			{
				y=y+1;
				if(d<0)
					d=d+inc1;
				else
				{
					d=d+inc2;
					x=x+1;
				}		
				SetPixel(hdc,x,y,col);
			}
		}
		else
		{
			int inc1=2*dx;
			int inc2=2*(dx-dy);
			int d=inc1-dy;
			x=x1;   y=y1;     y_end=y2;
			SetPixel(hdc,x,y,col);
	
			while(y<y_end)
			{
			    y=y+1;
				if(d<0)
					d=d+inc1;
				else
				{
					d=d+inc2;
					x=x+1;
				}		
				SetPixel(hdc,x,y,col);
			}
		}
		
		

	}
	else
	//if(m>0&&m<1)
	{
		int inc1=2*dy;
		int inc2=2*(dy-dx);
		int d=abs(inc1)-dx;

		if(dx<0)
		{
			x=x2;    y=y2;    x_end=x1;
			SetPixel(hdc,x,y,col);
		
			while(x<x_end)
			{
				x=x+1;
				if(d<0)
					d=d+inc1;
				else
				{
					d=d+inc2;
					y=y+1;
				}		
				SetPixel(hdc,x,y,col);
			}
		}
		else
		{
			x=x1;   y=y1;     x_end=x2;
			SetPixel(hdc,x,y,col);
		
			while(x<x_end)
			{
				x=x+1;
				if(d<0)
					d=d+inc1;
				else
				{
					d=d+inc2;
					y=y+1;
				}		
				SetPixel(hdc,x,y,col);
			}
		}
		
	/*	SetPixel(hdc,x,y,col);
		
		while(x<x_end)
		{
		    x=x+1;
			if(d<0)
				d=d+inc1;
			else
			{
				d=d+inc2;
				y=y+1;
			}		
			SetPixel(hdc,x,y,col);
			//////////////
			for(i=0;i<100;i++)
			SetPixel(hdc,(int)100+i,(int)100+i,col);
			////////////
		}*/
	}
	
}
//*********************************************************
int x1,x2,y1,y2;
LRESULT CALLBACK WndProc(HWND hwnd, UINT Message, WPARAM wParam,
						 LPARAM lParam)
{
	HDC hdc;
	switch(Message)
	{
		case WM_CLOSE :
			DestroyWindow(hwnd);
			break;
		case WM_DESTROY :
			PostQuitMessage(0);
			break;

		case WM_LBUTTONDOWN:
			hdc=GetDC(hwnd);
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
            bresenhans_Algorithm(x1,y1,x2,y2,hdc);
			ReleaseDC(hwnd,hdc);
			break;
		case WM_RBUTTONDOWN:
			hdc=GetDC(hwnd);
			x1=LOWORD(lParam);
			y1=HIWORD(lParam);
            //DDA_Algorithm(hdc,x1,y1,x2,y2);
			ReleaseDC(hwnd,hdc);
			break;
		
		default:
			return DefWindowProc(hwnd, Message, wParam, lParam);
	}
	return 0;
}



