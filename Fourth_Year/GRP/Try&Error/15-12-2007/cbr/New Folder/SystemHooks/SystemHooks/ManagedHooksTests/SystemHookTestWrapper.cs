// /////////////////////////////////////////////////////////////
// File: SystemHookTestWrapper.cs	Class: Kennedy.ManagedHooks.Tests.SystemHookTestWrapper
// Date: 2/25/2004					Author: Michael Kennedy
// Language: C#						Framework: .NET
//
// Copyright: Copyright (c) Michael Kennedy, 2004
// /////////////////////////////////////////////////////////////
// License: See License.txt file included with application.
// Description: See compiled documentation (Managed Hooks.chm)
// /////////////////////////////////////////////////////////////

using System;

namespace Kennedy.ManagedHooks.Tests
{
	//
	// This class serves as a concrete instance of the SystemHook class for testing.
	// Also, it exposes otherwise hidden elements (via protected access). This allows
	// us to write tests against them.
	//
	public class SystemHookTestWrapper : Kennedy.ManagedHooks.SystemHook
	{
		public SystemHookTestWrapper(Kennedy.ManagedHooks.HookTypes type) : base(type)
		{
		}

		protected override void HookCallback(int code, System.UIntPtr wparam, System.IntPtr lparam)
		{
		}

		private static IntPtr MyApplicationInstance
		{
			get
			{
				System.Reflection.Assembly A = typeof(SystemHookTestWrapper).Assembly;
				System.Reflection.Module module = A.GetModules(false)[0];
				IntPtr appInstance = System.Runtime.InteropServices.Marshal.GetHINSTANCE(module);

				return appInstance;
			}
		}

		public void GetMousePositionWrapper(UIntPtr wparam, IntPtr lparam, ref int x, ref int y)
		{
			GetMousePosition(wparam, lparam, ref x, ref y);
		}

		public void GetKeyboardReadingWrapper(UIntPtr wparam, IntPtr lparam, ref int vkCode)
		{
			GetKeyboardReading(wparam, lparam, ref vkCode);
		}

		public void FilterMessageWrapper(int message)
		{
			base.FilterMessage(this.HookType, message);
		}

		public void FilterMessageWrapper(HookTypes type, int message)
		{
			base.FilterMessage(type, message);
		}
	}
}
