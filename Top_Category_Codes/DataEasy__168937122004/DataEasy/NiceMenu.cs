/* *************************************** 
 *           NiceMenu.cs (v 1.1)
 *  --------------------------------------
 *  This is an improvement by Francesco Natali (fn.varie@libero.it)
 *  over an improvement by Sajith M 
 *  of the "Visual Studio .NET Menu Style" 
 *  by Carlos H. Perez that appeared on CodeProject 
 *  (http://www.codeproject.com)
 * ---------------------------------------
 *		     How to use it
 *  You have to add: 
 *		using Utility.NiceMenu;
 *  and after the "InitializeComponent()" code:
 * 		NiceMenu myNiceMenu = new NiceMenu();
 *		myNiceMenu.UpdateMenu(this.nameofyourmainmenu, new NiceMenuClickEvent(nameofyourclickfunction));
 * ---------------------------------------
 *  With only three lines of code your menu
 *    will be AUTOMATICALLY updated with 
 *       a new great .Net style menu!
 * ****************************************/

namespace Utility.NiceMenu
{
	using System;
	using System.Windows.Forms;
	using System.Drawing;
	using System.Drawing.Text;
	using System.Diagnostics;
	using System.Collections;

	/* ******************************************************
	 *   NiceMenuClickEvent(object sender, System.EventArgs e)
	 * ------------------------------------------------------
	 *	this is a delegate event that will be initializate with
	 *  the user function to handle the click event on the menu
	 * ******************************************************/
	public delegate void NiceMenuClickEvent(object sender, System.EventArgs e);
	/* ******************************************************
	 *  This is a simple example of a function 
	 *  to handle the click event:  
	 *  -----------------------------------------------------
	    public void myClickMenuEvent(object sender, System.EventArgs e)
		{
	  		if (typeof(NiceMenu).IsInstanceOfType(sender)) 
				{
					NiceMenu item = (NiceMenu)sender;
					MessageBox.Show(item.Text); //example
				}
		}
	 * ******************************************************/

	/// <summary>
	/// A great and free improvement menu class!
	/// </summary>
	public class NiceMenu : MenuItem 
	{
		/* If you want to add some incons in your menu 
		 * you have to:
		 * 1. add an imagelist control in your form
		 * 2. add your icons in your imagelist control
		 * 3. add in your menu items the index of the icon 
		 *    in the first two characters. For example:
		 *    00New
		 *    01Open
		 *    02Close
		 * 4. After the "NiceMenu myNiceMenu = new NiceMenu();" code
		 *    you have to add this simple line of code: 
		 *    myNiceMenu.imgMenu = nameofyourimagelist; 
		 * */
		/// <summary>
		/// Set "MenuImages" with the your ImageList to add icons in your menu.
		/// </summary>
		public ImageList MenuImages;

		// NiceMenu array to save the main menu item
		// so at runtime i can search an item and modify it
		public static NiceMenu[] myModifyNiceMenu = new NiceMenu[20];
		private static NiceMenu[] myModifyContextNiceMenu = new NiceMenu[20];
		private static int contModify = 0;
		private static int contModifyContext = 0;

		private static Color window;
		// Some useful properties to change the color of your menu
		private static Color backcolor;
		private static Color barcolor;
		private static Color selectioncolor;
		private static Color framecolor;
		
		private static int iconSize = SystemInformation.SmallIconSize.Width + 5;
		private static int itemHeight;
		private static bool doColorUpdate = false;
		private string shortcuttext = "";
		private Image icon   = null;
		private static int BITMAP_SIZE = 16;
		private static int STRIPE_WIDTH = iconSize + 5;
		
		public NiceMenu() : base() 
		{
			OwnerDraw = true; UpdateColors();
		}
		
		private NiceMenu(string name) : base(name) 
		{
			OwnerDraw = true; UpdateColors();
		}
		// public for the AddRecentFile function
		public NiceMenu(string name, EventHandler handler) : base(name, handler) 
		{
			OwnerDraw = true; UpdateColors();
		}

