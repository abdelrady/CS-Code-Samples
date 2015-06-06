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
			using System.ComponentModel;
			using System.Drawing;
			using System.Drawing.Drawing2D;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	[ToolboxItemAttribute(false)]
	internal class xa1883d0b59b7005b
	
	{
		
		#region Fields
			private DrawItemEventHandler x2a5f0003704e39da;
			private MeasureItemEventHandler x60e3b5f01780bd33;
			private static Pen x8eaf2b1854fb0bf6;
			private ISkinEngine xcab6a0e662ada486;
			private Menu xcbf78b15dd820156;
			private static Brush xd4d28a8f36023ad0;
			protected static ImageList xfeae2ed797ae6fbc;
		#endregion
		
		#region Constructors
		
			public xa1883d0b59b7005b (ISkinEngine engine, Menu menu)
			/*
				// Code Size: 85 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_000d: ldarg.0 
				L_000e: ldarg.2 
				L_000f: stfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.Menu xcbf78b15dd820156
				L_0014: ldarg.2 
				L_0015: brtrue.s L_0018
				L_0017: ret 
				L_0018: ldarg.0 
				L_0019: ldarg.0 
				L_001a: ldftn Sunisoft.IrisSkin.xa1883d0b59b7005b::Void x763e46f2422fcb86(System.Object, System.Windows.Forms.MeasureItemEventArgs)
				L_0020: newobj System.Windows.Forms.MeasureItemEventHandler::Void .ctor(System.Object, IntPtr)
				L_0025: stfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.MeasureItemEventHandler x60e3b5f01780bd33
				L_002a: ldarg.0 
				L_002b: ldarg.0 
				L_002c: ldftn Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xd590f29a688f99d2(System.Object, System.Windows.Forms.DrawItemEventArgs)
				L_0032: newobj System.Windows.Forms.DrawItemEventHandler::Void .ctor(System.Object, IntPtr)
				L_0037: stfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.DrawItemEventHandler x2a5f0003704e39da
				L_003c: ldarg.0 
				L_003d: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void x5d04f127bbb82004()
				L_0042: ldarg.1 
				L_0043: ldarg.0 
				L_0044: ldftn Sunisoft.IrisSkin.xa1883d0b59b7005b::Void x9a0949aaa2f0a885(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_004a: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_004f: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_0054: ret 
			*/
			
			static xa1883d0b59b7005b ()
			/*
				// Code Size: 92 Bytes
				.maxstack 7
				L_0000: ldc.i4 132
				L_0005: ldc.i4 130
				L_000a: ldc.i4 132
				L_000f: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_0014: ldc.r4 1
				L_0019: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_001e: stsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Drawing.Pen x8eaf2b1854fb0bf6
				L_0023: call System.Drawing.Color::System.Drawing.Color get_Gray()
				L_0028: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_002d: stsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Drawing.Brush xd4d28a8f36023ad0
				L_0032: ldstr "Sunisoft.IrisSkin.SkinEngine"
				L_0037: call System.Type::System.Type GetType(System.String)
				L_003c: ldstr "Sunisoft.IrisSkin.ImagesPopupMenu.bmp"
				L_0041: ldc.i4.s 16
				L_0043: ldc.i4.s 16
				L_0045: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_004a: ldc.i4.0 
				L_004b: ldc.i4.0 
				L_004c: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0051: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Windows.Forms.ImageList xd1601e45c3cc2056(System.Type, System.String, System.Drawing.Size, System.Drawing.Point)
				L_0056: stsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_005b: ret 
			*/
		#endregion
		
		#region Properties
		
			public Menu xbc9a1cbeed95c3fc
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.Menu xcbf78b15dd820156
					L_0006: ret 
				*/
				
				{
					return this.xcbf78b15dd820156;
				}
			}
			
			
			private bool xf2140268ef7ddbf7
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
					L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_000b: ret 
				*/
				
				{
					return ((SkinEngine) this.xcab6a0e662ada486).RealActive;
				}
			}
			
		#endregion
		
		#region Methods
		
			private void x5d04f127bbb82004 ()
			
			/*
				// Code Size: 274 Bytes
				.maxstack 4
				.locals (System.Boolean V_0, 
         System.Collections.ArrayList V_1, 
         System.Collections.ArrayList V_2, 
         System.Windows.Forms.MenuItem V_3, 
         System.Windows.Forms.MenuItem V_4, 
         System.Windows.Forms.MenuItem V_5, 
         System.Collections.IEnumerator V_6, 
         System.IDisposable V_7)
				.try L_0025 to L_006c finally L_006c to L_0081
				.try L_00a2 to L_00e6 finally L_00e6 to L_00fb
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Boolean get_xf2140268ef7ddbf7()
				L_0006: stloc.0 
				L_0007: newobj System.Collections.ArrayList::Void .ctor()
				L_000c: stloc.1 
				L_000d: newobj System.Collections.ArrayList::Void .ctor()
				L_0012: stloc.2 
				L_0013: ldarg.0 
				L_0014: call Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.Menu get_xbc9a1cbeed95c3fc()
				L_0019: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_001e: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_0023: stloc.s V_6
				L_0025: br.s L_005e
				L_0027: ldloc.s V_6
				L_0029: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_002e: castclass System.Windows.Forms.MenuItem
				L_0033: stloc.s V_4
				L_0035: ldloc.s V_4
				L_0037: ldloc.0 
				L_0038: callvirt System.Windows.Forms.MenuItem::Void set_OwnerDraw(Boolean)
				L_003d: ldloc.2 
				L_003e: ldloc.s V_4
				L_0040: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0045: pop 
				L_0046: ldloc.s V_4
				L_0048: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_004d: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_0052: ldc.i4.0 
				L_0053: ble.s L_005e
				L_0055: ldloc.1 
				L_0056: ldloc.s V_4
				L_0058: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_005d: pop 
				L_005e: ldloc.s V_6
				L_0060: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0065: brtrue.s L_0027
				L_0067: leave L_00fb
				L_006c: ldloc.s V_6
				L_006e: isinst System.IDisposable
				L_0073: stloc.s V_7
				L_0075: ldloc.s V_7
				L_0077: brfalse.s L_0080
				L_0079: ldloc.s V_7
				L_007b: callvirt System.IDisposable::Void Dispose()
				L_0080: endfinally 
				L_0081: ldloc.1 
				L_0082: ldc.i4.0 
				L_0083: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0088: castclass System.Windows.Forms.MenuItem
				L_008d: stloc.3 
				L_008e: ldloc.1 
				L_008f: ldc.i4.0 
				L_0090: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_0095: ldloc.3 
				L_0096: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_009b: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_00a0: stloc.s V_6
				L_00a2: br.s L_00db
				L_00a4: ldloc.s V_6
				L_00a6: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00ab: castclass System.Windows.Forms.MenuItem
				L_00b0: stloc.s V_5
				L_00b2: ldloc.s V_5
				L_00b4: ldloc.0 
				L_00b5: callvirt System.Windows.Forms.MenuItem::Void set_OwnerDraw(Boolean)
				L_00ba: ldloc.2 
				L_00bb: ldloc.s V_5
				L_00bd: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00c2: pop 
				L_00c3: ldloc.s V_5
				L_00c5: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_00ca: callvirt System.Windows.Forms.Menu+MenuItemCollection::Int32 get_Count()
				L_00cf: ldc.i4.0 
				L_00d0: ble.s L_00db
				L_00d2: ldloc.1 
				L_00d3: ldloc.s V_5
				L_00d5: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00da: pop 
				L_00db: ldloc.s V_6
				L_00dd: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00e2: brtrue.s L_00a4
				L_00e4: leave.s L_00fb
				L_00e6: ldloc.s V_6
				L_00e8: isinst System.IDisposable
				L_00ed: stloc.s V_7
				L_00ef: ldloc.s V_7
				L_00f1: brfalse.s L_00fa
				L_00f3: ldloc.s V_7
				L_00f5: callvirt System.IDisposable::Void Dispose()
				L_00fa: endfinally 
				L_00fb: ldloc.1 
				L_00fc: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0101: ldc.i4.0 
				L_0102: bgt L_0081
				L_0107: ldloc.0 
				L_0108: brfalse.s L_0111
				L_010a: ldarg.0 
				L_010b: ldloc.2 
				L_010c: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void x76f955f9fcce00c1(System.Collections.ArrayList)
				L_0111: ret 
			*/
			
			
			{
				MenuItem menuItem1;
				bool b1 = this.xf2140268ef7ddbf7;
				ArrayList arrayList1 = new ArrayList ();
				ArrayList arrayList2 = new ArrayList ();
				foreach (MenuItem menuItem2 in this.xbc9a1cbeed95c3fc.MenuItems)
				{
					menuItem2.OwnerDraw = b1;
					int i1 = arrayList2.Add (menuItem2);
					if (menuItem2.MenuItems.Count > 0)
					{
						int i2 = arrayList1.Add (menuItem2);
					}
				}
				while (arrayList1.Count > 0)
				{
					menuItem1 = ((MenuItem) arrayList1[0]);
					arrayList1.RemoveAt (0);
					foreach (MenuItem menuItem3 in menuItem1.MenuItems)
					{
						menuItem3.OwnerDraw = b1;
						int i3 = arrayList2.Add (menuItem3);
						if (menuItem3.MenuItems.Count > 0)
						{
							int i4 = arrayList1.Add (menuItem3);
						}
					}
				}
				if (b1)
				{
					this.x76f955f9fcce00c1 (arrayList2);
				}
			}
			
			private void x763e46f2422fcb86 (object xe0292b9ed559da7d, MeasureItemEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 324 Bytes
				.maxstack 6
				.locals (System.Windows.Forms.MenuItem V_0, 
         System.Drawing.Font V_1, 
         System.Drawing.SizeF V_2, 
         System.Boolean V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Windows.Forms.MenuItem V_6, 
         System.Collections.IEnumerator V_7, 
         System.Drawing.SizeF V_8, 
         System.IDisposable V_9)
				.try L_00b3 to L_010d finally L_010d to L_0122
				L_0000: ldarg.1 
				L_0001: isinst System.Windows.Forms.MenuItem
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: brtrue.s L_000b
				L_000a: ret 
				L_000b: ldloc.0 
				L_000c: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Menu get_Parent()
				L_0011: isinst System.Windows.Forms.MainMenu
				L_0016: brtrue.s L_0025
				L_0018: ldloc.0 
				L_0019: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Menu get_Parent()
				L_001e: isinst System.Windows.Forms.ContextMenu
				L_0023: brfalse.s L_0033
				L_0025: ldarg.2 
				L_0026: ldc.i4.0 
				L_0027: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemHeight(Int32)
				L_002c: ldarg.2 
				L_002d: ldc.i4.0 
				L_002e: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemWidth(Int32)
				L_0033: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font xfc84e4da153943c2()
				L_0038: stloc.1 
				L_0039: ldarg.2 
				L_003a: callvirt System.Windows.Forms.MeasureItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_003f: ldloc.0 
				L_0040: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
				L_0045: ldloc.1 
				L_0046: ldc.i4.0 
				L_0047: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat get_x33298d8984e76949()
				L_004c: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font, Int32, System.Drawing.StringFormat)
				L_0051: stloc.2 
				L_0052: ldloc.0 
				L_0053: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
				L_0058: ldstr "-"
				L_005d: call System.String::Boolean op_Equality(System.String, System.String)
				L_0062: brfalse.s L_006d
				L_0064: ldarg.2 
				L_0065: ldc.i4.5 
				L_0066: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemHeight(Int32)
				L_006b: br.s L_007d
				L_006d: ldarg.2 
				L_006e: ldloca.s V_2
				L_0070: call System.Drawing.SizeF::Single get_Height()
				L_0075: conv.i4 
				L_0076: ldc.i4.5 
				L_0077: add 
				L_0078: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemHeight(Int32)
				L_007d: ldarg.2 
				L_007e: ldloca.s V_2
				L_0080: call System.Drawing.SizeF::Single get_Width()
				L_0085: conv.i4 
				L_0086: ldc.i4.s 33
				L_0088: add 
				L_0089: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemWidth(Int32)
				L_008e: ldc.i4.0 
				L_008f: stloc.3 
				L_0090: ldc.i4.0 
				L_0091: stloc.s V_4
				L_0093: ldc.i4.0 
				L_0094: stloc.s V_5
				L_0096: ldloc.0 
				L_0097: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Menu get_Parent()
				L_009c: brfalse L_0122
				L_00a1: ldloc.0 
				L_00a2: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Menu get_Parent()
				L_00a7: callvirt System.Windows.Forms.Menu::MenuItemCollection get_MenuItems()
				L_00ac: callvirt System.Windows.Forms.Menu+MenuItemCollection::System.Collections.IEnumerator GetEnumerator()
				L_00b1: stloc.s V_7
				L_00b3: br.s L_0102
				L_00b5: ldloc.s V_7
				L_00b7: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00bc: castclass System.Windows.Forms.MenuItem
				L_00c1: stloc.s V_6
				L_00c3: ldloc.s V_6
				L_00c5: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Shortcut get_Shortcut()
				L_00ca: brfalse.s L_0102
				L_00cc: ldc.i4.1 
				L_00cd: stloc.3 
				L_00ce: ldarg.2 
				L_00cf: callvirt System.Windows.Forms.MeasureItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_00d4: ldloc.s V_6
				L_00d6: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Shortcut get_Shortcut()
				L_00db: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.String x75256eedb834b2e3(System.Windows.Forms.Shortcut)
				L_00e0: ldloc.1 
				L_00e1: ldc.i4.0 
				L_00e2: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat get_x5d48aae543c10712()
				L_00e7: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font, Int32, System.Drawing.StringFormat)
				L_00ec: stloc.s V_8
				L_00ee: ldloca.s V_8
				L_00f0: call System.Drawing.SizeF::Single get_Width()
				L_00f5: conv.i4 
				L_00f6: stloc.s V_4
				L_00f8: ldloc.s V_5
				L_00fa: ldloc.s V_4
				L_00fc: bge.s L_0102
				L_00fe: ldloc.s V_4
				L_0100: stloc.s V_5
				L_0102: ldloc.s V_7
				L_0104: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0109: brtrue.s L_00b5
				L_010b: leave.s L_0122
				L_010d: ldloc.s V_7
				L_010f: isinst System.IDisposable
				L_0114: stloc.s V_9
				L_0116: ldloc.s V_9
				L_0118: brfalse.s L_0121
				L_011a: ldloc.s V_9
				L_011c: callvirt System.IDisposable::Void Dispose()
				L_0121: endfinally 
				L_0122: ldloc.3 
				L_0123: brfalse.s L_0143
				L_0125: ldarg.2 
				L_0126: dup 
				L_0127: callvirt System.Windows.Forms.MeasureItemEventArgs::Int32 get_ItemWidth()
				L_012c: ldloc.s V_5
				L_012e: add 
				L_012f: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemWidth(Int32)
				L_0134: ldarg.2 
				L_0135: dup 
				L_0136: callvirt System.Windows.Forms.MeasureItemEventArgs::Int32 get_ItemWidth()
				L_013b: ldc.i4.s 10
				L_013d: add 
				L_013e: callvirt System.Windows.Forms.MeasureItemEventArgs::Void set_ItemWidth(Int32)
				L_0143: ret 
			*/
			
			
			{
				MenuItem menuItem1 = (xe0292b9ed559da7d as MenuItem);
				if (menuItem1 == null)
				{
					return;
				}
				if ((menuItem1.Parent is MainMenu) || (menuItem1.Parent is ContextMenu))
				{
					xfbf34718e704c6bc.ItemHeight = 0;
					xfbf34718e704c6bc.ItemWidth = 0;
				}
				Font font1 = x448fd9ab43628c71.xfc84e4da153943c2 ();
				SizeF sizeF1 = xfbf34718e704c6bc.Graphics.MeasureString (menuItem1.Text, font1, 0, x448fd9ab43628c71.x33298d8984e76949);
				switch (menuItem1.Text)
				{
					case "-":
					
					{
							xfbf34718e704c6bc.ItemHeight = 5;
							break;
					}
					default:
					
					{
							xfbf34718e704c6bc.ItemHeight = (((int) sizeF1.Height) + 5);
							break;
					}
				}
				xfbf34718e704c6bc.ItemWidth = ((int) (((int) sizeF1.Width) + 33));
				bool b1 = false;
				int i1 = 0;
				int i2 = 0;
				if (menuItem1.Parent != null)
				{
					foreach (MenuItem menuItem2 in menuItem1.Parent.MenuItems)
					{
						if (menuItem2.Shortcut != Shortcut.None)
						{
							b1 = true;
							i1 = ((int) xfbf34718e704c6bc.Graphics.MeasureString (x448fd9ab43628c71.x75256eedb834b2e3 (menuItem2.Shortcut), font1, 0, x448fd9ab43628c71.x5d48aae543c10712).Width);
							if (i2 >= i1)
							{
								continue;
							}
							i2 = i1;
						}
					}
				}
				if (b1)
				{
					xfbf34718e704c6bc.ItemWidth += i2;
					xfbf34718e704c6bc.ItemWidth += 10;
				}
			}
			
			private void x76f955f9fcce00c1 (ArrayList xf8b54ce7724a27f2)
			
			/*
				// Code Size: 82 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.MenuItem V_0, 
         System.Object V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0007 to L_0040 finally L_0040 to L_0051
				L_0000: ldarg.1 
				L_0001: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0006: stloc.2 
				L_0007: br.s L_0036
				L_0009: ldloc.2 
				L_000a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_000f: stloc.1 
				L_0010: ldloc.1 
				L_0011: castclass System.Windows.Forms.MenuItem
				L_0016: stloc.0 
				L_0017: ldloc.0 
				L_0018: ldc.i4.1 
				L_0019: callvirt System.Windows.Forms.MenuItem::Void set_OwnerDraw(Boolean)
				L_001e: ldloc.0 
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.MeasureItemEventHandler x60e3b5f01780bd33
				L_0025: callvirt System.Windows.Forms.MenuItem::Void add_MeasureItem(System.Windows.Forms.MeasureItemEventHandler)
				L_002a: ldloc.0 
				L_002b: ldarg.0 
				L_002c: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.DrawItemEventHandler x2a5f0003704e39da
				L_0031: callvirt System.Windows.Forms.MenuItem::Void add_DrawItem(System.Windows.Forms.DrawItemEventHandler)
				L_0036: ldloc.2 
				L_0037: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_003c: brtrue.s L_0009
				L_003e: leave.s L_0051
				L_0040: ldloc.2 
				L_0041: isinst System.IDisposable
				L_0046: stloc.3 
				L_0047: ldloc.3 
				L_0048: brfalse.s L_0050
				L_004a: ldloc.3 
				L_004b: callvirt System.IDisposable::Void Dispose()
				L_0050: endfinally 
				L_0051: ret 
			*/
			
			
			{
				MenuItem menuItem1;
				foreach (object object1 in xf8b54ce7724a27f2)
				{
					menuItem1 = ((MenuItem) object1);
					menuItem1.OwnerDraw = true;
					menuItem1.MeasureItem += this.x60e3b5f01780bd33;
					menuItem1.DrawItem += this.x2a5f0003704e39da;
				}
			}
			
			private void x9a0949aaa2f0a885 (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void x5d04f127bbb82004()
				L_0006: ret 
			*/
			
			
			{
				this.x5d04f127bbb82004 ();
			}
			
			public static void xc5cb8635e76bb6f9 (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Brush xd8f1949f8950238a)
			
			/*
				// Code Size: 61 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0)
				L_0000: ldarg.2 
				L_0001: ldc.r4 1
				L_0006: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldloc.0 
				L_000e: ldarga.s x26545669838eb36e
				L_0010: call System.Drawing.Rectangle::Int32 get_Right()
				L_0015: ldarga.s x26545669838eb36e
				L_0017: call System.Drawing.Rectangle::Int32 get_Left()
				L_001c: ldarga.s x26545669838eb36e
				L_001e: call System.Drawing.Rectangle::Int32 get_Top()
				L_0023: ldarga.s x26545669838eb36e
				L_0025: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_002a: ldc.i4.1 
				L_002b: sub 
				L_002c: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0031: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0036: ldloc.0 
				L_0037: callvirt System.Drawing.Pen::Void Dispose()
				L_003c: ret 
			*/
			
			
			{
				Pen pen1 = new Pen (xd8f1949f8950238a, 1F);
				x4b101060f4767186.DrawRectangle (pen1, Rectangle.FromLTRB (x26545669838eb36e.Right, x26545669838eb36e.Left, x26545669838eb36e.Top, ((int) (x26545669838eb36e.Bottom - 1))));
				pen1.Dispose ();
			}
			
			public static void xca84da6b0681dc08 (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Pen x9c79b5ad7b769b12, int x5a7437364c6578fa)
			
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.2 
				L_0002: ldarga.s x26545669838eb36e
				L_0004: call System.Drawing.Rectangle::Int32 get_Left()
				L_0009: ldarg.3 
				L_000a: add 
				L_000b: ldc.i4.4 
				L_000c: add 
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0014: ldc.i4.2 
				L_0015: add 
				L_0016: ldarga.s x26545669838eb36e
				L_0018: call System.Drawing.Rectangle::Int32 get_Right()
				L_001d: ldc.i4.2 
				L_001e: sub 
				L_001f: ldarga.s x26545669838eb36e
				L_0021: call System.Drawing.Rectangle::Int32 get_Top()
				L_0026: ldc.i4.2 
				L_0027: add 
				L_0028: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_002d: ret 
			*/
			
			
			{
				x4b101060f4767186.DrawLine (x9c79b5ad7b769b12, ((int) ((x26545669838eb36e.Left + x5a7437364c6578fa) + 4)), ((int) (x26545669838eb36e.Top + 2)), ((int) (x26545669838eb36e.Right - 2)), ((int) (x26545669838eb36e.Top + 2)));
			}
			
			public static void xcc14d110d5ae549a (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Brush xd8f1949f8950238a)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.2 
				L_0002: ldarg.1 
				L_0003: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0008: ret 
			*/
			
			
			{
				x4b101060f4767186.FillRectangle (xd8f1949f8950238a, x26545669838eb36e);
			}
			
			private void xd590f29a688f99d2 (object xe0292b9ed559da7d, DrawItemEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 1111 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.MenuItem V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Brush V_3, 
         System.Drawing.Drawing2D.LinearGradientBrush V_4, 
         System.Drawing.Drawing2D.LinearGradientBrush V_5, 
         System.Drawing.Image V_6, 
         System.Windows.Forms.ContextMenu V_7)
				.try L_00cd to L_00dd finally L_00dd to L_00e9
				.try L_024a to L_025a finally L_025a to L_0266
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Boolean get_xf2140268ef7ddbf7()
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.1 
				L_000a: isinst System.Windows.Forms.MenuItem
				L_000f: stloc.0 
				L_0010: ldloc.0 
				L_0011: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Menu get_Parent()
				L_0016: isinst System.Windows.Forms.MainMenu
				L_001b: brfalse.s L_001e
				L_001d: ret 
				L_001e: ldloc.0 
				L_001f: brtrue.s L_0022
				L_0021: ret 
				L_0022: ldarg.2 
				L_0023: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Rectangle get_Bounds()
				L_0028: stloc.2 
				L_0029: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font xfc84e4da153943c2()
				L_002e: pop 
				L_002f: ldloc.0 
				L_0030: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
				L_0035: ldstr "-"
				L_003a: call System.String::Boolean op_Equality(System.String, System.String)
				L_003f: brfalse L_0164
				L_0044: ldloca.s V_2
				L_0046: call System.Drawing.Rectangle::Int32 get_Left()
				L_004b: ldloca.s V_2
				L_004d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0052: ldloca.s V_2
				L_0054: call System.Drawing.Rectangle::Int32 get_Left()
				L_0059: ldc.i4.s 26
				L_005b: add 
				L_005c: ldloca.s V_2
				L_005e: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0063: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0068: stloc.1 
				L_0069: ldarg.0 
				L_006a: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_006f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0074: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0079: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_007e: ldarg.0 
				L_007f: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0084: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0089: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_008e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_0093: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0098: brfalse.s L_00e9
				L_009a: ldloc.1 
				L_009b: ldarg.0 
				L_009c: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_00a1: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00a6: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00ab: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_00b0: ldarg.0 
				L_00b1: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_00b6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00bb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00c0: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_00c5: ldc.i4.0 
				L_00c6: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_00cb: stloc.s V_4
				L_00cd: ldarg.2 
				L_00ce: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_00d3: ldloc.s V_4
				L_00d5: ldloc.1 
				L_00d6: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00db: leave.s L_010a
				L_00dd: ldloc.s V_4
				L_00df: brfalse.s L_00e8
				L_00e1: ldloc.s V_4
				L_00e3: callvirt System.IDisposable::Void Dispose()
				L_00e8: endfinally 
				L_00e9: ldarg.2 
				L_00ea: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_00ef: ldloc.1 
				L_00f0: ldarg.0 
				L_00f1: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_00f6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00fb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0100: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_0105: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xcc14d110d5ae549a(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_010a: ldloca.s V_2
				L_010c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0111: ldc.i4.s 26
				L_0113: add 
				L_0114: ldloca.s V_2
				L_0116: call System.Drawing.Rectangle::Int32 get_Top()
				L_011b: ldloca.s V_2
				L_011d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0122: ldloca.s V_2
				L_0124: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0129: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_012e: stloc.1 
				L_012f: ldarg.2 
				L_0130: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0135: ldloc.1 
				L_0136: ldarg.0 
				L_0137: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_013c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0141: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0146: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMCOLOR()
				L_014b: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xcc14d110d5ae549a(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_0150: ldarg.2 
				L_0151: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0156: ldloc.2 
				L_0157: ldsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Drawing.Pen x8eaf2b1854fb0bf6
				L_015c: ldc.i4.s 26
				L_015e: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xca84da6b0681dc08(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Pen, Int32)
				L_0163: ret 
				L_0164: ldarg.2 
				L_0165: callvirt System.Windows.Forms.DrawItemEventArgs::System.Windows.Forms.DrawItemState get_State()
				L_016a: ldc.i4.1 
				L_016b: and 
				L_016c: ldc.i4.1 
				L_016d: bne.un.s L_01c1
				L_016f: ldarg.2 
				L_0170: callvirt System.Windows.Forms.DrawItemEventArgs::System.Windows.Forms.DrawItemState get_State()
				L_0175: ldc.i4.4 
				L_0176: and 
				L_0177: ldc.i4.4 
				L_0178: beq.s L_01c1
				L_017a: ldarg.2 
				L_017b: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0180: ldloc.2 
				L_0181: ldarg.0 
				L_0182: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0187: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_018c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0191: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_SELECTEDMENUCOLOR()
				L_0196: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xcc14d110d5ae549a(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_019b: ldarg.2 
				L_019c: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_01a1: ldloc.2 
				L_01a2: ldarg.0 
				L_01a3: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_01a8: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01ad: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_01b2: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_SELECTEDMENUBORDERCOLOR()
				L_01b7: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xc5cb8635e76bb6f9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_01bc: br L_02cd
				L_01c1: ldloca.s V_2
				L_01c3: call System.Drawing.Rectangle::Int32 get_Left()
				L_01c8: ldloca.s V_2
				L_01ca: call System.Drawing.Rectangle::Int32 get_Top()
				L_01cf: ldloca.s V_2
				L_01d1: call System.Drawing.Rectangle::Int32 get_Left()
				L_01d6: ldc.i4.s 26
				L_01d8: add 
				L_01d9: ldloca.s V_2
				L_01db: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01e0: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_01e5: stloc.1 
				L_01e6: ldarg.0 
				L_01e7: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_01ec: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01f1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_01f6: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_01fb: ldarg.0 
				L_01fc: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0201: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0206: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_020b: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_0210: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0215: brfalse.s L_0266
				L_0217: ldloc.1 
				L_0218: ldarg.0 
				L_0219: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_021e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0223: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0228: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_022d: ldarg.0 
				L_022e: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0233: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0238: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_023d: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_0242: ldc.i4.0 
				L_0243: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_0248: stloc.s V_5
				L_024a: ldarg.2 
				L_024b: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0250: ldloc.s V_5
				L_0252: ldloc.1 
				L_0253: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0258: leave.s L_0287
				L_025a: ldloc.s V_5
				L_025c: brfalse.s L_0265
				L_025e: ldloc.s V_5
				L_0260: callvirt System.IDisposable::Void Dispose()
				L_0265: endfinally 
				L_0266: ldarg.2 
				L_0267: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_026c: ldloc.1 
				L_026d: ldarg.0 
				L_026e: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0273: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0278: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_027d: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_0282: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xcc14d110d5ae549a(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_0287: ldloca.s V_2
				L_0289: call System.Drawing.Rectangle::Int32 get_Left()
				L_028e: ldc.i4.s 26
				L_0290: add 
				L_0291: ldloca.s V_2
				L_0293: call System.Drawing.Rectangle::Int32 get_Top()
				L_0298: ldloca.s V_2
				L_029a: call System.Drawing.Rectangle::Int32 get_Right()
				L_029f: ldloca.s V_2
				L_02a1: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02a6: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02ab: stloc.1 
				L_02ac: ldarg.2 
				L_02ad: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_02b2: ldloc.1 
				L_02b3: ldarg.0 
				L_02b4: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_02b9: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02be: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_02c3: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMCOLOR()
				L_02c8: call Sunisoft.IrisSkin.xa1883d0b59b7005b::Void xcc14d110d5ae549a(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush)
				L_02cd: ldarg.2 
				L_02ce: callvirt System.Windows.Forms.DrawItemEventArgs::System.Windows.Forms.DrawItemState get_State()
				L_02d3: ldc.i4.4 
				L_02d4: and 
				L_02d5: ldc.i4.4 
				L_02d6: beq.s L_0313
				L_02d8: ldarg.2 
				L_02d9: callvirt System.Windows.Forms.DrawItemEventArgs::System.Windows.Forms.DrawItemState get_State()
				L_02de: ldc.i4.1 
				L_02df: and 
				L_02e0: ldc.i4.1 
				L_02e1: bne.un.s L_02fb
				L_02e3: ldarg.0 
				L_02e4: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_02e9: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02ee: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_02f3: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_SELECTEDMENUFONTCOLOR()
				L_02f8: stloc.3 
				L_02f9: br.s L_0319
				L_02fb: ldarg.0 
				L_02fc: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0301: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0306: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_030b: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMFONTCOLOR()
				L_0310: stloc.3 
				L_0311: br.s L_0319
				L_0313: ldsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Drawing.Brush xd4d28a8f36023ad0
				L_0318: stloc.3 
				L_0319: ldarg.2 
				L_031a: callvirt System.Windows.Forms.DrawItemEventArgs::System.Windows.Forms.DrawItemState get_State()
				L_031f: ldc.i4.s 32
				L_0321: and 
				L_0322: ldc.i4.s 32
				L_0324: pop 
				L_0325: pop 
				L_0326: ldloc.0 
				L_0327: callvirt System.Windows.Forms.MenuItem::Boolean get_Checked()
				L_032c: brfalse.s L_037c
				L_032e: ldloc.0 
				L_032f: callvirt System.Windows.Forms.MenuItem::Boolean get_RadioCheck()
				L_0334: brfalse.s L_034a
				L_0336: ldsfld Sunisoft.IrisSkin.xa1883d0b59b7005b::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_033b: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0340: ldc.i4.1 
				L_0341: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0346: stloc.s V_6
				L_0348: br.s L_0361
				L_034a: ldarg.0 
				L_034b: ldfld Sunisoft.IrisSkin.xa1883d0b59b7005b::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0350: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0355: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_035a: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_CHECKEDMENUICON()
				L_035f: stloc.s V_6
				L_0361: ldarg.2 
				L_0362: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0367: ldloc.s V_6
				L_0369: ldloca.s V_2
				L_036b: call System.Drawing.Rectangle::Int32 get_X()
				L_0370: ldloca.s V_2
				L_0372: call System.Drawing.Rectangle::Int32 get_Y()
				L_0377: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_037c: ldloca.s V_2
				L_037e: call System.Drawing.Rectangle::Int32 get_Left()
				L_0383: ldc.i4.s 30
				L_0385: add 
				L_0386: ldloca.s V_2
				L_0388: call System.Drawing.Rectangle::Int32 get_Top()
				L_038d: ldloca.s V_2
				L_038f: call System.Drawing.Rectangle::Int32 get_Right()
				L_0394: ldloca.s V_2
				L_0396: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_039b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03a0: stloc.1 
				L_03a1: ldloc.0 
				L_03a2: callvirt System.Windows.Forms.Menu::System.Windows.Forms.ContextMenu GetContextMenu()
				L_03a7: stloc.s V_7
				L_03a9: ldloc.s V_7
				L_03ab: brfalse.s L_03de
				L_03ad: ldloc.s V_7
				L_03af: callvirt System.Windows.Forms.ContextMenu::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_03b4: ldc.i4.1 
				L_03b5: and 
				L_03b6: ldc.i4.1 
				L_03b7: bne.un.s L_03de
				L_03b9: ldarg.2 
				L_03ba: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_03bf: ldloc.0 
				L_03c0: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
				L_03c5: ldarg.2 
				L_03c6: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Font get_Font()
				L_03cb: ldloc.3 
				L_03cc: ldloc.1 
				L_03cd: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_03d2: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat get_x0c71f394477b252a()
				L_03d7: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_03dc: br.s L_0401
				L_03de: ldarg.2 
				L_03df: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_03e4: ldloc.0 
				L_03e5: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
				L_03ea: ldarg.2 
				L_03eb: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Font get_Font()
				L_03f0: ldloc.3 
				L_03f1: ldloc.1 
				L_03f2: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_03f7: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat get_x33298d8984e76949()
				L_03fc: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0401: ldloc.0 
				L_0402: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Shortcut get_Shortcut()
				L_0407: brfalse.s L_0456
				L_0409: ldloca.s V_2
				L_040b: call System.Drawing.Rectangle::Int32 get_Left()
				L_0410: ldloca.s V_2
				L_0412: call System.Drawing.Rectangle::Int32 get_Top()
				L_0417: ldloca.s V_2
				L_0419: call System.Drawing.Rectangle::Int32 get_Right()
				L_041e: ldc.i4.s 10
				L_0420: sub 
				L_0421: ldloca.s V_2
				L_0423: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0428: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_042d: stloc.1 
				L_042e: ldarg.2 
				L_042f: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Graphics get_Graphics()
				L_0434: ldloc.0 
				L_0435: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Shortcut get_Shortcut()
				L_043a: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.String x75256eedb834b2e3(System.Windows.Forms.Shortcut)
				L_043f: ldarg.2 
				L_0440: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Font get_Font()
				L_0445: ldloc.3 
				L_0446: ldloc.1 
				L_0447: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_044c: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat get_x5d48aae543c10712()
				L_0451: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0456: ret 
			*/
			
			
			{
				MenuItem menuItem1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Brush brush1;
				Image image1;
				ContextMenu contextMenu1;
				if (! this.xf2140268ef7ddbf7)
				{
					return;
				}
				menuItem1 = (xe0292b9ed559da7d as MenuItem);
				if ((menuItem1.Parent is MainMenu) || (menuItem1 == null))
				{
					return;
				}
				rectangle2 = xfbf34718e704c6bc.Bounds;
				Font font1 = x448fd9ab43628c71.xfc84e4da153943c2 ();
				if (menuItem1.Text != "-")
				{
					if (((xfbf34718e704c6bc.State & DrawItemState.Selected) != DrawItemState.Selected) || ((xfbf34718e704c6bc.State & DrawItemState.Disabled) == DrawItemState.Disabled))
					{
						rectangle1 = Rectangle.FromLTRB (rectangle2.Left, rectangle2.Top, ((int) (rectangle2.Left + 26)), rectangle2.Bottom);
						if (((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (rectangle1, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR, LinearGradientMode.Horizontal))
							{
								xfbf34718e704c6bc.Graphics.FillRectangle (((Brush) linearGradientBrush2), rectangle1);
								goto L_0287;
							}
						}
						xa1883d0b59b7005b.xcc14d110d5ae549a (xfbf34718e704c6bc.Graphics, rectangle1, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR);
						goto L_0287;
					}
					else
					{
						xa1883d0b59b7005b.xcc14d110d5ae549a (xfbf34718e704c6bc.Graphics, rectangle2, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_SELECTEDMENUCOLOR);
						xa1883d0b59b7005b.xc5cb8635e76bb6f9 (xfbf34718e704c6bc.Graphics, rectangle2, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_SELECTEDMENUBORDERCOLOR);
						goto L_02CD;
					}
				}
				rectangle1 = Rectangle.FromLTRB (rectangle2.Left, rectangle2.Top, ((int) (rectangle2.Left + 26)), rectangle2.Bottom);
				if (((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR)
				{
					using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (rectangle1, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR, LinearGradientMode.Horizontal))
					{
						xfbf34718e704c6bc.Graphics.FillRectangle (((Brush) linearGradientBrush1), rectangle1);
						goto L_010A;
					}
				}
				xa1883d0b59b7005b.xcc14d110d5ae549a (xfbf34718e704c6bc.Graphics, rectangle1, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR);
				
			L_010A:
				
				{
				}
				rectangle1 = Rectangle.FromLTRB (((int) (rectangle2.Left + 26)), rectangle2.Top, rectangle2.Right, rectangle2.Bottom);
				xa1883d0b59b7005b.xcc14d110d5ae549a (xfbf34718e704c6bc.Graphics, rectangle1, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_MENUITEMCOLOR);
				xa1883d0b59b7005b.xca84da6b0681dc08 (xfbf34718e704c6bc.Graphics, rectangle2, xa1883d0b59b7005b.x8eaf2b1854fb0bf6, 26);
				return;
				
			L_0287:
				
				{
				}
				rectangle1 = Rectangle.FromLTRB (((int) (rectangle2.Left + 26)), rectangle2.Top, rectangle2.Right, rectangle2.Bottom);
				xa1883d0b59b7005b.xcc14d110d5ae549a (xfbf34718e704c6bc.Graphics, rectangle1, ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_MENUITEMCOLOR);
				
			L_02CD:
				
				{
				}
				if ((xfbf34718e704c6bc.State & DrawItemState.Disabled) == DrawItemState.Disabled)
				{
					brush1 = xa1883d0b59b7005b.xd4d28a8f36023ad0;
				}
				else if ((xfbf34718e704c6bc.State & DrawItemState.Selected) == DrawItemState.Selected)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_SELECTEDMENUFONTCOLOR;
				}
				else
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Brushes).SKIN2_MENUITEMFONTCOLOR;
				}
				DrawItemState drawItemState1 = (xfbf34718e704c6bc.State & DrawItemState.Default);
				if (menuItem1.Checked)
				{
					if (menuItem1.RadioCheck)
					{
						image1 = xa1883d0b59b7005b.xfeae2ed797ae6fbc.Images[1];
					}
					else
					{
						image1 = ((Image) ((SkinBitmaps) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Bitmaps).SKIN2_CHECKEDMENUICON);
					}
					xfbf34718e704c6bc.Graphics.DrawImageUnscaled (image1, rectangle2.X, rectangle2.Y);
				}
				rectangle1 = Rectangle.FromLTRB (((int) (rectangle2.Left + 30)), rectangle2.Top, rectangle2.Right, rectangle2.Bottom);
				contextMenu1 = menuItem1.GetContextMenu ();
				if ((contextMenu1 != null) && ((contextMenu1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes))
				{
					xfbf34718e704c6bc.Graphics.DrawString (menuItem1.Text, xfbf34718e704c6bc.Font, brush1, ((RectangleF) rectangle1), x448fd9ab43628c71.x0c71f394477b252a);
				}
				else
				{
					xfbf34718e704c6bc.Graphics.DrawString (menuItem1.Text, xfbf34718e704c6bc.Font, brush1, ((RectangleF) rectangle1), x448fd9ab43628c71.x33298d8984e76949);
				}
				if (menuItem1.Shortcut != Shortcut.None)
				{
					rectangle1 = Rectangle.FromLTRB (rectangle2.Left, rectangle2.Top, ((int) (rectangle2.Right - 10)), rectangle2.Bottom);
					xfbf34718e704c6bc.Graphics.DrawString (x448fd9ab43628c71.x75256eedb834b2e3 (menuItem1.Shortcut), xfbf34718e704c6bc.Font, brush1, ((RectangleF) rectangle1), x448fd9ab43628c71.x5d48aae543c10712);
				}
			}
			
		#endregion
	}
	
}

