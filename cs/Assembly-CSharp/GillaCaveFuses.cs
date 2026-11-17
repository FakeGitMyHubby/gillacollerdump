using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public static class GillaCaveFuses
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public GillaBotReport _003C_003E4__this;

		public GillaBotReport.Waiting w;

		internal void _003CSend_003Eb__0(string json)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
			object obj = 0;
			GillaBotReport gillaBotReport = (GillaBotReport)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (GillaBotReport)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaBotReport = (GillaBotReport)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (GillaBotReport)+A0]");
			object obj3 = 0;
			_ = 0;
			gillaBotReport.Answered(w, json);
		}

		internal void _003CSend_003Eb__1(string why)
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
			object obj = 0;
			GillaBotReport gillaBotReport = (GillaBotReport)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (GillaBotReport)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaBotReport = (GillaBotReport)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (GillaBotReport)+A0]");
			object obj3 = 0;
			_ = 0;
			gillaBotReport.Failed(w, why);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GetUserDataResult> _003C_003E9__25_0;

		public static Action<PlayFabError> _003C_003E9__25_1;

		public static Action<PlayFabError> _003C_003E9__26_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC030]");
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

		internal unsafe void _003CRead_003Eb__25_0(GetUserDataResult result)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0232: Expected Obj, but got I4
			//IL_02c0: Expected Obj, but got I
			//IL_026a: Expected Obj, but got I4
			//IL_005e: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_00ca: Expected Obj, but got I
			//IL_00e4: Expected Obj, but got Ref
			//IL_00e9: Expected I, but got Obj
			//IL_02a2: Expected Obj, but got I4
			//IL_0150: Expected Obj, but got I
			//IL_0170: Expected Obj, but got I4
			//IL_0189: Expected I, but got Obj
			//IL_01ef: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
			object obj4 = 0;
			_ = 256;
			int num2;
			GetUserDataResult getUserDataResult = default;
			if ((object)getUserDataResult.Data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC038]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E80]");
				object obj6 = 0;
				bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)(object)getUserDataResult.Data).TryGetValue((System.__Canon)obj5, out System.__Canon value);
				bool flag3 = !flag2;
				getUserDataResult = (GetUserDataResult)obj5;
				nint num = (nint)(&value);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-30_v5 (System.__Canon)+20]");
					bool flag4 = int.TryParse((string)0, out var result2);
					num2 = result2 & 3;
					getUserDataResult = (GetUserDataResult)(&result2);
					num = unchecked((nint)null);
					goto IL_0240;
				}
			}
			num2 = 0;
			goto IL_0240;
			IL_0240:
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bits = Bits;
			int num3 = num2 | bits;
			bool unsaved;
			if (num3 == num2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC018]");
				object key = 0;
				int num4 = PlayerPrefs.GetInt((string)key, 0);
				object obj9 = num4 - 1;
				bool flag6 = obj9 == null;
				getUserDataResult = null;
				nint num = unchecked((nint)null);
				unsaved = flag6;
			}
			else
			{
				unsaved = true;
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Set(num3, unsaved);
			if (num3 == num2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC018]");
				object key2 = 0;
				PlayerPrefs.SetInt((string)key2, 0);
				PlayerPrefs.Save();
			}
		}

		internal void _003CRead_003Eb__25_1(PlayFabError error)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ea: Expected Obj, but got I4
			//IL_0108: Expected Obj, but got I
			//IL_012f: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
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
			_ = 0;
			float unscaledTime = Time.unscaledTime;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+A0]");
			object obj6 = 0;
			float num = unscaledTime + 20f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC058]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj8 = 0;
			string text = error.GenerateErrorReport();
			string message = (string)obj7 + text;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}

		internal void _003CSave_003Eb__26_1(PlayFabError error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC060]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			string text = error.GenerateErrorReport();
			string message = (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	public const int Count = default(int);

	private const string Key = null;

	private const string UnsavedKey = null;

	private const string DataKey = null;

	private const float SaveRetry = default(float);

	private static int bits;

	private static bool reading;

	private static bool read;

	private static bool testing;

	private static float nextTry;

	private static Action m_Changed;

	private const int All = default(int);

	public static int Bits
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00de: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected Obj, but got Unknown
			//IL_010e: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got I
			//IL_019b: Expected I4, but got Obj
			//IL_003c: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got I
			//IL_0142: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+A0]");
			object obj4 = 0;
			object obj5 = obj4 & 0x80000000L;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC010]");
				object key = 0;
				int num = PlayerPrefs.GetInt((string)key, 0);
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+A0]");
				object obj7 = 0;
				int num2 = num & 3;
				obj7 = num2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+A0]");
			object obj9 = 0;
			return (int)obj9;
		}
	}

	public static bool AllIn
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0079: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Bits;
			object obj4 = num - 3;
			return obj4 == null;
		}
	}

	public static int Done
	{
		get
		{
			//IL_008b: Expected Obj, but got I
			//IL_009d: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			//IL_0056: Expected Obj, but got I4
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj = 0;
			int socket = 0;
			object obj2 = 1;
			int num = 0;
			object obj6;
			do
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = In(socket);
				num += (flag2 ? 1 : 0);
				object obj5 = obj2 & 1;
				bool flag3 = obj5 == null;
				obj6 = !flag3;
				socket = 1;
				obj2 = 0;
			}
			while (obj6 != null);
			return num;
		}
	}

	public static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
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
		obj4 = 4294967295L;
		_ = 0;
		_ = 0;
		_ = 0;
	}

	public static bool In(int socket)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Bits;
		int num2 = num >> socket;
		return (byte)(num2 & 1) != 0;
	}

	public static void Put(int socket)
	{
		//IL_0120: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		bool flag = socket < 1;
		object obj = !flag;
		object obj2 = socket - 1;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!In(socket))
		{
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Bits;
			int num2 = 1 << socket;
			int to = num | num2;
			Set(to, unsaved: true);
		}
	}

	public static void Tick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_049f: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0429: Invalid comparison between F4 and I
		//IL_023b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+6]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v11+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v16+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v17+10]");
			bool flag6 = ((PlayFabAuthenticationContext)0).IsClientLoggedIn();
			object obj16 = obj;
			if (flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v21+5]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC018]");
					object key = 0;
					int num = PlayerPrefs.GetInt((string)key, 0);
					if (num != 1)
					{
						return;
					}
					float unscaledTime = Time.unscaledTime;
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v32+E4]");
					bool flag8 = (nint)0 == 0;
					object obj20 = !flag8;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v32+A0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v28+8]");
					if (!(unscaledTime < 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v32+E4]");
						bool flag9 = (nint)0 == 0;
						object obj22 = !flag9;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Save();
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+E4]");
				bool flag10 = (nint)0 == 0;
				object obj23 = !flag10;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+A0]");
					obj18 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v21+4]");
				bool flag11 = (nint)0 == 0;
				object obj24 = !flag11;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+E4]");
					bool flag12 = (nint)0 == 0;
					object obj25 = !flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Read();
				}
				return;
			}
		}
		else
		{
			object obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+E4]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v23+A0]");
		object obj27 = 0;
		_ = 0;
	}

	private static void Set(int to, bool unsaved)
	{
		//IL_0010: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		object obj2 = obj;
		int num = to & 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num2 = Bits;
		if (num == num2 && !unsaved)
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC010]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num3 = Bits;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+A0]");
		object obj7 = 0;
		obj7 = num;
		PlayerPrefs.SetInt((string)key, num);
		bool flag3 = !unsaved;
		object obj8 = 0;
		int num4 = num;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC018]");
			object key2 = 0;
			PlayerPrefs.SetInt((string)key2, 1);
			obj8 = 0;
			num4 = 1;
		}
		PlayerPrefs.Save();
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v13+A0]");
		object obj11 = 0;
		bool flag5 = num == num3;
		_ = 0;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13+A0]");
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v11+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v11+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+40]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+28]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+18]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X2_v4 (should have been resolved before IL gen)");
			}
		}
	}

	private static void Read()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I4
		//IL_0594: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0403: Expected I, but got Obj
		//IL_0414: Expected I, but got Obj
		//IL_0432: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I
		//IL_04db: Expected I, but got Obj
		//IL_04ec: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_052d: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj6 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC038]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj8 = 0;
		System.__Canon[] items = list._items;
		object obj9 = obj8;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			object obj11 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj12 = obj11 + 32;
			obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v5+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v27+A8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v28+70]");
			nint num = 0;
			list.AddWithResize((System.__Canon)obj7);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC030]");
		object obj15 = 0;
		object obj16 = getUserDataRequest + 32;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v21+8]");
		Action<GetUserDataResult> resultCallback = (Action<GetUserDataResult>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v21+8]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		List<System.__Canon> list2 = list;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v25+A0]");
				obj19 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC020]");
			object obj24 = 0;
			nint num = (nint)obj24;
			Action<System.__Canon> action = default;
			action._002Ector(obj19, (IntPtr)obj24);
			object obj25 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v24+A0]");
			object obj26 = (nint)0 + (nint)8;
			obj26 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj17 = obj15;
			object obj27 = 0;
			list2 = (List<System.__Canon>)(object)action;
			resultCallback = (Action<GetUserDataResult>)action;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj15;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+10]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+10]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v17+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj33 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v19+A0]");
				obj29 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC028]");
			object obj35 = 0;
			nint num = (nint)obj35;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj29, (IntPtr)obj35);
			object obj36 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v18+A0]");
			object obj37 = (nint)0 + (nint)16;
			obj37 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			errorCallback = (Action<PlayFabError>)action2;
			object obj27 = 0;
			list2 = (List<System.__Canon>)(object)action2;
		}
		object obj38 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserData(getUserDataRequest, resultCallback, errorCallback);
	}

	private unsafe static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		//IL_009f: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0197: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_0397: Expected I, but got Obj
		//IL_03a8: Expected I, but got Obj
		//IL_03c6: Expected Obj, but got I
		//IL_03e1: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC040]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int value = Bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E68]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj7 = 0;
		int num = obj3 + 16;
		((int*)num)->m_value = value;
		float unscaledTime = Time.unscaledTime;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5+A0]");
		object obj9 = 0;
		float num2 = unscaledTime + 20f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserDataRequest updateUserDataRequest = default;
		updateUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		string value2 = ((int*)num)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC038]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
		object obj10 = 0;
		dictionary.Add((System.__Canon)key, (System.__Canon)(object)value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E48]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC050]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC030]");
		object obj13 = 0;
		object obj14 = updateUserDataRequest + 32;
		obj14 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num3 = (nint)obj12;
		Action<System.__Canon> action = default;
		action._002Ector(obj3, (IntPtr)obj12);
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v23+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+18]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v13+18]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		object obj20 = 0;
		object obj21 = obj3;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj22 = !flag4;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v17+A0]");
				obj17 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC048]");
			object obj25 = 0;
			num3 = (nint)obj25;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj17, (IntPtr)obj25);
			object obj26 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v16+A0]");
			object obj27 = (nint)0 + (nint)24;
			obj27 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj20 = 0;
			obj21 = action2;
			errorCallback = (Action<PlayFabError>)action2;
		}
		object obj28 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj29 = !flag5;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserData(updateUserDataRequest, (Action<UpdateUserDataResult>)action, errorCallback);
	}

	static GillaCaveFuses()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 4294967295L;
	}
}
