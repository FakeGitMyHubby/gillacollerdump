using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ApeColor : MonoBehaviour
{
	public Renderer body;

	public Renderer[] parts;

	public int materialIndex;

	public Texture2D tintTexture;

	public Color furColor;

	private static Color32[] source;

	private static Texture2D sourceTex;

	private Texture2D tex;

	private Material mat;

	private Renderer[] kept;

	private Material[][] madeWith;

	private static readonly List<Material> now;

	private static readonly HashSet<(int, int)> told;

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4160]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4168]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3907440");
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_005c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mat == null)
		{
			SetColor((Color)0);
		}
	}

	private void MakeMaterial()
	{
		//IL_0036: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_0392: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03da: Expected I4, but got Obj
		//IL_0421: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I8
		//IL_0111: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_0aa3: Expected Obj, but got I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_084b: Expected Obj, but got I
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I8
		//IL_0538: Expected Obj, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0895: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I4
		//IL_05bf: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I4
		//IL_07ca: Expected Obj, but got I4
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected Obj, but got Unknown
		//IL_0a6b: Expected Obj, but got I4
		//IL_0a74: Expected Obj, but got I4
		//IL_0622: Expected Obj, but got I4
		//IL_026f: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I4
		//IL_0997: Expected Obj, but got I4
		//IL_069b: Expected I4, but got Obj
		//IL_093f: Expected Obj, but got I
		//IL_0968: Expected Obj, but got I
		//IL_06e0: Expected Obj, but got I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Obj, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_0a0a: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_073e: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I
		Material[] materials = body.materials;
		bool flag = materialIndex < materials.Length;
		object obj = !flag;
		System.__Canon _Canon = null;
		Material[] array2 = default;
		object obj9 = default;
		IndexOutOfRangeException ex = default;
		if (obj == null)
		{
			object obj2 = materials + materialIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v8+20]");
			Material[] array = (Material[])0;
			object obj3 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v8+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X20_v8-30]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X20_v8-30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X24_v6+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X24_v6+18]");
					object obj5 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X20_v8-30]");
					object obj7 = (nint)0 + (nint)32;
					Material[] array3 = default;
					array2 = array3;
					object obj8 = obj9;
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v8+20]");
					_Canon = (System.__Canon)0;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
						object obj11 = !flag2;
						obj9 = obj8;
						if (obj11 != null)
						{
							break;
						}
						object obj12 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v57+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X27_v9+v101 @ X25_v12*8]");
						bool flag4 = (UnityEngine.Object)0 == null;
						bool flag5 = !flag4;
						object obj14 = !flag5;
						obj9 = 0;
						array = null;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X27_v9+v101 @ X25_v12*8]");
							Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
							object obj15 = sharedMaterials.Length;
							bool flag6 = materialIndex >= sharedMaterials.Length;
							array2 = sharedMaterials;
							obj9 = 0;
							array = null;
							if (!flag6)
							{
								bool flag7 = obj3 == null;
								Material[] array4 = null;
								if (!flag7)
								{
									nint num = (nint)sharedMaterials;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v45 (Il2CppClass<UnityEngine.Material[]>)+40]");
									array4 = (Material[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag8 = ex == null;
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v45 (Il2CppClass<UnityEngine.Material[]>)+40]");
									_Canon = (System.__Canon)0;
									if (flag8)
									{
										goto IL_0a3a;
									}
									obj15 = sharedMaterials.Length;
								}
								bool flag9 = materialIndex < (nint)obj15;
								object obj16 = !flag9;
								obj9 = 0;
								_Canon = (System.__Canon)(object)array4;
								if (obj16 != null)
								{
									break;
								}
								object obj17 = sharedMaterials + materialIndex;
								object obj18 = obj17 + 32;
								obj18 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X27_v9+v101 @ X25_v12*8]");
								((Renderer)0).sharedMaterials = sharedMaterials;
								array2 = sharedMaterials;
								obj9 = 0;
								array = sharedMaterials;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X24_v6+18]");
						obj5 = 0;
						obj10++;
						object obj19 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X24_v6+18]");
						bool flag10 = (nint)obj19 < 0;
						obj8 = obj9;
						_Canon = (System.__Canon)(object)array;
						if (flag10)
						{
							continue;
						}
						goto IL_0382;
					}
					goto IL_0a2c;
				}
			}
			goto IL_0382;
		}
		goto IL_0a2c;
		IL_07fe:
		List<System.__Canon> list = default;
		System.__Canon[] array5 = list.ToArray();
		object obj20 = this + 96;
		obj20 = array5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj23 = this + 104;
		System.__Canon _Canon2 = default;
		obj23 = _Canon2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X19_v7-8]");
		object obj24 = 0;
		object obj25 = 0;
		_Canon = _Canon2;
		while (true)
		{
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v19+18]");
			if ((nint)obj26 >= 0)
			{
				return;
			}
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v19+18]");
			bool flag11 = (nint)obj27 < 0;
			object obj28 = !flag11;
			if (obj28 != null)
			{
				break;
			}
			object obj29 = obj24 + obj25;
			object obj30 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v20+20]");
			Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
			bool flag12 = sharedMaterials2 == null;
			System.__Canon _Canon3 = null;
			if (!flag12)
			{
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v24+40]");
				_Canon3 = (System.__Canon)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag13 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v24+40]");
				_Canon = (System.__Canon)0;
				if (flag13)
				{
					goto IL_0a3a;
				}
			}
			object obj32 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X24_v9+18]");
			bool flag14 = (nint)obj32 < 0;
			object obj33 = !flag14;
			_Canon = _Canon3;
			if (obj33 != null)
			{
				break;
			}
			object obj34 = obj30 + obj25;
			obj25++;
			object obj35 = obj34 + 32;
			obj35 = sharedMaterials2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj24 = obj20;
			bool flag15 = obj20 == null;
			object obj36 = !flag15;
			_Canon = (System.__Canon)(object)sharedMaterials2;
			if (obj36 == null)
			{
				throw new NullReferenceException();
			}
		}
		goto IL_0a2c;
		IL_0382:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
		object obj38 = 0;
		System.__Canon[] items = list._items;
		_Canon = (System.__Canon)(object)body;
		int num2 = (int)obj38;
		int version = list._version + 1;
		list._version = version;
		bool flag16 = list._size < items.Length;
		object obj39 = !flag16;
		if (obj39 == null)
		{
			object obj40 = items + list._size;
			num2 = list._size + 1;
			list._size = num2;
			object obj41 = obj40 + 32;
			obj41 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X9_v14 (System.Int32)+20]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v35+A8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v36+70]");
			obj9 = 0;
			list.AddWithResize((System.__Canon)(object)body);
		}
		Renderer[] array6 = parts;
		if (parts == null || array6.Length < 1)
		{
			goto IL_07fe;
		}
		object obj44 = array6.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj45 = 0;
		object obj46 = parts + 32;
		UnityEngine.Object obj47 = (UnityEngine.Object)(object)array2;
		object obj48 = obj9;
		object obj49 = 0;
		while (true)
		{
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44);
			object obj50 = !flag17;
			obj9 = obj48;
			if (obj50 != null)
			{
				break;
			}
			object obj51 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X0_v37+E4]");
			bool flag18 = (nint)0 == 0;
			object obj52 = !flag18;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
			bool flag19 = (UnityEngine.Object)0 != null;
			bool flag20 = !flag19;
			obj9 = 0;
			_Canon = null;
			if (!flag20)
			{
				object obj53 = obj45;
				obj47 = body;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X0_v42+E4]");
				bool flag21 = (nint)0 == 0;
				object obj54 = !flag21;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
				bool flag22 = (UnityEngine.Object)0 != obj47;
				bool flag23 = !flag22;
				obj9 = 0;
				_Canon = (System.__Canon)(object)obj47;
				if (!flag23)
				{
					System.__Canon[] items2 = list._items;
					num2 = (int)obj38;
					int version2 = list._version + 1;
					list._version = version2;
					bool flag24 = list._size < items2.Length;
					object obj55 = !flag24;
					if (obj55 == null)
					{
						object obj56 = items2 + list._size;
						num2 = list._size + 1;
						list._size = num2;
						object obj57 = obj56 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
						obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
						_Canon = (System.__Canon)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X9_v14 (System.Int32)+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v33+A8]");
						object obj59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v34+70]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
						list.AddWithResize((System.__Canon)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X27_v8+v103 @ X25_v9*8]");
						_Canon = (System.__Canon)0;
					}
				}
			}
			obj44 = array6.Length;
			obj49++;
			bool flag25 = (nint)obj49 < array6.Length;
			obj48 = obj9;
			if (flag25)
			{
				continue;
			}
			goto IL_07fe;
		}
		goto IL_0a2c;
		IL_0a3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0a2c:
		ex = new IndexOutOfRangeException();
		goto IL_0a3a;
	}

	private unsafe void LateUpdate()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0023: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected Obj, but got Unknown
		//IL_11cf: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I
		//IL_14c2: Expected Obj, but got I4
		//IL_1256: Expected Obj, but got I
		//IL_1266: Expected Obj, but got I
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_039e: Expected I4, but got Obj
		//IL_05a4: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_054f: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected Obj, but got Unknown
		//IL_131b: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I4
		//IL_12a3: Expected Obj, but got I
		//IL_12ca: Expected Obj, but got I4
		//IL_117f: Expected Obj, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I8
		//IL_0430: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_14e9: Expected Obj, but got I4
		//IL_04a7: Expected Obj, but got I4
		//IL_1332: Expected Obj, but got I4
		//IL_1340: Expected Obj, but got I4
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_137e: Expected I4, but got Obj
		//IL_068d: Expected Obj, but got I4
		//IL_06d2: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I4
		//IL_074f: Expected Obj, but got I4
		//IL_078d: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I4
		//IL_092a: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I
		//IL_0849: Expected Obj, but got I
		//IL_13e1: Expected Obj, but got I4
		//IL_0a6b: Expected Obj, but got I4
		//IL_13ff: Expected Obj, but got I
		//IL_1407: Expected I, but got Obj
		//IL_1419: Expected Obj, but got I
		//IL_1429: Expected Obj, but got I
		//IL_1469: Expected Obj, but got I4
		//IL_09b6: Expected I, but got Obj
		//IL_09da: Expected Obj, but got I4
		//IL_0aa0: Expected Obj, but got I
		//IL_0aa8: Expected I4, but got Obj
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected Obj, but got Unknown
		//IL_0ad8: Expected VT, but got I4
		//IL_0b03: Expected Obj, but got I
		//IL_0b6b: Expected I, but got Obj
		//IL_0b7b: Expected Obj, but got I
		//IL_0ba4: Expected Obj, but got I
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Expected Obj, but got Unknown
		//IL_0c0a: Expected Obj, but got I
		//IL_0c98: Expected Obj, but got I8
		//IL_0c3d: Expected I, but got Obj
		//IL_0c4d: Expected Obj, but got I
		//IL_0c76: Expected Obj, but got I
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected Obj, but got Unknown
		//IL_0ced: Expected Obj, but got I
		//IL_0d13: Expected Obj, but got Ref
		//IL_0d8c: Expected Obj, but got I4
		//IL_0d9c: Expected Obj, but got I4
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected Obj, but got Unknown
		//IL_0d29: Expected I, but got Obj
		//IL_0d39: Expected Obj, but got I
		//IL_0d62: Expected Obj, but got I
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected Obj, but got Unknown
		//IL_0e12: Expected Obj, but got I4
		//IL_0e52: Expected Obj, but got I4
		//IL_0e8d: Expected Obj, but got I
		//IL_0fae: Expected Obj, but got I
		//IL_1065: Expected Obj, but got I8
		//IL_0ecd: Expected Obj, but got I4
		//IL_0ffa: Expected I, but got Obj
		//IL_100a: Expected Obj, but got I
		//IL_1043: Expected Obj, but got I
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected Obj, but got Unknown
		//IL_10d8: Expected Obj, but got I
		//IL_1112: Expected Obj, but got I4
		//IL_1141: Expected VT, but got I4
		//IL_0f31: Expected Obj, but got I
		//IL_0f61: Expected Obj, but got I4
		if (kept == null)
		{
			return;
		}
		int frameCount = Time.frameCount;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v5 (Il2CppClass<ApeColor>)+160]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		bool flag = ((object)this).Equals((object)0);
		object obj2 = (flag ? 1 : 0) + frameCount;
		object obj3 = obj2 & 3;
		if (obj3 != null)
		{
			return;
		}
		Renderer[] array = kept;
		if (kept == null)
		{
			goto IL_11f5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4160]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D0]");
		object obj6 = 0;
		object obj8 = default;
		object obj7 = obj8;
		int num3 = default;
		int num2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v5 (Il2CppClass<ApeColor>)+160]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		ApeColor apeColor = this;
		object obj10 = 0;
		string text = default;
		object[] array5 = default;
		int num13 = default;
		int num16 = default;
		UnityEngine.Object obj81 = default;
		IndexOutOfRangeException ex = default;
		while (true)
		{
			if ((nint)obj10 >= array.Length)
			{
				return;
			}
			bool flag2 = (nint)obj10 < array.Length;
			object obj11 = !flag2;
			obj8 = obj7;
			num3 = num2;
			obj = obj9;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj4;
			object obj13 = (object)array + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj16 = !flag5;
			num3 = 0;
			obj = null;
			if (obj16 != null)
			{
				goto IL_1195;
			}
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
			bool flag7 = (nint)0 == 0;
			obj8 = obj7;
			num3 = 0;
			obj = null;
			object obj21;
			if (!flag7)
			{
				object obj19 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v16+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v17+10]");
				((Renderer)num4).GetSharedMaterials((List<Material>)0);
				num3 = 0;
				obj21 = 0;
				int num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v17+10]");
				obj = (UnityEngine.Object)0;
				while (true)
				{
					object obj22 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+E4]");
					bool flag8 = (nint)0 == 0;
					object obj23 = !flag8;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v20+10]");
					List<System.__Canon> list = (List<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v20+10]");
					bool flag9 = (nint)0 == 0;
					obj8 = obj7;
					if (flag9)
					{
						break;
					}
					if (num5 < list._size)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+E4]");
						bool flag10 = (nint)0 == 0;
						object obj25 = !flag10;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj26 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v91+A0]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v92+10]");
							list = (List<System.__Canon>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v92+10]");
							bool flag11 = (nint)0 == 0;
							obj8 = obj7;
							if (flag11)
							{
								break;
							}
						}
						num3 = (int)obj6;
						System.__Canon _Canon = list.get_Item(num5);
						object obj33;
						if (_Canon != null)
						{
							object obj28 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v118+E4]");
							bool flag12 = (nint)0 == 0;
							object obj29 = !flag12;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj28 = obj5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v118+A0]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v88+10]");
							bool flag13 = (nint)0 == 0;
							obj8 = obj7;
							obj = (UnityEngine.Object)num5;
							if (flag13)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v88+10]");
							System.__Canon _Canon2 = ((List<System.__Canon>)0).get_Item(num5);
							object obj31 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v89+E4]");
							bool flag14 = (nint)0 == 0;
							object obj32 = !flag14;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag15 = (UnityEngine.Object)(object)_Canon2 == null;
							num3 = 0;
							System.__Canon _Canon3 = _Canon2;
							obj = null;
							obj33 = flag15;
						}
						else
						{
							obj = (UnityEngine.Object)num5;
							obj33 = 0;
						}
						object obj34 = obj21 & 1;
						num5++;
						object obj35 = obj33 | obj34;
						bool flag16 = obj35 == null;
						object obj36 = !flag16;
						obj21 = obj36;
						continue;
					}
					goto IL_04c2;
				}
			}
			goto IL_11f5;
			IL_04c2:
			object obj37 = obj21 & 1;
			if (obj37 == null)
			{
				goto IL_1195;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+E4]");
			bool flag17 = (nint)0 == 0;
			object obj38 = !flag17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v20+10]");
			List<System.__Canon> list2 = (List<System.__Canon>)0;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj39 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v80+A0]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v81+10]");
				list2 = (List<System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v81+10]");
				bool flag18 = (nint)0 == 0;
				obj8 = obj7;
				if (flag18)
				{
					goto IL_11f5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41C0]");
			nint num6 = 0;
			obj = (UnityEngine.Object)num6;
			System.__Canon[] array2 = list2.ToArray();
			bool flag19 = array2 == null;
			obj8 = obj7;
			if (!flag19)
			{
				if (array2.Length >= 1)
				{
					object obj41 = array2 + 32;
					object obj42 = array2.Length & 0xFFFFFFFFL;
					obj8 = obj7;
					text = text;
					int num7 = 0;
					System.__Canon[] array3 = array2;
					ApeColor apeColor2 = apeColor;
					while (true)
					{
						bool flag20 = num7 < (nint)obj42;
						object obj43 = !flag20;
						if (obj43 != null)
						{
							break;
						}
						UnityEngine.Object obj52;
						UnityEngine.Object obj53;
						int num11;
						UnityEngine.Object obj59;
						if (obj41 != null)
						{
							object obj44 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v33+E4]");
							bool flag21 = (nint)0 == 0;
							object obj45 = !flag21;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag22 = (UnityEngine.Object)obj41 != null;
							bool flag23 = !flag22;
							object obj46 = !flag23;
							num3 = 0;
							obj = null;
							array3 = (System.__Canon[])flag22;
							if (obj46 == null)
							{
								Material[][] array4 = apeColor2.madeWith;
								bool flag24 = apeColor2.madeWith == null;
								num3 = 0;
								obj = null;
								if (!flag24)
								{
									bool flag25 = (nint)obj10 < array4.Length;
									object obj47 = !flag25;
									num3 = 0;
									obj = null;
									if (obj47 != null)
									{
										break;
									}
									object obj48 = (object)apeColor2.madeWith + obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v31+20]");
									object obj49 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v31+20]");
									bool flag26 = (nint)0 == 0;
									num3 = 0;
									obj = null;
									if (!flag26)
									{
										int num8 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v32+18]");
										if ((nint)num8 < (nint)0)
										{
											int num9 = num7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v32+18]");
											bool flag27 = (nint)num9 < (nint)0;
											object obj50 = !flag27;
											num3 = 0;
											obj = null;
											if (obj50 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v31+20]");
											object obj51 = (nint)0 + (nint)num7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v79+20]");
											obj52 = (UnityEngine.Object)0;
										}
										else
										{
											obj52 = null;
										}
										bool flag28 = num7 != apeColor2.materialIndex;
										int num10 = 0;
										obj53 = (UnityEngine.Object)(object)text;
										UnityEngine.Object obj54 = null;
										if (!flag28)
										{
											object obj55 = obj4;
											obj53 = apeColor2.mat;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v106+E4]");
											bool flag29 = (nint)0 == 0;
											object obj56 = !flag29;
											if (obj56 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag30 = obj53 != null;
											bool flag31 = !flag30;
											num10 = 0;
											obj54 = null;
											if (!flag31)
											{
												obj52 = apeColor2.mat;
												num11 = 0;
												goto IL_0991;
											}
										}
										object obj57 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v101+E4]");
										bool flag32 = (nint)0 == 0;
										object obj58 = !flag32;
										if (obj58 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag33 = obj52 != null;
										bool flag34 = !flag33;
										num11 = 0;
										num3 = 0;
										obj59 = obj53;
										obj = null;
										if (!flag34)
										{
											goto IL_0991;
										}
										goto IL_13c6;
									}
								}
								goto IL_11f5;
							}
						}
						goto IL_1328;
						IL_1328:
						obj42 = array2.Length;
						System.__Canon _Canon3 = (System.__Canon)(num7 + 1);
						obj21 = obj41 + 8;
						bool flag35 = (nint)_Canon3 < array2.Length;
						obj7 = obj8;
						apeColor = apeColor2;
						obj41 = obj21;
						num7 = (int)_Canon3;
						if (flag35)
						{
							continue;
						}
						goto IL_116a;
						IL_1051:
						object obj60 = array5.Length & 0xFFFFFFFCL;
						bool flag36 = obj60 == null;
						int num12;
						num3 = num12;
						UnityEngine.Object obj61;
						obj = obj61;
						if (flag36)
						{
							break;
						}
						object obj62 = array5 + 56;
						string text2;
						obj62 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string text3 = string.Format(text, array5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj63 = 0;
						object obj64 = obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v62+E4]");
						num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v62+E4]");
						bool flag37 = (nint)0 == 0;
						object obj65 = !flag37;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogWarning(text3);
						(int, int) tuple = ((int, int))0;
						num13 = num7;
						num3 = 0;
						obj = null;
						array3 = (System.__Canon[])(object)text3;
						apeColor2 = this;
						goto IL_1328;
						IL_0991:
						if ((object)obj52 != null)
						{
							nint num14 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag38 = ex == null;
							object obj66 = !flag38;
							num3 = num11;
							obj59 = obj53;
							obj = obj52;
							if (obj66 == null)
							{
								num3 = num11;
								obj = obj52;
								goto IL_1211;
							}
						}
						else
						{
							num3 = num11;
							obj59 = obj53;
							obj = null;
						}
						goto IL_13c6;
						IL_0ff2:
						nint num15 = (nint)array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
						obj61 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag39 = ex == null;
						num12 = num3;
						string text4;
						text2 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
						obj = (UnityEngine.Object)0;
						if (!flag39)
						{
							goto IL_1051;
						}
						goto IL_1211;
						IL_13c6:
						bool flag40 = num7 < array2.Length;
						object obj67 = !flag40;
						if (obj67 != null)
						{
							break;
						}
						obj41 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj68 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X0_v41+E4]");
						bool flag41 = (nint)0 == 0;
						object obj69 = !flag41;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj68 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X0_v41+A0]");
						object obj70 = 0;
						num6 = (nint)obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
						((object)0).Finalize();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
						object obj71 = 0;
						obj8 = obj71;
						tuple = (num16, num7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v38+18]");
						bool flag42 = (nint)0 == 0;
						num3 = num7;
						obj = (UnityEngine.Object)num16;
						if (!flag42)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B8]");
							object obj72 = 0;
							num3 = (int)obj72;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3907F64");
							object obj73 = array3 & 1;
							bool flag43 = obj73 == null;
							tuple = ((int, int))0;
							text = (string)(object)obj59;
							obj = null;
							if (flag43)
							{
								goto IL_1328;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
							object obj74 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							string text5 = apeColor2.name;
							bool flag44 = array5 == null;
							obj = null;
							if (!flag44)
							{
								bool flag45 = text5 == null;
								UnityEngine.Object obj75 = null;
								if (!flag45)
								{
									nint num17 = (nint)array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
									obj75 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag46 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
									obj = (UnityEngine.Object)0;
									if (flag46)
									{
										goto IL_1211;
									}
								}
								bool flag47 = array5.Length == 0;
								obj = obj75;
								if (flag47)
								{
									break;
								}
								object obj76 = array5 + 32;
								obj76 = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
								string text6 = ((UnityEngine.Object)0).name;
								bool flag48 = text6 == null;
								UnityEngine.Object obj77 = null;
								if (!flag48)
								{
									nint num18 = (nint)array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
									obj77 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag49 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
									obj = (UnityEngine.Object)0;
									if (flag49)
									{
										goto IL_1211;
									}
								}
								object obj78 = array5.Length & 0xFFFFFFFEL;
								bool flag50 = obj78 == null;
								obj = obj77;
								if (flag50)
								{
									break;
								}
								object obj79 = array5 + 40;
								obj79 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj80 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								bool flag51 = (object)obj81 == null;
								UnityEngine.Object obj82 = (UnityEngine.Object)(&num13);
								if (!flag51)
								{
									nint num19 = (nint)array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
									obj82 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag52 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
									obj = (UnityEngine.Object)0;
									if (flag52)
									{
										goto IL_1211;
									}
								}
								bool flag53 = array5.Length < 2;
								object obj83 = !flag53;
								object obj84 = array5.Length - 2;
								bool flag54 = obj84 == null;
								object obj85 = ~obj83;
								object obj86 = obj85 | flag54;
								obj = obj82;
								if (obj86 != null)
								{
									break;
								}
								object obj87 = array5 + 48;
								obj87 = obj81;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag55 = num7 < array2.Length;
								object obj88 = !flag55;
								obj = obj81;
								if (obj88 != null)
								{
									break;
								}
								object obj89 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v67+E4]");
								bool flag56 = (nint)0 == 0;
								object obj90 = !flag56;
								if (obj90 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag57 = (UnityEngine.Object)obj41 != null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41F8]");
								object obj91 = 0;
								text = (string)obj91;
								if (flag57)
								{
									bool flag58 = num7 < array2.Length;
									object obj92 = !flag58;
									num3 = 0;
									obj = null;
									if (obj92 != null)
									{
										break;
									}
									bool flag59 = obj41 == null;
									num3 = 0;
									obj = null;
									if (flag59)
									{
										goto IL_11f5;
									}
									string text7 = ((UnityEngine.Object)obj41).name;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E8]");
									object obj93 = 0;
									string text8 = (string)obj93 + text7;
									bool flag60 = text8 == null;
									object obj94 = !flag60;
									num3 = 0;
									text4 = text8;
									if (obj94 != null)
									{
										goto IL_0ff2;
									}
									num12 = 0;
									obj61 = (UnityEngine.Object)(object)text7;
									text2 = text8;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41F0]");
									object obj95 = 0;
									text4 = (string)obj95;
									bool flag61 = obj95 == null;
									num3 = 0;
									num12 = 0;
									obj61 = null;
									text2 = (string)obj95;
									if (!flag61)
									{
										goto IL_0ff2;
									}
								}
								goto IL_1051;
							}
						}
						goto IL_11f5;
					}
					break;
				}
				goto IL_116a;
			}
			goto IL_11f5;
			IL_1195:
			array = apeColor.kept;
			obj10++;
			bool flag62 = apeColor.kept == null;
			object obj96 = !flag62;
			obj8 = obj7;
			num2 = num3;
			obj9 = obj;
			if (obj96 != null)
			{
				continue;
			}
			goto IL_11f5;
			IL_116a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v12+20]");
			((Renderer)0).sharedMaterials = (Material[])(object)array2;
			num3 = 0;
			obj = (UnityEngine.Object)(object)array2;
			goto IL_1195;
		}
		goto IL_1203;
		IL_11f5:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1203;
		IL_1211:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1203:
		ex = new IndexOutOfRangeException();
		goto IL_1211;
	}

	public void SetColorCode(int r, int g, int b)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00b1: Expected VT, but got I4
		object obj = b - 9;
		bool flag = (nint)obj < 0;
		int num = b ^ 9;
		int num2 = b ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMIN not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMAX not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		SetColor((Color)r);
	}

	public unsafe bool SetColorHex(string hex)
	{
		//IL_0096: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_007e: Expected VT, but got Ref
		if (hex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
			object obj = 0;
			bool flag = hex.StartsWith((string)obj);
			bool flag2 = !flag;
			object obj2 = !flag2;
			string htmlString = hex;
			if (obj2 == null)
			{
				string text = (string)obj + hex;
				htmlString = text;
			}
			bool flag3 = ColorUtility.TryParseHtmlString(htmlString, out var color);
			if (flag3)
			{
				SetColor((Color)(&color));
			}
			return flag3;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public void SetColor(Color c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_0b84: Expected Obj, but got I
		//IL_0b9c: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_0bd4: Expected Obj, but got I4
		//IL_0bf2: Expected Obj, but got I
		//IL_0c34: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_046f: Invalid comparison between VT and I4
		//IL_047e: Expected F8, but got I4
		//IL_0e55: Expected Obj, but got I
		//IL_0e7f: Expected Obj, but got I4
		//IL_0499: Invalid comparison between VT and F8
		//IL_04aa: Expected F8, but got VT
		//IL_04ec: Invalid comparison between F8 and I4
		//IL_02dc: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_0cae: Invalid comparison between F8 and I4
		//IL_0cbd: Expected F8, but got I4
		//IL_0560: Expected Obj, but got F8
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected Obj, but got Unknown
		//IL_0c92: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got F8
		//IL_0359: Expected Obj, but got I
		//IL_0eb7: Expected Obj, but got I4
		//IL_05e8: Invalid comparison between F8 and I4
		//IL_0d24: Invalid comparison between F8 and I4
		//IL_0d33: Expected F8, but got I4
		//IL_065c: Expected Obj, but got F8
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected Obj, but got Unknown
		//IL_0d08: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got F8
		//IL_0eef: Expected Obj, but got I4
		//IL_06e4: Invalid comparison between F8 and I4
		//IL_0459: Expected Obj, but got I4
		//IL_0dca: Expected Obj, but got I4
		//IL_0f0d: Expected Obj, but got I
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_0d8d: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I
		//IL_084b: Expected Obj, but got I4
		//IL_0e37: Expected Obj, but got I4
		//IL_0de8: Expected Obj, but got I
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_08be: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got I4
		//IL_08ee: Expected Obj, but got I
		//IL_097a: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_0a12: Expected Obj, but got F8
		//IL_0a2f: Expected Obj, but got F8
		//IL_0a4c: Expected Obj, but got F8
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Color color = default;
		furColor = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4160]");
		object obj4 = 0;
		if (mat == null)
		{
			MakeMaterial();
		}
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+A0]");
		object obj7 = 0;
		bool flag3 = obj7 == null;
		object obj8 = 0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v65+A0]");
				obj7 = 0;
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v94+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v64+8]");
			bool flag6 = (UnityEngine.Object)0 != tintTexture;
			bool flag7 = !flag6;
			obj8 = 0;
			object obj13 = 0;
			UnityEngine.Object obj14 = tintTexture;
			if (flag7)
			{
				goto IL_01f2;
			}
		}
		if ((object)tintTexture != null)
		{
			Color32[] pixels = tintTexture.GetPixels32();
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v59+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v59+A0]");
			object obj17 = 0;
			obj17 = pixels;
			object obj18 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj19 = obj4;
			UnityEngine.Object obj14 = tintTexture;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v62+A0]");
			object obj20 = (nint)0 + (nint)8;
			obj20 = tintTexture;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = obj8;
			goto IL_01f2;
		}
		goto IL_0b0e;
		IL_0466:
		bool flag9 = color < (object)0;
		double num = 0.0;
		if (!flag9)
		{
			bool flag10 = color <= (object)1.0;
			num = (double)color;
			if (!flag10)
			{
				num = 1.0;
			}
		}
		double num2 = num * 1132396544.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v20+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		object obj24;
		double num3 = default;
		if (num2 < 0.0)
		{
			if (num2 == -0.5)
			{
				obj24 = num3;
				goto IL_0c6a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num2 == 0.5)
			{
				obj24 = num3;
				goto IL_0c6a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0ca5;
		IL_0b1c:
		throw new IndexOutOfRangeException();
		IL_0d1b:
		double num4 = default;
		bool flag12 = num4 < 0.0;
		double num5 = 0.0;
		if (!flag12)
		{
			bool flag13 = !(num4 > 1.0);
			num5 = num4;
			if (!flag13)
			{
				num5 = 1.0;
			}
		}
		double num6 = num5 * 1132396544.0;
		object obj25 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v30+E4]");
		bool flag14 = (nint)0 == 0;
		object obj26 = !flag14;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num7;
		double num10;
		double num8;
		double num9;
		if (num6 < 0.0)
		{
			if (num6 == -0.5)
			{
				num7 = -1.0;
				num8 = num3;
				goto IL_0d56;
			}
			num8 = num6 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num9 = -0.5;
			num10 = num6;
		}
		else
		{
			if (num6 == 0.5)
			{
				num7 = 1.0;
				num8 = num3;
				goto IL_0d56;
			}
			num8 = num6 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num9 = 0.5;
			num10 = num6;
		}
		goto IL_0da0;
		IL_0c6a:
		object obj27 = obj24 & 1;
		bool flag15 = obj27 == null;
		object obj28 = !flag15;
		if (obj28 != null)
		{
		}
		goto IL_0ca5;
		IL_01f2:
		object obj29 = obj;
		object obj30 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v14+E4]");
		bool flag16 = (nint)0 == 0;
		object obj31 = !flag16;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)obj30 == null;
		bool flag18 = !flag17;
		object obj32 = 0;
		TextureWrapMode textureWrapMode = (TextureWrapMode)0;
		if (flag18)
		{
			goto IL_0466;
		}
		if ((object)tintTexture != null)
		{
			((WaitForSecondsRealtime)(object)tintTexture).Reset();
			Texture2D texture2D = tintTexture;
			if ((object)tintTexture != null)
			{
				nint num11 = (nint)texture2D;
				((WaitForSecondsRealtime)(object)tintTexture).Reset();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Texture2D texture2D2 = default;
				int width = default;
				int height = default;
				texture2D2._002Ector(width, height, (TextureFormat)4, mipChain: true, linear: false);
				tex = texture2D2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text = name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4180]");
				object obj34 = 0;
				string text2 = (string)obj34 + text;
				if ((object)tex != null)
				{
					tex.name = text2;
					if ((object)tintTexture != null)
					{
						FilterMode filterMode = tintTexture.filterMode;
						if ((object)tex != null)
						{
							tex.filterMode = filterMode;
							if ((object)tintTexture != null)
							{
								TextureWrapMode wrapMode = tintTexture.wrapMode;
								if ((object)tex != null)
								{
									tex.wrapMode = wrapMode;
									obj32 = 0;
									textureWrapMode = wrapMode;
									goto IL_0466;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0b0e;
		IL_0ce0:
		object obj36;
		object obj35 = obj36 & 1;
		bool flag19 = obj35 == null;
		object obj37 = !flag19;
		if (obj37 != null)
		{
		}
		goto IL_0d1b;
		IL_0da0:
		object obj38 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v35+E4]");
		bool flag20 = (nint)0 == 0;
		object obj39 = !flag20;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v35+A0]");
		object obj40 = 0;
		object obj41 = obj40;
		if (obj40 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			double num12 = num10 - 255.0;
			object obj43 = 8;
			Color32[] array = default;
			while (true)
			{
				object obj44 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v40+E4]");
				bool flag21 = (nint)0 == 0;
				object obj45 = !flag21;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj44 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v40+A0]");
				object obj46 = 0;
				object obj47 = obj46;
				if (obj46 == null)
				{
					break;
				}
				object obj48 = obj43 - 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v33+18]");
				if ((nint)obj48 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v40+E4]");
					bool flag22 = (nint)0 == 0;
					object obj49 = !flag22;
					if (obj49 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj50 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X8_v40+A0]");
						object obj51 = 0;
						obj47 = obj51;
						if (obj51 == null)
						{
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v33+18]");
					bool flag23 = (nint)obj48 < 0;
					object obj52 = !flag23;
					if (obj52 == null)
					{
						if (array == null)
						{
							break;
						}
						bool flag24 = (nint)obj48 < array.Length;
						object obj53 = !flag24;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v33+v152 @ X26_v4*4]");
							object obj54 = (nint)0 >> 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v33+v152 @ X26_v4*4]");
							object obj55 = (nint)0 >> 16;
							object obj56 = obj55 & 0xFF;
							double num13 = (double)obj54 * num12;
							double num14 = 65025.0 + num13;
							double num15 = num14 * (double)obj56;
							double num16 = num15 * 2164359683.0;
							object obj57 = num16 >> 32;
							double num17 = (double)obj57 + num15;
							object obj58 = num17 >> 15;
							double num18 = (double)obj58 + num17;
							object obj59 = num18 << 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
							object obj60 = obj59 | 0xFF000000L;
							obj43++;
							continue;
						}
					}
					goto IL_0b1c;
				}
				if (obj30 == null)
				{
					break;
				}
				((Texture2D)obj30).SetPixels32(array);
				if (obj30 == null)
				{
					break;
				}
				((Texture2D)obj30).Apply(true);
				if ((object)mat == null)
				{
					break;
				}
				mat.mainTexture = (Texture)obj30;
				return;
			}
		}
		goto IL_0b0e;
		IL_0b0e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b1c;
		IL_0d56:
		num9 = num8 + num7;
		object obj61 = num8 & 1;
		bool flag25 = obj61 == null;
		object obj62 = !flag25;
		num10 = ((obj62 != null) ? num9 : num8);
		goto IL_0da0;
		IL_0ca5:
		double num19 = default;
		bool flag26 = num19 < 0.0;
		double num20 = 0.0;
		if (!flag26)
		{
			bool flag27 = !(num19 > 1.0);
			num20 = num19;
			if (!flag27)
			{
				num20 = 1.0;
			}
		}
		double num21 = num20 * 1132396544.0;
		object obj63 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v25+E4]");
		bool flag28 = (nint)0 == 0;
		object obj64 = !flag28;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		if (num21 < 0.0)
		{
			if (num21 == -0.5)
			{
				obj36 = num3;
				goto IL_0ce0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num21 == 0.5)
			{
				obj36 = num3;
				goto IL_0ce0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0d1b;
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tex != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
			obj4 = null;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mat != null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(mat);
		}
	}

	public ApeColor()
	{
		//IL_0012: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA40]");
		furColor = (Color)0;
		base._002Ector();
	}

	static ApeColor()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4210]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4160]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4220]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4228]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3906D94");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+A0]");
		object obj8 = (nint)0 + (nint)24;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
