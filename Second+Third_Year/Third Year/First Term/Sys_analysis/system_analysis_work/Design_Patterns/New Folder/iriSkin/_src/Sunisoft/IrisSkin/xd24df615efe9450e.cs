//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using Sunisoft.IrisSkin.InternalControls;
			using System.Collections;
			using System.Drawing;
			using System.Drawing.Drawing2D;
			using System.Drawing.Imaging;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal abstract class xd24df615efe9450e : NativeWindow
	
	{
		
		#region Fields
			protected Bitmap x15810b502d9e43ee;
			protected Rectangle[] x170170622f070c21;
			private bool x230e512478b11e00;
			protected Form x42f4c234c9358072;
			private bool x507503a87814ae33;
			private int x5a29066520654c5a;
			private int x6b81454f45088f2e;
			protected Hashtable x84603c7eff1953af;
			protected uint x8782b9e138b1b2e0;
			protected int x9579bd00b393fc12;
			protected int x9c67b90604ff861f;
			protected uint x9cc269364e8b3cf1;
			protected Bitmap xa007e927c312863e;
			private string xa4b5d355cbf01a80;
			protected bool xa8de7f7b9ee88efe;
			protected int xb807ac541c41b1ec;
			protected int xc8a0258498c6c151;
			protected Bitmap[] xcacdadb77e32c6dd;
			protected int xcd2b5f9eab575311;
			private x902c4aee45bfd906 xcdc1a69e212e5aa9;
			protected int xdab5261f2cc3422d;
			protected ISkinEngine xdc87e2b99332cd4a;
			protected int xe43c4bad7e91c24a;
			protected int xef9eb32e7f1d1f23;
			protected Hashtable xf04e05b3bf638680;
			protected Color xf12dc3e78d9b1b40;
			protected Bitmap xf7b7e4e5afe45be7;
			private bool xfd408d62a1acef9b;
		#endregion
		
		#region Constructors
		
			public xd24df615efe9450e (IntPtr handle, ISkinEngine engine)
			/*
				// Code Size: 252 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldc.i4.5 
				L_0002: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_0007: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Color xf12dc3e78d9b1b40
				L_000c: ldarg.0 
				L_000d: newobj System.Collections.Hashtable::Void .ctor()
				L_0012: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0017: ldarg.0 
				L_0018: newobj System.Collections.Hashtable::Void .ctor()
				L_001d: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_0022: ldarg.0 
				L_0023: ldc.i4.m1 
				L_0024: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_0029: ldarg.0 
				L_002a: ldc.i4.2 
				L_002b: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_0030: ldarg.0 
				L_0031: ldc.i4.0 
				L_0032: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xa8de7f7b9ee88efe
				L_0037: ldarg.0 
				L_0038: ldc.i4.1 
				L_0039: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x230e512478b11e00
				L_003e: ldarg.0 
				L_003f: ldc.i4.0 
				L_0040: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x6b81454f45088f2e
				L_0045: ldarg.0 
				L_0046: ldc.i4.0 
				L_0047: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_004c: ldarg.0 
				L_004d: ldc.i4.0 
				L_004e: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x507503a87814ae33
				L_0053: ldarg.0 
				L_0054: ldc.i4.0 
				L_0055: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9c67b90604ff861f
				L_005a: ldarg.0 
				L_005b: ldc.i4.0 
				L_005c: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xb807ac541c41b1ec
				L_0061: ldarg.0 
				L_0062: ldc.i4.0 
				L_0063: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xcd2b5f9eab575311
				L_0068: ldarg.0 
				L_0069: ldc.i4.0 
				L_006a: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_006f: ldarg.0 
				L_0070: ldc.i4.4 
				L_0071: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0076: ldarg.0 
				L_0077: ldc.i4.4 
				L_0078: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_007d: ldarg.0 
				L_007e: ldc.i4.1 
				L_007f: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xfd408d62a1acef9b
				L_0084: ldarg.0 
				L_0085: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_008a: ldarg.0 
				L_008b: ldc.i4.1 
				L_008c: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xa8de7f7b9ee88efe
				L_0091: ldarg.0 
				L_0092: ldarg.2 
				L_0093: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0098: ldarg.0 
				L_0099: ldarg.1 
				L_009a: call System.Windows.Forms.Control::System.Windows.Forms.Control FromHandle(IntPtr)
				L_009f: castclass System.Windows.Forms.Form
				L_00a4: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00a9: ldarg.0 
				L_00aa: ldarg.1 
				L_00ab: call System.Windows.Forms.NativeWindow::Void AssignHandle(IntPtr)
				L_00b0: ldarg.0 
				L_00b1: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void GetWindowRestoreSize()
				L_00b6: ldarg.0 
				L_00b7: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x18f04d42fe6eab01()
				L_00bc: ldarg.0 
				L_00bd: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void SaveWindowStyle()
				L_00c2: ldarg.0 
				L_00c3: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_00c8: brfalse.s L_00d0
				L_00ca: ldarg.0 
				L_00cb: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void ResetWindowStyle()
				L_00d0: ldarg.0 
				L_00d1: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void SkinControls()
				L_00d6: ldarg.0 
				L_00d7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void ApplySkin()
				L_00dc: ldarg.0 
				L_00dd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e2: ldarg.0 
				L_00e3: dup 
				L_00e4: ldvirtftn Sunisoft.IrisSkin.xd24df615efe9450e::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_00ea: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_00ef: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_00f4: ldarg.0 
				L_00f5: ldc.i4.0 
				L_00f6: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xa8de7f7b9ee88efe
				L_00fb: ret 
			*/
		#endregion
		
		#region Properties
		
			protected abstract FormBorderStyle BorderStyle
			
			{
				get;
			}
			
			
			protected virtual bool CanPaint
			
			{
				get
				
				/*
					// Code Size: 133 Bytes
					.maxstack 4
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_000b: brfalse.s L_0025
					L_000d: ldarg.0 
					L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x230e512478b11e00
					L_0013: brfalse.s L_0025
					L_0015: ldarg.0 
					L_0016: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
					L_001b: brtrue.s L_0025
					L_001d: ldarg.0 
					L_001e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormBorderStyle get_BorderStyle()
					L_0023: brtrue.s L_0027
					L_0025: ldc.i4.0 
					L_0026: ret 
					L_0027: ldarg.0 
					L_0028: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_002d: isinst System.Int32
					L_0032: brfalse.s L_004f
					L_0034: ldarg.0 
					L_0035: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_003a: unbox System.Int32
					L_003f: ldind.i4 
					L_0040: ldarg.0 
					L_0041: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0046: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_004b: bne.un.s L_0083
					L_004d: ldc.i4.0 
					L_004e: ret 
					L_004f: ldarg.0 
					L_0050: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_0055: isinst System.String
					L_005a: brfalse.s L_0083
					L_005c: ldarg.0 
					L_005d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_0062: castclass System.String
					L_0067: ldarg.0 
					L_0068: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_006d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0072: stloc.0 
					L_0073: ldloca.s V_0
					L_0075: call System.Int32::System.String ToString()
					L_007a: call System.String::Boolean op_Equality(System.String, System.String)
					L_007f: brfalse.s L_0083
					L_0081: ldc.i4.0 
					L_0082: ret 
					L_0083: ldc.i4.1 
					L_0084: ret 
				*/
				
				{
					if (! ((SkinEngine) this.xdc87e2b99332cd4a).RealActive)
					{
						return false;
					}
					if (! this.x230e512478b11e00)
					{
						return false;
					}
					if (this.IsDisposed)
					{
						return false;
					}
					if (this.BorderStyle == FormBorderStyle.None)
					{
						return false;
					}
					if (this.Tag is int)
					{
						if (((int) this.Tag) != ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
					if (! (this.Tag is string))
					{
						return true;
					}
					int i1 = ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag;
					if (((string) this.Tag) != i1.ToString ())
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			
			
			protected virtual bool CanPaintChild
			
			{
				get
				
				/*
					// Code Size: 127 Bytes
					.maxstack 4
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_000b: brfalse.s L_0015
					L_000d: ldarg.0 
					L_000e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
					L_0013: brfalse.s L_0017
					L_0015: ldc.i4.0 
					L_0016: ret 
					L_0017: ldarg.0 
					L_0018: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_001d: isinst System.Int32
					L_0022: brfalse.s L_003f
					L_0024: ldarg.0 
					L_0025: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_002a: unbox System.Int32
					L_002f: ldind.i4 
					L_0030: ldarg.0 
					L_0031: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0036: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_003b: bne.un.s L_0073
					L_003d: ldc.i4.0 
					L_003e: ret 
					L_003f: ldarg.0 
					L_0040: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_0045: isinst System.String
					L_004a: brfalse.s L_0073
					L_004c: ldarg.0 
					L_004d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Object get_Tag()
					L_0052: castclass System.String
					L_0057: ldarg.0 
					L_0058: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_005d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0062: stloc.0 
					L_0063: ldloca.s V_0
					L_0065: call System.Int32::System.String ToString()
					L_006a: call System.String::Boolean op_Equality(System.String, System.String)
					L_006f: brfalse.s L_0073
					L_0071: ldc.i4.0 
					L_0072: ret 
					L_0073: ldarg.0 
					L_0074: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0079: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_007e: ret 
				*/
				
				{
					if (! ((SkinEngine) this.xdc87e2b99332cd4a).RealActive)
					{
						return false;
					}
					if (this.IsDisposed)
					{
						return false;
					}
					if (this.Tag is int)
					{
						if (((int) this.Tag) != ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag)
						{
							return ((SkinEngine) this.xdc87e2b99332cd4a).RealActive;
						}
						else
						{
							return false;
						}
					}
					if (! (this.Tag is string))
					{
						return ((SkinEngine) this.xdc87e2b99332cd4a).RealActive;
					}
					int i1 = ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag;
					if (((string) this.Tag) != i1.ToString ())
					{
						return ((SkinEngine) this.xdc87e2b99332cd4a).RealActive;
					}
					else
					{
						return false;
					}
				}
			}
			
			
			protected virtual bool CanSize
			
			{
				get
				
				/*
					// Code Size: 70 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.FormBorderStyle V_0, 
         System.Windows.Forms.FormWindowState V_1)
					L_0000: ldarg.0 
					L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormBorderStyle get_BorderStyle()
					L_0006: stloc.0 
					L_0007: ldloc.0 
					L_0008: switch (L_0027, L_0027, L_0027, L_0027, L_0029, L_0027)
					L_0025: br.s L_0029
					L_0027: ldc.i4.0 
					L_0028: ret 
					L_0029: ldarg.0 
					L_002a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
					L_002f: stloc.1 
					L_0030: ldloc.1 
					L_0031: ldc.i4.1 
					L_0032: sub 
					L_0033: switch (L_0042, L_0042)
					L_0040: br.s L_0044
					L_0042: ldc.i4.0 
					L_0043: ret 
					L_0044: ldc.i4.1 
					L_0045: ret 
				*/
				
				{
					switch (this.BorderStyle)
					{
						case FormBorderStyle.None:
						case FormBorderStyle.FixedSingle:
						case FormBorderStyle.Fixed3D:
						case FormBorderStyle.FixedDialog:
						case FormBorderStyle.FixedToolWindow:
						
						{
								return false;
						}
					}
					switch (this.WindowState)
					{
						case FormWindowState.Minimized:
						case FormWindowState.Maximized:
						
						{
								return false;
						}
					}
					return true;
				}
			}
			
			
			protected abstract Rectangle ClientRectangle
			
			{
				get;
			}
			
			
			protected abstract bool ControlBox
			
			{
				get;
			}
			
			
			protected abstract int Height
			
			{
				get;
			}
			
			
			protected abstract bool HelpButton
			
			{
				get;
			}
			
			
			protected abstract Icon Icon
			
			{
				get;
			}
			
			
			protected virtual bool IsActive
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xfd408d62a1acef9b
					L_0006: ret 
				*/
				
				{
					return this.xfd408d62a1acef9b;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xfd408d62a1acef9b
					L_0007: ret 
				*/
				
				{
					this.xfd408d62a1acef9b = value;
				}
			}
			
			
			protected abstract bool IsDisposed
			
			{
				get;
			}
			
			
			protected abstract bool IsMdiChild
			
			{
				get;
			}
			
			
			protected abstract bool IsMdiContainer
			
			{
				get;
			}
			
			
			protected abstract bool MaximizeBox
			
			{
				get;
			}
			
			
			protected virtual int MenuHeight
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.0 
					L_0001: ret 
				*/
				
				{
					return 0;
				}
			}
			
			
			protected abstract bool MinimizeBox
			
			{
				get;
			}
			
			
			protected abstract Region Region
			
			{
				get;
				set;
			}
			
			
			protected abstract RightToLeft RightToLeft
			
			{
				get;
			}
			
			
			protected abstract bool RightToLeftLayout
			
			{
				get;
			}
			
			
			protected abstract object Tag
			
			{
				get;
			}
			
			
			protected abstract string Text
			
			{
				get;
			}
			
			
			protected virtual int TitleHeight
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
					L_000b: ret 
				*/
				
				{
					return ((SkinEngine) this.xdc87e2b99332cd4a).TitleHeight;
				}
			}
			
			
			protected abstract int Width
			
			{
				get;
			}
			
			
			protected virtual FormWindowState WindowState
			
			{
				get
				
				/*
					// Code Size: 32 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean IsIconic(IntPtr)
					L_000b: brfalse.s L_000f
					L_000d: ldc.i4.1 
					L_000e: ret 
					L_000f: ldarg.0 
					L_0010: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0015: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean IsZoomed(IntPtr)
					L_001a: brfalse.s L_001e
					L_001c: ldc.i4.2 
					L_001d: ret 
					L_001e: ldc.i4.0 
					L_001f: ret 
				*/
				
				{
					if (x61467fe65a98f20c.IsIconic (base.Handle))
					{
						return FormWindowState.Minimized;
					}
					else if (! x61467fe65a98f20c.IsZoomed (base.Handle))
					{
						return FormWindowState.Normal;
					}
					else
					{
						return FormWindowState.Maximized;
					}
				}
				set
				
				/*
					// Code Size: 93 Bytes
					.maxstack 5
					.locals (System.Windows.Forms.FormWindowState V_0)
					L_0000: ldarg.1 
					L_0001: stloc.0 
					L_0002: ldloc.0 
					L_0003: switch (L_0045, L_0015, L_002d)
					L_0014: ret 
					L_0015: ldarg.0 
					L_0016: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_001b: ldc.i4 274
					L_0020: ldc.i4 61472
					L_0025: ldc.i4.0 
					L_0026: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
					L_002b: pop 
					L_002c: ret 
					L_002d: ldarg.0 
					L_002e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0033: ldc.i4 274
					L_0038: ldc.i4 61488
					L_003d: ldc.i4.0 
					L_003e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
					L_0043: pop 
					L_0044: ret 
					L_0045: ldarg.0 
					L_0046: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_004b: ldc.i4 274
					L_0050: ldc.i4 61728
					L_0055: ldc.i4.0 
					L_0056: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
					L_005b: pop 
					L_005c: ret 
				*/
				
				{
					switch (value)
					{
						case FormWindowState.Normal:
						
						{
								bool b3 = x61467fe65a98f20c.PostMessage (base.Handle, 274, 61728, uint.MinValue);
								return;
						}
						case FormWindowState.Minimized:
						
						{
								bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, 274, 61472, uint.MinValue);
								return;
						}
						case FormWindowState.Maximized:
						
						{
								bool b2 = x61467fe65a98f20c.PostMessage (base.Handle, 274, 61488, uint.MinValue);
								return;
						}
					}
				}
			}
			
			
			internal x902c4aee45bfd906 xd1faceba1dee38cf
			
			{
				get
				
				/*
					// Code Size: 286 Bytes
					.maxstack 6
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_0006: brtrue L_00a3
					L_000b: ldarg.0 
					L_000c: ldarg.0 
					L_000d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0012: newobj Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
					L_0017: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_001c: ldarg.0 
					L_001d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_0022: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_0027: ldarg.0 
					L_0028: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_002d: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuMin()
					L_0032: ldarg.0 
					L_0033: ldftn Sunisoft.IrisSkin.xd24df615efe9450e::Void x814eab16f4e2a468(System.Object, System.EventArgs)
					L_0039: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
					L_003e: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor(System.String, System.EventHandler)
					L_0043: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
					L_0048: pop 
					L_0049: ldarg.0 
					L_004a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_004f: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_0054: ldarg.0 
					L_0055: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_005a: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuMax()
					L_005f: ldarg.0 
					L_0060: ldftn Sunisoft.IrisSkin.xd24df615efe9450e::Void x841c19853f4810d4(System.Object, System.EventArgs)
					L_0066: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
					L_006b: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor(System.String, System.EventHandler)
					L_0070: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
					L_0075: pop 
					L_0076: ldarg.0 
					L_0077: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_007c: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_0081: ldarg.0 
					L_0082: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0087: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuClose()
					L_008c: ldarg.0 
					L_008d: ldftn Sunisoft.IrisSkin.xd24df615efe9450e::Void x5a3bdd19fa669e36(System.Object, System.EventArgs)
					L_0093: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
					L_0098: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor(System.String, System.EventHandler)
					L_009d: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
					L_00a2: pop 
					L_00a3: ldarg.0 
					L_00a4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_00a9: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_00ae: ldc.i4.0 
					L_00af: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
					L_00b4: ldarg.0 
					L_00b5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_00ba: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuMin()
					L_00bf: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Text(System.String)
					L_00c4: ldarg.0 
					L_00c5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_00ca: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_00cf: ldc.i4.1 
					L_00d0: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
					L_00d5: ldarg.0 
					L_00d6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_00db: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuMax()
					L_00e0: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Text(System.String)
					L_00e5: ldarg.0 
					L_00e6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_00eb: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
					L_00f0: ldc.i4.2 
					L_00f1: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
					L_00f6: ldarg.0 
					L_00f7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_00fc: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_ResSysMenuClose()
					L_0101: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Text(System.String)
					L_0106: ldarg.0 
					L_0107: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_010c: ldarg.0 
					L_010d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.RightToLeft get_RightToLeft()
					L_0112: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.RightToLeft x94975a4c4f1d71c4
					L_0117: ldarg.0 
					L_0118: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcdc1a69e212e5aa9
					L_011d: ret 
				*/
				
				{
					if (this.xcdc1a69e212e5aa9 == null)
					{
						this.xcdc1a69e212e5aa9 = new x902c4aee45bfd906 (this.xdc87e2b99332cd4a);
						x5f4b657f68f87baa x5f4b657f68f87baa1 = this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (new x5f4b657f68f87baa (((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuMin, new EventHandler (this.x814eab16f4e2a468)));
						x5f4b657f68f87baa x5f4b657f68f87baa2 = this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (new x5f4b657f68f87baa (((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuMax, new EventHandler (this.x841c19853f4810d4)));
						x5f4b657f68f87baa x5f4b657f68f87baa3 = this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (new x5f4b657f68f87baa (((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuClose, new EventHandler (this.x5a3bdd19fa669e36)));
					}
					this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (0).Text = ((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuMin;
					this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (1).Text = ((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuMax;
					this.xcdc1a69e212e5aa9.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (2).Text = ((SkinEngine) this.xdc87e2b99332cd4a).ResSysMenuClose;
					this.xcdc1a69e212e5aa9.x94975a4c4f1d71c4 = this.RightToLeft;
					return this.xcdc1a69e212e5aa9;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected unsafe virtual void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 1110 Bytes
				.maxstack 8
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS* V_2, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS* V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT* V_6, 
         System.UInt32 V_7, 
         System.IntPtr V_8)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.s V_7
				L_0008: ldloc.s V_7
				L_000a: ldc.i4 134
				L_000f: bgt.un.s L_0066
				L_0011: ldloc.s V_7
				L_0013: ldc.i4.s 12
				L_0015: bgt.un.s L_0032
				L_0017: ldloc.s V_7
				L_0019: ldc.i4.5 
				L_001a: sub 
				L_001b: switch (L_0371, L_0289)
				L_0028: ldloc.s V_7
				L_002a: ldc.i4.s 12
				L_002c: beq L_0364
				L_0031: ret 
				L_0032: ldloc.s V_7
				L_0034: ldc.i4.s 33
				L_0036: sub 
				L_0037: switch (L_0320, L_02fe)
				L_0044: ldloc.s V_7
				L_0046: ldc.i4 130
				L_004b: sub 
				L_004c: switch (L_009b, L_00f9, L_0455, L_0455, L_024a)
				L_0065: ret 
				L_0066: ldloc.s V_7
				L_0068: ldc.i4 310
				L_006d: bgt.un.s L_0082
				L_006f: ldloc.s V_7
				L_0071: ldc.i4 161
				L_0076: beq.s L_00db
				L_0078: ldloc.s V_7
				L_007a: ldc.i4 310
				L_007f: beq.s L_00c9
				L_0081: ret 
				L_0082: ldloc.s V_7
				L_0084: ldc.i4 532
				L_0089: beq L_0396
				L_008e: ldloc.s V_7
				L_0090: ldc.i4 546
				L_0095: beq L_0342
				L_009a: ret 
				L_009b: ldarg.0 
				L_009c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00a1: brfalse L_0455
				L_00a6: ldarg.0 
				L_00a7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00ac: ldarg.0 
				L_00ad: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9c67b90604ff861f
				L_00b2: callvirt System.Windows.Forms.Control::Void set_Width(Int32)
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00bd: ldarg.0 
				L_00be: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xb807ac541c41b1ec
				L_00c3: callvirt System.Windows.Forms.Control::Void set_Height(Int32)
				L_00c8: ret 
				L_00c9: ldarg.1 
				L_00ca: ldarg.0 
				L_00cb: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00d0: callvirt Sunisoft.IrisSkin.SkinEngine::IntPtr get_BackColorBrush()
				L_00d5: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_00da: ret 
				L_00db: ldarg.1 
				L_00dc: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_00e1: stloc.s V_8
				L_00e3: ldloca.s V_8
				L_00e5: call System.IntPtr::Int32 ToInt32()
				L_00ea: stloc.0 
				L_00eb: ldloc.0 
				L_00ec: ldc.i4.3 
				L_00ed: bne.un L_0455
				L_00f2: ldarg.0 
				L_00f3: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoSysMenu()
				L_00f8: ret 
				L_00f9: ldarg.1 
				L_00fa: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_00ff: stloc.s V_8
				L_0101: ldloca.s V_8
				L_0103: call System.IntPtr::Int32 ToInt32()
				L_0108: stloc.0 
				L_0109: ldloc.0 
				L_010a: brtrue.s L_010d
				L_010c: ret 
				L_010d: ldarg.1 
				L_010e: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0113: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_0118: stloc.2 
				L_0119: ldloc.2 
				L_011a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::IntPtr lppos
				L_011f: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_0124: stloc.3 
				L_0125: ldloc.2 
				L_0126: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_012b: ldloc.3 
				L_012c: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 y
				L_0131: ldarg.0 
				L_0132: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0137: add 
				L_0138: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_013d: ldarg.0 
				L_013e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_0143: ldc.i4.2 
				L_0144: bne.un.s L_01a0
				L_0146: ldarg.0 
				L_0147: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_014c: brfalse.s L_01a0
				L_014e: ldloc.2 
				L_014f: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_0154: ldloc.3 
				L_0155: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 x
				L_015a: ldloc.3 
				L_015b: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 cx
				L_0160: add 
				L_0161: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0166: ldloc.2 
				L_0167: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_016c: ldloc.3 
				L_016d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 x
				L_0172: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0177: ldloc.2 
				L_0178: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_017d: ldloc.3 
				L_017e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 y
				L_0183: ldloc.3 
				L_0184: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 cy
				L_0189: add 
				L_018a: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_018f: ldloc.2 
				L_0190: ldloc.2 
				L_0191: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_0196: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc1
				L_019b: br L_0232
				L_01a0: ldloc.2 
				L_01a1: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_01a6: ldloc.3 
				L_01a7: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 x
				L_01ac: ldloc.3 
				L_01ad: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 cx
				L_01b2: add 
				L_01b3: ldarg.0 
				L_01b4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01b9: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_01be: ldarg.0 
				L_01bf: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_01c4: call System.Math::Int32 Max(Int32, Int32)
				L_01c9: sub 
				L_01ca: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_01cf: ldloc.2 
				L_01d0: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_01d5: ldloc.3 
				L_01d6: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 x
				L_01db: ldarg.0 
				L_01dc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01e1: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_01e6: ldarg.0 
				L_01e7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_01ec: call System.Math::Int32 Max(Int32, Int32)
				L_01f1: add 
				L_01f2: call System.Drawing.Rectangle::Void set_X(Int32)
				L_01f7: ldloc.2 
				L_01f8: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_01fd: ldloc.3 
				L_01fe: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 y
				L_0203: ldloc.3 
				L_0204: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPOS::Int32 cy
				L_0209: add 
				L_020a: ldarg.0 
				L_020b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0210: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_0215: ldarg.0 
				L_0216: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_021b: call System.Math::Int32 Max(Int32, Int32)
				L_0220: sub 
				L_0221: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0226: ldloc.2 
				L_0227: ldloc.2 
				L_0228: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc0
				L_022d: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+NCCALCSIZE_PARAMS::System.Drawing.Rectangle rgrc1
				L_0232: ldarg.1 
				L_0233: ldc.i4 1024
				L_0238: conv.i8 
				L_0239: newobj System.IntPtr::Void .ctor(Int64)
				L_023e: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0243: ldarg.0 
				L_0244: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x271f237e4704798d()
				L_0249: ret 
				L_024a: ldarg.1 
				L_024b: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0250: stloc.s V_8
				L_0252: ldloca.s V_8
				L_0254: call System.IntPtr::Int32 ToInt32()
				L_0259: stloc.0 
				L_025a: ldarg.0 
				L_025b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0260: brfalse.s L_0269
				L_0262: ldarg.0 
				L_0263: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_0268: ret 
				L_0269: ldloc.0 
				L_026a: brfalse.s L_0275
				L_026c: ldarg.0 
				L_026d: ldc.i4.1 
				L_026e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_0273: br.s L_027c
				L_0275: ldarg.0 
				L_0276: ldc.i4.0 
				L_0277: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_027c: ldarg.0 
				L_027d: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_0282: ldarg.0 
				L_0283: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshMainMenu()
				L_0288: ret 
				L_0289: ldarg.1 
				L_028a: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_028f: stloc.s V_8
				L_0291: ldloca.s V_8
				L_0293: call System.IntPtr::Int32 ToInt32()
				L_0298: stloc.0 
				L_0299: ldarg.0 
				L_029a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_029f: brfalse.s L_02ae
				L_02a1: ldarg.0 
				L_02a2: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_02a7: ldarg.0 
				L_02a8: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshWindow()
				L_02ad: ret 
				L_02ae: ldloc.0 
				L_02af: conv.i8 
				L_02b0: ldc.i4.1 
				L_02b1: conv.i8 
				L_02b2: and 
				L_02b3: ldc.i4.1 
				L_02b4: conv.i8 
				L_02b5: beq.s L_02c0
				L_02b7: ldloc.0 
				L_02b8: conv.i8 
				L_02b9: ldc.i4.2 
				L_02ba: conv.i8 
				L_02bb: and 
				L_02bc: ldc.i4.2 
				L_02bd: conv.i8 
				L_02be: bne.un.s L_02c9
				L_02c0: ldarg.0 
				L_02c1: ldc.i4.1 
				L_02c2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_02c7: br.s L_02d0
				L_02c9: ldarg.0 
				L_02ca: ldc.i4.0 
				L_02cb: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_02d0: ldarg.0 
				L_02d1: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_02d6: ldarg.0 
				L_02d7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshMainMenu()
				L_02dc: ldarg.0 
				L_02dd: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_02e2: brtrue L_0455
				L_02e7: ldarg.0 
				L_02e8: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_02ed: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_02f2: bge L_0455
				L_02f7: ldarg.0 
				L_02f8: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshWindow()
				L_02fd: ret 
				L_02fe: ldarg.0 
				L_02ff: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_0304: brtrue L_0455
				L_0309: ldarg.0 
				L_030a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_030f: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_0314: bge L_0455
				L_0319: ldarg.0 
				L_031a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshWindow()
				L_031f: ret 
				L_0320: ldarg.0 
				L_0321: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_0326: brtrue L_0455
				L_032b: ldarg.0 
				L_032c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0331: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_0336: bge L_0455
				L_033b: ldarg.0 
				L_033c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshWindow()
				L_0341: ret 
				L_0342: ldarg.0 
				L_0343: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_0348: brtrue L_0455
				L_034d: ldarg.0 
				L_034e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0353: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_0358: bge L_0455
				L_035d: ldarg.0 
				L_035e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RefreshWindow()
				L_0363: ret 
				L_0364: ldarg.0 
				L_0365: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x271f237e4704798d()
				L_036a: ldarg.0 
				L_036b: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_0370: ret 
				L_0371: ldarg.0 
				L_0372: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0377: ldsfld System.IntPtr::IntPtr Zero
				L_037c: ldc.i4.0 
				L_037d: ldc.i4.0 
				L_037e: ldc.i4.0 
				L_037f: ldc.i4.0 
				L_0380: ldc.i4.s 55
				L_0382: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_0387: pop 
				L_0388: ldarg.0 
				L_0389: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RegionWindow()
				L_038e: ldarg.0 
				L_038f: ldc.i4.m1 
				L_0390: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_0395: ret 
				L_0396: ldarg.1 
				L_0397: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_039c: stloc.s V_8
				L_039e: ldloca.s V_8
				L_03a0: call System.IntPtr::Int32 ToInt32()
				L_03a5: stloc.1 
				L_03a6: ldarg.0 
				L_03a7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03ac: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormMinWidth()
				L_03b1: stloc.s V_4
				L_03b3: ldarg.0 
				L_03b4: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_03b9: brtrue.s L_03c1
				L_03bb: ldloc.s V_4
				L_03bd: ldc.i4.6 
				L_03be: sub 
				L_03bf: stloc.s V_4
				L_03c1: ldarg.0 
				L_03c2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_03c7: brtrue.s L_03cf
				L_03c9: ldloc.s V_4
				L_03cb: ldc.i4.6 
				L_03cc: sub 
				L_03cd: stloc.s V_4
				L_03cf: ldarg.0 
				L_03d0: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_03d5: brtrue.s L_03dd
				L_03d7: ldloc.s V_4
				L_03d9: ldc.i4.6 
				L_03da: sub 
				L_03db: stloc.s V_4
				L_03dd: ldarg.0 
				L_03de: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03e3: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
				L_03e8: ldarg.0 
				L_03e9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03ee: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_03f3: ldarg.0 
				L_03f4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_03f9: call System.Math::Int32 Max(Int32, Int32)
				L_03fe: add 
				L_03ff: ldarg.0 
				L_0400: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_0405: add 
				L_0406: stloc.s V_5
				L_0408: ldloc.1 
				L_0409: conv.u 
				L_040a: stloc.s V_6
				L_040c: ldloc.s V_6
				L_040e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0413: ldloc.s V_6
				L_0415: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_041a: sub 
				L_041b: ldloc.s V_4
				L_041d: bge.s L_0430
				L_041f: ldloc.s V_6
				L_0421: ldloc.s V_6
				L_0423: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0428: ldloc.s V_4
				L_042a: add 
				L_042b: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0430: ldloc.s V_6
				L_0432: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0437: ldloc.s V_6
				L_0439: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_043e: sub 
				L_043f: ldloc.s V_5
				L_0441: bge.s L_0455
				L_0443: ldloc.s V_6
				L_0445: ldloc.s V_6
				L_0447: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_044c: ldloc.s V_5
				L_044e: add 
				L_044f: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0454: ret 
				L_0455: ret 
			*/
			
			
			{
				int i1;
				int i2;
				x40255b11ef821fa3.NCCALCSIZE_PARAMS* nCCALCSIZE_PARAMS_Ptr1;
				x40255b11ef821fa3.WINDOWPOS* wINDOWPOS_Ptr1;
				int i3;
				int i4;
				xae4dd1cafd2eb77c.RECT* rECT_Ptr1;
				uint uInt32_1;
				IntPtr intPtr1;
				uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 < 134)
				{
					if (uInt32_1 < 12)
					{
						switch ((int) uInt32_1)
						{
							case 5:
							
							{
									bool b1 = x61467fe65a98f20c.SetWindowPos (base.Handle, IntPtr.Zero, 0, 0, 0, 0, 55);
									this.RegionWindow ();
									this.x9579bd00b393fc12 = -1;
									return;
							}
							case 6:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if (this.IsMdiChild)
									{
										this.x3b8ca818f0c2637e ();
										this.RefreshWindow ();
										return;
									}
									if (((((long) i1) & ((long) 1)) != ((long) 1)) && ((((long) i1) & ((long) 2)) != ((long) 2)))
									{
										this.IsActive = false;
										goto L_02D0;
									}
									this.IsActive = true;
									goto L_02D0;
							}
						}
						if (uInt32_1 == 12)
						{
							this.x271f237e4704798d ();
							this.x3b8ca818f0c2637e ();
						}
					}
					else
					{
						switch (uInt32_1)
						{
							case 33:
							
							{
									if ((! this.IsDisposed) && (this.TitleHeight < SystemInformation.CaptionHeight))
									{
										this.RefreshWindow ();
									}
									return;
							}
							case 34:
							
							{
									if ((! this.IsDisposed) && (this.TitleHeight < SystemInformation.CaptionHeight))
									{
										this.RefreshWindow ();
									}
									return;
							}
						}
						switch ((int) uInt32_1)
						{
							case 130:
							
							{
									if (this.x42f4c234c9358072 == null)
									{
										return;
									}
									this.x42f4c234c9358072.Width = this.x9c67b90604ff861f;
									this.x42f4c234c9358072.Height = this.xb807ac541c41b1ec;
									return;
							}
							case 131:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if (i1 == 0)
									{
										return;
									}
									nCCALCSIZE_PARAMS_Ptr1 = ((x40255b11ef821fa3.NCCALCSIZE_PARAMS*) ((void*) m.LParam));
									nCCALCSIZE_PARAMS_Ptr1->rgrc0.Y = ((wINDOWPOS_Ptr1 = ((x40255b11ef821fa3.WINDOWPOS*) ((void*) nCCALCSIZE_PARAMS_Ptr1->lppos)))->y + this.TitleHeight);
									if ((this.WindowState != FormWindowState.Maximized) || (! this.IsMdiChild))
									{
										nCCALCSIZE_PARAMS_Ptr1->rgrc0.Width = ((wINDOWPOS_Ptr1->x + wINDOWPOS_Ptr1->cx) - Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth, this.xdab5261f2cc3422d));
										nCCALCSIZE_PARAMS_Ptr1->rgrc0.X = (wINDOWPOS_Ptr1->x + Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, this.xdab5261f2cc3422d));
										nCCALCSIZE_PARAMS_Ptr1->rgrc0.Height = ((wINDOWPOS_Ptr1->y + wINDOWPOS_Ptr1->cy) - Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight, this.xef9eb32e7f1d1f23));
										nCCALCSIZE_PARAMS_Ptr1->rgrc1 = nCCALCSIZE_PARAMS_Ptr1->rgrc0;
										goto L_0232;
									}
									nCCALCSIZE_PARAMS_Ptr1->rgrc0.Width = (wINDOWPOS_Ptr1->x + wINDOWPOS_Ptr1->cx);
									nCCALCSIZE_PARAMS_Ptr1->rgrc0.X = wINDOWPOS_Ptr1->x;
									nCCALCSIZE_PARAMS_Ptr1->rgrc0.Height = (wINDOWPOS_Ptr1->y + wINDOWPOS_Ptr1->cy);
									nCCALCSIZE_PARAMS_Ptr1->rgrc1 = nCCALCSIZE_PARAMS_Ptr1->rgrc0;
									goto L_0232;
							}
							case 132:
							case 133:
							
							{
									return;
							}
							case 134:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if (this.IsMdiChild)
									{
										this.x3b8ca818f0c2637e ();
										return;
									}
									if (i1 == 0)
									{
										this.IsActive = false;
										goto L_027C;
									}
									this.IsActive = true;
									goto L_027C;
							}
						}
					}
					return;
				}
				if (uInt32_1 < 310)
				{
					if (uInt32_1 == 161)
					{
						intPtr1 = m.WParam;
						i1 = intPtr1.ToInt32 ();
						if (i1 == 3)
						{
							this.DoSysMenu ();
						}
					}
					else if (uInt32_1 == 310)
					{
						m.Result = ((SkinEngine) this.xdc87e2b99332cd4a).BackColorBrush;
					}
					return;
				}
				if (uInt32_1 == 532)
				{
					intPtr1 = m.LParam;
					i2 = intPtr1.ToInt32 ();
					i3 = ((SkinEngine) this.xdc87e2b99332cd4a).FormMinWidth;
					if (! this.HelpButton)
					{
						i3 -= 6;
					}
					if (! this.MinimizeBox)
					{
						i3 -= 6;
					}
					if (! this.MaximizeBox)
					{
						i3 -= 6;
					}
					i4 = ((((SkinEngine) this.xdc87e2b99332cd4a).TitleHeight + Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight, this.xef9eb32e7f1d1f23)) + this.MenuHeight);
					rECT_Ptr1 = i2;
					if ((rECT_Ptr1->right - rECT_Ptr1->left) < i3)
					{
						rECT_Ptr1->right = (rECT_Ptr1->left + i3);
					}
					if ((rECT_Ptr1->bottom - rECT_Ptr1->top) < i4)
					{
						rECT_Ptr1->bottom = (rECT_Ptr1->top + i4);
					}
					return;
				}
				if (uInt32_1 == 546)
				{
					if ((! this.IsDisposed) && (this.TitleHeight < SystemInformation.CaptionHeight))
					{
						this.RefreshWindow ();
					}
					return;
				}
				return;
				
			L_0232:
				
				{
				}
				m.Result = new IntPtr (1024L);
				this.x271f237e4704798d ();
				return;
				
			L_027C:
				
				{
				}
				this.x3b8ca818f0c2637e ();
				this.RefreshMainMenu ();
				return;
				
			L_02D0:
				
				{
				}
				this.x3b8ca818f0c2637e ();
				this.RefreshMainMenu ();
				if (this.IsDisposed || (this.TitleHeight >= SystemInformation.CaptionHeight))
				{
				}
				else
				{
					this.RefreshWindow ();
					return;
					
					/*
						Unreachable Code
						return;
					*/
				}
			}
			
			protected virtual void ApplySkin ()
			
			/*
				// Code Size: 32 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brfalse.s L_001f
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000e: ldsfld System.IntPtr::IntPtr Zero
				L_0013: ldc.i4.0 
				L_0014: ldc.i4.0 
				L_0015: ldc.i4.0 
				L_0016: ldc.i4.0 
				L_0017: ldc.i4.s 55
				L_0019: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_001e: pop 
				L_001f: ret 
			*/
			
			
			{
				if (this.CanPaint)
				{
					bool b1 = x61467fe65a98f20c.SetWindowPos (base.Handle, IntPtr.Zero, 0, 0, 0, 0, 55);
				}
			}
			
			protected virtual bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 976 Bytes
				.maxstack 8
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.Point V_2, 
         System.UInt32 V_3, 
         System.Drawing.Point V_4, 
         System.UInt32 V_5, 
         System.IntPtr V_6)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.s V_5
				L_0008: ldloc.s V_5
				L_000a: ldc.i4 134
				L_000f: bgt.un.s L_003e
				L_0011: ldloc.s V_5
				L_0013: ldc.i4.s 32
				L_0015: beq L_00e5
				L_001a: ldloc.s V_5
				L_001c: ldc.i4.s 70
				L_001e: beq.s L_0092
				L_0020: ldloc.s V_5
				L_0022: ldc.i4 132
				L_0027: sub 
				L_0028: switch (L_0355, L_02a2, L_01ce)
				L_0039: br L_03ce
				L_003e: ldloc.s V_5
				L_0040: ldc.i4 174
				L_0045: bgt.un.s L_0076
				L_0047: ldloc.s V_5
				L_0049: ldc.i4 160
				L_004e: sub 
				L_004f: switch (L_01f2, L_02aa, L_011c, L_0369, L_017d)
				L_0068: ldloc.s V_5
				L_006a: ldc.i4 174
				L_006f: beq.s L_0090
				L_0071: br L_03ce
				L_0076: ldloc.s V_5
				L_0078: ldc.i4 787
				L_007d: beq L_0102
				L_0082: ldloc.s V_5
				L_0084: ldc.i4 8401
				L_0089: beq.s L_00f0
				L_008b: br L_03ce
				L_0090: ldc.i4.0 
				L_0091: ret 
				L_0092: ldarg.0 
				L_0093: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_0098: brfalse L_03ce
				L_009d: ldarg.0 
				L_009e: ldarg.0 
				L_009f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00a4: ldc.i4.s -20
				L_00a6: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_00ab: stfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_00b0: ldarg.0 
				L_00b1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_00b6: ldc.i4 4194304
				L_00bb: and 
				L_00bc: ldc.i4 4194304
				L_00c1: bne.un L_03ce
				L_00c6: ldarg.0 
				L_00c7: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00cc: ldc.i4.s -20
				L_00ce: ldarg.0 
				L_00cf: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_00d4: ldc.i4 4194304
				L_00d9: sub 
				L_00da: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_00df: pop 
				L_00e0: br L_03ce
				L_00e5: ldarg.0 
				L_00e6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void ResetWindowStyle()
				L_00eb: br L_03ce
				L_00f0: ldarg.1 
				L_00f1: ldc.i4 8401
				L_00f6: newobj System.IntPtr::Void .ctor(Int32)
				L_00fb: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0100: ldc.i4.0 
				L_0101: ret 
				L_0102: ldloca.s V_2
				L_0104: ldc.i4.0 
				L_0105: ldc.i4.0 
				L_0106: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_010b: ldloca.s V_2
				L_010d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetCursorPos(System.Drawing.Point ByRef)
				L_0112: pop 
				L_0113: ldarg.0 
				L_0114: ldloc.2 
				L_0115: call Sunisoft.IrisSkin.xd24df615efe9450e::Void xd308f013f560f5be(System.Drawing.Point)
				L_011a: ldc.i4.0 
				L_011b: ret 
				L_011c: ldarg.0 
				L_011d: call Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x13d7e7b52a69e5dc()
				L_0122: stloc.3 
				L_0123: ldloc.3 
				L_0124: conv.u8 
				L_0125: ldarg.0 
				L_0126: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_012b: conv.i8 
				L_012c: bne.un.s L_0174
				L_012e: ldloc.3 
				L_012f: stloc.s V_5
				L_0131: ldloc.s V_5
				L_0133: ldc.i4.8 
				L_0134: sub 
				L_0135: switch (L_0166, L_015e)
				L_0142: ldloc.s V_5
				L_0144: ldc.i4.s 20
				L_0146: sub 
				L_0147: switch (L_0156, L_016e)
				L_0154: br.s L_0174
				L_0156: ldarg.0 
				L_0157: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoClose()
				L_015c: br.s L_0174
				L_015e: ldarg.0 
				L_015f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoMax()
				L_0164: br.s L_0174
				L_0166: ldarg.0 
				L_0167: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoMin()
				L_016c: br.s L_0174
				L_016e: ldarg.0 
				L_016f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoHelp()
				L_0174: ldarg.0 
				L_0175: ldc.i4.m1 
				L_0176: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_017b: ldc.i4.0 
				L_017c: ret 
				L_017d: ldarg.0 
				L_017e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_0183: brfalse.s L_01cc
				L_0185: ldarg.1 
				L_0186: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_018b: stloc.s V_6
				L_018d: ldloca.s V_6
				L_018f: call System.IntPtr::Int32 ToInt32()
				L_0194: stloc.0 
				L_0195: ldloc.0 
				L_0196: ldc.i4.2 
				L_0197: bne.un.s L_01cc
				L_0199: ldarg.1 
				L_019a: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_019f: stloc.s V_6
				L_01a1: ldloca.s V_6
				L_01a3: call System.IntPtr::Int32 ToInt32()
				L_01a8: stloc.1 
				L_01a9: ldloca.s V_4
				L_01ab: ldloc.1 
				L_01ac: ldc.i4 65535
				L_01b1: and 
				L_01b2: ldloc.1 
				L_01b3: conv.i8 
				L_01b4: ldc.i4 -65536
				L_01b9: conv.u8 
				L_01ba: and 
				L_01bb: ldc.i4.s 16
				L_01bd: shr 
				L_01be: conv.i4 
				L_01bf: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_01c4: ldarg.0 
				L_01c5: ldloc.s V_4
				L_01c7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoSysMenu(System.Drawing.Point)
				L_01cc: ldc.i4.0 
				L_01cd: ret 
				L_01ce: ldarg.1 
				L_01cf: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_01d4: stloc.s V_6
				L_01d6: ldloca.s V_6
				L_01d8: call System.IntPtr::Int32 ToInt32()
				L_01dd: stloc.0 
				L_01de: ldloc.0 
				L_01df: brtrue L_03ce
				L_01e4: ldarg.1 
				L_01e5: ldc.i4.1 
				L_01e6: newobj System.IntPtr::Void .ctor(Int32)
				L_01eb: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_01f0: ldc.i4.0 
				L_01f1: ret 
				L_01f2: ldarg.1 
				L_01f3: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_01f8: stloc.s V_6
				L_01fa: ldloca.s V_6
				L_01fc: call System.IntPtr::Int32 ToInt32()
				L_0201: stloc.0 
				L_0202: ldloc.0 
				L_0203: ldc.i4.s 9
				L_0205: beq.s L_021c
				L_0207: ldloc.0 
				L_0208: ldc.i4.8 
				L_0209: beq.s L_021c
				L_020b: ldloc.0 
				L_020c: ldc.i4.s 20
				L_020e: beq.s L_021c
				L_0210: ldloc.0 
				L_0211: ldc.i4.s 21
				L_0213: beq.s L_021c
				L_0215: ldarg.0 
				L_0216: ldc.i4.m1 
				L_0217: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_021c: ldarg.0 
				L_021d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_0222: ldc.i4.s 9
				L_0224: beq.s L_0243
				L_0226: ldarg.0 
				L_0227: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_022c: ldc.i4.8 
				L_022d: beq.s L_0243
				L_022f: ldarg.0 
				L_0230: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_0235: ldc.i4.s 20
				L_0237: beq.s L_0243
				L_0239: ldarg.0 
				L_023a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_023f: ldc.i4.s 21
				L_0241: bne.un.s L_027f
				L_0243: ldloc.0 
				L_0244: ldc.i4.s 9
				L_0246: beq.s L_0256
				L_0248: ldloc.0 
				L_0249: ldc.i4.8 
				L_024a: beq.s L_0256
				L_024c: ldloc.0 
				L_024d: ldc.i4.s 20
				L_024f: beq.s L_0256
				L_0251: ldloc.0 
				L_0252: ldc.i4.s 21
				L_0254: bne.un.s L_0276
				L_0256: ldarg.0 
				L_0257: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_025c: ldloc.0 
				L_025d: beq.s L_0299
				L_025f: ldarg.0 
				L_0260: ldc.i4.0 
				L_0261: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x6616b01fd7cbc65d(Int32)
				L_0266: ldarg.0 
				L_0267: ldc.i4.0 
				L_0268: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_026d: ldarg.0 
				L_026e: ldloc.0 
				L_026f: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x6616b01fd7cbc65d(Int32)
				L_0274: br.s L_0299
				L_0276: ldarg.0 
				L_0277: ldloc.0 
				L_0278: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x6616b01fd7cbc65d(Int32)
				L_027d: br.s L_0299
				L_027f: ldloc.0 
				L_0280: ldc.i4.s 9
				L_0282: beq.s L_0292
				L_0284: ldloc.0 
				L_0285: ldc.i4.8 
				L_0286: beq.s L_0292
				L_0288: ldloc.0 
				L_0289: ldc.i4.s 20
				L_028b: beq.s L_0292
				L_028d: ldloc.0 
				L_028e: ldc.i4.s 21
				L_0290: bne.un.s L_0299
				L_0292: ldarg.0 
				L_0293: ldloc.0 
				L_0294: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x6616b01fd7cbc65d(Int32)
				L_0299: ldarg.0 
				L_029a: ldloc.0 
				L_029b: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_02a0: ldc.i4.0 
				L_02a1: ret 
				L_02a2: ldarg.0 
				L_02a3: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3b8ca818f0c2637e()
				L_02a8: ldc.i4.0 
				L_02a9: ret 
				L_02aa: ldarg.1 
				L_02ab: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_02b0: stloc.s V_6
				L_02b2: ldloca.s V_6
				L_02b4: call System.IntPtr::Int32 ToInt32()
				L_02b9: stloc.0 
				L_02ba: ldarg.0 
				L_02bb: ldloc.0 
				L_02bc: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_02c1: ldarg.0 
				L_02c2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_02c7: ldc.i4.s 21
				L_02c9: beq.s L_02e8
				L_02cb: ldarg.0 
				L_02cc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_02d1: ldc.i4.8 
				L_02d2: beq.s L_02e8
				L_02d4: ldarg.0 
				L_02d5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_02da: ldc.i4.s 9
				L_02dc: beq.s L_02e8
				L_02de: ldarg.0 
				L_02df: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_02e4: ldc.i4.s 20
				L_02e6: bne.un.s L_02f8
				L_02e8: ldarg.0 
				L_02e9: ldloc.0 
				L_02ea: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x6616b01fd7cbc65d(Int32)
				L_02ef: ldarg.0 
				L_02f0: ldloc.0 
				L_02f1: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_02f6: ldc.i4.0 
				L_02f7: ret 
				L_02f8: ldarg.0 
				L_02f9: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.String get_Text()
				L_02fe: ldstr ""
				L_0303: call System.String::Boolean op_Equality(System.String, System.String)
				L_0308: brfalse.s L_0318
				L_030a: ldarg.0 
				L_030b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_0310: brtrue.s L_0318
				L_0312: ldloc.0 
				L_0313: ldc.i4.2 
				L_0314: bne.un.s L_0318
				L_0316: ldc.i4.0 
				L_0317: ret 
				L_0318: ldloc.0 
				L_0319: brtrue.s L_031d
				L_031b: ldc.i4.0 
				L_031c: ret 
				L_031d: ldloc.0 
				L_031e: ldc.i4.2 
				L_031f: bne.un L_03ce
				L_0324: ldarg.0 
				L_0325: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_032a: ldc.i4.2 
				L_032b: bne.un L_03ce
				L_0330: ldarg.1 
				L_0331: ldc.i4.0 
				L_0332: newobj System.IntPtr::Void .ctor(Int32)
				L_0337: call System.Windows.Forms.Message::Void set_WParam(IntPtr)
				L_033c: ldarg.0 
				L_033d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0342: ldc.i4.0 
				L_0343: newobj System.IntPtr::Void .ctor(Int32)
				L_0348: ldc.i4.0 
				L_0349: ldc.i4.0 
				L_034a: ldc.i4.0 
				L_034b: ldc.i4.0 
				L_034c: ldc.i4.3 
				L_034d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_0352: pop 
				L_0353: ldc.i4.0 
				L_0354: ret 
				L_0355: ldarg.1 
				L_0356: ldarg.0 
				L_0357: call Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x13d7e7b52a69e5dc()
				L_035c: conv.u8 
				L_035d: newobj System.IntPtr::Void .ctor(Int64)
				L_0362: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0367: ldc.i4.0 
				L_0368: ret 
				L_0369: ldarg.0 
				L_036a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.String get_Text()
				L_036f: ldstr ""
				L_0374: call System.String::Boolean op_Equality(System.String, System.String)
				L_0379: brfalse.s L_0385
				L_037b: ldarg.0 
				L_037c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_0381: brtrue.s L_0385
				L_0383: ldc.i4.0 
				L_0384: ret 
				L_0385: ldarg.1 
				L_0386: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_038b: stloc.s V_6
				L_038d: ldloca.s V_6
				L_038f: call System.IntPtr::Int32 ToInt32()
				L_0394: stloc.0 
				L_0395: ldloc.0 
				L_0396: ldc.i4.2 
				L_0397: bne.un.s L_03b0
				L_0399: ldarg.0 
				L_039a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_039f: brfalse.s L_03a7
				L_03a1: ldarg.0 
				L_03a2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoMax()
				L_03a7: ldarg.0 
				L_03a8: ldc.i4.m1 
				L_03a9: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_03ae: ldc.i4.0 
				L_03af: ret 
				L_03b0: ldloc.0 
				L_03b1: ldc.i4.3 
				L_03b2: bne.un.s L_03ce
				L_03b4: ldarg.0 
				L_03b5: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoClose()
				L_03ba: ldarg.0 
				L_03bb: ldc.i4.m1 
				L_03bc: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_03c1: ldarg.0 
				L_03c2: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_03c7: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf2996a13c26d70bb()
				L_03cc: ldc.i4.0 
				L_03cd: ret 
				L_03ce: ldc.i4.1 
				L_03cf: ret 
			*/
			
			
			{
				int i1;
				int i2;
				Point point1;
				uint uInt32_1;
				Point point2;
				uint uInt32_2;
				IntPtr intPtr1;
				uInt32_2 = ((uint) m.Msg);
				if (uInt32_2 < 134)
				{
					if (uInt32_2 == 32)
					{
						this.ResetWindowStyle ();
					}
					else if (uInt32_2 != 70)
					{
						switch ((int) uInt32_2)
						{
							case 132:
							
							{
									m.Result = new IntPtr (((long) this.x13d7e7b52a69e5dc ()));
									return false;
							}
							case 133:
							
							{
									this.x3b8ca818f0c2637e ();
									return false;
							}
							case 134:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if (i1 != 0)
									{
										return true;
									}
									m.Result = new IntPtr (1);
									return false;
							}
						}
					}
					else if (this.RightToLeftLayout)
					{
						this.x8782b9e138b1b2e0 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
						if ((((int) this.x8782b9e138b1b2e0) & 4194304) == 4194304)
						{
							uint uInt32_3 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, ((uint) (((int) this.x8782b9e138b1b2e0) - 4194304)));
						}
					}
					return true;
				}
				if (uInt32_2 < 174)
				{
					switch ((int) uInt32_2)
					{
						case 160:
						
						{
								intPtr1 = m.WParam;
								i1 = intPtr1.ToInt32 ();
								if ((((i1 == 9) || (i1 == 8)) || (i1 == 20)) || (i1 == 21))
								{
									goto L_021C;
								}
								this.x9579bd00b393fc12 = -1;
								goto L_021C;
						}
						case 161:
						
						{
								intPtr1 = m.WParam;
								i1 = intPtr1.ToInt32 ();
								this.x9579bd00b393fc12 = i1;
								if ((this.x9579bd00b393fc12 != 21) && ((this.x9579bd00b393fc12 != 8) && ((this.x9579bd00b393fc12 != 9) && (this.x9579bd00b393fc12 != 20))))
								{
									if (((this.Text == "") && (! this.ControlBox)) && (i1 == 2))
									{
										return false;
									}
									if (i1 == 0)
									{
										return false;
									}
									if (i1 != 2)
									{
										return true;
									}
									if (this.WindowState != FormWindowState.Maximized)
									{
										return true;
									}
									m.WParam = new IntPtr (0);
									bool b2 = x61467fe65a98f20c.SetWindowPos (base.Handle, new IntPtr (0), 0, 0, 0, 0, 3);
									return false;
								}
								this.x6616b01fd7cbc65d (i1);
								this.xc8a0258498c6c151 = i1;
								return false;
						}
						case 162:
						
						{
								uInt32_1 = this.x13d7e7b52a69e5dc ();
								if (((long) uInt32_1) != ((long) this.x9579bd00b393fc12))
								{
									goto L_0174;
								}
								uInt32_2 = uInt32_1;
								switch ((int) uInt32_2)
								{
									case 8:
									
									{
											this.DoMin ();
											goto L_0174;
									}
									case 9:
									
									{
											this.DoMax ();
											goto L_0174;
									}
								}
								switch (uInt32_2)
								{
									case 20:
									
									{
											this.DoClose ();
											break;
									}
									case 21:
									
									{
											this.DoHelp ();
											break;
									}
								}
								goto L_0174;
						}
						case 163:
						
						{
								if ((this.Text == "") && (! this.ControlBox))
								{
									return false;
								}
								intPtr1 = m.WParam;
								i1 = intPtr1.ToInt32 ();
								if (i1 != 2)
								{
									if (i1 != 3)
									{
										return true;
									}
									this.DoClose ();
									this.x9579bd00b393fc12 = -1;
									this.xd1faceba1dee38cf.xf2996a13c26d70bb ();
									return false;
								}
								if (this.MaximizeBox)
								{
									this.DoMax ();
								}
								this.x9579bd00b393fc12 = -1;
								return false;
						}
						case 164:
						
						{
								if (! this.ControlBox)
								{
									return false;
								}
								intPtr1 = m.WParam;
								i1 = intPtr1.ToInt32 ();
								if (i1 != 2)
								{
									return false;
								}
								intPtr1 = m.LParam;
								i2 = intPtr1.ToInt32 ();
								point2 = new Point (((int) (i2 & 65535)), ((int) ((((long) i2) & ((long) (-65536))) >> 16)));
								this.DoSysMenu (point2);
								return false;
						}
					}
					if (uInt32_2 == 174)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				if (uInt32_2 != 787)
				{
					if (uInt32_2 != 8401)
					{
						return true;
					}
					else
					{
						m.Result = new IntPtr (8401);
						return false;
					}
				}
				point1 = new Point (0, 0);
				bool b1 = x61467fe65a98f20c.GetCursorPos (ref point1);
				this.xd308f013f560f5be (point1);
				return false;
				
			L_0174:
				
				{
				}
				this.x9579bd00b393fc12 = -1;
				return false;
				
			L_021C:
				
				{
				}
				if ((this.xc8a0258498c6c151 == 9) || ((this.xc8a0258498c6c151 == 8) || ((this.xc8a0258498c6c151 == 20) || (this.xc8a0258498c6c151 == 21))))
				{
					if ((i1 != 9) && ((i1 != 8) && ((i1 != 20) && (i1 != 21))))
					{
						this.x6616b01fd7cbc65d (i1);
					}
					else if (this.xc8a0258498c6c151 != i1)
					{
						this.x6616b01fd7cbc65d (0);
						this.xc8a0258498c6c151 = 0;
						this.x6616b01fd7cbc65d (i1);
					}
				}
				else if ((i1 == 9) || ((i1 == 8) || ((i1 == 20) || (i1 == 21))))
				{
					this.x6616b01fd7cbc65d (i1);
				}
				this.xc8a0258498c6c151 = i1;
				return false;
			}
			
			protected virtual void DoClose ()
			
			/*
				// Code Size: 24 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldc.i4 274
				L_000b: ldc.i4 61536
				L_0010: ldc.i4.0 
				L_0011: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0016: pop 
				L_0017: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, 274, 61536, uint.MinValue);
			}
			
			protected virtual void DoHelp ()
			
			/*
				// Code Size: 24 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldc.i4 274
				L_000b: ldc.i4 61824
				L_0010: ldc.i4.0 
				L_0011: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0016: pop 
				L_0017: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, 274, 61824, uint.MinValue);
			}
			
			protected virtual void DoMax ()
			
			/*
				// Code Size: 25 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_0006: ldc.i4.2 
				L_0007: bne.un.s L_0011
				L_0009: ldarg.0 
				L_000a: ldc.i4.0 
				L_000b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0010: ret 
				L_0011: ldarg.0 
				L_0012: ldc.i4.2 
				L_0013: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0018: ret 
			*/
			
			
			{
				if (this.WindowState == FormWindowState.Maximized)
				{
					this.WindowState = FormWindowState.Normal;
				}
				else
				{
					this.WindowState = FormWindowState.Maximized;
				}
			}
			
			protected virtual void DoMin ()
			
			/*
				// Code Size: 33 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0006: brfalse.s L_0019
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_000e: ldc.i4.1 
				L_000f: bne.un.s L_0019
				L_0011: ldarg.0 
				L_0012: ldc.i4.0 
				L_0013: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0018: ret 
				L_0019: ldarg.0 
				L_001a: ldc.i4.1 
				L_001b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0020: ret 
			*/
			
			
			{
				if (this.IsMdiChild && (this.WindowState == FormWindowState.Minimized))
				{
					this.WindowState = FormWindowState.Normal;
				}
				else
				{
					this.WindowState = FormWindowState.Minimized;
				}
			}
			
			protected virtual void DoSysMenu ()
			
			/*
				// Code Size: 155 Bytes
				.maxstack 7
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_000b: ldc.i4.0 
				L_000c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_001c: ldarg.0 
				L_001d: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0022: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0027: ldc.i4.1 
				L_0028: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_002d: ldarg.0 
				L_002e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0033: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_0038: ldarg.0 
				L_0039: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_003e: brfalse.s L_0081
				L_0040: ldarg.0 
				L_0041: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0046: ldarg.0 
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_004d: ldc.i4.3 
				L_004e: ldelema System.Drawing.Rectangle
				L_0053: call System.Drawing.Rectangle::Int32 get_X()
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_005e: ldc.i4.3 
				L_005f: ldelema System.Drawing.Rectangle
				L_0064: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0069: ldarg.0 
				L_006a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_006f: sub 
				L_0070: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0075: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_007a: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point)
				L_007f: pop 
				L_0080: ret 
				L_0081: ldarg.0 
				L_0082: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0087: ldarg.0 
				L_0088: ldc.i4.0 
				L_0089: ldc.i4.0 
				L_008a: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_008f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_0094: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point)
				L_0099: pop 
				L_009a: ret 
			*/
			
			
			{
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (0).Enabled = this.MinimizeBox;
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (1).Enabled = this.MaximizeBox;
				if (this.RightToLeftLayout)
				{
					x5f4b657f68f87baa x5f4b657f68f87baa1 = this.xd1faceba1dee38cf.x6192996f26aa9421 (this.PointToScreen (new Point (this.x170170622f070c21[3].X, ((int) (this.x170170622f070c21[3].Bottom - this.TitleHeight)))));
				}
				else
				{
					x5f4b657f68f87baa x5f4b657f68f87baa2 = this.xd1faceba1dee38cf.x6192996f26aa9421 (this.PointToScreen (new Point (0, 0)));
				}
			}
			
			protected virtual void DoSysMenu (Point p)
			
			/*
				// Code Size: 70 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_000b: ldc.i4.0 
				L_000c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_001c: ldarg.0 
				L_001d: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0022: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0027: ldc.i4.1 
				L_0028: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_002d: ldarg.0 
				L_002e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0033: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_0038: ldarg.0 
				L_0039: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_003e: ldarg.1 
				L_003f: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point)
				L_0044: pop 
				L_0045: ret 
			*/
			
			
			{
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (0).Enabled = this.MinimizeBox;
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (1).Enabled = this.MaximizeBox;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = this.xd1faceba1dee38cf.x6192996f26aa9421 (p);
			}
			
			protected virtual void GetWindowRestoreSize ()
			
			/*
				// Code Size: 328 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000e: ldloca.s V_0
				L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetWindowPlacement(IntPtr, WINDOWPLACEMENT ByRef)
				L_0015: pop 
				L_0016: ldarg.0 
				L_0017: ldloca.s V_0
				L_0019: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT::System.Drawing.Rectangle rcNormalPosition
				L_001e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0023: ldloca.s V_0
				L_0025: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT::System.Drawing.Rectangle rcNormalPosition
				L_002a: call System.Drawing.Rectangle::Int32 get_X()
				L_002f: sub 
				L_0030: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9c67b90604ff861f
				L_0035: ldarg.0 
				L_0036: ldloca.s V_0
				L_0038: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT::System.Drawing.Rectangle rcNormalPosition
				L_003d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0042: ldloca.s V_0
				L_0044: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWPLACEMENT::System.Drawing.Rectangle rcNormalPosition
				L_0049: call System.Drawing.Rectangle::Int32 get_Y()
				L_004e: sub 
				L_004f: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xb807ac541c41b1ec
				L_0054: ldarg.0 
				L_0055: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_005a: brfalse L_0117
				L_005f: ldarg.0 
				L_0060: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0065: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_006a: brtrue.s L_00c9
				L_006c: ldarg.0 
				L_006d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0072: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0077: stloc.2 
				L_0078: ldloca.s V_2
				L_007a: call System.Drawing.Rectangle::Int32 get_Width()
				L_007f: brfalse.s L_00c9
				L_0081: ldarg.0 
				L_0082: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0087: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_008c: stloc.2 
				L_008d: ldloca.s V_2
				L_008f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0094: brfalse.s L_00c9
				L_0096: ldarg.0 
				L_0097: ldarg.0 
				L_0098: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_009d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00a2: stloc.2 
				L_00a3: ldloca.s V_2
				L_00a5: call System.Drawing.Rectangle::Int32 get_Width()
				L_00aa: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xcd2b5f9eab575311
				L_00af: ldarg.0 
				L_00b0: ldarg.0 
				L_00b1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00b6: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00bb: stloc.2 
				L_00bc: ldloca.s V_2
				L_00be: call System.Drawing.Rectangle::Int32 get_Height()
				L_00c3: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_00c8: ret 
				L_00c9: ldarg.0 
				L_00ca: ldarg.0 
				L_00cb: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xb807ac541c41b1ec
				L_00d0: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_00d5: sub 
				L_00d6: ldarg.0 
				L_00d7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_00dc: sub 
				L_00dd: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_00e2: ldarg.0 
				L_00e3: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00e8: callvirt System.Windows.Forms.Form::System.Windows.Forms.MainMenu get_Menu()
				L_00ed: brfalse.s L_0101
				L_00ef: ldarg.0 
				L_00f0: dup 
				L_00f1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_00f6: call System.Windows.Forms.SystemInformation::Int32 get_MenuHeight()
				L_00fb: sub 
				L_00fc: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_0101: ldarg.0 
				L_0102: ldarg.0 
				L_0103: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9c67b90604ff861f
				L_0108: ldc.i4.2 
				L_0109: ldarg.0 
				L_010a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_010f: mul 
				L_0110: sub 
				L_0111: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xcd2b5f9eab575311
				L_0116: ret 
				L_0117: ldloca.s V_1
				L_0119: initobj System.Drawing.Rectangle
				L_011f: ldarg.0 
				L_0120: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0125: ldloca.s V_1
				L_0127: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetClientRect(IntPtr, System.Drawing.Rectangle ByRef)
				L_012c: pop 
				L_012d: ldarg.0 
				L_012e: ldloca.s V_1
				L_0130: call System.Drawing.Rectangle::Int32 get_Width()
				L_0135: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xcd2b5f9eab575311
				L_013a: ldarg.0 
				L_013b: ldloca.s V_1
				L_013d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0142: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_0147: ret 
			*/
			
			
			{
				x40255b11ef821fa3.WINDOWPLACEMENT wINDOWPLACEMENT1 = new x40255b11ef821fa3.WINDOWPLACEMENT ();
				int i1 = x61467fe65a98f20c.GetWindowPlacement (base.Handle, ref wINDOWPLACEMENT1);
				this.x9c67b90604ff861f = (wINDOWPLACEMENT1.rcNormalPosition.Width - wINDOWPLACEMENT1.rcNormalPosition.X);
				this.xb807ac541c41b1ec = (wINDOWPLACEMENT1.rcNormalPosition.Height - wINDOWPLACEMENT1.rcNormalPosition.Y);
				if (this.x42f4c234c9358072 != null)
				{
					if (((this.x42f4c234c9358072.WindowState == FormWindowState.Normal) && (this.x42f4c234c9358072.ClientRectangle.Width != 0)) && (this.x42f4c234c9358072.ClientRectangle.Height != 0))
					{
						this.xcd2b5f9eab575311 = this.x42f4c234c9358072.ClientRectangle.Width;
						this.xe43c4bad7e91c24a = this.x42f4c234c9358072.ClientRectangle.Height;
					}
					else
					{
						this.xe43c4bad7e91c24a = ((this.xb807ac541c41b1ec - SystemInformation.CaptionHeight) - this.xef9eb32e7f1d1f23);
						if (this.x42f4c234c9358072.Menu != null)
						{
							this.xe43c4bad7e91c24a -= SystemInformation.MenuHeight;
						}
						this.xcd2b5f9eab575311 = (this.x9c67b90604ff861f - (2 * this.xdab5261f2cc3422d));
					}
					return;
				}
				Rectangle rectangle1 = new Rectangle ();
				bool b1 = x61467fe65a98f20c.GetClientRect (base.Handle, ref rectangle1);
				this.xcd2b5f9eab575311 = rectangle1.Width;
				this.xe43c4bad7e91c24a = rectangle1.Height;
			}
			
			protected virtual void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 160 Bytes
				.maxstack 8
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void ResetWindowStyle()
				L_0006: ldarg.0 
				L_0007: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_000c: brtrue.s L_0053
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_Region(System.Drawing.Region)
				L_0015: ldarg.0 
				L_0016: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_001b: brfalse.s L_0088
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_0023: ldc.i4 4194304
				L_0028: and 
				L_0029: brtrue.s L_003d
				L_002b: ldarg.0 
				L_002c: dup 
				L_002d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_0032: ldc.i4 4194304
				L_0037: add 
				L_0038: stfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_003d: ldarg.0 
				L_003e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0043: ldc.i4.s -20
				L_0045: ldarg.0 
				L_0046: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_004b: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0050: pop 
				L_0051: br.s L_0088
				L_0053: ldarg.0 
				L_0054: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_0059: brfalse.s L_0088
				L_005b: ldarg.0 
				L_005c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_0061: ldc.i4 4194304
				L_0066: and 
				L_0067: ldc.i4 4194304
				L_006c: bne.un.s L_0088
				L_006e: ldarg.0 
				L_006f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0074: ldc.i4.s -20
				L_0076: ldarg.0 
				L_0077: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_007c: ldc.i4 4194304
				L_0081: sub 
				L_0082: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0087: pop 
				L_0088: ldarg.0 
				L_0089: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_008e: ldsfld System.IntPtr::IntPtr Zero
				L_0093: ldc.i4.0 
				L_0094: ldc.i4.0 
				L_0095: ldc.i4.0 
				L_0096: ldc.i4.0 
				L_0097: ldc.i4.s 55
				L_0099: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_009e: pop 
				L_009f: ret 
			*/
			
			
			{
				this.ResetWindowStyle ();
				if (! this.CanPaint)
				{
					this.Region = ((System.Drawing.Region) null);
					if (this.RightToLeftLayout)
					{
						if ((((int) this.x8782b9e138b1b2e0) & 4194304) == 0)
						{
							this.x8782b9e138b1b2e0 = ((uint) (((int) this.x8782b9e138b1b2e0) + 4194304));
						}
						uint uInt32_1 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, this.x8782b9e138b1b2e0);
					}
				}
				else if (this.RightToLeftLayout && ((((int) this.x8782b9e138b1b2e0) & 4194304) == 4194304))
				{
					uint uInt32_2 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, ((uint) (((int) this.x8782b9e138b1b2e0) - 4194304)));
				}
				bool b1 = x61467fe65a98f20c.SetWindowPos (base.Handle, IntPtr.Zero, 0, 0, 0, 0, 55);
			}
			
			protected virtual void PaintBorder (Graphics g)
			
			/*
				// Code Size: 488 Bytes
				.maxstack 11
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Bitmap V_4, 
         System.Int32 V_5)
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0006: stloc.0 
				L_0007: ldarg.0 
				L_0008: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_000d: stloc.1 
				L_000e: ldc.i4.0 
				L_000f: stloc.s V_5
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_0017: brfalse.s L_0021
				L_0019: ldarg.0 
				L_001a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_001f: stloc.s V_5
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0027: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_002c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0031: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMLEFTBORDER()
				L_0036: stloc.s V_4
				L_0038: ldloc.s V_4
				L_003a: callvirt System.Drawing.Image::Int32 get_Width()
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0045: bge.s L_00b1
				L_0047: ldc.i4.0 
				L_0048: ldarg.0 
				L_0049: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_004e: ldarg.0 
				L_004f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0054: ldloc.1 
				L_0055: ldarg.0 
				L_0056: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005b: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_0060: sub 
				L_0061: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0066: stloc.2 
				L_0067: ldarg.1 
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0073: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0078: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_007d: ldloc.2 
				L_007e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0083: ldloc.s V_5
				L_0085: ldc.i4.0 
				L_0086: ble.s L_00b1
				L_0088: ldarg.0 
				L_0089: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_008e: ldloc.s V_4
				L_0090: callvirt System.Drawing.Image::Int32 get_Width()
				L_0095: sub 
				L_0096: ldarg.0 
				L_0097: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_009c: ldarg.0 
				L_009d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_00a2: ldarg.0 
				L_00a3: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_00a8: ldloc.s V_5
				L_00aa: add 
				L_00ab: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00b0: stloc.2 
				L_00b1: ldc.i4.0 
				L_00b2: ldarg.0 
				L_00b3: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_00b8: ldarg.0 
				L_00b9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00be: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_00c3: ldloc.1 
				L_00c4: ldarg.0 
				L_00c5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00ca: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_00cf: sub 
				L_00d0: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00d5: stloc.2 
				L_00d6: ldloca.s V_3
				L_00d8: ldc.i4.0 
				L_00d9: ldc.i4.0 
				L_00da: ldloc.s V_4
				L_00dc: callvirt System.Drawing.Image::Int32 get_Width()
				L_00e1: ldloc.s V_4
				L_00e3: callvirt System.Drawing.Image::Int32 get_Height()
				L_00e8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00ed: ldarg.1 
				L_00ee: ldloc.s V_4
				L_00f0: ldloc.2 
				L_00f1: ldloca.s V_3
				L_00f3: call System.Drawing.Rectangle::Int32 get_X()
				L_00f8: ldloca.s V_3
				L_00fa: call System.Drawing.Rectangle::Int32 get_Y()
				L_00ff: ldloca.s V_3
				L_0101: call System.Drawing.Rectangle::Int32 get_Width()
				L_0106: ldloca.s V_3
				L_0108: call System.Drawing.Rectangle::Int32 get_Height()
				L_010d: ldc.i4.2 
				L_010e: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_0113: ldnull 
				L_0114: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes, DrawImageAbort)
				L_0119: ldarg.0 
				L_011a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_011f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0124: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0129: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMRIGHTBORDER()
				L_012e: stloc.s V_4
				L_0130: ldloc.s V_4
				L_0132: callvirt System.Drawing.Image::Int32 get_Width()
				L_0137: ldarg.0 
				L_0138: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_013d: bge.s L_017d
				L_013f: ldloc.0 
				L_0140: ldarg.0 
				L_0141: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0146: sub 
				L_0147: ldarg.0 
				L_0148: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_014d: ldloc.0 
				L_014e: ldloc.1 
				L_014f: ldarg.0 
				L_0150: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0155: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_015a: sub 
				L_015b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0160: stloc.2 
				L_0161: ldarg.1 
				L_0162: ldarg.0 
				L_0163: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0168: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_016d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0172: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0177: ldloc.2 
				L_0178: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_017d: ldloc.0 
				L_017e: ldarg.0 
				L_017f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0184: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_0189: sub 
				L_018a: ldarg.0 
				L_018b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0190: ldloc.0 
				L_0191: ldloc.1 
				L_0192: ldarg.0 
				L_0193: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0198: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_019d: sub 
				L_019e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_01a3: stloc.2 
				L_01a4: ldloca.s V_3
				L_01a6: ldc.i4.0 
				L_01a7: ldc.i4.0 
				L_01a8: ldloc.s V_4
				L_01aa: callvirt System.Drawing.Image::Int32 get_Width()
				L_01af: ldloc.s V_4
				L_01b1: callvirt System.Drawing.Image::Int32 get_Height()
				L_01b6: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01bb: ldarg.1 
				L_01bc: ldloc.s V_4
				L_01be: ldloc.2 
				L_01bf: ldloca.s V_3
				L_01c1: call System.Drawing.Rectangle::Int32 get_X()
				L_01c6: ldloca.s V_3
				L_01c8: call System.Drawing.Rectangle::Int32 get_Y()
				L_01cd: ldloca.s V_3
				L_01cf: call System.Drawing.Rectangle::Int32 get_Width()
				L_01d4: ldloca.s V_3
				L_01d6: call System.Drawing.Rectangle::Int32 get_Height()
				L_01db: ldc.i4.2 
				L_01dc: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_01e1: ldnull 
				L_01e2: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes, DrawImageAbort)
				L_01e7: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i1 = this.Width;
				int i2 = this.Height;
				int i3 = 0;
				if (this.MenuHeight != 0)
				{
					i3 = this.MenuHeight;
				}
				Bitmap bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMLEFTBORDER;
				if (bitmap1.Width < this.xdab5261f2cc3422d)
				{
					rectangle1 = Rectangle.FromLTRB (0, this.TitleHeight, this.xdab5261f2cc3422d, ((int) (i2 - ((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight)));
					g.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, rectangle1);
					if (i3 > 0)
					{
						rectangle1 = Rectangle.FromLTRB (((int) (this.xdab5261f2cc3422d - bitmap1.Width)), this.TitleHeight, this.xdab5261f2cc3422d, ((int) (this.TitleHeight + i3)));
					}
				}
				rectangle1 = Rectangle.FromLTRB (0, this.TitleHeight, ((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, ((int) (i2 - ((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight)));
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				g.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797, ((Graphics.DrawImageAbort) null));
				bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMRIGHTBORDER;
				if (bitmap1.Width < this.xdab5261f2cc3422d)
				{
					rectangle1 = Rectangle.FromLTRB (((int) (i1 - this.xdab5261f2cc3422d)), this.TitleHeight, i1, ((int) (i2 - ((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight)));
					g.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, rectangle1);
				}
				rectangle1 = Rectangle.FromLTRB (((int) (i1 - ((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth)), this.TitleHeight, i1, ((int) (i2 - ((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight)));
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				g.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797, ((Graphics.DrawImageAbort) null));
			}
			
			protected abstract Point PointToScreen (Point point);
			protected virtual void RefreshMainMenu ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void RefreshWindow ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected unsafe virtual void RegionWindow ()
			
			/*
				// Code Size: 1117 Bytes
				.maxstack 8
				.locals (System.Drawing.Bitmap V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Byte V_10, 
         System.Drawing.Imaging.BitmapData V_11, 
         System.Boolean V_12, 
         System.Drawing.Drawing2D.GraphicsPath V_13, 
         System.Byte* V_14, 
         System.Int32 V_15, 
         System.Byte* V_16)
				.try L_0186 to L_0257 catch System.Object L_0257 to L_025a
				.try L_0186 to L_025c finally L_025c to L_0269
				.try L_034d to L_042a catch System.Object L_042a to L_042d
				.try L_034d to L_042f finally L_042f to L_043c
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0006: brfalse.s L_0041
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_000e: brfalse.s L_0041
				L_0010: ldarg.0 
				L_0011: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0016: ldc.i4.0 
				L_0017: ble.s L_0040
				L_0019: ldarg.0 
				L_001a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_001f: ldc.i4.0 
				L_0020: ble.s L_0040
				L_0022: ldarg.0 
				L_0023: ldc.i4.0 
				L_0024: ldc.i4.0 
				L_0025: ldarg.0 
				L_0026: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_002b: ldarg.0 
				L_002c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_0031: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0036: newobj System.Drawing.Region::Void .ctor(System.Drawing.Rectangle)
				L_003b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_Region(System.Drawing.Region)
				L_0040: ret 
				L_0041: ldarg.0 
				L_0042: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0047: brfalse.s L_0064
				L_0049: ldarg.0 
				L_004a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_004f: brfalse.s L_0064
				L_0051: ldarg.0 
				L_0052: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0057: callvirt System.Drawing.Image::Int32 get_Width()
				L_005c: ldarg.0 
				L_005d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0062: beq.s L_0070
				L_0064: ldarg.0 
				L_0065: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x58714ffe12c688d9()
				L_006a: ldarg.0 
				L_006b: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3c424b74aaf6d003()
				L_0070: ldarg.0 
				L_0071: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0076: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_007b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_0080: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEBARNEEDREGION
				L_0085: brtrue.s L_00bd
				L_0087: ldarg.0 
				L_0088: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_008d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0092: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_0097: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_BOTTOMBORDERNEEDREGION
				L_009c: brtrue.s L_00bd
				L_009e: ldarg.0 
				L_009f: ldc.i4.0 
				L_00a0: ldc.i4.0 
				L_00a1: ldarg.0 
				L_00a2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_00a7: ldarg.0 
				L_00a8: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_00ad: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00b2: newobj System.Drawing.Region::Void .ctor(System.Drawing.Rectangle)
				L_00b7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_Region(System.Drawing.Region)
				L_00bc: ret 
				L_00bd: ldarg.0 
				L_00be: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_00c3: stloc.0 
				L_00c4: ldc.i4.4 
				L_00c5: stloc.s V_7
				L_00c7: ldloc.0 
				L_00c8: callvirt System.Drawing.Image::Int32 get_Height()
				L_00cd: stloc.s V_6
				L_00cf: ldloc.0 
				L_00d0: callvirt System.Drawing.Image::Int32 get_Width()
				L_00d5: stloc.s V_5
				L_00d7: ldloc.s V_5
				L_00d9: ldarg.0 
				L_00da: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_00df: bge.s L_010a
				L_00e1: ldarg.0 
				L_00e2: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x58714ffe12c688d9()
				L_00e7: ldarg.0 
				L_00e8: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3c424b74aaf6d003()
				L_00ed: ldarg.0 
				L_00ee: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x9d937faa8065bfbb()
				L_00f3: ldarg.0 
				L_00f4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_00f9: stloc.0 
				L_00fa: ldloc.0 
				L_00fb: callvirt System.Drawing.Image::Int32 get_Height()
				L_0100: stloc.s V_6
				L_0102: ldloc.0 
				L_0103: callvirt System.Drawing.Image::Int32 get_Width()
				L_0108: stloc.s V_5
				L_010a: ldnull 
				L_010b: stloc.s V_11
				L_010d: ldc.i4.1 
				L_010e: stloc.s V_12
				L_0110: newobj System.Drawing.Drawing2D.GraphicsPath::Void .ctor()
				L_0115: stloc.s V_13
				L_0117: ldarg.0 
				L_0118: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_011d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0122: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_0127: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEBARNEEDREGION
				L_012c: brfalse L_0269
				L_0131: ldarg.0 
				L_0132: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0137: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_013c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_0141: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARREGIONMINY
				L_0146: stloc.s V_9
				L_0148: ldarg.0 
				L_0149: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_014e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0153: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_0158: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARREGIONMAXY
				L_015d: stloc.s V_8
				L_015f: ldloc.s V_13
				L_0161: ldc.i4.0 
				L_0162: ldc.i4.0 
				L_0163: ldloc.s V_5
				L_0165: ldloc.s V_9
				L_0167: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_016c: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_0171: ldloc.s V_13
				L_0173: ldc.i4.0 
				L_0174: ldloc.s V_8
				L_0176: ldc.i4.1 
				L_0177: add 
				L_0178: ldloc.s V_5
				L_017a: ldloc.s V_6
				L_017c: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0181: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_0186: ldloc.0 
				L_0187: ldc.i4.0 
				L_0188: ldc.i4.0 
				L_0189: ldloc.s V_5
				L_018b: ldloc.s V_6
				L_018d: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0192: ldc.i4.1 
				L_0193: ldc.i4 2498570
				L_0198: callvirt System.Drawing.Bitmap::System.Drawing.Imaging.BitmapData LockBits(System.Drawing.Rectangle, System.Drawing.Imaging.ImageLockMode, System.Drawing.Imaging.PixelFormat)
				L_019d: stloc.s V_11
				L_019f: ldloc.s V_11
				L_01a1: callvirt System.Drawing.Imaging.BitmapData::IntPtr get_Scan0()
				L_01a6: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_01ab: stloc.s V_14
				L_01ad: ldloc.s V_14
				L_01af: ldc.i4.3 
				L_01b0: ldloc.s V_7
				L_01b2: ldloc.s V_9
				L_01b4: mul 
				L_01b5: ldloc.s V_5
				L_01b7: mul 
				L_01b8: add 
				L_01b9: add 
				L_01ba: stloc.s V_14
				L_01bc: ldloc.s V_9
				L_01be: stloc.1 
				L_01bf: br L_024d
				L_01c4: ldc.i4.0 
				L_01c5: stloc.3 
				L_01c6: ldc.i4.0 
				L_01c7: stloc.s V_4
				L_01c9: ldc.i4.1 
				L_01ca: stloc.s V_12
				L_01cc: ldc.i4.0 
				L_01cd: stloc.2 
				L_01ce: br L_0241
				L_01d3: ldloc.s V_14
				L_01d5: ldind.u1 
				L_01d6: stloc.s V_10
				L_01d8: ldloc.s V_10
				L_01da: brfalse.s L_01e3
				L_01dc: ldloc.2 
				L_01dd: ldloc.s V_5
				L_01df: ldc.i4.1 
				L_01e0: sub 
				L_01e1: bne.un.s L_0222
				L_01e3: ldloc.2 
				L_01e4: ldloc.s V_5
				L_01e6: ldc.i4.1 
				L_01e7: sub 
				L_01e8: bne.un.s L_0204
				L_01ea: ldloc.s V_10
				L_01ec: brfalse.s L_0204
				L_01ee: ldloc.s V_13
				L_01f0: ldloc.3 
				L_01f1: ldloc.1 
				L_01f2: ldloc.2 
				L_01f3: ldc.i4.1 
				L_01f4: add 
				L_01f5: ldloc.1 
				L_01f6: ldc.i4.1 
				L_01f7: add 
				L_01f8: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_01fd: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_0202: br.s L_021d
				L_0204: ldloc.s V_12
				L_0206: brtrue.s L_021d
				L_0208: ldloc.s V_13
				L_020a: ldloc.3 
				L_020b: ldloc.1 
				L_020c: ldloc.s V_4
				L_020e: ldc.i4.1 
				L_020f: add 
				L_0210: ldloc.1 
				L_0211: ldc.i4.1 
				L_0212: add 
				L_0213: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0218: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_021d: ldc.i4.1 
				L_021e: stloc.s V_12
				L_0220: br.s L_0236
				L_0222: ldloc.s V_12
				L_0224: brfalse.s L_022d
				L_0226: ldloc.2 
				L_0227: stloc.3 
				L_0228: ldloc.2 
				L_0229: stloc.s V_4
				L_022b: br.s L_0233
				L_022d: ldloc.s V_4
				L_022f: ldc.i4.1 
				L_0230: add 
				L_0231: stloc.s V_4
				L_0233: ldc.i4.0 
				L_0234: stloc.s V_12
				L_0236: ldloc.s V_14
				L_0238: ldloc.s V_7
				L_023a: add 
				L_023b: stloc.s V_14
				L_023d: ldloc.2 
				L_023e: ldc.i4.1 
				L_023f: add 
				L_0240: stloc.2 
				L_0241: ldloc.2 
				L_0242: ldloc.s V_5
				L_0244: blt L_01d3
				L_0249: ldloc.1 
				L_024a: ldc.i4.1 
				L_024b: add 
				L_024c: stloc.1 
				L_024d: ldloc.1 
				L_024e: ldloc.s V_8
				L_0250: ble L_01c4
				L_0255: leave.s L_025a
				L_0257: pop 
				L_0258: leave.s L_025a
				L_025a: leave.s L_027b
				L_025c: ldloc.s V_11
				L_025e: brfalse.s L_0268
				L_0260: ldloc.0 
				L_0261: ldloc.s V_11
				L_0263: callvirt System.Drawing.Bitmap::Void UnlockBits(System.Drawing.Imaging.BitmapData)
				L_0268: endfinally 
				L_0269: ldloc.s V_13
				L_026b: ldc.i4.0 
				L_026c: ldc.i4.0 
				L_026d: ldloc.s V_5
				L_026f: ldloc.s V_6
				L_0271: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0276: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_027b: ldloc.s V_13
				L_027d: ldc.i4.0 
				L_027e: ldloc.s V_6
				L_0280: ldarg.0 
				L_0281: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0286: ldarg.0 
				L_0287: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_028c: ldarg.0 
				L_028d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_0292: callvirt System.Drawing.Image::Int32 get_Height()
				L_0297: sub 
				L_0298: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_029d: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_02a2: ldnull 
				L_02a3: stloc.s V_11
				L_02a5: ldarg.0 
				L_02a6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_02ab: stloc.0 
				L_02ac: ldloc.0 
				L_02ad: callvirt System.Drawing.Image::Int32 get_Height()
				L_02b2: stloc.s V_6
				L_02b4: ldloc.0 
				L_02b5: callvirt System.Drawing.Image::Int32 get_Width()
				L_02ba: stloc.s V_5
				L_02bc: ldarg.0 
				L_02bd: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_02c2: ldloc.s V_6
				L_02c4: sub 
				L_02c5: stloc.s V_15
				L_02c7: ldarg.0 
				L_02c8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02cd: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02d2: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_02d7: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_BOTTOMBORDERNEEDREGION
				L_02dc: brfalse L_043c
				L_02e1: ldarg.0 
				L_02e2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02e7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02ec: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_02f1: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_BOTTOMREGIONMINY
				L_02f6: stloc.s V_9
				L_02f8: ldarg.0 
				L_02f9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02fe: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0303: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_0308: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_BOTTOMREGIONMAXY
				L_030d: stloc.s V_8
				L_030f: ldloc.s V_13
				L_0311: ldc.i4.0 
				L_0312: ldloc.s V_15
				L_0314: ldloc.s V_5
				L_0316: ldloc.s V_9
				L_0318: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_031d: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_0322: ldloc.s V_8
				L_0324: ldloc.s V_15
				L_0326: add 
				L_0327: ldc.i4.1 
				L_0328: add 
				L_0329: ldarg.0 
				L_032a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_032f: bge.s L_034d
				L_0331: ldloc.s V_13
				L_0333: ldc.i4.0 
				L_0334: ldloc.s V_8
				L_0336: ldloc.s V_15
				L_0338: add 
				L_0339: ldc.i4.1 
				L_033a: add 
				L_033b: ldloc.s V_5
				L_033d: ldarg.0 
				L_033e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_0343: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0348: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_034d: ldloc.0 
				L_034e: ldc.i4.0 
				L_034f: ldc.i4.0 
				L_0350: ldloc.s V_5
				L_0352: ldloc.s V_6
				L_0354: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0359: ldc.i4.1 
				L_035a: ldc.i4 2498570
				L_035f: callvirt System.Drawing.Bitmap::System.Drawing.Imaging.BitmapData LockBits(System.Drawing.Rectangle, System.Drawing.Imaging.ImageLockMode, System.Drawing.Imaging.PixelFormat)
				L_0364: stloc.s V_11
				L_0366: ldloc.s V_11
				L_0368: callvirt System.Drawing.Imaging.BitmapData::IntPtr get_Scan0()
				L_036d: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_0372: stloc.s V_16
				L_0374: ldloc.s V_16
				L_0376: ldc.i4.3 
				L_0377: ldloc.s V_7
				L_0379: ldloc.s V_9
				L_037b: mul 
				L_037c: ldloc.s V_5
				L_037e: mul 
				L_037f: add 
				L_0380: add 
				L_0381: stloc.s V_16
				L_0383: ldloc.s V_9
				L_0385: stloc.1 
				L_0386: br L_0420
				L_038b: ldc.i4.0 
				L_038c: stloc.3 
				L_038d: ldc.i4.0 
				L_038e: stloc.s V_4
				L_0390: ldc.i4.1 
				L_0391: stloc.s V_12
				L_0393: ldc.i4.0 
				L_0394: stloc.2 
				L_0395: br L_0414
				L_039a: ldloc.s V_16
				L_039c: ldind.u1 
				L_039d: stloc.s V_10
				L_039f: ldloc.s V_10
				L_03a1: brfalse.s L_03aa
				L_03a3: ldloc.2 
				L_03a4: ldloc.s V_5
				L_03a6: ldc.i4.1 
				L_03a7: sub 
				L_03a8: bne.un.s L_03f5
				L_03aa: ldloc.2 
				L_03ab: ldloc.s V_5
				L_03ad: ldc.i4.1 
				L_03ae: sub 
				L_03af: bne.un.s L_03d1
				L_03b1: ldloc.s V_10
				L_03b3: brfalse.s L_03d1
				L_03b5: ldloc.s V_13
				L_03b7: ldloc.3 
				L_03b8: ldloc.1 
				L_03b9: ldloc.s V_15
				L_03bb: add 
				L_03bc: ldloc.2 
				L_03bd: ldc.i4.1 
				L_03be: add 
				L_03bf: ldloc.1 
				L_03c0: ldc.i4.1 
				L_03c1: add 
				L_03c2: ldloc.s V_15
				L_03c4: add 
				L_03c5: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03ca: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_03cf: br.s L_03f0
				L_03d1: ldloc.s V_12
				L_03d3: brtrue.s L_03f0
				L_03d5: ldloc.s V_13
				L_03d7: ldloc.3 
				L_03d8: ldloc.1 
				L_03d9: ldloc.s V_15
				L_03db: add 
				L_03dc: ldloc.s V_4
				L_03de: ldc.i4.1 
				L_03df: add 
				L_03e0: ldloc.1 
				L_03e1: ldc.i4.1 
				L_03e2: add 
				L_03e3: ldloc.s V_15
				L_03e5: add 
				L_03e6: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03eb: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_03f0: ldc.i4.1 
				L_03f1: stloc.s V_12
				L_03f3: br.s L_0409
				L_03f5: ldloc.s V_12
				L_03f7: brfalse.s L_0400
				L_03f9: ldloc.2 
				L_03fa: stloc.3 
				L_03fb: ldloc.2 
				L_03fc: stloc.s V_4
				L_03fe: br.s L_0406
				L_0400: ldloc.s V_4
				L_0402: ldc.i4.1 
				L_0403: add 
				L_0404: stloc.s V_4
				L_0406: ldc.i4.0 
				L_0407: stloc.s V_12
				L_0409: ldloc.s V_16
				L_040b: ldloc.s V_7
				L_040d: add 
				L_040e: stloc.s V_16
				L_0410: ldloc.2 
				L_0411: ldc.i4.1 
				L_0412: add 
				L_0413: stloc.2 
				L_0414: ldloc.2 
				L_0415: ldloc.s V_5
				L_0417: blt L_039a
				L_041c: ldloc.1 
				L_041d: ldc.i4.1 
				L_041e: add 
				L_041f: stloc.1 
				L_0420: ldloc.1 
				L_0421: ldloc.s V_8
				L_0423: ble L_038b
				L_0428: leave.s L_042d
				L_042a: pop 
				L_042b: leave.s L_042d
				L_042d: leave.s L_044f
				L_042f: ldloc.s V_11
				L_0431: brfalse.s L_043b
				L_0433: ldloc.0 
				L_0434: ldloc.s V_11
				L_0436: callvirt System.Drawing.Bitmap::Void UnlockBits(System.Drawing.Imaging.BitmapData)
				L_043b: endfinally 
				L_043c: ldloc.s V_13
				L_043e: ldc.i4.0 
				L_043f: ldloc.s V_15
				L_0441: ldloc.s V_5
				L_0443: ldloc.s V_6
				L_0445: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_044a: callvirt System.Drawing.Drawing2D.GraphicsPath::Void AddRectangle(System.Drawing.Rectangle)
				L_044f: ldarg.0 
				L_0450: ldloc.s V_13
				L_0452: newobj System.Drawing.Region::Void .ctor(System.Drawing.Drawing2D.GraphicsPath)
				L_0457: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_Region(System.Drawing.Region)
				L_045c: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				int i7;
				int i8;
				int i9;
				byte byte1;
				BitmapData bitmapData1;
				bool b1;
				GraphicsPath graphicsPath1;
				byte* byte_Ptr1;
				int i10;
				byte* byte_Ptr2;
				if (this.IsMdiChild && (this.WindowState != FormWindowState.Normal))
				{
					if ((this.Width > 0) && (this.Height > 0))
					{
						this.Region = new System.Drawing.Region (new Rectangle (0, 0, this.Width, this.Height));
					}
					return;
				}
				if ((this.xf7b7e4e5afe45be7 == null) || ((this.xa007e927c312863e == null) || (this.xf7b7e4e5afe45be7.Width != this.Width)))
				{
					this.x58714ffe12c688d9 ();
					this.x3c424b74aaf6d003 ();
				}
				if ((! ((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_TITLEBARNEEDREGION) && (! ((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_BOTTOMBORDERNEEDREGION))
				{
					this.Region = new System.Drawing.Region (new Rectangle (0, 0, this.Width, this.Height));
					return;
				}
				bitmap1 = this.xf7b7e4e5afe45be7;
				i7 = 4;
				i6 = bitmap1.Height;
				i5 = bitmap1.Width;
				if (i5 < this.Width)
				{
					this.x58714ffe12c688d9 ();
					this.x3c424b74aaf6d003 ();
					this.x9d937faa8065bfbb ();
					bitmap1 = this.xf7b7e4e5afe45be7;
					i6 = bitmap1.Height;
					i5 = bitmap1.Width;
				}
				bitmapData1 = ((BitmapData) null);
				b1 = true;
				graphicsPath1 = new GraphicsPath ();
				if (((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_TITLEBARNEEDREGION)
				{
					i9 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_TITLEBARREGIONMINY;
					i8 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_TITLEBARREGIONMAXY;
					graphicsPath1.AddRectangle (new Rectangle (0, 0, i5, i9));
					graphicsPath1.AddRectangle (Rectangle.FromLTRB (0, ((int) (i8 + 1)), i5, i6));
					try
					{
						try
						{
							bitmapData1 = bitmap1.LockBits (new Rectangle (0, 0, i5, i6), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
							byte_Ptr1 = ((byte*) ((void*) bitmapData1.Scan0));
							byte_Ptr1 += (3 + ((i7 * i9) * i5));
							for (i1 = i9; (i1 <= i8); i1++)
							{
								i3 = 0;
								i4 = 0;
								b1 = true;
								for (i2 = 0; (i2 < i5); i2++)
								{
									byte1 = (* byte_Ptr1);
									if ((byte1 != byte.MinValue) && (i2 != (i5 - 1)))
									{
										if (! b1)
										{
											i4++;
										}
										else
										{
											i3 = i2;
											i4 = i2;
										}
										b1 = false;
									}
									else
									{
										if ((i2 == (i5 - 1)) && (byte1 != byte.MinValue))
										{
											graphicsPath1.AddRectangle (Rectangle.FromLTRB (i3, i1, ((int) (i2 + 1)), ((int) (i1 + 1))));
										}
										else if (! b1)
										{
											graphicsPath1.AddRectangle (Rectangle.FromLTRB (i3, i1, ((int) (i4 + 1)), ((int) (i1 + 1))));
										}
										b1 = true;
									}
									byte_Ptr1 += i7;
								}
							}
						}
						catch
						{
						}
						goto L_027B;
					}
					finally
					{
						if (bitmapData1 != null)
						{
							bitmap1.UnlockBits (bitmapData1);
						}
					}
				}
				graphicsPath1.AddRectangle (new Rectangle (0, 0, i5, i6));
				
			L_027B:
				
				{
				}
				graphicsPath1.AddRectangle (Rectangle.FromLTRB (0, i6, this.Width, ((int) (this.Height - this.xa007e927c312863e.Height))));
				bitmapData1 = ((BitmapData) null);
				bitmap1 = this.xa007e927c312863e;
				i6 = bitmap1.Height;
				i5 = bitmap1.Width;
				i10 = (this.Height - i6);
				if (((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_BOTTOMBORDERNEEDREGION)
				{
					i9 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_BOTTOMREGIONMINY;
					i8 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_BOTTOMREGIONMAXY;
					graphicsPath1.AddRectangle (new Rectangle (0, i10, i5, i9));
					if (((i8 + i10) + 1) < this.Height)
					{
						graphicsPath1.AddRectangle (Rectangle.FromLTRB (0, ((int) ((i8 + i10) + 1)), i5, this.Height));
					}
					try
					{
						try
						{
							bitmapData1 = bitmap1.LockBits (new Rectangle (0, 0, i5, i6), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
							byte_Ptr2 = ((byte*) ((void*) bitmapData1.Scan0));
							byte_Ptr2 += (3 + ((i7 * i9) * i5));
							for (i1 = i9; (i1 <= i8); i1++)
							{
								i3 = 0;
								i4 = 0;
								b1 = true;
								byte byte1_1;
								for (i2 = 0; (i2 < i5); i2++)
								{
									byte1_1 = (* byte_Ptr2);
									if ((byte1_1 != byte.MinValue) && (i2 != (i5 - 1)))
									{
										if (! b1)
										{
											i4++;
										}
										else
										{
											i3 = i2;
											i4 = i2;
										}
										b1 = false;
									}
									else
									{
										if ((i2 == (i5 - 1)) && (byte1_1 != byte.MinValue))
										{
											graphicsPath1.AddRectangle (Rectangle.FromLTRB (i3, ((int) (i1 + i10)), ((int) (i2 + 1)), ((int) ((i1 + 1) + i10))));
										}
										else if (! b1)
										{
											graphicsPath1.AddRectangle (Rectangle.FromLTRB (i3, ((int) (i1 + i10)), ((int) (i4 + 1)), ((int) ((i1 + 1) + i10))));
										}
										b1 = true;
									}
									byte_Ptr2 += i7;
								}
							}
						}
						catch
						{
						}
						goto L_044F;
					}
					finally
					{
						if (bitmapData1 != null)
						{
							bitmap1.UnlockBits (bitmapData1);
						}
					}
				}
				graphicsPath1.AddRectangle (new Rectangle (0, i10, i5, i6));
				
			L_044F:
				
				{
				}
				this.Region = new System.Drawing.Region (graphicsPath1);
			}
			
			protected virtual void ResetWindowStyle ()
			
			/*
				// Code Size: 108 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0)
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldc.i4.s -16
				L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_000d: stloc.0 
				L_000e: ldarg.0 
				L_000f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0014: brfalse.s L_0035
				L_0016: ldloc.0 
				L_0017: ldc.i4 524288
				L_001c: and 
				L_001d: ldc.i4 524288
				L_0022: bne.un.s L_004c
				L_0024: ldarg.0 
				L_0025: ldc.i4.1 
				L_0026: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x507503a87814ae33
				L_002b: ldloc.0 
				L_002c: ldc.i4 524288
				L_0031: sub 
				L_0032: stloc.0 
				L_0033: br.s L_004c
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x507503a87814ae33
				L_003b: brfalse.s L_004c
				L_003d: ldloc.0 
				L_003e: ldc.i4 524288
				L_0043: or 
				L_0044: stloc.0 
				L_0045: ldarg.0 
				L_0046: ldc.i4.0 
				L_0047: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x507503a87814ae33
				L_004c: ldarg.0 
				L_004d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_0052: brtrue.s L_006b
				L_0054: ldarg.0 
				L_0055: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormBorderStyle get_BorderStyle()
				L_005a: brfalse.s L_006b
				L_005c: ldarg.0 
				L_005d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0062: ldc.i4.s -16
				L_0064: ldloc.0 
				L_0065: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_006a: pop 
				L_006b: ret 
			*/
			
			
			{
				uint uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -16);
				if (this.CanPaint)
				{
					if ((((int) uInt32_1) & 524288) == 524288)
					{
						this.x507503a87814ae33 = true;
						uInt32_1 = ((uint) (((int) uInt32_1) - 524288));
					}
				}
				else if (this.x507503a87814ae33)
				{
					uInt32_1 = ((uint) (((int) uInt32_1) | 524288));
					this.x507503a87814ae33 = false;
				}
				if ((! this.IsDisposed) && (this.BorderStyle != FormBorderStyle.None))
				{
					uint uInt32_2 = x61467fe65a98f20c.SetWindowLong (base.Handle, -16, uInt32_1);
				}
			}
			
			protected virtual void SaveWindowStyle ()
			
			/*
				// Code Size: 100 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0007: ldc.i4.s -16
				L_0009: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_000e: stfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x9cc269364e8b3cf1
				L_0013: ldarg.0 
				L_0014: ldarg.0 
				L_0015: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_001a: ldc.i4.s -20
				L_001c: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0021: stfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_0026: ldarg.0 
				L_0027: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_002c: brfalse.s L_0063
				L_002e: ldarg.0 
				L_002f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0034: brfalse.s L_0063
				L_0036: ldarg.0 
				L_0037: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_003c: ldc.i4 4194304
				L_0041: and 
				L_0042: ldc.i4 4194304
				L_0047: bne.un.s L_0063
				L_0049: ldarg.0 
				L_004a: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_004f: ldc.i4.s -20
				L_0051: ldarg.0 
				L_0052: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::UInt32 x8782b9e138b1b2e0
				L_0057: ldc.i4 4194304
				L_005c: sub 
				L_005d: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0062: pop 
				L_0063: ret 
			*/
			
			
			{
				this.x9cc269364e8b3cf1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -16);
				this.x8782b9e138b1b2e0 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
				if ((this.RightToLeftLayout && this.CanPaint) && ((((int) this.x8782b9e138b1b2e0) & 4194304) == 4194304))
				{
					uint uInt32_1 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, ((uint) (((int) this.x8782b9e138b1b2e0) - 4194304)));
				}
			}
			
			protected abstract void SkinControls ();
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 40 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_000f: brfalse.s L_0018
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldarg.1 
				L_0022: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0027: ret 
			*/
			
			
			{
				if (! this.CanPaint)
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
			
			private int x0c7b47d7852a0e99 ()
			
			/*
				// Code Size: 105 Bytes
				.maxstack 4
				.locals (System.Int32 V_0, 
         System.Drawing.Bitmap V_1)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_000b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_0010: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARBUTTONPOSY
				L_0015: stloc.0 
				L_0016: ldarg.0 
				L_0017: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_001c: ldc.i4.1 
				L_001d: bne.un.s L_0061
				L_001f: ldarg.0 
				L_0020: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0025: brfalse.s L_0061
				L_0027: ldarg.0 
				L_0028: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0032: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0037: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_003c: ldc.i4.1 
				L_003d: ldelem.ref 
				L_003e: stloc.1 
				L_003f: ldc.i4.s 26
				L_0041: ldloc.1 
				L_0042: callvirt System.Drawing.Image::Int32 get_Height()
				L_0047: sub 
				L_0048: ldc.i4.2 
				L_0049: div 
				L_004a: ldc.i4.0 
				L_004b: call System.Math::Int32 Max(Int32, Int32)
				L_0050: stloc.0 
				L_0051: ldloc.0 
				L_0052: ldloc.1 
				L_0053: callvirt System.Drawing.Image::Int32 get_Height()
				L_0058: add 
				L_0059: ldc.i4.s 22
				L_005b: bge.s L_0061
				L_005d: ldloc.0 
				L_005e: ldc.i4.2 
				L_005f: add 
				L_0060: stloc.0 
				L_0061: ldloc.0 
				L_0062: ldc.i4.4 
				L_0063: bge.s L_0067
				L_0065: ldc.i4.4 
				L_0066: stloc.0 
				L_0067: ldloc.0 
				L_0068: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				int i1 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_TITLEBARBUTTONPOSY;
				if ((this.WindowState == FormWindowState.Minimized) && this.IsMdiChild)
				{
					bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[1];
					i1 = Math.Max (((int) ((26 - bitmap1.Height) / 2)), 0);
					if ((i1 + bitmap1.Height) < 22)
					{
						i1 += 2;
					}
				}
				if (i1 >= 4)
				{
					return i1;
				}
				else
				{
					return 4;
				}
			}
			
			private uint x13d7e7b52a69e5dc ()
			
			/*
				// Code Size: 573 Bytes
				.maxstack 5
				.locals (System.Drawing.Point V_0)
				L_0000: ldloca.s V_0
				L_0002: ldc.i4.0 
				L_0003: ldc.i4.0 
				L_0004: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0009: ldloca.s V_0
				L_000b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetCursorPos(System.Drawing.Point ByRef)
				L_0010: brtrue.s L_0014
				L_0012: ldc.i4.0 
				L_0013: ret 
				L_0014: ldarg.0 
				L_0015: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_001a: ldloca.s V_0
				L_001c: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ScreenToClient(IntPtr, System.Drawing.Point ByRef)
				L_0021: brtrue.s L_0025
				L_0023: ldc.i4.0 
				L_0024: ret 
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_002b: brtrue.s L_002f
				L_002d: ldc.i4.0 
				L_002e: ret 
				L_002f: ldloca.s V_0
				L_0031: dup 
				L_0032: call System.Drawing.Point::Int32 get_X()
				L_0037: ldarg.0 
				L_0038: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_0042: ldc.i4.4 
				L_0043: call System.Math::Int32 Max(Int32, Int32)
				L_0048: add 
				L_0049: call System.Drawing.Point::Void set_X(Int32)
				L_004e: ldloca.s V_0
				L_0050: dup 
				L_0051: call System.Drawing.Point::Int32 get_Y()
				L_0056: ldarg.0 
				L_0057: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_005c: add 
				L_005d: call System.Drawing.Point::Void set_Y(Int32)
				L_0062: ldarg.0 
				L_0063: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0068: brfalse.s L_0075
				L_006a: ldarg.0 
				L_006b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_0070: ldc.i4.2 
				L_0071: bne.un.s L_0075
				L_0073: ldc.i4.1 
				L_0074: ret 
				L_0075: ldloc.0 
				L_0076: ldarg.0 
				L_0077: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_007c: ldc.i4.3 
				L_007d: ldelema System.Drawing.Rectangle
				L_0082: ldobj System.Drawing.Rectangle
				L_0087: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_008c: brfalse.s L_0090
				L_008e: ldc.i4.3 
				L_008f: ret 
				L_0090: ldloc.0 
				L_0091: ldarg.0 
				L_0092: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0097: ldc.i4.s 20
				L_0099: ldelema System.Drawing.Rectangle
				L_009e: ldobj System.Drawing.Rectangle
				L_00a3: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_00a8: brfalse.s L_00ad
				L_00aa: ldc.i4.s 20
				L_00ac: ret 
				L_00ad: ldloc.0 
				L_00ae: ldarg.0 
				L_00af: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00b4: ldc.i4.s 9
				L_00b6: ldelema System.Drawing.Rectangle
				L_00bb: ldobj System.Drawing.Rectangle
				L_00c0: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_00c5: brfalse.s L_00ca
				L_00c7: ldc.i4.s 9
				L_00c9: ret 
				L_00ca: ldloc.0 
				L_00cb: ldarg.0 
				L_00cc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00d1: ldc.i4.8 
				L_00d2: ldelema System.Drawing.Rectangle
				L_00d7: ldobj System.Drawing.Rectangle
				L_00dc: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_00e1: brfalse.s L_00e5
				L_00e3: ldc.i4.8 
				L_00e4: ret 
				L_00e5: ldloc.0 
				L_00e6: ldarg.0 
				L_00e7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00ec: ldc.i4.8 
				L_00ed: ldelema System.Drawing.Rectangle
				L_00f2: ldobj System.Drawing.Rectangle
				L_00f7: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_00fc: brfalse.s L_0100
				L_00fe: ldc.i4.8 
				L_00ff: ret 
				L_0100: ldloc.0 
				L_0101: ldarg.0 
				L_0102: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0107: ldc.i4.s 21
				L_0109: ldelema System.Drawing.Rectangle
				L_010e: ldobj System.Drawing.Rectangle
				L_0113: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0118: brfalse.s L_011d
				L_011a: ldc.i4.s 21
				L_011c: ret 
				L_011d: ldloc.0 
				L_011e: ldarg.0 
				L_011f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0124: ldc.i4.s 16
				L_0126: ldelema System.Drawing.Rectangle
				L_012b: ldobj System.Drawing.Rectangle
				L_0130: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0135: brfalse.s L_013a
				L_0137: ldc.i4.s 16
				L_0139: ret 
				L_013a: ldloc.0 
				L_013b: ldarg.0 
				L_013c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0141: ldc.i4.s 17
				L_0143: ldelema System.Drawing.Rectangle
				L_0148: ldobj System.Drawing.Rectangle
				L_014d: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0152: brfalse.s L_0157
				L_0154: ldc.i4.s 17
				L_0156: ret 
				L_0157: ldloc.0 
				L_0158: ldarg.0 
				L_0159: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_015e: ldc.i4.s 13
				L_0160: ldelema System.Drawing.Rectangle
				L_0165: ldobj System.Drawing.Rectangle
				L_016a: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_016f: brfalse.s L_0174
				L_0171: ldc.i4.s 13
				L_0173: ret 
				L_0174: ldloc.0 
				L_0175: ldarg.0 
				L_0176: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_017b: ldc.i4.s 14
				L_017d: ldelema System.Drawing.Rectangle
				L_0182: ldobj System.Drawing.Rectangle
				L_0187: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_018c: brfalse.s L_0191
				L_018e: ldc.i4.s 14
				L_0190: ret 
				L_0191: ldloc.0 
				L_0192: ldarg.0 
				L_0193: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0198: ldc.i4.s 10
				L_019a: ldelema System.Drawing.Rectangle
				L_019f: ldobj System.Drawing.Rectangle
				L_01a4: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_01a9: brfalse.s L_01ae
				L_01ab: ldc.i4.s 10
				L_01ad: ret 
				L_01ae: ldloc.0 
				L_01af: ldarg.0 
				L_01b0: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01b5: ldc.i4.s 11
				L_01b7: ldelema System.Drawing.Rectangle
				L_01bc: ldobj System.Drawing.Rectangle
				L_01c1: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_01c6: brfalse.s L_01cb
				L_01c8: ldc.i4.s 11
				L_01ca: ret 
				L_01cb: ldloc.0 
				L_01cc: ldarg.0 
				L_01cd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01d2: ldc.i4.s 12
				L_01d4: ldelema System.Drawing.Rectangle
				L_01d9: ldobj System.Drawing.Rectangle
				L_01de: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_01e3: brfalse.s L_01e8
				L_01e5: ldc.i4.s 12
				L_01e7: ret 
				L_01e8: ldloc.0 
				L_01e9: ldarg.0 
				L_01ea: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01ef: ldc.i4.s 15
				L_01f1: ldelema System.Drawing.Rectangle
				L_01f6: ldobj System.Drawing.Rectangle
				L_01fb: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0200: brfalse.s L_0205
				L_0202: ldc.i4.s 15
				L_0204: ret 
				L_0205: ldloc.0 
				L_0206: ldarg.0 
				L_0207: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_020c: ldc.i4.2 
				L_020d: ldelema System.Drawing.Rectangle
				L_0212: ldobj System.Drawing.Rectangle
				L_0217: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_021c: brfalse.s L_0220
				L_021e: ldc.i4.2 
				L_021f: ret 
				L_0220: ldloc.0 
				L_0221: ldarg.0 
				L_0222: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0227: ldc.i4.1 
				L_0228: ldelema System.Drawing.Rectangle
				L_022d: ldobj System.Drawing.Rectangle
				L_0232: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0237: brfalse.s L_023b
				L_0239: ldc.i4.1 
				L_023a: ret 
				L_023b: ldc.i4.0 
				L_023c: ret 
			*/
			
			
			{
				Point point1;
				point1 = new Point (0, 0);
				if (! x61467fe65a98f20c.GetCursorPos (ref point1))
				{
					return uint.MinValue;
				}
				else if (! x61467fe65a98f20c.ScreenToClient (base.Handle, ref point1))
				{
					return uint.MinValue;
				}
				else if (this.x170170622f070c21 == null)
				{
					return uint.MinValue;
				}
				else
				{
					point1.X += Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, 4);
					point1.Y += this.TitleHeight;
					if (this.IsMdiChild && (this.WindowState == FormWindowState.Maximized))
					{
						return 1;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[3]))
					{
						return 3;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[20]))
					{
						return 20;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[9]))
					{
						return 9;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[8]))
					{
						return 8;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[8]))
					{
						return 8;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[21]))
					{
						return 21;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[16]))
					{
						return 16;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[17]))
					{
						return 17;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[13]))
					{
						return 13;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[14]))
					{
						return 14;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[10]))
					{
						return 10;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[11]))
					{
						return 11;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[12]))
					{
						return 12;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[15]))
					{
						return 15;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[2]))
					{
						return 2;
					}
					else if (! x448fd9ab43628c71.x9466a6be27202526 (point1, this.x170170622f070c21[1]))
					{
						return uint.MinValue;
					}
					else
					{
						return 1;
					}
				}
			}
			
			protected void x18f04d42fe6eab01 ()
			
			/*
				// Code Size: 49 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWINFO V_0)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWINFO
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000e: ldloca.s V_0
				L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowInfo(IntPtr, WINDOWINFO ByRef)
				L_0015: pop 
				L_0016: ldarg.0 
				L_0017: ldloca.s V_0
				L_0019: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWINFO::UInt32 cxWindowBorders
				L_001e: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0023: ldarg.0 
				L_0024: ldloca.s V_0
				L_0026: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+WINDOWINFO::UInt32 cyWindowBorders
				L_002b: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_0030: ret 
			*/
			
			
			{
				x40255b11ef821fa3.WINDOWINFO wINDOWINFO1 = new x40255b11ef821fa3.WINDOWINFO ();
				bool b1 = x61467fe65a98f20c.GetWindowInfo (base.Handle, ref wINDOWINFO1);
				this.xdab5261f2cc3422d = ((int) wINDOWINFO1.cxWindowBorders);
				this.xef9eb32e7f1d1f23 = ((int) wINDOWINFO1.cyWindowBorders);
			}
			
			private void x271f237e4704798d ()
			
			/*
				// Code Size: 1582 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Drawing.Graphics V_8, 
         System.Drawing.Font V_9, 
         System.Drawing.SizeF V_10, 
         System.Drawing.Size V_11)
				.try L_0392 to L_0621 finally L_0621 to L_062d
				L_0000: ldarg.0 
				L_0001: ldc.i4.s 23
				L_0003: newarr System.Drawing.Rectangle
				L_0008: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0013: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0018: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_001d: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_0022: ldc.i4.1 
				L_0023: ldelem.ref 
				L_0024: callvirt System.Drawing.Image::Int32 get_Width()
				L_0029: stloc.s V_4
				L_002b: ldarg.0 
				L_002c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0031: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0036: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_003b: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_0040: ldc.i4.1 
				L_0041: ldelem.ref 
				L_0042: callvirt System.Drawing.Image::Int32 get_Height()
				L_0047: stloc.s V_5
				L_0049: ldarg.0 
				L_004a: call Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x0c7b47d7852a0e99()
				L_004f: stloc.2 
				L_0050: ldarg.0 
				L_0051: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0056: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_005b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_0060: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARICONPOSX
				L_0065: stloc.3 
				L_0066: ldarg.0 
				L_0067: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_006c: brfalse L_0164
				L_0071: ldloc.3 
				L_0072: ldc.i4.4 
				L_0073: add 
				L_0074: stloc.0 
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_007b: ldc.i4.3 
				L_007c: ldelema System.Drawing.Rectangle
				L_0081: ldloc.0 
				L_0082: ldloc.2 
				L_0083: ldc.i4.s 16
				L_0085: ldc.i4.s 16
				L_0087: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_008c: ldloc.0 
				L_008d: ldc.i4.s 18
				L_008f: add 
				L_0090: stloc.3 
				L_0091: ldarg.0 
				L_0092: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0097: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_009c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_00a1: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARBUTTONPOSX
				L_00a6: stloc.s V_6
				L_00a8: ldloc.s V_6
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b0: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_00b5: bge.s L_00c4
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00bd: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_00c2: stloc.s V_6
				L_00c4: ldarg.0 
				L_00c5: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_00ca: ldloc.s V_6
				L_00cc: sub 
				L_00cd: ldloc.s V_4
				L_00cf: sub 
				L_00d0: stloc.0 
				L_00d1: ldarg.0 
				L_00d2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00d7: ldc.i4.s 20
				L_00d9: ldelema System.Drawing.Rectangle
				L_00de: ldloc.0 
				L_00df: ldloc.2 
				L_00e0: ldloc.s V_4
				L_00e2: ldloc.s V_5
				L_00e4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e9: ldloc.0 
				L_00ea: ldloc.s V_4
				L_00ec: ldc.i4.2 
				L_00ed: add 
				L_00ee: sub 
				L_00ef: stloc.0 
				L_00f0: ldarg.0 
				L_00f1: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_00f6: brfalse.s L_0117
				L_00f8: ldarg.0 
				L_00f9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00fe: ldc.i4.s 9
				L_0100: ldelema System.Drawing.Rectangle
				L_0105: ldloc.0 
				L_0106: ldloc.2 
				L_0107: ldloc.s V_4
				L_0109: ldloc.s V_5
				L_010b: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0110: ldloc.0 
				L_0111: ldloc.s V_4
				L_0113: ldc.i4.2 
				L_0114: add 
				L_0115: sub 
				L_0116: stloc.0 
				L_0117: ldarg.0 
				L_0118: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_011d: brfalse.s L_013d
				L_011f: ldarg.0 
				L_0120: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0125: ldc.i4.8 
				L_0126: ldelema System.Drawing.Rectangle
				L_012b: ldloc.0 
				L_012c: ldloc.2 
				L_012d: ldloc.s V_4
				L_012f: ldloc.s V_5
				L_0131: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0136: ldloc.0 
				L_0137: ldloc.s V_4
				L_0139: ldc.i4.2 
				L_013a: add 
				L_013b: sub 
				L_013c: stloc.0 
				L_013d: ldarg.0 
				L_013e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_0143: brfalse.s L_0164
				L_0145: ldarg.0 
				L_0146: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_014b: ldc.i4.s 21
				L_014d: ldelema System.Drawing.Rectangle
				L_0152: ldloc.0 
				L_0153: ldloc.2 
				L_0154: ldloc.s V_4
				L_0156: ldloc.s V_5
				L_0158: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_015d: ldloc.0 
				L_015e: ldloc.s V_4
				L_0160: ldc.i4.2 
				L_0161: add 
				L_0162: sub 
				L_0163: stloc.0 
				L_0164: ldarg.0 
				L_0165: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_016a: stloc.s V_4
				L_016c: ldarg.0 
				L_016d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_0172: stloc.s V_5
				L_0174: ldarg.0 
				L_0175: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_017a: stloc.s V_7
				L_017c: ldarg.0 
				L_017d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0182: ldc.i4.2 
				L_0183: ldelema System.Drawing.Rectangle
				L_0188: ldc.i4.0 
				L_0189: ldc.i4.0 
				L_018a: ldloc.s V_4
				L_018c: ldloc.s V_7
				L_018e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0193: ldarg.0 
				L_0194: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0199: ldc.i4.1 
				L_019a: ldelema System.Drawing.Rectangle
				L_019f: ldc.i4.0 
				L_01a0: ldc.i4.0 
				L_01a1: ldloc.s V_4
				L_01a3: ldloc.s V_5
				L_01a5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01aa: ldarg.0 
				L_01ab: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanSize()
				L_01b0: brfalse L_0295
				L_01b5: ldarg.0 
				L_01b6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01bb: ldc.i4.s 10
				L_01bd: ldelema System.Drawing.Rectangle
				L_01c2: ldc.i4.0 
				L_01c3: ldloc.s V_7
				L_01c5: ldc.i4.4 
				L_01c6: ldloc.s V_5
				L_01c8: ldloc.s V_7
				L_01ca: sub 
				L_01cb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01d0: ldarg.0 
				L_01d1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01d6: ldc.i4.s 11
				L_01d8: ldelema System.Drawing.Rectangle
				L_01dd: ldloc.s V_4
				L_01df: ldc.i4.4 
				L_01e0: sub 
				L_01e1: ldloc.s V_7
				L_01e3: ldc.i4.4 
				L_01e4: ldloc.s V_5
				L_01e6: ldloc.s V_7
				L_01e8: sub 
				L_01e9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01ee: ldarg.0 
				L_01ef: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_01f4: ldc.i4.s 12
				L_01f6: ldelema System.Drawing.Rectangle
				L_01fb: ldc.i4.s 15
				L_01fd: ldc.i4.0 
				L_01fe: ldloc.s V_4
				L_0200: ldc.i4.s 30
				L_0202: sub 
				L_0203: ldc.i4.4 
				L_0204: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0209: ldarg.0 
				L_020a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_020f: ldc.i4.s 15
				L_0211: ldelema System.Drawing.Rectangle
				L_0216: ldc.i4.s 15
				L_0218: ldloc.s V_5
				L_021a: ldc.i4.4 
				L_021b: sub 
				L_021c: ldloc.s V_4
				L_021e: ldc.i4.s 30
				L_0220: sub 
				L_0221: ldc.i4.4 
				L_0222: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0227: ldarg.0 
				L_0228: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_022d: ldc.i4.s 13
				L_022f: ldelema System.Drawing.Rectangle
				L_0234: ldc.i4.0 
				L_0235: ldc.i4.0 
				L_0236: ldc.i4.s 15
				L_0238: ldloc.s V_7
				L_023a: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_023f: ldarg.0 
				L_0240: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0245: ldc.i4.s 14
				L_0247: ldelema System.Drawing.Rectangle
				L_024c: ldloc.s V_4
				L_024e: ldc.i4.s 15
				L_0250: sub 
				L_0251: ldc.i4.0 
				L_0252: ldc.i4.s 15
				L_0254: ldloc.s V_7
				L_0256: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_025b: ldarg.0 
				L_025c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0261: ldc.i4.s 16
				L_0263: ldelema System.Drawing.Rectangle
				L_0268: ldc.i4.0 
				L_0269: ldloc.s V_5
				L_026b: ldc.i4.4 
				L_026c: sub 
				L_026d: ldc.i4.s 15
				L_026f: ldc.i4.4 
				L_0270: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0275: ldarg.0 
				L_0276: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_027b: ldc.i4.s 17
				L_027d: ldelema System.Drawing.Rectangle
				L_0282: ldloc.s V_4
				L_0284: ldc.i4.s 15
				L_0286: sub 
				L_0287: ldloc.s V_5
				L_0289: ldc.i4.s 15
				L_028b: sub 
				L_028c: ldc.i4.s 15
				L_028e: ldc.i4.s 15
				L_0290: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0295: ldarg.0 
				L_0296: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_029b: brfalse L_0382
				L_02a0: ldarg.0 
				L_02a1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02a6: ldc.i4.s 20
				L_02a8: ldelema System.Drawing.Rectangle
				L_02ad: ldarg.0 
				L_02ae: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_02b3: ldarg.0 
				L_02b4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02b9: ldc.i4.s 20
				L_02bb: ldelema System.Drawing.Rectangle
				L_02c0: call System.Drawing.Rectangle::Int32 get_X()
				L_02c5: sub 
				L_02c6: ldc.i4.s 16
				L_02c8: sub 
				L_02c9: call System.Drawing.Rectangle::Void set_X(Int32)
				L_02ce: ldarg.0 
				L_02cf: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02d4: ldc.i4.s 9
				L_02d6: ldelema System.Drawing.Rectangle
				L_02db: ldarg.0 
				L_02dc: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_02e1: ldarg.0 
				L_02e2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02e7: ldc.i4.s 9
				L_02e9: ldelema System.Drawing.Rectangle
				L_02ee: call System.Drawing.Rectangle::Int32 get_X()
				L_02f3: sub 
				L_02f4: ldc.i4.s 16
				L_02f6: sub 
				L_02f7: call System.Drawing.Rectangle::Void set_X(Int32)
				L_02fc: ldarg.0 
				L_02fd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0302: ldc.i4.8 
				L_0303: ldelema System.Drawing.Rectangle
				L_0308: ldarg.0 
				L_0309: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_030e: ldarg.0 
				L_030f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0314: ldc.i4.8 
				L_0315: ldelema System.Drawing.Rectangle
				L_031a: call System.Drawing.Rectangle::Int32 get_X()
				L_031f: sub 
				L_0320: ldc.i4.s 16
				L_0322: sub 
				L_0323: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0328: ldarg.0 
				L_0329: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_032e: ldc.i4.3 
				L_032f: ldelema System.Drawing.Rectangle
				L_0334: ldarg.0 
				L_0335: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_033a: ldarg.0 
				L_033b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0340: ldc.i4.3 
				L_0341: ldelema System.Drawing.Rectangle
				L_0346: call System.Drawing.Rectangle::Int32 get_X()
				L_034b: sub 
				L_034c: ldc.i4.s 16
				L_034e: sub 
				L_034f: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0354: ldarg.0 
				L_0355: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_035a: ldc.i4.s 21
				L_035c: ldelema System.Drawing.Rectangle
				L_0361: ldarg.0 
				L_0362: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0367: ldarg.0 
				L_0368: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_036d: ldc.i4.s 21
				L_036f: ldelema System.Drawing.Rectangle
				L_0374: call System.Drawing.Rectangle::Int32 get_X()
				L_0379: sub 
				L_037a: ldc.i4.s 16
				L_037c: sub 
				L_037d: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0382: ldc.i4.s 10
				L_0384: ldc.i4.s 10
				L_0386: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_038b: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0390: stloc.s V_8
				L_0392: ldarg.0 
				L_0393: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_0398: brfalse L_048e
				L_039d: ldarg.0 
				L_039e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03a3: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosX()
				L_03a8: ldc.i4.m1 
				L_03a9: bne.un.s L_03ea
				L_03ab: ldarg.0 
				L_03ac: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_03b1: brfalse.s L_03d1
				L_03b3: ldarg.0 
				L_03b4: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Icon get_Icon()
				L_03b9: brfalse.s L_03d1
				L_03bb: ldarg.0 
				L_03bc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_03c1: ldc.i4.3 
				L_03c2: ldelema System.Drawing.Rectangle
				L_03c7: call System.Drawing.Rectangle::Int32 get_Left()
				L_03cc: ldc.i4.2 
				L_03cd: sub 
				L_03ce: stloc.1 
				L_03cf: br.s L_03f9
				L_03d1: ldloc.s V_4
				L_03d3: ldarg.0 
				L_03d4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03d9: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_03de: ldc.i4.4 
				L_03df: call System.Math::Int32 Max(Int32, Int32)
				L_03e4: sub 
				L_03e5: ldc.i4.2 
				L_03e6: sub 
				L_03e7: stloc.1 
				L_03e8: br.s L_03f9
				L_03ea: ldloc.s V_4
				L_03ec: ldarg.0 
				L_03ed: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03f2: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosX()
				L_03f7: sub 
				L_03f8: stloc.1 
				L_03f9: ldarg.0 
				L_03fa: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_03ff: brfalse.s L_0474
				L_0401: ldarg.0 
				L_0402: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0407: ldc.i4.s 20
				L_0409: ldelema System.Drawing.Rectangle
				L_040e: call System.Drawing.Rectangle::Int32 get_Right()
				L_0413: ldc.i4.2 
				L_0414: add 
				L_0415: stloc.0 
				L_0416: ldarg.0 
				L_0417: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_041c: brfalse.s L_0433
				L_041e: ldarg.0 
				L_041f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0424: ldc.i4.s 9
				L_0426: ldelema System.Drawing.Rectangle
				L_042b: call System.Drawing.Rectangle::Int32 get_Right()
				L_0430: ldc.i4.2 
				L_0431: add 
				L_0432: stloc.0 
				L_0433: ldarg.0 
				L_0434: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_0439: brfalse.s L_044f
				L_043b: ldarg.0 
				L_043c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0441: ldc.i4.8 
				L_0442: ldelema System.Drawing.Rectangle
				L_0447: call System.Drawing.Rectangle::Int32 get_Right()
				L_044c: ldc.i4.2 
				L_044d: add 
				L_044e: stloc.0 
				L_044f: ldarg.0 
				L_0450: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_0455: brfalse L_056b
				L_045a: ldarg.0 
				L_045b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0460: ldc.i4.s 21
				L_0462: ldelema System.Drawing.Rectangle
				L_0467: call System.Drawing.Rectangle::Int32 get_Right()
				L_046c: ldc.i4.2 
				L_046d: add 
				L_046e: stloc.0 
				L_046f: br L_056b
				L_0474: ldarg.0 
				L_0475: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_047a: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_047f: ldc.i4.4 
				L_0480: call System.Math::Int32 Max(Int32, Int32)
				L_0485: ldc.i4.s 16
				L_0487: add 
				L_0488: stloc.0 
				L_0489: br L_056b
				L_048e: ldarg.0 
				L_048f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0494: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosX()
				L_0499: ldc.i4.m1 
				L_049a: bne.un.s L_04d9
				L_049c: ldarg.0 
				L_049d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_04a2: brfalse.s L_04c2
				L_04a4: ldarg.0 
				L_04a5: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Icon get_Icon()
				L_04aa: brfalse.s L_04c2
				L_04ac: ldarg.0 
				L_04ad: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_04b2: ldc.i4.3 
				L_04b3: ldelema System.Drawing.Rectangle
				L_04b8: call System.Drawing.Rectangle::Int32 get_Right()
				L_04bd: ldc.i4.2 
				L_04be: add 
				L_04bf: stloc.0 
				L_04c0: br.s L_04e5
				L_04c2: ldarg.0 
				L_04c3: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_04c8: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_04cd: ldc.i4.4 
				L_04ce: call System.Math::Int32 Max(Int32, Int32)
				L_04d3: ldc.i4.s 16
				L_04d5: add 
				L_04d6: stloc.0 
				L_04d7: br.s L_04e5
				L_04d9: ldarg.0 
				L_04da: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_04df: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosX()
				L_04e4: stloc.0 
				L_04e5: ldarg.0 
				L_04e6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_04eb: brfalse.s L_055a
				L_04ed: ldarg.0 
				L_04ee: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_04f3: ldc.i4.s 20
				L_04f5: ldelema System.Drawing.Rectangle
				L_04fa: call System.Drawing.Rectangle::Int32 get_Left()
				L_04ff: ldc.i4.2 
				L_0500: sub 
				L_0501: stloc.1 
				L_0502: ldarg.0 
				L_0503: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0508: brfalse.s L_051f
				L_050a: ldarg.0 
				L_050b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0510: ldc.i4.s 9
				L_0512: ldelema System.Drawing.Rectangle
				L_0517: call System.Drawing.Rectangle::Int32 get_Left()
				L_051c: ldc.i4.2 
				L_051d: sub 
				L_051e: stloc.1 
				L_051f: ldarg.0 
				L_0520: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_0525: brfalse.s L_053b
				L_0527: ldarg.0 
				L_0528: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_052d: ldc.i4.8 
				L_052e: ldelema System.Drawing.Rectangle
				L_0533: call System.Drawing.Rectangle::Int32 get_Left()
				L_0538: ldc.i4.2 
				L_0539: sub 
				L_053a: stloc.1 
				L_053b: ldarg.0 
				L_053c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_0541: brfalse.s L_056b
				L_0543: ldarg.0 
				L_0544: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0549: ldc.i4.s 21
				L_054b: ldelema System.Drawing.Rectangle
				L_0550: call System.Drawing.Rectangle::Int32 get_Left()
				L_0555: ldc.i4.2 
				L_0556: sub 
				L_0557: stloc.1 
				L_0558: br.s L_056b
				L_055a: ldloc.s V_4
				L_055c: ldarg.0 
				L_055d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0562: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_0567: sub 
				L_0568: ldc.i4.2 
				L_0569: sub 
				L_056a: stloc.1 
				L_056b: ldarg.0 
				L_056c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0571: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0576: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_057b: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEFIVESECT
				L_0580: brfalse.s L_059f
				L_0582: ldloc.1 
				L_0583: ldarg.0 
				L_0584: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0589: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_058e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0593: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_0598: callvirt System.Drawing.Image::Int32 get_Width()
				L_059d: sub 
				L_059e: stloc.1 
				L_059f: ldarg.0 
				L_05a0: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_05a5: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_05aa: brtrue.s L_05b5
				L_05ac: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font get_x0a05657cf1966ee7()
				L_05b1: stloc.s V_9
				L_05b3: br.s L_05c2
				L_05b5: ldarg.0 
				L_05b6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_05bb: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_05c0: stloc.s V_9
				L_05c2: ldarg.0 
				L_05c3: ldloc.s V_8
				L_05c5: ldarg.0 
				L_05c6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.String get_Text()
				L_05cb: ldloc.s V_9
				L_05cd: ldloc.1 
				L_05ce: ldloc.0 
				L_05cf: sub 
				L_05d0: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.String xd770c4dc45b3b54f(System.Drawing.Graphics, System.String, System.Drawing.Font, Int32)
				L_05d5: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.String xa4b5d355cbf01a80
				L_05da: ldarg.0 
				L_05db: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_05e0: ldc.i4.1 
				L_05e1: and 
				L_05e2: ldc.i4.1 
				L_05e3: bne.un.s L_05ee
				L_05e5: ldarg.0 
				L_05e6: ldloc.1 
				L_05e7: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_05ec: br.s L_05f5
				L_05ee: ldarg.0 
				L_05ef: ldloc.0 
				L_05f0: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_05f5: ldarg.0 
				L_05f6: ldloc.s V_8
				L_05f8: ldarg.0 
				L_05f9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.String xa4b5d355cbf01a80
				L_05fe: ldloc.s V_9
				L_0600: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_0605: stloc.s V_10
				L_0607: ldloca.s V_10
				L_0609: call System.Drawing.SizeF::System.Drawing.Size ToSize()
				L_060e: stloc.s V_11
				L_0610: ldloca.s V_11
				L_0612: call System.Drawing.Size::Int32 get_Width()
				L_0617: ldc.i4.s 10
				L_0619: add 
				L_061a: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x6b81454f45088f2e
				L_061f: leave.s L_062d
				L_0621: ldloc.s V_8
				L_0623: brfalse.s L_062c
				L_0625: ldloc.s V_8
				L_0627: callvirt System.IDisposable::Void Dispose()
				L_062c: endfinally 
				L_062d: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i7;
				Font font1;
				this.x170170622f070c21 = new Rectangle[23];
				int i5 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[1].Width;
				int i6 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[1].Height;
				int i3 = this.x0c7b47d7852a0e99 ();
				int i4 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_TITLEBARICONPOSX;
				if (this.ControlBox)
				{
					i1 = (i4 + 4);
					this.x170170622f070c21[3] = new Rectangle (i1, i3, 16, 16);
					i4 = ((int) (i1 + 18));
					i7 = ((SkinInt) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Integers).SKIN2_TITLEBARBUTTONPOSX;
					if (i7 < ((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth)
					{
						i7 = ((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth;
					}
					i1 = ((this.Width - i7) - i5);
					this.x170170622f070c21[20] = new Rectangle (i1, i3, i5, i6);
					i1 -= (i5 + 2);
					if (this.MaximizeBox)
					{
						this.x170170622f070c21[9] = new Rectangle (i1, i3, i5, i6);
						i1 -= (i5 + 2);
					}
					if (this.MinimizeBox)
					{
						this.x170170622f070c21[8] = new Rectangle (i1, i3, i5, i6);
						i1 -= (i5 + 2);
					}
					if (this.HelpButton)
					{
						this.x170170622f070c21[21] = new Rectangle (i1, i3, i5, i6);
						i1 -= (i5 + 2);
					}
				}
				i5 = this.Width;
				i6 = this.Height;
				int i8 = this.TitleHeight;
				this.x170170622f070c21[2] = new Rectangle (0, 0, i5, i8);
				this.x170170622f070c21[1] = new Rectangle (0, 0, i5, i6);
				if (this.CanSize)
				{
					this.x170170622f070c21[10] = new Rectangle (0, i8, 4, ((int) (i6 - i8)));
					this.x170170622f070c21[11] = new Rectangle (((int) (i5 - 4)), i8, 4, ((int) (i6 - i8)));
					this.x170170622f070c21[12] = new Rectangle (15, 0, ((int) (i5 - 30)), 4);
					this.x170170622f070c21[15] = new Rectangle (15, ((int) (i6 - 4)), ((int) (i5 - 30)), 4);
					this.x170170622f070c21[13] = new Rectangle (0, 0, 15, i8);
					this.x170170622f070c21[14] = new Rectangle (((int) (i5 - 15)), 0, 15, i8);
					this.x170170622f070c21[16] = new Rectangle (0, ((int) (i6 - 4)), 15, 4);
					this.x170170622f070c21[17] = new Rectangle (((int) (i5 - 15)), ((int) (i6 - 15)), 15, 15);
				}
				if (this.RightToLeftLayout)
				{
					this.x170170622f070c21[20].X = ((int) ((this.Width - this.x170170622f070c21[20].X) - 16));
					this.x170170622f070c21[9].X = ((int) ((this.Width - this.x170170622f070c21[9].X) - 16));
					this.x170170622f070c21[8].X = ((int) ((this.Width - this.x170170622f070c21[8].X) - 16));
					this.x170170622f070c21[3].X = ((int) ((this.Width - this.x170170622f070c21[3].X) - 16));
					this.x170170622f070c21[21].X = ((int) ((this.Width - this.x170170622f070c21[21].X) - 16));
				}
				using (Graphics graphics1 = Graphics.FromImage (((Image) new Bitmap (10, 10))))
				{
					if (this.RightToLeftLayout)
					{
						if (((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosX != -1)
						{
							i2 = (i5 - ((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosX);
						}
						else if (this.ControlBox && (this.Icon != null))
						{
							i2 = (this.x170170622f070c21[3].Left - 2);
						}
						else
						{
							i2 = ((i5 - Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth, 4)) - 2);
						}
						if (this.ControlBox)
						{
							i1 = (this.x170170622f070c21[20].Right + 2);
							if (this.MaximizeBox)
							{
								i1 = (this.x170170622f070c21[9].Right + 2);
							}
							if (this.MinimizeBox)
							{
								i1 = (this.x170170622f070c21[8].Right + 2);
							}
							if (this.HelpButton)
							{
								i1 = (this.x170170622f070c21[21].Right + 2);
							}
						}
						else
						{
							i1 = ((int) (Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, 4) + 16));
						}
					}
					else
					{
						if (((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosX != -1)
						{
							i1 = ((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosX;
						}
						else if ((! this.ControlBox) || (this.Icon == null))
						{
							i1 = ((int) (Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, 4) + 16));
						}
						else
						{
							i1 = (this.x170170622f070c21[3].Right + 2);
						}
						if (this.ControlBox)
						{
							i2 = (this.x170170622f070c21[20].Left - 2);
							if (this.MaximizeBox)
							{
								i2 = (this.x170170622f070c21[9].Left - 2);
							}
							if (this.MinimizeBox)
							{
								i2 = (this.x170170622f070c21[8].Left - 2);
							}
							if (this.HelpButton)
							{
								i2 = (this.x170170622f070c21[21].Left - 2);
							}
						}
						else
						{
							i2 = ((i5 - ((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth) - 2);
						}
					}
					if (((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_TITLEFIVESECT)
					{
						i2 -= ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3.Width;
					}
					if (((SkinEngine) this.xdc87e2b99332cd4a).TitleFont == null)
					{
						font1 = x448fd9ab43628c71.x0a05657cf1966ee7;
					}
					else
					{
						font1 = ((SkinEngine) this.xdc87e2b99332cd4a).TitleFont;
					}
					this.xa4b5d355cbf01a80 = x448fd9ab43628c71.xd770c4dc45b3b54f (graphics1, this.Text, font1, ((int) (i2 - i1)));
					if ((this.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
					{
						this.x5a29066520654c5a = i2;
					}
					else
					{
						this.x5a29066520654c5a = i1;
					}
					this.x6b81454f45088f2e = ((int) (graphics1.MeasureString (this.xa4b5d355cbf01a80, font1).ToSize ().Width + 10));
				}
			}
			
			protected void x3b8ca818f0c2637e ()
			
			/*
				// Code Size: 269 Bytes
				.maxstack 8
				.locals (System.IntPtr V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Brush V_2)
				.try L_0037 to L_00f0 finally L_00f0 to L_00fa
				.try L_0012 to L_0109 catch System.Object L_0109 to L_010c
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_000f: brtrue.s L_0012
				L_0011: ret 
				L_0012: ldarg.0 
				L_0013: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0018: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_001d: stloc.0 
				L_001e: ldloc.0 
				L_001f: ldsfld System.IntPtr::IntPtr Zero
				L_0024: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_0029: brfalse.s L_0030
				L_002b: leave L_010c
				L_0030: ldloc.0 
				L_0031: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0036: stloc.1 
				L_0037: ldarg.0 
				L_0038: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x58714ffe12c688d9()
				L_003d: ldarg.0 
				L_003e: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x3c424b74aaf6d003()
				L_0043: ldarg.0 
				L_0044: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x9d937faa8065bfbb()
				L_0049: ldarg.0 
				L_004a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_004f: brfalse.s L_005f
				L_0051: ldloc.1 
				L_0052: ldarg.0 
				L_0053: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_0058: ldc.i4.0 
				L_0059: ldc.i4.0 
				L_005a: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_005f: ldarg.0 
				L_0060: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0065: brfalse.s L_009d
				L_0067: ldarg.0 
				L_0068: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_006d: ldc.i4.2 
				L_006e: bne.un.s L_009d
				L_0070: ldarg.0 
				L_0071: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0076: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_007b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0080: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0085: stloc.2 
				L_0086: ldloc.1 
				L_0087: ldloc.2 
				L_0088: ldc.i4.0 
				L_0089: ldc.i4.0 
				L_008a: ldarg.0 
				L_008b: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0090: ldarg.0 
				L_0091: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0096: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_009b: br.s L_00ee
				L_009d: ldarg.0 
				L_009e: ldloc.1 
				L_009f: call Sunisoft.IrisSkin.xd24df615efe9450e::Void xfecf8a78f99f2530(System.Drawing.Graphics)
				L_00a4: ldarg.0 
				L_00a5: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_00aa: brfalse.s L_00b5
				L_00ac: ldarg.0 
				L_00ad: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_00b2: ldc.i4.1 
				L_00b3: beq.s L_00ee
				L_00b5: ldarg.0 
				L_00b6: ldloc.1 
				L_00b7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void PaintBorder(System.Drawing.Graphics)
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_00c2: brfalse.s L_00ee
				L_00c4: ldloc.1 
				L_00c5: ldarg.0 
				L_00c6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_00cb: ldc.i4.0 
				L_00cc: ldarg.0 
				L_00cd: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Height()
				L_00d2: ldarg.0 
				L_00d3: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00d8: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_00dd: ldarg.0 
				L_00de: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_00e3: call System.Math::Int32 Max(Int32, Int32)
				L_00e8: sub 
				L_00e9: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00ee: leave.s L_00fa
				L_00f0: ldloc.1 
				L_00f1: brfalse.s L_00f9
				L_00f3: ldloc.1 
				L_00f4: callvirt System.IDisposable::Void Dispose()
				L_00f9: endfinally 
				L_00fa: ldarg.0 
				L_00fb: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0100: ldloc.0 
				L_0101: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0106: pop 
				L_0107: leave.s L_010c
				L_0109: pop 
				L_010a: leave.s L_010c
				L_010c: ret 
			*/
			
			
			{
				IntPtr intPtr1;
				Brush brush1;
				if ((this.x170170622f070c21 != null) && this.CanPaint)
				{
					try
					{
						intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
						if (intPtr1 == IntPtr.Zero)
						{
							return;
						}
						else
						{
							using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
							{
								this.x58714ffe12c688d9 ();
								this.x3c424b74aaf6d003 ();
								this.x9d937faa8065bfbb ();
								if (this.x15810b502d9e43ee != null)
								{
									graphics1.DrawImageUnscaled (((Image) this.x15810b502d9e43ee), 0, 0);
								}
								if (this.IsMdiChild && (this.WindowState == FormWindowState.Maximized))
								{
									brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
									graphics1.FillRectangle (brush1, 0, 0, this.Width, this.TitleHeight);
								}
								else
								{
									this.xfecf8a78f99f2530 (graphics1);
									if ((! this.IsMdiChild) || (this.WindowState != FormWindowState.Minimized))
									{
										this.PaintBorder (graphics1);
										if (this.xa007e927c312863e != null)
										{
											graphics1.DrawImageUnscaled (((Image) this.xa007e927c312863e), 0, ((int) (this.Height - Math.Max (((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight, this.xef9eb32e7f1d1f23))));
										}
									}
								}
							}
							int i1 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
						}
					}
					catch
					{
					}
				}
			}
			
			private void x3c424b74aaf6d003 ()
			
			/*
				// Code Size: 604 Bytes
				.maxstack 10
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Drawing.Graphics V_9, 
         System.Drawing.Bitmap V_10, 
         System.Drawing.Graphics V_11)
				.try L_0212 to L_0227 finally L_0227 to L_0233
				.try L_0209 to L_0241 finally L_0241 to L_024d
				.try L_0054 to L_024f finally L_024f to L_025b
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_0006: brfalse.s L_0013
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_000e: callvirt System.Drawing.Image::Void Dispose()
				L_0013: ldarg.0 
				L_0014: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_0019: stloc.3 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0020: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_0025: stloc.s V_4
				L_0027: ldc.i4.0 
				L_0028: stloc.s V_5
				L_002a: ldarg.0 
				L_002b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_0030: stloc.s V_8
				L_0032: ldarg.0 
				L_0033: ldloc.3 
				L_0034: ldloc.s V_4
				L_0036: ldloc.s V_8
				L_0038: call System.Math::Int32 Max(Int32, Int32)
				L_003d: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0042: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_004d: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0052: stloc.s V_9
				L_0054: ldloca.s V_2
				L_0056: ldc.i4.0 
				L_0057: ldc.i4.0 
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_005e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0063: ldarg.0 
				L_0064: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xa007e927c312863e
				L_0069: callvirt System.Drawing.Image::Int32 get_Height()
				L_006e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0073: ldloc.s V_4
				L_0075: ldloc.s V_8
				L_0077: bge.s L_00bc
				L_0079: ldloc.s V_8
				L_007b: ldloc.s V_4
				L_007d: sub 
				L_007e: stloc.s V_5
				L_0080: ldloc.s V_9
				L_0082: ldarg.0 
				L_0083: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0088: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_008d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0092: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0097: ldarg.0 
				L_0098: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_009d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_00a2: ldc.i4.0 
				L_00a3: ldloc.3 
				L_00a4: ldarg.0 
				L_00a5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00aa: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_00af: sub 
				L_00b0: ldloc.s V_5
				L_00b2: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00b7: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_00cc: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_BOTTOMBORDERTHREESECT
				L_00d1: brfalse L_01e5
				L_00d6: ldarg.0 
				L_00d7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00dc: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00e1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00e6: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMBOTTOMBORDER1()
				L_00eb: stloc.0 
				L_00ec: ldloca.s V_2
				L_00ee: ldc.i4.0 
				L_00ef: ldloc.s V_5
				L_00f1: ldloc.0 
				L_00f2: callvirt System.Drawing.Image::Int32 get_Width()
				L_00f7: ldloc.s V_4
				L_00f9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00fe: ldloca.s V_1
				L_0100: ldc.i4.0 
				L_0101: ldc.i4.0 
				L_0102: ldloc.0 
				L_0103: callvirt System.Drawing.Image::Int32 get_Width()
				L_0108: ldloc.0 
				L_0109: callvirt System.Drawing.Image::Int32 get_Height()
				L_010e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0113: ldloc.s V_9
				L_0115: ldloc.0 
				L_0116: ldloc.2 
				L_0117: ldloc.1 
				L_0118: ldc.i4.2 
				L_0119: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_011e: ldloca.s V_2
				L_0120: call System.Drawing.Rectangle::Int32 get_Right()
				L_0125: stloc.s V_6
				L_0127: ldarg.0 
				L_0128: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_012d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0132: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0137: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMBOTTOMBORDER3()
				L_013c: stloc.0 
				L_013d: ldloca.s V_2
				L_013f: ldloc.3 
				L_0140: ldloc.0 
				L_0141: callvirt System.Drawing.Image::Int32 get_Width()
				L_0146: sub 
				L_0147: ldloc.s V_5
				L_0149: ldloc.0 
				L_014a: callvirt System.Drawing.Image::Int32 get_Width()
				L_014f: ldloc.s V_4
				L_0151: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0156: ldloca.s V_1
				L_0158: ldc.i4.0 
				L_0159: ldc.i4.0 
				L_015a: ldloc.0 
				L_015b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0160: ldloc.0 
				L_0161: callvirt System.Drawing.Image::Int32 get_Height()
				L_0166: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_016b: ldloc.s V_9
				L_016d: ldloc.0 
				L_016e: ldloc.2 
				L_016f: ldloc.1 
				L_0170: ldc.i4.2 
				L_0171: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0176: ldloca.s V_2
				L_0178: call System.Drawing.Rectangle::Int32 get_Left()
				L_017d: stloc.s V_7
				L_017f: ldarg.0 
				L_0180: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0185: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_018a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_018f: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMBOTTOMBORDER2()
				L_0194: stloc.0 
				L_0195: ldloc.s V_6
				L_0197: ldloc.s V_5
				L_0199: ldloc.s V_7
				L_019b: ldloc.s V_4
				L_019d: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_01a2: stloc.2 
				L_01a3: ldloca.s V_1
				L_01a5: ldc.i4.0 
				L_01a6: ldc.i4.0 
				L_01a7: ldloc.0 
				L_01a8: callvirt System.Drawing.Image::Int32 get_Width()
				L_01ad: ldloc.0 
				L_01ae: callvirt System.Drawing.Image::Int32 get_Height()
				L_01b3: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01b8: ldloc.s V_9
				L_01ba: ldloc.0 
				L_01bb: ldloc.2 
				L_01bc: ldloca.s V_1
				L_01be: call System.Drawing.Rectangle::Int32 get_X()
				L_01c3: ldloca.s V_1
				L_01c5: call System.Drawing.Rectangle::Int32 get_Y()
				L_01ca: ldloca.s V_1
				L_01cc: call System.Drawing.Rectangle::Int32 get_Width()
				L_01d1: ldloca.s V_1
				L_01d3: call System.Drawing.Rectangle::Int32 get_Height()
				L_01d8: ldc.i4.2 
				L_01d9: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_01de: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_01e3: br.s L_024d
				L_01e5: ldarg.0 
				L_01e6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01eb: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01f0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_01f5: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMBOTTOMBORDER1()
				L_01fa: stloc.0 
				L_01fb: ldloc.3 
				L_01fc: ldloc.0 
				L_01fd: callvirt System.Drawing.Image::Int32 get_Height()
				L_0202: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0207: stloc.s V_10
				L_0209: ldloc.s V_10
				L_020b: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0210: stloc.s V_11
				L_0212: ldloc.0 
				L_0213: ldloc.s V_11
				L_0215: ldc.i4.0 
				L_0216: ldc.i4.0 
				L_0217: ldloc.3 
				L_0218: ldloc.s V_4
				L_021a: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_021f: ldc.i4.0 
				L_0220: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x6871065fdac2acd2(System.Drawing.Bitmap, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_0225: leave.s L_0233
				L_0227: ldloc.s V_11
				L_0229: brfalse.s L_0232
				L_022b: ldloc.s V_11
				L_022d: callvirt System.IDisposable::Void Dispose()
				L_0232: endfinally 
				L_0233: ldloc.s V_9
				L_0235: ldloc.s V_10
				L_0237: ldc.i4.0 
				L_0238: ldloc.s V_5
				L_023a: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_023f: leave.s L_024d
				L_0241: ldloc.s V_10
				L_0243: brfalse.s L_024c
				L_0245: ldloc.s V_10
				L_0247: callvirt System.IDisposable::Void Dispose()
				L_024c: endfinally 
				L_024d: leave.s L_025b
				L_024f: ldloc.s V_9
				L_0251: brfalse.s L_025a
				L_0253: ldloc.s V_9
				L_0255: callvirt System.IDisposable::Void Dispose()
				L_025a: endfinally 
				L_025b: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i4;
				int i5;
				if (this.xa007e927c312863e != null)
				{
					this.xa007e927c312863e.Dispose ();
				}
				int i1 = this.Width;
				int i2 = ((SkinEngine) this.xdc87e2b99332cd4a).BottomBorderHeight;
				int i3 = 0;
				int i6 = this.xef9eb32e7f1d1f23;
				this.xa007e927c312863e = new Bitmap (i1, Math.Max (i2, i6));
				using (Graphics graphics1 = Graphics.FromImage (((Image) this.xa007e927c312863e)))
				{
					rectangle2 = new Rectangle (0, 0, this.xa007e927c312863e.Width, this.xa007e927c312863e.Height);
					if (i2 < i6)
					{
						i3 = (i6 - i2);
						graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, Rectangle.FromLTRB (((SkinEngine) this.xdc87e2b99332cd4a).LeftBorderWidth, 0, ((int) (i1 - ((SkinEngine) this.xdc87e2b99332cd4a).RightBorderWidth)), i3));
					}
					if (((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_BOTTOMBORDERTHREESECT)
					{
						bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMBOTTOMBORDER1;
						rectangle2 = new Rectangle (0, i3, bitmap1.Width, i2);
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						graphics1.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						i4 = rectangle2.Right;
						bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMBOTTOMBORDER3;
						rectangle2 = new Rectangle (((int) (i1 - bitmap1.Width)), i3, bitmap1.Width, i2);
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						graphics1.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						i5 = rectangle2.Left;
						bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMBOTTOMBORDER2;
						rectangle2 = Rectangle.FromLTRB (i4, i3, i5, i2);
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						graphics1.DrawImage (((Image) bitmap1), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					}
					else
					{
						bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_FORMBOTTOMBORDER1;
						using (Bitmap bitmap2 = new Bitmap (i1, bitmap1.Height))
						{
							using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap2)))
							{
								x448fd9ab43628c71.x6871065fdac2acd2 (bitmap1, graphics2, new Rectangle (0, 0, i1, i2), false);
							}
							graphics1.DrawImageUnscaled (((Image) bitmap2), 0, i3);
						}
					}
				}
			}
			
			internal void x52b190e626f65140 (bool xde860fba55c41d76)
			
			/*
				// Code Size: 98 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.xbd3f2493841f18a1 V_0, 
         System.Object V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0014 to L_003c finally L_003c to L_004d
				L_0000: ldarg.1 
				L_0001: brfalse.s L_004d
				L_0003: ldarg.0 
				L_0004: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0009: callvirt System.Collections.Hashtable::System.Collections.ICollection get_Values()
				L_000e: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_0013: stloc.2 
				L_0014: br.s L_0032
				L_0016: ldloc.2 
				L_0017: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_001c: stloc.1 
				L_001d: ldloc.1 
				L_001e: isinst Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_0023: brfalse.s L_0032
				L_0025: ldloc.1 
				L_0026: castclass Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_002b: stloc.0 
				L_002c: ldloc.0 
				L_002d: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x52b190e626f65140()
				L_0032: ldloc.2 
				L_0033: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0038: brtrue.s L_0016
				L_003a: leave.s L_004d
				L_003c: ldloc.2 
				L_003d: isinst System.IDisposable
				L_0042: stloc.3 
				L_0043: ldloc.3 
				L_0044: brfalse.s L_004c
				L_0046: ldloc.3 
				L_0047: callvirt System.IDisposable::Void Dispose()
				L_004c: endfinally 
				L_004d: ldarg.0 
				L_004e: ldc.i4.0 
				L_004f: stfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean x230e512478b11e00
				L_0054: ldarg.0 
				L_0055: ldnull 
				L_0056: ldc.i4.0 
				L_0057: newobj Sunisoft.IrisSkin.SkinChangedEventArgs::Void .ctor(Boolean)
				L_005c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0061: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				if (xde860fba55c41d76)
				{
					foreach (object object1 in this.x84603c7eff1953af.Values)
					{
						if (object1 is xbd3f2493841f18a1)
						{
							xbd3f2493841f18a1_1 = ((xbd3f2493841f18a1) object1);
							xbd3f2493841f18a1_1.x52b190e626f65140 ();
						}
					}
				}
				this.x230e512478b11e00 = false;
				this.OnCurrentSkinChanged (null, new SkinChangedEventArgs (false));
			}
			
			private void x58714ffe12c688d9 ()
			
			/*
				// Code Size: 1840 Bytes
				.maxstack 11
				.locals (System.Boolean V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Boolean V_3, 
         System.Drawing.Bitmap V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Rectangle V_6, 
         System.Drawing.Brush V_7, 
         System.Drawing.Graphics V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Drawing.Bitmap V_11, 
         System.Drawing.Graphics V_12, 
         System.Drawing.Bitmap V_13, 
         System.Drawing.Graphics V_14, 
         System.Drawing.Graphics V_15, 
         System.Drawing.Image V_16, 
         System.Drawing.Bitmap V_17)
				.try L_0346 to L_03f1 finally L_03f1 to L_03fd
				.try L_033d to L_042d finally L_042d to L_0439
				.try L_0596 to L_05e5 finally L_05e5 to L_05f1
				.try L_058d to L_061e finally L_061e to L_062a
				.try L_0064 to L_062c finally L_062c to L_0638
				.try L_06d9 to L_06fc finally L_06fc to L_0708
				.try L_06b0 to L_0715 finally L_0715 to L_0721
				.try L_0659 to L_0723 finally L_0723 to L_072f
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0006: brfalse.s L_0013
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_000e: callvirt System.Drawing.Image::Void Dispose()
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0019: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_001e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_0023: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEFIVESECT
				L_0028: stloc.0 
				L_0029: ldarg.0 
				L_002a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_002f: stloc.1 
				L_0030: ldarg.0 
				L_0031: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0036: stloc.2 
				L_0037: ldarg.0 
				L_0038: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_003d: ldc.i4.1 
				L_003e: bne.un.s L_0048
				L_0040: ldarg.0 
				L_0041: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_0046: br.s L_0049
				L_0048: ldc.i4.0 
				L_0049: stloc.3 
				L_004a: ldarg.0 
				L_004b: ldloc.1 
				L_004c: ldloc.2 
				L_004d: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0052: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0057: ldarg.0 
				L_0058: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_005d: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0062: stloc.s V_8
				L_0064: ldloc.3 
				L_0065: brfalse.s L_00b3
				L_0067: ldarg.0 
				L_0068: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0072: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0077: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_MINIMIZEDTITLE()
				L_007c: stloc.s V_4
				L_007e: ldloca.s V_5
				L_0080: ldc.i4.0 
				L_0081: ldc.i4.0 
				L_0082: ldloc.1 
				L_0083: ldloc.2 
				L_0084: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0089: ldloca.s V_6
				L_008b: ldc.i4.0 
				L_008c: ldc.i4.0 
				L_008d: ldloc.s V_4
				L_008f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0094: ldloc.s V_4
				L_0096: callvirt System.Drawing.Image::Int32 get_Height()
				L_009b: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00a0: ldloc.s V_8
				L_00a2: ldloc.s V_4
				L_00a4: ldloc.s V_5
				L_00a6: ldloc.s V_6
				L_00a8: ldc.i4.2 
				L_00a9: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00ae: br L_062a
				L_00b3: ldloc.0 
				L_00b4: brfalse.s L_00cf
				L_00b6: ldarg.0 
				L_00b7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00bc: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00c6: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR5()
				L_00cb: stloc.s V_4
				L_00cd: br.s L_00e6
				L_00cf: ldarg.0 
				L_00d0: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00d5: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00da: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00df: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_00e4: stloc.s V_4
				L_00e6: ldloc.1 
				L_00e7: ldloc.s V_4
				L_00e9: callvirt System.Drawing.Image::Int32 get_Width()
				L_00ee: sub 
				L_00ef: stloc.s V_9
				L_00f1: ldloca.s V_5
				L_00f3: ldloc.s V_9
				L_00f5: ldc.i4.0 
				L_00f6: ldloc.s V_4
				L_00f8: callvirt System.Drawing.Image::Int32 get_Width()
				L_00fd: ldloc.2 
				L_00fe: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0103: ldloca.s V_6
				L_0105: ldc.i4.0 
				L_0106: ldc.i4.0 
				L_0107: ldloc.s V_4
				L_0109: callvirt System.Drawing.Image::Int32 get_Width()
				L_010e: ldloc.2 
				L_010f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0114: ldloc.s V_8
				L_0116: ldloc.s V_4
				L_0118: ldloc.s V_5
				L_011a: ldloc.s V_6
				L_011c: ldc.i4.2 
				L_011d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0122: ldloc.0 
				L_0123: brfalse L_0439
				L_0128: ldloc.s V_9
				L_012a: ldarg.0 
				L_012b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0130: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0135: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_013a: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_013f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0144: ldarg.0 
				L_0145: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_014a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_014f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0154: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_0159: callvirt System.Drawing.Image::Int32 get_Width()
				L_015e: add 
				L_015f: ble L_02f8
				L_0164: ldarg.0 
				L_0165: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_016a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_016f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0174: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_0179: stloc.s V_4
				L_017b: ldloca.s V_5
				L_017d: ldc.i4.0 
				L_017e: ldc.i4.0 
				L_017f: ldloc.s V_4
				L_0181: callvirt System.Drawing.Image::Int32 get_Width()
				L_0186: ldloc.2 
				L_0187: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_018c: ldloca.s V_6
				L_018e: ldc.i4.0 
				L_018f: ldc.i4.0 
				L_0190: ldloc.s V_4
				L_0192: callvirt System.Drawing.Image::Int32 get_Width()
				L_0197: ldloc.s V_4
				L_0199: callvirt System.Drawing.Image::Int32 get_Height()
				L_019e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01a3: ldloc.s V_8
				L_01a5: ldloc.s V_4
				L_01a7: ldloc.s V_5
				L_01a9: ldloc.s V_6
				L_01ab: ldc.i4.2 
				L_01ac: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01b1: ldloc.s V_4
				L_01b3: callvirt System.Drawing.Image::Int32 get_Width()
				L_01b8: stloc.s V_10
				L_01ba: ldarg.0 
				L_01bb: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01c0: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01c5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_01ca: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR2()
				L_01cf: stloc.s V_4
				L_01d1: ldloca.s V_5
				L_01d3: ldloc.s V_10
				L_01d5: ldc.i4.0 
				L_01d6: ldarg.0 
				L_01d7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x6b81454f45088f2e
				L_01dc: ldloc.2 
				L_01dd: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01e2: ldloca.s V_6
				L_01e4: ldc.i4.0 
				L_01e5: ldc.i4.0 
				L_01e6: ldloc.s V_4
				L_01e8: callvirt System.Drawing.Image::Int32 get_Width()
				L_01ed: ldloc.s V_4
				L_01ef: callvirt System.Drawing.Image::Int32 get_Height()
				L_01f4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01f9: ldloc.s V_8
				L_01fb: ldloc.s V_4
				L_01fd: ldloc.s V_5
				L_01ff: ldloca.s V_6
				L_0201: call System.Drawing.Rectangle::Int32 get_X()
				L_0206: ldloca.s V_6
				L_0208: call System.Drawing.Rectangle::Int32 get_Y()
				L_020d: ldloca.s V_6
				L_020f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0214: ldloca.s V_6
				L_0216: call System.Drawing.Rectangle::Int32 get_Height()
				L_021b: ldc.i4.2 
				L_021c: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_0221: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0226: ldarg.0 
				L_0227: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_022c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0231: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0236: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_023b: stloc.s V_4
				L_023d: ldloca.s V_5
				L_023f: ldloca.s V_5
				L_0241: call System.Drawing.Rectangle::Int32 get_Right()
				L_0246: ldc.i4.0 
				L_0247: ldloc.s V_4
				L_0249: callvirt System.Drawing.Image::Int32 get_Width()
				L_024e: ldloc.2 
				L_024f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0254: ldloca.s V_6
				L_0256: ldc.i4.0 
				L_0257: ldc.i4.0 
				L_0258: ldloc.s V_4
				L_025a: callvirt System.Drawing.Image::Int32 get_Width()
				L_025f: ldloc.s V_4
				L_0261: callvirt System.Drawing.Image::Int32 get_Height()
				L_0266: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_026b: ldloc.s V_8
				L_026d: ldloc.s V_4
				L_026f: ldloc.s V_5
				L_0271: ldloc.s V_6
				L_0273: ldc.i4.2 
				L_0274: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0279: ldarg.0 
				L_027a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_027f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0284: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0289: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR4()
				L_028e: stloc.s V_4
				L_0290: ldloca.s V_5
				L_0292: call System.Drawing.Rectangle::Int32 get_Right()
				L_0297: ldc.i4.0 
				L_0298: ldloc.s V_9
				L_029a: ldloc.2 
				L_029b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02a0: stloc.s V_5
				L_02a2: ldloca.s V_6
				L_02a4: ldc.i4.0 
				L_02a5: ldc.i4.0 
				L_02a6: ldloc.s V_4
				L_02a8: callvirt System.Drawing.Image::Int32 get_Width()
				L_02ad: ldloc.s V_4
				L_02af: callvirt System.Drawing.Image::Int32 get_Height()
				L_02b4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02b9: ldloca.s V_5
				L_02bb: call System.Drawing.Rectangle::Int32 get_Width()
				L_02c0: ldc.i4.0 
				L_02c1: ble L_062a
				L_02c6: ldloc.s V_8
				L_02c8: ldloc.s V_4
				L_02ca: ldloc.s V_5
				L_02cc: ldloca.s V_6
				L_02ce: call System.Drawing.Rectangle::Int32 get_X()
				L_02d3: ldloca.s V_6
				L_02d5: call System.Drawing.Rectangle::Int32 get_Y()
				L_02da: ldloca.s V_6
				L_02dc: call System.Drawing.Rectangle::Int32 get_Width()
				L_02e1: ldloca.s V_6
				L_02e3: call System.Drawing.Rectangle::Int32 get_Height()
				L_02e8: ldc.i4.2 
				L_02e9: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_02ee: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_02f3: br L_062a
				L_02f8: ldloc.s V_9
				L_02fa: ldc.i4.0 
				L_02fb: ble L_062a
				L_0300: ldarg.0 
				L_0301: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0306: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_030b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0310: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_0315: callvirt System.Drawing.Image::Int32 get_Width()
				L_031a: ldarg.0 
				L_031b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0320: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0325: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_032a: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_032f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0334: add 
				L_0335: ldloc.2 
				L_0336: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_033b: stloc.s V_11
				L_033d: ldloc.s V_11
				L_033f: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0344: stloc.s V_12
				L_0346: ldarg.0 
				L_0347: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_034c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0351: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0356: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_035b: stloc.s V_4
				L_035d: ldloca.s V_5
				L_035f: ldc.i4.0 
				L_0360: ldc.i4.0 
				L_0361: ldloc.s V_4
				L_0363: callvirt System.Drawing.Image::Int32 get_Width()
				L_0368: ldloc.2 
				L_0369: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_036e: ldloca.s V_6
				L_0370: ldc.i4.0 
				L_0371: ldc.i4.0 
				L_0372: ldloc.s V_4
				L_0374: callvirt System.Drawing.Image::Int32 get_Width()
				L_0379: ldloc.s V_4
				L_037b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0380: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0385: ldloc.s V_12
				L_0387: ldloc.s V_4
				L_0389: ldloc.s V_5
				L_038b: ldloc.s V_6
				L_038d: ldc.i4.2 
				L_038e: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0393: ldloc.s V_4
				L_0395: callvirt System.Drawing.Image::Int32 get_Width()
				L_039a: stloc.s V_10
				L_039c: ldarg.0 
				L_039d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03a2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03a7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_03ac: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_03b1: stloc.s V_4
				L_03b3: ldloca.s V_5
				L_03b5: ldloca.s V_5
				L_03b7: call System.Drawing.Rectangle::Int32 get_Right()
				L_03bc: ldc.i4.0 
				L_03bd: ldloc.s V_4
				L_03bf: callvirt System.Drawing.Image::Int32 get_Width()
				L_03c4: ldloc.2 
				L_03c5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03ca: ldloca.s V_6
				L_03cc: ldc.i4.0 
				L_03cd: ldc.i4.0 
				L_03ce: ldloc.s V_4
				L_03d0: callvirt System.Drawing.Image::Int32 get_Width()
				L_03d5: ldloc.s V_4
				L_03d7: callvirt System.Drawing.Image::Int32 get_Height()
				L_03dc: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03e1: ldloc.s V_12
				L_03e3: ldloc.s V_4
				L_03e5: ldloc.s V_5
				L_03e7: ldloc.s V_6
				L_03e9: ldc.i4.2 
				L_03ea: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_03ef: leave.s L_03fd
				L_03f1: ldloc.s V_12
				L_03f3: brfalse.s L_03fc
				L_03f5: ldloc.s V_12
				L_03f7: callvirt System.IDisposable::Void Dispose()
				L_03fc: endfinally 
				L_03fd: ldloca.s V_6
				L_03ff: ldc.i4.0 
				L_0400: ldc.i4.0 
				L_0401: ldloc.s V_11
				L_0403: callvirt System.Drawing.Image::Int32 get_Width()
				L_0408: ldloc.2 
				L_0409: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_040e: ldloca.s V_5
				L_0410: ldc.i4.0 
				L_0411: ldc.i4.0 
				L_0412: ldloc.s V_9
				L_0414: ldloc.2 
				L_0415: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_041a: ldloc.s V_8
				L_041c: ldloc.s V_11
				L_041e: ldloc.s V_5
				L_0420: ldloc.s V_6
				L_0422: ldc.i4.2 
				L_0423: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0428: leave L_062a
				L_042d: ldloc.s V_11
				L_042f: brfalse.s L_0438
				L_0431: ldloc.s V_11
				L_0433: callvirt System.IDisposable::Void Dispose()
				L_0438: endfinally 
				L_0439: ldloc.s V_9
				L_043b: ldarg.0 
				L_043c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0441: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0446: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_044b: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_0450: callvirt System.Drawing.Image::Int32 get_Width()
				L_0455: ble L_0563
				L_045a: ldarg.0 
				L_045b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0460: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0465: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_046a: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_046f: stloc.s V_4
				L_0471: ldloca.s V_5
				L_0473: ldc.i4.0 
				L_0474: ldc.i4.0 
				L_0475: ldloc.s V_4
				L_0477: callvirt System.Drawing.Image::Int32 get_Width()
				L_047c: ldloc.2 
				L_047d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0482: ldloca.s V_6
				L_0484: ldc.i4.0 
				L_0485: ldc.i4.0 
				L_0486: ldloc.s V_4
				L_0488: callvirt System.Drawing.Image::Int32 get_Width()
				L_048d: ldloc.s V_4
				L_048f: callvirt System.Drawing.Image::Int32 get_Height()
				L_0494: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0499: ldloc.s V_8
				L_049b: ldloc.s V_4
				L_049d: ldloc.s V_5
				L_049f: ldloc.s V_6
				L_04a1: ldc.i4.2 
				L_04a2: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_04a7: ldloc.s V_4
				L_04a9: callvirt System.Drawing.Image::Int32 get_Width()
				L_04ae: stloc.s V_10
				L_04b0: ldarg.0 
				L_04b1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_04b6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_04bb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_04c0: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR2()
				L_04c5: stloc.s V_4
				L_04c7: ldloc.s V_9
				L_04c9: ldloc.s V_10
				L_04cb: ble.s L_051f
				L_04cd: ldloc.s V_10
				L_04cf: ldc.i4.0 
				L_04d0: ldloc.s V_9
				L_04d2: ldloc.2 
				L_04d3: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_04d8: stloc.s V_5
				L_04da: ldloca.s V_6
				L_04dc: ldc.i4.0 
				L_04dd: ldc.i4.0 
				L_04de: ldloc.s V_4
				L_04e0: callvirt System.Drawing.Image::Int32 get_Width()
				L_04e5: ldloc.s V_4
				L_04e7: callvirt System.Drawing.Image::Int32 get_Height()
				L_04ec: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04f1: ldloc.s V_8
				L_04f3: ldloc.s V_4
				L_04f5: ldloc.s V_5
				L_04f7: ldloca.s V_6
				L_04f9: call System.Drawing.Rectangle::Int32 get_X()
				L_04fe: ldloca.s V_6
				L_0500: call System.Drawing.Rectangle::Int32 get_Y()
				L_0505: ldloca.s V_6
				L_0507: call System.Drawing.Rectangle::Int32 get_Width()
				L_050c: ldloca.s V_6
				L_050e: call System.Drawing.Rectangle::Int32 get_Height()
				L_0513: ldc.i4.2 
				L_0514: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_0519: ldnull 
				L_051a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes, DrawImageAbort)
				L_051f: ldloc.s V_4
				L_0521: callvirt System.Drawing.Image::Int32 get_Height()
				L_0526: ldloc.2 
				L_0527: bge L_062a
				L_052c: ldarg.0 
				L_052d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0532: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0537: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_053c: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0541: stloc.s V_7
				L_0543: ldloc.s V_8
				L_0545: ldloc.s V_7
				L_0547: ldc.i4.0 
				L_0548: ldloc.s V_4
				L_054a: callvirt System.Drawing.Image::Int32 get_Height()
				L_054f: ldloc.1 
				L_0550: ldloc.2 
				L_0551: ldloc.s V_4
				L_0553: callvirt System.Drawing.Image::Int32 get_Height()
				L_0558: sub 
				L_0559: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_055e: br L_062a
				L_0563: ldloc.s V_9
				L_0565: ldc.i4.0 
				L_0566: ble L_062a
				L_056b: ldarg.0 
				L_056c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0571: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0576: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_057b: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_0580: callvirt System.Drawing.Image::Int32 get_Width()
				L_0585: ldloc.2 
				L_0586: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_058b: stloc.s V_13
				L_058d: ldloc.s V_13
				L_058f: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0594: stloc.s V_14
				L_0596: ldarg.0 
				L_0597: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_059c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_05a1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_05a6: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_05ab: stloc.s V_4
				L_05ad: ldloca.s V_5
				L_05af: ldc.i4.0 
				L_05b0: ldc.i4.0 
				L_05b1: ldloc.s V_4
				L_05b3: callvirt System.Drawing.Image::Int32 get_Width()
				L_05b8: ldloc.2 
				L_05b9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05be: ldloca.s V_6
				L_05c0: ldc.i4.0 
				L_05c1: ldc.i4.0 
				L_05c2: ldloc.s V_4
				L_05c4: callvirt System.Drawing.Image::Int32 get_Width()
				L_05c9: ldloc.s V_4
				L_05cb: callvirt System.Drawing.Image::Int32 get_Height()
				L_05d0: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05d5: ldloc.s V_14
				L_05d7: ldloc.s V_4
				L_05d9: ldloc.s V_5
				L_05db: ldloc.s V_6
				L_05dd: ldc.i4.2 
				L_05de: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_05e3: leave.s L_05f1
				L_05e5: ldloc.s V_14
				L_05e7: brfalse.s L_05f0
				L_05e9: ldloc.s V_14
				L_05eb: callvirt System.IDisposable::Void Dispose()
				L_05f0: endfinally 
				L_05f1: ldloca.s V_6
				L_05f3: ldc.i4.0 
				L_05f4: ldc.i4.0 
				L_05f5: ldloc.s V_13
				L_05f7: callvirt System.Drawing.Image::Int32 get_Width()
				L_05fc: ldloc.2 
				L_05fd: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0602: ldloca.s V_5
				L_0604: ldc.i4.0 
				L_0605: ldc.i4.0 
				L_0606: ldloc.s V_9
				L_0608: ldloc.2 
				L_0609: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_060e: ldloc.s V_8
				L_0610: ldloc.s V_13
				L_0612: ldloc.s V_5
				L_0614: ldloc.s V_6
				L_0616: ldc.i4.2 
				L_0617: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_061c: leave.s L_062a
				L_061e: ldloc.s V_13
				L_0620: brfalse.s L_0629
				L_0622: ldloc.s V_13
				L_0624: callvirt System.IDisposable::Void Dispose()
				L_0629: endfinally 
				L_062a: leave.s L_0638
				L_062c: ldloc.s V_8
				L_062e: brfalse.s L_0637
				L_0630: ldloc.s V_8
				L_0632: callvirt System.IDisposable::Void Dispose()
				L_0637: endfinally 
				L_0638: ldarg.0 
				L_0639: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_RightToLeftLayout()
				L_063e: brfalse.s L_064c
				L_0640: ldarg.0 
				L_0641: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0646: ldc.i4.4 
				L_0647: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_064c: ldarg.0 
				L_064d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0652: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0657: stloc.s V_15
				L_0659: ldarg.0 
				L_065a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_065f: brfalse L_0721
				L_0664: ldarg.0 
				L_0665: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Icon get_Icon()
				L_066a: brfalse L_0721
				L_066f: ldarg.0 
				L_0670: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0675: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_DrawFormIcon()
				L_067a: brfalse L_0721
				L_067f: ldarg.0 
				L_0680: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0685: brtrue.s L_068d
				L_0687: ldarg.0 
				L_0688: call Sunisoft.IrisSkin.xd24df615efe9450e::Void x271f237e4704798d()
				L_068d: ldarg.0 
				L_068e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0693: ldc.i4.3 
				L_0694: ldelema System.Drawing.Rectangle
				L_0699: ldobj System.Drawing.Rectangle
				L_069e: stloc.s V_5
				L_06a0: ldarg.0 
				L_06a1: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Icon get_Icon()
				L_06a6: callvirt System.Drawing.Icon::System.Drawing.Bitmap ToBitmap()
				L_06ab: dup 
				L_06ac: stloc.s V_4
				L_06ae: stloc.s V_17
				L_06b0: ldloc.s V_4
				L_06b2: callvirt System.Drawing.Image::Int32 get_Width()
				L_06b7: ldc.i4.s 16
				L_06b9: bne.un.s L_06c6
				L_06bb: ldloc.s V_4
				L_06bd: callvirt System.Drawing.Image::Int32 get_Height()
				L_06c2: ldc.i4.s 16
				L_06c4: beq.s L_0708
				L_06c6: ldloc.s V_4
				L_06c8: ldc.i4.s 16
				L_06ca: ldc.i4.s 16
				L_06cc: ldnull 
				L_06cd: ldsfld System.IntPtr::IntPtr Zero
				L_06d2: callvirt System.Drawing.Image::System.Drawing.Image GetThumbnailImage(Int32, Int32, GetThumbnailImageAbort, IntPtr)
				L_06d7: stloc.s V_16
				L_06d9: ldloc.s V_15
				L_06db: ldloc.s V_16
				L_06dd: ldloc.s V_5
				L_06df: ldc.i4.0 
				L_06e0: ldc.i4.0 
				L_06e1: ldloc.s V_16
				L_06e3: callvirt System.Drawing.Image::Int32 get_Width()
				L_06e8: ldloc.s V_16
				L_06ea: callvirt System.Drawing.Image::Int32 get_Height()
				L_06ef: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_06f4: ldc.i4.2 
				L_06f5: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_06fa: leave.s L_0713
				L_06fc: ldloc.s V_16
				L_06fe: brfalse.s L_0707
				L_0700: ldloc.s V_16
				L_0702: callvirt System.IDisposable::Void Dispose()
				L_0707: endfinally 
				L_0708: ldloc.s V_15
				L_070a: ldloc.s V_4
				L_070c: ldloc.s V_5
				L_070e: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, System.Drawing.Rectangle)
				L_0713: leave.s L_0721
				L_0715: ldloc.s V_17
				L_0717: brfalse.s L_0720
				L_0719: ldloc.s V_17
				L_071b: callvirt System.IDisposable::Void Dispose()
				L_0720: endfinally 
				L_0721: leave.s L_072f
				L_0723: ldloc.s V_15
				L_0725: brfalse.s L_072e
				L_0727: ldloc.s V_15
				L_0729: callvirt System.IDisposable::Void Dispose()
				L_072e: endfinally 
				L_072f: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Brush brush1;
				int i3;
				int i4;
				if (this.xf7b7e4e5afe45be7 != null)
				{
					this.xf7b7e4e5afe45be7.Dispose ();
				}
				bool b1 = ((SkinBools) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bools).SKIN2_TITLEFIVESECT;
				int i1 = this.Width;
				int i2 = this.TitleHeight;
				bool b2 = ((this.WindowState == FormWindowState.Minimized) && this.IsMdiChild);
				this.xf7b7e4e5afe45be7 = new Bitmap (i1, i2);
				using (Graphics graphics1 = Graphics.FromImage (((Image) this.xf7b7e4e5afe45be7)))
				{
					if (b2)
					{
						bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_MINIMIZEDTITLE;
						rectangle1 = new Rectangle (0, 0, i1, i2);
						rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
					}
					else
					{
						if (b1)
						{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR5;
						}
						else
						{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3;
						}
						i3 = (i1 - bitmap1.Width);
						rectangle1 = new Rectangle (i3, 0, bitmap1.Width, i2);
						rectangle2 = new Rectangle (0, 0, bitmap1.Width, i2);
						graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
						if (b1)
						{
							if (i3 > (((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1.Width + ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3.Width))
							{
								bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1;
								rectangle1 = new Rectangle (0, 0, bitmap1.Width, i2);
								rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
								graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
								i4 = bitmap1.Width;
								bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR2;
								rectangle1 = new Rectangle (i4, 0, this.x6b81454f45088f2e, i2);
								rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
								graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
								bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3;
								rectangle1 = new Rectangle (rectangle1.Right, 0, bitmap1.Width, i2);
								rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
								graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
								bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR4;
								rectangle1 = Rectangle.FromLTRB (rectangle1.Right, 0, i3, i2);
								rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
								if (rectangle1.Width > 0)
								{
									graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
								}
							}
							else if (i3 > 0)
							{
								using (Bitmap bitmap2 = new Bitmap (((int) (((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1.Width + ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3.Width)), i2))
								{
									using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap2)))
									{
										bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1;
										rectangle1 = new Rectangle (0, 0, bitmap1.Width, i2);
										rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
										graphics2.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
										i4 = bitmap1.Width;
										bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR3;
										rectangle1 = new Rectangle (rectangle1.Right, 0, bitmap1.Width, i2);
										rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
										graphics2.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
									}
									rectangle2 = new Rectangle (0, 0, bitmap2.Width, i2);
									rectangle1 = new Rectangle (0, 0, i3, i2);
									graphics1.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
									goto L_062A;
								}
							}
						}
						else if (i3 > ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1.Width)
						{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1;
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, i2);
							rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
							i4 = bitmap1.Width;
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR2;
							if (i3 > i4)
							{
								rectangle1 = Rectangle.FromLTRB (i4, 0, i3, i2);
								rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
								graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797, ((Graphics.DrawImageAbort) null));
							}
							if (bitmap1.Height < i2)
							{
								brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
								graphics1.FillRectangle (brush1, 0, bitmap1.Height, i1, ((int) (i2 - bitmap1.Height)));
							}
						}
						else if (i3 > 0)
						{
							using (Bitmap bitmap3 = new Bitmap (((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1.Width, i2))
							{
								using (Graphics graphics3 = Graphics.FromImage (((Image) bitmap3)))
								{
									bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TITLEBAR1;
									rectangle1 = new Rectangle (0, 0, bitmap1.Width, i2);
									rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
									graphics3.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
								}
								rectangle2 = new Rectangle (0, 0, bitmap3.Width, i2);
								rectangle1 = new Rectangle (0, 0, i3, i2);
								graphics1.DrawImage (((Image) bitmap3), rectangle1, rectangle2, GraphicsUnit.Pixel);
							}
						}
					}
					
				L_062A:
					
					{
					}
				}
				if (this.RightToLeftLayout)
				{
					this.xf7b7e4e5afe45be7.RotateFlip (RotateFlipType.RotateNoneFlipX);
				}
				using (Graphics graphics4 = Graphics.FromImage (((Image) this.xf7b7e4e5afe45be7)))
				{
					if ((this.ControlBox && (this.Icon != null)) && ((SkinEngine) this.xdc87e2b99332cd4a).DrawFormIcon)
					{
						if (this.x170170622f070c21 == null)
						{
							this.x271f237e4704798d ();
						}
						rectangle1 = this.x170170622f070c21[3];
						bitmap1 = this.Icon.ToBitmap ();
						using (Bitmap bitmap4 = bitmap1)
						{
							if ((bitmap1.Width != 16) || (bitmap1.Height != 16))
							{
								using (Image image1 = bitmap1.GetThumbnailImage (16, 16, ((Image.GetThumbnailImageAbort) null), IntPtr.Zero))
								{
									graphics4.DrawImage (image1, rectangle1, new Rectangle (0, 0, image1.Width, image1.Height), GraphicsUnit.Pixel);
									goto L_0713;
								}
							}
							graphics4.DrawImageUnscaled (((Image) bitmap1), rectangle1);
							
						L_0713:
							
							{
							}
						}
					}
				}
			}
			
			private void x5a3bdd19fa669e36 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoClose()
				L_0006: ret 
			*/
			
			
			{
				this.DoClose ();
			}
			
			private void x6616b01fd7cbc65d (int x30cc7819189f11b6)
			
			/*
				// Code Size: 857 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Bitmap V_4, 
         System.IntPtr V_5, 
         System.Drawing.Graphics V_6, 
         System.Int32 V_7)
				.try L_0248 to L_033e finally L_033e to L_034a
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_000f: brtrue.s L_0012
				L_0011: ret 
				L_0012: ldc.i4.m1 
				L_0013: stloc.1 
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xc8a0258498c6c151
				L_001a: stloc.s V_7
				L_001c: ldloc.s V_7
				L_001e: ldc.i4.8 
				L_001f: sub 
				L_0020: switch (L_00b5, L_0068)
				L_002d: ldloc.s V_7
				L_002f: ldc.i4.s 20
				L_0031: sub 
				L_0032: switch (L_0044, L_0103)
				L_003f: br L_0124
				L_0044: ldarg.1 
				L_0045: ldc.i4.s 20
				L_0047: bne.un.s L_005d
				L_0049: ldarg.0 
				L_004a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_004f: ldc.i4.s 20
				L_0051: bne.un.s L_0058
				L_0053: ldc.i4.s 18
				L_0055: stloc.0 
				L_0056: br.s L_0060
				L_0058: ldc.i4.s 17
				L_005a: stloc.0 
				L_005b: br.s L_0060
				L_005d: ldc.i4.s 16
				L_005f: stloc.0 
				L_0060: ldc.i4.s 20
				L_0062: stloc.1 
				L_0063: br L_01ee
				L_0068: ldarg.1 
				L_0069: ldc.i4.s 9
				L_006b: bne.un.s L_009d
				L_006d: ldarg.0 
				L_006e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_0073: ldc.i4.2 
				L_0074: bne.un.s L_008a
				L_0076: ldarg.0 
				L_0077: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_007c: ldc.i4.s 9
				L_007e: bne.un.s L_0085
				L_0080: ldc.i4.s 12
				L_0082: stloc.0 
				L_0083: br.s L_00ad
				L_0085: ldc.i4.s 11
				L_0087: stloc.0 
				L_0088: br.s L_00ad
				L_008a: ldarg.0 
				L_008b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_0090: ldc.i4.s 9
				L_0092: bne.un.s L_0099
				L_0094: ldc.i4.s 9
				L_0096: stloc.0 
				L_0097: br.s L_00ad
				L_0099: ldc.i4.8 
				L_009a: stloc.0 
				L_009b: br.s L_00ad
				L_009d: ldarg.0 
				L_009e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_00a3: ldc.i4.2 
				L_00a4: bne.un.s L_00ab
				L_00a6: ldc.i4.s 10
				L_00a8: stloc.0 
				L_00a9: br.s L_00ad
				L_00ab: ldc.i4.7 
				L_00ac: stloc.0 
				L_00ad: ldc.i4.s 9
				L_00af: stloc.1 
				L_00b0: br L_01ee
				L_00b5: ldarg.0 
				L_00b6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_00bb: ldc.i4.1 
				L_00bc: bne.un.s L_00e2
				L_00be: ldarg.0 
				L_00bf: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_00c4: brfalse.s L_00e2
				L_00c6: ldarg.1 
				L_00c7: ldc.i4.8 
				L_00c8: bne.un.s L_00dd
				L_00ca: ldarg.0 
				L_00cb: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_00d0: ldc.i4.8 
				L_00d1: bne.un.s L_00d8
				L_00d3: ldc.i4.s 12
				L_00d5: stloc.0 
				L_00d6: br.s L_00fc
				L_00d8: ldc.i4.s 11
				L_00da: stloc.0 
				L_00db: br.s L_00fc
				L_00dd: ldc.i4.s 10
				L_00df: stloc.0 
				L_00e0: br.s L_00fc
				L_00e2: ldarg.1 
				L_00e3: ldc.i4.8 
				L_00e4: bne.un.s L_00f9
				L_00e6: ldarg.0 
				L_00e7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_00ec: ldc.i4.8 
				L_00ed: bne.un.s L_00f4
				L_00ef: ldc.i4.s 15
				L_00f1: stloc.0 
				L_00f2: br.s L_00fc
				L_00f4: ldc.i4.s 14
				L_00f6: stloc.0 
				L_00f7: br.s L_00fc
				L_00f9: ldc.i4.s 13
				L_00fb: stloc.0 
				L_00fc: ldc.i4.8 
				L_00fd: stloc.1 
				L_00fe: br L_01ee
				L_0103: ldarg.1 
				L_0104: ldc.i4.s 21
				L_0106: bne.un.s L_011a
				L_0108: ldarg.0 
				L_0109: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_010e: ldc.i4.s 21
				L_0110: bne.un.s L_0116
				L_0112: ldc.i4.6 
				L_0113: stloc.0 
				L_0114: br.s L_011c
				L_0116: ldc.i4.5 
				L_0117: stloc.0 
				L_0118: br.s L_011c
				L_011a: ldc.i4.4 
				L_011b: stloc.0 
				L_011c: ldc.i4.s 21
				L_011e: stloc.1 
				L_011f: br L_01ee
				L_0124: ldarg.1 
				L_0125: stloc.s V_7
				L_0127: ldloc.s V_7
				L_0129: ldc.i4.8 
				L_012a: sub 
				L_012b: switch (L_019c, L_0169)
				L_0138: ldloc.s V_7
				L_013a: ldc.i4.s 20
				L_013c: sub 
				L_013d: switch (L_014f, L_01d5)
				L_014a: br L_01ea
				L_014f: ldarg.0 
				L_0150: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_0155: ldc.i4.s 20
				L_0157: bne.un.s L_015e
				L_0159: ldc.i4.s 18
				L_015b: stloc.0 
				L_015c: br.s L_0161
				L_015e: ldc.i4.s 17
				L_0160: stloc.0 
				L_0161: ldc.i4.s 20
				L_0163: stloc.1 
				L_0164: br L_01ee
				L_0169: ldarg.0 
				L_016a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_016f: ldc.i4.2 
				L_0170: bne.un.s L_0186
				L_0172: ldarg.0 
				L_0173: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_0178: ldc.i4.s 9
				L_017a: bne.un.s L_0181
				L_017c: ldc.i4.s 12
				L_017e: stloc.0 
				L_017f: br.s L_0197
				L_0181: ldc.i4.s 11
				L_0183: stloc.0 
				L_0184: br.s L_0197
				L_0186: ldarg.0 
				L_0187: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_018c: ldc.i4.s 9
				L_018e: bne.un.s L_0195
				L_0190: ldc.i4.s 9
				L_0192: stloc.0 
				L_0193: br.s L_0197
				L_0195: ldc.i4.8 
				L_0196: stloc.0 
				L_0197: ldc.i4.s 9
				L_0199: stloc.1 
				L_019a: br.s L_01ee
				L_019c: ldarg.0 
				L_019d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_01a2: ldc.i4.1 
				L_01a3: bne.un.s L_01c0
				L_01a5: ldarg.0 
				L_01a6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_01ab: brfalse.s L_01c0
				L_01ad: ldarg.0 
				L_01ae: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_01b3: ldc.i4.8 
				L_01b4: bne.un.s L_01bb
				L_01b6: ldc.i4.s 12
				L_01b8: stloc.0 
				L_01b9: br.s L_01d1
				L_01bb: ldc.i4.s 11
				L_01bd: stloc.0 
				L_01be: br.s L_01d1
				L_01c0: ldarg.0 
				L_01c1: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_01c6: ldc.i4.8 
				L_01c7: bne.un.s L_01ce
				L_01c9: ldc.i4.s 15
				L_01cb: stloc.0 
				L_01cc: br.s L_01d1
				L_01ce: ldc.i4.s 14
				L_01d0: stloc.0 
				L_01d1: ldc.i4.8 
				L_01d2: stloc.1 
				L_01d3: br.s L_01ee
				L_01d5: ldarg.0 
				L_01d6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9579bd00b393fc12
				L_01db: ldc.i4.s 21
				L_01dd: bne.un.s L_01e3
				L_01df: ldc.i4.6 
				L_01e0: stloc.0 
				L_01e1: br.s L_01e5
				L_01e3: ldc.i4.5 
				L_01e4: stloc.0 
				L_01e5: ldc.i4.s 21
				L_01e7: stloc.1 
				L_01e8: br.s L_01ee
				L_01ea: ldc.i4.1 
				L_01eb: stloc.0 
				L_01ec: ldc.i4.m1 
				L_01ed: stloc.1 
				L_01ee: ldloc.1 
				L_01ef: ldc.i4.m1 
				L_01f0: bne.un.s L_01f3
				L_01f2: ret 
				L_01f3: ldarg.0 
				L_01f4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01f9: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01fe: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0203: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_0208: ldloc.0 
				L_0209: ldelem.ref 
				L_020a: stloc.s V_4
				L_020c: ldloca.s V_3
				L_020e: ldc.i4.0 
				L_020f: ldc.i4.0 
				L_0210: ldloc.s V_4
				L_0212: callvirt System.Drawing.Image::Int32 get_Width()
				L_0217: ldloc.s V_4
				L_0219: callvirt System.Drawing.Image::Int32 get_Height()
				L_021e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0223: ldarg.0 
				L_0224: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0229: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_022e: stloc.s V_5
				L_0230: ldloc.s V_5
				L_0232: ldsfld System.IntPtr::IntPtr Zero
				L_0237: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_023c: brfalse.s L_023f
				L_023e: ret 
				L_023f: ldloc.s V_5
				L_0241: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0246: stloc.s V_6
				L_0248: ldloc.1 
				L_0249: stloc.s V_7
				L_024b: ldloc.s V_7
				L_024d: ldc.i4.8 
				L_024e: sub 
				L_024f: switch (L_02a8, L_02da)
				L_025c: ldloc.s V_7
				L_025e: ldc.i4.s 20
				L_0260: sub 
				L_0261: switch (L_030c, L_0273)
				L_026e: br L_033c
				L_0273: ldarg.0 
				L_0274: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0279: ldloc.1 
				L_027a: ldelema System.Drawing.Rectangle
				L_027f: ldobj System.Drawing.Rectangle
				L_0284: stloc.2 
				L_0285: ldloc.s V_6
				L_0287: ldarg.0 
				L_0288: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_028d: ldc.i4.0 
				L_028e: ldelem.ref 
				L_028f: ldloc.2 
				L_0290: ldloc.3 
				L_0291: ldc.i4.2 
				L_0292: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0297: ldloc.s V_6
				L_0299: ldloc.s V_4
				L_029b: ldloc.2 
				L_029c: ldloc.3 
				L_029d: ldc.i4.2 
				L_029e: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_02a3: br L_033c
				L_02a8: ldarg.0 
				L_02a9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02ae: ldloc.1 
				L_02af: ldelema System.Drawing.Rectangle
				L_02b4: ldobj System.Drawing.Rectangle
				L_02b9: stloc.2 
				L_02ba: ldloc.s V_6
				L_02bc: ldarg.0 
				L_02bd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_02c2: ldc.i4.1 
				L_02c3: ldelem.ref 
				L_02c4: ldloc.2 
				L_02c5: ldloc.3 
				L_02c6: ldc.i4.2 
				L_02c7: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_02cc: ldloc.s V_6
				L_02ce: ldloc.s V_4
				L_02d0: ldloc.2 
				L_02d1: ldloc.3 
				L_02d2: ldc.i4.2 
				L_02d3: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_02d8: br.s L_033c
				L_02da: ldarg.0 
				L_02db: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02e0: ldloc.1 
				L_02e1: ldelema System.Drawing.Rectangle
				L_02e6: ldobj System.Drawing.Rectangle
				L_02eb: stloc.2 
				L_02ec: ldloc.s V_6
				L_02ee: ldarg.0 
				L_02ef: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_02f4: ldc.i4.2 
				L_02f5: ldelem.ref 
				L_02f6: ldloc.2 
				L_02f7: ldloc.3 
				L_02f8: ldc.i4.2 
				L_02f9: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_02fe: ldloc.s V_6
				L_0300: ldloc.s V_4
				L_0302: ldloc.2 
				L_0303: ldloc.3 
				L_0304: ldc.i4.2 
				L_0305: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_030a: br.s L_033c
				L_030c: ldarg.0 
				L_030d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0312: ldloc.1 
				L_0313: ldelema System.Drawing.Rectangle
				L_0318: ldobj System.Drawing.Rectangle
				L_031d: stloc.2 
				L_031e: ldloc.s V_6
				L_0320: ldarg.0 
				L_0321: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0326: ldc.i4.3 
				L_0327: ldelem.ref 
				L_0328: ldloc.2 
				L_0329: ldloc.3 
				L_032a: ldc.i4.2 
				L_032b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0330: ldloc.s V_6
				L_0332: ldloc.s V_4
				L_0334: ldloc.2 
				L_0335: ldloc.3 
				L_0336: ldc.i4.2 
				L_0337: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_033c: leave.s L_034a
				L_033e: ldloc.s V_6
				L_0340: brfalse.s L_0349
				L_0342: ldloc.s V_6
				L_0344: callvirt System.IDisposable::Void Dispose()
				L_0349: endfinally 
				L_034a: ldarg.0 
				L_034b: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0350: ldloc.s V_5
				L_0352: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0357: pop 
				L_0358: ret 
			*/
			
			
			{
				int i1;
				int i2;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Bitmap bitmap1;
				IntPtr intPtr1;
				int i3;
				if ((this.x170170622f070c21 == null) || (! this.CanPaint))
				{
					return;
				}
				i3 = this.xc8a0258498c6c151;
				switch (i3)
				{
					case 8:
					
					{
							if ((this.WindowState != FormWindowState.Minimized) || (! this.IsMdiChild))
							{
								if (x30cc7819189f11b6 != 8)
								{
									i1 = 13;
									goto L_00FC;
								}
								if (this.x9579bd00b393fc12 != 8)
								{
									i1 = 14;
									goto L_00FC;
								}
								i1 = 15;
								goto L_00FC;
							}
							if (x30cc7819189f11b6 != 8)
							{
								i1 = 10;
								goto L_00FC;
							}
							if (this.x9579bd00b393fc12 != 8)
							{
								i1 = 11;
								goto L_00FC;
							}
							i1 = 12;
							goto L_00FC;
					}
					case 9:
					
					{
							if (x30cc7819189f11b6 != 9)
							{
								if (this.WindowState != FormWindowState.Maximized)
								{
									i1 = 7;
									goto L_00AD;
								}
								i1 = 10;
								goto L_00AD;
							}
							if (this.WindowState != FormWindowState.Maximized)
							{
								if (this.x9579bd00b393fc12 != 9)
								{
									i1 = 8;
									goto L_00AD;
								}
								i1 = 9;
								goto L_00AD;
							}
							if (this.x9579bd00b393fc12 != 9)
							{
								i1 = 11;
								goto L_00AD;
							}
							i1 = 12;
							goto L_00AD;
					}
					case 20:
					
					{
							if (x30cc7819189f11b6 != 20)
							{
								i1 = 16;
								goto L_0060;
							}
							if (this.x9579bd00b393fc12 != 20)
							{
								i1 = 17;
								goto L_0060;
							}
							i1 = 18;
							goto L_0060;
					}
					case 21:
					
					{
							if (x30cc7819189f11b6 != 21)
							{
								i1 = 4;
								goto L_011C;
							}
							if (this.x9579bd00b393fc12 != 21)
							{
								i1 = 5;
								goto L_011C;
							}
							i1 = 6;
							goto L_011C;
					}
				}
				i3 = x30cc7819189f11b6;
				switch (i3)
				{
					case 8:
					
					{
							if ((this.WindowState != FormWindowState.Minimized) || (! this.IsMdiChild))
							{
								if (this.x9579bd00b393fc12 != 8)
								{
									i1 = 14;
									goto L_01D1;
								}
								i1 = 15;
								goto L_01D1;
							}
							if (this.x9579bd00b393fc12 != 8)
							{
								i1 = 11;
								goto L_01D1;
							}
							i1 = 12;
							goto L_01D1;
					}
					case 9:
					
					{
							if (this.WindowState != FormWindowState.Maximized)
							{
								if (this.x9579bd00b393fc12 != 9)
								{
									i1 = 8;
									goto L_0197;
								}
								i1 = 9;
								goto L_0197;
							}
							if (this.x9579bd00b393fc12 != 9)
							{
								i1 = 11;
								goto L_0197;
							}
							i1 = 12;
							goto L_0197;
					}
					case 20:
					
					{
							if (this.x9579bd00b393fc12 != 20)
							{
								i1 = 17;
								goto L_0161;
							}
							i1 = 18;
							goto L_0161;
					}
					case 21:
					
					{
							if (this.x9579bd00b393fc12 != 21)
							{
								i1 = 5;
								goto L_01E5;
							}
							i1 = 6;
							goto L_01E5;
					}
				}
				i1 = 1;
				i2 = -1;
				goto L_01EE;
				
			L_0060:
				
				{
				}
				i2 = 20;
				goto L_01EE;
				
			L_00AD:
				
				{
				}
				i2 = 9;
				goto L_01EE;
				
			L_00FC:
				
				{
				}
				i2 = 8;
				goto L_01EE;
				
			L_011C:
				
				{
				}
				i2 = 21;
				goto L_01EE;
				
			L_0161:
				
				{
				}
				i2 = 20;
				goto L_01EE;
				
			L_0197:
				
				{
				}
				i2 = 9;
				goto L_01EE;
				
			L_01D1:
				
				{
				}
				i2 = 8;
				goto L_01EE;
				
			L_01E5:
				
				{
				}
				i2 = 21;
				
			L_01EE:
				
				{
				}
				if (i2 != -1)
				{
					bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[i1];
					rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
					intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
					if (intPtr1 != IntPtr.Zero)
					{
						using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
						{
							i3 = i2;
							switch (i3)
							{
								case 8:
								
								{
										rectangle1 = this.x170170622f070c21[i2];
										graphics1.DrawImage (((Image) this.xcacdadb77e32c6dd[1]), rectangle1, rectangle2, GraphicsUnit.Pixel);
										graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
										break;
								}
								case 9:
								
								{
										rectangle1 = this.x170170622f070c21[i2];
										graphics1.DrawImage (((Image) this.xcacdadb77e32c6dd[2]), rectangle1, rectangle2, GraphicsUnit.Pixel);
										graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
										break;
								}
								case 20:
								
								{
										rectangle1 = this.x170170622f070c21[i2];
										graphics1.DrawImage (((Image) this.xcacdadb77e32c6dd[3]), rectangle1, rectangle2, GraphicsUnit.Pixel);
										graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
										break;
								}
								case 21:
								
								{
										rectangle1 = this.x170170622f070c21[i2];
										graphics1.DrawImage (((Image) this.xcacdadb77e32c6dd[0]), rectangle1, rectangle2, GraphicsUnit.Pixel);
										graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
										break;
								}
							}
						}
						int i4 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
					}
				}
			}
			
			private void x814eab16f4e2a468 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoMin()
				L_0006: ret 
			*/
			
			
			{
				this.DoMin ();
			}
			
			private void x841c19853f4810d4 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void DoMax()
				L_0006: ret 
			*/
			
			
			{
				this.DoMax ();
			}
			
			private void x9d937faa8065bfbb ()
			
			/*
				// Code Size: 1134 Bytes
				.maxstack 10
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Font V_5, 
         System.Drawing.StringFormat V_6, 
         System.Drawing.Color V_7, 
         System.Drawing.Brush V_8, 
         System.Drawing.Bitmap V_9, 
         System.Drawing.Graphics V_10, 
         System.Drawing.Graphics V_11, 
         System.Drawing.Graphics V_12, 
         System.Drawing.Graphics V_13, 
         System.Drawing.Bitmap[] V_14, 
         System.Int32 V_15)
				.try L_0122 to L_01a1 finally L_01a1 to L_01ad
				.try L_0081 to L_01af finally L_01af to L_01bb
				.try L_0252 to L_0298 finally L_0298 to L_02a4
				.try L_02ed to L_0332 finally L_0332 to L_033e
				.try L_0389 to L_03cf finally L_03cf to L_03db
				.try L_041b to L_0461 finally L_0461 to L_046d
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_0006: brfalse.s L_001a
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_000e: callvirt System.Drawing.Image::Void Dispose()
				L_0013: ldarg.0 
				L_0014: ldnull 
				L_0015: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0020: brtrue.s L_0023
				L_0022: ret 
				L_0023: ldarg.0 
				L_0024: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0029: brtrue.s L_002c
				L_002b: ret 
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0032: callvirt System.Drawing.Image::Int32 get_Width()
				L_0037: stloc.0 
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_003e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0043: stloc.1 
				L_0044: ldarg.0 
				L_0045: ldloc.0 
				L_0046: ldloc.1 
				L_0047: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_004c: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_0051: ldarg.0 
				L_0052: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0057: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosY()
				L_005c: ldc.i4.m1 
				L_005d: bne.un.s L_0068
				L_005f: ldarg.0 
				L_0060: call Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x0c7b47d7852a0e99()
				L_0065: stloc.2 
				L_0066: br.s L_0074
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006e: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_FormCaptionPosY()
				L_0073: stloc.2 
				L_0074: ldarg.0 
				L_0075: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap x15810b502d9e43ee
				L_007a: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_007f: stloc.s V_4
				L_0081: ldloc.s V_4
				L_0083: ldarg.0 
				L_0084: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0089: ldc.i4.0 
				L_008a: ldc.i4.0 
				L_008b: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0096: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_009b: brtrue.s L_00a6
				L_009d: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font get_x0a05657cf1966ee7()
				L_00a2: stloc.s V_5
				L_00a4: br.s L_00b3
				L_00a6: ldarg.0 
				L_00a7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00ac: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_00b1: stloc.s V_5
				L_00b3: newobj System.Drawing.StringFormat::Void .ctor()
				L_00b8: stloc.s V_6
				L_00ba: ldloc.s V_6
				L_00bc: ldc.i4.0 
				L_00bd: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00c2: ldarg.0 
				L_00c3: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_00c8: ldc.i4.1 
				L_00c9: and 
				L_00ca: ldc.i4.1 
				L_00cb: bne.un.s L_00d7
				L_00cd: ldloc.s V_6
				L_00cf: ldc.i4.2 
				L_00d0: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00d5: br.s L_00df
				L_00d7: ldloc.s V_6
				L_00d9: ldc.i4.0 
				L_00da: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00df: ldarg.0 
				L_00e0: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsActive()
				L_00e5: brfalse.s L_0100
				L_00e7: ldarg.0 
				L_00e8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00ed: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00f2: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00f7: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TITLEFONTCOLOR
				L_00fc: stloc.s V_7
				L_00fe: br.s L_0109
				L_0100: ldc.i4.s 18
				L_0102: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_0107: stloc.s V_7
				L_0109: ldarg.0 
				L_010a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_010f: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_DrawFormCaption()
				L_0114: brfalse L_01ad
				L_0119: ldloc.s V_7
				L_011b: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0120: stloc.s V_8
				L_0122: ldarg.0 
				L_0123: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0128: ldc.i4.1 
				L_0129: and 
				L_012a: ldc.i4.1 
				L_012b: bne.un.s L_0168
				L_012d: ldloc.s V_4
				L_012f: ldarg.0 
				L_0130: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.String xa4b5d355cbf01a80
				L_0135: ldloc.s V_5
				L_0137: ldloc.s V_8
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_013f: ldarg.0 
				L_0140: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x6b81454f45088f2e
				L_0145: sub 
				L_0146: ldc.i4.4 
				L_0147: add 
				L_0148: ldloc.2 
				L_0149: ldarg.0 
				L_014a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_014f: ldarg.0 
				L_0150: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_0155: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_015a: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_015f: ldloc.s V_6
				L_0161: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0166: br.s L_019f
				L_0168: ldloc.s V_4
				L_016a: ldarg.0 
				L_016b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.String xa4b5d355cbf01a80
				L_0170: ldloc.s V_5
				L_0172: ldloc.s V_8
				L_0174: ldarg.0 
				L_0175: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_017a: ldloc.2 
				L_017b: ldarg.0 
				L_017c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x5a29066520654c5a
				L_0181: ldarg.0 
				L_0182: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x6b81454f45088f2e
				L_0187: add 
				L_0188: ldarg.0 
				L_0189: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_018e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0193: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0198: ldloc.s V_6
				L_019a: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_019f: leave.s L_01ad
				L_01a1: ldloc.s V_8
				L_01a3: brfalse.s L_01ac
				L_01a5: ldloc.s V_8
				L_01a7: callvirt System.IDisposable::Void Dispose()
				L_01ac: endfinally 
				L_01ad: leave.s L_01bb
				L_01af: ldloc.s V_4
				L_01b1: brfalse.s L_01ba
				L_01b3: ldloc.s V_4
				L_01b5: callvirt System.IDisposable::Void Dispose()
				L_01ba: endfinally 
				L_01bb: ldarg.0 
				L_01bc: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_01c1: brfalse L_046d
				L_01c6: ldarg.0 
				L_01c7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_01cc: brfalse.s L_01fb
				L_01ce: ldarg.0 
				L_01cf: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_01d4: stloc.s V_14
				L_01d6: ldc.i4.0 
				L_01d7: stloc.s V_15
				L_01d9: br.s L_01f3
				L_01db: ldloc.s V_14
				L_01dd: ldloc.s V_15
				L_01df: ldelem.ref 
				L_01e0: stloc.s V_9
				L_01e2: ldloc.s V_9
				L_01e4: brfalse.s L_01ed
				L_01e6: ldloc.s V_9
				L_01e8: callvirt System.Drawing.Image::Void Dispose()
				L_01ed: ldloc.s V_15
				L_01ef: ldc.i4.1 
				L_01f0: add 
				L_01f1: stloc.s V_15
				L_01f3: ldloc.s V_15
				L_01f5: ldloc.s V_14
				L_01f7: ldlen 
				L_01f8: conv.i4 
				L_01f9: blt.s L_01db
				L_01fb: ldarg.0 
				L_01fc: ldc.i4.4 
				L_01fd: newarr System.Drawing.Bitmap
				L_0202: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0207: ldarg.0 
				L_0208: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_020d: brfalse L_02a4
				L_0212: ldarg.0 
				L_0213: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0218: ldc.i4.0 
				L_0219: ldarg.0 
				L_021a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_021f: ldc.i4.s 21
				L_0221: ldelema System.Drawing.Rectangle
				L_0226: call System.Drawing.Rectangle::Int32 get_Width()
				L_022b: ldarg.0 
				L_022c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0231: ldc.i4.s 21
				L_0233: ldelema System.Drawing.Rectangle
				L_0238: call System.Drawing.Rectangle::Int32 get_Height()
				L_023d: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0242: stelem.ref 
				L_0243: ldarg.0 
				L_0244: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0249: ldc.i4.0 
				L_024a: ldelem.ref 
				L_024b: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0250: stloc.s V_10
				L_0252: ldloca.s V_3
				L_0254: ldc.i4.0 
				L_0255: ldc.i4.0 
				L_0256: ldarg.0 
				L_0257: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_025c: ldc.i4.0 
				L_025d: ldelem.ref 
				L_025e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0263: ldarg.0 
				L_0264: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0269: ldc.i4.0 
				L_026a: ldelem.ref 
				L_026b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0270: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0275: ldloc.s V_10
				L_0277: ldarg.0 
				L_0278: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_027d: ldloc.3 
				L_027e: ldarg.0 
				L_027f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0284: ldc.i4.s 21
				L_0286: ldelema System.Drawing.Rectangle
				L_028b: ldobj System.Drawing.Rectangle
				L_0290: ldc.i4.2 
				L_0291: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0296: leave.s L_02a4
				L_0298: ldloc.s V_10
				L_029a: brfalse.s L_02a3
				L_029c: ldloc.s V_10
				L_029e: callvirt System.IDisposable::Void Dispose()
				L_02a3: endfinally 
				L_02a4: ldarg.0 
				L_02a5: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_02aa: brfalse L_033e
				L_02af: ldarg.0 
				L_02b0: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_02b5: ldc.i4.1 
				L_02b6: ldarg.0 
				L_02b7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02bc: ldc.i4.8 
				L_02bd: ldelema System.Drawing.Rectangle
				L_02c2: call System.Drawing.Rectangle::Int32 get_Width()
				L_02c7: ldarg.0 
				L_02c8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_02cd: ldc.i4.8 
				L_02ce: ldelema System.Drawing.Rectangle
				L_02d3: call System.Drawing.Rectangle::Int32 get_Height()
				L_02d8: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_02dd: stelem.ref 
				L_02de: ldarg.0 
				L_02df: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_02e4: ldc.i4.1 
				L_02e5: ldelem.ref 
				L_02e6: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_02eb: stloc.s V_11
				L_02ed: ldloca.s V_3
				L_02ef: ldc.i4.0 
				L_02f0: ldc.i4.0 
				L_02f1: ldarg.0 
				L_02f2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_02f7: ldc.i4.1 
				L_02f8: ldelem.ref 
				L_02f9: callvirt System.Drawing.Image::Int32 get_Width()
				L_02fe: ldarg.0 
				L_02ff: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0304: ldc.i4.1 
				L_0305: ldelem.ref 
				L_0306: callvirt System.Drawing.Image::Int32 get_Height()
				L_030b: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0310: ldloc.s V_11
				L_0312: ldarg.0 
				L_0313: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0318: ldloc.3 
				L_0319: ldarg.0 
				L_031a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_031f: ldc.i4.8 
				L_0320: ldelema System.Drawing.Rectangle
				L_0325: ldobj System.Drawing.Rectangle
				L_032a: ldc.i4.2 
				L_032b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0330: leave.s L_033e
				L_0332: ldloc.s V_11
				L_0334: brfalse.s L_033d
				L_0336: ldloc.s V_11
				L_0338: callvirt System.IDisposable::Void Dispose()
				L_033d: endfinally 
				L_033e: ldarg.0 
				L_033f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0344: brfalse L_03db
				L_0349: ldarg.0 
				L_034a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_034f: ldc.i4.2 
				L_0350: ldarg.0 
				L_0351: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0356: ldc.i4.s 9
				L_0358: ldelema System.Drawing.Rectangle
				L_035d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0362: ldarg.0 
				L_0363: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0368: ldc.i4.s 9
				L_036a: ldelema System.Drawing.Rectangle
				L_036f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0374: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0379: stelem.ref 
				L_037a: ldarg.0 
				L_037b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0380: ldc.i4.2 
				L_0381: ldelem.ref 
				L_0382: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0387: stloc.s V_12
				L_0389: ldloca.s V_3
				L_038b: ldc.i4.0 
				L_038c: ldc.i4.0 
				L_038d: ldarg.0 
				L_038e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0393: ldc.i4.2 
				L_0394: ldelem.ref 
				L_0395: callvirt System.Drawing.Image::Int32 get_Width()
				L_039a: ldarg.0 
				L_039b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_03a0: ldc.i4.2 
				L_03a1: ldelem.ref 
				L_03a2: callvirt System.Drawing.Image::Int32 get_Height()
				L_03a7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03ac: ldloc.s V_12
				L_03ae: ldarg.0 
				L_03af: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_03b4: ldloc.3 
				L_03b5: ldarg.0 
				L_03b6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_03bb: ldc.i4.s 9
				L_03bd: ldelema System.Drawing.Rectangle
				L_03c2: ldobj System.Drawing.Rectangle
				L_03c7: ldc.i4.2 
				L_03c8: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_03cd: leave.s L_03db
				L_03cf: ldloc.s V_12
				L_03d1: brfalse.s L_03da
				L_03d3: ldloc.s V_12
				L_03d5: callvirt System.IDisposable::Void Dispose()
				L_03da: endfinally 
				L_03db: ldarg.0 
				L_03dc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_03e1: ldc.i4.3 
				L_03e2: ldarg.0 
				L_03e3: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_03e8: ldc.i4.s 20
				L_03ea: ldelema System.Drawing.Rectangle
				L_03ef: call System.Drawing.Rectangle::Int32 get_Width()
				L_03f4: ldarg.0 
				L_03f5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_03fa: ldc.i4.s 20
				L_03fc: ldelema System.Drawing.Rectangle
				L_0401: call System.Drawing.Rectangle::Int32 get_Height()
				L_0406: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_040b: stelem.ref 
				L_040c: ldarg.0 
				L_040d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0412: ldc.i4.3 
				L_0413: ldelem.ref 
				L_0414: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0419: stloc.s V_13
				L_041b: ldloca.s V_3
				L_041d: ldc.i4.0 
				L_041e: ldc.i4.0 
				L_041f: ldarg.0 
				L_0420: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0425: ldc.i4.3 
				L_0426: ldelem.ref 
				L_0427: callvirt System.Drawing.Image::Int32 get_Width()
				L_042c: ldarg.0 
				L_042d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap[] xcacdadb77e32c6dd
				L_0432: ldc.i4.3 
				L_0433: ldelem.ref 
				L_0434: callvirt System.Drawing.Image::Int32 get_Height()
				L_0439: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_043e: ldloc.s V_13
				L_0440: ldarg.0 
				L_0441: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Bitmap xf7b7e4e5afe45be7
				L_0446: ldloc.3 
				L_0447: ldarg.0 
				L_0448: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_044d: ldc.i4.s 20
				L_044f: ldelema System.Drawing.Rectangle
				L_0454: ldobj System.Drawing.Rectangle
				L_0459: ldc.i4.2 
				L_045a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_045f: leave.s L_046d
				L_0461: ldloc.s V_13
				L_0463: brfalse.s L_046c
				L_0465: ldloc.s V_13
				L_0467: callvirt System.IDisposable::Void Dispose()
				L_046c: endfinally 
				L_046d: ret 
			*/
			
			
			{
				int i3;
				Rectangle rectangle1;
				Font font1;
				StringFormat stringFormat1;
				Color color1;
				if (this.x15810b502d9e43ee != null)
				{
					this.x15810b502d9e43ee.Dispose ();
					this.x15810b502d9e43ee = ((Bitmap) null);
				}
				if ((this.xf7b7e4e5afe45be7 == null) || (this.x170170622f070c21 == null))
				{
					return;
				}
				int i1 = this.xf7b7e4e5afe45be7.Width;
				int i2 = this.xf7b7e4e5afe45be7.Height;
				this.x15810b502d9e43ee = new Bitmap (i1, i2);
				if (((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosY == -1)
				{
					i3 = this.x0c7b47d7852a0e99 ();
				}
				else
				{
					i3 = ((SkinEngine) this.xdc87e2b99332cd4a).FormCaptionPosY;
				}
				using (Graphics graphics1 = Graphics.FromImage (((Image) this.x15810b502d9e43ee)))
				{
					graphics1.DrawImageUnscaled (((Image) this.xf7b7e4e5afe45be7), 0, 0);
					if (((SkinEngine) this.xdc87e2b99332cd4a).TitleFont == null)
					{
						font1 = x448fd9ab43628c71.x0a05657cf1966ee7;
					}
					else
					{
						font1 = ((SkinEngine) this.xdc87e2b99332cd4a).TitleFont;
					}
					stringFormat1 = new StringFormat ();
					stringFormat1.LineAlignment = StringAlignment.Near;
					if ((this.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
					{
						stringFormat1.Alignment = StringAlignment.Far;
					}
					else
					{
						stringFormat1.Alignment = StringAlignment.Near;
					}
					if (this.IsActive)
					{
						color1 = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_TITLEFONTCOLOR;
					}
					else
					{
						color1 = Color.FromKnownColor (KnownColor.InactiveCaptionText);
					}
					if (((SkinEngine) this.xdc87e2b99332cd4a).DrawFormCaption)
					{
						using (Brush brush1 = ((Brush) new SolidBrush (color1)))
						{
							if ((this.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
							{
								graphics1.DrawString (this.xa4b5d355cbf01a80, font1, brush1, ((RectangleF) Rectangle.FromLTRB (((int) ((this.x5a29066520654c5a - this.x6b81454f45088f2e) + 4)), i3, this.x5a29066520654c5a, this.TitleHeight)), stringFormat1);
							}
							else
							{
								graphics1.DrawString (this.xa4b5d355cbf01a80, font1, brush1, ((RectangleF) Rectangle.FromLTRB (this.x5a29066520654c5a, i3, ((int) (this.x5a29066520654c5a + this.x6b81454f45088f2e)), this.TitleHeight)), stringFormat1);
							}
						}
					}
				}
				if (this.ControlBox)
				{
					if (this.xcacdadb77e32c6dd != null)
					{
						foreach (Bitmap bitmap1 in this.xcacdadb77e32c6dd)
						{
							if (bitmap1 != null)
							{
								bitmap1.Dispose ();
							}
						}
					}
					this.xcacdadb77e32c6dd = new Bitmap[4];
					if (this.HelpButton)
					{
						this.xcacdadb77e32c6dd[0] = new Bitmap (this.x170170622f070c21[21].Width, this.x170170622f070c21[21].Height);
						using (Graphics graphics2 = Graphics.FromImage (((Image) this.xcacdadb77e32c6dd[0])))
						{
							rectangle1 = new Rectangle (0, 0, this.xcacdadb77e32c6dd[0].Width, this.xcacdadb77e32c6dd[0].Height);
							graphics2.DrawImage (((Image) this.xf7b7e4e5afe45be7), rectangle1, this.x170170622f070c21[21], GraphicsUnit.Pixel);
						}
					}
					if (this.MinimizeBox)
					{
						this.xcacdadb77e32c6dd[1] = new Bitmap (this.x170170622f070c21[8].Width, this.x170170622f070c21[8].Height);
						using (Graphics graphics3 = Graphics.FromImage (((Image) this.xcacdadb77e32c6dd[1])))
						{
							rectangle1 = new Rectangle (0, 0, this.xcacdadb77e32c6dd[1].Width, this.xcacdadb77e32c6dd[1].Height);
							graphics3.DrawImage (((Image) this.xf7b7e4e5afe45be7), rectangle1, this.x170170622f070c21[8], GraphicsUnit.Pixel);
						}
					}
					if (this.MaximizeBox)
					{
						this.xcacdadb77e32c6dd[2] = new Bitmap (this.x170170622f070c21[9].Width, this.x170170622f070c21[9].Height);
						using (Graphics graphics4 = Graphics.FromImage (((Image) this.xcacdadb77e32c6dd[2])))
						{
							rectangle1 = new Rectangle (0, 0, this.xcacdadb77e32c6dd[2].Width, this.xcacdadb77e32c6dd[2].Height);
							graphics4.DrawImage (((Image) this.xf7b7e4e5afe45be7), rectangle1, this.x170170622f070c21[9], GraphicsUnit.Pixel);
						}
					}
					this.xcacdadb77e32c6dd[3] = new Bitmap (this.x170170622f070c21[20].Width, this.x170170622f070c21[20].Height);
					using (Graphics graphics5 = Graphics.FromImage (((Image) this.xcacdadb77e32c6dd[3])))
					{
						rectangle1 = new Rectangle (0, 0, this.xcacdadb77e32c6dd[3].Width, this.xcacdadb77e32c6dd[3].Height);
						graphics5.DrawImage (((Image) this.xf7b7e4e5afe45be7), rectangle1, this.x170170622f070c21[20], GraphicsUnit.Pixel);
					}
				}
			}
			
			protected void xd308f013f560f5be (Point x9c79b5ad7b769b12)
			
			/*
				// Code Size: 70 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_000b: ldc.i4.0 
				L_000c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_001c: ldarg.0 
				L_001d: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_0022: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0027: ldc.i4.1 
				L_0028: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_002d: ldarg.0 
				L_002e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0033: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Enabled(Boolean)
				L_0038: ldarg.0 
				L_0039: call Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 get_xd1faceba1dee38cf()
				L_003e: ldarg.1 
				L_003f: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x8fff3e0fa3d68bb2(System.Drawing.Point)
				L_0044: pop 
				L_0045: ret 
			*/
			
			
			{
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (0).Enabled = this.MinimizeBox;
				this.xd1faceba1dee38cf.x6ef5a4a9a9587cfd.get_xe6d4b1b411ed94b5 (1).Enabled = this.MaximizeBox;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = this.xd1faceba1dee38cf.x8fff3e0fa3d68bb2 (x9c79b5ad7b769b12);
			}
			
			private void xfecf8a78f99f2530 (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 337 Bytes
				.maxstack 9
				.locals (System.Int32 V_0, 
         System.Drawing.Bitmap V_1)
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_ControlBox()
				L_0006: brfalse L_0150
				L_000b: ldc.i4.s 16
				L_000d: stloc.0 
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0019: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_001e: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_0023: ldloc.0 
				L_0024: ldelem.ref 
				L_0025: stloc.1 
				L_0026: ldarg.1 
				L_0027: ldloc.1 
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_002e: ldc.i4.s 20
				L_0030: ldelema System.Drawing.Rectangle
				L_0035: ldobj System.Drawing.Rectangle
				L_003a: ldc.i4.0 
				L_003b: ldc.i4.0 
				L_003c: ldloc.1 
				L_003d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0042: ldloc.1 
				L_0043: callvirt System.Drawing.Image::Int32 get_Height()
				L_0048: ldc.i4.2 
				L_0049: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit)
				L_004e: ldarg.0 
				L_004f: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MaximizeBox()
				L_0054: brfalse.s L_00a6
				L_0056: ldarg.0 
				L_0057: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_005c: ldc.i4.2 
				L_005d: bne.un.s L_0064
				L_005f: ldc.i4.s 10
				L_0061: stloc.0 
				L_0062: br.s L_0066
				L_0064: ldc.i4.7 
				L_0065: stloc.0 
				L_0066: ldarg.0 
				L_0067: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0071: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0076: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_007b: ldloc.0 
				L_007c: ldelem.ref 
				L_007d: stloc.1 
				L_007e: ldarg.1 
				L_007f: ldloc.1 
				L_0080: ldarg.0 
				L_0081: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0086: ldc.i4.s 9
				L_0088: ldelema System.Drawing.Rectangle
				L_008d: ldobj System.Drawing.Rectangle
				L_0092: ldc.i4.0 
				L_0093: ldc.i4.0 
				L_0094: ldloc.1 
				L_0095: callvirt System.Drawing.Image::Int32 get_Width()
				L_009a: ldloc.1 
				L_009b: callvirt System.Drawing.Image::Int32 get_Height()
				L_00a0: ldc.i4.2 
				L_00a1: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit)
				L_00a6: ldarg.0 
				L_00a7: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_MinimizeBox()
				L_00ac: brfalse.s L_0106
				L_00ae: ldarg.0 
				L_00af: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
				L_00b4: ldc.i4.1 
				L_00b5: bne.un.s L_00c4
				L_00b7: ldarg.0 
				L_00b8: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
				L_00bd: brfalse.s L_00c4
				L_00bf: ldc.i4.s 10
				L_00c1: stloc.0 
				L_00c2: br.s L_00c7
				L_00c4: ldc.i4.s 13
				L_00c6: stloc.0 
				L_00c7: ldarg.0 
				L_00c8: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00cd: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00d2: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_00d7: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_00dc: ldloc.0 
				L_00dd: ldelem.ref 
				L_00de: stloc.1 
				L_00df: ldarg.1 
				L_00e0: ldloc.1 
				L_00e1: ldarg.0 
				L_00e2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_00e7: ldc.i4.8 
				L_00e8: ldelema System.Drawing.Rectangle
				L_00ed: ldobj System.Drawing.Rectangle
				L_00f2: ldc.i4.0 
				L_00f3: ldc.i4.0 
				L_00f4: ldloc.1 
				L_00f5: callvirt System.Drawing.Image::Int32 get_Width()
				L_00fa: ldloc.1 
				L_00fb: callvirt System.Drawing.Image::Int32 get_Height()
				L_0100: ldc.i4.2 
				L_0101: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit)
				L_0106: ldarg.0 
				L_0107: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_HelpButton()
				L_010c: brfalse.s L_0150
				L_010e: ldc.i4.4 
				L_010f: stloc.0 
				L_0110: ldarg.0 
				L_0111: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0116: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_011b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0120: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_TITLEBUTTONS()
				L_0125: ldloc.0 
				L_0126: ldelem.ref 
				L_0127: stloc.1 
				L_0128: ldarg.1 
				L_0129: ldloc.1 
				L_012a: ldarg.0 
				L_012b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle[] x170170622f070c21
				L_0130: ldc.i4.s 21
				L_0132: ldelema System.Drawing.Rectangle
				L_0137: ldobj System.Drawing.Rectangle
				L_013c: ldc.i4.0 
				L_013d: ldc.i4.0 
				L_013e: ldloc.1 
				L_013f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0144: ldloc.1 
				L_0145: callvirt System.Drawing.Image::Int32 get_Height()
				L_014a: ldc.i4.2 
				L_014b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit)
				L_0150: ret 
			*/
			
			
			{
				if (! this.ControlBox)
				{
					return;
				}
				int i1 = 16;
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[i1];
				x4b101060f4767186.DrawImage (((Image) bitmap1), this.x170170622f070c21[20], 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel);
				if (this.MaximizeBox)
				{
					if (this.WindowState == FormWindowState.Maximized)
					{
						i1 = 10;
					}
					else
					{
						i1 = 7;
					}
					bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[i1];
					x4b101060f4767186.DrawImage (((Image) bitmap1), this.x170170622f070c21[9], 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel);
				}
				if (this.MinimizeBox)
				{
					if ((this.WindowState == FormWindowState.Minimized) && this.IsMdiChild)
					{
						i1 = 10;
					}
					else
					{
						i1 = 13;
					}
					bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[i1];
					x4b101060f4767186.DrawImage (((Image) bitmap1), this.x170170622f070c21[8], 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel);
				}
				if (this.HelpButton)
				{
					i1 = 4;
					bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_TITLEBUTTONS[i1];
					x4b101060f4767186.DrawImage (((Image) bitmap1), this.x170170622f070c21[21], 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel);
				}
			}
			
		#endregion
	}
	
}

