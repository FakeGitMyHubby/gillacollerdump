using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using PlayFab;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaFriends : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass36_2
	{
		public Vector3 push;

		public Vector3 at;

		public GillaFreecam._003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals2;

		internal void _003CResolve_003Eb__1()
		{
			//IL_002b: Expected VT, but got I4
			//IL_002b: Expected VT, but got I4
			GillaFreecam._003C_003Ec__DisplayClass36_0 obj = CS_0024_003C_003E8__locals2;
			ForceMode mode = default;
			obj.body.AddForceAtPosition((Vector3)1, (Vector3)0, mode);
		}
	}

	[Serializable]
	public class Person
	{
		public string id;

		public string name;

		public Person()
		{
			//IL_0010: Expected Obj, but got I
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			object obj2 = this + 16;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = this + 24;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	public class Friend
	{
		public string id;

		public string name;

		public string code;

		public bool on;

		public bool known;

		public int kind;

		public int players;

		public int most;

		public Friend()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			object obj2 = this + 16;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = this + 24;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 32;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	public class News
	{
		public long t;

		public string k;

		public string id;

		public string n;

		public News()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			object obj2 = this + 24;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = this + 32;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	public class State
	{
		public Friend[] friends;

		public Person[] asking;

		public Person[] asked;

		public Person[] blocked;

		public News[] inbox;

		public int page;

		public int pages;

		public long now;

		public string refused;

		public State()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected Obj, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected Obj, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected Obj, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AC0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AC8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AD0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj4 = this + 16;
			object obj5 = default;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj6 = this + 24;
			object obj7 = default;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = this + 32;
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj10 = this + 40;
			object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj12 = this + 48;
			object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	private class Reply
	{
		public string did;

		public string name;

		public string refused;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UpdateUserDataResult> _003C_003E9__84_0;

		public static Action<UpdateUserTitleDisplayNameResult> _003C_003E9__84_2;

		public static Action<PlayFabError> _003C_003E9__84_3;

		public static Action<UpdateUserDataResult> _003C_003E9__85_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C30]");
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

		internal void _003CSaveName_003Eb__84_0(UpdateUserDataResult _)
		{
		}

		internal void _003CSaveName_003Eb__84_2(UpdateUserTitleDisplayNameResult _)
		{
		}

		internal unsafe void _003CSaveName_003Eb__84_3(PlayFabError error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_003e: Expected Obj, but got Ref
			//IL_0086: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F00]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EF8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj3 = 0;
			object obj4 = default;
			string text = ((Enum)(&obj4)).ToString();
			string message = (string)obj + text + (string)obj2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}

		internal void _003CPresence_003Eb__85_0(UpdateUserDataResult _)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public string id;

		internal bool _003CIsBlocked_003Eb__0(Person p)
		{
			//IL_0048: Expected I4, but got Obj
			if (p != null)
			{
				return p.id == id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public string id;

		internal bool _003CIsFriend_003Eb__0(Friend f)
		{
			//IL_0048: Expected I4, but got Obj
			if (f != null)
			{
				return f.id == id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public string id;

		internal bool _003CAsksYou_003Eb__0(Person p)
		{
			//IL_0048: Expected I4, but got Obj
			if (p != null)
			{
				return p.id == id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public string id;

		internal bool _003CYouAsked_003Eb__0(Person p)
		{
			//IL_0048: Expected I4, but got Obj
			if (p != null)
			{
				return p.id == id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public GillaFriends _003C_003E4__this;

		public bool quick;

		internal void _003CLook_003Eb__0(string json)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0254: Expected Obj, but got I
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Expected Obj, but got Unknown
			//IL_032b: Expected Obj, but got I
			//IL_0355: Expected Obj, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_02a5: Expected Obj, but got I4
			//IL_02c3: Expected I, but got Obj
			//IL_038e: Expected Obj, but got I4
			//IL_03b2: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_0131: Expected I, but got Obj
			//IL_015d: Expected Obj, but got I
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected Obj, but got Unknown
			//IL_0194: Expected I4, but got Obj
			GillaFriends gillaFriends = _003C_003E4__this;
			bool flag = (object)_003C_003E4__this == null;
			State state = (State)(object)json;
			object obj2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F08]");
				object obj = 0;
				gillaFriends.busy = false;
				State state2 = (State)obj;
				System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(json);
				if (_Canon == null)
				{
					goto IL_0244;
				}
				obj2 = _Canon + 72;
				bool flag2 = string.IsNullOrEmpty((string)obj2);
				bool flag3 = !flag2;
				state2 = null;
				if (flag3)
				{
					goto IL_031b;
				}
				bool flag4 = (object)_003C_003E4__this == null;
				state = null;
				if (!flag4)
				{
					((GillaFriends)flag2).Take((State)(object)_Canon, quick: false);
					bool flag5 = (byte)(~(quick ? 1u : 0u)) != 0;
					object obj3 = !flag5;
					if (obj3 != null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36 (System.__Canon)+3C]");
					if ((nint)0 < (nint)2)
					{
						return;
					}
					GillaFriends gillaFriends2 = _003C_003E4__this;
					bool flag6 = (object)_003C_003E4__this == null;
					nint num = unchecked((nint)null);
					state = (State)(object)_Canon;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36 (System.__Canon)+38]");
						object obj4 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36 (System.__Canon)+3C]");
						object obj5 = obj4 / 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36 (System.__Canon)+3C]");
						object obj6 = obj5 * 0;
						int page = obj4 - obj6;
						gillaFriends2.page = page;
						return;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			bool flag7 = (nint)state != 1;
			NullReferenceException ex2 = ex;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj8 = default;
				object obj7 = obj8;
				State state2 = (State)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj10 = default;
				object obj9 = obj10 & 1;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					goto IL_0244;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj11 = obj8;
				state = (State)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				nint num = unchecked((nint)null);
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_031b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v3+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v7+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v7+A0]");
			object obj17 = (nint)0 + (nint)40;
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
			IL_0244:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F10]");
			obj2 = 0;
			goto IL_031b;
		}

		internal void _003CLook_003Eb__1(string why)
		{
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I4
			//IL_00a7: Expected Obj, but got I
			//IL_0121: Expected Obj, but got I4
			//IL_0092: Expected Obj, but got I
			//IL_0147: Expected Obj, but got I
			//IL_0157: Expected Obj, but got I
			//IL_0179: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I
			//IL_01ea: Expected Obj, but got I4
			GillaFriends gillaFriends = _003C_003E4__this;
			gillaFriends.busy = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC750]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			bool flag = why.StartsWith((string)value);
			object obj2 = obj;
			bool flag2 = !flag;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			object obj5;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F28]");
				obj5 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F18]");
				obj5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F20]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v9+A0]");
			object obj11 = (nint)0 + (nint)40;
			obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string message = (string)obj8 + why;
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public Person p;

		internal bool _003CTake_003Eb__0(Person q)
		{
			//IL_0074: Expected I4, but got Obj
			if (q != null)
			{
				Person person = p;
				if (p != null)
				{
					return q.id == person.id;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_1
	{
		public Friend f;

		internal bool _003CTake_003Eb__1(Friend q)
		{
			//IL_0074: Expected I4, but got Obj
			if (q != null)
			{
				Friend friend = f;
				if (f != null)
				{
					return q.id == friend.id;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool _003CTake_003Eb__2(Person q)
		{
			//IL_0074: Expected I4, but got Obj
			if (q != null)
			{
				Friend friend = f;
				if (f != null)
				{
					return q.id == friend.id;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const float PresenceEvery = default(float);

	private const float LookEvery = default(float);

	private const float QuickEvery = default(float);

	private const float WatchedFor = default(float);

	private const float JoinGivesUp = default(float);

	private const string OfflineKey = null;

	private const string BlockedKey = null;

	private const string SeenKey = null;

	private static GillaFriends instance;

	private static HashSet<string> blocked;

	private static State now;

	public static State Preview;

	private static bool Heard__BackingField;

	private static string Problem__BackingField;

	private static string Said__BackingField;

	private static float SaidAt__BackingField;

	private bool busy;

	private bool wasWatched;

	private float nextLook;

	private float nextPresence;

	private float watchedAt;

	private float lastLookAt;

	private const float JustAsked = default(float);

	private static int Looks__BackingField;

	private static string LastNotice__BackingField;

	private readonly Queue<(string, string, string, bool?)> waiting;

	private string nameSaid;

	private int page;

	private string presenceSaid;

	private Friend joining;

	private NetworkBootstrap.Lobby fromKind;

	private string fromCode;

	private float joinAsked;

	public static State Now
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I4
			//IL_00e5: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I
			//IL_0117: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00d0: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v3+18]");
			State result = (State)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v3+18]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v9+A0]");
					obj4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v3+10]");
				result = (State)0;
			}
			return result;
		}
	}

	public static bool Heard
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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

	public static string Problem
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+28]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static string Said
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+30]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			object obj4 = (nint)0 + (nint)48;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static float SaidAt
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
			return 0f;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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

	public static bool Busy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			//IL_019a: Expected Obj, but got I
			//IL_01bc: Expected Obj, but got I4
			//IL_0090: Expected Obj, but got I4
			//IL_0158: Expected Obj, but got I
			//IL_0100: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj6 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v10+A0]");
				object obj10 = 0;
				object obj11 = obj10;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+20]");
					bool flag4 = (nint)0 == 0;
					return !flag4;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public static int Looks
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+3C]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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

	public static string LastNotice
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+40]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
			object obj4 = (nint)0 + (nint)64;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool Offline
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B50]");
			object key = 0;
			int num = PlayerPrefs.GetInt((string)key, 0);
			object obj = num - 1;
			return obj == null;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_01ea: Expected Obj, but got I4
			//IL_0059: Expected Obj, but got I
			//IL_0069: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I
			//IL_0235: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I
			//IL_00fc: Expected Obj, but got I
			//IL_011e: Expected Obj, but got I4
			//IL_0190: Expected Obj, but got I4
			//IL_0253: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool offline = Offline;
			if (offline == value)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B50]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			bool flag2 = !value;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			object what;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B58]");
				what = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B60]");
				what = 0;
			}
			PlayerPrefs.SetInt((string)key, value ? 1 : 0);
			PlayerPrefs.Save();
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Say((string)what);
			object obj9 = obj;
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v9+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj11 != null)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v16+A0]");
				object obj15 = 0;
				object obj16 = obj15;
				_ = 0;
			}
		}
	}

	public static int Unseen
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_024e: Expected Obj, but got I4
			//IL_0224: Expected I4, but got Obj
			//IL_00b1: Expected Obj, but got I4
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00c9: Expected Obj, but got I4
			//IL_00f9: Expected Obj, but got I
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0141: Expected Obj, but got I8
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected I8, but got Unknown
			//IL_01be: Expected Obj, but got I4
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long seen = Seen;
			State state = Now;
			int num;
			if (state != null)
			{
				News[] inbox = state.inbox;
				if (state.inbox != null)
				{
					if (inbox.Length >= 1)
					{
						object obj4 = ~inbox.Length;
						object obj5 = inbox.Length & obj4;
						object obj6 = 0;
						num = 0;
						while (inbox.Length != (nint)obj6)
						{
							object obj7 = (object)state.inbox + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X12_v5+20]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X12_v5+20]");
							if ((nint)0 == 0)
							{
								goto IL_0208;
							}
							obj6++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X12_v6+10]");
							object obj9 = -seen;
							bool flag2 = (nint)obj9 < 0;
							bool flag3 = obj9 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X12_v6+10]");
							long num2 = 0 ^ seen;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X12_v6+10]");
							object obj10 = 0 ^ obj9;
							long num3 = num2 & obj10;
							bool flag4 = num3 < 0;
							bool flag5 = flag2 == flag4;
							object obj11 = !flag3;
							object obj12 = flag5 & obj11;
							object obj13 = ~obj12;
							if (obj13 == null)
							{
								num++;
							}
							if (obj5 != obj6)
							{
								continue;
							}
							goto IL_027b;
						}
						goto IL_0216;
					}
					num = 0;
					goto IL_027b;
				}
			}
			goto IL_0208;
			IL_0208:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0216;
			IL_0216:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
			IL_027b:
			return num;
		}
	}

	private static long Seen
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_003b: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B68]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
			object defaultValue = 0;
			string s = PlayerPrefs.GetString((string)key, (string)defaultValue);
			bool flag = long.TryParse(s, out var result);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return result;
			}
			return 0L;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AB8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj5 = 0;
		obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		State state = default;
		state._002Ector();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+A0]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = state;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8+A0]");
		object obj12 = (nint)0 + (nint)24;
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v21+A0]");
		object obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v21+A0]");
		object obj18 = (nint)0 + (nint)40;
		obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+A0]");
		object obj21 = (nint)0 + (nint)48;
		obj21 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v33+E4]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v33+A0]");
		object obj24 = 0;
		_ = 3267887104L;
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AD8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AE0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+A0]");
		object obj10 = 0;
		object obj11 = default;
		obj10 = obj11;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static void LoadBlocked()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_01fe: Expected I4, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D8]");
		object obj7 = 0;
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v8+A0]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AE8]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object defaultValue = 0;
		string text = PlayerPrefs.GetString((string)key, (string)defaultValue);
		if (text != null)
		{
			string[] array = text.Split(',', (StringSplitOptions)0);
			if (array != null)
			{
				object obj11 = array.Length;
				if (array.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
				object obj12 = 0;
				object obj13 = 0;
				StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
				char c = ',';
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
					object obj14 = !flag4;
					if (obj14 != null)
					{
						break;
					}
					object obj15 = (object)array + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v18+20]");
					System.__Canon _Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v18+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v6 (System.__Canon)+10]");
						if ((nint)0 >= (nint)1)
						{
							object obj16 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v22+E4]");
							bool flag5 = (nint)0 == 0;
							object obj17 = !flag5;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj16 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v22+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v23+8]");
							if ((nint)0 == 0)
							{
								goto IL_026b;
							}
							stringSplitOptions = (StringSplitOptions)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v23+8]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v18+20]");
							bool flag6 = ((HashSet<System.__Canon>)num).Add((System.__Canon)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v18+20]");
							c = '\0';
						}
						obj11 = array.Length;
						obj13++;
						if ((nint)obj13 >= array.Length)
						{
							return;
						}
						continue;
					}
					goto IL_026b;
				}
				goto IL_0279;
			}
		}
		goto IL_026b;
		IL_026b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0279;
		IL_0279:
		throw new IndexOutOfRangeException();
	}

	private static void SaveBlocked()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
		object separator = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AE8]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
		string value = string.Join((string)separator, (IEnumerable<string>)0);
		PlayerPrefs.SetString((string)key, value);
		PlayerPrefs.Save();
	}

	public static bool IsBlocked(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_025d: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_018b: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (string.IsNullOrEmpty((string)obj3))
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v5+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v17+18]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v17+18]");
					if ((nint)0 == 0)
					{
						goto IL_024f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B00]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B08]");
				object obj13 = 0;
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector(obj2, (IntPtr)obj13);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+28]");
				return Array.Exists((System.__Canon[])0, predicate);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			LoadBlocked();
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v7+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+8]");
				return ((HashSet<System.__Canon>)0).Contains((System.__Canon)obj3);
			}
		}
		goto IL_024f;
		IL_024f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsFriend(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011c: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			State state = Now;
			if (state != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B20]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector(obj2, (IntPtr)obj8);
				return Array.Exists((System.__Canon[])(object)state.friends, predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool AsksYou(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011c: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			State state = Now;
			if (state != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B00]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B38]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector(obj2, (IntPtr)obj8);
				return Array.Exists((System.__Canon[])(object)state.asking, predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool YouAsked(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011c: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			State state = Now;
			if (state != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B00]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B48]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Predicate<System.__Canon> predicate = default;
				predicate._002Ector(obj2, (IntPtr)obj8);
				return Array.Exists((System.__Canon[])(object)state.asked, predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static void MarkSeen()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_016c: Expected I8, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I4
		//IL_01b9: Expected I8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long seen = Seen;
		State state = Now;
		News[] inbox = state.inbox;
		if (state.inbox == null)
		{
			goto IL_026d;
		}
		object obj4 = inbox.Length;
		bool flag2 = inbox.Length < 1;
		long num = seen;
		if (flag2)
		{
			goto IL_01c7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj7 = default;
		object obj6 = obj7;
		long num3 = default;
		long num2 = num3;
		object obj8 = 0;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
			object obj9 = !flag3;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = (object)state.inbox + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+20]");
			if ((nint)0 != 0)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v23+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v16+10]");
				long num4 = Math.Max(seen, 0L);
				obj4 = inbox.Length;
				obj8++;
				bool flag5 = (nint)obj8 < inbox.Length;
				num = num4;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v16+10]");
				num2 = 0L;
				if (flag5)
				{
					continue;
				}
				goto IL_01c7;
			}
			goto IL_026d;
		}
		goto IL_027b;
		IL_027b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_026d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_027b;
		IL_01c7:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long seen2 = Seen;
		if (num != seen2)
		{
			long num5 = default;
			string value = num5.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B68]");
			object key = 0;
			PlayerPrefs.SetString((string)key, value);
			PlayerPrefs.Save();
		}
	}

	public static string Line(News news)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I
		object obj4;
		object obj6;
		object obj9;
		if (news != null)
		{
			object obj = news + 40;
			bool flag = string.IsNullOrEmpty((string)obj);
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
			string text = (string)0;
			object obj2 = !flag2;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BE8]");
				obj4 = 0;
			}
			else
			{
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
			if ((nint)0 != 0)
			{
				if (text._stringLength > 7)
				{
					if (text._stringLength != 10)
					{
						if (text._stringLength == 12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BB0]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
							if ((string)0 == (string)obj5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BD8]");
								obj6 = 0;
								goto IL_053f;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
						char c = ((string)0).get_Chars(3);
						int num = c & 0xFFFF;
						if (num != 98)
						{
							if (num != 99)
							{
								if (num == 117)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B88]");
									object obj7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
									if ((string)0 == (string)obj7)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B70]");
										obj6 = 0;
										goto IL_053f;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B78]");
								object obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
								if ((string)0 == (string)obj8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BD0]");
									obj9 = 0;
									goto IL_052a;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BC0]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
							if ((string)0 == (string)obj10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B98]");
								obj6 = 0;
								goto IL_053f;
							}
						}
					}
				}
				else if (text._stringLength != 5)
				{
					if (text._stringLength == 7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
						char c2 = ((string)0).get_Chars(0);
						int num2 = c2 & 0xFFFF;
						if (num2 != 102)
						{
							if (num2 == 117)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BB8]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
								if ((string)0 == (string)obj11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BE0]");
									obj9 = 0;
									goto IL_052a;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BA0]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
							if ((string)0 == (string)obj12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BC8]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BA8]");
								object obj14 = 0;
								return (string)obj13 + (string)obj4 + (string)obj14;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B90]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X19_v2-10]");
					if ((string)0 == (string)obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B80]");
						obj9 = 0;
						goto IL_052a;
					}
				}
			}
			return (string)obj4;
		}
		return (string)(object)new NullReferenceException();
		IL_053f:
		string text2 = (string)obj6;
		string text3 = (string)obj4;
		goto IL_0514;
		IL_0514:
		return text2 + text3;
		IL_052a:
		text3 = (string)obj9;
		text2 = (string)obj4;
		goto IL_0514;
	}

	public static string Where(Friend f)
	{
		//IL_01ce: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected I4, but got Unknown
		//IL_012a: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I
		if (f != null)
		{
			if (~(f.on ? 1u : 0u) == 0)
			{
				if (string.IsNullOrEmpty(f.code))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BF0]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = f.kind - 2;
				bool flag = (nint)obj3 < 0;
				int num = f.kind ^ 2;
				int num2 = f.kind ^ obj3;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				bool flag3 = flag == flag2;
				object obj4 = !flag3;
				object obj5 = ~obj4;
				int num4 = ((obj5 != null) ? 2 : f.kind);
				int num5 = ~num4;
				NetworkBootstrap.Lobby kind = (NetworkBootstrap.Lobby)(num4 & num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = NetworkBootstrap.LabelOf(kind);
				string text2 = NetworkBootstrap.Shown(f.code);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
				object obj7 = 0;
				return text + (string)obj7 + text2;
			}
			if (~(f.known ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
			return (string)0;
		}
		return (string)(object)new NullReferenceException();
	}

	private static void Say(string what)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
		object obj6 = (nint)0 + (nint)48;
		obj6 = what;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v13+A0]");
		object obj9 = 0;
	}

	public static void Watched()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+A0]");
			object obj11 = 0;
			object obj12 = obj11;
			float unscaledTime = Time.unscaledTime;
		}
	}

	public static void Refresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+A0]");
			object obj10 = 0;
			object obj11 = obj10;
			_ = 0;
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I4
		//IL_03d2: Expected Obj, but got I
		//IL_00c0: Invalid comparison between F4 and I4
		//IL_0340: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_0275: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			float unscaledTime = Time.unscaledTime;
			string real = GillaName.Real;
			if (real != nameSaid)
			{
				SaveName();
			}
			float num = unscaledTime - watchedAt;
			float num2 = num - 2f;
			bool flag3 = num2 < 0f;
			if ((double)num < 2.0)
			{
				bool flag4 = (byte)(~(wasWatched ? 1u : 0u)) != 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					float num3 = unscaledTime - lastLookAt;
					if ((double)num3 > 5.0)
					{
						nextLook = 0f;
					}
				}
			}
			wasWatched = flag3;
			bool flag5 = (byte)(~(busy ? 1u : 0u)) != 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Queue<(System.__Canon, System.__Canon, System.__Canon, bool?)> queue = (Queue<(System.__Canon, System.__Canon, System.__Canon, bool?)>)(object)waiting;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v29 (System.Collections.Generic.Queue`1<System.ValueTuple`4<System.__Canon, System.__Canon, System.__Canon, System.Nullable`1<System.Boolean>>>)+20]");
				if ((nint)0 >= (nint)1)
				{
					(System.__Canon, System.__Canon, System.__Canon, bool?) tuple = queue.Dequeue();
					string function = default;
					string id = default;
					string text = default;
					bool? yes = default;
					Send(function, id, text, yes);
				}
				else if (!(unscaledTime < nextLook))
				{
					float num4 = num - 2f;
					bool flag6 = num4 < 0f;
					bool quick = !flag6;
					Look(quick);
				}
			}
			Presence(unscaledTime);
			Joins(unscaledTime);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3E0]");
			object obj12 = 0;
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v11+E4]");
			bool flag8 = (nint)0 == 0;
			object obj14 = !flag8;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v11+A0]");
			object obj15 = (nint)0 + (nint)40;
			obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Look(bool quick)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got I
		//IL_00ff: Expected F8, but got I4
		//IL_0384: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_0255: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		busy = true;
		float unscaledTime = Time.unscaledTime;
		object obj5 = obj3;
		lastLookAt = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v15+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v9+3C]");
		object obj10 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v15+A0]");
		object obj13 = 0;
		float unscaledTime2 = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		double num = (((nint)0 != 0) ? 1123024896.0 : 20.0);
		float num2 = unscaledTime2 + (float)num;
		nextLook = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C88]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C70]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C78]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj20 = 0;
		System.__Canon _Canon = (System.__Canon)obj15;
		object obj21 = obj16;
		System.__Canon _Canon2 = default;
		dictionary.Add((System.__Canon)obj15, _Canon2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		bool flag4 = (nint)0 == 0;
		System.__Canon _Canon3 = _Canon2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C80]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			_Canon = (System.__Canon)obj22;
			obj21 = obj23;
			System.__Canon _Canon4 = default;
			dictionary.set_Item((System.__Canon)obj22, _Canon4);
			_Canon3 = _Canon4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C90]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj19);
		object obj24 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCloud.Run((string)function, (Dictionary<string, object>)(object)dictionary, (Action<string>)action, (Action<string>)action2);
	}

	private unsafe void Take(State s, bool quick)
	{
		//IL_0010: Expected Obj, but got I
		//IL_14ce: Expected Obj, but got I4
		//IL_1506: Expected Obj, but got I4
		//IL_1a19: Expected Obj, but got I
		//IL_0a42: Expected Obj, but got I
		//IL_0a52: Expected Obj, but got I
		//IL_0a9c: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_1826: Expected Obj, but got I
		//IL_1836: Expected Obj, but got I
		//IL_1536: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_0ad1: Expected Obj, but got I
		//IL_0b13: Expected Obj, but got I
		//IL_0b35: Expected Obj, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_1881: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_0e17: Expected Obj, but got I
		//IL_0e27: Expected Obj, but got I
		//IL_0e37: Expected Obj, but got I
		//IL_0e47: Expected Obj, but got I
		//IL_0e6d: Expected Obj, but got I4
		//IL_0e7d: Expected I4, but got Obj
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected Obj, but got Unknown
		//IL_0bc8: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I4
		//IL_1630: Expected Obj, but got I
		//IL_165e: Expected Obj, but got I4
		//IL_18b1: Expected Obj, but got I4
		//IL_1215: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I
		//IL_0594: Expected Obj, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I4
		//IL_191f: Expected Obj, but got I
		//IL_0e9d: Expected Obj, but got I4
		//IL_0cff: Expected Obj, but got I
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_0d2e: Expected Obj, but got I4
		//IL_17ce: Expected Obj, but got I
		//IL_17fc: Expected Obj, but got I4
		//IL_1960: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_1a56: Expected Obj, but got I
		//IL_0ecf: Expected Obj, but got I
		//IL_155c: Expected Obj, but got I
		//IL_156c: Expected Obj, but got I
		//IL_1990: Expected Obj, but got I4
		//IL_0cb1: Expected I, but got Obj
		//IL_0cd2: Expected Obj, but got I
		//IL_0cd2: Expected Obj, but got I
		//IL_0ce2: Expected Obj, but got I
		//IL_1a77: Expected Obj, but got I
		//IL_1aa6: Expected Obj, but got I
		//IL_0f46: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_02e3: Expected I, but got Obj
		//IL_117e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected Obj, but got Unknown
		//IL_11a2: Expected Obj, but got I4
		//IL_1688: Expected Obj, but got I
		//IL_1698: Expected Obj, but got I
		//IL_02f0: Expected I4, but got Obj
		//IL_0305: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_1281: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_04bb: Expected I, but got Obj
		//IL_04c8: Expected I, but got Obj
		//IL_06d3: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_06fe: Expected I, but got Obj
		//IL_0362: Expected I, but got Obj
		//IL_0fa9: Expected I, but got Obj
		//IL_0fc2: Expected Obj, but got I
		//IL_0fed: Expected Obj, but got I
		//IL_070b: Expected I4, but got Obj
		//IL_0720: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_074b: Expected I, but got Obj
		//IL_145d: Expected Obj, but got I4
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09dd: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I4
		//IL_12f8: Expected Obj, but got I4
		//IL_1024: Expected I, but got Obj
		//IL_103c: Expected Obj, but got I
		//IL_078b: Expected Obj, but got I4
		//IL_15d6: Expected Obj, but got I
		//IL_1612: Expected Obj, but got I4
		//IL_19e4: Expected Obj, but got I4
		//IL_1702: Expected Obj, but got I
		//IL_1712: Expected Obj, but got I
		//IL_173b: Expected I, but got Obj
		//IL_044b: Expected Obj, but got I
		//IL_03f6: Expected I, but got Obj
		//IL_1079: Expected Obj, but got I
		//IL_1322: Expected Obj, but got I
		//IL_1344: Expected Obj, but got I4
		//IL_10f9: Expected Obj, but got I4
		//IL_07c0: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I
		//IL_07ea: Expected Obj, but got I
		//IL_07fb: Expected I, but got Obj
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_108f: Expected I, but got Obj
		//IL_109f: Expected Obj, but got I
		//IL_10d0: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I
		//IL_0818: Expected I4, but got Obj
		//IL_082d: Expected Obj, but got I
		//IL_084d: Expected I, but got Obj
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_1379: Expected Obj, but got I
		//IL_088c: Expected I, but got Obj
		//IL_13b6: Expected Obj, but got I
		//IL_13be: Expected I4, but got Obj
		//IL_13db: Expected Obj, but got I
		//IL_13db: Expected Obj, but got I
		//IL_13f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Expected Obj, but got Unknown
		//IL_1415: Expected I4, but got Obj
		//IL_1425: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I4
		//IL_1771: Expected Obj, but got I
		//IL_17b0: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I
		//IL_099f: Expected I, but got Obj
		//IL_09a7: Expected I4, but got Obj
		//IL_0930: Expected I, but got Obj
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v49+20]");
		bool flag3 = (nint)0 == 0;
		State state = s;
		System.__Canon value;
		object obj12;
		Person[] asking;
		object obj11;
		Friend[] array = default;
		System.__Canon[] array3 = default;
		nint num;
		nint num2 = default;
		bool flag11 = default;
		State state2;
		Predicate<System.__Canon> predicate2 = default;
		object obj10;
		bool flag9;
		bool flag10;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v105+A0]");
				obj6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v49+18]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			state = s;
			if (obj9 == null)
			{
				bool flag6 = s == null;
				value = null;
				state = s;
				state2 = s;
				if (!flag6)
				{
					asking = s.asking;
					bool flag7 = s.asking == null;
					value = null;
					state = s;
					state2 = s;
					if (!flag7)
					{
						bool flag8 = asking.Length < 1;
						obj10 = !flag8;
						flag9 = asking.Length < 1;
						state = s;
						if (flag9)
						{
							goto IL_04f6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CF8]");
						array = (Friend[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AF8]");
						obj11 = 0;
						obj12 = s.asking + 32;
						Predicate<System.__Canon> predicate = predicate2;
						num = num2;
						flag10 = flag11;
						System.__Canon[] array2 = array3;
						State state3 = s;
						object obj13 = 0;
						bool flag12 = flag9;
						object obj15 = default;
						Predicate<System.__Canon> predicate3 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D00]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							obj15._002Ector();
							bool flag13 = (nint)obj13 < asking.Length;
							obj10 = !flag13;
							State state4 = null;
							if (obj10 != null)
							{
								break;
							}
							bool flag14 = obj15 == null;
							value = null;
							predicate2 = predicate;
							num2 = num;
							flag11 = flag10;
							array3 = array2;
							state = null;
							flag9 = flag12;
							state2 = s;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+v293 @ X26_v15*8]");
								state = (State)0;
								object obj16 = obj15 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+v293 @ X26_v15*8]");
								obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj17 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v111+E4]");
								bool flag15 = (nint)0 == 0;
								object obj18 = !flag15;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj17 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v111+A0]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v88+10]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v88+10]");
								bool flag16 = (nint)0 == 0;
								value = null;
								predicate2 = predicate;
								num2 = num;
								flag11 = flag10;
								array3 = array2;
								flag9 = flag12;
								state2 = s;
								if (!flag16)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v89+18]");
									array3 = (System.__Canon[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B00]");
									object obj21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									predicate3._002Ector(obj15, (IntPtr)array);
									flag11 = (byte)(int)obj11 != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v89+18]");
									bool flag17 = Array.Exists((System.__Canon[])0, predicate3);
									bool flag18 = !flag17;
									object obj22 = !flag18;
									state = (State)(object)predicate3;
									if (obj22 == null)
									{
										object obj23 = obj16;
										bool flag19 = obj16 == null;
										value = null;
										predicate2 = predicate3;
										num2 = unchecked((nint)null);
										state = (State)(object)predicate3;
										flag9 = flag12;
										state2 = s;
										if (flag19)
										{
											goto IL_11e0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v94+18]");
										bool flag20 = string.IsNullOrEmpty((string)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BE8]");
										object obj24 = 0;
										bool flag21 = !flag20;
										object obj25 = !flag21;
										if (obj25 == null)
										{
											bool flag22 = obj16 == null;
											value = null;
											predicate2 = predicate3;
											num2 = unchecked((nint)null);
											state = null;
											flag9 = flag12;
											state2 = s;
											if (flag22)
											{
												goto IL_11e0;
											}
											obj24 = obj16 + 24;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B80]");
										object obj26 = 0;
										string title = (string)obj24 + (string)obj26;
										object obj27 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v100+E4]");
										bool flag23 = (nint)0 == 0;
										object obj28 = !flag23;
										if (obj28 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D20]");
										object obj29 = 0;
										Notice(title, (string)obj29);
										flag11 = false;
										state = (State)obj29;
									}
									obj13++;
									bool flag24 = (nint)obj13 < asking.Length;
									obj10 = !flag24;
									flag9 = (nint)obj13 < asking.Length;
									predicate2 = predicate3;
									num2 = unchecked((nint)null);
									predicate = predicate3;
									num = unchecked((nint)null);
									flag10 = flag11;
									array2 = array3;
									state3 = state;
									flag12 = flag9;
									if (flag9)
									{
										continue;
									}
									goto IL_04f6;
								}
							}
							goto IL_11e0;
						}
						goto IL_1480;
					}
				}
				goto IL_11e0;
			}
		}
		goto IL_0a32;
		IL_148e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_04f6:
		asking = (Person[])(object)s.friends;
		bool flag25 = s.friends == null;
		value = null;
		state2 = s;
		if (flag25)
		{
			goto IL_11e0;
		}
		bool flag26 = asking.Length < 1;
		obj10 = !flag26;
		flag9 = asking.Length < 1;
		if (flag9)
		{
			goto IL_0a32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D08]");
		array = (Friend[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B18]");
		obj11 = 0;
		obj12 = s.friends + 32;
		Predicate<System.__Canon> predicate4 = predicate2;
		num = num2;
		flag10 = flag11;
		System.__Canon[] array4 = array3;
		State state5 = state;
		object obj30 = 0;
		bool flag27 = flag9;
		object obj32 = default;
		Predicate<System.__Canon> predicate5 = default;
		Predicate<System.__Canon> predicate6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D18]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj32._002Ector();
			bool flag28 = (nint)obj30 < asking.Length;
			obj10 = !flag28;
			State state4 = null;
			if (obj10 != null)
			{
				break;
			}
			bool flag29 = obj32 == null;
			value = null;
			predicate2 = predicate4;
			num2 = num;
			flag11 = flag10;
			array3 = array4;
			state = null;
			flag9 = flag27;
			state2 = s;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+v294 @ X26_v12*8]");
				state = (State)0;
				object obj33 = obj32 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+v294 @ X26_v12*8]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj34 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v81+E4]");
				bool flag30 = (nint)0 == 0;
				object obj35 = !flag30;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj34 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v81+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v59+10]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v59+10]");
				bool flag31 = (nint)0 == 0;
				value = null;
				predicate2 = predicate4;
				num2 = num;
				flag11 = flag10;
				array3 = array4;
				flag9 = flag27;
				state2 = s;
				if (!flag31)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v60+10]");
					array3 = (System.__Canon[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B20]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					predicate5._002Ector(obj32, (IntPtr)array);
					flag11 = (byte)(int)obj11 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v60+10]");
					bool flag32 = Array.Exists((System.__Canon[])0, predicate5);
					bool flag33 = !flag32;
					object obj39 = !flag33;
					predicate2 = predicate5;
					num2 = unchecked((nint)null);
					state = (State)(object)predicate5;
					if (obj39 == null)
					{
						object obj40 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v88+E4]");
						bool flag34 = (nint)0 == 0;
						object obj41 = !flag34;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj40 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v88+A0]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v66+10]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v66+10]");
						bool flag35 = (nint)0 == 0;
						value = null;
						predicate2 = predicate5;
						num2 = unchecked((nint)null);
						state = (State)(object)predicate5;
						flag9 = flag27;
						state2 = s;
						if (flag35)
						{
							goto IL_11e0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v67+20]");
						array3 = (System.__Canon[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B00]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D10]");
						object obj45 = 0;
						predicate6._002Ector(obj32, (IntPtr)obj45);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AF8]");
						object obj46 = 0;
						flag11 = (byte)(int)obj46 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v67+20]");
						bool flag36 = Array.Exists((System.__Canon[])0, predicate6);
						bool flag37 = !flag36;
						predicate2 = predicate6;
						num2 = unchecked((nint)null);
						state = (State)(object)predicate6;
						if (!flag37)
						{
							object obj47 = obj33;
							bool flag38 = obj33 == null;
							value = null;
							predicate2 = predicate6;
							num2 = unchecked((nint)null);
							state = (State)(object)predicate6;
							flag9 = flag27;
							state2 = s;
							if (flag38)
							{
								goto IL_11e0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v74+18]");
							bool flag39 = string.IsNullOrEmpty((string)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BC8]");
							object obj48 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB688]");
							object obj49 = 0;
							bool flag40 = !flag39;
							object obj50 = !flag40;
							if (obj50 == null)
							{
								bool flag41 = obj33 == null;
								value = null;
								predicate2 = predicate6;
								num2 = unchecked((nint)null);
								state = null;
								flag9 = flag27;
								state2 = s;
								if (flag41)
								{
									goto IL_11e0;
								}
								obj49 = obj33 + 24;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BA8]");
							object obj51 = 0;
							string title2 = (string)obj48 + (string)obj49 + (string)obj51;
							object obj52 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v79+E4]");
							bool flag42 = (nint)0 == 0;
							object obj53 = !flag42;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D28]");
							object obj54 = 0;
							Notice(title2, (string)obj54);
							predicate2 = predicate6;
							num2 = unchecked((nint)null);
							flag11 = (byte)(int)obj51 != 0;
							state = (State)obj54;
						}
					}
					obj30++;
					bool flag43 = (nint)obj30 < asking.Length;
					obj10 = !flag43;
					flag9 = (nint)obj30 < asking.Length;
					predicate4 = predicate2;
					num = num2;
					flag10 = flag11;
					array4 = array3;
					state5 = state;
					flag27 = flag9;
					if (flag9)
					{
						continue;
					}
					goto IL_0a32;
				}
			}
			goto IL_11e0;
		}
		goto IL_1480;
		IL_1480:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_148e;
		IL_11e0:
		throw new NullReferenceException();
		IL_0da1:
		bool flag44 = s == null;
		value = null;
		state2 = s;
		Dictionary<System.__Canon, System.__Canon> dictionary;
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		if (!flag44)
		{
			Friend[] friends = s.friends;
			bool flag45 = s.friends == null;
			value = null;
			state2 = s;
			if (!flag45)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CD8]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				asking = (Person[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C0]");
				predicate2 = (Predicate<System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
				array3 = (System.__Canon[])0;
				value = null;
				num = num2;
				flag10 = flag11;
				State state4 = state;
				object obj56 = 0;
				Friend[] array5 = array;
				bool flag46 = (byte)(int)dictionary != 0;
				while (true)
				{
					bool flag47 = (nint)obj56 < friends.Length;
					obj10 = !flag47;
					flag9 = (nint)obj56 >= friends.Length;
					num2 = num;
					flag11 = flag10;
					state = state4;
					obj11 = obj56;
					array = array5;
					state2 = s;
					if (!flag9)
					{
						bool flag48 = (nint)obj56 < friends.Length;
						obj10 = !flag48;
						if (obj10 != null)
						{
							break;
						}
						object obj57 = (object)friends + obj56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v38+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v38+20]");
						bool flag49 = (nint)0 == 0;
						num2 = num;
						flag11 = flag10;
						state = state4;
						obj11 = obj56;
						array = array5;
						state2 = s;
						if (!flag49)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+29]");
							bool flag50 = (nint)0 == 0;
							object obj59 = !flag50;
							if (obj59 == null)
							{
								bool flag51 = dictionary2 == null;
								num2 = num;
								flag11 = flag10;
								state = state4;
								obj11 = obj56;
								array = array5;
								state2 = s;
								if (flag51)
								{
									goto IL_11e0;
								}
								num = (nint)obj55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+10]");
								flag46 = dictionary2.TryGetValue((System.__Canon)0, out value);
								bool flag52 = !flag46;
								flag10 = (byte)(&value) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+10]");
								state4 = (State)0;
								if (!flag52)
								{
									array = s.friends;
									bool flag53 = s.friends == null;
									num2 = (nint)obj55;
									flag11 = (byte)(&value) != 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+10]");
									state = (State)0;
									obj11 = obj56;
									state2 = s;
									if (flag53)
									{
										goto IL_11e0;
									}
									bool flag54 = value == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v39+10]");
									State state6 = (State)0;
									if (!flag54)
									{
										nint num3 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v44 (Il2CppClass<Friend[]>)+40]");
										state6 = (State)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag55 = ex == null;
										flag10 = (byte)(&value) != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v44 (Il2CppClass<Friend[]>)+40]");
										state4 = (State)0;
										if (flag55)
										{
											goto IL_148e;
										}
									}
									bool flag56 = (nint)obj56 < array.Length;
									obj10 = !flag56;
									flag10 = (byte)(&value) != 0;
									state4 = state6;
									if (obj10 != null)
									{
										break;
									}
									object obj60 = (object)array + obj56;
									object obj61 = obj60 + 32;
									obj61 = value;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									flag10 = (byte)(&value) != 0;
									state4 = (State)(object)value;
									array5 = array;
								}
							}
							friends = s.friends;
							obj11 = obj56 + 1;
							bool flag57 = s.friends == null;
							object obj62 = !flag57;
							num2 = num;
							flag11 = flag10;
							state = state4;
							array = array5;
							state2 = s;
							obj56 = obj11;
							if (obj62 != null)
							{
								continue;
							}
						}
					}
					else
					{
						object obj63 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v14+E4]");
						bool flag58 = (nint)0 == 0;
						object obj64 = !flag58;
						if (obj64 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj63 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v14+A0]");
						object obj65 = (nint)0 + (nint)16;
						obj65 = state2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj66 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v22+E4]");
						bool flag59 = (nint)0 == 0;
						object obj67 = !flag59;
						if (obj67 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj66 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v22+A0]");
						object obj68 = 0;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v22+E4]");
						bool flag60 = (nint)0 == 0;
						object obj69 = !flag60;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj66 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v22+A0]");
						object obj70 = (nint)0 + (nint)40;
						obj70 = asking;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						LoadBlocked();
						object obj71 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v17+A0]");
						object obj72 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v18+8]");
						bool flag61 = (nint)0 == 0;
						state = (State)(object)asking;
						if (!flag61)
						{
							state = (State)(object)predicate2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v18+8]");
							((HashSet<System.__Canon>)0).Clear();
							state2 = (State)(object)state2.blocked;
							if (state2.blocked != null)
							{
								Person[] asking2 = state2.asking;
								flag9 = (nint)state2.asking < 1;
								System.__Canon _Canon = (System.__Canon)(object)predicate2;
								if (!flag9)
								{
									flag10 = flag11;
									object obj73 = 0;
									while (true)
									{
										bool flag62 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj73) < System.Runtime.CompilerServices.Unsafe.As<Person[], UIntPtr>(ref asking2);
										obj10 = !flag62;
										num = num2;
										state4 = state;
										if (obj10 != null)
										{
											break;
										}
										object obj74 = obj;
										object obj75 = (object)state2 + obj73;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+20]");
										object obj76 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v33+E4]");
										bool flag63 = (nint)0 == 0;
										object obj77 = !flag63;
										if (obj77 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj74 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v23+20]");
										bool flag64 = (nint)0 == 0;
										flag11 = flag10;
										if (!flag64)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v33+A0]");
											object obj78 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v24+8]");
											bool flag65 = (nint)0 == 0;
											flag11 = flag10;
											if (!flag65)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X22_v8+10]");
												_Canon = (System.__Canon)0;
												flag11 = (byte)(int)array3 != 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v24+8]");
												nint num4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X22_v8+10]");
												bool flag66 = ((HashSet<System.__Canon>)num4).Add((System.__Canon)0);
												asking2 = state2.asking;
												obj73++;
												object obj79 = obj73;
												Person[] asking3 = state2.asking;
												flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj79) < System.Runtime.CompilerServices.Unsafe.As<Person[], UIntPtr>(ref asking3);
												flag10 = (byte)(int)array3 != 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X22_v8+10]");
												state = (State)0;
												if (flag9)
												{
													continue;
												}
												goto IL_1433;
											}
										}
										goto IL_11e0;
									}
									break;
								}
								goto IL_1433;
							}
						}
					}
					goto IL_11e0;
					IL_1433:
					object obj80 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v29+E4]");
					bool flag67 = (nint)0 == 0;
					object obj81 = !flag67;
					if (obj81 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					SaveBlocked();
					return;
				}
				goto IL_1480;
			}
		}
		goto IL_11e0;
		IL_0a32:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CF0]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CE0]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		state = (State)obj83;
		dictionary2._002Ector();
		dictionary = (Dictionary<System.__Canon, System.__Canon>)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v57 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>)+E4]");
		bool flag68 = (nint)0 == 0;
		object obj84 = !flag68;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			dictionary = (Dictionary<System.__Canon, System.__Canon>)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v57 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>)+A0]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v32+10]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v32+10]");
		bool flag69 = (nint)0 == 0;
		value = null;
		state2 = s;
		if (!flag69)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v33+10]");
			System.__Canon _Canon2 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v33+10]");
			bool flag70 = (nint)0 == 0;
			value = null;
			state2 = s;
			if (!flag70)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
				object obj87 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
				bool flag71 = (nint)0 < (nint)1;
				obj10 = !flag71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
				flag9 = (nint)0 < (nint)1;
				if (flag9)
				{
					goto IL_0da1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CE8]");
				array3 = (System.__Canon[])0;
				Predicate<System.__Canon> predicate7 = null;
				num = num2;
				flag10 = flag11;
				State state4 = state;
				bool flag72 = flag9;
				Dictionary<System.__Canon, System.__Canon> dictionary3 = dictionary;
				while (true)
				{
					bool flag73 = System.Runtime.CompilerServices.Unsafe.As<Predicate<System.__Canon>, UIntPtr>(ref predicate7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj87);
					obj10 = !flag73;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v33+10]");
					object obj88 = 0 + predicate7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
					System.__Canon _Canon3 = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
					bool flag74 = (nint)0 == 0;
					value = null;
					predicate2 = predicate7;
					num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
					flag11 = false;
					state = state4;
					flag9 = flag72;
					state2 = s;
					if (!flag74)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X2_v14 (System.__Canon)+29]");
						if ((nint)0 != 0)
						{
							bool flag75 = dictionary2 == null;
							value = null;
							predicate2 = predicate7;
							num2 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
							flag11 = false;
							state = state4;
							flag9 = flag72;
							state2 = s;
							if (flag75)
							{
								goto IL_11e0;
							}
							num = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X2_v14 (System.__Canon)+10]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
							dictionary2.set_Item((System.__Canon)num5, (System.__Canon)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X2_v14 (System.__Canon)+10]");
							state4 = (State)0;
							dictionary3 = dictionary2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
						obj87 = 0;
						predicate2 = (Predicate<System.__Canon>)(predicate7 + 1);
						Predicate<System.__Canon> predicate8 = predicate2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
						bool flag76 = (nint)predicate8 < 0;
						obj10 = !flag76;
						Predicate<System.__Canon> predicate9 = predicate2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X22_v13 (System.__Canon)+18]");
						flag9 = (nint)predicate9 < 0;
						num2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
						flag11 = false;
						state = state4;
						dictionary = dictionary3;
						predicate7 = predicate2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v46+20]");
						flag10 = false;
						flag72 = flag9;
						if (flag9)
						{
							continue;
						}
						goto IL_0da1;
					}
					goto IL_11e0;
				}
				goto IL_1480;
			}
		}
		goto IL_11e0;
	}

	private void SaveName()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00d2: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I
		//IL_04d6: Expected I, but got Obj
		//IL_04e7: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_0528: Expected I4, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I4
		//IL_0584: Expected I, but got Obj
		//IL_0701: Expected Obj, but got I4
		//IL_0622: Expected Obj, but got I
		//IL_0632: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_03b5: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I
		//IL_05cc: Expected I, but got Obj
		//IL_05dd: Expected I, but got Obj
		//IL_05fb: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I
		//IL_067c: Expected Obj, but got I
		//IL_0684: Expected I, but got Obj
		//IL_0695: Expected I, but got Obj
		//IL_06b3: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj2 = 0;
		string real = GillaName.Real;
		object obj3 = this + 64;
		obj3 = real;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserDataRequest updateUserDataRequest = default;
		updateUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C38]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
		object obj4 = 0;
		object obj5 = obj4;
		dictionary.Add((System.__Canon)key, (System.__Canon)(object)real);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C30]");
		object obj7 = 0;
		object obj8 = updateUserDataRequest + 32;
		obj8 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		nint num = (nint)obj6;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
		object obj9 = obj7;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v18+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v18+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C08]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v30+8]");
		Action<UpdateUserDataResult> resultCallback = (Action<UpdateUserDataResult>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v30+8]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v34+A0]");
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E48]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C18]");
			object obj19 = 0;
			num = (nint)obj19;
			Action<System.__Canon> action = default;
			action._002Ector(obj11, (IntPtr)obj19);
			object obj20 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v33+A0]");
			object obj21 = (nint)0 + (nint)8;
			obj21 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = 0;
			_Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)action;
			resultCallback = (Action<UpdateUserDataResult>)action;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC328]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj13);
		object obj23 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v22+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserData(updateUserDataRequest, resultCallback, (Action<PlayFabError>)action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest = default;
		updateUserTitleDisplayNameRequest._002Ector();
		object obj25 = updateUserTitleDisplayNameRequest + 32;
		obj25 = real;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj26 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+E4]");
		bool flag5 = (nint)0 == 0;
		object obj27 = !flag5;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v24+10]");
		Action<UpdateUserTitleDisplayNameResult> resultCallback2 = (Action<UpdateUserTitleDisplayNameResult>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v24+10]");
		bool flag6 = (nint)0 == 0;
		object obj29 = !flag6;
		object obj30 = null;
		nint num2 = (nint)action2;
		string text = real;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+E4]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v28+A0]");
				obj28 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC308]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C20]");
			object obj34 = 0;
			num2 = (nint)obj34;
			Action<System.__Canon> action3 = default;
			action3._002Ector(obj28, (IntPtr)obj34);
			object obj35 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v27+A0]");
			object obj36 = (nint)0 + (nint)16;
			obj36 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj26 = obj7;
			obj30 = null;
			text = (string)(object)action3;
			resultCallback2 = (Action<UpdateUserTitleDisplayNameResult>)action3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+E4]");
		bool flag8 = (nint)0 == 0;
		object obj37 = !flag8;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v18+18]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v18+18]");
		bool flag9 = (nint)0 == 0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v33+E4]");
			bool flag10 = (nint)0 == 0;
			object obj40 = !flag10;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj41 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v22+A0]");
				obj38 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C28]");
			object obj42 = 0;
			num2 = (nint)obj42;
			Action<System.__Canon> action4 = default;
			action4._002Ector(obj38, (IntPtr)obj42);
			object obj43 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v21+A0]");
			object obj44 = (nint)0 + (nint)24;
			obj44 = action4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj30 = null;
			text = (string)(object)action4;
			errorCallback = (Action<PlayFabError>)action4;
		}
		object obj45 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v35+E4]");
		bool flag11 = (nint)0 == 0;
		object obj46 = !flag11;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserTitleDisplayName(updateUserTitleDisplayNameRequest, resultCallback2, errorCallback);
	}

	private void Presence(float t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e6c: Expected Obj, but got I4
		//IL_0e92: Expected Obj, but got I
		//IL_0eb4: Expected Obj, but got I4
		//IL_1083: Expected Obj, but got I
		//IL_1093: Expected Obj, but got I
		//IL_10b5: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_105d: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0efd: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I8
		//IL_0e05: Expected Obj, but got I
		//IL_0e12: Expected Obj, but got I4
		//IL_0e1b: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03d0: Expected Obj, but got I8
		//IL_03fd: Expected Obj, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got I4
		//IL_049b: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_052c: Expected Obj, but got I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0567: Expected Obj, but got I4
		//IL_0570: Expected Obj, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_062a: Expected Obj, but got I8
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_0689: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_070c: Expected Obj, but got I8
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_077d: Expected Obj, but got I4
		//IL_0793: Expected Obj, but got I
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_0808: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_08a5: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_0928: Expected Obj, but got I8
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_098f: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I4
		//IL_09f3: Expected Obj, but got I4
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected Obj, but got Unknown
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected Obj, but got Unknown
		//IL_0a68: Expected Obj, but got I4
		//IL_0a7e: Expected Obj, but got I
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected Obj, but got Unknown
		//IL_0ac1: Expected Obj, but got I
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected Obj, but got Unknown
		//IL_0b0b: Expected Obj, but got I4
		//IL_0b6c: Expected Obj, but got I4
		//IL_0b7c: Expected Obj, but got I4
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected Obj, but got Unknown
		//IL_0bbf: Expected Obj, but got I
		//IL_0bcf: Expected Obj, but got I
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0c42: Expected Obj, but got I
		//IL_0c52: Expected Obj, but got I
		//IL_0c80: Expected Obj, but got I
		//IL_0c90: Expected Obj, but got I
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected Obj, but got Unknown
		//IL_0cb8: Expected I, but got Obj
		//IL_0cfb: Expected Obj, but got I4
		//IL_0f29: Expected Obj, but got I
		//IL_0f39: Expected Obj, but got I
		//IL_0f49: Expected Obj, but got I
		//IL_0f59: Expected Obj, but got I
		//IL_0f69: Expected Obj, but got I
		//IL_0f8b: Expected Obj, but got I4
		//IL_0d8f: Expected I, but got Obj
		//IL_0dbe: Expected Obj, but got I4
		//IL_0d42: Expected Obj, but got I4
		//IL_0fb2: Expected Obj, but got I
		//IL_0fcc: Expected Obj, but got I
		//IL_0fd4: Expected I, but got Obj
		//IL_0fe5: Expected I, but got Obj
		//IL_1003: Expected Obj, but got I
		//IL_101e: Expected Obj, but got I4
		//IL_1026: Expected I4, but got Obj
		//IL_0d72: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		object obj11 = 0;
		UnityEngine.Object obj12 = null;
		object obj16;
		string text;
		if (!flag5)
		{
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v131+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X21_v3 (UnityEngine.Object)+B0]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			obj11 = 0;
			obj12 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X21_v3 (UnityEngine.Object)+B0]");
				bool isRunning = ((NetworkRunner)0).IsRunning;
				bool flag9 = !isRunning;
				obj11 = 0;
				obj12 = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X21_v3 (UnityEngine.Object)+B0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v61+2F8]");
					bool flag10 = (nint)0 == 0;
					obj11 = 0;
					obj12 = null;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X21_v3 (UnityEngine.Object)+A4]");
						bool flag11 = (nint)0 == 0;
						obj11 = 0;
						obj12 = null;
						if (flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+8]");
							string roomCode = ((NetworkBootstrap)0).RoomCode;
							obj16 = 0;
							obj11 = 0;
							obj12 = null;
							text = roomCode;
							goto IL_1033;
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj17 = 0;
		text = (string)obj17;
		obj16 = 1;
		goto IL_1033;
		IL_1033:
		object obj18 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v11+E4]");
		bool flag12 = (nint)0 == 0;
		object obj19 = !flag12;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+8]");
		if ((UnityEngine.Object)0 != null)
		{
		}
		object obj20 = obj16 & 1;
		int num;
		if (obj20 != null)
		{
			num = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v1+8]");
			int playerCount = ((NetworkBootstrap)0).PlayerCount;
			num = playerCount;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int num2 = default;
		string text2 = num2.ToString();
		string[] array = default;
		if (array.Length != 0)
		{
			object obj22 = array + 32;
			obj22 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X22_v5-8]");
			object obj23 = 0 & 0xFFFFFFFEL;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
				object obj24 = 0;
				object obj25 = array + 40;
				obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X22_v7-10]");
				bool flag13 = (nint)0 < (nint)2;
				object obj26 = !flag13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X22_v7-10]");
				object obj27 = -2;
				bool flag14 = obj27 == null;
				object obj28 = ~obj26;
				object obj29 = obj28 | flag14;
				if (obj29 == null)
				{
					object obj30 = array + 48;
					obj30 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X22_v9-18]");
					object obj31 = 0 & 0xFFFFFFFCL;
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
						object obj32 = 0;
						object obj33 = array + 56;
						obj33 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj34 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v32+E4]");
						bool flag15 = (nint)0 == 0;
						object obj35 = !flag15;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool offline = Offline;
						int num3 = default;
						string text3 = num3.ToString();
						bool flag16 = array.Length < 4;
						object obj36 = !flag16;
						object obj37 = array.Length - 4;
						bool flag17 = obj37 == null;
						object obj38 = ~obj36;
						object obj39 = obj38 | flag17;
						if (obj39 == null)
						{
							object obj40 = array + 64;
							obj40 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text4 = string.Concat(array);
							bool flag18 = !(nextPresence > t);
							object obj41 = 0;
							if (!flag18)
							{
								bool flag19 = text4 == presenceSaid;
								bool flag20 = !flag19;
								object obj42 = !flag20;
								obj41 = 0;
								if (obj42 != null)
								{
									return;
								}
							}
							object obj43 = this + 80;
							obj43 = text4;
							float num4 = t + 1.1190927E+09f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							string text5 = num2.ToString();
							string[] array2 = default;
							if (array2.Length != 0)
							{
								object obj44 = array2 + 32;
								obj44 = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X22_v13-8]");
								object obj45 = 0 & 0xFFFFFFFEL;
								if (obj45 != null)
								{
									object obj46 = array2 + 40;
									obj46 = obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X22_v15-10]");
									bool flag21 = (nint)0 < (nint)2;
									object obj47 = !flag21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X22_v15-10]");
									object obj48 = -2;
									bool flag22 = obj48 == null;
									object obj49 = ~obj47;
									object obj50 = obj49 | flag22;
									if (obj50 == null)
									{
										object obj51 = array2 + 48;
										obj51 = text;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X22_v17-18]");
										object obj52 = 0 & 0xFFFFFFFCL;
										if (obj52 != null)
										{
											object obj53 = array2 + 56;
											obj53 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text6 = num.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X20_v8-20]");
											bool flag23 = (nint)0 < (nint)4;
											object obj54 = !flag23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X20_v8-20]");
											object obj55 = -4;
											bool flag24 = obj55 == null;
											object obj56 = ~obj54;
											object obj57 = obj56 | flag24;
											if (obj57 == null)
											{
												object obj58 = array2 + 64;
												obj58 = text6;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X20_v10-28]");
												bool flag25 = (nint)0 < (nint)5;
												object obj59 = !flag25;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X20_v10-28]");
												object obj60 = -5;
												bool flag26 = obj60 == null;
												object obj61 = ~obj59;
												object obj62 = obj61 | flag26;
												if (obj62 == null)
												{
													object obj63 = array2 + 72;
													obj63 = obj24;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													int num5 = default;
													string text7 = num5.ToString();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X20_v12-30]");
													bool flag27 = (nint)0 < (nint)6;
													object obj64 = !flag27;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X20_v12-30]");
													object obj65 = -6;
													bool flag28 = obj65 == null;
													object obj66 = ~obj64;
													object obj67 = obj66 | flag28;
													if (obj67 == null)
													{
														object obj68 = array2 + 80;
														obj68 = text7;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X20_v14-38]");
														object obj69 = 0 & 0xFFFFFFF8L;
														if (obj69 != null)
														{
															object obj70 = array2 + 88;
															obj70 = obj24;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj71 = obj32;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v72+E4]");
															bool flag29 = (nint)0 == 0;
															object obj72 = !flag29;
															if (obj72 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															bool offline2 = Offline;
															string text8 = num3.ToString();
															bool flag30 = array2.Length < 8;
															object obj73 = !flag30;
															object obj74 = array2.Length - 8;
															bool flag31 = obj74 == null;
															object obj75 = ~obj73;
															object obj76 = obj75 | flag31;
															if (obj76 == null)
															{
																object obj77 = array2 + 96;
																obj77 = text8;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X20_v16-48]");
																bool flag32 = (nint)0 < (nint)9;
																object obj78 = !flag32;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X20_v16-48]");
																object obj79 = -9;
																bool flag33 = obj79 == null;
																object obj80 = ~obj78;
																object obj81 = obj80 | flag33;
																if (obj81 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
																	object obj82 = 0;
																	object obj83 = array2 + 104;
																	obj83 = obj24;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	object obj84 = obj82;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v81+E4]");
																	bool flag34 = (nint)0 == 0;
																	object obj85 = !flag34;
																	if (obj85 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	DateTime utcNow = DateTime.UtcNow;
																	DateTime dateTime = default;
																	long ticks = dateTime.Ticks;
																	long num6 = default;
																	string text9 = num6.ToString();
																	bool flag35 = array2.Length < 10;
																	object obj86 = !flag35;
																	object obj87 = array2.Length - 10;
																	bool flag36 = obj87 == null;
																	object obj88 = ~obj86;
																	object obj89 = obj88 | flag36;
																	if (obj89 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E68]");
																		object obj90 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
																		object obj91 = 0;
																		object obj92 = array2 + 112;
																		obj92 = text9;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		string value = string.Concat(array2);
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																		UpdateUserDataRequest updateUserDataRequest = default;
																		updateUserDataRequest._002Ector();
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																		Dictionary<System.__Canon, System.__Canon> dictionary = default;
																		dictionary._002Ector();
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CA8]");
																		object key = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
																		object obj93 = 0;
																		object obj94 = obj93;
																		dictionary.Add((System.__Canon)key, (System.__Canon)(object)value);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C10]");
																		object obj95 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C30]");
																		object obj96 = 0;
																		object obj97 = updateUserDataRequest + 32;
																		obj97 = dictionary;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		nint num7 = (nint)obj95;
																		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
																		object obj98 = obj96;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v103+E4]");
																		bool flag37 = (nint)0 == 0;
																		object obj99 = !flag37;
																		if (obj99 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			obj98 = obj96;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v103+A0]");
																		object obj100 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
																		object obj101 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C98]");
																		object obj102 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v44+20]");
																		Action<UpdateUserDataResult> resultCallback = (Action<UpdateUserDataResult>)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
																		object obj103 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v44+20]");
																		bool flag38 = (nint)0 == 0;
																		object obj104 = !flag38;
																		Unity.IL2CPP.Metadata.__Il2CppInt32Enum _Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
																		if (obj104 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v103+E4]");
																			bool flag39 = (nint)0 == 0;
																			object obj105 = !flag39;
																			if (obj105 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				object obj106 = obj96;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v48+A0]");
																				obj100 = 0;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E48]");
																			object obj107 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CA0]");
																			object obj108 = 0;
																			num7 = (nint)obj108;
																			Action<System.__Canon> action = default;
																			action._002Ector(obj100, (IntPtr)obj108);
																			object obj109 = obj96;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X8_v47+A0]");
																			object obj110 = (nint)0 + (nint)32;
																			obj110 = action;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			obj94 = 0;
																			_Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)action;
																			resultCallback = (Action<UpdateUserDataResult>)action;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																		Action<System.__Canon> action2 = default;
																		action2._002Ector((object)this, (IntPtr)obj102);
																		object obj111 = obj103;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v107+E4]");
																		bool flag40 = (nint)0 == 0;
																		object obj112 = !flag40;
																		if (obj112 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		PlayFabClientAPI.UpdateUserData(updateUserDataRequest, resultCallback, (Action<PlayFabError>)action2);
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
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Ask(string id, string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D30]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	public static void Answer(string id, string name, bool yes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_004a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D70]");
		object function = 0;
		bool? flag = yes;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	public static void Cancel(string id, string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D78]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	public static void Remove(string id, string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D80]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	public static void Block(string id, string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		//IL_01cb: Expected VT, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LoadBlocked();
		bool flag2 = string.IsNullOrEmpty(id);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		System.__Canon _Canon = null;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v12+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+8]");
			bool flag5 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)id);
			bool flag6 = !flag5;
			_Canon = (System.__Canon)(object)id;
			if (!flag6)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SaveBlocked();
				_Canon = (System.__Canon)(object)id;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D88]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	public static void Unblock(string id, string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D90]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Do((string)function, id, name, (bool?)(object)0);
	}

	private unsafe static void Do(string function, string id, string name, bool? yes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_084b: Expected Obj, but got I
		//IL_086d: Expected Obj, but got I4
		//IL_0a5c: Expected Obj, but got I
		//IL_0a7e: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I
		//IL_0ab4: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I
		//IL_08ed: Expected VT, but got I4
		//IL_08f6: Expected VT, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_091e: Expected Obj, but got I
		//IL_0948: Expected VT, but got I4
		//IL_0951: Expected VT, but got I4
		//IL_01a4: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I4
		//IL_0275: Expected VT, but got I4
		//IL_027e: Expected VT, but got I4
		//IL_033c: Expected VT, but got I4
		//IL_0345: Expected VT, but got I4
		//IL_01f6: Expected Obj, but got I
		//IL_0220: Expected VT, but got I4
		//IL_0229: Expected VT, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_037d: Expected Obj, but got VT
		//IL_0697: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I4
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected VT, but got Unknown
		//IL_04bf: Expected VT, but got I4
		//IL_04c8: Expected Obj, but got I4
		//IL_04d0: Expected VT, but got Ref
		//IL_04f1: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I
		//IL_0713: Expected VT, but got I4
		//IL_071c: Expected VT, but got I4
		//IL_09a3: Expected Obj, but got I
		//IL_09b4: Expected Ref, but got VT
		//IL_09ce: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got VT
		//IL_0508: Invalid comparison between VT and I4
		//IL_0519: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got VT
		//IL_059e: Expected Obj, but got I4
		//IL_0410: Expected VT, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0421: Expected VT, but got Ref
		//IL_0442: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_07ce: Expected VT, but got I4
		//IL_09f4: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I4
		//IL_082d: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected VT, but got Unknown
		//IL_0619: Expected VT, but got Obj
		//IL_0622: Expected VT, but got I4
		//IL_062b: Expected VT, but got I4
		//IL_0634: Expected VT, but got I4
		//IL_0668: Expected VT, but got Ref
		//IL_0668: Expected Obj, but got I
		//IL_0678: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		bool flag5 = string.IsNullOrEmpty(id);
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v14+A0]");
		object obj15 = 0;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v10+10]");
		Queue<(string, string, string, bool?)> queue = (Queue<(string, string, string, bool?)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v10+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+A0]");
			object obj18 = 0;
			GillaFriends gillaFriends = (GillaFriends)obj18;
			bool flag10 = obj18 == null;
			bool? flag11 = yes;
			Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
			(System.__Canon, System.__Canon, System.__Canon, bool?) tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
			System.__Canon _Canon = null;
			System.__Canon _Canon2 = null;
			if (!flag10)
			{
				bool flag12 = (byte)(~(gillaFriends.busy ? 1u : 0u)) != 0;
				object obj19 = !flag12;
				queue = (Queue<(string, string, string, bool?)>)gillaFriends.busy;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
					queue = (Queue<(string, string, string, bool?)>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
					bool flag13 = (nint)0 == 0;
					object obj20 = !flag13;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+A0]");
						object obj21 = 0;
						gillaFriends = (GillaFriends)obj21;
						bool flag14 = obj21 == null;
						flag11 = yes;
						enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
						tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
						_Canon = null;
						_Canon2 = null;
						if (flag14)
						{
							goto IL_075c;
						}
					}
					queue = gillaFriends.waiting;
					bool flag15 = (object)gillaFriends.waiting == null;
					flag11 = yes;
					enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
					tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
					_Canon = null;
					_Canon2 = null;
					if (flag15)
					{
						goto IL_075c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v4 (System.Collections.Generic.Queue`1<System.ValueTuple`4<System.String, System.String, System.String, System.Nullable`1<System.Boolean>>>)+20]");
					queue = (Queue<(string, string, string, bool?)>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v4 (System.Collections.Generic.Queue`1<System.ValueTuple`4<System.String, System.String, System.String, System.Nullable`1<System.Boolean>>>)+20]");
					if ((nint)0 < (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
						queue = (Queue<(string, string, string, bool?)>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
						bool flag16 = (nint)0 == 0;
						object obj22 = !flag16;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj23 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v44+A0]");
							object obj24 = 0;
							gillaFriends = (GillaFriends)obj24;
							bool flag17 = obj24 == null;
							flag11 = yes;
							enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
							tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
							_Canon = null;
							_Canon2 = null;
							if (flag17)
							{
								goto IL_075c;
							}
						}
						bool? yes2 = (bool?)(object)((_003F?)yes & 0xFFFF);
						gillaFriends.Send(function, id, name, yes2);
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
				bool flag18 = (nint)0 == 0;
				object obj25 = !flag18;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+A0]");
				object obj26 = 0;
				object obj27 = obj26;
				bool flag19 = obj26 == null;
				flag11 = yes;
				enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
				tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
				_Canon = null;
				_Canon2 = null;
				if (!flag19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v35+38]");
					bool flag20 = (nint)0 == 0;
					flag11 = yes;
					enumerator = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)0;
					tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
					_Canon = null;
					_Canon2 = null;
					if (!flag20)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v35+38]");
						Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator enumerator2 = ((Queue<(System.__Canon, System.__Canon, System.__Canon, bool?)>)0).GetEnumerator();
						Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator enumerator3 = default;
						string text = (string)enumerator3;
						_Canon = null;
						string text2 = default;
						object obj28;
						(System.__Canon, System.__Canon, System.__Canon, bool?) tuple5 = default;
						(System.__Canon, System.__Canon, System.__Canon, bool?) tuple7 = default;
						Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator enumerator4;
						object obj29;
						object obj30;
						(System.__Canon, System.__Canon, System.__Canon, bool?) tuple2;
						(System.__Canon, System.__Canon, System.__Canon, bool?) tuple3;
						while (true)
						{
							(System.__Canon, System.__Canon, System.__Canon, bool?) tuple4;
							(System.__Canon, System.__Canon, System.__Canon, bool?) tuple6;
							if (enumerator.MoveNext())
							{
								(System.__Canon, System.__Canon, System.__Canon, bool?) current = enumerator.Current;
								bool flag21 = (string)enumerator3 == function;
								bool flag22 = !flag21;
								_Canon = null;
								if (!flag22)
								{
									bool flag23 = text2 == id;
									bool flag24 = !flag23;
									_Canon = null;
									if (!flag24)
									{
										flag11 = yes;
										tuple2 = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
										obj28 = 0;
										tuple3 = ((System.__Canon, System.__Canon, System.__Canon, bool?))(&enumerator);
										tuple4 = tuple5;
										tuple6 = tuple7;
										enumerator4 = enumerator3;
										obj29 = 9;
										_Canon = null;
										obj30 = 0;
										break;
									}
								}
								continue;
							}
							flag11 = yes;
							tuple2 = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
							obj28 = 0;
							tuple3 = ((System.__Canon, System.__Canon, System.__Canon, bool?))(&enumerator);
							tuple4 = tuple5;
							tuple6 = tuple7;
							enumerator4 = enumerator3;
							obj29 = 10;
							obj30 = 0;
							break;
						}
						object obj34 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D38]");
							object obj31 = 0;
							_Canon2 = (System.__Canon)obj31;
							((Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator*)tuple3)->Dispose();
							bool flag25 = obj30 == null;
							object obj32 = !flag25;
							tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))enumerator4;
							if (obj32 == null)
							{
								bool flag26 = tuple2 == ((System.__Canon, System.__Canon, System.__Canon, bool?))(object)0;
								object obj33 = !flag26;
								OutOfMemoryException ex = (OutOfMemoryException)tuple3;
								if (obj33 == null)
								{
									break;
								}
							}
							else
							{
								OutOfMemoryException ex = new OutOfMemoryException();
								enumerator4 = (Stack<(System.__Canon, System.__Canon, System.__Canon, bool?)>.Enumerator)tuple;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)_Canon2 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								tuple2 = ((System.__Canon, System.__Canon, System.__Canon, bool?))1;
								obj30 = obj28;
							}
							else
							{
								if ((nint)_Canon2 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0D20");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj30 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj28 = obj34;
							}
							obj29 = 0;
						}
						if ((nint)obj29 != 10)
						{
							bool flag27 = obj29 == null;
							object obj35 = !flag27;
							if (obj35 != null)
							{
								return;
							}
						}
						object obj36 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v23+E4]");
						bool flag28 = (nint)0 == 0;
						object obj37 = !flag28;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj36 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v23+A0]");
						object obj38 = 0;
						object obj39 = obj38;
						bool flag29 = obj38 == null;
						tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))enumerator4;
						if (!flag29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D60]");
							queue = (Queue<(string, string, string, bool?)>)0;
							bool? item = (bool?)(object)((_003F?)yes & 0xFFFF);
							tuple3 = ((System.__Canon)(object)function, (System.__Canon)(object)id, (System.__Canon)(object)name, item);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22+38]");
							bool flag30 = (nint)0 == 0;
							flag11 = (bool?)(object)name;
							tuple2 = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
							tuple3 = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
							tuple = ((System.__Canon, System.__Canon, System.__Canon, bool?))0;
							_Canon = (System.__Canon)(object)id;
							_Canon2 = (System.__Canon)(object)function;
							if (!flag30)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22+38]");
								((Queue<(System.__Canon, System.__Canon, System.__Canon, bool?)>)0).Enqueue(((System.__Canon, System.__Canon, System.__Canon, bool?))(&text));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D68]");
								object what = 0;
								Say((string)what);
								return;
							}
						}
					}
				}
			}
			goto IL_075c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v49+E4]");
		bool flag31 = (nint)0 == 0;
		object obj40 = !flag31;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3E0]");
		object what2 = 0;
		Say((string)what2);
		return;
		IL_075c:
		throw new NullReferenceException();
	}

	private void Send(string function, string id, string name, bool? yes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_02cd: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_02ed: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2 + 24;
		obj5 = function;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 32;
		obj6 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2 + 40;
		obj7 = id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		busy = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C58]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
		object obj9 = 0;
		System.__Canon _Canon = (System.__Canon)obj7;
		object obj10 = obj8;
		dictionary.Add((System.__Canon)key, (System.__Canon)obj7);
		object obj11 = (_003F?)yes & 0xFF;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C60]");
			object key2 = 0;
			bool? flag = default;
			bool value = flag.Value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			obj10 = obj9;
			System.__Canon _Canon2 = default;
			dictionary.set_Item((System.__Canon)key2, _Canon2);
			_Canon = _Canon2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C48]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C50]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj16 = 0;
		bool flag2 = string.IsNullOrEmpty((string)obj6);
		bool flag3 = !flag2;
		object obj17 = !flag3;
		System.__Canon _Canon3 = null;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
			object obj18 = 0;
			bool flag4 = (string)obj6 != (string)obj18;
			bool flag5 = !flag4;
			_Canon = null;
			_Canon3 = (System.__Canon)obj18;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF10]");
				object obj19 = 0;
				_Canon = (System.__Canon)obj6;
				obj10 = obj9;
				_Canon3 = (System.__Canon)obj19;
				dictionary.set_Item((System.__Canon)obj19, (System.__Canon)obj6);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj15);
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v27+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+18]");
		GillaCloud.Run((string)0, (Dictionary<string, object>)(object)dictionary, (Action<string>)action, (Action<string>)action2);
	}

	private unsafe static void Nudge(string id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got I4
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got I4
		//IL_05e7: Expected I, but got Obj
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Ref, but got Unknown
		//IL_060a: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_040f: Expected Obj, but got I4
		//IL_042a: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
		//IL_02b8: Expected I, but got Obj
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v17 (UnityEngine.Object)+8]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v17 (UnityEngine.Object)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			obj4 = obj6;
			Enumerator<, > val2 = default;
			object obj24 = default;
			object obj20;
			Enumerator<, > val3;
			Enumerator<, > val4;
			while (true)
			{
				object obj21;
				if (val.MoveNext())
				{
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v29+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v29+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 != null;
					bool flag5 = !flag4;
					object obj11 = 0;
					if (flag5)
					{
						continue;
					}
					UnityEngine.Object obj16;
					nint num;
					if ((object)obj6 != null)
					{
						bool isLocal = ((NetworkApe)obj6).IsLocal;
						bool flag6 = !isLocal;
						object obj12 = !flag6;
						obj11 = 0;
						if (obj12 != null)
						{
							continue;
						}
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+40]");
						UnityEngine.Object obj14 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v40+E4]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v40+E4]");
						bool flag7 = (nint)0 == 0;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = obj14 != null;
						bool flag9 = !flag8;
						obj11 = 0;
						if (flag9)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+40]");
						obj14 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ stack_-78 (UnityEngine.Object)+40]");
						bool flag10 = (nint)0 == 0;
						obj11 = 0;
						obj16 = null;
						if (!flag10)
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v45+E4]");
							obj4 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v45+E4]");
							bool flag11 = (nint)0 == 0;
							object obj18 = !flag11;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X22_v7 (UnityEngine.Object)+30]");
							bool flag12 = (UnityEngine.Object)0;
							bool flag13 = !flag12;
							obj11 = 0;
							if (flag13)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X22_v7 (UnityEngine.Object)+30]");
							bool flag14 = (nint)0 == 0;
							obj11 = 0;
							num = unchecked((nint)null);
							if (flag14)
							{
								break;
							}
							ArgumentNullException ex = new ArgumentNullException();
							object obj19 = ex & 1;
							bool flag15 = obj19 == null;
							obj11 = 0;
							if (flag15)
							{
								continue;
							}
							string accountId = ((NetworkApe)obj6).AccountId;
							bool flag16 = accountId == id;
							bool flag17 = !flag16;
							obj11 = 0;
							if (flag17)
							{
								continue;
							}
							((NetworkApe)obj6).RPC_Moderated();
							obj11 = 0;
							obj5 = null;
							val = val2;
							obj20 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj21 = 0;
							goto IL_05df;
						}
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
						obj11 = 0;
						obj16 = null;
					}
					NullReferenceException ex3 = new NullReferenceException();
					num = (nint)obj16;
					break;
				}
				obj5 = null;
				val = val2;
				obj20 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				obj21 = 0;
				goto IL_05df;
				IL_05df:
				while (true)
				{
					nint num = (nint)obj8;
					((Enumerator<, >*)val4)->Dispose();
					bool flag18 = obj21 == null;
					object obj22 = !flag18;
					if (obj22 == null)
					{
						bool flag19 = (object)obj5 == null;
						object obj23 = !flag19;
						OutOfMemoryException ex4 = (OutOfMemoryException)val4;
						if (obj23 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex4 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = (UnityEngine.Object)1;
						obj4 = (UnityEngine.Object)1;
						obj21 = obj20;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj21 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj20 = obj24;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
			NullReferenceException ex5 = new NullReferenceException();
			obj5 = null;
			val = val2;
			obj20 = 0;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private static void Notice(string title, string line)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj7 = (nint)0 + (nint)64;
		obj7 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaToast.Show(0, title, line, error: false);
	}

	public static void TakeForTest(State s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			GillaFriends gillaFriends = (GillaFriends)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8 (GillaFriends)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaFriends = (GillaFriends)obj;
			}
			gillaFriends.Take(s, quick: false);
		}
	}

	private static string Outcome(string function, Reply a, string name)
	{
		//IL_0c03: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I
		//IL_09db: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_0935: Expected Obj, but got I
		//IL_090b: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I
		//IL_0a1e: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_0ba1: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_089e: Expected Obj, but got I
		//IL_0978: Expected Obj, but got I
		//IL_046d: Expected Obj, but got I
		//IL_0af8: Expected Obj, but got I
		//IL_06a5: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_09b6: Expected Obj, but got I
		//IL_09c6: Expected Obj, but got I
		//IL_0a8b: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_06e8: Expected Obj, but got I
		//IL_0a33: Expected Obj, but got I
		//IL_0ae3: Expected Obj, but got I
		//IL_0ace: Expected Obj, but got I
		//IL_0b0d: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_0726: Expected Obj, but got I
		//IL_07e4: Expected Obj, but got I
		//IL_0a76: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I
		//IL_0827: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(name);
		bool flag2 = !flag;
		object obj = !flag2;
		string text;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
			object obj2 = 0;
			bool flag3 = name == (string)obj2;
			bool flag4 = !flag3;
			text = name;
			if (flag4)
			{
				goto IL_0c11;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB688]");
		object obj3 = 0;
		text = (string)obj3;
		goto IL_0c11;
		IL_0cbe:
		string text2;
		string text3;
		string text4;
		return text2 + text3 + text4;
		IL_0b84:
		string refused;
		string text5 = refused.ToUpperInvariant();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E28]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
		object obj5 = 0;
		text4 = (string)obj5;
		text3 = text5;
		text2 = (string)obj4;
		goto IL_0cbe;
		IL_0c11:
		object obj7;
		object obj9;
		object obj10;
		object obj22;
		if (a != null)
		{
			string did = a.did;
			if (a.did != null)
			{
				if (did._stringLength <= 7)
				{
					if (did._stringLength != 5)
					{
						if (did._stringLength == 7)
						{
							char c = a.did.get_Chars(0);
							int num = c & 0xFFFF;
							if (num != 98)
							{
								if (num != 102)
								{
									if (num == 114)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E60]");
										object obj6 = 0;
										if (a.did == (string)obj6)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E80]");
											obj7 = 0;
											goto IL_0c2e;
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BA0]");
									object obj8 = 0;
									if (a.did == (string)obj8)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BC8]");
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0BA8]");
										obj10 = 0;
										goto IL_0c43;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E18]");
								object obj11 = 0;
								if (a.did == (string)obj11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DE8]");
									obj7 = 0;
									goto IL_0c2e;
								}
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B90]");
						object obj12 = 0;
						if (a.did == (string)obj12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DB8]");
							obj7 = 0;
							goto IL_0c2e;
						}
					}
				}
				else if (did._stringLength != 8)
				{
					if (did._stringLength == 9)
					{
						char c2 = a.did.get_Chars(0);
						int num2 = c2 & 0xFFFF;
						if (num2 != 99)
						{
							if (num2 == 117)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E20]");
								object obj13 = 0;
								if (a.did == (string)obj13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DC8]");
									obj7 = 0;
									goto IL_0c2e;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E10]");
							object obj14 = 0;
							if (a.did == (string)obj14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E70]");
								obj7 = 0;
								goto IL_0c2e;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DB0]");
					object obj15 = 0;
					if (a.did == (string)obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DA0]");
						obj7 = 0;
						goto IL_0c2e;
					}
				}
			}
			refused = a.refused;
			if (a.refused != null)
			{
				if (refused._stringLength > 9)
				{
					object obj19;
					if (refused._stringLength <= 12)
					{
						if (refused._stringLength != 10)
						{
							if (refused._stringLength == 11)
							{
								char c3 = a.refused.get_Chars(0);
								switch (c3 & 0xFFFF)
								{
								case 121:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DD8]");
									object obj18 = 0;
									if (a.refused == (string)obj18)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E38]");
										return (string)0;
									}
									break;
								}
								case 110:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DE0]");
									object obj16 = 0;
									if (a.refused == (string)obj16)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E48]");
										return (string)0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E00]");
									object obj17 = 0;
									if (a.refused == (string)obj17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DA8]");
										return (string)0;
									}
									break;
								}
								}
								goto IL_0b55;
							}
							goto IL_0b84;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC468]");
						obj19 = 0;
					}
					else
					{
						if (refused._stringLength != 14)
						{
							if (refused._stringLength == 13)
							{
								char c4 = a.refused.get_Chars(0);
								switch (c4 & 0xFFFF)
								{
								case 110:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC458]");
									object obj21 = 0;
									if (a.refused == (string)obj21)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E68]");
										return (string)0;
									}
									break;
								}
								case 97:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E98]");
									object obj20 = 0;
									if (a.refused == (string)obj20)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E30]");
										return (string)0;
									}
									break;
								}
								}
								goto IL_0b55;
							}
							goto IL_0b84;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC450]");
						obj19 = 0;
					}
					if (refused == (string)obj19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E50]");
						obj22 = 0;
						goto IL_0c93;
					}
				}
				else if (refused._stringLength != 4)
				{
					if (refused._stringLength != 7)
					{
						if (refused._stringLength != 9)
						{
							goto IL_0b84;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DC0]");
						object obj23 = 0;
						if (a.refused == (string)obj23)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D78]");
							object obj24 = 0;
							if (function == (string)obj24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E40]");
								return (string)0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E08]");
							obj22 = 0;
							goto IL_0c93;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E88]");
						object obj25 = 0;
						if (a.refused == (string)obj25)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D88]");
							object obj26 = 0;
							if (function == (string)obj26)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DD0]");
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E58]");
								obj10 = 0;
								goto IL_0c43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E78]");
							return (string)0;
						}
					}
				}
				else
				{
					char c5 = a.refused.get_Chars(0);
					switch (c5 & 0xFFFF)
					{
					case 102:
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DF0]");
						object obj28 = 0;
						if (a.refused == (string)obj28)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E90]");
							return (string)0;
						}
						break;
					}
					case 99:
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0DF8]");
						object obj27 = 0;
						if (a.refused == (string)obj27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0D98]");
							return (string)0;
						}
						break;
					}
					}
				}
				goto IL_0b55;
			}
			goto IL_0bce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EA0]");
		return (string)0;
		IL_0b55:
		refused = a.refused;
		if (a.refused != null)
		{
			goto IL_0b84;
		}
		goto IL_0bce;
		IL_0c2e:
		string text6 = (string)obj7;
		string text7 = text;
		goto IL_0ca8;
		IL_0ca8:
		return text6 + text7;
		IL_0c43:
		text2 = (string)obj9;
		text4 = (string)obj10;
		text3 = text;
		goto IL_0cbe;
		IL_0c93:
		text7 = (string)obj22;
		text6 = text;
		goto IL_0ca8;
		IL_0bce:
		return (string)(object)new NullReferenceException();
	}

	public static void Join(Friend f)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got I4
		//IL_07d1: Expected Obj, but got I
		//IL_07f3: Expected Obj, but got I4
		//IL_0973: Expected Obj, but got I
		//IL_0983: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I4
		//IL_0819: Expected Obj, but got I
		//IL_083b: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected I4, but got Unknown
		//IL_02bc: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I
		//IL_05e1: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_08cf: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_0405: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0690: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_0927: Expected Obj, but got I4
		//IL_06cf: Expected Obj, but got I
		//IL_0945: Expected Obj, but got I
		//IL_0725: Expected Obj, but got I
		//IL_0735: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+8]");
		UnityEngine.Object obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj5;
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj13 == null)
		{
			return;
		}
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+8]");
		bool flag6 = (UnityEngine.Object)0 == null;
		if (f == null)
		{
			return;
		}
		bool flag7 = !flag6;
		object obj17 = !flag7;
		if (obj17 != null)
		{
			return;
		}
		NetworkBootstrap.Lobby lobby;
		string what;
		object obj27;
		object obj30;
		object obj31;
		string text;
		string text2;
		if (~(f.on ? 1u : 0u) == 0)
		{
			if (!string.IsNullOrEmpty(f.code))
			{
				if (f.most < 1 || f.players < f.most)
				{
					object obj18 = f.kind - 2;
					bool flag8 = (nint)obj18 < 0;
					int num = f.kind ^ 2;
					int num2 = f.kind ^ obj18;
					int num3 = num & num2;
					bool flag9 = num3 < 0;
					bool flag10 = flag8 == flag9;
					object obj19 = !flag10;
					object obj20 = ~obj19;
					int num4 = ((obj20 != null) ? 2 : f.kind);
					object obj21 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v30+E4]");
					bool flag11 = (nint)0 == 0;
					object obj22 = !flag11;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num5 = ~num4;
					lobby = (NetworkBootstrap.Lobby)(num4 & num5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v3 (UnityEngine.Object)+B0]");
					bool flag12 = (UnityEngine.Object)0 != null;
					bool flag13 = !flag12;
					UnityEngine.Object obj23 = null;
					object obj24;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v3 (UnityEngine.Object)+B0]");
						bool isRunning = ((NetworkRunner)0).IsRunning;
						bool flag14 = !isRunning;
						obj23 = null;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v3 (UnityEngine.Object)+90]");
							bool flag15 = (nint)0 != (nint)lobby;
							obj24 = 0;
							text = null;
							if (!flag15)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+8]");
								string roomCode = ((NetworkBootstrap)0).RoomCode;
								text = f.code;
								bool flag16 = roomCode == f.code;
								bool flag17 = !flag16;
								obj24 = 0;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EB0]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E58]");
									object obj26 = 0;
									text = f.name;
									text2 = (string)obj26;
									what = (string)obj25 + f.name + (string)obj26;
									goto IL_01a9;
								}
							}
							obj27 = 0;
							goto IL_08a5;
						}
					}
					obj27 = 1;
					obj24 = 0;
					text = (string)(object)obj23;
					goto IL_08a5;
				}
				object obj28 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v69+E4]");
				bool flag18 = (nint)0 == 0;
				object obj29 = !flag18;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CC0]");
				obj30 = 0;
				text = null;
				goto IL_0898;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EC0]");
			obj31 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EB8]");
			obj31 = 0;
		}
		text = (string)obj31;
		what = f.name + (string)obj31;
		text2 = null;
		goto IL_01a9;
		IL_0898:
		what = (string)obj30;
		goto IL_0871;
		IL_08a5:
		object obj32 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v3 (UnityEngine.Object)+A4]");
		bool flag19 = (nint)0 == 0;
		object obj33 = !flag19;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v39+E4]");
			bool flag20 = (nint)0 == 0;
			object obj34 = !flag20;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v39+A0]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v32+58]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v39+E4]");
				bool flag21 = (nint)0 == 0;
				object obj37 = !flag21;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj38 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v44+A0]");
					object obj39 = 0;
					obj36 = obj39;
				}
				object obj40 = obj36 + 88;
				obj40 = f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj41 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v34+A0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v3 (UnityEngine.Object)+90]");
				_ = 0;
				string text3;
				if (obj27 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj43 = 0;
					text3 = (string)obj43;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+8]");
					string roomCode2 = ((NetworkBootstrap)0).RoomCode;
					text3 = roomCode2;
				}
				object obj44 = obj42 + 104;
				obj44 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj45 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v47+E4]");
				bool flag22 = (nint)0 == 0;
				object obj46 = !flag22;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj45 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v47+A0]");
				object obj47 = 0;
				object obj48 = obj47;
				float unscaledTime = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EC8]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
				object obj50 = 0;
				string what2 = (string)obj49 + f.name + (string)obj50;
				Say(what2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+8]");
				((NetworkBootstrap)0).JoinLobby(lobby, f.code);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v39+E4]");
		bool flag23 = (nint)0 == 0;
		object obj51 = !flag23;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EA8]");
		obj30 = 0;
		goto IL_0898;
		IL_01a9:
		object obj52 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15+E4]");
		bool flag24 = (nint)0 == 0;
		object obj53 = !flag24;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		goto IL_0871;
		IL_0871:
		Say(what);
	}

	private void Joins(float t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I4
		//IL_07dc: Expected Obj, but got I4
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_080c: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I4
		//IL_05b3: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I
		//IL_06a9: Expected Obj, but got I
		//IL_02fe: Expected I4, but got Obj
		//IL_0320: Expected Obj, but got I4
		//IL_0700: Expected Obj, but got I
		//IL_0710: Expected Obj, but got I
		//IL_0725: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I4
		//IL_0602: Expected Obj, but got I
		//IL_0617: Expected Obj, but got I
		//IL_062b: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I4
		//IL_082a: Expected Obj, but got I
		//IL_0854: Expected Obj, but got I4
		//IL_06da: Expected Obj, but got I
		//IL_06eb: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_0525: Expected Obj, but got I4
		//IL_04ac: Expected VT, but got I4
		//IL_04ac: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj6 = this + 88;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+A0]");
		object obj8 = 0;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v2+8]");
		UnityEngine.Object obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v2+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			return;
		}
		float num = t - joinAsked;
		if ((double)num < 0.5)
		{
			return;
		}
		if ((double)num < 30.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+A4]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		object obj13 = obj6;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+2C]");
		object obj15 = -2;
		bool flag6 = (nint)obj15 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+2C]");
		object obj16 = (nint)0 ^ (nint)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+2C]");
		object obj17 = 0 ^ obj15;
		object obj18 = obj16 & obj17;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = flag6 == flag7;
		object obj19 = !flag8;
		object obj20 = ~obj19;
		object obj21;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+2C]");
			obj21 = 0;
		}
		else
		{
			obj21 = 2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+B0]");
		bool flag10 = (UnityEngine.Object)0 != null;
		bool flag11 = !flag10;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+B0]");
			bool isRunning = ((NetworkRunner)0).IsRunning;
			bool flag12 = !isRunning;
			obj23 = 0;
			obj24 = null;
			if (!flag12)
			{
				object obj25 = ~obj21;
				NetworkBootstrap.Lobby lobby = (NetworkBootstrap.Lobby)(obj21 & obj25);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+90]");
				bool flag13 = (nint)0 != (nint)lobby;
				obj23 = 0;
				obj24 = null;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v2+8]");
					string roomCode = ((NetworkBootstrap)0).RoomCode;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+20]");
					bool flag14 = roomCode == (string)0;
					bool flag15 = !flag14;
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+20]");
					obj24 = (UnityEngine.Object)0;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+2C]");
						double num2;
						if ((nint)0 <= (nint)0)
						{
							bool flag16 = lobby == fromKind;
							num2 = 30.0;
							if (flag16)
							{
								goto IL_04c2;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CB0]");
						object obj26 = 0;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v55+E4]");
						bool flag17 = (nint)0 == 0;
						object obj28 = !flag17;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag18 = GillaModeButton.Arrival(lobby, out var at);
						bool flag19 = !flag18;
						num2 = 30.0;
						if (!flag19)
						{
							Vector3 position = at.position;
							Vector3 forward = at.forward;
							bool flag20 = GillaTeleport.To((Vector3)0, (Vector3)0);
							num2 = 30.0;
						}
						goto IL_04c2;
					}
				}
			}
		}
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v20+E4]");
		bool flag21 = (nint)0 == 0;
		object obj30 = !flag21;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+20]");
		string text = NetworkBootstrap.Shown((string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+98]");
		if ((string)0 == text)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CC8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+18]");
			string what = (string)0 + (string)obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj32 = 0;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+E4]");
			bool flag22 = (nint)0 == 0;
			object obj34 = !flag22;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Say(what);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4D0]");
		object obj35 = 0;
		string text2 = (string)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X20_v5 (UnityEngine.Object)+78]");
		string what2;
		if ((string)0 == (string)obj35)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CC0]");
			object obj36 = 0;
			what2 = (string)obj36;
			object obj37 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CD0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+18]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+18]");
			string text3 = (string)obj38 + (string)0;
			what2 = text3;
			object obj37 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v29+E4]");
		bool flag23 = (nint)0 == 0;
		object obj41 = !flag23;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Say(what2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v2+8]");
		((NetworkBootstrap)0).JoinLobby(fromKind, fromCode);
		return;
		IL_04c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CB8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v4+18]");
		string what3 = (string)obj42 + (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v36+E4]");
		bool flag24 = (nint)0 == 0;
		object obj45 = !flag24;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Say(what3);
		nextPresence = 0f;
	}

	public GillaFriends()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0ED0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num = default;
		watchedAt = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<(System.__Canon, System.__Canon, System.__Canon, bool?)> queue = default;
		queue._002Ector();
		object obj2 = this + 56;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaFriends()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0AB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		State state = default;
		state._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+A0]");
		object obj5 = (nint)0 + (nint)16;
		obj5 = state;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+A0]");
		object obj7 = (nint)0 + (nint)40;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+A0]");
		object obj9 = (nint)0 + (nint)48;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)64;
		obj11 = obj3;
		_ = 3267887104L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void _003CSaveName_003Eb__84_1(PlayFabError error)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		object obj = this + 64;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EE0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj3 = 0;
		string text = error.GenerateErrorReport();
		string message = (string)obj2 + text;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}

	private void _003CPresence_003Eb__85_1(PlayFabError error)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		object obj = this + 80;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0EE8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj3 = 0;
		string text = error.GenerateErrorReport();
		string message = (string)obj2 + text;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}
}
