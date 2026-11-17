using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

public static class GillaStains
{
	public enum Stuff
	{
		// error: enumerator has no value
		Blood,
		// error: enumerator has no value
		Yolk
	}

	public class Sheet
	{
		public Texture2D map;

		public readonly byte[] pixels;

		public int users;

		public int working;

		public bool changed;

		public bool egg;

		public float nextFade;

		public float fadeOver;

		public Sheet()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 24;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public class Shape
	{
		public Vector3[] at;

		public Vector3[] faces;

		public Vector2[] uv;

		public BoneWeight[] weights;

		public Matrix4x4[] binds;

		public int[] tris;

		public int[] fur;
	}

	public class Piece
	{
		public Mesh mesh;

		public string name;

		public Shape shape;

		public Matrix4x4[] bones;

		public Vector3[] at;

		public Vector3[] faces;
	}

	public class Job
	{
		public Sheet sheet;

		public List<Piece> pieces;

		public Vector3 point;

		public Vector3 to;

		public float radius;

		public float reach;

		public float strength;

		public float big;

		public bool line;

		public Stuff stuff;

		public int seed;
	}

	private struct Blot
	{
		public Vector3 a;

		public Vector3 b;

		public Vector3 faces;

		public float abX;

		public float abY;

		public float abZ;

		public float ab2;

		public float ra;

		public float rb;

		public int channel;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Piece> _003C_003E9__39_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F0]");
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

