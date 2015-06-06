//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x4fef14ebf3863c7f : Form
	
	{
		
		#region Fields
			private x3c41176af7e54b01 x11d58b056c032b03;
			private bool xbb04efaa616d8bab;
		#endregion
		
		#region Constructors
		
			public x4fef14ebf3863c7f (x3c41176af7e54b01 target, MainMenu ori)
			/*
				// Code Size: 42 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Boolean xbb04efaa616d8bab
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.Form::Void .ctor()
				L_000d: ldarg.0 
				L_000e: ldarg.1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x11d58b056c032b03
				L_0014: ldarg.0 
				L_0015: ldarg.2 
				L_0016: call System.Windows.Forms.Form::Void set_Menu(System.Windows.Forms.MainMenu)
				L_001b: ldarg.0 
				L_001c: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0021: pop 
				L_0022: ldarg.0 
				L_0023: ldc.i4.0 
				L_0024: stfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Boolean xbb04efaa616d8bab
				L_0029: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 48 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: ldc.i4.s 71
				L_0008: bne.un.s L_0028
				L_000a: ldarg.0 
				L_000b: ldfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Boolean xbb04efaa616d8bab
				L_0010: brtrue.s L_0028
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x11d58b056c032b03
				L_0018: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x11d58b056c032b03
				L_0023: callvirt System.Windows.Forms.Control::Void Invalidate()
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: call System.Windows.Forms.Form::Void WndProc(System.Windows.Forms.Message ByRef)
				L_002f: ret 
			*/
			
			
			{
				if ((m.Msg == 71) && (! this.xbb04efaa616d8bab))
				{
					this.x11d58b056c032b03.x39e008704a72ea56 ();
					this.x11d58b056c032b03.Invalidate ();
				}
				base.WndProc (ref m);
			}
			
		#endregion
	}
	
}

