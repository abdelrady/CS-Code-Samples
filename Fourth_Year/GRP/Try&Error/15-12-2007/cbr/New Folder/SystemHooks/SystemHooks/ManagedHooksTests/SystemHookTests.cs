using System;

using Kennedy.ManagedHooks;

using UnitedBinary.UnitTests.Framework;

namespace Kennedy.ManagedHooks.Tests
{
	public class SystemHookTests
	{
		public SystemHookTests() {}

		[TestMethod]
		public void HookInstallTests(TestMethodRecord tmr)
		{
			using (SystemHookTestWrapper hook = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				//
				// Test that we can install the hook as a local hook.
				//
				hook.InstallHook();

				//
				// Failure is signalled with an exception, so there is nothing 
				// to actually test. That's why we're passing true.
				//
				tmr.RunTest(true, "Install the hook as a global mouse hook.");
			
				hook.UninstallHook();
			}
		}

		[TestMethod]
		public void ConstructionUnsupportedTypeTests(TestMethodRecord tmr)
		{
			HookTypes type = HookTypes.Hardware;

			tmr.WriteLine("If you implement the hook type HookTypes." + type + 
							", change the type parameter to continue testing this senario.");

			tmr.RegisterException("An unimplemented hook type will cause an exception.", 
				typeof(HookTypeNotImplementedException));

			SystemHookTestWrapper hook = new SystemHookTestWrapper(type);
		}

		[TestMethod]
		public void UnsupportedFilterTypesTest1(TestMethodRecord tmr)
		{
			HookTypes type = HookTypes.Hardware;

			tmr.WriteLine("If you implement the hook type HookTypes." + type + 
				", change the type parameter to continue testing this senario.");

			using (SystemHookTestWrapper hook = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				tmr.RegisterException("An unimplemented hook type will cause an exception (filter message).",
					typeof(ManagedHooksException));

				hook.FilterMessageWrapper(type, 12345);
			}
		}

		[TestMethod]
		public void UnsupportedFilterTypesTest2(TestMethodRecord tmr)
		{
			using (SystemHookTestWrapper hook = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				hook.FilterMessageWrapper(12345);

				tmr.RunTest(true, "Filter message succeeded on HookTypes.MouseLL.");
			}
		}

		[TestMethod]
		public void SingletonErrorTest1(TestMethodRecord tmr)
		{
			using (SystemHookTestWrapper hook1 = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				tmr.RegisterException("Creating a second hook of the same type will fail.", typeof(ManagedHooksException));
				SystemHookTestWrapper hook2 = new SystemHookTestWrapper(HookTypes.MouseLL);
			}
		}

		[TestMethod]
		public void UtilityMethodTests1(TestMethodRecord tmr)
		{
			using (SystemHookTestWrapper hook = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				int vkCode = 0;

				tmr.RegisterException("Invalid LPARAM in GetKeyboardReading utility method is not allowed..",
					typeof(ManagedHooksException));

				hook.GetKeyboardReadingWrapper(new UIntPtr(512), new IntPtr(0), ref vkCode);
			}
		}

		[TestMethod]
		public void UtilityMethodTests2(TestMethodRecord tmr)
		{
			using (SystemHookTestWrapper hook = new SystemHookTestWrapper(HookTypes.MouseLL))
			{
				int x = 0, y = 0;

				tmr.RegisterException("Invalid LPARAM in GetMousePosition utility method is not allowed..",
					typeof(ManagedHooksException));

				hook.GetMousePositionWrapper(new UIntPtr(512), new IntPtr(0), ref x, ref y);
			}
		}
		
	}
}
