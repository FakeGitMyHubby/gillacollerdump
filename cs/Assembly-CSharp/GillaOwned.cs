using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public static class GillaOwned
{
	[Serializable]
	private class Kept
	{
		public GillaOutfits.Outfit[] outfits;

		public Kept()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5858]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj2 = this + 16;
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private class Seen
	{
		public HashSet<string> names;

		public bool unpublished;

		public long mutedUntil;

		public long bannedUntil;

		public string photon;

		public float at;

		public float asked;

		public bool pending;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<KeyValuePair<string, Seen>> _003C_003E9__35_0;

		public static Comparison<KeyValuePair<string, Seen>> _003C_003E9__35_1;

		public static Action<string, string, string> _003C_003E9__37_0;

		public static Action<string> _003C_003E9__37_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5960]");
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

		internal bool _003CTrim_003Eb__35_0(KeyValuePair<string, Seen> e)
		{
			//IL_0020: Expected I4, but got Obj
			IntPtr intPtr = default;
			if (intPtr != (IntPtr)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ X2 (Il2CppMethodInfo)+40]");
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int _003CTrim_003Eb__35_1(KeyValuePair<string, Seen> a, KeyValuePair<string, Seen> b)
		{
			//IL_01db: Invalid comparison between VT and I4
			//IL_01d2: Expected I4, but got Obj
			//IL_002d: Invalid comparison between F4 and I4
			//IL_003c: Invalid comparison between F4 and I4
			//IL_005f: Expected Obj, but got I
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_00a9: Expected Obj, but got I4
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00e2: Expected F4, but got I
			//IL_010a: Invalid comparison between F4 and I4
			//IL_0119: Invalid comparison between F4 and I4
			//IL_013c: Expected Obj, but got I
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_0186: Expected Obj, but got I4
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected Obj, but got Unknown
			//IL_01bf: Expected F4, but got I
			if (b != (KeyValuePair<string, Seen>)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X2 (System.Collections.Generic.KeyValuePair`2<System.String, GillaOwned+Seen>)+38]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X2 (System.Collections.Generic.KeyValuePair`2<System.String, GillaOwned+Seen>)+3C]");
				float num2 = num - 0f;
				bool flag = num2 < 0f;
				bool flag2 = num2 == 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X2 (System.Collections.Generic.KeyValuePair`2<System.String, GillaOwned+Seen>)+38]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X2 (System.Collections.Generic.KeyValuePair`2<System.String, GillaOwned+Seen>)+3C]");
				object obj = num3 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X2 (System.Collections.Generic.KeyValuePair`2<System.String, GillaOwned+Seen>)+38]");
				object obj2 = 0 ^ num2;
				object obj3 = obj & obj2;
				bool flag3 = (nint)obj3 < 0;
				bool flag4 = flag == flag3;
				object obj4 = !flag2;
				object obj5 = flag4 & obj4;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
				}
				object obj7 = default;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+38]");
					float value = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+38]");
					float num4 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+3C]");
					float num5 = num4 - 0f;
					bool flag5 = num5 < 0f;
					bool flag6 = num5 == 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+38]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+3C]");
					object obj8 = num6 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+38]");
					object obj9 = 0 ^ num5;
					object obj10 = obj8 & obj9;
					bool flag7 = (nint)obj10 < 0;
					bool flag8 = flag5 == flag7;
					object obj11 = !flag6;
					object obj12 = flag8 & obj11;
					object obj13 = ~obj12;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+3C]");
						value = 0f;
					}
					float num7 = default;
					return num7.CompareTo(value);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void _003CCheckingNow_003Eb__37_0(string value, string muted, string banned)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_00d9: Expected Obj, but got I
			//IL_00ef: Expected Obj, but got I
			//IL_015d: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I
			//IL_018d: Expected Obj, but got I4
			//IL_011f: Expected Obj, but got I
			//IL_0135: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
			object obj2 = 0;
			bool flag = value == null;
			bool value2 = !flag;
			bool? flag2 = value2;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
			object obj5 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
			object obj6 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v8+2C]");
			object obj11 = (nint)0 + (nint)1;
		}

		internal void _003CCheckingNow_003Eb__37_1(string error)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
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
			_ = 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public Seen s;

		public string account;

		public Action<string, string, string> got;

		internal void _003CAsk_003Eb__0(string value, string muted, string banned)
		{
			//IL_0057: Expected Obj, but got I
			//IL_006f: Expected Obj, but got I
			//IL_009e: Expected Obj, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_0121: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got I
			//IL_01b3: Expected Obj, but got I
			//IL_01ce: Expected Obj, but got I
			//IL_01f1: Expected Obj, but got I4
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected Obj, but got Unknown
			//IL_02ef: Expected Obj, but got I4
			//IL_030d: Expected Obj, but got I
			//IL_0246: Expected Obj, but got I
			//IL_025d: Expected Obj, but got I
			//IL_033c: Expected Obj, but got I4
			//IL_038a: Expected Obj, but got I
			//IL_036c: Expected Obj, but got I4
			//IL_039f: Expected Obj, but got I
			//IL_03b5: Expected Obj, but got I
			Seen seen = s;
			seen.pending = false;
			float unscaledTime = Time.unscaledTime;
			Seen seen2 = s;
			seen.at = unscaledTime;
			bool unpublished = value == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
			object obj3 = 0;
			seen2.unpublished = unpublished;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			HashSet<string> hashSet = Parse(value);
			object obj5 = seen2 + 16;
			obj5 = hashSet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj3;
			Seen seen3 = s;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long mutedUntil = GillaModeration.UntilOf(muted);
			Seen seen4 = s;
			seen3.mutedUntil = mutedUntil;
			long bannedUntil = GillaModeration.UntilOf(banned);
			object obj8 = obj;
			seen4.bannedUntil = bannedUntil;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v3+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v4+18]");
			bool flag3 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out var value2);
			bool flag4 = !flag3;
			object obj11 = !flag4;
			object obj12 = ~obj11;
			System.__Canon _Canon = ((obj12 != null) ? null : value2);
			object obj13 = s + 48;
			obj13 = _Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v22+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v11+18]");
			bool flag6 = ((Dictionary<System.__Canon, System.__Canon>)0).Remove((System.__Canon)(object)account);
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v29+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v29+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v29+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v29+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v17+2C]");
			object obj23 = (nint)0 + (nint)1;
		}

		internal void _003CAsk_003Eb__1(string error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I4
			Seen seen = s;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj3 = 0;
			seen.pending = false;
			string message = (string)obj + account + (string)obj2 + error;
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

		internal void _003CAsk_003Eb__2(string value)
		{
			//IL_001f: Expected Obj, but got I
			//IL_002f: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I
			Action<string, string, string> action = got;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<System.String, System.String, System.String>)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<System.String, System.String, System.String>)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`3<System.String, System.String, System.String>)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X5_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public const string Key = null;

	public const string Tag = null;

	public static float Again;

	public static float Stale;

	public static float MuteStale;

	private static readonly Dictionary<string, Seen> seen;

	private static readonly Dictionary<string, string> photonRead;

	public const string PhotonKey = null;

	public const string Republish = null;

	private const float AsksEvery = default(float);

	private const float AsksBurst = default(float);

	private const int MostSeen = default(int);

	private static float askTokens;

	private static float askTokensAt;

	private static bool? live;

	private static bool askingLive;

	private static int Version__BackingField;

	public static Action<string, Action<string, string, string>, Action<string>> ReadAccount;

	public static Action<string, Action<string>, Action<string>> Read;

	public static Func<bool?> Checking;

	public static int Version
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+2C]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
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

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0248: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_0127: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
		((Dictionary<System.__Canon, System.__Canon>)0).Clear();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5870]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v9+18]");
		((Dictionary<System.__Canon, System.__Canon>)0).Clear();
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+A0]");
		object obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BD90]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5868]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5890]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5880]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5888]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v10+A0]");
		object obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon, System.__Canon, System.__Canon> action = default;
		action._002Ector((object)null, (IntPtr)obj12);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+A0]");
		object obj18 = (nint)0 + (nint)48;
		obj18 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v17+A0]");
		object obj20 = (nint)0 + (nint)56;
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<bool?> func = default;
		func._002Ector((object)null, (IntPtr)obj14);
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+A0]");
		object obj22 = (nint)0 + (nint)64;
		obj22 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static int Filter(byte[] said, string account, bool trusted, byte[] shown)
	{
		//IL_0010: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I
		//IL_044d: Expected Obj, but got I
		//IL_0350: Expected I4, but got Obj
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_0094: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I8
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0402: Expected Obj, but got I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+40]");
		int num;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+28]");
			byte b = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ X8_v5+18] (should have been resolved before IL gen)");
			if (said != null)
			{
				object obj7 = default;
				object obj6 = obj7 & 0xFFFF;
				bool flag2 = (nint)obj6 < 256;
				object obj8 = !flag2;
				bool flag3 = (byte)(int)(~obj8) != 0;
				bool flag4 = (nint)obj6 < 255;
				object obj9 = !flag4;
				object obj10 = obj6 - 255;
				bool flag5 = obj10 == null;
				object obj11 = !flag5;
				object obj12 = obj9 & obj11;
				if (said.Length < 1)
				{
					num = 0;
					goto IL_0388;
				}
				object obj13 = obj12 & trusted;
				object obj14 = said.Length & 0xFFFFFFFFL;
				object obj15 = obj13 ^ 1;
				object obj16 = shown + 32;
				object obj17 = said + 32;
				object obj18 = 0;
				num = 0;
				while (shown != null)
				{
					object obj19 = shown.Length;
					if ((nint)obj18 < shown.Length)
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
						object obj20 = !flag6;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X29_v4+v86 @ X26_v5]");
							bool flag7 = (nint)0 == 0;
							object obj21 = !flag7;
							object obj22 = ~obj21;
							object obj23 = ((obj22 != null) ? ((object)1) : obj15);
							object obj24 = !flag7;
							object obj25 = ~obj24;
							bool flag8 = obj25 != null || flag3;
							object obj26 = obj23 & 1;
							bool flag9 = obj26 == null;
							object obj27 = !flag9;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
								object obj28 = 0;
								object obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v15+E4]");
								bool flag10 = (nint)0 == 0;
								object obj30 = !flag10;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X29_v4+v86 @ X26_v5]");
								flag8 = Allows(account, 0);
								obj19 = shown.Length;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X29_v4+v86 @ X26_v5]");
								b = 0;
							}
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							object obj31 = !flag11;
							if (obj31 == null)
							{
								bool flag12 = !flag8;
								object obj32 = !flag8;
								object obj33 = 1 & obj32;
								object obj34 = !flag12;
								object obj35 = ~obj34;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X29_v4+v86 @ X26_v5]");
									byte b2 = 0;
								}
								else
								{
									byte b2 = 0;
								}
								obj18++;
								obj14 = said.Length;
								num += obj33;
								if ((nint)obj18 < said.Length)
								{
									continue;
								}
								goto IL_0388;
							}
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
					goto IL_0388;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_0388:
		return num;
	}

	public unsafe static bool Allows(string account, byte id)
	{
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected I4, but got Unknown
		//IL_0052: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_05c0: Expected Obj, but got I
		//IL_0570: Expected I4, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I4
		//IL_0647: Expected Obj, but got I
		//IL_0666: Invalid comparison between F4 and Obj
		//IL_0196: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got Ref
		//IL_0312: Expected Obj, but got Ref
		//IL_03ce: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got I4
		//IL_0694: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I
		//IL_06cb: Invalid comparison between F4 and I
		//IL_0535: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_049a: Expected Obj, but got I4
		//IL_04de: Expected Obj, but got I4
		//IL_0709: Invalid comparison between F4 and Obj
		//IL_050e: Expected Obj, but got I
		int id2 = id & 0xFF;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
		bool flag = entry == null;
		CosmeticCatalog.Entry entry2 = entry;
		if (flag)
		{
			goto IL_0404;
		}
		if (string.IsNullOrEmpty(account))
		{
			goto IL_002f;
		}
		float unscaledTime = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v10+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v5+10]");
		System.__Canon value;
		object s;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v5+10]");
			if (((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out value))
			{
				if (value != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
						object obj6 = 0;
						System.__Canon name = (System.__Canon)(object)entry.name;
						System.__Canon _Canon = (System.__Canon)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+10]");
						if (((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.name))
						{
							entry2 = (CosmeticCatalog.Entry)1;
						}
						else
						{
							if (!string.IsNullOrEmpty(entry.comesWith))
							{
								if (value != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+10]");
									if ((nint)0 != 0)
									{
										name = (System.__Canon)(object)entry.comesWith;
										_Canon = (System.__Canon)obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+10]");
										bool flag3 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)entry.comesWith);
										entry2 = (CosmeticCatalog.Entry)flag3;
										goto IL_05e5;
									}
								}
								goto IL_0562;
							}
							name = null;
							entry2 = null;
						}
						goto IL_05e5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+40]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v27+E4]");
						bool flag5 = (nint)0 == 0;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj8 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v27+A0]");
						object obj10 = 0;
						float num = unscaledTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+3C]");
						float num2 = num - 0f;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v27+E4]");
							bool flag6 = (nint)0 == 0;
							object obj11 = !flag6;
							System.__Canon _Canon = (System.__Canon)(&value);
							s = value;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								_Canon = (System.__Canon)(&value);
								s = value;
							}
							goto IL_067a;
						}
					}
					goto IL_002f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58B0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj13 = default;
				obj13._002Ector();
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v21+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj14 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v21+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v14+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v14+10]");
					((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)account, (System.__Canon)obj13);
					System.__Canon _Canon = (System.__Canon)obj13;
					s = obj13;
					goto IL_067a;
				}
			}
		}
		goto IL_0562;
		IL_002f:
		entry2 = null;
		goto IL_0404;
		IL_05e5:
		if (value == null)
		{
			goto IL_0562;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+40]");
		if ((nint)0 != 0)
		{
			goto IL_0404;
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v37+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v37+A0]");
		object obj19 = 0;
		float num3 = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+38]");
		float num4 = num3 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v25+4]");
		object obj20 = 0;
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v25+4]");
		if (num5 < 0f)
		{
			object obj21 = entry2 & 1;
			if (obj21 != null)
			{
				entry2 = (CosmeticCatalog.Entry)1;
				goto IL_0404;
			}
			if (value == null)
			{
				goto IL_0562;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v37+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v37+A0]");
				obj19 = 0;
			}
			float num6 = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-28_v4 (System.__Canon)+3C]");
			num4 = num6 - 0f;
			obj20 = obj19;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
			{
				goto IL_002f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v37+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		s = value;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			s = value;
		}
		goto IL_071d;
		IL_071d:
		Ask(account, (Seen)s);
		goto IL_0404;
		IL_0404:
		return (byte)(entry2 & 1) != 0;
		IL_067a:
		entry2 = null;
		goto IL_071d;
		IL_0562:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static HashSet<string> Known(string account)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+10]");
			if (!((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out var value))
			{
				return null;
			}
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-28_v3 (System.__Canon)+10]");
				return (HashSet<string>)0;
			}
		}
		return (HashSet<string>)(object)new NullReferenceException();
	}

	public static string PhotonOf(string account)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_0275: Invalid comparison between F4 and Obj
		//IL_021a: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Seen seen = Entry(account);
		bool flag2 = seen == null;
		string result = (string)(object)seen;
		if (!flag2)
		{
			if (seen.names != null)
			{
				float unscaledTime = Time.unscaledTime;
				bool flag3 = (byte)(~(seen.pending ? 1u : 0u)) != 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					object obj5 = obj;
					object obj8;
					if (seen.photon != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
						bool flag4 = (nint)0 == 0;
						object obj6 = !flag4;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj5 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+4]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						obj8 = num * 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
						bool flag5 = (nint)0 == 0;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj5 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
						object obj10 = 0;
						obj8 = obj10;
					}
					float num2 = unscaledTime - seen.asked;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
						bool flag6 = (nint)0 == 0;
						object obj11 = !flag6;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Ask(account, seen);
					}
				}
				result = seen.photon;
			}
			else
			{
				result = null;
			}
		}
		return result;
	}

	public static bool HasItem(string account, string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Seen seen = Entry(account);
		if (seen != null && seen.names != null)
		{
			return ((HashSet<System.__Canon>)(object)seen.names).Contains((System.__Canon)(object)item);
		}
		return false;
	}

	public static bool Republished(string account)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F0]");
		object item = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return HasItem(account, (string)item);
	}

	public static bool ServerMutedIfKnown(string account)
	{
		//IL_0329: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I
		//IL_0302: Expected I4, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I8
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected I8, but got Unknown
		//IL_02da: Expected Obj, but got I4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected I4, but got Unknown
		bool flag = string.IsNullOrEmpty(account);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v8+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X8_v7+18] (should have been resolved before IL gen)");
				object obj8 = default;
				object obj7 = obj8 & 0xFFFF;
				bool flag4 = (nint)obj7 < 256;
				object obj9 = !flag4;
				object obj10 = ~obj9;
				if (obj10 != null)
				{
					goto IL_023a;
				}
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v14+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11+10]");
					if (!((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out var value))
					{
						goto IL_023a;
					}
					if (value != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-18_v5 (System.__Canon)+10]");
						if ((nint)0 == 0)
						{
							goto IL_023a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v17+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						long serverNowMs = GillaModeration.ServerNowMs;
						if (value != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-18_v5 (System.__Canon)+20]");
							if (0 > serverNowMs)
							{
								return true;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-18_v5 (System.__Canon)+28]");
							object obj18 = -serverNowMs;
							bool flag7 = (nint)obj18 < 0;
							bool flag8 = obj18 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-18_v5 (System.__Canon)+28]");
							long num = 0 ^ serverNowMs;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-18_v5 (System.__Canon)+28]");
							object obj19 = 0 ^ obj18;
							long num2 = num & obj19;
							bool flag9 = num2 < 0;
							bool flag10 = flag7 == flag9;
							object obj20 = !flag8;
							return (byte)((flag10 & obj20) ? 1 : 0) != 0;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_023a;
		IL_023a:
		return false;
	}

	private static Seen Entry(string account)
	{
		//IL_02d2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_0384: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I
		//IL_034e: Invalid comparison between F4 and Obj
		//IL_01c2: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(account);
		bool flag2 = !flag;
		object obj = !flag2;
		Seen result = null;
		object s;
		object obj14 = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v6+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v6+10]");
				if (((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out var value))
				{
					if (value != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ stack_-38_v4 (System.__Canon)+10]");
						bool flag4 = (nint)0 == 0;
						object obj7 = !flag4;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ stack_-38_v4 (System.__Canon)+40]");
							bool flag5 = (nint)0 == 0;
							object obj8 = !flag5;
							if (obj8 == null)
							{
								float unscaledTime = Time.unscaledTime;
								if (value == null)
								{
									goto IL_029d;
								}
								object obj9 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v25+E4]");
								bool flag6 = (nint)0 == 0;
								object obj10 = !flag6;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj9 = obj2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v25+A0]");
								object obj11 = 0;
								float num = unscaledTime;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ stack_-38_v4 (System.__Canon)+3C]");
								float num2 = num - 0f;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v25+E4]");
									bool flag7 = (nint)0 == 0;
									object obj12 = !flag7;
									s = value;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										s = value;
									}
									goto IL_0362;
								}
							}
						}
						goto IL_0290;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58B0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj14._002Ector();
					object obj15 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v19+E4]");
					bool flag8 = (nint)0 == 0;
					object obj16 = !flag8;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v19+A0]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v15+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v15+10]");
						((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)account, (System.__Canon)obj14);
						s = obj14;
						goto IL_0362;
					}
				}
			}
			goto IL_029d;
		}
		goto IL_02e5;
		IL_029d:
		return (Seen)(object)new NullReferenceException();
		IL_0362:
		Ask(account, (Seen)s);
		goto IL_0290;
		IL_0290:
		result = (Seen)obj14;
		goto IL_02e5;
		IL_02e5:
		return result;
	}

	public static bool ServerMuted(string account)
	{
		//IL_0516: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I
		//IL_0544: Expected Obj, but got I
		//IL_04ef: Expected I4, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_05ae: Expected Obj, but got I
		//IL_05d5: Invalid comparison between F4 and Obj
		//IL_044a: Expected Obj, but got I8
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected I8, but got Unknown
		//IL_04c7: Expected Obj, but got I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected I4, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0648: Expected Obj, but got I
		//IL_0658: Invalid comparison between F4 and I
		//IL_0297: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(account);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			goto IL_0427;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+40]");
		System.__Canon value;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X8_v7+18] (should have been resolved before IL gen)");
			object obj8 = default;
			object obj7 = obj8 & 0xFFFF;
			bool flag4 = (nint)obj7 < 256;
			object obj9 = !flag4;
			object obj10 = ~obj9;
			if (obj10 != null)
			{
				goto IL_0427;
			}
			float unscaledTime = Time.unscaledTime;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v15+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v11+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v11+10]");
				if (((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)account, out value))
				{
					if (value != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+40]");
						bool flag6 = (nint)0 == 0;
						object obj15 = !flag6;
						float num = unscaledTime;
						Seen seen = (Seen)(object)account;
						if (obj15 == null)
						{
							object obj16 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v40+E4]");
							bool flag7 = (nint)0 == 0;
							object obj17 = !flag7;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj16 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v40+A0]");
							object obj18 = 0;
							float num2 = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+3C]");
							num = num2 - 0f;
							object obj19 = obj18;
							bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
							seen = (Seen)(object)account;
							if (!flag8)
							{
								if (value == null)
								{
									goto IL_04e1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+10]");
								bool flag9 = (nint)0 == 0;
								System.__Canon _Canon = value;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v40+E4]");
									bool flag10 = (nint)0 == 0;
									object obj20 = !flag10;
									if (obj20 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj16 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v40+A0]");
										obj18 = 0;
									}
									float num3 = unscaledTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+38]");
									num = num3 - 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v30+8]");
									obj19 = 0;
									float num4 = num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v30+8]");
									bool flag11 = num4 < 0f;
									seen = (Seen)(object)account;
									if (flag11)
									{
										goto IL_02d2;
									}
									_Canon = value;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v40+E4]");
								bool flag12 = (nint)0 == 0;
								object obj21 = !flag12;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Ask(account, (Seen)(object)_Canon);
								seen = (Seen)(object)_Canon;
							}
						}
						goto IL_02d2;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58B0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj23 = default;
					obj23._002Ector();
					object obj24 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v21+E4]");
					bool flag13 = (nint)0 == 0;
					object obj25 = !flag13;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v21+A0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v17+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v17+10]");
						((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)account, (System.__Canon)obj23);
						Ask(account, (Seen)obj23);
						goto IL_0427;
					}
				}
			}
		}
		goto IL_04e1;
		IL_0427:
		return false;
		IL_04e1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj29 = !flag14;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long serverNowMs = GillaModeration.ServerNowMs;
		if (value != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+20]");
			if (0 > serverNowMs)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+28]");
			object obj30 = -serverNowMs;
			bool flag15 = (nint)obj30 < 0;
			bool flag16 = obj30 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+28]");
			long num5 = 0 ^ serverNowMs;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-38_v5 (System.__Canon)+28]");
			object obj31 = 0 ^ obj30;
			long num6 = num5 & obj31;
			bool flag17 = num6 < 0;
			bool flag18 = flag15 == flag17;
			object obj32 = !flag16;
			return (byte)((flag18 & obj32) ? 1 : 0) != 0;
		}
		goto IL_04e1;
	}

	private static void Ask(string account, Seen s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I
		//IL_04bc: Invalid comparison between F4 and I4
		//IL_04cb: Invalid comparison between F4 and I4
		//IL_04e3: Expected Obj, but got F8
		//IL_04f0: Expected Obj, but got F4
		//IL_0525: Expected Obj, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0160: Expected F4, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_02ab: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I4
		//IL_0586: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I4
		//IL_0405: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_05e7: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = s;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2 + 24;
		obj5 = account;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v12+A0]");
		object obj8 = 0;
		object obj9 = obj4;
		float num = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+24]");
		float num2 = num - 0f;
		float num3 = num2 + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+20]");
		float num4 = 0f + num3;
		float num5 = num4 - 20f;
		bool flag2 = num5 < 0f;
		bool flag3 = num5 == 0f;
		object obj10 = (double)num4 ^ 20.0;
		object obj11 = num4 ^ num5;
		object obj12 = obj10 & obj11;
		bool flag4 = (nint)obj12 < 0;
		bool flag5 = flag2 == flag4;
		object obj13 = !flag3;
		object obj14 = flag5 & obj13;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			num4 = 20f;
		}
		if ((double)num4 < 1.0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v28+A0]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+20]");
			num4 = 0f;
		}
		float num6 = num4 + -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58D0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+10]");
		int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
		if (count >= 401)
		{
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v37+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Trim();
		}
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C8]");
		object obj22 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58D8]");
		object obj23 = 0;
		Action<System.__Canon, System.__Canon, System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj23);
		object obj24 = obj2 + 32;
		obj24 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58E0]");
		object obj26 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj26);
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v24+E4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v24+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v18+38]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v18+38]");
		object obj35;
		object obj36;
		object obj37;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v24+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v25+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v26+38]");
				obj30 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58E8]");
			object obj34 = 0;
			Action<System.__Canon> action3 = default;
			action3._002Ector(obj2, (IntPtr)obj34);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X25_v5+40]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X25_v5+28]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X25_v5+18]");
			obj37 = 0;
			goto IL_05ec;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj38 = !flag10;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj39 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v20+A0]");
			obj29 = 0;
		}
		goto IL_05f6;
		IL_05f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v18+30]");
		object obj40 = 0;
		object obj41 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v19+40]");
		obj35 = 0;
		Action<System.__Canon> action4 = (Action<System.__Canon>)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v19+28]");
		obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v19+18]");
		obj37 = 0;
		goto IL_05ec;
		IL_05ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v196 @ X5_v1 (should have been resolved before IL gen)");
		goto IL_05f6;
	}

	private static void Trim()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_0563: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I
		//IL_0385: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0466: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got VT
		//IL_01f6: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5940]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5928]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5960]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
		List<KeyValuePair<System.__Canon, System.__Canon>> list = default;
		list._002Ector((IEnumerable<KeyValuePair<System.__Canon, System.__Canon>>)0);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v27+8]");
		Predicate<KeyValuePair<System.__Canon, System.__Canon>> match = (Predicate<KeyValuePair<System.__Canon, System.__Canon>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v27+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v31+A0]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5948]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5950]");
			object obj15 = 0;
			Predicate<KeyValuePair<System.__Canon, System.__Canon>> predicate = default;
			predicate._002Ector(obj10, (IntPtr)obj15);
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v30+A0]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			match = predicate;
			object obj18 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5918]");
		object obj19 = 0;
		int num = list.RemoveAll(match);
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v14+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v20+10]");
		Comparison<KeyValuePair<System.__Canon, System.__Canon>> comparison = (Comparison<KeyValuePair<System.__Canon, System.__Canon>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5920]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v20+10]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v14+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v24+A0]");
				obj22 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5900]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5958]");
			object obj28 = 0;
			Comparison<KeyValuePair<System.__Canon, System.__Canon>> comparison2 = default;
			comparison2._002Ector(obj22, (IntPtr)obj28);
			object obj29 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v23+A0]");
			object obj30 = (nint)0 + (nint)16;
			obj30 = comparison2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			comparison = comparison2;
			object obj18 = 0;
		}
		object obj31 = obj23;
		list.Sort(comparison);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.__Canon, System.__Canon>>)+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5908]");
		object obj32 = 0;
		int num2 = 0;
		Comparison<KeyValuePair<System.__Canon, System.__Canon>> comparison3 = comparison;
		bool flag12;
		do
		{
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj34 = !flag8;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v20+A0]");
			object obj35 = 0;
			KeyValuePair<System.__Canon, System.__Canon> keyValuePair = list.get_Item(num2);
			obj31 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+10]");
			bool flag9 = ((Dictionary<System.__Canon, System.__Canon>)0).Remove((System.__Canon)keyValuePair);
			bool flag10 = num2 < 98;
			object obj36 = !flag10;
			object obj37 = num2 - 98;
			bool flag11 = obj37 == null;
			object obj38 = !flag11;
			object obj39 = obj36 & obj38;
			if (obj39 == null)
			{
				num2++;
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.__Canon, System.__Canon>>)+18]");
				flag12 = (nint)num3 < (nint)0;
				comparison3 = (Comparison<KeyValuePair<System.__Canon, System.__Canon>>)keyValuePair;
				continue;
			}
			break;
		}
		while (flag12);
	}

	public static HashSet<string> Parse(string value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		bool flag = string.IsNullOrEmpty(value);
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			goto IL_0244;
		}
		if (value != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5968]");
			object obj3 = 0;
			if (!value.StartsWith((string)obj3))
			{
				goto IL_0244;
			}
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v6+10]");
				string text = value.Substring(0);
				if (text != null)
				{
					string[] array = text.Split(',', (StringSplitOptions)0);
					if (array != null)
					{
						object obj5 = array.Length;
						if (array.Length < 1)
						{
							goto IL_0244;
						}
						object obj6 = 0;
						while (true)
						{
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
							object obj7 = !flag3;
							if (obj7 != null)
							{
								break;
							}
							object obj8 = (object)array + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v9+20]");
							string text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v9+20]");
							if ((nint)0 != 0)
							{
								if (text2._stringLength >= 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v9+20]");
									string item = ((string)0).Trim();
									if (hashSet == null)
									{
										goto IL_0249;
									}
									bool flag4 = hashSet.Add((System.__Canon)(object)item);
								}
								obj5 = array.Length;
								obj6++;
								if ((nint)obj6 < array.Length)
								{
									continue;
								}
								goto IL_0244;
							}
							goto IL_0249;
						}
						goto IL_0257;
					}
				}
			}
		}
		goto IL_0249;
		IL_0249:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0257;
		IL_0257:
		return (HashSet<string>)(object)new IndexOutOfRangeException();
		IL_0244:
		return (HashSet<string>)(object)hashSet;
	}

	private static bool? CheckingNow()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_0589: Expected Obj, but got I
		//IL_02e8: Expected VT, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I
		//IL_0574: Expected VT, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I4
		//IL_0628: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I4
		//IL_0646: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_0678: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_047d: Expected I, but got Obj
		//IL_048e: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_04f5: Expected I, but got Obj
		//IL_0506: Expected I, but got Obj
		//IL_0524: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v18+28]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+A0]");
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v18+2A]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+E4]");
					bool flag7 = (nint)0 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj15 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v37+A0]");
						obj10 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5960]");
					object obj16 = 0;
					_ = 1;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+A0]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v31+18]");
					Action<string, string, string> action = (Action<string, string, string>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v31+18]");
					bool flag9 = (nint)0 == 0;
					object obj20 = !flag9;
					Action<string> action2 = default;
					nint num = (nint)action2;
					Action<string, string, string> action4;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+E4]");
						bool flag10 = (nint)0 == 0;
						object obj21 = !flag10;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj22 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v35+A0]");
							obj19 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C8]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5980]");
						object obj24 = 0;
						num = (nint)obj24;
						Action<System.__Canon, System.__Canon, System.__Canon> action3 = default;
						action3._002Ector(obj19, (IntPtr)obj24);
						object obj25 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v34+A0]");
						object obj26 = (nint)0 + (nint)24;
						obj26 = action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj17 = obj16;
						object obj27 = 0;
						action4 = (Action<string, string, string>)action3;
						action = (Action<string, string, string>)action3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj28 = !flag11;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+A0]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v25+20]");
					Action<string> failed = (Action<string>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v25+20]");
					bool flag12 = (nint)0 == 0;
					object obj30 = !flag12;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v22+E4]");
						bool flag13 = (nint)0 == 0;
						object obj31 = !flag13;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj32 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v29+A0]");
							obj29 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5988]");
						object obj34 = 0;
						num = (nint)obj34;
						Action<System.__Canon> action5 = default;
						action5._002Ector(obj29, (IntPtr)obj34);
						object obj35 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v28+A0]");
						object obj36 = (nint)0 + (nint)32;
						obj36 = action5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj27 = 0;
						action4 = (Action<string, string, string>)(object)action5;
						failed = (Action<string>)action5;
					}
					object obj37 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v24+E4]");
					bool flag14 = (nint)0 == 0;
					object obj38 = !flag14;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					ReadFromPlayFab(null, action, failed);
					obj8 = obj7;
					action4 = action;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+E4]");
			bool flag15 = (nint)0 == 0;
			object obj39 = !flag15;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v13+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v16+28]");
			return (bool?)(object)0;
		}
		bool? flag16 = false;
		return (bool?)(object)0;
	}

	private static void ReadFromPlayFab(string account, Action<string, string, string> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_035c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0411: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_047d: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_0544: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I
		//IL_0564: Expected Obj, but got I
		//IL_0574: Expected Obj, but got I
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_05f1: Expected I, but got Obj
		//IL_0611: Expected I, but got Obj
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_0640: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5990]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = account;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = done;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2 + 32;
		Action<string> action = default;
		obj7 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59C8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj9 = 0;
		System.__Canon[] items = list._items;
		object obj10 = obj9;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D8]");
		object obj11 = 0;
		bool flag = list._size < items.Length;
		object obj12 = !flag;
		if (obj12 == null)
		{
			object obj13 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj14 = obj13 + 32;
			obj14 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X9_v4+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v19+A8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v20+70]");
			action = (Action<string>)0;
			list.AddWithResize((System.__Canon)obj8);
		}
		System.__Canon[] items2 = list._items;
		object obj17 = obj9;
		int version2 = list._version + 1;
		list._version = version2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59E0]");
		object obj18 = 0;
		bool flag2 = list._size < items2.Length;
		object obj19 = !flag2;
		if (obj19 == null)
		{
			object obj20 = items2 + list._size;
			int size2 = list._size + 1;
			list._size = size2;
			object obj21 = obj20 + 32;
			obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v6+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+A8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v18+70]");
			action = (Action<string>)0;
			list.AddWithResize((System.__Canon)obj11);
		}
		System.__Canon[] items3 = list._items;
		object obj24 = obj9;
		int version3 = list._version + 1;
		list._version = version3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59D0]");
		object obj25 = 0;
		bool flag3 = list._size < items3.Length;
		object obj26 = !flag3;
		if (obj26 == null)
		{
			object obj27 = items3 + list._size;
			int size3 = list._size + 1;
			list._size = size3;
			object obj28 = obj27 + 32;
			obj28 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v8+20]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v15+A8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16+70]");
			action = (Action<string>)0;
			list.AddWithResize((System.__Canon)obj18);
		}
		System.__Canon[] items4 = list._items;
		object obj31 = obj9;
		int version4 = list._version + 1;
		list._version = version4;
		bool flag4 = list._size < items4.Length;
		object obj32 = !flag4;
		if (obj32 == null)
		{
			object obj33 = items4 + list._size;
			int size4 = list._size + 1;
			list._size = size4;
			object obj34 = obj33 + 32;
			obj34 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v10+20]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v13+A8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v14+70]");
			action = (Action<string>)0;
			list.AddWithResize((System.__Canon)obj25);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59C0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj41 = 0;
		object obj42 = getUserDataRequest + 32;
		obj42 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (obj5 != null)
		{
			object obj43 = getUserDataRequest + 40;
			obj43 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector(obj2, (IntPtr)obj38);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action3 = default;
		action3._002Ector(obj2, (IntPtr)obj40);
		object obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v30+E4]");
		bool flag5 = (nint)0 == 0;
		object obj45 = !flag5;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserReadOnlyData(getUserDataRequest, (Action<GetUserDataResult>)action2, (Action<PlayFabError>)action3);
	}

	static GillaOwned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_0147: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5868]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5890]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5880]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5888]");
		object obj7 = 0;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B340]");
		obj9 = 0;
		_ = 1123024896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+A0]");
		object obj11 = (nint)0 + (nint)16;
		obj11 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		dictionary2._002Ector();
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6+A0]");
		object obj13 = (nint)0 + (nint)24;
		obj13 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+A0]");
		object obj15 = 0;
		_ = 1101004800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon, System.__Canon, System.__Canon> action = default;
		action._002Ector((object)null, (IntPtr)obj5);
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v9+A0]");
		object obj17 = (nint)0 + (nint)48;
		obj17 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<bool?> func = default;
		func._002Ector((object)null, (IntPtr)obj7);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+A0]");
		object obj19 = (nint)0 + (nint)64;
		obj19 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