		internal bool _003CPump_003Eb__39_0(Piece p)
		{
			//IL_00aa: Expected I4, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			if (p != null)
			{
				if (p.shape != null)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return p.mesh == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public Job j;

		internal void _003CPump_003Eb__1(Task _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_005a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Work(j);
		}
	}

	public const int Size = default(int);

	private const float EggLasts = default(float);

	private const float FadeEvery = default(float);

	private const int MostSpare = default(int);

	private static readonly List<Sheet> sheets;

	private static readonly Stack<Sheet> spare;

	private static readonly Dictionary<Texture, Sheet> ofMap;

	private static readonly Queue<Job> waiting;

	private static readonly Dictionary<string, Shape> shapes;

	private static readonly Dictionary<Mesh, string> shapeNames;

	private static Task queue;

	private static bool noiseLaid;

	private static readonly int NoiseId;

	private static readonly ProfilerMarker SendMark;

	private static readonly ProfilerMarker ReadMark;

	private static readonly ProfilerMarker PaintMark;

	private static Blot[] blots;

	private static Vector4[] blotBalls;

	private static int blotCount;

	private static readonly List<int> nearBlots;

	private const int Across = default(int);

	private static readonly List<int>[] squares;

	private static readonly List<int> usedSquares;

	private static Vector3[][] posedAt;

	private static Vector3[][] posedFaces;

	private static float[] upTo;

	private static int[] upToPiece;

	private static int[] upToTri;

	private static Matrix4x4[] skinning;

	private unsafe static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0821: Expected Obj, but got I4
		//IL_09f2: Expected Obj, but got I
		//IL_0a0b: Expected VT, but got I4
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected I4, but got Obj
		//IL_0998: Expected I4, but got Obj
		//IL_09ab: Expected VT, but got I4
		//IL_09b4: Expected Obj, but got I4
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected Obj, but got I4
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected VT, but got I4
		//IL_06c3: Expected Obj, but got I4
		//IL_06cc: Expected Obj, but got I4
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0761: Expected Obj, but got I4
		//IL_076a: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_07c9: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_095f: Expected I4, but got Obj
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Ref, but got Unknown
		//IL_0982: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_04f2: Expected Obj, but got I4
		//IL_090d: Expected Obj, but got I
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got I
		//IL_05be: Expected I4, but got Obj
		//IL_05cf: Expected Obj, but got I
		//IL_05e7: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I
		//IL_0624: Expected I4, but got Obj
		//IL_0635: Expected Obj, but got I
		//IL_064d: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
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
		bool flag2 = obj4 == null;
		System.Collections.Generic.LowLevelListWithIList<System.__Canon>.Enumerator enumerator = (System.Collections.Generic.LowLevelListWithIList<System.__Canon>.Enumerator)0;
		object obj6 = default;
		object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85E0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85C8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85E8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85D0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8610]");
			object obj12 = 0;
			Enumerator<, > enumerator2 = ((List<System.__Canon>)obj4).GetEnumerator();
			obj4 = obj6;
			Enumerator<, > val4 = default;
			object obj19 = default;
			while (true)
			{
				int num = (int)obj7;
				object obj17;
				Enumerator<, > val3;
				Enumerator<, > val5;
				Enumerator<, > val2;
				int num2;
				if (val.MoveNext())
				{
					if (obj6 != null)
					{
						object obj13 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v62+E4]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v62+E4]");
						bool flag3 = (nint)0 == 0;
						object obj14 = !flag3;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-A8+10]");
						bool flag4 = (UnityEngine.Object)0 != null;
						bool flag5 = !flag4;
						num2 = 0;
						if (!flag5)
						{
							object obj15 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v66+E4]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v66+E4]");
							bool flag6 = (nint)0 == 0;
							object obj16 = !flag6;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-A8+10]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
							num2 = 0;
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					enumerator = (System.Collections.Generic.LowLevelListWithIList<System.__Canon>.Enumerator)0;
					obj5 = 0;
					obj17 = 0;
					val2 = (Enumerator<, >)(ref val);
					val3 = val4;
					val5 = (Enumerator<, >)(ref val);
					NullReferenceException ex2 = new NullReferenceException();
					break;
				}
				num = (int)obj9;
				val.Dispose();
				enumerator = (System.Collections.Generic.LowLevelListWithIList<System.__Canon>.Enumerator)0;
				obj5 = 0;
				val = val4;
				obj17 = 0;
				val2 = (Enumerator<, >)(ref val);
				val3 = val4;
				val5 = (Enumerator<, >)(ref val);
				object obj20;
				while (true)
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						object obj18;
						if (num == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj5 = 1;
							obj4 = 1;
							obj18 = obj17;
						}
						else
						{
							if (num != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E934");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj18 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj17 = obj19;
						}
						obj20 = 0;
						num = (int)obj11;
						((System.Collections.Generic.LowLevelListWithIList<System.__Canon>.Enumerator*)val5)->Dispose();
						bool flag7 = obj18 == null;
						object obj21 = !flag7;
						if (obj21 != null)
						{
							break;
						}
						bool flag8 = obj5 == null;
						object obj22 = !flag8;
						ex3 = (OutOfMemoryException)val5;
						obj4 = obj5;
						if (obj22 == null)
						{
							goto end_IL_0702;
						}
					}
					continue;
					end_IL_0702:
					break;
				}
				if ((nint)obj20 != 7)
				{
					bool flag9 = obj20 == null;
					object obj23 = !flag9;
					if (obj23 != null)
					{
						return;
					}
				}
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v9+E4]");
				bool flag10 = (nint)0 == 0;
				object obj25 = !flag10;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v9+A0]");
				obj4 = 0;
				val2 = (Enumerator<, >)obj4;
				if (obj4 == null)
				{
					break;
				}
				num2 = val2._index;
				int version = val2._version + 1;
				((Enumerator<, >*)(nint)val2)->_index = 0;
				((Enumerator<, >*)(nint)val2)->_version = version;
				if (val2._index >= 1)
				{
					Array.Clear((Array)(object)val2._list, 0, val2._index);
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v21+A0]");
					obj4 = 0;
					num = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
				if ((nint)0 == 0)
				{
					break;
				}
				num = (int)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+8]");
				((Stack<System.__Canon>)0).Clear();
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v11+A0]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85C0]");
				object obj28 = 0;
				num = (int)obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+10]");
				((Dictionary<System.__Canon, System.__Canon>)0).Clear();
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v15+A0]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
				((Queue<System.__Canon>)0).Clear();
				object obj30 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v19+A0]");
				object obj31 = 0;
				_ = 0;
				return;
			}
		}
		throw new NullReferenceException();
	}

	public static void LayNoise()
	{
		//IL_0010: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+38]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj11 = default;
		bool flag4 = obj11 != null;
		bool flag5 = !flag4;
		object obj12 = 0;
		string text = null;
		UnityEngine.Object obj13 = null;
		if (!flag5)
		{
			object obj14 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6 (UnityEngine.Object)+18]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			obj12 = 0;
			text = null;
			obj13 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8620]");
				object obj16 = 0;
				text = (string)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6 (UnityEngine.Object)+18]");
				Texture texture = ((Material)0).GetTexture((string)obj16);
				obj12 = 0;
				obj13 = texture;
			}
		}
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v11+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = obj13 == null;
		bool flag11 = !flag10;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v16+E4]");
			bool flag12 = (nint)0 == 0;
			object obj21 = !flag12;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v16+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v13+3C]");
			Shader.SetGlobalTexture(0, (Texture)obj13);
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+A0]");
			object obj24 = 0;
			_ = 1;
		}
	}

	public static Sheet NewSheet()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b5: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I4
		//IL_06b5: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_037b: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8640]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8628]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8638]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8650]");
		object name = 0;
		LayNoise();
		Sheet sheet = null;
		object obj15 = default;
		UnityEngine.Object obj16 = default;
		Sheet sheet2 = default;
		Texture2D texture2D = default;
		while (true)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v43+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+8]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
			if ((nint)0 >= (nint)1)
			{
				if (sheet != null)
				{
					object obj13 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v48+E4]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = sheet.map == null;
					bool flag5 = !flag4;
					obj15 = 0;
					obj16 = null;
					if (flag5)
					{
						goto IL_01fb;
					}
					obj9 = obj;
					obj15 = 0;
					obj16 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v43+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v43+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v27+8]");
				if ((nint)0 == 0)
				{
					break;
				}
				obj16 = (UnityEngine.Object)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v27+8]");
				System.__Canon _Canon = ((Stack<System.__Canon>)0).Pop();
				sheet = (Sheet)(object)_Canon;
				continue;
			}
			bool flag7 = sheet == null;
			object obj19 = obj15;
			UnityEngine.Object obj20 = obj16;
			if (!flag7)
			{
				goto IL_01fb;
			}
			goto IL_028e;
			IL_0390:
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v10+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Send(sheet);
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v14+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v14+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v13+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v13+10]");
			((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)sheet.map, (System.__Canon)(object)sheet);
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v14+A0]");
			object obj27 = 0;
			List<System.__Canon> list = (List<System.__Canon>)obj27;
			if (obj27 == null)
			{
				break;
			}
			System.__Canon[] items = list._items;
			int version = list._version + 1;
			list._version = version;
			if (list._items == null)
			{
				break;
			}
			bool flag10 = list._size < items.Length;
			object obj28 = !flag10;
			if (obj28 == null)
			{
				object obj29 = list._items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj30 = obj29 + 32;
				obj30 = sheet;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				((List<System.__Canon>)obj27).AddWithResize((System.__Canon)(object)sheet);
			}
			return sheet;
			IL_01fb:
			object obj31 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v37+E4]");
			bool flag11 = (nint)0 == 0;
			object obj32 = !flag11;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag12 = sheet.map == null;
			bool flag13 = !flag12;
			obj19 = 0;
			obj20 = null;
			object obj33 = 0;
			UnityEngine.Object obj34 = null;
			if (!flag13)
			{
				goto IL_028e;
			}
			goto IL_0390;
			IL_028e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			sheet2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			texture2D._002Ector(256, 256, (TextureFormat)4, mipChain: false, linear: true);
			if ((object)texture2D == null)
			{
				break;
			}
			texture2D.name = (string)name;
			texture2D.filterMode = (FilterMode)1;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)32;
			if (sheet2 == null)
			{
				break;
			}
			object obj35 = sheet2 + 16;
			obj35 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj33 = 0;
			obj34 = texture2D;
			sheet = sheet2;
			goto IL_0390;
		}
		return (Sheet)(object)new NullReferenceException();
	}

	public static Sheet OfMap(Texture map)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
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
		bool flag2 = map != null;
		bool flag3 = !flag2;
		Sheet result = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v9+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+10]");
			if ((nint)0 == 0)
			{
				return (Sheet)(object)new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+10]");
			bool flag5 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)map, out var value);
			bool flag6 = !flag5;
			object obj8 = !flag6;
			object obj9 = ~obj8;
			result = (Sheet)(object)((obj9 != null) ? null : value);
		}
		return result;
	}

	public unsafe static void Add(Job j)
	{
		//IL_0010: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Ref, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplatter.Here();
		}
		ref int location = ref *(int*)(j.sheet + 36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj7 = 0;
		int num = Interlocked.Increment(ref location);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+18]");
		((Queue<System.__Canon>)0).Enqueue((System.__Canon)(object)j);
	}

	public unsafe static void Pump()
	{
		//IL_0d93: Expected Obj, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0db4: Expected Obj, but got I
		//IL_0dc4: Expected Obj, but got I
		//IL_0dd4: Expected Obj, but got I
		//IL_0de4: Expected Obj, but got I
		//IL_0efd: Expected Obj, but got I4
		//IL_1131: Expected Obj, but got I
		//IL_1141: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I4
		//IL_0f70: Expected Obj, but got I
		//IL_0f80: Expected Obj, but got I
		//IL_0f90: Expected Obj, but got I
		//IL_0fa0: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_0df9: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_1170: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0fbd: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_0e0e: Expected Obj, but got I
		//IL_0e1e: Expected Obj, but got I
		//IL_0e40: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_10c4: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_0313: Expected Obj, but got Ref
		//IL_0230: Expected Obj, but got I4
		//IL_0e5e: Expected Obj, but got I
		//IL_0e78: Expected Obj, but got I
		//IL_0e89: Expected I, but got Obj
		//IL_0ea7: Expected Obj, but got I
		//IL_0a06: Expected Obj, but got I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_0831: Expected Obj, but got I4
		//IL_0ece: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_10e2: Expected Obj, but got I
		//IL_09a2: Expected Obj, but got I4
		//IL_0666: Expected F8, but got I
		//IL_0676: Invalid comparison between F4 and I
		//IL_034b: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0a3b: Expected Obj, but got I
		//IL_0a72: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got I
		//IL_0f1b: Expected Obj, but got I
		//IL_0aa1: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I4
		//IL_0ad4: Expected Obj, but got I
		//IL_0c6a: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_08b8: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I
		//IL_03dd: Expected I, but got Obj
		//IL_03e5: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I4
		//IL_0b15: Expected Obj, but got I4
		//IL_08e7: Expected Obj, but got I
		//IL_090f: Expected Obj, but got I
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_10f7: Expected Obj, but got I
		//IL_1107: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Ref, but got Unknown
		//IL_072e: Expected Obj, but got I4
		//IL_0f28: Expected I, but got Obj
		//IL_0f4a: Expected Obj, but got I4
		//IL_0950: Expected Obj, but got I4
		//IL_0fd2: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I
		//IL_0ff2: Expected Obj, but got I
		//IL_100c: Expected Obj, but got I
		//IL_101d: Expected I, but got Obj
		//IL_102d: Expected Obj, but got I
		//IL_1057: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I
		//IL_0c9e: Expected Obj, but got I4
		//IL_098b: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I4
		//IL_043b: Expected I, but got Obj
		//IL_0ce3: Expected Obj, but got I
		//IL_0d08: Expected Obj, but got I
		//IL_0d08: Expected Obj, but got I
		//IL_0d36: Expected Obj, but got I4
		//IL_0b73: Expected Obj, but got I
		//IL_1075: Expected Obj, but got I
		//IL_109f: Expected Obj, but got I4
		//IL_0d64: Expected Obj, but got I
		//IL_0d74: Expected Obj, but got I
		//IL_0cce: Expected Obj, but got I
		//IL_0b9a: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got I4
		//IL_0804: Expected I4, but got Obj
		//IL_0be9: Expected Obj, but got I4
		//IL_111c: Expected Obj, but got I
		//IL_0c1e: Expected Obj, but got I
		//IL_0c3b: Expected Obj, but got I
		//IL_0c44: Expected Obj, but got I4
		//IL_0c54: Expected Obj, but got I
		//IL_0c5c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8680]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
		Action<System.__Canon> action = (Action<System.__Canon>)0;
		object obj10 = default;
		List<System.__Canon> list = default;
		Predicate<System.__Canon> predicate = default;
		Predicate<System.__Canon> predicate2 = default;
		bool readOne = default;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+20]");
			if ((nint)0 <= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj10._002Ector();
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v96+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v96+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v63+18]");
			System.__Canon _Canon = ((Queue<System.__Canon>)0).Peek();
			object obj14 = obj10 + 16;
			obj14 = _Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = obj14;
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v64+18]");
			list = (List<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v102+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v102+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v90+8]");
			predicate = (Predicate<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v90+8]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			object obj26;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v102+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj21 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v96+A0]");
					obj18 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86C8]");
				object obj23 = 0;
				predicate2._002Ector(obj18, (IntPtr)obj23);
				object obj24 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v95+A0]");
				object obj25 = (nint)0 + (nint)8;
				obj25 = predicate2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
				action = (Action<System.__Canon>)0;
				predicate = predicate2;
				obj26 = 0;
			}
			TaskScheduler taskScheduler = (TaskScheduler)obj4;
			Task task;
			if (list.Exists(predicate))
			{
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v134+E4]");
				bool flag6 = (nint)0 == 0;
				object obj28 = !flag6;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v134+A0]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v87+18]");
				System.__Canon _Canon2 = ((Queue<System.__Canon>)0).Dequeue();
				object obj30 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v88+10]");
				int num = Interlocked.Decrement(ref *(int*)((nint)0 + (nint)36));
				task = null;
				continue;
			}
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v106+E4]");
			bool flag7 = (nint)0 == 0;
			object obj32 = !flag7;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = Read((Job)obj14, ref readOne);
			bool flag9 = !flag8;
			task = (Task)(&readOne);
			if (flag9)
			{
				break;
			}
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v111+E4]");
			bool flag10 = (nint)0 == 0;
			object obj34 = !flag10;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v111+A0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v69+18]");
			System.__Canon _Canon3 = ((Queue<System.__Canon>)0).Dequeue();
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v70+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8670]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86D0]");
			object obj39 = 0;
			action2._002Ector(obj10, (IntPtr)obj39);
			nint num2 = (nint)action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v116 (Il2CppClass<System.Action`1<System.__Canon>>)+E4]");
			bool flag11 = (nint)0 == 0;
			object obj40 = !flag11;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num3 = (nint)action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v119 (Il2CppClass<System.Action`1<System.__Canon>>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj41 = !flag12;
			nint num4 = num3;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num4 = (nint)action;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v120 (Il2CppClass<System.Action`1<System.__Canon>>)+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v81+8]");
			taskScheduler = (TaskScheduler)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v71+30]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v81+8]");
			Task task2 = ((Task)num5).ContinueWith((Action<Task>)action2, (TaskScheduler)0);
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v82+A0]");
			object obj44 = (nint)0 + (nint)48;
			obj44 = task2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj26 = 0;
			list = (List<System.__Canon>)(object)action2;
			task = task2;
		}
		float unscaledTime = Time.unscaledTime;
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v10+E4]");
		bool flag13 = (nint)0 == 0;
		object obj46 = !flag13;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj45 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8698]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86E8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v10+A0]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v12+18]");
		int num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v12+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		float num7 = unscaledTime + 0.25f;
		object obj52 = 0;
		double num8 = 0.25;
		object obj57 = default;
		Action<System.__Canon> action3 = default;
		bool flag36;
		do
		{
			object obj53 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v14+E4]");
			bool flag14 = (nint)0 == 0;
			object obj54 = !flag14;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v14+A0]");
			object obj55 = 0;
			TaskScheduler taskScheduler = (TaskScheduler)obj47;
			num6--;
			System.__Canon _Canon4 = ((List<System.__Canon>)obj55).get_Item(num6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+20]");
			object obj56;
			int num9;
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+29]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+29]");
				bool flag15 = (nint)0 == 0;
				obj56 = predicate;
				Task task3 = (Task)(object)list;
				num9 = num6;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+2C]");
					num8 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+2C]");
					bool flag16 = unscaledTime < 0f;
					obj56 = predicate;
					task3 = (Task)(object)list;
					num9 = num6;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj57._002Ector();
						object obj58 = obj57 + 16;
						obj58 = _Canon4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int num10 = Interlocked.Increment(ref *(int*)(obj58 + 36));
						object obj59 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v69+E4]");
						bool flag17 = (nint)0 == 0;
						object obj60 = !flag17;
						if (obj60 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj59 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v69+A0]");
						object obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v45+30]");
						task3 = (Task)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8670]");
						object obj62 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86E0]");
						object obj63 = 0;
						action3._002Ector(obj57, (IntPtr)obj63);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
						object obj64 = 0;
						object obj65 = obj64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v72+E4]");
						bool flag18 = (nint)0 == 0;
						object obj66 = !flag18;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
						obj5 = 0;
						object obj67 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v76+E4]");
						bool flag19 = (nint)0 == 0;
						object obj68 = !flag19;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj67 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v76+A0]");
						object obj69 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v57+8]");
						taskScheduler = (TaskScheduler)0;
						Task task4 = task3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v57+8]");
						Task task5 = task4.ContinueWith((Action<Task>)action3, (TaskScheduler)0);
						object obj70 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v58+A0]");
						object obj71 = (nint)0 + (nint)48;
						obj71 = task5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj56 = obj57;
						object obj26 = 0;
						num9 = (int)task5;
					}
				}
				object obj72 = obj52 & 1;
				bool flag20 = obj72 == null;
				object obj73 = !flag20;
				list = (List<System.__Canon>)(object)task3;
				if (obj73 != null)
				{
					goto IL_0999;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+28]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+28]");
				bool flag21 = (nint)0 == 0;
				list = (List<System.__Canon>)(object)task3;
				if (!flag21)
				{
					object obj74 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v53+E4]");
					bool flag22 = (nint)0 == 0;
					object obj75 = !flag22;
					if (obj75 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
					bool flag23 = (UnityEngine.Object)0 != null;
					bool flag24 = !flag23;
					taskScheduler = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
					list = (List<System.__Canon>)0;
					num9 = 0;
					if (!flag24)
					{
						object obj76 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v57+E4]");
						bool flag25 = (nint)0 == 0;
						object obj77 = !flag25;
						if (obj77 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Send((Sheet)(object)_Canon4);
						taskScheduler = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
						list = (List<System.__Canon>)0;
						num9 = 0;
						goto IL_0999;
					}
				}
				obj52 = 0;
				predicate = (Predicate<System.__Canon>)obj56;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+24]");
				bool flag26 = (nint)0 > (nint)0;
				num9 = num6;
				if (!flag26)
				{
					object obj78 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v19+E4]");
					bool flag27 = (nint)0 == 0;
					object obj79 = !flag27;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj78 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v19+A0]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8688]");
					object obj81 = 0;
					((List<System.__Canon>)obj80).RemoveAt(num6);
					object obj82 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v21+E4]");
					bool flag28 = (nint)0 == 0;
					object obj83 = !flag28;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
					bool flag29 = (UnityEngine.Object)0 == null;
					bool flag30 = !flag29;
					object obj84 = !flag30;
					taskScheduler = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
					list = (List<System.__Canon>)0;
					num9 = 0;
					if (obj84 == null)
					{
						object obj85 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v26+E4]");
						bool flag31 = (nint)0 == 0;
						object obj86 = !flag31;
						if (obj86 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj85 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v26+A0]");
						object obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27+8]");
						object obj88 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X9_v7+18]");
						if ((nint)0 < (nint)4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+18]");
							Array array = (Array)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+18]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v35 (System.Array)+18]");
							Array.Clear((Array)num11, 0, 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							object obj89 = obj;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v39+E4]");
							bool flag32 = (nint)0 == 0;
							object obj90 = !flag32;
							if (obj90 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj89 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v39+A0]");
							object obj91 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86C0]");
							object obj92 = 0;
							taskScheduler = (TaskScheduler)obj92;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v35+8]");
							((Stack<System.__Canon>)0).Push(_Canon4);
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
							list = (List<System.__Canon>)0;
							num9 = (int)_Canon4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v26+E4]");
							bool flag33 = (nint)0 == 0;
							object obj93 = !flag33;
							if (obj93 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj94 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v31+A0]");
								obj87 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8678]");
							object obj95 = 0;
							taskScheduler = (TaskScheduler)obj95;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27+10]");
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
							bool flag34 = ((Dictionary<System.__Canon, System.__Canon>)num12).Remove((System.__Canon)0);
							object obj96 = obj48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X0_v30+E4]");
							bool flag35 = (nint)0 == 0;
							object obj97 = !flag35;
							if (obj97 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
							UnityEngine.Object.Destroy((UnityEngine.Object)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v16 (System.__Canon)+10]");
							list = (List<System.__Canon>)0;
							num9 = 0;
						}
					}
				}
			}
			goto IL_10ad;
			IL_10ad:
			flag36 = num6 > 0;
			Task task = (Task)num9;
			continue;
			IL_0999:
			obj52 = 1;
			predicate = (Predicate<System.__Canon>)obj56;
			goto IL_10ad;
		}
		while (flag36);
	}

	public unsafe static void Send(Sheet s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ff: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I
		//IL_0027: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I4
		//IL_0042: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got Ref
		//IL_029b: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_01a1: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4 (System.IntPtr)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num = (nint)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4 (System.IntPtr)+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+40]");
		nint num2 = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+40]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			num2 = unchecked((nint)null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+40]");
			num = 0;
		}
		object obj4;
		OutOfMemoryException ex;
		bool flag5;
		if (s != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			s.changed = false;
			bool flag2 = (object)s.map == null;
			obj4 = 0;
			ex = null;
			if (flag2)
			{
				goto IL_023d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8658]");
			object obj5 = 0;
			num2 = (nint)s.pixels;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378DC98");
			bool flag3 = (object)s.map == null;
			object obj6 = 0;
			bool flag4 = false;
			obj4 = 0;
			ex = null;
			if (!flag3)
			{
				s.map.Apply(updateMipmaps: false, makeNoLongerReadable: false);
				obj6 = 0;
				flag4 = false;
				obj4 = 0;
				ex = null;
				flag5 = false;
				goto IL_016b;
			}
			goto IL_024b;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj4 = 0;
		ex = null;
		goto IL_0220;
		IL_0220:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_022e;
		IL_024b:
		NullReferenceException ex4 = new NullReferenceException();
		if (num2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
			flag5 = (byte)num2 != 0;
		}
		else
		{
			if (num2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj7 = default;
			ex = (OutOfMemoryException)obj7;
			flag5 = (byte)num2 != 0;
		}
		goto IL_016b;
		IL_016b:
		object obj9 = default;
		object obj8 = (object)(&obj9);
		bool flag6 = obj8 == null;
		num2 = (flag5 ? 1 : 0);
		if (!flag6)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj8);
			num2 = unchecked((nint)null);
		}
		bool flag7 = ex == null;
		object obj10 = !flag7;
		if (obj10 != null)
		{
			goto IL_0220;
		}
		bool flag8 = obj4 == null;
		object obj11 = !flag8;
		ex3 = ex;
		if (obj11 == null)
		{
			return;
		}
		goto IL_022e;
		IL_022e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_023d;
		IL_023d:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_024b;
	}

	public static void Finish()
	{
		//IL_00fc: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = 16;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+20]");
			if ((nint)0 <= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Pump();
			obj2--;
			if ((nint)obj2 == 1)
			{
				obj3 = obj;
				break;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v8+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11+30]");
		((Task)0).Wait();
	}

	private unsafe static bool Read(Job j, ref bool readOne)
	{
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got I4
		//IL_1148: Expected Obj, but got I4
		//IL_1151: Expected Obj, but got I4
		//IL_115a: Expected Obj, but got I4
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_1597: Expected Obj, but got I
		//IL_159f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a8: Expected Ref, but got Unknown
		//IL_15c2: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Ref, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_1189: Expected Obj, but got I4
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_1191: Expected Obj, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected I4, but got Unknown
		//IL_1398: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_1221: Expected Obj, but got I4
		//IL_122a: Expected Obj, but got I4
		//IL_122a: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_13c5: Expected I, but got Obj
		//IL_13e7: Expected Obj, but got I4
		//IL_129e: Expected Obj, but got I4
		//IL_12a7: Expected Obj, but got I4
		//IL_15e0: Expected Obj, but got I
		//IL_01fb: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_12fe: Expected Obj, but got I4
		//IL_0397: Expected I, but got Obj
		//IL_1434: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_0245: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_0447: Expected I, but got Obj
		//IL_0469: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0370: Expected I, but got Obj
		//IL_0380: Expected Obj, but got I
		//IL_1452: Expected Obj, but got I
		//IL_0491: Expected I, but got Obj
		//IL_0d04: Expected Obj, but got Ref
		//IL_0d15: Expected Obj, but got I4
		//IL_0d1e: Expected Obj, but got I4
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I
		//IL_051f: Expected Obj, but got I
		//IL_0527: Expected I, but got Obj
		//IL_0d4e: Expected Obj, but got Ref
		//IL_0d57: Expected Obj, but got I4
		//IL_0d60: Expected Obj, but got I4
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I
		//IL_0583: Expected I, but got Obj
		//IL_0d98: Expected Obj, but got Ref
		//IL_0da1: Expected Obj, but got I4
		//IL_0daa: Expected Obj, but got I4
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got I
		//IL_0de2: Expected Obj, but got Ref
		//IL_0deb: Expected Obj, but got I4
		//IL_0df4: Expected Obj, but got I4
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected Obj, but got Ref
		//IL_0e32: Expected Obj, but got I4
		//IL_0e3b: Expected Obj, but got I4
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Invalid comparison between Obj and Unknown
		//IL_1498: Expected Obj, but got I4
		//IL_0e70: Expected Obj, but got Ref
		//IL_0e79: Expected Obj, but got I4
		//IL_0e82: Expected Obj, but got I4
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected Obj, but got Ref
		//IL_0c84: Expected Obj, but got I4
		//IL_0c8d: Expected Obj, but got I4
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected Obj, but got Ref
		//IL_0ff5: Expected Obj, but got I4
		//IL_0ffe: Expected Obj, but got I4
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got I
		//IL_07f0: Expected Obj, but got I
		//IL_1106: Expected Obj, but got Ref
		//IL_110f: Expected Obj, but got I4
		//IL_1118: Expected Obj, but got I4
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got I
		//IL_102e: Expected Obj, but got Ref
		//IL_1037: Expected Obj, but got I4
		//IL_1040: Expected Obj, but got I4
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b6: Expected Obj, but got I
		//IL_14e0: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I4
		//IL_161d: Expected Obj, but got I
		//IL_162d: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_0eb7: Expected Obj, but got Ref
		//IL_0ec0: Expected Obj, but got I4
		//IL_0ec9: Expected Obj, but got I4
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got I
		//IL_0850: Expected Obj, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I8
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected Obj, but got I
		//IL_1078: Expected Obj, but got Ref
		//IL_1081: Expected Obj, but got I4
		//IL_108a: Expected Obj, but got I4
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efe: Expected Obj, but got Ref
		//IL_0f07: Expected Obj, but got I4
		//IL_0f10: Expected Obj, but got I4
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected Obj, but got Ref
		//IL_0ccb: Expected Obj, but got I4
		//IL_0cd4: Expected Obj, but got I4
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected Obj, but got Unknown
		//IL_10c3: Expected Obj, but got Ref
		//IL_10cc: Expected Obj, but got I4
		//IL_10d5: Expected Obj, but got I4
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Ref
		//IL_0f51: Expected Obj, but got I4
		//IL_0f5a: Expected Obj, but got I4
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected Obj, but got I
		//IL_092d: Expected Obj, but got I
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got I
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Expected Obj, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected Obj, but got Unknown
		//IL_0b31: Expected Obj, but got I
		//IL_0f8f: Expected Obj, but got I
		//IL_0fa2: Expected Obj, but got Ref
		//IL_0fab: Expected Obj, but got I4
		//IL_0fb4: Expected Obj, but got I4
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected Obj, but got I
		//IL_0b8d: Expected Obj, but got I
		//IL_0ba6: Expected Obj, but got I
		//IL_0bae: Expected Obj, but got Ref
		//IL_0bf0: Expected Obj, but got Ref
		//IL_0c08: Expected I, but got Obj
		//IL_0bdc: Expected I, but got Obj
		bool flag = j == null;
		nint num = 0;
		int num2 = 0;
		System.__Canon value = null;
		object obj2 = default;
		object obj = obj2;
		Enumerator<, > val = (Enumerator<, >)0;
		ref bool reference2 = default;
		ref bool reference = ref reference2;
		if (!flag)
		{
			bool flag2 = j.pieces == null;
			num = 0;
			num2 = 0;
			value = null;
			obj = obj2;
			val = (Enumerator<, >)0;
			reference = ref reference2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
				int[] array = (int[])0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)j.pieces).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num = 0;
				num2 = 0;
				value = null;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = val3;
				object obj4 = 1132462080;
				reference = ref reference2;
				string text;
				HashSet<int> hashSet = default;
				int[] array3 = default;
				object obj27 = default;
				Matrix4x4[] array4 = default;
				BoneWeight[] array6 = default;
				object obj44 = default;
				object obj56 = default;
				bool result = default;
				object obj29;
				Enumerator<, > val6;
				while (true)
				{
					text = (string)obj3;
					bool flag3 = val.MoveNext();
					if (!flag3)
					{
						goto IL_113a;
					}
					ref bool reference4;
					int[] triangles;
					Vector2[] uv;
					BoneWeight[] array2;
					if (obj2 != null)
					{
						ref System.__Canon reference3 = ref *(System.__Canon*)(obj2 + 32);
						bool flag4 = reference3 == null;
						object obj5 = !flag4;
						if (obj5 != null)
						{
							continue;
						}
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v46 (Il2CppClass<System.Int32[]>)+E4]");
						bool flag5 = (nint)0 == 0;
						object obj6 = !flag5;
						nint num4 = num3;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num4 = (nint)array;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v47 (Il2CppClass<System.Int32[]>)+A0]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v26+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							System.__Canon _Canon = (System.__Canon)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8708]");
							object obj8 = 0;
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v26+28]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							bool flag6 = ((Dictionary<System.__Canon, System.__Canon>)num5).TryGetValue((System.__Canon)0, out value);
							bool flag7 = !flag6;
							object obj10 = !flag7;
							nint num6 = (nint)(&value);
							if (obj10 == null)
							{
								nint num7 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v143 (Il2CppClass<System.Int32[]>)+E4]");
								bool flag8 = (nint)0 == 0;
								object obj11 = !flag8;
								nint num8 = num7;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									num8 = (nint)array;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								bool flag9 = (nint)0 == 0;
								num6 = (nint)(&value);
								text = (string)(object)_Canon;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								array = (int[])0;
								if (flag9)
								{
									goto IL_11ea;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v144 (Il2CppClass<System.Int32[]>)+A0]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								int vertexCount = ((Mesh)0).vertexCount;
								string text2 = num2.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+18]");
								string text3 = (string)0 + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v83+28]");
								bool flag10 = (nint)0 == 0;
								num2 = vertexCount;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+18]");
								array2 = (BoneWeight[])0;
								value = (System.__Canon)(object)text3;
								num6 = (nint)text3;
								text = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								array = (int[])0;
								if (flag10)
								{
									goto IL_11dc;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8710]");
								object obj13 = 0;
								obj9 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v83+28]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								((Dictionary<System.__Canon, System.__Canon>)num9).set_Item((System.__Canon)0, (System.__Canon)(object)text3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
								array = (int[])0;
								num2 = vertexCount;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+18]");
								array2 = (BoneWeight[])0;
								value = (System.__Canon)(object)text3;
								num6 = (nint)text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								_Canon = (System.__Canon)0;
							}
							nint num10 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v51 (Il2CppClass<System.Int32[]>)+E4]");
							bool flag11 = (nint)0 == 0;
							object obj14 = !flag11;
							nint num11 = num10;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num11 = (nint)array;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X0_v52 (Il2CppClass<System.Int32[]>)+A0]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v31+20]");
							bool flag12 = (nint)0 == 0;
							text = (string)(object)_Canon;
							if (flag12)
							{
								goto IL_11ce;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8700]");
							object obj16 = 0;
							obj9 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v31+20]");
							bool flag13 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue(value, out reference3);
							bool flag14 = !flag13;
							object obj17 = !flag14;
							num6 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
							if (obj17 != null)
							{
								continue;
							}
							bool flag15 = !reference;
							object obj18 = !flag15;
							num6 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
							if (obj18 != null)
							{
								goto IL_113a;
							}
							reference = ref *(bool*)1;
							nint num12 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X0_v55 (Il2CppClass<System.Int32[]>)+E4]");
							bool flag16 = (nint)0 == 0;
							object obj19 = !flag16;
							nint num13 = num12;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num13 = (nint)array;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v56 (Il2CppClass<System.Int32[]>)+A0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v37+48]");
							bool flag17 = (nint)0 == 0;
							reference4 = ref *(bool*)value;
							if (!flag17)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v37+48]");
								ProfilerUnsafeUtility.BeginSample((IntPtr)0);
								reference4 = ref *(bool*)null;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								triangles = ((Mesh)0).GetTriangles(0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8740]");
								object obj22 = 0;
								num6 = (nint)obj22;
								hashSet._002Ector((IEnumerable<int>)triangles);
								if (hashSet != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8738]");
									object obj24 = 0;
									num6 = (nint)obj24;
									hashSet.CopyTo(array3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
										uv = ((Mesh)0).uv;
										if (uv != null)
										{
											if (uv.Length < 1)
											{
												goto IL_069d;
											}
											obj4 = uv + 32;
											Enumerator<, > val4 = (Enumerator<, >)(uv.Length & 0xFFFFFFFFL);
											Enumerator<, > val5 = val2;
											object obj25 = 0;
											while (true)
											{
												bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<Enumerator<, >, UIntPtr>(ref val4);
												object obj26 = !flag18;
												if (obj26 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X9_v12+v567 @ X8_v80*8]");
												val2 = (Enumerator<, >)(0 * obj27);
												obj25++;
												bool flag19 = (nint)obj25 < uv.Length;
												val4 = (Enumerator<, >)uv.Length;
												val5 = val2;
												if (flag19)
												{
													continue;
												}
												goto IL_069d;
											}
											IndexOutOfRangeException ex = new IndexOutOfRangeException();
											object obj28 = (object)(&num);
											obj = 0;
											obj29 = 0;
											val = val3;
											val2 = val5;
											val6 = (Enumerator<, >)(ref val);
											reference4 = ref *(bool*)null;
										}
										else
										{
											NullReferenceException ex2 = new NullReferenceException();
											object obj28 = (object)(&num);
											obj = 0;
											obj29 = 0;
											val = val3;
											val6 = (Enumerator<, >)(ref val);
											reference4 = ref *(bool*)null;
											IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex2;
										}
									}
									else
									{
										NullReferenceException ex3 = new NullReferenceException();
										object obj28 = (object)(&num);
										obj = 0;
										obj29 = 0;
										val = val3;
										val6 = (Enumerator<, >)(ref val);
										reference4 = ref *(bool*)array3;
										IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex3;
									}
								}
								else
								{
									NullReferenceException ex4 = new NullReferenceException();
									object obj28 = (object)(&num);
									obj = 0;
									obj29 = 0;
									val = val3;
									val6 = (Enumerator<, >)(ref val);
									reference4 = ref *(bool*)triangles;
									IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex4;
								}
							}
							else
							{
								NullReferenceException ex5 = new NullReferenceException();
								object obj28 = (object)(&num);
								num6 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
								obj = 0;
								obj29 = 0;
								val = val3;
								val6 = (Enumerator<, >)(ref val);
								IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex5;
							}
							goto IL_1528;
						}
					}
					else
					{
						NullReferenceException ex6 = new NullReferenceException();
					}
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_11ce;
					IL_08c7:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Matrix4x4[] array5;
					object obj34;
					if (array4 != null)
					{
						if (array4.Length != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
							object obj31 = 0;
							object obj32 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v73+A0]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v74+70]");
							val2 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v74+60]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v74+70]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v74+40]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v74+50]");
							_ = 0;
							array5 = array4;
							array2 = array6;
							obj4 = obj34;
							ref bool reference5 = ref *(bool*)1;
							goto IL_14a6;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						object obj28 = (object)(&num);
						obj = 0;
						obj29 = 0;
						val = val3;
						val6 = (Enumerator<, >)(ref val);
						reference4 = ref *(bool*)1;
					}
					else
					{
						NullReferenceException ex8 = new NullReferenceException();
						object obj28 = (object)(&num);
						obj = 0;
						obj29 = 0;
						val = val3;
						val6 = (Enumerator<, >)(ref val);
						reference4 = ref *(bool*)1;
						IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex8;
					}
					goto IL_1528;
					IL_11ea:
					NullReferenceException ex9 = new NullReferenceException();
					break;
					IL_11ce:
					NullReferenceException ex10 = new NullReferenceException();
					goto IL_11dc;
					IL_069d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
						BoneWeight[] boneWeights = ((Mesh)0).boneWeights;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							Matrix4x4[] bindposes = ((Mesh)0).bindposes;
							bool flag20 = boneWeights == null;
							reference4 = ref *(bool*)null;
							if (!flag20)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								if ((nint)0 == 0)
								{
									NullReferenceException ex11 = new NullReferenceException();
									object obj28 = (object)(&num);
									obj = 0;
									obj29 = 0;
									val = val3;
									val6 = (Enumerator<, >)(ref val);
									reference4 = ref *(bool*)null;
									IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex11;
									goto IL_1528;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								int vertexCount2 = ((Mesh)0).vertexCount;
								bool flag21 = vertexCount2 == boneWeights.Length;
								reference4 = ref *(bool*)null;
								array5 = bindposes;
								array2 = boneWeights;
								ref bool reference5 = ref *(bool*)null;
								if (flag21)
								{
									goto IL_14a6;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								int vertexCount3 = ((Mesh)0).vertexCount;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F8]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								if (array6 != null)
								{
									obj34 = array6.Length;
									if (array6.Length < 1)
									{
										goto IL_08c7;
									}
									object obj36 = ~array6.Length;
									object obj37 = array6.Length & obj36;
									obj4 = array6.Length & 0xFFFFFFFFL;
									Enumerator<, > val7 = (Enumerator<, >)(array6 + 32);
									while (obj4 != null)
									{
										obj34 = obj4 - 1;
										val7 = (Enumerator<, >)1065353216;
										bool flag22 = (nint)obj37 != 1;
										obj4 = obj34;
										if (flag22)
										{
											continue;
										}
										goto IL_08c7;
									}
									IndexOutOfRangeException ex = new IndexOutOfRangeException();
									object obj28 = (object)(&num);
									obj = 0;
									obj29 = 0;
									val = val3;
									val6 = (Enumerator<, >)(ref val);
									reference4 = ref *(bool*)vertexCount3;
								}
								else
								{
									NullReferenceException ex12 = new NullReferenceException();
									object obj28 = (object)(&num);
									obj = 0;
									obj29 = 0;
									val = val3;
									val6 = (Enumerator<, >)(ref val);
									reference4 = ref *(bool*)vertexCount3;
									IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex12;
								}
							}
							else
							{
								NullReferenceException ex13 = new NullReferenceException();
								object obj28 = (object)(&num);
								obj = 0;
								obj29 = 0;
								val = val3;
								val6 = (Enumerator<, >)(ref val);
								IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex13;
							}
						}
						else
						{
							NullReferenceException ex14 = new NullReferenceException();
							object obj28 = (object)(&num);
							obj = 0;
							obj29 = 0;
							val = val3;
							val6 = (Enumerator<, >)(ref val);
							reference4 = ref *(bool*)null;
							IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex14;
						}
					}
					else
					{
						NullReferenceException ex15 = new NullReferenceException();
						object obj28 = (object)(&num);
						obj = 0;
						obj29 = 0;
						val = val3;
						val6 = (Enumerator<, >)(ref val);
						reference4 = ref *(bool*)null;
						IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex15;
					}
					goto IL_1528;
					IL_14a6:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					object obj38 = 0;
					object obj39 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X0_v79+E4]");
					bool flag23 = (nint)0 == 0;
					object obj40 = !flag23;
					if (obj40 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
						object obj41 = 0;
						obj39 = obj41;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X0_v79+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8750]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj44._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
						Vector3[] vertices = ((Mesh)0).vertices;
						if (obj44 != null)
						{
							object obj45 = obj44 + 16;
							obj45 = vertices;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-A8+10]");
								Vector3[] normals = ((Mesh)0).normals;
								object obj46 = obj44 + 24;
								obj46 = normals;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj47 = obj44 + 32;
								obj47 = uv;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj48 = obj44 + 40;
								obj48 = array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj49 = obj44 + 48;
								obj49 = array5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj50 = obj44 + 56;
								obj50 = triangles;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj51 = obj44 + 64;
								obj51 = array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								ref System.__Canon reference3 = ref *(System.__Canon*)obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
								array = (int[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X8_v53+20]");
								object obj28;
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8718]");
									object obj52 = 0;
									object obj9 = obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X8_v53+20]");
									((Dictionary<System.__Canon, System.__Canon>)0).set_Item(value, (System.__Canon)obj44);
									object obj53 = (object)(&num);
									bool flag24 = obj53 == null;
									text = (string)(object)value;
									if (!flag24)
									{
										ProfilerUnsafeUtility.EndSample((IntPtr)obj53);
										text = null;
									}
									obj28 = (object)(&num);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v37+48]");
									num = 0;
									nint num6 = (nint)obj44;
									reference = ref reference2;
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
								obj3 = 0;
								NullReferenceException ex16 = new NullReferenceException();
								obj28 = (object)(&num);
								obj = 0;
								obj29 = 0;
								val = val3;
								val6 = (Enumerator<, >)(ref val);
								reference4 = ref *(bool*)obj44;
								IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex16;
							}
							else
							{
								NullReferenceException ex17 = new NullReferenceException();
								object obj28 = (object)(&num);
								obj = 0;
								obj29 = 0;
								val = val3;
								val6 = (Enumerator<, >)(ref val);
								reference4 = ref *(bool*)vertices;
								IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex17;
							}
						}
						else
						{
							NullReferenceException ex18 = new NullReferenceException();
							object obj28 = (object)(&num);
							obj = 0;
							obj29 = 0;
							val = val3;
							val6 = (Enumerator<, >)(ref val);
							reference4 = ref *(bool*)vertices;
							IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex18;
						}
					}
					else
					{
						NullReferenceException ex19 = new NullReferenceException();
						object obj28 = (object)(&num);
						obj = 0;
						obj29 = 0;
						val = val3;
						val6 = (Enumerator<, >)(ref val);
						reference4 = ref *(bool*)null;
						IndexOutOfRangeException ex = (IndexOutOfRangeException)(object)ex19;
					}
					goto IL_1528;
					IL_11dc:
					NullReferenceException ex20 = new NullReferenceException();
					goto IL_11ea;
					IL_1528:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
					object obj54;
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) == (void*)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj = 1;
						obj54 = 1;
						goto IL_1557;
					}
					object obj55;
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) == (void*)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj55 = obj56;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj29 = obj56;
						obj54 = 1;
						goto IL_1587;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E970");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
					IL_1587:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8720]");
					object obj57 = 0;
					reference2 = ref *(bool*)obj57;
					((Enumerator<, >*)val6)->Dispose();
					bool flag25 = obj55 == null;
					object obj58 = !flag25;
					if (obj58 == null)
					{
						bool flag26 = obj == null;
						object obj59 = !flag26;
						OutOfMemoryException ex21 = (OutOfMemoryException)val6;
						if (obj59 == null)
						{
							return (byte)(obj54 & 1) != 0;
						}
					}
					else
					{
						OutOfMemoryException ex21 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					reference4 = ref reference2;
					goto IL_1528;
					IL_113a:
					obj54 = (flag3 ? 1 : 0) ^ 1;
					obj = 0;
					obj29 = 0;
					val = val3;
					val6 = (Enumerator<, >)(ref val);
					goto IL_1557;
					IL_1557:
					obj55 = obj29;
					goto IL_1587;
				}
				OutOfMemoryException ex22 = new OutOfMemoryException();
				ref bool reference6 = ref *(bool*)text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				obj = 0;
				obj29 = 0;
				val = val3;
				val6 = (Enumerator<, >)(ref val);
				reference2 = ref reference6;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static void Work(Job j)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0853: Expected Obj, but got I4
		//IL_0948: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got Ref
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_004a: Expected I, but got Obj
		//IL_00d0: Invalid comparison between F4 and I4
		//IL_0242: Expected Obj, but got Ref
		//IL_0250: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got Ref
		//IL_02a7: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_02d0: Expected I, but got Obj
		//IL_02d5: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got Ref
		//IL_01e7: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_05a4: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got Ref
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0775: Expected Obj, but got I4
		//IL_073e: Expected Obj, but got I4
		//IL_065d: Expected Obj, but got Ref
		//IL_0409: Expected Obj, but got I4
		//IL_040e: Expected I, but got Obj
		//IL_069d: Expected Obj, but got I4
		//IL_0700: Expected I, but got Obj
		//IL_0436: Expected Obj, but got I4
		//IL_047b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+50]");
		nint num = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+50]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			obj2 = obj;
			num = unchecked((nint)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		Stuff stuff = (Stuff)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Job job = default;
		Paint(job);
		bool flag3 = job == null;
		IntPtr intPtr = default;
		object obj6 = (object)(&intPtr);
		OutOfMemoryException ex = null;
		object obj7 = 0;
		object obj8 = 0;
		object obj9 = 0;
		object obj10 = 0;
		if (flag3)
		{
			goto IL_04f6;
		}
		float num2 = job.radius;
		bool flag4 = !(job.radius > 0f);
		Job job2 = job;
		Job job3 = job;
		Stuff stuff2;
		if (!flag4)
		{
			stuff = job.stuff;
			bool flag5 = job.stuff != (Stuff)1;
			job2 = job;
			job3 = job;
			if (!flag5)
			{
				Sheet sheet = job.sheet;
				bool flag6 = job.sheet == null;
				obj6 = (object)(&intPtr);
				ex = null;
				obj7 = 0;
				obj8 = 0;
				obj9 = 0;
				obj10 = 0;
				if (flag6)
				{
					goto IL_053e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				sheet.egg = true;
				bool flag7 = job == null;
				stuff = (Stuff)1;
				job3 = job;
				obj6 = (object)(&intPtr);
				ex = null;
				obj7 = 0;
				obj8 = 0;
				obj9 = 0;
				obj10 = 0;
				stuff2 = (Stuff)1;
				if (flag7)
				{
					goto IL_0554;
				}
			}
		}
		Sheet sheet2 = job3.sheet;
		bool flag8 = job3.sheet == null;
		obj6 = (object)(&intPtr);
		ex = null;
		obj7 = 0;
		obj8 = 0;
		obj9 = 0;
		obj10 = 0;
		if (flag8)
		{
			goto IL_0530;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		sheet2.changed = true;
		obj6 = (object)(&intPtr);
		ex = null;
		obj7 = 0;
		obj8 = 0;
		obj9 = 0;
		obj10 = 0;
		goto IL_08c9;
		IL_04f6:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0504;
		IL_0521:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0530;
		IL_0504:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0512;
		IL_08c9:
		if (obj6 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj6);
			num = unchecked((nint)null);
		}
		bool flag9 = obj9 == null;
		object obj11 = !flag9;
		if (obj11 != null)
		{
			goto IL_0504;
		}
		bool flag10 = obj10 == null;
		object obj12 = !flag10;
		OutOfMemoryException ex4 = ex;
		object obj13 = obj7;
		object obj15 = default;
		object obj14 = obj15;
		object obj16 = obj8;
		object obj17 = obj9;
		object obj18 = obj10;
		stuff2 = stuff;
		float num3 = num2;
		nint num4 = num;
		object obj19 = obj9;
		if (obj12 == null)
		{
			goto IL_037a;
		}
		goto IL_0521;
		IL_0554:
		NullReferenceException ex5 = new NullReferenceException();
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = 1;
			stuff = stuff2;
		}
		else
		{
			if (num != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				bool flag11 = num != 2;
				NullReferenceException ex6 = ex5;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj21 = default;
					object obj20 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj23 = default;
					object obj22 = obj23 & 1;
					if (obj22 != null)
					{
						object obj25 = default;
						object obj24 = (object)(&obj25);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v38+E4]");
						bool flag12 = (nint)0 == 0;
						object obj26 = !flag12;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogException((Exception)obj21);
						ex4 = ex;
						obj13 = obj7;
						obj14 = obj15;
						obj16 = obj8;
						obj17 = obj9;
						obj18 = obj10;
						num3 = num2;
						num4 = unchecked((nint)null);
						goto IL_037a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj27 = obj21;
					num = 101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					obj15 = 0;
					NullReferenceException ex7 = default;
					ex6 = ex7;
				}
				if (num == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex4 = ex;
					obj13 = 1;
					obj14 = obj15;
					obj16 = obj8;
					obj17 = obj9;
					obj18 = obj10;
					num3 = num2;
					num4 = num;
				}
				else
				{
					if (num != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E9AC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj28 = default;
					ex4 = (OutOfMemoryException)obj28;
					obj13 = obj7;
					obj14 = obj15;
					obj16 = obj8;
					obj17 = obj9;
					obj18 = obj10;
					num3 = num2;
					num4 = num;
				}
				goto IL_037a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj29 = default;
			obj9 = obj29;
			stuff = stuff2;
		}
		goto IL_08c9;
		IL_0530:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_053e;
		IL_037a:
		object obj30 = (object)(&job);
		object obj31 = obj30;
		if (obj30 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v30+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v30+10]");
				int num5 = Interlocked.Decrement(ref *(int*)((nint)0 + (nint)36));
				bool flag13 = ex4 == null;
				object obj32 = !flag13;
				num4 = unchecked((nint)null);
				if (obj32 != null)
				{
					goto IL_04a0;
				}
				bool flag14 = obj13 == null;
				object obj33 = !flag14;
				ex = ex4;
				obj7 = obj13;
				obj15 = obj14;
				obj8 = obj16;
				obj9 = obj17;
				obj10 = obj18;
				stuff = stuff2;
				num2 = num3;
				num = unchecked((nint)null);
				ex3 = ex4;
				if (obj33 == null)
				{
					return;
				}
				goto IL_0512;
			}
		}
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_04a0;
		IL_053e:
		NullReferenceException ex10 = new NullReferenceException();
		stuff2 = stuff;
		goto IL_0554;
		IL_0512:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0521;
		IL_04a0:
		OutOfMemoryException ex11 = new OutOfMemoryException();
		ex = ex4;
		obj7 = obj13;
		obj15 = obj14;
		obj8 = obj16;
		obj9 = obj17;
		obj10 = obj18;
		stuff = stuff2;
		num2 = num3;
		num = num4;
		goto IL_04f6;
	}

	private unsafe static void Fade(Sheet s)
	{
		//IL_0402: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_0622: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_059d: Expected Obj, but got I4
		//IL_05ae: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got Ref
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Ref, but got Unknown
		//IL_0375: Expected Obj, but got I4
		//IL_037a: Expected I, but got Obj
		//IL_0192: Expected Obj, but got F4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_03a7: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got F4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I4
		if (s == null)
		{
			goto IL_03f0;
		}
		byte[] pixels = s.pixels;
		float num = s.fadeOver + 1.0764943E+09f;
		float fadeOver = num - num;
		s.fadeOver = fadeOver;
		bool flag = s.pixels == null;
		float num2 = num;
		object obj = 0;
		OutOfMemoryException ex = null;
		if (flag)
		{
			goto IL_041a;
		}
		object obj2 = pixels.Length;
		object obj4;
		if (pixels.Length >= 2)
		{
			object obj3 = 1;
			obj4 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
				object obj5 = !flag2;
				if (obj5 == null)
				{
					object obj6 = obj3 + 1;
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj7 = !flag3;
					if (obj7 == null)
					{
						object obj8 = (object)s.pixels + obj3;
						object obj9 = (object)s.pixels + obj6;
						object obj10 = obj8 + 32;
						object obj11 = obj10;
						obj2 = obj9 + 32;
						object obj12 = obj2 | obj10;
						if (obj12 != null)
						{
							float num3 = (float)obj10 - num;
							object obj13 = ~num3;
							obj11 = num3 & obj13;
							obj10 = obj11;
							obj10 = pixels.Length;
							bool flag4 = (nint)obj6 < pixels.Length;
							object obj14 = !flag4;
							if (obj14 != null)
							{
								goto IL_03da;
							}
							float num4 = (float)obj2 - num;
							object obj15 = ~num4;
							obj6 = num4 & obj15;
							obj2 = obj6;
							obj4 = 1;
						}
						obj2 = pixels.Length;
						obj3 += 4;
						if ((nint)obj3 >= pixels.Length)
						{
							break;
						}
						continue;
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				}
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
				goto IL_03da;
				IL_03da:
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
				num2 = num;
				goto IL_03f0;
			}
		}
		else
		{
			obj4 = 0;
		}
		object obj16 = obj4 & 1;
		bool changed;
		if (obj16 != null)
		{
			bool flag5 = s == null;
			num2 = num;
			obj = 0;
			ex = null;
			if (flag5)
			{
				goto IL_0445;
			}
			changed = true;
		}
		else
		{
			bool flag6 = s == null;
			num2 = num;
			obj = 0;
			ex = null;
			if (flag6)
			{
				goto IL_0453;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			bool flag7 = !s.egg;
			bool flag8 = !flag7;
			changed = flag8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		s.changed = changed;
		object obj17 = obj4 & 1;
		bool flag9 = obj17 == null;
		object obj18 = !flag9;
		num2 = num;
		obj = 0;
		ex = null;
		if (obj18 == null)
		{
			bool flag10 = s == null;
			num2 = num;
			obj = 0;
			ex = null;
			if (flag10)
			{
				goto IL_0461;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			s.egg = false;
			num2 = num;
			obj = 0;
			ex = null;
		}
		goto IL_05c1;
		IL_0428:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0436;
		IL_0436:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0445;
		IL_0461:
		NullReferenceException ex6 = new NullReferenceException();
		nint num5 = default;
		if (num5 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if (num5 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E9F8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj19 = default;
			ex = (OutOfMemoryException)obj19;
		}
		goto IL_05c1;
		IL_040c:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_041a;
		IL_03f0:
		NullReferenceException ex8 = new NullReferenceException();
		obj = 0;
		ex = null;
		goto IL_040c;
		IL_05c1:
		object obj21 = default;
		object obj20 = (object)(&obj21);
		if (obj20 == null)
		{
			goto IL_040c;
		}
		int num6 = Interlocked.Decrement(ref *(int*)(obj20 + 36));
		bool flag11 = ex == null;
		object obj22 = !flag11;
		num5 = unchecked((nint)null);
		if (obj22 != null)
		{
			goto IL_0428;
		}
		bool flag12 = obj == null;
		object obj23 = !flag12;
		num5 = unchecked((nint)null);
		ex5 = ex;
		if (obj23 == null)
		{
			return;
		}
		goto IL_0436;
		IL_0453:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0461;
		IL_0445:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0453;
		IL_041a:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0428;
	}

	public static void Paint(Job j)
	{
		//IL_03c6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0244: Invalid comparison between F4 and I4
		//IL_010c: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		bool flag = j == null;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		System.Random random = (System.Random)109891584;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			System.Random random2 = default;
			random2._002Ector(j.seed);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v28+A0]");
			object obj5 = 0;
			List<System.__Canon> pieces = (List<System.__Canon>)(object)j.pieces;
			_ = 0;
			bool flag3 = j.pieces == null;
			object obj6 = 0;
			num = j.seed;
			random = random2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8768]");
				object obj7 = 0;
				object obj8 = 0;
				int num2 = j.seed;
				int num3 = 0;
				object obj11;
				do
				{
					bool flag4 = num3 >= pieces._size;
					obj6 = obj8;
					num = num2;
					random = random2;
					if (!flag4)
					{
						obj6 = obj7;
						System.__Canon p = pieces.get_Item(num3);
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v20+E4]");
						bool flag5 = (nint)0 == 0;
						object obj10 = !flag5;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Pose((Piece)(object)p, num3);
						pieces = (List<System.__Canon>)(object)j.pieces;
						int num4 = num3 + 1;
						bool flag6 = j.pieces == null;
						obj11 = !flag6;
						num = num3;
						random = random2;
						obj8 = obj6;
						num2 = num3;
						num3 = num4;
						continue;
					}
					if (~(j.line ? 1u : 0u) == 0)
					{
						object obj12 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v19+E4]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Scratched(j, random);
						System.Random random3 = random;
					}
					else
					{
						object obj14 = obj2;
						if (j.radius > 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v12+E4]");
							bool flag8 = (nint)0 == 0;
							object obj15 = !flag8;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Landed(j, random);
							System.Random random3 = random;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v12+E4]");
							bool flag9 = (nint)0 == 0;
							object obj16 = !flag9;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Thrown(j, random);
							System.Random random3 = random;
						}
					}
					object obj17 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5+E4]");
					bool flag10 = (nint)0 == 0;
					object obj18 = !flag10;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5+A0]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+68]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v5+E4]");
						bool flag11 = (nint)0 == 0;
						object obj20 = !flag11;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Draw(j);
					}
					return;
				}
				while (obj11 != null);
			}
		}
		throw new NullReferenceException();
	}

	public unsafe static void Pose(Piece p, int index)
	{
		//IL_1eea: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_0dee: Expected Obj, but got I4
		//IL_0df7: Expected Obj, but got I4
		//IL_0e00: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_0e20: Expected Obj, but got I4
		//IL_1f08: Expected Obj, but got I
		//IL_1f18: Expected Obj, but got I
		//IL_1f52: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_1f82: Expected Obj, but got I4
		//IL_0e78: Expected Obj, but got I4
		//IL_22c6: Expected Obj, but got I
		//IL_22d6: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Expected Ref, but got Unknown
		//IL_1fbc: Expected Obj, but got I
		//IL_1fd9: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I
		//IL_0ed0: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I4
		//IL_0f34: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I
		//IL_0f54: Expected Obj, but got I
		//IL_0f64: Expected Obj, but got I
		//IL_0f74: Expected Obj, but got I
		//IL_0f84: Expected Obj, but got I
		//IL_0f94: Expected Obj, but got I
		//IL_0fbe: Expected Obj, but got I4
		//IL_2057: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_21bf: Expected Obj, but got I
		//IL_21cf: Expected Obj, but got I
		//IL_21f6: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0ffe: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I
		//IL_101e: Expected Obj, but got I
		//IL_102e: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_1054: Expected Obj, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_035c: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_1077: Expected Obj, but got Unknown
		//IL_1087: Expected Obj, but got I
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected Obj, but got Unknown
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Expected Obj, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected Obj, but got Unknown
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected Obj, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected Obj, but got Unknown
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Expected Obj, but got Unknown
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected Obj, but got Unknown
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1173: Expected Obj, but got Unknown
		//IL_1183: Unknown result type (might be due to invalid IL or missing references)
		//IL_1188: Expected Obj, but got Unknown
		//IL_11b2: Expected Obj, but got I
		//IL_11c2: Expected Obj, but got I
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f1: Expected Obj, but got Unknown
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Expected Obj, but got Unknown
		//IL_1223: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected Obj, but got Unknown
		//IL_2039: Expected Obj, but got I4
		//IL_1286: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I4
		//IL_0567: Expected Obj, but got I
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_231d: Expected Obj, but got I
		//IL_232d: Expected Obj, but got I
		//IL_1de3: Expected Obj, but got I4
		//IL_2242: Expected Obj, but got I4
		//IL_12b6: Expected Obj, but got I
		//IL_12c6: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05c5: Expected Obj, but got I4
		//IL_061c: Expected Obj, but got I4
		//IL_0631: Expected Obj, but got I
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_1df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfe: Expected Obj, but got Unknown
		//IL_136d: Expected Obj, but got I
		//IL_137d: Expected Obj, but got I
		//IL_138d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected Obj, but got Unknown
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got Unknown
		//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Expected Obj, but got Unknown
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d1: Expected Obj, but got Unknown
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e6: Expected Obj, but got Unknown
		//IL_13f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fb: Expected Obj, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected Obj, but got Unknown
		//IL_1420: Unknown result type (might be due to invalid IL or missing references)
		//IL_1425: Expected Obj, but got Unknown
		//IL_1442: Unknown result type (might be due to invalid IL or missing references)
		//IL_1447: Expected Obj, but got Unknown
		//IL_1464: Unknown result type (might be due to invalid IL or missing references)
		//IL_1469: Expected Obj, but got Unknown
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected Obj, but got Unknown
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c7: Expected Obj, but got Unknown
		//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dc: Expected Obj, but got Unknown
		//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Expected Obj, but got Unknown
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		//IL_152d: Expected Obj, but got Unknown
		//IL_154a: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Expected Obj, but got Unknown
		//IL_155f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1564: Expected Obj, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Expected Obj, but got Unknown
		//IL_0679: Expected Obj, but got I
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_06a7: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_06d9: Expected Obj, but got I
		//IL_1e49: Expected Obj, but got I4
		//IL_1618: Expected Obj, but got I4
		//IL_2279: Expected Obj, but got I4
		//IL_0741: Expected Obj, but got I4
		//IL_0756: Expected Obj, but got I
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_1e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e65: Expected Obj, but got Unknown
		//IL_1e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e72: Expected Obj, but got Unknown
		//IL_1e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e80: Expected Obj, but got Unknown
		//IL_1e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8e: Expected Obj, but got Unknown
		//IL_1648: Expected Obj, but got I
		//IL_1658: Expected Obj, but got I
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f7: Expected Obj, but got Unknown
		//IL_1707: Expected Obj, but got I
		//IL_1717: Expected Obj, but got I
		//IL_1727: Unknown result type (might be due to invalid IL or missing references)
		//IL_172c: Expected Obj, but got Unknown
		//IL_173c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1741: Expected Obj, but got Unknown
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected Obj, but got Unknown
		//IL_1766: Unknown result type (might be due to invalid IL or missing references)
		//IL_176b: Expected Obj, but got Unknown
		//IL_177b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1780: Expected Obj, but got Unknown
		//IL_1790: Unknown result type (might be due to invalid IL or missing references)
		//IL_1795: Expected Obj, but got Unknown
		//IL_17a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17aa: Expected Obj, but got Unknown
		//IL_17ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bf: Expected Obj, but got Unknown
		//IL_17dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e1: Expected Obj, but got Unknown
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1803: Expected Obj, but got Unknown
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_184c: Expected Obj, but got Unknown
		//IL_185c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1861: Expected Obj, but got Unknown
		//IL_1871: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected Obj, but got Unknown
		//IL_1893: Unknown result type (might be due to invalid IL or missing references)
		//IL_1898: Expected Obj, but got Unknown
		//IL_18b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ba: Expected Obj, but got Unknown
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cf: Expected Obj, but got Unknown
		//IL_194e: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07cc: Expected Obj, but got I
		//IL_07ee: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_197e: Expected Obj, but got I4
		//IL_1b0c: Expected Obj, but got I4
		//IL_1a0e: Expected Obj, but got I
		//IL_1a1e: Expected Obj, but got I
		//IL_1a75: Expected Obj, but got I
		//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2f: Expected Obj, but got Unknown
		//IL_1b3f: Expected Obj, but got I
		//IL_1b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b54: Expected Obj, but got Unknown
		//IL_1b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b69: Expected Obj, but got Unknown
		//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7e: Expected Obj, but got Unknown
		//IL_1b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b93: Expected Obj, but got Unknown
		//IL_1ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Expected Obj, but got Unknown
		//IL_1bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbd: Expected Obj, but got Unknown
		//IL_1bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd2: Expected Obj, but got Unknown
		//IL_1be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be7: Expected Obj, but got Unknown
		//IL_1c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c09: Expected Obj, but got Unknown
		//IL_1c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1e: Expected Obj, but got Unknown
		//IL_1c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c40: Expected Obj, but got Unknown
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected Obj, but got Unknown
		//IL_1c8c: Expected Obj, but got I
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc8: Expected Obj, but got Unknown
		//IL_1cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdd: Expected Obj, but got Unknown
		//IL_1cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cff: Expected Obj, but got Unknown
		//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Expected Obj, but got Unknown
		//IL_1d65: Expected Obj, but got I
		//IL_0953: Expected Obj, but got I4
		//IL_095c: Expected Obj, but got I4
		//IL_08c9: Expected Obj, but got I
		//IL_08fd: Expected Obj, but got I4
		//IL_20c8: Expected Obj, but got I
		//IL_20d0: Expected Obj, but got I4
		//IL_0a67: Expected Obj, but got I4
		//IL_213e: Expected Obj, but got I4
		//IL_0b22: Expected Obj, but got I
		//IL_0b3f: Expected Obj, but got I
		//IL_0b63: Expected Obj, but got I
		//IL_0b7b: Expected Obj, but got I
		//IL_0b8b: Expected Obj, but got I
		//IL_0bce: Expected Obj, but got I4
		//IL_0c28: Expected Obj, but got I
		//IL_0c38: Expected Obj, but got I
		//IL_0c48: Expected Obj, but got I
		//IL_0c5d: Expected I, but got Obj
		//IL_0c96: Expected Obj, but got I4
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected Obj, but got Unknown
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0d18: Expected Obj, but got I4
		//IL_0d55: Expected I, but got Obj
		//IL_0d7f: Expected Obj, but got I
		//IL_0dac: Expected I, but got Obj
		bool flag = p == null;
		int num = index;
		int num2 = index;
		object obj = 109891584;
		Shape shape = default;
		Vector3[] at;
		object obj2 = default;
		int num3 = default;
		int num5 = default;
		nint num4 = default;
		if (!flag)
		{
			shape = p.shape;
			bool flag2 = p.shape == null;
			num = index;
			num2 = index;
			obj = 109891584;
			if (!flag2)
			{
				at = shape.at;
				bool flag3 = shape.at == null;
				num = index;
				num2 = index;
				obj = 109891584;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+E4]");
					bool flag4 = (nint)0 == 0;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+A0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v81+88]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v81+88]");
					bool flag5 = (nint)0 == 0;
					num = index;
					num3 = at.Length;
					num2 = index;
					obj = 109891584;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X9_v22+18]");
						bool flag6 = (nint)0 > (nint)index;
						num = index;
						obj = 109891584;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+E4]");
							bool flag7 = (nint)0 == 0;
							object obj7 = !flag7;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj8 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v84+A0]");
								obj5 = 0;
							}
							ref System.__Canon[] array = ref *(System.__Canon[]*)(obj5 + 136);
							int newSize = index + 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8770]");
							obj = 0;
							Array.Resize(ref array, newSize);
							object obj9 = obj2;
							num4 = (nint)obj;
							num = index + 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X8_v82+A0]");
							Array.Resize(ref *(System.__Canon[]*)((nint)0 + (nint)144), num);
							obj3 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+E4]");
						bool flag8 = (nint)0 == 0;
						object obj10 = !flag8;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj3 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+A0]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X8_v37+88]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X8_v37+88]");
						bool flag9 = (nint)0 == 0;
						num3 = at.Length;
						num2 = index;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X8_v75+18]");
							bool flag10 = (nint)0 < (nint)index;
							object obj13 = !flag10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X8_v75+18]");
							object obj14 = -index;
							bool flag11 = obj14 == null;
							object obj15 = ~obj13;
							object obj16 = obj15 | flag11;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X8_v37+88]");
								object obj17 = (nint)0 + (nint)index;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X9_v26+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+E4]");
									bool flag12 = (nint)0 == 0;
									object obj18 = !flag12;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj3 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+A0]");
										object obj19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X8_v79+88]");
										obj12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X8_v79+88]");
										bool flag13 = (nint)0 == 0;
										num3 = at.Length;
										num2 = index;
										if (flag13)
										{
											goto IL_0dba;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X8_v75+18]");
									bool flag14 = (nint)0 < (nint)index;
									object obj20 = !flag14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X8_v75+18]");
									object obj21 = -index;
									bool flag15 = obj21 == null;
									object obj22 = ~obj20;
									object obj23 = obj22 | flag15;
									if (obj23 != null)
									{
										goto IL_1ebb;
									}
									object obj24 = obj12 + index;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X8_v76+20]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X8_v76+20]");
									bool flag16 = (nint)0 == 0;
									num3 = at.Length;
									num2 = index;
									if (flag16)
									{
										goto IL_0dba;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v77+18]");
									bool flag17 = (nint)0 >= (nint)at.Length;
									object obj26 = obj3;
									if (flag17)
									{
										goto IL_2017;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+E4]");
								bool flag18 = (nint)0 == 0;
								object obj27 = !flag18;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj3 = obj2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v53+A0]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v70+88]");
								num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v70+88]");
								bool flag19 = (nint)0 == 0;
								num = at.Length;
								num3 = at.Length;
								num2 = index;
								if (flag19)
								{
									goto IL_0dba;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v5 (System.Int32)+18]");
								bool flag20 = (nint)0 < (nint)index;
								object obj29 = !flag20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v5 (System.Int32)+18]");
								object obj30 = -index;
								bool flag21 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag21;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v70+88]");
									object obj33 = (nint)0 + (nint)index;
									object obj34 = obj33 + 32;
									object obj35 = default;
									obj34 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj36 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1410 @ X8_v72+A0]");
									object obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v73+90]");
									num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v73+90]");
									bool flag22 = (nint)0 == 0;
									num = at.Length;
									num3 = at.Length;
									num2 = index;
									if (flag22)
									{
										goto IL_0dba;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v5 (System.Int32)+18]");
									bool flag23 = (nint)0 < (nint)index;
									object obj38 = !flag23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v5 (System.Int32)+18]");
									object obj39 = -index;
									bool flag24 = obj39 == null;
									object obj40 = ~obj38;
									object obj41 = obj40 | flag24;
									if (obj41 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v73+90]");
										object obj42 = (nint)0 + (nint)index;
										object obj43 = obj42 + 32;
										int num6 = default;
										obj43 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj26 = obj2;
										num = num6;
										goto IL_2017;
									}
								}
							}
							goto IL_1ebb;
						}
					}
				}
			}
		}
		goto IL_0dba;
		IL_2017:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v27+E4]");
		bool flag25 = (nint)0 == 0;
		object obj44 = !flag25;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj26 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v27+A0]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ X8_v41+88]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ X8_v41+88]");
		bool flag26 = (nint)0 == 0;
		num3 = at.Length;
		num2 = index;
		if (!flag26)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v42+18]");
			bool flag27 = (nint)0 < (nint)index;
			object obj47 = !flag27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v42+18]");
			object obj48 = -index;
			bool flag28 = obj48 == null;
			object obj49 = ~obj47;
			object obj50 = obj49 | flag28;
			if (obj50 != null)
			{
				goto IL_1ebb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ X8_v41+88]");
			object obj51 = (nint)0 + (nint)index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ X8_v43+20]");
			num5 = 0;
			object obj52 = p + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ X8_v43+20]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj53 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v44+A0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v45+90]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v45+90]");
			bool flag29 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ X8_v43+20]");
			num = 0;
			num3 = at.Length;
			num2 = index;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v46+18]");
				bool flag30 = (nint)0 < (nint)index;
				object obj56 = !flag30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v46+18]");
				object obj57 = -index;
				bool flag31 = obj57 == null;
				object obj58 = ~obj56;
				object obj59 = obj58 | flag31;
				if (obj59 != null)
				{
					goto IL_1ebb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v45+90]");
				object obj60 = (nint)0 + (nint)index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X8_v47+20]");
				num2 = 0;
				object obj61 = p + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X8_v47+20]");
				obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj62 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v48+A0]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v49+B0]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v49+B0]");
				bool flag32 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X8_v47+20]");
				num = 0;
				num3 = at.Length;
				if (!flag32)
				{
					Matrix4x4[] bones = p.bones;
					bool flag33 = p.bones == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ X8_v47+20]");
					num = 0;
					num3 = at.Length;
					if (!flag33)
					{
						int num7 = bones.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X9_v31+18]");
						if ((nint)0 < (nint)bones.Length)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
							object obj65 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj66 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X8_v65+E4]");
							bool flag34 = (nint)0 == 0;
							object obj67 = !flag34;
							if (obj67 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj66 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X8_v65+A0]");
							object obj68 = (nint)0 + (nint)176;
							int num8 = default;
							obj68 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bones = p.bones;
							bool flag35 = p.bones == null;
							num7 = num8;
							num = num8;
							num3 = at.Length;
							if (flag35)
							{
								goto IL_0dba;
							}
						}
						object obj70 = default;
						object obj69 = obj70;
						object obj72 = default;
						object obj71 = obj72;
						object obj74 = default;
						object obj73 = obj74;
						object obj76 = default;
						object obj75 = obj76;
						object obj78 = default;
						object obj77 = obj78;
						object obj79 = 32;
						object obj80 = 0;
						nint num9 = num4;
						object obj92 = default;
						object obj95 = default;
						object obj96 = default;
						object obj97 = default;
						while (true)
						{
							bool flag36 = (nint)obj80 >= bones.Length;
							obj70 = obj69;
							obj72 = obj71;
							obj74 = obj73;
							obj76 = obj75;
							obj78 = obj77;
							num = num7;
							num4 = num9;
							num3 = at.Length;
							if (flag36)
							{
								break;
							}
							Matrix4x4[] binds = shape.binds;
							bool flag37 = shape.binds == null;
							obj70 = obj69;
							obj72 = obj71;
							obj74 = obj73;
							obj76 = obj75;
							obj78 = obj77;
							num = num7;
							num4 = num9;
							num3 = at.Length;
							if (!flag37)
							{
								bool flag38 = (nint)obj80 >= binds.Length;
								obj70 = obj69;
								obj72 = obj71;
								obj74 = obj73;
								obj76 = obj75;
								obj78 = obj77;
								num = num7;
								num4 = num9;
								num3 = at.Length;
								if (flag38)
								{
									break;
								}
								object obj81 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v37+E4]");
								bool flag39 = (nint)0 == 0;
								object obj82 = !flag39;
								Matrix4x4[] array2 = bones;
								if (obj82 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									array2 = p.bones;
									bool flag40 = p.bones == null;
									obj70 = obj69;
									obj72 = obj71;
									obj74 = obj73;
									obj76 = obj75;
									obj78 = obj77;
									num = num7;
									num4 = num9;
									num3 = at.Length;
									if (flag40)
									{
										goto IL_0dba;
									}
									obj81 = obj2;
								}
								bool flag41 = (nint)obj80 < array2.Length;
								object obj83 = !flag41;
								if (obj83 != null)
								{
									goto IL_1ebb;
								}
								object obj84 = (object)array2 + obj79;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v37+A0]");
								object obj85 = 0;
								Matrix4x4[] binds2 = shape.binds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X9_v40+B0]");
								obj70 = 0;
								bool flag42 = shape.binds == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v54+10]");
								obj72 = 0;
								obj74 = obj84;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v54+30]");
								obj76 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v54+20]");
								obj78 = 0;
								num = num7;
								num4 = num9;
								num3 = at.Length;
								if (!flag42)
								{
									bool flag43 = (nint)obj80 < binds2.Length;
									object obj86 = !flag43;
									if (obj86 != null)
									{
										goto IL_1ebb;
									}
									object obj87 = (object)shape.binds + obj79;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X9_v40+B0]");
									bool flag44 = (nint)0 == 0;
									object obj88 = obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v54+10]");
									obj72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X8_v56+20]");
									obj74 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X8_v56+10]");
									obj76 = 0;
									obj78 = obj87;
									num = (int)(&obj88);
									num4 = unchecked((nint)null);
									num3 = at.Length;
									if (!flag44)
									{
										object obj89 = obj80;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X27_v5+18]");
										bool flag45 = (nint)obj89 < 0;
										object obj90 = !flag45;
										if (obj90 != null)
										{
											goto IL_1ebb;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X9_v40+B0]");
										object obj91 = 0 + obj79;
										obj79 += 64;
										obj80++;
										obj91 = obj92;
										bones = p.bones;
										bool flag46 = p.bones == null;
										object obj93 = !flag46;
										obj88 = obj87;
										object obj94 = obj84;
										obj72 = obj95;
										obj74 = obj92;
										obj76 = obj96;
										obj78 = obj97;
										num = (int)(&obj88);
										num4 = unchecked((nint)null);
										num3 = at.Length;
										obj88 = obj87;
										obj94 = obj84;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X9_v40+B0]");
										obj69 = 0;
										obj71 = obj95;
										obj73 = obj92;
										obj75 = obj96;
										obj77 = obj97;
										num7 = (int)(&obj88);
										num9 = unchecked((nint)null);
										if (obj93 != null)
										{
											continue;
										}
									}
								}
							}
							goto IL_0dba;
						}
						goto IL_0dc8;
					}
				}
			}
		}
		goto IL_0dba;
		IL_0dba:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0dc8;
		IL_1ebb:
		throw new IndexOutOfRangeException();
		IL_0dc8:
		if (num3 < 1)
		{
			return;
		}
		object obj98 = 40;
		object obj99 = 60;
		object obj100 = 0;
		object obj115 = default;
		object obj116 = default;
		object obj117 = default;
		object obj118 = default;
		object obj119 = default;
		object obj120 = default;
		object obj132 = default;
		object obj134 = default;
		object obj136 = default;
		object obj138 = default;
		object obj148 = default;
		object obj150 = default;
		object obj189 = default;
		object obj193 = default;
		object obj224 = default;
		object obj267 = default;
		while (true)
		{
			BoneWeight[] weights = shape.weights;
			if (shape.weights == null)
			{
				break;
			}
			bool flag47 = (nint)obj100 < weights.Length;
			object obj101 = !flag47;
			if (obj101 == null)
			{
				Vector3[] at2 = shape.at;
				if (shape.at == null)
				{
					break;
				}
				bool flag48 = (nint)obj100 < at2.Length;
				object obj102 = !flag48;
				if (obj102 == null)
				{
					Vector3[] faces = shape.faces;
					if (shape.faces == null)
					{
						break;
					}
					bool flag49 = (nint)obj100 < faces.Length;
					object obj103 = !flag49;
					if (obj103 == null)
					{
						object obj104 = (object)shape.weights + obj99;
						object obj105 = (object)shape.at + obj98;
						object obj106 = obj2;
						object obj107 = (object)shape.faces + obj98;
						object obj108 = obj105;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-C]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-4]");
						object obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X10_v6-8]");
						object obj109 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X10_v6-4]");
						object obj110 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+E4]");
						at2 = (Vector3[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v12-8]");
						object obj111 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v12-4]");
						object obj112 = 0;
						object obj113 = obj107;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+E4]");
						bool flag50 = (nint)0 == 0;
						object obj114 = !flag50;
						if (obj114 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj106 = obj2;
							obj115 = obj105;
							obj116 = obj107;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v12-4]");
							obj117 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v12-8]");
							obj118 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X10_v6-8]");
							obj119 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X10_v6-4]");
							obj120 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+A0]");
						object obj121 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v13+B0]");
						object obj122 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v13+B0]");
						bool flag51 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
						object obj76 = 0;
						if (flag51)
						{
							break;
						}
						object obj123 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v22+18]");
						bool flag52 = (nint)obj123 < 0;
						object obj124 = !flag52;
						if (obj124 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v13+B0]");
							object obj125 = 0 + obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+48]");
							object obj126 = 0;
							object obj127 = obj109;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+28]");
							object obj128 = obj127 * 0;
							object obj129 = obj110;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+38]");
							object obj130 = obj129 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+20]");
							object obj131 = 0 * obj132;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+30]");
							object obj133 = 0 * obj134;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+20]");
							object obj135 = 0 * obj136;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+30]");
							object obj137 = 0 * obj138;
							object obj139 = obj111;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+28]");
							object obj140 = obj139 * 0;
							object obj141 = obj112;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+38]");
							object obj142 = obj141 * 0;
							object obj143 = obj128 + obj130;
							object obj144 = obj108;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+48]");
							object obj145 = obj144 * 0;
							object obj146 = obj131 + obj133;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+40]");
							object obj147 = 0 * obj148;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+40]");
							object obj149 = 0 * obj150;
							object obj74 = obj135 + obj137;
							obj76 = obj140 + obj142;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+58]");
							object obj78 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+50]");
							object obj72 = 0;
							object obj151 = obj143 + obj145;
							object obj152 = obj146 + obj147;
							object obj153 = obj113;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+48]");
							object obj154 = obj153 * 0;
							object obj155 = obj74 + obj149;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+58]");
							object obj156 = 0 + obj151;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ X9_v8+50]");
							object obj157 = 0 + obj152;
							object obj158 = obj76 + obj154;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-1C]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A918]");
							if (num10 < 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+E4]");
								bool flag53 = (nint)0 == 0;
								object obj159 = !flag53;
								if (obj159 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj106 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+A0]");
									object obj160 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v29+B0]");
									obj122 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v29+B0]");
									bool flag54 = (nint)0 == 0;
									obj115 = obj108;
									obj116 = obj113;
									obj117 = obj112;
									obj118 = obj111;
									obj119 = obj109;
									obj120 = obj110;
									if (flag54)
									{
										break;
									}
									obj115 = obj108;
									obj116 = obj113;
									obj117 = obj112;
									obj118 = obj111;
									obj119 = obj109;
									obj120 = obj110;
								}
								object obj161 = obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v22+18]");
								bool flag55 = (nint)obj161 < 0;
								object obj162 = !flag55;
								if (obj162 != null)
								{
									goto IL_1ebb;
								}
								object obj163 = obj122 + obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+48]");
								obj126 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+40]");
								obj149 = 0;
								object obj164 = obj109;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+28]");
								object obj165 = obj164 * 0;
								object obj166 = obj110;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+38]");
								object obj167 = obj166 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+20]");
								object obj168 = 0 * obj132;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+30]");
								object obj169 = 0 * obj134;
								object obj170 = obj111;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+28]");
								object obj171 = obj170 * 0;
								object obj172 = obj112;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+38]");
								object obj173 = obj172 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+20]");
								object obj174 = 0 * obj136;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+30]");
								object obj175 = 0 * obj138;
								object obj176 = obj165 + obj167;
								object obj177 = obj108;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+48]");
								object obj178 = obj177 * 0;
								object obj179 = obj168 + obj169;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+40]");
								object obj180 = 0 * obj148;
								object obj181 = obj171 + obj173;
								object obj182 = obj174 + obj175;
								object obj183 = obj176 + obj178;
								object obj184 = obj179 + obj180;
								object obj185 = obj113;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+48]");
								object obj186 = obj185 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+40]");
								object obj187 = 0 * obj150;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+58]");
								object obj188 = 0 + obj183;
								obj151 = obj157 * obj189;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X9_v13+50]");
								object obj190 = 0 + obj184;
								object obj191 = obj181 + obj186;
								object obj192 = obj182 + obj187;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-1C]");
								obj152 = 0 * obj156;
								obj154 = obj155 * obj189;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-1C]");
								obj147 = 0 * obj158;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-18]");
								obj74 = 0 * obj188;
								obj72 = obj190 * obj193;
								obj78 = obj192 * obj193;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-18]");
								obj76 = 0 * obj191;
								obj156 = obj152 + obj74;
								obj157 = obj151 + obj72;
								obj155 = obj154 + obj78;
								obj158 = obj147 + obj76;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-14]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
								if (num11 > 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+E4]");
									bool flag56 = (nint)0 == 0;
									object obj194 = !flag56;
									if (obj194 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj106 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+A0]");
										object obj195 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X8_v27+B0]");
										obj122 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X8_v27+B0]");
										bool flag57 = (nint)0 == 0;
										obj115 = obj108;
										obj116 = obj113;
										obj117 = obj112;
										obj118 = obj111;
										obj119 = obj109;
										obj120 = obj110;
										if (flag57)
										{
											break;
										}
										obj115 = obj108;
										obj116 = obj113;
										obj117 = obj112;
										obj118 = obj111;
										obj119 = obj109;
										obj120 = obj110;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-4]");
									nint num12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v22+18]");
									bool flag58 = num12 < 0;
									object obj196 = !flag58;
									if (obj196 != null)
									{
										goto IL_1ebb;
									}
									object obj197 = obj122;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-4]");
									object obj198 = obj197 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+48]");
									obj126 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+40]");
									obj149 = 0;
									object obj199 = obj109;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+28]");
									object obj200 = obj199 * 0;
									object obj201 = obj110;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+38]");
									object obj202 = obj201 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+20]");
									object obj203 = 0 * obj132;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+30]");
									object obj204 = 0 * obj134;
									object obj205 = obj111;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+28]");
									object obj206 = obj205 * 0;
									object obj207 = obj112;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+38]");
									object obj208 = obj207 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+20]");
									object obj209 = 0 * obj136;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+30]");
									object obj210 = 0 * obj138;
									object obj211 = obj200 + obj202;
									object obj212 = obj108;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+48]");
									object obj213 = obj212 * 0;
									object obj214 = obj203 + obj204;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+40]");
									object obj215 = 0 * obj148;
									object obj216 = obj206 + obj208;
									object obj217 = obj209 + obj210;
									obj151 = obj211 + obj213;
									obj152 = obj214 + obj215;
									object obj218 = obj113;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+48]");
									obj154 = obj218 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+40]");
									obj147 = 0 * obj150;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+58]");
									object obj219 = 0 + obj151;
									object obj220 = obj216 + obj154;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1404 @ X9_v17+50]");
									object obj221 = 0 + obj152;
									object obj222 = obj217 + obj147;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-14]");
									obj74 = 0 * obj219;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-14]");
									object obj223 = 0 * obj220;
									obj72 = obj221 * obj224;
									obj78 = obj222 * obj224;
									obj156 += obj74;
									obj158 += obj223;
									obj157 += obj72;
									obj155 += obj78;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
									nint num13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
									bool flag59 = num13 <= 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
									obj76 = 0;
									if (!flag59)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X0_v11+E4]");
										bool flag60 = (nint)0 == 0;
										object obj225 = !flag60;
										object obj226 = obj115;
										object obj227 = obj116;
										object obj228 = obj117;
										object obj229 = obj118;
										object obj230 = obj119;
										object obj231 = obj120;
										object obj232 = obj113;
										object obj233 = obj112;
										object obj234 = obj111;
										object obj235 = obj110;
										object obj236 = obj109;
										object obj237 = obj108;
										if (obj225 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											object obj238 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X8_v24+A0]");
											object obj239 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1524 @ X8_v25+B0]");
											obj122 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1524 @ X8_v25+B0]");
											bool flag61 = (nint)0 == 0;
											obj115 = obj108;
											obj116 = obj113;
											obj117 = obj112;
											obj118 = obj111;
											obj119 = obj109;
											obj120 = obj110;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
											obj76 = 0;
											obj226 = obj108;
											obj227 = obj113;
											obj228 = obj112;
											obj229 = obj111;
											obj230 = obj109;
											obj231 = obj110;
											obj232 = obj113;
											obj233 = obj112;
											obj234 = obj111;
											obj235 = obj110;
											obj236 = obj109;
											obj237 = obj108;
											if (flag61)
											{
												break;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6+4]");
										nint num14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v22+18]");
										bool flag62 = num14 < 0;
										object obj240 = !flag62;
										if (obj240 != null)
										{
											goto IL_1ebb;
										}
										object obj241 = obj122;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6+4]");
										object obj242 = obj241 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+40]");
										obj149 = 0;
										object obj243 = obj236;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+28]");
										object obj244 = obj243 * 0;
										object obj245 = obj235;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+38]");
										object obj246 = obj245 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+20]");
										object obj247 = 0 * obj132;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+30]");
										object obj248 = 0 * obj134;
										object obj249 = obj234;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+28]");
										object obj250 = obj249 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+20]");
										object obj251 = 0 * obj136;
										object obj252 = obj233;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+38]");
										object obj253 = obj252 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+30]");
										object obj254 = 0 * obj138;
										object obj255 = obj244 + obj246;
										object obj256 = obj237;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+48]");
										object obj257 = obj256 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+40]");
										obj108 = 0 * obj148;
										obj154 = obj247 + obj248;
										object obj258 = obj232;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+48]");
										obj147 = obj258 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+40]");
										obj126 = 0 * obj150;
										object obj259 = obj250 + obj253;
										object obj260 = obj251 + obj254;
										object obj261 = obj255 + obj257;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+50]");
										obj152 = 0;
										object obj262 = obj154 + obj108;
										object obj263 = obj259 + obj147;
										object obj264 = obj260 + obj126;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+58]");
										object obj265 = 0 + obj261;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ X8_v23+50]");
										object obj266 = 0 + obj262;
										obj78 = obj264 * obj267;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
										obj76 = 0 * obj263;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
										obj72 = 0 * obj265;
										obj74 = obj266 * obj267;
										obj155 += obj78;
										obj158 += obj76;
										obj156 += obj72;
										obj157 += obj74;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v6-10]");
										obj151 = 0;
										obj115 = obj226;
										obj116 = obj227;
										obj117 = obj228;
										obj118 = obj229;
										obj119 = obj230;
										obj120 = obj231;
										obj113 = obj232;
										obj112 = obj233;
										obj111 = obj234;
										obj110 = obj235;
										obj109 = obj236;
									}
								}
							}
							if (num5 == 0)
							{
								break;
							}
							object obj268 = obj100;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X20_v5 (System.Int32)+18]");
							bool flag63 = (nint)obj268 < 0;
							object obj269 = !flag63;
							if (obj269 == null)
							{
								object obj270 = num5 + obj98;
								obj270 = obj156;
								if (num2 == 0)
								{
									break;
								}
								object obj271 = obj100;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X21_v3 (System.Int32)+18]");
								bool flag64 = (nint)obj271 < 0;
								object obj272 = !flag64;
								if (obj272 == null)
								{
									obj100++;
									object obj273 = num2 + obj98;
									obj99 += 32;
									obj98 += 12;
									obj273 = obj158;
									if (num3 == (nint)obj100)
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
			goto IL_1ebb;
		}
		goto IL_0dba;
	}

	private unsafe static void Add(Vector3 a, Vector3 b, float ra, float rb, Vector3 faces, int channel)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got I
		//IL_062b: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0065: Expected I4, but got VT
		//IL_0465: Expected Obj, but got I4
		//IL_0660: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_0481: Expected I4, but got Obj
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Ref, but got Unknown
		//IL_04b5: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+58]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+58]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+68]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+68]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X10_v1+18]");
			bool flag2 = num != 0;
			int num2 = (int)b;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v23+A0]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+68]");
					obj6 = 0;
				}
				int newSize = obj6 << 1;
				Array.Resize(ref *(Blot[]*)(obj4 + 88), newSize);
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v21+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8780]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v21+A0]");
				ref Vector4[] array = ref *(Vector4[]*)((nint)0 + (nint)96);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v22+68]");
				num2 = (int)((nint)0 << 1);
				Array.Resize(ref array, num2);
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v5+58]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v5+58]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v5+68]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v9+18]");
				bool flag5 = num3 < 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					object obj16 = default;
					float num4 = (float)obj16 - ra;
					object obj17 = default;
					float num5 = (float)obj17 - rb;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v5+58]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v5+68]");
					object obj18 = num6 + 0;
					object obj20 = default;
					object obj21 = default;
					object obj19 = obj20 - obj21;
					float num7 = num4 * num4;
					float num8 = num5 * num5;
					object obj22 = obj19 * obj19;
					float num9 = num7 + num8;
					float num10 = (float)obj22 + num9;
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v11+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+60]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+68]");
					object obj26 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj27 = 0;
					object obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v11+E4]");
					bool flag6 = (nint)0 == 0;
					object obj29 = !flag6;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+60]");
					if ((nint)0 == 0)
					{
						goto IL_03f6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+68]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X20_v5+18]");
					bool flag7 = num11 < 0;
					object obj30 = !flag7;
					if (obj30 == null)
					{
						float num12 = ra - (float)obj16;
						float num13 = rb - (float)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+60]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v12+68]");
						object obj31 = num14 + 0;
						object obj32 = obj21 - obj20;
						object obj34 = default;
						object obj35 = default;
						object obj33 = obj34 - obj35;
						bool flag8 = (nint)obj33 < 0;
						bool flag9 = obj33 == null;
						object obj36 = obj34 ^ obj35;
						object obj37 = obj34 ^ obj33;
						object obj38 = obj36 & obj37;
						bool flag10 = (nint)obj38 < 0;
						float num15 = rb + (float)obj17;
						object obj39 = obj21 + obj20;
						float num16 = num12 * num12;
						float num17 = num13 * num13;
						bool flag11 = flag8 == flag10;
						object obj40 = !flag9;
						object obj41 = flag11 & obj40;
						object obj42 = ~obj41;
						object obj43 = ((obj42 != null) ? obj35 : obj34);
						float num18 = num16 + num17;
						object obj44 = obj32 * obj32;
						float num19 = ra + (float)obj16;
						float num20 = (float)obj44 + num18;
						float num21 = num19 * 0.5f;
						float num22 = num15 * 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num23 = num20 * 0.5f;
						double num24 = (double)obj39 * 0.5;
						float num25 = (float)obj43 + num23;
						return;
					}
				}
				goto IL_0404;
			}
		}
		goto IL_03f6;
		IL_03f6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0404;
		IL_0404:
		throw new IndexOutOfRangeException();
	}

	private static float Rand(System.Random rng, float lo, float hi)
	{
		//IL_000f: Expected Obj, but got I
		StreamingContext context = default;
		((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, context);
		float num = hi - lo;
		float num2 = num * lo;
		return num2 + lo;
	}

	private unsafe static void Snap(Piece p, ref Vector3 at, out Vector3 faces)
	{
		//IL_01bd: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04cf: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		Shape shape = p.shape;
		int[] fur = shape.fur;
		Vector3[] at2 = p.at;
		object obj3;
		if (fur.Length >= 1)
		{
			object obj = ~fur.Length;
			object obj2 = fur.Length & obj;
			obj3 = 0;
			object obj4 = 2139095039;
			object obj5 = 0;
			while (fur.Length != (nint)obj5)
			{
				object obj6 = (object)fur + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X13_v5+20]");
				bool flag = (nint)0 < (nint)at2.Length;
				object obj7 = !flag;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X13_v5+20]");
				object obj8 = (nint)0 * (nint)12;
				object obj9 = (object)at2 + obj8;
				obj5++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X14_v6+20]");
				object obj10 = 0 - at;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X14_v6+28]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+8]");
				object obj11 = num - 0;
				object obj12 = obj10 * obj10;
				object obj13 = obj11 * obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj14 = obj12 + obj13;
				object obj15 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4)) ? obj4 : obj14);
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X13_v5+20]");
					obj3 = 0;
				}
				bool flag2 = obj2 != obj5;
				obj4 = obj15;
				if (flag2)
				{
					continue;
				}
				goto IL_0433;
			}
			goto IL_03d8;
		}
		obj3 = 0;
		goto IL_0433;
		IL_0433:
		Vector3[] faces2 = p.faces;
		bool flag3 = (nint)obj3 < faces2.Length;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			object obj17 = faces2 + 32;
			object obj18 = obj3 * 12;
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj20 = 0;
			object obj21 = obj3 * 12;
			object obj22 = obj17 + obj21;
			object obj23 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj24 = !flag4;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj25 = default;
			object obj27;
			object obj28;
			if ((nint)obj25 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj26 = obj22 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				obj27 = obj19 / 0;
				obj28 = obj26 / obj25;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v19+A0]");
				object obj31 = 0;
				obj27 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v20+8]");
				obj28 = 0;
			}
			ref Vector3 reference = ref *(Vector3*)obj27;
			bool flag5 = (nint)obj3 < at2.Length;
			object obj32 = !flag5;
			if (obj32 == null)
			{
				object obj33 = obj3 * 12;
				object obj34 = (object)at2 + obj33;
				Vector3 vector = at;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v16+20]");
				object obj35 = vector - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v16+28]");
				object obj36 = num2 - 0;
				object obj37 = obj27 * obj35;
				object obj38 = obj28 * obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj39 = obj38 + obj37;
				object obj41 = default;
				object obj40 = obj27 * obj41;
				object obj42 = obj28 * obj39;
				object obj43 = at - obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3&)+8]");
				object obj44 = 0 - obj42;
				ref Vector3 reference2 = ref *(Vector3*)obj43;
				return;
			}
		}
		goto IL_03d8;
		IL_03d8:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static Vector3 Sideways(Vector3 faces, System.Random rng)
	{
		//IL_001a: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_02f7: Invalid comparison between VT and I4
		//IL_01e1: Expected VT, but got Obj
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		object obj2 = default;
		object obj4;
		object obj5;
		object obj6;
		if ((nint)obj2 > 0)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v25+A0]");
			obj4 = (nint)0 + (nint)60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v25+A0]");
			obj5 = (nint)0 + (nint)64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v25+A0]");
			obj6 = (nint)0 + (nint)68;
		}
		else
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v20+A0]");
			obj4 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v20+A0]");
			obj5 = (nint)0 + (nint)28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v20+A0]");
			obj6 = (nint)0 + (nint)32;
		}
		object obj8 = obj2 * obj6;
		object obj10 = default;
		object obj9 = obj10 * obj5;
		object obj11 = obj10 * obj4;
		object obj13 = default;
		object obj12 = obj13 * obj6;
		object obj14 = obj13 * obj5;
		object obj15 = obj2 * obj4;
		object obj16 = obj8 - obj9;
		object obj17 = obj11 - obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj18 = 0;
		object obj19 = obj14 - obj15;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj21 = !flag;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = obj16 * obj16;
		object obj23 = obj17 * obj17;
		object obj24 = obj22 + obj23;
		object obj25 = obj19 * obj19;
		object obj26 = obj25 + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj27;
		object obj28;
		object obj29;
		if ((nint)obj26 > 0)
		{
			obj27 = obj16 / obj26;
			obj28 = obj17 / obj26;
			obj29 = obj19 / obj26;
		}
		else
		{
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14+A0]");
			object obj31 = 0;
			obj27 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v15+4]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v15+8]");
			obj29 = 0;
		}
		if (faces != (Vector3)(object)0)
		{
			float x = faces.x;
			object obj32 = obj13 * obj28;
			object obj33 = obj2 * obj27;
			object obj34 = obj13 * obj29;
			object obj35 = obj10 * obj27;
			object obj36 = obj2 * obj29;
			object obj37 = obj10 * obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X8_v11 (System.Single)+1B8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			object obj38 = obj32 * 0;
			object obj39 = obj38 + obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
			Vector3 result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private unsafe static void Lobed(Piece p, Vector3 at, Vector3 faces, float r, int channel, System.Random rng)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_0083: Expected VT, but got I4
		//IL_008c: Expected VT, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_032b: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0242: Expected VT, but got Ref
		//IL_0242: Expected VT, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_026a: Expected VT, but got F4
		//IL_0272: Expected VT, but got Ref
		//IL_0282: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default;
		Add(at, at, r, num, faces, channel);
		float x = faces.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X8_v4 (System.Single)+198] (should have been resolved before IL gen)");
		object obj4 = default;
		if ((nint)obj4 < 1)
		{
			return;
		}
		Vector3 at2 = (Vector3)0;
		Vector3 vector = (Vector3)8;
		System.Random rng2 = (System.Random)4;
		double num3 = default;
		double num2 = num3;
		float num4 = num;
		double num5 = num3;
		double num7 = default;
		double num6 = num7;
		double num8 = num7;
		float num9 = r;
		float num10 = num;
		float num11 = r;
		object obj5 = obj4;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		bool flag3;
		do
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector2 = Sideways(faces, rng2);
			float x2 = faces.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X8_v9 (System.Single)+1B8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADE0]");
			object obj8 = obj9 * 0;
			double num12 = (double)obj8 + 0.5;
			double num13 = num12 * num7;
			double num14 = (double)obj9 * num13;
			double num15 = (double)obj10 * num13;
			double num16 = (double)obj11 * num13;
			float num17 = r + (float)num14;
			float num18 = num + (float)num15;
			double num19 = num3 + num16;
			Snap(p, ref at2, out var faces2);
			float x3 = faces.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ X8_v10 (System.Single)+1B8] (should have been resolved before IL gen)");
			double num20 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB30]");
			double num21 = num20 * 0.0;
			double num22 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			double num23 = num22 + 0.0;
			num8 = num23 * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v10 (System.Single)+1C0]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (System.Single)+1A0]");
			Add(at, (Vector3)num24, num17, num18, (Vector3)(&faces2), 0);
			obj5--;
			flag3 = (nint)obj5 != 1;
			at2 = (Vector3)num17;
			vector = (Vector3)(&faces2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v10 (System.Single)+1C0]");
			rng2 = (System.Random)0;
			num2 = num19;
			num4 = num18;
			num5 = num19;
			num6 = num8;
			num9 = num17;
			num10 = num18;
			num11 = num17;
		}
		while (flag3);
	}

	private unsafe static void Thrown(Piece p, Vector3 at, Vector3 faces, float r, int many, int channel, float big, System.Random rng)
	{
		//IL_0353: Invalid comparison between VT and I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0056: Expected VT, but got I4
		//IL_0076: Expected Obj, but got VT
		//IL_0096: Expected F4, but got I
		//IL_0525: Expected Obj, but got I4
		//IL_00bf: Expected VT, but got I4
		//IL_055d: Expected Obj, but got I4
		//IL_02bb: Invalid comparison between F8 and I
		//IL_031c: Expected Obj, but got I
		//IL_0324: Expected F8, but got Obj
		//IL_0334: Expected F4, but got I
		//IL_0344: Expected F8, but got I
		//IL_048d: Expected VT, but got Ref
		//IL_048d: Expected VT, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected VT, but got Unknown
		//IL_04a4: Invalid comparison between VT and I4
		//IL_04bd: Expected VT, but got F4
		//IL_04c5: Expected VT, but got Ref
		//IL_04d5: Expected Obj, but got I
		if (at < (object)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		double num6 = default;
		double num5 = num6;
		Vector3 at2 = (Vector3)0;
		float num8 = default;
		float num7 = num8;
		Vector3 vector = faces;
		double num10 = default;
		double num9 = num10;
		System.Random rng2 = (System.Random)at;
		double num12 = default;
		double num11 = num12;
		float num13 = big;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num14 = 0f;
		Vector3 vector2 = at;
		object obj8 = default;
		bool flag3;
		do
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector3 = Sideways((Vector3)many, rng2);
			int value = ((int*)many)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X8_v8 (System.Int32)+1B8] (should have been resolved before IL gen)");
			double num15 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			double num16 = num15 * 0.0;
			double num17 = num16 + 1.0;
			double num18 = num17 * num6;
			double num19 = num10 * num18;
			double num20 = (double)num8 * num18;
			double num21 = num2 * num18;
			float num22 = r + (float)num19;
			float num23 = big + (float)num20;
			double num24 = num12 + num21;
			Snap(p, ref at2, out var faces2);
			int value2 = ((int*)many)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X8_v9 (System.Int32)+1B8] (should have been resolved before IL gen)");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num25 = num10 * (double)faces2;
			float num26 = num8 * (float)obj8;
			double num27 = num25 + (double)num26;
			double num28 = num2 * 0.0;
			double num29 = num28 + num27;
			double num30 = (double)faces2 * num29;
			double num31 = (double)obj8 * num29;
			double num32 = 0.0 * num29;
			double num33 = num10 - num30;
			float num34 = num8 - (float)num31;
			double num35 = num2 - num32;
			double num36 = num33 * num33;
			float num37 = num34 * num34;
			double num38 = num36 + (double)num37;
			double num39 = num35 * num35;
			double num40 = num39 + num38;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			double num41;
			float num42;
			double num43;
			if (num40 > 0.0)
			{
				num41 = num33 / num40;
				num42 = num34 / (float)num40;
				num43 = num35 / num40;
			}
			else
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v15+A0]");
				object obj10 = 0;
				num41 = (double)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v16+4]");
				num42 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v16+8]");
				num43 = 0.0;
			}
			int value3 = ((int*)many)->m_value;
			double num44 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
			double num45 = num44 * 0.0;
			double num46 = num45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
			double num47 = num46 + 0.0;
			double num48 = num47 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X8_v14 (System.Int32)+1B8] (should have been resolved before IL gen)");
			double num49 = num48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			num3 = num49 * 0.0;
			double num50 = num47 * 3.5;
			double num51 = num50 + 1.0;
			double num52 = num48 * num51;
			double num53 = num41 * num52;
			double num54 = (double)num42 * num52;
			double num55 = num43 * num52;
			num9 = (double)num22 + num53;
			num7 = num23 + (float)num54;
			num = num24 + num55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (System.Int32)+1C0]");
			Add(faces, (Vector3)0, num22, num23, (Vector3)(&faces2), many);
			vector2--;
			flag3 = vector2 != (Vector3)(object)1;
			num5 = num48;
			at2 = (Vector3)num22;
			vector = (Vector3)(&faces2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v14 (System.Int32)+1C0]");
			rng2 = (System.Random)0;
			num11 = num24;
			num13 = num23;
			num14 = num22;
		}
		while (flag3);
	}

	private unsafe static void Runs(Piece p, Vector3 from, Vector3 faces, float r, float each, int steps, int channel, System.Random rng)
	{
		//IL_0580: Invalid comparison between VT and I4
		//IL_0714: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Expected VT, but got I4
		//IL_0046: Expected Obj, but got VT
		//IL_006e: Expected VT, but got F4
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected F4, but got I
		//IL_05ea: Expected F4, but got I
		//IL_0699: Invalid comparison between F4 and I
		//IL_0525: Expected VT, but got Obj
		//IL_0535: Expected F4, but got I
		//IL_0776: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I
		//IL_0142: Expected F4, but got Obj
		//IL_0152: Expected F4, but got I
		//IL_0162: Expected F4, but got I
		//IL_06c2: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I4
		//IL_0183: Expected VT, but got I4
		//IL_07ae: Expected Obj, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0270: Invalid comparison between F4 and I
		//IL_02d1: Expected Obj, but got I
		//IL_02d9: Expected F4, but got Obj
		//IL_02e9: Expected F4, but got I
		//IL_02f9: Expected F4, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03ef: Expected VT, but got Ref
		//IL_03ef: Expected VT, but got Ref
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected VT, but got Unknown
		//IL_040b: Invalid comparison between VT and I4
		//IL_0434: Expected VT, but got F4
		//IL_043c: Expected VT, but got Ref
		//IL_0444: Expected Obj, but got Ref
		//IL_047d: Expected F4, but got I4
		//IL_04b3: Expected VT, but got Ref
		//IL_04bb: Expected VT, but got Ref
		Vector3 vector = default;
		Vector3 faces2;
		float ra;
		float rb;
		float num4 = default;
		float num2 = default;
		if (vector >= (object)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4;
			Vector3 at = (Vector3)0;
			faces2 = faces;
			System.Random random = (System.Random)vector;
			float num = num2;
			float num3 = num4;
			float num6 = default;
			float num5 = num6;
			Vector3 vector2 = vector;
			float num7 = default;
			Vector3 vector3 = (Vector3)num7;
			float num9 = default;
			float num8 = num9;
			float num11 = default;
			float num10 = num11;
			object obj6 = default;
			object obj5 = obj6;
			float num58 = default;
			while (true)
			{
				object obj7 = obj;
				float num12 = (float)vector3 * num8;
				float num13 = num8 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v13+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+24]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+28]");
				num7 = 0f;
				float num14 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+24]");
				float num15 = num14 + 0f;
				float num16 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+28]");
				float num17 = num16 + 0f;
				float num18 = num8 * num10;
				float num19 = num18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+2C]");
				float num20 = num19 + 0f;
				float num21 = num15 * num15;
				float num22 = num17 * num17;
				float num23 = num21 + num22;
				num4 = num20 * num20;
				float num24 = num23 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				if (num24 < 0f)
				{
					obj4 = obj3;
					vector = (Vector3)random;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					num2 = 0f;
					ra = num;
					rb = num3;
					break;
				}
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num27;
				float num29;
				float num31;
				if (num25 > 0)
				{
					float num26 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					num27 = num26 / 0f;
					float num28 = num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					num29 = num28 / 0f;
					float num30 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					num31 = num30 / 0f;
				}
				else
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v29+A0]");
					object obj12 = 0;
					num27 = (float)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v30+4]");
					num29 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v30+8]");
					num31 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector3 vector4 = Sideways((Vector3)steps, random);
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Vector3 vector5 = vector3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				object obj18 = vector5 * 0;
				float num32 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num33 = num32 * 0f;
				float num34 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num35 = num34 * 0f;
				float num36 = num27 + (float)obj18;
				float num37 = num29 + num33;
				float num38 = num31 + num35;
				float num39 = num36 * num36;
				float num40 = num37 * num37;
				float num41 = num39 + num40;
				float num42 = num38 * num38;
				float num43 = num42 + num41;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num44;
				float num45;
				float num46;
				if (num43 > 0f)
				{
					num44 = num36 / num43;
					num45 = num37 / num43;
					num46 = num38 / num43;
				}
				else
				{
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v27+A0]");
					object obj20 = 0;
					num44 = (float)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v28+4]");
					num45 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v28+8]");
					num46 = 0f;
				}
				int value = ((int*)steps)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ X8_v26 (System.Int32)+1B8] (should have been resolved before IL gen)");
				float num47 = num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE4]");
				float num48 = num47 * 0f;
				float num49 = num48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				float num50 = num49 + 0f;
				float num51 = num50 * (float)obj4;
				float num52 = num44 * num51;
				float num53 = num45 * num51;
				float num54 = num46 * num51;
				float num55 = num + num52;
				float num56 = num3 + num53;
				float num57 = num5 + num54;
				Snap(p, ref at, out var faces3);
				object obj21 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF88]");
				object obj22 = obj21 * 0;
				Add(faces, (Vector3)(&at), num, num3, (Vector3)(&faces3), steps);
				vector2--;
				bool flag4 = vector2 != (Vector3)(object)1;
				obj3 = obj22;
				num11 = num57;
				obj6 = obj5;
				at = (Vector3)num55;
				faces2 = (Vector3)(&faces3);
				random = (System.Random)(&at);
				num9 = num56;
				num = num55;
				num3 = num56;
				num5 = num57;
				vector3 = faces3;
				num8 = num58;
				num10 = 0f;
				obj5 = obj22;
				if (!flag4)
				{
					obj4 = obj22;
					num11 = num57;
					obj6 = obj22;
					faces2 = (Vector3)(&faces3);
					vector = (Vector3)(&at);
					num9 = num56;
					num7 = num55;
					num6 = num57;
					num4 = num56;
					num2 = num55;
					ra = num55;
					rb = num56;
					break;
				}
			}
		}
		else
		{
			faces2 = faces;
			ra = num2;
			rb = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Add(faces, vector, ra, rb, faces2, steps);
	}

	private unsafe static void Scratched(Job j, System.Random rng)
	{
		//IL_0c1e: Expected VT, but got I4
		//IL_0c28: Expected VT, but got I4
		//IL_0c32: Expected VT, but got I4
		//IL_0c3b: Expected VT, but got I4
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got I4
		//IL_0046: Expected VT, but got I4
		//IL_0050: Expected VT, but got I4
		//IL_0059: Expected VT, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected F8, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected VT, but got I4
		//IL_038b: Expected VT, but got I4
		//IL_0395: Expected VT, but got I4
		//IL_039d: Expected VT, but got Obj
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected F8, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got I4
		//IL_03e1: Expected VT, but got F8
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10da: Expected Ref, but got Unknown
		//IL_10f4: Expected Obj, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Invalid comparison between Unknown and I4
		//IL_0416: Expected Obj, but got I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between VT and I4
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected F8, but got Unknown
		//IL_0ae6: Expected VT, but got F8
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got I
		//IL_0afd: Expected VT, but got I4
		//IL_0b07: Expected VT, but got I4
		//IL_0b11: Expected VT, but got I4
		//IL_0b19: Expected VT, but got Obj
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected Obj, but got I4
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got VT
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Expected F8, but got Unknown
		//IL_1125: Expected VT, but got F8
		//IL_05b6: Expected Obj, but got I
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got VT
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_0d51: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected VT, but got Obj
		//IL_06ac: Expected Obj, but got Ref
		//IL_06b5: Expected Obj, but got I4
		//IL_06cd: Expected F8, but got I
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got I4
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected I, but got Obj
		//IL_0781: Invalid comparison between F8 and I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_07a2: Expected Obj, but got F8
		//IL_07d7: Expected Obj, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0804: Expected F8, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected VT, but got I
		//IL_0dc0: Invalid comparison between F8 and I4
		//IL_0dcf: Invalid comparison between F8 and I4
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected Obj, but got Unknown
		//IL_0df0: Expected Obj, but got F8
		//IL_0e25: Expected Obj, but got I4
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected Obj, but got Unknown
		//IL_081f: Expected F8, but got I4
		//IL_0e58: Expected VT, but got Ref
		//IL_0e58: Expected Obj, but got I
		//IL_0ea3: Expected Obj, but got I4
		//IL_0eac: Expected Obj, but got I4
		//IL_0ec4: Expected F8, but got I
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1051: Expected Obj, but got Unknown
		//IL_1069: Invalid comparison between F8 and I4
		//IL_1078: Expected F8, but got I4
		//IL_0ee8: Expected Obj, but got VT
		//IL_0f05: Expected Obj, but got I
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Expected Obj, but got Unknown
		//IL_0f6c: Expected Obj, but got I4
		//IL_088a: Expected I, but got Obj
		//IL_0899: Expected VT, but got Ref
		//IL_0899: Expected Obj, but got I
		//IL_0fa9: Expected Obj, but got I4
		//IL_0fdd: Expected VT, but got Ref
		//IL_0fdd: Expected F4, but got VT
		//IL_0fdd: Expected VT, but got I
		//IL_0fdd: Expected VT, but got I4
		//IL_0fe5: Expected I, but got Obj
		//IL_0ff5: Expected VT, but got I
		//IL_1004: Expected VT, but got Ref
		//IL_1004: Expected Obj, but got I
		//IL_1014: Invalid comparison between VT and I
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected Obj, but got Unknown
		//IL_0a54: Invalid comparison between F8 and Obj
		//IL_0a66: Expected Obj, but got I4
		//IL_09da: Expected Obj, but got I4
		//IL_0a29: Expected VT, but got Ref
		//IL_0a29: Expected F4, but got VT
		//IL_0a29: Expected VT, but got I4
		bool flag = j == null;
		Vector3 vector = (Vector3)0;
		Vector3 at = (Vector3)0;
		Vector3 vector2 = (Vector3)0;
		Vector3 faces = (Vector3)0;
		Enumerator<, > val2 = default;
		Enumerator<, > val = val2;
		Enumerator<, > val3 = (Enumerator<, >)0;
		System.Random random = rng;
		Piece piece = (Piece)109891584;
		if (!flag)
		{
			object obj = j + 44;
			Enumerator<, > val4 = (Enumerator<, >)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v1-14]");
			bool flag2 = (nint)0 == 0;
			vector = (Vector3)0;
			at = (Vector3)0;
			vector2 = (Vector3)0;
			faces = (Vector3)0;
			val = val2;
			val3 = (Enumerator<, >)0;
			random = rng;
			piece = (Piece)109891584;
			if (!flag2)
			{
				object obj2 = obj + -12;
				object obj3 = obj2 + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v1-4]");
				double num = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v1+8]");
				double num2 = num + 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8720]");
				object obj5 = 0;
				object obj6 = obj3 * 63;
				double num3 = num2 * 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v1-14]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Enumerator<, > val5 = (Enumerator<, >)2139095039;
				double num4 = 0.0;
				object obj7 = 0;
				Enumerator<, > val6 = (Enumerator<, >)(ref val3);
				Enumerator<, > val7 = default;
				val4 = val7;
				piece = null;
				object obj20 = default;
				object obj55 = default;
				Vector3 at2 = default;
				float rb = default;
				int channel = default;
				float rb2 = default;
				while (true)
				{
					random = (System.Random)obj4;
					Enumerator<, > val8;
					double num5;
					Vector3 vector3;
					if (val3.MoveNext())
					{
						if ((int)val2 != 0)
						{
							val6 = (Enumerator<, >)val2._current;
							if (val2._current == (_00210)(object)0)
							{
								goto IL_0ab1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X9_v18 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+40]");
							val6 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X9_v18 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+40]");
							if ((nint)0 != 0)
							{
								if (val6._index < 1)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-128 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+30]");
								object obj8 = 0;
								object obj9 = 0;
								while (true)
								{
									bool flag3 = val6._index == (nint)obj9;
									num5 = (double)val5;
									vector3 = (Vector3)num2;
									if (flag3)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-128 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+30]");
									if ((nint)0 == 0)
									{
										goto IL_0abf;
									}
									object obj10 = val6 + obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X13_v10+20]");
									object obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X13_v10+20]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X11_v6+18]");
									bool flag4 = num6 < 0;
									object obj12 = !flag4;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X13_v10+20]");
										object obj13 = (nint)0 * (nint)12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-128 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+30]");
										obj11 = 0 + obj13;
										obj9++;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X13_v6+20]");
										obj7 = 0 - obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X13_v6+28]");
										num4 = 0.0 - num3;
										object obj14 = obj7 * obj7;
										num2 = num4 * num4;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										val4 = (Enumerator<, >)(obj14 + num2);
										val8 = ((val4 >= val5) ? val5 : val4);
										if (val4 < val5)
										{
											piece = (Piece)val2;
										}
										bool flag5 = val6._index != (nint)obj9;
										val5 = val8;
										if (flag5)
										{
											continue;
										}
										goto IL_036b;
									}
									goto IL_0acd;
								}
								goto IL_0aeb;
							}
							NullReferenceException ex = new NullReferenceException();
						}
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_0ab1;
					}
					vector = (Vector3)0;
					at = (Vector3)0;
					vector2 = (Vector3)0;
					faces = (Vector3)obj7;
					val = (Enumerator<, >)0;
					object obj15 = 0;
					num5 = (double)val5;
					val3 = val7;
					object obj16 = 7;
					Enumerator<, > val9 = (Enumerator<, >)(ref val3);
					object obj17 = 0;
					vector3 = (Vector3)num2;
					double num7 = 0.5;
					Enumerator<, > val10 = (Enumerator<, >)63;
					while (true)
					{
						random = (System.Random)obj5;
						((Enumerator<, >*)val9)->Dispose();
						bool flag6 = obj17 == null;
						object obj18 = !flag6;
						if (obj18 == null)
						{
							bool flag7 = (int)val == 0;
							object obj19 = !flag7;
							OutOfMemoryException ex3 = (OutOfMemoryException)val9;
							if (obj19 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)random == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							val = (Enumerator<, >)1;
							obj17 = obj15;
						}
						else
						{
							if ((nint)random != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E970");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj17 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj15 = obj20;
						}
						obj16 = 0;
					}
					if ((nint)obj16 != 7)
					{
						bool flag8 = obj16 == null;
						object obj21 = !flag8;
						if (obj21 != null)
						{
							return;
						}
					}
					Vector3 vector4 = j.to - j.point;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+34]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
					object obj22 = num8 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X0_v6+E4]");
					if ((nint)0 != 0)
					{
						bool flag9 = piece == null;
						object obj25 = !flag9;
						if (obj25 == null)
						{
							return;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						if (piece == null)
						{
							return;
						}
					}
					object obj26 = vector4 * vector4;
					object obj27 = obj22 * obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					object obj28 = obj26 + obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num9 = (double)obj28 * 0.5;
					float num10 = j.big;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					float num11 = num10 * 0f;
					double num12 = num9 + (double)num11;
					double num13 = num12 * num12;
					if (num5 > num13)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					object obj29 = 0;
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v1+8]");
					val6 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v8+E4]");
					bool flag10 = (nint)0 == 0;
					object obj31 = !flag10;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Snap(piece, ref vector2, out vector);
					Snap(piece, ref at, out faces);
					obj6 = at - vector2;
					double num14 = (double)val6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X25_v7+8]");
					num5 = num14 - 0.0;
					object obj32 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v13+E4]");
					bool flag11 = (nint)0 == 0;
					object obj33 = !flag11;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num3 = j.radius;
					object obj34 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X0_v16+E4]");
					bool flag12 = (nint)0 == 0;
					object obj35 = !flag12;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = rng == null;
					faces = (Vector3)obj6;
					random = (System.Random)(&at);
					obj5 = 109891584;
					vector3 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X25_v7+8]");
					num7 = 0.0;
					val10 = val6;
					val4 = (Enumerator<, >)at;
					obj = 109891584;
					if (flag13)
					{
						break;
					}
					object obj36 = obj6 * obj6;
					double num15 = num5 * num5;
					nint num16 = (nint)rng;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num17 = (double)obj36 + num15;
					double num18 = num3 * 3.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num19 = num17 / num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					double num20 = num19 - 16.0;
					bool flag14 = num20 < 0.0;
					object obj37 = num19 ^ 0x10;
					object obj38 = num19 ^ num20;
					object obj39 = obj37 & obj38;
					bool flag15 = (nint)obj39 < 0;
					bool flag16 = flag14 == flag15;
					object obj40 = !flag16;
					object obj41 = ~obj40;
					double num21 = ((obj41 != null) ? 16.0 : num19);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X10_v4 (Il2CppClass<System.Random>)+1C0]");
					Vector3 vector5 = (Vector3)0;
					double num22 = num21 - 1.0;
					bool flag17 = num22 < 0.0;
					bool flag18 = num22 == 0.0;
					object obj42 = num21 ^ 1;
					object obj43 = num21 ^ num22;
					object obj44 = obj42 & obj43;
					bool flag19 = (nint)obj44 < 0;
					bool flag20 = flag17 == flag19;
					object obj45 = !flag18;
					object obj46 = flag20 & obj45;
					object obj47 = ~obj46;
					double num23 = ((obj47 != null) ? 1.0 : num21);
					((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)(&faces));
					double num24 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					double num25 = num24 * 0.0;
					double num26 = num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
					double num27 = num26 + 0.0;
					double num28 = (double)j.radius * num27;
					object obj48 = 0;
					object obj49 = 0;
					nint num29 = (nint)(&faces);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X25_v7+8]");
					double num30 = 0.0;
					bool flag28;
					do
					{
						object obj50 = obj49 + 1;
						double num31 = (double)obj50 / num23;
						bool flag21 = num31 < 0.0;
						double num32 = 0.0;
						if (!flag21)
						{
							bool flag22 = !(num31 > 1.0);
							num32 = num31;
							if (!flag22)
							{
								num32 = 1.0;
							}
						}
						object obj51 = obj29;
						object obj52 = j.to - j.point;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+34]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
						object obj53 = num33 - 0;
						object obj54 = obj52 * obj55;
						double num34 = (double)obj53 * num32;
						object obj56 = j.point + obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
						double num35 = 0.0 + num34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X0_v21+E4]");
						bool flag23 = (nint)0 == 0;
						object obj57 = !flag23;
						if (obj57 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Snap(piece, ref at2, out var faces2);
						nint num36 = (nint)rng;
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)(&faces2));
						double num37 = j.radius;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						double num38 = num37 * 0.0;
						double num39 = num35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A968]");
						double num40 = num39 * 0.0;
						double num41 = num40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						double num42 = num41 + 0.0;
						double num43 = num28 * num42;
						if (!(num43 < num38))
						{
							double num44 = j.radius;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
							double num45 = num44 * 0.0;
							bool flag24 = !(num43 > num45);
							num38 = num43;
							if (!flag24)
							{
								num38 = num45;
							}
						}
						object obj58 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X0_v28+E4]");
						bool flag25 = (nint)0 == 0;
						object obj59 = !flag25;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj60 = obj48 * obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						if ((nint)obj60 > 0)
						{
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v27 (Il2CppClass<System.Random>)+1C0]");
						Add((Vector3)0, (Vector3)0, (float)vector2, rb, (Vector3)(&faces2), channel);
						nint num46 = (nint)rng;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X8_v32 (Il2CppClass<System.Random>)+1C0]");
						vector5 = (Vector3)0;
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)(&faces2));
						Vector3 vector6 = vector2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C5E8]");
						bool flag26 = vector6 >= (object)0;
						double num47 = num38;
						double num48 = num28;
						double num49 = num35;
						if (!flag26)
						{
							object obj61 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1359 @ X0_v34+E4]");
							bool flag27 = (nint)0 == 0;
							object obj62 = !flag27;
							if (obj62 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num48 = num38 * 1.5;
							Add((Vector3)0, vector5, (float)at2, rb2, (Vector3)(&faces2), channel);
							num47 = num48;
							num49 = num35;
						}
						obj49++;
						flag28 = (object)num23 != obj49;
						obj48 = 0;
						num29 = (nint)(&faces2);
						num30 = num35;
						vector2 = at2;
						num28 = num38;
					}
					while (flag28);
					return;
					IL_036b:
					val5 = val8;
					continue;
					IL_0acd:
					IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
					num5 = (double)val5;
					vector3 = (Vector3)num2;
					goto IL_0aeb;
					IL_0ab1:
					NullReferenceException ex5 = new NullReferenceException();
					goto IL_0abf;
					IL_0abf:
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_0acd;
					IL_0aeb:
					IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
					vector = (Vector3)0;
					at = (Vector3)0;
					vector2 = (Vector3)0;
					faces = (Vector3)obj7;
					val = (Enumerator<, >)0;
					obj15 = 0;
					val3 = val7;
					val9 = (Enumerator<, >)(ref val3);
					num7 = 0.5;
					val10 = (Enumerator<, >)63;
					break;
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static void Landed(Job j, System.Random rng)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_1431: Expected VT, but got Obj
		//IL_0025: Expected F4, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected F4, but got I
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_146d: Expected VT, but got Obj
		//IL_147a: Expected F4, but got VT
		//IL_005a: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected F4, but got I
		//IL_00b3: Expected F4, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected F4, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected F4, but got I4
		//IL_1490: Expected VT, but got Obj
		//IL_0497: Expected Obj, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected F4, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got I4
		//IL_1abf: Expected VT, but got Obj
		//IL_1abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Expected Ref, but got Unknown
		//IL_1ae2: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got F4
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected F4, but got Unknown
		//IL_04e6: Expected Obj, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected F4, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_1b1d: Invalid comparison between VT and I4
		//IL_1395: Invalid comparison between VT and I4
		//IL_0543: Expected Obj, but got I4
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Expected F4, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected F4, but got Obj
		//IL_1300: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_1312: Expected Obj, but got I4
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Expected Obj, but got I4
		//IL_1387: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_13dd: Expected VT, but got F4
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b00: Invalid comparison between Unknown and Obj
		//IL_1507: Expected Obj, but got I
		//IL_1531: Expected Obj, but got I4
		//IL_0643: Invalid comparison between F4 and I
		//IL_0655: Expected F4, but got I4
		//IL_065e: Expected F4, but got I4
		//IL_0667: Expected F4, but got I4
		//IL_154f: Expected Obj, but got I
		//IL_0e8f: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_0eca: Expected F4, but got VT
		//IL_0eca: Expected VT, but got Obj
		//IL_0eca: Expected VT, but got I4
		//IL_0ee1: Expected I, but got Obj
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected F4, but got VT
		//IL_0f3a: Expected VT, but got I4
		//IL_0f42: Expected F4, but got VT
		//IL_06c9: Expected Obj, but got I4
		//IL_071b: Expected F4, but got VT
		//IL_071b: Expected VT, but got Obj
		//IL_071b: Expected VT, but got I4
		//IL_0729: Expected Obj, but got I4
		//IL_0729: Expected VT, but got Obj
		//IL_0288: Expected Obj, but got I
		//IL_02aa: Expected F4, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected VT, but got I4
		//IL_0f90: Expected I4, but got Obj
		//IL_0f90: Expected I4, but got Obj
		//IL_0f90: Expected F4, but got VT
		//IL_0f90: Expected VT, but got I4
		//IL_0f98: Expected I, but got Obj
		//IL_0749: Expected I, but got Obj
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected VT, but got I4
		//IL_07a2: Expected F4, but got VT
		//IL_07ab: Expected Obj, but got I4
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Expected Obj, but got Unknown
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d0: Invalid comparison between Unknown and Obj
		//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected F4, but got Unknown
		//IL_0ff2: Expected VT, but got I4
		//IL_0ffb: Expected VT, but got I4
		//IL_103b: Expected F4, but got I
		//IL_1044: Expected Obj, but got I4
		//IL_07c8: Expected VT, but got Obj
		//IL_07c8: Expected Obj, but got I
		//IL_0877: Expected VT, but got Obj
		//IL_0877: Expected VT, but got I4
		//IL_1a81: Expected Obj, but got I4
		//IL_0889: Expected VT, but got I4
		//IL_08af: Expected I4, but got Obj
		//IL_08af: Expected I4, but got Obj
		//IL_08af: Expected F4, but got VT
		//IL_08af: Expected VT, but got I4
		//IL_08bc: Expected VT, but got I4
		//IL_0906: Expected I4, but got Obj
		//IL_0906: Expected I4, but got Obj
		//IL_0906: Expected VT, but got I4
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected F4, but got Obj
		//IL_03a1: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected VT, but got Obj
		//IL_1080: Expected Obj, but got I
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected VT, but got Unknown
		//IL_0913: Expected I, but got Obj
		//IL_0948: Expected Obj, but got I4
		//IL_113a: Expected VT, but got Ref
		//IL_113a: Expected Obj, but got I
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected Obj, but got Unknown
		//IL_117b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1180: Expected Obj, but got Unknown
		//IL_11c3: Invalid comparison between F4 and I4
		//IL_11d2: Invalid comparison between F4 and I4
		//IL_11e5: Expected Obj, but got F4
		//IL_11f2: Expected Obj, but got F4
		//IL_1227: Expected Obj, but got I4
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Expected Obj, but got Unknown
		//IL_0bea: Expected I, but got Obj
		//IL_03d5: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected F4, but got I
		//IL_0417: Expected F4, but got I
		//IL_0427: Expected VT, but got I
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected VT, but got I4
		//IL_09b3: Expected VT, but got I4
		//IL_09c4: Expected Obj, but got I4
		//IL_09f4: Expected F4, but got I
		//IL_09fd: Expected Obj, but got I4
		//IL_190c: Invalid comparison between F4 and I4
		//IL_191b: Invalid comparison between F4 and I4
		//IL_192e: Expected Obj, but got F4
		//IL_193b: Expected Obj, but got F4
		//IL_1970: Expected Obj, but got I4
		//IL_1978: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Expected Obj, but got Unknown
		//IL_0c5b: Expected VT, but got I4
		//IL_0c64: Expected VT, but got I4
		//IL_0c74: Expected F4, but got I
		//IL_0c8c: Expected F4, but got I
		//IL_0c95: Expected Obj, but got I4
		//IL_174b: Expected Obj, but got I4
		//IL_18e6: Expected Obj, but got I4
		//IL_0a26: Expected VT, but got Obj
		//IL_0a39: Expected Obj, but got I
		//IL_19a1: Expected VT, but got I4
		//IL_19c7: Expected I4, but got Obj
		//IL_19c7: Expected I4, but got Obj
		//IL_19c7: Expected F4, but got VT
		//IL_19c7: Expected VT, but got I4
		//IL_19ff: Expected I4, but got Obj
		//IL_1a08: Expected VT, but got I4
		//IL_1a19: Expected F4, but got I4
		//IL_1a29: Expected F4, but got VT
		//IL_1a41: Expected F4, but got VT
		//IL_1a49: Expected Obj, but got VT
		//IL_0cbe: Expected VT, but got Obj
		//IL_0cd1: Expected Obj, but got I
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected Obj, but got Unknown
		//IL_0b33: Invalid comparison between F4 and I4
		//IL_0b42: Invalid comparison between F4 and I4
		//IL_0b55: Expected Obj, but got F4
		//IL_0b62: Expected Obj, but got F4
		//IL_0b97: Expected Obj, but got I4
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected Obj, but got Unknown
		//IL_0dac: Invalid comparison between F4 and I4
		//IL_0dbb: Invalid comparison between F4 and I4
		//IL_0dce: Expected Obj, but got F4
		//IL_0ddb: Expected Obj, but got F4
		//IL_0e10: Expected Obj, but got I4
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected Obj, but got Unknown
		//IL_15ad: Invalid comparison between F4 and I4
		//IL_15bc: Invalid comparison between F4 and I4
		//IL_15cf: Expected Obj, but got F4
		//IL_15dc: Expected Obj, but got F4
		//IL_1611: Expected Obj, but got I4
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Expected Obj, but got Unknown
		//IL_1771: Invalid comparison between F4 and I4
		//IL_1780: Invalid comparison between F4 and I4
		//IL_1793: Expected Obj, but got F4
		//IL_17a0: Expected Obj, but got F4
		//IL_17d5: Expected Obj, but got I4
		//IL_17dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e2: Expected Obj, but got Unknown
		//IL_1642: Expected VT, but got I4
		//IL_1668: Expected I4, but got Obj
		//IL_1668: Expected I4, but got Obj
		//IL_1668: Expected VT, but got I4
		//IL_16a1: Expected Obj, but got I4
		//IL_16b9: Expected VT, but got F8
		//IL_16c9: Expected I4, but got Obj
		//IL_16d2: Expected VT, but got I4
		//IL_16e3: Expected Obj, but got I4
		//IL_1713: Expected Obj, but got VT
		//IL_1806: Expected VT, but got I4
		//IL_182c: Expected I4, but got Obj
		//IL_182c: Expected I4, but got Obj
		//IL_182c: Expected VT, but got I4
		//IL_1854: Expected VT, but got F4
		//IL_1864: Expected I4, but got Obj
		//IL_186d: Expected VT, but got I4
		//IL_187e: Expected Obj, but got I4
		//IL_18ae: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDD4D]");
		Shape shape = (Shape)0;
		bool flag = j == null;
		Shape shape3 = default;
		Shape shape2 = shape3;
		Enumerator<, > val = (Enumerator<, >)0;
		Vector3 vector = (Vector3)rng;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+24]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A0]");
			shape = (Shape)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
			float num2 = 0f;
			bool flag2 = j.pieces == null;
			shape2 = shape3;
			val = (Enumerator<, >)0;
			vector = (Vector3)rng;
			float num3 = (float)j.point;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v57+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8720]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v58+1C]");
				float num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v58+20]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v58+18]");
				object obj6 = 0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)j.pieces).GetEnumerator();
				Vector3 vector2 = j.point;
				float num5 = 2.139095E+09f;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = val3;
				Enumerator<, > val4 = (Enumerator<, >)(ref val);
				float num6 = 2.139095E+09f;
				Piece piece = null;
				float num13 = default;
				object obj19 = default;
				int channel = default;
				System.Random random = default;
				Vector3 at2 = default;
				System.Random rng2 = default;
				object obj29 = default;
				object obj46 = default;
				object obj50 = default;
				float num97 = default;
				object obj63 = default;
				Enumerator<, > val5 = default;
				float num129 = default;
				while (true)
				{
					vector = (Vector3)obj4;
					float num11;
					float num12;
					if (val.MoveNext())
					{
						bool flag3 = shape3 == null;
						shape = (Shape)num6;
						if (!flag3)
						{
							shape = ((Piece)(object)shape3).shape;
							if (((Piece)(object)shape3).shape == null)
							{
								goto IL_129c;
							}
							shape = (Shape)(object)shape.fur;
							if (shape.fur != null)
							{
								val4 = (Enumerator<, >)shape.faces;
								bool flag4 = (nint)shape.faces < 1;
								num6 = (float)shape.fur;
								if (flag4)
								{
									continue;
								}
								Vector3[] at = ((Piece)(object)shape3).at;
								object obj7 = 0;
								float num7 = num5;
								float num8 = num2;
								while ((object)val4 != obj7)
								{
									if (((Piece)(object)shape3).at != null)
									{
										object obj8 = (object)shape + obj7;
										Vector3[] array = (Vector3[])at.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X12_v12+20]");
										object obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X12_v12+20]");
										bool flag5 = (nint)0 < (nint)at.Length;
										object obj10 = !flag5;
										if (obj10 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X12_v12+20]");
											object obj11 = (nint)0 * (nint)12;
											array = (Vector3[])(object)((object)((Piece)(object)shape3).at + obj11);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+28]");
											num2 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
											object obj12 = 0 - j.point;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+28]");
											float num9 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
											float num10 = num9 - 0f;
											val2 = (Enumerator<, >)(obj12 * obj12);
											num11 = num10 * num10;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											num5 = (float)val2 + num11;
											if (num5 < num7)
											{
												array = ((Piece)(object)shape3).faces;
												bool flag6 = ((Piece)(object)shape3).faces == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
												val5 = (Enumerator<, >)0;
												num12 = (float)val2;
												if (flag6)
												{
													goto IL_12ea;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X12_v12+20]");
												bool flag7 = (nint)0 < (nint)array.Length;
												object obj13 = !flag7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
												val5 = (Enumerator<, >)0;
												if (obj13 != null)
												{
													goto IL_12d4;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X12_v12+20]");
												object obj14 = (nint)0 * (nint)12;
												obj9 = (object)((Piece)(object)shape3).faces + obj14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X12_v14+20]");
												obj6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X12_v14+24]");
												num4 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X12_v14+28]");
												num3 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
												vector2 = (Vector3)0;
												num7 = num5;
												num8 = num2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
												val2 = (Enumerator<, >)0;
												num = num13;
												piece = (Piece)(object)shape3;
											}
											else
											{
												num5 = num7;
												num2 = num8;
											}
											obj7++;
											bool flag8 = (object)val4 != obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
											val5 = (Enumerator<, >)0;
											if (flag8)
											{
												continue;
											}
											goto IL_0471;
										}
										goto IL_12aa;
									}
									goto IL_12c6;
								}
								goto IL_12b8;
							}
							NullReferenceException ex = new NullReferenceException();
						}
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_129c;
					}
					Piece piece2 = (Piece)7;
					shape2 = null;
					val = val3;
					object obj15 = 0;
					num12 = (float)val2;
					Enumerator<, > val6 = (Enumerator<, >)(ref val);
					object obj16 = 0;
					Piece piece3;
					while (true)
					{
						vector = (Vector3)obj5;
						((Enumerator<, >*)val6)->Dispose();
						bool flag9 = obj16 == null;
						object obj17 = !flag9;
						piece3 = piece2;
						float num14;
						if (obj17 == null)
						{
							bool flag10 = shape2 == null;
							object obj18 = !flag10;
							num14 = (float)val5;
							piece3 = piece2;
							OutOfMemoryException ex3 = (OutOfMemoryException)val6;
							if (obj18 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
							num14 = (float)val5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if (vector == (Vector3)(object)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							shape2 = (Shape)1;
							obj16 = obj15;
							shape = (Shape)1;
						}
						else
						{
							if (vector != (Vector3)(object)1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E970");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj16 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj15 = obj19;
						}
						vector2 = (Vector3)num14;
						val5 = (Enumerator<, >)num14;
						piece2 = null;
						num12 = num14;
						num = num13;
						piece = piece3;
					}
					if ((nint)piece2 != 7)
					{
						bool flag11 = piece2 == null;
						object obj20 = !flag11;
						if (obj20 != null)
						{
							return;
						}
					}
					if (piece == null)
					{
						return;
					}
					float num15 = j.big;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					float num16 = num15 * 0f;
					float num17 = j.radius + num16;
					float num18 = num17 * num17;
					if (num5 > num18)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X0_v6+E4]");
					bool flag12 = (nint)0 == 0;
					object obj23 = !flag12;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj24 = obj6 * obj6;
					float num19 = num4 * num4;
					float num20 = num19 + (float)obj24;
					float num21 = num3 * num3;
					float num22 = num21 + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					bool flag13 = !(num22 > 0f);
					float num23 = 0f;
					float num24 = 0f;
					float num25 = 0f;
					if (!flag13)
					{
						num24 = (float)obj6 / num22;
						num23 = num4 / num22;
						num25 = num3 / num22;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					obj5 = 0;
					float num26 = j.radius;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					num4 = num26 * 0f;
					object obj25 = obj5;
					nint num29;
					float num28;
					float num30;
					float num31;
					float num32;
					float num33;
					if (j.stuff != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X0_v8+E4]");
						bool flag14 = (nint)0 == 0;
						object obj26 = !flag14;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num27 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC48]");
						num28 = num27 * 0f;
						Lobed(piece, (Vector3)2, (Vector3)rng, (float)vector2, channel, random);
						Vector3 vector3 = Sideways((Vector3)rng, (System.Random)2);
						bool flag15 = rng == null;
						num29 = (nint)rng;
						num30 = num25;
						num31 = num23;
						num32 = num24;
						num33 = num25;
						val5 = (Enumerator<, >)num4;
						num11 = num23;
						piece3 = piece2;
						num5 = num;
						num12 = num24;
						vector = (Vector3)2;
						num3 = (float)vector2;
						shape = (Shape)17276928;
						if (flag15)
						{
							break;
						}
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)rng);
						float num34 = num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
						float num35 = num34 * 0f;
						float num36 = num4 * num35;
						float num37 = num24 * num36;
						float num38 = num23 * num36;
						float num39 = num25 * num36;
						float num40 = (float)vector2 + num37;
						float big = num + num38;
						float num41 = num2 + num39;
						Snap(piece, ref at2, out var faces);
						Lobed(piece, (Vector3)1, (Vector3)rng, num40, channel, random);
						Vector3 at3 = (Vector3)rng.GetHashCode();
						Thrown(piece, at3, (Vector3)2, (float)vector2, (int)rng, (int)random, num, rng2);
						Vector3 at4 = (Vector3)rng.GetHashCode();
						float big2 = j.big;
						float num42 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num43 = num42 * 0f;
						Thrown(piece, at4, (Vector3)1, num40, (int)rng, (int)random, big, rng2);
						nint num44 = (nint)rng;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1465 @ X8_v32 (Il2CppClass<System.Random>)+1A0]");
						int num45 = 0;
						int hashCode = rng.GetHashCode();
						bool flag16 = hashCode < 1;
						object obj27 = 0;
						object obj28 = obj29;
						Vector3 vector4 = faces;
						if (!flag16)
						{
							float num46 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
							float num47 = num46 * 0f;
							float num48 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							float num49 = num48 * 0f;
							Vector3 at5 = (Vector3)0;
							float big3 = j.big;
							Vector3 context = (Vector3)4;
							float num50 = num43;
							object obj30 = 0;
							object obj31 = obj29;
							Vector3 vector5 = faces;
							float num51 = num47;
							float num52 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
							float num53 = 0f;
							System.Random rng3 = (System.Random)2;
							int num54 = hashCode;
							bool flag26;
							do
							{
								object obj32 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1659 @ X0_v63+E4]");
								bool flag17 = (nint)0 == 0;
								object obj33 = !flag17;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Vector3 vector6 = Sideways((Vector3)rng, rng3);
								((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)context);
								double num55 = (double)num24 * 0.5;
								double num56 = num55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
								double num57 = num56 + 0.0;
								double num58 = (double)num4 * num57;
								double num59 = (double)num24 * num58;
								double num60 = (double)num23 * num58;
								double num61 = (double)num25 * num58;
								double num62 = (double)vector2 + num59;
								double num63 = (double)num2 + num61;
								double num64 = (double)num + num60;
								Snap(piece, ref at5, out var faces2);
								float num65 = j.big;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
								float num66 = num65 * 0f;
								float num67 = j.big;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
								float num68 = num67 * 0f;
								float num69 = num47 - num66;
								bool flag18 = num69 < 0f;
								bool flag19 = num69 == 0f;
								object obj34 = num47 ^ num66;
								object obj35 = num47 ^ num69;
								object obj36 = obj34 & obj35;
								bool flag20 = (nint)obj36 < 0;
								bool flag21 = flag18 == flag20;
								object obj37 = !flag19;
								object obj38 = flag21 & obj37;
								object obj39 = ~obj38;
								if (obj39 == null)
								{
									num66 = num47;
								}
								float num70 = num49 - num68;
								bool flag22 = num70 < 0f;
								bool flag23 = num70 == 0f;
								object obj40 = num49 ^ num68;
								object obj41 = num49 ^ num70;
								object obj42 = obj40 & obj41;
								bool flag24 = (nint)obj42 < 0;
								bool flag25 = flag22 == flag24;
								object obj43 = !flag23;
								object obj44 = flag25 & obj43;
								object obj45 = ~obj44;
								float num71 = ((obj45 != null) ? num68 : num49);
								Vector3 vector7 = (Vector3)rng.GetHashCode();
								Runs(piece, vector7, (Vector3)2, (float)num62, (float)num64, (int)rng, (int)random, rng2);
								num54--;
								flag26 = num54 != 1;
								big2 = num71;
								num43 = num66;
								obj27 = 0;
								obj28 = obj46;
								vector4 = faces2;
								at5 = (Vector3)num62;
								big3 = num71;
								num45 = (int)rng;
								context = (Vector3)2;
								num50 = num66;
								obj30 = 0;
								obj31 = obj46;
								vector5 = faces2;
								num51 = (float)num63;
								num52 = (float)num64;
								num53 = (float)num62;
								rng3 = (System.Random)vector7;
							}
							while (flag26);
						}
						nint num72 = (nint)rng;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ X8_v34 (Il2CppClass<System.Random>)+1A0]");
						int num73 = 0;
						int hashCode2 = rng.GetHashCode();
						if (hashCode2 < 1)
						{
							return;
						}
						float num74 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
						float num75 = num74 * 0f;
						float num76 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
						float num77 = num76 * 0f;
						Vector3 at6 = (Vector3)0;
						Vector3 context2 = (Vector3)3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
						float num78 = 0f;
						float num79 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
						float num80 = 0f;
						System.Random rng4 = (System.Random)1;
						int num81 = hashCode2;
						bool flag36;
						do
						{
							object obj47 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1723 @ X0_v51+E4]");
							bool flag27 = (nint)0 == 0;
							object obj48 = !flag27;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Vector3 vector8 = Sideways((Vector3)rng, rng4);
							((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)context2);
							double num82 = (double)faces * 0.25;
							double num83 = num82;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
							double num84 = num83 + 0.0;
							double num85 = (double)num4 * num84;
							object obj49 = faces * obj50;
							double num86 = 0.0 * num85;
							float num87 = num40 + (float)obj49;
							float num88 = num41 + (float)num86;
							Snap(piece, ref at6, out var faces3);
							float num89 = j.big;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							float num90 = num89 * 0f;
							float num91 = j.big;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
							float num92 = num91 * 0f;
							float num93 = num75 - num90;
							bool flag28 = num93 < 0f;
							bool flag29 = num93 == 0f;
							object obj51 = num75 ^ num90;
							object obj52 = num75 ^ num93;
							object obj53 = obj51 & obj52;
							bool flag30 = (nint)obj53 < 0;
							bool flag31 = flag28 == flag30;
							object obj54 = !flag29;
							object obj55 = flag31 & obj54;
							object obj56 = ~obj55;
							float num94 = ((obj56 != null) ? num90 : num75);
							float num95 = num77 - num92;
							bool flag32 = num95 < 0f;
							bool flag33 = num95 == 0f;
							object obj57 = num77 ^ num92;
							object obj58 = num77 ^ num95;
							object obj59 = obj57 & obj58;
							bool flag34 = (nint)obj59 < 0;
							bool flag35 = flag32 == flag34;
							object obj60 = !flag33;
							object obj61 = flag35 & obj60;
							object obj62 = ~obj61;
							float num96 = ((obj62 != null) ? num92 : num77);
							Vector3 vector9 = (Vector3)rng.GetHashCode();
							Runs(piece, vector9, (Vector3)1, num87, num97, (int)rng, (int)random, rng2);
							num81--;
							flag36 = num81 != 1;
							at6 = (Vector3)num87;
							big2 = num96;
							num73 = (int)rng;
							context2 = (Vector3)1;
							num43 = num94;
							obj27 = 0;
							obj28 = obj63;
							vector4 = faces3;
							num78 = num88;
							num79 = num97;
							num80 = num87;
							rng4 = (System.Random)vector9;
						}
						while (flag36);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X0_v8+E4]");
					bool flag37 = (nint)0 == 0;
					object obj64 = !flag37;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Lobed(piece, (Vector3)0, (Vector3)rng, (float)vector2, channel, random);
					bool flag38 = rng == null;
					num29 = (nint)rng;
					num28 = num4;
					num30 = num25;
					num31 = num23;
					num32 = num24;
					num33 = num2;
					val5 = (Enumerator<, >)num4;
					num11 = num;
					piece3 = piece2;
					num5 = num;
					num12 = (float)vector2;
					vector = (Vector3)0;
					num3 = (float)vector2;
					if (flag38)
					{
						break;
					}
					Vector3 at7 = (Vector3)rng.GetHashCode();
					float big4 = j.big;
					Thrown(piece, at7, (Vector3)0, (float)vector2, (int)rng, (int)random, num, rng2);
					nint num98 = (nint)rng;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v16 (Il2CppClass<System.Random>)+1A0]");
					int num99 = 0;
					int hashCode3 = rng.GetHashCode();
					if (hashCode3 < 1)
					{
						return;
					}
					float num100 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					float num101 = num100 * 0f;
					Vector3 at8 = (Vector3)0;
					Vector3 context3 = (Vector3)4;
					float num102 = num4;
					float num103 = num25;
					float num104 = num23;
					float num105 = num24;
					float num106 = num2;
					float num107 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					float num108 = 0f;
					System.Random rng5 = (System.Random)1;
					int num109 = hashCode3;
					bool flag48;
					do
					{
						object obj65 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X0_v17+E4]");
						bool flag39 = (nint)0 == 0;
						object obj66 = !flag39;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector10 = Sideways((Vector3)rng, rng5);
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)context3);
						float num110 = num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A968]");
						float num111 = num110 * 0f;
						float num112 = num111;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num113 = num112 + 0f;
						float num114 = num4 * num113;
						float num115 = num24 * num114;
						float num116 = num23 * num114;
						float num117 = num25 * num114;
						Vector3 vector11 = vector2 + num115;
						float num118 = num2 + num117;
						float num119 = num + num116;
						Snap(piece, ref at8, out var faces4);
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)(&faces4));
						float num120 = j.big;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
						float num121 = num120 * 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAAC]");
						object obj67 = vector11 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
						object obj68 = obj67 + 0;
						float num122 = j.big;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
						float num123 = num122 * 0f;
						float num124 = num4 * (float)obj68;
						float num125 = num124 - num121;
						bool flag40 = num125 < 0f;
						bool flag41 = num125 == 0f;
						object obj69 = num124 ^ num121;
						object obj70 = num124 ^ num125;
						object obj71 = obj69 & obj70;
						bool flag42 = (nint)obj71 < 0;
						bool flag43 = flag40 == flag42;
						object obj72 = !flag41;
						object obj73 = flag43 & obj72;
						object obj74 = ~obj73;
						float num126 = ((obj74 != null) ? num121 : num124);
						float num127 = num101 - num123;
						bool flag44 = num127 < 0f;
						bool flag45 = num127 == 0f;
						object obj75 = num101 ^ num123;
						object obj76 = num101 ^ num127;
						object obj77 = obj75 & obj76;
						bool flag46 = (nint)obj77 < 0;
						bool flag47 = flag44 == flag46;
						object obj78 = !flag45;
						object obj79 = flag47 & obj78;
						object obj80 = ~obj79;
						float num128 = ((obj80 != null) ? num123 : num101);
						Vector3 vector12 = (Vector3)rng.GetHashCode();
						Runs(piece, vector12, (Vector3)0, (float)vector11, num119, (int)rng, (int)random, rng2);
						num109--;
						flag48 = num109 != 1;
						at8 = vector11;
						big4 = num128;
						num99 = (int)rng;
						context3 = (Vector3)0;
						num102 = num126;
						num103 = 0f;
						num104 = num129;
						num105 = (float)faces4;
						num106 = num118;
						num107 = num119;
						num108 = (float)vector11;
						rng5 = (System.Random)vector12;
					}
					while (flag48);
					return;
					IL_12d4:
					IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
					num12 = (float)val2;
					goto IL_12ea;
					IL_12aa:
					IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
					goto IL_12b8;
					IL_12b8:
					IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
					goto IL_12c6;
					IL_12c6:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_12d4;
					IL_12ea:
					NullReferenceException ex8 = new NullReferenceException();
					piece3 = (Piece)(object)shape3;
					shape2 = null;
					val = val3;
					obj15 = 0;
					val6 = (Enumerator<, >)(ref val);
					break;
					IL_129c:
					NullReferenceException ex9 = new NullReferenceException();
					goto IL_12aa;
					IL_0471:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X13_v6 (UnityEngine.Vector3[])+20]");
					val5 = (Enumerator<, >)0;
					num6 = (float)shape;
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static void Thrown(Job j, System.Random rng)
	{
		//IL_2d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d26: Expected I4, but got Obj
		//IL_1b6b: Expected F8, but got I4
		//IL_1b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b73: Expected F8, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Obj
		//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd8: Invalid comparison between F8 and I4
		//IL_1be7: Expected F8, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a5: Expected I4, but got F8
		//IL_31a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d45: Expected I4, but got Obj
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got I4
		//IL_1c3b: Expected I, but got Obj
		//IL_1c4b: Expected VT, but got I
		//IL_1c64: Expected VT, but got I
		//IL_1c64: Expected Obj, but got I
		//IL_1c96: Expected VT, but got F4
		//IL_37ec: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2254: Invalid comparison between F8 and I4
		//IL_2263: Expected F8, but got I4
		//IL_0257: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got Ref
		//IL_013c: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e1: Expected Obj, but got I4
		//IL_31f5: Expected Obj, but got I4
		//IL_22d1: Invalid comparison between F8 and I4
		//IL_1d05: Invalid comparison between F8 and I4
		//IL_029f: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7f: Expected Obj, but got I
		//IL_2dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected I4, but got Unknown
		//IL_35d5: Invalid comparison between F8 and I4
		//IL_3256: Invalid comparison between F8 and I4
		//IL_3267: Expected Obj, but got I4
		//IL_3280: Invalid comparison between F8 and I4
		//IL_3291: Expected Obj, but got I4
		//IL_32a6: Expected VT, but got F4
		//IL_359a: Unknown result type (might be due to invalid IL or missing references)
		//IL_359f: Expected Obj, but got Unknown
		//IL_35b9: Expected Obj, but got I4
		//IL_321b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3220: Expected Obj, but got Unknown
		//IL_323a: Expected Obj, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e6: Expected Obj, but got I
		//IL_23f9: Expected Obj, but got I4
		//IL_2411: Expected F4, but got I
		//IL_1e72: Expected F4, but got I
		//IL_030b: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got I4
		//IL_37ae: Expected Obj, but got I4
		//IL_3537: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_04ea: Expected F4, but got I
		//IL_04f3: Expected F4, but got I4
		//IL_0504: Expected F4, but got I4
		//IL_0511: Expected I4, but got I8
		//IL_051a: Expected F4, but got I4
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de2: Expected Obj, but got I
		//IL_2e04: Expected Obj, but got I
		//IL_2e2c: Expected Obj, but got I
		//IL_244e: Expected I, but got Obj
		//IL_245d: Expected VT, but got I4
		//IL_245d: Expected Obj, but got I
		//IL_246d: Invalid comparison between F4 and I
		//IL_1ebe: Expected VT, but got I4
		//IL_1ebe: Expected Obj, but got I
		//IL_1f04: Invalid comparison between F8 and I4
		//IL_1f13: Expected F8, but got I4
		//IL_38b7: Expected F8, but got I4
		//IL_3950: Expected F8, but got I
		//IL_3969: Unknown result type (might be due to invalid IL or missing references)
		//IL_396d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3979: Unknown result type (might be due to invalid IL or missing references)
		//IL_397d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3981: Unknown result type (might be due to invalid IL or missing references)
		//IL_3985: Unknown result type (might be due to invalid IL or missing references)
		//IL_398d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2530: Expected Obj, but got I4
		//IL_2540: Expected Obj, but got I
		//IL_2560: Invalid comparison between F4 and I4
		//IL_2576: Expected Obj, but got I
		//IL_2585: Expected Obj, but got I4
		//IL_2595: Expected Obj, but got I
		//IL_25b7: Expected Obj, but got I4
		//IL_25c7: Expected Obj, but got I
		//IL_25d7: Expected Obj, but got I
		//IL_3314: Expected Obj, but got Ref
		//IL_3314: Expected F4, but got VT
		//IL_3314: Expected VT, but got Obj
		//IL_3314: Expected VT, but got I4
		//IL_3321: Expected VT, but got I4
		//IL_3347: Expected Obj, but got Ref
		//IL_3347: Expected I4, but got Obj
		//IL_3347: Expected F4, but got VT
		//IL_3347: Expected VT, but got I4
		//IL_337c: Expected I4, but got Obj
		//IL_3385: Expected F8, but got I4
		//IL_339e: Expected VT, but got I4
		//IL_33a3: Expected I, but got Obj
		//IL_33c8: Expected F8, but got I
		//IL_261c: Expected I, but got Obj
		//IL_262b: Expected VT, but got I4
		//IL_262b: Expected Obj, but got I
		//IL_24ae: Expected Obj, but got I4
		//IL_24be: Expected Obj, but got I
		//IL_24ce: Expected Obj, but got I
		//IL_21c4: Invalid comparison between F8 and I4
		//IL_21d5: Expected Obj, but got Ref
		//IL_21dd: Expected Obj, but got Ref
		//IL_21ed: Expected Obj, but got Ref
		//IL_21f5: Expected Obj, but got Ref
		//IL_221d: Expected F4, but got VT
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f67: Expected I, but got Obj
		//IL_1f77: Expected VT, but got I
		//IL_1f87: Expected VT, but got I4
		//IL_1f87: Expected Obj, but got I
		//IL_1fa5: Expected I4, but got Obj
		//IL_1fae: Expected F8, but got I4
		//IL_1fc7: Expected VT, but got I4
		//IL_1fcc: Expected I, but got Obj
		//IL_3a19: Expected Obj, but got I4
		//IL_24ec: Expected Obj, but got I
		//IL_24fc: Expected Obj, but got I
		//IL_2514: Expected Obj, but got I
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2651: Expected Obj, but got VT
		//IL_2667: Expected Obj, but got I
		//IL_2026: Expected Obj, but got I4
		//IL_2712: Expected Obj, but got I
		//IL_272a: Expected Obj, but got I
		//IL_2053: Expected VT, but got I4
		//IL_2053: Expected Obj, but got I
		//IL_20f7: Invalid comparison between F8 and I4
		//IL_2106: Invalid comparison between F8 and I4
		//IL_2119: Expected Obj, but got F8
		//IL_2126: Expected Obj, but got F8
		//IL_215b: Expected Obj, but got I4
		//IL_2163: Unknown result type (might be due to invalid IL or missing references)
		//IL_2168: Expected Obj, but got Unknown
		//IL_07ee: Expected Obj, but got I
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected F4, but got I
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35fb: Expected Obj, but got Unknown
		//IL_3604: Unknown result type (might be due to invalid IL or missing references)
		//IL_3609: Expected Obj, but got Unknown
		//IL_3624: Unsupported input type for neg.
		//IL_3624: Unknown result type (might be due to invalid IL or missing references)
		//IL_3629: Expected Obj, but got Unknown
		//IL_3639: Unknown result type (might be due to invalid IL or missing references)
		//IL_363e: Expected Obj, but got Unknown
		//IL_366c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3671: Expected Obj, but got Unknown
		//IL_36b3: Expected Obj, but got I4
		//IL_36bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c0: Expected Obj, but got Unknown
		//IL_26f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f5: Expected Obj, but got Unknown
		//IL_33f6: Invalid comparison between F8 and I4
		//IL_3405: Invalid comparison between F8 and I4
		//IL_3418: Expected Obj, but got F8
		//IL_3425: Expected Obj, but got F8
		//IL_345a: Expected Obj, but got I4
		//IL_3462: Unknown result type (might be due to invalid IL or missing references)
		//IL_3467: Expected Obj, but got Unknown
		//IL_273f: Expected Obj, but got I
		//IL_1b4d: Expected F4, but got I
		//IL_3a47: Expected Obj, but got I
		//IL_3a69: Expected Obj, but got I4
		//IL_348b: Expected VT, but got I4
		//IL_34b1: Expected Obj, but got Ref
		//IL_34b1: Expected I4, but got Obj
		//IL_34b1: Expected F4, but got VT
		//IL_34b1: Expected VT, but got I4
		//IL_34b9: Expected I4, but got Obj
		//IL_34c2: Expected F8, but got I4
		//IL_34db: Expected VT, but got I4
		//IL_34e0: Expected I, but got Obj
		//IL_3500: Expected F4, but got VT
		//IL_305e: Expected Obj, but got I4
		//IL_30eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3108: Unknown result type (might be due to invalid IL or missing references)
		//IL_310c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_3114: Unknown result type (might be due to invalid IL or missing references)
		//IL_311c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got I4
		//IL_096b: Expected F4, but got I
		//IL_2776: Expected Obj, but got I
		//IL_278d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2792: Expected Obj, but got Unknown
		//IL_279b: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a0: Expected Obj, but got Unknown
		//IL_282a: Expected Obj, but got I
		//IL_282a: Expected VT, but got Obj
		//IL_2836: Expected I, but got Obj
		//IL_2846: Expected VT, but got I
		//IL_2856: Unknown result type (might be due to invalid IL or missing references)
		//IL_285b: Expected Obj, but got Unknown
		//IL_2871: Expected Obj, but got I
		//IL_2895: Unknown result type (might be due to invalid IL or missing references)
		//IL_289a: Expected Obj, but got Unknown
		//IL_28cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d0: Expected Obj, but got Unknown
		//IL_290b: Expected VT, but got I4
		//IL_290b: Expected Obj, but got I
		//IL_2940: Expected VT, but got Obj
		//IL_29bf: Invalid comparison between F8 and I4
		//IL_29ce: Invalid comparison between F8 and I4
		//IL_29e6: Expected Obj, but got F8
		//IL_29f3: Expected Obj, but got F8
		//IL_2a28: Expected Obj, but got I4
		//IL_2a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a35: Expected Obj, but got Unknown
		//IL_386e: Expected Obj, but got I4
		//IL_2bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ec: Invalid comparison between F8 and I
		//IL_3706: Expected F8, but got I4
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Invalid comparison between Unknown and I4
		//IL_09a7: Expected Obj, but got I4
		//IL_3aa1: Expected Obj, but got I4
		//IL_3b1c: Expected VT, but got I4
		//IL_3b1c: Expected F4, but got VT
		//IL_3b1c: Expected VT, but got I4
		//IL_3b35: Invalid comparison between F8 and I4
		//IL_3b46: Expected Obj, but got Ref
		//IL_3b4e: Expected Obj, but got Ref
		//IL_3b6f: Expected VT, but got I4
		//IL_3b8f: Expected F4, but got VT
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected I4, but got Unknown
		//IL_09dc: Expected Obj, but got I4
		//IL_3ad9: Expected Obj, but got I4
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9e: Invalid comparison between F8 and I
		//IL_2b05: Expected Obj, but got I
		//IL_2b1d: Expected F8, but got I
		//IL_0b0e: Expected Obj, but got I
		//IL_0b47: Expected Obj, but got I4
		//IL_3761: Unknown result type (might be due to invalid IL or missing references)
		//IL_3766: Expected VT, but got Unknown
		//IL_377f: Expected VT, but got I4
		//IL_2ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae8: Expected Obj, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected Obj, but got Unknown
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got I4
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected Obj, but got Unknown
		//IL_0c0f: Expected Obj, but got I4
		//IL_0c43: Expected Obj, but got I
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected Obj, but got Unknown
		//IL_0c6e: Expected Obj, but got I
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected Obj, but got Unknown
		//IL_0c99: Expected Obj, but got I
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected I4, but got Unknown
		//IL_0cb6: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0cd6: Expected Obj, but got I
		//IL_0ce6: Expected Obj, but got I
		//IL_0cf6: Expected Obj, but got I
		//IL_0d13: Expected Obj, but got I
		//IL_0d30: Expected Obj, but got I
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected Obj, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected VT, but got Unknown
		//IL_0dec: Invalid comparison between F4 and I4
		//IL_0dfd: Expected Obj, but got I4
		//IL_1a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f60: Expected Obj, but got Unknown
		//IL_3006: Unknown result type (might be due to invalid IL or missing references)
		//IL_300a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected Obj, but got I
		//IL_0f09: Expected Obj, but got I4
		//IL_0f31: Expected Obj, but got I
		//IL_0f41: Expected Obj, but got I
		//IL_0f51: Expected Obj, but got I
		//IL_0f61: Expected Obj, but got I
		//IL_0f71: Expected Obj, but got I
		//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Expected Obj, but got I4
		//IL_0ff8: Expected Obj, but got I
		//IL_1008: Expected Obj, but got I
		//IL_1018: Expected Obj, but got I
		//IL_1028: Expected Obj, but got I
		//IL_1038: Expected Obj, but got I
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got I4
		//IL_10bf: Expected Obj, but got I
		//IL_10cf: Expected Obj, but got I
		//IL_10df: Expected Obj, but got I
		//IL_10ef: Expected Obj, but got I
		//IL_10ff: Expected Obj, but got I
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Expected Obj, but got I
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Expected Obj, but got Unknown
		//IL_117c: Expected Obj, but got I
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_119f: Expected Obj, but got I
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ac: Expected I4, but got Unknown
		//IL_11bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Expected Obj, but got Unknown
		//IL_11e3: Expected Obj, but got I
		//IL_11f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Expected VT, but got Unknown
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_123d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Invalid comparison between Unknown and I4
		//IL_125b: Expected Obj, but got I4
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Invalid comparison between Unknown and I4
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected I4, but got Unknown
		//IL_1290: Expected Obj, but got I
		//IL_12b3: Expected Obj, but got VT
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Invalid comparison between F4 and I
		//IL_1331: Expected Obj, but got I
		//IL_133d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6d: Expected Obj, but got I4
		//IL_3847: Expected Obj, but got I4
		//IL_2e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected F4, but got I
		//IL_13c5: Expected F4, but got I
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd: Expected Obj, but got I4
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_1481: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b5: Expected Obj, but got Unknown
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Expected Obj, but got Unknown
		//IL_14ec: Expected Obj, but got I
		//IL_1506: Expected I4, but got Obj
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		//IL_152d: Expected Obj, but got Unknown
		//IL_1547: Expected VT, but got Obj
		//IL_156b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1570: Expected Obj, but got Unknown
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_1651: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1662: Unknown result type (might be due to invalid IL or missing references)
		//IL_1672: Unknown result type (might be due to invalid IL or missing references)
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected Obj, but got I4
		//IL_1753: Unknown result type (might be due to invalid IL or missing references)
		//IL_1757: Unknown result type (might be due to invalid IL or missing references)
		//IL_175b: Unknown result type (might be due to invalid IL or missing references)
		//IL_176d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_1776: Unknown result type (might be due to invalid IL or missing references)
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Expected VT, but got I4
		//IL_17be: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_182f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Expected Obj, but got I4
		//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_190d: Expected Obj, but got I
		//IL_1948: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDD4E]");
		int num = 0;
		bool flag = j == null;
		int num3 = default;
		int num2 = num3;
		Enumerator<, > val = (Enumerator<, >)0;
		int num4 = (int)rng;
		int num5 = 109891584;
		object obj2 = default;
		object obj8 = default;
		double num33;
		float num37 = default;
		int num15 = default;
		Enumerator<, > val8 = default;
		float num35 = default;
		Enumerator<, > val3 = default;
		float num19 = default;
		Vector3 vector2 = default;
		float num34 = default;
		double num32;
		object obj25 = default;
		nint num22 = default;
		double num36;
		if (!flag)
		{
			bool flag2 = j.pieces == null;
			num2 = num3;
			val = (Enumerator<, >)0;
			num4 = (int)rng;
			num5 = 109891584;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8720]");
				int num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
				obj2 = 0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)j.pieces).GetEnumerator();
				Enumerator<, > val2 = (Enumerator<, >)(ref val);
				num = num3;
				num5 = 0;
				Enumerator<, > val4 = default;
				object obj11 = default;
				object obj19 = default;
				object obj22 = default;
				int num8 = default;
				object obj46 = default;
				object obj87 = default;
				object obj88 = default;
				object obj7 = default;
				object obj43 = default;
				float num11 = default;
				float num13 = default;
				object obj27 = default;
				float num17 = default;
				object obj29 = default;
				object obj31 = default;
				object obj33 = default;
				object obj35 = default;
				object obj37 = default;
				object obj39 = default;
				object obj41 = default;
				int num21 = default;
				while (true)
				{
					num4 = (int)obj;
					object obj3;
					System.__Canon _Canon;
					if (val.MoveNext())
					{
						bool flag3 = num3 == 0;
						num2 = 0;
						obj3 = 0;
						_Canon = (System.__Canon)1431655766;
						val3 = val4;
						num = num3;
						if (flag3)
						{
							goto IL_2c18;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ stack_-118 (System.Int32)+20]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ stack_-118 (System.Int32)+20]");
						bool flag4 = (nint)0 == 0;
						num2 = 0;
						obj3 = 0;
						_Canon = (System.__Canon)1431655766;
						val3 = val4;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+38]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+38]");
							bool flag5 = (nint)0 == 0;
							num2 = 0;
							obj3 = 0;
							_Canon = (System.__Canon)1431655766;
							val3 = val4;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
								object obj4 = (nint)0 * (nint)1431655766;
								val2 = (Enumerator<, >)(obj4 >> 63);
								object obj5 = obj4 >> 32;
								num = (int)(obj5 + val2);
								num5 = num + num5;
								continue;
							}
							goto IL_2c0a;
						}
						goto IL_2c26;
					}
					object obj6 = obj7;
					num2 = 0;
					obj3 = 0;
					_Canon = (System.__Canon)1431655766;
					val3 = val4;
					obj8 = 0;
					while (true)
					{
						num4 = ((int*)num6)->m_value;
						val.Dispose();
						bool flag6 = obj8 == null;
						object obj9 = !flag6;
						if (obj9 == null)
						{
							bool flag7 = num2 == 0;
							object obj10 = !flag7;
							OutOfMemoryException ex = (OutOfMemoryException)(&val);
							num = num2;
							if (obj10 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (num4)
						{
						case 2:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num2 = 1;
							obj8 = obj3;
							num = 1;
							break;
						case 1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj8 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj3 = obj11;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E970");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
					}
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v104+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v104+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v75+98]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v75+98]");
					bool flag9 = (nint)0 == 0;
					obj7 = obj6;
					val = val4;
					Enumerator<, > val5 = (Enumerator<, >)(ref val);
					if (flag9)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
					num = 0;
					int num7 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
					if ((nint)num7 > (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj16 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ X8_v108+E4]");
						val2 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ X8_v108+E4]");
						bool flag10 = (nint)0 == 0;
						object obj17 = !flag10;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj16 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ X8_v108+A0]");
						object obj18 = (nint)0 + (nint)152;
						obj18 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj20 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1905 @ X8_v109+A0]");
						object obj21 = (nint)0 + (nint)160;
						obj21 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj23 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2021 @ X8_v112+A0]");
						num = (int)((nint)0 + (nint)168);
						((int*)num)->m_value = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num4 = num8;
					}
					List<System.__Canon> pieces = (List<System.__Canon>)(object)j.pieces;
					bool flag11 = j.pieces == null;
					obj7 = obj6;
					val = val4;
					val5 = (Enumerator<, >)(ref val);
					if (flag11)
					{
						break;
					}
					float num9 = j.reach * j.reach;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj8 = 0;
					float num10 = num11;
					float num12 = num13;
					int num14 = num15;
					object obj24 = obj25;
					object obj26 = obj27;
					float num16 = num17;
					Vector3 vector = vector2;
					object obj28 = obj29;
					object obj30 = obj31;
					object obj32 = obj33;
					object obj34 = obj35;
					object obj36 = obj37;
					object obj38 = obj39;
					float num18 = num19;
					object obj40 = obj41;
					int num20 = num21;
					object obj42 = obj43;
					object obj44 = obj6;
					object obj45 = obj46;
					IntPtr intPtr = num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
					float num23 = 0f;
					float num24 = 0f;
					float num25 = num9;
					float num26 = 2.139095E+09f;
					int num27 = -1096111445;
					float num28 = 0f;
					System.__Canon _Canon2 = _Canon;
					Enumerator<, > val6 = (Enumerator<, >)17276928;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					Enumerator<, > val7 = (Enumerator<, >)0;
					int num29 = num4;
					int num30 = 0;
					int num31 = 0;
					System.__Canon _Canon3;
					while (true)
					{
						num = pieces._size;
						bool flag12 = num30 >= pieces._size;
						num11 = num10;
						num13 = num12;
						num32 = num14;
						obj25 = obj24;
						obj27 = obj26;
						num17 = num16;
						vector2 = vector;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						obj39 = obj38;
						num19 = num18;
						obj41 = obj40;
						num21 = num20;
						obj43 = obj42;
						obj7 = obj44;
						obj46 = obj45;
						num22 = intPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						num33 = 0.0;
						num34 = num23;
						num35 = num24;
						num36 = num25;
						val = val4;
						_Canon = _Canon2;
						val2 = val6;
						val3 = val7;
						val5 = (Enumerator<, >)(ref val);
						num4 = num29;
						num6 = num30;
						num5 = num31;
						if (flag12)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8768]");
						num = 0;
						num22 = ((int*)num)->m_value;
						_Canon3 = pieces.get_Item(num30);
						bool flag13 = _Canon3 == null;
						num11 = num10;
						num13 = num12;
						num15 = num14;
						obj25 = obj24;
						obj27 = obj26;
						num17 = num16;
						vector2 = vector;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						obj39 = obj38;
						num19 = num18;
						obj41 = obj40;
						num21 = num20;
						obj43 = obj42;
						obj7 = obj44;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						val8 = (Enumerator<, >)0;
						num34 = num23;
						num35 = num24;
						num37 = num25;
						val = val4;
						_Canon = _Canon2;
						val2 = val6;
						val3 = val7;
						val5 = (Enumerator<, >)(ref val);
						num4 = num30;
						num6 = num30;
						num5 = num31;
						if (flag13)
						{
							goto end_IL_2d3d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+20]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+20]");
						bool flag14 = (nint)0 == 0;
						num11 = num10;
						num13 = num12;
						num15 = num14;
						obj25 = obj24;
						obj27 = obj26;
						num17 = num16;
						vector2 = vector;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						obj39 = obj38;
						num19 = num18;
						obj41 = obj40;
						num21 = num20;
						obj43 = obj42;
						obj7 = obj44;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						val8 = (Enumerator<, >)0;
						num34 = num23;
						num35 = num24;
						num37 = num25;
						val = val4;
						_Canon = _Canon3;
						val2 = val6;
						val3 = val7;
						val5 = (Enumerator<, >)(ref val);
						num4 = num30;
						num6 = num30;
						num5 = num31;
						if (flag14)
						{
							goto end_IL_2d3d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+38]");
						obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+38]");
						bool flag15 = (nint)0 == 0;
						num11 = num10;
						num13 = num12;
						num15 = num14;
						obj25 = obj24;
						obj27 = obj26;
						num17 = num16;
						vector2 = vector;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						obj39 = obj38;
						num19 = num18;
						obj41 = obj40;
						num21 = num20;
						obj43 = obj42;
						obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						val8 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
						num34 = 0f;
						num35 = num24;
						num37 = num9;
						val = val4;
						_Canon = _Canon3;
						val2 = val6;
						val3 = val7;
						val5 = (Enumerator<, >)(ref val);
						num4 = num30;
						num6 = num30;
						num5 = num31;
						if (flag15)
						{
							goto end_IL_2d3d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X27_v13+18]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X27_v13+18]");
						float num61;
						object obj99;
						float num62;
						float num63;
						float num64;
						int num65;
						float num66;
						Enumerator<, > val9;
						if ((nint)0 >= (nint)1)
						{
							obj43 = 0;
							obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
							num34 = 0f;
							num37 = num9;
							System.__Canon _Canon4 = _Canon3;
							while (true)
							{
								bool flag16 = (nint)obj43 < num;
								object obj47 = !flag16;
								if (obj47 != null)
								{
									break;
								}
								val6 = (Enumerator<, >)(obj43 + 1);
								bool flag17 = (int)val6 < num;
								object obj48 = !flag17;
								if (obj48 != null)
								{
									break;
								}
								num27 = obj43 + 2;
								bool flag18 = num27 < num;
								object obj49 = !flag18;
								if (obj49 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								num21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								bool flag19 = (nint)0 == 0;
								num11 = num10;
								num13 = num12;
								num15 = num14;
								obj25 = obj24;
								obj27 = obj26;
								num17 = num16;
								vector2 = vector;
								obj29 = obj28;
								obj31 = obj30;
								obj33 = obj32;
								obj35 = obj34;
								obj37 = obj36;
								obj39 = obj38;
								num19 = num18;
								obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
								val8 = (Enumerator<, >)0;
								num35 = num24;
								val = val4;
								_Canon = _Canon3;
								val2 = val6;
								val3 = val7;
								val5 = (Enumerator<, >)(ref val);
								num4 = num30;
								num6 = num30;
								num5 = num31;
								if (flag19)
								{
									goto end_IL_2d3d;
								}
								object obj50 = obj46 + obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
								obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ X8_v91+20]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ X8_v91+20]");
								nint num38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
								bool flag20 = num38 < 0;
								object obj51 = !flag20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								num20 = 0;
								if (obj51 != null)
								{
									break;
								}
								object obj52 = obj46 + val6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
								val6 = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
								nint num39 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
								bool flag21 = num39 < 0;
								object obj53 = !flag21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								num20 = 0;
								if (obj53 != null)
								{
									break;
								}
								object obj54 = obj46 + num27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X10_v25+20]");
								num27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X10_v25+20]");
								nint num40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
								bool flag22 = num40 < 0;
								object obj55 = !flag22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								num20 = 0;
								if (obj55 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ X8_v91+20]");
								object obj56 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								obj41 = 0 + obj56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
								object obj57 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+30]");
								obj39 = 0 + obj57;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X10_v25+20]");
								object obj58 = (nint)0 * (nint)12;
								num21 += obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+20]");
								obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+20]");
								obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+28]");
								obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+20]");
								obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+28]");
								obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+20]");
								nint num41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+20]");
								object obj59 = num41 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+28]");
								nint num42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+28]");
								object obj60 = num42 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+20]");
								object obj61 = obj59 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+28]");
								object obj62 = obj60 + 0;
								object obj63 = obj61 * obj7;
								float num43 = (float)obj62 * num34;
								num28 = (float)j.point + (float)obj63;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
								val3 = (Enumerator<, >)(0 - num43);
								num19 = num28 * num28;
								vector2 = (Vector3)(val3 * val3);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								num17 = num19 + (float)vector2;
								float num44 = num17 - num37;
								bool flag23 = num44 == 0f;
								obj27 = !flag23;
								flag12 = num17 > num37;
								int num45 = num31;
								System.__Canon _Canon5;
								if (!flag12)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+38]");
									num21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+38]");
									bool flag24 = (nint)0 == 0;
									num11 = num10;
									num13 = num12;
									num15 = num14;
									obj25 = obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
									val8 = (Enumerator<, >)0;
									num35 = num24;
									val = val4;
									_Canon = _Canon3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
									val2 = (Enumerator<, >)0;
									val5 = (Enumerator<, >)(ref val);
									num4 = num30;
									num6 = num30;
									num5 = num31;
									if (flag24)
									{
										goto end_IL_2d3d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
									obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ X8_v91+20]");
									nint num46 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
									bool flag25 = num46 < 0;
									object obj64 = !flag25;
									obj26 = obj27;
									num16 = num17;
									vector = vector2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+28]");
									obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+20]");
									obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+28]");
									obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+20]");
									obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+20]");
									obj36 = 0;
									obj38 = obj39;
									num18 = num19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+38]");
									num20 = 0;
									val7 = val3;
									if (obj64 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
									nint num47 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
									bool flag26 = num47 < 0;
									object obj65 = !flag26;
									obj26 = obj27;
									num16 = num17;
									vector = vector2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+28]");
									obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+20]");
									obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+28]");
									obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+20]");
									obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+20]");
									obj36 = 0;
									obj38 = obj39;
									num18 = num19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+38]");
									num20 = 0;
									val7 = val3;
									if (obj65 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X10_v25+20]");
									nint num48 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
									bool flag27 = num48 < 0;
									object obj66 = !flag27;
									obj26 = obj27;
									num16 = num17;
									vector = vector2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+28]");
									obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+20]");
									obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+28]");
									obj32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X13_v9+20]");
									obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X12_v13+20]");
									obj36 = 0;
									obj38 = obj39;
									num18 = num19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v108 (System.__Canon)+38]");
									num20 = 0;
									val7 = val3;
									if (obj66 != null)
									{
										break;
									}
									num21 += 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2397 @ X8_v91+20]");
									object obj67 = (nint)0 * (nint)12;
									object obj68 = num21 + obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2404 @ X9_v39+20]");
									object obj69 = (nint)0 * (nint)12;
									val6 = (Enumerator<, >)(num21 + obj69);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X10_v25+20]");
									object obj70 = (nint)0 * (nint)12;
									num27 = num21 + obj70;
									num14 = ((int*)num27)->m_value;
									object obj71 = obj68 + val6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v96+8]");
									nint num49 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2540 @ X9_v42 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8]");
									obj24 = num49 + 0;
									vector2 = (Vector3)(obj71 + ((int*)num27)->m_value);
									float num50 = (float)obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2512 @ X10_v28 (System.Int32)+8]");
									num19 = num50 + 0f;
									num28 *= (float)vector2;
									float num51 = (float)val3 * num19;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									val3 = (Enumerator<, >)(num51 + num28);
									bool flag28 = (int)val3 < 0;
									object obj72 = !flag28;
									bool flag29 = (int)val3 == 0;
									object obj73 = ~obj72;
									flag12 = (byte)((obj73 | flag29) ? 1 : 0) != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
									obj41 = 0;
									num45 = num31;
									if (!flag12)
									{
										object obj74 = vector2 * vector2;
										num19 *= num19;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										float num52 = (float)obj74 + num19;
										num28 = num17 * num52;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										float num53 = (float)val3 / num28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
										bool flag30 = num53 < 0f;
										num12 = num53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X11_v19 (System.Int32)+18]");
										obj41 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
										val3 = (Enumerator<, >)0;
										num45 = num31;
										if (!flag30)
										{
											object obj75 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2684 @ X0_v117+E4]");
											bool flag31 = (nint)0 == 0;
											object obj76 = !flag31;
											num13 = num53;
											if (obj76 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												num13 = num53;
												obj7 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
												num34 = 0f;
												num37 = num9;
											}
											_Canon4 = (System.__Canon)obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2544 @ X0_v115 (System.__Canon)+E4]");
											bool flag32 = (nint)0 == 0;
											object obj77 = !flag32;
											if (obj77 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												_Canon4 = (System.__Canon)obj2;
												num13 = num53;
												obj7 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
												num34 = 0f;
												num37 = num9;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2544 @ X0_v115 (System.__Canon)+A0]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+98]");
											val2 = (Enumerator<, >)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+98]");
											bool flag33 = (nint)0 == 0;
											num11 = num53;
											num15 = num14;
											obj25 = obj24;
											obj41 = obj40;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
											val8 = (Enumerator<, >)0;
											num35 = num24;
											val = val4;
											_Canon = _Canon3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
											val3 = (Enumerator<, >)0;
											val5 = (Enumerator<, >)(ref val);
											num4 = num30;
											num6 = num30;
											num5 = num31;
											if (flag33)
											{
												goto end_IL_2d3d;
											}
											num27 = val2._index;
											bool flag34 = num31 < val2._index;
											object obj78 = !flag34;
											num10 = num53;
											num12 = num13;
											obj26 = obj27;
											num16 = num17;
											vector = vector2;
											obj28 = obj29;
											obj30 = obj31;
											obj32 = obj33;
											obj34 = obj35;
											obj36 = obj37;
											obj38 = obj39;
											num18 = num19;
											num20 = num21;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+98]");
											val6 = (Enumerator<, >)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
											val7 = (Enumerator<, >)0;
											if (obj78 != null)
											{
												break;
											}
											object obj79 = obj35 - obj37;
											object obj80 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X12_v7+28]");
											object obj81 = obj80 - 0;
											object obj82 = obj31 - obj37;
											object obj83 = obj29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X12_v7+28]");
											object obj84 = obj83 - 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+98]");
											object obj85 = (nint)0 + (nint)num31;
											object obj86 = obj84 * obj87;
											num15 = obj81 * obj88;
											object obj89 = obj81 * obj82;
											object obj90 = obj84 * obj79;
											obj25 = obj86 - num15;
											object obj91 = obj89 - obj90;
											vector2 = (Vector3)(obj79 * obj88);
											object obj92 = obj82 * obj87;
											num19 = (float)obj25 * (float)obj25;
											object obj93 = vector2 - obj92;
											object obj94 = obj91 * obj91;
											float num54 = num19 + (float)obj94;
											object obj95 = obj93 * obj93;
											float num55 = (float)obj95 + num54;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											double num56 = (double)num55 * 0.5;
											float num57 = num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
											float num58 = num57 + 0f;
											double num59 = num56 * (double)num13;
											val3 = (Enumerator<, >)(num59 / (double)num58);
											num28 = num24 + (float)val3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A0]");
											val2 = (Enumerator<, >)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A0]");
											bool flag35 = (nint)0 == 0;
											num11 = num53;
											obj41 = obj40;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
											val8 = (Enumerator<, >)0;
											num35 = num28;
											val = val4;
											_Canon = _Canon3;
											val5 = (Enumerator<, >)(ref val);
											num4 = num30;
											num6 = num30;
											num5 = num31;
											if (flag35)
											{
												goto end_IL_2d3d;
											}
											num20 = val2._index;
											bool flag36 = num31 < val2._index;
											object obj96 = !flag36;
											num10 = num53;
											num12 = num13;
											num14 = num15;
											obj24 = obj25;
											obj26 = obj27;
											num16 = num17;
											vector = vector2;
											obj28 = obj29;
											obj30 = obj31;
											obj32 = obj33;
											obj34 = obj35;
											obj36 = obj37;
											obj38 = obj39;
											num18 = num19;
											num24 = num28;
											num27 = num31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A0]");
											val6 = (Enumerator<, >)0;
											val7 = val3;
											if (obj96 != null)
											{
												break;
											}
											val2 = (Enumerator<, >)(val2 + num31);
											System.Runtime.CompilerServices.Unsafe.Write(&((Enumerator<, >*)(nint)val2)->_current, (_00210)num30);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A8]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A8]");
											bool flag37 = (nint)0 == 0;
											num11 = num53;
											obj41 = obj40;
											num21 = val2._index;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
											val8 = (Enumerator<, >)0;
											num35 = num28;
											val = val4;
											_Canon = _Canon3;
											val5 = (Enumerator<, >)(ref val);
											num4 = num30;
											num6 = num30;
											num5 = num31;
											if (flag37)
											{
												goto end_IL_2d3d;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
											val6 = (Enumerator<, >)0;
											int num60 = num31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
											bool flag38 = (nint)num60 < (nint)0;
											object obj97 = !flag38;
											num10 = num53;
											num12 = num13;
											num14 = num15;
											obj24 = obj25;
											obj26 = obj27;
											num16 = num17;
											vector = vector2;
											obj28 = obj29;
											obj30 = obj31;
											obj32 = obj33;
											obj34 = obj35;
											obj36 = obj37;
											obj38 = obj39;
											num18 = num19;
											num24 = num28;
											num27 = num31;
											val7 = val3;
											if (obj97 != null)
											{
												break;
											}
											bool flag39 = num17 < num26;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+A8]");
											object obj98 = (nint)0 + (nint)num31;
											num45 = num31 + 1;
											num10 = num53;
											num12 = num13;
											num14 = num15;
											obj24 = obj25;
											obj41 = obj40;
											num21 = val2._index;
											num24 = num28;
											num27 = num31;
											num61 = num53;
											num16 = num17;
											vector = vector2;
											num18 = num19;
											obj99 = obj7;
											num62 = num34;
											num63 = num28;
											num64 = num37;
											num65 = num31;
											num66 = num28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v116 (System.Int32)+18]");
											val9 = (Enumerator<, >)0;
											val7 = val3;
											_Canon5 = _Canon4;
											num31 = num45;
											if (flag39)
											{
												goto IL_2f42;
											}
										}
									}
								}
								num61 = num10;
								num13 = num12;
								num15 = num14;
								obj25 = obj24;
								num16 = num26;
								vector = vector2;
								num18 = num19;
								obj40 = obj41;
								num20 = num21;
								obj99 = obj7;
								num62 = num34;
								num63 = num24;
								num64 = num37;
								num65 = num27;
								num66 = num28;
								val9 = val6;
								val7 = val3;
								_Canon5 = _Canon4;
								num31 = num45;
								goto IL_2f42;
								IL_2f42:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X27_v13+18]");
								num = 0;
								obj43 += 3;
								object obj100 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X27_v13+18]");
								flag12 = (nint)obj100 < 0;
								num10 = num61;
								num12 = num13;
								num14 = num15;
								obj24 = obj25;
								obj26 = obj27;
								obj28 = obj29;
								obj30 = obj31;
								obj32 = obj33;
								obj34 = obj35;
								obj36 = obj37;
								obj38 = obj39;
								obj7 = obj99;
								num34 = num62;
								num24 = num63;
								num37 = num64;
								num26 = num16;
								num27 = num65;
								num28 = num66;
								val6 = val9;
								_Canon4 = _Canon5;
								if (flag12)
								{
									continue;
								}
								goto IL_1a88;
							}
							goto IL_2b32;
						}
						num17 = num26;
						obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
						num34 = 0f;
						num37 = num9;
						goto IL_3024;
						IL_1a88:
						num10 = num61;
						num12 = num13;
						num14 = num15;
						obj24 = obj25;
						obj26 = obj27;
						num17 = num16;
						obj28 = obj29;
						obj30 = obj31;
						obj32 = obj33;
						obj34 = obj35;
						obj36 = obj37;
						obj38 = obj39;
						obj42 = obj43;
						obj7 = obj99;
						num34 = num62;
						num24 = num63;
						num37 = num64;
						num27 = num65;
						num28 = num66;
						val6 = val9;
						goto IL_3024;
						IL_3024:
						pieces = (List<System.__Canon>)(object)j.pieces;
						num6 = num30 + 1;
						bool flag40 = j.pieces == null;
						object obj101 = !flag40;
						num11 = num10;
						num13 = num12;
						num15 = num14;
						obj25 = obj24;
						obj27 = obj26;
						vector2 = vector;
						obj29 = obj28;
						obj31 = obj30;
						obj33 = obj32;
						obj35 = obj34;
						obj37 = obj36;
						obj39 = obj38;
						num19 = num18;
						obj41 = obj40;
						num21 = num20;
						obj43 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						val8 = (Enumerator<, >)0;
						num35 = num24;
						val = val4;
						_Canon = _Canon3;
						val2 = val6;
						val3 = val7;
						val5 = (Enumerator<, >)(ref val);
						num4 = num30;
						num5 = num31;
						num16 = num17;
						obj44 = obj7;
						obj45 = obj46;
						intPtr = num22;
						num23 = num34;
						num25 = num37;
						num26 = num17;
						_Canon2 = _Canon3;
						num29 = num30;
						num30 = num6;
						if (obj101 == null)
						{
							goto end_IL_2d3d;
						}
					}
					goto IL_1b80;
					IL_2c18:
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_2c26;
					IL_2c26:
					obj6 = obj7;
					throw new NullReferenceException();
					IL_2b32:
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					num11 = num10;
					num13 = num12;
					num15 = num14;
					obj25 = obj24;
					obj27 = obj26;
					num17 = num16;
					vector2 = vector;
					obj29 = obj28;
					obj31 = obj30;
					obj33 = obj32;
					obj35 = obj34;
					obj37 = obj36;
					obj39 = obj38;
					num19 = num18;
					obj41 = obj40;
					num21 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					val8 = (Enumerator<, >)0;
					num35 = num24;
					_Canon = _Canon3;
					val2 = val6;
					val3 = val7;
					num4 = num30;
					num6 = num30;
					num5 = num31;
					goto IL_2c0a;
					IL_2c0a:
					NullReferenceException ex4 = new NullReferenceException();
					goto IL_2c18;
					continue;
					end_IL_2d3d:
					break;
				}
			}
		}
		goto IL_1b5a;
		IL_324d:
		double num67;
		bool flag41 = num67 < 2147483646.0;
		object obj102 = !flag41;
		double num68 = num67 - 2147483646.0;
		bool flag42 = num68 == 0.0;
		object obj103 = !flag42;
		object obj104 = obj102 & obj103;
		Vector3 vector3 = (Vector3)num19;
		double num81;
		Vector3 vector6;
		object obj121;
		double num91;
		if (obj104 == null)
		{
			double num69 = num67 + 1.0;
			System.Random random2 = default;
			System.Random random = random2;
			System.Random random4 = default;
			System.Random random3 = random4;
			int num71 = default;
			int num70 = num71;
			double num72 = num32;
			object obj105 = obj25;
			Vector3 vector4 = vector2;
			IntPtr intPtr2 = num22;
			float num73 = num34;
			double num74 = num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
			float num75 = 0f;
			Vector3 vector5 = vector6;
			float num88 = default;
			object obj108 = default;
			bool flag57;
			do
			{
				object obj106 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1762 @ X0_v69+E4]");
				bool flag43 = (nint)0 == 0;
				object obj107 = !flag43;
				if (obj107 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Landing(j, rng, num5, num35, out var p, out var at, out var faces);
				((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)num5);
				float num76 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				float num77 = num76 * 0f;
				float num78 = num77;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num79 = num78 + 0f;
				double num80 = num81 * (double)num79;
				bool flag44 = num80 < 0.0;
				double num82 = 0.0;
				if (!flag44)
				{
					bool flag45 = !(num80 > 1.0);
					num82 = num80;
					if (!flag45)
					{
						num82 = 1.0;
					}
				}
				double num83 = num82;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE80]");
				double num84 = num83 * 0.0;
				double num85 = num84;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA14]");
				double num86 = num85 + 0.0;
				double num87 = (double)j.big * num86;
				Lobed(p, (Vector3)0, (Vector3)rng, (float)at, (int)(&p), (System.Random)(&at));
				Vector3 vector7 = (Vector3)rng.GetHashCode();
				Thrown(p, vector7, (Vector3)0, (float)at, (int)rng, (int)(&at), num88, (System.Random)(&faces));
				float num89 = j.big;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB68]");
				num75 = num89 * 0f;
				bool flag46 = !(num87 > (double)num75);
				num71 = (int)rng;
				num32 = 0.0;
				obj25 = obj108;
				vector2 = faces;
				vector3 = (Vector3)0;
				num22 = unchecked((nint)null);
				double num90 = j.big;
				num36 = num87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB68]");
				num91 = 0.0;
				vector6 = vector7;
				if (!flag46)
				{
					nint num92 = (nint)rng;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2099 @ X8_v60 (Il2CppClass<System.Random>)+1C0]");
					vector6 = (Vector3)0;
					((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)0);
					bool flag47 = !((double)num75 < 0.5000000000582077);
					num71 = (int)rng;
					num32 = 0.0;
					obj25 = obj108;
					vector2 = faces;
					vector3 = (Vector3)0;
					num22 = unchecked((nint)null);
					num90 = j.big;
					num36 = num87;
					num91 = 0.5000000000582077;
					if (!flag47)
					{
						object obj109 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2162 @ X0_v81+E4]");
						bool flag48 = (nint)0 == 0;
						object obj110 = !flag48;
						if (obj110 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)0);
						float num93 = j.big;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8CC]");
						float num94 = num93 * 0f;
						float num95 = num75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACD0]");
						float num96 = num95 * 0f;
						float num97 = j.big;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEAC]");
						float num98 = num97 * 0f;
						float num99 = num96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
						float num100 = num99 + 0f;
						double num101 = num87;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
						double num102 = num101 * 0.0;
						double num103 = num87 * (double)num100;
						double num104 = num103 - (double)num94;
						bool flag49 = num104 < 0.0;
						bool flag50 = num104 == 0.0;
						object obj111 = num103 ^ (double)num94;
						object obj112 = num103 ^ num104;
						object obj113 = obj111 & obj112;
						bool flag51 = (nint)obj113 < 0;
						bool flag52 = flag49 == flag51;
						object obj114 = !flag50;
						object obj115 = flag52 & obj114;
						object obj116 = ~obj115;
						if (obj116 != null)
						{
							num103 = num94;
						}
						double num105 = num102 - (double)num98;
						bool flag53 = num105 < 0.0;
						bool flag54 = num105 == 0.0;
						object obj117 = num102 ^ (double)num98;
						object obj118 = num102 ^ num105;
						object obj119 = obj117 & obj118;
						bool flag55 = (nint)obj119 < 0;
						bool flag56 = flag53 == flag55;
						object obj27 = !flag54;
						object obj120 = flag56 & obj27;
						obj121 = ~obj120;
						double num106 = ((obj121 != null) ? ((double)num98) : num102);
						Vector3 vector8 = (Vector3)rng.GetHashCode();
						Runs(p, vector8, (Vector3)0, (float)at, num88, (int)rng, (int)(&at), (System.Random)(&faces));
						num71 = (int)rng;
						num32 = 0.0;
						obj25 = obj108;
						vector2 = faces;
						vector3 = (Vector3)0;
						num22 = unchecked((nint)null);
						num90 = num106;
						num36 = num103;
						num91 = num88;
						num75 = (float)at;
						vector6 = vector8;
					}
				}
				num69--;
				flag57 = num69 != 1.0;
				random2 = (System.Random)(&faces);
				random4 = (System.Random)(&at);
				num34 = (float)num90;
				random = (System.Random)(&faces);
				random3 = (System.Random)(&at);
				num70 = num71;
				num72 = num32;
				obj105 = obj25;
				vector4 = vector2;
				num19 = (float)vector3;
				intPtr2 = num22;
				num73 = (float)num90;
				num74 = num36;
				vector5 = vector6;
			}
			while (flag57);
		}
		goto IL_224b;
		IL_3582:
		double num108;
		double num109;
		double num107 = num108 + num109;
		object obj122 = num108 & 1;
		bool flag58 = obj122 == null;
		object obj123 = !flag58;
		if (obj123 != null)
		{
			num108 = num107;
		}
		goto IL_35cc;
		IL_35cc:
		if (num108 < 1.0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj125 = 17276928;
		double num110 = num108;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
		float num111 = 0f;
		object obj167 = default;
		float num143 = default;
		bool flag76;
		object obj192 = default;
		do
		{
			object obj126 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1870 @ X0_v13+E4]");
			bool flag59 = (nint)0 == 0;
			object obj127 = !flag59;
			if (obj127 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Landing(j, rng, num5, num35, out var p2, out var at2, out var faces2);
			nint num112 = (nint)rng;
			((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)num5);
			float num113 = num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
			object obj130;
			object obj131;
			object obj132;
			object obj133;
			object obj134;
			if (num113 < 0f)
			{
				object obj128 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X0_v54+E4]");
				bool flag60 = (nint)0 == 0;
				object obj129 = !flag60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D0]");
				obj130 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
				obj131 = 0;
				if (obj129 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D0]");
					obj132 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
					obj133 = 0;
					obj134 = obj125;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
					object obj135 = 0;
					goto IL_25ed;
				}
			}
			else
			{
				object obj128 = obj2;
				object obj136 = 17281024 + 3064;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B688]");
				object obj135 = 0;
				float num114 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B688]");
				float num115 = num114 - 0f;
				bool flag61 = num115 < 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X10_v9+v2008 @ N_v23 (System.Boolean)*4]");
				obj133 = 0;
				obj134 = 17281024 + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2045 @ X10_v7+v2008 @ N_v23 (System.Boolean)*4]");
				obj132 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X0_v54+E4]");
				bool flag62 = (nint)0 == 0;
				object obj137 = !flag62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2045 @ X10_v7+v2008 @ N_v23 (System.Boolean)*4]");
				obj130 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X10_v9+v2008 @ N_v23 (System.Boolean)*4]");
				obj131 = 0;
				obj125 = obj134;
				if (obj137 == null)
				{
					goto IL_25ed;
				}
			}
			goto IL_2614;
			IL_2614:
			nint num116 = (nint)rng;
			((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)num5);
			object obj138 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2168 @ X0_v23+E4]");
			bool flag63 = (nint)0 == 0;
			object obj139 = !flag63;
			if (obj139 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj140 = at2 - j.point;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X0 (GillaStains+Job)+28]");
			object obj141 = -0;
			object obj142 = obj140 * obj140;
			object obj143 = obj141 * obj141;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj144 = obj142 + obj143;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj145;
			object obj146;
			if ((nint)obj144 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				obj145 = obj141 / obj144;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				obj146 = obj140 / 0;
			}
			else
			{
				object obj147 = obj124;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2361 @ X8_v41+A0]");
				object obj148 = 0;
				obj146 = obj148;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2362 @ X8_v42+8]");
				obj145 = 0;
			}
			object obj149 = obj146 * faces2;
			object obj150 = obj145 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj151 = obj150 + obj149;
			object obj152 = 0 - obj151;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			object obj153 = obj151 - 0;
			bool flag64 = (nint)obj153 < 0;
			bool flag65 = obj153 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
			object obj154 = obj151 ^ 0;
			object obj155 = obj151 ^ obj153;
			object obj156 = obj154 & obj155;
			bool flag66 = (nint)obj156 < 0;
			bool flag67 = flag64 == flag66;
			object obj157 = !flag65;
			object obj158 = flag67 & obj157;
			object obj159 = ~obj158;
			object obj160;
			if (obj159 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				obj160 = 0;
			}
			else
			{
				obj160 = obj152;
			}
			object obj161 = obj124;
			object obj162 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2409 @ X8_v30+A0]");
			object obj163 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2410 @ X0_v26+E4]");
			bool flag68 = (nint)0 == 0;
			object obj164 = !flag68;
			if (obj164 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X8_v31+24]");
			object obj165 = (nint)0 * (nint)0;
			float num117 = (float)obj131 * num35;
			object obj166 = faces2 * obj167;
			object obj168 = 0 * obj160;
			float num118 = num117 + (float)obj130;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X8_v31+2C]");
			double num119 = 0.0 * 0.25;
			object obj169 = obj146 + obj166;
			object obj170 = obj145 + obj168;
			float num120 = num118 * j.big;
			object obj171 = obj169 + obj165;
			double num121 = (double)obj170 + num119;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2072 @ X8_v24 (Il2CppClass<System.Random>)+1C0]");
			Vector3 vector9 = Sideways((Vector3)rng, (System.Random)0);
			nint num122 = (nint)rng;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2457 @ X8_v32 (Il2CppClass<System.Random>)+1C0]");
			vector6 = (Vector3)0;
			Vector3 vector10 = faces2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			object obj172 = vector10 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			object obj173 = (nint)0 * (nint)0;
			object obj174 = obj171 + obj172;
			double num123 = num121 + (double)obj173;
			object obj175 = faces2 * obj174;
			double num124 = 0.0 * num123;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			double num125 = num124 + (double)obj175;
			object obj176 = faces2 * obj167;
			double num126 = 0.0 * num125;
			object obj177 = obj174 - obj176;
			double num127 = num123 - num126;
			((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)num5);
			double num128 = 1.0 / (double)obj160;
			double num129 = (double)obj174 * 1.5;
			Vector3 vector11 = (Vector3)(obj177 * obj177);
			double num130 = num129;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num131 = num130 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			double num132 = num128 + -1.0;
			double num133 = num127 * num127;
			double num134 = num132 + num131;
			double num135 = num133 + (double)vector11;
			double num136 = num134 - 4.5;
			bool flag69 = num136 < 0.0;
			bool flag70 = num136 == 0.0;
			object obj178 = num134 ^ 4.5;
			object obj179 = num134 ^ num136;
			object obj180 = obj178 & obj179;
			bool flag71 = (nint)obj180 < 0;
			bool flag72 = flag69 == flag71;
			object obj181 = !flag70;
			object obj182 = flag72 & obj181;
			object obj183 = ~obj182;
			double num137 = ((obj183 != null) ? num134 : 4.5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			bool flag73 = !(num135 > 0.0);
			vector2 = at2;
			double num138 = 0.0;
			double num139 = 4.5;
			Vector3 vector12 = at2;
			if (!flag73)
			{
				object obj184 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2650 @ X0_v39+E4]");
				bool flag74 = (nint)0 == 0;
				object obj185 = !flag74;
				if (obj185 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				double num140;
				object obj186;
				if (4.5 > 0.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num140 = num127 / 4.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					obj186 = obj177 / 0;
				}
				else
				{
					object obj187 = obj124;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2667 @ X8_v39+A0]");
					object obj188 = 0;
					obj186 = obj188;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2668 @ X8_v40+8]");
					num140 = 0.0;
				}
				float num141 = num120 * (float)num137;
				object obj189 = obj186 * obj167;
				num139 = (double)num141 * num140;
				vector2 = at2 + obj189;
				vector11 = at2;
				num138 = num139;
				vector12 = (Vector3)0;
			}
			object obj190 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2620 @ X0_v33+E4]");
			bool flag75 = (nint)0 == 0;
			object obj191 = !flag75;
			if (obj191 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num142 = num120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
			num34 = num142 * 0f;
			Add((Vector3)0, vector6, (float)at2, num143, (Vector3)num5, (int)(&p2));
			num110--;
			flag76 = num110 != 1.0;
			System.Random random2 = (System.Random)(&faces2);
			System.Random random4 = (System.Random)(&at2);
			int num71 = (int)(&p2);
			num32 = num138;
			obj25 = obj192;
			vector3 = (Vector3)0;
			num22 = num5;
			num36 = num120;
			num107 = num143;
			num111 = (float)at2;
			continue;
			IL_25ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj130 = obj132;
			obj131 = obj133;
			obj125 = obj134;
			goto IL_2614;
		}
		while (flag76);
		return;
		IL_1b5a:
		NullReferenceException ex5 = new NullReferenceException();
		num32 = num15;
		num33 = (double)val8;
		num36 = num37;
		goto IL_1b80;
		IL_224b:
		bool flag77 = num81 < 0.0;
		double num144 = 0.0;
		if (!flag77)
		{
			bool flag78 = !(num81 > 1.0);
			num144 = num81;
			if (!flag78)
			{
				num144 = 1.0;
			}
		}
		double num145 = num144 * 1119354880.0;
		double num146 = num145 + 18.0;
		double num147 = 1.5 * num146;
		object obj193 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X0_v8+E4]");
		bool flag79 = (nint)0 == 0;
		object obj194 = !flag79;
		if (obj194 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num148 = default;
		if (num147 < 0.0)
		{
			if (num147 == -0.5)
			{
				num109 = -1.0;
				num108 = num148;
				goto IL_3582;
			}
			num108 = num147 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num107 = -0.5;
		}
		else
		{
			if (num147 == 0.5)
			{
				num109 = 1.0;
				num108 = num148;
				goto IL_3582;
			}
			num108 = num147 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num107 = 0.5;
		}
		goto IL_35cc;
		IL_3203:
		double num149;
		num91 = num67 + num149;
		object obj195 = num67 & 1;
		bool flag80 = obj195 == null;
		obj121 = !flag80;
		if (obj121 != null)
		{
			num67 = num91;
		}
		goto IL_324d;
		IL_1b80:
		if (num5 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num150 = (float)val3 / j.reach;
		double num151 = 1.0 - (double)num150;
		bool flag81 = num151 < 0.0;
		num81 = 0.0;
		if (!flag81)
		{
			bool flag12 = !(num151 > 1.0);
			num81 = num151;
			if (!flag12)
			{
				num81 = 1.0;
			}
		}
		bool flag82 = rng == null;
		num15 = (int)num32;
		val8 = (Enumerator<, >)num33;
		num37 = (float)num36;
		val3 = (Enumerator<, >)num151;
		if (flag82)
		{
			goto IL_1b5a;
		}
		nint num152 = (nint)rng;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v5 (Il2CppClass<System.Random>)+1C0]");
		vector6 = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)num22);
		double num153 = num81 + 0.25;
		bool flag83 = !(1.5 < num153);
		vector3 = (Vector3)num19;
		if (flag83)
		{
			goto IL_224b;
		}
		double num154 = num81 * num81;
		double num155 = num154;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E0]");
		double num156 = num155 * 0.0;
		double num157 = num156 * 1.5;
		object obj196 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X0_v64+E4]");
		bool flag84 = (nint)0 == 0;
		object obj197 = !flag84;
		if (obj197 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num158 = default;
		if (num157 < 0.0)
		{
			if (num157 == -0.5)
			{
				num149 = -1.0;
				num67 = num158;
				goto IL_3203;
			}
			num67 = num157 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num91 = -0.5;
		}
		else
		{
			if (num157 == 0.5)
			{
				num149 = 1.0;
				num67 = num158;
				goto IL_3203;
			}
			num67 = num157 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num91 = 0.5;
		}
		goto IL_324d;
	}

	private unsafe static void Landing(Job j, System.Random rng, int many, float all, out Piece p, out Vector3 at, out Vector3 faces)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0995: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005b: Expected VT, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_09b3: Expected Obj, but got I
		//IL_09c3: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_02a0: Expected VT, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_02a8: Expected I, but got Obj
		//IL_02b7: Expected VT, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_0314: Invalid comparison between F4 and I4
		//IL_0323: Invalid comparison between F4 and I4
		//IL_033b: Expected Obj, but got F8
		//IL_0348: Expected Obj, but got F4
		//IL_037d: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_09e1: Expected Obj, but got I4
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I4
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0556: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_06da: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I4
		//IL_0746: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I4
		//IL_07c1: Expected Obj, but got I4
		//IL_07e5: Expected Obj, but got I
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected Obj, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected Obj, but got Unknown
		//IL_0a8c: Expected Obj, but got I
		//IL_0ab6: Expected Obj, but got I4
		//IL_08c7: Invalid comparison between F4 and I
		//IL_0921: Expected Obj, but got I
		//IL_0939: Expected Obj, but got I
		//IL_0951: Expected F4, but got I
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8788]");
		object obj6 = 0;
		((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)many);
		float num = all * all;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36BBD60");
		object obj8 = default;
		object obj7 = obj8 ^ obj8;
		object obj9 = many - 1;
		object obj10 = obj7 - obj9;
		bool flag2 = (nint)obj10 < 0;
		object obj11 = obj7 ^ obj9;
		object obj12 = obj7 ^ obj10;
		object obj13 = obj11 & obj12;
		bool flag3 = (nint)obj13 < 0;
		bool flag4 = flag2 == flag3;
		object obj14 = !flag4;
		object obj15 = ~obj14;
		object obj16 = ((obj15 != null) ? obj9 : obj7);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v11+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v10+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v11+18]");
		bool flag6 = (nint)obj16 < 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8768]");
			object obj22 = 0;
			object obj23 = obj20 + obj16;
			List<Piece> pieces = j.pieces;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v13+20]");
			System.__Canon _Canon = ((List<System.__Canon>)(object)pieces).get_Item(0);
			ref Piece reference = ref *(Piece*)_Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v14+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v15+A8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16+18]");
			bool flag7 = (nint)obj16 < 0;
			object obj27 = !flag7;
			if (obj27 == null)
			{
				Piece piece = p;
				Shape shape = piece.shape;
				object obj28 = obj26 + obj16;
				int[] tris = shape.tris;
				((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)obj22);
				nint num2 = (nint)rng;
				((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, (StreamingContext)obj22);
				Piece piece2 = p;
				double num3 = 1.0 - (double)num;
				float num4 = num + num;
				double num5 = 1.0 - (double)num;
				float num6 = num4 - 1f;
				bool flag8 = num6 < 0f;
				bool flag9 = num6 == 0f;
				object obj29 = (double)num4 ^ 1.0;
				object obj30 = num4 ^ num6;
				object obj31 = obj29 & obj30;
				bool flag10 = (nint)obj31 < 0;
				bool flag11 = flag8 == flag10;
				object obj32 = !flag9;
				object obj33 = flag11 & obj32;
				object obj34 = ~obj33;
				float num7 = ((obj34 != null) ? num : ((float)num5));
				bool flag12 = flag8 == flag10;
				object obj35 = !flag9;
				object obj36 = flag12 & obj35;
				object obj37 = ~obj36;
				float num8 = ((obj37 != null) ? num : ((float)num3));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+20]");
				bool flag13 = (nint)0 < (nint)tris.Length;
				object obj38 = !flag13;
				if (obj38 == null)
				{
					Vector3[] at2 = piece2.at;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+20]");
					object obj39 = tris + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v21+20]");
					bool flag14 = (nint)0 < (nint)at2.Length;
					object obj40 = !flag14;
					if (obj40 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+20]");
						object obj41 = (nint)0 + (nint)1;
						bool flag15 = (nint)obj41 < tris.Length;
						object obj42 = !flag15;
						if (obj42 == null)
						{
							object obj43 = (object)tris + obj41;
							object obj44 = obj43 + 32;
							bool flag16 = (nint)obj44 < at2.Length;
							object obj45 = !flag16;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+20]");
								object obj46 = (nint)0 + (nint)2;
								bool flag17 = (nint)obj46 < tris.Length;
								object obj47 = !flag17;
								if (obj47 == null)
								{
									object obj48 = (object)tris + obj46;
									object obj49 = obj48 + 32;
									bool flag18 = (nint)obj49 < at2.Length;
									object obj50 = !flag18;
									if (obj50 == null)
									{
										double num9 = 1.0 - (double)num8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v21+20]");
										object obj51 = (nint)0 * (nint)12;
										object obj52 = (object)at2 + obj51;
										object obj53 = obj44 * 12;
										object obj54 = (object)at2 + obj53;
										object obj55 = obj49 * 12;
										object obj56 = (object)at2 + obj55;
										double num10 = num9 - (double)num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X14_v4+20]");
										object obj58 = default;
										object obj57 = 0 * obj58;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X15_v4+20]");
										object obj60 = default;
										object obj59 = 0 * obj60;
										float num11 = num8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X14_v4+28]");
										float num12 = num11 * 0f;
										float num13 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X15_v4+28]");
										float num14 = num13 * 0f;
										object obj61 = obj57 + obj59;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X13_v4+20]");
										object obj63 = default;
										object obj62 = 0 * obj63;
										float num15 = num12 + num14;
										double num16 = num10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X13_v4+28]");
										double num17 = num16 * 0.0;
										object obj64 = obj61 + obj62;
										float num18 = num15 + (float)num17;
										ref Vector3 reference2 = ref *(Vector3*)obj64;
										Piece piece3 = p;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v17+20]");
										bool flag19 = (nint)0 < (nint)tris.Length;
										object obj65 = !flag19;
										if (obj65 == null)
										{
											Vector3[] faces2 = piece3.faces;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v21+20]");
											bool flag20 = (nint)0 < (nint)faces2.Length;
											object obj66 = !flag20;
											if (obj66 == null)
											{
												bool flag21 = (nint)obj41 < tris.Length;
												object obj67 = !flag21;
												if (obj67 == null)
												{
													bool flag22 = (nint)obj44 < faces2.Length;
													object obj68 = !flag22;
													if (obj68 == null)
													{
														bool flag23 = (nint)obj46 < tris.Length;
														object obj69 = !flag23;
														if (obj69 == null)
														{
															bool flag24 = (nint)obj49 < faces2.Length;
															object obj70 = !flag24;
															if (obj70 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v21+20]");
																object obj71 = (nint)0 * (nint)12;
																object obj72 = (object)faces2 + obj71;
																object obj73 = obj44 * 12;
																object obj74 = (object)faces2 + obj73;
																object obj75 = obj49 * 12;
																object obj76 = (object)faces2 + obj75;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X10_v7+20]");
																object obj77 = 0 * obj58;
																float num19 = num8;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X10_v7+28]");
																float num20 = num19 * 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X9_v14+20]");
																object obj78 = 0 * obj60;
																float num21 = num7;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X9_v14+28]");
																float num22 = num21 * 0f;
																object obj79 = obj77 + obj78;
																float num23 = num20 + num22;
																double num24 = num10;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v23+28]");
																double num25 = num24 * 0.0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v23+20]");
																object obj80 = 0 * obj63;
																object obj81 = obj79 + obj80;
																float num26 = num23 + (float)num25;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
																object obj82 = 0;
																object obj83 = obj82;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v24+E4]");
																bool flag25 = (nint)0 == 0;
																object obj84 = !flag25;
																if (obj84 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																float num27 = num26 * num26;
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																object obj85;
																if (num27 > 0f)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																	float num28 = num26 / num27;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																	obj85 = obj81 / 0;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																	object obj86 = 0;
																	object obj87 = obj86;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v34+A0]");
																	object obj88 = 0;
																	obj85 = obj88;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v35+8]");
																	float num28 = 0f;
																}
																ref Vector3 reference3 = ref *(Vector3*)obj85;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe static void Draw(Job j)
	{
		//IL_4843: Expected Obj, but got I
		//IL_485b: Expected Obj, but got I
		//IL_486b: Expected Obj, but got I
		//IL_4877: Unknown result type (might be due to invalid IL or missing references)
		//IL_3390: Expected Obj, but got I
		//IL_33a0: Expected Obj, but got I
		//IL_33ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_33bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d1: Expected Obj, but got I4
		//IL_33da: Expected Obj, but got I4
		//IL_48d9: Expected Obj, but got I4
		//IL_4890: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I4
		//IL_2feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff3: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I
		//IL_33ef: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Ref
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected VT, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got I4
		//IL_34eb: Expected I4, but got Obj
		//IL_47aa: Expected Obj, but got I
		//IL_47b2: Expected I, but got Obj
		//IL_47c4: Expected Obj, but got I4
		//IL_47cd: Expected Obj, but got I4
		//IL_47d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_47dd: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_3068: Unknown result type (might be due to invalid IL or missing references)
		//IL_3070: Expected VT, but got Unknown
		//IL_0370: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_3414: Unknown result type (might be due to invalid IL or missing references)
		//IL_3418: Unknown result type (might be due to invalid IL or missing references)
		//IL_341c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3421: Expected Obj, but got Unknown
		//IL_343f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3443: Unknown result type (might be due to invalid IL or missing references)
		//IL_3447: Unknown result type (might be due to invalid IL or missing references)
		//IL_344c: Expected Obj, but got Unknown
		//IL_344c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3454: Unknown result type (might be due to invalid IL or missing references)
		//IL_3459: Expected Obj, but got Unknown
		//IL_34a2: Expected Obj, but got I4
		//IL_34aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_34af: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d6: Expected VT, but got I
		//IL_34d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I4
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_48f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f5: Expected Obj, but got Unknown
		//IL_4916: Expected Obj, but got I4
		//IL_491f: Expected Obj, but got I4
		//IL_4928: Expected Obj, but got I4
		//IL_492c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04df: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_052d: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_060a: Expected Obj, but got I4
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_065e: Expected Obj, but got I4
		//IL_0667: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I4
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06e3: Expected Obj, but got I
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected VT, but got I
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected Obj, but got VT
		//IL_0777: Expected Obj, but got I
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected Obj, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected Obj, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected VT, but got Unknown
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_091e: Expected Obj, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3515: Unknown result type (might be due to invalid IL or missing references)
		//IL_3519: Unknown result type (might be due to invalid IL or missing references)
		//IL_351d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3522: Expected Obj, but got Unknown
		//IL_3540: Unknown result type (might be due to invalid IL or missing references)
		//IL_3544: Unknown result type (might be due to invalid IL or missing references)
		//IL_3548: Unknown result type (might be due to invalid IL or missing references)
		//IL_354d: Expected Obj, but got Unknown
		//IL_354d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3555: Unknown result type (might be due to invalid IL or missing references)
		//IL_355a: Expected Obj, but got Unknown
		//IL_358f: Expected Obj, but got I4
		//IL_3597: Unknown result type (might be due to invalid IL or missing references)
		//IL_359c: Expected Obj, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c0: Expected Obj, but got Unknown
		//IL_35de: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35eb: Expected Obj, but got Unknown
		//IL_35eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f8: Expected Obj, but got Unknown
		//IL_362d: Expected Obj, but got I4
		//IL_3635: Unknown result type (might be due to invalid IL or missing references)
		//IL_363a: Expected Obj, but got Unknown
		//IL_3651: Unknown result type (might be due to invalid IL or missing references)
		//IL_3661: Invalid comparison between Unknown and I
		//IL_3667: Unknown result type (might be due to invalid IL or missing references)
		//IL_366b: Unknown result type (might be due to invalid IL or missing references)
		//IL_366f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3677: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+60]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
		List<int> list = (List<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+70]");
		Enumerator<, > val2 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+6C]");
		Enumerator<, > val3 = (Enumerator<, >)0;
		object obj6 = obj4;
		object obj7 = 0;
		object obj8 = 0;
		object obj26 = default;
		Enumerator<, > val4 = default;
		Enumerator<, > val7 = default;
		object obj36 = default;
		int num2;
		Enumerator<, > val9 = default;
		object obj37 = default;
		Enumerator<, > val15 = default;
		Enumerator<, > val16 = default;
		nint num8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v213+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v213+A0]");
			object obj10 = 0;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v196+68]");
			List<int> list2;
			Vector3 vector2;
			object obj38;
			if ((nint)obj11 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v213+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v213+A0]");
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v196+60]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v196+60]");
				if ((nint)0 != 0)
				{
					object obj14 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v198+18]");
					bool flag3 = (nint)obj14 < 0;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v196+60]");
						object obj16 = 0 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A8]");
						bool flag4 = (nint)0 == 0;
						object obj17 = !flag4;
						if (obj17 == null)
						{
							obj6 = obj4;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v213+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v200+60]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v200+60]");
							if ((nint)0 == 0)
							{
								goto IL_2fd4;
							}
						}
						object obj19 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v198+18]");
						bool flag5 = (nint)obj19 < 0;
						object obj20 = !flag5;
						if (obj20 == null)
						{
							object obj21 = obj;
							object obj22 = obj13 + obj8;
							obj7++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X9_v122+A0]");
							object obj23 = 0;
							obj8 += 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v123+C]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v199+2C]");
							object obj24 = num * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v123+10]");
							object obj25 = 0 * obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X9_v120+20]");
							val4 = (Enumerator<, >)(0 - obj24);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X9_v120+24]");
							Enumerator<, > val5 = (Enumerator<, >)(0 - obj25);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X9_v120+24]");
							Enumerator<, > val6 = (Enumerator<, >)(0 + obj25);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X9_v120+20]");
							val2 = (Enumerator<, >)(0 + obj24);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
							if (val >= val4)
							{
								val = val4;
							}
							object obj27 = val3 - val2;
							bool flag6 = (nint)obj27 < 0;
							bool flag7 = obj27 == null;
							object obj28 = val3 ^ val2;
							object obj29 = val3 ^ obj27;
							object obj30 = obj28 & obj29;
							bool flag8 = (nint)obj30 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
							bool flag9 = flag6 == flag8;
							object obj31 = !flag7;
							object obj32 = flag9 & obj31;
							object obj33 = ~obj32;
							if (obj33 != null)
							{
								val3 = val2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+64]");
							Vector3 vector = (Vector3)0;
							val7 = val2;
							continue;
						}
					}
					goto IL_2fe2;
				}
			}
			else if (j != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8728]");
				object obj34 = 0;
				if (j.pieces != null)
				{
					Enumerator<, > enumerator = ((List<System.__Canon>)(object)j.pieces).GetEnumerator();
					object obj35 = (object)(&obj36);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v67+FF]");
					val2 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					vector2 = (Vector3)val7;
					Enumerator<, > val8 = (Enumerator<, >)0;
					while (true)
					{
						num2 = (int)obj34;
						object obj39;
						Enumerator<, > val10;
						Enumerator<, > val5;
						if (val9.MoveNext())
						{
							bool flag10 = obj37 == null;
							obj38 = 0;
							obj39 = 0;
							val10 = (Enumerator<, >)(ref val9);
							list2 = (List<int>)val4;
							if (flag10)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+20]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+20]");
							bool flag11 = (nint)0 == 0;
							obj38 = 0;
							obj39 = 0;
							val10 = (Enumerator<, >)(ref val9);
							list2 = (List<int>)val4;
							if (flag11)
							{
								goto IL_3099;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v194+38]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v194+38]");
							bool flag12 = (nint)0 == 0;
							obj38 = 0;
							obj39 = 0;
							val10 = (Enumerator<, >)(ref val9);
							list2 = (List<int>)val4;
							if (flag12)
							{
								goto IL_30a7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v195+18]");
							if ((nint)0 < (nint)1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+30]");
							object obj42 = 0;
							object obj43 = 2;
							list2 = (List<int>)val4;
							while (true)
							{
								object obj44 = obj43 - 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v195+18]");
								bool flag13 = (nint)obj44 < 0;
								object obj45 = !flag13;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (obj45 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+30]");
								bool flag14 = (nint)0 == 0;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (flag14)
								{
									goto IL_30c3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v194+38]");
								object obj46 = 0 + obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3659 @ X13_v59+20]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X10_v97+18]");
								bool flag15 = num3 < 0;
								object obj47 = !flag15;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (obj47 != null)
								{
									goto IL_30d1;
								}
								object obj48 = obj44 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v195+18]");
								bool flag16 = (nint)obj48 < 0;
								object obj49 = !flag16;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (obj49 != null)
								{
									goto IL_30df;
								}
								object obj50 = obj43 - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v194+38]");
								object obj51 = 0 + obj50;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4476 @ X14_v56+20]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X10_v97+18]");
								bool flag17 = num4 < 0;
								object obj52 = !flag17;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (obj52 != null)
								{
									goto IL_30ed;
								}
								object obj53 = obj48 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v195+18]");
								bool flag18 = (nint)obj53 < 0;
								object obj54 = !flag18;
								obj38 = 0;
								obj39 = 0;
								val10 = (Enumerator<, >)(ref val9);
								if (obj54 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v194+38]");
									object obj55 = 0 + obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4952 @ X16_v52+20]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X10_v97+18]");
									bool flag19 = num5 < 0;
									object obj56 = !flag19;
									obj38 = 0;
									obj39 = 0;
									val10 = (Enumerator<, >)(ref val9);
									if (obj56 != null)
									{
										goto end_IL_48b7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3659 @ X13_v59+20]");
									object obj57 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+30]");
									Enumerator<, > val11 = (Enumerator<, >)(0 + obj57);
									Enumerator<, > val12 = (Enumerator<, >)(obj53 + 1);
									obj43 += 3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4476 @ X14_v56+20]");
									object obj58 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+30]");
									Enumerator<, > val13 = (Enumerator<, >)(0 + obj58);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4952 @ X16_v52+20]");
									object obj59 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ stack_-E8_v41+30]");
									object obj60 = 0 + obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7005 @ X13_v54 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+28]");
									Enumerator<, > val14 = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X15_v53+28]");
									vector2 = (Vector3)0;
									object obj61 = val11._current + val13._current;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7005 @ X13_v54 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+28]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6856 @ X14_v52 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+28]");
									object obj62 = num6 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X15_v53+20]");
									object obj63 = obj61 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X15_v53+28]");
									object obj64 = obj62 + 0;
									object obj65 = obj63 * val15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9EC]");
									Vector3 vector = (Vector3)(obj64 * 0);
									object obj66 = val13._current - obj65;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									object obj67 = val11._current - obj65;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7005 @ X13_v54 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+28]");
									object obj68 = 0 - vector;
									object obj69 = obj66 * obj66;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6856 @ X14_v52 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+28]");
									nint num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X15_v53+28]");
									Job job = (Job)(num7 - 0);
									object obj70 = obj67 * obj67;
									val4 = (Enumerator<, >)(obj68 * obj68);
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
									object obj71 = (object)job * (object)job;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X15_v53+28]");
									object obj72 = 0 + obj69;
									val2 = (Enumerator<, >)(obj70 + val4);
									Enumerator<, > val6 = (Enumerator<, >)(obj72 + obj71);
									object obj73 = val6 - val16;
									bool flag20 = (nint)obj73 < 0;
									bool flag21 = obj73 == null;
									object obj74 = val6 ^ val16;
									object obj75 = val6 ^ obj73;
									object obj76 = obj74 & obj75;
									bool flag22 = (nint)obj76 < 0;
									bool flag23 = flag20 == flag22;
									object obj77 = !flag21;
									object obj78 = flag23 & obj77;
									object obj79 = ~obj78;
									if (obj79 != null)
									{
										val6 = val16;
									}
									object obj80 = val2 - val6;
									bool flag24 = (nint)obj80 < 0;
									bool flag25 = obj80 == null;
									object obj81 = val2 ^ val6;
									object obj82 = val2 ^ obj80;
									object obj83 = obj81 & obj82;
									bool flag26 = (nint)obj83 < 0;
									bool flag27 = flag24 == flag26;
									object obj84 = !flag25;
									object obj85 = flag27 & obj84;
									object obj86 = ~obj85;
									if (obj86 != null)
									{
										val2 = val6;
									}
									object obj87 = val2 - val8;
									bool flag28 = (nint)obj87 < 0;
									bool flag29 = obj87 == null;
									object obj88 = val2 ^ val8;
									object obj89 = val2 ^ obj87;
									object obj90 = obj88 & obj89;
									bool flag30 = (nint)obj90 < 0;
									bool flag31 = flag28 == flag30;
									object obj91 = !flag29;
									object obj92 = flag31 & obj91;
									object obj93 = ~obj92;
									if (obj93 == null)
									{
										val8 = val2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v195+18]");
									bool flag32 = (nint)val12 < (nint)0;
									val5 = val16;
									list2 = (List<int>)val4;
									if (flag32)
									{
										continue;
									}
									goto IL_0973;
								}
								goto IL_30fb;
							}
							goto IL_30b5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8720]");
						object obj94 = 0;
						num8 = (nint)obj94;
						val9.Dispose();
						obj38 = 0;
						obj39 = 0;
						val10 = (Enumerator<, >)(ref val9);
						list2 = (List<int>)val4;
						throw new OutOfMemoryException();
						IL_0973:
						val5 = val16;
					}
					goto IL_308b;
				}
			}
			goto IL_2fd4;
			IL_30d1:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			goto IL_30df;
			IL_30a7:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_30b5;
			IL_30c3:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_30d1;
			IL_30ed:
			IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			goto IL_30fb;
			IL_30df:
			IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
			goto IL_30ed;
			IL_30fb:
			IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
			break;
			IL_2fd4:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_2fe2;
			IL_308b:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_3099;
			IL_2fe2:
			IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
			list2 = (List<int>)val4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex10 = new ArgumentNullException();
			num2 = 0;
			IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
			IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
			IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
			NullReferenceException ex14 = new NullReferenceException();
			IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
			IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
			vector2 = (Vector3)val7;
			IndexOutOfRangeException ex17 = new IndexOutOfRangeException();
			obj38 = obj37;
			goto IL_308b;
			IL_3099:
			NullReferenceException ex18 = new NullReferenceException();
			goto IL_30a7;
			IL_30b5:
			IndexOutOfRangeException ex19 = new IndexOutOfRangeException();
			goto IL_30c3;
			continue;
			end_IL_48b7:
			break;
		}
		IndexOutOfRangeException ex20 = new IndexOutOfRangeException();
		NullReferenceException ex21 = new NullReferenceException();
		NullReferenceException ex22 = new NullReferenceException();
		IndexOutOfRangeException ex23 = new IndexOutOfRangeException();
		NullReferenceException ex24 = new NullReferenceException();
		IndexOutOfRangeException ex25 = new IndexOutOfRangeException();
		NullReferenceException ex26 = new NullReferenceException();
		NullReferenceException ex27 = new NullReferenceException();
		NullReferenceException ex28 = new NullReferenceException();
		NullReferenceException ex29 = new NullReferenceException();
		IndexOutOfRangeException ex30 = new IndexOutOfRangeException();
		NullReferenceException ex31 = new NullReferenceException();
		NullReferenceException ex32 = new NullReferenceException();
		num8 = num2;
		throw new NullReferenceException();
	}

	private static int Square(float at, float from, float square)
	{
		//IL_0037: Invalid comparison between F4 and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got F4
		//IL_008d: Expected Obj, but got I4
		//IL_00ba: Expected F4, but got I4
		//IL_00c8: Expected Obj, but got F4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		float num = at - from;
		float num2 = num / square;
		float num3 = num2 - 13f;
		bool flag = num3 < 0f;
		object obj = num2 ^ 0xD;
		object obj2 = num2 ^ num3;
		object obj3 = obj & obj2;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		float num4 = ((obj5 != null) ? 13f : num2);
		object obj6 = ~num4;
		return num4 & obj6;
	}

	private static void Rasterise(Job j, byte[] px, Vector2 u0, Vector2 u1, Vector2 u2, Vector3 a, Vector3 b, Vector3 c, Vector3 na, Vector3 nb, Vector3 nc)
	{
		//IL_0ead: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_0eea: Expected Obj, but got I
		//IL_0f45: Expected Obj, but got I
		//IL_0f6f: Expected Obj, but got I4
		//IL_1516: Expected Obj, but got I
		//IL_1540: Expected Obj, but got I4
		//IL_0164: Invalid comparison between F8 and I4
		//IL_0173: Invalid comparison between F8 and I4
		//IL_0186: Expected Obj, but got F8
		//IL_0193: Expected Obj, but got F8
		//IL_01c8: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0fb9: Invalid comparison between F8 and I4
		//IL_0fc8: Invalid comparison between F8 and I4
		//IL_0fdb: Expected Obj, but got F8
		//IL_0fe8: Expected Obj, but got F8
		//IL_101d: Expected Obj, but got I4
		//IL_1025: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Expected Obj, but got Unknown
		//IL_155e: Expected Obj, but got I
		//IL_1588: Expected Obj, but got I4
		//IL_023d: Invalid comparison between F8 and I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got F8
		//IL_0293: Expected Obj, but got I4
		//IL_02c0: Expected F8, but got I4
		//IL_15a6: Expected Obj, but got I
		//IL_15d0: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I4
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_1103: Expected Obj, but got I4
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Expected Obj, but got Unknown
		//IL_1618: Expected Obj, but got I
		//IL_1642: Expected Obj, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0455: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I4
		//IL_0558: Expected I4, but got F8
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got F8
		//IL_0595: Expected Obj, but got F8
		//IL_05c7: Expected Obj, but got I
		//IL_05d7: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I4
		//IL_1153: Invalid comparison between Obj and F8
		//IL_12a2: Invalid comparison between F8 and I4
		//IL_12c2: Expected Obj, but got I4
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_1175: Expected Obj, but got I4
		//IL_0700: Invalid comparison between F8 and I4
		//IL_1197: Expected Obj, but got I4
		//IL_0731: Invalid comparison between F8 and I4
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Obj, but got Unknown
		//IL_092c: Expected F8, but got I4
		//IL_093e: Expected F8, but got I4
		//IL_0947: Expected Obj, but got I4
		//IL_16e5: Expected Obj, but got I4
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_0760: Invalid comparison between Obj and F8
		//IL_12e9: Expected Obj, but got I
		//IL_12f9: Expected Obj, but got I
		//IL_09ac: Expected Obj, but got I4
		//IL_0a21: Expected Obj, but got I
		//IL_09dc: Expected Obj, but got I
		//IL_09ec: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected Obj, but got Unknown
		//IL_0af9: Expected F8, but got I4
		//IL_132e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1333: Expected Obj, but got Unknown
		//IL_1343: Expected F8, but got I
		//IL_1666: Expected Obj, but got I4
		//IL_0b6e: Invalid comparison between F8 and I4
		//IL_0b7d: Expected F8, but got I4
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected Obj, but got Unknown
		//IL_0bf1: Expected Obj, but got I4
		//IL_14a2: Invalid comparison between F8 and I4
		//IL_14b3: Expected Obj, but got I4
		//IL_14bc: Invalid comparison between F8 and I4
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Expected Obj, but got Unknown
		//IL_1501: Expected Obj, but got I4
		//IL_1683: Expected Obj, but got I
		//IL_16ad: Expected Obj, but got I4
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected Obj, but got Unknown
		//IL_0d0a: Expected Obj, but got I4
		//IL_0c33: Invalid comparison between F8 and I4
		//IL_0c44: Expected Obj, but got I4
		//IL_0c54: Invalid comparison between F8 and I
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected Obj, but got Unknown
		//IL_0db4: Invalid comparison between F8 and Obj
		//IL_0dd3: Expected F8, but got I4
		//IL_0c88: Expected Obj, but got I
		//IL_0ca0: Expected Obj, but got I
		//IL_0ca8: Expected F8, but got Obj
		//IL_0cb8: Expected F8, but got I
		//IL_0de9: Expected Obj, but got F8
		//IL_0dff: Expected F8, but got I4
		double num2 = default;
		double num3 = default;
		double num = num2 - num3;
		double num5 = default;
		double num4 = num5 - num3;
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj4 = obj5 - obj3;
		double num6 = num * (double)obj;
		double num7 = (double)obj4 * num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		if ((nint)obj < 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v4+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA3B]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				_ = 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj9 = 0;
		object obj10 = obj9;
		double num8 = num3 - num5;
		double num9 = (double)obj3 - (double)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			double num10 = num8 * num8;
			double num11 = num9 * num9;
			double num12 = num10 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			double num13 = num8 * num8;
			double num11 = num9 * num9;
			double num12 = num13 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num14 = ((!(num2 < num5)) ? num5 : num2);
		double num15 = ((!(num3 < num14)) ? num14 : num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num16 = num2 - num5;
		bool flag4 = num16 < 0.0;
		bool flag5 = num16 == 0.0;
		object obj17 = num2 ^ num5;
		object obj18 = num2 ^ num16;
		object obj19 = obj17 & obj18;
		bool flag6 = (nint)obj19 < 0;
		bool flag7 = flag4 == flag6;
		object obj20 = !flag5;
		object obj21 = flag7 & obj20;
		object obj22 = ~obj21;
		double num17 = ((obj22 != null) ? num5 : num2);
		double num18 = num3 - num17;
		bool flag8 = num18 < 0.0;
		bool flag9 = num18 == 0.0;
		object obj23 = num3 ^ num17;
		object obj24 = num3 ^ num18;
		object obj25 = obj23 & obj24;
		bool flag10 = (nint)obj25 < 0;
		bool flag11 = flag8 == flag10;
		object obj26 = !flag9;
		object obj27 = flag11 & obj26;
		object obj28 = ~obj27;
		if (obj28 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj29 = 0;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj31 = !flag12;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num19 = num17 - 255.0;
		bool flag13 = num19 < 0.0;
		object obj32 = num17 ^ 0xFF;
		object obj33 = num17 ^ num19;
		object obj34 = obj32 & obj33;
		bool flag14 = (nint)obj34 < 0;
		bool flag15 = flag13 == flag14;
		object obj35 = !flag15;
		object obj36 = ~obj35;
		double num20 = ((obj36 != null) ? 255.0 : num17);
		object obj37 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2)) ? obj2 : obj5);
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37))
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj41 = obj5 - obj2;
		bool flag17 = (nint)obj41 < 0;
		bool flag18 = obj41 == null;
		object obj42 = obj5 ^ obj2;
		object obj43 = obj5 ^ obj41;
		object obj44 = obj42 & obj43;
		bool flag19 = (nint)obj44 < 0;
		bool flag20 = flag17 == flag19;
		object obj45 = !flag18;
		object obj46 = flag20 & obj45;
		object obj47 = ~obj46;
		object obj48 = ((obj47 != null) ? obj2 : obj5);
		object obj49 = obj3 - obj48;
		bool flag21 = (nint)obj49 < 0;
		bool flag22 = obj49 == null;
		object obj50 = obj3 ^ obj48;
		object obj51 = obj3 ^ obj49;
		object obj52 = obj50 & obj51;
		bool flag23 = (nint)obj52 < 0;
		bool flag24 = flag21 == flag23;
		object obj53 = !flag22;
		object obj54 = flag24 & obj53;
		object obj55 = ~obj54;
		object obj56 = ((obj55 != null) ? obj48 : obj3);
		double num21 = (double)obj56 + 0.5;
		object obj57 = ~obj37;
		object obj58 = obj37 & obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj59 = 0;
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v50+E4]");
		bool flag25 = (nint)0 == 0;
		object obj61 = !flag25;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj62 = obj37 - 255;
		bool flag26 = (nint)obj62 < 0;
		object obj63 = obj37 ^ 0xFF;
		object obj64 = obj37 ^ obj62;
		object obj65 = obj63 & obj64;
		bool flag27 = (nint)obj65 < 0;
		bool flag28 = flag26 == flag27;
		object obj66 = !flag28;
		object obj67 = ~obj66;
		object obj68 = ((obj67 != null) ? ((object)255) : obj37);
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
		{
			return;
		}
		double num22 = num6 - num7;
		double num23 = num5 - num2;
		object obj69 = obj2 - obj5;
		object obj70 = obj4 * obj4;
		double num24 = 1.0 / num22;
		double num25 = num23 * num23;
		object obj71 = obj69 * obj69;
		double num26 = num25 + (double)obj71;
		double num27 = num * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num28 = num27 + (double)obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num29 = num15 + -1.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		bool flag29 = (byte)(int)(~num29) != 0;
		object obj72 = num29 & flag29;
		double num30 = num26 * num24;
		object obj73 = 0.0 - num30;
		double num31 = num9 * num24;
		object obj74 = 0.0 - num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num32 = num28 * num24;
		double num33 = 0.0 - num32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
		object obj76 = 0;
		byte[] array = px;
		double num34 = num24;
		double num36 = default;
		double num35 = num36;
		double num38 = default;
		double num37 = num38;
		object obj78 = default;
		object obj77 = obj78;
		double num40 = default;
		double num39 = num40;
		object obj79 = 255;
		double num41 = 0.5;
		object obj80 = obj37;
		double num43 = default;
		double num42 = num43;
		double num44 = num33;
		object obj87 = default;
		object obj88 = default;
		object obj90 = default;
		object obj91 = default;
		object obj93 = default;
		object obj94 = default;
		object obj95 = default;
		object obj99 = default;
		object obj100 = default;
		double num70 = default;
		IntPtr intPtr = default;
		object obj104 = default;
		object obj105 = default;
		object obj121 = default;
		bool flag48;
		do
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj72) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num20))
			{
				List<int> list = (List<int>)(obj58 << 10);
				double num45 = (double)obj58 + 0.5;
				double num46 = (double)obj2 - num45;
				double num47 = (double)obj5 - num45;
				double num48 = (double)obj3 - num45;
				object obj81 = obj72;
				List<int> list2 = list;
				object obj82 = obj58;
				bool flag47;
				do
				{
					double num49 = (double)obj81 + 0.5;
					double num50 = num2 - num49;
					double num51 = num5 - num49;
					double num52 = num3 - num49;
					double num53 = num46 * num50;
					double num54 = num47 * num51;
					double num55 = num53 - num54;
					double num56 = num48 * num51;
					double num57 = num46 * num52;
					num44 = num24 * num55;
					double num58 = num56 - num57;
					double num59 = 1.0 - num44;
					num28 = num24 * num58;
					double num60 = num44 - (double)obj73;
					bool flag30 = num60 < 0.0;
					num42 = num59 - num28;
					object obj83 = !flag30;
					object obj84 = ~obj83;
					bool flag31;
					if (obj84 == null)
					{
						double num61 = num28 - (double)obj74;
						flag31 = num61 < 0.0;
					}
					else
					{
						flag31 = true;
					}
					object obj85 = !flag31;
					obj67 = ~obj85;
					bool flag32;
					if (obj67 == null)
					{
						double num62 = num42 - num33;
						flag32 = num62 < 0.0;
					}
					else
					{
						flag32 = true;
					}
					object obj86 = !flag32;
					num34 = num46;
					obj77 = obj73;
					num39 = num33;
					if (obj86 != null)
					{
						double num63 = (double)obj87 * num44;
						double num64 = (double)obj88 * num28;
						object obj89 = obj90 * obj91;
						object obj92 = obj93 * obj94;
						num35 = (double)obj95 * num42;
						object obj96 = (object)list + obj81;
						double num65 = num63 + num64;
						object obj97 = obj89 + obj92;
						object obj98 = obj99 * obj100;
						double num66 = num65 + num35;
						object obj101 = obj97 + obj98;
						double num67 = num66 * num66;
						object obj102 = obj101 * obj101;
						double num68 = num67 + (double)obj102;
						double num69 = num70 + num68;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						double num71 = (double)obj101 / num69;
						num34 = (double)nc * (double)obj94;
						double num72 = num66 / num70;
						object obj103 = na * obj91;
						double num73 = (double)nb * num44;
						double num74 = (double)(nint)intPtr * num28;
						num39 = (double)obj103 + num34;
						obj77 = obj104 * obj100;
						num44 = num73 + num74;
						num28 = (double)obj105 * num42;
						num9 = num39 + (double)obj77;
						num7 = num44 + num28;
						num37 = num70;
						num6 = 0.0;
						int num75 = 0;
						num41 = 0.0;
						obj82 = 0;
						while (true)
						{
							obj60 = obj75;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v50+E4]");
							bool flag33 = (nint)0 == 0;
							object obj106 = !flag33;
							if (obj106 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj60 = obj75;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v50+A0]");
							obj79 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+70]");
							list2 = (List<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+70]");
							if ((nint)0 != 0)
							{
								int num76 = num75;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v55 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)num76 >= (nint)0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v50+E4]");
								bool flag34 = (nint)0 == 0;
								object obj107 = !flag34;
								if (obj107 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj108 = obj75;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v80+A0]");
									obj79 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+70]");
									list2 = (List<int>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+70]");
									if ((nint)0 == 0)
									{
										goto IL_0e04;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+58]");
								object obj109 = 0;
								int num77 = list2.get_Item(num75);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+58]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X26_v8+18]");
									bool flag35 = (nint)num77 < (nint)0;
									object obj110 = !flag35;
									if (obj110 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X9_v10+58]");
										object obj111 = (nint)0 + (nint)32;
										object obj112 = obj111 + num77;
										double num78 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+8]");
										double num79 = num78 - 0.0;
										double num80 = num9 - (double)obj112;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+30]");
										nint num81 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
										bool flag36 = num81 <= 0;
										double num82 = 0.0;
										if (!flag36)
										{
											double num83 = num80;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+24]");
											double num84 = num83 * 0.0;
											double num85 = num79;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+2C]");
											num35 = num85 * 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											double num86 = num84 + num35;
											double num87 = num86;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+30]");
											double num88 = num87 / 0.0;
											bool flag37 = num88 < 0.0;
											num82 = 0.0;
											if (!flag37)
											{
												bool flag38 = !(num88 > 1.0);
												num82 = num88;
												if (!flag38)
												{
													num82 = 1.0;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+24]");
										obj77 = 0 * obj100;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+34]");
										num34 = 0.0;
										double num89 = num82;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+2C]");
										num39 = num89 * 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+38]");
										double num90 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+34]");
										num37 = num90 - 0.0;
										double num91 = num80 - (double)obj77;
										double num92 = num79 - num39;
										num42 = num82 * num37;
										num28 = num91 * num91;
										double num93 = num92 * num92;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+34]");
										num21 = 0.0 + num42;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										num15 = num28 + num93;
										num44 = num21 * num21;
										if (num15 < num44)
										{
											object obj113 = obj82 & 1;
											bool flag39 = obj113 == null;
											object obj114 = !flag39;
											if (obj114 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
												object obj115 = 0;
												object obj116 = obj115;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X0_v38+E4]");
												bool flag40 = (nint)0 == 0;
												object obj117 = !flag40;
												if (obj117 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												double num94 = num70;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
												double num95 = num94 - 0.0;
												bool flag41 = num95 == 0.0;
												obj53 = !flag41;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
												bool flag42 = num70 > 0.0;
												num6 = num72;
												num41 = num71;
												if (!flag42)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
													object obj118 = 0;
													object obj119 = obj118;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v76+A0]");
													object obj120 = 0;
													num6 = (double)obj120;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1454 @ X8_v77+4]");
													num41 = 0.0;
												}
											}
											double num96 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+18]");
											double num97 = num96 * 0.0;
											double num98 = num41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+1C]");
											double num99 = num98 * 0.0;
											double num100 = num97 + num99;
											double num101 = (double)obj121 + num100;
											double num102 = num101;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
											double num103 = num102 + 0.0;
											num44 = num103 * 3.0;
											bool flag43 = num44 < 0.0;
											object obj122 = !flag43;
											bool flag44 = num44 == 0.0;
											object obj123 = ~obj122;
											object obj124 = obj123 | flag44;
											num28 = 3.0;
											if (obj124 == null)
											{
												if (px == null)
												{
													goto IL_0e04;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v5+3C]");
												object obj125 = obj96 + 0;
												bool flag45 = (nint)obj125 < px.Length;
												object obj126 = !flag45;
												if (obj126 != null)
												{
													goto IL_0e12;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
												object obj127 = (object)px + obj125;
												object obj128 = obj127 + 32;
												double num104 = 3.0 / num21;
												double num105 = 1.0 - num104;
												double num106 = num105 * 3.0;
												double num107 = num106 * num44;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
												num44 = num107 * 1132396544.0;
												bool flag46 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num44) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj128);
												num42 = 3.0;
												num28 = 1132396544.0;
												if (!flag46)
												{
													obj128 = num44;
													num42 = 3.0;
													num28 = 1132396544.0;
												}
											}
											obj82 = 1;
										}
										int num108 = num75 + 1;
										array = (byte[])num75;
										num75 = num108;
										continue;
									}
									goto IL_0e12;
								}
							}
							goto IL_0e04;
							IL_0e04:
							NullReferenceException ex = new NullReferenceException();
							goto IL_0e12;
							IL_0e12:
							throw new IndexOutOfRangeException();
						}
					}
					obj80 = obj81 + 1;
					flag47 = obj81 != (object)num20;
					obj81 = obj80;
				}
				while (flag47);
			}
			object obj129 = obj58 + 1;
			flag48 = obj58 != obj68;
			obj79 = obj68;
			obj58 = obj129;
		}
		while (flag48);
	}

	static GillaStains()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_062c: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I
		//IL_06cc: Expected Obj, but got I
		//IL_06f6: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I
		//IL_0732: Expected Obj, but got I
		//IL_0742: Expected Obj, but got I
		//IL_0771: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_050c: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8790]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87B0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87C0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3+A0]");
		object obj8 = 0;
		obj8 = list;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Stack<System.__Canon> stack = default;
		stack._002Ector();
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = stack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7+A0]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8+A0]");
		object obj15 = (nint)0 + (nint)24;
		obj15 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87F0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v13+A0]");
		object obj18 = (nint)0 + (nint)32;
		obj18 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87E8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary3 = default;
		dictionary3._002Ector();
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v18+A0]");
		object obj21 = (nint)0 + (nint)40;
		obj21 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v31+E4]");
		bool flag = (nint)0 == 0;
		object obj23 = !flag;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8808]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8800]");
		object name2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8818]");
		object name3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8810]");
		object name4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87D0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87F8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73F0]");
		object obj27 = 0;
		object obj28 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v35+E4]");
		bool flag2 = (nint)0 == 0;
		object obj29 = !flag2;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v35+A0]");
		object obj30 = 0;
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X9_v1+A0]");
		object obj32 = (nint)0 + (nint)48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v23+30]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)name);
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24+A0]");
		object obj34 = 0;
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker((string)name2, 1, (MarkerFlags)0, 0);
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v26+A0]");
		object obj36 = 0;
		IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker((string)name3, 1, (MarkerFlags)0, 0);
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v28+A0]");
		object obj38 = 0;
		IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker((string)name4, 1, (MarkerFlags)0, 0);
		object obj39 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v30+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj41 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v32+A0]");
		object obj42 = (nint)0 + (nint)88;
		object obj43 = default;
		obj42 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v35+A0]");
		object obj45 = (nint)0 + (nint)96;
		object obj46 = default;
		obj45 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list2 = default;
		list2._002Ector();
		object obj47 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v38+A0]");
		object obj48 = (nint)0 + (nint)112;
		obj48 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj50 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v41+A0]");
		object obj51 = (nint)0 + (nint)120;
		object obj52 = default;
		obj51 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list3 = default;
		list3._002Ector();
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v44+A0]");
		object obj54 = (nint)0 + (nint)128;
		obj54 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj55 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v45+A0]");
		object obj56 = (nint)0 + (nint)136;
		object obj57 = default;
		obj56 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj58 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v48+A0]");
		object obj59 = (nint)0 + (nint)144;
		object obj60 = default;
		obj59 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj62 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v53+A0]");
		object obj63 = (nint)0 + (nint)152;
		object obj64 = default;
		obj63 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj66 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v56+A0]");
		object obj67 = (nint)0 + (nint)160;
		object obj68 = default;
		obj67 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj69 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v59+A0]");
		object obj70 = (nint)0 + (nint)168;
		object obj71 = default;
		obj70 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj73 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v64+A0]");
		object obj74 = (nint)0 + (nint)176;
		object obj75 = default;
		obj74 = obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
