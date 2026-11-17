using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct RpcMeta
{
	public readonly uint Key;

	public readonly Type DeclaringType;

	public readonly RpcSources Sources;

	public readonly RpcTargets Targets;

	public readonly RpcInvokeDelegate Invoke;

	public readonly bool IsTickAligned;

	public readonly RpcChannel Channel;

	public readonly RpcInvokeLocalMode LocalInvoke;

	public unsafe RpcMeta(uint key, Type declaringType, RpcSources sources, RpcTargets targets, RpcChannel channel, RpcInvokeLocalMode localInvoke, bool tickAligned, RpcInvokeDelegate invoke)
	{
		//IL_0015: Expected Obj, but got Ref
		//IL_0032: Expected Obj, but got Ref
		Key = key;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = declaringType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = invoke;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal bool IsInstanceOfDeclaringType(NetworkBehaviour obj)
	{
		//IL_02df: Expected I4, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_02ab: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_0127: Expected VT, but got Obj
		//IL_0138: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_019c: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0240: Expected I, but got Obj
		Type declaringType = DeclaringType;
		if ((object)DeclaringType != null)
		{
			nint num = (nint)declaringType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4 (Il2CppClass<System.Type>)+3D0]");
			object obj2 = 0;
			if (DeclaringType.IsCOMObject)
			{
				if ((object)obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
					object obj4 = 0;
					bool flag2 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X23_v4+E8]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10+E4]");
						bool flag = (nint)0 == 0;
						object obj6 = !flag;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!((Type)flag2 != null))
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X23_v4+E8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
						bool flag3 = (nint)0 == 0;
						object obj8 = !flag3;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj4);
						if (!((Type)flag2 != typeFromHandle))
						{
							break;
						}
						if (flag2)
						{
							bool isExplicitLayout = ((Type)flag2).IsExplicitLayout;
							bool flag4 = !isExplicitLayout;
							nint num2 = unchecked((nint)null);
							if (!flag4)
							{
								nint num3 = (flag2 ? 1 : 0);
								bool flag5 = ((Type)flag2).IsMarshalByRefImpl();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X23_v4+E8]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v15+E4]");
								bool flag6 = (nint)0 == 0;
								object obj10 = !flag6;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag7 = (Type)flag5 == DeclaringType;
								bool flag8 = !flag7;
								object obj11 = !flag8;
								num2 = unchecked((nint)null);
								if (obj11 != null)
								{
									return true;
								}
							}
							nint num4 = (flag2 ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13 (Il2CppClass<System.Type>)+870]");
							obj2 = 0;
							flag2 = ((object)flag2).Equals((object)0);
							continue;
						}
						goto IL_02d1;
					}
					goto IL_02b5;
				}
			}
			else
			{
				Type declaringType2 = DeclaringType;
				if ((object)DeclaringType != null)
				{
					nint num5 = (nint)declaringType2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v80 @ X8_v5 (Il2CppClass<System.Type>)+8C8] (should have been resolved before IL gen)");
					goto IL_02b5;
				}
			}
		}
		goto IL_02d1;
		IL_02b5:
		return false;
		IL_02d1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
