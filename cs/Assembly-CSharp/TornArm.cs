using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class TornArm : MonoBehaviour
{
	public const int Upper = default(int);

	public const int Fore = default(int);

	public const int Palm = default(int);

	public const int Links = default(int);

	private const float Jumped = default(float);

	private const float Trailing = default(float);

	private const float Rolls = default(float);

	private readonly Transform[] links;

	private readonly Rigidbody[] bodies;

	private readonly CapsuleCollider[] shapes;

	private readonly float[] middles;

	private readonly Dictionary<Transform, Transform> copied;

	private SkinnedMeshRenderer skin;

	private int held;

	private int heldBy;

	private bool heldRight;

	private Vector3 heldAt;

	private Quaternion heldTurned;

	private float heldRoll;

	private Vector3 hingeOnUpper;

	private Vector3 hingeOnFore;

	private static readonly Dictionary<Mesh, bool[]> skinnedOn;

	private TornPiece Piece__BackingField;

	public TornPiece Piece
	{
		get
		{
			return Piece__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool InHand
	{
		get
		{
			int num = ~held;
			return (byte)(num >> 31) != 0;
		}
	}

	public Transform HeldLink
	{
		get
		{
			//IL_005e: Expected Obj, but got I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0088: Expected Obj, but got I
			Transform[] array = links;
			if (links != null)
			{
				int num = ~held;
				int num2 = held & num;
				bool flag = num2 < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = links + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v2+20]");
					return (Transform)0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			return (Transform)(object)new IndexOutOfRangeException();
		}
	}

	public Vector3 MiddleNow
	{
		get
		{
			//IL_00bf: Expected VT, but got Obj
			//IL_00a8: Expected VT, but got I4
			//IL_00a8: Expected VT, but got I4
			Transform heldLink = HeldLink;
			if ((object)heldLink != null)
			{
				Vector3 position = heldLink.position;
				Transform heldLink2 = HeldLink;
				if ((object)heldLink2 != null)
				{
					Quaternion rotation = heldLink2.rotation;
					int num = ~held;
					int num2 = held & num;
					Vector3 vector = MiddleOf(num2);
					return (Quaternion)0 * (Vector3)num2;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public unsafe Bounds WorldBox
	{
		get
		{
			//IL_0321: Expected VT, but got Obj
			//IL_0331: Expected Obj, but got I
			//IL_0349: Expected Obj, but got I
			//IL_0351: Expected F8, but got Obj
			//IL_0386: Expected Obj, but got I4
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected Obj, but got Unknown
			//IL_03ab: Invalid comparison between F8 and I4
			//IL_03ba: Invalid comparison between F8 and I4
			//IL_03cd: Expected Obj, but got F8
			//IL_03da: Expected Obj, but got F8
			//IL_0419: Expected Obj, but got I4
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected Obj, but got Unknown
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Expected VT, but got Unknown
			//IL_01d3: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected Obj, but got Unknown
			//IL_0233: Expected Obj, but got I
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Expected Obj, but got Unknown
			//IL_0289: Expected VT, but got I4
			//IL_0504: Invalid comparison between F8 and I4
			//IL_0513: Invalid comparison between F8 and I4
			//IL_0526: Expected Obj, but got F8
			//IL_0533: Expected Obj, but got F8
			//IL_057c: Expected Obj, but got I4
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Expected Obj, but got Unknown
			//IL_05e3: Expected F4, but got I
			//IL_05f0: Expected VT, but got F8
			//IL_05eb: Expected native int or pointer, but got VT
			//IL_05fb: Expected VT, but got Ref
			Transform[] array = links;
			if (links != null)
			{
				if (array.Length == 0)
				{
					goto IL_0313;
				}
				if ((object)array[0] != null)
				{
					Vector3 position = array[0].position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+A0]");
					object obj3 = 0;
					double num = (double)obj3;
					double num2 = (double)obj3 * 63.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v7+8]");
					double num3 = 0.0 * 0.5;
					object obj4 = 5;
					double num5 = default;
					double num4 = num5;
					Bounds bounds = default;
					while (true)
					{
						Transform[] array2 = links;
						if (links != null)
						{
							object obj5 = obj4 - 4;
							bool flag = (nint)obj5 < array2.Length;
							object obj6 = !flag;
							if (obj6 != null)
							{
								goto IL_02f7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9 (UnityEngine.Transform[])+v77 @ X22_v4*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9 (UnityEngine.Transform[])+v77 @ X22_v4*8]");
								Vector3 position2 = ((Transform)0).position;
								double num6 = num4 - num3;
								obj4++;
								double num7 = num4 + num3;
								double num8 = (double)bounds + num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num6 < num))
								{
									num6 = num;
								}
								double num9 = num7 - num;
								bool flag2 = num9 < 0.0;
								bool flag3 = num9 == 0.0;
								object obj7 = num7 ^ num;
								object obj8 = num7 ^ num9;
								object obj9 = obj7 & obj8;
								bool flag4 = (nint)obj9 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								bool flag5 = flag2 == flag4;
								object obj10 = !flag3;
								object obj11 = flag5 & obj10;
								object obj12 = ~obj11;
								if (obj12 != null)
								{
									num7 = num;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
								num = num8 - (double)bounds;
								double num10 = num7 - num6;
								num2 = num * 63.0;
								num3 = num10 * 0.5;
								bounds = (Bounds)(bounds + num2);
								num4 = num6 + num3;
								if ((nint)obj4 == 7)
								{
									break;
								}
								continue;
							}
						}
						NullReferenceException ex = new NullReferenceException();
						goto IL_02f7;
						IL_02f7:
						IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
						goto IL_0305;
					}
					Transform[] array3 = links;
					if (links != null)
					{
						bool flag6 = array3.Length < 2;
						object obj13 = !flag6;
						object obj14 = array3.Length - 2;
						bool flag7 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag7;
						if (obj16 != null)
						{
							goto IL_0313;
						}
						if ((object)array3[2] != null)
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v12+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v13+18]");
							object obj19 = 0 * bounds;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v13+20]");
							float num11 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							float num12 = num11 * 0f;
							Vector3 vector = array3[2].TransformPoint((Vector3)0);
							double num13 = num4 - num3;
							double num14 = num4 + num3;
							double num15 = (double)bounds - num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							if (num13 < (double)num12)
							{
							}
							double num16 = num14 - (double)num12;
							bool flag8 = num16 < 0.0;
							bool flag9 = num16 == 0.0;
							object obj20 = num14 ^ (double)num12;
							object obj21 = num14 ^ num16;
							object obj22 = obj20 & obj21;
							bool flag10 = (nint)obj22 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
							bool flag11 = flag8 == flag10;
							object obj23 = !flag9;
							object obj24 = flag11 & obj23;
							object obj25 = ~obj24;
							if (obj25 == null)
							{
							}
							double num17 = (double)obj19 - num15;
							double num18 = num17 * 63.0;
							double num19 = num15 + num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							Bounds bounds2 = default;
							bounds2.Expand(0f);
							Bounds bounds3 = default;
							((Bounds*)(nint)bounds3)->m_Center = (Vector3)num19;
							_ = 0;
							return (Bounds)(&bounds2);
						}
					}
				}
			}
			goto IL_0305;
			IL_0313:
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			return (Bounds)ex3;
			IL_0305:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0313;
		}
	}

	public Transform Link(int i)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		Transform[] array = links;
		if (links != null)
		{
			object obj = i - 2;
			bool flag = (nint)obj < 0;
			int num = i ^ 2;
			int num2 = i ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num4 = ((obj3 != null) ? 2 : i);
			int num5 = ~num4;
			int num6 = num4 & num5;
			bool flag4 = num6 < array.Length;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				object obj5 = links + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v2+20]");
				return (Transform)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (Transform)(object)new IndexOutOfRangeException();
	}

	public Collider Shape(int i)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		CapsuleCollider[] array = shapes;
		if (shapes != null)
		{
			object obj = i - 2;
			bool flag = (nint)obj < 0;
			int num = i ^ 2;
			int num2 = i ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num4 = ((obj3 != null) ? 2 : i);
			int num5 = ~num4;
			int num6 = num4 & num5;
			bool flag4 = num6 < array.Length;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				object obj5 = shapes + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v2+20]");
				return (Collider)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (Collider)(object)new IndexOutOfRangeException();
	}

	public Vector3 MiddleOf(int i)
	{
		//IL_00c2: Expected VT, but got Obj
		//IL_0013: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_00a6: Expected VT, but got Obj
		float[] array = middles;
		if (middles != null)
		{
			object obj = i - 2;
			bool flag = (nint)obj < 0;
			int num = i ^ 2;
			int num2 = i ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num4 = ((obj3 != null) ? 2 : i);
			int num5 = ~num4;
			int num6 = num4 & num5;
			bool flag4 = num6 < array.Length;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				return (Vector3)this;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
	}

	public unsafe static TornArm Make(SkinnedMeshRenderer from, string name, bool left, Material[] materials, Vector3 front, Vector3 going, Vector3 spin)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1820: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_184f: Expected Obj, but got I
		//IL_1870: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I4
		//IL_1904: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I8
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		//IL_1981: Expected Obj, but got I4
		//IL_04b9: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_1890: Expected Obj, but got I4
		//IL_1899: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Expected Obj, but got Unknown
		//IL_053b: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I4
		//IL_18cd: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I
		//IL_06f4: Expected VT, but got I4
		//IL_06f4: Expected VT, but got I4
		//IL_0758: Expected VT, but got I4
		//IL_0758: Expected VT, but got I4
		//IL_076c: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_0844: Expected VT, but got I
		//IL_0844: Expected VT, but got Obj
		//IL_091f: Expected VT, but got I
		//IL_091f: Expected VT, but got Obj
		//IL_0a13: Expected VT, but got I
		//IL_0a13: Expected VT, but got Obj
		//IL_0a28: Expected Obj, but got I
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected Obj, but got Unknown
		//IL_0a67: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I4
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected Obj, but got Unknown
		//IL_0aa6: Expected Obj, but got I4
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected Obj, but got Unknown
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected Obj, but got Unknown
		//IL_0bd0: Expected Obj, but got I4
		//IL_0be0: Expected Obj, but got I4
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_0c23: Expected Obj, but got I
		//IL_0c4d: Expected Obj, but got I4
		//IL_0d0b: Expected Obj, but got I
		//IL_0d6e: Expected Obj, but got I8
		//IL_0e18: Expected Obj, but got I4
		//IL_0e28: Expected Obj, but got I4
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_1951: Invalid comparison between F4 and I
		//IL_1252: Expected Obj, but got I8
		//IL_11d6: Expected Obj, but got I8
		//IL_12da: Expected Obj, but got I
		//IL_1383: Expected VT, but got I4
		//IL_13c6: Expected Obj, but got I8
		//IL_142c: Expected VT, but got I4
		//IL_143e: Expected VT, but got I4
		//IL_1469: Expected VT, but got F4
		//IL_1486: Expected VT, but got Ref
		//IL_151d: Expected VT, but got I4
		//IL_15ac: Expected Obj, but got I4
		//IL_15bc: Expected Obj, but got I4
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Expected Obj, but got Unknown
		//IL_165a: Expected Obj, but got I
		//IL_16a7: Expected Obj, but got I8
		//IL_16d4: Expected Obj, but got I
		//IL_16fe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = from == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		TornArm result = null;
		if (obj4 != null)
		{
			goto IL_17d5;
		}
		Transform[] bones;
		Transform transform;
		UnityEngine.Object obj16;
		UnityEngine.Object obj17;
		if ((object)from != null)
		{
			Mesh sharedMesh = from.sharedMesh;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = sharedMesh == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			result = null;
			if (obj7 != null)
			{
				goto IL_17d5;
			}
			bool flag7 = !left;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C95B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C95B0]");
			object obj9 = 0;
			object obj10 = !flag7;
			object obj11 = ~obj10;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF8]");
				obj8 = 0;
			}
			string text = (string)obj9 + (string)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C95C0]");
			object obj12 = 0;
			string text2 = (string)obj12 + (string)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF0]");
			object obj13 = 0;
			string text3 = (string)obj13 + (string)obj8;
			bones = from.bones;
			if (bones != null)
			{
				object obj18;
				string text4;
				if (bones.Length >= 1)
				{
					object obj14 = bones.Length & 0xFFFFFFFFL;
					object obj15 = bones + 32;
					transform = null;
					obj16 = null;
					obj17 = null;
					obj18 = 0;
					text4 = null;
					object obj19 = 0;
					while (true)
					{
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
						object obj20 = !flag8;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X0_v152+E4]");
						bool flag9 = (nint)0 == 0;
						object obj22 = !flag9;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
						bool flag10 = (UnityEngine.Object)0 == null;
						bool flag11 = !flag10;
						object obj23 = !flag11;
						obj18 = 0;
						text4 = null;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
							if ((nint)0 == 0)
							{
								goto IL_17da;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
							string text5 = ((UnityEngine.Object)0).name;
							if (text5 == text)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
								obj17 = (UnityEngine.Object)0;
								obj18 = 0;
								text4 = text;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
								string text6 = ((UnityEngine.Object)0).name;
								if (text6 == text2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
									obj16 = (UnityEngine.Object)0;
									obj18 = 0;
									text4 = text2;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
									string text7 = ((UnityEngine.Object)0).name;
									bool flag12 = text7 == text3;
									bool flag13 = !flag12;
									object obj24 = !flag13;
									obj11 = ~obj24;
									UnityEngine.Object obj25;
									if (obj11 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X24_v10+v865 @ X22_v16*8]");
										obj25 = (UnityEngine.Object)0;
									}
									else
									{
										obj25 = transform;
									}
									transform = (Transform)obj25;
									obj18 = 0;
									text4 = text3;
								}
							}
						}
						obj14 = bones.Length;
						obj19++;
						if ((nint)obj19 < bones.Length)
						{
							continue;
						}
						goto IL_18da;
					}
					goto IL_17e8;
				}
				transform = null;
				obj16 = null;
				obj17 = null;
				obj18 = 0;
				text4 = null;
				goto IL_18da;
			}
		}
		goto IL_17da;
		IL_18da:
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v26+E4]");
		bool flag14 = (nint)0 == 0;
		object obj27 = !flag14;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = obj17 == null;
		bool flag16 = !flag15;
		object obj28 = !flag16;
		result = null;
		float num;
		float num2;
		float num5 = default;
		float num7 = default;
		TornArm tornArm = default;
		float num8;
		float num9;
		float num10;
		float num11;
		float num12;
		float num13;
		float num14;
		if (obj28 == null)
		{
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v30+E4]");
			bool flag17 = (nint)0 == 0;
			object obj30 = !flag17;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = obj16 == null;
			bool flag19 = !flag18;
			object obj31 = !flag19;
			result = null;
			if (obj31 == null)
			{
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X0_v34+E4]");
				bool flag20 = (nint)0 == 0;
				object obj33 = !flag20;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag21 = transform == null;
				bool flag22 = !flag21;
				object obj34 = !flag22;
				result = null;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
					object obj35 = 0;
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X0_v38+E4]");
					bool flag23 = (nint)0 == 0;
					object obj37 = !flag23;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num = Size((Transform)obj17);
					if ((object)obj16 != null)
					{
						Vector3 localScale = ((Transform)obj16).localScale;
						if ((object)transform != null)
						{
							Vector3 localScale2 = transform.localScale;
							Vector3 localPosition = ((Transform)obj16).localPosition;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
							Vector3 localPosition2 = transform.localPosition;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
							if ((object)obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								num2 = num * num;
								Vector3 position = ((Transform)obj17).position;
								Quaternion rotation = ((Transform)obj17).rotation;
								Vector3 localPosition3 = ((Transform)obj16).localPosition;
								Vector3 vector = (Quaternion)0 * (Vector3)0;
								Quaternion rotation2 = ((Transform)obj16).rotation;
								Vector3 localPosition4 = transform.localPosition;
								float num3 = num2 * num;
								float num4 = num2 * num5;
								float num6 = num2 * num7;
								Vector3 vector2 = (Quaternion)0 * (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								GameObject gameObject = default;
								gameObject._002Ector(name);
								if ((object)gameObject != null)
								{
									gameObject.layer = 2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB80]");
									object obj39 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
									Transform t = gameObject.transform;
									Quaternion rotation3 = ((Transform)obj17).rotation;
									if ((object)tornArm != null)
									{
										IntPtr intPtr = default;
										tornArm.AddLink(0, t, (Vector3)materials, (Quaternion)front, num, num5, num7, num, going, spin, (Vector3)(nint)intPtr);
										string text8 = obj16.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										GameObject gameObject2 = default;
										gameObject2._002Ector(text8);
										if ((object)gameObject2 != null)
										{
											num8 = num5 + num5;
											num9 = num + num;
											num10 = num7 + num7;
											gameObject2.layer = 2;
											Transform t2 = gameObject2.transform;
											Quaternion rotation4 = ((Transform)obj16).rotation;
											tornArm.AddLink(1, t2, (Vector3)materials, (Quaternion)front, num9, num8, num10, num7, going, spin, (Vector3)(nint)intPtr);
											string text9 = transform.name;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											GameObject gameObject3 = default;
											gameObject3._002Ector(text9);
											if ((object)gameObject3 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
												num11 = num2 * num;
												num12 = num8 + num5;
												num13 = num9 + num;
												num14 = num10 + num7;
												gameObject3.layer = 2;
												Transform transform2 = gameObject3.transform;
												Quaternion rotation5 = transform.rotation;
												tornArm.AddLink(2, transform2, (Vector3)materials, (Quaternion)front, num13, num12, num14, num7, going, spin, (Vector3)(nint)intPtr);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB88]");
												object obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
												object obj41 = tornArm + 152;
												object obj42 = default;
												obj41 = obj42;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB60]");
												object obj43 = 0;
												Transform transform3 = transform2;
												object obj44 = 5;
												Behaviour behaviour = default;
												while (true)
												{
													Transform[] array = tornArm.links;
													if (tornArm.links == null)
													{
														break;
													}
													object obj45 = obj44 - 4;
													bool flag24 = (nint)obj45 < array.Length;
													object obj46 = !flag24;
													if (obj46 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v41 (UnityEngine.Transform[])+v867 @ X22_v12*8]");
														if ((nint)0 == 0)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
														if ((object)behaviour == null)
														{
															break;
														}
														object obj47 = behaviour + 56;
														obj47 = obj41;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														behaviour.enabled = false;
														obj44++;
														bool flag25 = (nint)obj44 != 7;
														transform3 = null;
														if (flag25)
														{
															continue;
														}
														goto IL_0b66;
													}
													goto IL_17e8;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_17da;
				}
			}
		}
		goto IL_17d5;
		IL_198f:
		Transform[] array2 = tornArm.links;
		float num15;
		if (tornArm.links != null)
		{
			object obj48 = array2.Length & 0xFFFFFFFEL;
			if (obj48 == null)
			{
				goto IL_17e8;
			}
			if ((object)array2[1] != null)
			{
				GameObject gameObject4 = array2[1].gameObject;
				if ((object)gameObject4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB78]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					Rigidbody[] array3 = tornArm.bodies;
					if (tornArm.bodies != null)
					{
						if (array3.Length == 0)
						{
							goto IL_17e8;
						}
						Joint joint = default;
						if ((object)joint != null)
						{
							joint.connectedBody = array3[0];
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							joint.anchor = (Vector3)0;
							Transform[] array4 = tornArm.links;
							if (tornArm.links != null)
							{
								object obj50 = array4.Length & 0xFFFFFFFEL;
								if (obj50 == null)
								{
									goto IL_17e8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
								if ((object)array4[1] != null)
								{
									Vector3 vector3 = array4[1].InverseTransformDirection((Vector3)0);
									joint.axis = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5EB4");
									((HingeJoint)joint).useLimits = true;
									Vector3 vector4 = (Vector3)(0f - num15);
									float num16 = 1.1248599E+09f - num15;
									object obj51 = default;
									((HingeJoint)joint).limits = (JointLimits)(&obj51);
									Transform[] array5 = tornArm.links;
									if (tornArm.links != null)
									{
										if (array5.Length == 0)
										{
											goto IL_17e8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
										if ((object)array5[0] != null)
										{
											Vector3 vector5 = array5[0].InverseTransformDirection((Vector3)0);
											tornArm.hingeOnUpper = vector4;
											Vector3 axis = joint.axis;
											Transform[] array6 = tornArm.links;
											tornArm.hingeOnFore = vector4;
											if (tornArm.links != null)
											{
												bool flag26 = array6.Length < 2;
												object obj52 = !flag26;
												object obj53 = array6.Length - 2;
												bool flag27 = obj53 == null;
												object obj54 = ~obj52;
												object obj55 = obj54 | flag27;
												if (obj55 != null)
												{
													goto IL_17e8;
												}
												if ((object)array6[2] != null)
												{
													GameObject gameObject5 = array6[2].gameObject;
													if ((object)gameObject5 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB70]");
														object obj56 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
														Rigidbody[] array7 = tornArm.bodies;
														if (tornArm.bodies != null)
														{
															object obj57 = array7.Length & 0xFFFFFFFEL;
															if (obj57 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
																object obj58 = 0;
																object obj59 = obj58;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ X0_v139+E4]");
																bool flag28 = (nint)0 == 0;
																object obj60 = !flag28;
																if (obj60 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																CharacterJoint j = default;
																GillaCorpse.Swing(j, array7[1], 50f, 65f, 30f);
																float num17 = num * num;
																float num18 = num2 * num;
																float num19 = num17 + num18;
																float num20 = num11;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																float num21 = num20 * 0f;
																float num22 = num21 + num19;
																float reach = num22 / num;
																tornArm.Skin(from, bones, transform, materials, num, reach);
																result = tornArm;
																goto IL_17d5;
															}
															goto IL_17e8;
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
		goto IL_17da;
		IL_17e8:
		return (TornArm)(object)new IndexOutOfRangeException();
		IL_17da:
		NullReferenceException ex = new NullReferenceException();
		goto IL_17e8;
		IL_0b66:
		CapsuleCollider[] array8 = tornArm.shapes;
		if (tornArm.shapes == null)
		{
			goto IL_17da;
		}
		if (array8.Length != 0)
		{
			bool flag29 = array8.Length < 2;
			object obj61 = !flag29;
			object obj62 = array8.Length - 2;
			bool flag30 = obj62 == null;
			object obj63 = ~obj61;
			object obj64 = obj63 | flag30;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj65 = 0;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X0_v107+E4]");
				bool flag31 = (nint)0 == 0;
				object obj67 = !flag31;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Physics.IgnoreCollision(array8[0], array8[2]);
				Transform[] array9 = tornArm.links;
				if (tornArm.links != null)
				{
					if (array9.Length == 0)
					{
						goto IL_17e8;
					}
					if ((object)tornArm.copied != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB68]");
						object obj68 = 0;
						((Dictionary<System.__Canon, System.__Canon>)(object)tornArm.copied).set_Item((System.__Canon)(object)obj17, (System.__Canon)(object)array9[0]);
						Transform[] array10 = tornArm.links;
						if (tornArm.links != null)
						{
							object obj69 = array10.Length & 0xFFFFFFFEL;
							if (obj69 == null)
							{
								goto IL_17e8;
							}
							if ((object)tornArm.copied != null)
							{
								((Dictionary<System.__Canon, System.__Canon>)(object)tornArm.copied).set_Item((System.__Canon)(object)obj16, (System.__Canon)(object)array10[1]);
								Transform[] array11 = tornArm.links;
								if (tornArm.links != null)
								{
									bool flag32 = array11.Length < 2;
									object obj70 = !flag32;
									object obj71 = array11.Length - 2;
									bool flag33 = obj71 == null;
									object obj72 = ~obj70;
									object obj73 = obj72 | flag33;
									if (obj73 != null)
									{
										goto IL_17e8;
									}
									if ((object)tornArm.copied != null)
									{
										((Dictionary<System.__Canon, System.__Canon>)(object)tornArm.copied).set_Item((System.__Canon)(object)transform, (System.__Canon)(object)array11[2]);
										float num23 = num8 - num5;
										float num24 = num12 - num8;
										float num25 = num10 - num7;
										float num26 = num14 - num10;
										num15 = num9 - num;
										float num27 = num23 * num23;
										float num28 = num25 * num24;
										float num29 = num25 * num25;
										float num30 = num13 - num9;
										float num31 = num23 * num26;
										float num32 = num15 * num26;
										float num33 = num15 * num15;
										float num34 = num15 * num24;
										float num35 = num25 * num30;
										float num36 = num23 * num30;
										float num37 = num31 - num28;
										float num38 = num30 * num30;
										float num39 = num33 + num27;
										float num40 = num35 - num32;
										float num41 = num24 * num24;
										float num42 = num34 - num36;
										float num43 = num37 * num37;
										float num44 = num29 + num39;
										float num45 = num40 * num40;
										float num46 = num38 + num41;
										float num47 = num26 * num26;
										float num48 = num44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B02C]");
										float num49 = num48 * 0f;
										float num50 = num43 + num45;
										float num51 = num47 + num46;
										float num52 = num42 * num42;
										float num53 = num52 + num50;
										float num54 = num49 * num51;
										bool flag34 = !(num53 < num54);
										float num55 = num37;
										if (!flag34)
										{
											object obj74 = default;
											float num56 = (float)obj74 * num26;
											float num57 = num7 * num24;
											float num58 = num5 * num26;
											float num59 = num7 * num30;
											float num60 = num57 - num58;
											float num61 = num5 * num30;
											num40 = num56 - num59;
											float num62 = (float)obj74 * num24;
											num54 = num61 - num62;
											float num63 = num60 * num60;
											float num64 = num40 * num40;
											float num65 = num63 + num64;
											num49 = num54 * num54;
											num53 = num65 + num49;
											num55 = num60;
											num42 = num5;
										}
										float num66 = num53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
										if (!(num66 < 0f))
										{
											goto IL_198f;
										}
										Transform[] array12 = tornArm.links;
										if (tornArm.links != null)
										{
											object obj75 = array12.Length & 0xFFFFFFFEL;
											if (obj75 == null)
											{
												goto IL_17e8;
											}
											if ((object)array12[1] != null)
											{
												Vector3 right = array12[1].right;
												num55 = num53;
												goto IL_198f;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_17da;
			}
		}
		goto IL_17e8;
		IL_17d5:
		return result;
	}

	private static float Size(Transform bone)
	{
		//IL_0043: Invalid comparison between F4 and I4
		//IL_0052: Invalid comparison between F4 and I4
		//IL_0065: Expected Obj, but got F4
		//IL_0072: Expected Obj, but got F4
		//IL_00a7: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0179: Invalid comparison between F4 and I4
		//IL_0188: Invalid comparison between F4 and I4
		//IL_019b: Expected Obj, but got F4
		//IL_01a8: Expected Obj, but got F4
		//IL_01dd: Expected Obj, but got I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		Vector3 lossyScale = bone.lossyScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num2 = default;
		float num3 = default;
		float num = num2 - num3;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = num2 ^ num3;
		object obj2 = num2 ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		float num4 = ((obj6 != null) ? num3 : num2);
		if (!(num2 < num3))
		{
			num2 = num3;
		}
		float num6 = default;
		float num5 = ((!(num4 < num6)) ? num6 : num4);
		float num7 = num2 - num5;
		bool flag5 = num7 < 0f;
		bool flag6 = num7 == 0f;
		object obj7 = num2 ^ num5;
		object obj8 = num2 ^ num7;
		object obj9 = obj7 & obj8;
		bool flag7 = (nint)obj9 < 0;
		bool flag8 = flag5 == flag7;
		object obj10 = !flag6;
		object obj11 = flag8 & obj10;
		object obj12 = ~obj11;
		if (obj12 != null)
		{
			num2 = num5;
		}
		return num2;
	}

	private void AddLink(int i, Transform t, Vector3 at, Quaternion turned, float size, float length, float radius, float mass, Vector3 going, Vector3 spin, Vector3 about)
	{
		//IL_0783: Expected VT, but got I4
		//IL_0017: Expected VT, but got Obj
		//IL_0017: Expected VT, but got I4
		//IL_07a9: Expected Obj, but got I
		//IL_07c1: Expected Obj, but got I
		//IL_0814: Expected VT, but got I4
		//IL_0840: Expected VT, but got I4
		//IL_0024: Expected I, but got Obj
		//IL_0034: Expected VT, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0122: Expected VT, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_018f: Expected VT, but got Obj
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_0244: Expected F4, but got I
		//IL_026a: Expected VT, but got I4
		//IL_027a: Expected F4, but got I
		//IL_02a0: Expected VT, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0384: Expected F4, but got I
		//IL_02b6: Expected I, but got Obj
		//IL_02c6: Expected VT, but got I
		//IL_02f7: Expected VT, but got I
		//IL_0307: Expected F4, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03f3: Expected VT, but got I4
		//IL_0403: Expected F4, but got I
		//IL_0421: Expected Obj, but got I
		//IL_0429: Expected VT, but got Obj
		//IL_045a: Expected F4, but got I
		//IL_04ab: Expected F4, but got I
		//IL_04c5: Expected F4, but got I
		//IL_0524: Expected F4, but got I
		//IL_085c: Expected VT, but got I4
		//IL_0888: Expected VT, but got I4
		//IL_0896: Expected VT, but got I4
		//IL_0557: Expected VT, but got I4
		//IL_0595: Expected I, but got Obj
		//IL_05a5: Expected VT, but got I
		//IL_0614: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		//IL_06e1: Expected VT, but got I4
		//IL_0727: Expected Obj, but got I
		bool flag = (object)t == null;
		Transform transform = t;
		Vector3 vector = (Vector3)i;
		float num2 = default;
		float num = num2;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			t.SetPositionAndRotation((Vector3)0, (Quaternion)t);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v8+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v9+14]");
			object obj4 = default;
			float num3 = 0f * (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v9+C]");
			num = 0f * (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v9+10]");
			float num4 = 0f * (float)obj4;
			t.localScale = (Vector3)0;
			Transform[] array = links;
			bool flag2 = links == null;
			transform = t;
			vector = (Vector3)0;
			if (!flag2)
			{
				nint num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10 (Il2CppClass<UnityEngine.Transform[]>)+40]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag3 = ex == null;
				transform = t;
				if (flag3)
				{
					goto IL_074e;
				}
				bool flag4 = array.Length < i;
				object obj5 = !flag4;
				object obj6 = array.Length - i;
				bool flag5 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag5;
				transform = t;
				if (obj8 != null)
				{
					goto IL_0740;
				}
				object obj9 = links + i;
				object obj10 = obj9 + 32;
				obj10 = t;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				float[] array2 = middles;
				bool flag6 = middles == null;
				transform = t;
				vector = (Vector3)t;
				if (!flag6)
				{
					bool flag7 = array2.Length < i;
					object obj11 = !flag7;
					object obj12 = array2.Length - i;
					bool flag8 = obj12 == null;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag8;
					transform = t;
					vector = (Vector3)t;
					if (obj14 != null)
					{
						goto IL_0740;
					}
					IntPtr intPtr = default;
					object obj15 = obj4 * (nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
					object obj16 = 0;
					object obj17 = middles + i;
					CapsuleCollider[] array3 = shapes;
					object obj18 = obj16;
					double num6 = (double)obj15 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v17+E4]");
					bool flag9 = (nint)0 == 0;
					object obj19 = !flag9;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num7 = default;
					CapsuleCollider capsuleCollider = GillaCorpse.Capsule(t, (nint)intPtr, num7);
					bool flag10 = shapes == null;
					transform = t;
					vector = (Vector3)0;
					num4 = num7;
					num = (nint)intPtr;
					if (!flag10)
					{
						bool flag11 = (object)capsuleCollider == null;
						Vector3 vector2 = (Vector3)0;
						if (!flag11)
						{
							nint num8 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v30 (Il2CppClass<UnityEngine.CapsuleCollider[]>)+40]");
							vector2 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag12 = ex == null;
							transform = t;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v30 (Il2CppClass<UnityEngine.CapsuleCollider[]>)+40]");
							vector = (Vector3)0;
							num4 = num7;
							num = (nint)intPtr;
							if (flag12)
							{
								goto IL_074e;
							}
						}
						bool flag13 = array3.Length < i;
						object obj20 = !flag13;
						object obj21 = array3.Length - i;
						bool flag14 = obj21 == null;
						object obj22 = ~obj20;
						object obj23 = obj22 | flag14;
						transform = t;
						vector = vector2;
						num4 = num7;
						num = (nint)intPtr;
						if (obj23 != null)
						{
							goto IL_0740;
						}
						object obj24 = shapes + i;
						object obj25 = obj24 + 32;
						obj25 = capsuleCollider;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						GameObject gameObject = t.gameObject;
						bool flag15 = (object)gameObject == null;
						transform = t;
						vector = (Vector3)0;
						num4 = num7;
						num = (nint)intPtr;
						if (!flag15)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
							object obj26 = 0;
							vector = (Vector3)obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
							Rigidbody rigidbody = default;
							bool flag16 = (object)rigidbody == null;
							transform = t;
							num4 = num7;
							num = (nint)intPtr;
							if (!flag16)
							{
								float mass2 = default;
								rigidbody.mass = mass2;
								rigidbody.interpolation = (RigidbodyInterpolation)0;
								rigidbody.collisionDetectionMode = (CollisionDetectionMode)3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
								rigidbody.linearDamping = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
								rigidbody.angularDamping = 0f;
								rigidbody.maxDepenetrationVelocity = 3f;
								rigidbody.maxAngularVelocity = 20f;
								rigidbody.solverIterations = 10;
								rigidbody.solverVelocityIterations = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
								rigidbody.sleepThreshold = 0f;
								rigidbody.inertiaTensor = (Vector3)0;
								object obj27 = default;
								float num9 = size - (float)obj27;
								float num11 = default;
								float num10 = num11 * num9;
								rigidbody.linearVelocity = (Vector3)0;
								rigidbody.angularVelocity = (Vector3)0;
								Rigidbody[] array4 = bodies;
								bool flag17 = bodies == null;
								transform = null;
								vector = (Vector3)0;
								num3 = num11;
								float num12 = default;
								num4 = num12;
								object obj29 = default;
								object obj28 = obj29;
								float num14 = default;
								float num13 = num14;
								float num15 = default;
								num = num15;
								if (!flag17)
								{
									nint num16 = (nint)array4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v25 (Il2CppClass<UnityEngine.Rigidbody[]>)+40]");
									vector = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag18 = ex == null;
									transform = null;
									num3 = num11;
									num4 = num12;
									obj28 = obj29;
									num13 = num14;
									num = num15;
									if (flag18)
									{
										goto IL_074e;
									}
									bool flag19 = array4.Length < i;
									object obj30 = !flag19;
									object obj31 = array4.Length - i;
									bool flag20 = obj31 == null;
									object obj32 = ~obj30;
									object obj33 = obj32 | flag20;
									transform = null;
									num3 = num11;
									num4 = num12;
									obj28 = obj29;
									num13 = num14;
									num = num15;
									if (obj33 != null)
									{
										goto IL_0740;
									}
									object obj34 = bodies + i;
									object obj35 = obj34 + 32;
									obj35 = rigidbody;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									GameObject gameObject2 = t.gameObject;
									bool flag21 = (object)gameObject2 == null;
									transform = null;
									vector = (Vector3)0;
									num3 = num11;
									num4 = num12;
									obj28 = obj29;
									num13 = num14;
									num = num15;
									if (!flag21)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E08]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0740;
		IL_0740:
		ex = new IndexOutOfRangeException();
		goto IL_074e;
		IL_074e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private unsafe void Skin(SkinnedMeshRenderer from, Transform[] bones, Transform end, Material[] materials, float sizeUp, float reach)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I8
		//IL_01bd: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I4
		//IL_1596: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected Obj, but got Unknown
		//IL_15b4: Expected Obj, but got I4
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected Obj, but got Unknown
		//IL_0db2: Expected Obj, but got I8
		//IL_0dc3: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_1056: Expected Obj, but got I
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Expected Obj, but got Unknown
		//IL_154a: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_1411: Expected Obj, but got I4
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_1428: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Expected Obj, but got Unknown
		//IL_1436: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected Obj, but got Unknown
		//IL_0df2: Expected Obj, but got I4
		//IL_0fd6: Expected Obj, but got I4
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Expected Obj, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got I4
		//IL_0f5e: Expected Obj, but got I4
		//IL_0ef7: Expected I, but got Obj
		//IL_0f07: Expected Obj, but got I
		//IL_0f35: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got Ref
		//IL_05d8: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got Ref
		//IL_04fe: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I
		//IL_083d: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_052e: Expected Obj, but got Ref
		//IL_1206: Expected Obj, but got I
		//IL_121e: Expected Obj, but got I
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1233: Expected Obj, but got Unknown
		//IL_1297: Expected VT, but got Ref
		//IL_062e: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06f3: Expected I, but got Obj
		//IL_0703: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_12ce: Expected F4, but got I4
		//IL_054c: Expected Obj, but got Ref
		//IL_0564: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I4
		//IL_12f6: Expected Obj, but got I
		//IL_132d: Expected Obj, but got I4
		//IL_0a4f: Expected Obj, but got I
		//IL_0a69: Expected Obj, but got I
		//IL_0a80: Expected VT, but got I4
		//IL_0a80: Expected VT, but got I4
		//IL_14d1: Expected Obj, but got I
		//IL_14e9: Expected Obj, but got I
		//IL_14f9: Expected Obj, but got I
		//IL_1523: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I
		//IL_0b10: Expected VT, but got I4
		//IL_0b7b: Expected Obj, but got I
		//IL_0b9e: Expected Obj, but got I
		//IL_0bed: Expected Obj, but got I
		//IL_0c03: Expected I, but got Obj
		//IL_0c13: Expected Obj, but got I
		//IL_0c85: Expected Obj, but got I4
		//IL_0ccd: Expected Obj, but got I
		bool flag = (object)from == null;
		float num = reach;
		float num2 = sizeUp;
		Transform transform = end;
		Transform[] array = bones;
		UnityEngine.Object obj = from;
		Mesh sharedMesh;
		object obj7;
		SkinnedMeshRenderer skinnedMeshRenderer;
		Material[] array3;
		double num9;
		double num11;
		float num13;
		float num15;
		Transform transform2;
		Transform[] array4;
		UnityEngine.Object obj11;
		Transform[] array6 = default;
		double num10 = default;
		double num12 = default;
		float num14 = default;
		float num16 = default;
		NullReferenceException ex = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
			object obj2 = 0;
			sharedMesh = from.sharedMesh;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v5+E4]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool[] array2 = SkinnedOn(sharedMesh);
			bool flag3 = bones == null;
			num = reach;
			num2 = sizeUp;
			transform = end;
			array = bones;
			obj = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj7 = 0;
				obj = (UnityEngine.Object)bones.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag4 = bones.Length < 1;
				num = reach;
				num2 = sizeUp;
				transform = end;
				array = bones;
				skinnedMeshRenderer = from;
				array3 = materials;
				if (flag4)
				{
					goto IL_0d54;
				}
				object obj8 = bones.Length & 0xFFFFFFFFL;
				double num4 = default;
				double num3 = num4;
				float num6 = default;
				float num5 = num6;
				float num7 = reach;
				float num8 = sizeUp;
				num9 = num10;
				num11 = num12;
				num13 = num14;
				num15 = num16;
				transform2 = end;
				System.__Canon value = null;
				array4 = bones;
				object obj9 = 32;
				object obj10 = 32;
				obj11 = (UnityEngine.Object)bones.Length;
				SkinnedMeshRenderer skinnedMeshRenderer2 = from;
				Material[] array5 = materials;
				GameObject gameObject = default;
				while (true)
				{
					object obj12 = obj10 - 32;
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj13 = !flag5;
					num4 = num3;
					num6 = num5;
					num = num7;
					num2 = num8;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v56+E4]");
					bool flag6 = (nint)0 == 0;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
					bool flag7 = (UnityEngine.Object)0 == null;
					bool flag8 = !flag7;
					object obj16 = !flag8;
					num4 = num3;
					num6 = num5;
					num = num7;
					array = null;
					obj = null;
					System.__Canon _Canon;
					System.__Canon _Canon2;
					if (obj16 == null)
					{
						bool flag9 = array2 == null;
						num4 = num3;
						num6 = num5;
						num = num7;
						num2 = num8;
						num10 = num9;
						num12 = num11;
						num14 = num13;
						num16 = num15;
						transform = transform2;
						array = null;
						obj = null;
						if (flag9)
						{
							goto IL_139e;
						}
						bool flag10 = (nint)obj12 >= array2.Length;
						num4 = num3;
						num6 = num5;
						num = num7;
						array = null;
						obj = null;
						if (!flag10)
						{
							bool flag11 = (nint)obj12 < array2.Length;
							object obj17 = !flag11;
							num4 = num3;
							num6 = num5;
							num = num7;
							num2 = num8;
							array4 = null;
							obj11 = null;
							if (obj17 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v11 (System.Boolean[])+v198 @ X25_v13]");
							bool flag12 = (byte)(~(nuint)0u) != 0;
							num4 = num3;
							num6 = num5;
							num = num7;
							array = null;
							obj = null;
							if (!flag12)
							{
								bool flag13 = (object)copied == null;
								num4 = num3;
								num6 = num5;
								num = num7;
								num2 = num8;
								num10 = num9;
								num12 = num11;
								num14 = num13;
								num16 = num15;
								transform = transform2;
								array = null;
								obj = null;
								if (!flag13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB90]");
									object obj18 = 0;
									transform = (Transform)obj18;
									Dictionary<Transform, Transform> dictionary = copied;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
									if (((Dictionary<System.__Canon, System.__Canon>)(object)dictionary).TryGetValue((System.__Canon)0, out value))
									{
										bool flag14 = array6 == null;
										num4 = num3;
										num6 = num5;
										num = num7;
										num2 = num8;
										num10 = num9;
										num12 = num11;
										num14 = num13;
										num16 = num15;
										array = (Transform[])(&value);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
										obj = (UnityEngine.Object)0;
										if (!flag14)
										{
											bool flag15 = value == null;
											object obj19 = !flag15;
											array = (Transform[])(&value);
											_Canon = value;
											if (obj19 != null)
											{
												goto IL_06eb;
											}
											array4 = (Transform[])(&value);
											_Canon2 = value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
											obj11 = (UnityEngine.Object)0;
											goto IL_078a;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
										bool flag16 = (nint)0 == 0;
										num4 = num3;
										num6 = num5;
										num = num7;
										num2 = num8;
										num10 = num9;
										num12 = num11;
										num14 = num13;
										num16 = num15;
										array = (Transform[])(&value);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
										obj = (UnityEngine.Object)0;
										if (!flag16)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
											if (((Transform)0).IsChildOf(end))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
												Transform transform3 = CopyUnderHand((Transform)0);
												bool flag17 = array6 == null;
												num4 = num3;
												num6 = num5;
												num = num7;
												num2 = num8;
												num10 = num9;
												num12 = num11;
												num14 = num13;
												num16 = num15;
												array = null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
												obj = (UnityEngine.Object)0;
												if (!flag17)
												{
													bool flag18 = (object)transform3 == null;
													array = null;
													_Canon = (System.__Canon)(object)transform3;
													array4 = null;
													_Canon2 = (System.__Canon)(object)transform3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
													obj11 = (UnityEngine.Object)0;
													if (!flag18)
													{
														goto IL_06eb;
													}
													goto IL_078a;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
												string text = ((UnityEngine.Object)0).name;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
												object obj20 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												gameObject._002Ector(text);
												bool flag19 = (object)gameObject == null;
												num4 = num3;
												num6 = num5;
												num = num7;
												num2 = num8;
												num10 = num9;
												num12 = num11;
												num14 = num13;
												num16 = num15;
												array = null;
												obj = (UnityEngine.Object)(object)text;
												if (!flag19)
												{
													gameObject.layer = 2;
													Transform transform4 = gameObject.transform;
													Transform[] array7 = links;
													bool flag20 = links == null;
													num4 = num3;
													num6 = num5;
													num = num7;
													num2 = num8;
													num10 = num9;
													num12 = num11;
													num14 = num13;
													num16 = num15;
													array = null;
													obj = null;
													if (!flag20)
													{
														bool flag21 = array7.Length == 0;
														num4 = num3;
														num6 = num5;
														num = num7;
														num2 = num8;
														transform2 = (Transform)obj18;
														array4 = null;
														obj11 = null;
														if (flag21)
														{
															break;
														}
														bool flag22 = (object)transform4 == null;
														num4 = num3;
														num6 = num5;
														num = num7;
														num2 = num8;
														num10 = num9;
														num12 = num11;
														num14 = num13;
														num16 = num15;
														array = null;
														obj = null;
														if (!flag22)
														{
															transform4.SetParent(array7[0], worldPositionStays: false);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
															Vector3 position = ((Transform)0).position;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
															Quaternion rotation = ((Transform)0).rotation;
															transform4.SetPositionAndRotation((Vector3)0, (Quaternion)0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
															object obj21 = 0;
															object obj22 = obj21;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
															object obj23 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v60+A0]");
															object obj24 = 0;
															object obj25 = obj23;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v85+E4]");
															bool flag23 = (nint)0 == 0;
															object obj26 = !flag23;
															if (obj26 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
															float num17 = Size((Transform)0);
															float num18 = num17 / sizeUp;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v61+C]");
															num2 = 0f * num18;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v61+10]");
															num = 0f * num18;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v61+14]");
															num6 = 0f * num18;
															transform4.localScale = (Vector3)0;
															bool flag24 = (object)copied == null;
															num4 = num8;
															num10 = num3;
															num12 = num3;
															num14 = num5;
															num16 = num7;
															transform = null;
															array = null;
															obj = null;
															if (!flag24)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB68]");
																object obj27 = 0;
																transform = (Transform)obj27;
																Dictionary<Transform, Transform> dictionary2 = copied;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
																((Dictionary<System.__Canon, System.__Canon>)(object)dictionary2).set_Item((System.__Canon)0, (System.__Canon)(object)transform4);
																bool flag25 = array6 == null;
																num4 = num8;
																num10 = num3;
																num12 = num3;
																num14 = num5;
																num16 = num7;
																array = (Transform[])(object)transform4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bones @ X2 (UnityEngine.Transform[])+v194 @ X23_v7]");
																obj = (UnityEngine.Object)0;
																if (!flag25)
																{
																	nint num19 = (nint)array6;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v64 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																	obj = (UnityEngine.Object)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																	bool flag26 = ex == null;
																	num4 = num8;
																	num10 = num3;
																	num12 = num3;
																	num14 = num5;
																	num16 = num7;
																	array = (Transform[])(object)transform4;
																	if (flag26)
																	{
																		goto IL_13ac;
																	}
																	bool flag27 = (nint)obj12 < array6.Length;
																	object obj28 = !flag27;
																	num4 = num8;
																	num9 = num3;
																	num11 = num3;
																	num13 = num5;
																	num15 = num7;
																	transform2 = (Transform)obj27;
																	array4 = (Transform[])(object)transform4;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v64 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																	obj11 = (UnityEngine.Object)0;
																	if (obj28 != null)
																	{
																		break;
																	}
																	object obj29 = (object)array6 + obj9;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	num4 = num8;
																	num8 = num2;
																	num9 = num3;
																	num11 = num3;
																	num13 = num5;
																	num15 = num7;
																	transform2 = (Transform)obj27;
																	array = (Transform[])(object)transform4;
																	obj = transform4;
																	skinnedMeshRenderer2 = from;
																	array5 = materials;
																	goto IL_1407;
																}
															}
														}
													}
												}
											}
										}
									}
								}
								goto IL_139e;
							}
						}
					}
					goto IL_1407;
					IL_06eb:
					nint num20 = (nint)array6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v50 (Il2CppClass<UnityEngine.Transform[]>)+40]");
					obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag28 = ex == null;
					array4 = array;
					_Canon2 = _Canon;
					num4 = num3;
					num6 = num5;
					num = num7;
					num2 = num8;
					num10 = num9;
					num12 = num11;
					num14 = num13;
					num16 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v50 (Il2CppClass<UnityEngine.Transform[]>)+40]");
					obj = (UnityEngine.Object)0;
					if (!flag28)
					{
						goto IL_078a;
					}
					goto IL_13ac;
					IL_1407:
					obj8 = bones.Length;
					obj4 = obj10 - 31;
					obj10++;
					obj9 += 8;
					bool flag29 = (nint)obj4 < bones.Length;
					num2 = num8;
					num10 = num9;
					num12 = num11;
					num14 = num13;
					num16 = num15;
					transform = transform2;
					skinnedMeshRenderer = skinnedMeshRenderer2;
					array3 = array5;
					num3 = num4;
					num5 = num6;
					num7 = num;
					array4 = array;
					obj11 = obj;
					if (flag29)
					{
						continue;
					}
					goto IL_0d54;
					IL_078a:
					bool flag30 = (nint)obj12 < array6.Length;
					object obj30 = !flag30;
					num4 = num3;
					num6 = num5;
					num = num7;
					num2 = num8;
					transform2 = transform;
					if (obj30 != null)
					{
						break;
					}
					object obj31 = (object)array6 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num4 = num3;
					num6 = num5;
					num = num7;
					transform2 = transform;
					array = array4;
					obj = (UnityEngine.Object)(object)_Canon2;
					goto IL_1407;
				}
				goto IL_1358;
			}
		}
		goto IL_139e;
		IL_101a:
		GameObject gameObject2 = base.gameObject;
		bool flag31 = (object)gameObject2 == null;
		obj = null;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj33 = this + 72;
			UnityEngine.Object obj34 = default;
			obj33 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag32 = obj33 == null;
			obj = obj34;
			if (!flag32)
			{
				((SkinnedMeshRenderer)obj33).sharedMesh = sharedMesh;
				bool flag33 = obj33 == null;
				array = null;
				obj = sharedMesh;
				if (!flag33)
				{
					((Renderer)obj33).sharedMaterials = array3;
					bool flag34 = obj33 == null;
					array = null;
					obj = (UnityEngine.Object)(object)array3;
					if (!flag34)
					{
						((SkinnedMeshRenderer)obj33).bones = array6;
						Transform[] array8 = links;
						bool flag35 = links == null;
						array = null;
						obj = (UnityEngine.Object)(object)array6;
						if (!flag35)
						{
							bool flag36 = array8.Length == 0;
							num9 = num10;
							num11 = num12;
							num13 = num14;
							num15 = num16;
							transform2 = transform;
							array4 = null;
							obj11 = (UnityEngine.Object)(object)array6;
							if (flag36)
							{
								goto IL_1358;
							}
							bool flag37 = (object)skin == null;
							array = null;
							obj = (UnityEngine.Object)(object)array6;
							if (!flag37)
							{
								skin.rootBone = array8[0];
								bool flag38 = obj33 == null;
								array = null;
								obj = array8[0];
								if (!flag38)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj35 = 0;
									object obj36 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v25+A0]");
									object obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v26+C]");
									object obj39 = default;
									object obj38 = 0 * obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v26+14]");
									float num21 = 0f * reach;
									object obj40 = obj38 + obj38;
									float num22 = num21 + num21;
									num2 = (float)obj40 * 63f;
									num = num22 * 0.5f;
									object obj41 = default;
									((Renderer)obj33).localBounds = (Bounds)(&obj41);
									ShadowCastingMode shadowCastingMode = skinnedMeshRenderer.shadowCastingMode;
									bool flag39 = obj33 == null;
									double num4 = 0.5;
									float num6 = 63f;
									array = null;
									obj = null;
									if (!flag39)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
										object obj42 = 0;
										((Renderer)obj33).shadowCastingMode = shadowCastingMode;
										object obj43 = obj42;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v33+E4]");
										bool flag40 = (nint)0 == 0;
										object obj44 = !flag40;
										if (obj44 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaSplatter.CarryOver(skinnedMeshRenderer, (Renderer)obj33);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_139e;
		IL_0d54:
		if (array6 != null)
		{
			if (array6.Length < 1)
			{
				goto IL_101a;
			}
			object obj45 = array6 + 32;
			object obj46 = array6.Length & 0xFFFFFFFFL;
			array4 = array;
			object obj47 = 0;
			while (true)
			{
				bool flag41 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46);
				object obj48 = !flag41;
				num9 = num10;
				num11 = num12;
				num13 = num14;
				num15 = num16;
				transform2 = transform;
				obj11 = obj;
				if (obj48 != null)
				{
					break;
				}
				object obj49 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v44+E4]");
				bool flag42 = (nint)0 == 0;
				object obj50 = !flag42;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag43 = (UnityEngine.Object)obj45 == null;
				bool flag44 = !flag43;
				obj = null;
				if (!flag44)
				{
					Transform[] array9 = links;
					bool flag45 = links == null;
					array = null;
					obj = null;
					if (flag45)
					{
						goto IL_139e;
					}
					bool flag46 = array9.Length == 0;
					num9 = num10;
					num11 = num12;
					num13 = num14;
					num15 = num16;
					transform2 = transform;
					array4 = null;
					obj11 = null;
					if (flag46)
					{
						break;
					}
					bool flag47 = (object)array9[0] == null;
					obj11 = null;
					if (!flag47)
					{
						nint num23 = (nint)array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v38 (Il2CppClass<UnityEngine.Transform[]>)+40]");
						obj11 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag48 = ex == null;
						array = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v38 (Il2CppClass<UnityEngine.Transform[]>)+40]");
						obj = (UnityEngine.Object)0;
						if (flag48)
						{
							goto IL_13ac;
						}
					}
					bool flag49 = (nint)obj47 < array6.Length;
					object obj51 = !flag49;
					num9 = num10;
					num11 = num12;
					num13 = num14;
					num15 = num16;
					transform2 = transform;
					array4 = null;
					if (obj51 != null)
					{
						break;
					}
					obj45 = array9[0];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj = array9[0];
				}
				obj46 = array6.Length;
				obj47++;
				obj45 += 8;
				bool flag50 = (nint)obj47 < array6.Length;
				array = null;
				array4 = null;
				if (flag50)
				{
					continue;
				}
				goto IL_101a;
			}
			goto IL_1358;
		}
		goto IL_139e;
		IL_1358:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		num10 = num9;
		num12 = num11;
		num14 = num13;
		num16 = num15;
		transform = transform2;
		array = array4;
		obj = obj11;
		goto IL_139e;
		IL_139e:
		ex = new NullReferenceException();
		goto IL_13ac;
		IL_13ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private Transform CopyUnderHand(Transform bone)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_016a: Expected VT, but got I4
		//IL_016a: Expected VT, but got I4
		//IL_018a: Expected VT, but got I4
		if ((object)copied != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB90]");
			object obj = 0;
			if (((Dictionary<System.__Canon, System.__Canon>)(object)copied).TryGetValue((System.__Canon)(object)bone, out System.__Canon value))
			{
				return (Transform)(object)value;
			}
			if ((object)bone != null)
			{
				string text = bone.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GameObject gameObject = default;
				gameObject._002Ector(text);
				if ((object)gameObject != null)
				{
					gameObject.layer = 2;
					Transform transform = gameObject.transform;
					Transform parent = bone.parent;
					Transform parent2 = CopyUnderHand(parent);
					if ((object)transform != null)
					{
						transform.SetParent(parent2, worldPositionStays: false);
						Vector3 localPosition = bone.localPosition;
						Quaternion localRotation = bone.localRotation;
						transform.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
						Vector3 localScale = bone.localScale;
						transform.localScale = (Vector3)0;
						if ((object)copied != null)
						{
							((Dictionary<System.__Canon, System.__Canon>)(object)copied).set_Item((System.__Canon)(object)bone, (System.__Canon)(object)transform);
							return transform;
						}
					}
				}
			}
		}
		return (Transform)(object)new NullReferenceException();
	}

	private static bool[] SkinnedOn(Mesh mesh)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
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
		System.__Canon _Canon = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB98]");
			object obj5 = 0;
			if (((Dictionary<System.__Canon, System.__Canon>)obj4).TryGetValue((System.__Canon)(object)mesh, out System.__Canon value))
			{
				return (bool[])(object)value;
			}
			if ((object)mesh != null)
			{
				int bindposeCount = mesh.bindposeCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				NativeArray<BoneWeight1> allBoneWeights = mesh.GetAllBoneWeights();
				if (0 < 1)
				{
					goto IL_019e;
				}
				object obj7 = allBoneWeights + 4;
				object obj8 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X10_v6-4]");
					if ((nint)0 > (nint)0)
					{
						if (_Canon == null)
						{
							break;
						}
						object obj9 = obj7;
						object obj10 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15 (System.__Canon)+18]");
						if ((nint)obj10 < 0)
						{
							object obj11 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15 (System.__Canon)+18]");
							bool flag2 = (nint)obj11 < 0;
							object obj12 = !flag2;
							if (obj12 != null)
							{
								goto IL_021f;
							}
							obj9 = (object)_Canon + obj9;
							_ = 1;
						}
					}
					obj8--;
					obj7 += 8;
					if ((nint)obj8 != 1)
					{
						continue;
					}
					goto IL_019e;
				}
			}
		}
		goto IL_0211;
		IL_019e:
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v19+A0]");
		object obj15 = 0;
		if (obj15 != null)
		{
			((Dictionary<System.__Canon, System.__Canon>)obj15).set_Item((System.__Canon)(object)mesh, _Canon);
			return (bool[])(object)_Canon;
		}
		goto IL_0211;
		IL_0211:
		NullReferenceException ex = new NullReferenceException();
		goto IL_021f;
		IL_021f:
		return (bool[])(object)new IndexOutOfRangeException();
	}

	public void TakeGore(Transform gore, Transform on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(on != null))
		{
			goto IL_00de;
		}
		bool worldPositionStays;
		Transform parent;
		Transform transform;
		if ((object)copied != null)
		{
			if (!((Dictionary<System.__Canon, System.__Canon>)(object)copied).TryGetValue((System.__Canon)(object)on, out System.__Canon value))
			{
				goto IL_00de;
			}
			if ((object)gore != null)
			{
				worldPositionStays = false;
				parent = (Transform)(object)value;
				transform = gore;
				goto IL_02f5;
			}
		}
		goto IL_02a8;
		IL_00de:
		Transform[] array = links;
		if (links == null || (object)gore == null)
		{
			goto IL_02a8;
		}
		parent = array[0];
		worldPositionStays = true;
		transform = gore;
		goto IL_02f5;
		IL_02a8:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_02f5:
		transform.SetParent(parent, worldPositionStays);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBA8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj6 = default;
		object obj5 = obj6 & 1;
		if (obj5 == null)
		{
			return;
		}
		GillaWoundBend gillaWoundBend = default;
		if ((object)gillaWoundBend != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(gillaWoundBend.other != null))
			{
				return;
			}
			if ((object)gillaWoundBend != null && (object)copied != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB90]");
				object obj9 = 0;
				object key = gillaWoundBend + 32;
				bool flag3 = ((Dictionary<System.__Canon, System.__Canon>)(object)copied).TryGetValue((System.__Canon)key, out System.__Canon value2);
				bool flag4 = !flag3;
				object obj10 = !flag4;
				object obj11 = ~obj10;
				System.__Canon _Canon = ((obj11 != null) ? null : value2);
				key = _Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)gillaWoundBend != null)
				{
					gillaWoundBend.Bend();
					return;
				}
			}
		}
		goto IL_02a8;
	}

	public void Ignore(Collider other)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I8
		//IL_00ac: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = other == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		CapsuleCollider[] array = shapes;
		if (array.Length < 1)
		{
			return;
		}
		object obj5 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj6 = 0;
		object obj7 = array + 32;
		object obj8 = 0;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			object obj11 = !flag4;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X25_v4+v133 @ X23_v5*8]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			obj9 = 0;
			obj10 = null;
			if (!flag7)
			{
				object obj14 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v16+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X25_v4+v133 @ X23_v5*8]");
				Physics.IgnoreCollision((Collider)0, other);
				obj9 = 0;
				obj10 = other;
			}
			obj5 = array.Length;
			obj8++;
			if ((nint)obj8 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public unsafe int Nearest(Vector3 at, out float away)
	{
		//IL_040f: Expected Obj, but got I
		//IL_0418: Expected native int or pointer, but got VT
		//IL_042d: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I4
		//IL_03ff: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_00bc: Expected VT, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_016e: Expected VT, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_024a: Expected VT, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02e5: Expected VT, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I4
		//IL_03a7: Expected VT, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected I4, but got Unknown
		//IL_03cb: Expected native int or pointer, but got VT
		//IL_03d9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		((Vector3*)(nint)at)->x = 3.4028235E+38f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = 4;
		object obj5 = default;
		object obj4 = obj5;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		Vector3 vector = at;
		int result = 0;
		while (true)
		{
			CapsuleCollider[] array = shapes;
			if (shapes != null)
			{
				object obj6 = obj3 - 4;
				bool flag = (nint)obj6 < array.Length;
				object obj7 = !flag;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v5 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
				bool flag3 = (UnityEngine.Object)0 == null;
				bool flag4 = !flag3;
				object obj10 = !flag4;
				vector = (Vector3)0;
				if (obj10 != null)
				{
					goto IL_0464;
				}
				CapsuleCollider[] array2 = shapes;
				if (shapes != null)
				{
					bool flag5 = (nint)obj6 < array2.Length;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v9 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v9 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
						bool flag6 = ((Collider)0).enabled;
						bool flag7 = !flag6;
						vector = (Vector3)0;
						if (flag7)
						{
							goto IL_0464;
						}
						CapsuleCollider[] array3 = shapes;
						if (shapes != null)
						{
							bool flag8 = (nint)obj6 < array3.Length;
							object obj12 = !flag8;
							if (obj12 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v10 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v10 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
								GameObject gameObject = ((Component)0).gameObject;
								if ((object)gameObject != null)
								{
									bool activeInHierarchy = gameObject.activeInHierarchy;
									bool flag9 = !activeInHierarchy;
									vector = (Vector3)0;
									if (flag9)
									{
										goto IL_0464;
									}
									CapsuleCollider[] array4 = shapes;
									if (shapes != null)
									{
										bool flag10 = (nint)obj6 < array4.Length;
										object obj13 = !flag10;
										if (obj13 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v11 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v11 (UnityEngine.CapsuleCollider[])+v75 @ X25_v2*8]");
											Vector3 vector2 = ((Collider)0).ClosestPoint((Vector3)0);
											object obj14 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v21+E4]");
											bool flag11 = (nint)0 == 0;
											object obj15 = !flag11;
											if (obj15 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num5 = num4 - num4;
											float num6 = num2 - num2;
											obj4 = obj5 - obj5;
											float num7 = num5 * num5;
											float num8 = num6 * num6;
											float num9 = num7 + num8;
											object obj16 = obj4 * obj4;
											num3 = (float)obj16 + num9;
											num = at.x;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											bool flag12 = !(num3 < at.x);
											vector = (Vector3)0;
											if (!flag12)
											{
												result = obj3 - 4;
												((Vector3*)(nint)at)->x = num3;
												vector = (Vector3)0;
											}
											goto IL_0464;
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0464:
			obj3++;
			if ((nint)obj3 == 7)
			{
				return result;
			}
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	public void AddMeshes(List<MeshFilter> to)
	{
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0166: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBB8]");
		object obj3 = 0;
		object obj4 = 5;
		List<MeshFilter> list = to;
		IEnumerable<System.__Canon> enumerable = default;
		while (true)
		{
			Transform[] array = links;
			if (links != null)
			{
				object obj5 = obj4 - 4;
				bool flag = (nint)obj5 < array.Length;
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v4 (UnityEngine.Transform[])+v61 @ X25_v2*8]");
				bool flag3 = (UnityEngine.Object)0 != null;
				bool flag4 = !flag3;
				nint num = unchecked((nint)null);
				list = null;
				if (flag4)
				{
					goto IL_0180;
				}
				Transform[] array2 = links;
				if (links != null)
				{
					bool flag5 = (nint)obj5 < array2.Length;
					object obj9 = !flag5;
					if (obj9 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8 (UnityEngine.Transform[])+v61 @ X25_v2*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
						if ((object)to != null)
						{
							num = (nint)obj3;
							((List<System.__Canon>)(object)to).AddRange(enumerable);
							list = (List<MeshFilter>)enumerable;
							goto IL_0180;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0180:
			obj4++;
			if ((nint)obj4 == 7)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	public void CopyMaterials(Func<Material[], Material[]> copies)
	{
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_028e: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I4
		if ((object)skin != null)
		{
			Material[] sharedMaterials = skin.sharedMaterials;
			if (copies != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBC0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [copies @ X1 (System.Func`2<UnityEngine.Material[], UnityEngine.Material[]>)+18] (should have been resolved before IL gen)");
				Material[] array = default;
				skin.sharedMaterials = array;
				object obj3 = 0;
				object obj4 = 0;
				Material[] array2 = array;
				object obj11 = default;
				Material[] array5 = default;
				while (true)
				{
					Transform[] array3 = links;
					if (links == null)
					{
						break;
					}
					bool flag = (nint)obj3 < array3.Length;
					object obj5 = !flag;
					if (obj5 == null)
					{
						object obj6 = obj;
						object obj7 = (object)links + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v12+E4]");
						bool flag2 = (nint)0 == 0;
						object obj8 = !flag2;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v8+20]");
						bool flag3 = (UnityEngine.Object)0 != null;
						bool flag4 = !flag3;
						obj4 = 0;
						array2 = null;
						if (flag4)
						{
							goto IL_0311;
						}
						Transform[] array4 = links;
						if (links == null)
						{
							break;
						}
						bool flag5 = (nint)obj3 < array4.Length;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							object obj10 = (object)links + obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							array2 = (Material[])obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
							if (obj11 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v18+18]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v18+18]");
							bool flag6 = (nint)0 < (nint)1;
							obj4 = 0;
							if (flag6)
							{
								goto IL_0311;
							}
							object obj13 = obj11 + 32;
							object obj14 = 0;
							while (true)
							{
								bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
								object obj15 = !flag7;
								if (obj15 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X27_v4+v65 @ X26_v7*8]");
								if ((nint)0 == 0)
								{
									goto end_IL_039b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X27_v4+v65 @ X26_v7*8]");
								Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [copies @ X1 (System.Func`2<UnityEngine.Material[], UnityEngine.Material[]>)+18] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X27_v4+v65 @ X26_v7*8]");
								((Renderer)0).sharedMaterials = array5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v18+18]");
								obj12 = 0;
								object obj16 = obj14 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v18+18]");
								bool flag8 = (nint)obj16 < 0;
								obj4 = 0;
								array2 = array5;
								obj14 = obj16;
								if (flag8)
								{
									continue;
								}
								goto IL_0311;
							}
						}
					}
					goto IL_034e;
					IL_0311:
					obj3++;
					if ((nint)obj3 == 3)
					{
						return;
					}
					continue;
					end_IL_039b:
					break;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_034e;
		IL_034e:
		throw new IndexOutOfRangeException();
	}

	public unsafe void OutOfDoors()
	{
		//IL_00af: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_011b: Expected VT, but got Ref
		//IL_01c8: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f6: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_026f: Expected VT, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I
		//IL_038d: Expected VT, but got I4
		//IL_038d: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		Transform[] array = links;
		if (links != null && (object)array[0] != null)
		{
			Vector3 position = array[0].position;
			Transform[] array2 = links;
			if (links != null)
			{
				Bounds worldBox = WorldBox;
				Rigidbody[] array3 = bodies;
				if (bodies != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v10+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj4 = default;
					if (!GillaDoor.OutOfSlabs(array2[0], (Bounds)(&obj4), array3[0]))
					{
						return;
					}
					Transform[] array4 = links;
					if (links != null && (object)array4[0] != null)
					{
						Vector3 position2 = array4[0].position;
						object obj6 = default;
						object obj5 = obj6 - obj6;
						object obj8 = default;
						object obj7 = obj8 - obj8;
						object obj9 = 5;
						while (true)
						{
							Transform[] array5 = links;
							if (links == null)
							{
								break;
							}
							object obj10 = obj9 - 4;
							bool flag2 = (nint)obj10 < array5.Length;
							object obj11 = !flag2;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13 (UnityEngine.Transform[])+v128 @ X21_v7*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13 (UnityEngine.Transform[])+v128 @ X21_v7*8]");
								Vector3 position3 = ((Transform)0).position;
								obj6 = obj5 + obj6;
								obj8 = obj7 + obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13 (UnityEngine.Transform[])+v128 @ X21_v7*8]");
								((Transform)0).position = (Vector3)0;
								Rigidbody[] array6 = bodies;
								if (bodies == null)
								{
									break;
								}
								bool flag3 = (nint)obj10 < array6.Length;
								object obj12 = !flag3;
								if (obj12 == null)
								{
									Transform[] array7 = links;
									if (links == null)
									{
										break;
									}
									bool flag4 = (nint)obj10 < array7.Length;
									object obj13 = !flag4;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v14 (UnityEngine.Transform[])+v128 @ X21_v7*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v14 (UnityEngine.Transform[])+v128 @ X21_v7*8]");
										Vector3 position4 = ((Transform)0).position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v14 (UnityEngine.Rigidbody[])+v128 @ X21_v7*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v14 (UnityEngine.Rigidbody[])+v128 @ X21_v7*8]");
										((Rigidbody)0).position = (Vector3)0;
										obj9++;
										if ((nint)obj9 == 7)
										{
											return;
										}
										continue;
									}
								}
							}
							goto IL_03ca;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03ca;
		IL_03ca:
		throw new IndexOutOfRangeException();
	}

	public void Hold(int link, int by, bool right, Vector3 pos, Quaternion rot)
	{
		//IL_0358: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I4, but got Unknown
		//IL_03b7: Expected Obj, but got I4
		//IL_03f8: Expected I4, but got I8
		//IL_0412: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I
		//IL_030a: Expected VT, but got I4
		//IL_030a: Expected VT, but got I4
		//IL_0333: Expected VT, but got I4
		//IL_0333: Expected VT, but got I4
		object obj = link - 2;
		bool flag = (nint)obj < 0;
		int num = link ^ 2;
		int num2 = link ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		int num4 = ((obj3 != null) ? 2 : link);
		int num5 = ~num4;
		int num6 = num4 & num5;
		int num7 = (int)(held & 0x80000000L);
		bool flag4 = num7 == 0;
		object obj4 = !flag4;
		if (obj4 != null || held == num6)
		{
			goto IL_00e3;
		}
		Rigidbody[] array = bodies;
		if (bodies != null)
		{
			bool flag5 = held < array.Length;
			object obj5 = !flag5;
			if (obj5 != null)
			{
				goto IL_0343;
			}
			object obj6 = bodies + held;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v13+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v13+20]");
				((Rigidbody)0).isKinematic = false;
				goto IL_00e3;
			}
		}
		goto IL_0335;
		IL_00e3:
		held = num6;
		heldBy = by;
		heldRight = right;
		Rigidbody[] array2 = bodies;
		Vector3 vector = default;
		heldAt = vector;
		Quaternion quaternion = default;
		heldTurned = quaternion;
		heldRoll = 0f;
		if (bodies != null)
		{
			bool flag6 = num6 < array2.Length;
			object obj7 = !flag6;
			if (obj7 != null)
			{
				goto IL_0343;
			}
			object obj8 = bodies + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v10+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v10+20]");
				((Rigidbody)0).isKinematic = true;
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v8+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform = GillaCorpse.Hand(by, right);
				object obj13 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v12+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(transform != null))
				{
					return;
				}
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Quaternion rotation = transform.rotation;
					Vector3 vector2 = (Quaternion)0 * (Vector3)0;
					Quaternion rotation2 = transform.rotation;
					Put(num6, (Vector3)0, (Quaternion)right);
					return;
				}
			}
		}
		goto IL_0335;
		IL_0343:
		throw new IndexOutOfRangeException();
		IL_0335:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0343;
	}

	public void LetGo(Vector3 at, Quaternion rot, Vector3 velocity, Vector3 spin)
	{
		//IL_0029: Expected I4, but got I8
		//IL_007f: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I
		//IL_00ed: Expected VT, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0108: Expected VT, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		int num = ~held;
		int num2 = held & num;
		held = -1;
		Put(num2, (Vector3)rot, (Quaternion)velocity);
		Rigidbody[] array = bodies;
		if (bodies != null)
		{
			bool flag = num2 < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_01c1;
			}
			object obj2 = bodies + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+20]");
				((Rigidbody)0).isKinematic = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+20]");
				((Rigidbody)0).linearVelocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+20]");
				((Rigidbody)0).angularVelocity = (Vector3)0;
				object obj3 = 0;
				while (true)
				{
					Rigidbody[] array2 = bodies;
					if (bodies == null)
					{
						break;
					}
					bool flag2 = (nint)obj3 < array2.Length;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						object obj5 = (object)bodies + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v9+20]");
						((Rigidbody)0).WakeUp();
						obj3++;
						if ((nint)obj3 == 3)
						{
							return;
						}
						continue;
					}
					goto IL_01c1;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c1;
		IL_01c1:
		throw new IndexOutOfRangeException();
	}

	public void Place(int link, Vector3 at, Quaternion rot)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected I4, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02e2: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0155: Expected VT, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I4
		//IL_01f1: Expected VT, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_03bf: Expected VT, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0403: Expected Obj, but got I4
		//IL_028d: Expected VT, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_0431: Expected VT, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I4
		//IL_04b9: Expected Obj, but got I
		object obj = link - 2;
		bool flag = (nint)obj < 0;
		int num = link ^ 2;
		int num2 = link ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		int num4 = ((obj3 != null) ? 2 : link);
		if (link > 0)
		{
			Transform[] array = links;
			if (links != null)
			{
				int num5 = ~num4;
				int num6 = num4 & num5;
				bool flag4 = num6 < array.Length;
				object obj4 = !flag4;
				if (obj4 != null)
				{
					goto IL_04fb;
				}
				object obj5 = links + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v16+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v16+20]");
					((Transform)0).SetPositionAndRotation((Vector3)0, (Quaternion)at);
					Rigidbody[] array2 = bodies;
					if (bodies != null)
					{
						bool flag5 = num6 < array2.Length;
						object obj6 = !flag5;
						if (obj6 != null)
						{
							goto IL_04fb;
						}
						object obj7 = bodies + num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v18+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v18+20]");
							((Rigidbody)0).position = (Vector3)0;
							Rigidbody[] array3 = bodies;
							if (bodies != null)
							{
								bool flag6 = num6 < array3.Length;
								object obj8 = !flag6;
								if (obj8 != null)
								{
									goto IL_04fb;
								}
								object obj9 = bodies + num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+20]");
									((Rigidbody)0).rotation = (Quaternion)0;
									goto IL_02aa;
								}
							}
						}
					}
				}
			}
			goto IL_04ed;
		}
		Put(0, at, rot);
		goto IL_02aa;
		IL_02aa:
		object obj10 = 4;
		while (true)
		{
			Rigidbody[] array4 = bodies;
			if (bodies == null)
			{
				break;
			}
			object obj11 = obj10 - 4;
			bool flag7 = (nint)obj11 < array4.Length;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v6 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v6 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
				bool isKinematic = ((Rigidbody)0).isKinematic;
				bool flag8 = !isKinematic;
				object obj13 = !flag8;
				if (obj13 != null)
				{
					goto IL_04be;
				}
				Rigidbody[] array5 = bodies;
				if (bodies == null)
				{
					break;
				}
				bool flag9 = (nint)obj11 < array5.Length;
				object obj14 = !flag9;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
					((Rigidbody)0).linearVelocity = (Vector3)0;
					Rigidbody[] array6 = bodies;
					if (bodies == null)
					{
						break;
					}
					bool flag10 = (nint)obj11 < array6.Length;
					object obj15 = !flag10;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v11 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v11 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
						((Rigidbody)0).angularVelocity = (Vector3)0;
						Rigidbody[] array7 = bodies;
						if (bodies == null)
						{
							break;
						}
						bool flag11 = (nint)obj11 < array7.Length;
						object obj16 = !flag11;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (UnityEngine.Rigidbody[])+v113 @ X22_v4*8]");
							((Rigidbody)0).Sleep();
							goto IL_04be;
						}
					}
				}
			}
			goto IL_04fb;
			IL_04be:
			obj10++;
			if ((nint)obj10 == 7)
			{
				return;
			}
		}
		goto IL_04ed;
		IL_04ed:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04fb;
		IL_04fb:
		throw new IndexOutOfRangeException();
	}

	private void Put(int link, Vector3 at, Quaternion turned)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_023f: Expected VT, but got I4
		//IL_023f: Expected VT, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I
		//IL_02fd: Expected VT, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_0439: Expected VT, but got I4
		//IL_0439: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I4
		//IL_0531: Expected Obj, but got I
		//IL_0570: Expected VT, but got I4
		//IL_0570: Expected Obj, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		Transform[] array = links;
		if (links != null)
		{
			bool flag = array.Length < link;
			object obj = !flag;
			object obj2 = array.Length - link;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_05ad;
			}
			object obj5 = links + link;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v4+20]");
				Vector3 position = ((Transform)0).position;
				Transform[] array2 = links;
				if (links != null)
				{
					bool flag3 = array2.Length < link;
					object obj6 = !flag3;
					object obj7 = array2.Length - link;
					bool flag4 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag4;
					if (obj9 != null)
					{
						goto IL_05ad;
					}
					object obj10 = links + link;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v6+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v6+20]");
						Quaternion rotation = ((Transform)0).rotation;
						Quaternion rotation2 = default;
						Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
						object obj11 = 0;
						while (true)
						{
							Transform[] array3 = links;
							if (links == null)
							{
								break;
							}
							bool flag5 = (nint)obj11 < array3.Length;
							object obj12 = !flag5;
							if (obj12 == null)
							{
								object obj13 = (object)links + obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+20]");
								Vector3 position2 = ((Transform)0).position;
								Vector3 vector = (Quaternion)0 * (Vector3)0;
								Transform[] array4 = links;
								if (links == null)
								{
									break;
								}
								bool flag6 = (nint)obj11 < array4.Length;
								object obj14 = !flag6;
								if (obj14 == null)
								{
									object obj15 = (object)links + obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11+20]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v11+20]");
									Quaternion rotation3 = ((Transform)0).rotation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+20]");
									((Transform)0).SetPositionAndRotation((Vector3)0, (Quaternion)at);
									Rigidbody[] array5 = bodies;
									if (bodies == null)
									{
										break;
									}
									bool flag7 = (nint)obj11 < array5.Length;
									object obj16 = !flag7;
									if (obj16 == null)
									{
										Transform[] array6 = links;
										if (links == null)
										{
											break;
										}
										bool flag8 = (nint)obj11 < array6.Length;
										object obj17 = !flag8;
										if (obj17 == null)
										{
											object obj18 = (object)links + obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v10+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											object obj19 = (object)bodies + obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v10+20]");
											Vector3 position3 = ((Transform)0).position;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v13+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v13+20]");
											((Rigidbody)0).position = (Vector3)0;
											Rigidbody[] array7 = bodies;
											if (bodies == null)
											{
												break;
											}
											bool flag9 = (nint)obj11 < array7.Length;
											object obj20 = !flag9;
											if (obj20 == null)
											{
												Transform[] array8 = links;
												if (links == null)
												{
													break;
												}
												bool flag10 = (nint)obj11 < array8.Length;
												object obj21 = !flag10;
												if (obj21 == null)
												{
													object obj22 = (object)links + obj11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v13+20]");
													if ((nint)0 == 0)
													{
														break;
													}
													object obj23 = (object)bodies + obj11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v13+20]");
													Quaternion rotation4 = ((Transform)0).rotation;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+20]");
													if ((nint)0 == 0)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v15+20]");
													((Rigidbody)0).rotation = (Quaternion)0;
													obj11++;
													if ((nint)obj11 == 3)
													{
														return;
													}
													continue;
												}
											}
										}
									}
								}
							}
							goto IL_05ad;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ad;
		IL_05ad:
		throw new IndexOutOfRangeException();
	}

	private void Update()
	{
		//IL_05f3: Expected I4, but got I8
		//IL_060d: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0238: Expected VT, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I
		//IL_037c: Invalid comparison between Obj and F8
		//IL_03a8: Expected VT, but got I4
		//IL_03f3: Expected Obj, but got I4
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_044d: Expected VT, but got I4
		//IL_044d: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04ef: Expected VT, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I
		int num = (int)(held & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = !heldRight;
		bool right = !flag3;
		Transform transform = GillaCorpse.Hand(heldBy, right);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = transform == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Quaternion rotation2 = transform.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
			object obj10 = default;
			object obj11 = default;
			object obj9 = obj10 * obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			object obj13 = default;
			object obj12 = obj13 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj15 = default;
			object obj14 = obj12 + obj15;
			object obj16 = obj10 * heldTurned;
			object obj17 = obj14 - obj16;
			float deltaTime = Time.deltaTime;
			float dt = default;
			Quaternion quaternion = Rolled((Quaternion)0, dt);
			Transform[] array = links;
			if (links != null)
			{
				bool flag7 = held < array.Length;
				object obj18 = !flag7;
				if (obj18 != null)
				{
					goto IL_05d8;
				}
				object obj19 = links + held;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v12+20]");
				if ((nint)0 != 0)
				{
					object obj20 = obj10 + obj10;
					object obj21 = obj15 + obj15;
					object obj23 = default;
					object obj22 = obj23 + obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v12+20]");
					Vector3 position2 = ((Transform)0).position;
					object obj24 = obj21 - obj23;
					object obj26 = default;
					object obj25 = obj22 - obj26;
					object obj27 = obj20 - obj17;
					object obj28 = obj24 * obj24;
					object obj29 = obj25 * obj25;
					object obj30 = obj28 + obj29;
					object obj31 = obj27 * obj27;
					object obj32 = obj31 + obj30;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
					{
						Quaternion turned = default;
						Put(held, (Vector3)0, turned);
					}
					Rigidbody[] array2 = bodies;
					if (bodies != null)
					{
						bool flag8 = held < array2.Length;
						object obj33 = !flag8;
						if (obj33 != null)
						{
							goto IL_05d8;
						}
						object obj34 = bodies + held;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v14+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v14+20]");
							((Rigidbody)0).MovePosition((Vector3)0);
							Rigidbody[] array3 = bodies;
							if (bodies != null)
							{
								bool flag9 = held < array3.Length;
								object obj35 = !flag9;
								if (obj35 != null)
								{
									goto IL_05d8;
								}
								object obj36 = bodies + held;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v16+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v16+20]");
									((Rigidbody)0).MoveRotation((Quaternion)0);
									object obj37 = 0;
									while (true)
									{
										if ((nint)obj37 != held)
										{
											Rigidbody[] array4 = bodies;
											if (bodies == null)
											{
												break;
											}
											bool flag10 = (nint)obj37 < array4.Length;
											object obj38 = !flag10;
											if (obj38 != null)
											{
												goto IL_05d8;
											}
											object obj39 = (object)bodies + obj37;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v21+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v21+20]");
											((Rigidbody)0).WakeUp();
										}
										obj37++;
										if ((nint)obj37 == 3)
										{
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
		NullReferenceException ex = new NullReferenceException();
		goto IL_05d8;
		IL_05d8:
		throw new IndexOutOfRangeException();
	}

	private Quaternion Rolled(Quaternion turned, float dt)
	{
		//IL_018c: Expected Obj, but got I
		//IL_019a: Expected VT, but got I4
		//IL_0027: Expected VT, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected F4, but got I
		//IL_01db: Expected F4, but got I
		//IL_01eb: Expected F4, but got I
		//IL_0359: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_03a4: Expected F4, but got Obj
		//IL_03ac: Invalid comparison between F4 and Obj
		//IL_03d8: Expected Obj, but got I
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0589: Invalid comparison between F4 and I
		//IL_0248: Expected VT, but got I4
		//IL_0248: Expected VT, but got I4
		Quaternion result;
		if (held == 2)
		{
			result = (Quaternion)this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			Vector3 vector = (Quaternion)0 * (Vector3)turned;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v9+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+24]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+28]");
			float num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+2C]");
			float num3 = 0f;
			float num4 = dt * dt;
			object obj5 = default;
			object obj4 = obj5 * obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj6 = 0;
			object obj7 = obj6;
			float num5 = num4 + (float)obj4;
			object obj9 = default;
			object obj8 = obj9 * obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+A0]");
			object obj10 = 0;
			float num6 = (float)obj8 + num5;
			float num7 = (float)obj10;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				float num8 = dt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+24]");
				float num9 = num8 * 0f;
				float num10 = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+28]");
				float num11 = num10 * 0f;
				float num12 = (float)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v10+2C]");
				float num13 = num12 * 0f;
				float num14 = num9 + num11;
				float num15 = num13 + num14;
				float num16 = num15 / num6;
				num7 = dt * num16;
				float num17 = (float)obj5 * num16;
				float num18 = (float)obj9 * num16;
				num -= num7;
				num2 -= num17;
				num3 -= num18;
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18+A0]");
			object obj12 = 0;
			Vector3 axis = default;
			result = Quaternion.Internal_AngleAxis(heldRoll, ref axis);
			object obj13 = default;
			float num19 = (float)obj13 * heldRoll;
			float num20 = dt * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v19+20]");
			object obj14 = obj13 * 0;
			float num21 = (float)obj5 * num7;
			float num22 = num * num;
			float num23 = num2 * num2;
			object obj15 = obj13 * obj9;
			float num24 = (float)obj9 * num7;
			float num25 = num19 + num20;
			object obj16 = obj5 * obj9;
			float num26 = (float)obj14 + num21;
			float num27 = (float)obj9 * heldRoll;
			float num28 = num22 + num23;
			float num29 = num3 * num3;
			float num30 = (float)obj15 + num24;
			float num31 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v19+20]");
			float num32 = num31 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v19+20]");
			object obj17 = obj9 * 0;
			float num33 = (float)obj16 + num25;
			float num34 = num27 + num26;
			float num35 = dt * (float)obj9;
			float num36 = num28 + num29;
			float num37 = (float)obj5 * heldRoll;
			float num38 = num32 + num30;
			float num39 = num33 - (float)obj17;
			float num40 = num34 - num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			bool flag = num36 < 0f;
			float num41 = num38 - num37;
			if (!flag)
			{
				if (held == 0)
				{
				}
				if (held == 0)
				{
				}
				if (held == 0)
				{
				}
				Vector3 vector2 = (Quaternion)0 * (Vector3)0;
				float num42 = (float)obj9 * num40;
				float num43 = (float)obj5 * num41;
				float num44 = dt * num41;
				float num45 = (float)obj9 * num39;
				float num46 = (float)obj5 * num39;
				float num47 = dt * num40;
				float num48 = num42 - num43;
				float num49 = num44 - num45;
				float num50 = num46 - num47;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
				object obj18 = default;
				float num51 = (float)obj18 * 3.2788972E+09f;
				if (!(num48 < num51))
				{
					float num52 = (float)obj18 * 1.1314135E+09f;
					bool flag2 = !(num48 > num52);
					num51 = num48;
					if (!flag2)
					{
						num51 = num52;
					}
				}
				result = Quaternion.Internal_AngleAxis(heldRoll += num51, ref axis);
			}
		}
		return result;
	}

	private void LateUpdate()
	{
		//IL_03c8: Expected I4, but got I8
		//IL_03e2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected VT, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I
		//IL_036b: Expected VT, but got I4
		//IL_036b: Expected Obj, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		int num = (int)(held & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = !heldRight;
		bool right = !flag3;
		Transform transform = GillaCorpse.Hand(heldBy, right);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = transform == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Transform[] array = links;
			if (links != null)
			{
				bool flag7 = held < array.Length;
				object obj9 = !flag7;
				if (obj9 != null)
				{
					goto IL_03ad;
				}
				object obj10 = links + held;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v12+20]");
				if ((nint)0 != 0)
				{
					object obj12 = default;
					object obj11 = obj12 + obj12;
					object obj14 = default;
					object obj13 = obj14 + obj14;
					object obj16 = default;
					object obj15 = obj16 + obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v12+20]");
					Vector3 position2 = ((Transform)0).position;
					object obj17 = obj11 - obj12;
					object obj18 = obj13 - obj14;
					object obj19 = obj15 - obj16;
					object obj20 = obj17 * obj17;
					object obj21 = obj18 * obj18;
					object obj22 = obj20 + obj21;
					object obj23 = obj19 * obj19;
					object obj24 = obj23 + obj22;
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					if ((nint)obj25 < 0)
					{
						return;
					}
					object obj26 = 0;
					while (true)
					{
						Transform[] array2 = links;
						if (links == null)
						{
							break;
						}
						bool flag8 = (nint)obj26 < array2.Length;
						object obj27 = !flag8;
						if (obj27 == null)
						{
							object obj28 = (object)links + obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v16+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v16+20]");
							Vector3 position3 = ((Transform)0).position;
							obj24 = obj17 + obj24;
							obj16 = obj19 + obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v16+20]");
							((Transform)0).position = (Vector3)0;
							obj26++;
							if ((nint)obj26 == 3)
							{
								return;
							}
							continue;
						}
						goto IL_03ad;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03ad;
		IL_03ad:
		throw new IndexOutOfRangeException();
	}

	private void OnDestroy()
	{
		//IL_01f5: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_019c: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = 5;
		while (true)
		{
			Transform[] array = links;
			if (links != null)
			{
				object obj3 = obj2 - 4;
				bool flag = (nint)obj3 < array.Length;
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4 (UnityEngine.Transform[])+v46 @ X22_v2*8]");
				bool flag3 = (UnityEngine.Object)0 != null;
				bool flag4 = !flag3;
				nint num = unchecked((nint)null);
				if (flag4)
				{
					goto IL_01a1;
				}
				Transform[] array2 = links;
				if (links != null)
				{
					bool flag5 = (nint)obj3 < array2.Length;
					object obj7 = !flag5;
					if (obj7 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8 (UnityEngine.Transform[])+v46 @ X22_v2*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8 (UnityEngine.Transform[])+v46 @ X22_v2*8]");
						GameObject obj8 = ((Component)0).gameObject;
						object obj9 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v9+E4]");
						bool flag6 = (nint)0 == 0;
						object obj10 = !flag6;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object.Destroy(obj8);
						num = unchecked((nint)null);
						goto IL_01a1;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_01a1:
			obj2++;
			if ((nint)obj2 == 7)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	public TornArm()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0114: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBC8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBD0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBD8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 32;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 40;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 48;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 56;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj14 = this + 64;
		obj14 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		held = -1;
		base._002Ector();
	}

	static TornArm()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFBE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = dictionary;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
