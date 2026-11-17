using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaLimp : MonoBehaviour
{
	private const float EaseBack = default(float);

	private const float NoWordAfter = default(float);

	private NetworkApe who;

	private ApeAvatarDriver driver;

	private GillaCorpse limp;

	private Transform[] real;

	private Transform[] copied;

	private Vector3[] startedAt;

	private Vector3[] posedAt;

	private Vector3[] drawnAt;

	private Vector3[] easedAt;

	private Quaternion[] startedTurned;

	private Quaternion[] posedTurned;

	private Quaternion[] drawnTurned;

	private Quaternion[] easedTurned;

	private bool heard;

	private bool pushed;

	private Vector3 way;

	private float since;

	private float easing;

	public bool IsDown
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I4
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
			return limp != null;
		}
	}

	public Vector3 Eyes
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_00cb: Expected VT, but got Obj
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
			if (limp != null)
			{
				if ((object)limp != null)
				{
					return limp.HeadNow;
				}
			}
			else
			{
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public Vector3 Middle
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_00cb: Expected VT, but got Obj
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
			if (limp != null)
			{
				if ((object)limp != null)
				{
					return limp.MiddleNow;
				}
			}
			else
			{
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public Vector3 Front
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_00d4: Expected VT, but got I4
			//IL_0097: Expected VT, but got Obj
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
			bool flag2 = limp != null;
			if (flag2)
			{
				if ((object)limp != null)
				{
					return limp.FrontNow;
				}
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
			return (Vector3)flag2;
		}
	}

	public Vector3 Going
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_00d4: Expected VT, but got I4
			//IL_0097: Expected VT, but got Obj
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
			bool flag2 = limp != null;
			if (flag2)
			{
				if ((object)limp != null)
				{
					return limp.GoingNow;
				}
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
			return (Vector3)flag2;
		}
	}

	public Vector3 Way
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
	}

	public Vector3 Hand(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_00cf: Expected VT, but got Obj
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
		if (limp != null)
		{
			if ((object)limp != null)
			{
				return limp.HandNow(right);
			}
		}
		else
		{
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				return transform.position;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA460]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
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
		if (limp != null)
		{
			GameObject obj4 = limp.gameObject;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj4);
		}
	}

	public unsafe void Begin(Vector3 going)
	{
		//IL_159c: Expected Obj, but got I
		//IL_15b4: Expected Obj, but got I
		//IL_12d0: Expected Obj, but got I
		//IL_12ed: Expected Obj, but got I
		//IL_12fd: Expected Obj, but got I
		//IL_132f: Expected Obj, but got I
		//IL_133f: Expected Obj, but got I
		//IL_1356: Expected F8, but got Obj
		//IL_1366: Expected Obj, but got I
		//IL_136e: Invalid comparison between F8 and Obj
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Expected Obj, but got Unknown
		//IL_13ba: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_020b: Expected VT, but got I4
		//IL_033b: Expected VT, but got I4
		//IL_01cc: Expected F8, but got I
		//IL_01dc: Invalid comparison between F8 and I
		//IL_0268: Expected VT, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_13e0: Expected VT, but got I4
		//IL_03c2: Expected Obj, but got I4
		//IL_1646: Expected Obj, but got I
		//IL_1670: Expected Obj, but got I4
		//IL_027b: Expected VT, but got I4
		//IL_0d68: Invalid comparison between F8 and I
		//IL_03f4: Expected VT, but got I4
		//IL_0dc9: Expected Obj, but got I
		//IL_0dd1: Expected F8, but got Obj
		//IL_0de1: Expected F8, but got I
		//IL_0df1: Expected F8, but got I
		//IL_1532: Expected VT, but got F8
		//IL_1556: Expected VT, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0e06: Expected VT, but got I4
		//IL_0e1e: Expected VT, but got I4
		//IL_04ad: Expected VT, but got I4
		//IL_0e57: Expected VT, but got I4
		//IL_04dd: Expected VT, but got I4
		//IL_052a: Invalid comparison between F4 and I4
		//IL_145e: Invalid comparison between F8 and I4
		//IL_1474: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected Obj, but got Unknown
		//IL_1486: Expected Obj, but got F8
		//IL_14ca: Invalid comparison between F8 and I
		//IL_15d7: Expected VT, but got F8
		//IL_1603: Expected VT, but got I4
		//IL_1628: Expected F8, but got I
		//IL_057b: Expected VT, but got I4
		//IL_0598: Expected F8, but got I
		//IL_065e: Expected Obj, but got I
		//IL_0688: Expected Obj, but got I4
		//IL_06c5: Expected VT, but got I4
		//IL_05c3: Expected VT, but got I4
		//IL_05e0: Expected F8, but got I
		//IL_070f: Expected F8, but got I
		//IL_0718: Expected VT, but got I4
		//IL_077d: Expected F8, but got I
		//IL_0786: Expected VT, but got I4
		//IL_0639: Expected F8, but got I
		//IL_07ce: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected Obj, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_084a: Expected Obj, but got I
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected Obj, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected Obj, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_09cc: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I4
		//IL_0fdf: Expected Obj, but got I
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_1014: Expected Obj, but got I4
		//IL_1057: Expected VT, but got I4
		//IL_11bc: Expected Obj, but got I4
		//IL_108d: Expected F8, but got Ref
		//IL_10a5: Expected F8, but got I
		//IL_10ae: Expected VT, but got I4
		//IL_10bb: Expected F8, but got Ref
		//IL_0a21: Invalid comparison between F8 and I4
		//IL_0aa5: Expected Obj, but got I4
		//IL_121b: Expected F8, but got Ref
		//IL_1233: Expected F8, but got I
		//IL_123c: Expected VT, but got I4
		//IL_1249: Expected F8, but got Ref
		//IL_10fd: Expected F8, but got Ref
		//IL_1115: Expected F8, but got I
		//IL_111e: Expected VT, but got I4
		//IL_112b: Expected F8, but got Ref
		//IL_0a4d: Expected Obj, but got I
		//IL_0a76: Expected Obj, but got I
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected Obj, but got Unknown
		//IL_0ad6: Expected Obj, but got F8
		//IL_0aff: Expected Obj, but got F8
		//IL_1161: Expected Obj, but got I
		//IL_1169: Expected VT, but got Obj
		//IL_0b24: Expected Obj, but got F8
		//IL_0ba2: Expected Obj, but got I4
		//IL_0f54: Expected F8, but got Ref
		//IL_0f6c: Expected F8, but got I
		//IL_0f75: Expected VT, but got I4
		//IL_0f82: Expected F8, but got Ref
		//IL_0b4a: Expected Obj, but got I
		//IL_0b73: Expected Obj, but got I
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected Obj, but got Unknown
		//IL_0bee: Invalid comparison between F8 and I4
		//IL_0c1b: Expected Obj, but got F8
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0cab: Expected Obj, but got F8
		//IL_0cf2: Expected Obj, but got I4
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+18]");
		object obj4 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+1C]");
		object obj5 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+20]");
		object obj9 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+A0]");
		object obj10 = 0;
		double num4 = (double)obj9 + (double)obj8;
		double num5 = (double)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		double num7 = default;
		double num8;
		double num9;
		double num10 = default;
		double num11;
		double num12 = default;
		double num6;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
		{
			num6 = num7;
			num8 = num7;
			num9 = num10;
			num11 = num12;
		}
		else
		{
			double num13 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+18]");
			double num14 = num13 * 0.0;
			double num15 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+1C]");
			double num16 = num15 * 0.0;
			double num17 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+20]");
			double num18 = num17 * 0.0;
			double num19 = num14 + num16;
			double num20 = num18 + num19;
			double num21 = num20 / num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+18]");
			num5 = 0.0 * num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+1C]");
			num6 = 0.0 * num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+20]");
			num4 = 0.0 * num21;
			num11 = num12 - num5;
			num9 = num10 - num6;
			num8 = num7 - num4;
		}
		object obj12 = obj11;
		object obj13 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num31;
		double num35;
		Vector3 vector;
		UnityEngine.Object obj21;
		if ((UnityEngine.Object)obj13 != null)
		{
			bool flag2 = (byte)(~(pushed ? 1u : 0u)) != 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				double num22 = num11 * num11;
				double num23 = num9 * num9;
				double num24 = num22 + num23;
				num5 = num8 * num8;
				double num25 = num24 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num4 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				if (!(num25 < 0.0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v180+E4]");
					bool flag3 = (nint)0 == 0;
					object obj18 = !flag3;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num26 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if (num26 > 0.0)
					{
						num4 = num11 / num6;
						num5 = num9 / num6;
						num6 = num8 / num6;
					}
					else
					{
						object obj19 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v83+A0]");
						object obj20 = 0;
						num4 = (double)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v84+4]");
						num5 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v84+8]");
						num6 = 0.0;
					}
					way = (Vector3)num4;
					bool flag4 = (object)limp == null;
					vector = (Vector3)0;
					obj21 = null;
					if (!flag4)
					{
						limp.Shove((Vector3)0);
						bool flag5 = obj13 == null;
						vector = (Vector3)0;
						obj21 = null;
						num4 = num12;
						num6 = num7;
						num5 = num10;
						if (!flag5)
						{
							((GillaCorpse)obj13).FallsFlat((Vector3)0);
							pushed = true;
							goto IL_0280;
						}
					}
					goto IL_1292;
				}
			}
			bool flag6 = obj13 == null;
			vector = (Vector3)0;
			obj21 = null;
			if (!flag6)
			{
				num6 = num7 * 0.5;
				num5 = num10 * 0.5;
				num4 = num12 * 0.5;
				((GillaCorpse)obj13).Shove((Vector3)0);
				bool flag7 = obj13 == null;
				vector = (Vector3)0;
				obj21 = null;
				if (!flag7)
				{
					((GillaCorpse)obj13).FallsFlat((Vector3)0);
					goto IL_0280;
				}
			}
		}
		else
		{
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = (UnityEngine.Object)who == (UnityEngine.Object)null;
			bool flag10 = !flag9;
			object obj24 = !flag10;
			if (obj24 != null)
			{
				return;
			}
			NetworkApe networkApe = who;
			bool flag11 = (object)who == null;
			vector = (Vector3)0;
			obj21 = null;
			if (!flag11)
			{
				object obj25 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v21+E4]");
				bool flag12 = (nint)0 == 0;
				object obj26 = !flag12;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = networkApe.tearing == null;
				bool flag14 = !flag13;
				object obj27 = !flag14;
				if (obj27 != null)
				{
					return;
				}
				NetworkApe networkApe2 = who;
				bool flag15 = (object)who == null;
				vector = (Vector3)0;
				obj21 = null;
				if (!flag15)
				{
					object obj28 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v25+E4]");
					bool flag16 = (nint)0 == 0;
					object obj29 = !flag16;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag17 = networkApe2.ape == null;
					bool flag18 = !flag17;
					object obj30 = !flag18;
					if (obj30 != null)
					{
						return;
					}
					NetworkApe networkApe3 = who;
					bool flag19 = (object)who == null;
					vector = (Vector3)0;
					obj21 = null;
					if (!flag19)
					{
						bool flag20 = (object)networkApe3.ape == null;
						vector = (Vector3)0;
						obj21 = null;
						if (!flag20)
						{
							if (!networkApe3.ape.activeInHierarchy)
							{
								return;
							}
							if (easing > 0f)
							{
								PutBackPosed();
								easing = 0f;
							}
							double num27 = num11 * num11;
							double num28 = num9 * num9;
							double num29 = num27 + num28;
							double num30 = num8 * num8;
							num31 = num29 + num30;
							double num32 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							double num33 = num32 - 0.0;
							bool flag21 = num33 < 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							object obj31 = num31 ^ 0;
							object obj32 = num31 ^ num33;
							object obj33 = obj31 & obj32;
							bool flag22 = (nint)obj33 < 0;
							bool flag23 = flag21 == flag22;
							pushed = flag23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							bool flag24 = !(num31 < 0.0);
							double num34 = num11;
							num35 = num6;
							if (flag24)
							{
								goto IL_15b9;
							}
							NetworkApe networkApe4 = who;
							bool flag25 = (object)who == null;
							vector = (Vector3)0;
							obj21 = null;
							num4 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							num5 = 0.0;
							if (!flag25)
							{
								bool flag26 = (object)networkApe4.head == null;
								vector = (Vector3)0;
								obj21 = null;
								num4 = num31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
								num5 = 0.0;
								if (!flag26)
								{
									Vector3 forward = networkApe4.head.forward;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
									num34 = num31;
									double num36 = num6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
									double num37 = 0.0;
									double num18 = num31;
									num35 = num6;
									goto IL_15b9;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1292;
		IL_1292:
		NullReferenceException ex = new NullReferenceException();
		NullReferenceException ex2 = ex;
		goto IL_1569;
		IL_15b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
		NetworkApe networkApe5 = who;
		way = (Vector3)num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		_ = 0;
		bool flag27 = (object)who == null;
		vector = (Vector3)0;
		obj21 = null;
		num4 = num31;
		num6 = num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		num5 = 0.0;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = default;
		double num38 = default;
		object obj88;
		object obj89;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v35+E4]");
			bool flag28 = (nint)0 == 0;
			object obj36 = !flag28;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector2 = default;
			GillaCorpse gillaCorpse = GillaCorpse.Limp(networkApe5.tearing, networkApe5.owner, (Vector3)0, vector2);
			obj13 = gillaCorpse;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj37 = obj13;
			bool flag29 = obj13 == null;
			double num36 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			double num37 = 0.0;
			vector = (Vector3)0;
			obj21 = gillaCorpse;
			num4 = num12;
			double num18 = num31;
			num6 = num7;
			num5 = num10;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v24+B0]");
				bool flag30 = (nint)0 == 0;
				num36 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num37 = 0.0;
				vector = (Vector3)0;
				obj21 = gillaCorpse;
				num4 = num12;
				num18 = num31;
				num6 = num7;
				num5 = num10;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v24+B0]");
					int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj39 = this + 56;
					object obj40 = default;
					obj39 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj41 = this + 64;
					object obj42 = default;
					obj41 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj44 = this + 72;
					object obj45 = default;
					obj44 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj46 = this + 80;
					object obj47 = default;
					obj46 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj48 = this + 88;
					object obj49 = default;
					obj48 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj50 = this + 96;
					object obj51 = default;
					obj50 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
					object obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj53 = this + 104;
					object obj54 = default;
					obj53 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj55 = this + 112;
					object obj56 = default;
					obj55 = obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj57 = this + 120;
					object obj58 = default;
					obj57 = obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj59 = this + 128;
					object obj60 = default;
					obj59 = obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v24+B0]");
					Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = ((Dictionary<System.__Canon, System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B88]");
					object obj61 = 0;
					object obj62 = 0;
					UnityEngine.Object obj72 = default;
					ArgumentNullException ex3 = default;
					NullReferenceException ex4 = default;
					double num39;
					while (true)
					{
						UnityEngine.Object obj63 = (UnityEngine.Object)obj61;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						object obj64 = obj39;
						if (obj39 == null)
						{
							goto IL_0eb2;
						}
						UnityEngine.Object obj66;
						if (num38 != 0.0)
						{
							object obj65 = obj64;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v62+40]");
							obj63 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag31 = ex3 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v62+40]");
							obj66 = (UnityEngine.Object)0;
							if (flag31)
							{
								goto IL_0f07;
							}
						}
						object obj67 = obj62;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X29_v7+18]");
						bool flag32 = (nint)obj67 < 0;
						object obj68 = !flag32;
						if (obj68 != null)
						{
							goto IL_0ea4;
						}
						object obj69 = obj39 + obj62;
						object obj70 = obj69 + 32;
						obj70 = num38;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj71 = obj41;
						bool flag33 = obj41 == null;
						obj63 = (UnityEngine.Object)num38;
						if (flag33)
						{
							goto IL_0ece;
						}
						bool flag34 = (object)obj72 == null;
						UnityEngine.Object obj73 = (UnityEngine.Object)num38;
						if (!flag34)
						{
							object obj74 = obj71;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v61+40]");
							obj73 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag35 = ex4 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v61+40]");
							obj63 = (UnityEngine.Object)0;
							if (flag35)
							{
								goto IL_0eea;
							}
						}
						object obj75 = obj62;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X29_v15+18]");
						bool flag36 = (nint)obj75 < 0;
						object obj76 = !flag36;
						obj63 = obj73;
						if (obj76 != null)
						{
							goto IL_0ec0;
						}
						object obj77 = obj41 + obj62;
						object obj78 = obj77 + 32;
						obj78 = obj72;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag37 = num38 == 0.0;
						obj63 = obj72;
						if (!flag37)
						{
							object obj79 = obj44;
							Vector3 localPosition = ((Transform)num38).localPosition;
							if (obj44 != null)
							{
								object obj80 = obj62;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X25_v16+18]");
								bool flag38 = (nint)obj80 < 0;
								object obj81 = !flag38;
								obj63 = null;
								if (obj81 != null)
								{
									goto IL_0e96;
								}
								object obj82 = obj62 * 12;
								object obj83 = obj44 + obj82;
								object obj84 = obj53;
								Quaternion localRotation = ((Transform)num38).localRotation;
								bool flag39 = obj53 == null;
								obj63 = null;
								if (!flag39)
								{
									object obj85 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X25_v20+18]");
									bool flag40 = (nint)obj85 < 0;
									object obj86 = !flag40;
									obj63 = null;
									if (obj86 == null)
									{
										object obj87 = obj53 + obj62;
										obj62++;
										continue;
									}
									goto IL_0e88;
								}
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								obj63 = null;
							}
							NullReferenceException ex6 = new NullReferenceException();
							goto IL_0e88;
						}
						goto IL_0edc;
						IL_0ea4:
						IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
						goto IL_0eb2;
						IL_0ec0:
						IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
						goto IL_0ece;
						IL_0eea:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						ex3 = new ArgumentNullException();
						obj66 = null;
						goto IL_0f07;
						IL_0edc:
						ex4 = new NullReferenceException();
						goto IL_0eea;
						IL_0f07:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						ArgumentNullException ex9 = new ArgumentNullException();
						num39 = (nint)(&enumerator2);
						num36 = num35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
						num37 = 0.0;
						vector = (Vector3)0;
						obj21 = null;
						num4 = (nint)(&enumerator2);
						num18 = num31;
						num6 = num7;
						num5 = num38;
						ex2 = (NullReferenceException)(object)ex9;
						goto IL_1569;
						IL_0ece:
						NullReferenceException ex10 = new NullReferenceException();
						goto IL_0edc;
						IL_0e88:
						IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
						goto IL_0e96;
						IL_0eb2:
						NullReferenceException ex12 = new NullReferenceException();
						goto IL_0ec0;
						IL_0e96:
						IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
						goto IL_0ea4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1100");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					obj88 = 0;
					obj89 = this + 40;
					object obj90 = obj88;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X0_v97+E4]");
					bool flag41 = (nint)0 == 0;
					object obj91 = !flag41;
					if (obj91 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag42 = (UnityEngine.Object)obj89 == null;
					bool flag43 = !flag42;
					Vector3 vector3 = (Vector3)0;
					UnityEngine.Object obj92 = null;
					if (flag43)
					{
						goto IL_1192;
					}
					NetworkApe networkApe6 = who;
					bool flag44 = (object)who == null;
					num39 = (nint)(&enumerator2);
					num36 = num35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					num37 = 0.0;
					vector = (Vector3)0;
					obj21 = null;
					num4 = (nint)(&enumerator2);
					num18 = num31;
					num6 = num7;
					num5 = num38;
					if (!flag44)
					{
						bool flag45 = (object)networkApe6.ape == null;
						num39 = (nint)(&enumerator2);
						num36 = num35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
						num37 = 0.0;
						vector = (Vector3)0;
						obj21 = null;
						num4 = (nint)(&enumerator2);
						num18 = num31;
						num6 = num7;
						num5 = num38;
						if (!flag45)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD620]");
							object obj93 = 0;
							vector3 = (Vector3)obj93;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626234");
							UnityEngine.Object obj94 = default;
							obj89 = obj94;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj92 = obj94;
							goto IL_1192;
						}
					}
				}
			}
		}
		goto IL_1292;
		IL_0280:
		float time = Time.time;
		since = time;
		return;
		IL_1192:
		object obj95 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X0_v102+E4]");
		bool flag46 = (nint)0 == 0;
		object obj96 = !flag46;
		if (obj96 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj89 != null)
		{
			bool flag47 = obj89 == null;
			double num39 = (nint)(&enumerator2);
			double num36 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			double num37 = 0.0;
			vector = (Vector3)0;
			obj21 = null;
			num4 = (nint)(&enumerator2);
			double num18 = num31;
			num6 = num7;
			num5 = num38;
			if (flag47)
			{
				goto IL_1292;
			}
			((Behaviour)obj89).enabled = false;
		}
		heard = false;
		goto IL_0280;
		IL_1569:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1100");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public void End(bool ease)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a45: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_007e: Expected VT, but got I4
		//IL_0087: Expected VT, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Expected VT, but got I4
		//IL_0a5e: Expected Obj, but got I4
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_0a97: Expected Obj, but got I4
		//IL_0ab2: Expected Obj, but got I4
		//IL_0b2d: Expected VT, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I4
		//IL_08b6: Expected VT, but got I4
		//IL_08bf: Expected VT, but got I4
		//IL_046b: Expected Obj, but got I4
		//IL_011e: Expected VT, but got I4
		//IL_08e7: Expected VT, but got I4
		//IL_08f0: Expected VT, but got I4
		//IL_04fc: Expected VT, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_017d: Expected VT, but got I4
		//IL_0186: Expected VT, but got I4
		//IL_0979: Expected Obj, but got I4
		//IL_0917: Expected VT, but got I4
		//IL_0920: Expected VT, but got I4
		//IL_052d: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_09cf: Expected Obj, but got I4
		//IL_0a04: Expected F4, but got I4
		//IL_05b6: Expected VT, but got I4
		//IL_0216: Expected VT, but got I4
		//IL_021f: Expected VT, but got I4
		//IL_09f6: Expected F4, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_0685: Expected VT, but got I4
		//IL_0297: Expected VT, but got I4
		//IL_02a0: Expected VT, but got I4
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06ca: Expected Obj, but got I
		//IL_06da: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I
		//IL_06fa: Expected Obj, but got I
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_0720: Expected Obj, but got I
		//IL_0730: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I4
		//IL_075a: Expected VT, but got I4
		//IL_075a: Expected VT, but got I4
		//IL_075a: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I4
		//IL_0789: Expected VT, but got I4
		//IL_0792: Expected VT, but got I4
		//IL_07a2: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_07ca: Expected Obj, but got I
		//IL_07da: Expected Obj, but got I
		//IL_07ea: Expected Obj, but got I
		//IL_07fa: Expected Obj, but got I
		//IL_082e: Expected VT, but got I4
		//IL_02c9: Expected Obj, but got I
		//IL_02f7: Expected VT, but got I4
		//IL_0300: Expected VT, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_03c2: Expected Obj, but got I4
		//IL_03cb: Expected VT, but got I4
		//IL_03e2: Expected VT, but got I4
		//IL_03eb: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		Transform[] array = real;
		bool flag4 = real == null;
		Quaternion quaternion = (Quaternion)0;
		Vector3 vector = (Vector3)0;
		if (!flag4)
		{
			object obj6 = 44;
			object obj7 = 4;
			object obj8 = 0;
			Vector3 vector2 = (Vector3)0;
			Quaternion[] array6 = default;
			object obj31 = default;
			object obj29 = default;
			object obj27 = default;
			object obj25 = default;
			object obj23 = default;
			object obj21 = default;
			object obj15 = default;
			object obj18 = default;
			while (true)
			{
				object obj9 = array.Length;
				Quaternion[] array2 = (Quaternion[])(obj7 - 4);
				if ((nint)array2 < array.Length)
				{
					bool flag5 = (nint)array2 < array.Length;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13 (UnityEngine.Transform[])+v295 @ X24_v8*8]");
						bool flag6 = (nint)0 == 0;
						object obj11 = obj6;
						object obj12 = obj7;
						quaternion = (Quaternion)0;
						vector = vector2;
						if (flag6)
						{
							break;
						}
						Vector3[] array3 = drawnAt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13 (UnityEngine.Transform[])+v295 @ X24_v8*8]");
						Vector3 position = ((Transform)0).position;
						bool flag7 = drawnAt == null;
						obj11 = obj6;
						obj12 = obj7;
						quaternion = (Quaternion)0;
						vector = (Vector3)0;
						if (flag7)
						{
							break;
						}
						bool flag8 = (nint)array2 < array3.Length;
						obj10 = !flag8;
						if (obj10 == null)
						{
							object obj13 = (object)drawnAt + obj8;
							Transform[] array4 = real;
							bool flag9 = real == null;
							obj11 = obj6;
							obj12 = obj7;
							quaternion = (Quaternion)0;
							vector = (Vector3)0;
							if (flag9)
							{
								break;
							}
							obj9 = array4.Length;
							bool flag10 = (nint)array2 < array4.Length;
							obj10 = !flag10;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v19 (UnityEngine.Transform[])+v295 @ X24_v8*8]");
								bool flag11 = (nint)0 == 0;
								obj11 = obj6;
								obj12 = obj7;
								quaternion = (Quaternion)0;
								vector = (Vector3)0;
								if (flag11)
								{
									break;
								}
								array2 = drawnTurned;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v19 (UnityEngine.Transform[])+v295 @ X24_v8*8]");
								Quaternion rotation = ((Transform)0).rotation;
								bool flag12 = drawnTurned == null;
								obj11 = obj6;
								obj12 = obj7;
								quaternion = (Quaternion)0;
								vector = (Vector3)0;
								if (flag12)
								{
									break;
								}
								obj7++;
								obj9 = obj7 - 5;
								bool flag13 = (nint)obj9 < array2.Length;
								obj10 = !flag13;
								if (obj10 == null)
								{
									object obj14 = (object)drawnTurned + obj6;
									obj6 += 16;
									obj8 += 12;
									obj14 = obj15;
									array = real;
									bool flag14 = real == null;
									object obj16 = !flag14;
									vector2 = (Vector3)0;
									if (obj16 == null)
									{
										quaternion = (Quaternion)0;
										vector = (Vector3)0;
										break;
									}
									continue;
								}
							}
						}
					}
				}
				else
				{
					object obj17 = obj18;
					object obj19 = obj15;
					object obj20 = obj21;
					object obj22 = obj23;
					object obj24 = obj25;
					object obj26 = obj27;
					object obj28 = obj29;
					object obj30 = obj31;
					Quaternion[] array5 = array6;
					object obj32 = 0;
					object obj33 = 0;
					while (true)
					{
						Vector3[] array7 = (Vector3[])array.Length;
						bool flag15 = (nint)obj32 < array.Length;
						object obj10 = !flag15;
						bool flag16 = (nint)obj32 >= array.Length;
						obj18 = obj17;
						obj15 = obj19;
						obj21 = obj20;
						obj23 = obj22;
						obj25 = obj24;
						obj27 = obj26;
						obj29 = obj28;
						obj31 = obj30;
						array6 = array5;
						object obj11 = obj6;
						object obj12 = obj7;
						quaternion = (Quaternion)0;
						vector = vector2;
						if (!flag16)
						{
							bool flag17 = (nint)obj32 < array.Length;
							obj10 = !flag17;
							if (obj10 != null)
							{
								break;
							}
							array7 = startedAt;
							bool flag18 = startedAt == null;
							obj18 = obj17;
							obj15 = obj19;
							obj21 = obj20;
							obj23 = obj22;
							obj25 = obj24;
							obj27 = obj26;
							obj29 = obj28;
							obj31 = obj30;
							array6 = array5;
							obj11 = obj6;
							obj12 = obj7;
							quaternion = (Quaternion)0;
							vector = vector2;
							if (flag18)
							{
								goto end_IL_0a54;
							}
							bool flag19 = (nint)obj32 < array7.Length;
							obj10 = !flag19;
							if (obj10 != null)
							{
								break;
							}
							array6 = startedTurned;
							bool flag20 = startedTurned == null;
							obj18 = obj17;
							obj15 = obj19;
							obj21 = obj20;
							obj23 = obj22;
							obj25 = obj24;
							obj27 = obj26;
							obj29 = obj28;
							obj31 = obj30;
							obj11 = obj6;
							obj12 = obj7;
							quaternion = (Quaternion)0;
							vector = vector2;
							if (flag20)
							{
								goto end_IL_0a54;
							}
							obj12 = obj32 + 1;
							obj31 = obj12 - 1;
							bool flag21 = (nint)obj31 < array6.Length;
							obj10 = !flag21;
							if (obj10 != null)
							{
								break;
							}
							object obj34 = (object)array + obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v14+20]");
							bool flag22 = (nint)0 == 0;
							obj18 = obj17;
							obj15 = obj19;
							obj21 = obj20;
							obj23 = obj22;
							obj25 = obj24;
							obj27 = obj26;
							obj29 = obj28;
							obj11 = obj6;
							quaternion = (Quaternion)0;
							vector = vector2;
							if (flag22)
							{
								goto end_IL_0a54;
							}
							object obj35 = (object)startedAt + obj33;
							object obj36 = startedTurned + 44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+20]");
							obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+24]");
							obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+28]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-4]");
							obj23 = 0;
							obj21 = obj36;
							obj33 += 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-C]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-8]");
							obj18 = 0;
							obj11 = 44 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v14+20]");
							((Transform)0).SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
							array = real;
							bool flag23 = real == null;
							object obj37 = !flag23;
							quaternion = (Quaternion)0;
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-8]");
							obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-C]");
							obj19 = 0;
							obj20 = obj36;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X10_v7-4]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+28]");
							obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+24]");
							obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+20]");
							obj28 = 0;
							obj30 = obj31;
							array5 = startedTurned;
							obj32 = obj12;
							obj6 = obj11;
							obj7 = obj12;
							vector2 = (Vector3)0;
							if (obj37 == null)
							{
								goto end_IL_0a54;
							}
							continue;
						}
						object obj38 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v8+E4]");
						bool flag24 = (nint)0 == 0;
						object obj39 = !flag24;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = driver != null;
						bool flag26 = !flag25;
						quaternion = (Quaternion)0;
						vector = (Vector3)0;
						if (!flag26)
						{
							bool flag27 = (object)driver == null;
							quaternion = (Quaternion)0;
							vector = (Vector3)0;
							if (flag27)
							{
								goto end_IL_0a54;
							}
							driver.enabled = true;
							quaternion = (Quaternion)0;
							vector = (Vector3)1;
						}
						if (obj3 == null)
						{
							goto end_IL_0a54;
						}
						GameObject obj40 = ((Component)obj3).gameObject;
						object obj41 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v8+E4]");
						bool flag28 = (nint)0 == 0;
						object obj42 = !flag28;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object.Destroy(obj40);
						limp = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag29 = !ease;
						object obj43 = !flag29;
						object obj44 = ~obj43;
						float num;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
							num = 0f;
						}
						else
						{
							num = 0f;
						}
						easing = num;
						return;
					}
				}
				throw new IndexOutOfRangeException();
				continue;
				end_IL_0a54:
				break;
			}
		}
		throw new NullReferenceException();
	}

	private void Update()
	{
		//IL_000b: Invalid comparison between F4 and I4
		if (easing > 0f)
		{
			PutBackPosed();
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_14da: Expected I, but got Obj
		//IL_1506: Expected Obj, but got I4
		//IL_006a: Expected VT, but got I4
		//IL_00ac: Expected VT, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_151c: Expected I, but got Obj
		//IL_1548: Expected Obj, but got I4
		//IL_016e: Expected VT, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_01a2: Expected VT, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Expected Obj, but got Unknown
		//IL_15e7: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_039e: Expected I, but got Obj
		//IL_03ca: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_033a: Expected VT, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_040d: Expected VT, but got I4
		//IL_0297: Expected VT, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_0748: Invalid comparison between F4 and I4
		//IL_0759: Expected Obj, but got I4
		//IL_0764: Invalid comparison between F4 and I4
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0440: Expected VT, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_0b68: Expected Obj, but got I4
		//IL_07c4: Invalid comparison between F8 and I4
		//IL_07d3: Expected F8, but got I4
		//IL_1647: Invalid comparison between F4 and I4
		//IL_1658: Expected Obj, but got I4
		//IL_1661: Invalid comparison between F4 and I4
		//IL_1682: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I4
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected Obj, but got Unknown
		//IL_1566: Expected Obj, but got I
		//IL_157e: Expected Obj, but got I
		//IL_1586: Expected F4, but got Obj
		//IL_1596: Expected F8, but got I
		//IL_15a6: Expected F8, but got I
		//IL_15b1: Expected VT, but got I4
		//IL_1471: Invalid comparison between F4 and I4
		//IL_1482: Expected Obj, but got I4
		//IL_0bb2: Expected VT, but got I4
		//IL_0bbb: Expected Obj, but got I4
		//IL_0491: Expected Obj, but got I4
		//IL_08e3: Expected Obj, but got I4
		//IL_08ec: Expected Obj, but got I4
		//IL_169f: Expected Obj, but got I4
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected Obj, but got Unknown
		//IL_04db: Expected VT, but got I4
		//IL_0c20: Invalid comparison between F8 and I4
		//IL_0c2f: Invalid comparison between F8 and I4
		//IL_0c47: Expected Obj, but got F8
		//IL_0c54: Expected Obj, but got F8
		//IL_0c89: Expected Obj, but got I4
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected Obj, but got Unknown
		//IL_0911: Expected Obj, but got I4
		//IL_04fb: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got I4
		//IL_16d7: Invalid comparison between F8 and I4
		//IL_16f7: Expected F8, but got I4
		//IL_1708: Expected Obj, but got I4
		//IL_1711: Expected Obj, but got I4
		//IL_0554: Expected VT, but got I4
		//IL_1725: Expected Obj, but got I4
		//IL_172e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Expected Obj, but got Unknown
		//IL_0cd5: Expected F8, but got I4
		//IL_120e: Expected Obj, but got I4
		//IL_095f: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_05c3: Expected VT, but got I4
		//IL_099e: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I4
		//IL_1233: Expected Obj, but got I4
		//IL_0d17: Expected Obj, but got I4
		//IL_0d32: Expected Obj, but got I4
		//IL_0635: Expected VT, but got I4
		//IL_0d59: Expected Obj, but got I4
		//IL_09fe: Expected Obj, but got I4
		//IL_0a19: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I
		//IL_0689: Expected VT, but got I4
		//IL_1285: Expected Obj, but got I4
		//IL_06b3: Expected VT, but got I4
		//IL_06b3: Expected VT, but got I4
		//IL_06b3: Expected Obj, but got I
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_06e7: Expected Obj, but got I4
		//IL_06f8: Expected VT, but got I4
		//IL_070b: Expected Obj, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_0dc0: Expected Obj, but got I
		//IL_0a68: Expected Obj, but got I
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ca: Expected Obj, but got Unknown
		//IL_12d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected Obj, but got Unknown
		//IL_12f3: Expected Obj, but got I4
		//IL_0e13: Expected Obj, but got I4
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_0ac3: Expected Obj, but got I4
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected Obj, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b13: Expected Obj, but got F4
		//IL_0b39: Expected Obj, but got I4
		//IL_1361: Expected F8, but got I
		//IL_1371: Expected F8, but got I
		//IL_1381: Expected F8, but got I
		//IL_1389: Expected F4, but got Obj
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_1397: Expected Obj, but got Unknown
		//IL_13a7: Expected F4, but got I
		//IL_13b7: Expected F8, but got I
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Expected Obj, but got Unknown
		//IL_13df: Expected VT, but got I4
		//IL_13df: Expected Obj, but got I
		//IL_1405: Expected Obj, but got I4
		//IL_0f15: Expected Obj, but got I4
		//IL_0f73: Expected Obj, but got I4
		//IL_0f8e: Expected Obj, but got I4
		//IL_0ff9: Expected Obj, but got I
		//IL_1038: Expected VT, but got I
		//IL_1048: Expected VT, but got I
		//IL_1060: Expected F8, but got I
		//IL_107d: Expected VT, but got I4
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected Obj, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_10cd: Expected Obj, but got I4
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected Obj, but got Unknown
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Expected Obj, but got Unknown
		//IL_110e: Expected Obj, but got F8
		//IL_1143: Expected Obj, but got I4
		//IL_1153: Expected VT, but got I
		//IL_1163: Expected VT, but got I
		//IL_1183: Expected F8, but got I
		//IL_1196: Expected VT, but got I4
		//IL_11b5: Expected VT, but got I
		//IL_11c5: Expected VT, but got I
		//IL_11dd: Expected F8, but got I
		//IL_11f0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		Quaternion[] array = (Quaternion[])0;
		nint num = (nint)array;
		UnityEngine.Object obj = who;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (Il2CppClass<UnityEngine.Quaternion[]>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj == null)
		{
			return;
		}
		bool flag2 = (object)who == null;
		Quaternion quaternion = (Quaternion)0;
		bool downSaid;
		UnityEngine.Object drawn;
		if (!flag2)
		{
			downSaid = who.DownSaid;
			NetworkApe networkApe = who;
			bool flag3 = (object)who == null;
			quaternion = (Quaternion)0;
			if (!flag3)
			{
				nint num2 = (nint)array;
				drawn = networkApe.drawn;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v28 (Il2CppClass<UnityEngine.Quaternion[]>)+E4]");
				Transform[] array2 = (Transform[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v28 (Il2CppClass<UnityEngine.Quaternion[]>)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj3 = !flag4;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(drawn != null))
				{
					drawn = null;
					UnityEngine.Object obj4 = null;
					goto IL_1514;
				}
				NetworkApe networkApe2 = who;
				bool flag5 = (object)who == null;
				quaternion = (Quaternion)0;
				obj = (UnityEngine.Object)downSaid;
				if (!flag5)
				{
					bool flag6 = (object)networkApe2.drawn == null;
					quaternion = (Quaternion)0;
					obj = (UnityEngine.Object)downSaid;
					if (!flag6)
					{
						bool inHand = networkApe2.drawn.InHand;
						drawn = (UnityEngine.Object)inHand;
						UnityEngine.Object obj4 = null;
						goto IL_1514;
					}
				}
			}
		}
		goto IL_0732;
		IL_0396:
		nint num3 = (nint)array;
		obj = limp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X0_v38 (Il2CppClass<UnityEngine.Quaternion[]>)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj5 = !flag7;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj != null;
		bool flag9 = !flag8;
		quaternion = (Quaternion)0;
		float num6 = default;
		double num25 = default;
		float num5 = default;
		UnityEngine.Object obj10;
		if (!flag9)
		{
			Transform[] array3 = real;
			bool flag10 = real == null;
			quaternion = (Quaternion)0;
			if (!flag10)
			{
				float num4 = num5;
				UnityEngine.Object obj7 = default;
				UnityEngine.Object obj6 = obj7;
				UnityEngine.Object obj8 = (UnityEngine.Object)4;
				UnityEngine.Object obj9 = obj;
				while (true)
				{
					obj10 = (UnityEngine.Object)(obj8 - 4);
					if ((nint)obj10 >= array3.Length)
					{
						return;
					}
					bool flag11 = (nint)obj10 < array3.Length;
					object obj11 = !flag11;
					if (obj11 != null)
					{
						break;
					}
					Transform[] array2 = copied;
					bool flag12 = copied == null;
					num5 = num4;
					obj7 = obj6;
					drawn = obj8;
					quaternion = (Quaternion)0;
					obj = obj9;
					if (!flag12)
					{
						obj7 = (UnityEngine.Object)array2.Length;
						bool flag13 = (nint)obj10 < array2.Length;
						object obj12 = !flag13;
						if (obj12 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v2 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
						bool flag14 = (nint)0 == 0;
						num5 = num4;
						drawn = obj8;
						quaternion = (Quaternion)0;
						obj = obj9;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v34 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
							obj = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v2 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
							Vector3 position = ((Transform)0).position;
							Transform[] array4 = copied;
							bool flag15 = copied == null;
							num5 = num4;
							drawn = obj8;
							quaternion = (Quaternion)0;
							if (!flag15)
							{
								array2 = (Transform[])array4.Length;
								bool flag16 = (nint)obj10 < array4.Length;
								object obj13 = !flag16;
								if (obj13 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v35 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
								bool flag17 = (nint)0 == 0;
								num5 = num4;
								drawn = obj8;
								quaternion = (Quaternion)0;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v35 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
									Quaternion rotation = ((Transform)0).rotation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v34 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
									bool flag18 = (nint)0 == 0;
									num5 = num4;
									drawn = obj8;
									quaternion = (Quaternion)0;
									if (!flag18)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v34 (UnityEngine.Transform[])+v239 @ X21_v15 (UnityEngine.Object)*8]");
										((Transform)0).SetPositionAndRotation((Vector3)0, (Quaternion)0);
										array3 = real;
										drawn = (UnityEngine.Object)(obj8 + 1);
										bool flag19 = real == null;
										object obj14 = !flag19;
										num5 = num6;
										quaternion = (Quaternion)0;
										num4 = num6;
										obj6 = (UnityEngine.Object)array2.Length;
										obj8 = drawn;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v34 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
										obj9 = (UnityEngine.Object)0;
										if (obj14 != null)
										{
											continue;
										}
									}
								}
							}
						}
					}
					goto IL_0732;
				}
				goto IL_14cb;
			}
		}
		else
		{
			bool flag20 = easing < 0f;
			object obj15 = !flag20;
			bool flag21 = easing == 0f;
			object obj16 = ~obj15;
			object obj17 = obj16 | flag21;
			if (obj17 != null)
			{
				return;
			}
			float num7 = easing;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A834]");
			float num8 = num7 / 0f;
			double num9 = (double)num8 + 1.0;
			bool flag22 = num9 < 0.0;
			double num10 = 0.0;
			if (!flag22)
			{
				bool flag23 = !(num9 > 1.0);
				num10 = num9;
				if (!flag23)
				{
					num10 = 1.0;
				}
			}
			float deltaTime = Time.deltaTime;
			float num11 = easing - deltaTime;
			bool flag24 = num11 < 0f;
			object obj18 = !flag24;
			bool flag25 = num11 == 0f;
			easing = num11;
			object obj19 = ~obj18;
			object obj20 = obj19 | flag25;
			if (obj20 != null)
			{
				return;
			}
			Transform[] array5 = real;
			if (real != null)
			{
				double num12 = num10 + num10;
				double num13 = num10 * 3.0;
				double num14 = num10 * num12;
				double num15 = num10 * num13;
				double num16 = num10 * num14;
				double num17 = num15 - num16;
				double num18 = 1.0 - num17;
				double num19 = num18 * 0.0;
				double num20 = num17 + num19;
				drawn = (UnityEngine.Object)4;
				obj10 = (UnityEngine.Object)44;
				obj = null;
				while (true)
				{
					Transform[] array2 = (Transform[])array5.Length;
					array = (Quaternion[])(drawn - 4);
					if ((nint)array >= array5.Length)
					{
						break;
					}
					bool flag26 = (nint)array < array5.Length;
					object obj21 = !flag26;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
						if ((nint)0 != 0)
						{
							Vector3[] array6 = posedAt;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
							Vector3 localPosition = ((Transform)0).localPosition;
							if (posedAt != null)
							{
								bool flag27 = (nint)array < array6.Length;
								object obj22 = !flag27;
								if (obj22 != null)
								{
									goto IL_14cb;
								}
								object obj23 = (object)posedAt + (object)obj;
								Transform[] array7 = real;
								if (real != null)
								{
									array2 = (Transform[])array7.Length;
									bool flag28 = (nint)array < array7.Length;
									object obj24 = !flag28;
									if (obj24 != null)
									{
										goto IL_14cb;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v23 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
									if ((nint)0 != 0)
									{
										array = posedTurned;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v23 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
										Quaternion localRotation = ((Transform)0).localRotation;
										if (posedTurned != null)
										{
											drawn = (UnityEngine.Object)(drawn + 1);
											array2 = (Transform[])(drawn - 5);
											bool flag29 = (nint)array2 < array.Length;
											object obj25 = !flag29;
											if (obj25 != null)
											{
												goto IL_14cb;
											}
											object obj26 = (object)posedTurned + (object)obj10;
											obj10 = (UnityEngine.Object)(obj10 + 16);
											obj = (UnityEngine.Object)(obj + 12);
											obj26 = num5;
											array5 = real;
											bool flag30 = real == null;
											object obj27 = !flag30;
											if (obj27 != null)
											{
												continue;
											}
										}
									}
								}
							}
						}
						goto IL_0732;
					}
					goto IL_14cb;
				}
				double num21 = num20 - 1.0;
				bool flag31 = num21 < 0.0;
				bool flag32 = num21 == 0.0;
				object obj28 = num20 ^ 1.0;
				object obj29 = num20 ^ num21;
				object obj30 = obj28 & obj29;
				bool flag33 = (nint)obj30 < 0;
				bool flag34 = flag31 == flag33;
				object obj31 = !flag32;
				object obj32 = flag34 & obj31;
				object obj33 = ~obj32;
				double num22 = ((obj33 != null) ? num20 : 1.0);
				if (num20 < 0.0)
				{
					num22 = 0.0;
				}
				num19 = 0.0;
				double num23 = num22;
				drawn = (UnityEngine.Object)4;
				obj10 = (UnityEngine.Object)32;
				obj = null;
				object obj39 = default;
				Quaternion a = default;
				Quaternion b = default;
				while (true)
				{
					UnityEngine.Object obj7 = (UnityEngine.Object)array5.Length;
					array = (Quaternion[])(drawn - 4);
					if ((nint)array < array5.Length)
					{
						Vector3[] array8 = drawnAt;
						bool flag35 = drawnAt == null;
						Transform[] array2 = (Transform[])(object)drawnAt;
						if (flag35)
						{
							break;
						}
						Vector3[] array9 = (Vector3[])array8.Length;
						bool flag36 = (nint)array < array8.Length;
						object obj34 = !flag36;
						if (obj34 == null)
						{
							bool flag37 = System.Runtime.CompilerServices.Unsafe.As<Quaternion[], UIntPtr>(ref array) < System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj7);
							object obj35 = !flag37;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
								bool flag38 = (nint)0 == 0;
								array2 = (Transform[])(object)drawnAt;
								if (flag38)
								{
									break;
								}
								object obj36 = (object)drawnAt + (object)obj;
								Vector3[] array10 = easedAt;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
								Vector3 position2 = ((Transform)0).position;
								bool flag39 = easedAt == null;
								array2 = (Transform[])(object)drawnAt;
								Vector3[] array6 = easedAt;
								if (flag39)
								{
									break;
								}
								bool flag40 = (nint)array < array10.Length;
								object obj37 = !flag40;
								if (obj37 == null)
								{
									double num24 = num25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v14+28]");
									double num26 = num24 - 0.0;
									object obj38 = (object)easedAt + (object)obj;
									double num27 = num23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v14+20]");
									double num28 = num27 - 0.0;
									double num29 = num26 * num22;
									double num30 = num28 * (double)obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v14+28]");
									num19 = 0.0 + num29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v14+20]");
									double num31 = 0.0 + num30;
									Quaternion[] array11 = drawnTurned;
									bool flag41 = drawnTurned == null;
									num25 = num22;
									array2 = (Transform[])(object)drawnAt;
									array6 = easedAt;
									if (flag41)
									{
										break;
									}
									bool flag42 = (nint)array < array11.Length;
									object obj40 = !flag42;
									if (obj40 == null)
									{
										Transform[] array12 = real;
										bool flag43 = real == null;
										num25 = num22;
										array2 = real;
										array6 = easedAt;
										if (flag43)
										{
											break;
										}
										obj7 = (UnityEngine.Object)array12.Length;
										bool flag44 = (nint)array < array12.Length;
										object obj41 = !flag44;
										if (obj41 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X9_v11 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
											bool flag45 = (nint)0 == 0;
											num25 = num22;
											array2 = real;
											array6 = easedAt;
											if (flag45)
											{
												break;
											}
											Quaternion[] array13 = easedTurned;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X9_v11 (UnityEngine.Transform[])+v241 @ X21_v7 (UnityEngine.Object)*8]");
											Quaternion rotation2 = ((Transform)0).rotation;
											Quaternion quaternion2 = Quaternion.Internal_Slerp(ref a, ref b, (float)num20);
											bool flag46 = easedTurned == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
											a = (Quaternion)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
											b = (Quaternion)0;
											num25 = num22;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
											double num32 = 0.0;
											array2 = real;
											array6 = easedAt;
											quaternion = (Quaternion)0;
											array = easedTurned;
											if (flag46)
											{
												break;
											}
											drawn = (UnityEngine.Object)(drawn + 1);
											array2 = (Transform[])(drawn - 5);
											bool flag47 = (nint)array2 < array13.Length;
											object obj42 = !flag47;
											if (obj42 == null)
											{
												object obj43 = (object)easedTurned + (object)obj10;
												obj10 = (UnityEngine.Object)(obj10 + 16);
												obj = (UnityEngine.Object)(obj + 12);
												obj43 = num20;
												array5 = real;
												bool flag48 = real == null;
												object obj44 = !flag48;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
												a = (Quaternion)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
												b = (Quaternion)0;
												num25 = num22;
												num23 = num20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
												num32 = 0.0;
												array6 = easedAt;
												quaternion = (Quaternion)0;
												if (obj44 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
													a = (Quaternion)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
													b = (Quaternion)0;
													num25 = num22;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v17 (UnityEngine.Quaternion[])+v245 @ X22_v7 (UnityEngine.Object)]");
													num32 = 0.0;
													array6 = easedAt;
													quaternion = (Quaternion)0;
													array = easedTurned;
													break;
												}
												continue;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						obj7 = null;
						Transform[] array2 = (Transform[])44;
						obj = null;
						while (true)
						{
							if ((nint)obj7 >= array5.Length)
							{
								return;
							}
							bool flag49 = (nint)obj7 < array5.Length;
							object obj45 = !flag49;
							if (obj45 != null)
							{
								break;
							}
							Vector3[] array9 = easedAt;
							if (easedAt == null)
							{
								goto end_IL_171b;
							}
							bool flag50 = (nint)obj7 < array9.Length;
							object obj46 = !flag50;
							if (obj46 != null)
							{
								break;
							}
							Quaternion[] array14 = easedTurned;
							if (easedTurned == null)
							{
								goto end_IL_171b;
							}
							drawn = (UnityEngine.Object)(obj7 + 1);
							object obj47 = drawn - 1;
							bool flag51 = (nint)obj47 < array14.Length;
							object obj48 = !flag51;
							if (obj48 != null)
							{
								break;
							}
							object obj49 = (object)array5 + (object)obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v11+20]");
							if ((nint)0 == 0)
							{
								goto end_IL_171b;
							}
							object obj50 = (object)easedAt + (object)obj;
							object obj51 = (object)easedTurned + (object)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v12+24]");
							num19 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v12+28]");
							num25 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X10_v7-4]");
							double num33 = 0.0;
							float num34 = (float)obj51;
							obj = (UnityEngine.Object)(obj + 12);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X10_v7-C]");
							num5 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X10_v7-8]");
							double num32 = 0.0;
							obj10 = (UnityEngine.Object)(array2 + 16);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v11+20]");
							((Transform)0).SetPositionAndRotation((Vector3)0, quaternion);
							array5 = real;
							bool flag52 = real == null;
							object obj52 = !flag52;
							obj7 = drawn;
							array2 = (Transform[])(object)obj10;
							if (obj52 == null)
							{
								obj7 = drawn;
								array2 = (Transform[])(object)obj10;
								goto end_IL_171b;
							}
						}
					}
					goto IL_14cb;
					continue;
					end_IL_171b:
					break;
				}
			}
		}
		goto IL_0732;
		IL_1514:
		nint num35 = (nint)array;
		obj10 = limp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (Il2CppClass<UnityEngine.Quaternion[]>)+E4]");
		bool flag53 = (nint)0 == 0;
		object obj53 = !flag53;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag55;
		if (obj10 == null)
		{
			object obj54 = !downSaid;
			object obj55 = (object)drawn | obj54;
			object obj56 = obj55 & 1;
			bool flag54 = obj56 == null;
			object obj57 = !flag54;
			flag55 = false;
			if (obj57 == null)
			{
				bool flag56 = (object)who == null;
				quaternion = (Quaternion)0;
				obj = (UnityEngine.Object)downSaid;
				if (flag56)
				{
					goto IL_0732;
				}
				bool isMonster = who.IsMonster;
				bool flag57 = !isMonster;
				object obj58 = !flag57;
				flag55 = false;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj59 = 0;
					object obj60 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v46+A0]");
					object obj61 = 0;
					num6 = (float)obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v47+4]");
					double num19 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v47+8]");
					num25 = 0.0;
					Begin((Vector3)0);
					flag55 = false;
				}
			}
			goto IL_0396;
		}
		if (downSaid)
		{
			heard = true;
		}
		object obj62 = drawn & 1;
		bool flag58 = obj62 == null;
		object obj63 = !flag58;
		if (obj63 == null)
		{
			bool flag59 = (object)who == null;
			quaternion = (Quaternion)0;
			obj = (UnityEngine.Object)downSaid;
			if (flag59)
			{
				goto IL_0732;
			}
			if (!who.IsMonster)
			{
				bool flag60 = !downSaid;
				object obj64 = !flag60;
				flag55 = false;
				if (obj64 == null)
				{
					if (~(heard ? 1u : 0u) == 0)
					{
						bool flag61 = (object)who == null;
						quaternion = (Quaternion)0;
						obj = (UnityEngine.Object)downSaid;
						if (flag61)
						{
							goto IL_0732;
						}
						if (!who.Busy)
						{
							goto IL_037d;
						}
						flag55 = false;
					}
					else
					{
						float time = Time.time;
						num6 = time - since;
						float num36 = num6 - 1.5f;
						bool flag62 = num36 == 0f;
						object obj31 = !flag62;
						bool flag63 = (double)num6 > 1.5;
						double num19 = 1.5;
						if (flag63)
						{
							goto IL_037d;
						}
						num19 = 1.5;
						flag55 = false;
					}
				}
				goto IL_0396;
			}
		}
		goto IL_037d;
		IL_0732:
		throw new NullReferenceException();
		IL_14cb:
		throw new IndexOutOfRangeException();
		IL_037d:
		End(ease: true);
		flag55 = true;
		goto IL_0396;
	}

	private void PutBackPosed()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_0101: Expected VT, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		Transform[] array = real;
		object obj = 0;
		Quaternion localRotation = default;
		while (true)
		{
			if ((nint)obj < array.Length)
			{
				bool flag = (nint)obj < array.Length;
				object obj2 = !flag;
				if (obj2 != null)
				{
					break;
				}
				Vector3[] array2 = posedAt;
				bool flag2 = (nint)obj < array2.Length;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					break;
				}
				Quaternion[] array3 = posedTurned;
				object obj4 = obj + 1;
				object obj5 = obj4 - 1;
				bool flag3 = (nint)obj5 < array3.Length;
				object obj6 = !flag3;
				if (obj6 != null)
				{
					break;
				}
				object obj7 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v5+20]");
				((Transform)0).SetLocalPositionAndRotation((Vector3)0, localRotation);
				array = real;
				bool flag4 = real == null;
				object obj8 = !flag4;
				obj = obj4;
				if (obj8 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}
}
