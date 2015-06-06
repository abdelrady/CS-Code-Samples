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
			using System.Windows.Forms.Layout;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xa427f1b2281f554b : xd24df615efe9450e
	
	{
		
		#region Fields
			private x3c41176af7e54b01 x5486200f56f78413;
			private bool x71d812f69bdec219;
			private Color x7c26c2d810682d2e;
			private MainMenu x946d4396b0c9cde4;
			private xa1883d0b59b7005b xad9f8190f430c699;
		#endregion
		
		#region Constructors
		
			internal xa427f1b2281f554b (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 250 Bytes
				.maxstack 5
				.try L_00a8 to L_00f1 catch System.Object L_00f1 to L_00f9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::Boolean x71d812f69bdec219
				L_0007: ldarg.0 
				L_0008: ldarg.1 
				L_0009: ldarg.2 
				L_000a: call Sunisoft.IrisSkin.xd24df615efe9450e::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_000f: ldarg.0 
				L_0010: ldarg.1 
				L_0011: call System.Windows.Forms.Control::System.Windows.Forms.Control FromHandle(IntPtr)
				L_0016: castclass System.Windows.Forms.Form
				L_001b: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0020: ldarg.0 
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0027: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_002c: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Drawing.Color x7c26c2d810682d2e
				L_0031: ldarg.0 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0038: newobj Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_003d: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0042: ldarg.0 
				L_0043: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x30c11b5a89921b08()
				L_0048: ldarg.0 
				L_0049: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_004e: callvirt System.Windows.Forms.Control::System.Windows.Forms.ContextMenu get_ContextMenu()
				L_0053: brfalse.s L_0071
				L_0055: ldarg.0 
				L_0056: ldarg.0 
				L_0057: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005c: ldarg.0 
				L_005d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0062: callvirt System.Windows.Forms.Control::System.Windows.Forms.ContextMenu get_ContextMenu()
				L_0067: newobj Sunisoft.IrisSkin.xa1883d0b59b7005b::Void .ctor(Sunisoft.IrisSkin.SkinEngine, System.Windows.Forms.Menu)
				L_006c: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.xa1883d0b59b7005b xad9f8190f430c699
				L_0071: ldarg.0 
				L_0072: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x33251e4c534e7926()
				L_0077: ldarg.0 
				L_0078: newobj System.Collections.Hashtable::Void .ctor()
				L_007d: stfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_0082: ldarg.0 
				L_0083: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0088: callvirt System.Windows.Forms.Form::Boolean get_IsMdiContainer()
				L_008d: brfalse.s L_0095
				L_008f: ldarg.0 
				L_0090: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x08d09b54d1a926bd()
				L_0095: ldarg.0 
				L_0096: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x05931f73c2d66689()
				L_009b: call Sunisoft.IrisSkin.SkinEngine::Int32 get_Random()
				L_00a0: ldc.i4 50000
				L_00a5: rem 
				L_00a6: brtrue.s L_00f9
				L_00a8: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Collections.Hashtable x1c12011307e0a753
				L_00ad: ldarg.0 
				L_00ae: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b3: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_SerialNumber()
				L_00b8: callvirt System.String::System.String Trim()
				L_00bd: callvirt System.Collections.Hashtable::Boolean Contains(System.Object)
				L_00c2: brfalse.s L_00c9
				L_00c4: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xf4f948f95d7023bb()
				L_00c9: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Security.Cryptography.DSACryptoServiceProvider DSA
				L_00ce: ldsfld Sunisoft.IrisSkin.SkinEngine::Byte[] DSAHash
				L_00d3: ldarg.0 
				L_00d4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00d9: callvirt Sunisoft.IrisSkin.SkinEngine::System.String get_SerialNumber()
				L_00de: call System.Convert::Byte[] FromBase64String(System.String)
				L_00e3: callvirt System.Security.Cryptography.DSACryptoServiceProvider::Boolean VerifyData(Byte[], Byte[])
				L_00e8: brtrue.s L_00ef
				L_00ea: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xf4f948f95d7023bb()
				L_00ef: leave.s L_00f9
				L_00f1: pop 
				L_00f2: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xf4f948f95d7023bb()
				L_00f7: leave.s L_00f9
				L_00f9: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override FormBorderStyle BorderStyle
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormBorderStyle get_FormBorderStyle()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.FormBorderStyle;
				}
			}
			
			
			protected override Rectangle ClientRectangle
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.ClientRectangle;
				}
			}
			
			
			protected override bool ControlBox
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::Boolean get_ControlBox()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.ControlBox;
				}
			}
			
			
			protected override int Height
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::Int32 get_Height()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.Height;
				}
			}
			
			
			protected override bool HelpButton
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::Boolean get_HelpButton()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.HelpButton;
				}
			}
			
			
			protected override Icon Icon
			
			{
				get
				
				/*
					// Code Size: 58 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.FormBorderStyle V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormBorderStyle get_FormBorderStyle()
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: ldc.i4.1 
					L_000e: sub 
					L_000f: switch (L_002c, L_002c, L_002c, L_002c, L_0038, L_0038)
					L_002c: ldarg.0 
					L_002d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0032: callvirt System.Windows.Forms.Form::System.Drawing.Icon get_Icon()
					L_0037: ret 
					L_0038: ldnull 
					L_0039: ret 
				*/
				
				{
					switch (base.x42f4c234c9358072.FormBorderStyle)
					{
						case FormBorderStyle.FixedToolWindow:
						case FormBorderStyle.SizableToolWindow:
						
						{
								return null;
						}
						case FormBorderStyle.FixedSingle:
						case FormBorderStyle.Fixed3D:
						case FormBorderStyle.FixedDialog:
						case FormBorderStyle.Sizable:
						
						{
								return base.x42f4c234c9358072.Icon;
						}
					}
					return base.x42f4c234c9358072.Icon;
				}
			}
			
			
			protected override bool IsActive
			
			{
				get
				
				/*
					// Code Size: 72 Bytes
					.maxstack 4
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::Boolean get_IsMdiChild()
					L_000b: brfalse.s L_0026
					L_000d: ldarg.0 
					L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0013: ldarg.0 
					L_0014: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0019: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_MdiParent()
					L_001e: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveMdiChild()
					L_0023: ceq 
					L_0025: ret 
					L_0026: ldarg.0 
					L_0027: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_002c: callvirt System.Windows.Forms.Form::Boolean get_IsMdiContainer()
					L_0031: brfalse.s L_0041
					L_0033: ldarg.0 
					L_0034: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0039: call System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveForm()
					L_003e: ceq 
					L_0040: ret 
					L_0041: ldarg.0 
					L_0042: call Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsActive()
					L_0047: ret 
				*/
				
				{
					if (base.x42f4c234c9358072.IsMdiChild)
					{
						return (base.x42f4c234c9358072 == base.x42f4c234c9358072.MdiParent.ActiveMdiChild);
					}
					else if (! base.x42f4c234c9358072.IsMdiContainer)
					{
						return base.IsActive;
					}
					else
					{
						return (base.x42f4c234c9358072 == Form.ActiveForm);
					}
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: call Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
					L_0007: ret 
				*/
				
				{
					base.IsActive = value;
				}
			}
			
			
			protected override bool IsDisposed
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.IsDisposed;
				}
			}
			
			
			protected override bool IsMdiChild
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::Boolean get_IsMdiChild()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.IsMdiChild;
				}
			}
			
			
			protected override bool IsMdiContainer
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::Boolean get_IsMdiContainer()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.IsMdiContainer;
				}
			}
			
			
			protected override bool MaximizeBox
			
			{
				get
				
				/*
					// Code Size: 44 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.FormBorderStyle V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormBorderStyle get_FormBorderStyle()
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: ldc.i4.5 
					L_000e: sub 
					L_000f: switch (L_001e, L_001e)
					L_001c: br.s L_0020
					L_001e: ldc.i4.0 
					L_001f: ret 
					L_0020: ldarg.0 
					L_0021: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0026: callvirt System.Windows.Forms.Form::Boolean get_MaximizeBox()
					L_002b: ret 
				*/
				
				{
					switch (base.x42f4c234c9358072.FormBorderStyle)
					{
						case FormBorderStyle.FixedToolWindow:
						case FormBorderStyle.SizableToolWindow:
						
						{
								return false;
						}
					}
					return base.x42f4c234c9358072.MaximizeBox;
				}
			}
			
			
			protected override int MenuHeight
			
			{
				get
				
				/*
					// Code Size: 32 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
					L_0006: brfalse.s L_001e
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
					L_000e: brfalse.s L_001c
					L_0010: ldarg.0 
					L_0011: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
					L_0016: callvirt System.Windows.Forms.Control::Int32 get_Height()
					L_001b: ret 
					L_001c: ldc.i4.0 
					L_001d: ret 
					L_001e: ldc.i4.0 
					L_001f: ret 
				*/
				
				{
					if (this.x946d4396b0c9cde4 == null)
					{
						return 0;
					}
					else if (this.x5486200f56f78413 == null)
					{
						return 0;
					}
					else
					{
						return this.x5486200f56f78413.Height;
					}
				}
			}
			
			
			protected override bool MinimizeBox
			
			{
				get
				
				/*
					// Code Size: 44 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.FormBorderStyle V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormBorderStyle get_FormBorderStyle()
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: ldc.i4.5 
					L_000e: sub 
					L_000f: switch (L_001e, L_001e)
					L_001c: br.s L_0020
					L_001e: ldc.i4.0 
					L_001f: ret 
					L_0020: ldarg.0 
					L_0021: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0026: callvirt System.Windows.Forms.Form::Boolean get_MinimizeBox()
					L_002b: ret 
				*/
				
				{
					switch (base.x42f4c234c9358072.FormBorderStyle)
					{
						case FormBorderStyle.FixedToolWindow:
						case FormBorderStyle.SizableToolWindow:
						
						{
								return false;
						}
					}
					return base.x42f4c234c9358072.MinimizeBox;
				}
			}
			
			
			protected override Region Region
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Region get_Region()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.Region;
				}
				set
				
				/*
					// Code Size: 13 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: ldarg.1 
					L_0007: callvirt System.Windows.Forms.Control::Void set_Region(System.Drawing.Region)
					L_000c: ret 
				*/
				
				{
					base.x42f4c234c9358072.Region = value;
				}
			}
			
			
			protected override RightToLeft RightToLeft
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.RightToLeft;
				}
			}
			
			
			protected override bool RightToLeftLayout
			
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
			
			
			protected override object Tag
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.Tag;
				}
			}
			
			
			protected override string Text
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::System.String get_Text()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.Text;
				}
			}
			
			
			protected override int TitleHeight
			
			{
				get
				
				/*
					// Code Size: 51 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsMdiChild()
					L_0006: brfalse.s L_0027
					L_0008: ldarg.0 
					L_0009: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormWindowState get_WindowState()
					L_000e: ldc.i4.2 
					L_000f: bne.un.s L_0027
					L_0011: ldarg.0 
					L_0012: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
					L_0017: brfalse.s L_0027
					L_0019: ldarg.0 
					L_001a: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
					L_001f: callvirt System.Windows.Forms.Control::Int32 get_Height()
					L_0024: ldc.i4.1 
					L_0025: sub 
					L_0026: ret 
					L_0027: ldarg.0 
					L_0028: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_002d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
					L_0032: ret 
				*/
				
				{
					if (! this.IsMdiChild)
					{
						return ((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight;
					}
					else if (this.WindowState != FormWindowState.Maximized)
					{
						return ((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight;
					}
					else if (this.x946d4396b0c9cde4 == null)
					{
						return ((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight;
					}
					else
					{
						return (this.x5486200f56f78413.Height - 1);
					}
				}
			}
			
			
			protected override int Width
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
					L_0006: callvirt System.Windows.Forms.Control::Int32 get_Width()
					L_000b: ret 
				*/
				
				{
					return base.x42f4c234c9358072.Width;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 50 Bytes
				.maxstack 3
				.locals (System.UInt32 V_0, 
         System.IntPtr V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldc.i4 8403
				L_000d: bne.un.s L_002a
				L_000f: ldarg.1 
				L_0010: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0015: stloc.1 
				L_0016: ldloca.s V_1
				L_0018: call System.IntPtr::Int32 ToInt32()
				L_001d: ldc.i4 8403
				L_0022: bne.un.s L_002a
				L_0024: ldarg.0 
				L_0025: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void xbe3f57786c90d37f()
				L_002a: ldarg.0 
				L_002b: ldarg.1 
				L_002c: call Sunisoft.IrisSkin.xd24df615efe9450e::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0031: ret 
			*/
			
			
			{
				if ((((uint) m.Msg) == 8403) && (m.WParam.ToInt32 () == 8403))
				{
					this.xbe3f57786c90d37f ();
				}
				return base.BeforeWndProc (ref m);
			}
			
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 182 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brtrue L_008f
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0011: brfalse.s L_004d
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0019: ldnull 
				L_001a: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void set_xd8e8992926cad390(System.Windows.Forms.Form)
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0025: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_002a: ldarg.0 
				L_002b: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0030: callvirt System.Windows.Forms.Control+ControlCollection::Boolean Contains(System.Windows.Forms.Control)
				L_0035: brfalse.s L_004d
				L_0037: ldarg.0 
				L_0038: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_003d: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0048: callvirt System.Windows.Forms.Control+ControlCollection::Void Remove(System.Windows.Forms.Control)
				L_004d: ldarg.0 
				L_004e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0053: callvirt System.Windows.Forms.Form::System.Windows.Forms.MainMenu get_Menu()
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_005e: beq.s L_0079
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0066: brfalse.s L_0079
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_006e: ldarg.0 
				L_006f: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0074: callvirt System.Windows.Forms.Form::Void set_Menu(System.Windows.Forms.MainMenu)
				L_0079: ldarg.0 
				L_007a: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x33251e4c534e7926()
				L_007f: ldarg.0 
				L_0080: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaintChild()
				L_0085: brfalse.s L_00a7
				L_0087: ldarg.0 
				L_0088: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x7ca6c09f91bb596a()
				L_008d: br.s L_00a7
				L_008f: ldarg.0 
				L_0090: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x30c11b5a89921b08()
				L_0095: ldarg.0 
				L_0096: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x33251e4c534e7926()
				L_009b: ldarg.0 
				L_009c: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x7ca6c09f91bb596a()
				L_00a1: ldarg.0 
				L_00a2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RegionWindow()
				L_00a7: ldarg.0 
				L_00a8: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x05931f73c2d66689()
				L_00ad: ldarg.0 
				L_00ae: ldarg.1 
				L_00af: ldarg.2 
				L_00b0: call Sunisoft.IrisSkin.xd24df615efe9450e::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_00b5: ret 
			*/
			
			
			{
				if (this.CanPaint)
				{
					this.x30c11b5a89921b08 ();
					this.x33251e4c534e7926 ();
					this.x7ca6c09f91bb596a ();
					this.RegionWindow ();
				}
				else
				{
					if (this.x5486200f56f78413 != null)
					{
						this.x5486200f56f78413.xd8e8992926cad390 = ((Form) null);
						if (base.x42f4c234c9358072.Controls.Contains (((Control) this.x5486200f56f78413)))
						{
							base.x42f4c234c9358072.Controls.Remove (((Control) this.x5486200f56f78413));
						}
					}
					if ((base.x42f4c234c9358072.Menu != this.x946d4396b0c9cde4) && (this.x946d4396b0c9cde4 != null))
					{
						base.x42f4c234c9358072.Menu = this.x946d4396b0c9cde4;
					}
					this.x33251e4c534e7926 ();
					if (this.CanPaintChild)
					{
						this.x7ca6c09f91bb596a ();
					}
				}
				this.x05931f73c2d66689 ();
				base.OnCurrentSkinChanged (sender, e);
			}
			
			protected override void PaintBorder (Graphics g)
			
			/*
				// Code Size: 852 Bytes
				.maxstack 10
				.locals (System.Int32 V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Drawing2D.LinearGradientBrush V_4, 
         System.Drawing.Drawing2D.LinearGradientBrush V_5)
				.try L_019a to L_01a5 finally L_01a5 to L_01b1
				.try L_0320 to L_032b finally L_032b to L_0337
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.xd24df615efe9450e::Void PaintBorder(System.Drawing.Graphics)
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0018: blt.s L_0030
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0020: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_002b: bge L_0353
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0036: brfalse L_0353
				L_003b: ldarg.0 
				L_003c: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0041: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0046: stloc.0 
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0052: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0057: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_MENUBAR()
				L_005c: stloc.1 
				L_005d: ldarg.0 
				L_005e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0063: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_006e: bge L_01cd
				L_0073: ldloca.s V_2
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_007b: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_0080: ldarg.0 
				L_0081: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0086: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
				L_008b: ldarg.0 
				L_008c: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0091: callvirt System.Windows.Forms.Control::Int32 get_Top()
				L_0096: add 
				L_0097: ldarg.0 
				L_0098: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_009d: ldarg.0 
				L_009e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a3: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_00a8: sub 
				L_00a9: ldloc.0 
				L_00aa: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00af: ldloc.1 
				L_00b0: brfalse L_0136
				L_00b5: ldloc.1 
				L_00b6: callvirt System.Drawing.Image::Int32 get_Width()
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_00c1: ldarg.0 
				L_00c2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c7: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_00cc: sub 
				L_00cd: ble.s L_00f2
				L_00cf: ldloca.s V_3
				L_00d1: ldc.i4.0 
				L_00d2: ldc.i4.0 
				L_00d3: ldarg.0 
				L_00d4: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_00d9: ldarg.0 
				L_00da: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00df: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_00e4: sub 
				L_00e5: ldloc.1 
				L_00e6: callvirt System.Drawing.Image::Int32 get_Height()
				L_00eb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00f0: br.s L_0107
				L_00f2: ldloca.s V_3
				L_00f4: ldc.i4.0 
				L_00f5: ldc.i4.0 
				L_00f6: ldloc.1 
				L_00f7: callvirt System.Drawing.Image::Int32 get_Width()
				L_00fc: ldloc.1 
				L_00fd: callvirt System.Drawing.Image::Int32 get_Height()
				L_0102: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0107: ldarg.1 
				L_0108: ldloc.1 
				L_0109: ldloc.2 
				L_010a: ldloca.s V_3
				L_010c: call System.Drawing.Rectangle::Int32 get_X()
				L_0111: ldloca.s V_3
				L_0113: call System.Drawing.Rectangle::Int32 get_Y()
				L_0118: ldloca.s V_3
				L_011a: call System.Drawing.Rectangle::Int32 get_Width()
				L_011f: ldloca.s V_3
				L_0121: call System.Drawing.Rectangle::Int32 get_Height()
				L_0126: ldc.i4.2 
				L_0127: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_012c: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0131: br L_01cd
				L_0136: ldarg.0 
				L_0137: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_013c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0141: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0146: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_014b: ldarg.0 
				L_014c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0151: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0156: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_015b: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_0160: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0165: brfalse.s L_01b1
				L_0167: ldloc.2 
				L_0168: ldarg.0 
				L_0169: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_016e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0173: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0178: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_017d: ldarg.0 
				L_017e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0183: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0188: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_018d: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_0192: ldc.i4.1 
				L_0193: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_0198: stloc.s V_4
				L_019a: ldarg.1 
				L_019b: ldloc.s V_4
				L_019d: ldloc.2 
				L_019e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_01a3: leave.s L_01cd
				L_01a5: ldloc.s V_4
				L_01a7: brfalse.s L_01b0
				L_01a9: ldloc.s V_4
				L_01ab: callvirt System.IDisposable::Void Dispose()
				L_01b0: endfinally 
				L_01b1: ldarg.1 
				L_01b2: ldarg.0 
				L_01b3: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01b8: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01bd: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_01c2: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUBARSTARTCOLOR()
				L_01c7: ldloc.2 
				L_01c8: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_01cd: ldarg.0 
				L_01ce: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01d3: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_01d8: ldarg.0 
				L_01d9: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_01de: bge L_0353
				L_01e3: ldloca.s V_2
				L_01e5: ldarg.0 
				L_01e6: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_Width()
				L_01eb: ldarg.0 
				L_01ec: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_01f1: sub 
				L_01f2: ldarg.0 
				L_01f3: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_01f8: callvirt System.Windows.Forms.Control::Int32 get_Top()
				L_01fd: ldarg.0 
				L_01fe: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0203: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
				L_0208: add 
				L_0209: ldarg.0 
				L_020a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_020f: ldarg.0 
				L_0210: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0215: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_021a: sub 
				L_021b: ldloc.0 
				L_021c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0221: ldloc.1 
				L_0222: brfalse L_02bc
				L_0227: ldloc.1 
				L_0228: callvirt System.Drawing.Image::Int32 get_Width()
				L_022d: ldarg.0 
				L_022e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0233: ldarg.0 
				L_0234: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0239: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_023e: sub 
				L_023f: ble.s L_027c
				L_0241: ldloca.s V_3
				L_0243: ldloc.1 
				L_0244: callvirt System.Drawing.Image::Int32 get_Width()
				L_0249: ldarg.0 
				L_024a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_024f: sub 
				L_0250: ldarg.0 
				L_0251: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0256: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_025b: add 
				L_025c: ldc.i4.0 
				L_025d: ldarg.0 
				L_025e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0263: ldarg.0 
				L_0264: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0269: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_026e: sub 
				L_026f: ldloc.1 
				L_0270: callvirt System.Drawing.Image::Int32 get_Height()
				L_0275: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_027a: br.s L_0291
				L_027c: ldloca.s V_3
				L_027e: ldc.i4.0 
				L_027f: ldc.i4.0 
				L_0280: ldloc.1 
				L_0281: callvirt System.Drawing.Image::Int32 get_Width()
				L_0286: ldloc.1 
				L_0287: callvirt System.Drawing.Image::Int32 get_Height()
				L_028c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0291: ldarg.1 
				L_0292: ldloc.1 
				L_0293: ldloc.2 
				L_0294: ldloca.s V_3
				L_0296: call System.Drawing.Rectangle::Int32 get_X()
				L_029b: ldloca.s V_3
				L_029d: call System.Drawing.Rectangle::Int32 get_Y()
				L_02a2: ldloca.s V_3
				L_02a4: call System.Drawing.Rectangle::Int32 get_Width()
				L_02a9: ldloca.s V_3
				L_02ab: call System.Drawing.Rectangle::Int32 get_Height()
				L_02b0: ldc.i4.2 
				L_02b1: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_02b6: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_02bb: ret 
				L_02bc: ldarg.0 
				L_02bd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02c2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02c7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_02cc: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_02d1: ldarg.0 
				L_02d2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02d7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02dc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_02e1: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_02e6: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_02eb: brfalse.s L_0337
				L_02ed: ldloc.2 
				L_02ee: ldarg.0 
				L_02ef: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02f4: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02f9: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_02fe: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_0303: ldarg.0 
				L_0304: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0309: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_030e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0313: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_0318: ldc.i4.1 
				L_0319: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_031e: stloc.s V_5
				L_0320: ldarg.1 
				L_0321: ldloc.s V_5
				L_0323: ldloc.2 
				L_0324: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0329: leave.s L_0353
				L_032b: ldloc.s V_5
				L_032d: brfalse.s L_0336
				L_032f: ldloc.s V_5
				L_0331: callvirt System.IDisposable::Void Dispose()
				L_0336: endfinally 
				L_0337: ldarg.1 
				L_0338: ldarg.0 
				L_0339: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_033e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0343: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0348: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUBARSTARTCOLOR()
				L_034d: ldloc.2 
				L_034e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0353: ret 
			*/
			
			
			{
				int i1;
				Bitmap bitmap1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				base.PaintBorder (g);
				if (((((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth >= base.xdab5261f2cc3422d) && (((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth >= base.xdab5261f2cc3422d)) || (this.x946d4396b0c9cde4 == null))
				{
					return;
				}
				i1 = this.x5486200f56f78413.Height;
				bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_MENUBAR;
				if (((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth < base.xdab5261f2cc3422d)
				{
					rectangle1 = new Rectangle (((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth, ((int) (((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight + this.x5486200f56f78413.Top)), ((int) (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth)), i1);
					if (bitmap1 == null)
					{
						if (((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (rectangle1, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR, LinearGradientMode.Vertical))
							{
								g.FillRectangle (((Brush) linearGradientBrush1), rectangle1);
								goto L_01CD;
							}
						}
						else
						{
							g.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUBARSTARTCOLOR, rectangle1);
						}
					}
					else
					{
						if (bitmap1.Width > (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth))
						{
							rectangle2 = new Rectangle (0, 0, ((int) (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth)), bitmap1.Height);
						}
						else
						{
							rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						}
						g.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					}
				}
				
			L_01CD:
				
				{
				}
				if (((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth >= base.xdab5261f2cc3422d)
				{
				}
				else
				{
					rectangle1 = new Rectangle (((int) (this.Width - base.xdab5261f2cc3422d)), ((int) (this.x5486200f56f78413.Top + ((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight)), ((int) (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth)), i1);
					if (bitmap1 == null)
					{
						if (((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (rectangle1, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR, LinearGradientMode.Vertical))
							{
								g.FillRectangle (((Brush) linearGradientBrush2), rectangle1);
								return;
							}
						}
						else
						{
							g.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUBARSTARTCOLOR, rectangle1);
							return;
						}
					}
					if (bitmap1.Width > (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth))
					{
						rectangle2 = new Rectangle (((int) ((bitmap1.Width - base.xdab5261f2cc3422d) + ((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth)), 0, ((int) (base.xdab5261f2cc3422d - ((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth)), bitmap1.Height);
					}
					else
					{
						rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
					}
					g.DrawImage (((Image) bitmap1), rectangle1, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					return;
					
					/*
						Unreachable Code
						return;
					*/
				}
			}
			
			protected override Point PointToScreen (Point point)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: ldarg.1 
				L_0007: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_000c: ret 
			*/
			
			
			{
				return base.x42f4c234c9358072.PointToScreen (point);
			}
			
			protected override void RefreshMainMenu ()
			
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0006: brfalse.s L_0013
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_000e: callvirt System.Windows.Forms.Control::Void Refresh()
				L_0013: ret 
			*/
			
			
			{
				if (this.x5486200f56f78413 != null)
				{
					this.x5486200f56f78413.Refresh ();
				}
			}
			
			protected override void RefreshWindow ()
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: callvirt System.Windows.Forms.Control::Void Refresh()
				L_000b: ret 
			*/
			
			
			{
				base.x42f4c234c9358072.Refresh ();
			}
			
			protected override void SkinControls ()
			
			/*
				// Code Size: 297 Bytes
				.maxstack 5
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_005e to L_00a0 finally L_00a0 to L_00b5
				.try L_00bd to L_0113 finally L_0113 to L_0128
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_000b: brtrue.s L_003b
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.xa427f1b2281f554b::Void xe08c104b24ddae95(System.Object, System.Windows.Forms.ControlEventArgs)
				L_001a: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.Control::Void add_ControlAdded(System.Windows.Forms.ControlEventHandler)
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_002a: ldarg.0 
				L_002b: ldftn Sunisoft.IrisSkin.xa427f1b2281f554b::Void xbd90dc5580ff6562(System.Object, System.Windows.Forms.ControlEventArgs)
				L_0031: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_0036: callvirt System.Windows.Forms.Control::Void add_ControlRemoved(System.Windows.Forms.ControlEventHandler)
				L_003b: ldarg.0 
				L_003c: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaintChild()
				L_0041: brfalse L_0128
				L_0046: newobj System.Collections.ArrayList::Void .ctor()
				L_004b: stloc.0 
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0052: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0057: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_005c: stloc.s V_4
				L_005e: br.s L_0095
				L_0060: ldloc.s V_4
				L_0062: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0067: castclass System.Windows.Forms.Control
				L_006c: stloc.1 
				L_006d: ldloc.1 
				L_006e: isinst System.Windows.Forms.MdiClient
				L_0073: brtrue.s L_0095
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_007b: ldloc.1 
				L_007c: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0081: box System.IntPtr
				L_0086: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_008b: brtrue.s L_0095
				L_008d: ldloc.0 
				L_008e: ldloc.1 
				L_008f: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0094: pop 
				L_0095: ldloc.s V_4
				L_0097: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_009c: brtrue.s L_0060
				L_009e: leave.s L_00b5
				L_00a0: ldloc.s V_4
				L_00a2: isinst System.IDisposable
				L_00a7: stloc.s V_5
				L_00a9: ldloc.s V_5
				L_00ab: brfalse.s L_00b4
				L_00ad: ldloc.s V_5
				L_00af: callvirt System.IDisposable::Void Dispose()
				L_00b4: endfinally 
				L_00b5: ldloc.0 
				L_00b6: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_00bb: stloc.s V_4
				L_00bd: br.s L_0108
				L_00bf: ldloc.s V_4
				L_00c1: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00c6: castclass System.Windows.Forms.Control
				L_00cb: stloc.2 
				L_00cc: ldarg.0 
				L_00cd: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_00d2: ldloc.2 
				L_00d3: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00d8: box System.IntPtr
				L_00dd: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_00e2: brtrue.s L_0108
				L_00e4: ldloc.2 
				L_00e5: ldarg.0 
				L_00e6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00eb: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00f0: stloc.3 
				L_00f1: ldarg.0 
				L_00f2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_00f7: ldloc.2 
				L_00f8: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00fd: box System.IntPtr
				L_0102: ldloc.3 
				L_0103: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0108: ldloc.s V_4
				L_010a: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_010f: brtrue.s L_00bf
				L_0111: leave.s L_0128
				L_0113: ldloc.s V_4
				L_0115: isinst System.IDisposable
				L_011a: stloc.s V_5
				L_011c: ldloc.s V_5
				L_011e: brfalse.s L_0127
				L_0120: ldloc.s V_5
				L_0122: callvirt System.IDisposable::Void Dispose()
				L_0127: endfinally 
				L_0128: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				if (! base.x42f4c234c9358072.IsDisposed)
				{
					base.x42f4c234c9358072.ControlAdded += new ControlEventHandler (this.xe08c104b24ddae95);
					base.x42f4c234c9358072.ControlRemoved += new ControlEventHandler (this.xbd90dc5580ff6562);
				}
				if (! this.CanPaintChild)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in base.x42f4c234c9358072.Controls)
				{
					if ((! (control1 is MdiClient)) && (! base.x84603c7eff1953af.ContainsKey (control1.Handle)))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! base.x84603c7eff1953af.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, base.xdc87e2b99332cd4a);
						base.x84603c7eff1953af.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			private void x05931f73c2d66689 ()
			
			/*
				// Code Size: 75 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brfalse.s L_0029
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0019: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_001e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0023: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0028: ret 
				L_0029: ldarg.0 
				L_002a: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_IsDisposed()
				L_002f: brtrue.s L_004a
				L_0031: ldarg.0 
				L_0032: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormBorderStyle get_BorderStyle()
				L_0037: brfalse.s L_004a
				L_0039: ldarg.0 
				L_003a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Drawing.Color x7c26c2d810682d2e
				L_0045: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_004a: ret 
			*/
			
			
			{
				if (this.CanPaint)
				{
					base.x42f4c234c9358072.BackColor = ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_FORMCOLOR;
				}
				else if ((! this.IsDisposed) && (this.BorderStyle != FormBorderStyle.None))
				{
					base.x42f4c234c9358072.BackColor = this.x7c26c2d810682d2e;
				}
			}
			
			private void x08d09b54d1a926bd ()
			
			/*
				// Code Size: 45 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinAllForm()
				L_000b: brfalse.s L_002c
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.xa427f1b2281f554b::Void x23daf02978257d54(System.Object, System.EventArgs)
				L_001a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.Form::Void add_MdiChildActivate(System.EventHandler)
				L_0024: ldarg.0 
				L_0025: ldnull 
				L_0026: ldnull 
				L_0027: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x23daf02978257d54(System.Object, System.EventArgs)
				L_002c: ret 
			*/
			
			
			{
				if (((SkinEngine) base.xdc87e2b99332cd4a).SkinAllForm)
				{
					base.x42f4c234c9358072.MdiChildActivate += new EventHandler (this.x23daf02978257d54);
					this.x23daf02978257d54 (null, ((EventArgs) null));
				}
			}
			
			private void x23daf02978257d54 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 352 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.xa427f1b2281f554b V_0, 
         System.Windows.Forms.Form V_1, 
         System.Object V_2, 
         System.Object V_3, 
         System.Windows.Forms.Form[] V_4, 
         System.Int32 V_5, 
         System.Collections.IEnumerator V_6, 
         System.IDisposable V_7)
				.try L_009a to L_014a finally L_014a to L_015f
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_000b: stloc.s V_4
				L_000d: ldc.i4.0 
				L_000e: stloc.s V_5
				L_0010: br.s L_0072
				L_0012: ldloc.s V_4
				L_0014: ldloc.s V_5
				L_0016: ldelem.ref 
				L_0017: stloc.1 
				L_0018: ldloc.1 
				L_0019: brfalse.s L_006c
				L_001b: ldloc.1 
				L_001c: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0021: brtrue.s L_006c
				L_0023: ldloc.1 
				L_0024: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_0029: brfalse.s L_006c
				L_002b: ldarg.0 
				L_002c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_0031: ldloc.1 
				L_0032: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0037: box System.IntPtr
				L_003c: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0041: brtrue.s L_006c
				L_0043: ldloc.1 
				L_0044: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0049: ldarg.0 
				L_004a: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004f: newobj Sunisoft.IrisSkin.xa427f1b2281f554b::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0054: stloc.0 
				L_0055: ldarg.0 
				L_0056: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_005b: ldloc.1 
				L_005c: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0061: box System.IntPtr
				L_0066: ldloc.0 
				L_0067: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_006c: ldloc.s V_5
				L_006e: ldc.i4.1 
				L_006f: add 
				L_0070: stloc.s V_5
				L_0072: ldloc.s V_5
				L_0074: ldloc.s V_4
				L_0076: ldlen 
				L_0077: conv.i4 
				L_0078: blt.s L_0012
				L_007a: ldarg.0 
				L_007b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0080: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveMdiChild()
				L_0085: brtrue.s L_0088
				L_0087: ret 
				L_0088: ldarg.0 
				L_0089: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_008e: callvirt System.Collections.Hashtable::System.Collections.ICollection get_Keys()
				L_0093: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_0098: stloc.s V_6
				L_009a: br L_013c
				L_009f: ldloc.s V_6
				L_00a1: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00a6: stloc.3 
				L_00a7: ldloc.3 
				L_00a8: isinst System.IntPtr
				L_00ad: brfalse L_013c
				L_00b2: ldloc.3 
				L_00b3: unbox System.IntPtr
				L_00b8: ldobj System.IntPtr
				L_00bd: ldarg.0 
				L_00be: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00c3: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveMdiChild()
				L_00c8: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00cd: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_00d2: brfalse.s L_00f9
				L_00d4: ldarg.0 
				L_00d5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_00da: ldloc.3 
				L_00db: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_00e0: stloc.2 
				L_00e1: ldloc.2 
				L_00e2: isinst Sunisoft.IrisSkin.xa427f1b2281f554b
				L_00e7: brfalse.s L_013c
				L_00e9: ldloc.2 
				L_00ea: castclass Sunisoft.IrisSkin.xa427f1b2281f554b
				L_00ef: stloc.0 
				L_00f0: ldloc.0 
				L_00f1: ldc.i4.1 
				L_00f2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_00f7: br.s L_013c
				L_00f9: ldarg.0 
				L_00fa: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable xf04e05b3bf638680
				L_00ff: ldloc.3 
				L_0100: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0105: stloc.2 
				L_0106: ldloc.2 
				L_0107: isinst Sunisoft.IrisSkin.xa427f1b2281f554b
				L_010c: brfalse.s L_013c
				L_010e: ldloc.2 
				L_010f: castclass Sunisoft.IrisSkin.xa427f1b2281f554b
				L_0114: stloc.0 
				L_0115: ldloc.0 
				L_0116: ldc.i4.0 
				L_0117: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void set_IsActive(Boolean)
				L_011c: ldloc.3 
				L_011d: unbox System.IntPtr
				L_0122: ldobj System.IntPtr
				L_0127: ldc.i4 133
				L_012c: ldsfld System.IntPtr::IntPtr Zero
				L_0131: ldsfld System.IntPtr::IntPtr Zero
				L_0136: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_013b: pop 
				L_013c: ldloc.s V_6
				L_013e: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0143: brtrue L_009f
				L_0148: leave.s L_015f
				L_014a: ldloc.s V_6
				L_014c: isinst System.IDisposable
				L_0151: stloc.s V_7
				L_0153: ldloc.s V_7
				L_0155: brfalse.s L_015e
				L_0157: ldloc.s V_7
				L_0159: callvirt System.IDisposable::Void Dispose()
				L_015e: endfinally 
				L_015f: ret 
			*/
			
			
			{
				xa427f1b2281f554b xa427f1b2281f554b1;
				object object1;
				foreach (Form form1 in base.x42f4c234c9358072.MdiChildren)
				{
					if ((((form1 != null) && (! form1.IsDisposed)) && form1.Visible) && (! base.xf04e05b3bf638680.ContainsKey (form1.Handle)))
					{
						xa427f1b2281f554b1 = new xa427f1b2281f554b (form1.Handle, base.xdc87e2b99332cd4a);
						base.xf04e05b3bf638680.Add (form1.Handle, xa427f1b2281f554b1);
					}
				}
				if (base.x42f4c234c9358072.ActiveMdiChild != null)
				{
					foreach (object object2 in base.xf04e05b3bf638680.Keys)
					{
						if (object2 is IntPtr)
						{
							if (((IntPtr) object2) != base.x42f4c234c9358072.ActiveMdiChild.Handle)
							{
								object1 = base.xf04e05b3bf638680[object2];
								if (object1 is xa427f1b2281f554b)
								{
									xa427f1b2281f554b1 = ((xa427f1b2281f554b) object1);
									xa427f1b2281f554b1.IsActive = false;
									IntPtr intPtr1 = x61467fe65a98f20c.SendMessage (((IntPtr) object2), 133, IntPtr.Zero, IntPtr.Zero);
								}
								continue;
							}
							object1 = base.xf04e05b3bf638680[object2];
							if (! (object1 is xa427f1b2281f554b))
							{
								continue;
							}
							xa427f1b2281f554b1 = ((xa427f1b2281f554b) object1);
							xa427f1b2281f554b1.IsActive = true;
						}
					}
				}
			}
			
			private void x30c11b5a89921b08 ()
			
			/*
				// Code Size: 167 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: callvirt System.Windows.Forms.Form::System.Windows.Forms.MainMenu get_Menu()
				L_000b: brtrue.s L_0035
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0013: callvirt System.Windows.Forms.Form::Boolean get_IsMdiContainer()
				L_0018: brfalse.s L_0034
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0020: brfalse.s L_0033
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_002e: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void set_xd8e8992926cad390(System.Windows.Forms.Form)
				L_0033: ret 
				L_0034: ret 
				L_0035: ldarg.0 
				L_0036: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_003b: brfalse.s L_00a6
				L_003d: ldarg.0 
				L_003e: ldarg.0 
				L_003f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0044: callvirt System.Windows.Forms.Form::System.Windows.Forms.MainMenu get_Menu()
				L_0049: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_004e: ldarg.0 
				L_004f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0054: ldnull 
				L_0055: callvirt System.Windows.Forms.Form::Void set_Menu(System.Windows.Forms.MainMenu)
				L_005a: ldarg.0 
				L_005b: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void x45cc2ae14a69c414()
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0066: callvirt System.Windows.Forms.Form::Boolean get_IsMdiContainer()
				L_006b: brfalse.s L_007e
				L_006d: ldarg.0 
				L_006e: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0073: ldarg.0 
				L_0074: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0079: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void set_xd8e8992926cad390(System.Windows.Forms.Form)
				L_007e: ldarg.0 
				L_007f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0084: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0089: ldarg.0 
				L_008a: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_008f: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_0094: ldarg.0 
				L_0095: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_009a: ldarg.0 
				L_009b: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_00a0: newobj Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f::Void .ctor(Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01, System.Windows.Forms.MainMenu)
				L_00a5: pop 
				L_00a6: ret 
			*/
			
			
			{
				if (base.x42f4c234c9358072.Menu == null)
				{
					if (base.x42f4c234c9358072.IsMdiContainer && (this.x5486200f56f78413 != null))
					{
						this.x5486200f56f78413.xd8e8992926cad390 = base.x42f4c234c9358072;
					}
				}
				else if (this.CanPaint)
				{
					this.x946d4396b0c9cde4 = base.x42f4c234c9358072.Menu;
					base.x42f4c234c9358072.Menu = ((MainMenu) null);
					this.x45cc2ae14a69c414 ();
					if (base.x42f4c234c9358072.IsMdiContainer)
					{
						this.x5486200f56f78413.xd8e8992926cad390 = base.x42f4c234c9358072;
					}
					base.x42f4c234c9358072.Controls.Add (((Control) this.x5486200f56f78413));
					x4fef14ebf3863c7f x4fef14ebf3863c7f1 = new x4fef14ebf3863c7f (this.x5486200f56f78413, this.x946d4396b0c9cde4);
				}
			}
			
			private void x33251e4c534e7926 ()
			
			/*
				// Code Size: 328 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Windows.Forms.Control V_2, 
         System.Collections.IEnumerator V_3, 
         System.IDisposable V_4)
				.try L_0109 to L_0126 catch System.Object L_0126 to L_0129
				.try L_00f2 to L_0133 finally L_0133 to L_0147
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_000b: brfalse.s L_000e
				L_000d: ret 
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0014: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_0019: brfalse.s L_001c
				L_001b: ret 
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
				L_0027: ldarg.0 
				L_0028: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002d: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_0038: call System.Math::Int32 Max(Int32, Int32)
				L_003d: add 
				L_003e: stloc.0 
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0045: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_004a: ldarg.0 
				L_004b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0050: call System.Math::Int32 Max(Int32, Int32)
				L_0055: ldarg.0 
				L_0056: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005b: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0066: call System.Math::Int32 Max(Int32, Int32)
				L_006b: add 
				L_006c: stloc.1 
				L_006d: ldarg.0 
				L_006e: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0073: brfalse.s L_00a4
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_007b: ldloc.0 
				L_007c: ldarg.0 
				L_007d: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xe43c4bad7e91c24a
				L_0082: add 
				L_0083: ldarg.0 
				L_0084: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_0089: add 
				L_008a: callvirt System.Windows.Forms.Control::Void set_Height(Int32)
				L_008f: ldarg.0 
				L_0090: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0095: ldloc.1 
				L_0096: ldarg.0 
				L_0097: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xcd2b5f9eab575311
				L_009c: add 
				L_009d: callvirt System.Windows.Forms.Control::Void set_Width(Int32)
				L_00a2: br.s L_00c6
				L_00a4: ldarg.0 
				L_00a5: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xb807ac541c41b1ec
				L_00b0: callvirt System.Windows.Forms.Control::Void set_Height(Int32)
				L_00b5: ldarg.0 
				L_00b6: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 x9c67b90604ff861f
				L_00c1: callvirt System.Windows.Forms.Control::Void set_Width(Int32)
				L_00c6: ldarg.0 
				L_00c7: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Boolean x71d812f69bdec219
				L_00cc: brtrue L_0147
				L_00d1: ldarg.0 
				L_00d2: ldc.i4.1 
				L_00d3: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::Boolean x71d812f69bdec219
				L_00d8: ldarg.0 
				L_00d9: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_00de: ldc.i4.0 
				L_00df: ble.s L_0147
				L_00e1: ldarg.0 
				L_00e2: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_00e7: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_00ec: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_00f1: stloc.3 
				L_00f2: br.s L_0129
				L_00f4: ldloc.3 
				L_00f5: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00fa: castclass System.Windows.Forms.Control
				L_00ff: stloc.2 
				L_0100: ldloc.2 
				L_0101: ldarg.0 
				L_0102: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0107: beq.s L_0129
				L_0109: ldloc.2 
				L_010a: callvirt System.Windows.Forms.Control::System.Windows.Forms.DockStyle get_Dock()
				L_010f: brtrue.s L_0124
				L_0111: ldloc.2 
				L_0112: dup 
				L_0113: callvirt System.Windows.Forms.Control::Int32 get_Top()
				L_0118: ldarg.0 
				L_0119: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_011e: add 
				L_011f: callvirt System.Windows.Forms.Control::Void set_Top(Int32)
				L_0124: leave.s L_0129
				L_0126: pop 
				L_0127: leave.s L_0129
				L_0129: ldloc.3 
				L_012a: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_012f: brtrue.s L_00f4
				L_0131: leave.s L_0147
				L_0133: ldloc.3 
				L_0134: isinst System.IDisposable
				L_0139: stloc.s V_4
				L_013b: ldloc.s V_4
				L_013d: brfalse.s L_0146
				L_013f: ldloc.s V_4
				L_0141: callvirt System.IDisposable::Void Dispose()
				L_0146: endfinally 
				L_0147: ret 
			*/
			
			
			{
				if (base.x42f4c234c9358072.IsDisposed || (base.x42f4c234c9358072.WindowState != FormWindowState.Normal))
				{
					return;
				}
				int i1 = (((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight + Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).BottomBorderHeight, base.xef9eb32e7f1d1f23));
				int i2 = (Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth, base.xdab5261f2cc3422d) + Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth, base.xdab5261f2cc3422d));
				if (this.CanPaint)
				{
					base.x42f4c234c9358072.Height = ((i1 + base.xe43c4bad7e91c24a) + this.MenuHeight);
					base.x42f4c234c9358072.Width = (i2 + base.xcd2b5f9eab575311);
				}
				else
				{
					base.x42f4c234c9358072.Height = base.xb807ac541c41b1ec;
					base.x42f4c234c9358072.Width = base.x9c67b90604ff861f;
				}
				if (! this.x71d812f69bdec219)
				{
					this.x71d812f69bdec219 = true;
					if (this.MenuHeight > 0)
					{
						foreach (Control control1 in base.x42f4c234c9358072.Controls)
						{
							if (control1 != this.x5486200f56f78413)
							{
								try
								{
									if (control1.Dock == DockStyle.None)
									{
										control1.Top += this.MenuHeight;
									}
								}
								catch
								{
								}
							}
						}
					}
				}
			}
			
			private void x45cc2ae14a69c414 ()
			
			/*
				// Code Size: 425 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1, 
         System.Windows.Forms.MenuItem V_2, 
         System.Collections.ArrayList V_3, 
         System.Collections.ArrayList V_4, 
         System.Windows.Forms.MenuItem V_5, 
         System.Windows.Forms.MenuItem V_6, 
         System.Collections.IEnumerator V_7, 
         System.IDisposable V_8)
				.try L_008f to L_00e9 finally L_00e9 to L_00fe
				.try L_0135 to L_0187 finally L_0187 to L_019c
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_000f: brtrue.s L_0022
				L_0011: ldarg.0 
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0018: newobj Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_001d: stfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0028: callvirt System.Windows.Forms.MainMenu::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_002d: ldc.i4.2 
				L_002e: and 
				L_002f: ldc.i4.2 
				L_0030: bne.un.s L_004a
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_003e: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0043: callvirt System.Windows.Forms.Control::Void set_RightToLeft(System.Windows.Forms.RightToLeft)
				L_0048: br.s L_0060
				L_004a: ldarg.0 
				L_004b: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0050: ldarg.0 
				L_0051: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0056: callvirt System.Windows.Forms.MainMenu::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_005b: callvirt System.Windows.Forms.Control::Void set_RightToLeft(System.Windows.Forms.RightToLeft)
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0066: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_006b: callvirt System.Collections.CollectionBase::Void Clear()
				L_0070: newobj System.Collections.ArrayList::Void .ctor()
				L_0075: stloc.3 
				L_0076: newobj System.Collections.ArrayList::Void .ctor()
				L_007b: stloc.s V_4
				L_007d: ldarg.0 
				L_007e: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0083: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_0088: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_008d: stloc.s V_7
				L_008f: br.s L_00db
				L_0091: ldloc.s V_7
				L_0093: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0098: castclass System.Windows.Forms.MenuItem
				L_009d: stloc.s V_5
				L_009f: ldarg.0 
				L_00a0: ldloc.s V_5
				L_00a2: call Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd010ef1851698a47(System.Windows.Forms.MenuItem)
				L_00a7: stloc.0 
				L_00a8: ldarg.0 
				L_00a9: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_00ae: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_00b3: ldloc.0 
				L_00b4: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_00b9: pop 
				L_00ba: ldloc.s V_5
				L_00bc: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_00c1: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_00c6: ldc.i4.0 
				L_00c7: ble.s L_00db
				L_00c9: ldloc.3 
				L_00ca: ldloc.s V_5
				L_00cc: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00d1: pop 
				L_00d2: ldloc.s V_4
				L_00d4: ldloc.0 
				L_00d5: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00da: pop 
				L_00db: ldloc.s V_7
				L_00dd: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00e2: brtrue.s L_0091
				L_00e4: leave L_019c
				L_00e9: ldloc.s V_7
				L_00eb: isinst System.IDisposable
				L_00f0: stloc.s V_8
				L_00f2: ldloc.s V_8
				L_00f4: brfalse.s L_00fd
				L_00f6: ldloc.s V_8
				L_00f8: callvirt System.IDisposable::Void Dispose()
				L_00fd: endfinally 
				L_00fe: ldloc.3 
				L_00ff: ldc.i4.0 
				L_0100: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0105: castclass System.Windows.Forms.MenuItem
				L_010a: stloc.2 
				L_010b: ldloc.s V_4
				L_010d: ldc.i4.0 
				L_010e: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0113: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0118: stloc.1 
				L_0119: ldloc.3 
				L_011a: ldc.i4.0 
				L_011b: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_0120: ldloc.s V_4
				L_0122: ldc.i4.0 
				L_0123: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_0128: ldloc.2 
				L_0129: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_012e: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_0133: stloc.s V_7
				L_0135: br.s L_017c
				L_0137: ldloc.s V_7
				L_0139: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_013e: castclass System.Windows.Forms.MenuItem
				L_0143: stloc.s V_6
				L_0145: ldarg.0 
				L_0146: ldloc.s V_6
				L_0148: call Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd010ef1851698a47(System.Windows.Forms.MenuItem)
				L_014d: stloc.0 
				L_014e: ldloc.1 
				L_014f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0154: ldloc.0 
				L_0155: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_015a: pop 
				L_015b: ldloc.s V_6
				L_015d: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_0162: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_0167: ldc.i4.0 
				L_0168: ble.s L_017c
				L_016a: ldloc.3 
				L_016b: ldloc.s V_6
				L_016d: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0172: pop 
				L_0173: ldloc.s V_4
				L_0175: ldloc.0 
				L_0176: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_017b: pop 
				L_017c: ldloc.s V_7
				L_017e: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0183: brtrue.s L_0137
				L_0185: leave.s L_019c
				L_0187: ldloc.s V_7
				L_0189: isinst System.IDisposable
				L_018e: stloc.s V_8
				L_0190: ldloc.s V_8
				L_0192: brfalse.s L_019b
				L_0194: ldloc.s V_8
				L_0196: callvirt System.IDisposable::Void Dispose()
				L_019b: endfinally 
				L_019c: ldloc.3 
				L_019d: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_01a2: ldc.i4.0 
				L_01a3: bgt L_00fe
				L_01a8: ret 
			*/
			
			
			{
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				x5f4b657f68f87baa x5f4b657f68f87baa2;
				MenuItem menuItem1;
				if (this.x946d4396b0c9cde4 == null)
				{
					return;
				}
				if (this.x5486200f56f78413 == null)
				{
					this.x5486200f56f78413 = new x3c41176af7e54b01 (base.xdc87e2b99332cd4a);
				}
				if ((this.x946d4396b0c9cde4.RightToLeft & System.Windows.Forms.RightToLeft.Inherit) == System.Windows.Forms.RightToLeft.Inherit)
				{
					this.x5486200f56f78413.RightToLeft = base.x42f4c234c9358072.RightToLeft;
				}
				else
				{
					this.x5486200f56f78413.RightToLeft = this.x946d4396b0c9cde4.RightToLeft;
				}
				this.x5486200f56f78413.x6ef5a4a9a9587cfd.Clear ();
				ArrayList arrayList1 = new ArrayList ();
				ArrayList arrayList2 = new ArrayList ();
				foreach (MenuItem menuItem2 in this.x946d4396b0c9cde4.MenuItems)
				{
					x5f4b657f68f87baa1 = this.xd010ef1851698a47 (menuItem2);
					x5f4b657f68f87baa x5f4b657f68f87baa3 = this.x5486200f56f78413.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
					if (menuItem2.MenuItems.Count > 0)
					{
						int i1 = arrayList1.Add (menuItem2);
						int i2 = arrayList2.Add (x5f4b657f68f87baa1);
					}
				}
				while (arrayList1.Count > 0)
				{
					menuItem1 = ((MenuItem) arrayList1[0]);
					x5f4b657f68f87baa2 = ((x5f4b657f68f87baa) arrayList2[0]);
					arrayList1.RemoveAt (0);
					arrayList2.RemoveAt (0);
					foreach (MenuItem menuItem3 in menuItem1.MenuItems)
					{
						x5f4b657f68f87baa1 = this.xd010ef1851698a47 (menuItem3);
						x5f4b657f68f87baa x5f4b657f68f87baa4 = x5f4b657f68f87baa2.MenuCommands.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
						if (menuItem3.MenuItems.Count > 0)
						{
							int i3 = arrayList1.Add (menuItem3);
							int i4 = arrayList2.Add (x5f4b657f68f87baa1);
						}
					}
				}
			}
			
			private void x7ca6c09f91bb596a ()
			
			/*
				// Code Size: 238 Bytes
				.maxstack 4
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_0023 to L_0065 finally L_0065 to L_007a
				.try L_0082 to L_00d8 finally L_00d8 to L_00ed
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaintChild()
				L_0006: brfalse L_00ed
				L_000b: newobj System.Collections.ArrayList::Void .ctor()
				L_0010: stloc.0 
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.Form x42f4c234c9358072
				L_0017: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_001c: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_0021: stloc.s V_4
				L_0023: br.s L_005a
				L_0025: ldloc.s V_4
				L_0027: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_002c: castclass System.Windows.Forms.Control
				L_0031: stloc.1 
				L_0032: ldloc.1 
				L_0033: isinst System.Windows.Forms.MdiClient
				L_0038: brtrue.s L_005a
				L_003a: ldarg.0 
				L_003b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0040: ldloc.1 
				L_0041: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0046: box System.IntPtr
				L_004b: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0050: brtrue.s L_005a
				L_0052: ldloc.0 
				L_0053: ldloc.1 
				L_0054: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0059: pop 
				L_005a: ldloc.s V_4
				L_005c: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0061: brtrue.s L_0025
				L_0063: leave.s L_007a
				L_0065: ldloc.s V_4
				L_0067: isinst System.IDisposable
				L_006c: stloc.s V_5
				L_006e: ldloc.s V_5
				L_0070: brfalse.s L_0079
				L_0072: ldloc.s V_5
				L_0074: callvirt System.IDisposable::Void Dispose()
				L_0079: endfinally 
				L_007a: ldloc.0 
				L_007b: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0080: stloc.s V_4
				L_0082: br.s L_00cd
				L_0084: ldloc.s V_4
				L_0086: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_008b: castclass System.Windows.Forms.Control
				L_0090: stloc.2 
				L_0091: ldarg.0 
				L_0092: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0097: ldloc.2 
				L_0098: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_009d: box System.IntPtr
				L_00a2: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_00a7: brtrue.s L_00cd
				L_00a9: ldloc.2 
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b0: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00b5: stloc.3 
				L_00b6: ldarg.0 
				L_00b7: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_00bc: ldloc.2 
				L_00bd: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00c2: box System.IntPtr
				L_00c7: ldloc.3 
				L_00c8: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_00cd: ldloc.s V_4
				L_00cf: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00d4: brtrue.s L_0084
				L_00d6: leave.s L_00ed
				L_00d8: ldloc.s V_4
				L_00da: isinst System.IDisposable
				L_00df: stloc.s V_5
				L_00e1: ldloc.s V_5
				L_00e3: brfalse.s L_00ec
				L_00e5: ldloc.s V_5
				L_00e7: callvirt System.IDisposable::Void Dispose()
				L_00ec: endfinally 
				L_00ed: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				if (! this.CanPaintChild)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in base.x42f4c234c9358072.Controls)
				{
					if ((! (control1 is MdiClient)) && (! base.x84603c7eff1953af.ContainsKey (control1.Handle)))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! base.x84603c7eff1953af.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, base.xdc87e2b99332cd4a);
						base.x84603c7eff1953af.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			private void xbd90dc5580ff6562 (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			private void xbe3f57786c90d37f ()
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brfalse.s L_001e
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_000e: brfalse.s L_001e
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0016: brfalse.s L_001e
				L_0018: ldarg.0 
				L_0019: call Sunisoft.IrisSkin.xa427f1b2281f554b::Void xe09f26c14e176ef5()
				L_001e: ret 
			*/
			
			
			{
				if ((this.CanPaint && (this.x5486200f56f78413 != null)) && (this.x946d4396b0c9cde4 != null))
				{
					this.xe09f26c14e176ef5 ();
				}
			}
			
			private x5f4b657f68f87baa xd010ef1851698a47 (MenuItem xccb63ca5f63dc470)
			
			/*
				// Code Size: 33 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0)
				L_0000: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor()
				L_0005: stloc.0 
				L_0006: ldloc.0 
				L_0007: ldarg.1 
				L_0008: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_AttachedMenuItem(System.Windows.Forms.MenuItem)
				L_000d: ldloc.0 
				L_000e: ldarg.0 
				L_000f: ldftn Sunisoft.IrisSkin.xa427f1b2281f554b::Void xe26186777e7e0508(System.Object, System.EventArgs)
				L_0015: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_001a: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void add_Click(System.EventHandler)
				L_001f: ldloc.0 
				L_0020: ret 
			*/
			
			
			{
				x5f4b657f68f87baa x5f4b657f68f87baa1 = new x5f4b657f68f87baa ();
				x5f4b657f68f87baa1.AttachedMenuItem = xccb63ca5f63dc470;
				x5f4b657f68f87baa1.Click += new EventHandler (this.xe26186777e7e0508);
				return x5f4b657f68f87baa1;
			}
			
			private void xe08c104b24ddae95 (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 85 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Control V_0, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_1)
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaintChild()
				L_0006: brfalse.s L_0054
				L_0008: ldarg.2 
				L_0009: callvirt System.Windows.Forms.ControlEventArgs::System.Windows.Forms.Control get_Control()
				L_000e: stloc.0 
				L_000f: ldloc.0 
				L_0010: isinst System.Windows.Forms.MdiClient
				L_0015: brfalse.s L_0018
				L_0017: ret 
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_001e: ldloc.0 
				L_001f: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0024: box System.IntPtr
				L_0029: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_002e: brtrue.s L_0054
				L_0030: ldloc.0 
				L_0031: ldarg.0 
				L_0032: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0037: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_003c: stloc.1 
				L_003d: ldarg.0 
				L_003e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0043: ldloc.0 
				L_0044: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0049: box System.IntPtr
				L_004e: ldloc.1 
				L_004f: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0054: ret 
			*/
			
			
			{
				if (! this.CanPaintChild)
				{
					return;
				}
				Control control1 = xfbf34718e704c6bc.Control;
				if ((control1 is MdiClient) || base.x84603c7eff1953af.ContainsKey (control1.Handle))
				{
					return;
				}
				xbd3f2493841f18a1 xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control1, base.xdc87e2b99332cd4a);
				base.x84603c7eff1953af.Add (control1.Handle, xbd3f2493841f18a1_1);
			}
			
			private void xe09f26c14e176ef5 ()
			
			/*
				// Code Size: 329 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1, 
         System.Windows.Forms.MenuItem V_2, 
         System.Collections.ArrayList V_3, 
         System.Collections.ArrayList V_4, 
         System.Windows.Forms.MenuItem V_5, 
         System.Windows.Forms.MenuItem V_6, 
         System.Collections.IEnumerator V_7, 
         System.IDisposable V_8)
				.try L_002f to L_0089 finally L_0089 to L_009e
				.try L_00d5 to L_0127 finally L_0127 to L_013c
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_000b: callvirt System.Collections.CollectionBase::Void Clear()
				L_0010: newobj System.Collections.ArrayList::Void .ctor()
				L_0015: stloc.3 
				L_0016: newobj System.Collections.ArrayList::Void .ctor()
				L_001b: stloc.s V_4
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::System.Windows.Forms.MainMenu x946d4396b0c9cde4
				L_0023: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_0028: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_002d: stloc.s V_7
				L_002f: br.s L_007b
				L_0031: ldloc.s V_7
				L_0033: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0038: castclass System.Windows.Forms.MenuItem
				L_003d: stloc.s V_5
				L_003f: ldarg.0 
				L_0040: ldloc.s V_5
				L_0042: call Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd010ef1851698a47(System.Windows.Forms.MenuItem)
				L_0047: stloc.0 
				L_0048: ldarg.0 
				L_0049: ldfld Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5486200f56f78413
				L_004e: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0053: ldloc.0 
				L_0054: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0059: pop 
				L_005a: ldloc.s V_5
				L_005c: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_0061: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_0066: ldc.i4.0 
				L_0067: ble.s L_007b
				L_0069: ldloc.3 
				L_006a: ldloc.s V_5
				L_006c: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0071: pop 
				L_0072: ldloc.s V_4
				L_0074: ldloc.0 
				L_0075: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_007a: pop 
				L_007b: ldloc.s V_7
				L_007d: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0082: brtrue.s L_0031
				L_0084: leave L_013c
				L_0089: ldloc.s V_7
				L_008b: isinst System.IDisposable
				L_0090: stloc.s V_8
				L_0092: ldloc.s V_8
				L_0094: brfalse.s L_009d
				L_0096: ldloc.s V_8
				L_0098: callvirt System.IDisposable::Void Dispose()
				L_009d: endfinally 
				L_009e: ldloc.3 
				L_009f: ldc.i4.0 
				L_00a0: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_00a5: castclass System.Windows.Forms.MenuItem
				L_00aa: stloc.2 
				L_00ab: ldloc.s V_4
				L_00ad: ldc.i4.0 
				L_00ae: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_00b3: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_00b8: stloc.1 
				L_00b9: ldloc.3 
				L_00ba: ldc.i4.0 
				L_00bb: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_00c0: ldloc.s V_4
				L_00c2: ldc.i4.0 
				L_00c3: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_00c8: ldloc.2 
				L_00c9: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_00ce: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_00d3: stloc.s V_7
				L_00d5: br.s L_011c
				L_00d7: ldloc.s V_7
				L_00d9: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00de: castclass System.Windows.Forms.MenuItem
				L_00e3: stloc.s V_6
				L_00e5: ldarg.0 
				L_00e6: ldloc.s V_6
				L_00e8: call Sunisoft.IrisSkin.xa427f1b2281f554b::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd010ef1851698a47(System.Windows.Forms.MenuItem)
				L_00ed: stloc.0 
				L_00ee: ldloc.1 
				L_00ef: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_00f4: ldloc.0 
				L_00f5: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_00fa: pop 
				L_00fb: ldloc.s V_6
				L_00fd: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_0102: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_0107: ldc.i4.0 
				L_0108: ble.s L_011c
				L_010a: ldloc.3 
				L_010b: ldloc.s V_6
				L_010d: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0112: pop 
				L_0113: ldloc.s V_4
				L_0115: ldloc.0 
				L_0116: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_011b: pop 
				L_011c: ldloc.s V_7
				L_011e: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0123: brtrue.s L_00d7
				L_0125: leave.s L_013c
				L_0127: ldloc.s V_7
				L_0129: isinst System.IDisposable
				L_012e: stloc.s V_8
				L_0130: ldloc.s V_8
				L_0132: brfalse.s L_013b
				L_0134: ldloc.s V_8
				L_0136: callvirt System.IDisposable::Void Dispose()
				L_013b: endfinally 
				L_013c: ldloc.3 
				L_013d: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0142: ldc.i4.0 
				L_0143: bgt L_009e
				L_0148: ret 
			*/
			
			
			{
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				x5f4b657f68f87baa x5f4b657f68f87baa2;
				MenuItem menuItem1;
				this.x5486200f56f78413.x6ef5a4a9a9587cfd.Clear ();
				ArrayList arrayList1 = new ArrayList ();
				ArrayList arrayList2 = new ArrayList ();
				foreach (MenuItem menuItem2 in this.x946d4396b0c9cde4.MenuItems)
				{
					x5f4b657f68f87baa1 = this.xd010ef1851698a47 (menuItem2);
					x5f4b657f68f87baa x5f4b657f68f87baa3 = this.x5486200f56f78413.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
					if (menuItem2.MenuItems.Count > 0)
					{
						int i1 = arrayList1.Add (menuItem2);
						int i2 = arrayList2.Add (x5f4b657f68f87baa1);
					}
				}
				while (arrayList1.Count > 0)
				{
					menuItem1 = ((MenuItem) arrayList1[0]);
					x5f4b657f68f87baa2 = ((x5f4b657f68f87baa) arrayList2[0]);
					arrayList1.RemoveAt (0);
					arrayList2.RemoveAt (0);
					foreach (MenuItem menuItem3 in menuItem1.MenuItems)
					{
						x5f4b657f68f87baa1 = this.xd010ef1851698a47 (menuItem3);
						x5f4b657f68f87baa x5f4b657f68f87baa4 = x5f4b657f68f87baa2.MenuCommands.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
						if (menuItem3.MenuItems.Count > 0)
						{
							int i3 = arrayList1.Add (menuItem3);
							int i4 = arrayList2.Add (x5f4b657f68f87baa1);
						}
					}
				}
			}
			
			private void xe26186777e7e0508 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0)
				L_0000: ldarg.1 
				L_0001: isinst Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0006: brfalse.s L_0022
				L_0008: ldarg.1 
				L_0009: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_000e: stloc.0 
				L_000f: ldloc.0 
				L_0010: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem get_AttachedMenuItem()
				L_0015: brfalse.s L_0022
				L_0017: ldloc.0 
				L_0018: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem get_AttachedMenuItem()
				L_001d: callvirt System.Windows.Forms.MenuItem::Void PerformClick()
				L_0022: ret 
			*/
			
			
			{
				if (! (xe0292b9ed559da7d is x5f4b657f68f87baa))
				{
					return;
				}
				x5f4b657f68f87baa x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) xe0292b9ed559da7d);
				if (x5f4b657f68f87baa1.AttachedMenuItem != null)
				{
					x5f4b657f68f87baa1.AttachedMenuItem.PerformClick ();
				}
			}
			
		#endregion
	}
	
}

