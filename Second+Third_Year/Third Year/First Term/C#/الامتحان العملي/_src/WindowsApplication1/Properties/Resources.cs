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
			using System.ComponentModel;
			using System.Diagnostics;
			using System.Globalization;
			using System.Reflection;
			using System.Resources;
			using System.Runtime.CompilerServices;
			using System;
			
			
		#endregion
		
	[DebuggerNonUserCodeAttribute()]
	[CompilerGeneratedAttribute()]
	[GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	internal class Resources
	
	{
		
		#region Fields
			private static CultureInfo resourceCulture;
			private static ResourceManager resourceMan;
		#endregion
		
		#region Constructors

        internal Resources() { }
			/*
				// Code Size: 7 Bytes
				.maxstack 8
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Properties
		
			[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
			internal static CultureInfo Culture
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 8
					L_0000: ldsfld WindowsApplication1.Properties.Resources::System.Globalization.CultureInfo resourceCulture
					L_0005: ret 
				*/
				
				{
					return Resources.resourceCulture;
				}
				set
				
				/*
					// Code Size: 7 Bytes
					.maxstack 8
					L_0000: ldarg.0 
					L_0001: stsfld WindowsApplication1.Properties.Resources::System.Globalization.CultureInfo resourceCulture
					L_0006: ret 
				*/
				
				{
					Resources.resourceCulture = value;
				}
			}
			
			
			[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
			internal static ResourceManager ResourceManager
			
			{
				get
				
				/*
					// Code Size: 45 Bytes
					.maxstack 3
					.locals (System.Resources.ResourceManager V_0)
					L_0000: ldsfld WindowsApplication1.Properties.Resources::System.Resources.ResourceManager resourceMan
					L_0005: brtrue.s L_0027
					L_0007: ldstr "WindowsApplication1.Properties.Resources"
					L_000c: ldtoken WindowsApplication1.Properties.Resources
					L_0011: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
					L_0016: callvirt System.Type::System.Reflection.Assembly get_Assembly()
					L_001b: newobj System.Resources.ResourceManager::Void .ctor(System.String, System.Reflection.Assembly)
					L_0020: stloc.0 
					L_0021: ldloc.0 
					L_0022: stsfld WindowsApplication1.Properties.Resources::System.Resources.ResourceManager resourceMan
					L_0027: ldsfld WindowsApplication1.Properties.Resources::System.Resources.ResourceManager resourceMan
					L_002c: ret 
				*/
				
				{
					if (Resources.resourceMan != null)
					{
						return Resources.resourceMan;
					}
					System.Resources.ResourceManager temp1 = new System.Resources.ResourceManager ("WindowsApplication1.Properties.Resources", typeof (Resources).Assembly);
					Resources.resourceMan = temp1;
					return Resources.resourceMan;
				}
			}
			
		#endregion
	}
	
}

