//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 04/01/2007 01:05:16 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Students__House_Control

{
		
		#region Namespace Import Declarations
		
			using System.ComponentModel;
			using System.Data.OleDb;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	public interface Ipones : IComponent, IDisposable, IDropTarget, ISynchronizeInvoke, IWin32Window, IBindableComponent, IContainerControl
	
	{
		
		#region Generated Properties
		
			OleDbConnection DBConnection
			
			{
				 get;  set; 
			}
			
			
			string Dblocation
			
			{
				 get;  set; 
			}
			
			
			int RowPointer
			
			{
				 get;  set; 
			}
			
		#endregion
		
		#region Original Properties
		
		#endregion
		
		#region Methods
		
			void initilizeCount ();
			void showData ();
			void UPdatePonesByGivingItToStudents ();
		#endregion
	}
	
}

