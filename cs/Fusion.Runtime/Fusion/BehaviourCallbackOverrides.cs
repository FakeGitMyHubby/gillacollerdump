using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal static class BehaviourCallbackOverrides
{
	public static bool HasOverride(Type type, string methodName, Type[] excludedDeclaringTypes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0257: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected I4, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I8
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X23_v3+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		MethodInfo overrideMethod = GetOverrideMethod(type, typeFromHandle, methodName);
		object obj5;
		if (overrideMethod == null)
		{
			obj5 = 0;
			goto IL_02a7;
		}
		bool flag6;
		if ((object)overrideMethod != null)
		{
			nint num = (nint)overrideMethod;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6 (Il2CppClass<System.Reflection.MethodInfo>)+1D0]");
			Type type2 = (Type)0;
			bool flag2 = ((Type)(object)overrideMethod).IsMarshalByRefImpl();
			if (excludedDeclaringTypes != null)
			{
				if (excludedDeclaringTypes.Length < 1)
				{
					obj5 = 1;
					goto IL_02a7;
				}
				object obj6 = excludedDeclaringTypes.Length & 0xFFFFFFFFL;
				object obj7 = excludedDeclaringTypes + 32;
				object obj8 = 0;
				object obj9 = 0;
				while (true)
				{
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
					object obj10 = !flag3;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X23_v3+E8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v17+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v4+v175 @ X22_v8*8]");
					flag6 = (Type)flag5 == (Type)0;
					bool flag7 = !flag6;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						obj6 = excludedDeclaringTypes.Length;
						obj9++;
						bool flag8 = (nint)obj9 < excludedDeclaringTypes.Length;
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v4+v175 @ X22_v8*8]");
						type2 = (Type)0;
						if (flag8)
						{
							continue;
						}
					}
					goto IL_021a;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_021a:
		obj5 = (flag6 ? 1 : 0) ^ 1;
		goto IL_02a7;
		IL_02a7:
		return (byte)(obj5 & 1) != 0;
	}

	public static BehaviourCallbackFlags Compute(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I4
		//IL_003d: Expected VT, but got Obj
		//IL_0059: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0446: Expected I4, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0134: Expected VT, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I8
		//IL_016b: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_028f: Expected VT, but got Obj
		//IL_02b3: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_02ef: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected I4, but got Unknown
		//IL_03f3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X24_v2+E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj2);
		Type[] array = default;
		bool flag2 = array == null;
		object obj6 = 0;
		NullReferenceException ex = default;
		if (!flag2)
		{
			bool flag3 = (object)typeFromHandle == null;
			object obj7 = 0;
			if (!flag3)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18 (Il2CppClass<System.Type[]>)+40]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18 (Il2CppClass<System.Type[]>)+40]");
				obj6 = 0;
				if (flag4)
				{
					goto IL_0429;
				}
			}
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
				object obj8 = 0;
				object obj9 = array + 32;
				obj9 = typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj8);
				bool flag5 = (object)typeFromHandle2 == null;
				obj7 = 0;
				if (!flag5)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v17 (Il2CppClass<System.Type[]>)+40]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v17 (Il2CppClass<System.Type[]>)+40]");
					obj6 = 0;
					if (flag6)
					{
						goto IL_0429;
					}
				}
				object obj10 = array.Length & 0xFFFFFFFEL;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5850]");
					object methodName = 0;
					object obj11 = array + 40;
					obj11 = typeFromHandle2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag7 = HasOverride(type, (string)methodName, array);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X24_v2+E8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v12+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj2);
					Type[] array2 = default;
					bool flag9 = array2 == null;
					Type[] array3 = array;
					obj6 = 0;
					if (flag9)
					{
						goto IL_041b;
					}
					bool flag10 = (object)typeFromHandle3 == null;
					obj7 = 0;
					if (!flag10)
					{
						nint num3 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v16 (Il2CppClass<System.Type[]>)+40]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag11 = ex == null;
						array3 = array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v16 (Il2CppClass<System.Type[]>)+40]");
						obj6 = 0;
						if (flag11)
						{
							goto IL_0429;
						}
					}
					bool flag12 = array2.Length == 0;
					array3 = array;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5858]");
						object methodName2 = 0;
						object obj14 = array2 + 32;
						obj14 = typeFromHandle3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag13 = HasOverride(type, (string)methodName2, array2);
						bool flag14 = !flag13;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
						object obj15 = !flag14;
						object obj16 = ~obj15;
						object obj17 = ((obj16 != null) ? ((object)flag7) : ((object)2));
						BehaviourCallbackFlags behaviourCallbackFlags = ComputePreRender(type);
						return (BehaviourCallbackFlags)(obj17 | behaviourCallbackFlags);
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			obj6 = obj7;
		}
		goto IL_041b;
		IL_0429:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		return (BehaviourCallbackFlags)ex3;
		IL_041b:
		ex = new NullReferenceException();
		goto IL_0429;
	}

	private static BehaviourCallbackFlags ComputePreRender(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0073: Expected Obj, but got I4
		//IL_02aa: Expected I4, but got Obj
		//IL_00a6: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I4
		//IL_01a6: Expected VT, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5868]");
		object methodName = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		MethodInfo overrideMethod = GetOverrideMethod(type, typeFromHandle, (string)methodName);
		bool flag2 = overrideMethod == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			if ((object)overrideMethod == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (BehaviourCallbackFlags)ex;
			}
			nint num = (nint)overrideMethod;
			bool flag4 = ((Type)(object)overrideMethod).IsMarshalByRefImpl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v2+E8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((Type)flag4 == typeFromHandle))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v2+E8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v18+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj9);
				if ((Type)flag4 == typeFromHandle2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v25+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = NetworkBehaviourUtils.ChangeDetector.HasChangeCallbacks(type);
					bool flag9 = !flag8;
					object obj14 = !flag9;
					object obj15 = ~obj14;
					if (obj15 == null)
					{
						return (BehaviourCallbackFlags)4;
					}
					return (BehaviourCallbackFlags)0;
				}
				return (BehaviourCallbackFlags)4;
			}
		}
		return (BehaviourCallbackFlags)0;
	}

	internal static MethodInfo GetOverrideMethod(Type type, Type declaringType, string methodName)
	{
		//IL_0057: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		MethodInfo result;
		if ((object)type != null)
		{
			Type type2 = ((System.RuntimeType)type).MakeByRefType();
			if ((object)type2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v5 (System.Type)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v5 (System.Type)+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0239;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				object obj3 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj4 = !flag;
					if (obj4 != null)
					{
						break;
					}
					object obj5 = (object)type2 + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
					result = (MethodInfo)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
						string text = (string)((Type)0).IsMarshalByRef;
						if (text == methodName)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
							PropertyInfo property = ((Type)0).GetProperty((string)0, (BindingFlags)0);
							if ((object)property == null)
							{
								goto IL_0243;
							}
							nint num = (nint)property;
							Type field = (Type)(object)((Type)(object)property).GetField((string)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X24_v7+E8]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v14+E4]");
							bool flag2 = (nint)0 == 0;
							object obj7 = !flag2;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag3 = field == declaringType;
							bool flag4 = !flag3;
							object obj8 = !flag4;
							if (obj8 != null)
							{
								goto IL_025f;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v5 (System.Type)+18]");
						obj = 0;
						obj3++;
						object obj9 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v5 (System.Type)+18]");
						if ((nint)obj9 < 0)
						{
							continue;
						}
						goto IL_0239;
					}
					goto IL_0243;
				}
				goto IL_0251;
			}
		}
		goto IL_0243;
		IL_025f:
		return result;
		IL_0239:
		result = null;
		goto IL_025f;
		IL_0251:
		return (MethodInfo)(object)new IndexOutOfRangeException();
		IL_0243:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0251;
	}
}
