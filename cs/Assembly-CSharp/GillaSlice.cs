using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering;

public static class GillaSlice
{
	private class Points
	{
		public int count;

		public int[] bone;

		public float[] weight;

		public Vector3[] at;

		public Vector3[] way;

		public Vector3[][] shape;
	}

	private class Source
	{
		public string name;

		public Vector3[] at;

		public Vector3[] normals;

		public Vector4[] tangents;

		public Color[] colors;

		public readonly List<Vector4>[] uvs;

		public int[][] tris;

		public Material[] materials;

		public bool shadows;

		public bool cut;

		public bool plus;

		public Bounds bounds;

		public Source()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76F0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 56;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private class Side
	{
		public readonly List<Vector3> at;

		public readonly List<Vector3> normals;

		public readonly List<Vector4> tangents;

		public readonly List<Color> colors;

		public readonly List<Vector4>[] uvs;

		public List<int>[] tris;

		public readonly Dictionary<int, int> from;

		public readonly Dictionary<long, int> onEdge;

		public int Count
		{
			get
			{
				//IL_010a: Expected I4, but got Obj
				//IL_002f: Expected Obj, but got I4
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Expected Obj, but got Unknown
				//IL_0047: Expected Obj, but got I4
				//IL_0074: Expected Obj, but got I
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Expected Obj, but got Unknown
				List<int>[] array = tris;
				if (tris == null)
				{
					goto IL_00ee;
				}
				int num;
				if (array.Length >= 1)
				{
					object obj = ~array.Length;
					object obj2 = array.Length & obj;
					object obj3 = 0;
					num = 0;
					while (array.Length != (nint)obj3)
					{
						object obj4 = (object)tris + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X12_v5+20]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X12_v5+20]");
						if ((nint)0 == 0)
						{
							goto IL_00ee;
						}
						obj3++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X12_v6+18]");
						num = (int)((nint)0 + (nint)num);
						if (obj2 != obj3)
						{
							continue;
						}
						goto IL_0151;
					}
					goto IL_00fc;
				}
				num = 0;
				goto IL_0151;
				IL_00fc:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (int)ex;
				IL_00ee:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_00fc;
				IL_0151:
				return num;
			}
		}

		public Side()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I
			//IL_0053: Expected Obj, but got I
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected Obj, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected Obj, but got Unknown
			//IL_0173: Expected Obj, but got I
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7708]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76F0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6070]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list = default;
			list._002Ector();
			object obj6 = this + 16;
			obj6 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list2 = default;
			list2._002Ector();
			object obj7 = this + 24;
			obj7 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector4> list3 = default;
			list3._002Ector();
			object obj8 = this + 32;
			obj8 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Color> list4 = default;
			list4._002Ector();
			object obj9 = this + 40;
			obj9 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj10 = this + 48;
			object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<int, int> dictionary = default;
			dictionary._002Ector();
			object obj12 = this + 64;
			obj12 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6998]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<long, int> dictionary2 = default;
			dictionary2._002Ector();
			object obj14 = this + 72;
			obj14 = dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public const int MostDepth = default(int);

	public const float LeastSize = default(float);

	public const float Reach = default(float);

	public const float Settle = default(float);

	private const int LeastTriangles = default(int);

	public static string LastRefused;

	public const int MostPieces = default(int);

	private const float EachSide = default(float);

	private const int Samples = default(int);

	private const float SweepStep = default(float);

	private const int MostSweeps = default(int);

	private const float MostJoin = default(float);

	private const float MostAcross = default(float);

	private const float LipSoak = default(float);

	private static readonly string[] Frames;

	private static int Made__BackingField;

	public static float LastOpen;

	public static float WorstOpen;

	private static int countedAt;

	private static int counted;

	public static int Made
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public unsafe static int SlicesOut
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_045b: Expected Obj, but got I4
			//IL_05c5: Expected Obj, but got I
			//IL_02f7: Expected Obj, but got I4
			//IL_0534: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got I4
			//IL_0479: Expected Obj, but got I
			//IL_04ae: Expected Obj, but got I4
			//IL_0602: Expected Obj, but got I
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got I
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected Obj, but got I4
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_057c: Expected Obj, but got I
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Expected Ref, but got Unknown
			//IL_05a7: Expected Obj, but got I4
			//IL_0128: Expected Obj, but got I4
			//IL_016b: Expected Obj, but got I4
			//IL_026a: Expected Obj, but got I4
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Expected Obj, but got Unknown
			//IL_032e: Expected Obj, but got I4
			//IL_033c: Expected Obj, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected Obj, but got I4
			//IL_03c8: Expected Obj, but got I4
			//IL_02b7: Expected Obj, but got I4
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Expected I4, but got Unknown
			//IL_0427: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got I4
			//IL_04f6: Expected Obj, but got I
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
			object obj4 = 0;
			int frameCount = Time.frameCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+1C]");
			Enumerator<, > val2;
			Enumerator<, > val3 = default;
			int result2;
			object obj18;
			UnityEngine.Object obj12;
			object obj22;
			Enumerator<, > val4;
			Enumerator<, > val5;
			UnityEngine.Object obj26;
			if ((nint)0 != frameCount)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
				object obj5 = 0;
				int frameCount2 = Time.frameCount;
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v10+E4]");
				Enumerator<, > val = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v10+A0]");
				object obj8 = 0;
				object obj9 = obj5;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v17+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v13+8]");
				bool flag4 = (nint)0 == 0;
				UnityEngine.Object obj13 = default;
				obj12 = obj13;
				val2 = (Enumerator<, >)0;
				if (flag4)
				{
					goto IL_035e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v13+8]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74C0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj15 = 0;
				val = (Enumerator<, >)(ref val2);
				while (val2.MoveNext())
				{
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v44+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj13 != null;
					bool flag7 = !flag6;
					obj18 = 0;
					if (flag7)
					{
						continue;
					}
					if ((object)obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ stack_-58 (UnityEngine.Object)+28]");
						bool flag8 = (nint)0 < (nint)2;
						obj18 = 0;
						if (!flag8)
						{
							object obj19 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v50+E4]");
							bool flag9 = (nint)0 == 0;
							object obj20 = !flag9;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj19 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v50+A0]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v31+20]");
							val = (Enumerator<, >)((nint)0 + (nint)1);
							obj18 = 0;
						}
						continue;
					}
					goto IL_031c;
				}
				obj12 = null;
				obj22 = 0;
				val2 = val3;
				val4 = val3;
				val5 = (Enumerator<, >)(ref val2);
				object obj23 = 5;
				object obj24 = 0;
				int result = default;
				object obj29 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74B8]");
					object obj25 = 0;
					obj26 = (UnityEngine.Object)obj25;
					((Enumerator<, >*)val5)->Dispose();
					bool flag10 = obj24 == null;
					object obj27 = !flag10;
					if (obj27 == null)
					{
						bool flag11 = (object)obj12 == null;
						object obj28 = !flag11;
						OutOfMemoryException ex = (OutOfMemoryException)val5;
						if (obj28 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj26 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj12 = (UnityEngine.Object)1;
						obj24 = obj22;
					}
					else
					{
						if ((nint)obj26 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E134");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj24 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj22 = obj29;
					}
					obj23 = 0;
				}
				if ((nint)obj23 != 5)
				{
					bool flag12 = obj23 == null;
					object obj30 = !flag12;
					result2 = (int)val5;
					if (obj30 != null)
					{
						goto IL_051f;
					}
				}
			}
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9+E4]");
			bool flag13 = (nint)0 == 0;
			object obj32 = !flag13;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v9+A0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v8+20]");
			result2 = 0;
			goto IL_051f;
			IL_031c:
			NullReferenceException ex2 = new NullReferenceException();
			obj18 = 0;
			obj12 = null;
			obj22 = 0;
			val2 = val3;
			val4 = val3;
			val5 = (Enumerator<, >)(ref val2);
			obj26 = null;
			goto IL_035e;
			IL_051f:
			return result2;
			IL_035e:
			throw new NullReferenceException();
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
		object obj6 = 0;
		_ = 0;
		_ = 0;
	}

	public static void Name(GameObject piece, PieceKey key, GillaCorpse body = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
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
		bool flag2 = piece == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = key & 0xFF;
		object obj6 = obj5 - 1;
		bool flag4 = (nint)obj6 < 3;
		object obj7 = !flag4;
		object obj8 = obj6 - 3;
		bool flag5 = obj8 == null;
		object obj9 = !flag5;
		object obj10 = obj7 & obj9;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = body - 1;
		bool flag6 = (nint)obj11 < 62;
		object obj12 = !flag6;
		object obj13 = obj11 - 62;
		bool flag7 = obj13 == null;
		object obj14 = !flag7;
		object obj15 = obj12 & obj14;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74B0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj18 = default;
			object obj17 = obj18 & 1;
			GillaPieceId gillaPieceId = default;
			if (obj17 != null)
			{
				GillaPieceId gillaPieceId2 = default;
				gillaPieceId = gillaPieceId2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74A8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
			GillaCorpse of = (GillaCorpse)(body & 0xFFFFFFFFL);
			gillaPieceId.Set(key, of);
		}
	}

	public unsafe static GillaPieceId Find(PieceKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		if (obj4 != null)
		{
			IntPtr intPtr = default;
			ref System.__Canon value = ref *(System.__Canon*)((nint)intPtr & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7448]");
			object obj5 = 0;
			GillaPieceId result;
			if (((Dictionary<PieceKey, System.__Canon>)obj4).TryGetValue(key, out value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Behaviour behaviour = default;
				bool flag3 = behaviour != null;
				bool flag4 = !flag3;
				result = null;
				if (!flag4)
				{
					if ((object)behaviour == null)
					{
						goto IL_0183;
					}
					bool isActiveAndEnabled = behaviour.isActiveAndEnabled;
					bool flag5 = !isActiveAndEnabled;
					object obj9 = !flag5;
					object obj10 = ~obj9;
					result = (GillaPieceId)((obj10 != null) ? null : behaviour);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}
		goto IL_0183;
		IL_0183:
		return (GillaPieceId)(object)new NullReferenceException();
	}

	public unsafe static GillaPieceId NearestFree(Vector3 at, float reach, out float away)
	{
		//IL_0010: Expected Obj, but got I
		//IL_081c: Expected native int or pointer, but got VT
		//IL_0829: Expected I, but got Obj
		//IL_084b: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_09e9: Expected VT, but got I4
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected Obj, but got I4
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got I
		//IL_007c: Expected VT, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected F4, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected Ref, but got Unknown
		//IL_0977: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		//IL_0660: Expected Obj, but got I4
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_06a7: Expected I, but got Obj
		//IL_0168: Expected I, but got Obj
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected F4, but got Unknown
		//IL_07a4: Expected Obj, but got I4
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got I4
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I8
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_0223: Expected I, but got Obj
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected I, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected F4, but got Unknown
		//IL_0a2b: Expected Obj, but got I4
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I4
		//IL_02c9: Expected I, but got Obj
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got I4
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected F4, but got Unknown
		//IL_0300: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got I
		//IL_0344: Expected I, but got Obj
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got I
		//IL_0388: Expected I, but got Obj
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected I, but got Obj
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got I
		//IL_0416: Expected I, but got Obj
		//IL_0447: Expected Obj, but got I4
		//IL_04fa: Expected VT, but got I4
		//IL_04fa: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I
		//IL_058b: Expected I, but got Obj
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Invalid comparison between Unknown and F4
		//IL_04c3: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected F4, but got Unknown
		//IL_05a5: Expected native int or pointer, but got VT
		//IL_05fc: Expected I, but got Obj
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		GillaPieceId gillaPieceId = (GillaPieceId)0;
		float x = default;
		((Vector3*)(nint)at)->x = x;
		nint num = (nint)gillaPieceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2 (Il2CppClass<GillaPieceId>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		nint num2 = num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)gillaPieceId;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3 (Il2CppClass<GillaPieceId>)+A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		Bounds bounds = (Bounds)0;
		UnityEngine.Object obj4 = default;
		UnityEngine.Object obj3 = obj4;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj5 = 109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74C0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj5 = 0;
			bounds = (Bounds)0;
			object obj9 = default;
			object obj8 = obj9;
			float num4 = default;
			float num3 = num4;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			gillaPieceId = null;
			float num7;
			Vector3 point = default;
			Bounds bounds3 = default;
			GillaPieceId result = default;
			object obj32 = default;
			object obj22;
			float num12 = default;
			Enumerator<, > val5;
			while (true)
			{
				nint num6;
				UnityEngine.Object obj16;
				ref float reference;
				if (val.MoveNext())
				{
					object obj10 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v32+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj4 == null;
					bool flag5 = !flag4;
					object obj12 = !flag5;
					nint num5 = unchecked((nint)null);
					if (obj12 != null)
					{
						continue;
					}
					if ((object)obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ stack_-D8 (UnityEngine.Object)+48]");
						bool flag6 = 0L != 2147483648L;
						num5 = unchecked((nint)null);
						if (flag6)
						{
							continue;
						}
						bool onItsOwn = ((GillaPieceId)obj4).OnItsOwn;
						bool flag7 = !onItsOwn;
						num5 = unchecked((nint)null);
						if (flag7)
						{
							continue;
						}
						Collider[] colliders = ((GillaPieceId)obj4).Colliders;
						if (colliders != null)
						{
							bool flag8 = colliders.Length < 1;
							num5 = unchecked((nint)null);
							if (flag8)
							{
								continue;
							}
							object obj13 = colliders.Length & 0xFFFFFFFFL;
							object obj14 = colliders + 32;
							object obj15 = 0;
							num5 = unchecked((nint)null);
							num6 = (nint)val2;
							num7 = (float)val3;
							obj16 = null;
							while (true)
							{
								bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
								object obj17 = !flag9;
								val2 = (Enumerator<, >)num6;
								val3 = (Enumerator<, >)num7;
								if (obj17 != null)
								{
									break;
								}
								object obj18 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
								UnityEngine.Object obj19 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v48+E4]");
								bool flag10 = (nint)0 == 0;
								object obj20 = !flag10;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
								bool flag11 = (UnityEngine.Object)0 == null;
								bool flag12 = !flag11;
								object obj21 = !flag12;
								num5 = unchecked((nint)null);
								val3 = (Enumerator<, >)num7;
								obj16 = null;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
									bool flag13 = (nint)0 == 0;
									num5 = unchecked((nint)null);
									val2 = (Enumerator<, >)num6;
									reference = ref *(float*)null;
									if (flag13)
									{
										goto end_IL_0861;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
									bool enabled = ((Collider)0).enabled;
									bool flag14 = !enabled;
									num5 = unchecked((nint)null);
									val3 = (Enumerator<, >)num7;
									obj16 = null;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
										GameObject gameObject = ((Component)0).gameObject;
										bool flag15 = (object)gameObject == null;
										num5 = unchecked((nint)null);
										obj3 = null;
										val = val4;
										obj22 = 0;
										val2 = (Enumerator<, >)num6;
										val5 = (Enumerator<, >)(ref val);
										reference = ref *(float*)null;
										if (flag15)
										{
											goto IL_0754;
										}
										bool activeInHierarchy = gameObject.activeInHierarchy;
										bool flag16 = !activeInHierarchy;
										num5 = unchecked((nint)null);
										val3 = (Enumerator<, >)num7;
										obj16 = null;
										if (!flag16)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4370]");
											object obj23 = 0;
											num6 = (nint)obj19;
											object obj24 = obj23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X9_v11 (Il2CppClass<UnityEngine.Object>)+130]");
											nint num8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v32+130]");
											bool flag17 = num8 < 0;
											object obj25 = !flag17;
											object obj26 = ~obj25;
											if (obj26 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X9_v11 (Il2CppClass<UnityEngine.Object>)+B0]");
												nint num9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v32+130]");
												object obj27 = num9 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X9_v18-8]");
												num6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X9_v18-8]");
												if (0 == (nint)obj24)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
													if (!((MeshCollider)0).convex)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
														Bounds bounds2 = ((Collider)0).bounds;
														float num10 = bounds.Internal_SqrDistance(ref point);
														bounds = bounds3;
														num5 = unchecked((nint)null);
														val3 = (Enumerator<, >)num10;
														obj16 = (UnityEngine.Object)(&point);
														goto IL_0901;
													}
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X25_v8+v135 @ X28_v8*8]");
											Vector3 vector = ((Collider)0).ClosestPoint((Vector3)0);
											object obj28 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v63+E4]");
											bool flag18 = (nint)0 == 0;
											object obj29 = !flag18;
											if (obj29 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num11 = num12 - num12;
											float num13 = num4 - num4;
											obj8 = obj9 - obj9;
											float num14 = num11 * num11;
											float num15 = num13 * num13;
											float num16 = num14 + num15;
											object obj30 = obj8 * obj8;
											float num17 = (float)obj30 + num16;
											num5 = unchecked((nint)null);
											val3 = (Enumerator<, >)num17;
											obj16 = null;
											goto IL_0901;
										}
									}
								}
								goto IL_088b;
								IL_088b:
								obj13 = colliders.Length;
								obj15++;
								bool flag19 = (nint)obj15 < colliders.Length;
								num7 = (float)val3;
								if (flag19)
								{
									continue;
								}
								goto IL_05b7;
								IL_0901:
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								num3 = at.x;
								if ((float)val3 < at.x)
								{
									((Vector3*)(nint)at)->x = (float)val3;
									gillaPieceId = (GillaPieceId)obj4;
								}
								goto IL_088b;
							}
							goto IL_06b1;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					num5 = unchecked((nint)null);
					obj16 = null;
					goto IL_06b1;
				}
				obj3 = null;
				val = val4;
				obj22 = 0;
				num12 = (float)val3;
				val5 = (Enumerator<, >)(ref val);
				object obj31 = 0;
				goto IL_093c;
				IL_05b7:
				val2 = (Enumerator<, >)num6;
				continue;
				IL_0754:
				NullReferenceException ex3 = new NullReferenceException();
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == (void*)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj3 = (UnityEngine.Object)1;
					num12 = num7;
					obj31 = obj22;
				}
				else
				{
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E134");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj31 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj22 = obj32;
					num12 = num7;
				}
				goto IL_093c;
				IL_06b1:
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
				num7 = (float)val3;
				reference = ref *(float*)obj16;
				break;
				IL_093c:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74B8]");
				object obj33 = 0;
				reference = ref *(float*)obj33;
				((Enumerator<, >*)val5)->Dispose();
				bool flag20 = obj31 == null;
				object obj34 = !flag20;
				obj9 = obj8;
				num4 = num3;
				if (obj34 == null)
				{
					bool flag21 = (object)obj3 == null;
					object obj35 = !flag21;
					obj9 = obj8;
					num4 = num3;
					OutOfMemoryException ex5 = (OutOfMemoryException)val5;
					if (obj35 == null)
					{
						return gillaPieceId;
					}
				}
				else
				{
					OutOfMemoryException ex5 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				obj8 = obj9;
				num3 = num4;
				num7 = num12;
				goto IL_0754;
				continue;
				end_IL_0861:
				break;
			}
			NullReferenceException ex6 = new NullReferenceException();
			obj9 = obj8;
			num4 = num3;
			obj3 = null;
			val = val4;
			obj22 = 0;
			num12 = num7;
			val5 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public static void HoldIt(PlayerRef by, bool right, PieceKey key, Vector3 pos, Quaternion rot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_0209: Expected VT, but got I4
		//IL_0212: Expected VT, but got I4
		//IL_059d: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_02c0: Expected VT, but got I4
		//IL_02c8: Expected VT, but got Obj
		//IL_0411: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_04d3: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_05d5: Expected Obj, but got I4
		//IL_0625: Expected VT, but got I4
		//IL_0625: Expected VT, but got I4
		//IL_064e: Expected VT, but got I4
		//IL_0657: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = pos & 0xFFFFFFFFL;
		GillaPieceId gillaPieceId = Find(key);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gillaPieceId == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = default;
		int playerId = playerRef.PlayerId;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaPieceId gillaPieceId2 = HeldIn(playerId, right);
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = gillaPieceId2 != null;
		bool flag9 = !flag8;
		Quaternion quaternion2 = default;
		Quaternion quaternion = quaternion2;
		Quaternion quaternion4 = default;
		Quaternion quaternion3 = quaternion4;
		object obj17 = default;
		object obj16 = obj17;
		object obj19 = default;
		object obj18 = obj19;
		Quaternion quaternion5 = (Quaternion)0;
		Vector3 vector = (Vector3)0;
		object obj20 = obj17;
		Quaternion quaternion6 = quaternion4;
		Vector3 vector2 = default;
		if (!flag9)
		{
			object obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v34+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = gillaPieceId2 != gillaPieceId;
			bool flag12 = !flag11;
			quaternion = quaternion2;
			quaternion3 = quaternion4;
			obj16 = obj17;
			obj18 = obj19;
			quaternion5 = (Quaternion)0;
			vector = (Vector3)gillaPieceId;
			obj20 = obj17;
			quaternion6 = quaternion4;
			if (!flag12)
			{
				if ((object)gillaPieceId2 != null)
				{
					Transform transform = gillaPieceId2.transform;
					if ((object)transform != null)
					{
						Vector3 position = transform.position;
						Transform transform2 = gillaPieceId2.transform;
						if ((object)transform2 != null)
						{
							Quaternion rotation = transform2.rotation;
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v45+E4]");
							bool flag13 = (nint)0 == 0;
							object obj24 = !flag13;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Free(gillaPieceId2, (Vector3)0, (Quaternion)0, pos, (Vector3)rot);
							quaternion = (Quaternion)vector2;
							quaternion3 = quaternion2;
							object obj25 = default;
							obj16 = obj25;
							object obj26 = default;
							obj18 = obj26;
							quaternion5 = (Quaternion)0;
							vector = (Vector3)0;
							obj20 = obj17;
							quaternion6 = quaternion4;
							goto IL_0573;
						}
					}
				}
				goto IL_0516;
			}
		}
		goto IL_0573;
		IL_0573:
		object obj27 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v21+E4]");
		bool flag14 = (nint)0 == 0;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int playerId2 = playerRef.PlayerId;
		if ((object)gillaPieceId != null)
		{
			gillaPieceId.heldBy = playerId2;
			gillaPieceId.heldRight = right;
			gillaPieceId.heldPos = vector2;
			gillaPieceId.heldRot = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74D8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj30 = default;
			if (obj30 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v26+18]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v26+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				object obj32 = obj30 + 32;
				object obj33 = 0;
				while (true)
				{
					bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
					object obj34 = !flag15;
					if (obj34 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v6+v506 @ X20_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v6+v506 @ X20_v6*8]");
						((Rigidbody)0).isKinematic = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v26+18]");
						obj31 = 0;
						obj33++;
						object obj35 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v26+18]");
						if ((nint)obj35 >= 0)
						{
							return;
						}
						continue;
					}
					goto IL_0516;
				}
				goto IL_0524;
			}
		}
		goto IL_0516;
		IL_0524:
		throw new IndexOutOfRangeException();
		IL_0516:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0524;
	}

	public static void LetGo(PlayerRef by, bool right, Vector3 at, Quaternion rot, Vector3 velocity, Vector3 spin)
	{
		//IL_0010: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_016d: Expected VT, but got I4
		//IL_016d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		PlayerRef playerRef = default;
		int playerId = playerRef.PlayerId;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaPieceId gillaPieceId = HeldIn(playerId, right);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaPieceId != null)
		{
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Free(gillaPieceId, (Vector3)0, (Quaternion)0, (Vector3)rot, velocity);
		}
	}

	public unsafe static GillaPieceId HeldIn(int by, bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Ref
		//IL_01b0: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Ref, but got Unknown
		//IL_0396: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0212: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v8+8]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj5 = (UnityEngine.Object)right;
		object obj6 = 109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74C0]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74B8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v8+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val = default;
			obj4 = (object)(&val);
			bool flag5;
			object obj16 = default;
			GillaPieceId result2 = default;
			nint num;
			object obj11;
			object obj12;
			Enumerator<, > val2;
			do
			{
				if (val.MoveNext())
				{
					object obj8 = obj7;
					UnityEngine.Object obj9 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v31+E4]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)null != (UnityEngine.Object)null;
					flag5 = !flag4;
					num = unchecked((nint)null);
					continue;
				}
				obj11 = 0;
				obj12 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj13 = 0;
				while (true)
				{
					UnityEngine.Object result = null;
					obj5 = (UnityEngine.Object)obj;
					((Enumerator<, >*)val2)->Dispose();
					bool flag6 = obj13 == null;
					object obj14 = !flag6;
					if (obj14 == null)
					{
						bool flag7 = obj11 == null;
						object obj15 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj15 == null)
						{
							return (GillaPieceId)result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj11 = 1;
						obj13 = obj12;
						obj4 = 1;
						continue;
					}
					if ((nint)obj5 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj13 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E134");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			while (flag5);
			NullReferenceException ex2 = new NullReferenceException();
			num = unchecked((nint)null);
			obj11 = 0;
			obj12 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj5 = null;
		}
		throw new NullReferenceException();
	}

	private static void Free(GillaPieceId p, Vector3 at, Quaternion rot, Vector3 velocity, Vector3 spin)
	{
		//IL_0017: Expected I4, but got I8
		//IL_0051: Expected Obj, but got I
		//IL_0063: Expected VT, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_0131: Expected VT, but got I4
		//IL_0131: Expected Obj, but got I
		//IL_014c: Expected VT, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		if ((object)p != null)
		{
			p.heldBy = -2147483648;
			Transform transform = p.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74D8]");
				object obj = 0;
				transform.SetPositionAndRotation((Vector3)0, rot);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				object obj2 = default;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+18]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+18]");
					if ((nint)0 < (nint)1)
					{
						return;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v69 @ X21_v6*8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v69 @ X21_v6*8]");
							((Rigidbody)0).isKinematic = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v69 @ X21_v6*8]");
							((Rigidbody)0).linearVelocity = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v69 @ X21_v6*8]");
							((Rigidbody)0).angularVelocity = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v69 @ X21_v6*8]");
							((Rigidbody)0).WakeUp();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+18]");
							obj3 = 0;
							obj5++;
							object obj7 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+18]");
							if ((nint)obj7 >= 0)
							{
								return;
							}
							continue;
						}
						goto IL_01a5;
					}
					goto IL_01b3;
				}
			}
		}
		goto IL_01a5;
		IL_01a5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01b3;
		IL_01b3:
		throw new IndexOutOfRangeException();
	}

	public static void GoneWith(GillaCorpse body)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v8+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+18]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74E8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7468]");
		object obj11 = 0;
		object obj12 = 0;
		UnityEngine.Object obj13 = null;
		UnityEngine.Object obj29 = default;
		do
		{
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v13+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v11+8]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			num--;
			System.__Canon _Canon2;
			if (num < list._size)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj18 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v21+A0]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v22+8]");
					list = (List<System.__Canon>)0;
				}
				obj12 = obj10;
				System.__Canon _Canon = list.get_Item(num);
				_Canon2 = _Canon;
				obj13 = (UnityEngine.Object)num;
			}
			else
			{
				_Canon2 = null;
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = (UnityEngine.Object)(object)_Canon2 != null;
			bool flag9 = !flag8;
			obj12 = 0;
			obj13 = null;
			if (flag9)
			{
				continue;
			}
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X21_v5 (System.__Canon)+30]");
			UnityEngine.Object obj23 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v20+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = obj23 == body;
			bool flag12 = !flag11;
			obj12 = 0;
			obj13 = body;
			if (flag12)
			{
				continue;
			}
			GameObject gameObject = ((Component)(object)_Canon2).gameObject;
			GameObject gameObject2 = body.gameObject;
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v17+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = gameObject != gameObject2;
			bool flag15 = !flag14;
			obj23 = gameObject;
			obj12 = 0;
			obj13 = gameObject2;
			if (flag15)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v18+E4]");
			bool flag16 = (nint)0 == 0;
			object obj28 = !flag16;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = obj29 == null;
			bool flag18 = !flag17;
			obj23 = obj29;
			obj12 = 0;
			obj13 = null;
			if (!flag18)
			{
				GameObject gameObject3 = ((Component)(object)_Canon2).gameObject;
				object obj30 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v19+E4]");
				bool flag19 = (nint)0 == 0;
				object obj31 = !flag19;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(gameObject3);
				obj23 = obj29;
				obj12 = 0;
				obj13 = null;
			}
		}
		while (num > 0);
	}

	public static bool Ready(GillaPieceId p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Sliceable(p);
	}

	private static bool Sliceable(GillaPieceId p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_02c9: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_0182: Invalid comparison between F4 and I
		//IL_00e3: Expected Obj, but got I8
		//IL_01a6: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0352: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
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
		bool flag2 = p == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)p == null)
			{
				goto IL_02bb;
			}
			if (p.isActiveAndEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaPieceId)+28]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X0 (GillaPieceId)+28]");
				if ((nint)0 >= (nint)2)
				{
					object obj6 = 4294967295L;
					object obj7 = default;
					obj6 = obj7;
					object obj8 = default;
					obj5 = obj8;
					object obj12;
					do
					{
						bool flag4 = (nint)obj5 < 3;
						object obj9 = !flag4;
						object obj10 = obj5 - 3;
						bool flag5 = obj10 == null;
						obj6++;
						object obj11 = !flag5;
						obj12 = obj9 & obj11;
					}
					while (obj12 != null);
					bool flag6 = (nint)obj6 < 3;
					object obj13 = !flag6;
					object obj14 = obj6 - 3;
					bool flag7 = obj14 == null;
					object obj15 = !flag7;
					object obj16 = obj13 & obj15;
					if (obj16 != null)
					{
						goto IL_02ad;
					}
				}
				float time = Time.time;
				float num = time - p.bornAt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				if (!(num < 0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
					object obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v15+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int slicesOut = SlicesOut;
					if (slicesOut <= 79)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74F0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
						object obj22 = default;
						object obj21 = obj22 & 1;
						if (obj21 != null)
						{
							GillaCorpse gillaCorpse = default;
							if ((object)gillaCorpse == null)
							{
								goto IL_02bb;
							}
							if (!gillaCorpse.SliceReady)
							{
								goto IL_02ad;
							}
						}
						return true;
					}
				}
			}
		}
		goto IL_02ad;
		IL_02ad:
		return false;
		IL_02bb:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static void Touching(Vector3 back, Vector3 tip, float reach, List<(GillaPieceId, Vector3)> found, bool all = default(bool), Vector3? back0 = null, Vector3? tip0 = null)
	{
		//IL_150c: Invalid comparison between VT and I4
		//IL_151c: Expected VT, but got I4
		//IL_153a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_15a9: Expected VT, but got Obj
		//IL_15ba: Expected VT, but got Obj
		//IL_15d3: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_2074: Expected Obj, but got I4
		//IL_0132: Invalid comparison between F4 and I4
		//IL_0141: Invalid comparison between F4 and I4
		//IL_0154: Expected Obj, but got F4
		//IL_0161: Expected Obj, but got F4
		//IL_0196: Expected Obj, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_20ad: Expected Obj, but got I4
		//IL_01fe: Invalid comparison between F4 and I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got F4
		//IL_0254: Expected Obj, but got I4
		//IL_0281: Expected F4, but got I4
		//IL_168e: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a2: Expected Obj, but got I
		//IL_16bb: Invalid comparison between F4 and I4
		//IL_16ca: Invalid comparison between F4 and I4
		//IL_16d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16de: Expected Obj, but got Unknown
		//IL_16eb: Expected Obj, but got F4
		//IL_1720: Expected Obj, but got I4
		//IL_1728: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Expected Obj, but got Unknown
		//IL_0294: Expected F4, but got I4
		//IL_20cb: Expected Obj, but got I
		//IL_20e3: Expected Obj, but got I
		//IL_20eb: Expected Obj, but got Ref
		//IL_212e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2133: Expected Obj, but got Unknown
		//IL_1761: Invalid comparison between F8 and I4
		//IL_1770: Invalid comparison between F8 and I4
		//IL_1783: Expected Obj, but got F8
		//IL_1790: Expected Obj, but got F8
		//IL_17d9: Expected Obj, but got I4
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e6: Expected Obj, but got Unknown
		//IL_18df: Invalid comparison between F8 and I4
		//IL_18ee: Invalid comparison between F8 and I4
		//IL_1901: Expected Obj, but got F8
		//IL_190e: Expected Obj, but got F8
		//IL_194d: Expected Obj, but got I4
		//IL_1955: Unknown result type (might be due to invalid IL or missing references)
		//IL_195a: Expected Obj, but got Unknown
		//IL_1a6c: Invalid comparison between F8 and I4
		//IL_1a7b: Invalid comparison between F8 and I4
		//IL_1a8e: Expected Obj, but got F8
		//IL_1a9b: Expected Obj, but got F8
		//IL_1ae4: Expected Obj, but got I4
		//IL_1aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af1: Expected Obj, but got Unknown
		//IL_1bb3: Expected Obj, but got I4
		//IL_1bd1: Expected Obj, but got I
		//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c23: Expected Obj, but got I4
		//IL_1c35: Expected VT, but got I4
		//IL_1c45: Expected Obj, but got I
		//IL_0335: Expected F4, but got I
		//IL_0345: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got I
		//IL_1c77: Expected native int or pointer, but got F4
		//IL_1c80: Expected Obj, but got F4
		//IL_1325: Expected Obj, but got I4
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Expected Obj, but got I4
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected Obj, but got I4
		//IL_1fb7: Expected Obj, but got I
		//IL_1fbf: Expected VT, but got Obj
		//IL_1fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc8: Expected Ref, but got Unknown
		//IL_1fe2: Expected Obj, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_052a: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_1370: Expected Obj, but got I4
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got F4
		//IL_0595: Expected Obj, but got F4
		//IL_0445: Expected Obj, but got I4
		//IL_146e: Invalid comparison between VT and I4
		//IL_046c: Expected Obj, but got F4
		//IL_048a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got F4
		//IL_14bd: Invalid comparison between VT and I4
		//IL_05ac: Invalid comparison between F4 and I4
		//IL_05ba: Expected Obj, but got F4
		//IL_13ee: Expected VT, but got Obj
		//IL_04ae: Invalid comparison between F4 and I4
		//IL_04bc: Expected Obj, but got F4
		//IL_14a7: Expected Obj, but got I4
		//IL_140d: Expected Obj, but got I4
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got I4
		//IL_1423: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got F4
		//IL_05fc: Expected Obj, but got F4
		//IL_04dd: Expected Obj, but got F4
		//IL_04f8: Expected Obj, but got F4
		//IL_10cd: Expected F4, but got I4
		//IL_10d6: Expected F8, but got I4
		//IL_10df: Expected F4, but got I4
		//IL_10e7: Expected Obj, but got F4
		//IL_10f0: Expected F4, but got I4
		//IL_1ce1: Expected F4, but got I
		//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Expected Obj, but got Unknown
		//IL_063d: Expected Obj, but got I8
		//IL_0646: Expected F4, but got I4
		//IL_064f: Expected F8, but got I4
		//IL_0658: Expected F4, but got I4
		//IL_0661: Expected Obj, but got I4
		//IL_1cc3: Expected Obj, but got I4
		//IL_1105: Expected Obj, but got I
		//IL_1116: Expected VT, but got Obj
		//IL_1116: Expected Obj, but got F4
		//IL_1126: Expected Obj, but got I
		//IL_1136: Expected Obj, but got I
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected VT, but got F4
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I4
		//IL_11c2: Expected F4, but got I
		//IL_11ec: Expected Obj, but got I4
		//IL_0711: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I4
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected F4, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Expected Obj, but got VT
		//IL_12be: Expected Obj, but got I
		//IL_12ce: Expected Obj, but got I
		//IL_12db: Expected VT, but got Ref
		//IL_12db: Expected Obj, but got VT
		//IL_12e4: Expected F4, but got I4
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Expected F4, but got VT
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_123b: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected F4, but got I4
		//IL_128c: Expected F4, but got VT
		//IL_1f6e: Expected Obj, but got I4
		//IL_1f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7c: Expected Obj, but got Unknown
		//IL_078a: Expected Obj, but got I
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected F4, but got Unknown
		//IL_07c9: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected F4, but got Unknown
		//IL_0813: Expected Obj, but got I
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected F4, but got Unknown
		//IL_0886: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I4
		//IL_08d9: Invalid comparison between F8 and I4
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_09e6: Expected Obj, but got I4
		//IL_09fe: Invalid comparison between F4 and I4
		//IL_0a0f: Expected Obj, but got I4
		//IL_0a3d: Expected F8, but got I4
		//IL_0aef: Expected Obj, but got I4
		//IL_0b07: Invalid comparison between F8 and I4
		//IL_0b18: Expected Obj, but got I4
		//IL_0bc7: Expected Obj, but got I
		//IL_0bcf: Expected I, but got Obj
		//IL_0be8: Expected F4, but got I
		//IL_0c11: Expected Obj, but got I4
		//IL_1f3e: Invalid comparison between F8 and I4
		//IL_1f4d: Expected F8, but got I4
		//IL_1f56: Expected F8, but got I4
		//IL_1e1e: Expected VT, but got I4
		//IL_1049: Expected Obj, but got I
		//IL_1067: Expected Obj, but got I4
		//IL_2179: Invalid comparison between VT and I4
		//IL_2188: Expected F8, but got I4
		//IL_0ca5: Invalid comparison between F8 and I4
		//IL_0cb4: Invalid comparison between F8 and I4
		//IL_0ccc: Expected Obj, but got F8
		//IL_0cd9: Expected Obj, but got F8
		//IL_0d0e: Expected Obj, but got I4
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected Obj, but got Unknown
		//IL_1eb7: Expected VT, but got I4
		//IL_1eb7: Expected Obj, but got I
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eea: Expected Obj, but got I4
		//IL_0d7d: Invalid comparison between VT and F8
		//IL_0d8e: Expected F8, but got VT
		//IL_0e58: Expected Obj, but got I4
		//IL_0e70: Invalid comparison between F4 and I4
		//IL_0e81: Expected Obj, but got I4
		//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f06: Expected VT, but got Unknown
		//IL_1f0f: Invalid comparison between VT and I4
		//IL_0ea5: Expected Obj, but got I4
		//IL_0ef3: Invalid comparison between F4 and I4
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected Obj, but got Unknown
		//IL_0f14: Expected Obj, but got F4
		//IL_0f49: Expected Obj, but got I4
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Expected Obj, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		bool flag = back == (Vector3)(object)0;
		Bounds bounds = (Bounds)0;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		double num6 = default;
		double num5 = num6;
		Enumerator<, > val = (Enumerator<, >)0;
		double num8 = default;
		double num7 = num8;
		double num10 = default;
		double num9 = num10;
		double num12 = default;
		double num11 = num12;
		Vector3 vector = tip;
		float num14 = default;
		float num13 = num14;
		float num16 = default;
		float num15 = num16;
		float num17 = num14;
		float num18 = num16;
		double num19 = num10;
		Vector3 vector2 = tip;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7508]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+1C]");
			object obj2 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
			bool flag2 = (nint)0 < (nint)1;
			float num20 = num14;
			float num21 = num16;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+10]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
				Array.Clear((Array)num22, 0, 0);
				num20 = num14;
				num21 = num16;
			}
			Vector3? vector4 = default;
			Vector3 vector3 = (Vector3)(vector4 ?? obj);
			Vector3? vector6 = default;
			Vector3 vector5 = (Vector3)(vector6 ?? obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			object obj4 = obj3;
			float num23 = num14 - num20;
			float num24 = num16 - num21;
			double num25 = num12 - num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v28+E4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num26 = num23 * num23;
			float num27 = num24 * num24;
			float num28 = num26 + num27;
			double num29 = num25 * num25;
			float num30 = (float)num29 + num28;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj5 = obj3;
			double num31 = num10 - num10;
			double num32 = num6 - num6;
			double num33 = (double)num4 - (double)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v31+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num34 = num32 * num32;
			double num35 = num31 * num31;
			double num36 = num34 + num35;
			double num37 = num33 * num33;
			float num38 = (float)num37 + (float)num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num39 = num30 - num38;
			bool flag4 = num39 < 0f;
			bool flag5 = num39 == 0f;
			object obj7 = num30 ^ num38;
			object obj8 = num30 ^ num39;
			object obj9 = obj7 & obj8;
			bool flag6 = (nint)obj9 < 0;
			bool flag7 = flag4 == flag6;
			object obj10 = !flag5;
			object obj11 = flag7 & obj10;
			object obj12 = ~obj11;
			if (obj12 != null)
			{
				num30 = num38;
			}
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v34+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			float num40 = num38 - 8f;
			bool flag9 = num40 < 0f;
			object obj15 = num38 ^ 8;
			object obj16 = num38 ^ num40;
			object obj17 = obj15 & obj16;
			bool flag10 = (nint)obj17 < 0;
			bool flag11 = flag9 == flag10;
			object obj18 = !flag11;
			object obj19 = ~obj18;
			float num41 = ((obj19 != null) ? 8f : num38);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
			Enumerator<, > val2 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7428]");
			object obj20 = 0;
			float num42 = num41 - 1f;
			bool flag12 = num42 < 0f;
			bool flag13 = num42 == 0f;
			object obj21 = num41 ^ 1;
			object obj22 = num41 ^ num42;
			object obj23 = obj21 & obj22;
			bool flag14 = (nint)obj23 < 0;
			bool flag15 = flag12 == flag14;
			object obj24 = !flag13;
			object obj25 = flag15 & obj24;
			object obj26 = ~obj25;
			if (obj26 != null)
			{
				num41 = 1f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v28+A0]");
			object obj29 = 0;
			object obj31 = default;
			object obj30 = (object)(&obj31);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v29+8]");
			double num43 = 0.0 * 0.5;
			double num44 = num12 - num43;
			double num45 = num12 + num43;
			object obj32 = obj29 * 63;
			float num46 = num14 + (float)obj32;
			float num47 = num14 - (float)obj32;
			if (!(num44 < (double)num4))
			{
				num44 = num4;
			}
			double num48 = num45 - (double)num4;
			bool flag16 = num48 < 0.0;
			bool flag17 = num48 == 0.0;
			object obj33 = num45 ^ (double)num4;
			object obj34 = num45 ^ num48;
			object obj35 = obj33 & obj34;
			bool flag18 = (nint)obj35 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			bool flag19 = flag16 == flag18;
			object obj36 = !flag17;
			object obj37 = flag19 & obj36;
			object obj38 = ~obj37;
			if (obj38 != null)
			{
				num45 = num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			double num49 = num45 - num44;
			float num50 = num46 - num47;
			double num51 = num49 * 0.5;
			float num52 = num50 * 63f;
			double num53 = num44 + num51;
			float num54 = num47 + num52;
			double num55 = num53 - num51;
			double num56 = num51 + num53;
			float num57 = num52 + num54;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			double num58 = ((!(num55 < num12)) ? num12 : num55);
			double num59 = num56 - num12;
			bool flag20 = num59 < 0.0;
			bool flag21 = num59 == 0.0;
			object obj39 = num56 ^ num12;
			object obj40 = num56 ^ num59;
			object obj41 = obj39 & obj40;
			bool flag22 = (nint)obj41 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			bool flag23 = flag20 == flag22;
			object obj42 = !flag21;
			object obj43 = flag23 & obj42;
			object obj44 = ~obj43;
			if (obj44 != null)
			{
				num56 = num12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			double num60 = num56 - num58;
			float num61 = num57 - num52;
			double num62 = num60 * 0.5;
			float num63 = num61 * 63f;
			num9 = num58 + num62;
			num3 = num52 + num63;
			num7 = num9 - num62;
			double num64 = num62 + num9;
			float num65 = num3 - num63;
			float num66 = num63 + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			if (!(num7 < (double)num4))
			{
				num7 = num4;
			}
			double num67 = num64 - (double)num4;
			bool flag24 = num67 < 0.0;
			bool flag25 = num67 == 0.0;
			object obj45 = num64 ^ (double)num4;
			object obj46 = num64 ^ num67;
			object obj47 = obj45 & obj46;
			bool flag26 = (nint)obj47 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			bool flag27 = flag24 == flag26;
			object obj48 = !flag25;
			object obj49 = flag27 & obj48;
			object obj50 = ~obj49;
			if (obj50 != null)
			{
				num64 = num4;
			}
			float num68 = num66 - (float)num9;
			double num69 = num64 - num7;
			num15 = num68 * 63f;
			double num70 = num69 * 0.5;
			num11 = num9 + (double)num15;
			num5 = num7 + num70;
			num13 = (float)num8 + (float)num8;
			bounds.Expand(num13);
			object obj51 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X0_v39+E4]");
			bool flag28 = (nint)0 == 0;
			object obj52 = !flag28;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj51 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X0_v39+A0]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v32+8]");
			bool flag29 = (nint)0 == 0;
			double num71 = num6;
			num = num2;
			double num72 = num31;
			double num73 = num33;
			double num74 = num32;
			val = (Enumerator<, >)0;
			UnityEngine.Object obj54 = (UnityEngine.Object)109891584;
			double num75 = num12;
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
			List<(GillaPieceId, Vector3)> list = (List<(GillaPieceId, Vector3)>)0;
			num17 = num14;
			num18 = num16;
			num19 = num10;
			vector2 = tip;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74C0]");
				float num76 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v32+8]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				num71 = num6;
				num = num2;
				num72 = num31;
				num73 = num33;
				num74 = num32;
				double num77 = num5;
				float num78 = num41;
				obj54 = (UnityEngine.Object)109891584;
				val2 = (Enumerator<, >)(ref val);
				double num79 = num11;
				num75 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
				list = (List<(GillaPieceId, Vector3)>)0;
				num13 = num41;
				num17 = num14;
				num18 = num16;
				num19 = num10;
				vector2 = tip;
				List<(GillaPieceId, Vector3)> list2;
				Enumerator<, > val3 = default;
				float num86 = default;
				float num87 = default;
				double num88 = default;
				float num90 = default;
				double num91 = default;
				float num93 = default;
				float num94 = default;
				object obj116 = default;
				object obj110;
				object obj111;
				Enumerator<, > val4;
				while (true)
				{
					UnityEngine.Object obj56 = (UnityEngine.Object)((float*)(nint)num76)->m_value;
					UnityEngine.Object obj61;
					if (val.MoveNext())
					{
						object obj57 = vector2 & 1;
						if (obj57 != null)
						{
							object obj58 = obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X0_v100+E4]");
							bool flag30 = (nint)0 == 0;
							object obj59 = !flag30;
							if (obj59 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag31 = (UnityEngine.Object)num2 == null;
							bool flag32 = !flag31;
							object obj60 = !flag32;
							obj54 = (UnityEngine.Object)num2;
							list = null;
							if (obj60 != null)
							{
								continue;
							}
							bool flag33 = num2 == 0f;
							obj54 = (UnityEngine.Object)num2;
							obj61 = null;
							list2 = null;
							if (flag33)
							{
								goto IL_13cf;
							}
							bool isActiveAndEnabled = ((UnityEngine.Behaviour)num2).isActiveAndEnabled;
							bool flag34 = !isActiveAndEnabled;
							obj54 = (UnityEngine.Object)num2;
							list = null;
							if (flag34)
							{
								continue;
							}
							obj56 = null;
							list = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
							object obj62 = 0;
							object obj63 = obj62;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v95+E4]");
							bool flag35 = (nint)0 == 0;
							object obj64 = !flag35;
							if (obj64 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag36 = Sliceable((GillaPieceId)num2);
							bool flag37 = !flag36;
							obj54 = (UnityEngine.Object)num2;
							if (flag37)
							{
								continue;
							}
							bool flag38 = num2 == 0f;
							obj54 = (UnityEngine.Object)num2;
							obj61 = obj56;
							list2 = list;
							if (flag38)
							{
								goto IL_13dd;
							}
						}
						Collider[] colliders = ((GillaPieceId)num2).Colliders;
						bool flag39 = colliders == null;
						obj54 = (UnityEngine.Object)num2;
						if (!flag39)
						{
							float num80;
							double num81;
							float num82;
							UnityEngine.Object obj88;
							if (colliders.Length >= 1)
							{
								object obj65 = colliders.Length & 0xFFFFFFFFL;
								num80 = 0f;
								num81 = 0.0;
								num82 = 0f;
								object obj66 = 0;
								obj54 = null;
								num13 = (float)num8;
								num17 = (float)num8;
								double num83 = num18;
								float num84 = (float)num19;
								bool flag74;
								do
								{
									bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65);
									object obj67 = !flag40;
									nint num96;
									if (obj67 == null)
									{
										object obj68 = obj55;
										object obj69 = (object)colliders + obj66;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v67+E4]");
										val2 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
										UnityEngine.Object obj70 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X0_v67+E4]");
										bool flag41 = (nint)0 == 0;
										object obj71 = !flag41;
										if (obj71 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
										bool flag42 = (UnityEngine.Object)0 == null;
										bool flag43 = !flag42;
										object obj72 = !flag43;
										float num85 = (float)val3;
										obj56 = null;
										if (obj72 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
											bool flag44 = (nint)0 == 0;
											obj56 = null;
											list = null;
											if (flag44)
											{
												goto IL_1395;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
											bool enabled = ((Collider)0).enabled;
											bool flag45 = !enabled;
											num85 = (float)val3;
											obj56 = null;
											if (!flag45)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
												bool isTrigger = ((Collider)0).isTrigger;
												bool flag46 = !isTrigger;
												object obj73 = !flag46;
												num85 = (float)val3;
												obj56 = null;
												if (obj73 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
													GameObject gameObject = ((Component)0).gameObject;
													bool flag47 = (object)gameObject == null;
													obj56 = null;
													list = null;
													if (flag47)
													{
														goto IL_13a3;
													}
													bool activeInHierarchy = gameObject.activeInHierarchy;
													bool flag48 = !activeInHierarchy;
													num85 = (float)val3;
													obj56 = null;
													if (!flag48)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
														Bounds bounds2 = ((Collider)0).bounds;
														num9 = (double)num86 - (double)num87;
														num3 = (float)num11 + (float)num88;
														bool flag49 = num9 < (double)num3;
														object obj74 = !flag49;
														double num89 = num9 - (double)num3;
														bool flag50 = num89 == 0.0;
														object obj75 = ~obj74;
														object obj76 = obj75 | flag50;
														num77 = num88;
														num85 = num86;
														num79 = num11;
														obj56 = null;
														num13 = num86;
														num15 = num87;
														if (obj76 != null)
														{
															num79 = num11 - num88;
															num13 = num86 + num87;
															bool flag51 = (double)num13 < num79;
															num77 = num88;
															num85 = num86;
															obj56 = null;
															num15 = num87;
															if (!flag51)
															{
																num3 = num90 - num;
																bool flag52 = (double)num3 < num91;
																object obj77 = !flag52;
																float num92 = num3 - (float)num91;
																bool flag53 = num92 == 0f;
																object obj78 = !flag53;
																object obj79 = obj77 & obj78;
																num77 = num91;
																num85 = num86;
																num9 = num91;
																num79 = 0.0;
																obj56 = null;
																num13 = num90;
																num15 = num;
																if (obj79 == null)
																{
																	num13 = num90 + num;
																	bool flag54 = (double)num13 < num91;
																	num77 = num91;
																	num85 = num86;
																	num9 = num91;
																	num79 = num91;
																	obj56 = null;
																	num15 = num;
																	if (!flag54)
																	{
																		num9 = (double)num93 - (double)num94;
																		num3 = (float)num5 + (float)num70;
																		bool flag55 = num9 < (double)num3;
																		object obj80 = !flag55;
																		double num95 = num9 - (double)num3;
																		bool flag56 = num95 == 0.0;
																		object obj81 = !flag56;
																		object obj82 = obj80 & obj81;
																		num77 = num70;
																		num85 = num86;
																		num79 = num5;
																		obj56 = null;
																		num13 = num93;
																		num15 = num94;
																		if (obj82 == null)
																		{
																			num13 = num93 + num94;
																			num15 = (float)num5 - (float)num70;
																			bool flag57 = num13 < num15;
																			num77 = num70;
																			num85 = num86;
																			num79 = num5;
																			obj56 = null;
																			if (!flag57)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4370]");
																				object obj83 = 0;
																				num96 = (nint)obj70;
																				object obj84 = obj83;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ X8_v62+130]");
																				num78 = 0f;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X9_v27 (Il2CppClass<UnityEngine.Object>)+130]");
																				nint num97 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ X8_v62+130]");
																				bool flag58 = num97 < 0;
																				object obj85 = !flag58;
																				object obj86 = ~obj85;
																				if (obj86 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1811 @ X9_v27 (Il2CppClass<UnityEngine.Object>)+B0]");
																					float num98 = 0f;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ X8_v62+130]");
																					float num99 = num98 + 0f;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ X9_v30 (System.Single)-8]");
																					num96 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ X9_v30 (System.Single)-8]");
																					if (0 == (nint)obj84)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
																						bool convex = ((MeshCollider)0).convex;
																						bool flag59 = !convex;
																						object obj87 = !flag59;
																						num76 = num41;
																						if (obj87 != null)
																						{
																							goto IL_1f26;
																						}
																						obj88 = obj54;
																						num77 = num70;
																						val3 = (Enumerator<, >)num86;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ X9_v30 (System.Single)-8]");
																						val2 = (Enumerator<, >)0;
																						num79 = num5;
																						obj56 = null;
																						num76 = num41;
																						goto IL_1f64;
																					}
																				}
																				num76 = num41;
																				goto IL_1f26;
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
										obj88 = obj54;
										val3 = (Enumerator<, >)num85;
										goto IL_1f64;
									}
									IndexOutOfRangeException ex = new IndexOutOfRangeException();
									goto IL_1395;
									IL_1395:
									NullReferenceException ex2 = new NullReferenceException();
									goto IL_13a3;
									IL_1f26:
									float num108;
									float num113;
									float num115;
									double num116;
									float num117;
									bool flag73;
									do
									{
										double num100 = (double)num76 / (double)num41;
										bool flag60 = num100 < 0.0;
										double num101 = 0.0;
										double num102 = 0.0;
										if (!flag60)
										{
											double num103 = num100 - 1.0;
											bool flag61 = num103 < 0.0;
											bool flag62 = num103 == 0.0;
											object obj89 = num100 ^ 1.0;
											object obj90 = num100 ^ num103;
											object obj91 = obj89 & obj90;
											bool flag63 = (nint)obj91 < 0;
											bool flag64 = flag61 == flag63;
											obj48 = !flag62;
											object obj92 = flag64 & obj48;
											obj50 = ~obj92;
											num101 = ((obj50 != null) ? num100 : 1.0);
											num102 = ((!(num100 > 1.0)) ? num100 : 1.0);
										}
										num3 = (float)num72 * (float)num102;
										float num104 = num23 * (float)num101;
										float num105 = num24 * (float)num101;
										double num106 = num25 * num101;
										num9 = num74 * num102;
										double num107 = num73 * num102;
										num7 = (double)num20 + (double)num104;
										num65 = (float)num75 + (float)num106;
										num108 = num21 + num105;
										double num109 = num6 + num9;
										float num110 = (float)num10 + num3;
										double num111 = (double)num4 + num107;
										double num112 = num109 - num7;
										num113 = num110 - num108;
										double num114 = num111 - (double)num65;
										obj88 = obj54;
										num115 = (float)num81;
										num116 = num82;
										num117 = num17;
										vector2 = (Vector3)0;
										do
										{
											bool flag65 = vector2 < (object)0;
											double num118 = 0.0;
											if (!flag65)
											{
												bool flag66 = vector2 <= (object)1.0;
												num118 = (double)vector2;
												if (!flag66)
												{
													num118 = 1.0;
												}
											}
											double num119 = num112 * num118;
											float num120 = num113 * (float)num118;
											double num121 = num114 * num118;
											double num122 = num7 + num119;
											float num123 = num108 + num120;
											float num124 = num65 + (float)num121;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v55+20]");
											Vector3 vector7 = ((Collider)0).ClosestPoint((Vector3)0);
											object obj93 = obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2125 @ X0_v87+E4]");
											bool flag67 = (nint)0 == 0;
											object obj94 = !flag67;
											if (obj94 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											double num125 = num122 - num122;
											float num126 = num123 - num123;
											num79 = (double)num124 - (double)num124;
											double num127 = num125 * num125;
											float num128 = num126 * num126;
											double num129 = num127 + (double)num128;
											double num130 = num79 * num79;
											num13 = (float)num130 + (float)num129;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											bool flag68 = num13 < num117;
											object obj95 = !flag68;
											float num131 = num13 - num117;
											bool flag69 = num131 == 0f;
											object obj96 = !flag69;
											object obj97 = obj95 & obj96;
											if (obj97 == null)
											{
												obj88 = (UnityEngine.Object)1;
												num80 = num123;
												num115 = num124;
												num116 = num122;
												num117 = num13;
											}
											vector2++;
										}
										while (vector2 != (Vector3)(object)9);
										num76--;
										float num132 = num76 - 1f;
										bool flag70 = num132 < 0f;
										object obj98 = num76 ^ 1;
										object obj99 = num76 ^ num132;
										object obj100 = obj98 & obj99;
										bool flag71 = (nint)obj100 < 0;
										bool flag72 = flag70 == flag71;
										object obj101 = !flag72;
										object obj102 = obj101 | (object)obj88;
										object obj103 = obj102 & 1;
										flag73 = obj103 == null;
										num72 = num31;
										num73 = num33;
										num74 = num32;
										num81 = num115;
										num82 = (float)num116;
										obj54 = null;
										num75 = num12;
										num17 = num117;
									}
									while (flag73);
									num71 = num108;
									num72 = num31;
									num73 = num33;
									num74 = num32;
									num77 = num7;
									num81 = num115;
									num82 = (float)num116;
									val3 = (Enumerator<, >)num86;
									val2 = (Enumerator<, >)num96;
									num75 = num12;
									obj56 = null;
									num15 = num117;
									num17 = num117;
									num83 = num7;
									num84 = num113;
									goto IL_1f64;
									IL_13a3:
									NullReferenceException ex3 = new NullReferenceException();
									goto IL_13b1;
									IL_1f64:
									obj65 = colliders.Length;
									obj66++;
									flag74 = (nint)obj66 < colliders.Length;
									obj54 = obj88;
									list = null;
								}
								while (flag74);
								obj54 = obj88;
								list = null;
								num18 = (float)num83;
								num19 = num84;
							}
							else
							{
								obj88 = null;
								num80 = 0f;
								num81 = 0.0;
								num82 = 0f;
								obj54 = (UnityEngine.Object)num2;
								num13 = 0f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74C0]");
							num76 = 0f;
							object obj104 = obj88 & 1;
							bool flag75 = obj104 == null;
							vector2 = tip;
							if (!flag75)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7510]");
								object obj105 = 0;
								(System.__Canon, Vector3) tuple = ((System.__Canon)num2, (Vector3)obj105);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+10]");
								object obj106 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74F8]");
								object obj107 = 0;
								val2 = (Enumerator<, >)obj107;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+1C]");
								num78 = 0f + 1f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+10]");
								bool flag76 = (nint)0 == 0;
								num79 = num81;
								vector = (Vector3)num2;
								list2 = (List<(GillaPieceId, Vector3)>)obj105;
								num13 = num82;
								num15 = num80;
								vector2 = tip;
								if (flag76)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
								num78 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
								nint num133 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ X8_v47+18]");
								bool flag77 = num133 < 0;
								object obj108 = !flag77;
								if (obj108 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
									float num134 = 0f * 24f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+10]");
									float num135 = 0f + num134;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [back @ X0 (UnityEngine.Vector3)+18]");
									val2 = (Enumerator<, >)((nint)0 + (nint)1);
									_ = 0;
									float num136 = num135 + 32f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num78 = 0f;
									num79 = num81;
									list = (List<(GillaPieceId, Vector3)>)obj105;
									num13 = (float)tuple;
									num15 = num80;
									vector2 = tip;
								}
								else
								{
									System.__Canon _Canon = (System.__Canon)val2._current;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1785 @ X8_v48 (System.__Canon)+A8]");
									object obj109 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X8_v49+70]");
									list = (List<(GillaPieceId, Vector3)>)0;
									((List<(System.__Canon, Vector3)>)back).AddWithResize(((System.__Canon, Vector3))(&val3));
									num = 0f;
									val2 = (Enumerator<, >)0;
									num79 = num81;
									num13 = (float)tuple;
									num15 = num80;
									vector2 = tip;
								}
							}
							continue;
						}
						goto IL_13b1;
					}
					num5 = num77;
					obj110 = 0;
					val = val3;
					obj111 = 0;
					val4 = (Enumerator<, >)(ref val);
					num11 = num79;
					object obj112 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74B8]");
						object obj113 = 0;
						vector = (Vector3)obj113;
						((Enumerator<, >*)val4)->Dispose();
						bool flag78 = obj112 == null;
						object obj114 = !flag78;
						if (obj114 == null)
						{
							bool flag79 = obj110 == null;
							object obj115 = !flag79;
							OutOfMemoryException ex4 = (OutOfMemoryException)val4;
							if (obj115 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex4 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if (vector == (Vector3)(object)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj110 = 1;
							obj112 = obj111;
							continue;
						}
						if (vector != (Vector3)(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj112 = obj116;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj111 = obj116;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E134");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
					IL_13dd:
					NullReferenceException ex5 = new NullReferenceException();
					vector = (Vector3)obj61;
					break;
					IL_13cf:
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_13dd;
					IL_13b1:
					NullReferenceException ex7 = new NullReferenceException();
					obj61 = obj56;
					list2 = list;
					goto IL_13cf;
				}
				NullReferenceException ex8 = new NullReferenceException();
				num5 = num77;
				obj110 = 0;
				val = val3;
				obj111 = 0;
				val4 = (Enumerator<, >)(ref val);
				num11 = num79;
				list = list2;
			}
		}
		throw new NullReferenceException();
	}

	public unsafe static bool Slice(GillaPieceId piece, Vector3 point, Vector3 normal, out byte frame, out Vector3 localPoint, out Vector3 localNormal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0265: Expected native int or pointer, but got VT
		//IL_0294: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_017f: Expected Ref, but got VT
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0231: Expected I4, but got Obj
		//IL_01ae: Expected VT, but got I4
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01c7: Expected native int or pointer, but got VT
		//IL_01d4: Expected native int or pointer, but got VT
		//IL_01e7: Expected VT, but got I4
		//IL_0214: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		((Vector3*)(nint)point)->x = 0f;
		_ = 0;
		ref byte reference = ref *(byte*)null;
		((Vector3*)(nint)normal)->z = 0f;
		((Vector3*)(nint)normal)->x = 0f;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Sliceable(piece))
		{
			object obj5 = default;
			object obj4 = obj5 * obj5;
			object obj7 = default;
			object obj6 = obj7 * obj7;
			object obj8 = obj4 + obj6;
			object obj10 = default;
			object obj9 = obj10 * obj10;
			object obj11 = obj9 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if ((nint)obj11 >= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				bool flag3 = num <= 0;
				object obj15 = 0;
				object obj16 = 0;
				object obj17 = 0;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					obj16 = obj5 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					obj15 = obj7 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
					obj17 = obj10 / 0;
				}
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj19 = !flag4;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform = FrameOf(piece, point, out *(byte*)normal);
				if ((object)transform != null)
				{
					Vector3 vector = transform.InverseTransformPoint((Vector3)0);
					float x = default;
					((Vector3*)(nint)normal)->x = x;
					float y = default;
					((Vector3*)(nint)normal)->y = y;
					float z = default;
					((Vector3*)(nint)normal)->z = z;
					Vector3 vector2 = transform.InverseTransformDirection((Vector3)0);
					reference = ref *(byte*)obj16;
					return Cut(piece, (Vector3)0, normal);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		return false;
	}

	public static bool Apply(PieceKey key, byte frame, Vector3 localPoint, Vector3 localNormal, Vector3 near, float most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I4
		//IL_0036: Expected I4, but got I8
		//IL_006d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_05c8: Expected I4, but got Obj
		//IL_011f: Invalid comparison between I and VT
		//IL_0184: Invalid comparison between Obj and F8
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_03b5: Expected VT, but got I4
		//IL_03c7: Expected VT, but got I4
		//IL_0720: Expected Obj, but got I
		//IL_074a: Expected Obj, but got I4
		//IL_06fc: Invalid comparison between F4 and Obj
		//IL_0485: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_05a3: Expected VT, but got I4
		//IL_05a3: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = (int)((int)frame & 0xFFFFFFFFL);
		GillaPieceId gillaPieceId = Find(key);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = gillaPieceId == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v12+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+8]");
			if ((nint)0 == 0)
			{
				goto IL_05ac;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v30+18]");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref localPoint))
			{
				object obj13 = default;
				object obj12 = obj13 * obj13;
				object obj15 = default;
				object obj14 = obj15 * obj15;
				object obj16 = obj12 + obj14;
				object obj18 = default;
				object obj17 = obj18 * obj18;
				object obj19 = obj17 + obj16;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25))
				{
					object obj20 = localPoint & 0xFF;
					Transform transform;
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v12+E4]");
						bool flag6 = (nint)0 == 0;
						object obj21 = !flag6;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj22 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v32+A0]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v33+8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v33+8]");
							if ((nint)0 == 0)
							{
								goto IL_05ac;
							}
						}
						object obj24 = localPoint & 0xFF;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v30+18]");
						bool flag7 = (nint)obj24 < 0;
						object obj25 = !flag7;
						if (obj25 != null)
						{
							goto IL_05ba;
						}
						object obj26 = obj11 + localPoint;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v31+20]");
						string text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v31+20]");
						transform = Bone(gillaPieceId, (string)0);
					}
					else
					{
						if ((object)gillaPieceId == null)
						{
							goto IL_05ac;
						}
						transform = gillaPieceId.transform;
						string text = null;
					}
					object obj27 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v18+E4]");
					bool flag8 = (nint)0 == 0;
					object obj28 = !flag8;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = transform == null;
					bool flag10 = !flag9;
					Transform transform2 = transform;
					if (!flag10)
					{
						if ((object)gillaPieceId == null)
						{
							goto IL_05ac;
						}
						Transform transform3 = gillaPieceId.transform;
						transform2 = transform3;
					}
					if ((object)transform2 == null)
					{
						goto IL_05ac;
					}
					Vector3 vector = transform2.TransformPoint((Vector3)0);
					Vector3 vector2 = transform2.TransformDirection((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj29 = 0;
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v29+E4]");
					bool flag11 = (nint)0 == 0;
					object obj31 = !flag11;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj32 = obj13 * obj13;
					object obj33 = obj15 * obj15;
					object obj34 = obj32 + obj33;
					object obj35 = obj18 * obj18;
					object obj36 = obj35 + obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if ((nint)obj36 > 0)
					{
					}
					object obj38 = default;
					object obj39 = default;
					object obj37 = obj38 - obj39;
					object obj40 = default;
					float num2 = most - (float)obj40;
					object obj42 = default;
					object obj43 = default;
					object obj41 = obj42 - obj43;
					float num3 = num2 * num2;
					object obj44 = obj41 * obj41;
					float num4 = num3 + (float)obj44;
					object obj45 = obj37 * obj37;
					float num5 = (float)obj45 + num4;
					object obj47 = default;
					object obj46 = obj47 * obj47;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46))
					{
						object obj48 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v31+E4]");
						bool flag12 = (nint)0 == 0;
						object obj49 = !flag12;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector3 = Middle(gillaPieceId);
						float num6 = num5 - most;
						object obj50 = obj46 - obj42;
						object obj51 = obj37 - obj38;
						float num7 = num6 * num6;
						object obj52 = obj50 * obj50;
						float num8 = num7 + (float)obj52;
						object obj53 = obj51 * obj51;
						float num9 = (float)obj53 + num8;
						if (!((double)num9 > 4.0))
						{
							object obj54 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v35+E4]");
							bool flag13 = (nint)0 == 0;
							object obj55 = !flag13;
							if (obj55 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							return Cut(gillaPieceId, (Vector3)0, (Vector3)0);
						}
					}
				}
			}
		}
		return false;
		IL_05ba:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_05ac:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05ba;
	}

	private unsafe static Transform FrameOf(GillaPieceId piece, Vector3 point, out byte frame)
	{
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_0015: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_0281: Expected F4, but got I4
		//IL_027c: Expected native int or pointer, but got VT
		//IL_029e: Expected Obj, but got I
		((Vector3*)(nint)point)->x = 0f;
		Transform result;
		if ((object)piece != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7518]");
			object obj = 0;
			Transform transform = piece.transform;
			System.__Canon _Canon = (System.__Canon)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+18]");
				bool flag = (nint)0 < (nint)1;
				result = transform;
				if (flag)
				{
					goto IL_02a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4708]");
				object obj5 = 0;
				object obj7 = default;
				object obj6 = obj7;
				object obj9 = default;
				object obj8 = obj9;
				object obj11 = default;
				object obj10 = obj11;
				object obj12 = 0;
				object obj13 = 2139095039;
				Transform transform2 = transform;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj14 = !flag2;
					if (obj14 != null)
					{
						break;
					}
					object obj15 = obj4;
					object obj16 = obj2 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v13+E4]");
					bool flag3 = (nint)0 == 0;
					object obj17 = !flag3;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						object obj18 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v9+A0]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+20]");
						string name = ((UnityEngine.Object)0).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v10+8]");
						int num = Array.IndexOf((System.__Canon[])0, (System.__Canon)(object)name);
						bool flag4 = num < 1;
						_Canon = (System.__Canon)(object)name;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+20]");
							Vector3 position = ((Transform)0).position;
							object obj20 = obj10 - obj11;
							object obj21 = obj8 - obj9;
							obj6 -= obj7;
							object obj22 = obj20 * obj20;
							object obj23 = obj21 * obj21;
							object obj24 = obj22 + obj23;
							obj8 = obj6 * obj6;
							obj10 = obj8 + obj24;
							bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
							_Canon = null;
							if (!flag5)
							{
								((Vector3*)(nint)point)->x = num;
								obj13 = obj10;
								_Canon = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+20]");
								transform2 = (Transform)0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+18]");
						obj3 = 0;
						obj12++;
						object obj25 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+18]");
						bool flag6 = (nint)obj25 < 0;
						result = transform2;
						if (flag6)
						{
							continue;
						}
						goto IL_02a3;
					}
					goto IL_02a8;
				}
				goto IL_02b6;
			}
		}
		goto IL_02a8;
		IL_02b6:
		return (Transform)(object)new IndexOutOfRangeException();
		IL_02a3:
		return result;
		IL_02a8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02b6;
	}

	private static Transform Bone(GillaPieceId piece, string name)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		Transform result;
		if ((object)piece != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7518]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0157;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X23_v6+v52 @ X22_v7*8]");
					if ((nint)0 == 0)
					{
						goto IL_0161;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X23_v6+v52 @ X22_v7*8]");
					string name2 = ((UnityEngine.Object)0).name;
					bool flag2 = name2 == name;
					bool flag3 = !flag2;
					object obj7 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X23_v6+v52 @ X22_v7*8]");
					result = (Transform)0;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+18]");
						obj3 = 0;
						obj5++;
						object obj8 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+18]");
						if ((nint)obj8 < 0)
						{
							continue;
						}
						goto IL_0157;
					}
					goto IL_019a;
				}
				goto IL_016f;
			}
		}
		goto IL_0161;
		IL_019a:
		return result;
		IL_0161:
		NullReferenceException ex = new NullReferenceException();
		goto IL_016f;
		IL_016f:
		return (Transform)(object)new IndexOutOfRangeException();
		IL_0157:
		result = null;
		goto IL_019a;
	}

	private static Vector3 Middle(GillaPieceId piece)
	{
		//IL_0293: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0515: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_02cd: Invalid comparison between F8 and I4
		//IL_02dc: Invalid comparison between F8 and I4
		//IL_02ef: Expected Obj, but got F8
		//IL_02fc: Expected Obj, but got F8
		//IL_0331: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0404: Invalid comparison between F8 and I4
		//IL_0413: Invalid comparison between F8 and I4
		//IL_0426: Expected Obj, but got F8
		//IL_0433: Expected Obj, but got F8
		//IL_047c: Expected Obj, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		Vector3 result;
		Bounds bounds2;
		if ((object)piece != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+20]");
						if ((nint)0 == 0)
						{
							goto IL_0277;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+20]");
						Bounds bounds = ((Renderer)0).bounds;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+18]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+18]");
						bool flag = (nint)0 < (nint)2;
						result = (Vector3)bounds;
						if (flag)
						{
							goto IL_02b0;
						}
						double num2 = default;
						double num = num2;
						double num4 = default;
						double num3 = num4;
						object obj4 = 5;
						while (true)
						{
							object obj5 = obj4 - 4;
							bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
							object obj6 = !flag2;
							if (obj6 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+v140 @ X20_v7*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+v140 @ X20_v7*8]");
								bounds2 = ((Renderer)0).bounds;
								double num5 = num3 - num;
								double num6 = num + num3;
								double num7 = num4 - num2;
								double num8 = num4 + num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v7+18]");
								obj3 = 0;
								obj4++;
								object obj7 = obj4 - 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num5 < num7))
								{
									num5 = num7;
								}
								double num9 = num6 - num7;
								bool flag3 = num9 < 0.0;
								bool flag4 = num9 == 0.0;
								object obj8 = num6 ^ num7;
								object obj9 = num6 ^ num9;
								object obj10 = obj8 & obj9;
								bool flag5 = (nint)obj10 < 0;
								bool flag6 = flag3 == flag5;
								object obj11 = !flag4;
								object obj12 = flag6 & obj11;
								object obj13 = ~obj12;
								if (obj13 == null)
								{
									num7 = num6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								double num10 = num7 - num5;
								double num11 = num10 * 0.5;
								double num12 = num5 + num11;
								double num13 = num12 - num11;
								double num14 = num11 + num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num13 < num8))
								{
									num13 = num8;
								}
								double num15 = num14 - num8;
								bool flag7 = num15 < 0.0;
								bool flag8 = num15 == 0.0;
								object obj14 = num14 ^ num8;
								object obj15 = num14 ^ num15;
								object obj16 = obj14 & obj15;
								bool flag9 = (nint)obj16 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
								bool flag10 = flag7 == flag9;
								object obj17 = !flag8;
								object obj18 = flag10 & obj17;
								object obj19 = ~obj18;
								if (obj19 == null)
								{
									num8 = num14;
								}
								double num16 = num8 - num13;
								num = num16 * 0.5;
								num3 = num13 + num;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
								{
									continue;
								}
								goto IL_022e;
							}
							goto IL_0277;
						}
					}
					goto IL_0285;
				}
				Transform transform = piece.transform;
				if ((object)transform != null)
				{
					result = transform.position;
					goto IL_02b0;
				}
			}
		}
		goto IL_0277;
		IL_02b0:
		return result;
		IL_0285:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Vector3)ex;
		IL_0277:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0285;
		IL_022e:
		result = (Vector3)bounds2;
		goto IL_02b0;
	}

	private unsafe static bool Cut(GillaPieceId piece, Vector3 point, Vector3 normal)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_3219: Expected F4, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_0032: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_0086: Expected VT, but got Ref
		//IL_028b: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_00ee: Expected VT, but got Ref
		//IL_02ea: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I4
		//IL_32a7: Expected Obj, but got I
		//IL_32b7: Expected I, but got Obj
		//IL_32d5: Expected F4, but got I4
		//IL_3c77: Expected F4, but got I4
		//IL_0334: Expected I, but got Obj
		//IL_0137: Expected VT, but got I4
		//IL_0137: Expected VT, but got I4
		//IL_1453: Unknown result type (might be due to invalid IL or missing references)
		//IL_1458: Expected I4, but got Unknown
		//IL_016e: Expected VT, but got I4
		//IL_016e: Expected VT, but got I4
		//IL_3c2c: Expected Obj, but got I
		//IL_3c56: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_01e0: Expected F4, but got I
		//IL_01fa: Invalid comparison between F4 and I
		//IL_0349: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I
		//IL_0369: Expected F4, but got Obj
		//IL_0379: Expected F4, but got I
		//IL_0381: Expected F4, but got Obj
		//IL_323c: Expected Obj, but got I
		//IL_3256: Expected Obj, but got I
		//IL_3267: Expected I, but got Obj
		//IL_3289: Expected Obj, but got I4
		//IL_022b: Expected F4, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_03b2: Expected VT, but got Obj
		//IL_03cd: Expected VT, but got Obj
		//IL_03dd: Expected VT, but got F4
		//IL_0415: Expected VT, but got Obj
		//IL_1304: Expected VT, but got Obj
		//IL_1314: Expected VT, but got F4
		//IL_134c: Expected VT, but got Obj
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got I
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_1382: Expected Obj, but got I
		//IL_1392: Expected Obj, but got I
		//IL_3bb0: Expected Obj, but got I
		//IL_3bb8: Expected VT, but got Obj
		//IL_3be1: Expected VT, but got Obj
		//IL_3be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c0f: Expected Obj, but got I4
		//IL_3adc: Expected Obj, but got I
		//IL_3ae4: Expected VT, but got Obj
		//IL_3af5: Expected VT, but got Obj
		//IL_3af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got I
		//IL_2970: Unknown result type (might be due to invalid IL or missing references)
		//IL_2978: Expected VT, but got Unknown
		//IL_13c1: Expected Obj, but got I4
		//IL_2867: Expected VT, but got Obj
		//IL_286b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_2a0a: Expected VT, but got I4
		//IL_0558: Invalid comparison between F4 and I4
		//IL_056b: Expected Obj, but got F4
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_28f9: Expected VT, but got Obj
		Enumerator<, > val = default;
		object obj = (object)(&val);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = (object)piece == null;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		float num8 = default;
		float num7 = num8;
		float num10 = default;
		float num9 = num10;
		float num11 = 0f;
		NullReferenceException ex12;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			List<(System.__Canon, System.__Canon)> list = (List<(System.__Canon, System.__Canon)>)0;
			Transform transform = piece.transform;
			nint num12 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj3 = default;
			IntPtr intPtr = default;
			Vector3 normal2 = default;
			if (!Across(piece, (Vector3)(&obj3), normal2, out *(float*)intPtr))
			{
				string name = piece.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj4 = 0;
				float num13 = (float)obj3 * 1.1204035E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75B0]");
				object format = 0;
				object obj5 = default;
				object obj6 = default;
				string text = string.Format((string)format, name, obj5, obj6);
				nint num14 = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v15 (Il2CppClass<System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>>)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				nint num15 = num14;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num15 = (nint)list;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X8_v16 (Il2CppClass<System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>>)+A0]");
				object obj8 = 0;
				obj8 = text;
				nint num16 = (nint)list;
				ref List<float> reference = ref *(List<float>*)null;
				object obj9 = obj5;
				object obj10 = obj6;
				float num17 = 1.1204035E+09f;
				string text2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				float num18 = 0f;
				return (byte)(num18 & 1) != 0;
			}
			bool flag4 = (object)transform == null;
			num = num2;
			num3 = num4;
			num5 = num6;
			num7 = num8;
			num9 = num10;
			float num19 = default;
			num11 = num19;
			Vector3 vector = (Vector3)(&obj3);
			if (!flag4)
			{
				Quaternion rotation = transform.rotation;
				Quaternion rotation2 = default;
				Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
				Vector3 position = transform.position;
				Vector3 vector2 = (Quaternion)0 * (Vector3)0;
				Quaternion rotation3 = transform.rotation;
				Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation2);
				Vector3 vector3 = (Quaternion)0 * (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X0_v47+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num20 = num19 * num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+44]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+44]");
				object obj14 = num21 * 0;
				float num22 = num20 + (float)obj14;
				object obj15 = default;
				float num23 = num22 + (float)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num24 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num25 = num23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num29;
				float num30;
				if (num25 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+40]");
					float num26 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+40]");
					float num27 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float num28 = num27 / 0f;
					num29 = num8 / num23;
					num30 = num28;
					num24 = num8;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ X8_v234+A0]");
					object obj18 = 0;
					num23 = (float)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1449 @ X8_v235+8]");
					num29 = 0f;
					num30 = (float)obj18;
					float num26 = num8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7410]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7418]");
				object obj20 = 0;
				List<System.__Canon> list2 = default;
				list2._002Ector();
				nint num31 = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ X0_v51 (Il2CppClass<System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.__Canon>>>)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				List<Source> list3 = Read(piece, transform, (Vector3)list2, (List<Mesh>)(nint)intPtr);
				bool flag7 = list3 == null;
				normal2 = (Vector3)list2;
				float num32 = num2;
				rotation2 = (Quaternion)num19;
				num = num4;
				num3 = num6;
				num5 = num6;
				num7 = num8;
				num9 = num10;
				num11 = num19;
				vector = (Vector3)transform;
				if (!flag7)
				{
					if (list3._size != 0)
					{
						Enumerator<, > enumerator = ((List<System.__Canon>)(object)list3).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7548]");
						object obj22 = 0;
						num7 = num8;
						num9 = num19;
						num11 = num10;
						Transform transform2;
						float num36;
						GillaPieceId gillaPieceId2;
						Enumerator<, > val2;
						GillaPieceId gillaPieceId;
						float num37;
						while (true)
						{
							System.__Canon _Canon = (System.__Canon)obj22;
							if (!val.MoveNext())
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+10]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v231+51]");
								bool flag8 = (nint)0 == 0;
								object obj24 = !flag8;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v231+54]");
									float num33 = 0f - num19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v231+5C]");
									float num34 = 0f - num8;
									float num35 = num30 * num33;
									num9 = num29 * num34;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									num11 = num9 + num35;
									bool flag9 = num11 < 0f;
									object obj25 = num11 ^ num11;
									object obj26 = num11 & obj25;
									bool flag10 = (nint)obj26 < 0;
									bool flag11 = flag9 == flag10;
									num7 = num30;
								}
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							normal2 = (Vector3)list2;
							val2 = (Enumerator<, >)(ref val);
							num = num4;
							num3 = num6;
							num5 = num6;
							gillaPieceId = piece;
							NullReferenceException ex2 = new NullReferenceException();
							NullReferenceException ex3 = new NullReferenceException();
							NullReferenceException ex4 = new NullReferenceException();
							NullReferenceException ex5 = new NullReferenceException();
							NullReferenceException ex6 = new NullReferenceException();
							NullReferenceException ex7 = new NullReferenceException();
							NullReferenceException ex8 = new NullReferenceException();
							vector = (Vector3)_Canon;
							NullReferenceException ex9 = new NullReferenceException();
							transform2 = transform;
							num36 = num2;
							gillaPieceId2 = piece;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							num37 = num8;
							throw new IndexOutOfRangeException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7538]");
						object obj27 = 0;
						vector = (Vector3)obj27;
						val.Dispose();
						transform2 = transform;
						num36 = num2;
						gillaPieceId2 = piece;
						normal2 = (Vector3)list2;
						val2 = (Enumerator<, >)(ref val);
						num = num4;
						num3 = num6;
						num5 = num6;
						list = null;
						gillaPieceId = (GillaPieceId)9;
						num37 = num8;
						throw new OutOfMemoryException();
					}
					bool flag12 = list2 == null;
					normal2 = (Vector3)list2;
					num32 = num2;
					rotation2 = (Quaternion)num19;
					num = num4;
					num3 = num6;
					num5 = num6;
					num7 = num8;
					num9 = num10;
					num11 = num19;
					vector = (Vector3)transform;
					if (!flag12)
					{
						Enumerator<, > enumerator2 = list2.GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
						GillaPieceId gillaPieceId = (GillaPieceId)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj28 = 0;
						Enumerator<, > val3 = default;
						while (val3.MoveNext())
						{
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ X0_v161+E4]");
							bool flag13 = (nint)0 == 0;
							object obj30 = !flag13;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X29_v1+30]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
						object obj31 = 0;
						vector = (Vector3)obj31;
						val3.Dispose();
						normal2 = (Vector3)list2;
						Enumerator<, > val2 = (Enumerator<, >)(ref val3);
						num = num4;
						num3 = num6;
						num5 = num6;
						num7 = num8;
						num9 = num10;
						float num38 = default;
						num11 = num38;
						float num37 = num8;
						OutOfMemoryException ex10 = new OutOfMemoryException();
						rotation2 = (Quaternion)val2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
						ArgumentNullException ex11 = new ArgumentNullException();
						ex12 = (NullReferenceException)(object)ex11;
						num32 = num2;
						vector = (Vector3)0;
						goto IL_38bd;
					}
				}
			}
		}
		NullReferenceException ex13 = new NullReferenceException();
		ex12 = ex13;
		goto IL_38bd;
		IL_38bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DAC4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	private static bool Across(GillaPieceId piece, Vector3 point, Vector3 normal, out float through)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.InvalidCastException: Cast from String to Int64 not supported.
		//    at ICSharpCode.Decompiler.Util.CSharpPrimitiveCast.CSharpPrimitiveCastUnchecked(TypeCode targetType, Object input) in /_/ICSharpCode.Decompiler/Util/CSharpPrimitiveCast.cs:line 767
		//    at ICSharpCode.Decompiler.Util.CSharpPrimitiveCast.Cast(TypeCode targetType, Object input, Boolean checkForOverflow) in /_/ICSharpCode.Decompiler/Util/CSharpPrimitiveCast.cs:line 44
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.HandleBinaryNumeric(BinaryNumericInstruction inst, BinaryOperatorType op, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 1773
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitBinaryNumericInstruction(BinaryNumericInstruction inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 1333
		//    at ICSharpCode.Decompiler.IL.BinaryNumericInstruction.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1070
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
		//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1394
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertLoop(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1354
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1325
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlock(Block block) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1311
		//    at ICSharpCode.Decompiler.IL.Block.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 882
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitIfInstruction(IfInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 162
		//    at ICSharpCode.Decompiler.IL.IfInstruction.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1440
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	private unsafe static List<Source> Read(GillaPieceId piece, Transform root, Vector3 point, List<Mesh> made)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_208d: Expected F4, but got I4
		//IL_007c: Expected F4, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00e9: Expected F4, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_0175: Expected VT, but got I4
		//IL_0182: Expected VT, but got I4
		//IL_019e: Expected F4, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01cc: Expected F4, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_01f4: Expected VT, but got I4
		//IL_2741: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_20ab: Expected Obj, but got I
		//IL_20b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b9: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I
		//IL_02b1: Expected I4, but got Obj
		//IL_02b9: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I4
		//IL_0372: Expected I4, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I
		//IL_05f9: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I4
		//IL_0681: Expected VT, but got I4
		//IL_0410: Expected VT, but got Obj
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_043f: Expected Obj, but got Ref
		//IL_06a4: Expected Obj, but got I
		//IL_0464: Expected Obj, but got Ref
		//IL_06d6: Expected Obj, but got I
		//IL_06df: Invalid comparison between VT and I4
		//IL_06f3: Expected VT, but got I4
		//IL_0487: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I4
		//IL_0719: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I
		//IL_0747: Expected I4, but got Obj
		//IL_0771: Expected VT, but got I4
		//IL_0504: Expected VT, but got I4
		//IL_07a7: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I4
		//IL_052f: Expected VT, but got I4
		//IL_0854: Expected Obj, but got I
		//IL_0864: Expected Obj, but got I
		//IL_0874: Expected VT, but got I
		//IL_0881: Expected Obj, but got VT
		//IL_0897: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_083f: Expected VT, but got I4
		//IL_0560: Expected Obj, but got I
		//IL_0581: Expected VT, but got I4
		//IL_08e0: Expected Obj, but got I
		//IL_05b1: Expected F4, but got VT
		//IL_05ca: Expected VT, but got I4
		//IL_211a: Expected Obj, but got I
		//IL_2132: Expected Obj, but got I
		//IL_2142: Expected F4, but got I
		//IL_2152: Expected F4, but got I
		//IL_2177: Expected VT, but got I
		//IL_217f: Expected VT, but got F4
		//IL_2187: Expected VT, but got F4
		//IL_21a4: Expected VT, but got Ref
		//IL_21ba: Expected Obj, but got I4
		//IL_21c2: Expected VT, but got F4
		//IL_21ca: Expected Obj, but got Ref
		//IL_09b0: Expected Obj, but got I
		//IL_21d7: Expected I, but got Obj
		//IL_21e7: Expected Obj, but got I
		//IL_2782: Expected Obj, but got I
		//IL_2793: Expected Obj, but got I
		//IL_279c: Expected Obj, but got F4
		//IL_27a4: Expected Obj, but got Ref
		//IL_09cf: Expected Obj, but got I
		//IL_09f8: Expected Obj, but got I
		//IL_0a30: Expected F4, but got I
		//IL_0a4e: Expected VT, but got I4
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_0a9a: Expected Obj, but got I
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0ad4: Expected Obj, but got I
		//IL_0af7: Expected Obj, but got I4
		//IL_0b4a: Expected F4, but got I
		//IL_0b68: Expected VT, but got I4
		//IL_0b8d: Expected Obj, but got I4
		//IL_0ba1: Expected Obj, but got I8
		//IL_0bd2: Expected F4, but got I
		//IL_2238: Unknown result type (might be due to invalid IL or missing references)
		//IL_223d: Expected Obj, but got Unknown
		//IL_2258: Unknown result type (might be due to invalid IL or missing references)
		//IL_225d: Expected Obj, but got Unknown
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected Obj, but got Unknown
		//IL_0c2f: Expected F4, but got I
		//IL_0c58: Expected Obj, but got I4
		//IL_0dfc: Expected Obj, but got I4
		//IL_2206: Expected Obj, but got I4
		//IL_221c: Expected VT, but got I4
		//IL_1492: Expected Obj, but got I4
		//IL_10e9: Expected Obj, but got I4
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected Obj, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected Obj, but got Unknown
		//IL_0cbd: Expected F4, but got Obj
		//IL_0d42: Expected Obj, but got F4
		//IL_0d4d: Expected Obj, but got I4
		//IL_0d8d: Expected F4, but got Obj
		//IL_0daf: Expected Obj, but got I4
		//IL_1432: Expected Obj, but got I4
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_1739: Expected Obj, but got Unknown
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected Obj, but got Unknown
		//IL_14a7: Expected Obj, but got I
		//IL_145f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1464: Expected Obj, but got Unknown
		//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e7: Expected Obj, but got Unknown
		//IL_22f5: Expected Obj, but got I4
		//IL_232b: Expected VT, but got I4
		//IL_1776: Expected Obj, but got I
		//IL_1515: Expected VT, but got Obj
		//IL_1525: Expected Obj, but got I4
		//IL_1140: Expected Obj, but got I8
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Expected Obj, but got Unknown
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Expected Obj, but got Unknown
		//IL_23b8: Expected Obj, but got I4
		//IL_23ce: Expected VT, but got I4
		//IL_17ce: Expected VT, but got Obj
		//IL_1543: Expected Obj, but got I
		//IL_18ef: Expected Obj, but got I
		//IL_18ff: Expected Obj, but got I
		//IL_1907: Expected Obj, but got Ref
		//IL_1910: Invalid comparison between F4 and I4
		//IL_27db: Expected Obj, but got I
		//IL_2805: Expected Obj, but got I4
		//IL_1c10: Expected Obj, but got I4
		//IL_17ee: Expected Obj, but got I4
		//IL_15d8: Expected VT, but got Obj
		//IL_15e8: Expected Obj, but got I4
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected Obj, but got Unknown
		//IL_0f59: Expected F4, but got I
		//IL_0f73: Invalid comparison between F4 and I
		//IL_247b: Expected VT, but got I4
		//IL_248b: Expected Obj, but got I4
		//IL_2823: Expected Obj, but got I
		//IL_284d: Expected Obj, but got I4
		//IL_0fc7: Expected I, but got Obj
		//IL_0fd7: Expected Obj, but got I
		//IL_0fdf: Expected F4, but got Obj
		//IL_0fef: Expected F4, but got I
		//IL_1c6c: Expected VT, but got I
		//IL_1c7c: Expected VT, but got I
		//IL_15fe: Expected I, but got Obj
		//IL_160e: Expected Obj, but got I
		//IL_165c: Expected VT, but got Obj
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a1: Expected Obj, but got Unknown
		//IL_1287: Expected F4, but got I
		//IL_12a1: Invalid comparison between F4 and I
		//IL_2290: Expected Obj, but got I4
		//IL_22ab: Expected Obj, but got I4
		//IL_22bb: Expected F4, but got Obj
		//IL_22c9: Expected VT, but got I4
		//IL_2567: Expected Obj, but got I
		//IL_2577: Expected Obj, but got I
		//IL_25c1: Expected VT, but got I
		//IL_1989: Expected Obj, but got I
		//IL_1814: Expected Obj, but got I4
		//IL_1845: Expected VT, but got I4
		//IL_1855: Expected Obj, but got I4
		//IL_12f5: Expected I, but got Obj
		//IL_1305: Expected Obj, but got I
		//IL_130d: Expected F4, but got Obj
		//IL_131d: Expected F4, but got I
		//IL_1ced: Expected VT, but got Obj
		//IL_1d3c: Expected VT, but got I4
		//IL_1d3c: Expected VT, but got I4
		//IL_167c: Expected Obj, but got I4
		//IL_1697: Expected Obj, but got I4
		//IL_16cc: Expected VT, but got Obj
		//IL_2366: Expected Obj, but got I4
		//IL_237e: Expected F4, but got I
		//IL_238c: Expected VT, but got I4
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected Obj, but got Unknown
		//IL_100f: Expected Obj, but got F4
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Expected Obj, but got Unknown
		//IL_1027: Expected Obj, but got I4
		//IL_103f: Expected F4, but got Obj
		//IL_1d66: Expected F4, but got I
		//IL_1d86: Invalid comparison between F4 and I4
		//IL_1dc9: Expected VT, but got I4
		//IL_1dd1: Expected Obj, but got Ref
		//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8f: Expected Obj, but got Unknown
		//IL_1c9f: Expected VT, but got I
		//IL_1caf: Expected VT, but got I
		//IL_19c1: Expected Obj, but got I4
		//IL_2872: Unknown result type (might be due to invalid IL or missing references)
		//IL_2877: Expected Obj, but got Unknown
		//IL_287f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2884: Expected Obj, but got Unknown
		//IL_289c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a1: Expected Obj, but got Unknown
		//IL_28bd: Invalid comparison between F8 and Obj
		//IL_2514: Expected Obj, but got I4
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ad: Expected Obj, but got Unknown
		//IL_18c4: Expected VT, but got I4
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_1335: Expected Obj, but got Unknown
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348: Expected Obj, but got Unknown
		//IL_1352: Expected Obj, but got I4
		//IL_1372: Expected F4, but got I
		//IL_13a9: Expected Obj, but got I4
		//IL_13b9: Expected F4, but got I
		//IL_13cb: Expected Obj, but got I4
		//IL_1075: Expected F4, but got Obj
		//IL_10ab: Expected Obj, but got I4
		//IL_1dfc: Expected Obj, but got I
		//IL_1e17: Expected I4, but got Obj
		//IL_1e59: Expected VT, but got I4
		//IL_1e61: Expected Obj, but got Ref
		//IL_1cc9: Expected F8, but got Obj
		//IL_25e7: Invalid comparison between F8 and I4
		//IL_25f6: Invalid comparison between F8 and I4
		//IL_2604: Unknown result type (might be due to invalid IL or missing references)
		//IL_2609: Expected Obj, but got Unknown
		//IL_2616: Expected Obj, but got F8
		//IL_265f: Expected Obj, but got I4
		//IL_2667: Unknown result type (might be due to invalid IL or missing references)
		//IL_266c: Expected Obj, but got Unknown
		//IL_19e3: Expected Obj, but got I
		//IL_1e86: Expected Obj, but got I4
		//IL_1ea6: Expected Obj, but got I4
		//IL_1cdb: Expected F8, but got Obj
		//IL_1f31: Expected Obj, but got I
		//IL_1f41: Expected Obj, but got I
		//IL_1f51: Expected VT, but got I
		//IL_268c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2691: Expected Obj, but got Unknown
		//IL_26d6: Expected VT, but got Obj
		//IL_26e8: Expected VT, but got F8
		//IL_1f7b: Expected Obj, but got I
		//IL_1f8b: Expected Obj, but got I
		//IL_1f9b: Expected Obj, but got I
		//IL_1fab: Expected VT, but got I
		//IL_1fbb: Expected VT, but got F4
		//IL_1fc3: Expected VT, but got F4
		//IL_1fd6: Expected Obj, but got I4
		//IL_1ff7: Expected VT, but got I4
		//IL_1ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecb: Expected Obj, but got Unknown
		//IL_1ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef9: Expected Obj, but got Unknown
		//IL_1f14: Expected VT, but got I4
		//IL_1bcc: Expected Obj, but got I
		//IL_1bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bda: Expected Obj, but got Unknown
		//IL_1a71: Expected Obj, but got I
		//IL_1a81: Expected Obj, but got I
		//IL_1a8a: Expected Obj, but got I4
		//IL_24a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a7: Expected Obj, but got Unknown
		//IL_24c0: Expected Obj, but got I4
		//IL_1aa8: Expected Obj, but got I4
		//IL_1af9: Expected Obj, but got I
		//IL_1b29: Expected Obj, but got I4
		//IL_1b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7f: Expected Obj, but got Unknown
		//IL_1ba6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityEngine.Object obj3 = (UnityEngine.Object)obj2;
		List<System.__Canon> list = default;
		list._002Ector();
		bool flag = (object)root == null;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		Vector3 vector = point;
		float num7 = 0f;
		NullReferenceException ex = default;
		if (!flag)
		{
			Quaternion rotation = root.rotation;
			Quaternion q = default;
			Quaternion quaternion = Quaternion.Internal_Inverse(ref q);
			bool flag2 = (object)piece == null;
			num = num2;
			num3 = num4;
			num5 = num6;
			vector = point;
			num7 = 0f;
			obj3 = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
				object obj4 = 0;
				obj3 = (UnityEngine.Object)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				object obj5 = default;
				bool flag3 = obj5 == null;
				num = num2;
				num3 = num4;
				num5 = num6;
				vector = point;
				num7 = 0f;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v14+18]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v14+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_1ffc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A38]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A30]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					List<Vector4> list2 = (List<Vector4>)0;
					Bounds bounds = (Bounds)0;
					Matrix4x4 matrix4x = (Matrix4x4)0;
					num = num2;
					num3 = num4;
					float num8 = 0f;
					num5 = num6;
					MeshFilter meshFilter = null;
					vector = point;
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
					num7 = 0f;
					double num9 = 0.5;
					int num10 = 17281024;
					object obj11 = 63;
					q = (Quaternion)0;
					object obj16 = default;
					Mesh mesh2 = default;
					Vector3 pos = default;
					Vector3 s = default;
					Quaternion q2 = default;
					float num20 = default;
					object obj37 = default;
					float num24 = default;
					float num25 = default;
					float num26 = default;
					Source source = default;
					object obj42 = default;
					object obj55 = default;
					float num38 = default;
					object obj56 = default;
					float num40 = default;
					float num42 = default;
					float num45 = default;
					object obj57 = default;
					float num49 = default;
					Vector3 s2 = default;
					object obj65 = default;
					float num57 = default;
					object obj75 = default;
					object obj76 = default;
					float num68 = default;
					float num59 = default;
					List<Vector4> list5 = default;
					object obj111 = default;
					Vector3 point2 = default;
					while (true)
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj12 = !flag4;
						if (obj12 != null)
						{
							goto IL_2001;
						}
						object obj13 = obj5 + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
						Renderer renderer = (Renderer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
						bool enabled = ((Renderer)0).enabled;
						bool flag5 = !enabled;
						obj3 = null;
						float num18;
						float num19;
						Mesh mesh;
						List<Mesh> list3;
						Vector3 vector2;
						int num11;
						object obj18;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
							Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
							bool flag6 = sharedMaterials == null;
							obj3 = null;
							if (!flag6)
							{
								num11 = (int)obj7;
								nint num12 = (nint)renderer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v14 (Il2CppClass<UnityEngine.Renderer>)+130]");
								num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v14 (Il2CppClass<UnityEngine.Renderer>)+130]");
								nint num13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v8 (System.Int32)+130]");
								bool flag7 = num13 < 0;
								object obj14 = !flag7;
								object obj15 = ~obj14;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v14 (Il2CppClass<UnityEngine.Renderer>)+B0]");
									obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v14 (Il2CppClass<UnityEngine.Renderer>)+B0]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v8 (System.Int32)+130]");
									object obj17 = num14 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ X11_v16-8]");
									obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1589 @ X11_v16-8]");
									if ((nint)0 == num11)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
										Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
										nint num15 = (nint)list2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ X8_v115 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>>)+E4]");
										num10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ X8_v115 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>>)+E4]");
										bool flag8 = (nint)0 == 0;
										object obj19 = !flag8;
										if (obj19 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag9 = sharedMesh == null;
										bool flag10 = !flag9;
										object obj20 = !flag10;
										mesh = sharedMesh;
										vector = (Vector3)0;
										obj3 = null;
										if (obj20 != null)
										{
											goto IL_209b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
										object obj21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										mesh2._002Ector();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
										((SkinnedMeshRenderer)0).BakeMesh(mesh2, useScale: false);
										bool flag11 = point == (Vector3)(object)0;
										list3 = null;
										vector = (Vector3)0;
										obj3 = mesh2;
										if (flag11)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+10]");
										object obj22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
										object obj23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+1C]");
										object obj24 = (nint)0 + (nint)1;
										num10 = (int)obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+10]");
										bool flag12 = (nint)0 == 0;
										list3 = null;
										vector = (Vector3)0;
										obj3 = mesh2;
										if (flag12)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+18]");
										num11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v118+18]");
										obj18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+18]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v118+18]");
										bool flag13 = num16 < 0;
										object obj25 = !flag13;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+10]");
											nint num17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+18]");
											object obj26 = num17 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ X2 (UnityEngine.Vector3)+18]");
											num10 = (int)((nint)0 + (nint)1);
											object obj27 = obj26 + 32;
											obj27 = mesh2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											vector = (Vector3)0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X9_v9 (System.Int32)+20]");
											object obj28 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ X8_v129+A8]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1644 @ X8_v130+70]");
											vector = (Vector3)0;
											((List<System.__Canon>)point).AddWithResize((System.__Canon)(object)mesh2);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
										Transform transform = ((Component)0).transform;
										bool flag14 = (object)transform == null;
										list3 = null;
										obj3 = null;
										if (flag14)
										{
											break;
										}
										Vector3 position = transform.position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
										Transform transform2 = ((Component)0).transform;
										bool flag15 = (object)transform2 == null;
										list3 = null;
										obj3 = null;
										if (flag15)
										{
											break;
										}
										Quaternion rotation2 = transform2.rotation;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										object obj30 = 0;
										object obj31 = obj30;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X8_v125+A0]");
										object obj32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X8_v126+C]");
										num18 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X8_v126+14]");
										num19 = 0f;
										Matrix4x4 matrix4x2 = Matrix4x4.Internal_TRS(ref pos, ref q, ref s);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X8_v126+C]");
										s = (Vector3)0;
										q2 = (Quaternion)num7;
										vector2 = (Vector3)num3;
										list3 = null;
										num8 = num20;
										mesh = mesh2;
										vector = (Vector3)(&s);
										num9 = 0.5;
										obj11 = 63;
										q = (Quaternion)num7;
										obj3 = (UnityEngine.Object)(&q);
										goto IL_20dd;
									}
								}
								num11 = (int)obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v8 (System.Int32)+130]");
								obj18 = 0;
								int num21 = num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v8 (System.Int32)+130]");
								bool flag16 = (nint)num21 < (nint)0;
								object obj33 = !flag16;
								object obj34 = ~obj33;
								obj3 = null;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X8_v14 (Il2CppClass<UnityEngine.Renderer>)+B0]");
									nint num22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v8 (System.Int32)+130]");
									object obj35 = num22 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ X8_v111-8]");
									bool flag17 = (nint)0 != num11;
									obj3 = null;
									if (!flag17)
									{
										vector = (Vector3)obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
										object obj36 = obj37 & 1;
										bool flag18 = obj36 == null;
										obj3 = (UnityEngine.Object)(&meshFilter);
										if (!flag18)
										{
											bool flag19 = (object)meshFilter == null;
											obj3 = (UnityEngine.Object)(&meshFilter);
											if (flag19)
											{
												break;
											}
											Mesh sharedMesh2 = meshFilter.sharedMesh;
											nint num23 = (nint)list2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v113 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>>)+E4]");
											num10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v113 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>>)+E4]");
											bool flag20 = (nint)0 == 0;
											object obj38 = !flag20;
											if (obj38 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag21 = sharedMesh2 != null;
											bool flag22 = !flag21;
											mesh = sharedMesh2;
											vector = (Vector3)0;
											obj3 = null;
											if (!flag22)
											{
												bool flag23 = (object)meshFilter == null;
												vector = (Vector3)0;
												obj3 = null;
												if (flag23)
												{
													break;
												}
												Mesh sharedMesh3 = meshFilter.sharedMesh;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
												Transform transform3 = ((Component)0).transform;
												bool flag24 = (object)transform3 == null;
												vector = (Vector3)0;
												obj3 = null;
												if (flag24)
												{
													break;
												}
												Matrix4x4 localToWorldMatrix = transform3.localToWorldMatrix;
												num3 = num24;
												num8 = (float)q;
												num19 = num25;
												mesh = sharedMesh3;
												vector = (Vector3)0;
												num18 = num26;
												obj3 = null;
												goto IL_20dd;
											}
										}
									}
								}
							}
						}
						goto IL_209b;
						IL_209b:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v14+18]");
						obj6 = 0;
						obj10++;
						object obj39 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v14+18]");
						if ((nint)obj39 < 0)
						{
							continue;
						}
						goto IL_1ffc;
						IL_1759:
						int subMeshCount = mesh.subMeshCount;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67A0]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj41 = source + 64;
						obj41 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int subMeshCount2 = mesh.subMeshCount;
						bool flag25 = subMeshCount2 < 1;
						List<Vector4> list4;
						vector = (Vector3)list4;
						float num29;
						float num31;
						float num32;
						float num33;
						float num34;
						float num35;
						float num28;
						float num30;
						if (!flag25)
						{
							int num27 = 0;
							object obj43 = 32;
							while (true)
							{
								object obj44 = obj41;
								int[] triangles = mesh.GetTriangles(num27);
								bool flag26 = obj41 == null;
								num28 = num29;
								num30 = num31;
								num = num32;
								num3 = num33;
								num5 = num34;
								vector = (Vector3)0;
								num7 = num35;
								obj3 = (UnityEngine.Object)num27;
								if (flag26)
								{
									break;
								}
								int num36 = num27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X23_v21+18]");
								bool flag27 = (nint)num36 < (nint)0;
								object obj45 = !flag27;
								num28 = num29;
								num30 = num31;
								num = num32;
								num3 = num33;
								num5 = num34;
								vector = (Vector3)0;
								num7 = num35;
								obj3 = (UnityEngine.Object)num27;
								if (obj45 == null)
								{
									object obj46 = obj41 + obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num27++;
									int subMeshCount3 = mesh.subMeshCount;
									obj43 += 8;
									bool flag28 = num27 < subMeshCount3;
									vector = (Vector3)0;
									if (flag28)
									{
										continue;
									}
									goto IL_18d2;
								}
								goto IL_2001;
							}
							break;
						}
						goto IL_18d2;
						IL_0dcd:
						Vector3[] normals;
						bool flag29 = normals == null;
						Vector3[] array = normals;
						object obj48;
						object obj49;
						List<Vector4>[] array2;
						if (!flag29)
						{
							object obj47 = normals.Length;
							if (normals.Length == (nint)obj48)
							{
								bool flag30 = (nint)obj48 < 1;
								array = normals;
								if (!flag30)
								{
									obj49 = normals + 40;
									list2 = null;
									while (true)
									{
										bool flag31 = System.Runtime.CompilerServices.Unsafe.As<List<Vector4>, UIntPtr>(ref list2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
										object obj50 = !flag31;
										num28 = num29;
										num30 = num31;
										num = num32;
										list3 = null;
										num3 = num33;
										num5 = num34;
										vector = (Vector3)0;
										num7 = num35;
										obj3 = null;
										if (obj50 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj51 = 0;
										object obj52 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X0_v132+E4]");
										bool flag32 = (nint)0 == 0;
										object obj53 = !flag32;
										if (obj53 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj54 = num18 * obj55;
										float num37 = num38 * (float)obj56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X20_v30-8]");
										float num39 = 0f * num40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X20_v30-4]");
										float num41 = 0f * num42;
										float num43 = (float)obj54 + num37;
										float num44 = num45 * (float)obj57;
										float num46 = num43 + num44;
										float num47 = num39 + num41;
										float num48 = (float)obj49 * num49;
										float num50 = num47 + num48;
										float num51 = num46 * num46;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										float num52 = num50 * num50;
										num3 = num51 + num52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										num = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										float num53 = num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										if (num53 > 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											num5 = num50 / num3;
											float num54 = num46;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
											num7 = num54 / 0f;
										}
										else
										{
											nint num55 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v100 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+A0]");
											object obj58 = 0;
											num7 = (float)obj58;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2208 @ X8_v101+8]");
											num5 = 0f;
										}
										obj47 = normals.Length;
										bool flag33 = (nint)list2 < normals.Length;
										object obj59 = !flag33;
										num28 = num29;
										num30 = (float)obj49;
										list3 = null;
										vector = (Vector3)0;
										obj3 = null;
										if (obj59 != null)
										{
											break;
										}
										list2 = (List<Vector4>)(list2 + 1);
										obj49 = num5;
										obj49 += 12;
										obj48 = normals.Length;
										bool flag34 = (nint)list2 < normals.Length;
										num31 = (float)obj49;
										num32 = num;
										num33 = num3;
										num34 = num5;
										num35 = num7;
										if (flag34)
										{
											continue;
										}
										goto IL_106d;
									}
									goto IL_2001;
								}
							}
							else
							{
								array = null;
							}
						}
						goto IL_222f;
						IL_20dd:
						bool flag35 = (object)mesh == null;
						num5 = num19;
						num7 = num18;
						if (flag35)
						{
							break;
						}
						bool isReadable = mesh.isReadable;
						bool flag36 = !isReadable;
						num5 = num19;
						num7 = num18;
						obj3 = null;
						Vector3[] vertices;
						if (!flag36)
						{
							int vertexCount = mesh.vertexCount;
							bool flag37 = vertexCount == 0;
							num5 = num19;
							num7 = num18;
							obj3 = null;
							if (!flag37)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								array2 = (List<Vector4>[])0;
								nint num56 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1728 @ X8_v19 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+A0]");
								object obj60 = 0;
								Matrix4x4 matrix4x3 = Matrix4x4.Internal_TRS(ref s, ref q2, ref s2);
								Vector3 position2 = root.position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1738 @ X8_v21+C]");
								object obj61 = -0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1738 @ X8_v21+14]");
								object obj62 = -0;
								object obj63 = 0f - num2;
								object obj64 = (object)(&obj65);
								_ = 0;
								_ = 0;
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75E8]");
								object obj66 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								source._002Ector();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
								string name = ((UnityEngine.Object)0).name;
								bool flag38 = source == null;
								num28 = num26;
								num30 = num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
								num = 0f;
								list3 = null;
								num3 = num57;
								num5 = num38;
								vector = (Vector3)0;
								num7 = num45;
								obj3 = null;
								if (flag38)
								{
									break;
								}
								object obj67 = source + 16;
								obj67 = name;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
								Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
								object obj68 = source + 72;
								obj68 = sharedMaterials2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v11+20]");
								ShadowCastingMode shadowCastingMode = ((Renderer)0).shadowCastingMode;
								bool flag39 = shadowCastingMode == 0;
								object obj69 = !flag39;
								vertices = mesh.vertices;
								normals = mesh.normals;
								bool flag40 = vertices == null;
								num28 = num26;
								num30 = num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
								num = 0f;
								list3 = null;
								num3 = num57;
								num5 = num38;
								vector = (Vector3)0;
								num7 = num45;
								obj3 = null;
								if (flag40)
								{
									break;
								}
								object obj47 = vertices.Length;
								obj48 = vertices.Length & 0xFFFFFFFFL;
								bool flag41 = vertices.Length < 1;
								num29 = num26;
								num31 = num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
								num32 = 0f;
								num33 = num57;
								num34 = num38;
								num35 = num45;
								if (flag41)
								{
									goto IL_0dcd;
								}
								object obj70 = vertices + 40;
								float num58 = num59;
								num28 = num26;
								num30 = num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
								num = 0f;
								num3 = num57;
								num5 = num38;
								object obj71 = obj48;
								num7 = num45;
								object obj72 = 0;
								while (true)
								{
									bool flag42 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj72) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71);
									object obj73 = !flag42;
									num59 = num58;
									list3 = null;
									vector = (Vector3)0;
									obj3 = null;
									if (obj73 != null)
									{
										break;
									}
									obj47 = obj72 + 1;
									object obj74 = num18 * obj75;
									float num60 = num38 * (float)obj76;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ X9_v54-8]");
									float num61 = 0f * num40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ X9_v54-4]");
									float num62 = 0f * num42;
									num31 = (float)obj70;
									num29 = num45 * (float)obj57;
									float num63 = (float)obj74 + num60;
									float num64 = (float)obj70 * num49;
									float num65 = num61 + num62;
									float num66 = num63 + num29;
									float num67 = num65 + num64;
									num34 = num57 + num66;
									num35 = num68 + num67;
									obj70 = num35;
									obj48 = vertices.Length;
									bool flag43 = (nint)obj47 < vertices.Length;
									num59 = num49;
									num32 = num68;
									num33 = num57;
									num58 = num49;
									num28 = num29;
									num30 = (float)obj70;
									num = num68;
									num3 = num57;
									num5 = num34;
									obj71 = vertices.Length;
									num7 = num35;
									obj72 = obj47;
									if (flag43)
									{
										continue;
									}
									goto IL_0dcd;
								}
								goto IL_2001;
							}
						}
						goto IL_209b;
						IL_13fe:
						Color[] colors = mesh.colors;
						if (colors != null)
						{
							object obj47 = colors.Length;
							if (colors.Length == vertices.Length)
							{
								object obj77 = source + 48;
								obj77 = colors;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
						}
						list3 = null;
						int num69 = 0;
						object obj78 = 32;
						while (true)
						{
							VertexAttribute attr = (VertexAttribute)(num69 + 4);
							bool flag44 = mesh.HasVertexAttribute(attr);
							bool flag45 = !flag44;
							list4 = null;
							if (!flag45)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
								object obj79 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								list5._002Ector();
								mesh.GetUVs(num69, list5);
								bool flag46 = (object)list5 == null;
								num28 = num29;
								num30 = num31;
								num = num32;
								list3 = null;
								num3 = num33;
								num5 = num34;
								vector = (Vector3)list5;
								num7 = num35;
								obj3 = (UnityEngine.Object)num69;
								if (flag46)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X0_v105 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X0_v105 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
								bool flag47 = (nint)0 != vertices.Length;
								list3 = null;
								list4 = list5;
								list2 = list5;
								if (!flag47)
								{
									array2 = source.uvs;
									bool flag48 = source.uvs == null;
									num28 = num29;
									num30 = num31;
									num = num32;
									list3 = null;
									num3 = num33;
									num5 = num34;
									vector = (Vector3)list5;
									num7 = num35;
									obj3 = (UnityEngine.Object)num69;
									if (flag48)
									{
										break;
									}
									nint num70 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v62 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+40]");
									obj3 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag49 = ex == null;
									num28 = num29;
									num30 = num31;
									num = num32;
									list3 = null;
									num3 = num33;
									num5 = num34;
									vector = (Vector3)list5;
									num7 = num35;
									if (flag49)
									{
										goto IL_201d;
									}
									obj47 = array2.Length;
									bool flag50 = num69 < array2.Length;
									object obj80 = !flag50;
									num28 = num29;
									num30 = num31;
									num = num32;
									list3 = null;
									num3 = num33;
									num5 = num34;
									vector = (Vector3)list5;
									num7 = num35;
									if (obj80 != null)
									{
										goto IL_2001;
									}
									object obj81 = (object)source.uvs + obj78;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									list3 = null;
									list4 = list5;
									list2 = list5;
								}
							}
							num69++;
							obj78 += 8;
							if (num69 != 8)
							{
								continue;
							}
							goto IL_1759;
						}
						break;
						IL_2001:
						IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
						break;
						IL_13d9:
						object obj82 = source + 40;
						Vector4[] tangents;
						obj82 = tangents;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						goto IL_13fe;
						IL_106d:
						num31 = (float)obj49;
						num32 = num;
						num33 = num3;
						num34 = num5;
						num35 = num7;
						num9 = 0.5;
						obj11 = 63;
						array = normals;
						goto IL_222f;
						IL_222f:
						object obj83 = source + 24;
						obj83 = vertices;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj84 = source + 32;
						obj84 = array;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						tangents = mesh.tangents;
						if (tangents != null)
						{
							object obj47 = tangents.Length;
							if (tangents.Length == vertices.Length)
							{
								if (tangents.Length < 1)
								{
									goto IL_13d9;
								}
								object obj85 = tangents.Length & 0xFFFFFFFFL;
								object obj86 = tangents + 44;
								num30 = num31;
								num = num32;
								num3 = num33;
								num5 = num34;
								num7 = num35;
								List<Vector4> list6 = null;
								while (true)
								{
									bool flag51 = System.Runtime.CompilerServices.Unsafe.As<List<Vector4>, UIntPtr>(ref list6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj85);
									object obj87 = !flag51;
									num28 = num29;
									list3 = null;
									vector = (Vector3)0;
									obj3 = null;
									if (obj87 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									object obj88 = 0;
									object obj89 = obj88;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X0_v121+E4]");
									bool flag52 = (nint)0 == 0;
									object obj90 = !flag52;
									if (obj90 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj91 = num18 * obj55;
									float num71 = num38 * (float)obj56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-C]");
									float num72 = 0f * num40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-8]");
									float num73 = 0f * num42;
									float num74 = (float)obj91 + num71;
									float num75 = num45 * (float)obj57;
									float num76 = num74 + num75;
									float num77 = num72 + num73;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-4]");
									float num78 = 0f * num49;
									float num79 = num77 + num78;
									float num80 = num76 * num76;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									float num81 = num79 * num79;
									num3 = num80 + num81;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									num = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num82 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									if (num82 > 0f)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										num5 = num79 / num3;
										float num83 = num76;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										num7 = num83 / 0f;
									}
									else
									{
										nint num84 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ X8_v82 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+A0]");
										object obj92 = 0;
										num7 = (float)obj92;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2306 @ X8_v83+8]");
										num5 = 0f;
									}
									bool flag53 = (nint)list6 < tangents.Length;
									object obj93 = !flag53;
									num28 = num29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-4]");
									num30 = 0f;
									list3 = null;
									vector = (Vector3)0;
									obj3 = null;
									if (obj93 != null)
									{
										break;
									}
									list2 = (List<Vector4>)(list6 + 1);
									obj86 += 16;
									obj47 = tangents.Length;
									bool flag54 = (nint)list2 < tangents.Length;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-4]");
									num31 = 0f;
									num32 = num;
									num33 = num3;
									num34 = num5;
									num35 = num7;
									num9 = 0.5;
									obj11 = 63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ X20_v27-4]");
									num30 = 0f;
									list6 = list2;
									obj85 = tangents.Length;
									if (flag54)
									{
										continue;
									}
									goto IL_13d9;
								}
								goto IL_2001;
							}
						}
						goto IL_13fe;
						IL_1c06:
						object obj94 = vertices.Length;
						bool flag55 = vertices.Length == 0;
						num28 = num29;
						num30 = num31;
						num = num32;
						num3 = num33;
						num5 = num34;
						obj3 = null;
						if (flag55)
						{
							goto IL_2001;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v54 (UnityEngine.Vector3[])+20]");
						Vector3 vector3 = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v54 (UnityEngine.Vector3[])+28]");
						vector2 = (Vector3)0;
						object obj96;
						object obj95 = obj96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2424 @ X9_v24+A0]");
						object obj97 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X9_v25+8]");
						object obj98 = 0;
						object obj99 = obj97 * obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X9_v25+8]");
						double num85 = 0.0 * num9;
						bool flag56 = vertices.Length < 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v54 (UnityEngine.Vector3[])+20]");
						bounds = (Bounds)0;
						if (!flag56)
						{
							object obj100 = vertices + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v54 (UnityEngine.Vector3[])+28]");
							Vector3 vector4 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ X0_v54 (UnityEngine.Vector3[])+20]");
							Vector3 vector5 = (Vector3)0;
							object obj101 = obj99;
							bool flag61;
							do
							{
								double num86 = (double)vector4 - num85;
								obj98 = vector5 - obj101;
								object obj102 = vector5 + obj101;
								double num87 = (double)vector4 + num85;
								obj100 += 12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num86) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj100))
								{
									num86 = (double)obj100;
								}
								double num88 = num87 - (double)obj100;
								bool flag57 = num88 < 0.0;
								bool flag58 = num88 == 0.0;
								object obj103 = num87 ^ obj100;
								object obj104 = num87 ^ num88;
								object obj105 = obj103 & obj104;
								bool flag59 = (nint)obj105 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								bool flag60 = flag57 == flag59;
								object obj106 = !flag58;
								object obj107 = flag60 & obj106;
								object obj108 = ~obj107;
								if (obj108 != null)
								{
									num87 = (double)obj100;
								}
								obj94--;
								object obj109 = obj102 - obj98;
								double num89 = num87 - num86;
								obj99 = obj109 * obj11;
								num85 = num89 * num9;
								vector3 = (Vector3)(obj98 + obj99);
								vector2 = (Vector3)(num86 + num85);
								flag61 = (nint)obj94 != 1;
								bounds = (Bounds)vector3;
								vector4 = vector2;
								vector5 = vector3;
								obj101 = obj99;
							}
							while (flag61);
						}
						object obj110;
						source.bounds = (Bounds)obj110;
						_ = 0;
						Vector3 position3 = root.position;
						num28 = num6 - (float)obj99;
						num59 = num4 - (float)obj98;
						num30 = (float)obj111 - (float)obj110;
						Vector3 vector6 = (Quaternion)0 * (Vector3)0;
						num7 = bounds.Internal_SqrDistance(ref point2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC08]");
						num5 = 0f;
						float num90 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC08]");
						float num91 = num90 - 0f;
						bool cut = num91 < 0f;
						source.cut = cut;
						bool flag62 = list == null;
						object obj112 = obj111;
						num = num2;
						num3 = num4;
						vector = (Vector3)0;
						obj3 = (UnityEngine.Object)(&point2);
						if (flag62)
						{
							break;
						}
						System.__Canon[] items = list._items;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75E0]");
						object obj113 = 0;
						int version = list._version + 1;
						num10 = (int)obj113;
						list._version = version;
						bool flag63 = list._items == null;
						obj112 = obj111;
						num = num2;
						num3 = num4;
						vector = (Vector3)0;
						obj3 = (UnityEngine.Object)(&point2);
						if (flag63)
						{
							break;
						}
						num11 = list._size;
						obj18 = items.Length;
						bool flag64 = list._size < items.Length;
						object obj114 = !flag64;
						if (obj114 == null)
						{
							object obj115 = list._items + list._size;
							num10 = list._size + 1;
							list._size = num10;
							object obj116 = obj115 + 32;
							obj116 = source;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							vector = (Vector3)0;
							obj3 = (UnityEngine.Object)(object)source;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X9_v9 (System.Int32)+20]");
							object obj117 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2621 @ X8_v49+A8]");
							object obj118 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2624 @ X8_v50+70]");
							vector = (Vector3)0;
							list.AddWithResize((System.__Canon)(object)source);
							obj3 = (UnityEngine.Object)(object)source;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A38]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A30]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D8]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1738 @ X8_v21+C]");
						s2 = (Vector3)0;
						obj112 = obj111;
						matrix4x = (Matrix4x4)num18;
						Quaternion quaternion2 = (Quaternion)num7;
						float num92 = num8;
						obj65 = 1065353216;
						Vector3 vector7 = point2;
						num = num2;
						num3 = num4;
						q = (Quaternion)0;
						goto IL_209b;
						IL_18d2:
						num7 = matrix4x.GetDeterminant();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						list2 = (List<Vector4>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						obj96 = 0;
						obj110 = (object)(&bounds);
						if (num7 < 0f)
						{
							object obj119 = obj41;
							bool flag65 = obj41 == null;
							num28 = num29;
							num30 = num31;
							num = num32;
							num3 = num33;
							num5 = num34;
							obj3 = null;
							if (flag65)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v54+18]");
							object obj120 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v54+18]");
							if ((nint)0 >= (nint)1)
							{
								object obj121 = obj16;
								object obj122 = 0;
								while (true)
								{
									bool flag66 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj122) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj120);
									object obj123 = !flag66;
									num28 = num29;
									num30 = num31;
									num = num32;
									num3 = num33;
									num5 = num34;
									obj3 = null;
									if (obj123 != null)
									{
										break;
									}
									object obj124 = obj41 + obj122;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ X10_v20+20]");
									object obj125 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ X10_v20+20]");
									bool flag67 = (nint)0 == 0;
									num28 = num29;
									num30 = num31;
									num = num32;
									num3 = num33;
									num5 = num34;
									obj3 = null;
									if (flag67)
									{
										goto end_IL_2728;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v21+18]");
									if ((nint)0 >= (nint)3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ X10_v20+20]");
										obj18 = (nint)0 + (nint)32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v21+18]");
										object obj126 = 0;
										object obj127 = 2;
										while (true)
										{
											object obj128 = obj127 - 1;
											bool flag68 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj128) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126);
											object obj129 = !flag68;
											num28 = num29;
											num30 = num31;
											num = num32;
											num3 = num33;
											num5 = num34;
											obj3 = null;
											if (obj129 != null)
											{
												break;
											}
											bool flag69 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj127) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126);
											object obj130 = !flag69;
											num28 = num29;
											num30 = num31;
											num = num32;
											num3 = num33;
											num5 = num34;
											obj3 = null;
											if (obj130 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2501 @ X10_v20+20]");
											object obj131 = (nint)0 + (nint)32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2614 @ X13_v12+v1360 @ X12_v12*4]");
											_ = 0;
											object obj132 = obj127;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v21+18]");
											bool flag70 = (nint)obj132 < 0;
											object obj133 = !flag70;
											num28 = num29;
											num30 = num31;
											num = num32;
											num3 = num33;
											num5 = num34;
											obj3 = null;
											if (obj133 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2614 @ X13_v12+v1304 @ X14_v11*4]");
											_ = 0;
											obj121 = obj127 + 3;
											object obj134 = obj121;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v21+18]");
											bool flag71 = (nint)obj134 < 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v21+18]");
											obj126 = 0;
											obj127 = obj121;
											if (flag71)
											{
												continue;
											}
											goto IL_1bbc;
										}
										break;
									}
									goto IL_1bbc;
									IL_1bbc:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v54+18]");
									obj120 = 0;
									obj122++;
									object obj135 = obj122;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v54+18]");
									bool flag72 = (nint)obj135 < 0;
									obj16 = obj121;
									if (flag72)
									{
										continue;
									}
									goto IL_1c06;
								}
								goto IL_2001;
							}
						}
						goto IL_1c06;
						continue;
						end_IL_2728:
						break;
					}
				}
			}
		}
		ex = new NullReferenceException();
		goto IL_201d;
		IL_201d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (List<Source>)(object)new ArgumentNullException();
		IL_1ffc:
		return (List<Source>)(object)list;
	}

	private static Side Whole(Source s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_0717: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_041d: Expected Obj, but got I4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0477: Expected Obj, but got I8
		//IL_04e3: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I4
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_05bb: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_0643: Expected Obj, but got I
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_067d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Side side = NewSide(s);
		if (s != null)
		{
			int[][] tris = s.tris;
			if (s.tris != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BA8]");
				object obj5 = 0;
				object obj6 = 0;
				IEnumerable<int> enumerable = default;
				while (true)
				{
					if ((nint)obj6 < tris.Length)
					{
						object obj7 = 0;
						while (true)
						{
							bool flag2 = (nint)obj6 < tris.Length;
							object obj8 = !flag2;
							if (obj8 != null)
							{
								break;
							}
							object obj9 = (object)tris + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v7+20]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v7+20]");
							if ((nint)0 != 0)
							{
								object obj11 = obj7 + 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v8+18]");
								if ((nint)obj11 >= 0)
								{
									goto IL_0690;
								}
								if (side != null)
								{
									List<int>[] tris2 = side.tris;
									if (side.tris != null)
									{
										bool flag3 = (nint)obj6 < tris2.Length;
										object obj12 = !flag3;
										if (obj12 != null)
										{
											break;
										}
										object obj13 = (object)side.tris + obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										int[][] tris3 = s.tris;
										if (s.tris != null)
										{
											bool flag4 = (nint)obj6 < tris3.Length;
											object obj14 = !flag4;
											if (obj14 != null)
											{
												break;
											}
											object obj15 = (object)s.tris + obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v12+20]");
											object obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v12+20]");
											if ((nint)0 != 0)
											{
												object obj17 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v13+18]");
												bool flag5 = (nint)obj17 < 0;
												object obj18 = !flag5;
												if (obj18 != null)
												{
													break;
												}
												object obj19 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v12+20]");
												object obj20 = 0 + obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v15+E4]");
												bool flag6 = (nint)0 == 0;
												object obj21 = !flag6;
												if (obj21 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v14+20]");
												int num = Take(side, s, 0);
												if (enumerable != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v14 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
													if ((nint)0 == 0)
													{
														break;
													}
													int[][] tris4 = s.tris;
													if (s.tris != null)
													{
														bool flag7 = (nint)obj6 < tris4.Length;
														object obj22 = !flag7;
														if (obj22 != null)
														{
															break;
														}
														object obj23 = (object)s.tris + obj6;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+20]");
														object obj24 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+20]");
														if ((nint)0 != 0)
														{
															object obj25 = obj7 + 1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v18+18]");
															bool flag8 = (nint)obj25 < 0;
															object obj26 = !flag8;
															if (obj26 != null)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+20]");
															object obj27 = 0 + obj25;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v19+20]");
															int num2 = Take(side, s, 0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v14 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
															object obj28 = 0 & 0xFFFFFFFEL;
															if (obj28 == null)
															{
																break;
															}
															int[][] tris5 = s.tris;
															if (s.tris != null)
															{
																bool flag9 = (nint)obj6 < tris5.Length;
																object obj29 = !flag9;
																if (obj29 != null)
																{
																	break;
																}
																object obj30 = (object)s.tris + obj6;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v22+20]");
																object obj31 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v22+20]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v23+18]");
																	bool flag10 = (nint)obj11 < 0;
																	object obj32 = !flag10;
																	if (obj32 != null)
																	{
																		break;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v22+20]");
																	object obj33 = 0 + obj11;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v24+20]");
																	int num3 = Take(side, s, 0);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v14 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
																	bool flag11 = (nint)0 < (nint)2;
																	object obj34 = !flag11;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v14 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
																	object obj35 = -2;
																	bool flag12 = obj35 == null;
																	object obj36 = ~obj34;
																	object obj37 = obj36 | flag12;
																	if (obj37 != null)
																	{
																		break;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v10+20]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v10+20]");
																		((List<int>)0).AddRange(enumerable);
																		tris = s.tris;
																		obj7 += 3;
																		bool flag13 = s.tris == null;
																		object obj38 = !flag13;
																		if (obj38 != null)
																		{
																			continue;
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
							goto IL_06a8;
						}
						break;
					}
					return side;
					IL_0690:
					obj6++;
				}
				goto IL_06b6;
			}
		}
		goto IL_06a8;
		IL_06a8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06b6;
		IL_06b6:
		return (Side)(object)new IndexOutOfRangeException();
	}

	private static Side NewSide(Source s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04bb: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_0388: Expected I, but got Obj
		//IL_053b: Expected Obj, but got I4
		//IL_014b: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_03cf: Expected I, but got Obj
		//IL_0447: Expected Obj, but got I4
		//IL_03e5: Expected I, but got Obj
		//IL_01a7: Expected I, but got Obj
		//IL_0485: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02b3: Expected Obj, but got I4
		//IL_02bb: Expected I, but got Obj
		//IL_02d3: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76F8]");
		List<Vector4> list = (List<Vector4>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Side side = default;
		side._002Ector();
		object obj4 = default;
		IndexOutOfRangeException ex = default;
		if (s != null)
		{
			int[][] tris = s.tris;
			if (s.tris != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
				object obj = 0;
				nint num = tris.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				if (side != null)
				{
					list = (List<Vector4>)(side + 56);
					IntPtr intPtr = default;
					list = (List<Vector4>)(nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int[][] tris2 = s.tris;
					bool flag = s.tris == null;
					num = intPtr;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
						List<Vector4>[] array = (List<Vector4>[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC8]");
						obj4 = 0;
						nint num3 = default;
						nint num2 = num3;
						object obj5 = 32;
						object obj6 = 0;
						nint num4 = intPtr;
						List<int> list2 = default;
						while (true)
						{
							bool flag2 = (nint)obj6 < tris2.Length;
							object obj7 = !flag2;
							bool flag3 = (nint)obj6 >= tris2.Length;
							num3 = num2;
							object obj8 = obj5;
							num = num4;
							if (flag3)
							{
								break;
							}
							num3 = (nint)list;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							num = (nint)array;
							list2._002Ector();
							bool flag4 = (object)list == null;
							obj8 = obj5;
							if (!flag4)
							{
								bool flag5 = list2 == null;
								nint num5 = (nint)array;
								if (!flag5)
								{
									object obj9 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v22+40]");
									num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag6 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v22+40]");
									num = 0;
									if (flag6)
									{
										goto IL_04d3;
									}
								}
								object obj10 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X29_v3 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>>)+18]");
								bool flag7 = (nint)obj10 < 0;
								obj7 = !flag7;
								num = num5;
								if (obj7 != null)
								{
									goto IL_04c5;
								}
								object obj11 = num3 + obj6;
								object obj12 = num3 + obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								tris2 = s.tris;
								obj6++;
								obj8 = obj5 + 8;
								bool flag8 = s.tris == null;
								object obj13 = !flag8;
								num = (nint)list2;
								num2 = num3;
								obj5 = obj8;
								num4 = (nint)list2;
								if (obj13 != null)
								{
									continue;
								}
							}
							goto IL_02e1;
						}
						goto IL_02ef;
					}
				}
			}
		}
		goto IL_02e1;
		IL_02ef:
		object obj14 = -8;
		object obj15 = 32;
		List<Vector4> list3 = default;
		while (true)
		{
			List<Vector4>[] uvs = s.uvs;
			if (s.uvs == null)
			{
				break;
			}
			object obj2 = obj14 + 8;
			bool flag9 = (nint)obj2 < uvs.Length;
			object obj7 = !flag9;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v135 @ X25_v5]");
				if ((nint)0 == 0)
				{
					goto IL_048a;
				}
				List<Vector4>[] array = side.uvs;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				nint num = (nint)obj4;
				list3._002Ector();
				if (side.uvs == null)
				{
					break;
				}
				bool flag10 = (object)list3 == null;
				nint num6 = (nint)obj4;
				if (!flag10)
				{
					nint num7 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+40]");
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag11 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector4>[]>)+40]");
					num = 0;
					if (flag11)
					{
						goto IL_04d3;
					}
				}
				bool flag12 = (nint)obj2 < array.Length;
				object obj16 = !flag12;
				num = num6;
				if (obj16 == null)
				{
					object obj17 = (object)array + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num = (nint)list3;
					goto IL_048a;
				}
			}
			goto IL_04c5;
			IL_048a:
			obj14++;
			obj15 += 8;
			bool flag3 = true;
			obj7 = 0;
		}
		goto IL_02e1;
		IL_04c5:
		ex = new IndexOutOfRangeException();
		goto IL_04d3;
		IL_04d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Side)(object)new ArgumentNullException();
		IL_02e1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02ef;
	}

	private static int Take(Side side, Source s, int i)
	{
		//IL_0cd7: Expected I4, but got Obj
		//IL_005c: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02e0: Expected VT, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0273: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_09ff: Expected Obj, but got I
		//IL_0a08: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I4
		//IL_058c: Expected Obj, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_07db: Expected Obj, but got I4
		//IL_07ea: Expected Obj, but got I4
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_0a3f: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0610: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_086e: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_089e: Expected Obj, but got I
		//IL_08b4: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I
		//IL_08d4: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected Obj, but got Unknown
		//IL_06d2: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I
		//IL_052d: Expected VT, but got I
		//IL_0930: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I
		//IL_0771: Expected Obj, but got I
		//IL_078c: Expected VT, but got I
		//IL_0496: Expected Obj, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I
		//IL_09bf: Expected Obj, but got I
		//IL_09cf: Expected Obj, but got I
		//IL_09e9: Expected VT, but got I
		//IL_06fd: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I
		//IL_0abc: Expected Obj, but got I4
		//IL_095b: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I
		//IL_0aef: Expected Obj, but got I
		//IL_0b28: Expected Obj, but got I
		//IL_0b46: Expected Obj, but got I
		//IL_0b99: Expected Obj, but got I4
		//IL_0c08: Expected Obj, but got I
		//IL_0c18: Expected Obj, but got I
		//IL_0c35: Expected VT, but got I
		//IL_0c35: Expected Obj, but got I
		//IL_0bc4: Expected Obj, but got I
		//IL_0bda: Expected Obj, but got I
		if (side != null && side.from != null)
		{
			bool flag = side.from.TryGetValue(i, out var _);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj != null)
			{
				goto IL_0cae;
			}
			List<Vector3> at = side.at;
			if (side.at != null && s != null)
			{
				Vector3[] at2 = s.at;
				if (s.at != null)
				{
					bool flag3 = at2.Length < i;
					object obj2 = !flag3;
					object obj3 = at2.Length - i;
					bool flag4 = obj3 == null;
					object obj4 = ~obj2;
					object obj5 = obj4 | flag4;
					if (obj5 != null)
					{
						goto IL_0cc9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj6 = 0;
					object obj7 = i * 12;
					object obj8 = (object)s.at + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj10 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+20]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+24]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+28]");
					object obj13 = 0;
					object obj14 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v5+18]");
						bool flag5 = num < 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj16 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj17 = 0 + obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj18 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+24]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v6+28]");
							_ = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X10_v7+20]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v37+A8]");
							object obj20 = 0;
							List<Vector3> at3 = side.at;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v38+70]");
							at3.AddWithResize((Vector3)0);
						}
						Vector3[] normals = s.normals;
						if (s.normals == null)
						{
							goto IL_0532;
						}
						bool flag6 = normals.Length < i;
						object obj21 = !flag6;
						object obj22 = normals.Length - i;
						bool flag7 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag7;
						if (obj24 != null)
						{
							goto IL_0cc9;
						}
						List<Vector3> normals2 = side.normals;
						if (side.normals != null)
						{
							object obj25 = i * 12;
							object obj26 = (object)s.normals + obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj28 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+20]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+24]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+28]");
							obj13 = 0;
							object obj29 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v33+18]");
								bool flag8 = num2 < 0;
								object obj30 = !flag8;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj31 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj32 = 0 + obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj33 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+20]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+24]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X9_v26+28]");
									_ = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X9_v27+20]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v34+A8]");
									object obj35 = 0;
									List<Vector3> normals3 = side.normals;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v35+70]");
									normals3.AddWithResize((Vector3)0);
								}
								goto IL_0532;
							}
						}
					}
				}
			}
		}
		goto IL_0cbb;
		IL_0cbb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0cc9;
		IL_0532:
		Vector4[] tangents = s.tangents;
		if (s.tangents == null)
		{
			goto IL_0791;
		}
		bool flag9 = tangents.Length < i;
		object obj36 = !flag9;
		object obj37 = tangents.Length - i;
		bool flag10 = obj37 == null;
		object obj38 = ~obj36;
		object obj39 = obj38 | flag10;
		if (obj39 == null)
		{
			List<Vector4> tangents2 = side.tangents;
			if ((object)side.tangents != null)
			{
				object obj40 = s.tangents + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+24]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
				object obj43 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+2C]");
				object obj44 = 0;
				object obj45 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v29+18]");
					bool flag11 = num3 < 0;
					object obj46 = !flag11;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
						object obj47 = num4 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
						object obj48 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+24]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X9_v21+2C]");
						_ = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v22+20]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v30+A8]");
						object obj50 = 0;
						List<Vector4> tangents3 = side.tangents;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v31+70]");
						tangents3.AddWithResize((Vector4)0);
					}
					goto IL_0791;
				}
			}
			goto IL_0cbb;
		}
		goto IL_0cc9;
		IL_0cc9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
		IL_0cae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		return 0;
		IL_0791:
		Color[] colors = s.colors;
		if (s.colors == null)
		{
			goto IL_09ee;
		}
		bool flag12 = colors.Length < i;
		object obj51 = !flag12;
		object obj52 = colors.Length - i;
		bool flag13 = obj52 == null;
		object obj53 = ~obj51;
		object obj54 = obj53 | flag13;
		if (obj54 == null)
		{
			List<Color> colors2 = side.colors;
			if ((object)side.colors != null)
			{
				object obj55 = s.colors + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7700]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+24]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+1C]");
				object obj58 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+2C]");
				object obj44 = 0;
				object obj59 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v25+18]");
					bool flag14 = num5 < 0;
					object obj60 = !flag14;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
						object obj61 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v20 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
						object obj62 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+24]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v17+2C]");
						_ = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X9_v18+20]");
						object obj63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v26+A8]");
						object obj64 = 0;
						List<Color> colors3 = side.colors;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v27+70]");
						colors3.AddWithResize((Color)0);
					}
					goto IL_09ee;
				}
			}
			goto IL_0cbb;
		}
		goto IL_0cc9;
		IL_0c68:
		if (side.from != null)
		{
			Dictionary<int, int> dictionary = side.from;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			dictionary.set_Item(i, 0);
			goto IL_0cae;
		}
		goto IL_0cbb;
		IL_09ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
		object obj65 = 0;
		object obj66 = 4;
		int num7 = i;
		while (true)
		{
			List<Vector4>[] uvs = s.uvs;
			if (s.uvs == null)
			{
				break;
			}
			object obj67 = obj66 - 4;
			bool flag15 = (nint)obj67 < uvs.Length;
			object obj68 = !flag15;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v11 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v55 @ X25_v6*8]");
				if ((nint)0 != 0)
				{
					List<Vector4>[] uvs2 = side.uvs;
					if (side.uvs == null)
					{
						break;
					}
					bool flag16 = (nint)obj67 < uvs2.Length;
					object obj69 = !flag16;
					if (obj69 != null)
					{
						goto IL_0cc9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v13 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v55 @ X25_v6*8]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v11 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v55 @ X25_v6*8]");
					Vector4 vector = ((List<Vector4>)0).get_Item(i);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v13 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v55 @ X25_v6*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+10]");
					object obj70 = 0;
					object obj71 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+1C]");
					object obj72 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+18]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X9_v14+18]");
					bool flag17 = num8 < 0;
					object obj73 = !flag17;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+10]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+18]");
						object obj74 = num9 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X22_v8 (System.Int32)+18]");
						object obj75 = (nint)0 + (nint)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v21+20]");
						object obj76 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v22+A8]");
						object obj77 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v13 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v55 @ X25_v6*8]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v23+70]");
						((List<Vector4>)num10).AddWithResize((Vector4)0);
					}
				}
				obj66++;
				if ((nint)obj66 != 12)
				{
					continue;
				}
				goto IL_0c68;
			}
			goto IL_0cc9;
		}
		goto IL_0cbb;
	}

	private static int OnEdge(Side side, Source s, int i, int j, float t)
	{
		//IL_158d: Expected Obj, but got I4
		//IL_15c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c5: Expected I4, but got Unknown
		//IL_15fa: Expected Obj, but got I4
		//IL_162a: Expected Obj, but got I4
		//IL_1632: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Expected Obj, but got Unknown
		//IL_1580: Expected I4, but got Obj
		//IL_006d: Expected I4, but got I8
		//IL_008b: Expected Obj, but got I
		//IL_0098: Expected I8, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0218: Invalid comparison between F4 and I4
		//IL_022c: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0267: Expected F8, but got I4
		//IL_167b: Expected Obj, but got I
		//IL_168b: Expected Obj, but got I
		//IL_16a9: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected VT, but got I
		//IL_0421: Expected VT, but got I
		//IL_0387: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03b2: Expected Obj, but got I
		//IL_03c9: Expected VT, but got I8
		//IL_03d2: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_102b: Expected Obj, but got I
		//IL_1048: Invalid comparison between F4 and I4
		//IL_1057: Invalid comparison between F4 and I4
		//IL_106f: Expected Obj, but got F8
		//IL_107c: Expected Obj, but got F4
		//IL_10b1: Expected Obj, but got I4
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10be: Expected Obj, but got Unknown
		//IL_08a5: Expected Obj, but got I4
		//IL_08b4: Expected Obj, but got I4
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected Obj, but got Unknown
		//IL_0d88: Expected Obj, but got I4
		//IL_0d97: Expected Obj, but got I4
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected Obj, but got Unknown
		//IL_04cd: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_18b9: Invalid comparison between F4 and I4
		//IL_0902: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got I4
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected Obj, but got Unknown
		//IL_1126: Expected Obj, but got I4
		//IL_112f: Expected F4, but got I4
		//IL_0de5: Expected Obj, but got I4
		//IL_0df4: Expected Obj, but got I4
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected Obj, but got Unknown
		//IL_051d: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I4
		//IL_0579: Invalid comparison between F4 and I4
		//IL_0588: Invalid comparison between F4 and I4
		//IL_05a0: Expected Obj, but got F8
		//IL_05ad: Expected Obj, but got F4
		//IL_05d9: Expected F4, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_10fd: Expected F4, but got I4
		//IL_1106: Expected Obj, but got I4
		//IL_110f: Expected F4, but got I4
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0985: Invalid comparison between F4 and I4
		//IL_0994: Invalid comparison between F4 and I4
		//IL_09ac: Expected Obj, but got F8
		//IL_09b9: Expected Obj, but got F4
		//IL_09f2: Expected Obj, but got I
		//IL_0a0f: Expected Obj, but got I
		//IL_0a28: Expected Obj, but got I4
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		//IL_0e30: Invalid comparison between F4 and I4
		//IL_16f0: Expected Obj, but got I
		//IL_1710: Invalid comparison between F4 and I4
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected Obj, but got Unknown
		//IL_115e: Expected Obj, but got I4
		//IL_17cd: Invalid comparison between F4 and I4
		//IL_063e: Expected F8, but got I4
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected Obj, but got Unknown
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected Obj, but got Unknown
		//IL_0ea4: Expected Obj, but got I
		//IL_0eb4: Expected Obj, but got I
		//IL_0ed2: Expected Obj, but got I
		//IL_0a74: Expected F8, but got I4
		//IL_176a: Expected Obj, but got I
		//IL_1794: Expected Obj, but got I4
		//IL_14e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e9: Expected Obj, but got Unknown
		//IL_1827: Expected Obj, but got I
		//IL_1851: Expected Obj, but got I4
		//IL_0685: Invalid comparison between F8 and I
		//IL_0f2b: Expected Obj, but got I
		//IL_0f55: Expected Obj, but got I4
		//IL_0abb: Invalid comparison between F8 and I
		//IL_06e1: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_0701: Expected F4, but got Obj
		//IL_0711: Expected F8, but got I
		//IL_0fdb: Expected Obj, but got I
		//IL_0feb: Expected Obj, but got I
		//IL_1005: Expected VT, but got I
		//IL_0b17: Expected Obj, but got I
		//IL_0b2f: Expected Obj, but got I
		//IL_0b37: Expected F4, but got Obj
		//IL_0b47: Expected F8, but got I
		//IL_11e3: Expected Obj, but got I4
		//IL_0fa6: Expected Obj, but got I
		//IL_0fbc: Expected Obj, but got I
		//IL_0726: Expected Obj, but got I
		//IL_0744: Expected Obj, but got I
		//IL_1201: Expected Obj, but got I
		//IL_1216: Expected Obj, but got I
		//IL_0b67: Expected Obj, but got I4
		//IL_0b76: Expected Obj, but got I4
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got Unknown
		//IL_077e: Expected Obj, but got I
		//IL_07a8: Expected Obj, but got I4
		//IL_1264: Expected Obj, but got I4
		//IL_081b: Expected Obj, but got I
		//IL_082b: Expected Obj, but got I
		//IL_083b: Expected VT, but got I
		//IL_0855: Expected VT, but got I
		//IL_07cc: Expected Obj, but got I
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_07f7: Expected Obj, but got I
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected Obj, but got Unknown
		//IL_0bfa: Expected Obj, but got I
		//IL_0c0a: Expected Obj, but got I
		//IL_0c1a: Expected F4, but got I
		//IL_0c38: Expected Obj, but got I
		//IL_12ac: Expected Obj, but got I
		//IL_0c72: Expected Obj, but got I
		//IL_0c9c: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I
		//IL_0d1e: Expected Obj, but got I
		//IL_0d39: Expected VT, but got I
		//IL_12e5: Expected Obj, but got I
		//IL_1303: Expected Obj, but got I
		//IL_0cc7: Expected Obj, but got I
		//IL_0cdd: Expected Obj, but got I
		//IL_1392: Expected Obj, but got I4
		//IL_1491: Expected Obj, but got I
		//IL_14a1: Expected Obj, but got I
		//IL_14be: Expected VT, but got I
		//IL_14be: Expected Obj, but got I
		//IL_1435: Expected Obj, but got I
		//IL_144b: Expected Obj, but got I
		object obj = i - j;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = i ^ j;
		int num2 = i ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag4;
		object obj3 = ~obj2;
		int num4 = ((obj3 != null) ? j : i);
		bool flag5 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag5 & obj4;
		object obj6 = ~obj5;
		int num5 = ((obj6 != null) ? j : i);
		long num8;
		float num13;
		object obj28 = default;
		double num16;
		if (side != null && side.onEdge != null)
		{
			int num6 = (int)(num4 & 0xFFFFFFFFL);
			int num7 = num6 << 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C10]");
			object obj7 = 0;
			num8 = num7 + num5;
			bool flag6 = side.onEdge.TryGetValue(num8, out var _);
			bool flag7 = !flag6;
			object obj8 = !flag7;
			if (obj8 != null)
			{
				goto IL_1557;
			}
			List<Vector3> at = side.at;
			if (side.at != null && s != null)
			{
				Vector3[] at2 = s.at;
				if (s.at != null)
				{
					bool flag8 = at2.Length < i;
					object obj9 = !flag8;
					object obj10 = at2.Length - i;
					bool flag9 = obj10 == null;
					object obj11 = ~obj9;
					object obj12 = obj11 | flag9;
					if (obj12 == null)
					{
						bool flag10 = at2.Length < j;
						object obj13 = !flag10;
						object obj14 = at2.Length - j;
						bool flag11 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag11;
						if (obj16 == null)
						{
							bool flag12 = t < 0f;
							object obj17 = i * 12;
							object obj18 = (object)s.at + obj17;
							object obj19 = j * 12;
							object obj20 = (object)s.at + obj19;
							double num9 = 0.0;
							if (!flag12)
							{
								bool flag13 = !((double)t > 1.0);
								num9 = t;
								if (!flag13)
								{
									num9 = 1.0;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj22 = 0;
							object obj23 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj24 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 == 0)
							{
								goto IL_1564;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v8+20]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X11_v4+20]");
							object obj25 = num10 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v8+28]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X11_v4+28]");
							object obj26 = num11 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X9_v7+18]");
							bool flag14 = num12 < 0;
							object obj27 = !flag14;
							num13 = (float)obj25 * (float)obj28;
							double num14 = (double)obj26 * num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X11_v4+20]");
							float num15 = 0f + num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X11_v4+28]");
							num16 = 0.0 + num14;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj29 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj30 = 0 + obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj31 = (nint)0 + (nint)1;
								Vector3 vector = (Vector3)num8;
								obj23 = 12;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v15+20]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v72+A8]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v73+70]");
								Vector3 vector = (Vector3)0;
								List<Vector3> at3 = side.at;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v73+70]");
								at3.AddWithResize((Vector3)0);
							}
							Vector3[] normals = s.normals;
							if (s.normals == null)
							{
								goto IL_085a;
							}
							bool flag15 = normals.Length < i;
							object obj34 = !flag15;
							object obj35 = normals.Length - i;
							bool flag16 = obj35 == null;
							object obj36 = ~obj34;
							object obj37 = obj36 | flag16;
							if (obj37 == null)
							{
								bool flag17 = normals.Length < j;
								object obj38 = !flag17;
								object obj39 = normals.Length - j;
								bool flag18 = obj39 == null;
								object obj40 = ~obj38;
								object obj41 = obj40 | flag18;
								if (obj41 == null)
								{
									object obj42 = i * 12;
									object obj43 = (object)s.normals + obj42;
									List<Vector3> normals2 = side.normals;
									object obj44 = j * 12;
									object obj45 = (object)s.normals + obj44;
									float num17 = t - 1f;
									bool flag19 = num17 < 0f;
									bool flag20 = num17 == 0f;
									object obj46 = (double)t ^ 1.0;
									object obj47 = t ^ num17;
									object obj48 = obj46 & obj47;
									bool flag21 = (nint)obj48 < 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v52+28]");
									num13 = 0f;
									bool flag22 = flag19 == flag21;
									object obj49 = !flag22;
									object obj50 = obj49 | flag20;
									object obj51 = ~obj50;
									double num18 = ((obj51 != null) ? 1.0 : ((double)t));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v52+20]");
									nint num19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X9_v30+20]");
									object obj52 = num19 - 0;
									float num20 = num13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X9_v30+28]");
									float num21 = num20 - 0f;
									if (t < 0f)
									{
										num18 = 0.0;
									}
									float num22 = (float)obj52 * (float)obj28;
									double num23 = (double)num21 * num18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X9_v30+20]");
									float num24 = 0f + num22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X9_v30+28]");
									double num25 = 0.0 + num23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									object obj53 = 0;
									object obj54 = obj53;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v37+E4]");
									bool flag23 = (nint)0 == 0;
									object obj55 = !flag23;
									if (obj55 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									double num26 = num25 * num25;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									if (num26 > 0.0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										num16 = num25 / num26;
										float num27 = num24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										float num28 = num27 / 0f;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										object obj56 = 0;
										object obj57 = obj56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v68+A0]");
										object obj58 = 0;
										float num28 = (float)obj58;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v69+8]");
										num16 = 0.0;
									}
									if (side.normals != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj59 = 0;
										object obj60 = obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj61 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											nint num29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v62+18]");
											bool flag24 = num29 < 0;
											object obj62 = !flag24;
											if (obj62 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
												object obj63 = (nint)0 * (nint)12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
												object obj64 = 0 + obj63;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X24_v7 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
												object obj65 = (nint)0 + (nint)1;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v31+20]");
												object obj66 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X8_v63+A8]");
												object obj67 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v64+70]");
												Vector3 vector = (Vector3)0;
												List<Vector3> normals3 = side.normals;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v64+70]");
												normals3.AddWithResize((Vector3)0);
											}
											goto IL_085a;
										}
									}
									goto IL_1564;
								}
							}
						}
					}
					goto IL_1572;
				}
			}
		}
		goto IL_1564;
		IL_1511:
		if (side.onEdge != null)
		{
			Dictionary<long, int> onEdge = side.onEdge;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			onEdge.set_Item(num8, 0);
			goto IL_1557;
		}
		goto IL_1564;
		IL_1572:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_1557:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		return 0;
		IL_1564:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1572;
		IL_101a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
		object obj68 = 0;
		float num30 = t - 1f;
		bool flag25 = num30 < 0f;
		bool flag26 = num30 == 0f;
		object obj69 = (double)t ^ 1.0;
		object obj70 = t ^ num30;
		object obj71 = obj69 & obj70;
		bool flag27 = (nint)obj71 < 0;
		bool flag28 = flag25 == flag27;
		object obj72 = !flag26;
		object obj73 = flag28 & obj72;
		object obj74 = ~obj73;
		float num31 = ((obj74 != null) ? t : 1f);
		float num32;
		object obj75;
		float num33;
		if (t < 0f)
		{
			num32 = 0f;
			obj75 = 4;
			num33 = 0f;
		}
		else
		{
			num32 = num31;
			obj75 = 4;
			num33 = 0f;
		}
		while (true)
		{
			List<Vector4>[] uvs = s.uvs;
			if (s.uvs == null)
			{
				break;
			}
			object obj76 = obj75 - 4;
			bool flag29 = (nint)obj76 < uvs.Length;
			object obj77 = !flag29;
			float num34;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v16 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
				bool flag30 = (nint)0 == 0;
				num34 = num31;
				if (flag30)
				{
					goto IL_14db;
				}
				List<Vector4>[] uvs2 = side.uvs;
				if (side.uvs == null)
				{
					break;
				}
				bool flag31 = (nint)obj76 < uvs2.Length;
				object obj78 = !flag31;
				if (obj78 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v20 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
					List<Vector4> list = (List<Vector4>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v16 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
					Vector4 vector2 = ((List<Vector4>)0).get_Item(i);
					List<Vector4>[] uvs3 = s.uvs;
					if (s.uvs == null)
					{
						break;
					}
					bool flag32 = (nint)obj76 < uvs3.Length;
					object obj79 = !flag32;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v21 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
						Vector4 vector3 = ((List<Vector4>)0).get_Item(j);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v20 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
						object obj80 = 0;
						object obj81 = obj68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
						object obj82 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						float num35 = num31 - num31;
						float num36 = num33 - num33;
						double num37 = num16 - num16;
						float num38 = num13 - num13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
						nint num39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X9_v17+18]");
						bool flag33 = num39 < 0;
						object obj83 = !flag33;
						float num40 = num35 * num32;
						float num41 = num36 * num32;
						double num42 = num37 * (double)num32;
						float num43 = num38 * num32;
						num34 = num31 + num40;
						float num44 = num33 + num41;
						double num45 = num16 + num42;
						float num46 = num13 + num43;
						if (obj83 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
							nint num47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
							object obj84 = num47 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X24_v8 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
							object obj85 = (nint)0 + (nint)1;
							num33 = num44;
							num16 = num45;
							num13 = num46;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v22+20]");
							object obj86 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v23+A8]");
							object obj87 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v20 (System.Collections.Generic.List`1<UnityEngine.Vector4>[])+v160 @ X27_v7*8]");
							nint num48 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X8_v24+70]");
							((List<Vector4>)num48).AddWithResize((Vector4)0);
							num33 = num44;
							num16 = num45;
							num13 = num46;
						}
						goto IL_14db;
					}
				}
			}
			goto IL_1572;
			IL_14db:
			obj75++;
			bool flag34 = (nint)obj75 != 12;
			num31 = num34;
			if (flag34)
			{
				continue;
			}
			goto IL_1511;
		}
		goto IL_1564;
		IL_085a:
		Vector4[] tangents = s.tangents;
		if (s.tangents == null)
		{
			goto IL_0d3e;
		}
		bool flag35 = tangents.Length < i;
		object obj88 = !flag35;
		object obj89 = tangents.Length - i;
		bool flag36 = obj89 == null;
		object obj90 = ~obj88;
		object obj91 = obj90 | flag36;
		if (obj91 == null)
		{
			bool flag37 = tangents.Length < j;
			object obj92 = !flag37;
			object obj93 = tangents.Length - j;
			bool flag38 = obj93 == null;
			object obj94 = ~obj92;
			object obj95 = obj94 | flag38;
			if (obj95 == null)
			{
				object obj96 = s.tangents + i;
				object obj97 = s.tangents + j;
				float num49 = t - 1f;
				bool flag39 = num49 < 0f;
				bool flag40 = num49 == 0f;
				object obj98 = (double)t ^ 1.0;
				object obj99 = t ^ num49;
				object obj100 = obj98 & obj99;
				bool flag41 = (nint)obj100 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v30+20]");
				nint num50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v24+20]");
				object obj101 = num50 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v30+28]");
				nint num51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v24+28]");
				object obj102 = num51 - 0;
				bool flag42 = flag39 == flag41;
				object obj103 = !flag42;
				object obj104 = obj103 | flag40;
				object obj105 = ~obj104;
				double num52 = ((obj105 != null) ? 1.0 : ((double)t));
				if (t < 0f)
				{
					num52 = 0.0;
				}
				float num22 = (float)obj101 * (float)obj28;
				double num53 = (double)obj102 * num52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v24+20]");
				float num24 = 0f + num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X9_v24+28]");
				double num25 = 0.0 + num53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj106 = 0;
				object obj107 = obj106;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X0_v25+E4]");
				bool flag43 = (nint)0 == 0;
				object obj108 = !flag43;
				if (obj108 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num54 = num25 * num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num54 > 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num16 = num25 / num54;
					float num55 = num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float num56 = num55 / 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj109 = 0;
					object obj110 = obj109;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v48+A0]");
					object obj111 = 0;
					float num56 = (float)obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v49+8]");
					num16 = 0.0;
				}
				Vector4[] tangents2 = s.tangents;
				if (s.tangents != null)
				{
					bool flag44 = tangents2.Length < i;
					object obj112 = !flag44;
					object obj113 = tangents2.Length - i;
					bool flag45 = obj113 == null;
					object obj114 = ~obj112;
					object obj115 = obj114 | flag45;
					if (obj115 != null)
					{
						goto IL_1572;
					}
					List<Vector4> tangents3 = side.tangents;
					if ((object)side.tangents != null)
					{
						object obj116 = s.tangents + i;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
						object obj117 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
						object obj118 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v41+2C]");
						num13 = 0f;
						object obj119 = obj117;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
						object obj120 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
							nint num57 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v26+18]");
							bool flag46 = num57 < 0;
							object obj121 = !flag46;
							if (obj121 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
								nint num58 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
								object obj122 = num58 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v27 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
								object obj123 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v41+2C]");
								_ = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v42+20]");
								object obj124 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v43+A8]");
								object obj125 = 0;
								List<Vector4> tangents4 = side.tangents;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v44+70]");
								tangents4.AddWithResize((Vector4)0);
							}
							goto IL_0d3e;
						}
					}
				}
				goto IL_1564;
			}
		}
		goto IL_1572;
		IL_0d3e:
		Color[] colors = s.colors;
		if (s.colors == null)
		{
			goto IL_101a;
		}
		bool flag47 = colors.Length < i;
		object obj126 = !flag47;
		object obj127 = colors.Length - i;
		bool flag48 = obj127 == null;
		object obj128 = ~obj126;
		object obj129 = obj128 | flag48;
		if (obj129 == null)
		{
			bool flag49 = colors.Length < j;
			object obj130 = !flag49;
			object obj131 = colors.Length - j;
			bool flag50 = obj131 == null;
			object obj132 = ~obj130;
			object obj133 = obj132 | flag50;
			if (obj133 == null)
			{
				bool flag51 = t < 0f;
				List<Color> colors2 = side.colors;
				if ((!flag51 && (double)t > 1.0) || (object)side.colors != null)
				{
					object obj134 = s.colors + i;
					object obj135 = s.colors + j;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7700]");
					object obj136 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
					object obj137 = 0;
					object obj138 = obj136;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+1C]");
					object obj139 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X10_v19+20]");
						double num59 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X9_v20+20]");
						num16 = num59 - 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
						nint num60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v26+18]");
						bool flag52 = num60 < 0;
						object obj140 = !flag52;
						double num61 = num16 * (double)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X9_v20+20]");
						double num62 = 0.0 + num61;
						if (obj140 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+10]");
							nint num63 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
							object obj141 = num63 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v22 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
							object obj142 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X9_v21+20]");
							object obj143 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X8_v27+A8]");
							object obj144 = 0;
							List<Color> colors3 = side.colors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v28+70]");
							colors3.AddWithResize((Color)0);
							double num64 = default;
							num16 = num64;
							float num65 = default;
							num13 = num65;
						}
						goto IL_101a;
					}
				}
				goto IL_1564;
			}
		}
		goto IL_1572;
	}

	private unsafe static (Side, Side) Split(Source s, Vector3 p, Vector3 n, List<(Vector3, Vector3)> segments)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2dd9: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00b9: Expected VT, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I8
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_2da1: Expected VT, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I4
		//IL_2daf: Expected VT, but got Obj
		//IL_01fd: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_02b9: Invalid comparison between F4 and I
		//IL_040e: Expected Obj, but got I
		//IL_2df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfa: Expected Obj, but got Unknown
		//IL_2e1b: Expected VT, but got I
		//IL_2d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d39: Expected Obj, but got Unknown
		//IL_2d58: Expected Obj, but got I4
		//IL_02e0: Expected F4, but got I
		//IL_0474: Expected Obj, but got I4
		//IL_3176: Unknown result type (might be due to invalid IL or missing references)
		//IL_317b: Expected Obj, but got Unknown
		//IL_3194: Expected Obj, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_0500: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got I4
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05bf: Expected Obj, but got I4
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_05f2: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0663: Expected F8, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_0695: Expected VT, but got I
		//IL_093e: Invalid comparison between F8 and I4
		//IL_0c39: Expected Obj, but got I4
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Expected Obj, but got Unknown
		//IL_0c4f: Invalid comparison between VT and I4
		//IL_0c5e: Invalid comparison between VT and I4
		//IL_0c71: Expected Obj, but got VT
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0ca6: Expected Obj, but got I4
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected Obj, but got Unknown
		//IL_0cbc: Invalid comparison between F8 and I4
		//IL_0ccb: Invalid comparison between F8 and I4
		//IL_0cde: Expected Obj, but got F8
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_0d13: Expected Obj, but got I4
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		//IL_10a4: Expected Obj, but got I4
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Expected Obj, but got Unknown
		//IL_10ba: Invalid comparison between VT and I4
		//IL_10c9: Invalid comparison between VT and I4
		//IL_10dc: Expected Obj, but got VT
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected Obj, but got Unknown
		//IL_1111: Expected Obj, but got I4
		//IL_1119: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Expected Obj, but got Unknown
		//IL_1141: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Expected Obj, but got Unknown
		//IL_095b: Invalid comparison between VT and I4
		//IL_15b9: Expected Obj, but got I
		//IL_15e1: Expected Obj, but got I
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_2e52: Expected Obj, but got I4
		//IL_117b: Expected Obj, but got I
		//IL_119b: Expected Obj, but got I
		//IL_11ab: Expected Obj, but got I
		//IL_0989: Expected Obj, but got I4
		//IL_0d84: Expected Obj, but got I
		//IL_0d94: Expected Obj, but got I
		//IL_0dac: Expected Obj, but got I
		//IL_1646: Expected Obj, but got I
		//IL_1656: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Expected Obj, but got Unknown
		//IL_1683: Expected Obj, but got I4
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected Obj, but got Unknown
		//IL_09c5: Expected Obj, but got I
		//IL_2ec3: Expected Obj, but got I4
		//IL_2ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed0: Expected Obj, but got Unknown
		//IL_2ed9: Expected I4, but got Obj
		//IL_0781: Expected Obj, but got I4
		//IL_2f08: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I4
		//IL_07b9: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I4
		//IL_16fc: Expected Obj, but got I4
		//IL_0a5d: Expected Obj, but got I
		//IL_0a7f: Expected Obj, but got I4
		//IL_083c: Expected Obj, but got I
		//IL_0ae0: Expected Obj, but got I
		//IL_171a: Expected Obj, but got I
		//IL_174c: Expected F4, but got I
		//IL_176e: Expected Obj, but got I4
		//IL_1776: Expected I4, but got Obj
		//IL_0862: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I
		//IL_08a6: Expected Obj, but got I
		//IL_2f33: Expected Obj, but got I
		//IL_2f91: Expected I4, but got Obj
		//IL_2fae: Expected I4, but got Obj
		//IL_2fae: Expected I4, but got Obj
		//IL_0b06: Expected Obj, but got I
		//IL_0b1d: Expected Obj, but got I
		//IL_0b4a: Expected Obj, but got I
		//IL_1796: Expected I4, but got Obj
		//IL_08e5: Expected Obj, but got I4
		//IL_0b89: Expected Obj, but got I4
		//IL_0dc8: Expected Obj, but got I
		//IL_11c7: Expected Obj, but got I
		//IL_0910: Expected Obj, but got I
		//IL_0926: Expected Obj, but got I
		//IL_17ed: Expected Obj, but got I4
		//IL_0bb4: Expected Obj, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0e27: Expected Obj, but got I4
		//IL_181d: Expected Obj, but got I
		//IL_182e: Expected I4, but got Obj
		//IL_1859: Expected Obj, but got I
		//IL_1226: Expected Obj, but got I4
		//IL_0e57: Expected Obj, but got I
		//IL_1877: Expected Obj, but got I
		//IL_188e: Expected Obj, but got I
		//IL_18bb: Expected Obj, but got I
		//IL_1256: Expected Obj, but got I
		//IL_0eb9: Expected Obj, but got I
		//IL_0ed0: Expected Obj, but got I
		//IL_18f2: Expected Obj, but got I4
		//IL_12b8: Expected Obj, but got I
		//IL_12cf: Expected Obj, but got I
		//IL_1959: Expected Obj, but got I
		//IL_0f34: Expected Obj, but got I4
		//IL_198f: Expected Obj, but got I
		//IL_191d: Expected Obj, but got I
		//IL_1933: Expected Obj, but got I
		//IL_1333: Expected Obj, but got I4
		//IL_0f9b: Expected Obj, but got I
		//IL_139a: Expected Obj, but got I
		//IL_0f5f: Expected Obj, but got I
		//IL_0f75: Expected Obj, but got I
		//IL_19b8: Expected Obj, but got I4
		//IL_135e: Expected Obj, but got I
		//IL_1374: Expected Obj, but got I
		//IL_0ffa: Expected Obj, but got I4
		//IL_19e8: Expected Obj, but got I
		//IL_1a0f: Expected Obj, but got I
		//IL_13f9: Expected Obj, but got I4
		//IL_1a2d: Expected Obj, but got I
		//IL_1a44: Expected Obj, but got I
		//IL_1a71: Expected Obj, but got I
		//IL_2e70: Expected Obj, but got I
		//IL_2e81: Expected I4, but got Obj
		//IL_1aa8: Expected Obj, but got I4
		//IL_1446: Expected Obj, but got I
		//IL_1456: Expected Obj, but got I
		//IL_146c: Expected Obj, but got I
		//IL_1b1c: Expected Obj, but got I
		//IL_1b4d: Expected Obj, but got I
		//IL_1ad3: Expected Obj, but got I
		//IL_1ae9: Expected Obj, but got I
		//IL_14ae: Expected Obj, but got I
		//IL_14d7: Expected Obj, but got I4
		//IL_1b76: Expected Obj, but got I4
		//IL_1557: Expected Obj, but got I
		//IL_1567: Expected Obj, but got I
		//IL_1577: Expected VT, but got I
		//IL_158c: Expected Obj, but got I
		//IL_159c: Expected Obj, but got I
		//IL_15a4: Expected VT, but got I4
		//IL_2c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6a: Expected Obj, but got Unknown
		//IL_2c7a: Expected Obj, but got I
		//IL_1502: Expected Obj, but got I
		//IL_1518: Expected Obj, but got I
		//IL_152a: Expected VT, but got Obj
		//IL_153a: Expected Obj, but got I
		//IL_1542: Expected VT, but got I4
		//IL_1ba1: Expected Obj, but got I
		//IL_1bc8: Expected Obj, but got I
		//IL_1be6: Expected Obj, but got I
		//IL_1bfd: Expected Obj, but got I
		//IL_1c2a: Expected Obj, but got I
		//IL_1c61: Expected Obj, but got I4
		//IL_1cc8: Expected Obj, but got I
		//IL_1ce6: Expected I4, but got Obj
		//IL_1ce6: Expected I4, but got Obj
		//IL_1d03: Expected I4, but got Obj
		//IL_1d03: Expected I4, but got Obj
		//IL_1c8c: Expected Obj, but got I
		//IL_1ca2: Expected Obj, but got I
		//IL_1d1d: Expected I4, but got Obj
		//IL_1d32: Expected I4, but got Obj
		//IL_1d52: Expected Obj, but got I4
		//IL_1d89: Expected Obj, but got I4
		//IL_1db2: Expected Obj, but got I4
		//IL_1de2: Expected Obj, but got I
		//IL_1e01: Expected Obj, but got I4
		//IL_1e1f: Expected Obj, but got I
		//IL_1e2f: Expected Obj, but got I
		//IL_1e45: Expected Obj, but got I
		//IL_1e71: Expected Obj, but got I4
		//IL_1ea8: Expected Obj, but got I4
		//IL_1f1d: Expected Obj, but got I
		//IL_1f2d: Expected Obj, but got I
		//IL_1f52: Expected Obj, but got I
		//IL_1f7b: Expected Obj, but got I4
		//IL_1ed3: Expected Obj, but got I
		//IL_1ee9: Expected Obj, but got I
		//IL_1efb: Expected I4, but got Obj
		//IL_1fa4: Expected Obj, but got I4
		//IL_1fcf: Expected Obj, but got I
		//IL_1fee: Expected Obj, but got I4
		//IL_200c: Expected Obj, but got I
		//IL_201c: Expected Obj, but got I
		//IL_2032: Expected Obj, but got I
		//IL_205e: Expected Obj, but got I4
		//IL_2095: Expected Obj, but got I4
		//IL_20fd: Expected Obj, but got I
		//IL_210d: Expected Obj, but got I
		//IL_2132: Expected Obj, but got I
		//IL_215b: Expected Obj, but got I4
		//IL_20c0: Expected Obj, but got I
		//IL_20d6: Expected Obj, but got I
		//IL_2184: Expected Obj, but got I4
		//IL_21af: Expected Obj, but got I
		//IL_21ec: Expected Obj, but got I
		//IL_21fc: Expected Obj, but got I
		//IL_2212: Expected Obj, but got I
		//IL_2275: Expected Obj, but got I4
		//IL_22dd: Expected Obj, but got I
		//IL_22ed: Expected Obj, but got I
		//IL_2312: Expected Obj, but got I
		//IL_22a0: Expected Obj, but got I
		//IL_22b6: Expected Obj, but got I
		//IL_2364: Expected Obj, but got I4
		//IL_238f: Expected Obj, but got I
		//IL_23cc: Expected Obj, but got I
		//IL_23dc: Expected Obj, but got I
		//IL_23f2: Expected Obj, but got I
		//IL_2455: Expected Obj, but got I4
		//IL_24bd: Expected Obj, but got I
		//IL_24cd: Expected Obj, but got I
		//IL_24f2: Expected Obj, but got I
		//IL_2480: Expected Obj, but got I
		//IL_2496: Expected Obj, but got I
		//IL_2544: Expected Obj, but got I4
		//IL_256f: Expected Obj, but got I
		//IL_25ac: Expected Obj, but got I
		//IL_25bc: Expected Obj, but got I
		//IL_25d2: Expected Obj, but got I
		//IL_2635: Expected Obj, but got I4
		//IL_269d: Expected Obj, but got I
		//IL_26ad: Expected Obj, but got I
		//IL_26d2: Expected Obj, but got I
		//IL_2660: Expected Obj, but got I
		//IL_2676: Expected Obj, but got I
		//IL_2724: Expected Obj, but got I4
		//IL_274f: Expected Obj, but got I
		//IL_278c: Expected Obj, but got I
		//IL_279c: Expected Obj, but got I
		//IL_27b2: Expected Obj, but got I
		//IL_2815: Expected Obj, but got I4
		//IL_287d: Expected Obj, but got I
		//IL_288d: Expected Obj, but got I
		//IL_289d: Expected VT, but got I
		//IL_28b2: Expected Obj, but got I
		//IL_28d4: Expected Obj, but got I
		//IL_2840: Expected Obj, but got I
		//IL_2856: Expected Obj, but got I
		//IL_2868: Expected VT, but got I4
		//IL_2919: Expected Obj, but got I4
		//IL_2942: Expected Obj, but got I4
		//IL_2959: Invalid comparison between F4 and I4
		//IL_2968: Expected F8, but got I4
		//IL_2ff2: Expected Obj, but got I4
		//IL_29bd: Invalid comparison between F4 and I4
		//IL_29cc: Expected F8, but got I4
		//IL_3009: Unknown result type (might be due to invalid IL or missing references)
		//IL_300e: Expected Obj, but got Unknown
		//IL_3029: Unknown result type (might be due to invalid IL or missing references)
		//IL_302e: Expected Obj, but got Unknown
		//IL_3049: Unknown result type (might be due to invalid IL or missing references)
		//IL_304e: Expected Obj, but got Unknown
		//IL_307d: Expected Obj, but got I
		//IL_309a: Expected Obj, but got I
		//IL_30b7: Expected Obj, but got I
		//IL_30c7: Expected Obj, but got I
		//IL_3148: Expected VT, but got Obj
		//IL_3151: Invalid comparison between VT and I4
		//IL_2a28: Expected Obj, but got I
		//IL_2a38: Expected Obj, but got I
		//IL_2a4e: Expected Obj, but got I
		//IL_2aa0: Expected Obj, but got I
		//IL_2ac9: Expected Obj, but got I4
		//IL_2bb4: Expected Obj, but got I
		//IL_2bc4: Expected Obj, but got I
		//IL_2bd4: Expected VT, but got I
		//IL_2be1: Expected VT, but got Ref
		//IL_2be1: Expected Obj, but got VT
		//IL_2bec: Expected VT, but got I4
		//IL_2bfe: Expected VT, but got I4
		//IL_2c1f: Expected VT, but got I4
		//IL_2c37: Expected VT, but got Ref
		//IL_2c57: Expected Obj, but got I4
		//IL_2aed: Expected Obj, but got I
		//IL_2afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b02: Expected Obj, but got Unknown
		//IL_2b18: Expected Obj, but got I
		//IL_2b34: Expected VT, but got I4
		//IL_2b5d: Expected VT, but got I4
		//IL_2b66: Expected Obj, but got I4
		//IL_2b7e: Expected VT, but got Obj
		//IL_2b9f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Side side = NewSide(s);
		Side side2 = NewSide(s);
		bool flag2 = s == null;
		Side side3 = side;
		(Vector3, Vector3) tuple;
		List<(Vector3, Vector3)> list = default;
		Side side4 = default;
		float num;
		float num3;
		float num4 = default;
		object obj10 = default;
		object obj13 = default;
		float num10 = default;
		float num11 = default;
		bool flag9 = default;
		if (!flag2)
		{
			Vector3[] at = s.at;
			bool flag3 = s.at == null;
			side3 = side;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj4 = 0;
				tuple = ((Vector3, Vector3))at.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag4 = list == null;
				side4 = side2;
				side3 = side;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v14 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
					bool flag5 = (nint)0 < (nint)1;
					float num2 = default;
					num = num2;
					num3 = num4;
					float num6 = default;
					float num5 = num6;
					(Vector3, Vector3) tuple3 = default;
					(Vector3, Vector3) tuple2 = tuple3;
					if (flag5)
					{
						goto IL_02e5;
					}
					Vector3[] at2 = s.at;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v14 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
					object obj5 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v14 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
					object obj6 = 0 & obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v14 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
					object obj7 = 0 & 0xFFFFFFFFL;
					Side side5 = (Side)(list + 32);
					object obj8 = s.at + 40;
					object obj9 = 0;
					while (true)
					{
						bool flag6 = s.at == null;
						side4 = side2;
						side3 = side;
						if (flag6)
						{
							break;
						}
						obj10 = at2.Length;
						bool flag7 = (nint)obj9 < at2.Length;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
							object obj12 = !flag8;
							if (obj12 == null)
							{
								obj13 = obj8 + 12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X13_v15-8]");
								object obj14 = 0 - tuple3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X13_v15-4]");
								float num7 = 0f - num6;
								float num8 = (float)obj8 - num4;
								float num9 = num2 * (float)obj14;
								num3 = num10 * num7;
								num = num11 * num8;
								float num12 = num9 + num3;
								num5 = num + num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								float num13 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								flag9 = !(num13 < 0f);
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
									num5 = 0f;
								}
								obj9++;
								bool flag10 = obj6 != obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								tuple2 = ((Vector3, Vector3))0;
								obj8 = obj13;
								if (flag10)
								{
									continue;
								}
								goto IL_02e5;
							}
						}
						goto IL_2da1;
					}
				}
			}
		}
		goto IL_2d76;
		IL_2da1:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return ((Side, Side))ex;
		IL_02e5:
		int[][] tris = s.tris;
		bool flag11 = s.tris == null;
		side4 = side2;
		side3 = side;
		if (flag11)
		{
			goto IL_2d76;
		}
		double num14 = num11;
		object obj15 = 0;
		double num15 = num3;
		List<(Vector3, Vector3)> list2 = list;
		Side side6 = side2;
		Side side7 = side;
		Vector3 vector = p;
		float num16 = num4;
		List<int> list3 = (List<int>)109891584;
		float num17 = num10;
		float num18 = num11;
		object obj20 = default;
		float num19 = default;
		double num20 = default;
		List<(Vector3, Vector3)> list4 = default;
		object obj21 = default;
		Vector3 vector3 = default;
		object obj215 = default;
		float num68 = default;
		List<Vector4> list22 = default;
		(Vector3, Vector3) tuple6 = default;
		System.__Canon item;
		while (true)
		{
			bool flag12 = (nint)obj15 >= tris.Length;
			item = (System.__Canon)(object)side6;
			side3 = side7;
			if (!flag12)
			{
				bool flag13 = (nint)obj15 < tris.Length;
				object obj16 = !flag13;
				if (obj16 != null)
				{
					break;
				}
				object obj17 = (object)tris + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v13+20]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v13+20]");
				bool flag14 = (nint)0 == 0;
				side4 = side6;
				side3 = side7;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X11_v9+18]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X11_v9+18]");
					if ((nint)0 >= (nint)3)
					{
						obj20 = obj20;
						num19 = num19;
						num20 = num20;
						double num21 = num14;
						list4 = list4;
						obj21 = obj21;
						Vector3 vector2 = vector3;
						object obj22 = 2;
						bool flag15 = flag9;
						float num22 = num;
						object obj23 = obj10;
						object obj24 = obj13;
						List<(Vector3, Vector3)> list5 = list2;
						(Vector3, Vector3) tuple4 = tuple;
						side4 = side6;
						Vector3 vector4 = vector;
						object obj25 = obj;
						float num23 = num16;
						float num24 = num17;
						float num25 = num18;
						while (true)
						{
							object obj26 = obj22 - 2;
							bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							object obj27 = !flag16;
							if (obj27 != null)
							{
								break;
							}
							object obj28 = obj22 - 1;
							bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							object obj29 = !flag17;
							if (obj29 != null)
							{
								break;
							}
							bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							object obj30 = !flag18;
							if (obj30 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v13+20]");
							object obj31 = 0 + obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
							nint num26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag19 = num26 < 0;
							object obj32 = !flag19;
							if (obj32 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v13+20]");
							object obj33 = 0 + obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
							nint num27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag20 = num27 < 0;
							object obj34 = !flag20;
							if (obj34 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X8_v13+20]");
							object obj35 = 0 + obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1387 @ X9_v13+20]");
							Side side8 = (Side)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1387 @ X9_v13+20]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag21 = num28 < 0;
							object obj36 = !flag21;
							if (obj36 != null)
							{
								break;
							}
							List<(Vector3, Vector3)> list6 = list5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
							object obj37 = list6 + 0;
							List<(Vector3, Vector3)> list7 = list5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1387 @ X9_v13+20]");
							Side side5 = (Side)(list7 + 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X11_v10+20]");
							num15 = 0.0;
							List<(Vector3, Vector3)> list8 = list5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
							object obj38 = list8 + 0;
							List<Vector4> tangents = side5.tangents;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X11_v11+20]");
							(Vector3, Vector3) tuple2 = ((Vector3, Vector3))0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X11_v10+20]");
							Side side9;
							if ((nint)0 > (nint)0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X11_v11+20]");
								if ((nint)0 > (nint)0 && (nint)side5.tangents > 0)
								{
									bool flag22 = side == null;
									side3 = side;
									if (!flag22)
									{
										List<int>[] tris2 = side.tris;
										bool flag23 = side.tris == null;
										side3 = side;
										if (!flag23)
										{
											bool flag24 = (nint)obj15 < tris2.Length;
											object obj39 = !flag24;
											if (obj39 != null)
											{
												break;
											}
											object obj40 = obj25;
											object obj41 = (object)side.tris + obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v100+20]");
											List<int> list9 = (List<int>)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1698 @ X0_v65+E4]");
											bool flag25 = (nint)0 == 0;
											object obj42 = !flag25;
											if (obj42 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
											int item2 = Take(side, s, 0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v100+20]");
											bool flag26 = (nint)0 == 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v100+20]");
											side4 = (Side)0;
											side3 = side;
											if (!flag26)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+10]");
												object obj43 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+1C]");
												object obj44 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+10]");
												bool flag27 = (nint)0 == 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v100+20]");
												side4 = (Side)0;
												side3 = side;
												if (!flag27)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+18]");
													nint num29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v101+18]");
													bool flag28 = num29 < 0;
													object obj45 = !flag28;
													if (obj45 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+10]");
														nint num30 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj46 = num30 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X22_v18 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj47 = (nint)0 + (nint)1;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v100+20]");
														((List<int>)0).AddWithResize(item2);
													}
													List<int>[] tris3 = side.tris;
													bool flag29 = side.tris == null;
													side4 = side2;
													side3 = side;
													if (!flag29)
													{
														bool flag30 = (nint)obj15 < tris3.Length;
														object obj48 = !flag30;
														if (obj48 != null)
														{
															break;
														}
														object obj49 = (object)side.tris + obj15;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v104+20]");
														List<int> list10 = (List<int>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
														int item3 = Take(side, s, 0);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v104+20]");
														bool flag31 = (nint)0 == 0;
														side4 = side2;
														side3 = side;
														if (!flag31)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+10]");
															object obj50 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															object obj51 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+10]");
															bool flag32 = (nint)0 == 0;
															side4 = side2;
															side3 = side;
															if (!flag32)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
																nint num31 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v105+18]");
																bool flag33 = num31 < 0;
																object obj52 = !flag33;
																if (obj52 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+10]");
																	nint num32 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj53 = num32 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X19_v17 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj54 = (nint)0 + (nint)1;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v104+20]");
																	((List<int>)0).AddWithResize(item3);
																}
																List<int>[] tris4 = side.tris;
																bool flag34 = side.tris == null;
																side4 = side2;
																side3 = side;
																if (!flag34)
																{
																	bool flag35 = (nint)obj15 < tris4.Length;
																	object obj55 = !flag35;
																	if (obj55 != null)
																	{
																		break;
																	}
																	object obj56 = (object)side.tris + obj15;
																	side4 = side2;
																	side3 = side;
																	side9 = side;
																	goto IL_2e60;
																}
															}
														}
													}
												}
											}
										}
									}
									goto IL_2d76;
								}
							}
							if (!(num15 > 0.0) && tuple2 <= (object)0)
							{
								bool flag36 = (object)tangents == null;
								obj21 = !flag36;
								if ((nint)tangents <= 0)
								{
									bool flag37 = side4 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
									side3 = (Side)0;
									if (!flag37)
									{
										List<int>[] tris5 = side4.tris;
										bool flag38 = side4.tris == null;
										side3 = side;
										if (!flag38)
										{
											bool flag39 = (nint)obj15 < tris5.Length;
											object obj57 = !flag39;
											if (obj57 != null)
											{
												break;
											}
											object obj58 = obj25;
											object obj59 = (object)side4.tris + obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v84+20]");
											List<int> list11 = (List<int>)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1720 @ X0_v53+E4]");
											bool flag40 = (nint)0 == 0;
											object obj60 = !flag40;
											if (obj60 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
											int item4 = Take(side2, s, 0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v84+20]");
											bool flag41 = (nint)0 == 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v84+20]");
											side4 = (Side)0;
											side3 = side;
											if (!flag41)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
												object obj61 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
												object obj62 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
												bool flag42 = (nint)0 == 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v84+20]");
												side4 = (Side)0;
												side3 = side;
												if (!flag42)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
													nint num33 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v85+18]");
													bool flag43 = num33 < 0;
													object obj63 = !flag43;
													if (obj63 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
														nint num34 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj64 = num34 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X22_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj65 = (nint)0 + (nint)1;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v84+20]");
														((List<int>)0).AddWithResize(item4);
													}
													List<int>[] tris6 = side2.tris;
													bool flag44 = side2.tris == null;
													side4 = side2;
													side3 = side;
													if (!flag44)
													{
														bool flag45 = (nint)obj15 < tris6.Length;
														object obj66 = !flag45;
														if (obj66 != null)
														{
															break;
														}
														object obj67 = (object)side2.tris + obj15;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v88+20]");
														List<int> list12 = (List<int>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
														int item5 = Take(side2, s, 0);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v88+20]");
														bool flag46 = (nint)0 == 0;
														side4 = side2;
														side3 = side;
														if (!flag46)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
															object obj68 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															object obj69 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
															bool flag47 = (nint)0 == 0;
															side4 = side2;
															side3 = side;
															if (!flag47)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
																nint num35 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X8_v89+18]");
																bool flag48 = num35 < 0;
																object obj70 = !flag48;
																if (obj70 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
																	nint num36 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj71 = num36 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X19_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj72 = (nint)0 + (nint)1;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v88+20]");
																	((List<int>)0).AddWithResize(item5);
																}
																List<int>[] tris7 = side2.tris;
																bool flag49 = side2.tris == null;
																side4 = side2;
																side3 = side;
																if (!flag49)
																{
																	bool flag50 = (nint)obj15 < tris7.Length;
																	object obj73 = !flag50;
																	if (obj73 != null)
																	{
																		break;
																	}
																	object obj56 = (object)side2.tris + obj15;
																	side4 = side2;
																	side3 = side;
																	side9 = side2;
																	goto IL_2e60;
																}
															}
														}
													}
												}
											}
										}
									}
									goto IL_2d76;
								}
							}
							bool flag51 = (nint)tangents < 0;
							bool flag52 = (object)tangents == null;
							object obj74 = (object)tangents ^ (object)tangents;
							object obj75 = (object)tangents & obj74;
							bool flag53 = (nint)obj75 < 0;
							bool flag54 = flag51 == flag53;
							object obj76 = !flag52;
							object obj77 = flag54 & obj76;
							bool flag55 = tuple2 < (object)0;
							bool flag56 = tuple2 == ((Vector3, Vector3))(object)0;
							object obj78 = tuple2 ^ tuple2;
							object obj79 = tuple2 & obj78;
							bool flag57 = (nint)obj79 < 0;
							bool flag58 = flag55 == flag57;
							object obj80 = !flag56;
							object obj81 = flag58 & obj80;
							bool flag59 = num15 < 0.0;
							bool flag60 = num15 == 0.0;
							object obj82 = num15 ^ num15;
							object obj83 = num15 & obj82;
							bool flag61 = (nint)obj83 < 0;
							bool flag62 = flag59 == flag61;
							obj21 = !flag60;
							object obj84 = flag62 & obj21;
							Side side10;
							Side side11;
							Side side12;
							if (obj84 != obj81)
							{
								obj24 = obj84 ^ obj77;
								object obj85 = obj24 & 1;
								if (obj85 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
									side10 = (Side)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
									side11 = (Side)0;
									side12 = side8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
									side3 = (Side)0;
									goto IL_2e31;
								}
							}
							bool flag63 = (nint)tangents < 0;
							bool flag64 = (object)tangents == null;
							object obj86 = (object)tangents ^ (object)tangents;
							object obj87 = (object)tangents & obj86;
							bool flag65 = (nint)obj87 < 0;
							object obj88 = obj84 ^ obj81;
							bool flag66 = flag63 == flag65;
							object obj89 = !flag64;
							object obj90 = flag66 & obj89;
							bool flag67 = tuple2 < (object)0;
							bool flag68 = tuple2 == ((Vector3, Vector3))(object)0;
							object obj91 = tuple2 ^ tuple2;
							object obj92 = tuple2 & obj91;
							bool flag69 = (nint)obj92 < 0;
							bool flag70 = flag67 == flag69;
							obj21 = !flag68;
							object obj93 = flag70 & obj21;
							object obj94 = obj93 ^ obj90;
							object obj95 = obj88 & obj94;
							object obj96 = obj95 & 1;
							if (obj96 != null)
							{
								side10 = side8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
								side11 = (Side)0;
								obj23 = obj93;
								obj24 = obj90;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
								side12 = (Side)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
								side3 = (Side)0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v18+20]");
								side10 = (Side)0;
								side11 = side8;
								obj23 = obj93;
								obj24 = obj90;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
								side12 = (Side)0;
								side3 = side8;
							}
							goto IL_2e31;
							IL_2c5c:
							object obj97 = obj22 + 3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X11_v9+18]");
							obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X11_v9+18]");
							bool flag71 = (nint)obj97 < 0;
							num14 = num21;
							flag9 = flag15;
							num = num22;
							obj10 = obj23;
							obj13 = obj24;
							list2 = list5;
							side6 = side4;
							side7 = side3;
							vector = vector4;
							obj = obj25;
							num16 = num23;
							num17 = num24;
							num18 = num25;
							vector2 = vector3;
							obj22 = obj97;
							tuple4 = tuple;
							if (flag71)
							{
								continue;
							}
							goto IL_2d1e;
							IL_2e31:
							Side side13 = side11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag72 = (nint)side13 < 0;
							object obj98 = !flag72;
							if (obj98 != null)
							{
								break;
							}
							object obj99 = (object)list + (object)side3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							bool flag73 = (nint)0 < (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							bool flag74 = (nint)0 == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							nint num37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							object obj100 = num37 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							object obj101 = 0 & obj100;
							bool flag75 = (nint)obj101 < 0;
							bool flag76 = flag73 == flag75;
							object obj102 = !flag76;
							object obj103 = obj102 | flag74;
							object obj104 = ~obj103;
							Side side14 = ((obj104 != null) ? side : side4);
							bool flag77 = flag73 == flag75;
							object obj105 = !flag77;
							object obj106 = obj105 | flag74;
							flag15 = (byte)(int)(~obj106) != 0;
							Side side15 = (flag15 ? side4 : side);
							Side side16 = side10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag78 = (nint)side16 < 0;
							object obj107 = !flag78;
							if (obj107 != null)
							{
								break;
							}
							Side side17 = side12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X23_v9 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							bool flag79 = (nint)side17 < 0;
							object obj108 = !flag79;
							if (obj108 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
							object obj109 = 0;
							object obj110 = obj109;
							object obj111 = (object)list + (object)side10;
							object obj112 = (object)list + (object)side12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X9_v25+20]");
							num23 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1759 @ X0_v24+E4]");
							bool flag80 = (nint)0 == 0;
							object obj113 = !flag80;
							int j = (int)side10;
							if (obj113 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								j = (int)side10;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							nint num38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v29+20]");
							object obj114 = num38 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							num24 = 0f / (float)obj114;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							float num39 = 0f - num23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X9_v22+20]");
							num25 = 0f / num39;
							int item6 = OnEdge(side14, s, (int)side11, j, num24);
							int item7 = OnEdge(side14, s, (int)side11, (int)side12, num25);
							bool flag81 = side14 == null;
							side4 = side12;
							if (!flag81)
							{
								List<int>[] tris8 = side14.tris;
								bool flag82 = side14.tris == null;
								side4 = side12;
								if (!flag82)
								{
									bool flag83 = (nint)obj15 < tris8.Length;
									object obj115 = !flag83;
									if (obj115 != null)
									{
										break;
									}
									object obj116 = (object)side14.tris + obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
									List<int> list13 = (List<int>)0;
									int item8 = Take(side14, s, (int)side11);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
									bool flag84 = (nint)0 == 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
									side4 = (Side)0;
									if (!flag84)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+10]");
										object obj117 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+1C]");
										object obj118 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+10]");
										bool flag85 = (nint)0 == 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
										side4 = (Side)0;
										if (!flag85)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
											nint num40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v32+18]");
											bool flag86 = num40 < 0;
											object obj119 = !flag86;
											if (obj119 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+10]");
												nint num41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
												object obj120 = num41 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X22_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
												object obj121 = (nint)0 + (nint)1;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
												((List<int>)0).AddWithResize(item8);
											}
											List<int>[] tris9 = side14.tris;
											bool flag87 = side14.tris == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
											side4 = (Side)0;
											if (!flag87)
											{
												bool flag88 = (nint)obj15 < tris9.Length;
												object obj122 = !flag88;
												if (obj122 != null)
												{
													break;
												}
												object obj123 = (object)side14.tris + obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v32+20]");
												List<int> list14 = (List<int>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v32+20]");
												bool flag89 = (nint)0 == 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
												side4 = (Side)0;
												if (!flag89)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+10]");
													object obj124 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+1C]");
													object obj125 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+10]");
													bool flag90 = (nint)0 == 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
													side4 = (Side)0;
													if (!flag90)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+18]");
														nint num42 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X9_v33+18]");
														bool flag91 = num42 < 0;
														object obj126 = !flag91;
														List<int>[] tris10;
														if (obj126 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+10]");
															nint num43 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj127 = num43 + 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v33 (System.Collections.Generic.List`1<System.Int32>)+18]");
															object obj128 = (nint)0 + (nint)1;
															tris10 = side14.tris;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v32+20]");
															((List<int>)0).AddWithResize(item6);
															tris10 = side14.tris;
															bool flag92 = side14.tris == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
															side4 = (Side)0;
															if (flag92)
															{
																goto IL_2d76;
															}
														}
														bool flag93 = (nint)obj15 < tris10.Length;
														object obj129 = !flag93;
														if (obj129 != null)
														{
															break;
														}
														object obj130 = (object)tris10 + obj15;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v36+20]");
														List<int> list15 = (List<int>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v36+20]");
														bool flag94 = (nint)0 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
														side4 = (Side)0;
														if (!flag94)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
															object obj131 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+1C]");
															object obj132 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
															bool flag95 = (nint)0 == 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v31+20]");
															side4 = (Side)0;
															if (!flag95)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
																nint num44 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v37+18]");
																bool flag96 = num44 < 0;
																object obj133 = !flag96;
																if (obj133 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
																	nint num45 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj134 = num45 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	object obj135 = (nint)0 + (nint)1;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v36+20]");
																	((List<int>)0).AddWithResize(item7);
																}
																int num46 = OnEdge(side15, s, (int)side11, (int)side10, num24);
																int item9 = OnEdge(side15, s, (int)side11, (int)side12, num25);
																int num47 = Take(side15, s, (int)side10);
																int item10 = Take(side15, s, (int)side12);
																bool flag97 = side15 == null;
																side4 = (Side)num47;
																if (!flag97)
																{
																	List<int>[] tris11 = side15.tris;
																	bool flag98 = side15.tris == null;
																	side4 = (Side)num47;
																	if (!flag98)
																	{
																		bool flag99 = (nint)obj15 < tris11.Length;
																		object obj136 = !flag99;
																		if (obj136 != null)
																		{
																			break;
																		}
																		object obj137 = (object)side15.tris + obj15;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X9_v41+20]");
																		List<int> list16 = (List<int>)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X9_v41+20]");
																		bool flag100 = (nint)0 == 0;
																		side4 = (Side)num47;
																		if (!flag100)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+10]");
																			object obj138 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																			object obj139 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																			object obj140 = (nint)0 + (nint)1;
																			object obj141 = obj139;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+10]");
																			bool flag101 = (nint)0 == 0;
																			side4 = (Side)num47;
																			if (!flag101)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+18]");
																				nint num48 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X9_v42+18]");
																				bool flag102 = num48 < 0;
																				object obj142 = !flag102;
																				int num50;
																				List<int>[] tris12;
																				if (obj142 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+10]");
																					nint num49 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+18]");
																					object obj143 = num49 + 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v43 (System.Collections.Generic.List`1<System.Int32>)+18]");
																					object obj144 = (nint)0 + (nint)1;
																					num50 = (int)side12;
																					tris12 = side15.tris;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X10_v29+20]");
																					object obj145 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X8_v71+A8]");
																					object obj146 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ X8_v72+70]");
																					num50 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X9_v41+20]");
																					((List<int>)0).AddWithResize(num46);
																					tris12 = side15.tris;
																					bool flag103 = side15.tris == null;
																					side4 = (Side)num47;
																					if (flag103)
																					{
																						goto IL_2d76;
																					}
																				}
																				bool flag104 = (nint)obj15 < tris12.Length;
																				object obj147 = !flag104;
																				if (obj147 != null)
																				{
																					break;
																				}
																				object obj148 = (object)tris12 + obj15;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X9_v45+20]");
																				List<int> list17 = (List<int>)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X9_v45+20]");
																				bool flag105 = (nint)0 == 0;
																				side4 = (Side)num47;
																				if (!flag105)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+10]");
																					object obj149 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																					object obj150 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																					object obj151 = (nint)0 + (nint)1;
																					object obj152 = obj150;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+10]");
																					bool flag106 = (nint)0 == 0;
																					side4 = (Side)num47;
																					if (!flag106)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+18]");
																						nint num51 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X9_v46+18]");
																						bool flag107 = num51 < 0;
																						object obj153 = !flag107;
																						List<int>[] array;
																						if (obj153 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+10]");
																							nint num52 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+18]");
																							object obj154 = num52 + 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v44 (System.Collections.Generic.List`1<System.Int32>)+18]");
																							object obj155 = (nint)0 + (nint)1;
																							array = tris12;
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33+20]");
																							object obj156 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ X8_v68+A8]");
																							object obj157 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1940 @ X8_v69+70]");
																							num50 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X9_v45+20]");
																							((List<int>)0).AddWithResize(num47);
																							array = side15.tris;
																							bool flag108 = side15.tris == null;
																							side4 = (Side)num47;
																							if (flag108)
																							{
																								goto IL_2d76;
																							}
																						}
																						bool flag109 = (nint)obj15 < array.Length;
																						object obj158 = !flag109;
																						if (obj158 != null)
																						{
																							break;
																						}
																						object obj159 = (object)array + obj15;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X9_v49+20]");
																						List<int> list18 = (List<int>)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X9_v49+20]");
																						bool flag110 = (nint)0 == 0;
																						side4 = side2;
																						if (!flag110)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
																							object obj160 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																							object obj161 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																							object obj162 = (nint)0 + (nint)1;
																							object obj163 = obj161;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
																							bool flag111 = (nint)0 == 0;
																							side4 = side2;
																							if (!flag111)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
																								nint num53 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X9_v50+18]");
																								bool flag112 = num53 < 0;
																								object obj164 = !flag112;
																								List<int>[] array2;
																								if (obj164 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
																									nint num54 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
																									object obj165 = num54 + 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
																									object obj166 = (nint)0 + (nint)1;
																									array2 = array;
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X10_v37+20]");
																									object obj167 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X8_v65+A8]");
																									object obj168 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ X8_v66+70]");
																									num50 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X9_v49+20]");
																									((List<int>)0).AddWithResize(item10);
																									array2 = side15.tris;
																									bool flag113 = side15.tris == null;
																									side4 = side2;
																									if (flag113)
																									{
																										goto IL_2d76;
																									}
																								}
																								bool flag114 = (nint)obj15 < array2.Length;
																								object obj169 = !flag114;
																								if (obj169 != null)
																								{
																									break;
																								}
																								object obj170 = (object)array2 + obj15;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X9_v53+20]");
																								List<int> list19 = (List<int>)0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X9_v53+20]");
																								bool flag115 = (nint)0 == 0;
																								side4 = side2;
																								if (!flag115)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+10]");
																									object obj171 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																									object obj172 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																									object obj173 = (nint)0 + (nint)1;
																									object obj174 = obj172;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+10]");
																									bool flag116 = (nint)0 == 0;
																									side4 = side2;
																									if (!flag116)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+18]");
																										nint num55 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X9_v54+18]");
																										bool flag117 = num55 < 0;
																										object obj175 = !flag117;
																										List<int>[] array3;
																										if (obj175 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+10]");
																											nint num56 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+18]");
																											object obj176 = num56 + 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v46 (System.Collections.Generic.List`1<System.Int32>)+18]");
																											object obj177 = (nint)0 + (nint)1;
																											array3 = array2;
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v41+20]");
																											object obj178 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v62+A8]");
																											object obj179 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1960 @ X8_v63+70]");
																											num50 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X9_v53+20]");
																											((List<int>)0).AddWithResize(num46);
																											array3 = side15.tris;
																											bool flag118 = side15.tris == null;
																											side4 = side2;
																											if (flag118)
																											{
																												goto IL_2d76;
																											}
																										}
																										bool flag119 = (nint)obj15 < array3.Length;
																										object obj180 = !flag119;
																										if (obj180 != null)
																										{
																											break;
																										}
																										object obj181 = (object)array3 + obj15;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X9_v57+20]");
																										List<int> list20 = (List<int>)0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X9_v57+20]");
																										bool flag120 = (nint)0 == 0;
																										side4 = side2;
																										if (!flag120)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
																											object obj182 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																											object obj183 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																											object obj184 = (nint)0 + (nint)1;
																											object obj185 = obj183;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
																											bool flag121 = (nint)0 == 0;
																											side4 = side2;
																											if (!flag121)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
																												nint num57 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X9_v58+18]");
																												bool flag122 = num57 < 0;
																												object obj186 = !flag122;
																												List<int>[] array4;
																												if (obj186 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+10]");
																													nint num58 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
																													object obj187 = num58 + 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v47 (System.Collections.Generic.List`1<System.Int32>)+18]");
																													object obj188 = (nint)0 + (nint)1;
																													array4 = array3;
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X10_v45+20]");
																													object obj189 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ X8_v59+A8]");
																													object obj190 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v60+70]");
																													num50 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X9_v57+20]");
																													((List<int>)0).AddWithResize(item10);
																													array4 = side15.tris;
																													bool flag123 = side15.tris == null;
																													side4 = side2;
																													if (flag123)
																													{
																														goto IL_2d76;
																													}
																												}
																												bool flag124 = (nint)obj15 < array4.Length;
																												object obj191 = !flag124;
																												if (obj191 != null)
																												{
																													break;
																												}
																												object obj192 = (object)array4 + obj15;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v45+20]");
																												List<int> list21 = (List<int>)0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v45+20]");
																												bool flag125 = (nint)0 == 0;
																												side4 = side2;
																												if (!flag125)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+10]");
																													object obj193 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																													object obj194 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																													object obj195 = (nint)0 + (nint)1;
																													object obj196 = obj194;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+10]");
																													bool flag126 = (nint)0 == 0;
																													side4 = side2;
																													if (!flag126)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+18]");
																														nint num59 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X8_v46+18]");
																														bool flag127 = num59 < 0;
																														object obj197 = !flag127;
																														if (obj197 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+10]");
																															nint num60 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+18]");
																															object obj198 = num60 + 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v48 (System.Collections.Generic.List`1<System.Int32>)+18]");
																															object obj199 = (nint)0 + (nint)1;
																															vector3 = (Vector3)num50;
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X9_v63+20]");
																															object obj200 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1981 @ X8_v56+A8]");
																															object obj201 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1983 @ X8_v57+70]");
																															vector3 = (Vector3)0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v45+20]");
																															((List<int>)0).AddWithResize(item9);
																														}
																														Vector3[] at3 = s.at;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
																														obj25 = 0;
																														bool flag128 = s.at == null;
																														side4 = side2;
																														if (!flag128)
																														{
																															bool flag129 = (nint)side11 < at3.Length;
																															object obj202 = !flag129;
																															if (obj202 != null)
																															{
																																break;
																															}
																															bool flag130 = (nint)side10 < at3.Length;
																															object obj203 = !flag130;
																															if (obj203 != null)
																															{
																																break;
																															}
																															bool flag131 = num24 < 0f;
																															double num61 = 0.0;
																															if (!flag131)
																															{
																																bool flag132 = !((double)num24 > 1.0);
																																num61 = num24;
																																if (!flag132)
																																{
																																	num61 = 1.0;
																																}
																															}
																															bool flag133 = (nint)side12 < at3.Length;
																															object obj204 = !flag133;
																															if (obj204 != null)
																															{
																																break;
																															}
																															bool flag134 = num25 < 0f;
																															double num62 = 0.0;
																															if (!flag134)
																															{
																																bool flag135 = !((double)num25 > 1.0);
																																num62 = num25;
																																if (!flag135)
																																{
																																	num62 = 1.0;
																																}
																															}
																															object obj205 = side3 * 12;
																															object obj206 = (object)s.at + obj205;
																															object obj207 = side10 * 12;
																															object obj208 = (object)s.at + obj207;
																															object obj209 = side12 * 12;
																															object obj210 = (object)s.at + obj209;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v52+28]");
																															nint num63 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+28]");
																															object obj211 = num63 - 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ X8_v49+20]");
																															nint num64 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+20]");
																															object obj212 = num64 - 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ X8_v49+28]");
																															nint num65 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+28]");
																															obj20 = num65 - 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F8]");
																															object obj213 = 0;
																															num20 = (double)obj211 * num61;
																															object obj214 = obj212 * obj215;
																															double num66 = (double)obj20 * num62;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+20]");
																															num22 = 0f + (float)obj214;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+28]");
																															num15 = 0.0 + num20;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X9_v66+28]");
																															num21 = 0.0 + num66;
																															(Vector3, Vector3) tuple5 = ((Vector3)obj213, vector3);
																															bool flag136 = p == (Vector3)(object)0;
																															side4 = side2;
																															if (!flag136)
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+10]");
																																object obj216 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F0]");
																																object obj217 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+1C]");
																																object obj218 = (nint)0 + (nint)1;
																																object obj219 = obj217;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+10]");
																																bool flag137 = (nint)0 == 0;
																																side4 = side2;
																																side3 = side;
																																if (!flag137)
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
																																	object obj6 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
																																	nint num67 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v52+18]");
																																	bool flag138 = num67 < 0;
																																	object obj220 = !flag138;
																																	if (obj220 == null)
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
																																		object obj221 = (nint)0 * (nint)24;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+10]");
																																		object obj222 = 0 + obj221;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
																																		object obj223 = (nint)0 + (nint)1;
																																		_ = 0;
																																		_ = 0;
																																		tuple5 = ((Vector3, Vector3))0;
																																		num19 = num68;
																																		list4 = (List<(Vector3, Vector3)>)(object)side12;
																																		side8 = side11;
																																		tangents = list22;
																																		tuple2 = ((Vector3, Vector3))0;
																																		obj6 = 0;
																																		side5 = side12;
																																		list5 = list;
																																		tuple = ((Vector3, Vector3))obj213;
																																		side4 = side2;
																																		side3 = side;
																																		vector4 = p;
																																		list3 = (List<int>)num46;
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X9_v69+20]");
																																		object obj224 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2074 @ X8_v53+A8]");
																																		object obj225 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ X8_v54+70]");
																																		vector3 = (Vector3)0;
																																		((List<(Vector3, Vector3)>)p).AddWithResize(((Vector3, Vector3))(&tuple6));
																																		tuple5 = ((Vector3, Vector3))0;
																																		num19 = num68;
																																		tuple6 = ((Vector3, Vector3))0;
																																		list4 = (List<(Vector3, Vector3)>)(object)side12;
																																		side8 = side11;
																																		tangents = list22;
																																		tuple2 = ((Vector3, Vector3))0;
																																		side5 = side12;
																																		list5 = list;
																																		tuple = ((Vector3, Vector3))(&tuple6);
																																		side4 = side2;
																																		side3 = side;
																																		vector4 = p;
																																		list3 = (List<int>)num46;
																																	}
																																	goto IL_2c5c;
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
															}
														}
													}
												}
											}
										}
									}
								}
							}
							goto IL_2d76;
							IL_2e60:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v20+20]");
							list3 = (List<int>)0;
							int num69 = Take(side9, s, (int)side8);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v20+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj226 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
								object obj227 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj228 = (nint)0 + (nint)1;
								object obj229 = obj227;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v21+18]");
									bool flag139 = num70 < 0;
									object obj230 = !flag139;
									if (obj230 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
										nint num71 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj231 = num71 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X19_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj232 = (nint)0 + (nint)1;
										vector3 = (Vector3)side8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
										side15 = (Side)0;
										tuple = ((Vector3, Vector3))num69;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X9_v18+20]");
										object obj233 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1844 @ X8_v22+A8]");
										object obj234 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v23+70]");
										vector3 = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v20+20]");
										((List<int>)0).AddWithResize(num69);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X9_v12+20]");
										side15 = (Side)0;
										tuple = ((Vector3, Vector3))num69;
									}
									goto IL_2c5c;
								}
							}
							goto IL_2d76;
						}
						break;
					}
					goto IL_2d1e;
				}
				goto IL_2d76;
			}
			(System.__Canon, System.__Canon) tuple7 = ((System.__Canon)(object)side3, item);
			return ((Side, Side))0;
			IL_2d1e:
			tris = s.tris;
			obj15++;
			bool flag140 = s.tris == null;
			object obj235 = !flag140;
			side4 = side6;
			side3 = side7;
			if (obj235 != null)
			{
				continue;
			}
			goto IL_2d76;
		}
		goto IL_2da1;
		IL_2d76:
		item = (System.__Canon)(object)side4;
		throw new NullReferenceException();
	}

	private unsafe static List<int> Cap(List<(Vector3, Vector3)> segments, Vector3 p, Vector3 n, out List<Vector3> at, out List<float> lip)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected VT, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_8724: Expected Obj, but got Ref
		//IL_878d: Expected Obj, but got I4
		//IL_87b9: Expected F4, but got Obj
		//IL_87b4: Expected native int or pointer, but got VT
		//IL_007c: Expected F4, but got Obj
		//IL_0077: Expected native int or pointer, but got VT
		//IL_00a6: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_87d8: Expected Obj, but got I
		//IL_87e0: Expected Obj, but got Ref
		//IL_87fd: Expected F4, but got Obj
		//IL_883d: Expected F4, but got Obj
		//IL_8845: Expected Obj, but got F4
		//IL_00f0: Expected I, but got Obj
		//IL_8fec: Expected VT, but got Ref
		//IL_8ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b05: Expected Obj, but got I
		//IL_8b15: Expected F4, but got I
		//IL_8b25: Expected Obj, but got I
		//IL_8b45: Expected Obj, but got I
		//IL_8b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got I
		//IL_9203: Expected I4, but got Obj
		//IL_a1ea: Expected Obj, but got I
		//IL_a1f2: Expected I4, but got Obj
		//IL_a203: Expected Obj, but got F4
		//IL_a211: Expected Obj, but got I4
		//IL_a215: Unknown result type (might be due to invalid IL or missing references)
		//IL_a221: Expected I4, but got VT
		//IL_a232: Expected Obj, but got F4
		//IL_0188: Expected Obj, but got I
		//IL_8063: Expected Obj, but got I4
		//IL_2302: Expected VT, but got I
		//IL_2327: Expected Obj, but got I4
		//IL_232b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got Ref
		//IL_01e0: Expected Obj, but got Ref
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got I
		//IL_0254: Expected Obj, but got F4
		//IL_8095: Expected Obj, but got F4
		//IL_8020: Expected Obj, but got F4
		//IL_8028: Expected I4, but got VT
		//IL_8030: Expected Obj, but got F4
		//IL_25d2: Expected Obj, but got I4
		//IL_25fc: Expected Obj, but got VT
		//IL_260d: Expected Obj, but got VT
		//IL_2396: Expected Obj, but got I4
		//IL_9f72: Expected Obj, but got I
		//IL_9f7a: Expected I4, but got Obj
		//IL_9fc1: Expected Obj, but got I4
		//IL_9fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_a009: Expected VT, but got Ref
		//IL_912d: Expected Obj, but got I
		//IL_913a: Expected I4, but got Obj
		//IL_913a: Expected Obj, but got VT
		//IL_0261: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I4
		//IL_9192: Expected Obj, but got I4
		//IL_7ec7: Expected VT, but got Obj
		//IL_02ad: Expected VT, but got Ref
		//IL_02be: Expected VT, but got Ref
		//IL_7eeb: Expected Obj, but got I4
		//IL_7eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b0: Expected Obj, but got I
		//IL_23c4: Expected VT, but got I
		//IL_23cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d2: Expected I4, but got Unknown
		//IL_23df: Expected Obj, but got VT
		//IL_02dd: Expected F4, but got Obj
		//IL_0305: Expected F4, but got Obj
		//IL_2407: Expected VT, but got Obj
		//IL_240f: Expected F4, but got Obj
		//IL_2427: Expected Obj, but got I
		//IL_2437: Expected Obj, but got F4
		//IL_26f0: Expected Obj, but got I
		//IL_2715: Expected Obj, but got I
		//IL_2725: Unknown result type (might be due to invalid IL or missing references)
		//IL_272a: Expected Obj, but got Unknown
		//IL_033b: Expected I, but got Obj
		//IL_035d: Expected Obj, but got I4
		//IL_8100: Expected F4, but got Obj
		//IL_8108: Expected VT, but got I4
		//IL_2452: Expected VT, but got I4
		//IL_2467: Expected Obj, but got I
		//IL_811d: Expected I4, but got Obj
		//IL_91e0: Expected Obj, but got I4
		//IL_91e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_91ed: Expected I4, but got Unknown
		//IL_277a: Invalid comparison between F4 and I4
		//IL_2789: Invalid comparison between F4 and I4
		//IL_2797: Unknown result type (might be due to invalid IL or missing references)
		//IL_279c: Expected Obj, but got Unknown
		//IL_27a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a9: Expected Obj, but got Unknown
		//IL_910f: Expected Obj, but got I4
		//IL_03a9: Expected VT, but got Ref
		//IL_03b1: Expected F4, but got Obj
		//IL_03d9: Expected F4, but got Obj
		//IL_2a29: Expected Obj, but got I
		//IL_2a48: Expected F4, but got Obj
		//IL_2a56: Expected Obj, but got I4
		//IL_2a5e: Expected Obj, but got F4
		//IL_2a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7f: Expected Obj, but got F4
		//IL_2a87: Expected F4, but got Obj
		//IL_2a8f: Expected Obj, but got F4
		//IL_2a9f: Expected Obj, but got F4
		//IL_24ba: Expected Obj, but got I4
		//IL_24f4: Expected Obj, but got F4
		//IL_253a: Expected Obj, but got F4
		//IL_2552: Expected F4, but got Obj
		//IL_255a: Expected Obj, but got F4
		//IL_257a: Expected Obj, but got F4
		//IL_2582: Expected F4, but got Obj
		//IL_258a: Expected Obj, but got F4
		//IL_259a: Expected Obj, but got F4
		//IL_2801: Expected F4, but got Obj
		//IL_280f: Expected Obj, but got I4
		//IL_2817: Expected Obj, but got F4
		//IL_281b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2838: Expected Obj, but got F4
		//IL_2840: Expected F4, but got Obj
		//IL_2848: Expected Obj, but got F4
		//IL_2858: Expected Obj, but got F4
		//IL_2aca: Expected Obj, but got I
		//IL_2ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b0e: Expected F4, but got Obj
		//IL_2b1c: Expected Obj, but got I4
		//IL_2b24: Expected Obj, but got F4
		//IL_2b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b45: Expected Obj, but got F4
		//IL_2b4d: Expected F4, but got Obj
		//IL_2b55: Expected Obj, but got F4
		//IL_2b65: Expected Obj, but got F4
		//IL_2876: Expected Obj, but got I
		//IL_2886: Expected Obj, but got I
		//IL_28a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c8: Expected F4, but got Obj
		//IL_28d6: Expected Obj, but got I4
		//IL_28de: Expected Obj, but got F4
		//IL_28e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ff: Expected Obj, but got F4
		//IL_2907: Expected F4, but got Obj
		//IL_290f: Expected Obj, but got F4
		//IL_291f: Expected Obj, but got F4
		//IL_2b8a: Expected Obj, but got I4
		//IL_2baa: Expected Obj, but got I4
		//IL_2ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd8: Expected Obj, but got VT
		//IL_2ce8: Expected Obj, but got I
		//IL_2cf8: Expected VT, but got I
		//IL_2d0d: Expected Obj, but got VT
		//IL_2d0d: Expected Obj, but got I
		//IL_2d15: Expected F4, but got Obj
		//IL_2d1d: Expected Obj, but got F4
		//IL_2d25: Expected Obj, but got F4
		//IL_2d2d: Expected F4, but got Obj
		//IL_2d35: Expected Obj, but got F4
		//IL_2d45: Expected Obj, but got F4
		//IL_294d: Expected Obj, but got I
		//IL_2976: Expected Obj, but got I4
		//IL_2bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcf: Expected Obj, but got Unknown
		//IL_2bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfd: Expected Obj, but got Unknown
		//IL_2c05: Expected Obj, but got VT
		//IL_2c17: Expected F4, but got Obj
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c27: Expected Obj, but got F4
		//IL_2c2f: Expected Obj, but got F4
		//IL_2c37: Expected F4, but got Obj
		//IL_2c3f: Expected Obj, but got F4
		//IL_2c4f: Expected Obj, but got F4
		//IL_2c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c61: Expected Obj, but got VT
		//IL_2c71: Expected Obj, but got I
		//IL_2c81: Expected VT, but got I
		//IL_2c8e: Expected Obj, but got VT
		//IL_2c96: Expected F4, but got Obj
		//IL_2c9e: Expected Obj, but got F4
		//IL_2ca6: Expected Obj, but got F4
		//IL_2cae: Expected F4, but got Obj
		//IL_2cb6: Expected Obj, but got F4
		//IL_2cc6: Expected Obj, but got F4
		//IL_29a1: Expected Obj, but got I
		//IL_29b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ca: Expected Obj, but got Unknown
		//IL_29d2: Expected Obj, but got VT
		//IL_29e4: Expected F4, but got Obj
		//IL_29ec: Expected Obj, but got F4
		//IL_29f4: Expected Obj, but got F4
		//IL_29fc: Expected F4, but got Obj
		//IL_2a04: Expected Obj, but got F4
		//IL_2a14: Expected Obj, but got F4
		//IL_7fd8: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
		Vector3 vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		List<Vector3> list = (List<Vector3>)0;
		Enumerator<, > val = default;
		object obj3 = (object)(&val);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		obj3 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list2 = default;
		list2._002Ector();
		((Vector3*)(nint)p)->x = (float)list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<float> list3 = default;
		list3._002Ector();
		((Vector3*)(nint)n)->x = (float)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list4 = default;
		list4._002Ector();
		nint num2 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v12 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		nint num3 = num2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)list;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v13 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+A0]");
		object obj5 = 0;
		object obj6 = (object)(&val);
		_ = 0;
		bool flag2 = segments == null;
		List<int> list5 = default;
		float num4 = (float)list5;
		float num6 = default;
		float num5 = num6;
		List<int> list7 = default;
		List<int> list6 = list7;
		Vector3 vector2 = n;
		Vector3 vector3 = p;
		Vector3 vector4 = n;
		List<float> list8 = list3;
		List<int> list10 = default;
		List<int> list9 = list10;
		NullReferenceException ex = default;
		float num7 = (float)ex;
		float num8 = default;
		NullReferenceException ex2 = (NullReferenceException)num8;
		List<int> list11 = list7;
		float num9 = num6;
		List<int> list12 = list5;
		GillaSonar._003C_003Ec__DisplayClass52_0 obj9 = default;
		float num12 = default;
		int num13;
		float num17 = default;
		List<int> list17;
		int num22;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [segments @ X0 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
			bool flag3 = (nint)0 < (nint)3;
			List<int> result = list4;
			if (flag3)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B68]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<Vector3Int, System.__Canon> dictionary = default;
			dictionary._002Ector();
			int num10 = (int)(&val);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list13 = default;
			list13._002Ector();
			object obj8 = (nint)(&obj9) | (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B70]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<int, System.__Canon> dictionary2 = default;
			dictionary2._002Ector();
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 16));
			object obj12 = (object)(&val);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Enumerator<, > enumerator = segments.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7620]");
			object obj13 = 0;
			vector2 = n;
			NullReferenceException ex4 = default;
			NullReferenceException ex3 = ex4;
			float num11 = num12;
			num13 = (int)(&val);
			list9 = list10;
			NullReferenceException ex5 = ex;
			ex2 = (NullReferenceException)num8;
			Enumerator<, > val2 = default;
			List<int> list14 = default;
			float num18 = default;
			List<int> list16 = default;
			float num20 = default;
			NullReferenceException ex6 = default;
			NullReferenceException ex7 = default;
			while (val2.MoveNext())
			{
				nint num14 = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3614 @ X0_v693 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num15 = _003CCap_003Eg__PointOf_007C52_0((Vector3)(&obj9), ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)obj13);
				int num16 = _003CCap_003Eg__PointOf_007C52_0((Vector3)(&obj9), ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)obj13);
				bool flag5 = num15 == num16;
				num8 = (float)list14;
				num17 = num18;
				List<int> list15 = list16;
				float num19 = num20;
				ex3 = ex6;
				num11 = (float)ex7;
				num13 = num16;
				list9 = list14;
				ex5 = ex6;
				ex2 = ex7;
				if (!flag5)
				{
					nint num21 = (nint)list;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4515 @ X0_v699 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.Vector3>>)+E4]");
					bool flag6 = (nint)0 == 0;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					_003CCap_003Eg__Link_007C52_1(num15, num16, ref obj9);
					_003CCap_003Eg__Link_007C52_1(num16, num15, ref obj9);
					vector2 = (Vector3)(&obj9);
					num8 = (float)list14;
					num17 = num18;
					list15 = list16;
					num19 = num20;
					ex3 = ex6;
					num11 = (float)ex7;
					num13 = num16;
					list9 = list14;
					ex5 = ex6;
					ex2 = ex7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7610]");
			object obj16 = 0;
			num22 = (int)obj16;
			val2.Dispose();
			list17 = list5;
			num5 = num6;
			list6 = list7;
			ex4 = null;
			object obj17 = 0;
			Enumerator<, > val3 = (Enumerator<, >)(ref val2);
			ex = ex3;
			Enumerator<, > val4 = (Enumerator<, >)(ref val2);
			List<int> list18 = list4;
			List<(Vector3, Vector3)> list19 = segments;
			vector3 = p;
			vector4 = n;
			result = list4;
			Vector3 vector5 = (Vector3)(&obj9);
			nint num23 = 5;
			num9 = num6;
			list12 = list5;
		}
		else
		{
			NullReferenceException ex8 = new NullReferenceException();
			List<System.__Canon> list20 = default;
			List<int> result = (List<int>)(object)list20;
			List<System.__Canon> list21 = (List<System.__Canon>)(object)ex8;
			Vector3 vector5 = (Vector3)(&val);
			Enumerator<, > enumerator2 = list21.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A30]");
			List<(Vector3, Vector3)> list19 = (List<(Vector3, Vector3)>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num19 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
			list = (List<Vector3>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			object obj18 = 0;
			Enumerator<, > val5 = default;
			Enumerator<, > val3 = (Enumerator<, >)(ref val5);
			float num11 = num12;
			while (true)
			{
				num22 = (int)list19;
				NullReferenceException ex4;
				object obj17;
				Enumerator<, > val4;
				nint num23;
				if (val5.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+30]");
					vector4 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+30]");
					bool flag7 = (nint)0 == 0;
					ex4 = null;
					obj17 = 0;
					val4 = (Enumerator<, >)(ref val5);
					num23 = 1;
					if (flag7)
					{
						goto IL_7ff3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X24_v67 (UnityEngine.Vector3)+18]");
					bool flag8 = (nint)0 < (nint)2;
					float num24 = num8;
					List<int> list15 = null;
					NullReferenceException ex9 = ex;
					float num25 = num11;
					if (!flag8)
					{
						List<int> list22 = null;
						List<float> list23 = (List<float>)1;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
							List<Vector3> list24 = (List<Vector3>)0;
							int num26 = ((List<int>)vector4).get_Item((int)list23);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
								Vector3 vector6 = ((List<Vector3>)0).get_Item(num26);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
								vector3 = (Vector3)0;
								int num27 = list23 - 1;
								int num28 = ((List<int>)vector4).get_Item(num27);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
								bool flag9 = (nint)0 == 0;
								vector2 = (Vector3)list;
								num17 = (float)ex;
								num22 = num28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
								list24 = (List<Vector3>)0;
								num9 = num11;
								list12 = (List<int>)num8;
								if (!flag9)
								{
									vector2 = (Vector3)((int*)num)->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+98]");
									Vector3 vector7 = ((List<Vector3>)0).get_Item(num28);
									float x = vector.x;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4278 @ X0_v439 (System.Single)+E4]");
									bool flag10 = (nint)0 == 0;
									object obj19 = !flag10;
									if (obj19 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num29 = num11 - num11;
									float num30 = (float)ex - (float)ex;
									num24 = num8 - num8;
									list8 = (List<float>)(num27 + 2);
									float num31 = num29 * num29;
									float num32 = num30 * num30;
									float num33 = num31 + num32;
									ex9 = (NullReferenceException)(num24 * num24);
									num25 = (float)ex9 + num33;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num34 = (float)list22 + num25;
									List<float> list25 = list8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X24_v67 (UnityEngine.Vector3)+18]");
									bool flag11 = (nint)list25 < 0;
									list15 = (List<int>)num34;
									num22 = num28;
									num8 = num24;
									num17 = (float)ex;
									list22 = (List<int>)num34;
									ex = ex9;
									num11 = num25;
									list23 = list8;
									list9 = (List<int>)num24;
									num7 = (float)ex9;
									ex2 = (NullReferenceException)num25;
									num9 = num25;
									list12 = (List<int>)num24;
									if (!flag11)
									{
										break;
									}
									continue;
								}
							}
							else
							{
								NullReferenceException ex10 = new NullReferenceException();
								vector2 = (Vector3)list;
								num22 = num26;
							}
							NullReferenceException ex11 = new NullReferenceException();
							ex4 = null;
							obj17 = 0;
							val4 = (Enumerator<, >)(ref val5);
							num23 = 1;
							NullReferenceException ex12 = new NullReferenceException();
							Vector2 vector8 = vector2;
							IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
							NullReferenceException ex14 = new NullReferenceException();
							NullReferenceException ex15 = new NullReferenceException();
							NullReferenceException ex16 = new NullReferenceException();
							NullReferenceException ex17 = new NullReferenceException();
							NullReferenceException ex18 = new NullReferenceException();
							NullReferenceException ex19 = new NullReferenceException();
							IndexOutOfRangeException ex20 = new IndexOutOfRangeException();
							IndexOutOfRangeException ex21 = new IndexOutOfRangeException();
							NullReferenceException ex22 = new NullReferenceException();
							NullReferenceException ex23 = new NullReferenceException();
							NullReferenceException ex24 = new NullReferenceException();
							NullReferenceException ex25 = new NullReferenceException();
							vector2 = vector8;
							vector3 = (Vector3)list24;
							IndexOutOfRangeException ex26 = new IndexOutOfRangeException();
							list15 = list22;
							goto IL_7ff3;
						}
					}
					object obj20 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2587 @ X0_v406+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector9 = _003CCap_003Eg__Last_007C52_6((List<int>)vector4, ref obj9);
					Vector3 vector10 = _003CCap_003Eg__First_007C52_5((List<int>)vector4, ref obj9);
					float x2 = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3483 @ X0_v413 (System.Single)+E4]");
					bool flag13 = (nint)0 == 0;
					object obj22 = !flag13;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num35 = num25 - num25;
					float num36 = (float)ex9 - (float)ex9;
					num8 = num24 - num24;
					float num37 = num35 * num35;
					float num38 = num36 * num36;
					float num39 = num37 + num38;
					float num40 = num8 * num8;
					num11 = num40 + num39;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num41 = num11 + num11;
					bool flag14;
					bool flag15;
					if (num11 < num19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X24_v67 (UnityEngine.Vector3)+18]");
						object obj23 = -3;
						flag14 = (nint)obj23 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X24_v67 (UnityEngine.Vector3)+18]");
						object obj24 = (nint)0 ^ (nint)3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X24_v67 (UnityEngine.Vector3)+18]");
						object obj25 = 0 ^ obj23;
						object obj26 = obj24 & obj25;
						flag15 = (nint)obj26 < 0;
					}
					else
					{
						flag15 = false;
						flag14 = true;
					}
					bool flag16;
					bool flag17;
					bool flag18;
					if (flag14 == flag15)
					{
						float num42 = (float)list15 - num41;
						flag16 = num42 < 0f;
						flag17 = num42 == 0f;
						object obj27 = list15 ^ num41;
						object obj28 = list15 ^ num42;
						object obj29 = obj27 & obj28;
						flag18 = (nint)obj29 < 0;
					}
					else
					{
						flag18 = false;
						flag17 = true;
						flag16 = false;
					}
					bool flag19 = flag16 == flag18;
					object obj30 = !flag17;
					if (((flag19 & obj30) ? 1 : 0) == 0)
					{
						bool flag20 = result == null;
						num17 = (float)ex9;
						ex4 = null;
						obj17 = 0;
						ex = (NullReferenceException)num41;
						val4 = (Enumerator<, >)(ref val5);
						num22 = (int)(&obj9);
						num23 = 1;
						list9 = (List<int>)num24;
						num7 = (float)ex9;
						ex2 = (NullReferenceException)num25;
						num9 = num25;
						list12 = (List<int>)num24;
						if (!flag20)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A50]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							int num43 = (int)((nint)0 + (nint)1);
							val3 = (Enumerator<, >)obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
							bool flag21 = (nint)0 == 0;
							num17 = (float)ex9;
							ex4 = null;
							obj17 = 0;
							ex = (NullReferenceException)num41;
							val4 = (Enumerator<, >)(ref val5);
							num22 = (int)(&obj9);
							num23 = 1;
							list9 = (List<int>)num24;
							num7 = (float)ex9;
							ex2 = (NullReferenceException)num25;
							num9 = num25;
							list12 = (List<int>)num24;
							if (!flag21)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
								num43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2304 @ X8_v384+18]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num44 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2304 @ X8_v384+18]");
								bool flag22 = num44 < 0;
								object obj34 = !flag22;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num45 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj35 = num45 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7173 @ X27_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
									val3 = (Enumerator<, >)((nint)0 + (nint)1);
									object obj36 = obj35 + 32;
									obj36 = vector4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num17 = (float)ex9;
									ex = (NullReferenceException)num41;
									list9 = (List<int>)num24;
									num7 = (float)ex9;
									ex2 = (NullReferenceException)num25;
									num9 = num25;
									list12 = (List<int>)num24;
								}
								else
								{
									System.__Canon _Canon = (System.__Canon)val3._current;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5554 @ X8_v385 (System.__Canon)+A8]");
									object obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2306 @ X8_v386+70]");
									vector2 = (Vector3)0;
									((List<System.__Canon>)(object)result).AddWithResize((System.__Canon)vector4);
									num17 = (float)ex9;
									ex = (NullReferenceException)num41;
									list9 = (List<int>)num24;
									num7 = (float)ex9;
									ex2 = (NullReferenceException)num25;
									num9 = num25;
									list12 = (List<int>)num24;
								}
								continue;
							}
						}
						goto IL_8001;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+D8]");
					List<System.__Canon> list26 = (List<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+D8]");
					bool flag23 = (nint)0 == 0;
					num17 = (float)ex9;
					ex4 = null;
					obj17 = 0;
					ex = (NullReferenceException)num41;
					val4 = (Enumerator<, >)(ref val5);
					num22 = (int)(&obj9);
					num23 = 1;
					list9 = (List<int>)num24;
					num7 = (float)ex9;
					ex2 = (NullReferenceException)num25;
					num9 = num25;
					list12 = (List<int>)num24;
					if (!flag23)
					{
						System.__Canon[] items = list26._items;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A50]");
						object obj38 = 0;
						int num43 = list26._version + 1;
						val3 = (Enumerator<, >)obj38;
						list26._version = num43;
						bool flag24 = list26._items == null;
						num17 = (float)ex9;
						ex4 = null;
						obj17 = 0;
						ex = (NullReferenceException)num41;
						val4 = (Enumerator<, >)(ref val5);
						num22 = (int)(&obj9);
						num23 = 1;
						list9 = (List<int>)num24;
						num7 = (float)ex9;
						ex2 = (NullReferenceException)num25;
						num9 = num25;
						list12 = (List<int>)num24;
						if (!flag24)
						{
							num43 = list26._size;
							object obj33 = items.Length;
							bool flag25 = list26._size < items.Length;
							object obj39 = !flag25;
							if (obj39 == null)
							{
								object obj40 = list26._items + list26._size;
								int num46 = ++list26._size;
								object obj41 = obj40 + 32;
								obj41 = vector4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num17 = (float)ex9;
								val3 = (Enumerator<, >)num46;
								ex = (NullReferenceException)num41;
								list9 = (List<int>)num24;
								num7 = (float)ex9;
								ex2 = (NullReferenceException)num25;
								num9 = num25;
								list12 = (List<int>)num24;
							}
							else
							{
								System.__Canon _Canon2 = (System.__Canon)val3._current;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5557 @ X8_v380 (System.__Canon)+A8]");
								object obj42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2307 @ X8_v381+70]");
								vector2 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X22_v4 (UnityEngine.Vector3)+D8]");
								((List<System.__Canon>)0).AddWithResize((System.__Canon)vector4);
								num17 = (float)ex9;
								ex = (NullReferenceException)num41;
								list9 = (List<int>)num24;
								num7 = (float)ex9;
								ex2 = (NullReferenceException)num25;
								num9 = num25;
								list12 = (List<int>)num24;
							}
							continue;
						}
					}
					goto IL_800f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A28]");
				object obj43 = 0;
				num22 = (int)obj43;
				val5.Dispose();
				list17 = (List<int>)num4;
				ex4 = null;
				obj17 = 0;
				val4 = (Enumerator<, >)(ref val5);
				num13 = (int)vector;
				num23 = 34;
				NullReferenceException ex5 = (NullReferenceException)num7;
				break;
				IL_800f:
				NullReferenceException ex27 = new NullReferenceException();
				list17 = (List<int>)num4;
				num13 = (int)vector;
				ex5 = (NullReferenceException)num7;
				NullReferenceException ex28 = new NullReferenceException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				break;
				IL_7ff3:
				NullReferenceException ex29 = new NullReferenceException();
				goto IL_8001;
				IL_8001:
				NullReferenceException ex30 = new NullReferenceException();
				goto IL_800f;
			}
		}
		OutOfMemoryException ex31 = new OutOfMemoryException();
		string text = (string)num22;
		NullReferenceException ex32 = new NullReferenceException();
		NullReferenceException ex33 = new NullReferenceException();
		NullReferenceException ex34 = new NullReferenceException();
		list11 = (List<int>)num17;
		NullReferenceException ex35 = new NullReferenceException();
		NullReferenceException ex36 = new NullReferenceException();
		NullReferenceException ex37 = new NullReferenceException();
		NullReferenceException ex38 = new NullReferenceException();
		NullReferenceException ex39 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex40 = new OutOfMemoryException();
		num4 = (float)list17;
		vector = (Vector3)num13;
		float num47 = num17;
		num22 = (int)text;
		throw new NullReferenceException();
	}

	private static float Area(Vector2[] poly)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_0132: Expected F4, but got I4
		//IL_0060: Expected Obj, but got I8
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_0080: Expected F4, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		if (poly != null)
		{
			object obj = poly.Length - 1;
			if (poly.Length < 1)
			{
				return 0f;
			}
			object obj2 = poly.Length & 0xFFFFFFFFL;
			object obj3 = poly + 32;
			object obj4 = 0;
			float num = 0f;
			while (true)
			{
				bool flag = (nint)obj < poly.Length;
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				object obj6 = 0 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X11_v3+v35 @ X9_v4*8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X11_v3+v68 @ X12_v4*8]");
				object obj7 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X11_v3+v68 @ X12_v4*8]");
				object obj8 = obj7 - 0;
				num += (float)obj8;
				bool flag2 = obj2 != obj6;
				obj = obj6;
				if (!flag2)
				{
					return num * 0.5f;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		throw new NullReferenceException();
	}

	private static bool Within(Vector2 q, Vector2[] poly)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_0304: Expected I4, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected I4, but got Unknown
		//IL_0072: Expected Obj, but got I8
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		object obj2;
		if (q != (Vector2)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [q @ X0 (UnityEngine.Vector2)+18]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [q @ X0 (UnityEngine.Vector2)+18]");
			if ((nint)0 < (nint)1)
			{
				obj2 = 0;
				goto IL_0348;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [q @ X0 (UnityEngine.Vector2)+18]");
			object obj3 = 0 & 0xFFFFFFFFL;
			object obj4 = q + 32;
			object obj5 = q + 36;
			obj2 = 0;
			object obj10 = default;
			object obj33 = default;
			while (true)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [q @ X0 (UnityEngine.Vector2)+18]");
				bool flag = (nint)obj6 < 0;
				object obj7 = !flag;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = obj4 + obj;
				object obj9 = obj5 - obj10;
				bool flag2 = (nint)obj9 < 0;
				bool flag3 = obj9 == null;
				object obj11 = obj5 ^ obj10;
				object obj12 = obj5 ^ obj9;
				object obj13 = obj11 & obj12;
				bool flag4 = (nint)obj13 < 0;
				bool flag5 = flag2 == flag4;
				object obj14 = !flag3;
				object obj15 = flag5 & obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X15_v4+4]");
				object obj16 = 0 - obj10;
				bool flag6 = (nint)obj16 < 0;
				bool flag7 = obj16 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X15_v4+4]");
				object obj17 = 0 ^ obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X15_v4+4]");
				object obj18 = 0 ^ obj16;
				object obj19 = obj17 & obj18;
				bool flag8 = (nint)obj19 < 0;
				bool flag9 = flag6 == flag8;
				object obj20 = !flag9;
				object obj21 = obj20 | flag7;
				object obj22 = obj15 ^ obj21;
				object obj23 = obj22 & 1;
				bool flag10 = obj23 == null;
				object obj24 = !flag10;
				if (obj24 == null)
				{
					object obj25 = obj10 - obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X15_v4+4]");
					object obj26 = 0 - obj5;
					object obj27 = obj << 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
					object obj28 = obj26 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X12_v3+v230 @ X14_v8]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X13_v4-4]");
					object obj29 = num - 0;
					object obj30 = obj25 * obj29;
					object obj31 = obj30 / obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X13_v4-4]");
					object obj32 = 0 + obj31;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32))
					{
						obj2 ^= 1;
					}
				}
				object obj34 = 0 + 1;
				obj5 += 8;
				bool flag11 = obj3 != obj34;
				obj = obj34;
				if (flag11)
				{
					continue;
				}
				goto IL_0348;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0348:
		return (byte)(obj2 & 1) != 0;
	}

	private static List<int> EarClip(Vector2[] poly)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_1402: Invalid comparison between F4 and I4
		//IL_1411: Invalid comparison between F4 and I4
		//IL_1424: Expected Obj, but got F4
		//IL_142c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1431: Expected Obj, but got Unknown
		//IL_1450: Expected Obj, but got I
		//IL_1466: Expected Obj, but got I
		//IL_147f: Expected Obj, but got I4
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Expected Obj, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Expected Obj, but got Unknown
		//IL_1330: Expected I4, but got Obj
		//IL_138a: Expected Obj, but got I
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_1397: Expected I4, but got Unknown
		//IL_0ca4: Expected Obj, but got I
		//IL_0cbb: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_123c: Expected Obj, but got I4
		//IL_1256: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_0d93: Expected Obj, but got I
		//IL_0daa: Expected Obj, but got I
		//IL_0d39: Expected Obj, but got I
		//IL_0d4f: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I4
		//IL_0fd9: Expected Obj, but got I
		//IL_0ff0: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0dfd: Expected Obj, but got I4
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_1043: Expected Obj, but got I4
		//IL_0e90: Expected Obj, but got I
		//IL_0ea7: Expected Obj, but got I
		//IL_0e28: Expected Obj, but got I
		//IL_0e3e: Expected Obj, but got I
		//IL_10c9: Expected Obj, but got I
		//IL_10e0: Expected Obj, but got I
		//IL_106e: Expected Obj, but got I
		//IL_1084: Expected Obj, but got I
		//IL_0efa: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I
		//IL_1133: Expected Obj, but got I4
		//IL_0933: Expected Obj, but got I
		//IL_094a: Expected Obj, but got I
		//IL_12bd: Expected Obj, but got I4
		//IL_12d7: Expected Obj, but got I4
		//IL_0f6c: Expected Obj, but got I4
		//IL_0f25: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I
		//IL_115e: Expected Obj, but got I
		//IL_1174: Expected Obj, but got I
		//IL_099e: Expected Obj, but got I4
		//IL_126f: Expected Obj, but got I4
		//IL_05d8: Expected Obj, but got I4
		//IL_0a21: Expected Obj, but got I
		//IL_0a38: Expected Obj, but got I
		//IL_09c2: Expected Obj, but got I
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected Obj, but got Unknown
		//IL_09f7: Expected Obj, but got I
		//IL_1291: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got I4
		//IL_0a8c: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I4
		//IL_0b0e: Expected Obj, but got I
		//IL_0b25: Expected Obj, but got I
		//IL_0ab0: Expected Obj, but got I
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected Obj, but got Unknown
		//IL_0ae5: Expected Obj, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06de: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_0710: Expected Obj, but got I4
		//IL_0718: Expected VT, but got I4
		//IL_0b78: Expected Obj, but got I4
		//IL_074a: Expected VT, but got Obj
		//IL_074a: Expected VT, but got I4
		//IL_075e: Expected Obj, but got I
		//IL_083f: Expected Obj, but got I
		//IL_084f: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I
		//IL_086f: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I
		//IL_089f: Expected Obj, but got I
		//IL_08af: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got I
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got Unknown
		//IL_0bb1: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list = default;
		list._002Ector();
		object obj4;
		List<int> list2 = default;
		object obj13 = default;
		if (poly != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6810]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			list2._002Ector(poly.Length);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = Area(poly);
			int num2 = poly.Length - 1;
			if (poly.Length >= 1)
			{
				if (list2 != null)
				{
					int num3 = 0;
					while (true)
					{
						bool flag2 = num < 0f;
						bool flag3 = num == 0f;
						object obj7 = num ^ num;
						object obj8 = num & obj7;
						bool flag4 = (nint)obj8 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj10 = (nint)0 + (nint)1;
						bool flag5 = flag2 == flag4;
						object obj11 = !flag3;
						object obj12 = flag5 & obj11;
						obj13 = ~obj12;
						int item = ((obj13 != null) ? num2 : num3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v51+18]");
						bool flag6 = num4 < 0;
						object obj14 = !flag6;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj15 = num5 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj16 = (nint)0 + (nint)1;
						}
						else
						{
							list2.AddWithResize(item);
						}
						num2--;
						num3++;
						object obj17 = num2 + 1;
						bool flag7 = obj17 == null;
						object obj18 = !flag7;
						if (obj18 != null)
						{
							continue;
						}
						goto IL_01de;
					}
				}
			}
			else if (list2 != null)
			{
				goto IL_01de;
			}
		}
		goto IL_11aa;
		IL_1197:
		return list;
		IL_01de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
		if ((nint)0 < (nint)4)
		{
			goto IL_0216;
		}
		object obj20 = poly.Length * poly.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
		object obj21 = 0;
		object obj22 = ~obj20;
		object obj23 = obj20 & obj22;
		object obj24 = 0;
		object obj51 = default;
		object obj53 = default;
		object obj55 = default;
		object obj57 = default;
		object obj59 = default;
		object obj61 = default;
		int num17 = default;
		Vector2 c = default;
		while (obj24 != obj23)
		{
			object obj25 = obj24 + 1;
			int num6 = 0;
			int num7;
			int num8;
			int num11;
			object obj50;
			object obj52;
			object obj54;
			object obj56;
			object obj58;
			object obj60;
			object obj62;
			int num16;
			while (true)
			{
				object obj26 = num6 + obj19;
				object obj27 = obj26 - 1;
				object obj28 = obj27 / obj19;
				object obj29 = obj28 * obj19;
				int index = obj27 - obj29;
				num7 = list2.get_Item(index);
				num8 = list2.get_Item(num6);
				int num9 = num6 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
				int num10 = (int)((nint)num9 / (nint)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj30 = (nint)num10 * (nint)0;
				int index2 = num9 - obj30;
				num11 = list2.get_Item(index2);
				bool flag8 = num7 < poly.Length;
				object obj31 = !flag8;
				if (obj31 != null)
				{
					break;
				}
				bool flag9 = num8 < poly.Length;
				object obj32 = !flag9;
				if (obj32 != null)
				{
					break;
				}
				bool flag10 = num11 < poly.Length;
				object obj33 = !flag10;
				if (obj33 != null)
				{
					break;
				}
				object obj34 = poly + num7;
				object obj35 = poly + num8;
				object obj36 = poly + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+20]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+20]");
				object obj37 = num12 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+24]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+24]");
				object obj38 = num13 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+24]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+24]");
				object obj39 = num14 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+20]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+20]");
				object obj40 = num15 - 0;
				object obj41 = obj37 * obj39;
				object obj42 = obj38 * obj40;
				object obj43 = obj41 - obj42;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
				bool flag11 = (nint)obj44 < 0;
				object obj45 = !flag11;
				object obj46 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
				object obj47 = obj46 - 0;
				bool flag12 = obj47 == null;
				object obj48 = ~obj45;
				object obj49 = obj48 | flag12;
				if (obj49 != null)
				{
					goto IL_08dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag13 = (nint)0 < (nint)1;
				obj50 = obj51;
				obj52 = obj53;
				obj54 = obj55;
				obj56 = obj57;
				obj58 = obj59;
				obj60 = obj61;
				obj62 = obj13;
				num16 = num17;
				bool flag19;
				if (!flag13)
				{
					num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
					object obj63 = 0;
					while (true)
					{
						int num18 = list2.get_Item(num16);
						object obj64 = num18 - num11;
						bool flag14 = obj64 == null;
						object obj65 = !flag14;
						object obj66 = ~obj65;
						bool flag15;
						if (obj66 == null)
						{
							object obj67 = num18 - num7;
							flag15 = obj67 == null;
						}
						else
						{
							flag15 = true;
						}
						object obj68 = !flag15;
						obj62 = ~obj68;
						bool flag16;
						if (obj62 == null)
						{
							object obj69 = num18 - num8;
							flag16 = obj69 == null;
						}
						else
						{
							flag16 = true;
						}
						object obj70 = !flag16;
						if (obj70 == null)
						{
							num16++;
							int num19 = num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
							if ((nint)num19 >= (nint)0)
							{
								break;
							}
							continue;
						}
						bool flag17 = num18 < poly.Length;
						object obj71 = !flag17;
						if (obj71 != null)
						{
							goto end_IL_12ee;
						}
						object obj72 = poly + num18;
						object obj73 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X9_v40+20]");
						obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X9_v40+24]");
						obj59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v53+E4]");
						bool flag18 = (nint)0 == 0;
						object obj74 = !flag18;
						Vector2 q = (Vector2)num18;
						if (obj74 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag19 = InTriangle(q, (Vector2)num16, (Vector2)obj21, c);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
						obj19 = 0;
						num16++;
						int num20 = num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
						if ((nint)num20 < (nint)0)
						{
							bool flag20 = !flag19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+24]");
							obj51 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+20]");
							obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+24]");
							obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+20]");
							obj57 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+24]");
							obj40 = 0;
							obj63 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v31+20]");
							obj38 = 0;
							obj43 = obj61;
							if (flag20)
							{
								continue;
							}
						}
						goto IL_0820;
					}
					obj50 = obj51;
					obj52 = obj53;
					obj54 = obj55;
					obj56 = obj57;
					obj58 = obj59;
					obj60 = obj61;
				}
				goto IL_0906;
				IL_08dd:
				bool flag21 = num9 < (nint)obj19;
				num6 = num9;
				if (flag21)
				{
					continue;
				}
				goto IL_0216;
				IL_0820:
				bool flag22 = !flag19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+24]");
				obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+20]");
				obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+24]");
				obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+20]");
				obj57 = 0;
				obj13 = obj62;
				num17 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+24]");
				obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X10_v21+20]");
				obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+24]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X9_v27+20]");
				obj56 = 0;
				obj58 = obj59;
				obj60 = obj61;
				if (!flag22)
				{
					goto IL_08dd;
				}
				goto IL_0906;
				continue;
				end_IL_12ee:
				break;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			goto IL_11aa;
			IL_0906:
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj76 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v37+18]");
					bool flag23 = num21 < 0;
					object obj77 = !flag23;
					if (obj77 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj78 = (nint)0 + (nint)1;
						object obj79 = obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj80 = obj79 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj81 = (nint)0 + (nint)1;
					}
					else
					{
						list.AddWithResize(num7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj82 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_11aa;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v37+18]");
					bool flag24 = num22 < 0;
					object obj83 = !flag24;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj84 = (nint)0 + (nint)1;
						object obj85 = obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj86 = obj85 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj87 = (nint)0 + (nint)1;
					}
					else
					{
						list.AddWithResize(num8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj88 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 == 0)
						{
							goto IL_11aa;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ X8_v37+18]");
					bool flag25 = num23 < 0;
					object obj89 = !flag25;
					if (obj89 == null)
					{
						object obj90 = obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj91 = obj90 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj92 = (nint)0 + (nint)1;
					}
					else
					{
						list.AddWithResize(num11);
					}
					list2.RemoveAt(num6);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag26 = (nint)0 >= (nint)4;
					obj51 = obj50;
					obj53 = obj52;
					obj55 = obj54;
					obj57 = obj56;
					obj59 = obj58;
					obj61 = obj60;
					obj13 = obj62;
					num17 = num16;
					obj24 = obj25;
					if (flag26)
					{
						continue;
					}
					goto IL_0216;
				}
			}
			goto IL_11aa;
		}
		goto IL_0c85;
		IL_0216:
		if ((nint)obj19 == 3)
		{
			int item2 = list2.get_Item(0);
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj94 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v57+18]");
					bool flag27 = num24 < 0;
					object obj95 = !flag27;
					if (obj95 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj96 = num25 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj97 = (nint)0 + (nint)1;
					}
					else
					{
						list.AddWithResize(item2);
					}
					int item3 = list2.get_Item(1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					object obj98 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj99 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v59+18]");
						bool flag28 = num26 < 0;
						object obj100 = !flag28;
						if (obj100 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj101 = num27 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj102 = (nint)0 + (nint)1;
						}
						else
						{
							list.AddWithResize(item3);
						}
						int item4 = list2.get_Item(2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj103 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj104 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v61+18]");
							bool flag29 = num28 < 0;
							object obj105 = !flag29;
							if (obj105 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
								nint num29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj106 = num29 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj107 = (nint)0 + (nint)1;
							}
							else
							{
								list.AddWithResize(item4);
							}
							goto IL_1197;
						}
					}
				}
			}
			goto IL_11aa;
		}
		if ((nint)obj19 >= 4)
		{
			goto IL_0c85;
		}
		goto IL_1197;
		IL_0c85:
		int num30 = 1;
		while (true)
		{
			int item5 = list2.get_Item(0);
			if (list == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj109 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v10+18]");
			bool flag30 = num31 < 0;
			object obj110 = !flag30;
			if (obj110 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj111 = num32 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj112 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(item5);
			}
			int item6 = list2.get_Item(num30);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj113 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj114 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v12+18]");
			bool flag31 = num33 < 0;
			object obj115 = !flag31;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj116 = num34 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj117 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(item6);
			}
			int index3 = num30 + 1;
			int item7 = list2.get_Item(index3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj118 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj119 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v14+18]");
			bool flag32 = num35 < 0;
			object obj120 = !flag32;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj121 = num36 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj122 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(item7);
			}
			object obj123 = num30 + 2;
			num30++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)obj123 < 0)
			{
				continue;
			}
			goto IL_1197;
		}
		goto IL_11aa;
		IL_11aa:
		return (List<int>)(object)new NullReferenceException();
	}

	private static bool InTriangle(Vector2 q, Vector2 a, Vector2 b, Vector2 c)
	{
		//IL_00e3: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected I4, but got Unknown
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj4 = obj5 - obj3;
		object obj7 = default;
		object obj8 = default;
		object obj6 = obj7 - obj8;
		object obj10 = default;
		object obj9 = obj10 - obj8;
		object obj11 = obj * obj6;
		object obj12 = obj9 * obj4;
		object obj13 = obj11 - obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		bool flag = (nint)obj12 < 0;
		bool flag2 = obj12 == null;
		object obj14 = obj12 ^ obj12;
		object obj15 = obj12 & obj14;
		bool flag3 = (nint)obj15 < 0;
		bool flag4 = flag == flag3;
		object obj16 = !flag4;
		bool result = (byte)((obj16 | flag2) ? 1 : 0) != 0;
		if ((nint)obj13 < 0)
		{
			return result;
		}
		return true;
	}

	private unsafe static GameObject Build(GillaPieceId was, PieceKey key, Transform root, List<(Source, Side)> parts, List<int> capTris, List<Vector3> capAt, List<float> capLip, Vector3 faces, Vector3 nL, GillaGoreAssets gore, TornPiece source, GillaCorpse body, float mass, Vector3 going, Vector3 spin)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_4067: Expected Obj, but got I4
		//IL_40a5: Expected F4, but got I4
		//IL_40ad: Expected VT, but got Obj
		//IL_40b5: Expected Obj, but got VT
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_00c9: Expected F4, but got I4
		//IL_00d2: Expected VT, but got I4
		//IL_0140: Expected F4, but got I4
		//IL_0149: Expected VT, but got I4
		//IL_01b3: Expected F4, but got I4
		//IL_01bc: Expected VT, but got I4
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0223: Expected VT, but got I4
		//IL_0223: Expected VT, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0276: Expected F4, but got I4
		//IL_027f: Expected F8, but got I4
		//IL_0288: Expected F8, but got I4
		//IL_0291: Expected F8, but got I4
		//IL_029a: Expected F4, but got I4
		//IL_02cb: Expected F4, but got I4
		//IL_02dc: Expected VT, but got I4
		//IL_40cb: Expected I4, but got Obj
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Expected F4, but got I4
		//IL_1402: Expected Obj, but got I4
		//IL_1406: Unknown result type (might be due to invalid IL or missing references)
		//IL_1412: Expected VT, but got F4
		//IL_1438: Expected Obj, but got I4
		//IL_1442: Expected Obj, but got I4
		//IL_4d13: Expected Obj, but got I
		//IL_4d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d24: Expected Ref, but got Unknown
		//IL_4d3e: Expected Obj, but got I4
		//IL_4d4e: Expected F4, but got VT
		//IL_1450: Invalid comparison between F4 and I4
		//IL_1461: Expected Obj, but got I4
		//IL_1469: Expected F4, but got VT
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected Obj, but got Unknown
		//IL_033d: Expected Obj, but got I
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected F4, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_19db: Expected Obj, but got I
		//IL_1a05: Expected Obj, but got I4
		//IL_14be: Expected Obj, but got I4
		//IL_1cfd: Expected Obj, but got I4
		//IL_1d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d15: Expected F4, but got I4
		//IL_1d1e: Expected Obj, but got I4
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected F4, but got I4
		//IL_03f3: Expected Obj, but got I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected VT, but got I4
		//IL_1534: Expected Obj, but got I
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected F4, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected VT, but got I4
		//IL_363c: Expected Obj, but got I
		//IL_1e6d: Expected VT, but got F4
		//IL_15a1: Expected Obj, but got I
		//IL_15cb: Expected Obj, but got I4
		//IL_3681: Expected VT, but got I4
		//IL_15f2: Expected Obj, but got VT
		//IL_1616: Expected VT, but got I4
		//IL_4129: Unknown result type (might be due to invalid IL or missing references)
		//IL_4136: Expected F4, but got I4
		//IL_413f: Expected Obj, but got I4
		//IL_4143: Unknown result type (might be due to invalid IL or missing references)
		//IL_415d: Expected VT, but got I4
		//IL_48e4: Expected Obj, but got I
		//IL_4946: Invalid comparison between F8 and I4
		//IL_4955: Invalid comparison between F8 and I4
		//IL_4968: Expected Obj, but got F8
		//IL_4975: Expected Obj, but got F8
		//IL_49b4: Expected Obj, but got I4
		//IL_49bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c1: Expected Obj, but got Unknown
		//IL_165d: Invalid comparison between VT and I4
		//IL_1674: Expected VT, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected F4, but got I4
		//IL_052e: Expected Obj, but got I4
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected VT, but got I4
		//IL_49e6: Expected VT, but got I4
		//IL_49f6: Expected Obj, but got I
		//IL_4a20: Expected Obj, but got I4
		//IL_3fd4: Expected F4, but got I4
		//IL_36f6: Expected Obj, but got Ref
		//IL_3708: Expected VT, but got Ref
		//IL_372b: Invalid comparison between F4 and I
		//IL_16b1: Expected Obj, but got I4
		//IL_403b: Expected Obj, but got I4
		//IL_0595: Expected VT, but got I4
		//IL_4a55: Invalid comparison between F4 and I4
		//IL_4a64: Expected F8, but got I4
		//IL_16e0: Expected Obj, but got I
		//IL_1704: Expected VT, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected F4, but got I4
		//IL_0600: Expected Obj, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a7b: Invalid comparison between F8 and I4
		//IL_4a8a: Invalid comparison between F8 and I4
		//IL_4a9d: Expected Obj, but got F8
		//IL_4aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aaa: Expected Obj, but got Unknown
		//IL_4adc: Expected Obj, but got I4
		//IL_4ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ae9: Expected Obj, but got Unknown
		//IL_3752: Expected F4, but got I
		//IL_05be: Expected VT, but got I4
		//IL_1752: Expected Obj, but got I
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected F4, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b1f: Expected F4, but got I
		//IL_4b2f: Invalid comparison between F8 and I
		//IL_178a: Expected VT, but got I4
		//IL_4b62: Expected Obj, but got Ref
		//IL_17ad: Expected Obj, but got I
		//IL_17e2: Expected VT, but got I4
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected F4, but got I4
		//IL_073b: Expected Obj, but got I4
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected VT, but got I4
		//IL_1810: Expected VT, but got I4
		//IL_1818: Expected I4, but got Obj
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected F4, but got I4
		//IL_079c: Expected Obj, but got I4
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_386e: Expected VT, but got I4
		//IL_386e: Expected VT, but got I4
		//IL_185b: Expected Obj, but got I
		//IL_1875: Expected Obj, but got I
		//IL_3907: Unknown result type (might be due to invalid IL or missing references)
		//IL_390c: Expected Obj, but got Unknown
		//IL_3975: Expected VT, but got I4
		//IL_18a1: Expected Obj, but got I
		//IL_183d: Expected VT, but got I4
		//IL_39fa: Expected VT, but got I4
		//IL_18cb: Expected Obj, but got I
		//IL_18e5: Expected Obj, but got I
		//IL_0834: Expected I4, but got Obj
		//IL_3a0f: Expected Obj, but got I
		//IL_3a39: Expected Obj, but got I4
		//IL_190f: Expected Obj, but got I
		//IL_1929: Expected Obj, but got I
		//IL_0827: Expected VT, but got I4
		//IL_4b9a: Expected Obj, but got I4
		//IL_1979: Expected VT, but got Obj
		//IL_0867: Expected Obj, but got I4
		//IL_4de9: Expected Obj, but got I
		//IL_4df9: Expected Obj, but got I
		//IL_4e23: Expected Obj, but got I4
		//IL_3aa7: Expected VT, but got I4
		//IL_4529: Expected Obj, but got I
		//IL_4532: Expected F8, but got Obj
		//IL_4542: Expected F8, but got I
		//IL_4546: Unknown result type (might be due to invalid IL or missing references)
		//IL_454b: Unknown result type (might be due to invalid IL or missing references)
		//IL_455f: Expected Obj, but got I
		//IL_4567: Unknown result type (might be due to invalid IL or missing references)
		//IL_456f: Expected F4, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0897: Expected Obj, but got I
		//IL_08b6: Expected Obj, but got I4
		//IL_3cdc: Expected Obj, but got I4
		//IL_09a5: Expected VT, but got I
		//IL_09ad: Expected I4, but got Obj
		//IL_3ad1: Expected F4, but got I
		//IL_3aea: Expected VT, but got I4
		//IL_4c82: Expected Obj, but got I
		//IL_4c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cad: Expected F4, but got I4
		//IL_4cb6: Expected Obj, but got I4
		//IL_4cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cc6: Expected F4, but got VT
		//IL_4cd7: Expected Obj, but got I4
		//IL_08f5: Expected VT, but got I
		//IL_4c06: Expected F4, but got I
		//IL_4c1f: Expected VT, but got I4
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected F4, but got I4
		//IL_09f8: Expected Obj, but got I4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected VT, but got I
		//IL_3d40: Expected F4, but got I
		//IL_3d59: Expected VT, but got I4
		//IL_3b0d: Expected Obj, but got I
		//IL_3b15: Expected VT, but got Obj
		//IL_3b36: Expected F4, but got I
		//IL_3b4f: Expected Obj, but got I4
		//IL_093c: Expected Obj, but got I4
		//IL_3d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d8c: Expected Obj, but got Unknown
		//IL_3dc8: Expected Obj, but got I4
		//IL_0a6f: Expected VT, but got I4
		//IL_3b7d: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		//IL_0970: Expected Obj, but got I4
		//IL_3e6e: Expected F4, but got I4
		//IL_0a86: Expected VT, but got I4
		//IL_0a90: Expected Obj, but got I4
		//IL_4c64: Expected Obj, but got I4
		//IL_3e27: Expected F4, but got I
		//IL_3e40: Expected VT, but got I4
		//IL_3ba5: Expected Obj, but got I8
		//IL_3bb5: Expected Obj, but got I
		//IL_3bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bc3: Expected Obj, but got Unknown
		//IL_3bcb: Expected VT, but got Obj
		//IL_3bd4: Expected Obj, but got I4
		//IL_3bdd: Expected Obj, but got I4
		//IL_3e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e94: Expected Obj, but got Unknown
		//IL_4bc1: Expected Obj, but got I4
		//IL_4bc9: Expected F4, but got I
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected F4, but got I4
		//IL_0bbf: Expected Obj, but got I4
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee3: Expected F4, but got I
		//IL_3efb: Expected VT, but got Obj
		//IL_3e60: Expected F4, but got Obj
		//IL_0ab7: Expected Obj, but got I4
		//IL_0abf: Expected I4, but got Obj
		//IL_3c0c: Expected Obj, but got I4
		//IL_0bf0: Expected I4, but got Obj
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected F4, but got I4
		//IL_0c20: Expected Obj, but got I4
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f1c: Expected VT, but got I4
		//IL_3f30: Expected Obj, but got I
		//IL_3f5a: Expected Obj, but got I4
		//IL_3c3e: Expected Obj, but got I
		//IL_3c4e: Expected Obj, but got I
		//IL_3c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5c: Expected Obj, but got Unknown
		//IL_3c7b: Expected VT, but got I4
		//IL_3c8b: Expected Obj, but got I
		//IL_3c94: Expected VT, but got I4
		//IL_3ca4: Expected Obj, but got I
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected Obj, but got Unknown
		//IL_0af3: Expected Obj, but got I
		//IL_0b2d: Expected Obj, but got I4
		//IL_0b3a: Expected VT, but got I4
		//IL_0b4a: Expected Obj, but got I
		//IL_3f88: Expected VT, but got Ref
		//IL_0ca7: Expected Obj, but got I
		//IL_0cd1: Expected Obj, but got I4
		//IL_0b6d: Expected VT, but got I4
		//IL_0cff: Expected Obj, but got I
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Expected F4, but got I4
		//IL_0dba: Expected Obj, but got I4
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Expected Obj, but got I
		//IL_0d5f: Expected Obj, but got I4
		//IL_0dee: Expected Obj, but got I
		//IL_0e30: Expected Obj, but got I
		//IL_0e4b: Expected I4, but got Obj
		//IL_0ea8: Expected Obj, but got I4
		//IL_0f29: Expected Obj, but got I
		//IL_0f3e: Expected Obj, but got I
		//IL_0f69: Expected Obj, but got I4
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Expected Obj, but got Unknown
		//IL_0ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Expected Obj, but got Unknown
		//IL_41d6: Expected Obj, but got I
		//IL_4202: Unknown result type (might be due to invalid IL or missing references)
		//IL_420f: Expected F4, but got I4
		//IL_4218: Expected Obj, but got I4
		//IL_421c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4236: Expected VT, but got I4
		//IL_0f90: Expected Obj, but got I
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected F4, but got I4
		//IL_0ffa: Expected Obj, but got I4
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Expected VT, but got I4
		//IL_1059: Expected Obj, but got I
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected F4, but got I4
		//IL_10a0: Expected Obj, but got I4
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected VT, but got F4
		//IL_10ce: Expected VT, but got I4
		//IL_1102: Expected Obj, but got I
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected F4, but got I4
		//IL_1149: Expected Obj, but got I4
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Expected VT, but got I4
		//IL_1193: Expected Obj, but got I
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected F4, but got I4
		//IL_11c7: Expected Obj, but got I4
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5: Expected VT, but got I4
		//IL_1233: Expected Obj, but got I4
		//IL_123c: Expected VT, but got I4
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected Obj, but got Unknown
		//IL_1390: Expected Obj, but got Ref
		//IL_13a0: Expected F4, but got I
		//IL_13b0: Expected F4, but got I
		//IL_1261: Expected VT, but got I4
		//IL_4d83: Expected Obj, but got I4
		//IL_4d99: Expected Obj, but got I4
		//IL_12a6: Expected Obj, but got Ref
		//IL_13db: Expected Obj, but got I4
		//IL_426d: Invalid comparison between F8 and I4
		//IL_427c: Invalid comparison between F8 and I4
		//IL_428f: Expected Obj, but got F8
		//IL_429c: Expected Obj, but got F8
		//IL_42d1: Expected Obj, but got I4
		//IL_42d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42de: Expected Obj, but got Unknown
		//IL_43f0: Invalid comparison between F8 and I4
		//IL_43ff: Invalid comparison between F8 and I4
		//IL_4412: Expected Obj, but got F8
		//IL_441f: Expected Obj, but got F8
		//IL_4454: Expected Obj, but got I4
		//IL_445c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4461: Expected Obj, but got Unknown
		Enumerator<, > val = default;
		object obj = (object)(&val);
		obj = 0;
		_ = 0;
		bool flag = capTris == null;
		List<(Source, Side)> list = parts;
		float num2 = default;
		float num = num2;
		double num4 = default;
		double num3 = num4;
		float num6 = default;
		float num5 = num6;
		float num7 = 0f;
		Quaternion quaternion = (Quaternion)root;
		string text = (string)key;
		GameObject gameObject = default;
		float num8;
		double num11;
		float num12;
		NullReferenceException ex6;
		GameObject gameObject2;
		object obj5;
		float num30;
		List<(Source, Side)> list8;
		List<int> parts2;
		float num31;
		float num32;
		double num33;
		TornPiece tornPiece = default;
		Vector3 vector;
		float num15 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capTris @ X4 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 == 0)
			{
				goto IL_1a30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj3 = 0;
			PieceKey pieceKey = default;
			string text2 = pieceKey.ToString();
			string text3 = (string)obj2 + text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			gameObject._002Ector(text3);
			bool flag2 = (object)gameObject == null;
			list = parts;
			num = num2;
			num3 = num4;
			num5 = num6;
			num7 = 0f;
			quaternion = (Quaternion)0;
			text = text3;
			if (!flag2)
			{
				gameObject.layer = 2;
				Transform transform = gameObject.transform;
				bool flag3 = parts == null;
				list = parts;
				num = num2;
				num3 = num4;
				num5 = num6;
				num7 = 0f;
				quaternion = (Quaternion)0;
				text = null;
				if (!flag3)
				{
					Vector3 position = ((Transform)(object)parts).position;
					Quaternion rotation = ((Transform)(object)parts).rotation;
					bool flag4 = (object)transform == null;
					list = parts;
					num = num2;
					num3 = num4;
					num5 = num6;
					num7 = 0f;
					quaternion = (Quaternion)0;
					text = null;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
						Transform transform2 = (Transform)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E08]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7688]");
						List<Vector2> list2 = (List<Vector2>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7540]");
						obj5 = 0;
						transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon)>)(object)capTris).GetEnumerator();
						Enumerator<, > val2 = default;
						obj = val2;
						list = parts;
						num8 = 0f;
						double num9 = 0.0;
						double num10 = 0.0;
						num11 = 0.0;
						num12 = 0f;
						num = num2;
						double num13 = default;
						num3 = num13;
						float num14 = num15;
						num5 = num15;
						float num16 = num2;
						num7 = 0f;
						double num17 = num4;
						quaternion = (Quaternion)0;
						List<Vector3> list3 = null;
						Side side = default;
						Mesh mesh = default;
						List<Vector2> list4 = default;
						object obj12 = default;
						Mesh mesh2 = default;
						List<Vector3> list9 = default;
						List<Vector3> list10 = default;
						List<Vector2> list11 = default;
						List<Vector4> list12 = default;
						List<Vector2> list13 = default;
						List<Vector3> list14 = default;
						Enumerator<, > val4 = default;
						double num35 = default;
						object obj45 = default;
						GameObject gameObject3 = default;
						MeshFilter meshFilter = default;
						Renderer renderer = default;
						object obj59 = default;
						double num41 = default;
						double num42 = default;
						double num47 = default;
						object obj66 = default;
						double num59 = default;
						while (true)
						{
							int num18 = (int)obj5;
							Enumerator<, > val3;
							float num19;
							List<Color> list5;
							List<Vector3> list6;
							object obj7;
							double num20;
							if (val.MoveNext())
							{
								if (side != null)
								{
									if (side.Count == 0)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
									object obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									mesh._002Ector();
									bool flag5 = (object)list4 == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									list5 = null;
									if (flag5)
									{
										goto IL_1e24;
									}
									transform2 = (Transform)(list4 + 16);
									string text4 = (string)obj2 + (string)(object)transform2;
									bool flag6 = (object)mesh == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									quaternion = (Quaternion)0;
									text = text4;
									if (flag6)
									{
										goto IL_1df2;
									}
									mesh.name = text4;
									text = (string)(object)side.at;
									bool flag7 = side.at == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									quaternion = (Quaternion)0;
									if (flag7)
									{
										goto IL_1de4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4291 @ X1_v121 (System.String)+18]");
									bool flag8 = (nint)0 < (nint)65001;
									List<Vector3> at = side.at;
									if (!flag8)
									{
										mesh.indexFormat = (IndexFormat)1;
										at = side.at;
									}
									mesh.SetVertices(at);
									list6 = side.normals;
									bool flag9 = side.normals == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									quaternion = (Quaternion)0;
									if (flag9)
									{
										goto IL_1db2;
									}
									List<Vector3> at2 = side.at;
									bool flag10 = side.at == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									quaternion = (Quaternion)0;
									if (flag10)
									{
										goto IL_1dc0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3394 @ X1_v140 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									int num21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3394 @ X1_v140 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3407 @ X8_v218 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									bool flag11 = num22 != 0;
									quaternion = (Quaternion)0;
									if (!flag11)
									{
										mesh.SetNormals(side.normals);
										quaternion = (Quaternion)0;
									}
									List<Vector4> tangents = side.tangents;
									bool flag12 = (object)side.tangents == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									text = (string)(object)side.tangents;
									if (flag12)
									{
										goto IL_1dd6;
									}
									List<Vector3> at3 = side.at;
									bool flag13 = side.at == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									list5 = (List<Color>)(object)side.tangents;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2806 @ X1_v162 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
										num21 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2806 @ X1_v162 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
										nint num23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2820 @ X8_v220 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										if (num23 == 0)
										{
											mesh.SetTangents(side.tangents);
											quaternion = (Quaternion)0;
										}
										list5 = side.colors;
										bool flag14 = (object)side.colors == null;
										val3 = (Enumerator<, >)0;
										num19 = 0f;
										obj7 = 0;
										val2 = (Enumerator<, >)(ref val);
										num20 = 0.5;
										if (!flag14)
										{
											List<Vector3> at4 = side.at;
											bool flag15 = side.at == null;
											val3 = (Enumerator<, >)0;
											num19 = 0f;
											obj7 = 0;
											val2 = (Enumerator<, >)(ref val);
											num20 = 0.5;
											text = (string)(object)side.colors;
											if (!flag15)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3224 @ X1_v130 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
												num21 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3224 @ X1_v130 (System.Collections.Generic.List`1<UnityEngine.Color>)+18]");
												nint num24 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3178 @ X8_v222 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
												if (num24 == 0)
												{
													mesh.SetColors(side.colors);
													quaternion = (Quaternion)0;
												}
												num18 = (int)list5;
												int num25 = 0;
												while (true)
												{
													List<Vector4>[] uvs = side.uvs;
													if (side.uvs == null)
													{
														break;
													}
													num21 = uvs.Length;
													bool flag16 = num25 < uvs.Length;
													object obj8 = !flag16;
													if (obj8 == null)
													{
														object obj9 = side.uvs + num25;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
														List<Vector4> list7 = (List<Vector4>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
														bool flag17 = (nint)0 == 0;
														list5 = (List<Color>)num18;
														if (!flag17)
														{
															List<Vector3> at5 = side.at;
															bool flag18 = side.at == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
															quaternion = (Quaternion)0;
															if (flag18)
															{
																goto IL_1cec;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2368 @ X2_v111 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
															num21 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2368 @ X2_v111 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
															nint num26 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2378 @ X8_v267 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
															bool flag19 = num26 != 0;
															list5 = (List<Color>)num18;
															if (!flag19)
															{
																int channel = num25;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
																mesh.SetUVs(channel, (List<Vector4>)0);
																list = null;
																list5 = (List<Color>)num25;
															}
														}
														num25++;
														bool flag20 = num25 != 8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
														quaternion = (Quaternion)0;
														num18 = (int)list5;
														if (flag20)
														{
															continue;
														}
														goto IL_09bb;
													}
													goto IL_1cb4;
												}
												goto IL_1cc2;
											}
											goto IL_1e0e;
										}
										goto IL_1e32;
									}
									goto IL_1e40;
								}
								NullReferenceException ex = new NullReferenceException();
								goto IL_1cb4;
							}
							val3 = (Enumerator<, >)0;
							num19 = 0f;
							obj7 = 0;
							val2 = (Enumerator<, >)(ref val);
							vector = (Vector3)num14;
							float num27 = (float)num17;
							double num28 = num4;
							num20 = 0.5;
							object obj10 = 21;
							object obj11 = 0;
							goto IL_4d03;
							IL_1e32:
							NullReferenceException ex2 = new NullReferenceException();
							goto IL_1e40;
							IL_1e40:
							NullReferenceException ex3 = new NullReferenceException();
							goto IL_1e4e;
							IL_1db2:
							NullReferenceException ex4 = new NullReferenceException();
							goto IL_1dc0;
							IL_1e5c:
							NullReferenceException ex5 = new NullReferenceException();
							vector = (Vector3)num14;
							num27 = (float)num17;
							text = (string)(object)list5;
							goto IL_1e82;
							IL_1e82:
							ex6 = new NullReferenceException();
							if ((nint)text == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								num19 = 1f;
								obj11 = obj7;
							}
							else
							{
								if ((nint)text != 1)
								{
									goto IL_4ce4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj11 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj7 = obj12;
							}
							num28 = num4;
							obj10 = 0;
							goto IL_4d03;
							IL_1de4:
							NullReferenceException ex7 = new NullReferenceException();
							goto IL_1df2;
							IL_1cc2:
							NullReferenceException ex8 = new NullReferenceException();
							goto IL_1cd0;
							IL_1cb4:
							IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
							goto IL_1cc2;
							IL_1cd0:
							NullReferenceException ex10 = new NullReferenceException();
							goto IL_1cde;
							IL_1cec:
							NullReferenceException ex11 = new NullReferenceException();
							text = (string)num18;
							goto IL_1d02;
							IL_1cde:
							IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
							goto IL_1cec;
							IL_1d02:
							val3 = (Enumerator<, >)0;
							float num29 = 0f;
							obj7 = 0;
							val2 = (Enumerator<, >)(ref val);
							num20 = 0.5;
							throw new NullReferenceException();
							IL_4d03:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7530]");
							object obj13 = 0;
							text = (string)obj13;
							((Enumerator<, >*)val2)->Dispose();
							bool flag21 = obj11 == null;
							object obj14 = !flag21;
							num29 = num19;
							num14 = (float)vector;
							num17 = num27;
							if (obj14 != null)
							{
								goto IL_1d3f;
							}
							bool flag22 = num19 == 0f;
							object obj15 = !flag22;
							num14 = (float)vector;
							num17 = num27;
							OutOfMemoryException ex13 = (OutOfMemoryException)val2;
							if (obj15 != null)
							{
								goto IL_1d55;
							}
							if ((nint)obj10 != 21)
							{
								bool flag23 = obj10 == null;
								object obj16 = !flag23;
								gameObject2 = gameObject;
								if (obj16 != null)
								{
									break;
								}
							}
							object obj17 = list3 & 1;
							if (obj17 == null)
							{
								goto IL_19cb;
							}
							bool flag24 = capAt == null;
							num15 = num12;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capAt @ X5 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								bool flag25 = (nint)0 < (nint)3;
								num30 = (float)num28;
								gameObject2 = gameObject;
								list8 = parts;
								parts2 = capTris;
								num31 = mass;
								num32 = num2;
								num33 = num6;
								if (!flag25)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj18 = 0;
									object obj19 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2826 @ X0_v123+E4]");
									bool flag26 = (nint)0 == 0;
									object obj20 = !flag26;
									if (obj20 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag27 = (UnityEngine.Object)nL != null;
									bool flag28 = !flag27;
									num30 = (float)num28;
									quaternion = (Quaternion)0;
									gameObject2 = gameObject;
									list8 = parts;
									parts2 = capTris;
									num31 = mass;
									num32 = num2;
									num33 = num6;
									if (!flag28)
									{
										bool flag29 = nL == (Vector3)(object)0;
										num15 = num12;
										quaternion = (Quaternion)0;
										text = null;
										if (!flag29)
										{
											object obj21 = obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3415 @ X0_v127+E4]");
											bool flag30 = (nint)0 == 0;
											object obj22 = !flag30;
											if (obj22 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nL @ stack_0 (UnityEngine.Vector3)+48]");
											bool flag31 = (UnityEngine.Object)0 != null;
											bool flag32 = !flag31;
											num30 = (float)num28;
											quaternion = (Quaternion)0;
											gameObject2 = gameObject;
											list8 = parts;
											parts2 = capTris;
											num31 = mass;
											num32 = num2;
											num33 = num6;
											if (flag32)
											{
												goto IL_362c;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											mesh2._002Ector();
											bool flag33 = (object)mesh2 == null;
											num15 = num12;
											quaternion = (Quaternion)0;
											text = null;
											if (!flag33)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76D8]");
												object obj24 = 0;
												text = (string)obj24;
												mesh2.name = (string)obj24;
												bool flag34 = capLip == null;
												num15 = num12;
												quaternion = (Quaternion)0;
												if (!flag34)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													bool flag35 = (nint)0 < (nint)65001;
													Quaternion quaternion2 = (Quaternion)0;
													IndexFormat indexFormat = (IndexFormat)obj24;
													if (!flag35)
													{
														mesh2.indexFormat = (IndexFormat)1;
														quaternion2 = (Quaternion)0;
														indexFormat = (IndexFormat)1;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
													object obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6780]");
													object obj26 = 0;
													list9._002Ector((IEnumerable<Vector3>)capLip);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AA0]");
													object obj27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													list10._002Ector(0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
													object obj28 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A80]");
													object obj29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													list11._002Ector(0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
													object obj30 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A98]");
													object obj31 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													list12._002Ector(0);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													list13._002Ector(0);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													quaternion = (Quaternion)obj27;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [capLip @ X6 (System.Collections.Generic.List`1<System.Single>)+18]");
													list14._002Ector(0);
													object obj32 = obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3836 @ X8_v78+A0]");
													object obj33 = 0;
													num20 = (double)obj33;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3839 @ X8_v79+8]");
													double num34 = 0.0;
													Enumerator<, > enumerator2 = ((List<Vector3>)(object)capLip).GetEnumerator();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A38]");
													object obj34 = 0;
													num3 = num19;
													num7 = (float)val4;
													while (val3.MoveNext())
													{
														num20 += (double)num19;
														num34 += num35;
														num3 = num35;
														num7 = num19;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
													object obj35 = 0;
													text = (string)obj35;
													val3.Dispose();
													val3 = val4;
													int num21 = 65001;
													num29 = 0f;
													obj7 = 0;
													val2 = (Enumerator<, >)(ref val3);
													num14 = (float)vector;
													num17 = num27;
													obj2 = 27;
													list3 = list14;
													goto IL_1d3f;
												}
											}
										}
										goto IL_3f96;
									}
								}
								goto IL_362c;
							}
							goto IL_3f96;
							IL_1d3f:
							ex13 = new OutOfMemoryException();
							num19 = num29;
							goto IL_1d55;
							IL_1d55:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							goto IL_1d64;
							IL_1e4e:
							NullReferenceException ex14 = new NullReferenceException();
							goto IL_1e5c;
							IL_1d72:
							NullReferenceException ex15 = new NullReferenceException();
							goto IL_1d80;
							IL_1d64:
							NullReferenceException ex16 = new NullReferenceException();
							goto IL_1d72;
							IL_1d8e:
							NullReferenceException ex17 = new NullReferenceException();
							list6 = (List<Vector3>)(object)text;
							goto IL_1da4;
							IL_1d80:
							NullReferenceException ex18 = new NullReferenceException();
							goto IL_1d8e;
							IL_1dc0:
							NullReferenceException ex19 = new NullReferenceException();
							text = (string)(object)list6;
							goto IL_1dd6;
							IL_09bb:
							List<int>[] tris = side.tris;
							bool flag36 = side.tris == null;
							val3 = (Enumerator<, >)0;
							num19 = 0f;
							obj7 = 0;
							val2 = (Enumerator<, >)(ref val);
							num20 = 0.5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3676 @ X8_v226+20]");
							quaternion = (Quaternion)0;
							int num37;
							if (!flag36)
							{
								num18 = tris.Length;
								mesh.subMeshCount = tris.Length;
								List<int>[] tris2 = side.tris;
								bool flag37 = side.tris == null;
								quaternion = (Quaternion)0;
								if (flag37)
								{
									goto IL_1cd0;
								}
								quaternion = (Quaternion)0;
								text = (string)tris.Length;
								int num36 = 0;
								int num21;
								while (true)
								{
									num21 = tris2.Length;
									if (num36 >= tris2.Length)
									{
										break;
									}
									bool flag38 = num36 < num21;
									object obj36 = !flag38;
									num18 = (int)text;
									if (obj36 == null)
									{
										object obj37 = tris2 + num36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3804 @ X8_v265+20]");
										mesh.SetTriangles((List<int>)0, num36);
										tris2 = side.tris;
										num37 = num36 + 1;
										bool flag39 = side.tris == null;
										object obj38 = !flag39;
										list = null;
										quaternion = (Quaternion)num36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3804 @ X8_v265+20]");
										text = (string)0;
										num36 = num37;
										if (obj38 != null)
										{
											continue;
										}
										goto IL_0b60;
									}
									goto IL_1cde;
								}
								List<Vector3> normals = side.normals;
								bool flag40 = side.normals == null;
								val3 = (Enumerator<, >)0;
								num19 = 0f;
								obj7 = 0;
								val2 = (Enumerator<, >)(ref val);
								num20 = 0.5;
								if (flag40)
								{
									goto IL_1d64;
								}
								num21 = (int)side.at;
								bool flag41 = side.at == null;
								val3 = (Enumerator<, >)0;
								num19 = 0f;
								obj7 = 0;
								val2 = (Enumerator<, >)(ref val);
								num20 = 0.5;
								if (!flag41)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1660 @ X9_v83 (System.Int32)+18]");
									num21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2227 @ X8_v231 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num38 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1660 @ X9_v83 (System.Int32)+18]");
									if (num38 != 0)
									{
										mesh.RecalculateNormals();
									}
									mesh.RecalculateBounds();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
									object obj39 = 0;
									object obj40 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3854 @ X0_v336+E4]");
									bool flag42 = (nint)0 == 0;
									object obj41 = !flag42;
									if (obj41 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ stack_-C0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+48]");
									bool flag43 = GillaRip.DrawsFlesh((Material[])0);
									bool flag44 = !flag43;
									text = null;
									if (!flag44)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
										object obj42 = 0;
										object obj43 = obj42;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3904 @ X0_v370+E4]");
										bool flag45 = (nint)0 == 0;
										object obj44 = !flag45;
										if (obj44 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaRip.FleshChannels(mesh);
										text = null;
									}
									bool flag46 = obj45 == null;
									val3 = (Enumerator<, >)0;
									num19 = 0f;
									obj7 = 0;
									val2 = (Enumerator<, >)(ref val);
									num20 = 0.5;
									if (!flag46)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X0_v34+20]");
										List<System.__Canon> list15 = (List<System.__Canon>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X0_v34+20]");
										if ((nint)0 != 0)
										{
											System.__Canon[] items = list15._items;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
											object obj46 = 0;
											int version = list15._version + 1;
											num21 = (int)obj46;
											list15._version = version;
											if (list15._items != null)
											{
												version = list15._size;
												bool flag47 = list15._size < items.Length;
												object obj47 = !flag47;
												if (obj47 == null)
												{
													object obj48 = list15._items + list15._size;
													num21 = list15._size + 1;
													list15._size = num21;
													object obj49 = obj48 + 32;
													obj49 = mesh;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X0_v34+20]");
													((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)mesh);
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76D8]");
												object obj50 = 0;
												bool flag48 = (string)(object)transform2 == (string)obj50;
												bool flag49 = !flag48;
												object obj51 = !flag49;
												object obj52 = ~obj51;
												Transform transform3;
												if (obj52 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76E8]");
													transform3 = (Transform)0;
												}
												else
												{
													transform3 = transform2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
												object obj53 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												gameObject3._002Ector((string)(object)transform3);
												bool flag50 = (object)gameObject3 == null;
												val3 = (Enumerator<, >)0;
												num19 = 0f;
												obj7 = 0;
												val2 = (Enumerator<, >)(ref val);
												num20 = 0.5;
												quaternion = (Quaternion)0;
												text = (string)(object)transform3;
												transform2 = transform3;
												if (flag50)
												{
													goto IL_1d80;
												}
												gameObject3.layer = 2;
												Transform transform4 = gameObject3.transform;
												Transform transform5 = gameObject.transform;
												bool flag51 = (object)transform4 == null;
												val3 = (Enumerator<, >)0;
												num19 = 0f;
												obj7 = 0;
												val2 = (Enumerator<, >)(ref val);
												num20 = 0.5;
												quaternion = (Quaternion)0;
												text = (string)(object)transform5;
												transform2 = transform4;
												if (flag51)
												{
													goto IL_1d72;
												}
												transform4.SetParent(transform5, worldPositionStays: false);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
												object obj54 = 0;
												text = (string)obj54;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
												bool flag52 = (object)meshFilter == null;
												val3 = (Enumerator<, >)0;
												list = null;
												num19 = 0f;
												obj7 = 0;
												val2 = (Enumerator<, >)(ref val);
												vector = (Vector3)num14;
												num27 = (float)num17;
												num20 = 0.5;
												quaternion = (Quaternion)0;
												transform2 = transform4;
												if (!flag52)
												{
													meshFilter.sharedMesh = mesh;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
													object obj55 = 0;
													list5 = (List<Color>)obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
													bool flag53 = (object)tornPiece == null;
													val3 = (Enumerator<, >)0;
													list = null;
													num19 = 0f;
													obj7 = 0;
													val2 = (Enumerator<, >)(ref val);
													num20 = 0.5;
													quaternion = (Quaternion)0;
													transform2 = transform4;
													if (!flag53)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ stack_-C0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+48]");
														Material[] array = tornPiece.Own((Material[])0);
														bool flag54 = (object)renderer == null;
														val3 = (Enumerator<, >)0;
														list = null;
														num19 = 0f;
														obj7 = 0;
														val2 = (Enumerator<, >)(ref val);
														num20 = 0.5;
														quaternion = (Quaternion)0;
														list6 = (List<Vector3>)(object)array;
														transform2 = transform4;
														if (!flag54)
														{
															renderer.sharedMaterials = array;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1790 @ stack_-C0 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+50]");
															bool flag55 = (nint)0 == 0;
															object obj56 = !flag55;
															quaternion = (Quaternion)0;
															if (obj56 == null)
															{
																renderer.shadowCastingMode = (ShadowCastingMode)0;
																quaternion = (Quaternion)0;
															}
															object obj57 = list3 & 1;
															if (obj57 != null)
															{
																Bounds bounds = mesh.bounds;
																object obj58 = (object)(&obj59);
																double num39 = num10 - num11;
																double num40 = num41 - num42;
																double num43 = num11 + num10;
																double num44 = num41 + num42;
																double num45 = num9 - (double)num8;
																double num46 = num47;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4533 @ X8_v255+FF]");
																num17 = num46 + 0.0;
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
																if (!(num39 < num40))
																{
																	num39 = num40;
																}
																double num48 = num43 - num40;
																bool flag56 = num48 < 0.0;
																bool flag57 = num48 == 0.0;
																object obj60 = num43 ^ num40;
																object obj61 = num43 ^ num48;
																object obj62 = obj60 & obj61;
																bool flag58 = (nint)obj62 < 0;
																bool flag59 = flag56 == flag58;
																object obj63 = !flag57;
																object obj64 = flag59 & obj63;
																object obj65 = ~obj64;
																if (obj65 == null)
																{
																	num40 = num43;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
																double num49 = num40 - num39;
																double num50 = (double)obj66 - num45;
																double num51 = num49 * 0.5;
																num14 = (float)num50 * 63f;
																double num52 = num39 + num51;
																float num53 = (float)num45 + num14;
																num3 = num52 - num51;
																double num54 = num51 + num52;
																num16 = num53 - num14;
																num5 = num14 + num53;
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
																if (!(num3 < num44))
																{
																	num3 = num44;
																}
																double num55 = num54 - num44;
																bool flag60 = num55 < 0.0;
																bool flag61 = num55 == 0.0;
																object obj67 = num54 ^ num44;
																object obj68 = num54 ^ num55;
																object obj69 = obj67 & obj68;
																bool flag62 = (nint)obj69 < 0;
																bool flag63 = flag60 == flag62;
																object obj70 = !flag61;
																object obj71 = flag63 & obj70;
																obj52 = ~obj71;
																if (obj52 == null)
																{
																	num44 = num54;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
																double num56 = num44 - num3;
																double num57 = (double)num14 - num52;
																num11 = num56 * 0.5;
																num12 = (float)num57 * 63f;
																num10 = num3 + num11;
																double num58 = num52 + (double)num12;
																num8 = num12;
																num9 = num58;
																num = (float)num52;
																num7 = (float)num58;
															}
															else
															{
																Bounds bounds2 = mesh.bounds;
																object obj72 = (object)(&obj59);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4558 @ X8_v253+FF]");
																num7 = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4558 @ X8_v253+FF]");
																num8 = 0f;
																num9 = num59;
																num10 = num41;
																num11 = num42;
															}
															bool flag64 = side.at == null;
															object obj73 = !flag64;
															list = null;
															transform2 = transform4;
															list3 = (List<Vector3>)1;
															if (obj73 == null)
															{
																list = null;
																list3 = (List<Vector3>)1;
																throw new NullReferenceException();
															}
															continue;
														}
														goto IL_1da4;
													}
													goto IL_1e5c;
												}
												goto IL_1e82;
											}
										}
										goto IL_1d02;
									}
									goto IL_1d8e;
								}
								goto IL_1e00;
							}
							goto IL_1e4e;
							IL_1da4:
							NullReferenceException ex20 = new NullReferenceException();
							goto IL_1db2;
							IL_1dd6:
							NullReferenceException ex21 = new NullReferenceException();
							goto IL_1de4;
							IL_1df2:
							NullReferenceException ex22 = new NullReferenceException();
							goto IL_1e00;
							IL_0b60:
							list = null;
							quaternion = (Quaternion)num37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3804 @ X8_v265+20]");
							num18 = 0;
							goto IL_1cd0;
							IL_1e00:
							NullReferenceException ex23 = new NullReferenceException();
							goto IL_1e0e;
							IL_1e24:
							NullReferenceException ex24 = new NullReferenceException();
							goto IL_1e32;
							IL_1e0e:
							NullReferenceException ex25 = new NullReferenceException();
							list5 = (List<Color>)(object)text;
							goto IL_1e24;
						}
						goto IL_3f91;
					}
				}
			}
		}
		goto IL_3f96;
		IL_1a30:
		gameObject2 = null;
		goto IL_3f91;
		IL_3f96:
		NullReferenceException ex26 = new NullReferenceException();
		goto IL_3fa4;
		IL_4040:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		GameObject result = default;
		return result;
		IL_3f91:
		return gameObject2;
		IL_3fa4:
		IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DAC4");
		IndexOutOfRangeException ex28 = ex27;
		goto IL_4040;
		IL_362c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
		object obj74 = 0;
		text = (string)obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		BoxCollider boxCollider = default;
		bool flag65 = (object)boxCollider == null;
		num15 = num12;
		object obj83;
		Rigidbody rigidbody = default;
		double num95;
		IntPtr intPtr = default;
		object obj103;
		if (!flag65)
		{
			boxCollider.center = (Vector3)0;
			double num60 = num11 + num11;
			float num61 = num8 + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			double num62 = num60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
			double num63 = num62 * 0.0;
			object obj75 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3424 @ X8_v33+A0]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3429 @ X8_v34+C]");
			float num64 = 0f * num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3429 @ X8_v34+14]");
			double num65 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num66 = num65 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			double num67 = num63 - num66;
			bool flag66 = num67 < 0.0;
			bool flag67 = num67 == 0.0;
			object obj77 = num63 ^ num66;
			object obj78 = num63 ^ num67;
			object obj79 = obj77 & obj78;
			bool flag68 = (nint)obj79 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			bool flag69 = flag66 == flag68;
			object obj80 = !flag67;
			object obj81 = flag69 & obj80;
			object obj82 = ~obj81;
			if (obj82 == null)
			{
				double num68 = num63;
			}
			else
			{
				double num68 = num66;
			}
			boxCollider.size = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
			obj83 = 0;
			object obj84 = obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3485 @ X0_v51+E4]");
			bool flag70 = (nint)0 == 0;
			object obj85 = !flag70;
			if (obj85 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj87 = default;
			object obj86 = (object)(&obj87);
			object obj88 = default;
			float num69 = WholeVolume((List<(Source, Side)>)(object)parts2, (Bounds)(&obj88));
			object obj89 = default;
			num = num61 * (float)obj89;
			float num70 = num69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (num70 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				num69 = 0f;
			}
			float num71 = (float)num60 * num;
			float num72 = num71 / num69;
			bool flag71 = num72 < 0f;
			double num73 = 0.0;
			if (!flag71)
			{
				bool flag72 = !((double)num72 > 1.0);
				num73 = num72;
				if (!flag72)
				{
					num73 = 1.0;
				}
			}
			bool flag73 = num33 < 0.0;
			bool flag74 = num33 == 0.0;
			object obj90 = num33 ^ num33;
			object obj91 = num33 & obj90;
			bool flag75 = (nint)obj91 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			bool flag76 = flag73 == flag75;
			object obj92 = !flag74;
			object obj93 = flag76 & obj92;
			object obj94 = ~obj93;
			double num74 = ((obj94 != null) ? 3.0 : num33);
			num3 = num74 * num73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num7 = 0f;
			double num75 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			if (!(num75 < 0.0))
			{
				bool flag77 = !(num3 > 8.0);
				num7 = (float)num3;
				if (!flag77)
				{
					num7 = 8f;
				}
			}
			bool flag78 = (object)rigidbody == null;
			num15 = num12;
			text = (string)(&obj88);
			if (!flag78)
			{
				rigidbody.mass = num7;
				rigidbody.interpolation = (RigidbodyInterpolation)1;
				rigidbody.collisionDetectionMode = (CollisionDetectionMode)2;
				rigidbody.maxDepenetrationVelocity = 3f;
				Quaternion rotation2 = ((Transform)(object)list8).rotation;
				float num27 = 0f - num31;
				float num16 = 0f - num30;
				num5 = 0f - num32;
				Vector3 vector2 = (Quaternion)0 * (Vector3)0;
				double num76 = 3.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				double num77 = num76 * 0.0;
				double num78 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				double num79 = num78 * 0.0;
				float num80 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				float num81 = num80 * 0f;
				double num82 = (double)body + num77;
				object obj95 = default;
				double num83 = (double)obj95 + num79;
				float num84 = (float)going + num81;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				object obj96 = going * 0;
				double num85 = num79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				double num86 = num85 * 0.0;
				float num87 = num81;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				float num88 = num87 * 0f;
				double num89 = num82 + (double)obj96;
				double num90 = num83 + num86;
				float num91 = num84 + num88;
				rigidbody.linearVelocity = (Vector3)0;
				Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
				double num92 = num90 * 1.5;
				double num93 = num89 * 1.5;
				double num94 = (double)num91 * 1.5;
				object obj97 = default;
				num3 = (double)obj97 + num92;
				num7 = (float)spin + (float)num93;
				num95 = (double)(nint)intPtr + num94;
				rigidbody.angularVelocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
				object obj98 = 0;
				object obj99 = obj98;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3848 @ X0_v68+E4]");
				bool flag79 = (nint)0 == 0;
				object obj100 = !flag79;
				if (obj100 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj101 = obj98;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3897 @ X0_v72+E4]");
				bool flag80 = (nint)0 == 0;
				object obj102 = !flag80;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj101 = obj98;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3897 @ X0_v72+A0]");
				object obj104 = 0;
				object obj105 = obj103;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v43+E4]");
				bool flag81 = (nint)0 == 0;
				object obj106 = !flag81;
				if (obj106 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag82 = (UnityEngine.Object)obj104 != null;
				bool flag83 = !flag82;
				quaternion = (Quaternion)0;
				Collider collider = null;
				if (flag83)
				{
					goto IL_3cb2;
				}
				bool flag84 = obj104 == null;
				num15 = (nint)intPtr;
				num = (float)num95;
				vector = spin;
				quaternion = (Quaternion)0;
				text = null;
				if (!flag84)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
					object obj107 = 0;
					quaternion = (Quaternion)obj107;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
					object obj108 = default;
					bool flag85 = obj108 == null;
					num15 = (nint)intPtr;
					num = (float)num95;
					vector = spin;
					text = (string)1;
					if (!flag85)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v105+18]");
						bool flag86 = (nint)0 < (nint)1;
						collider = (Collider)1;
						if (flag86)
						{
							goto IL_3cb2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v105+18]");
						object obj109 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
						object obj110 = 0;
						object obj111 = obj108 + 32;
						Quaternion quaternion3 = (Quaternion)obj107;
						text = (string)1;
						object obj112 = 0;
						while (true)
						{
							bool flag87 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj112) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj109);
							object obj113 = !flag87;
							num15 = (nint)intPtr;
							num = (float)num95;
							vector = spin;
							quaternion = quaternion3;
							if (obj113 != null)
							{
								break;
							}
							object obj114 = obj110;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4056 @ X0_v107+E4]");
							bool flag88 = (nint)0 == 0;
							object obj115 = !flag88;
							if (obj115 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X27_v13+v1065 @ X25_v16*8]");
							Physics.IgnoreCollision(boxCollider, (Collider)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v105+18]");
							obj109 = 0;
							obj112++;
							object obj116 = obj112;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v105+18]");
							bool flag89 = (nint)obj116 < 0;
							quaternion = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X27_v13+v1065 @ X25_v16*8]");
							collider = (Collider)0;
							quaternion3 = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X27_v13+v1065 @ X25_v16*8]");
							text = (string)0;
							if (flag89)
							{
								continue;
							}
							goto IL_3cb2;
						}
						goto IL_3fa4;
					}
				}
			}
		}
		goto IL_3f96;
		IL_3cb2:
		object obj117 = obj103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3959 @ X0_v77+E4]");
		bool flag90 = (nint)0 == 0;
		object obj118 = !flag90;
		if (obj118 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag91 = gore != null;
		bool flag92 = !flag91;
		text = null;
		if (!flag92)
		{
			bool flag93 = (object)gore == null;
			num15 = (nint)intPtr;
			num = (float)num95;
			vector = spin;
			quaternion = (Quaternion)0;
			text = null;
			if (flag93)
			{
				goto IL_3f96;
			}
			text = (string)(object)gore.bone;
		}
		bool flag94 = (object)tornPiece == null;
		num15 = (nint)intPtr;
		num = (float)num95;
		vector = spin;
		quaternion = (Quaternion)0;
		if (!flag94)
		{
			object obj119 = tornPiece + 32;
			obj119 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj120 = obj103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4045 @ X0_v84+E4]");
			bool flag95 = (nint)0 == 0;
			object obj121 = !flag95;
			if (obj121 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (gore != null)
			{
				bool flag96 = (object)gore == null;
				num15 = (nint)intPtr;
				num = (float)num95;
				vector = spin;
				quaternion = (Quaternion)0;
				text = null;
				if (flag96)
				{
					goto IL_3f96;
				}
				num7 = (float)gore.pieces;
			}
			else
			{
				num7 = 2.139095E+09f;
			}
			object obj122 = obj83;
			tornPiece.life = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4105 @ X0_v88+E4]");
			bool flag97 = (nint)0 == 0;
			object obj123 = !flag97;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse gillaCorpse = (GillaCorpse)(root & 0xFFFFFFFFL);
			Name(gameObject2, key, gillaCorpse);
			Transform transform6 = gameObject2.transform;
			Transform transform7 = gameObject2.transform;
			bool flag98 = (object)transform7 == null;
			list = (List<(Source, Side)>)(object)source;
			num15 = (nint)intPtr;
			num = (float)num95;
			vector = spin;
			quaternion = (Quaternion)gillaCorpse;
			text = null;
			if (!flag98)
			{
				Vector3 vector3 = transform7.TransformPoint((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
				object obj124 = 0;
				object obj125 = obj124;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4328 @ X0_v96+E4]");
				bool flag99 = (nint)0 == 0;
				object obj126 = !flag99;
				if (obj126 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj127 = default;
				bool flag100 = GillaDoor.OutOfSlabs(transform6, (Bounds)(&obj127), rigidbody);
				goto IL_3f91;
			}
		}
		goto IL_3f96;
		IL_4ce4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E1AC");
		num15 = num12;
		ex28 = (IndexOutOfRangeException)(object)ex6;
		goto IL_4040;
		IL_19cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj128 = 0;
		object obj129 = obj128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2384 @ X0_v42+E4]");
		bool flag101 = (nint)0 == 0;
		object obj130 = !flag101;
		if (obj130 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(gameObject);
		goto IL_1a30;
	}

	private unsafe static float WholeVolume(List<(Source, Side)> parts, Bounds side)
	{
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected F4, but got Unknown
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected F8, but got I4
		//IL_0046: Expected F8, but got I4
		//IL_004f: Expected F8, but got I4
		//IL_0058: Expected F8, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected F8, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected VT, but got Obj
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected F4, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_07e5: Expected VT, but got Obj
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Ref, but got Unknown
		//IL_0808: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Invalid comparison between Unknown and I4
		//IL_0279: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_03d8: Invalid comparison between VT and I4
		//IL_01e7: Expected F8, but got I
		//IL_01f7: Expected F8, but got I
		//IL_0207: Expected F8, but got I
		//IL_0217: Expected F8, but got I
		//IL_0428: Invalid comparison between VT and I4
		//IL_081f: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got I4
		//IL_04dc: Invalid comparison between F8 and I4
		//IL_04eb: Invalid comparison between F8 and I4
		//IL_04fe: Expected Obj, but got F8
		//IL_050b: Expected Obj, but got F8
		//IL_054a: Expected Obj, but got I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I4
		//IL_0661: Invalid comparison between F8 and I4
		//IL_0670: Invalid comparison between F8 and I4
		//IL_0683: Expected Obj, but got F8
		//IL_0690: Expected Obj, but got F8
		//IL_06c5: Expected Obj, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		bool flag = parts == null;
		Enumerator<, > val2 = default;
		Enumerator<, > val = val2;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Enumerator<, > val4 = (Enumerator<, >)0;
		Bounds bounds = side;
		object obj = 109891584;
		float result;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7540]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7530]");
			obj = 0;
			Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon)>)(object)parts).GetEnumerator();
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			object obj3 = 0;
			double num5 = (double)val2;
			Enumerator<, > val5 = default;
			val4 = val5;
			object obj12 = default;
			object obj26 = default;
			object obj27 = default;
			object obj19;
			Enumerator<, > val6;
			while (true)
			{
				bounds = (Bounds)obj2;
				if (val3.MoveNext())
				{
					object obj4 = obj3 & 1;
					if (obj4 != null)
					{
						if ((int)val2 == 0)
						{
							NullReferenceException ex = new NullReferenceException();
							break;
						}
						double num6 = num2 - num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+54]");
						double num7 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+60]");
						double num8 = num7 - 0.0;
						double num9 = num3 + num2;
						double num10 = num - num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+54]");
						double num11 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+60]");
						double num12 = num11 + 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+58]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+64]");
						object obj5 = num13 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num6 < num8))
						{
							num6 = num8;
						}
						double num14 = num9 - num8;
						bool flag2 = num14 < 0.0;
						bool flag3 = num14 == 0.0;
						object obj6 = num9 ^ num8;
						object obj7 = num9 ^ num14;
						object obj8 = obj6 & obj7;
						bool flag4 = (nint)obj8 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						bool flag5 = flag2 == flag4;
						object obj9 = !flag3;
						object obj10 = flag5 & obj9;
						object obj11 = ~obj10;
						if (obj11 == null)
						{
							num8 = num9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						double num15 = num8 - num6;
						double num16 = (double)obj12 - num10;
						double num17 = num15 * 0.5;
						double num18 = num16 * 63.0;
						double num19 = num6 + num17;
						double num20 = num10 + num18;
						num5 = num19 - num17;
						double num21 = num17 + num19;
						double num22 = num20 - num18;
						double num23 = num18 + num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num5 < num12))
						{
							num5 = num12;
						}
						double num24 = num21 - num12;
						bool flag6 = num24 < 0.0;
						bool flag7 = num24 == 0.0;
						object obj13 = num21 ^ num12;
						object obj14 = num21 ^ num24;
						object obj15 = obj13 & obj14;
						bool flag8 = (nint)obj15 < 0;
						bool flag9 = flag6 == flag8;
						object obj16 = !flag7;
						object obj17 = flag9 & obj16;
						object obj18 = ~obj17;
						if (obj18 == null)
						{
							num12 = num21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						val4 = (Enumerator<, >)(num12 - num5);
						double num25 = num18 - num19;
						num3 = (double)val4 * 0.5;
						num4 = num25 * 63.0;
						num2 = num5 + num3;
						num = num19 + num4;
					}
					else
					{
						if ((int)val2 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+54]");
						num2 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+58]");
						num = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+60]");
						num3 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ stack_-90 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`2<System.__Canon, System.__Canon>>)+64]");
						num4 = 0.0;
					}
					obj3 = 1;
					continue;
				}
				val = (Enumerator<, >)0;
				obj19 = 0;
				val3 = val5;
				result = (float)val4;
				val6 = (Enumerator<, >)(ref val3);
				object obj20 = 5;
				object obj21 = 0;
				while (true)
				{
					bounds = (Bounds)obj;
					((Enumerator<, >*)val6)->Dispose();
					bool flag10 = obj21 == null;
					object obj22 = !flag10;
					if (obj22 == null)
					{
						bool flag11 = (int)val == 0;
						object obj23 = !flag11;
						OutOfMemoryException ex2 = (OutOfMemoryException)val6;
						if (obj23 == null)
						{
							if ((nint)obj20 != 5)
							{
								bool flag12 = obj20 == null;
								object obj24 = !flag12;
								if (obj24 != null)
								{
									goto IL_0792;
								}
							}
							object obj25 = obj3 & 1;
							double num26;
							double num27;
							if (obj25 != null)
							{
								num26 = num3 + num3;
								num27 = num4 + num4;
							}
							else
							{
								num26 = (double)side.m_Extents + (double)side.m_Extents;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ X1 (UnityEngine.Bounds)+10]");
								double num28 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [side @ X1 (UnityEngine.Bounds)+10]");
								num27 = num28 + 0.0;
							}
							double num29 = num26 * num27;
							result = (float)num29 * (float)obj26;
							goto IL_0792;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (bounds == (Bounds)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						val = (Enumerator<, >)1;
						obj21 = obj19;
					}
					else
					{
						if (bounds != (Bounds)(object)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj21 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj19 = obj27;
					}
					obj20 = 0;
					continue;
					IL_0792:
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E1AC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			NullReferenceException ex3 = new NullReferenceException();
			val = (Enumerator<, >)0;
			obj19 = 0;
			val3 = val5;
			val6 = (Enumerator<, >)(ref val3);
		}
		result = (float)val4;
		throw new NullReferenceException();
	}

	static GillaSlice()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I8
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I8
		//IL_01c3: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I8
		//IL_03fb: Expected Obj, but got I
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj3 = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = obj;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = default;
			object obj7 = obj8 + 32;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X20_v6-8]");
			object obj9 = 0 & 0xFFFFFFFEL;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
				object obj10 = 0;
				object obj11 = obj8 + 40;
				obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj12 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v8-10]");
				object obj13 = -2;
				bool flag2 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7720]");
					object obj16 = 0;
					object obj17 = obj8 + 48;
					obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v10-18]");
					object obj18 = 0 & 0xFFFFFFFCL;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
						object obj19 = 0;
						object obj20 = obj8 + 56;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X20_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj21 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X20_v12-20]");
						object obj22 = -4;
						bool flag4 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag4;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7728]");
							object obj25 = 0;
							object obj26 = obj8 + 64;
							obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v14-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj27 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X20_v14-28]");
							object obj28 = -5;
							bool flag6 = obj28 == null;
							object obj29 = ~obj27;
							object obj30 = obj29 | flag6;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7730]");
								object obj31 = 0;
								object obj32 = obj8 + 72;
								obj32 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X20_v16-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj33 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X20_v16-30]");
								object obj34 = -6;
								bool flag8 = obj34 == null;
								object obj35 = ~obj33;
								object obj36 = obj35 | flag8;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
									object obj37 = 0;
									object obj38 = obj8 + 80;
									obj38 = obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X20_v18-38]");
									object obj39 = 0 & 0xFFFFFFF8L;
									if (obj39 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
										object obj40 = 0;
										object obj41 = obj8 + 88;
										obj41 = obj40;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v20-40]");
										bool flag9 = (nint)0 < (nint)8;
										object obj42 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X20_v20-40]");
										object obj43 = -8;
										bool flag10 = obj43 == null;
										object obj44 = ~obj42;
										object obj45 = obj44 | flag10;
										if (obj45 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7738]");
											object obj46 = 0;
											object obj47 = obj8 + 96;
											obj47 = obj46;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X20_v22-48]");
											bool flag11 = (nint)0 < (nint)9;
											object obj48 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X20_v22-48]");
											object obj49 = -9;
											bool flag12 = obj49 == null;
											object obj50 = ~obj48;
											object obj51 = obj50 | flag12;
											if (obj51 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
												object obj52 = 0;
												object obj53 = obj8 + 104;
												obj53 = obj52;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj54 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v36+A0]");
												object obj55 = (nint)0 + (nint)8;
												obj55 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj56 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v37+A0]");
												object obj57 = 0;
												_ = 4294967295L;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal unsafe static int _003CCap_003Eg__PointOf_007C52_0(Vector3 v, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_1)
	{
		//IL_0954: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I
		//IL_09ed: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got I8
		//IL_093f: Expected Obj, but got I8
		//IL_0913: Expected VT, but got Obj
		//IL_0920: Expected Obj, but got I8
		//IL_0a09: Invalid comparison between F4 and I4
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got F4
		//IL_010a: Expected Ref, but got VT
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected Obj, but got Unknown
		//IL_0816: Expected Obj, but got Ref
		//IL_0137: Expected Ref, but got VT
		//IL_013f: Expected Obj, but got Ref
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_033c: Expected Obj, but got Ref
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0372: Expected Obj, but got Ref
		//IL_08db: Expected Obj, but got I4
		//IL_08e4: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I
		//IL_0891: Expected Obj, but got I4
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Ref
		//IL_017e: Invalid comparison between F4 and I4
		//IL_0395: Expected Obj, but got F4
		//IL_03a3: Invalid comparison between F4 and I4
		//IL_03b1: Expected Obj, but got Ref
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Ref
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Ref
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Ref, but got Unknown
		//IL_0288: Expected Obj, but got Ref
		//IL_01ad: Expected Obj, but got F4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Ref
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I
		//IL_03cf: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_0431: Expected Obj, but got Ref
		//IL_0249: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_0263: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_050a: Expected VT, but got I
		//IL_050a: Expected Obj, but got F4
		//IL_0545: Invalid comparison between F4 and I4
		//IL_0553: Expected Obj, but got Ref
		//IL_048c: Expected Obj, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_0576: Expected VT, but got Obj
		//IL_058c: Expected Obj, but got F4
		//IL_05aa: Expected Obj, but got I4
		//IL_05b2: Expected Ref, but got VT
		//IL_05ba: Expected Obj, but got Ref
		//IL_05e0: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_061e: Invalid comparison between F4 and I4
		//IL_062c: Expected Obj, but got Ref
		//IL_0725: Expected Obj, but got I4
		//IL_0652: Expected Obj, but got I
		//IL_0670: Expected Obj, but got Ref
		//IL_0670: Expected Obj, but got F4
		//IL_0678: Expected Ref, but got VT
		//IL_0750: Expected Obj, but got I
		//IL_0766: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v3+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		ref System.__Canon reference = default;
		object obj3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) / (nint)0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v6+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C98]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj9 = 0;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		int num = 17276928;
		Enumerator<, > val = (Enumerator<, >)0;
		ref System.__Canon reference2 = ref reference;
		int num2 = 0;
		object obj14 = obj3;
		object obj15 = 4294967295L;
		object obj19 = default;
		List<int> list2 = default;
		List<int> list4 = default;
		List<int> list5 = default;
		Enumerator<, > val3 = default;
		int result = default;
		while (true)
		{
			object obj16 = obj15 + obj14;
			object obj17 = 4294967295L;
			while (true)
			{
				object obj18 = obj17 + obj19;
				Vector3Int vector3Int = (Vector3Int)(obj16 | obj18);
				object obj20 = 4294967295L;
				ref System.__Canon reference3;
				nint num3;
				ref GillaSonar._003C_003Ec__DisplayClass52_0 reference4;
				List<int> list;
				while (v.x != 0f)
				{
					object obj21 = obj7;
					reference3 = ref *(System.__Canon*)((ref *(byte*)obj20) + (ref System.Runtime.CompilerServices.Unsafe.As<System.__Canon, byte>(ref reference)));
					bool flag2 = ((Dictionary<Vector3Int, System.__Canon>)v.x).TryGetValue(vector3Int, out reference3);
					bool flag3 = !flag2;
					reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)vector3Int;
					num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
					if (!flag3)
					{
						goto IL_0120;
					}
					obj20++;
					bool flag4 = (nint)obj20 != 2;
					list = (List<int>)(&list2);
					if (flag4)
					{
						continue;
					}
					goto IL_0314;
				}
				goto IL_078e;
				IL_0314:
				obj17++;
				bool flag5 = (nint)obj17 != 2;
				list = (List<int>)(&list2);
				if (flag5)
				{
					continue;
				}
				obj15++;
				bool flag6 = (nint)obj15 != 2;
				list = (List<int>)(&list2);
				obj14 = obj3;
				if (flag6)
				{
					break;
				}
				List<Vector3> list3 = (List<Vector3>)v.z;
				bool flag7 = v.z == 0f;
				list = (List<int>)(&list2);
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					num = 0;
					object obj24 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj25 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					bool flag8 = (nint)0 == 0;
					list = (List<int>)(&list2);
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v28+18]");
						bool flag9 = num4 < 0;
						object obj26 = !flag9;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj27 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj28 = 0 + obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj29 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X9_v13+20]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v42+A8]");
							object obj31 = 0;
							float z = v.z;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v43+70]");
							((List<Vector3>)z).AddWithResize((Vector3)0);
							obj10 = obj11;
							obj12 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v43+70]");
							reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)null;
							reference2 = ref reference;
						}
						bool flag10 = v.x == 0f;
						list = (List<int>)(&list2);
						if (!flag10)
						{
							object obj21 = obj7;
							Vector3Int vector3Int2 = (Vector3Int)(obj3 | obj19);
							bool flag11 = ((Dictionary<Vector3Int, System.__Canon>)v.x).TryGetValue(vector3Int2, out reference);
							bool flag12 = !flag11;
							object obj32 = !flag12;
							reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)vector3Int2;
							list = (List<int>)(&list4);
							num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
								object obj34 = 0;
								reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)obj34;
								list5._002Ector();
								bool flag13 = v.x == 0f;
								list = (List<int>)(&list4);
								num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
								if (flag13)
								{
									goto IL_078e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CA0]");
								object obj35 = 0;
								obj21 = obj35;
								((Dictionary<Vector3Int, System.__Canon>)v.x).set_Item(vector3Int2, (System.__Canon)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
								reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)vector3Int2;
								list = list5;
								num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							}
							if (list5 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								object obj37 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v32+18]");
									bool flag14 = num5 < 0;
									object obj38 = !flag14;
									if (obj38 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+10]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj39 = num6 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v36 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj40 = (nint)0 + (nint)1;
									}
									else
									{
										list5.AddWithResize(num);
									}
									return num;
								}
							}
						}
					}
				}
				goto IL_078e;
				IL_0120:
				bool flag15 = list2 == null;
				reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)vector3Int;
				list = (List<int>)(&list2);
				num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
				if (flag15)
				{
					goto IL_078e;
				}
				Enumerator<, > enumerator = list2.GetEnumerator();
				Enumerator<, > val2 = val3;
				while (true)
				{
					reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)obj8;
					if (!val.MoveNext())
					{
						break;
					}
					if (v.z != 0f)
					{
						reference3 = ref *(System.__Canon*)obj9;
						Vector3 vector = ((List<Vector3>)v.z).get_Item(0);
						object obj41 = (ref *(byte*)val2) - (ref System.Runtime.CompilerServices.Unsafe.As<System.__Canon, byte>(ref reference));
						object obj42 = obj12 - obj13;
						obj10 -= obj11;
						object obj43 = obj41 * obj41;
						object obj44 = obj42 * obj42;
						object obj45 = obj43 + obj44;
						obj12 = obj10 * obj10;
						val2 = (Enumerator<, >)(obj12 + obj45);
						Enumerator<, > val4 = val2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A848]");
						if ((nint)val4 >= (nint)0)
						{
							continue;
						}
						goto IL_0240;
					}
					goto IL_02e6;
				}
				object obj46 = 8;
				object obj47 = 0;
				num = num2;
				num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
				goto IL_0856;
				IL_078e:
				NullReferenceException ex = new NullReferenceException();
				goto IL_079c;
				IL_079c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				val2 = (Enumerator<, >)(ref reference2);
				goto IL_07b3;
				IL_0240:
				obj46 = 11;
				obj47 = 0;
				num = 0;
				num3 = (nint)obj9;
				goto IL_0856;
				IL_02e6:
				NullReferenceException ex2 = new NullReferenceException();
				Enumerator<, > val5 = (Enumerator<, >)(ref val);
				list = (List<int>)(&list2);
				num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
				OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
				goto IL_08af;
				IL_07b3:
				ex3 = new OutOfMemoryException();
				goto IL_08af;
				IL_0856:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
				object obj48 = 0;
				reference4 = ref *(GillaSonar._003C_003Ec__DisplayClass52_0*)obj48;
				val.Dispose();
				bool flag16 = obj47 == null;
				object obj49 = !flag16;
				val5 = (Enumerator<, >)(ref val);
				list = (List<int>)(&list2);
				if (obj49 == null)
				{
					val5 = (Enumerator<, >)(ref val);
					list = (List<int>)(&list2);
					reference2 = ref *(System.__Canon*)val2;
					ex = (NullReferenceException)(&val);
					goto IL_079c;
				}
				goto IL_07b3;
				IL_08af:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
		}
	}

	internal static void _003CCap_003Eg__Link_007C52_1(int a, int b, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_2)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002e: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+10]");
		bool flag = ((Dictionary<int, System.__Canon>)0).TryGetValue(a, out var _);
		bool flag2 = !flag;
		object obj2 = !flag2;
		List<int> list = default;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+10]");
			((Dictionary<int, System.__Canon>)0).set_Item(a, (System.__Canon)(object)list);
		}
		bool flag3 = list.Contains(b);
		bool flag4 = !flag3;
		object obj4 = !flag4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj6 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v10+18]");
			bool flag5 = num < 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj8 = obj5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj9 = (nint)0 + (nint)1;
			}
			else
			{
				list.AddWithResize(b);
			}
		}
	}

	internal static Vector2 _003CCap_003Eg__Flat_007C52_2(int i, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_1)
	{
		//IL_0070: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
			Vector3 vector = ((List<Vector3>)0).get_Item(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
				return ((List<Vector3>)0).get_Item(i);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
	}

	internal static long _003CCap_003Eg__Edge_007C52_3(int a, int b)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0114: Expected I4, but got I8
		//IL_012f: Expected I8, but got I4
		object obj = a - b;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = a ^ b;
		int num2 = a ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag4;
		object obj3 = ~obj2;
		int num4 = ((obj3 != null) ? b : a);
		bool flag5 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag5 & obj4;
		object obj6 = ~obj5;
		int num5 = ((obj6 != null) ? b : a);
		int num6 = (int)(num4 & 0xFFFFFFFFL);
		int num7 = num6 << 20;
		return num7 + num5;
	}

	internal unsafe static void _003CCap_003Eg__Walk_007C52_4(int start, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_1)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected I4, but got Obj
		//IL_102a: Expected Obj, but got I4
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a4: Expected Obj, but got I
		//IL_12ac: Expected I4, but got Obj
		//IL_12ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected Ref, but got Unknown
		//IL_12cf: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_0ed5: Expected Obj, but got I4
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected Obj, but got Unknown
		//IL_0fab: Expected Obj, but got I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected Obj, but got Unknown
		//IL_01ce: Expected I4, but got I8
		//IL_01e4: Expected I, but got Obj
		//IL_01f1: Expected I8, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_0e55: Expected Obj, but got I4
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_0264: Expected I4, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_043e: Expected I, but got Obj
		//IL_0453: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I4
		//IL_0480: Expected I4, but got I8
		//IL_0495: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I
		//IL_0ba4: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I4
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got I4
		//IL_0c00: Expected Obj, but got I
		//IL_0c4e: Expected Obj, but got I4
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I
		//IL_0c84: Expected Obj, but got I4
		//IL_0d72: Expected Obj, but got I
		//IL_0d82: Expected Obj, but got I
		//IL_0da7: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I
		//IL_05ed: Expected I, but got Obj
		//IL_0602: Expected Obj, but got I
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got Unknown
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected Obj, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected I4, but got Obj
		//IL_07ad: Expected I4, but got I8
		//IL_123b: Expected Obj, but got I
		//IL_1243: Expected I4, but got Obj
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got I4
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected Obj, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got I4
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected I4, but got Unknown
		//IL_072f: Expected I, but got Obj
		//IL_0748: Expected Obj, but got I4
		//IL_108b: Expected Obj, but got I4
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected Obj, but got Unknown
		//IL_10c1: Expected I4, but got I8
		//IL_10dc: Expected I8, but got I4
		//IL_10f1: Expected Obj, but got I
		//IL_110f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+10]");
		bool flag = (nint)0 == 0;
		int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref P_1);
		Enumerator<, > val;
		Enumerator<, > val4 = default;
		int num3;
		object obj5 = default;
		Enumerator<, > val5 = default;
		Enumerator<, > val7 = default;
		Enumerator<, > val6;
		Enumerator<, > val2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B50]");
			object obj = 0;
			nint num2 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+10]");
			System.__Canon _Canon = ((Dictionary<int, System.__Canon>)0).get_Item(start);
			bool flag2 = _Canon == null;
			num = start;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7718]");
				object obj4 = 0;
				Enumerator<, > enumerator = ((List<int>)(object)_Canon).GetEnumerator();
				val = (Enumerator<, >)0;
				Enumerator<, > val3 = default;
				val2 = val3;
				int num4 = default;
				List<int> list = default;
				int num16 = default;
				while (true)
				{
					num = (int)obj2;
					bool flag3 = val4.MoveNext();
					bool flag4 = !flag3;
					num3 = 0;
					obj5 = 0;
					val5 = (Enumerator<, >)(ref val4);
					if (flag4)
					{
						break;
					}
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v34+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj8 = start - num4;
					bool flag6 = (nint)obj8 < 0;
					bool flag7 = obj8 == null;
					int num5 = start ^ num4;
					int num6 = start ^ obj8;
					int num7 = num5 & num6;
					bool flag8 = num7 < 0;
					bool flag9 = flag6 == flag8;
					object obj9 = !flag9;
					object obj10 = ~obj9;
					int num8 = ((obj10 != null) ? num4 : start);
					bool flag10 = flag6 == flag8;
					object obj11 = !flag7;
					object obj12 = flag10 & obj11;
					object obj13 = ~obj12;
					int num9 = ((obj13 != null) ? num4 : start);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
					if ((nint)0 != 0)
					{
						int num10 = (int)(num8 & 0xFFFFFFFFL);
						int num11 = num10 << 20;
						num2 = (nint)obj4;
						long num12 = num11 + num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
						bool flag11 = ((HashSet<long>)0).Contains(num12);
						bool flag12 = !flag11;
						object obj14 = !flag12;
						if (obj14 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
						object obj16 = 0;
						num = (int)obj16;
						list._002Ector();
						if (list != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							object obj19 = (nint)0 + (nint)1;
							object obj20 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X8_v31+18]");
								bool flag13 = num13 < 0;
								object obj21 = !flag13;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj22 = num14 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj23 = (nint)0 + (nint)1;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X9_v17+20]");
									object obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v85+A8]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v86+70]");
									num2 = 0;
									list.AddWithResize(start);
									num = start;
								}
								object obj26 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v49+E4]");
								bool flag14 = (nint)0 == 0;
								object obj27 = !flag14;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
								if ((nint)0 == 0)
								{
									goto IL_0e35;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B90]");
								object obj28 = 0;
								num2 = (nint)obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
								bool flag15 = ((HashSet<long>)0).Add(num12);
								int num15 = num16;
								object obj29 = 0;
								int num17 = num4;
								num = (int)num12;
								if (num17 != start)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
									object obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+1C]");
									object obj32 = (nint)0 + (nint)1;
									object obj33 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
									if ((nint)0 == 0)
									{
										goto IL_0de0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v43+18]");
									bool flag16 = num18 < 0;
									object obj34 = !flag16;
									if (obj34 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+10]");
										nint num19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj35 = num19 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj36 = (nint)0 + (nint)1;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X9_v26+20]");
										object obj37 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X8_v82+A8]");
										object obj38 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v83+70]");
										num2 = 0;
										list.AddWithResize(num17);
										num = num17;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+10]");
									if ((nint)0 == 0)
									{
										goto IL_0dd2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B50]");
									object obj39 = 0;
									num2 = (nint)obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+10]");
									System.__Canon _Canon2 = ((Dictionary<int, System.__Canon>)0).get_Item(num17);
									bool flag17 = _Canon2 == null;
									num = num17;
									if (!flag17)
									{
										Enumerator<, > enumerator2 = ((List<int>)(object)_Canon2).GetEnumerator();
										while (true)
										{
											num = (int)obj2;
											if (val.MoveNext())
											{
												if (num15 == start)
												{
													continue;
												}
												object obj40 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X0_v87+E4]");
												bool flag18 = (nint)0 == 0;
												object obj41 = !flag18;
												if (obj41 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
												if ((nint)0 == 0)
												{
													break;
												}
												object obj42 = num17 - num15;
												bool flag19 = (nint)obj42 < 0;
												bool flag20 = obj42 == null;
												int num20 = num17 ^ num15;
												int num21 = num17 ^ obj42;
												int num22 = num20 & num21;
												bool flag21 = num22 < 0;
												num2 = (nint)obj4;
												bool flag22 = flag19 == flag21;
												object obj43 = !flag22;
												object obj44 = ~obj43;
												int num23 = ((obj44 != null) ? num15 : num17);
												bool flag23 = flag19 == flag21;
												object obj45 = !flag20;
												object obj46 = flag23 & obj45;
												object obj47 = ~obj46;
												int num24 = ((obj47 != null) ? num15 : num17);
												int num25 = (int)(num23 & 0xFFFFFFFFL);
												int num26 = num25 << 20;
												long item = num26 + num24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+40]");
												bool flag24 = ((HashSet<long>)0).Contains(item);
												bool flag25 = !flag24;
												object obj48 = !flag25;
												if (obj48 != null)
												{
													continue;
												}
												int num27 = num15;
											}
											else
											{
												int num27 = -1;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
											object obj49 = 0;
											num = (int)obj49;
											val.Dispose();
											OutOfMemoryException ex = new OutOfMemoryException();
											val6 = (Enumerator<, >)(ref val);
											val2 = val7;
											goto IL_0dd2;
										}
										goto IL_0980;
									}
									goto IL_0dfd;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v45 (System.Collections.Generic.List`1<System.Int32>)+18]");
								bool flag26 = (nint)0 < (nint)3;
								num16 = num15;
								if (flag26)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+48]");
								List<System.__Canon> list2 = (List<System.__Canon>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+48]");
								bool flag27 = (nint)0 == 0;
								num3 = 0;
								obj5 = 0;
								val5 = (Enumerator<, >)(ref val4);
								if (!flag27)
								{
									System.__Canon[] items = list2._items;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A50]");
									object obj50 = 0;
									int version = list2._version + 1;
									object obj51 = obj50;
									list2._version = version;
									bool flag28 = list2._items == null;
									num3 = 0;
									obj5 = 0;
									val5 = (Enumerator<, >)(ref val4);
									if (!flag28)
									{
										bool flag29 = list2._size < items.Length;
										object obj52 = !flag29;
										if (obj52 == null)
										{
											object obj53 = list2._items + list2._size;
											int size = list2._size + 1;
											list2._size = size;
											object obj54 = obj53 + 32;
											obj54 = list;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											num16 = num15;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X9_v22+20]");
											object obj55 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X8_v39+A8]");
											object obj56 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v40+70]");
											num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+48]");
											((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)list);
											num16 = num15;
										}
										continue;
									}
								}
								goto IL_0e79;
							}
						}
						goto IL_0e19;
					}
					goto IL_0e27;
					IL_0dd2:
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0de0;
					IL_0e27:
					NullReferenceException ex3 = new NullReferenceException();
					goto IL_0e35;
					IL_0dfd:
					NullReferenceException ex4 = new NullReferenceException();
					NullReferenceException ex5 = new NullReferenceException();
					goto IL_0e19;
					IL_0de0:
					NullReferenceException ex6 = new NullReferenceException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_0dfd;
					IL_0e19:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_0e27;
					IL_0e35:
					NullReferenceException ex8 = new NullReferenceException();
					NullReferenceException ex9 = new NullReferenceException();
					obj5 = 0;
					val5 = (Enumerator<, >)(ref val4);
					goto IL_0e62;
				}
				goto IL_0eae;
			}
		}
		goto IL_0e62;
		IL_1271:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0e62:
		NullReferenceException ex10 = new NullReferenceException();
		num3 = 0;
		goto IL_0e79;
		IL_121c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 1;
			goto IL_0eae;
		}
		bool flag30 = num != 1;
		NullReferenceException ex12;
		NullReferenceException ex11 = ex12;
		if (flag30)
		{
			goto IL_1271;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj58 = default;
		object obj57 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_1294;
		IL_0e79:
		ex12 = new NullReferenceException();
		goto IL_121c;
		IL_1294:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
		object obj59 = 0;
		num = (int)obj59;
		((Enumerator<, >*)val5)->Dispose();
		bool flag31 = obj57 == null;
		object obj60 = !flag31;
		if (obj60 == null)
		{
			bool flag32 = num3 == 0;
			object obj61 = !flag32;
			OutOfMemoryException ex13 = (OutOfMemoryException)val5;
			if (obj61 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex13 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex14 = default;
		ex11 = ex14;
		goto IL_1271;
		IL_0eae:
		obj57 = obj5;
		goto IL_1294;
		IL_0980:
		ex12 = new NullReferenceException();
		val6 = (Enumerator<, >)(ref val);
		num3 = 0;
		obj5 = 0;
		val2 = val7;
		val5 = (Enumerator<, >)(ref val4);
		goto IL_121c;
	}

	internal static Vector3 _003CCap_003Eg__First_007C52_5(List<int> c, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_1)
	{
		//IL_006a: Expected VT, but got Obj
		//IL_0053: Expected Obj, but got I
		if (c != null)
		{
			int index = c.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
				return ((List<Vector3>)0).get_Item(index);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	internal static Vector3 _003CCap_003Eg__Last_007C52_6(List<int> c, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_1)
	{
		//IL_007f: Expected VT, but got Obj
		//IL_0068: Expected Obj, but got I
		if (c != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X0 (System.Collections.Generic.List`1<System.Int32>)+18]");
			int index = (int)(-1);
			int index2 = c.get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass52_0&)+8]");
				return ((List<Vector3>)0).get_Item(index2);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	internal static int _003CCap_003Eg__Mid_007C52_7(int a, int b, ref GillaSonar._003C_003Ec__DisplayClass52_0 P_2)
	{
		//IL_031e: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected I4, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_02f7: Expected I4, but got Obj
		//IL_0039: Expected I8, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_028b: Expected VT, but got I
		//IL_028b: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I
		//IL_02d7: Expected I8, but got I4
		//IL_02d7: Expected Obj, but got I
		int num = b | a;
		int num2 = a | b;
		object obj = a - b;
		bool flag = (nint)obj < 0;
		int num3 = a ^ b;
		int num4 = a ^ obj;
		int num5 = num3 & num4;
		bool flag2 = num5 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		int num6 = ((obj3 != null) ? num2 : num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+58]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+58]");
			bool flag4 = ((Dictionary<long, int>)0).TryGetValue(num6, out var _);
			bool flag5 = !flag4;
			object obj4 = !flag5;
			if (obj4 != null)
			{
				goto IL_02dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
			List<Vector3> list = (List<Vector3>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
				Vector3 vector = ((List<Vector3>)0).get_Item(a);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
					Vector3 vector2 = ((List<Vector3>)0).get_Item(b);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj6 = 0;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj8 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						object obj10 = default;
						object obj9 = obj10 + obj10;
						object obj12 = default;
						object obj11 = obj12 + obj12;
						object obj14 = default;
						object obj13 = obj14 + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v10+18]");
						bool flag6 = num7 < 0;
						object obj15 = !flag6;
						double num8 = (double)obj9 * 0.5;
						double num9 = (double)obj11 * 0.5;
						double num10 = (double)obj13 * 0.5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj16 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj17 = 0 + obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj18 = (nint)0 + (nint)1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v7+20]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14+A8]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+60]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v15+70]");
							((List<Vector3>)num11).AddWithResize((Vector3)0);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+58]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass52_0&)+58]");
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							((Dictionary<long, int>)num12).set_Item((long)num6, 0);
							goto IL_02dc;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_02dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X23_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
		return 0;
	}
}
