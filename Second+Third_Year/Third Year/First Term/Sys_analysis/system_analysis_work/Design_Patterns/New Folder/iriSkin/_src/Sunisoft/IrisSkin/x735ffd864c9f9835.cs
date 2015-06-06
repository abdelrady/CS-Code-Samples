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
		
	internal class x735ffd864c9f9835
	
	{
		
		#region Constructors
		
			public x735ffd864c9f9835 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static x5b126f5f998c28e9 xebcf83b00134300b (IntPtr x45cb9c0352055524, string xc15bd84e01929885, ISkinEngine xcab6a0e662ada486)
			
			/*
				// Code Size: 141 Bytes
				.maxstack 4
				L_0000: ldarg.1 
				L_0001: ldstr "BUTTON"
				L_0006: call System.String::Boolean op_Equality(System.String, System.String)
				L_000b: brfalse.s L_0015
				L_000d: ldarg.0 
				L_000e: ldarg.2 
				L_000f: newobj Sunisoft.IrisSkin.x52106a473347a957::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0014: ret 
				L_0015: ldarg.1 
				L_0016: ldstr "BUTTON_CHECKBOX"
				L_001b: call System.String::Boolean op_Equality(System.String, System.String)
				L_0020: brfalse.s L_002a
				L_0022: ldarg.0 
				L_0023: ldarg.2 
				L_0024: newobj Sunisoft.IrisSkin.xdbcc71de92f8e117::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0029: ret 
				L_002a: ldarg.1 
				L_002b: ldstr "BUTTON_RADIOBUTTON"
				L_0030: call System.String::Boolean op_Equality(System.String, System.String)
				L_0035: brfalse.s L_003f
				L_0037: ldarg.0 
				L_0038: ldarg.2 
				L_0039: newobj Sunisoft.IrisSkin.xcf289f871d952cfd::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_003e: ret 
				L_003f: ldarg.1 
				L_0040: ldstr "COMBOBOX"
				L_0045: call System.String::Boolean op_Equality(System.String, System.String)
				L_004a: brtrue.s L_0059
				L_004c: ldarg.1 
				L_004d: ldstr "COMBOBOXEX32"
				L_0052: call System.String::Boolean op_Equality(System.String, System.String)
				L_0057: brfalse.s L_0061
				L_0059: ldarg.0 
				L_005a: ldarg.2 
				L_005b: newobj Sunisoft.IrisSkin.x4c8858ac0e107176::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0060: ret 
				L_0061: ldarg.1 
				L_0062: ldstr "SYSTABCONTROL32"
				L_0067: call System.String::Boolean op_Equality(System.String, System.String)
				L_006c: brfalse.s L_0076
				L_006e: ldarg.0 
				L_006f: ldarg.2 
				L_0070: newobj Sunisoft.IrisSkin.x224a55c9c6142e96::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0075: ret 
				L_0076: ldarg.1 
				L_0077: ldstr "TOOLBARWINDOW32"
				L_007c: call System.String::Boolean op_Equality(System.String, System.String)
				L_0081: brfalse.s L_008b
				L_0083: ldarg.0 
				L_0084: ldarg.2 
				L_0085: newobj Sunisoft.IrisSkin.x3ee27da79bc28367::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_008a: ret 
				L_008b: ldnull 
				L_008c: ret 
			*/
			
			
			{
				switch (xc15bd84e01929885)
				{
					case "BUTTON":
					
					{
							return new x52106a473347a957 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "BUTTON_CHECKBOX":
					
					{
							return new xdbcc71de92f8e117 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "BUTTON_RADIOBUTTON":
					
					{
							return new xcf289f871d952cfd (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "COMBOBOX":
					
					{
							return new x4c8858ac0e107176 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "COMBOBOXEX32":
					
					{
							return new x4c8858ac0e107176 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "SYSTABCONTROL32":
					
					{
							return new x224a55c9c6142e96 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					case "TOOLBARWINDOW32":
					
					{
							return new x3ee27da79bc28367 (x45cb9c0352055524, xcab6a0e662ada486);
					}
					default:
					
					{
							return null;
					}
				}
			}
			
		#endregion
	}
	
}

