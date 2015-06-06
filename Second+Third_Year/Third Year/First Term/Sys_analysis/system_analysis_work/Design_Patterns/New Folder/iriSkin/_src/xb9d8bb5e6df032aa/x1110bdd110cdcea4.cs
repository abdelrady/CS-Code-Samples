//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace xb9d8bb5e6df032aa

{
		
		#region Namespace Import Declarations
		
			using System;
			
			
		#endregion
		
	public class x1110bdd110cdcea4
	
	{
		
		#region Constructors
		
			public x1110bdd110cdcea4 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static string _xaacba899487bce8c (string x5e99b576d2530d13, int x2710752c36f2d14b)
			
			/*
				// Code Size: 220 Bytes
				.maxstack 5
				.locals (System.UInt16 V_0, 
         System.Char[] V_1, 
         System.Int32 V_2, 
         System.UInt16 V_3, 
         System.String V_4, 
         System.Boolean V_5)
				L_0000: ldarg.1 
				L_0001: conv.u2 
				L_0002: stloc.0 
				L_0003: ldloc V_3
				L_0007: conv.u4 
				L_0008: ldarg x2710752c36f2d14b
				L_000c: conv.u4 
				L_000d: sub 
				L_000e: ldc.i4.0 
				L_000f: clt.un 
				L_0011: stloc V_5
				L_0015: ldloc V_5
				L_0019: brfalse.s L_007b
				L_001b: ldloc.2 
				L_001c: ldc.i4.1 
				L_001d: add 
				L_001e: stloc.2 
				L_001f: ldloc.2 
				L_0020: ldarg.0 
				L_0021: callvirt System.String::Int32 get_Length()
				L_0026: ldc.i4.4 
				L_0027: div 
				L_0028: blt.s L_008d
				L_002a: ldarg x2710752c36f2d14b
				L_002e: conv.u4 
				L_002f: ldloc V_0
				L_0033: conv.u4 
				L_0034: sub 
				L_0035: ldc.i4.0 
				L_0036: clt.un 
				L_0038: stloc V_5
				L_003c: ldloc V_5
				L_0040: brtrue.s L_008d
				L_0042: ldloc.1 
				L_0043: newobj System.String::Void .ctor(Char[])
				L_0048: stloc.s V_4
				L_004a: br L_00d9
				L_004f: ldarg x2710752c36f2d14b
				L_0053: conv.u4 
				L_0054: ldloc V_3
				L_0058: conv.u4 
				L_0059: sub 
				L_005a: ldc.i4.0 
				L_005b: clt.un 
				L_005d: stloc V_5
				L_0061: ldloc V_5
				L_0065: brtrue.s L_007b
				L_0067: ldloc.3 
				L_0068: ldloc.0 
				L_0069: sub 
				L_006a: conv.u2 
				L_006b: stloc.3 
				L_006c: ldloc.1 
				L_006d: ldloc.2 
				L_006e: ldloc.3 
				L_006f: stelem.i2 
				L_0070: ldloc.0 
				L_0071: ldc.i4 1789
				L_0076: add 
				L_0077: conv.u2 
				L_0078: stloc.0 
				L_0079: br.s L_00d4
				L_007b: ldarg.0 
				L_007c: callvirt System.String::Int32 get_Length()
				L_0081: ldc.i4.4 
				L_0082: div 
				L_0083: newarr System.Char
				L_0088: stloc.1 
				L_0089: ldc.i4.0 
				L_008a: stloc.2 
				L_008b: br.s L_001f
				L_008d: ldarg.0 
				L_008e: ldc.i4.4 
				L_008f: ldloc.2 
				L_0090: mul 
				L_0091: callvirt System.String::Char get_Chars(Int32)
				L_0096: ldc.i4.s 97
				L_0098: sub 
				L_0099: ldarg.0 
				L_009a: ldc.i4.4 
				L_009b: ldloc.2 
				L_009c: mul 
				L_009d: ldc.i4.1 
				L_009e: add 
				L_009f: callvirt System.String::Char get_Chars(Int32)
				L_00a4: ldc.i4.s 97
				L_00a6: sub 
				L_00a7: ldc.i4.4 
				L_00a8: shl 
				L_00a9: add 
				L_00aa: ldarg.0 
				L_00ab: ldc.i4.4 
				L_00ac: ldloc.2 
				L_00ad: mul 
				L_00ae: ldc.i4.2 
				L_00af: add 
				L_00b0: callvirt System.String::Char get_Chars(Int32)
				L_00b5: ldc.i4.s 97
				L_00b7: sub 
				L_00b8: ldc.i4.8 
				L_00b9: shl 
				L_00ba: add 
				L_00bb: ldarg.0 
				L_00bc: ldc.i4.4 
				L_00bd: ldloc.2 
				L_00be: mul 
				L_00bf: ldc.i4.3 
				L_00c0: add 
				L_00c1: callvirt System.String::Char get_Chars(Int32)
				L_00c6: ldc.i4.s 97
				L_00c8: sub 
				L_00c9: ldc.i4.s 12
				L_00cb: shl 
				L_00cc: add 
				L_00cd: conv.u2 
				L_00ce: stloc.3 
				L_00cf: br L_004f
				L_00d4: br L_001b
				L_00d9: ldloc.s V_4
				L_00db: ret 
			*/
			
			
			{
				UInt16 uInt16_1;
				char[] charArray1;
				int i1;
				UInt16 uInt16_2;
				uInt16_1 = ((UInt16) x2710752c36f2d14b);
				if ((((uint) uInt16_2) - ((uint) x2710752c36f2d14b)) >= uint.MinValue)
				{
					goto L_007B;
				}
				
			L_001B:
				
				{
				}
				i1++;
				
			L_001F:
				
				{
				}
				if ((i1 < (x5e99b576d2530d13.Length / 4)) || ((((uint) x2710752c36f2d14b) - ((uint) uInt16_1)) < uint.MinValue))
				{
					uInt16_2 = ((UInt16) ((((x5e99b576d2530d13[((int) (4 * i1))] - 97) + ((x5e99b576d2530d13[((int) ((4 * i1) + 1))] - 97) << 4)) + ((x5e99b576d2530d13[((int) ((4 * i1) + 2))] - 97) << 8)) + ((x5e99b576d2530d13[((int) ((4 * i1) + 3))] - 97) << 12)));
					if ((((uint) x2710752c36f2d14b) - ((uint) uInt16_2)) >= uint.MinValue)
					{
						uInt16_2 -= uInt16_1;
						charArray1[i1] = ((char) uInt16_2);
						uInt16_1 = ((UInt16) (((int) uInt16_1) + 1789));
						goto L_001B;
					}
					else
					{
						goto L_007B;
					}
				}
				return new string (charArray1);
				
			L_007B:
				
				{
				}
				charArray1 = new char[(x5e99b576d2530d13.Length / 4)];
				i1 = 0;
				goto L_001F;
			}
			
		#endregion
	}
	
}

