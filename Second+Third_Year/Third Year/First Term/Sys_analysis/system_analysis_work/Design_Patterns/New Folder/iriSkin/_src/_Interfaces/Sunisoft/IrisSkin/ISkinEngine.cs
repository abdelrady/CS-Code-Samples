//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.ComponentModel;
			using System.Drawing;
			using System.IO;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	public interface ISkinEngine : IComponent, IDisposable
	
	{
		
		#region Properties
		
			string __Build
			
			{
				get;
			}
			
			
			bool Active
			
			{
				get;
				set;
			}
			
			
			ISkinCollection AddtionalBuiltInSkins
			
			{
				get;
			}
			
			
			bool BuiltIn
			
			{
				get;
				set;
			}
			
			
			int DisableTag
			
			{
				get;
				set;
			}
			
			
			bool DrawFormCaption
			
			{
				get;
				set;
			}
			
			
			bool DrawFormIcon
			
			{
				get;
				set;
			}
			
			
			bool DrawLineForAcceptButton
			
			{
				get;
				set;
			}
			
			
			bool Enable3rdControl
			
			{
				get;
				set;
			}
			
			
			int FormCaptionPosX
			
			{
				get;
				set;
			}
			
			
			int FormCaptionPosY
			
			{
				get;
				set;
			}
			
			
			Font MenuFont
			
			{
				get;
				set;
			}
			
			
			Component Owner
			
			{
				get;
			}
			
			
			IRes Res
			
			{
				get;
			}
			
			
			string ResSysMenuClose
			
			{
				get;
				set;
			}
			
			
			string ResSysMenuMax
			
			{
				get;
				set;
			}
			
			
			string ResSysMenuMin
			
			{
				get;
				set;
			}
			
			
			string SerialNumber
			
			{
				get;
				set;
			}
			
			
			bool SkinAllForm
			
			{
				get;
				set;
			}
			
			
			bool SkinDialogs
			
			{
				get;
				set;
			}
			
			
			string SkinFile
			
			{
				get;
				set;
			}
			
			
			string SkinPassword
			
			{
				get;
				set;
			}
			
			
			bool SkinScrollBar
			
			{
				get;
				set;
			}
			
			
			Stream SkinStream
			
			{
				get;
				set;
			}
			
			
			Stream SkinStreamMain
			
			{
				get;
				set;
			}
			
			
			Font TitleFont
			
			{
				get;
				set;
			}
			
			
			string Version
			
			{
				get;
			}
			
		#endregion
		
		#region Events
		
			event SkinChanged CurrentSkinChanged;
		#endregion
		
		#region Methods
		
			void AddContextMenu (ContextMenu menu);
			void AddControl (Control control);
			void AddForm (Form form);
			void ApplyAdditionalBuiltInSkins (int count);
			void ApplyMainBuiltInSkin ();
			Bitmap GetBitmap (string key, int spitCount, int spitIndex);
			Bitmap GetBitmap (string key);
			bool GetBool (string key);
			Brush GetBrush (string key);
			Color GetColor (string key);
			int GetInt (string key);
			void RemoveForm (Form form, bool includeControls);
			void ResetMainMenu (Form form);
			void SetBrush (string key, Brush b);
		#endregion
	}
	
}

