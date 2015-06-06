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
		
	internal class x896bb4cf7b29301a : xbd3f2493841f18a1
	
	{
		
		#region Constructors
		
			public x896bb4cf7b29301a (Control control, ISkinEngine engine)
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
		
		#region Properties
		
			protected override bool ChangeFontColor
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.1 
					L_0001: ret 
				*/
				
				{
					return true;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void DoInit ()
			
			/*
				// Code Size: 73 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.CheckBox V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: castclass System.Windows.Forms.CheckBox
				L_0011: stloc.0 
				L_0012: ldloc.0 
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.x896bb4cf7b29301a::Void x1dba4f67a1b5a3fb(System.Object, System.EventArgs)
				L_001a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.CheckBox::Void add_CheckedChanged(System.EventHandler)
				L_0024: ldloc.0 
				L_0025: ldarg.0 
				L_0026: ldftn Sunisoft.IrisSkin.x896bb4cf7b29301a::Void xf0204c2f26f9917d(System.Object, System.EventArgs)
				L_002c: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0031: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0036: ldloc.0 
				L_0037: ldarg.0 
				L_0038: ldftn Sunisoft.IrisSkin.x896bb4cf7b29301a::Void x6d90c2026f9061d8(System.Object, System.Windows.Forms.PaintEventArgs)
				L_003e: newobj System.Windows.Forms.PaintEventHandler::Void .ctor(System.Object, IntPtr)
				L_0043: callvirt System.Windows.Forms.Control::Void add_Paint(System.Windows.Forms.PaintEventHandler)
				L_0048: ret 
			*/
			
			
			{
				base.DoInit ();
				CheckBox checkBox1 = ((CheckBox) base.xcd9cdf30888d2204);
				checkBox1.CheckedChanged += new EventHandler (this.x1dba4f67a1b5a3fb);
				checkBox1.Click += new EventHandler (this.xf0204c2f26f9917d);
				checkBox1.Paint += new PaintEventHandler (this.x6d90c2026f9061d8);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 76 Bytes
				.maxstack 3
				.locals (System.Drawing.Graphics V_0, 
         System.Drawing.Rectangle V_1)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.1 
				L_000c: ldloca.s V_1
				L_000e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0013: ldc.i4.0 
				L_0014: ble.s L_002c
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001c: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0021: stloc.1 
				L_0022: ldloca.s V_1
				L_0024: call System.Drawing.Rectangle::Int32 get_Height()
				L_0029: ldc.i4.0 
				L_002a: bgt.s L_002d
				L_002c: ret 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0033: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0038: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_003d: stloc.0 
				L_003e: ldarg.0 
				L_003f: ldloc.0 
				L_0040: call Sunisoft.IrisSkin.x896bb4cf7b29301a::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0045: ldloc.0 
				L_0046: callvirt System.Drawing.Graphics::Void Dispose()
				L_004b: ret 
			*/
			
			
			{
				if ((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0))
				{
					return;
				}
				Graphics graphics1 = Graphics.FromHwnd (base.xcd9cdf30888d2204.Handle);
				this.x8bc95f030953f87b (graphics1);
				graphics1.Dispose ();
			}
			
			private void x1dba4f67a1b5a3fb (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_000e
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_000e: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x6d90c2026f9061d8 (object xe0292b9ed559da7d, PaintEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldarg.2 
				L_000a: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_000f: call Sunisoft.IrisSkin.x896bb4cf7b29301a::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0014: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.x8bc95f030953f87b (xfbf34718e704c6bc.Graphics);
				}
			}
			
			private void x6f37a3496a324cf4 (Graphics x4b101060f4767186, int x43abf768b4ac7ff4)
			
			/*
				// Code Size: 511 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.CheckBox V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.StringFormat V_2, 
         System.Drawing.Brush V_3, 
         System.Drawing.ContentAlignment V_4)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.CheckBox
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.ButtonBase::System.Drawing.ContentAlignment get_TextAlign()
				L_0012: ldloc.0 
				L_0013: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0018: ldloc.0 
				L_0019: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_001e: ldloca.s V_1
				L_0020: ldloca.s V_2
				L_0022: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x323b3762dd22c667(System.Drawing.ContentAlignment, System.Drawing.Rectangle, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle ByRef, System.Drawing.StringFormat ByRef)
				L_0027: ldloc.0 
				L_0028: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_002d: ldc.i4.1 
				L_002e: and 
				L_002f: ldc.i4.1 
				L_0030: bne.un L_00d3
				L_0035: ldloc.0 
				L_0036: callvirt System.Windows.Forms.CheckBox::System.Drawing.ContentAlignment get_CheckAlign()
				L_003b: stloc.s V_4
				L_003d: ldloc.s V_4
				L_003f: ldc.i4.s 32
				L_0041: bgt.s L_006d
				L_0043: ldloc.s V_4
				L_0045: ldc.i4.1 
				L_0046: sub 
				L_0047: switch (L_009c, L_0163, L_009c, L_00b0)
				L_005c: ldloc.s V_4
				L_005e: ldc.i4.s 16
				L_0060: beq.s L_009c
				L_0062: ldloc.s V_4
				L_0064: ldc.i4.s 32
				L_0066: beq L_0163
				L_006b: br.s L_009c
				L_006d: ldloc.s V_4
				L_006f: ldc.i4 256
				L_0074: bgt.s L_0087
				L_0076: ldloc.s V_4
				L_0078: ldc.i4.s 64
				L_007a: beq.s L_00b0
				L_007c: ldloc.s V_4
				L_007e: ldc.i4 256
				L_0083: beq.s L_009c
				L_0085: br.s L_009c
				L_0087: ldloc.s V_4
				L_0089: ldc.i4 512
				L_008e: beq L_0163
				L_0093: ldloc.s V_4
				L_0095: ldc.i4 1024
				L_009a: beq.s L_00b0
				L_009c: ldloca.s V_1
				L_009e: dup 
				L_009f: call System.Drawing.Rectangle::Int32 get_Width()
				L_00a4: ldarg.2 
				L_00a5: sub 
				L_00a6: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00ab: br L_0163
				L_00b0: ldloca.s V_1
				L_00b2: dup 
				L_00b3: call System.Drawing.Rectangle::Int32 get_X()
				L_00b8: ldarg.2 
				L_00b9: add 
				L_00ba: call System.Drawing.Rectangle::Void set_X(Int32)
				L_00bf: ldloca.s V_1
				L_00c1: dup 
				L_00c2: call System.Drawing.Rectangle::Int32 get_Width()
				L_00c7: ldarg.2 
				L_00c8: sub 
				L_00c9: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00ce: br L_0163
				L_00d3: ldloc.0 
				L_00d4: callvirt System.Windows.Forms.CheckBox::System.Drawing.ContentAlignment get_CheckAlign()
				L_00d9: stloc.s V_4
				L_00db: ldloc.s V_4
				L_00dd: ldc.i4.s 32
				L_00df: bgt.s L_0108
				L_00e1: ldloc.s V_4
				L_00e3: ldc.i4.1 
				L_00e4: sub 
				L_00e5: switch (L_0134, L_0163, L_0134, L_0154)
				L_00fa: ldloc.s V_4
				L_00fc: ldc.i4.s 16
				L_00fe: beq.s L_0134
				L_0100: ldloc.s V_4
				L_0102: ldc.i4.s 32
				L_0104: beq.s L_0163
				L_0106: br.s L_0134
				L_0108: ldloc.s V_4
				L_010a: ldc.i4 256
				L_010f: bgt.s L_0122
				L_0111: ldloc.s V_4
				L_0113: ldc.i4.s 64
				L_0115: beq.s L_0154
				L_0117: ldloc.s V_4
				L_0119: ldc.i4 256
				L_011e: beq.s L_0134
				L_0120: br.s L_0134
				L_0122: ldloc.s V_4
				L_0124: ldc.i4 512
				L_0129: beq.s L_0163
				L_012b: ldloc.s V_4
				L_012d: ldc.i4 1024
				L_0132: beq.s L_0154
				L_0134: ldloca.s V_1
				L_0136: dup 
				L_0137: call System.Drawing.Rectangle::Int32 get_X()
				L_013c: ldarg.2 
				L_013d: add 
				L_013e: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0143: ldloca.s V_1
				L_0145: dup 
				L_0146: call System.Drawing.Rectangle::Int32 get_Width()
				L_014b: ldarg.2 
				L_014c: sub 
				L_014d: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0152: br.s L_0163
				L_0154: ldloca.s V_1
				L_0156: dup 
				L_0157: call System.Drawing.Rectangle::Int32 get_Width()
				L_015c: ldarg.2 
				L_015d: sub 
				L_015e: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0163: ldarg.0 
				L_0164: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0169: ldc.i4.3 
				L_016a: bne.un.s L_0175
				L_016c: ldloca.s V_1
				L_016e: ldc.i4.1 
				L_016f: ldc.i4.1 
				L_0170: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_0175: ldarg.0 
				L_0176: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_017b: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0180: brfalse.s L_0195
				L_0182: ldarg.0 
				L_0183: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0188: callvirt System.Windows.Forms.Control::System.Drawing.Color get_ForeColor()
				L_018d: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0192: stloc.3 
				L_0193: br.s L_019b
				L_0195: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_019a: stloc.3 
				L_019b: ldarg.1 
				L_019c: ldloc.0 
				L_019d: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_01a2: ldloc.0 
				L_01a3: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_01a8: ldloc.3 
				L_01a9: ldloc.1 
				L_01aa: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_01af: ldloc.2 
				L_01b0: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_01b5: ldloc.0 
				L_01b6: callvirt System.Windows.Forms.Control::Boolean get_Focused()
				L_01bb: brfalse.s L_01e8
				L_01bd: ldarg.1 
				L_01be: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen get_x6ee6589d93f80946()
				L_01c3: ldloca.s V_1
				L_01c5: call System.Drawing.Rectangle::Int32 get_X()
				L_01ca: ldloca.s V_1
				L_01cc: call System.Drawing.Rectangle::Int32 get_Y()
				L_01d1: ldloca.s V_1
				L_01d3: call System.Drawing.Rectangle::Int32 get_Width()
				L_01d8: ldc.i4.1 
				L_01d9: sub 
				L_01da: ldloca.s V_1
				L_01dc: call System.Drawing.Rectangle::Int32 get_Height()
				L_01e1: ldc.i4.1 
				L_01e2: sub 
				L_01e3: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_01e8: ldarg.0 
				L_01e9: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01ee: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_01f3: brfalse.s L_01fe
				L_01f5: ldloc.3 
				L_01f6: brfalse.s L_01fe
				L_01f8: ldloc.3 
				L_01f9: callvirt System.Drawing.Brush::Void Dispose()
				L_01fe: ret 
			*/
			
			
			{
				CheckBox checkBox1;
				Rectangle rectangle1;
				StringFormat stringFormat1;
				Brush brush1;
				ContentAlignment contentAlignment1;
				checkBox1 = ((CheckBox) base.xcd9cdf30888d2204);
				x448fd9ab43628c71.x323b3762dd22c667 (checkBox1.TextAlign, checkBox1.ClientRectangle, checkBox1.RightToLeft, out rectangle1, out stringFormat1);
				if ((checkBox1.RightToLeft & RightToLeft.Yes) != RightToLeft.Yes)
				{
					contentAlignment1 = checkBox1.CheckAlign;
					if (contentAlignment1 > ContentAlignment.MiddleCenter)
					{
						if (contentAlignment1 > ContentAlignment.BottomLeft)
						{
							if (contentAlignment1 == ContentAlignment.BottomCenter)
							{
								goto L_0163;
							}
							else if (contentAlignment1 == ContentAlignment.BottomRight)
							{
								goto L_0154;
							}
							else
							{
								goto L_0134;
							}
						}
						if (contentAlignment1 == ContentAlignment.MiddleRight)
						{
							goto L_0154;
						}
						else
						{
							goto L_0134;
						}
					}
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						case  ((ContentAlignment) 3):
						
						{
								goto L_0134;
						}
						case ContentAlignment.TopCenter:
						
						{
								goto L_0163;
						}
						case ContentAlignment.TopRight:
						
						{
								goto L_0154;
						}
					}
					if ((contentAlignment1 != ContentAlignment.MiddleLeft) && (contentAlignment1 == ContentAlignment.MiddleCenter))
					{
						goto L_0163;
					}
					else
					{
						goto L_0134;
					}
				}
				contentAlignment1 = checkBox1.CheckAlign;
				if (contentAlignment1 <= ContentAlignment.MiddleCenter)
				{
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						case  ((ContentAlignment) 3):
						
						{
								goto L_009C;
						}
						case ContentAlignment.TopCenter:
						
						{
								goto L_0163;
						}
						case ContentAlignment.TopRight:
						
						{
								goto L_00B0;
						}
					}
					if ((contentAlignment1 != ContentAlignment.MiddleLeft) && (contentAlignment1 == ContentAlignment.MiddleCenter))
					{
						goto L_0163;
					}
					else
					{
						goto L_009C;
					}
				}
				if (contentAlignment1 <= ContentAlignment.BottomLeft)
				{
					if (contentAlignment1 == ContentAlignment.MiddleRight)
					{
						goto L_00B0;
					}
					else
					{
						goto L_009C;
					}
				}
				if (contentAlignment1 == ContentAlignment.BottomCenter)
				{
					goto L_0163;
				}
				if (contentAlignment1 == ContentAlignment.BottomRight)
				{
					goto L_00B0;
				}
				
			L_009C:
				
				{
				}
				rectangle1.Width -= x43abf768b4ac7ff4;
				goto L_0163;
				
			L_00B0:
				
				{
				}
				rectangle1.X += x43abf768b4ac7ff4;
				rectangle1.Width -= x43abf768b4ac7ff4;
				goto L_0163;
				
			L_0134:
				
				{
				}
				rectangle1.X += x43abf768b4ac7ff4;
				rectangle1.Width -= x43abf768b4ac7ff4;
				goto L_0163;
				
			L_0154:
				
				{
				}
				rectangle1.Width -= x43abf768b4ac7ff4;
				
			L_0163:
				
				{
				}
				if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
				{
					x448fd9ab43628c71.x897356c8698a543c (ref rectangle1, 1, 1);
				}
				if (base.xcd9cdf30888d2204.Enabled)
				{
					brush1 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.ForeColor));
				}
				else
				{
					brush1 = Brushes.Gray;
				}
				x4b101060f4767186.DrawString (checkBox1.Text, checkBox1.Font, brush1, ((RectangleF) rectangle1), stringFormat1);
				if (checkBox1.Focused)
				{
					x4b101060f4767186.DrawRectangle (x448fd9ab43628c71.x6ee6589d93f80946, rectangle1.X, rectangle1.Y, ((int) (rectangle1.Width - 1)), ((int) (rectangle1.Height - 1)));
				}
				if (base.xcd9cdf30888d2204.Enabled && (brush1 != null))
				{
					brush1.Dispose ();
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 260 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.CheckBox V_0, 
         System.Int32 V_1, 
         System.Drawing.Bitmap V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Drawing.Brush V_5, 
         System.Drawing.Rectangle V_6, 
         System.Drawing.Rectangle V_7)
				.try L_0090 to L_00f7 finally L_00f7 to L_0103
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.CheckBox
				L_000b: stloc.0 
				L_000c: ldc.i4.0 
				L_000d: stloc.1 
				L_000e: ldloc.0 
				L_000f: callvirt System.Windows.Forms.CheckBox::System.Windows.Forms.CheckState get_CheckState()
				L_0014: ldc.i4.1 
				L_0015: bne.un.s L_0027
				L_0017: ldloc.0 
				L_0018: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_001d: brfalse.s L_0023
				L_001f: ldc.i4.1 
				L_0020: stloc.1 
				L_0021: br.s L_004e
				L_0023: ldc.i4.4 
				L_0024: stloc.1 
				L_0025: br.s L_004e
				L_0027: ldloc.0 
				L_0028: callvirt System.Windows.Forms.CheckBox::System.Windows.Forms.CheckState get_CheckState()
				L_002d: ldc.i4.2 
				L_002e: bne.un.s L_0040
				L_0030: ldloc.0 
				L_0031: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0036: brfalse.s L_003c
				L_0038: ldc.i4.2 
				L_0039: stloc.1 
				L_003a: br.s L_004e
				L_003c: ldc.i4.5 
				L_003d: stloc.1 
				L_003e: br.s L_004e
				L_0040: ldloc.0 
				L_0041: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0046: brfalse.s L_004c
				L_0048: ldc.i4.3 
				L_0049: stloc.1 
				L_004a: br.s L_004e
				L_004c: ldc.i4.6 
				L_004d: stloc.1 
				L_004e: ldarg.0 
				L_004f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0054: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0059: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_005e: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_CHECKBOX()
				L_0063: ldloc.1 
				L_0064: ldelem.ref 
				L_0065: stloc.2 
				L_0066: ldloc.2 
				L_0067: callvirt System.Drawing.Image::Int32 get_Width()
				L_006c: ldc.i4.s 13
				L_006e: call System.Math::Int32 Max(Int32, Int32)
				L_0073: stloc.3 
				L_0074: ldloc.2 
				L_0075: callvirt System.Drawing.Image::Int32 get_Height()
				L_007a: ldc.i4.s 13
				L_007c: call System.Math::Int32 Max(Int32, Int32)
				L_0081: stloc.s V_4
				L_0083: ldloc.0 
				L_0084: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0089: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_008e: stloc.s V_5
				L_0090: ldloc.0 
				L_0091: callvirt System.Windows.Forms.CheckBox::System.Drawing.ContentAlignment get_CheckAlign()
				L_0096: ldloc.0 
				L_0097: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_009c: ldloc.0 
				L_009d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00a2: ldloc.3 
				L_00a3: ldloc.s V_4
				L_00a5: ldc.i4.0 
				L_00a6: ldc.i4.0 
				L_00a7: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Rectangle x323b3762dd22c667(System.Drawing.ContentAlignment, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle, Int32, Int32, Int32, Int32)
				L_00ac: stloc.s V_7
				L_00ae: ldarg.1 
				L_00af: ldloc.s V_5
				L_00b1: ldloc.0 
				L_00b2: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00b7: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00bc: ldloca.s V_6
				L_00be: ldc.i4.0 
				L_00bf: ldc.i4.0 
				L_00c0: ldloc.2 
				L_00c1: callvirt System.Drawing.Image::Int32 get_Width()
				L_00c6: ldloc.2 
				L_00c7: callvirt System.Drawing.Image::Int32 get_Height()
				L_00cc: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00d1: ldarg.1 
				L_00d2: ldloc.2 
				L_00d3: ldloc.s V_7
				L_00d5: ldloc.s V_6
				L_00d7: ldc.i4.2 
				L_00d8: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00dd: ldloc.0 
				L_00de: callvirt System.Windows.Forms.ButtonBase::System.Drawing.Image get_Image()
				L_00e3: brfalse.s L_00ed
				L_00e5: ldarg.0 
				L_00e6: ldarg.1 
				L_00e7: ldloc.3 
				L_00e8: call Sunisoft.IrisSkin.x896bb4cf7b29301a::Void xcea9a0eaf0e83f21(System.Drawing.Graphics, Int32)
				L_00ed: ldarg.0 
				L_00ee: ldarg.1 
				L_00ef: ldloc.3 
				L_00f0: call Sunisoft.IrisSkin.x896bb4cf7b29301a::Void x6f37a3496a324cf4(System.Drawing.Graphics, Int32)
				L_00f5: leave.s L_0103
				L_00f7: ldloc.s V_5
				L_00f9: brfalse.s L_0102
				L_00fb: ldloc.s V_5
				L_00fd: callvirt System.IDisposable::Void Dispose()
				L_0102: endfinally 
				L_0103: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				CheckBox checkBox1 = ((CheckBox) base.xcd9cdf30888d2204);
				int i1 = 0;
				if (checkBox1.CheckState == CheckState.Checked)
				{
					if (checkBox1.Enabled)
					{
						i1 = 1;
					}
					else
					{
						i1 = 4;
					}
				}
				else if (checkBox1.CheckState == CheckState.Indeterminate)
				{
					if (checkBox1.Enabled)
					{
						i1 = 2;
					}
					else
					{
						i1 = 5;
					}
				}
				else if (checkBox1.Enabled)
				{
					i1 = 3;
				}
				else
				{
					i1 = 6;
				}
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_CHECKBOX[i1];
				int i2 = Math.Max (bitmap1.Width, 13);
				int i3 = Math.Max (bitmap1.Height, 13);
				using (Brush brush1 = ((Brush) new SolidBrush (checkBox1.BackColor)))
				{
					rectangle2 = x448fd9ab43628c71.x323b3762dd22c667 (checkBox1.CheckAlign, checkBox1.RightToLeft, checkBox1.ClientRectangle, i2, i3, 0, 0);
					x4b101060f4767186.FillRectangle (brush1, checkBox1.ClientRectangle);
					rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
					if (checkBox1.Image != null)
					{
						this.xcea9a0eaf0e83f21 (x4b101060f4767186, i2);
					}
					this.x6f37a3496a324cf4 (x4b101060f4767186, i2);
				}
			}
			
			private void xcea9a0eaf0e83f21 (Graphics x4b101060f4767186, int x43abf768b4ac7ff4)
			
			/*
				// Code Size: 272 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.CheckBox V_0, 
         System.Drawing.Image V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.ContentAlignment V_4)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.CheckBox
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.ButtonBase::System.Drawing.Image get_Image()
				L_0012: stloc.1 
				L_0013: ldloc.1 
				L_0014: callvirt System.Drawing.Image::Int32 get_Height()
				L_0019: ldc.i4.0 
				L_001a: ble.s L_0025
				L_001c: ldloc.1 
				L_001d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0022: ldc.i4.0 
				L_0023: bgt.s L_0026
				L_0025: ret 
				L_0026: ldloc.0 
				L_0027: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_002c: stloc.2 
				L_002d: ldloc.0 
				L_002e: callvirt System.Windows.Forms.CheckBox::System.Drawing.ContentAlignment get_CheckAlign()
				L_0033: stloc.s V_4
				L_0035: ldloc.s V_4
				L_0037: ldc.i4.s 32
				L_0039: bgt.s L_0062
				L_003b: ldloc.s V_4
				L_003d: ldc.i4.1 
				L_003e: sub 
				L_003f: switch (L_008e, L_00bd, L_008e, L_00ae)
				L_0054: ldloc.s V_4
				L_0056: ldc.i4.s 16
				L_0058: beq.s L_008e
				L_005a: ldloc.s V_4
				L_005c: ldc.i4.s 32
				L_005e: beq.s L_00bd
				L_0060: br.s L_008e
				L_0062: ldloc.s V_4
				L_0064: ldc.i4 256
				L_0069: bgt.s L_007c
				L_006b: ldloc.s V_4
				L_006d: ldc.i4.s 64
				L_006f: beq.s L_00ae
				L_0071: ldloc.s V_4
				L_0073: ldc.i4 256
				L_0078: beq.s L_008e
				L_007a: br.s L_008e
				L_007c: ldloc.s V_4
				L_007e: ldc.i4 512
				L_0083: beq.s L_00bd
				L_0085: ldloc.s V_4
				L_0087: ldc.i4 1024
				L_008c: beq.s L_00ae
				L_008e: ldloca.s V_2
				L_0090: dup 
				L_0091: call System.Drawing.Rectangle::Int32 get_X()
				L_0096: ldarg.2 
				L_0097: add 
				L_0098: call System.Drawing.Rectangle::Void set_X(Int32)
				L_009d: ldloca.s V_2
				L_009f: dup 
				L_00a0: call System.Drawing.Rectangle::Int32 get_Width()
				L_00a5: ldarg.2 
				L_00a6: sub 
				L_00a7: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00ac: br.s L_00bd
				L_00ae: ldloca.s V_2
				L_00b0: dup 
				L_00b1: call System.Drawing.Rectangle::Int32 get_Width()
				L_00b6: ldarg.2 
				L_00b7: sub 
				L_00b8: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00bd: ldloc.0 
				L_00be: callvirt System.Windows.Forms.ButtonBase::System.Drawing.ContentAlignment get_ImageAlign()
				L_00c3: ldloc.0 
				L_00c4: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_00c9: ldloc.2 
				L_00ca: ldloc.1 
				L_00cb: callvirt System.Drawing.Image::Int32 get_Width()
				L_00d0: ldloc.1 
				L_00d1: callvirt System.Drawing.Image::Int32 get_Height()
				L_00d6: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Rectangle x323b3762dd22c667(System.Drawing.ContentAlignment, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle, Int32, Int32)
				L_00db: stloc.3 
				L_00dc: ldarg.0 
				L_00dd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_00e2: ldc.i4.3 
				L_00e3: bne.un.s L_00ee
				L_00e5: ldloca.s V_3
				L_00e7: ldc.i4.1 
				L_00e8: ldc.i4.1 
				L_00e9: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_00ee: ldarg.1 
				L_00ef: ldloc.1 
				L_00f0: ldloca.s V_3
				L_00f2: call System.Drawing.Rectangle::Int32 get_X()
				L_00f7: ldloca.s V_3
				L_00f9: call System.Drawing.Rectangle::Int32 get_Y()
				L_00fe: ldloc.1 
				L_00ff: callvirt System.Drawing.Image::Int32 get_Width()
				L_0104: ldloc.1 
				L_0105: callvirt System.Drawing.Image::Int32 get_Height()
				L_010a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32, Int32, Int32)
				L_010f: ret 
			*/
			
			
			{
				CheckBox checkBox1;
				Image image1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				ContentAlignment contentAlignment1;
				checkBox1 = ((CheckBox) base.xcd9cdf30888d2204);
				image1 = checkBox1.Image;
				if ((image1.Height <= 0) || (image1.Width <= 0))
				{
					return;
				}
				rectangle1 = checkBox1.ClientRectangle;
				contentAlignment1 = checkBox1.CheckAlign;
				if (contentAlignment1 <= ContentAlignment.MiddleCenter)
				{
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						case  ((ContentAlignment) 3):
						
						{
								goto L_008E;
						}
						case ContentAlignment.TopCenter:
						
						{
								goto L_00BD;
						}
						case ContentAlignment.TopRight:
						
						{
								goto L_00AE;
						}
					}
					if ((contentAlignment1 != ContentAlignment.MiddleLeft) && (contentAlignment1 == ContentAlignment.MiddleCenter))
					{
						goto L_00BD;
					}
					else
					{
						goto L_008E;
					}
				}
				if (contentAlignment1 <= ContentAlignment.BottomLeft)
				{
					if (contentAlignment1 == ContentAlignment.MiddleRight)
					{
						goto L_00AE;
					}
					else
					{
						goto L_008E;
					}
				}
				if (contentAlignment1 == ContentAlignment.BottomCenter)
				{
					goto L_00BD;
				}
				if (contentAlignment1 == ContentAlignment.BottomRight)
				{
					goto L_00AE;
				}
				
			L_008E:
				
				{
				}
				rectangle1.X += x43abf768b4ac7ff4;
				rectangle1.Width -= x43abf768b4ac7ff4;
				goto L_00BD;
				
			L_00AE:
				
				{
				}
				rectangle1.Width -= x43abf768b4ac7ff4;
				
			L_00BD:
				
				{
				}
				rectangle2 = x448fd9ab43628c71.x323b3762dd22c667 (checkBox1.ImageAlign, checkBox1.RightToLeft, rectangle1, image1.Width, image1.Height);
				if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
				{
					x448fd9ab43628c71.x897356c8698a543c (ref rectangle2, 1, 1);
				}
				x4b101060f4767186.DrawImage (image1, rectangle2.X, rectangle2.Y, image1.Width, image1.Height);
			}
			
			private void xf0204c2f26f9917d (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_000e
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_000e: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
		#endregion
	}
	
}

