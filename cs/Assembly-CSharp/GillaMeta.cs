using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;

public class GillaMeta : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass118_0
	{
		public bool open;
	}

	private class Answer
	{
		public bool done;

		public bool ok;

		public string why;

		public User user;

		public Answer()
		{
			//IL_0010: Expected Obj, but got I
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			object obj2 = this + 24;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Action<string>> _003C_003E9__15_3;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24F0]");
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

		internal void _003CStart_003Eb__15_3(Action<string> done)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_007e: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2500]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2510]");
			object obj4 = 0;
			object obj5 = obj2 + 16;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Request<UserProof> userProof = Users.GetUserProof();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Callback val = default;
			val._002Ector(obj2, (IntPtr)obj4);
			Request<System.__Canon> request = ((Request<System.__Canon>)(object)userProof).OnComplete(val);
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public Answer a;

		internal void _003CStart_003Eb__0(Message<PlatformInitialize> m)
		{
			//IL_0063: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected I4, but got Unknown
			//IL_0086: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			//IL_003a: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			Answer answer = a;
			object obj;
			if (m != null)
			{
				bool isError = m.IsError;
				obj = (isError ? 1 : 0) ^ 1;
				bool flag = answer == null;
				object obj2 = !flag;
				Message<PlatformInitialize> message = null;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				Message<PlatformInitialize> message = m;
				obj = 0;
			}
			bool ok = (byte)(obj & 1) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
			object obj3 = 0;
			answer.ok = ok;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Why(m);
			object obj6 = a + 24;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Answer answer2 = a;
			answer2.done = true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public Answer a;

		internal void _003CStart_003Eb__1(Message m)
		{
			//IL_0063: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected I4, but got Unknown
			//IL_0086: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			//IL_003a: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			Answer answer = a;
			object obj;
			if (m != null)
			{
				bool isError = m.IsError;
				obj = (isError ? 1 : 0) ^ 1;
				bool flag = answer == null;
				object obj2 = !flag;
				Message message = null;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				Message message = m;
				obj = 0;
			}
			bool ok = (byte)(obj & 1) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
			object obj3 = 0;
			answer.ok = ok;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Why(m);
			object obj6 = a + 24;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Answer answer2 = a;
			answer2.done = true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_2
	{
		public Answer a;

		internal void _003CStart_003Eb__2(Message<User> m)
		{
			//IL_0061: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_0035: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I
			//IL_01e7: Expected Obj, but got I
			//IL_0124: Expected Obj, but got I
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected Obj, but got Unknown
			//IL_0176: Expected Obj, but got I
			//IL_01a0: Expected Obj, but got I4
			object obj2;
			if (m != null)
			{
				bool isError = m.IsError;
				bool flag = !isError;
				object obj = !flag;
				obj2 = 0;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [m @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.User>)+40]");
					obj2 = 0;
				}
			}
			else
			{
				obj2 = 0;
			}
			object obj3 = a + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Answer answer = a;
			User user = answer.user;
			object obj4;
			if (answer.user != null)
			{
				bool flag2 = user.ID__BackingField == 0;
				bool ok = !flag2;
				answer.ok = ok;
				if (user.ID__BackingField != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					obj4 = 0;
					goto IL_0235;
				}
			}
			else
			{
				answer.ok = false;
			}
			string text2;
			if (m != null && m.IsError)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v14+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = Why(m);
				text2 = text;
				goto IL_0242;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2518]");
			obj4 = 0;
			goto IL_0235;
			IL_0242:
			object obj8 = answer + 24;
			obj8 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Answer answer2 = a;
			answer2.done = true;
			return;
			IL_0235:
			text2 = (string)obj4;
			goto IL_0242;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_3
	{
		public Action<string> done;

		internal void _003CStart_003Eb__4(Message<UserProof> proof)
		{
			//IL_0031: Expected Obj, but got I4
			//IL_003a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I4
			//IL_00ef: Expected Obj, but got I4
			//IL_0058: Expected Obj, but got I
			//IL_008d: Expected Obj, but got I
			Action<string> action = done;
			bool isError = proof.IsError;
			bool flag = !isError;
			object obj = !flag;
			object obj2 = 0;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [proof @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.UserProof>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [proof @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.UserProof>)+40]");
				if ((nint)0 == 0)
				{
					goto IL_00cc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v4+10]");
				obj2 = 0;
			}
			goto IL_0092;
			IL_0092:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X20_v2 (System.Action`1<System.String>)+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X20_v2 (System.Action`1<System.String>)+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X20_v2 (System.Action`1<System.String>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v52 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_00cc;
			IL_00cc:
			bool flag2 = action == null;
			object obj7 = !flag2;
			obj2 = 0;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0092;
		}
	}

	private sealed class _003CAwait_003Ed__17 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Answer a;

		private float _003Cuntil_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CAwait_003Ed__17(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Expected I4, but got I8
			//IL_003b: Expected Obj, but got I4
			//IL_0137: Expected I4, but got Obj
			//IL_00b1: Expected Obj, but got I4
			//IL_0058: Expected I4, but got I8
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected Obj, but got Unknown
			//IL_00fd: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_011b;
				}
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num = realtimeSinceStartup + 20f;
				_003Cuntil_003E5__2 = num;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			Answer answer = a;
			if (a != null)
			{
				bool flag2 = (byte)(~(answer.done ? 1u : 0u)) != 0;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					float realtimeSinceStartup2 = Time.realtimeSinceStartup;
					if (realtimeSinceStartup2 < _003Cuntil_003E5__2)
					{
						object obj3 = this + 24;
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						return true;
					}
				}
				goto IL_011b;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011b:
			return false;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	public const string AppId = null;

	private static string Problem__BackingField;

	private static bool Passed__BackingField;

	public const float StepTimeout = default(float);

	public const float RetryFirst = default(float);

	public const float RetryMost = default(float);

	private const float AskAgainAfter = default(float);

	public static string Problem
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
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
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
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
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool Passed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
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
		//IL_006f: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj7 = 0;
		obj7 = obj3;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+A0]");
		object obj11 = 0;
		_ = 0;
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (UnityEngine.Application.isEditor)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24D0]");
		object value = 0;
		if (string.IsNullOrEmpty((string)value))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24C0]");
			object message = 0;
			Debug.Log(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		UnityEngine.Object obj11 = default;
		bool flag4 = obj11 != null;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24C8]");
			object obj14 = 0;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj14);
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24B0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		}
	}

	private IEnumerator Start()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private static IEnumerator Await(Answer a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = a;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private static string Why(Message m)
	{
		//IL_00d7: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I4
		object result;
		if (m != null)
		{
			if (m.IsError)
			{
				string text = ((Message<ChallengeEntryList>)m).GetString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24E8]");
				result = 0;
				if (text != null)
				{
					object obj = text + 24;
					bool flag = string.IsNullOrEmpty((string)obj);
					bool flag2 = !flag;
					object obj2 = !flag2;
					object obj3 = ~obj2;
					if (obj3 != null)
					{
						result = obj;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				result = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
			result = 0;
		}
		return (string)result;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
		object obj6 = 0;
		if (obj6 != null)
		{
			Request.RunCallbacks(0u);
		}
	}

	static GillaMeta()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = obj;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
