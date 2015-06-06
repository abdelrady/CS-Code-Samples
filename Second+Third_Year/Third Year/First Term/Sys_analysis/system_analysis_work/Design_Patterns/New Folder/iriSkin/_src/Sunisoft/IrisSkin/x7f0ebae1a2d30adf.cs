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
			using System.Collections;
			using System.Drawing;
			using System.Drawing.Imaging;
			using System.IO;
			using System.Runtime.InteropServices;
			
			
		#endregion
		
	internal class x7f0ebae1a2d30adf : Ix7f0ebae1a2d30adf
	
	{
		
		#region Fields
			private string x2de0dddab0e399a9;
			private Hashtable x5e15c490aec0e408;
			private bool x6c7711ed04d2ac90;
			private Stream x6d84580748d50f45;
			private string x9fc8c6f4ce2be206;
			private Hashtable xb41dc438649d784b;
			private Hashtable xc41ca09fad45f9ee;
		#endregion
		
		#region Constructors
		
			public x7f0ebae1a2d30adf ()
			/*
				// Code Size: 47 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
				L_0007: ldarg.0 
				L_0008: newobj System.Collections.Hashtable::Void .ctor()
				L_000d: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0012: ldarg.0 
				L_0013: newobj System.Collections.Hashtable::Void .ctor()
				L_0018: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_001d: ldarg.0 
				L_001e: newobj System.Collections.Hashtable::Void .ctor()
				L_0023: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0028: ldarg.0 
				L_0029: call System.Object::Void .ctor()
				L_002e: ret 
			*/
			
			public x7f0ebae1a2d30adf (Stream stream)
			/*
				// Code Size: 54 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
				L_0007: ldarg.0 
				L_0008: newobj System.Collections.Hashtable::Void .ctor()
				L_000d: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0012: ldarg.0 
				L_0013: newobj System.Collections.Hashtable::Void .ctor()
				L_0018: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_001d: ldarg.0 
				L_001e: newobj System.Collections.Hashtable::Void .ctor()
				L_0023: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0028: ldarg.0 
				L_0029: call System.Object::Void .ctor()
				L_002e: ldarg.0 
				L_002f: ldarg.1 
				L_0030: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x896404322349820a(System.IO.Stream)
				L_0035: ret 
			*/
			
			public x7f0ebae1a2d30adf (string skin)
			/*
				// Code Size: 54 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
				L_0007: ldarg.0 
				L_0008: newobj System.Collections.Hashtable::Void .ctor()
				L_000d: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0012: ldarg.0 
				L_0013: newobj System.Collections.Hashtable::Void .ctor()
				L_0018: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_001d: ldarg.0 
				L_001e: newobj System.Collections.Hashtable::Void .ctor()
				L_0023: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0028: ldarg.0 
				L_0029: call System.Object::Void .ctor()
				L_002e: ldarg.0 
				L_002f: ldarg.1 
				L_0030: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_xf716b51dec80747d(System.String)
				L_0035: ret 
			*/
		#endregion
		
		#region Properties
		
			string Ix7f0ebae1a2d30adf.x2a6dc4421904bcaa
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
					L_0006: ret 
				*/
				
				{
					return this.x2de0dddab0e399a9;
				}
				set
				
				/*
					// Code Size: 28 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
					L_0006: ldarg.1 
					L_0007: call System.String::Boolean op_Inequality(System.String, System.String)
					L_000c: brfalse.s L_001b
					L_000e: ldarg.0 
					L_000f: ldarg.1 
					L_0010: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
					L_0015: ldarg.0 
					L_0016: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void SkinPasswordChanged()
					L_001b: ret 
				*/
				
				{
					if (this.x2de0dddab0e399a9 != value)
					{
						this.x2de0dddab0e399a9 = value;
						this.SkinPasswordChanged ();
					}
				}
			}
			
			
			Stream Ix7f0ebae1a2d30adf.x896404322349820a
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.IO.Stream x6d84580748d50f45
					L_0006: ret 
				*/
				
				{
					return this.x6d84580748d50f45;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void OnSkinStreamChanged(System.IO.Stream)
					L_0007: ret 
				*/
				
				{
					this.OnSkinStreamChanged (value);
				}
			}
			
			
			bool Ix7f0ebae1a2d30adf.xb591119eb9470315
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
					L_0006: ret 
				*/
				
				{
					return this.x6c7711ed04d2ac90;
				}
			}
			
			
			string Ix7f0ebae1a2d30adf.xf716b51dec80747d
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x9fc8c6f4ce2be206
					L_0006: ret 
				*/
				
				{
					return this.x9fc8c6f4ce2be206;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void OnSkinFileChanged(System.String)
					L_0007: ret 
				*/
				
				{
					this.OnSkinFileChanged (value);
				}
			}
			
		#endregion
		
		#region Methods
		
			protected virtual void OnSkinFileChanged (string fileName)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void x2fd0a49330761d63(System.String)
				L_0007: ldarg.0 
				L_0008: ldarg.1 
				L_0009: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x9fc8c6f4ce2be206
				L_000e: ret 
			*/
			
			
			{
				this.x2fd0a49330761d63 (fileName);
				this.x9fc8c6f4ce2be206 = fileName;
			}
			
			protected virtual void OnSkinStreamChanged (Stream stream)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void x2fd0a49330761d63(System.IO.Stream)
				L_0007: ldarg.0 
				L_0008: ldarg.1 
				L_0009: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.IO.Stream x6d84580748d50f45
				L_000e: ret 
			*/
			
			
			{
				this.x2fd0a49330761d63 (stream);
				this.x6d84580748d50f45 = stream;
			}
			
			protected virtual void SkinPasswordChanged ()
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.IO.Stream x6d84580748d50f45
				L_0007: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void x2fd0a49330761d63(System.IO.Stream)
				L_000c: ret 
			*/
			
			
			{
				this.x2fd0a49330761d63 (this.x6d84580748d50f45);
			}
			
			void Ix7f0ebae1a2d30adf.x0248d870497fc66d (string xba08ce632055a1d9, bool xe7ebe10fa44d8d49)
			
			/*
				// Code Size: 50 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.2 
				L_000a: brfalse.s L_001f
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0012: ldarg.1 
				L_0013: ldc.i4.1 
				L_0014: box System.Int32
				L_0019: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_001e: ret 
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0025: ldarg.1 
				L_0026: ldc.i4.0 
				L_0027: box System.Int32
				L_002c: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_0031: ret 
			*/
			
			
			{
				if (this.x6c7711ed04d2ac90)
				{
					if (xe7ebe10fa44d8d49)
					{
						this.xb41dc438649d784b[xba08ce632055a1d9] = 1;
					}
					else
					{
						this.xb41dc438649d784b[xba08ce632055a1d9] = 0;
					}
				}
			}
			
			private void x0c4b0fbba1d27e4d ()
			
			/*
				// Code Size: 34 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0006: callvirt System.Collections.Hashtable::Void Clear()
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_0011: callvirt System.Collections.Hashtable::Void Clear()
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_001c: callvirt System.Collections.Hashtable::Void Clear()
				L_0021: ret 
			*/
			
			
			{
				this.xc41ca09fad45f9ee.Clear ();
				this.x5e15c490aec0e408.Clear ();
				this.xb41dc438649d784b.Clear ();
			}
			
			void Ix7f0ebae1a2d30adf.x0ecee64b07d2d5b1 (string xba08ce632055a1d9, Bitmap x1ef26dbdd5d13d24)
			
			/*
				// Code Size: 41 Bytes
				.maxstack 4
				.locals (System.IO.MemoryStream V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: newobj System.IO.MemoryStream::Void .ctor()
				L_000e: stloc.0 
				L_000f: ldarg.2 
				L_0010: ldloc.0 
				L_0011: call System.Drawing.Imaging.ImageFormat::System.Drawing.Imaging.ImageFormat get_Bmp()
				L_0016: callvirt System.Drawing.Image::Void Save(System.IO.Stream, System.Drawing.Imaging.ImageFormat)
				L_001b: ldarg.0 
				L_001c: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0021: ldarg.1 
				L_0022: ldloc.0 
				L_0023: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_0028: ret 
			*/
			
			
			{
				if (! this.x6c7711ed04d2ac90)
				{
					return;
				}
				MemoryStream memoryStream1 = new MemoryStream ();
				x1ef26dbdd5d13d24.Save (((Stream) memoryStream1), ImageFormat.Bmp);
				this.xc41ca09fad45f9ee[xba08ce632055a1d9] = memoryStream1;
			}
			
			Bitmap Ix7f0ebae1a2d30adf.x14140ce12c223866 (string xba08ce632055a1d9, int x6d84ed4abd56c6c6, int xf67a82d2b619c935)
			
			/*
				// Code Size: 45 Bytes
				.maxstack 4
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Bitmap V_1)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_0006: brtrue.s L_000a
				L_0008: ldnull 
				L_0009: ret 
				L_000a: ldarg.0 
				L_000b: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0010: ldarg.1 
				L_0011: callvirt System.Collections.Hashtable::Boolean Contains(System.Object)
				L_0016: brfalse.s L_002b
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Drawing.Bitmap x14140ce12c223866(System.String)
				L_001f: stloc.0 
				L_0020: ldloc.0 
				L_0021: ldarg.2 
				L_0022: ldarg.3 
				L_0023: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Bitmap xb2c919bf91b5f7c6(System.Drawing.Bitmap, Int32, Int32)
				L_0028: stloc.1 
				L_0029: ldloc.1 
				L_002a: ret 
				L_002b: ldnull 
				L_002c: ret 
			*/
			
			
			{
				if (! ((Ix7f0ebae1a2d30adf) this).xb591119eb9470315)
				{
					return null;
				}
				if (! this.xc41ca09fad45f9ee.Contains (xba08ce632055a1d9))
				{
					return null;
				}
				Bitmap bitmap1 = ((Ix7f0ebae1a2d30adf) this).x14140ce12c223866 (xba08ce632055a1d9);
				return x448fd9ab43628c71.xb2c919bf91b5f7c6 (bitmap1, x6d84ed4abd56c6c6, xf67a82d2b619c935);
			}
			
			Bitmap Ix7f0ebae1a2d30adf.x14140ce12c223866 (string xba08ce632055a1d9)
			
			/*
				// Code Size: 54 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_0006: brtrue.s L_000a
				L_0008: ldnull 
				L_0009: ret 
				L_000a: ldarg.0 
				L_000b: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_0010: ldarg.1 
				L_0011: callvirt System.Collections.Hashtable::Boolean Contains(System.Object)
				L_0016: brfalse.s L_0034
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_001e: ldarg.1 
				L_001f: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0024: castclass System.IO.Stream
				L_0029: call System.Drawing.Image::System.Drawing.Image FromStream(System.IO.Stream)
				L_002e: castclass System.Drawing.Bitmap
				L_0033: ret 
				L_0034: ldnull 
				L_0035: ret 
			*/
			
			
			{
				if (! ((Ix7f0ebae1a2d30adf) this).xb591119eb9470315)
				{
					return null;
				}
				else if (! this.xc41ca09fad45f9ee.Contains (xba08ce632055a1d9))
				{
					return null;
				}
				else
				{
					return ((Bitmap) Image.FromStream (((Stream) this.xc41ca09fad45f9ee[xba08ce632055a1d9])));
				}
			}
			
			private void x2fd0a49330761d63 (Stream x23cda4cfdf81f2cf)
			
			/*
				// Code Size: 484 Bytes
				.maxstack 5
				.locals (System.IO.BinaryReader V_0, 
         System.IO.MemoryStream V_1, 
         Sunisoft.IrisSkin.x57f24fc7026c57d0 V_2, 
         Sunisoft.IrisSkin.x8632e8b92c54e123 V_3, 
         System.Int32 V_4, 
         System.Byte[] V_5, 
         System.IO.Stream V_6, 
         Sunisoft.IrisSkin.xfba9214ce91902fb V_7, 
         Sunisoft.IrisSkin.xab0f0a5b63c83169 V_8)
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_0007: ldarg.0 
				L_0008: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void x0c4b0fbba1d27e4d()
				L_000d: newobj System.IO.MemoryStream::Void .ctor()
				L_0012: stloc.s V_6
				L_0014: ldarg.1 
				L_0015: ldstr "SKINDATA.SK2"
				L_001a: ldloc.s V_6
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.String x2de0dddab0e399a9
				L_0022: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xfba9214ce91902fb x2b37c931ef30afed(System.IO.Stream, System.String, System.IO.Stream, System.String)
				L_0027: stloc.s V_7
				L_0029: ldloc.s V_7
				L_002b: brtrue L_01e3
				L_0030: ldloc.s V_6
				L_0032: newobj System.IO.BinaryReader::Void .ctor(System.IO.Stream)
				L_0037: stloc.0 
				L_0038: ldloc.s V_6
				L_003a: ldc.i4.0 
				L_003b: conv.i8 
				L_003c: ldc.i4.0 
				L_003d: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_0042: pop 
				L_0043: ldloc.0 
				L_0044: ldtoken Sunisoft.IrisSkin.xe148cfaee7cc82a1
				L_0049: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_004e: ldtoken Sunisoft.IrisSkin.xe148cfaee7cc82a1
				L_0053: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0058: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_005d: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_0062: unbox Sunisoft.IrisSkin.xe148cfaee7cc82a1
				L_0067: ldobj Sunisoft.IrisSkin.xe148cfaee7cc82a1
				L_006c: pop 
				L_006d: ldloc.s V_6
				L_006f: ldc.i4.0 
				L_0070: conv.i8 
				L_0071: ldc.i4.0 
				L_0072: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_0077: pop 
				L_0078: ldloc.0 
				L_0079: ldtoken Sunisoft.IrisSkin.x57f24fc7026c57d0
				L_007e: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0083: ldtoken Sunisoft.IrisSkin.x57f24fc7026c57d0
				L_0088: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_008d: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_0092: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_0097: unbox Sunisoft.IrisSkin.x57f24fc7026c57d0
				L_009c: ldobj Sunisoft.IrisSkin.x57f24fc7026c57d0
				L_00a1: stloc.2 
				L_00a2: ldloca.s V_2
				L_00a4: ldfld Sunisoft.IrisSkin.x57f24fc7026c57d0::UInt32 x478443346d1d109c
				L_00a9: brtrue.s L_00ac
				L_00ab: ret 
				L_00ac: ldloc.s V_6
				L_00ae: ldloca.s V_2
				L_00b0: ldfld Sunisoft.IrisSkin.x57f24fc7026c57d0::UInt32 x478443346d1d109c
				L_00b5: conv.u8 
				L_00b6: ldc.i4.0 
				L_00b7: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_00bc: pop 
				L_00bd: ldloc.0 
				L_00be: ldtoken Sunisoft.IrisSkin.x8632e8b92c54e123
				L_00c3: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_00c8: ldtoken Sunisoft.IrisSkin.x8632e8b92c54e123
				L_00cd: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_00d2: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_00d7: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_00dc: unbox Sunisoft.IrisSkin.x8632e8b92c54e123
				L_00e1: ldobj Sunisoft.IrisSkin.x8632e8b92c54e123
				L_00e6: stloc.3 
				L_00e7: ldloc.s V_6
				L_00e9: ldloca.s V_3
				L_00eb: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::UInt32 xcb1c51bccf5db2d5
				L_00f0: conv.u8 
				L_00f1: ldc.i4.0 
				L_00f2: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_00f7: pop 
				L_00f8: ldloca.s V_3
				L_00fa: call Sunisoft.IrisSkin.x8632e8b92c54e123::Sunisoft.IrisSkin.xab0f0a5b63c83169 get_x3146d638ec378671()
				L_00ff: stloc.s V_8
				L_0101: ldloc.s V_8
				L_0103: switch (L_011a, L_0171, L_014e, L_0192)
				L_0118: br.s L_0192
				L_011a: ldloc.0 
				L_011b: ldloca.s V_3
				L_011d: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::UInt32 xd95e52224405bb92
				L_0122: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_0127: stloc.s V_5
				L_0129: ldloc.s V_5
				L_012b: ldc.i4.0 
				L_012c: ldloca.s V_3
				L_012e: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::UInt32 xd95e52224405bb92
				L_0133: newobj System.IO.MemoryStream::Void .ctor(Byte[], Int32, Int32)
				L_0138: stloc.1 
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xc41ca09fad45f9ee
				L_013f: ldloca.s V_3
				L_0141: call Sunisoft.IrisSkin.x8632e8b92c54e123::System.String get_xb66f90d7e750b49e()
				L_0146: ldloc.1 
				L_0147: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_014c: br.s L_0192
				L_014e: ldloc.0 
				L_014f: callvirt System.IO.BinaryReader::Byte ReadByte()
				L_0154: stloc.s V_4
				L_0156: ldarg.0 
				L_0157: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_015c: ldloca.s V_3
				L_015e: call Sunisoft.IrisSkin.x8632e8b92c54e123::System.String get_xb66f90d7e750b49e()
				L_0163: ldloc.s V_4
				L_0165: box System.Int32
				L_016a: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_016f: br.s L_0192
				L_0171: ldloc.0 
				L_0172: callvirt System.IO.BinaryReader::Int32 ReadInt32()
				L_0177: stloc.s V_4
				L_0179: ldarg.0 
				L_017a: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_017f: ldloca.s V_3
				L_0181: call Sunisoft.IrisSkin.x8632e8b92c54e123::System.String get_xb66f90d7e750b49e()
				L_0186: ldloc.s V_4
				L_0188: box System.Int32
				L_018d: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0192: ldloc.s V_6
				L_0194: ldloca.s V_3
				L_0196: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::UInt32 x4f6686d624d5dfe1
				L_019b: conv.u8 
				L_019c: ldc.i4.0 
				L_019d: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_01a2: pop 
				L_01a3: ldloc.0 
				L_01a4: ldtoken Sunisoft.IrisSkin.x8632e8b92c54e123
				L_01a9: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_01ae: ldtoken Sunisoft.IrisSkin.x8632e8b92c54e123
				L_01b3: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_01b8: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_01bd: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_01c2: unbox Sunisoft.IrisSkin.x8632e8b92c54e123
				L_01c7: ldobj Sunisoft.IrisSkin.x8632e8b92c54e123
				L_01cc: stloc.3 
				L_01cd: ldc.i4.0 
				L_01ce: stloc.s V_4
				L_01d0: ldloca.s V_3
				L_01d2: ldfld Sunisoft.IrisSkin.x8632e8b92c54e123::UInt32 x4f6686d624d5dfe1
				L_01d7: brtrue L_00e7
				L_01dc: ldarg.0 
				L_01dd: ldc.i4.1 
				L_01de: stfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_01e3: ret 
			*/
			
			
			{
				MemoryStream memoryStream1;
				x57f24fc7026c57d0 x57f24fc7026c57d0_1;
				int i1;
				byte[] byteArray1;
				xab0f0a5b63c83169 xab0f0a5b63c83169_1;
				this.x6c7711ed04d2ac90 = false;
				this.x0c4b0fbba1d27e4d ();
				Stream stream1 = ((Stream) new MemoryStream ());
				xfba9214ce91902fb xfba9214ce91902fb1 = x2b13dab2573bcd5e.x2b37c931ef30afed (x23cda4cfdf81f2cf, "SKINDATA.SK2", stream1, this.x2de0dddab0e399a9);
				if (xfba9214ce91902fb1 != xfba9214ce91902fb.xfbacefb914bc4cc3)
				{
					return;
				}
				BinaryReader binaryReader1 = new BinaryReader (stream1);
				long int64_1 = stream1.Seek (0L, SeekOrigin.Begin);
				xe148cfaee7cc82a1 xe148cfaee7cc82a1_1 = ((xe148cfaee7cc82a1) x7f0ebae1a2d30adf.x49cceb88e1b6126e (binaryReader1, typeof (xe148cfaee7cc82a1), Marshal.SizeOf (typeof (xe148cfaee7cc82a1))));
				long int64_2 = stream1.Seek (0L, SeekOrigin.Begin);
				if ((x57f24fc7026c57d0_1 = ((x57f24fc7026c57d0) x7f0ebae1a2d30adf.x49cceb88e1b6126e (binaryReader1, typeof (x57f24fc7026c57d0), Marshal.SizeOf (typeof (x57f24fc7026c57d0))))).x478443346d1d109c == uint.MinValue)
				{
					return;
				}
				long int64_3 = stream1.Seek (((long) x57f24fc7026c57d0_1.x478443346d1d109c), SeekOrigin.Begin);
				x8632e8b92c54e123 x8632e8b92c54e123_1 = ((x8632e8b92c54e123) x7f0ebae1a2d30adf.x49cceb88e1b6126e (binaryReader1, typeof (x8632e8b92c54e123), Marshal.SizeOf (typeof (x8632e8b92c54e123))));
				while (true)
				{
					long int64_4 = stream1.Seek (((long) x8632e8b92c54e123_1.xcb1c51bccf5db2d5), SeekOrigin.Begin);
					xab0f0a5b63c83169_1 = x8632e8b92c54e123_1.x3146d638ec378671;
					switch (xab0f0a5b63c83169_1)
					{
						case xab0f0a5b63c83169.xb8a774e0111d0fbe:
						
						{
								byteArray1 = binaryReader1.ReadBytes (((int) x8632e8b92c54e123_1.xd95e52224405bb92));
								memoryStream1 = new MemoryStream (byteArray1, 0, ((int) x8632e8b92c54e123_1.xd95e52224405bb92));
								this.xc41ca09fad45f9ee.Add (x8632e8b92c54e123_1.xb66f90d7e750b49e, memoryStream1);
								break;
						}
						case xab0f0a5b63c83169.x53e1aac0092bbcc1:
						
						{
								i1 = binaryReader1.ReadInt32 ();
								this.x5e15c490aec0e408.Add (x8632e8b92c54e123_1.xb66f90d7e750b49e, i1);
								break;
						}
						case xab0f0a5b63c83169.x5facb5daef2aaefa:
						
						{
								i1 = ((int) binaryReader1.ReadByte ());
								this.xb41dc438649d784b.Add (x8632e8b92c54e123_1.xb66f90d7e750b49e, i1);
								break;
						}
					}
					long int64_5 = stream1.Seek (((long) x8632e8b92c54e123_1.x4f6686d624d5dfe1), SeekOrigin.Begin);
					x8632e8b92c54e123_1 = ((x8632e8b92c54e123) x7f0ebae1a2d30adf.x49cceb88e1b6126e (binaryReader1, typeof (x8632e8b92c54e123), Marshal.SizeOf (typeof (x8632e8b92c54e123))));
					i1 = 0;
					if (x8632e8b92c54e123_1.x4f6686d624d5dfe1 == uint.MinValue)
					{
						this.x6c7711ed04d2ac90 = true;
						return;
					}
				}
			}
			
			private void x2fd0a49330761d63 (string xafe2f3653ee64ebc)
			
			/*
				// Code Size: 52 Bytes
				.maxstack 5
				.locals (System.IO.FileStream V_0)
				.try L_0023 to L_002c finally L_002c to L_0033
				L_0000: ldarg.1 
				L_0001: call System.IO.File::Boolean Exists(System.String)
				L_0006: brfalse.s L_0014
				L_0008: ldarg.1 
				L_0009: ldc.i4.3 
				L_000a: ldc.i4.1 
				L_000b: ldc.i4.1 
				L_000c: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_0011: stloc.0 
				L_0012: br.s L_0023
				L_0014: ldarg.1 
				L_0015: call System.IO.Path::System.String GetFileName(System.String)
				L_001a: ldc.i4.3 
				L_001b: ldc.i4.1 
				L_001c: ldc.i4.1 
				L_001d: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_0022: stloc.0 
				L_0023: ldarg.0 
				L_0024: ldloc.0 
				L_0025: call Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void x2fd0a49330761d63(System.IO.Stream)
				L_002a: leave.s L_0033
				L_002c: ldloc.0 
				L_002d: callvirt System.IO.Stream::Void Close()
				L_0032: endfinally 
				L_0033: ret 
			*/
			
			
			{
				FileStream fileStream1;
				if (File.Exists (xafe2f3653ee64ebc))
				{
					fileStream1 = File.Open (xafe2f3653ee64ebc, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				else
				{
					fileStream1 = File.Open (Path.GetFileName (xafe2f3653ee64ebc), FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				try
				{
					this.x2fd0a49330761d63 (((Stream) fileStream1));
				}
				finally
				{
					fileStream1.Close ();
				}
			}
			
			private static unsafe object x49cceb88e1b6126e (BinaryReader xe134235b3526fa75, Type x43163d22e8cd5a71, int x0ceec69a97f73617)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 3
				.locals (System.Byte[] V_0, 
         System.Object V_1, 
         System.Byte& V_2 Pinned)
				L_0000: ldarg.0 
				L_0001: ldarg.2 
				L_0002: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_0007: stloc.0 
				L_0008: ldloc.0 
				L_0009: ldc.i4.0 
				L_000a: ldelema System.Byte
				L_000f: stloc.2 
				L_0010: ldloc.2 
				L_0011: conv.i 
				L_0012: call System.IntPtr::IntPtr op_Explicit(Void*)
				L_0017: ldarg.1 
				L_0018: call System.Runtime.InteropServices.Marshal::System.Object PtrToStructure(IntPtr, System.Type)
				L_001d: stloc.1 
				L_001e: ldc.i4.0 
				L_001f: conv.u 
				L_0020: stloc.2 
				L_0021: ldloc.1 
				L_0022: ret 
			*/
			
			
			{
				byte[] byteArray1 = xe134235b3526fa75.ReadBytes (x0ceec69a97f73617);
				fixed (byte* referencedByteAddress1 = byteArray1)
				{
					return Marshal.PtrToStructure (((IntPtr) referencedByteAddress1), x43163d22e8cd5a71);
				}
			}
			
			bool Ix7f0ebae1a2d30adf.x6e16b83386574e87 (string xba08ce632055a1d9)
			
			/*
				// Code Size: 51 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_0006: brtrue.s L_000a
				L_0008: ldc.i4.0 
				L_0009: ret 
				L_000a: ldarg.0 
				L_000b: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_0010: ldarg.1 
				L_0011: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0016: brfalse.s L_0031
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable xb41dc438649d784b
				L_001e: ldarg.1 
				L_001f: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0024: unbox System.Int32
				L_0029: ldind.i4 
				L_002a: ldc.i4.1 
				L_002b: bne.un.s L_002f
				L_002d: ldc.i4.1 
				L_002e: ret 
				L_002f: ldc.i4.0 
				L_0030: ret 
				L_0031: ldc.i4.0 
				L_0032: ret 
			*/
			
			
			{
				if (! this.x6c7711ed04d2ac90)
				{
					return false;
				}
				else if (! this.xb41dc438649d784b.ContainsKey (xba08ce632055a1d9))
				{
					return false;
				}
				else if (((int) this.xb41dc438649d784b[xba08ce632055a1d9]) != 1)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			
			int Ix7f0ebae1a2d30adf.x88bcf0804211ebbb (string xba08ce632055a1d9)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_000c: brfalse.s L_0021
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_0014: ldarg.1 
				L_0015: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_001a: unbox System.Int32
				L_001f: ldind.i4 
				L_0020: ret 
				L_0021: ldc.i4.0 
				L_0022: ret 
			*/
			
			
			{
				if (! this.x5e15c490aec0e408.ContainsKey (xba08ce632055a1d9))
				{
					return 0;
				}
				else
				{
					return ((int) this.x5e15c490aec0e408[xba08ce632055a1d9]);
				}
			}
			
			Color Ix7f0ebae1a2d30adf.xef50a938c8b9c7fd (string xba08ce632055a1d9)
			
			/*
				// Code Size: 128 Bytes
				.maxstack 5
				.locals (System.Drawing.Color V_0, 
         System.Int32 V_1)
				L_0000: ldc.i4 255
				L_0005: ldc.i4 255
				L_000a: ldc.i4 255
				L_000f: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_0014: stloc.0 
				L_0015: ldarg.0 
				L_0016: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_001b: brtrue.s L_001f
				L_001d: ldloc.0 
				L_001e: ret 
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_0025: ldarg.1 
				L_0026: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_002b: brfalse.s L_007e
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_0033: ldarg.1 
				L_0034: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0039: unbox System.Int32
				L_003e: ldind.i4 
				L_003f: stloc.1 
				L_0040: ldloc.1 
				L_0041: conv.i8 
				L_0042: ldc.i4 -16777216
				L_0047: conv.u8 
				L_0048: and 
				L_0049: ldc.i4 -16777216
				L_004e: conv.u8 
				L_004f: bne.un.s L_005e
				L_0051: ldloc.1 
				L_0052: ldc.i4 255
				L_0057: and 
				L_0058: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetSysColor(Int32)
				L_005d: stloc.1 
				L_005e: ldloc.1 
				L_005f: ldc.i4 255
				L_0064: and 
				L_0065: ldloc.1 
				L_0066: ldc.i4 65280
				L_006b: and 
				L_006c: ldc.i4.8 
				L_006d: shr 
				L_006e: ldloc.1 
				L_006f: ldc.i4 16711680
				L_0074: and 
				L_0075: ldc.i4.s 16
				L_0077: shr 
				L_0078: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_007d: stloc.0 
				L_007e: ldloc.0 
				L_007f: ret 
			*/
			
			
			{
				Color color1 = Color.FromArgb (255, 255, 255);
				if (! this.x6c7711ed04d2ac90)
				{
					return color1;
				}
				if (! this.x5e15c490aec0e408.ContainsKey (xba08ce632055a1d9))
				{
					return color1;
				}
				int i1 = ((int) this.x5e15c490aec0e408[xba08ce632055a1d9]);
				if ((((long) i1) & ((long) (-16777216))) == ((long) (-16777216)))
				{
					i1 = x61467fe65a98f20c.GetSysColor (((int) (i1 & 255)));
				}
				return Color.FromArgb (((int) (i1 & 255)), ((int) ((i1 & 65280) >> 8)), ((int) ((i1 & 16711680) >> 16)));
			}
			
			void Ix7f0ebae1a2d30adf.xf4868abd18f579a7 (string xba08ce632055a1d9, Color x6c50a99faab7d741)
			
			/*
				// Code Size: 34 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6c7711ed04d2ac90
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Collections.Hashtable x5e15c490aec0e408
				L_000f: ldarg.1 
				L_0010: ldarga.s x6c50a99faab7d741
				L_0012: call System.Drawing.Color::Int32 ToArgb()
				L_0017: box System.Int32
				L_001c: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_0021: ret 
			*/
			
			
			{
				if (this.x6c7711ed04d2ac90)
				{
					this.x5e15c490aec0e408[xba08ce632055a1d9] = x6c50a99faab7d741.ToArgb ();
				}
			}
			
		#endregion
	}
	
}

