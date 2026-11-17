using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class GillaBackpack : NetworkBehaviour, _00210, _0021_00210
{
	[Serializable]
	public struct Air
	{
		public string name;

		public Bounds box;

		public Color fog;

		public float density;

		public Color sky;

		public Color equator;

		public Color ground;
	}

	public GillaItem item;

	public Transform mouth;

	public float depth;

	public float mouthRadius;

	public float overMouth;

	public int holds;

	public GameObject[] shown;

	public float[] slotRoom;

	public float[] slotFit;

	public Vector3 onBack;

	public Vector3 onBackTurn;

	public float shoulderReach;

	public float shoulderDown;

	public float shoulderAhead;

	public int crystalBolts;

	public AudioClip[] wearSounds;

	public AudioClip[] putInSounds;

	public AudioClip[] pourSounds;

	public const int Most = default(int);

	private PlayerRef _Wearer;

	private byte _Held;

	private byte[] _Inside;

	private static readonly (string, string, int)[] Things;

	private static readonly List<GillaBackpack> all;

	private static readonly Dictionary<GillaItem, float> poured;

	private static readonly Dictionary<string, GameObject> prefabs;

	private static readonly Dictionary<int, (Mesh, Material[], float)> looks;

	private const float PourEvery = default(float);

	private const float PourBelow = default(float);

	private const float OpenAbove = default(float);

	private const float LetGoReach = default(float);

	private const float PouredFor = default(float);

	private const float ShownBigger = default(float);

	private bool worn;

	private readonly List<byte> inside;

	private int sellsFor;

	private int[] slotShows;

	private Vector3[] slotHome;

	private Mesh crystalMesh;

	private Material[] crystalMaterials;

	private Vector3 crystalScale;

	private float nextPour;

	private readonly bool[] hinted;

	private readonly HashSet<GillaItem> handedIn;

	private const float PutInBudget = default(float);

	private const float HandInReach = default(float);

	private unsafe PlayerRef Wearer
	{
		get
		{
			//IL_002e: Expected VT, but got I
			//IL_0080: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (PlayerRef)ex2;
			}
			return (PlayerRef)ptr;
		}
		set
		{
			//IL_0027: Expected I, but got VT
			if (Ptr != null)
			{
				int* ptr = (int*)(nint)value;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe byte Held
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+4]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (byte)(int)ex2;
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe NetworkArray<byte> Inside
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 8;
				NetworkArray<byte> networkArray = (NetworkArray<byte>)0;
				IElementReaderWriter<byte> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<byte>(array, 32, readerWriter));
				return networkArray;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkArray<byte>)ex2;
		}
	}

	public static int ThingCount
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I
			//IL_0047: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
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
			object obj5 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private bool Live
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	private bool Yours
	{
		get
		{
			//IL_0031: Expected I4, but got Obj
			//IL_003c: Expected I4, but got Obj
			//IL_0060: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			bool result;
			if (Live)
			{
				result = (byte)(int)((SimulationBehaviour)this)._object != 0;
				if ((int)(~((SimulationBehaviour)this)._object) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v2 (System.Boolean)+58]");
					object obj = (nint)0 & (nint)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						bool result2 = default;
						return result2;
					}
					result = false;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public static IReadOnlyList<GillaBackpack> All
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
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
			return (IReadOnlyList<GillaBackpack>)0;
		}
	}

	public unsafe static bool WornByYou
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_02e4: Expected Obj, but got I4
			//IL_0398: Expected Obj, but got I
			//IL_003d: Expected Obj, but got I
			//IL_004d: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got I4
			//IL_0145: Expected Obj, but got I4
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got I4
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected Ref, but got Unknown
			//IL_0372: Expected Obj, but got I4
			//IL_00a8: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_017d: Expected Obj, but got I4
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			//IL_01b2: Expected Obj, but got I4
			//IL_01bb: Expected Obj, but got I4
			//IL_01c4: Expected Obj, but got I4
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected Obj, but got I4
			//IL_0249: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5180]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5178]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v8+8]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Enumerator<, > val = default;
				bool flag6;
				object obj19 = default;
				bool result2 = default;
				object obj9 = default;
				object obj13;
				object obj14;
				Enumerator<, > val2;
				UnityEngine.Object obj16;
				do
				{
					bool flag2 = val.MoveNext();
					bool flag3 = !flag2;
					object obj8 = obj9;
					if (!flag3)
					{
						object obj10 = obj6;
						UnityEngine.Object obj11 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v32+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag5 = (UnityEngine.Object)null != (UnityEngine.Object)null;
						flag6 = !flag5;
						obj9 = 0;
						continue;
					}
					obj13 = 0;
					obj14 = 0;
					val2 = (Enumerator<, >)(ref val);
					bool result = flag2;
					object obj15 = 0;
					while (true)
					{
						obj16 = (UnityEngine.Object)obj7;
						((Enumerator<, >*)val2)->Dispose();
						bool flag7 = obj15 == null;
						object obj17 = !flag7;
						obj9 = obj8;
						if (obj17 == null)
						{
							bool flag8 = obj13 == null;
							object obj18 = !flag8;
							obj9 = obj8;
							OutOfMemoryException ex = (OutOfMemoryException)val2;
							if (obj18 == null)
							{
								return result;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj16 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj13 = 1;
							obj4 = 1;
							obj15 = obj14;
						}
						else
						{
							if ((nint)obj16 != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj15 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj14 = obj19;
						}
						obj8 = obj9;
						result = false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D398");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result2;
				}
				while (flag6);
				NullReferenceException ex2 = new NullReferenceException();
				obj9 = 0;
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				obj16 = null;
			}
			throw new NullReferenceException();
		}
	}

	public bool OnABack
	{
		get
		{
			//IL_0054: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got VT
			if (~(worn ? 1u : 0u) == 0)
			{
				return true;
			}
			if (Live)
			{
				PlayerRef wearer = Wearer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				object obj4 = wearer - none;
				bool flag2 = obj4 == null;
				return !flag2;
			}
			return false;
		}
	}

	public int Count
	{
		get
		{
			//IL_00b9: Expected Obj, but got I4
			//IL_0095: Expected I4, but got Obj
			bool yours = Yours;
			bool flag = !yours;
			object obj = !flag;
			if (obj == null && Live)
			{
				byte held = Held;
				return held & 0xFF;
			}
			List<byte> list = inside;
			if (inside != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4 (System.Collections.Generic.List`1<System.Byte>)+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private bool Open
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ca: Expected Obj, but got I4
			//IL_00a0: Expected I4, but got Obj
			//IL_00e8: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected Obj, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected Obj, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_01e3: Expected Obj, but got I4
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (mouth != null)
			{
				if ((object)mouth != null)
				{
					Vector3 up = mouth.up;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+18]");
					object obj8 = default;
					object obj7 = obj8 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+1C]");
					object obj10 = default;
					object obj9 = obj10 * 0;
					object obj11 = obj7 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+20]");
					object obj13 = default;
					object obj12 = obj13 * 0;
					object obj14 = obj12 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					object obj15 = obj14 - 0;
					bool flag2 = (nint)obj15 < 0;
					bool flag3 = obj15 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					object obj16 = obj14 ^ 0;
					object obj17 = obj14 ^ obj15;
					object obj18 = obj16 & obj17;
					bool flag4 = (nint)obj18 < 0;
					bool flag5 = flag2 == flag4;
					object obj19 = !flag3;
					return (byte)((flag5 & obj19) ? 1 : 0) != 0;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private unsafe static (string, string, int)[] MakeThings()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0990: Expected Obj, but got I
		//IL_09b2: Expected I4, but got I8
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b6: Expected VT, but got Ref
		//IL_0119: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I8
		//IL_028f: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0391: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got I4
		//IL_040e: Expected I4, but got I8
		//IL_0418: Expected VT, but got I4
		//IL_0abf: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I4
		//IL_0a98: Expected Obj, but got I4
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I4
		//IL_05da: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I4
		//IL_0a41: Expected Obj, but got I
		//IL_0a51: Expected Obj, but got I
		//IL_066c: Expected Obj, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_06b0: Expected Obj, but got I
		//IL_06b0: Expected Obj, but got I
		//IL_06fa: Expected Obj, but got I4
		//IL_0728: Expected Obj, but got I
		//IL_075d: Expected Obj, but got I
		//IL_076d: Expected Obj, but got I
		//IL_0783: Expected Obj, but got I
		//IL_07de: Expected Obj, but got I4
		//IL_0884: Expected Obj, but got I
		//IL_0894: Expected Obj, but got I
		//IL_08a4: Expected Obj, but got I
		//IL_08b1: Expected VT, but got Ref
		//IL_08ca: Expected VT, but got Ref
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_082d: Expected Obj, but got I
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_086f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5120]");
		object item = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5128]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, System.__Canon, int)> list = default;
		list._002Ector();
		System.__Canon _Canon = (System.__Canon)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5158]");
		object obj3 = 0;
		object obj4 = obj3;
		(System.__Canon, System.__Canon, int) tuple = ((System.__Canon)item, (System.__Canon)obj2, -1);
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5140]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+1C]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+18]");
				bool flag = num < 0;
				object obj10 = !flag;
				(System.__Canon, System.__Canon, int) tuple3 = default;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
					object obj11 = (nint)0 * (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
					object obj12 = 0 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
					object obj13 = (nint)0 + (nint)1;
					object obj14 = obj12 + 32;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					(System.__Canon, System.__Canon, int) tuple2 = tuple;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v5+20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v49+A8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v50+70]");
					_Canon = (System.__Canon)0;
					list.AddWithResize(((System.__Canon, System.__Canon, int))(&tuple3));
					tuple3 = tuple;
					(System.__Canon, System.__Canon, int) tuple2 = tuple;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj17 = default;
				if (obj17 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v11+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5168]");
						object obj18 = 0;
						object obj19 = obj17 + 32;
						obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X21_v6-8]");
						object obj20 = 0 & 0xFFFFFFFEL;
						if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj21 = 0;
							object obj22 = obj17 + 40;
							obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X21_v8-10]");
							bool flag2 = (nint)0 < (nint)2;
							object obj23 = !flag2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X21_v8-10]");
							object obj24 = -2;
							bool flag3 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag3;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5170]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5138]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5150]");
								object obj29 = 0;
								object obj30 = obj17 + 48;
								obj30 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj31 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v20+18]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+2]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v20+18]");
								if ((nint)0 < (nint)1)
								{
									goto IL_0936;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5160]");
								object obj34 = 0;
								object obj35 = obj17 + 32;
								object obj36 = 0;
								int num2 = -1;
								(System.__Canon, System.__Canon, int) tuple4 = ((System.__Canon, System.__Canon, int))3;
								object obj38 = default;
								object obj37 = obj38;
								while (true)
								{
									bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
									object obj39 = !flag4;
									if (obj39 != null)
									{
										break;
									}
									object obj40 = obj33;
									object obj41 = obj37 + obj36;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v28+E4]");
									bool flag5 = (nint)0 == 0;
									object obj42 = !flag5;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj40 = obj33;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v28+A0]");
									object obj43 = 0;
									object obj44 = obj43;
									if (obj43 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v23+20]");
										nint num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v25+18]");
										bool flag6 = num3 < 0;
										object obj45 = !flag6;
										if (obj45 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v23+20]");
										object obj46 = (nint)0 * (nint)72;
										object obj47 = obj43 + obj46;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+58]");
										object obj48 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+58]");
										object obj49 = (nint)0 + (nint)32;
										object obj50 = 0;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v28+E4]");
											bool flag7 = (nint)0 == 0;
											object obj51 = !flag7;
											if (obj51 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj40 = obj33;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v28+A0]");
											object obj52 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v29+8]");
											object obj53 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v29+8]");
											if ((nint)0 == 0)
											{
												break;
											}
											object obj54 = obj50;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v30+18]");
											if ((nint)obj54 < 0)
											{
												object obj55 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v11+18]");
												if ((nint)obj55 < 0)
												{
													object obj56 = obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v11+18]");
													bool flag8 = (nint)obj56 < 0;
													object obj57 = !flag8;
													if (obj57 != null)
													{
														goto end_IL_0aa6;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+20]");
													if ((nint)0 == 0)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+20]");
													string text = ((string)0).ToUpperInvariant();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X29_v5+v276 @ X21_v16*8]");
													string item2 = (string)0 + text;
													object obj58 = obj33;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v36+E4]");
													bool flag9 = (nint)0 == 0;
													object obj59 = !flag9;
													if (obj59 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj58 = obj33;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v36+A0]");
													object obj60 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v37+8]");
													object obj61 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v37+8]");
													if ((nint)0 == 0)
													{
														break;
													}
													object obj62 = obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v38+18]");
													bool flag10 = (nint)obj62 < 0;
													object obj63 = !flag10;
													if (obj63 != null)
													{
														goto end_IL_0aa6;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v37+8]");
													object obj64 = 0 + obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+20]");
													nint num4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v39+20]");
													string text2 = (string)obj34 + (string)num4 + (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+58]");
													if ((nint)0 == 0)
													{
														break;
													}
													object obj65 = obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X24_v6+18]");
													bool flag11 = (nint)obj65 < 0;
													object obj66 = !flag11;
													if (obj66 != null)
													{
														goto end_IL_0aa6;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X25_v6+v276 @ X21_v16*4]");
													num2 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5158]");
													object obj67 = 0;
													obj4 = obj67;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X25_v6+v276 @ X21_v16*4]");
													tuple = ((System.__Canon)(object)item2, (System.__Canon)(object)text2, 0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
													object obj68 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5140]");
													object obj69 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+1C]");
													object obj70 = (nint)0 + (nint)1;
													object obj71 = obj69;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
													if ((nint)0 == 0)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
													nint num5 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v43+18]");
													bool flag12 = num5 < 0;
													object obj72 = !flag12;
													if (obj72 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
														object obj73 = (nint)0 * (nint)24;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+10]");
														object obj74 = 0 + obj73;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.__Canon, System.Int32>>)+18]");
														object obj75 = (nint)0 + (nint)1;
														object obj76 = obj74 + 32;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														(System.__Canon, System.__Canon, int) tuple2 = tuple;
														_Canon = (System.__Canon)(object)text2;
														tuple4 = ((System.__Canon, System.__Canon, int))0;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X9_v19+20]");
														object obj77 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v45+A8]");
														object obj78 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v46+70]");
														_Canon = (System.__Canon)0;
														list.AddWithResize(((System.__Canon, System.__Canon, int))(&tuple3));
														tuple3 = tuple;
														(System.__Canon, System.__Canon, int) tuple2 = tuple;
														tuple4 = ((System.__Canon, System.__Canon, int))(&tuple3);
													}
													obj40 = obj33;
													obj50++;
													continue;
												}
											}
											goto IL_08ec;
										}
									}
									goto IL_0949;
									IL_08ec:
									obj36++;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v20+18]");
									obj32 = 0;
									object obj79 = obj36;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v20+18]");
									bool flag13 = (nint)obj79 < 0;
									obj37 = obj38;
									if (flag13)
									{
										continue;
									}
									goto IL_0936;
									continue;
									end_IL_0aa6:
									break;
								}
							}
						}
					}
					goto IL_0957;
				}
			}
		}
		goto IL_0949;
		IL_0936:
		return ((string, string, int)[])(object)list.ToArray();
		IL_0949:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0957;
		IL_0957:
		return ((string, string, int)[])(object)new IndexOutOfRangeException();
	}

	public static string ThingPrefab(int thing)
	{
		//IL_01d3: Expected I4, but got I8
		//IL_01ed: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I
		int num = (int)(thing & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 == null)
			{
				goto IL_01a5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10+18]");
			if ((nint)0 > (nint)thing)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v12+A0]");
					object obj9 = 0;
					obj6 = obj9;
					if (obj9 == null)
					{
						goto IL_01a5;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10+18]");
				bool flag4 = (nint)0 < (nint)thing;
				object obj10 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10+18]");
				object obj11 = -thing;
				bool flag5 = obj11 == null;
				object obj12 = ~obj10;
				object obj13 = obj12 | flag5;
				if (obj13 == null)
				{
					object obj14 = thing * 24;
					object obj15 = obj6 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v11+28]");
					return (string)0;
				}
				goto IL_01b3;
			}
		}
		return null;
		IL_01b3:
		return (string)(object)new IndexOutOfRangeException();
		IL_01a5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01b3;
	}

	public static int ThingOf(GillaItem thing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_005c: Expected I4, but got I8
		//IL_027b: Expected Obj, but got I
		//IL_0233: Expected I4, but got Obj
		//IL_0113: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num;
		if (!(thing == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj4 = 0;
			object obj5 = 32;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			num = 0;
			while (true)
			{
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+A0]");
				object obj10 = 0;
				object obj11 = obj10;
				if (obj10 != null)
				{
					int num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+18]");
					if ((nint)num2 >= (nint)0)
					{
						break;
					}
					if ((object)thing != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+E4]");
						bool flag3 = (nint)0 == 0;
						object obj12 = !flag3;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj13 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v12+A0]");
							object obj14 = 0;
							obj11 = obj14;
							if (obj14 == null)
							{
								goto IL_0217;
							}
						}
						int num3 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+18]");
						bool flag4 = (nint)num3 < (nint)0;
						object obj15 = !flag4;
						if (obj15 != null)
						{
							goto IL_0225;
						}
						string label = thing.label;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+v88 @ X23_v4]");
						bool flag5 = label == (string)0;
						bool flag6 = !flag5;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							num++;
							obj5 += 24;
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+v88 @ X23_v4]");
							obj7 = (UnityEngine.Object)0;
							continue;
						}
						goto IL_02a0;
					}
				}
				goto IL_0217;
				IL_0225:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (int)ex;
				IL_0217:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0225;
			}
		}
		num = -1;
		goto IL_02a0;
		IL_02a0:
		return num;
	}

	public static bool Takes(GillaItem thing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ThingOf(thing);
		int num2 = ~num;
		return (byte)(num2 >> 31) != 0;
	}

	public unsafe static bool WornBy(PlayerRef player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got I4
		//IL_04c8: Expected Obj, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Ref, but got Unknown
		//IL_04f3: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		bool result;
		Enumerator<, > val;
		Enumerator<, > val2 = default;
		object obj14 = default;
		UnityEngine.Object obj8;
		object obj19;
		Enumerator<, > val3;
		Enumerator<, > val4;
		UnityEngine.Object obj10;
		if (none == player)
		{
			result = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+8]");
			bool flag3 = (nint)0 == 0;
			UnityEngine.Object obj9 = default;
			obj8 = obj9;
			val = (Enumerator<, >)0;
			IntPtr intPtr = default;
			obj10 = (UnityEngine.Object)(nint)intPtr;
			if (flag3)
			{
				goto IL_0301;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v6+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5180]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj12 = 0;
			bool flag4;
			object obj13;
			while (true)
			{
				flag4 = val.MoveNext();
				bool flag5 = !flag4;
				obj13 = obj14;
				if (flag5)
				{
					break;
				}
				object obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v37+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = obj9 != null;
				bool flag8 = !flag7;
				obj14 = 0;
				if (flag8)
				{
					continue;
				}
				if ((object)obj9 != null)
				{
					bool live = ((GillaBackpack)obj9).Live;
					bool flag9 = !live;
					obj14 = 0;
					if (!flag9)
					{
						PlayerRef wearer = ((GillaBackpack)obj9).Wearer;
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v46+E4]");
						bool flag10 = (nint)0 == 0;
						object obj18 = !flag10;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = wearer != player;
						obj13 = 0;
						obj14 = 0;
						if (!flag11)
						{
							break;
						}
					}
					continue;
				}
				goto IL_02be;
			}
			obj8 = null;
			obj19 = 0;
			val = val2;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			object obj20 = 0;
			result = flag4;
			bool result2 = default;
			object obj24 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5178]");
				object obj21 = 0;
				obj10 = (UnityEngine.Object)obj21;
				((Enumerator<, >*)val4)->Dispose();
				bool flag12 = obj20 == null;
				object obj22 = !flag12;
				obj14 = obj13;
				if (obj22 == null)
				{
					bool flag13 = (object)obj8 == null;
					object obj23 = !flag13;
					obj14 = obj13;
					OutOfMemoryException ex = (OutOfMemoryException)val4;
					if (obj23 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj10 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj8 = (UnityEngine.Object)1;
					obj20 = obj19;
				}
				else
				{
					if ((nint)obj10 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D398");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj20 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj19 = obj24;
				}
				obj13 = obj14;
				result = false;
			}
		}
		return result;
		IL_0301:
		throw new NullReferenceException();
		IL_02be:
		NullReferenceException ex2 = new NullReferenceException();
		obj14 = 0;
		obj8 = null;
		obj19 = 0;
		val = val2;
		val3 = val2;
		val4 = (Enumerator<, >)(ref val);
		obj10 = null;
		goto IL_0301;
	}

	public int ThingAt(int i)
	{
		//IL_03cd: Expected Obj, but got I4
		//IL_02ea: Expected I4, but got I8
		//IL_0304: Expected Obj, but got I4
		//IL_0396: Expected I4, but got I8
		//IL_03a9: Expected I4, but got Obj
		//IL_003e: Expected I4, but got I8
		//IL_0058: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00cc: Expected I4, but got I8
		//IL_0101: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0140: Expected I4, but got I8
		//IL_0168: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I4, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		bool yours = Yours;
		bool flag = !yours;
		object obj = !flag;
		int result;
		if (obj == null && Live)
		{
			int num = (int)(i & 0x80000000L);
			bool flag2 = num == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				byte held = Held;
				bool flag3 = i < 31;
				object obj3 = !flag3;
				object obj4 = i - 31;
				bool flag4 = obj4 == null;
				object obj5 = !flag4;
				object obj6 = obj3 & obj5;
				result = -1;
				if (obj6 == null)
				{
					int num2 = held & 0xFF;
					bool flag5 = num2 < i;
					object obj7 = !flag5;
					object obj8 = num2 - i;
					bool flag6 = obj8 == null;
					object obj9 = ~obj7;
					object obj10 = obj9 | flag6;
					result = -1;
					if (obj10 == null)
					{
						NetworkArray<byte> networkArray = Inside;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
						object obj13 = default;
						object obj12 = obj13 & 0xFF;
						if (obj12 == null)
						{
							goto IL_0389;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v23+E4]");
						bool flag7 = (nint)0 == 0;
						object obj16 = !flag7;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj15 = obj14;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v23+A0]");
						object obj17 = 0;
						object obj18 = obj17;
						if (obj17 == null)
						{
							goto IL_039b;
						}
						int num3 = obj12 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v16+18]");
						object obj19 = obj12 - 0;
						bool flag8 = (nint)obj19 < 0;
						bool flag9 = obj19 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v16+18]");
						object obj20 = obj12 ^ 0;
						object obj21 = obj12 ^ obj19;
						object obj22 = obj20 & obj21;
						bool flag10 = (nint)obj22 < 0;
						bool flag11 = flag8 == flag10;
						object obj23 = !flag11;
						object obj24 = obj23 | flag9;
						object obj25 = ~obj24;
						result = ((obj25 != null) ? (-1) : num3);
					}
				}
				goto IL_03db;
			}
		}
		else
		{
			int num4 = (int)(i & 0x80000000L);
			bool flag12 = num4 == 0;
			object obj26 = !flag12;
			if (obj26 == null)
			{
				List<byte> list = inside;
				if (inside == null)
				{
					goto IL_039b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v10 (System.Collections.Generic.List`1<System.Byte>)+18]");
				if ((nint)0 > (nint)i)
				{
					byte b = inside.get_Item(i);
					result = b & 0xFF;
					goto IL_03db;
				}
			}
		}
		goto IL_0389;
		IL_03db:
		return result;
		IL_039b:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0389:
		result = -1;
		goto IL_03db;
	}

	public string LabelAt(int i)
	{
		//IL_0109: Expected I4, but got I8
		//IL_0123: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		int num = ThingAt(i);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v7+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+18]");
				bool flag3 = (nint)num < (nint)0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					object obj8 = num * 24;
					object obj9 = obj5 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+20]");
					return (string)0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			return (string)(object)new IndexOutOfRangeException();
		}
		return null;
	}

	private static void Hook()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<System.__Canon, Vector3, Vector3, bool> func = default;
		func._002Ector((object)null, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+A0]");
		object obj8 = 0;
		obj8 = func;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<int, Vector3, System.__Canon> func2 = default;
		func2._002Ector((object)null, (IntPtr)obj5);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v12+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8+10]");
		((Dictionary<System.__Canon, float>)0).Clear();
	}

	private unsafe void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected Obj, but got Unknown
		//IL_0a43: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected I4, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_0bbb: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I4
		//IL_0a81: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_07ea: Expected Obj, but got I
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected Obj, but got Unknown
		//IL_0b07: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I4
		//IL_0848: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected I4, but got Unknown
		//IL_086b: Expected Obj, but got I
		//IL_0873: Expected I, but got Obj
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_090e: Expected Obj, but got I
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_034e: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I8
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_09c5: Expected I, but got Obj
		//IL_08bf: Expected Obj, but got Ref
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I8
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02d8: Expected I4, but got I8
		//IL_095a: Expected I, but got Obj
		//IL_0962: Expected Obj, but got Ref
		//IL_036d: Expected Obj, but got I4
		//IL_0377: Expected I, but got Obj
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_0bfc: Expected Obj, but got I4
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected Obj, but got Unknown
		//IL_0c2f: Expected Obj, but got I4
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected Obj, but got Unknown
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected I4, but got Unknown
		//IL_0c6a: Expected I4, but got Obj
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_03fc: Expected Obj, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected I4, but got Unknown
		//IL_0437: Expected I4, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected Obj, but got Unknown
		//IL_0b5f: Expected Obj, but got I4
		//IL_0b6e: Expected I, but got Obj
		//IL_0b83: Expected I, but got Obj
		//IL_052a: Expected I, but got Obj
		//IL_0551: Expected Obj, but got I4
		//IL_056c: Expected Obj, but got I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected I4, but got Unknown
		//IL_05a7: Expected I4, but got Obj
		//IL_0607: Expected I, but got Obj
		//IL_063f: Expected Obj, but got I
		//IL_0671: Expected I, but got Obj
		//IL_06cb: Expected I, but got Obj
		//IL_0703: Expected Obj, but got I4
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected I4, but got Unknown
		//IL_073e: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		UnityEngine.Object obj4 = (UnityEngine.Object)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj4 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj8 = default;
			item = (GillaItem)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj6 = obj8;
		}
		Vector3[] array = (Vector3[])obj3;
		bool flag4 = obj3 == null;
		Renderer renderer = null;
		MeshFilter meshFilter = null;
		nint num = unchecked((nint)null);
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v7 (UnityEngine.Vector3[])+28]");
			int num2 = 0;
			bool flag5 = holds < 32;
			object obj9 = !flag5;
			object obj10 = holds - 32;
			bool flag6 = (nint)obj10 < 0;
			int num3 = holds ^ 0x20;
			int num4 = holds ^ obj10;
			int num5 = num3 & num4;
			bool flag7 = num5 < 0;
			bool flag8 = flag6 == flag7;
			bool flag9 = !flag8;
			object obj11 = !flag9;
			int num6 = ((obj11 != null) ? 32 : holds);
			GameObject[] array2 = shown;
			int num7 = ~num6;
			int num8 = num6 & num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			array = (Vector3[])0;
			sellsFor = num2;
			holds = num8;
			if (shown != null)
			{
				object obj12 = array2.Length;
			}
			else
			{
				object obj12 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			UnityEngine.Object obj13 = default;
			slotShows = (int[])(object)obj13;
			object obj14 = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int[] array3 = slotShows;
			bool flag10 = slotShows == null;
			renderer = null;
			meshFilter = null;
			num = unchecked((nint)null);
			obj6 = obj13;
			if (!flag10)
			{
				bool flag11 = array3.Length < 1;
				obj9 = !flag11;
				obj10 = array3.Length - 1;
				flag6 = (nint)obj10 < 0;
				num3 = array3.Length ^ 1;
				num4 = array3.Length ^ obj10;
				num5 = num3 & num4;
				flag7 = num5 < 0;
				if (array3.Length >= 1)
				{
					object obj15 = ~array3.Length;
					object obj16 = array3.Length & obj15;
					GameObject[] array4 = (GameObject[])(array3.Length & 0xFFFFFFFFL);
					int[] array5 = (int[])(slotShows + 32);
					bool flag12;
					do
					{
						array2 = (GameObject[])(array4 - 1);
						array5 = (int[])4294967295L;
						array3 = (int[])(array5 + 4);
						flag12 = (nint)obj16 != 1;
						num2 = -1;
					}
					while (flag12);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				UnityEngine.Object obj18 = default;
				slotHome = (Vector3[])(object)obj18;
				object obj19 = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				array = slotHome;
				bool flag13 = slotHome == null;
				renderer = null;
				meshFilter = null;
				num = unchecked((nint)null);
				obj6 = obj18;
				if (!flag13)
				{
					object obj20 = 4;
					UnityEngine.Object obj21 = null;
					nint num9 = unchecked((nint)null);
					UnityEngine.Object obj22 = obj18;
					Vector3[] array6 = slotHome;
					while (true)
					{
						array2 = (GameObject[])array6.Length;
						object obj23 = obj20 - 4;
						GameObject[] array7 = shown;
						bool flag14 = (nint)obj23 < array6.Length;
						obj9 = !flag14;
						obj10 = obj23 - array6.Length;
						flag6 = (nint)obj10 < 0;
						num3 = obj23 ^ array6.Length;
						num4 = obj23 ^ obj10;
						num5 = num3 & num4;
						flag7 = num5 < 0;
						flag9 = (nint)obj23 >= array6.Length;
						renderer = null;
						meshFilter = null;
						object obj24 = obj20;
						obj4 = obj21;
						num = num9;
						obj6 = obj22;
						array = (Vector3[])(object)shown;
						if (flag9)
						{
							break;
						}
						bool flag15 = shown == null;
						renderer = null;
						meshFilter = null;
						obj24 = obj20;
						obj4 = obj21;
						num = num9;
						obj6 = obj22;
						array = (Vector3[])(object)shown;
						if (!flag15)
						{
							bool flag16 = (nint)obj23 < array7.Length;
							obj9 = !flag16;
							obj10 = obj23 - array7.Length;
							flag6 = (nint)obj10 < 0;
							num3 = obj23 ^ array7.Length;
							num4 = obj23 ^ obj10;
							num5 = num3 & num4;
							flag7 = num5 < 0;
							if (obj9 != null)
							{
								goto IL_09ff;
							}
							object obj25 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v45+E4]");
							array2 = (GameObject[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v45+E4]");
							bool flag17 = (nint)0 == 0;
							object obj26 = !flag17;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v23 (UnityEngine.GameObject[])+v113 @ X23_v6*8]");
							bool flag18 = (UnityEngine.Object)0 != null;
							bool flag19 = !flag18;
							obj6 = null;
							if (flag19)
							{
								goto IL_0b1d;
							}
							GameObject[] array8 = shown;
							bool flag20 = shown == null;
							renderer = null;
							meshFilter = null;
							obj24 = obj20;
							obj4 = obj21;
							num = unchecked((nint)null);
							obj6 = null;
							array = (Vector3[])(object)shown;
							if (!flag20)
							{
								array2 = (GameObject[])array8.Length;
								bool flag21 = (nint)obj23 < array8.Length;
								obj9 = !flag21;
								obj10 = obj23 - array8.Length;
								flag6 = (nint)obj10 < 0;
								num3 = obj23 ^ array8.Length;
								num4 = obj23 ^ obj10;
								num5 = num3 & num4;
								flag7 = num5 < 0;
								if (obj9 != null)
								{
									goto IL_09ff;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v26 (UnityEngine.GameObject[])+v113 @ X23_v6*8]");
								bool flag22 = (nint)0 == 0;
								renderer = null;
								meshFilter = null;
								obj24 = obj20;
								obj4 = obj21;
								num = unchecked((nint)null);
								obj6 = null;
								array = (Vector3[])(object)shown;
								if (!flag22)
								{
									Vector3[] array9 = slotHome;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v26 (UnityEngine.GameObject[])+v113 @ X23_v6*8]");
									Transform transform = ((GameObject)0).transform;
									bool flag23 = (object)transform == null;
									renderer = null;
									meshFilter = null;
									obj24 = obj20;
									obj4 = obj21;
									num = unchecked((nint)null);
									obj6 = null;
									array = (Vector3[])(object)shown;
									if (!flag23)
									{
										Vector3 localPosition = transform.localPosition;
										bool flag24 = slotHome == null;
										renderer = null;
										meshFilter = null;
										obj24 = obj20;
										obj4 = obj21;
										num = unchecked((nint)null);
										obj6 = null;
										array = (Vector3[])(object)shown;
										if (!flag24)
										{
											bool flag25 = (nint)obj23 < array9.Length;
											obj9 = !flag25;
											obj10 = obj23 - array9.Length;
											flag6 = (nint)obj10 < 0;
											num3 = obj23 ^ array9.Length;
											num4 = obj23 ^ obj10;
											num5 = num3 & num4;
											flag7 = num5 < 0;
											if (obj9 != null)
											{
												goto IL_09ff;
											}
											object obj27 = (object)slotHome + (object)obj21;
											obj6 = null;
											goto IL_0b1d;
										}
									}
								}
							}
						}
						goto IL_0790;
						IL_09ff:
						throw new IndexOutOfRangeException();
						IL_0b1d:
						array = slotHome;
						obj24 = obj20 + 1;
						obj4 = (UnityEngine.Object)(obj21 + 12);
						bool flag26 = slotHome == null;
						object obj28 = !flag26;
						renderer = null;
						meshFilter = null;
						num = unchecked((nint)null);
						obj20 = obj24;
						obj21 = obj4;
						num9 = unchecked((nint)null);
						obj22 = obj6;
						array6 = slotHome;
						if (obj28 != null)
						{
							continue;
						}
						goto IL_0790;
					}
					goto IL_079e;
				}
			}
		}
		goto IL_0790;
		IL_0beb:
		Show();
		return;
		IL_079e:
		UnityEngine.Object obj29;
		if (array != null && array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v7 (UnityEngine.Vector3[])+20]");
			obj29 = (UnityEngine.Object)0;
		}
		else
		{
			obj29 = null;
		}
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v10+E4]");
		array = (Vector3[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v10+E4]");
		bool flag27 = (nint)0 == 0;
		object obj31 = !flag27;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj29 != null)
		{
			bool flag28 = (object)obj29 == null;
			num = unchecked((nint)null);
			obj6 = null;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E8]");
				array = (Vector3[])0;
				num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
				object obj33 = default;
				object obj32 = obj33 & 1;
				if (obj32 != null)
				{
					bool flag29 = (object)meshFilter == null;
					obj6 = (UnityEngine.Object)(&meshFilter);
					if (flag29)
					{
						goto IL_0790;
					}
					Mesh sharedMesh = meshFilter.sharedMesh;
					crystalMesh = sharedMesh;
					object obj34 = this + 280;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51F0]");
				array = (Vector3[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
				object obj36 = default;
				object obj35 = obj36 & 1;
				if (obj35 != null)
				{
					bool flag30 = (object)renderer == null;
					num = (nint)array;
					obj6 = (UnityEngine.Object)(&renderer);
					if (flag30)
					{
						goto IL_0790;
					}
					Material[] sharedMaterials = renderer.sharedMaterials;
					crystalMaterials = sharedMaterials;
					object obj37 = this + 288;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				Transform transform2 = ((GameObject)obj29).transform;
				bool flag31 = (object)transform2 == null;
				num = (nint)array;
				obj6 = null;
				if (!flag31)
				{
					Vector3 localScale = transform2.localScale;
					Vector3 vector = default;
					crystalScale = vector;
					goto IL_0beb;
				}
			}
			goto IL_0790;
		}
		goto IL_0beb;
		IL_0790:
		NullReferenceException ex = new NullReferenceException();
		goto IL_079e;
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0031: Expected I4, but got I8
		//IL_005d: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01cf: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = (Fusion.SimulationBehaviourRuntimeFlags)((long)((SimulationBehaviour)this).Flags & 0xFFFFFFEFL);
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+8]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5200]");
		object obj5 = 0;
		System.__Canon[] items = list._items;
		object obj6 = obj5;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51F8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj9 = 0;
		bool flag2 = list._size < items.Length;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			object obj11 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj12 = obj11 + 32;
			obj12 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			System.__Canon _Canon = (System.__Canon)(object)this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v5+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+A8]");
			object obj14 = 0;
			list.AddWithResize((System.__Canon)(object)this);
			System.__Canon _Canon = (System.__Canon)(object)this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj8);
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
	}

	private void OnDisable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = ((SimulationBehaviour)this).Flags | (Fusion.SimulationBehaviourRuntimeFlags)0x10;
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5210]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51F8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+8]");
		bool flag2 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj7);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
	}

	public override void Spawned()
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				if (obj3 != null)
				{
					return;
				}
			}
		}
		FromNetwork();
	}

	public void StateAuthorityChanged()
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				if (obj3 != null)
				{
					FromNetwork();
					return;
				}
			}
		}
		if (~(worn ? 1u : 0u) == 0)
		{
			TakenOff();
		}
	}

	private void FromNetwork()
	{
		//IL_001b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0099: Expected I, but got Obj
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected I4, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		List<byte> list = inside;
		bool flag = inside == null;
		List<byte> list2 = (List<byte>)(object)this;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3 (System.Collections.Generic.List`1<System.Byte>)+1C]");
			object obj = (nint)0 + (nint)1;
			_ = 0;
			byte held = Held;
			if ((held & 0xFF) == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
			object obj4 = 0;
			object obj5 = 0;
			nint num = unchecked((nint)null);
			object obj7 = default;
			object obj12 = default;
			while (true)
			{
				NetworkArray<byte> networkArray = Inside;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
				object obj6 = obj7 & 0xFF;
				bool flag2 = obj6 == null;
				nint num2 = num;
				if (!flag2)
				{
					list2 = (List<byte>)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						list2 = (List<byte>)obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+A0]");
					object obj9 = 0;
					object obj10 = obj9;
					bool flag4 = obj9 == null;
					num2 = num;
					object obj11 = obj12;
					if (flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+18]");
					bool flag5 = (nint)obj6 > 0;
					num2 = num;
					if (!flag5)
					{
						list2 = inside;
						bool flag6 = inside == null;
						num2 = num;
						obj11 = obj12;
						if (flag6)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+10]");
						object obj13 = 0;
						obj = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+1C]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+10]");
						bool flag7 = (nint)0 == 0;
						num2 = num;
						obj11 = obj12;
						if (flag7)
						{
							break;
						}
						byte b = (byte)(obj7 - 1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v15+18]");
						bool flag8 = num3 < 0;
						object obj15 = !flag8;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+18]");
							obj = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+10]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v2 (System.Collections.Generic.List`1<System.Byte>)+18]");
							object obj16 = num4 + 0;
							num2 = (int)b;
						}
						else
						{
							inside.AddWithResize(b);
							num2 = (int)b;
						}
					}
				}
				byte held2 = Held;
				bool flag9 = num < 30;
				object obj17 = !flag9;
				object obj18 = num - 30;
				bool flag10 = obj18 == null;
				object obj19 = !flag10;
				object obj20 = obj17 & obj19;
				if (obj20 == null)
				{
					int num5 = held2 & 0xFF;
					num++;
					bool flag11 = num < num5;
					object obj21 = !flag11;
					object obj22 = ~obj21;
					obj5 = obj12;
					if (obj22 == null)
					{
						return;
					}
					continue;
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E48");
	}

	public override void FixedUpdateNetwork()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_02d7: Expected I4, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj4 = default;
		object obj3 = obj4 & 1;
		if (obj3 == null)
		{
			return;
		}
		PlayerRef wearer;
		if (~(worn ? 1u : 0u) == 0)
		{
			wearer = ((SimulationBehaviour)this)._runner.LocalPlayer;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			wearer = PlayerRef.None;
		}
		Wearer = wearer;
		List<byte> list = inside;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
		object obj9 = -32;
		bool flag3 = (nint)obj9 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
		object obj10 = (nint)0 ^ (nint)0x20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
		object obj11 = 0 ^ obj9;
		object obj12 = obj10 & obj11;
		bool flag4 = (nint)obj12 < 0;
		bool flag5 = flag3 == flag4;
		object obj13 = !flag5;
		object obj14 = ~obj13;
		if (obj14 != null)
		{
			obj8 = 32;
		}
		object obj15 = ~obj8;
		byte held = (byte)(obj8 & obj15);
		Held = held;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5220]");
		object obj17 = 0;
		object obj18 = 0;
		int num = 0;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		do
		{
			List<byte> list2 = inside;
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v11 (System.Collections.Generic.List`1<System.Byte>)+18]");
			object obj19;
			if ((nint)num2 < (nint)0)
			{
				byte b = list2.get_Item(num);
				obj19 = b + 1;
				held = (byte)num;
			}
			else
			{
				obj19 = 0;
			}
			NetworkArray<byte> networkArray = Inside;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
			object obj20 = obj21 & 0xFF;
			bool flag6 = obj20 == obj19;
			obj18 = obj22;
			if (!flag6)
			{
				NetworkArray<byte> networkArray2 = Inside;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
				obj18 = obj23;
				held = (byte)num;
			}
			num++;
		}
		while (num != 32);
	}

	private unsafe static bool LetGo(GillaItem thing, Vector3 hand, Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_082c: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected VT, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00b7: Expected VT, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Ref
		//IL_02d5: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Ref
		//IL_084f: Expected Obj, but got I
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected VT, but got Ref
		//IL_030c: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Ref
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got I4
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_08c5: Expected Obj, but got I
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Ref, but got Unknown
		//IL_08f0: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_03a6: Expected VT, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected VT, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_07a2: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_048d: Expected VT, but got I4
		//IL_04ab: Expected Obj, but got I
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected VT, but got I4
		//IL_052e: Expected Obj, but got I4
		//IL_0537: Expected VT, but got I4
		//IL_0567: Expected Obj, but got I4
		//IL_0570: Expected VT, but got I4
		//IL_05ad: Expected VT, but got I4
		//IL_05cd: Expected VT, but got I4
		//IL_05f0: Expected F4, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected VT, but got I4
		//IL_063b: Expected VT, but got I4
		//IL_063b: Expected VT, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got I4
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected VT, but got I4
		//IL_06a6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (thing == null)
		{
			goto IL_004f;
		}
		bool flag2 = (object)thing == null;
		Enumerator<, > val = (Enumerator<, >)0;
		float num = default;
		Enumerator<, > val2 = (Enumerator<, >)num;
		GillaBackpack gillaBackpack = null;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj4 = null;
		bool result;
		UnityEngine.Object obj19 = default;
		float num2 = default;
		object obj21 = default;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5228]");
			object obj5 = 0;
			vector = (Vector3)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj7 = default;
			object obj6 = obj7 & 1;
			if (obj6 != null)
			{
				bool flag3 = (object)gillaBackpack == null;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)num;
				obj4 = (UnityEngine.Object)(&gillaBackpack);
				if (!flag3)
				{
					if (!gillaBackpack.Yours)
					{
						goto IL_004f;
					}
					bool flag4 = (object)gillaBackpack == null;
					val = (Enumerator<, >)0;
					val2 = (Enumerator<, >)num;
					obj4 = (UnityEngine.Object)(&gillaBackpack);
					if (!flag4)
					{
						if (!gillaBackpack.OverYourShoulder((Vector3)(&gillaBackpack)))
						{
							goto IL_004f;
						}
						bool flag5 = (object)gillaBackpack == null;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)num;
						obj4 = (UnityEngine.Object)(&gillaBackpack);
						if (!flag5)
						{
							gillaBackpack.Wear();
							result = true;
							goto IL_083a;
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v34+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Takes(thing) || !thing.Mine)
				{
					goto IL_004f;
				}
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v41+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v41+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+8]");
				bool flag8 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)num;
				obj4 = null;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v19+8]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5180]");
					object obj14 = 0;
					Enumerator<, > val3 = default;
					val2 = val3;
					UnityEngine.Object obj17 = default;
					float num3 = default;
					object obj22 = default;
					bool result2 = default;
					object obj32 = default;
					while (true)
					{
						object obj20;
						Enumerator<, > val4;
						object obj29;
						if (val.MoveNext())
						{
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X0_v47+E4]");
							bool flag9 = (nint)0 == 0;
							object obj16 = !flag9;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag10 = obj17 == null;
							bool flag11 = !flag10;
							object obj18 = !flag11;
							vector = (Vector3)0;
							if (obj18 != null)
							{
								continue;
							}
							bool flag12 = (object)obj17 == null;
							obj19 = null;
							val = val3;
							obj20 = 0;
							val4 = (Enumerator<, >)(ref val);
							num2 = num3;
							obj21 = obj22;
							vector = (Vector3)0;
							obj4 = null;
							if (flag12)
							{
								break;
							}
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v51+E4]");
							bool flag13 = (nint)0 == 0;
							object obj24 = !flag13;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ stack_-78_v8 (UnityEngine.Object)+68]");
							bool flag14 = (UnityEngine.Object)0 == null;
							bool flag15 = !flag14;
							object obj25 = !flag15;
							vector = (Vector3)0;
							if (obj25 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ stack_-78_v8 (UnityEngine.Object)+68]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ stack_-78_v8 (UnityEngine.Object)+68]");
							bool flag16 = (nint)0 == 0;
							obj19 = null;
							val = val3;
							obj20 = 0;
							val4 = (Enumerator<, >)(ref val);
							num2 = num3;
							obj21 = obj22;
							vector = (Vector3)0;
							obj4 = null;
							if (flag16)
							{
								goto IL_0747;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v28+40]");
							bool flag17 = (nint)0 == 0;
							object obj27 = !flag17;
							vector = (Vector3)0;
							if (obj27 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v28+41]");
							bool flag18 = (nint)0 == 0;
							object obj28 = !flag18;
							vector = (Vector3)0;
							if (obj28 != null)
							{
								continue;
							}
							int count = ((GillaBackpack)obj17).Count;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ stack_-78_v8 (UnityEngine.Object)+84]");
							bool flag19 = (nint)count >= (nint)0;
							vector = (Vector3)0;
							if (flag19)
							{
								continue;
							}
							bool flag20 = ((GillaBackpack)obj17).Over((Vector3)0, num);
							bool flag21 = !flag20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
							float num4 = 0f;
							val2 = (Enumerator<, >)num;
							vector = (Vector3)0;
							if (flag21)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							thing.Release((Vector3)0, (Vector3)0);
							((GillaBackpack)obj17).PutIn(thing);
							num4 = num;
							obj19 = null;
							val = val3;
							obj20 = 0;
							val4 = (Enumerator<, >)(ref val);
							num2 = num3;
							obj21 = obj22;
							val2 = (Enumerator<, >)num;
							vector = (Vector3)0;
							result = true;
							obj29 = 0;
							goto IL_08b5;
						}
						obj19 = null;
						val = val3;
						obj20 = 0;
						val4 = (Enumerator<, >)(ref val);
						num2 = num3;
						obj21 = obj22;
						obj29 = 0;
						goto IL_08fe;
						IL_08fe:
						result = false;
						goto IL_08b5;
						IL_08b5:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5178]");
						object obj30 = 0;
						obj4 = (UnityEngine.Object)obj30;
						((Enumerator<, >*)val4)->Dispose();
						bool flag22 = obj29 == null;
						object obj31 = !flag22;
						if (obj31 != null)
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							if ((nint)obj4 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj19 = (UnityEngine.Object)1;
								obj29 = obj20;
							}
							else
							{
								if ((nint)obj4 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D398");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return result2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj29 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj20 = obj32;
							}
							goto IL_08fe;
						}
						goto IL_06e7;
					}
					goto IL_0739;
				}
			}
		}
		goto IL_0713;
		IL_0713:
		NullReferenceException ex2 = new NullReferenceException();
		obj19 = obj19;
		num2 = num2;
		obj21 = obj21;
		goto IL_0739;
		IL_0747:
		throw new NullReferenceException();
		IL_004f:
		result = false;
		goto IL_083a;
		IL_06e7:
		if ((object)obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0713;
		}
		goto IL_083a;
		IL_083a:
		return result;
		IL_0739:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0747;
	}

	private unsafe static GillaItem Reaching(int hand, Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_0540: Expected VT, but got Obj
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Ref, but got Unknown
		//IL_0563: Expected Obj, but got I4
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I4
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0424: Invalid comparison between VT and I4
		//IL_03b0: Expected I, but got Obj
		//IL_03b9: Expected VT, but got I4
		//IL_0484: Invalid comparison between VT and I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_045d: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got I4
		//IL_0186: Expected I, but got Obj
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I
		//IL_0215: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_0258: Expected VT, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I8
		//IL_02a4: Expected I, but got Obj
		//IL_02c0: Expected VT, but got I4
		//IL_02d8: Expected I, but got Obj
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got I
		//IL_0303: Expected I, but got Obj
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18 (UnityEngine.Object)+8]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5180]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5178]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18 (UnityEngine.Object)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			obj4 = obj6;
			GillaItem result2 = default;
			object obj19 = default;
			object obj15;
			Enumerator<, > val4 = default;
			Enumerator<, > val5;
			while (true)
			{
				GillaItem result;
				object obj16;
				Vector3 vector;
				if (val.MoveNext())
				{
					object obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v31+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 != null;
					bool flag5 = !flag4;
					nint num = unchecked((nint)null);
					if (flag5)
					{
						continue;
					}
					if ((object)obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+F0]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+F0]");
						bool flag6 = (nint)0 == 0;
						num = unchecked((nint)null);
						if (flag6)
						{
							continue;
						}
						bool yours = ((GillaBackpack)obj6).Yours;
						bool flag7 = !yours;
						num = unchecked((nint)null);
						if (flag7)
						{
							continue;
						}
						object obj12 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v40+E4]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v40+E4]");
						bool flag8 = (nint)0 == 0;
						object obj13 = !flag8;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+68]");
						bool flag9 = (UnityEngine.Object)0 != null;
						bool flag10 = !flag9;
						num = unchecked((nint)null);
						if (flag10)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+68]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+68]");
						bool flag11 = (nint)0 == 0;
						num = unchecked((nint)null);
						vector = (Vector3)0;
						if (flag11)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18 (UnityEngine.Object)+3C]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v18 (UnityEngine.Object)+3C]");
						object obj14 = 0 & 0x80000000L;
						bool flag12 = obj14 == null;
						num = unchecked((nint)null);
						if (flag12)
						{
							continue;
						}
						bool flag13 = ((GillaBackpack)obj6).OverYourShoulder((Vector3)0);
						bool flag14 = !flag13;
						num = unchecked((nint)null);
						val2 = val4;
						if (flag14)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+68]");
						result = (GillaItem)0;
						num = unchecked((nint)null);
						obj5 = null;
						val = val3;
						obj15 = 0;
						val2 = val4;
						val5 = (Enumerator<, >)(ref val);
						obj16 = 0;
						goto IL_0538;
					}
					NullReferenceException ex = new NullReferenceException();
					num = unchecked((nint)null);
					vector = (Vector3)0;
					break;
				}
				obj5 = null;
				val = val3;
				obj15 = 0;
				val5 = (Enumerator<, >)(ref val);
				obj16 = 0;
				goto IL_0579;
				IL_0538:
				vector = (Vector3)obj9;
				((Enumerator<, >*)val5)->Dispose();
				bool flag15 = obj16 == null;
				object obj17 = !flag15;
				val4 = val2;
				if (obj17 == null)
				{
					bool flag16 = (object)obj5 == null;
					object obj18 = !flag16;
					val4 = val2;
					OutOfMemoryException ex2 = (OutOfMemoryException)val5;
					if (obj18 == null)
					{
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (vector == (Vector3)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj5 = (UnityEngine.Object)1;
					val2 = val4;
					obj4 = (UnityEngine.Object)1;
					obj16 = obj15;
				}
				else
				{
					if (vector != (Vector3)(object)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D398");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj16 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj15 = obj19;
					val2 = val4;
				}
				goto IL_0579;
				IL_0579:
				result = null;
				goto IL_0538;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj5 = null;
			val = val3;
			obj15 = 0;
			val4 = val2;
			val5 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public bool OverYourShoulder(Vector3 hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0604: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_05d1: Expected I4, but got Obj
		//IL_065a: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I
		//IL_07b9: Expected Obj, but got I
		//IL_07eb: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_06f2: Expected Obj, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_092a: Expected Obj, but got I
		//IL_0954: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I4
		//IL_0718: Expected Obj, but got I
		//IL_0732: Expected Obj, but got I
		//IL_075c: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I
		//IL_08c0: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I
		//IL_090c: Expected Obj, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e2: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got F4
		//IL_059b: Expected Obj, but got I4
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Camera main2 = Camera.main;
			if ((object)main2 == null)
			{
				goto IL_05c3;
			}
			Transform transform = main2.transform;
			obj4 = null;
			obj5 = transform;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			if ((object)obj5 == null)
			{
				goto IL_05c3;
			}
			Vector3 forward = ((Transform)obj5).forward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v9+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+18]");
			object obj12 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+1C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+1C]");
			object obj13 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj14 = 0;
			object obj15 = obj14;
			object obj16 = obj12 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+20]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+20]");
			object obj17 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v12+A0]");
			object obj18 = 0;
			object obj19 = obj17 + obj16;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
			object obj21 = default;
			object obj20 = obj21;
			object obj22 = obj21;
			object obj24 = default;
			object obj23 = obj24;
			object obj26 = default;
			object obj25 = obj26;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+18]");
				object obj27 = obj26 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+1C]");
				object obj28 = obj24 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+20]");
				object obj29 = obj21 * 0;
				object obj30 = obj27 + obj28;
				object obj31 = obj29 + obj30;
				object obj32 = obj31 / obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+18]");
				object obj33 = 0 * obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+1C]");
				obj20 = 0 * obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+20]");
				object obj34 = 0 * obj32;
				obj25 = obj26 - obj33;
				obj23 = obj24 - obj20;
				obj22 = obj21 - obj34;
			}
			object obj35 = obj25 * obj25;
			object obj36 = obj23 * obj23;
			object obj37 = obj35 + obj36;
			object obj38 = obj22 * obj22;
			object obj39 = obj37 + obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			bool flag8 = (nint)obj39 >= 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj41 = 0;
			object obj42 = 0;
			if (!flag8)
			{
				Vector3 up = ((Transform)obj5).up;
				object obj43 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v28+A0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+18]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+18]");
				object obj45 = num4 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+1C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+1C]");
				object obj46 = num5 * 0;
				object obj47 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v31+A0]");
				object obj48 = 0;
				object obj49 = obj45 + obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+20]");
				object obj50 = num6 * 0;
				obj40 = obj50 + obj49;
				obj41 = obj48;
				bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
				obj22 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				obj23 = 0;
				obj25 = obj39;
				obj42 = 0;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+18]");
					object obj51 = obj39 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+1C]");
					object obj52 = num7 * 0;
					object obj53 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+20]");
					object obj29 = obj53 * 0;
					object obj54 = obj51 + obj52;
					object obj55 = obj29 + obj54;
					object obj56 = obj55 / obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+18]");
					obj41 = 0 * obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+1C]");
					object obj57 = 0 * obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v29+20]");
					obj40 = 0 * obj56;
					obj25 = obj39 - obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					obj23 = 0 - obj57;
					obj22 = obj20 - obj40;
					obj20 = obj57;
					obj42 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj58 = 0;
			object obj59 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v21+E4]");
			bool flag10 = (nint)0 == 0;
			object obj60 = !flag10;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj61 = obj25 * obj25;
			object obj62 = obj23 * obj23;
			object obj63 = obj61 + obj62;
			object obj64 = obj22 * obj22;
			object obj65 = obj63 + obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			bool flag11 = (nint)obj65 <= 0;
			object obj66 = 0;
			object obj67 = 0;
			object obj68 = 0;
			if (!flag11)
			{
				obj67 = obj25 / obj65;
				obj66 = obj23 / obj65;
				obj68 = obj22 / obj65;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj69 = 0;
			object obj70 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v24+E4]");
			bool flag12 = (nint)0 == 0;
			object obj71 = !flag12;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num8 = Size();
			Vector3 position = ((Transform)obj5).position;
			float num9 = (float)obj26 - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj72 = obj24 - 0;
			object obj73 = obj21 - obj20;
			float num10 = num8 * shoulderReach;
			float num11 = num9 * num9;
			object obj74 = obj72 * obj72;
			float num12 = num11 + (float)obj74;
			object obj75 = obj73 * obj73;
			float num13 = (float)obj75 + num12;
			float num14 = num10 * num10;
			if (num13 < num14)
			{
				float num15 = (float)obj67 * num9;
				object obj76 = obj66 * obj72;
				object obj77 = obj68 * obj73;
				float num16 = num15 + (float)obj76;
				float num17 = (float)obj77 + num16;
				float num18 = num8 * shoulderAhead;
				if (num17 < num18)
				{
					float num19 = shoulderDown * num8;
					object obj78 = 0f - num19;
					object obj79 = obj72 - obj78;
					bool flag13 = (nint)obj79 < 0;
					bool flag14 = obj79 == null;
					object obj80 = obj72 ^ obj78;
					object obj81 = obj72 ^ obj79;
					object obj82 = obj80 & obj81;
					bool flag15 = (nint)obj82 < 0;
					bool flag16 = flag13 == flag15;
					object obj83 = !flag14;
					return (byte)((flag16 & obj83) ? 1 : 0) != 0;
				}
			}
		}
		return false;
		IL_05c3:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsCrystal(GillaItem thing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_00ab: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got I
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
		if (thing != null)
		{
			if ((object)thing != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5120]");
				object obj4 = 0;
				return thing.label == (string)obj4;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	public static Vector3? BackPoint(float down = default(float), float behind = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I4
		//IL_03ea: Expected VT, but got Obj
		//IL_00e1: Expected VT, but got I4
		//IL_0473: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I
		//IL_04eb: Invalid comparison between F4 and I
		//IL_050c: Expected F4, but got I
		//IL_0515: Expected Obj, but got I4
		//IL_076d: Expected Obj, but got I
		//IL_0797: Expected Obj, but got I4
		//IL_0396: Invalid comparison between F4 and I
		//IL_053b: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I4
		//IL_06a2: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I
		//IL_06d7: Expected Obj, but got I
		//IL_0701: Expected Obj, but got I
		//IL_0718: Expected F4, but got Obj
		//IL_0720: Invalid comparison between F4 and Obj
		//IL_073e: Expected F4, but got I
		//IL_074f: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I4
		//IL_059d: Expected Obj, but got I
		//IL_05aa: Expected VT, but got Obj
		//IL_05b3: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Camera main2 = Camera.main;
			if ((object)main2 == null)
			{
				goto IL_03dc;
			}
			Transform transform = main2.transform;
			obj4 = null;
			obj5 = transform;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj5 == null)
		{
			return (Vector3?)(object)0;
		}
		if ((object)obj5 != null)
		{
			Vector3 forward = ((Transform)obj5).forward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+18]");
			object obj11 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+1C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+1C]");
			object obj12 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj13 = 0;
			object obj14 = obj13;
			object obj15 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
			object obj16 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v11+A0]");
			object obj17 = 0;
			object obj18 = obj16 + obj15;
			bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
			float num5 = default;
			float num4 = num5;
			float num6 = behind;
			float num7 = down;
			if (!flag5)
			{
				float num8 = down;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+18]");
				float num9 = num8 * 0f;
				float num10 = behind;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+1C]");
				float num11 = num10 * 0f;
				float num12 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
				float num13 = num12 * 0f;
				float num14 = num9 + num11;
				float num15 = num13 + num14;
				float num16 = num15 / (float)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+18]");
				float num17 = 0f * num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+1C]");
				float num18 = 0f * num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
				float num19 = 0f * num16;
				num7 = down - num17;
				num6 = behind - num18;
				num4 = num5 - num19;
				num5 = num18;
			}
			float num20 = num7 * num7;
			float num21 = num6 * num6;
			float num22 = num20 + num21;
			float num23 = num4 * num4;
			float num24 = num22 + num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			bool flag6 = !(num24 < 0f);
			float num25 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			float num26 = 0f;
			object obj19 = 0;
			if (!flag6)
			{
				Vector3 up = ((Transform)obj5).up;
				object obj20 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v34+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+18]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+18]");
				object obj22 = num27 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+1C]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+1C]");
				object obj23 = num28 * 0;
				object obj24 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v37+A0]");
				object obj25 = 0;
				object obj26 = obj22 + obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+20]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+20]");
				object obj27 = num29 * 0;
				num25 = (float)obj27 + (float)obj26;
				num26 = (float)obj25;
				bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
				num4 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num6 = 0f;
				num7 = num24;
				obj19 = 0;
				if (!flag7)
				{
					float num30 = num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+18]");
					float num31 = num30 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					float num32 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+1C]");
					float num33 = num32 * 0f;
					float num34 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+20]");
					float num13 = num34 * 0f;
					float num35 = num31 + num33;
					float num36 = num13 + num35;
					float num37 = num36 / num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+18]");
					num26 = 0f * num37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+1C]");
					float num38 = 0f * num37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v35+20]");
					num25 = 0f * num37;
					num7 = num24 - num26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					num6 = 0f - num38;
					num4 = num5 - num25;
					num5 = num38;
					obj19 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num39 = num7 * num7;
			float num40 = num6 * num6;
			float num41 = num39 + num40;
			float num42 = num4 * num4;
			float num43 = num41 + num42;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (!(num43 > 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
				object obj31 = 0;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v23+E4]");
				bool flag9 = (nint)0 == 0;
				object obj33 = !flag9;
				if (obj33 != null)
				{
					goto IL_03b7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_03b7;
		}
		goto IL_03dc;
		IL_03b7:
		float num44 = Size();
		Vector3 position = ((Transform)obj5).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj34 = 0;
		Vector3? vector = (Vector3)obj34;
		return (Vector3?)(object)0;
		IL_03dc:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3?)(object)ex;
	}

	private static float Size()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_00b6: Expected F8, but got I
		//IL_00c6: Invalid comparison between F8 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != null;
		bool flag5 = !flag4;
		double num = 1.0;
		if (!flag5)
		{
			Transform transform = ((Component)obj8).transform;
			Vector3 lossyScale = transform.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			double num2 = default;
			if (!(num2 < 0.0))
			{
				bool flag6 = !(num2 > 20.0);
				num = num2;
				if (!flag6)
				{
					num = 20.0;
				}
			}
		}
		return (float)num;
	}

	private static float Sq(float x)
	{
		return x * x;
	}

	public void Wear()
	{
		//IL_002b: Expected I4, but got I8
		//IL_0045: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a5: Expected VT, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_019a: Expected F4, but got I
		//IL_019a: Expected F4, but got I
		//IL_019a: Expected F4, but got Obj
		//IL_019a: Expected VT, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0225: Expected F4, but got I
		//IL_0225: Expected F4, but got I
		//IL_0262: Expected F4, but got I
		//IL_0262: Expected F4, but got I
		if (Yours)
		{
			GillaItem gillaItem = item;
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				GillaHands.Drop(gillaItem);
				gillaItem = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v10+A0]");
			object obj4 = 0;
			Vector3 spin = default;
			gillaItem.Release((Vector3)0, spin);
			GillaItem gillaItem2 = item;
			worn = true;
			gillaItem2.Worn__BackingField = true;
			gillaItem2.Body__BackingField.isKinematic = true;
			Solid(on: false);
			Ride();
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AudioClip[] clips = wearSounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11+4]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v11+8]");
			Sfx.Play(clips, (Vector3)0, (float)obj4, num2, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			InputDevice inputDevice = default;
			bool flag4 = inputDevice.SendHapticImpulse(0u, num3, 0f);
			InputDevice deviceAtXRNode2 = InputDevices.GetDeviceAtXRNode((XRNode)5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			bool flag5 = inputDevice.SendHapticImpulse(0u, num4, 0f);
		}
	}

	private void TakenOff()
	{
		//IL_003f: Expected I4, but got I8
		//IL_0059: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected I4, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		GillaItem gillaItem = item;
		worn = false;
		gillaItem.Worn__BackingField = false;
		int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			return;
		}
		Solid(on: true);
		GillaItem gillaItem2 = item;
		object obj4;
		if (Live)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				object obj2 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj5 = default;
					obj4 = obj5 ^ 1;
					bool flag3 = (object)gillaItem2.Body__BackingField == null;
					object obj6 = !flag3;
					if (obj6 != null)
					{
						goto IL_0165;
					}
					goto IL_01bc;
				}
			}
			bool flag4 = (object)gillaItem2.Body__BackingField == null;
			object obj7 = !flag4;
			obj4 = 1;
			if (obj7 == null)
			{
				goto IL_01bc;
			}
		}
		else
		{
			obj4 = 0;
		}
		goto IL_0165;
		IL_0165:
		bool isKinematic = (byte)(obj4 & 1) != 0;
		gillaItem2.Body__BackingField.isKinematic = isKinematic;
		return;
		IL_01bc:
		throw new NullReferenceException();
	}

	private void Solid(bool on)
	{
		//IL_004a: Expected Obj, but got I8
		//IL_005a: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00ef: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I
		//IL_0120: Expected I, but got Obj
		GillaItem gillaItem = item;
		Collider[] array = gillaItem.Colliders__BackingField;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = array + 32;
		bool flag = on;
		object obj4 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj5 = !flag2;
			if (obj5 != null)
			{
				break;
			}
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X24_v4+v56 @ X22_v5*8]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			nint num = unchecked((nint)null);
			flag = false;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X24_v4+v56 @ X22_v5*8]");
				((Collider)0).enabled = on;
				num = unchecked((nint)null);
				flag = on;
			}
			obj = array.Length;
			obj4++;
			if ((nint)obj4 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void Ride()
	{
		//IL_004c: Expected VT, but got I4
		//IL_004c: Expected VT, but got I4
		//IL_0083: Expected VT, but got Ref
		//IL_0083: Expected VT, but got I4
		if (YourBack(out var _, out var turn, out var _))
		{
			Transform transform = base.transform;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			transform.SetPositionAndRotation((Vector3)0, (Quaternion)(&turn));
		}
	}

	private unsafe bool YourBack(out Vector3 at, out Quaternion turn, out float scale)
	{
		//IL_0010: Expected Obj, but got I
		//IL_087c: Expected Obj, but got I4
		//IL_08a2: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I4
		//IL_0a27: Expected Obj, but got I
		//IL_0a37: Expected Obj, but got I
		//IL_0a59: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I
		//IL_04be: Expected Obj, but got I4
		//IL_04eb: Expected F4, but got I
		//IL_04fb: Expected F4, but got I
		//IL_0518: Expected F4, but got I
		//IL_0518: Expected F4, but got I
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_056f: Expected F4, but got Obj
		//IL_057d: Expected F4, but got VT
		//IL_058d: Expected F4, but got Obj
		//IL_0852: Expected I4, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_05e0: Expected Ref, but got F4
		//IL_061d: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_0923: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_06e1: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_09d5: Expected Obj, but got I
		//IL_09e5: Expected F4, but got I
		//IL_09f5: Expected F4, but got I
		//IL_0a05: Expected F4, but got I
		//IL_09a9: Invalid comparison between F4 and I
		//IL_0b51: Expected Obj, but got I
		//IL_0949: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I8
		//IL_0222: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_0a84: Expected Obj, but got I
		//IL_0aa1: Expected Obj, but got I
		//IL_0ab1: Expected Obj, but got I
		//IL_0ae3: Expected Obj, but got I
		//IL_0af3: Expected Obj, but got I
		//IL_08eb: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got Ref
		//IL_0386: Expected Obj, but got Ref
		//IL_03ad: Expected Obj, but got I4
		//IL_03b5: Expected Obj, but got Ref
		//IL_03f6: Expected Obj, but got I4
		//IL_03fb: Expected I, but got Obj
		//IL_0413: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		ref float reference = ref scale;
		ref Quaternion reference2 = ref *(Quaternion*)null;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_0836;
			}
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v67+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X23_v3 (UnityEngine.Object)+68]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			reference = ref scale;
			reference2 = ref *(Quaternion*)null;
			obj11 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X23_v3 (UnityEngine.Object)+68]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X23_v3 (UnityEngine.Object)+68]");
				if ((nint)0 == 0)
				{
					goto IL_0836;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v51+20]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v51+20]");
				bool flag9 = (nint)0 == 0;
				reference = ref scale;
				reference2 = ref *(Quaternion*)null;
				obj11 = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X24_v9+18]");
					bool flag10 = (nint)0 < (nint)1;
					reference = ref scale;
					reference2 = ref *(Quaternion*)null;
					obj11 = null;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X24_v9+18]");
						object obj16 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5238]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v51+20]");
						object obj18 = (nint)0 + (nint)32;
						IntPtr intPtr = default;
						nint num = intPtr;
						ref float reference3 = ref scale;
						CosmeticWearer cosmeticWearer = null;
						object obj19 = 0;
						ref Quaternion reference4 = ref *(Quaternion*)null;
						UnityEngine.Object obj20 = null;
						object obj25 = default;
						while (true)
						{
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
							object obj21 = !flag11;
							if (obj21 != null)
							{
								break;
							}
							object obj22 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v72+E4]");
							bool flag12 = (nint)0 == 0;
							object obj23 = !flag12;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X28_v6+v224 @ X26_v7*8]");
							bool flag13 = (UnityEngine.Object)0 != null;
							bool flag14 = !flag13;
							reference2 = ref *(Quaternion*)null;
							obj11 = null;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X28_v6+v224 @ X26_v7*8]");
								if ((nint)0 == 0)
								{
									goto IL_0836;
								}
								reference2 = ref *(Quaternion*)obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj24 = obj25 & 1;
								bool flag15 = obj24 == null;
								obj11 = (UnityEngine.Object)(&cosmeticWearer);
								if (!flag15)
								{
									if ((object)cosmeticWearer == null)
									{
										goto IL_0836;
									}
									bool flag16 = (byte)(~(cosmeticWearer.local ? 1u : 0u)) != 0;
									obj11 = (UnityEngine.Object)(&cosmeticWearer);
									if (!flag16)
									{
										bool flag17 = (byte)(~(cosmeticWearer.skinOnly ? 1u : 0u)) != 0;
										object obj26 = !flag17;
										obj11 = (UnityEngine.Object)(&cosmeticWearer);
										if (obj26 == null)
										{
											bool flag18 = cosmeticWearer.BackFrame(out at, out turn, out scale);
											bool flag19 = !flag18;
											object obj27 = !flag19;
											num = unchecked((nint)null);
											reference3 = ref scale;
											reference2 = ref turn;
											obj11 = (UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref at);
											if (obj27 != null)
											{
												return true;
											}
										}
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X24_v9+18]");
							obj16 = 0;
							obj19++;
							object obj28 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X24_v9+18]");
							bool flag20 = (nint)obj28 < 0;
							reference = ref reference3;
							reference4 = ref reference2;
							obj20 = obj11;
							if (flag20)
							{
								continue;
							}
							goto IL_047b;
						}
						goto IL_0844;
					}
				}
			}
		}
		goto IL_047b;
		IL_047b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj29 = 0;
		ref float reference5 = ref *(float*)null;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v18+E4]");
		bool flag21 = (nint)0 == 0;
		object obj31 = !flag21;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num2 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		Vector3? vector = BackPoint(num4, 0f);
		object obj32 = (_003F?)vector & 0xFF;
		bool flag22 = obj32 == null;
		bool result = !flag22;
		float num7 = default;
		if (obj32 != null)
		{
			float num5 = (object)obj11 >> 32;
			float num6 = (_003F?)vector >> 32;
			num7 = num5;
			num3 = (float)obj11;
			num2 = num6;
		}
		else
		{
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				goto IL_0836;
			}
			Vector3 position = transform.position;
			obj11 = null;
		}
		ref Vector3 reference6 = ref *(Vector3*)num2;
		Camera main = Camera.main;
		object obj33 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v18+E4]");
		bool flag23 = (nint)0 == 0;
		object obj34 = !flag23;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = main != null;
		bool flag25 = !flag24;
		UnityEngine.Object obj35 = null;
		UnityEngine.Object obj36 = null;
		if (!flag25)
		{
			Camera main2 = Camera.main;
			if ((object)main2 == null)
			{
				goto IL_0836;
			}
			Transform transform2 = main2.transform;
			obj35 = null;
			obj36 = transform2;
		}
		object obj37 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v27+E4]");
		bool flag26 = (nint)0 == 0;
		object obj38 = !flag26;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag27 = obj36 != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj39 = 0;
		float num11;
		float num12;
		float num13;
		if (flag27)
		{
			if ((object)obj36 == null)
			{
				goto IL_0836;
			}
			Vector3 forward = ((Transform)obj36).forward;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v40+A0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+18]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+18]");
			object obj42 = num8 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+1C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+1C]");
			object obj43 = num9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj44 = 0;
			object obj45 = obj44;
			object obj46 = obj42 + obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+20]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+20]");
			object obj47 = num10 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v45+A0]");
			object obj48 = 0;
			object obj49 = obj47 + obj46;
			bool flag28 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
			num11 = num7;
			num12 = num3;
			num13 = num2;
			if (!flag28)
			{
				float num14 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+18]");
				float num15 = num14 * 0f;
				float num16 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+1C]");
				float num17 = num16 * 0f;
				float num18 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+20]");
				float num19 = num18 * 0f;
				float num20 = num15 + num17;
				float num21 = num19 + num20;
				float num22 = num21 / (float)obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+18]");
				float num23 = 0f * num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+1C]");
				float num24 = 0f * num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v41+20]");
				float num25 = 0f * num22;
				num13 = num2 - num23;
				num12 = num3 - num24;
				num11 = num7 - num25;
				num7 = num24;
			}
		}
		else
		{
			object obj50 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v35+A0]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v36+48]");
			num13 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v36+4C]");
			num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v36+50]");
			num11 = 0f;
		}
		float num26 = num13 * num13;
		float num27 = num12 * num12;
		float num28 = num26 + num27;
		float num29 = num11 * num11;
		float num30 = num28 + num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (!(num30 > 0f))
		{
		}
		object obj52 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v25+A0]");
		object obj53 = 0;
		Vector3 forward2 = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v26+18]");
		ref Quaternion reference7 = ref *(Quaternion*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v26+20]");
		_ = 0;
		return result;
		IL_0836:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0844;
		IL_0844:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe void Glue()
	{
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_02ca: Expected VT, but got I4
		//IL_02ca: Expected VT, but got I4
		//IL_02ec: Expected Obj, but got VT
		//IL_0309: Expected Obj, but got I
		//IL_0337: Expected VT, but got Ref
		//IL_0337: Expected VT, but got I4
		if (!Live)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		PlayerRef wearer = Wearer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		if (wearer != none)
		{
			PlayerRef wearer2 = Wearer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe networkApe = NetworkApe.Find(wearer2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = (UnityEngine.Object)networkApe != (UnityEngine.Object)null;
			bool flag7 = !flag6;
			UnityEngine.Object obj15 = null;
			if (!flag7)
			{
				obj15 = networkApe.wearer;
			}
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = obj15 == null;
			bool flag10 = !flag9;
			object obj18 = !flag10;
			if (obj18 == null && ((CosmeticWearer)obj15).BackFrame(out Vector3 _, out Quaternion turn, out float _))
			{
				Transform transform = base.transform;
				Vector3 vector = (Quaternion)0 * (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj19 = onBackTurn * turn;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBackpack)+B4]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				object obj20 = num * 0;
				Vector3 euler = default;
				Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				transform.SetPositionAndRotation((Vector3)0, (Quaternion)(&turn));
			}
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_02a7: Expected I4, but got I8
		//IL_02c1: Expected Obj, but got I4
		//IL_00b5: Expected I4, but got I8
		//IL_00cf: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_0264: Expected I4, but got I8
		//IL_027e: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected I4, but got Unknown
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
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		if (~(worn ? 1u : 0u) == 0)
		{
			GillaItem gillaItem = item;
			if ((object)item == null)
			{
				goto IL_04fa;
			}
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag4 = num == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				TakenOff();
				if (~(worn ? 1u : 0u) != 0)
				{
					goto IL_0107;
				}
			}
			Ride();
		}
		goto IL_0107;
		IL_0107:
		if (Yours)
		{
			Hint();
		}
		bool onABack = OnABack;
		if (Live)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			bool flag5 = (object)((SimulationBehaviour)this)._object == null;
			UnityEngine.Object obj6 = null;
			if (!flag5)
			{
				object obj7 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag6 = obj7 == null;
				object obj8 = !flag6;
				obj6 = null;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj10 = default;
					object obj9 = obj10 & 1;
					bool flag7 = obj9 == null;
					object obj11 = !flag7;
					obj6 = null;
					if (obj11 != null)
					{
						goto IL_028d;
					}
				}
			}
			GillaItem gillaItem2 = item;
			if ((object)item == null)
			{
				goto IL_04fa;
			}
			int num2 = (int)(gillaItem2.Hand__BackingField & 0x80000000L);
			bool flag8 = num2 == 0;
			object obj12 = !flag8;
			if (obj12 != null)
			{
				Collider[] array = gillaItem2.Colliders__BackingField;
				if (gillaItem2.Colliders__BackingField == null)
				{
					goto IL_04fa;
				}
				if (array.Length != 0)
				{
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v30+E4]");
					bool flag9 = (nint)0 == 0;
					object obj14 = !flag9;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (array[0] != null)
					{
						GillaItem gillaItem3 = item;
						if ((object)item != null)
						{
							Collider[] array2 = gillaItem3.Colliders__BackingField;
							if (gillaItem3.Colliders__BackingField != null && (object)array2[0] != null)
							{
								bool flag10 = array2[0].enabled;
								object obj15 = onABack ^ flag10;
								object obj16 = obj15 & 1;
								bool flag11 = obj16 == null;
								object obj17 = !flag11;
								if (obj17 == null)
								{
									object obj18 = !onABack;
									bool flag12 = (byte)(1 & obj18) != 0;
									Solid(flag12);
								}
								goto IL_028d;
							}
						}
						goto IL_04fa;
					}
				}
			}
		}
		goto IL_028d;
		IL_028d:
		Show();
		int num3 = (int)(sellsFor & 0x80000000L);
		bool flag13 = num3 == 0;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			GillaItem gillaItem4 = item;
			int num4 = ContentsBolts();
			if ((object)item == null)
			{
				goto IL_04fa;
			}
			int coins = num4 + sellsFor;
			gillaItem4.coins = coins;
		}
		TakeThings();
		if (Yours)
		{
			Pour();
		}
		return;
		IL_04fa:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private int ContentsBolts()
	{
		//IL_0016: Expected Obj, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_02de: Expected I4, but got I8
		//IL_02f8: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I
		//IL_021e: Expected I4, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I8
		//IL_0105: Expected Obj, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected I4, but got Unknown
		//IL_013d: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		int count = Count;
		int num2;
		if (count >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj = 0;
			object obj2 = this + 196;
			int num = 0;
			num2 = 0;
			do
			{
				int num3 = ThingAt(num);
				int num4 = (int)(num3 & 0x80000000L);
				bool flag = num4 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v11+A0]");
					object obj6 = 0;
					object obj7 = obj6;
					if (obj6 == null)
					{
						goto IL_0210;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v13+18]");
					bool flag3 = (nint)num3 < (nint)0;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						goto IL_0202;
					}
					object obj9 = num3 * 24;
					object obj10 = obj6 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X9_v7+30]");
					object obj11 = 0 & 0x80000000L;
					bool flag4 = obj11 == null;
					object obj12 = !flag4;
					object obj13 = obj2;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v11+E4]");
						bool flag5 = (nint)0 == 0;
						object obj14 = !flag5;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v15+A0]");
							object obj16 = 0;
							obj7 = obj16;
							if (obj16 == null)
							{
								goto IL_0210;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v13+18]");
						bool flag6 = (nint)num3 < (nint)0;
						object obj17 = !flag6;
						if (obj17 != null)
						{
							goto IL_0202;
						}
						object obj18 = num3 * 24;
						object obj19 = obj7 + obj18;
						obj13 = obj19 + 48;
					}
					num2 = obj13 + num2;
				}
				num++;
				continue;
				IL_0210:
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
				IL_0202:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				goto IL_0210;
			}
			while (count != num);
		}
		else
		{
			num2 = 0;
		}
		return num2;
	}

	private void Hint()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_041a: Expected I, but got Obj
		//IL_0443: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_0266: Expected VT, but got I4
		//IL_02e5: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_0329: Expected I, but got Obj
		//IL_0359: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I4
		//IL_03d4: Expected F4, but got I
		//IL_03d4: Expected F4, but got I
		//IL_03e1: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I4
		//IL_03ef: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj8 = 0;
		object obj9 = obj7 + 56;
		object obj10 = obj7 + 48;
		int num = 0;
		GillaItem gillaItem3 = default;
		InputDevice inputDevice = default;
		while (true)
		{
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = (UnityEngine.Object)obj7 != null;
			bool flag5 = !flag4;
			object obj13 = 0;
			UnityEngine.Object obj14 = null;
			if (flag5)
			{
				goto IL_0412;
			}
			GillaItem gillaItem = item;
			GillaItem gillaItem2;
			object obj15;
			object obj19;
			nint num2;
			bool flag7;
			if ((object)item != null)
			{
				bool flag6 = num == gillaItem.Hand__BackingField;
				gillaItem2 = gillaItem3;
				obj15 = 0;
				if (!flag6)
				{
					flag7 = worn;
					bool flag8 = (byte)(~(worn ? 1u : 0u)) != 0;
					obj13 = 0;
					num2 = unchecked((nint)null);
					if (flag8)
					{
						goto IL_0519;
					}
					GillaItem gillaItem4 = GillaHands.Holding(num);
					object obj16 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v29+E4]");
					bool flag9 = (nint)0 == 0;
					object obj17 = !flag9;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag10 = gillaItem4 == null;
					bool flag11 = !flag10;
					gillaItem2 = gillaItem4;
					obj15 = 0;
					gillaItem3 = gillaItem4;
					obj13 = 0;
					obj14 = null;
					if (flag11)
					{
						goto IL_0412;
					}
				}
				if (num != 0)
				{
					bool flag12 = obj7 == null;
					object obj18 = !flag12;
					obj19 = obj9;
					if (obj18 != null)
					{
						goto IL_0231;
					}
				}
				else
				{
					bool flag13 = obj7 == null;
					obj19 = obj10;
					if (!flag13)
					{
						goto IL_0231;
					}
				}
			}
			goto IL_0494;
			IL_0519:
			bool[] array = hinted;
			if (hinted != null)
			{
				bool flag14 = num < array.Length;
				object obj20 = !flag14;
				if (obj20 != null)
				{
					break;
				}
				object obj21 = hinted + num;
				num++;
				if (num == 2)
				{
					return;
				}
				continue;
			}
			goto IL_0494;
			IL_0494:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0412:
			num2 = (nint)obj14;
			flag7 = false;
			goto IL_0519;
			IL_0231:
			if (obj19 != null)
			{
				Vector3 position = ((Transform)obj19).position;
				bool flag15 = OverYourShoulder((Vector3)0);
				bool flag16 = !flag15;
				gillaItem3 = gillaItem2;
				obj13 = obj15;
				obj14 = null;
				if (flag16)
				{
					goto IL_0412;
				}
				bool[] array2 = hinted;
				if (hinted != null)
				{
					bool flag17 = num < array2.Length;
					object obj22 = !flag17;
					if (obj22 != null)
					{
						break;
					}
					object obj23 = hinted + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v21+20]");
					bool flag18 = (nint)0 == 0;
					object obj24 = !flag18;
					num2 = unchecked((nint)null);
					if (obj24 == null)
					{
						object obj25 = obj8;
						bool flag19 = num == 0;
						object obj26 = !flag19;
						object obj27 = ~obj26;
						XRNode xRNode = ((obj27 != null) ? ((XRNode)4) : ((XRNode)5));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v24+E4]");
						bool flag20 = (nint)0 == 0;
						object obj28 = !flag20;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(xRNode);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
						bool flag21 = inputDevice.SendHapticImpulse(0u, num3, 0f);
						gillaItem2 = (GillaItem)xRNode;
						obj15 = 0;
						num2 = unchecked((nint)null);
					}
					gillaItem3 = gillaItem2;
					obj13 = obj15;
					flag7 = true;
					goto IL_0519;
				}
			}
			goto IL_0494;
		}
		throw new IndexOutOfRangeException();
	}

	private bool Over(Vector3 p, float more)
	{
		//IL_0010: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0312: Expected I4, but got Obj
		//IL_0133: Expected Obj, but got F4
		//IL_013b: Invalid comparison between F4 and Obj
		//IL_01fa: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I4
		//IL_02f1: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = mouth == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			goto IL_017f;
		}
		if ((object)mouth != null)
		{
			Vector3 position = mouth.position;
			if ((object)mouth != null)
			{
				float num = more - more;
				object obj6 = default;
				object obj5 = obj6 - obj6;
				object obj8 = default;
				object obj7 = obj8 - obj8;
				Vector3 up = mouth.up;
				float num2 = num * more;
				object obj9 = obj5 * obj6;
				float num3 = num2 + (float)obj9;
				object obj10 = obj7 * obj8;
				float num4 = (float)obj10 + num3;
				object obj11 = 0f - depth;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					object obj12 = default;
					float num5 = overMouth + (float)obj12;
					if (!(num4 > num5))
					{
						if ((object)mouth != null)
						{
							Vector3 up2 = mouth.up;
							float num6 = num4 * num5;
							float num7 = num4 * (float)obj10;
							float num8 = num4 * depth;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
							object obj13 = 0;
							object obj14 = obj13;
							float num9 = num - num6;
							float num10 = (float)obj5 - num7;
							float num11 = (float)obj7 - num8;
							float num12 = num9 * num9;
							float num13 = num10 * num10;
							float num14 = num12 + num13;
							float num15 = num11 * num11;
							float num16 = num15 + num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v17+E4]");
							bool flag4 = (nint)0 == 0;
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num17 = mouthRadius + (float)obj12;
							float num18 = num17 * num17;
							float num19 = num16 - num18;
							return num19 < 0f;
						}
						goto IL_0304;
					}
				}
				goto IL_017f;
			}
		}
		goto IL_0304;
		IL_0304:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_017f:
		return false;
	}

	private unsafe void TakeThings()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0044: Invalid comparison between F8 and I4
		//IL_0053: Invalid comparison between F8 and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_00d6: Expected F4, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_0165: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I4
		//IL_09b2: Expected Obj, but got I
		//IL_09ca: Expected F4, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I, but got Obj
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_01fb: Expected F4, but got I4
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected I, but got Obj
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected F4, but got Unknown
		//IL_0798: Expected Obj, but got I4
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got I4
		//IL_0ac6: Expected Obj, but got I
		//IL_0ace: Expected I, but got Obj
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected Ref, but got Unknown
		//IL_0af1: Expected Obj, but got I4
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got I4
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected F4, but got Unknown
		//IL_07d2: Expected Obj, but got I4
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I4
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got I4
		//IL_02e7: Expected I4, but got I8
		//IL_0325: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_0a5c: Expected Obj, but got I
		//IL_0a81: Expected Obj, but got I4
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected F4, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9f: Expected I, but got Obj
		//IL_0409: Expected Obj, but got I
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected F4, but got Unknown
		//IL_05bf: Expected Obj, but got I4
		//IL_05fb: Expected VT, but got Ref
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Invalid comparison between Unknown and F8
		//IL_04ae: Expected Obj, but got I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Invalid comparison between Unknown and F8
		//IL_04de: Invalid comparison between F8 and I4
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected I4, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected I4, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected F4, but got Unknown
		//IL_053f: Expected Obj, but got Ref
		//IL_062b: Expected Obj, but got Ref
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got I4
		//IL_06d7: Invalid comparison between F8 and I4
		//IL_06e6: Invalid comparison between F8 and I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected I4, but got Unknown
		//IL_0744: Expected Obj, but got Ref
		//IL_076c: Expected Obj, but got Ref
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		if (!Open)
		{
			return;
		}
		int count = Count;
		bool flag = count < holds;
		object obj = !flag;
		double num = (double)count - (double)holds;
		bool flag2 = num < 0.0;
		bool flag3 = num == 0.0;
		int num2 = count ^ holds;
		int num3 = count ^ num;
		int num4 = num2 & num3;
		bool flag4 = num4 < 0;
		if (count >= holds)
		{
			return;
		}
		GillaItem gillaItem = item;
		bool flag5 = (object)item == null;
		float reach = 0f;
		GillaItem gillaItem3 = default;
		GillaItem gillaItem2 = gillaItem3;
		Enumerator<, > val = (Enumerator<, >)0;
		GillaItem gillaItem4 = (GillaItem)109891584;
		if (!flag5)
		{
			bool flag6 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
			object obj2 = !flag6;
			if (obj2 != null)
			{
				return;
			}
			bool flag7 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
			object obj3 = !flag7;
			if (obj3 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
			gillaItem4 = (GillaItem)0;
			nint num5 = (nint)gillaItem4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v29 (Il2CppClass<GillaItem>)+E4]");
			bool flag8 = (nint)0 == 0;
			object obj4 = !flag8;
			nint num6 = num5;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num6 = (nint)gillaItem4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v30 (Il2CppClass<GillaItem>)+A0]");
			object obj5 = 0;
			bool flag9 = obj5 == null;
			reach = 0f;
			gillaItem2 = gillaItem3;
			val = (Enumerator<, >)0;
			if (!flag9)
			{
				Enumerator<, > enumerator = ((List<System.__Canon>)obj5).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5258]");
				object obj8 = 0;
				reach = 0f;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = val3;
				float num9 = default;
				float num11 = default;
				object obj10 = default;
				object obj12 = default;
				object obj29 = default;
				object obj21;
				Enumerator<, > val4;
				while (true)
				{
					nint num7 = (nint)obj6;
					bool flag10 = val.MoveNext();
					bool flag11 = !flag10;
					float num8 = num9;
					float num10 = num11;
					object obj9 = obj10;
					object obj11 = obj12;
					float num12 = (float)val2;
					GillaItem gillaItem5 = gillaItem4;
					if (!flag11)
					{
						object obj13 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v37+E4]");
						bool flag12 = (nint)0 == 0;
						object obj14 = !flag12;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag13 = Takes(gillaItem3);
						bool flag14 = !flag13;
						gillaItem4 = gillaItem3;
						if (flag14)
						{
							continue;
						}
						if ((object)gillaItem3 == null)
						{
							break;
						}
						bool mine = gillaItem3.Mine;
						bool flag15 = !mine;
						gillaItem4 = gillaItem3;
						if (flag15)
						{
							continue;
						}
						int num13 = (int)(gillaItem3.Hand__BackingField & 0x80000000L);
						bool flag16 = num13 == 0;
						gillaItem4 = gillaItem3;
						if (flag16)
						{
							continue;
						}
						bool flag17 = (byte)(~(gillaItem3.Gone__BackingField ? 1u : 0u)) != 0;
						object obj15 = !flag17;
						gillaItem4 = gillaItem3;
						if (obj15 != null)
						{
							continue;
						}
						bool flag18 = (byte)(~(gillaItem3.Swallowed__BackingField ? 1u : 0u)) != 0;
						object obj16 = !flag18;
						gillaItem4 = gillaItem3;
						if (obj16 != null)
						{
							continue;
						}
						bool flag19 = (byte)(~(gillaItem3.Worn__BackingField ? 1u : 0u)) != 0;
						object obj17 = !flag19;
						gillaItem4 = gillaItem3;
						if (obj17 != null)
						{
							continue;
						}
						object obj18 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v45+E4]");
						bool flag20 = (nint)0 == 0;
						object obj19 = !flag20;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj18 = obj7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v45+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v30+10]");
						bool flag21 = (nint)0 == 0;
						gillaItem2 = null;
						obj21 = 0;
						val = val3;
						num12 = (float)val2;
						val4 = (Enumerator<, >)(ref val);
						num7 = unchecked((nint)null);
						gillaItem4 = gillaItem3;
						if (flag21)
						{
							goto IL_087f;
						}
						obj12 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v30+10]");
						bool flag22 = ((Dictionary<System.__Canon, float>)0).TryGetValue((System.__Canon)(object)gillaItem3, out var value);
						bool flag23 = !flag22;
						num10 = num11;
						num12 = (float)val2;
						bool flag24 = flag4;
						int num14 = num4;
						int num15 = num3;
						int num16 = num2;
						bool flag25 = flag3;
						bool flag26 = flag2;
						double num17 = num;
						object obj22 = obj;
						if (!flag23)
						{
							float time = Time.time;
							val2 = (Enumerator<, >)(time - value);
							bool flag27 = (double)val2 < 1.0;
							obj22 = !flag27;
							num17 = (double)val2 - 1.0;
							flag26 = (double)val2 < 1.0;
							flag25 = num17 == 0.0;
							num16 = val2 ^ 1.0;
							num15 = val2 ^ num17;
							num14 = num16 & num15;
							flag24 = num14 < 0;
							num10 = value;
							num12 = (float)val2;
							num11 = value;
							obj10 = (object)(&value);
							flag4 = flag24;
							num4 = num14;
							num3 = num15;
							num2 = num16;
							flag3 = flag25;
							flag2 = flag26;
							num = num17;
							obj = obj22;
							gillaItem4 = gillaItem3;
							if (flag26)
							{
								continue;
							}
						}
						object obj23 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v49+E4]");
						bool flag28 = (nint)0 == 0;
						object obj24 = !flag28;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector = Middle(gillaItem3, out reach);
						bool flag29 = InMouth((Vector3)(&reach), num12);
						bool flag30 = !flag29;
						num9 = reach;
						num11 = num10;
						obj10 = (object)(&value);
						val2 = (Enumerator<, >)num12;
						flag4 = flag24;
						num4 = num14;
						num3 = num15;
						num2 = num16;
						flag3 = flag25;
						flag2 = flag26;
						num = num17;
						obj = obj22;
						gillaItem4 = gillaItem3;
						if (flag30)
						{
							continue;
						}
						PutIn(gillaItem3);
						int count2 = Count;
						bool flag31 = count2 < holds;
						obj = !flag31;
						num = (double)count2 - (double)holds;
						flag2 = num < 0.0;
						flag3 = num == 0.0;
						num2 = count2 ^ holds;
						num3 = count2 ^ num;
						num4 = num2 & num3;
						flag4 = num4 < 0;
						bool flag32 = count2 < holds;
						num8 = reach;
						obj9 = (object)(&value);
						obj11 = obj12;
						gillaItem5 = gillaItem3;
						num9 = reach;
						num11 = num10;
						obj10 = (object)(&value);
						val2 = (Enumerator<, >)num12;
						gillaItem4 = gillaItem3;
						if (flag32)
						{
							continue;
						}
					}
					gillaItem2 = null;
					obj21 = 0;
					val = val3;
					val4 = (Enumerator<, >)(ref val);
					object obj25 = 0;
					goto IL_0ab6;
					IL_0ab6:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
					object obj26 = 0;
					num7 = (nint)obj26;
					((Enumerator<, >*)val4)->Dispose();
					bool flag33 = obj25 == null;
					object obj27 = !flag33;
					num9 = num8;
					num11 = num10;
					obj10 = obj9;
					obj12 = obj11;
					val2 = (Enumerator<, >)num12;
					gillaItem4 = gillaItem5;
					if (obj27 == null)
					{
						bool flag34 = (object)gillaItem2 == null;
						object obj28 = !flag34;
						num9 = num8;
						num11 = num10;
						obj10 = obj9;
						obj12 = obj11;
						val2 = (Enumerator<, >)num12;
						OutOfMemoryException ex = (OutOfMemoryException)val4;
						gillaItem4 = gillaItem5;
						if (obj28 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					num12 = (float)val2;
					goto IL_087f;
					IL_087f:
					NullReferenceException ex2 = new NullReferenceException();
					if (num7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num8 = num9;
						num10 = num11;
						obj9 = obj10;
						obj11 = obj12;
						gillaItem2 = (GillaItem)1;
						obj25 = obj21;
						gillaItem5 = gillaItem4;
					}
					else
					{
						if (num7 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj25 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num8 = num9;
						num10 = num11;
						obj9 = obj10;
						obj11 = obj12;
						obj21 = obj29;
						gillaItem5 = gillaItem4;
					}
					goto IL_0ab6;
				}
				NullReferenceException ex3 = new NullReferenceException();
				gillaItem2 = null;
				obj21 = 0;
				val = val3;
				val4 = (Enumerator<, >)(ref val);
				gillaItem4 = gillaItem3;
			}
		}
		throw new NullReferenceException();
	}

	private bool InMouth(Vector3 p, float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_033f: Expected I4, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got F4
		//IL_016e: Invalid comparison between F4 and Obj
		//IL_01a9: Invalid comparison between F4 and I4
		//IL_01ba: Expected Obj, but got I4
		//IL_01c3: Invalid comparison between F4 and I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_03e6: Invalid comparison between F4 and I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02c0: Invalid comparison between F4 and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = mouth == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)mouth != null)
			{
				Vector3 position = mouth.position;
				if ((object)mouth != null)
				{
					Vector3 up = mouth.up;
					if ((object)mouth != null)
					{
						float num = reach - reach;
						object obj6 = default;
						object obj5 = obj6 - obj6;
						object obj8 = default;
						object obj7 = obj8 - obj8;
						float num2 = num * reach;
						object obj9 = obj5 * obj6;
						object obj10 = obj7 * obj8;
						float num3 = num2 + (float)obj9;
						Vector3 up2 = mouth.up;
						float num4 = (float)obj10 + num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v18+E4]");
						bool flag4 = (nint)0 == 0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj14 = 0f - depth;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
						{
							float num5 = num4 * num2;
							float num6 = num4 * (float)obj9;
							bool flag5 = num4 < 0f;
							object obj15 = !flag5;
							bool flag6 = num4 == 0f;
							float num7 = num4 * (float)obj8;
							float num8 = num - num5;
							float num9 = (float)obj5 - num6;
							float num10 = (float)obj7 - num7;
							float num11 = num8 * num8;
							float num12 = num9 * num9;
							float num13 = num11 + num12;
							float num14 = num10 * num10;
							float num15 = num14 + num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							object obj16 = ~obj15;
							object obj17 = obj16 | flag6;
							double num19;
							if (obj17 == null)
							{
								object obj18 = default;
								float num16 = overMouth + (float)obj18;
								bool flag7 = num4 < num16;
								object obj19 = !flag7;
								float num17 = num4 - num16;
								bool flag8 = num17 == 0f;
								object obj20 = ~obj19;
								object obj21 = obj20 | flag8;
								if (obj21 == null)
								{
									goto IL_02ea;
								}
								double num18 = (double)obj18 * 0.5;
								num19 = num18 + (double)mouthRadius;
							}
							else
							{
								num19 = mouthRadius;
							}
							float num20 = num15 - (float)num19;
							return num20 < 0f;
						}
						goto IL_02ea;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_02ea;
		IL_02ea:
		return false;
	}

	private unsafe static Vector3 Middle(GillaItem thing, out float reach)
	{
		//IL_046d: Expected VT, but got Obj
		//IL_0067: Expected Obj, but got I8
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I
		//IL_009b: Expected F8, but got I4
		//IL_00a4: Expected F8, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00bf: Expected F8, but got I4
		//IL_00c8: Expected F8, but got I4
		//IL_00d1: Expected F8, but got I4
		//IL_084d: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_015a: Expected VT, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_01be: Expected VT, but got I4
		//IL_0366: Invalid comparison between F8 and I4
		//IL_0375: Invalid comparison between F8 and I4
		//IL_0388: Expected Obj, but got F8
		//IL_0395: Expected Obj, but got F8
		//IL_03ca: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_0795: Invalid comparison between F8 and I4
		//IL_07a4: Invalid comparison between F8 and I4
		//IL_07b7: Expected Obj, but got F8
		//IL_07c4: Expected Obj, but got F8
		//IL_07f9: Expected Obj, but got I4
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I
		//IL_082f: Expected Ref, but got F8
		//IL_0869: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_04e1: Invalid comparison between F8 and I4
		//IL_04f0: Invalid comparison between F8 and I4
		//IL_0503: Expected Obj, but got F8
		//IL_0510: Expected Obj, but got F8
		//IL_0545: Expected Obj, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_0664: Invalid comparison between F8 and I4
		//IL_0673: Invalid comparison between F8 and I4
		//IL_0686: Expected Obj, but got F8
		//IL_0693: Expected Obj, but got F8
		//IL_06c8: Expected Obj, but got I4
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		ref float reference = ref *(float*)null;
		double num;
		object obj4;
		double num3;
		Vector3 result;
		if ((object)thing != null)
		{
			Collider[] array = thing.Colliders__BackingField;
			if (thing.Colliders__BackingField == null || array.Length < 1)
			{
				goto IL_0415;
			}
			object obj = array.Length & 0xFFFFFFFFL;
			object obj2 = thing.Colliders__BackingField + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			ref float reference2 = ref reach;
			num = 0.0;
			double num2 = 0.0;
			obj4 = 0;
			object obj5 = 0;
			num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			double num9 = default;
			double num10 = default;
			double num14 = default;
			double num15 = default;
			object obj17 = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj6 = !flag;
				if (obj6 == null)
				{
					object obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+v125 @ X23_v6*8]");
					bool flag3 = (UnityEngine.Object)0 == null;
					bool flag4 = !flag3;
					object obj9 = !flag4;
					reference2 = ref *(float*)null;
					result = (Vector3)flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+v125 @ X23_v6*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+v125 @ X23_v6*8]");
						bool flag5 = ((Collider)0).enabled;
						bool flag6 = !flag5;
						reference2 = ref *(float*)null;
						result = (Vector3)flag5;
						if (!flag6)
						{
							object obj10 = obj4 & 1;
							if (obj10 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+v125 @ X23_v6*8]");
								Bounds bounds = ((Collider)0).bounds;
								double num6 = num4 - num3;
								double num7 = num3 + num4;
								double num8 = num9 - num10;
								double num11 = num9 + num10;
								double num12 = num2 - num;
								double num13 = num14 + num15;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num6 < num8))
								{
									num6 = num8;
								}
								double num16 = num7 - num8;
								bool flag7 = num16 < 0.0;
								bool flag8 = num16 == 0.0;
								object obj11 = num7 ^ num8;
								object obj12 = num7 ^ num16;
								object obj13 = obj11 & obj12;
								bool flag9 = (nint)obj13 < 0;
								bool flag10 = flag7 == flag9;
								object obj14 = !flag8;
								object obj15 = flag10 & obj14;
								object obj16 = ~obj15;
								if (obj16 == null)
								{
									num8 = num7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								double num17 = num8 - num6;
								double num18 = (double)obj17 - num12;
								double num19 = num17 * 0.5;
								double num20 = num18 * 63.0;
								double num21 = num6 + num19;
								double num22 = num12 + num20;
								double num23 = num21 - num19;
								double num24 = num19 + num21;
								double num25 = num22 - num20;
								double num26 = num20 + num22;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num23 < num11))
								{
									num23 = num11;
								}
								double num27 = num24 - num11;
								bool flag11 = num27 < 0.0;
								bool flag12 = num27 == 0.0;
								object obj18 = num24 ^ num11;
								object obj19 = num24 ^ num27;
								object obj20 = obj18 & obj19;
								bool flag13 = (nint)obj20 < 0;
								bool flag14 = flag11 == flag13;
								object obj21 = !flag12;
								object obj22 = flag14 & obj21;
								object obj23 = ~obj22;
								if (obj23 == null)
								{
									num11 = num24;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								double num28 = num11 - num23;
								double num29 = num20 - num21;
								num3 = num28 * 0.5;
								double num30 = num29 * 63.0;
								num4 = num23 + num3;
								num5 = num21 + num30;
								num = num30;
								num2 = num5;
								result = (Vector3)bounds;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+v125 @ X23_v6*8]");
								Bounds bounds2 = ((Collider)0).bounds;
								num = num15;
								num2 = num14;
								num3 = num10;
								num4 = num9;
								num5 = num15;
								result = (Vector3)bounds2;
							}
							reference2 = ref *(float*)null;
							obj4 = 1;
						}
					}
					obj = array.Length;
					obj5++;
					if ((nint)obj5 < array.Length)
					{
						continue;
					}
					goto IL_0323;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
			}
		}
		goto IL_045f;
		IL_0415:
		Transform transform = thing.transform;
		if ((object)transform == null)
		{
			goto IL_045f;
		}
		result = transform.position;
		goto IL_086e;
		IL_086e:
		return result;
		IL_0323:
		object obj24 = obj4 & 1;
		if (obj24 == null)
		{
			goto IL_0415;
		}
		double num32 = default;
		double num31 = num32 - num3;
		bool flag15 = num31 < 0.0;
		bool flag16 = num31 == 0.0;
		object obj25 = num32 ^ num3;
		object obj26 = num32 ^ num31;
		object obj27 = obj25 & obj26;
		bool flag17 = (nint)obj27 < 0;
		bool flag18 = flag15 == flag17;
		object obj28 = !flag16;
		object obj29 = flag18 & obj28;
		object obj30 = ~obj29;
		double num33 = ((obj30 != null) ? num3 : num32);
		double num34 = num - num33;
		bool flag19 = num34 < 0.0;
		bool flag20 = num34 == 0.0;
		object obj31 = num ^ num33;
		object obj32 = num ^ num34;
		object obj33 = obj31 & obj32;
		bool flag21 = (nint)obj33 < 0;
		bool flag22 = flag19 == flag21;
		object obj34 = !flag20;
		object obj35 = flag22 & obj34;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			num33 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		reference = ref *(float*)num33;
		goto IL_086e;
		IL_045f:
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
	}

	private unsafe void PutIn(GillaItem thing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_054d: Expected Obj, but got I4
		//IL_0043: Expected I4, but got I8
		//IL_005d: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_011f: Expected VT, but got I4
		//IL_02ed: Expected VT, but got Ref
		//IL_02f5: Expected VT, but got Ref
		//IL_014a: Expected Obj, but got I8
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Expected VT, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0574: Expected Obj, but got I4
		//IL_0500: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_01f2: Expected VT, but got I4
		//IL_0420: Expected VT, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0498: Expected F4, but got I
		//IL_04d2: Expected F4, but got I
		//IL_0244: Expected Obj, but got I
		//IL_024d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ThingOf(thing);
		int num2 = (int)(num & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		object obj5;
		if ((object)thing != null)
		{
			thing.Recycle();
			if ((object)thing.Body__BackingField != null)
			{
				thing.Body__BackingField.isKinematic = true;
				Collider[] array = thing.Colliders__BackingField;
				if (thing.Colliders__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					obj5 = 0;
					bool flag3 = array.Length < 1;
					RpcInfo rpcInfo = (RpcInfo)0;
					bool flag4 = true;
					if (flag3)
					{
						goto IL_02a1;
					}
					object obj6 = array.Length & 0xFFFFFFFFL;
					object obj7 = thing.Colliders__BackingField + 32;
					object obj8 = 0;
					RpcInfo rpcInfo2 = (RpcInfo)0;
					bool flag5 = true;
					while (true)
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj9 = !flag6;
						if (obj9 != null)
						{
							break;
						}
						object obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v45+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X26_v6+v182 @ X25_v7*8]");
						bool flag8 = (UnityEngine.Object)0 != null;
						bool flag9 = !flag8;
						rpcInfo = (RpcInfo)0;
						flag4 = false;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X26_v6+v182 @ X25_v7*8]");
							if ((nint)0 == 0)
							{
								goto IL_050e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X26_v6+v182 @ X25_v7*8]");
							((Collider)0).enabled = false;
							rpcInfo = (RpcInfo)0;
							flag4 = false;
						}
						obj6 = array.Length;
						obj8++;
						bool flag10 = (nint)obj8 < array.Length;
						rpcInfo2 = rpcInfo;
						flag5 = flag4;
						if (flag10)
						{
							continue;
						}
						goto IL_02a1;
					}
					goto IL_051c;
				}
			}
		}
		goto IL_050e;
		IL_050e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_051c;
		IL_039f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj12 = 0;
		Transform transform;
		Vector3 position = transform.position;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v25+E4]");
		bool flag11 = (nint)0 == 0;
		object obj14 = !flag11;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float pitchMin = default;
		float pitchMax = default;
		Sfx.Play(putInSounds, (Vector3)0, 0f, pitchMin, pitchMax);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v28+E4]");
		bool flag12 = (nint)0 == 0;
		object obj16 = !flag12;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		InputDevice inputDevice = default;
		bool flag13 = inputDevice.SendHapticImpulse(0u, 0.25f, 0f);
		InputDevice deviceAtXRNode2 = InputDevices.GetDeviceAtXRNode((XRNode)5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		bool flag14 = inputDevice.SendHapticImpulse(0u, 0.25f, 0f);
		return;
		IL_02a1:
		if (Yours)
		{
			Added(num);
			byte b = (byte)num;
		}
		else
		{
			object obj17 = default;
			RPC_PutIn((byte)num, (RpcInfo)(&obj17));
			RpcInfo rpcInfo = (RpcInfo)(&obj17);
			byte b = (byte)num;
		}
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v17+E4]");
		bool flag15 = (nint)0 == 0;
		object obj19 = !flag15;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mouth != null)
		{
			transform = mouth;
			if ((object)mouth != null)
			{
				goto IL_039f;
			}
		}
		else
		{
			transform = base.transform;
			bool flag16 = (object)transform == null;
			object obj20 = !flag16;
			if (obj20 != null)
			{
				goto IL_039f;
			}
		}
		goto IL_050e;
		IL_051c:
		throw new IndexOutOfRangeException();
	}

	public unsafe void RPC_PutIn(byte thing, RpcInfo info = default(RpcInfo))
	{
		//IL_0095: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I4
		//IL_0135: Expected I4, but got I8
		//IL_0071: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got VT
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I
		//IL_02d0: Expected VT, but got I8
		//IL_02eb: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got VT
		//IL_0328: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_0396: Expected VT, but got Ref
		//IL_039e: Expected I, but got VT
		//IL_03a6: Expected Obj, but got Ref
		//IL_03b7: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got Ref
		//IL_03c8: Expected Obj, but got I4
		//IL_03d0: Expected I4, but got VT
		//IL_01de: Expected Obj, but got I4
		//IL_01e3: Expected VT, but got Obj
		//IL_01f4: Expected VT, but got I4
		//IL_0652: Expected Ref, but got VT
		//IL_066c: Expected Obj, but got I4
		//IL_0797: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I
		//IL_034e: Expected VT, but got Obj
		//IL_036e: Expected VT, but got I4
		//IL_020b: Invalid comparison between VT and I4
		//IL_06b8: Expected Obj, but got I4
		//IL_0683: Expected Obj, but got I4
		//IL_068b: Expected Obj, but got VT
		//IL_0694: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I4
		//IL_0228: Invalid comparison between VT and I4
		//IL_023a: Expected Obj, but got I4
		//IL_023f: Expected VT, but got Obj
		//IL_0250: Expected VT, but got I4
		//IL_0705: Expected Obj, but got I
		//IL_0715: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got I
		//IL_0492: Expected VT, but got Obj
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected I4, but got Unknown
		//IL_04cd: Expected Obj, but got I4
		//IL_055d: Expected native int or pointer, but got VT
		//IL_056a: Expected native int or pointer, but got VT
		//IL_0574: Expected I, but got Obj
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected I4, but got Unknown
		//IL_051c: Expected VT, but got I4
		//IL_051c: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo;
		NullReferenceException ex;
		object obj11;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(3846818451u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag2 = (nint)obj5 < 2;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				object obj8;
				PlayerRef playerRef2;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					obj8 = 0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_0300;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag4)
						{
							goto IL_0300;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v60+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5308]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj8 = 0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0300;
			}
			ex = new NullReferenceException();
			rpcInfo = info;
			obj11 = 0;
			num = bytePayloadSize;
			goto IL_05b5;
		}
		goto IL_0005;
		IL_077d:
		nint num2 = default;
		bool flag6 = num2 == 0;
		object obj12 = !flag6;
		object obj13;
		nint num4;
		if (obj12 == null)
		{
			if ((nint)obj13 != 7)
			{
				bool flag7 = obj13 == null;
				object obj14 = !flag7;
				if (obj14 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v12+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F0]");
				object obj20 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj20);
				object obj21 = obj;
				int num3 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj22 = !flag9;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X27_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			bool flag10 = num == 0;
			object obj23 = !flag10;
			if (obj23 == null)
			{
				RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				Tick tick = default;
				System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
				((RpcInfo*)(nint)info)->_validationResult = num2;
				num4 = unchecked((nint)null);
				goto IL_0005;
			}
			return;
		}
		goto IL_05b5;
		IL_075a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0300:
		object obj24 = rpcInvokeInfo >> 32;
		bool flag11 = obj24 == null;
		object obj25 = !flag11;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj26 = 0;
			playerRef = (PlayerRef)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num5 = rpcBuilder2.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
		}
		rpcBuilder2.Dispose();
		num2 = 0;
		object obj27 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num4 = (nint)playerRef;
		networkRunner = (NetworkRunner)(&writer);
		rpcInfo = (RpcInfo)rpcInvokeInfo2;
		obj11 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj13 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_077d;
		IL_05b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj28;
		OutOfMemoryException ex2;
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj28 = obj27;
			num2 = 1;
		}
		else
		{
			bool flag12 = (nint)obj11 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag12)
			{
				goto IL_075a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj29 = default;
			obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj27 = obj29;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag13 = obj28 == null;
		object obj30 = !flag13;
		if (obj30 == null)
		{
			obj11 = 0;
			ex = (NullReferenceException)rpcBuilder3;
			obj13 = 0;
			goto IL_077d;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj11 = 0;
		goto IL_075a;
		IL_0005:
		bool flag14 = !info.IsInvokeLocal;
		object obj31 = !flag14;
		int thing2;
		if (obj31 == null)
		{
			thing2 = thing & 0xFF;
			bool flag15 = HandedIn(info.Source, thing2);
			bool flag16 = !flag15;
			object obj32 = !flag16;
			if (obj32 == null)
			{
				return;
			}
		}
		else
		{
			thing2 = thing & 0xFF;
		}
		Added(thing2);
	}

	private unsafe bool HandedIn(PlayerRef from, int thing)
	{
		//IL_0edc: Expected I4, but got I8
		//IL_0ef6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0f14: Expected Obj, but got I
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4d: Expected I4, but got VT
		//IL_0f56: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected VT, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got I
		//IL_0373: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I4
		//IL_103c: Expected Obj, but got I
		//IL_1051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_03bd: Expected I, but got Obj
		//IL_0f74: Expected Obj, but got I
		//IL_0f84: Expected Obj, but got I
		//IL_0fa6: Expected Obj, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected F8, but got Unknown
		//IL_032d: Expected Obj, but got I
		//IL_0335: Expected I4, but got Obj
		//IL_0356: Expected I4, but got Obj
		//IL_02e8: Expected Obj, but got I4
		//IL_0cec: Expected Obj, but got I4
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got I4
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Expected Obj, but got I
		//IL_0fef: Expected I, but got Obj
		//IL_100d: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_10ec: Expected Obj, but got I
		//IL_10f4: Expected I4, but got Obj
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd: Expected Ref, but got Unknown
		//IL_1117: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I4
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I4
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I4
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Expected Obj, but got I
		//IL_0856: Expected I, but got Obj
		//IL_0878: Expected Obj, but got I4
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got I4
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected I, but got Obj
		//IL_08df: Expected Obj, but got I4
		//IL_0915: Expected Obj, but got VT
		//IL_07e3: Expected Obj, but got I4
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected Obj, but got I4
		//IL_0990: Expected Obj, but got VT
		//IL_09bf: Expected Obj, but got VT
		//IL_09cd: Expected Obj, but got I4
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got I
		//IL_0a16: Expected I4, but got Obj
		//IL_0a43: Expected Obj, but got I4
		//IL_0a4b: Expected Obj, but got VT
		//IL_0a85: Expected Obj, but got VT
		//IL_0a93: Expected Obj, but got I4
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got VT
		//IL_0b09: Expected Obj, but got I4
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected Obj, but got VT
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got I
		//IL_0c6d: Expected I4, but got Obj
		//IL_0c96: Expected Obj, but got I4
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected Obj, but got I4
		int num = (int)(thing & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		object obj29;
		double num8;
		double num9;
		bool result;
		UnityEngine.Object obj35 = default;
		object obj30 = default;
		double num3;
		double num4;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			bool flag3 = obj5 == null;
			object obj8 = default;
			UnityEngine.Object obj7 = (UnityEngine.Object)obj8;
			Enumerator<, > val = (Enumerator<, >)0;
			int num2 = thing;
			GillaNetGuard.Kind kind = (GillaNetGuard.Kind)from;
			HashSet<System.__Canon> hashSet = (HashSet<System.__Canon>)109891584;
			if (flag3)
			{
				goto IL_0d67;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+18]");
			if ((nint)0 > (nint)thing)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v45+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = mouth == null;
				bool flag6 = !flag5;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
					object obj13 = 0;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v49+E4]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef playerRef = (PlayerRef)(from & 0xFFFFFFFFL);
					if (GillaNetGuard.Spend(playerRef, (GillaNetGuard.Kind)7, 4f, 6f))
					{
						hashSet = (HashSet<System.__Canon>)(object)handedIn;
						bool flag8 = handedIn == null;
						obj7 = (UnityEngine.Object)obj8;
						val = (Enumerator<, >)0;
						num3 = 6.0;
						num4 = 4.0;
						num2 = 0;
						kind = (GillaNetGuard.Kind)7;
						if (!flag8)
						{
							bool flag9 = hashSet._count < 65;
							obj7 = (UnityEngine.Object)obj8;
							num2 = 0;
							kind = (GillaNetGuard.Kind)7;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5348]");
								object obj16 = 0;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v104+E4]");
								bool flag10 = (nint)0 == 0;
								object obj18 = !flag10;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj17 = obj16;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v104+A0]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v57+8]");
								Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v57+8]");
								bool flag11 = (nint)0 == 0;
								object obj20 = !flag11;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v104+E4]");
									bool flag12 = (nint)0 == 0;
									object obj21 = !flag12;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj22 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v61+A0]");
										obj19 = 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5338]");
									Enumerator<, > val2 = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5340]");
									object obj23 = 0;
									Predicate<System.__Canon> predicate2 = default;
									predicate2._002Ector(obj19, (IntPtr)obj23);
									object obj24 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v60+A0]");
									object obj25 = (nint)0 + (nint)8;
									obj25 = predicate2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									predicate = predicate2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5328]");
								object obj26 = 0;
								num2 = (int)obj26;
								int num5 = hashSet.RemoveWhere(predicate);
								obj7 = (UnityEngine.Object)obj19;
								kind = (GillaNetGuard.Kind)predicate;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
							hashSet = (HashSet<System.__Canon>)0;
							nint num6 = (nint)hashSet;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X0_v54 (Il2CppClass<System.Collections.Generic.HashSet`1<System.__Canon>>)+E4]");
							bool flag13 = (nint)0 == 0;
							object obj27 = !flag13;
							nint num7 = num6;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num7 = (nint)hashSet;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v55 (Il2CppClass<System.Collections.Generic.HashSet`1<System.__Canon>>)+A0]");
							object obj28 = 0;
							bool flag14 = obj28 == null;
							val = (Enumerator<, >)0;
							num3 = 6.0;
							num4 = 4.0;
							if (!flag14)
							{
								Enumerator<, > enumerator = ((List<System.__Canon>)obj28).GetEnumerator();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
								object obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								hashSet = (HashSet<System.__Canon>)0;
								obj29 = obj30;
								Enumerator<, > val2 = (Enumerator<, >)(ref val);
								num8 = 6.0;
								Enumerator<, > val3 = default;
								num9 = (double)val3;
								UnityEngine.Object obj33 = default;
								PlayerRef none = default;
								bool result2 = default;
								object obj50 = default;
								while (true)
								{
									object obj36;
									Enumerator<, > val4;
									if (val.MoveNext())
									{
										object obj31 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v61+E4]");
										bool flag15 = (nint)0 == 0;
										object obj32 = !flag15;
										if (obj32 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag16 = obj33 == null;
										bool flag17 = !flag16;
										object obj34 = !flag17;
										num2 = 0;
										if (obj34 != null)
										{
											continue;
										}
										bool flag18 = (object)obj33 == null;
										obj35 = null;
										obj36 = 0;
										val = val3;
										val4 = (Enumerator<, >)(ref val);
										num2 = 0;
										kind = (GillaNetGuard.Kind)0;
										if (flag18)
										{
											break;
										}
										object obj37 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ stack_-A8_v14 (UnityEngine.Object)+88]");
										obj7 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v65+E4]");
										bool flag19 = (nint)0 == 0;
										object obj38 = !flag19;
										if (obj38 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag20 = obj7 == null;
										bool flag21 = !flag20;
										object obj39 = !flag21;
										num2 = 0;
										if (obj39 != null)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ stack_-A8_v14 (UnityEngine.Object)+88]");
										bool flag22 = (nint)0 == 0;
										obj30 = obj29;
										obj35 = null;
										obj36 = 0;
										val = val3;
										val4 = (Enumerator<, >)(ref val);
										num3 = num8;
										num4 = num9;
										num2 = 0;
										kind = (GillaNetGuard.Kind)0;
										if (flag22)
										{
											goto IL_0d7d;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ stack_-A8_v14 (UnityEngine.Object)+88]");
										bool live = ((GillaItemNet)0).Live;
										bool flag23 = !live;
										num2 = 0;
										if (flag23)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ stack_-A8_v14 (UnityEngine.Object)+88]");
										object obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ stack_-A8_v14 (UnityEngine.Object)+88]");
										bool flag24 = (nint)0 == 0;
										obj30 = obj29;
										obj35 = null;
										obj36 = 0;
										val = val3;
										val4 = (Enumerator<, >)(ref val);
										num3 = num8;
										num4 = num9;
										num2 = 0;
										kind = (GillaNetGuard.Kind)0;
										if (!flag24)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v41+40]");
											obj7 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v41+40]");
											bool flag25 = (nint)0 == 0;
											obj30 = obj29;
											obj35 = null;
											obj36 = 0;
											val = val3;
											val4 = (Enumerator<, >)(ref val);
											num3 = num8;
											num4 = num9;
											num2 = 0;
											kind = (GillaNetGuard.Kind)0;
											if (!flag25)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X24_v15 (UnityEngine.Object)+20]");
												object obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X24_v15 (UnityEngine.Object)+20]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X24_v15 (UnityEngine.Object)+30]");
													val2 = (Enumerator<, >)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X24_v15 (UnityEngine.Object)+30]");
													bool flag26 = (nint)0 == 0;
													obj30 = obj29;
													obj35 = null;
													obj36 = 0;
													val = val3;
													val4 = (Enumerator<, >)(ref val);
													num3 = num8;
													num4 = num9;
													num2 = 0;
													kind = (GillaNetGuard.Kind)0;
													if (!flag26)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v18 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+58]");
														bool flag27 = (nint)0 == 0;
														obj30 = obj29;
														obj35 = null;
														obj36 = 0;
														val = val3;
														val4 = (Enumerator<, >)(ref val);
														num3 = num8;
														num4 = num9;
														num2 = 0;
														kind = (GillaNetGuard.Kind)0;
														if (!flag27)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v43+20]");
															kind = (GillaNetGuard.Kind)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
															num2 = 0;
															goto IL_08b5;
														}
													}
													goto IL_0d8b;
												}
												nint num10 = (nint)hashSet;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v90 (Il2CppClass<System.Collections.Generic.HashSet`1<System.__Canon>>)+E4]");
												bool flag28 = (nint)0 == 0;
												object obj42 = !flag28;
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												none = PlayerRef.None;
												num2 = 0;
												kind = (GillaNetGuard.Kind)0;
												goto IL_08b5;
											}
											goto IL_0d99;
										}
										goto IL_0da7;
									}
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									object obj43 = 0;
									goto IL_113a;
									IL_0dc0:
									NullReferenceException ex = new NullReferenceException();
									goto IL_0dce;
									IL_08b5:
									nint num11 = (nint)hashSet;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X0_v73 (Il2CppClass<System.Collections.Generic.HashSet`1<System.__Canon>>)+E4]");
									bool flag29 = (nint)0 == 0;
									object obj44 = !flag29;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag30 = none != from;
									obj7 = (UnityEngine.Object)none;
									if (flag30)
									{
										continue;
									}
									object obj45 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ X0_v75+E4]");
									bool flag31 = (nint)0 == 0;
									object obj46 = !flag31;
									if (obj46 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int num12 = ThingOf((GillaItem)obj33);
									bool flag32 = num12 != thing;
									obj7 = (UnityEngine.Object)none;
									if (flag32)
									{
										continue;
									}
									bool flag33 = handedIn == null;
									obj30 = obj29;
									obj7 = (UnityEngine.Object)none;
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									num3 = num8;
									num4 = num9;
									if (flag33)
									{
										goto IL_0dc0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5320]");
									object obj47 = 0;
									num2 = (int)obj47;
									bool flag34 = ((HashSet<System.__Canon>)(object)handedIn).Contains((System.__Canon)(object)obj33);
									bool flag35 = !flag34;
									object obj48 = !flag35;
									obj7 = (UnityEngine.Object)none;
									if (obj48 != null)
									{
										continue;
									}
									Transform transform = ((Component)obj33).transform;
									bool flag36 = (object)transform == null;
									obj30 = obj29;
									obj7 = (UnityEngine.Object)none;
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									num3 = num8;
									num4 = num9;
									kind = (GillaNetGuard.Kind)0;
									if (flag36)
									{
										goto IL_0dce;
									}
									Vector3 position = transform.position;
									bool flag37 = (object)mouth == null;
									obj30 = obj29;
									obj7 = (UnityEngine.Object)none;
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									num3 = num8;
									num4 = num9;
									kind = (GillaNetGuard.Kind)0;
									if (flag37)
									{
										goto IL_0ddc;
									}
									Vector3 position2 = mouth.position;
									double num13 = num9 - num9;
									double num14 = num8 - num8;
									obj29 -= obj29;
									double num15 = num13 * num13;
									double num16 = num14 * num14;
									double num17 = num15 + num16;
									num3 = (double)obj29 * (double)obj29;
									num4 = num3 + num17;
									bool flag38 = num4 > 9.0;
									obj7 = (UnityEngine.Object)none;
									num8 = num3;
									num9 = num4;
									if (flag38)
									{
										continue;
									}
									bool flag39 = handedIn == null;
									obj30 = obj29;
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									kind = (GillaNetGuard.Kind)0;
									if (flag39)
									{
										goto IL_0dea;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5318]");
									object obj49 = 0;
									num2 = (int)obj49;
									bool flag40 = ((HashSet<System.__Canon>)(object)handedIn).Add((System.__Canon)(object)obj33);
									obj30 = obj29;
									obj35 = null;
									obj36 = 0;
									val = val3;
									val4 = (Enumerator<, >)(ref val);
									num8 = num3;
									num9 = num4;
									result = true;
									obj43 = 0;
									goto IL_10dc;
									IL_113a:
									obj30 = obj29;
									result = false;
									goto IL_10dc;
									IL_0dea:
									NullReferenceException ex2 = new NullReferenceException();
									if (kind == (GillaNetGuard.Kind)2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj29 = obj30;
										obj35 = (UnityEngine.Object)1;
										num8 = num3;
										num9 = num4;
										obj43 = obj36;
									}
									else
									{
										if (kind != (GillaNetGuard.Kind)1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
											return result2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										obj43 = obj50;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj29 = obj30;
										obj36 = obj50;
										num8 = num3;
										num9 = num4;
									}
									goto IL_113a;
									IL_10dc:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
									object obj51 = 0;
									kind = (GillaNetGuard.Kind)obj51;
									((Enumerator<, >*)val4)->Dispose();
									bool flag41 = obj43 == null;
									object obj52 = !flag41;
									num3 = num8;
									num4 = num9;
									if (obj52 != null)
									{
										OutOfMemoryException ex3 = new OutOfMemoryException();
										goto IL_0dc0;
									}
									goto IL_0d0d;
									IL_0dce:
									NullReferenceException ex4 = new NullReferenceException();
									goto IL_0ddc;
									IL_0ddc:
									NullReferenceException ex5 = new NullReferenceException();
									goto IL_0dea;
								}
								goto IL_0d41;
							}
						}
						goto IL_0d67;
					}
				}
			}
		}
		result = false;
		goto IL_1135;
		IL_0d8b:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0d99;
		IL_0d0d:
		if ((object)obj35 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			obj29 = obj30;
			goto IL_0d41;
		}
		goto IL_1135;
		IL_0d99:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0da7;
		IL_0d67:
		NullReferenceException ex8 = new NullReferenceException();
		obj35 = obj35;
		goto IL_0d7d;
		IL_0d7d:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0d8b;
		IL_0d41:
		NullReferenceException ex10 = new NullReferenceException();
		obj30 = obj29;
		num3 = num8;
		num4 = num9;
		goto IL_0d67;
		IL_1135:
		return result;
		IL_0da7:
		throw new NullReferenceException();
	}

	private void Added(int thing)
	{
		//IL_0188: Expected I4, but got I8
		//IL_01a2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		int num = (int)(thing & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v4+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+18]");
		if ((nint)0 <= (nint)thing)
		{
			return;
		}
		List<byte> list = inside;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+18]");
		if ((nint)0 < (nint)holds)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+1C]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v4+18]");
			bool flag3 = num2 < 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+18]");
				object obj10 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7 (System.Collections.Generic.List`1<System.Byte>)+18]");
				object obj11 = obj7 + 0;
			}
			else
			{
				list.AddWithResize((byte)thing);
			}
		}
	}

	private unsafe void Pour()
	{
		//IL_1094: Expected F4, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_006d: Expected F4, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_0149: Expected F4, but got I4
		//IL_0152: Expected VT, but got I4
		//IL_0157: Expected I, but got Obj
		//IL_023b: Expected F4, but got I
		//IL_0276: Expected VT, but got I4
		//IL_027b: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_02a1: Expected VT, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_0313: Expected VT, but got Obj
		//IL_0384: Expected I, but got Obj
		//IL_03c5: Expected I, but got Obj
		//IL_0410: Expected I, but got Obj
		//IL_0435: Expected I4, but got I8
		//IL_0449: Expected I, but got Obj
		//IL_04c4: Expected VT, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I4
		//IL_0470: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_0769: Expected I, but got VT
		//IL_04a4: Expected I, but got Obj
		//IL_0787: Expected Obj, but got I
		//IL_078f: Expected I, but got Obj
		//IL_07a0: Expected Obj, but got I
		//IL_0b0c: Expected I, but got Obj
		//IL_0d83: Expected Obj, but got I4
		//IL_0dc6: Expected VT, but got I4
		//IL_07e1: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I
		//IL_0803: Expected I, but got Obj
		//IL_0b33: Expected I, but got Obj
		//IL_0e76: Expected Obj, but got I
		//IL_0ea0: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I4
		//IL_0ecd: Expected F4, but got I
		//IL_0edd: Expected F4, but got I
		//IL_0ef9: Expected VT, but got I4
		//IL_0f3e: Expected I, but got Obj
		//IL_0e03: Expected Obj, but got I4
		//IL_10b2: Expected Obj, but got I
		//IL_0b5c: Expected VT, but got I4
		//IL_120b: Expected Obj, but got I
		//IL_1254: Expected VT, but got I4
		//IL_1259: Expected I, but got Obj
		//IL_0f6b: Expected Obj, but got I4
		//IL_0f7e: Expected Obj, but got I4
		//IL_0f98: Expected Obj, but got I4
		//IL_0872: Expected Obj, but got I
		//IL_0886: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I
		//IL_0e38: Expected Obj, but got I
		//IL_0e40: Expected VT, but got Obj
		//IL_0e59: Expected Obj, but got I
		//IL_110f: Expected I, but got Obj
		//IL_1138: Expected F4, but got VT
		//IL_0fda: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I4
		//IL_1289: Expected Obj, but got I4
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got I
		//IL_0c8d: Expected Obj, but got I
		//IL_08f4: Expected Obj, but got F4
		//IL_0912: Expected Obj, but got I4
		//IL_1043: Expected F4, but got I
		//IL_1043: Expected F4, but got I
		//IL_11ba: Expected I, but got Obj
		//IL_0d44: Expected VT, but got Ref
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected VT, but got Unknown
		//IL_0953: Invalid comparison between VT and F8
		//IL_096d: Expected VT, but got I4
		//IL_0cbc: Expected Obj, but got I4
		//IL_118d: Expected Obj, but got I
		//IL_0bb9: Expected VT, but got Ref
		//IL_0bc1: Expected F4, but got VT
		//IL_0bca: Expected VT, but got I4
		//IL_0bcf: Expected I, but got Obj
		//IL_0a17: Expected Obj, but got I4
		//IL_0d1d: Expected VT, but got Ref
		//IL_0ce9: Expected VT, but got Obj
		//IL_0cfe: Expected Obj, but got I
		//IL_0aaa: Expected Obj, but got I
		//IL_0aba: Expected Obj, but got I
		//IL_0aca: Expected VT, but got I
		//IL_0ad7: Expected Obj, but got F4
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected Obj, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0a72: Expected Obj, but got F4
		//IL_0a8d: Expected VT, but got I4
		GillaItem gillaItem = item;
		bool flag = (object)item == null;
		float num = 0f;
		object obj2;
		byte b;
		nint num14;
		Vector3 vector2;
		float num8 = default;
		nint num2;
		Vector3 vector;
		float num5 = default;
		if (!flag)
		{
			bool flag2 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
			object obj = !flag2;
			if (obj != null || ~(gillaItem.Gone__BackingField ? 1u : 0u) == 0)
			{
				return;
			}
			List<byte> list = inside;
			bool flag3 = inside == null;
			num = 0f;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj4 = !flag4;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = mouth == null;
				bool flag6 = !flag5;
				object obj5 = !flag6;
				if (obj5 != null)
				{
					return;
				}
				bool flag7 = (object)mouth == null;
				num = 0f;
				vector = (Vector3)0;
				num2 = unchecked((nint)null);
				if (!flag7)
				{
					Vector3 up = mouth.up;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
					float num3 = 0f * 0f;
					float num4 = num5 * num5;
					float num6 = num3 + num4;
					float num7 = num8 * num8;
					float num9 = num7 + num6;
					if ((double)num9 > -0.25)
					{
						return;
					}
					float time = Time.time;
					if (time < nextPour)
					{
						return;
					}
					float time2 = Time.time;
					List<byte> list2 = inside;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF84]");
					num5 = 0f;
					float num10 = time2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF84]");
					num = (nextPour = num10 + 0f);
					bool flag8 = inside == null;
					vector = (Vector3)0;
					num2 = unchecked((nint)null);
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A0]");
						object obj6 = 0;
						vector = (Vector3)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v21 (System.Collections.Generic.List`1<System.Byte>)+18]");
						int num11 = (int)(-1);
						b = inside.get_Item(num11);
						List<byte> list3 = inside;
						bool flag9 = inside == null;
						num2 = num11;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52D8]");
							object obj7 = 0;
							vector = (Vector3)obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v14 (System.Collections.Generic.List`1<System.Byte>)+18]");
							int num12 = (int)(-1);
							inside.RemoveAt(num12);
							bool flag10 = (object)mouth == null;
							num2 = num12;
							if (!flag10)
							{
								Vector3 position = mouth.position;
								bool flag11 = (object)mouth == null;
								num2 = unchecked((nint)null);
								if (!flag11)
								{
									Vector3 up2 = mouth.up;
									Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
									bool flag12 = (object)mouth == null;
									num2 = unchecked((nint)null);
									if (!flag12)
									{
										Vector3 up3 = mouth.up;
										Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
										GillaItem gillaItem2 = item;
										bool flag13 = (object)item == null;
										num2 = unchecked((nint)null);
										if (!flag13)
										{
											int num13 = (int)(gillaItem2.Hand__BackingField & 0x80000000L);
											bool flag14 = num13 == 0;
											num14 = unchecked((nint)null);
											if (flag14)
											{
												goto IL_04b2;
											}
											bool flag15 = (object)gillaItem2.Body__BackingField == null;
											num2 = unchecked((nint)null);
											if (!flag15)
											{
												bool isKinematic = gillaItem2.Body__BackingField.isKinematic;
												bool flag16 = !isKinematic;
												num14 = unchecked((nint)null);
												if (!flag16)
												{
													goto IL_04b2;
												}
												GillaItem gillaItem3 = item;
												bool flag17 = (object)item == null;
												num2 = unchecked((nint)null);
												if (!flag17)
												{
													bool flag18 = (object)gillaItem3.Body__BackingField == null;
													num2 = unchecked((nint)null);
													if (!flag18)
													{
														Vector3 linearVelocity = gillaItem3.Body__BackingField.linearVelocity;
														vector2 = (Vector3)0;
														goto IL_04c9;
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
		goto IL_1048;
		IL_1146:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D444");
		float num15;
		num8 = num15;
		float num17;
		float num16 = num17;
		float num19;
		double num18 = num19;
		float num21;
		float num20 = num21;
		float num22 = default;
		num5 = num22;
		goto IL_1056;
		IL_0d59:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X0_v42+E4]");
		bool flag19 = (nint)0 == 0;
		object obj9 = !flag19;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaItem gillaItem4;
		bool flag20 = gillaItem4 != null;
		bool flag21 = !flag20;
		vector = (Vector3)0;
		System.__Canon _Canon = null;
		object obj11;
		if (!flag21)
		{
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v56+E4]");
			bool flag22 = (nint)0 == 0;
			object obj12 = !flag22;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v56+A0]");
			object obj13 = 0;
			num = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v36+10]");
			bool flag23 = (nint)0 == 0;
			num8 = num15;
			num16 = num17;
			num18 = num19;
			num20 = num21;
			vector = (Vector3)0;
			num2 = unchecked((nint)null);
			if (flag23)
			{
				goto IL_1048;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52A0]");
			object obj14 = 0;
			vector = (Vector3)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v36+10]");
			((Dictionary<System.__Canon, float>)0).set_Item((System.__Canon)(object)gillaItem4, num);
			_Canon = (System.__Canon)(object)gillaItem4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X0_v47+E4]");
		bool flag24 = (nint)0 == 0;
		object obj17 = !flag24;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		num20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC4]");
		num16 = 0f;
		float num23;
		float num24;
		Sfx.Play(pourSounds, (Vector3)0, num23, num24, num15);
		GillaItem gillaItem5 = item;
		bool flag25 = (object)item == null;
		num8 = num15;
		num18 = 0.5;
		num5 = num24;
		num = num23;
		num2 = unchecked((nint)null);
		if (!flag25)
		{
			bool flag26 = gillaItem5.Hand__BackingField < 1;
			object obj18 = !flag26;
			object obj19 = gillaItem5.Hand__BackingField - 1;
			bool flag27 = obj19 == null;
			object obj20 = !flag27;
			object obj21 = obj18 & obj20;
			if (obj21 == null)
			{
				object obj22 = obj11;
				bool flag28 = gillaItem5.Hand__BackingField == 0;
				object obj23 = !flag28;
				object obj24 = ~obj23;
				XRNode node = ((obj24 != null) ? ((XRNode)4) : ((XRNode)5));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v50+E4]");
				bool flag29 = (nint)0 == 0;
				object obj25 = !flag29;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				Buzz(node, num25, 0f);
			}
			return;
		}
		goto IL_1048;
		IL_0d07:
		NullReferenceException ex = new NullReferenceException();
		Enumerator<, > val = default;
		Dictionary<System.__Canon, float>.Enumerator enumerator = (Dictionary<System.__Canon, float>.Enumerator)(&val);
		float num26 = default;
		num = num26;
		NullReferenceException ex2 = ex;
		goto IL_1146;
		IL_1056:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_1048:
		NullReferenceException ex3 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
		ex2 = ex3;
		goto IL_1056;
		IL_04b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
		vector2 = (Vector3)num14;
		goto IL_04c9;
		IL_0b61:
		NullReferenceException ex4 = new NullReferenceException();
		float num27 = default;
		enumerator = (Dictionary<System.__Canon, float>.Enumerator)(&num27);
		Dictionary<System.__Canon, float>.Enumerator enumerator2;
		num = (float)enumerator2;
		vector = (Vector3)0;
		num2 = unchecked((nint)null);
		ex2 = ex4;
		goto IL_1146;
		IL_04c9:
		float num28 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num29 = num28 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		obj11 = 0;
		float num30 = num * 0.25f;
		float num31 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num32 = num31 * 0f;
		float num33 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num34 = num33 * 0f;
		float num35 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num36 = num35 * 0f;
		float num37 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num38 = num37 * 0f;
		float num39 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num40 = num39 * 0f;
		float num41 = num5 * 0.25f;
		float num42 = num8 * 0.25f;
		float num43 = num5 + num29;
		float num44 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		float num45 = num44 * 0f;
		float num46 = num + num34;
		float num47 = num32 + num30;
		float num48 = num8 + num36;
		object obj26 = obj11;
		float num49 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		float num50 = num49 * 0f;
		float num51 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		float num52 = num51 * 0f;
		float num53 = num38 + num41;
		float num54 = num40 + num42;
		num23 = num46 + num45;
		num19 = num47 + num;
		num24 = num43 + num50;
		num15 = num48 + num52;
		num21 = num53 + num5;
		num17 = num54 + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v35+E4]");
		bool flag30 = (nint)0 == 0;
		object obj27 = !flag30;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int thing = b & 0xFF;
		gillaItem4 = Spawn(thing, vector2, vector);
		object obj28 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v21+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v22+10]");
		bool flag31 = (nint)0 == 0;
		num8 = num15;
		num16 = num17;
		num18 = num19;
		num20 = num21;
		num5 = num24;
		num = num23;
		num2 = (nint)vector2;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5298]");
			object obj30 = 0;
			num2 = (nint)obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v22+10]");
			int count = ((Dictionary<System.__Canon, float>)0).Count;
			bool flag32 = count < 41;
			num5 = num24;
			num = num23;
			if (flag32)
			{
				goto IL_0d59;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52E8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52E0]");
			object obj32 = 0;
			num2 = (nint)obj32;
			List<System.__Canon> list4 = default;
			list4._002Ector();
			object obj33 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v65+E4]");
			bool flag33 = (nint)0 == 0;
			object obj34 = !flag33;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v65+A0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v44+10]");
			bool flag34 = (nint)0 == 0;
			num8 = num15;
			num16 = num17;
			num18 = num19;
			num20 = num21;
			num5 = num24;
			num = num23;
			if (!flag34)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v44+10]");
				Dictionary<System.__Canon, float>.Enumerator enumerator3 = ((Dictionary<System.__Canon, float>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52B0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52D0]");
				object obj37 = 0;
				Dictionary<System.__Canon, float>.Enumerator enumerator4 = enumerator;
				Dictionary<System.__Canon, float>.Enumerator enumerator5 = default;
				System.__Canon key;
				object obj41 = default;
				while (true)
				{
					num2 = (nint)obj36;
					bool flag35 = enumerator5.MoveNext();
					bool flag36 = !flag35;
					key = null;
					num = (float)enumerator4;
					if (flag36)
					{
						break;
					}
					object obj38 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v91+E4]");
					bool flag37 = (nint)0 == 0;
					object obj39 = !flag37;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag38 = (UnityEngine.Object)num22 == null;
					bool flag39 = !flag38;
					object obj40 = !flag39;
					enumerator2 = enumerator4;
					bool flag40 = flag32;
					if (obj40 == null)
					{
						float time3 = Time.time;
						enumerator2 = (Dictionary<System.__Canon, float>.Enumerator)(time3 - obj41);
						flag40 = enumerator2 <= (object)1.0;
						enumerator4 = enumerator2;
						vector = (Vector3)0;
						flag32 = flag40;
						if (flag40)
						{
							continue;
						}
					}
					if (list4 != null)
					{
						System.__Canon[] items = list4._items;
						object obj42 = obj37;
						int version = list4._version + 1;
						list4._version = version;
						if (list4._items != null)
						{
							bool flag41 = list4._size < items.Length;
							object obj43 = !flag41;
							if (obj43 == null)
							{
								object obj44 = list4._items + list4._size;
								int size = list4._size + 1;
								list4._size = size;
								object obj45 = obj44 + 32;
								obj45 = num22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								enumerator4 = enumerator2;
								vector = (Vector3)0;
								flag32 = flag40;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X9_v20+20]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X8_v64+A8]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v65+70]");
								vector = (Vector3)0;
								list4.AddWithResize((System.__Canon)num22);
								enumerator4 = enumerator2;
								flag32 = flag40;
							}
							continue;
						}
					}
					goto IL_0b61;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D444");
				bool flag42 = list4 == null;
				num8 = num15;
				num16 = num17;
				num18 = num19;
				num20 = num21;
				num5 = num22;
				if (!flag42)
				{
					Enumerator<, > enumerator6 = list4.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5290]");
					object obj49 = 0;
					while (true)
					{
						num2 = (nint)obj48;
						if (!val.MoveNext())
						{
							break;
						}
						object obj50 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v85+E4]");
						bool flag43 = (nint)0 == 0;
						object obj51 = !flag43;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj50 = obj11;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X0_v85+A0]");
						object obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v58+10]");
						if ((nint)0 != 0)
						{
							vector = (Vector3)obj49;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v58+10]");
							bool flag44 = ((Dictionary<System.__Canon, float>)0).Remove(key);
							continue;
						}
						goto IL_0d07;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
					enumerator = (Dictionary<System.__Canon, float>.Enumerator)(&val);
					num5 = num22;
					num = num26;
					goto IL_0d59;
				}
			}
		}
		goto IL_1048;
	}

	private unsafe static GillaItem Spawn(int thing, Vector3 at, Vector3 going)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0dd7: Expected I, but got Obj
		//IL_0df9: Expected Obj, but got I4
		//IL_0ecc: Expected Obj, but got I
		//IL_0027: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_0ba9: Invalid comparison between VT and I4
		//IL_0203: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I4
		//IL_0bf1: Expected I, but got Obj
		//IL_0bf9: Expected VT, but got I
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected Obj, but got Unknown
		//IL_0e3e: Expected Obj, but got I4
		//IL_0d82: Expected VT, but got I4
		//IL_0f11: Expected Obj, but got I
		//IL_0f21: Expected Obj, but got I
		//IL_0f43: Expected Obj, but got I4
		//IL_0da4: Expected VT, but got I4
		//IL_0c47: Expected Obj, but got I4
		//IL_0c57: Expected Obj, but got Ref
		//IL_0287: Expected Obj, but got I
		//IL_0e76: Expected Obj, but got I4
		//IL_0c93: Expected I, but got Obj
		//IL_033e: Expected VT, but got I4
		//IL_02d5: Expected VT, but got I4
		//IL_02de: Expected VT, but got I4
		//IL_0ccb: Expected Obj, but got I4
		//IL_06be: Expected Obj, but got I4
		//IL_0d00: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_06f3: Expected VT, but got Obj
		//IL_0371: Expected VT, but got I4
		//IL_037a: Expected VT, but got I4
		//IL_0304: Expected Obj, but got I
		//IL_0d2f: Expected VT, but got I4
		//IL_0d37: Expected I, but got Obj
		//IL_0d3f: Expected VT, but got Obj
		//IL_0eae: Expected Obj, but got I4
		//IL_0787: Expected VT, but got I4
		//IL_03b5: Expected VT, but got I4
		//IL_081f: Expected Obj, but got I4
		//IL_07cb: Expected VT, but got I4
		//IL_03f0: Expected VT, but got I4
		//IL_03f9: Expected VT, but got I4
		//IL_0852: Expected VT, but got I4
		//IL_085b: Expected VT, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_043a: Expected VT, but got I4
		//IL_0879: Expected Obj, but got I
		//IL_0881: Expected VT, but got Obj
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got Unknown
		//IL_046d: Expected VT, but got I4
		//IL_0476: Expected VT, but got I4
		//IL_08d5: Expected VT, but got Ref
		//IL_049c: Expected Obj, but got I
		//IL_04a4: Expected VT, but got Obj
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got Ref
		//IL_090d: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got I
		//IL_04fe: Expected VT, but got Obj
		//IL_0a0c: Expected Obj, but got I
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I
		//IL_0529: Expected VT, but got Obj
		//IL_0549: Expected VT, but got Ref
		//IL_0549: Expected VT, but got I4
		//IL_097a: Expected VT, but got I4
		//IL_0983: Expected VT, but got I4
		//IL_057c: Expected Obj, but got I4
		//IL_0a5c: Expected Obj, but got I4
		//IL_0b1e: Expected VT, but got I4
		//IL_09b6: Expected VT, but got I4
		//IL_09bf: Expected VT, but got I4
		//IL_0b39: Expected Obj, but got I4
		//IL_0b4f: Expected VT, but got Ref
		//IL_0b5c: Expected I, but got Obj
		//IL_0b65: Expected VT, but got I4
		//IL_0a82: Expected VT, but got Obj
		//IL_0a8a: Expected VT, but got Ref
		//IL_05dc: Expected Obj, but got I4
		//IL_05f2: Expected VT, but got Ref
		//IL_05ff: Expected I, but got Obj
		//IL_0608: Expected VT, but got I4
		//IL_0611: Expected VT, but got I4
		//IL_0aaf: Expected VT, but got I4
		//IL_0ab8: Expected VT, but got I4
		//IL_0645: Expected Obj, but got I4
		//IL_065b: Expected VT, but got Ref
		//IL_0668: Expected I, but got Obj
		//IL_0671: Expected VT, but got I4
		//IL_0af9: Expected VT, but got I4
		//IL_0b02: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		GameObject gameObject = (GameObject)0;
		nint num = (nint)gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2 (Il2CppClass<UnityEngine.GameObject>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		nint num2 = num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)gameObject;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (Il2CppClass<UnityEngine.GameObject>)+A0]");
		object obj2 = 0;
		object obj3 = obj2;
		bool flag2 = obj2 == null;
		Quaternion? quaternion2 = default;
		Quaternion? quaternion = quaternion2;
		int num3;
		object obj10 = default;
		Quaternion? quaternion5 = default;
		UnityEngine.Object obj40;
		Vector3 vector2 = default;
		Vector3 vector;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+18]");
			bool flag3 = (nint)0 < (nint)thing;
			object obj4 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+18]");
			object obj5 = -thing;
			bool flag4 = obj5 == null;
			object obj6 = ~obj4;
			object obj7 = obj6 | flag4;
			if (obj7 != null)
			{
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				num3 = thing;
				goto IL_0b92;
			}
			object obj8 = thing * 24;
			object obj9 = obj2 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v31+28]");
			GameObject gameObject2 = PrefabOf((string)0);
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (gameObject2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5378]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5380]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v31+28]");
				string message = (string)obj13 + (string)0 + (string)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v57+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				goto IL_01e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v73+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v77+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			object obj23 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v77+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v13+8]");
			UnityEngine.Object obj25 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v37+E4]");
			bool flag9 = (nint)0 == 0;
			object obj26 = !flag9;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v13+8]");
			bool flag10 = (UnityEngine.Object)0 != null;
			bool flag11 = !flag10;
			UnityEngine.Object obj27 = null;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v13+8]");
				bool flag12 = (nint)0 == 0;
				quaternion = quaternion2;
				vector = (Vector3)0;
				vector2 = (Vector3)0;
				gameObject = gameObject2;
				if (flag12)
				{
					goto IL_0d56;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X22_v11 (UnityEngine.Object)+B0]");
				obj27 = (UnityEngine.Object)0;
			}
			object obj28 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v81+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag14 = obj27 != null;
			bool flag15 = !flag14;
			vector = (Vector3)0;
			UnityEngine.Object obj30 = null;
			if (!flag15)
			{
				bool flag16 = (object)obj27 == null;
				quaternion = quaternion2;
				vector = (Vector3)0;
				vector2 = (Vector3)0;
				gameObject = gameObject2;
				if (flag16)
				{
					goto IL_0d56;
				}
				bool isRunning = ((NetworkRunner)obj27).IsRunning;
				bool flag17 = !isRunning;
				vector = (Vector3)0;
				obj30 = null;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v13+8]");
					bool flag18 = (nint)0 == 0;
					quaternion = quaternion2;
					vector = (Vector3)0;
					vector2 = (Vector3)0;
					gameObject = gameObject2;
					if (flag18)
					{
						goto IL_0d56;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X22_v11 (UnityEngine.Object)+A4]");
					bool flag19 = (nint)0 == 0;
					object obj31 = !flag19;
					vector = (Vector3)0;
					obj30 = null;
					if (obj31 == null)
					{
						bool flag20 = (object)gameObject2 == null;
						quaternion = quaternion2;
						vector = (Vector3)0;
						vector2 = (Vector3)0;
						gameObject = gameObject2;
						if (flag20)
						{
							goto IL_0d56;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
						object obj32 = 0;
						vector = (Vector3)obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
						object obj34 = default;
						object obj33 = obj34 & 1;
						bool flag21 = obj33 == null;
						NetworkObject prefab = default;
						obj30 = (UnityEngine.Object)(&prefab);
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
							object obj35 = 0;
							Vector3? position = (Vector3)obj35;
							Quaternion rotation = UnityEngine.Random.rotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
							object obj36 = 0;
							Quaternion? quaternion3 = (Quaternion)obj36;
							Quaternion? quaternion4 = default;
							NetworkObject networkObject = ((NetworkRunner)obj27).Spawn(prefab, position, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion4), (NetworkRunner.OnBeforeSpawned)null, (NetworkSpawnFlags)0);
							object obj37 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v106+E4]");
							bool flag22 = (nint)0 == 0;
							object obj38 = !flag22;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)networkObject != (UnityEngine.Object)null)
							{
								bool flag23 = (object)networkObject == null;
								object obj39 = 4;
								NetworkSpawnFlags networkSpawnFlags = (NetworkSpawnFlags)0;
								NetworkRunner.OnBeforeSpawned onBeforeSpawned = null;
								PlayerRef? playerRef = (PlayerRef?)(object)(&quaternion4);
								quaternion5 = quaternion3;
								nint num4 = unchecked((nint)null);
								vector = (Vector3)0;
								vector2 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v31+28]");
								num3 = 0;
								if (flag23)
								{
									goto IL_0b92;
								}
								GameObject gameObject3 = networkObject.gameObject;
								obj39 = 4;
								networkSpawnFlags = (NetworkSpawnFlags)0;
								onBeforeSpawned = null;
								playerRef = (PlayerRef?)(object)(&quaternion4);
								quaternion5 = quaternion3;
								num4 = unchecked((nint)null);
								Vector3 vector3 = (Vector3)0;
								string text = null;
								gameObject = (GameObject)(object)networkObject;
								obj40 = gameObject3;
							}
							else
							{
								object obj39 = 4;
								NetworkSpawnFlags networkSpawnFlags = (NetworkSpawnFlags)0;
								NetworkRunner.OnBeforeSpawned onBeforeSpawned = null;
								PlayerRef? playerRef = (PlayerRef?)(object)(&quaternion4);
								quaternion5 = quaternion3;
								nint num4 = unchecked((nint)null);
								Vector3 vector3 = (Vector3)0;
								string text = null;
								gameObject = (GameObject)(object)networkObject;
								obj40 = null;
							}
							goto IL_0e84;
						}
					}
				}
			}
			Quaternion rotation2 = UnityEngine.Random.rotation;
			object obj41 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v88+E4]");
			bool flag24 = (nint)0 == 0;
			object obj42 = !flag24;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
			object obj43 = 0;
			vector2 = (Vector3)obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
			bool flag25 = (object)gameObject2 == null;
			Quaternion? quaternion6 = quaternion2;
			object obj45 = default;
			object obj44 = obj45;
			object obj47 = default;
			object obj46 = obj47;
			quaternion = quaternion5;
			gameObject = gameObject2;
			if (!flag25)
			{
				string text2 = gameObject2.name;
				UnityEngine.Object obj48 = default;
				bool flag26 = (object)obj48 == null;
				quaternion6 = quaternion2;
				obj44 = obj45;
				obj46 = obj47;
				quaternion = quaternion5;
				vector2 = (Vector3)0;
				gameObject = gameObject2;
				if (!flag26)
				{
					obj48.name = text2;
					quaternion6 = quaternion2;
					obj44 = obj45;
					obj46 = obj47;
					Vector3 vector3 = (Vector3)0;
					string text = text2;
					gameObject = gameObject2;
					obj40 = obj48;
					goto IL_0e84;
				}
			}
		}
		goto IL_0d56;
		IL_09fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
		object obj51 = default;
		object obj50 = obj51 & 1;
		if (obj50 == null)
		{
			goto IL_0b23;
		}
		Rigidbody rigidbody = default;
		bool flag27 = (object)rigidbody == null;
		object obj52 = !flag27;
		Rigidbody rigidbody2 = rigidbody;
		if (obj52 != null)
		{
			goto IL_0b10;
		}
		quaternion = quaternion5;
		vector = (Vector3)obj49;
		vector2 = (Vector3)(&rigidbody);
		goto IL_0d56;
		IL_0b10:
		rigidbody2.linearVelocity = (Vector3)0;
		goto IL_0b23;
		IL_0b23:
		GillaItem gillaItem = default;
		GillaItem result = gillaItem;
		goto IL_0e0f;
		IL_0d56:
		throw new NullReferenceException();
		IL_0e0f:
		return result;
		IL_0e84:
		object obj53 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v16+E4]");
		bool flag28 = (nint)0 == 0;
		object obj54 = !flag28;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag29 = obj40 == null;
		bool flag30 = !flag29;
		object obj55 = !flag30;
		result = null;
		if (obj55 == null)
		{
			bool flag31 = (object)obj40 == null;
			quaternion = quaternion5;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			if (!flag31)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5350]");
				object obj56 = 0;
				vector = (Vector3)obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
				object obj58 = default;
				object obj57 = obj58 & 1;
				if (obj57 == null)
				{
					goto IL_01e9;
				}
				bool flag32 = (object)gillaItem == null;
				quaternion = quaternion5;
				vector2 = (Vector3)(&gillaItem);
				if (!flag32)
				{
					object obj59 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v23+E4]");
					bool flag33 = (nint)0 == 0;
					object obj60 = !flag33;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(gillaItem.Body__BackingField != null))
					{
						goto IL_09fc;
					}
					bool flag34 = (object)gillaItem == null;
					quaternion = quaternion5;
					vector = (Vector3)0;
					vector2 = (Vector3)0;
					if (!flag34)
					{
						bool flag35 = (object)gillaItem.Body__BackingField == null;
						quaternion = quaternion5;
						vector = (Vector3)0;
						vector2 = (Vector3)0;
						if (!flag35)
						{
							if (gillaItem.Body__BackingField.isKinematic)
							{
								goto IL_09fc;
							}
							bool flag36 = (object)gillaItem == null;
							quaternion = quaternion5;
							vector = (Vector3)0;
							vector2 = (Vector3)0;
							if (!flag36)
							{
								rigidbody2 = gillaItem.Body__BackingField;
								bool flag37 = (object)gillaItem.Body__BackingField == null;
								quaternion = quaternion5;
								vector = (Vector3)0;
								vector2 = (Vector3)0;
								if (!flag37)
								{
									goto IL_0b10;
								}
							}
						}
					}
				}
			}
			goto IL_0d56;
		}
		goto IL_0e0f;
		IL_0b92:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag38 = vector2 != (Vector3)(object)1;
		quaternion = quaternion2;
		NullReferenceException ex3 = ex2;
		if (!flag38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			GameObject gameObject4 = default;
			nint num5 = (nint)gameObject4;
			vector2 = (Vector3)num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj62 = default;
			object obj61 = obj62 & 1;
			bool flag39 = obj61 == null;
			quaternion = quaternion2;
			gameObject = gameObject4;
			if (!flag39)
			{
				object obj63 = 0;
				gameObject = gameObject4;
				object obj65 = default;
				object obj64 = (object)(&obj65);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				bool flag40 = (object)gameObject4 == null;
				quaternion = quaternion2;
				if (flag40)
				{
					goto IL_0d56;
				}
				nint num6 = (nint)gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v785 @ X8_v28 (Il2CppClass<UnityEngine.GameObject>)+188] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string text3 = default;
				string text4 = default;
				string text5 = default;
				string message2 = text3 + (string)num3 + text4 + text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v61+E4]");
				bool flag41 = (nint)0 == 0;
				object obj66 = !flag41;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message2);
				PlayerRef? playerRef = (PlayerRef?)(object)0;
				nint num4 = (nint)text5;
				Vector3 vector3 = (Vector3)text4;
				string text = null;
				gameObject = (GameObject)(object)text5;
				obj40 = null;
				goto IL_0e84;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj67 = gameObject;
			vector2 = (Vector3)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			vector = (Vector3)0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		GillaItem result2 = default;
		return result2;
		IL_01e9:
		result = null;
		goto IL_0e0f;
	}

	private unsafe static GameObject PrefabOf(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_049c: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0088: Expected Obj, but got Ref
		//IL_04bf: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I
		//IL_0509: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I8
		//IL_0219: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
		GameObject result;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)name, out var value);
			bool flag3 = !flag2;
			System.__Canon _Canon = (System.__Canon)(object)name;
			object obj7 = (object)(&value);
			if (!flag3)
			{
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v39+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = (UnityEngine.Object)(object)value != null;
				bool flag6 = !flag5;
				_Canon = null;
				obj7 = 0;
				if (!flag6)
				{
					result = (GameObject)(object)value;
					goto IL_04aa;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
			object obj10 = 0;
			object obj11 = obj6;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v14+A0]");
			object obj13 = 0;
			UnityEngine.Object obj14 = (UnityEngine.Object)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = obj14 == null;
			bool flag9 = !flag8;
			object obj16 = !flag9;
			result = null;
			if (obj16 != null)
			{
				goto IL_04aa;
			}
			if ((object)obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X20_v10 (UnityEngine.Object)+20]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X20_v10 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X23_v4+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X23_v4+18]");
						object obj18 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X20_v10 (UnityEngine.Object)+20]");
						object obj19 = (nint)0 + (nint)32;
						object obj20 = 0;
						UnityEngine.Object obj21 = null;
						object obj22 = 0;
						while (true)
						{
							bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
							object obj23 = !flag10;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X26_v5+v84 @ X25_v6*8]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X26_v5+v84 @ X25_v6*8]");
								if ((nint)0 != 0)
								{
									object obj25 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v6+10]");
									obj14 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v21+E4]");
									bool flag11 = (nint)0 == 0;
									object obj26 = !flag11;
									if (obj26 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag12 = obj14 != null;
									bool flag13 = !flag12;
									obj21 = null;
									obj22 = 0;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v6+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v6+10]");
										string text = ((UnityEngine.Object)0).name;
										bool flag14 = text == name;
										bool flag15 = !flag14;
										object obj27 = !flag15;
										obj21 = (UnityEngine.Object)(object)name;
										obj22 = 0;
										if (obj27 != null)
										{
											goto IL_03d0;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X23_v4+18]");
								obj18 = 0;
								obj20++;
								object obj28 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X23_v4+18]");
								if ((nint)obj28 < 0)
								{
									continue;
								}
								goto IL_03c6;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							break;
						}
						goto IL_0464;
					}
				}
				goto IL_03c6;
			}
		}
		goto IL_0464;
		IL_0464:
		return (GameObject)(object)new NullReferenceException();
		IL_04aa:
		return result;
		IL_03d0:
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v29+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v29+A0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v25+18]");
		if ((nint)0 == 0)
		{
			goto IL_0464;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v25+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v6+10]");
		((Dictionary<System.__Canon, System.__Canon>)num).set_Item((System.__Canon)(object)name, (System.__Canon)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v6+10]");
		result = (GameObject)0;
		goto IL_04aa;
		IL_03c6:
		result = null;
		goto IL_04aa;
	}

	private void Show()
	{
		//IL_002e: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0127: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I4
		//IL_017c: Expected I4, but got I8
		//IL_019c: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_01fb: Expected I4, but got I8
		//IL_0215: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		if (shown == null)
		{
			return;
		}
		int count = Count;
		GameObject[] array = shown;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		int num = 0;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			int[] array2 = slotShows;
			if (num >= array2.Length)
			{
				return;
			}
			bool flag = num < array.Length;
			object obj2 = !flag;
			if (obj2 != null)
			{
				break;
			}
			object obj3 = obj;
			object obj4 = array + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+20]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			int num2 = 0;
			nint num3 = unchecked((nint)null);
			if (obj6 == null)
			{
				int num5;
				if (num < count)
				{
					int num4 = ThingAt(num);
					num5 = num4;
				}
				else
				{
					num5 = -1;
				}
				int[] array3 = slotShows;
				bool flag5 = num < array3.Length;
				object obj7 = !flag5;
				if (obj7 != null)
				{
					break;
				}
				object obj8 = array3 + num;
				int num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v13+20]");
				bool flag6 = (nint)num6 == 0;
				num2 = 0;
				if (!flag6)
				{
					int num7 = (int)(num5 & 0x80000000L);
					bool flag7 = num7 == 0;
					object obj9 = !flag7;
					num2 = 0;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+20]");
						Look((GameObject)0, num5, num);
						num2 = num5;
					}
				}
				bool flag8 = num5 < 0;
				int num8 = num5 ^ num5;
				int num9 = num5 & num8;
				bool flag9 = num9 < 0;
				bool flag10 = flag8 == flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+20]");
				bool activeSelf = ((GameObject)0).activeSelf;
				bool flag11 = flag10 == activeSelf;
				num3 = unchecked((nint)null);
				if (!flag11)
				{
					int num10 = ~num5;
					bool flag12 = (byte)(num10 >> 31) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+20]");
					((GameObject)0).SetActive(flag12);
					num2 = 0;
					num3 = (flag12 ? 1 : 0);
				}
			}
			array = shown;
			num++;
			bool flag13 = shown == null;
			object obj10 = !flag13;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void Look(GameObject slot, int thing, int i)
	{
		//IL_082f: Expected Obj, but got I
		//IL_0848: Expected F4, but got VT
		//IL_0852: Expected F4, but got VT
		//IL_0a89: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I
		//IL_0acb: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_08a1: Expected Obj, but got I
		//IL_007e: Expected F4, but got VT
		//IL_0088: Expected F4, but got VT
		//IL_00aa: Expected Obj, but got Ref
		//IL_0128: Expected I4, but got I8
		//IL_0142: Expected Obj, but got I4
		//IL_014b: Expected F4, but got I4
		//IL_00f2: Expected Obj, but got Ref
		//IL_08ea: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got I
		//IL_0911: Invalid comparison between F4 and I4
		//IL_017d: Expected F4, but got I4
		//IL_058d: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01e4: Expected F4, but got I4
		//IL_0940: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_021f: Expected F4, but got I
		//IL_035d: Expected Obj, but got I4
		//IL_04ae: Expected VT, but got I4
		//IL_0a07: Expected Obj, but got I
		//IL_0a4f: Expected Obj, but got I4
		//IL_0708: Invalid comparison between F8 and Obj
		//IL_04f2: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I4
		//IL_077c: Expected VT, but got I4
		//IL_0471: Expected Obj, but got I4
		//IL_09cc: Expected Obj, but got I4
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0a78: Expected VT, but got I4
		//IL_055e: Expected VT, but got I4
		//IL_0801: Expected VT, but got I4
		//IL_0801: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		bool flag = thing < 1;
		float num = (float)crystalScale;
		float num2 = (float)crystalScale;
		Material[] array = crystalMaterials;
		int num3 = i;
		int num4 = thing;
		GameObject gameObject = slot;
		UnityEngine.Object obj2 = crystalMesh;
		if (!flag)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v67+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = LookOf(thing, out var mesh, out var materials, out var size);
			bool flag4 = !flag3;
			num = (float)crystalScale;
			num2 = (float)crystalScale;
			array = crystalMaterials;
			num3 = (int)(&size);
			num4 = (int)(&materials);
			gameObject = (GameObject)(&mesh);
			obj2 = crystalMesh;
			if (!flag4)
			{
				num = size;
				num2 = size;
				array = materials;
				num3 = (int)(&size);
				num4 = (int)(&materials);
				gameObject = (GameObject)(&mesh);
				obj2 = mesh;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v5+A0]");
		object obj10 = 0;
		object obj11 = obj10;
		if (obj10 == null)
		{
			goto IL_080a;
		}
		int num5 = (int)(thing & 0x80000000L);
		bool flag6 = num5 == 0;
		object obj12 = !flag6;
		float num6 = 0f;
		if (obj12 == null)
		{
			float[] array2 = slotFit;
			bool flag7 = slotFit == null;
			num6 = 0f;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+18]");
				object obj13 = (nint)0 * (nint)i;
				object obj14 = thing + obj13;
				bool flag8 = (nint)obj14 < array2.Length;
				object obj15 = !flag8;
				bool flag9 = (nint)obj14 >= array2.Length;
				num6 = 0f;
				if (!flag9)
				{
					if (obj15 != null)
					{
						goto IL_0818;
					}
					object obj16 = (object)slotFit + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v45+20]");
					num6 = 0f;
				}
			}
		}
		float[] array3 = slotRoom;
		bool flag10 = slotRoom == null;
		object obj17 = 0;
		if (!flag10)
		{
			bool flag11 = array3.Length < i;
			object obj18 = !flag11;
			object obj19 = array3.Length - i;
			bool flag12 = obj19 == null;
			bool flag13 = array3.Length <= i;
			obj17 = 0;
			if (!flag13)
			{
				object obj20 = ~obj18;
				object obj21 = obj20 | flag12;
				if (obj21 != null)
				{
					goto IL_0818;
				}
				object obj22 = slotRoom + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+20]");
				obj17 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj23 = 0;
		double num11;
		object obj34 = default;
		double num9;
		double num12;
		double num10;
		if (!(num6 > 0f))
		{
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v43+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+C]");
			object obj26 = default;
			double num7 = 0.0 * (double)obj26;
			double num8 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7+14]");
			num9 = num8 * 0.0;
			bool flag15 = obj2 != null;
			bool flag16 = (nint)obj17 <= 0;
			num10 = num7;
			num11 = num;
			num12 = num7;
			if (!flag16)
			{
				bool flag17 = !flag15;
				num10 = num7;
				num11 = num;
				num12 = num7;
				if (!flag17)
				{
					if ((object)obj2 == null)
					{
						goto IL_080a;
					}
					Bounds bounds = ((Mesh)obj2).bounds;
					object obj28 = default;
					object obj27 = obj28 + obj28;
					object obj30 = default;
					object obj29 = obj30 + obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj31 = 0;
					object obj32 = obj31;
					double num13 = num7 * (double)obj27;
					double num14 = num9 * (double)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v50+E4]");
					bool flag18 = (nint)0 == 0;
					object obj33 = !flag18;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num15 = num13 * num13;
					double num16 = num14 * num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num17 = num15 + num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					num12 = num17 * 0.5;
					bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num12) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
					num10 = num7;
					num11 = 0.5;
					if (!flag19)
					{
						num12 = (double)obj17 / num12;
						num11 = num7 * (double)obj34;
						num9 *= num12;
						goto IL_0a5d;
					}
				}
			}
			goto IL_09da;
		}
		object obj35 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v39+A0]");
		object obj36 = 0;
		float num18 = ((!(num < num6)) ? num6 : num);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v40+C]");
		num11 = 0.0 * (double)obj34;
		float num19 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v40+14]");
		float num20 = num19 * 0f;
		num9 = num20;
		num12 = num18;
		goto IL_0a5d;
		IL_09da:
		if ((object)slot != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E8]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj39 = default;
			object obj38 = obj39 & 1;
			if (obj38 != null)
			{
				object obj40 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v37+E4]");
				bool flag20 = (nint)0 == 0;
				object obj41 = !flag20;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj2 != null)
				{
					MeshFilter meshFilter = default;
					if ((object)meshFilter == null)
					{
						goto IL_080a;
					}
					meshFilter.sharedMesh = (Mesh)obj2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51F0]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj45 = default;
			object obj44 = obj45 & 1;
			if (obj44 != null && array != null)
			{
				Renderer renderer = default;
				if ((object)renderer == null)
				{
					goto IL_080a;
				}
				renderer.sharedMaterials = array;
				obj43 = 0;
			}
			Transform transform = slot.transform;
			if ((object)transform != null)
			{
				transform.localScale = (Vector3)0;
				Vector3[] array4 = slotHome;
				if (slotHome != null)
				{
					bool flag21 = array4.Length < i;
					object obj46 = !flag21;
					object obj47 = array4.Length - i;
					bool flag22 = obj47 == null;
					if (array4.Length > i)
					{
						object obj48 = ~obj46;
						object obj49 = obj48 | flag22;
						if (obj49 != null)
						{
							goto IL_0818;
						}
						Vector3 vector = (Vector3)0;
					}
					else
					{
						Vector3 localPosition = transform.localPosition;
						Vector3 vector = (Vector3)0;
					}
					object obj50 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X0_v21+E4]");
					bool flag23 = (nint)0 == 0;
					object obj51 = !flag23;
					if (obj51 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj2 != null)
					{
						Quaternion localRotation = transform.localRotation;
						if ((object)obj2 == null)
						{
							goto IL_080a;
						}
						Bounds bounds2 = ((Mesh)obj2).bounds;
						Vector3 vector2 = (Quaternion)0 * (Vector3)0;
					}
					transform.localPosition = (Vector3)0;
					return;
				}
			}
		}
		goto IL_080a;
		IL_0a5d:
		num10 = num11;
		goto IL_09da;
		IL_080a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0818;
		IL_0818:
		throw new IndexOutOfRangeException();
	}

	private unsafe static bool LookOf(int thing, out Mesh mesh, out Material[] materials, out float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I
		//IL_06e9: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0080: Expected Obj, but got Ref
		//IL_019f: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I
		//IL_00df: Expected Obj, but got VT
		//IL_00fb: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0111: Expected Ref, but got VT
		//IL_023b: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_0780: Expected Obj, but got I4
		//IL_07b8: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got I4
		//IL_0644: Expected Ref, but got F4
		//IL_066e: Expected Obj, but got I4
		//IL_07db: Expected Obj, but got I
		//IL_06ba: Expected VT, but got Ref
		//IL_06ba: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+20]");
			bool flag2 = ((Dictionary<int, (System.__Canon, System.__Canon, float)>)0).TryGetValue(thing, out var value);
			bool flag3 = !flag2;
			object obj7 = (object)(&value);
			ref Mesh reference;
			ref Material[] reference2;
			ref float reference3;
			if (!flag3)
			{
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v79+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = (UnityEngine.Object)value != null;
				bool flag6 = !flag5;
				obj7 = 0;
				if (!flag6)
				{
					reference = ref *(Mesh*)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					reference2 = ref *(Material[]*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					reference3 = ref *(float*)null;
					goto IL_06bf;
				}
			}
			reference = ref *(Mesh*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			reference2 = ref *(Material[]*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			reference3 = ref *(float*)1065353216;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v19+A0]");
			object obj12 = 0;
			object obj13 = obj12;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v15+18]");
				bool flag8 = (nint)0 < (nint)thing;
				object obj14 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v15+18]");
				object obj15 = -thing;
				bool flag9 = obj15 == null;
				object obj16 = ~obj14;
				object obj17 = obj16 | flag9;
				if (obj17 == null)
				{
					object obj18 = thing * 24;
					object obj19 = obj12 + obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v16+28]");
					GameObject gameObject = PrefabOf((string)0);
					object obj20 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v17+E4]");
					bool flag10 = (nint)0 == 0;
					object obj21 = !flag10;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = gameObject != null;
					bool flag12 = !flag11;
					UnityEngine.Object obj22 = null;
					UnityEngine.Object obj23 = null;
					object obj24 = 0;
					if (!flag12)
					{
						if ((object)gameObject == null)
						{
							goto IL_06cd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53D0]");
						object obj25 = 0;
						obj24 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626234");
						UnityEngine.Object obj26 = default;
						obj22 = obj26;
						obj23 = (UnityEngine.Object)1;
					}
					object obj27 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v26+E4]");
					bool flag13 = (nint)0 == 0;
					object obj28 = !flag13;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = obj22 != null;
					bool flag15 = !flag14;
					UnityEngine.Object obj29 = null;
					UnityEngine.Object obj30 = null;
					if (!flag15)
					{
						if ((object)obj22 == null)
						{
							goto IL_06cd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B8]");
						object obj31 = 0;
						obj30 = (UnityEngine.Object)obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						UnityEngine.Object obj32 = default;
						obj29 = obj32;
					}
					object obj33 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v31+E4]");
					bool flag16 = (nint)0 == 0;
					object obj34 = !flag16;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag17 = obj22 == null;
					bool flag18 = !flag17;
					object obj35 = !flag18;
					if (obj35 == null)
					{
						object obj36 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v37+E4]");
						bool flag19 = (nint)0 == 0;
						object obj37 = !flag19;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag20 = obj29 == null;
						bool flag21 = !flag20;
						object obj38 = !flag21;
						if (obj38 == null)
						{
							if ((object)obj22 != null)
							{
								Mesh sharedMesh = ((MeshFilter)obj22).sharedMesh;
								object obj39 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v24+E4]");
								bool flag22 = (nint)0 == 0;
								object obj40 = !flag22;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (sharedMesh == null)
								{
									goto IL_0525;
								}
								Mesh sharedMesh2 = ((MeshFilter)obj22).sharedMesh;
								reference = ref *(Mesh*)sharedMesh2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								if ((object)obj29 != null)
								{
									Material[] sharedMaterials = ((Renderer)obj29).sharedMaterials;
									reference2 = ref *(Material[]*)sharedMaterials;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Transform transform = ((Component)obj22).transform;
									if ((object)transform != null)
									{
										Vector3 lossyScale = transform.lossyScale;
										if ((object)gameObject != null)
										{
											Transform transform2 = gameObject.transform;
											if ((object)transform2 != null)
											{
												Vector3 lossyScale2 = transform2.lossyScale;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
												object obj41 = default;
												float num = (float)obj41 / (float)obj41;
												reference3 = ref *(float*)num;
												object obj42 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v61+E4]");
												bool flag23 = (nint)0 == 0;
												object obj43 = !flag23;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj42 = obj;
													num = size;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v61+A0]");
												object obj44 = 0;
												(System.__Canon, System.__Canon, float) tuple = ((System.__Canon)(object)mesh, (System.__Canon)(object)materials, num);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v27+20]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v27+20]");
													object obj45 = default;
													((Dictionary<int, (System.__Canon, System.__Canon, float)>)0).set_Item(thing, ((System.__Canon, System.__Canon, float))(&obj45));
													goto IL_06bf;
												}
											}
										}
									}
								}
							}
							goto IL_06cd;
						}
					}
					goto IL_0525;
				}
				goto IL_06db;
			}
		}
		goto IL_06cd;
		IL_06bf:
		return true;
		IL_06cd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06db;
		IL_06db:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0525:
		return false;
	}

	private static void Buzz(XRNode node, float strength, float seconds)
	{
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		bool flag = inputDevice.SendHapticImpulse(0u, strength, seconds);
	}

	public void FillForTest(string[] labels)
	{
		//IL_0044: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I8
		//IL_00d0: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028b: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		if (!Yours)
		{
			return;
		}
		List<byte> list = inside;
		if (inside != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (System.Collections.Generic.List`1<System.Byte>)+1C]");
			object obj = (nint)0 + (nint)1;
			_ = 0;
			if (labels != null)
			{
				if (labels.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
				object obj3 = 0;
				object obj4 = labels.Length & 0xFFFFFFFFL;
				string[] array = labels;
				object obj5 = 0;
				while (true)
				{
					IL_04b2:
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = (object)labels + obj5;
					object obj8 = 32;
					byte b = 0;
					while (true)
					{
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v12+E4]");
						bool flag2 = (nint)0 == 0;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj9 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v12+A0]");
						object obj11 = 0;
						object obj12 = obj11;
						if (obj11 == null)
						{
							break;
						}
						byte b2 = b;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v17+18]");
						nint num4;
						if ((nint)(int)b2 < (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v12+E4]");
							bool flag3 = (nint)0 == 0;
							object obj13 = !flag3;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj14 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v23+A0]");
								object obj15 = 0;
								obj12 = obj15;
								if (obj15 == null)
								{
									break;
								}
							}
							byte b3 = b;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v17+18]");
							bool flag4 = (nint)(int)b3 < (nint)0;
							object obj16 = !flag4;
							if (obj16 != null)
							{
								goto end_IL_04b2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v17+v73 @ X26_v7]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+20]");
							if (!((string)num == (string)0))
							{
								goto IL_026a;
							}
							List<byte> list2 = inside;
							if (inside == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+18]");
							if ((nint)0 >= (nint)holds)
							{
								goto IL_026a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+10]");
							object obj17 = 0;
							object obj18 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+1C]");
							object obj19 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+18]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v14+18]");
							bool flag5 = num2 < 0;
							object obj20 = !flag5;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+18]");
								obj18 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+10]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18 (System.Collections.Generic.List`1<System.Byte>)+18]");
								object obj21 = num3 + 0;
								num4 = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+20]");
								array = (string[])0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v5+20]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v20+A8]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v21+70]");
								num4 = 0;
								inside.AddWithResize(b);
								array = (string[])b;
							}
						}
						obj4 = labels.Length;
						obj5++;
						if ((nint)obj5 >= labels.Length)
						{
							return;
						}
						goto IL_04b2;
						IL_026a:
						b++;
						obj8 += 24;
						num4 = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v10+20]");
						array = (string[])0;
					}
					goto IL_0409;
					continue;
					end_IL_04b2:
					break;
				}
				goto IL_0417;
			}
		}
		goto IL_0409;
		IL_0409:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0417;
		IL_0417:
		throw new IndexOutOfRangeException();
	}

	public void FillForTest(int n)
	{
		//IL_002a: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		if (!Yours)
		{
			return;
		}
		List<byte> list = inside;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4 (System.Collections.Generic.List`1<System.Byte>)+1C]");
		object obj = (nint)0 + (nint)1;
		_ = 0;
		if (n < 1)
		{
			return;
		}
		object obj2 = 0;
		while ((nint)obj2 < holds)
		{
			List<byte> list2 = inside;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.Collections.Generic.List`1<System.Byte>)+10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.Collections.Generic.List`1<System.Byte>)+1C]");
			object obj4 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+18]");
			bool flag = num < 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
				object obj6 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8 (System.Collections.Generic.List`1<System.Byte>)+18]");
				object obj7 = obj3 + 0;
				_ = 0;
			}
			else
			{
				list2.AddWithResize((byte)0);
			}
			obj2++;
			if (n == (nint)obj2)
			{
				break;
			}
		}
	}

	public GillaBackpack()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01d1: Expected F4, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b1: Expected VT, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_024c: Expected VT, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53F8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C328]");
		depth = 0f;
		overMouth = 0.08f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 136;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 144;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 152;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F490]");
		onBack = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D430]");
		_ = 0;
		shoulderAhead = 0.06f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<byte> list = default;
		list._002Ector();
		object obj14 = this + 248;
		obj14 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = obj14 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = obj14 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v16+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v17+C]");
		crystalScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v17+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array = default;
		hinted = array;
		object obj20 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj21 = this + 320;
		handedIn = (HashSet<GillaItem>)(object)hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaBackpack()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5400]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5410]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5420]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5430]");
		object obj5 = 0;
		(string, string, int)[] array = MakeThings();
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v3+A0]");
		object obj7 = 0;
		obj7 = array;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+A0]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary = default;
		dictionary._002Ector();
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+A0]");
		object obj12 = (nint)0 + (nint)16;
		obj12 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v8+A0]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, (System.__Canon, System.__Canon, float)> dictionary3 = default;
		dictionary3._002Ector();
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9+A0]");
		object obj16 = (nint)0 + (nint)32;
		obj16 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5440]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5448]");
		object obj2 = 0;
		Wearer = _Wearer;
		Held = _Held;
		NetworkArray<byte> networkArray = Inside;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6FA8");
	}

	public override void CopyStateToBackingFields()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5450]");
		object obj = 0;
		PlayerRef wearer = Wearer;
		_Wearer = wearer;
		byte held = Held;
		_Held = held;
		NetworkArray<byte> networkArray = Inside;
		object obj2 = this + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D60C0");
	}

	protected unsafe static void RPC_PutIn_0040Invoker3846818451([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Expected VT, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_0179: Expected VT, but got Ref
		//IL_0179: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F0]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaBackpack gillaBackpack = (GillaBackpack)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4970]");
			object obj11 = 0;
			object obj12 = obj11;
			nint num = (nint)gillaBackpack;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v21 (Il2CppClass<GillaBackpack>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			bool flag2 = num2 < 0;
			object obj13 = !flag2;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v21 (Il2CppClass<GillaBackpack>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
				object obj15 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v24-8]");
				if (0 == (nint)obj12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
					byte thing = default;
					object obj16 = default;
					((GillaBackpack)0).RPC_PutIn(thing, (RpcInfo)(&obj16));
					return;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		throw new NullReferenceException();
	}
}
