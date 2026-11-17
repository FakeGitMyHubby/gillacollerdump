using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;

namespace Fusion;

public static class NetworkStructUtils
{
	private static Dictionary<Type, int> _wordCounts;

	internal static void ResetStatics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = 0;
		((Dictionary<System.__Canon, int>)obj4).Clear();
	}

	public static int GetWordCount<T>() where T : struct, INetworkStruct
	{
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_002f: Expected VT, but got I
		//IL_0043: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC80]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GetWordCount(typeFromHandle);
	}

	public static int GetWordCount(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06a1: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected I4, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_019a: Expected VT, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_0691: Expected I4, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_0376: Expected I, but got Obj
		//IL_0386: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I
		//IL_05b3: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I8
		//IL_0401: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I4
		//IL_0487: Expected VT, but got Obj
		//IL_04b0: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_075e: Expected Obj, but got I
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected Obj, but got Unknown
		//IL_079a: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5DF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		object obj5;
		int num2;
		object obj19;
		System.__Canon _Canon;
		if ((object)typeFromHandle != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC98]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC80]");
			obj5 = 0;
			Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
			bool condition = (byte)(elementType & 1) != 0;
			Assert.Check(condition, (string)error);
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v16+A0]");
			object obj8 = 0;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9928]");
				object obj9 = 0;
				bool flag3 = ((Dictionary<System.__Canon, int>)obj8).TryGetValue((System.__Canon)(object)type, out int _);
				bool flag4 = !flag3;
				object obj10 = !flag4;
				if (obj10 != null)
				{
					goto IL_065d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC88]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj12);
				if ((object)type != null)
				{
					nint num = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v15 (Il2CppClass<System.Type>)+220]");
					object obj14 = 0;
					if (((System.RuntimeType)type).IsGenericParameter)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v26 (System.Boolean)+20]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v26 (System.Boolean)+20]");
						bool flag6 = (nint)0 == 0;
						Type type2 = typeFromHandle2;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC90]");
							object obj16 = 0;
							type2 = (Type)obj16;
							if (obj15 != obj16)
							{
								InvalidCastException ex = new InvalidCastException();
								return (int)ex;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v28+E4]");
						bool flag7 = (nint)0 == 0;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool condition2 = type != null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4178]");
						object error2 = 0;
						Assert.Always(condition2, (string)error2);
						num2 = UnsafeUtility.SizeOf(type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v26 (System.Boolean)+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v11+10]");
							obj19 = (nint)0 << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v11+14]");
							bool flag8 = (nint)0 == 0;
							_Canon = null;
							Type type3 = null;
							if (!flag8)
							{
								bool isExplicitLayout = type.IsExplicitLayout;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACA0]");
								object format = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6048]");
								object obj20 = 0;
								obj14 = obj20;
								Assert.Always(isExplicitLayout, (string)format, (System.__Canon)(object)type);
								nint num3 = (nint)type;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v36 (Il2CppClass<System.Type>)+460]");
								type3 = (Type)0;
								bool flag9 = ((System.RuntimeType)type).IsPrimitiveImpl();
								if (!flag9)
								{
									goto IL_066a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52 (System.Boolean)+18]");
								bool flag10 = (nint)0 < (nint)1;
								_Canon = (System.__Canon)(object)type;
								if (!flag10)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52 (System.Boolean)+18]");
									object obj21 = 0 & 0xFFFFFFFFL;
									object obj22 = (flag9 ? 1 : 0) + 32;
									object obj23 = 0;
									object obj24 = obj19;
									System.__Canon _Canon2 = (System.__Canon)(object)type;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v36 (Il2CppClass<System.Type>)+460]");
									Type type4 = (Type)0;
									while (true)
									{
										bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
										object obj25 = !flag11;
										if (obj25 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
										object obj26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v54+E4]");
										bool flag12 = (nint)0 == 0;
										object obj27 = !flag12;
										if (obj27 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
										if ((object)typeFromHandle3 != null)
										{
											nint num4 = (nint)typeFromHandle3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v41 (Il2CppClass<System.Type>)+2A0]");
											_Canon = (System.__Canon)0;
											Type elementType2 = ((System.RuntimeType)typeFromHandle3).GetElementType();
											object obj28 = elementType2 & 1;
											if (obj28 != null)
											{
												object obj29 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v60+E4]");
												bool flag13 = (nint)0 == 0;
												object obj30 = !flag13;
												if (obj30 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X21_v10+v105 @ X29_v8*8]");
												int wordCount = GetWordCount((Type)0);
												obj24 += wordCount;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52 (System.Boolean)+18]");
											obj21 = 0;
											obj23++;
											object obj31 = obj23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52 (System.Boolean)+18]");
											bool flag14 = (nint)obj31 < 0;
											obj19 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X21_v10+v105 @ X29_v8*8]");
											type3 = (Type)0;
											_Canon2 = _Canon;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X21_v10+v105 @ X29_v8*8]");
											type4 = (Type)0;
											if (flag14)
											{
												continue;
											}
											goto IL_0566;
										}
										goto IL_066a;
									}
									goto IL_0678;
								}
							}
							goto IL_0566;
						}
					}
				}
			}
		}
		goto IL_066a;
		IL_0566:
		bool flag15 = (nint)obj19 == num2;
		object obj32 = _Canon;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6010]");
			object format2 = 0;
			object obj33 = default;
			object obj34 = default;
			string error3 = string.Format((string)format2, type, obj33, obj34);
			Assert.AlwaysFail(error3);
			object obj14 = obj34;
			obj32 = obj33;
			Type type3 = null;
		}
		object obj35 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v38+E4]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v38+A0]");
		object obj37 = 0;
		if (obj37 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v11+10]");
			((Dictionary<System.__Canon, int>)obj37).Add((System.__Canon)(object)type, 0);
			goto IL_065d;
		}
		goto IL_066a;
		IL_065d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v11+10]");
		return 0;
		IL_0678:
		throw new IndexOutOfRangeException();
		IL_066a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0678;
	}

	static NetworkStructUtils()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9998]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAC80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary = default;
		dictionary._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = dictionary;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
