using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Rendering;

public class CosmeticWearer : MonoBehaviour
{
	private class Part
	{
		public Transform t;

		public Quaternion rest;

		public Vector3 tip;

		public Vector3 lastTip;

		public Vector3 vel;

		public Vector3 lastVel;

		public Vector3 acc;

		public Vector3 angle;

		public Vector3 speed;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SkinnedMeshRenderer> _003C_003E9__74_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B78]");
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

		internal bool _003CWearSuit_003Eb__74_0(SkinnedMeshRenderer p)
		{
			//IL_004b: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			if ((object)p != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C68]");
				object obj = 0;
				string name = p.name;
				return name == (string)obj;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public CosmeticCatalog.Entry e;

		internal bool _003COverTheEyes_003Eb__0(string w)
		{
			//IL_0090: Expected I4, but got Obj
			CosmeticCatalog.Entry entry = e;
			if (e != null && entry.name != null)
			{
				int num = entry.name.IndexOf(w, (StringComparison)5);
				int num2 = ~num;
				return (byte)(num2 >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public CosmeticSkin info;

		public int i;

		public Predicate<SkinnedMeshRenderer> _003C_003E9__1;

		internal bool _003CWearSuit_003Eb__1(SkinnedMeshRenderer p)
		{
			//IL_00fb: Expected I4, but got Obj
			//IL_009f: Expected Obj, but got I4
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected Obj, but got Unknown
			//IL_00d6: Expected Obj, but got I
			if ((object)p != null)
			{
				string name = p.name;
				CosmeticSkin cosmeticSkin = info;
				if ((object)info != null)
				{
					string[] suitPieces = cosmeticSkin.suitPieces;
					if (cosmeticSkin.suitPieces != null)
					{
						bool flag = i < suitPieces.Length;
						object obj = !flag;
						if (obj == null)
						{
							object obj2 = cosmeticSkin.suitPieces + i;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+20]");
							return name == (string)0;
						}
						goto IL_00ed;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_00ed;
			IL_00ed:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
	}

	public bool local;

	public bool skinOnly;

	private Dismemberment body;

	private SkinnedMeshRenderer skin;

	private SkinnedMeshRenderer eyes;

	private readonly List<(SkinnedMeshRenderer, Renderer)> suits;

	private int eyeSlot;

	private Transform headBone;

	private Transform spineBone;

	private Transform handL;

	private Transform handR;

	private Transform knucklesL;

	private readonly byte[] ids;

	private readonly List<GameObject>[] worn;

	private readonly List<Renderer> onHead;

	private bool headChanged;

	private MaterialPropertyBlock eyeBlock;

	private MaterialPropertyBlock furBlock;

	private readonly List<(Transform, Vector3)> eyeBones;

	private static readonly int BaseMap;

	private readonly List<(Renderer, int)> furSlots;

	private readonly Dictionary<Renderer, Material[]> beforeSkin;

	private CosmeticSkin look;

	private Material eyeBefore;

	private Material bloodBefore;

	private Material eyeMat;

	private Texture2D eyeTex;

	private float eyeSize;

	private float eyeOut;

	private ApeColor colour;

	private Color shownFur;

	private bool earsTucked;

	private CosmeticToy toy;

	private int toyState;

	private Transform toyLeft;

	private Transform toyRight;

	private Vector3 toyFromPos;

	private Quaternion toyFromRot;

	private Quaternion toyRest;

	private float toyHome;

	private float toyPop;

	private bool toyOnBody;

	private bool toyWasAway;

	private ApeFace Face__BackingField;

	public Func<bool> backHidden;

	private readonly List<GameObject> hiddenBack;

	private static readonly string[] OverEyes;

	private static readonly CosmeticSlot[] Stains;

	private static readonly Vector4 EarZone;

	private static readonly Vector3 EarRoot;

	private static readonly Vector3 EarKeep;

	private const float EarEase = default(float);

	private const float EarsOut = default(float);

	private static readonly Dictionary<Mesh, Mesh> tuckedOf;

	private static readonly Dictionary<Mesh, Mesh> untuckedOf;

	public ApeFace Face
	{
		get
		{
			return Face__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 360;
			Face__BackingField = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool CoversEyes
	{
		get
		{
			//IL_026a: Expected I4, but got Obj
			//IL_0038: Expected Obj, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			//IL_006f: Expected Obj, but got I4
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected I4, but got Unknown
			//IL_00b7: Expected Obj, but got I8
			//IL_00c7: Expected Obj, but got I
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00e0: Expected Obj, but got I4
			//IL_02ac: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected Obj, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected Obj, but got Unknown
			//IL_020d: Expected Obj, but got I4
			byte[] array = ids;
			object obj5;
			if (ids != null)
			{
				bool flag = array.Length < 0;
				bool flag2 = array.Length == 0;
				object obj = array.Length ^ array.Length;
				object obj2 = array.Length & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				object obj4 = flag4 & obj3;
				bool flag5 = array.Length < 1;
				obj5 = obj4;
				if (flag5)
				{
					goto IL_023b;
				}
				object obj6 = array.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
				object obj7 = 0;
				object obj8 = ids + 32;
				object obj9 = 0;
				object obj10 = obj4;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
					object obj11 = !flag6;
					if (obj11 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X24_v4+v75 @ X22_v5]");
					CosmeticCatalog.Entry e = CosmeticCatalog.Of(0);
					object obj12 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v8+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = OverTheEyes(e);
					bool flag9 = !flag8;
					object obj14 = !flag9;
					obj5 = obj10;
					if (obj14 == null)
					{
						obj6 = array.Length;
						obj9++;
						object obj15 = obj9 - array.Length;
						bool flag10 = (nint)obj15 < 0;
						object obj16 = obj9 ^ array.Length;
						object obj17 = obj9 ^ obj15;
						object obj18 = obj16 & obj17;
						bool flag11 = (nint)obj18 < 0;
						bool flag12 = flag10 == flag11;
						object obj19 = !flag12;
						bool flag13 = (nint)obj9 < array.Length;
						obj5 = obj19;
						obj10 = obj19;
						if (flag13)
						{
							continue;
						}
					}
					goto IL_023b;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
			IL_023b:
			return (byte)(obj5 & 1) != 0;
		}
	}

	private bool ShutsMouth
	{
		get
		{
			//IL_0246: Expected I4, but got Obj
			//IL_005c: Expected Obj, but got I4
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected Obj, but got Unknown
			//IL_0093: Expected Obj, but got I4
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected I4, but got Unknown
			//IL_00db: Expected Obj, but got I8
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_00f4: Expected Obj, but got I4
			//IL_025f: Expected Obj, but got I4
			//IL_016c: Expected Obj, but got I4
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected Obj, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01e9: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got I4
			byte[] array = ids;
			object obj5;
			if (ids != null)
			{
				bool flag = array.Length < 0;
				bool flag2 = array.Length == 0;
				object obj = array.Length ^ array.Length;
				object obj2 = array.Length & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				object obj4 = flag4 & obj3;
				bool flag5 = array.Length < 1;
				obj5 = obj4;
				if (flag5)
				{
					goto IL_0217;
				}
				object obj6 = array.Length & 0xFFFFFFFFL;
				object obj7 = ids + 32;
				object obj8 = 0;
				object obj9 = obj4;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
					object obj10 = !flag6;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X22_v4+v43 @ X21_v5]");
					CosmeticCatalog.Entry entry = CosmeticCatalog.Of(0);
					if (entry != null)
					{
						bool flag7 = (byte)(~(entry.shutsMouth ? 1u : 0u)) != 0;
						object obj11 = !flag7;
						obj5 = obj9;
						if (obj11 != null)
						{
							goto IL_0217;
						}
					}
					obj6 = array.Length;
					obj8++;
					object obj12 = obj8 - array.Length;
					bool flag8 = (nint)obj12 < 0;
					object obj13 = obj8 ^ array.Length;
					object obj14 = obj8 ^ obj12;
					object obj15 = obj13 & obj14;
					bool flag9 = (nint)obj15 < 0;
					bool flag10 = flag8 == flag9;
					object obj16 = !flag10;
					bool flag11 = (nint)obj8 < array.Length;
					obj5 = obj16;
					obj9 = obj16;
					if (flag11)
					{
						continue;
					}
					goto IL_0217;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
			IL_0217:
			return (byte)(obj5 & 1) != 0;
		}
	}

	public unsafe bool BackFrame(out Vector3 at, out Quaternion turn)
	{
		//IL_02af: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_029f: Expected I4, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7+A0]");
		object obj4 = 0;
		ref Quaternion reference2 = ref *(Quaternion*)obj4;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = spineBone == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(skin == null))
			{
				if ((object)spineBone != null)
				{
					Vector3 position = spineBone.position;
					reference = ref *(Vector3*)obj4;
					if ((object)spineBone != null)
					{
						Quaternion rotation = spineBone.rotation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
						object obj10 = 0;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v20+E4]");
						bool flag5 = (nint)0 == 0;
						object obj12 = !flag5;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Quaternion quaternion = OnBone(skin, spineBone);
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
						object obj14 = default;
						object obj13 = obj14 * obj4;
						object obj16 = default;
						object obj15 = obj4 * obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
						object obj17 = obj13 + obj15;
						object obj19 = default;
						object obj18 = obj4 * obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
						object obj20 = obj17 + obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						object obj21 = obj15 * obj19;
						object obj22 = obj20 - obj21;
						reference2 = ref *(Quaternion*)obj22;
						return true;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		return false;
	}

	public unsafe bool BackFrame(out Vector3 at, out Quaternion turn, out float scale)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_00e1: Expected Ref, but got F8
		//IL_009c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (spineBone != null)
		{
			if ((object)spineBone == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			Vector3 lossyScale = spineBone.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		}
		ref float reference = ref *(float*)1.0;
		return BackFrame(out at, out turn);
	}

	private unsafe void Awake()
	{
		//IL_1df3: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_1e1c: Expected Obj, but got I4
		//IL_1e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2b: Expected Obj, but got Unknown
		//IL_1e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e58: Expected I4, but got Unknown
		//IL_1e65: Expected I4, but got Obj
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected I, but got Unknown
		//IL_0266: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_028d: Expected I4, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected I4, but got Unknown
		//IL_0381: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected I4, but got Unknown
		//IL_0171: Expected I4, but got Obj
		//IL_1101: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I4
		//IL_1b08: Expected Obj, but got I
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b27: Expected Obj, but got Unknown
		//IL_1f9a: Expected Obj, but got I4
		//IL_1fd2: Expected I4, but got Obj
		//IL_1fdf: Expected I4, but got Obj
		//IL_1b60: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_1c1f: Expected Obj, but got I4
		//IL_1c46: Expected Obj, but got I
		//IL_1bbf: Expected Obj, but got I
		//IL_1bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Expected Obj, but got Unknown
		//IL_11c2: Expected Obj, but got I4
		//IL_11d2: Expected Obj, but got I4
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Expected I4, but got Unknown
		//IL_1c77: Expected Obj, but got I
		//IL_1c91: Expected Obj, but got I
		//IL_1c9f: Expected I, but got Obj
		//IL_1cbe: Expected Obj, but got I4
		//IL_1cce: Expected I4, but got Obj
		//IL_125a: Expected Obj, but got I
		//IL_126a: Expected Obj, but got I
		//IL_127a: Expected Obj, but got I
		//IL_128a: Expected Obj, but got I
		//IL_129a: Expected Obj, but got I
		//IL_12ae: Expected Obj, but got I8
		//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected Obj, but got Unknown
		//IL_2041: Expected Obj, but got I4
		//IL_2079: Expected I4, but got Obj
		//IL_2086: Expected I4, but got Obj
		//IL_1d0d: Expected Obj, but got I
		//IL_0ee6: Expected Obj, but got I
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f15: Expected Obj, but got I4
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Expected Obj, but got Unknown
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected I4, but got Unknown
		//IL_0f6a: Expected I4, but got Obj
		//IL_04d9: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected I4, but got Unknown
		//IL_1d2c: Expected Obj, but got I
		//IL_1d3a: Expected I, but got Obj
		//IL_1d54: Expected Obj, but got I4
		//IL_1d64: Expected I4, but got Obj
		//IL_12fe: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I8
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_132d: Expected Obj, but got I
		//IL_134b: Expected Obj, but got I4
		//IL_1f6b: Expected Obj, but got I4
		//IL_0586: Expected Obj, but got I8
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_1646: Expected Obj, but got I4
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1654: Expected Obj, but got Unknown
		//IL_166f: Expected Obj, but got I4
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected Obj, but got Unknown
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected I4, but got Unknown
		//IL_16b8: Expected I4, but got Obj
		//IL_1edb: Expected Obj, but got I4
		//IL_1f13: Expected I4, but got Obj
		//IL_1f20: Expected I4, but got Obj
		//IL_1397: Expected Obj, but got I
		//IL_13af: Expected Obj, but got I
		//IL_13bf: Expected Obj, but got I
		//IL_13cf: Expected Obj, but got I
		//IL_13df: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I4
		//IL_1702: Expected Obj, but got I
		//IL_1712: Expected Obj, but got I
		//IL_1722: Expected Obj, but got I
		//IL_1732: Expected Obj, but got I
		//IL_1742: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I4
		//IL_13fe: Expected Obj, but got I
		//IL_1412: Expected Obj, but got I
		//IL_0a4a: Expected Obj, but got I4
		//IL_0a59: Expected Obj, but got I4
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected I4, but got Unknown
		//IL_09f6: Expected Obj, but got I4
		//IL_0a04: Expected Obj, but got I4
		//IL_0a1c: Expected I4, but got Obj
		//IL_0700: Expected Obj, but got I4
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0729: Expected Obj, but got I4
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Obj, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected I4, but got Unknown
		//IL_0772: Expected I4, but got Obj
		//IL_1481: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got I4
		//IL_144b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1450: Expected Obj, but got Unknown
		//IL_1462: Expected Obj, but got I
		//IL_14f4: Expected Obj, but got I
		//IL_2023: Expected Obj, but got I
		//IL_0b32: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I4
		//IL_06a7: Expected Obj, but got I
		//IL_14ca: Expected Obj, but got I
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got I4
		//IL_1567: Expected Obj, but got I
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected Obj, but got Unknown
		//IL_1030: Expected Obj, but got I4
		//IL_153d: Expected Obj, but got I
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Expected Obj, but got Unknown
		//IL_0cb5: Expected Obj, but got I
		//IL_0ce9: Expected VT, but got I4
		//IL_0d01: Expected Obj, but got I4
		//IL_15da: Expected Obj, but got I
		//IL_0bef: Expected Obj, but got I4
		//IL_15b0: Expected Obj, but got I
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Expected Obj, but got Unknown
		//IL_0d34: Expected I, but got Obj
		//IL_0d6d: Expected VT, but got I4
		//IL_0d86: Expected Obj, but got I4
		//IL_1758: Expected Obj, but got I
		//IL_0c1d: Expected Obj, but got I
		//IL_178c: Expected Obj, but got I4
		//IL_1623: Expected Obj, but got I
		//IL_1629: Unknown result type (might be due to invalid IL or missing references)
		//IL_162e: Expected Obj, but got Unknown
		//IL_0dde: Expected Obj, but got I4
		//IL_181e: Expected Obj, but got I
		//IL_1832: Expected Obj, but got I
		//IL_184b: Expected VT, but got Obj
		//IL_184b: Expected Obj, but got I
		//IL_0e7f: Expected Obj, but got I
		//IL_0e8f: Expected Obj, but got I
		//IL_0e9f: Expected Obj, but got I
		//IL_0eaf: Expected VT, but got I4
		//IL_0eb9: Expected VT, but got I4
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected Obj, but got Unknown
		//IL_186b: Expected I4, but got Obj
		//IL_187b: Expected Obj, but got I
		//IL_1893: Expected Obj, but got I
		//IL_18a3: Expected Obj, but got I
		//IL_18b3: Expected Obj, but got I
		//IL_18c3: Expected Obj, but got I
		//IL_17ab: Expected Obj, but got I
		//IL_17bf: Expected Obj, but got I
		//IL_0e06: Expected Obj, but got I
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected Obj, but got Unknown
		//IL_0e38: Expected Obj, but got I4
		//IL_0e52: Expected VT, but got I4
		//IL_18eb: Expected Obj, but got I
		//IL_18fb: Expected Obj, but got I
		//IL_1919: Expected I, but got Obj
		//IL_193f: Expected I4, but got Obj
		//IL_194f: Expected Obj, but got I
		//IL_1967: Expected Obj, but got I
		//IL_1977: Expected Obj, but got I
		//IL_1987: Expected Obj, but got I
		//IL_1997: Expected Obj, but got I
		//IL_19e9: Expected Obj, but got I4
		//IL_1a8f: Expected Obj, but got I
		//IL_1a9f: Expected Obj, but got I
		//IL_1abe: Expected VT, but got Ref
		//IL_1ad4: Expected I, but got Obj
		//IL_1adc: Expected Obj, but got Ref
		//IL_1af1: Expected Obj, but got I
		//IL_1a0d: Expected Obj, but got I
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a22: Expected Obj, but got Unknown
		//IL_1a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b: Expected Obj, but got Unknown
		//IL_1a6d: Expected I, but got Obj
		//IL_1a75: Expected I4, but got Obj
		List<GameObject>[] array = worn;
		bool flag = worn == null;
		UnityEngine.Object obj = (UnityEngine.Object)(object)worn;
		List<System.__Canon> list = (List<System.__Canon>)109891584;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
			UnityEngine.Object obj2 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48B8]");
			UnityEngine.Object obj3 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4890]");
			UnityEngine.Object obj4 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4280]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48B0]");
			UnityEngine.Object obj6 = (UnityEngine.Object)0;
			UnityEngine.Object obj7 = (UnityEngine.Object)32;
			SkinnedMeshRenderer skinnedMeshRenderer = null;
			List<System.__Canon> list2 = (List<System.__Canon>)109891584;
			List<System.__Canon> list3 = default;
			object obj16 = default;
			UnityEngine.Object obj18 = default;
			(System.__Canon, int) tuple = default;
			ApeFace apeFace = default;
			UnityEngine.Object obj55 = default;
			Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon> action = default;
			Action action2 = default;
			IndexOutOfRangeException ex = default;
			while (true)
			{
				bool flag2 = (nint)skinnedMeshRenderer < array.Length;
				object obj8 = !flag2;
				object obj9 = skinnedMeshRenderer - array.Length;
				bool flag3 = (nint)obj9 < 0;
				bool flag4 = obj9 == null;
				int num = skinnedMeshRenderer ^ array.Length;
				int num2 = (object)skinnedMeshRenderer ^ obj9;
				int num3 = num & num2;
				bool flag5 = num3 < 0;
				bool flag6 = (nint)skinnedMeshRenderer >= array.Length;
				obj = (UnityEngine.Object)(object)array;
				UnityEngine.Object obj10 = obj7;
				SkinnedMeshRenderer skinnedMeshRenderer2 = skinnedMeshRenderer;
				list = list2;
				nint num5;
				UnityEngine.Object obj11;
				UnityEngine.Object obj24;
				int num9;
				UnityEngine.Object obj33;
				UnityEngine.Object obj34;
				Material[] sharedMaterials;
				int num6;
				UnityEngine.Object obj12;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj11 = obj3;
					list3._002Ector();
					if (list3 != null)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v80 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.GameObject>[]>)+40]");
						obj11 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v80 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.GameObject>[]>)+40]");
						obj12 = (UnityEngine.Object)0;
						if (flag7)
						{
							goto IL_1daf;
						}
					}
					bool flag8 = (nint)skinnedMeshRenderer < array.Length;
					obj8 = !flag8;
					obj9 = skinnedMeshRenderer - array.Length;
					flag3 = (nint)obj9 < 0;
					flag4 = obj9 == null;
					num = skinnedMeshRenderer ^ array.Length;
					num2 = (object)skinnedMeshRenderer ^ obj9;
					num3 = num & num2;
					flag5 = num3 < 0;
					if (obj8 == null)
					{
						object obj13 = (object)array + (object)skinnedMeshRenderer;
						object obj14 = (object)array + (object)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj = (UnityEngine.Object)(object)worn;
						skinnedMeshRenderer2 = (SkinnedMeshRenderer)(skinnedMeshRenderer + 1);
						obj10 = (UnityEngine.Object)(obj7 + 8);
						bool flag9 = worn == null;
						object obj15 = !flag9;
						list = list3;
						array = worn;
						obj7 = obj10;
						skinnedMeshRenderer = skinnedMeshRenderer2;
						list2 = list3;
						if (obj15 == null)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
					num5 = (nint)(this + 40);
					num5 = (nint)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
					object obj17 = 0;
					num6 = (int)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
					if ((object)obj18 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					bool flag10 = (nint)0 < (nint)1;
					obj8 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					obj9 = -1;
					flag3 = (nint)obj9 < 0;
					flag4 = obj9 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					num = (int)((nint)0 ^ (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					num2 = 0 ^ obj9;
					num3 = num & num2;
					flag5 = num3 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
					flag6 = (nint)0 < (nint)1;
					obj11 = (UnityEngine.Object)1;
					if (flag6)
					{
						goto IL_10cd;
					}
					obj11 = (UnityEngine.Object)1;
					list = null;
					while (true)
					{
						bool flag11 = System.Runtime.CompilerServices.Unsafe.As<List<System.__Canon>, UIntPtr>(ref list) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
						obj8 = !flag11;
						obj9 = (object)list - obj19;
						flag3 = (nint)obj9 < 0;
						flag4 = obj9 == null;
						num = (object)list ^ obj19;
						num2 = (object)list ^ obj9;
						num3 = num & num2;
						flag5 = num3 < 0;
						if (obj8 != null)
						{
							break;
						}
						object obj20 = obj5;
						object obj21 = (object)obj18 + (object)list;
						obj2 = skin;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v94+E4]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v47+20]");
						skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v94+E4]");
						bool flag12 = (nint)0 == 0;
						object obj22 = !flag12;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = obj2 == null;
						bool flag14 = !flag13;
						num6 = 0;
						Transform[] bones;
						bool flag18;
						if (!flag14)
						{
							bool flag15 = (object)skinnedMeshRenderer2 == null;
							num6 = 0;
							obj10 = obj18;
							if (flag15)
							{
								goto end_IL_1e01;
							}
							bones = skinnedMeshRenderer2.bones;
							bool flag16 = bones == null;
							num6 = 0;
							obj10 = obj18;
							if (flag16)
							{
								goto end_IL_1e01;
							}
							bool flag17 = bones.Length < 1;
							obj8 = !flag17;
							obj9 = bones.Length - 1;
							flag3 = (nint)obj9 < 0;
							flag4 = obj9 == null;
							num = bones.Length ^ 1;
							num2 = bones.Length ^ obj9;
							num3 = num & num2;
							flag5 = num3 < 0;
							flag6 = bones.Length < 1;
							num6 = 0;
							obj2 = (UnityEngine.Object)(object)bones;
							if (!flag6)
							{
								object obj23 = bones.Length & 0xFFFFFFFFL;
								obj3 = (UnityEngine.Object)(bones + 32);
								flag18 = flag6;
								int num8 = 0;
								obj24 = null;
								obj11 = null;
								while (true)
								{
									bool flag19 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
									obj8 = !flag19;
									obj9 = (object)obj24 - obj23;
									flag3 = (nint)obj9 < 0;
									flag4 = obj9 == null;
									num = (object)obj24 ^ obj23;
									num2 = (object)obj24 ^ obj9;
									num3 = num & num2;
									flag5 = num3 < 0;
									num6 = num8;
									if (obj8 != null)
									{
										break;
									}
									object obj25 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X28_v17 (UnityEngine.Object)+v607 @ X25_v16 (UnityEngine.Object)*8]");
									obj4 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v126+E4]");
									bool flag20 = (nint)0 == 0;
									object obj26 = !flag20;
									if (obj26 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag21 = obj4 != null;
									bool flag22 = !flag21;
									num6 = 0;
									obj11 = null;
									if (!flag22)
									{
										bool flag23 = (object)obj4 == null;
										flag6 = flag18;
										num6 = 0;
										obj = obj24;
										obj10 = obj18;
										obj2 = (UnityEngine.Object)(object)bones;
										if (flag23)
										{
											goto end_IL_1e01;
										}
										string text = obj4.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
										object obj27 = 0;
										bool flag24 = text == (string)obj27;
										bool flag25 = !flag24;
										object obj28 = !flag25;
										num6 = 0;
										obj11 = (UnityEngine.Object)obj27;
										if (obj28 != null)
										{
											goto IL_0ff7;
										}
									}
									obj23 = bones.Length;
									obj = (UnityEngine.Object)(obj24 + 1);
									bool flag26 = (nint)obj < bones.Length;
									obj8 = !flag26;
									obj9 = obj - bones.Length;
									flag3 = (nint)obj9 < 0;
									flag4 = obj9 == null;
									num = obj ^ bones.Length;
									num2 = (object)obj ^ obj9;
									num3 = num & num2;
									flag5 = num3 < 0;
									flag6 = (nint)obj < bones.Length;
									obj2 = (UnityEngine.Object)(object)bones;
									flag18 = flag6;
									num8 = num6;
									obj24 = obj;
									if (flag6)
									{
										continue;
									}
									goto IL_07cc;
								}
								break;
							}
						}
						goto IL_07cc;
						IL_0ff7:
						object obj29 = this + 48;
						skin = skinnedMeshRenderer2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag27 = (object)skinnedMeshRenderer2 == null;
						object obj30 = !flag27;
						num9 = 0;
						bool flag28 = flag5;
						int num10 = num3;
						int num11 = num2;
						int num12 = num;
						bool flag29 = flag4;
						bool flag30 = flag3;
						object obj31 = obj9;
						object obj32 = obj8;
						obj33 = obj4;
						obj34 = obj3;
						UnityEngine.Object obj35 = (UnityEngine.Object)(object)bones;
						if (obj30 == null)
						{
							flag6 = flag18;
							num6 = 0;
							obj = obj24;
							obj10 = obj18;
							obj2 = (UnityEngine.Object)(object)bones;
							goto end_IL_1e01;
						}
						goto IL_0861;
						IL_07cc:
						bool flag31 = (object)skinnedMeshRenderer2 == null;
						obj10 = obj18;
						flag18 = flag6;
						num9 = num6;
						obj24 = obj;
						flag28 = flag5;
						num10 = num3;
						num11 = num2;
						num12 = num;
						flag29 = flag4;
						flag30 = flag3;
						obj31 = obj9;
						obj32 = obj8;
						obj33 = obj4;
						obj34 = obj3;
						obj35 = obj2;
						if (flag31)
						{
							goto end_IL_1e01;
						}
						goto IL_0861;
						IL_0ed6:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
						obj19 = 0;
						list = (List<System.__Canon>)(list + 1);
						List<System.__Canon> list4 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
						bool flag32 = (nint)list4 < 0;
						obj8 = !flag32;
						List<System.__Canon> list5 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
						obj9 = list5 - 0;
						flag3 = (nint)obj9 < 0;
						flag4 = obj9 == null;
						List<System.__Canon> list6 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
						num = list6 ^ 0;
						num2 = (object)list ^ obj9;
						num3 = num & num2;
						flag5 = num3 < 0;
						List<System.__Canon> list7 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v14 (UnityEngine.Object)+18]");
						flag6 = (nint)list7 < 0;
						num6 = num9;
						obj = obj24;
						obj4 = obj33;
						obj3 = obj34;
						if (flag6)
						{
							continue;
						}
						goto IL_0fca;
						IL_0861:
						sharedMaterials = skinnedMeshRenderer2.sharedMaterials;
						bool flag33 = sharedMaterials == null;
						flag6 = flag18;
						num6 = num9;
						obj = obj24;
						flag5 = flag28;
						num3 = num10;
						num2 = num11;
						num = num12;
						flag4 = flag29;
						flag3 = flag30;
						obj9 = obj31;
						obj8 = obj32;
						obj10 = obj18;
						obj4 = obj33;
						obj3 = obj34;
						obj2 = obj35;
						if (flag33)
						{
							goto end_IL_1e01;
						}
						flag6 = sharedMaterials.Length < 1;
						obj11 = null;
						if (!flag6)
						{
							object obj36 = sharedMaterials.Length & 0xFFFFFFFFL;
							obj34 = (UnityEngine.Object)(sharedMaterials + 32);
							obj11 = null;
							int num13 = 0;
							while (true)
							{
								bool flag34 = num13 < (nint)obj36;
								object obj37 = !flag34;
								num6 = num9;
								if (obj37 != null)
								{
									break;
								}
								object obj38 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X28_v15 (UnityEngine.Object)+v343 @ X24_v18 (System.Int32)*8]");
								obj24 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v103+E4]");
								bool flag35 = (nint)0 == 0;
								object obj39 = !flag35;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag36 = obj24 == null;
								bool flag37 = !flag36;
								num9 = 0;
								obj11 = null;
								if (flag37)
								{
									bool flag38 = num13 < sharedMaterials.Length;
									obj8 = !flag38;
									obj9 = num13 - sharedMaterials.Length;
									flag3 = (nint)obj9 < 0;
									flag4 = obj9 == null;
									num = num13 ^ sharedMaterials.Length;
									num2 = num13 ^ obj9;
									num3 = num & num2;
									flag5 = num3 < 0;
									num6 = 0;
									obj11 = null;
									if (obj8 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X28_v15 (UnityEngine.Object)+v343 @ X24_v18 (System.Int32)*8]");
									bool flag39 = (nint)0 == 0;
									num6 = 0;
									obj = obj24;
									obj10 = obj18;
									obj4 = (UnityEngine.Object)num13;
									obj3 = obj34;
									obj2 = (UnityEngine.Object)(object)sharedMaterials;
									if (flag39)
									{
										goto end_IL_1e01;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X28_v15 (UnityEngine.Object)+v343 @ X24_v18 (System.Int32)*8]");
									string text2 = ((UnityEngine.Object)0).name;
									bool flag40 = text2 == null;
									num6 = 0;
									obj = obj24;
									obj10 = obj18;
									obj4 = (UnityEngine.Object)num13;
									obj3 = obj34;
									obj2 = (UnityEngine.Object)(object)sharedMaterials;
									if (flag40)
									{
										goto end_IL_1e01;
									}
									if (text2.Contains((string)value))
									{
										string text3 = skinnedMeshRenderer2.name;
										bool flag41 = text3 == null;
										num6 = 0;
										obj = obj24;
										obj10 = obj18;
										obj4 = (UnityEngine.Object)num13;
										obj3 = obj34;
										obj2 = (UnityEngine.Object)(object)sharedMaterials;
										if (flag41)
										{
											goto end_IL_1e01;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
										object obj40 = 0;
										bool flag42 = text3.Contains((string)obj40);
										bool flag43 = !flag42;
										num9 = 0;
										obj11 = (UnityEngine.Object)obj40;
										if (!flag43)
										{
											object obj41 = this + 56;
											eyes = skinnedMeshRenderer2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											eyeSlot = num13;
											num9 = 0;
											obj11 = skinnedMeshRenderer2;
										}
									}
									else
									{
										obj = furSlots;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C8]");
										object obj42 = 0;
										object obj43 = obj42;
										tuple = ((System.__Canon)(object)skinnedMeshRenderer2, num13);
										bool flag44 = (object)furSlots == null;
										tuple = ((System.__Canon, int))0;
										num6 = num13;
										obj10 = obj18;
										obj4 = (UnityEngine.Object)num13;
										obj3 = obj34;
										obj2 = (UnityEngine.Object)(object)sharedMaterials;
										if (flag44)
										{
											goto end_IL_1e01;
										}
										IntPtr cachedPtr = obj.m_CachedPtr;
										num7 = (nint)obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X25_v21 (UnityEngine.Object)+1C]");
										nint num14 = (nint)0 + (nint)1;
										bool flag45 = obj.m_CachedPtr == (IntPtr)0;
										tuple = ((System.__Canon, int))0;
										num6 = 0;
										obj10 = obj18;
										obj4 = (UnityEngine.Object)num13;
										obj3 = obj34;
										obj2 = (UnityEngine.Object)(object)sharedMaterials;
										if (flag45)
										{
											goto end_IL_1e01;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X25_v21 (UnityEngine.Object)+18]");
										num14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X25_v21 (UnityEngine.Object)+18]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v58 (System.IntPtr)+18]");
										bool flag46 = num15 < 0;
										object obj44 = !flag46;
										if (obj44 == null)
										{
											IntPtr cachedPtr2 = obj.m_CachedPtr;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X25_v21 (UnityEngine.Object)+18]");
											object obj45 = (nint)cachedPtr2 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X25_v21 (UnityEngine.Object)+18]");
											num7 = (nint)0 + (nint)1;
											object obj46 = obj45 + 32;
											obj46 = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											tuple = ((System.__Canon, int))0;
											num9 = 0;
											obj24 = furSlots;
											obj11 = null;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X9_v22 (Il2CppClass<UnityEngine.Object>)+20]");
											object obj47 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v59+A8]");
											object obj48 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v60+70]");
											obj43 = 0;
											((List<(System.__Canon, int)>)(object)furSlots).AddWithResize(((System.__Canon, int))0);
											tuple = ((System.__Canon, int))0;
											num9 = 0;
											obj24 = furSlots;
											obj11 = null;
										}
									}
								}
								obj36 = sharedMaterials.Length;
								obj33 = (UnityEngine.Object)(num13 + 1);
								flag6 = (nint)obj33 < sharedMaterials.Length;
								num13 = (int)obj33;
								if (flag6)
								{
									continue;
								}
								goto IL_0ed6;
							}
							break;
						}
						goto IL_0ed6;
					}
				}
				goto IL_1d99;
				IL_1af8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4880]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F1DC");
				Face__BackingField = apeFace;
				object obj50 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj51 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v25+E4]");
				bool flag47 = (nint)0 == 0;
				object obj52 = !flag47;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag48 = Face__BackingField == null;
				bool flag49 = !flag48;
				UnityEngine.Object obj53 = null;
				if (!flag49)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4888]");
					object obj54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
					Face__BackingField = (ApeFace)obj55;
					object obj56 = this + 360;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj53 = obj55;
				}
				object obj57 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X0_v30+E4]");
				bool flag50 = (nint)0 == 0;
				object obj58 = !flag50;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)num5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4898]");
					object obj60 = 0;
					action._002Ector((object)this, (IntPtr)obj60);
					bool flag51 = (object)body == null;
					object obj43 = 0;
					nint num7 = num5;
					num6 = (int)obj60;
					obj10 = (UnityEngine.Object)(object)action;
					list = (List<System.__Canon>)(object)body;
					if (flag51)
					{
						break;
					}
					body.PartTorn += (Action<ApePart, GameObject>)(object)action;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
					object obj61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48A0]");
					object obj62 = 0;
					action2._002Ector(this, (IntPtr)obj62);
					bool flag52 = (object)body == null;
					obj43 = 0;
					num7 = num5;
					num6 = (int)obj62;
					obj10 = (UnityEngine.Object)(object)action2;
					list = (List<System.__Canon>)(object)body;
					if (flag52)
					{
						break;
					}
					body.PartsReset += action2;
				}
				return;
				IL_10cd:
				object obj63 = obj5;
				obj10 = skin;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v16+E4]");
				bool flag53 = (nint)0 == 0;
				object obj64 = !flag53;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj10 != null)
				{
					bool flag54 = (object)skin == null;
					num6 = 0;
					if (flag54)
					{
						break;
					}
					Transform[] bones2 = skin.bones;
					bool flag55 = bones2 == null;
					num6 = 0;
					if (flag55)
					{
						break;
					}
					bool flag56 = bones2.Length < 1;
					obj8 = !flag56;
					obj9 = bones2.Length - 1;
					flag3 = (nint)obj9 < 0;
					flag4 = obj9 == null;
					num = bones2.Length ^ 1;
					num2 = bones2.Length ^ obj9;
					num3 = num & num2;
					flag5 = num3 < 0;
					if (bones2.Length >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
						UnityEngine.Object obj65 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
						UnityEngine.Object obj66 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
						UnityEngine.Object obj67 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
						UnityEngine.Object obj68 = (UnityEngine.Object)0;
						object obj69 = bones2.Length & 0xFFFFFFFFL;
						value = bones2 + 32;
						num6 = 0;
						obj11 = null;
						list = null;
						while (true)
						{
							bool flag57 = System.Runtime.CompilerServices.Unsafe.As<List<System.__Canon>, UIntPtr>(ref list) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69);
							obj8 = !flag57;
							obj9 = (object)list - obj69;
							flag3 = (nint)obj9 < 0;
							flag4 = obj9 == null;
							num = (object)list ^ obj69;
							num2 = (object)list ^ obj9;
							num3 = num & num2;
							flag5 = num3 < 0;
							if (obj8 != null)
							{
								break;
							}
							object obj70 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X0_v50+E4]");
							bool flag58 = (nint)0 == 0;
							object obj71 = !flag58;
							if (obj71 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
							bool flag59 = (UnityEngine.Object)0 == null;
							bool flag60 = !flag59;
							object obj72 = !flag60;
							num6 = 0;
							obj11 = null;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
								bool flag61 = (nint)0 == 0;
								num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
								obj = (UnityEngine.Object)0;
								obj10 = (UnityEngine.Object)(object)bones2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
								skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
								obj6 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
								obj3 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
								obj2 = (UnityEngine.Object)0;
								if (flag61)
								{
									goto end_IL_1e01;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
								string text4 = ((UnityEngine.Object)0).name;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
								object obj73 = 0;
								if (text4 == (string)obj73)
								{
									object obj74 = this + 80;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
									headBone = (Transform)0;
									num6 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
									string text5 = ((UnityEngine.Object)0).name;
									if (text5 == (string)(object)obj4)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
										spineBone = (Transform)0;
										object obj74 = this + 88;
										num6 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
										string text6 = ((UnityEngine.Object)0).name;
										if (text6 == (string)(object)obj65)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
											handL = (Transform)0;
											object obj74 = this + 96;
											num6 = 0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
											string text7 = ((UnityEngine.Object)0).name;
											if (text7 == (string)(object)obj66)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
												handR = (Transform)0;
												object obj74 = this + 104;
												num6 = 0;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
												string text8 = ((UnityEngine.Object)0).name;
												if (!(text8 == (string)(object)obj67))
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
													string text9 = ((UnityEngine.Object)0).name;
													bool flag62 = text9 == (string)(object)obj68;
													bool flag63 = !flag62;
													object obj75 = !flag63;
													if (obj75 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
														string text10 = ((UnityEngine.Object)0).name;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4910]");
														object obj76 = 0;
														bool flag64 = text10 == (string)obj76;
														bool flag65 = !flag64;
														num6 = 0;
														obj11 = (UnityEngine.Object)obj76;
														if (flag65)
														{
															goto IL_163c;
														}
													}
													List<(System.__Canon, Vector3)> list8 = (List<(System.__Canon, Vector3)>)(object)eyeBones;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
													Vector3 localScale = ((Transform)0).localScale;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D0]");
													object obj77 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
													(System.__Canon, Vector3) tuple2 = ((System.__Canon)0, (Vector3)obj77);
													bool flag66 = (object)eyeBones == null;
													num6 = (int)obj77;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
													obj = (UnityEngine.Object)0;
													obj10 = (UnityEngine.Object)(object)bones2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
													skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
													obj6 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
													obj4 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
													obj3 = (UnityEngine.Object)0;
													obj2 = eyeBones;
													if (flag66)
													{
														goto end_IL_1e01;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
													object obj78 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48A8]");
													object obj79 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+1C]");
													nint num14 = (nint)0 + (nint)1;
													nint num7 = (nint)obj79;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
													bool flag67 = (nint)0 == 0;
													num6 = (int)obj77;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
													obj = (UnityEngine.Object)0;
													obj10 = (UnityEngine.Object)(object)bones2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
													skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
													obj6 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
													obj4 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
													obj3 = (UnityEngine.Object)0;
													obj2 = eyeBones;
													if (flag67)
													{
														goto end_IL_1e01;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
													num14 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
													nint num16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v39+18]");
													bool flag68 = num16 < 0;
													object obj80 = !flag68;
													if (obj80 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
														object obj81 = (nint)0 * (nint)24;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
														object obj82 = 0 + obj81;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X23_v11 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
														num7 = (nint)0 + (nint)1;
														object obj83 = obj82 + 32;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														(System.__Canon, Vector3) tuple3 = tuple2;
														num14 = unchecked((nint)null);
														num6 = (int)obj77;
														obj11 = null;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X9_v22 (Il2CppClass<UnityEngine.Object>)+20]");
														object obj84 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ X8_v41+A8]");
														object obj85 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1253 @ X8_v42+70]");
														num6 = 0;
														((List<(System.__Canon, Vector3)>)(object)eyeBones).AddWithResize(((System.__Canon, Vector3))(&tuple));
														(System.__Canon, Vector3) tuple3 = tuple2;
														tuple = ((System.__Canon, int))tuple2;
														num7 = unchecked((nint)null);
														obj11 = (UnityEngine.Object)(&tuple);
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
													obj4 = (UnityEngine.Object)0;
													goto IL_163c;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
												knucklesL = (Transform)0;
												object obj74 = this + 112;
												num6 = 0;
											}
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
								obj11 = (UnityEngine.Object)0;
							}
							goto IL_163c;
							IL_163c:
							obj69 = bones2.Length;
							list = (List<System.__Canon>)(list + 1);
							bool flag69 = (nint)list < bones2.Length;
							obj8 = !flag69;
							obj9 = list - bones2.Length;
							flag3 = (nint)obj9 < 0;
							flag4 = obj9 == null;
							num = list ^ bones2.Length;
							num2 = (object)list ^ obj9;
							num3 = num & num2;
							flag5 = num3 < 0;
							if ((nint)list < bones2.Length)
							{
								continue;
							}
							goto IL_16f2;
						}
						goto IL_1d99;
					}
				}
				goto IL_1af8;
				IL_0fca:
				num6 = num9;
				obj = obj24;
				obj4 = obj33;
				obj3 = obj34;
				obj2 = (UnityEngine.Object)(object)sharedMaterials;
				goto IL_10cd;
				IL_1daf:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				throw new ArgumentNullException();
				IL_16f2:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
				obj = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X29_v4+v431 @ X20_v5 (System.Collections.Generic.List`1<System.__Canon>)*8]");
				skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
				obj6 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
				obj3 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
				obj2 = (UnityEngine.Object)0;
				goto IL_1af8;
				IL_1d99:
				ex = new IndexOutOfRangeException();
				obj12 = obj11;
				goto IL_1daf;
				continue;
				end_IL_1e01:
				break;
			}
		}
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4898]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon> action = default;
			action._002Ector((object)this, (IntPtr)obj5);
			body.PartTorn -= (Action<ApePart, GameObject>)(object)action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48A0]");
			object obj7 = 0;
			Action action2 = default;
			action2._002Ector(this, (IntPtr)obj7);
			body.PartsReset -= action2;
		}
	}

	private void Update()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		if (~(local ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		bool flag2;
		do
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte id = Cosmetics.In(cosmeticSlot);
			Put(cosmeticSlot, id, again: false);
			CosmeticSlot cosmeticSlot2 = cosmeticSlot + 1;
			flag2 = cosmeticSlot2 != (CosmeticSlot)8;
			cosmeticSlot = cosmeticSlot2;
		}
		while (flag2);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj2;
		}
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v13+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v2+8]");
		UnityEngine.Object obj12 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v2+8]");
		if ((UnityEngine.Object)0 != null)
		{
			byte netState = GillaToys.NetState;
			int num = netState & 0xFF;
			object obj14 = this + 288;
			toyState = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v8 (UnityEngine.Object)+38]");
			toyLeft = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = this + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X20_v8 (UnityEngine.Object)+40]");
			toyRight = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_060b: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Ref, but got Unknown
		//IL_067f: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Invalid comparison between Unknown and I4
		//IL_041d: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Invalid comparison between Unknown and I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got I4
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0388: Expected Obj, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03be: Expected Obj, but got I4
		Func<bool> func = backHidden;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool hide = default;
		if (backHidden != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ X8_v3 (System.Func`1<System.Boolean>)+18] (should have been resolved before IL gen)");
		}
		else if (~(local ? 1u : 0u) != 0 || ~(skinOnly ? 1u : 0u) == 0)
		{
			hide = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v68+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			hide = GillaBackpack.WornByYou;
		}
		HideBack(hide);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (look != null)
		{
			KeepSkin();
		}
		KeepEars();
		bool flag3 = (object)suits == null;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val5 = (Enumerator<, >)0;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4960]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4958]");
			object obj10 = 0;
			Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon)>)(object)suits).GetEnumerator();
			obj7 = 0;
			val = (Enumerator<, >)(ref val2);
			UnityEngine.Object obj15 = default;
			Enumerator<, > val6 = default;
			object obj23 = default;
			object obj17;
			Enumerator<, > val7;
			Enumerator<, > val8;
			while (true)
			{
				if (val2.MoveNext())
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v44+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v44+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = (UnityEngine.Object)val4 != null;
					bool flag6 = !flag5;
					obj7 = 0;
					if (flag6)
					{
						continue;
					}
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v48+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v48+E4]");
					bool flag7 = (nint)0 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = obj15 != null;
					bool flag9 = !flag8;
					obj7 = 0;
					if (!flag9)
					{
						if ((int)val4 == 0)
						{
							NullReferenceException ex = new NullReferenceException();
							obj8 = null;
							break;
						}
						bool flag10 = ((Renderer)val4).enabled;
						bool flag11 = (object)obj15 == null;
						obj8 = null;
						if (flag11)
						{
							break;
						}
						bool flag12 = ((Renderer)obj15).enabled;
						val = (Enumerator<, >)(flag10 ^ flag12);
						object obj16 = val & 1;
						bool flag13 = obj16 == null;
						obj7 = 0;
						if (!flag13)
						{
							bool flag14 = ((Renderer)obj15).enabled;
							((Renderer)val4).enabled = flag14;
							obj7 = 0;
						}
					}
					continue;
				}
				val2 = val6;
				val3 = (Enumerator<, >)0;
				obj17 = 0;
				val7 = val4;
				val5 = val6;
				val8 = (Enumerator<, >)(ref val2);
				object obj18 = 0;
				while (true)
				{
					obj8 = (UnityEngine.Object)obj10;
					((Enumerator<, >*)val8)->Dispose();
					bool flag15 = obj18 == null;
					object obj19 = !flag15;
					if (obj19 == null)
					{
						bool flag16 = (int)val3 == 0;
						object obj20 = !flag16;
						OutOfMemoryException ex2 = (OutOfMemoryException)val8;
						if (obj20 == null)
						{
							Tint();
							object obj21 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v14+E4]");
							bool flag17 = (nint)0 == 0;
							object obj22 = !flag17;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (toy != null)
							{
								float deltaTime = Time.deltaTime;
								PoseToy(deltaTime);
							}
							return;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj8 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						val3 = (Enumerator<, >)1;
						val = (Enumerator<, >)1;
						obj18 = obj17;
						continue;
					}
					if ((nint)obj8 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj18 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj17 = obj23;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D04C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex3 = new NullReferenceException();
			val2 = val6;
			val3 = (Enumerator<, >)0;
			obj17 = 0;
			val7 = val4;
			val5 = val6;
			val8 = (Enumerator<, >)(ref val2);
			obj7 = 0;
		}
		throw new NullReferenceException();
	}

	public void Show(byte head, byte face)
	{
		Put((CosmeticSlot)0, head, again: false);
		Put((CosmeticSlot)1, face, again: false);
	}

	public void Show(byte[] bySlot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		object obj = bySlot + 32;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		while (true)
		{
			if ((int)cosmeticSlot < bySlot.Length)
			{
				bool flag = (int)cosmeticSlot < bySlot.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					break;
				}
				CosmeticSlot slot = cosmeticSlot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X22_v2+v59 @ X21_v3 (CosmeticSlot)]");
				Put(slot, 0, again: false);
				cosmeticSlot++;
				if (cosmeticSlot == (CosmeticSlot)8)
				{
					return;
				}
				continue;
			}
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public byte In(CosmeticSlot slot)
	{
		//IL_00be: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		byte[] array = ids;
		if (ids != null)
		{
			bool flag = array.Length < (int)slot;
			object obj = !flag;
			object obj2 = array.Length - slot;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = ids + slot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2;
	}

	public IEnumerable<GameObject> Worn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Expected I4, but got I8
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dismemberment._003CWorn_003Ed__58 obj2 = default;
		obj2._002Ector(-2);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerable<GameObject>)(object)obj2;
		}
		return (IEnumerable<GameObject>)new NullReferenceException();
	}

	public unsafe bool TopOfHead(out float top)
	{
		//IL_1133: Expected Obj, but got I
		//IL_1146: Expected Obj, but got Ref
		//IL_10cd: Expected Obj, but got I4
		//IL_0d81: Expected Obj, but got I
		//IL_0d91: Expected Obj, but got I
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got I4
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_0dd7: Expected Obj, but got I4
		//IL_015c: Expected I, but got Obj
		//IL_0e16: Expected I, but got Obj
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected I, but got Obj
		//IL_0e62: Expected I, but got Obj
		//IL_028a: Expected I, but got Obj
		//IL_11be: Expected Obj, but got I
		//IL_1164: Expected Obj, but got I
		//IL_1180: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c4: Expected I, but got Obj
		//IL_0ec0: Expected I, but got Obj
		//IL_135a: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_03d0: Expected I, but got Obj
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected Obj, but got Unknown
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Expected Obj, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected Obj, but got Unknown
		//IL_0f71: Expected Obj, but got I4
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Expected Obj, but got Unknown
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1435: Expected Ref, but got Unknown
		//IL_143a: Expected I, but got Obj
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Invalid comparison between Unknown and I4
		//IL_0c0a: Expected Obj, but got Ref
		//IL_11f5: Expected Obj, but got I
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_120c: Expected Obj, but got Unknown
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Expected Obj, but got I4
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0c30: Expected Obj, but got I
		//IL_0c40: Expected Obj, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected Obj, but got I4
		//IL_0d0a: Expected Obj, but got I4
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected Obj, but got I4
		//IL_0ccb: Expected I, but got Obj
		//IL_13f4: Expected Obj, but got I
		//IL_0c7b: Expected Obj, but got I
		//IL_0526: Expected I, but got Obj
		//IL_0b6f: Expected Obj, but got I4
		//IL_12e4: Expected Obj, but got I
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_1294: Expected Obj, but got I
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected Obj, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I4
		//IL_05d5: Expected I, but got Obj
		//IL_0aa0: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_05fb: Expected I, but got Obj
		//IL_0640: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I4
		//IL_0696: Expected I4, but got I8
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06bd: Expected Obj, but got I4
		//IL_06d6: Expected I, but got Obj
		//IL_1324: Expected Obj, but got I4
		//IL_132c: Expected Obj, but got Ref
		//IL_06f3: Expected Obj, but got I
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected Obj, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected Obj, but got Unknown
		//IL_0728: Expected I, but got Obj
		//IL_0761: Expected Obj, but got I4
		//IL_07e1: Expected I4, but got Obj
		//IL_07f1: Expected Obj, but got I
		//IL_0812: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I
		//IL_07cb: Expected Obj, but got I
		//IL_0846: Expected Obj, but got I
		//IL_08bb: Expected I4, but got Obj
		//IL_091c: Expected Obj, but got I4
		//IL_093c: Expected Obj, but got I4
		//IL_09be: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got I
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		ref float reference = ref *(float*)4286578687L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = (byte)(~(headChanged ? 1u : 0u)) != 0;
		UnityEngine.Object obj2 = (UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref top);
		if (flag)
		{
			goto IL_0d49;
		}
		List<Renderer> list = onHead;
		headChanged = false;
		bool flag2 = (object)onHead == null;
		ref float reference2 = ref top;
		bool flag4;
		nint num2 = default;
		int num4;
		object obj7 = default;
		nint num6;
		if (!flag2)
		{
			int version = list._version + 1;
			object obj3 = list._size - 1;
			bool flag3 = obj3 == null;
			list._size = 0;
			list._version = version;
			flag4 = list._size < 1;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref top);
			if (!flag4)
			{
				Array.Clear(list._items, 0, list._size);
				num = 0;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v40+E4]");
			bool flag5 = (nint)0 == 0;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = headBone != null;
			bool flag7 = !flag6;
			obj2 = null;
			num2 = unchecked((nint)null);
			if (flag7)
			{
				goto IL_0d49;
			}
			IEnumerable<GameObject> enumerable = Worn();
			bool flag8 = enumerable == null;
			reference2 = ref *(float*)null;
			num2 = unchecked((nint)null);
			if (!flag8)
			{
				nint num3 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A10]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_027b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+98]");
				int num5 = (int)((nint)0 + (nint)8);
				bool flag9 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X10_v52 (System.Int32)-8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X10_v52 (System.Int32)-8]");
					obj3 = -((int*)num4)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X10_v52 (System.Int32)-8]");
					if ((nint)0 == ((int*)num4)->m_value)
					{
						break;
					}
					obj6--;
					obj3 = obj6 - 1;
					flag3 = obj3 == null;
					num4 = num5 + 16;
					flag4 = (nint)obj6 != 1;
					num5 = num4;
					flag9 = flag4;
					if (flag4)
					{
						continue;
					}
					goto IL_027b;
				}
				object obj8 = num3 + ((int*)num5)->m_value;
				object obj9 = obj8 + 312;
				num4 = num5;
				flag4 = flag9;
				num6 = unchecked((nint)null);
				goto IL_11ae;
			}
		}
		goto IL_10bb;
		IL_137f:
		NullReferenceException ex;
		bool flag10 = ex == null;
		object obj10 = !flag10;
		object obj11 = default;
		Enumerator<, > val = (Enumerator<, >)(ref obj11);
		object obj12 = 0;
		reference2 = ref *(float*)obj2;
		UnityEngine.Object obj13 = default;
		NullReferenceException ex2;
		nint num7;
		if (obj10 == null)
		{
			bool flag11 = (object)obj13 == null;
			object obj14 = !flag11;
			val = (Enumerator<, >)(ref obj11);
			num2 = num7;
			val = (Enumerator<, >)(ref obj11);
			obj12 = 0;
			reference2 = ref *(float*)obj2;
			ex2 = ex;
			if (obj14 == null)
			{
				goto IL_0d49;
			}
			goto IL_10da;
		}
		goto IL_1481;
		IL_10e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_0abe:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0acc;
		IL_0be3:
		Enumerator<, > val2 = (Enumerator<, >)(ref obj11);
		object obj15 = val2;
		bool flag12 = (int)val2 == 0;
		obj2 = (UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		if (flag12)
		{
			goto IL_137f;
		}
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X8_v32+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X8_v32+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0cbc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X8_v32+98]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X10_v18-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj18--;
			obj19 += 16;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_0cbc;
		}
		object obj20 = obj16 + obj19;
		object obj21 = obj20 + 312;
		goto IL_13e4;
		IL_1481:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		NullReferenceException ex5 = (NullReferenceException)(object)ex4;
		goto IL_10e9;
		IL_0cbc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num7 = unchecked((nint)null);
		goto IL_13e4;
		IL_0b1a:
		ex5 = new NullReferenceException();
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) == (void*)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex = null;
			obj13 = (UnityEngine.Object)1;
			num7 = num6;
		}
		else
		{
			bool flag13 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != (void*)1;
			val = (Enumerator<, >)(ref obj11);
			obj12 = 0;
			num7 = num6;
			if (flag13)
			{
				goto IL_10e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj22 = default;
			ex = (NullReferenceException)obj22;
			obj13 = null;
			num7 = num6;
		}
		goto IL_0be3;
		IL_0b04:
		NullReferenceException ex6 = new NullReferenceException();
		System.__Canon _Canon;
		reference2 = ref *(float*)_Canon;
		goto IL_0b1a;
		IL_0af6:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0b04;
		IL_10da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1481;
		IL_0ae8:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_0af6;
		IL_0d49:
		bool flag14 = (object)onHead == null;
		reference2 = ref *(float*)obj2;
		if (flag14)
		{
			goto IL_10bb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
		object obj24 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)onHead).GetEnumerator();
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val5 = default;
		object obj27 = default;
		object obj28 = default;
		while (val5.MoveNext())
		{
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v24+E4]");
			bool flag15 = (nint)0 == 0;
			object obj26 = !flag15;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = obj13 != null;
			bool flag17 = !flag16;
			num2 = unchecked((nint)null);
			if (flag17)
			{
				continue;
			}
			if ((object)obj13 != null)
			{
				bool flag18 = ((Renderer)obj13).enabled;
				bool flag19 = !flag18;
				num2 = unchecked((nint)null);
				if (flag19)
				{
					continue;
				}
				GameObject gameObject = ((Component)obj13).gameObject;
				bool flag20 = (object)gameObject == null;
				reference2 = ref *(float*)null;
				if (!flag20)
				{
					bool activeInHierarchy = gameObject.activeInHierarchy;
					bool flag21 = !activeInHierarchy;
					num2 = unchecked((nint)null);
					if (!flag21)
					{
						Bounds bounds = ((Renderer)obj13).bounds;
						val3 = (Enumerator<, >)(obj27 + obj28);
						object obj29 = top - val3;
						bool flag22 = (nint)obj29 < 0;
						bool flag23 = obj29 == null;
						object obj30 = top ^ val3;
						object obj31 = top ^ obj29;
						object obj32 = obj30 & obj31;
						bool flag24 = (nint)obj32 < 0;
						bool flag25 = flag22 == flag24;
						object obj33 = !flag23;
						object obj34 = flag25 & obj33;
						object obj35 = ~obj34;
						if (obj35 == null)
						{
							val3 = (Enumerator<, >)top;
						}
						reference = ref *(float*)val3;
						num2 = unchecked((nint)null);
					}
					continue;
				}
			}
			else
			{
				NullReferenceException ex9 = new NullReferenceException();
				reference2 = ref *(float*)null;
			}
			NullReferenceException ex10 = new NullReferenceException();
			val = (Enumerator<, >)(ref val5);
			num2 = unchecked((nint)null);
			goto IL_10bb;
		}
		reference2 = ref *(float*)obj24;
		val5.Dispose();
		val = (Enumerator<, >)(ref val5);
		obj12 = 0;
		num7 = num2;
		goto IL_1481;
		IL_027b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num6 = unchecked((nint)null);
		goto IL_11ae;
		IL_11ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v46+8]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v633 @ X0_v46] (should have been resolved before IL gen)");
		object obj36 = default;
		if (obj36 == null)
		{
			goto IL_0abe;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A18]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A30]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A38]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
		object obj41 = 0;
		num7 = num6;
		object obj42 = obj36;
		GameObject gameObject2 = default;
		List<System.__Canon> list2 = default;
		object obj49 = default;
		object obj69 = default;
		while (true)
		{
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v46+12E]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v46+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v46+98]");
			int num8 = (int)((nint)0 + (nint)8);
			bool flag26 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X10_v47 (System.Int32)-8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X10_v47 (System.Int32)-8]");
				object obj3 = 0 - obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X10_v47 (System.Int32)-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				obj44--;
				obj3 = obj44 - 1;
				bool flag3 = obj3 == null;
				num4 = num8 + 16;
				flag4 = (nint)obj44 != 1;
				num8 = num4;
				flag26 = flag4;
				if (flag4)
				{
					continue;
				}
				goto IL_03c1;
			}
			object obj45 = obj43 + ((int*)num8)->m_value;
			object obj46 = obj45 + 312;
			num4 = num8;
			flag4 = flag26;
			goto IL_1235;
			IL_12d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v80+8]");
			_Canon = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1296 @ X0_v80] (should have been resolved before IL gen)");
			int num13;
			if ((object)gameObject2 != null)
			{
				Transform transform = gameObject2.transform;
				bool flag27 = (object)transform == null;
				_Canon = null;
				if (!flag27)
				{
					bool flag28 = transform.IsChildOf(headBone);
					bool flag29 = !flag28;
					_Canon = (System.__Canon)(object)headBone;
					num6 = unchecked((nint)null);
					if (!flag29)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
						object obj47 = 0;
						num6 = (nint)obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
						bool flag30 = list2 == null;
						reference2 = ref *(float*)1;
						if (flag30)
						{
							goto IL_0b1a;
						}
						object obj3 = list2._size - 1;
						bool flag3 = obj3 == null;
						flag4 = list2._size < 1;
						_Canon = (System.__Canon)1;
						if (!flag4)
						{
							int num9 = (int)(list2._size & 0xFFFFFFFFL);
							object obj48 = list2 + 32;
							obj49 = obj49;
							object obj50 = obj7;
							object obj51 = 0;
							int num10 = num4;
							ref float reference3 = ref *(float*)1;
							nint num11 = (nint)obj47;
							List<System.__Canon> list3 = list2;
							while (true)
							{
								bool flag31 = (nint)obj51 < num9;
								object obj52 = !flag31;
								_Canon = (System.__Canon)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
								num6 = num11;
								if (obj52 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X25_v17+v832 @ X29_v19*8]");
								_Canon = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X25_v17+v832 @ X29_v19*8]");
								object obj57;
								if ((nint)0 != 0)
								{
									object obj53 = obj39;
									nint num12 = (nint)_Canon;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+130]");
									num13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+130]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v33+130]");
									bool flag32 = num14 < 0;
									object obj54 = !flag32;
									object obj55 = ~obj54;
									if (obj55 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+B0]");
										obj49 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+B0]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v33+130]");
										object obj56 = num15 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ X11_v32-8]");
										bool flag33 = 0 == (nint)obj53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+B0]");
										obj57 = 0;
										if (flag33)
										{
											goto IL_0875;
										}
									}
									num10 = (int)obj40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X10_v32 (System.Int32)+130]");
									obj50 = 0;
									int num16 = num13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X10_v32 (System.Int32)+130]");
									bool flag34 = (nint)num16 < (nint)0;
									object obj58 = !flag34;
									object obj59 = ~obj58;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1363 @ X8_v60 (Il2CppClass<System.__Canon>)+B0]");
										nint num17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X10_v32 (System.Int32)+130]");
										object obj60 = num17 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ X8_v68-8]");
										bool flag35 = (nint)0 != num10;
										obj57 = obj49;
										if (!flag35)
										{
											goto IL_0875;
										}
									}
								}
								goto IL_09fa;
								IL_0875:
								list3 = (List<System.__Canon>)(object)onHead;
								bool flag36 = (object)onHead == null;
								num6 = num11;
								if (!flag36)
								{
									System.__Canon[] items = list3._items;
									num13 = (int)obj41;
									int version2 = list3._version + 1;
									list3._version = version2;
									bool flag37 = list3._items == null;
									num6 = num11;
									if (!flag37)
									{
										num10 = list3._size;
										obj50 = items.Length;
										bool flag38 = list3._size < items.Length;
										object obj61 = !flag38;
										if (obj61 == null)
										{
											object obj62 = list3._items + list3._size;
											num13 = list3._size + 1;
											list3._size = num13;
											object obj63 = obj62 + 32;
											obj63 = _Canon;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											obj49 = obj57;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1339 @ X9_v34 (System.Int32)+20]");
											object obj64 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X8_v63+A8]");
											object obj65 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v64+70]");
											num11 = 0;
											((List<System.__Canon>)(object)onHead).AddWithResize(_Canon);
											obj49 = obj57;
										}
										goto IL_09fa;
									}
								}
								goto IL_0ada;
								IL_09fa:
								num9 = list2._size;
								object obj66 = obj51 + 1;
								obj3 = obj66 - list2._size;
								flag3 = obj3 == null;
								flag4 = (nint)obj66 < list2._size;
								obj7 = obj50;
								num4 = num10;
								num6 = num11;
								obj51 = obj66;
								reference3 = ref *(float*)_Canon;
								if (flag4)
								{
									continue;
								}
								goto IL_0a86;
							}
							goto IL_0acc;
						}
					}
					goto IL_0a86;
				}
				goto IL_0ae8;
			}
			goto IL_0b04;
			IL_0a86:
			bool flag39 = obj36 == null;
			object obj67 = !flag39;
			num7 = num6;
			obj42 = obj36;
			if (obj67 != null)
			{
				continue;
			}
			goto IL_0abe;
			IL_0517:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num6 = unchecked((nint)null);
			goto IL_12d4;
			IL_03c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num7 = unchecked((nint)null);
			goto IL_1235;
			IL_1235:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X0_v77+8]");
			reference2 = ref *(float*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1034 @ X0_v77] (should have been resolved before IL gen)");
			object obj68 = obj69 & 1;
			bool flag40 = obj68 == null;
			ex = null;
			obj13 = null;
			if (flag40)
			{
				break;
			}
			bool flag41 = obj36 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X0_v77+8]");
			_Canon = (System.__Canon)0;
			num6 = num7;
			if (flag41)
			{
				goto IL_0af6;
			}
			object obj70 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v49+12E]");
			num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v49+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0517;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v49+98]");
			int num18 = (int)((nint)0 + (nint)8);
			bool flag42 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X10_v42 (System.Int32)-8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X10_v42 (System.Int32)-8]");
				object obj3 = 0 - obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X10_v42 (System.Int32)-8]");
				if (0 == (nint)obj38)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v49+12E]");
				num13 = (int)(-1);
				obj3 = num13 - 1;
				bool flag3 = obj3 == null;
				num4 = num18 + 16;
				flag4 = num13 != 1;
				num18 = num4;
				flag42 = flag4;
				if (flag4)
				{
					continue;
				}
				goto IL_0517;
			}
			num13 = ((int*)num18)->m_value;
			object obj71 = obj70 + ((int*)num18)->m_value;
			object obj72 = obj71 + 312;
			num4 = num18;
			flag4 = flag42;
			num6 = num7;
			goto IL_12d4;
		}
		goto IL_0be3;
		IL_0ada:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0ae8;
		IL_0acc:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		goto IL_0ada;
		IL_10bb:
		ex2 = new NullReferenceException();
		obj12 = 0;
		num7 = num2;
		goto IL_10da;
		IL_13e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v52+8]");
		obj2 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1303 @ X0_v52] (should have been resolved before IL gen)");
		goto IL_137f;
	}

	public static bool OverTheEyes(CosmeticCatalog.Entry e)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0110: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass62_0 obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = e;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+20]");
				if ((nint)0 == 1)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v10+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A50]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A58]");
				object obj10 = 0;
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector((object)obj2, (IntPtr)obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7+8]");
				return Array.Exists((System.__Canon[])0, predicate);
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public void HoldToy(int state, Transform left, Transform right)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		toyState = state;
		toyLeft = left;
		object obj = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 296;
		toyRight = right;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void Put(CosmeticSlot slot, byte id, bool again = default(bool))
	{
		//IL_1044: Expected Obj, but got I4
		//IL_1066: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_10e5: Expected Obj, but got I4
		//IL_1115: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_1337: Expected Obj, but got I
		//IL_1348: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I4
		//IL_1003: Expected VT, but got I4
		bool flag = !skinOnly;
		object obj = !flag;
		object obj2 = ~obj;
		bool flag2;
		if (obj2 == null)
		{
			object obj3 = slot - 6;
			flag2 = obj3 == null;
		}
		else
		{
			flag2 = true;
		}
		object obj4 = !flag2;
		byte b = (byte)((obj4 == null) ? id : 0);
		int id2 = b & 0xFF;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
		bool flag3 = entry == null;
		string value = (string)(object)entry;
		if (!flag3)
		{
			value = entry.wornWith;
		}
		bool flag4 = string.IsNullOrEmpty(value);
		byte[] array = ids;
		bool flag5 = !flag4;
		object obj5 = !flag5;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			b = 0;
		}
		bool flag6 = ids == null;
		Transform transform = (Transform)id;
		UnityEngine.Object obj7 = null;
		if (!flag6)
		{
			bool flag7 = array.Length < (int)slot;
			object obj8 = !flag7;
			object obj9 = array.Length - slot;
			bool flag8 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag8;
			transform = (Transform)id;
			obj7 = null;
			if (obj11 != null)
			{
				goto IL_0f41;
			}
			object obj12 = ids + slot;
			object obj13 = obj12 + 32;
			bool flag9 = default;
			if ((nint)obj13 == (int)b && !flag9)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj14 = 0;
			obj13 = b;
			headChanged = true;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v32+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Face__BackingField != null)
			{
				ApeFace apeFace = Face__BackingField;
				bool coversEyes = CoversEyes;
				bool flag11 = (object)Face__BackingField == null;
				transform = null;
				obj7 = null;
				if (flag11)
				{
					goto IL_0f33;
				}
				apeFace.EyesCovered__BackingField = coversEyes;
			}
			List<GameObject>[] array2 = worn;
			bool flag12 = worn == null;
			transform = null;
			obj7 = null;
			if (!flag12)
			{
				bool flag13 = array2.Length < (int)slot;
				object obj17 = !flag13;
				object obj18 = array2.Length - slot;
				bool flag14 = obj18 == null;
				object obj19 = ~obj17;
				object obj20 = obj19 | flag14;
				transform = null;
				obj7 = null;
				if (obj20 != null)
				{
					goto IL_0f41;
				}
				object obj21 = worn + slot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v20+20]");
				bool flag15 = (nint)0 == 0;
				transform = null;
				obj7 = null;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v20+20]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
					object obj23 = 0;
					transform = null;
					Enumerator<, > val = default;
					UnityEngine.Object obj26 = default;
					while (val.MoveNext())
					{
						object obj24 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v116+E4]");
						bool flag16 = (nint)0 == 0;
						object obj25 = !flag16;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag17 = obj26 != null;
						bool flag18 = !flag17;
						transform = null;
						if (!flag18)
						{
							object obj27 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v120+E4]");
							bool flag19 = (nint)0 == 0;
							object obj28 = !flag19;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Gone((GameObject)obj26);
							transform = null;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
					object obj29 = 0;
					obj7 = (UnityEngine.Object)obj29;
					val.Dispose();
					Enumerator<, > val3 = default;
					Enumerator<, > val2 = val3;
					Enumerator<, > val4 = (Enumerator<, >)(ref val);
					OutOfMemoryException ex = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					}
					else
					{
						if ((nint)obj7 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
					shownFur = (Color)0;
					_ = 0;
					return;
				}
			}
		}
		goto IL_0f33;
		IL_0f33:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0f41;
		IL_0f41:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void HideBack(bool hide)
	{
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I
		//IL_08ca: Expected I4, but got Obj
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Ref, but got Unknown
		//IL_08ed: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected I, but got Obj
		//IL_05aa: Expected Obj, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_090b: Expected Obj, but got I
		//IL_0913: Expected I4, but got Obj
		//IL_092a: Expected Obj, but got I4
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected I, but got Obj
		//IL_04ba: Expected Obj, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I4
		//IL_0504: Expected I, but got Obj
		//IL_0813: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I4
		//IL_06bc: Expected I, but got Obj
		//IL_06e1: Expected Obj, but got I4
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected I, but got Obj
		//IL_0231: Expected I, but got Obj
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got VT
		//IL_036e: Expected Obj, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0344: Expected I, but got Obj
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<, > val;
		UnityEngine.Object obj10 = default;
		UnityEngine.Object obj18;
		bool flag = default;
		CosmeticWearer cosmeticWearer;
		UnityEngine.Object obj16;
		NullReferenceException ex4;
		if (flag)
		{
			List<GameObject>[] array = worn;
			bool flag2 = worn == null;
			val = (Enumerator<, >)0;
			cosmeticWearer = this;
			if (!flag2)
			{
				Enumerator<, > val2 = (Enumerator<, >)array.Length;
				bool flag3 = array.Length < 5;
				object obj = !flag3;
				object obj2 = array.Length - 5;
				bool flag4 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag4;
				val = (Enumerator<, >)0;
				cosmeticWearer = this;
				if (obj4 != null)
				{
					goto IL_0746;
				}
				bool flag5 = (object)array[5] == null;
				val = (Enumerator<, >)0;
				cosmeticWearer = this;
				if (!flag5)
				{
					Enumerator<, > enumerator = ((List<System.__Canon>)(object)array[5]).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
					object obj7 = 0;
					val2 = (Enumerator<, >)(ref val);
					Enumerator<, > val3 = default;
					object obj17;
					Enumerator<, > val4;
					Enumerator<, > val5;
					while (true)
					{
						if (val.MoveNext())
						{
							object obj8 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v49+E4]");
							bool flag6 = (nint)0 == 0;
							object obj9 = !flag6;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag7 = obj10 != null;
							bool flag8 = !flag7;
							nint num = unchecked((nint)null);
							if (flag8)
							{
								continue;
							}
							if ((object)obj10 != null)
							{
								bool activeSelf = ((GameObject)obj10).activeSelf;
								bool flag9 = !activeSelf;
								num = unchecked((nint)null);
								if (!flag9)
								{
									((GameObject)obj10).SetActive(false);
									List<System.__Canon> list = (List<System.__Canon>)(object)hiddenBack;
									bool flag10 = (object)hiddenBack == null;
									num = unchecked((nint)null);
									flag = false;
									if (flag10)
									{
										break;
									}
									System.__Canon[] items = list._items;
									val2 = (Enumerator<, >)obj7;
									int version = list._version + 1;
									list._version = version;
									bool flag11 = list._items == null;
									num = unchecked((nint)null);
									flag = false;
									if (flag11)
									{
										break;
									}
									version = list._size;
									bool flag12 = list._size < items.Length;
									object obj11 = !flag12;
									if (obj11 == null)
									{
										object obj12 = list._items + list._size;
										int num2 = ++list._size;
										object obj13 = obj12 + 32;
										obj13 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										num = unchecked((nint)null);
										val2 = (Enumerator<, >)num2;
									}
									else
									{
										System.__Canon _Canon = (System.__Canon)val2._current;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v36 (System.__Canon)+A8]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v37+70]");
										num = 0;
										((List<System.__Canon>)(object)hiddenBack).AddWithResize((System.__Canon)(object)obj10);
									}
								}
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							num = unchecked((nint)null);
							flag = false;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
						object obj15 = 0;
						flag = (byte)(int)obj15 != 0;
						val.Dispose();
						obj16 = null;
						obj17 = 0;
						val = val3;
						val4 = val3;
						val5 = (Enumerator<, >)(ref val);
						cosmeticWearer = null;
						throw new OutOfMemoryException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					obj18 = null;
					obj17 = 0;
					val = val3;
					val4 = val3;
					val5 = (Enumerator<, >)(ref val);
					goto IL_06fe;
				}
			}
		}
		else
		{
			List<System.__Canon> list2 = (List<System.__Canon>)(object)hiddenBack;
			bool flag13 = (object)hiddenBack == null;
			val = (Enumerator<, >)0;
			cosmeticWearer = this;
			if (!flag13)
			{
				if (list2._size == 0)
				{
					return;
				}
				Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)hiddenBack).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Enumerator<, > val6 = default;
				object obj17;
				Enumerator<, > val4;
				Enumerator<, > val5;
				Enumerator<, > val2;
				while (val.MoveNext())
				{
					object obj20 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v37+E4]");
					bool flag14 = (nint)0 == 0;
					object obj21 = !flag14;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag15 = obj10 != null;
					bool flag16 = !flag15;
					nint num = unchecked((nint)null);
					if (flag16)
					{
						continue;
					}
					bool flag17 = (object)obj10 == null;
					num = unchecked((nint)null);
					obj18 = null;
					obj17 = 0;
					val = val6;
					val4 = val6;
					val5 = (Enumerator<, >)(ref val);
					flag = false;
					val2 = (Enumerator<, >)(ref val);
					if (!flag17)
					{
						((GameObject)obj10).SetActive(true);
						num = unchecked((nint)null);
						continue;
					}
					goto IL_06fe;
				}
				obj16 = null;
				obj17 = 0;
				val = val6;
				val4 = val6;
				val5 = (Enumerator<, >)(ref val);
				val2 = (Enumerator<, >)(ref val);
				cosmeticWearer = this;
				object obj22 = 0;
				object obj23 = 9;
				object obj26 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
					object obj24 = 0;
					flag = (byte)(int)obj24 != 0;
					((Enumerator<, >*)val5)->Dispose();
					bool flag18 = obj22 == null;
					object obj25 = !flag18;
					if (obj25 != null)
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
						switch (flag)
						{
						case true:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj16 = (UnityEngine.Object)1;
							obj22 = obj17;
							break;
						case true:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj22 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj17 = obj26;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						obj23 = 0;
						continue;
					}
					break;
				}
				bool flag19 = (object)obj16 == null;
				object obj27 = !flag19;
				ex4 = (NullReferenceException)val5;
				if (obj27 != null)
				{
					goto IL_072f;
				}
				if ((nint)obj23 != 9)
				{
					bool flag20 = obj23 == null;
					object obj28 = !flag20;
					if (obj28 != null)
					{
						return;
					}
				}
				List<GameObject> list3 = cosmeticWearer.hiddenBack;
				bool flag21 = (object)cosmeticWearer.hiddenBack == null;
				obj10 = obj16;
				if (!flag21)
				{
					int version2 = list3._version + 1;
					list3._size = 0;
					list3._version = version2;
					if (list3._size >= 1)
					{
						Array.Clear(list3._items, 0, list3._size);
					}
					return;
				}
			}
		}
		goto IL_0719;
		IL_06fe:
		NullReferenceException ex5 = new NullReferenceException();
		obj10 = obj18;
		cosmeticWearer = this;
		goto IL_0719;
		IL_0746:
		obj16 = obj10;
		throw new IndexOutOfRangeException();
		IL_0719:
		ex4 = new NullReferenceException();
		obj16 = obj10;
		goto IL_072f;
		IL_072f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		obj10 = obj16;
		goto IL_0746;
	}

	public unsafe void Stainable(List<(string, Renderer, Mesh)> into)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0e46: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got I4
		//IL_0ef5: Expected Obj, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Expected Obj, but got I
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		//IL_02cd: Expected I, but got Obj
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected I, but got Obj
		//IL_0317: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_0390: Expected I, but got Obj
		//IL_03a3: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I4
		//IL_0ece: Expected Obj, but got I4
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_0471: Expected I, but got Obj
		//IL_0ae5: Expected Obj, but got I
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected I, but got Obj
		//IL_04c2: Expected I, but got Obj
		//IL_04e1: Expected Obj, but got I
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected I, but got Obj
		//IL_052d: Expected Obj, but got I4
		//IL_053a: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Expected I, but got Obj
		//IL_058a: Expected Obj, but got I
		//IL_05b5: Expected Obj, but got I4
		//IL_05c2: Expected I, but got Obj
		//IL_05e0: Expected Obj, but got I
		//IL_05e8: Expected I, but got Obj
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got Ref
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Ref
		//IL_0681: Expected Obj, but got I
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_070d: Expected Obj, but got I8
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Obj, but got I
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0785: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got I4
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_07fc: Expected Obj, but got I8
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got I
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_085a: Expected Obj, but got I
		//IL_087f: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected Obj, but got Unknown
		//IL_0904: Expected Obj, but got I
		//IL_0929: Expected Obj, but got I
		//IL_0939: Expected Obj, but got I
		//IL_094f: Expected Obj, but got I
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected I, but got Obj
		//IL_09ab: Expected Obj, but got I4
		//IL_0a67: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I
		//IL_0a94: Expected VT, but got Ref
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Ref
		//IL_09cf: Expected Obj, but got I
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected Obj, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected I, but got Obj
		bool flag = (object)into == null;
		List<(string, Renderer, Mesh)> list = into;
		Renderer renderer;
		Enumerator<, > val;
		Mesh sharedMesh;
		string text3;
		string text4;
		string text5;
		string text6;
		System.__Canon _Canon;
		nint num3;
		Enumerator<, > val5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+1C]");
			object obj2 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			list = into;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
				Array.Clear((Array)num, 0, 0);
				_Canon = null;
				list = null;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v11+10]");
			int num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v11+10]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
			num3 = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X10_v8 (System.Int32)+18]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X10_v8 (System.Int32)+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B20]");
				object obj9 = 0;
				int num4 = 0;
				renderer = null;
				val = (Enumerator<, >)0;
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
				num3 = 0;
				bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj11 = !flag5;
				if (obj11 != null)
				{
					goto IL_0de0;
				}
				List<GameObject>[] array = worn;
				if (worn != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v11+10]");
					object obj12 = 0 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X9_v8+20]");
					bool flag6 = (nint)0 < (nint)array.Length;
					object obj13 = !flag6;
					if (obj13 != null)
					{
						goto IL_0de0;
					}
					List<GameObject>[] array2 = worn;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X9_v8+20]");
					object obj14 = array2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17+20]");
						Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
						Enumerator<, > val3 = default;
						Enumerator<, > val2 = val3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X9_v8+20]");
						int num5 = 0;
						object obj19 = default;
						object obj32 = default;
						string[] array3 = default;
						Enumerator<, > val4 = default;
						while (val.MoveNext())
						{
							object obj15 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v28+E4]");
							bool flag7 = (nint)0 == 0;
							object obj16 = !flag7;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = (UnityEngine.Object)null == (UnityEngine.Object)null;
							bool flag9 = !flag8;
							object obj17 = !flag9;
							num3 = unchecked((nint)null);
							if (obj17 != null)
							{
								continue;
							}
							if (0 == 0)
							{
								goto IL_0c46;
							}
							bool activeInHierarchy = ((GameObject)null).activeInHierarchy;
							bool flag10 = !activeInHierarchy;
							num3 = unchecked((nint)null);
							if (flag10)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AF0]");
							object obj18 = 0;
							list = (List<(string, Renderer, Mesh)>)obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+18]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+18]");
								bool flag11 = (nint)0 < (nint)1;
								num3 = unchecked((nint)null);
								if (flag11)
								{
									continue;
								}
								num3 = unchecked((nint)null);
								object obj21 = 0;
								while (true)
								{
									bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
									object obj22 = !flag12;
									if (obj22 != null)
									{
										break;
									}
									object obj23 = obj19 + obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v33+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v33+20]");
										sharedMesh = ((MeshFilter)0).sharedMesh;
										object obj24 = obj8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X0_v43+E4]");
										bool flag13 = (nint)0 == 0;
										object obj25 = !flag13;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag14 = sharedMesh == null;
										bool flag15 = !flag14;
										object obj26 = !flag15;
										list = null;
										num3 = unchecked((nint)null);
										if (obj26 == null)
										{
											if ((object)sharedMesh == null)
											{
												goto IL_0bce;
											}
											bool isReadable = sharedMesh.isReadable;
											bool flag16 = !isReadable;
											list = null;
											num3 = unchecked((nint)null);
											if (!flag16)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v33+20]");
												string text = ((UnityEngine.Object)0).name;
												if (text == null)
												{
													goto IL_0bf6;
												}
												bool flag17 = text.StartsWith((string)obj9);
												bool flag18 = !flag17;
												object obj27 = !flag18;
												list = (List<(string, Renderer, Mesh)>)obj9;
												num3 = unchecked((nint)null);
												if (obj27 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v33+20]");
													string text2 = ((UnityEngine.Object)0).name;
													if (text2 == null)
													{
														goto IL_0c1e;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B10]");
													object obj28 = 0;
													bool flag19 = text2.StartsWith((string)obj28);
													bool flag20 = !flag19;
													object obj29 = !flag20;
													list = (List<(string, Renderer, Mesh)>)obj28;
													num3 = unchecked((nint)null);
													if (obj29 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AE8]");
														object obj30 = 0;
														num3 = (nint)obj30;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
														object obj31 = obj32 & 1;
														bool flag21 = obj31 == null;
														list = (List<(string, Renderer, Mesh)>)(&renderer);
														if (!flag21)
														{
															if ((object)renderer == null)
															{
																goto IL_0c91;
															}
															bool flag22 = renderer.enabled;
															bool flag23 = !flag22;
															list = null;
															if (!flag23)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
																object obj33 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																text3 = num4.ToString();
																if (array3 == null)
																{
																	goto IL_0d13;
																}
																if (array3.Length == 0)
																{
																	goto IL_0d39;
																}
																object obj34 = array3 + 32;
																obj34 = text3;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj35 = array3.Length & 0xFFFFFFFEL;
																if (obj35 == null)
																{
																	goto IL_0dab;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
																object obj36 = 0;
																object obj37 = array3 + 40;
																obj37 = obj36;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																text4 = ((UnityEngine.Object)null).name;
																bool flag24 = array3.Length < 2;
																object obj38 = !flag24;
																object obj39 = array3.Length - 2;
																bool flag25 = obj39 == null;
																object obj40 = ~obj38;
																object obj41 = obj40 | flag25;
																if (obj41 != null)
																{
																	goto IL_0d85;
																}
																object obj42 = array3 + 48;
																obj42 = text4;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj43 = array3.Length & 0xFFFFFFFCL;
																if (obj43 == null)
																{
																	goto IL_0cb7;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
																object obj44 = 0;
																object obj45 = array3 + 56;
																obj45 = obj44;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v33+20]");
																text5 = ((UnityEngine.Object)0).name;
																bool flag26 = array3.Length < 4;
																object obj46 = !flag26;
																object obj47 = array3.Length - 4;
																bool flag27 = obj47 == null;
																object obj48 = ~obj46;
																object obj49 = obj48 | flag27;
																if (obj49 != null)
																{
																	goto IL_0d5f;
																}
																object obj50 = array3 + 64;
																obj50 = text5;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																text6 = string.Concat(array3);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B08]");
																object obj51 = 0;
																(System.__Canon, System.__Canon, System.__Canon) tuple = ((System.__Canon)(object)text6, (System.__Canon)(object)renderer, (System.__Canon)(object)sharedMesh);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+10]");
																object obj52 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AF8]");
																object obj53 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+1C]");
																object obj54 = (nint)0 + (nint)1;
																object obj55 = obj53;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+10]");
																if ((nint)0 == 0)
																{
																	goto IL_0cdd;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
																nint num6 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v54+18]");
																bool flag28 = num6 < 0;
																object obj56 = !flag28;
																if (obj56 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
																	object obj57 = (nint)0 * (nint)24;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+10]");
																	object obj58 = 0 + obj57;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [into @ X1 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, UnityEngine.Renderer, UnityEngine.Mesh>>)+18]");
																	num5 = (int)((nint)0 + (nint)1);
																	_ = 0;
																	object obj59 = obj58 + 32;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X9_v8+20]");
																	num4 = 0;
																	val2 = (Enumerator<, >)tuple;
																	_Canon = (System.__Canon)(object)sharedMesh;
																	list = null;
																	num3 = (nint)renderer;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X9_v16+20]");
																	object obj60 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v55+A8]");
																	object obj61 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v56+70]");
																	num3 = 0;
																	((List<(System.__Canon, System.__Canon, System.__Canon)>)(object)into).AddWithResize(((System.__Canon, System.__Canon, System.__Canon))(&val4));
																	val4 = (Enumerator<, >)tuple;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X9_v8+20]");
																	num4 = 0;
																	val2 = (Enumerator<, >)tuple;
																	num5 = 0;
																	_Canon = (System.__Canon)(object)sharedMesh;
																	list = (List<(string, Renderer, Mesh)>)(&val4);
																}
															}
														}
													}
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+18]");
										obj20 = 0;
										obj21++;
										object obj62 = obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+18]");
										if ((nint)obj62 >= 0)
										{
											goto IL_0e8b;
										}
										continue;
									}
									goto IL_0b92;
								}
								goto IL_0bb0;
							}
							goto IL_0c6e;
							IL_0e8b:;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
						object obj63 = 0;
						list = (List<(string, Renderer, Mesh)>)obj63;
						val.Dispose();
						val5 = (Enumerator<, >)(ref val);
						goto IL_0dfd;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0de0;
		IL_0bf6:
		NullReferenceException ex2 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = null;
		num3 = unchecked((nint)null);
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		goto IL_0f03;
		IL_0d39:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text3;
		ex3 = (OutOfMemoryException)(object)ex4;
		goto IL_0f03;
		IL_0c46:
		NullReferenceException ex5 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = null;
		num3 = unchecked((nint)null);
		ex3 = (OutOfMemoryException)(object)ex5;
		goto IL_0f03;
		IL_0c6e:
		NullReferenceException ex6 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		num3 = unchecked((nint)null);
		ex3 = (OutOfMemoryException)(object)ex6;
		goto IL_0f03;
		IL_0cdd:
		NullReferenceException ex7 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		_Canon = (System.__Canon)(object)sharedMesh;
		list = (List<(string, Renderer, Mesh)>)(object)text6;
		num3 = (nint)renderer;
		ex3 = (OutOfMemoryException)(object)ex7;
		goto IL_0f03;
		IL_0bce:
		NullReferenceException ex8 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = null;
		num3 = unchecked((nint)null);
		ex3 = (OutOfMemoryException)(object)ex8;
		goto IL_0f03;
		IL_0f03:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0c91:
		NullReferenceException ex9 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(&renderer);
		ex3 = (OutOfMemoryException)(object)ex9;
		goto IL_0f03;
		IL_0bb0:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		ex3 = (OutOfMemoryException)(object)ex10;
		goto IL_0f03;
		IL_0cb7:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text4;
		ex3 = (OutOfMemoryException)(object)ex11;
		goto IL_0f03;
		IL_0d5f:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text5;
		ex3 = (OutOfMemoryException)(object)ex12;
		goto IL_0f03;
		IL_0de0:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0dfd;
		IL_0b92:
		NullReferenceException ex14 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		ex3 = (OutOfMemoryException)(object)ex14;
		goto IL_0f03;
		IL_0d85:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text4;
		ex3 = (OutOfMemoryException)(object)ex15;
		goto IL_0f03;
		IL_0d13:
		NullReferenceException ex16 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text3;
		ex3 = (OutOfMemoryException)(object)ex16;
		goto IL_0f03;
		IL_0dfd:
		ex3 = new OutOfMemoryException();
		goto IL_0f03;
		IL_0c1e:
		NullReferenceException ex17 = new NullReferenceException();
		val5 = (Enumerator<, >)(ref val);
		list = null;
		num3 = unchecked((nint)null);
		ex3 = (OutOfMemoryException)(object)ex17;
		goto IL_0f03;
		IL_0dab:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		val5 = (Enumerator<, >)(ref val);
		list = (List<(string, Renderer, Mesh)>)(object)text3;
		ex3 = (OutOfMemoryException)(object)ex18;
		goto IL_0f03;
	}

	private static void Gone(GameObject go)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj5 = obj3;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(go);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(go);
		}
	}

	private void Attach(GameObject go, Transform bone)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0121: Expected VT, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_01a0: Expected VT, but got I4
		//IL_01c5: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
		object obj4 = 0;
		if (bone == null)
		{
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Gone(go);
			return;
		}
		Transform transform = go.transform;
		transform.SetParent(bone, worldPositionStays: false);
		Transform transform2 = go.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7+A0]");
		object obj9 = 0;
		transform2.localPosition = (Vector3)0;
		Transform transform3 = go.transform;
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Quaternion quaternion = OnBone(skin, bone);
		transform3.localRotation = (Quaternion)0;
		Transform transform4 = go.transform;
		transform4.localScale = (Vector3)0;
		GameObject gameObject = skin.gameObject;
		int layer = gameObject.layer;
		Layer(go, layer);
	}

	private unsafe void Skin(CosmeticCatalog.Entry e)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_3270: Unknown result type (might be due to invalid IL or missing references)
		//IL_327f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3283: Unknown result type (might be due to invalid IL or missing references)
		//IL_3287: Unknown result type (might be due to invalid IL or missing references)
		//IL_3295: Expected VT, but got I4
		//IL_329e: Expected VT, but got I4
		//IL_32ae: Expected Obj, but got Ref
		//IL_001e: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I, but got Unknown
		//IL_3770: Unknown result type (might be due to invalid IL or missing references)
		//IL_377f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3788: Unknown result type (might be due to invalid IL or missing references)
		//IL_379d: Expected VT, but got I4
		//IL_37a5: Expected VT, but got Ref
		//IL_37a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_37bd: Expected VT, but got Ref
		//IL_00d9: Expected Obj, but got I4
		//IL_0118: Expected I, but got Obj
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected I, but got Obj
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected VT, but got I4
		//IL_0175: Expected VT, but got Ref
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected VT, but got Ref
		//IL_01bf: Expected I, but got Obj
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = default;
		UnityEngine.Object obj = (UnityEngine.Object)(&enumerator);
		obj.m_CachedPtr = (IntPtr)0;
		bool flag = (object)beforeSkin == null;
		Enumerator<, > val = (Enumerator<, >)0;
		IEnumerator enumerator2 = null;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		UnityEngine.Object obj2 = (UnityEngine.Object)(object)e;
		UnityEngine.Object obj3 = (UnityEngine.Object)(&enumerator);
		CosmeticWearer cosmeticWearer = this;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A98]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A90]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A80]");
			Enumerator<, > val5 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D0]");
			UnityEngine.Object obj7 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49C0]");
			UnityEngine.Object obj8 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			UnityEngine.Object obj9 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49B8]");
			object obj10 = 0;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4 = ((Dictionary<System.__Canon, System.__Canon>)(object)beforeSkin).GetEnumerator();
			obj.m_CachedPtr = (IntPtr)val4;
			UnityEngine.Object obj13 = default;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5 = default;
			Material[] sharedMaterials = default;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator6;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator7;
			Enumerator<, > val6;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator8;
			while (enumerator.MoveNext())
			{
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v317+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj13 != null;
				bool flag4 = !flag3;
				nint num = unchecked((nint)null);
				if (!flag4)
				{
					bool flag5 = (object)obj13 == null;
					val = (Enumerator<, >)0;
					enumerator2 = null;
					val2 = (Enumerator<, >)0;
					num = unchecked((nint)null);
					val3 = (Enumerator<, >)0;
					enumerator = enumerator5;
					enumerator6 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
					enumerator7 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
					val6 = val4;
					enumerator3 = enumerator5;
					enumerator8 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
					obj2 = null;
					obj3 = obj13;
					cosmeticWearer = this;
					if (flag5)
					{
						NullReferenceException ex = new NullReferenceException();
						NullReferenceException ex2 = new NullReferenceException();
						throw new NullReferenceException();
					}
					((Renderer)obj13).sharedMaterials = sharedMaterials;
					num = unchecked((nint)null);
				}
			}
			obj2 = (UnityEngine.Object)obj6;
			enumerator.Dispose();
			val = (Enumerator<, >)0;
			enumerator2 = null;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			enumerator = enumerator5;
			enumerator6 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			enumerator7 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
			val6 = val4;
			enumerator3 = enumerator5;
			enumerator8 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
			obj3 = null;
			cosmeticWearer = this;
			OutOfMemoryException ex3 = new OutOfMemoryException();
			NullReferenceException ex4 = new NullReferenceException();
			NullReferenceException ex5 = new NullReferenceException();
			NullReferenceException ex6 = new NullReferenceException();
			NullReferenceException ex7 = new NullReferenceException();
			IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
			IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
			OutOfMemoryException ex10 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			obj2 = null;
			throw new ArgumentNullException();
		}
		NullReferenceException ex11 = new NullReferenceException();
		NullReferenceException ex12 = new NullReferenceException();
		NullReferenceException ex13 = new NullReferenceException();
		NullReferenceException ex14 = new NullReferenceException();
		NullReferenceException ex15 = new NullReferenceException();
		NullReferenceException ex16 = new NullReferenceException();
		NullReferenceException ex17 = new NullReferenceException();
		NullReferenceException ex18 = new NullReferenceException();
		NullReferenceException ex19 = new NullReferenceException();
		NullReferenceException ex20 = new NullReferenceException();
		NullReferenceException ex21 = new NullReferenceException();
		NullReferenceException ex22 = new NullReferenceException();
		NullReferenceException ex23 = new NullReferenceException();
		NullReferenceException ex24 = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void WearSuit(CosmeticSkin info)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1114: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected I4, but got Unknown
		//IL_0c79: Expected Obj, but got I
		//IL_0ca3: Expected Obj, but got I4
		//IL_11e1: Expected Obj, but got I
		//IL_11f1: Expected Obj, but got I
		//IL_1213: Expected Obj, but got I4
		//IL_0d37: Expected I, but got Obj
		//IL_0d57: Expected Obj, but got I4
		//IL_0cfa: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected I4, but got Unknown
		//IL_1231: Expected Obj, but got I
		//IL_124b: Expected Obj, but got I
		//IL_125c: Expected I, but got Obj
		//IL_127a: Expected Obj, but got I
		//IL_0d2a: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I4
		//IL_0dcc: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_0dfb: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I4
		//IL_053d: Expected I, but got Obj
		//IL_0448: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_0473: Expected I, but got Obj
		//IL_0bd0: Expected Obj, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0e46: Expected Obj, but got I4
		//IL_0584: Expected I, but got Obj
		//IL_05af: Expected Obj, but got I
		//IL_05e3: Expected I, but got Obj
		//IL_0eaa: Expected I, but got Obj
		//IL_060e: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected I4, but got Unknown
		//IL_06b9: Expected I, but got Obj
		//IL_0ed5: Expected Obj, but got I
		//IL_0efb: Expected I, but got Obj
		//IL_0f04: Expected Obj, but got I4
		//IL_06ee: Expected Obj, but got I
		//IL_0720: Expected Obj, but got I4
		//IL_0f2e: Expected I, but got Obj
		//IL_0f37: Expected Obj, but got I4
		//IL_074f: Expected Obj, but got I
		//IL_076d: Expected Obj, but got I4
		//IL_0772: Expected I, but got Obj
		//IL_07b1: Expected I, but got Obj
		//IL_07e9: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I4
		//IL_0833: Expected I, but got Obj
		//IL_1011: Expected Obj, but got I
		//IL_1089: Expected I, but got Obj
		//IL_0861: Expected Obj, but got I
		//IL_0895: Expected I, but got Obj
		//IL_1046: Expected I, but got Obj
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_08d0: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got I
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected I4, but got Unknown
		//IL_097b: Expected I, but got Obj
		//IL_12ae: Expected Obj, but got I
		//IL_12e0: Expected Obj, but got I
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected Obj, but got Unknown
		//IL_09ab: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I
		//IL_09cb: Expected Obj, but got I
		//IL_0a01: Expected I, but got Obj
		//IL_0a0a: Expected Obj, but got I4
		//IL_0a44: Expected I, but got Obj
		//IL_0a4d: Expected Obj, but got I4
		//IL_0a73: Expected Obj, but got I
		//IL_0a93: Expected Obj, but got I4
		//IL_0b0b: Expected I, but got Obj
		//IL_0aa9: Expected I, but got Obj
		//IL_0ab9: Expected Obj, but got I
		//IL_0ad7: Expected I, but got Obj
		//IL_0ae7: Expected Obj, but got I
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected Obj, but got Unknown
		//IL_0b77: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B48]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass74_0 obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		CosmeticSkin cosmeticSkin = null;
		CosmeticSkin cosmeticSkin2 = info;
		object obj3 = 109891584;
		if (!flag)
		{
			obj3 = obj2 + 16;
			obj3 = info;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj3;
			bool flag2 = obj3 == null;
			cosmeticSkin = info;
			cosmeticSkin2 = info;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v29+48]");
				int num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v29+48]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v29+50]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
				CosmeticSkin info2 = obj2.info;
				obj2.i = 0;
				bool flag3 = (object)obj2.info == null;
				cosmeticSkin = (CosmeticSkin)1;
				cosmeticSkin2 = info;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B50]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj7 = 0;
					Material[] array2 = default;
					Material[] array = array2;
					object obj9 = default;
					object obj8 = obj9;
					Mesh mesh2 = default;
					Mesh mesh = mesh2;
					Mesh mesh4 = default;
					Mesh mesh3 = mesh4;
					bool flag5 = default;
					bool flag4 = flag5;
					bool flag7 = default;
					bool flag6 = flag7;
					int num4 = default;
					int num3 = num4;
					int num6 = default;
					int num5 = num6;
					int num8 = default;
					int num7 = num8;
					bool flag9 = default;
					bool flag8 = flag9;
					bool flag11 = default;
					bool flag10 = flag11;
					object obj11 = default;
					object obj10 = obj11;
					object obj13 = default;
					object obj12 = obj13;
					nint num9 = (nint)obj5;
					int num10 = 0;
					CosmeticSkin cosmeticSkin3 = (CosmeticSkin)1;
					CosmeticSkin cosmeticSkin4 = default;
					Predicate<System.__Canon> predicate2 = default;
					UnityEngine.Object obj20 = default;
					Material[] array3 = default;
					IndexOutOfRangeException ex = default;
					Predicate<System.__Canon> predicate3 = default;
					CosmeticSkin cosmeticSkin6 = default;
					Material[] array4 = default;
					object obj62;
					do
					{
						Mesh[] suitMeshes = info2.suitMeshes;
						bool flag12 = info2.suitMeshes == null;
						array2 = array;
						mesh2 = mesh;
						mesh4 = mesh3;
						flag5 = flag4;
						flag7 = flag6;
						num4 = num3;
						num6 = num5;
						num8 = num7;
						flag9 = flag8;
						flag11 = flag10;
						obj11 = obj10;
						obj13 = obj12;
						num2 = num9;
						num = num10;
						cosmeticSkin = cosmeticSkin3;
						cosmeticSkin2 = cosmeticSkin4;
						if (flag12)
						{
							break;
						}
						suitMeshes = (Mesh[])suitMeshes.Length;
						bool flag13 = num10 < suitMeshes.Length;
						obj13 = !flag13;
						obj11 = num10 - suitMeshes.Length;
						flag11 = (nint)obj11 < 0;
						flag9 = obj11 == null;
						num8 = num10 ^ suitMeshes.Length;
						num6 = num10 ^ obj11;
						num4 = num8 & num6;
						flag7 = num4 < 0;
						flag5 = num10 >= suitMeshes.Length;
						array2 = array;
						mesh2 = mesh;
						mesh4 = mesh3;
						num2 = num9;
						num = num10;
						cosmeticSkin = cosmeticSkin3;
						cosmeticSkin2 = cosmeticSkin4;
						if (!flag5)
						{
							string[] suitPieces = info2.suitPieces;
							bool flag14 = info2.suitPieces == null;
							array2 = array;
							mesh2 = mesh;
							mesh4 = mesh3;
							num2 = num9;
							num = num10;
							cosmeticSkin = cosmeticSkin3;
							cosmeticSkin2 = cosmeticSkin4;
							if (flag14)
							{
								break;
							}
							bool flag15 = num10 < suitPieces.Length;
							obj13 = !flag15;
							obj11 = num10 - suitPieces.Length;
							flag11 = (nint)obj11 < 0;
							flag9 = obj11 == null;
							num8 = num10 ^ suitPieces.Length;
							num6 = num10 ^ obj11;
							num4 = num8 & num6;
							flag7 = num4 < 0;
							flag5 = num10 >= suitPieces.Length;
							array2 = array;
							mesh2 = mesh;
							mesh4 = mesh3;
							num2 = num9;
							num = num10;
							cosmeticSkin = cosmeticSkin3;
							cosmeticSkin2 = cosmeticSkin4;
							if (!flag5)
							{
								Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)obj2._003C_003E9__1;
								bool flag16 = obj2._003C_003E9__1 == null;
								object obj14 = !flag16;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B60]");
									object obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B70]");
									object obj16 = 0;
									predicate2._002Ector((object)obj2, (IntPtr)obj16);
									object obj17 = obj2 + 32;
									obj2._003C_003E9__1 = (Predicate<SkinnedMeshRenderer>)predicate2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									mesh3 = null;
									predicate = predicate2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37ACF48");
								object obj18 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v38+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v38+E4]");
								bool flag17 = (nint)0 == 0;
								object obj19 = !flag17;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag18 = obj20 == null;
								bool flag19 = !flag18;
								object obj21 = !flag19;
								num2 = unchecked((nint)null);
								cosmeticSkin = null;
								if (obj21 != null)
								{
									goto IL_0b84;
								}
								object obj22 = obj3;
								bool flag20 = obj3 == null;
								array2 = array;
								mesh2 = mesh;
								mesh4 = mesh3;
								num2 = unchecked((nint)null);
								cosmeticSkin = null;
								cosmeticSkin2 = cosmeticSkin4;
								if (flag20)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v41+48]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v41+48]");
								bool flag21 = (nint)0 == 0;
								array2 = array;
								mesh2 = mesh;
								mesh4 = mesh3;
								num2 = unchecked((nint)null);
								cosmeticSkin = null;
								cosmeticSkin2 = cosmeticSkin4;
								if (flag21)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v42+18]");
								suitMeshes = (Mesh[])0;
								int i = obj2.i;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v42+18]");
								bool flag22 = (nint)i < (nint)0;
								obj13 = !flag22;
								int i2 = obj2.i;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v42+18]");
								obj11 = (nint)i2 - (nint)0;
								flag11 = (nint)obj11 < 0;
								flag9 = obj11 == null;
								int i3 = obj2.i;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v42+18]");
								num8 = (int)((nint)i3 ^ (nint)0);
								num6 = obj2.i ^ obj11;
								num4 = num8 & num6;
								flag7 = num4 < 0;
								nint num11 = unchecked((nint)null);
								UnityEngine.Object obj24 = null;
								if (obj13 == null)
								{
									object obj25 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v41+48]");
									object obj26 = (nint)0 + (nint)obj2.i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v65+E4]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v65+E4]");
									bool flag23 = (nint)0 == 0;
									object obj27 = !flag23;
									if (obj27 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v45+20]");
									bool flag24 = (UnityEngine.Object)0 == null;
									bool flag25 = !flag24;
									object obj28 = !flag25;
									num2 = unchecked((nint)null);
									cosmeticSkin = null;
									if (obj28 != null)
									{
										goto IL_0b84;
									}
									bool flag26 = (object)obj20 == null;
									array2 = array;
									mesh2 = mesh;
									mesh4 = mesh3;
									num2 = unchecked((nint)null);
									cosmeticSkin = null;
									cosmeticSkin2 = cosmeticSkin4;
									if (flag26)
									{
										break;
									}
									string text = obj20.name;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B88]");
									object obj29 = 0;
									string text2 = (string)obj29 + text;
									object obj30 = obj3;
									bool flag27 = obj3 == null;
									array2 = array;
									mesh2 = mesh;
									mesh4 = mesh3;
									num2 = unchecked((nint)null);
									cosmeticSkin = (CosmeticSkin)(object)text;
									cosmeticSkin2 = cosmeticSkin4;
									if (flag27)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v49+48]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v49+48]");
									bool flag28 = (nint)0 == 0;
									array2 = array;
									mesh2 = mesh;
									mesh4 = mesh3;
									num2 = unchecked((nint)null);
									cosmeticSkin = (CosmeticSkin)(object)text;
									cosmeticSkin2 = cosmeticSkin4;
									if (flag28)
									{
										break;
									}
									num = obj2.i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v50+18]");
									suitMeshes = (Mesh[])0;
									int i4 = obj2.i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v50+18]");
									bool flag29 = (nint)i4 < (nint)0;
									obj13 = !flag29;
									int i5 = obj2.i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v50+18]");
									obj11 = (nint)i5 - (nint)0;
									flag11 = (nint)obj11 < 0;
									flag9 = obj11 == null;
									int i6 = obj2.i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v50+18]");
									num8 = (int)((nint)i6 ^ (nint)0);
									num6 = obj2.i ^ obj11;
									num4 = num8 & num6;
									flag7 = num4 < 0;
									num11 = unchecked((nint)null);
									obj24 = (UnityEngine.Object)(object)text;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v49+48]");
										object obj32 = (nint)0 + (nint)obj2.i;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v51+20]");
										mesh2 = (Mesh)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
										object obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj34 = obj3;
										bool flag30 = obj3 == null;
										array2 = array;
										mesh4 = mesh3;
										num2 = unchecked((nint)null);
										cosmeticSkin = (CosmeticSkin)1;
										cosmeticSkin2 = cosmeticSkin4;
										if (flag30)
										{
											break;
										}
										bool flag31 = array3 == null;
										array2 = array;
										mesh4 = mesh3;
										num2 = unchecked((nint)null);
										cosmeticSkin = (CosmeticSkin)1;
										cosmeticSkin2 = cosmeticSkin4;
										if (flag31)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v54+58]");
										obj8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v54+58]");
										bool flag32 = (nint)0 == 0;
										UnityEngine.Object obj35 = (UnityEngine.Object)1;
										if (!flag32)
										{
											nint num12 = (nint)array3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v57 (Il2CppClass<UnityEngine.Material[]>)+40]");
											obj35 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag33 = ex == null;
											num11 = unchecked((nint)null);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v57 (Il2CppClass<UnityEngine.Material[]>)+40]");
											obj24 = (UnityEngine.Object)0;
											if (flag33)
											{
												goto IL_10c6;
											}
										}
										bool flag34 = array3.Length == 0;
										num11 = unchecked((nint)null);
										obj24 = obj35;
										if (!flag34)
										{
											object obj36 = array3 + 32;
											obj36 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Over((SkinnedMeshRenderer)obj20, text2, mesh2, array3);
											array = array3;
											mesh = mesh2;
											mesh3 = mesh2;
											num2 = (nint)text2;
											cosmeticSkin = (CosmeticSkin)obj20;
											goto IL_0b84;
										}
									}
								}
								ex = new IndexOutOfRangeException();
								goto IL_10c6;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B78]");
						object obj37 = 0;
						object obj38 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v7+E4]");
						bool flag35 = (nint)0 == 0;
						object obj39 = !flag35;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj38 = obj37;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v7+A0]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v20+8]");
						CosmeticSkin cosmeticSkin5 = (CosmeticSkin)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v20+8]");
						bool flag36 = (nint)0 == 0;
						object obj41 = !flag36;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v7+E4]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v7+E4]");
							bool flag37 = (nint)0 == 0;
							object obj42 = !flag37;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj43 = obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v26+A0]");
								obj40 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B60]");
							object obj44 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B68]");
							object obj45 = 0;
							predicate3._002Ector(obj40, (IntPtr)obj45);
							object obj46 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v25+A0]");
							object obj47 = (nint)0 + (nint)8;
							obj47 = predicate3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							mesh4 = null;
							cosmeticSkin5 = (CosmeticSkin)(object)predicate3;
						}
						num2 = (nint)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37ACF48");
						bool flag38 = (byte)(~(skinOnly ? 1u : 0u)) != 0;
						object obj48 = !flag38;
						if (obj48 != null)
						{
							return;
						}
						object obj49 = obj3;
						bool flag39 = obj3 == null;
						cosmeticSkin = cosmeticSkin5;
						if (flag39)
						{
							break;
						}
						object obj50 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v11+E4]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v11+E4]");
						bool flag40 = (nint)0 == 0;
						object obj51 = !flag40;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v9+60]");
						if (!((UnityEngine.Object)0 != null))
						{
							return;
						}
						object obj52 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v15+E4]");
						bool flag41 = (nint)0 == 0;
						object obj53 = !flag41;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(cosmeticSkin6 != null))
						{
							return;
						}
						object obj54 = obj3;
						bool flag42 = obj3 == null;
						num2 = unchecked((nint)null);
						cosmeticSkin = null;
						cosmeticSkin2 = cosmeticSkin6;
						if (flag42)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
						object obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj56 = obj3;
						bool flag43 = obj3 == null;
						num2 = unchecked((nint)null);
						cosmeticSkin = (CosmeticSkin)2;
						cosmeticSkin2 = cosmeticSkin6;
						if (flag43)
						{
							break;
						}
						bool flag44 = array4 == null;
						num2 = unchecked((nint)null);
						cosmeticSkin = (CosmeticSkin)2;
						cosmeticSkin2 = cosmeticSkin6;
						if (flag44)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						object obj57 = obj3;
						bool flag45 = obj3 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v14+58]");
						num2 = 0;
						cosmeticSkin = null;
						cosmeticSkin2 = cosmeticSkin6;
						if (flag45)
						{
							break;
						}
						object obj58 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v25+E4]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v25+E4]");
						bool flag46 = (nint)0 == 0;
						object obj59 = !flag46;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15+68]");
						if ((UnityEngine.Object)0 != null)
						{
							bool flag47 = obj3 == null;
							num2 = unchecked((nint)null);
							cosmeticSkin = null;
							cosmeticSkin2 = cosmeticSkin6;
							if (flag47)
							{
								break;
							}
							object obj60 = obj3 + 104;
						}
						else
						{
							bool flag48 = obj3 == null;
							num2 = unchecked((nint)null);
							cosmeticSkin = null;
							cosmeticSkin2 = cosmeticSkin6;
							if (flag48)
							{
								break;
							}
							object obj60 = obj3 + 88;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B80]");
						object obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v11+60]");
						Over((SkinnedMeshRenderer)(object)cosmeticSkin6, (string)obj61, (Mesh)0, array4);
						return;
						IL_0b84:
						info2 = obj2.info;
						num = ++obj2.i;
						bool flag49 = (object)obj2.info == null;
						obj62 = !flag49;
						array2 = array;
						mesh2 = mesh;
						mesh4 = mesh3;
						cosmeticSkin2 = cosmeticSkin4;
						flag4 = flag5;
						flag6 = flag7;
						num3 = num4;
						num5 = num6;
						num7 = num8;
						flag8 = flag9;
						flag10 = flag11;
						obj10 = obj11;
						obj12 = obj13;
						num9 = num2;
						num10 = num;
						cosmeticSkin3 = cosmeticSkin;
						continue;
						IL_10c6:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						throw new ArgumentNullException();
					}
					while (obj62 != null);
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void Over(SkinnedMeshRenderer under, string name, Mesh mesh, Material[] materials)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0119: Expected VT, but got I4
		//IL_018d: Expected VT, but got I4
		//IL_0201: Expected VT, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_0300: Expected VT, but got Ref
		//IL_03ff: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I
		//IL_0532: Expected VT, but got I4
		//IL_04ab: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I4
		//IL_058c: Expected Obj, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_0669: Expected Obj, but got I4
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)under != null)
			{
				Transform transform2 = under.transform;
				if ((object)transform2 != null)
				{
					Transform parent = transform2.parent;
					if ((object)transform != null)
					{
						transform.SetParent(parent, worldPositionStays: false);
						Transform transform3 = gameObject.transform;
						Transform transform4 = under.transform;
						if ((object)transform4 != null)
						{
							Vector3 localPosition = transform4.localPosition;
							if ((object)transform3 != null)
							{
								transform3.localPosition = (Vector3)0;
								Transform transform5 = gameObject.transform;
								Transform transform6 = under.transform;
								if ((object)transform6 != null)
								{
									Quaternion localRotation = transform6.localRotation;
									if ((object)transform5 != null)
									{
										transform5.localRotation = (Quaternion)0;
										Transform transform7 = gameObject.transform;
										Transform transform8 = under.transform;
										if ((object)transform8 != null)
										{
											Vector3 localScale = transform8.localScale;
											if ((object)transform7 != null)
											{
												transform7.localScale = (Vector3)0;
												GameObject gameObject2 = under.gameObject;
												if ((object)gameObject2 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
													object obj2 = 0;
													int layer = gameObject2.layer;
													gameObject.layer = layer;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
													SkinnedMeshRenderer skinnedMeshRenderer = default;
													if ((object)skinnedMeshRenderer != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BA0]");
														object obj3 = 0;
														skinnedMeshRenderer.sharedMesh = mesh;
														Transform[] bones = under.bones;
														skinnedMeshRenderer.bones = bones;
														Transform rootBone = under.rootBone;
														skinnedMeshRenderer.rootBone = rootBone;
														Bounds localBounds = under.localBounds;
														object obj4 = default;
														skinnedMeshRenderer.localBounds = (Bounds)(&obj4);
														skinnedMeshRenderer.sharedMaterials = materials;
														ShadowCastingMode shadowCastingMode = under.shadowCastingMode;
														skinnedMeshRenderer.shadowCastingMode = shadowCastingMode;
														bool updateWhenOffscreen = under.updateWhenOffscreen;
														skinnedMeshRenderer.updateWhenOffscreen = updateWhenOffscreen;
														SkinQuality quality = under.quality;
														skinnedMeshRenderer.quality = quality;
														bool skinnedMotionVectors = under.skinnedMotionVectors;
														skinnedMeshRenderer.skinnedMotionVectors = skinnedMotionVectors;
														bool flag = under.enabled;
														skinnedMeshRenderer.enabled = flag;
														object obj5 = obj3;
														List<(System.__Canon, System.__Canon)> list = (List<(System.__Canon, System.__Canon)>)(object)suits;
														(System.__Canon, System.__Canon) tuple = ((System.__Canon)(object)skinnedMeshRenderer, (System.__Canon)(object)under);
														if ((object)suits != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B98]");
															object obj6 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
															object obj7 = 0;
															object obj8 = obj6;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+1C]");
															object obj9 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
																nint num = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v7+18]");
																bool flag2 = num < 0;
																object obj10 = !flag2;
																if (obj10 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+10]");
																	nint num2 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
																	object obj11 = num2 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X22_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>)+18]");
																	object obj12 = (nint)0 + (nint)1;
																	object obj13 = obj11 + 32;
																	obj13 = 0;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v5+20]");
																	object obj14 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v16+A8]");
																	object obj15 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v17+70]");
																	obj5 = 0;
																	((List<(System.__Canon, System.__Canon)>)(object)suits).AddWithResize(((System.__Canon, System.__Canon))0);
																}
																List<GameObject>[] array = worn;
																if (worn != null)
																{
																	bool flag3 = array.Length < 6;
																	object obj16 = !flag3;
																	object obj17 = array.Length - 6;
																	bool flag4 = obj17 == null;
																	object obj18 = ~obj16;
																	object obj19 = obj18 | flag4;
																	if (obj19 != null)
																	{
																		goto IL_0700;
																	}
																	List<System.__Canon> list2 = (List<System.__Canon>)(object)array[6];
																	if ((object)array[6] != null)
																	{
																		System.__Canon[] items = list2._items;
																		int version = list2._version + 1;
																		list2._version = version;
																		if (list2._items != null)
																		{
																			bool flag5 = list2._size < items.Length;
																			object obj20 = !flag5;
																			if (obj20 == null)
																			{
																				object obj21 = list2._items + list2._size;
																				int size = list2._size + 1;
																				list2._size = size;
																				object obj22 = obj21 + 32;
																				obj22 = gameObject;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			}
																			else
																			{
																				((List<System.__Canon>)(object)array[6]).AddWithResize((System.__Canon)(object)gameObject);
																			}
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
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0700;
		IL_0700:
		throw new IndexOutOfRangeException();
	}

	private Material Unwounded(Material m)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body != null;
		bool flag3 = !flag2;
		Material result = m;
		if (!flag3)
		{
			if ((object)body == null)
			{
				goto IL_0100;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BA8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj6 = default;
			object obj5 = obj6 & 1;
			bool flag4 = obj5 == null;
			result = m;
			if (!flag4)
			{
				GillaWounds gillaWounds = default;
				if ((object)gillaWounds == null)
				{
					goto IL_0100;
				}
				Material material = gillaWounds.Unwounded(m);
				result = material;
			}
		}
		return result;
		IL_0100:
		return (Material)(object)new NullReferenceException();
	}

	private unsafe void KeepSkin()
	{
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected Obj, but got I4
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected Obj, but got I4
		//IL_0e74: Expected Obj, but got I
		//IL_0e7c: Expected I, but got Obj
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected Ref, but got Unknown
		//IL_0e9f: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Invalid comparison between Unknown and I4
		//IL_0be2: Expected Obj, but got I4
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0c54: Expected I, but got Obj
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected Obj, but got I4
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I4
		//IL_02ba: Expected I, but got Obj
		//IL_0300: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_08a3: Expected Obj, but got I
		//IL_08bd: Expected Obj, but got I
		//IL_08cb: Expected I, but got Obj
		//IL_08e0: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I4
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected Obj, but got I4
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_097d: Expected Obj, but got I
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected I, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got I4
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got I4
		//IL_0570: Expected I, but got Obj
		//IL_0aeb: Expected Obj, but got I4
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got I4
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected I, but got Obj
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got I4
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got I4
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected Obj, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		//IL_0b70: Expected VT, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_063c: Expected Obj, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got I4
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got I4
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got I4
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got I4
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected I, but got Obj
		//IL_0750: Expected Obj, but got I
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected Obj, but got I4
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got I
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_0884: Expected I, but got Obj
		bool flag = (object)furSlots == null;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val4 = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49C0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Enumerator<, > enumerator = ((List<(System.__Canon, int)>)(object)furSlots).GetEnumerator();
			object obj7 = default;
			Enumerator<, > val5 = default;
			Converter<System.__Canon, System.__Canon> converter2 = default;
			NullReferenceException ex = default;
			UnityEngine.Object obj10 = default;
			NullReferenceException ex2 = default;
			object obj17;
			Enumerator<, > val6;
			Enumerator<, > val7;
			while (true)
			{
				UnityEngine.Object obj6;
				Converter<System.__Canon, System.__Canon> converter;
				System.__Canon _Canon;
				nint num;
				System.__Canon _Canon2;
				if (val.MoveNext())
				{
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v53+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = (UnityEngine.Object)val3 == null;
					bool flag4 = !flag3;
					object obj5 = !flag4;
					_Canon = null;
					if (obj5 != null)
					{
						continue;
					}
					if ((object)look != null)
					{
						bool flag5 = look.Covers((Renderer)val3);
						bool flag6 = !flag5;
						_Canon = null;
						if (flag6)
						{
							continue;
						}
						bool flag7 = (int)val3 == 0;
						obj6 = (UnityEngine.Object)val3;
						if (!flag7)
						{
							Material[] sharedMaterials = ((Renderer)val3).sharedMaterials;
							bool flag8 = sharedMaterials == null;
							obj6 = null;
							if (flag8)
							{
								goto IL_0c22;
							}
							bool flag9 = sharedMaterials.Length <= (nint)obj7;
							_Canon = null;
							if (flag9)
							{
								continue;
							}
							bool flag10 = (nint)obj7 < sharedMaterials.Length;
							object obj8 = !flag10;
							obj6 = null;
							if (obj8 != null)
							{
								goto IL_0c30;
							}
							CosmeticSkin cosmeticSkin = look;
							bool flag11 = (object)look == null;
							obj6 = null;
							if (flag11)
							{
								goto IL_0c3e;
							}
							object obj9 = obj2;
							obj10 = cosmeticSkin.body;
							object obj11 = (object)sharedMaterials + obj7;
							object obj12 = obj11 + 32;
							UnityEngine.Object obj13 = (UnityEngine.Object)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v72+E4]");
							bool flag12 = (nint)0 == 0;
							object obj14 = !flag12;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag13 = obj13 != obj10;
							bool flag14 = !flag13;
							_Canon = null;
							if (flag14)
							{
								continue;
							}
							CosmeticSkin cosmeticSkin2 = look;
							bool flag15 = (object)look == null;
							_Canon = null;
							num = (nint)obj10;
							if (flag15)
							{
								break;
							}
							object obj15 = obj2;
							obj13 = cosmeticSkin2.body;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ X0_v76+E4]");
							bool flag16 = (nint)0 == 0;
							object obj16 = !flag16;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag17 = obj13 != null;
							bool flag18 = !flag17;
							_Canon = null;
							if (flag18)
							{
								continue;
							}
							bool flag19 = (object)beforeSkin == null;
							converter = (Converter<System.__Canon, System.__Canon>)(object)obj10;
							_Canon = null;
							val = val5;
							val2 = (Enumerator<, >)0;
							obj17 = 0;
							val6 = val3;
							val4 = val5;
							val7 = (Enumerator<, >)(ref val);
							num = unchecked((nint)null);
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49A0]");
								object obj18 = 0;
								_Canon = (System.__Canon)obj18;
								Dictionary<System.__Canon, System.__Canon> dictionary;
								if (((Dictionary<System.__Canon, System.__Canon>)(object)beforeSkin).ContainsKey((System.__Canon)val3))
								{
									bool flag20 = (nint)obj7 < sharedMaterials.Length;
									object obj19 = !flag20;
									converter = (Converter<System.__Canon, System.__Canon>)(object)obj10;
									val = val5;
									val2 = (Enumerator<, >)0;
									obj17 = 0;
									val6 = val3;
									val4 = val5;
									val7 = (Enumerator<, >)(ref val);
									_Canon2 = (System.__Canon)val3;
									if (obj19 != null)
									{
										goto IL_0d10;
									}
									Material material = Unwounded((Material)obj12);
									CosmeticSkin cosmeticSkin3 = look;
									bool flag21 = (object)look == null;
									converter = (Converter<System.__Canon, System.__Canon>)(object)obj10;
									val = val5;
									val2 = (Enumerator<, >)0;
									obj17 = 0;
									val6 = val3;
									val4 = val5;
									val7 = (Enumerator<, >)(ref val);
									_Canon2 = (System.__Canon)obj12;
									if (flag21)
									{
										goto IL_0d1e;
									}
									object obj20 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X0_v96+E4]");
									bool flag22 = (nint)0 == 0;
									object obj21 = !flag22;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag23 = material != cosmeticSkin3.body;
									bool flag24 = !flag23;
									dictionary = (Dictionary<System.__Canon, System.__Canon>)(object)material;
									converter = (Converter<System.__Canon, System.__Canon>)(object)cosmeticSkin3.body;
									_Canon = null;
									num = (nint)cosmeticSkin3.body;
									if (!flag24)
									{
										bool flag25 = (object)beforeSkin == null;
										obj13 = material;
										converter = (Converter<System.__Canon, System.__Canon>)(object)cosmeticSkin3.body;
										_Canon = null;
										val = val5;
										val2 = (Enumerator<, >)0;
										obj17 = 0;
										val6 = val3;
										val4 = val5;
										val7 = (Enumerator<, >)(ref val);
										_Canon2 = (System.__Canon)(object)cosmeticSkin3.body;
										if (flag25)
										{
											goto IL_0d64;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49A8]");
										object obj22 = 0;
										_Canon = (System.__Canon)obj22;
										System.__Canon _Canon3 = ((Dictionary<System.__Canon, System.__Canon>)(object)beforeSkin).get_Item((System.__Canon)val3);
										bool flag26 = (nint)obj7 < sharedMaterials.Length;
										object obj23 = !flag26;
										obj13 = material;
										converter = (Converter<System.__Canon, System.__Canon>)(object)cosmeticSkin3.body;
										val = val5;
										val2 = (Enumerator<, >)0;
										obj17 = 0;
										val6 = val3;
										val4 = val5;
										val7 = (Enumerator<, >)(ref val);
										_Canon2 = (System.__Canon)val3;
										if (obj23 != null)
										{
											goto IL_0d3a;
										}
										Material material2 = Unwounded((Material)obj12);
										bool flag27 = _Canon3 == null;
										obj13 = (UnityEngine.Object)(object)_Canon3;
										converter = (Converter<System.__Canon, System.__Canon>)(object)cosmeticSkin3.body;
										val = val5;
										val2 = (Enumerator<, >)0;
										obj17 = 0;
										val6 = val3;
										val4 = val5;
										val7 = (Enumerator<, >)(ref val);
										_Canon2 = (System.__Canon)obj12;
										if (flag27)
										{
											goto IL_0d48;
										}
										bool flag28 = (object)material2 == null;
										System.__Canon _Canon4 = (System.__Canon)obj12;
										if (!flag28)
										{
											nint num2 = (nint)_Canon3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v57 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>>)+40]");
											_Canon4 = (System.__Canon)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag29 = ex == null;
											obj13 = (UnityEngine.Object)(object)_Canon3;
											obj10 = material2;
											val = val5;
											val2 = (Enumerator<, >)0;
											obj17 = 0;
											val6 = val3;
											val4 = val5;
											val7 = (Enumerator<, >)(ref val);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v57 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>>)+40]");
											_Canon2 = (System.__Canon)0;
											if (flag29)
											{
												goto IL_0d7a;
											}
										}
										Dictionary<System.__Canon, System.__Canon>.Entry[] entries = ((Dictionary<System.__Canon, System.__Canon>)_Canon3)._entries;
										bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<Dictionary<System.__Canon, System.__Canon>.Entry[], UIntPtr>(ref entries);
										object obj24 = !flag30;
										obj13 = (UnityEngine.Object)(object)_Canon3;
										converter = (Converter<System.__Canon, System.__Canon>)(object)material2;
										val = val5;
										val2 = (Enumerator<, >)0;
										obj17 = 0;
										val6 = val3;
										val4 = val5;
										val7 = (Enumerator<, >)(ref val);
										_Canon2 = _Canon4;
										if (obj24 != null)
										{
											goto IL_0d56;
										}
										object obj25 = (object)_Canon3 + obj7;
										object obj26 = obj25 + 32;
										obj26 = material2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										dictionary = (Dictionary<System.__Canon, System.__Canon>)_Canon3;
										converter = (Converter<System.__Canon, System.__Canon>)(object)material2;
										num = (nint)material2;
									}
								}
								else
								{
									dictionary = (Dictionary<System.__Canon, System.__Canon>)(object)beforeSkin;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4990]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4998]");
									object obj28 = 0;
									converter2._002Ector((object)this, (IntPtr)obj28);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4988]");
									object obj29 = 0;
									_Canon = (System.__Canon)obj29;
									System.__Canon[] array = Array.ConvertAll((System.__Canon[])(object)sharedMaterials, converter2);
									bool flag31 = (object)beforeSkin == null;
									object obj30 = 0;
									obj13 = beforeSkin;
									converter = converter2;
									val = val5;
									val2 = (Enumerator<, >)0;
									obj17 = 0;
									val6 = val3;
									val4 = val5;
									val7 = (Enumerator<, >)(ref val);
									_Canon2 = (System.__Canon)(object)converter2;
									if (flag31)
									{
										goto IL_0d2c;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49B0]");
									object obj31 = 0;
									obj30 = obj31;
									((Dictionary<System.__Canon, System.__Canon>)(object)beforeSkin).set_Item((System.__Canon)val3, (System.__Canon)(object)array);
									converter = converter2;
									_Canon = (System.__Canon)(object)array;
									num = (nint)val3;
								}
								CosmeticSkin cosmeticSkin4 = look;
								bool flag32 = (object)look == null;
								obj13 = (UnityEngine.Object)(object)dictionary;
								val = val5;
								val2 = (Enumerator<, >)0;
								obj17 = 0;
								val6 = val3;
								val4 = val5;
								val7 = (Enumerator<, >)(ref val);
								if (!flag32)
								{
									obj13 = cosmeticSkin4.body;
									bool flag33 = (object)cosmeticSkin4.body == null;
									nint num3 = num;
									if (!flag33)
									{
										nint num4 = (nint)sharedMaterials;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v41 (Il2CppClass<UnityEngine.Material[]>)+40]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag34 = ex2 == null;
										val = val5;
										val2 = (Enumerator<, >)0;
										obj17 = 0;
										val6 = val3;
										val4 = val5;
										val7 = (Enumerator<, >)(ref val);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v41 (Il2CppClass<UnityEngine.Material[]>)+40]");
										num = 0;
										if (flag34)
										{
											goto IL_0cf3;
										}
									}
									bool flag35 = (nint)obj7 < sharedMaterials.Length;
									object obj32 = !flag35;
									val = val5;
									val2 = (Enumerator<, >)0;
									obj17 = 0;
									val6 = val3;
									val4 = val5;
									val7 = (Enumerator<, >)(ref val);
									num = num3;
									if (obj32 == null)
									{
										obj12 = obj13;
										object obj33 = obj11 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										((Renderer)val3).sharedMaterials = sharedMaterials;
										shownFur = (Color)0;
										_ = 0;
										obj10 = (UnityEngine.Object)(object)converter;
										_Canon = null;
										continue;
									}
									goto IL_0cc9;
								}
								goto IL_0cd7;
							}
							goto IL_0ce5;
						}
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						obj6 = null;
					}
					NullReferenceException ex4 = new NullReferenceException();
					goto IL_0c22;
				}
				val = val5;
				val2 = (Enumerator<, >)0;
				obj17 = 0;
				val6 = val3;
				val4 = val5;
				val7 = (Enumerator<, >)(ref val);
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49B8]");
				object obj35 = 0;
				num = (nint)obj35;
				((Enumerator<, >*)val7)->Dispose();
				bool flag36 = obj34 == null;
				object obj36 = !flag36;
				if (obj36 == null)
				{
					bool flag37 = (int)val2 == 0;
					object obj37 = !flag37;
					converter = (Converter<System.__Canon, System.__Canon>)(object)obj10;
					OutOfMemoryException ex5 = (OutOfMemoryException)val7;
					if (obj37 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex5 = new OutOfMemoryException();
					converter = (Converter<System.__Canon, System.__Canon>)(object)obj10;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0cc9;
				IL_0d1e:
				NullReferenceException ex6 = new NullReferenceException();
				goto IL_0d2c;
				IL_0d2c:
				NullReferenceException ex7 = new NullReferenceException();
				goto IL_0d3a;
				IL_0d3a:
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				goto IL_0d48;
				IL_0d48:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_0d56;
				IL_0c30:
				IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
				goto IL_0c3e;
				IL_0c3e:
				NullReferenceException ex11 = new NullReferenceException();
				_Canon = null;
				num = (nint)obj6;
				break;
				IL_0d64:
				ex = new NullReferenceException();
				obj10 = (UnityEngine.Object)(object)converter;
				goto IL_0d7a;
				IL_0d7a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ArgumentNullException ex12 = new ArgumentNullException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D194");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
				IL_0d56:
				IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
				goto IL_0d64;
				IL_0cc9:
				IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
				goto IL_0cd7;
				IL_0ce5:
				ex2 = new NullReferenceException();
				goto IL_0cf3;
				IL_0cf3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ArgumentNullException ex15 = new ArgumentNullException();
				_Canon2 = null;
				goto IL_0d10;
				IL_0cd7:
				NullReferenceException ex16 = new NullReferenceException();
				goto IL_0ce5;
				IL_0c22:
				NullReferenceException ex17 = new NullReferenceException();
				goto IL_0c30;
				IL_0d10:
				IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
				goto IL_0d1e;
			}
			NullReferenceException ex19 = new NullReferenceException();
			val = val5;
			val2 = (Enumerator<, >)0;
			obj17 = 0;
			val6 = val3;
			val4 = val5;
			val7 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private unsafe void Tint()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1297: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Expected Obj, but got Unknown
		//IL_12be: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12db: Expected Obj, but got Unknown
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected Obj, but got Unknown
		//IL_1318: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got I
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected Obj, but got I
		//IL_08ef: Expected Obj, but got I
		//IL_08ff: Expected Obj, but got I
		//IL_0910: Expected Obj, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected Obj, but got Unknown
		//IL_0efc: Expected Obj, but got I4
		//IL_0955: Expected Obj, but got I4
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected Obj, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected Obj, but got I4
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected Obj, but got Unknown
		//IL_148c: Expected Obj, but got I
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_149d: Expected Ref, but got Unknown
		//IL_14b7: Expected Obj, but got I4
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got I4
		//IL_09f7: Expected Obj, but got I
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got I4
		//IL_07bb: Expected Obj, but got I4
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_1415: Expected Obj, but got I
		//IL_1426: Unknown result type (might be due to invalid IL or missing references)
		//IL_142a: Unknown result type (might be due to invalid IL or missing references)
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Unknown result type (might be due to invalid IL or missing references)
		//IL_1440: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected Obj, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_144c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1450: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1458: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got I4
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I4
		//IL_0848: Expected Obj, but got I4
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Expected Obj, but got I4
		//IL_1284: Expected Obj, but got I4
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Expected Obj, but got Unknown
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected Obj, but got Unknown
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got I
		//IL_06ee: Expected VT, but got I4
		//IL_06ee: Expected I4, but got Obj
		//IL_0ab3: Expected I4, but got Obj
		//IL_070d: Expected Obj, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_110d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1127: Expected Obj, but got Unknown
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected Obj, but got Unknown
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected Obj, but got I4
		//IL_0aea: Expected Obj, but got I
		//IL_0b18: Expected Obj, but got I4
		//IL_0b21: Expected Obj, but got I4
		//IL_13d6: Expected Obj, but got I4
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected Obj, but got Unknown
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Expected Obj, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fba: Expected Obj, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected Obj, but got Unknown
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I4
		//IL_0bdc: Expected Obj, but got I4
		//IL_0dde: Expected Obj, but got I
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected Obj, but got Unknown
		//IL_0c11: Expected Obj, but got I
		//IL_0c3f: Expected Obj, but got I4
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected Obj, but got Unknown
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected Obj, but got I
		//IL_0c9e: Expected I4, but got Obj
		//IL_0ced: Expected Obj, but got I
		//IL_0d1f: Expected Obj, but got I4
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Expected Obj, but got Unknown
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected Obj, but got Unknown
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got I
		//IL_0d83: Expected VT, but got I4
		//IL_0d83: Expected I4, but got Obj
		//IL_0d98: Expected Obj, but got I
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		ApeColor apeColor = null;
		if (!flag3)
		{
			ApeColor apeColor2 = (colour = FindColour());
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			apeColor = apeColor2;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enumerator<, > val3;
		Enumerator<, > val5;
		Enumerator<, > val6;
		Enumerator<, > val;
		Enumerator<, > val2;
		UnityEngine.Object obj8;
		Enumerator<, > val4;
		int num;
		if ((UnityEngine.Object)obj3 != null)
		{
			object obj7 = obj3;
			bool flag5 = obj3 == null;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			num = 0;
			obj8 = null;
			if (flag5)
			{
				goto IL_1156;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v66+40]");
			val5 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v66+48]");
			val6 = (Enumerator<, >)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C690]");
			val5 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BBE8]");
			val6 = (Enumerator<, >)0;
		}
		object obj9 = val5 - shownFur;
		Enumerator<, > val7 = val6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticWearer)+100]");
		object obj10 = val7 - 0;
		object obj11 = obj9 * obj9;
		object obj12 = obj10 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj13 = obj11 + val5;
		object obj14 = obj12 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj15 = obj12 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj15 < 0)
		{
			return;
		}
		obj3 = this + 160;
		bool flag6 = obj3 == null;
		object obj16 = !flag6;
		UnityEngine.Object obj17 = null;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj3 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj17 = (UnityEngine.Object)(object)materialPropertyBlock;
		}
		object obj19 = obj;
		UnityEngine.Object obj20 = look;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj20 != null;
		bool flag9 = !flag8;
		Enumerator<, > val8 = val5;
		Enumerator<, > val9 = val6;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		Enumerator<, > val11 = default;
		Enumerator<, > val10 = val11;
		UnityEngine.Object obj22 = default;
		Enumerator<, > val12 = (Enumerator<, >)obj22;
		val4 = val5;
		Enumerator<, > val13 = val6;
		num = 0;
		obj8 = null;
		if (flag9)
		{
			goto IL_0886;
		}
		CosmeticSkin cosmeticSkin = look;
		bool flag10 = (object)look == null;
		Enumerator<, > val14 = val5;
		val9 = val6;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val10 = val11;
		UnityEngine.Object obj23 = obj22;
		val4 = val5;
		val13 = val6;
		Enumerator<, > val15 = val6;
		Enumerator<, > val16 = val5;
		num = 0;
		obj8 = null;
		UnityEngine.Object obj31;
		UnityEngine.Object obj32 = default;
		object obj38;
		UnityEngine.Object obj39;
		Enumerator<, > val18 = default;
		UnityEngine.Object obj27 = default;
		if (!flag10)
		{
			bool flag11 = (byte)(~(cosmeticSkin.furTint ? 1u : 0u)) != 0;
			val8 = val5;
			val9 = val6;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val10 = val11;
			val12 = (Enumerator<, >)obj22;
			val4 = val5;
			val13 = val6;
			num = 0;
			obj8 = null;
			if (flag11)
			{
				goto IL_0886;
			}
			bool flag12 = (object)furSlots == null;
			val14 = val5;
			val9 = val6;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val10 = val11;
			obj23 = obj22;
			val4 = val5;
			val13 = val6;
			val15 = val6;
			val16 = val5;
			num = 0;
			obj8 = null;
			if (!flag12)
			{
				Enumerator<, > enumerator = ((List<(System.__Canon, int)>)(object)furSlots).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49C0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4860]");
				object obj25 = 0;
				Enumerator<, > val17 = default;
				val4 = val17;
				UnityEngine.Object obj26 = obj27;
				val15 = val6;
				val16 = val5;
				num = 0;
				int num2 = default;
				while (val3.MoveNext())
				{
					object obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X0_v23+E4]");
					bool flag13 = (nint)0 == 0;
					object obj29 = !flag13;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = obj27 == null;
					bool flag15 = !flag14;
					object obj30 = !flag15;
					num = 0;
					if (obj30 != null)
					{
						continue;
					}
					bool flag16 = (object)obj27 == null;
					val14 = val5;
					val9 = val6;
					val = (Enumerator<, >)0;
					obj31 = null;
					obj32 = null;
					val2 = (Enumerator<, >)obj27;
					val3 = val17;
					val10 = val11;
					obj23 = obj22;
					val13 = (Enumerator<, >)obj26;
					num = 0;
					obj8 = null;
					if (flag16)
					{
						goto IL_1194;
					}
					((Renderer)obj27).GetPropertyBlock((MaterialPropertyBlock)obj3, num2);
					object obj33 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X0_v28+E4]");
					bool flag17 = (nint)0 == 0;
					object obj34 = !flag17;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag18 = obj3 == null;
					val14 = val5;
					val9 = val6;
					val = (Enumerator<, >)0;
					object obj35 = 0;
					obj31 = null;
					obj32 = null;
					val2 = (Enumerator<, >)obj27;
					val3 = val17;
					val10 = val11;
					obj23 = obj22;
					val13 = (Enumerator<, >)obj26;
					num = num2;
					obj8 = (UnityEngine.Object)obj3;
					if (!flag18)
					{
						object obj36 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v23+A0]");
						object obj37 = 0;
						((MaterialPropertyBlock)obj3).SetColor((int)obj37, (Color)0);
						((Renderer)obj27).SetPropertyBlock((MaterialPropertyBlock)obj3, num2);
						obj35 = 0;
						val4 = val5;
						obj26 = obj22;
						val15 = val11;
						val16 = val6;
						num = num2;
						continue;
					}
					goto IL_11a2;
				}
				val14 = val5;
				val9 = val6;
				val = (Enumerator<, >)0;
				obj38 = 7;
				obj31 = null;
				obj32 = null;
				obj39 = obj27;
				val3 = val17;
				val18 = (Enumerator<, >)(ref val3);
				val10 = val11;
				obj23 = obj22;
				val13 = (Enumerator<, >)obj26;
				obj20 = null;
				goto IL_147c;
			}
		}
		goto IL_1156;
		IL_0f8f:
		NullReferenceException ex = new NullReferenceException();
		val14 = val8;
		Enumerator<, > val19 = default;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		Enumerator<, > val20;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		goto IL_11bd;
		IL_103d:
		ex = new NullReferenceException();
		val14 = val8;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		num = 0;
		obj8 = (UnityEngine.Object)obj3;
		goto IL_11bd;
		IL_0f12:
		val14 = val8;
		obj23 = (UnityEngine.Object)val12;
		val15 = val6;
		val16 = val5;
		goto IL_1156;
		IL_1156:
		throw new NullReferenceException();
		IL_0f37:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		val14 = val8;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		ex = (NullReferenceException)(object)ex2;
		goto IL_11bd;
		IL_147c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49B8]");
		object obj40 = 0;
		obj8 = (UnityEngine.Object)obj40;
		((Enumerator<, >*)val18)->Dispose();
		bool flag19 = (object)obj20 == null;
		object obj41 = !flag19;
		obj27 = obj31;
		val2 = (Enumerator<, >)obj39;
		if (obj41 != null)
		{
			goto IL_1161;
		}
		bool flag20 = (object)obj31 == null;
		object obj42 = !flag20;
		obj27 = obj31;
		val2 = (Enumerator<, >)obj39;
		OutOfMemoryException ex3 = (OutOfMemoryException)val18;
		if (obj42 == null)
		{
			bool flag21 = (nint)obj38 == 7;
			val8 = val14;
			obj27 = obj31;
			val2 = (Enumerator<, >)obj39;
			val12 = (Enumerator<, >)obj23;
			val6 = val15;
			val5 = val16;
			if (!flag21)
			{
				bool flag22 = obj38 == null;
				object obj43 = !flag22;
				val8 = val14;
				obj27 = obj31;
				val2 = (Enumerator<, >)obj39;
				val12 = (Enumerator<, >)obj23;
				val6 = val15;
				val5 = val16;
				if (obj43 != null)
				{
					return;
				}
			}
			goto IL_0886;
		}
		goto IL_116f;
		IL_116f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_117e;
		IL_117e:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		obj31 = obj27;
		goto IL_1194;
		IL_1161:
		ex3 = new OutOfMemoryException();
		goto IL_116f;
		IL_1194:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_11a2;
		IL_109e:
		ex = new NullReferenceException();
		val14 = val8;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		num = 0;
		obj8 = null;
		goto IL_11bd;
		IL_11a2:
		ex = new NullReferenceException();
		obj39 = (UnityEngine.Object)val2;
		goto IL_11bd;
		IL_0886:
		List<GameObject>[] array = worn;
		bool flag23 = worn == null;
		val14 = val8;
		obj23 = (UnityEngine.Object)val12;
		val15 = val6;
		val16 = val5;
		if (!flag23)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4860]");
			object obj46 = 0;
			UnityEngine.Object obj47 = obj27;
			object obj24 = 0;
			while (true)
			{
				if ((nint)obj24 < array.Length)
				{
					bool flag24 = (nint)obj24 == 6;
					obj27 = obj47;
					if (!flag24)
					{
						break;
					}
					array = worn;
					obj24++;
					bool flag25 = worn == null;
					object obj48 = !flag25;
					obj47 = obj27;
					if (obj48 != null)
					{
						continue;
					}
					goto IL_0f12;
				}
				return;
			}
			bool flag26 = (nint)obj24 < array.Length;
			object obj49 = !flag26;
			val14 = val8;
			obj27 = obj47;
			obj23 = (UnityEngine.Object)val12;
			val15 = val6;
			val16 = val5;
			if (obj49 != null)
			{
				goto IL_117e;
			}
			object obj50 = (object)array + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v42+20]");
			bool flag27 = (nint)0 == 0;
			val14 = val8;
			obj27 = obj47;
			obj23 = (UnityEngine.Object)val12;
			val15 = val6;
			val16 = val5;
			if (!flag27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v42+20]");
				Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
				val20 = val19;
				object obj54 = default;
				while (val.MoveNext())
				{
					object obj51 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X0_v77+E4]");
					bool flag28 = (nint)0 == 0;
					object obj52 = !flag28;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag29 = obj47 == null;
					bool flag30 = !flag29;
					object obj53 = !flag30;
					num = 0;
					if (obj53 != null)
					{
						continue;
					}
					if ((object)obj47 == null)
					{
						goto IL_109e;
					}
					num = (int)obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
					if (obj54 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v83+18]");
						object obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v83+18]");
						if ((nint)0 < (nint)1)
						{
							continue;
						}
						object obj25 = 0;
						obj8 = (UnityEngine.Object)1;
						while (true)
						{
							bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55);
							object obj56 = !flag31;
							if (obj56 != null)
							{
								break;
							}
							object obj57 = obj54 + obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+20]");
								Material sharedMaterial = ((Renderer)0).sharedMaterial;
								object obj58 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X0_v90+E4]");
								bool flag32 = (nint)0 == 0;
								object obj59 = !flag32;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag33 = sharedMaterial == null;
								bool flag34 = !flag33;
								object obj60 = !flag34;
								Material material = sharedMaterial;
								num = 0;
								obj8 = null;
								if (obj60 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+20]");
									Material sharedMaterial2 = ((Renderer)0).sharedMaterial;
									object obj61 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X0_v97+E4]");
									bool flag35 = (nint)0 == 0;
									object obj62 = !flag35;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if ((object)sharedMaterial2 == null)
									{
										goto IL_0fdf;
									}
									object obj63 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v60+A0]");
									object obj64 = 0;
									bool flag36 = sharedMaterial2.HasProperty((int)obj64);
									bool flag37 = !flag36;
									material = sharedMaterial2;
									num = 0;
									obj8 = (UnityEngine.Object)obj64;
									if (!flag37)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+20]");
										((Renderer)0).GetPropertyBlock((MaterialPropertyBlock)obj3);
										object obj65 = obj46;
										material = (Material)obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v103+E4]");
										bool flag38 = (nint)0 == 0;
										object obj66 = !flag38;
										if (obj66 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if ((object)material == null)
										{
											goto IL_103d;
										}
										object obj67 = obj46;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X8_v63+A0]");
										object obj68 = 0;
										((MaterialPropertyBlock)(object)material).SetColor((int)obj68, (Color)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v55+20]");
										((Renderer)0).SetPropertyBlock((MaterialPropertyBlock)obj3);
										val20 = val8;
										val13 = val12;
										val6 = val10;
										val5 = val9;
										num = 0;
										obj8 = (UnityEngine.Object)obj3;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v83+18]");
								obj55 = 0;
								obj25++;
								object obj69 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v83+18]");
								if ((nint)obj69 >= 0)
								{
									goto IL_1393;
								}
								continue;
							}
							goto IL_0f8f;
						}
						goto IL_0f37;
					}
					goto IL_10fc;
					IL_1393:;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
				object obj70 = 0;
				obj8 = (UnityEngine.Object)obj70;
				val.Dispose();
				val14 = val8;
				val = val19;
				obj27 = null;
				obj32 = null;
				obj23 = (UnityEngine.Object)val12;
				val4 = val20;
				val15 = val6;
				val16 = val5;
				goto IL_1161;
			}
		}
		goto IL_1156;
		IL_10fc:
		ex = new NullReferenceException();
		val14 = val8;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		obj8 = (UnityEngine.Object)1;
		goto IL_11bd;
		IL_11bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
		NullReferenceException ex6 = ex;
		object obj71 = default;
		NullReferenceException ex7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if ((nint)obj8 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj31 = (UnityEngine.Object)1;
				obj20 = obj32;
				break;
			}
			if ((nint)obj8 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj20 = (UnityEngine.Object)obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj32 = (UnityEngine.Object)obj71;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D194");
			ex6 = ex7;
		}
		obj38 = 0;
		goto IL_147c;
		IL_0fdf:
		ex = new NullReferenceException();
		val14 = val8;
		val = val19;
		obj31 = null;
		obj32 = null;
		obj39 = (UnityEngine.Object)val2;
		obj23 = (UnityEngine.Object)val12;
		val4 = val20;
		val15 = val6;
		val16 = val5;
		num = 0;
		obj8 = null;
		goto IL_11bd;
	}

	private ApeColor FindColour()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0648: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_069b: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I8
		//IL_03c4: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I4
		//IL_0674: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_04a0: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		bool flag2 = obj5 == null;
		bool flag3 = !flag2;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		UnityEngine.Object obj8 = obj5;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B38]");
			object obj9 = 0;
			obj6 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F1DC");
			obj7 = (UnityEngine.Object)1;
			UnityEngine.Object obj10 = default;
			obj8 = obj10;
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = obj8 != null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B40]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD840");
			object obj18 = default;
			if (obj18 == null)
			{
				goto IL_05c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v17+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v17+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_05b6;
			}
			object obj20 = 0;
			Transform transform = null;
			while (true)
			{
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
				object obj21 = !flag8;
				if (obj21 != null)
				{
					break;
				}
				object obj22 = obj18 + obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v13+20]");
				obj8 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v13+20]");
				if ((nint)0 != 0)
				{
					object obj23 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v24+E4]");
					bool flag9 = (nint)0 == 0;
					object obj24 = !flag9;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+20]");
					bool flag10 = (UnityEngine.Object)0 != null;
					bool flag11 = !flag10;
					obj17 = 0;
					transform = null;
					if (flag11)
					{
						goto IL_033a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+20]");
						Transform transform2 = ((Component)0).transform;
						Transform transform3 = base.transform;
						if ((object)transform2 != null)
						{
							bool flag12 = transform2.IsChildOf(transform3);
							bool flag13 = !flag12;
							object obj25 = !flag13;
							obj17 = 0;
							transform = transform3;
							if (obj25 == null)
							{
								goto IL_033a;
							}
							goto IL_0656;
						}
					}
				}
				goto IL_05c0;
				IL_033a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+28]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X25_v7+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X25_v7+18]");
						object obj27 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v4 (UnityEngine.Object)+28]");
						object obj28 = (nint)0 + (nint)32;
						object obj29 = 0;
						object obj30 = obj17;
						Transform transform4 = transform;
						while (true)
						{
							bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
							object obj31 = !flag14;
							if (obj31 != null)
							{
								break;
							}
							object obj32 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v31+E4]");
							bool flag15 = (nint)0 == 0;
							object obj33 = !flag15;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X27_v7+v116 @ X26_v9*8]");
							bool flag16 = (UnityEngine.Object)0 != null;
							bool flag17 = !flag16;
							obj17 = 0;
							transform = null;
							if (flag17)
							{
								goto IL_051a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X27_v7+v116 @ X26_v9*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X27_v7+v116 @ X26_v9*8]");
								Transform transform5 = ((Component)0).transform;
								Transform transform6 = base.transform;
								if ((object)transform5 != null)
								{
									bool flag18 = transform5.IsChildOf(transform6);
									bool flag19 = !flag18;
									object obj34 = !flag19;
									obj17 = 0;
									transform = transform6;
									if (obj34 == null)
									{
										goto IL_051a;
									}
									goto IL_0656;
								}
							}
							goto IL_05c0;
							IL_051a:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X25_v7+18]");
							obj27 = 0;
							object obj35 = obj29 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X25_v7+18]");
							bool flag20 = (nint)obj35 < 0;
							obj29 = obj35;
							obj30 = obj17;
							transform4 = transform;
							if (flag20)
							{
								continue;
							}
							goto IL_0574;
						}
						break;
					}
				}
				goto IL_0574;
				IL_0574:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v17+18]");
				obj19 = 0;
				obj20++;
				object obj36 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v17+18]");
				if ((nint)obj36 < 0)
				{
					continue;
				}
				goto IL_05b6;
			}
			goto IL_05ce;
		}
		goto IL_0656;
		IL_05b6:
		obj8 = null;
		goto IL_0656;
		IL_05c0:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ce;
		IL_05ce:
		return (ApeColor)(object)new IndexOutOfRangeException();
		IL_0656:
		return (ApeColor)obj8;
	}

	private unsafe void Eyes()
	{
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got I4
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected Ref, but got Unknown
		//IL_0fe4: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got I4
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected VT, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_024b: Expected I4, but got Obj
		//IL_0256: Expected I4, but got Obj
		//IL_02e9: Expected Obj, but got I8
		//IL_0303: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0fab: Expected Obj, but got I4
		//IL_03e1: Expected I4, but got Obj
		//IL_03ec: Expected I4, but got Obj
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected Obj, but got Unknown
		//IL_0aa1: Expected Obj, but got I4
		//IL_0ab1: Expected I4, but got Obj
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected I4, but got Obj
		//IL_04b5: Expected I4, but got Obj
		//IL_0b82: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got I4
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I4
		//IL_09bf: Expected Obj, but got I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got I4
		//IL_0d60: Expected Obj, but got I4
		//IL_0784: Expected I, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I
		//IL_0936: Expected I, but got Obj
		//IL_0946: Expected Obj, but got I
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got I
		//IL_0c08: Expected Obj, but got I4
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_067a: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I4
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected Obj, but got I
		//IL_0c72: Expected I, but got Obj
		//IL_0c9e: Expected Obj, but got I4
		//IL_0cd3: Expected Obj, but got I4
		//IL_0cfb: Expected I, but got Obj
		//IL_0d36: Expected Obj, but got I4
		//IL_0d43: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD98D]");
		bool flag = false;
		bool flag2 = (object)eyeBones == null;
		bool flag4 = default;
		bool flag3 = flag4;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A68]");
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A60]");
			Material[] array = (Material[])0;
			Enumerator<, > enumerator = ((List<(System.__Canon, Vector3)>)(object)eyeBones).GetEnumerator();
			Enumerator<, > val3 = (Enumerator<, >)flag4;
			Enumerator<, > val4 = default;
			val2 = val4;
			bool flag5 = default;
			flag = flag5;
			object obj6 = default;
			object obj7 = default;
			IndexOutOfRangeException ex3 = default;
			MaterialPropertyBlock materialPropertyBlock2 = default;
			while (true)
			{
				object obj5;
				Enumerator<, > val6;
				Enumerator<, > val5;
				Texture texture;
				if (val.MoveNext())
				{
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v115+E4]");
					flag = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v115+E4]");
					bool flag6 = (byte)(~(nuint)0u) != 0;
					object obj4 = !flag6;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag7 = (UnityEngine.Object)flag4 != null;
					bool flag8 = !flag7;
					texture = null;
					if (!flag8)
					{
						if (!flag4)
						{
							NullReferenceException ex = new NullReferenceException();
							texture = null;
							flag3 = false;
							val = val4;
							obj5 = 0;
							val5 = (Enumerator<, >)(ref val);
							val6 = (Enumerator<, >)(ref val);
							obj = null;
							break;
						}
						float num = (float)(flag5 ? 1 : 0) * eyeSize;
						float num2 = (float)obj6 * eyeSize;
						val2 = (Enumerator<, >)(obj7 * eyeSize);
						((Transform)flag4).localScale = (Vector3)0;
						texture = null;
						val3 = (Enumerator<, >)num2;
					}
					continue;
				}
				flag3 = false;
				val = val4;
				obj5 = 0;
				val5 = (Enumerator<, >)(ref val);
				val6 = (Enumerator<, >)(ref val);
				object obj8 = 0;
				obj = (UnityEngine.Object)(object)array;
				((Enumerator<, >*)val6)->Dispose();
				bool flag9 = obj8 == null;
				object obj9 = !flag9;
				Material[] sharedMaterials;
				object obj23;
				if (obj9 == null)
				{
					bool flag10 = !flag3;
					object obj10 = !flag10;
					OutOfMemoryException ex2 = (OutOfMemoryException)val6;
					flag = flag3;
					if (obj10 == null)
					{
						object obj11 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v5+E4]");
						bool flag11 = (nint)0 == 0;
						object obj12 = !flag11;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (Face__BackingField != null)
						{
							flag = (byte)(int)Face__BackingField != 0;
							bool flag12 = (byte)(int)(~Face__BackingField) != 0;
							texture = null;
							obj = null;
							if (flag12)
							{
								break;
							}
							val2 = (Enumerator<, >)eyeOut;
							_ = eyeOut;
						}
						object obj13 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v9+E4]");
						bool flag13 = (nint)0 == 0;
						object obj14 = !flag13;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag14 = eyes == null;
						bool flag15 = !flag14;
						object obj15 = !flag15;
						if (obj15 != null)
						{
							return;
						}
						flag = (byte)eyeSlot != 0;
						object obj16 = eyeSlot & 0x80000000L;
						bool flag16 = obj16 == null;
						object obj17 = !flag16;
						if (obj17 != null)
						{
							return;
						}
						bool flag17 = (object)eyes == null;
						texture = null;
						obj = null;
						if (flag17)
						{
							break;
						}
						sharedMaterials = eyes.sharedMaterials;
						object obj18 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v10+E4]");
						val5 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v10+E4]");
						bool flag18 = (nint)0 == 0;
						object obj19 = !flag18;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag19 = look != null;
						bool flag20 = !flag19;
						Texture texture2 = null;
						UnityEngine.Object obj20 = null;
						if (!flag20)
						{
							flag = (byte)(int)look != 0;
							bool flag21 = (byte)(int)(~look) != 0;
							texture = null;
							obj = null;
							array = sharedMaterials;
							if (flag21)
							{
								break;
							}
							object obj21 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v79+E4]");
							val5 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v79+E4]");
							bool flag22 = (nint)0 == 0;
							object obj22 = !flag22;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v17 (System.Boolean)+30]");
							bool flag23 = (UnityEngine.Object)0 != null;
							bool flag24 = !flag23;
							texture2 = null;
							obj20 = null;
							if (!flag24)
							{
								flag = (byte)(int)look != 0;
								bool flag25 = (byte)(int)(~look) != 0;
								texture = null;
								obj = null;
								array = sharedMaterials;
								if (flag25)
								{
									break;
								}
								obj23 = look + 48;
								texture2 = null;
								obj20 = null;
								goto IL_0f81;
							}
						}
						obj23 = this + 216;
						goto IL_0f81;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0e40;
				IL_0d92:
				bool flag26 = (object)eyes == null;
				UnityEngine.Object obj24;
				materialPropertyBlock = (MaterialPropertyBlock)(object)obj24;
				if (flag26)
				{
					break;
				}
				eyes.SetPropertyBlock(eyeBlock, eyeSlot);
				return;
				IL_0e40:
				ex3 = new IndexOutOfRangeException();
				goto IL_0e4e;
				IL_0e4e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ArgumentNullException ex4 = new ArgumentNullException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D1D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
				IL_0f81:
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v20+E4]");
				bool flag27 = (nint)0 == 0;
				object obj26 = !flag27;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = (UnityEngine.Object)obj23 != null;
				object obj27 = obj2;
				materialPropertyBlock = (MaterialPropertyBlock)(this + 200);
				UnityEngine.Object obj28 = (UnityEngine.Object)(object)materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v24+E4]");
				val5 = (Enumerator<, >)0;
				Material[] array2;
				if (flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v24+E4]");
					bool flag29 = (nint)0 == 0;
					object obj29 = !flag29;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj32;
					Enumerator<, > val7;
					if (obj28 == null)
					{
						bool flag30 = sharedMaterials == null;
						texture = null;
						obj = null;
						array = sharedMaterials;
						flag = flag28;
						if (flag30)
						{
							break;
						}
						flag = (byte)eyeSlot != 0;
						val5 = (Enumerator<, >)sharedMaterials.Length;
						bool flag31 = eyeSlot < sharedMaterials.Length;
						object obj30 = !flag31;
						texture = null;
						obj = null;
						array = sharedMaterials;
						if (obj30 != null)
						{
							goto IL_0e40;
						}
						object obj31 = sharedMaterials + eyeSlot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v33+20]");
						obj32 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v33+20]");
						materialPropertyBlock = (MaterialPropertyBlock)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						val7 = (Enumerator<, >)sharedMaterials.Length;
					}
					else
					{
						bool flag32 = sharedMaterials == null;
						val7 = val5;
						obj32 = null;
						texture = null;
						obj = null;
						array = sharedMaterials;
						flag = flag28;
						if (flag32)
						{
							break;
						}
					}
					materialPropertyBlock = (MaterialPropertyBlock)eyeSlot;
					if (obj23 != null)
					{
						nint num3 = (nint)sharedMaterials;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v31 (Il2CppClass<UnityEngine.Material[]>)+40]");
						obj32 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag33 = ex3 == null;
						texture = null;
						val5 = val7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v31 (Il2CppClass<UnityEngine.Material[]>)+40]");
						obj = (UnityEngine.Object)0;
						array = sharedMaterials;
						flag = (byte)num3 != 0;
						if (flag33)
						{
							goto IL_0e4e;
						}
					}
					flag = (byte)sharedMaterials.Length != 0;
					bool flag34 = (nint)materialPropertyBlock < sharedMaterials.Length;
					object obj33 = !flag34;
					texture = null;
					val5 = val7;
					obj = obj32;
					array = sharedMaterials;
					if (obj33 != null)
					{
						goto IL_0e40;
					}
					object obj34 = (object)sharedMaterials + (object)materialPropertyBlock;
					object obj35 = obj34 + 32;
					obj35 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag35 = (object)eyes == null;
					texture = null;
					val5 = val7;
					obj = (UnityEngine.Object)obj23;
					array = sharedMaterials;
					if (flag35)
					{
						break;
					}
					eyes.sharedMaterials = sharedMaterials;
					texture = null;
					val5 = val7;
					array2 = sharedMaterials;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v24+E4]");
					bool flag36 = (nint)0 == 0;
					object obj36 = !flag36;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag37 = obj28 != null;
					bool flag38 = !flag37;
					texture = null;
					array2 = null;
					if (!flag38)
					{
						bool flag39 = sharedMaterials == null;
						texture = null;
						obj = null;
						array = sharedMaterials;
						flag = flag28;
						if (flag39)
						{
							break;
						}
						obj28 = eyeBefore;
						bool flag40 = (object)eyeBefore == null;
						UnityEngine.Object obj37 = null;
						if (!flag40)
						{
							nint num4 = (nint)sharedMaterials;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27 (Il2CppClass<UnityEngine.Material[]>)+40]");
							obj37 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag41 = ex3 == null;
							texture = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27 (Il2CppClass<UnityEngine.Material[]>)+40]");
							obj = (UnityEngine.Object)0;
							array = sharedMaterials;
							flag = (byte)num4 != 0;
							if (flag41)
							{
								goto IL_0e4e;
							}
						}
						flag = (byte)sharedMaterials.Length != 0;
						bool flag42 = eyeSlot < sharedMaterials.Length;
						object obj38 = !flag42;
						texture = null;
						obj = obj37;
						array = sharedMaterials;
						if (obj38 != null)
						{
							goto IL_0e40;
						}
						object obj39 = sharedMaterials + eyeSlot;
						object obj40 = obj39 + 32;
						obj40 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag43 = (object)eyes == null;
						texture = null;
						obj = obj28;
						array = sharedMaterials;
						if (flag43)
						{
							break;
						}
						eyes.sharedMaterials = sharedMaterials;
						materialPropertyBlock = (MaterialPropertyBlock)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						texture = null;
						array2 = null;
					}
				}
				array = (Material[])(this + 152);
				bool flag44 = array == null;
				object obj41 = !flag44;
				obj = (UnityEngine.Object)(object)array2;
				flag = (byte)(int)array != 0;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					flag = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					materialPropertyBlock2._002Ector();
					array = (Material[])(object)materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj = (UnityEngine.Object)(object)materialPropertyBlock2;
					materialPropertyBlock = materialPropertyBlock2;
				}
				if ((object)eyes == null)
				{
					break;
				}
				eyes.GetPropertyBlock(eyeBlock, eyeSlot);
				object obj42 = obj2;
				obj24 = eyeTex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v28+E4]");
				flag = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v28+E4]");
				bool flag45 = (byte)(~(nuint)0u) != 0;
				object obj43 = !flag45;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag46 = obj24 != null;
				bool flag47 = !flag46;
				texture = null;
				obj = null;
				object obj47;
				if (!flag47)
				{
					object obj44 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v36+E4]");
					flag = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v36+E4]");
					bool flag48 = (byte)(~(nuint)0u) != 0;
					object obj45 = !flag48;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag49 = (UnityEngine.Object)obj23 == null;
					bool flag50 = !flag49;
					texture = null;
					obj = null;
					if (!flag50)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
						obj24 = (UnityEngine.Object)0;
						nint num5 = (nint)obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X0_v40 (Il2CppClass<UnityEngine.Object>)+E4]");
						flag = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X0_v40 (Il2CppClass<UnityEngine.Object>)+E4]");
						bool flag51 = (byte)(~(nuint)0u) != 0;
						object obj46 = !flag51;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag52 = array == null;
						obj47 = 0;
						texture = null;
						obj = null;
						materialPropertyBlock = (MaterialPropertyBlock)(object)obj24;
						if (flag52)
						{
							break;
						}
						nint num6 = (nint)obj24;
						texture = eyeTex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v21 (Il2CppClass<UnityEngine.Object>)+A0]");
						flag = false;
						((MaterialPropertyBlock)(object)array).SetTexture(((bool*)(flag ? 1 : 0))->m_value ? 1 : 0, (Texture)eyeTex);
						obj47 = 0;
						obj = (UnityEngine.Object)((bool*)(flag ? 1 : 0))->m_value;
						goto IL_0d92;
					}
				}
				bool flag53 = array == null;
				obj47 = 0;
				materialPropertyBlock = (MaterialPropertyBlock)(object)obj24;
				if (flag53)
				{
					break;
				}
				((MaterialPropertyBlock)(object)array).Clear();
				obj47 = 0;
				obj = null;
				goto IL_0d92;
			}
		}
		throw new NullReferenceException();
	}

	private bool TornFor(string fx)
	{
		//IL_0010: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_0221: Expected I4, but got Obj
		//IL_0178: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool result;
		if (body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AD0]");
			object obj4 = 0;
			if (fx == (string)obj4)
			{
				if ((object)body == null)
				{
					goto IL_0213;
				}
				if (body.IsTorn((ApePart)0))
				{
					result = true;
					goto IL_0259;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AC8]");
			object obj5 = 0;
			if (fx == (string)obj5)
			{
				if ((object)body == null)
				{
					goto IL_0213;
				}
				bool flag2 = body.IsTorn((ApePart)1);
				bool flag3 = !flag2;
				object obj6 = !flag3;
				result = true;
				if (obj6 != null)
				{
					goto IL_0259;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4AD8]");
			object obj7 = 0;
			if (fx == (string)obj7)
			{
				if ((object)body != null)
				{
					return body.IsTorn((ApePart)2);
				}
				goto IL_0213;
			}
		}
		result = false;
		goto IL_0259;
		IL_0259:
		return result;
		IL_0213:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void PoseToy(float dt)
	{
		//IL_00a4: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0c70: Expected Obj, but got I4
		//IL_0de5: Expected Obj, but got I
		//IL_0e0f: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_0c87: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected I4, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_0520: Expected Obj, but got I4
		//IL_0678: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_0d43: Expected VT, but got Obj
		//IL_05ae: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_07ad: Invalid comparison between F4 and I4
		//IL_07bc: Invalid comparison between F4 and I4
		//IL_07d4: Expected Obj, but got F8
		//IL_07e1: Expected Obj, but got F4
		//IL_0816: Expected Obj, but got I4
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I4
		//IL_09f2: Expected Obj, but got I
		//IL_0a3f: Invalid comparison between F4 and I4
		//IL_0a4e: Invalid comparison between F4 and I4
		//IL_0a66: Expected Obj, but got F8
		//IL_0a73: Expected Obj, but got F4
		//IL_0aa8: Expected Obj, but got I4
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected Obj, but got Unknown
		//IL_06d4: Expected VT, but got F4
		//IL_06f5: Expected VT, but got F4
		//IL_075a: Expected Obj, but got I4
		//IL_0dc2: Expected Obj, but got I4
		//IL_0e3b: Expected Obj, but got I
		//IL_0e4b: Expected Obj, but got I
		//IL_0e6b: Expected Obj, but got I
		//IL_0e8d: Expected Obj, but got I4
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Obj, but got Unknown
		//IL_0741: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_0b03: Invalid comparison between F4 and I4
		//IL_0b14: Expected Obj, but got I4
		//IL_0b1d: Invalid comparison between F4 and I4
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0b42: Expected F8, but got I4
		//IL_0871: Invalid comparison between F4 and I4
		//IL_0882: Expected Obj, but got I4
		//IL_088b: Invalid comparison between F4 and I4
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08b0: Expected F8, but got I4
		//IL_0d5f: Expected VT, but got I4
		//IL_0d6f: Expected F8, but got I
		//IL_0d7d: Expected VT, but got I4
		//IL_09ae: Expected VT, but got I4
		//IL_09b7: Expected VT, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0c29: Expected VT, but got I4
		//IL_0444: Expected Obj, but got I4
		//IL_0c51: Expected VT, but got I4
		//IL_0cc7: Expected VT, but got I4
		//IL_0cc7: Expected VT, but got I4
		UnityEngine.Object obj;
		object obj5;
		if (toyState != 1)
		{
			if (toyState == 2)
			{
				obj = toyRight;
				goto IL_0dd5;
			}
			if (toyState == 3)
			{
				obj = null;
				goto IL_0129;
			}
			obj = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			obj = toyLeft;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v121+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = obj == null;
			bool flag3 = !flag2;
			obj5 = 0;
			if (!flag3)
			{
				goto IL_0129;
			}
			bool flag4 = toyState == 2;
			obj5 = 0;
			if (flag4)
			{
				goto IL_0dd5;
			}
			obj5 = 0;
		}
		bool flag5 = false;
		goto IL_0141;
		IL_0ccc:
		toyOnBody = false;
		return;
		IL_0129:
		flag5 = true;
		goto IL_0141;
		IL_0dd5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = toyRight == null;
		obj5 = 0;
		flag5 = flag7;
		goto IL_0141;
		IL_0141:
		GameObject gameObject = toy.gameObject;
		bool activeSelf = gameObject.activeSelf;
		object obj9 = flag5 ^ activeSelf;
		object obj10 = obj9 & 1;
		bool flag8 = obj10 == null;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			GameObject gameObject2 = toy.gameObject;
			object obj12 = !flag5;
			bool active = (byte)(1 & obj12) != 0;
			gameObject2.SetActive(active);
			obj5 = 0;
		}
		if (flag5)
		{
			toyOnBody = false;
			return;
		}
		Transform transform = toy.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = obj == null;
		bool flag11 = !flag10;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		if (!flag11)
		{
			CosmeticToy cosmeticToy = toy;
			bool flag12 = cosmeticToy.kind != (ToyKind)2;
			obj16 = 0;
			obj17 = null;
			if (!flag12)
			{
				object obj18 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v82+E4]");
				bool flag13 = (nint)0 == 0;
				object obj19 = !flag13;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag14 = handL != null;
				bool flag15 = !flag14;
				obj16 = 0;
				obj17 = null;
				if (!flag15)
				{
					Transform parent = transform.parent;
					Transform transform2 = base.transform;
					object obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v63+E4]");
					bool flag16 = (nint)0 == 0;
					object obj21 = !flag16;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag17 = parent != transform2;
					bool flag18 = !flag17;
					bool flag19 = false;
					Transform transform3 = transform2;
					if (!flag18)
					{
						Transform transform4 = base.transform;
						transform.SetParent(transform4, worldPositionStays: true);
						object obj22 = 0;
						flag19 = true;
						transform3 = transform4;
					}
					object obj23 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v94+E4]");
					bool flag20 = (nint)0 == 0;
					object obj24 = !flag20;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (knucklesL != null)
					{
						Vector3 position = handL.position;
						Vector3 position2 = knucklesL.position;
					}
					else
					{
						Vector3 position3 = handL.position;
					}
					Transform transform5 = base.transform;
					Vector3 forward = transform5.forward;
					toy.Sit((Vector3)0, (Vector3)0);
					goto IL_0ccc;
				}
			}
		}
		object obj25 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v24+E4]");
		bool flag21 = (nint)0 == 0;
		object obj26 = !flag21;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj != null)
		{
			Transform parent2 = transform.parent;
			Transform transform6 = base.transform;
			object obj27 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v58+E4]");
			bool flag22 = (nint)0 == 0;
			object obj28 = !flag22;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parent2 != transform6)
			{
				Transform parent3 = base.transform;
				transform.SetParent(parent3, worldPositionStays: true);
			}
			float palmSide = ((toyState != 1) ? (-1f) : 1f);
			toy.PoseIn((Transform)obj, palmSide);
			goto IL_0ccc;
		}
		bool flag23 = (byte)(~(toyOnBody ? 1u : 0u)) != 0;
		object obj29 = !flag23;
		bool flag24 = false;
		UnityEngine.Object obj30 = null;
		if (obj29 == null)
		{
			toyOnBody = true;
			transform.SetParent(spineBone, worldPositionStays: true);
			Vector3 localPosition = transform.localPosition;
			toyFromPos = (Vector3)dt;
			Quaternion localRotation = transform.localRotation;
			toyFromRot = (Quaternion)dt;
			toyHome = 0f;
			bool flag25 = (byte)(~(toyWasAway ? 1u : 0u)) != 0;
			obj30 = null;
			if (!flag25)
			{
				object obj31 = this + 348;
				obj31 = 1065353216;
				transform.localPosition = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticWearer)+154]");
				double num = 0.0;
				transform.localRotation = (Quaternion)0;
				obj30 = null;
			}
			toyWasAway = false;
			object obj22 = 0;
			flag24 = true;
		}
		bool flag26 = !((double)toyPop < 1.0);
		Vector3 vector = (Vector3)obj30;
		if (!flag26)
		{
			float num2 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num3 = num2 / 0f;
			float num4 = num3 + toyPop;
			float num5 = num4 - 1f;
			bool flag27 = num5 < 0f;
			bool flag28 = num5 == 0f;
			object obj32 = (double)num4 ^ 1.0;
			object obj33 = num4 ^ num5;
			object obj34 = obj32 & obj33;
			bool flag29 = (nint)obj34 < 0;
			bool flag30 = flag27 == flag29;
			object obj35 = !flag28;
			object obj36 = flag30 & obj35;
			object obj37 = ~obj36;
			float num6 = (toyPop = ((obj37 != null) ? num4 : 1f));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
			object obj39 = 0;
			object obj40 = obj38;
			object obj41 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v41+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v46+E4]");
			bool flag31 = (nint)0 == 0;
			object obj43 = !flag31;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag32 = num6 < 0f;
			object obj44 = !flag32;
			bool flag33 = num6 == 0f;
			object obj45 = ~obj44;
			object obj46 = obj45 | flag33;
			double num7 = 0.0;
			if (obj46 == null)
			{
				bool flag34 = !((double)num6 < 1.0);
				num7 = 1.0;
				if (!flag34)
				{
					float num8 = num6 * -10f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
					float num9 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9A4]");
					float num10 = num9 + 0f;
					float num11 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
					float num12 = num11 * 0f;
					float num13 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					float num14 = num13 / 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					float num15 = num8 * num14;
					num7 = (double)num15 + 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v42+14]");
			double num = 0.0 * num7;
			transform.localScale = (Vector3)0;
			vector = (Vector3)0;
		}
		if (!((double)toyHome < 1.0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
		object obj47 = 0;
		float num16 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num17 = num16 / 0f;
		object obj48 = obj47;
		float num18 = num17 + toyHome;
		float num19 = num18 - 1f;
		bool flag35 = num19 < 0f;
		bool flag36 = num19 == 0f;
		object obj49 = (double)num18 ^ 1.0;
		object obj50 = num18 ^ num19;
		object obj51 = obj49 & obj50;
		bool flag37 = (nint)obj51 < 0;
		bool flag38 = flag35 == flag37;
		object obj52 = !flag36;
		object obj53 = flag38 & obj52;
		object obj54 = ~obj53;
		float num20 = (toyHome = ((obj54 != null) ? num18 : 1f));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v31+E4]");
		bool flag39 = (nint)0 == 0;
		object obj55 = !flag39;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag40 = num20 < 0f;
		object obj56 = !flag40;
		bool flag41 = num20 == 0f;
		object obj57 = ~obj56;
		object obj58 = obj57 | flag41;
		double num21 = 0.0;
		if (obj58 == null)
		{
			bool flag42 = !((double)num20 < 1.0);
			num21 = 1.0;
			if (!flag42)
			{
				float num22 = num20 * -10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				float num23 = num20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9A4]");
				float num24 = num23 + 0f;
				float num25 = num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
				float num26 = num25 * 0f;
				float num27 = num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num28 = num27 / 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num29 = num22 * num28;
				num21 = (double)num29 + 1.0;
			}
		}
		transform.localPosition = (Vector3)0;
		Quaternion a = default;
		Quaternion b = default;
		Quaternion quaternion = Quaternion.Internal_SlerpUnclamped(ref a, ref b, (float)num21);
		transform.localRotation = (Quaternion)0;
	}

	public unsafe static Mesh EarsTucked(Mesh head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got Ref
		//IL_029a: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
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
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = Tucked(head);
			bool flag6 = !flag5;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				if ((object)head != null)
				{
					if (!head.isReadable)
					{
						goto IL_0263;
					}
					object obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v18+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v18+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v9+40]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v9+40]");
						bool flag8 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)head, out var value);
						bool flag9 = !flag8;
						object obj13 = (object)(&value);
						System.__Canon _Canon = (System.__Canon)(object)head;
						if (!flag9)
						{
							object obj14 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v42+E4]");
							bool flag10 = (nint)0 == 0;
							object obj15 = !flag10;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = (UnityEngine.Object)(object)value != null;
							bool flag12 = !flag11;
							obj13 = 0;
							_Canon = null;
							if (!flag12)
							{
								return (Mesh)(object)value;
							}
						}
						object obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+E4]");
						bool flag13 = (nint)0 == 0;
						object obj17 = !flag13;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BB8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
						string text = head.name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BC0]");
						object obj19 = 0;
						string text2 = text + (string)obj19;
						Mesh mesh = default;
						if ((object)mesh != null)
						{
							mesh.name = text2;
							mesh.hideFlags = (HideFlags)52;
							Vector3[] vertices = mesh.vertices;
							object obj20 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v18+E4]");
							bool flag14 = (nint)0 == 0;
							object obj21 = !flag14;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							TuckEars(vertices, 1f);
							mesh.vertices = vertices;
							mesh.RecalculateBounds();
							object obj22 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v19+A0]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v20+40]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v20+40]");
								((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)head, (System.__Canon)(object)mesh);
								object obj24 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v21+A0]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v22+48]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v22+48]");
									((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)mesh, (System.__Canon)(object)head);
									return mesh;
								}
							}
						}
					}
				}
				return (Mesh)(object)new NullReferenceException();
			}
		}
		goto IL_0263;
		IL_0263:
		return head;
	}

	public static void TuckEars(Vector3[] v, float scale)
	{
		//IL_003e: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I8
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_079d: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03ec: Expected Obj, but got I
		//IL_03fc: Expected F4, but got I
		//IL_042f: Expected Obj, but got I4
		//IL_0457: Invalid comparison between F4 and I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_07b5: Expected Obj, but got I4
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I
		//IL_04a1: Invalid comparison between F4 and I
		//IL_04b2: Expected Obj, but got I4
		//IL_04d2: Invalid comparison between F4 and I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0523: Expected F4, but got I
		//IL_0533: Invalid comparison between F4 and I
		//IL_0544: Expected Obj, but got I4
		//IL_0564: Invalid comparison between F4 and I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_059e: Expected F4, but got I
		//IL_05ae: Invalid comparison between F4 and I
		//IL_01c9: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I
		//IL_0686: Invalid comparison between F8 and I4
		//IL_0695: Expected F8, but got I4
		//IL_073e: Invalid comparison between F8 and I4
		//IL_074d: Expected F8, but got I4
		//IL_0776: Expected Obj, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got F4
		if (v.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
		object obj = 0;
		object obj2 = v.Length & 0xFFFFFFFFL;
		object obj3 = v + 40;
		float num = scale;
		object obj4 = 0;
		object obj9 = default;
		float num5 = default;
		object obj38 = default;
		object obj40 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj5 = !flag;
			if (obj5 != null)
			{
				break;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X22_v5-8]");
			object obj8 = 0 / obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+18]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X22_v5-8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+18]");
			bool flag3 = num2 < 0;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X22_v5-8]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+18]");
			float num4 = num3 - 0f;
			bool flag4 = num4 == 0f;
			object obj12 = ~obj11;
			object obj13 = obj12 | flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+A0]");
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+1C]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+1C]");
				bool flag6 = num5 < 0f;
				object obj16 = !flag6;
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+1C]");
				float num7 = num6 - 0f;
				bool flag7 = num7 == 0f;
				object obj17 = ~obj16;
				object obj18 = obj17 | flag7;
				num = num5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+A0]");
						obj10 = 0;
					}
					float num8 = (float)obj3 / scale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+20]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+20]");
					bool flag9 = num8 < 0f;
					object obj20 = !flag9;
					float num9 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+20]");
					float num10 = num9 - 0f;
					bool flag10 = num10 == 0f;
					object obj21 = ~obj20;
					object obj22 = obj21 | flag10;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+E4]");
						bool flag11 = (nint)0 == 0;
						object obj23 = !flag11;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj6 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+A0]");
							obj10 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+24]");
						num = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+24]");
						if (num8 < 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v13+E4]");
							bool flag12 = (nint)0 == 0;
							object obj24 = !flag12;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj25 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v18+A0]");
								obj10 = 0;
							}
							bool flag13 = (nint)obj8 < 0;
							object obj26 = obj8 ^ obj8;
							object obj27 = obj8 & obj26;
							bool flag14 = (nint)obj27 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X22_v5-8]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+18]");
							object obj28 = num11 - 0;
							double num12 = (double)obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AADC]");
							double num13 = num12 / 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+28]");
							object obj29 = -0;
							bool flag15 = flag13 == flag14;
							object obj30 = !flag15;
							object obj31 = ~obj30;
							if (obj31 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+28]");
								obj29 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							bool flag16 = num13 < 0.0;
							double num14 = 0.0;
							if (!flag16)
							{
								bool flag17 = !(num13 > 1.0);
								num14 = num13;
								if (!flag17)
								{
									num14 = 1.0;
								}
							}
							double num15 = num14 + num14;
							double num16 = num14 * 3.0;
							double num17 = num14 * num15;
							double num18 = num14 * num17;
							double num19 = num14 * num16;
							double num20 = num19 - num18;
							double num21 = 1.0 - num20;
							double num22 = num21 * 0.0;
							double num23 = num20 + num22;
							bool flag18 = num23 < 0.0;
							double num24 = 0.0;
							if (!flag18)
							{
								bool flag19 = !(num23 > 1.0);
								num24 = num23;
								if (!flag19)
								{
									num24 = 1.0;
								}
							}
							bool flag20 = (nint)obj4 < v.Length;
							object obj32 = !flag20;
							if (obj32 != null)
							{
								break;
							}
							object obj33 = obj8 - obj29;
							float num25 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+30]");
							float num26 = num25 - 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+34]");
							object obj34 = obj33 * 0;
							float num27 = num26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+3C]");
							float num28 = num27 * 0f;
							object obj35 = obj29 + obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+30]");
							float num29 = 0f + num28;
							object obj36 = obj35 - obj8;
							float num30 = num29 - num8;
							object obj37 = obj36 * obj38;
							float num31 = num30 * (float)num24;
							object obj39 = obj8 + obj37;
							float num32 = num8 + num31;
							obj15 = obj39 * obj40;
							num = num32 * scale;
							obj3 = num;
						}
					}
				}
			}
			obj2 = v.Length;
			obj4++;
			obj3 += 12;
			if ((nint)obj4 >= v.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static bool Tucked(Mesh head)
	{
		//IL_0099: Expected I4, but got Obj
		//IL_005a: Unsupported input type for neg.
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		if ((object)head != null)
		{
			Bounds bounds = head.bounds;
			object obj2 = default;
			object obj3 = default;
			object obj = obj2 - obj3;
			Bounds bounds2 = head.bounds;
			object obj5 = default;
			object obj4 = obj5 + obj3;
			object obj6 = 0 - obj;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				obj4 = obj6;
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
			object obj8 = obj7 - 0;
			return (nint)obj8 < 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void KeepEars()
	{
		//IL_0010: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04cb: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I4
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
		bool flag2 = body != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		ApePart apePart = (ApePart)0;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Dismemberment.Part part = body.Find((ApePart)0);
			if (part != null)
			{
				obj4 = 0;
				apePart = (ApePart)0;
				obj5 = part.renderer;
			}
			else
			{
				obj4 = 0;
				apePart = (ApePart)0;
				obj5 = null;
			}
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		Mesh sharedMesh = ((SkinnedMeshRenderer)obj5).sharedMesh;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v6+E4]");
		bool flag7 = (nint)0 == 0;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = sharedMesh == null;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		if (obj11 != null)
		{
			return;
		}
		Mesh sharedMesh2 = ((SkinnedMeshRenderer)obj5).sharedMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v7+E4]");
		bool flag10 = (nint)0 == 0;
		object obj14 = !flag10;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = Tucked(sharedMesh2);
		bool flag12 = earsTucked;
		if (~(earsTucked ? 1u : 0u) == 0)
		{
			bool flag13 = !flag11;
			object obj15 = !flag13;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v32+E4]");
				bool flag14 = (nint)0 == 0;
				object obj18 = !flag14;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Application.isPlaying)
				{
					Mesh sharedMesh3 = ((SkinnedMeshRenderer)obj5).sharedMesh;
					object obj19 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v20+E4]");
					bool flag15 = (nint)0 == 0;
					object obj20 = !flag15;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Mesh sharedMesh4 = EarsTucked(sharedMesh3);
					((SkinnedMeshRenderer)obj5).sharedMesh = sharedMesh4;
					return;
				}
				flag12 = earsTucked;
			}
		}
		bool flag16 = !flag12;
		object obj21 = !flag16;
		object obj22 = !flag11;
		object obj23 = obj21 | obj22;
		object obj24 = obj23 & 1;
		bool flag17 = obj24 == null;
		object obj25 = !flag17;
		if (obj25 == null)
		{
			object obj26 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v24+E4]");
			bool flag18 = (nint)0 == 0;
			object obj27 = !flag18;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v24+A0]");
			object obj28 = 0;
			Mesh sharedMesh5 = ((SkinnedMeshRenderer)obj5).sharedMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+48]");
			if (((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)sharedMesh5, out var value))
			{
				((SkinnedMeshRenderer)obj5).sharedMesh = (Mesh)(object)value;
			}
		}
	}

	private unsafe void OnTorn(ApePart part, GameObject piece)
	{
		//IL_0ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected I4, but got Obj
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Expected Ref, but got Unknown
		//IL_1035: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got I4
		//IL_0e5b: Expected Obj, but got I4
		//IL_0e6c: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I8
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0417: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I4
		//IL_0ff4: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_0c7a: Expected Obj, but got I4
		//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Expected Obj, but got Unknown
		//IL_0d90: Expected Obj, but got I
		//IL_0fcd: Expected Obj, but got I4
		//IL_0d1f: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I4
		//IL_0d57: Expected I, but got Obj
		//IL_0d64: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got I4
		//IL_07da: Expected Obj, but got I
		//IL_0805: Expected Obj, but got I4
		//IL_083f: Expected Obj, but got I
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_0880: Expected I, but got Obj
		//IL_08dd: Expected I, but got Obj
		//IL_0923: Expected Obj, but got I
		//IL_0959: Expected I, but got Obj
		//IL_09a0: Expected Obj, but got I
		//IL_09c4: Expected I, but got Obj
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected I4, but got Unknown
		//IL_0a03: Expected Obj, but got I4
		//IL_0f5c: Expected Obj, but got I4
		//IL_0f69: Expected I, but got Obj
		//IL_0a3c: Expected I, but got Obj
		//IL_0a6b: Expected Obj, but got I
		//IL_0a8b: Expected I, but got Obj
		//IL_0ad8: Expected Obj, but got I
		//IL_0aed: Expected Obj, but got I
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got Unknown
		//IL_0b26: Expected I4, but got Obj
		//IL_0b51: Expected I, but got Obj
		//IL_0b5e: Expected I4, but got Obj
		List<GameObject>[] array = worn;
		bool flag = worn == null;
		TornPiece tornPiece = null;
		GameObject gameObject = piece;
		Enumerator<, > val = (Enumerator<, >)0;
		ApePart apePart2 = default;
		ApePart apePart = apePart2;
		object obj = 109891584;
		List<GameObject>[] array2 = default;
		List<GameObject>[] array3;
		ApePart apePart3;
		if (!flag)
		{
			bool flag2 = array.Length < 6;
			object obj2 = !flag2;
			object obj3 = array.Length - 6;
			bool flag3 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag3;
			tornPiece = null;
			gameObject = piece;
			val = (Enumerator<, >)0;
			apePart = apePart2;
			obj = 109891584;
			if (obj5 != null)
			{
				goto IL_0dcb;
			}
			bool flag4 = (object)array[6] == null;
			tornPiece = null;
			gameObject = piece;
			val = (Enumerator<, >)0;
			apePart = apePart2;
			obj = 109891584;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
				int num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
				obj = 0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)array[6]).GetEnumerator();
				gameObject = piece;
				array = array2;
				Enumerator<, > val2 = default;
				CosmeticWearer cosmeticWearer;
				object obj9;
				Enumerator<, > val3;
				Enumerator<, > val4;
				while (val.MoveNext())
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v83+E4]");
					array = (List<GameObject>[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v83+E4]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = (UnityEngine.Object)(object)array2 != null;
					bool flag7 = !flag6;
					gameObject = null;
					if (flag7)
					{
						continue;
					}
					bool flag8 = array2 == null;
					tornPiece = null;
					gameObject = null;
					cosmeticWearer = this;
					array3 = null;
					val = val2;
					obj9 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					apePart3 = (ApePart)0;
					apePart = apePart2;
					if (!flag8)
					{
						string fx = ((UnityEngine.Object)(object)array2).name;
						bool flag9 = TornFor(fx);
						bool flag10 = !flag9;
						gameObject = null;
						if (!flag10)
						{
							((GameObject)(object)array2).SetActive(false);
							gameObject = null;
						}
						continue;
					}
					goto IL_0de9;
				}
				tornPiece = null;
				object obj10 = 0;
				cosmeticWearer = this;
				array3 = null;
				val = val2;
				obj9 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				CosmeticWearer cosmeticWearer2 = this;
				apePart = apePart2;
				object obj13 = default;
				while (true)
				{
					apePart3 = (ApePart)obj;
					((Enumerator<, >*)val4)->Dispose();
					bool flag11 = obj10 == null;
					object obj11 = !flag11;
					if (obj11 == null)
					{
						bool flag12 = array3 == null;
						object obj12 = !flag12;
						OutOfMemoryException ex = (OutOfMemoryException)val4;
						array = array3;
						if (obj12 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch (apePart3)
					{
					case (ApePart)2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj10 = obj9;
						array3 = (List<GameObject>[])1;
						cosmeticWearer2 = cosmeticWearer;
						array = (List<GameObject>[])1;
						break;
					case (ApePart)1:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj10 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj9 = obj13;
						cosmeticWearer2 = cosmeticWearer;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				bool flag13 = apePart == 0;
				object obj14 = !flag13;
				if (obj14 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BC8]");
				array = (List<GameObject>[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj15 = default;
				bool flag14 = obj15 == null;
				array2 = array3;
				apePart2 = (ApePart)2;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v7+18]");
					array = (List<GameObject>[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v7+18]");
					object obj16 = 0 & 0xFFFFFFFEL;
					bool flag15 = obj16 == null;
					array2 = array3;
					apePart2 = (ApePart)2;
					if (!flag15)
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v7+18]");
						if ((nint)0 < (nint)1)
						{
							return;
						}
						array = (List<GameObject>[])(array & 0xFFFFFFFFL);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BD8]");
						object obj17 = 0;
						object obj18 = 0;
						apePart2 = (ApePart)2;
						object obj32 = default;
						object obj33 = default;
						TornPiece tornPiece3 = default;
						int num3 = default;
						nint num5 = default;
						while (true)
						{
							bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<List<GameObject>[], UIntPtr>(ref array);
							object obj19 = !flag16;
							array2 = array3;
							if (obj19 != null)
							{
								break;
							}
							array = cosmeticWearer2.worn;
							bool flag17 = cosmeticWearer2.worn == null;
							array2 = array3;
							List<System.__Canon> list;
							if (!flag17)
							{
								object obj20 = obj15 + obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X9_v5+20]");
								bool flag18 = (nint)0 < (nint)array.Length;
								object obj21 = !flag18;
								array2 = array3;
								if (obj21 != null)
								{
									break;
								}
								List<GameObject>[] array4 = array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X9_v5+20]");
								array = (List<GameObject>[])(array4 + 0);
								list = (List<System.__Canon>)(object)array[0];
								bool flag19 = (object)array[0] == null;
								array2 = array3;
								if (!flag19)
								{
									if (list._size < 1)
									{
										goto IL_0c50;
									}
									TornPiece tornPiece2 = tornPiece3;
									int num2 = num3;
									nint num4 = num5;
									int num6 = 0;
									ApePart apePart4 = apePart;
									object obj22 = obj;
									while (true)
									{
										System.__Canon _Canon = ((List<System.__Canon>)(object)array[0]).get_Item(num6);
										object obj23 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v22+E4]");
										bool flag20 = (nint)0 == 0;
										object obj24 = !flag20;
										if (obj24 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag21 = (UnityEngine.Object)(object)_Canon == null;
										bool flag22 = !flag21;
										object obj25 = !flag22;
										gameObject = null;
										apePart2 = (ApePart)0;
										Material[] array5;
										if (obj25 == null)
										{
											object obj26 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v24+E4]");
											array = (List<GameObject>[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v24+E4]");
											bool flag23 = (nint)0 == 0;
											object obj27 = !flag23;
											if (obj27 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag24 = piece != null;
											gameObject = (GameObject)obj17;
											System.__Canon _Canon2 = ((List<System.__Canon>)(object)array[0]).get_Item(num6);
											if (flag24)
											{
												bool flag25 = _Canon2 == null;
												tornPiece3 = tornPiece2;
												num3 = num2;
												num5 = num4;
												array2 = array3;
												apePart2 = (ApePart)num6;
												num = num6;
												apePart = apePart4;
												obj = obj22;
												if (flag25)
												{
													break;
												}
												Transform transform = ((GameObject)(object)_Canon2).transform;
												bool flag26 = (object)piece == null;
												tornPiece3 = tornPiece2;
												num3 = num2;
												num5 = num4;
												array2 = array3;
												apePart2 = (ApePart)0;
												num = num6;
												apePart = apePart4;
												obj = obj22;
												if (flag26)
												{
													break;
												}
												Transform parent = piece.transform;
												bool flag27 = (object)transform == null;
												tornPiece3 = tornPiece2;
												num3 = num2;
												num5 = num4;
												array2 = array3;
												apePart2 = (ApePart)0;
												num = num6;
												apePart = apePart4;
												obj = obj22;
												if (flag27)
												{
													break;
												}
												transform.SetParent(parent, worldPositionStays: true);
												System.__Canon go = ((List<System.__Canon>)(object)array[0]).get_Item(num6);
												int layer = piece.layer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
												object obj28 = 0;
												object obj29 = obj28;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v28+E4]");
												bool flag28 = (nint)0 == 0;
												object obj30 = !flag28;
												if (obj30 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Layer((GameObject)(object)go, layer);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BD0]");
												array = (List<GameObject>[])0;
												gameObject = (GameObject)(object)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
												object obj31 = obj32 & 1;
												bool flag29 = obj31 == null;
												num2 = layer;
												num4 = unchecked((nint)null);
												apePart2 = (ApePart)(int)(&tornPiece);
												if (!flag29)
												{
													gameObject = (GameObject)obj17;
													System.__Canon _Canon3 = ((List<System.__Canon>)(object)array[0]).get_Item(num6);
													bool flag30 = _Canon3 == null;
													tornPiece3 = tornPiece2;
													num3 = layer;
													num5 = unchecked((nint)null);
													array2 = array3;
													apePart2 = (ApePart)num6;
													num = num6;
													apePart = apePart4;
													obj = obj22;
													if (flag30)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
													array = (List<GameObject>[])0;
													gameObject = (GameObject)(object)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
													bool flag31 = obj33 == null;
													tornPiece3 = tornPiece2;
													num3 = layer;
													num5 = unchecked((nint)null);
													array2 = array3;
													apePart2 = (ApePart)1;
													num = num6;
													apePart = apePart4;
													obj = obj22;
													if (flag31)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v44+18]");
													array = (List<GameObject>[])0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v44+18]");
													bool flag32 = (nint)0 < (nint)1;
													num2 = layer;
													num4 = unchecked((nint)null);
													apePart2 = (ApePart)1;
													if (!flag32)
													{
														apePart = (ApePart)(obj33 + 32);
														num3 = layer;
														apePart2 = (ApePart)1;
														obj = 0;
														while (true)
														{
															bool flag33 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<List<GameObject>[], UIntPtr>(ref array);
															object obj34 = !flag33;
															tornPiece3 = tornPiece2;
															num5 = unchecked((nint)null);
															array2 = array3;
															num = num6;
															if (obj34 != null)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X21_v6 (ApePart)+v637 @ X20_v6*8]");
															num3 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X21_v6 (ApePart)+v637 @ X20_v6*8]");
															bool flag34 = (nint)0 == 0;
															tornPiece3 = tornPiece2;
															num5 = unchecked((nint)null);
															array2 = array3;
															num = num6;
															if (flag34)
															{
																goto end_IL_0f87;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X21_v6 (ApePart)+v637 @ X20_v6*8]");
															Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
															bool flag35 = (object)tornPiece == null;
															tornPiece3 = tornPiece;
															num5 = unchecked((nint)null);
															array2 = array3;
															apePart2 = (ApePart)0;
															num = num6;
															if (flag35)
															{
																goto end_IL_0f87;
															}
															array5 = tornPiece.Own(sharedMaterials);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X21_v6 (ApePart)+v637 @ X20_v6*8]");
															((Renderer)0).sharedMaterials = array5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v44+18]");
															array = (List<GameObject>[])0;
															obj++;
															object obj35 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v44+18]");
															bool flag36 = (nint)obj35 < 0;
															tornPiece2 = tornPiece;
															gameObject = null;
															apePart2 = (ApePart)array5;
															if (flag36)
															{
																continue;
															}
															goto IL_0b34;
														}
														goto end_IL_0fdb;
													}
												}
											}
											else
											{
												bool flag37 = _Canon2 == null;
												tornPiece3 = tornPiece2;
												num3 = num2;
												num5 = num4;
												array2 = array3;
												apePart2 = (ApePart)num6;
												num = num6;
												apePart = apePart4;
												obj = obj22;
												if (flag37)
												{
													break;
												}
												((GameObject)(object)_Canon2).SetActive(false);
												gameObject = null;
												apePart2 = (ApePart)0;
											}
										}
										goto IL_0bf1;
										IL_0b34:
										tornPiece2 = tornPiece;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X21_v6 (ApePart)+v637 @ X20_v6*8]");
										num2 = 0;
										num4 = unchecked((nint)null);
										gameObject = null;
										apePart2 = (ApePart)array5;
										apePart4 = apePart;
										obj22 = obj;
										goto IL_0bf1;
										IL_0bf1:
										num = num6 + 1;
										bool flag38 = num < list._size;
										tornPiece3 = tornPiece2;
										num3 = num2;
										num5 = num4;
										apePart = apePart4;
										obj = obj22;
										num6 = num;
										if (flag38)
										{
											continue;
										}
										goto IL_0c50;
										continue;
										end_IL_0f87:
										break;
									}
								}
							}
							goto IL_0dbd;
							IL_0c50:
							object obj36 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v9+E4]");
							bool flag39 = (nint)0 == 0;
							object obj37 = !flag39;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag40 = piece != null;
							bool flag41 = !flag40;
							gameObject = null;
							apePart2 = (ApePart)0;
							if (!flag41)
							{
								int version = list._version + 1;
								list._size = 0;
								list._version = version;
								bool flag42 = list._size < 1;
								gameObject = (GameObject)list._size;
								apePart2 = (ApePart)0;
								if (!flag42)
								{
									Array.Clear(list._items, 0, list._size);
									num5 = unchecked((nint)null);
									gameObject = (GameObject)list._size;
									apePart2 = (ApePart)0;
								}
							}
							obj18++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v7+18]");
							array = (List<GameObject>[])0;
							object obj38 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v7+18]");
							bool flag43 = (nint)obj38 < 0;
							cosmeticWearer2 = cosmeticWearer;
							if (!flag43)
							{
								return;
							}
							continue;
							end_IL_0fdb:
							break;
						}
					}
					goto IL_0dcb;
				}
			}
		}
		goto IL_0dbd;
		IL_0dcb:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		array3 = array2;
		apePart3 = apePart2;
		goto IL_0de9;
		IL_0dbd:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0dcb;
		IL_0de9:
		throw new NullReferenceException();
	}

	private void PutBack()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got I4
		//IL_0477: Expected I, but got Obj
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got I8
		//IL_011f: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected I, but got Obj
		List<GameObject>[] array = worn;
		if (worn == null)
		{
			goto IL_0399;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
		object obj3 = 0;
		Enumerator<, > val = (Enumerator<, >)0;
		CosmeticSlot cosmeticSlot = (CosmeticSlot)0;
		UnityEngine.Object obj9 = default;
		byte b;
		nint num;
		while (true)
		{
			if ((int)cosmeticSlot >= array.Length)
			{
				return;
			}
			bool flag = (int)cosmeticSlot < array.Length;
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = array + cosmeticSlot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11+20]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11+20]");
			if ((nint)0 != 0)
			{
				if (list._size >= 1)
				{
					goto IL_00db;
				}
				byte[] array2 = ids;
				if (ids != null)
				{
					bool flag2 = (int)cosmeticSlot < array2.Length;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = (long)cosmeticSlot & 0xFFFFFFFBL;
					bool flag3 = (nint)obj7 == 2;
					UnityEngine.Object obj8 = obj9;
					if (!flag3)
					{
						object obj10 = ids + cosmeticSlot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v17+20]");
						b = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v17+20]");
						bool flag4 = (nint)0 == 0;
						obj8 = obj9;
						if (!flag4)
						{
							CosmeticSlot slot = cosmeticSlot;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v17+20]");
							Put(slot, 0, again: true);
							obj8 = obj9;
							num = (nint)cosmeticSlot;
						}
					}
					array = worn;
					cosmeticSlot++;
					bool flag5 = worn == null;
					object obj11 = !flag5;
					obj9 = obj8;
					if (obj11 != null)
					{
						continue;
					}
				}
			}
			goto IL_0399;
		}
		goto IL_03a7;
		IL_03a7:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_03c4;
		IL_00db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v11+20]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		while (val.MoveNext())
		{
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = obj9 != null;
			bool flag8 = !flag7;
			b = 0;
			if (flag8)
			{
				continue;
			}
			if ((object)obj9 != null)
			{
				((GameObject)obj9).SetActive(true);
				b = 0;
				continue;
			}
			goto IL_0364;
		}
		num = (nint)obj3;
		val.Dispose();
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val4 = (Enumerator<, >)(ref val);
		goto IL_03c4;
		IL_044c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0364:
		NullReferenceException ex2 = new NullReferenceException();
		b = 0;
		val2 = val3;
		val4 = (Enumerator<, >)(ref val);
		num = unchecked((nint)null);
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		goto IL_044c;
		IL_03c4:
		ex3 = new OutOfMemoryException();
		goto IL_044c;
		IL_0399:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_03a7;
	}

	private static void Layer(GameObject go, int layer)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_01f6: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		if ((object)go != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0133;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v5+v55 @ X22_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v5+v55 @ X22_v6*8]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject != null)
						{
							gameObject.layer = layer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+18]");
							obj3 = 0;
							obj5++;
							object obj7 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+18]");
							if ((nint)obj7 < 0)
							{
								continue;
							}
							goto IL_0133;
						}
					}
					goto IL_0239;
				}
				goto IL_0247;
			}
		}
		goto IL_0239;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj9 = default;
		if (obj9 == null)
		{
			goto IL_0239;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj11 = obj9 + 32;
		object obj12 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			object obj13 = !flag2;
			if (obj13 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X21_v7+v129 @ X20_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X21_v7+v129 @ X20_v7*8]");
				((Renderer)0).allowOcclusionWhenDynamic = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+18]");
				obj10 = 0;
				obj12++;
				object obj14 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+18]");
				if ((nint)obj14 >= 0)
				{
					return;
				}
				continue;
			}
			goto IL_0239;
		}
		goto IL_0247;
		IL_0239:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0247;
		IL_0247:
		throw new IndexOutOfRangeException();
	}

	public unsafe static Quaternion OnBone(SkinnedMeshRenderer skin, Transform bone)
	{
		//IL_023c: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004a: Expected I4, but got I8
		//IL_0064: Expected Obj, but got I4
		//IL_0261: Expected VT, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Ref, but got Unknown
		if ((object)skin != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4288]");
			object obj = 0;
			Transform[] bones = skin.bones;
			int num = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)bone);
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj2 = !flag;
			bool flag2 = (byte)num != 0;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj3 = 0;
				Mesh sharedMesh = skin.sharedMesh;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v14+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag2 = sharedMesh == null;
				if (!flag2)
				{
					Mesh sharedMesh2 = skin.sharedMesh;
					if ((object)sharedMesh2 != null)
					{
						Matrix4x4[] bindposes = sharedMesh2.bindposes;
						if (bindposes != null)
						{
							bool flag4 = num < bindposes.Length;
							object obj6 = !flag4;
							if (obj6 != null)
							{
								goto IL_022e;
							}
							object obj7 = bindposes + num;
							Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj7 + 32));
							Matrix4x4 matrix4x2 = default;
							Quaternion rotation = matrix4x2.GetRotation();
							Quaternion rotation2 = default;
							Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
							Transform transform = skin.transform;
							if ((object)transform != null)
							{
								Quaternion localRotation = transform.localRotation;
								return Quaternion.Internal_Inverse(ref rotation2);
							}
						}
					}
					goto IL_0220;
				}
			}
			return (Quaternion)flag2;
		}
		goto IL_0220;
		IL_022e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Quaternion)ex;
		IL_0220:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_022e;
	}

	public static Quaternion OnHead(SkinnedMeshRenderer skin, Transform head)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return OnBone(skin, head);
	}

	public CosmeticWearer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0077: Expected I4, but got I8
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d5: Expected VT, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I8
		//IL_020e: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BF0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BF8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C08]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, System.__Canon)> list = default;
		list._002Ector();
		object obj7 = this + 64;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		eyeSlot = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 120;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 128;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj12 = this + 136;
		obj12 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		headChanged = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, Vector3)> list3 = default;
		list3._002Ector();
		object obj13 = this + 168;
		obj13 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, int)> list4 = default;
		list4._002Ector();
		object obj14 = this + 176;
		obj14 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj16 = this + 184;
		obj16 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		shownFur = (Color)0;
		_ = 0;
		eyeSize = 1f;
		object obj17 = this + 348;
		obj17 = 4575657222473777152L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj18 = 0;
		toyOnBody = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list5 = default;
		list5._002Ector();
		object obj19 = this + 376;
		hiddenBack = (List<GameObject>)(object)list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static CosmeticWearer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I8
		//IL_00e2: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I8
		//IL_01f4: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = default;
		bool flag = obj6 == null;
		object obj7 = 5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
			bool flag2 = (nint)0 == 0;
			obj7 = 5;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C40]");
				object obj8 = 0;
				obj7 = obj8;
				object obj9 = obj6 + 32;
				obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v7-8]");
				object obj10 = 0 & 0xFFFFFFFEL;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C58]");
					object obj11 = 0;
					obj7 = obj11;
					object obj12 = obj6 + 40;
					obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v9-10]");
					bool flag3 = (nint)0 < (nint)2;
					object obj13 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v9-10]");
					object obj14 = -2;
					bool flag4 = obj14 == null;
					object obj15 = ~obj13;
					object obj16 = obj15 | flag4;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C50]");
						object obj17 = 0;
						obj7 = obj17;
						object obj18 = obj6 + 48;
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v11-18]");
						object obj19 = 0 & 0xFFFFFFFCL;
						if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C60]");
							object obj20 = 0;
							obj7 = obj20;
							object obj21 = obj6 + 56;
							obj21 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X20_v13-20]");
							bool flag5 = (nint)0 < (nint)4;
							object obj22 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X20_v13-20]");
							object obj23 = -4;
							bool flag6 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag6;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C48]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BC8]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C38]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C30]");
								object obj29 = 0;
								object obj30 = obj6 + 64;
								obj30 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj31 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v28+A0]");
								object obj32 = (nint)0 + (nint)8;
								obj32 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj33 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v29+10]");
								_ = 0;
								object obj34 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v30+A0]");
								object obj35 = (nint)0 + (nint)16;
								object obj36 = default;
								obj35 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj37 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v31+A0]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D330]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v31+A0]");
								object obj39 = 0;
								_ = 1052266988;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C698]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v31+A0]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BC98]");
								_ = 0;
								_ = 1060320051;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Dictionary<System.__Canon, System.__Canon> dictionary = default;
								dictionary._002Ector();
								object obj41 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v33+A0]");
								object obj42 = (nint)0 + (nint)64;
								obj42 = dictionary;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
								dictionary2._002Ector();
								object obj43 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v34+A0]");
								object obj44 = (nint)0 + (nint)72;
								obj44 = dictionary2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		throw new NullReferenceException();
	}
}
