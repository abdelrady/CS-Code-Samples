//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Drawing;
			using System;
			
			
		#endregion
		
	public interface ISplitBitmaps : IDisposable
	
	{
		
		#region Properties
		
			Bitmap[] SKIN2_BUTTON
			
			{
				get;
			}
			
			
			Bitmap[] SKIN2_CHECKBOX
			
			{
				get;
			}
			
			
			Bitmap[] SKIN2_RADIOBUTTON
			
			{
				get;
			}
			
			
			Bitmap[] SKIN2_TITLEBUTTONS
			
			{
				get;
			}
			
		#endregion
	}
	
}

