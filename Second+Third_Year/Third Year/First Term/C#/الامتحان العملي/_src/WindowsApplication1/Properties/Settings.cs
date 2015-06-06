//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 25/12/2006 02:25:34 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace WindowsApplication1.Properties

{
		
		#region Namespace Import Declarations
		
			using System.CodeDom.Compiler;
			using System.Configuration;
			using System.Runtime.CompilerServices;
			using System;
			
			
		#endregion
		
	[GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	[CompilerGeneratedAttribute()]
	internal sealed class Settings : ApplicationSettingsBase
	
	{
		
		#region Fields
			private static Settings defaultInstance;
		#endregion
		
		#region Constructors
		
			public Settings (){}
			/*
				// Code Size: 7 Bytes
				.maxstack 8
				L_0000: ldarg.0 
				L_0001: call System.Configuration.ApplicationSettingsBase::Void .ctor()
				L_0006: ret 
			*/

        static Settings() { }
			/*
				// Code Size: 21 Bytes
				.maxstack 8
				L_0000: newobj WindowsApplication1.Properties.Settings::Void .ctor()
				L_0005: call System.Configuration.SettingsBase::System.Configuration.SettingsBase Synchronized(System.Configuration.SettingsBase)
				L_000a: castclass WindowsApplication1.Properties.Settings
				L_000f: stsfld WindowsApplication1.Properties.Settings::WindowsApplication1.Properties.Settings defaultInstance
				L_0014: ret 
			*/
		#endregion
		
		#region Properties
		
			public static Settings Default
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 8
					L_0000: ldsfld WindowsApplication1.Properties.Settings::WindowsApplication1.Properties.Settings defaultInstance
					L_0005: ret 
				*/
				
				{
					return Settings.defaultInstance;
				}
			}
			
		#endregion
	}
	
}

