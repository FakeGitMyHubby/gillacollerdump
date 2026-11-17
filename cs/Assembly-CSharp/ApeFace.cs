using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ApeFace : MonoBehaviour
{
	public SkinnedMeshRenderer face;

	public Transform head;

	public Transform eyeL;

	public Transform eyeR;

	public MicLevel mic;

	public float externalLevel;

	public float screamFrom;

	public float wobble;

	public float openSpeed;

	public float closeSpeed;

	public float screamEyes;

	public float shake;

	public float shakeSpeed;

	public float pupilReach;

	public int playerId;

	public float lookRange;

	public float maxEyeAngle;

	public float eyeSpeed;

	private static readonly List<ApeFace> all;

	private static readonly int BaseMapST;

	private readonly List<(SkinnedMeshRenderer, int, int)> alongWith;

	private int mouthIdx;

	private int screamIdx;

	private int eyeSlot;

	private float mouth;

	private float scream;

	private float swellShown;

	private float shapeGrowth;

	private Quaternion restL;

	private Quaternion restR;

	private Vector3 gazeL;

	private Vector3 gazeR;

	private Vector3 sideL;

	private Vector3 sideR;

	private Vector3 baseL;

	private Vector3 baseR;

	private Vector3 setL;

	private Vector3 setR;

	private Vector3 placeL;

	private Vector3 placeR;

	private Vector3 growL;

	private Vector3 growR;

	private bool held;

	private MaterialPropertyBlock eyeBlock;

	private bool ready;

	private bool MouthShut__BackingField;

	private bool EyesCovered__BackingField;

	private float EyesOut__BackingField;

	public float Scream
	{
		get
		{
			//IL_001f: Expected F4, but got I4
			if (~(MouthShut__BackingField ? 1u : 0u) == 0)
			{
				return 0f;
			}
			return scream;
		}
	}

	public float Talk
	{
		get
		{
			//IL_001f: Expected F4, but got I4
			if (~(MouthShut__BackingField ? 1u : 0u) == 0)
			{
				return 0f;
			}
			return mouth;
		}
	}

	public bool MouthShut
	{
		get
		{
			return MouthShut__BackingField;
		}
		set
		{
			MouthShut__BackingField = value;
		}
	}

	public bool EyesCovered
	{
		get
		{
			return EyesCovered__BackingField;
		}
		set
		{
			EyesCovered__BackingField = value;
		}
	}

	public float EyesOut
	{
		get
		{
			return EyesOut__BackingField;
		}
		set
		{
			EyesOut__BackingField = value;
		}
	}

	public unsafe static bool Held(Transform bone, out Vector3 place, out Vector3 scale)
	{
		//IL_03e2: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_03d2: Expected I4, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+4]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+4]");
		_ = 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = bone != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		UnityEngine.Object obj9 = null;
		if (!flag3)
		{
			if ((object)bone == null)
			{
				goto IL_03c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4230]");
			object obj10 = 0;
			obj7 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F56C");
			obj8 = (UnityEngine.Object)1;
			UnityEngine.Object obj11 = default;
			obj9 = obj11;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = obj9 == null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			if ((object)obj9 == null)
			{
				goto IL_03c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+154]");
			if ((nint)0 != 0)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+30]");
				bool flag8 = bone != (UnityEngine.Object)0;
				bool flag9 = !flag8;
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+30]");
				UnityEngine.Object obj18 = (UnityEngine.Object)0;
				if (!flag9)
				{
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v31+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+38]");
					bool flag11 = bone != (UnityEngine.Object)0;
					bool flag12 = !flag11;
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+38]");
					obj18 = (UnityEngine.Object)0;
					if (!flag12)
					{
						goto IL_025a;
					}
				}
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v20+E4]");
				bool flag13 = (nint)0 == 0;
				object obj22 = !flag13;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+30]");
				object obj24;
				if (bone == (UnityEngine.Object)0)
				{
					object obj23 = obj9 + 292;
					obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+12C]");
					object obj25 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+130]");
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+138]");
					object obj25 = 0;
				}
				reference2 = ref *(Vector3*)obj24;
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v24+E4]");
				bool flag14 = (nint)0 == 0;
				object obj27 = !flag14;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+30]");
				object obj28;
				if (bone == (UnityEngine.Object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+F4]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+FC]");
					object obj29 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+100]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (UnityEngine.Object)+108]");
					object obj29 = 0;
				}
				reference = ref *(Vector3*)obj28;
				return true;
			}
		}
		goto IL_025a;
		IL_025a:
		return false;
		IL_03c4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj = 0;
		object obj2 = obj;
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
		List<System.__Canon> list = (List<System.__Canon>)obj4;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj = 0;
		object obj2 = obj;
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
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
	}

	private unsafe void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1083: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0c58: Expected Obj, but got I4
		//IL_0ccc: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0d4e: Expected VT, but got F4
		//IL_0d95: Expected VT, but got F4
		//IL_0168: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_0e36: Expected VT, but got I4
		//IL_0e44: Expected VT, but got F4
		//IL_025e: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Ref, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Ref, but got Unknown
		//IL_0285: Expected Obj, but got I8
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I4
		//IL_1170: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I4
		//IL_0ee0: Expected VT, but got I4
		//IL_0eee: Expected VT, but got F4
		//IL_0318: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I
		//IL_0574: Expected Obj, but got I4
		//IL_109b: Expected Obj, but got I4
		//IL_0f30: Expected VT, but got F4
		//IL_05b7: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I4
		//IL_0f72: Expected VT, but got F4
		//IL_119f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a4: Expected Obj, but got Unknown
		//IL_11b4: Expected Obj, but got I
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected Obj, but got Unknown
		//IL_11f3: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_0fff: Expected Obj, but got I
		//IL_1017: Expected Obj, but got I
		//IL_101f: Expected F4, but got Obj
		//IL_102f: Expected Obj, but got I
		//IL_103f: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I4
		//IL_110d: Expected VT, but got F4
		//IL_1111: Unsupported input type for neg.
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_1120: Expected VT, but got F4
		//IL_1129: Unsupported input type for neg.
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Expected Obj, but got Unknown
		//IL_064f: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I4
		//IL_06c6: Expected Obj, but got I8
		//IL_06d6: Expected Obj, but got I
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_06fd: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I4
		//IL_10f0: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got I4
		//IL_0771: Expected Obj, but got I
		//IL_078f: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I4
		//IL_0be4: Expected Obj, but got I
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_07e6: Expected Obj, but got I
		//IL_081a: Expected Obj, but got I4
		//IL_0823: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I
		//IL_0888: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I4
		//IL_08fa: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I
		//IL_0986: Expected I4, but got I8
		//IL_0a10: Expected Obj, but got I
		//IL_0a35: Expected Obj, but got I
		//IL_09b5: Expected I4, but got I8
		//IL_09cf: Expected Obj, but got I4
		//IL_09e0: Expected Obj, but got I4
		//IL_0a64: Expected Obj, but got I
		//IL_0a74: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I
		//IL_0ae5: Expected Obj, but got I4
		//IL_0b87: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I
		//IL_0bb7: Expected VT, but got I4
		//IL_0bc1: Expected VT, but got I4
		//IL_0bca: Expected Obj, but got I4
		//IL_0b10: Expected Obj, but got I
		//IL_0b26: Expected Obj, but got I
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0b42: Expected Obj, but got I4
		//IL_0b5c: Expected VT, but got I4
		//IL_0b6d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = face != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		if (flag3)
		{
			goto IL_0c2e;
		}
		object blendShapeName;
		object obj8;
		if ((object)face != null)
		{
			Mesh sharedMesh = face.sharedMesh;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = sharedMesh != null;
			bool flag6 = !flag5;
			obj4 = 0;
			obj5 = null;
			if (flag6)
			{
				goto IL_0c2e;
			}
			if ((object)face != null)
			{
				Mesh sharedMesh2 = face.sharedMesh;
				if ((object)sharedMesh2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4268]");
					blendShapeName = 0;
					int blendShapeIndex = sharedMesh2.GetBlendShapeIndex((string)blendShapeName);
					mouthIdx = blendShapeIndex;
					if ((object)face != null)
					{
						Mesh sharedMesh3 = face.sharedMesh;
						if ((object)sharedMesh3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4270]");
							obj8 = 0;
							int blendShapeIndex2 = sharedMesh3.GetBlendShapeIndex((string)obj8);
							screamIdx = blendShapeIndex2;
							if ((object)face != null)
							{
								Material[] sharedMaterials = face.sharedMaterials;
								if (sharedMaterials != null)
								{
									bool flag7 = sharedMaterials.Length < 1;
									object obj9 = 0;
									string text = null;
									if (flag7)
									{
										goto IL_0428;
									}
									object obj10 = sharedMaterials.Length & 0xFFFFFFFFL;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4280]");
									int num = 0;
									object obj11 = sharedMaterials + 32;
									int num2 = 0;
									object obj12 = 0;
									string text2 = null;
									while (true)
									{
										bool flag8 = num2 < (nint)obj10;
										object obj13 = !flag8;
										if (obj13 != null)
										{
											break;
										}
										object obj14 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v115+E4]");
										bool flag9 = (nint)0 == 0;
										object obj15 = !flag9;
										if (obj15 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v9+v245 @ X22_v13 (System.Int32)*8]");
										bool flag10 = (UnityEngine.Object)0 != null;
										bool flag11 = !flag10;
										obj9 = 0;
										text = null;
										if (!flag11)
										{
											bool flag12 = num2 < sharedMaterials.Length;
											object obj16 = !flag12;
											if (obj16 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v9+v245 @ X22_v13 (System.Int32)*8]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v9+v245 @ X22_v13 (System.Int32)*8]");
												string text3 = ((UnityEngine.Object)0).name;
												if (text3 != null)
												{
													text = (string)((int*)num)->m_value;
													bool flag13 = text3.Contains((string)((int*)num)->m_value);
													bool flag14 = !flag13;
													obj9 = 0;
													if (!flag14)
													{
														eyeSlot = num2;
														obj9 = 0;
													}
													goto IL_1091;
												}
											}
											goto IL_1044;
										}
										goto IL_1091;
										IL_1091:
										obj10 = sharedMaterials.Length;
										num2++;
										bool flag15 = num2 < sharedMaterials.Length;
										obj12 = obj9;
										text2 = text;
										if (flag15)
										{
											continue;
										}
										goto IL_0428;
									}
									goto IL_1052;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1044;
		IL_1044:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1052;
		IL_1052:
		throw new IndexOutOfRangeException();
		IL_0c2e:
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v11+E4]");
		bool flag16 = (nint)0 == 0;
		object obj18 = !flag16;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(eyeL != null))
		{
			return;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v16+E4]");
		bool flag17 = (nint)0 == 0;
		object obj20 = !flag17;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(eyeR != null))
		{
			return;
		}
		float num3 = default;
		if ((object)eyeL != null)
		{
			Quaternion localRotation = eyeL.localRotation;
			restL = (Quaternion)num3;
			if ((object)eyeR != null)
			{
				Quaternion localRotation2 = eyeR.localRotation;
				restR = (Quaternion)num3;
				if ((object)eyeL != null)
				{
					Transform parent = eyeL.parent;
					Transform transform = base.transform;
					if ((object)transform != null)
					{
						Vector3 forward = transform.forward;
						if ((object)parent != null)
						{
							Vector3 vector = parent.InverseTransformDirection((Vector3)0);
							gazeL = (Vector3)num3;
							if ((object)eyeR != null)
							{
								Transform parent2 = eyeR.parent;
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									Vector3 forward2 = transform2.forward;
									if ((object)parent2 != null)
									{
										Vector3 vector2 = parent2.InverseTransformDirection((Vector3)0);
										gazeR = (Vector3)num3;
										if ((object)eyeL != null)
										{
											Vector3 localPosition = eyeL.localPosition;
											placeL = (Vector3)num3;
											if ((object)eyeR != null)
											{
												Vector3 localPosition2 = eyeR.localPosition;
												placeR = (Vector3)num3;
												float num4 = (float)placeL - num3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+128]");
												object obj22 = default;
												object obj21 = 0 - obj22;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+12C]");
												object obj25 = default;
												object obj24 = 0 - obj25;
												object obj26 = obj23;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v44+E4]");
												bool flag18 = (nint)0 == 0;
												object obj27 = !flag18;
												if (obj27 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
												float num5;
												object obj28;
												object obj29;
												if ((nint)obj25 > 0)
												{
													num5 = num4 / (float)obj25;
													obj28 = obj21 / obj25;
													obj29 = obj24 / obj25;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
													object obj30 = 0;
													object obj31 = obj30;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v22+A0]");
													object obj32 = 0;
													num5 = (float)obj32;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v23+4]");
													obj28 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v23+8]");
													obj29 = 0;
												}
												Vector3 vector3 = (Vector3)(0f - num5);
												object obj33 = 0 - obj28;
												sideL = (Vector3)num5;
												object obj34 = 0 - obj29;
												ready = true;
												sideR = vector3;
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
		}
		goto IL_1044;
		IL_0428:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj35 = 0;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v69+E4]");
		bool flag19 = (nint)0 == 0;
		object obj37 = !flag19;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num6 = EyeGrowth(face, screamIdx, eyeL, out *(Vector3*)(this + 316));
		ref Vector3 reference = ref *(Vector3*)(this + 328);
		shapeGrowth = num6;
		num3 = EyeGrowth(face, screamIdx, eyeR, out reference);
		if ((object)face != null)
		{
			Transform transform3 = face.transform;
			if ((object)transform3 != null)
			{
				Transform parent3 = transform3.parent;
				object obj38 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v34+E4]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v34+E4]");
				bool flag20 = (nint)0 == 0;
				object obj40 = !flag20;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag21 = parent3 != null;
				bool flag22 = !flag21;
				obj4 = 0;
				obj5 = null;
				if (flag22)
				{
					goto IL_0c2e;
				}
				if ((object)face != null)
				{
					Transform transform4 = face.transform;
					if ((object)transform4 != null)
					{
						Transform parent4 = transform4.parent;
						if ((object)parent4 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
							object obj41 = 0;
							obj4 = obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
							object obj42 = default;
							if (obj42 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v82+18]");
								bool flag23 = (nint)0 < (nint)1;
								obj5 = (UnityEngine.Object)1;
								if (flag23)
								{
									goto IL_0c2e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v82+18]");
								object obj43 = 0 & 0xFFFFFFFFL;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4278]");
								object obj44 = 0;
								object obj45 = obj42 + 32;
								object obj47 = default;
								object obj46 = obj47;
								ref Vector3 reference2 = ref reference;
								object obj48 = 0;
								object obj49 = obj41;
								UnityEngine.Object obj50 = (UnityEngine.Object)1;
								while (true)
								{
									bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43);
									object obj51 = !flag24;
									if (obj51 != null)
									{
										break;
									}
									object obj52 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v84+E4]");
									bool flag25 = (nint)0 == 0;
									object obj53 = !flag25;
									if (obj53 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
									bool flag26 = (UnityEngine.Object)0 == face;
									bool flag27 = !flag26;
									object obj54 = !flag27;
									obj4 = 0;
									obj5 = face;
									if (obj54 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
										if ((nint)0 == 0)
										{
											goto IL_1044;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
										string text4 = ((UnityEngine.Object)0).name;
										bool flag28 = text4 == (string)obj44;
										bool flag29 = !flag28;
										object obj55 = !flag29;
										obj4 = 0;
										obj5 = (UnityEngine.Object)obj44;
										if (obj55 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
											Mesh sharedMesh4 = ((SkinnedMeshRenderer)0).sharedMesh;
											object obj56 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v43+E4]");
											obj39 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v43+E4]");
											bool flag30 = (nint)0 == 0;
											object obj57 = !flag30;
											if (obj57 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag31 = sharedMesh4 == null;
											bool flag32 = !flag31;
											object obj58 = !flag32;
											obj4 = 0;
											obj5 = null;
											if (obj58 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
												Mesh sharedMesh5 = ((SkinnedMeshRenderer)0).sharedMesh;
												if ((object)sharedMesh5 != null)
												{
													int blendShapeIndex3 = sharedMesh5.GetBlendShapeIndex((string)blendShapeName);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
													Mesh sharedMesh6 = ((SkinnedMeshRenderer)0).sharedMesh;
													if ((object)sharedMesh6 != null)
													{
														int blendShapeIndex4 = sharedMesh6.GetBlendShapeIndex((string)obj8);
														if ((int)(blendShapeIndex3 & 0x80000000L) != 0)
														{
															int num7 = (int)(blendShapeIndex4 & 0x80000000L);
															bool flag33 = num7 == 0;
															object obj59 = !flag33;
															reference2 = ref *(Vector3*)blendShapeIndex4;
															obj4 = 0;
															obj5 = (UnityEngine.Object)obj8;
															if (obj59 != null)
															{
																goto IL_0bd4;
															}
														}
														List<(System.__Canon, int, int)> list = (List<(System.__Canon, int, int)>)(object)alongWith;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4260]");
														object obj60 = 0;
														obj46 = obj60;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X29_v5+v243 @ X27_v7*8]");
														(System.__Canon, int, int) tuple = ((System.__Canon)0, blendShapeIndex3, blendShapeIndex4);
														if ((object)alongWith != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+10]");
															object obj61 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4258]");
															object obj62 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+1C]");
															object obj63 = (nint)0 + (nint)1;
															obj39 = obj62;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+10]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+18]");
																nint num8 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v46+18]");
																bool flag34 = num8 < 0;
																object obj64 = !flag34;
																if (obj64 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+10]");
																	nint num9 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+18]");
																	object obj65 = num9 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v11 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Int32>>)+18]");
																	obj39 = (nint)0 + (nint)1;
																	object obj66 = obj65 + 32;
																	obj66 = 0;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	tuple = ((System.__Canon, int, int))0;
																	reference2 = ref *(Vector3*)blendShapeIndex4;
																	obj4 = 0;
																	obj5 = null;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v7+20]");
																	object obj67 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v47+A8]");
																	object obj68 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v48+70]");
																	reference2 = ref *(Vector3*)null;
																	((List<(System.__Canon, int, int)>)(object)alongWith).AddWithResize(((System.__Canon, int, int))0);
																	tuple = ((System.__Canon, int, int))0;
																	obj4 = 0;
																	obj5 = null;
																}
																goto IL_0bd4;
															}
														}
													}
												}
												goto IL_1044;
											}
										}
									}
									goto IL_0bd4;
									IL_0bd4:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v82+18]");
									obj43 = 0;
									obj48++;
									object obj69 = obj48;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v82+18]");
									bool flag35 = (nint)obj69 < 0;
									reference = ref reference2;
									obj49 = obj4;
									obj50 = obj5;
									if (flag35)
									{
										continue;
									}
									goto IL_0c2e;
								}
								goto IL_1052;
							}
						}
					}
				}
			}
		}
		goto IL_1044;
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_0bf6: Invalid comparison between F4 and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got I4
		//IL_00bf: Expected F4, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_0102: Invalid comparison between F4 and I
		//IL_0c52: Invalid comparison between F8 and I4
		//IL_0c61: Expected F8, but got I4
		//IL_0c78: Invalid comparison between F4 and I4
		//IL_0c87: Expected F8, but got I4
		//IL_0caf: Invalid comparison between F4 and I4
		//IL_0cbe: Invalid comparison between F4 and I4
		//IL_0cd3: Expected Obj, but got F4
		//IL_0ce0: Expected Obj, but got F4
		//IL_0d26: Expected Obj, but got I4
		//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0d53: Invalid comparison between F8 and I4
		//IL_0d66: Expected Obj, but got F8
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_0dd2: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0e1d: Expected Obj, but got I4
		//IL_0e35: Invalid comparison between F4 and I4
		//IL_0e46: Expected Obj, but got I4
		//IL_0ed6: Invalid comparison between F8 and I4
		//IL_0ee9: Expected Obj, but got F8
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0f28: Expected Obj, but got I4
		//IL_0f58: Expected Obj, but got I4
		//IL_0f70: Invalid comparison between F8 and I4
		//IL_0f92: Expected Obj, but got I4
		//IL_0fa8: Expected I4, but got Obj
		//IL_0fd0: Invalid comparison between F8 and I
		//IL_0fea: Expected F4, but got I4
		//IL_116c: Expected Obj, but got I4
		//IL_1175: Expected F4, but got I4
		//IL_117e: Expected F4, but got I4
		//IL_100c: Expected I4, but got I8
		//IL_1026: Expected Obj, but got I4
		//IL_102f: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I
		//IL_04c4: Expected I4, but got I8
		//IL_04de: Expected Obj, but got I4
		//IL_03d4: Invalid comparison between F4 and I4
		//IL_03f4: Expected F8, but got I4
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_1076: Expected F4, but got I4
		//IL_107f: Expected F8, but got I4
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected F4, but got Unknown
		//IL_04ab: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_0789: Expected Obj, but got I4
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got I4
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got I4
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1126: Expected Ref, but got Unknown
		//IL_1140: Expected Obj, but got I4
		//IL_1148: Expected F8, but got Obj
		//IL_05f7: Expected Obj, but got I4
		//IL_061e: Expected Obj, but got F8
		//IL_063c: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I4
		//IL_07d7: Expected Obj, but got I4
		//IL_07df: Expected F8, but got Obj
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_0665: Expected I4, but got I8
		//IL_067f: Expected Obj, but got I4
		//IL_0688: Expected Obj, but got I4
		//IL_06fd: Expected I4, but got I8
		//IL_0717: Expected Obj, but got I4
		//IL_06a8: Invalid comparison between F8 and I4
		//IL_0b1b: Expected F8, but got I4
		//IL_087f: Expected F4, but got I4
		//IL_082c: Expected Obj, but got I4
		//IL_072e: Invalid comparison between F8 and I4
		//IL_073c: Expected Obj, but got I4
		//IL_0a6e: Expected Obj, but got I4
		//IL_0b7b: Expected Obj, but got I4
		//IL_0b83: Expected Obj, but got F8
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected F8, but got I4
		//IL_0a9c: Expected Obj, but got I4
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got F8
		//IL_06de: Expected Obj, but got I4
		//IL_0769: Expected Obj, but got F8
		//IL_077a: Expected Obj, but got I4
		//IL_097c: Expected F4, but got VT
		//IL_097c: Expected VT, but got Obj
		//IL_09a3: Expected F4, but got VT
		//IL_09a3: Expected VT, but got Obj
		//IL_08bd: Expected F8, but got Obj
		//IL_08c6: Expected F8, but got I4
		//IL_0a14: Expected Obj, but got I4
		//IL_08e4: Expected F8, but got I
		//IL_08f4: Expected F8, but got I
		//IL_08fe: Expected F4, but got VT
		//IL_090e: Expected VT, but got I4
		//IL_0927: Expected F8, but got Obj
		//IL_094a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enumerator<, > val;
		double num2 = default;
		object obj6;
		object obj4;
		UnityEngine.Object obj5;
		double num;
		if (mic != null)
		{
			bool flag2 = (object)mic == null;
			val = (Enumerator<, >)0;
			num = num2;
			obj4 = 0;
			obj5 = null;
			if (flag2)
			{
				goto IL_0ab1;
			}
			obj6 = mic + 60;
		}
		else
		{
			obj6 = this + 72;
		}
		float num3 = screamFrom;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num4 = (float)obj6 / deltaTime;
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		else
		{
			bool flag3 = (double)num4 > 1.0;
			float num5 = 1f;
			if (!flag3)
			{
				float num6 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				bool flag4 = !(num6 > 0f);
				num5 = num4;
				if (flag4)
				{
					goto IL_0c0d;
				}
			}
			float time = Time.time;
			float x = time * 11f;
			float num7 = playerId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE8]");
			float y = num7 * 0f;
			float num8 = Mathf.PerlinNoise(x, y);
			float num9 = wobble * num8;
			double num10 = 1.0 - (double)wobble;
			float num11 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			float num12 = num11 * 0f;
			num3 = screamFrom;
			double num13 = num10 + (double)num12;
			num4 = num5 * (float)num13;
		}
		goto IL_0c0d;
		IL_0ab1:
		throw new NullReferenceException();
		IL_0c0d:
		double num14 = 1.0 - (double)num3;
		float num15 = (float)obj6 - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num16 = (double)num15 / num14;
		bool flag5 = num16 < 0.0;
		double num17 = 0.0;
		if (!flag5)
		{
			bool flag6 = !(num16 > 1.0);
			num17 = num16;
			if (!flag6)
			{
				num17 = 1.0;
			}
		}
		bool flag7 = num4 < 0f;
		double num18 = 0.0;
		if (!flag7)
		{
			bool flag8 = !((double)num4 > 1.0);
			num18 = num4;
			if (!flag8)
			{
				num18 = 1.0;
			}
		}
		float num19 = num4 - mouth;
		bool flag9 = num19 < 0f;
		bool flag10 = num19 == 0f;
		object obj7 = num4 ^ mouth;
		object obj8 = num4 ^ num19;
		object obj9 = obj7 & obj8;
		bool flag11 = (nint)obj9 < 0;
		double num20 = num18 - (double)mouth;
		bool flag12 = flag9 == flag11;
		object obj10 = !flag10;
		object obj11 = flag12 & obj10;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			object obj13 = 84;
		}
		else
		{
			object obj13 = 88;
		}
		bool flag13 = num20 < 0.0;
		object obj14 = num20 ^ num20;
		object obj15 = num20 & obj14;
		bool flag14 = (nint)obj15 < 0;
		float num21 = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+v547 @ X8_v18]");
		float num22 = num21 * 0f;
		float num23 = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+v547 @ X8_v18]");
		float num24 = num23 * 0f;
		float num25 = 0f - num24;
		bool flag15 = flag13 == flag14;
		object obj16 = !flag15;
		object obj17 = ~obj16;
		float num26 = ((obj17 != null) ? num22 : num25);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num27 = mouth + num26;
		bool flag16 = num25 < num22;
		object obj18 = !flag16;
		float num28 = num25 - num22;
		bool flag17 = num28 == 0f;
		object obj19 = !flag17;
		object obj20 = obj18 & obj19;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			num18 = num27;
		}
		mouth = (float)num18;
		double num29 = ((!(num17 > (double)scream)) ? ((double)closeSpeed * 0.5) : ((double)openSpeed));
		double num30 = num17 - (double)scream;
		float num31 = deltaTime * (float)num29;
		float num32 = deltaTime * (float)num29;
		float num33 = 0f - num32;
		bool flag18 = num30 < 0.0;
		object obj22 = num30 ^ num30;
		object obj23 = num30 & obj22;
		bool flag19 = (nint)obj23 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag20 = flag18 == flag19;
		object obj24 = !flag20;
		object obj25 = ~obj24;
		if (obj25 != null)
		{
			num33 = num31;
		}
		bool flag21 = num30 < (double)num31;
		object obj26 = !flag21;
		double num34 = num30 - (double)num31;
		bool flag22 = num34 == 0.0;
		float num35 = scream + num33;
		object obj27 = !flag22;
		object obj28 = obj26 & obj27;
		if ((int)(~obj28) == 0)
		{
			num17 = num35;
		}
		scream = (float)num17;
		double num36 = num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		bool flag23 = !(num36 > 0.0);
		double num37 = num33;
		deltaTime = 0f;
		if (!flag23)
		{
			float time2 = Time.time;
			num31 = shakeSpeed;
			float x2 = time2 * shakeSpeed;
			int num38 = playerId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A830]");
			object obj29 = (nint)num38 * (nint)0;
			float y2 = (float)obj29 + 11f;
			float num39 = Mathf.PerlinNoise(x2, y2);
			float num40 = num39 + num39;
			num30 = num17 * (double)shake;
			float num41 = num40 + -1f;
			double num42 = num30 * (double)num41;
			num37 = -1.0;
			deltaTime = (float)num42;
		}
		bool flag24 = (byte)(~(MouthShut__BackingField ? 1u : 0u)) != 0;
		object obj30 = !flag24;
		float num43 = 0f;
		float num44 = 0f;
		if (obj30 == null)
		{
			num22 = deltaTime + scream;
			double num45 = 1.0 - (double)scream;
			bool flag25 = num22 < 0f;
			double num46 = (double)mouth * num45;
			num37 = 0.0;
			if (!flag25)
			{
				bool flag26 = !((double)num22 > 1.0);
				num37 = num22;
				if (!flag26)
				{
					num37 = 1.0;
				}
			}
			double num47 = num46 * 1120403456.0;
			double num48 = num37 * 1120403456.0;
			num43 = (float)num47;
			num44 = (float)num48;
			num31 = 1.1204035E+09f;
			num30 = 1120403456.0;
			deltaTime = (float)num46;
		}
		int num49 = (int)(mouthIdx & 0x80000000L);
		bool flag27 = num49 == 0;
		object obj31 = !flag27;
		obj4 = 0;
		if (obj31 == null)
		{
			bool flag28 = (object)face == null;
			val = (Enumerator<, >)0;
			num = num2;
			obj4 = 0;
			obj5 = (UnityEngine.Object)mouthIdx;
			if (flag28)
			{
				goto IL_0ab1;
			}
			face.SetBlendShapeWeight(mouthIdx, num43);
			deltaTime = num43;
			obj4 = 0;
		}
		int num50 = (int)(screamIdx & 0x80000000L);
		bool flag29 = num50 == 0;
		object obj32 = !flag29;
		if (obj32 == null)
		{
			bool flag30 = (object)face == null;
			val = (Enumerator<, >)0;
			num = num2;
			obj5 = (UnityEngine.Object)screamIdx;
			if (flag30)
			{
				goto IL_0ab1;
			}
			face.SetBlendShapeWeight(screamIdx, num44);
			deltaTime = num44;
			obj4 = 0;
		}
		bool flag31 = (object)alongWith == null;
		val = (Enumerator<, >)0;
		num = num2;
		obj5 = (UnityEngine.Object)screamIdx;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42A0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4298]");
			object obj34 = 0;
			Enumerator<, > enumerator = ((List<(System.__Canon, int, int)>)(object)alongWith).GetEnumerator();
			Enumerator<, > val2 = default;
			deltaTime = (float)val2;
			int num52 = default;
			object obj45 = default;
			Vector3 gaze = default;
			Vector3 side = default;
			Transform target = default;
			while (true)
			{
				if (val.MoveNext())
				{
					object obj35 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X0_v28+E4]");
					bool flag32 = (nint)0 == 0;
					object obj36 = !flag32;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag33 = (UnityEngine.Object)num2 == null;
					bool flag34 = !flag33;
					object obj37 = !flag34;
					obj4 = 0;
					if (obj37 != null)
					{
						continue;
					}
					int num51 = (int)(num52 & 0x80000000L);
					bool flag35 = num51 == 0;
					object obj38 = !flag35;
					obj4 = 0;
					int num53 = 0;
					if (obj38 == null)
					{
						if (num2 == 0.0)
						{
							NullReferenceException ex = new NullReferenceException();
							obj4 = 0;
							obj5 = null;
							goto IL_0a78;
						}
						((SkinnedMeshRenderer)num2).SetBlendShapeWeight(num52, num43);
						deltaTime = num43;
						obj4 = 0;
						num53 = num52;
					}
					int num54 = (int)(num52 & -9223372036854775808L);
					bool flag36 = num54 == 0;
					object obj39 = !flag36;
					if (obj39 != null)
					{
						continue;
					}
					bool flag37 = num2 == 0.0;
					obj5 = (UnityEngine.Object)num53;
					if (!flag37)
					{
						int index = num52 >> 32;
						((SkinnedMeshRenderer)num2).SetBlendShapeWeight(index, num44);
						deltaTime = num44;
						obj4 = 0;
						continue;
					}
					goto IL_0a78;
				}
				object obj40 = 20;
				val = val2;
				MicLevel micLevel = null;
				object obj41 = 0;
				Enumerator<, > val3 = (Enumerator<, >)(ref val);
				num37 = num2;
				object obj42 = 0;
				while (true)
				{
					obj5 = (UnityEngine.Object)obj34;
					((Enumerator<, >*)val3)->Dispose();
					bool flag38 = obj42 == null;
					object obj43 = !flag38;
					num = (double)micLevel;
					if (obj43 == null)
					{
						bool flag39 = (object)micLevel == null;
						object obj44 = !flag39;
						num = (double)micLevel;
						OutOfMemoryException ex2 = (OutOfMemoryException)val3;
						if (obj44 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num = 1.0;
						obj42 = obj41;
					}
					else
					{
						if ((nint)obj5 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD94");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj42 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj41 = obj45;
					}
					obj40 = 0;
					micLevel = (MicLevel)num;
				}
				if ((nint)obj40 != 20)
				{
					bool flag40 = obj40 == null;
					object obj46 = !flag40;
					if (obj46 != null)
					{
						return;
					}
				}
				deltaTime = num44 / 1.1204035E+09f;
				num44 = ((screamIdx < 0) ? 0f : deltaTime);
				if (~(ready ? 1u : 0u) != 0)
				{
					return;
				}
				if (held)
				{
					bool flag41 = (object)eyeL == null;
					num = (double)micLevel;
					num37 = 0.0;
					if (flag41)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+12C]");
					num30 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+128]");
					num37 = 0.0;
					deltaTime = (float)placeL;
					eyeL.localPosition = (Vector3)0;
					bool flag42 = (object)eyeR == null;
					num = (double)micLevel;
					obj5 = null;
					if (flag42)
					{
						break;
					}
					eyeR.localPosition = (Vector3)0;
				}
				Transform transform = ClosestOtherHead();
				Aim(eyeL, (Quaternion)transform, gaze, side, target, (float)restL);
				Aim(eyeR, (Quaternion)transform, gaze, side, target, (float)restR);
				held = EyesCovered__BackingField;
				if (~(EyesCovered__BackingField ? 1u : 0u) == 0)
				{
					Hold(num44);
					return;
				}
				float num55 = screamEyes * scream;
				float num56 = num55 + 1f;
				bool flag43 = (byte)(~(MouthShut__BackingField ? 1u : 0u)) != 0;
				object obj47 = !flag43;
				double num57 = 1.0;
				if (obj47 == null)
				{
					float num58 = scream * shapeGrowth;
					num57 = (double)num58 + 1.0;
				}
				float total = num56 * (float)num57;
				Swell(num56, total);
				return;
				IL_0a78:
				NullReferenceException ex3 = new NullReferenceException();
				val = val2;
				num = 0.0;
				obj41 = 0;
				val3 = (Enumerator<, >)(ref val);
				num37 = num2;
				break;
			}
		}
		goto IL_0ab1;
	}

	private unsafe static float EyeGrowth(SkinnedMeshRenderer smr, int shape, Transform eyeBone, out Vector3 from)
	{
		//IL_0a02: Expected Obj, but got I
		//IL_0a1a: Expected Obj, but got I
		//IL_0a22: Expected F4, but got Obj
		//IL_0a32: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00f2: Expected I4, but got I8
		//IL_06cc: Expected I4, but got I8
		//IL_06e6: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_09f2: Expected F4, but got I
		//IL_015b: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I8
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_027b: Expected F4, but got I4
		//IL_0284: Expected F4, but got I4
		//IL_028d: Expected F8, but got I4
		//IL_0296: Expected F8, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected Obj, but got Unknown
		//IL_030d: Expected F8, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0361: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I4
		//IL_0518: Invalid comparison between F8 and Obj
		//IL_053c: Expected F8, but got Obj
		//IL_03a6: Expected Obj, but got I
		//IL_03ae: Expected F8, but got Obj
		//IL_07ae: Invalid comparison between F8 and I4
		//IL_07bd: Invalid comparison between F8 and I4
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_07dd: Expected Obj, but got F8
		//IL_0812: Expected Obj, but got I4
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I4
		//IL_054e: Expected F8, but got Obj
		//IL_0788: Expected Obj, but got I4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_056e: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_086b: Invalid comparison between F4 and I4
		//IL_087a: Invalid comparison between F4 and I4
		//IL_088d: Expected Obj, but got F4
		//IL_089a: Expected Obj, but got F4
		//IL_08ed: Expected Obj, but got I4
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected Obj, but got Unknown
		//IL_09b5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+A0]");
		object obj3 = 0;
		float num = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+8]");
		object obj4 = 0;
		ref Vector3 reference = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+8]");
		_ = 0;
		object obj13;
		BoneWeight[] array2;
		BoneWeight[] boneWeights;
		if ((object)smr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Mesh sharedMesh = smr.sharedMesh;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num3;
			if (eyeBone != null)
			{
				Transform[] bones = smr.bones;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4288]");
				object obj8 = 0;
				object obj9 = obj8;
				int num2 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)eyeBone);
				num3 = num2;
			}
			else
			{
				object obj9 = 0;
				num3 = -1;
			}
			int num4 = num3 | shape;
			int num5 = (int)(num4 & 0x80000000L);
			bool flag2 = num5 == 0;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				goto IL_09e5;
			}
			if ((object)sharedMesh != null)
			{
				if (!sharedMesh.isReadable)
				{
					goto IL_09e5;
				}
				int vertexCount = sharedMesh.vertexCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				int blendShapeFrameCount = sharedMesh.GetBlendShapeFrameCount(shape);
				int frameIndex = blendShapeFrameCount - 1;
				Vector3[] array = default;
				sharedMesh.GetBlendShapeFrameVertices(shape, frameIndex, array, null, null);
				Vector3[] vertices = sharedMesh.vertices;
				boneWeights = sharedMesh.boneWeights;
				if (vertices != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj12 = 0;
					if (vertices.Length < 1)
					{
						obj13 = 0;
						goto IL_09ba;
					}
					object obj14 = vertices.Length & 0xFFFFFFFFL;
					object obj15 = boneWeights + 48;
					object obj16 = array + 40;
					object obj17 = vertices + 40;
					object obj18 = 0;
					object obj19 = 0;
					object obj20 = 0;
					obj4 = 0;
					num = 0f;
					float num6 = 0f;
					double num7 = 0.0;
					double num8 = 0.0;
					object obj21 = 0;
					obj13 = 0;
					array2 = boneWeights;
					object obj50 = default;
					while (boneWeights != null)
					{
						bool flag3 = (nint)obj18 < boneWeights.Length;
						object obj22 = !flag3;
						if (obj22 != null)
						{
							goto IL_068f;
						}
						if ((nint)obj15 == num3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X28_v6-10]");
							double num9 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X28_v6-10]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
							if (num10 >= 0)
							{
								object obj23 = obj13 & 1;
								bool flag4 = obj23 == null;
								object obj24 = !flag4;
								if (obj24 == null)
								{
									bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
									object obj25 = !flag5;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X22_v7-8]");
										obj21 = 0;
										num8 = (double)obj17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
										object obj26;
										if ((nint)0 != 0)
										{
											obj26 = obj14 & 0xFFFFFFFFL;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
											array2 = (BoneWeight[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
											obj12 = 0;
											obj26 = vertices.Length;
											_ = 1;
											obj14 = vertices.Length;
										}
										bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26);
										object obj27 = !flag6;
										if (obj27 == null)
										{
											if (array == null)
											{
												break;
											}
											bool flag7 = (nint)obj18 < array.Length;
											object obj28 = !flag7;
											if (obj28 == null)
											{
												object obj29 = obj12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X9_v17+A0]");
												object obj30 = 0;
												num6 = (float)obj17 + (float)obj16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X22_v7-8]");
												nint num11 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X29_v6-8]");
												obj20 = num11 + 0;
												obj4 = obj30 * 63;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X9_v18+8]");
												num7 = 0.0 * 0.5;
												obj19 = obj4;
												num = (float)num7;
												goto IL_0748;
											}
										}
									}
									goto IL_068f;
								}
								goto IL_0748;
							}
						}
						goto IL_06f4;
						IL_068f:
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
						IL_06f4:
						obj18++;
						obj15 += 32;
						obj16 += 12;
						obj17 += 12;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
						{
							continue;
						}
						goto IL_0660;
						IL_0748:
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
						object obj31 = !flag8;
						if (obj31 == null)
						{
							double num9 = num8 - num7;
							double num12 = num8 + num7;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
							{
								num9 = (double)obj17;
							}
							double num13 = num12 - (double)obj17;
							bool flag9 = num13 < 0.0;
							bool flag10 = num13 == 0.0;
							object obj32 = num12 ^ obj17;
							object obj33 = num12 ^ num13;
							object obj34 = obj32 & obj33;
							bool flag11 = (nint)obj34 < 0;
							bool flag12 = flag9 == flag11;
							object obj35 = !flag10;
							object obj36 = flag12 & obj35;
							object obj37 = ~obj36;
							if (obj37 != null)
							{
								num12 = (double)obj17;
							}
							if (array == null)
							{
								break;
							}
							bool flag13 = (nint)obj18 < array.Length;
							object obj38 = !flag13;
							if (obj38 == null)
							{
								object obj39 = obj21 - obj4;
								object obj40 = obj21 + obj4;
								float num14 = (float)obj17 + (float)obj16;
								float num15 = num6 - num;
								float num16 = num6 + num;
								object obj41 = obj20 + obj19;
								double num17 = num12 - num9;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								num7 = num17 * 0.5;
								if (!(num15 < num14))
								{
									num15 = num14;
								}
								float num18 = num16 - num14;
								bool flag14 = num18 < 0f;
								bool flag15 = num18 == 0f;
								object obj42 = num16 ^ num14;
								object obj43 = num16 ^ num18;
								object obj44 = obj42 & obj43;
								bool flag16 = (nint)obj44 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								bool flag17 = flag14 == flag16;
								object obj45 = !flag15;
								object obj46 = flag17 & obj45;
								object obj47 = ~obj46;
								if (obj47 != null)
								{
									num16 = num14;
								}
								num8 = num9 + num7;
								object obj48 = obj40 - obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								float num19 = num16 - num15;
								obj4 = obj48 * 63;
								object obj49 = obj41 - obj50;
								num = num19 * 0.5f;
								obj21 = obj39 + obj4;
								obj19 = obj49 * 63;
								num6 = num15 + num;
								obj20 = obj50 + obj19;
								obj13 = 1;
								goto IL_06f4;
							}
						}
						goto IL_068f;
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_0660:
		boneWeights = array2;
		goto IL_09ba;
		IL_09ba:
		object obj51 = obj13 & 1;
		if (obj51 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCAC");
			return num;
		}
		goto IL_09e5;
		IL_09e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		return 0f;
	}

	public Vector3 Unswelled(Transform eye)
	{
		//IL_015f: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_0094: Expected VT, but got I4
		//IL_0118: Expected VT, but got I4
		if (~(ready ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = eye == eyeL;
			if (flag2)
			{
				return (Vector3)flag2;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = eye == eyeR;
			if (flag4)
			{
				return (Vector3)flag4;
			}
		}
		if ((object)eye != null)
		{
			return eye.localScale;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private void Swell(float k, float total)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00a5: Invalid comparison between F4 and I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0185: Invalid comparison between F4 and I
		//IL_039b: Invalid comparison between VT and I4
		//IL_00d5: Expected VT, but got F4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03e0: Expected VT, but got F4
		//IL_01b5: Expected VT, but got F4
		//IL_032c: Expected VT, but got I4
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected VT, but got Unknown
		//IL_01cf: Invalid comparison between VT and I4
		//IL_0376: Expected VT, but got I4
		//IL_01f7: Expected Obj, but got VT
		//IL_0207: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I
		Vector3 localScale = eyeL.localScale;
		float num = k - (float)setL;
		float num2 = total;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+110]");
		float num3 = num2 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+114]");
		object obj2 = default;
		object obj = obj2 - 0;
		float num4 = num * num;
		float num5 = num3 * num3;
		float num6 = num4 + num5;
		object obj3 = obj * obj;
		float num7 = num6 + (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		if (num7 > 0f)
		{
			Vector3 localScale2 = eyeL.localScale;
			baseL = (Vector3)num7;
		}
		Vector3 localScale3 = eyeR.localScale;
		float num8 = num7 - (float)setR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+11C]");
		object obj4 = obj3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+120]");
		object obj5 = obj - 0;
		float num9 = num8 * num8;
		object obj6 = obj4 * obj4;
		float num10 = num9 + (float)obj6;
		object obj7 = obj5 * obj5;
		float num11 = num10 + (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		if (num11 > 0f)
		{
			Vector3 localScale4 = eyeR.localScale;
			baseR = (Vector3)num11;
		}
		Vector3 vector = baseL;
		if (baseL > (object)0 && baseR > (object)0)
		{
			object obj8 = baseL - baseR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+104]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+F8]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+104]");
			object obj10 = num12 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+FC]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+108]");
			object obj11 = num13 - 0;
			object obj12 = obj8 * obj8;
			object obj13 = obj10 * obj10;
			object obj14 = obj12 + obj13;
			object obj15 = obj11 * obj11;
			object obj16 = obj15 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			if ((nint)obj16 >= 0)
			{
				if (baseL < baseR)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+F8]");
					obj9 = 0;
				}
				if (vector < baseR)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+FC]");
					object obj17 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+108]");
					object obj17 = 0;
				}
				if (vector >= baseR)
				{
					vector = baseR;
				}
				baseL = vector;
				baseR = vector;
			}
		}
		float num14 = (float)vector * k;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+F8]");
		object obj19 = default;
		object obj18 = 0 * obj19;
		setL = (Vector3)num14;
		eyeL.localScale = (Vector3)0;
		Vector3 vector2 = baseR * obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeFace)+108]");
		float num15 = 0f * k;
		setR = vector2;
		eyeR.localScale = (Vector3)0;
		Pupils(total);
	}

	private unsafe void Hold(float open)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Ref, but got Unknown
		//IL_005b: Expected F4, but got VT
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Ref, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Ref, but got Unknown
		//IL_0092: Expected F4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 place = default;
		Vector3 vector = default;
		HoldOne(eyeL, ref *(Vector3*)(this + 244), ref *(Vector3*)(this + 268), place, vector, (float)placeL);
		HoldOne(eyeR, ref *(Vector3*)(this + 256), ref *(Vector3*)(this + 280), place, vector, (float)placeR);
		Pupils(1f);
	}

	private unsafe static void HoldOne(Transform eye, ref Vector3 size, ref Vector3 set, Vector3 place, Vector3 from, float k)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Invalid comparison between F4 and I
		//IL_00fa: Expected F4, but got VT
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_015f: Expected Ref, but got F4
		//IL_0177: Expected VT, but got I4
		//IL_0193: Expected VT, but got I4
		//IL_0193: Expected VT, but got I4
		//IL_00de: Expected Ref, but got F4
		//IL_012d: Expected VT, but got I4
		Vector3 localScale = eye.localScale;
		float num = k - (float)set;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X2 (UnityEngine.Vector3&)+4]");
		object obj2 = default;
		object obj = obj2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X2 (UnityEngine.Vector3&)+8]");
		object obj4 = default;
		object obj3 = obj4 - 0;
		float num2 = num * num;
		object obj5 = obj * obj;
		float num3 = num2 + (float)obj5;
		object obj6 = obj3 * obj3;
		float num4 = num3 + (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		object obj7 = 0;
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		if (num5 > 0f)
		{
			Vector3 localScale2 = eye.localScale;
			ref Vector3 reference = ref *(Vector3*)num4;
		}
		else
		{
			num4 = (float)size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [size @ X1 (UnityEngine.Vector3&)+4]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [size @ X1 (UnityEngine.Vector3&)+8]");
			obj3 = 0;
		}
		object obj8 = default;
		float num6 = num4 / (float)obj8;
		object obj9 = obj7 / obj8;
		object obj10 = obj3 / obj8;
		ref Vector3 reference2 = ref *(Vector3*)num6;
		eye.localScale = (Vector3)0;
		Quaternion localRotation = eye.localRotation;
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		eye.localPosition = (Vector3)0;
	}

	private void Pupils(float total)
	{
		//IL_02b7: Expected I4, but got I8
		//IL_02d1: Expected Obj, but got I4
		//IL_0033: Invalid comparison between F4 and I
		//IL_00e5: Invalid comparison between F4 and I4
		//IL_00f4: Expected F8, but got I4
		//IL_02f9: Invalid comparison between F8 and I
		//IL_007a: Invalid comparison between F8 and I
		//IL_032c: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I
		//IL_0285: Expected VT, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		int num = (int)(eyeSlot & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		float num2 = total + -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if (num2 < 0f)
		{
			double num3 = (double)swellShown + -1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			if (num3 < 0.0)
			{
				return;
			}
		}
		swellShown = total;
		float num4 = pupilReach;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		float num5 = num4 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABEC]");
		float num6 = 0f / total;
		bool flag2 = num6 < 0f;
		double num7 = 0.0;
		if (!flag2)
		{
			bool flag3 = !((double)num6 > 1.0);
			num7 = num6;
			if (!flag3)
			{
				num7 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D060");
		double num8 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if (num8 > 0.0)
		{
			num7 = (double)num5 / num7;
			if (num7 < 1.0)
			{
				num6 = 1f;
			}
			else
			{
				num6 = 1f;
			}
		}
		bool flag4 = eyeBlock == null;
		object obj2 = !flag4;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj4 = this + 344;
			eyeBlock = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		face.GetPropertyBlock(eyeBlock, eyeSlot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v12+A0]");
		object obj9 = 0;
		MaterialPropertyBlock materialPropertyBlock2 = eyeBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v13+8]");
		materialPropertyBlock2.SetVector(0, (Vector4)0);
		face.SetPropertyBlock(eyeBlock, eyeSlot);
	}

	private unsafe Transform ClosestOtherHead()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Ref, but got Unknown
		//IL_0622: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_042a: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got I4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Invalid comparison between Unknown and F4
		//IL_037b: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected F4, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Transform result = null;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
			Transform transform = (Transform)0;
			nint num = (nint)transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8 (Il2CppClass<UnityEngine.Transform>)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			nint num2 = num;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num2 = (nint)transform;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v9 (Il2CppClass<UnityEngine.Transform>)+A0]");
			object obj6 = 0;
			bool flag5 = obj6 == null;
			UnityEngine.Object obj8 = default;
			UnityEngine.Object obj7 = obj8;
			Enumerator<, > val = (Enumerator<, >)0;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (flag5)
			{
				goto IL_046e;
			}
			float num3 = lookRange * lookRange;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj6).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42C0]");
			object obj11 = 0;
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			obj9 = 0;
			transform = null;
			object obj20 = default;
			object obj21 = default;
			object obj25;
			Enumerator<, > val4;
			while (val.MoveNext())
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v35+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = obj8 == this;
				bool flag8 = !flag7;
				object obj14 = !flag8;
				obj9 = 0;
				if (obj14 != null)
				{
					continue;
				}
				if ((object)obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+6C]");
					bool flag9 = (nint)0 == playerId;
					obj9 = 0;
					if (flag9)
					{
						continue;
					}
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v44+E4]");
					bool flag10 = (nint)0 == 0;
					object obj16 = !flag10;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+28]");
					bool flag11 = (UnityEngine.Object)0 == null;
					bool flag12 = !flag11;
					object obj17 = !flag12;
					obj9 = 0;
					if (obj17 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+28]");
					bool flag13 = (nint)0 == 0;
					obj9 = 0;
					obj10 = null;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+28]");
						Vector3 position = ((Transform)0).position;
						bool flag14 = (object)head == null;
						obj9 = 0;
						obj10 = null;
						if (!flag14)
						{
							Vector3 position2 = head.position;
							object obj18 = val2 - val2;
							object obj19 = obj20 - obj20;
							obj21 -= obj21;
							object obj22 = obj18 * obj18;
							object obj23 = obj19 * obj19;
							object obj24 = obj22 + obj23;
							obj20 = obj21 * obj21;
							val2 = (Enumerator<, >)(obj20 + obj24);
							bool flag15 = !((float)val2 < num3);
							obj9 = 0;
							if (!flag15)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+28]");
								transform = (Transform)0;
								num3 = (float)val2;
								obj9 = 0;
							}
							continue;
						}
						goto IL_0442;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					obj9 = 0;
					obj10 = this;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0442;
				IL_0442:
				NullReferenceException ex3 = new NullReferenceException();
				obj7 = null;
				val = val3;
				obj25 = 0;
				val4 = (Enumerator<, >)(ref val);
				goto IL_046e;
			}
			obj7 = null;
			val = val3;
			obj25 = 0;
			val4 = (Enumerator<, >)(ref val);
			object obj26 = 0;
			object obj30 = default;
			Transform result2 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42B8]");
				object obj27 = 0;
				obj10 = (UnityEngine.Object)obj27;
				((Enumerator<, >*)val4)->Dispose();
				bool flag16 = obj26 == null;
				object obj28 = !flag16;
				if (obj28 == null)
				{
					bool flag17 = (object)obj7 == null;
					object obj29 = !flag17;
					result = transform;
					OutOfMemoryException ex4 = (OutOfMemoryException)val4;
					if (obj29 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex4 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj10 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj7 = (UnityEngine.Object)1;
					obj26 = obj25;
					continue;
				}
				if ((nint)obj10 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj26 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj25 = obj30;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CDD0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
		}
		return result;
		IL_046e:
		throw new NullReferenceException();
	}

	private void Aim(Transform eye, Quaternion rest, Vector3 gaze, Vector3 side, Transform target, float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_007f: Expected VT, but got Obj
		//IL_023e: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got VT
		//IL_038c: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got F4
		//IL_02cb: Expected Obj, but got VT
		//IL_02d8: Expected Obj, but got VT
		//IL_05d2: Expected VT, but got I4
		//IL_06a7: Expected Obj, but got I
		//IL_06e0: Expected Obj, but got I4
		//IL_0346: Invalid comparison between F4 and I
		//IL_03c0: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e9: Expected F4, but got I
		//IL_03fc: Expected VT, but got I4
		//IL_05ae: Expected VT, but got F4
		//IL_05b7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = default;
		object obj7 = default;
		object obj5 = obj6 * obj7;
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 * obj10;
		object obj12 = default;
		object obj11 = obj9 * obj12;
		Vector3 vector = default;
		object obj13 = vector * obj7;
		object obj14 = vector * obj10;
		object obj15 = obj6 * obj12;
		Vector3 vector2 = (Vector3)(obj5 - obj8);
		object obj16 = obj11 - obj13;
		float num = (float)obj14 - (float)obj15;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(EyesOut__BackingField, ref axis);
		object obj17 = default;
		float num2 = (float)obj17 * EyesOut__BackingField;
		float num3 = dt * (float)obj13;
		object obj18 = obj3;
		object obj20 = default;
		object obj19 = obj20 * obj13;
		object obj21 = obj17 * obj16;
		object obj23 = default;
		object obj22 = obj23 * obj13;
		float num4 = (float)obj17 * num;
		object obj24 = obj17 * obj13;
		float num5 = dt * EyesOut__BackingField;
		float num6 = num3 + num2;
		float num7 = (float)obj23 * (float)obj16;
		float num8 = (float)obj20 * num;
		float num9 = (float)obj19 + (float)obj21;
		float num10 = dt * num;
		float num11 = (float)obj23 * EyesOut__BackingField;
		float num12 = (float)obj22 + num4;
		float num13 = (float)obj20 * EyesOut__BackingField;
		float num14 = dt * (float)obj16;
		float num15 = (float)obj24 - num5;
		object obj25 = obj20 * obj16;
		float num16 = (float)obj23 * num;
		float num17 = num7 + num6;
		float num18 = num10 + num9;
		float num19 = num13 + num12;
		float num20 = num15 - (float)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj26 = !flag2;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num21 = num17 - num8;
		float num22 = num18 - num11;
		float num23 = num19 - num14;
		float num24 = num20 - num16;
		Quaternion b = default;
		Quaternion a;
		if ((UnityEngine.Object)rest != null)
		{
			Vector3 position = ((Transform)rest).position;
			Vector3 up = ((Transform)rest).up;
			float num25 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			float num26 = num25 * 0f;
			Transform parent = eye.parent;
			Vector3 position2 = eye.position;
			float num27 = num + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj27 = 0;
			float num28 = num27 - num;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v29+E4]");
			bool flag3 = (nint)0 == 0;
			object obj29 = !flag3;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num29 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num30;
			if (num29 > 0f)
			{
				num30 = num28 / num;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj30 = 0;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v20+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v21+8]");
				num30 = 0f;
			}
			Vector3 vector3 = parent.InverseTransformDirection((Vector3)0);
			float num31 = maxEyeAngle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num32 = num31 * 0f;
			Vector3 target2 = default;
			Vector3 vector4 = Vector3.Internal_RotateTowards(ref axis, ref target2, num32, 0f);
			Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref axis, ref target2);
			float num33 = num24 * num32;
			float num34 = num21 * num32;
			float num35 = num22 * num32;
			float num36 = num24 * 0f;
			float num37 = num23 * num32;
			float num38 = num24 * num30;
			float num39 = num24 * num32;
			float num40 = num21 * num32;
			float num41 = num34 + num33;
			float num42 = num23 * 0f;
			float num43 = num35 + num36;
			float num44 = num21 * num30;
			float num45 = num37 + num38;
			float num46 = num22 * num32;
			float num47 = num39 - num40;
			float num48 = num22 * 0f;
			num21 *= 0f;
			num6 = num42 + num41;
			num7 = num44 + num43;
			num9 = num22 * num30;
			num = num23 * num30;
			num10 = num46 + num45;
			num15 = num47 - num48;
			b = (Quaternion)num32;
			object obj33 = 0;
			a = (Quaternion)vector;
		}
		else
		{
			bool flag4 = (object)eye == null;
			object obj34 = !flag4;
			object obj33 = 0;
			a = (Quaternion)vector2;
			if (obj34 == null)
			{
				throw new NullReferenceException();
			}
		}
		Quaternion localRotation = eye.localRotation;
		object obj35 = default;
		float num49 = eyeSpeed * (float)obj35;
		object obj36 = 0f - num49;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		float t = 1f - (float)obj36;
		Quaternion quaternion3 = Quaternion.Internal_Slerp(ref a, ref b, t);
		eye.localRotation = (Quaternion)0;
	}

	private static Quaternion TurnedOut(Vector3 gaze, Vector3 side, float degrees)
	{
		float angle = default;
		Vector3 axis = default;
		return Quaternion.Internal_AngleAxis(angle, ref axis);
	}

	public ApeFace()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected F4, but got I
		//IL_0066: Expected F4, but got I
		//IL_0078: Expected F4, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_0025: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E340]");
		screamFrom = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C8F0]");
		screamEyes = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAB0]");
		lookRange = 0f;
		eyeSpeed = 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, int, int)> list = default;
		list._002Ector();
		object obj2 = this + 128;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		eyeSlot = -1;
		swellShown = 1f;
		mouthIdx = -1;
		base._002Ector();
	}

	static ApeFace()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4238]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4300]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = list;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v6+A0]");
		object obj8 = 0;
	}
}
