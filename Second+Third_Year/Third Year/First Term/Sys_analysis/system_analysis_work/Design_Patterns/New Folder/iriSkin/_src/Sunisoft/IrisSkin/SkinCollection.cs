//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using Sunisoft.IrisSkin.Design;
			using System.Collections;
			using System.ComponentModel;
			using System.Drawing.Design;
			using System.Reflection;
			using System;
			
			
		#endregion
		
	// [DefaultMemberAttribute("Item")]
	[EditorAttribute(((Type) typeof (xf4009cb7cc23b91e)), ((Type) typeof (UITypeEditor)))]
	public class SkinCollection : CollectionBase, ISkinCollection
	
	{
		
		#region Constructors
		
			internal SkinCollection ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Properties
		
			public ISkinCollectionItem this[int index]
			
			{
				get
				
				/*
					// Code Size: 18 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
					L_0006: ldarg.1 
					L_0007: callvirt System.Collections.IList::System.Object get_Item(Int32)
					L_000c: castclass Sunisoft.IrisSkin.SkinCollectionItem
					L_0011: ret 
				*/
				
				{
					return ((ISkinCollectionItem) base.List[index]);
				}
			}
			
		#endregion
		
		#region Methods
		
			public ISkinCollectionItem Add (ISkinCollectionItem item)
			
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
				int i1 = base.List.Add (item);
				return item;
			}
			
			public void Remove (ISkinCollectionItem item)
			
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
				base.List.Remove (item);
			}
			
			public void Remove (int index)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Collections.CollectionBase::System.Collections.IList get_List()
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.IList::Void RemoveAt(Int32)
				L_000c: ret 
			*/
			
			
			{
				base.List.RemoveAt (index);
			}
			
		#endregion
	}
	
}

