//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System.ComponentModel;
			using System.Drawing.Imaging;
			using System.Drawing;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	[ToolboxItemAttribute(false)]
	internal class x5d3356d9dffccb60 : Control
	
	{
		
		#region Fields
			protected MouseButtons x2092ce7be83a9db0;
			protected bool x21da04747061b494;
			protected ImageAttributes x295aa0055499b2a1;
			protected ImageList x2993d26e54ff8a77;
			protected int x55bc7f15d48063ab;
			protected bool x753f06f9b5cd6e0d;
			protected bool x7e5b6f1120392742;
			protected int xc9b9743c6a16e903;
			protected int xd36653cb399695c7;
		#endregion
		
		#region Constructors
		
			public x5d3356d9dffccb60 (ImageList imageList, int imageIndexEnabled)
			/*
				// Code Size: 17 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldc.i4.m1 
				L_000a: ldnull 
				L_000b: call Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void xe8347ded66542b74(System.Windows.Forms.ImageList, Int32, Int32, System.Drawing.Imaging.ImageAttributes)
				L_0010: ret 
			*/
			
			public x5d3356d9dffccb60 ()
			/*
				// Code Size: 17 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldnull 
				L_0008: ldc.i4.m1 
				L_0009: ldc.i4.m1 
				L_000a: ldnull 
				L_000b: call Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void xe8347ded66542b74(System.Windows.Forms.ImageList, Int32, Int32, System.Drawing.Imaging.ImageAttributes)
				L_0010: ret 
			*/
			
			public x5d3356d9dffccb60 (ImageList imageList, int imageIndexEnabled, int imageIndexDisabled)
			/*
				// Code Size: 17 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldarg.3 
				L_000a: ldnull 
				L_000b: call Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void xe8347ded66542b74(System.Windows.Forms.ImageList, Int32, Int32, System.Drawing.Imaging.ImageAttributes)
				L_0010: ret 
			*/
			
			public x5d3356d9dffccb60 (ImageList imageList, int imageIndexEnabled, int imageIndexDisabled, ImageAttributes imageAttr)
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldarg.3 
				L_000a: ldarg.s imageAttr
				L_000c: call Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void xe8347ded66542b74(System.Windows.Forms.ImageList, Int32, Int32, System.Drawing.Imaging.ImageAttributes)
				L_0011: ret 
			*/
		#endregion
		
		#region Properties
		
			[CategoryAttribute("Appearance")]
			[DefaultValueAttribute(((String) null))]
			public ImageAttributes x698e9b05d858b9d7
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
					L_0006: ret 
				*/
				
				{
					return this.x295aa0055499b2a1;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.x295aa0055499b2a1 != value)
					{
						this.x295aa0055499b2a1 = value;
						base.Invalidate ();
					}
				}
			}
			
			
			[CategoryAttribute("Appearance")]
			[DefaultValueAttribute(((String) null))]
			public ImageList x7bc501a48fc6524b
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
					L_0006: ret 
				*/
				
				{
					return this.x2993d26e54ff8a77;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.x2993d26e54ff8a77 != value)
					{
						this.x2993d26e54ff8a77 = value;
						base.Invalidate ();
					}
				}
			}
			
			
			[DefaultValueAttribute(true)]
			[CategoryAttribute("Appearance")]
			public bool x7d7f7b528e13f94c
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x21da04747061b494
					L_0006: ret 
				*/
				
				{
					return this.x21da04747061b494;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x21da04747061b494
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x21da04747061b494
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.x21da04747061b494 != value)
					{
						this.x21da04747061b494 = value;
						base.Invalidate ();
					}
				}
			}
			
			
			[CategoryAttribute("Appearance")]
			[DefaultValueAttribute(FFFFFFFF)]
			public int xa9ec320e21d07e1e
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
					L_0006: ret 
				*/
				
				{
					return this.xd36653cb399695c7;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.xd36653cb399695c7 != value)
					{
						this.xd36653cb399695c7 = value;
						base.Invalidate ();
					}
				}
			}
			
			
			[CategoryAttribute("Appearance")]
			[DefaultValueAttribute(0002)]
			public int xeae235558dc44397
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
					L_0006: ret 
				*/
				
				{
					return this.x55bc7f15d48063ab;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.x55bc7f15d48063ab != value)
					{
						this.x55bc7f15d48063ab = value;
						base.Invalidate ();
					}
				}
			}
			
			
			[DefaultValueAttribute(FFFFFFFF)]
			[CategoryAttribute("Appearance")]
			public int xf33c56657dc25071
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
					L_0006: ret 
				*/
				
				{
					return this.xc9b9743c6a16e903;
				}
				set
				
				/*
					// Code Size: 23 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
					L_0006: ldarg.1 
					L_0007: beq.s L_0016
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
					L_0010: ldarg.0 
					L_0011: call System.Windows.Forms.Control::Void Invalidate()
					L_0016: ret 
				*/
				
				{
					if (this.xc9b9743c6a16e903 != value)
					{
						this.xc9b9743c6a16e903 = value;
						base.Invalidate ();
					}
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void OnMouseDown (MouseEventArgs e)
			
			/*
				// Code Size: 48 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_0006: brtrue.s L_0028
				L_0008: ldarg.0 
				L_0009: ldc.i4.1 
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_000f: ldarg.0 
				L_0010: ldc.i4.1 
				L_0011: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_0016: ldarg.0 
				L_0017: ldarg.1 
				L_0018: callvirt System.Windows.Forms.MouseEventArgs::System.Windows.Forms.MouseButtons get_Button()
				L_001d: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.MouseButtons x2092ce7be83a9db0
				L_0022: ldarg.0 
				L_0023: call System.Windows.Forms.Control::Void Invalidate()
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: call System.Windows.Forms.Control::Void OnMouseDown(System.Windows.Forms.MouseEventArgs)
				L_002f: ret 
			*/
			
			
			{
				if (! this.x7e5b6f1120392742)
				{
					this.x753f06f9b5cd6e0d = true;
					this.x7e5b6f1120392742 = true;
					this.x2092ce7be83a9db0 = e.Button;
					base.Invalidate ();
				}
				base.OnMouseDown (e);
			}
			
			protected override void OnMouseEnter (EventArgs e)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.Control::Void Invalidate()
				L_000d: ldarg.0 
				L_000e: ldarg.1 
				L_000f: call System.Windows.Forms.Control::Void OnMouseEnter(System.EventArgs)
				L_0014: ret 
			*/
			
			
			{
				this.x753f06f9b5cd6e0d = true;
				base.Invalidate ();
				base.OnMouseEnter (e);
			}
			
			protected override void OnMouseLeave (EventArgs e)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.Control::Void Invalidate()
				L_000d: ldarg.0 
				L_000e: ldarg.1 
				L_000f: call System.Windows.Forms.Control::Void OnMouseLeave(System.EventArgs)
				L_0014: ret 
			*/
			
			
			{
				this.x753f06f9b5cd6e0d = false;
				base.Invalidate ();
				base.OnMouseLeave (e);
			}
			
			protected override void OnMouseMove (MouseEventArgs e)
			
			/*
				// Code Size: 62 Bytes
				.maxstack 5
				.locals (System.Boolean V_0, 
         System.Drawing.Rectangle V_1)
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0006: stloc.1 
				L_0007: ldloca.s V_1
				L_0009: ldarg.1 
				L_000a: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_X()
				L_000f: ldarg.1 
				L_0010: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_Y()
				L_0015: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_001a: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_001f: stloc.0 
				L_0020: ldloc.0 
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0027: beq.s L_0036
				L_0029: ldarg.0 
				L_002a: ldloc.0 
				L_002b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0030: ldarg.0 
				L_0031: call System.Windows.Forms.Control::Void Invalidate()
				L_0036: ldarg.0 
				L_0037: ldarg.1 
				L_0038: call System.Windows.Forms.Control::Void OnMouseMove(System.Windows.Forms.MouseEventArgs)
				L_003d: ret 
			*/
			
			
			{
				Rectangle rectangle1 = base.ClientRectangle;
				bool b1 = rectangle1.Contains (new Point (e.X, e.Y));
				if (b1 != this.x753f06f9b5cd6e0d)
				{
					this.x753f06f9b5cd6e0d = b1;
					base.Invalidate ();
				}
				base.OnMouseMove (e);
			}
			
			protected override void OnMouseUp (MouseEventArgs e)
			
			/*
				// Code Size: 51 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: callvirt System.Windows.Forms.MouseEventArgs::System.Windows.Forms.MouseButtons get_Button()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.MouseButtons x2092ce7be83a9db0
				L_000c: bne.un.s L_0024
				L_000e: ldarg.0 
				L_000f: ldc.i4.0 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_001c: ldarg.0 
				L_001d: call System.Windows.Forms.Control::Void Invalidate()
				L_0022: br.s L_002b
				L_0024: ldarg.0 
				L_0025: ldc.i4.1 
				L_0026: call System.Windows.Forms.Control::Void set_Capture(Boolean)
				L_002b: ldarg.0 
				L_002c: ldarg.1 
				L_002d: call System.Windows.Forms.Control::Void OnMouseUp(System.Windows.Forms.MouseEventArgs)
				L_0032: ret 
			*/
			
			
			{
				if (e.Button == this.x2092ce7be83a9db0)
				{
					this.x753f06f9b5cd6e0d = false;
					this.x7e5b6f1120392742 = false;
					base.Invalidate ();
				}
				else
				{
					base.Capture = true;
				}
				base.OnMouseUp (e);
			}
			
			protected override void OnPaint (PaintEventArgs e)
			
			/*
				// Code Size: 879 Bytes
				.maxstack 15
				.locals (System.Drawing.Image V_0, 
         System.Drawing.Point[] V_1, 
         System.Drawing.Image V_2, 
         System.Drawing.Point[] V_3, 
         System.Windows.Forms.ButtonBorderStyle V_4)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_0006: brfalse L_0367
				L_000b: ldarg.0 
				L_000c: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_0011: brtrue L_0178
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
				L_001c: ldc.i4.m1 
				L_001d: beq L_013e
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
				L_0028: brtrue.s L_0057
				L_002a: ldarg.1 
				L_002b: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_0036: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_003b: ldarg.0 
				L_003c: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
				L_0041: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0046: ldc.i4.1 
				L_0047: ldc.i4.1 
				L_0048: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_004d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Point)
				L_0052: br L_0367
				L_0057: ldarg.0 
				L_0058: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_005d: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0062: ldarg.0 
				L_0063: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
				L_0068: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_006d: stloc.0 
				L_006e: ldc.i4.3 
				L_006f: newarr System.Drawing.Point
				L_0074: stloc.1 
				L_0075: ldloc.1 
				L_0076: ldc.i4.0 
				L_0077: ldelema System.Drawing.Point
				L_007c: ldc.i4.1 
				L_007d: call System.Drawing.Point::Void set_X(Int32)
				L_0082: ldloc.1 
				L_0083: ldc.i4.0 
				L_0084: ldelema System.Drawing.Point
				L_0089: ldc.i4.1 
				L_008a: call System.Drawing.Point::Void set_Y(Int32)
				L_008f: ldloc.1 
				L_0090: ldc.i4.1 
				L_0091: ldelema System.Drawing.Point
				L_0096: ldloc.1 
				L_0097: ldc.i4.0 
				L_0098: ldelema System.Drawing.Point
				L_009d: call System.Drawing.Point::Int32 get_X()
				L_00a2: ldloc.0 
				L_00a3: callvirt System.Drawing.Image::Int32 get_Width()
				L_00a8: add 
				L_00a9: call System.Drawing.Point::Void set_X(Int32)
				L_00ae: ldloc.1 
				L_00af: ldc.i4.1 
				L_00b0: ldelema System.Drawing.Point
				L_00b5: ldloc.1 
				L_00b6: ldc.i4.0 
				L_00b7: ldelema System.Drawing.Point
				L_00bc: call System.Drawing.Point::Int32 get_Y()
				L_00c1: call System.Drawing.Point::Void set_Y(Int32)
				L_00c6: ldloc.1 
				L_00c7: ldc.i4.2 
				L_00c8: ldelema System.Drawing.Point
				L_00cd: ldloc.1 
				L_00ce: ldc.i4.0 
				L_00cf: ldelema System.Drawing.Point
				L_00d4: call System.Drawing.Point::Int32 get_X()
				L_00d9: call System.Drawing.Point::Void set_X(Int32)
				L_00de: ldloc.1 
				L_00df: ldc.i4.2 
				L_00e0: ldelema System.Drawing.Point
				L_00e5: ldloc.1 
				L_00e6: ldc.i4.1 
				L_00e7: ldelema System.Drawing.Point
				L_00ec: call System.Drawing.Point::Int32 get_Y()
				L_00f1: ldloc.0 
				L_00f2: callvirt System.Drawing.Image::Int32 get_Height()
				L_00f7: add 
				L_00f8: call System.Drawing.Point::Void set_Y(Int32)
				L_00fd: ldarg.1 
				L_00fe: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0103: ldarg.0 
				L_0104: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_0109: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_010e: ldarg.0 
				L_010f: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
				L_0114: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0119: ldloc.1 
				L_011a: ldc.i4.0 
				L_011b: ldc.i4.0 
				L_011c: ldloc.0 
				L_011d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0122: ldloc.0 
				L_0123: callvirt System.Drawing.Image::Int32 get_Height()
				L_0128: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_012d: ldc.i4.2 
				L_012e: ldarg.0 
				L_012f: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
				L_0134: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Point[], System.Drawing.Rectangle, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0139: br L_0367
				L_013e: ldarg.0 
				L_013f: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_0144: ldc.i4.m1 
				L_0145: beq L_0367
				L_014a: ldarg.1 
				L_014b: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0150: ldarg.0 
				L_0151: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_0156: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_015b: ldarg.0 
				L_015c: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_0161: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0166: ldc.i4.1 
				L_0167: ldc.i4.1 
				L_0168: ldarg.0 
				L_0169: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_016e: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_0173: br L_0367
				L_0178: ldarg.0 
				L_0179: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
				L_017e: brtrue.s L_01c6
				L_0180: ldarg.1 
				L_0181: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0186: ldarg.0 
				L_0187: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_018c: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0191: ldarg.0 
				L_0192: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_0197: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_019c: ldarg.0 
				L_019d: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_01a2: brfalse.s L_01ac
				L_01a4: ldarg.0 
				L_01a5: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_01aa: brtrue.s L_01b5
				L_01ac: ldc.i4.1 
				L_01ad: ldc.i4.1 
				L_01ae: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_01b3: br.s L_01bc
				L_01b5: ldc.i4.2 
				L_01b6: ldc.i4.2 
				L_01b7: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_01bc: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Point)
				L_01c1: br L_02ce
				L_01c6: ldarg.0 
				L_01c7: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_01cc: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_01d1: ldarg.0 
				L_01d2: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_01d7: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_01dc: stloc.2 
				L_01dd: ldc.i4.3 
				L_01de: newarr System.Drawing.Point
				L_01e3: stloc.3 
				L_01e4: ldloc.3 
				L_01e5: ldc.i4.0 
				L_01e6: ldelema System.Drawing.Point
				L_01eb: ldarg.0 
				L_01ec: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_01f1: brfalse.s L_01fb
				L_01f3: ldarg.0 
				L_01f4: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_01f9: brtrue.s L_01fe
				L_01fb: ldc.i4.1 
				L_01fc: br.s L_01ff
				L_01fe: ldc.i4.2 
				L_01ff: call System.Drawing.Point::Void set_X(Int32)
				L_0204: ldloc.3 
				L_0205: ldc.i4.0 
				L_0206: ldelema System.Drawing.Point
				L_020b: ldarg.0 
				L_020c: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0211: brfalse.s L_021b
				L_0213: ldarg.0 
				L_0214: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_0219: brtrue.s L_021e
				L_021b: ldc.i4.1 
				L_021c: br.s L_021f
				L_021e: ldc.i4.2 
				L_021f: call System.Drawing.Point::Void set_Y(Int32)
				L_0224: ldloc.3 
				L_0225: ldc.i4.1 
				L_0226: ldelema System.Drawing.Point
				L_022b: ldloc.3 
				L_022c: ldc.i4.0 
				L_022d: ldelema System.Drawing.Point
				L_0232: call System.Drawing.Point::Int32 get_X()
				L_0237: ldloc.2 
				L_0238: callvirt System.Drawing.Image::Int32 get_Width()
				L_023d: add 
				L_023e: call System.Drawing.Point::Void set_X(Int32)
				L_0243: ldloc.3 
				L_0244: ldc.i4.1 
				L_0245: ldelema System.Drawing.Point
				L_024a: ldloc.3 
				L_024b: ldc.i4.0 
				L_024c: ldelema System.Drawing.Point
				L_0251: call System.Drawing.Point::Int32 get_Y()
				L_0256: call System.Drawing.Point::Void set_Y(Int32)
				L_025b: ldloc.3 
				L_025c: ldc.i4.2 
				L_025d: ldelema System.Drawing.Point
				L_0262: ldloc.3 
				L_0263: ldc.i4.0 
				L_0264: ldelema System.Drawing.Point
				L_0269: call System.Drawing.Point::Int32 get_X()
				L_026e: call System.Drawing.Point::Void set_X(Int32)
				L_0273: ldloc.3 
				L_0274: ldc.i4.2 
				L_0275: ldelema System.Drawing.Point
				L_027a: ldloc.3 
				L_027b: ldc.i4.1 
				L_027c: ldelema System.Drawing.Point
				L_0281: call System.Drawing.Point::Int32 get_Y()
				L_0286: ldloc.2 
				L_0287: callvirt System.Drawing.Image::Int32 get_Height()
				L_028c: add 
				L_028d: call System.Drawing.Point::Void set_Y(Int32)
				L_0292: ldarg.1 
				L_0293: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0298: ldarg.0 
				L_0299: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_029e: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_02a3: ldarg.0 
				L_02a4: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_02a9: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_02ae: ldloc.3 
				L_02af: ldc.i4.0 
				L_02b0: ldc.i4.0 
				L_02b1: ldloc.2 
				L_02b2: callvirt System.Drawing.Image::Int32 get_Width()
				L_02b7: ldloc.2 
				L_02b8: callvirt System.Drawing.Image::Int32 get_Height()
				L_02bd: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02c2: ldc.i4.2 
				L_02c3: ldarg.0 
				L_02c4: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
				L_02c9: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Point[], System.Drawing.Rectangle, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_02ce: ldarg.0 
				L_02cf: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x21da04747061b494
				L_02d4: brfalse.s L_02fb
				L_02d6: ldarg.0 
				L_02d7: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_02dc: brfalse.s L_02f6
				L_02de: ldarg.0 
				L_02df: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_02e4: brfalse.s L_02f6
				L_02e6: ldarg.0 
				L_02e7: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_02ec: brtrue.s L_02f1
				L_02ee: ldc.i4.5 
				L_02ef: br.s L_02f2
				L_02f1: ldc.i4.4 
				L_02f2: stloc.s V_4
				L_02f4: br.s L_031e
				L_02f6: ldc.i4.3 
				L_02f7: stloc.s V_4
				L_02f9: br.s L_031e
				L_02fb: ldarg.0 
				L_02fc: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_0301: brfalse.s L_031b
				L_0303: ldarg.0 
				L_0304: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_0309: brfalse.s L_0313
				L_030b: ldarg.0 
				L_030c: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_0311: brtrue.s L_0316
				L_0313: ldc.i4.5 
				L_0314: br.s L_0317
				L_0316: ldc.i4.4 
				L_0317: stloc.s V_4
				L_0319: br.s L_031e
				L_031b: ldc.i4.3 
				L_031c: stloc.s V_4
				L_031e: ldarg.1 
				L_031f: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0324: ldarg.0 
				L_0325: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_032a: ldarg.0 
				L_032b: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0330: ldarg.0 
				L_0331: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
				L_0336: ldloc.s V_4
				L_0338: ldarg.0 
				L_0339: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_033e: ldarg.0 
				L_033f: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
				L_0344: ldloc.s V_4
				L_0346: ldarg.0 
				L_0347: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_034c: ldarg.0 
				L_034d: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
				L_0352: ldloc.s V_4
				L_0354: ldarg.0 
				L_0355: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_035a: ldarg.0 
				L_035b: ldfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
				L_0360: ldloc.s V_4
				L_0362: call System.Windows.Forms.ControlPaint::Void DrawBorder(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Color, Int32, System.Windows.Forms.ButtonBorderStyle, System.Drawing.Color, Int32, System.Windows.Forms.ButtonBorderStyle, System.Drawing.Color, Int32, System.Windows.Forms.ButtonBorderStyle, System.Drawing.Color, Int32, System.Windows.Forms.ButtonBorderStyle)
				L_0367: ldarg.0 
				L_0368: ldarg.1 
				L_0369: call System.Windows.Forms.Control::Void OnPaint(System.Windows.Forms.PaintEventArgs)
				L_036e: ret 
			*/
			
			
			{
				Image image1;
				Point[] pointArray1;
				Image image2;
				Point[] pointArray2;
				ButtonBorderStyle buttonBorderStyle1;
				if (this.x2993d26e54ff8a77 != null)
				{
					if (base.Enabled)
					{
						if (this.x295aa0055499b2a1 != null)
						{
							image2 = this.x2993d26e54ff8a77.Images[this.xd36653cb399695c7];
							pointArray2 = new Point[3];
							pointArray2[0].X = ((this.x753f06f9b5cd6e0d && this.x7e5b6f1120392742) ? 2 : 1);
							pointArray2[0].Y = ((this.x753f06f9b5cd6e0d && this.x7e5b6f1120392742) ? 2 : 1);
							pointArray2[1].X = (pointArray2[0].X + image2.Width);
							pointArray2[1].Y = pointArray2[0].Y;
							pointArray2[2].X = pointArray2[0].X;
							pointArray2[2].Y = (pointArray2[1].Y + image2.Height);
							e.Graphics.DrawImage (this.x2993d26e54ff8a77.Images[this.xd36653cb399695c7], pointArray2, new Rectangle (0, 0, image2.Width, image2.Height), GraphicsUnit.Pixel, this.x295aa0055499b2a1);
						}
						else
						{
							e.Graphics.DrawImage (this.x2993d26e54ff8a77.Images[this.xd36653cb399695c7], ((this.x753f06f9b5cd6e0d && this.x7e5b6f1120392742) ? new Point (2, 2) : new Point (1, 1)));
						}
						if (this.x21da04747061b494)
						{
							if (this.x753f06f9b5cd6e0d && base.Enabled)
							{
								buttonBorderStyle1 = ((ButtonBorderStyle) (this.x7e5b6f1120392742 ? 4 : 5));
							}
							else
							{
								buttonBorderStyle1 = ButtonBorderStyle.Solid;
							}
						}
						else if (base.Enabled)
						{
							buttonBorderStyle1 = ((ButtonBorderStyle) ((this.x753f06f9b5cd6e0d && this.x7e5b6f1120392742) ? 4 : 5));
						}
						else
						{
							buttonBorderStyle1 = ButtonBorderStyle.Solid;
						}
						ControlPaint.DrawBorder (e.Graphics, base.ClientRectangle, this.BackColor, this.x55bc7f15d48063ab, buttonBorderStyle1, this.BackColor, this.x55bc7f15d48063ab, buttonBorderStyle1, this.BackColor, this.x55bc7f15d48063ab, 
						buttonBorderStyle1, this.BackColor, this.x55bc7f15d48063ab, buttonBorderStyle1);
					}
					else if (this.xc9b9743c6a16e903 == -1)
					{
						if (this.xd36653cb399695c7 != -1)
						{
							ControlPaint.DrawImageDisabled (e.Graphics, this.x2993d26e54ff8a77.Images[this.xd36653cb399695c7], 1, 1, this.BackColor);
						}
					}
					else if (this.x295aa0055499b2a1 != null)
					{
						image1 = this.x2993d26e54ff8a77.Images[this.xc9b9743c6a16e903];
						pointArray1 = new Point[3];
						pointArray1[0].X = 1;
						pointArray1[0].Y = 1;
						pointArray1[1].X = (pointArray1[0].X + image1.Width);
						pointArray1[1].Y = pointArray1[0].Y;
						pointArray1[2].X = pointArray1[0].X;
						pointArray1[2].Y = (pointArray1[1].Y + image1.Height);
						e.Graphics.DrawImage (this.x2993d26e54ff8a77.Images[this.xc9b9743c6a16e903], pointArray1, new Rectangle (0, 0, image1.Width, image1.Height), GraphicsUnit.Pixel, this.x295aa0055499b2a1);
					}
					else
					{
						e.Graphics.DrawImage (this.x2993d26e54ff8a77.Images[this.xc9b9743c6a16e903], new Point (1, 1));
					}
				}
				base.OnPaint (e);
			}
			
			public void xe8347ded66542b74 (ImageList x6ec0d1228599f9ae, int xc17cd053481cd654, int x3af67ce3cb1fa27a, ImageAttributes x056b92012ec4abb5)
			
			/*
				// Code Size: 101 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.ImageList x2993d26e54ff8a77
				L_0007: ldarg.0 
				L_0008: ldarg.2 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xd36653cb399695c7
				L_000e: ldarg.0 
				L_000f: ldarg.3 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 xc9b9743c6a16e903
				L_0015: ldarg.0 
				L_0016: ldarg.s x056b92012ec4abb5
				L_0018: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Drawing.Imaging.ImageAttributes x295aa0055499b2a1
				L_001d: ldarg.0 
				L_001e: ldc.i4.2 
				L_001f: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Int32 x55bc7f15d48063ab
				L_0024: ldarg.0 
				L_0025: ldc.i4.0 
				L_0026: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x753f06f9b5cd6e0d
				L_002b: ldarg.0 
				L_002c: ldc.i4.0 
				L_002d: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x7e5b6f1120392742
				L_0032: ldarg.0 
				L_0033: ldc.i4.1 
				L_0034: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Boolean x21da04747061b494
				L_0039: ldarg.0 
				L_003a: ldc.i4.0 
				L_003b: stfld Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::System.Windows.Forms.MouseButtons x2092ce7be83a9db0
				L_0040: ldarg.0 
				L_0041: ldc.i4 73730
				L_0046: ldc.i4.1 
				L_0047: call System.Windows.Forms.Control::Void SetStyle(System.Windows.Forms.ControlStyles, Boolean)
				L_004c: ldarg.0 
				L_004d: ldc.i4 4096
				L_0052: ldc.i4.0 
				L_0053: call System.Windows.Forms.Control::Void SetStyle(System.Windows.Forms.ControlStyles, Boolean)
				L_0058: ldarg.0 
				L_0059: ldc.i4 512
				L_005e: ldc.i4.0 
				L_005f: call System.Windows.Forms.Control::Void SetStyle(System.Windows.Forms.ControlStyles, Boolean)
				L_0064: ret 
			*/
			
			
			{
				this.x2993d26e54ff8a77 = x6ec0d1228599f9ae;
				this.xd36653cb399695c7 = xc17cd053481cd654;
				this.xc9b9743c6a16e903 = x3af67ce3cb1fa27a;
				this.x295aa0055499b2a1 = x056b92012ec4abb5;
				this.x55bc7f15d48063ab = 2;
				this.x753f06f9b5cd6e0d = false;
				this.x7e5b6f1120392742 = false;
				this.x21da04747061b494 = true;
				this.x2092ce7be83a9db0 = MouseButtons.None;
				base.SetStyle ((ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer), true);
				base.SetStyle (ControlStyles.StandardDoubleClick, false);
				base.SetStyle (ControlStyles.Selectable, false);
			}
			
		#endregion
	}
	
}