		private NiceMenu(string name, NiceMenu[] items) : base(name, items) 
		{
			OwnerDraw = true; UpdateColors();
		}

		private NiceMenu(string name, EventHandler handler, Shortcut shortcut) : base(name, handler, shortcut) 
		{
			OwnerDraw = true; UpdateColors();
		}

		private NiceMenu(MenuMerge mergeType, int mergeOrder, Shortcut shortcut, string name, EventHandler onClick, EventHandler onPopup, EventHandler onSelect, NiceMenu[] items) : base(mergeType, mergeOrder, shortcut, name, onClick, onPopup, onSelect, items) 
		{
			OwnerDraw = true; UpdateColors();
		}

		private NiceMenu(string name, Image img) : this(name) 
		{
			icon = img;
		}

		private NiceMenu(string name, EventHandler handler, Image img) : this(name, handler) 
		{
			icon = img;
		}
		
		private NiceMenu(string name, EventHandler handler, Shortcut shortcut, Image img) : this(name, handler, shortcut) 
		{
			icon = img;
		}
	
		// *********************************************************

		private Image Icon 
		{
			get 
			{ return icon; }
			set 			
			{ icon = value;	}
		}

		private string ShortcutText 
		{
			get 
			{ return shortcuttext; }
			set 
			{ shortcuttext = value;	}
		}

		public Color SelectionColor
		{
			get
			{ return selectioncolor; }
			set
			{ selectioncolor = value; }
		}

		public Color BackColor
		{
			get
			{ return backcolor; }
			set
			{ backcolor = value; }
		}

		public Color BarColor
		{
			get
			{ return barcolor; }
			set
			{ barcolor = value; }
		}

		public Color FrameColor
		{
			get
			{ return framecolor; }
			set
			{ framecolor = value; }
		}

		//************************************************************************

		private void UpdateColors() 
		{
			window = SystemColors.Window;
			backcolor  = SystemColors.ControlLightLight;
			barcolor = SystemColors.Control;
			selectioncolor  = SystemColors.Highlight;
			framecolor = SystemColors.Highlight;

			int wa = (int)window.A;
			int wr = (int)window.R;
			int wg = (int)window.G;
			int wb = (int)window.B;

			int mna = (int)backcolor.A;
			int mnr = (int)backcolor.R;
			int mng = (int)backcolor.G;
			int mnb = (int)backcolor.B;

			int sta = (int)barcolor.A;
			int str = (int)barcolor.R;
			int stg = (int)barcolor.G;
			int stb = (int)barcolor.B;

			int sla = (int)selectioncolor.A;
			int slr = (int)selectioncolor.R;
			int slg = (int)selectioncolor.G;
			int slb = (int)selectioncolor.B;

			backcolor = Color.FromArgb(wr-(((wr-mnr)*2)/5), wg-(((wg-mng)*2)/5), wb-(((wb-mnb)*2)/5));
			barcolor = Color.FromArgb(wr-(((wr-str)*4)/5), wg-(((wg-stg)*4)/5), wb-(((wb-stb)*4)/5));
			selectioncolor = Color.FromArgb(wr-(((wr-slr)*2)/5), wg-(((wg-slg)*2)/5), wb-(((wb-slb)*2)/5));
		}

		private static void UpdateMenuColors() 
		{            
			doColorUpdate = true;
		}

		private void DoUpdateMenuColors() 
		{
			UpdateColors();			
			doColorUpdate = false;
		}

