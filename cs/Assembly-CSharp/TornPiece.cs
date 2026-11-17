using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class TornPiece : MonoBehaviour
{
	public AudioClip[] dropSounds;

	public float life;

	public float hardHitSpeed;

	public float minSpeed;

	public TornPiece thudsOn;

	private int thuds;

	private float cool;

	private Dictionary<Material, Material> own;

	public unsafe Material[] Own(Material[] mats)
	{
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04e2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I8
		//IL_00ff: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I4
		//IL_0189: Expected I, but got Obj
		//IL_043d: Expected Obj, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I
		//IL_0392: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_02e4: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_0333: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		object obj = this + 72;
		bool flag = obj == null;
		object obj2 = !flag;
		Material[] array = mats;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9E40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			obj = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			array = (Material[])(object)dictionary;
		}
		Material[] array2 = default;
		NullReferenceException ex = default;
		if (mats != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
			object obj4 = 0;
			array = (Material[])mats.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			if (mats.Length < 1)
			{
				goto IL_047f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9510]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9518]");
			object obj7 = 0;
			object obj8 = mats.Length & 0xFFFFFFFFL;
			System.__Canon value = null;
			object obj9 = 32;
			object obj10 = 0;
			Material material = default;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
				object obj11 = !flag2;
				UnityEngine.Object obj15;
				if (obj11 == null)
				{
					object obj12 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
					bool flag4 = (UnityEngine.Object)0 == null;
					bool flag5 = !flag4;
					object obj14 = !flag5;
					nint num = unchecked((nint)null);
					obj15 = null;
					if (obj14 != null)
					{
						goto IL_0433;
					}
					bool flag6 = (nint)obj10 < mats.Length;
					object obj16 = !flag6;
					num = unchecked((nint)null);
					array = null;
					if (obj16 == null)
					{
						bool flag7 = obj == null;
						num = unchecked((nint)null);
						array = null;
						if (flag7)
						{
							break;
						}
						object obj17 = obj6;
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
						bool flag8 = ((Dictionary<System.__Canon, System.__Canon>)obj18).TryGetValue((System.__Canon)0, out value);
						bool flag9 = !flag8;
						object obj19 = !flag9;
						num = (nint)(&value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
						array = (Material[])0;
						if (obj19 == null)
						{
							bool flag10 = (nint)obj10 < mats.Length;
							object obj20 = !flag10;
							num = (nint)(&value);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
							array = (Material[])0;
							if (obj20 != null)
							{
								goto IL_0484;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
							material._002Ector((Material)0);
							bool flag11 = obj == null;
							num = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
							array = (Material[])0;
							if (flag11)
							{
								break;
							}
							obj17 = obj7;
							object obj22 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
							((Dictionary<System.__Canon, System.__Canon>)obj22).set_Item((System.__Canon)0, (System.__Canon)(object)material);
							value = (System.__Canon)(object)material;
							num = (nint)material;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mats @ X1 (UnityEngine.Material[])+v116 @ X28_v6]");
							array = (Material[])0;
						}
						if (array2 == null)
						{
							break;
						}
						bool flag12 = value == null;
						Material[] array3 = array;
						if (!flag12)
						{
							nint num2 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v21 (Il2CppClass<UnityEngine.Material[]>)+40]");
							array3 = (Material[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag13 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v21 (Il2CppClass<UnityEngine.Material[]>)+40]");
							array = (Material[])0;
							if (flag13)
							{
								goto IL_04a0;
							}
						}
						bool flag14 = (nint)obj10 < array2.Length;
						object obj23 = !flag14;
						array = array3;
						if (obj23 == null)
						{
							object obj24 = (object)array2 + obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj15 = (UnityEngine.Object)(object)value;
							goto IL_0433;
						}
					}
				}
				goto IL_0484;
				IL_0484:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				break;
				IL_0433:
				obj8 = mats.Length;
				obj10++;
				obj9 += 8;
				bool flag15 = (nint)obj10 < mats.Length;
				array = (Material[])(object)obj15;
				if (flag15)
				{
					continue;
				}
				goto IL_047f;
			}
		}
		ex = new NullReferenceException();
		goto IL_04a0;
		IL_04a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Material[])(object)new ArgumentNullException();
		IL_047f:
		return array2;
	}

	public void Again()
	{
		thuds = 0;
	}

	private unsafe void OnDestroy()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_0163: Expected VT, but got Ref
		//IL_016c: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got Ref
		//IL_0118: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		if ((object)own == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9738]");
		object obj = 0;
		ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)(object)own).Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9768]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9748]");
		object obj4 = 0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)values.GetEnumerator();
		object obj6 = default;
		object obj5 = obj6;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
		while (enumerator2.MoveNext())
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)null != (UnityEngine.Object)null;
			bool flag3 = !flag2;
			obj5 = 0;
			if (!flag3)
			{
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v32+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(null);
				obj5 = 0;
			}
		}
		object obj11 = 0;
		object obj12 = 0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
		object obj13 = 0;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			object obj14 = obj4;
			enumerator2.Dispose();
			bool flag5 = obj13 == null;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				bool flag6 = obj11 == null;
				object obj16 = !flag6;
				OutOfMemoryException ex = (OutOfMemoryException)(&enumerator2);
				if (obj16 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj5 = obj6;
				obj11 = obj17;
				obj12 = obj18;
				obj14 = obj;
				obj4 = 109895680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj14 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = 1;
				obj13 = obj12;
				continue;
			}
			if ((nint)obj14 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj13 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F45C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void Update()
	{
		//IL_00b8: Invalid comparison between F4 and I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00d2: Invalid comparison between F4 and I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I4
		float deltaTime = Time.deltaTime;
		float num = cool - deltaTime;
		cool = num;
		float deltaTime2 = Time.deltaTime;
		float num2 = life - deltaTime2;
		bool flag = num2 < 0f;
		object obj = !flag;
		bool flag2 = num2 == 0f;
		life = num2;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			GameObject obj5 = gameObject;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj5);
		}
	}

	private void OnCollisionEnter(Collision c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I4
		//IL_0149: Invalid comparison between F4 and I4
		//IL_0174: Invalid comparison between Obj and F4
		//IL_01cf: Invalid comparison between F4 and I4
		//IL_01de: Expected F8, but got I4
		//IL_03ce: Expected Obj, but got I4
		//IL_0281: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj2 = 0;
		Collision collision = c;
		TornPiece tornPiece = this;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TornPiece tornPiece2;
			if (tornPiece.thudsOn != null)
			{
				tornPiece2 = tornPiece.thudsOn;
				bool flag2 = (object)tornPiece.thudsOn == null;
				object obj5 = !flag2;
				collision = null;
				tornPiece = tornPiece.thudsOn;
				if (obj5 == null)
				{
					goto IL_00bd;
				}
				continue;
			}
			goto IL_00d3;
			IL_00d3:
			bool flag3 = c == null;
			tornPiece2 = tornPiece;
			if (!flag3)
			{
				break;
			}
			goto IL_00bd;
			IL_00bd:
			NullReferenceException ex = new NullReferenceException();
			tornPiece = tornPiece2;
			goto IL_00d3;
		}
		Vector3 relativeVelocity = c.relativeVelocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tornPiece.thuds > 2 || tornPiece.cool > 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj9 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)tornPiece.minSpeed) || c.contactCount == 0)
		{
			return;
		}
		float num = (float)obj9 / tornPiece.hardHitSpeed;
		bool flag5 = num < 0f;
		double num2 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)num > 1.0);
			num2 = num;
			if (!flag6)
			{
				num2 = 1.0;
			}
		}
		double num3 = ((tornPiece.thuds != 0) ? 0.5 : 1.0);
		double num4 = num2 * num3;
		ContactPoint contact = c.GetContact(0);
		object obj10 = obj2;
		if (num4 < 0.25)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float volume = default;
		float pitchMin = default;
		float pitchMax = default;
		Sfx.Play(tornPiece.dropSounds, (Vector3)0, volume, pitchMin, pitchMax);
		int num5 = tornPiece.thuds + 1;
		tornPiece.thuds = num5;
		tornPiece.cool = 0.15f;
	}

	public TornPiece()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4E0]");
		life = 0f;
		minSpeed = 0.7f;
		base._002Ector();
	}
}
