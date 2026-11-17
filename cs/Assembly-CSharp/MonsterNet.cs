using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class MonsterNet : NetworkBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BoxCollider, bool> _003C_003E9__8_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCEA8]");
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

		internal bool _003CBarred_003Eb__8_0(BoxCollider b)
		{
			//IL_004b: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			if ((object)b != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F50]");
				object obj = 0;
				string name = b.name;
				return name == (string)obj;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public MonsterBrain brain;

	private float _Speed;

	private float _Pace;

	private Vector3 _Look;

	private float _LookWeight;

	private PlayerRef _Victim;

	private int _Kills;

	private NetworkBool _Chasing;

	private NetworkBool _Prying;

	private float _Climb;

	private NetworkBool _Dead;

	private float _HealthLeft;

	private float _SnareLeft;

	private int _HurtsMade;

	private PlayerRef _Prey;

	private Vector4[] _Hurts;

	private const int MostHurts = default(int);

	private int seenKills;

	private int seenHurts;

	private int quietUpTo;

	private float nextClaim;

	private float claimedAt = -100f;

	private const float ClaimFor = default(float);

	private static readonly List<MonsterNet> spawned;

	private const int MostEach = default(int);

	private bool counted;

	public static readonly NetworkRunner.OnBeforeSpawned FromGame;

	private bool fromGame;

	private unsafe float Speed
	{
		get
		{
			//IL_002e: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				return (nint)ptr;
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
			//IL_0027: Expected I, but got F4
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

	private unsafe float Pace
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

	private unsafe Vector3 Look
	{
		get
		{
			//IL_0021: Expected VT, but got Obj
			//IL_0073: Expected VT, but got Obj
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
				return (Vector3)ex2;
			}
			return (Vector3)this;
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

	private unsafe float LookWeight
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+14]");
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

	private unsafe PlayerRef Victim
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
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

	private unsafe int Kills
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1C]");
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

	private unsafe NetworkBool Chasing
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+20]");
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

	private unsafe NetworkBool Prying
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+24]");
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

	private unsafe float Climb
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+28]");
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

	private unsafe NetworkBool Dead
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+2C]");
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

	private unsafe float HealthLeft
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+30]");
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

	private unsafe float SnareLeft
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+34]");
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

	private unsafe int HurtsMade
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+38]");
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

	private unsafe PlayerRef Prey
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+3C]");
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

	private unsafe NetworkArray<Vector4> Hurts
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD000]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F076AC");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 64;
				NetworkArray<Vector4> networkArray = (NetworkArray<Vector4>)0;
				IElementReaderWriter<Vector4> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<Vector4>(array, 16, readerWriter));
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
			return (NetworkArray<Vector4>)ex2;
		}
	}

	public bool CanSay
	{
		get
		{
			//IL_003f: Expected Obj, but got I4
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected I4, but got Unknown
			if (IsAuthority)
			{
				int hurtsMade = HurtsMade;
				object obj = hurtsMade - 16;
				bool flag = (nint)obj < 0;
				int num = hurtsMade ^ 0x10;
				int num2 = hurtsMade ^ obj;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				bool flag3 = flag == flag2;
				return !flag3;
			}
			return false;
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

	public bool IsAuthority
	{
		get
		{
			//IL_0063: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got I4
			if (Live)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						bool result = default;
						return result;
					}
				}
			}
			return false;
		}
	}

	private static void ForgetSpawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
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
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	public unsafe void RPC_Caught(RpcInfo info = default(RpcInfo))
	{
		//IL_0671: Expected VT, but got I4
		//IL_0683: Expected VT, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0055: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_00b7: Expected VT, but got I4
		//IL_00ca: Expected VT, but got Obj
		//IL_0124: Expected Obj, but got VT
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_0223: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I
		//IL_028d: Expected VT, but got I8
		//IL_02a8: Expected VT, but got I4
		//IL_02cb: Expected Obj, but got VT
		//IL_02e5: Expected Obj, but got I4
		//IL_0317: Expected VT, but got I4
		//IL_0329: Expected Obj, but got I4
		//IL_0331: Expected VT, but got Ref
		//IL_0339: Expected I, but got VT
		//IL_034a: Expected Obj, but got Ref
		//IL_0353: Expected Obj, but got I4
		//IL_019b: Expected VT, but got I4
		//IL_01a0: Expected VT, but got Obj
		//IL_01b1: Expected VT, but got I4
		//IL_05e3: Expected Ref, but got VT
		//IL_05fd: Expected Obj, but got I4
		//IL_0733: Expected Obj, but got I4
		//IL_01c8: Invalid comparison between VT and I4
		//IL_061c: Expected Obj, but got VT
		//IL_0625: Expected Obj, but got I4
		//IL_03b5: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I4
		//IL_01e5: Invalid comparison between VT and I4
		//IL_01f7: Expected VT, but got I4
		//IL_01fc: Expected VT, but got Obj
		//IL_020d: Expected VT, but got I4
		//IL_06a1: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I4
		//IL_074a: Invalid comparison between VT and I4
		//IL_0502: Expected native int or pointer, but got VT
		//IL_050f: Expected native int or pointer, but got VT
		//IL_0525: Expected VT, but got I4
		//IL_052a: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_041d: Expected VT, but got Obj
		//IL_0429: Expected I, but got Obj
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected VT, but got Unknown
		//IL_0458: Expected Obj, but got I4
		//IL_0490: Expected I4, but got I8
		//IL_04a7: Expected VT, but got I4
		//IL_04d3: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcChannel rpcChannel = (RpcChannel)0;
		RpcInvokeInfo rpcInvokeInfo = (RpcInvokeInfo)109895680;
		MethodBase methodBase = default;
		RpcInvokeInfo rpcInvokeInfo2;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer = default;
		object obj2 = default;
		RpcInvokeInfo rpcInvokeInfo3;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			methodBase = (MethodBase)0;
			nint num = (nint)methodBase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v44 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj = !flag3;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			bool flag4 = (object)((SimulationBehaviour)this)._runner == null;
			rpcBuilder = (Fusion.RpcBuilder)0;
			rpcChannel = (RpcChannel)0;
			rpcInvokeInfo = (RpcInvokeInfo)((SimulationBehaviour)this)._runner;
			if (!flag4)
			{
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(1553443366u, 0, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo2 = rpcBuilder3.Prepare(out writer);
				obj2 = rpcInvokeInfo2 >> 32;
				object obj3 = obj2 - 522;
				bool flag5 = (nint)obj3 < 2;
				object obj4 = !flag5;
				object obj5 = ~obj4;
				PlayerRef playerRef2;
				PlayerRef playerRef;
				PlayerRef playerRef3;
				if (obj5 == null && (nint)obj2 != 518)
				{
					bool flag6 = (nint)obj2 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo3 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_02bd;
					}
					if (rpcInvokeInfo2 != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo2 != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo3 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_02bd;
						}
					}
				}
				nint num2 = (nint)methodBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v59 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag8 = (nint)0 == 0;
				object obj6 = !flag8;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD030]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo2, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo3 = rpcInvokeInfo2;
				goto IL_02bd;
			}
			goto IL_0538;
		}
		goto IL_0005;
		IL_0719:
		nint num3 = default;
		bool flag9 = num3 == 0;
		object obj7 = !flag9;
		object obj8;
		Fusion.RpcBuilder rpcBuilder4 = default;
		nint num5;
		if (obj7 == null)
		{
			if ((nint)obj8 != 6)
			{
				bool flag10 = obj8 == null;
				object obj9 = !flag10;
				if (obj9 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v6+E4]");
			bool flag11 = (nint)0 == 0;
			object obj12 = !flag11;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v6+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD028]");
				object obj15 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj15);
				nint num4 = (nint)methodBase;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)(rpcInvokeInfo | obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v10 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag12 = (nint)0 == 0;
				object obj16 = !flag12;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X26_v1+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num3 = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef3 = (PlayerRef)0;
				methodBase = methodFromHandle;
			}
			if (rpcInvokeInfo != (RpcInvokeInfo)(object)0)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, (Tick)rpcBuilder4);
			((RpcInfo*)(nint)info)->_validationResult = num3;
			rpcBuilder = rpcBuilder4;
			PlayerRef playerRef2 = (PlayerRef)0;
			num5 = unchecked((nint)null);
			rpcChannel = (RpcChannel)0;
			goto IL_0005;
		}
		goto IL_0546;
		IL_0538:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0546;
		IL_0005:
		if ((object)brain != null)
		{
			brain.Claimed(info.Source);
			return;
		}
		goto IL_0538;
		IL_0546:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj17;
		object obj18 = default;
		OutOfMemoryException ex2;
		if (rpcChannel == (RpcChannel)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = obj18;
			num3 = 1;
		}
		else
		{
			bool flag13 = rpcChannel != (RpcChannel)1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_06f6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj19 = default;
			obj17 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj18 = obj19;
		}
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag14 = obj17 == null;
		object obj20 = !flag14;
		if (obj20 == null)
		{
			rpcChannel = (RpcChannel)0;
			ex = (NullReferenceException)rpcBuilder4;
			obj8 = 0;
			goto IL_0719;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		rpcChannel = (RpcChannel)0;
		goto IL_06f6;
		IL_02bd:
		object obj21 = rpcInvokeInfo2 >> 32;
		bool flag15 = obj21 == null;
		object obj22 = !flag15;
		if (obj22 == null)
		{
			int num6 = rpcBuilder3.Send();
		}
		rpcBuilder3.Dispose();
		rpcBuilder = (Fusion.RpcBuilder)0;
		num3 = 0;
		obj18 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num5 = (nint)rpcInvokeInfo3;
		rpcChannel = (RpcChannel)0;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj8 = 6;
		rpcInvokeInfo = rpcInvokeInfo2;
		goto IL_0719;
		IL_06f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public void Say(Vector4 said)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected VT, but got Obj
		if (CanSay)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD038]");
			object obj = 0;
			NetworkArray<Vector4> hurts = Hurts;
			int hurtsMade = HurtsMade;
			NetworkArray<Vector4> networkArray = default;
			Vector4 vector = networkArray.Set(hurtsMade, (Vector4)obj);
			int hurtsMade2 = HurtsMade;
			int hurtsMade3 = hurtsMade2 + 1;
			HurtsMade = hurtsMade3;
			int hurtsMade4 = HurtsMade;
			seenHurts = hurtsMade4;
		}
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I4
		//IL_07f2: Expected Obj, but got I
		//IL_0814: Expected Obj, but got I4
		//IL_06c5: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0792: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0715: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I
		//IL_0740: Expected I, but got Obj
		//IL_075e: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_025b: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected I4, but got Unknown
		//IL_04b3: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_07b2: Expected Obj, but got I4
		//IL_07cc: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected I4, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD058]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v44+8]");
		Predicate<System.__Canon> match = (Predicate<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v44+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v48+A0]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD048]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD050]");
			object obj13 = 0;
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector(obj8, (IntPtr)obj13);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v47+A0]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			match = predicate;
			string text = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD040]");
		object obj16 = 0;
		string text2 = (string)obj16;
		int num = ((List<System.__Canon>)obj6).RemoveAll(match);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v11+A0]");
		object obj19 = 0;
		List<System.__Canon> list = (List<System.__Canon>)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDC0]");
		object obj20 = 0;
		System.__Canon[] items = list._items;
		object obj21 = obj20;
		int version = list._version + 1;
		list._version = version;
		bool flag6 = list._size < items.Length;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			object obj23 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj24 = obj23 + 32;
			obj24 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v7+20]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v39+A8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v40+70]");
			text2 = (string)0;
			list.AddWithResize((System.__Canon)(object)this);
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj27 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag7 = obj27 == null;
			object obj28 = !flag7;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				networkObject = ((SimulationBehaviour)this)._object;
				object obj29 = default;
				bool flag8 = (byte)(obj29 & 1) != 0;
				counted = flag8;
				bool flag9 = (object)((SimulationBehaviour)this)._object == null;
				object obj30 = !flag9;
				if (obj30 == null)
				{
					goto IL_0459;
				}
			}
			else
			{
				counted = false;
			}
			object obj31 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag10 = obj31 == null;
			object obj32 = !flag10;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj34 = default;
				object obj33 = obj34 & 1;
				if (obj33 != null)
				{
					bool flag11 = (byte)(~(fromGame ? 1u : 0u)) != 0;
					object obj35 = !flag11;
					if (obj35 == null)
					{
						string text3 = name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB568]");
						object oldValue = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj36 = 0;
						string text4 = text3.Replace((string)oldValue, (string)obj36);
						string what = text4.Trim();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
						object obj37 = 0;
						object obj38 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v34+E4]");
						bool flag12 = (nint)0 == 0;
						object obj39 = !flag12;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7C8]");
						object kind = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD060]");
						object obj40 = 0;
						string text = (string)obj36;
						text2 = (string)obj40;
						GillaBotReport.Tell((string)kind, what, (string)obj40, (string)obj36, (string)obj36);
					}
				}
			}
		}
		else
		{
			counted = false;
		}
		goto IL_0459;
		IL_0459:
		int kills = Kills;
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		MonsterBrain monsterBrain = brain;
		seenKills = kills;
		object obj43;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj41 = networkObject2.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag13 = obj41 == null;
			object obj42 = !flag13;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj44 = default;
				obj43 = obj44 ^ 1;
				goto IL_0507;
			}
		}
		obj43 = 1;
		goto IL_0507;
		IL_0507:
		NetworkObject networkObject3 = ((SimulationBehaviour)this)._object;
		bool flag14 = (byte)(obj43 & 1) != 0;
		monsterBrain.Puppet__BackingField = flag14;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj45 = networkObject3.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag15 = obj45 == null;
			object obj46 = !flag15;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj48 = default;
				object obj47 = obj48 & 1;
				if (obj47 != null)
				{
					int hurtsMade = HurtsMade;
					bool flag16 = hurtsMade == 0;
					object obj49 = !flag16;
					if (obj49 == null)
					{
						MonsterBrain monsterBrain2 = brain;
						HealthLeft = monsterBrain2.Health__BackingField;
					}
				}
			}
		}
		int hurtsMade2 = HurtsMade;
		quietUpTo = hurtsMade2;
		NetworkBool dead = Dead;
		if ((bool)dead)
		{
			brain.ShowDeath();
		}
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
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

	private unsafe bool Counted()
	{
		//IL_0023: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_04a6: Expected I4, but got Obj
		//IL_01da: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0503: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I
		//IL_057d: Expected I, but got Obj
		//IL_058e: Expected I, but got Obj
		//IL_05ac: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		bool result;
		if (~(counted ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = GillaNetGuard.Master(((SimulationBehaviour)this)._runner);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			bool flag3 = playerRef == none;
			result = true;
			if (flag3)
			{
				goto IL_04bf;
			}
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			counted = true;
			if ((object)((SimulationBehaviour)this)._object == null)
			{
				goto IL_0498;
			}
			int* ptr = networkObject.Ptr;
			PlayerRef none2 = default;
			if (networkObject.Ptr != null)
			{
				NetworkRunner runner = networkObject._runner;
				if ((object)networkObject._runner == null || (object)runner._simulation == null)
				{
					goto IL_0498;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v10 (System.Int32*)+20]");
				Func<System.__Canon, bool> func = (Func<System.__Canon, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
				nint num = 0;
			}
			else
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v48+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				none2 = PlayerRef.None;
				Func<System.__Canon, bool> func = null;
			}
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (none2 != playerRef)
			{
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v17+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none3 = PlayerRef.None;
				if (none2 != none3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
					object obj13 = 0;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v15+E4]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj13;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD058]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v15+A0]");
					object obj17 = 0;
					object obj18 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v23+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj18 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v23+A0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v25+10]");
					Func<System.__Canon, bool> func2 = (Func<System.__Canon, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v25+10]");
					bool flag9 = (nint)0 == 0;
					object obj21 = !flag9;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v23+E4]");
						bool flag10 = (nint)0 == 0;
						object obj22 = !flag10;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj23 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v29+A0]");
							obj20 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD070]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD080]");
						object obj25 = 0;
						nint num = (nint)obj25;
						Func<System.__Canon, bool> func3 = default;
						func3._002Ector(obj20, (IntPtr)obj25);
						object obj26 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v28+A0]");
						object obj27 = (nint)0 + (nint)16;
						obj27 = func3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						func2 = func3;
						Func<System.__Canon, bool> func = func3;
					}
					object obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v25+E4]");
					bool flag11 = (nint)0 == 0;
					object obj29 = !flag11;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD078]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627130");
					object obj31 = default;
					if ((nint)obj31 >= 4)
					{
						object obj32 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v29+E4]");
						bool flag12 = (nint)0 == 0;
						object obj33 = !flag12;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7C8]");
						object what = 0;
						GillaNetGuard.Ignore(this, (string)what, 4);
						result = false;
						goto IL_04bf;
					}
				}
			}
		}
		result = true;
		goto IL_04bf;
		IL_0498:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_04bf:
		return result;
	}

	public void KillStarted(PlayerRef victim)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected VT, but got Unknown
		if (IsAuthority)
		{
			PlayerRef victim2 = (PlayerRef)(victim & 0xFFFFFFFFL);
			Victim = victim2;
			int kills = Kills;
			int kills2 = kills + 1;
			Kills = kills2;
			int kills3 = Kills;
			seenKills = kills3;
		}
	}

	public override void FixedUpdateNetwork()
	{
		//IL_0094: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0199: Expected VT, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		MonsterBrain monsterBrain = brain;
		object obj3;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				obj3 = obj4 ^ 1;
				goto IL_0099;
			}
		}
		obj3 = 1;
		goto IL_0099;
		IL_0099:
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		bool flag2 = (byte)(obj3 & 1) != 0;
		monsterBrain.Puppet__BackingField = flag2;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj5 = networkObject2.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj8 = default;
			object obj7 = obj8 & 1;
			if (obj7 != null)
			{
				MonsterBrain monsterBrain2 = brain;
				Speed = monsterBrain2.AnimSpeed__BackingField;
				MonsterBrain monsterBrain3 = brain;
				Pace = monsterBrain3.AnimPace__BackingField;
				Look = (Vector3)0;
				MonsterBrain monsterBrain4 = brain;
				LookWeight = monsterBrain4.LookWeight__BackingField;
				MonsterBrain monsterBrain5 = brain;
				NetworkBool prying = monsterBrain5.Prying__BackingField;
				Prying = prying;
				MonsterBrain monsterBrain6 = brain;
				Climb = monsterBrain6.ClimbPitch__BackingField;
				MonsterBrain monsterBrain7 = brain;
				NetworkBool chasing = monsterBrain7.Chasing__BackingField;
				Chasing = chasing;
				MonsterBrain monsterBrain8 = brain;
				NetworkBool dead = monsterBrain8.Dead__BackingField;
				Dead = dead;
				MonsterBrain monsterBrain9 = brain;
				HealthLeft = monsterBrain9.Health__BackingField;
				MonsterBrain monsterBrain10 = brain;
				SnareLeft = monsterBrain10.SnareLeft__BackingField;
				PlayerRef preyPlayer = brain.PreyPlayer;
				Prey = preyPlayer;
			}
		}
	}

	private void CatchUp()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00cc: Expected VT, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected I4, but got Unknown
		//IL_0175: Expected VT, but got I4
		MonsterBrain monsterBrain = brain;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = monsterBrain.Hurt__BackingField == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int hurtsMade = HurtsMade;
		if (seenHurts < hurtsMade)
		{
			NetworkArray<Vector4> networkArray = (NetworkArray<Vector4>)0;
			bool flag7;
			NetworkArray<Vector4> networkArray2 = default;
			do
			{
				MonsterBrain monsterBrain2 = brain;
				NetworkArray<Vector4> hurts = Hurts;
				Vector4 vector = networkArray.get_Item(seenHurts);
				object obj5 = seenHurts - quietUpTo;
				bool flag4 = (nint)obj5 < 0;
				int num = seenHurts ^ quietUpTo;
				int num2 = seenHurts ^ obj5;
				int num3 = num & num2;
				bool flag5 = num3 < 0;
				bool flag6 = flag4 == flag5;
				monsterBrain2.Hurt__BackingField.Take((Vector4)flag6, loud: false);
				int num4 = ++seenHurts;
				int hurtsMade2 = HurtsMade;
				flag7 = num4 < hurtsMade2;
				networkArray = networkArray2;
			}
			while (flag7);
		}
	}

	public unsafe override void Render()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_024f: Invalid comparison between F4 and I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_02fc: Expected VT, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I4
		//IL_0678: Expected Obj, but got I4
		//IL_05e1: Expected VT, but got Ref
		//IL_05ea: Expected F4, but got I4
		//IL_070a: Expected Obj, but got I
		//IL_071a: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I
		//IL_075c: Expected Obj, but got I4
		//IL_07bc: Expected Obj, but got I
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		MonsterBrain monsterBrain = brain;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			}
			else
			{
				networkObject = null;
			}
		}
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		object obj3 = ~networkObject;
		bool flag2 = (byte)(1 & obj3) != 0;
		monsterBrain.Puppet__BackingField = flag2;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj4 = networkObject2.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag3 = obj4 == null;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj7 = default;
				object obj6 = obj7 & 1;
				bool flag4 = obj6 == null;
				object obj8 = !flag4;
				if (obj8 != null)
				{
					goto IL_014c;
				}
			}
		}
		if (Counted())
		{
			goto IL_014c;
		}
		return;
		IL_014c:
		CatchUp();
		NetworkObject networkObject3 = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj9 = networkObject3.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag5 = obj9 == null;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj12 = default;
				object obj11 = obj12 & 1;
				bool flag6 = obj11 == null;
				object obj13 = !flag6;
				if (obj13 != null)
				{
					return;
				}
			}
		}
		NetworkBool dead = Dead;
		if ((bool)dead)
		{
			brain.ShowDeath();
			return;
		}
		float healthLeft = HealthLeft;
		if (healthLeft > 0f)
		{
			float healthLeft2 = HealthLeft;
			brain.HeardHealth(healthLeft2);
		}
		float snareLeft = SnareLeft;
		brain.ShowSnare(snareLeft);
		float speed = Speed;
		float pace = Pace;
		Vector3 look = Look;
		float lookWeight = LookWeight;
		brain.ShowPuppet(speed, pace, (Vector3)0, pace);
		MonsterBrain monsterBrain2 = brain;
		bool flag7 = !monsterBrain2.Prying__BackingField;
		object obj14 = !flag7;
		NetworkBool prying = Prying;
		bool flag8 = prying;
		if ((nint)obj14 != (flag8 ? 1 : 0))
		{
			NetworkBool prying2 = Prying;
			bool flag9 = prying2;
			brain.ShowPry(flag9);
			object obj15 = 0;
		}
		MonsterBrain monsterBrain3 = brain;
		float climb = Climb;
		if (monsterBrain3.ClimbPitch__BackingField != climb)
		{
			climb = Climb;
			brain.ShowClimb(climb);
		}
		MonsterBrain monsterBrain4 = brain;
		bool flag10 = !monsterBrain4.Chasing__BackingField;
		object obj16 = !flag10;
		NetworkBool chasing = Chasing;
		bool flag11 = chasing;
		if ((nint)obj16 != (flag11 ? 1 : 0))
		{
			NetworkBool chasing2 = Chasing;
			bool flag12 = chasing2;
			brain.ShowChasing(flag12);
			object obj15 = 0;
		}
		PlayerRef prey = Prey;
		PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = prey != localPlayer;
		float num = pace;
		if (!flag14)
		{
			climb = Time.unscaledTime;
			num = nextClaim;
			if (!(climb < nextClaim) && brain.HasYouHere())
			{
				float unscaledTime = Time.unscaledTime;
				float num2 = unscaledTime + 0.25f;
				nextClaim = num2;
				climb = Time.unscaledTime;
				claimedAt = climb;
				object obj20 = default;
				RPC_Caught((RpcInfo)(&obj20));
				num = 0f;
			}
		}
		int kills = Kills;
		if (kills == seenKills)
		{
			return;
		}
		int kills2 = Kills;
		seenKills = kills2;
		PlayerRef victim = Victim;
		PlayerRef localPlayer2 = ((SimulationBehaviour)this)._runner.LocalPlayer;
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v19+E4]");
		bool flag15 = (nint)0 == 0;
		object obj22 = !flag15;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (victim == localPlayer2)
		{
			float unscaledTime2 = Time.unscaledTime;
			float num3 = unscaledTime2 - claimedAt;
			if (!((double)num3 > 2.0))
			{
				brain.PlayKill();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj24 = 0;
				object obj25 = obj23;
				object obj26 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X9_v8+A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v55+E4]");
				bool flag16 = (nint)0 == 0;
				object obj28 = !flag16;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj27 != null)
				{
					object obj29 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v23+A0]");
					object obj30 = 0;
					bool flag17 = ((KillCam)obj30).Begin(brain, (Transform)null);
				}
			}
		}
		else
		{
			brain.PlayKill();
		}
	}

	static MonsterNet()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDD8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD058]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD090]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+A0]");
		object obj7 = 0;
		obj7 = list;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkRunner.OnBeforeSpawned onBeforeSpawned = default;
		onBeforeSpawned._002Ector(obj11, (IntPtr)obj5);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v8+A0]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = onBeforeSpawned;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f8: Expected VT, but got I4
		//IL_00d5: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD098]");
		object obj = 0;
		Speed = _Speed;
		Pace = _Pace;
		Look = (Vector3)P_0;
		LookWeight = _LookWeight;
		Victim = _Victim;
		Kills = _Kills;
		Chasing = _Chasing;
		Prying = _Prying;
		Climb = _Climb;
		Dead = _Dead;
		HealthLeft = _HealthLeft;
		SnareLeft = _SnareLeft;
		HurtsMade = _HurtsMade;
		Prey = _Prey;
		NetworkArray<Vector4> hurts = Hurts;
		object obj2 = default;
		NetworkBehaviourUtils.InitializeNetworkArray((NetworkArray<Vector4>)(&obj2), _Hurts, (string)obj);
	}

	public unsafe override void CopyStateToBackingFields()
	{
		//IL_0010: Expected VT, but got F4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Ref, but got Unknown
		//IL_0136: Expected VT, but got Ref
		float speed = Speed;
		_Speed = speed;
		float num = (_Pace = Pace);
		Vector3 look = Look;
		_Look = (Vector3)num;
		float lookWeight = LookWeight;
		_LookWeight = lookWeight;
		PlayerRef victim = Victim;
		_Victim = victim;
		int kills = Kills;
		_Kills = kills;
		NetworkBool chasing = Chasing;
		_Chasing = chasing;
		NetworkBool prying = Prying;
		_Prying = prying;
		float climb = Climb;
		_Climb = climb;
		NetworkBool dead = Dead;
		_Dead = dead;
		float healthLeft = HealthLeft;
		_HealthLeft = healthLeft;
		float snareLeft = SnareLeft;
		_SnareLeft = snareLeft;
		int hurtsMade = HurtsMade;
		_HurtsMade = hurtsMade;
		PlayerRef prey = Prey;
		_Prey = prey;
		NetworkArray<Vector4> hurts = Hurts;
		object obj = default;
		NetworkBehaviourUtils.CopyFromNetworkArray((NetworkArray<Vector4>)(&obj), ref *(Vector4[]*)(this + 176));
	}

	protected unsafe static void RPC_Caught_0040Invoker1553443366([In] ref RpcInvokeContext context)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD028]");
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
		MonsterNet monsterNet = (MonsterNet)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)monsterNet;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<MonsterNet>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12 (Il2CppClass<MonsterNet>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X1_v4+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v15-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				monsterNet.RPC_Caught((RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
