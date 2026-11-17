using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class MonsterOnShow : MonoBehaviour
{
	private const string SoonDots = null;

	private static readonly Color Soon;

	private static readonly int BaseColor;

	private static readonly int ColorId;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_0286;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_00fe;
		}
		object obj4 = obj2 + 32;
		object obj5 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X23_v6+v85 @ X22_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X23_v6+v85 @ X22_v7*8]");
				((Animator)0).fireEvents = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X23_v6+v85 @ X22_v7*8]");
				((Animator)0).cullingMode = (AnimatorCullingMode)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				obj3 = 0;
				obj5++;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				if ((nint)obj7 < 0)
				{
					continue;
				}
				goto IL_00fe;
			}
			goto IL_0286;
		}
		goto IL_0294;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj8 = 0;
		string text = name;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (MonsterChoice.ComingSoon(text))
		{
			Dotted();
		}
		return;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0C0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v10+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_01f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v10+18]");
			object obj13 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v10+18]");
			object obj14 = 0 & obj13;
			object obj15 = 0;
			while (true)
			{
				object obj16 = obj12 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X11_v5+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				obj15++;
				_ = 0;
				if (obj14 != obj15)
				{
					continue;
				}
				goto IL_01f3;
			}
		}
		goto IL_0286;
		IL_0286:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0294;
		IL_0294:
		throw new IndexOutOfRangeException();
	}

	private void Dotted()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_03da: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I8
		//IL_00bd: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_019e: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_030a: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I8
		//IL_0229: Expected Obj, but got I4
		//IL_042c: Expected I4, but got Obj
		//IL_0402: Expected Obj, but got I4
		//IL_0407: Expected I, but got Obj
		//IL_0236: Expected I, but got Obj
		//IL_0264: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA360]");
		Material[] array = (Material[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		Material material = default;
		bool flag = (object)material == null;
		object obj3 = !flag;
		Material material2 = material;
		if (obj3 == null)
		{
			Material material3 = NearestDots();
			material2 = material3;
		}
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
		object obj7 = 0 & 0xFFFFFFFFL;
		ShadowCastingMode shadowCastingMode = (ShadowCastingMode)1;
		object obj8 = 0;
		object obj12 = default;
		Material[] array2 = default;
		IndexOutOfRangeException ex = default;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj9 = !flag2;
			if (obj9 == null)
			{
				object obj10 = obj4;
				object obj11 = obj12 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (material2 == null)
				{
					object obj14 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v34+E4]");
					bool flag4 = (nint)0 == 0;
					object obj15 = !flag4;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+20]");
					Redden((Renderer)0);
					num = unchecked((nint)null);
					shadowCastingMode = (ShadowCastingMode)0;
					goto IL_0318;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+20]");
				Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
				Material material4 = (Material)sharedMaterials.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				if (array2.Length >= 1)
				{
					object obj16 = array2 + 32;
					object obj17 = array2.Length & 0xFFFFFFFFL;
					object obj18 = 0;
					while (true)
					{
						bool flag5 = (object)material2 == null;
						shadowCastingMode = (ShadowCastingMode)material4;
						if (!flag5)
						{
							nint num2 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v19 (Il2CppClass<UnityEngine.Material[]>)+40]");
							shadowCastingMode = (ShadowCastingMode)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							num = unchecked((nint)null);
							if (flag6)
							{
								break;
							}
							obj17 = array2.Length;
						}
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
						object obj19 = !flag7;
						num = unchecked((nint)null);
						if (obj19 == null)
						{
							obj16 = material2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj17 = array2.Length;
							object obj20 = obj18 + 1;
							bool flag8 = (nint)obj20 < array2.Length;
							obj18 = obj20;
							material4 = material2;
							if (flag8)
							{
								continue;
							}
							goto IL_02da;
						}
						goto IL_035b;
					}
					break;
				}
				goto IL_02da;
			}
			goto IL_035b;
			IL_0318:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
			obj7 = 0;
			obj8++;
			object obj21 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
			if ((nint)obj21 >= 0)
			{
				return;
			}
			continue;
			IL_035b:
			ex = new IndexOutOfRangeException();
			break;
			IL_02da:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+20]");
			((Renderer)0).sharedMaterials = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+20]");
			((Renderer)0).shadowCastingMode = (ShadowCastingMode)0;
			num = unchecked((nint)null);
			shadowCastingMode = (ShadowCastingMode)0;
			goto IL_0318;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}

	private Material NearestDots()
	{
		//IL_0010: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj5 = default;
		if (obj5 == null)
		{
			goto IL_03d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+18]");
		Material result;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0E0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43F8]");
			object obj8 = 0;
			result = null;
			object obj9 = 0;
			object obj10 = 2139095039;
			object obj14 = default;
			object obj15 = default;
			UnityEngine.Object obj18 = default;
			object obj24 = default;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj11 = !flag2;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = obj5 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9+20]");
				if ((nint)0 == 0)
				{
					goto IL_03d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9+20]");
				string text = ((UnityEngine.Object)0).name;
				bool flag3 = text != (string)obj7;
				bool flag4 = !flag3;
				object obj13 = !flag4;
				obj14 = obj14;
				obj15 = obj15;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v12+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj18 == null;
					bool flag7 = !flag6;
					object obj19 = !flag7;
					obj14 = obj14;
					obj15 = obj15;
					if (obj19 == null)
					{
						if ((object)obj18 != null)
						{
							Material sharedMaterial = ((Renderer)obj18).sharedMaterial;
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13+E4]");
							bool flag8 = (nint)0 == 0;
							object obj21 = !flag8;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag9 = sharedMaterial == null;
							bool flag10 = !flag9;
							object obj22 = !flag10;
							obj14 = obj14;
							obj15 = obj15;
							if (obj22 != null)
							{
								goto IL_043a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9+20]");
							Transform transform = ((Component)0).transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									Vector3 position2 = transform2.position;
									object obj23 = obj24 - obj24;
									object obj25 = obj15 - obj15;
									obj14 -= obj14;
									object obj26 = obj23 * obj23;
									object obj27 = obj25 * obj25;
									obj24 = obj26 + obj27;
									obj15 = obj14 * obj14;
									object obj28 = obj15 + obj24;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
									{
										Material sharedMaterial2 = ((Renderer)obj18).sharedMaterial;
										result = sharedMaterial2;
										obj10 = obj28;
									}
									goto IL_043a;
								}
							}
						}
						goto IL_03d6;
					}
				}
				goto IL_043a;
				IL_043a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+18]");
				obj6 = 0;
				obj9++;
				object obj29 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+18]");
				if ((nint)obj29 < 0)
				{
					continue;
				}
				goto IL_047c;
			}
			goto IL_03e4;
		}
		result = null;
		goto IL_047c;
		IL_047c:
		return result;
		IL_03d6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03e4;
		IL_03e4:
		return (Material)(object)new IndexOutOfRangeException();
	}

	private static void Redden(Renderer r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I8
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0654: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_04de: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_0224: Expected VT, but got I4
		//IL_037f: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I
		//IL_057e: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0337: Expected VT, but got I4
		//IL_0340: Expected VT, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04a9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		if ((object)r != null)
		{
			Material[] sharedMaterials = r.sharedMaterials;
			if (sharedMaterials != null)
			{
				if (sharedMaterials.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0D0]");
				object obj3 = 0;
				object obj4 = sharedMaterials.Length & 0xFFFFFFFFL;
				object obj5 = sharedMaterials + 32;
				int num = 0;
				MaterialPropertyBlock materialPropertyBlock2 = null;
				object obj24 = default;
				object obj26 = default;
				object obj28 = default;
				object obj29 = default;
				while (true)
				{
					bool flag = num < (nint)obj4;
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v12+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
					bool flag3 = (UnityEngine.Object)0 == null;
					bool flag4 = !flag3;
					object obj9 = !flag4;
					int num2 = 0;
					materialPropertyBlock2 = null;
					if (obj9 == null)
					{
						r.GetPropertyBlock(materialPropertyBlock, num);
						object obj10 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v18+E4]");
						bool flag5 = (nint)0 == 0;
						object obj11 = !flag5;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
						if ((nint)0 == 0)
						{
							goto IL_050b;
						}
						object obj12 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v13+A0]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v14+10]");
						int num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v14+10]");
						bool flag6 = ((Material)num4).HasProperty(0);
						bool flag7 = !flag6;
						Color color = (Color)0;
						if (!flag7)
						{
							object obj14 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v39+E4]");
							bool flag8 = (nint)0 == 0;
							object obj15 = !flag8;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj14 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v39+A0]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v24+10]");
							Color color2 = ((Material)num5).GetColor(0);
							if (materialPropertyBlock == null)
							{
								goto IL_050b;
							}
							object obj17 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v25+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+C]");
							object obj20 = 0;
							object obj21 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+4]");
							object obj22 = 0;
							object obj23 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+C]");
							obj24 = obj23 * 0;
							object obj25 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+8]");
							obj26 = obj25 * 0;
							object obj27 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v26+4]");
							obj28 = obj27 * 0;
							obj29 *= obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v24+10]");
							materialPropertyBlock.SetColor(0, (Color)0);
							color = (Color)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v24+10]");
							num3 = 0;
						}
						object obj30 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v24+E4]");
						bool flag9 = (nint)0 == 0;
						object obj31 = !flag9;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj30 = obj3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v24+A0]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v17+14]");
						if (((Material)num6).HasProperty(0))
						{
							object obj33 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v30+E4]");
							bool flag10 = (nint)0 == 0;
							object obj34 = !flag10;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v30+A0]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X27_v5+v103 @ X22_v6 (System.Int32)*8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v20+14]");
							Color color3 = ((Material)num7).GetColor(0);
							if (materialPropertyBlock == null)
							{
								goto IL_050b;
							}
							object obj36 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v21+A0]");
							object obj37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+C]");
							object obj20 = 0;
							object obj21 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+4]");
							object obj22 = 0;
							object obj38 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+C]");
							obj24 = obj38 * 0;
							object obj39 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+8]");
							obj26 = obj39 * 0;
							object obj40 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v22+4]");
							obj28 = obj40 * 0;
							obj29 *= obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v20+14]");
							materialPropertyBlock.SetColor(0, (Color)0);
						}
						r.SetPropertyBlock(materialPropertyBlock, num);
						num2 = num;
						materialPropertyBlock2 = materialPropertyBlock;
					}
					obj4 = sharedMaterials.Length;
					num++;
					if (num >= sharedMaterials.Length)
					{
						return;
					}
				}
				goto IL_0519;
			}
		}
		goto IL_050b;
		IL_050b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0519;
		IL_0519:
		throw new IndexOutOfRangeException();
	}

	static MonsterOnShow()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD0D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7858]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD40]");
		obj5 = 0;
		int num = Shader.PropertyToID((string)obj2);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj7 = 0;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+A0]");
		object obj9 = 0;
	}
}
