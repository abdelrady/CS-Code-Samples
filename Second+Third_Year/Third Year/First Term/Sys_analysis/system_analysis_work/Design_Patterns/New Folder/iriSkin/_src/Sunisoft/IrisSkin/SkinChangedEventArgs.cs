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
		
	public class SkinChangedEventArgs : EventArgs, ISkinChangedEventArgs
	
	{
		
		#region Fields
			private bool x9315ecd224bb4564;
		#endregion
		
		#region Constructors
		
			public SkinChangedEventArgs (bool realActive)
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.EventArgs::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinChangedEventArgs::Boolean x9315ecd224bb4564
				L_000d: ret 
			*/
		#endregion
		
		#region Properties
		
			public bool RealActive
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinChangedEventArgs::Boolean x9315ecd224bb4564
					L_0006: ret 
				*/
				
				{
					return this.x9315ecd224bb4564;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinChangedEventArgs::Boolean x9315ecd224bb4564
					L_0007: ret 
				*/
				
				{
					this.x9315ecd224bb4564 = value;
				}
			}
			
		#endregion
	}
	
}

