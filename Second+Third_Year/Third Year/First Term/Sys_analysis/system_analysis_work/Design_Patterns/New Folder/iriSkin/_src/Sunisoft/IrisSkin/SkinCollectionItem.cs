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
			using System;
			using System.ComponentModel;
			using System.Drawing.Design;
			using System.Drawing;
			using System.IO;
			
			
		#endregion
		
	[SerializableAttribute()]
	[TypeConverterAttribute(((Type) typeof (TypeConverter)))]
	[ToolboxItemAttribute(false)]
	[ToolboxBitmapAttribute(((Type) typeof (SkinEngine)), "ItemIcon.bmp")]
	public class SkinCollectionItem : Component, ISkinCollectionItem
	
	{
		
		#region Fields
			[NonSerializedAttribute()]
			private Ix7f0ebae1a2d30adf reader;
			private string skinFile;
			private MemoryStream skinStream;
		#endregion
		
		#region Constructors
		
			public SkinCollectionItem ()
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.SkinCollectionItem::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_000b: ldarg.0 
				L_000c: call System.ComponentModel.Component::Void .ctor()
				L_0011: ret 
			*/
			
			public SkinCollectionItem (string fileName)
			/*
				// Code Size: 25 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.SkinCollectionItem::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_000b: ldarg.0 
				L_000c: call System.ComponentModel.Component::Void .ctor()
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: call Sunisoft.IrisSkin.SkinCollectionItem::Void set_SkinFile(System.String)
				L_0018: ret 
			*/
		#endregion
		
		#region Properties
		
			[DescriptionAttribute("Specifies the skin file(.sui file). ")]
			[DesignOnlyAttribute(true)]
			[CategoryAttribute("Skins")]
			[EditorAttribute(((Type) typeof (x1cc8dd3ebd3495cd)), ((Type) typeof (UITypeEditor)))]
			public string SkinFile
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinCollectionItem::System.String skinFile
					L_0006: ret 
				*/
				
				{
					return this.skinFile;
				}
				set
				
				/*
					// Code Size: 22 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinCollectionItem::System.String skinFile
					L_0006: ldarg.1 
					L_0007: call System.String::Boolean op_Inequality(System.String, System.String)
					L_000c: brfalse.s L_0015
					L_000e: ldarg.0 
					L_000f: ldarg.1 
					L_0010: call Sunisoft.IrisSkin.SkinCollectionItem::Void OnSkinFileChanged(System.String)
					L_0015: ret 
				*/
				
				{
					if (this.skinFile != value)
					{
						this.OnSkinFileChanged (value);
					}
				}
			}
			
			
			[DefaultValueAttribute("")]
			[CategoryAttribute("Skins")]
			[DescriptionAttribute("Specifies the password of the skinFile")]
			public string SkinPassword
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinCollectionItem::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
					L_0006: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String get_x2a6dc4421904bcaa()
					L_000b: ret 
				*/
				
				{
					return ((Ix7f0ebae1a2d30adf) this.reader).x2a6dc4421904bcaa;
				}
				set
				
				/*
					// Code Size: 13 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinCollectionItem::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
					L_0006: ldarg.1 
					L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x2a6dc4421904bcaa(System.String)
					L_000c: ret 
				*/
				
				{
					((Ix7f0ebae1a2d30adf) this.reader).x2a6dc4421904bcaa = value;
				}
			}
			
			
			[BrowsableAttribute(false)]
			public MemoryStream SkinSteam
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinCollectionItem::System.IO.MemoryStream skinStream
					L_0006: ret 
				*/
				
				{
					return this.skinStream;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinCollectionItem::System.IO.MemoryStream skinStream
					L_0007: ret 
				*/
				
				{
					this.skinStream = value;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected void OnSkinFileChanged (string file)
			
			/*
				// Code Size: 96 Bytes
				.maxstack 5
				.locals (System.IO.FileStream V_0, 
         System.IO.BinaryReader V_1)
				.try L_0018 to L_005c catch System.Object L_005c to L_005f
				L_0000: ldarg.1 
				L_0001: brfalse.s L_0010
				L_0003: ldarg.1 
				L_0004: ldstr ""
				L_0009: call System.String::Boolean op_Equality(System.String, System.String)
				L_000e: brfalse.s L_0018
				L_0010: ldarg.0 
				L_0011: ldnull 
				L_0012: stfld Sunisoft.IrisSkin.SkinCollectionItem::System.IO.MemoryStream skinStream
				L_0017: ret 
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.SkinCollectionItem::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_001e: ldarg.1 
				L_001f: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_xf716b51dec80747d(System.String)
				L_0024: ldarg.1 
				L_0025: ldc.i4.3 
				L_0026: ldc.i4.1 
				L_0027: ldc.i4.1 
				L_0028: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_002d: stloc.0 
				L_002e: ldloc.0 
				L_002f: newobj System.IO.BinaryReader::Void .ctor(System.IO.Stream)
				L_0034: stloc.1 
				L_0035: ldarg.0 
				L_0036: ldloc.1 
				L_0037: ldloc.0 
				L_0038: callvirt System.IO.Stream::Int64 get_Length()
				L_003d: conv.i4 
				L_003e: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_0043: newobj System.IO.MemoryStream::Void .ctor(Byte[])
				L_0048: stfld Sunisoft.IrisSkin.SkinCollectionItem::System.IO.MemoryStream skinStream
				L_004d: ldloc.1 
				L_004e: callvirt System.IO.BinaryReader::Void Close()
				L_0053: ldarg.0 
				L_0054: ldarg.1 
				L_0055: stfld Sunisoft.IrisSkin.SkinCollectionItem::System.String skinFile
				L_005a: leave.s L_005f
				L_005c: pop 
				L_005d: leave.s L_005f
				L_005f: ret 
			*/
			
			
			{
				FileStream fileStream1;
				BinaryReader binaryReader1;
				if ((file == null) || (file == ""))
				{
					this.skinStream = ((MemoryStream) null);
				}
				else
				{
					try
					{
						((Ix7f0ebae1a2d30adf) this.reader).xf716b51dec80747d = file;
						fileStream1 = File.Open (file, FileMode.Open, FileAccess.Read, FileShare.Read);
						binaryReader1 = new BinaryReader (((Stream) fileStream1));
						this.skinStream = new MemoryStream (binaryReader1.ReadBytes (((int) fileStream1.Length)));
						binaryReader1.Close ();
						this.skinFile = file;
					}
					catch
					{
					}
				}
			}
			
		#endregion
	}
	
}

