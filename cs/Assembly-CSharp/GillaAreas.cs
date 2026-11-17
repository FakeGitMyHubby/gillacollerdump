using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GillaAreas : MonoBehaviour
{
	public const float Near = default(float);

	public const float Far = default(float);

	private const int Looked = default(int);

	private const int LookedAfterJump = default(int);

	private const float Jump = default(float);

	public float near;

	public float far;

	private Renderer[] renderers;

	private Bounds[] boxes;

	private bool[] on;

	private int next;

	private int jumpLeft;

	private Vector3 last;

	public int Count
	{
		get
		{
			Renderer[] array = renderers;
			if (renderers != null)
			{
				return array.Length;
			}
			return 0;
		}
	}

	public IReadOnlyList<Renderer> Renderers => renderers;

	public static GillaAreas Make(Transform baseRoot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5030]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5038]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			Component component = default;
			if ((object)component != null)
			{
				GameObject go = component.gameObject;
				if ((object)baseRoot != null)
				{
					GameObject gameObject2 = baseRoot.gameObject;
					if ((object)gameObject2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
						object obj4 = 0;
						Scene scene = gameObject2.scene;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+E4]");
						bool flag = (nint)0 == 0;
						object obj6 = !flag;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SceneManager.MoveGameObjectToScene(go, scene);
						((GillaAreas)component).Gather(baseRoot);
						return (GillaAreas)component;
					}
				}
			}
		}
		return (GillaAreas)(object)new NullReferenceException();
	}

	private void OnDestroy()
	{
		ShowAll();
	}

	private unsafe void Gather(Transform baseRoot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_16f8: Expected I, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_15ad: Expected Obj, but got I
		//IL_15c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c5: Expected Obj, but got Unknown
		//IL_0a66: Expected Obj, but got I4
		//IL_0a73: Expected Obj, but got Ref
		//IL_0a7c: Expected Obj, but got I4
		//IL_1579: Expected Obj, but got I
		//IL_1841: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got Ref
		//IL_0194: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_1747: Expected Obj, but got I4
		//IL_01fa: Expected I, but got Obj
		//IL_0b9a: Expected Obj, but got I4
		//IL_0b41: Expected I, but got Obj
		//IL_1799: Expected Obj, but got I
		//IL_163e: Expected Obj, but got I
		//IL_1660: Expected Obj, but got I4
		//IL_166d: Expected Obj, but got Ref
		//IL_1765: Expected Obj, but got I
		//IL_160a: Expected Obj, but got I
		//IL_0c05: Expected Obj, but got I
		//IL_0c15: Expected Obj, but got I
		//IL_0c5c: Expected Obj, but got I4
		//IL_0b65: Expected Obj, but got I4
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected Obj, but got Unknown
		//IL_02f9: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got Ref
		//IL_02ce: Expected Obj, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0c9b: Expected I, but got Obj
		//IL_0be7: Expected Obj, but got I4
		//IL_14d7: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got Ref
		//IL_152b: Expected Obj, but got I4
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected Obj, but got Unknown
		//IL_104d: Expected I, but got Obj
		//IL_0ce0: Expected Obj, but got I
		//IL_0ce8: Expected I, but got Obj
		//IL_0d0a: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_041b: Expected I, but got Obj
		//IL_0a17: Expected Obj, but got I4
		//IL_1082: Expected Obj, but got I
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_109a: Expected Obj, but got Unknown
		//IL_0d28: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I4
		//IL_10c1: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I4
		//IL_046b: Expected I, but got Obj
		//IL_0d66: Expected Obj, but got I
		//IL_0d76: Expected I, but got Obj
		//IL_0d87: Expected Obj, but got I4
		//IL_10fe: Expected Obj, but got I
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_17c1: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_04bb: Expected I, but got Obj
		//IL_117b: Expected Obj, but got I4
		//IL_1184: Expected Obj, but got I4
		//IL_0ddc: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I4
		//IL_050b: Expected I, but got Obj
		//IL_0fa3: Expected Obj, but got I
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected Obj, but got Unknown
		//IL_11aa: Expected Obj, but got I4
		//IL_11cb: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I4
		//IL_056b: Expected I, but got Obj
		//IL_11e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Expected Obj, but got Unknown
		//IL_0e39: Expected I4, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_0591: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got Ref
		//IL_05e9: Expected Obj, but got I4
		//IL_122c: Expected Obj, but got I
		//IL_0e97: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got I4
		//IL_0f49: Expected Obj, but got I
		//IL_0f59: Expected Obj, but got I
		//IL_0f7e: Expected Obj, but got I
		//IL_0f8e: Expected Obj, but got I
		//IL_060f: Expected Obj, but got I
		//IL_1273: Expected Obj, but got I4
		//IL_1294: Expected Obj, but got I4
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected Obj, but got Unknown
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0a: Expected Obj, but got Unknown
		//IL_0f1a: Expected Obj, but got I
		//IL_0f34: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I4
		//IL_064d: Expected I, but got Obj
		//IL_0676: Expected Obj, but got I4
		//IL_169c: Expected Obj, but got I4
		//IL_16c5: Expected Obj, but got I4
		//IL_16d2: Expected Obj, but got Ref
		//IL_131c: Expected Obj, but got I4
		//IL_1345: Expected Obj, but got I4
		//IL_06c8: Expected Obj, but got I4
		//IL_06d5: Expected Obj, but got Ref
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected Obj, but got Unknown
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected Obj, but got Unknown
		//IL_138f: Expected I, but got Obj
		//IL_13a9: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I
		//IL_076b: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_07c3: Expected Obj, but got Ref
		//IL_07fb: Expected I4, but got Obj
		//IL_0850: Expected Obj, but got I4
		//IL_085d: Expected Obj, but got Ref
		//IL_088f: Expected Obj, but got I4
		//IL_08af: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I
		//IL_0951: Expected Obj, but got I
		//IL_0976: Expected Obj, but got I
		//IL_097e: Expected I4, but got Obj
		//IL_098e: Expected Obj, but got I
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected Obj, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected Obj, but got Unknown
		//IL_0912: Expected Obj, but got I
		//IL_092c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4198]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityEngine.Object obj3 = (UnityEngine.Object)obj2;
		List<System.__Canon> list = default;
		list._002Ector();
		GillaAreas gillaAreas2;
		object obj24;
		object obj27;
		object obj12 = default;
		object obj14 = default;
		int num5 = default;
		object obj13;
		List<System.__Canon> list2;
		int num;
		if ((object)baseRoot != null)
		{
			IEnumerator enumerator = baseRoot.GetEnumerator();
			bool flag = enumerator == null;
			object obj4 = default;
			num = (int)(&obj4);
			GillaAreas gillaAreas = this;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				gillaAreas = (GillaAreas)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5078]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5060]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5080]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5070]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
				object obj10 = 0;
				object obj11 = obj12;
				obj13 = obj14;
				nint num3 = default;
				nint num2 = num3;
				int num4 = num5;
				IEnumerator enumerator2 = enumerator;
				int num9 = default;
				object obj23 = default;
				object obj26 = default;
				object obj28 = default;
				object obj31;
				UnityEngine.Object obj33 = default;
				object obj44 = default;
				do
				{
					nint num6 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v59 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v59 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0161;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v59 (Il2CppClass<System.Collections.IEnumerator>)+98]");
					int num7 = (int)((nint)0 + (nint)8);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v48 (System.Int32)-8]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v48 (System.Int32)-8]");
						if (0 == (nint)gillaAreas)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v59 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						num = (int)(-1);
						num4 = num7 + 16;
						bool flag2 = num != 1;
						num7 = num4;
						if (flag2)
						{
							continue;
						}
						goto IL_0161;
					}
					num = ((int*)num7)->m_value;
					object obj15 = num6 + ((int*)num7)->m_value;
					object obj16 = obj15 + 312;
					num3 = num2;
					num4 = num7;
					goto IL_159d;
					IL_1831:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					object obj17 = 0;
					System.__Canon _Canon = (System.__Canon)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					int num8 = (int)(&obj4);
					((int*)num8)->m_value = num9;
					if (num9 == 0)
					{
						goto IL_172d;
					}
					int value = ((int*)num9)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v40 (System.Int32)+12E]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v40 (System.Int32)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0b32;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v40 (System.Int32)+98]");
					int num10 = (int)((nint)0 + (nint)8);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X10_v17 (System.Int32)-8]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X10_v17 (System.Int32)-8]");
						if (0 == (nint)obj17)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v40 (System.Int32)+12E]");
						num = (int)(-1);
						num5 = num10 + 16;
						bool flag3 = num != 1;
						num10 = num5;
						if (flag3)
						{
							continue;
						}
						goto IL_0b32;
					}
					num = ((int*)num10)->m_value;
					object obj18 = value + ((int*)num10)->m_value;
					object obj19 = obj18 + 312;
					num5 = num10;
					goto IL_1789;
					IL_172d:
					OutOfMemoryException ex;
					bool flag4 = ex == null;
					object obj20 = !flag4;
					if (obj20 != null)
					{
						goto IL_146a;
					}
					object obj21;
					bool flag5 = obj21 == null;
					object obj22 = !flag5;
					OutOfMemoryException ex2 = ex;
					if (obj22 == null)
					{
						goto IL_0bb0;
					}
					goto IL_1478;
					IL_1487:
					NullReferenceException ex3 = new NullReferenceException();
					if ((nint)_Canon == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj21 = 1;
					}
					else
					{
						if ((nint)_Canon != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						ex = (OutOfMemoryException)obj23;
					}
					gillaAreas2 = this;
					obj24 = 0;
					goto IL_1831;
					IL_0161:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num3 = unchecked((nint)null);
					goto IL_159d;
					IL_159d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v92+8]");
					_Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X0_v92] (should have been resolved before IL gen)");
					object obj25 = obj26 & 1;
					bool flag6 = obj25 == null;
					obj12 = obj11;
					obj14 = obj13;
					num5 = num4;
					if (!flag6)
					{
						bool flag7 = enumerator == null;
						obj21 = 0;
						ex = null;
						obj27 = (object)(&obj28);
						list2 = list;
						if (flag7)
						{
							goto IL_141a;
						}
						nint num11 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v62 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v62 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0296;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v62 (Il2CppClass<System.Collections.IEnumerator>)+98]");
						int num12 = (int)((nint)0 + (nint)8);
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X10_v43 (System.Int32)-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X10_v43 (System.Int32)-8]");
							if (0 == (nint)gillaAreas)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v62 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
							num = (int)(-1);
							num4 = num12 + 16;
							bool flag8 = num != 1;
							num12 = num4;
							if (flag8)
							{
								continue;
							}
							goto IL_0296;
						}
						num = ((int*)num12)->m_value + 1;
						object obj29 = num11 + num;
						object obj30 = obj29 + 312;
						num4 = num12;
						goto IL_162e;
					}
					gillaAreas2 = this;
					obj21 = 0;
					ex = null;
					obj27 = (object)(&obj28);
					obj24 = 7;
					list2 = list;
					goto IL_1831;
					IL_146a:
					ex2 = new OutOfMemoryException();
					goto IL_1478;
					IL_0b32:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num3 = unchecked((nint)null);
					goto IL_1789;
					IL_1789:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v51+8]");
					_Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1058 @ X0_v51] (should have been resolved before IL gen)");
					goto IL_172d;
					IL_09fd:
					bool flag9 = enumerator == null;
					obj31 = !flag9;
					obj12 = obj11;
					obj14 = obj13;
					num5 = num4;
					num2 = num3;
					enumerator2 = enumerator;
					continue;
					IL_1428:
					IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
					goto IL_1436;
					IL_0296:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num3 = 1;
					goto IL_162e;
					IL_162e:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X0_v95+8]");
					UnityEngine.Object obj32 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1181 @ X0_v95] (should have been resolved before IL gen)");
					bool flag10 = (object)obj33 == null;
					obj21 = 0;
					ex = null;
					obj27 = (object)(&obj28);
					list2 = list;
					if (!flag10)
					{
						obj32 = (UnityEngine.Object)obj5;
						nint num13 = (nint)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v65 (Il2CppClass<UnityEngine.Object>)+130]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X1_v36 (UnityEngine.Object)+130]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v65 (Il2CppClass<UnityEngine.Object>)+130]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X1_v36 (UnityEngine.Object)+130]");
						bool flag11 = num14 < 0;
						object obj34 = !flag11;
						object obj35 = ~obj34;
						obj21 = 0;
						ex = null;
						obj27 = (object)(&obj28);
						list2 = list;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v65 (Il2CppClass<UnityEngine.Object>)+B0]");
							nint num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X1_v36 (UnityEngine.Object)+130]");
							object obj36 = num15 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v67-8]");
							bool flag12 = 0 != (nint)obj32;
							obj21 = 0;
							ex = null;
							obj27 = (object)(&obj28);
							list2 = list;
							if (!flag12)
							{
								string text = obj33.name;
								bool flag13 = text == (string)obj6;
								bool flag14 = !flag13;
								object obj37 = !flag14;
								num3 = unchecked((nint)null);
								if (obj37 == null)
								{
									string text2 = obj33.name;
									bool flag15 = text2 == (string)obj7;
									bool flag16 = !flag15;
									object obj38 = !flag16;
									num3 = unchecked((nint)null);
									if (obj38 == null)
									{
										string text3 = obj33.name;
										bool flag17 = text3 == (string)obj8;
										bool flag18 = !flag17;
										object obj39 = !flag18;
										num3 = unchecked((nint)null);
										if (obj39 == null)
										{
											string text4 = obj33.name;
											bool flag19 = text4 == (string)obj9;
											bool flag20 = !flag19;
											object obj40 = !flag20;
											num3 = unchecked((nint)null);
											if (obj40 == null)
											{
												string text5 = obj33.name;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5068]");
												object obj41 = 0;
												bool flag21 = text5 == (string)obj41;
												bool flag22 = !flag21;
												object obj42 = !flag22;
												num3 = unchecked((nint)null);
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5050]");
													object obj43 = 0;
													num3 = (nint)obj43;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
													bool flag23 = obj44 == null;
													obj12 = obj11;
													obj14 = obj13;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v65 (Il2CppClass<UnityEngine.Object>)+130]");
													num5 = 0;
													obj21 = 0;
													ex = null;
													obj27 = (object)(&obj28);
													_Canon = (System.__Canon)1;
													list2 = list;
													if (flag23)
													{
														goto IL_1487;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v115+18]");
													object obj45 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v115+18]");
													if ((nint)0 >= (nint)1)
													{
														object obj46 = obj11;
														object obj47 = 0;
														nint num16 = (nint)obj43;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v65 (Il2CppClass<UnityEngine.Object>)+130]");
														int num17 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X1_v36 (UnityEngine.Object)+130]");
														int num18 = 0;
														_Canon = (System.__Canon)1;
														while (true)
														{
															bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45);
															object obj48 = !flag24;
															obj11 = obj46;
															obj13 = obj47;
															num3 = num16;
															num4 = num17;
															obj21 = 0;
															ex = null;
															obj27 = (object)(&obj28);
															num = num18;
															list2 = list;
															if (obj48 != null)
															{
																break;
															}
															object obj49 = obj44 + obj47;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
															bool flag25 = (nint)0 == 0;
															obj11 = obj46;
															obj13 = obj47;
															num3 = num16;
															num4 = num17;
															obj21 = 0;
															ex = null;
															obj27 = (object)(&obj28);
															num = num18;
															list2 = list;
															if (!flag25)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																bool flag26 = ((Renderer)0).enabled;
																bool flag27 = !flag26;
																_Canon = null;
																if (!flag27)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																	Transform part = ((Component)0).transform;
																	bool flag28 = Moves(part);
																	bool flag29 = !flag28;
																	object obj50 = !flag29;
																	_Canon = null;
																	if (obj50 == null)
																	{
																		bool flag30 = list == null;
																		obj11 = obj46;
																		obj13 = obj47;
																		num3 = num16;
																		num4 = num17;
																		obj21 = 0;
																		ex = null;
																		obj27 = (object)(&obj28);
																		num = num18;
																		_Canon = null;
																		list2 = list;
																		if (!flag30)
																		{
																			System.__Canon[] items = list._items;
																			num = (int)obj10;
																			num4 = ++list._version;
																			bool flag31 = list._items == null;
																			obj11 = obj46;
																			obj13 = obj47;
																			num3 = num16;
																			obj21 = 0;
																			ex = null;
																			obj27 = (object)(&obj28);
																			_Canon = null;
																			list2 = list;
																			if (!flag31)
																			{
																				num17 = list._size;
																				obj46 = items.Length;
																				bool flag32 = list._size < items.Length;
																				object obj51 = !flag32;
																				if (obj51 == null)
																				{
																					object obj52 = list._items + list._size;
																					num18 = ++list._size;
																					object obj53 = obj52 + 32;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																					obj53 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																					_Canon = (System.__Canon)0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X9_v19 (System.Int32)+20]");
																					object obj54 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X8_v80+A8]");
																					object obj55 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ X8_v81+70]");
																					num16 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																					list.AddWithResize((System.__Canon)0);
																					num18 = (int)obj10;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+20]");
																					_Canon = (System.__Canon)0;
																				}
																				goto IL_0993;
																			}
																		}
																		goto IL_1444;
																	}
																}
																goto IL_0993;
															}
															goto IL_1436;
															IL_0993:
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v115+18]");
															obj45 = 0;
															obj13 = obj47 + 1;
															object obj56 = obj13;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v115+18]");
															bool flag33 = (nint)obj56 < 0;
															obj11 = obj46;
															num3 = num16;
															num4 = num17;
															num = num18;
															obj47 = obj13;
															if (flag33)
															{
																continue;
															}
															goto IL_09fd;
														}
														goto IL_1428;
													}
												}
											}
										}
									}
								}
								goto IL_09fd;
							}
						}
						InvalidCastException ex5 = new InvalidCastException();
					}
					NullReferenceException ex6 = new NullReferenceException();
					_Canon = (System.__Canon)(object)obj32;
					goto IL_141a;
					IL_141a:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_1428;
					IL_1436:
					NullReferenceException ex8 = new NullReferenceException();
					goto IL_1444;
					IL_1444:
					NullReferenceException ex9 = new NullReferenceException();
					obj12 = obj11;
					obj14 = obj13;
					num5 = num4;
					goto IL_146a;
					IL_1478:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_1487;
				}
				while (obj31 != null);
			}
			throw new NullReferenceException();
		}
		goto IL_13c9;
		IL_13e3:
		obj13 = obj14;
		throw new IndexOutOfRangeException();
		IL_0bb0:
		if ((nint)obj24 != 7)
		{
			bool flag34 = obj24 == null;
			object obj57 = !flag34;
			if (obj57 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5088]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj59 = 0;
		GameObject gameObject = GameObject.Find((string)obj58);
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v14+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v14+E4]");
		bool flag35 = (nint)0 == 0;
		object obj61 = !flag35;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag36 = gameObject != null;
		bool flag37 = !flag36;
		nint num19 = unchecked((nint)null);
		obj3 = null;
		if (flag37)
		{
			goto IL_0ff5;
		}
		bool flag38 = (object)gameObject == null;
		obj3 = null;
		if (!flag38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5058]");
			object obj62 = 0;
			num19 = (nint)obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj63 = default;
			bool flag39 = obj63 == null;
			obj3 = (UnityEngine.Object)1;
			if (!flag39)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+18]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+18]");
				bool flag40 = (nint)0 < (nint)1;
				obj3 = (UnityEngine.Object)1;
				if (flag40)
				{
					goto IL_0ff5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
				object obj65 = 0;
				object obj11 = obj12;
				nint num3 = (nint)obj62;
				int num4 = num5;
				UnityEngine.Object obj32 = (UnityEngine.Object)1;
				GillaAreas gillaAreas = null;
				while (true)
				{
					bool flag41 = System.Runtime.CompilerServices.Unsafe.As<GillaAreas, UIntPtr>(ref gillaAreas) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64);
					object obj66 = !flag41;
					if (obj66 != null)
					{
						break;
					}
					object obj67 = obj63 + (object)gillaAreas;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
					bool flag42 = (nint)0 == 0;
					obj3 = obj32;
					if (!flag42)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
						bool flag43 = ((Renderer)0).enabled;
						bool flag44 = !flag43;
						obj3 = null;
						if (flag44)
						{
							goto IL_0f93;
						}
						bool flag45 = list2 == null;
						obj3 = null;
						if (!flag45)
						{
							System.__Canon[] items2 = list2._items;
							num = (int)obj65;
							int version = list2._version + 1;
							list2._version = version;
							bool flag46 = list2._items == null;
							obj3 = null;
							if (!flag46)
							{
								num4 = list2._size;
								obj11 = items2.Length;
								bool flag47 = list2._size < items2.Length;
								object obj68 = !flag47;
								if (obj68 == null)
								{
									object obj69 = list2._items + list2._size;
									num = list2._size + 1;
									list2._size = num;
									object obj70 = obj69 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
									obj70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
									obj3 = (UnityEngine.Object)0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X9_v19 (System.Int32)+20]");
									object obj71 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v38+A8]");
									object obj72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X8_v39+70]");
									num3 = 0;
									List<System.__Canon> list3 = list2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
									list3.AddWithResize((System.__Canon)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+20]");
									obj3 = (UnityEngine.Object)0;
								}
								goto IL_0f93;
							}
						}
					}
					goto IL_13c9;
					IL_0f93:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+18]");
					obj64 = 0;
					gillaAreas = (GillaAreas)(gillaAreas + 1);
					GillaAreas gillaAreas3 = gillaAreas;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+18]");
					bool flag48 = (nint)gillaAreas3 < 0;
					obj12 = obj11;
					num19 = num3;
					num5 = num4;
					obj32 = obj3;
					if (flag48)
					{
						continue;
					}
					goto IL_0ff5;
				}
				goto IL_13e3;
			}
		}
		goto IL_13c9;
		IL_0ff5:
		if (list2 != null)
		{
			System.__Canon[] array = list2.ToArray();
			list2 = (List<System.__Canon>)(gillaAreas2 + 40);
			list2 = (List<System.__Canon>)(object)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			nint num20 = (nint)list2;
			bool flag49 = list2 == null;
			obj3 = (UnityEngine.Object)(object)array;
			if (!flag49)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj74 = gillaAreas2 + 48;
				UnityEngine.Object obj75 = default;
				obj74 = obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X21_v12-8]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X21_v12-8]");
				bool flag50 = (nint)0 == 0;
				obj3 = obj75;
				if (!flag50)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj78 = gillaAreas2 + 56;
					UnityEngine.Object obj79 = default;
					obj78 = obj79;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v12-10]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v12-10]");
					bool flag51 = (nint)0 == 0;
					obj3 = obj79;
					if (!flag51)
					{
						UnityEngine.Object obj32 = obj79;
						GillaAreas gillaAreas = (GillaAreas)32;
						object obj80 = 0;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v22 (Il2CppClass<System.Collections.Generic.List`1<System.__Canon>>)+18]");
							num = 0;
							object obj81 = obj80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v22 (Il2CppClass<System.Collections.Generic.List`1<System.__Canon>>)+18]");
							bool flag52 = (nint)obj81 >= 0;
							obj3 = obj32;
							if (!flag52)
							{
								object obj82 = obj80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v22 (Il2CppClass<System.Collections.Generic.List`1<System.__Canon>>)+18]");
								bool flag53 = (nint)obj82 < 0;
								object obj83 = !flag53;
								object obj11 = obj12;
								nint num3 = num19;
								int num4 = num5;
								object obj5 = 1;
								if (obj83 != null)
								{
									break;
								}
								object obj84 = num21 + obj80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v23+20]");
								bool flag54 = (nint)0 == 0;
								obj3 = obj32;
								if (!flag54)
								{
									object obj6 = obj74;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v23+20]");
									Bounds bounds = ((Renderer)0).bounds;
									bool flag55 = obj74 == null;
									obj3 = null;
									if (!flag55)
									{
										object obj85 = obj80;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X25_v7+18]");
										bool flag56 = (nint)obj85 < 0;
										object obj86 = !flag56;
										obj11 = obj12;
										num3 = num19;
										num4 = num5;
										obj5 = 1;
										obj32 = null;
										if (obj86 != null)
										{
											break;
										}
										object obj87 = obj74 + (object)gillaAreas;
										obj87 = obj27;
										object obj88 = obj78;
										bool flag57 = obj78 == null;
										obj3 = null;
										if (!flag57)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v27+18]");
											num = 0;
											object obj89 = obj80;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v27+18]");
											bool flag58 = (nint)obj89 < 0;
											object obj90 = !flag58;
											object obj91 = obj27;
											obj11 = obj12;
											num3 = num19;
											num4 = num5;
											obj5 = 1;
											obj32 = null;
											if (obj90 != null)
											{
												break;
											}
											object obj92 = obj78 + obj80;
											obj80++;
											gillaAreas = (GillaAreas)(gillaAreas + 24);
											_ = 1;
											num21 = (nint)list2;
											bool flag59 = list2 == null;
											object obj93 = !flag59;
											obj3 = null;
											obj91 = obj27;
											obj32 = null;
											if (obj93 != null)
											{
												continue;
											}
										}
									}
								}
								goto IL_13c9;
							}
							gillaAreas2.Settle();
							return;
						}
						goto IL_13e3;
					}
				}
			}
		}
		goto IL_13c9;
		IL_13c9:
		throw new NullReferenceException();
	}

	public static bool Moves(Transform part)
	{
		//IL_03f2: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I
		//IL_0432: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_03e2: Expected I4, but got Obj
		//IL_00ce: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5090]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5098]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A0]");
		object obj5 = 0;
		Transform transform = part;
		object obj15 = default;
		object obj17 = default;
		while (true)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (transform != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (transform == part)
				{
					bool flag3 = (object)transform == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						break;
					}
				}
				else
				{
					if ((object)transform == null)
					{
						break;
					}
					Transform parent = transform.parent;
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v12+E4]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v12+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(parent != null))
					{
						goto IL_03b8;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
				object obj14 = obj15 & 1;
				bool flag5 = obj14 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F73C");
					if (obj17 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v22+18]");
					if ((nint)0 >= (nint)1)
					{
						object obj12 = obj4;
						object obj18 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v22+18]");
						object obj19 = ~(nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v22+18]");
						object obj20 = 0 & obj19;
						object obj21 = 0;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v22+18]");
							if (0 == (nint)obj21)
							{
								break;
							}
							object obj22 = obj17 + obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X13_v7+20]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X13_v7+20]");
							if ((nint)0 != 0)
							{
								object obj24 = obj23;
								if (obj23 == obj12)
								{
									goto IL_035b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X13_v5+130]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X10_v5+130]");
								bool flag6 = num < 0;
								object obj25 = !flag6;
								object obj26 = ~obj25;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X13_v5+B0]");
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X10_v5+130]");
									object obj27 = num2 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X13_v12-8]");
									obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X13_v12-8]");
									if (0 == (nint)obj18)
									{
										goto IL_035b;
									}
								}
							}
							goto IL_03aa;
							IL_035b:
							object obj28 = obj21 + 1;
							bool flag7 = obj20 != obj28;
							obj21 = obj28;
							if (!flag7)
							{
								goto IL_0390;
							}
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
					goto IL_0390;
				}
				goto IL_03aa;
			}
			goto IL_03b8;
			IL_0390:
			Transform parent2 = transform.parent;
			transform = parent2;
			continue;
			IL_03aa:
			return true;
			IL_03b8:
			return false;
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private static Vector3 Eyes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0109: Expected VT, but got I4
		//IL_00bb: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		if (flag2)
		{
			if ((object)main != null)
			{
				Transform transform = main.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		return (Vector3)flag2;
	}

	private void Update()
	{
		Step();
	}

	public void Step()
	{
		//IL_0060: Expected Obj, but got VT
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_014e: Expected VT, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b0: Expected I4, but got Obj
		//IL_0140: Expected VT, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01f0: Expected VT, but got I4
		Renderer[] array = renderers;
		if (renderers != null && array.Length != 0)
		{
			Vector3 vector = Eyes();
			Vector3 vector2 = default;
			object obj = vector2 - last;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaAreas)+4C]");
			object obj3 = default;
			object obj2 = obj3 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaAreas)+50]");
			object obj5 = default;
			object obj4 = obj5 - 0;
			object obj6 = obj * obj;
			object obj7 = obj2 * obj2;
			object obj8 = obj6 + obj7;
			object obj9 = obj4 * obj4;
			object obj10 = obj8 + obj9;
			int num;
			Renderer[] array3;
			if ((nint)obj10 > 1132462080)
			{
				Renderer[] array2 = renderers;
				num = array2.Length;
				jumpLeft = array2.Length;
				array3 = array2;
			}
			else
			{
				num = jumpLeft;
				array3 = renderers;
			}
			bool flag = num < 0;
			bool flag2 = num == 0;
			int num2 = num ^ num;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj11 = !flag2;
			object obj12 = flag4 & obj11;
			object obj13 = ~obj12;
			Vector3 vector3 = ((obj13 != null) ? ((Vector3)120) : ((Vector3)2000));
			last = vector2;
			object obj14 = num - vector3;
			object obj15 = ~obj14;
			int num4 = obj14 & obj15;
			jumpLeft = num4;
			object obj16 = vector3 - array3.Length;
			bool flag5 = (nint)obj16 < 0;
			object obj17 = vector3 ^ array3.Length;
			object obj18 = vector3 ^ obj16;
			object obj19 = obj17 & obj18;
			bool flag6 = (nint)obj19 < 0;
			bool flag7 = flag5 == flag6;
			object obj20 = !flag7;
			object obj21 = ~obj20;
			Vector3 eyes = ((obj21 != null) ? ((Vector3)array3.Length) : vector3);
			int count = default;
			Look(eyes, count);
		}
	}

	private unsafe void Look(Vector3 eyes, int count)
	{
		//IL_0400: Invalid comparison between VT and I4
		//IL_0015: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0066: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected VT, but got Unknown
		//IL_00fe: Expected Ref, but got VT
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected VT, but got Unknown
		//IL_03c2: Invalid comparison between VT and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_03a6: Expected Obj, but got I
		if (eyes < (object)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Vector3 vector = eyes;
		UnityEngine.Object obj2 = (UnityEngine.Object)109891584;
		Vector3 point = default;
		Vector3 vector2 = default;
		while (true)
		{
			Renderer[] array = renderers;
			object obj11;
			if (renderers != null)
			{
				object obj3 = next + 1;
				object obj4 = obj3 / array.Length;
				object obj5 = obj4 * array.Length;
				int num = obj3 - obj5;
				Bounds[] array2 = boxes;
				next = num;
				if (boxes != null)
				{
					bool flag = next < array2.Length;
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = next * 24;
					object obj8 = (object)boxes + obj7;
					Bounds bounds = (Bounds)(obj8 + 32);
					float num2 = ((Bounds*)bounds)->Internal_SqrDistance(ref point);
					bool[] array3 = on;
					if (on != null)
					{
						bool flag2 = next < array3.Length;
						object obj9 = !flag2;
						if (obj9 != null)
						{
							break;
						}
						object obj10 = on + next;
						obj11 = obj10 + 32;
						if (obj11 != null)
						{
							float num3 = far * far;
							if (!(num2 < num3))
							{
								goto IL_01fb;
							}
						}
						else
						{
							float num3 = near * near;
							if (num2 < num3)
							{
								goto IL_01fb;
							}
						}
						goto IL_03ab;
					}
				}
			}
			goto IL_03e2;
			IL_03ab:
			vector--;
			bool flag3 = vector != (Vector3)(object)1;
			point = vector2;
			if (!flag3)
			{
				return;
			}
			continue;
			IL_01fb:
			Renderer[] array4 = renderers;
			object obj12 = obj11 ^ 1;
			obj11 = obj12;
			if (renderers != null)
			{
				bool flag4 = next < array4.Length;
				object obj13 = !flag4;
				if (obj13 != null)
				{
					break;
				}
				object obj14 = obj;
				object obj15 = renderers + next;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v16+20]");
				obj2 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v10+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(obj2 != null))
				{
					goto IL_03ab;
				}
				Renderer[] array5 = renderers;
				if (renderers != null)
				{
					bool flag6 = next < array5.Length;
					object obj17 = !flag6;
					if (obj17 != null)
					{
						break;
					}
					object obj18 = renderers + next;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v18+20]");
					if ((nint)0 != 0)
					{
						bool flag7 = obj11 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v18+20]");
						((Renderer)0).enabled = flag7;
						goto IL_03ab;
					}
				}
			}
			goto IL_03e2;
			IL_03e2:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	public void Settle()
	{
		//IL_0080: Expected VT, but got I4
		Vector3 vector = Eyes();
		Renderer[] array = renderers;
		Vector3 vector2 = default;
		last = vector2;
		jumpLeft = 0;
		if (renderers != null && array.Length >= 1)
		{
			int count = default;
			Look((Vector3)array.Length, count);
		}
	}

	public void ShowAll()
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00d3: Expected I, but got Obj
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0156: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I4
		Renderer[] array = renderers;
		if (renderers == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = 0;
		while (true)
		{
			if ((nint)obj2 >= array.Length)
			{
				return;
			}
			bool flag = (nint)obj2 < array.Length;
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			object obj4 = obj;
			object obj5 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v7+20]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			object obj7 = 0;
			nint num = unchecked((nint)null);
			if (!flag4)
			{
				bool[] array2 = on;
				bool flag5 = (nint)obj2 < array2.Length;
				object obj8 = !flag5;
				if (obj8 != null)
				{
					break;
				}
				object obj9 = (object)array2 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v12+20]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				obj7 = 0;
				num = unchecked((nint)null);
				if (obj10 == null)
				{
					Renderer[] array3 = renderers;
					bool flag7 = (nint)obj2 < array3.Length;
					object obj11 = !flag7;
					if (obj11 != null)
					{
						break;
					}
					object obj12 = (object)array3 + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v15+20]");
					((Renderer)0).enabled = true;
					bool[] array4 = on;
					bool flag8 = (nint)obj2 < array4.Length;
					object obj13 = !flag8;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = (object)array4 + obj2;
					_ = 1;
					obj7 = 0;
					num = 1;
				}
			}
			array = renderers;
			obj2++;
			bool flag9 = renderers == null;
			object obj15 = !flag9;
			if (obj15 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	public GillaAreas()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C4F0]");
		near = 0f;
		base._002Ector();
	}
}