		protected override void OnMeasureItem(MeasureItemEventArgs e) 
		{
			base.OnMeasureItem(e);
			
			if (Shortcut != Shortcut.None) 
			{
				string text = "";
				int    key  = (int)Shortcut;
				int    ch   = key & 0xFF;
				if (((int)Keys.Control & key) > 0) text += "Ctrl+";
				if (((int)Keys.Shift & key) > 0) text += "Shift+";
				if (((int)Keys.Alt & key) > 0) text += "Alt+";
				
				if (ch >= (int)Shortcut.F1 && ch <= (int)Shortcut.F12)
					text += "F" + (ch - (int)Shortcut.F1 + 1);
				else 
				{
					if ( Shortcut == Shortcut.Del) 
					{
						text += "Del";
					}
					else 
					{
						text += (char)ch;
					}
				}
				shortcuttext = text;
			} 
			
			if (Text == "-") 
			{
				e.ItemHeight = 8;
				e.ItemWidth  = 4;
				return;
			}
				
			bool topLevel = Parent == Parent.GetMainMenu();
			string tempShortcutText = shortcuttext;
			if ( topLevel ) 
			{
				tempShortcutText = "";
			}
			int textwidth = (int)(e.Graphics.MeasureString(Text + tempShortcutText, SystemInformation.MenuFont).Width);
			int extraHeight = 4;
			e.ItemHeight  = SystemInformation.MenuHeight + extraHeight;
			if ( topLevel )
				e.ItemWidth  = textwidth - 5; 
			else
				e.ItemWidth   = Math.Max(160, textwidth + 50);

			itemHeight = e.ItemHeight;
		}
		
		protected override void OnDrawItem(DrawItemEventArgs e) 
		{
			if ( doColorUpdate) 
			{
				DoUpdateMenuColors();
			}
			
			base.OnDrawItem(e);

			Graphics  g      = e.Graphics;
			Rectangle bounds = e.Bounds;
			bool selected = (e.State & DrawItemState.Selected) > 0;
			bool toplevel = (Parent == Parent.GetMainMenu());
			bool hasicon  = Icon != null;
			bool enabled = Enabled;
			
			DrawBackground(g, bounds, e.State, toplevel, hasicon, enabled);
			if (hasicon)
				DrawIcon(g, Icon, bounds, selected, Enabled, Checked);
			else
			{
				if (Checked)
					DrawCheckmark(g, bounds, selected);
				if (RadioCheck)
					DrawRadioCheckmark(g, bounds, selected);
			}
			
			if (Text == "-") 
			{ DrawSeparator(g, bounds);	} 
			else 
			{ DrawMenuText(g, bounds, Text, shortcuttext, Enabled, toplevel, e.State); }
		}

		/* ******************************
		 *		DrawRadioCheckmark
		 * ******************************/
		private void DrawRadioCheckmark(Graphics g, Rectangle bounds, bool selected) 
		{
			int checkTop = bounds.Top + (itemHeight - BITMAP_SIZE)/2;
			int checkLeft = bounds.Left + ( STRIPE_WIDTH - BITMAP_SIZE)/2;
			ControlPaint.DrawMenuGlyph(g, new Rectangle(checkLeft, checkTop, BITMAP_SIZE, BITMAP_SIZE), MenuGlyph.Bullet);
			g.DrawRectangle(new Pen(framecolor), checkLeft-1, checkTop-1, BITMAP_SIZE+1, BITMAP_SIZE+1);
		}
		private void DrawCheckmark(Graphics g, Rectangle bounds, bool selected) 
		{
			int checkTop = bounds.Top + (itemHeight - BITMAP_SIZE)/2;
			int checkLeft = bounds.Left + ( STRIPE_WIDTH - BITMAP_SIZE)/2;
			ControlPaint.DrawMenuGlyph(g, new Rectangle(checkLeft, checkTop, BITMAP_SIZE, BITMAP_SIZE), MenuGlyph.Checkmark);
			g.DrawRectangle(new Pen(framecolor), checkLeft-1, checkTop-1, BITMAP_SIZE+1, BITMAP_SIZE+1);
		}
		private void DrawIcon(Graphics g, Image icon, Rectangle bounds, bool selected, bool enabled, bool ischecked) 
		{
			int iconTop = bounds.Top + (itemHeight - BITMAP_SIZE)/2;
			int iconLeft = bounds.Left + (STRIPE_WIDTH - BITMAP_SIZE)/2;
			if (enabled) 
			{
				if (selected) 
				{
					ControlPaint.DrawImageDisabled(g, icon, iconLeft + 1, iconTop, Color.Black);
					g.DrawImage(icon, iconLeft, iconTop-1);
				} 
				else 
				{
					g.DrawImage(icon, iconLeft + 1, iconTop);
				}
			} 
			else 
			{
				ControlPaint.DrawImageDisabled(g, icon, iconLeft + 1, iconTop, SystemColors.HighlightText);
			}
		}
	
