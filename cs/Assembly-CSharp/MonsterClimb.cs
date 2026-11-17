using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AI;

public class MonsterClimb : MonoBehaviour
{
	public Vector3 bottom;

	public Vector3 rim;

	public Vector3 top;

	public float width = 1.2f;

	private NavMeshLinkInstance link;

	public static readonly List<MonsterClimb> All;

	public Vector3 Into
	{
		get
		{
			//IL_0011: Expected Obj, but got VT
			//IL_002e: Expected Obj, but got I
			//IL_00e4: Expected VT, but got Obj
			//IL_00f9: Expected Obj, but got I
			//IL_0101: Expected VT, but got Obj
			//IL_0123: Expected Obj, but got I4
			object obj = rim - bottom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2 (MonsterClimb)+34]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2 (MonsterClimb)+28]");
			object obj2 = num - 0;
			object obj3 = obj * obj;
			object obj4 = obj2 * obj2;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			Vector3 result;
			if ((nint)obj5 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj6 = 0;
				result = (Vector3)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v1 (UnityEngine.Vector3)+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if ((nint)obj4 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				}
			}
			else
			{
				result = (Vector3)this;
			}
			return result;
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA20]");
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

	private unsafe void Start()
	{
		//IL_002b: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		NavMeshLinkData navMeshLinkData = default;
		navMeshLinkData.bidirectional = true;
		object obj = default;
		NavMeshLinkInstance navMeshLinkInstance = NavMesh.AddLink((NavMeshLinkData)(&obj));
		link = navMeshLinkInstance;
	}

	private unsafe void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected VT, but got Unknown
		//IL_004f: Expected Ref, but got VT
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected VT, but got Unknown
		//IL_0089: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA20]");
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
		NavMeshLinkInstance navMeshLinkInstance = (NavMeshLinkInstance)(this + 72);
		if (((NavMeshLinkInstance*)navMeshLinkInstance)->valid)
		{
			NavMeshLinkInstance navMeshLinkInstance2 = (NavMeshLinkInstance)(this + 72);
			((NavMeshLinkInstance*)navMeshLinkInstance2)->Remove();
		}
	}

	public unsafe static MonsterClimb Up(Vector3 at, Vector3 next, float near = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0544: Expected Obj, but got I4
		//IL_0682: Expected Obj, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got VT
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got I
		//IL_0092: Expected F4, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Ref, but got Unknown
		//IL_0627: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0124: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03f4: Expected I, but got Obj
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got I4
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got I
		//IL_05b6: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01ce: Invalid comparison between F4 and Obj
		//IL_01dc: Expected I, but got Obj
		//IL_01fa: Expected F4, but got I
		//IL_0219: Invalid comparison between I and F8
		//IL_0234: Expected I, but got Obj
		//IL_05ee: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02f2: Invalid comparison between F4 and I
		//IL_030b: Expected F8, but got I
		//IL_0310: Expected I, but got Obj
		//IL_032e: Expected F8, but got I
		//IL_0333: Expected I, but got Obj
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj7 = (UnityEngine.Object)next;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC98]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCC90]");
			object obj10 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj11 = 0;
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			float num = 0f;
			obj4 = (UnityEngine.Object)17276928;
			object obj20 = default;
			object obj23 = default;
			object obj25 = default;
			object obj27 = default;
			Enumerator<, > val2 = default;
			MonsterClimb result2 = default;
			object obj36 = default;
			nint num2;
			object obj32;
			float num4 = default;
			Enumerator<, > val3;
			while (true)
			{
				UnityEngine.Object result;
				object obj33;
				if (val.MoveNext())
				{
					object obj14 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 == null;
					bool flag5 = !flag4;
					object obj16 = !flag5;
					num2 = unchecked((nint)null);
					if (obj16 != null)
					{
						continue;
					}
					if ((object)obj6 == null)
					{
						break;
					}
					object obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v37+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v37+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+20]");
					float num3 = 0f - num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+28]");
					object obj19 = 0 - obj13;
					float num5 = num3 * num3;
					double num6 = (double)obj19 * (double)obj19;
					num = num5 + (float)num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
					num2 = unchecked((nint)null);
					if (flag7)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+24]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+24]");
					bool flag8 = !(0.0 < 1.0);
					num6 = 1.0;
					num2 = unchecked((nint)null);
					if (flag8)
					{
						continue;
					}
					object obj21 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v40+E4]");
					bool flag9 = (nint)0 == 0;
					object obj22 = !flag9;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+40]");
					obj12 = 0 - obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+38]");
					object obj24 = 0 - obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ stack_-A8 (UnityEngine.Object)+3C]");
					object obj26 = 0 - obj27;
					object obj28 = obj24 * obj24;
					object obj29 = obj26 * obj26;
					object obj30 = obj28 + obj29;
					object obj31 = obj12 * obj12;
					num = (float)obj30 + (float)obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num7 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					bool flag10 = !(num7 < 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					num6 = 0.0;
					num2 = unchecked((nint)null);
					if (flag10)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					num6 = 0.0;
					num2 = unchecked((nint)null);
					obj5 = null;
					val = val2;
					obj32 = 0;
					val3 = (Enumerator<, >)(ref val);
					result = obj6;
					obj33 = 0;
					goto IL_05fc;
				}
				obj5 = null;
				val = val2;
				obj32 = 0;
				val3 = (Enumerator<, >)(ref val);
				obj33 = 0;
				goto IL_0645;
				IL_05fc:
				obj7 = (UnityEngine.Object)obj10;
				((Enumerator<, >*)val3)->Dispose();
				bool flag11 = obj33 == null;
				object obj34 = !flag11;
				obj13 = obj12;
				num4 = num;
				if (obj34 == null)
				{
					bool flag12 = (object)obj5 == null;
					object obj35 = !flag12;
					obj13 = obj12;
					num4 = num;
					OutOfMemoryException ex = (OutOfMemoryException)val3;
					if (obj35 == null)
					{
						return (MonsterClimb)result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj7 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj13;
					obj5 = (UnityEngine.Object)1;
					num = num4;
					obj4 = (UnityEngine.Object)1;
					obj33 = obj32;
				}
				else
				{
					if ((nint)obj7 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FEEC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj33 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj13;
					obj32 = obj36;
					num = num4;
				}
				goto IL_0645;
				IL_0645:
				result = null;
				goto IL_05fc;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj13 = obj12;
			num2 = unchecked((nint)null);
			obj5 = null;
			val = val2;
			obj32 = 0;
			num4 = num;
			val3 = (Enumerator<, >)(ref val);
			obj7 = null;
		}
		throw new NullReferenceException();
	}

	private void OnDrawGizmosSelected()
	{
		//IL_000a: Expected VT, but got I4
		//IL_0018: Expected VT, but got I
		//IL_0018: Expected VT, but got I4
		//IL_002b: Expected VT, but got I
		//IL_002b: Expected VT, but got I4
		//IL_0039: Expected VT, but got I
		//IL_0039: Expected VT, but got I4
		//IL_004e: Expected F4, but got VT
		//IL_004e: Expected VT, but got I4
		//IL_005e: Expected F4, but got VT
		//IL_005e: Expected VT, but got I4
		Gizmos.color = (Color)0;
		IntPtr intPtr = default;
		Gizmos.DrawLine((Vector3)0, (Vector3)(nint)intPtr);
		Gizmos.DrawLine((Vector3)0, (Vector3)(nint)intPtr);
		Gizmos.DrawLine((Vector3)0, (Vector3)(nint)intPtr);
		Gizmos.DrawWireSphere((Vector3)0, (float)bottom);
		Gizmos.DrawWireSphere((Vector3)0, (float)top);
	}

	static MonsterClimb()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCA20]");
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
