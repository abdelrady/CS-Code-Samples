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
		
	internal class x3e6caec60640904a : x2edc3f693fe78d2e
	
	{
		
		#region Constructors
		
			public x3e6caec60640904a (Control control, ISkinEngine engine)
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
					L_0000: ldc.i4.1 
					L_0001: ret 
				*/
				
				{
					return 1;
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
			
		#endregion
		
		#region Methods
		
			protected override void DoInit ()
			
			/*
				// Code Size: 78 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.Control V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: isinst System.Windows.Forms.NumericUpDown
				L_0012: brtrue.s L_0046
				L_0014: ldloc.0 
				L_0015: isinst System.Windows.Forms.ListView
				L_001a: brtrue.s L_0046
				L_001c: ldloc.0 
				L_001d: isinst System.Windows.Forms.DataGrid
				L_0022: brtrue.s L_0046
				L_0024: ldloc.0 
				L_0025: isinst System.Windows.Forms.ListBox
				L_002a: brtrue.s L_0046
				L_002c: ldloc.0 
				L_002d: isinst System.Windows.Forms.PropertyGrid
				L_0032: brtrue.s L_0046
				L_0034: ldloc.0 
				L_0035: callvirt System.Windows.Forms.Control::System.String get_CompanyName()
				L_003a: ldstr "Infragistics, Inc. (www.infragistics.com)"
				L_003f: call System.String::Boolean op_Equality(System.String, System.String)
				L_0044: brfalse.s L_0047
				L_0046: ret 
				L_0047: ldarg.0 
				L_0048: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_004d: ret 
			*/
			
			
			{
				Control control1 = base.xcd9cdf30888d2204.Parent;
				if ((! (control1 is NumericUpDown)) && ((! (control1 is ListView)) && ((! (control1 is DataGrid)) && ((! (control1 is ListBox)) && ((! (control1 is PropertyGrid)) && (control1.CompanyName != "Infragistics, Inc. (www.infragistics.com)"))))))
				{
					base.DoInit ();
				}
			}
			
		#endregion
	}
	
}

