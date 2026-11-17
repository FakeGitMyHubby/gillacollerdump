using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaSplashPool : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public GillaSplashGame game;

		internal bool _003CWinners_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00a4: Expected I4, but got Obj
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected VT, but got Unknown
			object obj = kv & 0xFF00000000L;
			if ((long)obj == 12884901888L)
			{
				return false;
			}
			GillaSplashGame gillaSplashGame = game;
			if ((object)game != null && (object)((SimulationBehaviour)gillaSplashGame)._runner != null)
			{
				IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)gillaSplashGame)._runner.ActivePlayers;
				PlayerRef value = (PlayerRef)(kv & 0xFFFFFFFFL);
				return Enumerable.Contains(activePlayers, value);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int index;

	public Rect area;

	public float depth;

	public Transform monsterStart;

	public float cell;

	public int cols;

	public int rows;

	private byte[] cells;

	public Renderer surface;

	public GillaSplashSpectate.Footprint[] standing;

	public Color murk;

	public static readonly List<GillaSplashPool> All;

	public const float BodyRoom = default(float);

	private readonly List<GillaSplashSpectate.Footprint> feet;

	private static readonly int[] StepC;

	private static readonly int[] StepR;

	public const float FoamCell = default(float);

	public const float FoamRange = default(float);

	private static readonly int FoamTexId;

	private static readonly int FoamRectId;

	private Texture2D foamMap;

	private byte[] foamBytes;

	public float Surface
	{
		get
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			float result = default;
			return result;
		}
	}

	private byte[] Cells => cells;

	public Texture2D FoamMap => foamMap;

	public Vector4 FoamRect
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_009a: Expected Obj, but got I4
			//IL_0066: Expected VT, but got Obj
			//IL_004f: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
			object obj = 0;
			Transform transform = base.transform;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)transform != null)
			{
				return transform.TransformPoint((Vector3)0);
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector4)ex;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
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

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
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
	}

	public Vector2 Local(Vector3 world)
	{
		//IL_004c: Expected VT, but got Obj
		//IL_0035: Expected VT, but got I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			return transform.InverseTransformPoint((Vector3)0);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
	}

	public Vector3 World(Vector2 local)
	{
		//IL_004c: Expected VT, but got Obj
		//IL_0035: Expected VT, but got I4
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			return transform.TransformPoint((Vector3)0);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public bool Over(Vector3 world)
	{
		//IL_0010: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_002e: Invalid comparison between Obj and VT
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj = 0;
		Vector2 vector = Local(world);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<Rect, UIntPtr>(ref area))
		{
			Rect rect = area;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+2C]");
			object obj5 = rect + 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
				object obj6 = default;
				if ((nint)obj6 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+30]");
					object obj7 = num + 0;
					object obj8 = obj6 - obj7;
					return (nint)obj8 < 0;
				}
			}
		}
		return false;
	}

	public bool In(Vector3 world, float margin = default(float))
	{
		//IL_004c: Invalid comparison between Obj and F4
		//IL_00aa: Invalid comparison between F4 and I4
		//IL_00b9: Invalid comparison between F4 and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		if (Over(world))
		{
			float num = Surface;
			object obj = default;
			float num2 = num - (float)obj;
			object obj2 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2))
			{
				float num3 = Surface;
				float num4 = num3 - depth;
				float num5 = num4 + -0.5f;
				float num6 = (float)obj2 - num5;
				bool flag = num6 < 0f;
				bool flag2 = num6 == 0f;
				object obj3 = obj2 ^ num5;
				object obj4 = obj2 ^ num6;
				object obj5 = obj3 & obj4;
				bool flag3 = (nint)obj5 < 0;
				bool flag4 = flag == flag3;
				object obj6 = !flag2;
				return (byte)((flag4 & obj6) ? 1 : 0) != 0;
			}
		}
		return false;
	}

	public unsafe static GillaSplashPool At(Vector3 world)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I
		//IL_0323: Expected VT, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected VT, but got Obj
		//IL_00cd: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got I4
		//IL_029e: Expected VT, but got Obj
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Ref, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Ref
		//IL_010e: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_018a: Invalid comparison between VT and I4
		//IL_01e2: Invalid comparison between VT and I4
		//IL_01c3: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
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
		bool flag2 = obj4 == null;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8450]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8448]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj4).GetEnumerator();
			vector = (Vector3)obj5;
			Enumerator<, > val = default;
			object obj7;
			object obj8;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				obj7 = 0;
				obj8 = 0;
				val2 = (Enumerator<, >)(ref val);
				obj4 = (object)(&val);
				object obj9 = 0;
				object obj12 = default;
				while (true)
				{
					GillaSplashPool result = null;
					vector = (Vector3)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag3 = obj9 == null;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						bool flag4 = obj7 == null;
						object obj11 = !flag4;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj11 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (vector == (Vector3)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj7 = 1;
						obj4 = 1;
						obj9 = obj8;
						continue;
					}
					if (vector != (Vector3)(object)1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj9 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj8 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E7A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				GillaSplashPool result2 = default;
				return result2;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj7 = 0;
			obj8 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj4 = (object)(&val);
		}
		throw new NullReferenceException();
	}

	public unsafe static GillaSplashPool Near(Vector3 world, float round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected VT, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected F4, but got Unknown
		//IL_04cb: Expected VT, but got Obj
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got I4
		//IL_05a7: Expected VT, but got Obj
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Ref, but got Unknown
		//IL_05ca: Expected Obj, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected VT, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0119: Expected F4, but got VT
		//IL_03c9: Invalid comparison between VT and I4
		//IL_0431: Invalid comparison between VT and I4
		//IL_0164: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I4
		//IL_0505: Expected F4, but got I
		//IL_040a: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_01ab: Expected F4, but got VT
		//IL_01c8: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_0217: Expected F4, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_055a: Expected F4, but got I
		//IL_02af: Expected F4, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+A0]");
		GillaSplashPool gillaSplashPool = (GillaSplashPool)0;
		bool flag2 = (object)gillaSplashPool == null;
		GillaSplashPool gillaSplashPool3 = default;
		GillaSplashPool gillaSplashPool2 = gillaSplashPool3;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8450]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8448]");
			object obj6 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)gillaSplashPool).GetEnumerator();
			float num2 = default;
			float num = num2;
			Enumerator<, > val2 = default;
			float num3 = (float)val2;
			gillaSplashPool = gillaSplashPool3;
			object obj9 = default;
			GillaSplashPool result2 = default;
			object obj20 = default;
			object obj16;
			float num4 = default;
			Enumerator<, > val3;
			while (true)
			{
				vector = (Vector3)obj4;
				GillaSplashPool result;
				object obj17;
				if (val.MoveNext())
				{
					if ((object)gillaSplashPool3 == null)
					{
						break;
					}
					Vector2 vector2 = gillaSplashPool3.Local((Vector3)obj4);
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v34+E4]");
					gillaSplashPool = (GillaSplashPool)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v34+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num3 = (float)gillaSplashPool3.area;
					num = (float)gillaSplashPool3.area - (float)obj9;
					if (!(num4 > num))
					{
						continue;
					}
					object obj10 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v36+E4]");
					gillaSplashPool = (GillaSplashPool)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v36+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num3 = (float)gillaSplashPool3.area;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+2C]");
					num = 0f;
					float num5 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+2C]");
					float num6 = num5 + 0f;
					num3 = num6 + (float)obj9;
					if (!(num4 < num3))
					{
						continue;
					}
					object obj12 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v38+E4]");
					gillaSplashPool = (GillaSplashPool)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v38+E4]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+28]");
					num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+28]");
					num = 0f - (float)obj9;
					if (!(num2 > num))
					{
						continue;
					}
					object obj14 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v40+E4]");
					gillaSplashPool = (GillaSplashPool)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v40+E4]");
					bool flag6 = (nint)0 == 0;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+28]");
						num3 = 0f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+30]");
					num = 0f;
					float num7 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ stack_-88 (GillaSplashPool)+30]");
					float num8 = num7 + 0f;
					num3 = num8 + (float)obj9;
					if (!(num2 < num3))
					{
						continue;
					}
					gillaSplashPool2 = null;
					val = val2;
					obj16 = 0;
					val3 = (Enumerator<, >)(ref val);
					result = gillaSplashPool3;
					obj17 = 0;
					goto IL_059f;
				}
				gillaSplashPool2 = null;
				val = val2;
				obj16 = 0;
				val3 = (Enumerator<, >)(ref val);
				obj17 = 0;
				goto IL_05e8;
				IL_05e8:
				result = null;
				goto IL_059f;
				IL_059f:
				vector = (Vector3)obj6;
				((Enumerator<, >*)val3)->Dispose();
				bool flag7 = obj17 == null;
				object obj18 = !flag7;
				num2 = num;
				num4 = num3;
				if (obj18 == null)
				{
					bool flag8 = (object)gillaSplashPool2 == null;
					object obj19 = !flag8;
					num2 = num;
					num4 = num3;
					OutOfMemoryException ex = (OutOfMemoryException)val3;
					if (obj19 == null)
					{
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (vector == (Vector3)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num = num2;
					gillaSplashPool2 = (GillaSplashPool)1;
					num3 = num4;
					gillaSplashPool = (GillaSplashPool)1;
					obj17 = obj16;
				}
				else
				{
					if (vector != (Vector3)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E7A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj17 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num = num2;
					obj16 = obj20;
					num3 = num4;
				}
				goto IL_05e8;
			}
			NullReferenceException ex2 = new NullReferenceException();
			num2 = num;
			gillaSplashPool2 = null;
			val = val2;
			obj16 = 0;
			num4 = num3;
			val3 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public unsafe void Lay(List<GillaSplashSpectate.Footprint> platforms)
	{
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected F8, but got I4
		//IL_0b88: Expected I4, but got Obj
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0033: Expected I4, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected F8, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_009c: Expected I4, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0ad2: Expected Obj, but got I
		//IL_0ba6: Expected Obj, but got I
		//IL_0bd6: Expected I4, but got Obj
		//IL_11cf: Expected Obj, but got I
		//IL_0bf3: Expected F8, but got I4
		//IL_0a70: Expected Obj, but got I
		//IL_0a78: Expected I4, but got Obj
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got I
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got I
		//IL_053a: Expected F8, but got I
		//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected F8, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected Obj, but got I
		//IL_09b2: Expected I4, but got Obj
		//IL_0561: Expected Obj, but got I4
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_0d45: Expected Obj, but got I4
		//IL_0d92: Expected VT, but got Ref
		//IL_0daf: Expected VT, but got Ref
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and F8
		//IL_01df: Expected F8, but got VT
		//IL_0602: Expected Obj, but got VT
		//IL_0610: Expected Obj, but got VT
		//IL_0620: Expected Obj, but got I4
		//IL_0636: Expected I4, but got Obj
		//IL_06a1: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected F8, but got I
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Invalid comparison between Unknown and F8
		//IL_06db: Expected Obj, but got VT
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected VT, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got I4
		//IL_113d: Expected VT, but got I4
		//IL_114a: Expected Obj, but got VT
		//IL_1166: Expected Obj, but got VT
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1173: Expected Obj, but got Unknown
		//IL_11a8: Expected Obj, but got I4
		//IL_0295: Expected F8, but got I
		//IL_02f7: Expected Obj, but got I4
		//IL_1020: Expected Obj, but got I4
		//IL_1099: Expected Obj, but got I4
		//IL_0cb5: Expected F8, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_031f: Expected F8, but got I
		//IL_10be: Expected I4, but got VT
		//IL_10fa: Expected Obj, but got I4
		//IL_1114: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected F8, but got I
		//IL_0f15: Expected Obj, but got I4
		//IL_0879: Invalid comparison between F8 and I4
		//IL_0e30: Expected VT, but got Obj
		//IL_0e52: Expected Obj, but got I4
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected VT, but got Unknown
		//IL_0e88: Expected VT, but got I4
		//IL_0e95: Expected Obj, but got VT
		//IL_0eb1: Expected Obj, but got VT
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_0ef3: Expected Obj, but got I4
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected I4, but got VT
		//IL_08c7: Expected VT, but got I
		//IL_08d6: Expected Obj, but got I4
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_0904: Expected Obj, but got I4
		List<GillaSplashSpectate.Footprint> list = feet;
		bool flag = feet == null;
		Enumerator<, > val = (Enumerator<, >)0;
		double num = 0.0;
		IntPtr intPtr = default;
		int num2 = (int)(nint)intPtr;
		int num3 = (int)platforms;
		object obj3;
		int num4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+1C]");
			object obj2 = (nint)0 + (nint)1;
			num2 = (int)obj;
			_ = 0;
			feet.AddRange(standing);
			List<GillaSplashSpectate.Footprint> list2 = feet;
			bool flag2 = feet == null;
			val = (Enumerator<, >)0;
			num = 0.0;
			num3 = (int)standing;
			if (!flag2)
			{
				num2 = (int)obj;
				feet.AddRange((IEnumerable<GillaSplashSpectate.Footprint>)platforms);
				obj3 = this + 80;
				object obj4 = obj3;
				if (obj3 != null)
				{
					num4 = rows;
					num3 = rows * cols;
					int num5 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X9_v4+18]");
					if ((nint)num5 == 0)
					{
						goto IL_0bdb;
					}
				}
				else
				{
					num3 = rows * cols;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				byte[] array = default;
				cells = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num4 = rows;
				num3 = (int)array;
				goto IL_0bdb;
			}
		}
		goto IL_09fb;
		IL_0bdb:
		bool flag3 = num4 < 1;
		num = 0.0;
		if (flag3)
		{
			goto IL_04d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj6 = 0;
		int num6 = cols;
		double num8 = default;
		double num7 = num8;
		Enumerator<, > val2 = (Enumerator<, >)0;
		int num9 = num2;
		int num10 = num3;
		int num11 = 0;
		Enumerator<, > val3;
		while (true)
		{
			bool flag4 = num6 < 1;
			num = (double)val2;
			int num13;
			double num14;
			if (!flag4)
			{
				double num12 = num7;
				num13 = 0;
				while (true)
				{
					Vector2 vector = CellMiddle(num13, num11);
					List<GillaSplashSpectate.Footprint> list2 = (List<GillaSplashSpectate.Footprint>)obj6;
					byte[] array2 = cells;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v70 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Rect rect = area;
					num7 = (double)area + 0.5;
					bool flag6 = (double)val2 < num7;
					num14 = (double)area;
					object obj12;
					if (!flag6)
					{
						list2 = (List<GillaSplashSpectate.Footprint>)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v70 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+E4]");
						bool flag7 = (nint)0 == 0;
						object obj8 = !flag7;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							rect = area;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+2C]");
						num7 = 0.0;
						double num15 = (double)rect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+2C]");
						double num16 = num15 + 0.0;
						num14 = num16 + -0.5;
						if (!((double)val2 > num14))
						{
							list2 = (List<GillaSplashSpectate.Footprint>)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v70 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+E4]");
							bool flag8 = (nint)0 == 0;
							object obj9 = !flag8;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
							num14 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
							num7 = 0.0 + 0.5;
							if (!(num12 < num7))
							{
								list2 = (List<GillaSplashSpectate.Footprint>)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v70 (System.Collections.Generic.List`1<GillaSplashSpectate+Footprint>)+E4]");
								bool flag9 = (nint)0 == 0;
								object obj10 = !flag9;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
									num14 = 0.0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+30]");
								num7 = 0.0;
								double num17 = num14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+30]");
								double num18 = num17 + 0.0;
								num14 = num18 + -0.5;
								if (!(num12 > num14))
								{
									bool flag10 = cells == null;
									object obj11 = !flag10;
									obj12 = 0;
									if (obj11 == null)
									{
										val = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+30]");
										num8 = 0.0;
										num = num14;
										num2 = num11;
										num3 = num13;
										break;
									}
									goto IL_0375;
								}
							}
						}
					}
					bool flag11 = cells == null;
					obj12 = 1;
					val = (Enumerator<, >)0;
					num8 = num7;
					num = num14;
					num2 = num11;
					num3 = num13;
					if (flag11)
					{
						break;
					}
					goto IL_0375;
					IL_0375:
					bool flag12 = (byte)(num11 * cols) != 0;
					object obj13 = num13 + (flag12 ? 1 : 0);
					bool flag13 = (nint)obj13 < array2.Length;
					object obj14 = !flag13;
					val3 = (Enumerator<, >)0;
					num8 = num7;
					num = num14;
					num2 = num11;
					num3 = num13;
					if (obj14 == null)
					{
						object obj15 = (object)cells + obj13;
						num13++;
						num6 = cols;
						bool flag14 = num13 < cols;
						num12 = num7;
						val2 = (Enumerator<, >)num14;
						if (flag14)
						{
							continue;
						}
						goto IL_04ab;
					}
					goto IL_0a11;
				}
				break;
			}
			goto IL_0c01;
			IL_04ab:
			num4 = rows;
			num = num14;
			num9 = num11;
			num10 = num13;
			goto IL_0c01;
			IL_0c01:
			num11++;
			bool flag15 = num11 < num4;
			num8 = num7;
			num2 = num9;
			num3 = num10;
			val2 = (Enumerator<, >)num;
			if (flag15)
			{
				continue;
			}
			goto IL_04d2;
		}
		goto IL_09fb;
		IL_09fb:
		NullReferenceException ex = new NullReferenceException();
		val3 = val;
		goto IL_0a11;
		IL_09c0:
		DrawFoam();
		return;
		IL_04d2:
		bool flag16 = feet == null;
		val = (Enumerator<, >)0;
		int num44;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8470]");
			object obj16 = 0;
			Enumerator<, > enumerator = feet.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num19 = 0.0;
			double num21 = default;
			double num20 = num21;
			object obj18 = default;
			double num23 = default;
			double num27 = default;
			object obj25 = default;
			object obj26 = default;
			object obj48 = default;
			double num39 = default;
			Enumerator<, > val4 = default;
			while (val.MoveNext())
			{
				bool flag17 = (nint)obj18 < 0;
				object obj19 = !flag17;
				bool flag18 = obj18 == null;
				object obj20 = ~obj19;
				object obj21 = obj20 | flag18;
				double num22 = num23;
				if (obj21 == null)
				{
					object obj22 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X0_v64+E4]");
					bool flag19 = (nint)0 == 0;
					object obj23 = !flag19;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num24 = num23 * num23;
					object obj24 = obj18 * obj18;
					num22 = num24 + (double)obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				}
				double num25 = num22 + 0.5;
				double num26 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				double num28 = num26 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
				(int, int) tuple = CellOf((Vector2)(&obj25));
				num20 = (double)obj26 + num25;
				(int, int) tuple2 = CellOf((Vector2)(&obj25));
				int num29 = rows;
				object obj27 = tuple >> 32;
				object obj28 = tuple2 >> 32;
				object obj29 = rows - 1;
				object obj30 = ~obj27;
				int num30 = obj27 & obj30;
				object obj31 = obj29 - obj28;
				bool flag20 = (nint)obj31 < 0;
				object obj32 = obj29 ^ obj28;
				object obj33 = obj29 ^ obj31;
				object obj34 = obj32 & obj33;
				bool flag21 = (nint)obj34 < 0;
				bool flag22 = flag20 == flag21;
				object obj35 = !flag22;
				object obj36 = ~obj35;
				object obj37 = ((obj36 != null) ? obj28 : obj29);
				if (num30 > (nint)obj37)
				{
					continue;
				}
				object obj38 = ~tuple;
				(int, int) tuple3 = ((int, int))(tuple & obj38);
				int num31 = cols;
				double num32 = num23 + 0.5;
				double num33 = (double)obj18 + 0.5;
				double num34 = num33;
				double num35 = num23;
				double num36 = num27;
				while (true)
				{
					(int, int) tuple4 = ((int, int))(num31 - 1);
					object obj39 = tuple4 - tuple2;
					bool flag23 = (nint)obj39 < 0;
					object obj40 = tuple4 ^ tuple2;
					object obj41 = tuple4 ^ obj39;
					object obj42 = obj40 & obj41;
					bool flag24 = (nint)obj42 < 0;
					bool flag25 = flag23 == flag24;
					object obj43 = !flag25;
					object obj44 = ~obj43;
					if (obj44 != null)
					{
						tuple4 = tuple2;
					}
					double num41;
					double num42;
					if (tuple3 <= tuple4)
					{
						(int, int) tuple5 = tuple3;
						while (true)
						{
							Vector2 vector2 = CellMiddle((int)tuple5, num30);
							num35 = num34 - num21;
							num36 = num20 - (double)obj26;
							bool flag26 = (nint)obj18 < 0;
							object obj45 = !flag26;
							bool flag27 = obj18 == null;
							object obj46 = !flag27;
							object obj47 = obj45 & obj46;
							if (obj47 != null)
							{
								double num37 = (double)obj48 * num35;
								double num38 = (double)obj25 * num36;
								num19 = (double)obj25 * num35;
								num39 = (double)obj48 * num36;
								num = num37 + num38;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								bool flag28;
								if (num38 < num32)
								{
									double num40 = num - num33;
									flag28 = num40 < 0.0;
								}
								else
								{
									flag28 = false;
								}
								object obj49 = !flag28;
								num8 = num33;
								num41 = num39;
								num42 = num19;
								num20 = num33;
								num34 = num;
								if (obj49 == null)
								{
									goto IL_0892;
								}
							}
							else
							{
								vector2 = (Vector2)obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v53 (UnityEngine.Vector2)+E4]");
								bool flag29 = (nint)0 == 0;
								obj38 = !flag29;
								if (obj38 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								double num43 = num35 * num35;
								num8 = num36 * num36;
								num = num43 + num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								if (num < num32)
								{
									goto IL_0892;
								}
								num41 = num39;
								num42 = num19;
								num20 = num8;
								num34 = num;
							}
							goto IL_0e60;
							IL_0e60:
							num31 = cols;
							tuple5 = ((int, int))(tuple5 + 1);
							(int, int) tuple6 = ((int, int))(cols - 1);
							object obj50 = tuple6 - tuple2;
							bool flag30 = (nint)obj50 < 0;
							object obj51 = tuple6 ^ tuple2;
							object obj52 = tuple6 ^ obj50;
							object obj53 = obj51 & obj52;
							bool flag31 = (nint)obj53 < 0;
							bool flag32 = flag30 == flag31;
							object obj54 = !flag32;
							object obj55 = ~obj54;
							if (obj55 != null)
							{
								tuple6 = tuple2;
							}
							bool flag33 = tuple5 <= tuple6;
							num39 = num41;
							num19 = num42;
							if (flag33)
							{
								continue;
							}
							goto IL_095c;
							IL_0892:
							object obj56 = obj3;
							if (obj3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v40+18]");
								tuple4 = ((int, int))0;
								obj38 = num30 * cols;
								object obj57 = tuple5 + obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v40+18]");
								bool flag34 = (nint)obj57 < 0;
								object obj58 = !flag34;
								if (obj58 == null)
								{
									object obj59 = obj3 + obj57;
									_ = 1;
									num41 = num39;
									num42 = num19;
									num20 = num8;
									num34 = num;
									goto IL_0e60;
								}
							}
							else
							{
								NullReferenceException ex2 = new NullReferenceException();
							}
							IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
							val = val4;
							num2 = num30;
							num3 = (int)tuple5;
							break;
						}
						break;
					}
					goto IL_1012;
					IL_1012:
					object obj60 = num29 - 1;
					num30++;
					object obj61 = obj60 - obj28;
					bool flag35 = (nint)obj61 < 0;
					object obj62 = obj60 ^ obj28;
					object obj63 = obj60 ^ obj61;
					object obj64 = obj62 & obj63;
					bool flag36 = (nint)obj64 < 0;
					bool flag37 = flag35 == flag36;
					object obj65 = !flag37;
					object obj66 = ~obj65;
					if (obj66 != null)
					{
						obj60 = obj28;
					}
					if (num30 > (nint)obj60)
					{
						goto IL_0f99;
					}
					continue;
					IL_095c:
					num29 = rows;
					num39 = num41;
					num19 = num42;
					num2 = num30;
					goto IL_1012;
				}
				goto IL_09fb;
				IL_0f99:;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8468]");
			object obj67 = 0;
			num44 = (int)obj67;
			val.Dispose();
			goto IL_09c0;
		}
		goto IL_09fb;
		IL_0a11:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		bool flag38 = num3 == 2;
		num44 = num3;
		if (!flag38)
		{
			bool flag39 = num3 != 1;
			IndexOutOfRangeException ex5 = ex4;
			if (!flag39)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8468]");
				object obj68 = 0;
				num44 = (int)obj68;
				val3.Dispose();
				object obj69 = default;
				if (obj69 != null)
				{
					throw new OutOfMemoryException();
				}
				goto IL_09c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8468]");
			object obj70 = 0;
			val3.Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			IndexOutOfRangeException ex6 = default;
			IndexOutOfRangeException ex5 = ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8468]");
		object obj71 = 0;
		val3.Dispose();
		throw new OutOfMemoryException();
	}

	private bool Free(int c, int r)
	{
		//IL_001f: Expected I4, but got I8
		//IL_0039: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_016e: Expected I4, but got Obj
		int num = c | r;
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null && cols > c && rows > r)
		{
			byte[] array = cells;
			if (cells != null)
			{
				object obj2 = rows * cols;
				if ((nint)obj2 == array.Length)
				{
					object obj3 = cols * r;
					object obj4 = c + obj3;
					bool flag2 = (nint)obj4 < array.Length;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						object obj6 = (object)cells + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5+20]");
						return (nint)0 == 0;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					return (byte)(int)ex != 0;
				}
			}
			return true;
		}
		return false;
	}

	private (int, int) CellOf(Vector2 local)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00e1: Expected I4, but got F4
		//IL_00e1: Expected I4, but got F4
		//IL_00e7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+E4]");
		object obj6;
		float num;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
			obj6 = 0;
			num = cell;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
			obj6 = 0;
			num = cell;
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = default;
		object obj9 = obj10 - obj6;
		object obj12 = default;
		object obj11 = obj12 - area;
		float num2 = (float)obj9 / num;
		float num3 = (float)obj11 / cell;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		(int, int) tuple = ((int)num3, (int)num2);
		return ((int, int))0;
	}

	private Vector2 CellMiddle(int c, int r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0031: Expected VT, but got Obj
		//IL_0053: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj = 0;
		Vector2 result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Vector2)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return result;
	}

	private unsafe bool NearestFree(Vector2 local, out (int, int) at)
	{
		//IL_03e8: Expected Obj, but got I4
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected I4, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0395: Expected I4, but got I8
		//IL_0395: Expected I4, but got I8
		//IL_039e: Expected native int or pointer, but got VT
		//IL_0027: Expected Obj, but got VT
		//IL_0037: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_0687: Expected Obj, but got I
		//IL_06aa: Expected I4, but got I8
		//IL_06aa: Expected I4, but got I8
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_06c1: Expected native int or pointer, but got VT
		//IL_06cf: Expected VT, but got I4
		//IL_06dc: Expected I4, but got I8
		//IL_06e9: Expected I4, but got I8
		//IL_06f2: Expected VT, but got I4
		//IL_006b: Unsupported input type for neg.
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0664: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_00e4: Unsupported input type for neg.
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I4, but got Unknown
		//IL_0122: Expected I4, but got Obj
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected I4, but got Unknown
		//IL_016b: Expected I4, but got Obj
		//IL_01be: Expected VT, but got Obj
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected I4, but got Unknown
		//IL_01fa: Expected Obj, but got I
		//IL_0207: Expected I4, but got Obj
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0237: Expected VT, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected I4, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		(int, int) tuple = CellOf(local);
		int num = cols;
		object obj = cols - rows;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num2 = cols ^ rows;
		int num3 = cols ^ obj;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			num = rows;
		}
		(int, int) tuple2;
		if (num >= 1)
		{
			object obj5 = tuple >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			object obj11 = 1;
			object obj12 = 1;
			object obj13 = 0;
			bool flag15;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
				object obj14 = 0;
				object obj15 = obj14;
				tuple2 = (-1, -1);
				object obj16 = 0 - obj13;
				((Vector2*)(nint)local)->x = 0f;
				tuple2 = ((int, int))0;
				int num5 = -1;
				int num6 = -1;
				Vector2 vector = (Vector2)2139095039;
				object obj17 = obj16;
				do
				{
					object obj18;
					object obj19;
					object obj20;
					if ((nint)obj17 < 0)
					{
						obj18 = 0 - obj17;
						obj19 = obj11;
						obj20 = obj16;
					}
					else
					{
						obj19 = obj11;
						obj18 = obj17;
						obj20 = obj16;
					}
					do
					{
						object obj21 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v13+E4]");
						bool flag5 = (nint)0 == 0;
						object obj22 = !flag5;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj23 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v15+E4]");
						bool flag6 = (nint)0 == 0;
						object obj24 = !flag6;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj25 = (((nint)obj20 >= 0) ? obj20 : ((object)(0 - obj20)));
						object obj26 = obj18 - obj25;
						bool flag7 = (nint)obj26 < 0;
						bool flag8 = obj26 == null;
						object obj27 = obj18 ^ obj25;
						object obj28 = obj18 ^ obj26;
						object obj29 = obj27 & obj28;
						bool flag9 = (nint)obj29 < 0;
						bool flag10 = flag7 == flag9;
						object obj30 = !flag8;
						object obj31 = flag10 & obj30;
						object obj32 = ~obj31;
						if (obj32 == null)
						{
							obj25 = obj18;
						}
						if (obj25 == obj13)
						{
							num6 = (int)(obj17 + tuple);
							num5 = (int)(obj5 + obj20);
							if (Free(num6, num5))
							{
								num6 = (int)(obj17 + tuple);
								num5 = (int)(obj5 + obj20);
								Vector2 vector2 = CellMiddle(num6, num5);
								object obj33 = obj9 - obj10;
								object obj34 = obj7 - obj8;
								obj9 = obj33 * obj33;
								obj7 = obj34 * obj34;
								Vector2 vector3 = (Vector2)(obj9 + obj7);
								if (vector3 < vector)
								{
									num6 = (int)(obj17 + tuple);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41E0]");
									object obj35 = 0;
									num5 = (int)(obj5 + obj20);
									obj15 = obj35;
									tuple2 = (num6, num5);
									((Vector2*)(nint)local)->x = 0f;
									tuple2 = ((int, int))0;
									vector = vector3;
								}
							}
						}
						obj19--;
						obj20++;
					}
					while ((nint)obj19 != 1);
					obj17++;
				}
				while (obj17 != obj12);
				object obj36 = local.x & 0x80000000L;
				if (obj36 != null)
				{
					int num7 = cols;
					obj13++;
					object obj37 = cols - rows;
					bool flag11 = (nint)obj37 < 0;
					bool flag12 = obj37 == null;
					int num8 = cols ^ rows;
					int num9 = cols ^ obj37;
					int num10 = num8 & num9;
					bool flag13 = num10 < 0;
					bool flag14 = flag11 == flag13;
					object obj38 = !flag12;
					object obj39 = flag14 & obj38;
					object obj40 = ~obj39;
					if (obj40 != null)
					{
						num7 = rows;
					}
					object obj41 = obj12 + 1;
					object obj42 = obj11 + 2;
					flag15 = (nint)obj13 < num7;
					obj11 = obj42;
					obj12 = obj41;
					continue;
				}
				return true;
			}
			while (flag15);
		}
		tuple2 = (-1, -1);
		((Vector2*)(nint)local)->x = 0f;
		return false;
	}

	public unsafe Vector3 FreeNear(Vector3 world)
	{
		//IL_001c: Expected VT, but got Ref
		//IL_003c: Expected VT, but got I4
		//IL_0066: Expected VT, but got I4
		Vector2 vector = Local(world);
		int num = default;
		IntPtr intPtr = default;
		bool flag = NearestFree((Vector2)(&num), out *((int, int)*)intPtr);
		bool flag2 = !flag;
		Vector3 result = (Vector3)flag;
		if (!flag2)
		{
			int r = default;
			Vector2 vector2 = CellMiddle(num, r);
			result = World((Vector2)num);
		}
		return result;
	}

	public Vector3 RandomSpot(Vector3 from, float awayFrom)
	{
		//IL_001e: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_01a2: Expected VT, but got I4
		//IL_01b1: Expected VT, but got I4
		//IL_01c2: Expected I4, but got Obj
		//IL_01e4: Expected Obj, but got I4
		//IL_0145: Invalid comparison between F4 and Obj
		Vector2 vector = Local(from);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj3 = default;
		object obj2 = obj3;
		float num = awayFrom;
		object obj4 = 0;
		int num2;
		object obj12 = default;
		while (true)
		{
			num2 = UnityEngine.Random.Range(0, cols);
			int r = UnityEngine.Random.Range(0, rows);
			bool flag = Free(num2, r);
			bool flag2 = !flag;
			object obj5 = obj2;
			float num3 = num;
			if (!flag2)
			{
				Vector2 vector2 = CellMiddle(num2, r);
				bool flag3 = (nint)obj4 < 29;
				object obj6 = !flag3;
				object obj7 = obj4 - 29;
				bool flag4 = obj7 == null;
				object obj8 = !flag4;
				object obj9 = obj6 & obj8;
				if (obj9 != null)
				{
					break;
				}
				flag = (byte)(int)obj != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v10 (System.Boolean)+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num4 = num - awayFrom;
				object obj11 = obj2 - obj3;
				float num5 = num4 * num4;
				obj5 = obj11 * obj11;
				num3 = num5 + (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
				{
					break;
				}
			}
			obj4++;
			bool flag6 = (nint)obj4 != 40;
			obj2 = obj5;
			num = num3;
			if (!flag6)
			{
				return (Vector3)flag;
			}
		}
		return World((Vector2)num2);
	}

	private bool Clear(Vector2 a, Vector2 b)
	{
		//IL_0144: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_0222: Invalid comparison between F8 and I4
		//IL_01e0: Expected I4, but got VT
		//IL_01ee: Expected I4, but got VT
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b4: Invalid comparison between F8 and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0102: Invalid comparison between Obj and F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj7 = 0.5 & 0x80000000L;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		bool flag4 = default;
		if (obj8 == null)
		{
			object obj9 = 1;
			(int, int) tuple = default;
			bool flag5;
			do
			{
				if (0.5 != 0.0)
				{
					obj5 = obj9 - 1;
					double num = (double)obj5 / 0.5;
					if (!(num < 0.0) && num > 1.0)
					{
						goto IL_00e7;
					}
				}
				tuple = CellOf((Vector2)tuple);
				int r = tuple >> 32;
				flag4 = Free((int)tuple, r);
				if (!flag4)
				{
					break;
				}
				goto IL_00e7;
				IL_00e7:
				object obj10 = obj9 + 1;
				flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
				obj9 = obj10;
			}
			while (flag5);
		}
		else
		{
			flag4 = true;
		}
		return flag4;
	}

	public unsafe List<Vector3> Path(Vector3 from, Vector3 to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_148d: Expected VT, but got Obj
		//IL_002f: Expected VT, but got Obj
		//IL_0041: Expected Ref, but got VT
		//IL_0041: Expected VT, but got Ref
		//IL_007d: Expected Ref, but got VT
		//IL_007d: Expected VT, but got Ref
		//IL_00b4: Expected VT, but got Ref
		//IL_0211: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_00df: Expected VT, but got Ref
		//IL_0348: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected I4, but got Unknown
		//IL_03bb: Expected Obj, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_1076: Expected Obj, but got I
		//IL_1086: Expected Obj, but got I
		//IL_109b: Expected VT, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I
		//IL_14ca: Expected Obj, but got I
		//IL_14f4: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_04ad: Expected Obj, but got I
		//IL_04b5: Expected I4, but got Obj
		//IL_04c4: Expected Obj, but got I4
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected I4, but got Unknown
		//IL_04df: Expected VT, but got I4
		//IL_04f3: Expected Obj, but got I
		//IL_04fb: Expected VT, but got Obj
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I
		//IL_054b: Expected VT, but got I4
		//IL_0ddd: Expected Obj, but got I4
		//IL_1703: Expected Obj, but got VT
		//IL_1713: Expected Obj, but got I
		//IL_171b: Expected I4, but got Obj
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected Obj, but got Unknown
		//IL_0e12: Expected Obj, but got I8
		//IL_058e: Expected Obj, but got VT
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected I4, but got Unknown
		//IL_05ac: Expected Obj, but got I4
		//IL_05b9: Expected I4, but got Obj
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_0e66: Expected Obj, but got I
		//IL_16d9: Expected Obj, but got I4
		//IL_0e91: Expected I4, but got I8
		//IL_0eab: Expected Obj, but got I4
		//IL_1512: Expected Obj, but got I
		//IL_1522: Expected Obj, but got I
		//IL_0ec9: Expected Obj, but got I
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_0640: Expected Obj, but got I4
		//IL_10d5: Expected Obj, but got I
		//IL_10e8: Expected VT, but got Obj
		//IL_1786: Expected Obj, but got I4
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Expected I4, but got Unknown
		//IL_10f9: Invalid comparison between I4 and VT
		//IL_065e: Expected Obj, but got I
		//IL_0ede: Expected Obj, but got I
		//IL_0efc: Expected Obj, but got I
		//IL_112a: Expected VT, but got Obj
		//IL_113c: Expected Obj, but got VT
		//IL_06a4: Expected Obj, but got I4
		//IL_1204: Expected Obj, but got I
		//IL_1214: Expected Obj, but got I
		//IL_0f4f: Expected Obj, but got I4
		//IL_117b: Expected Obj, but got I
		//IL_11a2: Expected VT, but got Obj
		//IL_0fb4: Expected Obj, but got I
		//IL_0fc4: Expected Obj, but got I
		//IL_0fd9: Expected VT, but got I
		//IL_0715: Expected VT, but got I4
		//IL_0fff: Expected Obj, but got I4
		//IL_0f7a: Expected Obj, but got I
		//IL_0f90: Expected Obj, but got I
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_180a: Expected VT, but got I4
		//IL_1259: Expected VT, but got Obj
		//IL_1259: Expected VT, but got I4
		//IL_073d: Expected Obj, but got I4
		//IL_074d: Expected VT, but got I4
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected Obj, but got Unknown
		//IL_1044: Expected I4, but got I8
		//IL_0d4d: Expected Obj, but got I
		//IL_0d55: Expected VT, but got Obj
		//IL_0b6a: Expected Obj, but got I4
		//IL_12d1: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I
		//IL_1635: Expected Obj, but got I
		//IL_1645: Expected Obj, but got I
		//IL_076b: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I4
		//IL_1342: Expected Obj, but got I4
		//IL_0bb0: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got I4
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07e0: Expected Obj, but got I4
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected I4, but got Unknown
		//IL_07f8: Expected Obj, but got I4
		//IL_13ba: Expected Obj, but got I
		//IL_13ca: Expected Obj, but got I
		//IL_13df: Expected VT, but got I
		//IL_1366: Expected Obj, but got I
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected Obj, but got Unknown
		//IL_1391: Expected Obj, but got I
		//IL_0c0c: Expected VT, but got I4
		//IL_1560: Expected Obj, but got I4
		//IL_082c: Expected F8, but got I
		//IL_0c44: Expected Obj, but got I4
		//IL_085c: Expected F4, but got Obj
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_087f: Expected I, but got Obj
		//IL_0896: Invalid comparison between F4 and Obj
		//IL_167a: Expected Obj, but got I
		//IL_168a: Expected Obj, but got I
		//IL_08df: Expected F4, but got Obj
		//IL_08e8: Expected F4, but got I4
		//IL_0c8a: Expected Obj, but got I4
		//IL_1587: Expected Obj, but got I4
		//IL_0cd9: Expected Obj, but got I4
		//IL_0ce1: Expected VT, but got I4
		//IL_0cf9: Expected VT, but got I4
		//IL_09e9: Expected Obj, but got F4
		//IL_15a5: Expected Obj, but got I
		//IL_15cf: Expected Obj, but got I4
		//IL_0a27: Expected Obj, but got I4
		//IL_09ba: Expected VT, but got I4
		//IL_09d3: Expected Obj, but got I
		//IL_09dc: Expected VT, but got I4
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_15ed: Expected Obj, but got I
		//IL_1617: Expected Obj, but got I4
		//IL_0b0a: Expected Obj, but got I
		//IL_0b12: Expected I4, but got Obj
		//IL_0b20: Expected VT, but got I4
		//IL_0b32: Expected VT, but got I4
		//IL_0b3b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		Vector2 vector = Local((Vector3)obj2);
		Vector2 vector2 = Local((Vector3)obj2);
		int num = default;
		bool flag = NearestFree((Vector2)(&num), out *((int, int)*)to);
		bool flag2 = !flag;
		List<Vector3> result = list;
		int num2 = default;
		object obj16 = default;
		object obj19 = default;
		if (!flag2)
		{
			bool flag3 = NearestFree((Vector2)(&num2), out *((int, int)*)to);
			bool flag4 = !flag3;
			result = list;
			if (!flag4)
			{
				if (Clear((Vector2)(&num2), to))
				{
					Vector3 vector3 = World((Vector2)(&num2));
					if (list != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj4 = 0;
						object obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj6 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v116+18]");
							bool flag5 = num3 < 0;
							object obj7 = !flag5;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj8 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj9 = 0 + obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj10 = (nint)0 + (nint)1;
								result = list;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X9_v49+20]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v117+A8]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v118+70]");
								list.AddWithResize((Vector3)0);
								result = list;
							}
							goto IL_144f;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
					object obj13 = 0;
					object obj14 = rows * cols;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					if ((nint)obj14 < 1)
					{
						goto IL_0338;
					}
					if (obj16 != null)
					{
						object obj17 = obj16 + 32;
						object obj18 = obj19 + 32;
						object obj20 = 0;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v19+18]");
							if (0 == (nint)obj20)
							{
								break;
							}
							_ = 2139095039;
							if (obj19 != null)
							{
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v21+18]");
								bool flag6 = (nint)obj21 < 0;
								object obj22 = !flag6;
								if (obj22 != null)
								{
									break;
								}
								_ = 4294967295L;
								obj20++;
								if (obj14 != obj20)
								{
									continue;
								}
								goto IL_0338;
							}
							goto IL_1462;
						}
						goto IL_1454;
					}
				}
				goto IL_1462;
			}
		}
		goto IL_144f;
		IL_0338:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84E0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SortedSet<(float, int)> sortedSet = default;
		sortedSet._002Ector();
		int num6 = default;
		IntPtr intPtr = default;
		float num9 = default;
		float num20 = default;
		List<Vector2> list3 = default;
		if (obj16 != null)
		{
			int num4 = default;
			object obj24 = num4 * cols;
			int num5 = num + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v19+18]");
			bool flag7 = (nint)num5 < (nint)0;
			object obj25 = !flag7;
			if (obj25 != null)
			{
				goto IL_1454;
			}
			object obj26 = obj16 + num5;
			_ = 0;
			Vector2 vector4 = CellMiddle(num, num4);
			Vector2 vector5 = CellMiddle(num2, num6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v31+E4]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num7 = (float)(nint)intPtr - (float)(nint)intPtr;
			float num8 = num9 - num9;
			float num10 = num7 * num7;
			float num11 = num8 * num8;
			float num12 = num10 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			(float, int) tuple = (num12, num5);
			if (sortedSet != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84B8]");
				object obj30 = 0;
				int num13 = (int)obj30;
				object obj31 = num6 * cols;
				int num14 = num2 + obj31;
				bool flag9 = sortedSet.Add(((float, int))0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84D0]");
				object obj32 = 0;
				(float, int) tuple2 = ((float, int))obj32;
				int count = sortedSet.Count;
				bool flag10 = count < 1;
				int num15 = num14;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
					object obj33 = 0;
					(float, int) tuple3 = ((float, int))0;
					SortedSet<(float, int)> sortedSet2 = sortedSet;
					float num16 = num11;
					float num17 = num12;
					List<Vector3> list2 = list;
					nint num18 = intPtr;
					float num19 = num20;
					bool flag40;
					do
					{
						(float, int) min = sortedSet2.Min;
						object obj34 = min >> 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84C0]");
						object obj35 = 0;
						num13 = (int)obj35;
						bool flag11 = sortedSet2.Remove(min);
						bool flag12 = num14 == (nint)obj34;
						num11 = num16;
						num12 = num17;
						tuple2 = min;
						num15 = num14;
						if (flag12)
						{
							break;
						}
						object obj36 = min >> 32;
						int num21 = obj34 / cols;
						object obj37 = num21 * cols;
						int num22 = obj34 - obj37;
						object obj38 = obj16 + obj36;
						object obj39 = obj38 + 32;
						tuple = tuple3;
						(float, int) tuple4 = min;
						int num23 = num14;
						object obj40 = 8;
						while (true)
						{
							object obj41 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v75+E4]");
							bool flag13 = (nint)0 == 0;
							object obj42 = !flag13;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj41 = obj33;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v75+A0]");
							object obj43 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X9_v27+8]");
							object obj44 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X9_v27+8]");
							if ((nint)0 == 0)
							{
								break;
							}
							object obj45 = obj40 - 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v71+18]");
							bool flag14 = (nint)obj45 < 0;
							object obj46 = !flag14;
							int num24;
							int num25;
							int num26;
							(float, int) tuple5;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X9_v27+10]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X9_v27+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X9_v28+18]");
								bool flag15 = (nint)obj45 < 0;
								object obj48 = !flag15;
								if (obj48 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v71+v842 @ X22_v13*4]");
									num24 = (int)((nint)0 + (nint)num22);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X9_v28+v842 @ X22_v13*4]");
									num25 = (int)((nint)0 + (nint)num21);
									bool flag16 = Free(num24, num25);
									bool flag17 = !flag16;
									tuple3 = tuple;
									num13 = num25;
									tuple4 = ((float, int))num24;
									if (!flag17)
									{
										bool flag18 = (nint)obj45 < 4;
										object obj49 = !flag18;
										num26 = num25;
										tuple5 = ((float, int))num24;
										if (obj49 == null)
										{
											goto IL_075b;
										}
										object obj50 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v82+E4]");
										bool flag19 = (nint)0 == 0;
										object obj51 = !flag19;
										if (obj51 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj50 = obj33;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v82+A0]");
										object obj52 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v77+8]");
										object obj53 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v77+8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v78+18]");
										bool flag20 = (nint)obj45 < 0;
										object obj54 = !flag20;
										if (obj54 != null)
										{
											goto IL_1454;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v78+v842 @ X22_v13*4]");
										int num27 = (int)((nint)0 + (nint)num22);
										bool flag21 = Free(num27, num21);
										bool flag22 = !flag21;
										tuple3 = tuple;
										num13 = num21;
										tuple4 = ((float, int))num27;
										if (!flag22)
										{
											object obj55 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v86+E4]");
											bool flag23 = (nint)0 == 0;
											object obj56 = !flag23;
											if (obj56 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj55 = obj33;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v86+A0]");
											object obj57 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X8_v81+10]");
											object obj58 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X8_v81+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v82+18]");
											bool flag24 = (nint)obj45 < 0;
											object obj59 = !flag24;
											if (obj59 != null)
											{
												goto IL_1454;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v82+v842 @ X22_v13*4]");
											num26 = (int)((nint)0 + (nint)num21);
											bool flag25 = Free(num22, num26);
											bool flag26 = !flag25;
											object obj60 = !flag26;
											tuple5 = ((float, int))num22;
											tuple3 = tuple;
											num13 = num26;
											tuple4 = ((float, int))num22;
											if (obj60 != null)
											{
												goto IL_075b;
											}
										}
									}
									goto IL_0d07;
								}
							}
							goto IL_1454;
							IL_075b:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v19+18]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v19+18]");
							bool flag27 = (nint)obj36 < 0;
							object obj62 = !flag27;
							if (obj62 == null)
							{
								bool flag28 = (nint)obj45 < 3;
								object obj63 = !flag28;
								object obj64 = obj45 - 3;
								bool flag29 = obj64 == null;
								object obj65 = cols * num25;
								num23 = num24 + obj65;
								object obj66 = !flag29;
								object obj67 = obj63 & obj66;
								object obj68 = ~obj67;
								double num28;
								if (obj68 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A808]");
									num28 = 0.0;
								}
								else
								{
									num28 = 1.0;
								}
								bool flag30 = num23 < (nint)obj61;
								object obj69 = !flag30;
								if (obj69 == null)
								{
									num17 = (float)num28 * cell;
									num16 = (float)obj39;
									object obj70 = obj16 + num23;
									list2 = (List<Vector3>)(obj70 + 32);
									num18 = (nint)list2;
									num19 = (float)obj39 + num17;
									bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num19) >= System.Runtime.CompilerServices.Unsafe.As<List<Vector3>, UIntPtr>(ref list2);
									tuple3 = tuple;
									num13 = num26;
									tuple4 = tuple5;
									if (flag31)
									{
										goto IL_0d07;
									}
									bool flag32 = (nint)list2 >= 2139095039;
									float num29 = (float)obj39;
									float num30 = 2.139095E+09f;
									if (!flag32)
									{
										Vector2 vector6 = CellMiddle(num24, num25);
										Vector2 vector7 = CellMiddle(num2, num6);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj71 = 0;
										object obj72 = obj71;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X0_v114+E4]");
										bool flag33 = (nint)0 == 0;
										object obj73 = !flag33;
										if (obj73 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num31 = 2.139095E+09f - 2.139095E+09f;
										float num32 = num16 - num16;
										float num33 = num31 * num31;
										num29 = num32 * num32;
										float num34 = num33 + num29;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										num30 = (float)num18 + num34;
										tuple = (num30, num23);
										bool flag34 = sortedSet.Remove(((float, int))0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v19+18]");
										obj61 = 0;
										tuple = ((float, int))0;
									}
									bool flag35 = num23 < (nint)obj61;
									object obj74 = !flag35;
									if (obj74 == null)
									{
										list2 = (List<Vector3>)num19;
										if (obj19 == null)
										{
											break;
										}
										int num35 = num23;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v21+18]");
										bool flag36 = (nint)num35 < (nint)0;
										object obj75 = !flag36;
										if (obj75 == null)
										{
											object obj76 = obj19 + num23;
											Vector2 vector8 = CellMiddle(num24, num25);
											Vector2 vector9 = CellMiddle(num2, num6);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
											object obj77 = 0;
											object obj78 = obj77;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X0_v100+E4]");
											bool flag37 = (nint)0 == 0;
											object obj79 = !flag37;
											if (obj79 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num36 = num30 - num30;
											float num37 = num29 - num29;
											float num38 = num36 * num36;
											num16 = num37 * num37;
											float num39 = num38 + num16;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											num17 = num19 + num39;
											tuple = (num17, num23);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84B8]");
											object obj80 = 0;
											num13 = (int)obj80;
											bool flag38 = sortedSet.Add(((float, int))0);
											tuple3 = ((float, int))0;
											tuple4 = ((float, int))0;
											goto IL_0d07;
										}
									}
								}
							}
							goto IL_1454;
							IL_0d07:
							obj40++;
							bool flag39 = (nint)obj40 != 16;
							tuple = tuple3;
							if (flag39)
							{
								continue;
							}
							goto IL_0d3d;
						}
						goto IL_1462;
						IL_0d3d:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84D0]");
						object obj81 = 0;
						tuple2 = ((float, int))obj81;
						int count2 = sortedSet.Count;
						flag40 = count2 > 0;
						num11 = num16;
						num12 = num17;
						num15 = num14;
						sortedSet2 = sortedSet;
					}
					while (flag40);
				}
				if (obj19 != null)
				{
					int num40 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v21+18]");
					bool flag41 = (nint)num40 < (nint)0;
					object obj82 = !flag41;
					if (obj82 != null)
					{
						goto IL_1454;
					}
					object obj83 = obj19 + num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v31+20]");
					object obj84 = 0 & 0x80000000L;
					if (obj84 != null)
					{
						bool flag42 = num15 != num5;
						result = list;
						if (flag42)
						{
							goto IL_144f;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
					object obj85 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					list3._002Ector();
					int num41 = (int)(num15 & 0x80000000L);
					bool flag43 = num41 == 0;
					object obj86 = !flag43;
					if (obj86 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
						object obj87 = 0;
						while (true)
						{
							num13 = num15 / cols;
							object obj88 = num13 * cols;
							int c = num15 - obj88;
							Vector2 vector10 = CellMiddle(c, num13);
							if ((object)list3 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
							object obj89 = 0;
							object obj90 = obj87;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
							object obj91 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
							nint num42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X8_v53+18]");
							bool flag44 = num42 < 0;
							object obj92 = !flag44;
							if (obj92 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
								nint num43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
								object obj93 = num43 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
								object obj94 = (nint)0 + (nint)1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X9_v20+20]");
								object obj95 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X8_v57+A8]");
								object obj96 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X8_v58+70]");
								list3.AddWithResize((Vector2)0);
							}
							int num44 = num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v21+18]");
							bool flag45 = (nint)num44 < (nint)0;
							object obj97 = !flag45;
							if (obj97 == null)
							{
								object obj98 = obj19 + num15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v56+20]");
								num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v56+20]");
								if (0 == 0)
								{
									continue;
								}
								goto IL_10c5;
							}
							goto IL_1454;
						}
					}
					else if ((object)list3 != null)
					{
						goto IL_10c5;
					}
				}
			}
		}
		goto IL_1462;
		IL_1454:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1462;
		IL_144f:
		return result;
		IL_10c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84A0]");
		object obj99 = 0;
		list3.Reverse();
		(int, int) tuple6 = CellOf((Vector2)obj99);
		bool flag46 = (object)num2 != (object)tuple6;
		float num45 = num20;
		IntPtr intPtr3 = default;
		IntPtr intPtr2 = intPtr3;
		if (!flag46)
		{
			(int, int) tuple7 = CellOf((Vector2)obj99);
			object obj100 = tuple7 >> 32;
			bool flag47 = num6 != (nint)obj100;
			num45 = num20;
			intPtr2 = intPtr3;
			if (!flag47)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84B0]");
				object obj101 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				int num46 = (int)(-1);
				list3.set_Item(num46, (Vector2)obj101);
				num45 = num20;
				intPtr2 = intPtr3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		int num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
		bool flag48 = (nint)0 < (nint)1;
		result = list;
		if (flag48)
		{
			goto IL_144f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69D8]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
		object obj103 = 0;
		int num48 = 0;
		IntPtr intPtr4 = intPtr3;
		float num49 = num9;
		IntPtr intPtr5 = intPtr;
		while (true)
		{
			num47--;
			if (num47 > num48)
			{
				Vector2 vector11 = list3.get_Item(num47);
				bool flag49 = Clear((Vector2)num47, (Vector2)obj102);
				bool flag50 = !flag49;
				intPtr4 = intPtr2;
				num45 = num49;
				intPtr2 = intPtr5;
				if (flag50)
				{
					continue;
				}
				intPtr4 = intPtr5;
				num45 = num49;
				intPtr2 = intPtr5;
			}
			else
			{
				num47 = num48;
			}
			Vector2 vector12 = list3.get_Item(num47);
			Vector3 vector13 = World((Vector2)num47);
			if (list == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj104 = 0;
			object obj105 = obj103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj106 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			if ((nint)0 == 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X9_v14+18]");
			bool flag51 = num50 < 0;
			object obj107 = !flag51;
			if (obj107 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj108 = (nint)0 * (nint)12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj109 = 0 + obj108;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj110 = (nint)0 + (nint)1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v43+20]");
				object obj111 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ X8_v45+A8]");
				object obj112 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v46+70]");
				list.AddWithResize((Vector3)0);
			}
			Vector2 vector14 = list3.get_Item(num47);
			num48 = num47 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			num47 = 0;
			int num51 = num48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v40 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			bool flag52 = (nint)num51 < (nint)0;
			result = list;
			num49 = num45;
			intPtr5 = intPtr2;
			if (flag52)
			{
				continue;
			}
			goto IL_144f;
		}
		goto IL_1462;
		IL_1462:
		return (List<Vector3>)(object)new NullReferenceException();
	}

	public static void Ripple(Vector3 at, float strength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_0032: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWaterSim.Drop((Vector3)0, strength);
	}

	public unsafe void DrawFoam()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d63: Expected Obj, but got I4
		//IL_0d9d: Expected Obj, but got I
		//IL_10b4: Expected Obj, but got I
		//IL_10d6: Expected Obj, but got I4
		//IL_006e: Expected F8, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_00de: Expected VT, but got I4
		//IL_02fb: Expected Obj, but got F8
		//IL_078b: Expected VT, but got I4
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got I
		//IL_0134: Expected I4, but got F8
		//IL_0327: Expected Obj, but got F8
		//IL_0388: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got I
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected VT, but got I4
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Invalid comparison between F8 and I4
		//IL_018a: Expected VT, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got I4
		//IL_01c2: Expected VT, but got I4
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got I4
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got I4
		//IL_0885: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I4
		//IL_1086: Expected Obj, but got I4
		//IL_0806: Expected Obj, but got I
		//IL_0825: Expected F4, but got I
		//IL_0825: Expected I4, but got F8
		//IL_0836: Expected VT, but got F8
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected F8, but got I4
		//IL_0f85: Invalid comparison between F8 and I4
		//IL_0f98: Expected Obj, but got F8
		//IL_0fa5: Expected Obj, but got F8
		//IL_0fda: Expected Obj, but got I4
		//IL_043e: Expected F8, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_026c: Expected Obj, but got F8
		//IL_08a4: Expected Obj, but got I4
		//IL_08b4: Expected Obj, but got Ref
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02c5: Expected VT, but got I4
		//IL_0df1: Invalid comparison between F8 and I4
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected Obj, but got Unknown
		//IL_0e11: Expected Obj, but got F8
		//IL_0e46: Expected Obj, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected I4, but got Unknown
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected Obj, but got Unknown
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected Obj, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_0ef0: Expected Obj, but got I4
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got F8
		//IL_0cc3: Expected Obj, but got I4
		//IL_0ccc: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I4
		//IL_0f2e: Expected Obj, but got I4
		//IL_0f38: Expected VT, but got I4
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected Obj, but got I4
		//IL_0975: Expected VT, but got I4
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected I4, but got Unknown
		//IL_04be: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04f6: Expected Obj, but got I4
		//IL_04ff: Expected Obj, but got I4
		//IL_0509: Expected VT, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I4
		//IL_0580: Expected VT, but got I4
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_05e1: Expected VT, but got I4
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected VT, but got I4
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected I4, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_067e: Expected Obj, but got I4
		//IL_0abb: Expected Obj, but got I
		//IL_0ad3: Expected Obj, but got I
		//IL_0af5: Expected Obj, but got I4
		//IL_0b3b: Expected VT, but got I4
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected I4, but got Unknown
		//IL_0b79: Expected Obj, but got I
		//IL_0bac: Expected Obj, but got I
		//IL_0bd5: Expected VT, but got I4
		//IL_0c00: Expected VT, but got I4
		//IL_0c10: Expected Obj, but got I
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+2C]");
		double num = 0.0 * 8.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10+E4]");
		double num2 = 0.0;
		MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)(this + 128);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)(object)materialPropertyBlock == null;
		bool flag5 = !flag4;
		Vector4 vector = (Vector4)0;
		UnityEngine.Object obj11 = null;
		Texture2D texture2D = (Texture2D)(object)materialPropertyBlock;
		Enumerator<, > val;
		int num3;
		object obj15;
		GillaSplashSpectate.Footprint footprint;
		string text2;
		string text4;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D2 = default;
			texture2D2._002Ector((int)num, 0, (TextureFormat)62, mipChain: false, linear: true);
			string text = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8498]");
			object obj13 = 0;
			text2 = (string)obj13;
			string text3 = (string)obj13 + text;
			flag5 = (object)texture2D2 == null;
			footprint = (GillaSplashSpectate.Footprint)0;
			val = (Enumerator<, >)0;
			object obj14 = 0;
			bool flag6 = true;
			bool flag7 = false;
			TextureFormat textureFormat = (TextureFormat)62;
			vector = (Vector4)0;
			text4 = text;
			num3 = 0;
			texture2D = texture2D2;
			if (flag5)
			{
				goto IL_0c43;
			}
			texture2D2.name = text3;
			texture2D2.filterMode = (FilterMode)1;
			texture2D2.wrapMode = (TextureWrapMode)1;
			texture2D2.hideFlags = (HideFlags)52;
			foamMap = texture2D2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = num * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			obj15 = 0;
			object obj16 = num2 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj17 = this + 136;
			UnityEngine.Object obj18 = default;
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj14 = 0;
			flag6 = true;
			flag7 = false;
			textureFormat = (TextureFormat)62;
			vector = (Vector4)0;
			obj11 = obj18;
			texture2D = texture2D2;
		}
		bool flag8 = 0 < 1;
		num3 = 0;
		text2 = (string)num2;
		if (flag8)
		{
			goto IL_0770;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A914]");
		num3 = 0;
		obj15 = num << 1;
		double num4 = num - 1.0;
		string text6 = default;
		string text5 = text6;
		object obj20 = default;
		object obj19 = obj20;
		string text8 = default;
		string text7 = text8;
		byte[] array2 = default;
		byte[] array = array2;
		object obj22 = default;
		object obj21 = obj22;
		object obj24 = default;
		object obj23 = obj24;
		double num6 = default;
		double num5 = num6;
		double num8 = default;
		double num7 = num8;
		string text10 = default;
		string text9 = text10;
		object obj25 = 1;
		UnityEngine.Object obj26 = obj11;
		string text11 = null;
		while (true)
		{
			object obj49;
			if (!(num < 1.0))
			{
				object obj27 = ~text11;
				object obj28 = (object)text11 - obj27;
				bool flag9 = (nint)obj28 < 0;
				object obj29 = (object)text11 ^ obj27;
				object obj30 = (object)text11 ^ obj28;
				object obj31 = obj29 & obj30;
				bool flag10 = (nint)obj31 < 0;
				bool flag11 = flag9 == flag10;
				object obj32 = !flag11;
				object obj33 = ~obj32;
				if (obj33 == null)
				{
					obj24 = obj25;
					num6 = num4;
					num8 = 0.0;
					text10 = text11;
					text4 = (string)(object)obj26;
				}
				else
				{
					obj24 = obj25;
					num6 = num4;
					num8 = 0.0;
					text10 = (string)obj27;
					text4 = (string)(object)obj26;
				}
				while (true)
				{
					double num9 = num8 - num6;
					bool flag12 = num9 < 0.0;
					object obj34 = num8 ^ num6;
					object obj35 = num8 ^ num9;
					object obj36 = obj34 & obj35;
					bool flag13 = (nint)obj36 < 0;
					bool flag14 = flag12 == flag13;
					object obj37 = !flag14;
					object obj38 = ~obj37;
					double num10 = ((obj38 != null) ? num6 : num8);
					double num11 = num10 - (double)text10;
					bool flag15 = num11 < 0.0;
					object obj39 = num10 ^ text10;
					object obj40 = num10 ^ num11;
					object obj41 = obj39 & obj40;
					bool flag16 = (nint)obj41 < 0;
					bool flag17 = flag15 == flag16;
					object obj42 = !flag17;
					object obj43 = ~obj42;
					string text12 = ((obj43 != null) ? text10 : ((string)num10));
					byte[] array3 = foamBytes;
					text8 = (string)(text12 * num3);
					object obj44 = text8 - 1132396544;
					bool flag18 = (nint)obj44 < 0;
					bool flag19 = obj44 == null;
					object obj45 = text8 ^ 0x437F0000;
					object obj46 = (object)text8 ^ obj44;
					object obj47 = obj45 & obj46;
					bool flag20 = (nint)obj47 < 0;
					bool flag21 = flag18 == flag20;
					obj20 = !flag19;
					object obj48 = flag21 & obj20;
					obj22 = ~obj48;
					if (obj22 == null)
					{
						text8 = (string)1132396544;
					}
					bool flag22 = foamBytes == null;
					text6 = (string)1132396544;
					footprint = (GillaSplashSpectate.Footprint)0;
					val = (Enumerator<, >)0;
					array2 = foamBytes;
					obj49 = obj25;
					text2 = text11;
					if (flag22)
					{
						break;
					}
					text4 = (string)array3.Length;
					object obj50 = obj24 - 1;
					bool flag23 = (nint)obj50 < array3.Length;
					object obj51 = !flag23;
					text6 = (string)1132396544;
					footprint = (GillaSplashSpectate.Footprint)0;
					val = (Enumerator<, >)0;
					array2 = foamBytes;
					obj49 = obj25;
					text2 = text11;
					if (obj51 == null)
					{
						object obj52 = (object)foamBytes + obj50;
						array2 = foamBytes;
						flag5 = foamBytes == null;
						text6 = (string)1132396544;
						footprint = (GillaSplashSpectate.Footprint)0;
						val = (Enumerator<, >)0;
						obj49 = obj25;
						text4 = text8;
						text2 = text11;
						if (flag5)
						{
							break;
						}
						bool flag24 = (nint)obj24 < array2.Length;
						object obj53 = !flag24;
						text6 = (string)1132396544;
						footprint = (GillaSplashSpectate.Footprint)0;
						val = (Enumerator<, >)0;
						obj49 = obj25;
						text4 = text8;
						text2 = text11;
						if (obj53 == null)
						{
							array = (byte[])(object)((object)foamBytes + obj24);
							num7 = num8 + 1.0;
							obj23 = obj24 + 2;
							num5 = num6 - 1.0;
							array[0] = 0;
							bool flag25 = num != num7;
							text5 = (string)1132396544;
							obj19 = obj20;
							text7 = text8;
							obj21 = obj22;
							text9 = text10;
							obj26 = (UnityEngine.Object)(object)text8;
							obj24 = obj23;
							num6 = num5;
							num8 = num7;
							text4 = text8;
							if (flag25)
							{
								continue;
							}
							goto IL_06d4;
						}
					}
					goto IL_0c51;
				}
				break;
			}
			goto IL_06d4;
			IL_06d4:
			text2 = text11 + 1;
			obj49 = obj25 + obj15;
			bool flag26 = text2 != null;
			text6 = text5;
			obj20 = obj19;
			text8 = text7;
			array2 = array;
			obj22 = obj21;
			obj24 = obj23;
			num6 = num5;
			num8 = num7;
			text10 = text9;
			obj11 = obj26;
			obj25 = obj49;
			text11 = text2;
			if (flag26)
			{
				continue;
			}
			goto IL_0770;
		}
		goto IL_0c43;
		IL_0770:
		bool flag27 = feet == null;
		footprint = (GillaSplashSpectate.Footprint)0;
		val = (Enumerator<, >)0;
		text4 = (string)(object)obj11;
		Enumerator<, > val3;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8468]");
			texture2D = (Texture2D)0;
			Enumerator<, > enumerator = feet.GetEnumerator();
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			footprint = (GillaSplashSpectate.Footprint)0;
			Enumerator<, > val4 = default;
			val3 = val4;
			string text13 = default;
			text2 = text13;
			while (val.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X27_v7 (System.Collections.Generic.LowLevelDictionary`2<GillaSplashSpectate+Footprint>+Enumerator<GillaSplashSpectate+Footprint>)+20]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A914]");
				Stamp(ref footprint, (int)num, 0, 0f);
				TextureFormat textureFormat = (TextureFormat)0;
				vector = (Vector4)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A914]");
				val3 = (Enumerator<, >)0;
			}
			string text14 = null;
			val = val4;
			object obj54 = 0;
			Enumerator<, > val5 = (Enumerator<, >)(ref val);
			string text15 = default;
			text8 = text15;
			object obj55 = 9;
			object obj56 = 0;
			object obj59 = default;
			while (true)
			{
				text4 = (string)(object)texture2D;
				val.Dispose();
				bool flag28 = obj56 == null;
				object obj57 = !flag28;
				text15 = text14;
				if (obj57 == null)
				{
					bool flag29 = text14 == null;
					object obj58 = !flag29;
					text15 = text14;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					text2 = text14;
					if (obj58 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)text4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					text15 = (string)1;
					text2 = (string)1;
					obj56 = obj54;
				}
				else
				{
					if ((nint)text4 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E7DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj56 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj54 = obj59;
				}
				text14 = text15;
				obj55 = 0;
			}
			if ((nint)obj55 != 9)
			{
				bool flag30 = obj55 == null;
				object obj60 = !flag30;
				if (obj60 != null)
				{
					return;
				}
			}
			bool flag31 = materialPropertyBlock == null;
			text15 = text14;
			num3 = (int)val3;
			text2 = text14;
			if (!flag31)
			{
				((Texture2D)(object)materialPropertyBlock).LoadRawTextureData(foamBytes);
				bool flag32 = (object)foamMap == null;
				text15 = text14;
				vector = (Vector4)0;
				text4 = (string)(object)foamBytes;
				num3 = (int)val3;
				text2 = text14;
				if (!flag32)
				{
					foamMap.Apply(updateMipmaps: false, makeNoLongerReadable: false);
					object obj61 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v19+E4]");
					bool flag33 = (nint)0 == 0;
					object obj62 = !flag33;
					if (obj62 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(surface != null))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					bool flag34 = (object)surface == null;
					text15 = text14;
					TextureFormat textureFormat = (TextureFormat)0;
					vector = (Vector4)0;
					text4 = null;
					num3 = (int)val3;
					materialPropertyBlock = materialPropertyBlock2;
					if (!flag34)
					{
						surface.GetPropertyBlock(materialPropertyBlock2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
						object obj63 = 0;
						object obj64 = obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v26+E4]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v26+E4]");
						bool flag35 = (nint)0 == 0;
						object obj65 = !flag35;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag36 = materialPropertyBlock2 == null;
						text15 = text14;
						textureFormat = (TextureFormat)0;
						vector = (Vector4)0;
						text4 = (string)(object)materialPropertyBlock2;
						num3 = (int)val3;
						materialPropertyBlock = materialPropertyBlock2;
						if (!flag36)
						{
							object obj66 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v18+A0]");
							object obj67 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v19+18]");
							materialPropertyBlock2.SetTexture(0, foamMap);
							object obj68 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v20+A0]");
							text2 = (string)0;
							Vector4 foamRect = FoamRect;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v23 (System.String)+1C]");
							materialPropertyBlock2.SetVector(0, (Vector4)0);
							bool flag37 = (object)surface == null;
							text15 = text14;
							textureFormat = (TextureFormat)0;
							vector = (Vector4)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v23 (System.String)+1C]");
							text4 = (string)0;
							num3 = (int)val3;
							materialPropertyBlock = materialPropertyBlock2;
							if (!flag37)
							{
								surface.SetPropertyBlock(materialPropertyBlock2);
								return;
							}
						}
					}
				}
			}
		}
		goto IL_0c43;
		IL_0c51:
		val3 = (Enumerator<, >)num3;
		throw new IndexOutOfRangeException();
		IL_0c43:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c51;
	}

	private void Stamp([In] ref GillaSplashSpectate.Footprint f, int w, int h, float scale)
	{
		//IL_066a: Expected Obj, but got I
		//IL_067a: Expected Obj, but got I
		//IL_0697: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I
		//IL_06f5: Expected Obj, but got I4
		//IL_0772: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_07ff: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_0abe: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_082b: Expected Obj, but got I
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_0862: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected Obj, but got Unknown
		//IL_08dd: Expected Obj, but got I4
		//IL_08e6: Expected I4, but got Obj
		//IL_02ca: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_032d: Expected Obj, but got F8
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected I4, but got Unknown
		//IL_0372: Expected Obj, but got F8
		//IL_037b: Expected Obj, but got I4
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_0af6: Expected Obj, but got I4
		//IL_0932: Expected Obj, but got I4
		//IL_09a1: Expected Obj, but got I4
		//IL_09cf: Invalid comparison between F8 and I4
		//IL_04fa: Expected F8, but got I4
		//IL_051a: Expected Obj, but got I4
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_055c: Invalid comparison between F8 and Obj
		//IL_056d: Expected F8, but got Obj
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a4a: Expected F8, but got Obj
		//IL_0a62: Expected F8, but got Obj
		//IL_0583: Expected Obj, but got F8
		//IL_05b6: Expected Obj, but got I4
		//IL_05d0: Invalid comparison between F8 and I4
		//IL_05e1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7BD8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj3 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
		bool flag = (nint)0 < (nint)0;
		object obj4 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj6 = !flag2;
		object obj7 = obj4 & obj6;
		if (obj7 == null)
		{
			object obj9 = default;
			object obj8 = obj9;
		}
		else
		{
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v48+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+8]");
			object obj12 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
			obj = num3 * 0;
			object obj8 = obj12 + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
		object obj16 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj16 + f;
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj21 = w - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+4]");
		object obj22 = 0 - obj16;
		object obj23 = obj21 - obj18;
		bool flag7 = (nint)obj23 < 0;
		object obj24 = obj21 ^ obj18;
		object obj25 = obj21 ^ obj23;
		object obj26 = obj24 & obj25;
		bool flag8 = (nint)obj26 < 0;
		bool flag9 = flag7 == flag8;
		object obj27 = !flag9;
		object obj28 = ~obj27;
		object obj29 = ((obj28 != null) ? obj18 : obj21);
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+4]");
		object obj33 = obj16 + 0;
		object obj34 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
		object obj35 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
		object obj36 = 0 & obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v21+E4]");
		bool flag11 = (nint)0 == 0;
		object obj37 = !flag11;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		object obj38 = h - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+14]");
		object obj39 = 0;
		object obj40 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
		object obj41 = obj40 - 0;
		bool flag12 = (nint)obj41 < 0;
		object obj42 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
		object obj43 = obj42 ^ 0;
		object obj44 = obj38 ^ obj41;
		object obj45 = obj43 & obj44;
		bool flag13 = (nint)obj45 < 0;
		bool flag14 = flag12 == flag13;
		object obj46 = !flag14;
		object obj47 = ~obj46;
		if (obj47 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSplashPool)+28]");
			obj38 = 0;
		}
		object obj48 = obj39 - 255;
		bool flag15 = (nint)obj48 < 0;
		object obj49 = obj39 ^ 0xFF;
		object obj50 = obj39 ^ obj48;
		object obj51 = obj49 & obj50;
		bool flag16 = (nint)obj51 < 0;
		bool flag17 = flag15 == flag16;
		object obj52 = !flag17;
		object obj53 = (((int)(~obj52) != 0) ? ((object)255) : obj39);
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38))
		{
			return;
		}
		object obj54 = f - obj16;
		object obj55 = ~obj53;
		object obj56 = obj53 & obj55;
		object obj57 = obj54 - area;
		double num5 = (double)obj57 * 8.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj58 = ~num5;
		object obj59 = num5 & obj58;
		bool flag18 = (byte)(w * obj36) != 0;
		double num6 = (double)obj59 + (double)(flag18 ? 1 : 0);
		int num7 = w << 1;
		object obj60 = num6 << 1;
		object obj61 = 109891584;
		double num8 = 8.0;
		object obj62 = default;
		double num11 = default;
		object obj71 = default;
		object obj72 = default;
		object obj73 = default;
		do
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj59) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
			{
				double num9 = (double)obj36 + 0.5;
				double num10 = num9 * 0.125;
				obj62 = obj62;
				num11 = num11;
				double num12 = num10;
				object obj63 = obj60;
				object obj64 = obj32;
				object obj65 = obj39;
				object obj66 = obj59;
				double num13 = num8;
				while (true)
				{
					obj34 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v21+E4]");
					bool flag19 = (nint)0 == 0;
					object obj67 = !flag19;
					if (obj67 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
					bool flag20 = (nint)0 < (nint)0;
					object obj68 = !flag20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+C]");
					bool flag21 = (nint)0 == 0;
					double num14 = (double)obj66 + 0.5;
					double num15 = num14 * 0.125;
					double num16 = num15 + (double)area;
					double num17 = num16 - (double)f;
					object obj69 = !flag21;
					object obj70 = obj68 & obj69;
					double num20;
					if (obj70 == null)
					{
						double num18 = num17 * num17;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						double num19 = num18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+8]");
						num20 = num19 - 0.0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						double num21 = num17 * (double)obj71;
						obj64 *= obj72;
						num11 = num21 - (double)obj64;
						double num22 = num21 + (double)obj64;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						double num23 = num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [f @ X1 (Footprint&)+8]");
						double num24 = num23 - 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						num20 = num24 * num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						obj62 = obj73;
					}
					byte[] array = foamBytes;
					if (num20 < 0.0)
					{
						num20 = 0.0;
					}
					if (foamBytes == null)
					{
						goto IL_0645;
					}
					bool flag22 = (nint)obj63 < array.Length;
					object obj74 = !flag22;
					if (obj74 == null)
					{
						object obj75 = (object)foamBytes + obj63;
						num5 = num20 * (double)scale;
						object obj76 = obj75 + 32;
						bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76);
						num6 = (double)obj76;
						if (!flag23)
						{
							obj76 = num5;
							byte[] array2 = foamBytes;
							if (foamBytes == null)
							{
								goto IL_0645;
							}
							obj65 = array2.Length;
							num6 = (double)obj63 + 1.0;
							bool flag24 = num6 < (double)array2.Length;
							object obj77 = !flag24;
							if (obj77 != null)
							{
								goto IL_0653;
							}
							double num25 = (double)foamBytes + num6;
						}
						obj61 = obj66 + 1;
						object obj78 = obj63 + 2;
						bool flag25 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
						obj32 = obj64;
						obj39 = obj65;
						num8 = (double)obj76;
						obj63 = obj78;
						obj66 = obj61;
						num13 = (double)obj76;
						num9 = num5;
						if (!flag25)
						{
							break;
						}
						continue;
					}
					goto IL_0653;
					IL_0653:
					throw new IndexOutOfRangeException();
					IL_0645:
					NullReferenceException ex = new NullReferenceException();
					goto IL_0653;
				}
			}
			obj36++;
			obj60 += num7;
		}
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38));
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
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
		if (foamMap == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj7 = obj;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(foamMap);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(foamMap);
		}
	}

	public GillaSplashPool()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00a7: Expected VT, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78B8]");
		object obj2 = 0;
		cell = 1f;
		depth = 0.65f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 96;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EFA0]");
		murk = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<GillaSplashSpectate.Footprint> list = default;
		list._002Ector();
		object obj5 = this + 120;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaSplashPool()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8500]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8510]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8518]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8520]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8528]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+A0]");
		object obj9 = 0;
		obj9 = list;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+10]");
		_ = 0;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+A0]");
		object obj13 = (nint)0 + (nint)8;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8+10]");
		_ = 0;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9+A0]");
		object obj17 = (nint)0 + (nint)16;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj6);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+A0]");
		object obj20 = 0;
		int num2 = Shader.PropertyToID((string)obj7);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+A0]");
		object obj22 = 0;
	}
}
