//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Runtime.InteropServices;
			
			
		#endregion
		
	internal class x31775329b2a4ff52
	
	{
		
		#region Constructors
		
			public x31775329b2a4ff52 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			[DllImportAttribute("Gdi32.dll", EntryPoint = "CombineRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int CombineRgn (IntPtr dest, IntPtr src1, IntPtr src2, int flags);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "CreateBrushIndirect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateBrushIndirect (ref x1439a41cfa24189f.LOGBRUSH brush);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "CreateCompatibleDC", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateCompatibleDC (IntPtr hDC);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "CreateFontIndirect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateFontIndirect (ref x40255b11ef821fa3.LOGFONT lplf);
			[DllImportAttribute("Gdi32.DLL", EntryPoint = "CreateRectRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRectRgnIndirect", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateRectRgnIndirect (ref xae4dd1cafd2eb77c.RECT rect);
			[DllImportAttribute("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "DeleteDC", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool DeleteDC (IntPtr hDC);
			[DllImportAttribute("Gdi32.DLL", EntryPoint = "DeleteObject", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool DeleteObject (IntPtr hObject);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "GetClipBox", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int GetClipBox (IntPtr hDC, ref xae4dd1cafd2eb77c.RECT rectBox);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "PatBlt", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern bool PatBlt (IntPtr hDC, int x, int y, int width, int height, uint flags);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "SelectClipRgn", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int SelectClipRgn (IntPtr hDC, IntPtr hRgn);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "SelectObject", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern IntPtr SelectObject (IntPtr hDC, IntPtr hObject);
			[DllImportAttribute("Gdi32.dll", EntryPoint = "SetBkMode", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
			[PreserveSigAttribute()]
			public static extern int SetBkMode (IntPtr hdc, int iBkMode);
		#endregion
	}
	
}

