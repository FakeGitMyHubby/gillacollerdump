using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaStrands : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public int sending;

		public string text;

		internal void _003CSave_003Eb__0(UpdateUserDataResult _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_010b: Expected Obj, but got I
			//IL_004d: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D90]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D88]");
			object key2 = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+A0]");
			object obj3 = 0;
			int sending2 = sending;
			int sending3 = sending;
			PlayerPrefs.SetInt((string)key, sending);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+A0]");
			object list = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v6+8]");
			string value = GillaStashSave.Write((List<(string, int)>)list, 0);
			PlayerPrefs.SetString((string)key2, value);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+A0]");
			object list2 = 0;
			string text = GillaStashSave.Write((List<(string, int)>)list2, sending);
			if (text == this.text)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DF8]");
				object key3 = 0;
				PlayerPrefs.SetInt((string)key3, 0);
			}
			PlayerPrefs.Save();
		}
	}

	private enum Kind
	{
		// error: enumerator has no value
		Thread,
		// error: enumerator has no value
		Rope,
		// error: enumerator has no value
		Sheet
	}

	private struct Vertex
	{
		public Vector3 at;

		public Vector3 normal;

		public Color32 colour;

		public Vector2 uv;
	}

	private struct End
	{
		public int b0;

		public int b1;

		public int b2;

		public float w0;

		public float w1;

		public float w2;

		public Vector3 p0;

		public Vector3 p1;

		public Vector3 p2;
	}

	private class Strand
	{
		public End onA;

		public End onB;

		public readonly Vector3[] at;

		public readonly Vector3[] was;

		public Kind kind;

		public float wide;

		public float deep;

		public float goesAt;

		public float goesAfter;

		public float hangsFor;

		public float gone;

		public float slack;

		public float heavy;

		public float stub;

		public Vector3 drift;

		public Vector3 flatWay;

		public bool snapped;

		public bool hidden;

		public int cut;

		public int sides;

		public int firstVertex;

		public float beadAt;

		public float bead;

		public float beadBig;

		public float beadGrows;

		public float waves;

		public float phase;

		public float tone;

		public Strand()
		{
			//IL_0010: Expected Obj, but got I
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 136;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj4 = this + 144;
			object obj5 = default;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private struct Spot
	{
		public Vector3 at;

		public Vector3 into;

		public Transform on;

		public float room;

		public int vertex;
	}

	private const int Points = default(int);

	private const int Rings = default(int);

	private const int MostAtOnce = default(int);

	private const int MostDrops = default(int);

	private const float MostHeld = default(float);

	private const float Sink = default(float);

	public static bool On;

	private static readonly Color32 Dark;

	private static readonly Color32 Bright;

	private static readonly List<GillaStrands> live;

	private static GillaGoreAssets gore;

	private static readonly Dictionary<int, Vector2[]> rounds;

	private static readonly Dictionary<Mesh, BoneWeight[]> weightsOf;

	private static readonly List<Vector3> readAt;

	private static readonly List<Vector3> readFaces;

	private static readonly List<Vector2> readDown;

	private static readonly List<int> readTris;

	private static readonly Vector3[] ringAt;

	private static Vector3[] readWorld;

	private Transform a;

	private Transform b;

	private readonly List<Vector3> rimA;

	private Rigidbody pulled;

	private Strand[] strands;

	private Mesh mesh;

	private Vertex[] verts;

	private readonly List<Transform> anchors;

	private Matrix4x4[] anchorNow;

	private float age;

	private float held;

	private float size;

	private int left;

	private int dropFirst;

	private readonly Vector3[] dropAt;

	private readonly Vector3[] dropGoing;

	private readonly float[] dropSize;

	private readonly float[] dropLife;

	private readonly float[] dropFloor;

	private readonly bool[] dropShown;

	private int dropsOut;

	private static readonly Vector3[] DropRound;

	private static readonly int[] DropTris;

	public int Many
	{
		get
		{
			Strand[] array = strands;
			if (strands != null)
			{
				return array.Length;
			}
			return 0;
		}
	}

	public unsafe void EndsOf(int i, out Vector3 onA, out Vector3 onB, out int kind, out bool whole)
	{
		//IL_004a: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		Fetch();
		Strand[] array = strands;
		if (strands != null)
		{
			bool flag = array.Length < i;
			object obj = !flag;
			object obj2 = array.Length - i;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_03b7;
			}
			object obj5 = strands + i;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+20]");
				Vector3 vector = Where(ref *(End*)((nint)0 + (nint)16));
				object obj6 = default;
				ref Vector3 reference = ref *(Vector3*)obj6;
				Strand[] array2 = strands;
				if (strands != null)
				{
					bool flag3 = array2.Length < i;
					object obj7 = !flag3;
					object obj8 = array2.Length - i;
					bool flag4 = obj8 == null;
					object obj9 = ~obj7;
					object obj10 = obj9 | flag4;
					if (obj10 != null)
					{
						goto IL_03b7;
					}
					object obj11 = strands + i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v7+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v7+20]");
						Vector3 vector2 = Where(ref *(End*)((nint)0 + (nint)76));
						ref Vector3 reference2 = ref *(Vector3*)obj6;
						Strand[] array3 = strands;
						if (strands != null)
						{
							bool flag5 = array3.Length < i;
							object obj12 = !flag5;
							object obj13 = array3.Length - i;
							bool flag6 = obj13 == null;
							object obj14 = ~obj12;
							object obj15 = obj14 | flag6;
							if (obj15 != null)
							{
								goto IL_03b7;
							}
							object obj16 = strands + i;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v10+20]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v10+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+98]");
								ref int reference3 = ref *(int*)null;
								Strand[] array4 = strands;
								if (strands != null)
								{
									bool flag7 = array4.Length < i;
									object obj18 = !flag7;
									object obj19 = array4.Length - i;
									bool flag8 = obj19 == null;
									object obj20 = ~obj18;
									object obj21 = obj20 | flag8;
									if (obj21 != null)
									{
										goto IL_03b7;
									}
									object obj22 = strands + i;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v14+20]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v14+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+D8]");
										object obj24 = (nint)0 ^ (nint)1;
										ref bool reference4 = ref *(bool*)obj24;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03b7;
		IL_03b7:
		throw new IndexOutOfRangeException();
	}

	public static GillaStrands Between(Transform a, Transform b, Vector3 at, Vector3 outWay, Vector3 along, float across, float longWay, int many, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0aca: Expected Obj, but got I4
		//IL_0dac: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_0af5: Expected Obj, but got I
		//IL_0b17: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_0b72: Expected Obj, but got I
		//IL_0b82: Expected Obj, but got I
		//IL_0ba4: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_0b3b: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I4
		//IL_0bc2: Expected Obj, but got I
		//IL_0bd2: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I4
		//IL_0a57: Expected Obj, but got I4
		//IL_0c11: Expected Obj, but got I
		//IL_0c21: Expected Obj, but got I
		//IL_0c39: Expected Obj, but got I
		//IL_0c5b: Expected Obj, but got I4
		//IL_0dd9: Expected Obj, but got I
		//IL_0de9: Expected Obj, but got I
		//IL_0e0b: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_0a01: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I
		//IL_0570: Expected Obj, but got I4
		//IL_0c79: Expected Obj, but got I
		//IL_0c93: Expected Obj, but got I
		//IL_0ca4: Expected I, but got Obj
		//IL_0cc2: Expected Obj, but got I
		//IL_0cdd: Expected VT, but got I4
		//IL_0d0a: Expected Obj, but got I
		//IL_0d1a: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_05b1: Expected I4, but got Obj
		//IL_078d: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I
		//IL_05e1: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I
		//IL_0621: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I4
		//IL_0864: Expected VT, but got I4
		//IL_088e: Expected Obj, but got I4
		//IL_070f: Expected Obj, but got I
		//IL_0d57: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I
		//IL_076f: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+A0]");
		object obj4 = 0;
		if (obj4 == null)
		{
			goto IL_0a2c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = a == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		GillaStrands result = null;
		UnityEngine.Object obj31;
		Predicate<System.__Canon> predicate;
		Transform transform;
		if (obj8 == null)
		{
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = b == null;
			bool flag7 = !flag6;
			object obj11 = !flag7;
			result = null;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v15+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isPlaying = Application.isPlaying;
				bool flag9 = !isPlaying;
				result = null;
				if (!flag9)
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v20+E4]");
					bool flag10 = (nint)0 == 0;
					object obj16 = !flag10;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj;
					}
					object obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v20+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v14+E4]");
					bool flag11 = (nint)0 == 0;
					object obj19 = !flag11;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X9_v3+18]");
					bool flag12 = (UnityEngine.Object)0 == null;
					bool flag13 = !flag12;
					UnityEngine.Object obj20 = null;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v68+E4]");
						bool flag14 = (nint)0 == 0;
						object obj24 = !flag14;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj23 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v68+A0]");
						object obj25 = (nint)0 + (nint)24;
						UnityEngine.Object obj26 = default;
						obj25 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj20 = obj26;
					}
					object obj27 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v26+E4]");
					bool flag15 = (nint)0 == 0;
					object obj28 = !flag15;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj27 = obj;
					}
					object obj29 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v26+A0]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v5+18]");
					obj31 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v17+E4]");
					bool flag16 = (nint)0 == 0;
					object obj32 = !flag16;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag17 = obj31 == null;
					bool flag18 = !flag17;
					object obj33 = !flag18;
					result = null;
					if (obj33 == null)
					{
						object obj34 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v31+E4]");
						bool flag19 = (nint)0 == 0;
						object obj35 = !flag19;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj34 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v31+A0]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v19+18]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v19+18]");
						bool flag20 = (nint)0 == 0;
						transform = null;
						predicate = null;
						if (!flag20)
						{
							object obj38 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v63+E4]");
							bool flag21 = (nint)0 == 0;
							object obj39 = !flag21;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v20+58]");
							bool flag22 = (UnityEngine.Object)0 == null;
							bool flag23 = !flag22;
							object obj40 = !flag23;
							result = null;
							if (obj40 != null)
							{
								goto IL_0ad8;
							}
							object obj41 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v29+E4]");
							bool flag24 = (nint)0 == 0;
							object obj42 = !flag24;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj41 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FF0]");
							object obj43 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v29+A0]");
							object obj44 = 0;
							object obj45 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v30+10]");
							obj31 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v69+E4]");
							bool flag25 = (nint)0 == 0;
							object obj46 = !flag25;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj45 = obj43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v69+A0]");
							object obj47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v58+8]");
							Predicate<System.__Canon> predicate2 = (Predicate<System.__Canon>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v58+8]");
							bool flag26 = (nint)0 == 0;
							object obj48 = !flag26;
							transform = null;
							predicate = null;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v69+E4]");
								bool flag27 = (nint)0 == 0;
								object obj49 = !flag27;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj50 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v62+A0]");
									obj47 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FE0]");
								object obj51 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FE8]");
								object obj52 = 0;
								Predicate<System.__Canon> predicate3 = default;
								predicate3._002Ector(obj47, (IntPtr)obj52);
								object obj53 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v61+A0]");
								object obj54 = (nint)0 + (nint)8;
								obj54 = predicate3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Vector3 vector = (Vector3)0;
								predicate2 = predicate3;
								transform = (Transform)obj52;
								predicate = predicate3;
							}
							if ((object)obj31 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FC0]");
								object obj55 = 0;
								transform = (Transform)obj55;
								int num = ((List<System.__Canon>)(object)obj31).RemoveAll(predicate2);
								object obj56 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v74+E4]");
								bool flag28 = (nint)0 == 0;
								object obj57 = !flag28;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj56 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v74+A0]");
								object obj58 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v36+10]");
								List<System.__Canon> list = (List<System.__Canon>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v36+10]");
								bool flag29 = (nint)0 == 0;
								predicate = predicate2;
								if (!flag29)
								{
									bool flag30 = list._size < 6;
									int num2 = (int)predicate2;
									if (flag30)
									{
										goto IL_077d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v74+E4]");
									bool flag31 = (nint)0 == 0;
									object obj59 = !flag31;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj60 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v55+A0]");
										object obj61 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v56+10]");
										list = (List<System.__Canon>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v56+10]");
										bool flag32 = (nint)0 == 0;
										predicate = predicate2;
										if (flag32)
										{
											goto IL_08da;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FD8]");
									object obj62 = 0;
									transform = (Transform)obj62;
									System.__Canon _Canon = list.get_Item(0);
									bool flag33 = _Canon == null;
									predicate = null;
									if (!flag33)
									{
										GameObject gameObject = ((Component)(object)_Canon).gameObject;
										object obj63 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v50+E4]");
										bool flag34 = (nint)0 == 0;
										object obj64 = !flag34;
										if (obj64 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										UnityEngine.Object.Destroy(gameObject);
										object obj65 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v51+A0]");
										object obj66 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v52+10]");
										bool flag35 = (nint)0 == 0;
										predicate = null;
										obj31 = gameObject;
										if (!flag35)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FC8]");
											object obj67 = 0;
											transform = (Transform)obj67;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v52+10]");
											((List<System.__Canon>)0).RemoveAt(0);
											num2 = 0;
											goto IL_077d;
										}
									}
								}
							}
						}
						goto IL_08da;
					}
				}
			}
		}
		goto IL_0ad8;
		IL_08e8:
		NullReferenceException ex = new NullReferenceException();
		bool flag36 = (nint)predicate != 1;
		NullReferenceException ex2 = ex;
		if (!flag36)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj69 = default;
			object obj68 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj71 = default;
			object obj70 = obj71 & 1;
			if (obj70 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v51+E4]");
				bool flag37 = (nint)0 == 0;
				object obj72 = !flag37;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogException((Exception)obj69);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v56+E4]");
				bool flag38 = (nint)0 == 0;
				object obj73 = !flag38;
				if (obj73 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj31);
				goto IL_0a2c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj74 = obj69;
			predicate = (Predicate<System.__Canon>)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			transform = null;
			NullReferenceException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		GillaStrands result2 = default;
		return result2;
		IL_0a2c:
		result = null;
		goto IL_0ad8;
		IL_08da:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_08e8;
		IL_0ad8:
		return result;
		IL_077d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FF8]");
		object obj76 = 0;
		GameObject gameObject2 = default;
		gameObject2._002Ector((string)obj76);
		bool flag39 = (object)gameObject2 == null;
		transform = null;
		predicate = (Predicate<System.__Canon>)obj76;
		obj31 = gameObject2;
		if (!flag39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FB0]");
			object obj77 = 0;
			predicate = (Predicate<System.__Canon>)obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			GillaStrands gillaStrands = default;
			bool flag40 = (object)gillaStrands == null;
			transform = null;
			obj31 = gameObject2;
			if (flag40)
			{
				goto IL_08e8;
			}
			float across2 = default;
			float longWay2 = default;
			IntPtr intPtr = default;
			float scale = default;
			gillaStrands.Begin(a, b, at, along, (Vector3)many, across2, longWay2, (int)(nint)intPtr, scale);
			object obj78 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v81+E4]");
			bool flag41 = (nint)0 == 0;
			object obj79 = !flag41;
			if (obj79 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj78 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v81+A0]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v46+10]");
			bool flag42 = (nint)0 == 0;
			Vector3 vector = at;
			transform = b;
			predicate = (Predicate<System.__Canon>)(object)a;
			obj31 = gameObject2;
			if (!flag42)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FB8]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D100");
				result = gillaStrands;
				goto IL_0ad8;
			}
		}
		goto IL_08da;
	}

	private unsafe void Begin(Transform sideA, Transform sideB, Vector3 where, Vector3 outWay, Vector3 along, float across, float longWay, int many, float scale)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1a96: Expected Obj, but got I
		//IL_1ab8: Expected Obj, but got I4
		//IL_2367: Expected Obj, but got I
		//IL_2389: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0197: Expected F4, but got I
		//IL_01a7: Invalid comparison between F4 and I
		//IL_1adc: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0267: Invalid comparison between F8 and I
		//IL_1b71: Expected Obj, but got I
		//IL_1b89: Expected Obj, but got I
		//IL_1b99: Expected F4, but got I
		//IL_1ba9: Expected F4, but got I
		//IL_1bb9: Expected F4, but got I
		//IL_1b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5c: Expected Obj, but got Unknown
		//IL_23ef: Expected Obj, but got I
		//IL_2419: Expected Obj, but got I4
		//IL_23a7: Expected Obj, but got I
		//IL_23d1: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_043b: Invalid comparison between Obj and F8
		//IL_033a: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_0362: Expected F4, but got I
		//IL_036a: Expected F4, but got Obj
		//IL_037a: Expected F4, but got I
		//IL_03fd: Invalid comparison between Obj and F8
		//IL_1c31: Invalid comparison between F4 and I4
		//IL_1c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c45: Expected Obj, but got Unknown
		//IL_1c52: Expected Obj, but got F4
		//IL_1c87: Expected Obj, but got I4
		//IL_0504: Expected F4, but got I4
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be3: Expected Obj, but got Unknown
		//IL_1bfd: Expected Obj, but got I4
		//IL_1cb7: Invalid comparison between F4 and I4
		//IL_1cc6: Invalid comparison between F4 and I4
		//IL_1cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cda: Expected Obj, but got Unknown
		//IL_1ce7: Expected Obj, but got F4
		//IL_1d1c: Expected Obj, but got I4
		//IL_1d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d29: Expected Obj, but got Unknown
		//IL_051f: Expected F4, but got I4
		//IL_1d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d55: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I4
		//IL_05a5: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I
		//IL_1ed9: Invalid comparison between F8 and I4
		//IL_1ee8: Invalid comparison between F8 and I4
		//IL_1efb: Expected Obj, but got F8
		//IL_1f08: Expected Obj, but got F8
		//IL_1f3d: Expected Obj, but got I4
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected Obj, but got Unknown
		//IL_0751: Expected Obj, but got I
		//IL_075a: Expected VT, but got I4
		//IL_076a: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I
		//IL_1f83: Expected Obj, but got I4
		//IL_0672: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I4
		//IL_07de: Expected Obj, but got F4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_0811: Expected VT, but got Obj
		//IL_1d88: Expected Obj, but got Ref
		//IL_1e04: Invalid comparison between F4 and I4
		//IL_1e13: Invalid comparison between F4 and I4
		//IL_1e26: Expected Obj, but got F4
		//IL_1e33: Expected Obj, but got F4
		//IL_1e68: Expected Obj, but got I4
		//IL_1e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e75: Expected Obj, but got Unknown
		//IL_0a73: Expected VT, but got Ref
		//IL_0a7b: Expected VT, but got Ref
		//IL_0a84: Expected Obj, but got I4
		//IL_1f99: Expected VT, but got Ref
		//IL_1fa2: Expected Obj, but got I4
		//IL_085c: Expected Obj, but got I4
		//IL_1fb7: Expected VT, but got Obj
		//IL_1fd8: Expected Obj, but got I4
		//IL_1fe8: Expected F4, but got I
		//IL_08b0: Expected Obj, but got I4
		//IL_22a9: Invalid comparison between F4 and Obj
		//IL_22ba: Expected Obj, but got I4
		//IL_22d2: Invalid comparison between F4 and I4
		//IL_22eb: Expected Obj, but got I4
		//IL_22f8: Expected I4, but got Obj
		//IL_230e: Invalid comparison between Obj and F4
		//IL_231f: Expected Obj, but got I4
		//IL_232f: Expected Obj, but got I
		//IL_0ab3: Expected VT, but got Ref
		//IL_0abb: Expected VT, but got Ref
		//IL_0ac4: Expected Obj, but got I4
		//IL_2017: Expected Obj, but got VT
		//IL_090f: Expected VT, but got Ref
		//IL_0917: Expected VT, but got Ref
		//IL_0927: Expected VT, but got Ref
		//IL_0b3e: Expected Obj, but got VT
		//IL_09a8: Expected Obj, but got I4
		//IL_0b64: Expected Obj, but got I
		//IL_0b85: Expected Obj, but got VT
		//IL_09e2: Expected F4, but got I
		//IL_09ef: Unsupported input type for neg.
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected F4, but got Unknown
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected VT, but got Unknown
		//IL_0a27: Expected Obj, but got I4
		//IL_0a27: Expected VT, but got Obj
		//IL_0a34: Expected VT, but got Obj
		//IL_0a3d: Expected Obj, but got I4
		//IL_0a66: Expected F4, but got I4
		//IL_0bb4: Expected Obj, but got I4
		//IL_0bbc: Expected Obj, but got VT
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_0ed4: Expected I4, but got Obj
		//IL_0ed4: Expected VT, but got I4
		//IL_0ee0: Expected Obj, but got Ref
		//IL_0f57: Expected VT, but got I4
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Obj, but got Unknown
		//IL_0fc5: Expected VT, but got I4
		//IL_0fd1: Expected Obj, but got Ref
		//IL_10bd: Expected VT, but got I4
		//IL_102d: Expected VT, but got Obj
		//IL_1035: Expected VT, but got I4
		//IL_0ca8: Expected Obj, but got I
		//IL_0cb8: Expected Obj, but got I
		//IL_0cc8: Invalid comparison between F4 and I
		//IL_187f: Expected Obj, but got I
		//IL_18a9: Expected Obj, but got I4
		//IL_2488: Unknown result type (might be due to invalid IL or missing references)
		//IL_248d: Expected Obj, but got Unknown
		//IL_2495: Invalid comparison between Obj and F4
		//IL_190e: Expected VT, but got I4
		//IL_1135: Expected Obj, but got I
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1161: Expected Obj, but got Unknown
		//IL_11de: Expected VT, but got I4
		//IL_20d0: Expected Obj, but got I
		//IL_1981: Expected VT, but got Obj
		//IL_1989: Expected VT, but got I4
		//IL_11ff: Expected VT, but got I4
		//IL_1207: Expected Obj, but got I4
		//IL_2035: Expected Obj, but got I
		//IL_204d: Expected Obj, but got I
		//IL_2055: Expected F4, but got Obj
		//IL_205d: Invalid comparison between F4 and Obj
		//IL_19e9: Expected Obj, but got VT
		//IL_20ff: Expected Obj, but got I4
		//IL_1238: Expected Obj, but got I4
		//IL_1241: Expected VT, but got I4
		//IL_1249: Expected Obj, but got I4
		//IL_14ae: Invalid comparison between F4 and I
		//IL_14cf: Expected F4, but got I
		//IL_1a0f: Expected Obj, but got I
		//IL_1a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a24: Expected Obj, but got Unknown
		//IL_153f: Expected Obj, but got I
		//IL_1547: Expected F4, but got Obj
		//IL_1557: Expected F4, but got I
		//IL_1567: Expected F4, but got I
		//IL_2456: Expected Obj, but got I4
		//IL_1a45: Expected I4, but got F4
		//IL_127c: Expected Obj, but got I
		//IL_128c: Expected Obj, but got Ref
		//IL_12ae: Expected Obj, but got I4
		//IL_1522: Expected F4, but got I
		//IL_0e31: Invalid comparison between F4 and I
		//IL_0e4a: Expected F4, but got I
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e0: Expected Obj, but got Unknown
		//IL_1330: Expected Obj, but got VT
		//IL_1330: Expected VT, but got Obj
		//IL_1330: Expected VT, but got Ref
		//IL_1349: Expected VT, but got I
		//IL_2137: Expected Obj, but got I4
		//IL_0e95: Expected F4, but got I
		//IL_1667: Invalid comparison between F4 and I
		//IL_16c8: Expected Obj, but got I
		//IL_16d0: Expected F4, but got Obj
		//IL_16e0: Expected F4, but got I
		//IL_16f0: Expected F4, but got I
		//IL_223d: Expected F4, but got I
		//IL_223d: Expected F4, but got I
		//IL_228b: Expected F4, but got I
		//IL_228b: Expected F4, but got I
		//IL_17fe: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v1+18]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		UnityEngine.Object obj9 = null;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v158+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v158+A0]");
			object obj14 = (nint)0 + (nint)24;
			UnityEngine.Object obj15 = default;
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj9 = obj15;
		}
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaStains.LayNoise();
		object obj18 = this + 32;
		obj18 = sideA;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = this + 40;
		obj19 = sideB;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num2 = default;
		if (!(num2 < 0f))
		{
			num = num2;
		}
		bool flag7 = (object)sideB == null;
		float num3 = scale;
		float num4 = longWay;
		List<Vector3> list = null;
		List<Spot> list2 = (List<Spot>)(object)sideB;
		float num6 = default;
		float num5 = num6;
		if (flag7)
		{
			goto IL_1a4c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj21 = this + 56;
		object obj22 = default;
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		double num8 = default;
		double num7 = num8 * num8;
		float num10 = default;
		float num9 = num10 * num10;
		double num11 = num7 + (double)num9;
		float num13 = default;
		float num12 = num13 * num13;
		double num14 = (double)num12 + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		float num20;
		float num21;
		float num22;
		if (num14 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X0_v184+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num15 > 0)
			{
				float num16 = (float)num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				num3 = num16 / 0f;
				float num17 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				float num18 = num17 / 0f;
				float num19 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				num20 = num19 / 0f;
				num21 = num3;
				num22 = num18;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj26 = 0;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v150+A0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v151+8]");
				num20 = 0f;
				num21 = (float)obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v151+4]");
				num22 = 0f;
				num3 = scale;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj29 = 0;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v137+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v138+20]");
			num20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v138+18]");
			num21 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v138+1C]");
			num22 = 0f;
			num3 = scale;
		}
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE0]");
		object obj32 = vector * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X0_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj35 = !flag9;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9028]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9020]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9008]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num23;
		float num24 = default;
		if ((nint)obj32 < 0)
		{
			if (obj32 == (object)(-0.5))
			{
				num23 = -1.0;
				num = num24;
				goto IL_1bc6;
			}
			double num25 = (double)obj32 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num4 = -0.5f;
			num = (float)num25;
		}
		else
		{
			if (obj32 == (object)0.5)
			{
				num23 = 1.0;
				num = num24;
				goto IL_1bc6;
			}
			double num26 = (double)obj32 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num4 = 0.5f;
			num = (float)num26;
		}
		goto IL_1c18;
		IL_1bc6:
		double num27 = (double)num + num23;
		object obj39 = num & 1;
		bool flag10 = obj39 == null;
		object obj40 = !flag10;
		if (obj40 != null)
		{
			num = (float)num27;
		}
		num4 = (float)num27;
		goto IL_1c18;
		IL_1a4c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1a5a;
		IL_1d76:
		num3 = size;
		object obj41 = (object)(&num24);
		float num28 = num21 * num21;
		float num29 = num22 * num22;
		num8 = (double)num20 * (double)num20;
		float num30 = num28 + num29;
		float num31 = size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		float num32 = num31 * 0f;
		float num33 = (float)num8 + num30;
		float num35 = default;
		float num36 = default;
		float num34 = num35 - num36;
		bool flag11 = num34 < 0f;
		bool flag12 = num34 == 0f;
		object obj42 = num35 ^ num36;
		object obj43 = num35 ^ num34;
		object obj44 = obj42 & obj43;
		bool flag13 = (nint)obj44 < 0;
		bool flag14 = flag11 == flag13;
		object obj45 = !flag12;
		object obj46 = flag14 & obj45;
		object obj47 = ~obj46;
		float num37 = ((obj47 != null) ? num36 : num35);
		num4 = num36;
		List<Vector3> list3;
		Vector3 vector3 = (Vector3)list3;
		float num39 = default;
		float num38 = num39;
		float num40 = num6;
		float num42 = default;
		float num41 = num42;
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		num = 0f;
		float num43;
		Strand strand = default;
		object obj65;
		object obj67;
		List<Spot> list4 = default;
		float num90 = default;
		float num92 = default;
		object obj79 = default;
		object obj80 = default;
		End end = default;
		object obj81 = default;
		Transform t = default;
		object obj84 = default;
		List<Spot> list5 = default;
		BoneWeight[] array;
		object obj85 = default;
		object obj91 = default;
		object obj94 = default;
		Transform[] bones;
		End end4 = default;
		End end5 = default;
		float num109 = default;
		End end7 = default;
		object obj100 = default;
		End end9 = default;
		object obj102 = default;
		End onB = default;
		object obj105 = default;
		End onA2 = default;
		End onB2 = default;
		IndexOutOfRangeException ex2 = default;
		object obj52;
		Vector3 vector4 = default;
		while (true)
		{
			object obj49 = obj48 + obj48;
			bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num43) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
			object obj50 = !flag15;
			float num44 = num43 - (float)obj48;
			bool flag16 = num44 == 0f;
			object obj51 = obj52;
			object obj53 = !flag16;
			Kind kind = (Kind)(obj50 & obj53);
			object obj54 = obj49 << 1;
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num43);
			object obj55 = !flag17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9030]");
			object obj56 = 0;
			object obj57 = ~obj55;
			object obj58 = ~obj57;
			Kind kind2 = ((obj58 != null) ? kind : ((Kind)2));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			strand._002Ector();
			bool flag18 = strand == null;
			list = (List<Vector3>)vector3;
			if (flag18)
			{
				break;
			}
			strand.kind = kind2;
			bool flag19 = obj52 == null;
			list = (List<Vector3>)vector3;
			if (flag19)
			{
				break;
			}
			object obj59 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v43+40]");
			list2 = (List<Spot>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag20 = ex2 == null;
			list = (List<Vector3>)vector3;
			if (flag20)
			{
				goto IL_1a68;
			}
			object obj60 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X23_v6+18]");
			bool flag21 = (nint)obj60 < 0;
			object obj61 = !flag21;
			list = (List<Vector3>)vector3;
			if (obj61 != null)
			{
				goto IL_1a5a;
			}
			object obj62 = obj52 + obj48;
			object obj63 = obj62 + 32;
			obj63 = strand;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj64 = obj65 & 1;
			object obj68;
			object obj69;
			float num70;
			float num71;
			float num72;
			float num94;
			float num106;
			float num108;
			float num113;
			if (obj64 != null)
			{
				object obj66 = obj67 & 1;
				if (obj66 != null)
				{
					float num45 = num40 * num40;
					float num46 = num41 * num41;
					float num47 = num46 + num45;
					float num48 = num38 * num38;
					float num49 = num48 + num47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					obj68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					if (!(num49 > 0f))
					{
						object obj70 = obj68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1531 @ X8_v96+A0]");
						object obj71 = 0;
						object obj72 = obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ X0_v150+E4]");
						bool flag22 = (nint)0 == 0;
						object obj73 = !flag22;
						if (obj73 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num50 = num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+44]");
						float num51 = num50 * 0f;
						float num52 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+44]");
						float num53 = num52 * 0f;
						float num54 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+40]");
						float num55 = num54 * 0f;
						float num56 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+3C]");
						float num57 = num56 * 0f;
						float num58 = num53 - num55;
						float num59 = num57 - num51;
						float num60 = num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+40]");
						float num61 = num60 * 0f;
						float num62 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X8_v97+3C]");
						float num63 = num62 * 0f;
						num3 = num61 - num63;
						float num64 = num58 * num58;
						float num65 = num59 * num59;
						float num66 = num64 + num65;
						float num67 = num3 * num3;
						float num68 = num67 + num66;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num69 = num68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						bool flag23 = !(num69 > 0f);
						num13 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						num10 = 0f;
						if (flag23)
						{
							goto IL_1527;
						}
						num70 = num58 / num68;
						num71 = num59 / num68;
						num72 = num3 / num68;
						num13 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						num10 = 0f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
						object obj74 = 0;
						object obj75 = obj74;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X8_v111+A0]");
						object obj76 = 0;
						float num73 = (float)obj76;
						bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76);
						float num74 = num40;
						float num68 = (float)num8;
						float num75 = num33;
						float num76 = num41;
						float num77 = num38;
						if (!flag24)
						{
							float num78 = num21 * num40;
							float num79 = num22 * num41;
							float num80 = num20 * num38;
							float num81 = num79 + num78;
							float num82 = num80 + num81;
							float num83 = num82 / num33;
							num75 = num21 * num83;
							num3 = num22 * num83;
							num73 = num20 * num83;
							num74 = num40 - num75;
							num76 = num41 - num3;
							num77 = num38 - num73;
							num13 = num20;
							num10 = num22;
							num68 = num21;
							num5 = num33;
						}
						object obj77 = obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X0_v162+E4]");
						bool flag25 = (nint)0 == 0;
						object obj78 = !flag25;
						if (obj78 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num84 = num74 * num74;
						float num85 = num76 * num76;
						float num86 = num84 + num85;
						float num87 = num77 * num77;
						float num58 = num86 + num87;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num88 = num58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						bool flag26 = !(num88 > 0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						float num59 = 0f;
						if (flag26)
						{
							goto IL_1527;
						}
						num70 = num74 / num58;
						num71 = num76 / num58;
						num72 = num77 / num58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						num59 = 0f;
					}
					goto IL_210d;
				}
				Spot spot = Pick(list4, kind2, null);
				float num89 = num32 * num90;
				float num91 = num32 * num92;
				float num93 = num32 * (float)obj79;
				num94 = (float)obj80 + num89;
				float num95 = (float)end + num91;
				float num96 = (float)obj81 + num93;
				End end2 = Rigid(t, (Vector3)kind2);
				strand.onB = end;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X21_v13+2C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v39 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
				float num107;
				List<Vector3> list6;
				End onA;
				Kind kind3;
				if ((nint)0 >= (nint)1)
				{
					Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X21_v13+2C]");
					nint num97 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
					object obj82 = num97 * 0;
					float num98 = num90;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
					float num99 = num98 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
					object obj83 = obj84 * 0;
					num8 = size;
					double num100 = (double)size * (double)obj82;
					double num101 = (double)size * (double)num99;
					double num102 = (double)size * (double)obj83;
					num = (float)end + (float)num100;
					num4 = (float)obj80 + (float)num101;
					num3 = (float)obj81 + (float)num102;
					Spot spot2 = Nearest(list5, (Vector3)kind2, (Kind)0);
					bool flag27 = array == null;
					vector2 = (Vector3)0;
					list = (List<Vector3>)kind2;
					list2 = list5;
					if (flag27)
					{
						break;
					}
					bool flag28 = (nint)obj85 < array.Length;
					object obj86 = !flag28;
					vector2 = (Vector3)0;
					list = (List<Vector3>)kind2;
					list2 = list5;
					if (obj86 != null)
					{
						goto IL_1a5a;
					}
					object obj87 = (object)array + obj85;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
					object obj88 = 0;
					object obj89 = obj88;
					object obj90 = (object)(&obj91);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v121+E4]");
					bool flag29 = (nint)0 == 0;
					object obj92 = !flag29;
					if (obj92 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X9_v21+FF]");
					object obj93 = 0 * obj94;
					float num103 = num32 * (float)obj79;
					float num104 = num24 + (float)obj93;
					float num105 = (float)obj81 + num103;
					Transform transform = Steady(sideA);
					End end3 = OnSkin(bones, (BoneWeight)(&end4), (Vector3)transform, (Transform)vector4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1981 @ X8_v69+20]");
					end4 = (End)0;
					num106 = num105;
					num107 = num104;
					list6 = (List<Vector3>)(object)transform;
					onA = end5;
					kind3 = (Kind)(int)(&end4);
					num108 = num109;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
					object obj95 = 0;
					object obj96 = obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ X0_v110+E4]");
					bool flag30 = (nint)0 == 0;
					object obj97 = !flag30;
					if (obj97 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num110 = (float)end - num91;
					num108 = (float)obj80 - num89;
					float num111 = (float)obj81 - num93;
					Transform t2 = Steady(sideA);
					End end6 = Rigid(t2, (Vector3)kind2);
					num106 = num111;
					num107 = num110;
					list6 = null;
					onA = end7;
					kind3 = kind2;
				}
				strand.onA = onA;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X21_v13+2C]");
				_ = 0;
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				float num112 = num90;
				num8 = num95;
				vector2 = (Vector3)list6;
				vector3 = (Vector3)kind3;
				num113 = num96;
				num5 = num92;
				num = num107;
				goto IL_2469;
			}
			Spot spot3 = Pick(list5, kind2, rimA);
			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
			Spot spot4 = Nearest(list4, (Vector3)kind2, (Kind)rimA);
			object obj98 = (object)(&obj91);
			float num114 = num32 * num90;
			float num115 = num32 * num92;
			float num116 = num32 * (float)obj79;
			num108 = (float)obj80 + num114;
			float num117 = num24 + num115;
			float num118 = (float)obj81 + num116;
			float num119 = num32 * (float)obj79;
			End end8 = Rigid(t, (Vector3)kind2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1550 @ X8_v53+FF]");
			object obj99 = 0 * obj100;
			num113 = (float)obj81 + num119;
			strand.onA = end9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X21_v13+2C]");
			_ = 0;
			float num120 = (float)end9 + (float)obj99;
			End end10 = Rigid(t, (Vector3)kind2);
			object obj101 = (object)(&obj102);
			strand.onB = onB;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1981 @ X8_v69+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1681 @ X8_v56+FF]");
			_ = 0;
			Vector3 onUnitSphere2 = UnityEngine.Random.onUnitSphere;
			num106 = num118;
			float num121 = num117;
			float num122 = num120;
			vector2 = (Vector3)rimA;
			vector3 = (Vector3)kind2;
			num94 = num109;
			goto IL_20a3;
			IL_2469:
			Shape(strand, vector3, vector2, vector4);
			obj48++;
			bool flag31 = obj48 != (object)num43;
			num13 = num113;
			num10 = num94;
			num3 = num106;
			num4 = num108;
			list2 = (List<Spot>)(object)strand;
			if (!flag31)
			{
				List<Transform> list7 = anchors;
				bool flag32 = (object)anchors == null;
				num13 = num113;
				num10 = num94;
				num3 = num106;
				num4 = num108;
				list = (List<Vector3>)vector3;
				list2 = (List<Spot>)(object)strand;
				if (flag32)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
				object obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj104 = this + 96;
				obj104 = obj105;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				left = (int)num43;
				Build();
				return;
			}
			continue;
			IL_20a3:
			num8 = num122;
			num = num121;
			goto IL_2469;
			IL_1527:
			object obj106 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ X8_v91+A0]");
			object obj107 = 0;
			num70 = (float)obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v92+4]");
			num71 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1800 @ X8_v92+8]");
			num72 = 0f;
			goto IL_210d;
			IL_210d:
			object obj108 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X0_v131+E4]");
			bool flag33 = (nint)0 == 0;
			object obj109 = !flag33;
			if (obj109 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num123 = num21 * num72;
			float num124 = num22 * num72;
			float num125 = num20 * num71;
			float num126 = num20 * num70;
			float num127 = num124 - num125;
			float num128 = num126 - num123;
			float num129 = num21 * num71;
			float num130 = num22 * num70;
			float num131 = num129 - num130;
			float num132 = num127 * num127;
			float num133 = num128 * num128;
			float num134 = num132 + num133;
			float num135 = num131 * num131;
			float num136 = num135 + num134;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num137;
			float num138;
			float num139;
			if (num136 > 0f)
			{
				num137 = num127 / num136;
				num138 = num128 / num136;
				num139 = num131 / num136;
			}
			else
			{
				object obj110 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2083 @ X8_v86+A0]");
				object obj111 = 0;
				num137 = (float)obj111;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ X8_v87+4]");
				num138 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ X8_v87+8]");
				num139 = 0f;
			}
			Vector2 insideUnitCircle = UnityEngine.Random.insideUnitCircle;
			float num140 = num37 * num127;
			float num141 = num128 * num36;
			float num142 = num70 * num140;
			float num143 = num71 * num140;
			float num144 = num72 * num140;
			float num145 = num137 * num141;
			float num146 = across + num142;
			float num147 = longWay + num143;
			float num148 = scale + num144;
			float num149 = num138 * num141;
			float num150 = num139 * num141;
			float num151 = num145 + num146;
			float num152 = num150 + num148;
			float num153 = num149 + num147;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			nint num154 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num155 = UnityEngine.Random.Range(num154, 0f);
			float num156 = num70 * num155;
			float num157 = num71 * num155;
			float num158 = num72 * num155;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			nint num159 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num160 = UnityEngine.Random.Range(num159, 0f);
			float num161 = num137 * num160;
			float num162 = num138 * num160;
			float num163 = num139 * num160;
			float num164 = num156 + num161;
			float num165 = num157 + num162;
			float num166 = num158 + num163;
			float num167 = num164 * num36;
			float num168 = num165 * num36;
			float num169 = num166 * num36;
			float num170 = num151 + num167;
			num94 = num153 + num168;
			num113 = num152 + num169;
			End end11 = Rigid(sideA, vector3);
			strand.onA = onA2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X21_v13+2C]");
			_ = 0;
			End end12 = Rigid(sideB, vector3);
			object obj112 = (object)(&obj102);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1981 @ X8_v69+30]");
			_ = 0;
			strand.onB = onB2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1927 @ X8_v85+FF]");
			_ = 0;
			num106 = num152;
			num121 = num151;
			num122 = num170;
			num38 = num72;
			num40 = num70;
			num41 = num71;
			num108 = num153;
			num5 = across;
			goto IL_20a3;
		}
		goto IL_1a4c;
		IL_1a68:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1a5a:
		ex2 = new IndexOutOfRangeException();
		goto IL_1a68;
		IL_1c18:
		float num171 = num - 20f;
		bool flag34 = num171 < 0f;
		object obj113 = num ^ 0x14;
		object obj114 = num ^ num171;
		object obj115 = obj113 & obj114;
		bool flag35 = (nint)obj115 < 0;
		bool flag36 = flag34 == flag35;
		object obj116 = !flag36;
		object obj117 = ~obj116;
		float num172 = ((obj117 != null) ? 20f : num);
		float num173 = num172 - 5f;
		bool flag37 = num173 < 0f;
		bool flag38 = num173 == 0f;
		object obj118 = num172 ^ 5;
		object obj119 = num172 ^ num173;
		object obj120 = obj118 & obj119;
		bool flag39 = (nint)obj120 < 0;
		bool flag40 = flag37 == flag39;
		object obj121 = !flag38;
		object obj122 = flag40 & obj121;
		object obj123 = ~obj122;
		num43 = ((obj123 != null) ? 5f : num172);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		obj52 = this + 64;
		object obj124 = default;
		obj52 = obj124;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list5._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list4._002Ector();
		object obj125 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v42+E4]");
		bool flag41 = (nint)0 == 0;
		object obj126 = !flag41;
		if (obj126 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X25_v5-10]");
		InsideOf(sideA, list5, (List<Vector3>)0);
		InsideOf(sideB, list4, null);
		bool flag42 = list5 == null;
		list = null;
		list2 = list4;
		num5 = num6;
		if (flag42)
		{
			goto IL_1a4c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v39 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
		if ((nint)0 >= (nint)1)
		{
			bool flag43 = list4 == null;
			list = null;
			list2 = list4;
			num5 = num6;
			if (flag43)
			{
				goto IL_1a4c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
			if ((nint)0 > (nint)0)
			{
				obj67 = 1;
				array = null;
				bones = null;
				list3 = null;
				list2 = list4;
				obj65 = 0;
				num5 = num6;
				goto IL_1d76;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+1C]");
			object obj127 = (nint)0 + (nint)1;
			_ = 0;
			List<Vector3> list8 = null;
			List<Spot> list9 = list4;
		}
		else
		{
			bool flag44 = list4 == null;
			list = null;
			list2 = list4;
			num5 = num6;
			if (flag44)
			{
				goto IL_1a4c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+1C]");
			object obj128 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
			bool flag45 = (nint)0 < (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
			List<Vector3> list8 = (List<Vector3>)0;
			List<Spot> list9 = list4;
			if (!flag45)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+10]");
				nint num174 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
				Array.Clear((Array)num174, 0, 0);
				vector2 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v41 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
				list8 = (List<Vector3>)0;
				list9 = null;
			}
		}
		object obj129 = obj;
		double num175 = (double)num36 * 2.5;
		float num176 = size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num177 = num176 * 0f;
		double num178 = num175 - (double)num177;
		bool flag46 = num178 < 0.0;
		bool flag47 = num178 == 0.0;
		object obj130 = num175 ^ (double)num177;
		object obj131 = num175 ^ num178;
		object obj132 = obj130 & obj131;
		bool flag48 = (nint)obj132 < 0;
		bool flag49 = flag46 == flag48;
		object obj133 = !flag47;
		object obj134 = flag49 & obj133;
		object obj135 = ~obj134;
		double num179 = ((obj135 != null) ? ((double)num177) : num175);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X0_v47+E4]");
		bool flag50 = (nint)0 == 0;
		object obj136 = !flag50;
		if (obj136 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj137 = num43 << 3;
		List<Spot> list10 = (List<Spot>)(obj137 + 16);
		float reach = default;
		Vector3 vector5;
		if (CapOf(sideB, (Vector3)list4, across, list10, (int)(&reach), out var middle, out var round, out *(Vector3*)many))
		{
			object obj138 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X0_v52+E4]");
			bool flag51 = (nint)0 == 0;
			object obj139 = !flag51;
			if (obj139 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SkinnedMeshRenderer skinnedMeshRenderer = TorsoOf(sideA);
			object obj140 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v32+E4]");
			bool flag52 = (nint)0 == 0;
			object obj141 = !flag52;
			if (obj141 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (skinnedMeshRenderer != null)
			{
				bool flag53 = (object)skinnedMeshRenderer == null;
				vector5 = (Vector3)(&round);
				vector4 = (Vector3)(&middle);
				num8 = num179;
				vector2 = (Vector3)(&reach);
				num3 = scale;
				num4 = longWay;
				list = null;
				list2 = null;
				num5 = num6;
				num = across;
				if (flag53)
				{
					goto IL_1a4c;
				}
				Transform[] bones2 = skinnedMeshRenderer.bones;
				Mesh sharedMesh = skinnedMeshRenderer.sharedMesh;
				object obj142 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X8_v33+E4]");
				bool flag54 = (nint)0 == 0;
				object obj143 = !flag54;
				if (obj143 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				BoneWeight[] array2 = WeightsOf(sharedMesh);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
				float num112 = 0f;
				num10 = 0f - round;
				object obj144 = default;
				num13 = 0 - obj144;
				vector2 = (Vector3)(obj137 + 16);
				TorsoCap(skinnedMeshRenderer, bones2, array2, vector2, reach, (Vector3)list5, (int)(&round), (List<Spot>)many);
				vector4 = (Vector3)list5;
				obj67 = 0;
				array = array2;
				bones = bones2;
				list3 = (List<Vector3>)(object)array2;
				list2 = (List<Spot>)(object)bones2;
				num5 = 0f;
			}
			else
			{
				vector4 = (Vector3)(&middle);
				vector2 = (Vector3)(&reach);
				obj67 = 0;
				array = null;
				bones = null;
				list3 = null;
				list2 = null;
				num5 = num6;
			}
		}
		else
		{
			vector4 = (Vector3)(&middle);
			vector2 = (Vector3)(&reach);
			obj67 = 1;
			array = null;
			bones = null;
			list3 = (List<Vector3>)(object)list10;
			list2 = list4;
			num5 = num6;
		}
		vector5 = (Vector3)(&round);
		obj65 = 1;
		goto IL_1d76;
	}

	private void Shape(Strand st, Vector3 p, Vector3 q, Vector3 flat)
	{
		//IL_0164: Invalid comparison between F4 and I4
		//IL_0173: Expected F8, but got I4
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0b2c: Invalid comparison between F4 and I4
		//IL_0b3b: Expected F8, but got I4
		//IL_0bcb: Invalid comparison between F4 and I4
		//IL_0bda: Expected F8, but got I4
		//IL_0244: Invalid comparison between F4 and I4
		//IL_0253: Expected F8, but got I4
		//IL_0c40: Expected F4, but got I
		//IL_0c40: Expected F4, but got I
		//IL_0c6e: Expected F4, but got I
		//IL_0c6e: Expected F4, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_0d92: Invalid comparison between F4 and I4
		//IL_0da1: Expected F8, but got I4
		//IL_009c: Expected F4, but got I
		//IL_009c: Expected F4, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00e4: Expected F4, but got I
		//IL_00e4: Expected F4, but got I
		//IL_0cdd: Expected Obj, but got I
		//IL_0ced: Expected Obj, but got I
		//IL_0d10: Expected Obj, but got I4
		//IL_0d19: Expected F8, but got I4
		//IL_0e0b: Invalid comparison between F4 and I4
		//IL_0e1a: Expected F8, but got I4
		//IL_0112: Invalid comparison between F4 and I4
		//IL_0f54: Invalid comparison between F8 and I4
		//IL_0f63: Expected F8, but got I4
		//IL_0e7d: Expected F4, but got I
		//IL_0eab: Expected F4, but got I
		//IL_0eab: Expected F4, but got I
		//IL_0ebf: Expected Obj, but got I
		//IL_034f: Invalid comparison between F4 and I4
		//IL_035e: Invalid comparison between F4 and I4
		//IL_0376: Expected Obj, but got F8
		//IL_0383: Expected Obj, but got F4
		//IL_03cf: Expected Obj, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0156: Expected F8, but got I4
		//IL_0a24: Expected F4, but got I
		//IL_0a52: Expected F4, but got I
		//IL_0a52: Expected F4, but got I
		//IL_0a66: Expected Obj, but got I
		//IL_045f: Invalid comparison between F8 and I4
		//IL_0470: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got F8
		//IL_0535: Invalid comparison between F8 and I4
		//IL_0546: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_0596: Expected Obj, but got F8
		//IL_10ad: Expected Obj, but got I
		//IL_10df: Expected Obj, but got I
		//IL_0fed: Expected F4, but got I
		//IL_102b: Expected VT, but got F8
		//IL_107a: Expected F4, but got I
		//IL_107a: Expected F4, but got I
		//IL_0f86: Expected Obj, but got I
		//IL_0f9e: Expected Obj, but got I
		//IL_0fae: Expected Obj, but got I
		//IL_0fbe: Expected Obj, but got I
		//IL_0fce: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I4
		//IL_07ae: Expected F4, but got I
		//IL_07ae: Expected F4, but got I
		//IL_07ed: Expected F4, but got I
		//IL_087e: Expected I4, but got VT
		//IL_08ac: Expected Obj, but got I4
		//IL_091f: Expected VT, but got I4
		float value = UnityEngine.Random.value;
		if (st != null)
		{
			int sides = ((st.kind != (Kind)1) ? 5 : (5 + 1));
			if (st.kind == (Kind)2)
			{
				sides = 8;
			}
			bool flag = st.kind == (Kind)1;
			st.sides = sides;
			object obj;
			float slack;
			object obj8;
			object obj9;
			object obj10 = default;
			object obj11;
			object obj12 = default;
			if (!flag)
			{
				if (st.kind == (Kind)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA14]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					float num2 = UnityEngine.Random.Range(num, 0f);
					obj = this + 112;
					float wide = num2 * (float)obj;
					st.wide = wide;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB70]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF40]");
					float num4 = UnityEngine.Random.Range(num3, 0f);
					float deep = num4 * (float)obj;
					st.deep = deep;
					double num6;
					if (value < 0f)
					{
						float num5 = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float goesAt = num5 * 0f;
						st.goesAt = goesAt;
						num6 = 0.0;
					}
					else
					{
						float num7 = value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						float num8 = num7 * 0f;
						float num9 = value - 1f;
						bool flag2 = num9 < 0f;
						bool flag3 = num9 == 0f;
						object obj2 = (double)value ^ 1.0;
						object obj3 = value ^ num9;
						object obj4 = obj2 & obj3;
						bool flag4 = (nint)obj4 < 0;
						float num10 = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num11 = num10 + 0f;
						bool flag5 = flag2 == flag4;
						object obj5 = !flag3;
						object obj6 = flag5 & obj5;
						object obj7 = ~obj6;
						if (obj7 == null)
						{
							num11 = 0.5f;
						}
						float goesAt2 = num11 * (float)obj;
						st.goesAt = goesAt2;
						bool flag6 = !((double)value > 1.0);
						num6 = value;
						if (!flag6)
						{
							num6 = 1.0;
						}
					}
					double num12 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A91C]");
					double num13 = num12 * 0.0;
					double num14 = num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					double num15 = num14 + 0.0;
					st.goesAfter = (float)num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					float heavy = UnityEngine.Random.Range(0.5f, 0f);
					st.heavy = heavy;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADD8]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC48]");
					slack = UnityEngine.Random.Range(num16, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
					obj8 = 0;
					obj9 = obj10;
					obj11 = obj12;
				}
				else
				{
					bool flag7 = value < 0f;
					double num17 = 0.0;
					if (!flag7)
					{
						bool flag8 = !((double)value > 1.0);
						num17 = value;
						if (!flag8)
						{
							num17 = 1.0;
						}
					}
					double num18 = num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF50]");
					double num19 = num18 * 0.0;
					double num20 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA24]");
					double num21 = num20 + 0.0;
					obj = this + 112;
					double num22 = (double)obj * num21;
					st.wide = (float)num22;
					st.deep = (float)num22;
					float value2 = UnityEngine.Random.value;
					bool flag9 = value2 < 0f;
					double num23 = 0.0;
					if (!flag9)
					{
						bool flag10 = !((double)value2 > 1.0);
						num23 = value2;
						if (!flag10)
						{
							num23 = 1.0;
						}
					}
					double num24 = num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC90]");
					double num25 = num24 * 0.0;
					double num26 = num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC88]");
					double num27 = num26 + 0.0;
					double num28 = (double)obj * num27;
					st.goesAt = (float)num28;
					float value3 = UnityEngine.Random.value;
					bool flag11 = value3 < 0f;
					double num29 = 0.0;
					if (!flag11)
					{
						bool flag12 = !((double)value3 > 1.0);
						num29 = value3;
						if (!flag12)
						{
							num29 = 1.0;
						}
					}
					double num30 = num29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A80C]");
					double num31 = num30 * 0.0;
					double num32 = num31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					double num33 = num32 + 0.0;
					st.goesAfter = (float)num33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float heavy2 = UnityEngine.Random.Range(0f, 0.5f);
					st.heavy = heavy2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE84]");
					nint num34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A894]");
					slack = UnityEngine.Random.Range(num34, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A974]");
					obj8 = 0;
					obj9 = obj10;
					obj11 = obj12;
				}
			}
			else
			{
				bool flag13 = value < 0f;
				double num35 = 0.0;
				if (!flag13)
				{
					bool flag14 = !((double)value > 1.0);
					num35 = value;
					if (!flag14)
					{
						num35 = 1.0;
					}
				}
				double num36 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD0C]");
				double num37 = num36 * 0.0;
				double num38 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD60]");
				double num39 = num38 + 0.0;
				obj = this + 112;
				double num40 = (double)obj * num39;
				st.wide = (float)num40;
				st.deep = (float)num40;
				float value4 = UnityEngine.Random.value;
				float num41 = value4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num42 = num41 * 0f;
				float num43 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				float num44 = num43 * 0f;
				float num45 = num44 + num42;
				bool flag15 = num45 < 0f;
				double num46 = 0.0;
				if (!flag15)
				{
					bool flag16 = !((double)num45 > 1.0);
					num46 = num45;
					if (!flag16)
					{
						num46 = 1.0;
					}
				}
				double num47 = num46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC04]");
				double num48 = num47 * 0.0;
				double num49 = num48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
				double num50 = num49 + 0.0;
				double num51 = (double)obj * num50;
				st.goesAt = (float)num51;
				float value5 = UnityEngine.Random.value;
				float num52 = value5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num53 = num52 * 0f;
				float num54 = num44 + num53;
				bool flag17 = num54 < 0f;
				double num55 = 0.0;
				if (!flag17)
				{
					bool flag18 = !((double)num54 > 1.0);
					num55 = num54;
					if (!flag18)
					{
						num55 = 1.0;
					}
				}
				double num56 = num55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD98]");
				double num57 = num56 * 0.0;
				double num58 = num57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
				double num59 = num58 + 0.0;
				st.goesAfter = (float)num59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				float heavy3 = UnityEngine.Random.Range(num60, 0f);
				st.heavy = heavy3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF4C]");
				nint num61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC8C]");
				slack = UnityEngine.Random.Range(num61, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
				obj8 = 0;
				obj9 = obj10;
				obj11 = obj12;
			}
			object obj14 = default;
			object obj15 = default;
			object obj13 = obj14 - obj15;
			object obj17 = default;
			object obj16 = obj9 - obj17;
			object obj19 = default;
			object obj18 = obj11 - obj19;
			float beadBig = (float)obj * (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FA8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj21 = 0;
			st.slack = slack;
			st.beadBig = beadBig;
			object obj22 = 40;
			double num62 = 0.0;
			Vector3 flatWay = default;
			while (true)
			{
				bool flag19 = num62 < 0.0;
				double num63 = 0.0;
				if (!flag19)
				{
					bool flag20 = !(num62 > 1.0);
					num63 = num62;
					if (!flag20)
					{
						num63 = 1.0;
					}
				}
				Vector3[] was = st.was;
				if (st.was == null)
				{
					break;
				}
				bool flag21 = num62 < (double)was.Length;
				object obj23 = !flag21;
				if (obj23 == null)
				{
					double num64 = (double)obj13 * num63;
					double num65 = (double)obj16 * num63;
					object obj24 = (object)st.was + obj22;
					double num66 = (double)obj18 * num63;
					Vector3[] at = st.at;
					double num67 = (double)obj15 + num64;
					double num68 = (double)obj17 + num65;
					double num69 = (double)obj19 + num66;
					obj24 = num69;
					if (st.at == null)
					{
						break;
					}
					bool flag22 = num62 < (double)at.Length;
					object obj25 = !flag22;
					if (obj25 == null)
					{
						object obj26 = (object)st.at + obj22;
						obj22 += 12;
						num62++;
						obj26 = num69;
						if ((nint)obj22 != 148)
						{
							continue;
						}
						Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
						object obj27 = obj13 * obj13;
						object obj28 = obj16 * obj16;
						object obj29 = obj27 + obj28;
						object obj30 = obj18 * obj18;
						object obj31 = obj30 + obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
						if ((nint)obj31 <= 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj32 = 0;
							object obj33 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v30+A0]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v31+18]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v31+1C]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v31+20]");
							obj18 = 0;
						}
						object obj35 = obj13 * obj13;
						object obj36 = obj16 * obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
						object obj37 = 0;
						object obj38 = obj37;
						object obj39 = obj35 + obj36;
						object obj40 = obj18 * obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v16+A0]");
						object obj41 = 0;
						object obj42 = obj40 + obj39;
						bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41);
						double num70 = 1.0;
						double num71 = num67;
						double num72 = num69;
						if (!flag23)
						{
							double num73 = num69 * (double)obj13;
							double num74 = 1.0 * (double)obj16;
							num68 = num67 * (double)obj18;
							double num75 = num73 + num74;
							double num76 = num68 + num75;
							double num77 = num76 / (double)obj42;
							double num78 = (double)obj13 * num77;
							double num79 = (double)obj16 * num77;
							double num80 = (double)obj18 * num77;
							num72 = num69 - num78;
							num70 = 1.0 - num79;
							num71 = num67 - num80;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						float num81 = UnityEngine.Random.Range(0f, 3f);
						double num82 = num72 * (double)num81;
						double num83 = num70 * (double)num81;
						double num84 = num71 * (double)num81;
						st.drift = (Vector3)num82;
						float hangsFor = UnityEngine.Random.Range(2.5f, 6f);
						st.hangsFor = hangsFor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						nint num85 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC54]");
						float num86 = UnityEngine.Random.Range(num85, 0f);
						object obj43 = 17281024 + 3992;
						bool flag24 = st.kind == 0;
						float num87 = num86 * size;
						float num88 = num87;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X9_v12+v170 @ Z_v15 (System.Boolean)*4]");
						float stub = num88 * 0f;
						st.stub = stub;
						int cut = UnityEngine.Random.Range(2, 6);
						st.cut = cut;
						float beadAt = UnityEngine.Random.Range(5f, 11f);
						st.beadAt = beadAt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
						nint num89 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
						float num90 = UnityEngine.Random.Range(num89, 0f);
						float beadGrows = num90 * st.heavy;
						st.beadGrows = beadGrows;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFDC]");
						float waves = UnityEngine.Random.Range(2f, 0f);
						st.waves = waves;
						float value6 = UnityEngine.Random.value;
						float num91 = value6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A84C]");
						float phase = num91 * 0f;
						st.phase = phase;
						float value7 = UnityEngine.Random.value;
						st.tone = value7;
						if ((object)anchors == null)
						{
							break;
						}
						System.__Canon _Canon = ((List<System.__Canon>)(object)anchors).get_Item((int)st.onA);
						object obj44 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v24+E4]");
						bool flag25 = (nint)0 == 0;
						object obj45 = !flag25;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)(object)_Canon != null)
						{
							if (_Canon == null)
							{
								break;
							}
							Vector3 vector = ((Transform)(object)_Canon).InverseTransformDirection((Vector3)0);
						}
						st.flatWay = flatWay;
						return;
					}
				}
				goto IL_094e;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_094e;
		IL_094e:
		throw new IndexOutOfRangeException();
	}

	private int Anchor(Transform t)
	{
		//IL_01c0: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003a: Expected I4, but got I8
		//IL_00f1: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		int num;
		if ((object)anchors != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90D0]");
			object obj = 0;
			num = ((List<System.__Canon>)(object)anchors).IndexOf((System.__Canon)(object)t);
			if ((int)(num & 0x80000000L) == 0)
			{
				goto IL_01df;
			}
			List<System.__Canon> list = (List<System.__Canon>)(object)anchors;
			if ((object)anchors != null)
			{
				System.__Canon[] items = list._items;
				int version = list._version + 1;
				list._version = version;
				if (list._items != null)
				{
					bool flag = list._size < items.Length;
					object obj2 = !flag;
					if (obj2 == null)
					{
						object obj3 = list._items + list._size;
						int num2 = list._size + 1;
						list._size = num2;
						object obj4 = obj3 + 32;
						obj4 = t;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						((List<System.__Canon>)(object)anchors).AddWithResize((System.__Canon)(object)t);
					}
					List<Transform> list2 = anchors;
					if ((object)anchors != null)
					{
						num = list2._size - 1;
						goto IL_01df;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_01df:
		return num;
	}

	private unsafe End Rigid(Transform t, Vector3 world)
	{
		//IL_00b8: Expected VT, but got Obj
		//IL_0039: Expected VT, but got I4
		//IL_0045: Expected native int or pointer, but got VT
		//IL_0053: Expected native int or pointer, but got VT
		//IL_0061: Expected native int or pointer, but got VT
		//IL_006e: Expected native int or pointer, but got VT
		//IL_0081: Expected native int or pointer, but got VT
		//IL_0099: Expected VT, but got I4
		//IL_0094: Expected native int or pointer, but got VT
		int b = Anchor(t);
		if ((object)t != null)
		{
			End result = (End)t.InverseTransformPoint((Vector3)0);
			End end = default;
			((End*)(nint)end)->b0 = b;
			((End*)(nint)end)->w1 = 0f;
			((End*)(nint)end)->w0 = 1f;
			Vector3 p = default;
			((End*)(nint)end)->p0 = p;
			((End*)(nint)end)->b1 = -1;
			((End*)(nint)end)->p1 = (Vector3)0;
			_ = 0;
			_ = 0;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (End)ex;
	}

	private unsafe static void InsideOf(Transform half, List<Spot> found, List<Vector3> rim)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_10f8: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_0ed7: Expected Obj, but got I
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0474: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I4
		//IL_0f4c: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I
		//IL_054d: Expected I, but got Obj
		//IL_0574: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I4
		//IL_05d1: Expected VT, but got I4
		//IL_10d1: Expected Obj, but got I4
		//IL_0f81: Expected Obj, but got I
		//IL_0f91: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		//IL_063c: Expected Obj, but got I4
		//IL_066c: Expected Obj, but got I
		//IL_068e: Expected I4, but got Obj
		//IL_068e: Expected Obj, but got I
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected Obj, but got Unknown
		//IL_0942: Expected Obj, but got I4
		//IL_094a: Expected VT, but got Obj
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected Obj, but got Unknown
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected Obj, but got Unknown
		//IL_06e5: Expected VT, but got Obj
		//IL_097e: Expected Obj, but got I
		//IL_0986: Expected VT, but got Obj
		//IL_071d: Expected Obj, but got I4
		//IL_09be: Expected Obj, but got I4
		//IL_0feb: Expected Obj, but got I
		//IL_1020: Expected Obj, but got I
		//IL_075f: Expected I4, but got Obj
		//IL_075f: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I
		//IL_09f8: Expected I4, but got Obj
		//IL_09f8: Expected Obj, but got I
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected Obj, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a52: Expected Obj, but got I
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_083a: Expected Obj, but got I4
		//IL_0afc: Expected I4, but got Obj
		//IL_0afc: Expected Obj, but got I
		//IL_0c3a: Expected Obj, but got I
		//IL_0c4a: Expected Obj, but got I
		//IL_0c5f: Expected VT, but got I
		//IL_0c77: Expected VT, but got I
		//IL_089f: Expected Obj, but got I
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_08ca: Expected Obj, but got I
		//IL_08e9: Expected VT, but got Obj
		//IL_1116: Expected Obj, but got I
		//IL_1140: Expected Obj, but got I4
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0c8c: Expected Obj, but got I
		//IL_0ca4: Expected Obj, but got I
		//IL_0cbc: Expected Obj, but got I
		//IL_1058: Unsupported input type for neg.
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected Obj, but got Unknown
		//IL_106e: Expected Obj, but got I
		//IL_1080: Expected Obj, but got Ref
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0cd1: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got I
		//IL_0cf7: Expected Obj, but got I
		//IL_0d54: Expected Obj, but got I4
		//IL_0e21: Expected Obj, but got I
		//IL_0e31: Expected Obj, but got I
		//IL_0e41: Expected Obj, but got I
		//IL_0e4e: Expected VT, but got Ref
		//IL_0e5b: Expected Obj, but got I8
		//IL_0e64: Expected Obj, but got I4
		//IL_0e6f: Expected Obj, but got I4
		//IL_0e87: Expected Obj, but got I
		//IL_0e90: Expected Obj, but got I4
		//IL_0e99: Expected Obj, but got I4
		//IL_0ea1: Expected VT, but got Ref
		//IL_0d78: Expected Obj, but got I
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected Obj, but got Unknown
		//IL_0da3: Expected Obj, but got I
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected Obj, but got Unknown
		//IL_0de1: Expected Obj, but got I4
		//IL_0df9: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I4
		//IL_0e0c: Expected VT, but got I4
		if ((object)half != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9038]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9048]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69D8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
				object obj7 = 0;
				object obj8 = 0;
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj10 = 0;
				object obj14 = default;
				object obj15 = default;
				object obj37 = default;
				object obj52 = default;
				object obj54 = default;
				object obj56 = default;
				object obj58 = default;
				object obj59 = default;
				object obj61 = default;
				object obj63 = default;
				object obj64 = default;
				object obj70 = default;
				object obj76 = default;
				object obj105 = default;
				object obj110 = default;
				object obj136 = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj11 = !flag;
					if (obj11 != null)
					{
						break;
					}
					object obj12 = obj2 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
						string text = ((UnityEngine.Object)0).name;
						bool flag2 = text != (string)obj4;
						bool flag3 = !flag2;
						object obj13 = !flag3;
						obj14 = obj14;
						obj15 = obj15;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
							Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj16 = 0;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v15+E4]");
							bool flag4 = (nint)0 == 0;
							object obj18 = !flag4;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag5 = sharedMesh == null;
							bool flag6 = !flag5;
							object obj19 = !flag6;
							obj14 = obj14;
							obj15 = obj15;
							Mesh mesh = sharedMesh;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
								Mesh sharedMesh2 = ((MeshFilter)0).sharedMesh;
								if ((object)sharedMesh2 != null)
								{
									bool isReadable = sharedMesh2.isReadable;
									bool flag7 = !isReadable;
									obj14 = obj14;
									obj15 = obj15;
									mesh = sharedMesh;
									if (flag7)
									{
										goto IL_0ec7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
									Mesh sharedMesh3 = ((MeshFilter)0).sharedMesh;
									object obj20 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v16+E4]");
									bool flag8 = (nint)0 == 0;
									object obj21 = !flag8;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if ((object)sharedMesh3 != null)
									{
										object obj22 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v17+A0]");
										object obj23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v18+30]");
										sharedMesh3.GetVertices((List<Vector3>)0);
										object obj24 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v19+A0]");
										object obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v20+38]");
										sharedMesh3.GetNormals((List<Vector3>)0);
										object obj26 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v21+A0]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v22+40]");
										List<Vector2> list = (List<Vector2>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v22+40]");
										sharedMesh3.GetUVs(2, (List<Vector2>)0);
										object obj28 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v28+A0]");
										object obj29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+38]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+38]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+30]");
											object obj31 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+30]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X9_v11+18]");
												nint num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v7+18]");
												bool flag9 = num != 0;
												obj14 = obj14;
												obj15 = obj15;
												nint num2 = unchecked((nint)null);
												mesh = sharedMesh3;
												if (flag9)
												{
													goto IL_0ec7;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v28+E4]");
												bool flag10 = (nint)0 == 0;
												object obj32 = !flag10;
												if (obj32 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													object obj33 = obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v73+A0]");
													obj29 = 0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+40]");
												object obj34 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+40]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+30]");
													object obj35 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v24+30]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X9_v14+18]");
														nint num3 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v25+18]");
														bool flag11 = num3 != 0;
														obj14 = obj14;
														obj15 = obj15;
														num2 = unchecked((nint)null);
														mesh = sharedMesh3;
														if (flag11)
														{
															goto IL_0ec7;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
														Transform transform = ((Component)0).transform;
														if ((object)transform != null)
														{
															Matrix4x4 localToWorldMatrix = transform.localToWorldMatrix;
															obj14 = obj14;
															obj15 = obj15;
															object obj36 = 0;
															mesh = null;
															obj10 = obj37;
															Spot spot = (Spot)0;
															while (true)
															{
																object obj38 = obj5;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+E4]");
																bool flag12 = (nint)0 == 0;
																object obj39 = !flag12;
																if (obj39 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	obj38 = obj5;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+A0]");
																object obj40 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+30]");
																object obj41 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+30]");
																if ((nint)0 == 0)
																{
																	break;
																}
																Mesh mesh2 = mesh;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v17+18]");
																bool flag13 = (nint)mesh2 >= 0;
																num2 = unchecked((nint)null);
																if (!flag13)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+E4]");
																	bool flag14 = (nint)0 == 0;
																	object obj42 = !flag14;
																	if (obj42 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		object obj43 = obj5;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v71+A0]");
																		obj40 = 0;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+40]");
																	if ((nint)0 == 0)
																	{
																		break;
																	}
																	list = (List<Vector2>)obj6;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v31+40]");
																	Vector2 vector = ((List<Vector2>)0).get_Item((int)mesh);
																	object obj44 = obj10;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E8]");
																	obj10 = obj44 / 0;
																	object obj45 = obj10;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
																	if ((nint)obj45 < 0)
																	{
																		bool flag15 = rim == null;
																		spot = (Spot)mesh;
																		if (!flag15)
																		{
																			object obj46 = obj5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v67+E4]");
																			bool flag16 = (nint)0 == 0;
																			object obj47 = !flag16;
																			if (obj47 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				obj46 = obj5;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v67+A0]");
																			object obj48 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v66+30]");
																			if ((nint)0 == 0)
																			{
																				break;
																			}
																			list = (List<Vector2>)obj7;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v66+30]");
																			Vector3 vector2 = ((List<Vector3>)0).get_Item((int)mesh);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			object obj49 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																			object obj50 = (nint)0 + (nint)1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			if ((nint)0 == 0)
																			{
																				break;
																			}
																			object obj51 = 0 * obj52;
																			object obj53 = obj15 * obj54;
																			object obj55 = obj56 * obj10;
																			object obj57 = obj58 * obj59;
																			object obj60 = obj14 * obj61;
																			object obj62 = obj63 * obj64;
																			object obj65 = obj51 + obj53;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																			nint num4 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v67+18]");
																			bool flag17 = num4 < 0;
																			object obj66 = !flag17;
																			object obj67 = obj55 + obj57;
																			object obj68 = obj60 + obj65;
																			object obj69 = obj62 + obj67;
																			obj10 = obj70 + obj68;
																			obj64 = obj37 + obj69;
																			if (obj66 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				object obj71 = (nint)0 * (nint)12;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																				object obj72 = 0 + obj71;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rim @ X2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				object obj73 = (nint)0 + (nint)1;
																				obj59 = obj37;
																				spot = (Spot)mesh;
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
																				object obj74 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v68+A8]");
																				object obj75 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v69+70]");
																				rim.AddWithResize((Vector3)0);
																				obj59 = obj76;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v69+70]");
																				spot = (Spot)0;
																			}
																		}
																	}
																	else
																	{
																		object obj77 = mesh * 2863311531L;
																		object obj78 = obj77 >> 33;
																		object obj79 = obj78 + obj78;
																		object obj80 = obj36 + obj79;
																		bool flag18 = obj80 == null;
																		object obj81 = !flag18;
																		spot = (Spot)mesh;
																		if (obj81 == null)
																		{
																			object obj82 = obj10;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																			bool flag19 = (nint)obj82 < 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																			obj59 = 0;
																			spot = (Spot)mesh;
																			if (!flag19)
																			{
																				object obj83 = obj5;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v41+E4]");
																				bool flag20 = (nint)0 == 0;
																				object obj84 = !flag20;
																				if (obj84 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																					obj83 = obj5;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v41+A0]");
																				object obj85 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v40+30]");
																				if ((nint)0 == 0)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v40+30]");
																				Vector3 vector3 = ((List<Vector3>)0).get_Item((int)mesh);
																				object obj86 = 0 * obj52;
																				object obj87 = obj15 * obj54;
																				object obj88 = obj5;
																				object obj89 = obj56 * 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																				object obj90 = obj58 * 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v41+A0]");
																				object obj91 = 0;
																				object obj92 = obj86 + obj87;
																				object obj93 = obj14 * obj61;
																				object obj94 = obj63 * obj64;
																				object obj95 = obj89 + obj90;
																				object obj96 = obj93 + obj92;
																				object obj97 = obj94 + obj95;
																				object obj98 = obj70 + obj96;
																				object obj99 = obj37 + obj97;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v42+38]");
																				if ((nint)0 == 0)
																				{
																					break;
																				}
																				list = (List<Vector2>)obj7;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v42+38]");
																				Vector3 vector4 = ((List<Vector3>)0).get_Item((int)mesh);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
																				object obj100 = 0;
																				object obj101 = obj100;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v48+E4]");
																				bool flag21 = (nint)0 == 0;
																				object obj102 = !flag21;
																				if (obj102 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				}
																				object obj103 = 0 * obj61;
																				object obj104 = obj15 * obj105;
																				object obj106 = obj56 * obj99;
																				object obj107 = obj58 * obj98;
																				object obj108 = obj103 + obj104;
																				object obj109 = obj14 * obj110;
																				object obj111 = obj109 + obj108;
																				object obj112 = obj106 + obj107;
																				object obj113 = obj63 * obj37;
																				object obj114 = obj113 + obj112;
																				object obj115 = obj111 * obj111;
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
																				object obj116 = obj114 * obj114;
																				obj64 = obj116 + obj115;
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																				object obj117 = obj64;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																				object obj118;
																				if ((nint)obj117 > 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																					obj118 = obj114 / obj64;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																					object obj119 = obj111 / 0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																					object obj120 = 0;
																					object obj121 = obj120;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v61+A0]");
																					object obj122 = 0;
																					object obj119 = obj122;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v62+8]");
																					obj118 = 0;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
																				object obj123 = 0 - obj118;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v10+20]");
																				Transform transform2 = ((Component)0).transform;
																				object obj124 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 24));
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				if (found == null)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+10]");
																				object obj125 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9040]");
																				object obj126 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+1C]");
																				object obj127 = (nint)0 + (nint)1;
																				object obj128 = obj126;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+10]");
																				if ((nint)0 == 0)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
																				nint num5 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v55+18]");
																				bool flag22 = num5 < 0;
																				object obj129 = !flag22;
																				if (obj129 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
																					object obj130 = (nint)0 * (nint)40;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+10]");
																					object obj131 = 0 + obj130;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [found @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
																					object obj132 = (nint)0 + (nint)1;
																					object obj133 = obj131 + 56;
																					_ = 3212836864L;
																					_ = 0;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					obj59 = 0;
																					object obj53 = obj37;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																					object obj65 = 0;
																					obj10 = 0;
																					spot = (Spot)0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v25+20]");
																					object obj134 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v56+A8]");
																					object obj135 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v57+70]");
																					list = (List<Vector2>)0;
																					found.AddWithResize((Spot)(&obj136));
																					obj14 = 3212836864L;
																					obj15 = 0;
																					obj59 = 0;
																					object obj53 = obj37;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																					object obj65 = 0;
																					obj136 = 0;
																					obj10 = 0;
																					spot = (Spot)(&obj136);
																				}
																			}
																		}
																	}
																	mesh = (Mesh)(mesh + 1);
																	obj36--;
																	continue;
																}
																goto IL_0ec7;
															}
														}
													}
												}
											}
										}
									}
								}
								goto IL_0f0a;
							}
						}
						goto IL_0ec7;
					}
					goto IL_0f0a;
					IL_0ec7:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+18]");
					obj3 = 0;
					obj9++;
					object obj137 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+18]");
					if ((nint)obj137 >= 0)
					{
						return;
					}
				}
				goto IL_0f18;
			}
		}
		goto IL_0f0a;
		IL_0f18:
		throw new IndexOutOfRangeException();
		IL_0f0a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0f18;
	}

	private unsafe static bool CapOf(Transform piece, Vector3 cut, float near, List<Spot> found, int many, out Vector3 middle, out float round, out Vector3 into)
	{
		//IL_17b1: Expected Obj, but got I
		//IL_17c9: Expected Obj, but got I
		//IL_17cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e1: Expected F4, but got I
		//IL_17f1: Expected F4, but got I
		//IL_182d: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0159: Expected VT, but got Ref
		//IL_0079: Expected VT, but got Ref
		//IL_1339: Expected Obj, but got I
		//IL_1363: Expected Obj, but got I4
		//IL_0116: Expected VT, but got Ref
		//IL_0195: Expected Obj, but got I4
		//IL_009d: Expected VT, but got I4
		//IL_1087: Expected Obj, but got I4
		//IL_013a: Expected VT, but got I4
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Expected I4, but got Unknown
		//IL_01d0: Expected VT, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I4
		//IL_1381: Expected Obj, but got I
		//IL_13b5: Expected Obj, but got I
		//IL_13cd: Expected Obj, but got I
		//IL_13dd: Expected Obj, but got I
		//IL_140d: Expected Obj, but got I4
		//IL_141d: Expected VT, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_143b: Expected Obj, but got I
		//IL_1450: Expected Obj, but got I
		//IL_1468: Expected Obj, but got I
		//IL_1478: Expected Obj, but got I
		//IL_14b5: Expected VT, but got I
		//IL_0308: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_035a: Expected VT, but got I
		//IL_04c5: Expected Obj, but got I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got I4
		//IL_14fa: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_1586: Expected Obj, but got I
		//IL_15af: Expected VT, but got I4
		//IL_054f: Expected VT, but got I4
		//IL_03e9: Expected Obj, but got I
		//IL_03f9: Expected Obj, but got I
		//IL_0436: Expected VT, but got I
		//IL_0cc5: Expected Obj, but got I
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Expected Obj, but got I
		//IL_0ce9: Expected Obj, but got I
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected VT, but got Obj
		//IL_05a3: Expected Obj, but got I4
		//IL_1782: Expected Obj, but got I
		//IL_178a: Expected VT, but got Obj
		//IL_05e5: Expected Obj, but got I
		//IL_061b: Expected VT, but got I4
		//IL_0d20: Expected Obj, but got I4
		//IL_15cd: Expected Obj, but got I
		//IL_063b: Expected Obj, but got I
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_1535: Expected Obj, but got I
		//IL_153d: Expected VT, but got Obj
		//IL_0d55: Expected Obj, but got I
		//IL_0d72: Expected Obj, but got I
		//IL_0d9e: Expected VT, but got I4
		//IL_0b3b: Expected Obj, but got Ref
		//IL_0f43: Expected Obj, but got I4
		//IL_0dcd: Expected Obj, but got I4
		//IL_0dde: Expected VT, but got I4
		//IL_1650: Expected Obj, but got I
		//IL_1660: Expected Obj, but got I
		//IL_1675: Expected Obj, but got I
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Expected I4, but got Unknown
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got I4
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected Obj, but got I4
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected Obj, but got Unknown
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got I4
		//IL_0bf6: Invalid comparison between VT and I4
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_06d2: Expected Obj, but got I
		//IL_06f4: Expected Obj, but got I4
		//IL_109c: Expected Obj, but got I
		//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Expected Obj, but got Unknown
		//IL_0c34: Invalid comparison between VT and I4
		//IL_0c45: Expected Obj, but got Ref
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Expected Obj, but got Unknown
		//IL_11fc: Invalid comparison between F4 and I
		//IL_10f9: Expected VT, but got Ref
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected Obj, but got Unknown
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected Obj, but got I4
		//IL_1241: Expected Obj, but got I4
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Ref
		//IL_1282: Expected Obj, but got I4
		//IL_1226: Expected Obj, but got I4
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1743: Expected Obj, but got I
		//IL_1764: Expected Obj, but got Ref
		//IL_1764: Expected I4, but got VT
		//IL_1764: Expected VT, but got Obj
		//IL_1764: Expected Obj, but got I
		//IL_176d: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got I
		//IL_0794: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I
		//IL_07c1: Expected VT, but got I4
		//IL_07e7: Expected Obj, but got I
		//IL_0b52: Expected VT, but got I4
		//IL_081c: Expected Obj, but got I
		//IL_0839: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I4
		//IL_0860: Expected VT, but got I4
		//IL_088d: Expected VT, but got I4
		//IL_08bc: Expected Obj, but got I4
		//IL_08c4: Expected VT, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected Obj, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected Obj, but got Unknown
		//IL_0a36: Expected Obj, but got I4
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected Obj, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+A0]");
		object obj3 = 0;
		Enumerator<, > val = (Enumerator<, >)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+4]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+8]");
		float num2 = 0f;
		ref float reference = ref *(float*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+8]");
		_ = 0;
		((int*)many)->m_value = (int)obj3;
		ref Vector3 reference2 = ref *(Vector3*)null;
		bool flag = (object)piece == null;
		float num4 = default;
		float num3 = num4;
		int num5 = many;
		List<Spot> list = found;
		Vector3 vector = cut;
		Mesh sharedMesh;
		Mesh mesh;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D8]");
			object obj4 = 0;
			list = (List<Spot>)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj6 = default;
			object obj5 = obj6 & 1;
			if (obj5 != null)
			{
				MeshFilter meshFilter = default;
				bool flag2 = (object)meshFilter == null;
				num3 = num4;
				num5 = many;
				vector = (Vector3)(&meshFilter);
				if (!flag2)
				{
					sharedMesh = meshFilter.sharedMesh;
					Vector3 vector2 = (Vector3)0;
					goto IL_013f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9058]");
				object obj7 = 0;
				list = (List<Spot>)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
				object obj9 = default;
				object obj8 = obj9 & 1;
				SkinnedMeshRenderer skinnedMeshRenderer = default;
				if (obj8 == null)
				{
					mesh = null;
					Vector3 vector2 = (Vector3)(&skinnedMeshRenderer);
					goto IL_1329;
				}
				bool flag3 = (object)skinnedMeshRenderer == null;
				num3 = num4;
				num5 = many;
				vector = (Vector3)(&skinnedMeshRenderer);
				if (!flag3)
				{
					sharedMesh = skinnedMeshRenderer.sharedMesh;
					Vector3 vector2 = (Vector3)0;
					goto IL_013f;
				}
			}
		}
		goto IL_12a7;
		IL_0c0d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_0c7d;
		IL_0c2b:
		bool flag4 = vector != (Vector3)(object)1;
		Enumerator<, > val2;
		object obj10 = (object)(&val2);
		num5 = 0;
		IndexOutOfRangeException ex2;
		IndexOutOfRangeException ex = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			goto IL_0c7d;
		}
		goto IL_1567;
		IL_12a7:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_12b5;
		IL_107e:
		object obj11 = 0;
		goto IL_162d;
		IL_12b5:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_12c3;
		IL_14c3:
		Matrix4x4 localToWorldMatrix = piece.localToWorldMatrix;
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v54+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v54+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v35+48]");
		bool flag6 = (nint)0 == 0;
		num5 = 0;
		vector = (Vector3)0;
		if (flag6)
		{
			goto IL_12a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v35+48]");
		Enumerator<, > enumerator = ((List<int>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj17 = 0;
		Enumerator<, > val3 = default;
		val = val3;
		int num6 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		float num9 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		object obj33 = default;
		object obj34 = default;
		while (true)
		{
			vector = (Vector3)obj16;
			if (!val2.MoveNext())
			{
				break;
			}
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ X0_v62+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ X0_v62+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v45+30]");
			bool flag8 = (nint)0 == 0;
			num5 = 0;
			if (flag8)
			{
				goto IL_12c3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v45+58]");
			object obj21 = 0;
			list = (List<Spot>)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v45+30]");
			Vector3 vector3 = ((List<Vector3>)0).get_Item(num6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v45+58]");
			bool flag9 = (nint)0 == 0;
			num5 = 0;
			vector = (Vector3)num6;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X26_v13+18]");
				bool flag10 = (nint)num6 < (nint)0;
				object obj22 = !flag10;
				num5 = 0;
				vector = (Vector3)num6;
				if (obj22 == null)
				{
					object obj23 = obj24 * obj25;
					float num7 = (float)num6 * (float)obj26;
					float num8 = num9 * (float)val;
					float num10 = (float)obj27 * num;
					float num11 = (float)obj28 * (float)obj29;
					num2 = (float)obj30 * num2;
					object obj31 = num6 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v45+58]");
					object obj32 = 0 + obj31;
					num3 = (float)obj23 + num7;
					float num12 = num8 + num10;
					float num13 = num11 + num3;
					float num14 = num2 + num12;
					num = (float)obj33 + num13;
					val = (Enumerator<, >)(obj34 + num14);
					continue;
				}
				goto IL_12b5;
			}
			goto IL_12d1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
		object obj35 = 0;
		vector = (Vector3)obj35;
		val2.Dispose();
		num5 = 0;
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		IndexOutOfRangeException ex6 = default;
		ex = ex6;
		goto IL_1567;
		IL_0c7d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Enumerator<, > val4 = default;
		val2 = val4;
		obj10 = (object)(&val2);
		goto IL_14c3;
		IL_013f:
		mesh = sharedMesh;
		goto IL_1329;
		IL_1329:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v25+E4]");
		bool flag11 = (nint)0 == 0;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = mesh == null;
		bool flag13 = !flag12;
		object obj39 = !flag13;
		if (obj39 == null)
		{
			bool flag14 = (object)mesh == null;
			num3 = num4;
			num5 = many;
			list = null;
			vector = (Vector3)0;
			if (flag14)
			{
				goto IL_12a7;
			}
			if (mesh.isReadable)
			{
				int subMeshCount = mesh.subMeshCount;
				if (subMeshCount >= 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
					obj13 = 0;
					object obj40 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v37+E4]");
					bool flag15 = (nint)0 == 0;
					object obj41 = !flag15;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj40 = obj13;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v37+A0]");
					object obj42 = 0;
					int subMeshCount2 = mesh.subMeshCount;
					int num15 = subMeshCount2 - 1;
					Mesh mesh2 = mesh;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v25+48]");
					mesh2.GetTriangles((List<int>)0, num15);
					object obj43 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v41+A0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+48]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+48]");
					bool flag16 = (nint)0 == 0;
					num3 = num4;
					num5 = 0;
					list = (List<Spot>)num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v25+48]");
					vector = (Vector3)0;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X9_v11+18]");
						if ((nint)0 < (nint)9)
						{
							goto IL_107e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v41+E4]");
						bool flag17 = (nint)0 == 0;
						object obj46 = !flag17;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj47 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v105+A0]");
							obj44 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+30]");
						List<Vector3> list2 = (List<Vector3>)0;
						Mesh mesh3 = mesh;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+30]");
						mesh3.GetVertices((List<Vector3>)0);
						object obj48 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v44+A0]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+58]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+58]");
						bool flag18 = (nint)0 == 0;
						num3 = num4;
						num5 = 0;
						list = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+30]");
						vector = (Vector3)0;
						if (!flag18)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+30]");
							object obj51 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+30]");
							bool flag19 = (nint)0 == 0;
							num3 = num4;
							num5 = 0;
							list = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+30]");
							vector = (Vector3)0;
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X8_v98+18]");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X9_v14+18]");
								if (num16 > 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v44+E4]");
									bool flag20 = (nint)0 == 0;
									object obj52 = !flag20;
									if (obj52 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj53 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X8_v102+A0]");
										object obj54 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v103+30]");
										obj51 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v103+30]");
										bool flag21 = (nint)0 == 0;
										num3 = num4;
										num5 = 0;
										list = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v27+30]");
										vector = (Vector3)0;
										if (flag21)
										{
											goto IL_12a7;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
									object obj55 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									object obj56 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X8_v99+A0]");
									object obj57 = (nint)0 + (nint)88;
									List<Vector3> list3 = default;
									obj57 = list3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									list2 = list3;
								}
								object obj58 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X0_v46+E4]");
								bool flag22 = (nint)0 == 0;
								object obj59 = !flag22;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag23 = (UnityEngine.Object)null != (UnityEngine.Object)null;
								bool flag24 = !flag23;
								num3 = num4;
								val2 = (Enumerator<, >)0;
								list = null;
								if (flag24)
								{
									goto IL_14c3;
								}
								bool flag25 = 0 == 0;
								num3 = num4;
								num5 = 0;
								list = null;
								vector = (Vector3)0;
								if (!flag25)
								{
									Transform[] bones = ((SkinnedMeshRenderer)null).bones;
									Matrix4x4[] bindposes = mesh.bindposes;
									object obj60 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X8_v61+E4]");
									bool flag26 = (nint)0 == 0;
									object obj61 = !flag26;
									if (obj61 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									BoneWeight[] array = WeightsOf(mesh);
									object obj62 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v62+A0]");
									object obj63 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v63+48]");
									bool flag27 = (nint)0 == 0;
									num3 = num4;
									num5 = 0;
									list = null;
									vector = (Vector3)0;
									if (!flag27)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v63+48]");
										Enumerator<, > enumerator2 = ((List<int>)0).GetEnumerator();
										object obj64 = bindposes + 32;
										num3 = num4;
										val = val4;
										list = null;
										object obj87 = default;
										float num11;
										float num7;
										float num20;
										float num26;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
											object obj65 = 0;
											vector = (Vector3)obj65;
											if (!val2.MoveNext())
											{
												break;
											}
											if (array == null)
											{
												goto IL_0b89;
											}
											bool flag28 = num6 < array.Length;
											object obj66 = !flag28;
											object obj69;
											if (obj66 == null)
											{
												object obj67 = obj13;
												object obj68 = array + num6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ X8_v81+30]");
												obj69 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1558 @ X0_v138+E4]");
												bool flag29 = (nint)0 == 0;
												object obj70 = !flag29;
												if (obj70 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj67 = obj13;
												}
												if (bones == null)
												{
													goto IL_0b9f;
												}
												bool flag30 = (nint)obj69 < bones.Length;
												object obj71 = !flag30;
												if (obj71 == null)
												{
													object obj72 = (object)bones + obj69;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X8_v83+20]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1558 @ X0_v138+A0]");
														object obj73 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X8_v87+58]");
														object obj74 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X8_v83+20]");
														Matrix4x4 localToWorldMatrix2 = ((Transform)0).localToWorldMatrix;
														bool flag31 = bindposes == null;
														vector = (Vector3)0;
														if (flag31)
														{
															goto IL_0b65;
														}
														object obj75 = obj13;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1750 @ X8_v89+A0]");
														object obj76 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1723 @ X8_v90+30]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
															object obj77 = 0;
															list = (List<Spot>)obj77;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1723 @ X8_v90+30]");
															Vector3 vector4 = ((List<Vector3>)0).get_Item(num6);
															bool flag32 = (nint)obj69 < bindposes.Length;
															object obj78 = !flag32;
															vector = (Vector3)num6;
															if (obj78 != null)
															{
																goto IL_0b73;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X8_v87+58]");
															bool flag33 = (nint)0 == 0;
															vector = (Vector3)num6;
															if (flag33)
															{
																goto IL_0bad;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1410 @ X19_v35+18]");
															bool flag34 = (nint)num6 < (nint)0;
															object obj79 = !flag34;
															vector = (Vector3)num6;
															if (obj79 == null)
															{
																object obj80 = obj64 + obj69;
																float num17 = num;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+10]");
																float num18 = num17 * 0f;
																float num19 = num;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+14]");
																num20 = num19 * 0f;
																object obj81 = val * obj80;
																Enumerator<, > val5 = val;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+4]");
																object obj82 = val5 * 0;
																Enumerator<, > val6 = val;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+8]");
																object obj83 = val6 * 0;
																float num21 = num;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+18]");
																float num22 = num21 * 0f;
																float num23 = num2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+20]");
																float num24 = num23 * 0f;
																float num25 = num2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+24]");
																num26 = num25 * 0f;
																float num27 = (float)obj81 + num18;
																float num28 = (float)obj82 + num20;
																float num29 = (float)obj83 + num22;
																float num30 = num2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+28]");
																float num31 = num30 * 0f;
																float num32 = num27 + num24;
																float num33 = num28 + num26;
																float num34 = num29 + num31;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+30]");
																float num35 = 0f + num32;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+34]");
																float num36 = 0f + num33;
																object obj84 = num6 * 12;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X8_v87+58]");
																object obj85 = 0 + obj84;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v95+38]");
																float num37 = 0f + num34;
																object obj86 = obj87 * obj26;
																float num38 = num9 * num35;
																num7 = (float)num6 * (float)obj29;
																float num39 = (float)obj27 * num36;
																num11 = (float)obj28 * (float)obj25;
																float num40 = (float)obj30 * num37;
																num3 = (float)obj86 + num7;
																float num41 = num38 + num39;
																num2 = num3 + num11;
																float num42 = num41 + num40;
																num = (float)obj33 + num2;
																val = (Enumerator<, >)(obj34 + num42);
																continue;
															}
															goto IL_0bbb;
														}
														NullReferenceException ex7 = new NullReferenceException();
														vector = (Vector3)0;
													}
													NullReferenceException ex8 = new NullReferenceException();
													goto IL_0b65;
												}
												goto IL_0bc9;
											}
											goto IL_0bdf;
											IL_0b89:
											NullReferenceException ex9 = new NullReferenceException();
											obj69 = obj13;
											goto IL_0b9f;
											IL_0b9f:
											NullReferenceException ex10 = new NullReferenceException();
											goto IL_0bad;
											IL_0bbb:
											IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
											goto IL_0bc9;
											IL_0bdf:
											ex2 = new IndexOutOfRangeException();
											if (vector == (Vector3)(object)2)
											{
												goto IL_0c0d;
											}
											goto IL_0c2b;
											IL_0bc9:
											IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
											obj13 = obj69;
											goto IL_0bdf;
											IL_0bad:
											NullReferenceException ex13 = new NullReferenceException();
											goto IL_0bbb;
											IL_0b65:
											NullReferenceException ex14 = new NullReferenceException();
											goto IL_0b73;
											IL_0b73:
											IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
											obj13 = obj69;
											goto IL_0b89;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
										obj10 = (object)(&val2);
										object obj88 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v71+E4]");
										bool flag35 = (nint)0 == 0;
										object obj89 = !flag35;
										if (obj89 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj88 = obj13;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj90 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X0_v71+A0]");
										object obj91 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v50+48]");
										Vector3 vector5 = MiddleOf((List<int>)0, out System.Runtime.CompilerServices.Unsafe.As<Vector3, float>(ref middle));
										((int*)many)->m_value = (int)val;
										object obj92 = default;
										num11 = num2 - (float)obj92;
										num3 = (float)val - near;
										object obj93 = default;
										num7 = num - (float)obj93;
										float num43 = num3 * num3;
										float num44 = num7 * num7;
										float num45 = num43 + num44;
										float num46 = num11 * num11;
										num20 = num46 + num45;
										num26 = num4 * num4;
										if (num20 > num26)
										{
											goto IL_107e;
										}
										object obj94 = obj90;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1707 @ X0_v74+E4]");
										bool flag36 = (nint)0 == 0;
										object obj95 = !flag36;
										if (obj95 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										List<Spot> list4;
										Vector3 vector6;
										if ((UnityEngine.Object)null != (UnityEngine.Object)null)
										{
											Vector3 position = piece.position;
											Vector3 up = piece.up;
											Enumerator<, > val7 = val;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
											object obj96 = val7 * 0;
											float num47 = num;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
											float num48 = num47 * 0f;
											float num49 = num2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
											float num50 = num49 * 0f;
											val = (Enumerator<, >)(val + obj96);
											num += num48;
											num2 += num50;
											list4 = found;
											list = null;
											vector6 = cut;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9050]");
											object obj97 = 0;
											list = (List<Spot>)obj97;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
											object obj99 = default;
											object obj98 = obj99 & 1;
											if (obj98 != null)
											{
												Renderer renderer = default;
												bool flag37 = (object)renderer == null;
												num5 = 0;
												vector = (Vector3)(&renderer);
												if (flag37)
												{
													goto IL_12a7;
												}
												Bounds bounds = renderer.bounds;
												num2 = num9;
												float num51 = default;
												num = num51;
												list4 = found;
												Enumerator<, > val8 = default;
												val = val8;
												vector6 = cut;
											}
											else
											{
												Vector3 position2 = piece.position;
												list4 = found;
												vector6 = cut;
											}
										}
										object obj100 = val - ((int*)many)->m_value;
										float num52 = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [many @ X3 (System.Int32)+4]");
										float num53 = num52 - 0f;
										float num54 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [many @ X3 (System.Int32)+8]");
										float num55 = num54 - 0f;
										object obj101 = obj100 * obj100;
										float num56 = num53 * num53;
										float num57 = (float)obj101 + num56;
										float num58 = num55 * num55;
										float num59 = num57 + num58;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
										if (num59 > 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
											object obj102 = 0;
										}
										else
										{
											Vector3 forward = piece.forward;
											object obj102 = 0;
										}
										reference = ref *(float*)obj100;
										object obj103 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ X0_v81+E4]");
										bool flag38 = (nint)0 == 0;
										object obj104 = !flag38;
										if (obj104 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj103 = obj13;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ X0_v81+A0]");
										object obj105 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X8_v55+48]");
										Places((List<int>)0, (Vector3)piece, (Transform)(object)list4, (int)vector6, (List<Spot>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref middle));
										obj11 = 1;
										goto IL_162d;
									}
								}
							}
						}
					}
					goto IL_12a7;
				}
			}
		}
		goto IL_107e;
		IL_12c3:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_12d1;
		IL_1567:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_12d1:
		throw new NullReferenceException();
		IL_162d:
		return (byte)(obj11 & 1) != 0;
	}

	private unsafe static void TorsoCap(SkinnedMeshRenderer torso, Transform[] bones, BoneWeight[] weights, Vector3 near, float reach, Vector3 into, int many, List<Spot> found)
	{
		//IL_2836: Unknown result type (might be due to invalid IL or missing references)
		//IL_2874: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected VT, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected VT, but got I4
		//IL_028a: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got I4
		//IL_289a: Expected Obj, but got I
		//IL_28c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d4: Expected VT, but got I4
		//IL_28ff: Expected Obj, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected I4, but got Unknown
		//IL_04c6: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected F4, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected VT, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_2a24: Expected Obj, but got I
		//IL_18e4: Expected Obj, but got I4
		//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f5: Expected Obj, but got I4
		//IL_18f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1906: Expected VT, but got I4
		//IL_1927: Expected Obj, but got I4
		//IL_2b90: Expected Obj, but got I
		//IL_2b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba1: Expected Ref, but got Unknown
		//IL_2bbb: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected VT, but got I4
		//IL_194e: Expected Obj, but got I4
		//IL_194e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1956: Expected Obj, but got Unknown
		//IL_0594: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got I4
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected VT, but got I4
		//IL_198a: Expected Obj, but got I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I4
		//IL_2ced: Expected Obj, but got I4
		//IL_2925: Expected Obj, but got I
		//IL_2955: Expected Obj, but got I4
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_2959: Unknown result type (might be due to invalid IL or missing references)
		//IL_2966: Expected Obj, but got I4
		//IL_296a: Unknown result type (might be due to invalid IL or missing references)
		//IL_297e: Expected F4, but got I
		//IL_2987: Expected VT, but got I4
		//IL_27b6: Expected Obj, but got I4
		//IL_2a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a76: Expected Obj, but got I
		//IL_2ab3: Expected Obj, but got I4
		//IL_2abc: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_06a6: Expected I4, but got Obj
		//IL_06a6: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I4
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got I4
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected F4, but got I
		//IL_0704: Expected VT, but got I4
		//IL_19bf: Expected Obj, but got I
		//IL_2409: Expected Obj, but got I4
		//IL_2419: Expected Obj, but got I
		//IL_075d: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I4
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got I4
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected F4, but got I
		//IL_07a8: Expected VT, but got I4
		//IL_24bd: Expected Obj, but got I
		//IL_24da: Expected VT, but got Obj
		//IL_24ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2513: Expected Obj, but got I
		//IL_2550: Expected Obj, but got I4
		//IL_2558: Expected Obj, but got I4
		//IL_2560: Expected Obj, but got I4
		//IL_2569: Expected Obj, but got I4
		//IL_1a08: Expected Obj, but got I4
		//IL_1a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2449: Expected Obj, but got I
		//IL_2459: Expected Obj, but got I
		//IL_2496: Expected Obj, but got I4
		//IL_249f: Expected Obj, but got I4
		//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac2: Expected Obj, but got Unknown
		//IL_1adf: Expected I4, but got Obj
		//IL_1b20: Expected Obj, but got I4
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b39: Expected Obj, but got I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_0823: Expected Obj, but got I4
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got I4
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected F4, but got I
		//IL_0855: Expected VT, but got I4
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Expected Obj, but got I
		//IL_1a8d: Expected Obj, but got I4
		//IL_1a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected Obj, but got I4
		//IL_1b68: Expected Obj, but got I4
		//IL_1b8e: Expected Obj, but got I4
		//IL_1b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba7: Expected Obj, but got I4
		//IL_089c: Expected Obj, but got I
		//IL_08c8: Expected Obj, but got I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected Obj, but got I4
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected F4, but got I
		//IL_08fa: Expected VT, but got I4
		//IL_25be: Expected Obj, but got I4
		//IL_2b7b: Expected Obj, but got VT
		//IL_2b7b: Expected I4, but got VT
		//IL_2b7b: Expected Obj, but got VT
		//IL_2b7b: Expected VT, but got I4
		//IL_1bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0a: Expected Obj, but got I4
		//IL_1c1b: Expected Obj, but got I4
		//IL_0950: Expected Obj, but got I4
		//IL_0969: Expected Obj, but got I4
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected Obj, but got I4
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected F4, but got I
		//IL_099b: Expected VT, but got I4
		//IL_25ee: Expected Obj, but got I
		//IL_25fe: Expected Obj, but got I
		//IL_1c37: Expected Obj, but got I4
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected Obj, but got Unknown
		//IL_1c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Expected I4, but got Unknown
		//IL_1c82: Expected F4, but got I
		//IL_1c97: Expected Obj, but got I
		//IL_1cd8: Expected Obj, but got I4
		//IL_1ce0: Expected Obj, but got I4
		//IL_1ce9: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0bb6: Expected F4, but got I
		//IL_1d18: Expected Obj, but got I4
		//IL_1d3e: Expected Obj, but got I4
		//IL_1d46: Expected Obj, but got I4
		//IL_1d4f: Expected Obj, but got I4
		//IL_2c25: Expected F4, but got I
		//IL_0bfc: Expected Obj, but got I4
		//IL_0c1c: Expected F4, but got I
		//IL_0c35: Expected Obj, but got I4
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Expected Obj, but got I4
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected F4, but got I
		//IL_0c67: Expected VT, but got I4
		//IL_2a06: Expected Obj, but got I4
		//IL_1062: Expected Obj, but got I4
		//IL_1073: Expected Obj, but got I4
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Expected Obj, but got I4
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected F4, but got I
		//IL_10a5: Expected VT, but got I4
		//IL_1d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db2: Expected Obj, but got I4
		//IL_1dba: Expected Obj, but got I4
		//IL_1dc3: Expected Obj, but got I4
		//IL_2c43: Expected Obj, but got I
		//IL_2c53: Expected Obj, but got I
		//IL_2c73: Expected Obj, but got I4
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c84: Expected Obj, but got I4
		//IL_2c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c95: Expected VT, but got I4
		//IL_142e: Expected Obj, but got I4
		//IL_1437: Expected Obj, but got I4
		//IL_1437: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected Obj, but got I4
		//IL_144c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Expected F4, but got I
		//IL_1469: Expected VT, but got I4
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Obj, but got Unknown
		//IL_0ce6: Expected F4, but got I
		//IL_0cff: Expected Obj, but got I4
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected Obj, but got I4
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected F4, but got I
		//IL_0d31: Expected VT, but got I4
		//IL_1108: Expected Obj, but got I4
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1119: Expected Obj, but got I4
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1131: Expected F4, but got I
		//IL_113a: Expected VT, but got I4
		//IL_1ddf: Expected Obj, but got I4
		//IL_1def: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df4: Expected Obj, but got Unknown
		//IL_1e21: Expected I4, but got Obj
		//IL_1e21: Expected Obj, but got I
		//IL_1e62: Expected Obj, but got I4
		//IL_1e73: Expected Obj, but got I4
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected Obj, but got I4
		//IL_1840: Expected Obj, but got I4
		//IL_1840: Unknown result type (might be due to invalid IL or missing references)
		//IL_1844: Unknown result type (might be due to invalid IL or missing references)
		//IL_1851: Expected Obj, but got I4
		//IL_1855: Unknown result type (might be due to invalid IL or missing references)
		//IL_1862: Expected VT, but got I4
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Expected Obj, but got Unknown
		//IL_14d4: Expected Obj, but got I4
		//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Expected Obj, but got I4
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected F4, but got I
		//IL_1506: Expected VT, but got I4
		//IL_0d75: Expected Obj, but got I
		//IL_0d9c: Expected Obj, but got I4
		//IL_0dbc: Expected F4, but got I
		//IL_0dd5: Expected Obj, but got I4
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected Obj, but got I4
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected F4, but got I
		//IL_0e07: Expected VT, but got I4
		//IL_1179: Expected Obj, but got I
		//IL_1198: Expected Obj, but got I4
		//IL_11a1: Expected Obj, but got I4
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Expected Obj, but got I4
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ca: Expected F4, but got I
		//IL_11d3: Expected VT, but got I4
		//IL_1ea2: Expected Obj, but got I4
		//IL_1ec8: Expected Obj, but got I4
		//IL_1ed9: Expected Obj, but got I4
		//IL_1899: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Expected Obj, but got Unknown
		//IL_18ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b3: Expected Obj, but got Unknown
		//IL_18d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Expected Obj, but got I
		//IL_156c: Expected Obj, but got I4
		//IL_157d: Expected Obj, but got I4
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected Obj, but got I4
		//IL_1592: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Expected F4, but got I
		//IL_15af: Expected VT, but got I4
		//IL_0e4f: Expected Obj, but got I
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected Obj, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1035: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected F8, but got Unknown
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Expected Obj, but got Unknown
		//IL_1230: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Expected Obj, but got Unknown
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Expected Obj, but got Unknown
		//IL_12d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Expected Obj, but got Unknown
		//IL_1308: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Expected F8, but got Unknown
		//IL_1ef5: Expected Obj, but got I4
		//IL_1f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0a: Expected Obj, but got Unknown
		//IL_1f27: Expected Obj, but got I
		//IL_1f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Expected Obj, but got Unknown
		//IL_1f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f69: Expected Obj, but got Unknown
		//IL_1ff4: Invalid comparison between F4 and Obj
		//IL_15f7: Expected Obj, but got I
		//IL_1614: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Expected Obj, but got Unknown
		//IL_1629: Unknown result type (might be due to invalid IL or missing references)
		//IL_162e: Expected Obj, but got Unknown
		//IL_16b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Expected Obj, but got Unknown
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e5: Expected F8, but got Unknown
		//IL_2ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad8: Expected Obj, but got Unknown
		//IL_203a: Expected Obj, but got I4
		//IL_2b05: Expected Obj, but got I
		//IL_2b42: Expected Obj, but got I4
		//IL_2b53: Expected Obj, but got I4
		//IL_207c: Expected I4, but got Obj
		//IL_207c: Expected Obj, but got I
		//IL_2098: Expected Obj, but got I
		//IL_20d5: Expected Obj, but got I4
		//IL_20e6: Expected Obj, but got I4
		//IL_2111: Expected Obj, but got I
		//IL_212d: Expected Obj, but got I
		//IL_216a: Expected Obj, but got I4
		//IL_2172: Expected Obj, but got I4
		//IL_217b: Expected Obj, but got I4
		//IL_21a6: Expected I4, but got Obj
		//IL_21a6: Expected Obj, but got I
		//IL_21c2: Expected Obj, but got I
		//IL_21ff: Expected Obj, but got I4
		//IL_2210: Expected Obj, but got I4
		//IL_222b: Expected VT, but got I4
		//IL_2244: Expected Obj, but got I
		//IL_225c: Expected Obj, but got I
		//IL_2299: Expected Obj, but got I4
		//IL_22a1: Expected Obj, but got I4
		//IL_22a9: Expected Obj, but got I4
		//IL_22b1: Expected Obj, but got I4
		//IL_22ba: Expected Obj, but got I4
		//IL_22d5: Expected VT, but got I4
		//IL_22fc: Expected Obj, but got I
		//IL_2314: Expected Obj, but got I
		//IL_2351: Expected Obj, but got I4
		//IL_2359: Expected Obj, but got I4
		//IL_2361: Expected Obj, but got I4
		//IL_2369: Expected Obj, but got I4
		//IL_2372: Expected Obj, but got I4
		//IL_238d: Expected VT, but got I4
		//IL_23c2: Expected Obj, but got I
		//IL_23ca: Expected Obj, but got I4
		//IL_23d2: Expected Obj, but got I4
		//IL_23da: Expected Obj, but got I4
		bool flag = (object)torso == null;
		float num2 = default;
		float num = num2;
		double num4 = default;
		double num3 = num4;
		Enumerator<, > val = (Enumerator<, >)0;
		Vector3 vector = near;
		BoneWeight[] array = weights;
		List<Vector3> list = (List<Vector3>)(object)bones;
		float num6 = default;
		float num5 = num6;
		Mesh mesh = (Mesh)(object)torso;
		Transform[] array2 = bones;
		object obj = 109891584;
		object obj3 = default;
		object obj2 = obj3;
		float num28 = default;
		float num9;
		double num10;
		object obj27;
		float num11;
		double num25;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			object obj4 = 0;
			Mesh sharedMesh = torso.sharedMesh;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v70+E4]");
			Enumerator<, > val2 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v70+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (object)sharedMesh == null;
			num = num2;
			num3 = num4;
			val = (Enumerator<, >)0;
			vector = near;
			array = weights;
			list = null;
			num5 = num6;
			mesh = sharedMesh;
			array2 = bones;
			obj = 109891584;
			obj2 = obj3;
			if (!flag3)
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v71+A0]");
				object obj8 = 0;
				int subMeshCount = sharedMesh.subMeshCount;
				int submesh = subMeshCount - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v72+48]");
				sharedMesh.GetTriangles((List<int>)0, submesh);
				object obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v73+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v74+30]");
				list = (List<Vector3>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v74+30]");
				sharedMesh.GetVertices((List<Vector3>)0);
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v107+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v75+58]");
				val2 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v75+58]");
				bool flag4 = (nint)0 == 0;
				num = num2;
				num3 = num4;
				val = (Enumerator<, >)0;
				vector = (Vector3)0;
				array = null;
				num5 = num6;
				mesh = sharedMesh;
				array2 = bones;
				obj = 109891584;
				obj2 = obj3;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v75+30]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v75+30]");
					bool flag5 = (nint)0 == 0;
					num = num2;
					num3 = num4;
					val = (Enumerator<, >)0;
					vector = (Vector3)0;
					array = null;
					num5 = num6;
					mesh = sharedMesh;
					array2 = bones;
					obj = 109891584;
					obj2 = obj3;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v122+18]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v122+18]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+18]");
						if (num7 > 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v107+E4]");
							val2 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v107+E4]");
							bool flag6 = (nint)0 == 0;
							object obj15 = !flag6;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj16 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X8_v126+A0]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v127+30]");
								obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v127+30]");
								bool flag7 = (nint)0 == 0;
								num = num2;
								num3 = num4;
								val = (Enumerator<, >)0;
								vector = (Vector3)0;
								array = null;
								num5 = num6;
								mesh = sharedMesh;
								array2 = bones;
								obj = 109891584;
								obj2 = obj3;
								if (flag7)
								{
									goto IL_2604;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj19 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v123+A0]");
							object obj20 = (nint)0 + (nint)88;
							object obj21 = default;
							obj20 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						Matrix4x4[] bindposes = sharedMesh.bindposes;
						object obj22 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X8_v79+E4]");
						val2 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X8_v79+E4]");
						bool flag8 = (nint)0 == 0;
						object obj23 = !flag8;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj22 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X8_v79+A0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v80+48]");
						bool flag9 = (nint)0 == 0;
						num = num2;
						num3 = num4;
						val = (Enumerator<, >)0;
						vector = (Vector3)0;
						array = null;
						list = null;
						num5 = num6;
						mesh = (Mesh)(object)bindposes;
						array2 = bones;
						obj = 109891584;
						obj2 = obj3;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v80+48]");
							Enumerator<, > enumerator = ((List<int>)0).GetEnumerator();
							int num8 = bindposes + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
							object obj26 = 0;
							obj27 = obj3;
							num9 = num2;
							num10 = num4;
							Enumerator<, > val3 = default;
							num11 = (float)val3;
							array = null;
							val2 = (Enumerator<, >)(ref val);
							obj = 109891584;
							List<int> list2 = default;
							object obj42 = default;
							object obj44 = default;
							Enumerator<, > val5 = default;
							object obj50 = default;
							object obj52 = default;
							object obj54 = default;
							object obj56 = default;
							object obj57 = default;
							object obj58 = default;
							object obj61 = default;
							object obj62 = default;
							object obj63 = default;
							object obj71 = default;
							Enumerator<, > val6 = default;
							Enumerator<, > val7 = default;
							Enumerator<, > val8 = default;
							object obj29;
							object obj30;
							Enumerator<, > val4;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
								object obj28 = 0;
								list = (List<Vector3>)obj28;
								if (!val.MoveNext())
								{
									break;
								}
								bool flag10 = weights == null;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								vector = (Vector3)0;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag10)
								{
									goto IL_2668;
								}
								bool flag11 = (nint)list2 < weights.Length;
								object obj31 = !flag11;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								vector = (Vector3)0;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (obj31 != null)
								{
									goto IL_2676;
								}
								object obj32 = (object)weights + (object)list2;
								object obj33 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1992 @ X0_v118+E4]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+38]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1992 @ X0_v118+E4]");
								bool flag12 = (nint)0 == 0;
								object obj34 = !flag12;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj33 = obj4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1992 @ X0_v118+A0]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v91+30]");
								bool flag13 = (nint)0 == 0;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag13)
								{
									goto IL_2684;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
								object obj36 = 0;
								array = (BoneWeight[])obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X8_v91+30]");
								Vector3 vector2 = ((List<Vector3>)0).get_Item((int)list2);
								bool flag14 = bones == null;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								list = (List<Vector3>)(object)list2;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag14)
								{
									goto IL_264c;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+30]");
								bool flag15 = (nint)0 < (nint)bones.Length;
								object obj37 = !flag15;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								list = (List<Vector3>)(object)list2;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (obj37 != null)
								{
									goto IL_2692;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+30]");
								object obj38 = bones + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v95+20]");
								bool flag16 = (nint)0 == 0;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								list = (List<Vector3>)(object)list2;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag16)
								{
									goto IL_265a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v95+20]");
								Matrix4x4 localToWorldMatrix = ((Transform)0).localToWorldMatrix;
								bool flag17 = bindposes == null;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								list = null;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag17)
								{
									goto IL_263e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+30]");
								bool flag18 = (nint)0 < (nint)bindposes.Length;
								object obj39 = !flag18;
								num = num9;
								num3 = num10;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								vector = (Vector3)0;
								list = null;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (obj39 != null)
								{
									goto IL_2630;
								}
								int num12 = num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+30]");
								object obj40 = (nint)num12 + (nint)0;
								object obj41 = obj40 * obj42;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+10]");
								object obj43 = 0 * obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								float num13 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+8]");
								float num14 = num13 * 0f;
								double num15 = num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+18]");
								double num16 = num15 * 0.0;
								object obj45 = obj41 + obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+20]");
								object obj46 = 0 * obj42;
								float num17 = num14 + (float)num16;
								float num18 = num9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+28]");
								float num19 = num18 * 0f;
								object obj47 = obj45 + obj46;
								float num20 = num17 + num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+30]");
								object obj48 = 0 + obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X8_v98+38]");
								float num21 = 0f + num20;
								object obj49 = val5 * obj50;
								object obj51 = (object)list2 * obj52;
								object obj53 = obj54 * obj48;
								object obj55 = obj56 * obj57;
								float num22 = (float)obj58 * num21;
								object obj59 = obj49 + obj51;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								object obj60 = obj59 + obj55;
								float num23 = (float)obj53 + num22;
								num3 = (double)obj61 + (double)obj60;
								float num24 = (float)obj62 + num23;
								num25 = num3 * (double)obj63;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+20]");
								double num26 = 0.0 * (double)num24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+24]");
								bool flag19 = 0 <= (nint)obj26;
								obj27 = obj62;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+20]");
								num = 0f;
								object obj64 = obj58;
								double num27 = num10;
								list = null;
								if (!flag19)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+38]");
									bool flag20 = (nint)0 < (nint)bones.Length;
									object obj65 = !flag20;
									num28 = (float)num25;
									obj27 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+20]");
									num = 0f;
									obj64 = obj58;
									num27 = num10;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+24]");
									num11 = 0f;
									vector = (Vector3)0;
									list = null;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj65 != null)
									{
										goto IL_26bc;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+38]");
									object obj66 = bones + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X8_v117+20]");
									bool flag21 = (nint)0 == 0;
									num28 = (float)num25;
									obj27 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+20]");
									num = 0f;
									obj64 = obj58;
									num27 = num10;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+24]");
									num11 = 0f;
									vector = (Vector3)0;
									list = null;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (flag21)
									{
										goto IL_2710;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X8_v117+20]");
									Matrix4x4 localToWorldMatrix2 = ((Transform)0).localToWorldMatrix;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+38]");
									bool flag22 = (nint)0 < (nint)bindposes.Length;
									object obj67 = !flag22;
									num28 = (float)num25;
									obj27 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+20]");
									num = 0f;
									obj64 = obj58;
									num27 = num10;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+24]");
									num11 = 0f;
									vector = (Vector3)0;
									list = null;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj67 != null)
									{
										goto IL_26ca;
									}
									int num29 = num8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+38]");
									object obj68 = (nint)num29 + (nint)0;
									object obj69 = obj68 * obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+10]");
									object obj70 = 0 * obj71;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+20]");
									object obj72 = 0 * obj42;
									object obj73 = obj69 + obj70;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									float num30 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+8]");
									float num31 = num30 * 0f;
									double num32 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+18]");
									double num33 = num32 * 0.0;
									object obj74 = obj73 + obj72;
									float num34 = num9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+28]");
									float num35 = num34 * 0f;
									float num36 = num31 + (float)num33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+30]");
									object obj75 = 0 + obj74;
									float num37 = num36 + num35;
									obj55 = obj54 * obj75;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X8_v120+38]");
									float num38 = 0f + num37;
									double num39 = (double)val6 * (double)obj50;
									object obj76 = (object)list2 * obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									float num40 = (float)obj58 * num38;
									object obj77 = obj56 * obj57;
									double num41 = num39 + (double)obj76;
									float num42 = (float)obj55 + num40;
									double num43 = num41 + (double)obj77;
									num = (float)obj62 + num42;
									double num44 = (double)obj61 + num43;
									double num45 = num44 * (double)obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+24]");
									float num46 = 0f * num;
									num25 += num45;
									num26 += (double)num46;
									double num47 = num10;
									obj27 = obj62;
									num3 = num46;
									obj64 = obj56;
									num27 = (double)val6;
									list = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+28]");
								if (0 > (nint)obj26)
								{
									bool flag23 = (nint)obj < bones.Length;
									object obj78 = !flag23;
									num28 = (float)num25;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+28]");
									num11 = 0f;
									vector = (Vector3)0;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj78 != null)
									{
										goto IL_26e6;
									}
									object obj79 = (object)bones + obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X8_v112+20]");
									bool flag24 = (nint)0 == 0;
									num28 = (float)num25;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+28]");
									num11 = 0f;
									vector = (Vector3)0;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (flag24)
									{
										goto IL_26d8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X8_v112+20]");
									Matrix4x4 localToWorldMatrix3 = ((Transform)0).localToWorldMatrix;
									bool flag25 = (nint)obj < bindposes.Length;
									object obj80 = !flag25;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+28]");
									num11 = 0f;
									vector = (Vector3)0;
									list = null;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj80 != null)
									{
										goto IL_2734;
									}
									object obj81 = num8 + obj;
									object obj82 = obj81 * obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+10]");
									object obj83 = 0 * obj71;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+20]");
									object obj84 = 0 * obj42;
									object obj85 = obj82 + obj83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									float num48 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+8]");
									float num49 = num48 * 0f;
									double num50 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+18]");
									double num51 = num50 * 0.0;
									object obj86 = obj85 + obj84;
									float num52 = num9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+28]");
									float num53 = num52 * 0f;
									float num54 = num49 + (float)num51;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+30]");
									object obj87 = 0 + obj86;
									float num55 = num54 + num53;
									obj55 = obj54 * obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ X8_v115+38]");
									float num56 = 0f + num55;
									double num57 = (double)val7 * (double)obj50;
									object obj88 = (object)list2 * obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									float num58 = (float)obj58 * num56;
									object obj89 = obj56 * obj57;
									double num59 = num57 + (double)obj88;
									float num60 = (float)obj55 + num58;
									double num61 = num59 + (double)obj89;
									num = (float)obj62 + num60;
									double num62 = (double)obj61 + num61;
									double num63 = num62 * (double)obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+28]");
									float num64 = 0f * num;
									num25 += num63;
									num26 += (double)num64;
									double num47 = num10;
									obj27 = obj62;
									num3 = num64;
									obj64 = obj56;
									num27 = (double)val7;
									list = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								bool flag26 = 0 <= (nint)obj26;
								num28 = (float)num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
								num11 = 0f;
								if (!flag26)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+40]");
									bool flag27 = (nint)0 < (nint)bones.Length;
									object obj90 = !flag27;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									num11 = 0f;
									vector = (Vector3)0;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj90 != null)
									{
										goto IL_2726;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+40]");
									object obj91 = bones + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ X8_v107+20]");
									bool flag28 = (nint)0 == 0;
									num28 = (float)num25;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									num11 = 0f;
									vector = (Vector3)0;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (flag28)
									{
										goto IL_26f4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ X8_v107+20]");
									Matrix4x4 localToWorldMatrix4 = ((Transform)0).localToWorldMatrix;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+40]");
									bool flag29 = (nint)0 < (nint)bindposes.Length;
									object obj92 = !flag29;
									num28 = (float)num25;
									obj29 = 0;
									val = val3;
									obj30 = 0;
									val4 = (Enumerator<, >)(ref val);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									num11 = 0f;
									vector = (Vector3)0;
									list = null;
									num5 = num6;
									mesh = (Mesh)(object)bindposes;
									array2 = bones;
									obj2 = obj3;
									if (obj92 != null)
									{
										goto IL_2702;
									}
									int num65 = num8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+40]");
									object obj93 = (nint)num65 + (nint)0;
									object obj94 = obj93 * obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+10]");
									object obj95 = 0 * obj71;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+20]");
									object obj96 = 0 * obj42;
									object obj97 = obj94 + obj95;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									float num66 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+8]");
									float num67 = num66 * 0f;
									double num68 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+18]");
									double num69 = num68 * 0.0;
									object obj98 = obj97 + obj96;
									float num70 = num9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+28]");
									float num71 = num70 * 0f;
									float num72 = num67 + (float)num69;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+30]");
									object obj99 = 0 + obj98;
									float num73 = num72 + num71;
									obj55 = obj54 * obj99;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v110+38]");
									float num74 = 0f + num73;
									double num75 = (double)val8 * (double)obj50;
									object obj100 = (object)list2 * obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									float num76 = (float)obj58 * num74;
									object obj101 = obj56 * obj57;
									double num77 = num75 + (double)obj100;
									float num78 = (float)obj55 + num76;
									double num79 = num77 + (double)obj101;
									num = (float)obj62 + num78;
									double num80 = (double)obj61 + num79;
									num11 = (float)num80 * (float)obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X8_v90+2C]");
									float num81 = 0f * num;
									num28 = (float)num25 + num11;
									num26 += (double)num81;
									double num47 = num10;
									obj27 = obj62;
									num3 = num81;
									obj64 = obj56;
									num27 = (double)val8;
									list = null;
								}
								object obj102 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v127+E4]");
								bool flag30 = (nint)0 == 0;
								object obj103 = !flag30;
								if (obj103 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj102 = obj4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v127+A0]");
								object obj104 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v103+58]");
								object obj105 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v103+58]");
								bool flag31 = (nint)0 == 0;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								vector = (Vector3)0;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (flag31)
								{
									goto IL_26a0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v104+18]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v104+18]");
								bool flag32 = (nint)list2 < 0;
								object obj106 = !flag32;
								obj29 = 0;
								val = val3;
								obj30 = 0;
								val4 = (Enumerator<, >)(ref val);
								vector = (Vector3)0;
								num5 = num6;
								mesh = (Mesh)(object)bindposes;
								array2 = bones;
								obj2 = obj3;
								if (obj106 == null)
								{
									object obj107 = list2 * 12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v103+58]");
									object obj108 = 0 + obj107;
									num9 = num;
									num10 = num3;
									val2 = (Enumerator<, >)12;
									continue;
								}
								goto IL_26ae;
							}
							obj29 = 0;
							val = val3;
							obj30 = 0;
							val4 = (Enumerator<, >)(ref val);
							vector = (Vector3)0;
							num5 = num6;
							mesh = (Mesh)(object)bindposes;
							array2 = bones;
							object obj109 = 0;
							obj2 = obj3;
							object obj113 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
								object obj110 = 0;
								list = (List<Vector3>)obj110;
								((Enumerator<, >*)val4)->Dispose();
								bool flag33 = obj109 == null;
								object obj111 = !flag33;
								num25 = num28;
								if (obj111 == null)
								{
									bool flag34 = obj29 == null;
									object obj112 = !flag34;
									OutOfMemoryException ex = (OutOfMemoryException)val4;
									if (obj112 == null)
									{
										break;
									}
								}
								else
								{
									OutOfMemoryException ex = new OutOfMemoryException();
									num28 = (float)num25;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
								if ((nint)list == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj29 = 1;
									obj109 = obj30;
									continue;
								}
								if ((nint)list == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj109 = obj113;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj30 = obj113;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							obj2 *= obj2;
							num3 = num4;
							num6 = num5;
							array2 = (Transform[])2;
							int num82 = 0;
							while (true)
							{
								object obj114 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v9+E4]");
								bool flag35 = (nint)0 == 0;
								object obj115 = !flag35;
								if (obj115 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj114 = obj4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v9+A0]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
								List<int> list3 = (List<int>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
								bool flag36 = (nint)0 == 0;
								double num26 = 3.0;
								obj3 = obj27;
								num = num9;
								obj26 = 0;
								obj = 12;
								if (flag36)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v9+E4]");
								obj14 = 0;
								Transform[] array3 = array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ X0_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)array3 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v9+E4]");
									bool flag37 = (nint)0 == 0;
									object obj116 = !flag37;
									Enumerator<, > val9 = val2;
									if (obj116 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj117 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v44+A0]");
										val9 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v11 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
										list3 = (List<int>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v11 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
										bool flag38 = (nint)0 == 0;
										num26 = 3.0;
										obj3 = obj27;
										num = num9;
										obj26 = 0;
										val2 = val9;
										obj = 12;
										if (flag38)
										{
											break;
										}
									}
									array = (BoneWeight[])obj25;
									mesh = (Mesh)(array2 - 2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v11 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
									num8 = 0;
									int num83 = list3.get_Item((int)mesh);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v11 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
									bool flag39 = (nint)0 == 0;
									num26 = 3.0;
									obj3 = obj27;
									num = num9;
									obj26 = 0;
									val2 = val9;
									list = (List<Vector3>)(object)mesh;
									obj = 12;
									if (flag39)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ X20_v7 (System.Int32)+18]");
									bool flag40 = (nint)num83 < (nint)0;
									object obj118 = !flag40;
									num26 = 3.0;
									obj3 = obj27;
									num = num9;
									obj26 = 0;
									val2 = val9;
									list = (List<Vector3>)(object)mesh;
									obj = 12;
									if (obj118 == null)
									{
										object obj119 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2378 @ X8_v21+A0]");
										val2 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
										bool flag41 = (nint)0 == 0;
										num26 = 3.0;
										obj3 = obj27;
										num = num9;
										obj26 = 0;
										list = (List<Vector3>)(object)mesh;
										obj = 12;
										if (flag41)
										{
											break;
										}
										object obj120 = num83 * 12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v11 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
										obj14 = 0 + obj120;
										array = (BoneWeight[])obj25;
										int num84 = array2 - 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
										num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X10_v8+28]");
										num28 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
										int num85 = ((List<int>)0).get_Item(num84);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
										bool flag42 = (nint)0 == 0;
										num26 = 3.0;
										obj3 = obj27;
										num = num9;
										obj26 = 0;
										list = (List<Vector3>)num84;
										obj = 12;
										if (flag42)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ X20_v7 (System.Int32)+18]");
										bool flag43 = (nint)num85 < (nint)0;
										object obj121 = !flag43;
										num26 = 3.0;
										obj3 = obj27;
										num = num9;
										obj26 = 0;
										list = (List<Vector3>)num84;
										obj = 12;
										if (obj121 == null)
										{
											object obj122 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2592 @ X8_v24+A0]");
											val2 = (Enumerator<, >)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
											bool flag44 = (nint)0 == 0;
											num26 = 3.0;
											obj3 = obj27;
											num = num9;
											obj26 = 0;
											list = (List<Vector3>)num84;
											obj = 12;
											if (flag44)
											{
												break;
											}
											object obj123 = num85 * 12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
											obj14 = 0 + obj123;
											array = (BoneWeight[])obj25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
											num8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
											int num86 = ((List<int>)0).get_Item((int)array2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
											bool flag45 = (nint)0 == 0;
											num26 = 3.0;
											obj3 = obj27;
											num = num9;
											obj26 = 0;
											list = (List<Vector3>)(object)array2;
											obj = 12;
											if (flag45)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ X20_v7 (System.Int32)+18]");
											bool flag46 = (nint)num86 < (nint)0;
											object obj124 = !flag46;
											num26 = 3.0;
											obj3 = obj27;
											num = num9;
											obj26 = 0;
											list = (List<Vector3>)(object)array2;
											obj = 12;
											if (obj124 == null)
											{
												object obj125 = num86 * 12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+58]");
												object obj126 = 0 + obj125;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X10_v8+20]");
												nint num87 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X10_v8+20]");
												object obj127 = num87 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2670 @ X8_v27+20]");
												object obj128 = obj127 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X10_v8+28]");
												float num88 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X10_v8+28]");
												float num89 = num88 + 0f;
												object obj129 = obj128 / 0;
												float num90 = num89;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2670 @ X8_v27+28]");
												float num91 = num90 + 0f;
												double num92 = (double)num91 / 3.0;
												float num93 = (float)obj129 - num5;
												float num94 = num93 * num93;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
												double num95 = num92 - (double)num2;
												num3 = num95 * num95;
												num6 = num94 + (float)num3;
												bool flag47 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
												list = (List<Vector3>)(object)array2;
												if (!flag47)
												{
													object obj130 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2694 @ X0_v25+E4]");
													bool flag48 = (nint)0 == 0;
													object obj131 = !flag48;
													if (obj131 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj130 = obj4;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AB0]");
													num8 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2694 @ X0_v25+A0]");
													object obj132 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v30+48]");
													bool flag49 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													list = (List<Vector3>)(object)array2;
													obj = 12;
													if (flag49)
													{
														break;
													}
													array = (BoneWeight[])obj25;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v30+48]");
													int num96 = ((List<int>)0).get_Item((int)mesh);
													object obj133 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2697 @ X8_v31+A0]");
													object obj134 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2698 @ X8_v32+48]");
													bool flag50 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													list = (List<Vector3>)(object)mesh;
													obj = 12;
													if (flag50)
													{
														break;
													}
													array = (BoneWeight[])obj25;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2698 @ X8_v32+48]");
													int num97 = ((List<int>)0).get_Item(num84);
													object obj135 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2700 @ X8_v34+A0]");
													object obj136 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2701 @ X8_v35+48]");
													bool flag51 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													list = (List<Vector3>)num84;
													obj = 12;
													if (flag51)
													{
														break;
													}
													array = (BoneWeight[])obj25;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2701 @ X8_v35+48]");
													int num98 = ((List<int>)0).get_Item((int)array2);
													object obj137 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2703 @ X8_v37+A0]");
													object obj138 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2704 @ X8_v38+48]");
													bool flag52 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													list = (List<Vector3>)(object)array2;
													obj = 12;
													if (flag52)
													{
														break;
													}
													vector = (Vector3)((int*)num8)->m_value;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2704 @ X8_v38+48]");
													((List<int>)0).set_Item(num82, num96);
													object obj139 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2706 @ X8_v40+A0]");
													object obj140 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v41+48]");
													bool flag53 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													array = (BoneWeight[])num96;
													list = (List<Vector3>)num82;
													mesh = (Mesh)num98;
													obj = 12;
													if (flag53)
													{
														break;
													}
													vector = (Vector3)((int*)num8)->m_value;
													int num99 = num82 + 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v41+48]");
													((List<int>)0).set_Item(num99, num97);
													object obj141 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ X8_v42+A0]");
													object obj142 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v43+48]");
													bool flag54 = (nint)0 == 0;
													num26 = 3.0;
													obj3 = obj27;
													num = num5;
													obj26 = 0;
													array = (BoneWeight[])num97;
													list = (List<Vector3>)num99;
													mesh = (Mesh)num98;
													obj = 12;
													if (flag54)
													{
														break;
													}
													vector = (Vector3)((int*)num8)->m_value;
													int num100 = num82 + 2;
													num8 = num82 + 3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v43+48]");
													((List<int>)0).set_Item(num100, num98);
													array = (BoneWeight[])num98;
													list = (List<Vector3>)num100;
													mesh = (Mesh)num98;
													num82 = num8;
												}
												array2 = (Transform[])(array2 + 3);
												num9 = num5;
												continue;
											}
										}
									}
									goto IL_2612;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v9+E4]");
								bool flag55 = (nint)0 == 0;
								object obj143 = !flag55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
								List<int> list4 = (List<int>)0;
								if (obj143 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj144 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2271 @ X8_v17+A0]");
									object obj145 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v18+48]");
									list4 = (List<int>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v18+48]");
									bool flag56 = (nint)0 == 0;
									num26 = 3.0;
									obj3 = obj27;
									num = num9;
									obj26 = 0;
									obj = 12;
									if (flag56)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BC8]");
								object obj146 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
								int num101 = (int)(-num82);
								vector = (Vector3)obj146;
								list4.RemoveRange(num82, num101);
								object obj147 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v12+A0]");
								val2 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
								List<int> tris = (List<int>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X9_v17 (System.Collections.Generic.LowLevelDictionary`2<System.Int32>+Enumerator<System.Int32>)+48]");
								bool flag57 = (nint)0 == 0;
								num26 = 3.0;
								obj3 = obj27;
								num = num9;
								obj26 = 0;
								array = (BoneWeight[])num101;
								list = (List<Vector3>)num82;
								obj = 12;
								if (flag57)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2396 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)0 >= (nint)9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v12+E4]");
									bool flag58 = (nint)0 == 0;
									object obj148 = !flag58;
									if (obj148 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj149 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2544 @ X8_v15+A0]");
										object obj150 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2522 @ X8_v16+48]");
										tris = (List<int>)0;
									}
									Places(tris, (Vector3)0, (Transform)near, (int)into, (List<Spot>)into);
								}
								return;
							}
						}
					}
				}
			}
		}
		goto IL_2604;
		IL_264c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_265a;
		IL_26f4:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_2702;
		IL_2668:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_2676;
		IL_26e6:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_26f4;
		IL_26d8:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_26e6;
		IL_2734:
		num9 = num;
		num10 = num3;
		throw new IndexOutOfRangeException();
		IL_26a0:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_26ae;
		IL_2604:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_2612;
		IL_26bc:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_26ca;
		IL_2726:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_2734;
		IL_26ae:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_26bc;
		IL_2612:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		obj27 = obj3;
		num11 = num6;
		goto IL_2630;
		IL_26ca:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		goto IL_26d8;
		IL_2630:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		goto IL_263e;
		IL_2710:
		NullReferenceException ex15 = new NullReferenceException();
		num25 = num28;
		goto IL_2726;
		IL_2702:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		goto IL_2710;
		IL_2684:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_2692;
		IL_2692:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_26a0;
		IL_2676:
		IndexOutOfRangeException ex19 = new IndexOutOfRangeException();
		goto IL_2684;
		IL_265a:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_2668;
		IL_263e:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_264c;
	}

	private unsafe static Vector3 MiddleOf(List<int> tris, out float round)
	{
		//IL_0a8b: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected F8, but got I
		//IL_0065: Expected F8, but got Obj
		//IL_008d: Expected F8, but got I4
		//IL_05b3: Invalid comparison between F8 and I4
		//IL_0621: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_0125: Expected F8, but got Obj
		//IL_0135: Expected F8, but got I
		//IL_0145: Expected Obj, but got I
		//IL_014e: Expected F8, but got I4
		//IL_0c25: Expected Obj, but got I
		//IL_0c35: Expected Obj, but got I
		//IL_0c4d: Expected I, but got Obj
		//IL_0bbb: Expected Obj, but got I4
		//IL_0bda: Expected Obj, but got I
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected F8, but got I4
		//IL_0c10: Expected Obj, but got Ref
		//IL_0aa0: Expected Obj, but got I
		//IL_0aa8: Expected I, but got Obj
		//IL_0ac6: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I4
		//IL_08f9: Expected VT, but got Ref
		//IL_0902: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_06d5: Expected F8, but got I
		//IL_06e5: Expected F8, but got I
		//IL_0d45: Expected Ref, but got VT
		//IL_0d5f: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_0cb1: Expected Obj, but got I
		//IL_0cc1: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got I4
		//IL_0cea: Expected Obj, but got I4
		//IL_0cf2: Expected VT, but got Ref
		//IL_0cfb: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0242: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_02f0: Expected F8, but got I
		//IL_0921: Expected Obj, but got I4
		//IL_0939: Expected Obj, but got VT
		//IL_0751: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I4
		//IL_077c: Expected Obj, but got I4
		//IL_0785: Expected Obj, but got I4
		//IL_078d: Expected VT, but got Ref
		//IL_0796: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_0394: Expected F8, but got I
		//IL_0959: Expected Ref, but got F8
		//IL_07bb: Expected Obj, but got I4
		//IL_0845: Invalid comparison between F8 and I4
		//IL_0854: Invalid comparison between F8 and I4
		//IL_0867: Expected Obj, but got F8
		//IL_0874: Expected Obj, but got F8
		//IL_08a9: Expected Obj, but got I4
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03e2: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I
		//IL_0492: Expected F8, but got I
		//IL_09f2: Expected Obj, but got I4
		//IL_0a0b: Expected Obj, but got I4
		//IL_0d22: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_0526: Expected F8, but got I
		//IL_054f: Expected Obj, but got I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0574: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_0594: Expected Obj, but got I
		//IL_0b83: Expected Obj, but got I4
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected Obj, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected Obj, but got Unknown
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected Obj, but got Unknown
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected Obj, but got Unknown
		//IL_0fbd: Expected F8, but got I
		//IL_0fcd: Expected Obj, but got I
		//IL_0ff2: Expected F8, but got I
		//IL_1002: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
		object obj = 0;
		bool flag = tris == null;
		ref float reference = ref round;
		int num = 109891584;
		object obj3;
		object obj6;
		double num2;
		double num3;
		double num5;
		double num16;
		object obj8;
		double num15;
		double num13 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			obj3 = 0;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v16+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v17+8]");
			num2 = 0.0;
			num3 = (double)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag2 = (nint)0 < (nint)3;
			int num4 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref round);
			num5 = 0.0;
			if (flag2)
			{
				goto IL_05aa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj8 = 0;
			object obj10 = default;
			object obj9 = obj10;
			double num7 = default;
			double num6 = num7;
			object obj12 = default;
			object obj11 = obj12;
			double num9 = default;
			double num8 = num9;
			double num11 = default;
			double num10 = num11;
			object obj14 = default;
			object obj13 = obj14;
			object obj16 = default;
			object obj15 = obj16;
			object obj18 = default;
			object obj17 = obj18;
			object obj20 = default;
			object obj19 = obj20;
			double num12 = num13;
			ref float reference2 = ref round;
			nint num14 = default;
			IntPtr intPtr = num14;
			num15 = (double)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v17+8]");
			num16 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj21 = 0;
			double num17 = 0.0;
			num = 2;
			object obj43 = default;
			object obj44 = default;
			object obj48 = default;
			while (true)
			{
				object obj22 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v48+E4]");
				bool flag3 = (nint)0 == 0;
				object obj23 = !flag3;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = obj6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v48+A0]");
				obj = 0;
				num14 = (nint)obj7;
				int num18 = num - 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
				object obj24 = 0;
				int num19 = tris.get_Item(num18);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
				bool flag4 = (nint)0 == 0;
				obj10 = obj9;
				num7 = num6;
				obj12 = obj11;
				num9 = num8;
				num11 = num10;
				obj14 = obj13;
				obj16 = obj15;
				obj18 = obj17;
				obj20 = obj19;
				num13 = num12;
				reference = ref *(float*)num18;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
				bool flag5 = (nint)num19 < (nint)0;
				object obj25 = !flag5;
				obj10 = obj9;
				num7 = num6;
				obj12 = obj11;
				num9 = num8;
				num11 = num10;
				obj14 = obj13;
				obj16 = obj15;
				obj18 = obj17;
				obj20 = obj19;
				num13 = num12;
				reference = ref *(float*)num18;
				if (obj25 == null)
				{
					object obj26 = num19 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
					obj = 0 + obj26;
					object obj27 = obj6;
					num14 = (nint)obj7;
					int num20 = num - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X9_v16+A0]");
					obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
					obj24 = 0;
					int num21 = tris.get_Item(num20);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
					bool flag6 = (nint)0 == 0;
					obj10 = obj9;
					num7 = num6;
					obj12 = obj11;
					num9 = num8;
					num11 = num10;
					obj14 = obj13;
					obj16 = obj15;
					obj18 = obj17;
					obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
					num13 = 0.0;
					reference = ref *(float*)num20;
					if (flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
					bool flag7 = (nint)num21 < (nint)0;
					object obj28 = !flag7;
					obj10 = obj9;
					num7 = num6;
					obj12 = obj11;
					num9 = num8;
					num11 = num10;
					obj14 = obj13;
					obj16 = obj15;
					obj18 = obj17;
					obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
					num13 = 0.0;
					reference = ref *(float*)num20;
					if (obj28 == null)
					{
						object obj29 = obj6;
						object obj30 = num21 * 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
						obj = 0 + obj30;
						num14 = (nint)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X9_v18+A0]");
						obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
						obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
						obj24 = 0;
						int num22 = tris.get_Item(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
						bool flag8 = (nint)0 == 0;
						obj10 = obj9;
						num7 = num6;
						obj12 = obj11;
						num9 = num8;
						num11 = num10;
						obj14 = obj13;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
						num13 = 0.0;
						reference = ref *(float*)num;
						if (flag8)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X28_v1+18]");
						bool flag9 = (nint)num22 < (nint)0;
						object obj31 = !flag9;
						obj10 = obj9;
						num7 = num6;
						obj12 = obj11;
						num9 = num8;
						num11 = num10;
						obj14 = obj13;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
						num13 = 0.0;
						reference = ref *(float*)num;
						if (obj31 == null)
						{
							object obj32 = num22 * 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X9_v2+58]");
							object obj33 = 0 + obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v41+20]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v41+28]");
							obj14 = 0;
							object obj34 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v56+E4]");
							bool flag10 = (nint)0 == 0;
							object obj35 = !flag10;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num23 = num + 3;
							object obj36 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							object obj37 = obj36 - 0;
							double num24 = (double)obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
							double num25 = num24 - 0.0;
							object obj38 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							object obj39 = obj38 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							object obj40 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							object obj41 = obj40 - 0;
							double num26 = num25 * (double)obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							object obj42 = obj37 * obj41;
							double num27 = (double)obj37 * num25;
							obj10 = obj43 * obj39;
							double num28 = num26 - (double)obj42;
							double num29 = num27 - (double)obj10;
							double num30 = num28 * num28;
							double num31 = num29 * num29;
							double num32 = (double)obj44 + num30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
							double num33 = 0.0 + (double)obj18;
							num13 = num31 + num32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							object obj45 = 0 + obj20;
							double num34 = num33 + (double)obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							object obj46 = obj45 + obj16;
							object obj47 = obj46 * obj48;
							double num35 = num34 * num13;
							num5 = num17 + num13;
							num11 = (double)obj47 / 0.0;
							num9 = num35 / 3.0;
							num3 = num15 + num11;
							num2 = num16 + num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
							bool flag11 = (nint)num23 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
							num7 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							obj12 = 0;
							num4 = num;
							obj9 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
							num6 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
							obj11 = 0;
							num8 = num9;
							num10 = num11;
							obj13 = obj14;
							obj15 = obj16;
							obj17 = obj18;
							obj19 = obj20;
							num12 = num13;
							reference2 = ref *(float*)num;
							intPtr = num14;
							num15 = num3;
							num16 = num2;
							obj21 = obj3;
							num17 = num5;
							num = num23;
							if (flag11)
							{
								continue;
							}
							goto IL_05aa;
						}
					}
				}
				goto IL_096c;
			}
		}
		goto IL_095e;
		IL_05aa:
		double num36;
		if (num5 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num16 = num2 / num5;
			num36 = num3 / num13;
		}
		else
		{
			object obj49 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v41+E4]");
			bool flag12 = (nint)0 == 0;
			object obj50 = !flag12;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj49 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v41+A0]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
			num = 0;
			nint num14 = (nint)obj21;
			int num37 = tris.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
			bool flag13 = (nint)0 == 0;
			reference = ref *(float*)null;
			num15 = num3;
			num16 = num2;
			double num17 = num5;
			if (flag13)
			{
				goto IL_095e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X21_v5 (System.Int32)+18]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X21_v5 (System.Int32)+18]");
			bool flag14 = (nint)num37 < (nint)0;
			object obj51 = !flag14;
			reference = ref *(float*)null;
			num15 = num3;
			num16 = num2;
			num17 = num5;
			if (obj51 != null)
			{
				goto IL_096c;
			}
			object obj52 = num37 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+58]");
			object obj53 = 0 + obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v32+20]");
			num36 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v32+28]");
			num16 = 0.0;
			obj3 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
		num = 0;
		Enumerator<, > enumerator = tris.GetEnumerator();
		num13 = num36;
		num15 = 0.0;
		Enumerator<, > val = default;
		obj = (object)(&val);
		object obj57;
		object obj58;
		Vector3 vector;
		while (true)
		{
			reference = ref *(float*)obj8;
			if (!val.MoveNext())
			{
				break;
			}
			object obj54 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v37+E4]");
			bool flag15 = (nint)0 == 0;
			object obj55 = !flag15;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj54 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v37+A0]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v25+58]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v25+58]");
			bool flag16 = (nint)0 == 0;
			obj57 = 0;
			obj58 = 0;
			vector = (Vector3)(&val);
			object obj7 = 0;
			object obj21 = obj3;
			double num17 = num5;
			if (flag16)
			{
				goto IL_097a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+18]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+18]");
			bool flag17 = (nint)0 < (nint)0;
			object obj59 = !flag17;
			obj57 = 0;
			obj58 = 0;
			vector = (Vector3)(&val);
			obj7 = 0;
			num17 = num5;
			if (obj59 == null)
			{
				object obj60 = 0 * 12;
				obj += obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+20]");
				double num38 = 0.0 - num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v7+28]");
				double num39 = 0.0 - num16;
				double num40 = num38 * num38;
				double num11 = num39 * num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				num13 = num40 + num11;
				double num41 = num15 - num13;
				bool flag18 = num41 < 0.0;
				bool flag19 = num41 == 0.0;
				object obj61 = num15 ^ num13;
				object obj62 = num15 ^ num41;
				object obj63 = obj61 & obj62;
				bool flag20 = (nint)obj63 < 0;
				bool flag21 = flag18 == flag20;
				object obj64 = !flag19;
				object obj65 = flag21 & obj64;
				object obj66 = ~obj65;
				if (obj66 != null)
				{
					num15 = num13;
				}
				obj7 = 0;
				obj3 = obj21;
				continue;
			}
			goto IL_0988;
		}
		obj57 = 0;
		obj58 = 0;
		vector = (Vector3)(&val);
		object obj67 = 0;
		object obj70 = default;
		while (true)
		{
			reference = ref *(float*)((int*)num)->m_value;
			((Enumerator<, >*)vector)->Dispose();
			bool flag22 = obj67 == null;
			object obj68 = !flag22;
			object obj21 = obj3;
			double num17 = num5;
			if (obj68 == null)
			{
				bool flag23 = obj57 == null;
				object obj69 = !flag23;
				obj21 = obj3;
				num17 = num5;
				OutOfMemoryException ex = (OutOfMemoryException)vector;
				if (obj69 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					ref float reference3 = ref *(float*)num5;
					return vector;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == (void*)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj57 = 1;
				obj3 = obj21;
				num5 = num17;
				obj = 1;
				obj67 = obj58;
				continue;
			}
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj67 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj58 = obj70;
			obj3 = obj21;
			num5 = num17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Vector3 result = default;
		return result;
		IL_095e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_096c;
		IL_096c:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_097a;
		IL_0988:
		throw new IndexOutOfRangeException();
		IL_097a:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0988;
	}

	private unsafe static void Places(List<int> tris, Vector3 into, Transform on, int many, List<Spot> found)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_142f: Expected I4, but got VT
		//IL_1437: Expected VT, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005f: Expected VT, but got Obj
		//IL_00a8: Expected I8, but got I
		//IL_1386: Unknown result type (might be due to invalid IL or missing references)
		//IL_138e: Expected VT, but got Unknown
		//IL_0277: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0299: Expected I4, but got Obj
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_1546: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0323: Expected VT, but got Ref
		//IL_032b: Expected Obj, but got Ref
		//IL_033b: Expected VT, but got I
		//IL_034b: Expected F8, but got I
		//IL_1504: Expected I4, but got Obj
		//IL_151d: Expected VT, but got Obj
		//IL_1553: Expected I4, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_1a38: Expected Obj, but got I
		//IL_1a40: Expected I4, but got Obj
		//IL_1a51: Expected VT, but got Ref
		//IL_1452: Expected I4, but got Obj
		//IL_148d: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got I4
		//IL_158d: Expected Obj, but got I
		//IL_159d: Expected Obj, but got I
		//IL_15bc: Expected VT, but got Ref
		//IL_15c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Expected I8, but got I4
		//IL_14b8: Expected I4, but got Obj
		//IL_14d7: Expected I8, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_040b: Expected VT, but got Ref
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0249: Expected I4, but got Obj
		//IL_0251: Expected I8, but got I4
		//IL_0259: Expected VT, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_0442: Expected VT, but got Ref
		//IL_0474: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04b2: Expected F8, but got Obj
		//IL_04c2: Expected F8, but got I
		//IL_04d2: Expected Obj, but got I
		//IL_04e2: Expected F8, but got I
		//IL_04f2: Expected F4, but got I
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected VT, but got Obj
		//IL_0522: Expected VT, but got Ref
		//IL_052a: Expected I4, but got Obj
		//IL_0548: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_058a: Expected VT, but got Ref
		//IL_0592: Expected I4, but got Obj
		//IL_05c9: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_0665: Expected VT, but got I
		//IL_0677: Expected VT, but got Ref
		//IL_05ed: Expected Obj, but got I
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I
		Enumerator<, > val = default;
		object obj = (object)(&val);
		_ = 0;
		bool flag = tris == null;
		float num2 = default;
		float num = num2;
		double num4 = default;
		double num3 = num4;
		Enumerator<, > val2 = (Enumerator<, >)0;
		int num5 = many;
		int num6 = (int)into;
		Vector3 vector = (Vector3)on;
		object obj4;
		Dictionary<long, int> dictionary = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90E8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			vector = (Vector3)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			dictionary._002Ector(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag2 = (nint)0 < (nint)3;
			num5 = many;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			long num7 = 0L;
			if (flag2)
			{
				goto IL_0267;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C18]");
			object obj6 = 0;
			int num8 = many;
			object obj7 = 0;
			while (true)
			{
				object obj8 = 0;
				int num16;
				int num17;
				while (true)
				{
					int index = (int)(obj7 + obj8);
					int num9 = tris.get_Item(index);
					vector = (Vector3)obj5;
					object obj9 = (((nint)obj8 != 2) ? ((object)(obj8 + 1)) : ((object)0));
					num6 = (int)(obj9 + obj7);
					int num10 = tris.get_Item(num6);
					object obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v96+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = dictionary == null;
					num = num2;
					num3 = num4;
					val2 = (Enumerator<, >)0;
					num5 = num8;
					if (flag4)
					{
						break;
					}
					object obj12 = num9 - num10;
					bool flag5 = (nint)obj12 < 0;
					int num11 = num9 ^ num10;
					int num12 = num9 ^ obj12;
					int num13 = num11 & num12;
					bool flag6 = num13 < 0;
					int num14 = num10 | num9;
					int num15 = num9 | num10;
					obj8++;
					bool flag7 = flag5 == flag6;
					object obj13 = !flag7;
					object obj14 = ~obj13;
					num16 = ((obj14 != null) ? num15 : num14);
					bool flag8 = dictionary.TryGetValue(num16, out var value);
					num8 = (int)obj6;
					num17 = value + 1;
					dictionary.set_Item((long)num16, num17);
					if ((nint)obj8 != 3)
					{
						continue;
					}
					goto IL_020f;
				}
				break;
				IL_020f:
				object obj15 = obj7 + 5;
				obj7 += 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tris @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag9 = (nint)obj15 < 0;
				num5 = (int)obj6;
				num7 = num16;
				vector = (Vector3)num17;
				if (flag9)
				{
					continue;
				}
				goto IL_0267;
			}
		}
		goto IL_1353;
		IL_137d:
		NullReferenceException ex = new NullReferenceException();
		Dictionary<long, int>.Enumerator enumerator = (Dictionary<long, int>.Enumerator)val2;
		goto IL_1393;
		IL_13a1:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		throw new OutOfMemoryException();
		IL_0267:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7598]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7580]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		num6 = (int)obj17;
		List<(Vector3, Vector3)> list = default;
		list._002Ector();
		bool flag10 = dictionary == null;
		num = num2;
		num3 = num4;
		val2 = (Enumerator<, >)0;
		if (flag10)
		{
			goto IL_1353;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90F8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F0]");
		object obj20 = 0;
		Dictionary<long, int>.Enumerator enumerator2 = dictionary.GetEnumerator();
		Dictionary<long, int>.Enumerator enumerator3 = (Dictionary<long, int>.Enumerator)(&val);
		object obj21 = (object)(&val);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ X9_v11 (System.Collections.Generic.Dictionary`2<System.Int64, System.Int32>+Enumerator<System.Int64, System.Int32>)+50]");
		enumerator = (Dictionary<long, int>.Enumerator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ X9_v11 (System.Collections.Generic.Dictionary`2<System.Int64, System.Int32>+Enumerator<System.Int64, System.Int32>)+60]");
		num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ X9_v11 (System.Collections.Generic.Dictionary`2<System.Int64, System.Int32>+Enumerator<System.Int64, System.Int32>)+60]");
		_ = 0;
		num = num2;
		Dictionary<long, int>.Enumerator enumerator4 = default;
		object obj22 = default;
		object obj28 = default;
		object obj47 = default;
		while (true)
		{
			num6 = (int)obj18;
			Dictionary<long, int>.Enumerator enumerator5;
			if (enumerator4.MoveNext())
			{
				if ((nint)obj22 != 1)
				{
					continue;
				}
				object obj23 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v93+E4]");
				bool flag11 = (nint)0 == 0;
				object obj24 = !flag11;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v93+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v85+58]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v85+58]");
				bool flag12 = (nint)0 == 0;
				enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
				val2 = (Enumerator<, >)enumerator;
				if (flag12)
				{
					break;
				}
				object obj27 = obj28 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X8_v86+18]");
				bool flag13 = (nint)obj27 < 0;
				object obj29 = !flag13;
				enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
				if (obj29 != null)
				{
					goto IL_1393;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X8_v86+18]");
				bool flag14 = (nint)obj28 < 0;
				object obj30 = !flag14;
				enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
				if (obj30 == null)
				{
					object obj31 = obj28 >> 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v85+58]");
					object obj32 = (nint)0 + (nint)32;
					object obj33 = obj28 * 12;
					object obj34 = obj32 + obj33;
					object obj35 = obj31 * 12;
					object obj36 = obj32 + obj35;
					double num18 = (double)obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v19+4]");
					double num19 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X10_v19+8]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v88+4]");
					num3 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v88+8]");
					num = 0f;
					val2 = (Enumerator<, >)obj36;
					(Vector3, Vector3) tuple = ((Vector3)obj19, vector);
					bool flag15 = list == null;
					enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
					num6 = (int)obj19;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
						object obj38 = 0;
						object obj39 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+1C]");
						object obj40 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
						bool flag16 = (nint)0 == 0;
						enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
						num6 = (int)obj19;
						if (!flag16)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							nint num20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v89+18]");
							bool flag17 = num20 < 0;
							object obj41 = !flag17;
							if (obj41 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
								object obj42 = (nint)0 * (nint)24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
								object obj43 = 0 + obj42;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v31 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
								object obj44 = (nint)0 + (nint)1;
								_ = 0;
								enumerator = (Dictionary<long, int>.Enumerator)tuple;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X9_v41+20]");
								object obj45 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1827 @ X8_v90+A8]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v91+70]");
								vector = (Vector3)0;
								list.AddWithResize(((Vector3, Vector3))(&obj47));
								enumerator = (Dictionary<long, int>.Enumerator)tuple;
							}
							continue;
						}
					}
					goto IL_136f;
				}
				goto IL_13a1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90F0]");
			object obj48 = 0;
			num6 = (int)obj48;
			((Dictionary<long, int>.Enumerator*)(&val))->Dispose();
			enumerator5 = (Dictionary<long, int>.Enumerator)(&val);
			OutOfMemoryException ex3 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E1E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
		}
		goto IL_137d;
		IL_1353:
		NullReferenceException ex4 = new NullReferenceException();
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_136f;
		IL_1393:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_13a1;
		IL_136f:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_137d;
	}

	private static float ToSegment(Vector3 p, Vector3 from, Vector3 to)
	{
		//IL_007c: Expected F8, but got I
		//IL_008c: Invalid comparison between F8 and I
		//IL_009e: Expected F8, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_012e: Invalid comparison between F8 and I4
		//IL_013d: Expected F8, but got I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj9 = default;
		object obj7 = obj8 - obj9;
		object obj10 = obj * obj;
		object obj11 = obj4 * obj4;
		double num = (double)obj10 + (double)obj11;
		object obj12 = obj7 * obj7;
		double num2 = (double)obj12 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		double num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		bool flag = !(num2 > 0.0);
		double num4 = 0.0;
		object obj14 = default;
		object obj16 = default;
		object obj18 = default;
		if (!flag)
		{
			object obj13 = obj14 - obj3;
			object obj15 = obj16 - obj6;
			object obj17 = obj18 - obj9;
			object obj19 = obj13 * obj;
			object obj20 = obj15 * obj4;
			object obj21 = obj17 * obj7;
			object obj22 = obj19 + obj20;
			num3 = (double)obj21 + (double)obj22;
			num = num3 / num2;
			bool flag2 = num < 0.0;
			num4 = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num > 1.0);
				num4 = num;
				num3 = 1.0;
				if (!flag3)
				{
					num4 = 1.0;
					num3 = 1.0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num5 = (double)obj4 * num4;
		double num6 = (double)obj * num4;
		double num7 = (double)obj7 * num4;
		double num8 = (double)obj6 + num5;
		double num9 = (double)obj3 + num6;
		double num10 = (double)obj9 + num7;
		double num11 = (double)obj16 - num8;
		double num12 = (double)obj14 - num9;
		double num13 = (double)obj18 - num10;
		double num14 = num12 * num12;
		double num15 = num11 * num11;
		double num16 = num14 + num15;
		double num17 = num13 * num13;
		float result = (float)num17 + (float)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	private unsafe Spot Pick(List<Spot> on, Kind kind, List<Vector3> rim)
	{
		//IL_03e6: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_02a9: Expected F4, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_02d9: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_04ed: Expected VT, but got F4
		//IL_04e8: Expected native int or pointer, but got VT
		//IL_04fa: Expected native int or pointer, but got VT
		//IL_0507: Expected native int or pointer, but got VT
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected VT, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got VT
		//IL_005d: Expected Obj, but got I
		//IL_0066: Expected Obj, but got Ref
		//IL_006f: Expected Obj, but got I4
		//IL_0078: Expected F4, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00b3: Expected VT, but got I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Invalid comparison between Unknown and I4
		//IL_057b: Expected F4, but got I
		//IL_0583: Expected Obj, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got VT
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Invalid comparison between Unknown and F8
		//IL_062a: Expected Obj, but got I4
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0652: Expected Obj, but got I4
		//IL_00d7: Expected F4, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got VT
		//IL_0223: Expected Obj, but got I
		//IL_0233: Expected F4, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected F8, but got Unknown
		//IL_024b: Expected F4, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected VT, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Ref
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		Kind kind2 = default;
		object obj = kind2 - 1;
		bool flag = obj == null;
		object obj2 = 17285120 + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v5+v81 @ Z_v1 (System.Boolean)*4]");
		object obj3 = 0;
		if (kind2 == (Kind)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC50]");
			obj3 = 0;
		}
		float num = size;
		float num2 = (float)obj3 * size;
		float num3;
		double num4;
		int vertex;
		Vector3 at;
		object obj6;
		List<Spot> list;
		object obj8;
		Enumerator<, > val;
		GillaStrands gillaStrands;
		if ((double)num2 > -1.0)
		{
			bool flag2 = on == null;
			list = on;
			val = (Enumerator<, >)0;
			gillaStrands = this;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9088]");
				object obj4 = 0;
				Enumerator<, > val2 = default;
				object obj5 = (object)(&val2);
				obj6 = 0;
				num3 = 0f;
				num4 = -1.0;
				Enumerator<, > val3 = (Enumerator<, >)0;
				vertex = 0;
				object obj7 = 0;
				obj8 = 0;
				at = (Vector3)0;
				int num5;
				Spot spot;
				Enumerator<, > val4 = default;
				float num6 = default;
				object obj9 = default;
				int num7 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [on @ X1 (System.Collections.Generic.List`1<GillaStrands+Spot>)+18]");
					num5 = UnityEngine.Random.Range(0, 0);
					spot = on.get_Item(num5);
					bool flag3 = (int)val4 >= 0;
					num6 = num6;
					obj9 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v9+C]");
					num = 0f;
					list = (List<Spot>)num5;
					val = val4;
					GillaStrands gillaStrands2 = (GillaStrands)spot;
					if (!flag3)
					{
						break;
					}
					if ((double)val > num4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v9+1C]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v9+C]");
						num3 = 0f;
						num4 = (double)val;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v9+C]");
						num = 0f;
						vertex = num7;
						obj8 = obj9;
						at = (Vector3)val2;
					}
					bool flag4 = (nint)obj7 < 14;
					object obj10 = !flag4;
					object obj11 = obj7 - 14;
					bool flag5 = obj11 == null;
					object obj12 = !flag5;
					object obj13 = obj10 & obj12;
					if (obj13 == null)
					{
						bool flag6 = num4 < (double)num2;
						obj7++;
						if (flag6)
						{
							continue;
						}
					}
					goto IL_04ce;
				}
				bool flag7 = rim == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X24_v9+C]");
				num = 0f;
				list = (List<Spot>)num5;
				val = val4;
				gillaStrands = (GillaStrands)spot;
				if (!flag7)
				{
					Enumerator<, > enumerator = rim.GetEnumerator();
					Enumerator<, > val5 = (Enumerator<, >)2139095039;
					num = num6;
					Enumerator<, > val6 = default;
					val = val6;
					object obj16 = default;
					while (val3.MoveNext())
					{
						object obj14 = num6 - val2;
						object obj15 = obj16 - obj9;
						object obj17 = obj14 * obj14;
						num = (float)obj15 * (float)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						val = (Enumerator<, >)(obj17 + num);
						if (val5 >= val)
						{
							val5 = val;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
					object obj18 = 0;
					list = (List<Spot>)obj18;
					val3.Dispose();
					val2 = (Enumerator<, >)(ref val3);
					gillaStrands = (GillaStrands)(&val3);
					goto IL_0328;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
			if (num8 == 0)
			{
				NullReferenceException ex = new NullReferenceException();
				gillaStrands = (GillaStrands)(object)ex;
				goto IL_0328;
			}
			goto IL_03ba;
		}
		obj6 = 0;
		num3 = 0f;
		num4 = -1.0;
		list = on;
		vertex = 0;
		obj8 = 0;
		at = (Vector3)0;
		goto IL_04ce;
		IL_04ce:
		Spot spot2 = default;
		((Spot*)(nint)spot2)->at = at;
		((Spot*)(nint)spot2)->into = (Vector3)num3;
		((Spot*)(nint)spot2)->room = (float)num4;
		((Spot*)(nint)spot2)->vertex = vertex;
		val = (Enumerator<, >)num3;
		Spot spot3 = (Spot)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
		bool flag8 = num9 != 0;
		gillaStrands = (GillaStrands)spot3;
		if (!flag8)
		{
			return spot3;
		}
		goto IL_03ba;
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
		if (num10 == 0)
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
			gillaStrands = (GillaStrands)(object)ex2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
			if (num11 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DAC4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ SYSREG+28]");
				if (num12 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
			}
		}
		goto IL_03ba;
		IL_03ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Spot result = default;
		return result;
	}

	private unsafe Spot Nearest(List<Spot> on, Vector3 to, Kind kind)
	{
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I4
		//IL_054f: Expected F4, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Invalid comparison between VT and I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected F4, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_007e: Expected VT, but got Ref
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected VT, but got I4
		//IL_039b: Expected Obj, but got I4
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got I4
		//IL_0099: Expected F4, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected VT, but got Unknown
		//IL_0264: Expected VT, but got Ref
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected F4, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Invalid comparison between Unknown and I4
		//IL_0692: Expected Obj, but got I4
		//IL_069a: Expected Obj, but got Ref
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got I4
		//IL_02a5: Expected Obj, but got Ref
		//IL_0174: Invalid comparison between I4 and F4
		//IL_01d9: Expected F4, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected VT, but got Unknown
		//IL_0300: Expected native int or pointer, but got VT
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected native int or pointer, but got VT
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected F4, but got Unknown
		//IL_0324: Expected native int or pointer, but got VT
		//IL_0336: Expected I4, but got VT
		//IL_0331: Expected native int or pointer, but got VT
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected F4, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Ref
		//IL_02ea: Expected Obj, but got I4
		//IL_04e1: Expected Obj, but got I4
		//IL_0348: Expected VT, but got Ref
		Vector3 vector = default;
		object obj = vector - 1;
		bool flag = obj == null;
		object obj2 = 17285120 + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v3+v80 @ Z_v1 (System.Boolean)*4]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC50]");
		Enumerator<, > val = (Enumerator<, >)0;
		if (vector == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC50]");
			num = 0f;
		}
		List<Spot> list = default;
		object obj4;
		Enumerator<, > val2 = default;
		Enumerator<, > val5 = default;
		Enumerator<, > val8 = default;
		Enumerator<, > val9 = default;
		Vector3 vector2;
		object obj16 = default;
		Vector3 vector5;
		Enumerator<, > val14;
		object obj17;
		Enumerator<, > val11;
		if (list != null)
		{
			float num2 = num * size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9088]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9090]");
			obj4 = 0;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float num4 = num3 * 0f;
			Spot spot = list.get_Item(0);
			Spot spot2 = (Spot)(&val2);
			Enumerator<, > enumerator = list.GetEnumerator();
			float num5 = 2.139095E+09f;
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			Enumerator<, > val6 = default;
			val5 = val6;
			object obj6 = default;
			object obj5 = obj6;
			Enumerator<, > val7 = val8;
			Enumerator<, > val10 = default;
			val9 = val10;
			val11 = val6;
			Enumerator<, > val12 = val4;
			Vector3 vector3 = default;
			vector2 = vector3;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			Enumerator<, > val13 = default;
			object obj13 = default;
			Vector3 vector4 = default;
			while (val2.MoveNext())
			{
				object obj7 = 0 - obj8;
				object obj9 = obj10 - obj11;
				object obj12 = obj7 * obj7;
				float num6 = (float)val13 - (float)obj13;
				object obj14 = obj9 * obj9;
				object obj15 = obj12 + obj14;
				float num7 = num6 * num6;
				float num8 = (float)obj15 + num7;
				if (0 >= 0 && 0f < num4)
				{
					float num9 = size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					num6 = num9 * 0f;
					num7 = size * num6;
					num8 += num7;
				}
				bool flag2 = !(num8 < num5);
				val = (Enumerator<, >)0;
				val11 = val13;
				val12 = (Enumerator<, >)0;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (GillaStrands+Spot)+1C]");
					num7 = 0f;
					val = (Enumerator<, >)0;
					num5 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (GillaStrands+Spot)+1C]");
					val3 = (Enumerator<, >)0;
					val5 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (GillaStrands+Spot)+2C]");
					obj5 = 0;
					val7 = val13;
					val9 = (Enumerator<, >)0;
					val11 = val13;
					val12 = (Enumerator<, >)0;
					vector2 = vector4;
				}
			}
			obj16 = 0;
			val8 = (Enumerator<, >)0;
			vector5 = (Vector3)val3;
			Spot spot3 = (Spot)(&val2);
			num = (float)val12;
			val14 = (Enumerator<, >)0;
			obj17 = 5;
			goto IL_066f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		bool flag3 = num10 != 0;
		val11 = (Enumerator<, >)0;
		GillaStrands gillaStrands;
		if (!flag3)
		{
			NullReferenceException ex = new NullReferenceException();
			vector5 = (Vector3)0;
			object obj5 = 0;
			val11 = (Enumerator<, >)0;
			gillaStrands = (GillaStrands)(object)ex;
			vector2 = vector;
			obj4 = 109891584;
			goto IL_03c2;
		}
		goto IL_04f5;
		IL_04f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Spot result = default;
		return result;
		IL_05ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		bool flag4 = num11 != 0;
		gillaStrands = (GillaStrands)(&val2);
		if (!flag4)
		{
			return (Spot)(&val2);
		}
		goto IL_04f5;
		IL_03c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		if (num12 == 0)
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
			gillaStrands = (GillaStrands)(object)ex2;
			goto IL_0407;
		}
		goto IL_04f5;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
		if (num13 != 0)
		{
			goto IL_04f5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj4 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj16 = 1;
			val14 = val8;
		}
		else
		{
			if ((nint)obj4 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EC78");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ SYSREG+28]");
				if (num14 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_04f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj18 = default;
			val14 = (Enumerator<, >)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			val8 = (Enumerator<, >)obj18;
		}
		obj17 = 0;
		goto IL_066f;
		IL_066f:
		val2.Dispose();
		bool flag5 = (int)val14 == 0;
		object obj19 = !flag5;
		gillaStrands = (GillaStrands)(&val2);
		if (obj19 != null)
		{
			goto IL_03c2;
		}
		bool flag6 = obj16 == null;
		object obj20 = !flag6;
		gillaStrands = (GillaStrands)(&val2);
		if (obj20 != null)
		{
			goto IL_0407;
		}
		if ((nint)obj17 != 5)
		{
			bool flag7 = obj17 == null;
			object obj21 = !flag7;
			if (obj21 != null)
			{
				goto IL_05ff;
			}
		}
		Spot spot4 = default;
		((Spot*)(nint)spot4)->at = (Vector3)val9;
		((Spot*)(nint)spot4)->into = vector5;
		((Spot*)(nint)spot4)->room = (float)val5;
		((Spot*)(nint)spot4)->vertex = (int)vector2;
		num = (float)val5;
		goto IL_05ff;
	}

	private float Want(Kind kind)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		object obj = kind - 1;
		bool flag = obj == null;
		object obj2 = 17285120 + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v2+v5 @ Z_v1 (System.Boolean)*4]");
		object obj3 = 0;
		if (kind == (Kind)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC50]");
			obj3 = 0;
		}
		return size * (float)obj3;
	}

	private static BoneWeight[] WeightsOf(Mesh m)
	{
		//IL_0010: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+28]");
		BoneWeight[] boneWeights = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9078]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+28]");
			bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)m, out var _);
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				goto IL_0131;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			if ((object)m != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v11+A0]");
				object obj9 = 0;
				boneWeights = m.boneWeights;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v10+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v10+28]");
					((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)m, (System.__Canon)(object)boneWeights);
					goto IL_0131;
				}
			}
		}
		return (BoneWeight[])(object)new NullReferenceException();
		IL_0131:
		return boneWeights;
	}

	private static SkinnedMeshRenderer TorsoOf(Transform side)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		object obj2;
		Transform transform;
		if ((object)side != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9060]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj5 = default;
			bool flag2 = obj5 != null;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			object obj7 = 0;
			UnityEngine.Object obj8 = obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9068]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v23+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj12 = default;
				bool flag5 = obj12 != null;
				bool flag6 = !flag5;
				obj7 = 0;
				obj8 = obj12;
				object obj13 = 0;
				UnityEngine.Object obj14 = null;
				transform = null;
				if (flag6)
				{
					goto IL_04f5;
				}
			}
			if ((object)obj8 != null)
			{
				Transform transform2 = ((Component)obj8).transform;
				object obj13 = obj7;
				UnityEngine.Object obj14 = null;
				transform = transform2;
				goto IL_04f5;
			}
		}
		goto IL_04bc;
		IL_04b2:
		SkinnedMeshRenderer result = null;
		goto IL_052d;
		IL_052d:
		return result;
		IL_04f5:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = transform == null;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		result = null;
		if (obj17 == null)
		{
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9070]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				object obj19 = default;
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v19+18]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v19+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_04b2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C68]");
					object obj21 = 0;
					object obj22 = 0;
					while (true)
					{
						bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
						object obj23 = !flag10;
						if (obj23 != null)
						{
							break;
						}
						object obj24 = obj19 + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
							string text = ((UnityEngine.Object)0).name;
							if (text == (string)obj21)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
								Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
								object obj25 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v19+E4]");
								bool flag11 = (nint)0 == 0;
								object obj26 = !flag11;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (sharedMesh != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
									Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
									if ((object)sharedMesh2 == null)
									{
										goto IL_04bc;
									}
									if (sharedMesh2.isReadable)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
										Mesh sharedMesh3 = ((SkinnedMeshRenderer)0).sharedMesh;
										if ((object)sharedMesh3 == null)
										{
											goto IL_04bc;
										}
										int subMeshCount = sharedMesh3.subMeshCount;
										bool flag12 = subMeshCount > 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v16+20]");
										result = (SkinnedMeshRenderer)0;
										if (flag12)
										{
											goto IL_052d;
										}
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v19+18]");
							obj20 = 0;
							obj22++;
							object obj27 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v19+18]");
							if ((nint)obj27 < 0)
							{
								continue;
							}
							goto IL_04b2;
						}
						goto IL_04bc;
					}
					goto IL_04ca;
				}
			}
			goto IL_04bc;
		}
		goto IL_052d;
		IL_04ca:
		return (SkinnedMeshRenderer)(object)new IndexOutOfRangeException();
		IL_04bc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04ca;
	}

	private static Transform Steady(Transform side)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		if ((object)side != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform parent = side.parent;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parent != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9060]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj7 = default;
				if (obj7 != null)
				{
					return side.parent;
				}
			}
			return side;
		}
		return (Transform)(object)new NullReferenceException();
	}

	private unsafe End OnSkin(Transform[] bones, BoneWeight by, Vector3 at, Transform steady)
	{
		//IL_0786: Invalid comparison between F4 and I
		//IL_0103: Expected Obj, but got VT
		//IL_010f: Expected native int or pointer, but got VT
		//IL_011c: Expected native int or pointer, but got VT
		//IL_0749: Expected VT, but got Obj
		//IL_0042: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_00e7: Expected VT, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_0201: Expected VT, but got I4
		//IL_0201: Expected Obj, but got I
		//IL_021a: Invalid comparison between F4 and I
		//IL_0423: Expected Obj, but got I4
		//IL_042c: Expected VT, but got I4
		//IL_0435: Expected F4, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_044f: Expected Obj, but got I4
		//IL_0468: Expected VT, but got I4
		//IL_0471: Expected VT, but got I4
		//IL_047e: Expected I4, but got I8
		//IL_07fb: Invalid comparison between F4 and I
		//IL_0251: Expected Obj, but got I4
		//IL_06ab: Expected F4, but got I4
		//IL_06b4: Expected Obj, but got I4
		//IL_06bd: Expected VT, but got I4
		//IL_06d2: Expected I4, but got I8
		//IL_081a: Expected native int or pointer, but got VT
		//IL_0827: Expected native int or pointer, but got VT
		//IL_0834: Expected native int or pointer, but got VT
		//IL_0855: Expected native int or pointer, but got VT
		//IL_0862: Expected native int or pointer, but got VT
		//IL_0879: Expected native int or pointer, but got VT
		//IL_0890: Expected native int or pointer, but got VT
		//IL_08a7: Expected native int or pointer, but got VT
		//IL_08b4: Expected native int or pointer, but got VT
		//IL_04ea: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I4
		//IL_0495: Expected VT, but got I4
		//IL_049e: Expected F4, but got I4
		//IL_04a7: Expected Obj, but got I4
		//IL_04b0: Expected VT, but got I4
		//IL_04b8: Expected VT, but got I4
		//IL_04c5: Expected I4, but got I8
		//IL_0563: Expected Obj, but got I
		//IL_07c0: Expected Obj, but got I4
		//IL_07e1: Expected VT, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_06f0: Expected Obj, but got I4
		//IL_06f9: Expected F4, but got I4
		//IL_070a: Expected Obj, but got I4
		//IL_0713: Expected VT, but got I4
		//IL_071b: Expected VT, but got I4
		//IL_0728: Expected I4, but got I8
		//IL_05a4: Expected Obj, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_033d: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05d6: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I4
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_03d0: Expected VT, but got I4
		//IL_03d0: Expected Obj, but got I
		//IL_03fd: Expected VT, but got I4
		//IL_0669: Expected VT, but got I4
		//IL_0669: Expected Obj, but got I
		float num = by.m_Weight0 + by.m_Weight1;
		float num2 = num + by.m_Weight2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag = num2 < 0f;
		Vector3 world = (Vector3)by;
		if (flag)
		{
			goto IL_00f5;
		}
		object obj3;
		int b;
		Vector3 vector;
		object obj11 = default;
		Vector3 p;
		float w;
		Vector3 p2;
		Vector3 vector2 = default;
		int b2;
		object obj13 = default;
		object obj10;
		object obj12;
		object obj15;
		object obj17;
		object obj18;
		Vector3 vector3;
		if (bones != null)
		{
			bool flag2 = by.m_BoneIndex0 < bones.Length;
			object obj = !flag2;
			if (obj == null)
			{
				object obj2 = bones + by.m_BoneIndex0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9+20]");
				bool flag4 = (UnityEngine.Object)0 == null;
				bool flag5 = !flag4;
				world = (Vector3)0;
				if (!flag5)
				{
					goto IL_00f5;
				}
				bool flag6 = by.m_BoneIndex0 < bones.Length;
				object obj6 = !flag6;
				if (obj6 == null)
				{
					object obj7 = bones + by.m_BoneIndex0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v11+20]");
					b = Anchor((Transform)0);
					bool flag7 = by.m_BoneIndex0 < bones.Length;
					object obj8 = !flag7;
					if (obj8 == null)
					{
						object obj9 = bones + by.m_BoneIndex0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v13+20]");
						if ((nint)0 == 0)
						{
							goto IL_073b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v13+20]");
						vector = ((Transform)0).InverseTransformPoint((Vector3)0);
						float weight = by.m_Weight1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
						if (!(weight > 0f))
						{
							obj10 = obj11;
							obj12 = obj13;
							object obj14 = 0;
							p = (Vector3)0;
							w = 0f;
							obj15 = 0;
							p2 = vector2;
							object obj16 = 0;
							obj17 = obj11;
							obj18 = obj13;
							vector3 = (Vector3)0;
							Vector3 vector4 = (Vector3)0;
							b2 = -1;
							goto IL_07e6;
						}
						bool flag8 = by.m_BoneIndex1 < bones.Length;
						object obj19 = !flag8;
						if (obj19 == null)
						{
							object obj20 = obj3;
							object obj21 = bones + by.m_BoneIndex1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v30+E4]");
							bool flag9 = (nint)0 == 0;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v25+20]");
							bool flag10 = (UnityEngine.Object)0 != null;
							if (!flag10)
							{
								object obj14 = 0;
								p = (Vector3)0;
								w = 0f;
								object obj16 = 0;
								Vector3 vector4 = (Vector3)0;
								vector = (Vector3)flag10;
								b2 = -1;
								goto IL_07a7;
							}
							bool flag11 = by.m_BoneIndex1 < bones.Length;
							object obj23 = !flag11;
							if (obj23 == null)
							{
								object obj24 = bones + by.m_BoneIndex1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v28+20]");
								int num3 = Anchor((Transform)0);
								bool flag12 = by.m_BoneIndex1 < bones.Length;
								object obj25 = !flag12;
								if (obj25 == null)
								{
									object obj26 = bones + by.m_BoneIndex1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v30+20]");
									if ((nint)0 == 0)
									{
										goto IL_073b;
									}
									float num4 = by.m_Weight1 / num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v30+20]");
									vector = ((Transform)0).InverseTransformPoint((Vector3)0);
									object obj14 = obj11;
									p = vector2;
									w = num4;
									object obj16 = obj13;
									Vector3 vector4 = (Vector3)0;
									b2 = num3;
									goto IL_07a7;
								}
							}
						}
					}
				}
			}
			goto IL_072d;
		}
		goto IL_073b;
		IL_07a2:
		End result;
		return result;
		IL_073b:
		NullReferenceException ex = new NullReferenceException();
		return (End)ex;
		IL_00f5:
		result = Rigid((Transform)at, world);
		End end = default;
		int b3 = default;
		((End*)(nint)end)->b0 = b3;
		float w2 = default;
		((End*)(nint)end)->w1 = w2;
		goto IL_07a2;
		IL_072d:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_073b;
		IL_0812:
		((End*)(nint)end)->b0 = b;
		((End*)(nint)end)->b1 = b2;
		int b4;
		((End*)(nint)end)->b2 = b4;
		float w3 = by.m_Weight0 / num2;
		float w4;
		((End*)(nint)end)->w2 = w4;
		((End*)(nint)end)->p0 = p2;
		((End*)(nint)end)->p1 = p;
		((End*)(nint)end)->p2 = vector2;
		((End*)(nint)end)->w0 = w3;
		((End*)(nint)end)->w1 = w;
		goto IL_07a2;
		IL_07e6:
		float weight2 = by.m_Weight2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if (weight2 > 0f)
		{
			bool flag13 = by.m_BoneIndex2 < bones.Length;
			object obj27 = !flag13;
			if (obj27 == null)
			{
				object obj28 = obj3;
				object obj29 = bones + by.m_BoneIndex2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v20+E4]");
				bool flag14 = (nint)0 == 0;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v18+20]");
				bool flag15 = (UnityEngine.Object)0 != null;
				if (!flag15)
				{
					obj10 = obj11;
					obj12 = obj13;
					obj15 = 0;
					w4 = 0f;
					p2 = vector2;
					obj13 = 0;
					vector2 = (Vector3)0;
					result = (End)flag15;
					b4 = -1;
					goto IL_0812;
				}
				bool flag16 = by.m_BoneIndex2 < bones.Length;
				object obj31 = !flag16;
				if (obj31 == null)
				{
					object obj32 = bones + by.m_BoneIndex2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v21+20]");
					int num5 = Anchor((Transform)0);
					bool flag17 = by.m_BoneIndex2 < bones.Length;
					object obj33 = !flag17;
					if (obj33 == null)
					{
						object obj34 = bones + by.m_BoneIndex2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v23+20]");
						if ((nint)0 == 0)
						{
							goto IL_073b;
						}
						w4 = by.m_Weight2 / num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v23+20]");
						Vector3 vector5 = ((Transform)0).InverseTransformPoint((Vector3)0);
						obj10 = obj11;
						obj12 = obj13;
						obj15 = obj11;
						p2 = vector2;
						result = (End)vector5;
						b4 = num5;
						goto IL_0812;
					}
				}
			}
			goto IL_072d;
		}
		w4 = 0f;
		obj13 = 0;
		vector2 = (Vector3)0;
		result = (End)vector;
		b4 = -1;
		goto IL_0812;
		IL_07a7:
		obj10 = obj11;
		obj12 = obj13;
		obj15 = 0;
		p2 = vector2;
		obj17 = obj11;
		obj18 = obj13;
		vector3 = (Vector3)0;
		goto IL_07e6;
	}

	private unsafe void Build()
	{
		//IL_0133: Expected F4, but got I4
		//IL_0fa0: Expected Obj, but got I
		//IL_0fd4: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Expected F4, but got I4
		//IL_11c9: Expected Obj, but got I
		//IL_11d9: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected I4, but got Unknown
		//IL_01be: Expected I4, but got F4
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected I4, but got Unknown
		//IL_0229: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I4
		//IL_088e: Expected F4, but got I4
		//IL_011c: Expected F4, but got I4
		//IL_1087: Expected F4, but got I4
		//IL_1090: Expected F4, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_1186: Expected Obj, but got I4
		//IL_1068: Expected Obj, but got I4
		//IL_1213: Expected Obj, but got I
		//IL_1223: Expected Obj, but got I
		//IL_08db: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_1101: Expected Obj, but got I4
		//IL_02a8: Expected F4, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected F4, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_10a5: Expected Obj, but got I
		//IL_10b5: Expected Obj, but got I
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff0: Expected Obj, but got Unknown
		//IL_1000: Unknown result type (might be due to invalid IL or missing references)
		//IL_1005: Expected Obj, but got Unknown
		//IL_0a46: Expected Obj, but got F4
		//IL_0a6e: Expected Obj, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0331: Expected F4, but got I4
		//IL_1156: Expected Obj, but got I4
		//IL_0940: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_111f: Expected Obj, but got I
		//IL_112f: Expected Obj, but got I
		//IL_10ca: Expected Obj, but got I
		//IL_10da: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I4
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_0b98: Invalid comparison between F4 and I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_0695: Expected F4, but got I4
		//IL_09a4: Expected F4, but got I
		//IL_09d2: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got I
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0861: Expected F4, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected I4, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_0bbf: Expected Obj, but got I
		//IL_0add: Invalid comparison between F4 and I
		//IL_0aee: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected Obj, but got Unknown
		//IL_06f3: Invalid comparison between F4 and I
		//IL_0704: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_049d: Expected Obj, but got I4
		//IL_0c2f: Expected Obj, but got I
		//IL_0b0a: Expected F4, but got Obj
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected Obj, but got Unknown
		//IL_07ba: Expected Obj, but got I
		//IL_07ca: Invalid comparison between F4 and I
		//IL_07e8: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I4
		//IL_0cb6: Expected Obj, but got I8
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_0d12: Expected Obj, but got I4
		//IL_0d22: Expected Obj, but got I4
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected Obj, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0d8c: Expected Obj, but got I8
		//IL_0df1: Expected Obj, but got I
		//IL_0e41: Expected VT, but got Ref
		//IL_0e60: Expected Obj, but got I
		//IL_0e9d: Expected Obj, but got I
		//IL_0ed1: Expected Obj, but got I4
		//IL_11a4: Expected Obj, but got I
		//IL_11b4: Expected Obj, but got I
		//IL_0f0b: Expected Obj, but got I
		Strand[] array = strands;
		int num;
		float num2;
		if (array.Length >= 1)
		{
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			num = 0;
			object obj3 = 0;
			num2 = 0f;
			while (array.Length != (nint)obj3)
			{
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X13_v15+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X13_v8+E0]");
				object obj6 = 0;
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X13_v8+E0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X13_v8+E0]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X13_v8+E0]");
				float num4 = 0f * 96f;
				num2 += num4;
				num = obj7 + num;
				if (obj2 != obj3)
				{
					continue;
				}
				goto IL_0113;
			}
			goto IL_0f4e;
		}
		num = 0;
		num2 = 0f;
		goto IL_0f90;
		IL_0f90:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj8 = 0;
		dropFirst = num;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v5+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v3+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v3+68]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90C8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v6+18]");
		float num5 = 0f * 14f;
		int vertexCount = (int)(num + num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v4+18]");
		float num6 = 0f * 14f;
		int num7 = (int)(num2 + num6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = this + 80;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X23_v3-10]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X25_v2+18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X25_v2+18]");
		object obj21;
		float num10 = default;
		int num8;
		float num13;
		float num12;
		if ((nint)0 >= (nint)1)
		{
			object obj20 = 0;
			num8 = num7;
			obj21 = 0;
			float num9 = num10;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
				object obj22 = !flag2;
				if (obj22 != null)
				{
					break;
				}
				object obj23 = obj18 + obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v56+20]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
				float num11 = ~(nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
				num12 = 0 & num11;
				object obj25 = 0;
				object obj26 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
						object obj27 = 0 * obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E4]");
						object obj5 = 0 + obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E4]");
						object obj7 = 0 + obj26;
						object obj28 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
						object obj6 = obj28 + 0;
						num13 = 0f;
						while (true)
						{
							object obj29 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag3 = (nint)obj29 < 0;
							object obj30 = !flag3;
							if (obj30 != null)
							{
								break;
							}
							float num14 = num10 + (float)obj21;
							object obj31 = obj21 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag4 = (nint)obj31 < 0;
							object obj32 = !flag4;
							if (obj32 != null)
							{
								break;
							}
							object obj33 = obj21 + 1;
							object obj34 = obj31 + 1;
							float num15 = num10 + (float)obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							num8 = 0 + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag5 = (nint)obj34 < 0;
							object obj35 = !flag5;
							if (obj35 != null)
							{
								break;
							}
							num13++;
							object obj36 = obj21 + 2;
							float num16 = num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							float num17 = num16 / 0f;
							float num18 = num10 + (float)obj36;
							object obj37 = obj34 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag6 = (nint)obj37 < 0;
							object obj38 = !flag6;
							float num19 = num17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							num11 = num19 * 0f;
							float num20 = num13 - num11;
							float num21 = num20 + (float)obj5;
							if (obj38 != null)
							{
								break;
							}
							object obj39 = obj21 + 3;
							object obj40 = obj37 + 1;
							float num22 = num10 + (float)obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag7 = (nint)obj40 < 0;
							object obj41 = !flag7;
							if (obj41 != null)
							{
								break;
							}
							object obj42 = obj21 + 4;
							float num23 = num10 + (float)obj42;
							object obj43 = obj40 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
							bool flag8 = (nint)obj43 < 0;
							object obj44 = !flag8;
							if (obj44 != null)
							{
								break;
							}
							object obj45 = obj21 + 5;
							num9 = (float)obj6 + num20;
							float num24 = num10 + (float)obj45;
							obj7++;
							obj21 = obj43 + 1;
							if (num12 != num13)
							{
								continue;
							}
							goto IL_060f;
						}
						break;
					}
					goto IL_0fe2;
					IL_060f:
					object obj46 = obj21 + 6;
					obj21 = obj46;
					goto IL_0fe2;
					IL_0fe2:
					obj25++;
					object obj47 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
					obj26 = obj47 + 0;
					if ((nint)obj25 != 16)
					{
						continue;
					}
					goto IL_062a;
				}
				break;
				IL_062a:
				float value = UnityEngine.Random.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
				object obj48 = 0;
				float num25 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE8]");
				float num26 = num25 * 0f;
				object obj49 = 0;
				while (true)
				{
					if ((nint)obj48 >= 1)
					{
						object obj50 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
						object obj51 = obj50 * 0;
						float num27 = value + (float)obj51;
						float num28 = 0f;
						object obj52 = obj48;
						while (true)
						{
							obj25 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X11_v11+18]");
							object obj5 = 0;
							object obj53 = obj49 * obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E4]");
							object obj54 = 0 + obj53;
							num13 = num28 + (float)obj54;
							float num29 = num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X11_v11+18]");
							bool flag9 = num29 < 0f;
							object obj55 = !flag9;
							if (obj55 != null)
							{
								break;
							}
							num11 = num13 * 36f;
							float num30 = (float)obj25 + num11;
							num12 = num28 + 1f;
							float num31 = num28 + num28;
							float num32 = num31 / (float)obj52;
							double num33 = (double)num32 + -1.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							double num34 = num33 * 0.5;
							float num35 = num26 + (float)num34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							obj48 = 0;
							float num36 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							bool flag10 = num36 < 0f;
							num28 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X29_v7+E0]");
							obj52 = 0;
							if (flag10)
							{
								continue;
							}
							goto IL_07f6;
						}
						break;
					}
					goto IL_07f6;
					IL_07f6:
					obj49++;
					if ((nint)obj49 != 17)
					{
						continue;
					}
					goto IL_0824;
				}
				break;
				IL_0824:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X25_v2+18]");
				obj19 = 0;
				obj20++;
				object obj56 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X25_v2+18]");
				bool flag11 = (nint)obj56 < 0;
				num9 = 0f;
				if (flag11)
				{
					continue;
				}
				goto IL_1076;
			}
			goto IL_0f4e;
		}
		num8 = num7;
		obj21 = 0;
		num12 = 14f;
		goto IL_1076;
		IL_0113:
		num13 = 96f;
		goto IL_0f90;
		IL_1076:
		object obj57 = obj8;
		float num37 = 0f;
		float num38 = 17276928f;
		Mesh mesh = default;
		VertexAttributeDescriptor[] array2 = default;
		object obj94 = default;
		MeshFilter meshFilter = default;
		Renderer renderer = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+E4]");
			bool flag12 = (nint)0 == 0;
			object obj58 = !flag12;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj57 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+A0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v13+60]");
			object obj60 = 0;
			float num39 = num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v14+18]");
			float num40 = num39 * 0f;
			float num41 = (float)dropFirst + num40;
			object obj61 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+E4]");
				bool flag13 = (nint)0 == 0;
				object obj62 = !flag13;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj57 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+A0]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v18+68]");
				object obj64 = 0;
				object obj65 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v19+18]");
				if ((nint)obj65 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+E4]");
				bool flag14 = (nint)0 == 0;
				object obj66 = !flag14;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj57 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+A0]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X8_v50+68]");
				object obj68 = 0;
				object obj69 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v51+18]");
				bool flag15 = (nint)obj69 < 0;
				object obj70 = !flag15;
				if (obj70 != null)
				{
					goto end_IL_1164;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
				num12 = 0f;
				object obj71 = obj21 + obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v11 (System.Single)+18]");
				bool flag16 = (nint)obj71 < 0;
				object obj72 = !flag16;
				if (obj72 != null)
				{
					goto end_IL_1164;
				}
				object obj73 = obj68 + obj61;
				num38 = num10 + (float)obj71;
				obj61++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1199 @ X8_v52+20]");
				float num42 = 0f + num41;
			}
			obj21 = obj61 + obj21;
			object obj74 = num41 << 32;
			float num43 = num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
			float num44 = num43 * 0f;
			float value = num37;
			object obj75 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+E4]");
				bool flag17 = (nint)0 == 0;
				object obj76 = !flag17;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj57 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v19+A0]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1178 @ X8_v23+60]");
				object obj78 = 0;
				object obj79 = obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v24+18]");
				if ((nint)obj79 >= 0)
				{
					break;
				}
				object obj80 = obj16;
				num12 = num41 + (float)obj75;
				float num45 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v47+18]");
				bool flag18 = num45 < 0f;
				object obj81 = !flag18;
				if (obj81 != null)
				{
					goto end_IL_1164;
				}
				num38 = obj74 >> 32;
				object obj82 = obj75 + 1;
				obj74 += 4294967296L;
				float num46 = num38 * 36f;
				float num47 = (float)obj80 + num46;
				float num48 = (float)obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
				value = num48 * 0f;
				obj57 = obj8;
				obj75 = obj82;
			}
			num37++;
			if (num37 == 14f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
				object obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				mesh._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FF8]");
				object obj84 = 0;
				mesh.name = (string)obj84;
				object obj85 = this + 72;
				obj85 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				((Mesh)obj85).MarkDynamic();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90C0]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				VertexAttributeDescriptor vertexAttributeDescriptor = new VertexAttributeDescriptor((VertexAttribute)0, (VertexAttributeFormat)0, 3, 0);
				if (array2.Length == 0)
				{
					break;
				}
				_ = 0;
				VertexAttributeDescriptor vertexAttributeDescriptor2 = new VertexAttributeDescriptor((VertexAttribute)1, (VertexAttributeFormat)0, 3, 0);
				object obj87 = array2.Length & 0xFFFFFFFEL;
				if (obj87 == null)
				{
					break;
				}
				_ = 0;
				VertexAttributeDescriptor vertexAttributeDescriptor3 = new VertexAttributeDescriptor((VertexAttribute)3, (VertexAttributeFormat)2, 4, 0);
				bool flag19 = array2.Length < 2;
				object obj88 = !flag19;
				object obj89 = array2.Length - 2;
				bool flag20 = obj89 == null;
				object obj90 = ~obj88;
				object obj91 = obj90 | flag20;
				if (obj91 != null)
				{
					break;
				}
				_ = 0;
				VertexAttributeDescriptor vertexAttributeDescriptor4 = new VertexAttributeDescriptor((VertexAttribute)4, (VertexAttributeFormat)0, 2, 0);
				object obj92 = array2.Length & 0xFFFFFFFCL;
				if (obj92 == null)
				{
					break;
				}
				_ = 0;
				((Mesh)obj85).SetVertexBufferParams(vertexCount, array2);
				((Mesh)obj85).SetIndexBufferParams(num7, (IndexFormat)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C90B0]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A3C9C");
				((Mesh)obj85).subMeshCount = 1;
				SubMeshDescriptor subMeshDescriptor = new SubMeshDescriptor(0, num7, (MeshTopology)0);
				((Mesh)obj85).SetSubMesh(0, (SubMeshDescriptor)(&obj94), (MeshUpdateFlags)9);
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
				object obj95 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				meshFilter.sharedMesh = this.mesh;
				GameObject gameObject2 = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
				object obj96 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				object obj97 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v43+E4]");
				bool flag21 = (nint)0 == 0;
				object obj98 = !flag21;
				if (obj98 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj97 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v43+A0]");
				object obj99 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v44+18]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v45+58]");
				renderer.sharedMaterial = (Material)0;
				renderer.shadowCastingMode = (ShadowCastingMode)0;
				renderer.receiveShadows = false;
				renderer.lightProbeUsage = (LightProbeUsage)1;
				renderer.allowOcclusionWhenDynamic = false;
				return;
			}
			continue;
			end_IL_1164:
			break;
		}
		goto IL_0f4e;
		IL_0f4e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj4 = 0;
		bool flag2 = mesh != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			object obj9 = obj;
			if (isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(mesh);
				obj5 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v19+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DestroyImmediate(mesh);
				obj5 = null;
			}
		}
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+10]");
		bool flag8 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
	}

	private void LateUpdate()
	{
		float deltaTime = Time.deltaTime;
		Step(deltaTime);
	}

	private void Fetch()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		Matrix4x4[] array = anchorNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = 32;
		int num = 0;
		object obj8 = default;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			System.__Canon _Canon = ((List<System.__Canon>)(object)anchors).get_Item(num);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)(object)_Canon != null)
			{
				Matrix4x4[] array2 = anchorNow;
				System.__Canon _Canon2 = ((List<System.__Canon>)(object)anchors).get_Item(num);
				Matrix4x4 localToWorldMatrix = ((Transform)(object)_Canon2).localToWorldMatrix;
				bool flag2 = num < array2.Length;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					break;
				}
				object obj7 = (object)array2 + obj3;
				obj7 = obj8;
			}
			array = anchorNow;
			num++;
			obj3 += 64;
			bool flag3 = anchorNow == null;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	private Vector3 Where([In] ref End e)
	{
		//IL_015e: Expected VT, but got Obj
		//IL_0038: Invalid comparison between VT and I4
		//IL_0049: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I8
		//IL_008b: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I8
		//IL_0103: Expected Obj, but got I4
		//IL_01a2: Expected VT, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I8
		//IL_0192: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		Matrix4x4[] array = anchorNow;
		if (anchorNow == null)
		{
			goto IL_0150;
		}
		bool flag = e < (object)array.Length;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_0142;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X1 (End&)+4]");
		object obj2 = 0 & 0x80000000L;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X1 (End&)+4]");
			bool flag3 = (nint)0 < (nint)array.Length;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				goto IL_0142;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X1 (End&)+8]");
			object obj5 = 0 & 0x80000000L;
			bool flag4 = obj5 == null;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_01a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X1 (End&)+8]");
		object obj7 = 0 & 0x80000000L;
		bool flag5 = obj7 == null;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X1 (End&)+8]");
			bool flag6 = (nint)0 < (nint)array.Length;
			object obj9 = !flag6;
			if (obj9 != null)
			{
				goto IL_0142;
			}
		}
		goto IL_01a0;
		IL_0142:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0150;
		IL_01a0:
		return (Vector3)this;
		IL_0150:
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
	}

	public void Step(float dt)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCBC");
	}

	private void HoldBack(Vector3 toA, float share, float dt)
	{
		//IL_01b4: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_00bf: Expected VT, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0112: Invalid comparison between F8 and I4
		//IL_0121: Invalid comparison between F8 and I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01fc: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = share * share;
		float num2 = dt * dt;
		float num3 = num + num2;
		object obj5 = default;
		object obj4 = obj5 * obj5;
		float num4 = (float)obj4 + num3;
		float num5 = size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num6 = num5 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (!(num4 < num6))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			pulled.AddForce((Vector3)5, (ForceMode)0);
			Vector3 linearVelocity = pulled.linearVelocity;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			object obj7 = default;
			object obj6 = obj7 * 0;
			object obj9 = default;
			object obj8 = obj6 * obj9;
			double num7 = (double)obj8 - 1.0;
			bool flag2 = num7 < 0.0;
			bool flag3 = num7 == 0.0;
			object obj10 = obj8 ^ 1.0;
			object obj11 = obj8 ^ num7;
			object obj12 = obj10 & obj11;
			bool flag4 = (nint)obj12 < 0;
			bool flag5 = flag2 == flag4;
			object obj13 = !flag3;
			object obj14 = flag5 & obj13;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
			}
			pulled.linearVelocity = (Vector3)0;
		}
	}

	private void Snap(Strand st, float dt)
	{
		//IL_0040: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I4
		//IL_0725: Expected Obj, but got I
		//IL_074f: Expected Obj, but got I4
		//IL_02ac: Invalid comparison between F8 and I
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0319: Expected F8, but got I
		//IL_04c7: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I4
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0582: Invalid comparison between F4 and I4
		//IL_0689: Expected Obj, but got I
		//IL_06e7: Expected F4, but got I
		//IL_06e7: Expected F4, but got I
		//IL_06fe: Expected VT, but got I4
		//IL_06fe: Expected VT, but got I4
		Vector3[] at = st.at;
		st.snapped = true;
		bool flag = st.cut < at.Length;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = st.cut + 1;
			bool flag2 = (nint)obj2 < at.Length;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Vector3[] was = st.was;
				bool flag3 = st.cut < was.Length;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					bool flag4 = (nint)obj2 < was.Length;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						object obj6 = st.cut * 12;
						object obj7 = (object)at + obj6;
						object obj8 = was + 32;
						object obj9 = obj2 * 12;
						object obj10 = (object)at + obj9;
						object obj11 = st.cut * 12;
						object obj12 = obj8 + obj11;
						double num = 0.5 / (double)dt;
						object obj13 = obj2 * 12;
						object obj14 = obj8 + obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v5+20]");
						object obj15 = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X9_v4+20]");
						object obj16 = 0 - obj14;
						object obj17 = obj15 + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v5+28]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X13_v3+8]");
						object obj18 = num2 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X9_v4+28]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X11_v6+8]");
						object obj19 = num3 - 0;
						object obj20 = obj18 + obj19;
						object obj22 = default;
						object obj21 = obj17 * obj22;
						double num4 = num * (double)obj20;
						object obj23 = obj21 * obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						double num5 = num4 * num4;
						double num6 = (double)obj23 + num5;
						if (num6 > 9.0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj24 = 0;
							object obj25 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v19+E4]");
							bool flag5 = (nint)0 == 0;
							object obj26 = !flag5;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							double num7 = num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							if (num7 > 0.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								num5 = num4 / num5;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj27 = 0;
								object obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v33+A0]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v34+8]");
								num5 = 0.0;
							}
							was = st.was;
						}
						bool flag6 = st.cut < was.Length;
						object obj30 = !flag6;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v5+20]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X9_v4+20]");
							object obj31 = num8 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v5+28]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X9_v4+28]");
							object obj32 = num9 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							object obj33 = st.cut * 12;
							object obj34 = (object)was + obj33;
							double num10 = (double)obj31 * num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							object obj35 = obj32 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v7+20]");
							double num11 = 0.0 - num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v7+28]");
							object obj36 = 0 - obj35;
							Vector3[] was2 = st.was;
							bool flag7 = (nint)obj2 < was2.Length;
							object obj37 = !flag7;
							if (obj37 == null)
							{
								object obj38 = obj2 * 12;
								object obj39 = (object)was2 + obj38;
								double num12 = num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v9+20]");
								double num13 = num12 + 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v9+28]");
								object obj40 = obj35 + 0;
								int num14;
								int minInclusive;
								if (st.kind != 0)
								{
									num14 = 5;
									minInclusive = 2;
								}
								else
								{
									num14 = 3;
									minInclusive = 1;
								}
								int num15 = UnityEngine.Random.Range(minInclusive, num14);
								if (num15 < 1)
								{
									return;
								}
								object obj41 = 17285120 + 136;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								int num16 = num15;
								object obj50 = default;
								while (true)
								{
									Vector3[] at2 = st.at;
									bool flag8 = st.cut < at2.Length;
									object obj42 = !flag8;
									if (obj42 != null)
									{
										break;
									}
									bool flag9 = (nint)obj2 < at2.Length;
									object obj43 = !flag9;
									if (obj43 != null)
									{
										break;
									}
									object obj44 = st.cut * 12;
									object obj45 = (object)at2 + obj44;
									object obj46 = obj2 * 12;
									object obj47 = (object)at2 + obj46;
									float value = UnityEngine.Random.value;
									if (value < 0f || !((double)value > 1.0))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v18+20]");
										nint num17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X9_v14+20]");
										object obj48 = num17 - 0;
										object obj49 = obj48 * obj50;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X9_v14+20]");
										float big = 0f + (float)obj49;
										Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
										bool flag10 = st.kind == 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B00C]");
										nint num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X25_v6+v635 @ Z_v18 (System.Boolean)*4]");
										float num19 = UnityEngine.Random.Range(num18, 0f);
										Drip((Vector3)num14, (Vector3)0, big);
									}
									num16--;
									if (num16 == 1)
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void Drip(Vector3 at, Vector3 going, float big)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0227: Expected VT, but got I8
		//IL_0227: Expected VT, but got Ref
		//IL_0259: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		float[] array = dropLife;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = array.Length + array.Length;
		object obj3 = obj2 << 2;
		object obj4 = 0;
		object obj5 = 8;
		object obj15 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		object obj16 = default;
		double num2 = default;
		while (obj3 != obj4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1 (System.Single[])+v222 @ X20_v4*4]");
			if ((nint)0 > (nint)0)
			{
				obj4 += 12;
				obj5++;
				if ((nint)obj4 == 168)
				{
					return;
				}
				continue;
			}
			Vector3[] array2 = dropAt;
			object obj6 = obj5 - 8;
			bool flag = (nint)obj6 < array2.Length;
			object obj7 = !flag;
			if (obj7 != null)
			{
				break;
			}
			object obj8 = (object)array2 + obj4;
			Vector3[] array3 = dropGoing;
			bool flag2 = (nint)obj6 < array3.Length;
			object obj9 = !flag2;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = (object)array3 + obj4;
			float[] array4 = dropSize;
			bool flag3 = (nint)obj6 < array4.Length;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				break;
			}
			float[] array5 = dropLife;
			bool flag4 = (nint)obj6 < array5.Length;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				break;
			}
			float[] array6 = dropFloor;
			_ = 1068708659;
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = Physics.Raycast((Vector3)(&obj15), (Vector3)4294951163L, out *(RaycastHit*)1, big, 0, queryTriggerInteraction);
			bool flag7 = !flag6;
			double num = (double)obj16 + -4.0;
			object obj17 = !flag7;
			object obj18 = ~obj17;
			if (obj18 == null)
			{
				num = num2;
			}
			bool flag8 = (nint)obj6 < array6.Length;
			object obj19 = !flag8;
			if (obj19 != null)
			{
				break;
			}
			int num3 = dropsOut + 1;
			dropsOut = num3;
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Falling(float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got F4
		//IL_01f1: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got F4
		//IL_02d0: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_042f: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		if (dropsOut == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 gravity = Physics.gravity;
		float[] array = dropLife;
		float num = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
		float num2 = num * 0f;
		object obj4 = default;
		float num3 = dt * (float)obj4;
		object obj5 = default;
		float num4 = num2 * (float)obj5;
		object obj6 = 40;
		object obj7 = 8;
		object obj20 = default;
		while (true)
		{
			object obj8 = obj7 - 8;
			bool flag2 = (nint)obj8 < array.Length;
			object obj9 = !flag2;
			if (obj9 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v6 (System.Single[])+v160 @ X8_v10*4]");
			bool flag3 = (nint)0 < (nint)0;
			object obj10 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v6 (System.Single[])+v160 @ X8_v10*4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = ~obj10;
			object obj12 = obj11 | flag4;
			if (obj12 == null)
			{
				Vector3[] array2 = dropGoing;
				bool flag5 = (nint)obj8 < array2.Length;
				object obj13 = !flag5;
				if (obj13 != null)
				{
					break;
				}
				object obj14 = (object)array2 + obj6;
				float num5 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X11_v8-8]");
				float num6 = num5 + 0f;
				float num7 = num4 + (float)obj14;
				obj14 = num7;
				Vector3[] array3 = dropAt;
				bool flag6 = (nint)obj8 < array3.Length;
				object obj15 = !flag6;
				if (obj15 != null)
				{
					break;
				}
				Vector3[] array4 = dropGoing;
				bool flag7 = (nint)obj8 < array4.Length;
				object obj16 = !flag7;
				if (obj16 != null)
				{
					break;
				}
				object obj17 = (object)array4 + obj6;
				object obj18 = (object)array3 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X12_v10-8]");
				object obj19 = 0 * obj20;
				float num8 = (float)obj17 * dt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X11_v10-8]");
				object obj21 = 0 + obj19;
				float num9 = (float)obj18 + num8;
				obj18 = num9;
				float[] array5 = dropLife;
				bool flag8 = (nint)obj8 < array5.Length;
				object obj22 = !flag8;
				if (obj22 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X11_v11 (System.Single[])+v160 @ X8_v10*4]");
				float num10 = 0f - dt;
				Vector3[] array6 = dropAt;
				bool flag9 = (nint)obj8 < array6.Length;
				object obj23 = !flag9;
				if (obj23 != null)
				{
					break;
				}
				float[] array7 = dropFloor;
				bool flag10 = (nint)obj8 < array7.Length;
				object obj24 = !flag10;
				if (obj24 != null)
				{
					break;
				}
				object obj25 = (object)array6 + obj6;
				array = dropLife;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X11_v13-4]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X12_v13 (System.Single[])+v160 @ X8_v10*4]");
				if (num11 < 0)
				{
					bool flag11 = (nint)obj8 < array.Length;
					object obj26 = !flag11;
					if (obj26 != null)
					{
						break;
					}
					_ = 0;
				}
				bool flag12 = (nint)obj8 < array.Length;
				object obj27 = !flag12;
				if (obj27 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v6 (System.Single[])+v160 @ X8_v10*4]");
				bool flag13 = (nint)0 < (nint)0;
				object obj28 = !flag13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v6 (System.Single[])+v160 @ X8_v10*4]");
				bool flag14 = (nint)0 == 0;
				object obj29 = !flag14;
				object obj30 = obj28 & obj29;
				if (obj30 == null)
				{
					int num12 = dropsOut - 1;
					dropsOut = num12;
				}
			}
			obj6 += 12;
			obj7++;
			if ((nint)obj6 == 208)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Hang(Strand st, Vector3 A, Vector3 B, float far, float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0225: Expected F4, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0c94: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_0308: Expected Obj, but got F4
		//IL_0323: Expected Obj, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected I4, but got Unknown
		//IL_04e0: Expected Obj, but got I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_135e: Expected Obj, but got Unknown
		//IL_136e: Expected Obj, but got I
		//IL_1377: Expected Obj, but got I4
		//IL_0f89: Expected Obj, but got I4
		//IL_0cd0: Invalid comparison between F4 and I4
		//IL_0cdf: Invalid comparison between F4 and I4
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected Obj, but got Unknown
		//IL_0d00: Expected Obj, but got F4
		//IL_0d35: Expected Obj, but got I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d4b: Expected I4, but got Obj
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a2: Expected Obj, but got Unknown
		//IL_0532: Expected F4, but got I4
		//IL_05b8: Expected Obj, but got I4
		//IL_05de: Expected F4, but got I
		//IL_05ee: Expected F4, but got I
		//IL_05fe: Expected F4, but got I
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected Obj, but got Unknown
		//IL_0e04: Expected VT, but got Obj
		//IL_0e26: Expected Obj, but got I4
		//IL_0681: Invalid comparison between F4 and I
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected Obj, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected I4, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected I4, but got Unknown
		//IL_0712: Expected Obj, but got I4
		//IL_071b: Expected I4, but got Obj
		//IL_08e7: Expected Obj, but got I4
		//IL_0e4f: Expected Obj, but got I4
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_0924: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got I4
		//IL_094e: Expected Obj, but got I4
		//IL_099c: Expected Obj, but got I4
		//IL_09a5: Expected Obj, but got I4
		//IL_09ae: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I4
		//IL_098e: Expected Obj, but got I4
		//IL_0ece: Expected Obj, but got I
		//IL_0ee6: Expected Obj, but got I
		//IL_0eee: Expected F4, but got Obj
		//IL_0efe: Expected F8, but got I
		//IL_09ce: Expected Obj, but got I4
		//IL_0eb0: Expected Obj, but got I4
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected Obj, but got Unknown
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0818: Expected F4, but got I
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected Obj, but got Unknown
		//IL_085f: Expected Obj, but got I4
		//IL_0f73: Expected Obj, but got F8
		//IL_0f13: Expected Obj, but got I
		//IL_0f2b: Expected Obj, but got I
		//IL_0f33: Expected F4, but got Obj
		//IL_0f43: Expected F4, but got I
		//IL_1014: Invalid comparison between F8 and I4
		//IL_1027: Expected Obj, but got F8
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Expected Obj, but got Unknown
		//IL_1070: Expected Obj, but got I4
		//IL_108f: Invalid comparison between Obj and F8
		//IL_10a0: Expected Obj, but got I4
		//IL_10b8: Invalid comparison between F8 and I4
		//IL_10f1: Expected Obj, but got I4
		//IL_117d: Expected Obj, but got I4
		//IL_0b22: Invalid comparison between F8 and I4
		//IL_11ee: Invalid comparison between F8 and I4
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Expected Obj, but got Unknown
		//IL_120f: Expected Obj, but got F8
		//IL_1244: Expected Obj, but got I4
		//IL_0c23: Expected F8, but got I4
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected Obj, but got Unknown
		//IL_11c2: Expected Obj, but got I4
		//IL_1274: Invalid comparison between F8 and I4
		//IL_1283: Invalid comparison between F8 and I4
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_1297: Expected Obj, but got Unknown
		//IL_12a4: Expected Obj, but got F8
		//IL_12d9: Expected Obj, but got I4
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected Obj, but got Unknown
		//IL_0c36: Expected F8, but got I4
		//IL_1307: Invalid comparison between F8 and I4
		//IL_1318: Expected Obj, but got I4
		//IL_134a: Expected F4, but got I
		//IL_134a: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		Vector3[] at = st.at;
		Vector3[] was = st.was;
		object obj2 = obj;
		object obj5 = default;
		float num3 = default;
		float num4;
		float num6;
		object obj10 = default;
		float num7;
		if (~(st.snapped ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 gravity = Physics.gravity;
			object obj4 = obj5 * obj5;
			object obj6 = default;
			float num = far * (float)obj6;
			float num2 = (float)obj4 * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num4 = num * num3;
			float num5 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num6 = num5 * 0f;
			bool flag2 = st.at == null;
			object obj7 = !flag2;
			num7 = num3;
			if (obj7 == null)
			{
				goto IL_0c72;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 gravity = Physics.gravity;
			float num8 = num3 * st.heavy;
			object obj9 = default;
			float num9 = far * (float)obj9;
			float num10 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [st @ X1 (GillaStrands+Strand)+C8]");
			float num11 = num10 + 0f;
			float num12 = num9 + (float)st.drift;
			num7 = (float)obj5 * (float)obj5;
			num4 = num12 * (float)obj10;
			num6 = num7 * num11;
		}
		object obj11 = st.at + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD8C]");
		float num13 = 0f;
		object obj12 = st.was + 40;
		object obj13 = 0;
		float num33 = default;
		double num63 = default;
		while (true)
		{
			bool flag4 = (nint)obj13 < at.Length;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				break;
			}
			bool flag5 = (nint)obj13 < was.Length;
			object obj15 = !flag5;
			if (obj15 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X10_v3-8]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X9_v7-8]");
			object obj16 = num14 - 0;
			object obj17 = obj11 - obj12;
			float num15 = (float)obj16 * num7;
			float num16 = (float)obj17 * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X10_v3-8]");
			float num17 = 0f + num15;
			float num18 = (float)obj11 + num16;
			float num19 = num4 + num17;
			float num20 = num6 + num18;
			obj11 = num20;
			bool flag6 = (nint)obj13 < was.Length;
			object obj18 = !flag6;
			if (obj18 != null)
			{
				break;
			}
			obj13++;
			obj11 += 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X10_v3-8]");
			_ = 0;
			obj12 = obj11;
			obj12 += 12;
			if ((nint)obj13 != 9)
			{
				continue;
			}
			if (at.Length == 0)
			{
				break;
			}
			bool flag7 = at.Length < 8;
			object obj19 = !flag7;
			object obj20 = at.Length - 8;
			bool flag8 = obj20 == null;
			object obj21 = ~obj19;
			object obj22 = obj21 | flag8;
			if (obj22 != null)
			{
				break;
			}
			double num28;
			double num29;
			if (~(st.snapped ? 1u : 0u) == 0)
			{
				object obj23 = st.cut - 1;
				bool flag9 = (nint)obj23 < 0;
				bool flag10 = obj23 == null;
				int num21 = st.cut ^ 1;
				int num22 = st.cut ^ obj23;
				int num23 = num21 & num22;
				bool flag11 = num23 < 0;
				double num24 = st.stub;
				bool flag12 = flag9 == flag11;
				object obj24 = !flag10;
				object obj25 = flag12 & obj24;
				object obj26 = ~obj25;
				int num25 = ((obj26 != null) ? 1 : st.cut);
				float num26 = 7f - (float)st.cut;
				float num27 = num26 - 1f;
				bool flag13 = num27 < 0f;
				bool flag14 = num27 == 0f;
				object obj27 = num26 ^ 1;
				object obj28 = num26 ^ num27;
				object obj29 = obj27 & obj28;
				bool flag15 = (nint)obj29 < 0;
				bool flag16 = flag13 == flag15;
				object obj30 = !flag14;
				object obj31 = flag16 & obj30;
				if ((int)(~obj31) != 0)
				{
					num26 = 1f;
				}
				num28 = num24 / (double)num25;
				num29 = num24 / (double)num26;
				float num30 = num26;
			}
			else
			{
				float num31 = size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				float num32 = num31 * 0f;
				if (num32 < num33)
				{
					num32 = num33;
				}
				float num30 = st.slack * num32;
				num28 = (double)num30 * 0.125;
				double num24 = 0.125;
				num29 = num28;
			}
			object obj32 = st.at + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj33 = 0;
			object obj34 = 0;
			float num34 = far;
			float num35 = dt;
			float num36 = num3;
			while (true)
			{
				object obj35 = obj32;
				object obj36 = 0;
				while (true)
				{
					object obj37 = obj36 + 1;
					if (~(st.snapped ? 1u : 0u) != 0 || st.cut != (nint)obj36)
					{
						bool flag17 = (nint)obj37 < at.Length;
						object obj38 = !flag17;
						if (obj38 != null)
						{
							break;
						}
						object obj39 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-8]");
						num36 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-14]");
						num35 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-C]");
						num34 = 0f;
						Vector3 gravity = (Vector3)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v29 (UnityEngine.Vector3)+E4]");
						bool flag18 = (nint)0 == 0;
						object obj40 = !flag18;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num30 = num36 - num35;
						double num24 = (double)obj39 - (double)num34;
						float num37 = num30 * num30;
						double num38 = num24 * num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						num7 = num37 + (float)num38;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num39 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
						bool flag19 = num39 < 0f;
						num13 = (float)num38;
						if (!flag19)
						{
							object obj41 = obj36 - st.cut;
							bool flag20 = (nint)obj41 < 0;
							int num40 = obj36 ^ st.cut;
							object obj42 = obj36 ^ obj41;
							int num41 = num40 & obj42;
							bool flag21 = num41 < 0;
							bool flag22 = flag20 == flag21;
							object obj43 = !flag22;
							double num42 = (((int)(~obj43) != 0) ? num29 : num28);
							bool flag23 = (nint)obj36 < at.Length;
							object obj44 = !flag23;
							if (obj44 != null)
							{
								break;
							}
							num13 = num7 - (float)num42;
							float num43 = num13 / num7;
							num7 = num43 * 0.5f;
							num36 = num30 * (float)obj10;
							double num44 = num24 * (double)num7;
							float num45;
							double num46;
							if (obj36 != null)
							{
								bool flag24 = (nint)obj36 != 7;
								num45 = num36;
								num46 = num44;
								if (!flag24)
								{
									num45 = num36 + num36;
									num46 = num44 + num44;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj45 = 0;
								object obj46 = obj45;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v64+A0]");
								object obj47 = 0;
								num45 = (float)obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v65+8]");
								num46 = 0.0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-14]");
							float num47 = 0f + num45;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-C]");
							double num48 = 0.0 + num46;
							bool flag25 = (nint)obj37 < at.Length;
							object obj48 = !flag25;
							if (obj48 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X27_v5-8]");
							num34 = 0f;
							obj39 = obj35;
							if ((nint)obj36 != 7)
							{
								bool flag26 = obj36 == null;
								object obj49 = !flag26;
								num35 = (float)num44;
								if (obj49 == null)
								{
									num36 += num36;
									double num49 = num44 + num44;
									num35 = (float)num49;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj50 = 0;
								object obj51 = obj50;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v57+A0]");
								object obj52 = 0;
								num36 = (float)obj52;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v58+8]");
								num35 = 0f;
							}
							num30 = num34 - num36;
							num24 = (double)obj39 - (double)num35;
							obj35 = num24;
						}
					}
					obj35 += 12;
					bool flag27 = (nint)obj37 != 8;
					obj36 = obj37;
					if (flag27)
					{
						continue;
					}
					goto IL_08a0;
				}
				break;
				IL_08a0:
				obj34++;
				if ((nint)obj34 != 5)
				{
					continue;
				}
				bool flag28 = (byte)(~(st.snapped ? 1u : 0u)) != 0;
				object obj53 = !flag28;
				if (obj53 != null)
				{
					return;
				}
				object obj54 = st.at + 48;
				bool flag29 = at.Length < 1;
				object obj55 = !flag29;
				object obj56 = at.Length - 1;
				bool flag30 = obj56 == null;
				object obj57 = !flag30;
				object obj58 = obj55 & obj57;
				object obj59 = ~obj58;
				object obj60;
				object obj61;
				object obj62;
				if (obj59 == null)
				{
					obj60 = 1;
					obj61 = at.Length;
					obj62 = 4;
				}
				else
				{
					obj60 = 1;
					obj61 = 1;
					obj62 = 4;
				}
				while (obj61 != obj60)
				{
					bool flag31 = (nint)obj62 < at.Length;
					object obj63 = !flag31;
					if (obj63 != null)
					{
						break;
					}
					object obj64 = obj62 * 12;
					object obj65 = (object)st.at + obj64;
					obj54 += 12;
					object obj66 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X14_v5+24]");
					if ((nint)obj66 < 0)
					{
						obj62 = obj60;
					}
					obj60++;
					if ((nint)obj60 != 8)
					{
						continue;
					}
					double num50 = (double)obj62 + (double)obj62;
					bool flag32 = num50 < 4.0;
					double num51 = 4.0;
					if (!flag32)
					{
						bool flag33 = !(num50 > 12.0);
						num51 = num50;
						if (!flag33)
						{
							num51 = 12.0;
						}
					}
					double num52 = num51 - (double)st.beadAt;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					double num53 = (double)obj5 * 9.0;
					double num54 = (double)obj5 * 9.0;
					double num55 = 0.0 - num54;
					bool flag34 = num52 < 0.0;
					object obj67 = num52 ^ num52;
					object obj68 = num52 & obj67;
					bool flag35 = (nint)obj68 < 0;
					float num56 = st.beadGrows * (float)obj5;
					bool flag36 = flag34 == flag35;
					object obj69 = !flag36;
					object obj70 = ~obj69;
					if (obj70 != null)
					{
						num55 = num53;
					}
					bool flag37 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num53);
					object obj71 = !flag37;
					double num57 = (double)obj11 - num53;
					bool flag38 = num57 == 0.0;
					double num58 = (double)st.beadAt + num55;
					float num59 = st.bead + num56;
					object obj72 = !flag38;
					object obj73 = obj71 & obj72;
					object obj74 = ~obj73;
					if (obj74 == null)
					{
						num51 = num58;
					}
					st.beadAt = (float)num51;
					st.bead = num59;
					if ((double)num59 < 1.0)
					{
						return;
					}
					st.bead = 0.15f;
					double num60 = num51 * 0.5;
					object obj75 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X0_v12+E4]");
					bool flag39 = (nint)0 == 0;
					object obj76 = !flag39;
					if (obj76 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					double num61;
					double num62;
					if (num60 < 0.0)
					{
						if (num60 == -0.5)
						{
							num61 = -1.0;
							num62 = num63;
							goto IL_118b;
						}
						num62 = num60 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if (num60 == 0.5)
						{
							num61 = 1.0;
							num62 = num63;
							goto IL_118b;
						}
						num62 = num60 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_11d5;
					IL_118b:
					double num64 = num62 + num61;
					object obj77 = num62 & 1;
					bool flag40 = obj77 == null;
					object obj78 = !flag40;
					if (obj78 != null)
					{
						num62 = num64;
					}
					goto IL_11d5;
					IL_11d5:
					double num65 = num62 - 7.0;
					bool flag41 = num65 < 0.0;
					object obj79 = num62 ^ 7;
					object obj80 = num62 ^ num65;
					object obj81 = obj79 & obj80;
					bool flag42 = (nint)obj81 < 0;
					bool flag43 = flag41 == flag42;
					object obj82 = !flag43;
					object obj83 = ~obj82;
					double num66 = ((obj83 != null) ? 7.0 : num62);
					double num67 = num66 - 1.0;
					bool flag44 = num67 < 0.0;
					bool flag45 = num67 == 0.0;
					object obj84 = num66 ^ 1;
					object obj85 = num66 ^ num67;
					object obj86 = obj84 & obj85;
					bool flag46 = (nint)obj86 < 0;
					bool flag47 = flag44 == flag46;
					object obj87 = !flag45;
					object obj88 = flag47 & obj87;
					object obj89 = ~obj88;
					if (obj89 != null)
					{
						num66 = 1.0;
					}
					bool flag48 = num66 < (double)at.Length;
					object obj90 = !flag48;
					if (obj90 != null)
					{
						break;
					}
					double num68 = num66 * 12.0;
					double num69 = (double)st.at + num68;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v31 (System.Double)+20]");
					Drip((Vector3)st, A, 0f);
					return;
				}
				break;
			}
			break;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0c72;
		IL_0c72:
		throw new NullReferenceException();
	}

	private static void Rounded(Strand st)
	{
		//IL_001f: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_09d9: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected I4, but got Unknown
		//IL_08ed: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected I4, but got Unknown
		//IL_04d9: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected I4, but got Unknown
		//IL_042b: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected I4, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected I4, but got Unknown
		//IL_0354: Expected Obj, but got I4
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_0942: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I8
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0269: Expected F8, but got I
		//IL_0279: Expected Obj, but got I
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0897: Expected Obj, but got F8
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05c7: Expected Obj, but got I4
		//IL_0765: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got I
		//IL_05f5: Expected Obj, but got I
		//IL_096c: Expected Obj, but got I4
		//IL_097c: Expected Obj, but got I4
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_0629: Expected Obj, but got I4
		//IL_079a: Expected Obj, but got I
		//IL_07aa: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_066f: Expected Obj, but got I
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06bc: Expected Obj, but got I
		//IL_06d9: Expected Obj, but got I
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_07d1: Expected Obj, but got I4
		//IL_07e7: Expected Obj, but got I
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj = 0;
		Vector3[] at = st.at;
		object obj2 = 0;
		object obj68 = default;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			bool flag2 = (nint)obj2 < at.Length;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v8+50]");
			object obj7 = 0;
			object obj8 = obj2 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v9+18]");
			bool flag3 = (nint)obj8 < 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = obj2 * 12;
			object obj11 = (object)at + obj10;
			object obj12 = obj8 * 12;
			object obj13 = obj7 + obj12;
			object obj14 = obj11 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X27_v5+8]");
			_ = 0;
			object obj25;
			double num;
			int num2;
			object obj27;
			object obj26;
			if (~(st.snapped ? 1u : 0u) == 0)
			{
				if ((nint)obj2 == st.cut)
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v19+E4]");
					bool flag4 = (nint)0 == 0;
					object obj16 = !flag4;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj;
					}
					obj2++;
					bool flag5 = (nint)obj2 < at.Length;
					object obj17 = !flag5;
					if (obj17 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v19+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v30+50]");
					object obj19 = 0;
					object obj20 = obj8 | 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v31+18]");
					bool flag6 = (nint)obj20 < 0;
					object obj21 = !flag6;
					if (obj21 != null)
					{
						break;
					}
					object obj22 = obj2 * 12;
					object obj23 = (object)at + obj22;
					object obj24 = obj20 * 12;
					obj25 = obj19 + obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X10_v16+20]");
					num = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X10_v16+24]");
					obj26 = 0;
					goto IL_0881;
				}
				if ((nint)obj2 < st.cut)
				{
					num2 = obj2 + 2;
					obj27 = obj2 - 1;
					object obj28 = num2 - st.cut;
					bool flag7 = (nint)obj28 < 0;
					int num3 = num2 ^ st.cut;
					int num4 = num2 ^ obj28;
					int num5 = num3 & num4;
					bool flag8 = num5 < 0;
					bool flag9 = flag7 == flag8;
					object obj29 = !flag9;
					object obj30 = ~obj29;
					if (obj30 != null)
					{
						num2 = st.cut;
					}
				}
				else
				{
					object obj31 = st.cut + 1;
					obj27 = obj2 - 1;
					object obj32 = obj27 - obj31;
					bool flag10 = (nint)obj32 < 0;
					bool flag11 = obj32 == null;
					object obj33 = obj27 ^ obj31;
					object obj34 = obj27 ^ obj32;
					object obj35 = obj33 & obj34;
					bool flag12 = (nint)obj35 < 0;
					num2 = obj2 + 2;
					bool flag13 = flag10 == flag12;
					object obj36 = !flag11;
					object obj37 = flag13 & obj36;
					object obj38 = ~obj37;
					if (obj38 != null)
					{
						obj27 = st.cut + 1;
					}
				}
			}
			else
			{
				obj27 = obj2 - 1;
				num2 = obj2 + 2;
			}
			object obj39 = ~obj27;
			object obj40 = obj27 & obj39;
			bool flag14 = (nint)obj40 < at.Length;
			object obj41 = !flag14;
			if (obj41 != null)
			{
				break;
			}
			object obj42 = num2 - 8;
			bool flag15 = (nint)obj42 < 0;
			int num6 = num2 ^ 8;
			int num7 = num2 ^ obj42;
			int num8 = num6 & num7;
			bool flag16 = num8 < 0;
			bool flag17 = flag15 == flag16;
			object obj43 = !flag17;
			object obj44 = ~obj43;
			if (obj44 != null)
			{
				num2 = 8;
			}
			bool flag18 = num2 < at.Length;
			object obj45 = !flag18;
			if (obj45 != null)
			{
				break;
			}
			object obj46 = obj40 * 12;
			object obj47 = (object)at + obj46;
			object obj48 = obj;
			object obj49 = num2 * 12;
			object obj50 = (object)at + obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v10+E4]");
			object obj51;
			if ((nint)0 != 0)
			{
				obj51 = at.Length & 0xFFFFFFFFL;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj48 = obj;
				obj51 = at.Length;
			}
			bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
			object obj52 = !flag19;
			if (obj52 != null)
			{
				break;
			}
			obj2++;
			bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
			object obj53 = !flag20;
			if (obj53 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v10+A0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v15+50]");
			object obj55 = 0;
			object obj56 = obj8 | 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v16+18]");
			bool flag21 = (nint)obj56 < 0;
			object obj57 = !flag21;
			if (obj57 != null)
			{
				break;
			}
			object obj58 = obj2 * 12;
			object obj59 = (object)at + obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v6+24]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v7+24]");
			object obj60 = num9 + 0;
			object obj61 = obj56 * 12;
			obj25 = obj55 + obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X10_v8+20]");
			object obj62 = obj14 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v6+20]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v7+20]");
			object obj63 = num10 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X27_v5+4]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X10_v8+24]");
			object obj64 = num11 + 0;
			double num12 = (double)obj62 * 0.5625;
			object obj65 = obj63 * 3179282432L;
			object obj66 = obj64 * 0;
			object obj67 = obj60 * obj68;
			num = num12 + (double)obj65;
			obj26 = obj66 + obj67;
			goto IL_0881;
			IL_0881:
			object obj69 = obj25 + 32;
			obj69 = num;
			if ((nint)obj2 == 8)
			{
				object obj70 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v15+E4]");
				bool flag22 = (nint)0 == 0;
				object obj71 = !flag22;
				if (obj71 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj70 = obj;
				}
				bool flag23 = at.Length < 8;
				object obj72 = !flag23;
				object obj73 = at.Length - 8;
				bool flag24 = obj73 == null;
				object obj74 = ~obj72;
				object obj75 = obj74 | flag24;
				if (obj75 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v15+A0]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v24+50]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v25+18]");
				bool flag25 = (nint)0 < (nint)16;
				object obj78 = !flag25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v25+18]");
				object obj79 = -16;
				bool flag26 = obj79 == null;
				object obj80 = ~obj78;
				object obj81 = obj80 | flag26;
				if (obj81 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X20_v3 (UnityEngine.Vector3[])+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X20_v3 (UnityEngine.Vector3[])+88]");
				_ = 0;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe static Vector2[] Round(int sides)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got Ref
		//IL_0302: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I
		//IL_011c: Expected Obj, but got Ref
		//IL_0341: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got Ref
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected I4, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
		bool flag2 = (nint)0 == 0;
		System.__Canon value = null;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9128]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			bool flag3 = ((Dictionary<int, System.__Canon>)0).TryGetValue(sides, out value);
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj8 = sides - 1;
				bool flag5 = obj8 == null;
				bool flag6 = sides < 1;
				nint num = sides;
				System.__Canon _Canon = default;
				value = _Canon;
				object obj9 = (object)(&value);
				if (!flag6)
				{
					bool flag7 = _Canon == null;
					num = sides;
					value = _Canon;
					obj9 = (object)(&value);
					if (flag7)
					{
						goto IL_02cd;
					}
					int num2 = 0 / sides;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
					object obj10 = 1;
					object obj11 = 0;
					object obj13 = default;
					object obj12 = obj13;
					object obj15 = default;
					object obj14 = obj15;
					nint num3 = (nint)(&obj13);
					System.__Canon _Canon2 = _Canon;
					object obj27 = default;
					object obj28 = default;
					while (true)
					{
						object obj16 = obj10 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v7 (System.__Canon)+18]");
						bool flag8 = (nint)obj16 < 0;
						object obj17 = !flag8;
						if (obj17 == null)
						{
							object obj18 = (object)_Canon2 + obj11;
							obj8 = sides - obj10;
							flag5 = sides == (nint)obj10;
							object obj19 = obj10;
							object obj20 = obj11;
							object obj21 = obj12;
							object obj22 = obj14;
							num = num3;
							value = _Canon;
							obj9 = (object)(&value);
							if (flag5)
							{
								break;
							}
							object obj23 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
							object obj24 = obj23 * 0;
							object obj25 = obj24 + obj24;
							int num4 = obj25 / sides;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
							obj19 = obj10 + 1;
							obj20 = obj11 + 8;
							bool flag9 = _Canon == null;
							object obj26 = !flag9;
							obj21 = obj27;
							obj22 = obj28;
							num = (nint)(&obj27);
							value = _Canon;
							obj9 = (object)(&value);
							obj10 = obj19;
							obj11 = obj20;
							obj12 = obj27;
							obj14 = obj28;
							num3 = (nint)(&obj27);
							_Canon2 = _Canon;
							if (obj26 != null)
							{
								continue;
							}
							goto IL_02cd;
						}
						return (Vector2[])(object)new IndexOutOfRangeException();
					}
				}
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v9+E4]");
				bool flag10 = (nint)0 == 0;
				object obj30 = !flag10;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj29 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v9+A0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					goto IL_02cd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8+20]");
				((Dictionary<int, System.__Canon>)0).set_Item(sides, value);
			}
			return (Vector2[])(object)value;
		}
		goto IL_02cd;
		IL_02cd:
		throw new NullReferenceException();
	}

	private unsafe void Draw()
	{
		//IL_376a: Expected Obj, but got I
		//IL_3782: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I4
		//IL_0047: Expected F8, but got I
		//IL_0068: Expected F8, but got I
		//IL_0078: Expected F8, but got I
		//IL_0088: Expected F8, but got I
		//IL_1be4: Expected Obj, but got I4
		//IL_1bed: Expected F8, but got I4
		//IL_1bfd: Expected F8, but got I
		//IL_00a6: Expected F8, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_016a: Expected F8, but got I4
		//IL_017a: Expected F8, but got I
		//IL_1c1d: Expected Obj, but got I4
		//IL_326f: Expected Obj, but got I4
		//IL_1c52: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected F8, but got I
		//IL_1cc2: Expected Obj, but got I4
		//IL_1c94: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I4
		//IL_1d1d: Expected Obj, but got I4
		//IL_1afe: Expected Obj, but got I4
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0c: Expected Obj, but got Unknown
		//IL_1b2c: Expected F8, but got I
		//IL_1bbc: Expected F8, but got I
		//IL_0206: Expected native int or pointer, but got F8
		//IL_0231: Expected Obj, but got I4
		//IL_3286: Unknown result type (might be due to invalid IL or missing references)
		//IL_328b: Expected Obj, but got Unknown
		//IL_0494: Expected Obj, but got I4
		//IL_1d76: Expected Obj, but got I
		//IL_1d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8b: Expected Obj, but got Unknown
		//IL_1dc8: Expected Obj, but got I4
		//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd5: Expected Obj, but got Unknown
		//IL_1dfc: Expected Obj, but got I4
		//IL_0277: Expected F8, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_0289: Expected F8, but got I4
		//IL_2519: Unknown result type (might be due to invalid IL or missing references)
		//IL_251e: Expected Obj, but got Unknown
		//IL_32bb: Expected Obj, but got I
		//IL_32cb: Expected Obj, but got I
		//IL_2691: Expected native int or pointer, but got F8
		//IL_26bc: Expected Obj, but got I4
		//IL_2630: Expected Obj, but got I
		//IL_2640: Expected Obj, but got I
		//IL_25b7: Expected Obj, but got Ref
		//IL_1e4b: Expected Obj, but got I4
		//IL_02c7: Invalid comparison between F8 and I
		//IL_02d8: Expected Obj, but got I4
		//IL_02a9: Expected native int or pointer, but got F8
		//IL_25f6: Expected VT, but got Ref
		//IL_0303: Expected F8, but got I
		//IL_1e83: Expected Obj, but got I4
		//IL_0541: Expected Obj, but got I4
		//IL_2655: Expected Obj, but got I
		//IL_267f: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_1e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9f: Expected Obj, but got Unknown
		//IL_1eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eba: Expected Obj, but got Unknown
		//IL_1ed7: Expected F8, but got I
		//IL_1ee7: Expected F8, but got I
		//IL_1ef7: Expected F8, but got I
		//IL_056d: Expected F8, but got I
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_058d: Expected I4, but got I8
		//IL_05a9: Expected Obj, but got I4
		//IL_32e0: Expected Obj, but got I
		//IL_330a: Expected Obj, but got I4
		//IL_1f2e: Expected F8, but got I4
		//IL_05ff: Expected Obj, but got I8
		//IL_0660: Invalid comparison between F4 and I
		//IL_0676: Expected F8, but got I
		//IL_334b: Invalid comparison between F8 and I
		//IL_0419: Expected F8, but got I4
		//IL_0422: Expected F8, but got I4
		//IL_0756: Expected Obj, but got I
		//IL_076a: Expected I4, but got VT
		//IL_077e: Expected Obj, but got I
		//IL_07a8: Expected Obj, but got I4
		//IL_33ce: Expected Obj, but got I
		//IL_33e6: Expected Obj, but got I
		//IL_33f6: Expected F8, but got I
		//IL_3406: Expected F8, but got I
		//IL_1f66: Expected Obj, but got I4
		//IL_2754: Invalid comparison between F8 and I4
		//IL_2763: Expected F8, but got I4
		//IL_338e: Expected F8, but got Obj
		//IL_33b0: Expected Obj, but got I4
		//IL_095d: Expected F8, but got I
		//IL_3b9d: Expected Obj, but got I
		//IL_3bc7: Invalid comparison between F8 and I4
		//IL_3bd6: Expected F8, but got I4
		//IL_0741: Expected F8, but got I
		//IL_3421: Expected Obj, but got I
		//IL_3437: Expected Obj, but got I
		//IL_3440: Unknown result type (might be due to invalid IL or missing references)
		//IL_3445: Expected Obj, but got Unknown
		//IL_345b: Expected Obj, but got I
		//IL_3464: Unknown result type (might be due to invalid IL or missing references)
		//IL_3469: Expected Obj, but got Unknown
		//IL_3479: Unknown result type (might be due to invalid IL or missing references)
		//IL_347e: Expected Obj, but got Unknown
		//IL_3494: Expected Obj, but got I
		//IL_349d: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a2: Expected Obj, but got Unknown
		//IL_34c5: Expected Obj, but got I
		//IL_34ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d3: Expected Obj, but got Unknown
		//IL_34e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e8: Expected Obj, but got Unknown
		//IL_34f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f7: Expected Obj, but got Unknown
		//IL_351a: Expected F4, but got I
		//IL_3530: Expected Obj, but got I
		//IL_3539: Unknown result type (might be due to invalid IL or missing references)
		//IL_353e: Expected F8, but got Unknown
		//IL_3554: Expected Obj, but got I
		//IL_355d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3562: Expected Obj, but got Unknown
		//IL_35e3: Expected F8, but got I
		//IL_35ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f1: Expected Obj, but got Unknown
		//IL_3627: Expected F8, but got I
		//IL_363d: Expected Obj, but got I4
		//IL_20f2: Expected F8, but got Obj
		//IL_1f9e: Expected Obj, but got I4
		//IL_3797: Expected Obj, but got I
		//IL_37c3: Expected Obj, but got I
		//IL_37d3: Expected F8, but got I
		//IL_37e3: Expected F4, but got I
		//IL_37ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f1: Expected Obj, but got Unknown
		//IL_3832: Expected F8, but got I
		//IL_3863: Expected F8, but got I4
		//IL_0809: Expected F8, but got I4
		//IL_0818: Invalid comparison between VT and I4
		//IL_0829: Expected Obj, but got I4
		//IL_3664: Expected Obj, but got I4
		//IL_3b46: Expected Obj, but got I
		//IL_3b70: Expected Obj, but got I4
		//IL_3bf4: Expected Obj, but got I
		//IL_3c04: Expected Obj, but got I
		//IL_1fff: Invalid comparison between F8 and I4
		//IL_200e: Invalid comparison between F8 and I4
		//IL_2026: Expected Obj, but got F8
		//IL_2033: Expected Obj, but got F8
		//IL_2068: Expected Obj, but got I4
		//IL_2070: Unknown result type (might be due to invalid IL or missing references)
		//IL_2075: Expected Obj, but got Unknown
		//IL_2819: Expected Obj, but got I
		//IL_2829: Expected Obj, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0859: Expected F8, but got I
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected Obj, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		//IL_08ba: Expected Obj, but got I
		//IL_08ca: Expected F8, but got I
		//IL_0940: Expected VT, but got F8
		//IL_2143: Expected native int or pointer, but got F8
		//IL_0996: Invalid comparison between F8 and I
		//IL_09a7: Expected Obj, but got I4
		//IL_219a: Expected Obj, but got I4
		//IL_09dc: Invalid comparison between F8 and I4
		//IL_2205: Expected Obj, but got I4
		//IL_0b4d: Expected Obj, but got I4
		//IL_21b6: Expected native int or pointer, but got F8
		//IL_21cf: Expected Obj, but got I
		//IL_21df: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I8
		//IL_09f9: Invalid comparison between F8 and I4
		//IL_368a: Invalid comparison between F8 and I4
		//IL_3699: Invalid comparison between F8 and I4
		//IL_36ac: Expected Obj, but got F8
		//IL_36b9: Expected Obj, but got F8
		//IL_3702: Expected Obj, but got I4
		//IL_370a: Unknown result type (might be due to invalid IL or missing references)
		//IL_370f: Expected Obj, but got Unknown
		//IL_0b75: Expected Obj, but got I
		//IL_0b8d: Expected Obj, but got I
		//IL_0b9d: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got I4
		//IL_224a: Expected Obj, but got I4
		//IL_0be9: Expected Obj, but got I
		//IL_0c41: Expected F8, but got I
		//IL_0ccd: Expected F8, but got I
		//IL_0ced: Invalid comparison between F8 and I
		//IL_0cfe: Expected Obj, but got I4
		//IL_0a32: Expected Obj, but got I4
		//IL_287a: Expected F8, but got I
		//IL_288a: Invalid comparison between F8 and I
		//IL_0c90: Expected Obj, but got I
		//IL_0ca8: Expected Obj, but got I
		//IL_0cb8: Expected Obj, but got I
		//IL_0aa1: Expected Obj, but got I8
		//IL_226e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2273: Expected Obj, but got Unknown
		//IL_227c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2281: Expected Obj, but got Unknown
		//IL_229e: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Expected Obj, but got Unknown
		//IL_2362: Expected Obj, but got F8
		//IL_236b: Expected native int or pointer, but got F8
		//IL_2384: Expected Obj, but got I
		//IL_2394: Expected Obj, but got I
		//IL_297c: Invalid comparison between F8 and I
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected Obj, but got Unknown
		//IL_0d3b: Expected Obj, but got I4
		//IL_0a5a: Expected Obj, but got I
		//IL_0a72: Expected Obj, but got I
		//IL_0a82: Expected Obj, but got I
		//IL_23a9: Expected Obj, but got I
		//IL_23ca: Expected Obj, but got I4
		//IL_0f68: Invalid comparison between F8 and I
		//IL_0ace: Expected Obj, but got I
		//IL_0b26: Expected F8, but got I
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_0d9f: Expected Obj, but got I
		//IL_0daf: Expected F8, but got I
		//IL_0db3: Expected native int or pointer, but got F8
		//IL_23f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f5: Expected Obj, but got Unknown
		//IL_2405: Expected F8, but got I
		//IL_2415: Expected F8, but got I
		//IL_241e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2423: Expected Obj, but got Unknown
		//IL_242c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2431: Expected Obj, but got Unknown
		//IL_2461: Expected native int or pointer, but got F8
		//IL_2a75: Expected Obj, but got I
		//IL_2a93: Expected Obj, but got I
		//IL_2aa9: Expected Obj, but got I
		//IL_3898: Expected Obj, but got I
		//IL_38c2: Expected Obj, but got I4
		//IL_3928: Expected Obj, but got I
		//IL_2a14: Expected Obj, but got I
		//IL_2a32: Expected Obj, but got I
		//IL_2a48: Expected Obj, but got I
		//IL_38e0: Expected Obj, but got I
		//IL_390a: Expected Obj, but got I4
		//IL_0e15: Invalid comparison between F8 and I
		//IL_0edc: Invalid comparison between F8 and I
		//IL_0e71: Expected Obj, but got I
		//IL_0e89: Expected Obj, but got I
		//IL_0e91: Expected F8, but got Obj
		//IL_0ea1: Expected F8, but got I
		//IL_0ea9: Expected F8, but got Obj
		//IL_2ad6: Expected Obj, but got I
		//IL_2b00: Expected Obj, but got I4
		//IL_10dc: Expected Obj, but got I
		//IL_10f4: Expected Obj, but got I
		//IL_1104: Expected F8, but got I
		//IL_110c: Expected VT, but got Obj
		//IL_0fa1: Expected native int or pointer, but got F8
		//IL_103e: Expected VT, but got I
		//IL_1058: Invalid comparison between F8 and I
		//IL_1072: Expected F8, but got Obj
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected VT, but got Unknown
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected VT, but got Unknown
		//IL_10c7: Expected F8, but got Obj
		//IL_1296: Expected Obj, but got I4
		//IL_12ae: Invalid comparison between F8 and I4
		//IL_12bd: Expected F8, but got I4
		//IL_1146: Invalid comparison between F8 and I4
		//IL_1157: Expected Obj, but got I4
		//IL_2bfc: Invalid comparison between F8 and I4
		//IL_2c18: Expected F8, but got I4
		//IL_2c35: Expected Obj, but got I4
		//IL_2d78: Expected I4, but got Obj
		//IL_2b16: Invalid comparison between F8 and I4
		//IL_1187: Invalid comparison between F8 and I4
		//IL_39f4: Invalid comparison between F8 and I4
		//IL_3a03: Expected F8, but got I4
		//IL_1374: Expected Obj, but got I4
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected I4, but got Unknown
		//IL_13e2: Expected Obj, but got I4
		//IL_13ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected Obj, but got Unknown
		//IL_2f6f: Expected Obj, but got I
		//IL_2f99: Expected Obj, but got I4
		//IL_3a4d: Invalid comparison between F8 and I4
		//IL_3a6c: Expected F8, but got I4
		//IL_2b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3a: Expected I4, but got Unknown
		//IL_2b66: Invalid comparison between F8 and I4
		//IL_2b75: Invalid comparison between F8 and I4
		//IL_2b8d: Expected Obj, but got F8
		//IL_2b9a: Expected Obj, but got F8
		//IL_2bcf: Expected Obj, but got I4
		//IL_2bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdc: Expected Obj, but got Unknown
		//IL_2fcb: Expected Obj, but got I4
		//IL_2dc9: Expected Obj, but got I4
		//IL_2de1: Invalid comparison between F8 and I4
		//IL_2df2: Expected Obj, but got I4
		//IL_3aae: Invalid comparison between F8 and I
		//IL_1ad5: Expected F8, but got I
		//IL_15a2: Expected Obj, but got I4
		//IL_15ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b0: Expected Obj, but got Unknown
		//IL_15c6: Expected Obj, but got I
		//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected Obj, but got Unknown
		//IL_15ec: Expected Obj, but got I
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected Obj, but got Unknown
		//IL_1608: Expected Obj, but got I4
		//IL_1625: Unknown result type (might be due to invalid IL or missing references)
		//IL_162a: Expected Obj, but got Unknown
		//IL_1640: Expected Obj, but got I
		//IL_1649: Unknown result type (might be due to invalid IL or missing references)
		//IL_164e: Expected Obj, but got Unknown
		//IL_1664: Expected Obj, but got I
		//IL_1711: Unknown result type (might be due to invalid IL or missing references)
		//IL_1716: Expected Obj, but got Unknown
		//IL_175e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1763: Expected Obj, but got Unknown
		//IL_1774: Expected Obj, but got I4
		//IL_2e1e: Expected Obj, but got I4
		//IL_1443: Invalid comparison between F8 and I4
		//IL_306c: Invalid comparison between F8 and I4
		//IL_307b: Invalid comparison between F8 and I4
		//IL_3091: Unknown result type (might be due to invalid IL or missing references)
		//IL_3096: Expected Obj, but got Unknown
		//IL_30a3: Expected Obj, but got F8
		//IL_30ec: Expected Obj, but got I4
		//IL_30f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f9: Expected Obj, but got Unknown
		//IL_3ae0: Expected Obj, but got I4
		//IL_2e46: Expected Obj, but got I4
		//IL_2e4f: Expected F8, but got I4
		//IL_1aef: Expected F8, but got I
		//IL_3a29: Expected F8, but got I4
		//IL_146c: Expected F8, but got I
		//IL_3119: Invalid comparison between F8 and I4
		//IL_313a: Expected F8, but got I
		//IL_314a: Expected F8, but got I
		//IL_315a: Expected F8, but got I
		//IL_316b: Expected Obj, but got I4
		//IL_3170: Expected I, but got Obj
		//IL_3180: Expected F8, but got I
		//IL_3208: Expected F8, but got I
		//IL_3218: Expected F8, but got I
		//IL_3238: Expected F8, but got I
		//IL_17a1: Invalid comparison between F8 and I4
		//IL_17b2: Expected Obj, but got I4
		//IL_149c: Invalid comparison between I4 and F8
		//IL_14ad: Expected F8, but got I4
		//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ce: Expected Obj, but got Unknown
		//IL_195f: Expected native int or pointer, but got F8
		//IL_1974: Invalid comparison between F8 and I
		//IL_1985: Expected F8, but got VT
		//IL_2fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe7: Expected Obj, but got Unknown
		//IL_2ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff5: Expected Obj, but got Unknown
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected I4, but got Unknown
		//IL_1a81: Expected F8, but got VT
		//IL_1a91: Expected Obj, but got F8
		//IL_1aa2: Expected Obj, but got I4
		//IL_1aab: Expected Obj, but got I4
		//IL_3afe: Expected Obj, but got I
		//IL_3b28: Expected Obj, but got I4
		//IL_19db: Invalid comparison between F8 and I
		//IL_1a37: Expected Obj, but got I
		//IL_1a4f: Expected Obj, but got I
		//IL_1a57: Expected F8, but got Obj
		//IL_1a67: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+A0]");
		object obj3 = 0;
		Strand[] array = strands;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+A0]");
		object obj6 = 0;
		object obj7 = array.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v3+74]");
		double num = 0.0;
		bool flag = array.Length < 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+60]");
		double num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+68]");
		double num3 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v3+6C]");
		double num4 = 0.0;
		if (flag)
		{
			goto IL_1bdb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+68]");
		double num5 = 0.0;
		double num7 = default;
		double num6 = num7;
		double num9 = default;
		double num8 = num9;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		double num11 = default;
		double num10 = num11;
		double num13 = default;
		double num12 = num13;
		double num15 = default;
		double num14 = num15;
		float num17 = default;
		float num16 = num17;
		double num19 = default;
		double num18 = num19;
		object obj13 = default;
		object obj12 = obj13;
		IntPtr intPtr = default;
		nint num20 = intPtr;
		double num22 = default;
		double num21 = num22;
		Strand[] array2 = array;
		double num24 = default;
		double num23 = num24;
		double num26 = default;
		double num25 = num26;
		double num28 = default;
		double num27 = num28;
		double num30 = default;
		double num29 = num30;
		double num32 = default;
		double num31 = num32;
		object obj15 = default;
		object obj14 = obj15;
		double num34 = default;
		double num33 = num34;
		object obj16 = 17276928;
		object obj17 = 12;
		object obj18 = 0;
		double num35 = 17276928.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v3+74]");
		double num36 = 0.0;
		bool flag2 = false;
		GillaStrands gillaStrands = this;
		object obj45 = default;
		object obj50 = default;
		double num75 = default;
		double num80 = default;
		object obj56 = default;
		object obj58 = default;
		object obj93 = default;
		object obj105 = default;
		object obj140 = default;
		object obj148 = default;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj19 = !flag3;
			if (obj19 != null)
			{
				break;
			}
			object obj20 = (object)array2 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v73+20]");
			Strand strand = (Strand)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			double num37 = 0.0;
			float gone = strand.gone;
			int num38 = strand.firstVertex;
			Vector2[] array3;
			double num39;
			double num40;
			double num43;
			if ((double)strand.gone < 1.0)
			{
				double value = ((double*)(nint)num37)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ X0_v47 (System.Double)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj21 = !flag4;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Rounded(strand);
				array3 = Round(strand.sides);
				num39 = 1.0;
				object obj22 = 0;
				num40 = 0.0;
				double num41 = 1.0;
				while (true)
				{
					double value2 = ((double*)(nint)num37)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v54 (System.Double)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj23 = !flag5;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						value2 = ((double*)(nint)num37)->m_value;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v54 (System.Double)+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1614 @ X8_v83+50]");
					object obj25 = 0;
					double num42 = num39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v84+18]");
					bool flag6 = num42 < 0.0;
					object obj26 = !flag6;
					if (obj26 != null)
					{
						break;
					}
					object obj27 = obj25 + obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ X8_v85+28]");
					num43 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X0_v56+E4]");
					bool flag7 = (nint)0 == 0;
					object obj30 = !flag7;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ X8_v85+2C]");
					nint num44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ X8_v85+20]");
					object obj31 = num44 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ X8_v85+34]");
					double num45 = 0.0 - num43;
					obj22 += 12;
					num39++;
					object obj32 = obj31 * obj31;
					num41 = num45 * num45;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num46 = (double)obj32 + num41;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					num40 += num46;
					bool flag8 = (nint)obj22 != 192;
					gone = (float)num46;
					if (flag8)
					{
						continue;
					}
					goto IL_03df;
				}
				break;
			}
			bool flag9 = (byte)(~(strand.hidden ? 1u : 0u)) != 0;
			object obj33 = !flag9;
			double num47 = 1.0;
			Strand strand2 = strand;
			if (obj33 == null)
			{
				object obj34 = strand.sides + strand.sides;
				strand.hidden = true;
				bool flag10 = (nint)obj34 < 1;
				num47 = 1.0;
				strand2 = strand;
				flag2 = true;
				if (!flag10)
				{
					int num48 = strand.firstVertex << 32;
					while (true)
					{
						Vertex[] array4 = verts;
						Vector3[] at = strand.at;
						if (at.Length == 0)
						{
							break;
						}
						bool flag11 = num38 < array4.Length;
						object obj35 = !flag11;
						if (obj35 != null)
						{
							break;
						}
						int num49 = num48 >> 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X11_v17 (UnityEngine.Vector3[])+28]");
						num47 = 0.0;
						obj34--;
						flag2 = (byte)(num48 + 4294967296L) != 0;
						num38++;
						object obj36 = num49 * 36;
						num35 = (double)array4 + (double)obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X11_v17 (UnityEngine.Vector3[])+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X11_v17 (UnityEngine.Vector3[])+28]");
						_ = 0;
						if ((nint)obj34 != 1)
						{
							continue;
						}
						goto IL_05f2;
					}
					break;
				}
			}
			goto IL_1af4;
			IL_1af4:
			obj7 = array.Length;
			obj18++;
			bool flag12 = (nint)obj18 < array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+60]");
			num2 = 0.0;
			num3 = num5;
			obj9 = obj8;
			obj11 = obj10;
			num11 = num10;
			num15 = num14;
			num17 = num16;
			num19 = num18;
			num22 = num21;
			num24 = num23;
			num26 = num25;
			num28 = num27;
			num30 = num29;
			num32 = num31;
			obj15 = obj14;
			num34 = num33;
			object obj37 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v3+6C]");
			num4 = 0.0;
			num = num36;
			array2 = array;
			if (flag12)
			{
				continue;
			}
			goto IL_1bdb;
			IL_03df:
			double num51;
			double num52;
			double num53;
			double num54;
			if (~(strand.snapped ? 1u : 0u) == 0)
			{
				float num50 = (float)num18;
				num51 = 1.0;
				num52 = 0.0;
				num53 = 0.0;
				num54 = 1.0;
				double num55 = 1.0;
			}
			else
			{
				float num56 = size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float num57 = num56 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				float num58 = num57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				float num59 = num58 / 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A920]");
				bool flag13 = num59 < 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A920]");
				num54 = 0.0;
				if (!flag13)
				{
					bool flag14 = !((double)num59 > 1.0);
					num54 = num59;
					if (!flag14)
					{
						num54 = 1.0;
					}
				}
				float num60 = size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9B0]");
				float num61 = num60 * 0f;
				double num62 = (double)size * 0.5;
				double num63 = num40 + (double)num61;
				double num64 = num63 / num62;
				double num65 = ((strand.kind != (Kind)2) ? 1.0 : num54);
				bool flag15 = num64 < 0.0;
				double num41 = 0.0;
				if (!flag15)
				{
					bool flag16 = !(num64 > 1.0);
					num41 = num64;
					if (!flag16)
					{
						num41 = 1.0;
					}
				}
				num14 = num54 * num65;
				if (strand.kind == 0)
				{
					num21 = 0.5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA18]");
					num21 = 0.0;
				}
				float num50 = strand.bead;
				num16 = strand.beadBig;
				double num66 = num21 * num41;
				double num55 = (double)strand.bead * (double)strand.beadBig;
				num51 = num14;
				num52 = num55;
				num53 = num66;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8FA8]");
			object obj38 = 0;
			System.__Canon _Canon = ((List<System.__Canon>)(object)anchors).get_Item((int)strand.onA);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ X8_v96+E4]");
			bool flag17 = (nint)0 == 0;
			object obj41 = !flag17;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num70;
			Vector3 vector;
			if ((UnityEngine.Object)(object)_Canon != null)
			{
				Matrix4x4[] array5 = anchorNow;
				num35 = array5.Length;
				bool flag18 = strand.onA < (object)array5.Length;
				object obj42 = !flag18;
				if (obj42 != null)
				{
					break;
				}
				object obj43 = array5 + strand.onA;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+48]");
				num12 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+20]");
				object obj44 = 0 * obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+30]");
				object obj46 = 0 * obj45;
				Vector3 flatWay = strand.flatWay;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+28]");
				object obj47 = flatWay * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X29_v12 (GillaStrands+Strand)+D0]");
				nint num67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+38]");
				object obj48 = num67 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+40]");
				num14 = 0.0;
				object obj49 = obj44 + obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+40]");
				double num68 = 0.0 * (double)obj50;
				object obj51 = obj47 + obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X29_v12 (GillaStrands+Strand)+D4]");
				double num69 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v241+48]");
				double num41 = num69 * 0.0;
				num21 = (double)obj49 + num68;
				num70 = (double)obj51 + num41;
				vector = (Vector3)num21;
				float num50 = (float)num68;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X29_v12 (GillaStrands+Strand)+D4]");
				num70 = 0.0;
				vector = strand.flatWay;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj52 = 0;
			object obj53 = obj52;
			double num71 = 1.0 - num54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2087 @ X8_v103+A0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2089 @ X8_v104+18]");
			double num72 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2089 @ X8_v104+1C]");
			float num73 = 0f;
			object obj55 = array3 + 36;
			double num74 = num75;
			double num76 = num5;
			double num77 = num70;
			double num78 = num8;
			double num79 = num80;
			obj56 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2089 @ X8_v104+18]");
			double num81 = 0.0;
			double num82 = num12;
			double num83 = num14;
			double num84 = num21;
			object obj57 = obj58;
			Strand strand3 = strand;
			double num85 = 0.0;
			object obj59 = obj16;
			object obj60 = obj17;
			double num86 = num35;
			double num87 = num36;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
				object obj61 = 0;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v66+E4]");
				bool flag19 = (nint)0 == 0;
				object obj63 = !flag19;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj62 = obj61;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v66+A0]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2116 @ X8_v108+50]");
				object obj65 = 0;
				double num88 = num85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
				bool flag20 = num88 < 0.0;
				object obj66 = !flag20;
				if (obj66 != null)
				{
					break;
				}
				double num89 = num85 * (double)obj60;
				double num90 = (double)obj65 + num89;
				double num92;
				double num94;
				if (num85 != 0.0)
				{
					if (num85 == 16.0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v66+E4]");
						bool flag21 = (nint)0 == 0;
						object obj67 = !flag21;
						if (obj67 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
							object obj68 = 0;
							object obj69 = obj68;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2186 @ X8_v236+A0]");
							object obj70 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2187 @ X8_v237+50]");
							obj65 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
						object obj71 = 0 & 0xFFFFFFF0L;
						if (obj71 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+D8]");
						object obj72 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
						double num91 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+D4]");
						num92 = num91 - 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
						double num93 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+D8]");
						num94 = num93 - 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
						double num95 = 0.0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v66+E4]");
						bool flag22 = (nint)0 == 0;
						object obj73 = !flag22;
						if (obj73 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
							object obj74 = 0;
							object obj75 = obj74;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2197 @ X8_v230+A0]");
							object obj76 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v231+50]");
							obj65 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
						num86 = 0.0;
						double num96 = num85 + 1.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
						bool flag23 = num96 < 0.0;
						object obj77 = !flag23;
						if (obj77 != null)
						{
							break;
						}
						array2 = (Strand[])(num85 - 1);
						Strand[] array6 = array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
						bool flag24 = (nint)array6 < 0;
						object obj78 = !flag24;
						if (obj78 != null)
						{
							break;
						}
						object obj79 = obj65 + 32;
						double num97 = num96 * (double)obj60;
						double num98 = (double)obj79 + num97;
						object obj80 = (object)array2 * obj60;
						object obj81 = obj79 + obj80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2227 @ X9_v105 (System.Double)+4]");
						object obj72 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2232 @ X8_v227+4]");
						double num95 = 0.0;
						num92 = ((double*)(nint)num98)->m_value - (double)obj81;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2227 @ X9_v105 (System.Double)+4]");
						double num99 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2232 @ X8_v227+4]");
						num94 = num99 - 0.0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X0_v66+E4]");
					bool flag25 = (nint)0 == 0;
					object obj82 = !flag25;
					if (obj82 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
						object obj83 = 0;
						object obj84 = obj83;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ X8_v222+A0]");
						object obj85 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2175 @ X8_v223+50]");
						obj65 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+18]");
					object obj86 = 0 & 0xFFFFFFFEL;
					if (obj86 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+30]");
					object obj72 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+2C]");
					double num100 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
					num92 = num100 - 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v225+30]");
					double num101 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
					num94 = num101 - 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
					double num95 = 0.0;
				}
				double num102 = num92 * num92;
				double num103 = num94 * num94;
				double num104 = num102 + num103;
				double num105 = num104 + (double)obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
				double num106 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
				bool flag26 = !(num105 > 0.0);
				double num107 = num73;
				if (!flag26)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj87 = 0;
					object obj88 = obj87;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2361 @ X0_v126+E4]");
					bool flag27 = (nint)0 == 0;
					object obj89 = !flag27;
					if (obj89 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num108 = num106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if (num108 > 0.0)
					{
						double num109 = num92 / num106;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						num107 = num94 / num106;
						num81 = num109;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj90 = 0;
						object obj91 = obj90;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X8_v215+A0]");
						object obj92 = 0;
						num106 = (double)obj92;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2293 @ X8_v216+4]");
						num107 = 0.0;
						num81 = (double)obj92;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num110 = num77 * (double)obj93;
				double num111 = (double)vector * num106;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num112 = num110 + num111;
				double num113 = num106 * (double)obj45;
				double num114 = num112 * (double)obj93;
				double num115 = (double)vector - num113;
				double num116 = num77 - num114;
				double num117 = num115 * num115;
				double num118 = num116 * num116;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num119 = num118 + num117;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				double num122;
				Vector3 vector4;
				if (num119 > 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj94 = 0;
					object obj95 = obj94;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2859 @ X0_v70+E4]");
					bool flag28 = (nint)0 == 0;
					object obj96 = !flag28;
					if (obj96 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num120 = num106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					bool flag29 = !(num120 > 0.0);
					double num121 = num107;
					Vector3 vector2 = vector;
					if (flag29)
					{
						goto IL_10cc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num122 = num116 / num106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					Vector3 vector3 = (Vector3)(num115 / 0);
					vector4 = vector3;
					num121 = num107;
					vector2 = vector;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					double num123 = num106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					object obj99;
					object obj100;
					if (num123 > 0.0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj97 = 0;
						object obj98 = obj97;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2412 @ X8_v188+A0]");
						obj99 = (nint)0 + (nint)60;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2412 @ X8_v188+A0]");
						obj100 = (nint)0 + (nint)64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2412 @ X8_v188+A0]");
						num86 = 0.0 + 68.0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj101 = 0;
						object obj102 = obj101;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X8_v180+A0]");
						obj99 = (nint)0 + (nint)24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X8_v180+A0]");
						obj100 = (nint)0 + (nint)28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X8_v180+A0]");
						num86 = 0.0 + 32.0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99E]");
					array2 = (Strand[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj103 = 0;
					object obj95 = obj103;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2859 @ X0_v70+E4]");
					bool flag30 = (nint)0 == 0;
					object obj104 = !flag30;
					if (obj104 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num124 = num107 * ((double*)(nint)num86)->m_value;
					double num125 = num43 * (double)obj100;
					double num126 = num107 * (double)obj99;
					double num127 = num124 - num125;
					double num128 = num81 * (double)obj100;
					double num129 = num128 - num126;
					double num130 = num127 * num127;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num131 = num129 * num129;
					double num132 = num131 + num130;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					Vector3 vector2 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					bool flag31 = !(num132 > 0.0);
					obj56 = obj105;
					double num121 = (double)obj100;
					if (flag31)
					{
						goto IL_10cc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					Vector3 vector5 = (Vector3)(num127 / 0);
					num122 = num129 / num132;
					obj56 = obj105;
					vector4 = vector5;
					num121 = (double)obj100;
				}
				goto IL_2998;
				IL_10cc:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj106 = 0;
				object obj107 = obj106;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2516 @ X8_v162+A0]");
				object obj108 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2517 @ X8_v163+8]");
				num122 = 0.0;
				vector4 = (Vector3)obj108;
				goto IL_2998;
				IL_2998:
				double num133 = num85 + num85;
				double num134 = num133 + -1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				double num135 = num134 * num134;
				double num136 = num135 * -1.0;
				int num141;
				float phase;
				double num165;
				double num166;
				if (~(strand3.snapped ? 1u : 0u) == 0)
				{
					int num137 = strand3.cut << 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
					double num138 = num85 - (double)num137;
					bool flag32 = num138 == 0.0;
					object obj109 = !flag32;
					object obj110 = ~obj109;
					bool flag33;
					if (obj110 == null)
					{
						double num139 = num85 - 1.0;
						flag33 = num139 == 0.0;
					}
					else
					{
						flag33 = true;
					}
					double num140;
					if (num85 < (double)num137)
					{
						num140 = (double)num137 - num85;
						num141 = num137;
					}
					else
					{
						num141 = 16 - 1;
						num140 = num85 - 1.0;
						object obj111 = num141 - 1;
						bool flag34 = (nint)obj111 < 0;
						bool flag35 = obj111 == null;
						int num142 = num141 ^ 1;
						int num143 = num141 ^ obj111;
						int num144 = num142 & num143;
						bool flag36 = num144 < 0;
						bool flag37 = flag34 == flag36;
						object obj112 = !flag35;
						object obj113 = flag37 & obj112;
						object obj114 = ~obj113;
						if (obj114 != null)
						{
							num141 = 1;
						}
					}
					int num145 = (int)(num140 / num141);
					double num146 = (double)num145 * (double)num145;
					double num147 = num146 - 1.0;
					bool flag38 = num147 < 0.0;
					bool flag39 = num147 == 0.0;
					object obj115 = num146 ^ 1.0;
					object obj116 = num146 ^ num147;
					object obj117 = obj115 & obj116;
					bool flag40 = (nint)obj117 < 0;
					bool flag41 = flag38 == flag40;
					object obj118 = !flag39;
					object obj119 = flag41 & obj118;
					object obj120 = ~obj119;
					if (obj120 == null)
					{
						num146 = 1.0;
					}
					double num148 = num146;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A898]");
					double num149 = num148 * 0.0;
					double num150 = num149;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADDC]");
					double num151 = num150 + 0.0;
					num86 = (double)num137 + 2.0;
					object obj121 = num137 - 1;
					double num152 = num85 - num86;
					bool flag42 = num152 == 0.0;
					object obj122 = !flag42;
					object obj123 = ~obj122;
					bool flag43;
					if (obj123 == null)
					{
						double num153 = num85 - (double)obj121;
						flag43 = num153 == 0.0;
					}
					else
					{
						flag43 = true;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					object obj124 = !flag43;
					if (obj124 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						num151 = 0.0;
					}
					bool flag44 = !flag33;
					object obj125 = !flag44;
					double num154 = 0.0;
					if (obj125 == null)
					{
						num154 = 1.0 - (double)strand3.gone;
					}
					bool flag45 = num145 < 0;
					double num155 = 0.0;
					if (!flag45)
					{
						bool flag46 = !((double)num145 > 1.0);
						num155 = num145;
						if (!flag46)
						{
							num155 = 1.0;
						}
					}
					phase = strand3.phase;
					double num156 = num155;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					double num157 = num156 * 0.0;
					double num158 = num157;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					double num159 = num158 + 0.0;
					double num160 = strand3.wide;
					float deep = strand3.deep;
					double num161 = (double)strand3.wide * num159;
					double num162 = num151 * num161;
					double num163 = num151 * (double)strand3.deep;
					num33 = num154 * num162;
					double num164 = num154 * num163;
					num165 = ((!(num33 < num164)) ? num164 : num33);
					num166 = 1.0 - num136;
					num75 = num74;
					num8 = num78;
					num80 = num79;
					double num167 = num77;
				}
				else
				{
					phase = strand3.phase;
					float num168 = (float)num85 * strand3.waves;
					float num169 = num168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A84C]");
					float num170 = num169 * 0f;
					float num171 = age;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
					float num172 = num171 * 0f;
					float num173 = strand3.phase + num170;
					float num174 = num173 + num172;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					float num175 = (float)num85 - strand3.beadAt;
					float num176 = num175 * num175;
					float num177 = num176;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC58]");
					float num178 = num177 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
					object obj126 = strand3.kind - 2;
					bool flag47 = obj126 == null;
					bool flag48 = num136 < 0.0;
					double num179 = 0.0;
					if (!flag48)
					{
						bool flag49 = !(num136 > 1.0);
						num179 = num136;
						if (!flag49)
						{
							num179 = 1.0;
						}
					}
					bool flag50 = num136 < 0.0;
					float deep = strand3.deep;
					double num180 = 0.0;
					if (!flag50)
					{
						bool flag51 = !(num136 > 1.0);
						num180 = num136;
						if (!flag51)
						{
							num180 = 1.0;
						}
					}
					object obj127 = 17285120 + 832;
					num166 = 1.0 - num136;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2799 @ X9_v80+v2669 @ Z_v73 (System.Boolean)*4]");
					num82 = 0.0 - num51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2799 @ X9_v80+v2669 @ Z_v73 (System.Boolean)*4]");
					double num181 = 0.0 - num54;
					num8 = num53 * (double)num174;
					double num182 = num82 * num179;
					double num183 = num181 * num180;
					double num184 = num166 * num8;
					double num185 = num51 + num182;
					double num186 = num54 + num183;
					double num167 = num184 + 1.0;
					double num187 = (double)strand3.wide * num185;
					double num188 = (double)deep * num186;
					double num189 = num52 * (double)num178;
					double num154 = num167 * num187;
					double num163 = num167 * num188;
					num33 = num189 + num154;
					num165 = num189 + num163;
					num75 = num51;
					num80 = 1.0;
					double num160 = num52;
					num141 = (int)array2;
				}
				double num190 = num85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				double num191 = num190 * 0.0;
				float num192 = (float)num191 + phase;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				num27 = num71 * num166;
				double num193 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
				double num194 = num193 * 0.0;
				double num195 = num194;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
				double num196 = num195 + 0.0;
				float num197 = strand3.tone;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B000]");
				float num198 = num197 * 0f;
				float num199 = num192;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				float num200 = num199 * 0f;
				num47 = num196 + (double)num198;
				double num201 = num47 + (double)num200;
				bool flag52 = num201 < 0.0;
				num29 = 0.0;
				if (!flag52)
				{
					bool flag53 = !(num201 > 1.0);
					num29 = num201;
					num47 = 1.0;
					if (!flag53)
					{
						num29 = 1.0;
						num47 = 1.0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
				obj14 = 0;
				gillaStrands = (GillaStrands)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3048 @ X0_v76 (GillaStrands)+E4]");
				bool flag54 = (nint)0 == 0;
				object obj128 = !flag54;
				if (obj128 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					gillaStrands = (GillaStrands)obj14;
				}
				float[] array7 = gillaStrands.dropFloor;
				bool flag55 = num29 < 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+8]");
				flag2 = false;
				num72 = 0.0;
				if (!flag55)
				{
					bool flag56 = !(num29 > 1.0);
					num72 = num29;
					if (!flag56)
					{
						num72 = 1.0;
					}
				}
				bool flag57 = strand.sides < 1;
				num6 = num85;
				array2 = (Strand[])num141;
				double num205;
				double num210;
				object obj144;
				if (!flag57)
				{
					object obj129 = (flag2 ? 1 : 0) >> 8;
					object obj130 = obj129 & 0xFF;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+4]");
					object obj131 = (nint)0 >> 8;
					object obj132 = obj131 & 0xFFFFFF;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+4]");
					object obj133 = (nint)0 >> 16;
					obj57 = obj133 & 0xFFFF;
					object obj134 = (flag2 ? 1 : 0) & 0xFF;
					object obj135 = obj130 - obj132;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+4]");
					object obj136 = obj134 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+4]");
					object obj137 = (nint)0 >> 8;
					object obj138 = obj137 & 0xFF;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2965 @ X9_v62 (System.Single[])+4]");
					object obj139 = (nint)0 & (nint)0xFF;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					double num202 = num72 * (double)obj135;
					double num203 = num72 * (double)obj136;
					double num204 = num202 + (double)obj138;
					num205 = num203 + (double)obj139;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					double num206 = num43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
					double num207 = num206 * 0.0;
					double num208 = num107 * (double)obj138;
					double num209 = num107 * (double)vector4;
					num210 = num27 * 1132396544.0;
					double num211 = num81 * (double)obj140;
					object obj141 = num204 & 0xFF;
					object obj142 = obj141 << 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
					num27 = num207 - num208;
					num43 = num209 - num211;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
					obj14 = obj142 | num210;
					object obj143 = obj55;
					obj144 = 0;
					while (true)
					{
						bool flag58 = (nint)obj144 < array3.Length;
						object obj145 = !flag58;
						if (obj145 != null)
						{
							break;
						}
						Vertex[] array8 = verts;
						num39 = (double)num38 + (double)obj144;
						bool flag59 = num39 < (double)array8.Length;
						object obj146 = !flag59;
						if (obj146 != null)
						{
							break;
						}
						object obj147 = array8 + 32;
						double num212 = num39 * 36.0;
						double num213 = (double)obj147 + num212;
						double num214 = num165;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X29_v17-4]");
						double num215 = num214 * 0.0;
						double num216 = num33 * (double)obj143;
						double num217 = num33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X29_v17-4]");
						double num218 = num217 * 0.0;
						double num219 = num165 * (double)obj143;
						double num220 = (double)vector4 * (double)obj105;
						double num221 = num27 * (double)obj148;
						double num222 = num122 * num215;
						double num223 = num43 * num216;
						num29 = num220 + num221;
						num6 = num222 + num223;
						double num224 = (double)vector4 * (double)obj45;
						double num225 = num122 * num218;
						double num226 = num29 * num29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
						double num227 = 0.0 + num224;
						double num228 = num27 * (double)obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
						double num229 = 0.0 + num225;
						double num230 = num43 * num219;
						double num231 = num6 * num6;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						double num232 = num229 + num230;
						num166 = num231 + num226;
						double value3 = num227 + num228;
						((double*)(nint)num213)->m_value = value3;
						double num233 = num166;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
						bool flag60 = !(num233 > 0.0);
						num47 = (double)vector4;
						num72 = num122;
						flag2 = false;
						if (!flag60)
						{
							flag2 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj149 = 0;
							gillaStrands = (GillaStrands)obj149;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3048 @ X0_v76 (GillaStrands)+E4]");
							bool flag61 = (nint)0 == 0;
							object obj150 = !flag61;
							if (obj150 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							double num234 = num122;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							if (num234 > 0.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								num72 = num6 / num122;
								double num235 = num29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num47 = num235 / 0.0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj151 = 0;
								object obj152 = obj151;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3288 @ X8_v146+A0]");
								object obj153 = 0;
								num47 = (double)obj153;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3253 @ X8_v147+8]");
								num72 = 0.0;
							}
						}
						obj144++;
						obj143 += 8;
						double num236 = num39 * 36.0;
						double num237 = (double)obj147 + num236;
						if (strand.sides != (nint)obj144)
						{
							continue;
						}
						goto IL_1a6c;
					}
					break;
				}
				goto IL_3a7a;
				IL_1a6c:
				num38 += obj144;
				num8 = (double)vector4;
				num80 = num122;
				array2 = (Strand[])num210;
				strand3 = strand;
				obj59 = 17276928;
				obj60 = 12;
				num86 = num205;
				goto IL_3a7a;
				IL_3a7a:
				num37 = num85 + 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				double num238 = num76;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
				if (num238 < 0.0)
				{
					num18 = num76;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
					num18 = 0.0;
				}
				double num239 = num87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
				double num240 = num239 - 0.0;
				bool flag62 = num240 < 0.0;
				bool flag63 = num240 == 0.0;
				double num241 = num87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
				object obj154 = num241 ^ 0;
				object obj155 = num87 ^ num240;
				object obj156 = obj154 & obj155;
				bool flag64 = (nint)obj156 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
				bool flag65 = flag62 == flag64;
				obj8 = !flag63;
				object obj157 = flag65 & obj8;
				obj10 = ~obj157;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
					num87 = 0.0;
				}
				bool flag66 = num37 != 17.0;
				num5 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
				num10 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
				num12 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
				num14 = 0.0;
				num16 = (float)num107;
				obj12 = 0;
				num20 = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+60]");
				num21 = 0.0;
				obj58 = obj57;
				num23 = num54;
				num25 = num43;
				num31 = num39;
				strand2 = strand3;
				obj16 = obj59;
				obj17 = obj60;
				num35 = num86;
				num36 = num87;
				num74 = num75;
				num76 = num18;
				num77 = num122;
				num78 = num8;
				num79 = num80;
				vector = vector4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+28]");
				num82 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X9_v56 (System.Double)+20]");
				num83 = 0.0;
				num73 = (float)num107;
				float num50 = (float)num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+60]");
				num84 = 0.0;
				double num41 = num47;
				num85 = num37;
				if (flag66)
				{
					continue;
				}
				goto IL_1af4;
			}
			break;
			IL_05f2:
			obj58 = 4294967296L;
			strand2 = strand;
			goto IL_1af4;
		}
		goto IL_25f7;
		IL_2605:
		throw new NullReferenceException();
		IL_1bdb:
		object obj158 = 0;
		double num242 = 17276928.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		double num243 = 0.0;
		object obj237 = default;
		Bounds bounds = default;
		object obj238 = default;
		while (true)
		{
			float[] array9 = dropLife;
			bool flag67 = (nint)obj158 < array9.Length;
			object obj159 = !flag67;
			if (obj159 != null)
			{
				break;
			}
			object obj160 = (object)array9 + obj158;
			bool[] array10 = dropShown;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			object obj161 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			if ((nint)0 > (nint)0)
			{
				bool flag68 = array10 == null;
				object obj162 = !flag68;
				if (obj162 == null)
				{
					goto IL_2605;
				}
			}
			else
			{
				bool flag69 = (nint)obj158 < array10.Length;
				object obj163 = !flag69;
				if (obj163 != null)
				{
					break;
				}
				object obj164 = (object)array10 + obj158;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1542 @ X9_v34+20]");
				if ((nint)0 == 0)
				{
					goto IL_327d;
				}
			}
			bool flag70 = (nint)obj158 < array10.Length;
			object obj165 = !flag70;
			if (obj165 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			bool flag71 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			bool flag72 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			nint num244 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			object obj166 = num244 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			object obj167 = 0 & obj166;
			bool flag73 = (nint)obj167 < 0;
			object obj168 = obj161;
			object obj169 = (object)array10 + obj158;
			bool flag74 = flag71 == flag73;
			obj9 = !flag72;
			object obj170 = flag74 & obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v19+E4]");
			bool flag75 = (nint)0 == 0;
			object obj171 = !flag75;
			if (obj171 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj168 = obj161;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v19+A0]");
			object obj172 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1550 @ X8_v32+60]");
			object obj173 = 0;
			Vector3[] array11 = dropAt;
			bool flag76 = (nint)obj158 < array11.Length;
			object obj174 = !flag76;
			if (obj174 != null)
			{
				break;
			}
			Vector3[] array12 = dropGoing;
			bool flag77 = (nint)obj158 < array12.Length;
			object obj175 = !flag77;
			if (obj175 != null)
			{
				break;
			}
			object obj176 = obj158 * 12;
			object obj177 = (object)array11 + obj176;
			object obj178 = obj158 * 12;
			object obj179 = (object)array12 + obj178;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ X9_v15+20]");
			num24 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ X9_v15+28]");
			num28 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v10+28]");
			num30 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj180 = 0;
			object obj181 = obj180;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1879 @ X0_v24+E4]");
			bool flag78 = (nint)0 == 0;
			object obj182 = !flag78;
			if (obj182 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			bool flag79 = (nint)0 <= (nint)0;
			num11 = 0.0;
			if (!flag79)
			{
				float[] array13 = dropSize;
				bool flag80 = (nint)obj158 < array13.Length;
				object obj183 = !flag80;
				if (obj183 != null)
				{
					break;
				}
				float[] array14 = dropLife;
				bool flag81 = (nint)obj158 < array14.Length;
				object obj184 = !flag81;
				if (obj184 != null)
				{
					break;
				}
				object obj185 = (object)array14 + obj158;
				object obj186 = (object)array13 + obj158;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X9_v31+20]");
				double num245 = 0.0 * 3.0;
				double num246 = num245 - 1.0;
				bool flag82 = num246 < 0.0;
				bool flag83 = num246 == 0.0;
				object obj187 = num245 ^ 1.0;
				object obj188 = num245 ^ num246;
				object obj189 = obj187 & obj188;
				bool flag84 = (nint)obj189 < 0;
				bool flag85 = flag82 == flag84;
				obj9 = !flag83;
				object obj190 = flag85 & obj9;
				obj11 = ~obj190;
				if (obj11 == null)
				{
					num245 = 1.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X8_v70+20]");
				double num247 = 0.0 * num245;
				num11 = num247;
			}
			double num248 = num30 * num30;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (num248 > 0.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v10+20]");
				double num249 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num26 = num249 / 0.0;
				num34 = num30 / num248;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj191 = 0;
				object obj192 = obj191;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1858 @ X8_v66+A0]");
				object obj193 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v67+24]");
				num26 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v67+2C]");
				num34 = 0.0;
			}
			num32 = (double)obj161;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X22_v5 (System.Double)+E4]");
			bool flag86 = (nint)0 == 0;
			object obj194 = !flag86;
			if (obj194 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num32 = (double)obj161;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X22_v5 (System.Double)+A0]");
			object obj195 = 0;
			double num250 = (double)obj158;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA1C]");
			double num251 = num250 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0F0");
			bool flag87 = num251 < 0.0;
			double num252 = 0.0;
			if (!flag87)
			{
				bool flag88 = !(num251 > 1.0);
				num252 = num251;
				if (!flag88)
				{
					num252 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+8]");
			object obj196 = (nint)0 & (nint)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+8]");
			object obj197 = (nint)0 >> 8;
			object obj198 = obj197 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			object obj199 = (nint)0 >> 8;
			object obj200 = obj199 & 0xFFFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			object obj201 = obj196 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			object obj202 = (nint)0 >> 16;
			array = (Strand[])(obj202 & 0xFFFF);
			object obj203 = obj198 - obj200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+8]");
			object obj204 = (nint)0 >> 16;
			object obj205 = obj204 & 0xFF;
			object obj206 = obj158;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v33+18]");
			object obj207 = obj206 * 0;
			object obj37 = dropFirst + obj207;
			object obj208 = obj205 - (object)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			float num253 = (nint)0 & (nint)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			object obj209 = (nint)0 >> 8;
			double num254 = obj209 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v43+4]");
			object obj210 = (nint)0 >> 16;
			object obj211 = obj210 & 0xFF;
			double num255 = num252 * (double)obj201;
			double num256 = num252 * (double)obj203;
			double num257 = num252 * (double)obj208;
			double num258 = num255 + (double)num253;
			num22 = num256 + num254;
			double num259 = num257 + (double)obj211;
			double num260 = num248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			num243 = num260 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			double num37 = 0.0;
			obj15 = num258 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			num19 = num248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			double num47 = 0.0;
			Strand strand2 = null;
			num242 = num259;
			object obj212 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X22_v5 (System.Double)+E4]");
				bool flag89 = (nint)0 == 0;
				object obj213 = !flag89;
				if (obj213 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num32 = ((double*)(nint)num37)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X22_v5 (System.Double)+A0]");
				object obj214 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v52+60]");
				object obj215 = 0;
				Strand strand4 = strand2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X9_v25+18]");
				if ((nint)strand4 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X22_v5 (System.Double)+E4]");
				bool flag90 = (nint)0 == 0;
				object obj216 = !flag90;
				if (obj216 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					double value4 = ((double*)(nint)num37)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2132 @ X8_v60 (System.Double)+A0]");
					object obj217 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X8_v61+60]");
					obj215 = 0;
				}
				Strand strand5 = strand2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X9_v25+18]");
				bool flag91 = (nint)strand5 < 0;
				object obj218 = !flag91;
				if (obj218 != null)
				{
					goto end_IL_3b7e;
				}
				Vertex[] array15 = verts;
				object obj219 = obj37 + (object)strand2;
				bool flag92 = (nint)obj219 < array15.Length;
				object obj220 = !flag92;
				if (obj220 != null)
				{
					goto end_IL_3b7e;
				}
				object obj221 = obj215 + obj212;
				object obj222 = array15 + 32;
				object obj223 = obj219 * 36;
				object obj224 = obj222 + obj223;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X9_v26+20]");
				object obj225 = 0 * obj105;
				double num261 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2145 @ X9_v26+28]");
				double num262 = num261 * 0.0;
				double num263 = num26 * (double)obj225;
				double num264 = num34 * num262;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num265 = num264 + num263;
				double num266 = num6 * num265;
				num19 = num26 * (double)obj105;
				num22 = num34 * num266;
				double num267 = (double)obj225 + num19;
				double num268 = num262 + num22;
				double num269 = num24 + num267;
				double num270 = num28 + num268;
				obj224 = num269;
				double value5 = ((double*)(nint)num37)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2160 @ X10_v22 (System.Double)+A0]");
				object obj226 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2161 @ X10_v23+60]");
				object obj227 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X10_v24+18]");
				array = (Strand[])0;
				Strand strand6 = strand2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X10_v24+18]");
				bool flag93 = (nint)strand6 < 0;
				object obj228 = !flag93;
				if (obj228 != null)
				{
					goto end_IL_3b7e;
				}
				num242 = (double)obj227 + (double)obj212;
				strand2 = (Strand)(strand2 + 1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v6 (System.Double)+20]");
				num243 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v6 (System.Double)+28]");
				num47 = 0.0;
				obj212 += 12;
				object obj229 = obj219 * 36;
				object obj230 = obj222 + obj229;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v6 (System.Double)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v6 (System.Double)+28]");
				_ = 0;
				num32 = ((double*)(nint)num37)->m_value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X8_v21+20]");
			bool flag94 = (nint)0 <= (nint)0;
			num15 = num254;
			num17 = num253;
			if (!flag94)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				num19 = ((!(num3 < num28)) ? num28 : num3);
				double num271 = num - num28;
				bool flag95 = num271 < 0.0;
				bool flag96 = num271 == 0.0;
				object obj231 = num ^ num28;
				object obj232 = num ^ num271;
				object obj233 = obj231 & obj232;
				bool flag97 = (nint)obj233 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
				bool flag98 = flag95 == flag97;
				obj9 = !flag96;
				object obj234 = flag98 & obj9;
				obj11 = ~obj234;
				if (obj11 != null)
				{
					num = num28;
				}
				num3 = num19;
				num15 = num254;
				num17 = (float)num4;
				num22 = num2;
			}
			goto IL_327d;
			IL_327d:
			obj158++;
			if ((nint)obj158 == 14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
				object obj235 = num2 & 1;
				if (obj235 != null)
				{
					Transform transform = base.transform;
					Vector3 position = transform.position;
					num4 = num2;
				}
				Vertex[] array16 = verts;
				mesh.SetVertexBufferData(verts, 0, 0, array16.Length, 0, (MeshUpdateFlags)9);
				double num272 = num4 - num2;
				double num273 = num272 * 63.0;
				object obj236 = (object)(&obj237);
				float num274 = size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float amount = num274 * 0f;
				bounds.Expand(amount);
				mesh.bounds = (Bounds)(&obj238);
				return;
			}
			continue;
			end_IL_3b7e:
			break;
		}
		goto IL_25f7;
		IL_25f7:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_2605;
	}

	public GillaStrands()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		object obj6 = this + 48;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj7 = this + 88;
		obj7 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 128;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 136;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 144;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 152;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = this + 160;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = this + 168;
		object obj19 = default;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaStrands()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I
		//IL_0589: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I8
		//IL_035b: Expected Obj, but got I
		//IL_05f9: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I8
		//IL_03c9: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got I
		//IL_0706: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0437: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9148]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9158]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj6 = 0;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v3+A0]");
		object obj8 = 0;
		_ = 460110;
		object obj9 = obj;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v3+A0]");
		object obj10 = 0;
		_ = 1251484;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+A0]");
		object obj12 = (nint)0 + (nint)16;
		obj12 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+A0]");
		object obj14 = (nint)0 + (nint)32;
		obj14 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9+A0]");
		object obj16 = (nint)0 + (nint)40;
		obj16 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list2 = default;
		list2._002Ector();
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10+A0]");
		object obj18 = (nint)0 + (nint)48;
		obj18 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list3 = default;
		list3._002Ector();
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v11+A0]");
		object obj20 = (nint)0 + (nint)56;
		obj20 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector2> list4 = default;
		list4._002Ector();
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v16+A0]");
		object obj23 = (nint)0 + (nint)64;
		obj23 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list5 = default;
		list5._002Ector();
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v21+A0]");
		object obj26 = (nint)0 + (nint)72;
		obj26 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v22+A0]");
		object obj28 = (nint)0 + (nint)80;
		object obj29 = default;
		obj28 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v25+A0]");
		object obj31 = (nint)0 + (nint)88;
		object obj32 = default;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj33 = 0;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X9_v7+A0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v8+3C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X9_v8+44]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
			object obj36 = 0 & 0xFFFFFFFEL;
			if (obj36 != null)
			{
				object obj37 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X9_v10+A0]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v11+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X9_v11+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
				bool flag = (nint)0 < (nint)2;
				object obj39 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
				object obj40 = -2;
				bool flag2 = obj40 == null;
				object obj41 = ~obj39;
				object obj42 = obj41 | flag2;
				if (obj42 == null)
				{
					object obj43 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X9_v13+A0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X9_v14+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X9_v14+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
					object obj45 = 0 & 0xFFFFFFFCL;
					if (obj45 != null)
					{
						object obj46 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X9_v16+A0]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X9_v17+24]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X9_v17+2C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
						bool flag3 = (nint)0 < (nint)4;
						object obj48 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
						object obj49 = -4;
						bool flag4 = obj49 == null;
						object obj50 = ~obj48;
						object obj51 = obj50 | flag4;
						if (obj51 == null)
						{
							object obj52 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X9_v19+A0]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v20+48]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v20+50]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
							bool flag5 = (nint)0 < (nint)5;
							object obj54 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v46+18]");
							object obj55 = -5;
							bool flag6 = obj55 == null;
							object obj56 = ~obj54;
							object obj57 = obj56 | flag6;
							if (obj57 == null)
							{
								object obj58 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v38+A0]");
								object obj59 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v39+54]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v39+5C]");
								_ = 0;
								object obj60 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
								object obj61 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9168]");
								object obj62 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v40+A0]");
								object obj63 = (nint)0 + (nint)96;
								object obj64 = default;
								obj63 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj66 = default;
								object obj65 = obj66 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								object obj67 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v41+A0]");
								object obj68 = (nint)0 + (nint)104;
								obj68 = obj66;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static long _003CPlaces_003Eg__Key_007C59_0(int v0, int v1)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_00b1: Expected I8, but got I4
		//IL_00a4: Expected I8, but got I4
		object obj = v0 - v1;
		bool flag = (nint)obj < 0;
		int num = v0 ^ v1;
		int num2 = v0 ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		int num4 = v1 | v0;
		int num5 = v0 | v1;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			return num4;
		}
		return num5;
	}
}
