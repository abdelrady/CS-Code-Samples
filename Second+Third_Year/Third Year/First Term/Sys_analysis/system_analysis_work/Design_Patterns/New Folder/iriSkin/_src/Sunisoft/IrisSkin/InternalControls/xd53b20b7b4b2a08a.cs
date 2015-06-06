//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System.Collections;
			using System.Drawing;
			using System.Reflection;
			using System;
			
			
		#endregion
		
	// [DefaultMemberAttribute("Item")]
	internal class xd53b20b7b4b2a08a : x81f0e41c32f52159
	
	{
		
		#region Fields
			protected Color x184ba080a2db6d7f;
			protected string x4184883c68212fdb;
			protected Color x710613e295566dc0;
			protected bool x86c6e3905608c757;
			protected Brush xc9130b1a627ae655;
			protected Font xcc4dbf362617fd95;
			protected Brush xd960fa85a964da8f;
		#endregion
		
		#region Constructors
		
			public xd53b20b7b4b2a08a ()
			/*
				// Code Size: 72 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldstr ""
				L_000c: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String x4184883c68212fdb
				L_0011: ldarg.0 
				L_0012: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Font xcc4dbf362617fd95
				L_001c: ldarg.0 
				L_001d: call System.Drawing.SystemColors::System.Drawing.Color get_ActiveCaptionText()
				L_0022: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x710613e295566dc0
				L_0027: ldarg.0 
				L_0028: ldnull 
				L_0029: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xd960fa85a964da8f
				L_002e: ldarg.0 
				L_002f: call System.Drawing.SystemColors::System.Drawing.Color get_ActiveCaption()
				L_0034: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x184ba080a2db6d7f
				L_0039: ldarg.0 
				L_003a: ldnull 
				L_003b: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xc9130b1a627ae655
				L_0040: ldarg.0 
				L_0041: ldc.i4.0 
				L_0042: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean x86c6e3905608c757
				L_0047: ret 
			*/
		#endregion
		
		#region Properties
		
			public Brush x0a00a4ce1ac2b818
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xd960fa85a964da8f
					L_0006: ret 
				*/
				
				{
					return this.xd960fa85a964da8f;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xd960fa85a964da8f
					L_0007: ret 
				*/
				
				{
					this.xd960fa85a964da8f = value;
				}
			}
			
			
			public Font x5af2f9fd52bb2f28
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Font xcc4dbf362617fd95
					L_0006: ret 
				*/
				
				{
					return this.xcc4dbf362617fd95;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Font xcc4dbf362617fd95
					L_0007: ret 
				*/
				
				{
					this.xcc4dbf362617fd95 = value;
				}
			}
			
			
			public Color x64752539024e52b4
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x710613e295566dc0
					L_0006: ret 
				*/
				
				{
					return this.x710613e295566dc0;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x710613e295566dc0
					L_0007: ret 
				*/
				
				{
					this.x710613e295566dc0 = value;
				}
			}
			
			
			public bool x6f72c846c7dcb042
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean x86c6e3905608c757
					L_0006: ret 
				*/
				
				{
					return this.x86c6e3905608c757;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean x86c6e3905608c757
					L_0007: ret 
				*/
				
				{
					this.x86c6e3905608c757 = value;
				}
			}
			
			
			public string x95e21d0daad2a69e
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String x4184883c68212fdb
					L_0006: ret 
				*/
				
				{
					return this.x4184883c68212fdb;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String x4184883c68212fdb
					L_0007: ret 
				*/
				
				{
					this.x4184883c68212fdb = value;
				}
			}
			
			
			public Brush x9bb803f1a1f3f613
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xc9130b1a627ae655
					L_0006: ret 
				*/
				
				{
					return this.xc9130b1a627ae655;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush xc9130b1a627ae655
					L_0007: ret 
				*/
				
				{
					this.xc9130b1a627ae655 = value;
				}
			}
			
			
			public x5f4b657f68f87baa get_xe6d4b1b411ed94b5 (string xb41faee6912a2313)
			
			/*
				// Code Size: 75 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_000c to L_0036 finally L_0036 to L_0047
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_000b: stloc.2 
				L_000c: br.s L_002c
				L_000e: ldloc.2 
				L_000f: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0014: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0019: stloc.0 
				L_001a: ldloc.0 
				L_001b: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_0020: ldarg.1 
				L_0021: call System.String::Boolean op_Equality(System.String, System.String)
				L_0026: brfalse.s L_002c
				L_0028: ldloc.0 
				L_0029: stloc.1 
				L_002a: leave.s L_0049
				L_002c: ldloc.2 
				L_002d: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0032: brtrue.s L_000e
				L_0034: leave.s L_0047
				L_0036: ldloc.2 
				L_0037: isinst System.IDisposable
				L_003c: stloc.3 
				L_003d: ldloc.3 
				L_003e: brfalse.s L_0046
				L_0040: ldloc.3 
				L_0041: callvirt System.IDisposable::Void Dispose()
				L_0046: endfinally 
				L_0047: ldnull 
				L_0048: ret 
				L_0049: ldloc.1 
				L_004a: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in base.List)
				{
					if (x5f4b657f68f87baa1.Text == xb41faee6912a2313)
					{
						return x5f4b657f68f87baa1;
					}
				}
				return null;
			}
			
			
			public x5f4b657f68f87baa get_xe6d4b1b411ed94b5 (int xc0c4c459c6ccbd00)
			
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::System.Object get_Item(Int32)
				L_000c: isinst Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0011: ret 
			*/
			
			
			{
				return (base.List[xc0c4c459c6ccbd00] as x5f4b657f68f87baa);
			}
			
			
			public Color xf66c387eec1b0e74
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x184ba080a2db6d7f
					L_0006: ret 
				*/
				
				{
					return this.x184ba080a2db6d7f;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color x184ba080a2db6d7f
					L_0007: ret 
				*/
				
				{
					this.x184ba080a2db6d7f = value;
				}
			}
			
		#endregion
		
		#region Methods
		
			public bool x263d579af1d0d43f (x5f4b657f68f87baa xbcea506a33cf9111)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::Boolean Contains(System.Object)
				L_000c: ret 
			*/
			
			
			{
				return base.List.Contains (xbcea506a33cf9111);
			}
			
			public int x2ee5ad3d826ed0fe (x5f4b657f68f87baa xbcea506a33cf9111)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::Int32 IndexOf(System.Object)
				L_000c: ret 
			*/
			
			
			{
				return base.List.IndexOf (xbcea506a33cf9111);
			}
			
			public void x52b190e626f65140 (x5f4b657f68f87baa xbcea506a33cf9111)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::Void Remove(System.Object)
				L_000c: ret 
			*/
			
			
			{
				base.List.Remove (xbcea506a33cf9111);
			}
			
			public bool xb7b226d9e2df0fa0 ()
			
			/*
				// Code Size: 114 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         System.Boolean V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_000c to L_005d finally L_005d to L_006e
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_000b: stloc.2 
				L_000c: br.s L_0053
				L_000e: ldloc.2 
				L_000f: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0014: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0019: stloc.0 
				L_001a: ldloc.0 
				L_001b: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Visible()
				L_0020: brfalse.s L_0053
				L_0022: ldloc.0 
				L_0023: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_0028: ldstr "-"
				L_002d: call System.String::Boolean op_Inequality(System.String, System.String)
				L_0032: brfalse.s L_0053
				L_0034: ldloc.0 
				L_0035: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_003a: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_003f: ldc.i4.0 
				L_0040: ble.s L_004f
				L_0042: ldloc.0 
				L_0043: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0048: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean xb7b226d9e2df0fa0()
				L_004d: brfalse.s L_0053
				L_004f: ldc.i4.1 
				L_0050: stloc.1 
				L_0051: leave.s L_0070
				L_0053: ldloc.2 
				L_0054: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0059: brtrue.s L_000e
				L_005b: leave.s L_006e
				L_005d: ldloc.2 
				L_005e: isinst System.IDisposable
				L_0063: stloc.3 
				L_0064: ldloc.3 
				L_0065: brfalse.s L_006d
				L_0067: ldloc.3 
				L_0068: callvirt System.IDisposable::Void Dispose()
				L_006d: endfinally 
				L_006e: ldc.i4.0 
				L_006f: ret 
				L_0070: ldloc.1 
				L_0071: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in base.List)
				{
					if (x5f4b657f68f87baa1.Visible && (x5f4b657f68f87baa1.Text != "-"))
					{
						if (x5f4b657f68f87baa1.MenuCommands.Count <= 0)
						{
							return true;
						}
						else if (x5f4b657f68f87baa1.MenuCommands.xb7b226d9e2df0fa0 ())
						{
							return true;
						}
					}
				}
				return false;
			}
			
			public x5f4b657f68f87baa xd6b6ed77479ef68c (x5f4b657f68f87baa xbcea506a33cf9111)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::Int32 Add(System.Object)
				L_000c: pop 
				L_000d: ldarg.1 
				L_000e: ret 
			*/
			
			
			{
				int i1 = base.List.Add (xbcea506a33cf9111);
				return xbcea506a33cf9111;
			}
			
			public void xef23aa45e7612fdd (int xc0c4c459c6ccbd00, x5f4b657f68f87baa xbcea506a33cf9111)
			
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: ldarg.2 
				L_0008: callvirt System.Collections.IList::Void Insert(Int32, System.Object)
				L_000d: ret 
			*/
			
			
			{
				base.List.Insert (xc0c4c459c6ccbd00, xbcea506a33cf9111);
			}
			
			public void xf82029c4e8b4cfc3 (x5f4b657f68f87baa[] x0788cd5a9865fc16)
			
			/*
				// Code Size: 29 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] V_1, 
         System.Int32 V_2)
				L_0000: ldarg.1 
				L_0001: stloc.1 
				L_0002: ldc.i4.0 
				L_0003: stloc.2 
				L_0004: br.s L_0016
				L_0006: ldloc.1 
				L_0007: ldloc.2 
				L_0008: ldelem.ref 
				L_0009: stloc.0 
				L_000a: ldarg.0 
				L_000b: ldloc.0 
				L_000c: call Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0011: pop 
				L_0012: ldloc.2 
				L_0013: ldc.i4.1 
				L_0014: add 
				L_0015: stloc.2 
				L_0016: ldloc.2 
				L_0017: ldloc.1 
				L_0018: ldlen 
				L_0019: conv.i4 
				L_001a: blt.s L_0006
				L_001c: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in x0788cd5a9865fc16)
				{
					x5f4b657f68f87baa x5f4b657f68f87baa2 = this.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
				}
			}
			
		#endregion
	}
	
}