		private void DrawSeparator(Graphics g, Rectangle bounds) 
		{
			int y = bounds.Y + bounds.Height / 2;
			g.DrawLine(new Pen(SystemColors.ControlDark), bounds.X + iconSize + 7, y, bounds.X + bounds.Width - 2, y);
		}
		
		private void DrawBackground(Graphics g, Rectangle bounds, DrawItemState state, bool toplevel, bool hasicon, bool enabled) 
		{
			bool selected = (state & DrawItemState.Selected) > 0;
			
			if (selected || ((state & DrawItemState.HotLight) > 0)) 
			{
				if (toplevel && selected) 
				{
					bounds.Inflate(-1, 0);
					g.FillRectangle(new SolidBrush(barcolor), bounds);
					ControlPaint.DrawBorder3D(g, bounds.Left, bounds.Top, bounds.Width, bounds.Height, Border3DStyle.Flat, Border3DSide.Top | Border3DSide.Left | Border3DSide.Right);
				} 
				else 
				{
					if ( enabled ) 
					{
						g.FillRectangle(new SolidBrush(selectioncolor), bounds);
						g.DrawRectangle(new Pen(framecolor), bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1);
					}
					else 
					{
						g.FillRectangle(new SolidBrush(barcolor), bounds);
						bounds.X += STRIPE_WIDTH;
						bounds.Width -= STRIPE_WIDTH;
						g.FillRectangle(new SolidBrush(backcolor), bounds);
					}
				}
			} 
			else 
			{
				if (!toplevel) 
				{
					g.FillRectangle(new SolidBrush(barcolor), bounds);
					bounds.X += STRIPE_WIDTH;
					bounds.Width -= STRIPE_WIDTH;
					g.FillRectangle(new SolidBrush(backcolor), bounds);
				} 
				else 
				{
					g.FillRectangle(SystemBrushes.Control, bounds);
				}
			}
		}

		private void DrawMenuText(Graphics g, Rectangle bounds, string text, string shortcut, bool enabled, bool toplevel, DrawItemState state )	
		{
			StringFormat stringformat = new StringFormat();
			stringformat.HotkeyPrefix = ((state & DrawItemState.NoAccelerator) > 0) ? HotkeyPrefix.Hide : HotkeyPrefix.Show;
		
			if ( toplevel ) 
			{
				int index = text.IndexOf("&");
				if ( index != -1 ) 
				{
					text = text.Remove(index,1);
				}
			}
			
			int textwidth = (int)(g.MeasureString(text, SystemInformation.MenuFont).Width);
			int x = toplevel ? bounds.Left + (bounds.Width - textwidth) / 2: bounds.Left + iconSize + 10;
			int topGap = 4;
			if ( toplevel ) topGap = 2;
			int y = bounds.Top + topGap;
			Brush brush = null;
			
			if (!enabled)
				brush = new SolidBrush(SystemColors.GrayText);
			else 
				brush = new SolidBrush(SystemColors.MenuText);
			
			g.DrawString(text, SystemInformation.MenuFont, brush, x, y, stringformat);

			if ( !toplevel ) 
			{
				stringformat.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
				g.DrawString(shortcut, SystemInformation.MenuFont, brush, bounds.Width - 10 , bounds.Top + topGap, stringformat);
			}
		}

