using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;

namespace Fusion;

public struct NetworkInput
{
	private unsafe uint* _ptr;

	private int _wordCount;

	public int WordCount => _wordCount;

	public unsafe uint* Data
	{
		get
		{
			//IL_0037: Expected I, but got Obj
			uint* result = _ptr + 1;
			if (_ptr == null)
			{
				return (uint*)unchecked((nint)null);
			}
			return result;
		}
	}

	public unsafe bool IsValid
	{
		get
		{
			bool flag = _ptr == null;
			return !flag;
		}
	}

	internal unsafe uint* Ptr => _ptr;

	internal unsafe int TypeKey
	{
		get
		{
			//IL_0038: Expected I4, but got I8
			uint* ptr = _ptr;
			if (_ptr == null)
			{
				return -1;
			}
			return (int)ptr;
		}
		set
		{
			if (_ptr != null)
			{
				uint* ptr = (uint*)value;
			}
		}
	}

	public unsafe Type Type
	{
		get
		{
			//IL_0037: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I
			//IL_011f: Expected Obj, but got I4
			//IL_0142: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I4
			uint* ptr = _ptr;
			if (_ptr != null)
			{
				object obj = (object)((byte*)ptr + 1);
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v5+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v5+A0]");
					object obj5 = 0;
					if (obj5 != null)
					{
						bool flag2 = ((NetworkTypesMeta)obj5).TryGetInputType((int)ptr, out Type type);
						bool flag3 = !flag2;
						object obj6 = !flag3;
						object obj7 = ~obj6;
						if (obj7 == null)
						{
							return type;
						}
						return null;
					}
					return (Type)(object)new NullReferenceException();
				}
			}
			return null;
		}
	}

	internal unsafe static NetworkInput FromRaw(uint* ptr, int wordCount)
	{
		//IL_0005: Expected VT, but got I
		return (NetworkInput)ptr;
	}

	internal unsafe static NetworkInput FromRaw(int* ptr, int wordCount)
	{
		//IL_0005: Expected VT, but got I
		return (NetworkInput)ptr;
	}

	public unsafe bool TryGet<T>(out T input) where T : struct, INetworkInput
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0213: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got Ref
		//IL_0252: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_0060: Expected VT, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		_ = 0;
		bool isValid = IsValid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		Assert.Check(isValid, (string)error);
		bool flag7;
		ref T reference;
		object obj14;
		NullReferenceException ex;
		if (_ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v14+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v17+E8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
				bool flag3 = num2 != 0;
				reference = ref *(T*)null;
				obj14 = 0;
				ex = (NullReferenceException)(object)typeFromHandle;
				if (!flag3)
				{
					ex = new NullReferenceException();
					reference = ref *(T*)null;
					obj14 = 0;
				}
				goto IL_01e8;
			}
			bool flag4 = ((NetworkTypesMeta)obj11).TryGetInputTypeKey(typeFromHandle, out System.Runtime.CompilerServices.Unsafe.As<object, int>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12)));
			bool flag5 = !flag4;
			object obj15 = 0;
			if (!flag5)
			{
				int typeKey = TypeKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
				bool flag6 = (nint)typeKey != 0;
				obj15 = 0;
				if (!flag6)
				{
					uint* data = Data;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
					obj15 = 0;
					obj14 = obj5;
					flag7 = true;
					goto IL_02c6;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		reference = ref *(T*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<T>)+FC]");
		obj14 = 0;
		flag7 = false;
		goto IL_02c6;
		IL_02c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		bool flag8 = num3 != 0;
		ex = (NullReferenceException)flag7;
		if (!flag8)
		{
			return flag7;
		}
		goto IL_01e8;
		IL_01e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe bool TrySet<T>(T input) where T : struct, INetworkInput
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0201: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_0060: Expected VT, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		ref int reference = ref *(int*)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		_ = 0;
		bool isValid = IsValid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object obj6 = 0;
		string text = (string)obj6;
		Assert.Check(isValid, (string)obj6);
		bool flag = _ptr == null;
		ref int reference2 = ref *(int*)null;
		bool flag8;
		NullReferenceException ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v12+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v17+E8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
				bool flag4 = num2 != 0;
				text = null;
				reference2 = ref *(int*)null;
				ex = (NullReferenceException)(object)typeFromHandle;
				if (!flag4)
				{
					ex = new NullReferenceException();
					text = null;
					reference2 = ref *(int*)null;
				}
				goto IL_01d6;
			}
			bool flag5 = ((NetworkTypesMeta)obj11).TryGetInputTypeKey(typeFromHandle, out System.Runtime.CompilerServices.Unsafe.As<object, int>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12)));
			bool flag6 = !flag5;
			object obj14 = 0;
			text = (string)(object)typeFromHandle;
			if (!flag6)
			{
				int typeKey = TypeKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-C]");
				bool flag7 = (nint)typeKey != 0;
				obj14 = 0;
				text = null;
				if (!flag7)
				{
					uint* data = Data;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
					obj14 = 0;
					text = (string)data;
					reference2 = ref reference;
					flag8 = true;
					goto IL_02c1;
				}
			}
		}
		flag8 = false;
		goto IL_02c1;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		bool flag9 = num3 != 0;
		ex = (NullReferenceException)flag8;
		if (!flag9)
		{
			return flag8;
		}
		goto IL_01d6;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	public unsafe T Get<T>() where T : struct, INetworkInput
	{
		//IL_0010: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
				obj = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2+8]");
		object obj4 = 0;
		bool isValid = IsValid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		Assert.Check(isValid, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X2+38]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X1_v3] (should have been resolved before IL gen)");
		uint* data = Data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		T result = default;
		return result;
	}

	public unsafe bool Set<T>(T value) where T : struct, INetworkInput
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_00be: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got Ref
		//IL_00f7: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected I4, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		bool isValid = IsValid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		Assert.Check(isValid, (string)error);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X1_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		uint* data = Data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		object obj7 = default;
		if (num3 == 0)
		{
			return (byte)(obj7 & 1) != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}

	internal unsafe bool Set(Type type, void* value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_02b2: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		bool flag = _ptr == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+A0]");
		object obj4 = 0;
		int num;
		object obj6;
		string message;
		if (((NetworkTypesMeta)obj4).TryGetInputWordCount(type, out int wordCount))
		{
			if (wordCount < _wordCount)
			{
				bool flag3 = Convert(type);
				object obj5 = (object)(_ptr + 1);
				num = wordCount << 2;
				obj6 = ((_ptr != null) ? obj5 : ((object)0));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
				if ((nint)0 != 0)
				{
					if (num != 0)
					{
						goto IL_0105;
					}
				}
				else
				{
					_ = 1;
					bool flag4 = num == 0;
					object obj7 = !flag4;
					if (obj7 != null)
					{
						goto IL_0105;
					}
				}
				bool flag5 = true;
				goto IL_035a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object obj9 = default;
			object obj10 = default;
			message = string.Format(format, obj9, obj10);
			object obj11 = obj9;
			object obj12 = obj10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format2 = default;
			message = string.Format(format2, type);
			object obj11 = type;
			object obj12 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentException ex = default;
		string paramName = default;
		ex._002Ector(message, paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (byte)(int)ex2 != 0;
		IL_035a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return true;
		IL_0105:
		if (obj6 != null)
		{
			int num2 = num >> 30;
			bool flag6 = value == null;
			object obj14 = !flag6;
			object obj15 = ~obj14;
			bool flag7 = obj15 == null && num2 == 0;
			bool flag5 = flag7;
		}
		else
		{
			bool flag5 = false;
		}
		goto IL_035a;
	}

	public bool Convert<T>() where T : struct, INetworkInput
	{
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_002a: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X9_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		return Convert(typeFromHandle);
	}

	public unsafe bool Convert(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_016c: Expected I4, but got Obj
		//IL_00a6: Expected I, but got I8
		//IL_00f9: Expected Obj, but got I4
		//IL_0245: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		bool flag = _ptr == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+A0]");
		object obj4 = 0;
		if (obj4 != null)
		{
			if (((NetworkTypesMeta)obj4).TryGetInputTypeKey(type, out int key))
			{
				IntPtr ptr = (nint)_ptr;
				void* ptr2 = ((_ptr == null) ? ((void*)4294967295uL) : ((IntPtr*)ptr)->m_value);
				if ((void*)key != ptr2)
				{
					int num = _wordCount << 2;
					if (num != 0)
					{
						int num2 = num >> 30;
						bool flag3 = _ptr == null;
						object obj5 = !flag3;
						object obj6 = ~obj5;
						bool condition2 = obj6 == null && num2 == 0;
						Assert.Always(condition2, (nint)_ptr, num);
						UnsafeUtility.MemClear(_ptr, num);
					}
					if (_ptr != null)
					{
						uint* ptr3 = (uint*)key;
					}
					return true;
				}
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool Is<T>() where T : struct, INetworkInput
	{
		//IL_0033: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_0077: Expected VT, but got I
		//IL_0119: Expected I4, but got Obj
		//IL_00e1: Expected Obj, but got I4
		bool isValid = IsValid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D57E8]");
		object error = 0;
		Assert.Check(isValid, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if (obj5 != null)
		{
			if (((NetworkTypesMeta)obj5).TryGetInputTypeKey(typeFromHandle, out int key))
			{
				int typeKey = TypeKey;
				object obj8 = key - typeKey;
				return obj8 == null;
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
