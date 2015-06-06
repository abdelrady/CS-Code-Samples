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
		
	internal class xf3f6919ac5d158dc
	
	{
		
		#region Constructors
		
			public xf3f6919ac5d158dc ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static xbd3f2493841f18a1 xebcf83b00134300b (Control x43bec302f92080b9, ISkinEngine xcab6a0e662ada486)
			
			/*
				// Code Size: 375 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: isinst System.Windows.Forms.Label
				L_0006: brfalse.s L_0010
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: newobj Sunisoft.IrisSkin.x2d2ded96c91a7f0f::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_000f: ret 
				L_0010: ldarg.0 
				L_0011: isinst System.Windows.Forms.Button
				L_0016: brfalse.s L_0020
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: newobj Sunisoft.IrisSkin.xead0c12c344036e3::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: isinst System.Windows.Forms.CheckBox
				L_0026: brfalse.s L_0030
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: newobj Sunisoft.IrisSkin.x896bb4cf7b29301a::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_002f: ret 
				L_0030: ldarg.0 
				L_0031: isinst System.Windows.Forms.RadioButton
				L_0036: brfalse.s L_0040
				L_0038: ldarg.0 
				L_0039: ldarg.1 
				L_003a: newobj Sunisoft.IrisSkin.xfe25d236d92b80ed::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_003f: ret 
				L_0040: ldarg.0 
				L_0041: isinst System.Windows.Forms.ScrollBar
				L_0046: brfalse.s L_0050
				L_0048: ldarg.0 
				L_0049: ldarg.1 
				L_004a: newobj Sunisoft.IrisSkin.x41d32e77872302c5::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_004f: ret 
				L_0050: ldarg.0 
				L_0051: isinst System.Windows.Forms.TextBox
				L_0056: brfalse.s L_0060
				L_0058: ldarg.0 
				L_0059: ldarg.1 
				L_005a: newobj Sunisoft.IrisSkin.x3e6caec60640904a::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_005f: ret 
				L_0060: ldarg.0 
				L_0061: isinst System.Windows.Forms.RichTextBox
				L_0066: brfalse.s L_0070
				L_0068: ldarg.0 
				L_0069: ldarg.1 
				L_006a: newobj Sunisoft.IrisSkin.x3e6caec60640904a::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_006f: ret 
				L_0070: ldarg.0 
				L_0071: isinst System.Windows.Forms.TrackBar
				L_0076: brfalse.s L_0080
				L_0078: ldarg.0 
				L_0079: ldarg.1 
				L_007a: newobj Sunisoft.IrisSkin.x422d5afcba1397d3::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_007f: ret 
				L_0080: ldarg.0 
				L_0081: isinst System.Windows.Forms.ProgressBar
				L_0086: brfalse.s L_0090
				L_0088: ldarg.0 
				L_0089: ldarg.1 
				L_008a: newobj Sunisoft.IrisSkin.xc3d08931d227ebfe::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_008f: ret 
				L_0090: ldarg.0 
				L_0091: isinst System.Windows.Forms.NumericUpDown
				L_0096: brfalse.s L_00a0
				L_0098: ldarg.0 
				L_0099: ldarg.1 
				L_009a: newobj Sunisoft.IrisSkin.x2ada8799c851d3c1::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_009f: ret 
				L_00a0: ldarg.0 
				L_00a1: isinst System.Windows.Forms.TabPage
				L_00a6: brfalse.s L_00b0
				L_00a8: ldarg.0 
				L_00a9: ldarg.1 
				L_00aa: newobj Sunisoft.IrisSkin.xbd3f2493841f18a1::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00af: ret 
				L_00b0: ldarg.0 
				L_00b1: isinst System.Windows.Forms.Panel
				L_00b6: brfalse.s L_00c0
				L_00b8: ldarg.0 
				L_00b9: ldarg.1 
				L_00ba: newobj Sunisoft.IrisSkin.x3a157e8c7a942ff8::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00bf: ret 
				L_00c0: ldarg.0 
				L_00c1: isinst System.Windows.Forms.ListView
				L_00c6: brfalse.s L_00d0
				L_00c8: ldarg.0 
				L_00c9: ldarg.1 
				L_00ca: newobj Sunisoft.IrisSkin.x1d3c48e32d645589::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00cf: ret 
				L_00d0: ldarg.0 
				L_00d1: isinst System.Windows.Forms.ComboBox
				L_00d6: brfalse.s L_00e0
				L_00d8: ldarg.0 
				L_00d9: ldarg.1 
				L_00da: newobj Sunisoft.IrisSkin.xd8e48d4d4b6a016e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00df: ret 
				L_00e0: ldarg.0 
				L_00e1: isinst System.Windows.Forms.ListBox
				L_00e6: brfalse.s L_00f0
				L_00e8: ldarg.0 
				L_00e9: ldarg.1 
				L_00ea: newobj Sunisoft.IrisSkin.x467f7b62900802c7::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00ef: ret 
				L_00f0: ldarg.0 
				L_00f1: isinst System.Windows.Forms.TabControl
				L_00f6: brfalse.s L_0100
				L_00f8: ldarg.0 
				L_00f9: ldarg.1 
				L_00fa: newobj Sunisoft.IrisSkin.x97d171718e5c7e7f::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00ff: ret 
				L_0100: ldarg.0 
				L_0101: isinst System.Windows.Forms.DateTimePicker
				L_0106: brfalse.s L_0110
				L_0108: ldarg.0 
				L_0109: ldarg.1 
				L_010a: newobj Sunisoft.IrisSkin.x6a7aef305e9ce97d::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_010f: ret 
				L_0110: ldarg.0 
				L_0111: isinst System.Windows.Forms.GroupBox
				L_0116: brfalse.s L_0120
				L_0118: ldarg.0 
				L_0119: ldarg.1 
				L_011a: newobj Sunisoft.IrisSkin.x77a19d75b4e98e57::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_011f: ret 
				L_0120: ldarg.0 
				L_0121: isinst System.Windows.Forms.TreeView
				L_0126: brfalse.s L_0130
				L_0128: ldarg.0 
				L_0129: ldarg.1 
				L_012a: newobj Sunisoft.IrisSkin.xc0bf85194d12f6b3::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_012f: ret 
				L_0130: ldarg.0 
				L_0131: isinst System.Windows.Forms.DataGrid
				L_0136: brfalse.s L_0140
				L_0138: ldarg.0 
				L_0139: ldarg.1 
				L_013a: newobj Sunisoft.IrisSkin.x0e2bf2da454c077f::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_013f: ret 
				L_0140: ldarg.0 
				L_0141: isinst System.Windows.Forms.ToolBar
				L_0146: brfalse.s L_0150
				L_0148: ldarg.0 
				L_0149: ldarg.1 
				L_014a: newobj Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_014f: ret 
				L_0150: ldarg.0 
				L_0151: isinst System.Windows.Forms.StatusBar
				L_0156: brfalse.s L_0160
				L_0158: ldarg.0 
				L_0159: ldarg.1 
				L_015a: newobj Sunisoft.IrisSkin.xba6d4b6ba4628dd2::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_015f: ret 
				L_0160: ldarg.1 
				L_0161: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_Enable3rdControl()
				L_0166: brfalse.s L_016f
				L_0168: ldarg.0 
				L_0169: ldarg.1 
				L_016a: call Sunisoft.IrisSkin.xe352b8686e1d5ecf::Void xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_016f: ldarg.0 
				L_0170: ldarg.1 
				L_0171: newobj Sunisoft.IrisSkin.xbd32ddd20be31ef9::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0176: ret 
			*/
			
			
			{
				if (x43bec302f92080b9 is Label)
				{
					return new x2d2ded96c91a7f0f (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is Button)
				{
					return new xead0c12c344036e3 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is CheckBox)
				{
					return new x896bb4cf7b29301a (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is RadioButton)
				{
					return new xfe25d236d92b80ed (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ScrollBar)
				{
					return new x41d32e77872302c5 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is TextBox)
				{
					return new x3e6caec60640904a (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is RichTextBox)
				{
					return new x3e6caec60640904a (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is TrackBar)
				{
					return new x422d5afcba1397d3 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ProgressBar)
				{
					return new xc3d08931d227ebfe (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is NumericUpDown)
				{
					return new x2ada8799c851d3c1 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is TabPage)
				{
					return new xbd3f2493841f18a1 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is Panel)
				{
					return new x3a157e8c7a942ff8 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ListView)
				{
					return new x1d3c48e32d645589 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ComboBox)
				{
					return new xd8e48d4d4b6a016e (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ListBox)
				{
					return new x467f7b62900802c7 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is TabControl)
				{
					return new x97d171718e5c7e7f (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is DateTimePicker)
				{
					return new x6a7aef305e9ce97d (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is GroupBox)
				{
					return new x77a19d75b4e98e57 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is TreeView)
				{
					return new xc0bf85194d12f6b3 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is DataGrid)
				{
					return new x0e2bf2da454c077f (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is ToolBar)
				{
					return new xac9a4b8f6325d7e3 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else if (x43bec302f92080b9 is StatusBar)
				{
					return new xba6d4b6ba4628dd2 (x43bec302f92080b9, xcab6a0e662ada486);
				}
				else
				{
					if (((SkinEngine) xcab6a0e662ada486).Enable3rdControl)
					{
						xe352b8686e1d5ecf.xebcf83b00134300b (x43bec302f92080b9, xcab6a0e662ada486);
					}
					return new xbd32ddd20be31ef9 (x43bec302f92080b9, xcab6a0e662ada486);
				}
			}
			
		#endregion
	}
	
}

