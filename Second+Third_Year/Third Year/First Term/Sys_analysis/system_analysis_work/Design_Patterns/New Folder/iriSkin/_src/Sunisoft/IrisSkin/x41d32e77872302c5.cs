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
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x41d32e77872302c5 : xbd3f2493841f18a1
	
	{
		
		#region Fields
			private x60982e1b4eef090a x1f8a3bb85c91d0b5;
		#endregion
		
		#region Constructors
		
			public x41d32e77872302c5 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 168 Bytes
				.maxstack 6
				.locals (System.Windows.Forms.ScrollBar V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.1 
				L_0009: castclass System.Windows.Forms.ScrollBar
				L_000e: stloc.0 
				L_000f: ldarg.1 
				L_0010: isinst System.Windows.Forms.HScrollBar
				L_0015: brfalse.s L_0027
				L_0017: ldarg.0 
				L_0018: ldloc.0 
				L_0019: ldarg.2 
				L_001a: ldc.i4.1 
				L_001b: newobj Sunisoft.IrisSkin.x60982e1b4eef090a::Void .ctor(System.Windows.Forms.ScrollBar, Sunisoft.IrisSkin.SkinEngine, Boolean)
				L_0020: stfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0025: br.s L_0035
				L_0027: ldarg.0 
				L_0028: ldloc.0 
				L_0029: ldarg.2 
				L_002a: ldc.i4.0 
				L_002b: newobj Sunisoft.IrisSkin.x60982e1b4eef090a::Void .ctor(System.Windows.Forms.ScrollBar, Sunisoft.IrisSkin.SkinEngine, Boolean)
				L_0030: stfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0035: ldarg.0 
				L_0036: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_003b: ldloc.0 
				L_003c: ldarg.0 
				L_003d: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void xbad904bdcc347055(System.Object, System.EventArgs)
				L_0043: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0048: callvirt System.Windows.Forms.Control::Void add_VisibleChanged(System.EventHandler)
				L_004d: ldloc.0 
				L_004e: ldarg.0 
				L_004f: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void xe8a173d72f8f3729(System.Object, System.EventArgs)
				L_0055: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_005a: callvirt System.Windows.Forms.Control::Void add_SizeChanged(System.EventHandler)
				L_005f: ldloc.0 
				L_0060: ldarg.0 
				L_0061: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void x9fca9353a2d2087c(System.Object, System.EventArgs)
				L_0067: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_006c: callvirt System.Windows.Forms.Control::Void add_LocationChanged(System.EventHandler)
				L_0071: ldloc.0 
				L_0072: ldarg.0 
				L_0073: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void xb82f209246987e7a(System.Object, System.EventArgs)
				L_0079: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_007e: callvirt System.Windows.Forms.Control::Void add_Resize(System.EventHandler)
				L_0083: ldloc.0 
				L_0084: ldarg.0 
				L_0085: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void xc68edf742e725d77(System.Object, System.EventArgs)
				L_008b: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0090: callvirt System.Windows.Forms.Control::Void add_EnabledChanged(System.EventHandler)
				L_0095: ldloc.0 
				L_0096: ldarg.0 
				L_0097: ldftn Sunisoft.IrisSkin.x41d32e77872302c5::Void xdf8f78b46a8ed400(System.Object, System.EventArgs)
				L_009d: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_00a2: callvirt System.Windows.Forms.ScrollBar::Void add_ValueChanged(System.EventHandler)
				L_00a7: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_000e: ret 
			*/
			
			
			{
				base.OnCurrentSkinChanged (sender, e);
				this.xf149df02f1aa3d56 ();
			}
			
			private void x9fca9353a2d2087c (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xb82f209246987e7a (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xbad904bdcc347055 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xc68edf742e725d77 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0006: callvirt Sunisoft.IrisSkin.x60982e1b4eef090a::Void x9b8f9735fbcfbe34()
				L_000b: ret 
			*/
			
			
			{
				this.x1f8a3bb85c91d0b5.x9b8f9735fbcfbe34 ();
			}
			
			private void xdf8f78b46a8ed400 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0006: callvirt Sunisoft.IrisSkin.x60982e1b4eef090a::Void x9b8f9735fbcfbe34()
				L_000b: ret 
			*/
			
			
			{
				this.x1f8a3bb85c91d0b5.x9b8f9735fbcfbe34 ();
			}
			
			private void xe8a173d72f8f3729 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x41d32e77872302c5::Void xf149df02f1aa3d56()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_000c: callvirt Sunisoft.IrisSkin.x60982e1b4eef090a::Void x9b8f9735fbcfbe34()
				L_0011: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
				this.x1f8a3bb85c91d0b5.x9b8f9735fbcfbe34 ();
			}
			
			private void xf149df02f1aa3d56 ()
			
			/*
				// Code Size: 88 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0006: ldarg.0 
				L_0007: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0012: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_0017: and 
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001e: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_0023: and 
				L_0024: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0029: ldarg.0 
				L_002a: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_002f: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_0034: brfalse.s L_0057
				L_0036: ldarg.0 
				L_0037: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_003c: ldarg.0 
				L_003d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0042: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_Bounds()
				L_0047: callvirt System.Windows.Forms.Control::Void set_Bounds(System.Drawing.Rectangle)
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.x41d32e77872302c5::Sunisoft.IrisSkin.x60982e1b4eef090a x1f8a3bb85c91d0b5
				L_0052: callvirt System.Windows.Forms.Control::Void BringToFront()
				L_0057: ret 
			*/
			
			
			{
				this.x1f8a3bb85c91d0b5.Visible = ((base.xf2140268ef7ddbf7 && base.xcd9cdf30888d2204.Visible) && ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar);
				if (this.x1f8a3bb85c91d0b5.Visible)
				{
					this.x1f8a3bb85c91d0b5.Bounds = base.xcd9cdf30888d2204.Bounds;
					this.x1f8a3bb85c91d0b5.BringToFront ();
				}
			}
			
		#endregion
	}
	
}

