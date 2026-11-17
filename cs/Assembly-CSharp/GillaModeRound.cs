using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaModeRound : NetworkBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly GillaModeRound._003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__4_0;

		public static Action<string> _003C_003E9__4_1;

		public static Action<string> _003C_003E9__4_2;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25F0]");
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

		internal void _003CAskOnce_003Eb__4_0(string _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2600]");
			object message = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}

		internal void _003CAskOnce_003Eb__4_1(string _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2608]");
			object message = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}

		internal void _003CAskOnce_003Eb__4_2(string _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			//IL_008b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25F8]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2610]");
			object message = 0;
			PlayerPrefs.SetInt((string)key, 1);
			PlayerPrefs.Save();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly GillaModeRound._003C_003Ec _003C_003E9;

		public static Func<float> _003C_003E9__116_0;

		public static Func<double> _003C_003E9__117_0;

		public static Func<PlayerRef, PlayerRef> _003C_003E9__129_2;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A8]");
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

		internal float _003CBegin_003Eb__116_0()
		{
			return UnityEngine.Random.value;
		}

		internal double _003CPickMonsters_003Eb__117_0()
		{
			float value = UnityEngine.Random.value;
			return value;
		}

		internal PlayerRef _003CDrawMany_003Eb__129_2(PlayerRef p)
		{
			return p;
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public PlayerRef besides;

		public GillaModeRound _003C_003E4__this;

		internal bool _003CHuntersIn_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00da: Expected I4, but got Obj
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected VT, but got Unknown
			object obj = kv & 0xFF00000000L;
			if ((long)obj == 12884901888L)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (besides != (PlayerRef)kv)
				{
					if ((object)_003C_003E4__this != null)
					{
						PlayerRef p = (PlayerRef)(kv & 0xFFFFFFFFL);
						return _003C_003E4__this.InRoom(p);
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public int[] counts;

		public int most;

		internal bool _003CPickMode_003Eb__0(int i)
		{
			//IL_00dc: Expected I4, but got Obj
			//IL_0044: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I4
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I
			int[] array = counts;
			if (counts != null)
			{
				bool flag = array.Length < i;
				object obj = !flag;
				object obj2 = array.Length - i;
				bool flag2 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag2;
				if (obj4 == null)
				{
					object obj5 = counts + i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
					object obj6 = -most;
					return obj6 == null;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public int mode;

		public GillaModeRound _003C_003E4__this;

		internal bool _003CModeVotesFor_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_000e: Expected Obj, but got VT
			//IL_0070: Expected I4, but got Obj
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected VT, but got Unknown
			object obj = kv >> 32;
			if (mode == (nint)obj)
			{
				if ((object)_003C_003E4__this != null)
				{
					PlayerRef p = (PlayerRef)(kv & 0xFFFFFFFFL);
					return _003C_003E4__this.InRoom(p);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public int map;

		public GillaModeRound _003C_003E4__this;

		internal bool _003CVotesFor_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_000e: Expected Obj, but got VT
			//IL_0070: Expected I4, but got Obj
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected VT, but got Unknown
			object obj = kv >> 32;
			if (map == (nint)obj)
			{
				if ((object)_003C_003E4__this != null)
				{
					PlayerRef p = (PlayerRef)(kv & 0xFFFFFFFFL);
					return _003C_003E4__this.InRoom(p);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public int[] counts;

		public int most;

		internal bool _003CMapChosen_003Eb__0(int i)
		{
			//IL_00dc: Expected I4, but got Obj
			//IL_0044: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I4
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I
			int[] array = counts;
			if (counts != null)
			{
				bool flag = array.Length < i;
				object obj = !flag;
				object obj2 = array.Length - i;
				bool flag2 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag2;
				if (obj4 == null)
				{
					object obj5 = counts + i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
					object obj6 = -most;
					return obj6 == null;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public int n;

		public int k;

		internal double _003CChances_003Eb__0(int w)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Weight(w, n, k);
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public Dictionary<PlayerRef, int> waited;

		public int n;

		public int k;

		public List<PlayerRef> picked;

		public HashSet<PlayerRef> due;

		public Dictionary<PlayerRef, int> next;

		public int dueAt;

		internal int _003CDrawMany_003Eb__0(PlayerRef p)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected VT, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef p2 = (PlayerRef)(p & 0xFFFFFFFFL);
			return Waited((IDictionary<PlayerRef, int>)waited, p2);
		}

		internal double _003CDrawMany_003Eb__1(int w)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Weight(w, n, k);
		}

		internal int _003CDrawMany_003Eb__3(PlayerRef p)
		{
			//IL_013b: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			//IL_0027: Expected Obj, but got I
			//IL_0075: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected VT, but got Unknown
			//IL_00ef: Expected Obj, but got I4
			if ((object)picked != null)
			{
				PlayerRef item = (PlayerRef)(p & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E80]");
				object obj = 0;
				if (picked.Contains(item))
				{
					return 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef p2 = (PlayerRef)(p & 0xFFFFFFFFL);
				int num = Waited((IDictionary<PlayerRef, int>)waited, p2);
				object obj5 = num + 1;
				if ((nint)obj5 >= 127)
				{
					return 127;
				}
				return num + 1;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool _003CDrawMany_003Eb__4(PlayerRef p)
		{
			//IL_018a: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected VT, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected VT, but got Unknown
			//IL_011a: Expected Obj, but got I4
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected I4, but got Unknown
			if ((object)picked != null)
			{
				PlayerRef item = (PlayerRef)(p & 0xFFFFFFFFL);
				if (picked.Contains(item))
				{
					return false;
				}
				if (due != null)
				{
					PlayerRef item2 = (PlayerRef)(p & 0xFFFFFFFFL);
					if (due.Contains(item2))
					{
						return true;
					}
					if ((object)next != null)
					{
						PlayerRef key = (PlayerRef)(p & 0xFFFFFFFFL);
						int num = next.get_Item(key);
						object obj = num - dueAt;
						bool flag = (nint)obj < 0;
						int num2 = num ^ dueAt;
						int num3 = num ^ obj;
						int num4 = num2 & num3;
						bool flag2 = num4 < 0;
						return flag == flag2;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public const byte Vote = default(byte);

	public const byte Hunt = default(byte);

	public const byte Over = default(byte);

	public const byte ModePick = default(byte);

	public const byte Alive = default(byte);

	public const byte Dead = default(byte);

	public const byte Hunter = default(byte);

	public const byte MonsterWins = default(byte);

	public const byte ApesWin = default(byte);

	public const int Maps = default(int);

	public const byte OneMonster = default(byte);

	public const byte Infection = default(byte);

	public const byte TwoMonsters = default(byte);

	public const int Modes = default(int);

	public static int TwoMonstersLeast;

	public static float VoteSeconds;

	public static float HuntSeconds;

	public static float OverSeconds;

	public static float ModeSeconds;

	public static float BigHuntSeconds;

	public static int BigHunt;

	public static int LeastPlayers;

	public static bool HeldForTest;

	public static int TwoMonstersFrom;

	public const int MostMonsters = default(int);

	private byte _Phase;

	private float _VoteEnds;

	private SerializableDictionary<PlayerRef, byte> _Votes;

	private byte _Map;

	private PlayerRef _Monster;

	private int _Round;

	private float _HuntEnds;

	private float _OverEnds;

	private SerializableDictionary<PlayerRef, byte> _Players;

	private byte _Winner;

	private SerializableDictionary<PlayerRef, byte> _Turns;

	private byte _Mode;

	private float _ModeEnds;

	private SerializableDictionary<PlayerRef, byte> _ModeVotes;

	private byte _StartApes;

	private byte _StartMonsters;

	private static readonly GillaNetWatch.Single<GillaModeRound> rounds;

	public const int NewcomerWait = default(int);

	public const int DueBit = default(int);

	public const int MostWait = default(int);

	public unsafe byte Phase
	{
		get
		{
			//IL_0080: Expected I4, but got Obj
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
				return (byte)(int)ex2;
			}
			return (byte)ptr;
		}
		set
		{
			if (Ptr != null)
			{
				int* ptr = (int*)(int)value;
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

	public unsafe float VoteEnds
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+4]");
				return 0f;
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

	public unsafe NetworkDictionary<PlayerRef, byte> Votes
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0058: Expected VT, but got I4
			//IL_0089: Expected I4, but got Obj
			//IL_0084: Expected native int or pointer, but got VT
			//IL_00e0: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E107D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				int* ptr = Ptr + 2;
				NetworkDictionary<PlayerRef, byte> networkDictionary = (NetworkDictionary<PlayerRef, byte>)0;
				_ = 0;
				_ = 0;
				_ = 0;
				IElementReaderWriter<PlayerRef> keyReaderWriter = default;
				IElementReaderWriter<byte> valReaderWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkDictionary, new NetworkDictionary<PlayerRef, byte>(ptr, (int)typeof(_0021_00210), keyReaderWriter, valReaderWriter));
				return networkDictionary;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkDictionary<PlayerRef, byte>)ex2;
		}
	}

	public unsafe byte Map
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1E4]");
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

	public unsafe PlayerRef Monster
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1E8]");
				return (PlayerRef)0;
			}
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

	public unsafe int Round
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1EC]");
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
			return (int)ex2;
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

	public unsafe float HuntEnds
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1F0]");
				return 0f;
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

	public unsafe float OverEnds
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1F4]");
				return 0f;
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

	public unsafe NetworkDictionary<PlayerRef, byte> Players
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0058: Expected VT, but got I4
			//IL_0089: Expected I4, but got Obj
			//IL_0084: Expected native int or pointer, but got VT
			//IL_00e0: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E107D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				int* ptr = Ptr + 126;
				NetworkDictionary<PlayerRef, byte> networkDictionary = (NetworkDictionary<PlayerRef, byte>)0;
				_ = 0;
				_ = 0;
				_ = 0;
				IElementReaderWriter<PlayerRef> keyReaderWriter = default;
				IElementReaderWriter<byte> valReaderWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkDictionary, new NetworkDictionary<PlayerRef, byte>(ptr, (int)typeof(_0021_00210), keyReaderWriter, valReaderWriter));
				return networkDictionary;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkDictionary<PlayerRef, byte>)ex2;
		}
	}

	public unsafe byte Winner
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+3D4]");
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

	public unsafe NetworkDictionary<PlayerRef, byte> Turns
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0058: Expected VT, but got I4
			//IL_0089: Expected I4, but got Obj
			//IL_0084: Expected native int or pointer, but got VT
			//IL_00e0: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E107D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				int* ptr = Ptr + 246;
				NetworkDictionary<PlayerRef, byte> networkDictionary = (NetworkDictionary<PlayerRef, byte>)0;
				_ = 0;
				_ = 0;
				_ = 0;
				IElementReaderWriter<PlayerRef> keyReaderWriter = default;
				IElementReaderWriter<byte> valReaderWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkDictionary, new NetworkDictionary<PlayerRef, byte>(ptr, (int)typeof(_0021_00210), keyReaderWriter, valReaderWriter));
				return networkDictionary;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkDictionary<PlayerRef, byte>)ex2;
		}
	}

	public unsafe byte Mode
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+5B4]");
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

	public unsafe float ModeEnds
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+5B8]");
				return 0f;
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

	public unsafe NetworkDictionary<PlayerRef, byte> ModeVotes
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0058: Expected VT, but got I4
			//IL_0089: Expected I4, but got Obj
			//IL_0084: Expected native int or pointer, but got VT
			//IL_00e0: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E107D0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				int* ptr = Ptr + 367;
				NetworkDictionary<PlayerRef, byte> networkDictionary = (NetworkDictionary<PlayerRef, byte>)0;
				_ = 0;
				_ = 0;
				_ = 0;
				IElementReaderWriter<PlayerRef> keyReaderWriter = default;
				IElementReaderWriter<byte> valReaderWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkDictionary, new NetworkDictionary<PlayerRef, byte>(ptr, (int)typeof(_0021_00210), keyReaderWriter, valReaderWriter));
				return networkDictionary;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkDictionary<PlayerRef, byte>)ex2;
		}
	}

	public unsafe byte StartApes
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+798]");
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

	public unsafe byte StartMonsters
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+79C]");
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

	public static GillaModeRound Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27C8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F864");
				GillaModeRound result = default;
				return result;
			}
			return (GillaModeRound)(object)new NullReferenceException();
		}
	}

	public bool Live
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

	public float Now
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I4
			//IL_006b: Expected F4, but got I4
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
			{
				return ((SimulationBehaviour)this)._runner.SimulationTime;
			}
			return 0f;
		}
	}

	public bool Enough
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I4
			//IL_011c: Expected I4, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I
			//IL_0179: Expected Obj, but got I
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected I4, but got Unknown
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
			{
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
					object obj4 = 0;
					int num = Enumerable.Count(activePlayers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v8+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v8+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v9+1C]");
					object obj9 = (nint)num - (nint)0;
					bool flag3 = (nint)obj9 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v9+1C]");
					int num2 = (int)((nint)num ^ (nint)0);
					int num3 = num ^ obj9;
					int num4 = num2 & num3;
					bool flag4 = num4 < 0;
					return flag3 == flag4;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public byte NextMode
	{
		get
		{
			//IL_00ca: Expected Obj, but got I4
			//IL_00d8: Expected Obj, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0297: Expected I4, but got Obj
			//IL_0125: Expected Obj, but got I4
			//IL_017a: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I4
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected Obj, but got Unknown
			int[] array;
			int num2;
			if (Live)
			{
				byte phase = Phase;
				int num = phase & 0xFF;
				if (num == 3)
				{
					array = ModeCounts();
					num2 = Enumerable.Max(array);
					if (num2 < 1)
					{
						goto IL_026d;
					}
					byte mode = Mode;
					int num3 = mode & 0xFF;
					bool flag = num3 < 2;
					object obj = !flag;
					object obj2 = num3 - 2;
					bool flag2 = obj2 == null;
					object obj3 = ~obj;
					object obj4 = obj3 | flag2;
					if (obj4 == null)
					{
						bool flag3 = array == null;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							goto IL_01ff;
						}
					}
					else
					{
						byte mode2 = Mode;
						if (array != null)
						{
							bool flag4 = array.Length < mode2;
							object obj6 = !flag4;
							object obj7 = array.Length - mode2;
							bool flag5 = obj7 == null;
							object obj8 = ~obj6;
							object obj9 = obj8 | flag5;
							if (obj9 == null)
							{
								object obj10 = array + mode2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v11+20]");
								if ((nint)0 == num2)
								{
									goto IL_01f0;
								}
								goto IL_01ff;
							}
							goto IL_027b;
						}
					}
					goto IL_0289;
				}
			}
			goto IL_01f0;
			IL_01f0:
			return Mode;
			IL_026d:
			byte b = 0;
			goto IL_0297;
			IL_01ff:
			object obj11 = array + 32;
			b = 0;
			while (array.Length != b)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v5+returnVal2 @ X0_v10 (System.Byte)*4]");
				if ((nint)0 != num2)
				{
					b++;
					if (b != 3)
					{
						continue;
					}
					goto IL_026d;
				}
				goto IL_0297;
			}
			goto IL_027b;
			IL_027b:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			goto IL_0289;
			IL_0289:
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2;
			IL_0297:
			return b;
		}
	}

	public float HuntLength
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0128: Expected Obj, but got I4
			//IL_0146: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I4
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got Unknown
			//IL_005e: Expected Obj, but got I4
			//IL_0198: Expected F4, but got Obj
			//IL_00e5: Expected Obj, but got I
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_008e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2840]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj2 = 0;
			NetworkDictionary<PlayerRef, byte> players = Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B144");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v4+18]");
			object obj6 = default;
			object obj9;
			if ((nint)obj6 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v12+A0]");
					obj5 = 0;
				}
				obj9 = obj5 + 8;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+A0]");
					obj5 = 0;
				}
				obj9 = obj5 + 20;
			}
			return (float)obj9;
		}
	}

	public bool TwoMonstersOpen
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_014d: Expected Obj, but got I4
			//IL_0123: Expected I4, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I4
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
			{
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
					object obj4 = 0;
					int players = Enumerable.Count(activePlayers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v8+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return ModeAllowed(2, players);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public int MonstersNext
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I4
			//IL_012c: Expected I4, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I4
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
			if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
			{
				byte nextMode = NextMode;
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
					object obj4 = 0;
					int players = Enumerable.Count(activePlayers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return MonstersFor(nextMode, players);
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return 1;
		}
	}

	public static int MonstersFor(int players)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected I4, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected I4, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected I4, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+24]");
		object obj5 = -players;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+24]");
		int num = (int)((nint)0 ^ (nint)players);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+24]");
		object obj6 = 0 ^ obj5;
		int num2 = num & obj6;
		bool flag4 = num2 < 0;
		bool flag5 = flag2 == flag4;
		object obj7 = !flag5;
		object obj8 = obj7 | flag3;
		object obj9 = ~obj8;
		int num3 = ((obj9 != null) ? 1 : (1 + 1));
		object obj10 = players - 1;
		bool flag6 = (nint)obj10 < 0;
		bool flag7 = obj10 == null;
		int num4 = players ^ 1;
		int num5 = players ^ obj10;
		int num6 = num4 & num5;
		bool flag8 = num6 < 0;
		bool flag9 = flag6 == flag8;
		object obj11 = !flag7;
		object obj12 = flag9 & obj11;
		object obj13 = ~obj12;
		int num7 = ((obj13 != null) ? 1 : players);
		object obj14 = num3 - num7;
		bool flag10 = (nint)obj14 < 0;
		int num8 = num3 ^ num7;
		int num9 = num3 ^ obj14;
		int num10 = num8 & num9;
		bool flag11 = num10 < 0;
		bool flag12 = flag10 == flag11;
		object obj15 = !flag12;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			return num3;
		}
		return num7;
	}

	public static int MonstersFor(byte mode, int players)
	{
		//IL_017c: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected I4, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected I4, but got Unknown
		//IL_0389: Expected Obj, but got I4
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected I4, but got Unknown
		//IL_04b5: Expected Obj, but got I4
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected I4, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I4
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected I4, but got Unknown
		//IL_041d: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected I4, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		int num;
		switch (mode & 0xFF)
		{
		case 1:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num4 = MonstersFor(players);
			object obj13 = players - 1;
			bool flag7 = (nint)obj13 < 0;
			bool flag8 = obj13 == null;
			int num5 = players ^ 1;
			int num6 = players ^ obj13;
			int num7 = num5 & num6;
			bool flag9 = num7 < 0;
			bool flag10 = flag7 == flag9;
			object obj14 = !flag8;
			object obj15 = flag10 & obj14;
			object obj16 = ~obj15;
			int num8 = ((obj16 != null) ? 1 : players);
			object obj17 = num4 - num8;
			bool flag11 = (nint)obj17 < 0;
			int num9 = num4 ^ num8;
			int num10 = num4 ^ obj17;
			int num11 = num9 & num10;
			bool flag12 = num11 < 0;
			bool flag13 = flag11 == flag12;
			object obj18 = !flag13;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				num8 = num4;
			}
			if (num4 >= 1)
			{
				return num8;
			}
			return 1;
		}
		case 2:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+A0]");
			object obj4 = 0;
			object obj5 = obj4 - players;
			bool flag2 = (nint)obj5 < 0;
			bool flag3 = obj5 == null;
			int num2 = obj4 ^ players;
			object obj6 = obj4 ^ obj5;
			int num3 = num2 & obj6;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag5;
			object obj8 = obj7 | flag3;
			object obj9 = ~obj8;
			num = ((obj9 != null) ? 1 : (1 + 1));
			break;
		}
		default:
			num = 1;
			break;
		}
		object obj20 = players - 1;
		bool flag14 = (nint)obj20 < 0;
		bool flag15 = obj20 == null;
		int num12 = players ^ 1;
		int num13 = players ^ obj20;
		int num14 = num12 & num13;
		bool flag16 = num14 < 0;
		bool flag17 = flag14 == flag16;
		object obj21 = !flag15;
		object obj22 = flag17 & obj21;
		object obj23 = ~obj22;
		int num15 = ((obj23 != null) ? 1 : players);
		object obj24 = num - num15;
		bool flag18 = (nint)obj24 < 0;
		int num16 = num ^ num15;
		int num17 = num ^ obj24;
		int num18 = num16 & num17;
		bool flag19 = num18 < 0;
		bool flag20 = flag18 == flag19;
		object obj25 = !flag20;
		object obj26 = ~obj25;
		if (obj26 == null)
		{
			return num;
		}
		return num15;
	}

	public static bool ModeAllowed(int mode, int players)
	{
		//IL_00ba: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected I4, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected I4, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected I4, but got Unknown
		bool flag = mode < 2;
		object obj = !flag;
		object obj2 = mode - 2;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			return false;
		}
		if (mode == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v5+A0]");
			object obj8 = 0;
			object obj9 = obj8 - players;
			bool flag4 = (nint)obj9 < 0;
			bool flag5 = obj9 == null;
			int num = obj8 ^ players;
			object obj10 = obj8 ^ obj9;
			int num2 = num & obj10;
			bool flag6 = num2 < 0;
			bool flag7 = flag4 == flag6;
			object obj11 = !flag7;
			return (byte)((obj11 | flag5) ? 1 : 0) != 0;
		}
		return true;
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
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
		_ = 1092616192;
		_ = 12;
		_ = 0;
		obj4 = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2660]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F818");
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F668");
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F774");
	}

	public unsafe void RPC_Vote(byte map, RpcInfo info = default(RpcInfo))
	{
		//IL_065e: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I4
		//IL_06c7: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_04eb: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got VT
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_024c: Expected VT, but got I8
		//IL_0267: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got VT
		//IL_02a4: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0312: Expected VT, but got Ref
		//IL_0322: Expected Obj, but got Ref
		//IL_032b: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got Ref
		//IL_033b: Expected I4, but got VT
		//IL_015a: Expected Obj, but got I4
		//IL_015f: Expected VT, but got Obj
		//IL_0168: Expected VT, but got I4
		//IL_05e7: Expected Ref, but got VT
		//IL_05ff: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got VT
		//IL_035a: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I
		//IL_02ca: Expected VT, but got Obj
		//IL_02ea: Expected VT, but got I4
		//IL_0187: Invalid comparison between VT and I4
		//IL_0378: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I4
		//IL_0634: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I
		//IL_01a4: Invalid comparison between VT and I4
		//IL_01b6: Expected Obj, but got I4
		//IL_01bb: Expected VT, but got Obj
		//IL_01c4: Expected VT, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_03e0: Expected VT, but got Obj
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected I4, but got Unknown
		//IL_041b: Expected Obj, but got I4
		//IL_04ab: Expected native int or pointer, but got VT
		//IL_04b8: Expected native int or pointer, but got VT
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected I4, but got Unknown
		//IL_046a: Expected VT, but got I4
		//IL_046a: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj5 = default;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo;
		NullReferenceException ex;
		object obj12;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			object obj3 = obj2;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(1408835608u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj5 = rpcInvokeInfo >> 32;
				object obj6 = obj5 - 522;
				bool flag4 = (nint)obj6 < 2;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				PlayerRef playerRef;
				object obj9;
				PlayerRef playerRef2;
				if (obj8 == null && (nint)obj5 != 518)
				{
					bool flag5 = (nint)obj5 != 524;
					obj9 = 0;
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag5)
					{
						goto IL_027c;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj9 = 0;
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag6)
						{
							goto IL_027c;
						}
					}
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v67+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27E8]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj9 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_027c;
			}
			ex = new NullReferenceException();
			rpcInfo = info;
			obj12 = 0;
			num = bytePayloadSize;
			goto IL_054a;
		}
		goto IL_066d;
		IL_0340:
		nint num2 = default;
		bool flag8 = num2 == 0;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			goto IL_054a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v38+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v38+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v17+18]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v17+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27E0]");
			object obj19 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj19);
			object obj20 = obj2;
			int num3 = num | obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v22+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ X27_v4+18] (should have been resolved before IL gen)");
			IntPtr intPtr = default;
			num2 = intPtr;
		}
		bool flag11 = num == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num2;
			goto IL_066d;
		}
		return;
		IL_0747:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_027c:
		object obj23 = rpcInvokeInfo >> 32;
		bool flag12 = obj23 == null;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj25 = 0;
			PlayerRef playerRef = (PlayerRef)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num4 = rpcBuilder2.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
		}
		rpcBuilder2.Dispose();
		num2 = 0;
		object obj26 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		rpcInfo = (RpcInfo)rpcInvokeInfo2;
		networkRunner = (NetworkRunner)(&writer);
		obj12 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		num = (int)rpcInvokeInfo;
		goto IL_0340;
		IL_054a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj27;
		OutOfMemoryException ex2;
		if ((nint)obj12 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj27 = obj26;
			num2 = 1;
		}
		else
		{
			bool flag13 = (nint)obj12 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0747;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj28 = default;
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj28;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag14 = obj27 == null;
		obj12 = 0;
		ex = (NullReferenceException)rpcBuilder3;
		if (flag14)
		{
			goto IL_0340;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj12 = 0;
		goto IL_0747;
		IL_066d:
		byte phase = Phase;
		int num5 = map & 0xFF;
		bool flag15 = num5 < 2;
		object obj29 = !flag15;
		object obj30 = num5 - 2;
		bool flag16 = obj30 == null;
		object obj31 = !flag16;
		object obj32 = obj29 & obj31;
		if (obj32 == null)
		{
			int num6 = phase & 0xFF;
			bool flag17 = num6 == 0;
			object obj33 = !flag17;
			if (obj33 == null)
			{
				NetworkDictionary<PlayerRef, byte> votes = Votes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
			}
		}
	}

	public unsafe void RPC_ModeVote(byte mode, RpcInfo info = default(RpcInfo))
	{
		//IL_0764: Expected Obj, but got I4
		//IL_076d: Expected VT, but got I4
		//IL_0775: Expected I4, but got VT
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I4
		//IL_0546: Expected VT, but got I4
		//IL_0095: Expected VT, but got I4
		//IL_0573: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I
		//IL_05bf: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got VT
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		//IL_0204: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_026e: Expected VT, but got I8
		//IL_0289: Expected VT, but got I4
		//IL_0632: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got VT
		//IL_02c6: Expected Obj, but got I4
		//IL_0323: Expected VT, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_033d: Expected VT, but got Ref
		//IL_0345: Expected I, but got VT
		//IL_0355: Expected Obj, but got Ref
		//IL_0366: Expected Obj, but got Ref
		//IL_036e: Expected I4, but got VT
		//IL_017c: Expected VT, but got I4
		//IL_0181: Expected VT, but got Obj
		//IL_018a: Expected VT, but got I4
		//IL_06ed: Expected Ref, but got VT
		//IL_070d: Expected Obj, but got VT
		//IL_038d: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I
		//IL_02ec: Expected VT, but got Obj
		//IL_030c: Expected VT, but got I4
		//IL_01a9: Invalid comparison between VT and I4
		//IL_03ab: Expected Obj, but got I
		//IL_03d5: Expected Obj, but got I4
		//IL_07dd: Expected Obj, but got I
		//IL_07ed: Expected Obj, but got I
		//IL_01c6: Invalid comparison between VT and I4
		//IL_01d8: Expected VT, but got I4
		//IL_01dd: Expected VT, but got Obj
		//IL_01e6: Expected VT, but got I4
		//IL_086f: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I
		//IL_0413: Expected VT, but got Obj
		//IL_041f: Expected I, but got Obj
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected I4, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_04f7: Expected native int or pointer, but got VT
		//IL_0504: Expected native int or pointer, but got VT
		//IL_0516: Expected I, but got Obj
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected I4, but got Unknown
		//IL_049d: Expected VT, but got I4
		//IL_049d: Expected VT, but got I4
		//IL_04c9: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcHostMode rpcHostMode = (RpcHostMode)info;
		RpcChannel rpcChannel = (RpcChannel)0;
		int num = 109895680;
		MethodBase methodBase = default;
		NetworkRunner networkRunner = default;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj3 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		RpcInfo rpcInfo;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			methodBase = (MethodBase)0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			nint num2 = (nint)methodBase;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v30 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			bool flag4 = (object)networkRunner == null;
			rpcBuilder = (Fusion.RpcBuilder)0;
			rpcInfo = info;
			rpcChannel = (RpcChannel)0;
			num = bytePayloadSize;
			if (!flag4)
			{
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(855452797u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj3 = rpcInvokeInfo >> 32;
				object obj4 = obj3 - 522;
				bool flag5 = (nint)obj4 < 2;
				object obj5 = !flag5;
				object obj6 = ~obj5;
				PlayerRef playerRef;
				PlayerRef playerRef3;
				if (obj6 == null && (nint)obj3 != 518)
				{
					bool flag6 = (nint)obj3 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef3 = invalid;
					if (flag6)
					{
						goto IL_029e;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef3 = invalid;
						if (flag7)
						{
							goto IL_029e;
						}
					}
				}
				nint num3 = (nint)methodBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v76 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag8 = (nint)0 == 0;
				object obj7 = !flag8;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27F8]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef3 = none;
				goto IL_029e;
			}
			goto IL_0642;
		}
		goto IL_0795;
		IL_0832:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0642:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0650;
		IL_0373:
		nint num4 = default;
		bool flag9 = num4 == 0;
		object obj8 = !flag9;
		if (obj8 != null)
		{
			goto IL_0650;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v42+E4]");
		bool flag10 = (nint)0 == 0;
		object obj11 = !flag10;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v42+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v22+18]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v22+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27F0]");
			object obj14 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj14);
			nint num5 = (nint)methodBase;
			int num6 = num | obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v27 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
			bool flag11 = (nint)0 == 0;
			object obj15 = !flag11;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num6, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v419 @ X27_v6+18] (should have been resolved before IL gen)");
			IntPtr intPtr = default;
			num4 = intPtr;
			PlayerRef playerRef = invalid2;
			PlayerRef playerRef3 = (PlayerRef)0;
			methodBase = methodFromHandle;
		}
		bool flag12 = num == 0;
		object obj16 = !flag12;
		Fusion.RpcBuilder rpcBuilder4 = default;
		nint num7;
		if (obj16 == null)
		{
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, (Tick)rpcBuilder4);
			((RpcInfo*)(nint)info)->_validationResult = num4;
			rpcBuilder = rpcBuilder4;
			num7 = unchecked((nint)null);
			rpcHostMode = (RpcHostMode)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0795;
		}
		return;
		IL_0650:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj17;
		object obj18 = default;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = obj18;
			num4 = 1;
		}
		else
		{
			bool flag13 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0832;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj19 = default;
			obj17 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj18 = obj19;
		}
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag14 = obj17 == null;
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)rpcBuilder4;
		if (flag14)
		{
			goto IL_0373;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_0832;
		IL_029e:
		object obj20 = rpcInvokeInfo >> 32;
		bool flag15 = obj20 == null;
		object obj21 = !flag15;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj22 = 0;
			playerRef2 = (PlayerRef)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num8 = rpcBuilder3.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
		}
		rpcBuilder3.Dispose();
		rpcBuilder = (Fusion.RpcBuilder)0;
		num4 = 0;
		obj18 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num7 = (nint)playerRef2;
		rpcInfo = (RpcInfo)rpcInvokeInfo2;
		networkRunner = (NetworkRunner)(&writer);
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)(&rpcBuilder3);
		num = (int)rpcInvokeInfo;
		goto IL_0373;
		IL_0795:
		byte phase = Phase;
		int num9 = phase & 0xFF;
		if (num9 != 3)
		{
			return;
		}
		bool flag16 = (object)((SimulationBehaviour)this)._runner == null;
		rpcInfo = (RpcInfo)rpcHostMode;
		if (!flag16)
		{
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
			object obj23 = 0;
			int players = Enumerable.Count(activePlayers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+E4]");
			bool flag17 = (nint)0 == 0;
			object obj26 = !flag17;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int mode2 = mode & 0xFF;
			if (ModeAllowed(mode2, players))
			{
				NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
			}
			return;
		}
		goto IL_0642;
	}

	public unsafe void RPC_Out(RpcInfo info = default(RpcInfo))
	{
		//IL_0240: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_02d3: Expected I4, but got I8
		//IL_0057: Expected Obj, but got I
		//IL_0305: Expected Obj, but got VT
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_032d: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I
		//IL_046e: Expected VT, but got I8
		//IL_0489: Expected VT, but got I4
		//IL_04ac: Expected Obj, but got VT
		//IL_04c6: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I4
		//IL_0512: Expected VT, but got Ref
		//IL_051a: Expected Obj, but got Ref
		//IL_0523: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got VT
		//IL_037c: Expected VT, but got I4
		//IL_0389: Expected VT, but got Obj
		//IL_0392: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_07a6: Expected Ref, but got VT
		//IL_07c0: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_03a9: Invalid comparison between VT and I4
		//IL_07df: Expected Obj, but got VT
		//IL_07e8: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I4
		//IL_03c6: Invalid comparison between VT and I4
		//IL_03d8: Expected VT, but got I4
		//IL_03e5: Expected VT, but got Obj
		//IL_03ee: Expected VT, but got I4
		//IL_022b: Expected Obj, but got I4
		//IL_0872: Expected Obj, but got I
		//IL_0882: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_06ca: Expected native int or pointer, but got VT
		//IL_06d7: Expected native int or pointer, but got VT
		//IL_05e4: Expected Obj, but got I
		//IL_05ed: Expected VT, but got Obj
		//IL_0606: Expected VT, but got Obj
		//IL_0628: Expected Obj, but got I4
		//IL_0660: Expected I4, but got I8
		//IL_0677: Expected VT, but got I4
		//IL_06a3: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer = default;
		object obj4 = default;
		NullReferenceException ex;
		RpcChannel rpcChannel;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			networkRunner = ((SimulationBehaviour)this)._runner;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(2511415377u, 0, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag2 = (nint)obj5 < 2;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				PlayerRef playerRef3;
				PlayerRef playerRef;
				PlayerRef playerRef2;
				RpcInvokeInfo rpcInvokeInfo2;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = invalid;
					playerRef3 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_049e;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = invalid;
						playerRef3 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag4)
						{
							goto IL_049e;
						}
					}
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v58+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2808]");
				object rpc = 0;
				playerRef3 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef3);
				playerRef = (PlayerRef)0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_049e;
			}
			ex = new NullReferenceException();
			rpcChannel = (RpcChannel)0;
			goto IL_0709;
		}
		goto IL_0005;
		IL_08ea:
		nint num = default;
		bool flag6 = num == 0;
		object obj10 = !flag6;
		object obj11;
		if (obj10 == null)
		{
			if ((nint)obj11 != 9)
			{
				bool flag7 = obj11 == null;
				object obj12 = !flag7;
				if (obj12 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v11+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v7+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2800]");
				object obj18 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj18);
				object obj19 = obj;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)networkRunner | obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ X26_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef2 = (PlayerRef)0;
			}
			if ((object)networkRunner != null)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num;
			goto IL_0005;
		}
		goto IL_0709;
		IL_08c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_049e:
		object obj21 = rpcInvokeInfo >> 32;
		bool flag10 = obj21 == null;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			int num2 = rpcBuilder2.Send();
		}
		rpcBuilder2.Dispose();
		num = 0;
		object obj23 = 0;
		rpcChannel = (RpcChannel)0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		ex = (NullReferenceException)(&rpcBuilder2);
		obj11 = 9;
		networkRunner = (NetworkRunner)rpcInvokeInfo;
		goto IL_08ea;
		IL_0709:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj24;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj24 = obj23;
			num = 1;
		}
		else
		{
			bool flag11 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_08c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj25 = default;
			obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj23 = obj25;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj24 == null;
		object obj26 = !flag12;
		if (obj26 == null)
		{
			rpcChannel = (RpcChannel)0;
			ex = (NullReferenceException)rpcBuilder3;
			obj11 = 0;
			goto IL_08ea;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_08c7;
		IL_0005:
		byte phase = Phase;
		int num3 = phase & 0xFF;
		if (num3 != 1)
		{
			return;
		}
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
		object obj27 = 0;
		PlayerRef source = info.Source;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
		object obj29 = default;
		object obj28 = obj29 & 1;
		if (obj28 == null)
		{
			return;
		}
		byte mode = Mode;
		int num4 = mode & 0xFF;
		object obj30 = default;
		if (num4 != 1 && (nint)obj30 == 3)
		{
			source = info.Source;
			if (HuntersIn(info.Source) == 0)
			{
				End(2);
				return;
			}
		}
		NetworkDictionary<PlayerRef, byte> players2 = Players;
		byte mode2 = Mode;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj31 = 0;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v38+E4]");
		bool flag13 = (nint)0 == 0;
		object obj33 = !flag13;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = mode2 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
		object obj34 = 0;
		bool flag14;
		if ((nint)obj30 == 1)
		{
			object obj35 = num5 - 1;
			flag14 = obj35 == null;
		}
		else
		{
			flag14 = false;
		}
		object obj36 = !flag14;
		if (obj36 == null)
		{
			object obj37 = 2 + 1;
		}
		else
		{
			object obj37 = 2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
	}

	public static byte PartWhenOut(byte mode, byte part)
	{
		//IL_0099: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		int num = part & 0xFF;
		int num2 = mode & 0xFF;
		bool flag;
		if (num == 1)
		{
			object obj = num2 - 1;
			flag = obj == null;
		}
		else
		{
			flag = false;
		}
		object obj2 = !flag;
		if (obj2 == null)
		{
			return 3;
		}
		return 2;
	}

	public int HuntersIn(PlayerRef besides = default(PlayerRef))
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2810]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2818]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D70]");
			object obj6 = 0;
			object obj7 = obj2 + 24;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			NetworkDictionary<PlayerRef, byte> players = Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
			func._002Ector(obj2, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35C6D04");
			int result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public bool Hunting(PlayerRef p)
	{
		//IL_004d: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		bool live = Live;
		bool flag = !live;
		bool result = false;
		if (!flag)
		{
			byte phase = Phase;
			int num = phase & 0xFF;
			if (num == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				if (none != p)
				{
					NetworkDictionary<PlayerRef, byte> players = Players;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
					object obj4 = 0;
					object obj5 = p & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
					object obj7 = default;
					object obj6 = obj7 & 1;
					if (obj6 != null)
					{
						object obj9 = default;
						object obj8 = obj9 - 3;
						bool flag3 = obj8 == null;
						result = flag3;
						goto IL_0187;
					}
				}
			}
			result = false;
		}
		goto IL_0187;
		IL_0187:
		return result;
	}

	public static byte Outcome(byte mode, int startApes, int alive, int huntersIn, bool monsterIn, bool timeUp)
	{
		//IL_0139: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		int num = mode & 0xFF;
		if (num == 1)
		{
			if (huntersIn != 0)
			{
				goto IL_004b;
			}
		}
		else
		{
			bool flag = !monsterIn;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_004b;
			}
		}
		return 2;
		IL_004b:
		bool flag2 = !timeUp;
		object obj2 = !flag2;
		object obj3 = ~obj2;
		byte result = (byte)((obj3 == null) ? 2 : 0);
		bool flag3;
		bool flag4;
		bool flag5;
		if (alive == 0)
		{
			flag3 = startApes < 0;
			flag4 = startApes == 0;
			int num2 = startApes ^ startApes;
			int num3 = startApes & num2;
			flag5 = num3 < 0;
		}
		else
		{
			flag5 = false;
			flag4 = true;
			flag3 = false;
		}
		bool flag6 = flag3 == flag5;
		object obj4 = !flag6;
		object obj5 = obj4 | flag4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return result;
		}
		return 1;
	}

	public static byte PickMode(int[] counts, Func<float> roll)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ab: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected I4, but got Unknown
		//IL_01de: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected I4, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2820]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = counts;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			IEnumerable<int> enumerable = (IEnumerable<int>)obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
				if ((nint)0 == 0)
				{
					_ = 0;
					return 0;
				}
				int num = Enumerable.Max((IEnumerable<int>)obj3);
				if (num < 1)
				{
					return 0;
				}
				object obj4 = obj3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+18]");
					IEnumerable<int> source = Enumerable.Range(0, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E68]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2828]");
					object obj6 = 0;
					Func<int, bool> func = default;
					func._002Ector(obj2, (IntPtr)obj6);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E30]");
					object obj7 = 0;
					IEnumerable<int> source2 = Enumerable.Where(source, func);
					List<int> list = Enumerable.ToList(source2);
					if (roll != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [roll @ X1 (System.Func`1<System.Single>)+18] (should have been resolved before IL gen)");
						if (list != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v19 (System.Collections.Generic.List`1<System.Int32>)+18]");
							int num2 = (int)(-1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v19 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj8 = default;
							int num3 = obj8 * 0;
							object obj9 = num3 - num2;
							bool flag = (nint)obj9 < 0;
							int num4 = num3 ^ num2;
							int num5 = num3 ^ obj9;
							int num6 = num4 & num5;
							bool flag2 = num6 < 0;
							bool flag3 = flag == flag2;
							object obj10 = !flag3;
							object obj11 = ~obj10;
							if (obj11 == null)
							{
								num2 = num3;
							}
							bool flag4 = num3 < 0;
							int num7 = num3 ^ num3;
							int num8 = num3 & num7;
							bool flag5 = num8 < 0;
							bool flag6 = flag4 == flag5;
							object obj12 = !flag6;
							object obj13 = ~obj12;
							int index = ((obj13 != null) ? num2 : 0);
							return (byte)list.get_Item(index);
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
	}

	public int ModeVotesFor(int mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2830]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2838]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D70]");
			object obj6 = 0;
			object obj7 = obj2 + 24;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
			func._002Ector(obj2, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35C6D04");
			int result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private unsafe int[] ModeCounts()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_0525: Expected Obj, but got I
		//IL_0535: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got Ref
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got Ref
		//IL_02fc: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_05d1: Expected I4, but got Obj
		//IL_05f5: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected I4, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected VT, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0230: Expected I4, but got Obj
		//IL_035e: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got Ref
		//IL_0390: Expected Obj, but got I4
		//IL_0398: Expected I4, but got Obj
		//IL_0278: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = default;
		int num = (int)(&obj3);
		((int*)num)->m_value = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj2;
		UnityEngine.Object runner = ((SimulationBehaviour)this)._runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj7;
		object obj8;
		int num3;
		int num2;
		object obj6;
		if (runner != null)
		{
			bool flag2 = (object)((SimulationBehaviour)this)._runner == null;
			num2 = 0;
			obj6 = 0;
			obj7 = null;
			num3 = (int)(&obj3);
			obj8 = 109895680;
			if (flag2)
			{
				goto IL_03c8;
			}
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			int num4 = Enumerable.Count(activePlayers);
			runner = (UnityEngine.Object)num4;
		}
		else
		{
			runner = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
		obj8 = 0;
		NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
		int value = default;
		((int*)num)->m_value = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		int[] array = default;
		object obj13 = array + 32;
		object obj14 = default;
		num3 = (int)(&obj14);
		OutOfMemoryException ex = default;
		obj4 = (object)(&ex);
		object obj16 = default;
		object obj18 = default;
		object obj29 = default;
		object obj31 = default;
		int num5 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28;
		object obj30;
		int num6;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj15 = obj16 & 1;
			if (obj15 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
			object obj17 = obj18 >> 32;
			num3 = obj17 & 0xFF;
			bool flag3 = num3 < 2;
			object obj19 = !flag3;
			object obj20 = num3 - 2;
			bool flag4 = obj20 == null;
			object obj21 = !flag4;
			object obj22 = obj19 & obj21;
			if (obj22 != null)
			{
				continue;
			}
			PlayerRef p = (PlayerRef)(obj18 & 0xFFFFFFFFL);
			if (!InRoom(p))
			{
				continue;
			}
			object obj23 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v24+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!ModeAllowed(num3, (int)runner))
			{
				continue;
			}
			if (array != null)
			{
				obj4 = array.Length;
				bool flag6 = num3 < array.Length;
				object obj25 = !flag6;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X27_v7+v159 @ X22_v9 (System.Int32)*4]");
					obj4 = (nint)0 + (nint)1;
					continue;
				}
			}
			else
			{
				NullReferenceException ex2 = new NullReferenceException();
			}
			obj26 = 0;
			obj27 = 0;
			ex = (OutOfMemoryException)(&obj14);
			obj28 = obj29;
			obj30 = obj31;
			num2 = num5;
			obj6 = 72;
			num6 = (int)runner;
			throw new IndexOutOfRangeException();
		}
		obj26 = 0;
		obj27 = 0;
		ex = (OutOfMemoryException)(&obj14);
		obj28 = obj29;
		obj30 = obj31;
		num2 = num5;
		obj6 = 72;
		object obj32 = 0;
		goto IL_05c9;
		IL_03c8:
		NullReferenceException ex3 = new NullReferenceException();
		if ((nint)obj7 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = 1;
			obj32 = obj27;
			obj4 = 1;
		}
		else
		{
			if ((nint)obj7 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				int[] result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj33 = default;
			obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj27 = obj33;
		}
		goto IL_05c9;
		IL_05c9:
		num6 = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
		bool flag7 = obj32 == null;
		object obj34 = !flag7;
		if (obj34 == null)
		{
			bool flag8 = obj26 == null;
			object obj35 = !flag8;
			obj7 = (UnityEngine.Object)obj8;
			OutOfMemoryException ex4 = ex;
			if (obj35 == null)
			{
				return array;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj7 = (UnityEngine.Object)num6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_03c8;
	}

	public unsafe (int, int) Apes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got Ref
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got Ref
		//IL_0142: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected VT, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_0318: Expected VT, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
		object obj4 = 0;
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		object obj6 = default;
		object obj5 = (object)(&obj6);
		int num = 0;
		int num2 = 0;
		object obj8 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj7 = obj8 & 1;
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
			object obj9 = obj10 >> 32;
			obj5 = obj9 & 0xFF;
			if ((nint)obj5 != 3)
			{
				num2++;
				if ((nint)obj5 == 1)
				{
					PlayerRef p = (PlayerRef)(obj10 & 0xFFFFFFFFL);
					bool flag = InRoom(p);
					num += (flag ? 1 : 0);
					obj5 = flag;
				}
			}
		}
		object obj11 = 0;
		object obj12 = 0;
		object obj13 = 0;
		object obj20 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
			bool flag2 = obj11 == null;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				bool flag3 = obj12 == null;
				object obj15 = !flag3;
				OutOfMemoryException ex = (OutOfMemoryException)(&obj6);
				if (obj15 == null)
				{
					byte startMonsters = StartMonsters;
					int num3 = startMonsters & 0xFF;
					bool flag4 = num3 < 1;
					object obj16 = !flag4;
					object obj17 = num3 - 1;
					bool flag5 = obj17 == null;
					object obj18 = ~obj16;
					object obj19 = obj18 | flag5;
					if (obj19 == null)
					{
						byte startApes = StartApes;
						num2 = startApes & 0xFF;
					}
					(int, int) tuple = (num2, num);
					return ((int, int))0;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj4 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = obj13;
				obj12 = 1;
				obj5 = 1;
				continue;
			}
			if ((nint)obj4 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj11 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		(int, int) result = default;
		return result;
	}

	public bool IsOut(PlayerRef p)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		bool live = Live;
		bool flag = !live;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj = 0;
			NetworkDictionary<PlayerRef, byte> players = Players;
			object obj2 = p & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj4 = default;
			object obj3 = obj4 & 1;
			if (obj3 != null)
			{
				object obj6 = default;
				object obj5 = obj6 - 2;
				bool flag2 = obj5 == null;
				result = flag2;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	public int VotesFor(int map)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2850]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D70]");
			object obj6 = 0;
			object obj7 = obj2 + 24;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			NetworkDictionary<PlayerRef, byte> votes = Votes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
			func._002Ector(obj2, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35C6D04");
			int result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private bool InRoom(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_00c1: Expected I4, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
		{
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
				PlayerRef value = (PlayerRef)(p & 0xFFFFFFFFL);
				return Enumerable.Contains(activePlayers, value);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	public override void FixedUpdateNetwork()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_035a: Invalid comparison between F4 and I4
		//IL_040c: Expected Obj, but got I
		//IL_0753: Expected Obj, but got I
		//IL_00fc: Expected VT, but got I4
		//IL_06b6: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I
		//IL_079a: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0452: Expected F4, but got I4
		//IL_07af: Expected Obj, but got I
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected I4, but got Unknown
		//IL_01f6: Expected VT, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_0828: Expected Obj, but got I4
		//IL_08b3: Expected I4, but got VT
		//IL_02d6: Expected Obj, but got I
		//IL_02e4: Expected I, but got Obj
		//IL_099b: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_090f: Expected Obj, but got I4
		//IL_04cd: Invalid comparison between F4 and I4
		//IL_04e0: Expected Obj, but got F4
		//IL_04ed: Expected Obj, but got F4
		//IL_0530: Expected Obj, but got I4
		//IL_06ef: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got VT
		//IL_05db: Expected Obj, but got I4
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_061e: Expected Obj, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0945: Expected Obj, but got I4
		//IL_097d: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
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
		byte phase = Phase;
		(int, int) tuple;
		int num;
		object obj31;
		object obj14;
		byte winner;
		float voteEnds;
		object obj6;
		bool flag2;
		bool flag3;
		int num2;
		int num3;
		bool flag4;
		bool flag5;
		object obj7;
		object obj8;
		bool flag6;
		object obj9;
		bool flag7;
		object obj10;
		object obj11;
		bool flag8;
		object obj12;
		bool flag25;
		object obj39;
		object obj38;
		object obj40;
		bool flag26;
		object obj41;
		switch (phase & 0xFF)
		{
		case 1:
		{
			tuple = Apes();
			int num5 = HuntersIn((PlayerRef)0);
			byte startMonsters = StartMonsters;
			int num6 = startMonsters & 0xFF;
			bool flag10 = num6 < 1;
			object obj26 = !flag10;
			object obj27 = num6 - 1;
			bool flag11 = obj27 == null;
			object obj28 = ~obj26;
			object obj29 = obj28 | flag11;
			bool flag17;
			if (obj29 == null)
			{
				bool flag12 = num5 < 0;
				bool flag13 = num5 == 0;
				int num7 = num5 ^ num5;
				int num8 = num5 & num7;
				bool flag14 = num8 < 0;
				bool flag15 = flag12 == flag14;
				object obj30 = !flag13;
				bool flag16 = (byte)((flag15 & obj30) ? 1 : 0) != 0;
				flag17 = flag16;
				PlayerRef playerRef = (PlayerRef)0;
			}
			else
			{
				PlayerRef monster = Monster;
				bool flag18 = InRoom(monster);
				flag17 = flag18;
				PlayerRef playerRef = monster;
			}
			byte mode = Mode;
			byte mode2 = Mode;
			int num9 = mode2 & 0xFF;
			bool flag19 = num9 != 1;
			num = (int)tuple;
			if (!flag19)
			{
				byte startApes = StartApes;
				num = startApes & 0xFF;
			}
			float now4 = Now;
			float huntEnds = HuntEnds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v73+E4]");
			bool flag20 = (nint)0 == 0;
			object obj33 = !flag20;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num10 = now4 - huntEnds;
			bool flag21 = num10 < 0f;
			object obj34 = now4 ^ huntEnds;
			object obj35 = now4 ^ num10;
			object obj36 = obj34 & obj35;
			bool flag22 = (nint)obj36 < 0;
			int num11 = mode & 0xFF;
			bool flag23 = flag21 == flag22;
			obj14 = !flag23;
			if (num11 == 1)
			{
				if (num5 != 0)
				{
					goto IL_056d;
				}
			}
			else
			{
				bool flag24 = !flag17;
				object obj37 = !flag24;
				if (obj37 != null)
				{
					goto IL_056d;
				}
			}
			winner = 2;
			goto IL_0953;
		}
		case 3:
			if (Enough)
			{
				float now5 = Now;
				float modeEnds = ModeEnds;
				if (now5 < modeEnds)
				{
					IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2878]");
					object obj43 = 0;
					Func<PlayerRef, bool> func2 = default;
					func2._002Ector((object)this, (IntPtr)obj43);
					if (!Enumerable.All(activePlayers, func2))
					{
						return;
					}
				}
				Begin();
			}
			else
			{
				Phase = 0;
				NetworkDictionary<PlayerRef, byte> modeVotes2 = ModeVotes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				ModeEnds = 0f;
			}
			return;
		case 0:
			if (Enough)
			{
				float voteEnds2 = VoteEnds;
				if (voteEnds2 > 0f)
				{
					float now2 = Now;
					float voteEnds3 = VoteEnds;
					if (!(now2 < voteEnds3))
					{
						MapChosen();
					}
					return;
				}
				NetworkDictionary<PlayerRef, byte> votes2 = Votes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2870]");
				object obj18 = 0;
				Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
				func._002Ector((object)this, (IntPtr)obj18);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2860]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35B4398");
				object obj21 = default;
				object obj20 = obj21 & 1;
				if (obj20 != null)
				{
					float now3 = Now;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj22 = 0;
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v53+E4]");
					bool flag9 = (nint)0 == 0;
					object obj24 = !flag9;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj23 = obj22;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v53+A0]");
					object obj25 = 0;
					float num4 = now3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v32+4]");
					voteEnds = num4 + 0f;
					break;
				}
				return;
			}
			VoteEnds = 0f;
			return;
		case 2:
		{
			float now = Now;
			float overEnds = OverEnds;
			if (!(now < overEnds))
			{
				Phase = 0;
				NetworkDictionary<PlayerRef, byte> players = Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				NetworkDictionary<PlayerRef, byte> votes = Votes;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				voteEnds = 0f;
				break;
			}
			return;
		}
		default:
			return;
			IL_056d:
			obj6 = tuple >> 32;
			flag2 = num < 0;
			flag3 = num == 0;
			num2 = num ^ num;
			num3 = num & num2;
			flag4 = num3 < 0;
			flag5 = flag2 == flag4;
			obj7 = !flag3;
			obj8 = flag5 & obj7;
			flag6 = obj6 == null;
			obj9 = flag6 & obj8;
			flag7 = obj9 == null;
			obj10 = !flag7;
			winner = (byte)((obj10 != null) ? 1 : (1 + 1));
			obj11 = obj9 & 1;
			flag8 = obj11 == null;
			obj12 = !flag8;
			if (obj12 == null)
			{
				object obj13 = obj14 ^ 1;
				object obj15 = obj13 & 1;
				if (obj15 == null)
				{
					return;
				}
			}
			goto IL_0953;
			IL_0953:
			obj38 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v76+E4]");
			flag25 = (nint)0 == 0;
			obj39 = !flag25;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj31;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v76+A0]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v39+20]");
			flag26 = (nint)0 == 0;
			obj41 = !flag26;
			if (obj41 == null)
			{
				End(winner);
			}
			return;
		}
		VoteEnds = voteEnds;
	}

	private unsafe void MapChosen()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0028: Expected Obj, but got Ref
		//IL_0754: Expected Obj, but got I4
		//IL_07ab: Expected F4, but got I4
		//IL_07b4: Expected VT, but got I4
		//IL_07bd: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0089: Expected F4, but got I4
		//IL_0092: Expected VT, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got Ref
		//IL_0180: Expected Obj, but got Ref
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got Ref
		//IL_0341: Expected Obj, but got I4
		//IL_0849: Expected VT, but got Obj
		//IL_086d: Expected Obj, but got I4
		//IL_018d: Expected VT, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_06ad: Invalid comparison between VT and I4
		//IL_0705: Invalid comparison between VT and I4
		//IL_0398: Expected VT, but got Obj
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected VT, but got Unknown
		//IL_03f1: Expected F4, but got I4
		//IL_03f9: Expected Obj, but got Ref
		//IL_0646: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_0657: Expected Obj, but got Ref
		//IL_06e6: Expected Obj, but got I4
		//IL_06f7: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I
		//IL_0499: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_04df: Expected VT, but got Obj
		//IL_0519: Expected F4, but got I4
		//IL_0559: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0810: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEA80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2880]");
		object obj2 = 0;
		object obj4 = default;
		object obj3 = (object)(&obj4);
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj5 = default;
		obj5._002Ector();
		bool flag = (object)((SimulationBehaviour)this)._runner == null;
		float num = 0f;
		PlayerRef playerRef = (PlayerRef)0;
		List<PlayerRef> list = (List<PlayerRef>)109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj6 = 0;
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			List<PlayerRef> list2 = Enumerable.ToList(activePlayers);
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag2 = obj5 == null;
			num = 0f;
			playerRef = (PlayerRef)3;
			list = list2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E80]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
				object obj12 = 0;
				object obj13 = obj5 + 16;
				object obj14 = default;
				obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				NetworkDictionary<PlayerRef, byte> votes = Votes;
				object obj15 = default;
				obj3 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj16 = 72;
				object obj17 = default;
				OutOfMemoryException ex = (OutOfMemoryException)(&obj17);
				OutOfMemoryException ex2 = default;
				obj = (object)(&ex2);
				object obj19 = default;
				object obj21 = default;
				object obj31 = default;
				object obj33 = default;
				float num2 = default;
				object obj37 = default;
				object obj38 = default;
				Func<int, bool> func = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
					object obj18 = obj19 & 1;
					if (obj18 != null)
					{
						playerRef = (PlayerRef)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
						object obj20 = obj21 >> 32;
						ex = (OutOfMemoryException)(obj20 & 0xFF);
						bool flag3 = (nint)ex < 2;
						object obj22 = !flag3;
						object obj23 = ex - 2;
						bool flag4 = obj23 == null;
						object obj24 = !flag4;
						object obj25 = obj22 & obj24;
						if (obj25 != null)
						{
							continue;
						}
						if ((object)list2 != null)
						{
							obj16 = obj10;
							playerRef = (PlayerRef)(obj21 & 0xFFFFFFFFL);
							if (!list2.Contains(playerRef))
							{
								continue;
							}
							obj = obj13;
							if (obj13 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v30+18]");
								object obj26 = 0;
								OutOfMemoryException ex3 = ex;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v30+18]");
								bool flag5 = (nint)ex3 < 0;
								object obj27 = !flag5;
								if (obj27 == null)
								{
									obj += (object)ex;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v30+20]");
									obj26 = (nint)0 + (nint)1;
									continue;
								}
								goto IL_0634;
							}
						}
						else
						{
							NullReferenceException ex4 = new NullReferenceException();
						}
						NullReferenceException ex5 = new NullReferenceException();
						goto IL_0634;
					}
					object obj28 = 0;
					object obj29 = 0;
					ex2 = (OutOfMemoryException)(&obj17);
					object obj30 = obj31;
					object obj32 = obj33;
					num = num2;
					object obj34 = 0;
					list = list2;
					while (true)
					{
						playerRef = (PlayerRef)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
						bool flag6 = obj34 == null;
						object obj35 = !flag6;
						if (obj35 == null)
						{
							bool flag7 = obj28 == null;
							object obj36 = !flag7;
							OutOfMemoryException ex6 = ex2;
							obj = obj28;
							if (obj36 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex6 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if (playerRef == (PlayerRef)(object)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj28 = 1;
							obj34 = obj29;
							obj = 1;
							continue;
						}
						if (playerRef == (PlayerRef)(object)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj34 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj29 = obj37;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					NetworkDictionary<PlayerRef, byte> votes2 = Votes;
					playerRef = (PlayerRef)obj12;
					obj3 = ex2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
					VoteEnds = 0f;
					bool flag8 = (object)list == null;
					obj30 = obj38;
					obj32 = obj28;
					num = 0f;
					obj = (object)(&ex2);
					if (flag8)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X21_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+10]");
						int num3 = Enumerable.Max((IEnumerable<int>)0);
						IEnumerable<int> enumerable = Enumerable.Range(0, 3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E68]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2888]");
						object obj40 = 0;
						func._002Ector(obj5, (IntPtr)obj40);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E30]");
						object obj41 = 0;
						obj16 = obj41;
						IEnumerable<int> source = Enumerable.Where(enumerable, func);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E20]");
						obj = 0;
						playerRef = (PlayerRef)obj;
						List<int> list3 = Enumerable.ToList(source);
						bool flag9 = list3 == null;
						obj30 = obj38;
						obj32 = obj28;
						num = 0f;
						list = (List<PlayerRef>)enumerable;
						if (flag9)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v20 (System.Collections.Generic.List`1<System.Int32>)+18]");
						int index = UnityEngine.Random.Range(0, 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
						object obj42 = 0;
						int map = list3.get_Item(index);
						Map = (byte)map;
						NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
						obj3 = ex2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
						float now = Now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
						object obj43 = 0;
						object obj44 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v31+E4]");
						bool flag10 = (nint)0 == 0;
						object obj45 = !flag10;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj44 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v31+A0]");
						object obj46 = 0;
						float num4 = now;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v21+10]");
						float modeEnds = num4 + 0f;
						ModeEnds = modeEnds;
						Phase = 3;
					}
					return;
					IL_0634:
					IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
					obj28 = 0;
					obj29 = 0;
					ex2 = (OutOfMemoryException)(&obj17);
					obj30 = obj31;
					obj32 = obj33;
					num = num2;
					list = list2;
					break;
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void Begin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0836: Expected F4, but got I4
		//IL_083f: Expected F4, but got I4
		//IL_0847: Expected Obj, but got I
		//IL_0850: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I
		//IL_00b2: Expected F4, but got I4
		//IL_00c2: Expected Obj, but got Ref
		//IL_010d: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_086e: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_08b0: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0900: Expected I, but got Obj
		//IL_0911: Expected I, but got Obj
		//IL_092f: Expected Obj, but got I
		//IL_0952: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_035a: Expected F4, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_03c9: Expected I4, but got Obj
		//IL_046b: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Ref
		//IL_057c: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I4
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I4
		//IL_0a4f: Expected Obj, but got I4
		//IL_0515: Expected VT, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_05d6: Expected Obj, but got Ref
		//IL_0998: Expected Obj, but got Ref
		//IL_064c: Expected Obj, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got I4
		//IL_07ab: Expected Obj, but got I4
		//IL_07bc: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got I4
		//IL_0813: Expected Obj, but got I4
		//IL_09dd: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEA81]");
		object obj = 0;
		bool flag = (object)((SimulationBehaviour)this)._runner == null;
		float num = 0f;
		float num2 = 0f;
		IntPtr intPtr = default;
		List<PlayerRef> list = (List<PlayerRef>)(nint)intPtr;
		List<PlayerRef> list2 = (List<PlayerRef>)109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
			object obj2 = 0;
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			List<PlayerRef> list3 = Enumerable.ToList(activePlayers);
			int[] array = ModeCounts();
			NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
			list = (List<PlayerRef>)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
			ModeEnds = 0f;
			bool flag2 = (object)list3 == null;
			float num3 = default;
			num = num3;
			float num5 = default;
			float num4 = num5;
			float num7 = default;
			float num6 = num7;
			num2 = 0f;
			int[] array2 = array;
			obj = (object)(&num3);
			list2 = list3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v37 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				byte phase;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A8]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v46+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v46+A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v35+8]");
					Func<float> roll = (Func<float>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v35+8]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					int num9 = default;
					nint num8 = num9;
					object obj12;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v46+E4]");
						bool flag5 = (nint)0 == 0;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj10 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v39+A0]");
							obj6 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2890]");
						object obj11 = 0;
						obj12 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A0]");
						object obj13 = 0;
						num8 = (nint)obj13;
						Func<float> func = default;
						func._002Ector(obj6, (IntPtr)obj13);
						object obj14 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v38+A0]");
						object obj15 = (nint)0 + (nint)8;
						obj15 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						roll = func;
						object obj16 = 0;
						list = (List<PlayerRef>)(object)func;
					}
					object obj17 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v48+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					byte mode = PickMode(array, roll);
					Mode = mode;
					byte mode2 = Mode;
					int mode3 = mode2 & 0xFF;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v37 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					bool flag7 = ModeAllowed(mode3, 0);
					bool flag8 = !flag7;
					object obj19 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v37 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					byte b = 0;
					if (obj19 == null)
					{
						Mode = 0;
						b = 0;
					}
					byte mode4 = Mode;
					obj = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v3+E4]");
					bool flag9 = (nint)0 == 0;
					object obj20 = !flag9;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					byte mode5 = mode4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v37 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					int num10 = MonstersFor(mode5, 0);
					List<PlayerRef> list4 = PickMonsters(list3, num10);
					bool flag10 = (object)list4 == null;
					num9 = num10;
					num = num3;
					num4 = num5;
					num6 = num7;
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v37 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					array2 = (int[])0;
					list = list3;
					list2 = list3;
					if (flag10)
					{
						goto IL_0741;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v64 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					PlayerRef monster;
					if ((nint)0 > (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2898]");
						object obj21 = 0;
						num9 = (int)obj21;
						monster = list4.get_Item(0);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v81+E4]");
						bool flag11 = (nint)0 == 0;
						object obj24 = !flag11;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						monster = PlayerRef.None;
						num9 = num10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E48]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E80]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E38]");
					obj12 = 0;
					Monster = monster;
					NetworkDictionary<PlayerRef, byte> players = Players;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
					Enumerator<, > enumerator = list3.GetEnumerator();
					num = num3;
					num4 = num5;
					num6 = num7;
					float num11 = default;
					num2 = num11;
					Enumerator<, > val = default;
					obj = (object)(&val);
					while (val.MoveNext())
					{
						NetworkDictionary<PlayerRef, byte> players2 = Players;
						bool flag12 = list4.Contains((PlayerRef)0);
						object obj16 = obj25;
						bool flag13 = !flag12;
						object obj26 = !flag13;
						object obj27 = ~obj26;
						if (obj27 == null)
						{
							num9 = 3;
						}
						else
						{
							num9 = 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
						num4 = num5;
						num6 = num7;
						num2 = num11;
						obj = (object)(&num3);
					}
					object obj28 = 0;
					object obj29 = 0;
					Enumerator<, > val2 = (Enumerator<, >)(ref val);
					object obj30 = 0;
					array2 = (int[])(object)list4;
					object obj31 = 11;
					list2 = list3;
					object obj34 = default;
					while (true)
					{
						list = (List<PlayerRef>)obj12;
						val.Dispose();
						bool flag14 = obj30 == null;
						object obj32 = !flag14;
						if (obj32 == null)
						{
							bool flag15 = obj28 == null;
							object obj33 = !flag15;
							OutOfMemoryException ex = (OutOfMemoryException)(&val);
							if (obj33 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)list == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj28 = 1;
							obj30 = obj29;
							obj = 1;
						}
						else
						{
							if ((nint)list != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E42C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj30 = obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj29 = obj34;
						}
						obj31 = 0;
					}
					if ((nint)obj31 != 11)
					{
						bool flag16 = obj31 == null;
						object obj35 = !flag16;
						if (obj35 != null)
						{
							return;
						}
					}
					StartMonsters = (byte)array2.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X20_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					object obj36 = -array2.Length;
					object obj37 = obj36 - 255;
					bool flag17 = (nint)obj37 < 0;
					object obj38 = obj36 ^ 0xFF;
					object obj39 = obj36 ^ obj37;
					object obj40 = obj38 & obj39;
					bool flag18 = (nint)obj40 < 0;
					bool flag19 = flag17 == flag18;
					object obj41 = !flag19;
					object obj42 = ~obj41;
					if (obj42 != null)
					{
						obj36 = 255;
					}
					object obj43 = ~obj36;
					byte startApes = (byte)(obj36 & obj43);
					StartApes = startApes;
					Winner = 0;
					float now = Now;
					float huntLength = HuntLength;
					float huntEnds = now + huntLength;
					HuntEnds = huntEnds;
					int round = Round;
					int round2 = round + 1;
					Round = round2;
					phase = 1;
				}
				else
				{
					phase = 0;
				}
				Phase = phase;
				return;
			}
		}
		goto IL_0741;
		IL_0741:
		throw new NullReferenceException();
	}

	private unsafe List<PlayerRef> PickMonsters(List<PlayerRef> everyone, int monsters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0038: Expected Obj, but got Ref
		//IL_074f: Expected Obj, but got I
		//IL_075f: Expected Obj, but got I
		//IL_076f: Expected Obj, but got I
		//IL_077f: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_07cc: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got Ref
		//IL_0212: Expected Obj, but got I4
		//IL_0a6d: Expected Obj, but got I
		//IL_00a9: Expected VT, but got Obj
		//IL_0a82: Expected Obj, but got I
		//IL_0a8a: Expected VT, but got Obj
		//IL_0aae: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got I4
		//IL_05ed: Expected Obj, but got Ref
		//IL_00d8: Expected I, but got Obj
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected I4, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected VT, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got Ref
		//IL_0279: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I
		//IL_0855: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I4
		//IL_01aa: Expected I4, but got Obj
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected VT, but got Unknown
		//IL_0305: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I
		//IL_03a7: Expected VT, but got Obj
		//IL_03d0: Expected I, but got Obj
		//IL_03d8: Expected I4, but got Obj
		//IL_089d: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_08c7: Expected I, but got Obj
		//IL_08d8: Expected I, but got Obj
		//IL_08f6: Expected Obj, but got I
		//IL_090d: Expected I, but got Obj
		//IL_0915: Expected VT, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_0414: Expected I, but got Obj
		//IL_041c: Expected I4, but got Obj
		//IL_09db: Expected VT, but got Obj
		//IL_0a15: Expected Obj, but got I
		//IL_0a1d: Expected VT, but got Obj
		//IL_0a2f: Expected Obj, but got I4
		//IL_0a39: Expected Obj, but got I4
		//IL_0a49: Expected VT, but got Ref
		//IL_0a57: Expected Obj, but got I4
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_04cb: Expected Obj, but got I4
		//IL_0672: Invalid comparison between VT and I4
		//IL_04f8: Expected Obj, but got I4
		//IL_06c1: Invalid comparison between VT and I4
		//IL_0944: Expected Obj, but got I4
		//IL_094e: Expected Obj, but got I4
		//IL_0976: Expected VT, but got Ref
		//IL_097f: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I4
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected VT, but got Unknown
		//IL_0537: Expected I, but got Obj
		//IL_0558: Expected Obj, but got I4
		//IL_070a: Expected Obj, but got I
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_09ac: Expected I4, but got Obj
		//IL_0578: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28C0]");
		object obj3 = 0;
		Dictionary<PlayerRef, int>.Enumerator enumerator = default;
		object obj4 = (object)(&enumerator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28F8]");
		object obj8 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28E0]");
		object obj9 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
		object obj10 = 0;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PlayerRef, int> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<PlayerRef> hashSet = default;
		hashSet._002Ector();
		NetworkDictionary<PlayerRef, byte> turns = Turns;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		int num = 72;
		object obj13 = default;
		object obj15 = default;
		object obj19 = default;
		object obj21 = default;
		object obj25 = default;
		Func<double> func2 = default;
		object obj44 = default;
		object obj45 = default;
		object obj47 = default;
		object obj23 = default;
		object obj59 = default;
		List<PlayerRef> result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj12 = obj13 & 1;
			object obj17;
			object obj18;
			NullReferenceException ex;
			GillaModeRound gillaModeRound;
			Dictionary<PlayerRef, int> dictionary2;
			object obj20;
			object obj22;
			object obj24;
			if (obj12 != null)
			{
				PlayerRef playerRef = (PlayerRef)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
				if ((object)dictionary != null)
				{
					nint num2 = (nint)obj7;
					object obj14 = obj15 >> 32;
					num = obj14 & 0x7F;
					playerRef = (PlayerRef)(obj15 & 0xFFFFFFFFL);
					dictionary.set_Item(playerRef, num);
					object obj16 = obj15 & 0x8000000000L;
					if (obj16 == null)
					{
						continue;
					}
					bool flag = hashSet == null;
					obj17 = 0;
					obj18 = 0;
					ex = (NullReferenceException)(&obj19);
					obj20 = obj21;
					obj22 = obj23;
					obj24 = obj25;
					gillaModeRound = this;
					dictionary2 = dictionary;
					if (!flag)
					{
						num = (int)obj8;
						PlayerRef item = (PlayerRef)(obj15 & 0xFFFFFFFFL);
						bool flag2 = hashSet.Add(item);
						continue;
					}
					goto IL_0625;
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj17 = 0;
				obj18 = 0;
				ex = (NullReferenceException)(&obj19);
				obj20 = obj21;
				obj22 = obj23;
				obj24 = obj25;
				gillaModeRound = this;
				dictionary2 = dictionary;
				goto IL_0617;
			}
			obj17 = 0;
			obj18 = 0;
			ex = (NullReferenceException)(&obj19);
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj25;
			gillaModeRound = this;
			object obj26 = 0;
			dictionary2 = dictionary;
			NullReferenceException ex3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A8]");
				object obj27 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
					object obj28 = 0;
					PlayerRef playerRef = (PlayerRef)obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
					bool flag3 = obj26 == null;
					object obj29 = !flag3;
					if (obj29 != null)
					{
						break;
					}
					bool flag4 = obj17 == null;
					object obj30 = !flag4;
					ex3 = ex;
					if (obj30 == null)
					{
						object obj31 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v18+E4]");
						bool flag5 = (nint)0 == 0;
						object obj32 = !flag5;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj31 = obj27;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v18+A0]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v32+10]");
						Func<double> func = (Func<double>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v32+10]");
						bool flag6 = (nint)0 == 0;
						object obj34 = !flag6;
						nint num3 = num;
						nint num2;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v18+E4]");
							bool flag7 = (nint)0 == 0;
							object obj35 = !flag7;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj36 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v36+A0]");
								obj33 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28F0]");
							Dictionary<PlayerRef, int> dictionary3 = (Dictionary<PlayerRef, int>)0;
							obj6 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2920]");
							object obj37 = 0;
							num3 = (nint)obj37;
							func2._002Ector(obj33, (IntPtr)obj37);
							object obj38 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v35+A0]");
							object obj39 = (nint)0 + (nint)16;
							obj39 = func2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num2 = unchecked((nint)null);
							playerRef = (PlayerRef)func2;
							func = func2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
						object obj40 = 0;
						object obj41 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v20+E4]");
						bool flag8 = (nint)0 == 0;
						object obj42 = !flag8;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						List<PlayerRef> list = DrawMany(everyone, dictionary2, hashSet, func, monsters);
						NetworkDictionary<PlayerRef, byte> turns2 = gillaModeRound.Turns;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
						object obj43 = 0;
						playerRef = (PlayerRef)obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
						bool flag9 = (object)dictionary2 == null;
						int num4 = monsters;
						num2 = (nint)func;
						num = (int)hashSet;
						obj20 = obj44;
						obj22 = obj17;
						obj24 = obj45;
						if (flag9)
						{
							goto end_IL_0800;
						}
						Dictionary<PlayerRef, int>.Enumerator enumerator2 = dictionary2.GetEnumerator();
						num2 = (nint)func;
						num = (int)hashSet;
						obj20 = obj44;
						obj22 = obj17;
						obj24 = obj45;
						Dictionary<PlayerRef, int>.Enumerator enumerator3;
						while (true)
						{
							playerRef = (PlayerRef)obj9;
							if (!enumerator.MoveNext())
							{
								break;
							}
							NetworkDictionary<PlayerRef, byte> turns3 = gillaModeRound.Turns;
							object obj46 = obj47 >> 32;
							object obj48 = obj46 - 127;
							bool flag10 = (nint)obj48 < 0;
							object obj49 = obj46 ^ 0x7F;
							object obj50 = obj46 ^ obj48;
							object obj51 = obj49 & obj50;
							bool flag11 = (nint)obj51 < 0;
							bool flag12 = flag10 == flag11;
							object obj52 = !flag12;
							object obj53 = ~obj52;
							obj6 = ((obj53 != null) ? ((object)127) : obj46);
							bool flag13 = hashSet == null;
							obj23 = 0;
							obj7 = 127;
							num4 = monsters;
							obj20 = obj44;
							obj22 = obj17;
							obj24 = obj45;
							enumerator3 = (Dictionary<PlayerRef, int>.Enumerator)(&enumerator);
							dictionary2 = (Dictionary<PlayerRef, int>)128;
							if (!flag13)
							{
								PlayerRef item2 = (PlayerRef)(obj47 & 0xFFFFFFFFL);
								bool flag14 = hashSet.Contains(item2);
								bool flag15 = !flag14;
								num2 = (nint)obj10;
								object obj54 = ~obj6;
								object obj55 = obj6 & obj54;
								object obj56 = !flag15;
								obj53 = ~obj56;
								Dictionary<PlayerRef, int> dictionary3 = ((obj53 != null) ? null : ((Dictionary<PlayerRef, int>)128));
								object obj57 = obj47 & 0xFFFFFFFFL;
								num = (object)dictionary3 | obj55;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
								obj20 = obj44;
								obj22 = obj17;
								obj24 = obj45;
								continue;
							}
							goto IL_0617;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28D8]");
						object obj58 = 0;
						playerRef = (PlayerRef)obj58;
						enumerator.Dispose();
						obj23 = 0;
						obj7 = 127;
						num4 = monsters;
						enumerator3 = (Dictionary<PlayerRef, int>.Enumerator)(&enumerator);
						gillaModeRound = null;
						dictionary2 = (Dictionary<PlayerRef, int>)128;
						OutOfMemoryException ex4 = new OutOfMemoryException();
						if (playerRef == (PlayerRef)(object)2)
						{
							goto IL_0689;
						}
						if (playerRef == (PlayerRef)(object)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj26 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A8]");
							obj27 = 0;
							obj18 = obj59;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					goto IL_0633;
				}
				break;
				IL_0689:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj17 = 1;
				obj26 = obj18;
			}
			goto IL_0642;
			IL_0617:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0625;
			IL_0642:
			OutOfMemoryException ex6 = new OutOfMemoryException();
			break;
			IL_0625:
			ex3 = new NullReferenceException();
			goto IL_0633;
			IL_0633:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0642;
			continue;
			end_IL_0800:
			break;
		}
		throw new NullReferenceException();
	}

	public static int Waited(IDictionary<PlayerRef, int> waited, PlayerRef p)
	{
		//IL_010f: Expected I4, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		if ((object)waited != null)
		{
			nint num = (nint)waited;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<Fusion.PlayerRef, System.Int32>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<Fusion.PlayerRef, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<Fusion.PlayerRef, System.Int32>>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00a9;
			}
			object obj4 = obj3 + 7;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0150;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0150:
		object obj7 = p & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X0_v3] (should have been resolved before IL gen)");
		object obj9 = default;
		object obj8 = obj9 & 1;
		bool flag = obj8 == null;
		object obj10 = !flag;
		object obj11 = ~obj10;
		int result = default;
		if (obj11 == null)
		{
			return result;
		}
		return 1;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0150;
	}

	public static double Growth(int players, int monsters = default(int))
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected I4, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected I4, but got Unknown
		object obj = monsters - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = monsters ^ 1;
		int num2 = monsters ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : monsters);
		object obj5 = players - 1;
		bool flag5 = (nint)obj5 < 0;
		bool flag6 = obj5 == null;
		int num5 = players ^ 1;
		int num6 = players ^ obj5;
		int num7 = num5 & num6;
		bool flag7 = num7 < 0;
		bool flag8 = flag5 == flag7;
		object obj6 = !flag6;
		object obj7 = flag8 & obj6;
		object obj8 = ~obj7;
		int num8 = ((obj8 != null) ? 1 : players);
		object obj9 = num4 + num4;
		int num9 = obj9 / num8;
		return (double)num9 + 1.0;
	}

	public static double Weight(int rounds, int players, int monsters = default(int))
	{
		//IL_0190: Expected F8, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected I4, but got Unknown
		//IL_00f0: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected I4, but got Unknown
		//IL_0229: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_025b: Expected Obj, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected I4, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected I4, but got Unknown
		//IL_0331: Expected Obj, but got I4
		if (rounds >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = monsters - 1;
			bool flag2 = (nint)obj5 < 0;
			bool flag3 = obj5 == null;
			int num = monsters ^ 1;
			int num2 = monsters ^ obj5;
			int num3 = num & num2;
			bool flag4 = num3 < 0;
			object obj6 = obj3;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag3;
			object obj8 = flag5 & obj7;
			object obj9 = ~obj8;
			int num4 = ((obj9 != null) ? 1 : monsters);
			object obj10 = players - 1;
			bool flag6 = (nint)obj10 < 0;
			bool flag7 = obj10 == null;
			int num5 = players ^ 1;
			int num6 = players ^ obj10;
			int num7 = num5 & num6;
			bool flag8 = num7 < 0;
			bool flag9 = flag6 == flag8;
			object obj11 = !flag7;
			object obj12 = flag9 & obj11;
			object obj13 = ~obj12;
			int num8 = ((obj13 != null) ? 1 : players);
			object obj14 = rounds - 127;
			bool flag10 = (nint)obj14 < 0;
			int num9 = rounds ^ 0x7F;
			int num10 = rounds ^ obj14;
			int num11 = num9 & num10;
			bool flag11 = num11 < 0;
			bool flag12 = flag10 == flag11;
			object obj15 = !flag12;
			object obj16 = ~obj15;
			int num12 = ((obj16 != null) ? 127 : rounds);
			double y = (double)num12 - 1.0;
			object obj17 = num4 + num4;
			int num13 = obj17 / num8;
			double x = (double)num13 + 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
			bool flag13 = (nint)0 == 0;
			object obj18 = !flag13;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Math.Pow(x, y);
		}
		return 0.0;
	}

	public static int DueAfter(int players, int monsters = default(int))
	{
		//IL_00fa: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected I4, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_0204: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = players - 1;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = obj4 == null;
		int num = players ^ 1;
		int num2 = players ^ obj4;
		int num3 = num & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag2 == flag4;
		object obj5 = !flag3;
		object obj6 = flag5 & obj5;
		object obj7 = ~obj6;
		int num4 = ((obj7 != null) ? 1 : players);
		object obj8 = monsters - 1;
		bool flag6 = (nint)obj8 < 0;
		bool flag7 = obj8 == null;
		int num5 = monsters ^ 1;
		int num6 = monsters ^ obj8;
		int num7 = num5 & num6;
		bool flag8 = num7 < 0;
		bool flag9 = flag6 == flag8;
		object obj9 = !flag7;
		object obj10 = flag9 & obj9;
		object obj11 = ~obj10;
		int num8 = ((obj11 != null) ? 1 : monsters);
		double num9 = (double)num4 * 1.25;
		double num10 = num9 / (double)num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		return (int)num10;
	}

	public static Dictionary<PlayerRef, float> Chances(IEnumerable<PlayerRef> everyone, Func<PlayerRef, int> waitedOf, Func<PlayerRef, bool> dueOf, int monsters = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected I4, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_01f1: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_0385: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB68]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj4 = default;
		obj4._002Ector();
		IEnumerable<PlayerRef> source = Enumerable.Distinct(everyone);
		List<PlayerRef> list = Enumerable.ToList(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PlayerRef, float> dictionary = default;
		dictionary._002Ector();
		if ((object)list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
			if ((nint)0 == 0)
			{
				goto IL_03b7;
			}
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				object obj5 = (nint)monsters - (nint)0;
				bool flag = (nint)obj5 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				int num = (int)((nint)monsters ^ (nint)0);
				int num2 = monsters ^ obj5;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2948]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2958]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2988]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29F0]");
				object obj9 = 0;
				bool flag3 = flag == flag2;
				object obj10 = !flag3;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					int num4 = monsters;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					int num4 = 0;
				}
				if (monsters < 1)
				{
					int num4 = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				_ = 0;
				IEnumerable<int> source2 = Enumerable.Select((IEnumerable<PlayerRef>)list, waitedOf);
				int[] array = Enumerable.ToArray(source2);
				IEnumerable<bool> source3 = Enumerable.Select((IEnumerable<PlayerRef>)list, dueOf);
				bool[] dues = Enumerable.ToArray(source3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Func<int, double> func = default;
				func._002Ector(obj4, (IntPtr)obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2940]");
				object obj12 = 0;
				IEnumerable<double> source4 = Enumerable.Select(array, func);
				double[] weights = Enumerable.ToArray(source4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+14]");
				bool[] taken = default;
				double[] array2 = default;
				Picks(array, dues, weights, taken, 1.0, 0, array2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+10]");
				if ((nint)0 < (nint)1)
				{
					goto IL_03b7;
				}
				object obj18 = array2 + 32;
				int num5 = 0;
				while (true)
				{
					PlayerRef key = list.get_Item(num5);
					if (array2 == null)
					{
						break;
					}
					bool flag5 = num5 < array2.Length;
					object obj19 = !flag5;
					if (obj19 == null)
					{
						if ((object)dictionary == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X26_v10+v170 @ X23_v8 (System.Int32)*8]");
						dictionary.set_Item(key, 0f);
						num5++;
						int num6 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+10]");
						if ((nint)num6 < (nint)0)
						{
							continue;
						}
						goto IL_03b7;
					}
					goto IL_03ca;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03ca;
		IL_03b7:
		return dictionary;
		IL_03ca:
		return (Dictionary<PlayerRef, float>)(object)new IndexOutOfRangeException();
	}

	private unsafe static void Picks(int[] waits, bool[] dues, double[] weights, bool[] taken, double reach, int picks, double[] share)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_01d7: Expected F8, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00b3: Expected F8, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_05df: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_027d: Invalid comparison between F8 and I4
		//IL_0580: Invalid comparison between F8 and I4
		//IL_0591: Expected Obj, but got I4
		//IL_059a: Invalid comparison between F8 and I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_030d: Expected I4, but got F8
		//IL_033c: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected I4, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I4
		//IL_0485: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int left = default;
		int num = Longest(waits, dues, taken, ref left);
		if (left == 0)
		{
			return;
		}
		object obj4 = waits.Length;
		double num5;
		int num6;
		int num3;
		bool[] array;
		bool[] array2;
		if (waits.Length >= 1)
		{
			object obj5 = taken + 32;
			double num2 = reach;
			num3 = picks;
			int num4 = 0;
			num5 = 0.0;
			array = taken;
			array2 = dues;
			num6 = (int)(&left);
			while (true)
			{
				bool flag2 = num4 < taken.Length;
				object obj6 = !flag2;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X29_v8+v217 @ X26_v10 (System.Int32)]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v25+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num2 = Pull(waits, dues, weights, num, num4);
					num5 += num2;
					num3 = num4;
					array = (bool[])(object)weights;
					array2 = dues;
					num6 = num;
				}
				obj4 = waits.Length;
				num4++;
				if (num4 < waits.Length)
				{
					continue;
				}
				goto IL_052e;
			}
			goto IL_04ab;
		}
		num3 = picks;
		num5 = 0.0;
		array = taken;
		array2 = dues;
		num6 = (int)(&left);
		goto IL_052e;
		IL_04ab:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_052e:
		if ((nint)obj4 < 1)
		{
			return;
		}
		int num7 = picks - 1;
		double num8 = reach / (double)left;
		double[] array3 = share;
		int num9 = left;
		int num10 = 0;
		bool[] array4 = (bool[])num6;
		while (true)
		{
			bool flag5 = num10 < taken.Length;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				break;
			}
			object obj11 = taken + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X29_v6+20]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				bool flag7 = !(num5 > 0.0);
				double num11 = num8;
				if (!flag7)
				{
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v17+E4]");
					bool flag8 = (nint)0 == 0;
					object obj14 = !flag8;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num12 = Pull(waits, dues, weights, num, num10);
					num9 = (int)(num12 * reach);
					num11 = (double)num9 / num5;
					num3 = num10;
					array = (bool[])(object)weights;
					array2 = dues;
					array4 = (bool[])num;
				}
				bool flag9 = num11 < 0.0;
				object obj15 = !flag9;
				bool flag10 = num11 == 0.0;
				object obj16 = ~obj15;
				object obj17 = obj16 | flag10;
				if (obj17 == null)
				{
					bool flag11 = num10 < share.Length;
					object obj18 = !flag11;
					if (obj18 != null)
					{
						break;
					}
					object obj19 = share + num10;
					double num13 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v15+20]");
					num9 = (int)(num13 + 0);
					if (picks >= 2)
					{
						bool flag12 = num10 < taken.Length;
						object obj20 = !flag12;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = obj;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v13+E4]");
						bool flag13 = (nint)0 == 0;
						object obj22 = !flag13;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Picks(waits, dues, weights, taken, num11, num7, share);
						bool flag14 = num10 < taken.Length;
						object obj23 = !flag14;
						if (obj23 != null)
						{
							break;
						}
						_ = 0;
						array3 = share;
						num9 = (int)num11;
						num3 = num7;
						array = (bool[])(object)weights;
						array2 = dues;
						array4 = taken;
					}
				}
			}
			num10++;
			if (num10 >= waits.Length)
			{
				return;
			}
		}
		goto IL_04ab;
	}

	private unsafe static int Longest(int[] waits, bool[] dues, bool[] taken, ref int left)
	{
		//IL_0291: Expected I4, but got Obj
		//IL_0270: Expected I4, but got I8
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_008e: Expected I4, but got I8
		//IL_00ae: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected I4, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		ref int reference = ref *(int*)null;
		int num;
		if (waits != null)
		{
			if (waits.Length < 1)
			{
				num = -1;
				goto IL_02bd;
			}
			object obj = waits + 32;
			object obj2 = dues + 32;
			object obj3 = taken + 32;
			object obj4 = 0;
			object obj5 = 0;
			num = -1;
			while (taken != null)
			{
				bool flag = (nint)obj5 < taken.Length;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_0275;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X13_v3+v45 @ X9_v4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					obj4++;
					reference = ref *(int*)obj4;
					if (dues == null)
					{
						break;
					}
					bool flag3 = (nint)obj5 < dues.Length;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						goto IL_0275;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X12_v3+v45 @ X9_v4]");
					if ((nint)0 != 0)
					{
						bool flag4 = (nint)obj5 < waits.Length;
						object obj9 = !flag4;
						if (obj9 != null)
						{
							goto IL_0275;
						}
						int num2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X11_v3+v45 @ X9_v4*4]");
						object obj10 = (nint)num2 - (nint)0;
						bool flag5 = (nint)obj10 < 0;
						bool flag6 = obj10 == null;
						int num3 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X11_v3+v45 @ X9_v4*4]");
						int num4 = (int)((nint)num3 ^ (nint)0);
						int num5 = num ^ obj10;
						int num6 = num4 & num5;
						bool flag7 = num6 < 0;
						bool flag8 = flag5 == flag7;
						object obj11 = !flag6;
						object obj12 = flag8 & obj11;
						object obj13 = ~obj12;
						if (obj13 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X11_v3+v45 @ X9_v4*4]");
							num = 0;
						}
					}
				}
				obj5++;
				if ((nint)obj5 < waits.Length)
				{
					continue;
				}
				goto IL_02bd;
				IL_0275:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_02bd:
		return num;
	}

	private static double Pull(int[] waits, bool[] dues, double[] weights, int most, int i)
	{
		//IL_0012: Expected I4, but got I8
		//IL_002c: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_024b: Expected F8, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_0259: Expected F8, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_01af: Expected F8, but got I4
		int num = (int)(most & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			if (dues == null)
			{
				goto IL_025e;
			}
			bool flag2 = dues.Length < i;
			object obj2 = !flag2;
			object obj3 = dues.Length - i;
			bool flag3 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag3;
			if (obj5 == null)
			{
				object obj6 = dues + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v4+20]");
				if ((nint)0 == 0)
				{
					return 0.0;
				}
				if (waits == null)
				{
					goto IL_025e;
				}
				bool flag4 = waits.Length < i;
				object obj7 = !flag4;
				object obj8 = waits.Length - i;
				bool flag5 = obj8 == null;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag5;
				if (obj10 == null)
				{
					object obj11 = waits + i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v8+20]");
					if ((nint)0 == most)
					{
						return 1.0;
					}
					return 0.0;
				}
			}
		}
		else
		{
			if (weights == null)
			{
				goto IL_025e;
			}
			bool flag6 = weights.Length < i;
			object obj12 = !flag6;
			object obj13 = weights.Length - i;
			bool flag7 = obj13 == null;
			object obj14 = ~obj12;
			object obj15 = obj14 | flag7;
			if (obj15 == null)
			{
				object obj16 = weights + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5+20]");
				return 0.0;
			}
		}
		goto IL_026c;
		IL_026c:
		throw new IndexOutOfRangeException();
		IL_025e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_026c;
	}

	public unsafe static List<PlayerRef> DrawMany(List<PlayerRef> everyone, Dictionary<PlayerRef, int> waited, HashSet<PlayerRef> due, Func<double> roll, int monsters)
	{
		//IL_0010: Expected Obj, but got I
		//IL_16ca: Expected VT, but got I4
		//IL_16d3: Expected VT, but got I4
		//IL_1702: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0112: Expected VT, but got I4
		//IL_011b: Expected VT, but got I4
		//IL_019f: Expected F8, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected I4, but got Unknown
		//IL_0211: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I4
		//IL_175a: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_02e4: Expected VT, but got I4
		//IL_02ed: Expected VT, but got I4
		//IL_0349: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0381: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03ff: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_041c: Expected I, but got Obj
		//IL_0450: Expected VT, but got I
		//IL_0460: Expected Obj, but got I
		//IL_049a: Expected VT, but got I4
		//IL_0f12: Expected I, but got Obj
		//IL_0f22: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I4
		//IL_0fa9: Expected Obj, but got I4
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got Unknown
		//IL_04cd: Expected VT, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_195d: Expected Obj, but got I
		//IL_196d: Expected Obj, but got I
		//IL_198d: Expected Obj, but got I
		//IL_199d: Expected Obj, but got I
		//IL_19ad: Expected Obj, but got I
		//IL_19cf: Expected Obj, but got I4
		//IL_191d: Expected I, but got Obj
		//IL_193f: Expected Obj, but got I4
		//IL_1035: Expected Obj, but got I
		//IL_1050: Expected I, but got Obj
		//IL_0518: Expected Obj, but got I
		//IL_0537: Expected Obj, but got Ref
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected Obj, but got Unknown
		//IL_0ff0: Expected Obj, but got I4
		//IL_0980: Expected VT, but got I4
		//IL_0988: Expected I4, but got Obj
		//IL_09a0: Expected I4, but got Obj
		//IL_109f: Expected Obj, but got I
		//IL_10ba: Expected I, but got Obj
		//IL_1a0f: Expected Obj, but got I
		//IL_1a17: Expected I, but got Obj
		//IL_1a28: Expected I, but got Obj
		//IL_1a46: Expected Obj, but got I
		//IL_1a65: Expected I4, but got Obj
		//IL_0576: Expected VT, but got I4
		//IL_057e: Expected Obj, but got Ref
		//IL_05a6: Expected I4, but got Obj
		//IL_10e8: Expected Obj, but got I
		//IL_1020: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_09ff: Invalid comparison between F8 and I4
		//IL_0a12: Expected Obj, but got F8
		//IL_0a1f: Expected Obj, but got F8
		//IL_0a54: Expected Obj, but got I4
		//IL_112b: Expected VT, but got I4
		//IL_181e: Invalid comparison between F8 and I4
		//IL_1831: Expected Obj, but got F8
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_183e: Expected Obj, but got Unknown
		//IL_1866: Expected Obj, but got I4
		//IL_186f: Expected I4, but got Obj
		//IL_05bc: Expected F8, but got VT
		//IL_05c5: Expected F8, but got I4
		//IL_05cd: Expected Obj, but got Ref
		//IL_0a8a: Expected Obj, but got F8
		//IL_1bb9: Expected Obj, but got I4
		//IL_1bc1: Expected VT, but got F8
		//IL_1163: Expected Obj, but got I4
		//IL_1174: Expected Obj, but got I
		//IL_1195: Expected VT, but got I4
		//IL_1579: Expected VT, but got I4
		//IL_0be1: Expected VT, but got I4
		//IL_0bf1: Expected VT, but got F8
		//IL_0bf9: Expected I4, but got Obj
		//IL_0c11: Expected I4, but got Obj
		//IL_060d: Expected Obj, but got I4
		//IL_11c1: Expected Obj, but got I
		//IL_11d1: Expected Obj, but got I
		//IL_11e1: Expected Obj, but got I
		//IL_0ab0: Expected VT, but got I4
		//IL_0ac0: Expected VT, but got F8
		//IL_0ac8: Expected I4, but got Obj
		//IL_0ae0: Expected I4, but got Obj
		//IL_0c34: Expected I4, but got I8
		//IL_062b: Expected I, but got Obj
		//IL_064d: Expected Obj, but got I4
		//IL_1b66: Expected Obj, but got I4
		//IL_1b6e: Expected VT, but got Ref
		//IL_1b8f: Expected Obj, but got I4
		//IL_17f7: Expected Obj, but got I4
		//IL_17ff: Expected VT, but got F8
		//IL_1807: Expected I4, but got Obj
		//IL_0af8: Expected Obj, but got I4
		//IL_0b01: Expected F8, but got I4
		//IL_0b0e: Expected I4, but got I8
		//IL_06d4: Invalid comparison between F8 and I4
		//IL_06e5: Expected Obj, but got I4
		//IL_06ee: Invalid comparison between F8 and I4
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_0712: Expected VT, but got F8
		//IL_06a6: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I4
		//IL_1221: Expected Obj, but got I4
		//IL_1229: Expected VT, but got Ref
		//IL_18e9: Invalid comparison between Obj and F8
		//IL_18ff: Expected VT, but got F8
		//IL_1907: Expected I4, but got Obj
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Expected Obj, but got Unknown
		//IL_0c64: Expected Obj, but got I
		//IL_0c9e: Expected VT, but got I4
		//IL_0ca6: Expected VT, but got F8
		//IL_0cc7: Expected Obj, but got I4
		//IL_0ccf: Expected I4, but got Obj
		//IL_0741: Expected VT, but got I4
		//IL_0749: Expected VT, but got F8
		//IL_0751: Expected I4, but got Obj
		//IL_0769: Expected I4, but got Obj
		//IL_1277: Expected VT, but got I8
		//IL_1290: Expected Obj, but got I4
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0ced: Expected Obj, but got I
		//IL_0cfd: Expected Obj, but got I
		//IL_0d1d: Expected I4, but got Obj
		//IL_0d4b: Expected VT, but got I4
		//IL_0d53: Expected VT, but got F8
		//IL_0d6b: Expected Obj, but got I4
		//IL_0d73: Expected I4, but got Obj
		//IL_18c2: Invalid comparison between F8 and I
		//IL_0787: Expected Obj, but got I
		//IL_07b0: Expected VT, but got F8
		//IL_07b8: Expected I4, but got Obj
		//IL_0b67: Expected I4, but got F8
		//IL_0d91: Expected F8, but got I
		//IL_0da1: Expected Obj, but got I
		//IL_0dca: Expected Obj, but got I4
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b8b: Expected I4, but got I8
		//IL_0ba5: Expected Obj, but got I4
		//IL_07de: Expected F8, but got I4
		//IL_07f4: Expected I4, but got I8
		//IL_1666: Unknown result type (might be due to invalid IL or missing references)
		//IL_1673: Expected Obj, but got I4
		//IL_0e34: Expected Obj, but got I
		//IL_0e44: Expected Obj, but got I
		//IL_0e54: Expected Obj, but got I
		//IL_1bf2: Expected Obj, but got I4
		//IL_1bfa: Expected VT, but got F8
		//IL_1c02: Expected I4, but got Obj
		//IL_1afa: Expected Obj, but got I
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0b: Expected Ref, but got Unknown
		//IL_1b25: Expected Obj, but got I4
		//IL_1b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2d: Expected VT, but got Unknown
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected Obj, but got Unknown
		//IL_0eaa: Expected VT, but got F8
		//IL_0eb2: Expected I, but got Obj
		//IL_0e1f: Expected VT, but got I4
		//IL_081b: Expected Obj, but got I4
		//IL_14ee: Expected Obj, but got I4
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected VT, but got Unknown
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Expected Obj, but got Unknown
		//IL_0ec8: Expected VT, but got F8
		//IL_0ed0: Expected I, but got Obj
		//IL_0831: Expected I, but got Obj
		//IL_0853: Expected Obj, but got I4
		//IL_0896: Invalid comparison between F8 and I4
		//IL_08a7: Expected Obj, but got I4
		//IL_08b0: Invalid comparison between F8 and I4
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_08dc: Expected Obj, but got I4
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1543: Expected Obj, but got Unknown
		//IL_0ee5: Expected Obj, but got I4
		//IL_0935: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2928]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		int num2 = default;
		int num = num2;
		Dictionary<PlayerRef, int>.Enumerator enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
		Dictionary<PlayerRef, int>.Enumerator enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)0;
		int left = 0;
		Func<double> func = roll;
		bool[] array = null;
		List<PlayerRef> list = everyone;
		int num4 = default;
		int num3 = num4;
		List<PlayerRef> list2 = (List<PlayerRef>)109895680;
		double[] array4;
		List<PlayerRef> list3;
		object obj4;
		int num16;
		double num19;
		bool[] array3;
		object obj5;
		HashSet<PlayerRef> hashSet = default;
		nint num15;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2938]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E28]");
			bool[] array2 = (bool[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29A0]");
			array3 = (bool[])0;
			array4 = (double[])(obj2 + 16);
			array4 = (double[])(object)waited;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			double[] array5 = (double[])(obj2 + 40);
			array5 = (double[])(object)hashSet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			IEnumerable<PlayerRef> source = Enumerable.Distinct((IEnumerable<PlayerRef>)everyone);
			list3 = Enumerable.ToList(source);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<PlayerRef> list4 = default;
			list4._002Ector();
			obj4 = obj2 + 32;
			obj4 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag2 = (object)list3 == null;
			num = num2;
			enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
			enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)0;
			left = 0;
			func = roll;
			obj5 = obj4;
			array = (bool[])(object)list4;
			list = everyone;
			num3 = num4;
			list2 = list3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v38 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				bool flag3 = (nint)0 == 0;
				obj5 = obj4;
				if (flag3)
				{
					goto IL_1551;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2980]");
				double num5 = 0.0;
				int num6 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v38 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				object obj6 = (nint)num6 - (nint)0;
				bool flag4 = (nint)obj6 < 0;
				int num7 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v38 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				int num8 = (int)((nint)num7 ^ (nint)0);
				int num9 = num4 ^ obj6;
				int num10 = num8 & num9;
				bool flag5 = num10 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2950]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9F10]");
				obj = 0;
				bool flag6 = flag4 == flag5;
				object obj9 = !flag6;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					int num11 = num4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v38 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
					int num11 = 0;
				}
				if (num4 < 1)
				{
					int num11 = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v38 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Func<PlayerRef, int> func2 = default;
				func2._002Ector(obj2, (IntPtr)obj7);
				hashSet = (HashSet<PlayerRef>)obj8;
				IEnumerable<int> source2 = Enumerable.Select((IEnumerable<PlayerRef>)list3, func2);
				array = (bool[])obj;
				int[] array6 = Enumerable.ToArray(source2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+28]");
				bool flag7 = (nint)0 == 0;
				num = num2;
				enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
				enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)0;
				left = 0;
				func = null;
				obj5 = obj4;
				list = everyone;
				num3 = num4;
				list2 = list3;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
					int num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2948]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2958]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2988]");
					int num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29C0]");
					object obj14 = 0;
					nint num13 = (nint)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					list = (List<PlayerRef>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+28]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v19 (Il2CppClass<System.Object>)+1C0]");
					Func<PlayerRef, bool> func3 = default;
					func3._002Ector((object)num14, (IntPtr)0);
					IEnumerable<bool> source3 = Enumerable.Select((IEnumerable<PlayerRef>)list3, func3);
					bool[] array7 = Enumerable.ToArray(source3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Func<int, double> func4 = default;
					func4._002Ector(obj2, (IntPtr)obj14);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2940]");
					object obj15 = 0;
					num15 = (nint)obj15;
					IEnumerable<double> source4 = Enumerable.Select(array6, func4);
					double[] array8 = Enumerable.ToArray(source4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
					PlayerRef playerRef = (PlayerRef)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+1C]");
					num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+1C]");
					bool flag8 = (nint)0 < (nint)1;
					enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)0;
					left = 0;
					func = null;
					if (flag8)
					{
						goto IL_0f0a;
					}
					bool[] array9 = default;
					list2 = (List<PlayerRef>)(array9 + 32);
					enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)0;
					func = null;
					obj = 0;
					while (true)
					{
						nint num17 = (nint)list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X0_v107 (Il2CppClass<System.Collections.Generic.List`1<Fusion.PlayerRef>>)+E4]");
						bool flag9 = (nint)0 == 0;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num18 = Longest(array6, array7, array9, ref left);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
						bool flag10 = (nint)0 < (nint)1;
						func = (Func<double>)(&left);
						hashSet = (HashSet<PlayerRef>)(object)array9;
						array = array7;
						if (flag10)
						{
							goto IL_095f;
						}
						bool flag11 = array9 == null;
						num = num2;
						enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
						func = (Func<double>)(&left);
						hashSet = (HashSet<PlayerRef>)(object)array9;
						obj5 = obj4;
						array3 = array7;
						array = array7;
						num3 = (int)array6;
						if (flag11)
						{
							break;
						}
						num19 = (double)enumerator2;
						double num20 = 0.0;
						func = (Func<double>)(&left);
						bool[] array10 = array9;
						array = array7;
						int num21 = 0;
						while (true)
						{
							num11 = array9.Length;
							bool flag12 = num21 < array9.Length;
							object obj19 = !flag12;
							enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
							hashSet = (HashSet<PlayerRef>)(object)array10;
							if (obj19 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X22_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+v1291 @ X19_v46 (System.Int32)]");
							bool flag13 = (nint)0 == 0;
							object obj20 = !flag13;
							hashSet = (HashSet<PlayerRef>)(object)array10;
							if (obj20 == null)
							{
								nint num22 = (nint)list;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X0_v131 (Il2CppClass<System.Collections.Generic.List`1<Fusion.PlayerRef>>)+E4]");
								bool flag14 = (nint)0 == 0;
								object obj21 = !flag14;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num19 = Pull(array6, array7, array8, num18, num21);
								num20 += num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
								obj18 = 0;
								num4 = num21;
								func = (Func<double>)num18;
								hashSet = (HashSet<PlayerRef>)(object)array8;
								array = array7;
							}
							num21++;
							bool flag15 = num21 < (nint)obj18;
							array10 = (bool[])(object)hashSet;
							if (flag15)
							{
								continue;
							}
							goto IL_06cb;
						}
						goto IL_155e;
						IL_095f:
						bool flag16 = roll == null;
						num = num2;
						enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
						num11 = (int)roll;
						obj5 = obj4;
						array3 = array7;
						num3 = (int)array6;
						if (flag16)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [roll @ X3 (System.Func`1<System.Double>)+28]");
						array = (bool[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [roll @ X3 (System.Func`1<System.Double>)+18] (should have been resolved before IL gen)");
						num5 = (double)left - 1.0;
						num19 = (double)enumerator2 * (double)left;
						double num23 = num19 - num5;
						bool flag17 = num23 < 0.0;
						object obj22 = num19 ^ num5;
						object obj23 = num19 ^ num23;
						object obj24 = obj22 & obj23;
						bool flag18 = (nint)obj24 < 0;
						bool flag19 = flag17 == flag18;
						object obj25 = !flag19;
						object obj26 = ~obj25;
						if (obj26 == null)
						{
							num5 = num19;
						}
						bool flag20 = num19 < 0.0;
						object obj27 = num19 ^ num19;
						object obj28 = num19 & obj27;
						bool flag21 = (nint)obj28 < 0;
						bool flag22 = flag20 == flag21;
						object obj29 = !flag22;
						Func<double> func5 = (((int)(~obj29) != 0) ? ((Func<double>)num5) : null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
						int num25;
						int num24;
						if ((nint)0 >= (nint)1)
						{
							bool flag23 = array9 == null;
							num = num2;
							enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
							num24 = left;
							enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
							num11 = (int)func5;
							obj5 = obj4;
							array3 = array7;
							num3 = (int)array6;
							if (flag23)
							{
								break;
							}
							object obj30 = array9.Length;
							num5 = 0.0;
							num25 = -1;
							while (true)
							{
								bool flag24 = obj30 == (object)num5;
								num24 = left;
								enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
								num11 = (int)func5;
								if (flag24)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X22_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+v318 @ X10_v13 (System.Double)]");
								object obj31 = 0 | func5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X22_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+v318 @ X10_v13 (System.Double)]");
								bool flag25 = (nint)0 == 0;
								if (obj31 == null)
								{
									num25 = (int)num5;
								}
								num5++;
								double num26 = num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
								bool flag26 = !(num26 < 0.0);
								num24 = left;
								if (!flag26)
								{
									func5 = (Func<double>)(func5 - flag25);
									int num27 = (int)(num25 & 0x80000000L);
									bool flag27 = num27 == 0;
									object obj32 = !flag27;
									if (obj32 != null)
									{
										continue;
									}
									num24 = left;
								}
								goto IL_17dc;
							}
							goto IL_155e;
						}
						bool flag28 = array9 == null;
						num = num2;
						enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
						num24 = left;
						enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
						num11 = (int)func5;
						obj5 = obj4;
						array3 = array7;
						num3 = (int)array6;
						if (flag28)
						{
							break;
						}
						num24 = left;
						num25 = -1;
						goto IL_17dc;
						IL_0952:
						func5 = roll;
						goto IL_17dc;
						IL_17dc:
						bool flag29 = num25 < array9.Length;
						object obj33 = !flag29;
						enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
						num11 = (int)func5;
						if (obj33 == null)
						{
							object obj34 = array9 + num25;
							_ = 1;
							List<PlayerRef> list5 = (List<PlayerRef>)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2898]");
							object obj35 = 0;
							hashSet = (HashSet<PlayerRef>)obj35;
							PlayerRef playerRef2 = list3.get_Item(num25);
							bool flag30 = obj4 == null;
							num = num2;
							enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
							enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
							num11 = 1;
							obj5 = obj4;
							array3 = array7;
							array = (bool[])num25;
							num3 = (int)array6;
							if (flag30)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+10]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2998]");
							object obj37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+1C]");
							num5 = 0.0 + 1.0;
							num11 = (int)obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+10]");
							bool flag31 = (nint)0 == 0;
							num = num2;
							enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
							enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
							obj5 = obj4;
							array3 = array7;
							array = (bool[])num25;
							num3 = (int)array6;
							if (flag31)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
							num5 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v68+18]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v68+18]");
							bool flag32 = num28 < 0;
							object obj38 = !flag32;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+10]");
								double num29 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
								double num30 = num29 + 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v31 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
								num11 = (int)((nint)0 + (nint)1);
								playerRef = (PlayerRef)num25;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X9_v26 (System.Int32)+20]");
								object obj39 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ X8_v70+A8]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1616 @ X8_v71+70]");
								hashSet = (HashSet<PlayerRef>)0;
								((List<PlayerRef>)obj4).AddWithResize(playerRef2);
								playerRef = playerRef2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+1C]");
							num16 = 0;
							obj++;
							object obj41 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+1C]");
							bool flag33 = (nint)obj41 < 0;
							enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
							num15 = (nint)hashSet;
							if (flag33)
							{
								continue;
							}
							goto IL_0ec0;
						}
						goto IL_155e;
						IL_155e:
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						num = num2;
						enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
						obj5 = obj4;
						break;
						IL_0ed5:
						int num31;
						num4 = num31;
						func = (Func<double>)num18;
						hashSet = (HashSet<PlayerRef>)(object)array8;
						func5 = roll;
						array = array7;
						num25 = num31;
						goto IL_17dc;
						IL_06cb:
						bool flag34 = num20 < 0.0;
						object obj42 = !flag34;
						bool flag35 = num20 == 0.0;
						object obj43 = ~obj42;
						object obj44 = obj43 | flag35;
						enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
						if (obj44 != null)
						{
							goto IL_095f;
						}
						bool flag36 = roll == null;
						num = num2;
						enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
						enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
						num11 = (int)roll;
						obj5 = obj4;
						array3 = array7;
						num3 = (int)array6;
						if (flag36)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [roll @ X3 (System.Func`1<System.Double>)+28]");
						array = (bool[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [roll @ X3 (System.Func`1<System.Double>)+18] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
						bool flag37 = (nint)0 < (nint)1;
						enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
						num11 = (int)roll;
						if (!flag37)
						{
							num20 *= num19;
							double num32 = 0.0;
							num31 = 0;
							num25 = -1;
							while (true)
							{
								bool flag38 = num31 < array9.Length;
								object obj45 = !flag38;
								enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
								num11 = (int)roll;
								if (obj45 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X22_v2 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+v1370 @ X20_v34 (System.Int32)]");
								bool flag39 = (nint)0 == 0;
								object obj46 = !flag39;
								if (obj46 == null)
								{
									nint num33 = (nint)list;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1559 @ X0_v127 (Il2CppClass<System.Collections.Generic.List`1<Fusion.PlayerRef>>)+E4]");
									bool flag40 = (nint)0 == 0;
									object obj47 = !flag40;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num19 = Pull(array6, array7, array8, num18, num31);
									bool flag41 = num19 < 0.0;
									object obj48 = !flag41;
									bool flag42 = num19 == 0.0;
									object obj49 = ~obj48;
									object obj50 = obj49 | flag42;
									num4 = num31;
									func = (Func<double>)num18;
									hashSet = (HashSet<PlayerRef>)(object)array8;
									array = array7;
									if (obj50 == null)
									{
										num32 += num19;
										if (num20 < num32)
										{
											goto IL_0ed5;
										}
										num4 = num31;
										func = (Func<double>)num18;
										hashSet = (HashSet<PlayerRef>)(object)array8;
										array = array7;
										num25 = num31;
									}
								}
								num31++;
								int num34 = num31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
								if ((nint)num34 < (nint)0)
								{
									continue;
								}
								goto IL_0952;
							}
						}
						goto IL_155e;
					}
				}
			}
		}
		goto IL_1586;
		IL_0f0a:
		nint num35 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28A8]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X0_v62 (Il2CppClass<System.Collections.Generic.List`1<Fusion.PlayerRef>>)+E4]");
		bool flag43 = (nint)0 == 0;
		object obj52 = !flag43;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+18]");
		int num36 = DueAfter(0, num16);
		object obj53 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v67+E4]");
		bool flag44 = (nint)0 == 0;
		object obj54 = !flag44;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj53 = obj51;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29C8]");
		array3 = (bool[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v67+A0]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2968]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29D0]");
		list2 = (List<PlayerRef>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v53+18]");
		Func<PlayerRef, PlayerRef> keySelector = (Func<PlayerRef, PlayerRef>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2970]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v53+18]");
		bool flag45 = (nint)0 == 0;
		object obj56 = !flag45;
		int num37 = num16;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v67+E4]");
			bool flag46 = (nint)0 == 0;
			object obj57 = !flag46;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj58 = obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v57+A0]");
				obj55 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2978]");
			int num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29B0]");
			object obj59 = 0;
			num15 = (nint)obj59;
			Func<PlayerRef, PlayerRef> func6 = default;
			func6._002Ector(obj55, (IntPtr)obj59);
			object obj60 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X8_v56+A0]");
			object obj61 = (nint)0 + (nint)24;
			obj61 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func = null;
			num37 = (int)func6;
			keySelector = func6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2980]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<PlayerRef, int> func7 = default;
		func7._002Ector(obj2, (IntPtr)array3);
		Dictionary<PlayerRef, int> dictionary = Enumerable.ToDictionary((IEnumerable<PlayerRef>)list3, keySelector, func7);
		object obj63 = obj2 + 48;
		obj63 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<PlayerRef, bool> func8 = default;
		func8._002Ector(obj2, (IntPtr)list2);
		hashSet = (HashSet<PlayerRef>)obj;
		IEnumerable<PlayerRef> source5 = Enumerable.Where((IEnumerable<PlayerRef>)list3, func8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E28]");
		object obj65 = 0;
		array = (bool[])obj65;
		List<PlayerRef> list6 = Enumerable.ToList(source5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+10]");
		bool flag47 = (nint)0 == 0;
		num = num2;
		enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
		func = null;
		obj5 = obj4;
		List<PlayerRef> result2;
		if (!flag47)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2930]");
			int num11 = 0;
			array = (bool[])((int*)num11)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Object)+10]");
			((Dictionary<PlayerRef, int>)0).Clear();
			bool flag48 = obj63 == null;
			num = num2;
			enumerator = (Dictionary<PlayerRef, int>.Enumerator)0;
			func = null;
			obj5 = obj4;
			if (!flag48)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28E0]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28D0]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D28D8]");
				object obj67 = 0;
				Dictionary<PlayerRef, int>.Enumerator enumerator3 = ((Dictionary<PlayerRef, int>)obj63).GetEnumerator();
				func = null;
				Dictionary<PlayerRef, int>.Enumerator enumerator4 = default;
				object obj68;
				Dictionary<PlayerRef, int>.Enumerator enumerator5;
				int num24;
				while (true)
				{
					array = (bool[])obj66;
					if (!enumerator.MoveNext())
					{
						break;
					}
					bool flag49 = array4 == null;
					num = 0;
					enumerator = enumerator4;
					obj68 = 0;
					enumerator5 = (Dictionary<PlayerRef, int>.Enumerator)(&enumerator);
					num24 = num2;
					enumerator2 = enumerator4;
					obj5 = obj4;
					if (!flag49)
					{
						func = (Func<double>)obj;
						int num38 = num2 >> 32;
						PlayerRef key = (PlayerRef)(num2 & 0xFFFFFFFFL);
						((Dictionary<PlayerRef, int>)(object)array4).set_Item(key, num38);
						hashSet = (HashSet<PlayerRef>)num38;
						continue;
					}
					goto IL_1594;
				}
				array = (bool[])obj67;
				enumerator.Dispose();
				num = 0;
				enumerator = enumerator4;
				obj68 = 0;
				enumerator5 = (Dictionary<PlayerRef, int>.Enumerator)(&enumerator);
				num24 = num2;
				enumerator2 = enumerator4;
				obj5 = obj4;
				obj = 21;
				List<PlayerRef> result = default;
				object obj70 = default;
				Enumerator<, > val;
				object obj71;
				while (true)
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						object obj69;
						if ((nint)array == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num = 1;
							obj69 = obj68;
						}
						else
						{
							if ((nint)array != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E42C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj69 = obj70;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj68 = obj70;
						}
						val = (Enumerator<, >)enumerator5;
						obj71 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E38]");
						object obj72 = 0;
						array = (bool[])obj72;
						((Enumerator<, >*)val)->Dispose();
						bool flag50 = obj69 == null;
						object obj73 = !flag50;
						enumerator5 = (Dictionary<PlayerRef, int>.Enumerator)val;
						if (obj73 != null)
						{
							break;
						}
						bool flag51 = num == 0;
						object obj74 = !flag51;
						enumerator5 = (Dictionary<PlayerRef, int>.Enumerator)val;
						ex2 = (OutOfMemoryException)val;
						if (obj74 == null)
						{
							goto end_IL_15ad;
						}
					}
					continue;
					end_IL_15ad:
					break;
				}
				if (obj71 != null)
				{
					bool flag52 = (nint)obj71 != 24;
					result2 = (List<PlayerRef>)val;
					if (flag52)
					{
						goto IL_1aa4;
					}
				}
				goto IL_1551;
			}
		}
		goto IL_1586;
		IL_1aa4:
		return result2;
		IL_0ec0:
		enumerator2 = (Dictionary<PlayerRef, int>.Enumerator)num19;
		num15 = (nint)hashSet;
		goto IL_0f0a;
		IL_1594:
		NullReferenceException ex3 = new NullReferenceException();
		throw new NullReferenceException();
		IL_1551:
		result2 = (List<PlayerRef>)obj5;
		goto IL_1aa4;
		IL_1586:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_1594;
	}

	public static PlayerRef Draw(List<PlayerRef> everyone, Dictionary<PlayerRef, int> waited, HashSet<PlayerRef> due, Func<double> roll)
	{
		//IL_0010: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0112: Expected VT, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<PlayerRef> list = DrawMany(everyone, waited, due, roll, 1);
		if ((object)list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
			if ((nint)0 > (nint)0)
			{
				return list.get_Item(0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return PlayerRef.None;
		}
		NullReferenceException ex = new NullReferenceException();
		return (PlayerRef)ex;
	}

	private int WaitedOf(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		//IL_008c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
		object obj = 0;
		NetworkDictionary<PlayerRef, byte> turns = Turns;
		object obj2 = p & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
		object obj4 = default;
		object obj3 = obj4 & 1;
		bool flag = obj3 == null;
		object obj5 = default;
		int result = obj5 & 0x7F;
		object obj6 = !flag;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			return result;
		}
		return 1;
	}

	private bool DueOf(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0099: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
		object obj = 0;
		NetworkDictionary<PlayerRef, byte> turns = Turns;
		object obj2 = p & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
		object obj3 = default;
		bool flag = (nint)obj3 < 0;
		object obj4 = obj3 ^ obj3;
		object obj5 = obj3 & obj4;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = flag == flag2;
		object obj6 = !flag3;
		object obj7 = default;
		return (byte)(obj7 & obj6) != 0;
	}

	public float MonsterChance(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0057: Expected F4, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected VT, but got Unknown
		//IL_01ef: Expected Obj, but got I4
		//IL_021c: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)((SimulationBehaviour)this)._runner == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		float result = 0f;
		if (obj4 == null)
		{
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E28]");
			object obj5 = 0;
			List<PlayerRef> everyone = Enumerable.ToList(activePlayers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2980]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A00]");
			object obj7 = 0;
			Func<PlayerRef, int> func = default;
			func._002Ector((object)this, (IntPtr)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29F8]");
			object obj9 = 0;
			Func<PlayerRef, bool> func2 = default;
			func2._002Ector((object)this, (IntPtr)obj9);
			byte nextMode = NextMode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte mode = nextMode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v11 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
			int monsters = MonstersFor(mode, 0);
			Dictionary<PlayerRef, float> dictionary = Chances((IEnumerable<PlayerRef>)everyone, func, func2, monsters);
			PlayerRef key = (PlayerRef)(p & 0xFFFFFFFFL);
			bool flag5 = dictionary.TryGetValue(key, out var value);
			bool flag6 = !flag5;
			object obj13 = !flag6;
			object obj14 = ~obj13;
			result = ((obj14 != null) ? 0f : value);
		}
		return result;
	}

	public bool OthersTurn(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_0240: Expected I4, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected VT, but got Unknown
		//IL_00a1: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected VT, but got Unknown
		//IL_01b1: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null)
		{
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
				PlayerRef value = (PlayerRef)(p & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E08]");
				object obj4 = 0;
				if (!Enumerable.Contains(activePlayers, value))
				{
					goto IL_022c;
				}
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					IEnumerable<PlayerRef> activePlayers2 = ((SimulationBehaviour)this)._runner.ActivePlayers;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2980]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A00]");
					object obj6 = 0;
					Func<PlayerRef, int> func = default;
					func._002Ector((object)this, (IntPtr)obj6);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29F8]");
					object obj8 = 0;
					Func<PlayerRef, bool> func2 = default;
					func2._002Ector((object)this, (IntPtr)obj8);
					PlayerRef p2 = (PlayerRef)(p & 0xFFFFFFFFL);
					float chance = MonsterChance(p2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v20+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef p3 = (PlayerRef)(p & 0xFFFFFFFFL);
					return OthersTurnOf(activePlayers2, p3, func, func2, chance);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_022c;
		IL_022c:
		return false;
	}

	public static bool OthersTurnOf(IEnumerable<PlayerRef> here, PlayerRef p, Func<PlayerRef, int> waitedOf, Func<PlayerRef, bool> dueOf, float chance)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0197: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected I4, but got Unknown
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		//IL_0125: Invalid comparison between F4 and I4
		//IL_0136: Expected Obj, but got I4
		//IL_013f: Invalid comparison between F4 and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj13;
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = dueOf;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (waitedOf != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [waitedOf @ X2 (System.Func`2<Fusion.PlayerRef, System.Int32>)+18] (should have been resolved before IL gen)");
				object obj4 = default;
				if ((nint)obj4 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2868]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A18]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Func<PlayerRef, bool> func = default;
					func._002Ector(obj2, (IntPtr)obj6);
					if (Enumerable.Any(here, func))
					{
						object obj7 = obj3;
						if (obj3 == null)
						{
							goto IL_0189;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X8_v10+18] (should have been resolved before IL gen)");
						bool flag = chance < 0f;
						object obj8 = !flag;
						bool flag2 = chance == 0f;
						object obj10 = default;
						object obj9 = obj10 ^ 1;
						object obj11 = ~obj8;
						object obj12 = obj11 | flag2;
						obj13 = obj12 | obj9;
						goto IL_01c7;
					}
				}
				obj13 = 0;
				goto IL_01c7;
			}
		}
		goto IL_0189;
		IL_0189:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01c7:
		return (byte)(obj13 & 1) != 0;
	}

	private void End(byte winner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		Winner = winner;
		float now = Now;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+A0]");
		object obj4 = 0;
		float num = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+C]");
		float overEnds = num + 0f;
		OverEnds = overEnds;
		Phase = 2;
	}

	static GillaModeRound()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A28]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FA90]");
		_ = 0;
		_ = 1127481344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C628]");
		_ = 0;
		_ = 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434FD2C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+A0]");
		object obj7 = (nint)0 + (nint)40;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private bool _003CFixedUpdateNetwork_003Eb__114_0(KeyValuePair<PlayerRef, byte> kv)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		PlayerRef p = (PlayerRef)(kv & 0xFFFFFFFFL);
		return InRoom(p);
	}

	private bool _003CFixedUpdateNetwork_003Eb__114_1(PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C0]");
		object obj = 0;
		NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
		object obj2 = p & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B65C");
		object obj3 = default;
		return (byte)(obj3 & 1) != 0;
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EF8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F00]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A30]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2A38]");
		object obj5 = 0;
		Phase = _Phase;
		VoteEnds = _VoteEnds;
		NetworkDictionary<PlayerRef, byte> votes = Votes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		Map = _Map;
		Monster = _Monster;
		Round = _Round;
		HuntEnds = _HuntEnds;
		OverEnds = _OverEnds;
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		Winner = _Winner;
		NetworkDictionary<PlayerRef, byte> turns = Turns;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		Mode = _Mode;
		ModeEnds = _ModeEnds;
		NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		StartApes = _StartApes;
		StartMonsters = _StartMonsters;
	}

	public override void CopyStateToBackingFields()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F18]");
		object obj = 0;
		byte phase = Phase;
		_Phase = phase;
		float voteEnds = VoteEnds;
		_VoteEnds = voteEnds;
		NetworkDictionary<PlayerRef, byte> votes = Votes;
		object obj2 = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6550");
		byte map = Map;
		_Map = map;
		PlayerRef monster = Monster;
		_Monster = monster;
		int round = Round;
		_Round = round;
		float huntEnds = HuntEnds;
		_HuntEnds = huntEnds;
		float overEnds = OverEnds;
		_OverEnds = overEnds;
		NetworkDictionary<PlayerRef, byte> players = Players;
		object obj3 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6550");
		byte winner = Winner;
		_Winner = winner;
		NetworkDictionary<PlayerRef, byte> turns = Turns;
		object obj4 = this + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6550");
		byte mode = Mode;
		_Mode = mode;
		float modeEnds = ModeEnds;
		_ModeEnds = modeEnds;
		NetworkDictionary<PlayerRef, byte> modeVotes = ModeVotes;
		object obj5 = this + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6550");
		byte startApes = StartApes;
		_StartApes = startApes;
		byte startMonsters = StartMonsters;
		_StartMonsters = startMonsters;
	}

	protected unsafe static void RPC_Vote_0040Invoker1408835608([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_008d: Expected VT, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0171: Expected VT, but got Ref
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27E0]");
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
		GillaModeRound gillaModeRound = (GillaModeRound)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaModeRound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaModeRound>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaModeRound>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte map = default;
				object obj16 = default;
				gillaModeRound.RPC_Vote(map, (RpcInfo)(&obj16));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_ModeVote_0040Invoker855452797([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_008d: Expected VT, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0171: Expected VT, but got Ref
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D27F0]");
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
		GillaModeRound gillaModeRound = (GillaModeRound)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaModeRound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaModeRound>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaModeRound>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte mode = default;
				object obj16 = default;
				gillaModeRound.RPC_ModeVote(mode, (RpcInfo)(&obj16));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Out_0040Invoker2511415377([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0045: Expected VT, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0125: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2800]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X21_v2+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaModeRound gillaModeRound = (GillaModeRound)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaModeRound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaModeRound>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaModeRound>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaModeRound.RPC_Out((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
