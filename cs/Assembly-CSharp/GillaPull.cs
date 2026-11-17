using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaPull : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__7_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F20]");
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

		internal bool _003CForget_003Eb__7_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ModMenuAccess.IsModerator;
		}

		internal bool _003C_002Ecctor_003Eb__39_0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ModMenuAccess.IsModerator;
		}
	}

	private class Limb
	{
		public Transform drawn;

		public GillaCorpse body;

		public int part;

		public Transform shoulder;

		public Transform up;

		public Transform lo;

		public Transform end;

		public Transform head;

		public Vector3 shoulderAt;

		public Vector3 loAt;

		public Vector3 endAt;

		public Vector3 upRest;

		public Vector3 loRest;

		public Vector3 endRest;

		public Vector3 headAt;

		public Vector3 upHad;

		public Vector3 loHad;

		public Vector3 offset;

		public Quaternion upTurn;

		public Quaternion loTurn;

		public Quaternion endTurn;

		public Quaternion headTurn;

		public float keepOffset;

		public float lengthUp;

		public float lengthLo;

		public float reach;

		public bool off;

		public Transform away;

		public Transform eyes;

		public Vector3 awayAt;

		public Transform spine;

		public Vector3 spineAt;

		public int across;

		public float width;

		public readonly List<(Transform, Vector3)> onSpine;

		public Limb()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BF8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<(System.__Canon, Vector3)> list = default;
			list._002Ector();
			object obj2 = this + 352;
			onSpine = (List<(Transform, Vector3)>)(object)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private const float LeastStretch = default(float);

	private const float ShoulderShare = default(float);

	private const float DrawShare = default(float);

	private const float MiddleWide = default(float);

	private const float Takes = default(float);

	private const float EasesBack = default(float);

	private const float Follows = default(float);

	private const float ArmFromHead = default(float);

	private const float Spring = default(float);

	private const float Damping = default(float);

	private static readonly List<GillaQuests.Pull> pulls;

	private static GillaQuests.Pull mine;

	private readonly Dictionary<int, int> grips;

	public static float MineStrain
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0207: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got I
			//IL_023a: Expected Obj, but got I
			//IL_025a: Expected F4, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00b3: Expected F4, but got I4
			//IL_007e: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I4
			//IL_014a: Expected Obj, but got I4
			//IL_0153: Expected F4, but got I4
			//IL_0113: Expected Obj, but got I
			//IL_0123: Expected Obj, but got I
			//IL_0183: Expected Obj, but got I4
			//IL_01d8: Expected F4, but got I
			//IL_01b3: Expected Obj, but got I
			//IL_01c3: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
			bool flag2 = (nint)0 == 0;
			float result = 0f;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+A0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+8]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v10+98]");
				bool flag4 = (nint)0 == 0;
				result = 0f;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+A0]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v14+8]");
						obj5 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v10+99]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					result = 0f;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v8+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj12 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+A0]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
							obj5 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v10+88]");
						result = 0f;
					}
				}
			}
			return result;
		}
	}

	private static void Make()
	{
		//IL_0010: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
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
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F80]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+1C]");
		object obj9 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+18]");
			Array.Clear((Array)num, 0, 0);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+A0]");
			obj4 = 0;
		}
		object obj11 = obj4 + 8;
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj7);
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F70]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
	}

	public static void Mine(Dismemberment ape, GillaCorpse body, ApePart part, Transform grip, Transform a, Transform b, float tears)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Mine(ape, body, part, middle: false, grip, a, b, tears);
	}

	public static void MineMiddle(Dismemberment ape, Transform grip, Transform a, Transform b, float tears)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Mine(ape, null, (ApePart)0, middle: true, grip, a, b, tears);
	}

	private static void Mine(Dismemberment ape, GillaCorpse body, ApePart part, bool middle, Transform grip, Transform a, Transform b, float tears)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I4
		//IL_078b: Expected Obj, but got I
		//IL_079b: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_07f2: Expected Obj, but got I4
		//IL_05b9: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_070b: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I
		//IL_047e: Expected I4, but got Obj
		//IL_042a: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		ApePart apePart = part;
		UnityEngine.Object obj6 = body;
		object obj28;
		Transform transform;
		ApePart apePart2;
		bool flag19;
		bool flag20;
		GillaQuests.Pull pull;
		object obj25;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v46+8]");
				obj5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v28+98]");
			bool flag4 = (nint)0 == 0;
			apePart = part;
			obj6 = body;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v44+8]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v28+99]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				apePart = part;
				obj6 = body;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v41+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v42+8]");
						obj5 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v32+E4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v28+38]");
					bool flag9 = (UnityEngine.Object)0 == ape;
					obj2 = obj;
					bool flag10 = !flag9;
					apePart = (ApePart)0;
					obj6 = ape;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
						bool flag11 = (nint)0 == 0;
						object obj18 = !flag11;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj2 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v31+8]");
						object obj20 = 0;
						object obj21 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v38+E4]");
						bool flag12 = (nint)0 == 0;
						object obj22 = !flag12;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v32+30]");
						bool flag13 = (UnityEngine.Object)0 == body;
						obj2 = obj;
						bool flag14 = !flag13;
						apePart = (ApePart)0;
						obj6 = body;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
							bool flag15 = (nint)0 == 0;
							object obj23 = !flag15;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v35+8]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X26_v6+44]");
							bool flag16 = (nint)0 != (nint)part;
							apePart = (ApePart)0;
							obj6 = body;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
								bool flag17 = (nint)0 == 0;
								object obj26 = !flag17;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj2 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v40+8]");
									obj25 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X26_v6+48]");
								bool flag18 = (nint)0 == (middle ? 1 : 0);
								apePart = (ApePart)0;
								obj6 = body;
								IntPtr intPtr = default;
								transform = (Transform)(nint)intPtr;
								apePart2 = (middle ? ((ApePart)1) : ((ApePart)0));
								flag19 = (byte)(int)grip != 0;
								flag20 = false;
								pull = (GillaQuests.Pull)(object)body;
								obj28 = obj2;
								if (flag18)
								{
									goto IL_0646;
								}
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
		bool flag21 = (nint)0 == 0;
		object obj29 = !flag21;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v15+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
			bool flag22 = (nint)0 == 0;
			object obj31 = !flag22;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+A0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24+8]");
				object obj33 = 0;
			}
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v44+E4]");
		bool flag23 = (nint)0 == 0;
		object obj34 = !flag23;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform a2 = default;
		Transform transform2 = default;
		float tears2 = default;
		GillaQuests.Pull pull2 = Pulling(ape, body, yours: false, part, middle, grip, a2, transform2, tears2);
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v19+A0]");
		object obj36 = (nint)0 + (nint)8;
		obj36 = pull2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v7+A0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v22+8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v22+8]");
		bool flag24 = (nint)0 == 0;
		transform = transform2;
		apePart2 = part;
		flag19 = middle;
		flag20 = false;
		pull = pull2;
		if (!flag24)
		{
			goto IL_0646;
		}
		return;
		IL_0646:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v7+E4]");
		int frameCount;
		if ((nint)0 != 0)
		{
			frameCount = Time.frameCount;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v11+A0]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+8]");
		obj25 = 0;
		frameCount = Time.frameCount;
	}

	public unsafe static bool Tearing(Dismemberment ape, ApePart part)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got I4
		//IL_03e1: Expected I4, but got Obj
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Ref, but got Unknown
		//IL_0404: Expected Obj, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected I4, but got Obj
		//IL_009e: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
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
		GillaQuests.Pull pull = (GillaQuests.Pull)0;
		bool flag2 = pull == null;
		GillaQuests.Pull pull3 = default;
		GillaQuests.Pull pull2 = pull3;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FC0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FB8]");
			object obj5 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)pull).GetEnumerator();
			pull = pull3;
			Enumerator<, > val2 = default;
			bool result2 = default;
			object obj15 = default;
			object obj11;
			Enumerator<, > val3;
			Enumerator<, > val4;
			ApePart apePart = default;
			while (true)
			{
				bool result;
				object obj12;
				if (val.MoveNext())
				{
					if (pull3 == null)
					{
						break;
					}
					bool flag3 = (byte)(~(pull3.middle ? 1u : 0u)) != 0;
					object obj6 = !flag3;
					pull = (GillaQuests.Pull)pull3.middle;
					if (obj6 != null)
					{
						continue;
					}
					bool flag4 = pull3.part != apePart;
					pull = (GillaQuests.Pull)pull3.part;
					if (flag4)
					{
						continue;
					}
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v32+E4]");
					pull = (GillaQuests.Pull)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v32+E4]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!Owns(pull3, ape))
					{
						continue;
					}
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v36+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Snap(pull3);
					pull2 = null;
					val = val2;
					obj11 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					result = true;
					obj12 = 0;
					goto IL_03d9;
				}
				pull2 = null;
				val = val2;
				obj11 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				obj12 = 0;
				goto IL_0412;
				IL_03d9:
				apePart = (ApePart)obj5;
				((Enumerator<, >*)val4)->Dispose();
				bool flag7 = obj12 == null;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					bool flag8 = pull2 == null;
					object obj14 = !flag8;
					OutOfMemoryException ex = (OutOfMemoryException)val4;
					if (obj14 == null)
					{
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (apePart == (ApePart)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					pull2 = (GillaQuests.Pull)1;
					pull = (GillaQuests.Pull)1;
					obj12 = obj11;
				}
				else
				{
					if (apePart != (ApePart)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D998");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj12 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj11 = obj15;
				}
				goto IL_0412;
				IL_0412:
				result = false;
				goto IL_03d9;
			}
			NullReferenceException ex2 = new NullReferenceException();
			pull2 = null;
			val = val2;
			obj11 = 0;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			apePart = (ApePart)obj4;
		}
		throw new NullReferenceException();
	}

	public unsafe static bool Tearing(GillaCorpse body, ApePart part)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got I4
		//IL_0405: Expected I4, but got Obj
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Ref, but got Unknown
		//IL_0428: Expected Obj, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_014a: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0173: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_01e3: Expected I, but got Obj
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+A0]");
		GillaQuests.Pull pull = (GillaQuests.Pull)0;
		bool flag2 = pull == null;
		GillaQuests.Pull pull3 = default;
		GillaQuests.Pull pull2 = pull3;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FC0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FB8]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)pull).GetEnumerator();
			pull = pull3;
			Enumerator<, > val2 = default;
			bool result2 = default;
			object obj16 = default;
			object obj12;
			Enumerator<, > val3;
			Enumerator<, > val4;
			ApePart apePart = default;
			while (true)
			{
				bool result;
				object obj13;
				if (val.MoveNext())
				{
					if (pull3 == null)
					{
						break;
					}
					bool flag3 = (byte)(~(pull3.middle ? 1u : 0u)) != 0;
					object obj7 = !flag3;
					pull = (GillaQuests.Pull)pull3.middle;
					if (obj7 != null)
					{
						continue;
					}
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v32+E4]");
					pull = (GillaQuests.Pull)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v32+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = pull3.body == body;
					bool flag6 = !flag5;
					nint num = unchecked((nint)null);
					if (flag6)
					{
						continue;
					}
					bool flag7 = pull3.part != apePart;
					num = unchecked((nint)null);
					pull = (GillaQuests.Pull)pull3.part;
					if (flag7)
					{
						continue;
					}
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v36+E4]");
					bool flag8 = (nint)0 == 0;
					object obj11 = !flag8;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Snap(pull3);
					num = unchecked((nint)null);
					pull2 = null;
					val = val2;
					obj12 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					result = true;
					obj13 = 0;
					goto IL_03fd;
				}
				pull2 = null;
				val = val2;
				obj12 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				obj13 = 0;
				goto IL_0436;
				IL_0436:
				result = false;
				goto IL_03fd;
				IL_03fd:
				apePart = (ApePart)obj6;
				((Enumerator<, >*)val4)->Dispose();
				bool flag9 = obj13 == null;
				object obj14 = !flag9;
				if (obj14 == null)
				{
					bool flag10 = pull2 == null;
					object obj15 = !flag10;
					OutOfMemoryException ex = (OutOfMemoryException)val4;
					if (obj15 == null)
					{
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (apePart == (ApePart)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					pull2 = (GillaQuests.Pull)1;
					pull = (GillaQuests.Pull)1;
					obj13 = obj12;
				}
				else
				{
					if (apePart != (ApePart)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D998");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj13 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj16;
				}
				goto IL_0436;
			}
			NullReferenceException ex2 = new NullReferenceException();
			pull2 = null;
			val = val2;
			obj12 = 0;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			apePart = (ApePart)obj4;
		}
		throw new NullReferenceException();
	}

	public static void Done(Dismemberment ape)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I4
		//IL_0807: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_016d: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected I, but got Obj
		//IL_07e1: Expected I, but got Obj
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got I4
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected I, but got Obj
		//IL_063a: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected VT, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected I, but got Obj
		//IL_0616: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected VT, but got I4
		//IL_0458: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+18]");
			int num = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FA8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE0]");
			object obj9 = 0;
			Enumerator<, > val = (Enumerator<, >)0;
			Limb limb = default;
			Enumerator<, > val3 = default;
			while (true)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v20+A0]");
				object obj12 = 0;
				if (obj12 == null)
				{
					break;
				}
				object obj13 = obj6;
				System.__Canon _Canon = ((List<System.__Canon>)obj12).get_Item(num);
				bool flag3 = Owns((GillaQuests.Pull)(object)_Canon, ape);
				bool flag4 = !flag3;
				limb = limb;
				nint num2 = (nint)ape;
				if (!flag4)
				{
					bool flag5 = _Canon == null;
					num2 = (nint)ape;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v22 (System.__Canon)+A0]");
					bool flag6 = (nint)0 == 0;
					num2 = (nint)ape;
					if (flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v22 (System.__Canon)+A0]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Enumerator<, > val2 = val3;
					while (true)
					{
						num2 = (nint)obj7;
						Enumerator<, > val4;
						if (val.MoveNext())
						{
							object obj14 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v43+E4]");
							bool flag7 = (nint)0 == 0;
							object obj15 = !flag7;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Back(limb);
							NullReferenceException ex;
							if (limb != null)
							{
								object obj16 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v47+E4]");
								bool flag8 = (nint)0 == 0;
								object obj17 = !flag8;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag9 = limb.body == null;
								bool flag10 = !flag9;
								obj13 = 0;
								if (flag10)
								{
									continue;
								}
								object obj18 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v51+E4]");
								bool flag11 = (nint)0 == 0;
								object obj19 = !flag11;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag12 = limb.up != null;
								bool flag13 = !flag12;
								obj13 = 0;
								if (flag13)
								{
									continue;
								}
								object obj20 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v55+E4]");
								bool flag14 = (nint)0 == 0;
								object obj21 = !flag14;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag15 = limb.lo != null;
								bool flag16 = !flag15;
								obj13 = 0;
								if (!flag16)
								{
									if ((object)limb.up == null)
									{
										ex = new NullReferenceException();
										val4 = (Enumerator<, >)(ref val);
										num2 = unchecked((nint)null);
										obj13 = 0;
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ stack_-88_v7 (GillaPull+Limb)+78]");
									object obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ stack_-88_v7 (GillaPull+Limb)+7C]");
									object obj23 = 0;
									val2 = (Enumerator<, >)limb.upRest;
									limb.up.localScale = (Vector3)0;
									if ((object)limb.lo == null)
									{
										ex = new NullReferenceException();
										val4 = (Enumerator<, >)(ref val);
										num2 = unchecked((nint)null);
										obj13 = 0;
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ stack_-88_v7 (GillaPull+Limb)+84]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ stack_-88_v7 (GillaPull+Limb)+88]");
									obj23 = 0;
									val2 = (Enumerator<, >)limb.loRest;
									limb.lo.localScale = (Vector3)0;
									obj13 = 0;
								}
								continue;
							}
							ex = new NullReferenceException();
							val4 = (Enumerator<, >)(ref val);
							break;
						}
						num2 = (nint)obj9;
						val.Dispose();
						val4 = (Enumerator<, >)(ref val);
						OutOfMemoryException ex2 = new OutOfMemoryException();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D9D4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				int num3 = num - 1;
				bool flag17 = num > 0;
				num = num3;
				if (!flag17)
				{
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	private static bool Owns(GillaQuests.Pull p, Dismemberment ape)
	{
		//IL_0305: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		if (p == null)
		{
			goto IL_02f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool result;
		if (p.ape == ape)
		{
			result = true;
			goto IL_0322;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
		}
		if (~(p.yours ? 1u : 0u) == 0)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v13+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v4+8]");
			UnityEngine.Object obj11 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v4+8]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v4+8]");
				if ((nint)0 != 0)
				{
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v19+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X20_v6 (UnityEngine.Object)+68]");
					if (!((UnityEngine.Object)0 != null))
					{
						goto IL_02e9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X20_v6 (UnityEngine.Object)+68]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X20_v6 (UnityEngine.Object)+68]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v14+20]");
						bool flag6 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v14+20]");
						result = false;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v14+20]");
							int num = Array.IndexOf((System.__Canon[])0, (System.__Canon)(object)ape);
							int num2 = ~num;
							result = (byte)(num2 >> 31) != 0;
						}
						goto IL_0322;
					}
				}
				goto IL_02f7;
			}
		}
		goto IL_02e9;
		IL_02e9:
		result = false;
		goto IL_0322;
		IL_0322:
		return result;
		IL_02f7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static void WetSnap(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00e8: Expected VT, but got I4
		//IL_00e8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (UnityEngine.Object)+70]");
			float volume = default;
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play((AudioClip[])0, (Vector3)0, volume, pitchMin, pitchMax);
		}
	}

	private unsafe static void Snap(GillaQuests.Pull p)
	{
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_003a: Invalid comparison between F4 and I4
		//IL_0057: Expected F8, but got I4
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got I4
		//IL_0727: Expected Obj, but got I
		//IL_072f: Expected I, but got Obj
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Ref, but got Unknown
		//IL_0752: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_04be: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0185: Expected VT, but got I4
		//IL_04d5: Expected Obj, but got I4
		//IL_04de: Expected Obj, but got I4
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I
		//IL_028f: Expected VT, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_02c2: Expected I, but got Obj
		//IL_01d6: Expected F8, but got I
		//IL_01e6: Expected F8, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected VT, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_0215: Expected VT, but got I4
		//IL_03c7: Expected Obj, but got I4
		//IL_02e0: Expected F8, but got I
		//IL_02f0: Expected F8, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected VT, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_031f: Expected VT, but got I4
		//IL_03ea: Expected F8, but got I
		//IL_03fa: Expected F8, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected VT, but got I4
		//IL_0420: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		bool flag = p == null;
		object obj2 = default;
		object obj = obj2;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj3 = 109891584;
		if (!flag)
		{
			bool flag2 = (byte)(~(p.snapped ? 1u : 0u)) != 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
			bool flag3 = p.strain < 0f;
			p.snapped = true;
			double num = 0.0;
			if (!flag3)
			{
				bool flag4 = !((double)p.strain > 1.0);
				num = p.strain;
				if (!flag4)
				{
					num = 1.0;
				}
			}
			double num2 = num + num;
			p.v = 0f;
			double num3 = num * 3.0;
			double num4 = num * num2;
			double num5 = num * num3;
			double num6 = num * num4;
			double num7 = num5 - num6;
			double num8 = 1.0 - num7;
			double num9 = num8 * 0.0;
			double num10 = num7 + num9;
			p.x = (float)num10;
			bool flag5 = p.limbs == null;
			obj = obj2;
			val = (Enumerator<, >)0;
			Enumerator<, > val2 = (Enumerator<, >)num10;
			obj3 = 109891584;
			if (!flag5)
			{
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)p.limbs).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				Enumerator<, > val3 = default;
				val2 = val3;
				object obj19 = default;
				object obj14;
				Enumerator<, > val4;
				while (true)
				{
					UnityEngine.Object obj6 = (UnityEngine.Object)obj3;
					nint num11;
					if (val.MoveNext())
					{
						if (obj2 != null)
						{
							object obj7 = obj5;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v35+E4]");
							bool flag6 = (nint)0 == 0;
							object obj8 = !flag6;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+48]");
							bool flag7 = (UnityEngine.Object)0 != null;
							bool flag8 = !flag7;
							Vector3 vector = (Vector3)0;
							object obj9;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+48]");
								bool flag9 = (nint)0 == 0;
								obj9 = 0;
								obj6 = null;
								if (flag9)
								{
									goto IL_04ad;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+9C]");
								num7 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+A0]");
								num8 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+98]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+48]");
								((Transform)0).localPosition = (Vector3)0;
								vector = (Vector3)0;
							}
							object obj10 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v40+E4]");
							bool flag10 = (nint)0 == 0;
							object obj11 = !flag10;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+38]");
							bool flag11 = (UnityEngine.Object)0 != null;
							bool flag12 = !flag11;
							Vector3 vector2 = (Vector3)0;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+38]");
								bool flag13 = (nint)0 == 0;
								obj9 = 0;
								num11 = unchecked((nint)null);
								if (flag13)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+60]");
								num7 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+64]");
								num8 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+5C]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+38]");
								((Transform)0).localPosition = (Vector3)0;
								vector2 = (Vector3)0;
							}
							object obj12 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v45+E4]");
							bool flag14 = (nint)0 == 0;
							object obj13 = !flag14;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+40]");
							bool flag15 = (UnityEngine.Object)0 != null;
							bool flag16 = !flag15;
							obj9 = 0;
							if (flag16)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+40]");
							bool flag17 = (nint)0 == 0;
							obj9 = 0;
							obj6 = null;
							if (!flag17)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+6C]");
								num7 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+70]");
								num8 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+68]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ stack_-58+40]");
								((Transform)0).localPosition = (Vector3)0;
								obj9 = 0;
								continue;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
						}
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_04ad;
					}
					obj = 0;
					obj14 = 0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					object obj15 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE0]");
						object obj16 = 0;
						num11 = (nint)obj16;
						((Enumerator<, >*)val4)->Dispose();
						bool flag18 = obj15 == null;
						object obj17 = !flag18;
						if (obj17 == null)
						{
							bool flag19 = obj == null;
							object obj18 = !flag19;
							OutOfMemoryException ex3 = (OutOfMemoryException)val4;
							if (obj18 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch ((long)num11)
						{
						case 2L:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj = 1;
							obj15 = obj14;
							break;
						case 1L:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj15 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj14 = obj19;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D9D4");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
					}
					return;
					IL_04ad:
					NullReferenceException ex4 = new NullReferenceException();
					num11 = (nint)obj6;
					break;
				}
				NullReferenceException ex5 = new NullReferenceException();
				obj = 0;
				obj14 = 0;
				val = val3;
				val4 = (Enumerator<, >)(ref val);
			}
		}
		throw new NullReferenceException();
	}

	private static GillaQuests.Pull Pulling(Dismemberment ape, GillaCorpse body, bool yours, ApePart part, bool middle, Transform grip, Transform a, Transform b, float tears)
	{
		//IL_0010: Expected Obj, but got I
		//IL_163a: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_1658: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I4
		//IL_17b5: Expected Obj, but got I4
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected Obj, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_168d: Expected Obj, but got I
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected Obj, but got Unknown
		//IL_08ae: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I4
		//IL_08f5: Expected VT, but got I
		//IL_02dc: Expected Obj, but got I4
		//IL_17d3: Expected Obj, but got I
		//IL_17fd: Expected Obj, but got I4
		//IL_16ba: Expected Obj, but got I
		//IL_0947: Expected Obj, but got VT
		//IL_0aa8: Expected Obj, but got I4
		//IL_09db: Expected Obj, but got I4
		//IL_0f74: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_0b1a: Expected Obj, but got I4
		//IL_0a4d: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I4
		//IL_0fe6: Expected Obj, but got I4
		//IL_0b9e: Expected Obj, but got I
		//IL_0bc8: Expected Obj, but got I4
		//IL_16e7: Expected Obj, but got I
		//IL_1224: Expected Obj, but got I
		//IL_124e: Expected Obj, but got I4
		//IL_0c19: Expected Obj, but got I4
		//IL_129f: Expected Obj, but got I4
		//IL_10ba: Expected Obj, but got I4
		//IL_1842: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I4
		//IL_1338: Expected Obj, but got I4
		//IL_0ce1: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I4
		//IL_1367: Expected Obj, but got I
		//IL_1150: Expected Obj, but got I4
		//IL_1714: Expected Obj, but got I
		//IL_0d1c: Expected Obj, but got I
		//IL_13a2: Expected Obj, but got I
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Expected Obj, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected Obj, but got Unknown
		//IL_0d51: Expected Obj, but got I
		//IL_13d7: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_054f: Expected Obj, but got I
		//IL_0563: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I4
		//IL_0dc9: Expected Obj, but got I8
		//IL_0ddf: Expected Obj, but got I
		//IL_0df2: Expected Obj, but got I4
		//IL_05bb: Expected Obj, but got I4
		//IL_144f: Expected Obj, but got I8
		//IL_1465: Expected Obj, but got I
		//IL_1480: Expected Obj, but got I4
		//IL_1824: Expected Obj, but got I4
		//IL_1741: Expected Obj, but got I
		//IL_1880: Expected Obj, but got I4
		//IL_0e21: Expected Obj, but got I4
		//IL_14af: Expected Obj, but got I4
		//IL_0e50: Expected Obj, but got I
		//IL_14de: Expected Obj, but got I
		//IL_0f01: Expected Obj, but got I
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected Obj, but got Unknown
		//IL_0637: Expected Obj, but got I4
		//IL_15ad: Expected Obj, but got I
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Expected Obj, but got Unknown
		//IL_0ea0: Expected Obj, but got I4
		//IL_1533: Expected Obj, but got I4
		//IL_0ed3: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I4
		//IL_156e: Expected Obj, but got I
		//IL_176e: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_0715: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = grip == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		GillaQuests.Pull result = null;
		object obj11;
		ApePart apePart = default;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = a == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			result = null;
			if (obj7 == null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v12+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = b == null;
				bool flag9 = !flag8;
				object obj10 = !flag9;
				result = null;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
					obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v17+E4]");
					bool flag10 = (nint)0 == 0;
					object obj13 = !flag10;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v17+A0]");
					object obj14 = 0;
					object obj15 = obj14;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9+18]");
						int num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9+18]");
						bool flag11 = (nint)0 < (nint)1;
						object obj16 = 0;
						UnityEngine.Object obj17 = null;
						if (flag11)
						{
							goto IL_0747;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FA8]");
						object obj18 = 0;
						object obj19 = 0;
						UnityEngine.Object obj20 = null;
						while (true)
						{
							object obj21 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v147+E4]");
							bool flag12 = (nint)0 == 0;
							object obj22 = !flag12;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj21 = obj11;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v147+A0]");
							object obj23 = 0;
							if (obj23 == null)
							{
								break;
							}
							obj16 = obj18;
							num--;
							System.__Canon _Canon = ((List<System.__Canon>)obj23).get_Item(num);
							if (_Canon == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v149 (System.__Canon)+44]");
							bool flag13 = (nint)0 != (nint)apePart;
							obj17 = (UnityEngine.Object)num;
							if (!flag13)
							{
								object obj24 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v152+E4]");
								bool flag14 = (nint)0 == 0;
								object obj25 = !flag14;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj24 = obj11;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v152+A0]");
								object obj26 = 0;
								if (obj26 == null)
								{
									break;
								}
								obj16 = obj18;
								System.__Canon _Canon2 = ((List<System.__Canon>)obj26).get_Item(num);
								if (_Canon2 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v154 (System.__Canon)+48]");
								bool flag15 = (nint)0 != (middle ? 1 : 0);
								obj17 = (UnityEngine.Object)num;
								if (!flag15)
								{
									object obj27 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v156+E4]");
									bool flag16 = (nint)0 == 0;
									object obj28 = !flag16;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj27 = obj11;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v156+A0]");
									object obj29 = 0;
									if (obj29 == null)
									{
										break;
									}
									System.__Canon _Canon3 = ((List<System.__Canon>)obj29).get_Item(num);
									if (_Canon3 == null)
									{
										break;
									}
									object obj30 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v159+E4]");
									bool flag17 = (byte)(~(nuint)0u) != 0;
									object obj31 = !flag17;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v158 (System.__Canon)+30]");
									bool flag18 = (UnityEngine.Object)0 == body;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									obj = 0;
									bool flag19 = !flag18;
									obj16 = 0;
									obj17 = body;
									if (!flag19)
									{
										object obj32 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v164+E4]");
										bool flag20 = (nint)0 == 0;
										object obj33 = !flag20;
										if (obj33 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj32 = obj11;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v164+A0]");
										object obj34 = 0;
										if (obj34 == null)
										{
											break;
										}
										System.__Canon _Canon4 = ((List<System.__Canon>)obj34).get_Item(num);
										if (_Canon4 == null)
										{
											break;
										}
										object obj35 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v167+E4]");
										bool flag21 = (byte)(~(nuint)0u) != 0;
										object obj36 = !flag21;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v166 (System.__Canon)+38]");
										bool flag22 = (UnityEngine.Object)0 == ape;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										obj = 0;
										bool flag23 = !flag22;
										obj16 = 0;
										obj17 = ape;
										if (!flag23)
										{
											object obj37 = obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v172+E4]");
											bool flag24 = (nint)0 == 0;
											object obj38 = !flag24;
											if (obj38 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj37 = obj11;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v172+A0]");
											object obj39 = 0;
											if (obj39 == null)
											{
												break;
											}
											obj16 = obj18;
											System.__Canon _Canon5 = ((List<System.__Canon>)obj39).get_Item(num);
											if (_Canon5 == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v174 (System.__Canon)+40]");
											bool flag25 = (nint)0 != (yours ? 1 : 0);
											obj17 = (UnityEngine.Object)num;
											if (!flag25)
											{
												object obj40 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v176+E4]");
												bool flag26 = (nint)0 == 0;
												object obj41 = !flag26;
												if (obj41 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj40 = obj11;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v176+A0]");
												object obj42 = 0;
												if (obj42 == null)
												{
													break;
												}
												System.__Canon p = ((List<System.__Canon>)obj42).get_Item(num);
												Finish((GillaQuests.Pull)(object)p);
												object obj43 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v85+A0]");
												object obj44 = 0;
												if (obj44 == null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F90]");
												object obj45 = 0;
												obj16 = obj45;
												((List<System.__Canon>)obj44).RemoveAt(num);
												obj17 = (UnityEngine.Object)num;
											}
										}
									}
								}
							}
							bool flag27 = num > 0;
							obj19 = obj16;
							obj20 = obj17;
							if (flag27)
							{
								continue;
							}
							goto IL_0747;
						}
					}
					goto IL_15f4;
				}
			}
		}
		goto IL_11e8;
		IL_15e7:
		ApePart apePart2;
		apePart = apePart2;
		goto IL_103f;
		IL_11e8:
		return result;
		IL_0f40:
		Transform transform = null;
		goto IL_103f;
		IL_0747:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FB0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaQuests.Pull pull = default;
		pull._002Ector();
		if (pull != null)
		{
			object obj47 = pull + 56;
			obj47 = ape;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj48 = pull + 48;
			obj48 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			pull.part = apePart;
			pull.yours = yours;
			pull.middle = middle;
			object obj49 = pull + 80;
			obj49 = grip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj50 = pull + 88;
			obj50 = a;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj51 = pull + 96;
			obj51 = b;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			_ = 0;
			if ((object)a != null)
			{
				Vector3 position = a.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj52 = 0;
				if ((object)b != null)
				{
					Vector3 position2 = b.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					Vector3 vector = (Vector3)(num2 - 0);
					object obj54 = default;
					object obj53 = obj54 - obj54;
					object obj56 = default;
					object obj55 = obj56 - obj56;
					pull.from = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj57 = 0;
					object obj58 = obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v44+E4]");
					bool flag28 = (nint)0 == 0;
					object obj59 = !flag28;
					if (obj59 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj60 = vector * vector;
					object obj61 = obj53 * obj53;
					object obj62 = obj52;
					object obj63 = obj60 + obj61;
					object obj64 = obj55 * obj55;
					float start = (float)obj63 + (float)obj64;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					pull.start = start;
					Limb limb3;
					Limb limb;
					if (middle)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v46+E4]");
						bool flag29 = (nint)0 == 0;
						object obj65 = !flag29;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(ape != null))
						{
							bool flag30 = !yours;
							transform = null;
							limb = null;
							if (!flag30)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj66 = 0;
								object obj67 = obj66;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v107+E4]");
								bool flag31 = (nint)0 == 0;
								object obj68 = !flag31;
								if (obj68 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC04B8");
								object obj69 = obj52;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v54+E4]");
								bool flag32 = (nint)0 == 0;
								object obj70 = !flag32;
								if (obj70 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object obj71 = default;
								bool flag33 = obj71 != null;
								bool flag34 = !flag33;
								transform = null;
								limb = null;
								if (!flag34)
								{
									if ((object)obj71 == null)
									{
										goto IL_15f4;
									}
									object obj72 = obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v114+E4]");
									bool flag35 = (nint)0 == 0;
									object obj73 = !flag35;
									if (obj73 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v110 (UnityEngine.Object)+68]");
									bool flag36 = (UnityEngine.Object)0 != null;
									bool flag37 = !flag36;
									transform = null;
									limb = null;
									if (!flag37)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v110 (UnityEngine.Object)+68]");
										object obj74 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v110 (UnityEngine.Object)+68]");
										if ((nint)0 == 0)
										{
											goto IL_15f4;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v56+20]");
										object obj75 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v56+20]");
										bool flag38 = (nint)0 == 0;
										transform = null;
										limb = null;
										if (!flag38)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v8+18]");
											bool flag39 = (nint)0 < (nint)1;
											transform = null;
											limb = null;
											if (!flag39)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v8+18]");
												object obj76 = 0 & 0xFFFFFFFFL;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v56+20]");
												object obj77 = (nint)0 + (nint)32;
												Transform transform2 = null;
												UnityEngine.Object obj78 = null;
												object obj79 = 0;
												while (true)
												{
													bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj79) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76);
													object obj80 = !flag40;
													if (obj80 != null)
													{
														break;
													}
													object obj81 = obj52;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X0_v119+E4]");
													bool flag41 = (nint)0 == 0;
													object obj82 = !flag41;
													if (obj82 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X24_v9+v610 @ X23_v11*8]");
													bool flag42 = (UnityEngine.Object)0 != null;
													bool flag43 = !flag42;
													limb = null;
													if (!flag43)
													{
														object obj83 = obj11;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v124+E4]");
														bool flag44 = (nint)0 == 0;
														object obj84 = !flag44;
														if (obj84 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X24_v9+v610 @ X23_v11*8]");
														Limb limb2 = OfMiddle((Dismemberment)0, drawnAlong: false);
														Add(pull, limb2);
														limb = limb2;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v8+18]");
													obj76 = 0;
													obj79++;
													object obj85 = obj79;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X20_v8+18]");
													bool flag45 = (nint)obj85 < 0;
													transform2 = null;
													obj78 = (UnityEngine.Object)(object)limb;
													if (flag45)
													{
														continue;
													}
													goto IL_0f40;
												}
												goto IL_1602;
											}
										}
									}
								}
							}
							goto IL_103f;
						}
						object obj86 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v135+E4]");
						bool flag46 = (nint)0 == 0;
						object obj87 = !flag46;
						if (obj87 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						limb3 = OfMiddle(ape, drawnAlong: true);
						transform = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v46+E4]");
						bool flag47 = (nint)0 == 0;
						object obj88 = !flag47;
						if (obj88 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (ape != null)
						{
							object obj89 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v98+E4]");
							bool flag48 = (nint)0 == 0;
							object obj90 = !flag48;
							if (obj90 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							limb3 = OfApe(ape, apePart, grip, drawnAlong: true);
							apePart = (ApePart)1;
							transform = grip;
						}
						else
						{
							object obj91 = obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v60+E4]");
							bool flag49 = (nint)0 == 0;
							object obj92 = !flag49;
							if (obj92 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!(body != null))
							{
								bool flag50 = !yours;
								transform = null;
								limb = null;
								if (!flag50)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
									object obj93 = 0;
									object obj94 = obj93;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X0_v64+E4]");
									bool flag51 = (nint)0 == 0;
									object obj95 = !flag51;
									if (obj95 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC04B8");
									object obj96 = obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v39+E4]");
									bool flag52 = (nint)0 == 0;
									object obj97 = !flag52;
									if (obj97 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									UnityEngine.Object obj98 = default;
									bool flag53 = obj98 != null;
									bool flag54 = !flag53;
									transform = null;
									limb = null;
									if (!flag54)
									{
										if ((object)obj98 == null)
										{
											goto IL_15f4;
										}
										object obj99 = obj52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X0_v71+E4]");
										bool flag55 = (nint)0 == 0;
										object obj100 = !flag55;
										if (obj100 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v67 (UnityEngine.Object)+68]");
										bool flag56 = (UnityEngine.Object)0 != null;
										bool flag57 = !flag56;
										transform = null;
										limb = null;
										if (!flag57)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v67 (UnityEngine.Object)+68]");
											object obj101 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v67 (UnityEngine.Object)+68]");
											if ((nint)0 == 0)
											{
												goto IL_15f4;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v41+20]");
											object obj102 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v41+20]");
											bool flag58 = (nint)0 == 0;
											transform = null;
											limb = null;
											if (!flag58)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X24_v8+18]");
												bool flag59 = (nint)0 < (nint)1;
												transform = null;
												limb = null;
												if (!flag59)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X24_v8+18]");
													object obj103 = 0 & 0xFFFFFFFFL;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v41+20]");
													object obj104 = (nint)0 + (nint)32;
													apePart2 = apePart;
													transform = null;
													UnityEngine.Object obj105 = null;
													object obj106 = 0;
													while (true)
													{
														bool flag60 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj106) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj103);
														object obj107 = !flag60;
														if (obj107 != null)
														{
															break;
														}
														object obj108 = obj52;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X0_v76+E4]");
														bool flag61 = (nint)0 == 0;
														object obj109 = !flag61;
														if (obj109 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X26_v7+v614 @ X25_v11*8]");
														bool flag62 = (UnityEngine.Object)0 != null;
														bool flag63 = !flag62;
														transform = null;
														limb = null;
														if (!flag63)
														{
															object obj110 = obj11;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X0_v81+E4]");
															bool flag64 = (nint)0 == 0;
															object obj111 = !flag64;
															if (obj111 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X26_v7+v614 @ X25_v11*8]");
															Limb limb4 = OfApe((Dismemberment)0, apePart, grip, drawnAlong: false);
															Add(pull, limb4);
															apePart2 = (ApePart)0;
															transform = grip;
															limb = limb4;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X24_v8+18]");
														obj103 = 0;
														obj106++;
														object obj112 = obj106;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X24_v8+18]");
														bool flag65 = (nint)obj112 < 0;
														obj105 = (UnityEngine.Object)(object)limb;
														if (flag65)
														{
															continue;
														}
														goto IL_15e7;
													}
													goto IL_1602;
												}
											}
										}
									}
								}
								goto IL_103f;
							}
							object obj113 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X0_v92+E4]");
							bool flag66 = (nint)0 == 0;
							object obj114 = !flag66;
							if (obj114 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							limb3 = OfBody(body, apePart, grip);
							transform = grip;
						}
					}
					Add(pull, limb3);
					limb = limb3;
					goto IL_103f;
				}
			}
		}
		goto IL_15f4;
		IL_15f4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1602;
		IL_103f:
		List<Limb> limbs = pull.limbs;
		if (pull.limbs != null)
		{
			if (limbs._size == 0)
			{
				result = null;
				goto IL_11e8;
			}
			object obj115 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v49+E4]");
			bool flag67 = (nint)0 == 0;
			object obj116 = !flag67;
			if (obj116 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj115 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v49+A0]");
			object obj117 = 0;
			List<System.__Canon> list = (List<System.__Canon>)obj117;
			if (obj117 != null)
			{
				System.__Canon[] items = list._items;
				int version = list._version + 1;
				list._version = version;
				if (list._items != null)
				{
					bool flag68 = list._size < items.Length;
					object obj118 = !flag68;
					if (obj118 == null)
					{
						object obj119 = list._items + list._size;
						int size = list._size + 1;
						list._size = size;
						object obj120 = obj119 + 32;
						obj120 = pull;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						result = pull;
					}
					else
					{
						((List<System.__Canon>)obj117).AddWithResize((System.__Canon)(object)pull);
						result = pull;
					}
					goto IL_11e8;
				}
			}
		}
		goto IL_15f4;
		IL_1602:
		return (GillaQuests.Pull)(object)new IndexOutOfRangeException();
	}

	private static void Add(GillaQuests.Pull p, Limb l)
	{
		//IL_006b: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		if (l != null)
		{
			List<System.__Canon> limbs = (List<System.__Canon>)(object)p.limbs;
			System.__Canon[] items = limbs._items;
			int version = limbs._version + 1;
			limbs._version = version;
			bool flag = limbs._size < items.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = items + limbs._size;
				int size = limbs._size + 1;
				limbs._size = size;
				object obj3 = obj2 + 32;
				obj3 = l;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				limbs.AddWithResize((System.__Canon)(object)l);
			}
		}
	}

	private static Limb OfApe(Dismemberment ape, ApePart part, Transform grip, bool drawnAlong)
	{
		//IL_004b: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I
		//IL_046a: Expected VT, but got F4
		//IL_049e: Expected Obj, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0583: Expected VT, but got F4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I
		//IL_05f6: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_076b: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_069a: Expected Obj, but got I
		//IL_06b4: Expected VT, but got F4
		//IL_030f: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		if ((object)ape == null)
		{
			goto IL_06c3;
		}
		Dismemberment.Part part2 = ape.Find(part);
		bool flag = part2 == null;
		Limb result = (Limb)(object)part2;
		Limb limb = default;
		float num = default;
		Transform transform4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = part2.joint == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			result = null;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6030]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				limb._002Ector();
				Transform transform2;
				if (drawnAlong)
				{
					Transform transform = ape.transform;
					transform2 = transform;
				}
				else
				{
					transform2 = null;
				}
				if (limb != null)
				{
					object obj6 = limb + 16;
					obj6 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj7 = obj;
					if (part != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
						bool flag5 = (nint)0 == 0;
						object obj8 = !flag5;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = part2.jointOut == null;
						bool flag7 = !flag6;
						object obj9 = !flag7;
						result = null;
						if (obj9 == null)
						{
							object obj10 = limb + 48;
							obj10 = part2.joint;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj11 = limb + 56;
							obj11 = part2.jointOut;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (obj11 == null)
							{
								goto IL_06c3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
							object n = 0;
							if (part != (ApePart)1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
								n = 0;
							}
							Transform transform3 = ((Transform)obj11).Find((string)n);
							object obj12 = limb + 64;
							obj12 = transform3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj13 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v66+E4]");
							bool flag8 = (nint)0 == 0;
							object obj14 = !flag8;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag9 = (UnityEngine.Object)obj12 == null;
							bool flag10 = !flag9;
							object obj15 = !flag10;
							result = null;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
								object obj16 = 0;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v71+E4]");
								bool flag11 = (nint)0 == 0;
								object obj18 = !flag11;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Arm(limb, grip);
								goto IL_0779;
							}
						}
						goto IL_06ee;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
					bool flag12 = (nint)0 == 0;
					object obj19 = !flag12;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (part2.renderer == null)
					{
						if (drawnAlong)
						{
							result = null;
							goto IL_06ee;
						}
						Transform away = ape.transform;
						limb.away = away;
						object obj20 = limb + 288;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if ((object)limb.away != null)
						{
							Vector3 localPosition = limb.away.localPosition;
							limb.awayAt = (Vector3)num;
							object obj21 = limb + 296;
							limb.eyes = part2.joint;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
							object obj22 = 0;
							object obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v46+E4]");
							bool flag13 = (nint)0 == 0;
							object obj24 = !flag13;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num = Across(part2.joint);
							transform4 = part2.joint;
							goto IL_0786;
						}
					}
					else
					{
						object obj25 = limb + 72;
						obj25 = part2.joint;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (obj25 != null)
						{
							Vector3 localPosition2 = ((Transform)obj25).localPosition;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
							object obj26 = 0;
							limb.headAt = (Vector3)num;
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v32+E4]");
							bool flag14 = (nint)0 == 0;
							object obj28 = !flag14;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((object)limb.head != null)
							{
								Vector3 lossyScale = limb.head.lossyScale;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								transform4 = limb.head;
								goto IL_0786;
							}
						}
					}
				}
				goto IL_06c3;
			}
		}
		goto IL_06ee;
		IL_0779:
		result = limb;
		goto IL_06ee;
		IL_0786:
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num3 = (limb.reach = num2 * 0f);
		if ((object)transform4 != null)
		{
			Vector3 position = transform4.position;
			if ((object)grip != null)
			{
				Vector3 position2 = grip.position;
				float num4 = num3 - num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				object obj29 = num5 - 0;
				object obj31 = default;
				object obj30 = obj31 - obj31;
				limb.offset = (Vector3)num4;
				goto IL_0779;
			}
		}
		goto IL_06c3;
		IL_06c3:
		return (Limb)(object)new NullReferenceException();
		IL_06ee:
		return result;
	}

	private unsafe static Limb OfBody(GillaCorpse body, ApePart part, Transform grip)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05c6: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_036c: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Ref, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Ref, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Ref, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0471: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I
		//IL_0591: Expected VT, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6030]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int part2 = GillaCorpse.Part(part);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Limb limb = default;
		limb._002Ector();
		Limb result;
		if (limb != null)
		{
			object obj5 = limb + 24;
			obj5 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)body != null)
			{
				Transform transform = body.transform;
				object obj6 = limb + 16;
				obj6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Quaternion quaternion = default;
				if (part != 0)
				{
					bool flag2 = body.ArmBones(part2, out *(Transform*)(limb + 48), out *(Transform*)(limb + 56), out *(Transform*)(limb + 64));
					bool flag3 = !flag2;
					result = null;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
						object obj7 = 0;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v48+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Arm(limb, grip);
						if ((object)limb.up != null)
						{
							Quaternion localRotation = limb.up.localRotation;
							limb.upTurn = quaternion;
							if ((object)limb.lo != null)
							{
								Quaternion localRotation2 = limb.lo.localRotation;
								limb.loTurn = quaternion;
								if ((object)limb.end != null)
								{
									Quaternion localRotation3 = limb.end.localRotation;
									limb.endTurn = quaternion;
									if ((object)limb.up != null)
									{
										Vector3 localScale = limb.up.localScale;
										limb.upHad = (Vector3)quaternion;
										if ((object)limb.lo != null)
										{
											Vector3 localScale2 = limb.lo.localScale;
											limb.loHad = (Vector3)quaternion;
											goto IL_05fb;
										}
									}
								}
							}
						}
						goto IL_05a0;
					}
				}
				else
				{
					Transform headBone = body.HeadBone;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v10+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = headBone == null;
					bool flag7 = !flag6;
					object obj13 = !flag7;
					result = null;
					if (obj13 == null)
					{
						object obj14 = limb + 72;
						obj14 = headBone;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if ((object)headBone != null)
						{
							Vector3 localPosition = headBone.localPosition;
							limb.headAt = (Vector3)quaternion;
							Quaternion localRotation4 = headBone.localRotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
							object obj15 = 0;
							limb.headTurn = quaternion;
							object obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v34+E4]");
							bool flag8 = (nint)0 == 0;
							object obj17 = !flag8;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Vector3 lossyScale = headBone.lossyScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							float num = (float)quaternion;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
							float num2 = (limb.reach = num * 0f);
							Vector3 position = headBone.position;
							if ((object)grip != null)
							{
								Vector3 position2 = grip.position;
								float num3 = num2 - num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
								object obj18 = num4 - 0;
								object obj20 = default;
								object obj19 = obj20 - obj20;
								limb.offset = (Vector3)num3;
								goto IL_05fb;
							}
						}
						goto IL_05a0;
					}
				}
				goto IL_05f6;
			}
		}
		goto IL_05a0;
		IL_05a0:
		return (Limb)(object)new NullReferenceException();
		IL_05fb:
		body.LimbStill(part2, still: true);
		result = limb;
		goto IL_05f6;
		IL_05f6:
		return result;
	}

	private static void Arm(Limb l, Transform grip)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_05b1: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I
		//IL_0582: Expected VT, but got Obj
		//IL_00f4: Expected VT, but got Obj
		//IL_0132: Expected VT, but got Obj
		//IL_0187: Expected VT, but got Obj
		//IL_01a6: Expected VT, but got Obj
		//IL_01dc: Expected VT, but got Obj
		//IL_05de: Expected Obj, but got I
		//IL_05f6: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_0650: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I
		//IL_0447: Expected VT, but got F4
		//IL_0688: Expected Obj, but got I4
		//IL_051a: Invalid comparison between F4 and I4
		//IL_0529: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Transform parent = l.up.parent;
		object obj2 = l + 40;
		obj2 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default;
		if ((UnityEngine.Object)obj2 != null)
		{
			Vector3 localPosition = ((Transform)obj2).localPosition;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v26+A0]");
			obj7 = 0;
		}
		l.shoulderAt = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		Vector3 localPosition2 = l.lo.localPosition;
		l.loAt = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		Vector3 localPosition3 = l.end.localPosition;
		l.endAt = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		Vector3 localScale = l.up.localScale;
		Vector3 localScale2 = l.lo.localScale;
		l.upRest = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		l.loRest = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		Vector3 localScale3 = l.end.localScale;
		l.endRest = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		_ = 0;
		Vector3 localPosition4 = l.lo.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v28+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj7 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+4]");
		object obj15 = num * 0;
		object obj16 = obj14 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		object obj17 = num2 * 0;
		object obj18 = obj17 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Vector3 lossyScale = l.up.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num3 = (l.lengthUp = (float)obj7 * (float)obj18);
		Vector3 localPosition5 = l.end.localPosition;
		object obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v35+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 lossyScale2 = l.up.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v27+8]");
		object obj21 = num4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Vector3 localScale4 = l.lo.localScale;
		float num5 = num3 * (float)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num6 = num5 * num3;
		float num7 = l.lengthUp + num6;
		l.lengthLo = num6;
		l.reach = num7;
		Vector3 position = l.end.position;
		Vector3 position2 = grip.position;
		float num8 = num6 - num6;
		float num9 = num7 - num7;
		object obj22 = obj21 - obj21;
		l.offset = (Vector3)num8;
		object obj23 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v46+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num10 = num8 * num8;
		float num11 = num9 * num9;
		object obj25 = obj22 * obj22;
		float num12 = num10 + num11;
		float num13 = num12 + (float)obj25;
		float num14 = l.reach;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num15 = num14 / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num16 = num13 / num15;
		float num17 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
		float num18 = num17 + 0f;
		float num19 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A88C]");
		float num20 = num19 / 0f;
		bool flag6 = num20 < 0f;
		double num21 = 0.0;
		if (!flag6)
		{
			bool flag7 = !((double)num20 > 1.0);
			num21 = num20;
			if (!flag7)
			{
				num21 = 1.0;
			}
		}
		l.keepOffset = (float)num21;
	}

	private static float Across(Transform bone)
	{
		Vector3 lossyScale = bone.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float result = default;
		return result;
	}

	private unsafe static Limb OfMiddle(Dismemberment ape, bool drawnAlong)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003d: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I4
		//IL_1307: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I4
		//IL_12c7: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I4
		//IL_04c7: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0500: Expected I, but got Obj
		//IL_0526: Expected VT, but got I4
		//IL_0550: Invalid comparison between Obj and F4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_05d2: Invalid comparison between F4 and Obj
		//IL_05e3: Expected Obj, but got I4
		//IL_05fc: Invalid comparison between F4 and I4
		//IL_060e: Invalid comparison between F4 and Obj
		//IL_01aa: Expected Obj, but got I8
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected I4, but got Unknown
		//IL_01de: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I4
		//IL_0596: Invalid comparison between F4 and I4
		//IL_15d1: Expected Obj, but got I4
		//IL_1325: Expected Obj, but got I
		//IL_062e: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_1369: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0254: Expected I, but got Obj
		//IL_1262: Expected Obj, but got I4
		//IL_126b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected Obj, but got Unknown
		//IL_027b: Expected I, but got Obj
		//IL_06c4: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I4
		//IL_029e: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I
		//IL_0780: Expected I, but got Obj
		//IL_0f9c: Expected Obj, but got I4
		//IL_0fa9: Expected Obj, but got Ref
		//IL_0fb1: Expected Obj, but got Ref
		//IL_030b: Expected Obj, but got I
		//IL_07a3: Expected Obj, but got I
		//IL_07b3: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_07d3: Expected Obj, but got I
		//IL_07e3: Expected Obj, but got I
		//IL_07f0: Expected I, but got Obj
		//IL_14f5: Expected I, but got Obj
		//IL_1505: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I
		//IL_08b9: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I4
		//IL_13f1: Expected Obj, but got I
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_1409: Expected Obj, but got Unknown
		//IL_1421: Expected Obj, but got I4
		//IL_142e: Expected Obj, but got Ref
		//IL_1436: Expected Obj, but got Ref
		//IL_0813: Expected Obj, but got I
		//IL_03a4: Expected I, but got Obj
		//IL_10bd: Expected Obj, but got I
		//IL_13a1: Expected Obj, but got I4
		//IL_0382: Expected I, but got Obj
		//IL_039a: Expected Obj, but got I
		//IL_1567: Expected Obj, but got I4
		//IL_090e: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got Ref
		//IL_0923: Expected Obj, but got Ref
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected Obj, but got Unknown
		//IL_110c: Expected Obj, but got I
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0848: Expected Obj, but got I4
		//IL_0862: Invalid comparison between F4 and I4
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_11d6: Expected Obj, but got I4
		//IL_1197: Expected I, but got Obj
		//IL_0949: Expected I, but got Obj
		//IL_0959: Expected Obj, but got I
		//IL_15a9: Expected Obj, but got I
		//IL_1147: Expected Obj, but got I
		//IL_14c6: Expected Obj, but got I
		//IL_0994: Expected Obj, but got I
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b7: Expected Obj, but got Unknown
		//IL_0bed: Expected Obj, but got I4
		//IL_0bfa: Expected Obj, but got Ref
		//IL_0c02: Expected Obj, but got Ref
		//IL_1476: Expected Obj, but got I4
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Expected Obj, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_0a91: Expected I, but got Obj
		//IL_0aa1: Expected Obj, but got I
		//IL_0aca: Expected Obj, but got I4
		//IL_0adc: Expected Obj, but got I4
		//IL_0ae9: Expected Obj, but got Ref
		//IL_0af1: Expected Obj, but got Ref
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected Obj, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected Obj, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected Obj, but got Unknown
		//IL_105f: Expected Obj, but got I4
		//IL_0c30: Expected I, but got Obj
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_09c9: Expected Obj, but got I4
		//IL_09e3: Invalid comparison between F4 and I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_0f64: Expected Obj, but got I4
		//IL_0b2c: Expected Obj, but got I
		//IL_0b4d: Expected Obj, but got I4
		//IL_0b6e: Invalid comparison between F4 and I4
		//IL_0ba2: Expected Obj, but got I4
		//IL_0baf: Expected Obj, but got Ref
		//IL_0bb7: Expected Obj, but got Ref
		//IL_0c7e: Expected Obj, but got I4
		//IL_0c8b: Expected Obj, but got Ref
		//IL_0c93: Expected Obj, but got Ref
		//IL_0ce4: Expected VT, but got Obj
		//IL_0d06: Expected Obj, but got I4
		//IL_0d13: Expected Obj, but got Ref
		//IL_0d1b: Expected Obj, but got Ref
		//IL_0d2b: Expected I, but got Obj
		//IL_0d59: Expected Obj, but got I
		//IL_0d77: Expected Obj, but got I
		//IL_0d9c: Expected Obj, but got I4
		//IL_0da9: Expected Obj, but got Ref
		//IL_0db1: Expected Obj, but got Ref
		//IL_0dc1: Expected I, but got Obj
		//IL_0def: Expected Obj, but got I
		//IL_0e19: Expected Obj, but got I4
		//IL_0e42: Invalid comparison between F4 and I4
		//IL_0ef8: Expected Obj, but got I
		//IL_0f08: Expected Obj, but got I
		//IL_0f2a: Expected VT, but got Ref
		//IL_0f3d: Expected F4, but got VT
		//IL_0f45: Expected Obj, but got Ref
		//IL_0e70: Expected Obj, but got I
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected Obj, but got Unknown
		//IL_0e9b: Expected Obj, but got I
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Expected Obj, but got Unknown
		//IL_0ece: Expected Obj, but got I4
		//IL_0ed6: Expected F4, but got VT
		//IL_0ede: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6010]");
		Limb limb = (Limb)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6018]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityEngine.Object obj2 = (UnityEngine.Object)obj;
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj4;
		UnityEngine.Object obj8;
		nint num;
		if ((object)ape != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
			object obj3 = 0;
			num = (nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			Limb limb2 = default;
			bool flag = limb2 == null;
			obj2 = (UnityEngine.Object)1;
			if (!flag)
			{
				GillaCorpse body = limb2.body;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj4 = 0;
				if ((nint)limb2.body >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6020]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
					object obj6 = 0;
					object obj7 = 0;
					obj2 = (UnityEngine.Object)1;
					obj8 = null;
					bool flag2 = drawnAlong;
					object obj9 = 109891584;
					object obj13 = default;
					while (true)
					{
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<GillaCorpse, UIntPtr>(ref body);
						object obj10 = !flag3;
						limb = limb2;
						if (obj10 != null)
						{
							break;
						}
						object obj11 = (object)limb2 + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v61+20]");
						bool flag4 = (nint)0 == 0;
						limb = limb2;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v61+20]");
							Transform[] bones = ((SkinnedMeshRenderer)0).bones;
							bool flag5 = bones == null;
							obj2 = null;
							limb = limb2;
							if (!flag5)
							{
								bool flag6 = bones.Length < 1;
								obj2 = null;
								if (!flag6)
								{
									object obj12 = bones.Length & 0xFFFFFFFFL;
									flag2 = (byte)(bones + 32) != 0;
									obj13 = obj13;
									IntPtr intPtr = num;
									UnityEngine.Object obj14 = null;
									UnityEngine.Object obj15 = obj8;
									object obj16 = 0;
									while (true)
									{
										bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
										object obj17 = !flag7;
										num = intPtr;
										obj2 = obj14;
										limb = limb2;
										if (obj17 != null)
										{
											break;
										}
										object obj18 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X0_v110+E4]");
										bool flag8 = (nint)0 == 0;
										object obj19 = !flag8;
										if (obj19 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
										bool flag9 = (UnityEngine.Object)0 != null;
										bool flag10 = !flag9;
										num = unchecked((nint)null);
										obj2 = null;
										if (!flag10)
										{
											bool flag11 = hashSet == null;
											num = unchecked((nint)null);
											obj2 = null;
											limb = limb2;
											if (flag11)
											{
												goto IL_0fcc;
											}
											num = (nint)obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
											bool flag12 = hashSet.Add((System.__Canon)0);
											bool flag13 = !flag12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
											obj2 = (UnityEngine.Object)0;
											if (!flag13)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
												bool flag14 = (nint)0 == 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
												obj2 = (UnityEngine.Object)0;
												limb = limb2;
												if (flag14)
												{
													goto IL_0fcc;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
												string text = ((UnityEngine.Object)0).name;
												bool flag15 = text == (string)obj6;
												bool flag16 = !flag15;
												object obj20 = !flag16;
												obj13 = ~obj20;
												if (obj13 == null)
												{
													num = unchecked((nint)null);
													obj2 = (UnityEngine.Object)obj6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X22_v22 (System.Boolean)+v281 @ X21_v29*8]");
													obj15 = (UnityEngine.Object)0;
												}
												else
												{
													num = unchecked((nint)null);
													obj2 = (UnityEngine.Object)obj6;
												}
											}
										}
										obj12 = bones.Length;
										obj9 = obj16 + 1;
										bool flag17 = (nint)obj9 < bones.Length;
										obj8 = obj15;
										intPtr = num;
										obj14 = obj2;
										obj16 = obj9;
										if (flag17)
										{
											continue;
										}
										goto IL_03b1;
									}
									break;
								}
								goto IL_03b1;
							}
						}
						goto IL_0fcc;
						IL_03b1:
						body = limb2.body;
						obj7++;
						object obj21 = obj7;
						GillaCorpse body2 = limb2.body;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<GillaCorpse, UIntPtr>(ref body2))
						{
							continue;
						}
						goto IL_12dd;
					}
					goto IL_0fbe;
				}
				obj2 = (UnityEngine.Object)1;
				obj8 = null;
				goto IL_12dd;
			}
		}
		goto IL_0fcc;
		IL_11ec:
		return limb;
		IL_0fbe:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0fcc;
		IL_0fcc:
		throw new NullReferenceException();
		IL_1315:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6030]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Limb limb3 = default;
		limb3._002Ector();
		if (drawnAlong)
		{
			Transform transform = ape.transform;
			obj2 = transform;
		}
		else
		{
			obj2 = null;
		}
		bool flag18 = limb3 == null;
		num = unchecked((nint)null);
		limb = limb3;
		bool flag22;
		float num3 = default;
		if (!flag18)
		{
			object obj23 = limb3 + 16;
			obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj24 = obj23 + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Vector3 localScale = ((Transform)obj8).localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X0_v68+E4]");
			bool flag19 = (nint)0 == 0;
			object obj27 = !flag19;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 lossyScale = ((Transform)obj8).lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD48]");
			num3 = (limb3.width = num2 * 0f);
			IEnumerator enumerator = ((Transform)obj8).GetEnumerator();
			bool flag20 = enumerator == null;
			num = unchecked((nint)null);
			obj2 = null;
			object obj41 = default;
			object obj43 = default;
			object obj39;
			OutOfMemoryException ex2;
			object obj40;
			object obj42;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6028]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48A8]");
				object obj32 = 0;
				float num4 = num3;
				nint num5 = unchecked((nint)null);
				IEnumerator enumerator2 = enumerator;
				System.__Canon _Canon = default;
				(System.__Canon, Vector3) tuple2 = default;
				object obj54 = default;
				object obj56 = default;
				NullReferenceException ex7 = default;
				Limb result = default;
				object obj65 = default;
				object obj74;
				do
				{
					nint num6 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_08aa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+98]");
					object obj34 = (nint)0 + (nint)8;
					bool flag21 = flag22;
					object obj36;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ X10_v36-8]");
						bool flag23 = 0 < (nint)obj28;
						object obj35 = !flag23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ X10_v36-8]");
						float num7 = 0f - (float)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ X10_v36-8]");
						if (0 == (nint)obj28)
						{
							break;
						}
						obj33--;
						bool flag24 = (nint)obj33 < 1;
						obj35 = !flag24;
						num7 = (float)obj33 - 1f;
						bool flag25 = num7 == 0f;
						obj36 = obj34 + 16;
						flag22 = (nint)obj33 != 1;
						obj34 = obj36;
						flag21 = flag22;
						if (flag22)
						{
							continue;
						}
						goto IL_08aa;
					}
					object obj37 = num6 + obj34;
					object obj38 = obj37 + 312;
					obj36 = obj34;
					flag22 = flag21;
					num = num5;
					goto IL_13e1;
					IL_0bd5:
					bool flag26 = hashSet == null;
					obj39 = 0;
					ex2 = null;
					obj40 = (object)(&obj41);
					obj42 = (object)(&obj43);
					num3 = num4;
					UnityEngine.Object obj44;
					obj2 = obj44;
					limb = limb3;
					if (flag26)
					{
						goto IL_1001;
					}
					num = (nint)obj30;
					bool flag27 = hashSet.Contains(_Canon);
					bool flag28 = !flag27;
					obj2 = (UnityEngine.Object)(object)_Canon;
					if (flag28)
					{
						goto IL_0f4a;
					}
					bool flag29 = _Canon == null;
					obj39 = 0;
					ex2 = null;
					obj40 = (object)(&obj41);
					obj42 = (object)(&obj43);
					num3 = num4;
					obj2 = (UnityEngine.Object)(object)_Canon;
					limb = limb3;
					if (!flag29)
					{
						List<(System.__Canon, Vector3)> onSpine = (List<(System.__Canon, Vector3)>)(object)limb3.onSpine;
						Vector3 localScale2 = ((Transform)(object)_Canon).localScale;
						(System.__Canon, Vector3) tuple = (_Canon, (Vector3)obj31);
						bool flag30 = (object)limb3.onSpine == null;
						obj39 = 0;
						ex2 = null;
						obj40 = (object)(&obj41);
						obj42 = (object)(&obj43);
						num3 = num4;
						num = (nint)obj31;
						obj2 = (UnityEngine.Object)(object)_Canon;
						limb = limb3;
						if (!flag30)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
							object obj45 = 0;
							object obj46 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+1C]");
							object obj47 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
							bool flag31 = (nint)0 == 0;
							obj39 = 0;
							ex2 = null;
							obj40 = (object)(&obj41);
							obj42 = (object)(&obj43);
							num3 = num4;
							num = (nint)obj31;
							obj2 = (UnityEngine.Object)(object)_Canon;
							limb = limb3;
							if (!flag31)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
								obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v49+18]");
								bool flag32 = num8 < 0;
								object obj35 = !flag32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
								float num9 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v49+18]");
								float num7 = num9 - 0f;
								bool flag25 = num7 == 0f;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
									object obj48 = (nint)0 * (nint)24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+10]");
									object obj49 = 0 + obj48;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X21_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, UnityEngine.Vector3>>)+18]");
									object obj50 = (nint)0 + (nint)1;
									_ = 0;
									object obj51 = obj49 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj36 = 0;
									num4 = (float)tuple;
									num = (nint)obj31;
									obj2 = null;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v26+20]");
									object obj52 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1479 @ X8_v50+A8]");
									object obj53 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X8_v51+70]");
									num = 0;
									((List<(System.__Canon, Vector3)>)(object)limb3.onSpine).AddWithResize(((System.__Canon, Vector3))(&tuple2));
									tuple2 = tuple;
									num4 = (float)tuple;
									obj2 = (UnityEngine.Object)(&tuple2);
								}
								goto IL_0f4a;
							}
						}
						goto IL_0fe5;
					}
					goto IL_100f;
					IL_1001:
					NullReferenceException ex3 = new NullReferenceException();
					goto IL_100f;
					IL_100f:
					NullReferenceException ex4 = new NullReferenceException();
					NullReferenceException ex5;
					if ((nint)obj2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj39 = 1;
					}
					else
					{
						bool flag33 = (nint)obj2 != 1;
						ex5 = ex4;
						if (flag33)
						{
							goto IL_152a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						ex2 = (OutOfMemoryException)obj54;
					}
					goto IL_10ad;
					IL_08aa:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num = unchecked((nint)null);
					goto IL_13e1;
					IL_13e1:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X0_v77+8]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1358 @ X0_v77] (should have been resolved before IL gen)");
					object obj55 = obj56 & 1;
					bool flag34 = obj55 == null;
					obj39 = 0;
					ex2 = null;
					obj40 = (object)(&obj41);
					obj42 = (object)(&obj43);
					num3 = num4;
					limb = limb3;
					if (flag34)
					{
						goto IL_10ad;
					}
					bool flag35 = enumerator == null;
					obj39 = 0;
					ex2 = null;
					obj40 = (object)(&obj41);
					obj42 = (object)(&obj43);
					num3 = num4;
					limb = limb3;
					if (flag35)
					{
						goto IL_0ff3;
					}
					nint num10 = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0a2b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+98]");
					object obj58 = (nint)0 + (nint)8;
					bool flag36 = flag22;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X10_v31-8]");
						bool flag37 = 0 < (nint)obj28;
						object obj35 = !flag37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X10_v31-8]");
						float num7 = 0f - (float)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X10_v31-8]");
						if (0 == (nint)obj28)
						{
							break;
						}
						obj57--;
						bool flag38 = (nint)obj57 < 1;
						obj35 = !flag38;
						num7 = (float)obj57 - 1f;
						bool flag25 = num7 == 0f;
						obj36 = obj58 + 16;
						flag22 = (nint)obj57 != 1;
						obj58 = obj36;
						flag36 = flag22;
						if (flag22)
						{
							continue;
						}
						goto IL_0a2b;
					}
					object obj59 = obj58 + 1;
					object obj60 = num10 + obj59;
					object obj61 = obj60 + 312;
					obj36 = obj58;
					flag22 = flag36;
					goto IL_14b6;
					IL_1599:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X0_v20+8]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1211 @ X0_v20] (should have been resolved before IL gen)");
					goto IL_154d;
					IL_154d:
					bool flag39 = ex2 == null;
					object obj62 = !flag39;
					if (obj62 == null)
					{
						bool flag40 = obj39 == null;
						object obj63 = !flag40;
						OutOfMemoryException ex6 = ex2;
						if (obj63 == null)
						{
							goto IL_11ec;
						}
					}
					else
					{
						OutOfMemoryException ex6 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					ex5 = ex7;
					goto IL_152a;
					IL_152a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
					IL_10ad:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					object obj64 = 0;
					obj2 = (UnityEngine.Object)obj64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					obj40 = obj65;
					if (obj65 == null)
					{
						goto IL_154d;
					}
					object obj66 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v11+12E]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v11+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1188;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v11+98]");
					object obj68 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X10_v9-8]");
						if (0 == (nint)obj64)
						{
							break;
						}
						obj67--;
						obj68 += 16;
						if ((nint)obj67 != 1)
						{
							continue;
						}
						goto IL_1188;
					}
					object obj69 = obj66 + obj68;
					object obj70 = obj69 + 312;
					goto IL_1599;
					IL_1188:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num = unchecked((nint)null);
					goto IL_1599;
					IL_0a2b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num = 1;
					goto IL_14b6;
					IL_14b6:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1432 @ X0_v80+8]");
					obj44 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1432 @ X0_v80] (should have been resolved before IL gen)");
					if (_Canon == null)
					{
						goto IL_0bd5;
					}
					obj2 = (UnityEngine.Object)obj29;
					nint num11 = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v53 (Il2CppClass<System.__Canon>)+130]");
					obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v53 (Il2CppClass<System.__Canon>)+130]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X1_v16 (UnityEngine.Object)+130]");
					bool flag41 = num12 < 0;
					object obj71 = !flag41;
					object obj72 = ~obj71;
					obj39 = 0;
					ex2 = null;
					obj40 = (object)(&obj41);
					obj42 = (object)(&obj43);
					num3 = num4;
					limb = limb3;
					if (obj72 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v53 (Il2CppClass<System.__Canon>)+B0]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X1_v16 (UnityEngine.Object)+130]");
						object obj73 = num13 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v55-8]");
						bool flag42 = 0 < (nint)obj2;
						object obj35 = !flag42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v55-8]");
						float num7 = 0f - (float)obj2;
						bool flag25 = num7 == 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v55-8]");
						flag22 = 0 != (nint)obj2;
						obj44 = obj2;
						obj39 = 0;
						ex2 = null;
						obj40 = (object)(&obj41);
						obj42 = (object)(&obj43);
						num3 = num4;
						limb = limb3;
						if (!flag22)
						{
							goto IL_0bd5;
						}
					}
					InvalidCastException ex8 = new InvalidCastException();
					goto IL_0fe5;
					IL_0fe5:
					NullReferenceException ex9 = new NullReferenceException();
					goto IL_0ff3;
					IL_0ff3:
					NullReferenceException ex10 = new NullReferenceException();
					goto IL_1001;
					IL_0f4a:
					bool flag43 = enumerator == null;
					obj74 = !flag43;
					num3 = num4;
					num5 = num;
					enumerator2 = enumerator;
				}
				while (obj74 != null);
			}
			NullReferenceException ex11 = new NullReferenceException();
			obj39 = 0;
			ex2 = null;
			obj40 = (object)(&obj41);
			obj42 = (object)(&obj43);
			limb = limb3;
			goto IL_0fbe;
		}
		goto IL_0fcc;
		IL_12dd:
		object obj75 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v48+E4]");
		bool flag44 = (nint)0 == 0;
		object obj76 = !flag44;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag45 = obj8 == null;
		bool flag46 = !flag45;
		object obj77 = !flag46;
		limb = null;
		if (obj77 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj78 = 0;
			object obj79 = obj78;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v52+E4]");
			bool flag47 = (nint)0 == 0;
			object obj80 = !flag47;
			if (obj80 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds gillaWounds = GillaWounds.On(ape);
			bool flag48 = (object)gillaWounds == null;
			num = unchecked((nint)null);
			obj2 = null;
			limb = null;
			if (!flag48)
			{
				Vector3 vector = gillaWounds.PlusX();
				bool flag49 = (object)obj8 == null;
				num = unchecked((nint)null);
				obj2 = null;
				limb = null;
				if (!flag49)
				{
					Vector3 vector2 = ((Transform)obj8).InverseTransformDirection((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					object obj81 = default;
					object obj82 = default;
					object obj35;
					float num7;
					bool flag25;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj81) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3))
					{
						bool flag50 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj81) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82);
						obj35 = !flag50;
						num7 = (float)obj81 - (float)obj82;
						flag25 = num7 == 0f;
						flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj81) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82);
						if (!flag22)
						{
							object obj83 = 0;
							goto IL_1315;
						}
					}
					bool flag51 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82);
					obj35 = !flag51;
					num7 = num3 - (float)obj82;
					flag25 = num7 == 0f;
					flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82);
					if (!flag22)
					{
						object obj83 = 2;
					}
					else
					{
						object obj83 = 1;
					}
					goto IL_1315;
				}
			}
			goto IL_0fcc;
		}
		goto IL_11ec;
	}

	private unsafe void Watch()
	{
		//IL_0010: Expected Obj, but got I
		//IL_09d5: Expected I, but got Obj
		//IL_09f7: Expected Obj, but got I4
		//IL_0acb: Expected I4, but got Obj
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected Obj, but got I4
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got I4
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got I4
		//IL_0a3f: Expected I, but got Obj
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Ref, but got Unknown
		//IL_0a62: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_08b3: Expected I, but got Obj
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got I
		//IL_044d: Expected Obj, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0546: Expected Obj, but got I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected I4, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got I4
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got I4
		//IL_077f: Expected Obj, but got I4
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got I4
		//IL_07d7: Expected Obj, but got I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		nint num2 = num;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (Il2CppClass<UnityEngine.Object>)+A0]");
		int num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (System.Int32)+8]");
		bool flag2 = (nint)0 == 0;
		int value = 0;
		UnityEngine.Object obj3 = default;
		int num4 = (int)obj3;
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj4 = (UnityEngine.Object)109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6040]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6048]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (System.Int32)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			value = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			num3 = 17276928;
			obj4 = (UnityEngine.Object)109891584;
			Enumerator<, > val4 = default;
			object obj44 = default;
			object obj34;
			Enumerator<, > val5;
			Enumerator<, > val6;
			while (true)
			{
				UnityEngine.Object obj21;
				nint num6;
				if (val.MoveNext())
				{
					object obj11 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v31+E4]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj3 == null;
					bool flag5 = !flag4;
					object obj13 = !flag5;
					int num5 = 0;
					if (obj13 != null)
					{
						continue;
					}
					if ((object)obj3 != null)
					{
						bool isLocal = ((NetworkApe)obj3).IsLocal;
						bool flag6 = !isLocal;
						object obj14 = !flag6;
						num5 = 0;
						if (obj14 != null)
						{
							continue;
						}
						object obj15 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+98]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v44+E4]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v44+E4]");
						bool flag7 = (nint)0 == 0;
						object obj16 = !flag7;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = obj4 == null;
						bool flag9 = !flag8;
						object obj17 = !flag9;
						num5 = 0;
						if (obj17 != null)
						{
							continue;
						}
						object obj18 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+A0]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v48+E4]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v48+E4]");
						bool flag10 = (nint)0 == 0;
						object obj19 = !flag10;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = obj4 == null;
						bool flag12 = !flag11;
						object obj20 = !flag12;
						num5 = 0;
						if (obj20 != null)
						{
							continue;
						}
						bool flag13 = grips == null;
						num5 = 0;
						obj21 = null;
						if (flag13)
						{
							goto IL_08a2;
						}
						object obj22 = obj7;
						Dictionary<int, int> dictionary = grips;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
						bool flag14 = dictionary.TryGetValue(0, out value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+98]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+98]");
						bool flag15 = (nint)0 == 0;
						num5 = (int)(&value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
						obj21 = (UnityEngine.Object)0;
						if (!flag15)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+A0]");
							val2 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+A0]");
							bool flag16 = (nint)0 == 0;
							num5 = (int)(&value);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
							num6 = 0;
							if (flag16)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8C]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							object obj23 = num7 - 0;
							bool flag17 = (nint)obj23 < 0;
							bool flag18 = obj23 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8C]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							object obj24 = num8 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8C]");
							object obj25 = 0 ^ obj23;
							object obj26 = obj24 & obj25;
							bool flag19 = (nint)obj26 < 0;
							bool flag20 = flag17 == flag19;
							object obj27 = !flag18;
							object obj28 = flag20 & obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (System.Int32)+8C]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							object obj29 = num9 - 0;
							bool flag21 = (nint)obj29 < 0;
							bool flag22 = obj29 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (System.Int32)+8C]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
							object obj30 = num10 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (System.Int32)+8C]");
							object obj31 = 0 ^ obj29;
							object obj32 = obj30 & obj31;
							bool flag23 = (nint)obj32 < 0;
							bool flag24 = flag21 == flag23;
							object obj33 = !flag22;
							Enumerator<, > val3 = (Enumerator<, >)(flag24 & obj33);
							num5 = val3 | obj28;
							bool flag25 = num5 == value;
							val2 = val3;
							num3 = value;
							if (flag25)
							{
								continue;
							}
							bool flag26 = grips == null;
							num4 = 0;
							val = val4;
							obj34 = 0;
							val2 = val3;
							val5 = val4;
							val6 = (Enumerator<, >)(ref val);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
							num6 = 0;
							num3 = value;
							if (!flag26)
							{
								obj22 = obj8;
								Dictionary<int, int> dictionary2 = grips;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
								dictionary2.set_Item(0, num5);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ stack_-64_v6 (System.Int32)+8C]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
								bool flag27 = num11 <= 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
								bool flag28 = false;
								num3 = value;
								if (!flag27)
								{
									int num12 = value & 1;
									bool flag29 = num12 == 0;
									object obj35 = !flag29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-98 (UnityEngine.Object)+6CC]");
									flag28 = false;
									num3 = value;
									if (obj35 == null)
									{
										object obj36 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v60+E4]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v60+E4]");
										bool flag30 = (nint)0 == 0;
										object obj37 = !flag30;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Closed((NetworkApe)obj3, right: false);
										flag28 = false;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8C]");
								nint num13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
								bool flag31 = num13 <= 0;
								val2 = val3;
								if (flag31)
								{
									continue;
								}
								int num14 = value & 2;
								bool flag32 = num14 == 0;
								object obj38 = !flag32;
								val2 = val3;
								num3 = value;
								if (obj38 == null)
								{
									object obj39 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v56+E4]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v56+E4]");
									bool flag33 = (nint)0 == 0;
									object obj40 = !flag33;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Closed((NetworkApe)obj3, right: true);
									val2 = val3;
								}
								continue;
							}
							goto IL_0918;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
						num5 = 0;
						obj21 = null;
					}
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_08a2;
				}
				num4 = 0;
				val = val4;
				obj34 = 0;
				val5 = val4;
				val6 = (Enumerator<, >)(ref val);
				object obj41 = 0;
				goto IL_0a37;
				IL_0a37:
				num6 = (nint)obj10;
				((Enumerator<, >*)val6)->Dispose();
				bool flag34 = obj41 == null;
				object obj42 = !flag34;
				if (obj42 == null)
				{
					bool flag35 = num4 == 0;
					object obj43 = !flag35;
					OutOfMemoryException ex3 = (OutOfMemoryException)val6;
					if (obj43 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0918;
				IL_08a2:
				NullReferenceException ex4 = new NullReferenceException();
				num6 = (nint)obj21;
				break;
				IL_0918:
				NullReferenceException ex5 = new NullReferenceException();
				if (num6 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num4 = 1;
					num3 = 1;
					obj41 = obj34;
				}
				else
				{
					if (num6 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj41 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj34 = obj44;
				}
				goto IL_0a37;
			}
			NullReferenceException ex6 = new NullReferenceException();
			num4 = 0;
			val = val4;
			obj34 = 0;
			val5 = val4;
			val6 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private unsafe static void Closed(NetworkApe by, bool right)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Expected Obj, but got I
		//IL_16e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ec: Expected Obj, but got Unknown
		//IL_1716: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_174e: Expected Obj, but got I4
		//IL_1c21: Expected Obj, but got I
		//IL_1c60: Expected Obj, but got I4
		//IL_02d8: Expected F8, but got I
		//IL_1786: Expected Obj, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I, but got Obj
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected F8, but got I
		//IL_17be: Expected Obj, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected I, but got Obj
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Expected Obj, but got I4
		//IL_17f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f9: Expected I4, but got Unknown
		//IL_181a: Expected Obj, but got I
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Expected Obj, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected I, but got Obj
		//IL_1872: Expected Obj, but got I
		//IL_1898: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c4: Expected I, but got Obj
		//IL_18cc: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got I
		//IL_04ba: Expected I, but got Obj
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected Obj, but got I4
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got I4
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected Obj, but got I4
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Expected Obj, but got I
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a00: Expected Ref, but got Unknown
		//IL_1a1a: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_052e: Expected Obj, but got I4
		//IL_0533: Expected I, but got Obj
		//IL_0c56: Expected Obj, but got I4
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_05b8: Expected I, but got Obj
		//IL_0cd9: Expected Obj, but got I
		//IL_0d03: Expected Obj, but got I4
		//IL_1a50: Expected Obj, but got I
		//IL_0cbb: Expected Obj, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got I4
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected I, but got Obj
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I4
		//IL_1642: Expected Obj, but got I4
		//IL_06d1: Expected Obj, but got I4
		//IL_06d6: Expected I, but got Obj
		//IL_16b1: Expected Obj, but got I4
		//IL_1234: Expected Obj, but got I4
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bba: Expected Obj, but got I
		//IL_1bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be1: Expected Obj, but got I4
		//IL_1be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected Obj, but got I4
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got I4
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected I, but got Obj
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Expected Obj, but got I4
		//IL_0dbf: Expected I, but got Obj
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got I4
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected I, but got Obj
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Expected Obj, but got I4
		//IL_158d: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Expected I, but got Obj
		//IL_15a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got I
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected I4, but got Unknown
		//IL_1914: Expected Obj, but got I
		//IL_193e: Expected Obj, but got I4
		//IL_0e66: Expected Obj, but got I4
		//IL_0880: Expected Obj, but got I4
		//IL_0e95: Expected Obj, but got I
		//IL_0eb3: Expected Obj, but got I4
		//IL_0ebd: Expected I, but got Obj
		//IL_08b3: Expected VT, but got Ref
		//IL_08d3: Expected Obj, but got I4
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected I4, but got Unknown
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected Obj, but got I4
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1a: Expected I, but got Obj
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1965: Expected Obj, but got I4
		//IL_196e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1973: Expected I4, but got Unknown
		//IL_198c: Expected Obj, but got I4
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected Obj, but got Unknown
		//IL_19a7: Expected Obj, but got I4
		//IL_19b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Expected Obj, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got I4
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got I4
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected Obj, but got I4
		//IL_0a15: Expected Obj, but got I4
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a3d: Expected Obj, but got I4
		//IL_0aa2: Expected Obj, but got I
		//IL_0acc: Expected Obj, but got I4
		//IL_1abf: Expected Obj, but got I
		//IL_1ae9: Expected Obj, but got I4
		//IL_0b14: Expected I4, but got Obj
		//IL_0b24: Expected I4, but got Obj
		//IL_0b46: Expected I, but got Obj
		//IL_0a77: Invalid comparison between F4 and I4
		//IL_0f8b: Expected VT, but got Ref
		//IL_1b10: Expected Obj, but got I4
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Expected I4, but got Unknown
		//IL_1b37: Expected Obj, but got I4
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected Obj, but got Unknown
		//IL_1063: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected Obj, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected Obj, but got Unknown
		//IL_1b52: Expected Obj, but got I4
		//IL_1b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Expected Obj, but got Unknown
		//IL_1205: Expected I4, but got F4
		//IL_120e: Expected Obj, but got I4
		//IL_10c7: Expected Obj, but got I4
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected Obj, but got Unknown
		//IL_10ef: Expected Obj, but got I4
		//IL_1154: Expected Obj, but got I
		//IL_117e: Expected Obj, but got I4
		//IL_11f8: Expected I, but got Obj
		//IL_1129: Invalid comparison between F4 and I4
		ApePart part;
		Enumerator<, > val;
		ApePart part2;
		Enumerator<, > val2;
		object obj3;
		UnityEngine.Object obj2;
		UnityEngine.Object obj;
		Enumerator<, > val3;
		if (right)
		{
			bool flag = (object)by == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			val2 = (Enumerator<, >)0;
			obj = (UnityEngine.Object)right;
			obj2 = (UnityEngine.Object)109891584;
			if (flag)
			{
				goto IL_15b0;
			}
			obj3 = by + 120;
			val3 = (Enumerator<, >)(by + 112);
		}
		else
		{
			bool flag2 = (object)by == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			val2 = (Enumerator<, >)0;
			obj = (UnityEngine.Object)right;
			obj2 = (UnityEngine.Object)109891584;
			if (flag2)
			{
				goto IL_15b0;
			}
			obj3 = by + 112;
			val3 = (Enumerator<, >)(by + 120);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		obj2 = (UnityEngine.Object)val3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v70+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj3 == null;
		bool flag5 = !flag4;
		object obj7 = !flag5;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v74+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = obj2 == null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		if (obj10 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v78+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X0_v82+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X0_v82+A0]");
		object obj16 = 0;
		UnityEngine.Object obj17 = (UnityEngine.Object)obj16;
		float num = MonsterPlayer.RigOf(by);
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X0_v84+E4]");
		bool flag11 = (nint)0 == 0;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num4;
		float num2;
		nint num3;
		if ((UnityEngine.Object)obj16 != null)
		{
			bool flag12 = obj16 == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			val2 = (Enumerator<, >)0;
			num2 = num;
			num3 = unchecked((nint)null);
			obj = null;
			if (flag12)
			{
				goto IL_15b0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X23_v11 (UnityEngine.Object)+E0]");
			num4 = 0.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			num4 = 0.0;
		}
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X0_v88+E4]");
		bool flag13 = (nint)0 == 0;
		object obj21 = !flag13;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enumerator<, > val4;
		if ((UnityEngine.Object)obj16 != null)
		{
			bool flag14 = obj16 == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			val2 = (Enumerator<, >)0;
			num2 = num;
			num3 = unchecked((nint)null);
			obj = null;
			if (flag14)
			{
				goto IL_15b0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X23_v11 (UnityEngine.Object)+F4]");
			val4 = (Enumerator<, >)0;
		}
		else
		{
			val4 = (Enumerator<, >)0;
		}
		object obj22 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ X0_v92+E4]");
		bool flag15 = (nint)0 == 0;
		object obj23 = !flag15;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ApePart apePart;
		if ((UnityEngine.Object)obj16 != null)
		{
			bool flag16 = obj16 == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			val2 = (Enumerator<, >)0;
			num2 = num;
			num3 = unchecked((nint)null);
			obj = null;
			if (flag16)
			{
				goto IL_15b0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X23_v11 (UnityEngine.Object)+F0]");
			apePart = (ApePart)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			apePart = (ApePart)0;
		}
		Transform transform = by.HandOf(right);
		object obj24 = (right ? 1 : 0) ^ 1;
		bool flag17 = (byte)(obj24 & 1) != 0;
		Transform transform2 = by.HandOf(flag17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj25 = 0;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X8_v56+E4]");
		val3 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X8_v56+E4]");
		bool flag18 = (nint)0 == 0;
		object obj27 = !flag18;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X8_v56+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v57+8]");
		bool flag19 = (nint)0 == 0;
		part = (ApePart)0;
		val = (Enumerator<, >)0;
		part2 = (ApePart)0;
		val2 = (Enumerator<, >)0;
		num2 = num;
		Transform transform3 = transform;
		num3 = unchecked((nint)null);
		obj = (UnityEngine.Object)flag17;
		if (flag19)
		{
			goto IL_15b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		double num5 = 0.0 * num4;
		float num6 = num * (float)apePart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v57+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj29 = 0;
		num3 = unchecked((nint)null);
		UnityEngine.Object obj32 = default;
		float num7 = default;
		float num8;
		float num9;
		UnityEngine.Object obj37;
		object obj38;
		Enumerator<, > val5;
		while (val2.MoveNext())
		{
			object obj30 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ X0_v106+E4]");
			bool flag20 = (nint)0 == 0;
			object obj31 = !flag20;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = obj32 == null;
			bool flag22 = !flag21;
			object obj33 = !flag22;
			num3 = unchecked((nint)null);
			if (obj33 != null)
			{
				continue;
			}
			object obj34 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X0_v110+E4]");
			bool flag23 = (nint)0 == 0;
			object obj35 = !flag23;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag24 = obj32 == by;
			bool flag25 = !flag24;
			object obj36 = !flag25;
			num3 = unchecked((nint)null);
			if (obj36 != null)
			{
				continue;
			}
			bool flag26 = (object)obj32 == null;
			part = (ApePart)0;
			val = (Enumerator<, >)0;
			part2 = (ApePart)0;
			obj37 = null;
			val2 = (Enumerator<, >)num7;
			obj38 = 0;
			val5 = (Enumerator<, >)(ref val2);
			num8 = num6;
			num9 = (float)num5;
			num2 = num7;
			transform3 = transform;
			num3 = unchecked((nint)null);
			obj = by;
			val3 = (Enumerator<, >)(ref val2);
			if (!flag26)
			{
				Transform holderHand = ((NetworkApe)obj32).HolderHand;
				object obj39 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X0_v116+E4]");
				bool flag27 = (nint)0 == 0;
				object obj40 = !flag27;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = holderHand != transform2;
				bool flag29 = !flag28;
				object obj41 = !flag29;
				num3 = unchecked((nint)null);
				if (obj41 != null)
				{
					continue;
				}
				goto IL_06e4;
			}
			goto IL_15c6;
		}
		part = (ApePart)0;
		val = (Enumerator<, >)0;
		part2 = (ApePart)0;
		ApePart apePart3 = default;
		ApePart apePart2 = apePart3;
		double num11 = default;
		double num10 = num11;
		object obj42 = 0;
		UnityEngine.Object obj43 = null;
		val2 = (Enumerator<, >)num7;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val2);
		num8 = num6;
		num9 = (float)num5;
		num2 = num7;
		transform3 = transform;
		object obj44 = 21;
		val3 = (Enumerator<, >)(ref val2);
		goto IL_19df;
		IL_15df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_15ee;
		IL_1baa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
		object obj45 = 0;
		obj = (UnityEngine.Object)obj45;
		val.Dispose();
		float num12 = default;
		val = (Enumerator<, >)num12;
		obj37 = null;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val);
		goto IL_15d1;
		IL_15b0:
		NullReferenceException ex = new NullReferenceException();
		obj37 = obj32;
		goto IL_15c6;
		IL_15d1:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_15df;
		IL_19df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj46 = 0;
		obj = (UnityEngine.Object)obj46;
		((Enumerator<, >*)val5)->Dispose();
		bool flag30 = obj42 == null;
		object obj47 = !flag30;
		apePart3 = apePart2;
		num11 = num10;
		obj37 = obj43;
		if (obj47 != null)
		{
			goto IL_15d1;
		}
		bool flag31 = (object)obj43 == null;
		object obj48 = !flag31;
		apePart3 = apePart2;
		num11 = num10;
		obj37 = obj43;
		ex2 = (OutOfMemoryException)val5;
		if (obj48 != null)
		{
			goto IL_15df;
		}
		if ((nint)obj44 != 21)
		{
			bool flag32 = obj44 == null;
			object obj49 = !flag32;
			if (obj49 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X0_v5+E4]");
		bool flag33 = (nint)0 == 0;
		object obj52 = !flag33;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj51 = obj50;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X0_v5+A0]");
		object obj53 = 0;
		bool flag34 = obj53 == null;
		apePart3 = apePart2;
		num11 = num10;
		obj32 = obj43;
		if (flag34)
		{
			goto IL_15b0;
		}
		Enumerator<, > enumerator2 = ((List<System.__Canon>)obj53).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
		object obj54 = 0;
		GillaDummy gillaDummy;
		while (val.MoveNext())
		{
			object obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X0_v35+E4]");
			bool flag35 = (nint)0 == 0;
			object obj56 = !flag35;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag36 = obj43 == null;
			bool flag37 = !flag36;
			object obj57 = !flag37;
			num3 = unchecked((nint)null);
			if (obj57 != null)
			{
				continue;
			}
			if ((object)obj43 != null)
			{
				bool flag38 = (byte)(obj24 & 1) != 0;
				bool flag39 = ((GillaDummy)obj43).HeldBy(by.ownerRef, flag38);
				bool flag40 = !flag39;
				gillaDummy = null;
				num3 = (flag38 ? 1 : 0);
				if (flag40)
				{
					continue;
				}
				object obj58 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1359 @ X0_v42+E4]");
				bool flag41 = (nint)0 == 0;
				object obj59 = !flag41;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-F0_v1 (UnityEngine.Object)+80]");
				bool flag42 = (UnityEngine.Object)0 == null;
				bool flag43 = !flag42;
				object obj60 = !flag43;
				gillaDummy = null;
				num3 = unchecked((nint)null);
				if (obj60 != null)
				{
					continue;
				}
				goto IL_0ecb;
			}
			goto IL_155a;
		}
		apePart3 = apePart2;
		num11 = num10;
		num2 = num12;
		object obj61 = 28;
		val3 = (Enumerator<, >)(ref val);
		goto IL_1baa;
		IL_15fc:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_160a;
		IL_15ee:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_15fc;
		IL_15c6:
		throw new NullReferenceException();
		IL_0ecb:
		bool flag44 = obj3 == null;
		val = (Enumerator<, >)num12;
		gillaDummy = null;
		apePart3 = apePart2;
		num11 = num10;
		obj37 = null;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val);
		num2 = num12;
		num3 = unchecked((nint)null);
		obj = null;
		val3 = (Enumerator<, >)(ref val);
		if (flag44)
		{
			goto IL_160a;
		}
		Vector3 position = ((Transform)obj3).position;
		Vector3 middle = ((GillaDummy)obj43).Middle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ X0_v51+E4]");
		bool flag45 = (nint)0 == 0;
		object obj64 = !flag45;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position2 = ((Transform)obj3).position;
		ApePart apePart4 = default;
		bool flag46 = ((GillaDummy)obj43).PartNear((Vector3)(&apePart4), num12, out part, out *(float*)null);
		float num13 = num12 - num12;
		double num14 = num10 - num10;
		apePart3 = (ApePart)(apePart2 - apePart2);
		float num15 = num13 * num13;
		double num16 = num14 * num14;
		float num17 = num15 + (float)num16;
		num11 = (double)apePart3 * (double)apePart3;
		num2 = (float)num11 + num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag47;
		bool flag48;
		if (num2 < num9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-F0_v1 (UnityEngine.Object)+C4]");
			object obj65 = 0 - val4;
			flag47 = (nint)obj65 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-F0_v1 (UnityEngine.Object)+C4]");
			object obj66 = 0 ^ val4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ stack_-F0_v1 (UnityEngine.Object)+C4]");
			object obj67 = 0 ^ obj65;
			object obj68 = obj66 & obj67;
			flag48 = (nint)obj68 < 0;
		}
		else
		{
			flag48 = false;
			flag47 = true;
		}
		bool flag49 = flag47 == flag48;
		object obj69 = !flag49;
		bool flag50 = (byte)(obj69 ^ 1) != 0;
		bool flag51 = flag47 == flag48;
		object obj70 = !flag51;
		if (obj70 == null)
		{
			object obj71 = (flag46 ? 1 : 0) ^ 1;
			object obj72 = obj71 & 1;
			bool flag52 = obj72 == null;
			object obj73 = !flag52;
			if (obj73 == null)
			{
				num11 = (double)part * 1.5;
				float num18 = num2 - (float)num11;
				bool flag53 = num18 < 0f;
				apePart3 = part;
				flag50 = flag53;
			}
		}
		object obj74 = flag46 | flag50;
		object obj75 = obj74 & 1;
		bool flag54 = obj75 == null;
		gillaDummy = null;
		num3 = (nint)(&part);
		if (!flag54)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj76 = 0;
			object obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X0_v58+E4]");
			bool flag55 = (nint)0 == 0;
			object obj78 = !flag55;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			StartOn(by, right, null, (GillaDummy)obj43, null, apePart4, flag50, transform3, (Transform)obj3, (Transform)obj2, num8);
			bool flag56 = flag50;
			ApePart apePart5 = apePart4;
			GillaCorpse gillaCorpse = null;
			Transform transform4 = transform3;
			gillaDummy = (GillaDummy)obj43;
			num2 = num8;
			num3 = unchecked((nint)null);
		}
		ApePart apePart6 = (ApePart)num9;
		obj61 = 20;
		goto IL_1baa;
		IL_160a:
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)obj == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj42 = obj38;
			obj37 = (UnityEngine.Object)1;
		}
		else
		{
			if ((nint)obj != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj79 = default;
			obj42 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj38 = obj79;
		}
		apePart2 = apePart3;
		num10 = num11;
		obj43 = obj37;
		obj44 = 0;
		goto IL_19df;
		IL_155a:
		NullReferenceException ex6 = new NullReferenceException();
		val = (Enumerator<, >)num12;
		apePart3 = apePart2;
		num11 = num10;
		obj32 = null;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val);
		num2 = num12;
		num3 = unchecked((nint)null);
		obj = null;
		val3 = (Enumerator<, >)(ref val);
		goto IL_15b0;
		IL_06e4:
		bool flag57 = obj3 == null;
		part = (ApePart)0;
		val = (Enumerator<, >)0;
		part2 = (ApePart)0;
		obj37 = null;
		val2 = (Enumerator<, >)num7;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val2);
		num8 = num6;
		num9 = (float)num5;
		num2 = num7;
		transform3 = transform;
		num3 = unchecked((nint)null);
		obj = transform2;
		val3 = (Enumerator<, >)(ref val2);
		if (flag57)
		{
			goto IL_15ee;
		}
		Vector3 position3 = ((Transform)obj3).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ stack_-F0_v12 (UnityEngine.Object)+68]");
		bool flag58 = (nint)0 == 0;
		part = (ApePart)0;
		val = (Enumerator<, >)0;
		part2 = (ApePart)0;
		obj37 = null;
		val2 = (Enumerator<, >)num7;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val2);
		num8 = num6;
		num9 = (float)num5;
		num2 = num7;
		transform3 = transform;
		num3 = unchecked((nint)null);
		obj = null;
		val3 = (Enumerator<, >)(ref val2);
		if (flag58)
		{
			goto IL_15fc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ stack_-F0_v12 (UnityEngine.Object)+68]");
		Vector3 position4 = ((Transform)0).position;
		Vector3 middleFromEyes = ((NetworkApe)obj32).MiddleFromEyes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj80 = 0;
		object obj81 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1569 @ X0_v127+E4]");
		bool flag59 = (nint)0 == 0;
		object obj82 = !flag59;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position5 = ((Transform)obj3).position;
		object obj83 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1579 @ X0_v131+E4]");
		bool flag60 = (nint)0 == 0;
		object obj84 = !flag60;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform5 = default;
		bool flag61 = MonsterPlayer.Part((NetworkApe)obj32, (Vector3)(&transform5), num7, out part2, out *(float*)null);
		double num19 = num11 + num11;
		object obj85 = (int)apePart3 + (int)apePart3;
		float num20 = num7 + num7;
		double num21 = num11 - num19;
		float num22 = num7 - num20;
		apePart2 = (ApePart)(apePart3 - obj85);
		double num23 = num21 * num21;
		float num24 = num22 * num22;
		float num25 = num24 + (float)num23;
		num10 = (double)apePart2 * (double)apePart2;
		num2 = (float)num10 + num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag62;
		bool flag63;
		if ((double)num2 < num5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ stack_-F0_v12 (UnityEngine.Object)+6E8]");
			object obj86 = 0 - val4;
			flag62 = (nint)obj86 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ stack_-F0_v12 (UnityEngine.Object)+6E8]");
			object obj87 = 0 ^ val4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ stack_-F0_v12 (UnityEngine.Object)+6E8]");
			object obj88 = 0 ^ obj86;
			object obj89 = obj87 & obj88;
			flag63 = (nint)obj89 < 0;
		}
		else
		{
			flag63 = false;
			flag62 = true;
		}
		bool flag64 = flag62 == flag63;
		object obj90 = !flag64;
		bool flag65 = (byte)(obj90 ^ 1) != 0;
		bool flag66 = flag62 == flag63;
		object obj91 = !flag66;
		if (obj91 == null)
		{
			object obj92 = (flag61 ? 1 : 0) ^ 1;
			object obj93 = obj92 & 1;
			bool flag67 = obj93 == null;
			object obj94 = !flag67;
			if (obj94 == null)
			{
				num10 = (double)part2 * 1.5;
				float num26 = num2 - (float)num10;
				bool flag68 = num26 < 0f;
				apePart2 = part2;
				flag65 = flag68;
			}
		}
		object obj95 = flag61 | flag65;
		object obj96 = obj95 & 1;
		bool flag69 = obj96 == null;
		gillaDummy = null;
		num3 = (nint)(&part2);
		if (!flag69)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj97 = 0;
			object obj98 = obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ X0_v136+E4]");
			bool flag70 = (nint)0 == 0;
			object obj99 = !flag70;
			if (obj99 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			StartOn(by, right, (NetworkApe)obj32, null, null, (ApePart)transform5, flag65, transform, (Transform)obj3, (Transform)obj2, num6);
			bool flag56 = flag65;
			ApePart apePart5 = (ApePart)transform5;
			GillaCorpse gillaCorpse = null;
			Transform transform4 = transform;
			gillaDummy = null;
			num2 = num6;
			num3 = (nint)obj32;
		}
		part = (ApePart)0;
		val = (Enumerator<, >)0;
		apePart6 = apePart3;
		obj42 = 0;
		obj43 = null;
		val2 = (Enumerator<, >)num7;
		obj38 = 0;
		val5 = (Enumerator<, >)(ref val2);
		num8 = num6;
		num9 = (float)num5;
		transform3 = transform;
		obj44 = 20;
		goto IL_19df;
	}

	private static void StartOn(NetworkApe by, bool right, NetworkApe who, GillaDummy dummy, GillaCorpse body, ApePart part, bool middle, Transform grip, Transform a, Transform b, float tears)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)who != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		bool yours;
		Dismemberment ape;
		if (!flag3)
		{
			bool isLocal = who.IsLocal;
			bool flag4 = !isLocal;
			obj4 = null;
			if (!flag4)
			{
				object obj5 = 0;
				UnityEngine.Object obj6 = null;
				yours = true;
				ape = null;
				goto IL_02f0;
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9;
		if ((UnityEngine.Object)who != (UnityEngine.Object)null)
		{
			obj9 = who + 168;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
		}
		else
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v27+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5;
			UnityEngine.Object obj6;
			if (!((UnityEngine.Object)dummy != (UnityEngine.Object)null))
			{
				obj5 = 0;
				obj6 = null;
				yours = false;
				ape = null;
				goto IL_02f0;
			}
			obj9 = dummy + 128;
			obj5 = 0;
			obj6 = null;
		}
		ape = (Dismemberment)obj9;
		yours = false;
		goto IL_02f0;
		IL_02f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Pull pull = Pulling(ape, body, yours, part, middle, grip, a, b, tears);
		if (pull != null)
		{
			object obj15 = pull + 16;
			obj15 = by;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			pull.right = right;
			object obj16 = pull + 32;
			obj16 = who;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj17 = pull + 40;
			obj17 = dummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private static bool Still(GillaQuests.Pull p)
	{
		//IL_06b8: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_0650: Expected Obj, but got I4
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected I4, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_06ff: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I4
		//IL_049f: Expected VT, but got I
		//IL_060f: Expected Obj, but got I4
		//IL_0384: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_06a5: Expected Obj, but got I4
		bool flag12;
		if (p != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			UnityEngine.Object obj2 = p.by;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)p.by == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				object obj6;
				if (~(p.right ? 1u : 0u) == 0)
				{
					if ((object)p.by == null)
					{
						goto IL_06aa;
					}
					obj6 = p.by + 160;
				}
				else
				{
					if ((object)p.by == null)
					{
						goto IL_06aa;
					}
					obj6 = p.by + 152;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = (UnityEngine.Object)obj6 == null;
				bool flag6 = !flag5;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					if (!p.right)
					{
						object obj10 = 152;
					}
					else
					{
						object obj10 = 160;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (UnityEngine.Object)+v337 @ X9_v6]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (UnityEngine.Object)+v337 @ X9_v6]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v7+8C]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						bool flag7 = num < 0;
						object obj12 = !flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v7+8C]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						object obj13 = num2 - 0;
						bool flag8 = obj13 == null;
						object obj14 = ~obj12;
						object obj15 = obj14 | flag8;
						if (obj15 != null)
						{
							goto IL_0647;
						}
						bool right = !p.right;
						Transform transform = p.by.HandOf(right);
						object obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v11+E4]");
						bool flag9 = (nint)0 == 0;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)p.who != (UnityEngine.Object)null)
						{
							if ((object)p.who != null)
							{
								Transform holderHand = p.who.HolderHand;
								object obj18 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v24+E4]");
								bool flag10 = (nint)0 == 0;
								object obj19 = !flag10;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (!(holderHand == transform))
								{
									goto IL_0647;
								}
								bool flag11 = (byte)(~(p.middle ? 1u : 0u)) != 0;
								object obj20 = !flag11;
								if (obj20 != null)
								{
									goto IL_04dc;
								}
								if ((object)p.who != null)
								{
									flag12 = p.who.IsTorn(p.part);
									goto IL_0697;
								}
							}
						}
						else
						{
							object obj21 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v22+E4]");
							bool flag13 = (nint)0 == 0;
							object obj22 = !flag13;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!((UnityEngine.Object)p.dummy != (UnityEngine.Object)null))
							{
								object obj23 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v26+E4]");
								bool flag14 = (nint)0 == 0;
								object obj24 = !flag14;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (p.body != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
									object obj25 = 0;
									object obj26 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v30+E4]");
									bool flag15 = (nint)0 == 0;
									object obj27 = !flag15;
									if (obj27 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool right2 = !p.right;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (UnityEngine.Object)+6CC]");
									GillaCorpse gillaCorpse = GillaCorpse.BodyIn(0, right2);
									object obj28 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v21+E4]");
									bool flag16 = (nint)0 == 0;
									object obj29 = !flag16;
									if (obj29 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									return gillaCorpse == p.body;
								}
								goto IL_0647;
							}
							if ((object)p.dummy != null)
							{
								bool right3 = !p.right;
								GillaDummy dummy = p.dummy;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (UnityEngine.Object)+6D0]");
								if (!dummy.HeldBy((PlayerRef)0, right3))
								{
									goto IL_0647;
								}
								if (~(p.middle ? 1u : 0u) == 0)
								{
									goto IL_04dc;
								}
								if ((object)p.dummy != null)
								{
									flag12 = p.dummy.IsTorn(p.part);
									goto IL_0697;
								}
							}
						}
					}
					goto IL_06aa;
				}
			}
			goto IL_0647;
		}
		goto IL_06aa;
		IL_0697:
		object obj30 = (flag12 ? 1 : 0) ^ 1;
		goto IL_0742;
		IL_0647:
		obj30 = 0;
		goto IL_0742;
		IL_04dc:
		obj30 = 1;
		goto IL_0742;
		IL_06aa:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0742:
		return (byte)(obj30 & 1) != 0;
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I4
		//IL_0878: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected I, but got Obj
		//IL_07cd: Expected Obj, but got I4
		//IL_07d6: Expected Obj, but got I4
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected I, but got Obj
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Ref, but got Unknown
		//IL_085a: Expected Obj, but got I4
		//IL_0663: Expected Obj, but got I4
		//IL_068f: Expected Obj, but got I4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_061d: Expected Obj, but got I4
		//IL_0626: Expected Obj, but got I4
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected I, but got Obj
		//IL_05b8: Expected I, but got Obj
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got I4
		//IL_018d: Expected VT, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_027d: Expected VT, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected I, but got Obj
		//IL_036d: Expected VT, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected VT, but got I4
		//IL_0206: Expected VT, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected I, but got Obj
		//IL_045d: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected VT, but got I4
		//IL_02f6: Expected VT, but got I4
		//IL_0546: Expected Obj, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected I, but got Obj
		//IL_0495: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected VT, but got I4
		//IL_03e6: Expected VT, but got I4
		//IL_04c1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+A0]");
		object obj4 = 0;
		if (obj4 == null)
		{
			goto IL_0633;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FC0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FB8]");
		object obj9 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)obj4).GetEnumerator();
		Enumerator<, > val2 = default;
		Enumerator<, > val = val2;
		nint num = (nint)obj5;
		Enumerator<, > val3 = default;
		bool flag2 = val3.MoveNext();
		bool flag3 = !flag2;
		object obj10 = 0;
		object obj11 = 0;
		Enumerator<, > val4 = (Enumerator<, >)(ref val3);
		object obj12 = default;
		Enumerator<, > val6 = default;
		object obj23;
		Enumerator<, > val7;
		if (!flag3)
		{
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ stack_-A8_v4+A0]");
				if ((nint)0 == 0)
				{
					goto IL_060b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ stack_-A8_v4+A0]");
				Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
				Enumerator<, > val5 = default;
				val = val5;
				while (true)
				{
					num = (nint)obj6;
					if (!val6.MoveNext())
					{
						break;
					}
					if (false)
					{
						object obj13 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v48+E4]");
						bool flag4 = (nint)0 == 0;
						object obj14 = !flag4;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Limb limb;
						bool flag5 = limb.shoulder != null;
						bool flag6 = !flag5;
						Vector3 vector = (Vector3)0;
						if (!flag6)
						{
							if ((object)limb.shoulder == null)
							{
								goto IL_04f6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+54]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+58]");
							object obj16 = 0;
							val = (Enumerator<, >)limb.shoulderAt;
							limb.shoulder.localPosition = (Vector3)0;
							vector = (Vector3)0;
						}
						object obj17 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v53+E4]");
						bool flag7 = (nint)0 == 0;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = limb.head != null;
						bool flag9 = !flag8;
						Vector3 vector2 = (Vector3)0;
						if (!flag9)
						{
							if ((object)limb.head == null)
							{
								goto IL_0572;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+9C]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+A0]");
							object obj16 = 0;
							val = (Enumerator<, >)limb.headAt;
							limb.head.localPosition = (Vector3)0;
							vector2 = (Vector3)0;
						}
						object obj19 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v58+E4]");
						bool flag10 = (nint)0 == 0;
						object obj20 = !flag10;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = limb.away != null;
						bool flag12 = !flag11;
						Vector3 vector3 = (Vector3)0;
						if (!flag12)
						{
							if ((object)limb.away == null)
							{
								goto IL_0534;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+138]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-C0_v6 (GillaPull+Limb)+134]");
							object obj15 = 0;
							val = (Enumerator<, >)limb.awayAt;
							limb.away.localPosition = (Vector3)0;
							vector3 = (Vector3)0;
						}
						object obj21 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X0_v63+E4]");
						bool flag13 = (nint)0 == 0;
						object obj22 = !flag13;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag14 = limb.spine != null;
						bool flag15 = !flag14;
						obj23 = 0;
						if (!flag15)
						{
							object obj24 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v67+E4]");
							bool flag16 = (nint)0 == 0;
							object obj25 = !flag16;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Unstretch(null);
							obj23 = 0;
						}
						continue;
					}
					goto IL_04c6;
				}
				num = (nint)obj8;
				val6.Dispose();
				OutOfMemoryException ex = new OutOfMemoryException();
				val7 = (Enumerator<, >)(ref val6);
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_060b;
		}
		goto IL_0668;
		IL_082f:
		num = (nint)obj9;
		((Enumerator<, >*)val4)->Dispose();
		object obj26;
		bool flag17 = obj26 == null;
		object obj27 = !flag17;
		if (obj27 == null)
		{
			bool flag18 = obj10 == null;
			object obj28 = !flag18;
			OutOfMemoryException ex3 = (OutOfMemoryException)val4;
			if (obj28 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex5 = default;
		NullReferenceException ex4 = ex5;
		goto IL_080c;
		IL_0633:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0791;
		IL_04c6:
		ex6 = new NullReferenceException();
		val7 = (Enumerator<, >)(ref val6);
		obj12 = 0;
		obj11 = 0;
		val4 = (Enumerator<, >)(ref val3);
		goto IL_0791;
		IL_0668:
		obj26 = obj11;
		goto IL_082f;
		IL_0572:
		ex6 = new NullReferenceException();
		obj23 = 0;
		val7 = (Enumerator<, >)(ref val6);
		obj12 = 0;
		obj11 = 0;
		val4 = (Enumerator<, >)(ref val3);
		num = unchecked((nint)null);
		goto IL_0791;
		IL_0534:
		ex6 = new NullReferenceException();
		obj23 = 0;
		val7 = (Enumerator<, >)(ref val6);
		obj12 = 0;
		obj11 = 0;
		val4 = (Enumerator<, >)(ref val3);
		num = unchecked((nint)null);
		goto IL_0791;
		IL_04f6:
		ex6 = new NullReferenceException();
		obj23 = 0;
		val7 = (Enumerator<, >)(ref val6);
		obj12 = 0;
		obj11 = 0;
		val4 = (Enumerator<, >)(ref val3);
		num = unchecked((nint)null);
		goto IL_0791;
		IL_0791:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D9D4");
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = 1;
			goto IL_0668;
		}
		bool flag19 = num != 1;
		ex4 = ex6;
		if (flag19)
		{
			goto IL_080c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj29 = default;
		obj26 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		obj10 = obj12;
		goto IL_082f;
		IL_080c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D998");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_060b:
		NullReferenceException ex7 = new NullReferenceException();
		obj12 = 0;
		obj11 = 0;
		val4 = (Enumerator<, >)(ref val3);
		goto IL_0633;
	}

	private unsafe static void Unstretch(Limb l)
	{
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected VT, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got I4
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Ref, but got Unknown
		//IL_0428: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I4
		bool flag = l == null;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		UnityEngine.Object obj2 = (UnityEngine.Object)109891584;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			obj2 = l.spine;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = obj2 != null;
			bool flag4 = !flag3;
			val = (Enumerator<, >)0;
			obj = null;
			object obj6;
			if (!flag4)
			{
				bool flag5 = (object)l.spine == null;
				val = (Enumerator<, >)0;
				obj6 = 0;
				obj = null;
				if (flag5)
				{
					goto IL_02d5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+150]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+14C]");
				object obj8 = 0;
				val = (Enumerator<, >)l.spineAt;
				l.spine.localScale = (Vector3)0;
				obj = null;
			}
			bool flag6 = (object)l.onSpine == null;
			obj6 = 0;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A68]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A60]");
				obj2 = (UnityEngine.Object)0;
				Enumerator<, > enumerator = ((List<(System.__Canon, Vector3)>)(object)l.onSpine).GetEnumerator();
				obj6 = 0;
				Enumerator<, > val2 = default;
				bool flag9;
				object obj17 = default;
				object obj12;
				object obj13;
				Enumerator<, > val3;
				do
				{
					if (val2.MoveNext())
					{
						object obj10 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v32+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = (UnityEngine.Object)null != (UnityEngine.Object)null;
						flag9 = !flag8;
						obj6 = 0;
						continue;
					}
					obj12 = 0;
					obj13 = 0;
					val3 = (Enumerator<, >)(ref val2);
					object obj14 = 0;
					while (true)
					{
						obj = obj2;
						((Enumerator<, >*)val3)->Dispose();
						bool flag10 = obj14 == null;
						object obj15 = !flag10;
						if (obj15 == null)
						{
							bool flag11 = obj12 == null;
							object obj16 = !flag11;
							OutOfMemoryException ex = (OutOfMemoryException)val3;
							if (obj16 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj12 = 1;
							obj14 = obj13;
							continue;
						}
						if ((nint)obj != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj14 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = obj17;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D1D0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				while (flag9);
				NullReferenceException ex2 = new NullReferenceException();
				obj12 = 0;
				obj13 = 0;
				val3 = (Enumerator<, >)(ref val2);
				obj6 = 0;
				obj = null;
			}
		}
		goto IL_02d5;
		IL_02d5:
		throw new NullReferenceException();
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		Watch();
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tick(deltaTime);
	}

	public static void Tick(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got I4
		//IL_0462: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I
		//IL_054b: Expected I4, but got Obj
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag2 = obj4 == null;
		float num = dt;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+18]");
			int num2 = (int)(-1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FA8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F90]");
			object obj9 = 0;
			Enumerator<, > val = (Enumerator<, >)0;
			num = dt;
			Limb limb = default;
			float num4 = default;
			while (true)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v19+A0]");
				object obj12 = 0;
				if (obj12 == null)
				{
					break;
				}
				object obj13 = obj6;
				System.__Canon _Canon = ((List<System.__Canon>)obj12).get_Item(num2);
				int num3;
				if (Step((GillaQuests.Pull)(object)_Canon, dt))
				{
					bool flag4 = _Canon == null;
					num = dt;
					num3 = num2;
					if (flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v21 (System.__Canon)+A0]");
					bool flag5 = (nint)0 == 0;
					num = dt;
					num3 = num2;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v21 (System.__Canon)+A0]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					while (val.MoveNext())
					{
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v42+E4]");
						bool flag6 = (nint)0 == 0;
						object obj15 = !flag6;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Pose((GillaQuests.Pull)(object)_Canon, limb);
					}
					num3 = (int)obj8;
					val.Dispose();
					Enumerator<, > val2 = (Enumerator<, >)(ref val);
					num = num4;
					OutOfMemoryException ex = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D9D4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v24+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Finish((GillaQuests.Pull)(object)_Canon);
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v16+A0]");
				object obj19 = 0;
				bool flag8 = obj19 == null;
				num = dt;
				num3 = num2;
				if (flag8)
				{
					break;
				}
				obj13 = obj9;
				((List<System.__Canon>)obj19).RemoveAt(num2);
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v29+8]");
				bool flag9 = _Canon != null;
				limb = limb;
				num = dt;
				num3 = num2;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v18+E4]");
					bool flag10 = (nint)0 == 0;
					object obj22 = !flag10;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v20+A0]");
						obj21 = 0;
					}
					object obj24 = obj21 + 8;
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					limb = limb;
					num = dt;
					num3 = 0;
				}
				int num5 = num2 - 1;
				bool flag11 = num2 > 0;
				num2 = num5;
				if (!flag11)
				{
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	private static bool Step(GillaQuests.Pull p, float dt)
	{
		//IL_0795: Expected I4, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_00e1: Invalid comparison between F4 and I
		//IL_0261: Expected Obj, but got I4
		//IL_011f: Invalid comparison between F8 and I4
		//IL_012e: Invalid comparison between F8 and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got F8
		//IL_018b: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected I4, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got F4
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected F4, but got Unknown
		//IL_0867: Expected Obj, but got I4
		//IL_0881: Expected Obj, but got I4
		//IL_08dc: Invalid comparison between F4 and I4
		//IL_08eb: Expected F8, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_04e4: Invalid comparison between F4 and I4
		//IL_04f5: Expected Obj, but got I4
		//IL_04fe: Invalid comparison between F4 and I4
		//IL_050f: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I4
		//IL_0632: Invalid comparison between F4 and I4
		//IL_0641: Expected F8, but got I4
		//IL_0934: Invalid comparison between F8 and I4
		//IL_0943: Expected F8, but got I4
		//IL_0994: Invalid comparison between F8 and I4
		//IL_09a7: Expected Obj, but got F8
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_0a42: Expected Obj, but got I4
		//IL_0a61: Invalid comparison between Obj and F4
		//IL_0a72: Expected Obj, but got I4
		//IL_0a8a: Invalid comparison between F4 and I4
		//IL_0ac3: Expected Obj, but got I4
		//IL_0b11: Invalid comparison between F4 and I
		//IL_072d: Expected VT, but got F8
		if (p == null)
		{
			goto IL_0787;
		}
		if (~(p.snapped ? 1u : 0u) == 0)
		{
			float num = p.x * 3.2946913E+09f;
			double num2 = (double)p.v * -18.0;
			double num3 = (double)num + num2;
			double num4 = num3 * (double)dt;
			double num5 = (double)p.v + num4;
			double num6 = num5 * (double)dt;
			double num7 = (double)p.x + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			p.x = (float)num7;
			p.v = (float)num5;
			float x = p.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (!(x > 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				double num8 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				double num9 = num8 - 0.0;
				bool flag = num9 < 0.0;
				bool flag2 = num9 == 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				object obj = num5 ^ 0;
				object obj2 = num5 ^ num9;
				object obj3 = obj & obj2;
				bool flag3 = (nint)obj3 < 0;
				bool flag4 = flag == flag3;
				object obj4 = !flag2;
				return (byte)((flag4 & obj4) ? 1 : 0) != 0;
			}
			goto IL_07b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = p.pulling == null;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj10 = !flag8;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = p.holding == null;
			bool flag10 = !flag9;
			object obj11 = !flag10;
			if (obj11 == null)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v17+E4]");
				bool flag11 = (nint)0 == 0;
				object obj13 = !flag11;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = p.grip == null;
				bool flag13 = !flag12;
				object obj14 = !flag13;
				if (obj14 == null)
				{
					if (~(p.live ? 1u : 0u) == 0)
					{
						object obj15 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v23+E4]");
						bool flag14 = (nint)0 == 0;
						object obj16 = !flag14;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag15 = (UnityEngine.Object)p.by != (UnityEngine.Object)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
						object obj17 = 0;
						object obj18 = obj17;
						if (flag15)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v39+E4]");
							bool flag16 = (nint)0 == 0;
							object obj19 = !flag16;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (Still(p))
							{
								goto IL_0538;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v39+E4]");
							bool flag17 = (nint)0 == 0;
							object obj20 = !flag17;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj18 = obj17;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v39+A0]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21+8]");
							if (0 == (nint)p)
							{
								int frameCount = Time.frameCount;
								if (p.said >= frameCount)
								{
									goto IL_0538;
								}
							}
						}
						p.live = false;
					}
					goto IL_07c5;
				}
			}
		}
		goto IL_052a;
		IL_052a:
		return false;
		IL_08d3:
		float num10;
		bool flag18 = num10 < 0f;
		double num11 = 0.0;
		if (!flag18)
		{
			bool flag19 = !((double)num10 > 1.0);
			num11 = num10;
			if (!flag19)
			{
				num11 = 1.0;
			}
		}
		double num12 = num11 + num11;
		double num13 = num11 * 3.0;
		double num14 = num11 * num12;
		double num15 = num11 * num14;
		double num16 = num11 * num13;
		double num17 = num16 - num15;
		double num18 = 1.0 - num17;
		double num19 = num18 * 0.0;
		double num20 = num17 + num19;
		p.x = (float)num20;
		goto IL_07b2;
		IL_07b2:
		return true;
		IL_07c5:
		float num21 = dt * 4f;
		object obj22 = 0f - num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGE not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		float num22 = p.strain + (float)obj22;
		num10 = (p.strain = num22 & -1);
		object obj23 = default;
		bool flag20 = (nint)obj23 < 0;
		object obj24 = !flag20;
		bool flag21 = obj23 == null;
		object obj25 = !flag21;
		object obj26 = obj24 & obj25;
		if (obj26 == null)
		{
			bool flag22 = num10 < 0f;
			object obj27 = !flag22;
			bool flag23 = num10 == 0f;
			object obj28 = !flag23;
			object obj29 = obj27 & obj28;
			if (obj29 == null)
			{
				goto IL_052a;
			}
		}
		goto IL_08d3;
		IL_0538:
		if (~(p.live ? 1u : 0u) == 0)
		{
			if ((object)p.pulling != null)
			{
				Vector3 position = p.pulling.position;
				if ((object)p.holding != null)
				{
					Vector3 position2 = p.holding.position;
					float num23 = dt - dt;
					object obj31 = default;
					object obj30 = obj31 - obj31;
					object obj33 = default;
					object obj32 = obj33 - obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
					double num24 = p.start;
					float num25 = num23 - p.start;
					float num26 = num25 / p.tears;
					bool flag24 = num26 < 0f;
					double num27 = 0.0;
					if (!flag24)
					{
						bool flag25 = !((double)num26 > 1.0);
						num27 = num26;
						num24 = 1.0;
						if (!flag25)
						{
							num27 = 1.0;
							num24 = 1.0;
						}
					}
					float num28 = dt * -18f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
					double num29 = 1.0 - (double)num28;
					bool flag26 = num29 < 0.0;
					double num30 = 0.0;
					if (!flag26)
					{
						bool flag27 = !(num29 > 1.0);
						num30 = num29;
						if (!flag27)
						{
							num30 = 1.0;
						}
					}
					double num31 = 1.0 - (double)p.blend;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					float num32 = dt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					float num33 = num32 / 0f;
					bool flag28 = num31 < 0.0;
					object obj34 = num31 ^ num31;
					object obj35 = num31 & obj34;
					bool flag29 = (nint)obj35 < 0;
					float num34 = num23 * num23;
					object obj36 = obj30 * obj30;
					double num35 = num27 - (double)p.strain;
					float num36 = num34 + (float)obj36;
					double num37 = num35 * num30;
					object obj37 = default;
					float num38 = num36 + (float)obj37;
					float num39 = 0f - num33;
					bool flag30 = flag28 == flag29;
					object obj38 = !flag30;
					object obj39 = ~obj38;
					if (obj39 != null)
					{
						num39 = num33;
					}
					object obj40 = default;
					bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num33);
					object obj41 = !flag31;
					float num40 = (float)obj40 - num33;
					bool flag32 = num40 == 0f;
					double num41 = (double)p.strain + num37;
					float num42 = p.blend + num39;
					object obj42 = !flag32;
					object obj43 = obj41 & obj42;
					object obj44 = ~obj43;
					double num43 = ((obj44 != null) ? 1.0 : ((double)num42));
					p.strain = (float)num41;
					p.blend = (float)num43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					bool flag33 = !(num38 > 0f);
					num10 = (float)num41;
					if (!flag33)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
						p.way = (Vector3)num41;
						num10 = p.strain;
					}
					goto IL_08d3;
				}
			}
			goto IL_0787;
		}
		goto IL_07c5;
		IL_0787:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static void Pose(GillaQuests.Pull p, Limb l)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_016c: Expected VT, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0541: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I4
		//IL_0306: Expected VT, but got I4
		//IL_030f: Expected Obj, but got I4
		//IL_0318: Expected VT, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_022f: Expected VT, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I4
		//IL_043a: Expected VT, but got I4
		//IL_0694: Expected Obj, but got I4
		//IL_070b: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I
		//IL_0792: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.spine != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v75+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PoseMiddle(p, l);
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = l.drawn != null;
		bool flag5 = !flag4;
		object obj9 = 0;
		Vector3 vector = (Vector3)0;
		if (!flag5)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v63+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = l.body == null;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				bool inAHand = l.body.InAHand;
				bool flag9 = !inAHand;
				obj9 = 0;
				vector = (Vector3)0;
				if (flag9)
				{
					goto IL_031d;
				}
			}
			Vector3 position = l.drawn.position;
			float num = l.reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num2 = num * 0f;
			float num3 = num2 * p.x;
			float num4 = (float)p.way * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaQuests+Pull)+80]");
			float num5 = 0f * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaQuests+Pull)+84]");
			float num6 = 0f * num3;
			float num7 = num7 + num4;
			float num8 = num8 + num5;
			float num9 = num9 + num6;
			l.drawn.position = (Vector3)0;
			obj9 = 0;
			vector = (Vector3)0;
		}
		goto IL_031d;
		IL_031d:
		if (~(l.off ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v51+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Back(l);
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v54+E4]");
			bool flag11 = (nint)0 == 0;
			object obj17 = !flag11;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (l.shoulder != null)
			{
				Vector3 position2 = l.shoulder.position;
				l.shoulder.position = (Vector3)0;
			}
			return;
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj19 = !flag12;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.away != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v46+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PoseAway(p, l);
			return;
		}
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v18+E4]");
		bool flag14 = (nint)0 == 0;
		object obj24 = !flag14;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.head != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v41+E4]");
			bool flag15 = (nint)0 == 0;
			object obj27 = !flag15;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PoseHead(p, l);
			return;
		}
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v22+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(l.up != null))
		{
			return;
		}
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v26+E4]");
		bool flag17 = (nint)0 == 0;
		object obj31 = !flag17;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(l.lo != null))
		{
			return;
		}
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v30+E4]");
		bool flag18 = (nint)0 == 0;
		object obj33 = !flag18;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.end != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v34+E4]");
			bool flag19 = (nint)0 == 0;
			object obj36 = !flag19;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PoseArm(p, l);
		}
	}

	private static void PoseAway(GillaQuests.Pull p, Limb l)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(l.eyes == null))
		{
			Vector3 position = l.away.position;
			Vector3 position2 = p.grip.position;
			Vector3 position3 = l.eyes.position;
			l.away.position = (Vector3)0;
		}
	}

	private static void PoseHead(GillaQuests.Pull p, Limb l)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00f3: Invalid comparison between F4 and I4
		//IL_009f: Expected VT, but got I4
		//IL_013e: Expected VT, but got I4
		//IL_00b7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.body != null)
		{
			l.head.localPosition = (Vector3)0;
			l.head.localRotation = (Quaternion)0;
		}
		Vector3 position = l.head.position;
		Vector3 position2 = p.grip.position;
		if (p.blend < 0f || (double)p.blend > 1.0)
		{
		}
		l.head.position = (Vector3)0;
	}

	private unsafe static void PoseMiddle(GillaQuests.Pull p, Limb l)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected F8, but got I4
		//IL_09db: Expected F8, but got I4
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected F8, but got I4
		//IL_0057: Expected F8, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected F8, but got I4
		//IL_00e2: Expected F8, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected Obj, but got I
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected Obj, but got I4
		//IL_01b0: Invalid comparison between F8 and I4
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Expected F8, but got I4
		//IL_0ac5: Expected F8, but got I4
		//IL_0ad6: Expected F8, but got I4
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected F8, but got I4
		//IL_01e6: Expected F8, but got I
		//IL_01f6: Expected F8, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected F8, but got I
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got I4
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected F8, but got I4
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected VT, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected F8, but got I4
		//IL_02a0: Expected F8, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected Obj, but got I
		//IL_0bf8: Expected Obj, but got I
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected F8, but got I
		//IL_0c2d: Expected F8, but got I
		//IL_03b1: Expected F8, but got I
		//IL_03c1: Expected F8, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Expected Obj, but got I4
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got I
		//IL_0867: Expected I, but got Obj
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected I4, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected F8, but got I
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got I4
		//IL_0656: Expected F8, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected F8, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Ref, but got Unknown
		//IL_0d11: Expected Obj, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got I4
		//IL_08c1: Expected Obj, but got I
		//IL_08c6: Expected I, but got Obj
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected F8, but got I4
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got F8
		//IL_04cf: Expected Obj, but got I4
		//IL_04d4: Expected I, but got Obj
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Invalid comparison between F8 and I4
		//IL_06a0: Expected Obj, but got I4
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Invalid comparison between F8 and I4
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got I4
		//IL_07bb: Expected Obj, but got I4
		//IL_07c0: Expected I, but got Obj
		//IL_07c9: Expected F8, but got I4
		//IL_07d2: Expected Obj, but got I4
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got F8
		//IL_052d: Expected VT, but got I4
		//IL_052d: Expected VT, but got I4
		//IL_053a: Expected Obj, but got F8
		//IL_076b: Expected I, but got Obj
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected VT, but got I4
		//IL_0612: Expected Obj, but got F8
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected VT, but got Unknown
		//IL_061f: Expected I, but got Obj
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDB51]");
		Enumerator<, > val = (Enumerator<, >)0;
		bool flag = p == null;
		double num2 = default;
		double num = num2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num6 = default;
		double num5 = num6;
		double num8 = default;
		double num7 = num8;
		Enumerator<, > val4 = (Enumerator<, >)0;
		UnityEngine.Object obj = (UnityEngine.Object)(object)l;
		Limb limb = l;
		int num23;
		object obj10 = default;
		object obj11 = default;
		Enumerator<, > val5 = default;
		object obj16;
		object obj8;
		string text2;
		object obj5;
		nint num24;
		object obj15 = default;
		Enumerator<, > val7 = default;
		if (!flag)
		{
			bool flag2 = (object)p.pulling == null;
			num = num2;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			num3 = 0.0;
			num4 = 0.0;
			num5 = num6;
			num7 = num8;
			val4 = (Enumerator<, >)0;
			obj = (UnityEngine.Object)(object)l;
			limb = l;
			if (!flag2)
			{
				Vector3 position = p.pulling.position;
				bool flag3 = (object)p.holding == null;
				num = num2;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				num3 = 0.0;
				num4 = 0.0;
				num5 = num6;
				num7 = num8;
				val4 = (Enumerator<, >)0;
				obj = null;
				limb = l;
				if (!flag3)
				{
					Vector3 position2 = p.holding.position;
					double num9 = num8 - num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj2 = 0;
					double num10 = num6 - num6;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v51+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v51+E4]");
					bool flag4 = (nint)0 == 0;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num11 = 0.0 * 0.0;
					double num12 = num9 * num9;
					double num13 = num11 + num12;
					double num14 = num10 * num10;
					double num15 = num14 + num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num16 = num15 - (double)p.start;
					if (num16 < 0.0)
					{
						num16 = 0.0;
					}
					bool flag5 = l == null;
					num = num2;
					val2 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					num3 = 0.0;
					num4 = 0.0;
					num5 = num6;
					num7 = 0.0;
					val4 = (Enumerator<, >)num16;
					obj = null;
					limb = l;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+14C]");
						double num17 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+150]");
						double num18 = 0.0;
						num5 = l.width;
						num7 = p.blend;
						if (l.across != 0)
						{
							if (l.across != 1)
							{
								bool flag6 = l.across != 2;
								num = num2;
								val2 = (Enumerator<, >)0;
								val3 = (Enumerator<, >)0;
								num3 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+150]");
								double num19 = 0.0;
								val4 = (Enumerator<, >)num16;
								obj = null;
								val = (Enumerator<, >)l.across;
								limb = l;
								if (flag6)
								{
									goto IL_081d;
								}
								val = (Enumerator<, >)(ref num19);
							}
							else
							{
								val = (Enumerator<, >)(ref num4);
							}
						}
						else
						{
							Vector3 vector = default;
							val = (Enumerator<, >)(ref vector);
						}
						double num20 = num7 * num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						num17 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						double num21 = num20 / num16;
						num10 = num21 + 1.0;
						double num22 = num10 * (double)val;
						val = (Enumerator<, >)num22;
						bool flag7 = (object)l.spine == null;
						obj5 = 17276928;
						num = num2;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						num3 = 0.0;
						num7 = 1.0;
						val4 = (Enumerator<, >)num22;
						obj = null;
						limb = l;
						if (!flag7)
						{
							l.spine.localScale = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj6 = 0;
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v23+A0]");
							obj5 = 0;
							num23 = l.across;
							val4 = (Enumerator<, >)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+4]");
							num7 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+8]");
							num5 = 0.0;
							double num25 = default;
							if (l.across != 0)
							{
								if (l.across != 2)
								{
									if (l.across != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										IndexOutOfRangeException ex = default;
										string text = default;
										ex._002Ector(text);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6068]");
										obj8 = 0;
										num24 = unchecked((nint)null);
										num = num2;
										val2 = (Enumerator<, >)0;
										text2 = text;
										limb = l;
										goto IL_0cce;
									}
									val3 = (Enumerator<, >)obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+8]");
									num3 = 0.0;
									val = (Enumerator<, >)(ref num25);
								}
								else
								{
									val3 = (Enumerator<, >)obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+4]");
									num25 = 0.0;
									val = (Enumerator<, >)(ref num3);
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+8]");
								num3 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v1+4]");
								num25 = 0.0;
								val = (Enumerator<, >)(ref val3);
							}
							val = (Enumerator<, >)1065353216;
							bool flag8 = (object)l.onSpine == null;
							obj5 = 1065353216;
							num = num2;
							val2 = (Enumerator<, >)0;
							obj = null;
							limb = l;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A68]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A60]");
								obj11 = 0;
								Enumerator<, > enumerator = ((List<(System.__Canon, Vector3)>)(object)l.onSpine).GetEnumerator();
								double num26 = num10 + -1.0;
								num5 = -1.0;
								num7 = num2;
								val4 = val5;
								val = (Enumerator<, >)(ref val2);
								Quaternion rotation = default;
								while (val2.MoveNext())
								{
									object obj12 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v60+E4]");
									val = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v60+E4]");
									bool flag9 = (nint)0 == 0;
									object obj13 = !flag9;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag10 = (UnityEngine.Object)num2 == null;
									bool flag11 = !flag10;
									object obj14 = !flag11;
									num24 = unchecked((nint)null);
									if (obj14 != null)
									{
										continue;
									}
									if (num2 != 0.0)
									{
										Quaternion localRotation = ((Transform)num2).localRotation;
										Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation);
										Vector3 vector2 = (Quaternion)0 * (Vector3)0;
										Vector3 localScale = ((Transform)num2).localScale;
										double num27 = num26 * (double)val4;
										double num28 = num26 * num7;
										double num29 = (double)val4 * num27;
										double num30 = num29 + 1.0;
										Enumerator<, > val6 = (Enumerator<, >)(val4 / num30);
										double num31 = num7 * num28;
										num18 = num26 * num5;
										double num32 = num31 + 1.0;
										double num33 = num7 / num32;
										double num34 = num5 * num18;
										double num35 = num34 + 1.0;
										double num36 = num5 / num35;
										((Transform)num2).localScale = (Vector3)0;
										rotation = (Quaternion)val4;
										num24 = unchecked((nint)null);
										num5 = num36;
										num17 = num35;
										num7 = num33;
										val4 = val6;
										continue;
									}
									goto IL_07a9;
								}
								obj5 = 1065353216;
								num = 0.0;
								obj15 = 0;
								val2 = val5;
								val7 = (Enumerator<, >)(ref val2);
								limb = l;
								obj16 = 0;
								goto IL_0ce6;
							}
						}
					}
				}
			}
		}
		goto IL_07f5;
		IL_0ce6:
		obj = (UnityEngine.Object)obj11;
		((Enumerator<, >*)val7)->Dispose();
		bool flag12 = obj16 == null;
		object obj17 = !flag12;
		if (obj17 == null)
		{
			bool flag13 = num == 0.0;
			object obj18 = !flag13;
			OutOfMemoryException ex2 = (OutOfMemoryException)val7;
			val = (Enumerator<, >)num;
			if (obj18 == null)
			{
				object obj19 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v4+E4]");
				val = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v4+E4]");
				bool flag14 = (nint)0 == 0;
				object obj20 = !flag14;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (limb.drawn != null)
				{
					limb = (Limb)(object)limb.drawn;
					bool flag15 = (object)limb.drawn == null;
					num24 = unchecked((nint)null);
					obj = null;
					if (!flag15)
					{
						Vector3 position3 = limb.drawn.position;
						limb.drawn.position = (Vector3)0;
						return;
					}
					goto IL_07f5;
				}
				return;
			}
		}
		else
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_081d;
		IL_081d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		IndexOutOfRangeException ex3 = default;
		string text3 = default;
		ex3._002Ector(text3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6060]");
		obj8 = 0;
		num24 = unchecked((nint)null);
		text2 = text3;
		num23 = (int)val;
		goto IL_0cce;
		IL_0cce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex4 = new ArgumentNullException();
		object obj21 = default;
		if ((nint)obj21 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num = 1.0;
			val = (Enumerator<, >)1;
			obj16 = obj15;
		}
		else
		{
			if ((nint)obj21 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D1D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj22 = default;
			obj16 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj15 = obj22;
			val = (Enumerator<, >)num23;
		}
		goto IL_0ce6;
		IL_07f5:
		throw new NullReferenceException();
		IL_07a9:
		NullReferenceException ex5 = new NullReferenceException();
		obj5 = 1065353216;
		num24 = unchecked((nint)null);
		num = 0.0;
		obj15 = 0;
		val2 = val5;
		val7 = (Enumerator<, >)(ref val2);
		obj = null;
		limb = l;
		goto IL_07f5;
	}

	private unsafe static void PoseArm(GillaQuests.Pull p, Limb l)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_009f: Expected VT, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_00b7: Expected VT, but got I4
		//IL_0205: Expected F4, but got I
		//IL_0212: Expected F4, but got VT
		//IL_0222: Expected F4, but got I
		//IL_00cf: Expected VT, but got I4
		//IL_00e7: Expected VT, but got I4
		//IL_034a: Invalid comparison between F4 and I4
		//IL_0359: Expected F8, but got I4
		//IL_00ff: Expected VT, but got I4
		//IL_0bb8: Invalid comparison between F4 and I4
		//IL_0c72: Expected F8, but got I4
		//IL_030e: Expected VT, but got I4
		//IL_0117: Expected VT, but got I4
		//IL_012f: Expected VT, but got I4
		//IL_13fb: Expected Obj, but got I
		//IL_1452: Expected Obj, but got I4
		//IL_0147: Expected VT, but got I4
		//IL_04c1: Invalid comparison between F8 and I4
		//IL_04d0: Invalid comparison between F8 and I4
		//IL_04e3: Expected Obj, but got F8
		//IL_04f0: Expected Obj, but got F8
		//IL_0525: Expected Obj, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0d44: Invalid comparison between F4 and I4
		//IL_05aa: Invalid comparison between F8 and I4
		//IL_05b9: Invalid comparison between F8 and I4
		//IL_05d6: Expected Obj, but got F8
		//IL_05e8: Expected Obj, but got F8
		//IL_061d: Expected Obj, but got I4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0583: Expected F8, but got I4
		//IL_0e36: Invalid comparison between F8 and I4
		//IL_0e45: Invalid comparison between F8 and I4
		//IL_0e58: Expected Obj, but got F8
		//IL_0e65: Expected Obj, but got F8
		//IL_0e9a: Expected Obj, but got I4
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected Obj, but got Unknown
		//IL_14ac: Expected Obj, but got I
		//IL_150f: Expected Obj, but got I
		//IL_159e: Invalid comparison between F8 and Obj
		//IL_0f8f: Invalid comparison between F8 and Obj
		//IL_0fae: Invalid comparison between F8 and Obj
		//IL_1020: Invalid comparison between F8 and I
		//IL_1140: Expected Obj, but got I
		//IL_115e: Expected Obj, but got I
		//IL_1174: Expected Obj, but got I
		//IL_118a: Expected Obj, but got I
		//IL_10e1: Expected Obj, but got I
		//IL_10ff: Expected Obj, but got I
		//IL_1115: Expected Obj, but got I
		//IL_112b: Expected Obj, but got I
		//IL_15df: Expected Obj, but got I4
		//IL_1056: Invalid comparison between F8 and I
		//IL_11e6: Expected Obj, but got I4
		//IL_07e7: Expected Obj, but got I
		//IL_07ff: Expected Obj, but got I
		//IL_0807: Expected F8, but got Obj
		//IL_0817: Expected F8, but got I
		//IL_0827: Expected F8, but got I
		//IL_160c: Invalid comparison between F8 and I
		//IL_10ba: Invalid comparison between F8 and I4
		//IL_16eb: Expected Obj, but got I4
		//IL_0835: Expected F8, but got I4
		//IL_0863: Invalid comparison between F8 and I
		//IL_1310: Invalid comparison between F8 and I4
		//IL_131f: Expected F8, but got I4
		//IL_1396: Expected Obj, but got I
		//IL_139f: Invalid comparison between F8 and I4
		//IL_13dd: Expected Obj, but got I4
		//IL_1357: Expected Obj, but got I4
		//IL_0a36: Expected VT, but got I4
		//IL_0a4e: Expected VT, but got I4
		//IL_0a66: Expected VT, but got I4
		//IL_0a81: Expected VT, but got I4
		//IL_0aef: Expected VT, but got I4
		//IL_0b48: Expected VT, but got I4
		//IL_0b91: Expected VT, but got I4
		//IL_0ba9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.body != null)
		{
			l.up.localRotation = (Quaternion)0;
			l.up.localScale = (Vector3)0;
			l.lo.localRotation = (Quaternion)0;
			l.lo.localScale = (Vector3)0;
			l.lo.localPosition = (Vector3)0;
			l.end.localRotation = (Quaternion)0;
			l.end.localScale = (Vector3)0;
			l.end.localPosition = (Vector3)0;
		}
		Vector3 position = l.end.position;
		Vector3 position2 = l.lo.position;
		Quaternion rotation = l.end.rotation;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = l.shoulder != null;
		bool flag4 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+6C]");
		float num = 0f;
		float num2 = (float)l.endAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+70]");
		float num3 = 0f;
		if (!flag4)
		{
			Vector3 position3 = l.shoulder.position;
			float num4 = l.reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			float num5 = num4 * 0f;
			float num6 = num5 * p.x;
			float num7 = (float)p.way * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaQuests+Pull)+80]");
			float num8 = 0f * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaQuests+Pull)+84]");
			float num9 = 0f * num6;
			num2 = (float)l.endAt + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+6C]");
			num = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+70]");
			num3 = 0f + num9;
			l.shoulder.position = (Vector3)0;
		}
		Vector3 position4 = l.up.position;
		Vector3 position5 = p.grip.position;
		bool flag5 = p.blend < 0f;
		double num10 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)p.blend > 1.0);
			num10 = p.blend;
			if (!flag6)
			{
				num10 = 1.0;
			}
		}
		bool flag7 = p.blend < 0f;
		double num11 = (double)l.keepOffset + -1.0;
		double num12 = num11 * num10;
		double num13 = num12 + 1.0;
		double num14 = (double)l.offset * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+C0]");
		double num15 = 0.0 * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+C4]");
		double num16 = 0.0 * num13;
		double num17 = (double)num2 + num14;
		double num18 = (double)num + num15;
		double num19 = (double)num3 + num16;
		double num20 = 0.0;
		if (!flag7)
		{
			bool flag8 = !((double)p.blend > 1.0);
			num20 = p.blend;
			if (!flag8)
			{
				num20 = 1.0;
			}
		}
		double num21 = num17 - (double)l.endAt;
		double num22 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+6C]");
		double num23 = num22 - 0.0;
		double num24 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+70]");
		double num25 = num24 - 0.0;
		double num26 = num21 * num20;
		double num27 = num23 * num20;
		double num28 = num25 * num20;
		double num29 = (double)l.endAt + num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+6C]");
		double num30 = 0.0 + num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+70]");
		double num31 = 0.0 + num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		double num32 = num29 - (double)num2;
		double num33 = num30 - (double)num;
		double num34 = num31 - (double)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v25+E4]");
		bool flag9 = (nint)0 == 0;
		object obj8 = !flag9;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num35 = num32 * num32;
		double num36 = num33 * num33;
		double num37 = num34 * num34;
		double num38 = num35 + num36;
		double num39 = num37 + num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num40 = num39 / (double)l.reach;
		float num41 = p.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num42 = num41 * 0f;
		double num43 = (double)num42 + 1.0;
		double num44 = num43 - num40;
		bool flag10 = num44 < 0.0;
		bool flag11 = num44 == 0.0;
		object obj9 = num43 ^ num40;
		object obj10 = num43 ^ num44;
		object obj11 = obj9 & obj10;
		bool flag12 = (nint)obj11 < 0;
		bool flag13 = flag10 == flag12;
		object obj12 = !flag11;
		object obj13 = flag13 & obj12;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			num40 = num43;
		}
		double num46;
		double num47;
		if (p.blend < 0f)
		{
			double num45 = num40 + -1.0;
			num46 = num45 * 0.0;
			num47 = 0.0;
		}
		else
		{
			double num48 = (double)p.blend - 1.0;
			bool flag14 = num48 < 0.0;
			bool flag15 = num48 == 0.0;
			object obj15 = (double)p.blend ^ 1.0;
			object obj16 = (double)p.blend ^ num48;
			object obj17 = obj15 & obj16;
			bool flag16 = (nint)obj17 < 0;
			bool flag17 = flag14 == flag16;
			object obj18 = !flag15;
			object obj19 = flag17 & obj18;
			object obj20 = ~obj19;
			num47 = ((obj20 != null) ? ((double)p.blend) : 1.0);
			double num49 = num40 + -1.0;
			num46 = num47 * num49;
		}
		double num50 = num46 + 1.0;
		double num51 = num33 / num39;
		double num52 = num50 * (double)l.lengthLo;
		double num53 = num43 + -1.0;
		double num54 = num39 - num52;
		double num55 = num53 * num47;
		double num56 = num52 * num52;
		double num57 = num32 / num39;
		double num58 = num55 + 1.0;
		double num59 = (double)l.endAt - (double)num2;
		double num60 = num54 / (double)l.lengthUp;
		double num61 = num58 - num60;
		bool flag18 = num61 < 0.0;
		bool flag19 = num61 == 0.0;
		object obj21 = num58 ^ num60;
		object obj22 = num58 ^ num61;
		object obj23 = obj21 & obj22;
		bool flag20 = (nint)obj23 < 0;
		bool flag21 = flag18 == flag20;
		object obj24 = !flag19;
		object obj25 = flag21 & obj24;
		object obj26 = ~obj25;
		if (obj26 != null)
		{
			num58 = num60;
		}
		double num62 = (double)l.lengthUp * num58;
		double num63 = num34 / num39;
		double num64 = num39 + num39;
		double num65 = num62 * num62;
		double num66 = num39 * num39;
		double num67 = num65 - num56;
		double num68 = num66 + num67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+6C]");
		double num69 = 0.0 - (double)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (GillaPull+Limb)+70]");
		double num70 = 0.0 - (double)num3;
		double num71 = num57 * num57;
		double num72 = num51 * num51;
		double num73 = num59 * num57;
		double num74 = num69 * num51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj27 = 0;
		double num75 = num68 / num64;
		object obj28 = obj27;
		double num76 = num71 + num72;
		double num77 = num63 * num63;
		double num78 = num73 + num74;
		double num79 = num70 * num63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v16+A0]");
		object obj29 = 0;
		double num80 = num77 + num76;
		double num81 = num79 + num78;
		double num82 = num81 / num80;
		double num83 = num57 * num82;
		double num84 = num51 * num82;
		double num85 = num63 * num82;
		double num86 = num59 - num83;
		double num87 = num69 - num84;
		double num88 = num70 - num85;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num80) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
		{
			num59 = num86;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num80) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
		{
			num69 = num87;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num80) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
		{
			num70 = num88;
		}
		double num89 = num59 * num59;
		double num90 = num69 * num69;
		double num91 = num89 + num90;
		double num92 = num70 * num70;
		double num93 = num91 + num92;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		double num94;
		double num95;
		float num96;
		double num97;
		double num98;
		double num99;
		if (num93 > 0.0)
		{
			num94 = num57;
			num95 = num63;
			object obj30 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X0_v91+E4]");
			bool flag22 = (nint)0 == 0;
			object obj31 = !flag22;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num94 = num57;
				num95 = num63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			bool flag23 = !(num86 > 0.0);
			num96 = num2;
			if (flag23)
			{
				goto IL_07d7;
			}
			num97 = num59 / num86;
			num98 = num69 / num86;
			num99 = num70 / num86;
			num96 = num2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			nint num100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj34;
			object obj35;
			object obj36;
			if (num100 < 0)
			{
				num94 = num57;
				num95 = num63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v56+A0]");
				obj34 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v56+A0]");
				obj35 = (nint)0 + (nint)28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v56+A0]");
				obj36 = (nint)0 + (nint)32;
			}
			else
			{
				num94 = num57;
				num95 = num63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v49+A0]");
				obj34 = (nint)0 + (nint)60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v49+A0]");
				obj35 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v49+A0]");
				obj36 = (nint)0 + (nint)68;
			}
			double num101 = num51 * (double)obj36;
			double num102 = num95 * (double)obj35;
			double num103 = num95 * (double)obj34;
			double num104 = num94 * (double)obj36;
			double num105 = num94 * (double)obj35;
			double num106 = num51 * (double)obj34;
			object obj39 = obj6;
			double num107 = num101 - num102;
			double num108 = num103 - num104;
			double num109 = num105 - num106;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X0_v72+E4]");
			bool flag24 = (nint)0 == 0;
			object obj40 = !flag24;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num94 = num57;
				num95 = num63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			bool flag25 = !(num86 > 0.0);
			num96 = num2;
			if (flag25)
			{
				goto IL_07d7;
			}
			num97 = num107 / num86;
			num98 = num108 / num86;
			num99 = num109 / num86;
			num96 = num2;
		}
		goto IL_1075;
		IL_07d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj41 = 0;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X8_v34+A0]");
		object obj43 = 0;
		num97 = (double)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v35+4]");
		num98 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v35+8]");
		num99 = 0.0;
		goto IL_1075;
		IL_1075:
		double num110 = num75 * num75;
		double num111 = num51 * num75;
		double num112 = num95 * num75;
		double num113 = num65 - num110;
		if (num113 < 0.0)
		{
			num113 = 0.0;
		}
		double num114 = num94 * num75;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num115 = (double)num96 + num114;
		double num116 = (double)num + num111;
		double num117 = (double)num3 + num112;
		double num118 = num113 * num97;
		double num119 = num113 * num98;
		double num120 = num113 * num99;
		double num121 = num115 + num118;
		double num122 = num116 + num119;
		double num123 = num117 + num120;
		double num124 = num121 - (double)num96;
		double num125 = num29 - num121;
		double num126 = num122 - (double)num;
		double num127 = num123 - (double)num3;
		double num128 = num30 - num122;
		double num129 = num31 - num123;
		double num130 = num124 * num124;
		double num131 = num126 * num126;
		object obj44 = obj6;
		double num132 = num125 * num125;
		double num133 = num128 * num128;
		double num134 = num130 + num131;
		double num135 = num127 * num127;
		double num136 = num132 + num133;
		double num137 = num129 * num129;
		double num138 = num135 + num134;
		double num139 = num137 + num136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X0_v30+E4]");
		bool flag26 = (nint)0 == 0;
		object obj45 = !flag26;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		bool flag27 = num138 < 0.0;
		double num140 = -5.0;
		if (!flag27)
		{
			double num141 = num124 * num125;
			double num142 = num126 * num128;
			double num143 = num141 + num142;
			double num144 = num127 * num129;
			double num145 = num144 + num143;
			double num146 = num145 / num138;
			bool flag28 = num146 < -1.0;
			double num147 = -1.0;
			if (!flag28)
			{
				bool flag29 = !(num146 > 1.0);
				num147 = num146;
				if (!flag29)
				{
					num147 = 1.0;
				}
			}
			object obj46 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X0_v61+E4]");
			bool flag30 = (nint)0 == 0;
			object obj47 = !flag30;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
			double num148 = num147;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			double num149 = num148 * 0.0;
			num140 = num149 + -5.0;
		}
		double num150 = num140 / 25.0;
		bool flag31 = num150 < 0.0;
		double num151 = 0.0;
		if (!flag31)
		{
			bool flag32 = !(num150 > 1.0);
			num151 = num150;
			if (!flag32)
			{
				num151 = 1.0;
			}
		}
		double num152 = p.blend;
		double num153 = num151 * (double)p.blend;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj48 = 0;
		if (!(num153 < 0.0))
		{
			bool flag33 = !(num153 > 1.0);
			num152 = 1.0;
			if (!flag33)
			{
				num152 = 1.0;
			}
		}
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X0_v33+E4]");
		bool flag34 = (nint)0 == 0;
		object obj50 = !flag34;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		l.up.localScale = (Vector3)0;
		l.lo.localPosition = (Vector3)0;
		l.lo.localScale = (Vector3)0;
		l.end.localScale = (Vector3)0;
		Vector3 up = l.up.up;
		Vector3 fromDirection = default;
		Vector3 toDirection = default;
		Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion rotation2 = l.up.rotation;
		l.up.rotation = (Quaternion)0;
		Vector3 up2 = l.lo.up;
		Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion rotation3 = l.lo.rotation;
		l.lo.rotation = (Quaternion)0;
		Quaternion rotation4 = l.lo.rotation;
		Quaternion b = default;
		Quaternion quaternion3 = Quaternion.Internal_Slerp(ref *(Quaternion*)(&fromDirection), ref b, p.blend);
		l.end.rotation = (Quaternion)0;
		l.end.position = (Vector3)0;
	}

	private static Vector3 AlongY(Vector3 scale, float by)
	{
		return scale;
	}

	private static void Back(Limb l)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01ea: Expected VT, but got I4
		//IL_0177: Expected VT, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_02c1: Expected VT, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_022b: Expected VT, but got I4
		//IL_0234: Expected VT, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_0302: Expected VT, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_038a: Expected VT, but got I4
		//IL_04a9: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I
		//IL_03d8: Expected VT, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_03ea: Expected VT, but got I4
		//IL_0539: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I4
		//IL_063b: Expected VT, but got I4
		//IL_0653: Expected VT, but got I4
		//IL_066b: Expected VT, but got I4
		//IL_0695: Expected Obj, but got I4
		//IL_06f5: Expected VT, but got I4
		//IL_070d: Expected VT, but got I4
		//IL_0726: Expected Obj, but got I4
		//IL_0747: Expected VT, but got I4
		//IL_075f: Expected VT, but got I4
		//IL_0777: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.spine != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v71+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Unstretch(l);
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.away != null)
		{
			l.away.localPosition = (Vector3)0;
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = l.shoulder != null;
		bool flag6 = !flag5;
		Vector3 vector = (Vector3)0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+54]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+58]");
			object obj12 = 0;
			l.shoulder.localPosition = (Vector3)0;
			vector = (Vector3)0;
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = l.head != null;
		bool flag9 = !flag8;
		Quaternion shoulderAt = (Quaternion)l.shoulderAt;
		object obj15 = 0;
		Quaternion quaternion = (Quaternion)0;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+9C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+A0]");
			object obj12 = 0;
			l.head.localPosition = (Vector3)0;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v60+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = l.body != null;
			bool flag12 = !flag11;
			shoulderAt = (Quaternion)l.headAt;
			obj15 = 0;
			quaternion = (Quaternion)0;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+FC]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X0 (GillaPull+Limb)+100]");
				obj12 = 0;
				shoulderAt = l.headTurn;
				l.head.localRotation = (Quaternion)0;
				obj15 = 0;
				quaternion = (Quaternion)0;
			}
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v22+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = l.up == null;
		bool flag15 = !flag14;
		object obj20 = !flag15;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (obj20 == null)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v35+E4]");
			bool flag16 = (nint)0 == 0;
			object obj24 = !flag16;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = l.lo == null;
			bool flag18 = !flag17;
			object obj25 = !flag18;
			obj21 = 0;
			obj22 = null;
			if (obj25 == null)
			{
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v39+E4]");
				bool flag19 = (nint)0 == 0;
				object obj27 = !flag19;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag20 = l.end == null;
				bool flag21 = !flag20;
				obj21 = 0;
				obj22 = null;
				if (flag21)
				{
					l.end.localScale = (Vector3)0;
					l.lo.localPosition = (Vector3)0;
					l.end.localPosition = (Vector3)0;
					object obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v46+E4]");
					bool flag22 = (nint)0 == 0;
					object obj29 = !flag22;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (l.body != null)
					{
						l.up.localScale = (Vector3)0;
						l.lo.localScale = (Vector3)0;
						bool flag23 = (byte)(~(l.off ? 1u : 0u)) != 0;
						object obj30 = !flag23;
						if (obj30 == null)
						{
							l.up.localRotation = (Quaternion)0;
							l.lo.localRotation = (Quaternion)0;
							l.end.localRotation = (Quaternion)0;
						}
						goto IL_060b;
					}
					return;
				}
			}
		}
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v30+E4]");
		bool flag24 = (nint)0 == 0;
		object obj32 = !flag24;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (l.body != null)
		{
			goto IL_060b;
		}
		return;
		IL_060b:
		l.body.LimbStill(l.part, still: false);
	}

	private unsafe static void Finish(GillaQuests.Pull p)
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got I4
		//IL_0209: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got Ref
		//IL_017a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FE0]");
		object obj3 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)p.limbs).GetEnumerator();
		Enumerator<, > val = default;
		while (val.MoveNext())
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Back(null);
		}
		object obj6 = 0;
		object obj7 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj8 = 0;
		object obj11 = default;
		object obj12 = default;
		IntPtr intPtr = default;
		object obj13 = default;
		while (true)
		{
			nint num = (nint)obj3;
			val.Dispose();
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				bool flag3 = obj6 == null;
				object obj10 = !flag3;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj10 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj6 = obj11;
				obj7 = obj12;
				num = intPtr;
				obj3 = 109891584;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num)
			{
			case 2L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj6 = 1;
				obj8 = obj7;
				break;
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj8 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = obj13;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D9D4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
	}

	public GillaPull()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6070]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, int> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 32;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaPull()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6080]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
