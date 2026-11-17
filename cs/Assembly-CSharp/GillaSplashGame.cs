using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaSplashGame : NetworkBehaviour
{
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public byte index;

		internal void _003CMakeMissing_003Eb__0(NetworkRunner r, NetworkObject obj)
		{
			//IL_0015: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C00]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			GillaSplashMonster gillaSplashMonster = default;
			gillaSplashMonster.NetPool = index;
		}
	}

	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public int[] counts;

		public int most;

		internal bool _003CBeginGame_003Eb__0(int i)
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

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public byte part;

		public GillaSplashGame _003C_003E4__this;

		internal bool _003CCount_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0070: Expected Obj, but got VT
			//IL_0062: Expected I4, but got Obj
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected VT, but got Unknown
			object obj = kv >> 32;
			if ((int)part == (nint)obj)
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

	public const byte Vote = default(byte);

	public const byte Start = default(byte);

	public const byte Race = default(byte);

	public const byte Results = default(byte);

	public const byte Over = default(byte);

	public const byte Racing = default(byte);

	public const byte Through = default(byte);

	public const byte Out = default(byte);

	public const byte Dead = default(byte);

	public const int Maps = default(int);

	public const int Levels = default(int);

	public const int MaxRounds = default(int);

	public const int MaxPlatforms = default(int);

	public static float VoteSeconds;

	public static float StartSeconds;

	public static float ResultsSeconds;

	public static float OverSeconds;

	public static float FirstRaceSeconds;

	public static float RaceSecondsLess;

	public static float LeastRaceSeconds;

	public static int DarkFromRound;

	public static bool KeepGoing;

	public static bool RaceToTheClock;

	private byte _Phase;

	private float _VoteEnds;

	private SerializableDictionary<PlayerRef, byte> _Votes;

	private byte _Map;

	private int _Round;

	private int _Starts;

	private float _PhaseEnds;

	private NetworkBool _Sinking;

	private SerializableDictionary<PlayerRef, byte> _Players;

	private float[] _SinkAt;

	private int _Layouts;

	private int _PlatformCount;

	private int[] _Platforms;

	private int _LayoutCheck;

	private static readonly GillaNetWatch.Single<GillaSplashGame> games;

	private const float StoodBudget = default(float);

	private const float StoodReach = default(float);

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

	public unsafe int Round
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1E8]");
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

	public unsafe int Starts
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

	public unsafe float PhaseEnds
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

	public unsafe NetworkBool Sinking
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1F4]");
				return (NetworkBool)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkBool)ex2;
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

	public unsafe NetworkArray<float> SinkAt
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5518]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA9A44");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 980;
				NetworkArray<float> networkArray = (NetworkArray<float>)0;
				IElementReaderWriter<float> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<float>(array, 128, readerWriter));
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
			return (NetworkArray<float>)ex2;
		}
	}

	public unsafe int Layouts
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+5D4]");
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

	public unsafe int PlatformCount
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+5D8]");
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

	public unsafe NetworkArray<int> Platforms
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D20]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E1089C");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 1500;
				NetworkArray<int> networkArray = (NetworkArray<int>)0;
				IElementReaderWriter<int> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<int>(array, 128, readerWriter));
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
			return (NetworkArray<int>)ex2;
		}
	}

	public unsafe int LayoutCheck
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+7DC]");
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

	public static GillaSplashGame Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D58]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F864");
				GillaSplashGame result = default;
				return result;
			}
			return (GillaSplashGame)(object)new NullReferenceException();
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

	public int Level
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_0032: Expected Obj, but got I4
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected I4, but got Unknown
			//IL_00a0: Expected Obj, but got I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_012f: Expected Obj, but got I4
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_0169: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
			object obj = 0;
			int round = Round;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = round - 1;
			bool flag2 = (nint)obj4 < 0;
			bool flag3 = obj4 == null;
			int num = round ^ 1;
			int num2 = round ^ obj4;
			int num3 = num & num2;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj5 = !flag3;
			object obj6 = flag5 & obj5;
			object obj7 = ~obj6;
			int num4 = ((obj7 != null) ? 1 : round);
			object obj8 = num4 - 1;
			object obj9 = obj8 * 2863311531L;
			object obj10 = obj9 >> 33;
			object obj11 = obj10 + obj10;
			return obj8 - obj11;
		}
	}

	public bool Dark
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
			object obj = 0;
			int round = Round;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+1C]");
			if ((nint)round < (nint)0)
			{
				return false;
			}
			byte phase = Phase;
			int num = phase & 0xFF;
			if (num != 1)
			{
				byte phase2 = Phase;
				int num2 = phase2 & 0xFF;
				if (num2 != 2)
				{
					byte phase3 = Phase;
					int num3 = phase3 & 0xFF;
					object obj5 = num3 - 3;
					return obj5 == null;
				}
			}
			return true;
		}
	}

	public bool Tied
	{
		get
		{
			//IL_0068: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_00e4: Expected Obj, but got I4
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected I4, but got Unknown
			byte phase = Phase;
			int num = phase & 0xFF;
			if (num == 4)
			{
				int num2 = Count(1);
				int num3 = Count(2);
				object obj = num3 + num2;
				object obj2 = obj - 1;
				bool flag = (nint)obj2 < 0;
				bool flag2 = obj2 == null;
				object obj3 = obj ^ 1;
				object obj4 = obj ^ obj2;
				object obj5 = obj3 & obj4;
				bool flag3 = (nint)obj5 < 0;
				bool flag4 = flag == flag3;
				object obj6 = !flag2;
				return (byte)((flag4 & obj6) ? 1 : 0) != 0;
			}
			return false;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F818");
	}

	public static int LevelOf(int round)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0103: Expected I4, but got Obj
		object obj = round - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = round ^ 1;
		int num2 = round ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : round);
		object obj5 = num4 - 1;
		object obj6 = obj5 * 2863311531L;
		object obj7 = obj6 >> 33;
		object obj8 = obj7 + obj7;
		return obj5 - obj8;
	}

	public static float Dimness(int round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_02f8: Expected F4, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02b2: Expected F4, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01e6: Invalid comparison between F8 and I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00d3: Invalid comparison between F8 and I4
		//IL_00e2: Expected F4, but got I4
		//IL_0100: Expected F4, but got I
		//IL_024f: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+1C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+1C]");
		float result;
		double num5;
		object obj10;
		if ((nint)0 > (nint)round)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v16+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v17+1C]");
				obj5 = 0;
			}
			object obj9 = obj5 - 1;
			bool flag3 = (nint)obj9 == 1;
			result = 0f;
			if (!flag3)
			{
				double num = (double)round + -1.0;
				double num2 = (double)obj9 + -1.0;
				double num3 = num / num2;
				bool flag4 = num3 < 0.0;
				result = 0f;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
					result = 0f;
					if (!(num3 > 1.0))
					{
						double num4 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						num5 = num4 * 0.0;
						obj10 = 0;
						goto IL_02c5;
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v10+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v11+1C]");
				obj5 = 0;
			}
			bool flag6 = (nint)obj5 == 7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			result = 0f;
			if (!flag6)
			{
				object obj14 = round - obj5;
				double num6 = 7.0 - (double)obj5;
				double num7 = (double)obj14 / num6;
				if (!(num7 < 0.0))
				{
					bool flag7 = num7 > 1.0;
					result = 1f;
					if (!flag7)
					{
						double num8 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						num5 = num8 * 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
						obj10 = 0;
						goto IL_02c5;
					}
				}
			}
		}
		goto IL_02c0;
		IL_02c0:
		return result;
		IL_02c5:
		result = (float)num5 + (float)obj10;
		goto IL_02c0;
	}

	public static float RaceSeconds(int round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00fe: Invalid comparison between F4 and I4
		//IL_010d: Invalid comparison between F4 and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_003c: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
		object obj4 = round - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj5 = 0;
		object obj6 = ~obj4;
		object obj7 = obj4 & obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+14]");
		object obj8 = 0 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+10]");
		float num = 0f - (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
		float num2 = 0f - num;
		bool flag2 = num2 < 0f;
		bool flag3 = num2 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
		object obj9 = 0 ^ num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
		object obj10 = 0 ^ num2;
		object obj11 = obj9 & obj10;
		bool flag4 = (nint)obj11 < 0;
		bool flag5 = flag2 == flag4;
		object obj12 = !flag3;
		object obj13 = flag5 & obj12;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
			num = 0f;
		}
		return num;
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F668");
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F774");
	}

	public unsafe void RPC_Vote(byte map, RpcInfo info = default(RpcInfo))
	{
		//IL_01ab: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I
		//IL_03e2: Expected VT, but got I8
		//IL_03fd: Expected VT, but got I4
		//IL_00ec: Invalid comparison between F4 and I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0106: Invalid comparison between F4 and I4
		//IL_0117: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got VT
		//IL_043a: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got Ref
		//IL_04b9: Expected Obj, but got I4
		//IL_04c1: Expected VT, but got Ref
		//IL_04c9: Expected Obj, but got Ref
		//IL_04d2: Expected Obj, but got I4
		//IL_04da: Expected I4, but got VT
		//IL_02f0: Expected VT, but got I4
		//IL_02fd: Expected VT, but got Obj
		//IL_0306: Expected VT, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_0755: Expected Ref, but got VT
		//IL_076f: Expected Obj, but got I4
		//IL_08b9: Expected Obj, but got I4
		//IL_0458: Expected Obj, but got I
		//IL_0460: Expected VT, but got Obj
		//IL_0480: Expected VT, but got I4
		//IL_07f9: Expected Obj, but got I
		//IL_031d: Invalid comparison between VT and I4
		//IL_07bb: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got VT
		//IL_0797: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I4
		//IL_033a: Invalid comparison between VT and I4
		//IL_034c: Expected VT, but got I4
		//IL_0359: Expected VT, but got Obj
		//IL_0362: Expected VT, but got I4
		//IL_0827: Expected Obj, but got I
		//IL_0837: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I4
		//IL_0679: Expected native int or pointer, but got VT
		//IL_0686: Expected native int or pointer, but got VT
		//IL_0593: Expected Obj, but got I
		//IL_059c: Expected VT, but got Obj
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected I4, but got Unknown
		//IL_05d7: Expected Obj, but got I4
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected I4, but got Unknown
		//IL_0626: Expected VT, but got I4
		//IL_0626: Expected VT, but got I4
		//IL_0652: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo;
		NullReferenceException ex;
		object obj10;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(1533595928u, bytePayloadSize, (NetworkBehaviour)this, invalid);
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
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = invalid;
					playerRef3 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_0412;
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
							goto IL_0412;
						}
					}
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v60+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DB0]");
				object rpc = 0;
				playerRef3 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef3);
				playerRef = (PlayerRef)0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0412;
			}
			ex = new NullReferenceException();
			rpcInfo = info;
			obj10 = 0;
			num = bytePayloadSize;
			goto IL_06b8;
		}
		goto IL_0005;
		IL_089f:
		nint num2 = default;
		bool flag6 = num2 == 0;
		object obj11 = !flag6;
		object obj12;
		if (obj11 == null)
		{
			if ((nint)obj12 != 9)
			{
				bool flag7 = obj12 == null;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v12+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v7+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA0]");
				object obj19 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj19);
				object obj20 = obj;
				int num3 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ X27_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num2 = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef2 = (PlayerRef)0;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num2;
			goto IL_0005;
		}
		goto IL_06b8;
		IL_087c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0412:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag10 = obj22 == null;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj24 = 0;
			PlayerRef playerRef3 = (PlayerRef)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num4 = rpcBuilder2.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
		}
		rpcBuilder2.Dispose();
		num2 = 0;
		object obj25 = 0;
		networkRunner = (NetworkRunner)(&writer);
		rpcInfo = (RpcInfo)rpcInvokeInfo2;
		obj10 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		ex = (NullReferenceException)(&rpcBuilder2);
		obj12 = 9;
		num = (int)rpcInvokeInfo;
		goto IL_089f;
		IL_06b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj26;
		OutOfMemoryException ex2;
		if ((nint)obj10 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj25;
			num2 = 1;
		}
		else
		{
			bool flag11 = (nint)obj10 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_087c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj27 = default;
			obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj27;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj26 == null;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			obj10 = 0;
			ex = (NullReferenceException)rpcBuilder3;
			obj12 = 0;
			goto IL_089f;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj10 = 0;
		goto IL_087c;
		IL_0005:
		byte phase = Phase;
		int num5 = map & 0xFF;
		bool flag13 = num5 < 2;
		object obj29 = !flag13;
		object obj30 = num5 - 2;
		bool flag14 = obj30 == null;
		object obj31 = !flag14;
		object obj32 = obj29 & obj31;
		if (obj32 != null)
		{
			return;
		}
		int num6 = phase & 0xFF;
		bool flag15 = num6 == 0;
		object obj33 = !flag15;
		if (obj33 != null)
		{
			return;
		}
		NetworkDictionary<PlayerRef, byte> votes = Votes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
		float voteEnds = VoteEnds;
		bool flag16 = voteEnds < 0f;
		object obj35 = !flag16;
		bool flag17 = voteEnds == 0f;
		object obj36 = !flag17;
		object obj37 = obj35 & obj36;
		if (obj37 == null)
		{
			float now = Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
			object obj38 = 0;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v78+E4]");
			bool flag18 = (nint)0 == 0;
			object obj40 = !flag18;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj38;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v78+A0]");
			object obj41 = 0;
			float voteEnds2 = now + (float)obj41;
			VoteEnds = voteEnds2;
		}
	}

	public unsafe void RPC_Finished(RpcInfo info = default(RpcInfo))
	{
		//IL_0648: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_00a8: Expected I4, but got I8
		//IL_00da: Expected Obj, but got VT
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0243: Expected VT, but got I8
		//IL_025e: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got VT
		//IL_029b: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_02de: Expected VT, but got Ref
		//IL_02ef: Expected Obj, but got Ref
		//IL_02f7: Expected Obj, but got VT
		//IL_0151: Expected Obj, but got I4
		//IL_0156: Expected VT, but got Obj
		//IL_015f: Expected VT, but got I4
		//IL_05d1: Expected Ref, but got VT
		//IL_05f1: Expected Obj, but got VT
		//IL_0316: Expected Obj, but got I4
		//IL_017e: Invalid comparison between VT and I4
		//IL_0334: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I
		//IL_019b: Invalid comparison between VT and I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01b2: Expected VT, but got Obj
		//IL_01bb: Expected VT, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I
		//IL_039c: Expected VT, but got Obj
		//IL_03b5: Expected VT, but got Obj
		//IL_03d7: Expected Obj, but got I4
		//IL_0467: Expected native int or pointer, but got VT
		//IL_0474: Expected native int or pointer, but got VT
		//IL_040f: Expected I4, but got I8
		//IL_0426: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer = default;
		object obj5 = default;
		NullReferenceException ex;
		RpcChannel rpcChannel;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			networkRunner = ((SimulationBehaviour)this)._runner;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(3009007143u, 0, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj5 = rpcInvokeInfo >> 32;
				object obj6 = obj5 - 522;
				bool flag4 = (nint)obj6 < 2;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				PlayerRef playerRef;
				object obj9;
				RpcInvokeInfo rpcInvokeInfo2;
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
						goto IL_0273;
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
							goto IL_0273;
						}
					}
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v69+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DC0]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj9 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_0273;
			}
			ex = new NullReferenceException();
			rpcChannel = (RpcChannel)0;
			goto IL_0534;
		}
		goto IL_0657;
		IL_02fc:
		nint num = default;
		bool flag8 = num == 0;
		object obj12 = !flag8;
		if (obj12 != null)
		{
			goto IL_0534;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v41+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v41+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v21+18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v21+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DB8]");
			object obj18 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj18);
			object obj19 = obj2;
			RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)networkRunner | obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v26+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)((nint)(&writer) & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ X26_v4+18] (should have been resolved before IL gen)");
			IntPtr intPtr = default;
			num = intPtr;
		}
		bool flag11 = (object)networkRunner == null;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num;
			goto IL_0657;
		}
		return;
		IL_06f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0273:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag12 = obj22 == null;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			int num2 = rpcBuilder2.Send();
		}
		rpcBuilder2.Dispose();
		num = 0;
		object obj24 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)(&rpcBuilder2);
		networkRunner = (NetworkRunner)rpcInvokeInfo;
		goto IL_02fc;
		IL_0534:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj25;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj24;
			num = 1;
		}
		else
		{
			bool flag13 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_06f4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj26 = default;
			obj25 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj24 = obj26;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag14 = obj25 == null;
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)rpcBuilder3;
		if (flag14)
		{
			goto IL_02fc;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_06f4;
		IL_0657:
		byte phase = Phase;
		int num3 = phase & 0xFF;
		if (num3 == 2)
		{
			NetworkDictionary<PlayerRef, byte> players = Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj29 = default;
			object obj28 = obj29 & 1;
			object obj30 = default;
			if (obj28 != null && (nint)obj30 == 1)
			{
				NetworkDictionary<PlayerRef, byte> players2 = Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
			}
		}
	}

	public unsafe void RPC_Died(RpcInfo info = default(RpcInfo))
	{
		//IL_0648: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_00a8: Expected I4, but got I8
		//IL_00da: Expected Obj, but got VT
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0243: Expected VT, but got I8
		//IL_025e: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got VT
		//IL_029b: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_02de: Expected VT, but got Ref
		//IL_02ef: Expected Obj, but got Ref
		//IL_02f7: Expected Obj, but got VT
		//IL_0151: Expected Obj, but got I4
		//IL_0156: Expected VT, but got Obj
		//IL_015f: Expected VT, but got I4
		//IL_05d1: Expected Ref, but got VT
		//IL_05f1: Expected Obj, but got VT
		//IL_0316: Expected Obj, but got I4
		//IL_017e: Invalid comparison between VT and I4
		//IL_0334: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I
		//IL_019b: Invalid comparison between VT and I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01b2: Expected VT, but got Obj
		//IL_01bb: Expected VT, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I
		//IL_039c: Expected VT, but got Obj
		//IL_03b5: Expected VT, but got Obj
		//IL_03d7: Expected Obj, but got I4
		//IL_0467: Expected native int or pointer, but got VT
		//IL_0474: Expected native int or pointer, but got VT
		//IL_040f: Expected I4, but got I8
		//IL_0426: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer = default;
		object obj5 = default;
		NullReferenceException ex;
		RpcChannel rpcChannel;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			networkRunner = ((SimulationBehaviour)this)._runner;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(2665585797u, 0, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj5 = rpcInvokeInfo >> 32;
				object obj6 = obj5 - 522;
				bool flag4 = (nint)obj6 < 2;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				PlayerRef playerRef;
				object obj9;
				RpcInvokeInfo rpcInvokeInfo2;
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
						goto IL_0273;
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
							goto IL_0273;
						}
					}
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v69+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DD0]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				obj9 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_0273;
			}
			ex = new NullReferenceException();
			rpcChannel = (RpcChannel)0;
			goto IL_0534;
		}
		goto IL_0657;
		IL_02fc:
		nint num = default;
		bool flag8 = num == 0;
		object obj12 = !flag8;
		if (obj12 != null)
		{
			goto IL_0534;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v41+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v41+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v21+18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v21+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DC8]");
			object obj18 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj18);
			object obj19 = obj2;
			RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)networkRunner | obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v26+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)((nint)(&writer) & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ X26_v4+18] (should have been resolved before IL gen)");
			IntPtr intPtr = default;
			num = intPtr;
		}
		bool flag11 = (object)networkRunner == null;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num;
			goto IL_0657;
		}
		return;
		IL_06f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0273:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag12 = obj22 == null;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			int num2 = rpcBuilder2.Send();
		}
		rpcBuilder2.Dispose();
		num = 0;
		object obj24 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)(&rpcBuilder2);
		networkRunner = (NetworkRunner)rpcInvokeInfo;
		goto IL_02fc;
		IL_0534:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj25;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj24;
			num = 1;
		}
		else
		{
			bool flag13 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_06f4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj26 = default;
			obj25 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj24 = obj26;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag14 = obj25 == null;
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)rpcBuilder3;
		if (flag14)
		{
			goto IL_02fc;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_06f4;
		IL_0657:
		byte phase = Phase;
		int num3 = phase & 0xFF;
		if (num3 == 2)
		{
			NetworkDictionary<PlayerRef, byte> players = Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj29 = default;
			object obj28 = obj29 & 1;
			object obj30 = default;
			if (obj28 != null && (nint)obj30 == 1)
			{
				NetworkDictionary<PlayerRef, byte> players2 = Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
			}
		}
	}

	public unsafe void RPC_Stood(int platform, RpcInfo info = default(RpcInfo))
	{
		//IL_0294: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_0334: Expected I4, but got I8
		//IL_0366: Expected Obj, but got VT
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_04cf: Expected VT, but got I8
		//IL_04ea: Expected VT, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got VT
		//IL_0527: Expected Obj, but got I4
		//IL_052f: Expected I4, but got VT
		//IL_059d: Expected Obj, but got I4
		//IL_05a5: Expected I, but got VT
		//IL_05ad: Expected Obj, but got Ref
		//IL_05b5: Expected VT, but got I4
		//IL_05bd: Expected VT, but got Ref
		//IL_05c6: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got Ref
		//IL_05d7: Expected Obj, but got I4
		//IL_05df: Expected I4, but got VT
		//IL_03dd: Expected VT, but got I4
		//IL_03e2: Expected VT, but got Obj
		//IL_03f3: Expected VT, but got I4
		//IL_0860: Expected Ref, but got VT
		//IL_087a: Expected Obj, but got I4
		//IL_0997: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I
		//IL_0555: Expected VT, but got Obj
		//IL_040a: Invalid comparison between VT and I4
		//IL_011d: Expected Obj, but got I
		//IL_08c6: Expected Obj, but got I4
		//IL_0891: Expected Obj, but got I4
		//IL_0899: Expected Obj, but got VT
		//IL_08a2: Expected Obj, but got I4
		//IL_013c: Invalid comparison between F4 and I4
		//IL_0639: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I4
		//IL_0427: Invalid comparison between VT and I4
		//IL_0439: Expected VT, but got I4
		//IL_043e: Expected VT, but got Obj
		//IL_044f: Expected VT, but got I4
		//IL_0905: Expected Obj, but got I
		//IL_0915: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_077e: Expected native int or pointer, but got VT
		//IL_078b: Expected native int or pointer, but got VT
		//IL_0795: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_06a1: Expected VT, but got Obj
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected I4, but got Unknown
		//IL_06dc: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected I4, but got Unknown
		//IL_072b: Expected VT, but got I4
		//IL_072b: Expected VT, but got I4
		//IL_0757: Expected VT, but got I4
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo;
		NullReferenceException ex;
		object obj10;
		if (!NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(4031950739u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag2 = (nint)obj5 < 2;
				object obj6 = !flag2;
				object obj7 = ~obj6;
				PlayerRef playerRef;
				PlayerRef playerRef3;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag3 = (nint)obj4 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag3)
					{
						goto IL_04ff;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag4 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag4)
						{
							goto IL_04ff;
						}
					}
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v60+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DE0]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_04ff;
			}
			ex = new NullReferenceException();
			rpcInfo = info;
			obj10 = 0;
			num = bytePayloadSize;
			goto IL_07c3;
		}
		goto IL_0005;
		IL_097d:
		nint num2 = default;
		bool flag6 = num2 == 0;
		object obj11 = !flag6;
		object obj12;
		nint num4;
		if (obj11 == null)
		{
			if ((nint)obj12 != 10)
			{
				bool flag7 = obj12 == null;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v12+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v7+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DD8]");
				object obj19 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj19);
				object obj20 = obj;
				int num3 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X27_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num2 = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef3 = (PlayerRef)0;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			Tick tick = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, tick);
			((RpcInfo*)(nint)info)->_validationResult = num2;
			num4 = unchecked((nint)null);
			goto IL_0005;
		}
		goto IL_07c3;
		IL_095a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_04ff:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag10 = obj22 == null;
		object obj23 = !flag10;
		int num5 = (int)rpcInvokeInfo2;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D50]");
			object obj24 = 0;
			playerRef2 = (PlayerRef)obj24;
			writer.Write(platform, 4);
			int num6 = rpcBuilder2.Send();
			num5 = 4;
		}
		rpcBuilder2.Dispose();
		num2 = 0;
		object obj25 = 0;
		num4 = (nint)playerRef2;
		networkRunner = (NetworkRunner)(&writer);
		rpcInfo = (RpcInfo)num5;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		obj10 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj12 = 10;
		num = (int)rpcInvokeInfo;
		goto IL_097d;
		IL_07c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj26;
		OutOfMemoryException ex2;
		if ((nint)obj10 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj25;
			num2 = 1;
		}
		else
		{
			bool flag11 = (nint)obj10 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag11)
			{
				goto IL_095a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj27 = default;
			obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj27;
		}
		((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
		bool flag12 = obj26 == null;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			obj10 = 0;
			ex = (NullReferenceException)rpcBuilder3;
			obj12 = 0;
			goto IL_097d;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj10 = 0;
		goto IL_095a;
		IL_0005:
		byte phase = Phase;
		int num7 = phase & 0xFF;
		if (num7 != 2)
		{
			return;
		}
		NetworkBool sinking = Sinking;
		if (!sinking)
		{
			return;
		}
		bool flag13 = InRace(info.Source);
		bool flag14 = platform < 127;
		object obj29 = !flag14;
		object obj30 = platform - 127;
		bool flag15 = obj30 == null;
		object obj31 = !flag15;
		object obj32 = obj29 & obj31;
		if (obj32 != null || !flag13)
		{
			return;
		}
		NetworkArray<float> sinkAt = SinkAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5568]");
		object obj33 = 0;
		NetworkArray<float> networkArray = default;
		float num8 = networkArray.get_Item(platform);
		if (num8 > 0f)
		{
			return;
		}
		bool flag16 = !info.IsInvokeLocal;
		object obj34 = !flag16;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v85+E4]");
			bool flag17 = (nint)0 == 0;
			object obj37 = !flag17;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!GillaNetGuard.Spend(info.Source, (GillaNetGuard.Kind)5, 4f, 6f) || !StoodOn(info.Source, platform))
			{
				return;
			}
		}
		NetworkArray<float> sinkAt2 = SinkAt;
		float now = Now;
		NetworkArray<float> networkArray2 = default;
		float num9 = networkArray2.Set(platform, now);
	}

	private unsafe bool StoodOn(PlayerRef p, int platform)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bd5: Expected Obj, but got I4
		//IL_0bfb: Expected Obj, but got I
		//IL_0c1d: Expected Obj, but got I4
		//IL_0f09: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I
		//IL_0f43: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_0c3b: Expected Obj, but got I
		//IL_0c62: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I4
		//IL_0427: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_0517: Expected Obj, but got I
		//IL_0dde: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I4
		//IL_0ce0: Expected Obj, but got I
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected Obj, but got Unknown
		//IL_0d17: Expected VT, but got Ref
		//IL_053a: Expected Obj, but got I
		//IL_0c92: Expected Obj, but got I4
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected Obj, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0ac8: Expected VT, but got Ref
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_064c: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I4
		//IL_0db8: Expected Obj, but got I4
		//IL_0687: Expected Obj, but got I
		//IL_079b: Expected Obj, but got I4
		//IL_0d46: Expected Obj, but got I4
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got Unknown
		//IL_085d: Expected Obj, but got I4
		//IL_0866: Expected Obj, but got I4
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_07c8: Expected VT, but got Ref
		//IL_07d1: Expected Obj, but got I4
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06bc: Expected Obj, but got I4
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_0805: Expected Obj, but got I4
		//IL_081a: Expected Obj, but got I
		//IL_08c1: Expected VT, but got Ref
		//IL_08ca: Expected Obj, but got I4
		//IL_0920: Expected VT, but got Ref
		//IL_0929: Expected Obj, but got I4
		//IL_097f: Expected VT, but got Ref
		//IL_0988: Expected Obj, but got I4
		//IL_09b5: Expected Obj, but got VT
		//IL_09e0: Expected VT, but got I4
		//IL_09e0: Expected VT, but got I4
		//IL_0a0c: Expected Obj, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a49: Expected Obj, but got F8
		//IL_0e59: Invalid comparison between Obj and F8
		//IL_0e6a: Expected Obj, but got I4
		//IL_0e82: Invalid comparison between F8 and I4
		//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected I4, but got Unknown
		//IL_0ea6: Expected VT, but got F8
		//IL_0eae: Expected VT, but got Ref
		//IL_0eb7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		UnityEngine.Object obj10 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef player = (PlayerRef)(p & 0xFFFFFFFFL);
		NetworkApe networkApe = NetworkApe.Find(player);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj8 == null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		object obj49 = default;
		UnityEngine.Object obj57 = default;
		Quaternion quaternion;
		Quaternion quaternion2 = default;
		object obj18;
		UnityEngine.Object obj19;
		if (obj14 == null)
		{
			object obj15 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = (UnityEngine.Object)networkApe == (UnityEngine.Object)null;
			bool flag9 = !flag8;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				bool flag10 = (object)networkApe == null;
				obj18 = 0;
				obj19 = null;
				if (flag10)
				{
					goto IL_0acd;
				}
				object obj20 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v47+E4]");
				bool flag11 = (nint)0 == 0;
				object obj21 = !flag11;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = networkApe.head == null;
				bool flag13 = !flag12;
				object obj22 = !flag13;
				if (obj22 == null)
				{
					int platformCount = PlatformCount;
					if (platformCount > platform)
					{
						NetworkArray<int> platforms = Platforms;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79F0]");
						object obj23 = 0;
						obj18 = obj23;
						NetworkArray<int> networkArray = default;
						int num = networkArray.get_Item(platform);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
						object obj24 = 0;
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v27+E4]");
						bool flag14 = (nint)0 == 0;
						object obj26 = !flag14;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj25 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v27+E4]");
							bool flag15 = (nint)0 == 0;
							object obj27 = !flag15;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj25 = obj24;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v27+A0]");
						object obj28 = 0;
						object obj29 = obj28;
						bool flag16 = obj28 == null;
						quaternion = quaternion2;
						obj19 = (UnityEngine.Object)platform;
						if (!flag16)
						{
							int num2 = num >> 20;
							int num3 = num2 & 0x1F;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v18+18]");
							bool flag17 = (nint)num3 >= (nint)0;
							if (flag17)
							{
								goto IL_0887;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v27+E4]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v27+E4]");
							bool flag18 = (nint)0 == 0;
							object obj31 = !flag18;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj32 = obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v45+A0]");
								object obj33 = 0;
								obj29 = obj33;
								bool flag19 = obj33 == null;
								quaternion = quaternion2;
								obj19 = (UnityEngine.Object)platform;
								if (flag19)
								{
									goto IL_0acd;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v18+18]");
							bool flag20 = (nint)num3 < (nint)0;
							object obj34 = !flag20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v18+18]");
							object obj35 = (nint)num3 - (nint)0;
							bool flag21 = obj35 == null;
							quaternion = quaternion2;
							obj19 = (UnityEngine.Object)platform;
							if (obj34 != null)
							{
								goto IL_0ae9;
							}
							bool flag22 = obj8 == null;
							quaternion = quaternion2;
							obj19 = (UnityEngine.Object)platform;
							if (!flag22)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3 (UnityEngine.Object)+F0]");
								obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v3 (UnityEngine.Object)+F0]");
								bool flag23 = (nint)0 == 0;
								quaternion = quaternion2;
								obj19 = (UnityEngine.Object)platform;
								if (!flag23)
								{
									object obj36 = obj29 + num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DE8]");
									object obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E38C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
									object obj38 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DF0]");
									object obj39 = 0;
									object obj41 = default;
									object obj40 = obj41;
									object obj48 = default;
									while (true)
									{
										object obj42 = obj40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v34+12E]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v34+12E]");
										if ((nint)0 == 0)
										{
											goto IL_05cf;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v34+98]");
										object obj44 = (nint)0 + (nint)8;
										bool flag24 = flag17;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v26-8]");
											bool flag25 = 0 < (nint)obj38;
											obj34 = !flag25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v26-8]");
											obj35 = 0 - obj38;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X10_v26-8]");
											if (0 == (nint)obj38)
											{
												break;
											}
											obj43--;
											bool flag26 = (nint)obj43 < 1;
											obj34 = !flag26;
											obj35 = obj43 - 1;
											flag21 = obj35 == null;
											obj30 = obj44 + 16;
											flag17 = (nint)obj43 != 1;
											obj44 = obj30;
											flag24 = flag17;
											if (flag17)
											{
												continue;
											}
											goto IL_05cf;
										}
										object obj45 = obj42 + obj44;
										object obj46 = obj45 + 312;
										obj30 = obj44;
										flag17 = flag24;
										goto IL_0cd0;
										IL_0cd0:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X0_v64+8]");
										obj19 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v961 @ X0_v64] (should have been resolved before IL gen)");
										object obj47 = obj48 & 1;
										bool flag27 = obj47 == null;
										quaternion = quaternion2;
										quaternion2 = (Quaternion)(&obj49);
										if (flag27)
										{
											break;
										}
										if (obj41 == null)
										{
											goto IL_0aaf;
										}
										object obj50 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v37+12E]");
										object obj51 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v37+12E]");
										if ((nint)0 == 0)
										{
											goto IL_071c;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X8_v37+98]");
										object obj52 = (nint)0 + (nint)8;
										bool flag28 = flag17;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X10_v21-8]");
											bool flag29 = 0 < (nint)obj39;
											obj34 = !flag29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X10_v21-8]");
											obj35 = 0 - obj39;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X10_v21-8]");
											if (0 == (nint)obj39)
											{
												break;
											}
											obj51--;
											bool flag30 = (nint)obj51 < 1;
											obj34 = !flag30;
											obj35 = obj51 - 1;
											flag21 = obj35 == null;
											obj30 = obj52 + 16;
											flag17 = (nint)obj51 != 1;
											obj52 = obj30;
											flag28 = flag17;
											if (flag17)
											{
												continue;
											}
											goto IL_071c;
										}
										object obj53 = obj50 + obj52;
										object obj54 = obj53 + 312;
										obj30 = obj52;
										flag17 = flag28;
										goto IL_0d84;
										IL_0d84:
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1024 @ X0_v68] (should have been resolved before IL gen)");
										object obj55 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v71+E4]");
										bool flag31 = (nint)0 == 0;
										object obj56 = !flag31;
										if (obj56 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag32 = obj57 == null;
										bool flag33 = !flag32;
										object obj58 = !flag33;
										if (obj58 == null)
										{
											bool flag34 = (object)obj57 == null;
											quaternion = quaternion2;
											quaternion2 = (Quaternion)(&obj49);
											obj18 = 0;
											obj19 = null;
											if (flag34)
											{
												goto IL_0adb;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v70 (UnityEngine.Object)+20]");
											bool flag35 = (nint)0 < (nint)platform;
											obj34 = !flag35;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v70 (UnityEngine.Object)+20]");
											obj35 = -platform;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v70 (UnityEngine.Object)+20]");
											if ((nint)0 == platform)
											{
												goto IL_0895;
											}
										}
										bool flag36 = obj41 == null;
										object obj59 = !flag36;
										obj18 = 0;
										obj40 = obj41;
										if (obj59 == null)
										{
											throw new NullReferenceException();
										}
										continue;
										IL_071c:
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
										obj18 = 0;
										goto IL_0d84;
										IL_05cf:
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
										obj18 = 0;
										goto IL_0cd0;
									}
									goto IL_0b98;
								}
							}
						}
						goto IL_0acd;
					}
				}
			}
		}
		goto IL_0887;
		IL_0acd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0adb;
		IL_0b13:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)obj19 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		else
		{
			if ((nint)obj19 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		goto IL_0b98;
		IL_0b98:
		bool result2 = false;
		goto IL_0f51;
		IL_0aaf:
		NullReferenceException ex3 = new NullReferenceException();
		quaternion = quaternion2;
		quaternion2 = (Quaternion)(&obj49);
		goto IL_0acd;
		IL_0f51:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		goto IL_0eec;
		IL_0b05:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0b13;
		IL_0eec:
		return result2;
		IL_0adb:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0ae9;
		IL_0895:
		Transform transform = ((Component)obj57).transform;
		bool flag37 = (object)transform == null;
		quaternion = quaternion2;
		quaternion2 = (Quaternion)(&obj49);
		obj18 = 0;
		obj19 = null;
		if (flag37)
		{
			goto IL_0af7;
		}
		Quaternion rotation = transform.rotation;
		Quaternion rotation2 = default;
		Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
		bool flag38 = (object)networkApe.head == null;
		quaternion = quaternion2;
		quaternion2 = (Quaternion)(&obj49);
		obj18 = 0;
		obj19 = null;
		if (flag38)
		{
			goto IL_0b05;
		}
		Vector3 position = networkApe.head.position;
		Transform transform2 = ((Component)obj57).transform;
		bool flag39 = (object)transform2 == null;
		quaternion = quaternion2;
		quaternion2 = (Quaternion)(&obj49);
		obj18 = 0;
		obj19 = null;
		if (flag39)
		{
			goto IL_0b13;
		}
		Vector3 position2 = transform2.position;
		object obj60 = quaternion2 - quaternion2;
		object obj62 = default;
		object obj61 = obj62 - obj62;
		double num5 = default;
		double num4 = num5 - num5;
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		float sizeNow = networkApe.SizeNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v30+30]");
		object obj63 = (nint)0 * (nint)191;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj64 = quaternion2 + obj63;
		bool flag40 = (double)sizeNow < 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj65 = ~num5;
		object obj66 = obj64 & obj65;
		double num6 = 1.0;
		if (!flag40)
		{
			bool flag41 = !((double)sizeNow > 2.0);
			num6 = sizeNow;
			if (!flag41)
			{
				num6 = 2.0;
			}
		}
		obj62 = obj66 * obj66;
		double num7 = num6 * 3.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		double num8 = num7 + 3.0;
		double num9 = num8 * num8;
		bool flag42 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9);
		object obj67 = !flag42;
		double num10 = (double)obj62 - num9;
		bool flag43 = num10 == 0.0;
		object obj68 = ~obj67;
		bool flag44 = (byte)((obj68 | flag43) ? 1 : 0) != 0;
		quaternion = (Quaternion)num9;
		quaternion2 = (Quaternion)(&obj49);
		obj18 = 0;
		obj19 = null;
		result2 = flag44;
		goto IL_0f51;
		IL_0ae9:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0af7;
		IL_0887:
		result2 = false;
		goto IL_0eec;
		IL_0af7:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0b05;
	}

	public bool InRace(PlayerRef p)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		byte phase = Phase;
		int num = phase & 0xFF;
		bool flag = num != 2;
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
				object obj5 = obj6 - 1;
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

	public int Count(byte part)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D68]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D88]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DF8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E00]");
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
		//IL_0595: Invalid comparison between F4 and I4
		//IL_0499: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_0331: Expected VT, but got I4
		//IL_04b7: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I4
		//IL_0641: Invalid comparison between F4 and I4
		//IL_0671: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
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
		switch (phase & 0xFF)
		{
		case 4:
		{
			float now2 = Now;
			float phaseEnds = PhaseEnds;
			if (!(now2 < phaseEnds))
			{
				Phase = 0;
				NetworkDictionary<PlayerRef, byte> players = Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				NetworkDictionary<PlayerRef, byte> votes = Votes;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
				VoteEnds = 0f;
				ClearSinking();
			}
			break;
		}
		case 1:
		{
			float now3 = Now;
			float phaseEnds2 = PhaseEnds;
			if (!(now3 < phaseEnds2))
			{
				Phase = 2;
				float now4 = Now;
				int round = Round;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num = RaceSeconds(round);
				float phaseEnds3 = now4 + num;
				PhaseEnds = phaseEnds3;
			}
			break;
		}
		case 2:
		{
			int round2 = Round;
			float num2 = GillaSinkPlatform.Cycle(round2);
			int platformCount = PlatformCount;
			bool flag3 = platformCount < 1;
			float num3 = num2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5568]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5578]");
				object obj10 = 0;
				NetworkArray<float> networkArray = (NetworkArray<float>)0;
				int num4 = 0;
				NetworkArray<float> networkArray2 = default;
				NetworkArray<float> networkArray3 = default;
				NetworkArray<float> networkArray4 = default;
				NetworkArray<float> networkArray5 = default;
				int platformCount2;
				do
				{
					NetworkArray<float> sinkAt = SinkAt;
					object obj11 = obj9;
					num3 = networkArray.get_Item(num4);
					bool flag4 = !(num3 > 0f);
					networkArray = networkArray2;
					if (!flag4)
					{
						float now6 = Now;
						NetworkArray<float> sinkAt2 = SinkAt;
						obj11 = obj9;
						float num5 = networkArray.get_Item(num4);
						num3 = now6 - num5;
						bool flag5 = !(num3 > num2);
						networkArray = networkArray3;
						if (!flag5)
						{
							NetworkArray<float> sinkAt3 = SinkAt;
							obj11 = obj10;
							num3 = networkArray4.Set(num4, 0f);
							networkArray = networkArray5;
						}
					}
					platformCount2 = PlatformCount;
					bool flag6 = num4 < 126;
					object obj12 = !flag6;
					object obj13 = num4 - 126;
					bool flag7 = obj13 == null;
					object obj14 = !flag7;
					object obj15 = obj12 & obj14;
					if (obj15 != null)
					{
						break;
					}
					num4++;
				}
				while (num4 < platformCount2);
			}
			int num6 = Count(1);
			bool flag8 = num6 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v35+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v35+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v13+21]");
				if ((nint)0 == 0)
				{
					goto IL_053b;
				}
			}
			float now7 = Now;
			float phaseEnds5 = PhaseEnds;
			if (!(now7 < phaseEnds5))
			{
				goto IL_053b;
			}
			break;
		}
		case 3:
		{
			float now5 = Now;
			float phaseEnds4 = PhaseEnds;
			if (!(now5 < phaseEnds4))
			{
				NextRound();
			}
			break;
		}
		case 0:
			{
				float voteEnds = VoteEnds;
				if (voteEnds > 0f)
				{
					float now = Now;
					float voteEnds2 = VoteEnds;
					if (!(now < voteEnds2))
					{
						BeginGame();
					}
				}
				break;
			}
			IL_053b:
			EndRace();
			break;
		}
	}

	private unsafe void BeginGame()
	{
		//IL_0010: Expected F4, but got I
		//IL_0020: Expected Obj, but got I
		//IL_083e: Expected F4, but got I4
		//IL_0847: Expected F4, but got I4
		//IL_0850: Expected VT, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_005f: Expected F4, but got Obj
		//IL_0084: Expected F4, but got I4
		//IL_008d: Expected F4, but got I4
		//IL_0096: Expected VT, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got Ref
		//IL_0176: Expected F4, but got Ref
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0307: Expected F4, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got Ref
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected F4, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_0917: Expected VT, but got Obj
		//IL_093b: Expected Obj, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected VT, but got Obj
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01eb: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I
		//IL_036f: Invalid comparison between F4 and I4
		//IL_0380: Expected Obj, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected VT, but got Obj
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected VT, but got Unknown
		//IL_03e9: Expected F4, but got Obj
		//IL_0402: Expected F4, but got I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected F4, but got Ref
		//IL_06d3: Expected F4, but got I4
		//IL_06dc: Expected Obj, but got I4
		//IL_06e4: Expected Obj, but got Ref
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected F4, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected F4, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I4
		//IL_0456: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_04b2: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_04f0: Expected F4, but got I
		//IL_04f4: Expected native int or pointer, but got F4
		//IL_04fd: Expected VT, but got F4
		//IL_0527: Expected Obj, but got I4
		//IL_052f: Expected F4, but got Obj
		//IL_0548: Expected F4, but got I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got I
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got I4
		//IL_05ed: Expected F4, but got Obj
		//IL_08d5: Expected F4, but got I
		//IL_08d9: Expected native int or pointer, but got F4
		//IL_08e2: Expected VT, but got F4
		//IL_08f4: Expected F4, but got I4
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Invalid comparison between VT and I4
		//IL_0634: Expected Obj, but got I4
		//IL_063c: Expected F4, but got Obj
		//IL_07c0: Invalid comparison between VT and I4
		//IL_0799: Expected F4, but got I4
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected F4, but got I4
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDCC9]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E18]");
		List<PlayerRef> list = (List<PlayerRef>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj = default;
		obj._002Ector();
		bool flag = (object)((SimulationBehaviour)this)._runner == null;
		float num2 = 0f;
		float num3 = 0f;
		PlayerRef playerRef = (PlayerRef)0;
		object obj2 = obj;
		NullReferenceException ex7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj3 = 0;
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)this)._runner.ActivePlayers;
			List<PlayerRef> list2 = Enumerable.ToList(activePlayers);
			num = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag2 = obj == null;
			num2 = 0f;
			num3 = 0f;
			playerRef = (PlayerRef)3;
			list = list2;
			obj2 = obj;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E98]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E50]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E60]");
				Func<int, bool> func = (Func<int, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E80]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
				object obj8 = 0;
				object obj9 = obj + 16;
				object obj10 = default;
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				NetworkDictionary<PlayerRef, byte> votes = Votes;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj11 = 72;
				float num4 = default;
				NullReferenceException ex = (NullReferenceException)(&num4);
				NullReferenceException ex2 = default;
				num = (nint)(&ex2);
				object obj13 = default;
				object obj15 = default;
				Enumerator<, > val = default;
				float num7 = default;
				float num10 = default;
				float num5;
				object obj22;
				float num6;
				float num8;
				float num9 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
					object obj12 = obj13 & 1;
					if (obj12 == null)
					{
						break;
					}
					playerRef = (PlayerRef)func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
					object obj14 = obj15 >> 32;
					ex = (NullReferenceException)(obj14 & 0xFF);
					bool flag3 = (nint)ex < 2;
					object obj16 = !flag3;
					object obj17 = ex - 2;
					bool flag4 = obj17 == null;
					object obj18 = !flag4;
					object obj19 = obj16 & obj18;
					if (obj19 != null)
					{
						continue;
					}
					if ((object)list2 != null)
					{
						obj11 = obj6;
						playerRef = (PlayerRef)(obj15 & 0xFFFFFFFFL);
						if (!list2.Contains(playerRef))
						{
							continue;
						}
						num = (float)obj9;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (System.Single)+18]");
							object obj20 = 0;
							NullReferenceException ex3 = ex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (System.Single)+18]");
							bool flag5 = (nint)ex3 < 0;
							object obj21 = !flag5;
							if (obj21 == null)
							{
								num += (float)ex;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v37 (System.Single)+20]");
								obj20 = (nint)0 + (nint)1;
								continue;
							}
							goto IL_06c1;
						}
					}
					else
					{
						NullReferenceException ex4 = new NullReferenceException();
					}
					NullReferenceException ex5 = new NullReferenceException();
					goto IL_06c1;
					IL_06c1:
					IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
					num5 = 0f;
					obj22 = 0;
					ex2 = (NullReferenceException)(&num4);
					num2 = (float)val;
					num6 = num7;
					num8 = num9;
					num3 = num10;
					Enumerator<, > val2 = val;
					list = list2;
					obj2 = obj;
					goto IL_0721;
				}
				num5 = 0f;
				obj22 = 0;
				ex2 = (NullReferenceException)(&num4);
				num2 = (float)val;
				num6 = num7;
				num8 = num9;
				num3 = num10;
				object obj23 = 0;
				list = list2;
				obj2 = obj;
				float num11 = default;
				Func<int, bool> func2 = default;
				float num13 = default;
				Enumerator<, > val3 = default;
				object obj31 = default;
				while (true)
				{
					playerRef = (PlayerRef)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
					bool flag6 = obj23 == null;
					object obj24 = !flag6;
					Enumerator<, > val2 = val;
					if (obj24 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E10]");
					obj7 = 0;
					bool flag7 = num5 == 0f;
					object obj25 = !flag7;
					val2 = val;
					ex7 = ex2;
					num = num5;
					if (obj25 == null)
					{
						NetworkDictionary<PlayerRef, byte> votes2 = Votes;
						playerRef = (PlayerRef)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
						VoteEnds = 0f;
						bool flag8 = (object)list == null;
						num2 = (float)ex2;
						num6 = num11;
						num8 = num5;
						num3 = 0f;
						val2 = val;
						num = (nint)(&ex2);
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X20_v3 (System.Collections.Generic.List`1<Fusion.PlayerRef>)+18]");
							if ((nint)0 == 0)
							{
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v3 (System.Object)+10]");
							int num12 = Enumerable.Max((IEnumerable<int>)0);
							IEnumerable<int> source = Enumerable.Range(0, 3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E68]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EA0]");
							object obj27 = 0;
							func2._002Ector(obj2, (IntPtr)obj27);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E30]");
							object obj28 = 0;
							obj11 = obj28;
							IEnumerable<int> source2 = Enumerable.Where(source, func2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E20]");
							num = 0f;
							playerRef = (PlayerRef)((float*)(nint)num)->m_value;
							List<int> list3 = Enumerable.ToList(source2);
							bool flag9 = list3 == null;
							object obj29 = 0;
							num2 = (float)ex2;
							num6 = num11;
							num8 = num5;
							num3 = 0f;
							val2 = val;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v20 (System.Collections.Generic.List`1<System.Int32>)+18]");
								int index = UnityEngine.Random.Range(0, 0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
								object obj30 = 0;
								obj11 = obj30;
								int map = list3.get_Item(index);
								Map = (byte)map;
								NetworkDictionary<PlayerRef, byte> players = Players;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B528");
								Enumerator<, > enumerator = list.GetEnumerator();
								obj29 = 0;
								num2 = (float)ex2;
								num6 = num11;
								num8 = num5;
								num3 = num13;
								while (val3.MoveNext())
								{
									NetworkDictionary<PlayerRef, byte> players2 = Players;
									obj29 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
									obj11 = 1;
									num2 = (float)ex2;
									num6 = num11;
									num8 = num5;
									num3 = num13;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E38]");
								num = 0f;
								playerRef = (PlayerRef)((float*)(nint)num)->m_value;
								val3.Dispose();
								num9 = 0f;
								val2 = (Enumerator<, >)(ref val3);
								list = null;
								obj2 = list3;
								OutOfMemoryException ex8 = new OutOfMemoryException();
								if (playerRef == (PlayerRef)(object)2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									num5 = 1f;
									val = val2;
									obj23 = obj22;
									num = 1f;
									continue;
								}
								if (playerRef == (PlayerRef)(object)1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj23 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj22 = obj31;
									val = val2;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E3F0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
						}
						goto IL_0721;
					}
					goto IL_072f;
				}
				goto IL_073e;
			}
		}
		goto IL_0721;
		IL_072f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_073e;
		IL_0721:
		ex7 = new NullReferenceException();
		goto IL_072f;
		IL_073e:
		throw new OutOfMemoryException();
	}

	private unsafe void StartRound()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Ref, but got Unknown
		//IL_047d: Expected Obj, but got I4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Invalid comparison between Unknown and I4
		//IL_0152: Expected Obj, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected I4, but got Unknown
		//IL_01ee: Expected Obj, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected I4, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EA8]");
		object obj2 = 0;
		int round = Round;
		int round2 = round + 1;
		Round = round2;
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E409C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EB0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj5 = 0;
		List<KeyValuePair<PlayerRef, byte>> list = default;
		Enumerator<, > enumerator = list.GetEnumerator();
		object obj7 = default;
		object obj6 = obj7;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj9 = default;
		object obj8 = obj9;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val5 = default;
		Enumerator<, > val4 = val5;
		Enumerator<, > val7 = default;
		Enumerator<, > val6 = val7;
		Enumerator<, > val8 = default;
		while (val8.MoveNext())
		{
		}
		object obj10 = 0;
		Enumerator<, > val9 = (Enumerator<, >)0;
		Enumerator<, > val10 = (Enumerator<, >)(ref val8);
		object obj11 = 0;
		Enumerator<, > val11 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			object obj12 = obj4;
			((Enumerator<, >*)val10)->Dispose();
			bool flag = obj11 == null;
			object obj13 = !flag;
			val = (Enumerator<, >)0;
			val10 = val11;
			if (obj13 == null)
			{
				bool flag2 = (int)val9 == 0;
				object obj14 = !flag2;
				OutOfMemoryException ex = (OutOfMemoryException)val11;
				if (obj14 == null)
				{
					int round3 = Round;
					object obj15 = round3 - 1;
					bool flag3 = (nint)obj15 < 0;
					bool flag4 = obj15 == null;
					int num = round3 ^ 1;
					int num2 = round3 ^ obj15;
					int num3 = num & num2;
					bool flag5 = num3 < 0;
					bool flag6 = flag3 == flag5;
					object obj16 = !flag4;
					bool flag7 = (byte)((flag6 & obj16) ? 1 : 0) != 0;
					NetworkBool sinking = flag7;
					Sinking = sinking;
					ClearSinking();
					LayOut();
					Phase = 1;
					float now = Now;
					object obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v22+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v22+A0]");
					object obj19 = 0;
					float num4 = now;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v7+4]");
					float phaseEnds = num4 + 0f;
					PhaseEnds = phaseEnds;
					int starts = Starts;
					int starts2 = starts + 1;
					Starts = starts2;
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj6 = obj7;
				obj8 = obj9;
				obj10 = obj20;
				val2 = val3;
				val9 = val5;
				val4 = val5;
				val6 = val7;
				obj12 = obj2;
				obj5 = obj;
				obj4 = 109891584;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj12 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				val9 = (Enumerator<, >)1;
				obj11 = obj10;
				continue;
			}
			if ((nint)obj12 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj11 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj10 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E468");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void LayOut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_018e: Expected I4, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected I4, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7880]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7940]");
		object obj10 = 0;
		List<GillaSplashLayout.Spot> list2;
		if ((UnityEngine.Object)obj8 != null)
		{
			GillaSplashLayout.Hall[] halls = ((GillaSplashDirector)obj8).Halls;
			byte map = Map;
			int round = Round;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			System.Random random = default;
			random._002Ector();
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int style = map & 0xFF;
			List<GillaSplashLayout.Spot> list = GillaSplashLayout.Make(halls, style, round, random);
			System.Random random2 = random;
			list2 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C79E8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7ED0]");
			object obj15 = 0;
			int style = (int)obj15;
			List<GillaSplashLayout.Spot> list3 = default;
			list3._002Ector();
			list2 = list3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X20_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
		object obj16 = -128;
		bool flag5 = (nint)obj16 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X20_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
		int num = (int)((nint)0 ^ (nint)0x80);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X20_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
		int num2 = 0 ^ obj16;
		int num3 = num & num2;
		bool flag6 = num3 < 0;
		bool flag7 = flag5 == flag6;
		object obj17 = !flag7;
		object obj18 = ~obj17;
		int num4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X20_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
			num4 = 0;
		}
		else
		{
			num4 = 128;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X20_v5 (System.Collections.Generic.List`1<GillaSplashLayout+Spot>)+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7980]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7ED8]");
			object obj20 = 0;
			int num5 = 0;
			GillaSplashLayout.Spot s = default;
			NetworkArray<int> networkArray = default;
			bool flag9;
			do
			{
				NetworkArray<int> platforms = Platforms;
				GillaSplashLayout.Spot spot = list2.get_Item(num5);
				object obj21 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v26+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int value = GillaSplashLayout.Pack(ref s);
				System.Random random2 = (System.Random)obj20;
				int num6 = networkArray.Set(num5, value);
				num5++;
				flag9 = num4 != num5;
				int style = num5;
			}
			while (flag9);
		}
		PlatformCount = num4;
		int layouts = Layouts;
		int layouts2 = layouts + 1;
		Layouts = layouts2;
		int layoutCheck = CheckNow();
		LayoutCheck = layoutCheck;
	}

	public int CheckNow()
	{
		//IL_0108: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I4, but got Unknown
		//IL_002c: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		int layouts = Layouts;
		int platformCount = PlatformCount;
		object obj = layouts * 16777619;
		int num = obj ^ platformCount;
		int platformCount2 = PlatformCount;
		if (platformCount2 >= 1)
		{
			NetworkArray<int> networkArray = (NetworkArray<int>)0;
			int num2 = 0;
			int num3 = num;
			bool flag3;
			NetworkArray<int> networkArray2 = default;
			do
			{
				NetworkArray<int> platforms = Platforms;
				int num4 = networkArray.get_Item(num2);
				int num5 = num4 ^ num3;
				num = num5 * 16777619;
				int platformCount3 = PlatformCount;
				bool flag = num2 < 126;
				object obj2 = !flag;
				object obj3 = num2 - 126;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				object obj5 = obj2 & obj4;
				if (obj5 != null)
				{
					break;
				}
				int num6 = num2 + 1;
				flag3 = num6 < platformCount3;
				networkArray = networkArray2;
				num2 = num6;
				num3 = num;
			}
			while (flag3);
		}
		return num;
	}

	private unsafe void EndRace()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Ref, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_0169: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EA8]");
		object obj2 = 0;
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E409C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EB0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj5 = 0;
		List<KeyValuePair<PlayerRef, byte>> list = default;
		Enumerator<, > enumerator = list.GetEnumerator();
		object obj7 = default;
		object obj6 = obj7;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj9 = default;
		object obj8 = obj9;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val5 = default;
		Enumerator<, > val4 = val5;
		Enumerator<, > val7 = default;
		Enumerator<, > val6 = val7;
		Enumerator<, > val8 = default;
		bool flag2 = default;
		while (val8.MoveNext())
		{
			bool flag = flag2;
			flag = true;
			flag2 = true;
		}
		object obj10 = 0;
		object obj11 = 5;
		Enumerator<, > val9 = (Enumerator<, >)0;
		Enumerator<, > val10 = (Enumerator<, >)(ref val8);
		object obj12 = 0;
		Enumerator<, > val11 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			object obj13 = obj4;
			((Enumerator<, >*)val10)->Dispose();
			bool flag3 = obj12 == null;
			object obj14 = !flag3;
			val = (Enumerator<, >)0;
			val10 = val11;
			if (obj14 == null)
			{
				bool flag4 = (int)val9 == 0;
				object obj15 = !flag4;
				OutOfMemoryException ex = (OutOfMemoryException)val11;
				if (obj15 == null)
				{
					if ((nint)obj11 != 5)
					{
						bool flag5 = obj11 == null;
						object obj16 = !flag5;
						if (obj16 != null)
						{
							return;
						}
					}
					Phase = 3;
					float now = Now;
					object obj17 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v13+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v13+A0]");
					object obj19 = 0;
					float num = now;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v8+8]");
					float phaseEnds = num + 0f;
					PhaseEnds = phaseEnds;
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj6 = obj7;
				obj8 = obj9;
				obj10 = obj20;
				val2 = val3;
				val9 = val5;
				obj13 = obj2;
				val4 = val5;
				val6 = val7;
				obj5 = obj;
				obj4 = 109891584;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj13 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				val9 = (Enumerator<, >)1;
				obj12 = obj10;
			}
			else
			{
				if ((nint)obj13 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj12 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj10 = obj21;
			}
			obj11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E468");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void NextRound()
	{
		//IL_011e: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		int num = Count(2);
		if (num != 0)
		{
			int round = Round;
			if (round <= 6)
			{
				if (num == 1)
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v17+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v17+A0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+20]");
					if ((nint)0 == 0)
					{
						goto IL_002f;
					}
				}
				StartRound();
				return;
			}
		}
		goto IL_002f;
		IL_002f:
		Phase = 4;
		float now = Now;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v8+A0]");
		object obj7 = 0;
		float num2 = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v5+C]");
		float phaseEnds = num2 + 0f;
		PhaseEnds = phaseEnds;
	}

	private void ClearSinking()
	{
		//IL_006c: Expected VT, but got I4
		//IL_009e: Invalid comparison between F4 and I4
		NetworkArray<float> networkArray = (NetworkArray<float>)0;
		int num = 0;
		NetworkArray<float> networkArray2 = default;
		NetworkArray<float> networkArray3 = default;
		do
		{
			NetworkArray<float> sinkAt = SinkAt;
			float num2 = networkArray.get_Item(num);
			if (num2 > 0f)
			{
				NetworkArray<float> sinkAt2 = SinkAt;
				float num3 = networkArray2.Set(num, 0f);
				networkArray = networkArray3;
			}
			num++;
		}
		while (num != 128);
	}

	static GillaSplashGame()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EE0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EE8]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E8C0]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6C0]");
		_ = 0;
		_ = 18289262592L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434FD2C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+A0]");
		object obj7 = (nint)0 + (nint)40;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_00e2: Expected VT, but got Ref
		//IL_0121: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7EF8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F00]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7F08]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C78E8]");
		object obj5 = 0;
		Phase = _Phase;
		VoteEnds = _VoteEnds;
		NetworkDictionary<PlayerRef, byte> votes = Votes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		Map = _Map;
		Round = _Round;
		Starts = _Starts;
		PhaseEnds = _PhaseEnds;
		Sinking = _Sinking;
		NetworkDictionary<PlayerRef, byte> players = Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D75A8");
		NetworkArray<float> sinkAt = SinkAt;
		object obj6 = default;
		NetworkBehaviourUtils.InitializeNetworkArray((NetworkArray<float>)(&obj6), _SinkAt, (string)obj4);
		Layouts = _Layouts;
		PlatformCount = _PlatformCount;
		NetworkArray<int> platforms = Platforms;
		NetworkBehaviourUtils.InitializeNetworkArray((NetworkArray<int>)(&obj6), _Platforms, (string)obj5);
		LayoutCheck = _LayoutCheck;
	}

	public unsafe override void CopyStateToBackingFields()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Ref, but got Unknown
		//IL_00e5: Expected VT, but got Ref
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Ref, but got Unknown
		//IL_0139: Expected VT, but got Ref
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
		int round = Round;
		_Round = round;
		int starts = Starts;
		_Starts = starts;
		float phaseEnds = PhaseEnds;
		_PhaseEnds = phaseEnds;
		NetworkBool sinking = Sinking;
		_Sinking = sinking;
		NetworkDictionary<PlayerRef, byte> players = Players;
		object obj3 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6550");
		NetworkArray<float> sinkAt = SinkAt;
		object obj4 = default;
		NetworkBehaviourUtils.CopyFromNetworkArray((NetworkArray<float>)(&obj4), ref *(float[]*)(this + 152));
		int layouts = Layouts;
		_Layouts = layouts;
		int platformCount = PlatformCount;
		_PlatformCount = platformCount;
		NetworkArray<int> platforms = Platforms;
		NetworkBehaviourUtils.CopyFromNetworkArray((NetworkArray<int>)(&obj4), ref *(int[]*)(this + 168));
		int layoutCheck = LayoutCheck;
		_LayoutCheck = layoutCheck;
	}

	protected unsafe static void RPC_Vote_0040Invoker1533595928([In] ref RpcInvokeContext context)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DA0]");
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
		GillaSplashGame gillaSplashGame = (GillaSplashGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaSplashGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaSplashGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaSplashGame>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte map = default;
				object obj16 = default;
				gillaSplashGame.RPC_Vote(map, (RpcInfo)(&obj16));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Finished_0040Invoker3009007143([In] ref RpcInvokeContext context)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DB8]");
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
		GillaSplashGame gillaSplashGame = (GillaSplashGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaSplashGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashGame>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaSplashGame.RPC_Finished((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Died_0040Invoker2665585797([In] ref RpcInvokeContext context)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DC8]");
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
		GillaSplashGame gillaSplashGame = (GillaSplashGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaSplashGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<GillaSplashGame>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaSplashGame.RPC_Died((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Stood_0040Invoker4031950739([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected VT, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_0162: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out int value, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7DD8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaSplashGame gillaSplashGame = (GillaSplashGame)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaSplashGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaSplashGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaSplashGame>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaSplashGame.RPC_Stood(value, (RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
