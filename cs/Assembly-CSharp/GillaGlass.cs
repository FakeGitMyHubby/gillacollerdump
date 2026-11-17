using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class GillaGlass : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass50_0
	{
		public Vector3 foot;

		public GillaFuseBox _003C_003E4__this;

		public Vector3 side;
	}

	private class Shard
	{
		public Transform t;

		public Mesh mesh;

		public MeshRenderer r;

		public Rigidbody body;

		public BoxCollider box;
	}

	public float runSpeed;

	public float regrow;

	public int shardCount;

	public float shardReach;

	public float shardOpacity;

	public float slowTo;

	public AudioClip[] breakSounds;

	private const float ShardLife = default(float);

	private const float ShardFade = default(float);

	private const float BreakFade = default(float);

	private const float FadeSeconds = default(float);

	private static readonly int FadeId;

	private const int ShardLayer = default(int);

	private const float Teleport = default(float);

	private const float Lift = default(float);

	private static readonly Dictionary<int, GillaGlass> panes;

	private static readonly Dictionary<(Material, float), Material> shardMats;

	private static int notShards;

	private BoxCollider solid;

	private MeshRenderer glass;

	private MaterialPropertyBlock block;

	private int id;

	private bool broken;

	private bool tracking;

	private float brokenAt;

	private float fade;

	private GillaGoreAssets.Track head;

	private GillaGoreAssets.Track body;

	private GillaGoreAssets.Track handL;

	private GillaGoreAssets.Track handR;

	private Shard[] shards;

	private const float Smooth = default(float);

	private const float ClearGap = default(float);

	private const float ClearFor = default(float);

	private string LastBreak__BackingField;

	public string LastBreak
	{
		get
		{
			return LastBreak__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 224;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool IsBroken => broken;

	public int ShardsOut
	{
		get
		{
			//IL_0033: Expected Obj, but got I4
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected Obj, but got Unknown
			//IL_0074: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I4
			//IL_0184: Expected I4, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_00e4: Expected Obj, but got I
			//IL_011c: Expected Obj, but got I4
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			Shard[] array = shards;
			int num;
			if (shards != null)
			{
				object obj = array.Length;
				if (array.Length >= 1)
				{
					object obj2 = shards + 32;
					num = 0;
					object obj3 = 0;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj4 = !flag;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v3+v94 @ X21_v4*8]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v3+v94 @ X21_v4*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
									GameObject gameObject = ((Component)0).gameObject;
									if ((object)gameObject != null)
									{
										bool activeSelf = gameObject.activeSelf;
										obj = array.Length;
										obj3++;
										num += (activeSelf ? 1 : 0);
										if ((nint)obj3 >= array.Length)
										{
											break;
										}
										continue;
									}
								}
							}
							NullReferenceException ex = new NullReferenceException();
						}
						IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
						return (int)ex2;
					}
					goto IL_01ab;
				}
			}
			num = 0;
			goto IL_01ab;
			IL_01ab:
			return num;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I8
		//IL_0156: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I8
		//IL_0258: Expected Obj, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_029a: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj4 = this + 64;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj6 = this + 72;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+18]");
		object obj11 = 0 & 0x80000000L;
		if (obj11 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
			object obj13 = 0;
			object obj14 = array + 32;
			obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X20_v8-8]");
			object obj15 = 0 & 0xFFFFFFFEL;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
				object obj16 = 0;
				object obj17 = array + 40;
				obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X20_v10-10]");
				bool flag2 = (nint)0 < (nint)2;
				object obj18 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X20_v10-10]");
				object obj19 = -2;
				bool flag3 = obj19 == null;
				object obj20 = ~obj18;
				object obj21 = obj20 | flag3;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
					object obj22 = 0;
					object obj23 = array + 48;
					obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X20_v12-18]");
					object obj24 = 0 & 0xFFFFFFFCL;
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
						object obj25 = 0;
						object obj26 = array + 56;
						obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v14-20]");
						bool flag4 = (nint)0 < (nint)4;
						object obj27 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v14-20]");
						object obj28 = -4;
						bool flag5 = obj28 == null;
						object obj29 = ~obj27;
						object obj30 = obj29 | flag5;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
							object obj31 = 0;
							object obj32 = array + 64;
							obj32 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int mask = LayerMask.GetMask(array);
							object obj33 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v27+E4]");
							bool flag6 = (nint)0 == 0;
							object obj34 = !flag6;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v27+A0]");
							object obj35 = 0;
							int num = mask | 4;
							return;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj = 0;
		int num = StableId();
		object obj2 = obj;
		id = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+8]");
		((Dictionary<int, System.__Canon>)0).set_Item(id, (System.__Canon)(object)this);
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1078]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+8]");
		if (!((Dictionary<int, System.__Canon>)0).TryGetValue(id, out var value))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)(object)value == this)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v13+8]");
			bool flag4 = ((Dictionary<int, System.__Canon>)0).Remove(id);
		}
	}

	private void OnDestroy()
	{
		DropShards();
	}

	private void DropShards()
	{
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I
		//IL_01f5: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_0292: Expected I, but got Obj
		object obj = this + 216;
		object obj2 = obj;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X21_v1+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X21_v1+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj4 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			object obj7 = default;
			object obj6 = obj7;
			object obj8 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v4+v133 @ X22_v5*8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v4+v133 @ X22_v5*8]");
					if ((nint)0 != 0)
					{
						object obj11 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v10+E4]");
						bool flag2 = (nint)0 == 0;
						object obj12 = !flag2;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+18]");
						bool flag3 = (UnityEngine.Object)0 != null;
						bool flag4 = !flag3;
						UnityEngine.Object obj13 = null;
						if (!flag4)
						{
							object obj14 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v27+E4]");
							bool flag5 = (nint)0 == 0;
							object obj15 = !flag5;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+18]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
							obj13 = null;
						}
						object obj16 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v15+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
						bool flag7 = (UnityEngine.Object)0 != null;
						bool flag8 = !flag7;
						nint num = unchecked((nint)null);
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
							if ((nint)0 == 0)
							{
								goto IL_02f7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
							GameObject obj18 = ((Component)0).gameObject;
							object obj19 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v13+E4]");
							bool flag9 = (nint)0 == 0;
							object obj20 = !flag9;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy(obj18);
							num = unchecked((nint)null);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X21_v1+18]");
						obj3 = 0;
						obj8++;
						object obj21 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X21_v1+18]");
						bool flag10 = (nint)obj21 < 0;
						obj6 = 0;
						if (!flag10)
						{
							break;
						}
						continue;
					}
					goto IL_02f7;
				}
				goto IL_0305;
				IL_02f7:
				NullReferenceException ex = new NullReferenceException();
				goto IL_0305;
				IL_0305:
				throw new IndexOutOfRangeException();
			}
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private int StableId()
	{
		//IL_0010: Expected Obj, but got I
		//IL_062a: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I
		//IL_0660: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_061a: Expected I4, but got Obj
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0675: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I4
		//IL_0214: Invalid comparison between Obj and F8
		//IL_0115: Expected Obj, but got I4
		//IL_01d6: Invalid comparison between Obj and F8
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06e4: Expected Obj, but got I4
		//IL_02c4: Expected I4, but got F8
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_073e: Expected Obj, but got I4
		//IL_038e: Invalid comparison between Obj and F8
		//IL_0350: Invalid comparison between Obj and F8
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_0783: Expected Obj, but got I4
		//IL_043e: Expected I4, but got F8
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_07dd: Expected Obj, but got I4
		//IL_0508: Invalid comparison between Obj and F8
		//IL_04ca: Invalid comparison between Obj and F8
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_0822: Expected Obj, but got I4
		//IL_059e: Expected I4, but got F8
		//IL_05eb: Expected I4, but got I8
		//IL_0891: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Transform parent = base.transform;
		object obj4 = 0;
		object obj8 = default;
		double num3 = default;
		object obj15 = default;
		string text2 = default;
		object obj21 = default;
		while (true)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parent != null)
			{
				if ((object)parent == null)
				{
					break;
				}
				string text = parent.name;
				string value = (string)obj3 + text;
				if (stringBuilder == null)
				{
					break;
				}
				StringBuilder stringBuilder2 = stringBuilder.Insert(0, value);
				parent = parent.parent;
				obj4 = 0;
				continue;
			}
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				break;
			}
			Vector3 position = transform.position;
			if (stringBuilder == null)
			{
				break;
			}
			StringBuilder stringBuilder3 = stringBuilder.Append('@');
			object obj7 = obj8 * 1120403456;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num;
			double num2;
			double num4;
			if ((nint)obj7 < 0)
			{
				if (obj7 == (object)(-0.5))
				{
					num = -1.0;
					num2 = num3;
					goto IL_06ad;
				}
				num2 = (double)obj7 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num4 = -0.5;
			}
			else
			{
				if (obj7 == (object)0.5)
				{
					num = 1.0;
					num2 = num3;
					goto IL_06ad;
				}
				num2 = (double)obj7 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num4 = 0.5;
			}
			goto IL_06f7;
			IL_074c:
			double num6;
			double num7;
			double num5 = num6 + num7;
			object obj12 = num6 & 1;
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			if (obj13 != null)
			{
				num6 = num5;
			}
			goto IL_0796;
			IL_0796:
			StringBuilder stringBuilder4;
			if (stringBuilder4 == null)
			{
				break;
			}
			StringBuilder stringBuilder5 = stringBuilder4.Append((int)num6);
			if (stringBuilder5 == null)
			{
				break;
			}
			StringBuilder stringBuilder6 = stringBuilder5.Append(',');
			object obj14 = obj15 * 1120403456;
			object obj16 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num8;
			double num9;
			if ((nint)obj14 < 0)
			{
				if (obj14 == (object)(-0.5))
				{
					num8 = -1.0;
					num9 = num3;
					goto IL_07eb;
				}
				num9 = (double)obj14 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			}
			else
			{
				if (obj14 == (object)0.5)
				{
					num8 = 1.0;
					num9 = num3;
					goto IL_07eb;
				}
				num9 = (double)obj14 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			}
			goto IL_0835;
			IL_06ad:
			num4 = num2 + num;
			object obj18 = num2 & 1;
			bool flag5 = obj18 == null;
			object obj19 = !flag5;
			if (obj19 != null)
			{
				num2 = num4;
			}
			goto IL_06f7;
			IL_0835:
			if (stringBuilder6 == null)
			{
				break;
			}
			StringBuilder stringBuilder7 = stringBuilder6.Append((int)num9);
			((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
			if (text2 == null)
			{
				break;
			}
			bool flag6 = text2._stringLength < 1;
			int result = -2128831035;
			if (!flag6)
			{
				int num10 = 0;
				do
				{
					char c = text2.get_Chars(num10);
					int num11 = c & 0xFFFF;
					num10++;
					int num12 = (int)(0x811C9DC5L ^ num11);
					result = num12 * 16777619;
				}
				while (num10 < text2._stringLength);
			}
			return result;
			IL_06f7:
			if (stringBuilder3 == null)
			{
				break;
			}
			StringBuilder stringBuilder8 = stringBuilder3.Append((int)num2);
			if (stringBuilder8 == null)
			{
				break;
			}
			stringBuilder4 = stringBuilder8.Append(',');
			object obj20 = obj21 * 1120403456;
			object obj22 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v27+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			if ((nint)obj20 < 0)
			{
				if (obj20 == (object)(-0.5))
				{
					num7 = -1.0;
					num6 = num3;
					goto IL_074c;
				}
				num6 = (double)obj20 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num5 = -0.5;
			}
			else
			{
				if (obj20 == (object)0.5)
				{
					num7 = 1.0;
					num6 = num3;
					goto IL_074c;
				}
				num6 = (double)obj20 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num5 = 0.5;
			}
			goto IL_0796;
			IL_07eb:
			double num13 = num9 + num8;
			object obj24 = num9 & 1;
			bool flag8 = obj24 == null;
			object obj25 = !flag8;
			if (obj25 != null)
			{
				num9 = num13;
			}
			goto IL_0835;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private unsafe void Update()
	{
		//IL_0017: Invalid comparison between F4 and I4
		//IL_0046: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_08f5: Expected Obj, but got I4
		//IL_0970: Expected Obj, but got I
		//IL_0980: Expected Obj, but got I
		//IL_09b2: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_0274: Expected VT, but got I4
		//IL_0288: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_02e5: Expected VT, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_02ff: Expected VT, but got I4
		//IL_02ff: Expected Obj, but got I
		//IL_06b9: Expected VT, but got F4
		//IL_06de: Expected VT, but got F4
		//IL_06ff: Expected VT, but got I
		//IL_073c: Expected VT, but got I
		//IL_0333: Invalid comparison between F4 and I4
		//IL_0344: Expected Obj, but got I4
		//IL_034d: Invalid comparison between F4 and I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Ref, but got Unknown
		//IL_0414: Expected VT, but got I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Ref, but got Unknown
		//IL_0435: Expected VT, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Ref, but got Unknown
		//IL_046b: Expected F4, but got I
		//IL_046b: Expected F4, but got I
		//IL_046b: Expected VT, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Ref, but got Unknown
		//IL_049c: Expected F4, but got I
		//IL_049c: Expected F4, but got I
		//IL_049c: Expected VT, but got I4
		//IL_04c0: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Ref, but got Unknown
		//IL_0557: Expected Obj, but got I
		//IL_0571: Expected Obj, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Ref, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Ref, but got Unknown
		//IL_05ec: Expected F4, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Ref, but got Unknown
		//IL_0622: Expected F4, but got I
		//IL_0630: Expected VT, but got Ref
		//IL_0684: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I
		//IL_07be: Expected Obj, but got I
		//IL_0926: Expected VT, but got I4
		//IL_07f0: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I
		//IL_0952: Expected I4, but got Obj
		//IL_095b: Expected VT, but got I4
		//IL_086c: Expected Obj, but got I
		//IL_0886: Expected Obj, but got I
		//IL_0828: Expected I4, but got Obj
		//IL_0831: Expected VT, but got I4
		//IL_083a: Expected VT, but got I4
		//IL_08ad: Expected VT, but got I4
		if (~(broken ? 1u : 0u) == 0)
		{
			WhileBroken();
			return;
		}
		if (!(fade < 0f))
		{
			FadeIn();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v7+A0]");
		object obj7 = 0;
		object obj8 = obj6;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj7 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		bool left;
		Vector3 push;
		Vector3 at5;
		string text3;
		if (obj11 == null)
		{
			object obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+20]");
			bool flag7 = (UnityEngine.Object)0 == null;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				object obj15 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+28]");
				if (!((UnityEngine.Object)0 == null))
				{
					float deltaTime = Time.deltaTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+20]");
					Transform transform = ((Component)0).transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+28]");
					Transform transform2 = ((Component)0).transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+28]");
					Vector3 center = ((CapsuleCollider)0).center;
					Vector3 vector = transform2.TransformPoint((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
					object obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v33+E4]");
					bool flag10 = (nint)0 == 0;
					object obj19 = !flag10;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+48]");
					Vector3 vector2 = Hand((Transform)0, (Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+40]");
					Vector3 vector3 = Hand((Transform)0, (Vector3)0);
					float time = Time.time;
					if (~(tracking ? 1u : 0u) == 0)
					{
						bool flag11 = deltaTime < 0f;
						object obj20 = !flag11;
						bool flag12 = deltaTime == 0f;
						object obj21 = ~obj20;
						object obj22 = obj21 | flag12;
						if (obj22 == null)
						{
							float num = deltaTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD90]");
							float num2 = num / 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
							object obj23 = obj17;
							double num3 = 1.0 - (double)num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v41+E4]");
							bool flag13 = (nint)0 == 0;
							object obj24 = !flag13;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float k = default;
							Follow(ref *(GillaGoreAssets.Track*)(this + 104), (Vector3)0, deltaTime, k);
							Follow(ref *(GillaGoreAssets.Track*)(this + 132), (Vector3)0, deltaTime, k);
							ref GillaGoreAssets.Track t = ref *(GillaGoreAssets.Track*)(this + 160);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+E8]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+EC]");
							Follow(ref t, (Vector3)0, num4, 0f);
							ref GillaGoreAssets.Track t2 = ref *(GillaGoreAssets.Track*)(this + 188);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+DC]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+E0]");
							Follow(ref t2, (Vector3)0, num5, 0f);
							float fixedDeltaTime = Time.fixedDeltaTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+20]");
							float radius = ((SphereCollider)0).radius;
							float num6 = deltaTime + deltaTime;
							float ahead = num6 + fixedDeltaTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+20]");
							Transform t3 = ((Component)0).transform;
							float num7 = Biggest(t3);
							float r = radius * num7;
							bool flag14 = Meets(ref *(GillaGoreAssets.Track*)(this + 104), r, ahead, time, out var _);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+28]");
							float radius2 = ((CapsuleCollider)0).radius;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+28]");
							Transform t4 = ((Component)0).transform;
							float num8 = Biggest(t4);
							float r2 = radius2 * num8;
							bool flag15 = Meets(ref *(GillaGoreAssets.Track*)(this + 132), r2, ahead, time, out var _);
							ref GillaGoreAssets.Track t5 = ref *(GillaGoreAssets.Track*)(this + 160);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+98]");
							bool flag16 = Meets(ref t5, 0f, ahead, time, out var _);
							ref GillaGoreAssets.Track t6 = ref *(GillaGoreAssets.Track*)(this + 188);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+98]");
							bool flag17 = Meets(ref t6, 0f, ahead, time, out var _);
							object obj25 = default;
							float num9 = Into((GillaGoreAssets.Track)(&obj25));
							if (num9 < runSpeed)
							{
								return;
							}
							object format;
							if (flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1088]");
								format = 0;
							}
							else
							{
								if (!flag15)
								{
									if (flag16)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1090]");
										object format2 = 0;
										object arg = default;
										string text = string.Format((string)format2, arg);
										left = (byte)(int)text != 0;
										push = (Vector3)0;
										at5 = (Vector3)1;
										goto IL_092b;
									}
									if (flag17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
										object obj28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1098]");
										object format3 = 0;
										object arg2 = default;
										string text2 = string.Format((string)format3, arg2);
										text3 = text2;
										at5 = (Vector3)0;
										goto IL_094a;
									}
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1080]");
								format = 0;
							}
							object arg3 = default;
							string text4 = string.Format((string)format, arg3);
							text3 = text4;
							at5 = (Vector3)1;
							goto IL_094a;
						}
					}
					_ = 0;
					_ = 0;
					head = (GillaGoreAssets.Track)deltaTime;
					_ = 0;
					_ = 0;
					body = (GillaGoreAssets.Track)deltaTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+E8]");
					handL = (GillaGoreAssets.Track)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+EC]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+F0]");
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+DC]");
					handR = (GillaGoreAssets.Track)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+E0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X20_v4 (UnityEngine.Object)+E4]");
					_ = 0;
					_ = 0;
					_ = 0;
					tracking = true;
					return;
				}
			}
		}
		tracking = false;
		return;
		IL_092b:
		bool right = default;
		string how = default;
		BreakByYou(at5, push, left, right, how);
		return;
		IL_094a:
		left = (byte)(int)text3 != 0;
		push = (Vector3)1;
		goto IL_092b;
	}

	private unsafe static void Follow(ref GillaGoreAssets.Track t, Vector3 now, float dt, float k)
	{
		//IL_0012: Expected Ref, but got F4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_00a6: Invalid comparison between F4 and I
		//IL_00cb: Invalid comparison between F8 and I4
		//IL_00da: Expected F8, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_0156: Expected F4, but got Obj
		//IL_0166: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		ref GillaGoreAssets.Track reference = ref *(GillaGoreAssets.Track*)dt;
		float num = dt - (float)t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X0 (Track&)+8]");
		object obj2 = default;
		object obj = obj2 - 0;
		object obj3 = default;
		float num2 = num / (float)obj3;
		object obj5 = default;
		object obj4 = obj / obj5;
		float num3 = num2 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj6 = obj4 * obj4;
		float num4 = num3 + (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE10]");
		if (!(num4 > 0f))
		{
			double num5 = default;
			bool flag = num5 < 0.0;
			double num6 = 0.0;
			if (!flag)
			{
				bool flag2 = !(num5 > 1.0);
				num6 = num5;
				if (!flag2)
				{
					num6 = 1.0;
				}
			}
			float num7 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X0 (Track&)+C]");
			float num8 = num7 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X0 (Track&)+14]");
			object obj7 = obj4 - 0;
			object obj8 = default;
			float num9 = num8 * (float)obj8;
			double num10 = (double)obj7 * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X0 (Track&)+C]");
			float num11 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X0 (Track&)+14]");
			double num12 = 0.0 + num10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+A0]");
			object obj11 = 0;
			float num11 = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8+8]");
			double num12 = 0.0;
		}
	}

	private static Vector3 Hand(Transform controller, Vector3 offset)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_00fb: Expected VT, but got I4
		//IL_00b6: Expected VT, but got Obj
		//IL_009a: Expected VT, but got I4
		//IL_009a: Expected VT, but got I4
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
		bool flag2 = controller != null;
		if (flag2)
		{
			if ((object)controller != null)
			{
				Vector3 position = controller.position;
				Quaternion rotation = controller.rotation;
				return (Quaternion)0 * (Vector3)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		return (Vector3)flag2;
	}

	private static float Biggest(Transform t)
	{
		//IL_0015: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I8
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01fa: Invalid comparison between F4 and I4
		//IL_0209: Invalid comparison between F4 and I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0183: Expected F4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Vector3 lossyScale = t.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
				bool flag = (nint)0 < (nint)2;
				object obj2 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
				object obj3 = -2;
				bool flag2 = obj3 == null;
				object obj4 = ~obj2;
				object obj5 = obj4 | flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
					float num = default;
					if ((nint)0 >= (nint)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+18]");
						object obj6 = 0 & 0xFFFFFFFFL;
						object obj8 = default;
						object obj7 = obj8 + 36;
						object obj9 = obj6 - 1;
						float num2 = default;
						num = num2;
						do
						{
							obj7 += 4;
							float num3 = (float)obj7 - num;
							bool flag3 = num3 < 0f;
							bool flag4 = num3 == 0f;
							object obj10 = obj7 ^ num;
							object obj11 = obj7 ^ num3;
							object obj12 = obj10 & obj11;
							bool flag5 = (nint)obj12 < 0;
							bool flag6 = flag3 == flag5;
							object obj13 = !flag4;
							object obj14 = flag6 & obj13;
							object obj15 = ~obj14;
							if (obj15 == null)
							{
								num = (float)obj7;
							}
							obj9--;
						}
						while ((nint)obj9 != 1);
					}
					return num;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void Frame(out Vector3 c, out Vector3 u, out Vector3 w, out Vector3 n, out float hw, out float hh, out float ht)
	{
		//IL_003e: Expected VT, but got I4
		//IL_0102: Expected Ref, but got F8
		//IL_0149: Expected Ref, but got F8
		//IL_0190: Expected Ref, but got F8
		Transform transform = base.transform;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 center = solid.center;
		Vector3 vector = transform.TransformPoint((Vector3)0);
		object obj = default;
		ref Vector3 reference = ref *(Vector3*)obj;
		Vector3 right = transform.right;
		ref Vector3 reference2 = ref *(Vector3*)obj;
		Vector3 up = transform.up;
		ref Vector3 reference3 = ref *(Vector3*)obj;
		Vector3 forward = transform.forward;
		ref Vector3 reference4 = ref *(Vector3*)obj;
		Vector3 size = solid.size;
		object obj2 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num = (double)obj2 * 0.5;
		ref float reference5 = ref *(float*)num;
		Vector3 size2 = solid.size;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num2 = (double)obj3 * 0.5;
		ref float reference6 = ref *(float*)num2;
		Vector3 size3 = solid.size;
		object obj6 = default;
		object obj5 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num3 = (double)obj5 * 0.5;
		ref float reference7 = ref *(float*)num3;
	}

	private unsafe bool Meets(ref GillaGoreAssets.Track t, float r, float ahead, float now, out Vector3 at)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_00a8: Invalid comparison between Obj and F4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I
		//IL_010e: Invalid comparison between Obj and F4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_01b1: Invalid comparison between F4 and I
		//IL_01ea: Expected F4, but got I
		//IL_0385: Invalid comparison between F4 and I
		//IL_023d: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got F8
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0440: Expected Obj, but got I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got I4
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		Frame(out var _, out var _, out var _, out var _, out var hw, out var _, out var _);
		float num = r * 0.5f;
		object obj = t * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+8]");
		object obj2 = (nint)0 * (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num2 = (float)obj2 + (float)obj;
		float num3 = num + hw;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3))
		{
			object obj3 = t * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+8]");
			object obj4 = (nint)0 * (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj5 = obj4 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			object obj6 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
			{
				object obj7 = 0 * t;
				object obj9 = default;
				object obj10 = default;
				object obj8 = obj9 * obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+8]");
				object obj11 = (nint)0 * (nint)0;
				object obj12 = obj7 + obj8;
				object obj13 = obj11 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num4 = (float)obj12 - r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				float num5;
				if (num4 > 0f)
				{
					num5 = now;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+18]");
					num5 = 0f;
				}
				float num6 = now - num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				if (!(num6 > 0f))
				{
					bool flag = (nint)obj13 < 0;
					object obj14 = obj13 ^ obj13;
					object obj15 = obj13 & obj14;
					bool flag2 = (nint)obj15 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+C]");
					object obj16 = (nint)0 * (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+10]");
					object obj17 = obj9 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (Track&)+14]");
					object obj18 = (nint)0 * (nint)0;
					object obj19 = obj16 + obj17;
					bool flag3 = flag == flag2;
					object obj20 = !flag3;
					object obj21 = ~obj20;
					double num7 = ((obj21 != null) ? 1.0 : (-1.0));
					object obj22 = obj18 + obj19;
					double num8 = num7 * (double)obj22;
					object obj23 = 0.0 - num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					float num9 = (float)obj23 * ahead;
					float num10 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					float num11 = num10 + 0f;
					if (!(num4 > num11))
					{
						float num12 = 0f - hw;
						if (!(num2 < num12))
						{
							bool flag4 = !(num2 > hw);
							num12 = num2;
							if (!flag4)
							{
								num12 = hw;
							}
						}
						object obj25 = default;
						object obj24 = 0 * obj25;
						float num13 = 0f * num12;
						bool flag5 = (nint)obj5 < 0;
						object obj26 = 0;
						if (!flag5)
						{
							bool flag6 = (nint)obj5 <= 0;
							obj26 = obj5;
							if (!flag6)
							{
								obj26 = 0;
							}
						}
						object obj28 = default;
						object obj27 = 0 * obj28;
						object obj29 = 0 * obj26;
						object obj30 = obj24 + obj27;
						float num14 = num13 + (float)obj29;
						reference = ref *(Vector3*)obj30;
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	private float Into(GillaGoreAssets.Track t)
	{
		//IL_004d: Expected VT, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		Transform transform = base.transform;
		Vector3 forward = transform.forward;
		Transform transform2 = base.transform;
		Vector3 center = solid.center;
		Vector3 vector = transform2.TransformPoint((Vector3)0);
		object obj2 = default;
		object obj = t.at - obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (GillaGoreAssets+Track)+4]");
		object obj4 = default;
		object obj3 = 0 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (GillaGoreAssets+Track)+8]");
		object obj6 = default;
		object obj5 = 0 - obj6;
		object obj7 = obj2 * obj;
		object obj8 = obj4 * obj3;
		object obj9 = obj7 + obj8;
		object obj10 = obj6 * obj5;
		object obj11 = obj2 * t.v;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (GillaGoreAssets+Track)+10]");
		object obj12 = obj4 * 0;
		object obj13 = obj10 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [t @ X1 (GillaGoreAssets+Track)+14]");
		object obj14 = obj6 * 0;
		object obj15 = obj11 + obj12;
		bool flag = (nint)obj13 < 0;
		object obj16 = obj13 ^ obj13;
		object obj17 = obj13 & obj16;
		bool flag2 = (nint)obj17 < 0;
		bool flag3 = flag == flag2;
		object obj18 = !flag3;
		object obj19 = ~obj18;
		double num = ((obj19 != null) ? 1.0 : (-1.0));
		object obj20 = obj14 + obj15;
		double num2 = num * (double)obj20;
		return (float)(0.0 - num2);
	}

	public unsafe void Click(Vector3 at, Vector3 push)
	{
		//IL_0233: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0040: Expected VT, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_0217: Expected VT, but got I4
		//IL_0217: Expected VT, but got Ref
		bool flag = (byte)(~(broken ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AB0]");
		object obj2 = 0;
		object obj3 = this + 224;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Break((Vector3)obj2, push);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v11+A0]");
		object obj10 = 0;
		object obj11 = obj9;
		UnityEngine.Object obj12 = (UnityEngine.Object)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj10 != null))
		{
			return;
		}
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X20_v6 (UnityEngine.Object)+40]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X20_v6 (UnityEngine.Object)+40]");
		object obj16 = 0;
		object obj17 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X21_v6+30]");
		if ((bool)(UnityEngine.Object)0)
		{
			ArgumentNullException ex = new ArgumentNullException();
			object obj19 = ex & 1;
			if (obj19 != null)
			{
				object obj20 = default;
				RpcInfo info = default;
				((NetworkApe)obj10).RPC_BreakGlass(id, (Vector3)(&obj20), (Vector3)0, info);
			}
		}
	}

	public unsafe void Struck(Vector3 at, Vector3 push)
	{
		//IL_0299: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0040: Expected VT, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_027d: Expected VT, but got I4
		//IL_027d: Expected VT, but got Ref
		bool flag = (byte)(~(broken ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10A0]");
		object obj2 = 0;
		object obj3 = this + 224;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Break((Vector3)obj2, push);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Report((GillaQuests.Stat)5, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v14+A0]");
		object obj13 = 0;
		object obj14 = obj12;
		UnityEngine.Object obj15 = (UnityEngine.Object)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj13 != null))
		{
			return;
		}
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X20_v6 (UnityEngine.Object)+40]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X20_v6 (UnityEngine.Object)+40]");
		object obj19 = 0;
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v25+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v6+30]");
		if ((bool)(UnityEngine.Object)0)
		{
			ArgumentNullException ex = new ArgumentNullException();
			object obj22 = ex & 1;
			if (obj22 != null)
			{
				object obj23 = default;
				RpcInfo info = default;
				((NetworkApe)obj13).RPC_BreakGlass(id, (Vector3)(&obj23), (Vector3)0, info);
			}
		}
	}

	private unsafe void BreakByYou(Vector3 at, Vector3 push, bool left, bool right, string how)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I4
		//IL_0423: Expected VT, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I
		//IL_054d: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03e2: Expected VT, but got I4
		//IL_03e2: Expected VT, but got I4
		//IL_03e2: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj2 = 0;
		object obj3 = this + 224;
		obj3 = left;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Break((Vector3)left, push);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Report((GillaQuests.Stat)5, 1);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj2;
		}
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v13+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj12 != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj14 = null;
		if (!flag6)
		{
			((Player)obj12).Slow(slowTo);
			obj14 = null;
		}
		object obj15 = at & 1;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v60+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Buzz((XRNode)4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj19 = 0;
		object obj20 = push & 1;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v56+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Buzz((XRNode)5);
		}
		object obj24 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v26+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj19;
		}
		object obj28 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v26+A0]");
		object obj29 = 0;
		UnityEngine.Object obj30 = (UnityEngine.Object)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj29 != null))
		{
			return;
		}
		object obj32 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v31+E4]");
		bool flag12 = (nint)0 == 0;
		object obj33 = !flag12;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v4 (UnityEngine.Object)+40]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v4 (UnityEngine.Object)+40]");
		object obj34 = 0;
		object obj35 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v36+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X21_v8+30]");
		if ((bool)(UnityEngine.Object)0)
		{
			ArgumentNullException ex = new ArgumentNullException();
			object obj37 = ex & 1;
			if (obj37 != null)
			{
				object obj38 = default;
				((NetworkApe)obj29).RPC_BreakGlass(id, (Vector3)(&obj38), (Vector3)0, (RpcInfo)right);
			}
		}
	}

	private static void Buzz(XRNode node)
	{
		//IL_0062: Expected F4, but got I
		//IL_0062: Expected F4, but got I
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			bool flag = inputDevice.SendHapticImpulse(0u, num, 0f);
		}
	}

	public unsafe static void BrokenByOther(int pane, Vector3 at, Vector3 push)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0078: Expected VT, but got Ref
		//IL_0078: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+8]");
		if (((Dictionary<int, System.__Canon>)0).TryGetValue(pane, out var value))
		{
			((GillaGlass)(object)value).Break((Vector3)pane, (Vector3)(&value));
		}
	}

	public void Break(Vector3 at, Vector3 push)
	{
		//IL_0084: Expected VT, but got I4
		//IL_0084: Expected VT, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00f7: Expected VT, but got I4
		if (~(broken ? 1u : 0u) != 0)
		{
			broken = true;
			float time = Time.time;
			brokenAt = time;
			solid.enabled = false;
			glass.enabled = true;
			fade = -1f;
			SetFade(glass, 1f);
			Shatter((Vector3)glass, (Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float volume = default;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play(breakSounds, (Vector3)0, volume, pitchMin, pitchMax);
		}
	}

	private void WhileBroken()
	{
		//IL_00a4: Invalid comparison between F4 and I4
		//IL_017f: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I4
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05d2: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_06fd: Expected Obj, but got I4
		//IL_02b3: Invalid comparison between F8 and I4
		//IL_02c4: Expected Obj, but got I4
		//IL_02cd: Invalid comparison between F8 and I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_05e7: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0642: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got I
		float time = Time.time;
		double num;
		float num2;
		if ((object)glass != null)
		{
			num = brokenAt;
			num2 = time - brokenAt;
			if (glass.enabled)
			{
				float num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
				float num4 = num3 / 0f;
				float num5 = num4 + 1f;
				if (!(num5 > 0f))
				{
					if ((object)glass != null)
					{
						glass.enabled = false;
						if ((object)glass != null)
						{
							glass.SetPropertyBlock(null);
							num = 1.0;
							goto IL_014c;
						}
					}
					goto IL_06a8;
				}
				SetFade(glass, num5);
				num = 1.0;
			}
			goto IL_014c;
		}
		goto IL_06a8;
		IL_048d:
		if (num2 < regrow)
		{
			return;
		}
		bool flag = YouAreInIt();
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		broken = false;
		if ((object)solid != null)
		{
			solid.enabled = true;
			if ((object)glass != null)
			{
				glass.enabled = true;
				fade = 0f;
				SetFade(glass, 0f);
				Shard[] array = shards;
				if (shards == null)
				{
					return;
				}
				object obj2 = array.Length;
				if (array.Length < 1)
				{
					return;
				}
				object obj3 = shards + 32;
				object obj4 = 0;
				while (true)
				{
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj5 = !flag3;
					if (obj5 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v6+v58 @ X20_v7*8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v6+v58 @ X20_v7*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+10]");
							GameObject gameObject = ((Component)0).gameObject;
							if ((object)gameObject != null)
							{
								gameObject.SetActive(value: false);
								obj2 = array.Length;
								obj4++;
								if ((nint)obj4 >= array.Length)
								{
									return;
								}
								continue;
							}
						}
					}
					goto IL_06a8;
				}
				goto IL_06b6;
			}
		}
		goto IL_06a8;
		IL_014c:
		Shard[] array2 = shards;
		if (shards != null)
		{
			object obj7 = array2.Length;
			if (array2.Length >= 1)
			{
				object obj8 = shards + 32;
				float num6 = num2 + -3.5f;
				float num7 = num6 + num6;
				double num8 = 1.0 - (double)num7;
				object obj9 = 0;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj10 = !flag4;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v5+v50 @ X21_v8*8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v5+v50 @ X21_v8*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
							GameObject gameObject2 = ((Component)0).gameObject;
							if ((object)gameObject2 != null)
							{
								if (!gameObject2.activeSelf)
								{
									goto IL_0409;
								}
								bool flag5 = num8 < 0.0;
								object obj12 = !flag5;
								bool flag6 = num8 == 0.0;
								object obj13 = ~obj12;
								object obj14 = obj13 | flag6;
								if (obj14 != null)
								{
									goto IL_039d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
									Vector3 position = ((Transform)0).position;
									Transform transform = base.transform;
									if ((object)transform != null)
									{
										Vector3 position2 = transform.position;
										num7 = (float)num + 3.256877E+09f;
										if (num < (double)num7)
										{
											goto IL_039d;
										}
										if (num8 < 1.0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+20]");
											SetFade((Renderer)0, (float)num8);
											num7 = (float)num8;
										}
										goto IL_0409;
									}
								}
							}
						}
					}
					goto IL_06a8;
					IL_039d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v6+10]");
						GameObject gameObject3 = ((Component)0).gameObject;
						if ((object)gameObject3 != null)
						{
							gameObject3.SetActive(value: false);
							goto IL_0409;
						}
					}
					goto IL_06a8;
					IL_0409:
					obj7 = array2.Length;
					obj9++;
					if ((nint)obj9 < array2.Length)
					{
						continue;
					}
					goto IL_048d;
				}
				goto IL_06b6;
			}
		}
		goto IL_048d;
		IL_06b6:
		throw new IndexOutOfRangeException();
		IL_06a8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06b6;
	}

	private void SetFade(Renderer r, float f)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00d5: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		object obj = this + 80;
		MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock2 = default;
			materialPropertyBlock2._002Ector();
			obj = materialPropertyBlock2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			materialPropertyBlock = (MaterialPropertyBlock)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj4 = 0;
		materialPropertyBlock.Clear();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+A0]");
		object obj8 = 0;
		((MaterialPropertyBlock)obj).SetFloat((int)obj8, f);
		r.SetPropertyBlock((MaterialPropertyBlock)obj);
	}

	private bool YouAreInIt()
	{
		//IL_0010: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_05b0: Expected Obj, but got I
		//IL_05d2: Expected Obj, but got I4
		//IL_065a: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0560: Expected I4, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_022f: Invalid comparison between F4 and I4
		//IL_05f1: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I4
		//IL_024f: Expected F4, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I
		//IL_0318: Expected VT, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I
		//IL_0459: Expected VT, but got I4
		//IL_0477: Expected Obj, but got I4
		//IL_0494: Expected VT, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_04fc: Expected VT, but got I4
		//IL_0549: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			if (obj8 == null)
			{
				goto IL_0552;
			}
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
			bool flag7 = (UnityEngine.Object)0 == null;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
				if (!((UnityEngine.Object)0 == null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						float height = ((CapsuleCollider)0).height;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						float radius = ((CapsuleCollider)0).radius;
						float num = height * 0.5f;
						float num2 = num - radius;
						float num3 = ((!(num2 < 0f)) ? num2 : 0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						Transform t = ((Component)0).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
						object obj17 = 0;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v15+E4]");
						bool flag10 = (nint)0 == 0;
						object obj19 = !flag10;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num4 = Biggest(t);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						float radius2 = ((CapsuleCollider)0).radius;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						Transform t2 = ((Component)0).transform;
						float num5 = Biggest(t2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						Transform transform = ((Component)0).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
						Vector3 center = ((CapsuleCollider)0).center;
						if ((object)transform != null)
						{
							Vector3 vector = transform.TransformPoint((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+28]");
							Transform transform2 = ((Component)0).transform;
							if ((object)transform2 != null)
							{
								Vector3 up = transform2.up;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
									Transform transform3 = ((Component)0).transform;
									if ((object)transform3 != null)
									{
										Vector3 position = transform3.position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
											float radius3 = ((SphereCollider)0).radius;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v3 (UnityEngine.Object)+20]");
												Transform t3 = ((Component)0).transform;
												float num6 = Biggest(t3);
												bool flag11 = Inside((Vector3)0, num5);
												bool flag12 = !flag11;
												object obj20 = !flag12;
												if (obj20 == null)
												{
													bool flag13 = Inside((Vector3)0, num5);
													bool flag14 = !flag13;
													object obj21 = !flag14;
													if (obj21 == null)
													{
														float num7 = num3 * num4;
														float num8 = num7 * num5;
														float r = num5 + num8;
														if (!Inside((Vector3)0, r))
														{
															float r2 = num5 - num8;
															return Inside((Vector3)0, r2);
														}
													}
												}
												return true;
											}
										}
									}
								}
							}
						}
					}
					goto IL_0552;
				}
			}
		}
		return false;
		IL_0552:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool Inside(Vector3 p, float r)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0108: Invalid comparison between Obj and F4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0193: Invalid comparison between F4 and I4
		Frame(out var _, out var _, out var _, out var _, out var hw, out var hh, out var _);
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj4 = r * 0;
		object obj6 = default;
		object obj5 = obj * obj6;
		object obj7 = obj4 + obj5;
		object obj9 = default;
		object obj8 = obj9 * 0;
		object obj10 = obj8 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj11 = default;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
		bool result = false;
		if (!flag)
		{
			object obj12 = r * 0;
			object obj14 = default;
			object obj13 = obj * obj14;
			object obj15 = obj12 + obj13;
			object obj16 = obj9 * 0;
			object obj17 = obj16 + obj15;
			float num = hw + (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
			{
				object obj18 = r * 0;
				object obj20 = default;
				object obj19 = obj * obj20;
				object obj21 = obj18 + obj19;
				object obj22 = obj9 * 0;
				object obj23 = obj22 + obj21;
				float num2 = hh + (float)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num3 = (float)obj23 - num2;
				bool flag2 = num3 < 0f;
				result = flag2;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	private void FadeIn()
	{
		float deltaTime = Time.deltaTime;
		float num = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float num2 = num / 0f;
		float num3 = (fade += num2);
		if ((double)num3 < 1.0)
		{
			SetFade(glass, num3);
			return;
		}
		fade = -1f;
		glass.SetPropertyBlock(null);
	}

	private unsafe void Shatter(Vector3 at, Vector3 push)
	{
		//IL_006b: Expected Obj, but got I
		//IL_00a1: Expected F4, but got I
		//IL_1030: Expected Obj, but got I4
		//IL_0c14: Expected Obj, but got I
		//IL_0c22: Expected Obj, but got I4
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected I4, but got Unknown
		//IL_0c90: Expected Obj, but got I4
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Expected Obj, but got Unknown
		//IL_0130: Invalid comparison between F4 and I4
		//IL_013f: Invalid comparison between F4 and I4
		//IL_0152: Expected Obj, but got F4
		//IL_015f: Expected Obj, but got F4
		//IL_0194: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_0cf3: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0d29: Expected F4, but got I
		//IL_0d29: Expected F4, but got I
		//IL_0d92: Expected VT, but got Obj
		//IL_0db4: Expected Obj, but got I4
		//IL_024e: Expected VT, but got Ref
		//IL_026f: Expected F4, but got I
		//IL_026f: Expected F4, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got F4
		//IL_033c: Expected F4, but got I
		//IL_033c: Expected F4, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got F4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I4
		//IL_0dd2: Expected Obj, but got I
		//IL_0dfc: Expected Obj, but got I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got I4
		//IL_04ba: Unsupported input type for neg.
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0553: Expected Obj, but got I4
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0e23: Expected Obj, but got I4
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected Obj, but got Unknown
		//IL_05a7: Expected Obj, but got I4
		//IL_0e60: Expected Obj, but got I4
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected Obj, but got Unknown
		//IL_05c2: Expected Obj, but got I4
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Expected Obj, but got Unknown
		//IL_0ed4: Invalid comparison between F4 and I4
		//IL_0ee7: Expected Obj, but got F4
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f1c: Expected Obj, but got I4
		//IL_0f4c: Expected Obj, but got I4
		//IL_0f7c: Expected Obj, but got I4
		//IL_0631: Expected Obj, but got Ref
		//IL_063a: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I4
		//IL_0653: Expected VT, but got F4
		//IL_065c: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_0677: Expected F4, but got I4
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected Obj, but got Unknown
		//IL_05d9: Expected Obj, but got Ref
		//IL_05e2: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I4
		//IL_05fb: Expected VT, but got F4
		//IL_0604: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I4
		//IL_061f: Expected F4, but got I4
		//IL_06b7: Expected Obj, but got I4
		//IL_068a: Expected Obj, but got I4
		//IL_06e2: Expected Obj, but got I
		//IL_073b: Expected Obj, but got I4
		//IL_0796: Expected Obj, but got I4
		//IL_07c0: Expected Obj, but got I4
		//IL_07d0: Expected Obj, but got I4
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_0854: Expected VT, but got I4
		//IL_0854: Expected VT, but got Ref
		//IL_0854: Expected VT, but got Ref
		//IL_0854: Expected VT, but got Ref
		//IL_0854: Expected VT, but got Ref
		//IL_0854: Expected VT, but got Ref
		//IL_0854: Expected Obj, but got I
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_088f: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I4
		//IL_0940: Expected Obj, but got I4
		//IL_099b: Expected Obj, but got I4
		//IL_09c5: Expected Obj, but got I4
		//IL_09d5: Expected Obj, but got I4
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_0a43: Expected Obj, but got I4
		//IL_0ab4: Expected VT, but got I4
		//IL_0ab4: Expected VT, but got Ref
		//IL_0ab4: Expected VT, but got Ref
		//IL_0ab4: Expected VT, but got Ref
		//IL_0ab4: Expected VT, but got Ref
		//IL_0ab4: Expected VT, but got Ref
		//IL_0ab4: Expected Obj, but got I
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected Obj, but got Unknown
		//IL_0aec: Expected Obj, but got I4
		//IL_0af5: Expected VT, but got I4
		//IL_0afe: Expected Obj, but got I4
		//IL_0b07: Expected Obj, but got I4
		//IL_0b20: Expected F4, but got I4
		Frame(out var _, out var u, out var w, out var n, out var hw, out var hh, out var ht);
		Transform transform = base.transform;
		Vector3 lossyScale = transform.lossyScale;
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj4 = default;
		float num = (float)obj4 * 0f;
		object obj6 = default;
		object obj5 = obj * obj6;
		float num3 = default;
		float num2 = num3 * 0f;
		float num4 = num + (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
		object obj7 = 0;
		float num5 = hw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
		float num6 = num5 * 0f;
		float num7 = num2 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num8 = 0f;
		if (!(num7 < num6))
		{
			float num9 = hw;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float num10 = num9 * 0f;
			bool flag = !(num7 > num10);
			num6 = num7;
			if (!flag)
			{
				num6 = num10;
			}
		}
		float num11 = (float)obj4 * 0f;
		object obj9 = default;
		object obj8 = obj * obj9;
		float num12 = num11 + (float)obj8;
		float num13 = num3 * 0f;
		float num14 = 0f * (float)obj7;
		float num15 = num13 + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		if (!(num15 < num14))
		{
			num3 = 0f * num8;
			float num16 = num15 - num3;
			bool flag2 = num16 < 0f;
			bool flag3 = num16 == 0f;
			object obj10 = num15 ^ num3;
			object obj11 = num15 ^ num16;
			object obj12 = obj10 & obj11;
			bool flag4 = (nint)obj12 < 0;
			bool flag5 = flag2 == flag4;
			object obj13 = !flag5;
			object obj14 = obj13 | flag3;
			object obj15 = ~obj14;
			num14 = ((obj15 != null) ? num3 : num15);
		}
		int num17 = shardCount;
		bool flag6 = shardCount < 0;
		int num18 = shardCount ^ shardCount;
		int num19 = shardCount & num18;
		bool flag7 = num19 < 0;
		bool flag8 = flag6 == flag7;
		object obj16 = !flag8;
		object obj17 = ~obj16;
		if (obj17 == null)
		{
			num17++;
		}
		int num20 = num17 >> 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj18 = 0;
		object obj19 = num20 - 3;
		bool flag9 = (nint)obj19 < 0;
		bool flag10 = obj19 == null;
		int num21 = num20 ^ 3;
		int num22 = num20 ^ obj19;
		int num23 = num21 & num22;
		bool flag11 = num23 < 0;
		bool flag12 = flag9 == flag11;
		object obj20 = !flag10;
		object obj21 = flag12 & obj20;
		object obj22 = ~obj21;
		int num24 = ((obj22 != null) ? 3 : num20);
		float value = UnityEngine.Random.value;
		float num25 = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		float num26 = num25 * 0f;
		float num27 = num26 + num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj25 = default;
		object obj24 = obj25 + 36;
		object obj27 = default;
		object obj26 = obj27 + 36;
		object obj28 = 0;
		object obj30 = default;
		float num42 = default;
		object obj39 = default;
		object obj41 = default;
		object obj45 = default;
		object obj50 = default;
		Vector2[] array3 = default;
		Vector2[] array5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num29 = UnityEngine.Random.Range(num28, 0f);
			float num30 = num29 + (float)obj28;
			float num31 = num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			float num32 = num31 * 0f;
			float num33 = num32 + num32;
			float num34 = num33 / (float)num24;
			float num35 = num27 + num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
			Vector2 p = (Vector2)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X0_v18 (UnityEngine.Vector2)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num36 = ToEdge(p, (Vector2)(&obj30), num6, num14);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			float num38 = UnityEngine.Random.Range(num37, 0f);
			object obj31 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v10+18]");
			bool flag14 = (nint)obj31 < 0;
			object obj32 = !flag14;
			if (obj32 != null)
			{
				break;
			}
			float num39 = num36 * shardReach;
			float num40 = (float)obj30 * num39;
			float num41 = num42 * num39;
			float num43 = num38 * num40;
			float num44 = num38 * num41;
			float num45 = num6 + num43;
			float num46 = num14 + num44;
			obj24 = num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC4]");
			float num48 = UnityEngine.Random.Range(num47, 0f);
			object obj33 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v12+18]");
			bool flag15 = (nint)obj33 < 0;
			object obj34 = !flag15;
			if (obj34 != null)
			{
				break;
			}
			float num49 = num40 * num48;
			float num50 = num41 * num48;
			obj28++;
			obj24 += 8;
			float num51 = num6 + num49;
			float num52 = num14 + num50;
			obj26 = num52;
			obj26 += 8;
			bool flag16 = num24 != (nint)obj28;
			num15 = num42;
			obj7 = 0;
			num8 = hw;
			if (flag16)
			{
				continue;
			}
			int count = num24 << 1;
			EnsureShards(count);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v25+E4]");
			bool flag17 = (nint)0 == 0;
			object obj37 = !flag17;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj38 = obj39 * obj39;
			object obj40 = obj41 * obj41;
			object obj42 = obj25 + 32;
			object obj43 = obj38 + obj40;
			object obj44 = obj45 * obj45;
			object obj46 = obj27 + 32;
			object obj47 = num24 - 1;
			object obj48 = obj44 + obj43;
			object obj49 = 0 - obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj51 = obj48 - 0;
			bool flag18 = (nint)obj51 < 0;
			bool flag19 = obj51 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj52 = obj48 ^ 0;
			object obj53 = obj48 ^ obj51;
			object obj54 = obj52 & obj53;
			bool flag20 = (nint)obj54 < 0;
			bool flag21 = flag18 == flag20;
			object obj55 = !flag19;
			object obj56 = flag21 & obj55;
			object obj57 = ~obj56;
			object obj58 = ((obj57 != null) ? obj49 : obj41);
			bool flag22 = flag18 == flag20;
			object obj59 = !flag19;
			object obj60 = flag22 & obj59;
			object obj61 = ~obj60;
			object obj62 = ((obj61 != null) ? ((object)0) : obj39);
			bool flag23 = flag18 == flag20;
			object obj63 = !flag19;
			object obj64 = flag23 & obj63;
			object obj65 = ~obj64;
			object obj66 = ((obj65 != null) ? ((object)0) : obj45);
			object obj67 = obj62 * 0;
			object obj68 = obj58 * obj50;
			object obj69 = obj67 + obj68;
			float num53 = (float)obj66 * 0f;
			float num54 = num53 + (float)obj69;
			bool flag24 = num54 < 0f;
			object obj70 = num54 ^ num54;
			object obj71 = num54 & obj70;
			bool flag25 = (nint)obj71 < 0;
			bool flag26 = flag24 == flag25;
			object obj72 = !flag26;
			object obj73 = ~obj72;
			if (obj73 == null)
			{
			}
			bool flag27 = flag24 == flag25;
			object obj74 = !flag27;
			object obj75 = ~obj74;
			if (obj75 == null)
			{
			}
			bool flag28 = flag24 == flag25;
			object obj76 = !flag28;
			object obj77 = ~obj76;
			object obj78;
			object obj79;
			GillaGlass gillaGlass;
			if (obj77 == null)
			{
				Vector2[] array = (Vector2[])(&u);
				obj78 = 0;
				obj79 = 0;
				object obj80 = obj50;
				Vector3 vector = (Vector3)num54;
				object obj81 = 0;
				object obj82 = 0;
				object obj83 = 0;
				float num55 = 0f;
				gillaGlass = this;
			}
			else
			{
				Vector2[] array = (Vector2[])(&u);
				obj78 = 0;
				obj79 = 0;
				object obj80 = obj50;
				Vector3 vector = (Vector3)num54;
				object obj81 = 0;
				object obj82 = 0;
				object obj83 = 0;
				float num55 = 0f;
				gillaGlass = this;
			}
			while (true)
			{
				Shard[] array2 = gillaGlass.shards;
				object obj84 = obj78 + 1;
				object obj85 = ((obj47 != obj78) ? obj84 : ((object)0));
				bool flag29 = (nint)obj79 < array2.Length;
				object obj86 = !flag29;
				if (obj86 != null)
				{
					break;
				}
				object obj87 = (object)array2 + obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
				object obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				if (array3.Length == 0)
				{
					break;
				}
				object obj89 = obj78;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v10+18]");
				bool flag30 = (nint)obj89 < 0;
				object obj90 = !flag30;
				if (obj90 != null || array3.Length == 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X8_v24+v211 @ X28_v4*8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v10+18]");
				bool flag31 = (nint)obj85 < 0;
				object obj91 = !flag31;
				if (obj91 != null)
				{
					break;
				}
				bool flag32 = array3.Length < 2;
				object obj92 = !flag32;
				object obj93 = array3.Length - 2;
				bool flag33 = obj93 == null;
				object obj94 = ~obj92;
				object obj95 = obj94 | flag33;
				if (obj95 != null)
				{
					break;
				}
				object obj96 = obj25 + obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X27_v5+20]");
				_ = 0;
				GillaGlass gillaGlass2 = gillaGlass;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v29+20]");
				gillaGlass2.Piece((Shard)0, array3, (Vector3)(&w), (Vector3)(&n), (Vector3)(&hw), 0f, (Vector2)(&hh), (Vector3)(&ht), (Vector3)0);
				Shard[] array4 = gillaGlass.shards;
				object obj97 = obj79 + 1;
				bool flag34 = (nint)obj97 < array4.Length;
				object obj98 = !flag34;
				if (obj98 != null)
				{
					break;
				}
				object obj99 = (object)array4 + obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj101 = obj78;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v10+18]");
				bool flag35 = (nint)obj101 < 0;
				object obj102 = !flag35;
				if (obj102 != null || array5.Length == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X8_v24+v211 @ X28_v4*8]");
				_ = 0;
				object obj103 = obj78;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v12+18]");
				bool flag36 = (nint)obj103 < 0;
				object obj104 = !flag36;
				if (obj104 != null || array5.Length == 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X9_v6+v211 @ X28_v4*8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v12+18]");
				bool flag37 = (nint)obj85 < 0;
				object obj105 = !flag37;
				if (obj105 != null)
				{
					break;
				}
				bool flag38 = array5.Length < 2;
				object obj106 = !flag38;
				object obj107 = array5.Length - 2;
				bool flag39 = obj107 == null;
				object obj108 = ~obj106;
				object obj109 = obj108 | flag39;
				if (obj109 != null)
				{
					break;
				}
				object obj110 = obj27 + obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X9_v18+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v10+18]");
				bool flag40 = (nint)obj85 < 0;
				object obj111 = !flag40;
				if (obj111 != null || array5.Length == 3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X27_v5+20]");
				_ = 0;
				GillaGlass gillaGlass3 = gillaGlass;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v34+28]");
				gillaGlass3.Piece((Shard)0, array5, (Vector3)(&w), (Vector3)(&n), (Vector3)(&hw), 0f, (Vector2)(&hh), (Vector3)(&ht), (Vector3)0);
				obj79 = obj97 + 1;
				bool flag41 = num24 != (nint)obj84;
				Vector2[] array = array5;
				obj78 = obj84;
				object obj80 = 0;
				Vector3 vector = (Vector3)0;
				object obj81 = 0;
				obj49 = 0;
				object obj82 = obj6;
				object obj83 = obj3;
				float num55 = 0f;
				if (!flag41)
				{
					return;
				}
			}
			break;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static float ToEdge(Vector2 p, Vector2 d, float hw, float hh)
	{
		//IL_00da: Expected F4, but got I4
		//IL_0035: Unsupported input type for neg.
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0043: Invalid comparison between F4 and I4
		//IL_0052: Invalid comparison between F4 and I4
		//IL_0065: Expected Obj, but got F4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01c0: Invalid comparison between F4 and I4
		//IL_01cf: Invalid comparison between F4 and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got F4
		//IL_0225: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_00e3: Unsupported input type for neg.
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_00cc: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj = default;
		float num2;
		if ((nint)obj > 0)
		{
			object obj3 = default;
			object obj2 = 0 - obj3;
			float num = default;
			bool flag = num < 0f;
			bool flag2 = num == 0f;
			object obj4 = num ^ num;
			object obj5 = num & obj4;
			bool flag3 = (nint)obj5 < 0;
			bool flag4 = flag == flag3;
			object obj6 = !flag2;
			object obj7 = flag4 & obj6;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
			}
			object obj9 = obj2 - hw;
			num2 = (float)obj9 / num;
			float num3 = num2 - 2.139095E+09f;
			bool flag5 = num3 < 0f;
			bool flag6 = num3 == 0f;
			object obj10 = num2 ^ 0x7F7FFFFF;
			object obj11 = num2 ^ num3;
			object obj12 = obj10 & obj11;
			bool flag7 = (nint)obj12 < 0;
			bool flag8 = flag5 == flag7;
			object obj13 = !flag6;
			object obj14 = flag8 & obj13;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				num2 = 2.139095E+09f;
			}
		}
		else
		{
			num2 = 2.139095E+09f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)2139095039 > (nint)0)
		{
			object obj17 = default;
			object obj16 = 0 - obj17;
			object obj18 = default;
			bool flag9 = (nint)obj18 < 0;
			bool flag10 = obj18 == null;
			object obj19 = obj18 ^ obj18;
			object obj20 = obj18 & obj19;
			bool flag11 = (nint)obj20 < 0;
			bool flag12 = flag9 == flag11;
			object obj21 = !flag10;
			object obj22 = flag12 & obj21;
			object obj23 = ~obj22;
			if (obj23 == null)
			{
				obj16 = obj17;
			}
			object obj24 = obj16 - hh;
			float num4 = (float)obj24 / (float)obj18;
			if (!(num2 < num4))
			{
				num2 = num4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		return num2;
	}

	private void Piece(Shard s, Vector2[] poly, Vector3 c, Vector3 u, Vector3 w, float depth, Vector2 hit, Vector3 push, Vector3 side)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0031: Expected I4, but got I8
		//IL_0041: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_013c: Expected I4, but got Obj
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0182: Expected I4, but got Obj
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_27bf: Unsupported input type for neg.
		//IL_27bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c4: Expected Obj, but got Unknown
		//IL_27d4: Expected Obj, but got I
		//IL_27e4: Expected Obj, but got I4
		//IL_0f7d: Expected Obj, but got I4
		//IL_0f86: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I4
		//IL_2397: Expected Obj, but got I4
		//IL_0fb5: Expected Obj, but got I4
		//IL_0fbe: Expected Obj, but got I4
		//IL_0fc7: Expected Obj, but got I4
		//IL_2631: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I
		//IL_281b: Expected Obj, but got I
		//IL_2831: Expected Obj, but got I
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_08a9: Expected Obj, but got I4
		//IL_2508: Expected Obj, but got I4
		//IL_101a: Expected Obj, but got I4
		//IL_0925: Expected Obj, but got I
		//IL_0935: Expected Obj, but got I
		//IL_0945: Expected Obj, but got I
		//IL_0963: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_0989: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_0903: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected VT, but got I
		//IL_0328: Expected VT, but got I
		//IL_09fa: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I
		//IL_02d6: Expected VT, but got I4
		//IL_0a6d: Expected Obj, but got I
		//IL_0a7d: Expected Obj, but got I
		//IL_0a8d: Expected Obj, but got I
		//IL_0aaa: Expected Obj, but got I
		//IL_0aba: Expected Obj, but got I
		//IL_0ad0: Expected Obj, but got I
		//IL_286b: Expected Obj, but got I
		//IL_2895: Expected Obj, but got I4
		//IL_0a1e: Expected Obj, but got I
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected Obj, but got Unknown
		//IL_0a53: Expected Obj, but got I
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected Obj, but got Unknown
		//IL_107f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Expected Obj, but got Unknown
		//IL_0b33: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I
		//IL_1125: Expected Obj, but got I
		//IL_113d: Expected Obj, but got I
		//IL_1155: Expected Obj, but got I
		//IL_0ba6: Expected Obj, but got I
		//IL_0bb6: Expected Obj, but got I
		//IL_0bc6: Expected Obj, but got I
		//IL_0be3: Expected Obj, but got I
		//IL_0bf3: Expected Obj, but got I
		//IL_0c09: Expected Obj, but got I
		//IL_10dd: Unsupported input type for neg.
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected Obj, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected Obj, but got Unknown
		//IL_1110: Expected Obj, but got I4
		//IL_0b57: Expected Obj, but got I
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_0c6c: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04c8: Expected VT, but got I
		//IL_116a: Expected Obj, but got I
		//IL_1188: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0cd6: Expected Obj, but got I
		//IL_0ce6: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d15: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_0452: Expected Obj, but got I
		//IL_0486: Expected I4, but got VT
		//IL_2494: Expected Obj, but got I
		//IL_0c90: Expected Obj, but got I
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_2030: Expected VT, but got I4
		//IL_2030: Expected VT, but got I4
		//IL_11db: Expected Obj, but got I4
		//IL_1257: Expected Obj, but got I
		//IL_1267: Expected Obj, but got I
		//IL_127d: Expected VT, but got I
		//IL_0d62: Expected Obj, but got I4
		//IL_2548: Expected Obj, but got I
		//IL_2566: Expected Obj, but got I
		//IL_11ff: Expected Obj, but got I
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_122a: Expected Obj, but got I
		//IL_0dd5: Expected Obj, but got I
		//IL_0de5: Expected Obj, but got I
		//IL_0df5: Expected Obj, but got I
		//IL_0e12: Expected Obj, but got I
		//IL_0e22: Expected Obj, but got I
		//IL_0e38: Expected Obj, but got I
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I4
		//IL_2048: Expected VT, but got I4
		//IL_0d86: Expected Obj, but got I
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Expected Obj, but got Unknown
		//IL_0dbb: Expected Obj, but got I
		//IL_2470: Expected Obj, but got I4
		//IL_12c3: Expected Obj, but got I4
		//IL_0ea9: Expected Obj, but got I4
		//IL_1336: Expected Obj, but got I
		//IL_1346: Expected Obj, but got I
		//IL_135c: Expected VT, but got I
		//IL_0f09: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I
		//IL_0f29: Expected Obj, but got I
		//IL_0f46: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_1389: Expected Obj, but got I
		//IL_13a7: Expected Obj, but got I
		//IL_12e7: Expected Obj, but got I
		//IL_12f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Expected Obj, but got Unknown
		//IL_1312: Expected Obj, but got I
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0ee2: Expected Obj, but got I
		//IL_20ae: Expected VT, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected Obj, but got Unknown
		//IL_0623: Expected Obj, but got I4
		//IL_13fa: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_06c6: Expected VT, but got I
		//IL_06db: Expected VT, but got I
		//IL_2101: Expected VT, but got I4
		//IL_1475: Expected Obj, but got I
		//IL_1485: Expected Obj, but got I
		//IL_149b: Expected VT, but got I
		//IL_0647: Expected Obj, but got I
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0672: Expected Obj, but got I
		//IL_0689: Expected VT, but got I4
		//IL_25a0: Expected Obj, but got I
		//IL_25be: Expected Obj, but got I
		//IL_141e: Expected Obj, but got I
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Expected Obj, but got Unknown
		//IL_1449: Expected Obj, but got I
		//IL_23b5: Expected Obj, but got I
		//IL_23d5: Expected Obj, but got I
		//IL_23e5: Expected Obj, but got I
		//IL_23f5: Expected Obj, but got I
		//IL_2405: Expected Obj, but got I
		//IL_2415: Expected Obj, but got I
		//IL_242b: Expected Obj, but got I
		//IL_14e9: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_155c: Expected Obj, but got I
		//IL_156c: Expected Obj, but got I
		//IL_1582: Expected VT, but got I
		//IL_07b6: Expected Obj, but got I
		//IL_07c6: Expected Obj, but got I
		//IL_07db: Expected VT, but got I
		//IL_150d: Expected Obj, but got I
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected Obj, but got Unknown
		//IL_1538: Expected Obj, but got I
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got Unknown
		//IL_073a: Expected Obj, but got I
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_0765: Expected Obj, but got I
		//IL_0799: Expected I4, but got VT
		//IL_2195: Expected VT, but got I4
		//IL_15c5: Expected Obj, but got I4
		//IL_21ca: Expected VT, but got I4
		//IL_28b3: Expected Obj, but got I
		//IL_28d1: Expected Obj, but got I
		//IL_2671: Expected Obj, but got I
		//IL_269b: Expected Obj, but got I4
		//IL_2937: Expected Obj, but got I4
		//IL_15fb: Expected Obj, but got I4
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Expected Obj, but got Unknown
		//IL_26fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ff: Expected Obj, but got Unknown
		//IL_2721: Expected Obj, but got I4
		//IL_166e: Expected Obj, but got I
		//IL_167e: Expected Obj, but got I
		//IL_1694: Expected VT, but got I
		//IL_296f: Expected Obj, but got I
		//IL_29a6: Expected Obj, but got I4
		//IL_25f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f6: Expected Obj, but got Unknown
		//IL_161f: Expected Obj, but got I
		//IL_162f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1634: Expected Obj, but got Unknown
		//IL_164a: Expected Obj, but got I
		//IL_2749: Expected F4, but got I
		//IL_2767: Expected F4, but got I
		//IL_2788: Expected F4, but got I
		//IL_2788: Expected F4, but got I
		//IL_16e6: Expected Obj, but got I
		//IL_16f6: Expected Obj, but got I
		//IL_170c: Expected Obj, but got I
		//IL_22ca: Expected VT, but got I4
		//IL_1767: Expected Obj, but got I4
		//IL_17e2: Expected Obj, but got I
		//IL_17f2: Expected Obj, but got I
		//IL_1802: Expected Obj, but got I
		//IL_1827: Expected Obj, but got I
		//IL_1837: Expected Obj, but got I
		//IL_184d: Expected Obj, but got I
		//IL_230d: Expected VT, but got I4
		//IL_178b: Expected Obj, but got I
		//IL_179b: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a0: Expected Obj, but got Unknown
		//IL_17c8: Expected Obj, but got I
		//IL_18be: Expected Obj, but got I4
		//IL_1931: Expected Obj, but got I
		//IL_1941: Expected Obj, but got I
		//IL_1951: Expected Obj, but got I
		//IL_196e: Expected Obj, but got I
		//IL_197e: Expected Obj, but got I
		//IL_1994: Expected Obj, but got I
		//IL_18e2: Expected Obj, but got I
		//IL_18f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f7: Expected Obj, but got Unknown
		//IL_1917: Expected Obj, but got I
		//IL_1a05: Expected Obj, but got I4
		//IL_1a78: Expected Obj, but got I
		//IL_1a88: Expected Obj, but got I
		//IL_1a98: Expected Obj, but got I
		//IL_1ab5: Expected Obj, but got I
		//IL_1ac5: Expected Obj, but got I
		//IL_1adb: Expected Obj, but got I
		//IL_1a29: Expected Obj, but got I
		//IL_1a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3e: Expected Obj, but got Unknown
		//IL_1a5e: Expected Obj, but got I
		//IL_1b36: Expected Obj, but got I4
		//IL_1bb1: Expected Obj, but got I
		//IL_1bc1: Expected Obj, but got I
		//IL_1bd1: Expected Obj, but got I
		//IL_1bf6: Expected Obj, but got I
		//IL_1c06: Expected Obj, but got I
		//IL_1c1c: Expected Obj, but got I
		//IL_1b5a: Expected Obj, but got I
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected Obj, but got Unknown
		//IL_1b97: Expected Obj, but got I
		//IL_1c77: Expected Obj, but got I4
		//IL_1cea: Expected Obj, but got I
		//IL_1cfa: Expected Obj, but got I
		//IL_1d0a: Expected Obj, but got I
		//IL_1d27: Expected Obj, but got I
		//IL_1d37: Expected Obj, but got I
		//IL_1d4d: Expected Obj, but got I
		//IL_1c9b: Expected Obj, but got I
		//IL_1cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb0: Expected Obj, but got Unknown
		//IL_1cd0: Expected Obj, but got I
		//IL_1dbe: Expected Obj, but got I4
		//IL_1e16: Expected Obj, but got I
		//IL_1e26: Expected Obj, but got I
		//IL_1e36: Expected Obj, but got I
		//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de1: Expected Obj, but got Unknown
		//IL_1df7: Expected Obj, but got I
		if (poly == null)
		{
			goto IL_230e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj = 0;
		object obj2 = obj;
		int num = (int)(poly.Length & 0xFFFFFFFFL);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7+A0]");
		object obj3 = 0;
		object obj4 = obj3;
		if (poly.Length >= 1)
		{
			int num2 = ~poly.Length;
			int num3 = poly.Length & num2;
			object obj5 = poly + 32;
			do
			{
				obj5 += 8;
				obj4 = obj3 + obj5;
			}
			while (num3 != 1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AA0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj10 = poly.Length + poly.Length;
		int capacity = obj10 << 1;
		List<Vector3> list = default;
		list._002Ector(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list2 = default;
		list2._002Ector(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		int num4 = obj10 << 2;
		object obj11 = obj9;
		List<int> list3 = default;
		list3._002Ector(num4);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		List<int> list4 = list3;
		object obj13 = default;
		object obj12 = obj4 / obj13;
		object obj15 = default;
		object obj14 = 0 - obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj16 = 0;
		object obj17 = poly.Length - 1;
		bool flag = poly.Length < 1;
		object obj18 = obj12;
		object obj25;
		object obj37 = default;
		if (!flag)
		{
			object obj19 = poly + 32;
			object obj20 = 0;
			while (true)
			{
				bool flag2 = (nint)obj20 < poly.Length;
				object obj21 = !flag2;
				if (obj21 != null)
				{
					break;
				}
				if (list != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj22 = 0;
					object obj23 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj24 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X27_v16+v860 @ X19_v18*8]");
						obj25 = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X9_v74+18]");
						bool flag3 = num5 < 0;
						object obj26 = !flag3;
						Vector3 vector;
						List<Vector3> list5;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj27 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj28 = 0 + obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj29 = (nint)0 + (nint)1;
							vector = (Vector3)num4;
							list5 = (List<Vector3>)(object)list4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v166+20]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v197+A8]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v198+70]");
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v198+70]");
							list.AddWithResize((Vector3)0);
							list5 = list;
						}
						if (list2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj32 = 0;
							object obj33 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj34 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1414 @ X8_v171+A0]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X9_v76+48]");
							obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X9_v76+4C]");
							obj37 = 0;
							object obj38 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v172+18]");
								bool flag4 = num6 < 0;
								object obj39 = !flag4;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj40 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj41 = 0 + obj40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj42 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X9_v76+48]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X9_v76+4C]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X9_v76+50]");
									_ = 0;
									num4 = (int)vector;
									list4 = (List<int>)(object)list5;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X9_v77+20]");
									object obj43 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1467 @ X8_v194+A8]");
									object obj44 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v195+70]");
									list2.AddWithResize((Vector3)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v195+70]");
									num4 = 0;
									list4 = (List<int>)(object)list2;
								}
								obj20++;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								if (num != (nint)obj20)
								{
									continue;
								}
								goto IL_053a;
							}
						}
					}
				}
				goto IL_230e;
			}
			goto IL_231c;
		}
		goto IL_233f;
		IL_230e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_231c;
		IL_053a:
		bool flag5 = poly.Length < 1;
		object obj45 = obj25;
		if (!flag5)
		{
			object obj46 = poly + 32;
			int num7 = num4;
			List<int> list6 = list4;
			object obj47 = 0;
			while (true)
			{
				bool flag6 = (nint)obj47 < poly.Length;
				object obj48 = !flag6;
				if (obj48 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj49 = 0;
				object obj50 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj51 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X20_v13+v861 @ X19_v22*8]");
					object obj52 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X9_v81+18]");
					bool flag7 = num8 < 0;
					object obj53 = !flag7;
					Vector3 vector2;
					List<Vector3> list7;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj54 = (nint)0 * (nint)12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj55 = 0 + obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj56 = (nint)0 + (nint)1;
						vector2 = (Vector3)num7;
						list7 = (List<Vector3>)(object)list6;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v179+20]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X8_v191+A8]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X8_v192+70]");
						vector2 = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X8_v192+70]");
						list.AddWithResize((Vector3)0);
						list7 = list;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj59 = 0;
					object obj60 = obj16;
					object obj61 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1683 @ X8_v184+A0]");
					object obj62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj63 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+54]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+58]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+5C]");
					obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj64 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v185+18]");
						bool flag8 = num9 < 0;
						object obj65 = !flag8;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj66 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj67 = 0 + obj66;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj68 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+54]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+58]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X9_v83+5C]");
							_ = 0;
							num4 = (int)vector2;
							list4 = (List<int>)(object)list7;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v112+20]");
							object obj69 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ X8_v188+A8]");
							object obj70 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X8_v189+70]");
							list2.AddWithResize((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X8_v189+70]");
							num4 = 0;
							list4 = (List<int>)(object)list2;
						}
						obj47++;
						bool flag9 = num != (nint)obj47;
						num7 = num4;
						list6 = list4;
						if (flag9)
						{
							continue;
						}
						goto IL_233f;
					}
				}
				goto IL_230e;
			}
			goto IL_231c;
		}
		goto IL_233f;
		IL_1e9f:
		object obj78 = default;
		object obj82 = default;
		object obj84 = default;
		if (s != null && (object)s.mesh != null)
		{
			s.mesh.Clear();
			if ((object)s.mesh != null)
			{
				s.mesh.SetVertices(list);
				if ((object)s.mesh != null)
				{
					s.mesh.SetNormals(list2);
					if ((object)s.mesh != null)
					{
						s.mesh.SetTriangles(list3, 0);
						if ((object)s.mesh != null)
						{
							s.mesh.RecalculateBounds();
							Transform transform = base.transform;
							if ((object)transform != null)
							{
								Quaternion rotation = transform.rotation;
								if ((object)s.t != null)
								{
									s.t.SetPositionAndRotation((Vector3)0, (Quaternion)0);
									if ((object)s.t != null)
									{
										s.t.localScale = (Vector3)0;
										if ((object)s.r != null)
										{
											s.r.SetPropertyBlock(null);
											if ((object)s.box != null)
											{
												s.box.center = (Vector3)0;
												if ((object)s.box != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
													s.box.size = (Vector3)0;
													if ((object)s.t != null)
													{
														GameObject gameObject = s.t.gameObject;
														if ((object)gameObject != null)
														{
															gameObject.SetActive(value: true);
															if ((object)s.body != null)
															{
																s.body.position = (Vector3)0;
																if ((object)s.body != null)
																{
																	s.body.rotation = (Quaternion)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
																	object obj71 = 0;
																	object obj72 = obj71;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X0_v37+E4]");
																	bool flag10 = (nint)0 == 0;
																	object obj73 = !flag10;
																	object obj74 = obj12;
																	if (obj73 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj74 = obj12;
																	}
																	object obj76 = default;
																	object obj75 = obj74 - obj76;
																	object obj79 = default;
																	object obj77 = obj78 - obj79;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X27_v8+99E]");
																	bool flag11 = (nint)0 == 0;
																	object obj80 = !flag11;
																	if (obj80 == null)
																	{
																		_ = 1;
																	}
																	object obj81 = obj82 * obj75;
																	object obj83 = obj84 * obj75;
																	object obj86 = default;
																	object obj85 = obj86 * obj75;
																	object obj88 = default;
																	object obj87 = obj88 * obj77;
																	object obj89 = side * obj77;
																	IntPtr intPtr = default;
																	object obj90 = (nint)intPtr * obj77;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X28_v8+9A1]");
																	bool flag12 = (nint)0 == 0;
																	object obj91 = !flag12;
																	if (obj91 == null)
																	{
																		_ = 1;
																	}
																	object obj92 = obj83 + obj89;
																	object obj93 = obj81 + obj87;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
																	object obj94 = 0;
																	object obj95 = obj85 + obj90;
																	object obj96 = obj94;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X0_v41+E4]");
																	bool flag13 = (nint)0 == 0;
																	object obj97 = !flag13;
																	if (obj97 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	object obj98 = obj92 * obj92;
																	object obj99 = obj93 * obj93;
																	object obj100 = obj98 + obj99;
																	object obj101 = obj95 * obj95;
																	object obj102 = obj101 + obj100;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																	if ((nint)obj102 > 0)
																	{
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
																	float num10 = UnityEngine.Random.Range(0f, 0.75f);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
																	float num11 = UnityEngine.Random.Range(0f, 1f);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
																	nint num12 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
																	float num13 = UnityEngine.Random.Range(num12, 0f);
																	Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
																	if ((object)s.body != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																		s.body.linearVelocity = (Vector3)0;
																		Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
																		if ((object)s.body != null)
																		{
																			s.body.angularVelocity = (Vector3)0;
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
		goto IL_230e;
		IL_231c:
		throw new IndexOutOfRangeException();
		IL_0f5b:
		bool flag14 = poly.Length < 1;
		object obj103 = obj84;
		object obj104 = 109891584;
		object obj105 = 109891584;
		if (flag14)
		{
			goto IL_1e9f;
		}
		object obj106 = obj84;
		object obj107 = obj45;
		object obj108 = obj37;
		object obj109 = 0;
		obj104 = 109891584;
		obj105 = 109891584;
		int num14 = num;
		Vector2[] array = poly;
		object obj110 = obj18;
		object obj136 = default;
		while (true)
		{
			bool flag15 = (nint)obj109 < array.Length;
			object obj111 = !flag15;
			if (obj111 != null)
			{
				break;
			}
			object obj112 = obj109 + 1;
			object obj113 = (((nint)obj112 != num14) ? obj112 : ((object)0));
			bool flag16 = (nint)obj113 < array.Length;
			object obj114 = !flag16;
			if (obj114 != null)
			{
				break;
			}
			object obj115 = (object)array + obj109;
			object obj116 = (object)array + obj113;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj117 = 0;
			List<Vector3> list8 = (List<Vector3>)obj117;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v76 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E4]");
			bool flag17 = (nint)0 == 0;
			object obj118 = !flag17;
			if (obj118 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ X8_v59+20]");
			object obj119 = 0 - obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X9_v13+20]");
			obj103 = 0 - obj12;
			object obj120 = obj103 - obj119;
			obj45 = obj120 * obj120;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj123;
			if ((nint)obj82 > 0)
			{
				object obj121 = 0 - obj120;
				object obj122 = obj78 / obj82;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				obj123 = 0 / obj121;
				obj45 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj124 = 0;
				object obj125 = obj124;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ X8_v120+A0]");
				object obj126 = 0;
				object obj122 = obj126;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X8_v121+4]");
				obj123 = 0;
			}
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj127 = 0;
				object obj128 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj129 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v67+18]");
					bool flag18 = num15 < 0;
					object obj130 = !flag18;
					if (obj130 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj131 = (nint)0 * (nint)12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj132 = 0 + obj131;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj133 = (nint)0 + (nint)1;
						obj37 = obj123;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v14+20]");
						object obj134 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ X8_v115+A8]");
						object obj135 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ X8_v116+70]");
						list.AddWithResize((Vector3)0);
						obj45 = obj15;
						obj37 = obj136;
						list8 = list;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj137 = 0;
					object obj138 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj139 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v69+18]");
						bool flag19 = num16 < 0;
						object obj140 = !flag19;
						if (obj140 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj141 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj142 = 0 + obj141;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj143 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X9_v16+20]");
							object obj144 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1669 @ X8_v112+A8]");
							object obj145 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v113+70]");
							list.AddWithResize((Vector3)0);
							obj45 = obj14;
							obj37 = obj136;
							list8 = list;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj146 = 0;
						object obj147 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj148 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v71+18]");
							bool flag20 = num17 < 0;
							object obj149 = !flag20;
							if (obj149 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj150 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj151 = 0 + obj150;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj152 = (nint)0 + (nint)1;
								object obj153 = obj103;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X9_v18+20]");
								object obj154 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1719 @ X8_v109+A8]");
								object obj155 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1723 @ X8_v110+70]");
								list.AddWithResize((Vector3)0);
								obj45 = obj14;
								obj37 = obj136;
								list8 = list;
								object obj153 = obj103;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj156 = 0;
							object obj157 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj158 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								nint num18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v73+18]");
								bool flag21 = num18 < 0;
								object obj159 = !flag21;
								if (obj159 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj160 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj161 = 0 + obj160;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj162 = (nint)0 + (nint)1;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X9_v20+20]");
									object obj163 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1736 @ X8_v106+A8]");
									object obj164 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ X8_v107+70]");
									list.AddWithResize((Vector3)0);
									obj45 = obj15;
									obj37 = obj136;
									list8 = list;
								}
								if (list2 != null)
								{
									object obj165 = 4;
									obj18 = obj123;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj166 = 0;
										object obj167 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj168 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v76+18]");
										bool flag22 = num19 < 0;
										object obj169 = !flag22;
										if (obj169 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj170 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj171 = 0 + obj170;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj172 = (nint)0 + (nint)1;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X9_v23+20]");
											object obj173 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v103+A8]");
											object obj174 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ X8_v104+70]");
											list2.AddWithResize((Vector3)0);
											obj45 = obj136;
											obj37 = obj123;
											list8 = list2;
											obj18 = obj123;
										}
										obj165--;
										if ((nint)obj165 != 1)
										{
											continue;
										}
										goto IL_16b9;
									}
								}
							}
						}
					}
				}
			}
			goto IL_230e;
			IL_16b9:
			if (list3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj175 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
				object obj176 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj177 = (nint)0 + (nint)1;
				object obj178 = obj176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag23 = num20 < 0;
					object obj179 = !flag23;
					if (obj179 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj180 = (nint)0 + (nint)1;
						object obj181 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj182 = obj181 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj183 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj184 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ X8_v100+A8]");
						object obj185 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ X8_v101+70]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						list3.AddWithResize(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj175 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj186 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj187 = (nint)0 + (nint)1;
						obj178 = obj186;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_230e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					int item = (int)((nint)0 + (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag24 = num21 < 0;
					object obj188 = !flag24;
					if (obj188 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj189 = (nint)0 + (nint)1;
						object obj190 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj191 = obj190 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj192 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj193 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ X8_v97+A8]");
						object obj194 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1815 @ X8_v98+70]");
						obj11 = 0;
						list3.AddWithResize(item);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj175 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj195 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj196 = (nint)0 + (nint)1;
						obj178 = obj195;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_230e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					int item2 = (int)((nint)0 + (nint)2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag25 = num22 < 0;
					object obj197 = !flag25;
					if (obj197 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj198 = (nint)0 + (nint)1;
						object obj199 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj200 = obj199 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj201 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj202 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1854 @ X8_v94+A8]");
						object obj203 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1855 @ X8_v95+70]");
						obj11 = 0;
						list3.AddWithResize(item2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj175 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj204 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj205 = (nint)0 + (nint)1;
						obj178 = obj204;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_230e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag26 = num23 < 0;
					object obj206 = !flag26;
					if (obj206 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj207 = (nint)0 + (nint)1;
						object obj208 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj209 = obj208 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj210 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj211 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1909 @ X8_v91+A8]");
						object obj212 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1910 @ X8_v92+70]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						list3.AddWithResize(0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj175 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj213 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj214 = (nint)0 + (nint)1;
						obj178 = obj213;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_230e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag27 = num24 < 0;
					object obj215 = !flag27;
					if (obj215 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj216 = (nint)0 + (nint)1;
						object obj217 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj218 = obj217 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj219 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj220 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ X8_v88+A8]");
						object obj221 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1951 @ X8_v89+70]");
						obj11 = 0;
						list3.AddWithResize(item2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj175 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
						object obj222 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj223 = (nint)0 + (nint)1;
						obj178 = obj222;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_230e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v8 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					num4 = (int)((nint)0 + (nint)3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v83+18]");
					bool flag28 = num25 < 0;
					object obj224 = !flag28;
					if (obj224 == null)
					{
						object obj225 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj226 = obj225 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj227 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X9_v32+20]");
						object obj228 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1984 @ X8_v85+A8]");
						object obj229 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ X8_v86+70]");
						obj11 = 0;
						list3.AddWithResize(num4);
					}
					bool flag29 = (nint)obj112 != num;
					obj106 = obj103;
					obj107 = obj45;
					obj108 = obj37;
					obj109 = obj112;
					num14 = num;
					array = poly;
					obj110 = obj18;
					if (flag29)
					{
						continue;
					}
					goto IL_1e9f;
				}
			}
			goto IL_230e;
		}
		goto IL_231c;
		IL_233f:
		if ((nint)obj17 <= 1)
		{
			goto IL_0f5b;
		}
		if (list3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
			object obj230 = 0;
			object obj231 = obj230;
			object obj232 = obj11;
			int num26 = 2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj233 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj234 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag30 = num27 < 0;
				object obj235 = !flag30;
				List<int> list9;
				if (obj235 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj236 = (nint)0 + (nint)1;
					object obj237 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj238 = obj237 + 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj239 = (nint)0 + (nint)1;
					list9 = list4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj240 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v159+A8]");
					object obj241 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ X8_v160+70]");
					obj232 = 0;
					list3.AddWithResize(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj233 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj242 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj243 = (nint)0 + (nint)1;
					obj231 = obj242;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					bool flag31 = (nint)0 == 0;
					list9 = list3;
					if (flag31)
					{
						break;
					}
				}
				int item3 = num26 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag32 = num28 < 0;
				object obj244 = !flag32;
				if (obj244 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj245 = (nint)0 + (nint)1;
					object obj246 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj247 = obj246 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj248 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj249 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v154+A8]");
					object obj250 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v155+70]");
					obj232 = 0;
					list3.AddWithResize(item3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj233 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj251 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj252 = (nint)0 + (nint)1;
					obj231 = obj251;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					bool flag33 = (nint)0 == 0;
					list9 = list3;
					if (flag33)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag34 = num29 < 0;
				object obj253 = !flag34;
				if (obj253 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj254 = (nint)0 + (nint)1;
					object obj255 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj256 = obj255 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj257 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj258 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1450 @ X8_v149+A8]");
					object obj259 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X8_v150+70]");
					obj232 = 0;
					list3.AddWithResize(num26);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj233 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj260 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj261 = (nint)0 + (nint)1;
					obj231 = obj260;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					bool flag35 = (nint)0 == 0;
					list9 = list3;
					if (flag35)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag36 = num30 < 0;
				object obj262 = !flag36;
				if (obj262 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj263 = (nint)0 + (nint)1;
					object obj264 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj265 = obj264 + 0;
					_ = poly.Length;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj266 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v144+A8]");
					object obj267 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ X8_v145+70]");
					obj232 = 0;
					list3.AddWithResize(poly.Length);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj268 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj233 = 0;
					obj231 = obj268;
					list9 = list3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj269 = (nint)0 + (nint)1;
				if (obj233 == null)
				{
					break;
				}
				int num31 = poly.Length + num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag37 = num32 < 0;
				object obj270 = !flag37;
				if (obj270 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj271 = (nint)0 + (nint)1;
					object obj272 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj273 = obj272 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj274 = (nint)0 + (nint)1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj275 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1569 @ X8_v139+A8]");
					object obj276 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X8_v140+70]");
					obj232 = 0;
					list3.AddWithResize(num31);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					obj233 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj277 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj278 = (nint)0 + (nint)1;
					obj231 = obj277;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+10]");
					bool flag38 = (nint)0 == 0;
					list9 = list3;
					if (flag38)
					{
						break;
					}
				}
				num4 = num31 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X9_v65+18]");
				bool flag39 = num33 < 0;
				object obj279 = !flag39;
				if (obj279 == null)
				{
					object obj280 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj281 = obj280 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v13 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj282 = (nint)0 + (nint)1;
					list4 = list9;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v133+20]");
					object obj283 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X8_v134+A8]");
					object obj284 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ X8_v135+70]");
					obj232 = 0;
					list3.AddWithResize(num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj285 = 0;
					obj231 = obj285;
					list4 = list3;
				}
				num26++;
				bool flag40 = poly.Length != num26;
				obj11 = obj232;
				if (flag40)
				{
					continue;
				}
				goto IL_0f5b;
			}
		}
		goto IL_230e;
	}

	private void EnsureShards(int count)
	{
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_07b9: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_0178: Expected I, but got Obj
		//IL_0180: Expected I4, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I4
		//IL_01f4: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0240: Expected I4, but got Obj
		//IL_0267: Expected Obj, but got I4
		//IL_026c: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_029f: Expected I4, but got Obj
		//IL_02c6: Expected Obj, but got I4
		//IL_02cb: Expected I, but got Obj
		//IL_0309: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I
		//IL_0776: Expected Obj, but got I4
		//IL_077b: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I
		//IL_0387: Expected I4, but got Obj
		//IL_03ae: Expected Obj, but got I4
		//IL_03b3: Expected I, but got Obj
		//IL_03d6: Expected F4, but got I
		//IL_03eb: Expected F4, but got I
		//IL_0405: Expected F4, but got I
		//IL_0430: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_04b1: Expected I, but got Obj
		//IL_04c1: Expected F4, but got I
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_059a: Expected Obj, but got I4
		//IL_059f: Expected I, but got Obj
		//IL_05af: Expected F4, but got I
		//IL_05b7: Expected I4, but got Obj
		//IL_05ff: Expected Obj, but got I4
		//IL_0604: Expected I, but got Obj
		//IL_0614: Expected F4, but got I
		//IL_0643: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I4
		//IL_0651: Expected I, but got Obj
		//IL_0661: Expected F4, but got I
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06aa: Expected Obj, but got I4
		//IL_06c8: Expected F4, but got I
		object obj = this + 216;
		object obj2 = obj;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+18]");
			if ((nint)0 >= (nint)count)
			{
				return;
			}
		}
		DropShards();
		bool flag = (object)glass == null;
		int num = count;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10A8]");
			object obj4 = 0;
			Material sharedMaterial = glass.sharedMaterial;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Material sharedMaterial2 = ShardMaterial(sharedMaterial, shardOpacity);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj7 = default;
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (count < 1)
			{
				return;
			}
			float num2 = shardOpacity;
			int num3 = default;
			GameObject gameObject = default;
			Mesh mesh = default;
			MeshFilter meshFilter = default;
			Renderer renderer = default;
			Collider collider = default;
			Rigidbody rigidbody = default;
			Shard shard = default;
			while (true)
			{
				string text = name;
				string text2 = num3.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10B8]");
				object obj8 = 0;
				string text3 = text + (string)obj8 + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				gameObject._002Ector(text3);
				bool flag3 = (object)gameObject == null;
				object obj10 = 0;
				nint num4 = unchecked((nint)null);
				num = (int)text3;
				if (flag3)
				{
					break;
				}
				gameObject.layer = 2;
				gameObject.SetActive(value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				mesh._002Ector();
				bool flag4 = (object)mesh == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				num = 0;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10C0]");
				object obj12 = 0;
				mesh.name = (string)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
				object obj13 = 0;
				num = (int)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				bool flag5 = (object)meshFilter == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				if (flag5)
				{
					break;
				}
				meshFilter.sharedMesh = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
				object obj14 = 0;
				num = (int)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				bool flag6 = (object)renderer == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				if (flag6)
				{
					break;
				}
				renderer.sharedMaterial = sharedMaterial2;
				renderer.shadowCastingMode = (ShadowCastingMode)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v30+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v30+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v31+18]");
				LayerMask excludeLayers = 0;
				bool flag8 = (object)collider == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				num = 0;
				if (flag8)
				{
					break;
				}
				collider.excludeLayers = excludeLayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
				object obj19 = 0;
				num = (int)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				bool flag9 = (object)rigidbody == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				if (flag9)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				rigidbody.mass = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				rigidbody.linearDamping = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				rigidbody.angularDamping = 0f;
				rigidbody.interpolation = (RigidbodyInterpolation)1;
				object obj20 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v34+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v35+18]");
				LayerMask excludeLayers2 = 0;
				rigidbody.excludeLayers = excludeLayers2;
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10B0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				shard._002Ector();
				Transform transform = gameObject.transform;
				bool flag10 = shard == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				num2 = 0f;
				num = 0;
				if (flag10)
				{
					break;
				}
				object obj24 = shard + 16;
				obj24 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj25 = shard + 24;
				obj25 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj26 = shard + 32;
				obj26 = renderer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj27 = shard + 40;
				obj27 = rigidbody;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj28 = shard + 48;
				obj28 = collider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag11 = obj == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				num2 = 0f;
				num = (int)collider;
				if (flag11)
				{
					break;
				}
				object obj29 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v38+40]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag12 = ex == null;
				obj10 = 0;
				num4 = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				num2 = 0f;
				if (!flag12)
				{
					int num5 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X19_v11+18]");
					bool flag13 = (nint)num5 < (nint)0;
					object obj30 = !flag13;
					obj10 = 0;
					num4 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					num2 = 0f;
					if (obj30 == null)
					{
						object obj31 = obj + num3;
						object obj32 = obj31 + 32;
						obj32 = shard;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj33 = num3 + 1;
						bool flag14 = (nint)obj33 < count;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						num2 = 0f;
						if (!flag14)
						{
							return;
						}
						continue;
					}
					goto IL_06e5;
				}
				goto IL_06f3;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06e5;
		IL_06e5:
		ex = new IndexOutOfRangeException();
		goto IL_06f3;
		IL_06f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private unsafe static Material ShardMaterial(Material pane, float opacity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0564: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e6: Expected VT, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_02cf: Invalid comparison between F4 and I4
		//IL_02de: Expected F8, but got I4
		//IL_041f: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_033c: Expected VT, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_0512: Expected VT, but got I4
		//IL_0512: Expected Obj, but got I
		//IL_049e: Expected F4, but got I4
		//IL_04a7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = pane == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Material result = null;
		object obj5;
		Material material;
		Material material2 = default;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
			obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v9+A0]");
			object obj8 = 0;
			(System.__Canon, float) tuple = ((System.__Canon)(object)pane, opacity);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v7+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10C8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v7+10]");
				bool flag5 = ((Dictionary<(System.__Canon, float), System.__Canon>)0).TryGetValue(((System.__Canon, float))0, out *(System.__Canon*)null);
				bool flag6 = !flag5;
				ref System.__Canon reference = ref *(System.__Canon*)null;
				UnityEngine.Object obj10 = null;
				if (!flag6)
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v45+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj13 = default;
					bool flag8 = obj13 != null;
					bool flag9 = !flag8;
					object obj14 = !flag9;
					reference = ref *(System.__Canon*)null;
					obj10 = null;
					material = (Material)obj13;
					if (obj14 != null)
					{
						goto IL_051f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				material2._002Ector(pane);
				if ((object)pane != null)
				{
					string text = pane.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10E0]");
					object obj16 = 0;
					string text2 = text + (string)obj16;
					if ((object)material2 != null)
					{
						material2.name = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
						object obj17 = 0;
						if (!material2.HasProperty((string)obj17))
						{
							goto IL_0341;
						}
						if ((object)material2 != null)
						{
							Color color = material2.GetColor((string)obj17);
							double num2 = default;
							float num = (float)num2 * opacity;
							bool flag10 = num < 0f;
							num2 = 0.0;
							if (!flag10)
							{
								bool flag11 = !((double)num > 1.0);
								num2 = num;
								if (!flag11)
								{
									num2 = 1.0;
								}
							}
							if ((object)material2 != null)
							{
								material2.SetColor((string)obj17, (Color)0);
								goto IL_0341;
							}
						}
					}
				}
			}
			goto IL_052c;
		}
		goto IL_0572;
		IL_051f:
		result = material;
		goto IL_0572;
		IL_052c:
		return (Material)(object)new NullReferenceException();
		IL_0572:
		return result;
		IL_0341:
		if ((object)material2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9CC8]");
			object obj18 = 0;
			bool flag12 = material2.HasProperty((string)obj18);
			bool flag13 = !flag12;
			float num3 = opacity;
			if (!flag13)
			{
				if ((object)material2 == null)
				{
					goto IL_052c;
				}
				num3 = material2.GetFloat((string)obj18);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				material2.SetFloat((string)obj18, num3);
			}
			if ((object)material2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B28]");
				object obj19 = 0;
				string text3 = (string)obj19;
				bool flag14 = material2.HasProperty((string)obj19);
				bool flag15 = !flag14;
				object obj20 = 0;
				if (!flag15)
				{
					if ((object)material2 == null)
					{
						goto IL_052c;
					}
					text3 = (string)obj19;
					material2.SetFloat((string)obj19, 0f);
					num3 = 0f;
					obj20 = 0;
				}
				object obj21 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v34+E4]");
				bool flag16 = (nint)0 == 0;
				object obj22 = !flag16;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v34+A0]");
				object obj23 = 0;
				(System.__Canon, float) tuple = ((System.__Canon)(object)pane, opacity);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v19+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v19+10]");
					((Dictionary<(System.__Canon, float), System.__Canon>)0).set_Item(((System.__Canon, float))0, (System.__Canon)null);
					material = material2;
					goto IL_051f;
				}
			}
		}
		goto IL_052c;
	}

	public GillaGlass()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003d: Expected F4, but got I
		//IL_004f: Expected F4, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		shardCount = 10;
		slowTo = 0.75f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1E8]");
		runSpeed = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B6A0]");
		shardReach = 0f;
		fade = -1f;
		object obj2 = this + 224;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaGlass()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7860]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD9F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D10F8]");
		object obj4 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<(System.__Canon, float), System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+A0]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+A0]");
		object obj12 = 0;
		_ = 4294967295L;
	}
}
