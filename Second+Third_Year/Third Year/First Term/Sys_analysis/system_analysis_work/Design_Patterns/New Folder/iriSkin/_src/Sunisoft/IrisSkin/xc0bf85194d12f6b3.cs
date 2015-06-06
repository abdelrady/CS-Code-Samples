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
		
	internal class xc0bf85194d12f6b3 : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private BorderStyle xacfbd7a08ba56c78;
		#endregion
		
		#region Constructors
		
			public xc0bf85194d12f6b3 (Control control, ISkinEngine engine)
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
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.0 
					L_0001: ret 
				*/
				
				{
					return 0;
				}
			}
			
			
			protected override bool ChangeBackColor
			
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
			
			
			protected override bool PaintBorder
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Boolean get_PaintBorder()
					L_0006: ret 
				*/
				
				{
					return base.PaintBorder;
				}
			}
			
			
			protected override bool PaintBorderLine
			
			{
				get
				
				/*
					// Code Size: 24 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.TreeView V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: castclass System.Windows.Forms.TreeView
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: callvirt System.Windows.Forms.TreeView::System.Windows.Forms.BorderStyle get_BorderStyle()
					L_0012: brtrue.s L_0016
					L_0014: ldc.i4.0 
					L_0015: ret 
					L_0016: ldc.i4.1 
					L_0017: ret 
				*/
				
				{
					TreeView treeView1 = ((TreeView) base.xcd9cdf30888d2204);
					if (treeView1.BorderStyle != BorderStyle.None)
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
				.locals (System.Windows.Forms.TreeView V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000c: ldarg.0 
				L_000d: ldftn Sunisoft.IrisSkin.xc0bf85194d12f6b3::Void x9d36565e6d24455f(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0013: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_0018: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0023: castclass System.Windows.Forms.TreeView
				L_0028: stloc.0 
				L_0029: ldarg.0 
				L_002a: ldloc.0 
				L_002b: callvirt System.Windows.Forms.TreeView::System.Windows.Forms.BorderStyle get_BorderStyle()
				L_0030: stfld Sunisoft.IrisSkin.xc0bf85194d12f6b3::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xc0bf85194d12f6b3::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_003b: brfalse.s L_004c
				L_003d: ldarg.0 
				L_003e: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0043: brfalse.s L_004c
				L_0045: ldloc.0 
				L_0046: ldc.i4.1 
				L_0047: callvirt System.Windows.Forms.TreeView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_004c: ret 
			*/
			
			
			{
				base.DoInit ();
				((SkinEngine) base.xdc87e2b99332cd4a).CurrentSkinChanged += new SkinChanged (this.x9d36565e6d24455f);
				TreeView treeView1 = ((TreeView) base.xcd9cdf30888d2204);
				this.xacfbd7a08ba56c78 = treeView1.BorderStyle;
				if ((this.xacfbd7a08ba56c78 != BorderStyle.None) && base.xf2140268ef7ddbf7)
				{
					treeView1.BorderStyle = BorderStyle.FixedSingle;
				}
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
			
			private void x9d36565e6d24455f (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 63 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.TreeView V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_000b: brfalse.s L_000e
				L_000d: ret 
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0014: castclass System.Windows.Forms.TreeView
				L_0019: stloc.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xc0bf85194d12f6b3::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0020: brfalse.s L_003e
				L_0022: ldarg.0 
				L_0023: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0028: brfalse.s L_0032
				L_002a: ldloc.0 
				L_002b: ldc.i4.1 
				L_002c: callvirt System.Windows.Forms.TreeView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_0031: ret 
				L_0032: ldloc.0 
				L_0033: ldarg.0 
				L_0034: ldfld Sunisoft.IrisSkin.xc0bf85194d12f6b3::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0039: callvirt System.Windows.Forms.TreeView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_003e: ret 
			*/
			
			
			{
				if (base.xcd9cdf30888d2204.IsDisposed)
				{
					return;
				}
				TreeView treeView1 = ((TreeView) base.xcd9cdf30888d2204);
				if (this.xacfbd7a08ba56c78 != BorderStyle.None)
				{
					if (base.xf2140268ef7ddbf7)
					{
						treeView1.BorderStyle = BorderStyle.FixedSingle;
					}
					else
					{
						treeView1.BorderStyle = this.xacfbd7a08ba56c78;
					}
				}
			}
			
		#endregion
	}
	
}

