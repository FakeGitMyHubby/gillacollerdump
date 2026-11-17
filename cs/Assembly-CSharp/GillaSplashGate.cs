using System;
using Cpp2ILInjected;
using UnityEngine;

public class GillaSplashGate : MonoBehaviour
{
	public Transform[] doors;

	public Collider block;

	public float rise;

	public float seconds;

	public AudioClip[] moveSounds;

	private Vector3[] rest;

	private float open;

	private bool want;

	public bool Open
	{
		get
		{
			//IL_001f: Invalid comparison between F4 and I4
			//IL_0039: Expected Obj, but got F8
			//IL_0048: Expected Obj, but got F4
			float num = open - 1f;
			bool flag = num < 0f;
			object obj = (double)open ^ 1.0;
			object obj2 = open ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	private void Awake()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		Transform[] array = doors;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 64;
		UnityEngine.Object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X20_v6-20]");
		Transform[] array2 = (Transform[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = 4;
		object obj6 = 0;
		UnityEngine.Object obj7 = obj3;
		while (true)
		{
			object obj8 = obj5 - 4;
			if ((nint)obj8 >= array2.Length)
			{
				return;
			}
			bool flag = (nint)obj8 < array2.Length;
			object obj9 = !flag;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7 (UnityEngine.Transform[])+v101 @ X23_v5*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj7 = null;
			if (!flag4)
			{
				Transform[] array3 = doors;
				bool flag5 = (nint)obj8 < array3.Length;
				object obj12 = !flag5;
				if (obj12 != null)
				{
					break;
				}
				Vector3[] array4 = rest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v11 (UnityEngine.Transform[])+v101 @ X23_v5*8]");
				Vector3 localPosition = ((Transform)0).localPosition;
				bool flag6 = (nint)obj8 < array4.Length;
				object obj13 = !flag6;
				if (obj13 != null)
				{
					break;
				}
				object obj14 = (object)array4 + obj6;
				obj7 = null;
			}
			array2 = doors;
			obj5++;
			obj6 += 12;
			bool flag7 = doors == null;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	public void Set(bool up)
	{
		//IL_0083: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00e6: Expected VT, but got I4
		if (want == up)
		{
			return;
		}
		AudioClip[] array = moveSounds;
		want = up;
		if (moveSounds != null && array.Length != 0)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float volume = default;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play(moveSounds, (Vector3)0, volume, pitchMin, pitchMax);
		}
	}

	private void Update()
	{
		//IL_05e7: Invalid comparison between F4 and I
		//IL_000e: Expected F8, but got I4
		//IL_0625: Invalid comparison between F8 and I4
		//IL_0638: Expected Obj, but got F8
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_0676: Expected Obj, but got I4
		//IL_0035: Expected F4, but got I
		//IL_06bf: Expected Obj, but got I4
		//IL_06d8: Invalid comparison between F4 and I4
		//IL_06ed: Expected Obj, but got I4
		//IL_06fa: Expected I4, but got Obj
		//IL_0705: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I4
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got Unknown
		//IL_07d2: Expected Obj, but got I4
		//IL_07ed: Invalid comparison between F4 and I4
		//IL_04f1: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_014b: Invalid comparison between F4 and I4
		//IL_0555: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_058a: Invalid comparison between F4 and I4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_046a: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I4
		//IL_0291: Invalid comparison between F4 and I4
		//IL_02cd: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0340: Invalid comparison between F4 and I4
		//IL_0375: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_0413: Expected VT, but got I4
		//IL_0413: Expected Obj, but got I
		double num = open;
		float deltaTime = Time.deltaTime;
		Transform[] array = doors;
		double num2 = (want ? 1.0 : 0.0);
		float num3 = seconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num4;
		if (num3 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			num4 = 0f;
		}
		else
		{
			num4 = seconds;
		}
		float num5 = deltaTime / num4;
		double num6 = num2 - num;
		bool flag = num6 < 0.0;
		object obj = num6 ^ num6;
		object obj2 = num6 & obj;
		bool flag2 = (nint)obj2 < 0;
		float num7 = 0f - num5;
		bool flag3 = flag == flag2;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		float num8 = ((obj4 != null) ? num5 : num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num9 = (float)num + num8;
		bool flag4 = num7 < num5;
		object obj5 = !flag4;
		float num10 = num7 - num5;
		bool flag5 = num10 == 0f;
		object obj6 = !flag5;
		bool flag6 = (byte)(obj5 & obj6) != 0;
		object obj7 = !flag6;
		double num11 = ((obj7 != null) ? num2 : ((double)num9));
		open = (float)num11;
		bool flag7 = array == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj8 = (UnityEngine.Object)(nint)intPtr;
		if (!flag7)
		{
			double num12 = num11 + num11;
			double num13 = num11 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			double num14 = 3.0 - num12;
			num = num13 * num14;
			object obj12 = default;
			object obj11 = obj12;
			UnityEngine.Object obj14 = default;
			UnityEngine.Object obj13 = obj14;
			object obj15 = 4;
			object obj16 = 0;
			float num15 = 3f;
			object obj25 = default;
			double num18 = default;
			object obj28;
			do
			{
				Vector3[] array2 = (Vector3[])array.Length;
				object obj17 = obj15 - 4;
				bool flag8 = (nint)obj17 < array.Length;
				obj5 = !flag8;
				num10 = (float)obj17 - (float)array.Length;
				flag5 = num10 == 0f;
				flag6 = (nint)obj17 >= array.Length;
				obj12 = obj11;
				obj8 = obj8;
				obj14 = obj13;
				object obj18 = obj15;
				object obj19 = obj16;
				num11 = num13;
				num9 = num15;
				num2 = num14;
				if (!flag6)
				{
					bool flag9 = (nint)obj17 < array.Length;
					obj5 = !flag9;
					num10 = (float)obj17 - (float)array.Length;
					flag5 = num10 == 0f;
					if (obj5 == null)
					{
						object obj20 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v9 (UnityEngine.Transform[])+v187 @ X24_v6*8]");
						obj14 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v15+E4]");
						array2 = (Vector3[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v15+E4]");
						bool flag10 = (nint)0 == 0;
						object obj21 = !flag10;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = obj14 != null;
						bool flag12 = !flag11;
						obj8 = null;
						if (flag12)
						{
							goto IL_0428;
						}
						Transform[] array3 = doors;
						bool flag13 = doors == null;
						obj12 = 0;
						obj8 = null;
						obj18 = obj15;
						obj19 = obj16;
						num11 = num13;
						num9 = num15;
						num2 = num14;
						if (flag13)
						{
							break;
						}
						bool flag14 = (nint)obj17 < array3.Length;
						obj5 = !flag14;
						num10 = (float)obj17 - (float)array3.Length;
						flag5 = num10 == 0f;
						if (obj5 == null)
						{
							array2 = rest;
							bool flag15 = rest == null;
							obj12 = 0;
							obj8 = null;
							obj18 = obj15;
							obj19 = obj16;
							num11 = num13;
							num9 = num15;
							num2 = num14;
							if (flag15)
							{
								break;
							}
							bool flag16 = (nint)obj17 < array2.Length;
							obj5 = !flag16;
							num10 = (float)obj17 - (float)array2.Length;
							flag5 = num10 == 0f;
							if (obj5 == null)
							{
								array2 = (Vector3[])(object)((object)array2 + obj16);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13 (UnityEngine.Transform[])+v187 @ X24_v6*8]");
								obj14 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13 (UnityEngine.Transform[])+v187 @ X24_v6*8]");
								bool flag17 = (nint)0 == 0;
								obj12 = 0;
								obj8 = null;
								obj18 = obj15;
								obj19 = obj16;
								num11 = num13;
								num9 = num15;
								num2 = num14;
								if (flag17)
								{
									break;
								}
								object obj22 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v14+A0]");
								object obj23 = 0;
								double num16 = num * (double)rise;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+18]");
								object obj24 = 0 * obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+20]");
								double num17 = 0.0 * num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v1 (UnityEngine.Vector3[])+20]");
								num13 = 0.0 + (double)obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v1 (UnityEngine.Vector3[])+28]");
								num15 = 0f + (float)num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v13 (UnityEngine.Transform[])+v187 @ X24_v6*8]");
								((Transform)0).localPosition = (Vector3)0;
								obj8 = null;
								num14 = num18;
								goto IL_0428;
							}
						}
					}
					throw new IndexOutOfRangeException();
				}
				object obj26 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v4+E4]");
				bool flag18 = (nint)0 == 0;
				object obj27 = !flag18;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (block != null)
				{
					bool flag19 = (object)block == null;
					obj12 = 0;
					obj8 = null;
					if (flag19)
					{
						break;
					}
					float num19 = open;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					float num20 = num19 - 0f;
					bool flag20 = num20 < 0f;
					block.enabled = flag20;
				}
				return;
				IL_0428:
				array = doors;
				obj18 = obj15 + 1;
				obj19 = obj16 + 12;
				bool flag21 = doors == null;
				obj28 = !flag21;
				obj12 = 0;
				num11 = num13;
				num9 = num15;
				num2 = num14;
				obj11 = 0;
				obj13 = obj14;
				obj15 = obj18;
				obj16 = obj19;
			}
			while (obj28 != null);
		}
		throw new NullReferenceException();
	}

	public GillaSplashGate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_004f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6C8]");
		rise = 0f;
		base._002Ector();
	}
}
