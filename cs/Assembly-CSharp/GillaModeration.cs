using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Fusion;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class GillaModeration : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public PlayerRef p;

		public Func<PlayerRef, bool> dueOf;

		internal bool _003COthersTurnOf_003Eb__0(PlayerRef q)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f8: Expected Obj, but got I4
			//IL_00ce: Expected I4, but got Obj
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_0096: Expected Obj, but got I
			//IL_00a6: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (p == q)
			{
				return false;
			}
			Func<PlayerRef, bool> func = dueOf;
			if (dueOf != null)
			{
				object obj4 = q & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4 (System.Func`2<Fusion.PlayerRef, System.Boolean>)+40]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4 (System.Func`2<Fusion.PlayerRef, System.Boolean>)+28]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4 (System.Func`2<Fusion.PlayerRef, System.Boolean>)+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X3_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__94_0;

		public static Func<float> _003C_003E9__94_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal bool _003CForget_003Eb__94_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+10]");
			return false;
		}

		internal float _003CForget_003Eb__94_1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0228: Expected Obj, but got I4
			//IL_024e: Expected Obj, but got I
			//IL_0270: Expected Obj, but got I4
			//IL_030b: Expected Obj, but got I
			//IL_032d: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_007d: Expected F4, but got I4
			//IL_00b5: Expected Obj, but got I4
			//IL_02ad: Expected Obj, but got I4
			//IL_034b: Expected Obj, but got I
			//IL_035b: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I
			//IL_0163: Expected F4, but got I4
			//IL_019b: Expected Obj, but got I4
			//IL_02e5: Expected Obj, but got I4
			//IL_0370: Expected Obj, but got I
			//IL_0380: Expected Obj, but got I
			//IL_01e4: Expected Obj, but got I
			//IL_01f9: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			float result = 0f;
			if (!flag5)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v11+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v15+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13+8]");
				object obj15 = 0;
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v14+50]");
				bool flag9 = (UnityEngine.Object)0 != null;
				bool flag10 = !flag9;
				result = 0f;
				if (!flag10)
				{
					object obj18 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v26+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj20 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v26+A0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v20+8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+50]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v22+3C]");
					result = 0f;
				}
			}
			return result;
		}

		internal bool _003C_002Ecctor_003Eb__121_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+10]");
			return false;
		}

		internal float _003C_002Ecctor_003Eb__121_1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0228: Expected Obj, but got I4
			//IL_024e: Expected Obj, but got I
			//IL_0270: Expected Obj, but got I4
			//IL_030b: Expected Obj, but got I
			//IL_032d: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_007d: Expected F4, but got I4
			//IL_00b5: Expected Obj, but got I4
			//IL_02ad: Expected Obj, but got I4
			//IL_034b: Expected Obj, but got I
			//IL_035b: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I
			//IL_0163: Expected F4, but got I4
			//IL_019b: Expected Obj, but got I4
			//IL_02e5: Expected Obj, but got I4
			//IL_0370: Expected Obj, but got I
			//IL_0380: Expected Obj, but got I
			//IL_01e4: Expected Obj, but got I
			//IL_01f9: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			float result = 0f;
			if (!flag5)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v11+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v15+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13+8]");
				object obj15 = 0;
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v14+50]");
				bool flag9 = (UnityEngine.Object)0 != null;
				bool flag10 = !flag9;
				result = 0f;
				if (!flag10)
				{
					object obj18 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v26+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj20 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v26+A0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v20+8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+50]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v22+3C]");
					result = 0f;
				}
			}
			return result;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass114_0
	{
		public Dictionary<string, string> values;
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public Action<Dictionary<string, string>> done;

		public Action<string> failed;

		internal void _003CReadFromPlayFab_003Eb__0(GetUserDataResult result)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0257: Expected Obj, but got I4
			//IL_0275: Expected Obj, but got I
			//IL_0285: Expected Obj, but got I
			//IL_01d3: Expected Obj, but got I
			//IL_01e3: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I
			//IL_008b: Expected Obj, but got I8
			//IL_009b: Expected Obj, but got I
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00b2: Expected Obj, but got I4
			//IL_02a3: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I4
			//IL_0113: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I
			//IL_0182: Expected Obj, but got I
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected Obj, but got Unknown
			//IL_015d: Expected Obj, but got I
			//IL_016d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A00]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			System.__Canon _Canon = (System.__Canon)obj2;
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v3+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_01b4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v3+18]");
			object obj8 = 0 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A30]");
			object obj9 = 0;
			object obj10 = obj7 + 32;
			object obj11 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
				object obj12 = !flag2;
				if (obj12 != null)
				{
					break;
				}
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v4+v100 @ X25_v5*8]");
				string text = ValueOf(result, (string)0);
				bool flag4 = text == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v4+v100 @ X25_v5*8]");
				_Canon = (System.__Canon)0;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v4+v100 @ X25_v5*8]");
					dictionary.set_Item((System.__Canon)0, (System.__Canon)(object)text);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v4+v100 @ X25_v5*8]");
					_Canon = (System.__Canon)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v3+18]");
				obj8 = 0;
				obj11++;
				object obj15 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v3+18]");
				if ((nint)obj15 < 0)
				{
					continue;
				}
				goto IL_01b4;
			}
			goto IL_01fd;
			IL_01b4:
			Action<Dictionary<string, string>> action = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8 (System.Action`1<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8 (System.Action`1<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8 (System.Action`1<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v202 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_01fd;
			IL_01fd:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}

		internal void _003CReadFromPlayFab_003Eb__1(PlayFabError error)
		{
			//IL_0073: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I
			//IL_0093: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			Action<string> action = failed;
			if (error.Error == (PlayFabErrorCode)1002)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CD0]");
				object obj = 0;
				string text = (string)obj;
			}
			else
			{
				string text2 = error.GenerateErrorReport();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X20_v3 (System.Action`1<System.String>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X20_v3 (System.Action`1<System.String>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X20_v3 (System.Action`1<System.String>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public Action<long> done;

		public Action<string> failed;

		internal unsafe void _003CTimeFromPlayFab_003Eb__0(GetTimeResult result)
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected VT, but got Unknown
			//IL_007a: Expected Obj, but got I
			//IL_0083: Expected Ref, but got VT
			//IL_0138: Expected Obj, but got I4
			//IL_00d1: Expected Obj, but got I4
			//IL_01b2: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected VT, but got Unknown
			//IL_0105: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = (DateTime)(result + 32);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
			object obj4 = 0;
			DateTimeKind kind = ((DateTime*)dateTime)->Kind;
			DateTime dateTime3;
			if (kind == (DateTimeKind)2)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v22+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime2 = (DateTime)(result + 32);
				dateTime3 = ((DateTime*)dateTime2)->ToUniversalTime();
			}
			else
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				dateTime3 = DateTime.SpecifyKind(result.Time, (DateTimeKind)1);
			}
			Action<long> action = done;
			DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime3);
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTimeOffset dateTimeOffset2 = default;
			long num = dateTimeOffset2.ToUnixTimeMilliseconds();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X19_v3 (System.Action`1<System.Int64>)+18] (should have been resolved before IL gen)");
		}

		internal void _003CTimeFromPlayFab_003Eb__1(PlayFabError error)
		{
			//IL_002c: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			Action<string> action = failed;
			string text = error.GenerateErrorReport();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X19_v2 (System.Action`1<System.String>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public const string MuteKey = null;

	public const string MuteWhyKey = null;

	public const string BanKey = null;

	public const string BanWhyKey = null;

	public const string Tag = null;

	public const string Forever = null;

	public const string KickKey = null;

	public const string KickWhyKey = null;

	public const string RoomKickKey = null;

	public const string RoomKickFromKey = null;

	public const string RoomKickWhyKey = null;

	public const float CheckEvery = default(float);

	public const float ClockRetry = default(float);

	public static float RemindEvery;

	public static float TalkLevel;

	public static float BanRemindEvery;

	private const string PrefsKey = null;

	private const string KickPrefsKey = null;

	private const string RoomKickPrefsKey = null;

	private static GillaModeration instance;

	private static bool silenced;

	private static long MuteUntil__BackingField;

	private static string MuteWhy__BackingField;

	private static long KickUntil__BackingField;

	private static string KickWhy__BackingField;

	private static string RoomKickFrom__BackingField;

	private static long RoomKickUntil__BackingField;

	private static string RoomKickWhy__BackingField;

	public static Func<string, bool> KeptOut;

	private static bool keptOutByClose;

	private static bool keptOutByAvoid;

	private static readonly Dictionary<string, float> avoided;

	public const string ClosedFrom = null;

	public const string ClosedCodesKey = null;

	public const float ClosedEvery = default(float);

	public const float ClosedJitter = default(float);

	private static readonly Dictionary<string, (long, string)> closed;

	private static readonly Regex ClosedEntry;

	public static Action<Action<string>, Action<string>> ReadClosed;

	private bool closedAsking;

	private float nextClosed;

	private string closedLeft;

	public static Action<Action<Dictionary<string, string>>, Action<string>> Read;

	public static Func<bool> Reading;

	public static Action<Action<long>, Action<string>> AskTime;

	public static Func<float> Loudness;

	private static bool synced;

	private static double serverAt;

	private static double realAt;

	private bool asking;

	private bool askingTime;

	private bool told;

	private bool banTold;

	private bool wasKicked;

	private bool kickTold;

	private float nextCheck;

	private float nextTime;

	private float toldAt;

	private float banToldAt;

	private float kickToldAt;

	private static readonly string[] Keys;

	public static bool Silenced
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			return false;
		}
	}

	public static long MuteUntil
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected I8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
			return 0L;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
		}
	}

	public static string MuteWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+28]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static long KickUntil
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected I8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+30]");
			return 0L;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
		}
	}

	public static string KickWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
			object obj4 = (nint)0 + (nint)56;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool Kicked
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			//IL_00de: Expected Obj, but got I8
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected Obj, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected I8, but got Unknown
			//IL_015b: Expected Obj, but got I4
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			long serverNowMs = ServerNowMs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+30]");
			object obj7 = -serverNowMs;
			bool flag3 = (nint)obj7 < 0;
			bool flag4 = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+30]");
			long num = 0 ^ serverNowMs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+30]");
			object obj8 = 0 ^ obj7;
			long num2 = num & obj8;
			bool flag5 = num2 < 0;
			bool flag6 = flag3 == flag5;
			object obj9 = !flag4;
			return (byte)((flag6 & obj9) ? 1 : 0) != 0;
		}
	}

	public static string RoomKickFrom
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+40]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
			object obj4 = (nint)0 + (nint)64;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static long RoomKickUntil
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected I8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
			return 0L;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
		}
	}

	public static string RoomKickWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+50]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
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
			object obj4 = (nint)0 + (nint)80;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static long ServerNowMs
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0124: Expected Obj, but got I4
			//IL_01b5: Expected Obj, but got I
			//IL_0093: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0153: Expected Obj, but got I
			//IL_01a0: Expected I8, but got F8
			//IL_007e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+A8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v13+A0]");
					obj4 = 0;
				}
				double realtimeSinceStartupAsDouble = Time.realtimeSinceStartupAsDouble;
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v10+A0]");
				object obj8 = 0;
				double num = realtimeSinceStartupAsDouble;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v11+B8]");
				double num2 = num - 0.0;
				double num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
				double num4 = num3 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+B0]");
				double num5 = 0.0 + num4;
				return (long)num5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTimeOffset utcNow = DateTimeOffset.UtcNow;
			DateTimeOffset dateTimeOffset = default;
			return dateTimeOffset.ToUnixTimeMilliseconds();
		}
	}

	public static bool ClockSynced
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+A8]");
			return false;
		}
	}

	private static bool KeptOutOfKickedRoom(string room)
	{
		//IL_0023: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_03d3: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		if (!string.IsNullOrEmpty(room))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8+40]");
			if (room == (string)0)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v34+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v38+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v38+A0]");
				object obj11 = 0;
				long serverNowMs = ServerNowMs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+48]");
				if (0 > serverNowMs)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v41+E4]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v41+A0]");
					object obj14 = 0;
					_ = 0;
					goto IL_0449;
				}
			}
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string code = CodeOf(room);
			bool flag7 = ClosedNow(code, out var _, out var _);
			object obj17 = obj;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v29+E4]");
				bool flag8 = (nint)0 == 0;
				object obj18 = !flag8;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v29+A0]");
				object obj19 = 0;
				_ = 1;
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Avoided(room))
			{
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v25+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v25+A0]");
				object obj23 = 0;
				_ = 256;
				goto IL_0449;
			}
		}
		return false;
		IL_0449:
		return true;
	}

	public static void Avoid(string room, float seconds)
	{
		//IL_017d: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(room);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+A0]");
			object obj5 = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float value = realtimeSinceStartup + seconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE60]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5+68]");
			((Dictionary<System.__Canon, float>)0).set_Item((System.__Canon)(object)room, value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj7 = 0;
			float num = seconds / 1.1146363E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A50]");
			object format = 0;
			object arg = default;
			string message = string.Format((string)format, room, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	public static bool Avoided(string room)
	{
		//IL_0181: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_015a: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00c0: Invalid comparison between F4 and I4
		//IL_00cf: Invalid comparison between F4 and I4
		//IL_00e2: Expected Obj, but got F4
		//IL_00ef: Expected Obj, but got F4
		//IL_0124: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected I4, but got Unknown
		bool flag = string.IsNullOrEmpty(room);
		bool flag2 = !flag;
		object obj = !flag2;
		bool result = false;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+68]");
			if ((nint)0 == 0)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+68]");
			if (((Dictionary<System.__Canon, float>)0).TryGetValue((System.__Canon)(object)room, out var value))
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num = value - realtimeSinceStartup;
				bool flag4 = num < 0f;
				bool flag5 = num == 0f;
				object obj6 = value ^ realtimeSinceStartup;
				object obj7 = value ^ num;
				object obj8 = obj6 & obj7;
				bool flag6 = (nint)obj8 < 0;
				bool flag7 = flag4 == flag6;
				object obj9 = !flag5;
				bool flag8 = (byte)((flag7 & obj9) ? 1 : 0) != 0;
				result = flag8;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	public static float NextClosedRead(float now, bool first)
	{
		float num;
		if (first)
		{
			num = UnityEngine.Random.Range(0f, 300f);
		}
		else
		{
			float num2 = UnityEngine.Random.Range(0.75f, 1.25f);
			num = num2 * 1.1339039E+09f;
		}
		return num + now;
	}

	public static string CodeOf(string room)
	{
		//IL_0015: Expected Obj, but got I
		//IL_005b: Expected I4, but got I8
		//IL_0075: Expected Obj, but got I4
		if (string.IsNullOrEmpty(room))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			return (string)0;
		}
		if (room != null)
		{
			int num = room.LastIndexOf('-');
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			string text = room;
			if (obj == null)
			{
				int startIndex = num + 1;
				string text2 = room.Substring(startIndex);
				bool flag2 = text2 == null;
				text = text2;
				if (flag2)
				{
					goto IL_00e1;
				}
			}
			return text.ToUpperInvariant();
		}
		goto IL_00e1;
		IL_00e1:
		return (string)(object)new NullReferenceException();
	}

	public unsafe static bool ClosedNow(string code, out long until, out string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_01b4: Expected I4, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_0158: Invalid comparison between VT and I8
		//IL_0177: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		ref long reference = ref *(long*)null;
		ref string reference2 = ref *(string*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = string.IsNullOrEmpty(code);
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			if (code != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+A0]");
				object obj6 = 0;
				string key = code.ToUpperInvariant();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+70]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A48]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+70]");
					if (((Dictionary<System.__Canon, (long, System.__Canon)>)0).TryGetValue((System.__Canon)(object)key, out var value))
					{
						object obj8 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v18+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						long serverNowMs = ServerNowMs;
						if (value > (object)serverNowMs)
						{
							reference = ref *(long*)value;
							reference2 = ref *(string*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return true;
						}
					}
					goto IL_0198;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0198;
		IL_0198:
		return false;
	}

	public unsafe static void TakeClosed(string json)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b21: Expected Obj, but got I4
		//IL_0dac: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_093e: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_099c: Expected Obj, but got I
		//IL_09a4: Expected I, but got Obj
		//IL_0b3f: Expected Obj, but got I
		//IL_0b5b: Expected I, but got Obj
		//IL_0d4b: Expected Obj, but got I4
		//IL_09eb: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0ab5: Expected Obj, but got I4
		//IL_0a26: Expected Obj, but got I
		//IL_012f: Expected VT, but got I4
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Expected Obj, but got Unknown
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0cd9: Expected I, but got Obj
		//IL_0ce9: Expected Obj, but got I
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected Obj, but got Unknown
		//IL_0bde: Expected Obj, but got I4
		//IL_0beb: Expected Obj, but got Ref
		//IL_0bf3: Expected Obj, but got Ref
		//IL_01db: Expected Obj, but got I
		//IL_0277: Expected VT, but got Obj
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_028d: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_086f: Expected Obj, but got VT
		//IL_032c: Expected VT, but got I4
		//IL_02d8: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0362: Expected VT, but got Obj
		//IL_0821: Expected I4, but got Obj
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I
		//IL_08d4: Expected Obj, but got I4
		//IL_08e1: Expected Obj, but got Ref
		//IL_08e9: Expected Obj, but got Ref
		//IL_049c: Expected VT, but got I4
		//IL_04ee: Expected VT, but got I4
		//IL_04f6: Expected Obj, but got Ref
		//IL_07d7: Expected Obj, but got I4
		//IL_07ef: Expected Obj, but got VT
		//IL_052e: Expected Obj, but got I4
		//IL_0c7d: Expected Obj, but got I
		//IL_058d: Expected VT, but got I4
		//IL_06aa: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I4
		//IL_06ff: Expected I4, but got Obj
		//IL_076f: Expected I, but got I8
		//IL_079e: Expected Obj, but got I
		//IL_07a8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+70]");
		object obj23 = default;
		OutOfMemoryException ex4 = default;
		string text;
		nint num = default;
		object obj24;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+70]");
			((Dictionary<System.__Canon, (long, System.__Canon)>)0).Clear();
			bool flag2 = string.IsNullOrEmpty(json);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				return;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v37+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v37+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v23+78]");
			bool flag5 = (nint)0 == 0;
			num = unchecked((nint)null);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v23+78]");
				MatchCollection matchCollection = ((Regex)0).Matches(json);
				bool flag6 = matchCollection == null;
				text = null;
				num = (nint)json;
				if (!flag6)
				{
					IEnumerator enumerator = matchCollection.GetEnumerator();
					bool flag7 = enumerator == null;
					(long, System.__Canon) tuple = ((long, System.__Canon))0;
					System.__Canon _Canon = null;
					if (flag7)
					{
						goto IL_0805;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A68]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A88]");
					object oldValue = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A78]");
					object newValue = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A70]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A60]");
					object obj12 = 0;
					object obj14 = default;
					object obj13 = obj14;
					object obj16 = default;
					object obj15 = obj16;
					text = null;
					IEnumerator enumerator2 = enumerator;
					object obj22 = default;
					object obj25 = default;
					object obj27 = default;
					object obj33 = default;
					GroupCollection groupCollection = default;
					GroupCollection groupCollection2 = default;
					GroupCollection groupCollection3 = default;
					while (true)
					{
						nint num2 = (nint)enumerator2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v39 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v39 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_021c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v39 (Il2CppClass<System.Collections.IEnumerator>)+98]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v38-8]");
							if (0 == (nint)obj9)
							{
								break;
							}
							obj17--;
							obj18 += 16;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_021c;
						}
						object obj19 = num2 + obj18;
						object obj20 = obj19 + 312;
						goto IL_0b8e;
						IL_0826:
						NullReferenceException ex = new NullReferenceException();
						goto IL_0834;
						IL_089e:
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_08ac;
						IL_0834:
						NullReferenceException ex3 = new NullReferenceException();
						goto IL_0842;
						IL_021c:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
						text = null;
						goto IL_0b8e;
						IL_0b8e:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v69+8]");
						int num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v831 @ X0_v69] (should have been resolved before IL gen)");
						object obj21 = obj22 & 1;
						bool flag8 = obj21 == null;
						obj14 = obj13;
						obj16 = obj15;
						obj23 = 0;
						ex4 = null;
						obj24 = (object)(&obj25);
						object obj26 = (object)(&obj27);
						if (flag8)
						{
							break;
						}
						bool flag9 = enumerator == null;
						obj14 = obj13;
						obj16 = obj15;
						tuple = ((long, System.__Canon))text;
						if (flag9)
						{
							goto IL_0842;
						}
						nint num4 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v42 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v42 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0319;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v42 (Il2CppClass<System.Collections.IEnumerator>)+98]");
						object obj29 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X10_v33-8]");
							if (0 == (nint)obj9)
							{
								break;
							}
							obj28--;
							obj29 += 16;
							if ((nint)obj28 != 1)
							{
								continue;
							}
							goto IL_0319;
						}
						object obj30 = obj29 + 1;
						object obj31 = num4 + obj30;
						object obj32 = obj31 + 312;
						tuple = ((long, System.__Canon))text;
						goto IL_0c26;
						IL_0850:
						NullReferenceException ex5 = new NullReferenceException();
						goto IL_085e;
						IL_0842:
						NullReferenceException ex6 = new NullReferenceException();
						goto IL_0850;
						IL_085e:
						NullReferenceException ex7 = new NullReferenceException();
						text = (string)tuple;
						goto IL_0874;
						IL_0874:
						NullReferenceException ex8 = new NullReferenceException();
						goto IL_0882;
						IL_0882:
						NullReferenceException ex9 = new NullReferenceException();
						goto IL_0890;
						IL_0319:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
						tuple = ((long, System.__Canon))1;
						goto IL_0c26;
						IL_0c26:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X0_v72+8]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1095 @ X0_v72] (should have been resolved before IL gen)");
						bool flag10 = obj33 == null;
						obj14 = obj13;
						obj16 = obj15;
						if (!flag10)
						{
							_Canon = (System.__Canon)obj10;
							object obj34 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v45+130]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X1_v24 (System.__Canon)+130]");
							bool flag11 = num5 < 0;
							object obj35 = !flag11;
							object obj36 = ~obj35;
							obj14 = obj13;
							obj16 = obj15;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v45+B0]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X1_v24 (System.__Canon)+130]");
								object obj37 = num6 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X9_v32-8]");
								bool flag12 = 0 != (nint)_Canon;
								obj14 = obj13;
								obj16 = obj15;
								if (!flag12)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v45+190]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v668 @ X8_v45+188] (should have been resolved before IL gen)");
									bool flag13 = groupCollection == null;
									obj14 = obj13;
									obj16 = obj15;
									if (flag13)
									{
										goto IL_0826;
									}
									Group obj38 = groupCollection.get_Item(2);
									bool flag14 = obj38 == null;
									obj14 = obj13;
									obj16 = obj15;
									tuple = ((long, System.__Canon))0;
									num3 = 2;
									if (!flag14)
									{
										string value = obj38.Value;
										bool flag15 = long.TryParse(value, out var result);
										bool flag16 = !flag15;
										tuple = ((long, System.__Canon))0;
										_Canon = (System.__Canon)(&result);
										if (!flag16)
										{
											object obj39 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v82+E4]");
											bool flag17 = (nint)0 == 0;
											object obj40 = !flag17;
											if (obj40 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj39 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v82+A0]");
											object obj41 = 0;
											object obj42 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X9_v36+190]");
											num3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v945 @ X9_v36+188] (should have been resolved before IL gen)");
											bool flag18 = groupCollection2 == null;
											obj14 = obj13;
											obj16 = obj15;
											text = null;
											if (flag18)
											{
												goto IL_0890;
											}
											Group obj43 = groupCollection2.get_Item(1);
											bool flag19 = obj43 == null;
											obj14 = obj13;
											obj16 = obj15;
											tuple = ((long, System.__Canon))0;
											num3 = 1;
											if (flag19)
											{
												goto IL_085e;
											}
											string value2 = obj43.Value;
											object obj44 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v50+190]");
											num3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1026 @ X8_v50+188] (should have been resolved before IL gen)");
											bool flag20 = groupCollection3 == null;
											obj14 = obj13;
											obj16 = obj15;
											text = null;
											if (flag20)
											{
												goto IL_089e;
											}
											Group obj45 = groupCollection3.get_Item(3);
											bool flag21 = obj45 == null;
											obj14 = obj13;
											obj16 = obj15;
											text = null;
											num3 = 3;
											if (flag21)
											{
												goto IL_0874;
											}
											string value3 = obj45.Value;
											bool flag22 = value3 == null;
											obj14 = obj13;
											obj16 = obj15;
											text = null;
											num3 = 0;
											if (flag22)
											{
												goto IL_08ac;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A80]");
											object obj46 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7240]");
											object obj47 = 0;
											text = (string)obj47;
											string text2 = value3.Replace((string)obj46, (string)obj47);
											bool flag23 = text2 == null;
											obj14 = obj13;
											obj16 = 0;
											num3 = (int)obj46;
											if (flag23)
											{
												goto IL_0882;
											}
											string text3 = text2.Replace((string)oldValue, (string)newValue);
											obj16 = obj11;
											(long, System.__Canon) tuple2 = (result, (System.__Canon)(object)text3);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ X8_v48+70]");
											bool flag24 = (nint)0 == 0;
											obj14 = obj13;
											text = text3;
											num = (nint)result;
											if (flag24)
											{
												goto IL_08c2;
											}
											obj13 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ X8_v48+70]");
											((Dictionary<System.__Canon, (long, System.__Canon)>)0).set_Item((System.__Canon)(object)value2, tuple2);
											obj15 = 0;
											tuple = tuple2;
											_Canon = (System.__Canon)(object)value2;
										}
										bool flag25 = enumerator == null;
										object obj48 = !flag25;
										obj14 = obj13;
										obj16 = obj15;
										text = (string)tuple;
										enumerator2 = enumerator;
										if (obj48 != null)
										{
											continue;
										}
										goto IL_0805;
									}
									goto IL_0834;
								}
							}
							InvalidCastException ex10 = new InvalidCastException();
							num3 = (int)_Canon;
							goto IL_0826;
						}
						goto IL_0850;
						IL_0890:
						NullReferenceException ex11 = new NullReferenceException();
						goto IL_089e;
						IL_08ac:
						NullReferenceException ex12 = new NullReferenceException();
						num = num3;
						goto IL_08c2;
						IL_08c2:
						NullReferenceException ex13 = new NullReferenceException();
						obj23 = 0;
						ex4 = null;
						obj24 = (object)(&obj25);
						obj26 = (object)(&obj27);
						goto IL_08ee;
					}
					goto IL_098c;
				}
			}
		}
		goto IL_08ee;
		IL_0d31:
		bool flag26 = ex4 == null;
		object obj49 = !flag26;
		if (obj49 == null)
		{
			bool flag27 = obj23 == null;
			object obj50 = !flag27;
			OutOfMemoryException ex14 = ex4;
			if (obj50 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex14 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex16 = default;
		NullReferenceException ex15 = ex16;
		goto IL_0d0e;
		IL_08ee:
		NullReferenceException ex17 = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj23 = 1;
		}
		else
		{
			bool flag28 = num != 1;
			ex15 = ex17;
			if (flag28)
			{
				goto IL_0d0e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj51 = default;
			ex4 = (OutOfMemoryException)obj51;
		}
		goto IL_098c;
		IL_0d7d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v20+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v766 @ X0_v20] (should have been resolved before IL gen)");
		goto IL_0d31;
		IL_0d0e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0a67:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text = null;
		goto IL_0d7d;
		IL_098c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj52 = 0;
		num = (nint)obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj53 = default;
		obj24 = obj53;
		if (obj53 == null)
		{
			goto IL_0d31;
		}
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v13+12E]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a67;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v13+98]");
		object obj56 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X10_v9-8]");
			if (0 == (nint)obj52)
			{
				break;
			}
			obj55--;
			obj56 += 16;
			if ((nint)obj55 != 1)
			{
				continue;
			}
			goto IL_0a67;
		}
		object obj57 = obj54 + obj56;
		object obj58 = obj57 + 312;
		goto IL_0d7d;
		IL_0805:
		throw new NullReferenceException();
	}

	private static void ReadClosedFromPlayFab(Action<string> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0281: Expected I, but got Obj
		//IL_02a1: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = done;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2 + 24;
		obj5 = failed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AA8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj7 = 0;
		object obj8 = getUserDataRequest + 40;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AB0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj10 = 0;
		System.__Canon[] items = list._items;
		object obj11 = obj10;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A98]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AA0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj16 = 0;
		bool flag = list._size < items.Length;
		object obj17 = !flag;
		if (obj17 == null)
		{
			object obj18 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj19 = obj18 + 32;
			obj19 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v4+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v9+A8]");
			object obj21 = 0;
			list.AddWithResize((System.__Canon)obj9);
		}
		object obj22 = getUserDataRequest + 32;
		obj22 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj15);
		object obj23 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj24 = !flag2;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserReadOnlyData(getUserDataRequest, (Action<GetUserDataResult>)action, (Action<PlayFabError>)action2);
	}

	private void WatchClosed(float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0112: Invalid comparison between F4 and I4
		//IL_07af: Expected Obj, but got I4
		//IL_0891: Expected Obj, but got I
		//IL_08a1: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01a5: Expected F4, but got I4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07f3: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I4
		//IL_0259: Invalid comparison between F4 and I4
		//IL_026a: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_04b1: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I
		//IL_0380: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_03ad: Expected I, but got Obj
		//IL_0517: Expected Obj, but got I
		//IL_0527: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I4
		//IL_03c5: Expected F4, but got I4
		//IL_082b: Expected Obj, but got I4
		//IL_08be: Expected Obj, but got I
		//IL_08e0: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I4
		//IL_06e5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
		string text;
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
			string roomName = ((NetworkBootstrap)0).RoomName;
			UnityEngine.Object obj10 = null;
			text = roomName;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj11 = 0;
			text = (string)obj11;
			UnityEngine.Object obj10 = null;
		}
		if (text._stringLength == 0)
		{
			return;
		}
		float num = nextClosed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj12 = 0;
		if (nextClosed < 0f)
		{
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v77+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num2 = UnityEngine.Random.Range(0f, 300f);
			num = num2 + now;
			nextClosed = num;
			float num3 = 1.1339039E+09f;
		}
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v14+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v13+90]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ X8_v14+18] (should have been resolved before IL gen)");
		object obj20 = default;
		object obj19 = obj20 & 1;
		if (obj19 != null)
		{
			bool flag6 = (byte)(~(closedAsking ? 1u : 0u)) != 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				num = nextClosed;
				bool flag7 = nextClosed < now;
				object obj22 = !flag7;
				float num4 = nextClosed - now;
				bool flag8 = num4 == 0f;
				object obj23 = !flag8;
				object obj24 = obj22 & obj23;
				if (obj24 == null)
				{
					object obj25 = obj12;
					closedAsking = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v65+E4]");
					bool flag9 = (nint)0 == 0;
					object obj26 = !flag9;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num5 = UnityEngine.Random.Range(0.75f, 1.25f);
					object obj27 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v39+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
					object obj29 = 0;
					float num6 = num5 * 1.1339039E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v40+80]");
					object obj30 = 0;
					num = num6 + now;
					nextClosed = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AB8]");
					object obj31 = 0;
					Action<System.__Canon> action = default;
					action._002Ector((object)this, (IntPtr)obj31);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC0]");
					object obj32 = 0;
					Action<System.__Canon> action2 = default;
					action2._002Ector((object)this, (IntPtr)obj32);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X26_v4+18] (should have been resolved before IL gen)");
					float num3 = 1.1339039E+09f;
				}
			}
		}
		object obj33 = this + 40;
		bool flag10 = text == (string)obj33;
		bool flag11 = !flag10;
		object obj34 = !flag11;
		if (obj34 != null)
		{
			return;
		}
		object obj35 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj36 = !flag12;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string code = CodeOf(text);
		if (!ClosedNow(code, out var until, out var why))
		{
			return;
		}
		obj33 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AD8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AE0]");
		object obj38 = 0;
		string message = (string)obj37 + text + (string)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v21+E4]");
		bool flag13 = (nint)0 == 0;
		object obj41 = !flag13;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v1+8]");
		((NetworkBootstrap)0).KickFromRoom();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v32+E4]");
		bool flag14 = (nint)0 == 0;
		object obj44 = !flag14;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj45 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v36+E4]");
		bool flag15 = (nint)0 == 0;
		object obj46 = !flag15;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj45 = obj42;
		}
		object obj47 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v36+A0]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v26+E4]");
		bool flag16 = (nint)0 == 0;
		object obj49 = !flag16;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)obj48 == null;
		bool flag18 = !flag17;
		object obj50 = !flag18;
		if (obj50 == null)
		{
			object obj51 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v41+E4]");
			bool flag19 = (nint)0 == 0;
			object obj52 = !flag19;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long serverNowMs = ServerNowMs;
			long ms = until - serverNowMs;
			string text2 = Left(ms);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AE8]");
			object obj53 = 0;
			string bottom = (string)obj53 + text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AD0]");
			object top = 0;
			((GillaHud)obj48).Alert((string)top, bottom, 4f);
			bool flag20 = string.IsNullOrEmpty(why);
			bool flag21 = !flag20;
			object obj54 = !flag21;
			if (obj54 == null)
			{
				string bottom2 = why.ToUpperInvariant();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC8]");
				object top2 = 0;
				((GillaHud)obj48).Alert((string)top2, bottom2, 5f);
			}
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I4
		//IL_0914: Expected Obj, but got I
		//IL_091d: Expected Obj, but got I4
		//IL_0949: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_09fa: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0a21: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_0a42: Expected Obj, but got I
		//IL_0a6c: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_011a: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0211: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_0680: Expected Obj, but got I
		//IL_0690: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I4
		//IL_06bb: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_0778: Expected Obj, but got I
		//IL_079c: Expected I, but got Obj
		//IL_07aa: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I
		//IL_0703: Expected I, but got Obj
		//IL_0714: Expected I, but got Obj
		//IL_0732: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I
		//IL_07f1: Expected Obj, but got I4
		//IL_07fa: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I4
		//IL_08b7: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got I
		//IL_083a: Expected Obj, but got I
		//IL_0842: Expected I, but got Obj
		//IL_0853: Expected I, but got Obj
		//IL_0871: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+A0]");
		object obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+A0]");
		object obj11 = (nint)0 + (nint)40;
		obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v20+A0]");
		object obj14 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v20+A0]");
		object obj16 = (nint)0 + (nint)56;
		obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v26+A0]");
		object obj19 = (nint)0 + (nint)64;
		obj19 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v34+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v34+A0]");
		object obj22 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B08]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B10]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B00]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B18]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v34+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v34+A0]");
		object obj28 = (nint)0 + (nint)80;
		obj28 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<System.__Canon, bool> func = default;
		func._002Ector((object)null, (IntPtr)obj24);
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v25+A0]");
		object obj30 = (nint)0 + (nint)88;
		obj30 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon, System.__Canon> action = default;
		action._002Ector((object)null, (IntPtr)obj26);
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v26+A0]");
		object obj32 = (nint)0 + (nint)128;
		obj32 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v27+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v28+70]");
		((Dictionary<System.__Canon, (long, System.__Canon)>)0).Clear();
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v32+A0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDD8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AF0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B20]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B40]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v33+68]");
		((Dictionary<System.__Canon, float>)0).Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num = (nint)obj39;
		Action<System.__Canon, System.__Canon> action2 = default;
		action2._002Ector((object)null, (IntPtr)obj39);
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v36+A0]");
		object obj42 = (nint)0 + (nint)136;
		obj42 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj43 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v58+E4]");
		bool flag9 = (nint)0 == 0;
		object obj44 = !flag9;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v58+A0]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v54+8]");
		Func<bool> func2 = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v54+8]");
		bool flag10 = (nint)0 == 0;
		object obj46 = !flag10;
		object obj47 = 0;
		Action<System.__Canon, System.__Canon> action3 = action2;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v58+E4]");
			bool flag11 = (nint)0 == 0;
			object obj48 = !flag11;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj49 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v58+A0]");
				obj45 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B30]");
			object obj51 = 0;
			num = (nint)obj51;
			Func<bool> func3 = default;
			func3._002Ector(obj45, (IntPtr)obj51);
			object obj52 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v57+A0]");
			object obj53 = (nint)0 + (nint)8;
			obj53 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj47 = 0;
			action3 = (Action<System.__Canon, System.__Canon>)(object)func3;
			func2 = func3;
		}
		object obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AF8]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B28]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v61+E4]");
		bool flag12 = (nint)0 == 0;
		object obj57 = !flag12;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj54 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v61+A0]");
		object obj58 = (nint)0 + (nint)144;
		obj58 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num2 = (nint)obj56;
		Action<System.__Canon, System.__Canon> action4 = default;
		action4._002Ector((object)null, (IntPtr)obj56);
		object obj59 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v41+A0]");
		object obj60 = (nint)0 + (nint)152;
		obj60 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj61 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v71+E4]");
		bool flag13 = (nint)0 == 0;
		object obj62 = !flag13;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj61 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v71+A0]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v48+10]");
		Func<float> func4 = (Func<float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v48+10]");
		bool flag14 = (nint)0 == 0;
		object obj64 = !flag14;
		object obj65 = 0;
		Action<System.__Canon, System.__Canon> action5 = action4;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v71+E4]");
			bool flag15 = (nint)0 == 0;
			object obj66 = !flag15;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj67 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v52+A0]");
				obj63 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2890]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B38]");
			object obj69 = 0;
			num2 = (nint)obj69;
			Func<float> func5 = default;
			func5._002Ector(obj63, (IntPtr)obj69);
			object obj70 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v51+A0]");
			object obj71 = (nint)0 + (nint)16;
			obj71 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj65 = 0;
			action5 = (Action<System.__Canon, System.__Canon>)(object)func5;
			func4 = func5;
		}
		object obj72 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v74+E4]");
		bool flag16 = (nint)0 == 0;
		object obj73 = !flag16;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj72 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v74+A0]");
		object obj74 = (nint)0 + (nint)160;
		obj74 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj75 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v46+A0]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B808]");
		obj76 = 0;
		_ = 1114636288;
		_ = 0;
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B50]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+A0]");
		object obj10 = (nint)0 + (nint)16;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		LoadSaved();
	}

	public static long UntilOf(string value)
	{
		//IL_018e: Expected Obj, but got I4
		//IL_0197: Expected I8, but got I4
		//IL_0167: Expected I8, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_005b: Expected I8, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0154: Expected I8, but got I4
		bool flag = string.IsNullOrEmpty(value);
		bool flag2 = !flag;
		object obj = !flag2;
		long result = 0L;
		if (obj == null)
		{
			if (value == null)
			{
				goto IL_0159;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5968]");
			object obj2 = 0;
			bool flag3 = value.StartsWith((string)obj2);
			bool flag4 = !flag3;
			result = 0L;
			if (!flag4)
			{
				object obj3 = obj2;
				if (obj2 == null)
				{
					goto IL_0159;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+10]");
				string text = value.Substring(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B70]");
				object obj4 = 0;
				if (text == (string)obj4)
				{
					result = 9223372036854775807L;
				}
				else
				{
					bool flag5 = long.TryParse(text, out var result2);
					bool flag6 = !flag5;
					object obj5 = !flag6;
					object obj6 = ~obj5;
					result = ((obj6 != null) ? 0 : result2);
				}
			}
		}
		return result;
		IL_0159:
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	public static void CheckNow()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v1+10]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+10]");
			object obj11 = 0;
			_ = 0;
		}
	}

	public static void ResyncClock()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v1+10]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+10]");
			object obj11 = 0;
			_ = 0;
		}
	}

	public unsafe static void LoadSaved()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_00e5: Expected I8, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_0a22: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_06c7: Expected Obj, but got I4
		//IL_00d7: Expected I8, but got I4
		//IL_0a40: Expected Obj, but got I
		//IL_0687: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I4
		//IL_06f7: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I4
		//IL_0a7b: Expected Obj, but got I
		//IL_0254: Expected I8, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_0ae5: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_0796: Expected Obj, but got I4
		//IL_0246: Expected I8, but got I4
		//IL_0b03: Expected Obj, but got I
		//IL_0756: Expected Obj, but got I4
		//IL_075f: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_07ec: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got I
		//IL_081e: Expected Obj, but got I4
		//IL_0b3e: Expected Obj, but got I
		//IL_0425: Expected I8, but got I4
		//IL_0b9a: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I4
		//IL_0417: Expected I8, but got I4
		//IL_086c: Expected Obj, but got I4
		//IL_083d: Expected Obj, but got Ref
		//IL_0bb8: Expected Obj, but got I
		//IL_089c: Expected Obj, but got I4
		//IL_0bd2: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0904: Expected Obj, but got I4
		//IL_0c0d: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I
		//IL_096c: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_0992: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I4
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I
		//IL_0ca1: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B58]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = PlayerPrefs.GetString((string)key, (string)obj);
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj2 = 0;
			int num = text.IndexOf('|');
			if (num >= 1)
			{
				string s = text.Substring(0, num);
				bool flag = long.TryParse(s, out var result);
				bool flag2 = !flag;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					long num2 = result;
				}
				else
				{
					long num2 = 0L;
				}
				object obj5 = 0;
				object obj6 = 0;
				char c = (char)(ushort)(&result);
			}
			else
			{
				long num2 = 0L;
				object obj6 = 0;
				char c = '|';
			}
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v11+A0]");
			object obj11 = 0;
			string text3;
			if (num > 0)
			{
				int num3 = num + 1;
				string text2 = text.Substring(num3);
				obj9 = obj2;
				object obj6 = 0;
				char c = (char)num3;
				text3 = text2;
			}
			else
			{
				text3 = (string)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B68]");
			object key2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v18+A0]");
			object obj15 = (nint)0 + (nint)40;
			obj15 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text4 = PlayerPrefs.GetString((string)key2, (string)obj);
			if (text4 != null)
			{
				int num4 = text4.IndexOf('|');
				if (num4 >= 1)
				{
					string s2 = text4.Substring(0, num4);
					bool flag7 = long.TryParse(s2, out var result2);
					bool flag8 = !flag7;
					object obj16 = !flag8;
					object obj17 = ~obj16;
					if (obj17 == null)
					{
						long num5 = result2;
					}
					else
					{
						long num5 = 0L;
					}
					object obj5 = 0;
					object obj18 = 0;
					char c2 = (char)(ushort)(&result2);
				}
				else
				{
					long num5 = 0L;
					object obj18 = 0;
					char c2 = '|';
				}
				object obj19 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v26+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+A0]");
				object obj23 = 0;
				string text6;
				if (num4 > 0)
				{
					int num6 = num4 + 1;
					string text5 = text4.Substring(num6);
					obj21 = obj2;
					object obj18 = 0;
					char c2 = (char)num6;
					text6 = text5;
				}
				else
				{
					text6 = (string)obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v21+E4]");
				bool flag11 = (nint)0 == 0;
				object obj24 = !flag11;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B60]");
				object key3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v34+E4]");
				bool flag12 = (nint)0 == 0;
				object obj27 = !flag12;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj25 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v34+A0]");
				object obj28 = (nint)0 + (nint)56;
				obj28 = text6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text7 = PlayerPrefs.GetString((string)key3, (string)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				char[] array = default;
				if (array != null)
				{
					array[0] = '|';
					if (text7 != null)
					{
						string[] array2 = text7.Split(array, 3);
						if (array2 != null)
						{
							if (array2.Length == 3)
							{
								bool flag13 = long.TryParse(array2[0], out var result3);
								bool flag14 = !flag13;
								object obj29 = !flag14;
								object obj30 = ~obj29;
								if (obj30 == null)
								{
									long num7 = result3;
								}
								else
								{
									long num7 = 0L;
								}
								int num8 = 0;
								char[] array3 = (char[])(&result3);
							}
							else
							{
								long num7 = 0L;
								int num8 = 3;
								char[] array3 = array;
							}
							object obj31 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v45+E4]");
							bool flag15 = (nint)0 == 0;
							object obj32 = !flag15;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj33 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v51+E4]");
							bool flag16 = (nint)0 == 0;
							object obj34 = !flag16;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v51+A0]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v51+E4]");
							bool flag17 = (nint)0 == 0;
							object obj36 = !flag17;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v51+A0]");
							object obj37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v37+48]");
							object obj38;
							if ((nint)0 >= (nint)1)
							{
								obj38 = array2 + 40;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								obj38 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v51+E4]");
							bool flag18 = (nint)0 == 0;
							object obj39 = !flag18;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj40 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v55+E4]");
							bool flag19 = (nint)0 == 0;
							object obj41 = !flag19;
							if (obj41 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj40 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v55+A0]");
							object obj42 = (nint)0 + (nint)64;
							obj42 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj43 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v61+E4]");
							bool flag20 = (nint)0 == 0;
							object obj44 = !flag20;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj43 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v61+A0]");
							object obj45 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v46+48]");
							object obj50;
							if ((nint)0 >= (nint)1)
							{
								bool flag21 = array2.Length < 2;
								object obj46 = !flag21;
								object obj47 = array2.Length - 2;
								bool flag22 = obj47 == null;
								object obj48 = ~obj46;
								object obj49 = obj48 | flag22;
								if (obj49 != null)
								{
									goto IL_0649;
								}
								obj50 = array2 + 48;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								obj50 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v61+E4]");
							bool flag23 = (nint)0 == 0;
							object obj51 = !flag23;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj52 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v65+E4]");
							bool flag24 = (nint)0 == 0;
							object obj54 = !flag24;
							if (obj54 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj52 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v65+A0]");
							object obj55 = (nint)0 + (nint)80;
							obj55 = obj50;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj56 = obj2;
							object obj57 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v52+A0]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v69+E4]");
							bool flag25 = (nint)0 == 0;
							object obj59 = !flag25;
							if (obj59 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v53+10]");
							if (!((UnityEngine.Object)0 != null))
							{
								return;
							}
							object obj60 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v75+E4]");
							bool flag26 = (nint)0 == 0;
							object obj61 = !flag26;
							if (obj61 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj60 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v75+A0]");
							object obj62 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v56+10]");
							if ((nint)0 != 0)
							{
								_ = 0;
								_ = 0;
								return;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0649;
		IL_0649:
		throw new IndexOutOfRangeException();
	}

	private static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B58]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+20]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num = default;
			string text = num.ToString();
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v18+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v19+28]");
			string value = text + (string)obj11 + (string)0;
			PlayerPrefs.SetString((string)key, value);
		}
		else
		{
			PlayerPrefs.DeleteKey((string)key);
		}
		PlayerPrefs.Save();
	}

	private static void SaveKick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B68]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+30]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num = default;
			string text = num.ToString();
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v18+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v19+38]");
			string value = text + (string)obj11 + (string)0;
			PlayerPrefs.SetString((string)key, value);
		}
		else
		{
			PlayerPrefs.DeleteKey((string)key);
		}
		PlayerPrefs.Save();
	}

	private static void SaveRoomKick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I8
		//IL_013b: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I4
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I8
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_03b1: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B60]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+48]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num = default;
			string text = num.ToString();
			string[] array = default;
			if (array.Length != 0)
			{
				object obj12 = array + 32;
				obj12 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X20_v7-8]");
				object obj13 = 0 & 0xFFFFFFFEL;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
					object obj14 = 0;
					object obj15 = array + 40;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v29+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj;
					}
					bool flag6 = array.Length < 2;
					object obj18 = !flag6;
					object obj19 = array.Length - 2;
					bool flag7 = obj19 == null;
					object obj20 = ~obj18;
					object obj21 = obj20 | flag7;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v29+A0]");
						object obj22 = 0;
						object obj23 = array + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v26+40]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X20_v10-18]");
						object obj24 = 0 & 0xFFFFFFFCL;
						if (obj24 != null)
						{
							object obj25 = array + 56;
							obj25 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj26 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v37+E4]");
							bool flag8 = (nint)0 == 0;
							object obj27 = !flag8;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj26 = obj;
							}
							bool flag9 = array.Length < 4;
							object obj28 = !flag9;
							object obj29 = array.Length - 4;
							bool flag10 = obj29 == null;
							object obj30 = ~obj28;
							object obj31 = obj30 | flag10;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v37+A0]");
								object obj32 = 0;
								object obj33 = array + 64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v32+50]");
								obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string value = string.Concat(array);
								PlayerPrefs.SetString((string)key, value);
								goto IL_028c;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}
		PlayerPrefs.DeleteKey((string)key);
		goto IL_028c;
		IL_028c:
		PlayerPrefs.Save();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1333: Expected Obj, but got I4
		//IL_1351: Expected Obj, but got I
		//IL_1361: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_13d0: Expected Obj, but got I4
		//IL_1376: Expected Obj, but got I
		//IL_1398: Expected Obj, but got I4
		//IL_1bca: Expected Obj, but got I
		//IL_1bda: Expected Obj, but got I
		//IL_1c00: Expected Obj, but got I8
		//IL_1c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Expected Obj, but got Unknown
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected I8, but got Unknown
		//IL_1c7d: Expected Obj, but got I4
		//IL_1c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8a: Expected Obj, but got Unknown
		//IL_1c9a: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_1408: Expected Obj, but got I4
		//IL_1522: Expected Obj, but got I4
		//IL_1478: Expected Obj, but got I4
		//IL_1440: Expected Obj, but got I4
		//IL_1d23: Expected Obj, but got I
		//IL_1cdb: Expected Obj, but got I
		//IL_1cfd: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I4
		//IL_1632: Expected Obj, but got I4
		//IL_04ad: Expected Obj, but got I4
		//IL_1e32: Expected Obj, but got I
		//IL_1e50: Expected Obj, but got I8
		//IL_1e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e98: Expected Obj, but got Unknown
		//IL_1ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea5: Expected I8, but got Unknown
		//IL_1ecd: Expected Obj, but got I4
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eda: Expected I4, but got Unknown
		//IL_0526: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I4
		//IL_155a: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_15c2: Expected Obj, but got I4
		//IL_1d60: Expected Obj, but got I
		//IL_1d70: Expected Obj, but got I
		//IL_1496: Expected Obj, but got I
		//IL_14a6: Expected Obj, but got I
		//IL_09e9: Expected Obj, but got I4
		//IL_0745: Expected Obj, but got I
		//IL_077a: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I4
		//IL_1dc5: Expected Obj, but got I
		//IL_1dd5: Expected Obj, but got I
		//IL_1dff: Expected Obj, but got I4
		//IL_158a: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I
		//IL_039a: Invalid comparison between F4 and I
		//IL_1787: Expected Obj, but got I4
		//IL_1d91: Expected Obj, but got I
		//IL_1fc0: Expected Obj, but got I
		//IL_166a: Expected Obj, but got I4
		//IL_16da: Expected Obj, but got I4
		//IL_0e06: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_1f0b: Expected Obj, but got I
		//IL_1f1b: Expected Obj, but got I
		//IL_1f45: Expected Obj, but got I4
		//IL_1f78: Expected Obj, but got I
		//IL_1f9a: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I4
		//IL_14cc: Invalid comparison between F4 and Obj
		//IL_0c25: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got I4
		//IL_0a3b: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I
		//IL_193f: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I
		//IL_0abc: Expected Obj, but got I
		//IL_0ae6: Expected Obj, but got I4
		//IL_217e: Expected Obj, but got I
		//IL_15fa: Expected Obj, but got I4
		//IL_1897: Expected Obj, but got I4
		//IL_17bf: Expected Obj, but got I4
		//IL_0829: Expected Obj, but got I4
		//IL_0f55: Expected Obj, but got I4
		//IL_1e1d: Expected Obj, but got I
		//IL_20c7: Expected Obj, but got I
		//IL_20d7: Expected Obj, but got I
		//IL_2101: Expected Obj, but got I4
		//IL_1827: Expected Obj, but got I4
		//IL_1ff5: Expected Obj, but got I
		//IL_2005: Expected Obj, but got I
		//IL_0938: Expected Obj, but got I4
		//IL_0e61: Expected Obj, but got I4
		//IL_0640: Expected Obj, but got I
		//IL_0650: Expected Obj, but got I
		//IL_067a: Expected Obj, but got I4
		//IL_0cb4: Expected Obj, but got I
		//IL_205a: Expected Obj, but got I
		//IL_206a: Expected Obj, but got I
		//IL_2094: Expected Obj, but got I4
		//IL_17ef: Expected Obj, but got I4
		//IL_16a2: Expected Obj, but got I4
		//IL_16f8: Expected Obj, but got I
		//IL_1719: Expected Obj, but got I
		//IL_1729: Invalid comparison between F4 and I
		//IL_173f: Expected Obj, but got I
		//IL_1a4f: Expected Obj, but got I4
		//IL_2026: Expected Obj, but got I
		//IL_1f63: Expected Obj, but got I
		//IL_2282: Expected Obj, but got I
		//IL_1977: Expected Obj, but got I4
		//IL_0d09: Expected Obj, but got I4
		//IL_0873: Expected Obj, but got I
		//IL_21b3: Expected Obj, but got I
		//IL_0b8d: Expected Obj, but got I4
		//IL_0fb0: Expected Obj, but got I4
		//IL_18cf: Expected Obj, but got I4
		//IL_0ec4: Expected Obj, but got I4
		//IL_211f: Expected Obj, but got I
		//IL_2141: Expected Obj, but got I4
		//IL_185f: Expected Obj, but got I4
		//IL_1a87: Expected Obj, but got I4
		//IL_20b2: Expected Obj, but got I
		//IL_22b7: Expected Obj, but got I
		//IL_19af: Expected Obj, but got I4
		//IL_0d6c: Expected Obj, but got I4
		//IL_0bd6: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I
		//IL_0c10: Expected Obj, but got I4
		//IL_107a: Expected Obj, but got I4
		//IL_21f0: Expected Obj, but got I
		//IL_2200: Expected Obj, but got I
		//IL_19df: Expected Obj, but got I4
		//IL_1907: Expected Obj, but got I4
		//IL_1b04: Expected Obj, but got I4
		//IL_2221: Expected Obj, but got I
		//IL_2169: Expected Obj, but got I
		//IL_22ed: Expected Obj, but got I
		//IL_102c: Expected Obj, but got I4
		//IL_1a17: Expected Obj, but got I4
		//IL_0db5: Expected Obj, but got I
		//IL_0dd2: Expected Obj, but got I
		//IL_1aa5: Expected Obj, but got I
		//IL_1ac6: Invalid comparison between F4 and I
		//IL_224e: Expected Obj, but got I
		//IL_10dd: Expected Obj, but got I4
		//IL_112d: Expected Obj, but got I4
		//IL_1b3c: Expected Obj, but got I4
		//IL_2322: Expected Obj, but got I
		//IL_1188: Expected Obj, but got I4
		//IL_11ba: Expected Obj, but got I
		//IL_11e4: Expected Obj, but got I4
		//IL_1b74: Expected Obj, but got I4
		//IL_2356: Expected Obj, but got I
		//IL_2366: Expected Obj, but got I
		//IL_2390: Expected Obj, but got I4
		//IL_1281: Expected Obj, but got I4
		//IL_1bac: Expected Obj, but got I4
		//IL_23ae: Expected Obj, but got I
		//IL_12ca: Expected Obj, but got I
		//IL_12da: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+28]");
		UnityEngine.Object obj6 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ X8_v5+18] (should have been resolved before IL gen)");
		object obj8 = default;
		object obj7 = obj8 & 1;
		if (obj7 != null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v414+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v414+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v247+A8]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				bool flag4 = (byte)(~(askingTime ? 1u : 0u)) != 0;
				object obj13 = !flag4;
				if (obj13 == null && !(unscaledTime < nextTime))
				{
					SyncClock();
				}
			}
			bool flag5 = (byte)(~(asking ? 1u : 0u)) != 0;
			object obj14 = !flag5;
			if (obj14 == null && !(unscaledTime < nextCheck))
			{
				Check();
			}
		}
		WatchClosed(unscaledTime);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v15+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj20 = 0;
		long serverNowMs = ServerNowMs;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v12+20]");
		object obj22 = -serverNowMs;
		bool flag8 = (nint)obj22 < 0;
		bool flag9 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v12+20]");
		long num = 0 ^ serverNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v12+20]");
		object obj23 = 0 ^ obj22;
		long num2 = num & obj23;
		bool flag10 = num2 < 0;
		bool flag11 = flag8 == flag10;
		object obj24 = !flag9;
		object obj25 = flag11 & obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v13+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v14+18]");
		float num3;
		if (0 == (nint)obj25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v12+20]");
			if (0 > serverNowMs)
			{
				goto IL_13de;
			}
			num3 = unscaledTime;
		}
		else
		{
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v343+E4]");
			bool flag12 = (nint)0 == 0;
			object obj28 = !flag12;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v345+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v12+20]");
			if (0 > serverNowMs)
			{
				told = false;
				goto IL_13de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v345+E4]");
			bool flag13 = (nint)0 == 0;
			object obj31 = !flag13;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v349+E4]");
			bool flag14 = (nint)0 == 0;
			object obj33 = !flag14;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v349+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v213+20]");
			bool flag15 = (nint)0 == 0;
			string text = (string)(object)obj6;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v349+E4]");
				bool flag16 = (nint)0 == 0;
				object obj35 = !flag16;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v385+E4]");
				bool flag17 = (nint)0 == 0;
				object obj37 = !flag17;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj36 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v385+A0]");
				object obj39 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v385+E4]");
				bool flag18 = (nint)0 == 0;
				object obj40 = !flag18;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj36 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v385+A0]");
				object obj41 = (nint)0 + (nint)40;
				obj41 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Save();
				text = (string)obj38;
			}
			if (~(told ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj42 = 0;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v352+E4]");
				bool flag19 = (nint)0 == 0;
				object obj44 = !flag19;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj45 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v356+E4]");
				bool flag20 = (nint)0 == 0;
				object obj46 = !flag20;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj45 = obj42;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v356+A0]");
				object obj48 = 0;
				object obj49 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v224+E4]");
				bool flag21 = (nint)0 == 0;
				object obj50 = !flag21;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = (UnityEngine.Object)obj48 != null;
				bool flag23 = !flag22;
				string text2 = null;
				text = null;
				if (!flag23)
				{
					object obj51 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v360+E4]");
					bool flag24 = (nint)0 == 0;
					object obj52 = !flag24;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj53 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v364+E4]");
					bool flag25 = (nint)0 == 0;
					object obj54 = !flag25;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj53 = obj42;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v364+A0]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B80]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B90]");
					object obj57 = 0;
					text = (string)obj56;
					text2 = (string)obj57;
					((GillaHud)obj55).Show((string)obj56, (string)obj57);
					object obj58 = 0;
				}
			}
			told = false;
			num3 = unscaledTime;
			obj6 = (UnityEngine.Object)(object)text;
		}
		goto IL_1416;
		IL_1416:
		object obj59 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v19+E4]");
		bool flag26 = (nint)0 == 0;
		object obj60 = !flag26;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj61 = 109895680;
		object obj62 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v23+E4]");
		bool flag27 = (nint)0 == 0;
		object obj63 = !flag27;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj62 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v23+A0]");
		object obj64 = 0;
		long serverNowMs2 = ServerNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v20+30]");
		object obj65 = -serverNowMs2;
		bool flag28 = (nint)obj65 < 0;
		bool flag29 = obj65 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v20+30]");
		long num4 = 0 ^ serverNowMs2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v20+30]");
		object obj66 = 0 ^ obj65;
		long num5 = num4 & obj66;
		bool flag30 = num5 < 0;
		bool flag31 = flag28 == flag30;
		object obj67 = !flag29;
		bool flag32 = (byte)((flag31 & obj67) ? 1 : 0) != 0;
		string text3;
		if (wasKicked == flag32)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v20+30]");
			if (0 > serverNowMs2)
			{
				goto IL_0882;
			}
			text3 = (string)(object)obj6;
		}
		else
		{
			wasKicked = flag32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v20+30]");
			string text2;
			if (0 > serverNowMs2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj68 = 0;
				kickTold = false;
				object obj69 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v285+E4]");
				bool flag33 = (nint)0 == 0;
				object obj70 = !flag33;
				if (obj70 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj71 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v289+E4]");
				bool flag34 = (nint)0 == 0;
				object obj72 = !flag34;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj71 = obj68;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v289+A0]");
				object obj74 = 0;
				object obj75 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v181+E4]");
				bool flag35 = (nint)0 == 0;
				object obj76 = !flag35;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v23+8]");
				bool flag36 = (UnityEngine.Object)0 != null;
				bool flag37 = !flag36;
				text2 = null;
				obj6 = null;
				if (!flag37)
				{
					object obj77 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X0_v293+E4]");
					bool flag38 = (nint)0 == 0;
					object obj78 = !flag38;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj79 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v297+E4]");
					bool flag39 = (nint)0 == 0;
					object obj80 = !flag39;
					if (obj80 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj79 = obj68;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v297+A0]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v186+8]");
					((NetworkBootstrap)0).Kick();
					text2 = null;
					obj6 = null;
				}
				goto IL_0882;
			}
			object obj82 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v185+E4]");
			bool flag40 = (nint)0 == 0;
			object obj83 = !flag40;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X21_v5+507]");
			bool flag41 = (nint)0 == 0;
			object obj84 = !flag41;
			if (obj84 == null)
			{
				_ = 1;
			}
			object obj85 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v189+E4]");
			bool flag42 = (nint)0 == 0;
			object obj86 = !flag42;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj85 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v189+A0]");
			object obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v120+30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v189+E4]");
				bool flag43 = (nint)0 == 0;
				object obj88 = !flag43;
				if (obj88 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj89 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v264+E4]");
				bool flag44 = (nint)0 == 0;
				object obj90 = !flag44;
				if (obj90 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj89 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj91 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v264+A0]");
				object obj92 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v264+E4]");
				bool flag45 = (nint)0 == 0;
				object obj93 = !flag45;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj89 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v264+A0]");
				object obj94 = (nint)0 + (nint)56;
				obj94 = obj91;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				SaveKick();
				obj6 = (UnityEngine.Object)obj91;
			}
			bool flag46 = (byte)(~(kickTold ? 1u : 0u)) != 0;
			string text4 = (string)(object)obj6;
			if (!flag46)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj95 = 0;
				object obj96 = obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X0_v231+E4]");
				bool flag47 = (nint)0 == 0;
				object obj97 = !flag47;
				if (obj97 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj98 = obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X0_v235+E4]");
				bool flag48 = (nint)0 == 0;
				object obj99 = !flag48;
				if (obj99 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj98 = obj95;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X0_v235+A0]");
				object obj101 = 0;
				object obj102 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X8_v154+E4]");
				bool flag49 = (nint)0 == 0;
				object obj103 = !flag49;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag50 = (UnityEngine.Object)obj101 != null;
				bool flag51 = !flag50;
				text2 = null;
				text4 = null;
				if (!flag51)
				{
					object obj104 = obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v239+E4]");
					bool flag52 = (nint)0 == 0;
					object obj105 = !flag52;
					if (obj105 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj106 = obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1465 @ X0_v243+E4]");
					bool flag53 = (nint)0 == 0;
					object obj107 = !flag53;
					if (obj107 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj106 = obj95;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1465 @ X0_v243+A0]");
					object obj108 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B98]");
					object obj109 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BA0]");
					object obj110 = 0;
					text4 = (string)obj109;
					text2 = (string)obj110;
					((GillaHud)obj108).Show((string)obj109, (string)obj110);
					object obj58 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj111 = 0;
			kickTold = false;
			object obj112 = obj111;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X0_v192+E4]");
			bool flag54 = (nint)0 == 0;
			object obj113 = !flag54;
			if (obj113 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj114 = obj111;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v196+E4]");
			bool flag55 = (nint)0 == 0;
			object obj115 = !flag55;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj114 = obj111;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj116 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v196+A0]");
			object obj117 = 0;
			object obj118 = obj116;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v131+E4]");
			bool flag56 = (nint)0 == 0;
			object obj119 = !flag56;
			if (obj119 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X9_v18+8]");
			bool flag57 = (UnityEngine.Object)0 != null;
			bool flag58 = !flag57;
			text2 = null;
			text3 = null;
			if (!flag58)
			{
				object obj120 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ X0_v200+E4]");
				bool flag59 = (nint)0 == 0;
				object obj121 = !flag59;
				if (obj121 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj122 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v204+E4]");
				bool flag60 = (nint)0 == 0;
				object obj123 = !flag60;
				if (obj123 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj122 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v204+A0]");
				object obj124 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v136+11]");
				bool flag61 = (nint)0 == 0;
				object obj125 = !flag61;
				text2 = null;
				text3 = null;
				if (obj125 == null)
				{
					object obj126 = obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X0_v205+E4]");
					bool flag62 = (nint)0 == 0;
					object obj127 = !flag62;
					if (obj127 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj128 = obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ X0_v209+E4]");
					bool flag63 = (nint)0 == 0;
					object obj129 = !flag63;
					if (obj129 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj128 = obj111;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ X0_v209+A0]");
					object obj130 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj131 = 0;
					text3 = (string)obj131;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v142+8]");
					((NetworkBootstrap)0).JoinRoom((string)obj131);
					text2 = null;
				}
			}
		}
		goto IL_0ddc;
		IL_0882:
		object obj132 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v168+E4]");
		bool flag64 = (nint)0 == 0;
		object obj133 = !flag64;
		if (obj133 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj134 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v172+E4]");
		bool flag65 = (nint)0 == 0;
		object obj135 = !flag65;
		if (obj135 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj134 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v172+A0]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X8_v109+11]");
		bool flag66 = (nint)0 == 0;
		object obj137 = !flag66;
		text3 = (string)(object)obj6;
		object obj139 = default;
		if (obj137 == null)
		{
			bool flag67 = (byte)(~(kickTold ? 1u : 0u)) != 0;
			object obj138 = obj139;
			float num6 = num3;
			if (!flag67)
			{
				object obj140 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v176+E4]");
				bool flag68 = (nint)0 == 0;
				object obj141 = !flag68;
				if (obj141 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj140 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v176+A0]");
				object obj142 = 0;
				num6 = unscaledTime - kickToldAt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v114+8]");
				obj138 = 0;
				float num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v114+8]");
				bool flag69 = num7 < 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v114+8]");
				obj139 = 0;
				num3 = num6;
				text3 = (string)(object)obj6;
				if (flag69)
				{
					goto IL_0ddc;
				}
			}
			TellKick();
			obj139 = obj138;
			num3 = num6;
			text3 = (string)(object)obj6;
		}
		goto IL_0ddc;
		IL_12f0:
		banTold = false;
		return;
		IL_0ddc:
		object obj143 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v26+E4]");
		bool flag70 = (nint)0 == 0;
		object obj144 = !flag70;
		if (obj144 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj145 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v30+E4]");
		bool flag71 = (nint)0 == 0;
		object obj146 = !flag71;
		if (obj146 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj145 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v30+A0]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X8_v27+48]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v30+E4]");
			bool flag72 = (nint)0 == 0;
			object obj148 = !flag72;
			if (obj148 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj149 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X0_v121+E4]");
			bool flag73 = (nint)0 == 0;
			object obj150 = !flag73;
			if (obj150 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj149 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X0_v121+A0]");
			object obj151 = 0;
			long serverNowMs3 = ServerNowMs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X8_v87+48]");
			if (0 <= serverNowMs3)
			{
				object obj152 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v123+E4]");
				bool flag74 = (nint)0 == 0;
				object obj153 = !flag74;
				if (obj153 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj154 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v129+E4]");
				bool flag75 = (nint)0 == 0;
				object obj155 = !flag75;
				if (obj155 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj154 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj156 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v129+A0]");
				object obj157 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v129+E4]");
				bool flag76 = (nint)0 == 0;
				object obj158 = !flag76;
				if (obj158 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj154 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X0_v129+A0]");
				object obj159 = (nint)0 + (nint)80;
				obj159 = obj156;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj160 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X0_v135+E4]");
				bool flag77 = (nint)0 == 0;
				object obj161 = !flag77;
				if (obj161 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj160 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X0_v135+A0]");
				object obj162 = (nint)0 + (nint)64;
				obj162 = obj156;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				SaveRoomKick();
				text3 = (string)obj156;
			}
		}
		object obj163 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X0_v32+E4]");
		bool flag78 = (nint)0 == 0;
		object obj164 = !flag78;
		if (obj164 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj165 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v36+E4]");
		bool flag79 = (nint)0 == 0;
		object obj166 = !flag79;
		if (obj166 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj165 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v36+A0]");
		object obj167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v34+11]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v36+E4]");
			bool flag80 = (nint)0 == 0;
			object obj168 = !flag80;
			if (obj168 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj169 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X0_v42+E4]");
			bool flag81 = (nint)0 == 0;
			object obj170 = !flag81;
			if (obj170 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj169 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X0_v42+A0]");
			object obj171 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v42+20]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X0_v42+E4]");
				bool flag82 = (nint)0 == 0;
				object obj172 = !flag82;
				if (obj172 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj173 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X0_v46+E4]");
				bool flag83 = (nint)0 == 0;
				object obj174 = !flag83;
				if (obj174 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj173 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X0_v46+A0]");
				object obj175 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X8_v48+18]");
				if ((nint)0 >= (nint)1)
				{
					object obj176 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1538 @ X0_v48+E4]");
					bool flag84 = (nint)0 == 0;
					object obj177 = !flag84;
					if (obj177 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long serverNowMs4 = ServerNowMs;
					object obj178 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X8_v51+E4]");
					bool flag85 = (nint)0 == 0;
					object obj179 = !flag85;
					if (obj179 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj180 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v53+E4]");
					bool flag86 = (nint)0 == 0;
					object obj181 = !flag86;
					if (obj181 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj180 = obj20;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v53+A0]");
					object obj182 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1564 @ X8_v55+18]");
					if (serverNowMs4 >= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v53+E4]");
						bool flag87 = (nint)0 == 0;
						object obj183 = !flag87;
						if (obj183 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaCloud.Unban();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
						object obj184 = 0;
						object obj185 = obj184;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ X0_v56+E4]");
						bool flag88 = (nint)0 == 0;
						object obj186 = !flag88;
						if (obj186 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj187 = obj184;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X0_v60+E4]");
						bool flag89 = (nint)0 == 0;
						object obj188 = !flag89;
						if (obj188 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj187 = obj184;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj189 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X0_v60+A0]");
						object obj190 = 0;
						object obj191 = obj189;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ X8_v64+E4]");
						bool flag90 = (nint)0 == 0;
						object obj192 = !flag90;
						if (obj192 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)obj190 != null)
						{
							object obj193 = obj184;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ X0_v64+E4]");
							bool flag91 = (nint)0 == 0;
							object obj194 = !flag91;
							if (obj194 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj195 = obj184;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v68+E4]");
							bool flag92 = (nint)0 == 0;
							object obj196 = !flag92;
							if (obj196 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj195 = obj184;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v68+A0]");
							object obj197 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B78]");
							object top = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B88]");
							object bottom = 0;
							((GillaHud)obj197).Show((string)top, (string)bottom);
						}
						goto IL_12f0;
					}
				}
			}
			if (~(banTold ? 1u : 0u) == 0)
			{
				object obj198 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X0_v103+E4]");
				bool flag93 = (nint)0 == 0;
				object obj199 = !flag93;
				if (obj199 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj198 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X0_v103+A0]");
				object obj200 = 0;
				float num8 = unscaledTime - banToldAt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v80+8]");
				if (num8 < 0f)
				{
					return;
				}
			}
			TellBan();
			return;
		}
		goto IL_12f0;
		IL_040d:
		Tell();
		object obj201;
		obj139 = obj201;
		float num9;
		num3 = num9;
		UnityEngine.Object obj202;
		obj6 = obj202;
		goto IL_1416;
		IL_13de:
		object obj203 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v320+E4]");
		bool flag94 = (nint)0 == 0;
		object obj204 = !flag94;
		if (obj204 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj205 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v324+E4]");
		bool flag95 = (nint)0 == 0;
		object obj206 = !flag95;
		if (obj206 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj205 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v324+A0]");
		object obj207 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v195+11]");
		bool flag96 = (nint)0 == 0;
		object obj208 = !flag96;
		num3 = unscaledTime;
		if (obj208 == null)
		{
			bool flag97 = (byte)(~(told ? 1u : 0u)) != 0;
			obj201 = obj139;
			num9 = unscaledTime;
			obj202 = obj6;
			if (flag97)
			{
				goto IL_040d;
			}
			object obj209 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v328+E4]");
			bool flag98 = (nint)0 == 0;
			object obj210 = !flag98;
			if (obj210 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj209 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v328+A0]");
			object obj211 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v200+A0]");
			object obj212 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v201+28]");
			obj6 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X8_v201+18] (should have been resolved before IL gen)");
			object obj213 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v331+A0]");
			object obj214 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v203+4]");
			obj139 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v203+4]");
			bool flag99 = unscaledTime < 0f;
			num3 = unscaledTime;
			if (!flag99)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v331+E4]");
				bool flag100 = (nint)0 == 0;
				object obj215 = !flag100;
				if (obj215 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj216 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v204+A0]");
					obj214 = 0;
				}
				num9 = unscaledTime - toldAt;
				obj201 = obj214;
				bool flag101 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj214);
				obj202 = obj6;
				obj139 = obj214;
				num3 = num9;
				if (!flag101)
				{
					goto IL_040d;
				}
			}
		}
		goto IL_1416;
	}

	private void Tell()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BD8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v15+A0]");
		object obj17 = 0;
		long serverNowMs = ServerNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v13+20]");
		long ms = -serverNowMs;
		string text = Left(ms);
		string bottom = (string)obj15 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BE0]");
		object top = 0;
		((GillaHud)obj8).Alert((string)top, bottom, 4f);
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v26+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v21+28]");
		bool flag9 = string.IsNullOrEmpty((string)0);
		bool flag10 = !flag9;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v31+E4]");
			bool flag11 = (nint)0 == 0;
			object obj23 = !flag11;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v35+E4]");
			bool flag12 = (nint)0 == 0;
			object obj25 = !flag12;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v35+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v28+28]");
			string bottom2 = ((string)0).ToUpperInvariant();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC8]");
			object top2 = 0;
			((GillaHud)obj8).Alert((string)top2, bottom2, 5f);
		}
		told = true;
		float unscaledTime = Time.unscaledTime;
		toldAt = unscaledTime;
	}

	private void TellBan()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I4
		//IL_0589: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		//IL_04fb: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06bd: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I4
		//IL_06db: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v15+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13+20]");
		object obj17;
		string bottom;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFB8]");
			obj17 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v53+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v53+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v40+18]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v53+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj23 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v58+E4]");
				bool flag11 = (nint)0 == 0;
				object obj24 = !flag11;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v58+A0]");
				object obj26 = 0;
				object obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v50+E4]");
				bool flag12 = (nint)0 == 0;
				object obj28 = !flag12;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				long serverNowMs = ServerNowMs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v5+18]");
				long ms = -serverNowMs;
				string text = Left(ms);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA8]");
				object obj29 = 0;
				string text2 = (string)obj29 + text;
				bottom = text2;
				goto IL_0235;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFB0]");
			obj17 = 0;
		}
		bottom = (string)obj17;
		bool flag13 = obj8 == null;
		object obj30 = !flag13;
		if (obj30 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0235;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BF0]");
		object top = 0;
		((GillaHud)obj8).Alert((string)top, bottom, 4f);
		object obj31 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v21+E4]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v25+E4]");
		bool flag15 = (nint)0 == 0;
		object obj34 = !flag15;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v25+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v24+28]");
		bool flag16 = string.IsNullOrEmpty((string)0);
		bool flag17 = !flag16;
		object obj36 = !flag17;
		if (obj36 == null)
		{
			object obj37 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v30+E4]");
			bool flag18 = (nint)0 == 0;
			object obj38 = !flag18;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj39 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v34+E4]");
			bool flag19 = (nint)0 == 0;
			object obj40 = !flag19;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v34+A0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v31+28]");
			string bottom2 = ((string)0).ToUpperInvariant();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC8]");
			object top2 = 0;
			((GillaHud)obj8).Alert((string)top2, bottom2, 5f);
		}
		banTold = true;
		float unscaledTime = Time.unscaledTime;
		banToldAt = unscaledTime;
	}

	private void TellKick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v15+A0]");
		object obj17 = 0;
		long serverNowMs = ServerNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v13+30]");
		long ms = -serverNowMs;
		string text = Left(ms);
		string bottom = (string)obj15 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BE8]");
		object top = 0;
		((GillaHud)obj8).Alert((string)top, bottom, 4f);
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v26+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v21+38]");
		bool flag9 = string.IsNullOrEmpty((string)0);
		bool flag10 = !flag9;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v31+E4]");
			bool flag11 = (nint)0 == 0;
			object obj23 = !flag11;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v35+E4]");
			bool flag12 = (nint)0 == 0;
			object obj25 = !flag12;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v35+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v28+38]");
			string bottom2 = ((string)0).ToUpperInvariant();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC8]");
			object top2 = 0;
			((GillaHud)obj8).Alert((string)top2, bottom2, 5f);
		}
		kickTold = true;
		float unscaledTime = Time.unscaledTime;
		kickToldAt = unscaledTime;
	}

	private static void TellRoomKick(string top)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AE8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v15+A0]");
		object obj17 = 0;
		long serverNowMs = ServerNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v13+48]");
		long ms = -serverNowMs;
		string text = Left(ms);
		string bottom = (string)obj15 + text;
		((GillaHud)obj8).Alert(top, bottom, 4f);
		object obj18 = 109895680;
		object obj19 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v26+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v19+50]");
		if (!string.IsNullOrEmpty((string)0))
		{
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X20_v5+B5D]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				_ = 1;
			}
			object obj25 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v33+E4]");
			bool flag11 = (nint)0 == 0;
			object obj26 = !flag11;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj25 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v33+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v24+50]");
			string bottom2 = ((string)0).ToUpperInvariant();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AC8]");
			object top2 = 0;
			((GillaHud)obj8).Alert((string)top2, bottom2, 5f);
		}
	}

	public static void SayKeptOut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_02a5: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13+61]");
		object top;
		object bottom;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v25+A0]");
				obj10 = 0;
			}
			object obj14 = obj11;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v25+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj8 != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BF8]");
			top = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C18]");
			bottom = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+A0]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13+60]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C00]");
				object top2 = 0;
				TellRoomKick((string)top2);
				return;
			}
			object obj18 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj8 != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C10]");
			top = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C08]");
			bottom = 0;
		}
		((GillaHud)obj8).Alert((string)top, (string)bottom, 4f);
	}

	public static string Left(long ms)
	{
		//IL_0010: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I8
		//IL_0057: Expected I8, but got Obj
		//IL_0065: Expected I8, but got I4
		//IL_0098: Expected Obj, but got I8
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I8, but got Unknown
		//IL_0148: Expected I8, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = ms + 59999;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
		object obj5 = obj4 >> 14;
		long val = (long)(obj5 + obj4);
		long num = Math.Max(1L, val);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
		long num2 = 12810238940076077L + 3279421168659475843L;
		object obj6 = num2 * 1440;
		object obj7 = num - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
		object obj8 = obj7 * 4294936713L;
		object obj10 = default;
		object obj9 = obj10 + num;
		object obj11 = obj9 >> 5;
		object obj12 = obj7 + obj8;
		object obj13 = obj11 + obj9;
		object obj14 = obj12 >> 5;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj12 & 0x8000;
		object obj17 = obj13 * 60;
		long num3 = num - obj17;
		long num4 = (long)(obj15 + obj16);
		string text2;
		string text3;
		string text4;
		long num6 = default;
		object obj19;
		object obj20;
		if (num >= 1440)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A20]");
			object obj18 = 0;
			long num5 = default;
			string text = num5.ToString();
			text2 = (string)obj18;
			bool flag2 = num4 <= 0;
			text3 = text;
			if (flag2)
			{
				goto IL_0290;
			}
			text4 = num6.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC138]");
			obj20 = 0;
			text3 = text;
		}
		else
		{
			long num7 = default;
			if ((nint)obj7 < 60)
			{
				string text5 = num7.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A28]");
				object obj21 = 0;
				return text5 + (string)obj21;
			}
			string text6 = num6.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC138]");
			object obj22 = 0;
			text2 = (string)obj22;
			bool flag3 = num3 <= 0;
			text3 = text6;
			if (flag3)
			{
				goto IL_0290;
			}
			text4 = num7.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A28]");
			obj20 = 0;
			text3 = text6;
		}
		string text7 = (string)obj19 + text4 + (string)obj20;
		string text8 = text7;
		goto IL_033f;
		IL_0290:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj23 = 0;
		text8 = (string)obj23;
		goto IL_033f;
		IL_033f:
		return text3 + text2 + text8;
	}

	private void Check()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_003a: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		Action<System.__Canon> action = default;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BC0]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BC8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BD0]");
			object obj6 = 0;
			asking = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+88]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			action._002Ector((object)this, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			action2._002Ector((object)this, (IntPtr)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private void SyncClock()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_003a: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		Action<long> action = default;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BA8]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BB0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BB8]");
			object obj6 = 0;
			askingTime = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+98]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			action._002Ector((object)this, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			action2._002Ector((object)this, (IntPtr)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v1+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	private static void ReadFromPlayFab(Action<Dictionary<string, string>> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_01b1: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE20]");
		object obj6 = 0;
		object obj7 = obj2 + 16;
		obj7 = done;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj2 + 24;
		obj8 = failed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v15+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+C0]");
		List<System.__Canon> list = default;
		list._002Ector((IEnumerable<System.__Canon>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C30]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj16 = 0;
		object obj17 = getUserDataRequest + 32;
		obj17 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj15);
		object obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj19 = !flag2;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserReadOnlyData(getUserDataRequest, (Action<GetUserDataResult>)action, (Action<PlayFabError>)action2);
	}

	public static string ValueOf(GetUserDataResult result, string key)
	{
		//IL_0099: Expected Obj, but got I
		if (result == null)
		{
			goto IL_009e;
		}
		bool flag = (object)result.Data == null;
		string result2 = result.Data;
		if (!flag)
		{
			if (!((Dictionary<System.__Canon, System.__Canon>)(object)result.Data).TryGetValue((System.__Canon)(object)key, out System.__Canon value) || value == null)
			{
				goto IL_009e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-28_v4 (System.__Canon)+20]");
			result2 = (string)0;
		}
		goto IL_00c5;
		IL_00c5:
		return result2;
		IL_009e:
		result2 = null;
		goto IL_00c5;
	}

	private static void TimeFromPlayFab(Action<long> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C48]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C58]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj8 = 0;
		object obj9 = obj2 + 16;
		obj9 = done;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2 + 24;
		obj10 = failed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetTimeRequest getTimeRequest = default;
		getTimeRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj7);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetTime(getTimeRequest, (Action<GetTimeResult>)action, (Action<PlayFabError>)action2);
	}

	public GillaModeration()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		nextClosed = -1f;
		object obj2 = this + 40;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaModeration()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_090d: Expected Obj, but got I
		//IL_091d: Expected Obj, but got I
		//IL_092d: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I
		//IL_095b: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I
		//IL_09d1: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_0237: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02a4: Expected I, but got Obj
		//IL_02c7: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_09f8: Expected Obj, but got I
		//IL_0a13: Expected I, but got Obj
		//IL_0a31: Expected Obj, but got I
		//IL_0340: Expected I, but got Obj
		//IL_0363: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03cd: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0490: Expected Obj, but got I8
		//IL_04bd: Expected Obj, but got I
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0558: Expected Obj, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_0592: Expected Obj, but got I8
		//IL_05bf: Expected Obj, but got I
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_0601: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_065a: Expected Obj, but got I
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_069c: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_06f5: Expected Obj, but got I
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected Obj, but got Unknown
		//IL_0737: Expected Obj, but got I4
		//IL_074d: Expected Obj, but got I
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_0790: Expected Obj, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I8
		//IL_07f7: Expected Obj, but got I
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I4
		//IL_084f: Expected Obj, but got I
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0892: Expected Obj, but got I
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected Obj, but got Unknown
		//IL_08d0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B08]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFF8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C78]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AF8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B28]");
		object obj10 = 0;
		object obj11 = obj;
		_ = 1114636288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B808]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+A0]");
		object obj13 = (nint)0 + (nint)40;
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+A0]");
		object obj15 = (nint)0 + (nint)56;
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+A0]");
		object obj17 = (nint)0 + (nint)64;
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v8+A0]");
		object obj19 = (nint)0 + (nint)80;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<System.__Canon, bool> func = default;
		func._002Ector((object)null, (IntPtr)obj4);
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v9+A0]");
		object obj21 = (nint)0 + (nint)88;
		obj21 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary = default;
		dictionary._002Ector();
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v10+A0]");
		object obj23 = (nint)0 + (nint)104;
		obj23 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C68]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, (long, System.__Canon)> dictionary2 = default;
		dictionary2._002Ector();
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v15+A0]");
		object obj26 = (nint)0 + (nint)112;
		obj26 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C70]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C98]");
		object pattern = 0;
		Regex regex = default;
		regex._002Ector((string)pattern);
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v20+A0]");
		object obj29 = (nint)0 + (nint)120;
		obj29 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B00]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B18]");
		object obj31 = 0;
		Action<System.__Canon, System.__Canon> action = default;
		action._002Ector((object)null, (IntPtr)obj31);
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v25+A0]");
		object obj33 = (nint)0 + (nint)128;
		obj33 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AF0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2B20]");
		object obj35 = 0;
		Action<System.__Canon, System.__Canon> action2 = default;
		action2._002Ector((object)null, (IntPtr)obj35);
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v30+A0]");
		object obj37 = (nint)0 + (nint)136;
		obj37 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj38 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v45+E4]");
		bool flag = (nint)0 == 0;
		object obj39 = !flag;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v45+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<bool> func2 = default;
		func2._002Ector(obj40, (IntPtr)obj8);
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v33+A0]");
		object obj42 = (nint)0 + (nint)144;
		obj42 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon, System.__Canon> action3 = default;
		action3._002Ector((object)null, (IntPtr)obj10);
		object obj43 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v34+A0]");
		object obj44 = (nint)0 + (nint)152;
		obj44 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj45 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v35+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2890]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C80]");
		object obj48 = 0;
		Func<float> func3 = default;
		func3._002Ector(obj46, (IntPtr)obj48);
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v41+A0]");
		object obj50 = (nint)0 + (nint)160;
		obj50 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v62+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D8]");
			object obj52 = 0;
			object obj54 = default;
			object obj53 = obj54 + 32;
			obj53 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X20_v8-8]");
			object obj55 = 0 & 0xFFFFFFFEL;
			if (obj55 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CC0]");
				object obj56 = 0;
				object obj57 = obj54 + 40;
				obj57 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X20_v10-10]");
				bool flag2 = (nint)0 < (nint)2;
				object obj58 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X20_v10-10]");
				object obj59 = -2;
				bool flag3 = obj59 == null;
				object obj60 = ~obj58;
				object obj61 = obj60 | flag3;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59E0]");
					object obj62 = 0;
					object obj63 = obj54 + 48;
					obj63 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X20_v12-18]");
					object obj64 = 0 & 0xFFFFFFFCL;
					if (obj64 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C88]");
						object obj65 = 0;
						object obj66 = obj54 + 56;
						obj66 = obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X20_v14-20]");
						bool flag4 = (nint)0 < (nint)4;
						object obj67 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X20_v14-20]");
						object obj68 = -4;
						bool flag5 = obj68 == null;
						object obj69 = ~obj67;
						object obj70 = obj69 | flag5;
						if (obj70 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CB0]");
							object obj71 = 0;
							object obj72 = obj54 + 64;
							obj72 = obj71;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X20_v16-28]");
							bool flag6 = (nint)0 < (nint)5;
							object obj73 = !flag6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X20_v16-28]");
							object obj74 = -5;
							bool flag7 = obj74 == null;
							object obj75 = ~obj73;
							object obj76 = obj75 | flag7;
							if (obj76 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CA8]");
								object obj77 = 0;
								object obj78 = obj54 + 72;
								obj78 = obj77;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X20_v18-30]");
								bool flag8 = (nint)0 < (nint)6;
								object obj79 = !flag8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X20_v18-30]");
								object obj80 = -6;
								bool flag9 = obj80 == null;
								object obj81 = ~obj79;
								object obj82 = obj81 | flag9;
								if (obj82 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C90]");
									object obj83 = 0;
									object obj84 = obj54 + 80;
									obj84 = obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X20_v20-38]");
									object obj85 = 0 & 0xFFFFFFF8L;
									if (obj85 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CB8]");
										object obj86 = 0;
										object obj87 = obj54 + 88;
										obj87 = obj86;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X20_v22-40]");
										bool flag10 = (nint)0 < (nint)8;
										object obj88 = !flag10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X20_v22-40]");
										object obj89 = -8;
										bool flag11 = obj89 == null;
										object obj90 = ~obj88;
										object obj91 = obj90 | flag11;
										if (obj91 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CA0]");
											object obj92 = 0;
											object obj93 = obj54 + 96;
											obj93 = obj92;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj94 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v73+A0]");
											object obj95 = (nint)0 + (nint)192;
											obj95 = obj54;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void _003CWatchClosed_003Eb__75_0(string json)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		closedAsking = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TakeClosed(json);
	}

	private void _003CWatchClosed_003Eb__75_1(string why)
	{
		closedAsking = false;
	}

	private unsafe void _003CCheck_003Eb__114_0(Dictionary<string, string> values)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1060: Expected Obj, but got I
		//IL_10c2: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_018e: Expected I8, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got Ref
		//IL_03b0: Expected I8, but got I4
		//IL_1110: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_1148: Expected Obj, but got I4
		//IL_1673: Expected Obj, but got I
		//IL_1178: Expected Obj, but got I4
		//IL_04fb: Expected Obj, but got I4
		//IL_11e8: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I4
		//IL_11b0: Expected Obj, but got I4
		//IL_1290: Expected Obj, but got I4
		//IL_16aa: Expected Obj, but got I
		//IL_16ba: Expected Obj, but got I
		//IL_16cf: Expected Obj, but got I
		//IL_17b9: Expected Obj, but got I
		//IL_1220: Expected Obj, but got I4
		//IL_06b5: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I4
		//IL_12c0: Expected Obj, but got I4
		//IL_1705: Expected Obj, but got I
		//IL_17d9: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I4
		//IL_0922: Expected Obj, but got I4
		//IL_0938: Expected I8, but got I4
		//IL_1258: Expected Obj, but got I4
		//IL_12f8: Expected Obj, but got I4
		//IL_07bd: Expected Obj, but got I4
		//IL_1749: Expected Obj, but got I
		//IL_1759: Expected Obj, but got I
		//IL_176e: Expected Obj, but got I
		//IL_179b: Expected Obj, but got I
		//IL_1330: Expected Obj, but got I4
		//IL_180d: Expected Obj, but got I
		//IL_181d: Expected Obj, but got I
		//IL_1360: Expected Obj, but got I4
		//IL_098a: Expected Obj, but got I4
		//IL_1408: Expected Obj, but got I4
		//IL_1036: Expected Obj, but got I4
		//IL_191d: Expected Obj, but got I
		//IL_1398: Expected Obj, but got I4
		//IL_086e: Expected Obj, but got I4
		//IL_1438: Expected Obj, but got I4
		//IL_1854: Expected Obj, but got I
		//IL_1864: Expected Obj, but got I
		//IL_1879: Expected Obj, but got I
		//IL_189f: Expected Obj, but got I4
		//IL_089b: Expected Obj, but got I
		//IL_193d: Expected Obj, but got I
		//IL_08ef: Expected Obj, but got I4
		//IL_1470: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got I4
		//IL_196a: Expected Obj, but got I
		//IL_0ab3: Expected Obj, but got I4
		//IL_13d0: Expected Obj, but got I4
		//IL_18c2: Expected Obj, but got I
		//IL_18d2: Expected Obj, but got I
		//IL_18e7: Expected Obj, but got I
		//IL_0cc2: Expected Obj, but got I
		//IL_0ce4: Expected Obj, but got I4
		//IL_0aef: Expected Obj, but got I4
		//IL_0b41: Expected Obj, but got I
		//IL_0b51: Expected Obj, but got I
		//IL_0b7b: Expected Obj, but got I4
		//IL_0baa: Expected Obj, but got I
		//IL_0e54: Expected Obj, but got I4
		//IL_0e5c: Expected Obj, but got Ref
		//IL_0d51: Expected I8, but got I4
		//IL_0be6: Expected Obj, but got I
		//IL_14d5: Expected Obj, but got I4
		//IL_0da8: Expected Obj, but got I4
		//IL_0dd5: Expected Obj, but got I
		//IL_150d: Expected Obj, but got I4
		//IL_0e29: Expected Obj, but got I4
		//IL_0c3b: Expected Obj, but got I
		//IL_0c65: Expected Obj, but got I4
		//IL_199e: Expected Obj, but got I
		//IL_0c92: Expected Obj, but got I
		//IL_157d: Expected Obj, but got I4
		//IL_0eae: Expected Obj, but got I4
		//IL_0f2e: Expected Obj, but got I4
		//IL_1625: Expected Obj, but got I4
		//IL_1545: Expected Obj, but got I4
		//IL_1aef: Expected Obj, but got I
		//IL_15b5: Expected Obj, but got I4
		//IL_19d5: Expected Obj, but got I
		//IL_19e5: Expected Obj, but got I
		//IL_19fa: Expected Obj, but got I
		//IL_1a18: Expected Obj, but got I4
		//IL_1655: Expected Obj, but got I4
		//IL_1a3b: Expected Obj, but got I
		//IL_1b0f: Expected Obj, but got I
		//IL_0f89: Expected Obj, but got I4
		//IL_15ed: Expected Obj, but got I4
		//IL_1a7f: Expected Obj, but got I
		//IL_1a8f: Expected Obj, but got I
		//IL_1aa4: Expected Obj, but got I
		//IL_1ad1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59E0]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		asking = false;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		float num = unscaledTime + 1.1146363E+09f;
		nextCheck = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C88]");
		object key2 = 0;
		_003C_003Ec__DisplayClass114_0 obj5 = default;
		string value = _003CCheck_003Eg__Of_007C114_2((string)key, ref obj5);
		long num2 = UntilOf(value);
		object obj6 = obj;
		bool forever;
		string text3;
		if (num2 == 9223372036854775807L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v315+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = _003CCheck_003Eg__Of_007C114_2((string)key2, ref obj5);
			if (text == null)
			{
				text = (string)obj4;
			}
			string text2 = text.Trim();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v169+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text3 = text2;
			forever = true;
			num2 = 0L;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v315+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long serverNowMs = ServerNowMs;
			bool flag5 = num2 <= serverNowMs;
			IntPtr intPtr = default;
			text3 = (string)(nint)intPtr;
			forever = (byte)(&obj5) != 0;
			if (flag5)
			{
				goto IL_0309;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v317+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text4 = _003CCheck_003Eg__Of_007C114_2((string)key2, ref obj5);
			if (text4 == null)
			{
				text4 = (string)obj4;
			}
			string text5 = text4.Trim();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v165+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text3 = text5;
			forever = false;
		}
		GillaCloud.Ban(num2, forever, text3);
		goto IL_0309;
		IL_1553:
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X0_v144+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X0_v150+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X0_v150+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X0_v150+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X0_v150+A0]");
		object obj23 = (nint)0 + (nint)40;
		string text6;
		obj23 = text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Save();
		return;
		IL_0a89:
		object obj25;
		object obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X0_v125+E4]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj27 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X0_v217+E4]");
		object obj28;
		if ((nint)0 != 0)
		{
			bool flag12 = obj28 == null;
			object obj29 = !flag12;
			if (obj29 != null)
			{
				goto IL_0b31;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj25;
			if (obj28 != null)
			{
				goto IL_0b31;
			}
		}
		goto IL_0caa;
		IL_0309:
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CB0]");
		object key3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v15+E4]");
		bool flag13 = (nint)0 == 0;
		object obj31 = !flag13;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value2 = _003CCheck_003Eg__Of_007C114_2((string)key3, ref obj5);
		long num3 = UntilOf(value2);
		long num4;
		string text10;
		string text9;
		if (num3 == 9223372036854775807L)
		{
			num4 = 0L;
		}
		else
		{
			bool flag14 = num3 <= 0;
			num4 = num3;
			if (!flag14)
			{
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v305+E4]");
				bool flag15 = (nint)0 == 0;
				object obj33 = !flag15;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CA8]");
				object key4 = 0;
				string text7 = _003CCheck_003Eg__Of_007C114_2((string)key4, ref obj5);
				if (text7 == null)
				{
					text7 = (string)obj4;
				}
				string text8 = text7.Trim();
				text9 = null;
				num4 = num3;
				text10 = text8;
				goto IL_10e6;
			}
		}
		text10 = (string)obj4;
		text9 = (string)(&obj5);
		goto IL_10e6;
		IL_0caa:
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D8]");
		object key5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v130+E4]");
		bool flag16 = (nint)0 == 0;
		object obj35 = !flag16;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value3 = _003CCheck_003Eg__Of_007C114_2((string)key5, ref obj5);
		long num5 = UntilOf(value3);
		long num6;
		object obj38;
		string text13;
		if (num5 == 9223372036854775807L)
		{
			num6 = 0L;
		}
		else
		{
			bool flag17 = num5 <= 0;
			num6 = num5;
			if (!flag17)
			{
				object obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X0_v207+E4]");
				bool flag18 = (nint)0 == 0;
				object obj37 = !flag18;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CC0]");
				object key6 = 0;
				string text11 = _003CCheck_003Eg__Of_007C114_2((string)key6, ref obj5);
				if (text11 == null)
				{
					text11 = (string)obj4;
				}
				string text12 = text11.Trim();
				obj38 = 1;
				text13 = null;
				num6 = num5;
				text6 = text12;
				goto IL_14ab;
			}
		}
		text6 = (string)obj4;
		obj38 = 0;
		text13 = (string)(&obj5);
		goto IL_14ab;
		IL_10e6:
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v21+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v27+E4]");
		bool flag20 = (nint)0 == 0;
		object obj42 = !flag20;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v27+A0]");
		object obj43 = 0;
		long num7 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v16+30]");
		if (num7 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v27+E4]");
			bool flag21 = (nint)0 == 0;
			object obj44 = !flag21;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj45 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v289+E4]");
			bool flag22 = (nint)0 == 0;
			object obj46 = !flag22;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj45 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v289+A0]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v154+38]");
			text9 = (string)0;
			string text14 = text10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v154+38]");
			bool flag23 = text14 != (string)0;
			bool flag24 = !flag23;
			text3 = null;
			if (flag24)
			{
				goto IL_069d;
			}
			obj41 = obj;
			text3 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v27+E4]");
		bool flag25 = (nint)0 == 0;
		object obj48 = !flag25;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long serverNowMs2 = ServerNowMs;
		if (num4 > serverNowMs2)
		{
			object obj49 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v51+E4]");
			bool flag26 = (nint)0 == 0;
			object obj50 = !flag26;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj51 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v55+E4]");
			bool flag27 = (nint)0 == 0;
			object obj52 = !flag27;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj51 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v55+A0]");
			object obj53 = 0;
			long num8 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v34+30]");
			bool flag28 = num8 > 0;
			string text15 = text3;
			string text16 = text9;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v55+E4]");
				bool flag29 = (nint)0 == 0;
				object obj54 = !flag29;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj55 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v60+E4]");
				bool flag30 = (nint)0 == 0;
				object obj56 = !flag30;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj55 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v60+A0]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v41+38]");
				text16 = (string)0;
				string text17 = text10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v41+38]");
				bool flag31 = text17 != (string)0;
				bool flag32 = !flag31;
				text15 = null;
				text3 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v41+38]");
				text9 = (string)0;
				if (flag32)
				{
					goto IL_11be;
				}
			}
			kickTold = false;
			text3 = text15;
			text9 = text16;
		}
		goto IL_11be;
		IL_0b31:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X0_v217+A0]");
		object obj59 = 0;
		object obj60 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v124+E4]");
		bool flag33 = (nint)0 == 0;
		object obj61 = !flag33;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v12+8]");
		bool flag34 = (UnityEngine.Object)0 != null;
		bool flag35 = !flag34;
		text3 = null;
		string text18 = null;
		string text19;
		if (!flag35)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v12+8]");
			string roomName = ((NetworkBootstrap)0).RoomName;
			bool flag36 = roomName == text19;
			bool flag37 = !flag36;
			text3 = null;
			text18 = text19;
			if (!flag37)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v12+8]");
				((NetworkBootstrap)0).KickFromRoom();
				object obj62 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X0_v225+E4]");
				bool flag38 = (nint)0 == 0;
				object obj63 = !flag38;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CC8]");
				object top = 0;
				TellRoomKick((string)top);
				text3 = null;
				text18 = null;
			}
		}
		goto IL_0caa;
		IL_12ce:
		object obj64 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v87+E4]");
		bool flag39 = (nint)0 == 0;
		object obj65 = !flag39;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v92+E4]");
		bool flag40 = (nint)0 == 0;
		object obj67 = !flag40;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj66 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v92+A0]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		obj25 = 0;
		long num10;
		long num9 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v54+48]");
		string text22;
		if (num9 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v92+E4]");
			bool flag41 = (nint)0 == 0;
			object obj69 = !flag41;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj70 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X0_v240+E4]");
			bool flag42 = (nint)0 == 0;
			object obj71 = !flag42;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj70 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X0_v240+A0]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v133+40]");
			text18 = (string)0;
			string text20 = text19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v133+40]");
			bool flag43 = text20 != (string)0;
			obj66 = obj;
			bool flag44 = !flag43;
			object obj73 = !flag44;
			text3 = null;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v92+E4]");
				bool flag45 = (nint)0 == 0;
				object obj74 = !flag45;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj75 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v247+E4]");
				bool flag46 = (nint)0 == 0;
				object obj76 = !flag46;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj75 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v247+A0]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v139+50]");
				text18 = (string)0;
				string text21 = text22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v139+50]");
				bool flag47 = text21 != (string)0;
				bool flag48 = !flag47;
				text3 = null;
				if (flag48)
				{
					goto IL_0a89;
				}
				obj66 = obj;
				text3 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v92+E4]");
		bool flag49 = (nint)0 == 0;
		object obj78 = !flag49;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj79 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v98+E4]");
		bool flag50 = (nint)0 == 0;
		object obj80 = !flag50;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v98+A0]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v98+E4]");
		bool flag51 = (nint)0 == 0;
		object obj82 = !flag51;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj79 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v98+A0]");
		object obj83 = (nint)0 + (nint)64;
		obj83 = text19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X0_v104+E4]");
		bool flag52 = (nint)0 == 0;
		object obj85 = !flag52;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj84 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X0_v104+A0]");
		object obj86 = (nint)0 + (nint)80;
		obj86 = text22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		SaveRoomKick();
		text18 = text22;
		goto IL_0a89;
		IL_14ab:
		object obj87 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X0_v136+E4]");
		bool flag53 = (nint)0 == 0;
		object obj88 = !flag53;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj89 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v140+E4]");
		bool flag54 = (nint)0 == 0;
		object obj90 = !flag54;
		if (obj90 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj89 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v140+A0]");
		object obj91 = 0;
		long num11 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v83+20]");
		if (num11 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v140+E4]");
			bool flag55 = (nint)0 == 0;
			object obj92 = !flag55;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj93 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v192+E4]");
			bool flag56 = (nint)0 == 0;
			object obj94 = !flag56;
			if (obj94 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj93 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v192+A0]");
			object obj95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X8_v115+28]");
			text13 = (string)0;
			string text23 = text6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X8_v115+28]");
			bool flag57 = text23 == (string)0;
			bool flag58 = !flag57;
			object obj96 = !flag58;
			text3 = null;
			if (obj96 != null)
			{
				return;
			}
		}
		if (obj38 != null)
		{
			object obj97 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X0_v165+E4]");
			bool flag59 = (nint)0 == 0;
			object obj98 = !flag59;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj99 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v169+E4]");
			bool flag60 = (nint)0 == 0;
			object obj100 = !flag60;
			if (obj100 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj99 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v169+A0]");
			object obj101 = 0;
			long num12 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X8_v101+20]");
			bool flag61 = num12 > 0;
			string text24 = text3;
			string text25 = text13;
			if (!flag61)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v169+E4]");
				bool flag62 = (nint)0 == 0;
				object obj102 = !flag62;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj103 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X0_v174+E4]");
				bool flag63 = (nint)0 == 0;
				object obj104 = !flag63;
				if (obj104 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj103 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X0_v174+A0]");
				object obj105 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v108+28]");
				text25 = (string)0;
				string text26 = text6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v108+28]");
				bool flag64 = text26 != (string)0;
				bool flag65 = !flag64;
				text24 = null;
				text3 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v108+28]");
				text13 = (string)0;
				if (flag65)
				{
					goto IL_1553;
				}
			}
			told = false;
			text3 = text24;
			text13 = text25;
		}
		goto IL_1553;
		IL_11be:
		object obj106 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v30+E4]");
		bool flag66 = (nint)0 == 0;
		object obj107 = !flag66;
		if (obj107 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj108 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v36+E4]");
		bool flag67 = (nint)0 == 0;
		object obj109 = !flag67;
		if (obj109 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj108 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v36+A0]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v36+E4]");
		bool flag68 = (nint)0 == 0;
		object obj111 = !flag68;
		if (obj111 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj108 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v36+A0]");
		object obj112 = (nint)0 + (nint)56;
		obj112 = text10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		SaveKick();
		text9 = text10;
		goto IL_069d;
		IL_069d:
		object obj113 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C90]");
		object key7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CB8]");
		object key8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v77+E4]");
		bool flag69 = (nint)0 == 0;
		object obj114 = !flag69;
		if (obj114 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value4 = _003CCheck_003Eg__Of_007C114_2((string)key7, ref obj5);
		long num13 = UntilOf(value4);
		string text27 = _003CCheck_003Eg__Of_007C114_2((string)key8, ref obj5);
		if (text27 == null)
		{
			text27 = (string)obj4;
		}
		string text28 = text27.Trim();
		if (num13 != 9223372036854775807L)
		{
			object obj115 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v271+E4]");
			bool flag70 = (nint)0 == 0;
			object obj116 = !flag70;
			if (obj116 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long serverNowMs3 = ServerNowMs;
			if (num13 > serverNowMs3 && text28._stringLength != 0)
			{
				if (num13 > 0)
				{
					object obj117 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v273+E4]");
					bool flag71 = (nint)0 == 0;
					object obj118 = !flag71;
					if (obj118 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CA0]");
					object key9 = 0;
					string text29 = _003CCheck_003Eg__Of_007C114_2((string)key9, ref obj5);
					if (text29 == null)
					{
						text29 = (string)obj4;
					}
					string text30 = text29.Trim();
					obj28 = 1;
					text22 = text30;
					text18 = null;
					text19 = text28;
					num10 = num13;
				}
				else
				{
					text22 = (string)obj4;
					obj28 = 0;
					text18 = null;
					text19 = text28;
					num10 = num13;
				}
				goto IL_12ce;
			}
		}
		text19 = (string)obj4;
		obj28 = 0;
		text22 = (string)obj4;
		text18 = null;
		num10 = 0L;
		goto IL_12ce;
	}

	internal static string _003CCheck_003Eg__Of_007C114_2(string key, ref _003C_003Ec__DisplayClass114_0 P_1)
	{
		//IL_0076: Invalid comparison between VT and I4
		//IL_0089: Expected Obj, but got VT
		//IL_001c: Expected Obj, but got VT
		//IL_003a: Expected Obj, but got I4
		bool flag = P_1 == (_003C_003Ec__DisplayClass114_0)(object)0;
		string result = (string)P_1;
		if (!flag)
		{
			bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)P_1).TryGetValue((System.__Canon)(object)key, out var value);
			bool flag3 = !flag2;
			object obj = !flag3;
			object obj2 = ~obj;
			result = (string)(object)((obj2 != null) ? null : value);
		}
		return result;
	}

	private void _003CCheck_003Eb__114_1(string error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_008f: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CD0]");
		object obj = 0;
		asking = false;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 1.1146363E+09f;
		nextCheck = num;
		if (error == (string)obj)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object why = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.Ban(0L, forever: false, (string)why);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CD8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj6 = 0;
		string message = (string)obj5 + error;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}

	private void _003CSyncClock_003Eb__115_0(long ms)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		askingTime = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		double realtimeSinceStartupAsDouble = Time.realtimeSinceStartupAsDouble;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+A0]");
		object obj6 = 0;
		_ = 1;
	}

	private void _003CSyncClock_003Eb__115_1(string error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj2 = 0;
		askingTime = false;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 30f;
		nextTime = num;
		string message = (string)obj + error;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}
}
