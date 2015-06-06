//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Drawing;
			using System;
			using System.Runtime.InteropServices;
			using System.Text;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x61467fe65a98f20c
	
	{
		
		#region Constructors
		
			private x61467fe65a98f20c ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			[DllImportAttribute("User32.dll", EntryPoint = "AnimateWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool AnimateWindow (IntPtr hwnd, uint dwTime, uint dwFlags);
			[DllImportAttribute("User32.dll", EntryPoint = "BeginPaint", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr BeginPaint (IntPtr hwnd, [Out] out x40255b11ef821fa3.PAINTSTRUCT lpPaint);
			[DllImportAttribute("User32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CallNextHookEx (IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
			[DllImportAttribute("User32.dll", EntryPoint = "CallWindowProc", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CallWindowProc (xc405cb1a6ec3e1f6 lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
			[DllImportAttribute("User32.dll", EntryPoint = "ClientToScreen", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ClientToScreen (IntPtr hWnd, ref x555516122dcc901e.POINT lpPoint);
			[DllImportAttribute("User32.dll", EntryPoint = "ClientToScreen", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ClientToScreen (IntPtr hWnd, ref Point lpPoint);
			[DllImportAttribute("user32.dll", EntryPoint = "DefWindowProcA", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr DefWindowProcA (IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
			[DllImportAttribute("User32.dll", EntryPoint = "DispatchMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr DispatchMessage (ref x40255b11ef821fa3.MSG lpmsg);
			[DllImportAttribute("User32.dll", EntryPoint = "DrawIconEx", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool DrawIconEx (IntPtr hdc, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, IntPtr hbrFlickerFreeDraw, uint diFlags);
			[DllImportAttribute("User32.dll", EntryPoint = "EndPaint", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool EndPaint (IntPtr hWnd, ref x40255b11ef821fa3.PAINTSTRUCT lpPaint);
			[DllImportAttribute("user32.dll", EntryPoint = "FrameRect", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int FrameRect (IntPtr hDC, ref xae4dd1cafd2eb77c.RECT lprc, IntPtr hbr);
			[DllImportAttribute("user32.dll", EntryPoint = "GetActiveWindow", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetActiveWindow ();
			[DllImportAttribute("user32.dll", EntryPoint = "GetCapture", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetCapture ();
			[DllImportAttribute("User32.dll", EntryPoint = "GetClassLong", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint GetClassLong (IntPtr hWnd, int nIndex);
			[DllImportAttribute("User32.dll", EntryPoint = "GetClassName", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetClassName (IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
			[DllImportAttribute("User32.dll", EntryPoint = "GetClientRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetClientRect (IntPtr hWnd, ref Rectangle lpRect);
			[DllImportAttribute("User32.dll", EntryPoint = "GetClientRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetClientRect (IntPtr hWnd, ref xae4dd1cafd2eb77c.RECT lpRect);
			[DllImportAttribute("user32.dll", EntryPoint = "GetComboBoxInfo", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetComboBoxInfo (IntPtr hwndCombo, ref x40255b11ef821fa3.COMBOBOXINFO cbi);
			[DllImportAttribute("User32.dll", EntryPoint = "GetCursorPos", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetCursorPos (ref Point lpPoint);
			[DllImportAttribute("User32.dll", EntryPoint = "GetDC", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetDC (IntPtr hWnd);
			[DllImportAttribute("user32.dll", EntryPoint = "GetDlgCtrlID", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetDlgCtrlID (IntPtr hwndCtl);
			[DllImportAttribute("user32.dll", EntryPoint = "GetFocus", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetFocus ();
			[DllImportAttribute("User32.dll", EntryPoint = "GetKeyState", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern UInt16 GetKeyState (int virtKey);
			[DllImportAttribute("User32.dll", EntryPoint = "GetMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetMessage (ref x40255b11ef821fa3.MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
			[DllImportAttribute("user32.dll", EntryPoint = "GetMessagePos", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetMessagePos ();
			[DllImportAttribute("user32.dll", EntryPoint = "GetParent", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetParent (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "GetScrollBarInfo", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetScrollBarInfo (IntPtr hwnd, uint idObject, ref x40255b11ef821fa3.SCROLLBARINFO psbi);
			[DllImportAttribute("User32.dll", EntryPoint = "GetScrollInfo", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetScrollInfo (IntPtr hwnd, int fnBar, ref x40255b11ef821fa3.SCROLLINFO lpsi);
			[DllImportAttribute("user32.dll", EntryPoint = "GetScrollRange", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetScrollRange (IntPtr hWnd, int nBar, ref int lpMinPos, ref int lpMaxPos);
			[DllImportAttribute("user32.dll", EntryPoint = "GetSysColor", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetSysColor (int nIndex);
			[DllImportAttribute("User32.dll", EntryPoint = "GetTitleBarInfo", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetTitleBarInfo (IntPtr hwnd, ref x40255b11ef821fa3.TITLEBARINFO pti);
			[DllImportAttribute("User32.dll", EntryPoint = "GetTopWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetTopWindow (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetWindow (IntPtr hWnd, uint wCmd);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowDC", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr GetWindowDC (IntPtr hWnd);
			[DllImportAttribute("user32.dll", EntryPoint = "GetWindowInfo", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetWindowInfo (IntPtr hwnd, ref x40255b11ef821fa3.WINDOWINFO pwi);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint GetWindowLong (IntPtr hWnd, int nIndex);
			[DllImportAttribute("user32.dll", EntryPoint = "GetWindowPlacement", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetWindowPlacement (IntPtr hWnd, ref x40255b11ef821fa3.WINDOWPLACEMENT lpwndpl);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetWindowRect (IntPtr hWnd, ref xae4dd1cafd2eb77c.RECT lpRect);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool GetWindowRect (IntPtr hWnd, ref Rectangle lpRect);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetWindowRgn (IntPtr hWnd, IntPtr hRgn);
			[DllImportAttribute("User32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Ansi, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetWindowText (IntPtr hWnd, StringBuilder lpString, int nMaxCount);
			[DllImportAttribute("user32.dll", EntryPoint = "GetWindowTextLengthA", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetWindowTextLengthA (IntPtr hWnd);
			[DllImportAttribute("user32.dll", EntryPoint = "GetWindowThreadProcessId", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint GetWindowThreadProcessId (IntPtr hWnd, ref uint lpdwProcessId);
			[DllImportAttribute("User32.dll", EntryPoint = "HideCaret", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool HideCaret (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "InvalidateRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool InvalidateRect (IntPtr hWnd, ref xae4dd1cafd2eb77c.RECT lpRect, int bErase);
			[DllImportAttribute("User32.dll", EntryPoint = "InvalidateRect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool InvalidateRect (IntPtr hWnd, ref xae4dd1cafd2eb77c.RECT lpRect, bool bErase);
			[DllImportAttribute("User32.dll", EntryPoint = "IsIconic", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool IsIconic (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "IsWindowVisible", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool IsWindowVisible (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "IsZoomed", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool IsZoomed (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "LoadCursor", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr LoadCursor (IntPtr hInstance, uint cursor);
			[DllImportAttribute("User32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int MessageBox (IntPtr hWnd, string lpText, string lpCaption, uint uType);
			[DllImportAttribute("User32.dll", EntryPoint = "MoveWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool MoveWindow (IntPtr hWnd, int x, int y, int width, int height, bool repaint);
			[DllImportAttribute("User32.dll", EntryPoint = "PeekMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool PeekMessage (ref Message lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
			[DllImportAttribute("User32.dll", EntryPoint = "PeekMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool PeekMessage (ref x40255b11ef821fa3.MSG msg, int hWnd, uint wFilterMin, uint wFilterMax, uint wFlag);
			[DllImportAttribute("User32.dll", EntryPoint = "PostMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool PostMessage (IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
			[DllImportAttribute("User32.dll", EntryPoint = "PostMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool PostMessage (IntPtr hWnd, uint Msg, uint wParam, uint lParam);
			[DllImportAttribute("user32.dll", EntryPoint = "ReleaseCapture", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ReleaseCapture ();
			[DllImportAttribute("User32.dll", EntryPoint = "ReleaseDC", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int ReleaseDC (IntPtr hWnd, IntPtr hDC);
			[DllImportAttribute("User32.dll", EntryPoint = "ScreenToClient", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ScreenToClient (IntPtr hWnd, ref Point lpPoint);
			[DllImportAttribute("User32.dll", EntryPoint = "ScreenToClient", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ScreenToClient (IntPtr hWnd, ref x555516122dcc901e.POINT lpPoint);
			[DllImportAttribute("user32.dll", EntryPoint = "ScrollDC", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ScrollDC (IntPtr hDC, int dx, int dy, ref xae4dd1cafd2eb77c.RECT lprcScroll, ref xae4dd1cafd2eb77c.RECT lprcClip, IntPtr hrgnUpdate, [Out] out xae4dd1cafd2eb77c.RECT lprcUpdate);
			[DllImportAttribute("user32.dll", EntryPoint = "ScrollWindow", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ScrollWindow (IntPtr hWnd, int XAmount, int YAmount, IntPtr lpRect, IntPtr lpClipRect);
			[DllImportAttribute("user32.dll", EntryPoint = "ScrollWindowEx", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int ScrollWindowEx (IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);
			[DllImportAttribute("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SendMessage (IntPtr hWnd, uint Msg, uint wParam, uint lParam);
			[DllImportAttribute("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SendMessage (IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
			[DllImportAttribute("user32.dll", EntryPoint = "SetActiveWindow", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SetActiveWindow (IntPtr hWnd);
			[DllImportAttribute("user32.dll", EntryPoint = "SetCapture", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SetCapture (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "SetClassLong", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint SetClassLong (IntPtr hWnd, int nIndex, uint dwNewLong);
			[DllImportAttribute("User32.dll", EntryPoint = "SetCursor", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SetCursor (IntPtr hCursor);
			[DllImportAttribute("user32.dll", EntryPoint = "SetScrollInfo", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int SetScrollInfo (IntPtr hwnd, int fnBar, ref x40255b11ef821fa3.SCROLLINFO lpsi, bool fRedraw);
			[DllImportAttribute("user32.dll", EntryPoint = "SetScrollPos", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int SetScrollPos (IntPtr hWnd, int nBar, int nPos, bool bRedraw);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern xc405cb1a6ec3e1f6 SetWindowLong (IntPtr hWnd, int nIndex, xc405cb1a6ec3e1f6 dwNewLong);
			[DllImportAttribute("User32.DLL", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern uint SetWindowLong (IntPtr hWnd, int nIndex, uint dwNewLong);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowPos", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool SetWindowPos (IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowPos", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool SetWindowPos (IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int SetWindowRgn (IntPtr hWnd, IntPtr hRgn, bool bRedraw);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowsHookEx", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SetWindowsHookEx (int idHook, x6161963e817c3cff lpfn, int hMod, int dwThreadId);
			[DllImportAttribute("User32.dll", EntryPoint = "SetWindowsHookEx", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SetWindowsHookEx (int idHook, xe4ad4a23d5a4f544 lpfn, int hMod, int dwThreadId);
			[DllImportAttribute("User32.dll", EntryPoint = "ShowCaret", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ShowCaret (IntPtr hWnd);
			[DllImportAttribute("user32.dll", EntryPoint = "ShowScrollBar", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool ShowScrollBar (IntPtr hWnd, int wBar, bool bShow);
			[DllImportAttribute("User32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int ShowWindow (IntPtr hWnd, short cmdShow);
			[DllImportAttribute("User32.dll", EntryPoint = "SystemParametersInfoA", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool SystemParametersInfoA (uint uiAction, uint uiParam, ref x40255b11ef821fa3.NONCLIENTMETRICS pvParam, uint fWinIni);
			[DllImportAttribute("User32.dll", EntryPoint = "SystemParametersInfoA", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool SystemParametersInfoA (uint uiAction, uint uiParam, ref int bRetValue, uint fWinINI);
			[DllImportAttribute("User32.dll", EntryPoint = "TrackMouseEvent", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool TrackMouseEvent (ref x40255b11ef821fa3.TRACKMOUSEEVENTS tme);
			[DllImportAttribute("User32.dll", EntryPoint = "TranslateMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool TranslateMessage (ref x40255b11ef821fa3.MSG lpMsg);
			[DllImportAttribute("User32.dll", EntryPoint = "UnhookWindowsHookEx", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool UnhookWindowsHookEx (IntPtr hhk);
			[DllImportAttribute("User32.dll", EntryPoint = "UpdateLayeredWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool UpdateLayeredWindow (IntPtr hwnd, IntPtr hdcDst, ref x555516122dcc901e.POINT pptDst, ref x555516122dcc901e.SIZE psize, IntPtr hdcSrc, ref x555516122dcc901e.POINT pptSrc, int crKey, ref x1439a41cfa24189f.BLENDFUNCTION pblend, int dwFlags);
			[DllImportAttribute("User32.dll", EntryPoint = "UpdateWindow", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool UpdateWindow (IntPtr hWnd);
			[DllImportAttribute("User32.dll", EntryPoint = "WaitMessage", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool WaitMessage ();
		#endregion
	}
	
}

