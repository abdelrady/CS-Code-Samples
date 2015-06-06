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
			using Sunisoft.IrisSkin.InternalControls;
			using System;
			using System.Collections;
			using System.ComponentModel.Design.Serialization;
			using System.ComponentModel;
			using System.Drawing;
			using System.Drawing.Design;
			using System.IO;
			using System.Security.Cryptography;
			using System.Text;
			using System.Windows.Forms;
			
			
		#endregion
		
	[SerializableAttribute()]
	[DesignerSerializerAttribute(((Type) typeof (x2f6133cd59233dfd)), ((Type) typeof (CodeDomSerializer)))]
	[ToolboxBitmapAttribute(((Type) typeof (SkinEngine)), "SkinEngineIcon.bmp")]
	[ToolboxItemAttribute(true)]
	public class SkinEngine : Component, ISkinEngine
	
	{
		
		#region Fields
			private string __build;
			private bool active;
			private ISkinCollection addtionalBuiltInSkins;
			private IntPtr backColorBrush;
			private Hashtable bitmapList;
			private int bottomBorderHeight;
			private Hashtable brushList;
			private bool builtIn;
			internal static x6161963e817c3cff CbtProc;
			private IntPtr controlBorderBrush;
			private SkinChanged CurrentSkinChanged;
			private static Hashtable dialogList;
			private Hashtable disabledForm;
			private int disableTag;
			private bool drawFormCaption;
			private bool drawFormIcon;
			private bool drawLineForAcceptButton;
			internal static DSACryptoServiceProvider DSA;
			internal static byte[] DSAHash;
			private bool enable3rdControl;
			internal static ISkinEngine Engine;
			private int formCaptionPosX;
			private int formCaptionPosY;
			private int formMinWidth;
			internal static IntPtr Hook;
			private int leftBorderWidth;
			private Font menuFont;
			private int minTextWidth;
			private Component owner;
			private static Random ram;
			private static int random;
			private Ix7f0ebae1a2d30adf reader;
			private bool realActive;
			private IRes res;
			private string resSysMenuClose;
			private string resSysMenuMax;
			private string resSysMenuMin;
			private int rightBorderWidth;
			private string serialNumber;
			private bool skinAllForm;
			private bool skinDialogs;
			private string skinFile;
			internal static ArrayList SkinHandleList;
			private string skinPassword;
			private bool skinScrollBar;
			private Stream skinStream;
			private Stream skinStreamMain;
			private Font titleFont;
			private int titleHeight;
			private static Hashtable windowList;
		#endregion
		
		#region Constructors
		
			static SkinEngine ()
			/*
				// Code Size: 117 Bytes
				.maxstack 3
				L_0000: ldsfld System.IntPtr::IntPtr Zero
				L_0005: stsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_000a: ldc.i4.0 
				L_000b: stsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
				L_0010: newobj System.Random::Void .ctor()
				L_0015: stsfld Sunisoft.IrisSkin.SkinEngine::System.Random ram
				L_001a: newobj System.Collections.Hashtable::Void .ctor()
				L_001f: stsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_0024: newobj System.Collections.Hashtable::Void .ctor()
				L_0029: stsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable dialogList
				L_002e: newobj System.Collections.ArrayList::Void .ctor()
				L_0033: stsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0038: newobj System.Security.Cryptography.DSACryptoServiceProvider::Void .ctor()
				L_003d: stsfld Sunisoft.IrisSkin.SkinEngine::System.Security.Cryptography.DSACryptoServiceProvider DSA
				L_0042: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Security.Cryptography.DSACryptoServiceProvider DSA
				L_0047: ldstr "pdleeecfafjfldagcehgjfogkgfheemhmediefkikfbjheijnbpjibgkjcnkebeljellhacmocjmbcanpdhnipnnbpeoaplodcdpackpkbbafphagooadagblpmbcbecablcmobdpnidgaaejngejnneamefcnlfhncglljgimahlmhhhlohonfiikmimmdjaokjknbkmjikompkkkgljknlclemallmikcnjljnemaodihokloockfpljmpdldakikamibbmgibakpboigcmjnclhedfhldnjcegjjeghafhhhfgiofaffgigmglgdhcekhdhbigfiinfpioegjlfnjcdekjclkpdcllejlkgambchmifomfdfnbfmnjddoockoccbphdipadpplagafcnaoaeblalbhacchpicfbadaahdlpndnafehplehcdffakfkbbgaphgabpgcbghlpmhandicaligacjomijcaakongkdmnkfpelonlljncmhnjmcoanclhnononbnfoimmomldpgokpojbaijiackpaojgboinbnkechjlccjcdkjjdoiaeokheckoeojffijmfmgdgbkkgkgbhaiihljphhjgiihniahejmgljghcknjjkjialjihldjolmifmdimmofdnggknpgbojdiojhpokegpffnppceahglahccbigjbjfacpchcleockbfdjbmdfedecckencbfcdifgepfmcggbangbaehidlhppbidbjincajkahjocojibfkjbmkjpclhpjlnoamcaimgoomjofnpomnfaeoealolmbpcmipbaaafpgaomnaomebkolbmkccbpjccmadfohdmkodikfeammenkdfalkfjnbgijigalpghnghhmnhekeihiliflcjpijjiiakfihkbiokbhflgimlkhdmfhkmpibnbhingkpnoigoihnohfepmjlppicaafjamiabdihbnfobihfcnhmcciddjfkdgdbeddieadpegegffgnfahegaglgpfchhcjhmbaibghilfoinefjfdmjobdkmakkhcblibillbplaagmeenmkcenkalncccoeajoacapkahpdaopjcfagplambdbcakbloacoaicgnocbagdkmmdmmdeealelacfdajfhnpfjoggmpngenehimlhdnciiojifoajilhjbnojjnfkakmkakdlinklajbmflimlmpmangnemnnjjeonjlofjcpmjjpilaagkhafkoaejfbmjmbpidcggkcikbdlgidigpdeggeefnelhefnflfifcgdgjgefahefhhbfohoefilemiiedjhfkjkebkhdikefpkmdgllfnlieemaelmnccnkcjnmbaoffhopcoocffpkcmpbedaockabcbbibibdepbmpfcmcncfbedibldcpbelcjeeaafmogfnbofgcfgpbmgppchfakhpabiaphinnoikmfjjpmjhodkfpkkdaclenilpnplbngmapnmkoenlolnjocojnjocoapcnhpnmopokfajkmaljdbnkkbimbchkicnlpcpigdphndhjeeiiledicfhjjfgkagdkhgpjogghfhpimhjgdieikicjbjbjijpipjejgkfgnkphelmglljfcmmfjmphancehneionjhfojdmojedpifkpggbaogiaoepaccgbienbkdecadlcadcdbcjdnbaenaheocoendffkdmfgddgnakgiabhjbihncphicgiocniaaejjcljmcckccjkfcaldbhlnbolgoemnolmjbdnmnjnjnaofnhofmoodofphpmpcpdaipkakmbbdpibgppbmogcponcnnedholdalcelkjeljafnkhfjlofekfglkmgcmdhdnkhnkbifliinlpidmgjalnjgiek"
				L_004c: ldc.i4 1338657539
				L_0051: call xb9d8bb5e6df032aa.x1110bdd110cdcea4::System.String _xaacba899487bce8c(System.String, Int32)
				L_0056: call System.String::System.String Intern(System.String)
				L_005b: callvirt System.Security.Cryptography.AsymmetricAlgorithm::Void FromXmlString(System.String)
				L_0060: call System.Text.Encoding::System.Text.Encoding get_ASCII()
				L_0065: ldstr "IrisSkin is good !!!"
				L_006a: callvirt System.Text.Encoding::Byte[] GetBytes(System.String)
				L_006f: stsfld Sunisoft.IrisSkin.SkinEngine::Byte[] DSAHash
				L_0074: ret 
			*/
			
			public SkinEngine (Component owner, string skinFile)
			/*
				// Code Size: 302 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0007: ldarg.0 
				L_0008: ldnull 
				L_0009: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_0015: ldarg.0 
				L_0016: ldc.i4 9999
				L_001b: stfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
				L_0020: ldarg.0 
				L_0021: ldc.i4.0 
				L_0022: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
				L_0027: ldarg.0 
				L_0028: ldc.i4.1 
				L_0029: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
				L_002e: ldarg.0 
				L_002f: ldc.i4.1 
				L_0030: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
				L_0035: ldarg.0 
				L_0036: ldc.i4.1 
				L_0037: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
				L_003c: ldarg.0 
				L_003d: ldc.i4.m1 
				L_003e: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
				L_0043: ldarg.0 
				L_0044: ldc.i4.m1 
				L_0045: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
				L_0051: ldarg.0 
				L_0052: ldstr ""
				L_0057: stfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
				L_005c: ldarg.0 
				L_005d: ldstr "&Close"
				L_0062: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
				L_0067: ldarg.0 
				L_0068: ldstr "Ma&ximize/Restore"
				L_006d: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
				L_0072: ldarg.0 
				L_0073: ldstr "Mi&nimize"
				L_0078: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
				L_007d: ldarg.0 
				L_007e: ldnull 
				L_007f: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
				L_0084: ldarg.0 
				L_0085: ldnull 
				L_0086: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
				L_008b: ldarg.0 
				L_008c: ldc.i4.1 
				L_008d: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
				L_0092: ldarg.0 
				L_0093: ldc.i4.1 
				L_0094: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
				L_0099: ldarg.0 
				L_009a: ldstr "2006.11.07"
				L_009f: stfld Sunisoft.IrisSkin.SkinEngine::System.String __build
				L_00a4: ldarg.0 
				L_00a5: ldnull 
				L_00a6: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStream
				L_00ab: ldarg.0 
				L_00ac: newobj System.Collections.Hashtable::Void .ctor()
				L_00b1: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable disabledForm
				L_00b6: ldarg.0 
				L_00b7: ldc.i4.0 
				L_00b8: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_00bd: ldarg.0 
				L_00be: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_00c3: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_00c8: ldarg.0 
				L_00c9: ldc.i4.0 
				L_00ca: stfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_00cf: ldarg.0 
				L_00d0: ldc.i4.0 
				L_00d1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_00d6: ldarg.0 
				L_00d7: ldc.i4.0 
				L_00d8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
				L_00dd: ldarg.0 
				L_00de: ldc.i4.0 
				L_00df: stfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
				L_00e4: ldarg.0 
				L_00e5: ldsfld System.IntPtr::IntPtr Zero
				L_00ea: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_00ef: ldarg.0 
				L_00f0: ldc.i4.0 
				L_00f1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00f6: ldarg.0 
				L_00f7: ldc.i4.0 
				L_00f8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_00fd: ldarg.0 
				L_00fe: newobj System.Collections.Hashtable::Void .ctor()
				L_0103: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0108: ldarg.0 
				L_0109: newobj System.Collections.Hashtable::Void .ctor()
				L_010e: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0113: ldarg.0 
				L_0114: call System.ComponentModel.Component::Void .ctor()
				L_0119: ldarg.0 
				L_011a: ldarg.1 
				L_011b: stfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
				L_0120: ldarg.0 
				L_0121: call Sunisoft.IrisSkin.SkinEngine::Void InternalConstructor()
				L_0126: ldarg.0 
				L_0127: ldarg.2 
				L_0128: call Sunisoft.IrisSkin.SkinEngine::Void set_SkinFile(System.String)
				L_012d: ret 
			*/
			
			public SkinEngine (Component owner, Stream skinStream)
			/*
				// Code Size: 302 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0007: ldarg.0 
				L_0008: ldnull 
				L_0009: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_0015: ldarg.0 
				L_0016: ldc.i4 9999
				L_001b: stfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
				L_0020: ldarg.0 
				L_0021: ldc.i4.0 
				L_0022: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
				L_0027: ldarg.0 
				L_0028: ldc.i4.1 
				L_0029: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
				L_002e: ldarg.0 
				L_002f: ldc.i4.1 
				L_0030: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
				L_0035: ldarg.0 
				L_0036: ldc.i4.1 
				L_0037: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
				L_003c: ldarg.0 
				L_003d: ldc.i4.m1 
				L_003e: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
				L_0043: ldarg.0 
				L_0044: ldc.i4.m1 
				L_0045: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
				L_0051: ldarg.0 
				L_0052: ldstr ""
				L_0057: stfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
				L_005c: ldarg.0 
				L_005d: ldstr "&Close"
				L_0062: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
				L_0067: ldarg.0 
				L_0068: ldstr "Ma&ximize/Restore"
				L_006d: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
				L_0072: ldarg.0 
				L_0073: ldstr "Mi&nimize"
				L_0078: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
				L_007d: ldarg.0 
				L_007e: ldnull 
				L_007f: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
				L_0084: ldarg.0 
				L_0085: ldnull 
				L_0086: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
				L_008b: ldarg.0 
				L_008c: ldc.i4.1 
				L_008d: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
				L_0092: ldarg.0 
				L_0093: ldc.i4.1 
				L_0094: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
				L_0099: ldarg.0 
				L_009a: ldstr "2006.11.07"
				L_009f: stfld Sunisoft.IrisSkin.SkinEngine::System.String __build
				L_00a4: ldarg.0 
				L_00a5: ldnull 
				L_00a6: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStream
				L_00ab: ldarg.0 
				L_00ac: newobj System.Collections.Hashtable::Void .ctor()
				L_00b1: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable disabledForm
				L_00b6: ldarg.0 
				L_00b7: ldc.i4.0 
				L_00b8: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_00bd: ldarg.0 
				L_00be: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_00c3: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_00c8: ldarg.0 
				L_00c9: ldc.i4.0 
				L_00ca: stfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_00cf: ldarg.0 
				L_00d0: ldc.i4.0 
				L_00d1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_00d6: ldarg.0 
				L_00d7: ldc.i4.0 
				L_00d8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
				L_00dd: ldarg.0 
				L_00de: ldc.i4.0 
				L_00df: stfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
				L_00e4: ldarg.0 
				L_00e5: ldsfld System.IntPtr::IntPtr Zero
				L_00ea: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_00ef: ldarg.0 
				L_00f0: ldc.i4.0 
				L_00f1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00f6: ldarg.0 
				L_00f7: ldc.i4.0 
				L_00f8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_00fd: ldarg.0 
				L_00fe: newobj System.Collections.Hashtable::Void .ctor()
				L_0103: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0108: ldarg.0 
				L_0109: newobj System.Collections.Hashtable::Void .ctor()
				L_010e: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0113: ldarg.0 
				L_0114: call System.ComponentModel.Component::Void .ctor()
				L_0119: ldarg.0 
				L_011a: ldarg.1 
				L_011b: stfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
				L_0120: ldarg.0 
				L_0121: call Sunisoft.IrisSkin.SkinEngine::Void InternalConstructor()
				L_0126: ldarg.0 
				L_0127: ldarg.2 
				L_0128: call Sunisoft.IrisSkin.SkinEngine::Void set_SkinStream(System.IO.Stream)
				L_012d: ret 
			*/
			
			public SkinEngine (Component owner)
			/*
				// Code Size: 295 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0007: ldarg.0 
				L_0008: ldnull 
				L_0009: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_0015: ldarg.0 
				L_0016: ldc.i4 9999
				L_001b: stfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
				L_0020: ldarg.0 
				L_0021: ldc.i4.0 
				L_0022: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
				L_0027: ldarg.0 
				L_0028: ldc.i4.1 
				L_0029: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
				L_002e: ldarg.0 
				L_002f: ldc.i4.1 
				L_0030: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
				L_0035: ldarg.0 
				L_0036: ldc.i4.1 
				L_0037: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
				L_003c: ldarg.0 
				L_003d: ldc.i4.m1 
				L_003e: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
				L_0043: ldarg.0 
				L_0044: ldc.i4.m1 
				L_0045: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
				L_0051: ldarg.0 
				L_0052: ldstr ""
				L_0057: stfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
				L_005c: ldarg.0 
				L_005d: ldstr "&Close"
				L_0062: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
				L_0067: ldarg.0 
				L_0068: ldstr "Ma&ximize/Restore"
				L_006d: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
				L_0072: ldarg.0 
				L_0073: ldstr "Mi&nimize"
				L_0078: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
				L_007d: ldarg.0 
				L_007e: ldnull 
				L_007f: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
				L_0084: ldarg.0 
				L_0085: ldnull 
				L_0086: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
				L_008b: ldarg.0 
				L_008c: ldc.i4.1 
				L_008d: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
				L_0092: ldarg.0 
				L_0093: ldc.i4.1 
				L_0094: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
				L_0099: ldarg.0 
				L_009a: ldstr "2006.11.07"
				L_009f: stfld Sunisoft.IrisSkin.SkinEngine::System.String __build
				L_00a4: ldarg.0 
				L_00a5: ldnull 
				L_00a6: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStream
				L_00ab: ldarg.0 
				L_00ac: newobj System.Collections.Hashtable::Void .ctor()
				L_00b1: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable disabledForm
				L_00b6: ldarg.0 
				L_00b7: ldc.i4.0 
				L_00b8: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_00bd: ldarg.0 
				L_00be: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_00c3: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_00c8: ldarg.0 
				L_00c9: ldc.i4.0 
				L_00ca: stfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_00cf: ldarg.0 
				L_00d0: ldc.i4.0 
				L_00d1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_00d6: ldarg.0 
				L_00d7: ldc.i4.0 
				L_00d8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
				L_00dd: ldarg.0 
				L_00de: ldc.i4.0 
				L_00df: stfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
				L_00e4: ldarg.0 
				L_00e5: ldsfld System.IntPtr::IntPtr Zero
				L_00ea: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_00ef: ldarg.0 
				L_00f0: ldc.i4.0 
				L_00f1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00f6: ldarg.0 
				L_00f7: ldc.i4.0 
				L_00f8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_00fd: ldarg.0 
				L_00fe: newobj System.Collections.Hashtable::Void .ctor()
				L_0103: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0108: ldarg.0 
				L_0109: newobj System.Collections.Hashtable::Void .ctor()
				L_010e: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0113: ldarg.0 
				L_0114: call System.ComponentModel.Component::Void .ctor()
				L_0119: ldarg.0 
				L_011a: ldarg.1 
				L_011b: stfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
				L_0120: ldarg.0 
				L_0121: call Sunisoft.IrisSkin.SkinEngine::Void InternalConstructor()
				L_0126: ret 
			*/
			
			public SkinEngine ()
			/*
				// Code Size: 288 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0007: ldarg.0 
				L_0008: ldnull 
				L_0009: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_0015: ldarg.0 
				L_0016: ldc.i4 9999
				L_001b: stfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
				L_0020: ldarg.0 
				L_0021: ldc.i4.0 
				L_0022: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
				L_0027: ldarg.0 
				L_0028: ldc.i4.1 
				L_0029: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
				L_002e: ldarg.0 
				L_002f: ldc.i4.1 
				L_0030: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
				L_0035: ldarg.0 
				L_0036: ldc.i4.1 
				L_0037: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
				L_003c: ldarg.0 
				L_003d: ldc.i4.m1 
				L_003e: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
				L_0043: ldarg.0 
				L_0044: ldc.i4.m1 
				L_0045: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
				L_0051: ldarg.0 
				L_0052: ldstr ""
				L_0057: stfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
				L_005c: ldarg.0 
				L_005d: ldstr "&Close"
				L_0062: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
				L_0067: ldarg.0 
				L_0068: ldstr "Ma&ximize/Restore"
				L_006d: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
				L_0072: ldarg.0 
				L_0073: ldstr "Mi&nimize"
				L_0078: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
				L_007d: ldarg.0 
				L_007e: ldnull 
				L_007f: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
				L_0084: ldarg.0 
				L_0085: ldnull 
				L_0086: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
				L_008b: ldarg.0 
				L_008c: ldc.i4.1 
				L_008d: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
				L_0092: ldarg.0 
				L_0093: ldc.i4.1 
				L_0094: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
				L_0099: ldarg.0 
				L_009a: ldstr "2006.11.07"
				L_009f: stfld Sunisoft.IrisSkin.SkinEngine::System.String __build
				L_00a4: ldarg.0 
				L_00a5: ldnull 
				L_00a6: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStream
				L_00ab: ldarg.0 
				L_00ac: newobj System.Collections.Hashtable::Void .ctor()
				L_00b1: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable disabledForm
				L_00b6: ldarg.0 
				L_00b7: ldc.i4.0 
				L_00b8: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_00bd: ldarg.0 
				L_00be: newobj Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void .ctor()
				L_00c3: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_00c8: ldarg.0 
				L_00c9: ldc.i4.0 
				L_00ca: stfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_00cf: ldarg.0 
				L_00d0: ldc.i4.0 
				L_00d1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_00d6: ldarg.0 
				L_00d7: ldc.i4.0 
				L_00d8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
				L_00dd: ldarg.0 
				L_00de: ldc.i4.0 
				L_00df: stfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
				L_00e4: ldarg.0 
				L_00e5: ldsfld System.IntPtr::IntPtr Zero
				L_00ea: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_00ef: ldarg.0 
				L_00f0: ldc.i4.0 
				L_00f1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00f6: ldarg.0 
				L_00f7: ldc.i4.0 
				L_00f8: stfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_00fd: ldarg.0 
				L_00fe: newobj System.Collections.Hashtable::Void .ctor()
				L_0103: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0108: ldarg.0 
				L_0109: newobj System.Collections.Hashtable::Void .ctor()
				L_010e: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0113: ldarg.0 
				L_0114: call System.ComponentModel.Component::Void .ctor()
				L_0119: ldarg.0 
				L_011a: call Sunisoft.IrisSkin.SkinEngine::Void InternalConstructor()
				L_011f: ret 
			*/
		#endregion
		
		#region Properties
		
			[BrowsableAttribute(false)]
			[DefaultValueAttribute("2006.11.07")]
			public string __Build
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String __build
					L_0006: ret 
				*/
				
				{
					return this.__build;
				}
			}
			
			
			[CategoryAttribute("Behavior")]
			[DefaultValueAttribute(true)]
			[DescriptionAttribute("If the skin engine skin all .NET forms")]
			public bool Active
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
					L_0006: ret 
				*/
				
				{
					return this.active;
				}
				set
				
				/*
					// Code Size: 14 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean active
					L_0007: ldarg.0 
					L_0008: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnActiveChanged()
					L_000d: ret 
				*/
				
				{
					this.active = value;
					this.OnActiveChanged ();
				}
			}
			
			
			[DescriptionAttribute("Build more skins into the EXE file")]
			[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
			[CategoryAttribute("Skins")]
			public ISkinCollection AddtionalBuiltInSkins
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection addtionalBuiltInSkins
					L_0006: ret 
				*/
				
				{
					return this.addtionalBuiltInSkins;
				}
			}
			
			
			internal IntPtr BackColorBrush
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
					L_0006: ret 
				*/
				
				{
					return this.backColorBrush;
				}
			}
			
			
			internal int BottomBorderHeight
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
					L_0006: ret 
				*/
				
				{
					return this.bottomBorderHeight;
				}
			}
			
			
			[CategoryAttribute("Skins")]
			[DescriptionAttribute("Specifies whether build the skin file into the EXE file.")]
			[DefaultValueAttribute(true)]
			public bool BuiltIn
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
					L_0006: ret 
				*/
				
				{
					return this.builtIn;
				}
				set
				
				/*
					// Code Size: 17 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
					L_0006: ldarg.1 
					L_0007: beq.s L_0010
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnBuiltInChanged(Boolean)
					L_0010: ret 
				*/
				
				{
					if (this.builtIn != value)
					{
						this.OnBuiltInChanged (value);
					}
				}
			}
			
			
			internal IntPtr ControlBorderBrush
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr controlBorderBrush
					L_0006: ret 
				*/
				
				{
					return this.controlBorderBrush;
				}
			}
			
			
			internal Hashtable DisabledForm
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable disabledForm
					L_0006: ret 
				*/
				
				{
					return this.disabledForm;
				}
			}
			
			
			[DescriptionAttribute("If you do not want skin the control, Set Control\'s Tag property to this")]
			[DefaultValueAttribute(270F)]
			[CategoryAttribute("Behavior")]
			public int DisableTag
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
					L_0006: ret 
				*/
				
				{
					return this.disableTag;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Int32 disableTag
					L_0007: ret 
				*/
				
				{
					this.disableTag = value;
				}
			}
			
			
			[DefaultValueAttribute(true)]
			[BrowsableAttribute(false)]
			public bool DrawFormCaption
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
					L_0006: ret 
				*/
				
				{
					return this.drawFormCaption;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormCaption
					L_0007: ret 
				*/
				
				{
					this.drawFormCaption = value;
				}
			}
			
			
			[BrowsableAttribute(false)]
			[DefaultValueAttribute(true)]
			public bool DrawFormIcon
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
					L_0006: ret 
				*/
				
				{
					return this.drawFormIcon;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawFormIcon
					L_0007: ret 
				*/
				
				{
					this.drawFormIcon = value;
				}
			}
			
			
			[CategoryAttribute("Behavior")]
			[DescriptionAttribute("If a line under the text will be added into the \'AcceptButton\' of a form")]
			[DefaultValueAttribute(false)]
			public bool DrawLineForAcceptButton
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
					L_0006: ret 
				*/
				
				{
					return this.drawLineForAcceptButton;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean drawLineForAcceptButton
					L_0007: ret 
				*/
				
				{
					this.drawLineForAcceptButton = value;
				}
			}
			
			
			[CategoryAttribute("Behavior")]
			[DefaultValueAttribute(false)]
			[DescriptionAttribute("Enable/Disable skin 3rd controls")]
			public bool Enable3rdControl
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
					L_0006: ret 
				*/
				
				{
					return this.enable3rdControl;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean enable3rdControl
					L_0007: ret 
				*/
				
				{
					this.enable3rdControl = value;
				}
			}
			
			
			[DefaultValueAttribute(FFFFFFFF)]
			[DescriptionAttribute("Force to specifies the position of the caption on title bar. In general, the pos"
+ "ition is an auto-position defined in a skin")]
			[CategoryAttribute("Behavior")]
			public int FormCaptionPosX
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
					L_0006: ret 
				*/
				
				{
					return this.formCaptionPosX;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosX
					L_0007: ret 
				*/
				
				{
					this.formCaptionPosX = value;
				}
			}
			
			
			[DescriptionAttribute("Force to specifies the position of the caption on title bar. In general, the pos"
+ "ition is an auto-position defined in a skin")]
			[DefaultValueAttribute(FFFFFFFF)]
			[CategoryAttribute("Behavior")]
			public int FormCaptionPosY
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
					L_0006: ret 
				*/
				
				{
					return this.formCaptionPosY;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formCaptionPosY
					L_0007: ret 
				*/
				
				{
					this.formCaptionPosY = value;
				}
			}
			
			
			internal int FormMinWidth
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
					L_0006: ret 
				*/
				
				{
					return this.formMinWidth;
				}
			}
			
			
			private static bool IsDesignModel
			
			{
				get
				
				/*
					// Code Size: 48 Bytes
					.maxstack 3
					.locals (System.String V_0)
					L_0000: call System.Windows.Forms.Application::System.String get_ExecutablePath()
					L_0005: call System.IO.Path::System.String GetFileName(System.String)
					L_000a: stloc.0 
					L_000b: ldloc.0 
					L_000c: brfalse.s L_0018
					L_000e: ldloc.0 
					L_000f: callvirt System.String::Int32 get_Length()
					L_0014: ldc.i4.s 10
					L_0016: beq.s L_001a
					L_0018: ldc.i4.0 
					L_0019: ret 
					L_001a: ldloc.0 
					L_001b: callvirt System.String::System.String ToUpper()
					L_0020: ldstr "DEVENV.EXE"
					L_0025: call System.String::Boolean op_Inequality(System.String, System.String)
					L_002a: brfalse.s L_002e
					L_002c: ldc.i4.0 
					L_002d: ret 
					L_002e: ldc.i4.1 
					L_002f: ret 
				*/
				
				{
					string string1 = Path.GetFileName (Application.ExecutablePath);
					if (string1 == null)
					{
						return false;
					}
					else if (string1.Length != 10)
					{
						return false;
					}
					else
					{
						switch (string1.ToUpper ())
						{
							case "DEVENV.EXE":
							
							{
									return true;
							}
							default:
							
							{
									return false;
							}
						}
					}
				}
			}
			
			
			internal int LeftBorderWidth
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
					L_0006: ret 
				*/
				
				{
					return this.leftBorderWidth;
				}
			}
			
			
			[DefaultValueAttribute(((String) null))]
			[DescriptionAttribute("Specifies the font of the main menu on the skinned forms")]
			[CategoryAttribute("Font")]
			public Font MenuFont
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
					L_0006: ret 
				*/
				
				{
					return this.menuFont;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font menuFont
					L_0007: ret 
				*/
				
				{
					this.menuFont = value;
				}
			}
			
			
			internal int MinTextWidth
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
					L_0006: ret 
				*/
				
				{
					return this.minTextWidth;
				}
			}
			
			
			[BrowsableAttribute(false)]
			public Component Owner
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
					L_0006: ret 
				*/
				
				{
					return this.owner;
				}
			}
			
			
			internal static int Random
			
			{
				get
				
				/*
					// Code Size: 59 Bytes
					.maxstack 3
					.locals (System.Int32 V_0)
					L_0000: ldsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_0005: brtrue.s L_0013
					L_0007: ldc.i4 50000
					L_000c: stsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_0011: br.s L_0027
					L_0013: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Random ram
					L_0018: ldc.i4 50001
					L_001d: callvirt System.Random::Int32 Next(Int32)
					L_0022: stsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_0027: ldsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_002c: stloc.0 
					L_002d: ldsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_0032: ldc.i4.1 
					L_0033: add 
					L_0034: stsfld Sunisoft.IrisSkin.SkinEngine::Int32 random
					L_0039: ldloc.0 
					L_003a: ret 
				*/
				
				{
					if (SkinEngine.random == 0)
					{
						SkinEngine.random = 50000;
					}
					else
					{
						SkinEngine.random = SkinEngine.ram.Next (50001);
					}
					int i1 = SkinEngine.random;
					SkinEngine.random++;
					return i1;
				}
			}
			
			
			internal Ix7f0ebae1a2d30adf Reader
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
					L_0006: ret 
				*/
				
				{
					return this.reader;
				}
			}
			
			
			internal bool RealActive
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
					L_0006: ret 
				*/
				
				{
					return this.realActive;
				}
			}
			
			
			[BrowsableAttribute(false)]
			public IRes Res
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res res
					L_0006: ret 
				*/
				
				{
					return this.res;
				}
			}
			
			
			[DefaultValueAttribute("&Close")]
			[DescriptionAttribute("Specifies the text for the close menu item in the system menu")]
			[CategoryAttribute("Misc")]
			public string ResSysMenuClose
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
					L_0006: ret 
				*/
				
				{
					return this.resSysMenuClose;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuClose
					L_0007: ret 
				*/
				
				{
					this.resSysMenuClose = value;
				}
			}
			
			
			[DescriptionAttribute("Specifies the text for the maximize/restore menu item in the system menu")]
			[CategoryAttribute("Misc")]
			[DefaultValueAttribute("Ma&ximize/Restore")]
			public string ResSysMenuMax
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
					L_0006: ret 
				*/
				
				{
					return this.resSysMenuMax;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMax
					L_0007: ret 
				*/
				
				{
					this.resSysMenuMax = value;
				}
			}
			
			
			[CategoryAttribute("Misc")]
			[DefaultValueAttribute("Mi&nimize")]
			[DescriptionAttribute("Specifies the text for the minimize menu item in the system menu")]
			public string ResSysMenuMin
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
					L_0006: ret 
				*/
				
				{
					return this.resSysMenuMin;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.String resSysMenuMin
					L_0007: ret 
				*/
				
				{
					this.resSysMenuMin = value;
				}
			}
			
			
			internal int RightBorderWidth
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
					L_0006: ret 
				*/
				
				{
					return this.rightBorderWidth;
				}
			}
			
			
			[DefaultValueAttribute(" ")]
			[CategoryAttribute("Misc")]
			[DescriptionAttribute("Input the serial number hear to built the skin without registry infomation")]
			public string SerialNumber
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
					L_0006: ret 
				*/
				
				{
					return this.serialNumber;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.String serialNumber
					L_0007: ret 
				*/
				
				{
					this.serialNumber = value;
				}
			}
			
			
			[DescriptionAttribute("If the skin engine skin all .NET forms")]
			[DefaultValueAttribute(true)]
			[CategoryAttribute("Behavior")]
			public bool SkinAllForm
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
					L_0006: ret 
				*/
				
				{
					return this.skinAllForm;
				}
				set
				
				/*
					// Code Size: 14 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinAllForm
					L_0007: ldarg.0 
					L_0008: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnSkinAllFormChanged()
					L_000d: ret 
				*/
				
				{
					this.skinAllForm = value;
					this.OnSkinAllFormChanged ();
				}
			}
			
			
			[DefaultValueAttribute(true)]
			[CategoryAttribute("Behavior")]
			[DescriptionAttribute("If the skin engine skin the dialogs")]
			public bool SkinDialogs
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
					L_0006: ret 
				*/
				
				{
					return this.skinDialogs;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinDialogs
					L_0007: ret 
				*/
				
				{
					this.skinDialogs = value;
				}
			}
			
			
			[EditorAttribute(((Type) typeof (x1cc8dd3ebd3495cd)), ((Type) typeof (UITypeEditor)))]
			[DescriptionAttribute("Specifies the skin file(.sui file). ")]
			[CategoryAttribute("Skins")]
			public string SkinFile
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String skinFile
					L_0006: ret 
				*/
				
				{
					return this.skinFile;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnSkinFileChanged(System.String)
					L_0007: ret 
				*/
				
				{
					this.OnSkinFileChanged (value);
				}
			}
			
			
			[CategoryAttribute("Skins")]
			[DescriptionAttribute("Specifies the password of the skinFile")]
			[DefaultValueAttribute(((String) null))]
			public string SkinPassword
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
					L_0006: ret 
				*/
				
				{
					return this.skinPassword;
				}
				set
				
				/*
					// Code Size: 20 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
					L_0006: ldarg.1 
					L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x2a6dc4421904bcaa(System.String)
					L_000c: ldarg.0 
					L_000d: ldarg.1 
					L_000e: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
					L_0013: ret 
				*/
				
				{
					((Ix7f0ebae1a2d30adf) this.reader).x2a6dc4421904bcaa = value;
					this.skinPassword = value;
				}
			}
			
			
			[CategoryAttribute("Behavior")]
			[DescriptionAttribute("If the skin engine skin the Scroll bar of a control")]
			[DefaultValueAttribute(true)]
			public bool SkinScrollBar
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
					L_0006: ret 
				*/
				
				{
					return this.skinScrollBar;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::Boolean skinScrollBar
					L_0007: ret 
				*/
				
				{
					this.skinScrollBar = value;
				}
			}
			
			
			[BrowsableAttribute(false)]
			[DefaultValueAttribute(((String) null))]
			public Stream SkinStream
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStream
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
					L_0002: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnSkinStreamChanged(System.IO.Stream)
					L_0007: ret 
				*/
				
				{
					this.OnSkinStreamChanged (value);
				}
			}
			
			
			[DefaultValueAttribute(((String) null))]
			[BrowsableAttribute(false)]
			public Stream SkinStreamMain
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStreamMain
					L_0006: ret 
				*/
				
				{
					return this.skinStreamMain;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnMainSkinStreamChanged(System.IO.Stream)
					L_0007: ret 
				*/
				
				{
					this.OnMainSkinStreamChanged (value);
				}
			}
			
			
			[DescriptionAttribute("Specifies the title font of the skinned forms")]
			[DefaultValueAttribute(((String) null))]
			[CategoryAttribute("Font")]
			public Font TitleFont
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
					L_0006: ret 
				*/
				
				{
					return this.titleFont;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font titleFont
					L_0007: ret 
				*/
				
				{
					this.titleFont = value;
				}
			}
			
			
			internal int TitleHeight
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
					L_0006: ret 
				*/
				
				{
					return this.titleHeight;
				}
			}
			
			
			[CategoryAttribute("Version")]
			[DescriptionAttribute("Current version of IrisSkin")]
			public string Version
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldstr "3.3"
					L_0005: ret 
				*/
				
				{
					return "3.3";
				}
			}
			
		#endregion
		
		#region Events
		
			public event SkinChanged CurrentSkinChanged
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.SkinChanged
					L_0012: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
					L_0017: ret 
				*/
				
				{
					this.CurrentSkinChanged = ((SkinChanged) Delegate.Combine (((Delegate) this.CurrentSkinChanged), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.SkinChanged
					L_0012: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
					L_0017: ret 
				*/
				
				{
					this.CurrentSkinChanged = ((SkinChanged) Delegate.Remove (((Delegate) this.CurrentSkinChanged), ((Delegate) value)));
				}
			}
			
		#endregion
		
		#region Methods
		
			public void AddContextMenu (ContextMenu menu)
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brfalse.s L_000b
				L_0003: ldarg.0 
				L_0004: ldarg.1 
				L_0005: newobj Sunisoft.IrisSkin.xa1883d0b59b7005b::Void .ctor(Sunisoft.IrisSkin.SkinEngine, System.Windows.Forms.Menu)
				L_000a: pop 
				L_000b: ret 
			*/
			
			
			{
				if (menu != null)
				{
					xa1883d0b59b7005b xa1883d0b59b7005b1 = new xa1883d0b59b7005b (this, ((Menu) menu));
				}
			}
			
			public void AddControl (Control control)
			
			/*
				// Code Size: 16 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brfalse.s L_000f
				L_0003: ldarg.1 
				L_0004: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0009: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_000e: pop 
				L_000f: ret 
			*/
			
			
			{
				if (control != null)
				{
					xbd3f2493841f18a1 xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control, SkinEngine.Engine);
				}
			}
			
			public void AddForm (Form form)
			
			/*
				// Code Size: 75 Bytes
				.maxstack 5
				L_0000: ldarg.1 
				L_0001: brfalse.s L_000b
				L_0003: ldarg.1 
				L_0004: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0009: brfalse.s L_000c
				L_000b: ret 
				L_000c: ldarg.1 
				L_000d: callvirt System.Windows.Forms.Control::Boolean get_Created()
				L_0012: brfalse.s L_0038
				L_0014: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0019: ldarg.1 
				L_001a: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001f: box System.IntPtr
				L_0024: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0029: pop 
				L_002a: ldarg.0 
				L_002b: ldarg.1 
				L_002c: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0031: ldc.i4.1 
				L_0032: call Sunisoft.IrisSkin.SkinEngine::Void DoAddWnd(IntPtr, Boolean)
				L_0037: ret 
				L_0038: ldarg.1 
				L_0039: ldarg.0 
				L_003a: ldftn Sunisoft.IrisSkin.SkinEngine::Void SkinFormHandleCreated(System.Object, System.EventArgs)
				L_0040: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0045: callvirt System.Windows.Forms.Control::Void add_HandleCreated(System.EventHandler)
				L_004a: ret 
			*/
			
			
			{
				if ((form != null) && (! form.IsDisposed))
				{
					if (form.Created)
					{
						int i1 = SkinEngine.SkinHandleList.Add (form.Handle);
						this.DoAddWnd (form.Handle, true);
					}
					else
					{
						form.HandleCreated += new EventHandler (this.SkinFormHandleCreated);
					}
				}
			}
			
			public void ApplyAdditionalBuiltInSkins (int count)
			
			/*
				// Code Size: 131 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection get_AddtionalBuiltInSkins()
				L_0006: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_000b: brtrue.s L_0018
				L_000d: ldstr "there is no addtional built in skin"
				L_0012: newobj System.ApplicationException::Void .ctor(System.String)
				L_0017: throw 
				L_0018: ldarg.1 
				L_0019: ldc.i4.0 
				L_001a: blt.s L_002a
				L_001c: ldarg.1 
				L_001d: ldarg.0 
				L_001e: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection get_AddtionalBuiltInSkins()
				L_0023: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0028: ble.s L_004f
				L_002a: ldstr "count"
				L_002f: ldstr "count must equal to 0 or greater than 0 and less than {0}"
				L_0034: ldarg.0 
				L_0035: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection get_AddtionalBuiltInSkins()
				L_003a: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_003f: box System.Int32
				L_0044: call System.String::System.String Format(System.String, System.Object)
				L_0049: newobj System.ArgumentOutOfRangeException::Void .ctor(System.String, System.String)
				L_004e: throw 
				L_004f: ldarg.0 
				L_0050: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0055: ldarg.0 
				L_0056: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection get_AddtionalBuiltInSkins()
				L_005b: ldarg.1 
				L_005c: callvirt Sunisoft.IrisSkin.SkinCollection::Sunisoft.IrisSkin.SkinCollectionItem get_Item(Int32)
				L_0061: callvirt Sunisoft.IrisSkin.SkinCollectionItem::System.String get_SkinPassword()
				L_0066: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x2a6dc4421904bcaa(System.String)
				L_006b: ldarg.0 
				L_006c: ldarg.0 
				L_006d: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection get_AddtionalBuiltInSkins()
				L_0072: ldarg.1 
				L_0073: callvirt Sunisoft.IrisSkin.SkinCollection::Sunisoft.IrisSkin.SkinCollectionItem get_Item(Int32)
				L_0078: callvirt Sunisoft.IrisSkin.SkinCollectionItem::System.IO.MemoryStream get_SkinSteam()
				L_007d: call Sunisoft.IrisSkin.SkinEngine::Void set_SkinStream(System.IO.Stream)
				L_0082: ret 
			*/
			
			
			{
				if (((SkinCollection) this.AddtionalBuiltInSkins).Count == 0)
				{
					throw new ApplicationException ("there is no addtional built in skin");
				}
				else if ((count < 0) || (count > ((SkinCollection) this.AddtionalBuiltInSkins).Count))
				{
					throw new ArgumentOutOfRangeException ("count", string.Format ("count must equal to 0 or greater than 0 and less than {0}", ((SkinCollection) this.AddtionalBuiltInSkins).Count));
				}
				else
				{
					((Ix7f0ebae1a2d30adf) this.reader).x2a6dc4421904bcaa = ((SkinCollectionItem) this.AddtionalBuiltInSkins[count]).SkinPassword;
					this.SkinStream = ((Stream) ((SkinCollectionItem) this.AddtionalBuiltInSkins[count]).SkinSteam);
				}
			}
			
			public void ApplyMainBuiltInSkin ()
			
			/*
				// Code Size: 30 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.SkinEngine::System.String skinPassword
				L_000c: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x2a6dc4421904bcaa(System.String)
				L_0011: ldarg.0 
				L_0012: ldarg.0 
				L_0013: call Sunisoft.IrisSkin.SkinEngine::System.IO.Stream get_SkinStreamMain()
				L_0018: call Sunisoft.IrisSkin.SkinEngine::Void set_SkinStream(System.IO.Stream)
				L_001d: ret 
			*/
			
			
			{
				((Ix7f0ebae1a2d30adf) this.reader).x2a6dc4421904bcaa = this.skinPassword;
				this.SkinStream = this.SkinStreamMain;
			}
			
			protected override void Dispose (bool disposing)
			
			/*
				// Code Size: 48 Bytes
				.maxstack 9
				L_0000: ldsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_0005: ldsfld System.IntPtr::IntPtr Zero
				L_000a: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_000f: brfalse.s L_0026
				L_0011: ldsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_0016: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean UnhookWindowsHookEx(IntPtr)
				L_001b: pop 
				L_001c: ldsfld System.IntPtr::IntPtr Zero
				L_0021: stsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_0026: ldarg.1 
				L_0027: pop 
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: call System.ComponentModel.Component::Void Dispose(Boolean)
				L_002f: ret 
			*/
			
			
			{
				if (SkinEngine.Hook != IntPtr.Zero)
				{
					bool b1 = x61467fe65a98f20c.UnhookWindowsHookEx (SkinEngine.Hook);
					SkinEngine.Hook = IntPtr.Zero;
				}
				base.Dispose (disposing);
			}
			
			private void DoAddDlg (IntPtr handle, bool isManul)
			
			/*
				// Code Size: 61 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.xb052c904ac95dc43 V_0)
				L_0000: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable dialogList
				L_0005: ldarg.1 
				L_0006: box System.IntPtr
				L_000b: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0010: brtrue.s L_003c
				L_0012: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable dialogList
				L_0017: ldarg.1 
				L_0018: box System.IntPtr
				L_001d: ldnull 
				L_001e: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0023: ldarg.1 
				L_0024: ldarg.0 
				L_0025: newobj Sunisoft.IrisSkin.xb052c904ac95dc43::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_002a: stloc.0 
				L_002b: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable dialogList
				L_0030: ldarg.1 
				L_0031: box System.IntPtr
				L_0036: ldloc.0 
				L_0037: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_003c: ret 
			*/
			
			
			{
				if (SkinEngine.dialogList.ContainsKey (handle))
				{
					return;
				}
				SkinEngine.dialogList.Add (handle, null);
				xb052c904ac95dc43 xb052c904ac95dc43_1 = new xb052c904ac95dc43 (handle, this);
				SkinEngine.dialogList[handle] = xb052c904ac95dc43_1;
			}
			
			private void DoAddWnd (IntPtr handle, bool isManual)
			
			/*
				// Code Size: 128 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Control V_0, 
         Sunisoft.IrisSkin.xa427f1b2281f554b V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Control::System.Windows.Forms.Control FromHandle(IntPtr)
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: isinst System.Windows.Forms.Form
				L_000d: brfalse.s L_007f
				L_000f: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_0014: ldarg.1 
				L_0015: box System.IntPtr
				L_001a: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_001f: brtrue.s L_007f
				L_0021: ldloc.0 
				L_0022: callvirt System.Windows.Forms.Control::System.String get_CompanyName()
				L_0027: ldstr "9Rays.Net"
				L_002c: call System.String::Boolean op_Equality(System.String, System.String)
				L_0031: brfalse.s L_0034
				L_0033: ret 
				L_0034: ldloc.0 
				L_0035: callvirt System.Object::System.Type GetType()
				L_003a: callvirt System.Type::System.String get_FullName()
				L_003f: ldstr "XPTable.Editors.DropDownContainer"
				L_0044: call System.String::Boolean op_Equality(System.String, System.String)
				L_0049: brfalse.s L_004c
				L_004b: ret 
				L_004c: ldloc.0 
				L_004d: isinst Sunisoft.IrisSkin.InternalControls.x4fef14ebf3863c7f
				L_0052: brfalse.s L_0055
				L_0054: ret 
				L_0055: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_005a: ldarg.1 
				L_005b: box System.IntPtr
				L_0060: ldnull 
				L_0061: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0066: ldarg.1 
				L_0067: ldarg.0 
				L_0068: newobj Sunisoft.IrisSkin.xa427f1b2281f554b::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_006d: stloc.1 
				L_006e: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_0073: ldarg.1 
				L_0074: box System.IntPtr
				L_0079: ldloc.1 
				L_007a: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_007f: ret 
			*/
			
			
			{
				Control control1 = Control.FromHandle (handle);
				if (((((! (control1 is Form)) || SkinEngine.windowList.ContainsKey (handle)) || (control1.CompanyName == "9Rays.Net")) || (control1.GetType ().FullName == "XPTable.Editors.DropDownContainer")) || (control1 is x4fef14ebf3863c7f))
				{
					return;
				}
				SkinEngine.windowList.Add (handle, null);
				xa427f1b2281f554b xa427f1b2281f554b1 = new xa427f1b2281f554b (handle, this);
				SkinEngine.windowList[handle] = xa427f1b2281f554b1;
			}
			
			private static unsafe IntPtr FnHookProc (int nCode, IntPtr wParam, IntPtr lParam)
			
			/*
				// Code Size: 482 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.Control V_0, 
         System.Text.StringBuilder V_1, 
         System.Text.StringBuilder V_2, 
         System.String V_3, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+CBT_CREATEWND* V_4, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+CREATESTRUCT* V_5, 
         System.Int32 V_6)
				L_0000: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0005: brfalse L_01d4
				L_000a: ldarg.0 
				L_000b: stloc.s V_6
				L_000d: ldloc.s V_6
				L_000f: ldc.i4.3 
				L_0010: sub 
				L_0011: switch (L_0151, L_01d4, L_0027)
				L_0022: br L_01d4
				L_0027: ldarg.1 
				L_0028: call System.Windows.Forms.Control::System.Windows.Forms.Control FromHandle(IntPtr)
				L_002d: stloc.0 
				L_002e: ldloc.0 
				L_002f: brfalse L_00e7
				L_0034: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0039: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinAllForm()
				L_003e: brfalse.s L_0082
				L_0040: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0045: ldarg.1 
				L_0046: box System.IntPtr
				L_004b: callvirt System.Collections.ArrayList::Boolean Contains(System.Object)
				L_0050: brtrue L_01d4
				L_0055: ldloc.0 
				L_0056: isinst System.Windows.Forms.Form
				L_005b: brfalse L_01d4
				L_0060: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0065: ldarg.1 
				L_0066: box System.IntPtr
				L_006b: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0070: pop 
				L_0071: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0076: ldarg.1 
				L_0077: ldc.i4.0 
				L_0078: callvirt Sunisoft.IrisSkin.SkinEngine::Void DoAddWnd(IntPtr, Boolean)
				L_007d: br L_01d4
				L_0082: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0087: callvirt Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component get_Owner()
				L_008c: isinst System.Windows.Forms.Form
				L_0091: brfalse L_01d4
				L_0096: ldloc.0 
				L_0097: callvirt System.Object::System.Type GetType()
				L_009c: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_00a1: callvirt Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component get_Owner()
				L_00a6: callvirt System.Object::System.Type GetType()
				L_00ab: bne.un L_01d4
				L_00b0: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_00b5: ldarg.1 
				L_00b6: box System.IntPtr
				L_00bb: callvirt System.Collections.ArrayList::Boolean Contains(System.Object)
				L_00c0: brtrue L_01d4
				L_00c5: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_00ca: ldarg.1 
				L_00cb: box System.IntPtr
				L_00d0: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00d5: pop 
				L_00d6: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_00db: ldarg.1 
				L_00dc: ldc.i4.0 
				L_00dd: callvirt Sunisoft.IrisSkin.SkinEngine::Void DoAddWnd(IntPtr, Boolean)
				L_00e2: br L_01d4
				L_00e7: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_00ec: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinDialogs()
				L_00f1: brfalse L_01d4
				L_00f6: ldc.i4 260
				L_00fb: newobj System.Text.StringBuilder::Void .ctor(Int32)
				L_0100: stloc.1 
				L_0101: ldarg.1 
				L_0102: ldloc.1 
				L_0103: ldc.i4 260
				L_0108: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetClassName(IntPtr, System.Text.StringBuilder, Int32)
				L_010d: pop 
				L_010e: ldloc.1 
				L_010f: callvirt System.Text.StringBuilder::Int32 get_Length()
				L_0114: ldc.i4.6 
				L_0115: bne.un L_01d4
				L_011a: ldloc.1 
				L_011b: callvirt System.Text.StringBuilder::System.String ToString()
				L_0120: ldstr "#32770"
				L_0125: call System.String::Boolean op_Equality(System.String, System.String)
				L_012a: brfalse L_01d4
				L_012f: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0134: ldarg.1 
				L_0135: box System.IntPtr
				L_013a: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_013f: pop 
				L_0140: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0145: ldarg.1 
				L_0146: ldc.i4.1 
				L_0147: callvirt Sunisoft.IrisSkin.SkinEngine::Void DoAddDlg(IntPtr, Boolean)
				L_014c: br L_01d4
				L_0151: ldc.i4 260
				L_0156: newobj System.Text.StringBuilder::Void .ctor(Int32)
				L_015b: stloc.2 
				L_015c: ldarg.1 
				L_015d: ldloc.2 
				L_015e: ldc.i4 260
				L_0163: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetClassName(IntPtr, System.Text.StringBuilder, Int32)
				L_0168: pop 
				L_0169: ldloc.2 
				L_016a: callvirt System.Text.StringBuilder::Int32 get_Length()
				L_016f: ldc.i4.s 9
				L_0171: bne.un.s L_01d4
				L_0173: ldloc.2 
				L_0174: callvirt System.Text.StringBuilder::System.String ToString()
				L_0179: callvirt System.String::System.String ToUpper()
				L_017e: stloc.3 
				L_017f: ldloc.3 
				L_0180: ldstr "SCROLLBAR"
				L_0185: call System.String::Boolean op_Equality(System.String, System.String)
				L_018a: brfalse.s L_01d4
				L_018c: ldarg.2 
				L_018d: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_0192: stloc.s V_4
				L_0194: ldloc.s V_4
				L_0196: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+CBT_CREATEWND::IntPtr lpcs
				L_019b: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_01a0: stloc.s V_5
				L_01a2: ldloc.s V_5
				L_01a4: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+CREATESTRUCT::Int64 style
				L_01a9: ldc.i4.s 16
				L_01ab: conv.i8 
				L_01ac: and 
				L_01ad: ldc.i4.s 16
				L_01af: conv.i8 
				L_01b0: bne.un.s L_01d4
				L_01b2: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_01b7: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
				L_01bc: brfalse.s L_01d4
				L_01be: ldloc.s V_5
				L_01c0: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+CREATESTRUCT::Int64 style
				L_01c5: ldc.i4 1442971668
				L_01ca: conv.i8 
				L_01cb: bgt.s L_01d4
				L_01cd: ldc.i4.1 
				L_01ce: newobj System.IntPtr::Void .ctor(Int32)
				L_01d3: ret 
				L_01d4: ldsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_01d9: ldarg.0 
				L_01da: ldarg.1 
				L_01db: ldarg.2 
				L_01dc: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr CallNextHookEx(IntPtr, Int32, IntPtr, IntPtr)
				L_01e1: ret 
			*/
			
			
			{
				Control control1;
				StringBuilder stringBuilder1;
				StringBuilder stringBuilder2;
				x40255b11ef821fa3.CREATESTRUCT* cREATESTRUCT_Ptr1;
				if (SkinEngine.Engine != null)
				{
					switch (nCode)
					{
						case 3:
						
						{
								stringBuilder2 = new StringBuilder (260);
								int i6 = x61467fe65a98f20c.GetClassName (wParam, stringBuilder2, 260);
								if (stringBuilder2.Length != 9)
								{
									return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
								}
								else
								{
									switch (stringBuilder2.ToString ().ToUpper ())
									{
										case "SCROLLBAR":
										
										{
												if (((cREATESTRUCT_Ptr1 = ((x40255b11ef821fa3.CREATESTRUCT*) ((void*) ((x40255b11ef821fa3.CBT_CREATEWND*) ((void*) lParam))->lpcs)))->style & ((long) 16)) != ((long) 16))
												{
													return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
												}
												else if (! ((SkinEngine) SkinEngine.Engine).RealActive)
												{
													return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
												}
												else if (cREATESTRUCT_Ptr1->style > ((long) 1442971668))
												{
													return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
												}
												else
												{
													return new IntPtr (1);
												}
										}
										default:
										
										{
												return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
										}
									}
								}
						}
						case 4:
						
						{
								return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
						}
						case 5:
						
						{
								control1 = Control.FromHandle (wParam);
								if (control1 == null)
								{
									if (! ((SkinEngine) SkinEngine.Engine).SkinDialogs)
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									stringBuilder1 = new StringBuilder (260);
									int i4 = x61467fe65a98f20c.GetClassName (wParam, stringBuilder1, 260);
									if (stringBuilder1.Length != 6)
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									if (stringBuilder1.ToString () != "#32770")
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									int i5 = SkinEngine.SkinHandleList.Add (wParam);
									((SkinEngine) SkinEngine.Engine).DoAddDlg (wParam, true);
									return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
								}
								if (! ((SkinEngine) SkinEngine.Engine).SkinAllForm)
								{
									if (! (((SkinEngine) SkinEngine.Engine).Owner is Form))
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									if (control1.GetType () != ((SkinEngine) SkinEngine.Engine).Owner.GetType ())
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									if (SkinEngine.SkinHandleList.Contains (wParam))
									{
										return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
									}
									int i3 = SkinEngine.SkinHandleList.Add (wParam);
									((SkinEngine) SkinEngine.Engine).DoAddWnd (wParam, false);
									return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
								}
								if (SkinEngine.SkinHandleList.Contains (wParam))
								{
									return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
								}
								if (! (control1 is Form))
								{
									return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
								}
								int i2 = SkinEngine.SkinHandleList.Add (wParam);
								((SkinEngine) SkinEngine.Engine).DoAddWnd (wParam, false);
								return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
						}
					}
				}
				return x61467fe65a98f20c.CallNextHookEx (SkinEngine.Hook, nCode, wParam, lParam);
			}
			
			public Bitmap GetBitmap (string key, int spitCount, int spitIndex)
			
			/*
				// Code Size: 106 Bytes
				.maxstack 5
				.locals (System.String V_0, 
         System.Drawing.Bitmap V_1)
				L_0000: ldstr "{0}{1}OF{2}"
				L_0005: ldarg.1 
				L_0006: ldarg.3 
				L_0007: box System.Int32
				L_000c: ldarg.2 
				L_000d: box System.Int32
				L_0012: call System.String::System.String Format(System.String, System.Object, System.Object, System.Object)
				L_0017: stloc.0 
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_001e: ldloc.0 
				L_001f: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0024: brfalse.s L_0038
				L_0026: ldarg.0 
				L_0027: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_002c: ldloc.0 
				L_002d: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0032: castclass System.Drawing.Bitmap
				L_0037: ret 
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_003e: ldarg.1 
				L_003f: ldarg.2 
				L_0040: ldarg.3 
				L_0041: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Drawing.Bitmap x14140ce12c223866(System.String, Int32, Int32)
				L_0046: stloc.1 
				L_0047: ldloc.1 
				L_0048: brfalse.s L_005b
				L_004a: ldloc.1 
				L_004b: ldarg.0 
				L_004c: ldstr "SKIN2_TRANSCOLOR"
				L_0051: call Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0056: callvirt System.Drawing.Bitmap::Void MakeTransparent(System.Drawing.Color)
				L_005b: ldarg.0 
				L_005c: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0061: ldloc.0 
				L_0062: ldloc.1 
				L_0063: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0068: ldloc.1 
				L_0069: ret 
			*/
			
			
			{
				string string1 = string.Format ("{0}{1}OF{2}", key, spitIndex, spitCount);
				if (this.bitmapList.ContainsKey (string1))
				{
					return ((Bitmap) this.bitmapList[string1]);
				}
				Bitmap bitmap1 = ((Ix7f0ebae1a2d30adf) this.reader).x14140ce12c223866 (key, spitCount, spitIndex);
				if (bitmap1 != null)
				{
					bitmap1.MakeTransparent (this.GetColor ("SKIN2_TRANSCOLOR"));
				}
				this.bitmapList.Add (string1, bitmap1);
				return bitmap1;
			}
			
			public Bitmap GetBitmap (string key)
			
			/*
				// Code Size: 80 Bytes
				.maxstack 4
				.locals (System.Drawing.Bitmap V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_000c: brfalse.s L_0020
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0014: ldarg.1 
				L_0015: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_001a: castclass System.Drawing.Bitmap
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0026: ldarg.1 
				L_0027: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Drawing.Bitmap x14140ce12c223866(System.String)
				L_002c: stloc.0 
				L_002d: ldloc.0 
				L_002e: brfalse.s L_0041
				L_0030: ldloc.0 
				L_0031: ldarg.0 
				L_0032: ldstr "SKIN2_TRANSCOLOR"
				L_0037: call Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_003c: callvirt System.Drawing.Bitmap::Void MakeTransparent(System.Drawing.Color)
				L_0041: ldarg.0 
				L_0042: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_0047: ldarg.1 
				L_0048: ldloc.0 
				L_0049: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_004e: ldloc.0 
				L_004f: ret 
			*/
			
			
			{
				if (this.bitmapList.ContainsKey (key))
				{
					return ((Bitmap) this.bitmapList[key]);
				}
				Bitmap bitmap1 = ((Ix7f0ebae1a2d30adf) this.reader).x14140ce12c223866 (key);
				if (bitmap1 != null)
				{
					bitmap1.MakeTransparent (this.GetColor ("SKIN2_TRANSCOLOR"));
				}
				this.bitmapList.Add (key, bitmap1);
				return bitmap1;
			}
			
			public bool GetBool (string key)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0006: ldarg.1 
				L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean x6e16b83386574e87(System.String)
				L_000c: ret 
			*/
			
			
			{
				return ((Ix7f0ebae1a2d30adf) this.reader).x6e16b83386574e87 (key);
			}
			
			public Brush GetBrush (string key)
			
			/*
				// Code Size: 65 Bytes
				.maxstack 4
				.locals (System.Drawing.Brush V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0006: ldarg.1 
				L_0007: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_000c: brfalse.s L_0020
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0014: ldarg.1 
				L_0015: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_001a: castclass System.Drawing.Brush
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0026: ldarg.1 
				L_0027: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Drawing.Color xef50a938c8b9c7fd(System.String)
				L_002c: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0031: stloc.0 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0038: ldarg.1 
				L_0039: ldloc.0 
				L_003a: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_003f: ldloc.0 
				L_0040: ret 
			*/
			
			
			{
				if (this.brushList.ContainsKey (key))
				{
					return ((Brush) this.brushList[key]);
				}
				Brush brush1 = ((Brush) new SolidBrush (((Ix7f0ebae1a2d30adf) this.reader).xef50a938c8b9c7fd (key)));
				this.brushList.Add (key, brush1);
				return brush1;
			}
			
			public Color GetColor (string key)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0006: ldarg.1 
				L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::System.Drawing.Color xef50a938c8b9c7fd(System.String)
				L_000c: ret 
			*/
			
			
			{
				return ((Ix7f0ebae1a2d30adf) this.reader).xef50a938c8b9c7fd (key);
			}
			
			public int GetInt (string key)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0006: ldarg.1 
				L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Int32 x88bcf0804211ebbb(System.String)
				L_000c: ret 
			*/
			
			
			{
				return ((Ix7f0ebae1a2d30adf) this.reader).x88bcf0804211ebbb (key);
			}
			
			private void InternalConstructor ()
			
			/*
				// Code Size: 199 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.Form V_0)
				L_0000: ldarg.0 
				L_0001: newobj Sunisoft.IrisSkin.SkinCollection::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinCollection addtionalBuiltInSkins
				L_000b: call Sunisoft.IrisSkin.SkinEngine::Boolean get_IsDesignModel()
				L_0010: brtrue L_00c6
				L_0015: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_001a: brtrue.s L_006f
				L_001c: ldarg.0 
				L_001d: stsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0022: ldsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_0027: ldsfld System.IntPtr::IntPtr Zero
				L_002c: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_0031: brfalse L_00c6
				L_0036: ldnull 
				L_0037: ldftn Sunisoft.IrisSkin.SkinEngine::IntPtr FnHookProc(Int32, IntPtr, IntPtr)
				L_003d: newobj Sunisoft.IrisSkin.x6161963e817c3cff::Void .ctor(System.Object, IntPtr)
				L_0042: stsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x6161963e817c3cff CbtProc
				L_0047: ldc.i4.5 
				L_0048: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x6161963e817c3cff CbtProc
				L_004d: ldc.i4.0 
				L_004e: call System.AppDomain::Int32 GetCurrentThreadId()
				L_0053: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetWindowsHookEx(Int32, Sunisoft.IrisSkin.x6161963e817c3cff, Int32, Int32)
				L_0058: stsfld Sunisoft.IrisSkin.SkinEngine::IntPtr Hook
				L_005d: ldnull 
				L_005e: ldftn Sunisoft.IrisSkin.SkinEngine::Void OnApplicationExit(System.Object, System.EventArgs)
				L_0064: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0069: call System.Windows.Forms.Application::Void add_ApplicationExit(System.EventHandler)
				L_006e: ret 
				L_006f: ldarg.0 
				L_0070: ldfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
				L_0075: isinst System.Windows.Forms.Form
				L_007a: brfalse.s L_00c6
				L_007c: ldarg.0 
				L_007d: ldfld Sunisoft.IrisSkin.SkinEngine::System.ComponentModel.Component owner
				L_0082: castclass System.Windows.Forms.Form
				L_0087: stloc.0 
				L_0088: ldloc.0 
				L_0089: callvirt System.Windows.Forms.Control::Boolean get_Created()
				L_008e: brfalse.s L_00b4
				L_0090: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0095: ldloc.0 
				L_0096: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_009b: box System.IntPtr
				L_00a0: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_00a5: pop 
				L_00a6: ldarg.0 
				L_00a7: ldloc.0 
				L_00a8: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00ad: ldc.i4.1 
				L_00ae: call Sunisoft.IrisSkin.SkinEngine::Void DoAddWnd(IntPtr, Boolean)
				L_00b3: ret 
				L_00b4: ldloc.0 
				L_00b5: ldarg.0 
				L_00b6: ldftn Sunisoft.IrisSkin.SkinEngine::Void SkinFormHandleCreated(System.Object, System.EventArgs)
				L_00bc: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_00c1: callvirt System.Windows.Forms.Control::Void add_HandleCreated(System.EventHandler)
				L_00c6: ret 
			*/
			
			
			{
				this.addtionalBuiltInSkins = new SkinCollection ();
				if (((SkinEngine) ISkinEngine).IsDesignModel)
				{
					return;
				}
				if (SkinEngine.Engine == null)
				{
					SkinEngine.Engine = this;
					if (SkinEngine.Hook == IntPtr.Zero)
					{
						SkinEngine.CbtProc = new x6161963e817c3cff (SkinEngine.FnHookProc);
						SkinEngine.Hook = x61467fe65a98f20c.SetWindowsHookEx (5, SkinEngine.CbtProc, 0, AppDomain.GetCurrentThreadId ());
						Application.ApplicationExit += new EventHandler (SkinEngine.OnApplicationExit);
					}
					return;
				}
				if (! (this.owner is Form))
				{
					return;
				}
				Form form1 = ((Form) this.owner);
				if (form1.Created)
				{
					int i1 = SkinEngine.SkinHandleList.Add (form1.Handle);
					this.DoAddWnd (form1.Handle, true);
				}
				else
				{
					form1.HandleCreated += new EventHandler (this.SkinFormHandleCreated);
				}
			}
			
			protected virtual void OnActiveChanged ()
			
			/*
				// Code Size: 55 Bytes
				.maxstack 9
				L_0000: call Sunisoft.IrisSkin.SkinEngine::Boolean get_IsDesignModel()
				L_0005: brtrue.s L_0036
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_000d: brfalse.s L_0029
				L_000f: ldarg.0 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0016: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_001b: ldarg.0 
				L_001c: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0021: and 
				L_0022: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_0027: br.s L_0030
				L_0029: ldarg.0 
				L_002a: ldc.i4.0 
				L_002b: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_0030: ldarg.0 
				L_0031: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnCurrentSkinChanged()
				L_0036: ret 
			*/
			
			
			{
				if (! ((SkinEngine) ISkinEngine).IsDesignModel)
				{
					if (this.reader != null)
					{
						this.realActive = (((Ix7f0ebae1a2d30adf) this.reader).xb591119eb9470315 && this.active);
					}
					else
					{
						this.realActive = false;
					}
					this.OnCurrentSkinChanged ();
				}
			}
			
			private static void OnApplicationExit (object sender, EventArgs e)
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: ldsfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinEngine Engine
				L_0005: ldc.i4.0 
				L_0006: callvirt System.ComponentModel.Component::Void Dispose(Boolean)
				L_000b: ret 
			*/
			
			
			{
				((SkinEngine) SkinEngine.Engine).Dispose (false);
			}
			
			protected virtual void OnBuiltInChanged (bool builtIn)
			
			/*
				// Code Size: 45 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brfalse.s L_0017
				L_0003: ldarg.0 
				L_0004: ldarg.0 
				L_0005: call Sunisoft.IrisSkin.SkinEngine::System.String get_SkinFile()
				L_000a: call Sunisoft.IrisSkin.SkinEngine::Void SetBuiltInSkinFile(System.String)
				L_000f: ldarg.0 
				L_0010: ldc.i4.1 
				L_0011: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_0016: ret 
				L_0017: ldarg.0 
				L_0018: ldc.i4.0 
				L_0019: stfld Sunisoft.IrisSkin.SkinEngine::Boolean builtIn
				L_001e: call Sunisoft.IrisSkin.SkinEngine::Boolean get_IsDesignModel()
				L_0023: brfalse.s L_002c
				L_0025: ldarg.0 
				L_0026: ldnull 
				L_0027: call Sunisoft.IrisSkin.SkinEngine::Void set_SkinStreamMain(System.IO.Stream)
				L_002c: ret 
			*/
			
			
			{
				if (builtIn)
				{
					this.SetBuiltInSkinFile (this.SkinFile);
					this.builtIn = true;
				}
				else
				{
					this.builtIn = false;
					if (((SkinEngine) ISkinEngine).IsDesignModel)
					{
						this.SkinStreamMain = ((Stream) null);
					}
				}
			}
			
			protected virtual void OnCurrentSkinChanged ()
			
			/*
				// Code Size: 534 Bytes
				.maxstack 6
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Font V_1, 
         System.Drawing.Graphics V_2, 
         System.Drawing.SizeF V_3, 
         System.Drawing.Size V_4)
				.try L_0137 to L_015c finally L_015c to L_0166
				L_0000: ldarg.0 
				L_0001: newobj System.Collections.Hashtable::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable bitmapList
				L_000b: ldarg.0 
				L_000c: newobj System.Collections.Hashtable::Void .ctor()
				L_0011: stfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0016: ldarg.0 
				L_0017: call Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
				L_001c: brfalse L_01f6
				L_0021: ldarg.0 
				L_0022: call Sunisoft.IrisSkin.SkinEngine::Void PrepareResources()
				L_0027: ldarg.0 
				L_0028: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_002d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0032: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_0037: stloc.0 
				L_0038: ldarg.0 
				L_0039: ldloc.0 
				L_003a: callvirt System.Drawing.Image::Int32 get_Height()
				L_003f: stfld Sunisoft.IrisSkin.SkinEngine::Int32 titleHeight
				L_0044: ldarg.0 
				L_0045: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_004f: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMLEFTBORDER()
				L_0054: stloc.0 
				L_0055: ldarg.0 
				L_0056: ldloc.0 
				L_0057: callvirt System.Drawing.Image::Int32 get_Width()
				L_005c: stfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_0061: ldarg.0 
				L_0062: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0067: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_006c: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMRIGHTBORDER()
				L_0071: stloc.0 
				L_0072: ldarg.0 
				L_0073: ldloc.0 
				L_0074: callvirt System.Drawing.Image::Int32 get_Width()
				L_0079: stfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_007e: ldarg.0 
				L_007f: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0084: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0089: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_FORMBOTTOMBORDER1()
				L_008e: stloc.0 
				L_008f: ldarg.0 
				L_0090: ldloc.0 
				L_0091: callvirt System.Drawing.Image::Int32 get_Height()
				L_0096: stfld Sunisoft.IrisSkin.SkinEngine::Int32 bottomBorderHeight
				L_009b: ldarg.0 
				L_009c: ldc.i4.0 
				L_009d: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00a2: ldarg.0 
				L_00a3: dup 
				L_00a4: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00a9: ldarg.0 
				L_00aa: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 leftBorderWidth
				L_00af: ldarg.0 
				L_00b0: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 rightBorderWidth
				L_00b5: add 
				L_00b6: add 
				L_00b7: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00bc: ldarg.0 
				L_00bd: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c2: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools get_Bools()
				L_00c7: ldfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEFIVESECT
				L_00cc: brfalse L_01a2
				L_00d1: ldarg.0 
				L_00d2: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00d7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00dc: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_00e1: stloc.0 
				L_00e2: ldarg.0 
				L_00e3: dup 
				L_00e4: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00e9: ldloc.0 
				L_00ea: callvirt System.Drawing.Image::Int32 get_Width()
				L_00ef: add 
				L_00f0: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_00f5: ldarg.0 
				L_00f6: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00fb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0100: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_0105: stloc.0 
				L_0106: ldarg.0 
				L_0107: dup 
				L_0108: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_010d: ldloc.0 
				L_010e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0113: add 
				L_0114: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_0119: ldarg.0 
				L_011a: call Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_011f: brtrue.s L_0129
				L_0121: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font x357f53120b135506()
				L_0126: stloc.1 
				L_0127: br.s L_0130
				L_0129: ldarg.0 
				L_012a: call Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_TitleFont()
				L_012f: stloc.1 
				L_0130: ldloc.0 
				L_0131: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0136: stloc.2 
				L_0137: ldarg.0 
				L_0138: ldloc.2 
				L_0139: ldstr "W..."
				L_013e: ldloc.1 
				L_013f: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_0144: stloc.3 
				L_0145: ldloca.s V_3
				L_0147: call System.Drawing.SizeF::System.Drawing.Size ToSize()
				L_014c: stloc.s V_4
				L_014e: ldloca.s V_4
				L_0150: call System.Drawing.Size::Int32 get_Width()
				L_0155: stfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_015a: leave.s L_0166
				L_015c: ldloc.2 
				L_015d: brfalse.s L_0165
				L_015f: ldloc.2 
				L_0160: callvirt System.IDisposable::Void Dispose()
				L_0165: endfinally 
				L_0166: ldarg.0 
				L_0167: dup 
				L_0168: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_016d: ldarg.0 
				L_016e: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 minTextWidth
				L_0173: ldarg.0 
				L_0174: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0179: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt get_Integers()
				L_017e: ldfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARICONPOSX
				L_0183: add 
				L_0184: ldc.i4.s 40
				L_0186: add 
				L_0187: add 
				L_0188: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_018d: ldarg.0 
				L_018e: ldarg.0 
				L_018f: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_0194: ldc.i4.s 100
				L_0196: call System.Math::Int32 Max(Int32, Int32)
				L_019b: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01a0: br.s L_01f6
				L_01a2: ldarg.0 
				L_01a3: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01a8: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_01ad: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR1()
				L_01b2: stloc.0 
				L_01b3: ldarg.0 
				L_01b4: ldloc.0 
				L_01b5: callvirt System.Drawing.Image::Int32 get_Width()
				L_01ba: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01bf: ldarg.0 
				L_01c0: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01c5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_01ca: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TITLEBAR3()
				L_01cf: stloc.0 
				L_01d0: ldarg.0 
				L_01d1: dup 
				L_01d2: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01d7: ldloc.0 
				L_01d8: callvirt System.Drawing.Image::Int32 get_Width()
				L_01dd: add 
				L_01de: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01e3: ldarg.0 
				L_01e4: ldarg.0 
				L_01e5: ldfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01ea: ldc.i4.s 100
				L_01ec: call System.Math::Int32 Max(Int32, Int32)
				L_01f1: stfld Sunisoft.IrisSkin.SkinEngine::Int32 formMinWidth
				L_01f6: ldarg.0 
				L_01f7: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
				L_01fc: brfalse.s L_0215
				L_01fe: ldarg.0 
				L_01ff: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.SkinChanged CurrentSkinChanged
				L_0204: ldarg.0 
				L_0205: ldarg.0 
				L_0206: call Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
				L_020b: newobj Sunisoft.IrisSkin.SkinChangedEventArgs::Void .ctor(Boolean)
				L_0210: callvirt Sunisoft.IrisSkin.SkinChanged::Void Invoke(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0215: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				Font font1;
				this.bitmapList = new Hashtable ();
				this.brushList = new Hashtable ();
				if (((SkinEngine) this).RealActive)
				{
					this.PrepareResources ();
					bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_TITLEBAR1;
					this.titleHeight = bitmap1.Height;
					bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_FORMLEFTBORDER;
					this.leftBorderWidth = bitmap1.Width;
					bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_FORMRIGHTBORDER;
					this.rightBorderWidth = bitmap1.Width;
					bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_FORMBOTTOMBORDER1;
					this.bottomBorderHeight = bitmap1.Height;
					this.formMinWidth = 0;
					this.formMinWidth += (this.leftBorderWidth + this.rightBorderWidth);
					if (! ((SkinBools) ((Sunisoft.IrisSkin.Res) this.Res).Bools).SKIN2_TITLEFIVESECT)
					{
						bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_TITLEBAR1;
						this.formMinWidth = bitmap1.Width;
						bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_TITLEBAR3;
						this.formMinWidth += bitmap1.Width;
						this.formMinWidth = Math.Max (this.formMinWidth, 100);
					}
					else
					{
						bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_TITLEBAR1;
						this.formMinWidth += bitmap1.Width;
						bitmap1 = ((SkinBitmaps) ((Sunisoft.IrisSkin.Res) this.Res).Bitmaps).SKIN2_TITLEBAR3;
						this.formMinWidth += bitmap1.Width;
						if (this.TitleFont == null)
						{
							font1 = x448fd9ab43628c71.x357f53120b135506 ();
						}
						else
						{
							font1 = this.TitleFont;
						}
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.minTextWidth = graphics1.MeasureString ("W...", font1).ToSize ().Width;
						}
						this.formMinWidth += ((int) ((this.minTextWidth + ((SkinInt) ((Sunisoft.IrisSkin.Res) this.Res).Integers).SKIN2_TITLEBARICONPOSX) + 40));
						this.formMinWidth = Math.Max (this.formMinWidth, 100);
					}
				}
				if (this.CurrentSkinChanged != null)
				{
					this.CurrentSkinChanged (this, new SkinChangedEventArgs (((SkinEngine) this).RealActive));
				}
			}
			
			protected virtual void OnMainSkinStreamChanged (Stream stream)
			
			/*
				// Code Size: 62 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brtrue.s L_000c
				L_0003: ldarg.0 
				L_0004: ldc.i4.0 
				L_0005: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_000a: br.s L_0030
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0012: ldarg.1 
				L_0013: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x896404322349820a(System.IO.Stream)
				L_0018: ldarg.0 
				L_0019: ldarg.0 
				L_001a: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_001f: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_002a: and 
				L_002b: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_0030: ldarg.0 
				L_0031: ldarg.1 
				L_0032: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStreamMain
				L_0037: ldarg.0 
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnCurrentSkinChanged()
				L_003d: ret 
			*/
			
			
			{
				if (stream == null)
				{
					this.realActive = false;
				}
				else
				{
					((Ix7f0ebae1a2d30adf) this.reader).x896404322349820a = stream;
					this.realActive = (((Ix7f0ebae1a2d30adf) this.reader).xb591119eb9470315 && this.active);
				}
				this.skinStreamMain = stream;
				this.OnCurrentSkinChanged ();
			}
			
			protected virtual void OnSkinAllFormChanged ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void OnSkinFileChanged (string fileName)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.SkinEngine::Boolean get_BuiltIn()
				L_0006: brfalse.s L_0017
				L_0008: call Sunisoft.IrisSkin.SkinEngine::Boolean get_IsDesignModel()
				L_000d: brfalse.s L_0017
				L_000f: ldarg.0 
				L_0010: ldarg.1 
				L_0011: call Sunisoft.IrisSkin.SkinEngine::Void SetBuiltInSkinFile(System.String)
				L_0016: ret 
				L_0017: ldarg.0 
				L_0018: ldarg.1 
				L_0019: call Sunisoft.IrisSkin.SkinEngine::Void SetSkinFile(System.String)
				L_001e: ret 
			*/
			
			
			{
				if (this.BuiltIn && ((SkinEngine) ISkinEngine).IsDesignModel)
				{
					this.SetBuiltInSkinFile (fileName);
				}
				else
				{
					this.SetSkinFile (fileName);
				}
			}
			
			protected virtual void OnSkinStreamChanged (Stream skinStream)
			
			/*
				// Code Size: 55 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brtrue.s L_000c
				L_0003: ldarg.0 
				L_0004: ldc.i4.0 
				L_0005: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_000a: br.s L_0030
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_0012: ldarg.1 
				L_0013: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_x896404322349820a(System.IO.Stream)
				L_0018: ldarg.0 
				L_0019: ldarg.0 
				L_001a: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf reader
				L_001f: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_002a: and 
				L_002b: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_0030: ldarg.0 
				L_0031: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnCurrentSkinChanged()
				L_0036: ret 
			*/
			
			
			{
				if (skinStream == null)
				{
					this.realActive = false;
				}
				else
				{
					((Ix7f0ebae1a2d30adf) this.reader).x896404322349820a = skinStream;
					this.realActive = (((Ix7f0ebae1a2d30adf) this.reader).xb591119eb9470315 && this.active);
				}
				this.OnCurrentSkinChanged ();
			}
			
			private void PrepareResources ()
			
			/*
				// Code Size: 251 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res res
				L_0006: brfalse.s L_0013
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res res
				L_000e: callvirt Sunisoft.IrisSkin.Res::Void Dispose()
				L_0013: ldarg.0 
				L_0014: ldnull 
				L_0015: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res res
				L_001a: ldarg.0 
				L_001b: ldarg.0 
				L_001c: newobj Sunisoft.IrisSkin.Res::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0021: stfld Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res res
				L_0026: ldarg.0 
				L_0027: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_002c: ldsfld System.IntPtr::IntPtr Zero
				L_0031: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0036: brfalse.s L_0044
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_003e: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_0043: pop 
				L_0044: ldloca.s V_0
				L_0046: initobj Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH
				L_004c: ldarg.0 
				L_004d: ldstr "SKIN2_FORMCOLOR"
				L_0052: call Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0057: stloc.1 
				L_0058: ldloc.1 
				L_0059: ldc.i4 -16777216
				L_005e: and 
				L_005f: ldc.i4 -16777216
				L_0064: bne.un.s L_0073
				L_0066: ldloc.1 
				L_0067: ldc.i4 255
				L_006c: and 
				L_006d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetSysColor(Int32)
				L_0072: stloc.1 
				L_0073: ldloca.s V_0
				L_0075: ldloc.1 
				L_0076: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbColor
				L_007b: ldloca.s V_0
				L_007d: ldc.i4.0 
				L_007e: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbStyle
				L_0083: ldarg.0 
				L_0084: ldloca.s V_0
				L_0086: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateBrushIndirect(LOGBRUSH ByRef)
				L_008b: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr backColorBrush
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr controlBorderBrush
				L_0096: ldsfld System.IntPtr::IntPtr Zero
				L_009b: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_00a0: brfalse.s L_00ae
				L_00a2: ldarg.0 
				L_00a3: ldfld Sunisoft.IrisSkin.SkinEngine::IntPtr controlBorderBrush
				L_00a8: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_00ad: pop 
				L_00ae: ldloca.s V_0
				L_00b0: initobj Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH
				L_00b6: ldarg.0 
				L_00b7: ldstr "SKIN2_CONTROLBORDERCOLOR"
				L_00bc: call Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_00c1: stloc.1 
				L_00c2: ldloc.1 
				L_00c3: ldc.i4 -16777216
				L_00c8: and 
				L_00c9: ldc.i4 -16777216
				L_00ce: bne.un.s L_00dd
				L_00d0: ldloc.1 
				L_00d1: ldc.i4 255
				L_00d6: and 
				L_00d7: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetSysColor(Int32)
				L_00dc: stloc.1 
				L_00dd: ldloca.s V_0
				L_00df: ldloc.1 
				L_00e0: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbColor
				L_00e5: ldloca.s V_0
				L_00e7: ldc.i4.0 
				L_00e8: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbStyle
				L_00ed: ldarg.0 
				L_00ee: ldloca.s V_0
				L_00f0: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateBrushIndirect(LOGBRUSH ByRef)
				L_00f5: stfld Sunisoft.IrisSkin.SkinEngine::IntPtr controlBorderBrush
				L_00fa: ret 
			*/
			
			
			{
				if (this.res != null)
				{
					((Sunisoft.IrisSkin.Res) this.res).Dispose ();
				}
				this.res = ((IRes) null);
				this.res = new Sunisoft.IrisSkin.Res (this);
				if (this.backColorBrush != IntPtr.Zero)
				{
					bool b1 = x31775329b2a4ff52.DeleteObject (this.backColorBrush);
				}
				x1439a41cfa24189f.LOGBRUSH lOGBRUSH1 = new x1439a41cfa24189f.LOGBRUSH ();
				uint uInt32_1 = ((uint) this.GetInt ("SKIN2_FORMCOLOR"));
				if ((((int) uInt32_1) & -16777216) == -16777216)
				{
					uInt32_1 = ((uint) x61467fe65a98f20c.GetSysColor (((int) (((int) uInt32_1) & 255))));
				}
				lOGBRUSH1.lbColor = uInt32_1;
				lOGBRUSH1.lbStyle = uint.MinValue;
				this.backColorBrush = x31775329b2a4ff52.CreateBrushIndirect (ref lOGBRUSH1);
				if (this.controlBorderBrush != IntPtr.Zero)
				{
					bool b2 = x31775329b2a4ff52.DeleteObject (this.controlBorderBrush);
				}
				lOGBRUSH1 = new x1439a41cfa24189f.LOGBRUSH ();
				uInt32_1 = ((uint) this.GetInt ("SKIN2_CONTROLBORDERCOLOR"));
				if ((((int) uInt32_1) & -16777216) == -16777216)
				{
					uInt32_1 = ((uint) x61467fe65a98f20c.GetSysColor (((int) (((int) uInt32_1) & 255))));
				}
				lOGBRUSH1.lbColor = uInt32_1;
				lOGBRUSH1.lbStyle = uint.MinValue;
				this.controlBorderBrush = x31775329b2a4ff52.CreateBrushIndirect (ref lOGBRUSH1);
			}
			
			public void RemoveForm (Form form, bool includeControls)
			
			/*
				// Code Size: 106 Bytes
				.maxstack 4
				.locals (System.IntPtr V_0, 
         Sunisoft.IrisSkin.xd24df615efe9450e V_1)
				L_0000: ldarg.1 
				L_0001: brfalse.s L_000b
				L_0003: ldarg.1 
				L_0004: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0009: brfalse.s L_000c
				L_000b: ret 
				L_000c: ldarg.1 
				L_000d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0012: stloc.0 
				L_0013: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_0018: ldloc.0 
				L_0019: box System.IntPtr
				L_001e: callvirt System.Collections.Hashtable::Boolean Contains(System.Object)
				L_0023: brfalse.s L_0069
				L_0025: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_002a: ldloc.0 
				L_002b: box System.IntPtr
				L_0030: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0035: isinst Sunisoft.IrisSkin.xd24df615efe9450e
				L_003a: brfalse.s L_0069
				L_003c: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_0041: ldloc.0 
				L_0042: box System.IntPtr
				L_0047: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_004c: castclass Sunisoft.IrisSkin.xd24df615efe9450e
				L_0051: stloc.1 
				L_0052: ldloc.1 
				L_0053: ldarg.2 
				L_0054: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void x52b190e626f65140(Boolean)
				L_0059: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable windowList
				L_005e: ldloc.0 
				L_005f: box System.IntPtr
				L_0064: callvirt System.Collections.Hashtable::Void Remove(System.Object)
				L_0069: ret 
			*/
			
			
			{
				if ((form == null) || form.IsDisposed)
				{
					return;
				}
				IntPtr intPtr1 = form.Handle;
				if ((! SkinEngine.windowList.Contains (intPtr1)) || (! (SkinEngine.windowList[intPtr1] is xd24df615efe9450e)))
				{
					return;
				}
				xd24df615efe9450e xd24df615efe9450e1 = ((xd24df615efe9450e) SkinEngine.windowList[intPtr1]);
				xd24df615efe9450e1.x52b190e626f65140 (includeControls);
				SkinEngine.windowList.Remove (intPtr1);
			}
			
			public void ResetMainMenu (Form form)
			
			/*
				// Code Size: 36 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: brfalse.s L_000b
				L_0003: ldarg.1 
				L_0004: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0009: brfalse.s L_000c
				L_000b: ret 
				L_000c: ldarg.1 
				L_000d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0012: ldc.i4 8403
				L_0017: ldc.i4 8403
				L_001c: ldc.i4.0 
				L_001d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0022: pop 
				L_0023: ret 
			*/
			
			
			{
				if ((form != null) && (! form.IsDisposed))
				{
					IntPtr intPtr1 = x61467fe65a98f20c.SendMessage (form.Handle, 8403, 8403, uint.MinValue);
				}
			}
			
			public void SetBrush (string key, Brush b)
			
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.SkinEngine::System.Collections.Hashtable brushList
				L_0006: ldarg.1 
				L_0007: ldarg.2 
				L_0008: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_000d: ret 
			*/
			
			
			{
				this.brushList.Add (key, b);
			}
			
			private void SetBuiltInSkinFile (string file)
			
			/*
				// Code Size: 134 Bytes
				.maxstack 5
				.locals (System.IO.FileStream V_0, 
         System.IO.BinaryReader V_1)
				.try L_0026 to L_0082 catch System.Object L_0082 to L_0085
				L_0000: ldarg.1 
				L_0001: brfalse.s L_0010
				L_0003: ldarg.1 
				L_0004: ldstr ""
				L_0009: call System.String::Boolean op_Equality(System.String, System.String)
				L_000e: brfalse.s L_0026
				L_0010: ldarg.0 
				L_0011: ldnull 
				L_0012: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStreamMain
				L_0017: ldarg.0 
				L_0018: ldc.i4.0 
				L_0019: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_001e: ldarg.0 
				L_001f: ldarg.1 
				L_0020: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinFile
				L_0025: ret 
				L_0026: ldarg.0 
				L_0027: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf get_Reader()
				L_002c: ldarg.1 
				L_002d: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_xf716b51dec80747d(System.String)
				L_0032: ldarg.1 
				L_0033: ldc.i4.3 
				L_0034: ldc.i4.1 
				L_0035: ldc.i4.1 
				L_0036: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_003b: stloc.0 
				L_003c: ldloc.0 
				L_003d: newobj System.IO.BinaryReader::Void .ctor(System.IO.Stream)
				L_0042: stloc.1 
				L_0043: ldarg.0 
				L_0044: ldloc.1 
				L_0045: ldloc.0 
				L_0046: callvirt System.IO.Stream::Int64 get_Length()
				L_004b: conv.i4 
				L_004c: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_0051: newobj System.IO.MemoryStream::Void .ctor(Byte[])
				L_0056: stfld Sunisoft.IrisSkin.SkinEngine::System.IO.Stream skinStreamMain
				L_005b: ldloc.1 
				L_005c: callvirt System.IO.BinaryReader::Void Close()
				L_0061: ldarg.0 
				L_0062: ldarg.1 
				L_0063: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinFile
				L_0068: ldarg.0 
				L_0069: ldarg.0 
				L_006a: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf get_Reader()
				L_006f: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_0074: ldarg.0 
				L_0075: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_007a: and 
				L_007b: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_0080: leave.s L_0085
				L_0082: pop 
				L_0083: leave.s L_0085
				L_0085: ret 
			*/
			
			
			{
				FileStream fileStream1;
				BinaryReader binaryReader1;
				if ((file == null) || (file == ""))
				{
					this.skinStreamMain = ((Stream) null);
					this.realActive = false;
					this.skinFile = file;
				}
				else
				{
					try
					{
						((Ix7f0ebae1a2d30adf) ((SkinEngine) this).Reader).xf716b51dec80747d = file;
						fileStream1 = File.Open (file, FileMode.Open, FileAccess.Read, FileShare.Read);
						binaryReader1 = new BinaryReader (((Stream) fileStream1));
						this.skinStreamMain = ((Stream) new MemoryStream (binaryReader1.ReadBytes (((int) fileStream1.Length))));
						binaryReader1.Close ();
						this.skinFile = file;
						this.realActive = (((Ix7f0ebae1a2d30adf) ((SkinEngine) this).Reader).xb591119eb9470315 && this.active);
					}
					catch
					{
					}
				}
			}
			
			private void SetSkinFile (string file)
			
			/*
				// Code Size: 66 Bytes
				.maxstack 4
				.locals (System.Exception V_0)
				.try L_0000 to L_000e catch System.Exception L_000e to L_001c
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf get_Reader()
				L_0006: ldarg.1 
				L_0007: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Void set_xf716b51dec80747d(System.String)
				L_000c: leave.s L_001c
				L_000e: stloc.0 
				L_000f: ldloc.0 
				L_0010: callvirt System.Exception::System.String get_Message()
				L_0015: call System.Console::Void WriteLine(System.String)
				L_001a: leave.s L_001c
				L_001c: ldarg.0 
				L_001d: ldarg.1 
				L_001e: stfld Sunisoft.IrisSkin.SkinEngine::System.String skinFile
				L_0023: ldarg.0 
				L_0024: ldarg.0 
				L_0025: call Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.x7f0ebae1a2d30adf get_Reader()
				L_002a: callvirt Sunisoft.IrisSkin.x7f0ebae1a2d30adf::Boolean get_xb591119eb9470315()
				L_002f: ldarg.0 
				L_0030: ldfld Sunisoft.IrisSkin.SkinEngine::Boolean active
				L_0035: and 
				L_0036: stfld Sunisoft.IrisSkin.SkinEngine::Boolean realActive
				L_003b: ldarg.0 
				L_003c: callvirt Sunisoft.IrisSkin.SkinEngine::Void OnCurrentSkinChanged()
				L_0041: ret 
			*/
			
			
			{
				Exception exception1;
				try
				{
					((Ix7f0ebae1a2d30adf) ((SkinEngine) this).Reader).xf716b51dec80747d = file;
				}
				catch (Exception exception2)
				{
					exception1 = exception2;
					Console.WriteLine (exception1.Message);
				}
				this.skinFile = file;
				this.realActive = (((Ix7f0ebae1a2d30adf) ((SkinEngine) this).Reader).xb591119eb9470315 && this.active);
				this.OnCurrentSkinChanged ();
			}
			
			private void SkinFormHandleCreated (object sender, EventArgs e)
			
			/*
				// Code Size: 51 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Form V_0)
				L_0000: ldarg.1 
				L_0001: isinst System.Windows.Forms.Form
				L_0006: brfalse.s L_0032
				L_0008: ldarg.1 
				L_0009: castclass System.Windows.Forms.Form
				L_000e: stloc.0 
				L_000f: ldsfld Sunisoft.IrisSkin.SkinEngine::System.Collections.ArrayList SkinHandleList
				L_0014: ldloc.0 
				L_0015: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001a: box System.IntPtr
				L_001f: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0024: pop 
				L_0025: ldarg.0 
				L_0026: ldloc.0 
				L_0027: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_002c: ldc.i4.1 
				L_002d: call Sunisoft.IrisSkin.SkinEngine::Void DoAddWnd(IntPtr, Boolean)
				L_0032: ret 
			*/
			
			
			{
				if (! (sender is Form))
				{
					return;
				}
				Form form1 = ((Form) sender);
				int i1 = SkinEngine.SkinHandleList.Add (form1.Handle);
				this.DoAddWnd (form1.Handle, true);
			}
			
		#endregion
	}
	
}

