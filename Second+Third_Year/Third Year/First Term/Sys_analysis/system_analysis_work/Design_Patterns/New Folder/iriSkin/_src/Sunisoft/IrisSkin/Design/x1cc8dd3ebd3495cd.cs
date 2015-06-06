//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.Design

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Windows.Forms.Design;
			using System.Windows.Forms;
			
			
		#endregion
		
	public class x1cc8dd3ebd3495cd : FileNameEditor
	
	{
		
		#region Constructors
		
			public x1cc8dd3ebd3495cd ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Design.FileNameEditor::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void InitializeDialog (OpenFileDialog openFileDialog)
			
			/*
				// Code Size: 33 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call System.Windows.Forms.Design.FileNameEditor::Void InitializeDialog(System.Windows.Forms.OpenFileDialog)
				L_0007: ldarg.1 
				L_0008: ldc.i4.1 
				L_0009: callvirt System.Windows.Forms.FileDialog::Void set_CheckFileExists(Boolean)
				L_000e: ldarg.1 
				L_000f: ldc.i4.1 
				L_0010: callvirt System.Windows.Forms.FileDialog::Void set_CheckPathExists(Boolean)
				L_0015: ldarg.1 
				L_0016: ldstr "Sunisoft skin file (ssk file) | *.ssk"
				L_001b: callvirt System.Windows.Forms.FileDialog::Void set_Filter(System.String)
				L_0020: ret 
			*/
			
			
			{
				base.InitializeDialog (openFileDialog);
				openFileDialog.CheckFileExists = true;
				openFileDialog.CheckPathExists = true;
				openFileDialog.Filter = "Sunisoft skin file (ssk file) | *.ssk";
			}
			
		#endregion
	}
	
}

