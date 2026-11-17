using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;

namespace Fusion;

public static class ReflectionUtils
{
	public static T GetCustomAttributeOrThrow<T>(MemberInfo member, bool inherit) where T : Attribute
	{
		//IL_02da: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_002a: Expected VT, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0069: Expected VT, but got I4
		//IL_01da: Expected VT, but got I
		//IL_0256: Expected VT, but got I
		//IL_0124: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X23_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		bool flag2 = (object)member == null;
		Type type = null;
		if (!flag2)
		{
			nint num = (nint)member;
			((Exception)(object)member).GetObjectData((SerializationInfo)(object)typeFromHandle, (StreamingContext)inherit);
			object obj4 = default;
			bool flag3 = obj4 == null;
			nint num2 = (inherit ? 1 : 0);
			type = typeFromHandle;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v31+18]");
				bool flag4 = (nint)0 == 0;
				num2 = (inherit ? 1 : 0);
				type = typeFromHandle;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v31+18]");
					if ((nint)0 < (nint)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v31+18]");
						if ((nint)0 != 0)
						{
							object obj5 = (nint)0 + (nint)309;
							object obj6 = obj5 & 1;
							bool flag5 = obj6 == null;
							object obj7 = !flag5;
							nint num3 = 0;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
								IntPtr intPtr = default;
								num3 = intPtr;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v31+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								T val = default;
								bool flag6 = val == null;
								object obj8 = !flag6;
								if (obj8 == null)
								{
									throw new InvalidCastException();
								}
								return val;
							}
							return null;
						}
						goto IL_02bc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format = default;
					string message = string.Format(format, member, typeFromHandle2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector(message);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string format2 = default;
					string message2 = string.Format(format2, member, typeFromHandle3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentOutOfRangeException ex2 = default;
					string paramName = default;
					ex2._002Ector(paramName, message2);
				}
				ArgumentNullException ex3 = new ArgumentNullException();
				goto IL_02bc;
			}
		}
		throw new NullReferenceException();
		IL_02bc:
		return (T)(object)new IndexOutOfRangeException();
	}
}
