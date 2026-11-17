using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AI;

public class MonsterNavMesh : MonoBehaviour
{
	[Serializable]
	public class Arm
	{
		public GoreSection section;

		public string upper;

		public string lower;

		public string hand;

		public Vector3 cut;

		public Vector3 way;

		public float radius;

		public float clear;

		public Mesh piece;

		public int[] slots;

		public Arm()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 88;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public NavMeshData data;

	private NavMeshDataInstance instance;

	private static int live;

	private static BoxCollider[] barriers;

	private const float Below = default(float);

	public static bool Ready
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_008d: Expected Obj, but got I4
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE78]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			bool flag = (nint)obj3 < 0;
			bool flag2 = obj3 == null;
			object obj4 = obj3 ^ obj3;
			object obj5 = obj3 & obj4;
			bool flag3 = (nint)obj5 < 0;
			bool flag4 = flag == flag3;
			object obj6 = !flag2;
			return (byte)((flag4 & obj6) ? 1 : 0) != 0;
		}
	}

	private unsafe void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_00b9: Expected VT, but got I4
		//IL_00b9: Expected VT, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected VT, but got Unknown
		//IL_00da: Expected I4, but got VT
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_00e3: Expected Ref, but got VT
		//IL_011c: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = data == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Transform transform2 = base.transform;
			Quaternion rotation = transform2.rotation;
			NavMeshDataInstance navMeshDataInstance = NavMesh.AddNavMeshData(data, (Vector3)0, (Quaternion)0);
			NavMeshDataInstance navMeshDataInstance2 = (NavMeshDataInstance)(this + 40);
			((NavMeshDataInstance*)(nint)navMeshDataInstance2)->id__BackingField = (int)navMeshDataInstance;
			if (((NavMeshDataInstance*)navMeshDataInstance2)->valid)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v6+A0]");
				object obj9 = 0;
				object obj10 = obj9 + 1;
				obj9 = obj10;
			}
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_0070: Expected Ref, but got VT
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected VT, but got Unknown
		//IL_0020: Expected Obj, but got I
		//IL_0029: Expected Ref, but got VT
		//IL_0041: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		NavMeshDataInstance navMeshDataInstance = (NavMeshDataInstance)(this + 40);
		if (((NavMeshDataInstance*)navMeshDataInstance)->valid)
		{
			NavMeshDataInstance navMeshDataInstance2 = (NavMeshDataInstance)(this + 40);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE78]");
			object obj = 0;
			((NavMeshDataInstance*)navMeshDataInstance2)->Remove();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+A0]");
			object obj3 = 0;
			object obj4 = obj3 - 1;
			obj3 = obj4;
		}
	}

	public static bool Barred(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0746: Expected Obj, but got I
		//IL_0756: Expected Obj, but got I
		//IL_0766: Expected Obj, but got I
		//IL_0788: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected I4, but got Unknown
		//IL_003f: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I8
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0877: Expected Obj, but got I4
		//IL_07a6: Expected Obj, but got I
		//IL_07b6: Expected Obj, but got I
		//IL_07d8: Expected Obj, but got I4
		//IL_072e: Expected I4, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I4
		//IL_0381: Expected I, but got Obj
		//IL_07f6: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I
		//IL_0821: Expected I, but got Obj
		//IL_083f: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_06c2: Expected Obj, but got I4
		//IL_06f1: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_03f4: Expected VT, but got I4
		//IL_0409: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0476: Invalid comparison between F8 and I4
		//IL_0487: Expected Obj, but got I4
		//IL_04a9: Expected I, but got Obj
		//IL_04f3: Expected Obj, but got I4
		//IL_050b: Invalid comparison between F8 and I4
		//IL_051c: Expected Obj, but got I4
		//IL_0536: Expected I, but got Obj
		//IL_0580: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I4
		//IL_05dd: Invalid comparison between F8 and I4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0613: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE78]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+8]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE98]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD840");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCEA8]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v18+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v7+8]");
			Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v7+8]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v18+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v35+A0]");
					obj13 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE90]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCEA0]");
				object obj18 = 0;
				Func<System.__Canon, bool> func = default;
				func._002Ector(obj13, (IntPtr)obj18);
				object obj19 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v34+A0]");
				object obj20 = (nint)0 + (nint)8;
				obj20 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				predicate = func;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE88]");
			object obj21 = 0;
			object obj22 = obj21;
			IEnumerable<System.__Canon> source2 = default;
			IEnumerable<System.__Canon> source = Enumerable.Where(source2, predicate);
			System.__Canon[] array = Enumerable.ToArray(source);
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v24+A0]");
			object obj24 = (nint)0 + (nint)8;
			obj24 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v27+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v28+8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v28+8]");
			bool flag6 = (nint)0 == 0;
			nint num = (nint)array;
			if (flag6)
			{
				goto IL_0712;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		bool flag7 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		bool flag8 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		object obj27 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		object obj28 = 0 & obj27;
		bool flag9 = (nint)obj28 < 0;
		bool flag10 = flag7 == flag9;
		object obj29 = !flag8;
		object obj30 = flag10 & obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		bool flag11 = (nint)0 < (nint)1;
		object obj31 = obj30;
		if (flag11)
		{
			goto IL_06ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
		object obj32 = 0 & 0xFFFFFFFFL;
		object obj33 = obj4 + 32;
		object obj35 = default;
		object obj34 = obj35;
		double num4 = default;
		double num3 = num4;
		double num6 = default;
		double num5 = num6;
		object obj36 = obj30;
		object obj37 = 0;
		double num7 = default;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
			object obj38 = !flag12;
			if (obj38 != null)
			{
				break;
			}
			object obj39 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v10+E4]");
			bool flag13 = (nint)0 == 0;
			object obj40 = !flag13;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X24_v6+v221 @ X23_v8*8]");
			bool flag14 = (UnityEngine.Object)0 == null;
			bool flag15 = !flag14;
			object obj41 = !flag15;
			nint num = unchecked((nint)null);
			if (obj41 != null)
			{
				goto IL_0629;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X24_v6+v221 @ X23_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X24_v6+v221 @ X23_v8*8]");
				Transform transform = ((Component)0).transform;
				if ((object)transform != null)
				{
					Vector3 vector = transform.InverseTransformPoint((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X24_v6+v221 @ X23_v8*8]");
					Vector3 center = ((BoxCollider)0).center;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X24_v6+v221 @ X23_v8*8]");
					Vector3 size = ((BoxCollider)0).size;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					num5 = num6 * 0.5;
					bool flag16 = num7 < num5;
					object obj42 = !flag16;
					double num8 = num7 - num5;
					bool flag17 = num8 == 0.0;
					object obj43 = !flag17;
					object obj44 = obj42 & obj43;
					obj34 = obj35;
					num3 = num4;
					num = unchecked((nint)null);
					if (obj44 == null)
					{
						num3 = num4 * 0.5;
						num5 = num4 - num4;
						bool flag18 = num5 < num3;
						object obj45 = !flag18;
						double num9 = num5 - num3;
						bool flag19 = num9 == 0.0;
						object obj46 = !flag19;
						object obj47 = obj45 & obj46;
						obj34 = obj35;
						num = unchecked((nint)null);
						if (obj47 == null)
						{
							num3 = -1.5 - num3;
							bool flag20 = num5 < num3;
							num7 = -1.5;
							obj34 = obj35;
							num = unchecked((nint)null);
							if (!flag20)
							{
								num5 = (double)obj35 * 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag21 = num3 < num5;
								object obj48 = !flag21;
								double num10 = num3 - num5;
								bool flag22 = num10 == 0.0;
								object obj49 = ~obj48;
								object obj50 = obj49 | flag22;
								num7 = -1.5;
								obj34 = obj35;
								num = unchecked((nint)null);
								obj31 = obj36;
								if (obj50 != null)
								{
									goto IL_06ff;
								}
							}
						}
					}
					goto IL_0629;
				}
			}
			goto IL_0712;
			IL_0629:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
			obj32 = 0;
			obj37++;
			object obj51 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
			object obj52 = obj51 - 0;
			bool flag23 = (nint)obj52 < 0;
			object obj53 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
			object obj54 = obj53 ^ 0;
			object obj55 = obj37 ^ obj52;
			object obj56 = obj54 & obj55;
			bool flag24 = (nint)obj56 < 0;
			bool flag25 = flag23 == flag24;
			object obj57 = !flag25;
			object obj58 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X20_v4+18]");
			bool flag26 = (nint)obj58 < 0;
			obj31 = obj57;
			obj36 = obj57;
			object obj22 = 0;
			if (flag26)
			{
				continue;
			}
			goto IL_06ff;
		}
		goto IL_0720;
		IL_0720:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_06ff:
		return (byte)(obj31 & 1) != 0;
		IL_0712:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0720;
	}
}
