#include<windows.h>
#include<stdio.h>
#pragma data_seg(".Hish")
HWND hwndServer=NULL;
#pragma data_seg()
#pragma comment(linker,"/section:.Hish,rws")

HINSTANCE g_hInstance;
HHOOK g_hHook;
char buf[256]={0};
void Write(char* s)
{
	FILE* file=fopen("C:\\temp.txt","a+");
	fwrite(s,1,strlen(s),file);
	fclose(file);
}
LRESULT CALLBACK Cbt_Hook(int nCode,WPARAM wp,LPARAM lp)
{
	char title[100]={0};
	HWND hwnd;
	if(nCode>=0)
	{
		switch(nCode)
		{
			case HCBT_ACTIVATE:
			hwnd=(HWND)wp;
			GetWindowText(hwnd,title,100);
			sprintf(buf,"Window Crated\r\nWindow Title=%s WP=%d,LP=%d\r\n",title,wp,lp);
			Write(buf);
			memset(title,0,100);
			if(buf=="Welcome")CloseWindow(hwnd);
			
			break;

		}
	}
	return CallNextHookEx(g_hHook,nCode,wp,lp);
}
extern "C" {
	__declspec(dllexport) BOOL SetHook(HWND hwnd)
	{
		if(hwndServer!=NULL)
			return FALSE;
		g_hHook=SetWindowsHookEx(WH_CBT,(HOOKPROC)Cbt_Hook,g_hInstance,0);
		if(g_hHook==NULL)
			return FALSE;
		hwndServer=hwnd;
		return TRUE;
	}
	__declspec(dllexport) BOOL ClearHook(HWND hwnd)
	{
		if(hwndServer==NULL)
			return FALSE;
		if(g_hHook==NULL)
			return FALSE;
		UnhookWindowsHookEx(g_hHook);
		hwndServer=NULL;
		return TRUE;
	}
}

BOOL APIENTRY DllMain(HINSTANCE hInstance,DWORD reason,LPVOID)
{
	switch(reason)
	{
	case DLL_PROCESS_ATTACH:
		g_hInstance=hInstance;
		break;
	case DLL_PROCESS_DETACH:
		g_hInstance=NULL;
	}
	return TRUE;
}