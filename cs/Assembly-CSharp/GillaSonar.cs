using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaSonar : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass52_0
	{
		public Dictionary<Vector3Int, List<int>> cells;

		public List<Vector3> points;

		public Dictionary<int, List<int>> next;

		public Vector3 p;

		public Vector3 u;

		public Vector3 w;

		public HashSet<long> used;

		public List<List<int>> rings;

		public List<List<int>> loose;

		public Dictionary<long, int> mids;

		public List<Vector3> points3;
	}

	public Material ghost;

	public AudioClip ping;

	public float every;

	[NonSerialized]
	public float lasts;

	public Color apeColour;

	public Color monsterColour;

	private static bool On__BackingField;

	private static float Fade__BackingField;

	private static bool Pulsing__BackingField;

	private static int Pings__BackingField;

	public static readonly List<(GameObject, bool)> Extra;

	private const float JustDied = default(float);

	private static readonly int ColorId;

	private static readonly int FadeId;

	private static GillaSonar current;

	private readonly Dictionary<SkinnedMeshRenderer, GillaSplashDirector.Copy> ghosts;

	private readonly List<GillaSplashDirector.Copy> lit;

	private readonly List<SkinnedMeshRenderer> gone;

	private readonly List<SkinnedMeshRenderer> parts;

	private MaterialPropertyBlock block;

	private AudioClip[] pings;

	private int lastPulse;

	private float nextSweep;

	public static bool On
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0079: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
			return (byte)(int)obj4 != 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
			obj4 = value;
		}
	}

	public static float Fade
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+4]");
			return 0f;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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

	public static bool Pulsing
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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

	public static int Pings
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+C]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
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
		object obj4 = (nint)0 + (nint)32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_06c1: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I
		//IL_056f: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I
		//IL_05dd: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_0726: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_073b: Expected Obj, but got I
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Ref, but got Unknown
		//IL_069b: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v1+20]");
		bool flag3 = (UnityEngine.Object)0 == this;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = this;
		if (!flag4)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v72+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v72+A0]");
			object obj11 = (nint)0 + (nint)32;
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = null;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+A0]");
		object obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+A0]");
		object obj18 = 0;
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+A0]");
		List<GillaSplashDirector.Copy> list = (List<GillaSplashDirector.Copy>)0;
		_ = 0;
		bool flag10 = lit == null;
		List<GillaSplashDirector.Copy> list3 = default;
		List<GillaSplashDirector.Copy> list2 = list3;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj20 = 0;
		object obj21 = 109891584;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7758]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7750]");
			obj21 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)lit).GetEnumerator();
			obj20 = 0;
			list = list3;
			Enumerator<, > val2 = default;
			object obj30 = default;
			while (true)
			{
				obj8 = (UnityEngine.Object)obj22;
				object obj25;
				Enumerator<, > val3;
				Enumerator<, > val4;
				if (val.MoveNext())
				{
					if (list3 != null)
					{
						object obj23 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v48+E4]");
						list = (List<GillaSplashDirector.Copy>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v48+E4]");
						bool flag11 = (nint)0 == 0;
						object obj24 = !flag11;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = (UnityEngine.Object)(object)list3._items != null;
						bool flag13 = !flag12;
						obj20 = 0;
						if (flag13)
						{
							continue;
						}
						bool flag14 = list3._items == null;
						obj20 = 0;
						obj8 = null;
						if (!flag14)
						{
							((Renderer)(object)list3._items).enabled = false;
							obj20 = 0;
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					list2 = null;
					val = val2;
					obj25 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					break;
				}
				object obj26 = 5;
				list2 = null;
				val = val2;
				obj25 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				object obj27 = 0;
				while (true)
				{
					obj8 = (UnityEngine.Object)obj21;
					((Enumerator<, >*)val4)->Dispose();
					bool flag15 = obj27 == null;
					object obj28 = !flag15;
					if (obj28 == null)
					{
						bool flag16 = list2 == null;
						object obj29 = !flag16;
						OutOfMemoryException ex3 = (OutOfMemoryException)val4;
						list = list2;
						if (obj29 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj8 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list2 = (List<GillaSplashDirector.Copy>)1;
						list = (List<GillaSplashDirector.Copy>)1;
						obj27 = obj25;
					}
					else
					{
						if ((nint)obj8 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E260");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj27 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj25 = obj30;
					}
					obj26 = 0;
				}
				if ((nint)obj26 != 5)
				{
					bool flag17 = obj26 == null;
					object obj31 = !flag17;
					if (obj31 != null)
					{
						return;
					}
				}
				list = lit;
				if (lit == null)
				{
					break;
				}
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	public static bool Yours(GillaModeRound round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_02e5: Expected I4, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)round == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)round == null)
			{
				goto IL_02d7;
			}
			if (round.Live)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v13+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = (UnityEngine.Object)((SimulationBehaviour)round)._runner == (UnityEngine.Object)null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v17+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool outOfHunt = GillaMapVote.OutOfHunt;
					bool flag8 = !outOfHunt;
					object obj11 = !flag8;
					if (obj11 == null)
					{
						NetworkDictionary<PlayerRef, byte> players = round.Players;
						if ((object)((SimulationBehaviour)round)._runner == null)
						{
							goto IL_02d7;
						}
						PlayerRef localPlayer = ((SimulationBehaviour)round)._runner.LocalPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
						object obj14 = default;
						object obj13 = obj14 & 1;
						if (obj13 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
							object obj15 = 0;
							object obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v27+E4]");
							bool flag9 = (nint)0 == 0;
							object obj17 = !flag9;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj19 = default;
							object obj18 = obj19 & 0xFFFFFFFDL;
							object obj20 = obj18 - 1;
							return obj20 == null;
						}
					}
				}
			}
		}
		return false;
		IL_02d7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static bool Glows(GillaModeRound round, PlayerRef who, out bool hunter)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0481: Expected I4, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01f2: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_03f0: Invalid comparison between F4 and I4
		//IL_03ff: Invalid comparison between F4 and I4
		//IL_0417: Expected Obj, but got F8
		//IL_0424: Expected Obj, but got F4
		//IL_0459: Expected Obj, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		ref bool reference = ref *(bool*)null;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)round == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)round == null)
			{
				goto IL_0473;
			}
			if (round.Live)
			{
				NetworkDictionary<PlayerRef, byte> players = round.Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
				object obj5 = 0;
				object obj6 = who & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
				object obj8 = default;
				object obj7 = obj8 & 1;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v17+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = default;
					object obj12 = obj13 & 0xFFFFFFFDL;
					if ((nint)obj12 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj14 = 0;
						object obj15 = obj13 - 3;
						bool flag5 = obj15 == null;
						reference = ref *(flag5 ? ((bool*)1) : ((bool*)null));
						object obj16 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v19+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayerRef playerRef = default;
						int playerId = playerRef.PlayerId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v19+E4]");
						bool flag7 = (nint)0 == 0;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaCorpse gillaCorpse = GillaCorpse.Find(playerId);
						object obj21 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20+E4]");
						bool flag8 = (nint)0 == 0;
						object obj22 = !flag8;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag9 = gillaCorpse == null;
						bool flag10 = !flag9;
						object obj23 = !flag10;
						if (obj23 == null)
						{
							if ((object)gillaCorpse == null)
							{
								goto IL_0473;
							}
							if (!gillaCorpse.OnATimer)
							{
								bool flag11 = gillaCorpse.Has(0);
								bool flag12 = !flag11;
								object obj24 = !flag12;
								if (obj24 != null || ~(gillaCorpse.Ripped__BackingField ? 1u : 0u) == 0)
								{
									float time = Time.time;
									float num = time - gillaCorpse.MadeAt__BackingField;
									float num2 = num - 3f;
									bool flag13 = num2 < 0f;
									bool flag14 = num2 == 0f;
									object obj25 = (double)num ^ 3.0;
									object obj26 = num ^ num2;
									object obj27 = obj25 & obj26;
									bool flag15 = (nint)obj27 < 0;
									bool flag16 = flag13 == flag15;
									object obj28 = !flag14;
									return (byte)((flag16 & obj28) ? 1 : 0) != 0;
								}
							}
						}
						return true;
					}
				}
			}
		}
		return false;
		IL_0473:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool InIt(byte part)
	{
		//IL_001c: Expected Obj, but got I4
		int num = part & 0xFD;
		object obj = num - 1;
		return obj == null;
	}

	public unsafe static void ForScreen(bool drawing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got VT
		//IL_0587: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Ref, but got Unknown
		//IL_050f: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_0309: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected I4, but got Unknown
		//IL_0262: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		UnityEngine.Object obj6 = (UnityEngine.Object)((Enumerator<, >)0)._current;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v7+20]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v7+20]");
		bool flag6 = (nint)0 == 0;
		object obj14 = default;
		object obj13 = obj14;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj15 = 0;
		UnityEngine.Object obj16 = null;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8+60]");
			bool flag7 = (nint)0 == 0;
			obj13 = obj14;
			val = (Enumerator<, >)0;
			obj15 = 0;
			obj16 = null;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v8+60]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				obj = (drawing ? 1 : 0) ^ 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7758]");
				obj6 = (UnityEngine.Object)0;
				obj15 = 0;
				Enumerator<, > val2 = default;
				object obj24 = default;
				object obj19;
				Enumerator<, > val3;
				Enumerator<, > val4;
				Enumerator<, > val5;
				while (true)
				{
					if (val.MoveNext())
					{
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ stack_-58+1C]");
							if ((nint)0 == 0)
							{
								continue;
							}
							object obj17 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v38+E4]");
							bool flag8 = (nint)0 == 0;
							object obj18 = !flag8;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ stack_-58+10]");
							bool flag9 = (UnityEngine.Object)0 != null;
							bool flag10 = !flag9;
							obj15 = 0;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ stack_-58+10]");
								bool flag11 = (nint)0 == 0;
								obj15 = 0;
								obj16 = null;
								if (flag11)
								{
									break;
								}
								bool forceRenderingOff = (byte)(obj & 1) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ stack_-58+10]");
								((Renderer)0).forceRenderingOff = forceRenderingOff;
								obj15 = 0;
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						obj16 = obj6;
						break;
					}
					obj13 = 0;
					val = val2;
					obj19 = 0;
					val3 = (Enumerator<, >)(ref val);
					val4 = val2;
					val5 = (Enumerator<, >)(ref val);
					object obj20 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7750]");
						object obj21 = 0;
						obj16 = (UnityEngine.Object)obj21;
						((Enumerator<, >*)val5)->Dispose();
						bool flag12 = obj20 == null;
						object obj22 = !flag12;
						if (obj22 == null)
						{
							bool flag13 = obj13 == null;
							object obj23 = !flag13;
							OutOfMemoryException ex2 = (OutOfMemoryException)val5;
							if (obj23 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex2 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj16 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj13 = 1;
							obj20 = obj19;
							continue;
						}
						if ((nint)obj16 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj20 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj19 = obj24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E260");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				NullReferenceException ex3 = new NullReferenceException();
				obj13 = 0;
				val = val2;
				obj19 = 0;
				val3 = (Enumerator<, >)(ref val);
				val4 = val2;
				val5 = (Enumerator<, >)(ref val);
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_22ed: Expected Obj, but got I
		//IL_230f: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_2335: Expected Obj, but got I
		//IL_2357: Expected Obj, but got I4
		//IL_2db2: Expected VT, but got I
		//IL_2dd2: Expected Obj, but got I
		//IL_2df4: Expected Obj, but got I4
		//IL_06fc: Expected I4, but got I8
		//IL_0705: Expected F8, but got I4
		//IL_070e: Expected VT, but got I4
		//IL_23dc: Expected Obj, but got I4
		//IL_0102: Expected VT, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected VT, but got I4
		//IL_253b: Expected Obj, but got I4
		//IL_2e0b: Invalid comparison between F8 and I4
		//IL_2e1a: Invalid comparison between F8 and I4
		//IL_2e2d: Expected Obj, but got F8
		//IL_2e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e3a: Expected Obj, but got Unknown
		//IL_2e59: Expected Obj, but got I
		//IL_2e72: Expected Obj, but got I4
		//IL_2e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e7f: Expected I4, but got Unknown
		//IL_256b: Expected Obj, but got I4
		//IL_2e99: Expected Obj, but got I
		//IL_2ebb: Expected Obj, but got I4
		//IL_2581: Unknown result type (might be due to invalid IL or missing references)
		//IL_2586: Expected Obj, but got Unknown
		//IL_25a8: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_2ed0: Expected Obj, but got I
		//IL_07f6: Expected Obj, but got I
		//IL_0264: Expected VT, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected VT, but got I4
		//IL_0794: Expected Obj, but got I
		//IL_2613: Expected Obj, but got I4
		//IL_2620: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected F8, but got I4
		//IL_25e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected F8, but got I4
		//IL_2661: Expected Obj, but got I4
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got I4
		//IL_2eed: Expected Obj, but got I
		//IL_2691: Expected Obj, but got I4
		//IL_2f07: Expected Obj, but got I
		//IL_2f2b: Expected Obj, but got I4
		//IL_2f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f39: Expected Obj, but got Unknown
		//IL_08ac: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got I4
		//IL_2375: Expected Obj, but got I
		//IL_239f: Expected Obj, but got I4
		//IL_03b0: Invalid comparison between F4 and I4
		//IL_03bf: Expected F8, but got I4
		//IL_03c7: Expected VT, but got F4
		//IL_26c5: Expected VT, but got I
		//IL_26e7: Expected Obj, but got I4
		//IL_043b: Expected F8, but got I4
		//IL_0443: Expected VT, but got F8
		//IL_2724: Expected Obj, but got I4
		//IL_2f66: Expected Obj, but got I
		//IL_2f80: Expected Obj, but got I4
		//IL_2f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8d: Expected Obj, but got Unknown
		//IL_2f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9b: Expected Obj, but got Unknown
		//IL_2fb5: Expected Obj, but got I4
		//IL_2fc0: Expected VT, but got I4
		//IL_2fc9: Expected Obj, but got I4
		//IL_2fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fff: Expected Obj, but got I4
		//IL_0487: Invalid comparison between F4 and I4
		//IL_0496: Expected F8, but got I4
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Expected VT, but got Unknown
		//IL_14f0: Expected Obj, but got I4
		//IL_2411: Invalid comparison between F4 and I4
		//IL_2420: Expected F8, but got I4
		//IL_0963: Expected Obj, but got I4
		//IL_2447: Invalid comparison between F4 and I4
		//IL_2455: Expected VT, but got F8
		//IL_09aa: Expected VT, but got I4
		//IL_09b3: Expected Obj, but got I4
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got I4
		//IL_052a: Expected I4, but got F4
		//IL_153d: Expected Obj, but got I
		//IL_154d: Expected Obj, but got I
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0a37: Expected Obj, but got I4
		//IL_0a40: Expected Obj, but got I4
		//IL_1f4e: Expected VT, but got F8
		//IL_18ea: Expected VT, but got F4
		//IL_18f2: Expected Obj, but got I4
		//IL_2abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac6: Expected VT, but got Unknown
		//IL_2ace: Expected Obj, but got I4
		//IL_0ab2: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_2742: Expected Obj, but got I
		//IL_2764: Expected VT, but got I4
		//IL_276d: Expected Obj, but got I4
		//IL_2773: Unknown result type (might be due to invalid IL or missing references)
		//IL_2785: Unknown result type (might be due to invalid IL or missing references)
		//IL_2792: Unknown result type (might be due to invalid IL or missing references)
		//IL_279a: Expected VT, but got Unknown
		//IL_27a2: Expected Obj, but got I4
		//IL_0a63: Expected Obj, but got I
		//IL_1928: Expected VT, but got I4
		//IL_1943: Expected I4, but got VT
		//IL_157f: Expected I4, but got Obj
		//IL_15c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ca: Expected VT, but got Unknown
		//IL_15d2: Expected Obj, but got I4
		//IL_15da: Expected Obj, but got I4
		//IL_2489: Expected VT, but got F4
		//IL_19c5: Expected VT, but got F4
		//IL_19cd: Expected Obj, but got I4
		//IL_0b13: Expected Obj, but got I
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected I4, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected I4, but got Unknown
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected I4, but got Unknown
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected I4, but got Unknown
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got I
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected VT, but got I
		//IL_061c: Expected Obj, but got I4
		//IL_1612: Expected Obj, but got I4
		//IL_1a06: Expected Obj, but got I
		//IL_1a16: Expected Obj, but got I
		//IL_1a1e: Expected VT, but got Ref
		//IL_1641: Expected Obj, but got I
		//IL_10d5: Expected VT, but got I4
		//IL_10de: Expected Obj, but got I4
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected F8, but got I4
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected Obj, but got I4
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Expected VT, but got I4
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected Obj, but got I4
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected VT, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected VT, but got Unknown
		//IL_1179: Expected Obj, but got I4
		//IL_16be: Expected Obj, but got I4
		//IL_2c8b: Expected Obj, but got I
		//IL_2c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9c: Expected Ref, but got Unknown
		//IL_2cb6: Expected Obj, but got I4
		//IL_2cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cce: Expected Obj, but got I4
		//IL_0bd8: Expected Obj, but got I4
		//IL_24be: Expected VT, but got I4
		//IL_24c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e3: Expected VT, but got F8
		//IL_0687: Expected Obj, but got I4
		//IL_2d49: Expected Obj, but got I
		//IL_2d6b: Expected F8, but got I4
		//IL_2d74: Expected Obj, but got I4
		//IL_2d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected Obj, but got I
		//IL_0bff: Expected Obj, but got F8
		//IL_0c1d: Expected Obj, but got I4
		//IL_1a4d: Expected Obj, but got I4
		//IL_17bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c4: Expected VT, but got Unknown
		//IL_17cc: Expected Obj, but got I4
		//IL_181b: Expected Obj, but got I4
		//IL_1187: Invalid comparison between F8 and I4
		//IL_1198: Expected Obj, but got I4
		//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected Obj, but got I4
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected Obj, but got Unknown
		//IL_1f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8c: Expected Obj, but got Unknown
		//IL_1fae: Expected Obj, but got I4
		//IL_06a8: Expected VT, but got I4
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected VT, but got F8
		//IL_1a74: Expected Obj, but got F8
		//IL_1a92: Expected Obj, but got I4
		//IL_1743: Unknown result type (might be due to invalid IL or missing references)
		//IL_174b: Expected VT, but got Unknown
		//IL_1753: Expected Obj, but got I4
		//IL_0c3d: Invalid comparison between F8 and I4
		//IL_0c4e: Expected VT, but got I4
		//IL_0c57: Expected Obj, but got I4
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected F8, but got I4
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected Obj, but got I4
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected VT, but got I4
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected VT, but got Unknown
		//IL_0cd3: Expected Obj, but got I4
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected VT, but got Unknown
		//IL_2b5d: Expected Obj, but got I
		//IL_2b87: Expected Obj, but got I4
		//IL_1bd6: Expected F8, but got I4
		//IL_1bdf: Expected Obj, but got I4
		//IL_1be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c07: Expected I4, but got F8
		//IL_17e2: Expected I4, but got Obj
		//IL_17fc: Expected Obj, but got I4
		//IL_20cb: Expected F4, but got I
		//IL_20e5: Expected VT, but got I4
		//IL_2114: Expected Obj, but got I4
		//IL_1fe2: Expected Obj, but got I
		//IL_2016: Expected VT, but got I4
		//IL_201c: Unknown result type (might be due to invalid IL or missing references)
		//IL_202e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2043: Expected VT, but got F8
		//IL_2055: Expected Obj, but got I4
		//IL_1ace: Expected F8, but got I4
		//IL_1ad7: Expected Obj, but got I4
		//IL_1adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b05: Expected I4, but got F8
		//IL_1785: Expected Obj, but got I
		//IL_123a: Expected Obj, but got I4
		//IL_0d05: Expected Obj, but got F8
		//IL_0d23: Expected Obj, but got I4
		//IL_1c2a: Expected VT, but got Obj
		//IL_1c6f: Expected F8, but got I4
		//IL_1c78: Expected Obj, but got I4
		//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Expected I4, but got F8
		//IL_223f: Expected F8, but got I4
		//IL_2919: Expected Obj, but got I
		//IL_2938: Unknown result type (might be due to invalid IL or missing references)
		//IL_293c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2948: Expected Obj, but got I4
		//IL_11fd: Expected Obj, but got I4
		//IL_2bc4: Expected Obj, but got I4
		//IL_2072: Expected I4, but got Obj
		//IL_1b3d: Expected Obj, but got I4
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ae: Expected Obj, but got I4
		//IL_22b6: Expected I4, but got Obj
		//IL_0d57: Expected Obj, but got I
		//IL_0d79: Expected Obj, but got I4
		//IL_3196: Expected Obj, but got I
		//IL_31ac: Expected Obj, but got I
		//IL_1cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce5: Expected Obj, but got I4
		//IL_1b6c: Expected Obj, but got I
		//IL_1276: Expected Obj, but got I
		//IL_1271: Unknown result type (might be due to invalid IL or missing references)
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected Obj, but got I
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected VT, but got Obj
		//IL_2bf4: Expected Obj, but got I4
		//IL_1d6f: Expected Obj, but got I
		//IL_1d7f: Expected Obj, but got I
		//IL_1da1: Expected Obj, but got F8
		//IL_31c1: Expected Obj, but got I
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0a: Expected Obj, but got Unknown
		//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d38: Expected Obj, but got Unknown
		//IL_1d40: Expected Obj, but got F8
		//IL_1d5a: Expected VT, but got I4
		//IL_2c12: Expected Obj, but got I
		//IL_2c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c34: Expected F8, but got I4
		//IL_2c3d: Expected Obj, but got I4
		//IL_2c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4e: Expected Obj, but got I4
		//IL_2c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c56: Expected VT, but got Unknown
		//IL_2c5e: Expected Obj, but got I4
		//IL_12ce: Expected Obj, but got I4
		//IL_0e5f: Expected Obj, but got F8
		//IL_102d: Expected Obj, but got I
		//IL_0e18: Expected Obj, but got I4
		//IL_2985: Expected Obj, but got I4
		//IL_0ea5: Expected Obj, but got I
		//IL_0ec7: Expected Obj, but got I4
		//IL_30e5: Expected Obj, but got I
		//IL_30ff: Expected Obj, but got I4
		//IL_2817: Expected Obj, but got I4
		//IL_134e: Expected Obj, but got I4
		//IL_302a: Expected Obj, but got I
		//IL_1369: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326: Expected Obj, but got I4
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Expected VT, but got I4
		//IL_0f48: Expected Obj, but got I4
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f63: Expected F8, but got I4
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Expected Obj, but got I4
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected VT, but got I4
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected VT, but got Unknown
		//IL_0fc4: Expected Obj, but got I4
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Expected VT, but got Unknown
		//IL_29c8: Expected Obj, but got I4
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1360: Unknown result type (might be due to invalid IL or missing references)
		//IL_284e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2856: Expected F4, but got Unknown
		//IL_2863: Expected F4, but got I4
		//IL_104c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Expected VT, but got I4
		//IL_0ffe: Expected Obj, but got I
		//IL_29e1: Expected Obj, but got I4
		//IL_287e: Expected F4, but got I4
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f7: Expected F4, but got Unknown
		//IL_289c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a4: Expected F8, but got Unknown
		//IL_28be: Expected Obj, but got I4
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1d: Expected F4, but got I4
		//IL_2a25: Expected F4, but got VT
		//IL_2a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2d: Expected F8, but got Unknown
		//IL_2a4f: Expected Obj, but got I4
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_28fb: Expected Obj, but got I4
		//IL_305f: Expected Obj, but got I
		//IL_3088: Expected VT, but got I4
		//IL_3090: Unknown result type (might be due to invalid IL or missing references)
		//IL_3094: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8c: Expected Obj, but got I4
		//IL_311d: Expected Obj, but got I
		//IL_3149: Expected VT, but got I4
		//IL_3149: Expected Obj, but got F8
		//IL_3175: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound gillaModeRound = GillaModeRound.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v9+A0]");
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+E4]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v4 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+8]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
		int num2 = 0;
		bool flag5 = (UnityEngine.Object)gillaModeRound != (UnityEngine.Object)null;
		bool flag6 = !flag5;
		int num3 = 0;
		UnityEngine.Object obj13 = null;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2;
		Enumerator<, > val;
		bool hunter;
		Enumerator<, > val2;
		double num7;
		bool flag19;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4;
		GillaSonar gillaSonar;
		double num8;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3;
		if (!flag6)
		{
			bool flag7 = (object)gillaModeRound == null;
			enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			val = (Enumerator<, >)0;
			hunter = false;
			val2 = (Enumerator<, >)0;
			enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			num3 = 0;
			obj13 = null;
			gillaSonar = this;
			if (flag7)
			{
				goto IL_216e;
			}
			bool live = gillaModeRound.Live;
			bool flag8 = !live;
			num3 = 0;
			obj13 = null;
			if (!flag8)
			{
				byte phase = gillaModeRound.Phase;
				int num4 = phase & 0xFF;
				bool flag9 = num4 != 1;
				num3 = 0;
				obj13 = null;
				if (!flag9)
				{
					object obj14 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v269+E4]");
					bool flag10 = (nint)0 == 0;
					object obj15 = !flag10;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = obj11 != null;
					bool flag12 = !flag11;
					num3 = 0;
					obj13 = null;
					if (!flag12)
					{
						bool flag13 = (object)obj11 == null;
						enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
						val = (Enumerator<, >)0;
						hunter = false;
						val2 = (Enumerator<, >)0;
						enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
						num3 = 0;
						obj13 = null;
						gillaSonar = this;
						if (flag13)
						{
							goto IL_216e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X22_v5 (UnityEngine.Object)+90]");
						bool flag14 = (nint)0 != 1;
						num3 = 0;
						obj13 = null;
						if (!flag14)
						{
							int value = ((int*)num2)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X0_v273 (System.Int32)+E4]");
							bool flag15 = (nint)0 == 0;
							object obj16 = !flag15;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag16 = Yours(gillaModeRound);
							float huntLength = gillaModeRound.HuntLength;
							float huntEnds = gillaModeRound.HuntEnds;
							float now = gillaModeRound.Now;
							float num5 = huntEnds - now;
							float num6 = huntLength - num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj17 = 0;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ X0_v281+E4]");
							bool flag17 = (nint)0 == 0;
							object obj19 = !flag17;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							bool flag18 = num5 < 1f;
							num7 = 0.0;
							enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num5;
							flag19 = flag16;
							num3 = 0;
							obj13 = null;
							if (!flag18)
							{
								num8 = every;
								float num9 = lasts;
								double num10 = (double)every * (double)num5;
								float num11 = num6 - (float)num10;
								bool flag20 = !(num11 < lasts);
								num7 = 0.0;
								enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num10;
								flag19 = flag16;
								num3 = 0;
								obj13 = null;
								if (!flag20)
								{
									float num12 = num11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
									float num13 = num12 / 0f;
									bool flag21 = num13 < 0f;
									num8 = 0.0;
									if (!flag21)
									{
										bool flag22 = !((double)num13 > 1.0);
										num8 = num13;
										if (!flag22)
										{
											num8 = 1.0;
										}
									}
									float num14 = num9 - num11;
									num9 = num14 + num14;
									bool flag23 = num9 < 0f;
									double num15 = 0.0;
									if (!flag23)
									{
										bool flag24 = !((double)num9 > 1.0);
										num15 = num9;
										if (!flag24)
										{
											num15 = 1.0;
										}
									}
									num7 = num8 * num15;
									bool flag25 = num5 == (float)lastPulse;
									enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num15;
									flag19 = flag16;
									num3 = 0;
									obj13 = null;
									if (!flag25)
									{
										lastPulse = (int)num5;
										if (flag16)
										{
											object obj20 = obj8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X0_v283+E4]");
											bool flag26 = (nint)0 == 0;
											object obj21 = !flag26;
											if (obj21 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag27 = ping != null;
											bool flag28 = !flag27;
											double num16 = num13;
											float num17 = (float)num15;
											num3 = 0;
											obj13 = null;
											if (!flag28)
											{
												Camera main = Camera.main;
												object obj22 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v182+E4]");
												enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v182+E4]");
												bool flag29 = (nint)0 == 0;
												object obj23 = !flag29;
												if (obj23 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Component component;
												if (main != null)
												{
													Camera main2 = Camera.main;
													bool flag30 = (object)main2 == null;
													object obj24 = !flag30;
													component = main2;
													if (obj24 == null)
													{
														enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
														val = (Enumerator<, >)0;
														hunter = false;
														val2 = (Enumerator<, >)0;
														enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num15;
														obj11 = main;
														num3 = 0;
														obj13 = null;
														gillaSonar = this;
														goto IL_216e;
													}
												}
												else
												{
													component = this;
												}
												Transform transform = component.transform;
												bool flag31 = (object)transform == null;
												enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
												val = (Enumerator<, >)0;
												hunter = false;
												val2 = (Enumerator<, >)0;
												enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num15;
												obj11 = main;
												num3 = 0;
												obj13 = null;
												gillaSonar = this;
												if (flag31)
												{
													goto IL_216e;
												}
												Vector3 position = transform.position;
												object obj25 = this + 128;
												obj11 = (UnityEngine.Object)obj25;
												bool flag32 = obj25 == null;
												object obj26 = !flag32;
												AudioClip[] clips = (AudioClip[])obj25;
												num3 = 0;
												AudioClip[] array = null;
												double num18;
												float num19;
												if (obj26 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
													object obj27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													AudioClip[] array2 = default;
													bool flag33 = array2 == null;
													num18 = num8;
													num19 = num9;
													enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
													val = (Enumerator<, >)0;
													hunter = false;
													val2 = (Enumerator<, >)0;
													num6 = (float)num15;
													enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num15;
													num3 = 0;
													obj13 = (UnityEngine.Object)1;
													gillaSonar = this;
													if (flag33)
													{
														goto IL_216e;
													}
													num3 = (int)ping;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													pings = array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													clips = pings;
													array = array2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
												object obj28 = 0;
												object obj29 = obj28;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2447 @ X0_v297+E4]");
												bool flag34 = (nint)0 == 0;
												object obj30 = !flag34;
												if (obj30 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
												num11 = 0f;
												Sfx.Play(clips, (Vector3)0, (float)num15, (float)num8, num9);
												int value2 = ((int*)num2)->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2478 @ X0_v300 (System.Int32)+E4]");
												bool flag35 = (nint)0 == 0;
												object obj31 = !flag35;
												if (obj31 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												int value3 = ((int*)num2)->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2143 @ X0_v306 (System.Int32)+E4]");
												bool flag36 = (nint)0 == 0;
												object obj32 = !flag36;
												if (obj32 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value3 = ((int*)num2)->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2143 @ X0_v306 (System.Int32)+A0]");
												object obj33 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2520 @ X8_v192+C]");
												object obj34 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2143 @ X0_v306 (System.Int32)+E4]");
												bool flag37 = (nint)0 == 0;
												object obj35 = !flag37;
												if (obj35 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value3 = ((int*)num2)->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2143 @ X0_v306 (System.Int32)+A0]");
												object obj36 = 0;
												num18 = num8;
												num19 = num9;
												num16 = 1.0;
												num17 = (float)num15;
												obj13 = null;
											}
											num13 = (float)num16;
											enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num17;
											flag19 = true;
										}
										else
										{
											enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num15;
											flag19 = false;
											num3 = 0;
											obj13 = null;
										}
									}
								}
							}
							goto IL_23ad;
						}
					}
				}
			}
		}
		lastPulse = -1;
		num7 = 0.0;
		enumerator4 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		flag19 = false;
		goto IL_23ad;
		IL_2198:
		NullReferenceException ex = new NullReferenceException();
		double num21 = default;
		double num20 = num21;
		goto IL_21ae;
		IL_21ae:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_21bc;
		IL_21cb:
		throw new OutOfMemoryException();
		IL_1858:
		float unscaledTime = Time.unscaledTime;
		if (unscaledTime < gillaSonar.nextSweep)
		{
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		List<SkinnedMeshRenderer> list = gillaSonar.gone;
		float num22 = (gillaSonar.nextSweep = unscaledTime2 + 1f);
		bool flag38 = (object)gillaSonar.gone == null;
		double num23;
		num21 = num23;
		num8 = 1.0;
		enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num22;
		int num24;
		obj11 = (UnityEngine.Object)num24;
		int num25;
		num2 = num25;
		object obj42;
		Enumerator<, > val3;
		if (!flag38)
		{
			num3 = list._size;
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(list._version + 1);
			list._size = 0;
			list._version = (int)enumerator;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
				bool flag39 = false;
				obj13 = null;
			}
			bool flag40 = (object)gillaSonar.ghosts == null;
			num21 = num23;
			num8 = 1.0;
			enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num22;
			obj11 = (UnityEngine.Object)num24;
			num2 = num25;
			if (!flag40)
			{
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5 = ((Dictionary<System.__Canon, System.__Canon>)(object)gillaSonar.ghosts).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77A8]");
				obj11 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D88]");
				object obj37 = 0;
				enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator2);
				object obj41 = default;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator6 = default;
				while (enumerator2.MoveNext())
				{
					object obj38 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v232+E4]");
					bool flag41 = (nint)0 == 0;
					object obj39 = !flag41;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag42 = (UnityEngine.Object)num23 == null;
					bool flag43 = !flag42;
					object obj40 = !flag43;
					int num26 = 0;
					obj13 = null;
					if (obj40 == null)
					{
						bool flag44 = obj41 == null;
						enumerator2 = enumerator6;
						num21 = 0.0;
						obj42 = 0;
						val3 = (Enumerator<, >)(ref enumerator2);
						num8 = num23;
						enumerator3 = enumerator6;
						num3 = 0;
						obj13 = null;
						num2 = (int)num23;
						if (flag44)
						{
							goto IL_2198;
						}
						object obj43 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2532 @ X0_v240+E4]");
						bool flag45 = (nint)0 == 0;
						object obj44 = !flag45;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2472 @ stack_-E8+10]");
						bool flag46 = (UnityEngine.Object)0 == null;
						bool flag47 = !flag46;
						num26 = 0;
						obj13 = null;
						num3 = 0;
						if (flag47)
						{
							continue;
						}
					}
					List<System.__Canon> list2 = (List<System.__Canon>)(object)gillaSonar.gone;
					bool flag48 = (object)gillaSonar.gone == null;
					enumerator2 = enumerator6;
					num21 = 0.0;
					obj42 = 0;
					val3 = (Enumerator<, >)(ref enumerator2);
					num8 = num23;
					enumerator3 = enumerator6;
					num3 = num26;
					num2 = (int)num23;
					if (!flag48)
					{
						System.__Canon[] items = list2._items;
						enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)obj37;
						num = list2._version + 1;
						list2._version = num;
						bool flag49 = list2._items == null;
						enumerator2 = enumerator6;
						num21 = 0.0;
						obj42 = 0;
						val3 = (Enumerator<, >)(ref enumerator2);
						num8 = num23;
						enumerator3 = enumerator6;
						num3 = num26;
						num2 = (int)num23;
						if (!flag49)
						{
							num = list2._size;
							Enumerator<, > val4 = (Enumerator<, >)items.Length;
							bool flag50 = list2._size < items.Length;
							object obj45 = !flag50;
							if (obj45 == null)
							{
								object obj46 = list2._items + list2._size;
								int num27 = ++list2._size;
								object obj47 = obj46 + 32;
								obj47 = num23;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num3 = num26;
								enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num27;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X9_v4 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+20]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X8_v157+A8]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2427 @ X8_v158+70]");
								num3 = 0;
								((List<System.__Canon>)(object)gillaSonar.gone).AddWithResize((System.__Canon)num23);
							}
							continue;
						}
					}
					goto IL_217c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7798]");
				object obj50 = 0;
				obj13 = (UnityEngine.Object)obj50;
				enumerator2.Dispose();
				enumerator2 = enumerator6;
				num20 = 0.0;
				obj42 = 0;
				val3 = (Enumerator<, >)(ref enumerator2);
				num8 = num23;
				enumerator3 = enumerator6;
				num2 = 0;
				goto IL_21cb;
			}
		}
		goto IL_216e;
		IL_23ad:
		int value4 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v46 (System.Int32)+E4]");
		bool flag51 = (nint)0 == 0;
		object obj51 = !flag51;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int value5 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+E4]");
		bool flag52 = (nint)0 == 0;
		object obj52 = !flag52;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value5 = ((int*)num2)->m_value;
		}
		bool flag53 = num7 < 0.0;
		bool flag54 = num7 == 0.0;
		object obj53 = num7 ^ num7;
		object obj54 = num7 & obj53;
		bool flag55 = (nint)obj54 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+A0]");
		object obj55 = 0;
		bool flag56 = flag53 == flag55;
		object obj56 = !flag54;
		int num28 = ((flag56 & obj56) ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+E4]");
		bool flag57 = (nint)0 == 0;
		object obj57 = !flag57;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value5 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+A0]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X8_v41+8]");
		bool flag58 = (nint)0 == 0;
		object obj59 = !flag58;
		object obj60 = flag19 & obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+E4]");
		bool flag59 = (nint)0 == 0;
		object obj61 = !flag59;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value5 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+A0]");
		object obj62 = 0;
		obj62 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+E4]");
		Enumerator<, > val5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v55 (System.Int32)+A0]");
			object obj63 = 0;
			double num29 = ((obj63 != null) ? num7 : 0.0);
			float num6 = (float)num29;
			val5 = (Enumerator<, >)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int value6 = ((int*)num2)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ X0_v156 (System.Int32)+A0]");
			object obj64 = 0;
			double num30 = ((obj64 != null) ? num7 : 0.0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ X0_v156 (System.Int32)+E4]");
			bool flag60 = (nint)0 == 0;
			object obj65 = !flag60;
			float num6 = (float)num30;
			val5 = (Enumerator<, >)0;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num6 = (float)num30;
				val5 = (Enumerator<, >)0;
			}
		}
		int value7 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ X0_v61 (System.Int32)+E4]");
		bool flag61 = (nint)0 == 0;
		object obj66 = !flag61;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value7 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ X0_v61 (System.Int32)+A0]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ X0_v61 (System.Int32)+E4]");
		bool flag62 = (nint)0 == 0;
		object obj68 = !flag62;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value7 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ X0_v61 (System.Int32)+A0]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X8_v56+8]");
		bool flag63 = (nint)0 == 0;
		object obj70 = flag63 | flag19;
		object obj71 = obj70 & 1;
		bool flag64;
		if (obj71 != null)
		{
			flag64 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77C8]");
			object obj72 = 0;
			object obj73 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X0_v140+E4]");
			bool flag65 = (nint)0 == 0;
			object obj74 = !flag65;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool watched = GillaMonsterCam.Watched;
			flag64 = watched;
		}
		int frameCount = Time.frameCount;
		int value8 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v61 (System.Int32)+E4]");
		enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v61 (System.Int32)+E4]");
		bool flag66 = (nint)0 == 0;
		object obj75 = !flag66;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int value9 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X0_v68 (System.Int32)+E4]");
		bool flag67 = (nint)0 == 0;
		object obj76 = !flag67;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value9 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X0_v68 (System.Int32)+A0]");
		object obj77 = 0;
		bool flag68 = obj77 == null;
		object obj78 = !flag64;
		object obj79 = flag68 & obj78;
		object obj80 = obj79 & 1;
		bool flag69 = obj80 == null;
		object obj81 = !flag69;
		enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		object obj82 = 109891584;
		val = (Enumerator<, >)0;
		hunter = false;
		num23 = num21;
		val2 = (Enumerator<, >)0;
		num = num28;
		MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)109891584;
		num24 = frameCount;
		gillaSonar = this;
		Enumerator<, > val13;
		Enumerator<, > val14;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator8;
		int num35;
		int num36;
		Enumerator<, > val15;
		Enumerator<, > val16;
		int num37;
		double num39;
		Enumerator<, > val17;
		object obj104;
		int frame = default;
		if (obj81 == null)
		{
			object obj83 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2063 @ X0_v69+E4]");
			bool flag70 = (nint)0 == 0;
			object obj84 = !flag70;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag71 = ghost != null;
			bool flag72 = !flag71;
			enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			obj82 = 109891584;
			val = (Enumerator<, >)0;
			hunter = false;
			num23 = num21;
			val2 = (Enumerator<, >)0;
			num = num28;
			materialPropertyBlock = (MaterialPropertyBlock)109891584;
			num24 = frameCount;
			num3 = 0;
			obj13 = null;
			gillaSonar = this;
			if (!flag72)
			{
				object obj85 = this + 120;
				bool flag73 = obj85 == null;
				object obj86 = !flag73;
				materialPropertyBlock = (MaterialPropertyBlock)109891584;
				obj13 = null;
				if (obj86 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj87 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					obj85 = materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					materialPropertyBlock = materialPropertyBlock2;
					obj13 = (UnityEngine.Object)(object)materialPropertyBlock2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj88 = 0;
				object obj89 = obj88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2231 @ X0_v75+E4]");
				bool flag74 = (nint)0 == 0;
				object obj90 = !flag74;
				if (obj90 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj89 = obj88;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2231 @ X0_v75+A0]");
				object obj91 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v73+8]");
				bool flag75 = (nint)0 == 0;
				enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
				obj82 = 109891584;
				val = (Enumerator<, >)0;
				hunter = false;
				val2 = (Enumerator<, >)0;
				num = num28;
				enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
				obj11 = (UnityEngine.Object)frameCount;
				num3 = 0;
				gillaSonar = this;
				if (flag75)
				{
					goto IL_216e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v73+8]");
				Enumerator<, > enumerator7 = ((List<System.__Canon>)0).GetEnumerator();
				int num31 = this + 72;
				Enumerator<, > val6 = (Enumerator<, >)(this + 76);
				Enumerator<, > val7 = (Enumerator<, >)(this + 80);
				int num32 = this + 84;
				int num33 = this + 56;
				Enumerator<, > val8 = (Enumerator<, >)(this + 60);
				int num34 = this + 68;
				Enumerator<, > val9 = (Enumerator<, >)(this + 64);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
				object obj92 = 0;
				hunter = false;
				num = num32;
				Enumerator<, > val11 = default;
				Enumerator<, > val10 = val11;
				num3 = 0;
				Enumerator<, > val12 = (Enumerator<, >)(ref val2);
				object obj108 = default;
				while (true)
				{
					GameObject body;
					if (val2.MoveNext())
					{
						object obj93 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2383 @ X0_v81+E4]");
						bool flag76 = (nint)0 == 0;
						object obj94 = !flag76;
						if (obj94 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag77 = (UnityEngine.Object)num21 == null;
						bool flag78 = !flag77;
						object obj95 = !flag78;
						num3 = 0;
						if (obj95 != null)
						{
							continue;
						}
						bool flag79 = num21 == 0.0;
						enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
						obj82 = 109891584;
						val = (Enumerator<, >)0;
						val13 = val9;
						num20 = 0.0;
						val14 = val8;
						obj42 = 0;
						val2 = val11;
						enumerator8 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num34;
						num35 = num32;
						num36 = num33;
						val15 = val6;
						val16 = val7;
						num37 = num31;
						val3 = (Enumerator<, >)(ref val2);
						enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val10;
						obj11 = (UnityEngine.Object)frameCount;
						num3 = 0;
						obj13 = null;
						enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val12;
						gillaSonar = this;
						if (flag79)
						{
							break;
						}
						bool isLocal = ((NetworkApe)num21).IsLocal;
						bool flag80 = !isLocal;
						object obj96 = !flag80;
						num3 = 0;
						if (obj96 != null)
						{
							continue;
						}
						int value10 = ((int*)num2)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ stack_-130_v12 (System.Double)+6D0]");
						materialPropertyBlock = (MaterialPropertyBlock)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2529 @ X0_v87 (System.Int32)+E4]");
						bool flag81 = (nint)0 == 0;
						object obj97 = !flag81;
						if (obj97 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag82 = Glows(gillaModeRound, (PlayerRef)materialPropertyBlock, out hunter);
						bool flag83 = !flag82;
						num3 = (int)(&hunter);
						if (flag83)
						{
							continue;
						}
						if (hunter)
						{
							int value11 = ((int*)num2)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2580 @ X0_v114 (System.Int32)+E4]");
							bool flag84 = (nint)0 == 0;
							object obj98 = !flag84;
							if (obj98 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int value12 = ((int*)num2)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2334 @ X0_v118 (System.Int32)+E4]");
							bool flag85 = (nint)0 == 0;
							object obj99 = !flag85;
							if (obj99 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								value12 = ((int*)num2)->m_value;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2334 @ X0_v118 (System.Int32)+A0]");
							object obj100 = 0;
							bool flag86 = obj100 == null;
							num3 = (int)(&hunter);
							if (flag86)
							{
								continue;
							}
						}
						bool isMonster = ((NetworkApe)num21).IsMonster;
						bool flag87 = !isMonster;
						int num38 = (int)(&hunter);
						UnityEngine.Object obj101 = null;
						if (!flag87)
						{
							object obj102 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ stack_-130_v12 (System.Double)+6D8]");
							materialPropertyBlock = (MaterialPropertyBlock)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2616 @ X0_v107+E4]");
							bool flag88 = (nint)0 == 0;
							object obj103 = !flag88;
							if (obj103 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag89 = (UnityEngine.Object)(object)materialPropertyBlock != null;
							bool flag90 = !flag89;
							num38 = 0;
							obj101 = null;
							if (!flag90)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ stack_-130_v12 (System.Double)+6D8]");
								bool flag91 = (nint)0 == 0;
								enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
								obj82 = 109891584;
								val = (Enumerator<, >)0;
								val13 = val9;
								num20 = 0.0;
								val14 = val8;
								obj42 = 0;
								val2 = val11;
								enumerator8 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num34;
								num35 = num32;
								num36 = num33;
								val15 = val6;
								val16 = val7;
								num37 = num31;
								val3 = (Enumerator<, >)(ref val2);
								enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val10;
								obj11 = (UnityEngine.Object)frameCount;
								num3 = 0;
								obj13 = null;
								enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val12;
								gillaSonar = this;
								if (flag91)
								{
									goto IL_21ef;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ stack_-130_v12 (System.Double)+6D8]");
								GameObject gameObject = ((Component)0).gameObject;
								body = gameObject;
								num38 = 0;
								obj101 = null;
								goto IL_2825;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ stack_-130_v12 (System.Double)+80]");
						body = (GameObject)0;
						goto IL_2825;
					}
					enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
					obj82 = 109891584;
					val = (Enumerator<, >)0;
					val13 = val9;
					num39 = 0.0;
					val14 = val8;
					obj42 = 0;
					val2 = val11;
					enumerator8 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)num34;
					num35 = num32;
					num36 = num33;
					val15 = val6;
					val16 = val7;
					num37 = num31;
					val17 = (Enumerator<, >)(ref val2);
					obj104 = 25;
					enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val10;
					num24 = frameCount;
					enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val12;
					gillaSonar = this;
					object obj105 = 0;
					goto IL_2c7b;
					IL_2c7b:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
					object obj106 = 0;
					obj13 = (UnityEngine.Object)obj106;
					((Enumerator<, >*)val17)->Dispose();
					bool flag92 = obj105 == null;
					object obj107 = !flag92;
					num20 = num39;
					val3 = val17;
					obj11 = (UnityEngine.Object)num24;
					if (obj107 != null)
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
						goto IL_21ef;
					}
					goto IL_117e;
					IL_21ef:
					NullReferenceException ex4 = new NullReferenceException();
					if ((nint)obj13 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num20 = 1.0;
						obj105 = obj42;
					}
					else
					{
						if ((nint)obj13 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj105 = obj108;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj42 = obj108;
					}
					num39 = num20;
					val17 = val3;
					obj104 = 0;
					num24 = (int)obj11;
					goto IL_2c7b;
					IL_2825:
					int value13 = ((int*)num2)->m_value;
					int num40 = (hunter ? num32 : num34);
					val12 = (hunter ? val7 : val9);
					float num19 = (float)val12;
					float num41 = ((int*)num40)->m_value;
					int num42 = (hunter ? num31 : num33);
					float num6 = ((int*)num42)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2655 @ X0_v95 (System.Int32)+E4]");
					num = 0;
					Enumerator<, > val4 = (hunter ? val6 : val8);
					double num18 = (double)val4;
					bool flag93 = num == 0;
					object obj109 = !flag93;
					if (obj109 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int value14 = ((int*)num2)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ X0_v99 (System.Int32)+E4]");
					bool flag94 = (nint)0 == 0;
					object obj110 = !flag94;
					if (obj110 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						value14 = ((int*)num2)->m_value;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ X0_v99 (System.Int32)+A0]");
					object obj111 = 0;
					bool flag95 = obj111 == null;
					Glow(body, (Color)flag95, num6, (byte)frameCount != 0, frame);
					bool flag39 = (byte)frameCount != 0;
					Enumerator<, > val18 = val8;
					bool flag96 = hunter;
					float num13 = (float)num7;
					float num11 = num41;
					float num9 = num19;
					num8 = num18;
					val10 = (Enumerator<, >)num6;
					num3 = (flag95 ? 1 : 0);
				}
				goto IL_21ae;
			}
		}
		List<GillaSplashDirector.Copy> list3 = gillaSonar.lit;
		bool flag97 = gillaSonar.lit == null;
		num21 = num23;
		enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
		obj11 = (UnityEngine.Object)num24;
		if (!flag97)
		{
			num25 = list3._size;
			if (list3._size < 1)
			{
				goto IL_1858;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77F8]");
			materialPropertyBlock = (MaterialPropertyBlock)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77E8]");
			obj82 = 0;
			object obj112 = obj56;
			int num43 = num3;
			UnityEngine.Object obj113 = obj13;
			num2 = list3._size;
			while (true)
			{
				bool flag98 = gillaSonar.lit == null;
				obj56 = obj112;
				num21 = num23;
				enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
				obj11 = (UnityEngine.Object)num24;
				num3 = num43;
				obj13 = obj113;
				if (flag98)
				{
					break;
				}
				num3 = (int)materialPropertyBlock;
				num2--;
				System.__Canon _Canon = ((List<System.__Canon>)(object)gillaSonar.lit).get_Item(num2);
				bool flag99 = _Canon == null;
				obj56 = obj112;
				num21 = num23;
				enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
				obj11 = (UnityEngine.Object)num24;
				obj13 = (UnityEngine.Object)num2;
				if (flag99)
				{
					break;
				}
				object obj114 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2248 @ X0_v250+E4]");
				bool flag100 = (nint)0 == 0;
				object obj115 = !flag100;
				if (obj115 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v249 (System.__Canon)+10]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v249 (System.__Canon)+18]");
					bool flag101 = (nint)0 == num24;
					num3 = 0;
					obj13 = null;
					if (flag101)
					{
						goto IL_1801;
					}
				}
				object obj116 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2370 @ X0_v255+E4]");
				bool flag102 = (nint)0 == 0;
				object obj117 = !flag102;
				if (obj117 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v249 (System.__Canon)+10]");
				bool flag103 = (UnityEngine.Object)0 != null;
				bool flag104 = !flag103;
				num3 = 0;
				obj13 = null;
				if (!flag104)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v249 (System.__Canon)+10]");
					bool flag105 = (nint)0 == 0;
					obj56 = obj112;
					num21 = num23;
					enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
					obj11 = (UnityEngine.Object)num24;
					num3 = 0;
					obj13 = null;
					if (flag105)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v249 (System.__Canon)+10]");
					((Renderer)0).enabled = false;
					num3 = 0;
					obj13 = null;
				}
				bool flag106 = gillaSonar.lit == null;
				obj56 = obj112;
				num21 = num23;
				enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
				obj11 = (UnityEngine.Object)num24;
				if (flag106)
				{
					break;
				}
				num3 = (int)obj82;
				((List<System.__Canon>)(object)gillaSonar.lit).RemoveAt(num2);
				obj13 = (UnityEngine.Object)num2;
				goto IL_1801;
				IL_1801:
				bool flag107 = num2 == 0;
				obj56 = !flag107;
				bool flag108 = num2 > 0;
				num25 = num2;
				obj112 = obj56;
				num43 = num3;
				obj113 = obj13;
				if (flag108)
				{
					continue;
				}
				goto IL_1858;
			}
		}
		goto IL_216e;
		IL_216e:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_217c;
		IL_217c:
		NullReferenceException ex6 = new NullReferenceException();
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_2198;
		IL_117e:
		bool flag109 = num39 == 0.0;
		object obj118 = !flag109;
		num20 = num39;
		val3 = val17;
		obj11 = (UnityEngine.Object)num24;
		ex2 = (NullReferenceException)val17;
		if (obj118 != null)
		{
			goto IL_21bc;
		}
		if ((nint)obj104 != 25)
		{
			bool flag110 = obj104 == null;
			object obj119 = !flag110;
			if (obj119 != null)
			{
				return;
			}
		}
		int value15 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X0_v16 (System.Int32)+E4]");
		bool flag111 = (nint)0 == 0;
		object obj120 = !flag111;
		if (obj120 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value15 = ((int*)num2)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X0_v16 (System.Int32)+A0]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v14+10]");
		bool flag112 = (nint)0 == 0;
		num21 = num39;
		val3 = val17;
		obj11 = (UnityEngine.Object)num24;
		if (flag112)
		{
			goto IL_216e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v14+10]");
		Enumerator<, > enumerator9 = ((List<(System.__Canon, bool)>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77B0]");
		object obj122 = 0;
		num8 = num39;
		Enumerator<, > val19 = default;
		val5 = val19;
		bool flag117 = default;
		while (val.MoveNext())
		{
			int value16 = ((int*)num2)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X0_v23 (System.Int32)+E4]");
			bool flag113 = (nint)0 == 0;
			object obj123 = !flag113;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int value17 = ((int*)num2)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2105 @ X0_v27 (System.Int32)+E4]");
			bool flag114 = (nint)0 == 0;
			object obj124 = !flag114;
			if (obj124 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				value17 = ((int*)num2)->m_value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2105 @ X0_v27 (System.Int32)+A0]");
			object obj125 = 0;
			bool flag115 = obj125 == null;
			object obj126 = !flag115;
			if (obj126 == null)
			{
				bool flag116 = !flag117;
				object obj127 = !flag116;
				if (obj127 != null)
				{
					continue;
				}
			}
			bool flag118 = !flag117;
			object obj128 = !flag118;
			Enumerator<, > val4 = ((obj128 != null) ? val16 : val13);
			object obj129 = !flag118;
			enumerator = ((obj129 != null) ? ((Dictionary<System.__Canon, System.__Canon>.Enumerator)num35) : enumerator8);
			object obj130 = !flag118;
			num = ((obj130 != null) ? num37 : num36);
			float num19 = (float)val4;
			Enumerator<, > val18 = ((!flag118) ? val15 : val14);
			float num6 = ((int*)num)->m_value;
			float num41 = (float)enumerator;
			double num18 = (double)val18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2105 @ X0_v27 (System.Int32)+E4]");
			bool flag119 = (nint)0 == 0;
			object obj131 = !flag119;
			if (obj131 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int value18 = ((int*)num2)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2563 @ X0_v31 (System.Int32)+E4]");
			bool flag120 = (nint)0 == 0;
			object obj132 = !flag120;
			if (obj132 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				value18 = ((int*)num2)->m_value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2563 @ X0_v31 (System.Int32)+A0]");
			object obj133 = 0;
			bool flag121 = obj133 == null;
			gillaSonar.Glow((GameObject)num39, (Color)flag121, num6, (byte)num24 != 0, frame);
			bool flag39 = (byte)num24 != 0;
			float num13 = (float)num7;
			float num11 = num41;
			float num9 = num19;
			num8 = num18;
			val5 = (Enumerator<, >)num6;
			num3 = (flag121 ? 1 : 0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C77A0]");
		object obj134 = 0;
		obj13 = (UnityEngine.Object)obj134;
		val.Dispose();
		val = val19;
		num20 = 0.0;
		obj42 = 0;
		val3 = (Enumerator<, >)(ref val);
		materialPropertyBlock = (MaterialPropertyBlock)1;
		enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)val5;
		obj11 = (UnityEngine.Object)num24;
		num2 = 0;
		goto IL_21cb;
		IL_21bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_21cb;
	}

	private unsafe void Glow(GameObject body, Color c, float fade, bool screenOnly, int frame)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0adb: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected VT, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected VT, but got Obj
		//IL_011f: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I4, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected F4, but got Unknown
		//IL_08f4: Expected Obj, but got I4
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got I4
		//IL_0b23: Expected Obj, but got I
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected Ref, but got Unknown
		//IL_0b4e: Expected Obj, but got I4
		//IL_0b56: Expected VT, but got Obj
		//IL_01d3: Expected Obj, but got I4
		//IL_09ff: Expected Obj, but got VT
		//IL_0218: Expected Obj, but got I4
		//IL_092c: Expected Obj, but got I4
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected Obj, but got Unknown
		//IL_095a: Expected Obj, but got I4
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected VT, but got I4
		//IL_0a55: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I4
		//IL_03b9: Expected Obj, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected VT, but got I4
		//IL_0459: Expected Obj, but got I4
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected VT, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_04c5: Expected VT, but got I4
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0795: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I4
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected VT, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_07e7: Expected Obj, but got I4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected I4, but got Unknown
		//IL_0754: Expected VT, but got I4
		//IL_075c: Expected Obj, but got I4
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected VT, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_081d: Expected Obj, but got I
		//IL_0837: Expected VT, but got I4
		//IL_0856: Expected Obj, but got I4
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected VT, but got I4
		//IL_087f: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got VT
		//IL_06c2: Expected Obj, but got I
		//IL_06d2: Expected VT, but got I
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2+E4]");
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
		bool flag4 = (object)body == null;
		GameObject gameObject2 = default;
		GameObject gameObject = gameObject2;
		Enumerator<, > val = (Enumerator<, >)0;
		bool flag5 = screenOnly;
		Color color = (Color)0;
		UnityEngine.Object obj5 = null;
		GameObject gameObject3 = body;
		MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)109891584;
		object obj19 = default;
		object obj21 = default;
		object obj23 = default;
		object obj18;
		object obj20;
		object obj22;
		float num = default;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7800]");
			object obj6 = 0;
			List<SkinnedMeshRenderer> list = parts;
			flag5 = (byte)(int)obj6 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626A60");
			bool flag6 = (object)parts == null;
			gameObject = gameObject2;
			val = (Enumerator<, >)0;
			color = (Color)parts;
			obj5 = null;
			gameObject3 = body;
			materialPropertyBlock = (MaterialPropertyBlock)109891584;
			if (!flag6)
			{
				bool screenOnly2 = (byte)(c & 1) != 0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)parts).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4278]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7808]");
				object obj10 = 0;
				Enumerator<, > val2 = (Enumerator<, >)(ref val);
				Enumerator<, > val3 = default;
				num = (float)val3;
				gameObject3 = body;
				object obj34 = default;
				float num3 = default;
				object obj24;
				Enumerator<, > val4;
				while (true)
				{
					if (val.MoveNext())
					{
						object obj11 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v43+E4]");
						bool flag7 = (nint)0 == 0;
						object obj12 = !flag7;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = gameObject2 == null;
						bool flag9 = !flag8;
						object obj13 = !flag9;
						list = null;
						gameObject3 = gameObject2;
						if (obj13 != null)
						{
							continue;
						}
						if ((object)gameObject2 == null)
						{
							break;
						}
						bool flag10 = ((Renderer)(object)gameObject2).enabled;
						bool flag11 = !flag10;
						list = null;
						gameObject3 = gameObject2;
						if (flag11)
						{
							continue;
						}
						Mesh sharedMesh = ((SkinnedMeshRenderer)(object)gameObject2).sharedMesh;
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v52+E4]");
						bool flag12 = (nint)0 == 0;
						object obj15 = !flag12;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = sharedMesh == null;
						bool flag14 = !flag13;
						object obj16 = !flag14;
						list = null;
						gameObject3 = gameObject2;
						if (obj16 != null)
						{
							continue;
						}
						string text = gameObject2.name;
						bool flag15 = text == (string)obj8;
						bool flag16 = !flag15;
						object obj17 = !flag16;
						list = null;
						gameObject3 = gameObject2;
						if (obj17 != null)
						{
							continue;
						}
						GillaSplashDirector.Copy copy = Ghost((SkinnedMeshRenderer)(object)gameObject2);
						bool flag17 = copy == null;
						obj18 = obj19;
						obj20 = obj21;
						obj22 = obj23;
						gameObject = null;
						obj24 = 0;
						val = val3;
						val4 = (Enumerator<, >)(ref val);
						color = (Color)0;
						obj5 = gameObject2;
						gameObject3 = gameObject2;
						materialPropertyBlock = (MaterialPropertyBlock)(object)copy;
						if (flag17)
						{
							goto IL_09c7;
						}
						gameObject3 = (GameObject)(object)copy.glow;
						copy.wanted = (screenOnly ? 1 : 0);
						copy.screenOnly = screenOnly2;
						bool flag18 = (object)copy.glow == null;
						obj18 = obj19;
						obj20 = obj21;
						obj22 = obj23;
						gameObject = null;
						obj24 = 0;
						val = val3;
						val4 = (Enumerator<, >)(ref val);
						color = (Color)0;
						obj5 = gameObject2;
						materialPropertyBlock = (MaterialPropertyBlock)(object)copy;
						if (flag18)
						{
							goto IL_09b9;
						}
						bool flag19 = copy.glow.enabled;
						bool flag20 = !flag19;
						object obj25 = !flag20;
						color = (Color)0;
						if (obj25 != null)
						{
							goto IL_06e6;
						}
						copy.glow.enabled = true;
						List<System.__Canon> list2 = (List<System.__Canon>)(object)lit;
						bool flag21 = lit == null;
						obj18 = obj19;
						obj20 = obj21;
						obj22 = obj23;
						gameObject = null;
						obj24 = 0;
						val = val3;
						val4 = (Enumerator<, >)(ref val);
						color = (Color)0;
						obj5 = (UnityEngine.Object)1;
						if (!flag21)
						{
							System.__Canon[] items = list2._items;
							val2 = (Enumerator<, >)obj10;
							int version = list2._version + 1;
							list2._version = version;
							bool flag22 = list2._items == null;
							obj18 = obj19;
							obj20 = obj21;
							obj22 = obj23;
							gameObject = null;
							obj24 = 0;
							val = val3;
							val4 = (Enumerator<, >)(ref val);
							color = (Color)0;
							obj5 = (UnityEngine.Object)1;
							if (!flag22)
							{
								version = list2._size;
								bool flag23 = list2._size < items.Length;
								object obj26 = !flag23;
								if (obj26 == null)
								{
									object obj27 = list2._items + list2._size;
									int num2 = ++list2._size;
									object obj28 = obj27 + 32;
									obj28 = copy;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									val2 = (Enumerator<, >)num2;
									color = (Color)0;
								}
								else
								{
									System.__Canon _Canon = (System.__Canon)val2._current;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v35 (System.__Canon)+A8]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v36+70]");
									color = (Color)0;
									((List<System.__Canon>)(object)lit).AddWithResize((System.__Canon)(object)copy);
								}
								goto IL_06e6;
							}
						}
						goto IL_09e3;
					}
					gameObject = null;
					obj24 = 0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					object obj30 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D70]");
						object obj31 = 0;
						obj5 = (UnityEngine.Object)obj31;
						((Enumerator<, >*)val4)->Dispose();
						bool flag24 = obj30 == null;
						object obj32 = !flag24;
						color = (Color)list;
						if (obj32 == null)
						{
							bool flag25 = (object)gameObject == null;
							object obj33 = !flag25;
							OutOfMemoryException ex = (OutOfMemoryException)val4;
							if (obj33 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							list = (List<SkinnedMeshRenderer>)color;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj5 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							gameObject = (GameObject)1;
							obj30 = obj24;
							continue;
						}
						if ((nint)obj5 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj30 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj24 = obj34;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
					IL_06e6:
					bool forceRenderingOff = ((Renderer)(object)gameObject3).forceRenderingOff;
					object obj35 = forceRenderingOff ^ c;
					object obj36 = obj35 & 1;
					bool flag26 = obj36 == null;
					obj5 = null;
					if (!flag26)
					{
						bool flag27 = (byte)(c & 1) != 0;
						((Renderer)(object)gameObject3).forceRenderingOff = flag27;
						color = (Color)0;
						obj5 = (UnityEngine.Object)flag27;
					}
					object obj37 = obj9;
					materialPropertyBlock = block;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v67+E4]");
					bool flag28 = (nint)0 == 0;
					object obj38 = !flag28;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag29 = materialPropertyBlock == null;
					obj18 = obj19;
					obj20 = obj21;
					obj22 = obj23;
					gameObject = null;
					obj24 = 0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					if (!flag29)
					{
						object obj39 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v30+A0]");
						object obj40 = 0;
						MaterialPropertyBlock materialPropertyBlock2 = materialPropertyBlock;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v31+18]");
						materialPropertyBlock2.SetColor(0, (Color)0);
						bool flag30 = block == null;
						gameObject = null;
						obj24 = 0;
						val = val3;
						val4 = (Enumerator<, >)(ref val);
						color = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v31+18]");
						obj5 = (UnityEngine.Object)0;
						if (!flag30)
						{
							object obj41 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v32+A0]");
							object obj42 = 0;
							MaterialPropertyBlock materialPropertyBlock3 = block;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v33+1C]");
							materialPropertyBlock3.SetFloat(0, num3);
							((Renderer)(object)gameObject3).SetPropertyBlock(block);
							num = num3;
							list = null;
							continue;
						}
						goto IL_098b;
					}
					goto IL_09d5;
				}
				NullReferenceException ex2 = new NullReferenceException();
				gameObject = null;
				obj24 = 0;
				val = val3;
				val4 = (Enumerator<, >)(ref val);
				color = (Color)0;
				obj5 = null;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_098b;
		IL_098b:
		NullReferenceException ex4 = new NullReferenceException();
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj23;
		num = num;
		goto IL_09b9;
		IL_09b9:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_09c7;
		IL_09c7:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_09d5;
		IL_09e3:
		throw new NullReferenceException();
		IL_09d5:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_09e3;
	}

	private unsafe GillaSplashDirector.Copy Ghost(SkinnedMeshRenderer src)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004b: Expected Obj, but got Ref
		//IL_0129: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_02d9: Expected VT, but got Ref
		//IL_0339: Expected Obj, but got I
		//IL_0354: Expected Obj, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected I4, but got Unknown
		//IL_03c2: Expected Obj, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0503: Expected Obj, but got I
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I8
		//IL_044b: Expected Obj, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0669: Expected Obj, but got I4
		//IL_0458: Expected I, but got Obj
		//IL_04bd: Expected Obj, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04e5: Expected I4, but got Obj
		//IL_0499: Expected Obj, but got I4
		object obj22 = default;
		if ((object)ghosts != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7818]");
			object obj = 0;
			bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)ghosts).TryGetValue((System.__Canon)(object)src, out System.__Canon value);
			bool flag2 = !flag;
			UnityEngine.Object obj2 = src;
			object obj3 = (object)(&value);
			if (!flag2)
			{
				if (value == null)
				{
					goto IL_05fc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v63+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ stack_-48_v3 (System.__Canon)+10]");
				bool flag4 = (UnityEngine.Object)0 != null;
				bool flag5 = !flag4;
				object obj7 = !flag5;
				obj2 = null;
				obj3 = 0;
				if (obj7 != null)
				{
					goto IL_05d1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4278]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj9);
			if ((object)gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((object)src != null)
				{
					Transform parent = src.transform;
					if ((object)transform != null)
					{
						transform.SetParent(parent, worldPositionStays: false);
						GameObject gameObject2 = src.gameObject;
						if ((object)gameObject2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
							object obj10 = 0;
							int layer = gameObject2.layer;
							gameObject.layer = layer;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
							Mesh sharedMesh = src.sharedMesh;
							SkinnedMeshRenderer skinnedMeshRenderer = default;
							if ((object)skinnedMeshRenderer != null)
							{
								skinnedMeshRenderer.sharedMesh = sharedMesh;
								Transform rootBone = src.rootBone;
								skinnedMeshRenderer.rootBone = rootBone;
								Transform[] bones = src.bones;
								skinnedMeshRenderer.bones = bones;
								Bounds localBounds = src.localBounds;
								object obj11 = default;
								skinnedMeshRenderer.localBounds = (Bounds)(&obj11);
								skinnedMeshRenderer.updateWhenOffscreen = true;
								skinnedMeshRenderer.allowOcclusionWhenDynamic = false;
								Mesh sharedMesh2 = src.sharedMesh;
								if ((object)sharedMesh2 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
									object obj12 = 0;
									int subMeshCount = sharedMesh2.subMeshCount;
									object obj13 = subMeshCount - 1;
									bool flag6 = (nint)obj13 < 0;
									bool flag7 = obj13 == null;
									int num = subMeshCount ^ 1;
									int num2 = subMeshCount ^ obj13;
									int num3 = num & num2;
									bool flag8 = num3 < 0;
									bool flag9 = flag6 == flag8;
									object obj14 = !flag7;
									object obj15 = flag9 & obj14;
									object obj16 = ~obj15;
									if (obj16 == null)
									{
										int num4 = subMeshCount;
									}
									else
									{
										int num4 = 1;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Material[] array = default;
									if (array != null)
									{
										if (array.Length >= 1)
										{
											object obj17 = array + 32;
											object obj18 = array.Length & 0xFFFFFFFFL;
											object obj19 = 0;
											IndexOutOfRangeException ex = default;
											while (true)
											{
												if ((object)ghost != null)
												{
													nint num5 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v23 (Il2CppClass<UnityEngine.Material[]>)+40]");
													int num4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													if (ex == null)
													{
														goto IL_05e4;
													}
													obj18 = array.Length;
												}
												bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
												object obj20 = !flag10;
												if (obj20 == null)
												{
													obj17 = ghost;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj18 = array.Length;
													obj19++;
													bool flag11 = (nint)obj19 < array.Length;
													int num4 = (int)ghost;
													if (!flag11)
													{
														break;
													}
													continue;
												}
												ex = new IndexOutOfRangeException();
												goto IL_05e4;
												IL_05e4:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
												ArgumentNullException ex2 = new ArgumentNullException();
												goto IL_05fc;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7810]");
										object obj21 = 0;
										skinnedMeshRenderer.sharedMaterials = array;
										skinnedMeshRenderer.shadowCastingMode = (ShadowCastingMode)0;
										skinnedMeshRenderer.receiveShadows = false;
										skinnedMeshRenderer.lightProbeUsage = (LightProbeUsage)0;
										skinnedMeshRenderer.enabled = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										_ = 4294967295L;
										obj22._002Ector();
										object obj23 = obj22 + 16;
										obj23 = skinnedMeshRenderer;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										if ((object)ghosts != null)
										{
											((Dictionary<System.__Canon, System.__Canon>)(object)ghosts).set_Item((System.__Canon)(object)src, (System.__Canon)obj22);
											goto IL_05d1;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_05fc;
		IL_05fc:
		return (GillaSplashDirector.Copy)(object)new NullReferenceException();
		IL_05d1:
		return (GillaSplashDirector.Copy)obj22;
	}

	public GillaSonar()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0109: Expected F4, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00eb: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7828]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7838]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D7B0]");
		every = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F4A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = this + 88;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = this + 96;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj6 = this + 104;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj7 = this + 112;
		obj7 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		lastPulse = -1;
		base._002Ector();
	}

	static GillaSonar()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7748]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7858]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7860]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, bool)> list = default;
		list._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+A0]");
		object obj8 = 0;
		int num2 = Shader.PropertyToID((string)obj4);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+A0]");
		object obj10 = 0;
	}
}
