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
			using System;
			
			
		#endregion
		
	internal class x81f0e41c32f52159 : CollectionBase
	
	{
		
		#region Fields
			public event x66edf89974942dab x18717d558d54a6dc;
			private int xa83ef27b7a71ab3f;
			public event x2f6aff803d60b50c xb1acec69632d2193;
			public event x2f6aff803d60b50c xb56f44eae6e354a0;
			public event x66edf89974942dab xebadb072f5851c44;
			public event x2f6aff803d60b50c xf12ffa4bc2262d75;
			public event x2f6aff803d60b50c xf41c8c66e3182d79;
		#endregion
		
		#region Constructors
		
			public x81f0e41c32f52159 ()
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldc.i4.0 
				L_0008: stfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
				L_000d: ret 
			*/
		#endregion
		
		#region Properties
		
			public bool xbab53d46b13d3f4d
			
			{
				get
				
				/*
					// Code Size: 10 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
					L_0006: ldc.i4.0 
					L_0007: cgt 
					L_0009: ret 
				*/
				
				{
					return (this.xa83ef27b7a71ab3f > 0);
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void OnClear ()
			
			/*
				// Code Size: 29 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x66edf89974942dab x18717d558d54a6dc
				L_000f: brfalse.s L_001c
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x66edf89974942dab x18717d558d54a6dc
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x66edf89974942dab::Void Invoke()
				L_001c: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.x18717d558d54a6dc != null))
				{
					this.x18717d558d54a6dc ();
				}
			}
			
			protected override void OnClearComplete ()
			
			/*
				// Code Size: 29 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x66edf89974942dab xebadb072f5851c44
				L_000f: brfalse.s L_001c
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x66edf89974942dab xebadb072f5851c44
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x66edf89974942dab::Void Invoke()
				L_001c: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.xebadb072f5851c44 != null))
				{
					this.xebadb072f5851c44 ();
				}
			}
			
			protected override void OnInsert (int index, object value)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xf12ffa4bc2262d75
				L_000f: brfalse.s L_001e
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xf12ffa4bc2262d75
				L_0017: ldarg.1 
				L_0018: ldarg.2 
				L_0019: callvirt Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void Invoke(Int32, System.Object)
				L_001e: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.xf12ffa4bc2262d75 != null))
				{
					this.xf12ffa4bc2262d75 (index, value);
				}
			}
			
			protected override void OnInsertComplete (int index, object value)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xb1acec69632d2193
				L_000f: brfalse.s L_001e
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xb1acec69632d2193
				L_0017: ldarg.1 
				L_0018: ldarg.2 
				L_0019: callvirt Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void Invoke(Int32, System.Object)
				L_001e: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.xb1acec69632d2193 != null))
				{
					this.xb1acec69632d2193 (index, value);
				}
			}
			
			protected override void OnRemove (int index, object value)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xf41c8c66e3182d79
				L_000f: brfalse.s L_001e
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xf41c8c66e3182d79
				L_0017: ldarg.1 
				L_0018: ldarg.2 
				L_0019: callvirt Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void Invoke(Int32, System.Object)
				L_001e: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.xf41c8c66e3182d79 != null))
				{
					this.xf41c8c66e3182d79 (index, value);
				}
			}
			
			protected override void OnRemoveComplete (int index, object value)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Boolean get_xbab53d46b13d3f4d()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xb56f44eae6e354a0
				L_000f: brfalse.s L_001e
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c xb56f44eae6e354a0
				L_0017: ldarg.1 
				L_0018: ldarg.2 
				L_0019: callvirt Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void Invoke(Int32, System.Object)
				L_001e: ret 
			*/
			
			
			{
				if ((! this.xbab53d46b13d3f4d) && (this.xb56f44eae6e354a0 != null))
				{
					this.xb56f44eae6e354a0 (index, value);
				}
			}
			
			protected int x2ee5ad3d826ed0fe (object xbcea506a33cf9111)
			
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
			
			public void x6e5b80c4a5c6f243 ()
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: dup 
				L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
				L_0007: ldc.i4.1 
				L_0008: add 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
				L_000e: ret 
			*/
			
			
			{
				this.xa83ef27b7a71ab3f++;
			}
			
			public void xf5f4c9bcfc1ead0f ()
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: dup 
				L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
				L_0007: ldc.i4.1 
				L_0008: sub 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Int32 xa83ef27b7a71ab3f
				L_000e: ret 
			*/
			
			
			{
				this.xa83ef27b7a71ab3f--;
			}
			
		#endregion
	}
	
}

