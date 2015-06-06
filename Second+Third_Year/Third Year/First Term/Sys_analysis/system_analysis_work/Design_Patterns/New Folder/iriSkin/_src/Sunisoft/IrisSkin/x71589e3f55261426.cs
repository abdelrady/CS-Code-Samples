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
		
	internal class x71589e3f55261426
	
	{
		
		#region Fields
			public static uint[] x6ee31887cc8af8eb;
			public static byte[] x79346f529f25ee2d;
			public static int[] x7d0d65d43fee511e;
			public static UInt16[] x829fbae11dc19d07;
			public static byte[] xc9fe980725d32ac6;
			public static byte[] xcf1e65d83cd6b794;
			public static int[] xd4434a4392e36da6;
			public static UInt16[] xf224e2f78df7e606;
			public static int[] xf82987893a267166;
			public static byte[] xfa45002bb236a68c;
		#endregion
		
		#region Constructors
		
			static x71589e3f55261426 ()
			/*
				// Code Size: 340 Bytes
				.maxstack 4
				.locals (System.Int32 V_0)
				L_0000: ldc.i4.s 31
				L_0002: newarr System.Int32
				L_0007: dup 
				L_0008: ldtoken x19d54ee1f3e0c943::x59457c5c414b8d1e x8ffb83cb0cc2faf7
				L_000d: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_0012: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_0017: ldc.i4 256
				L_001c: newarr System.UInt32
				L_0021: dup 
				L_0022: ldtoken x19d54ee1f3e0c943::xb1e146f6833f54dc x7af6f71e8a7f0e11
				L_0027: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_002c: stsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_0031: ldc.i4.s 19
				L_0033: newarr System.Byte
				L_0038: dup 
				L_0039: ldtoken x19d54ee1f3e0c943::x51535835fd11efaa xfbb9a1ef70f41c2f
				L_003e: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_0043: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] x79346f529f25ee2d
				L_0048: ldc.i4.s 16
				L_004a: newarr System.Int32
				L_004f: dup 
				L_0050: ldtoken x19d54ee1f3e0c943::xa595ecddad1b1d32 x2d04205ffcc6c2a7
				L_0055: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_005a: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xf82987893a267166
				L_005f: ldc.i4.s 31
				L_0061: newarr System.Byte
				L_0066: dup 
				L_0067: ldtoken x19d54ee1f3e0c943::x6f01f3c0fa10b560 xec70f7aa24e47aa9
				L_006c: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_0071: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xcf1e65d83cd6b794
				L_0076: ldc.i4.s 32
				L_0078: newarr System.Byte
				L_007d: dup 
				L_007e: ldtoken x19d54ee1f3e0c943::x40123812655e1be4 x2eb73ff89de3d8f8
				L_0083: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_0088: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xc9fe980725d32ac6
				L_008d: ldc.i4.s 29
				L_008f: newarr System.UInt16
				L_0094: dup 
				L_0095: ldtoken x19d54ee1f3e0c943::x18910a808034ed93 xfd13635ae1f64c89
				L_009a: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_009f: stsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] xf224e2f78df7e606
				L_00a4: ldc.i4.s 32
				L_00a6: newarr System.UInt16
				L_00ab: dup 
				L_00ac: ldtoken x19d54ee1f3e0c943::x3ffdb73409912feb x4d620ca5bac928bb
				L_00b1: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_00b6: stsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] x829fbae11dc19d07
				L_00bb: ldc.i4 256
				L_00c0: newarr System.Byte
				L_00c5: dup 
				L_00c6: ldtoken x19d54ee1f3e0c943::x17476180b8b9f3b2 x1a101e1f41233582
				L_00cb: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_00d0: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xfa45002bb236a68c
				L_00d5: ldc.i4 288
				L_00da: newarr System.Int32
				L_00df: stsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_00e4: ldc.i4.0 
				L_00e5: stloc.0 
				L_00e6: ldc.i4.0 
				L_00e7: stloc.0 
				L_00e8: br.s L_00f6
				L_00ea: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_00ef: ldloc.0 
				L_00f0: ldc.i4.8 
				L_00f1: stelem.i4 
				L_00f2: ldloc.0 
				L_00f3: ldc.i4.1 
				L_00f4: add 
				L_00f5: stloc.0 
				L_00f6: ldloc.0 
				L_00f7: ldc.i4 144
				L_00fc: blt.s L_00ea
				L_00fe: ldc.i4 144
				L_0103: stloc.0 
				L_0104: br.s L_0113
				L_0106: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_010b: ldloc.0 
				L_010c: ldc.i4.s 9
				L_010e: stelem.i4 
				L_010f: ldloc.0 
				L_0110: ldc.i4.1 
				L_0111: add 
				L_0112: stloc.0 
				L_0113: ldloc.0 
				L_0114: ldc.i4 256
				L_0119: blt.s L_0106
				L_011b: ldc.i4 256
				L_0120: stloc.0 
				L_0121: br.s L_012f
				L_0123: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_0128: ldloc.0 
				L_0129: ldc.i4.7 
				L_012a: stelem.i4 
				L_012b: ldloc.0 
				L_012c: ldc.i4.1 
				L_012d: add 
				L_012e: stloc.0 
				L_012f: ldloc.0 
				L_0130: ldc.i4 280
				L_0135: blt.s L_0123
				L_0137: ldc.i4 280
				L_013c: stloc.0 
				L_013d: br.s L_014b
				L_013f: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_0144: ldloc.0 
				L_0145: ldc.i4.8 
				L_0146: stelem.i4 
				L_0147: ldloc.0 
				L_0148: ldc.i4.1 
				L_0149: add 
				L_014a: stloc.0 
				L_014b: ldloc.0 
				L_014c: ldc.i4 288
				L_0151: blt.s L_013f
				L_0153: ret 
			*/
			
			public x71589e3f55261426 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
	}
	
}

