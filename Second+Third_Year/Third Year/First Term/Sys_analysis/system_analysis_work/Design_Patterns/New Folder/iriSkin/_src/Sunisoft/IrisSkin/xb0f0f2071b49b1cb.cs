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
		
	internal class xb0f0f2071b49b1cb : Ixb0f0f2071b49b1cb
	
	{
		
		#region Fields
			private int xca3516d7e7bf3e88;
			private int[] xd56734c5eb5c07a0;
			private int xda0cfe0865a46405;
		#endregion
		
		#region Constructors
		
			public xb0f0f2071b49b1cb (int defMaxCodeLen)
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xda0cfe0865a46405
				L_000d: ret 
			*/
		#endregion
		
		#region Properties
		
			int Ixb0f0f2071b49b1cb.xc5207dd50e2ff5b4
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xca3516d7e7bf3e88
					L_0006: ret 
				*/
				
				{
					return this.xca3516d7e7bf3e88;
				}
			}
			
		#endregion
		
		#region Methods
		
			public static int xa52147d0d9c2c73c (int x7b28e8a789372508, int x1148d0e8cc982c04)
			
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: ble.s L_000b
				L_0004: ldarg.0 
				L_0005: ldarg.1 
				L_0006: ldc.i4.s 31
				L_0008: and 
				L_0009: shr 
				L_000a: ret 
				L_000b: ldarg.0 
				L_000c: ldarg.1 
				L_000d: ldc.i4.s 31
				L_000f: and 
				L_0010: shr.un 
				L_0011: ret 
			*/
			
			
			{
				if (x7b28e8a789372508 <= 0)
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
				else
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
			}
			
			void Ixb0f0f2071b49b1cb.xda09af88ab899a50 (int[] xf9424bfd9f23efe2, int x75b49f23876967eb, int xd44988f225497f3a, byte[] x1c2284fc7e4d802b, int x7cc8e942f1106d79)
			
			/*
				// Code Size: 405 Bytes
				.maxstack 5
				.locals (System.Int32[] V_0, 
         System.Int32[] V_1, 
         System.Int32[] V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Int32 V_11, 
         System.Int32 V_12, 
         System.Int32 V_13, 
         System.Int32 V_14, 
         System.Int32 V_15, 
         System.Int32 V_16, 
         System.Int32[] V_17, 
         System.IntPtr V_18)
				L_0000: ldc.i4.s 16
				L_0002: newarr System.Int32
				L_0007: stloc.0 
				L_0008: ldc.i4.s 16
				L_000a: newarr System.Int32
				L_000f: stloc.1 
				L_0010: ldarg.0 
				L_0011: ldc.i4.0 
				L_0012: stfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xca3516d7e7bf3e88
				L_0017: ldc.i4.0 
				L_0018: stloc.s V_10
				L_001a: br.s L_004d
				L_001c: ldarg.1 
				L_001d: ldloc.s V_10
				L_001f: ldarg.2 
				L_0020: add 
				L_0021: ldelem.i4 
				L_0022: stloc.s V_5
				L_0024: ldloc.s V_5
				L_0026: ldarg.0 
				L_0027: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xca3516d7e7bf3e88
				L_002c: ble.s L_0036
				L_002e: ldarg.0 
				L_002f: ldloc.s V_5
				L_0031: stfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xca3516d7e7bf3e88
				L_0036: ldloc.0 
				L_0037: dup 
				L_0038: stloc.s V_17
				L_003a: ldloc.s V_5
				L_003c: dup 
				L_003d: stloc.s V_18
				L_003f: ldloc.s V_17
				L_0041: ldloc.s V_18
				L_0043: ldelem.i4 
				L_0044: ldc.i4.1 
				L_0045: add 
				L_0046: stelem.i4 
				L_0047: ldloc.s V_10
				L_0049: ldc.i4.1 
				L_004a: add 
				L_004b: stloc.s V_10
				L_004d: ldloc.s V_10
				L_004f: ldarg.3 
				L_0050: blt.s L_001c
				L_0052: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xf82987893a267166
				L_0057: ldarg.0 
				L_0058: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xca3516d7e7bf3e88
				L_005d: ldelem.i4 
				L_005e: stloc.s V_7
				L_0060: ldarg.0 
				L_0061: ldloc.s V_7
				L_0063: ldc.i4.4 
				L_0064: mul 
				L_0065: conv.ovf.u4 
				L_0066: newarr System.Int32
				L_006b: stfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32[] xd56734c5eb5c07a0
				L_0070: ldloc.s V_7
				L_0072: stloc.s V_9
				L_0074: ldc.i4.0 
				L_0075: stloc.s V_11
				L_0077: br.s L_0089
				L_0079: ldarg.0 
				L_007a: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32[] xd56734c5eb5c07a0
				L_007f: ldloc.s V_11
				L_0081: ldc.i4.0 
				L_0082: stelem.i4 
				L_0083: ldloc.s V_11
				L_0085: ldc.i4.1 
				L_0086: add 
				L_0087: stloc.s V_11
				L_0089: ldloc.s V_11
				L_008b: ldloc.s V_7
				L_008d: ldc.i4.4 
				L_008e: mul 
				L_008f: blt.s L_0079
				L_0091: ldc.i4.0 
				L_0092: stloc.s V_4
				L_0094: ldloc.0 
				L_0095: ldc.i4.0 
				L_0096: ldc.i4.0 
				L_0097: stelem.i4 
				L_0098: ldc.i4.1 
				L_0099: stloc.s V_12
				L_009b: br.s L_00b6
				L_009d: ldloc.s V_4
				L_009f: ldloc.0 
				L_00a0: ldloc.s V_12
				L_00a2: ldc.i4.1 
				L_00a3: sub 
				L_00a4: ldelem.i4 
				L_00a5: add 
				L_00a6: ldc.i4.1 
				L_00a7: shl 
				L_00a8: stloc.s V_4
				L_00aa: ldloc.1 
				L_00ab: ldloc.s V_12
				L_00ad: ldloc.s V_4
				L_00af: stelem.i4 
				L_00b0: ldloc.s V_12
				L_00b2: ldc.i4.1 
				L_00b3: add 
				L_00b4: stloc.s V_12
				L_00b6: ldloc.s V_12
				L_00b8: ldarg.0 
				L_00b9: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xda0cfe0865a46405
				L_00be: ble.s L_009d
				L_00c0: ldarg.0 
				L_00c1: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32[] xd56734c5eb5c07a0
				L_00c6: stloc.2 
				L_00c7: ldc.i4.0 
				L_00c8: stloc.s V_16
				L_00ca: br L_018c
				L_00cf: ldarg.1 
				L_00d0: ldloc.s V_16
				L_00d2: ldarg.2 
				L_00d3: add 
				L_00d4: ldelem.i4 
				L_00d5: stloc.s V_5
				L_00d7: ldloc.s V_5
				L_00d9: brfalse L_0186
				L_00de: ldloc.1 
				L_00df: ldloc.s V_5
				L_00e1: ldelem.i4 
				L_00e2: stloc.s V_4
				L_00e4: ldloc.s V_4
				L_00e6: ldc.i4 65280
				L_00eb: and 
				L_00ec: ldc.i4.8 
				L_00ed: call Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_00f2: stloc.s V_14
				L_00f4: ldloc.s V_4
				L_00f6: ldc.i4 255
				L_00fb: and 
				L_00fc: stloc.s V_13
				L_00fe: ldloc.s V_14
				L_0100: stloc.s V_15
				L_0102: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xfa45002bb236a68c
				L_0107: ldloc.s V_13
				L_0109: ldelem.u1 
				L_010a: stloc.s V_14
				L_010c: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xfa45002bb236a68c
				L_0111: ldloc.s V_15
				L_0113: ldelem.u1 
				L_0114: stloc.s V_13
				L_0116: ldloc.s V_4
				L_0118: ldloc.s V_4
				L_011a: ldc.i4 65535
				L_011f: and 
				L_0120: sub 
				L_0121: ldloc.s V_14
				L_0123: ldc.i4.8 
				L_0124: shl 
				L_0125: add 
				L_0126: ldloc.s V_13
				L_0128: add 
				L_0129: stloc.s V_4
				L_012b: ldloc.s V_4
				L_012d: ldc.i4.s 16
				L_012f: ldloc.s V_5
				L_0131: sub 
				L_0132: call Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0137: stloc.s V_4
				L_0139: ldloc.s V_16
				L_013b: ldloc.s V_5
				L_013d: ldc.i4.s 16
				L_013f: shl 
				L_0140: add 
				L_0141: stloc.s V_6
				L_0143: ldloc.s V_16
				L_0145: ldarg.s x7cc8e942f1106d79
				L_0147: blt.s L_0159
				L_0149: ldloc.s V_6
				L_014b: ldarg.s x1c2284fc7e4d802b
				L_014d: ldloc.s V_16
				L_014f: ldarg.s x7cc8e942f1106d79
				L_0151: sub 
				L_0152: ldelem.u1 
				L_0153: ldc.i4.s 24
				L_0155: shl 
				L_0156: add 
				L_0157: stloc.s V_6
				L_0159: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xf82987893a267166
				L_015e: ldloc.s V_5
				L_0160: ldelem.i4 
				L_0161: stloc.s V_8
				L_0163: ldloc.s V_4
				L_0165: stloc.3 
				L_0166: ldloc.2 
				L_0167: ldloc.3 
				L_0168: ldloc.s V_6
				L_016a: stelem.i4 
				L_016b: ldloc.3 
				L_016c: ldloc.s V_8
				L_016e: add 
				L_016f: stloc.3 
				L_0170: ldloc.3 
				L_0171: ldloc.s V_9
				L_0173: blt.s L_0166
				L_0175: ldloc.1 
				L_0176: dup 
				L_0177: stloc.s V_17
				L_0179: ldloc.s V_5
				L_017b: dup 
				L_017c: stloc.s V_18
				L_017e: ldloc.s V_17
				L_0180: ldloc.s V_18
				L_0182: ldelem.i4 
				L_0183: ldc.i4.1 
				L_0184: add 
				L_0185: stelem.i4 
				L_0186: ldloc.s V_16
				L_0188: ldc.i4.1 
				L_0189: add 
				L_018a: stloc.s V_16
				L_018c: ldloc.s V_16
				L_018e: ldarg.3 
				L_018f: blt L_00cf
				L_0194: ret 
			*/
			
			
			{
				int[] int32Array1;
				int[] int32Array2;
				int[] int32Array3;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				int i7;
				int i8;
				int i9;
				int i10;
				int i11;
				int i12;
				int i13;
				int i14;
				int[] int32Array4;
				IntPtr intPtr1;
				int32Array1 = new int[16];
				int32Array2 = new int[16];
				this.xca3516d7e7bf3e88 = 0;
				for (i8 = 0; (i8 < xd44988f225497f3a); i8++)
				{
					i3 = xf9424bfd9f23efe2[(i8 + x75b49f23876967eb)];
					if (i3 > this.xca3516d7e7bf3e88)
					{
						this.xca3516d7e7bf3e88 = i3;
					}
					int32Array4 = int32Array1;
					int32Array4[((int) (intPtr1 = ((IntPtr) i3)))] = (int32Array4[((int) intPtr1)] + 1);
				}
				i5 = x71589e3f55261426.xf82987893a267166[this.xca3516d7e7bf3e88];
				this.xd56734c5eb5c07a0 = new int[((uint) (i5 * 4))];
				i7 = i5;
				for (i9 = 0; (i9 < (i5 * 4)); i9++)
				{
					this.xd56734c5eb5c07a0[i9] = 0;
				}
				i2 = 0;
				int32Array1[0] = 0;
				for (i10 = 1; (i10 <= this.xda0cfe0865a46405); i10++)
				{
					i2 = ((i2 + int32Array1[(i10 - 1)]) << 1);
					int32Array2[i10] = i2;
				}
				int32Array3 = this.xd56734c5eb5c07a0;
				i14 = 0;
				goto L_018C;
				
			L_0166:
				
				{
				}
				int32Array3[i1] = i4;
				i1 += i6;
				if (i1 < i7)
				{
					goto L_0166;
				}
				int32Array4 = int32Array2;
				int32Array4[((int) (intPtr1 = ((IntPtr) i3)))] = (int32Array4[((int) intPtr1)] + 1);
				
			L_0186:
				
				{
				}
				i14++;
				
			L_018C:
				
				{
				}
				if (i14 >= xd44988f225497f3a)
				{
				}
				else
				{
					i3 = xf9424bfd9f23efe2[(i14 + x75b49f23876967eb)];
					if (i3 != 0)
					{
						i2 = int32Array2[i3];
						i12 = xb0f0f2071b49b1cb.xa52147d0d9c2c73c (((int) (i2 & 65280)), 8);
						i11 = (i2 & 255);
						i13 = i12;
						i12 = ((int) x71589e3f55261426.xfa45002bb236a68c[i11]);
						i11 = ((int) x71589e3f55261426.xfa45002bb236a68c[i13]);
						i2 = (((i2 - (i2 & 65535)) + (i12 << 8)) + i11);
						i2 = xb0f0f2071b49b1cb.xa52147d0d9c2c73c (i2, ((int) (16 - i3)));
						i4 = ((int) (i14 + (i3 << 16)));
						if (i14 >= x7cc8e942f1106d79)
						{
							i4 += ((int) (x1c2284fc7e4d802b[(i14 - x7cc8e942f1106d79)] << 24));
						}
						i6 = x71589e3f55261426.xf82987893a267166[i3];
						i1 = i2;
						goto L_0166;
					}
					else
					{
						goto L_0186;
					}
				}
			}
			
			int Ixb0f0f2071b49b1cb.xf76803be5e9ee2aa (int x8056ee08e8b9a4f9)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32[] xd56734c5eb5c07a0
				L_0006: ldarg.1 
				L_0007: ldelem.i4 
				L_0008: ret 
			*/
			
			
			{
				return this.xd56734c5eb5c07a0[x8056ee08e8b9a4f9];
			}
			
		#endregion
	}
	
}

