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
			
			
		#endregion
		
	internal class x6106db8218fc38c0
	
	{
		
		#region Fields
			public static int x311e7a92306d7199;
		#endregion
		
		#region Constructors
		
			public x6106db8218fc38c0 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
			
			static x6106db8218fc38c0 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldc.i4.0 
				L_0001: stsfld Sunisoft.IrisSkin.x6106db8218fc38c0::Int32 x311e7a92306d7199
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static void x718df7700a5c2d4d (int x8a41fbc87a3fb305)
			
			/*
				// Code Size: 2270 Bytes
				.maxstack 4
				.locals (System.String V_0, 
         System.UInt32 V_1)
				L_0000: ldstr ""
				L_0005: stloc.0 
				L_0006: ldarg.0 
				L_0007: stloc.1 
				L_0008: ldloc.1 
				L_0009: ldc.i4 61536
				L_000e: bgt.un L_02d5
				L_0013: ldloc.1 
				L_0014: ldc.i4 534
				L_0019: bgt.un L_0260
				L_001e: ldloc.1 
				L_001f: ldc.i4 173
				L_0024: bgt.un L_0134
				L_0029: ldloc.1 
				L_002a: switch (L_039d, L_03a8, L_03b3, L_03be, L_08af, L_03c9, L_03d4, L_03df, L_03ea, L_08af, L_03f5, L_0400, L_040b, L_0416, L_0421, L_042c, L_0437, L_0442, L_0463, L_044d, L_046e, L_0479, L_0458, L_08af, L_0484, L_08af, L_048f, L_049a, L_04a5, L_04b0, L_04bb, L_04c6, L_04d1, L_04dc, L_04e7, L_04f2)
				L_00bf: ldloc.1 
				L_00c0: ldc.i4 129
				L_00c5: sub 
				L_00c6: switch (L_06aa, L_06b5, L_06c0, L_06cb, L_06d6, L_06e1, L_06ec, L_06f7)
				L_00eb: ldloc.1 
				L_00ec: ldc.i4 160
				L_00f1: sub 
				L_00f2: switch (L_0702, L_070d, L_0718, L_0723, L_072e, L_0739, L_0744, L_074f, L_075a, L_0765, L_08af, L_0770, L_077b, L_0786)
				L_012f: br L_08af
				L_0134: ldloc.1 
				L_0135: ldc.i4 255
				L_013a: sub 
				L_013b: switch (L_0791, L_079c, L_07a7, L_07b2, L_07bd, L_07c8, L_07d3, L_07de, L_07e9, L_08af, L_07f4, L_08af, L_08af, L_08af, L_080a, L_0815, L_0820, L_04fd, L_0508, L_0513, L_051e, L_0529, L_0534, L_053f, L_054a, L_08af, L_08af, L_08af, L_08af, L_08af, L_08af, L_08af, L_0555, L_0560, L_056b, L_0576, L_0581, L_058c, L_0597, L_05a2, L_05ad, L_05b8, L_05c3, L_08af, L_08af, L_08af, L_08af, L_08af, L_08af, L_08af, L_08af, L_082b, L_0836, L_0841, L_084c, L_0857, L_085f, L_0867)
				L_0228: ldloc.1 
				L_0229: ldc.i4 481
				L_022e: beq L_086f
				L_0233: ldloc.1 
				L_0234: ldc.i4 528
				L_0239: sub 
				L_023a: switch (L_0877, L_087f, L_0887, L_088f, L_0897, L_089f, L_08a7)
				L_025b: br L_08af
				L_0260: ldloc.1 
				L_0261: ldc.i4 61472
				L_0266: bgt.un.s L_0297
				L_0268: ldloc.1 
				L_0269: ldc.i4 61440
				L_026e: beq L_05ce
				L_0273: ldloc.1 
				L_0274: ldc.i4 61455
				L_0279: sub 
				L_027a: switch (L_069f, L_05d9)
				L_0287: ldloc.1 
				L_0288: ldc.i4 61472
				L_028d: beq L_05e4
				L_0292: br L_08af
				L_0297: ldloc.1 
				L_0298: ldc.i4 61504
				L_029d: bgt.un.s L_02ba
				L_029f: ldloc.1 
				L_02a0: ldc.i4 61488
				L_02a5: beq L_05ef
				L_02aa: ldloc.1 
				L_02ab: ldc.i4 61504
				L_02b0: beq L_05fa
				L_02b5: br L_08af
				L_02ba: ldloc.1 
				L_02bb: ldc.i4 61520
				L_02c0: beq L_0605
				L_02c5: ldloc.1 
				L_02c6: ldc.i4 61536
				L_02cb: beq L_0610
				L_02d0: br L_08af
				L_02d5: ldloc.1 
				L_02d6: ldc.i4 61728
				L_02db: bgt.un.s L_0331
				L_02dd: ldloc.1 
				L_02de: ldc.i4 61584
				L_02e3: bgt.un.s L_030b
				L_02e5: ldloc.1 
				L_02e6: ldc.i4 61552
				L_02eb: beq L_061b
				L_02f0: ldloc.1 
				L_02f1: ldc.i4 61568
				L_02f6: beq L_0626
				L_02fb: ldloc.1 
				L_02fc: ldc.i4 61584
				L_0301: beq L_0631
				L_0306: br L_08af
				L_030b: ldloc.1 
				L_030c: ldc.i4 61696
				L_0311: beq L_063c
				L_0316: ldloc.1 
				L_0317: ldc.i4 61712
				L_031c: beq L_0647
				L_0321: ldloc.1 
				L_0322: ldc.i4 61728
				L_0327: beq L_0652
				L_032c: br L_08af
				L_0331: ldloc.1 
				L_0332: ldc.i4 61776
				L_0337: bgt.un.s L_035f
				L_0339: ldloc.1 
				L_033a: ldc.i4 61744
				L_033f: beq L_065d
				L_0344: ldloc.1 
				L_0345: ldc.i4 61760
				L_034a: beq L_0668
				L_034f: ldloc.1 
				L_0350: ldc.i4 61776
				L_0355: beq L_0673
				L_035a: br L_08af
				L_035f: ldloc.1 
				L_0360: ldc.i4 61808
				L_0365: bgt.un.s L_0382
				L_0367: ldloc.1 
				L_0368: ldc.i4 61792
				L_036d: beq L_067e
				L_0372: ldloc.1 
				L_0373: ldc.i4 61808
				L_0378: beq L_0689
				L_037d: br L_08af
				L_0382: ldloc.1 
				L_0383: ldc.i4 61824
				L_0388: beq L_0694
				L_038d: ldloc.1 
				L_038e: ldc.i4 65535
				L_0393: beq L_07ff
				L_0398: br L_08af
				L_039d: ldstr "WM_NULL"
				L_03a2: stloc.0 
				L_03a3: br L_08bc
				L_03a8: ldstr "WM_CREATE"
				L_03ad: stloc.0 
				L_03ae: br L_08bc
				L_03b3: ldstr "WM_DESTROY"
				L_03b8: stloc.0 
				L_03b9: br L_08bc
				L_03be: ldstr "WM_MOVE"
				L_03c3: stloc.0 
				L_03c4: br L_08bc
				L_03c9: ldstr "WM_SIZE"
				L_03ce: stloc.0 
				L_03cf: br L_08bc
				L_03d4: ldstr "WM_ACTIVATE"
				L_03d9: stloc.0 
				L_03da: br L_08bc
				L_03df: ldstr "WM_SETFOCUS"
				L_03e4: stloc.0 
				L_03e5: br L_08bc
				L_03ea: ldstr "WM_KILLFOCUS"
				L_03ef: stloc.0 
				L_03f0: br L_08bc
				L_03f5: ldstr "WM_ENABLE"
				L_03fa: stloc.0 
				L_03fb: br L_08bc
				L_0400: ldstr "WM_SETREDRAW"
				L_0405: stloc.0 
				L_0406: br L_08bc
				L_040b: ldstr "WM_SETTEXT"
				L_0410: stloc.0 
				L_0411: br L_08bc
				L_0416: ldstr "WM_GETTEXT"
				L_041b: stloc.0 
				L_041c: br L_08bc
				L_0421: ldstr "WM_GETTEXTLENGTH"
				L_0426: stloc.0 
				L_0427: br L_08bc
				L_042c: ldstr "WM_PAINT"
				L_0431: stloc.0 
				L_0432: br L_08bc
				L_0437: ldstr "WM_CLOSE"
				L_043c: stloc.0 
				L_043d: br L_08bc
				L_0442: ldstr "WM_QUERYENDSESSION"
				L_0447: stloc.0 
				L_0448: br L_08bc
				L_044d: ldstr "WM_QUERYOPEN"
				L_0452: stloc.0 
				L_0453: br L_08bc
				L_0458: ldstr "WM_ENDSESSION"
				L_045d: stloc.0 
				L_045e: br L_08bc
				L_0463: ldstr "WM_QUIT"
				L_0468: stloc.0 
				L_0469: br L_08bc
				L_046e: ldstr "WM_ERASEBKGND"
				L_0473: stloc.0 
				L_0474: br L_08bc
				L_0479: ldstr "WM_SYSCOLORCHANGE"
				L_047e: stloc.0 
				L_047f: br L_08bc
				L_0484: ldstr "WM_SHOWWINDOW"
				L_0489: stloc.0 
				L_048a: br L_08bc
				L_048f: ldstr "WM_WININICHANGE"
				L_0494: stloc.0 
				L_0495: br L_08bc
				L_049a: ldstr "WM_DEVMODECHANGE"
				L_049f: stloc.0 
				L_04a0: br L_08bc
				L_04a5: ldstr "WM_ACTIVATEAPP"
				L_04aa: stloc.0 
				L_04ab: br L_08bc
				L_04b0: ldstr "WM_FONTCHANGE"
				L_04b5: stloc.0 
				L_04b6: br L_08bc
				L_04bb: ldstr "WM_TIMECHANGE"
				L_04c0: stloc.0 
				L_04c1: br L_08bc
				L_04c6: ldstr "WM_CANCELMODE"
				L_04cb: stloc.0 
				L_04cc: br L_08bc
				L_04d1: ldstr "WM_SETCURSOR"
				L_04d6: stloc.0 
				L_04d7: br L_08bc
				L_04dc: ldstr "WM_MOUSEACTIVATE"
				L_04e1: stloc.0 
				L_04e2: br L_08bc
				L_04e7: ldstr "WM_CHILDACTIVATE"
				L_04ec: stloc.0 
				L_04ed: br L_08bc
				L_04f2: ldstr "WM_QUEUESYNC"
				L_04f7: stloc.0 
				L_04f8: br L_08bc
				L_04fd: ldstr "WM_INITDIALOG"
				L_0502: stloc.0 
				L_0503: br L_08bc
				L_0508: ldstr "WM_COMMAND"
				L_050d: stloc.0 
				L_050e: br L_08bc
				L_0513: ldstr "WM_SYSCOMMAND"
				L_0518: stloc.0 
				L_0519: br L_08bc
				L_051e: ldstr "WM_TIMER"
				L_0523: stloc.0 
				L_0524: br L_08bc
				L_0529: ldstr "WM_HSCROLL"
				L_052e: stloc.0 
				L_052f: br L_08bc
				L_0534: ldstr "WM_VSCROLL"
				L_0539: stloc.0 
				L_053a: br L_08bc
				L_053f: ldstr "WM_INITMENU"
				L_0544: stloc.0 
				L_0545: br L_08bc
				L_054a: ldstr "WM_INITMENUPOPUP"
				L_054f: stloc.0 
				L_0550: br L_08bc
				L_0555: ldstr "WM_MENUSELECT"
				L_055a: stloc.0 
				L_055b: br L_08bc
				L_0560: ldstr "WM_MENUCHAR"
				L_0565: stloc.0 
				L_0566: br L_08bc
				L_056b: ldstr "WM_ENTERIDLE"
				L_0570: stloc.0 
				L_0571: br L_08bc
				L_0576: ldstr "WM_MENURBUTTONUP"
				L_057b: stloc.0 
				L_057c: br L_08bc
				L_0581: ldstr "WM_MENUDRAG"
				L_0586: stloc.0 
				L_0587: br L_08bc
				L_058c: ldstr "WM_MENUGETOBJECT"
				L_0591: stloc.0 
				L_0592: br L_08bc
				L_0597: ldstr "WM_UNINITMENUPOPUP"
				L_059c: stloc.0 
				L_059d: br L_08bc
				L_05a2: ldstr "WM_MENUCOMMAND"
				L_05a7: stloc.0 
				L_05a8: br L_08bc
				L_05ad: ldstr "WM_CHANGEUISTATE"
				L_05b2: stloc.0 
				L_05b3: br L_08bc
				L_05b8: ldstr "WM_UPDATEUISTATE"
				L_05bd: stloc.0 
				L_05be: br L_08bc
				L_05c3: ldstr "WM_QUERYUISTATE"
				L_05c8: stloc.0 
				L_05c9: br L_08bc
				L_05ce: ldstr "SC_SIZE"
				L_05d3: stloc.0 
				L_05d4: br L_08bc
				L_05d9: ldstr "SC_MOVE"
				L_05de: stloc.0 
				L_05df: br L_08bc
				L_05e4: ldstr "SC_MINIMIZE"
				L_05e9: stloc.0 
				L_05ea: br L_08bc
				L_05ef: ldstr "SC_MAXIMIZE"
				L_05f4: stloc.0 
				L_05f5: br L_08bc
				L_05fa: ldstr "SC_NEXTWINDOW"
				L_05ff: stloc.0 
				L_0600: br L_08bc
				L_0605: ldstr "SC_PREVWINDOW"
				L_060a: stloc.0 
				L_060b: br L_08bc
				L_0610: ldstr "SC_CLOSE"
				L_0615: stloc.0 
				L_0616: br L_08bc
				L_061b: ldstr "SC_VSCROLL"
				L_0620: stloc.0 
				L_0621: br L_08bc
				L_0626: ldstr "SC_HSCROLL"
				L_062b: stloc.0 
				L_062c: br L_08bc
				L_0631: ldstr "SC_MOUSEMENU"
				L_0636: stloc.0 
				L_0637: br L_08bc
				L_063c: ldstr "SC_KEYMENU"
				L_0641: stloc.0 
				L_0642: br L_08bc
				L_0647: ldstr "SC_ARRANGE"
				L_064c: stloc.0 
				L_064d: br L_08bc
				L_0652: ldstr "SC_RESTORE"
				L_0657: stloc.0 
				L_0658: br L_08bc
				L_065d: ldstr "SC_TASKLIST"
				L_0662: stloc.0 
				L_0663: br L_08bc
				L_0668: ldstr "SC_SCREENSAVE"
				L_066d: stloc.0 
				L_066e: br L_08bc
				L_0673: ldstr "SC_HOTKEY"
				L_0678: stloc.0 
				L_0679: br L_08bc
				L_067e: ldstr "SC_DEFAULT"
				L_0683: stloc.0 
				L_0684: br L_08bc
				L_0689: ldstr "SC_MONITORPOWER"
				L_068e: stloc.0 
				L_068f: br L_08bc
				L_0694: ldstr "SC_CONTEXTHELP"
				L_0699: stloc.0 
				L_069a: br L_08bc
				L_069f: ldstr "SC_SEPARATOR"
				L_06a4: stloc.0 
				L_06a5: br L_08bc
				L_06aa: ldstr "WM_NCCREATE"
				L_06af: stloc.0 
				L_06b0: br L_08bc
				L_06b5: ldstr "WM_NCDESTROY"
				L_06ba: stloc.0 
				L_06bb: br L_08bc
				L_06c0: ldstr "WM_NCCALCSIZE"
				L_06c5: stloc.0 
				L_06c6: br L_08bc
				L_06cb: ldstr "WM_NCHITTEST"
				L_06d0: stloc.0 
				L_06d1: br L_08bc
				L_06d6: ldstr "WM_NCPAINT"
				L_06db: stloc.0 
				L_06dc: br L_08bc
				L_06e1: ldstr "WM_NCACTIVATE"
				L_06e6: stloc.0 
				L_06e7: br L_08bc
				L_06ec: ldstr "WM_GETDLGCODE"
				L_06f1: stloc.0 
				L_06f2: br L_08bc
				L_06f7: ldstr "WM_SYNCPAINT"
				L_06fc: stloc.0 
				L_06fd: br L_08bc
				L_0702: ldstr "WM_NCMOUSEMOVE"
				L_0707: stloc.0 
				L_0708: br L_08bc
				L_070d: ldstr "WM_NCLBUTTONDOWN"
				L_0712: stloc.0 
				L_0713: br L_08bc
				L_0718: ldstr "WM_NCLBUTTONUP"
				L_071d: stloc.0 
				L_071e: br L_08bc
				L_0723: ldstr "WM_NCLBUTTONDBLCLK"
				L_0728: stloc.0 
				L_0729: br L_08bc
				L_072e: ldstr "WM_NCRBUTTONDOWN"
				L_0733: stloc.0 
				L_0734: br L_08bc
				L_0739: ldstr "WM_NCRBUTTONUP"
				L_073e: stloc.0 
				L_073f: br L_08bc
				L_0744: ldstr "WM_NCRBUTTONDBLCLK"
				L_0749: stloc.0 
				L_074a: br L_08bc
				L_074f: ldstr "WM_NCMBUTTONDOWN"
				L_0754: stloc.0 
				L_0755: br L_08bc
				L_075a: ldstr "WM_NCMBUTTONUP"
				L_075f: stloc.0 
				L_0760: br L_08bc
				L_0765: ldstr "WM_NCMBUTTONDBLCLK"
				L_076a: stloc.0 
				L_076b: br L_08bc
				L_0770: ldstr "WM_NCXBUTTONDOWN"
				L_0775: stloc.0 
				L_0776: br L_08bc
				L_077b: ldstr "WM_NCXBUTTONUP"
				L_0780: stloc.0 
				L_0781: br L_08bc
				L_0786: ldstr "WM_NCXBUTTONDBLCLK"
				L_078b: stloc.0 
				L_078c: br L_08bc
				L_0791: ldstr "WM_INPUT"
				L_0796: stloc.0 
				L_0797: br L_08bc
				L_079c: ldstr "WM_KEYFIRST"
				L_07a1: stloc.0 
				L_07a2: br L_08bc
				L_07a7: ldstr "WM_KEYUP"
				L_07ac: stloc.0 
				L_07ad: br L_08bc
				L_07b2: ldstr "WM_CHAR"
				L_07b7: stloc.0 
				L_07b8: br L_08bc
				L_07bd: ldstr "WM_DEADCHAR"
				L_07c2: stloc.0 
				L_07c3: br L_08bc
				L_07c8: ldstr "WM_SYSKEYDOWN"
				L_07cd: stloc.0 
				L_07ce: br L_08bc
				L_07d3: ldstr "WM_SYSKEYUP"
				L_07d8: stloc.0 
				L_07d9: br L_08bc
				L_07de: ldstr "WM_SYSCHAR"
				L_07e3: stloc.0 
				L_07e4: br L_08bc
				L_07e9: ldstr "WM_SYSDEADCHAR"
				L_07ee: stloc.0 
				L_07ef: br L_08bc
				L_07f4: ldstr "WM_UNICHAR"
				L_07f9: stloc.0 
				L_07fa: br L_08bc
				L_07ff: ldstr "UNICODE_NOCHAR"
				L_0804: stloc.0 
				L_0805: br L_08bc
				L_080a: ldstr "WM_IME_STARTCOMPOSITION"
				L_080f: stloc.0 
				L_0810: br L_08bc
				L_0815: ldstr "WM_IME_ENDCOMPOSITION"
				L_081a: stloc.0 
				L_081b: br L_08bc
				L_0820: ldstr "WM_IME_COMPOSITION"
				L_0825: stloc.0 
				L_0826: br L_08bc
				L_082b: ldstr "WM_CTLCOLORMSGBOX"
				L_0830: stloc.0 
				L_0831: br L_08bc
				L_0836: ldstr "WM_CTLCOLOREDIT"
				L_083b: stloc.0 
				L_083c: br L_08bc
				L_0841: ldstr "WM_CTLCOLORLISTBOX"
				L_0846: stloc.0 
				L_0847: br L_08bc
				L_084c: ldstr "WM_CTLCOLORBTN"
				L_0851: stloc.0 
				L_0852: br L_08bc
				L_0857: ldstr "WM_CTLCOLORDLG"
				L_085c: stloc.0 
				L_085d: br.s L_08bc
				L_085f: ldstr "WM_CTLCOLORSCROLLBAR"
				L_0864: stloc.0 
				L_0865: br.s L_08bc
				L_0867: ldstr "WM_CTLCOLORSTATIC"
				L_086c: stloc.0 
				L_086d: br.s L_08bc
				L_086f: ldstr "MN_GETHMENU"
				L_0874: stloc.0 
				L_0875: br.s L_08bc
				L_0877: ldstr "WM_PARENTNOTIFY"
				L_087c: stloc.0 
				L_087d: br.s L_08bc
				L_087f: ldstr "WM_ENTERMENULOOP"
				L_0884: stloc.0 
				L_0885: br.s L_08bc
				L_0887: ldstr "WM_EXITMENULOOP"
				L_088c: stloc.0 
				L_088d: br.s L_08bc
				L_088f: ldstr "WM_NEXTMENU"
				L_0894: stloc.0 
				L_0895: br.s L_08bc
				L_0897: ldstr "WM_SIZING"
				L_089c: stloc.0 
				L_089d: br.s L_08bc
				L_089f: ldstr "WM_CAPTURECHANGED"
				L_08a4: stloc.0 
				L_08a5: br.s L_08bc
				L_08a7: ldstr "WM_MOVING"
				L_08ac: stloc.0 
				L_08ad: br.s L_08bc
				L_08af: ldarga.s x8a41fbc87a3fb305
				L_08b1: ldstr "x"
				L_08b6: call System.Int32::System.String ToString(System.String)
				L_08bb: stloc.0 
				L_08bc: ldstr "{0}:  {1}"
				L_08c1: ldsfld Sunisoft.IrisSkin.x6106db8218fc38c0::Int32 x311e7a92306d7199
				L_08c6: box System.Int32
				L_08cb: ldloc.0 
				L_08cc: call System.Console::Void WriteLine(System.String, System.Object, System.Object)
				L_08d1: ldsfld Sunisoft.IrisSkin.x6106db8218fc38c0::Int32 x311e7a92306d7199
				L_08d6: ldc.i4.1 
				L_08d7: add 
				L_08d8: stsfld Sunisoft.IrisSkin.x6106db8218fc38c0::Int32 x311e7a92306d7199
				L_08dd: ret 
			*/
			
			
			{
				string string1;
				uint uInt32_1;
				uInt32_1 = ((uint) x8a41fbc87a3fb305);
				if (uInt32_1 <= 61536)
				{
					if (uInt32_1 <= 534)
					{
						if (uInt32_1 <= 173)
						{
							switch (uInt32_1)
							{
								case uint.MinValue:
								
								{
										string1 = "WM_NULL";
										goto L_08BC;
								}
								case 1:
								
								{
										string1 = "WM_CREATE";
										goto L_08BC;
								}
								case 2:
								
								{
										string1 = "WM_DESTROY";
										goto L_08BC;
								}
								case 3:
								
								{
										string1 = "WM_MOVE";
										goto L_08BC;
								}
								case 4:
								case 9:
								case 23:
								case 25:
								
								{
										goto L_08AF;
								}
								case 5:
								
								{
										string1 = "WM_SIZE";
										goto L_08BC;
								}
								case 6:
								
								{
										string1 = "WM_ACTIVATE";
										goto L_08BC;
								}
								case 7:
								
								{
										string1 = "WM_SETFOCUS";
										goto L_08BC;
								}
								case 8:
								
								{
										string1 = "WM_KILLFOCUS";
										goto L_08BC;
								}
								case 10:
								
								{
										string1 = "WM_ENABLE";
										goto L_08BC;
								}
								case 11:
								
								{
										string1 = "WM_SETREDRAW";
										goto L_08BC;
								}
								case 12:
								
								{
										string1 = "WM_SETTEXT";
										goto L_08BC;
								}
								case 13:
								
								{
										string1 = "WM_GETTEXT";
										goto L_08BC;
								}
								case 14:
								
								{
										string1 = "WM_GETTEXTLENGTH";
										goto L_08BC;
								}
								case 15:
								
								{
										string1 = "WM_PAINT";
										goto L_08BC;
								}
								case 16:
								
								{
										string1 = "WM_CLOSE";
										goto L_08BC;
								}
								case 17:
								
								{
										string1 = "WM_QUERYENDSESSION";
										goto L_08BC;
								}
								case 18:
								
								{
										string1 = "WM_QUIT";
										goto L_08BC;
								}
								case 19:
								
								{
										string1 = "WM_QUERYOPEN";
										goto L_08BC;
								}
								case 20:
								
								{
										string1 = "WM_ERASEBKGND";
										goto L_08BC;
								}
								case 21:
								
								{
										string1 = "WM_SYSCOLORCHANGE";
										goto L_08BC;
								}
								case 22:
								
								{
										string1 = "WM_ENDSESSION";
										goto L_08BC;
								}
								case 24:
								
								{
										string1 = "WM_SHOWWINDOW";
										goto L_08BC;
								}
								case 26:
								
								{
										string1 = "WM_WININICHANGE";
										goto L_08BC;
								}
								case 27:
								
								{
										string1 = "WM_DEVMODECHANGE";
										goto L_08BC;
								}
								case 28:
								
								{
										string1 = "WM_ACTIVATEAPP";
										goto L_08BC;
								}
								case 29:
								
								{
										string1 = "WM_FONTCHANGE";
										goto L_08BC;
								}
								case 30:
								
								{
										string1 = "WM_TIMECHANGE";
										goto L_08BC;
								}
								case 31:
								
								{
										string1 = "WM_CANCELMODE";
										goto L_08BC;
								}
								case 32:
								
								{
										string1 = "WM_SETCURSOR";
										goto L_08BC;
								}
								case 33:
								
								{
										string1 = "WM_MOUSEACTIVATE";
										goto L_08BC;
								}
								case 34:
								
								{
										string1 = "WM_CHILDACTIVATE";
										goto L_08BC;
								}
								case 35:
								
								{
										string1 = "WM_QUEUESYNC";
										goto L_08BC;
								}
							}
							switch ((int) uInt32_1)
							{
								case 129:
								
								{
										string1 = "WM_NCCREATE";
										goto L_08BC;
								}
								case 130:
								
								{
										string1 = "WM_NCDESTROY";
										goto L_08BC;
								}
								case 131:
								
								{
										string1 = "WM_NCCALCSIZE";
										goto L_08BC;
								}
								case 132:
								
								{
										string1 = "WM_NCHITTEST";
										goto L_08BC;
								}
								case 133:
								
								{
										string1 = "WM_NCPAINT";
										goto L_08BC;
								}
								case 134:
								
								{
										string1 = "WM_NCACTIVATE";
										goto L_08BC;
								}
								case 135:
								
								{
										string1 = "WM_GETDLGCODE";
										goto L_08BC;
								}
								case 136:
								
								{
										string1 = "WM_SYNCPAINT";
										goto L_08BC;
								}
								case 160:
								
								{
										string1 = "WM_NCMOUSEMOVE";
										goto L_08BC;
								}
								case 161:
								
								{
										string1 = "WM_NCLBUTTONDOWN";
										goto L_08BC;
								}
								case 162:
								
								{
										string1 = "WM_NCLBUTTONUP";
										goto L_08BC;
								}
								case 163:
								
								{
										string1 = "WM_NCLBUTTONDBLCLK";
										goto L_08BC;
								}
								case 164:
								
								{
										string1 = "WM_NCRBUTTONDOWN";
										goto L_08BC;
								}
								case 165:
								
								{
										string1 = "WM_NCRBUTTONUP";
										goto L_08BC;
								}
								case 166:
								
								{
										string1 = "WM_NCRBUTTONDBLCLK";
										goto L_08BC;
								}
								case 167:
								
								{
										string1 = "WM_NCMBUTTONDOWN";
										goto L_08BC;
								}
								case 168:
								
								{
										string1 = "WM_NCMBUTTONUP";
										goto L_08BC;
								}
								case 169:
								
								{
										string1 = "WM_NCMBUTTONDBLCLK";
										goto L_08BC;
								}
								case 171:
								
								{
										string1 = "WM_NCXBUTTONDOWN";
										goto L_08BC;
								}
								case 172:
								
								{
										string1 = "WM_NCXBUTTONUP";
										goto L_08BC;
								}
								case 173:
								
								{
										string1 = "WM_NCXBUTTONDBLCLK";
										goto L_08BC;
								}
							}
						}
						else
						{
							switch ((int) uInt32_1)
							{
								case 255:
								
								{
										string1 = "WM_INPUT";
										goto L_08BC;
								}
								case 256:
								
								{
										string1 = "WM_KEYFIRST";
										goto L_08BC;
								}
								case 257:
								
								{
										string1 = "WM_KEYUP";
										goto L_08BC;
								}
								case 258:
								
								{
										string1 = "WM_CHAR";
										goto L_08BC;
								}
								case 259:
								
								{
										string1 = "WM_DEADCHAR";
										goto L_08BC;
								}
								case 260:
								
								{
										string1 = "WM_SYSKEYDOWN";
										goto L_08BC;
								}
								case 261:
								
								{
										string1 = "WM_SYSKEYUP";
										goto L_08BC;
								}
								case 262:
								
								{
										string1 = "WM_SYSCHAR";
										goto L_08BC;
								}
								case 263:
								
								{
										string1 = "WM_SYSDEADCHAR";
										goto L_08BC;
								}
								case 264:
								case 266:
								case 267:
								case 268:
								case 280:
								case 281:
								case 282:
								case 283:
								case 284:
								case 285:
								case 286:
								case 298:
								case 299:
								case 300:
								case 301:
								case 302:
								case 303:
								case 304:
								case 305:
								
								{
										goto L_08AF;
								}
								case 265:
								
								{
										string1 = "WM_UNICHAR";
										goto L_08BC;
								}
								case 269:
								
								{
										string1 = "WM_IME_STARTCOMPOSITION";
										goto L_08BC;
								}
								case 270:
								
								{
										string1 = "WM_IME_ENDCOMPOSITION";
										goto L_08BC;
								}
								case 271:
								
								{
										string1 = "WM_IME_COMPOSITION";
										goto L_08BC;
								}
								case 272:
								
								{
										string1 = "WM_INITDIALOG";
										goto L_08BC;
								}
								case 273:
								
								{
										string1 = "WM_COMMAND";
										goto L_08BC;
								}
								case 274:
								
								{
										string1 = "WM_SYSCOMMAND";
										goto L_08BC;
								}
								case 275:
								
								{
										string1 = "WM_TIMER";
										goto L_08BC;
								}
								case 276:
								
								{
										string1 = "WM_HSCROLL";
										goto L_08BC;
								}
								case 277:
								
								{
										string1 = "WM_VSCROLL";
										goto L_08BC;
								}
								case 278:
								
								{
										string1 = "WM_INITMENU";
										goto L_08BC;
								}
								case 279:
								
								{
										string1 = "WM_INITMENUPOPUP";
										goto L_08BC;
								}
								case 287:
								
								{
										string1 = "WM_MENUSELECT";
										goto L_08BC;
								}
								case 288:
								
								{
										string1 = "WM_MENUCHAR";
										goto L_08BC;
								}
								case 289:
								
								{
										string1 = "WM_ENTERIDLE";
										goto L_08BC;
								}
								case 290:
								
								{
										string1 = "WM_MENURBUTTONUP";
										goto L_08BC;
								}
								case 291:
								
								{
										string1 = "WM_MENUDRAG";
										goto L_08BC;
								}
								case 292:
								
								{
										string1 = "WM_MENUGETOBJECT";
										goto L_08BC;
								}
								case 293:
								
								{
										string1 = "WM_UNINITMENUPOPUP";
										goto L_08BC;
								}
								case 294:
								
								{
										string1 = "WM_MENUCOMMAND";
										goto L_08BC;
								}
								case 295:
								
								{
										string1 = "WM_CHANGEUISTATE";
										goto L_08BC;
								}
								case 296:
								
								{
										string1 = "WM_UPDATEUISTATE";
										goto L_08BC;
								}
								case 297:
								
								{
										string1 = "WM_QUERYUISTATE";
										goto L_08BC;
								}
								case 306:
								
								{
										string1 = "WM_CTLCOLORMSGBOX";
										goto L_08BC;
								}
								case 307:
								
								{
										string1 = "WM_CTLCOLOREDIT";
										goto L_08BC;
								}
								case 308:
								
								{
										string1 = "WM_CTLCOLORLISTBOX";
										goto L_08BC;
								}
								case 309:
								
								{
										string1 = "WM_CTLCOLORBTN";
										goto L_08BC;
								}
								case 310:
								
								{
										string1 = "WM_CTLCOLORDLG";
										goto L_08BC;
								}
								case 311:
								
								{
										string1 = "WM_CTLCOLORSCROLLBAR";
										goto L_08BC;
								}
								case 312:
								
								{
										string1 = "WM_CTLCOLORSTATIC";
										goto L_08BC;
								}
							}
							if (uInt32_1 == 481)
							{
								string1 = "MN_GETHMENU";
								goto L_08BC;
							}
							else
							{
								switch ((int) uInt32_1)
								{
									case 528:
									
									{
											string1 = "WM_PARENTNOTIFY";
											goto L_08BC;
									}
									case 529:
									
									{
											string1 = "WM_ENTERMENULOOP";
											goto L_08BC;
									}
									case 530:
									
									{
											string1 = "WM_EXITMENULOOP";
											goto L_08BC;
									}
									case 531:
									
									{
											string1 = "WM_NEXTMENU";
											goto L_08BC;
									}
									case 532:
									
									{
											string1 = "WM_SIZING";
											goto L_08BC;
									}
									case 533:
									
									{
											string1 = "WM_CAPTURECHANGED";
											goto L_08BC;
									}
									case 534:
									
									{
											string1 = "WM_MOVING";
											goto L_08BC;
									}
								}
							}
						}
						goto L_08AF;
					}
					else
					{
						if (uInt32_1 < 61472)
						{
							if (uInt32_1 == 61440)
							{
								string1 = "SC_SIZE";
								goto L_08BC;
							}
							else
							{
								switch ((int) uInt32_1)
								{
									case 61455:
									
									{
											string1 = "SC_SEPARATOR";
											goto L_08BC;
									}
									case 61456:
									
									{
											string1 = "SC_MOVE";
											goto L_08BC;
									}
								}
								if (uInt32_1 == 61472)
								{
									string1 = "SC_MINIMIZE";
									goto L_08BC;
								}
								else
								{
									goto L_08AF;
								}
							}
						}
						if (uInt32_1 < 61504)
						{
							if (uInt32_1 == 61488)
							{
								string1 = "SC_MAXIMIZE";
								goto L_08BC;
							}
							else if (uInt32_1 == 61504)
							{
								string1 = "SC_NEXTWINDOW";
								goto L_08BC;
							}
							else
							{
								goto L_08AF;
							}
						}
						if (uInt32_1 == 61520)
						{
							string1 = "SC_PREVWINDOW";
							goto L_08BC;
						}
						else if (uInt32_1 == 61536)
						{
							string1 = "SC_CLOSE";
							goto L_08BC;
						}
						else
						{
							goto L_08AF;
						}
					}
				}
				if (uInt32_1 < 61728)
				{
					if (uInt32_1 < 61584)
					{
						if (uInt32_1 == 61552)
						{
							string1 = "SC_VSCROLL";
							goto L_08BC;
						}
						else if (uInt32_1 == 61568)
						{
							string1 = "SC_HSCROLL";
							goto L_08BC;
						}
						else if (uInt32_1 == 61584)
						{
							string1 = "SC_MOUSEMENU";
							goto L_08BC;
						}
						else
						{
							goto L_08AF;
						}
					}
					if (uInt32_1 == 61696)
					{
						string1 = "SC_KEYMENU";
						goto L_08BC;
					}
					else if (uInt32_1 == 61712)
					{
						string1 = "SC_ARRANGE";
						goto L_08BC;
					}
					else if (uInt32_1 == 61728)
					{
						string1 = "SC_RESTORE";
						goto L_08BC;
					}
					else
					{
						goto L_08AF;
					}
				}
				if (uInt32_1 < 61776)
				{
					if (uInt32_1 == 61744)
					{
						string1 = "SC_TASKLIST";
						goto L_08BC;
					}
					else if (uInt32_1 == 61760)
					{
						string1 = "SC_SCREENSAVE";
						goto L_08BC;
					}
					else if (uInt32_1 == 61776)
					{
						string1 = "SC_HOTKEY";
						goto L_08BC;
					}
					else
					{
						goto L_08AF;
					}
				}
				if (uInt32_1 < 61808)
				{
					if (uInt32_1 == 61792)
					{
						string1 = "SC_DEFAULT";
						goto L_08BC;
					}
					else if (uInt32_1 == 61808)
					{
						string1 = "SC_MONITORPOWER";
						goto L_08BC;
					}
					else
					{
						goto L_08AF;
					}
				}
				if (uInt32_1 != 61824)
				{
					if (uInt32_1 == 65535)
					{
						string1 = "UNICODE_NOCHAR";
						goto L_08BC;
					}
					else
					{
						goto L_08AF;
					}
				}
				string1 = "SC_CONTEXTHELP";
				goto L_08BC;
				
			L_08AF:
				
				{
				}
				string1 = x8a41fbc87a3fb305.ToString ("x");
				
			L_08BC:
				
				{
				}
				Console.WriteLine ("{0}:  {1}", x6106db8218fc38c0.x311e7a92306d7199, string1);
				x6106db8218fc38c0.x311e7a92306d7199++;
			}
			
		#endregion
	}
	
}