		/* ******************************************************
		 *		UpdateMenu(MainMenu yourOldMenu)
		 *		UpdateMenu(ContextMenu yourOldMenu)
		 * ------------------------------------------------------
		 *		this function will update the user old menu
		 * ******************************************************/
		/// <summary>
		/// this function will update your Main Menu.
		/// </summary>
		public void UpdateMenu(MainMenu yourOldMenu, NiceMenuClickEvent yourClickFunction)
		{
			IList myMenuList = new Menu.MenuItemCollection(yourOldMenu);
			BuildMenuTree(myMenuList, yourOldMenu, yourClickFunction);
		}
		/// <summary>
		/// this function will update your Context Menu.
		/// </summary>
		public void UpdateMenu(ContextMenu yourOldMenu, NiceMenuClickEvent yourClickFunction)
		{
			IList myMenuList = new Menu.MenuItemCollection(yourOldMenu);
			BuildMenuTree(myMenuList, yourOldMenu, yourClickFunction);
		}

		/* ***********************************************************
		 *		BuildMenuTree (IList myMenu, MenuItem parentMenu)
		 * -----------------------------------------------------------
		 *		build the new submenu item 
		 * ***********************************************************/
		private void BuildMenuTree(IList myMenu, MenuItem parentMenu, NiceMenuClickEvent yourClickFunction)
		{
			foreach (MenuItem myMenuItem in myMenu) 
			{
				// Declaration
				NiceMenu newSubMenu;

				string IndexImage = "";
				bool AddMenuImage = false;
				
				/* If in the first two characters of the menu item text 
				 * there is a number I set AddMenuImage = true and the 
				 * IndexImage to get the icon in the image list control. */
				if (myMenuItem.Text.Length > 2)
				{
					IndexImage = myMenuItem.Text.Substring(0,2);
					if (Char.IsNumber(IndexImage,1) == true)
					{
						AddMenuImage = true;
						// I have to delete first two characters
						myMenuItem.Text = myMenuItem.Text.Substring(2);
					}
				}
				if (AddMenuImage == true)
					newSubMenu = new NiceMenu(myMenuItem.Text, new EventHandler(yourClickFunction), myMenuItem.Shortcut, MenuImages.Images[Convert.ToInt32(IndexImage)]);
				else
					newSubMenu = new NiceMenu(myMenuItem.Text, new EventHandler(yourClickFunction), myMenuItem.Shortcut);	
				// I add the new menu item to its parent
				parentMenu.MenuItems.Add(newSubMenu);
				// Checked 
				if (myMenuItem.Checked == true) newSubMenu.Checked = true;
				// RadioCheck 
				if (myMenuItem.RadioCheck == true) 
					if (myMenuItem.Checked == true) newSubMenu.RadioCheck = true;
				// DefaultItem 
				if (myMenuItem.DefaultItem == true) newSubMenu.DefaultItem = true;
				// Enabled
				if (myMenuItem.Enabled == false) newSubMenu.Enabled = false;
				// If this menu item contains child menu items
				if (myMenuItem.IsParent == true)
				{
					IList mySubMenu = new Menu.MenuItemCollection(myMenuItem);
					BuildMenuTree(mySubMenu, newSubMenu, yourClickFunction);
				}
			}
		}

		/* ***********************************************************
		 *	BuildMenuTree (IList myMenu, MainMenu parentMenu)
		 *  BuildMenuTree (IList myMenu, ContextMenu parentMenu, NiceMenuClickEvent yourClickFunction)
		 * -----------------------------------------------------------
		 *  build the new main menus and delete the old ones
		 * ***********************************************************/
		private void BuildMenuTree(IList myMenu, MainMenu parentMenu, NiceMenuClickEvent yourClickFunction)
		{
			int numOldMenu = myMenu.Count;

			foreach (MenuItem myMenuItem in myMenu) 
			{
				NiceMenu newMainMenu = new NiceMenu(myMenuItem.Text);
				parentMenu.MenuItems.Add(newMainMenu);
				
				if (myModifyNiceMenu[contModify] == null)
				{
					myModifyNiceMenu[contModify] = newMainMenu;
					contModify ++;
				}

				if (myMenuItem.IsParent == true)
				{
					IList mySubMenu = new Menu.MenuItemCollection(myMenuItem);
					BuildMenuTree(mySubMenu, newMainMenu, yourClickFunction);
				}
			}
			// Now I have to delete the old menus
			for (int i=0;i<numOldMenu;i++) 
			{   parentMenu.MenuItems.RemoveAt(0);   }
		}
		
