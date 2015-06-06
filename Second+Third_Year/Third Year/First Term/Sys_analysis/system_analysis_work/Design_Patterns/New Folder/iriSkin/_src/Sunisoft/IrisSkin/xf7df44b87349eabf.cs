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
			
			
		#endregion
		
	internal class xf7df44b87349eabf : x5b126f5f998c28e9
	
	{
		
		#region Constructors
		
			public xf7df44b87349eabf (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void PaintControl ()
			
			/*
				// Code Size: 97 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0, 
         System.IntPtr V_1)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_0006: ldloca.s V_0
				L_0008: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_000e: ldarg.0 
				L_000f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0014: ldloca.s V_0
				L_0016: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_001b: pop 
				L_001c: ldloca.s V_0
				L_001e: ldloca.s V_0
				L_0020: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0025: neg 
				L_0026: ldloca.s V_0
				L_0028: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_002d: neg 
				L_002e: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(RECT ByRef, Int32, Int32)
				L_0033: ldarg.0 
				L_0034: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0039: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_003e: stloc.1 
				L_003f: ldloc.1 
				L_0040: ldloca.s V_0
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0048: callvirt Sunisoft.IrisSkin.SkinEngine::IntPtr get_ControlBorderBrush()
				L_004d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 FrameRect(IntPtr, RECT ByRef, IntPtr)
				L_0052: pop 
				L_0053: ldarg.0 
				L_0054: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0059: ldloc.1 
				L_005a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_005f: pop 
				L_0060: ret 
			*/
			
			
			{
				base.PaintControl ();
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				x448fd9ab43628c71.x897356c8698a543c (ref rECT1, (- rECT1.left), (- rECT1.top));
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
				int i1 = x61467fe65a98f20c.FrameRect (intPtr1, ref rECT1, ((SkinEngine) base.xdc87e2b99332cd4a).ControlBorderBrush);
				int i2 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
		#endregion
	}
	
}

