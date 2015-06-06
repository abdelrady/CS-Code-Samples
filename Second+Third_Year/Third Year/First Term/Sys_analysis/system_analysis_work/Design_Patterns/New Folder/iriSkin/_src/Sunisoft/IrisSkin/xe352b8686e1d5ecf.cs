//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Globalization;
			using System.Reflection;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xe352b8686e1d5ecf
	
	{
		
		#region Fields
			private static Assembly xe16f4e54dbd828d7;
		#endregion
		
		#region Constructors
		
			static xe352b8686e1d5ecf ()
			/*
				// Code Size: 27 Bytes
				.maxstack 2
				.try L_0006 to L_0017 catch System.Object L_0017 to L_001a
				L_0000: ldnull 
				L_0001: stsfld Sunisoft.IrisSkin.xe352b8686e1d5ecf::System.Reflection.Assembly xe16f4e54dbd828d7
				L_0006: ldstr "IrisSkin_NetAdvantage53Win"
				L_000b: call System.Reflection.Assembly::System.Reflection.Assembly Load(System.String)
				L_0010: stsfld Sunisoft.IrisSkin.xe352b8686e1d5ecf::System.Reflection.Assembly xe16f4e54dbd828d7
				L_0015: leave.s L_001a
				L_0017: pop 
				L_0018: leave.s L_001a
				L_001a: ret 
			*/
			
			public xe352b8686e1d5ecf ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static void xebcf83b00134300b (Control x43bec302f92080b9, ISkinEngine xcab6a0e662ada486)
			
			/*
				// Code Size: 64 Bytes
				.maxstack 9
				.locals (System.Exception V_0, 
         System.Object[] V_1)
				.try L_0000 to L_0036 catch System.Exception L_0036 to L_003f
				L_0000: ldsfld Sunisoft.IrisSkin.xe352b8686e1d5ecf::System.Reflection.Assembly xe16f4e54dbd828d7
				L_0005: brfalse.s L_0034
				L_0007: ldsfld Sunisoft.IrisSkin.xe352b8686e1d5ecf::System.Reflection.Assembly xe16f4e54dbd828d7
				L_000c: ldstr "IrisSkinNetAdvantage53Win.Implement3rdControl"
				L_0011: ldc.i4.1 
				L_0012: ldc.i4 512
				L_0017: ldnull 
				L_0018: ldc.i4.2 
				L_0019: newarr System.Object
				L_001e: stloc.1 
				L_001f: ldloc.1 
				L_0020: ldc.i4.0 
				L_0021: ldarg.0 
				L_0022: stelem.ref 
				L_0023: ldloc.1 
				L_0024: ldc.i4.1 
				L_0025: ldarg.1 
				L_0026: stelem.ref 
				L_0027: ldloc.1 
				L_0028: call System.Globalization.CultureInfo::System.Globalization.CultureInfo get_CurrentCulture()
				L_002d: ldnull 
				L_002e: callvirt System.Reflection.Assembly::System.Object CreateInstance(System.String, Boolean, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
				L_0033: pop 
				L_0034: leave.s L_003f
				L_0036: stloc.0 
				L_0037: ldloc.0 
				L_0038: call System.Console::Void WriteLine(System.Object)
				L_003d: leave.s L_003f
				L_003f: ret 
			*/
			
			
			{
				Exception exception1;
				object[] objectArray1;
				try
				{
					if (xe352b8686e1d5ecf.xe16f4e54dbd828d7 != null)
					{
						objectArray1 = new object[] { x43bec302f92080b9, ((object) xcab6a0e662ada486) };
						object object1 = xe352b8686e1d5ecf.xe16f4e54dbd828d7.CreateInstance ("IrisSkinNetAdvantage53Win.Implement3rdControl", true, BindingFlags.CreateInstance, ((Binder) null), objectArray1, CultureInfo.CurrentCulture, ((object[]) null));
					}
				}
				catch (Exception exception2)
				{
					exception1 = exception2;
					Console.WriteLine (exception1);
				}
			}
			
		#endregion
	}
	
}

