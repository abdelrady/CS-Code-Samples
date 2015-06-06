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
			
			
		#endregion
		
	internal class x4c8858ac0e107176 : xf7df44b87349eabf
	
	{
		
		#region Constructors
		
			public x4c8858ac0e107176 (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xf7df44b87349eabf::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void PaintControl ()
			
			/*
				// Code Size: 331 Bytes
				.maxstack 8
				.locals (System.Drawing.Brush V_0, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_1, 
         System.Drawing.Rectangle V_2, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+COMBOBOXINFO V_3, 
         System.IntPtr V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Drawing.Graphics V_7, 
         System.Drawing.Pen V_8)
				.try L_00c6 to L_00f1 finally L_00f1 to L_00fd
				.try L_0049 to L_0130 finally L_0130 to L_013c
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xf7df44b87349eabf::Void PaintControl()
				L_0006: ldloca.s V_1
				L_0008: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_000e: ldloca.s V_3
				L_0010: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+COMBOBOXINFO
				L_0016: ldloca.s V_3
				L_0018: ldc.i4.s 52
				L_001a: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+COMBOBOXINFO::UInt32 cbSize
				L_001f: ldarg.0 
				L_0020: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0025: ldloca.s V_3
				L_0027: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetComboBoxInfo(IntPtr, COMBOBOXINFO ByRef)
				L_002c: brtrue.s L_002f
				L_002e: ret 
				L_002f: ldarg.0 
				L_0030: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0035: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_003a: stloc.s V_4
				L_003c: ldarg.0 
				L_003d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0042: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0047: stloc.s V_7
				L_0049: ldloca.s V_3
				L_004b: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+COMBOBOXINFO::RECT rcButton
				L_0050: stloc.1 
				L_0051: ldloca.s V_2
				L_0053: ldloca.s V_1
				L_0055: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_005a: ldloca.s V_1
				L_005c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0061: ldloca.s V_1
				L_0063: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0068: ldloca.s V_1
				L_006a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_006f: sub 
				L_0070: ldloca.s V_1
				L_0072: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0077: ldloca.s V_1
				L_0079: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_007e: sub 
				L_007f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0084: ldarg.0 
				L_0085: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_008a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_008f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0094: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0099: stloc.0 
				L_009a: ldloc.s V_7
				L_009c: ldloc.0 
				L_009d: ldloc.2 
				L_009e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00a3: ldarg.0 
				L_00a4: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a9: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00ae: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00b3: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_00b8: stloc.0 
				L_00b9: ldloc.0 
				L_00ba: ldc.r4 1
				L_00bf: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_00c4: stloc.s V_8
				L_00c6: ldloc.s V_7
				L_00c8: ldloc.s V_8
				L_00ca: ldloca.s V_2
				L_00cc: call System.Drawing.Rectangle::Int32 get_Left()
				L_00d1: ldloca.s V_2
				L_00d3: call System.Drawing.Rectangle::Int32 get_Top()
				L_00d8: ldc.i4.1 
				L_00d9: sub 
				L_00da: ldloca.s V_2
				L_00dc: call System.Drawing.Rectangle::Int32 get_Left()
				L_00e1: ldloca.s V_2
				L_00e3: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00e8: ldc.i4.1 
				L_00e9: add 
				L_00ea: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00ef: leave.s L_00fd
				L_00f1: ldloc.s V_8
				L_00f3: brfalse.s L_00fc
				L_00f5: ldloc.s V_8
				L_00f7: callvirt System.IDisposable::Void Dispose()
				L_00fc: endfinally 
				L_00fd: ldloca.s V_2
				L_00ff: call System.Drawing.Rectangle::Int32 get_Width()
				L_0104: ldc.i4.2 
				L_0105: div 
				L_0106: ldloca.s V_2
				L_0108: call System.Drawing.Rectangle::Int32 get_Left()
				L_010d: add 
				L_010e: ldc.i4.3 
				L_010f: sub 
				L_0110: stloc.s V_5
				L_0112: ldloca.s V_2
				L_0114: call System.Drawing.Rectangle::Int32 get_Height()
				L_0119: ldc.i4.2 
				L_011a: div 
				L_011b: stloc.s V_6
				L_011d: ldloc.s V_7
				L_011f: ldloc.s V_5
				L_0121: ldloc.s V_6
				L_0123: ldarg.0 
				L_0124: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0129: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x3fbffc8bcd27b3c0(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_012e: leave.s L_013c
				L_0130: ldloc.s V_7
				L_0132: brfalse.s L_013b
				L_0134: ldloc.s V_7
				L_0136: callvirt System.IDisposable::Void Dispose()
				L_013b: endfinally 
				L_013c: ldarg.0 
				L_013d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0142: ldloc.s V_4
				L_0144: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0149: pop 
				L_014a: ret 
			*/
			
			
			{
				Brush brush1;
				Rectangle rectangle1;
				int i1;
				int i2;
				base.PaintControl ();
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				x40255b11ef821fa3.COMBOBOXINFO cOMBOBOXINFO1 = new x40255b11ef821fa3.COMBOBOXINFO ();
				cOMBOBOXINFO1.cbSize = 52;
				if (! x61467fe65a98f20c.GetComboBoxInfo (base.Handle, ref cOMBOBOXINFO1))
				{
					return;
				}
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					rectangle1 = new Rectangle ((rECT1 = cOMBOBOXINFO1.rcButton).left, rECT1.top, ((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top)));
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
					graphics1.FillRectangle (brush1, rectangle1);
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
					using (Pen pen1 = new Pen (brush1, 1F))
					{
						graphics1.DrawLine (pen1, rectangle1.Left, ((int) (rectangle1.Top - 1)), rectangle1.Left, ((int) (rectangle1.Bottom + 1)));
					}
					i1 = (((rectangle1.Width / 2) + rectangle1.Left) - 3);
					i2 = (rectangle1.Height / 2);
					x448fd9ab43628c71.x3fbffc8bcd27b3c0 (graphics1, i1, i2, this.Enabled);
				}
				int i3 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
		#endregion
	}
	
}

