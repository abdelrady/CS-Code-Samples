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
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x8917d01b98173f4c : xbd3f2493841f18a1
	
	{
		
		#region Constructors
		
			public x8917d01b98173f4c (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Methods
		
			protected virtual void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 2 Bytes
				.maxstack 9
				L_0000: ldc.i4.1 
				L_0001: ret 
			*/
			
			
			{
				return true;
			}
			
			protected override void DoInit ()
			
			/*
				// Code Size: 24 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0012: call System.Windows.Forms.NativeWindow::Void AssignHandle(IntPtr)
				L_0017: ret 
			*/
			
			
			{
				base.DoInit ();
				base.AssignHandle (base.xcd9cdf30888d2204.Handle);
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 40 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: callvirt Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_000f: brfalse.s L_0018
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: callvirt Sunisoft.IrisSkin.x8917d01b98173f4c::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldarg.1 
				L_0022: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0027: ret 
			*/
			
			
			{
				if (! base.xf2140268ef7ddbf7)
				{
					base.WndProc (ref m);
				}
				else
				{
					if (this.BeforeWndProc (ref m))
					{
						base.WndProc (ref m);
					}
					this.AfterWndProc (ref m);
				}
			}
			
		#endregion
	}
	
}

