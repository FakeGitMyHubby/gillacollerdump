using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class GillaSaw
{
	public const byte Door = default(byte);

	public const float Width = default(float);

	public const float BiteEvery = default(float);

	private const float MostCutWait = default(float);

	private static readonly List<(Func<bool>, Action, float)> waitingCuts;

	public static int CutsWaiting
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I
			//IL_0047: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
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
			object obj5 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private static void ForgetCuts()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
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
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	public unsafe static void WhenCut(Func<bool> ready, Action then)
	{
		//IL_0071: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_01c7: Expected VT, but got Ref
		//IL_015f: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		if (then == null)
		{
			return;
		}
		if (ready != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [ready @ X0 (System.Func`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			object obj2 = default;
			object obj = obj2 & 1;
			if (obj == null)
			{
				goto IL_0061;
			}
		}
		goto IL_0057;
		IL_0057:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: then.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0061;
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v8+A0]");
		object obj6 = 0;
		List<(System.__Canon, System.__Canon, float)> list = (List<(System.__Canon, System.__Canon, float)>)obj6;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D28]");
		object obj7 = 0;
		(System.__Canon, System.__Canon, float) tuple = ((System.__Canon)(object)ready, (System.__Canon)(object)then, realtimeSinceStartup);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+1C]");
			object obj9 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v15+18]");
				bool flag2 = num < 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+18]");
					object obj11 = (nint)0 * (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+10]");
					object obj12 = 0 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X21_v8 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+18]");
					object obj13 = (nint)0 + (nint)1;
					object obj14 = obj12 + 32;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					object obj15 = default;
					((List<(System.__Canon, System.__Canon, float)>)obj6).AddWithResize(((System.__Canon, System.__Canon, float))(&obj15));
				}
				GillaSawPump.Ensure();
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		bool flag3 = (nint)ready != 1;
		System.__Canon _Canon = (System.__Canon)(object)then;
		System.__Canon _Canon2 = (System.__Canon)(object)ready;
		NullReferenceException ex2 = ex;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj17 = default;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj19 = default;
			object obj18 = obj19 & 1;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v29+E4]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogException((Exception)obj17);
				goto IL_0057;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj21 = obj17;
			_Canon2 = (System.__Canon)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			_Canon = null;
			NullReferenceException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	internal static void PumpCuts()
	{
		//IL_031e: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D58]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D50]");
		object obj3 = 0;
		int num = 0;
		object obj11 = default;
		object obj14 = default;
		object obj16 = default;
		object obj20 = default;
		while (true)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v4+A0]");
			object obj6 = 0;
			List<(System.__Canon, System.__Canon, float)> list = (List<(System.__Canon, System.__Canon, float)>)obj6;
			if (obj6 == null)
			{
				break;
			}
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X9_v5 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Single>>)+18]");
			if ((nint)num2 >= (nint)0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v20+A0]");
				object obj9 = 0;
				list = (List<(System.__Canon, System.__Canon, float)>)obj9;
				if (obj9 == null)
				{
					break;
				}
			}
			object obj10 = obj2;
			(System.__Canon, System.__Canon, float) tuple = list.get_Item(num);
			int num4;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ stack_-98_v4+28]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ stack_-98_v4+18] (should have been resolved before IL gen)");
				object obj13 = obj14 & 1;
				bool flag3 = obj13 == null;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					float num3 = realtimeSinceStartup - (float)obj16;
					if (!((double)num3 > 2.0))
					{
						num4 = num;
						goto IL_0379;
					}
				}
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v28+E4]");
				bool flag4 = (nint)0 == 0;
				object obj18 = !flag4;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v28+A0]");
				object obj19 = 0;
				if (obj19 == null)
				{
					break;
				}
				obj10 = obj3;
				num4 = num - 1;
				((List<(System.__Canon, System.__Canon, float)>)obj19).RemoveAt(num);
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ stack_-90+28]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ stack_-90+18] (should have been resolved before IL gen)");
					goto IL_0379;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
			IL_0379:
			num = num4 + 1;
		}
		throw new NullReferenceException();
	}

	public unsafe static void Bite(Dismemberment copy, GoreSection section, int slot, GillaRip.Along along, Vector3 middle, Vector3 way, Vector3 half, bool bleed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected VT, but got Ref
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_02d4: Expected VT, but got I4
		//IL_02d4: Expected VT, but got Ref
		//IL_02d4: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = copy == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On(copy);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = gillaWounds == null;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 != null)
		{
			return;
		}
		Vector3 vector = default;
		gillaWounds.Kerf(slot, section, (GillaRip.Along)(&vector), (Vector3)0, (Vector3)0, half, bleed);
		object obj11 = middle & 1;
		if (obj11 == null || ~(copy.spawnPieces ? 1u : 0u) != 0)
		{
			return;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(copy.bloodMaterial != null))
		{
			return;
		}
		GameObject gameObject = copy.gameObject;
		if (gameObject.activeInHierarchy)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v24+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Spurt(gillaWounds, section, (Vector3)copy.bloodMaterial, (Vector3)(&vector), (Vector3)0, null);
		}
	}

	public static void Spurt(GillaWounds w, GoreSection section, Vector3 middle, Vector3 way, Vector3 half, Material blood)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got VT
		//IL_00c9: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_06c0: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_0206: Expected VT, but got I4
		//IL_024f: Expected VT, but got I4
		//IL_0722: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_05a2: Expected VT, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_0781: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_079f: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I4
		//IL_0628: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I
		//IL_089b: Expected Obj, but got I4
		//IL_04a4: Invalid comparison between F8 and I
		//IL_0678: Expected Obj, but got I
		//IL_06a2: Expected Obj, but got I4
		//IL_04e7: Expected I4, but got VT
		//IL_04e7: Expected VT, but got I4
		//IL_04e7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = w == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)middle == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = 109891584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj12 = default;
		object obj13;
		object obj14 = default;
		object obj15;
		object obj16 = default;
		object obj17;
		object obj18 = default;
		if ((nint)obj12 > 0)
		{
			obj13 = obj14 / obj12;
			obj15 = obj16 / obj12;
			obj17 = obj18 / obj12;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v58+A0]");
			object obj21 = 0;
			obj13 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v59+4]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v59+8]");
			obj17 = 0;
		}
		object obj23 = default;
		object obj22 = obj23 * obj13;
		object obj24 = obj23 * obj15;
		object obj25 = obj23 * obj17;
		object obj27 = default;
		object obj26 = obj27 + obj22;
		object obj29 = default;
		object obj28 = obj29 + obj24;
		object obj31 = default;
		object obj30 = obj31 + obj25;
		string text = w.BodyBone(section, (Vector3)0);
		if (w.HasBone(text))
		{
			Vector3 vector = w.World(text, (Vector3)0);
			object obj32 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v24+E4]");
			bool flag8 = (nint)0 == 0;
			object obj33 = !flag8;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj34;
			object obj35;
			object obj36;
			if ((nint)obj12 > 0)
			{
				obj34 = obj14 / obj12;
				obj35 = obj16 / obj12;
				obj36 = obj18 / obj12;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v52+A0]");
				object obj39 = 0;
				obj34 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v53+4]");
				obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v53+8]");
				obj36 = 0;
			}
			object obj40 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj41 = obj40 * 0;
			object obj42 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj43 = obj42 * 0;
			object obj44 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj45 = obj44 * 0;
			object obj46 = obj26 - obj41;
			object obj47 = obj28 - obj43;
			object obj48 = obj30 - obj45;
			Vector3 vector2 = w.World(text, (Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X22_v5+99E]");
			bool flag9 = (nint)0 == 0;
			object obj49 = !flag9;
			if (obj49 == null)
			{
				_ = 1;
			}
			object obj50 = obj9;
			object obj51 = obj46 - obj26;
			object obj52 = obj47 - obj28;
			object obj53 = obj48 - obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v30+E4]");
			bool flag10 = (nint)0 == 0;
			object obj54 = !flag10;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj55 = obj51 * obj51;
			object obj56 = obj52 * obj52;
			object obj57 = obj55 + obj56;
			object obj58 = obj53 * obj53;
			object obj59 = obj58 + obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj61;
			object obj62;
			object obj63;
			if ((nint)obj59 > 0)
			{
				object obj60 = obj51 / obj59;
				obj61 = obj52 / obj59;
				obj62 = obj53 / obj59;
				obj63 = obj60;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj64 = 0;
				object obj65 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v46+A0]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v47+4]");
				obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v47+8]");
				obj62 = 0;
				obj63 = obj66;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj67 = 0;
			object obj68 = obj67;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28+A0]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v29+20]");
			double num = 0.0 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v29+18]");
			double num2 = 0.0 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v29+1C]");
			double num3 = 0.0 * 0.5;
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X22_v5+99E]");
			bool flag11 = (nint)0 == 0;
			object obj70 = !flag11;
			if (obj70 == null)
			{
				_ = 1;
			}
			double num4 = (double)obj61 + num3;
			double num5 = 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num6 = num5 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v29+1C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj71 = num7 * 0;
			double num8 = (double)obj63 + num2;
			double num9 = (double)obj62 + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v29+18]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj72 = num10 * 0;
			object obj73 = obj9;
			double num11 = num8 + num6;
			double num12 = num4 + (double)obj72;
			double num13 = num9 + (double)obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v37+E4]");
			bool flag12 = (nint)0 == 0;
			object obj74 = !flag12;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num14 = num11 * num11;
			double num15 = num12 * num12;
			double num16 = num14 + num15;
			double num17 = num13 * num13;
			double num18 = num17 + num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num18 > 0.0)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj75 = 0;
			object obj76 = obj75;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v39+E4]");
			bool flag13 = (nint)0 == 0;
			object obj77 = !flag13;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Blood.Chain((Vector3)14, (Vector3)1, 0, (int)way);
		}
	}

	public unsafe static void CutPart(Dismemberment copy, ApePart part, GillaRip.Along along, Vector3 impulse)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I4
		//IL_0420: Expected VT, but got Ref
		//IL_0420: Expected VT, but got Ref
		//IL_02a5: Expected Obj, but got I4
		//IL_0449: Expected VT, but got Ref
		//IL_0505: Expected VT, but got Ref
		//IL_0505: Expected VT, but got I4
		//IL_031e: Expected Obj, but got I4
		//IL_0512: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj4 = 0;
		Dismemberment dismemberment = default;
		bool flag2 = dismemberment == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		if (!flag3)
		{
			goto IL_0068;
		}
		ApePart apePart = default;
		if (dismemberment.IsTorn(apePart))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v49+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = Resawable(dismemberment, apePart);
			bool flag6 = !flag5;
			obj5 = 0;
			if (flag6)
			{
				goto IL_0068;
			}
		}
		Dismemberment.Part part2 = dismemberment.Find(apePart);
		bool flag7 = part2 == null;
		object obj9 = 0;
		ApePart apePart2 = apePart;
		Vector3 at;
		GameObject piece;
		if (!flag7)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v29+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = part2.renderer == null;
			bool flag10 = !flag9;
			obj9 = 0;
			apePart2 = (ApePart)0;
			if (!flag10)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v33+E4]");
				bool flag11 = (nint)0 == 0;
				object obj13 = !flag11;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform;
				if (part2.joint != null)
				{
					transform = part2.joint;
					bool flag12 = (object)part2.joint == null;
					object obj14 = !flag12;
					if (obj14 == null)
					{
						throw new NullReferenceException();
					}
				}
				else
				{
					transform = dismemberment.transform;
				}
				Vector3 position = transform.position;
				object obj15 = default;
				at = (Vector3)(&obj15);
				piece = null;
				goto IL_04e7;
			}
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj17 = !flag13;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On(dismemberment);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10+E4]");
		bool flag14 = (nint)0 == 0;
		object obj19 = !flag14;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = gillaWounds == null;
		bool flag16 = !flag15;
		object obj20 = !flag16;
		object obj21 = default;
		GameObject gameObject = default;
		Vector3 cutAt = default;
		if (obj20 == null && gillaWounds.SawArm(apePart, (GillaRip.Along)(&obj21), (Vector3)(&gameObject), out var _, out cutAt, out *(Vector3*)null))
		{
			object obj22 = default;
			at = (Vector3)(&obj22);
			piece = gameObject;
			goto IL_04e7;
		}
		return;
		IL_04e7:
		dismemberment.Sawn(apePart, piece, at, (Vector3)0, (GillaRip.Along)(&cutAt));
		return;
		IL_0068:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DC8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D60]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string text = string.Format((string)format, arg);
		object obj24 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v30+E4]");
		bool flag17 = (nint)0 == 0;
		object obj25 = !flag17;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v30+A0]");
		object obj26 = (nint)0 + (nint)56;
		obj26 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static bool Resawable(Dismemberment copy, ApePart part)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_016d: Expected I4, but got Obj
		//IL_0124: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = copy == null;
		if (part != 0)
		{
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				if ((object)copy == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				Dismemberment.Part part2 = copy.Find(part);
				if (part2 != null && ~(part2.torn ? 1u : 0u) == 0 && ~(part2.sawn ? 1u : 0u) == 0)
				{
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return part2.renderer != null;
				}
			}
		}
		return false;
	}

	public unsafe static bool PartOf(GoreSection s, out ApePart part)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		object obj = s & (GoreSection)0xFF;
		object obj2 = obj - 2;
		bool flag = obj2 == null;
		object obj3 = s & (GoreSection)0xFE;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object obj6 = ((obj5 != null) ? ((object)1) : ((object)(1 + 1)));
		object obj7 = s & (GoreSection)0xFF;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			obj6 = 0;
		}
		object obj9 = obj3 - 2;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		object obj11 = ~obj10;
		bool result = obj11 != null || flag2;
		ref ApePart reference = ref *(ApePart*)obj6;
		return result;
	}

	public unsafe static bool ArmOf(GoreSection s, out ApePart part)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		object obj = s & (GoreSection)0xFF;
		object obj2 = obj - 2;
		bool flag = obj2 == null;
		object obj3 = s & (GoreSection)0xFE;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object obj6 = ((obj5 != null) ? ((object)1) : ((object)(1 + 1)));
		object obj7 = obj3 - 2;
		bool result = obj7 == null;
		ref ApePart reference = ref *(ApePart*)obj6;
		return result;
	}

	static GillaSaw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, System.__Canon, float)> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
