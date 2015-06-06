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
		
	public interface IRes : IDisposable
	
	{
		
		#region Properties
		
			ISkinBitmaps Bitmaps
			
			{
				get;
			}
			
			
			ISkinBools Bools
			
			{
				get;
			}
			
			
			ISkinBrushes Brushes
			
			{
				get;
			}
			
			
			ISkinColors Colors
			
			{
				get;
			}
			
			
			ISkinInt Integers
			
			{
				get;
			}
			
			
			ScrollBarRes ScrollBarRes
			
			{
				get;
			}
			
			
			ISplitBitmaps SplitBitmaps
			
			{
				get;
			}
			
			
			TabControlRes TabControlRes
			
			{
				get;
			}
			
		#endregion
	}
	
}

