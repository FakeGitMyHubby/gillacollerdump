using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using PlayFab;
using UnityEngine;

public class GillaBotReport : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string label;

		internal bool _003CSells_003Eb__0(GillaBoltShop.Item i)
		{
			//IL_0048: Expected I4, but got Obj
			if (i != null)
			{
				return i.label == label;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private class Waiting
	{
		public string kind;

		public string what;

		public string how;

		public string caller;

		public string by;

		public int count = 1;

		public int tries;

		public float notBefore;
	}

	[Serializable]
	private class Answer
	{
		public bool ok;

		public string refused;

		public long wait;
	}

	public const string Monster = null;

	public const string Anonymous = null;

	public const string GameCode = null;

	public const string LobbyCode = null;

	public const string LoadScene = null;

	private const int MostCodes = default(int);

	public const float Gap = default(float);

	private const int MostWaiting = default(int);

	private const int MostTries = default(int);

	private const float RetryAfter = default(float);

	private const float KeepEvery = default(float);

	private static readonly List<Waiting> waiting;

	private static readonly Dictionary<string, float> sentAt;

	private static GillaBotReport pump;

	private static bool sending;

	private static bool toldNoScript;

	private float nextKeep;

	private static string LastSent__BackingField;

	private static int Sent__BackingField;

	private static int Dropped__BackingField;

	private static string LastAnswer__BackingField;

	public static string LastSent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static int Sent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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

	public static int Dropped
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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

	public static int WaitingCount
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0071: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I
			//IL_0047: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public static string LastAnswer
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+18]");
			Array.Clear((Array)num, 0, 0);
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v27+A0]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6+8]");
		((Dictionary<System.__Canon, float>)0).Clear();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+A0]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+A0]");
		object obj12 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+A0]");
		object obj14 = (nint)0 + (nint)48;
		obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v19+A0]");
		object obj17 = (nint)0 + (nint)32;
		obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+A0]");
		object obj20 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v27+A0]");
		object obj22 = 0;
		_ = 0;
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v1+10]");
		if (!((UnityEngine.Object)0 != null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDF0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj9);
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDE8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v11+A0]");
			object obj15 = (nint)0 + (nint)16;
			object obj16 = default;
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public unsafe static void LobbyCodeTyped(string code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b77: Expected I, but got Obj
		//IL_0b87: Expected Obj, but got I
		//IL_0ba9: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_016b: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_0bc7: Expected Obj, but got I
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got I4
		//IL_0bf9: Expected Obj, but got Ref
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Ref
		//IL_0c27: Expected I4, but got Obj
		//IL_0685: Expected Obj, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected Obj, but got I4
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got I4
		//IL_06be: Expected Obj, but got I4
		//IL_0c59: Expected I4, but got Obj
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Expected Ref, but got Unknown
		//IL_0c7c: Expected Obj, but got I4
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got I4
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I4
		//IL_0741: Expected I, but got Obj
		//IL_0763: Expected Obj, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got I4
		//IL_0320: Expected I4, but got Obj
		//IL_0c9a: Expected Obj, but got I
		//IL_078b: Expected I, but got Obj
		//IL_0365: Expected Obj, but got I
		//IL_0b09: Expected Obj, but got I4
		//IL_0b12: Expected Obj, but got I4
		//IL_0384: Expected Obj, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got I4
		//IL_03e8: Expected I4, but got Obj
		//IL_0b69: Expected Obj, but got I4
		//IL_09ba: Expected Obj, but got I4
		//IL_07d7: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_0d92: Expected I, but got Obj
		//IL_0db4: Expected Obj, but got I4
		//IL_0ccf: Expected Obj, but got I
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected Obj, but got Unknown
		//IL_0e35: Expected Obj, but got I
		//IL_0e4b: Expected Obj, but got I
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_0853: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I4
		//IL_07f7: Expected I, but got Obj
		//IL_0807: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got I4
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got I4
		//IL_0667: Expected Obj, but got I4
		//IL_04a2: Expected Obj, but got I4
		//IL_0dec: Expected Obj, but got I4
		//IL_09ee: Expected I, but got Obj
		//IL_088b: Expected Obj, but got I
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I4
		//IL_0e60: Expected Obj, but got I
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected Obj, but got Unknown
		//IL_0d3d: Expected Obj, but got I
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0d65: Expected I4, but got Obj
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got I4
		//IL_0524: Expected I4, but got Obj
		//IL_0531: Expected Obj, but got I4
		//IL_0a05: Expected I, but got Obj
		//IL_057c: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I4
		//IL_092e: Expected Obj, but got I4
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj = 0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2 (Il2CppClass<System.Object>)+E4]");
		System.__Canon[] array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2 (Il2CppClass<System.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Clean(code, 16);
		bool flag2 = text == null;
		System.__Canon[] array3 = default;
		System.__Canon[] array2 = array3;
		Enumerator<, > val = (Enumerator<, >)0;
		int num2 = 16;
		string text2 = code;
		bool flag3 = false;
		if (!flag2)
		{
			string text3 = text.ToUpperInvariant();
			bool flag4 = text3 == null;
			array2 = array3;
			val = (Enumerator<, >)0;
			num2 = 0;
			text2 = code;
			flag3 = false;
			if (!flag4)
			{
				if (text3._stringLength == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v79+E4]");
				bool flag5 = (nint)0 == 0;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = GillaModeration.ClosedNow(text3, out var until, out var why);
				nint num3 = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v47 (Il2CppClass<System.Object>)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj6 = !flag7;
				nint num4 = num3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num4 = (nint)obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v48 (Il2CppClass<System.Object>)+A0]");
				array = (System.__Canon[])0;
				bool flag8 = array == null;
				array2 = array3;
				val = (Enumerator<, >)0;
				object obj7 = 0;
				string text4 = (string)(&why);
				num2 = (int)(&until);
				text2 = text3;
				flag3 = flag6;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE00]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE40]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDF8]");
					object obj10 = 0;
					Enumerator<, > enumerator = ((List<System.__Canon>)(object)array).GetEnumerator();
					text4 = (string)(&why);
					array = array3;
					Enumerator<, > val2 = default;
					List<System.__Canon> list = default;
					object obj19 = default;
					object obj27 = default;
					while (true)
					{
						num2 = (int)obj8;
						object obj11;
						Enumerator<, > val4;
						object obj17;
						object obj18;
						if (val.MoveNext())
						{
							Enumerator<, > val3;
							if (array3 == null)
							{
								NullReferenceException ex = new NullReferenceException();
								array2 = null;
								val = val2;
								obj11 = 0;
								val3 = val2;
								val4 = (Enumerator<, >)(ref val);
								obj7 = 0;
								text2 = text3;
								flag3 = flag6;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-88 (System.__Canon[])+10]");
							bool flag9 = (string)0 == (string)obj9;
							bool flag10 = !flag9;
							text4 = null;
							if (flag10)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-88 (System.__Canon[])+3C]");
							array = (System.__Canon[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-88 (System.__Canon[])+3C]");
							bool flag11 = (nint)0 == 0;
							object obj12 = !flag11;
							text4 = null;
							if (obj12 != null)
							{
								continue;
							}
							object obj13 = array3 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X23_v15+20]");
							array = (System.__Canon[])((nint)0 + (nint)1);
							bool flag12 = obj13 == null;
							array2 = null;
							val = val2;
							obj11 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj7 = 0;
							text4 = null;
							num2 = (int)obj9;
							text2 = text3;
							flag3 = flag6;
							if (flag12)
							{
								goto IL_0a95;
							}
							string[] array4 = ((string)obj13).Split(' ', (StringSplitOptions)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE20]");
							array = (System.__Canon[])0;
							text4 = (string)(object)array;
							list._002Ector((IEnumerable<System.__Canon>)(object)array4);
							bool flag13 = list == null;
							List<System.__Canon> list2 = list;
							array2 = null;
							val = val2;
							obj11 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj7 = 0;
							num2 = (int)array4;
							text2 = text3;
							flag3 = flag6;
							if (flag13)
							{
								goto IL_0aa3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8B10]");
							int num5 = 0;
							text4 = (string)((int*)num5)->m_value;
							bool flag14 = list.Contains((System.__Canon)(object)text3);
							bool flag15 = !flag14;
							object obj15 = !flag15;
							list2 = list;
							obj7 = 0;
							if (obj15 == null)
							{
								num5 = list._size;
								bool flag16 = list._size > 7;
								list2 = list;
								obj7 = 0;
								if (!flag16)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
									list2 = (List<System.__Canon>)0;
									string text5 = (string)obj13 + (string)(object)list2 + text3;
									bool flag17 = text5 == null;
									array2 = null;
									val = val2;
									obj11 = 0;
									val3 = val2;
									val4 = (Enumerator<, >)(ref val);
									obj7 = 0;
									text4 = text3;
									num2 = (int)list2;
									array = (System.__Canon[])list._size;
									text2 = text3;
									flag3 = flag6;
									if (flag17)
									{
										goto IL_0ab1;
									}
									num5 = text5._stringLength;
									bool flag18 = text5._stringLength > 80;
									obj7 = 0;
									text4 = text3;
									if (!flag18)
									{
										string text6 = (string)obj13 + (string)(object)list2 + text3;
										obj13 = text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										obj7 = 0;
										text4 = text3;
									}
								}
							}
							if (flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE30]");
								num5 = 0;
								object obj16 = array3 + 32;
								obj16 = ((int*)num5)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							obj17 = 0;
							array2 = null;
							val = val2;
							obj11 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj18 = 7;
							array = (System.__Canon[])num5;
							text2 = text3;
							flag3 = flag6;
						}
						else
						{
							obj17 = 0;
							array2 = null;
							val = val2;
							obj11 = 0;
							Enumerator<, > val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj18 = 8;
							obj7 = 0;
							text2 = text3;
							flag3 = flag6;
						}
						goto IL_0c51;
						IL_0aa3:
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_0ab1;
						IL_0ab1:
						NullReferenceException ex3 = new NullReferenceException();
						if (num2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj17 = obj11;
							array2 = (System.__Canon[])1;
							array = (System.__Canon[])1;
						}
						else
						{
							if (num2 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FB20");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj17 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj11 = obj19;
						}
						obj18 = 0;
						goto IL_0c51;
						IL_0c51:
						num2 = (int)obj10;
						((Enumerator<, >*)val4)->Dispose();
						bool flag19 = obj17 == null;
						object obj20 = !flag19;
						if (obj20 == null)
						{
							bool flag20 = array2 == null;
							object obj21 = !flag20;
							OutOfMemoryException ex4 = (OutOfMemoryException)val4;
							array = array2;
							if (obj21 == null)
							{
								object obj22 = obj18 | 8;
								if ((nint)obj22 != 8)
								{
									return;
								}
								nint num6 = (nint)obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v8 (Il2CppClass<System.Object>)+E4]");
								bool flag21 = (nint)0 == 0;
								object obj23 = !flag21;
								nint num7 = num6;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									num7 = (nint)obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v9 (Il2CppClass<System.Object>)+A0]");
								array = (System.__Canon[])0;
								List<System.__Canon> list3 = (List<System.__Canon>)(object)array;
								if (array == null)
								{
									break;
								}
								if (list3._size < 16)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v9 (Il2CppClass<System.Object>)+E4]");
									bool flag22 = (nint)0 == 0;
									object obj24 = !flag22;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										nint num8 = (nint)obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v32 (Il2CppClass<System.Object>)+A0]");
										object obj25 = 0;
										list3 = (List<System.__Canon>)obj25;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE28]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									_ = 1;
									obj27._002Ector();
									object obj28 = obj27 + 16;
									obj28 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj29 = obj27 + 24;
									obj29 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag23 = !flag3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE30]");
									array = (System.__Canon[])0;
									object obj30 = !flag23;
									object obj31 = ~obj30;
									if (obj31 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE38]");
										array = (System.__Canon[])0;
									}
									object obj32 = obj27 + 32;
									obj32 = array;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									text2 = (string)0;
									object obj33 = obj27 + 40;
									obj33 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num2 = (int)text2;
									object obj34 = obj27 + 48;
									obj34 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag24 = list3 == null;
									obj = obj27;
									if (flag24)
									{
										break;
									}
									array = list3._items;
									int version = list3._version + 1;
									list3._version = version;
									bool flag25 = list3._items == null;
									obj = obj27;
									if (flag25)
									{
										break;
									}
									bool flag26 = list3._size < array.Length;
									object obj35 = !flag26;
									if (obj35 == null)
									{
										object obj36 = list3._items + list3._size;
										int size = list3._size + 1;
										list3._size = size;
										object obj37 = obj36 + 32;
										obj37 = obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									}
									else
									{
										list3.AddWithResize((System.__Canon)obj27);
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v9 (Il2CppClass<System.Object>)+E4]");
									bool flag27 = (nint)0 == 0;
									object obj38 = !flag27;
									if (obj38 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									nint num9 = (nint)obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v12 (Il2CppClass<System.Object>)+E4]");
									bool flag28 = (nint)0 == 0;
									object obj39 = !flag28;
									nint num10 = num9;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										num10 = (nint)obj;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X0_v14 (Il2CppClass<System.Object>)+A0]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v13+2C]");
									object obj41 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X0_v14 (Il2CppClass<System.Object>)+E4]");
									bool flag29 = (nint)0 == 0;
									object obj42 = !flag29;
									nint num11 = num10;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										num11 = (nint)obj;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v15 (Il2CppClass<System.Object>)+A0]");
									object obj43 = 0;
								}
								return;
							}
						}
						else
						{
							OutOfMemoryException ex4 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						goto IL_0a95;
						IL_0a95:
						NullReferenceException ex5 = new NullReferenceException();
						goto IL_0aa3;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	public unsafe static void Tell(string kind, string what, string how = null, string caller = null, string by = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0896: Expected I, but got Obj
		//IL_08b8: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected I4, but got Obj
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got Ref
		//IL_038a: Expected Obj, but got I4
		//IL_0900: Expected I4, but got Obj
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Ref, but got Unknown
		//IL_0923: Expected Obj, but got I4
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got I4
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Ref
		//IL_078b: Expected Obj, but got Ref
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_041c: Expected I, but got Obj
		//IL_043e: Expected Obj, but got I4
		//IL_0949: Expected Obj, but got I
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got I4
		//IL_0829: Expected Obj, but got I4
		//IL_0466: Expected I, but got Obj
		//IL_0888: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_06ef: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected I4, but got Obj
		//IL_09cc: Expected I, but got Obj
		//IL_09ee: Expected Obj, but got I4
		//IL_0986: Expected Obj, but got I
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_0a6f: Expected Obj, but got I
		//IL_0a85: Expected Obj, but got I
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_04df: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0a26: Expected Obj, but got I4
		//IL_0723: Expected I, but got Obj
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0a9a: Expected Obj, but got I
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05a5: Expected I4, but got Obj
		//IL_05ae: Expected Obj, but got I4
		//IL_073a: Expected I, but got Obj
		//IL_05d4: Expected Obj, but got I
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_062d: Expected I4, but got Obj
		//IL_0663: Expected Obj, but got I4
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj = 0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2 (Il2CppClass<System.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Clean(what, 80);
		string s = default;
		string text2 = Clean(s, 40);
		string text3 = Clean(caller, 160);
		string text4 = Clean(by, 64);
		nint num2 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4 (Il2CppClass<System.Object>)+A0]");
		System.__Canon[] array = (System.__Canon[])0;
		List<System.__Canon> list = (List<System.__Canon>)(object)array;
		bool flag2 = array == null;
		System.__Canon[] array3 = default;
		System.__Canon[] array2 = array3;
		Enumerator<, > val = (Enumerator<, >)0;
		int num3 = 64;
		string text5 = by;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE00]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDF8]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)array).GetEnumerator();
			Enumerator<, > val2 = default;
			object obj10 = default;
			object obj18 = default;
			while (true)
			{
				num3 = (int)obj3;
				object obj5;
				Enumerator<, > val4;
				object obj8;
				object obj9;
				List<System.__Canon> list2;
				if (val.MoveNext())
				{
					Enumerator<, > val3;
					if (array3 == null)
					{
						NullReferenceException ex = new NullReferenceException();
						array2 = null;
						val = val2;
						obj5 = 0;
						val3 = val2;
						list2 = (List<System.__Canon>)(&val);
						list = (List<System.__Canon>)(&val);
						array = array3;
						text5 = text4;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ stack_-78 (System.__Canon[])+10]");
					bool flag3 = (string)0 == kind;
					bool flag4 = !flag3;
					s = null;
					if (flag4)
					{
						continue;
					}
					bool flag5 = (string)array3.Length == text;
					bool flag6 = !flag5;
					s = null;
					if (flag6)
					{
						continue;
					}
					bool flag7 = (string)(object)array3[0] == text2;
					bool flag8 = !flag7;
					s = null;
					if (flag8)
					{
						continue;
					}
					bool flag9 = (string)(object)array3[2] == text4;
					bool flag10 = !flag9;
					s = null;
					if (flag10)
					{
						continue;
					}
					object obj6 = array3 + 40;
					array = (System.__Canon[])obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X25_v19+10]");
					list = (List<System.__Canon>)((nint)0 + (nint)1);
					bool flag11 = obj6 == null;
					s = null;
					array2 = null;
					val = val2;
					obj5 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					num3 = (int)text4;
					text5 = text4;
					if (flag11)
					{
						goto IL_07d0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v32 (System.__Canon[])+10]");
					array = (System.__Canon[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v32 (System.__Canon[])+10]");
					bool flag12 = (nint)0 == 0;
					object obj7 = !flag12;
					if (obj7 == null)
					{
						obj6 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					s = null;
					array2 = null;
					val = val2;
					obj5 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					obj8 = 5;
					text5 = text4;
					obj9 = 0;
				}
				else
				{
					array2 = null;
					val = val2;
					obj5 = 0;
					Enumerator<, > val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					obj8 = 6;
					list = (List<System.__Canon>)(&val);
					array = array3;
					text5 = text4;
					obj9 = 0;
				}
				goto IL_08f8;
				IL_07d0:
				NullReferenceException ex2 = new NullReferenceException();
				if (num3 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					array2 = (System.__Canon[])1;
					array = (System.__Canon[])1;
					obj9 = obj5;
				}
				else
				{
					if (num3 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FB20");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj9 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj5 = obj10;
				}
				obj8 = 0;
				goto IL_08f8;
				IL_08f8:
				num3 = (int)obj4;
				((Enumerator<, >*)val4)->Dispose();
				bool flag13 = obj9 == null;
				object obj11 = !flag13;
				list2 = (List<System.__Canon>)val4;
				if (obj11 == null)
				{
					bool flag14 = array2 == null;
					object obj12 = !flag14;
					list2 = (List<System.__Canon>)val4;
					OutOfMemoryException ex3 = (OutOfMemoryException)val4;
					array = array2;
					if (obj12 == null)
					{
						if ((nint)obj8 != 6)
						{
							bool flag15 = obj8 == null;
							object obj13 = !flag15;
							if (obj13 != null)
							{
								return;
							}
						}
						nint num4 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v15 (Il2CppClass<System.Object>)+E4]");
						bool flag16 = (nint)0 == 0;
						object obj14 = !flag16;
						nint num5 = num4;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num5 = (nint)obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v16 (Il2CppClass<System.Object>)+A0]");
						array = (System.__Canon[])0;
						List<System.__Canon> list3 = (List<System.__Canon>)(object)array;
						bool flag17 = array == null;
						list2 = (List<System.__Canon>)val4;
						if (flag17)
						{
							break;
						}
						list = (List<System.__Canon>)list3._size;
						if (list3._size < 16)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v16 (Il2CppClass<System.Object>)+E4]");
							bool flag18 = (nint)0 == 0;
							object obj15 = !flag18;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								nint num6 = (nint)obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v29 (Il2CppClass<System.Object>)+A0]");
								object obj16 = 0;
								list3 = (List<System.__Canon>)obj16;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE28]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							_ = 1;
							obj18._002Ector();
							object obj19 = obj18 + 16;
							obj19 = kind;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj20 = obj18 + 24;
							obj20 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj21 = obj18 + 32;
							obj21 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj22 = obj18 + 40;
							obj22 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj23 = obj18 + 48;
							obj23 = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag19 = list3 == null;
							list2 = (List<System.__Canon>)val4;
							num3 = (int)text5;
							array = (System.__Canon[])1;
							obj = obj18;
							if (flag19)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE10]");
							object obj24 = 0;
							array = list3._items;
							list = (List<System.__Canon>)obj24;
							int version = list3._version + 1;
							list3._version = version;
							bool flag20 = list3._items == null;
							list2 = (List<System.__Canon>)val4;
							num3 = (int)text5;
							obj = obj18;
							if (flag20)
							{
								break;
							}
							bool flag21 = list3._size < array.Length;
							object obj25 = !flag21;
							if (obj25 == null)
							{
								object obj26 = list3._items + list3._size;
								int size = list3._size + 1;
								list3._size = size;
								object obj27 = obj26 + 32;
								obj27 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								list3.AddWithResize((System.__Canon)obj18);
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v16 (Il2CppClass<System.Object>)+E4]");
							bool flag22 = (nint)0 == 0;
							object obj28 = !flag22;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							nint num7 = (nint)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v19 (Il2CppClass<System.Object>)+E4]");
							bool flag23 = (nint)0 == 0;
							object obj29 = !flag23;
							nint num8 = num7;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num8 = (nint)obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v21 (Il2CppClass<System.Object>)+A0]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v15+2C]");
							object obj31 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v21 (Il2CppClass<System.Object>)+E4]");
							bool flag24 = (nint)0 == 0;
							object obj32 = !flag24;
							nint num9 = num8;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								num9 = (nint)obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v22 (Il2CppClass<System.Object>)+A0]");
							object obj33 = 0;
						}
						return;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				val4 = (Enumerator<, >)list2;
				goto IL_07d0;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void Update()
	{
		//IL_0315: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_00fc: Expected F4, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_0394: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I4
		//IL_01d2: Expected F4, but got I
		//IL_01e2: Invalid comparison between F4 and I
		//IL_0197: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj = 0;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = realtimeSinceStartup < nextKeep;
		float num = realtimeSinceStartup;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
			object obj2 = 0;
			num = realtimeSinceStartup + 1f;
			object obj3 = obj2;
			nextKeep = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSceneGuard.Keep();
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+18]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE50]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE48]");
		object obj10 = 0;
		float value = 0f;
		int num2 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+A0]");
			object obj12 = 0;
			List<System.__Canon> list = (List<System.__Canon>)obj12;
			if (num2 >= list._size)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+A0]");
				object obj15 = 0;
				list = (List<System.__Canon>)obj15;
			}
			object obj16 = obj9;
			System.__Canon w = list.get_Item(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v13 (System.__Canon)+40]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v13 (System.__Canon)+40]");
			bool flag7 = realtimeSinceStartup < 0f;
			nint num3 = num2;
			if (!flag7)
			{
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v17+E4]");
				bool flag8 = (nint)0 == 0;
				object obj18 = !flag8;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v17+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v16+8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v13 (System.__Canon)+10]");
				if (((Dictionary<System.__Canon, float>)num4).TryGetValue((System.__Canon)0, out value))
				{
					num = realtimeSinceStartup - value;
					bool flag9 = !((double)num < 30.0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v13 (System.__Canon)+10]");
					num3 = 0;
					obj16 = (object)(&value);
					if (!flag9)
					{
						goto IL_02da;
					}
				}
				Send((Waiting)(object)w);
				break;
			}
			goto IL_02da;
			IL_02da:
			obj5 = obj;
			num2++;
		}
	}

	private void Send(Waiting w)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_02eb: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2 + 24;
		obj6 = w;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Dictionary<string, object> args = ArgsOf((Waiting)obj6);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v18+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v9+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v21+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v13+10]");
		if (((PlayFabAuthenticationContext)0).IsClientLoggedIn())
		{
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v25+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v25+A0]");
			object obj20 = 0;
			bool flag6 = ((List<System.__Canon>)obj20).Remove((System.__Canon)obj6);
			object obj21 = obj6;
			object obj22 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v3+A0]");
			object obj23 = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE60]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v4+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v18+10]");
			((Dictionary<System.__Canon, float>)num).set_Item((System.__Canon)0, realtimeSinceStartup);
			object obj25 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v21+A0]");
			object obj26 = 0;
			_ = 1;
			Handed(args);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE70]");
			object obj28 = 0;
			Action<System.__Canon> action = default;
			action._002Ector(obj2, (IntPtr)obj28);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE78]");
			object obj29 = 0;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj2, (IntPtr)obj29);
			object obj30 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v35+E4]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE80]");
			object function = 0;
			GillaCloud.Run((string)function, args, (Action<string>)action, (Action<string>)action2);
		}
	}

	private static void Handed(Dictionary<string, object> args)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+28]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF28]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF20]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726194");
		object obj16 = default;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0119;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v12+98]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v8-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj18--;
			obj19 += 16;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_0119;
		}
		object obj20 = obj19 + 3;
		object obj21 = obj15 + obj20;
		object obj22 = obj21 + 312;
		goto IL_0271;
		IL_0119:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0271;
		IL_0271:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v13] (should have been resolved before IL gen)");
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v18+A0]");
		object obj25 = (nint)0 + (nint)32;
		object obj26 = default;
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF30]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj30 = !flag6;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v24+A0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v21+20]");
		string message = (string)obj28 + (string)0;
		object obj32 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
	}

	private void Answered(Waiting w, string json)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I4
		//IL_0708: Expected Obj, but got I
		//IL_072a: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got I
		//IL_0755: Expected Obj, but got I
		//IL_077b: Expected Obj, but got I4
		//IL_0842: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_0789: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_057e: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I8
		//IL_07d4: Expected Obj, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_05e0: Invalid comparison between F8 and I4
		//IL_03c6: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I8
		//IL_0608: Expected F8, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04c8: Expected Obj, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj2 = 0;
		object obj3 = obj2;
		string text2 = default;
		string text = (string)((text2 != null) ? text2 : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF68]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+A0]");
		object obj8 = (nint)0 + (nint)48;
		obj8 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text3 = (string)obj6;
		string json2 = (string)((text2 != null) ? text2 : obj);
		System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(json2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
		string text4 = (string)0;
		object obj16;
		if (_Canon != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11 (System.__Canon)+10]");
			if ((nint)0 != 0)
			{
				if (w != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF98]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF70]");
					object obj10 = 0;
					string message = (string)obj9 + w.kind + (string)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v43+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message);
					return;
				}
				goto IL_0639;
			}
			string text5 = (string)(_Canon + 24);
			bool flag4 = string.IsNullOrEmpty(text5);
			bool flag5 = !flag4;
			object obj14 = !flag5;
			object obj15 = ~obj14;
			if (obj15 != null)
			{
				text4 = text5;
			}
			obj16 = 0;
		}
		else
		{
			obj16 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF88]");
		object obj17 = 0;
		text4 = text4;
		text3 = (string)obj17;
		if (!(text4 == (string)obj17))
		{
			goto IL_0221;
		}
		bool flag6 = w == null;
		text2 = null;
		if (!flag6)
		{
			if (++w.tries > 3)
			{
				goto IL_0221;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			bool flag7 = obj16 == null;
			object obj18 = !flag7;
			text2 = null;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11 (System.__Canon)+20]");
				double num = 0.0 / 1148846080.0;
				bool flag8 = num < 20.0;
				double num2 = 20.0;
				if (!flag8)
				{
					bool flag9 = !(num > 1163984896.0);
					num2 = num;
					if (!flag9)
					{
						num2 = 1163984896.0;
					}
				}
				float notBefore = realtimeSinceStartup + (float)num2;
				object obj19 = obj2;
				w.notBefore = notBefore;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v38+E4]");
				bool flag10 = (nint)0 == 0;
				object obj20 = !flag10;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Requeue(w);
				return;
			}
		}
		goto IL_0639;
		IL_0639:
		throw new NullReferenceException();
		IL_0221:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		bool flag11 = array == null;
		text2 = null;
		text3 = (string)5;
		if (!flag11)
		{
			bool flag12 = array.Length == 0;
			text3 = (string)5;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF90]");
				object obj22 = 0;
				text3 = (string)obj22;
				object obj23 = array + 32;
				obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag13 = w == null;
				text2 = null;
				if (flag13)
				{
					goto IL_0639;
				}
				object obj24 = array.Length & 0xFFFFFFFEL;
				if (obj24 != null)
				{
					text3 = w.kind;
					object obj25 = array + 40;
					obj25 = w.kind;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X19_v4-10]");
					bool flag14 = (nint)0 < (nint)2;
					object obj26 = !flag14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X19_v4-10]");
					object obj27 = -2;
					bool flag15 = obj27 == null;
					object obj28 = ~obj26;
					object obj29 = obj28 | flag15;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF78]");
						object obj30 = 0;
						text3 = (string)obj30;
						object obj31 = array + 48;
						obj31 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X19_v6-18]");
						object obj32 = 0 & 0xFFFFFFFCL;
						if (obj32 != null)
						{
							object obj33 = array + 56;
							obj33 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X19_v8-20]");
							bool flag16 = (nint)0 < (nint)4;
							object obj34 = !flag16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X19_v8-20]");
							object obj35 = -4;
							bool flag17 = obj35 == null;
							object obj36 = ~obj34;
							object obj37 = obj36 | flag17;
							text3 = text4;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF80]");
								object obj38 = 0;
								object obj39 = array + 64;
								obj39 = obj38;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string message2 = string.Concat(array);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj40 = 0;
								object obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v28+E4]");
								bool flag18 = (nint)0 == 0;
								object obj42 = !flag18;
								if (obj42 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Debug.LogWarning(message2);
								return;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			text2 = null;
		}
		goto IL_0639;
	}

	private void Failed(Waiting w, string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_096e: Expected Obj, but got I4
		//IL_09a6: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_062b: Expected Obj, but got I8
		//IL_00df: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I8
		//IL_09c4: Expected Obj, but got I
		//IL_09e6: Expected Obj, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_068f: Expected Obj, but got I4
		//IL_06a5: Expected Obj, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_0a7e: Expected Obj, but got I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0a04: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I
		//IL_0734: Expected Obj, but got I8
		//IL_031d: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I8
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0793: Expected Obj, but got I4
		//IL_07a9: Expected Obj, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03c8: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_07ec: Expected Obj, but got I
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected Obj, but got Unknown
		//IL_082e: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got I
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_08b9: Expected Obj, but got I
		//IL_08e3: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04ee: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj2 = 0;
		object obj3 = obj2;
		string text = (string)((why != null) ? why : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+A0]");
		object obj7 = (nint)0 + (nint)48;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag3 = why == null;
		string text2 = why;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFC8]");
			object obj8 = 0;
			string text3 = (string)obj8;
			bool flag4 = why.StartsWith((string)obj8);
			bool flag5 = !flag4;
			text2 = null;
			if (!flag5)
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v70+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v70+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v48+19]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj13 = 0;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v73+E4]");
					bool flag8 = (nint)0 == 0;
					object obj15 = !flag8;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFE0]");
					object message = 0;
					Debug.LogWarning(message);
					obj9 = obj2;
					text3 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v70+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v70+A0]");
				object obj17 = 0;
				_ = 1;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj18 = 0;
		int num = ++w.tries;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (num < 4)
		{
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFB8]");
				object obj19 = 0;
				object obj20 = array + 32;
				obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X22_v10-8]");
				object obj21 = 0 & 0xFFFFFFFEL;
				if (obj21 != null)
				{
					object obj22 = array + 40;
					obj22 = w.kind;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X22_v12-10]");
					bool flag10 = (nint)0 < (nint)2;
					object obj23 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X22_v12-10]");
					object obj24 = -2;
					bool flag11 = obj24 == null;
					object obj25 = ~obj23;
					object obj26 = obj25 | flag11;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFC0]");
						object obj27 = 0;
						object obj28 = array + 48;
						obj28 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						float num2 = default;
						string text4 = num2.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X22_v14-18]");
						object obj29 = 0 & 0xFFFFFFFCL;
						if (obj29 != null)
						{
							object obj30 = array + 56;
							obj30 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X22_v16-20]");
							bool flag12 = (nint)0 < (nint)4;
							object obj31 = !flag12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X22_v16-20]");
							object obj32 = -4;
							bool flag13 = obj32 == null;
							object obj33 = ~obj31;
							object obj34 = obj33 | flag13;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFB0]");
								object obj35 = 0;
								object obj36 = array + 64;
								obj36 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X22_v18-28]");
								bool flag14 = (nint)0 < (nint)5;
								object obj37 = !flag14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X22_v18-28]");
								object obj38 = -5;
								bool flag15 = obj38 == null;
								object obj39 = ~obj37;
								object obj40 = obj39 | flag15;
								if (obj40 == null)
								{
									object obj41 = array + 72;
									obj41 = why;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string message2 = string.Concat(array);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj42 = 0;
									object obj43 = obj42;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v43+E4]");
									bool flag16 = (nint)0 == 0;
									object obj44 = !flag16;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.LogWarning(message2);
									float realtimeSinceStartup = Time.realtimeSinceStartup;
									object obj45 = obj2;
									float notBefore = realtimeSinceStartup + 20f;
									w.notBefore = notBefore;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v59+E4]");
									bool flag17 = (nint)0 == 0;
									object obj46 = !flag17;
									if (obj46 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Requeue(w);
									return;
								}
							}
						}
					}
				}
			}
		}
		else if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFB8]");
			object obj47 = 0;
			object obj48 = array + 32;
			obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X22_v8-8]");
			object obj49 = 0 & 0xFFFFFFFEL;
			if (obj49 != null)
			{
				object obj50 = array + 40;
				obj50 = w.kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X20_v7-10]");
				bool flag18 = (nint)0 < (nint)2;
				object obj51 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X20_v7-10]");
				object obj52 = -2;
				bool flag19 = obj52 == null;
				object obj53 = ~obj51;
				object obj54 = obj53 | flag19;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFD8]");
					object obj55 = 0;
					object obj56 = array + 48;
					obj56 = obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num3 = default;
					string text5 = num3.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X20_v9-18]");
					object obj57 = 0 & 0xFFFFFFFCL;
					if (obj57 != null)
					{
						object obj58 = array + 56;
						obj58 = text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X20_v11-20]");
						bool flag20 = (nint)0 < (nint)4;
						object obj59 = !flag20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X20_v11-20]");
						object obj60 = -4;
						bool flag21 = obj60 == null;
						object obj61 = ~obj59;
						object obj62 = obj61 | flag21;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFD0]");
							object obj63 = 0;
							object obj64 = array + 64;
							obj64 = obj63;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v13-28]");
							bool flag22 = (nint)0 < (nint)5;
							object obj65 = !flag22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v13-28]");
							object obj66 = -5;
							bool flag23 = obj66 == null;
							object obj67 = ~obj65;
							object obj68 = obj67 | flag23;
							if (obj68 == null)
							{
								object obj69 = array + 72;
								obj69 = why;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string message3 = string.Concat(array);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj70 = 0;
								object obj71 = obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v27+E4]");
								bool flag24 = (nint)0 == 0;
								object obj72 = !flag24;
								if (obj72 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Debug.LogWarning(message3);
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe static void Requeue(Waiting w)
	{
		//IL_0010: Expected Obj, but got I
		//IL_063d: Expected Obj, but got I4
		//IL_07cb: Expected Obj, but got I
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got I4
		//IL_078a: Expected I, but got Obj
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected Ref, but got Unknown
		//IL_07ad: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_05a5: Expected Obj, but got I4
		//IL_05ae: Expected Obj, but got I4
		//IL_06d2: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I4
		//IL_0721: Expected Obj, but got I4
		//IL_080a: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I
		//IL_0439: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got I
		//IL_01f4: Invalid comparison between F4 and I4
		//IL_0203: Invalid comparison between F4 and I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0751: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got I
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got I4
		//IL_0694: Expected Obj, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected Obj, but got I4
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		bool flag2 = list == null;
		List<System.__Canon> list3 = default;
		List<System.__Canon> list2 = list3;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE00]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDF8]");
			object obj5 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			Enumerator<, > val3 = default;
			object obj18 = default;
			while (true)
			{
				nint num = (nint)obj4;
				object obj13;
				object obj15;
				object obj14;
				Enumerator<, > val4;
				Enumerator<, > val2;
				if (val.MoveNext())
				{
					if (list3 != null)
					{
						if (w != null)
						{
							bool flag3 = (string)(object)list3._items == w.kind;
							bool flag4 = !flag3;
							object obj6 = 0;
							if (flag4)
							{
								continue;
							}
							bool flag5 = (string)list3._size == w.what;
							bool flag6 = !flag5;
							obj6 = 0;
							if (flag6)
							{
								continue;
							}
							bool flag7 = (string)list3._syncRoot == w.how;
							bool flag8 = !flag7;
							obj6 = 0;
							if (flag8)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+30]");
							bool flag9 = (string)0 == w.by;
							bool flag10 = !flag9;
							obj6 = 0;
							if (flag10)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+40]");
							val2 = (Enumerator<, >)0;
							int count = w.count;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+38]");
							list = (List<System.__Canon>)((nint)count + (nint)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+40]");
							float num2 = 0f - w.notBefore;
							bool flag11 = num2 < 0f;
							bool flag12 = num2 == 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+40]");
							object obj7 = 0 ^ w.notBefore;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-58 (System.Collections.Generic.List`1<System.__Canon>)+40]");
							object obj8 = 0 ^ num2;
							object obj9 = obj7 & obj8;
							bool flag13 = (nint)obj9 < 0;
							bool flag14 = flag11 == flag13;
							object obj10 = !flag12;
							object obj11 = flag14 & obj10;
							object obj12 = ~obj11;
							if (obj12 != null)
							{
								val2 = (Enumerator<, >)w.notBefore;
							}
							obj6 = 0;
							obj13 = 4;
							list2 = null;
							val = val3;
							obj14 = 0;
							val4 = (Enumerator<, >)(ref val);
							obj15 = 0;
							goto IL_0782;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					list2 = null;
					val = val3;
					obj14 = 0;
					val2 = val3;
					val4 = (Enumerator<, >)(ref val);
					list = list3;
					break;
				}
				obj13 = 5;
				list2 = null;
				val = val3;
				obj14 = 0;
				val2 = val3;
				val4 = (Enumerator<, >)(ref val);
				list = list3;
				obj15 = 0;
				goto IL_0782;
				IL_0782:
				while (true)
				{
					num = (nint)obj5;
					((Enumerator<, >*)val4)->Dispose();
					bool flag15 = obj15 == null;
					object obj16 = !flag15;
					if (obj16 == null)
					{
						bool flag16 = list2 == null;
						object obj17 = !flag16;
						OutOfMemoryException ex3 = (OutOfMemoryException)val4;
						list = list2;
						if (obj17 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list2 = (List<System.__Canon>)1;
						list = (List<System.__Canon>)1;
						obj15 = obj14;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj18;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FB20");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					obj13 = 0;
				}
				if ((nint)obj13 != 5)
				{
					bool flag17 = obj13 == null;
					object obj19 = !flag17;
					if (obj19 != null)
					{
						return;
					}
				}
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+E4]");
				bool flag18 = (nint)0 == 0;
				object obj21 = !flag18;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+A0]");
				object obj22 = 0;
				list = (List<System.__Canon>)obj22;
				if (obj22 == null)
				{
					break;
				}
				if (list._size < 16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+E4]");
					bool flag19 = (nint)0 == 0;
					object obj23 = !flag19;
					List<System.__Canon> list4 = (List<System.__Canon>)obj22;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj24 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v22+A0]");
						object obj25 = 0;
						list4 = (List<System.__Canon>)obj25;
						bool flag20 = obj25 == null;
						list = (List<System.__Canon>)obj25;
						if (flag20)
						{
							break;
						}
					}
					list4.Insert(0, (System.__Canon)(object)w);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+E4]");
				bool flag21 = (nint)0 == 0;
				object obj26 = !flag21;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v15+E4]");
				bool flag22 = (nint)0 == 0;
				object obj28 = !flag22;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v15+A0]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v14+2C]");
				object obj30 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v15+E4]");
				bool flag23 = (nint)0 == 0;
				object obj31 = !flag23;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v15+A0]");
				object obj32 = 0;
				return;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static Dictionary<string, object> ArgsOf(Waiting w)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a5f: Expected Obj, but got I4
		//IL_0a85: Expected Obj, but got I
		//IL_0aa7: Expected Obj, but got I4
		//IL_0d9d: Expected Obj, but got I
		//IL_0dbf: Expected Obj, but got I4
		//IL_0adf: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_0af6: Expected Obj, but got I4
		//IL_0afe: Expected Obj, but got I
		//IL_0b06: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_0ce8: Expected Obj, but got I
		//IL_0cf8: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0146: Expected I, but got Obj
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_09ec: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_01da: Expected Obj, but got VT
		//IL_0d50: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got VT
		//IL_0913: Expected Obj, but got I4
		//IL_03cb: Expected I, but got Obj
		//IL_01e7: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I4
		//IL_0b19: Expected Obj, but got I4
		//IL_0b21: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_0b3e: Expected Obj, but got I
		//IL_0b60: Expected Obj, but got I4
		//IL_0ddd: Expected Obj, but got I
		//IL_0b7e: Expected Obj, but got I
		//IL_0b90: Expected I, but got Obj
		//IL_0466: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I4
		//IL_0c0e: Expected Obj, but got I
		//IL_0c16: Expected I, but got Obj
		//IL_0c37: Expected Obj, but got I
		//IL_0c61: Expected Obj, but got I4
		//IL_0bf0: Expected Obj, but got I4
		//IL_0e22: Expected Obj, but got I
		//IL_0e32: Expected Obj, but got I
		//IL_0e5f: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I
		//IL_0c7f: Expected Obj, but got I
		//IL_0c8f: Expected Obj, but got I
		//IL_0cca: Expected Obj, but got I4
		//IL_070a: Expected I, but got Obj
		//IL_061a: Expected Obj, but got I
		//IL_0633: Expected Obj, but got Ref
		//IL_0650: Expected I4, but got Obj
		//IL_0687: Expected I4, but got Obj
		//IL_076f: Expected Obj, but got I
		//IL_07ac: Expected Obj, but got I
		//IL_07b4: Expected I, but got Obj
		//IL_084b: Expected Obj, but got I
		//IL_0853: Expected I, but got Obj
		//IL_08ea: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+A0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X9_v7 (Il2CppClass<System.__Canon>)+8]");
		UnityEngine.Object obj8 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = obj8 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj10 = null;
		UnityEngine.Object obj11;
		System.__Canon _Canon;
		if (!flag5)
		{
			bool flag6 = (object)obj8 == null;
			obj10 = null;
			_Canon = null;
			obj11 = null;
			if (flag6)
			{
				goto IL_0920;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X20_v4 (UnityEngine.Object)+B0]");
			obj10 = (UnityEngine.Object)0;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v87+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		System.__Canon _Canon2 = default;
		nint num2;
		string s;
		if (obj10 != null)
		{
			bool flag8 = (object)obj10 == null;
			_Canon = null;
			obj11 = null;
			if (flag8)
			{
				goto IL_0920;
			}
			bool isRunning = ((NetworkRunner)obj10).IsRunning;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			_Canon2 = (System.__Canon)0;
			num2 = (nint)_Canon2;
			bool flag9 = !isRunning;
			UnityEngine.Object obj14 = null;
			if (!flag9)
			{
				PlayerRef localPlayer = ((NetworkRunner)obj10).LocalPlayer;
				string playerUserId = ((NetworkRunner)obj10).GetPlayerUserId(localPlayer);
				if (playerUserId == null)
				{
					s = (string)(object)_Canon2;
					_Canon = null;
					obj14 = (UnityEngine.Object)localPlayer;
				}
				else
				{
					s = playerUserId;
					_Canon = null;
					obj14 = (UnityEngine.Object)localPlayer;
				}
				goto IL_0d40;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj15 = 0;
			num2 = (nint)obj15;
			UnityEngine.Object obj14 = null;
		}
		object obj16 = 1;
		s = (string)num2;
		string text = (string)num2;
		_Canon = null;
		goto IL_0cd8;
		IL_0d40:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X22_v2 (UnityEngine.Object)+2F8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X22_v2 (UnityEngine.Object)+2F8]");
		if ((nint)0 != 0)
		{
			num = (nint)_Canon2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v9+18]");
			nint num3;
			if ((nint)0 == 0)
			{
				num3 = (nint)_Canon2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v9+18]");
				num3 = 0;
			}
			obj16 = 0;
			text = (string)num3;
		}
		else
		{
			obj16 = 0;
			text = (string)(object)_Canon2;
		}
		goto IL_0cd8;
		IL_0920:
		NullReferenceException ex = new NullReferenceException();
		bool flag10 = (nint)obj11 != 1;
		NullReferenceException ex2 = ex;
		string text2 = default;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj19 = default;
			object obj18 = obj19;
			UnityEngine.Object obj14 = (UnityEngine.Object)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj21 = default;
			object obj20 = obj21 & 1;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				s = text2;
				goto IL_0d40;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj22 = obj19;
			obj11 = (UnityEngine.Object)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex3 = default;
			ex2 = ex3;
			_Canon = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Dictionary<string, object> result = default;
		return result;
		IL_0c6f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEF8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF00]");
		obj8 = (UnityEngine.Object)0;
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		System.__Canon value;
		dictionary.Add(_Canon2, value);
		object obj24;
		object obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v42+E4]");
		bool flag11 = (nint)0 == 0;
		object obj25 = !flag11;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value2 = Clean(text, 12);
		dictionary.Add((System.__Canon)(object)text2, (System.__Canon)(object)value2);
		string value3 = Clean(s, 64);
		object obj26;
		nint num4 = (nint)obj26;
		dictionary.Add((System.__Canon)(object)obj8, (System.__Canon)(object)value3);
		_Canon = (System.__Canon)(object)w.how;
		bool flag12 = w.how == null;
		obj10 = (UnityEngine.Object)(object)dictionary;
		obj11 = obj8;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
			obj8 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X2_v2 (System.__Canon)+10]");
			bool flag13 = (nint)0 < (nint)1;
			obj11 = obj8;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEC0]");
				object obj27 = 0;
				num4 = (nint)obj8;
				dictionary.set_Item((System.__Canon)obj27, (System.__Canon)(object)w.how);
				obj11 = (UnityEngine.Object)obj27;
			}
			_Canon = (System.__Canon)(object)w.caller;
			bool flag14 = w.caller == null;
			obj10 = (UnityEngine.Object)(object)dictionary;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X2_v2 (System.__Canon)+10]");
				bool flag15 = (nint)0 < (nint)1;
				nint num5 = num4;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEE0]");
					object obj28 = 0;
					num5 = (nint)obj8;
					dictionary.set_Item((System.__Canon)obj28, (System.__Canon)(object)w.caller);
					obj11 = (UnityEngine.Object)obj28;
				}
				_Canon = (System.__Canon)(object)w.by;
				bool flag16 = w.by == null;
				num4 = num5;
				obj10 = (UnityEngine.Object)(object)dictionary;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X2_v2 (System.__Canon)+10]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEC8]");
						object key = 0;
						dictionary.set_Item((System.__Canon)key, (System.__Canon)(object)w.by);
					}
					return (Dictionary<string, object>)(object)dictionary;
				}
			}
		}
		goto IL_0920;
		IL_0cd8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE90]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		obj11 = (UnityEngine.Object)obj30;
		dictionary._002Ector();
		bool flag17 = w == null;
		text2 = text;
		obj10 = (UnityEngine.Object)(object)dictionary;
		if (!flag17)
		{
			bool flag18 = dictionary == null;
			text2 = text;
			obj10 = (UnityEngine.Object)(object)dictionary;
			if (!flag18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBED8]");
				object key2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
				obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEF0]");
				object key3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB8]");
				object key4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
				object obj32 = 0;
				dictionary.Add((System.__Canon)key2, (System.__Canon)(object)w.kind);
				dictionary.Add((System.__Canon)key3, (System.__Canon)(object)w.what);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				System.__Canon value4 = default;
				dictionary.Add((System.__Canon)key4, value4);
				string real = GillaName.Real;
				object obj33 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v17+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v17+E4]");
				bool flag19 = (nint)0 == 0;
				object obj34 = !flag19;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text3 = Clean(real, 32);
				num4 = (nint)obj26;
				dictionary.Add((System.__Canon)obj31, (System.__Canon)(object)text3);
				object obj35 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v25+E4]");
				bool flag20 = (nint)0 == 0;
				object obj36 = !flag20;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj37 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF08]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v29+E4]");
				bool flag21 = (nint)0 == 0;
				object obj39 = !flag21;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj37 = obj32;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v29+A0]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v22+30]");
				int num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v22+30]");
				int num7;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v29+E4]");
					bool flag22 = (nint)0 == 0;
					object obj41 = !flag22;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj42 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v72+E4]");
					bool flag23 = (nint)0 == 0;
					object obj43 = !flag23;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj42 = obj32;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v72+A0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v55+30]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v55+30]");
					bool flag24 = (nint)0 == 0;
					num7 = w.count;
					text2 = (string)109895680;
					_Canon2 = (System.__Canon)obj38;
					obj10 = (UnityEngine.Object)(object)dictionary;
					_Canon = (System.__Canon)(object)text3;
					obj11 = (UnityEngine.Object)obj31;
					if (flag24)
					{
						goto IL_0920;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v56+38]");
					num6 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEE8]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				num4 = (nint)obj26;
				System.__Canon _Canon3 = default;
				dictionary.Add((System.__Canon)obj38, _Canon3);
				_Canon2 = (System.__Canon)(object)text2;
				System.__Canon value5;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj46 = 0;
					value5 = (System.__Canon)obj46;
				}
				else
				{
					bool flag25 = (object)obj8 == null;
					num7 = num6;
					obj10 = (UnityEngine.Object)(object)dictionary;
					_Canon = _Canon3;
					obj11 = (UnityEngine.Object)obj38;
					if (flag25)
					{
						goto IL_0920;
					}
					string roomName = ((NetworkBootstrap)obj8).RoomName;
					object obj47 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v48+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v48+E4]");
					bool flag26 = (nint)0 == 0;
					object obj48 = !flag26;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text4 = Clean(roomName, 40);
					value5 = (System.__Canon)(object)text4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBED0]");
				text2 = (string)0;
				num4 = (nint)obj26;
				dictionary.Add(_Canon2, value5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj49 = 0;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v36+E4]");
				bool flag27 = (nint)0 == 0;
				object obj51 = !flag27;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = obj8 != null;
				_Canon2 = (System.__Canon)(object)text2;
				if (!flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj52 = 0;
					value = (System.__Canon)obj52;
					num7 = num6;
					goto IL_0c6f;
				}
				bool flag29 = (object)obj8 == null;
				num7 = num6;
				obj10 = (UnityEngine.Object)(object)dictionary;
				_Canon = null;
				obj11 = null;
				if (!flag29)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB0]");
					object obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X20_v4 (UnityEngine.Object)+90]");
					num = 0;
					string text5 = ((Enum)(&num7)).ToString();
					bool flag30 = text5 == null;
					num7 = (int)obj53;
					obj10 = (UnityEngine.Object)(object)dictionary;
					_Canon = null;
					obj11 = null;
					if (!flag30)
					{
						string text6 = text5.ToUpperInvariant();
						num7 = (int)obj53;
						value = (System.__Canon)(object)text6;
						goto IL_0c6f;
					}
				}
			}
		}
		goto IL_0920;
	}

	public static string Clean(string s, int most)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0397: Expected I, but got Obj
		//IL_03a7: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		if (string.IsNullOrEmpty(s))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			return (string)0;
		}
		StringBuilder stringBuilder = default;
		if (s != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int capacity = Math.Min(s._stringLength, most);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			stringBuilder._002Ector(capacity);
			if (s._stringLength >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj5 = 0;
				object obj6 = 0;
				int num = 0;
				while (true)
				{
					char c = s.get_Chars(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X24_v5+90]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = char.IsControl(c);
					bool flag4 = !flag3;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X24_v5+90]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v24+E4]");
						bool flag5 = (nint)0 == 0;
						object obj11 = !flag5;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!char.IsWhiteSpace(c))
						{
							object obj12 = obj6 & 1;
							if (obj12 != null)
							{
								if (stringBuilder == null)
								{
									break;
								}
								int length = stringBuilder.Length;
								if (length >= most)
								{
									goto IL_038f;
								}
								StringBuilder stringBuilder2 = stringBuilder.Append(' ');
							}
							else if (stringBuilder == null)
							{
								break;
							}
							int length2 = stringBuilder.Length;
							if (length2 >= most)
							{
								goto IL_038f;
							}
							StringBuilder stringBuilder3 = stringBuilder.Append(c);
							obj6 = 0;
							goto IL_03f9;
						}
					}
					if (stringBuilder == null)
					{
						break;
					}
					int length3 = stringBuilder.Length;
					bool flag6 = length3 < 0;
					bool flag7 = length3 == 0;
					int num2 = length3 ^ length3;
					int num3 = length3 & num2;
					bool flag8 = num3 < 0;
					bool flag9 = flag6 == flag8;
					object obj13 = !flag7;
					object obj14 = flag9 & obj13;
					obj6 = obj14;
					goto IL_03f9;
					IL_03f9:
					num++;
					if (num < s._stringLength)
					{
						continue;
					}
					goto IL_038f;
				}
			}
			else if (stringBuilder != null)
			{
				goto IL_038f;
			}
		}
		goto IL_03c1;
		IL_038f:
		nint num4 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v12 (Il2CppClass<System.Text.StringBuilder>)+168]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v12 (Il2CppClass<System.Text.StringBuilder>)+170]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_03c1;
		IL_03c1:
		return (string)(object)new NullReferenceException();
	}

	static GillaBotReport()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFF8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = list;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary = default;
		dictionary._002Ector();
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)8;
		obj9 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+A0]");
		object obj11 = (nint)0 + (nint)32;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8+A0]");
		object obj13 = (nint)0 + (nint)48;
		obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
