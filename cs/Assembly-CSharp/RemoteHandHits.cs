using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class RemoteHandHits : MonoBehaviour
{
	public Transform left;

	public Transform right;

	public float reach;

	public float minSpeed;

	public float hardHitSpeed;

	public float volume;

	public float minInterval;

	public float minAirTime;

	private const int Solid = default(int);

	private AudioSource[] sources;

	private int next;

	private bool wasL;

	private bool wasR;

	private bool started;

	private Vector3 lastL;

	private Vector3 lastR;

	private float coolL;

	private float coolR;

	private float offL;

	private float offR;

	private float speedL;

	private float speedR;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0109: Expected F4, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4348]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 72;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4360]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
		object obj7 = 0;
		object obj8 = 0;
		int num = default;
		GameObject gameObject = default;
		AudioSource audioSource = default;
		while (true)
		{
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v6+18]");
			if ((nint)obj9 < 0)
			{
				string text = num.ToString();
				string text2 = (string)obj5 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				gameObject._002Ector(text2);
				Transform transform = gameObject.transform;
				Transform parent = base.transform;
				transform.SetParent(parent, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				audioSource.playOnAwake = false;
				audioSource.spatialBlend = 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				audioSource.minDistance = 0f;
				audioSource.maxDistance = 15f;
				audioSource.rolloffMode = (AudioRolloffMode)1;
				audioSource.dopplerLevel = 0f;
				object obj10 = obj2;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v10+18]");
				bool flag = (nint)num2 < (nint)0;
				object obj11 = !flag;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = obj10 + num;
				object obj13 = obj12 + 32;
				obj13 = audioSource;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj4 = obj2;
				obj8 = num + 1;
				bool flag2 = obj2 == null;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_024e: Expected VT, but got F4
		//IL_0276: Expected VT, but got F4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Ref, but got Unknown
		//IL_0157: Expected Ref, but got F4
		//IL_016d: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected VT, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Ref, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Ref, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Ref, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected VT, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Ref, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Ref, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Ref, but got Unknown
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
		bool flag2 = left == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = right == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 == null && sources != null)
		{
			float deltaTime = Time.deltaTime;
			if (~(started ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				ref Vector3 reference = ref *(Vector3*)(this + 112);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num = (float)reference - deltaTime;
				reference = ref *(Vector3*)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X20_v8 (UnityEngine.Vector3&)-50]");
				Vector3 position = ((Transform)0).position;
				Vector3 pos = (Vector3)(this + 84);
				ref float lastSpeed = default;
				Hand(pos, ref *(bool*)(this + 88), ref reference, ref *(float*)(this + 120), ref *(float*)(this + 128), ref lastSpeed, num);
				Vector3 position2 = right.position;
				Vector3 pos2 = (Vector3)(this + 85);
				Hand(pos2, ref *(bool*)(this + 100), ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 4), ref *(float*)(this + 124), ref *(float*)(this + 132), ref lastSpeed, num);
			}
			else
			{
				Vector3 position3 = left.position;
				lastL = (Vector3)deltaTime;
				Vector3 position4 = right.position;
				lastR = (Vector3)deltaTime;
				started = true;
			}
		}
	}

	private unsafe void Hand(Vector3 pos, ref bool was, ref Vector3 last, ref float cool, ref float off, ref float lastSpeed, float dt)
	{
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		//IL_06b0: Expected Obj, but got I
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_06ef: Expected Obj, but got I4
		//IL_0054: Expected Ref, but got F4
		//IL_00a3: Invalid comparison between F4 and I4
		//IL_00b2: Invalid comparison between F4 and I4
		//IL_00ca: Expected Obj, but got F4
		//IL_00d7: Expected Obj, but got F4
		//IL_00fb: Expected Ref, but got F4
		//IL_0114: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0160: Expected F4, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_0624: Expected native int or pointer, but got VT
		//IL_022a: Expected VT, but got I8
		//IL_023e: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_063a: Expected F4, but got I4
		//IL_02be: Invalid comparison between F4 and I4
		//IL_02cf: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_02f4: Invalid comparison between VT and I4
		//IL_0305: Expected Obj, but got I4
		//IL_0313: Invalid comparison between VT and I4
		//IL_0324: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_043b: Expected I4, but got Obj
		//IL_047b: Expected Obj, but got I
		//IL_04aa: Expected VT, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_04cd: Invalid comparison between F4 and I4
		//IL_0669: Expected Obj, but got I4
		//IL_04f4: Expected F8, but got I
		//IL_05c2: Expected F4, but got I
		//IL_05c2: Expected F4, but got I
		//IL_05c2: Expected Obj, but got I
		//IL_05d0: Expected Ref, but got F4
		//IL_05d9: Expected Obj, but got I4
		float num = dt - (float)(was ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [was @ X2 (System.Boolean&)+4]");
		object obj2 = default;
		object obj = obj2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [was @ X2 (System.Boolean&)+8]");
		object obj5 = default;
		object obj4 = obj5 - 0;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj8 = obj * obj;
		object obj9 = obj4 * obj4;
		float num3 = num2 + (float)obj8;
		ref bool reference = ref *(bool*)dt;
		float num4 = num3 + (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj10 = default;
		float num5 = num4 / (float)obj10;
		float num6 = num5 - off;
		bool flag2 = num6 < 0f;
		bool flag3 = num6 == 0f;
		object obj11 = num5 ^ off;
		object obj12 = num5 ^ num6;
		object obj13 = obj11 & obj12;
		bool flag4 = (nint)obj13 < 0;
		ref float reference2 = ref *(float*)num5;
		bool flag5 = flag2 == flag4;
		object obj14 = !flag3;
		object obj15 = flag5 & obj14;
		object obj16 = ~obj15;
		float num7 = ((obj16 != null) ? off : num5);
		float x;
		if ((double)num5 > 30.0)
		{
			x = 0f;
			goto IL_061c;
		}
		Transform transform = base.transform;
		if ((object)transform == null)
		{
			goto IL_05de;
		}
		Vector3 lossyScale = transform.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num8 = reach;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [was @ X2 (System.Boolean&)+8]");
		float num9 = num8 * 0f;
		Collider collider = Surfaces.Under((Vector3)4294961403L, dt, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = collider != null;
		object obj24;
		if (flag8)
		{
			bool flag9 = pos.x == 0f;
			object obj23 = !flag9;
			obj24 = 0;
			if (obj23 == null)
			{
				bool flag10 = last < (object)0;
				object obj25 = !flag10;
				bool flag11 = last == (Vector3)(object)0;
				object obj26 = !flag11;
				object obj27 = obj25 & obj26;
				obj24 = 0;
				if (obj27 == null)
				{
					bool flag12 = cool < minAirTime;
					obj24 = 0;
					if (!flag12)
					{
						bool flag13 = num7 < minSpeed;
						obj24 = 0;
						if (!flag13)
						{
							AudioSource[] array = sources;
							if (sources != null)
							{
								bool flag14 = next < array.Length;
								object obj28 = !flag14;
								if (obj28 != null)
								{
									goto IL_05ec;
								}
								object obj29 = next + 1;
								object obj30 = sources + next;
								object obj31 = obj29 / array.Length;
								object obj32 = obj31 * array.Length;
								int num10 = obj29 - obj32;
								next = num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v20+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v20+20]");
									Transform transform2 = ((Component)0).transform;
									if ((object)transform2 != null)
									{
										transform2.position = (Vector3)0;
										object obj33 = 17276928;
										float num11 = num7 / hardHitSpeed;
										double num12;
										if (num11 < 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
											num12 = 0.0;
										}
										else
										{
											bool flag15 = (double)num11 > 1.0;
											num12 = 1.0;
											if (!flag15)
											{
												float num13 = num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
												num11 = num13 * 0f;
												double num14 = num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v21+D00]");
												num12 = num14 + 0.0;
											}
										}
										object obj34 = obj17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v23+E4]");
										bool flag16 = (nint)0 == 0;
										object obj35 = !flag16;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float loud = volume * (float)num12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v20+20]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE68]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
										bool flag17 = Surfaces.Play((AudioSource)num15, collider, loud, num16, 0f);
										ref Vector3 reference3 = ref *(Vector3*)minInterval;
										obj24 = 0;
										goto IL_062a;
									}
								}
							}
							goto IL_05de;
						}
					}
				}
			}
		}
		else
		{
			obj24 = cool + obj10;
		}
		goto IL_062a;
		IL_062a:
		ref float reference4 = ref *(float*)obj24;
		x = (flag8 ? 1 : 0);
		goto IL_061c;
		IL_061c:
		((Vector3*)(nint)pos)->x = x;
		return;
		IL_05ec:
		throw new IndexOutOfRangeException();
		IL_05de:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ec;
	}

	public RemoteHandHits()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C900]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BB38]");
		minInterval = 0f;
		base._002Ector();
	}
}
