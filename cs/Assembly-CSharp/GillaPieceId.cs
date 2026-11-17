using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class GillaPieceId : MonoBehaviour
{
	public PieceKey key;

	public GillaCorpse body;

	public float bornAt;

	public static readonly Dictionary<PieceKey, GillaPieceId> Out;

	public static readonly List<GillaPieceId> All;

	private Collider[] colliders;

	internal int heldBy = -2147483648;

	internal bool heldRight;

	internal Vector3 heldPos;

	internal Quaternion heldRot;

	internal const int NotHeld = default(int);

	public Collider[] Colliders
	{
		get
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			object obj = this + 64;
			Collider[] result = (Collider[])obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7458]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				Collider[] array = default;
				colliders = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = array;
			}
			return result;
		}
	}

	public bool Held
	{
		get
		{
			//IL_0014: Expected Obj, but got I8
			object obj = heldBy - 2147483648L;
			bool flag = obj == null;
			return !flag;
		}
	}

	public (int, bool) HeldIn
	{
		get
		{
			//IL_0021: Expected VT, but got I4
			(int, bool) tuple = (heldBy, heldRight);
			return ((int, bool))0;
		}
	}

	public bool OnItsOwn
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I4
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00cb: Expected Obj, but got I4
			//IL_010b: Expected Obj, but got I
			//IL_013f: Expected Obj, but got I
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected Obj, but got Unknown
			//IL_0189: Expected Obj, but got I4
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected I4, but got Unknown
			if (isActiveAndEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7468]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj5 = default;
				if (obj5 == null)
				{
					object obj6 = key - 3;
					bool flag2 = (nint)obj6 < 2;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						return true;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
					object obj8 = -1;
					bool flag3 = (nint)obj8 < 0;
					bool flag4 = obj8 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
					object obj9 = (nint)0 ^ (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
					object obj10 = 0 ^ obj8;
					object obj11 = obj9 & obj10;
					bool flag5 = (nint)obj11 < 0;
					bool flag6 = flag3 == flag5;
					object obj12 = !flag4;
					return (byte)((flag6 & obj12) ? 1 : 0) != 0;
				}
			}
			return false;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
		object obj4 = 0;
		((Dictionary<PieceKey, System.__Canon>)obj4).Clear();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v9+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v10+1C]");
		object obj8 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v10+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v10+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v10+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	public unsafe void Set(PieceKey k, GillaCorpse of)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0082: Expected Obj, but got Ref
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got Ref
		//IL_0266: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7448]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
		ref System.__Canon reference = ref *(System.__Canon*)null;
		PieceKey pieceKey = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
		bool flag2 = ((Dictionary<PieceKey, System.__Canon>)obj4).TryGetValue(pieceKey, out *(System.__Canon*)null);
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = default;
		object obj6 = (object)(&obj7);
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = obj7 == this;
			bool flag6 = !flag5;
			reference = ref *(System.__Canon*)null;
			obj6 = (object)(&obj7);
			if (!flag6)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v29+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v29+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7440]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
				reference = ref *(System.__Canon*)null;
				obj6 = obj14;
				bool flag8 = ((Dictionary<PieceKey, System.__Canon>)obj13).Remove(key);
			}
		}
		key = k;
		object obj15 = this + 48;
		IntPtr intPtr = default;
		obj15 = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		bornAt = time;
		object obj16 = this + 64;
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (isActiveAndEnabled)
		{
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v20+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v20+A0]");
			object obj19 = 0;
			PieceKey pieceKey2 = key;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
			((Dictionary<PieceKey, System.__Canon>)obj19).set_Item(pieceKey2, (System.__Canon)0);
		}
	}

	private void LateUpdate()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_014b: Expected VT, but got I4
		//IL_014b: Expected VT, but got I4
		//IL_0174: Expected VT, but got I4
		//IL_0174: Expected VT, but got I4
		if (heldBy != 2147483648L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = !heldRight;
			bool right = !flag2;
			Transform transform = GillaCorpse.Hand(heldBy, right);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(transform == null))
			{
				Transform transform2 = base.transform;
				Vector3 position = transform.position;
				Quaternion rotation = transform.rotation;
				Vector3 vector = (Quaternion)0 * (Vector3)0;
				Quaternion rotation2 = transform.rotation;
				transform2.SetPositionAndRotation((Vector3)0, (Quaternion)0);
			}
		}
	}

	private void OnEnable()
	{
		//IL_02ba: Expected Obj, but got I
		//IL_02c2: Expected VT, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj = 0;
		IntPtr intPtr = default;
		PieceKey pieceKey = (PieceKey)(nint)intPtr;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7478]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+8]");
		if (!((List<System.__Canon>)0).Contains((System.__Canon)(object)this))
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v12+8]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			System.__Canon[] items = list._items;
			int version = list._version + 1;
			list._version = version;
			bool flag3 = list._size < items.Length;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				object obj10 = items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj11 = obj10 + 32;
				obj11 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				list.AddWithResize((System.__Canon)(object)this);
			}
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got Ref
		//IL_01f1: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_023c: Expected I4, but got I8
		//IL_0113: Expected VT, but got Obj
		//IL_0120: Expected Obj, but got Ref
		//IL_0158: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7448]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
		ref System.__Canon reference = ref *(System.__Canon*)null;
		PieceKey pieceKey = key;
		PieceKey pieceKey2 = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
		bool flag2 = ((Dictionary<PieceKey, System.__Canon>)obj4).TryGetValue(pieceKey2, out *(System.__Canon*)null);
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = default;
		object obj6 = (object)(&obj7);
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = obj7 == this;
			bool flag6 = !flag5;
			pieceKey = (PieceKey)this;
			reference = ref *(System.__Canon*)null;
			obj6 = (object)(&obj7);
			if (!flag6)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v20+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v20+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7440]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaPieceId)+28]");
				reference = ref *(System.__Canon*)null;
				pieceKey = key;
				obj6 = obj14;
				bool flag8 = ((Dictionary<PieceKey, System.__Canon>)obj13).Remove(key);
			}
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v10+8]");
		bool flag10 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
		heldBy = -2147483648;
	}

	public GillaPieceId()
	{
		//IL_000f: Expected I4, but got I8
		//IL_0024: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0046: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+A0]");
		heldRot = (Quaternion)(object)0;
		base._002Ector();
	}

	static GillaPieceId()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7488]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7498]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PieceKey, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = dictionary;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
