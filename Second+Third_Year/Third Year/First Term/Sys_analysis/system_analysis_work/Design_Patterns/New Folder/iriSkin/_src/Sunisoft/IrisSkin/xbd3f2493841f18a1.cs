//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Collections;
			using System.Drawing;
			using System;
			using System.Windows.Forms;
			using System.Windows.Forms.Layout;
			
			
		#endregion
		
	internal class xbd3f2493841f18a1 : NativeWindow, IDisposable
	
	{
		
		#region Fields
			protected Color x154083d58301ef75;
			protected Hashtable x1cb3eacdc401d7a9;
			private bool x230e512478b11e00;
			protected Color x8ef2762e422f7380;
			public xa1883d0b59b7005b x902c4aee45bfd906;
			protected Control xcd9cdf30888d2204;
			protected ISkinEngine xdc87e2b99332cd4a;
			protected xb9506a535e31f22a xdd938462da9aed37;
		#endregion
		
		#region Constructors
		
			public xbd3f2493841f18a1 (Control control, ISkinEngine engine)
			/*
				// Code Size: 58 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: ldc.i4.1 
				L_0009: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean x230e512478b11e00
				L_000e: ldarg.0 
				L_000f: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_0014: ldarg.0 
				L_0015: newobj System.Collections.Hashtable::Void .ctor()
				L_001a: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_001f: ldarg.0 
				L_0020: ldarg.1 
				L_0021: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0026: ldarg.0 
				L_0027: ldarg.2 
				L_0028: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002d: ldarg.0 
				L_002e: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void DoInit()
				L_0033: ldarg.0 
				L_0034: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x172fd1e80a81620d()
				L_0039: ret 
			*/
		#endregion
		
		#region Properties
		
			protected virtual bool ChangeBackColor
			
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
			
			
			protected virtual bool ChangeFontColor
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.0 
					L_0001: ret 
				*/
				
				{
					return false;
				}
			}
			
			
			protected bool xf2140268ef7ddbf7
			
			{
				get
				
				/*
					// Code Size: 158 Bytes
					.maxstack 4
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean x230e512478b11e00
					L_0006: brtrue.s L_000a
					L_0008: ldc.i4.0 
					L_0009: ret 
					L_000a: ldarg.0 
					L_000b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0010: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
					L_0015: brfalse.s L_0019
					L_0017: ldc.i4.0 
					L_0018: ret 
					L_0019: ldarg.0 
					L_001a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_001f: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_0024: brtrue.s L_0028
					L_0026: ldc.i4.0 
					L_0027: ret 
					L_0028: ldarg.0 
					L_0029: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_002e: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0033: isinst System.Int32
					L_0038: brfalse.s L_005c
					L_003a: ldarg.0 
					L_003b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0040: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0045: unbox System.Int32
					L_004a: ldind.i4 
					L_004b: ldarg.0 
					L_004c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0051: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0056: bne.un.s L_005a
					L_0058: ldc.i4.0 
					L_0059: ret 
					L_005a: ldc.i4.1 
					L_005b: ret 
					L_005c: ldarg.0 
					L_005d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0062: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0067: isinst System.String
					L_006c: brfalse.s L_009c
					L_006e: ldarg.0 
					L_006f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0074: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0079: castclass System.String
					L_007e: ldarg.0 
					L_007f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0084: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0089: stloc.0 
					L_008a: ldloca.s V_0
					L_008c: call System.Int32::System.String ToString()
					L_0091: call System.String::Boolean op_Equality(System.String, System.String)
					L_0096: brfalse.s L_009a
					L_0098: ldc.i4.0 
					L_0099: ret 
					L_009a: ldc.i4.1 
					L_009b: ret 
					L_009c: ldc.i4.1 
					L_009d: ret 
				*/
				
				{
					if (! this.x230e512478b11e00)
					{
						return false;
					}
					if (this.xcd9cdf30888d2204.IsDisposed)
					{
						return false;
					}
					if (! ((SkinEngine) this.xdc87e2b99332cd4a).RealActive)
					{
						return false;
					}
					if (this.xcd9cdf30888d2204.Tag is int)
					{
						if (((int) this.xcd9cdf30888d2204.Tag) != ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
					if (! (this.xcd9cdf30888d2204.Tag is string))
					{
						return true;
					}
					int i1 = ((SkinEngine) this.xdc87e2b99332cd4a).DisableTag;
					if (((string) this.xcd9cdf30888d2204.Tag) != i1.ToString ())
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
		
			public virtual void Dispose ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void DoInit ()
			
			/*
				// Code Size: 502 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0011: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0016: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_001b: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0020: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0025: brfalse.s L_0038
				L_0027: ldarg.0 
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_002e: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0033: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Drawing.Color x154083d58301ef75
				L_0038: ldarg.0 
				L_0039: ldarg.0 
				L_003a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003f: callvirt System.Windows.Forms.Control::System.Drawing.Color get_ForeColor()
				L_0044: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Drawing.Color x8ef2762e422f7380
				L_0049: ldarg.0 
				L_004a: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_004f: brfalse.s L_00a1
				L_0051: ldarg.0 
				L_0052: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeBackColor()
				L_0057: brfalse.s L_0079
				L_0059: ldarg.0 
				L_005a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_005f: ldarg.0 
				L_0060: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0065: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_006a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_006f: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0074: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0079: ldarg.0 
				L_007a: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeFontColor()
				L_007f: brfalse.s L_00a1
				L_0081: ldarg.0 
				L_0082: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0087: ldarg.0 
				L_0088: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_008d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0092: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0097: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLFONTCOLOR
				L_009c: callvirt System.Windows.Forms.Control::Void set_ForeColor(System.Drawing.Color)
				L_00a1: ldarg.0 
				L_00a2: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a7: ldarg.0 
				L_00a8: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x8c06ad1b432b98eb(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_00ae: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_00b3: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_00b8: ldarg.0 
				L_00b9: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00be: ldarg.0 
				L_00bf: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x32475e142481d30b(System.Object, System.Windows.Forms.PaintEventArgs)
				L_00c5: newobj System.Windows.Forms.PaintEventHandler::Void .ctor(System.Object, IntPtr)
				L_00ca: callvirt System.Windows.Forms.Control::Void add_Paint(System.Windows.Forms.PaintEventHandler)
				L_00cf: ldarg.0 
				L_00d0: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00d5: ldarg.0 
				L_00d6: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x1f31d31f0e09c076(System.Object, System.EventArgs)
				L_00dc: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_00e1: callvirt System.Windows.Forms.Control::Void add_BackgroundImageChanged(System.EventHandler)
				L_00e6: ldarg.0 
				L_00e7: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00ec: ldarg.0 
				L_00ed: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x02b398f1260ef2d9(System.Object, System.EventArgs)
				L_00f3: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_00f8: callvirt System.Windows.Forms.Control::Void add_EnabledChanged(System.EventHandler)
				L_00fd: ldarg.0 
				L_00fe: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0103: ldarg.0 
				L_0104: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x238e719e4d456cb9(System.Object, System.EventArgs)
				L_010a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_010f: callvirt System.Windows.Forms.Control::Void add_TextChanged(System.EventHandler)
				L_0114: ldarg.0 
				L_0115: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_011a: ldarg.0 
				L_011b: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x5aa038edd784e0a2(System.Object, System.EventArgs)
				L_0121: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0126: callvirt System.Windows.Forms.Control::Void add_MouseEnter(System.EventHandler)
				L_012b: ldarg.0 
				L_012c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0131: ldarg.0 
				L_0132: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x42271d490e21550a(System.Object, System.EventArgs)
				L_0138: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_013d: callvirt System.Windows.Forms.Control::Void add_MouseLeave(System.EventHandler)
				L_0142: ldarg.0 
				L_0143: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0148: ldarg.0 
				L_0149: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xa5ecc87221b6cc18(System.Object, System.Windows.Forms.MouseEventArgs)
				L_014f: newobj System.Windows.Forms.MouseEventHandler::Void .ctor(System.Object, IntPtr)
				L_0154: callvirt System.Windows.Forms.Control::Void add_MouseUp(System.Windows.Forms.MouseEventHandler)
				L_0159: ldarg.0 
				L_015a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_015f: ldarg.0 
				L_0160: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xd82fdb580ad5d9c2(System.Object, System.Windows.Forms.MouseEventArgs)
				L_0166: newobj System.Windows.Forms.MouseEventHandler::Void .ctor(System.Object, IntPtr)
				L_016b: callvirt System.Windows.Forms.Control::Void add_MouseDown(System.Windows.Forms.MouseEventHandler)
				L_0170: ldarg.0 
				L_0171: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0176: ldarg.0 
				L_0177: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xbca0e60879f588a1(System.Object, System.Windows.Forms.KeyEventArgs)
				L_017d: newobj System.Windows.Forms.KeyEventHandler::Void .ctor(System.Object, IntPtr)
				L_0182: callvirt System.Windows.Forms.Control::Void add_KeyDown(System.Windows.Forms.KeyEventHandler)
				L_0187: ldarg.0 
				L_0188: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_018d: ldarg.0 
				L_018e: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x3d2022a4b24873fe(System.Object, System.Windows.Forms.KeyEventArgs)
				L_0194: newobj System.Windows.Forms.KeyEventHandler::Void .ctor(System.Object, IntPtr)
				L_0199: callvirt System.Windows.Forms.Control::Void add_KeyUp(System.Windows.Forms.KeyEventHandler)
				L_019e: ldarg.0 
				L_019f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01a4: ldarg.0 
				L_01a5: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x2bf160cd2bad82a5(System.Object, System.EventArgs)
				L_01ab: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_01b0: callvirt System.Windows.Forms.Control::Void add_GotFocus(System.EventHandler)
				L_01b5: ldarg.0 
				L_01b6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01bb: ldarg.0 
				L_01bc: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xcd7553179bfc3f6c(System.Object, System.EventArgs)
				L_01c2: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_01c7: callvirt System.Windows.Forms.Control::Void add_BackColorChanged(System.EventHandler)
				L_01cc: ldarg.0 
				L_01cd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01d2: callvirt System.Windows.Forms.Control::System.Windows.Forms.ContextMenu get_ContextMenu()
				L_01d7: brfalse.s L_01f5
				L_01d9: ldarg.0 
				L_01da: ldarg.0 
				L_01db: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01e0: ldarg.0 
				L_01e1: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01e6: callvirt System.Windows.Forms.Control::System.Windows.Forms.ContextMenu get_ContextMenu()
				L_01eb: newobj Sunisoft.IrisSkin.xa1883d0b59b7005b::Void .ctor(Sunisoft.IrisSkin.SkinEngine, System.Windows.Forms.Menu)
				L_01f0: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xa1883d0b59b7005b x902c4aee45bfd906
				L_01f5: ret 
			*/
			
			
			{
				if (this.xcd9cdf30888d2204.BackColor != ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_FORMCOLOR)
				{
					this.x154083d58301ef75 = this.xcd9cdf30888d2204.BackColor;
				}
				this.x8ef2762e422f7380 = this.xcd9cdf30888d2204.ForeColor;
				if (this.xf2140268ef7ddbf7)
				{
					if (this.ChangeBackColor)
					{
						this.xcd9cdf30888d2204.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_FORMCOLOR;
					}
					if (this.ChangeFontColor)
					{
						this.xcd9cdf30888d2204.ForeColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_CONTROLFONTCOLOR;
					}
				}
				((SkinEngine) this.xdc87e2b99332cd4a).CurrentSkinChanged += new SkinChanged (this.x8c06ad1b432b98eb);
				this.xcd9cdf30888d2204.Paint += new PaintEventHandler (this.x32475e142481d30b);
				this.xcd9cdf30888d2204.BackgroundImageChanged += new EventHandler (this.x1f31d31f0e09c076);
				this.xcd9cdf30888d2204.EnabledChanged += new EventHandler (this.x02b398f1260ef2d9);
				this.xcd9cdf30888d2204.TextChanged += new EventHandler (this.x238e719e4d456cb9);
				this.xcd9cdf30888d2204.MouseEnter += new EventHandler (this.x5aa038edd784e0a2);
				this.xcd9cdf30888d2204.MouseLeave += new EventHandler (this.x42271d490e21550a);
				this.xcd9cdf30888d2204.MouseUp += new MouseEventHandler (this.xa5ecc87221b6cc18);
				this.xcd9cdf30888d2204.MouseDown += new MouseEventHandler (this.xd82fdb580ad5d9c2);
				this.xcd9cdf30888d2204.KeyDown += new KeyEventHandler (this.xbca0e60879f588a1);
				this.xcd9cdf30888d2204.KeyUp += new KeyEventHandler (this.x3d2022a4b24873fe);
				this.xcd9cdf30888d2204.GotFocus += new EventHandler (this.x2bf160cd2bad82a5);
				this.xcd9cdf30888d2204.BackColorChanged += new EventHandler (this.xcd7553179bfc3f6c);
				if (this.xcd9cdf30888d2204.ContextMenu != null)
				{
					this.x902c4aee45bfd906 = new xa1883d0b59b7005b (this.xdc87e2b99332cd4a, ((Menu) this.xcd9cdf30888d2204.ContextMenu));
				}
			}
			
			protected virtual void DoUnInit ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 171 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_0060
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xb1ee1b6293236c5f()
				L_000e: ldarg.0 
				L_000f: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeBackColor()
				L_0014: brfalse.s L_0036
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0027: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_002c: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0031: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0036: ldarg.0 
				L_0037: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeFontColor()
				L_003c: brfalse.s L_009f
				L_003e: ldarg.0 
				L_003f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0044: ldarg.0 
				L_0045: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0054: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLFONTCOLOR
				L_0059: callvirt System.Windows.Forms.Control::Void set_ForeColor(System.Drawing.Color)
				L_005e: br.s L_009f
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0066: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_006b: brtrue.s L_009f
				L_006d: ldarg.0 
				L_006e: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeBackColor()
				L_0073: brfalse.s L_0086
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_007b: ldarg.0 
				L_007c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Drawing.Color x154083d58301ef75
				L_0081: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0086: ldarg.0 
				L_0087: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_ChangeFontColor()
				L_008c: brfalse.s L_009f
				L_008e: ldarg.0 
				L_008f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0094: ldarg.0 
				L_0095: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Drawing.Color x8ef2762e422f7380
				L_009a: callvirt System.Windows.Forms.Control::Void set_ForeColor(System.Drawing.Color)
				L_009f: ldarg.0 
				L_00a0: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00a5: callvirt System.Windows.Forms.Control::Void Refresh()
				L_00aa: ret 
			*/
			
			
			{
				if (this.xf2140268ef7ddbf7)
				{
					this.xb1ee1b6293236c5f ();
					if (this.ChangeBackColor)
					{
						this.xcd9cdf30888d2204.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_FORMCOLOR;
					}
					if (this.ChangeFontColor)
					{
						this.xcd9cdf30888d2204.ForeColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_CONTROLFONTCOLOR;
					}
				}
				else if (! this.xcd9cdf30888d2204.IsDisposed)
				{
					if (this.ChangeBackColor)
					{
						this.xcd9cdf30888d2204.BackColor = this.x154083d58301ef75;
					}
					if (this.ChangeFontColor)
					{
						this.xcd9cdf30888d2204.ForeColor = this.x8ef2762e422f7380;
					}
				}
				this.xcd9cdf30888d2204.Refresh ();
			}
			
			protected virtual void PaintControl ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			private void x02b398f1260ef2d9 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x172fd1e80a81620d ()
			
			/*
				// Code Size: 276 Bytes
				.maxstack 5
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_0051 to L_008b finally L_008b to L_00a0
				.try L_00a8 to L_00fe finally L_00fe to L_0113
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: ldarg.0 
				L_0007: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xd34eabd7bd15b71a(System.Object, System.Windows.Forms.ControlEventArgs)
				L_000d: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_0012: callvirt System.Windows.Forms.Control::Void add_ControlAdded(System.Windows.Forms.ControlEventHandler)
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: ldarg.0 
				L_001e: ldftn Sunisoft.IrisSkin.xbd3f2493841f18a1::Void xf8f5e344dcfab3e8(System.Object, System.Windows.Forms.ControlEventArgs)
				L_0024: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_0029: callvirt System.Windows.Forms.Control::Void add_ControlRemoved(System.Windows.Forms.ControlEventHandler)
				L_002e: ldarg.0 
				L_002f: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0034: brfalse L_0113
				L_0039: newobj System.Collections.ArrayList::Void .ctor()
				L_003e: stloc.0 
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0045: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_004a: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_004f: stloc.s V_4
				L_0051: br.s L_0080
				L_0053: ldloc.s V_4
				L_0055: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_005a: castclass System.Windows.Forms.Control
				L_005f: stloc.1 
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_0066: ldloc.1 
				L_0067: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_006c: box System.IntPtr
				L_0071: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0076: brtrue.s L_0080
				L_0078: ldloc.0 
				L_0079: ldloc.1 
				L_007a: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_007f: pop 
				L_0080: ldloc.s V_4
				L_0082: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0087: brtrue.s L_0053
				L_0089: leave.s L_00a0
				L_008b: ldloc.s V_4
				L_008d: isinst System.IDisposable
				L_0092: stloc.s V_5
				L_0094: ldloc.s V_5
				L_0096: brfalse.s L_009f
				L_0098: ldloc.s V_5
				L_009a: callvirt System.IDisposable::Void Dispose()
				L_009f: endfinally 
				L_00a0: ldloc.0 
				L_00a1: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_00a6: stloc.s V_4
				L_00a8: br.s L_00f3
				L_00aa: ldloc.s V_4
				L_00ac: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00b1: castclass System.Windows.Forms.Control
				L_00b6: stloc.2 
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_00bd: ldloc.2 
				L_00be: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00c3: box System.IntPtr
				L_00c8: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_00cd: brtrue.s L_00f3
				L_00cf: ldloc.2 
				L_00d0: ldarg.0 
				L_00d1: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00d6: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00db: stloc.3 
				L_00dc: ldarg.0 
				L_00dd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_00e2: ldloc.2 
				L_00e3: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00e8: box System.IntPtr
				L_00ed: ldloc.3 
				L_00ee: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_00f3: ldloc.s V_4
				L_00f5: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00fa: brtrue.s L_00aa
				L_00fc: leave.s L_0113
				L_00fe: ldloc.s V_4
				L_0100: isinst System.IDisposable
				L_0105: stloc.s V_5
				L_0107: ldloc.s V_5
				L_0109: brfalse.s L_0112
				L_010b: ldloc.s V_5
				L_010d: callvirt System.IDisposable::Void Dispose()
				L_0112: endfinally 
				L_0113: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				this.xcd9cdf30888d2204.ControlAdded += new ControlEventHandler (this.xd34eabd7bd15b71a);
				this.xcd9cdf30888d2204.ControlRemoved += new ControlEventHandler (this.xf8f5e344dcfab3e8);
				if (! this.xf2140268ef7ddbf7)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in this.xcd9cdf30888d2204.Controls)
				{
					if (! this.x1cb3eacdc401d7a9.ContainsKey (control1.Handle))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! this.x1cb3eacdc401d7a9.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, this.xdc87e2b99332cd4a);
						this.x1cb3eacdc401d7a9.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			private void x1f31d31f0e09c076 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x238e719e4d456cb9 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x2bf160cd2bad82a5 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x32475e142481d30b (object xe0292b9ed559da7d, PaintEventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x3d2022a4b24873fe (object xe0292b9ed559da7d, KeyEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 42 Bytes
				.maxstack 9
				L_0000: ldarg.2 
				L_0001: callvirt System.Windows.Forms.KeyEventArgs::System.Windows.Forms.Keys get_KeyCode()
				L_0006: ldc.i4.s 32
				L_0008: beq.s L_0014
				L_000a: ldarg.2 
				L_000b: callvirt System.Windows.Forms.KeyEventArgs::System.Windows.Forms.Keys get_KeyCode()
				L_0010: ldc.i4.s 13
				L_0012: bne.un.s L_0029
				L_0014: ldarg.0 
				L_0015: ldc.i4.1 
				L_0016: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_001b: ldarg.0 
				L_001c: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0021: brfalse.s L_0029
				L_0023: ldarg.0 
				L_0024: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0029: ret 
			*/
			
			
			{
				if ((xfbf34718e704c6bc.KeyCode == Keys.Space) || (xfbf34718e704c6bc.KeyCode == Keys.Enter))
				{
					this.xdd938462da9aed37 = xb9506a535e31f22a.x4d0b9d4447ba7566;
					if (this.xf2140268ef7ddbf7)
					{
						this.PaintControl ();
					}
				}
			}
			
			private void x42271d490e21550a (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000d: brfalse.s L_0015
				L_000f: ldarg.0 
				L_0010: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0015: ret 
			*/
			
			
			{
				this.xdd938462da9aed37 = xb9506a535e31f22a.x4d0b9d4447ba7566;
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			internal void x52b190e626f65140 ()
			
			/*
				// Code Size: 95 Bytes
				.maxstack 5
				.locals (System.Object V_0, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0011 to L_0039 finally L_0039 to L_004a
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_0006: callvirt System.Collections.Hashtable::System.Collections.ICollection get_Values()
				L_000b: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_0010: stloc.2 
				L_0011: br.s L_002f
				L_0013: ldloc.2 
				L_0014: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0019: stloc.0 
				L_001a: ldloc.0 
				L_001b: isinst Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_0020: brfalse.s L_002f
				L_0022: ldloc.0 
				L_0023: castclass Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_0028: stloc.1 
				L_0029: ldloc.1 
				L_002a: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x52b190e626f65140()
				L_002f: ldloc.2 
				L_0030: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0035: brtrue.s L_0013
				L_0037: leave.s L_004a
				L_0039: ldloc.2 
				L_003a: isinst System.IDisposable
				L_003f: stloc.3 
				L_0040: ldloc.3 
				L_0041: brfalse.s L_0049
				L_0043: ldloc.3 
				L_0044: callvirt System.IDisposable::Void Dispose()
				L_0049: endfinally 
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean x230e512478b11e00
				L_0051: ldarg.0 
				L_0052: ldnull 
				L_0053: ldc.i4.0 
				L_0054: newobj Sunisoft.IrisSkin.SkinChangedEventArgs::Void .ctor(Boolean)
				L_0059: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_005e: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				foreach (object object1 in this.x1cb3eacdc401d7a9.Values)
				{
					if (object1 is xbd3f2493841f18a1)
					{
						xbd3f2493841f18a1_1 = ((xbd3f2493841f18a1) object1);
						xbd3f2493841f18a1_1.x52b190e626f65140 ();
					}
				}
				this.x230e512478b11e00 = false;
				this.OnCurrentSkinChanged (null, new SkinChangedEventArgs (false));
			}
			
			private void x5aa038edd784e0a2 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.2 
				L_0002: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000d: brfalse.s L_0015
				L_000f: ldarg.0 
				L_0010: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0015: ret 
			*/
			
			
			{
				this.xdd938462da9aed37 = xb9506a535e31f22a.x38f64d20b794f1fc;
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void x8c06ad1b432b98eb (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ret 
			*/
			
			
			{
				this.OnCurrentSkinChanged (xe0292b9ed559da7d, xfbf34718e704c6bc);
			}
			
			private void xa5ecc87221b6cc18 (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.2 
				L_0002: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000d: brfalse.s L_0015
				L_000f: ldarg.0 
				L_0010: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0015: ret 
			*/
			
			
			{
				this.xdd938462da9aed37 = xb9506a535e31f22a.x38f64d20b794f1fc;
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void xb1ee1b6293236c5f ()
			
			/*
				// Code Size: 230 Bytes
				.maxstack 4
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_0023 to L_005d finally L_005d to L_0072
				.try L_007a to L_00d0 finally L_00d0 to L_00e5
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse L_00e5
				L_000b: newobj System.Collections.ArrayList::Void .ctor()
				L_0010: stloc.0 
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0017: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_001c: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_0021: stloc.s V_4
				L_0023: br.s L_0052
				L_0025: ldloc.s V_4
				L_0027: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_002c: castclass System.Windows.Forms.Control
				L_0031: stloc.1 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_0038: ldloc.1 
				L_0039: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_003e: box System.IntPtr
				L_0043: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0048: brtrue.s L_0052
				L_004a: ldloc.0 
				L_004b: ldloc.1 
				L_004c: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0051: pop 
				L_0052: ldloc.s V_4
				L_0054: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0059: brtrue.s L_0025
				L_005b: leave.s L_0072
				L_005d: ldloc.s V_4
				L_005f: isinst System.IDisposable
				L_0064: stloc.s V_5
				L_0066: ldloc.s V_5
				L_0068: brfalse.s L_0071
				L_006a: ldloc.s V_5
				L_006c: callvirt System.IDisposable::Void Dispose()
				L_0071: endfinally 
				L_0072: ldloc.0 
				L_0073: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0078: stloc.s V_4
				L_007a: br.s L_00c5
				L_007c: ldloc.s V_4
				L_007e: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0083: castclass System.Windows.Forms.Control
				L_0088: stloc.2 
				L_0089: ldarg.0 
				L_008a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_008f: ldloc.2 
				L_0090: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0095: box System.IntPtr
				L_009a: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_009f: brtrue.s L_00c5
				L_00a1: ldloc.2 
				L_00a2: ldarg.0 
				L_00a3: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a8: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00ad: stloc.3 
				L_00ae: ldarg.0 
				L_00af: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_00b4: ldloc.2 
				L_00b5: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00ba: box System.IntPtr
				L_00bf: ldloc.3 
				L_00c0: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_00c5: ldloc.s V_4
				L_00c7: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00cc: brtrue.s L_007c
				L_00ce: leave.s L_00e5
				L_00d0: ldloc.s V_4
				L_00d2: isinst System.IDisposable
				L_00d7: stloc.s V_5
				L_00d9: ldloc.s V_5
				L_00db: brfalse.s L_00e4
				L_00dd: ldloc.s V_5
				L_00df: callvirt System.IDisposable::Void Dispose()
				L_00e4: endfinally 
				L_00e5: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				if (! this.xf2140268ef7ddbf7)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in this.xcd9cdf30888d2204.Controls)
				{
					if (! this.x1cb3eacdc401d7a9.ContainsKey (control1.Handle))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! this.x1cb3eacdc401d7a9.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, this.xdc87e2b99332cd4a);
						this.x1cb3eacdc401d7a9.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			private void xbca0e60879f588a1 (object xe0292b9ed559da7d, KeyEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 42 Bytes
				.maxstack 9
				L_0000: ldarg.2 
				L_0001: callvirt System.Windows.Forms.KeyEventArgs::System.Windows.Forms.Keys get_KeyCode()
				L_0006: ldc.i4.s 32
				L_0008: beq.s L_0014
				L_000a: ldarg.2 
				L_000b: callvirt System.Windows.Forms.KeyEventArgs::System.Windows.Forms.Keys get_KeyCode()
				L_0010: ldc.i4.s 13
				L_0012: bne.un.s L_0029
				L_0014: ldarg.0 
				L_0015: ldc.i4.3 
				L_0016: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_001b: ldarg.0 
				L_001c: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0021: brfalse.s L_0029
				L_0023: ldarg.0 
				L_0024: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0029: ret 
			*/
			
			
			{
				if ((xfbf34718e704c6bc.KeyCode == Keys.Space) || (xfbf34718e704c6bc.KeyCode == Keys.Enter))
				{
					this.xdd938462da9aed37 = xb9506a535e31f22a.x51fcce5a95fca000;
					if (this.xf2140268ef7ddbf7)
					{
						this.PaintControl ();
					}
				}
			}
			
			private void xcd7553179bfc3f6c (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void xd34eabd7bd15b71a (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 76 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Control V_0, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_1)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_004b
				L_0008: ldarg.2 
				L_0009: callvirt System.Windows.Forms.ControlEventArgs::System.Windows.Forms.Control get_Control()
				L_000e: stloc.0 
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_0015: ldloc.0 
				L_0016: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001b: box System.IntPtr
				L_0020: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0025: brtrue.s L_004b
				L_0027: ldloc.0 
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002e: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0033: stloc.1 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Collections.Hashtable x1cb3eacdc401d7a9
				L_003a: ldloc.0 
				L_003b: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0040: box System.IntPtr
				L_0045: ldloc.1 
				L_0046: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_004b: ret 
			*/
			
			
			{
				if (! this.xf2140268ef7ddbf7)
				{
					return;
				}
				Control control1 = xfbf34718e704c6bc.Control;
				if (this.x1cb3eacdc401d7a9.ContainsKey (control1.Handle))
				{
					return;
				}
				xbd3f2493841f18a1 xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control1, this.xdc87e2b99332cd4a);
				this.x1cb3eacdc401d7a9.Add (control1.Handle, xbd3f2493841f18a1_1);
			}
			
			private void xd82fdb580ad5d9c2 (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.3 
				L_0002: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000d: brfalse.s L_0015
				L_000f: ldarg.0 
				L_0010: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0015: ret 
			*/
			
			
			{
				this.xdd938462da9aed37 = xb9506a535e31f22a.x51fcce5a95fca000;
				if (this.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void xf8f5e344dcfab3e8 (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
		#endregion
	}
	
}