		/* ****************************************************
		 *	With the context menu I need the yourClickFunction
		 *	because also the main menu shall be clickable !       
		 * ****************************************************/
		private void BuildMenuTree(IList myMenu, ContextMenu parentMenu, NiceMenuClickEvent yourClickFunction)
		{
			int numOldMenu = myMenu.Count;

			foreach (MenuItem myMenuItem in myMenu) 
			{
				// Declaration
				NiceMenu newMainMenu;

				string IndexImage = "";
				bool AddMenuImage = false;
				
				/* If in the first two characters of the menu item text 
				 * there is a number I set AddMenuImage = true and the 
				 * IndexImage to get the icon in the image list control. */
				if (myMenuItem.Text.Length > 2)
				{
					IndexImage = myMenuItem.Text.Substring(0,2);
					if (Char.IsNumber(IndexImage,1) == true)
					{
						AddMenuImage = true;
						// I have to delete first two characters
						myMenuItem.Text = myMenuItem.Text.Substring(2);
					}
				}
				if (AddMenuImage == true)
					newMainMenu = new NiceMenu(myMenuItem.Text, new EventHandler(yourClickFunction), myMenuItem.Shortcut, MenuImages.Images[Convert.ToInt32(IndexImage)]);
				else
					newMainMenu = new NiceMenu(myMenuItem.Text, new EventHandler(yourClickFunction), myMenuItem.Shortcut);	

				parentMenu.MenuItems.Add(newMainMenu);

				if (myModifyContextNiceMenu[contModifyContext] == null)
				{
					myModifyContextNiceMenu[contModifyContext] = newMainMenu;
					contModifyContext ++;
				}

				if (myMenuItem.IsParent == true)
				{
					IList mySubMenu = new Menu.MenuItemCollection(myMenuItem);
					BuildMenuTree(mySubMenu, newMainMenu, yourClickFunction);
				}
			}
			// Now I have to delete the old menus
			for (int i=0;i<numOldMenu;i++) 
			{   parentMenu.MenuItems.RemoveAt(0);   }
		}
		
		/* ****************************************************
		 *	I need a search function to modify a NiceMenu item 
		 *  at runtime
		 * ****************************************************/
		public NiceMenu SearchNiceMenuItem(string NiceMenuText)
		{
			contModify = 0;
		repeat:
			IList myMenuList = new Menu.MenuItemCollection(myModifyNiceMenu[contModify]);
			foreach (NiceMenu myMenuItem in myMenuList) 
			{
				// ---------------------------------------
				if (myMenuItem.Text == NiceMenuText)
				{
					return myMenuItem; 
				}
				// ---------------------------------------
				if (myMenuItem.IsParent == true)
				{
					IList myMenuList2 = new Menu.MenuItemCollection(myMenuItem);
					foreach (NiceMenu myMenuItem2 in myMenuList2) 
					{
						// -------------------------------- 
						if (myMenuItem2.Text == NiceMenuText)
						{
							contModify++;
							return myMenuItem2;
						}
					}
				}
			}
			contModify++;
			goto repeat;
		}

		/* ****************************************************
		 *	I need a search function to modify a NiceMenu item 
		 *  at runtime (for Context menu)
		 * ****************************************************/
		public NiceMenu SearchContextNiceMenuItem(string ContextNiceMenuText)
		{
			contModifyContext = 0;
			repeat:
			// ---------------------------------------
				if (myModifyContextNiceMenu[contModifyContext].Text 
					== ContextNiceMenuText)
				{
					return myModifyContextNiceMenu[contModifyContext];
				}
			// --------------------------------------------
			IList myMenuList = new Menu.MenuItemCollection(myModifyContextNiceMenu[contModifyContext]);
			foreach (NiceMenu myMenuItem in myMenuList) 
			{
				if (myMenuItem.Text == ContextNiceMenuText)
				{
					contModifyContext++;
					return myMenuItem;
				}
			}
			contModifyContext++;
			goto repeat;
		}
	}
}