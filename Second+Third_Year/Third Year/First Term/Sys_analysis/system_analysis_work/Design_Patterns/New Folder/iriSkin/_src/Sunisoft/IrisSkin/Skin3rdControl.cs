//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Collections;
			using System;
			using System.Windows.Forms.Layout;
			using System.Windows.Forms;
			
			
		#endregion
		
	public class Skin3rdControl : NativeWindow, IDisposable
	
	{
		
		#region Fields
			protected Control Ctrl;
			protected ISkinEngine Engine;
			protected Hashtable skinControlList;
			private bool x230e512478b11e00;
		#endregion
		
		#region Constructors
		
			public Skin3rdControl (Control control, ISkinEngine engine)
			/*
				// Code Size: 51 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.Skin3rdControl::Boolean x230e512478b11e00
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_000d: ldarg.0 
				L_000e: newobj System.Collections.Hashtable::Void .ctor()
				L_0013: stfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: stfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_001f: ldarg.0 
				L_0020: ldarg.2 
				L_0021: stfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
				L_0026: ldarg.0 
				L_0027: callvirt Sunisoft.IrisSkin.Skin3rdControl::Void DoInit()
				L_002c: ldarg.0 
				L_002d: call Sunisoft.IrisSkin.Skin3rdControl::Void x172fd1e80a81620d()
				L_0032: ret 
			*/
		#endregion
		
		#region Properties
		
			protected bool CanPaint
			
			{
				get
				
				/*
					// Code Size: 158 Bytes
					.maxstack 4
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Skin3rdControl::Boolean x230e512478b11e00
					L_0006: brtrue.s L_000a
					L_0008: ldc.i4.0 
					L_0009: ret 
					L_000a: ldarg.0 
					L_000b: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
					L_0010: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
					L_0015: brfalse.s L_0019
					L_0017: ldc.i4.0 
					L_0018: ret 
					L_0019: ldarg.0 
					L_001a: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
					L_001f: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_0024: brtrue.s L_0028
					L_0026: ldc.i4.0 
					L_0027: ret 
					L_0028: ldarg.0 
					L_0029: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
					L_002e: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0033: isinst System.Int32
					L_0038: brfalse.s L_005c
					L_003a: ldarg.0 
					L_003b: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
					L_0040: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0045: unbox System.Int32
					L_004a: ldind.i4 
					L_004b: ldarg.0 
					L_004c: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
					L_0051: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0056: bne.un.s L_005a
					L_0058: ldc.i4.0 
					L_0059: ret 
					L_005a: ldc.i4.1 
					L_005b: ret 
					L_005c: ldarg.0 
					L_005d: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
					L_0062: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0067: isinst System.String
					L_006c: brfalse.s L_009c
					L_006e: ldarg.0 
					L_006f: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
					L_0074: callvirt System.Windows.Forms.Control::System.Object get_Tag()
					L_0079: castclass System.String
					L_007e: ldarg.0 
					L_007f: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
					L_0084: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_DisableTag()
					L_0089: stloc.0 
					L_008a: ldloca.s V_0
					L_008c: call System.Int32::System.String ToString()
					L_0091: call System.String::Boolean op_Equality(System.String, System.String)
					L_0096: brfalse.s L_009a
					L_0098: ldc.i4.0 
					L_0099: ret 
					L_009a: ldc.i4.1 
					L_009b: ret 
					L_009c: ldc.i4.1 
					L_009d: ret 
				*/
				
				{
					if (! this.x230e512478b11e00)
					{
						return false;
					}
					if (this.Ctrl.IsDisposed)
					{
						return false;
					}
					if (! ((SkinEngine) this.Engine).RealActive)
					{
						return false;
					}
					if (this.Ctrl.Tag is int)
					{
						if (((int) this.Ctrl.Tag) != ((SkinEngine) this.Engine).DisableTag)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
					if (! (this.Ctrl.Tag is string))
					{
						return true;
					}
					int i1 = ((SkinEngine) this.Engine).DisableTag;
					if (((string) this.Ctrl.Tag) != i1.ToString ())
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			
		#endregion
		
		#region Methods
		
			protected virtual void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 2 Bytes
				.maxstack 9
				L_0000: ldc.i4.1 
				L_0001: ret 
			*/
			
			
			{
				return true;
			}
			
			public virtual void Dispose ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void DoInit ()
			
			/*
				// Code Size: 41 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
				L_0006: ldarg.0 
				L_0007: ldftn Sunisoft.IrisSkin.Skin3rdControl::Void x8c06ad1b432b98eb(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_000d: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_0017: ldarg.0 
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_001e: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0023: call System.Windows.Forms.NativeWindow::Void AssignHandle(IntPtr)
				L_0028: ret 
			*/
			
			
			{
				((SkinEngine) this.Engine).CurrentSkinChanged += new SkinChanged (this.x8c06ad1b432b98eb);
				base.AssignHandle (this.Ctrl.Handle);
			}
			
			protected virtual void DoUnInit ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected virtual void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 26 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.Skin3rdControl::Boolean get_CanPaint()
				L_0006: brfalse.s L_000e
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.Skin3rdControl::Void xb1ee1b6293236c5f()
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_0014: callvirt System.Windows.Forms.Control::Void Refresh()
				L_0019: ret 
			*/
			
			
			{
				if (this.CanPaint)
				{
					this.xb1ee1b6293236c5f ();
				}
				this.Ctrl.Refresh ();
			}
			
			protected virtual void PaintControl ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 40 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.Skin3rdControl::Boolean get_CanPaint()
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: callvirt Sunisoft.IrisSkin.Skin3rdControl::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_000f: brfalse.s L_0018
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: callvirt Sunisoft.IrisSkin.Skin3rdControl::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldarg.1 
				L_0022: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0027: ret 
			*/
			
			
			{
				if (! this.CanPaint)
				{
					base.WndProc (ref m);
				}
				else
				{
					if (this.BeforeWndProc (ref m))
					{
						base.WndProc (ref m);
					}
					this.AfterWndProc (ref m);
				}
			}
			
			private void x172fd1e80a81620d ()
			
			/*
				// Code Size: 276 Bytes
				.maxstack 5
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_0051 to L_008b finally L_008b to L_00a0
				.try L_00a8 to L_00fe finally L_00fe to L_0113
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_0006: ldarg.0 
				L_0007: ldftn Sunisoft.IrisSkin.Skin3rdControl::Void xd34eabd7bd15b71a(System.Object, System.Windows.Forms.ControlEventArgs)
				L_000d: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_0012: callvirt System.Windows.Forms.Control::Void add_ControlAdded(System.Windows.Forms.ControlEventHandler)
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_001d: ldarg.0 
				L_001e: ldftn Sunisoft.IrisSkin.Skin3rdControl::Void xf8f5e344dcfab3e8(System.Object, System.Windows.Forms.ControlEventArgs)
				L_0024: newobj System.Windows.Forms.ControlEventHandler::Void .ctor(System.Object, IntPtr)
				L_0029: callvirt System.Windows.Forms.Control::Void add_ControlRemoved(System.Windows.Forms.ControlEventHandler)
				L_002e: ldarg.0 
				L_002f: call Sunisoft.IrisSkin.Skin3rdControl::Boolean get_CanPaint()
				L_0034: brfalse L_0113
				L_0039: newobj System.Collections.ArrayList::Void .ctor()
				L_003e: stloc.0 
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_0045: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_004a: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_004f: stloc.s V_4
				L_0051: br.s L_0080
				L_0053: ldloc.s V_4
				L_0055: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_005a: castclass System.Windows.Forms.Control
				L_005f: stloc.1 
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_0066: ldloc.1 
				L_0067: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_006c: box System.IntPtr
				L_0071: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0076: brtrue.s L_0080
				L_0078: ldloc.0 
				L_0079: ldloc.1 
				L_007a: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_007f: pop 
				L_0080: ldloc.s V_4
				L_0082: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0087: brtrue.s L_0053
				L_0089: leave.s L_00a0
				L_008b: ldloc.s V_4
				L_008d: isinst System.IDisposable
				L_0092: stloc.s V_5
				L_0094: ldloc.s V_5
				L_0096: brfalse.s L_009f
				L_0098: ldloc.s V_5
				L_009a: callvirt System.IDisposable::Void Dispose()
				L_009f: endfinally 
				L_00a0: ldloc.0 
				L_00a1: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_00a6: stloc.s V_4
				L_00a8: br.s L_00f3
				L_00aa: ldloc.s V_4
				L_00ac: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00b1: castclass System.Windows.Forms.Control
				L_00b6: stloc.2 
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_00bd: ldloc.2 
				L_00be: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00c3: box System.IntPtr
				L_00c8: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_00cd: brtrue.s L_00f3
				L_00cf: ldloc.2 
				L_00d0: ldarg.0 
				L_00d1: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
				L_00d6: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00db: stloc.3 
				L_00dc: ldarg.0 
				L_00dd: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_00e2: ldloc.2 
				L_00e3: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00e8: box System.IntPtr
				L_00ed: ldloc.3 
				L_00ee: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_00f3: ldloc.s V_4
				L_00f5: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00fa: brtrue.s L_00aa
				L_00fc: leave.s L_0113
				L_00fe: ldloc.s V_4
				L_0100: isinst System.IDisposable
				L_0105: stloc.s V_5
				L_0107: ldloc.s V_5
				L_0109: brfalse.s L_0112
				L_010b: ldloc.s V_5
				L_010d: callvirt System.IDisposable::Void Dispose()
				L_0112: endfinally 
				L_0113: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				this.Ctrl.ControlAdded += new ControlEventHandler (this.xd34eabd7bd15b71a);
				this.Ctrl.ControlRemoved += new ControlEventHandler (this.xf8f5e344dcfab3e8);
				if (! this.CanPaint)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in this.Ctrl.Controls)
				{
					if (! this.skinControlList.ContainsKey (control1.Handle))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! this.skinControlList.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, this.Engine);
						this.skinControlList.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			internal void x52b190e626f65140 ()
			
			/*
				// Code Size: 95 Bytes
				.maxstack 5
				.locals (System.Object V_0, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0011 to L_0039 finally L_0039 to L_004a
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_0006: callvirt System.Collections.Hashtable::System.Collections.ICollection get_Values()
				L_000b: callvirt System.Collections.IEnumerable::System.Collections.IEnumerator GetEnumerator()
				L_0010: stloc.2 
				L_0011: br.s L_002f
				L_0013: ldloc.2 
				L_0014: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0019: stloc.0 
				L_001a: ldloc.0 
				L_001b: isinst Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_0020: brfalse.s L_002f
				L_0022: ldloc.0 
				L_0023: castclass Sunisoft.IrisSkin.xbd3f2493841f18a1
				L_0028: stloc.1 
				L_0029: ldloc.1 
				L_002a: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void x52b190e626f65140()
				L_002f: ldloc.2 
				L_0030: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0035: brtrue.s L_0013
				L_0037: leave.s L_004a
				L_0039: ldloc.2 
				L_003a: isinst System.IDisposable
				L_003f: stloc.3 
				L_0040: ldloc.3 
				L_0041: brfalse.s L_0049
				L_0043: ldloc.3 
				L_0044: callvirt System.IDisposable::Void Dispose()
				L_0049: endfinally 
				L_004a: ldarg.0 
				L_004b: ldc.i4.0 
				L_004c: stfld Sunisoft.IrisSkin.Skin3rdControl::Boolean x230e512478b11e00
				L_0051: ldarg.0 
				L_0052: ldnull 
				L_0053: ldc.i4.0 
				L_0054: newobj Sunisoft.IrisSkin.SkinChangedEventArgs::Void .ctor(Boolean)
				L_0059: callvirt Sunisoft.IrisSkin.Skin3rdControl::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_005e: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				foreach (object object1 in this.skinControlList.Values)
				{
					if (object1 is xbd3f2493841f18a1)
					{
						xbd3f2493841f18a1_1 = ((xbd3f2493841f18a1) object1);
						xbd3f2493841f18a1_1.x52b190e626f65140 ();
					}
				}
				this.x230e512478b11e00 = false;
				this.OnCurrentSkinChanged (null, new SkinChangedEventArgs (false));
			}
			
			private void x8c06ad1b432b98eb (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: callvirt Sunisoft.IrisSkin.Skin3rdControl::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ret 
			*/
			
			
			{
				this.OnCurrentSkinChanged (xe0292b9ed559da7d, xfbf34718e704c6bc);
			}
			
			private void xb1ee1b6293236c5f ()
			
			/*
				// Code Size: 230 Bytes
				.maxstack 4
				.locals (System.Collections.ArrayList V_0, 
         System.Windows.Forms.Control V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_0023 to L_005d finally L_005d to L_0072
				.try L_007a to L_00d0 finally L_00d0 to L_00e5
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.Skin3rdControl::Boolean get_CanPaint()
				L_0006: brfalse L_00e5
				L_000b: newobj System.Collections.ArrayList::Void .ctor()
				L_0010: stloc.0 
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Windows.Forms.Control Ctrl
				L_0017: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_001c: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_0021: stloc.s V_4
				L_0023: br.s L_0052
				L_0025: ldloc.s V_4
				L_0027: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_002c: castclass System.Windows.Forms.Control
				L_0031: stloc.1 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_0038: ldloc.1 
				L_0039: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_003e: box System.IntPtr
				L_0043: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0048: brtrue.s L_0052
				L_004a: ldloc.0 
				L_004b: ldloc.1 
				L_004c: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0051: pop 
				L_0052: ldloc.s V_4
				L_0054: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0059: brtrue.s L_0025
				L_005b: leave.s L_0072
				L_005d: ldloc.s V_4
				L_005f: isinst System.IDisposable
				L_0064: stloc.s V_5
				L_0066: ldloc.s V_5
				L_0068: brfalse.s L_0071
				L_006a: ldloc.s V_5
				L_006c: callvirt System.IDisposable::Void Dispose()
				L_0071: endfinally 
				L_0072: ldloc.0 
				L_0073: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0078: stloc.s V_4
				L_007a: br.s L_00c5
				L_007c: ldloc.s V_4
				L_007e: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0083: castclass System.Windows.Forms.Control
				L_0088: stloc.2 
				L_0089: ldarg.0 
				L_008a: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_008f: ldloc.2 
				L_0090: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0095: box System.IntPtr
				L_009a: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_009f: brtrue.s L_00c5
				L_00a1: ldloc.2 
				L_00a2: ldarg.0 
				L_00a3: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
				L_00a8: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_00ad: stloc.3 
				L_00ae: ldarg.0 
				L_00af: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_00b4: ldloc.2 
				L_00b5: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00ba: box System.IntPtr
				L_00bf: ldloc.3 
				L_00c0: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_00c5: ldloc.s V_4
				L_00c7: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_00cc: brtrue.s L_007c
				L_00ce: leave.s L_00e5
				L_00d0: ldloc.s V_4
				L_00d2: isinst System.IDisposable
				L_00d7: stloc.s V_5
				L_00d9: ldloc.s V_5
				L_00db: brfalse.s L_00e4
				L_00dd: ldloc.s V_5
				L_00df: callvirt System.IDisposable::Void Dispose()
				L_00e4: endfinally 
				L_00e5: ret 
			*/
			
			
			{
				xbd3f2493841f18a1 xbd3f2493841f18a1_1;
				if (! this.CanPaint)
				{
					return;
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (Control control1 in this.Ctrl.Controls)
				{
					if (! this.skinControlList.ContainsKey (control1.Handle))
					{
						int i1 = arrayList1.Add (control1);
					}
				}
				foreach (Control control2 in arrayList1)
				{
					if (! this.skinControlList.ContainsKey (control2.Handle))
					{
						xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control2, this.Engine);
						this.skinControlList.Add (control2.Handle, xbd3f2493841f18a1_1);
					}
				}
			}
			
			private void xd34eabd7bd15b71a (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 76 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.Control V_0, 
         Sunisoft.IrisSkin.xbd3f2493841f18a1 V_1)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.Skin3rdControl::Boolean get_CanPaint()
				L_0006: brfalse.s L_004b
				L_0008: ldarg.2 
				L_0009: callvirt System.Windows.Forms.ControlEventArgs::System.Windows.Forms.Control get_Control()
				L_000e: stloc.0 
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_0015: ldloc.0 
				L_0016: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001b: box System.IntPtr
				L_0020: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0025: brtrue.s L_004b
				L_0027: ldloc.0 
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.Skin3rdControl::Sunisoft.IrisSkin.SkinEngine Engine
				L_002e: call Sunisoft.IrisSkin.xf3f6919ac5d158dc::Sunisoft.IrisSkin.xbd3f2493841f18a1 xebcf83b00134300b(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0033: stloc.1 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.Skin3rdControl::System.Collections.Hashtable skinControlList
				L_003a: ldloc.0 
				L_003b: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0040: box System.IntPtr
				L_0045: ldloc.1 
				L_0046: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_004b: ret 
			*/
			
			
			{
				if (! this.CanPaint)
				{
					return;
				}
				Control control1 = xfbf34718e704c6bc.Control;
				if (this.skinControlList.ContainsKey (control1.Handle))
				{
					return;
				}
				xbd3f2493841f18a1 xbd3f2493841f18a1_1 = xf3f6919ac5d158dc.xebcf83b00134300b (control1, this.Engine);
				this.skinControlList.Add (control1.Handle, xbd3f2493841f18a1_1);
			}
			
			private void xf8f5e344dcfab3e8 (object xe0292b9ed559da7d, ControlEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
		#endregion
	}
	
}

