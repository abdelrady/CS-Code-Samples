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
		
	internal class x3a157e8c7a942ff8 : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private BorderStyle xacfbd7a08ba56c78;
		#endregion
		
		#region Constructors
		
			public x3a157e8c7a942ff8 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override int BorderWidth
			
			{
				get
				
				/*
					// Code Size: 25 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.Panel V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: castclass System.Windows.Forms.Panel
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: callvirt System.Windows.Forms.Panel::System.Windows.Forms.BorderStyle get_BorderStyle()
					L_0012: ldc.i4.1 
					L_0013: bne.un.s L_0017
					L_0015: ldc.i4.0 
					L_0016: ret 
					L_0017: ldc.i4.2 
					L_0018: ret 
				*/
				
				{
					Panel panel1 = ((Panel) base.xcd9cdf30888d2204);
					if (panel1.BorderStyle != BorderStyle.FixedSingle)
					{
						return 2;
					}
					else
					{
						return 0;
					}
				}
			}
			
			
			protected override bool CanScroll
			
			{
				get
				
				/*
					// Code Size: 17 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: castclass System.Windows.Forms.Panel
					L_000b: callvirt System.Windows.Forms.ScrollableControl::Boolean get_AutoScroll()
					L_0010: ret 
				*/
				
				{
					return ((Panel) base.xcd9cdf30888d2204).AutoScroll;
				}
			}
			
			
			protected override bool PaintBorder
			
			{
				get
				
				/*
					// Code Size: 24 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.Panel V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: castclass System.Windows.Forms.Panel
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: callvirt System.Windows.Forms.Panel::System.Windows.Forms.BorderStyle get_BorderStyle()
					L_0012: brtrue.s L_0016
					L_0014: ldc.i4.0 
					L_0015: ret 
					L_0016: ldc.i4.1 
					L_0017: ret 
				*/
				
				{
					Panel panel1 = ((Panel) base.xcd9cdf30888d2204);
					if (panel1.BorderStyle != BorderStyle.None)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void DoInit ()
			
			/*
				// Code Size: 77 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.Panel V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: castclass System.Windows.Forms.Panel
				L_0011: stloc.0 
				L_0012: ldarg.0 
				L_0013: ldloc.0 
				L_0014: callvirt System.Windows.Forms.Panel::System.Windows.Forms.BorderStyle get_BorderStyle()
				L_0019: stfld Sunisoft.IrisSkin.x3a157e8c7a942ff8::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.x3a157e8c7a942ff8::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0024: brfalse.s L_0035
				L_0026: ldarg.0 
				L_0027: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_002c: brfalse.s L_0035
				L_002e: ldloc.0 
				L_002f: ldc.i4.1 
				L_0030: callvirt System.Windows.Forms.Panel::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003b: ldarg.0 
				L_003c: ldftn Sunisoft.IrisSkin.x3a157e8c7a942ff8::Void x495cb160f8448ee7(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0042: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_0047: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_004c: ret 
			*/
			
			
			{
				base.DoInit ();
				Panel panel1 = ((Panel) base.xcd9cdf30888d2204);
				this.xacfbd7a08ba56c78 = panel1.BorderStyle;
				if ((this.xacfbd7a08ba56c78 != BorderStyle.None) && base.xf2140268ef7ddbf7)
				{
					panel1.BorderStyle = BorderStyle.FixedSingle;
				}
				((SkinEngine) base.xdc87e2b99332cd4a).CurrentSkinChanged += new SkinChanged (this.x495cb160f8448ee7);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void PaintControl()
				L_0006: ret 
			*/
			
			
			{
				base.PaintControl ();
			}
			
			private void x495cb160f8448ee7 (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 134 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Panel V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_000b: brfalse.s L_000e
				L_000d: ret 
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0014: castclass System.Windows.Forms.Panel
				L_0019: stloc.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.x3a157e8c7a942ff8::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0020: brfalse.s L_003f
				L_0022: ldarg.0 
				L_0023: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0028: brfalse.s L_0033
				L_002a: ldloc.0 
				L_002b: ldc.i4.1 
				L_002c: callvirt System.Windows.Forms.Panel::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_0031: br.s L_003f
				L_0033: ldloc.0 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.x3a157e8c7a942ff8::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_003a: callvirt System.Windows.Forms.Panel::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_003f: ldarg.0 
				L_0040: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0045: brfalse.s L_0069
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_004d: ldarg.0 
				L_004e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0053: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0058: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_005d: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0062: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0067: br.s L_007a
				L_0069: ldarg.0 
				L_006a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_006f: ldarg.0 
				L_0070: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Drawing.Color x154083d58301ef75
				L_0075: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_007a: ldarg.0 
				L_007b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0080: callvirt System.Windows.Forms.Control::Void Refresh()
				L_0085: ret 
			*/
			
			
			{
				if (base.xcd9cdf30888d2204.IsDisposed)
				{
					return;
				}
				Panel panel1 = ((Panel) base.xcd9cdf30888d2204);
				if (this.xacfbd7a08ba56c78 != BorderStyle.None)
				{
					if (! base.xf2140268ef7ddbf7)
					{
						panel1.BorderStyle = this.xacfbd7a08ba56c78;
					}
					else
					{
						panel1.BorderStyle = BorderStyle.FixedSingle;
					}
				}
				if (base.xf2140268ef7ddbf7)
				{
					base.xcd9cdf30888d2204.BackColor = ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_FORMCOLOR;
				}
				else
				{
					base.xcd9cdf30888d2204.BackColor = base.x154083d58301ef75;
				}
				base.xcd9cdf30888d2204.Refresh ();
			}
			
		#endregion
	}
	
}

