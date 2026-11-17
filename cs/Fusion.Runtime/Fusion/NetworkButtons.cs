using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
public struct NetworkButtons : _0021_00210, Action<PlayFabError>
{
	[FieldOffset(0)]
	private int _bits;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF__BITS = default(int);

	internal const int BYTE_COUNT_OF__BITS = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public int Bits => _bits;

	public NetworkButtons(int buttons)
	{
		_bits = buttons;
	}

	public bool IsSet(int button)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0038: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DA8]");
		object error = 0;
		bool flag = button < 32;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		int num = _bits >> button;
		return (byte)(num & 1) != 0;
	}

	public void SetDown(int button)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0038: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DA8]");
		object error = 0;
		bool flag = button < 32;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		int num = 1 << button;
		int bits = _bits | num;
		_bits = bits;
	}

	public void SetUp(int button)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0038: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DA8]");
		object error = 0;
		bool flag = button < 32;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		int num = 1 << button;
		int num2 = ~num;
		int bits = _bits & num2;
		_bits = bits;
	}

	public void Set(int button, bool state)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_004e: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DA8]");
		object error = 0;
		bool flag = button < 32;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		if (state)
		{
			SetDown(button);
		}
		else
		{
			SetUp(button);
		}
	}

	public void SetAllUp()
	{
		_bits = 0;
	}

	public void SetAllDown()
	{
		//IL_000f: Expected I4, but got I8
		_bits = -1;
	}

	public unsafe bool IsSet<T>(T button) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01ee: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got Ref
		//IL_021d: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I
		//IL_0070: Expected Obj, but got I
		//IL_008a: Expected VT, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got Ref
		//IL_00f5: Expected Obj, but got Ref
		//IL_0159: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if ((object)typeFromHandle != null)
		{
			int num2 = ((Enum)(object)typeFromHandle).CompareTo((object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+50]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
			bool condition = (Type)num2 == typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F80A8]");
			object error = 0;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ X1_v8 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			int num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			bool flag2 = IsSet(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag3 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)flag2;
			if (!flag3)
			{
				return flag2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag4 = num6 != 0;
			int num4 = 0;
			NullReferenceException ex = (NullReferenceException)(object)typeFromHandle;
			if (!flag4)
			{
				ex = new NullReferenceException();
				num4 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe void SetDown<T>(T button) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01df: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got Ref
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I
		//IL_0070: Expected Obj, but got I
		//IL_008a: Expected VT, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got Ref
		//IL_00f5: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if ((object)typeFromHandle != null)
		{
			int num2 = ((Enum)(object)typeFromHandle).CompareTo((object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+50]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
			bool condition = (Type)num2 == typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F80A8]");
			object error = 0;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X1_v8 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			int num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			SetDown(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag3 = num6 != 0;
			int num4 = 0;
			NullReferenceException ex = (NullReferenceException)(object)typeFromHandle;
			if (!flag3)
			{
				ex = new NullReferenceException();
				num4 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public unsafe void SetUp<T>(T button) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01df: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got Ref
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I
		//IL_0070: Expected Obj, but got I
		//IL_008a: Expected VT, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got Ref
		//IL_00f5: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if ((object)typeFromHandle != null)
		{
			int num2 = ((Enum)(object)typeFromHandle).CompareTo((object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X26_v2+50]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
			bool condition = (Type)num2 == typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F80A8]");
			object error = 0;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X1_v8 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			int num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
			SetUp(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
			bool flag3 = num6 != 0;
			int num4 = 0;
			NullReferenceException ex = (NullReferenceException)(object)typeFromHandle;
			if (!flag3)
			{
				ex = new NullReferenceException();
				num4 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public unsafe void Set<T>(T button, bool state) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_01e3: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got Ref
		//IL_0212: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I
		//IL_0070: Expected Obj, but got I
		//IL_008a: Expected VT, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got Ref
		//IL_00f5: Expected Obj, but got Ref
		//IL_0156: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X27_v2+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if ((object)typeFromHandle != null)
		{
			int num2 = ((Enum)(object)typeFromHandle).CompareTo((object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X27_v2+50]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
			bool condition = (Type)num2 == typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F80A8]");
			object error = 0;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X1_v8 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-C]");
			int num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-C]");
			bool state2 = default;
			Set(0, state2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			bool flag2 = num5 != 0;
			NullReferenceException ex = (NullReferenceException)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			bool flag3 = num6 != 0;
			int num4 = 0;
			NullReferenceException ex = (NullReferenceException)(object)typeFromHandle;
			if (!flag3)
			{
				ex = new NullReferenceException();
				num4 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public (NetworkButtons, NetworkButtons) GetPressedOrReleased(NetworkButtons previous)
	{
		//IL_000f: Expected Obj, but got VT
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected VT, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		//IL_004d: Expected VT, but got I4
		object obj = ~previous;
		NetworkButtons item = (NetworkButtons)(_bits & obj);
		int num = ~_bits;
		NetworkButtons item2 = (NetworkButtons)(previous & num);
		(NetworkButtons, NetworkButtons) tuple = (item, item2);
		return ((NetworkButtons, NetworkButtons))0;
	}

	public NetworkButtons GetPressed(NetworkButtons previous)
	{
		//IL_0009: Expected Obj, but got VT
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		object obj = ~previous;
		return (NetworkButtons)(_bits & obj);
	}

	public NetworkButtons GetReleased(NetworkButtons previous)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		int num = ~_bits;
		return (NetworkButtons)(previous & num);
	}

	public bool WasPressed(NetworkButtons previous, int button)
	{
		NetworkButtons networkButtons = default;
		return networkButtons.IsSet(button);
	}

	public bool WasReleased(NetworkButtons previous, int button)
	{
		NetworkButtons networkButtons = default;
		return networkButtons.IsSet(button);
	}

	public unsafe bool WasPressed<T>(NetworkButtons previous, T button) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got Ref
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_00bb: Expected Obj, but got Ref
		//IL_00c9: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		NetworkButtons previous2 = (NetworkButtons)(previous & 0xFFFFFFFFL);
		_ = 0;
		NetworkButtons pressed = GetPressed(previous2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ X1_v3 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-C]");
		bool flag = (nint)0 == 0;
		bool result = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num3 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe bool WasReleased<T>(NetworkButtons previous, T button) where T : struct, Enum
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0059: Expected Obj, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got Ref
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_00bb: Expected Obj, but got Ref
		//IL_00c9: Expected Obj, but got Ref
		//IL_00d7: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		NetworkButtons previous2 = (NetworkButtons)(previous & 0xFFFFFFFFL);
		_ = 0;
		NetworkButtons released = GetReleased(previous2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ X1_v3 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-C]");
		bool flag = (nint)0 == 0;
		bool result = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num3 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public bool Equals(NetworkButtons other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = _bits - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DB8]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int bits = _bits;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)bits - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _bits;
	}
}
