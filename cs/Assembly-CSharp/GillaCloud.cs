using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.Networking;

public class GillaCloud : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public int sending;

		internal void _003CSave_003Eb__0(UpdateUserDataResult _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I4
			//IL_005e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bits = GillaCaveFuses.Bits;
			if (bits == sending)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC018]");
				object key = 0;
				PlayerPrefs.SetInt((string)key, 0);
				PlayerPrefs.Save();
			}
		}
	}

	[Serializable]
	public class Reply
	{
		public string ticket;

		public string player;

		public string refused;

		public string banReason;

		public long banUntil;

		public bool banForever;

		public int coins;

		public int bolts;

		public int xp;

		public int day;

		public int dailyGiven;

		public long nextDaily;

		public string[] owned;

		public int[] claimed;
	}

	[Serializable]
	private class SignInBody
	{
		public string metaId;

		public string nonce;

		public string failed;

		public int build;
	}

	[Serializable]
	private class ModReply
	{
		public string refused;

		public string did;

		public string name;

		public long until;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ShiftAuth.Outcome> _003C_003E9__54_0;

		public static Action<string> _003C_003E9__55_1;

		public static Action<UpdateUserTitleDisplayNameResult> _003C_003E9__98_0;

		public static Action<PlayFabError> _003C_003E9__98_1;

		public static Action<PlayFabError> _003C_003E9__109_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A8]");
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

		internal unsafe void _003CBeginShiftAuth_003Eb__54_0(ShiftAuth.Outcome outcome)
		{
			//IL_0010: Expected Obj, but got I
			//IL_01c4: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_003d: Expected VT, but got Ref
			//IL_005c: Expected Obj, but got I
			//IL_008b: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I4
			//IL_0125: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_00e5: Expected I8, but got I4
			//IL_01ea: Expected Obj, but got I
			//IL_020c: Expected Obj, but got I4
			//IL_0194: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj4 = 0;
			object obj5 = default;
			NetworkBootstrap.NoteLogin((ShiftAuth.Outcome)(&obj5));
			bool flag2 = outcome.Kind != (ShiftAuth.FailKind)4;
			IntPtr intPtr = default;
			string text = (string)(nint)intPtr;
			bool flag3 = false;
			if (!flag2)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v15+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text = (string)obj7;
				Ban(0L, forever: false, (string)obj7);
				flag3 = false;
			}
			if (outcome.Success)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v8+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v3+8]");
				BindPhoton((string)0);
			}
		}

		internal void _003CBindPhoton_003Eb__55_1(string why)
		{
			//IL_0010: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I
			//IL_006d: Expected Obj, but got I
			//IL_008f: Expected Obj, but got I4
			//IL_00b3: Expected Obj, but got I
			//IL_00bc: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCD8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
			object obj6 = (nint)0 + (nint)64;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string message = (string)obj3 + why;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}

		internal void _003CArrive_003Eb__98_0(UpdateUserTitleDisplayNameResult _)
		{
		}

		internal void _003CArrive_003Eb__98_1(PlayFabError error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCE0]");
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

		internal void _003CLoadProfile_003Eb__109_1(PlayFabError error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCE8]");
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

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public GillaCloud _003C_003E4__this;

		public int count;

		public string function;

		internal void _003CSendNext_003Eb__0(Reply reply)
		{
			//IL_0076: Expected Obj, but got I4
			//IL_0094: Expected Obj, but got I
			//IL_00a4: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I
			//IL_00fe: Expected Obj, but got I4
			GillaCloud gillaCloud = _003C_003E4__this;
			((List<System.__Canon>)(object)gillaCloud.queue).RemoveRange(0, count);
			GillaCloud gillaCloud2 = _003C_003E4__this;
			gillaCloud2.sendingCount = 0;
			gillaCloud2.SaveQueue();
			bool flag = string.IsNullOrEmpty(reply.refused);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCF8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj3 = 0;
				string message = (string)obj2 + function + (string)obj3 + reply.refused;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
			}
			GillaCloud gillaCloud3 = _003C_003E4__this;
			float unscaledTime = Time.unscaledTime;
			float nextSend = unscaledTime + 3f;
			gillaCloud3.nextSend = nextSend;
			_003C_003E4__this.Adopt(reply);
		}

		internal void _003CSendNext_003Eb__1(string why)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_00b7: Expected Obj, but got I4
			GillaCloud gillaCloud = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD00]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD08]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj3 = 0;
			gillaCloud.sendingCount = 0;
			float unscaledTime = Time.unscaledTime;
			float nextSend = unscaledTime + 20f;
			gillaCloud.nextSend = nextSend;
			string message = (string)obj + function + (string)obj2 + why;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public Action<string> failed;

		public string function;

		public Action<string> done;

		internal void _003CRun_003Eb__0(ExecuteCloudScriptResult result)
		{
			//IL_0204: Expected Obj, but got I
			//IL_0238: Expected Obj, but got I4
			//IL_0265: Expected Obj, but got I
			//IL_0275: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_029c: Expected Obj, but got I
			//IL_02ac: Expected Obj, but got I
			//IL_013e: Expected Obj, but got I
			//IL_014e: Expected Obj, but got I
			//IL_03d5: Expected Obj, but got I4
			//IL_02e7: Expected Obj, but got I
			//IL_0375: Expected Obj, but got I
			//IL_0385: Expected Obj, but got I
			//IL_0395: Expected Obj, but got I
			//IL_00ac: Expected Obj, but got I
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected Obj, but got Unknown
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Expected Obj, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected Obj, but got Unknown
			//IL_01c3: Expected Obj, but got I
			ScriptExecutionError error = result.Error;
			bool flag = result.Error == null;
			ExecuteCloudScriptResult executeCloudScriptResult = result;
			if (flag)
			{
				goto IL_01f4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD20]");
			object obj = 0;
			bool flag2 = error.Error == (string)obj;
			bool flag3 = !flag2;
			object obj2 = !flag3;
			string text2;
			string text3;
			string text4;
			Action<string> action;
			if (obj2 == null)
			{
				ScriptExecutionError error2 = result.Error;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj3 = 0;
				string text = (string)((error2.Message != null) ? error2.Message : obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD10]");
				object obj4 = 0;
				if (!text.Contains((string)obj4))
				{
					ScriptExecutionError error3 = result.Error;
					bool flag4 = result.Error == null;
					executeCloudScriptResult = (ExecuteCloudScriptResult)obj4;
					if (flag4)
					{
						goto IL_01f4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
					object obj5 = 0;
					text2 = error3.Error;
					text3 = error3.Message;
					action = failed;
					text4 = (string)obj5;
					goto IL_03a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC750]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD18]");
			object obj7 = 0;
			action = failed;
			text4 = function;
			text2 = (string)obj6;
			text3 = (string)obj7;
			goto IL_03a6;
			IL_01f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF28]");
			object obj8 = 0;
			action = done;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF20]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726194");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v12+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0328;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v12+98]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X10_v9-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj16--;
				obj17 += 16;
				if ((nint)obj16 != 1)
				{
					continue;
				}
				goto IL_0328;
			}
			object obj18 = obj17 + 3;
			object obj19 = obj13 + obj18;
			object obj20 = obj19 + 312;
			goto IL_0407;
			IL_0407:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X0_v11] (should have been resolved before IL gen)");
			goto IL_0365;
			IL_0365:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X21_v3 (System.Action`1<System.String>)+40]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X21_v3 (System.Action`1<System.String>)+28]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X21_v3 (System.Action`1<System.String>)+18]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v189 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_039f;
			IL_03a6:
			string text5 = text2 + text4 + text3;
			bool flag6 = action == null;
			object obj24 = !flag6;
			if (obj24 != null)
			{
				goto IL_0365;
			}
			goto IL_039f;
			IL_0328:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0407;
			IL_039f:
			throw new NullReferenceException();
		}

		internal void _003CRun_003Eb__1(PlayFabError error)
		{
			//IL_0060: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I4
			//IL_0163: Expected Obj, but got I
			//IL_0173: Expected Obj, but got I
			//IL_019d: Expected Obj, but got I4
			//IL_00d0: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I4
			//IL_01bb: Expected Obj, but got I
			//IL_0151: Expected Obj, but got I
			Action<string> action = failed;
			string text = error.GenerateErrorReport();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ X20_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
			if (error.Error != (PlayFabErrorCode)1074)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v10+A0]");
			object obj5 = 0;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v3+8]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v15+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v15+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12+8]");
				((GillaCloud)0).SessionLost();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public Action<bool, string> done;

		internal void _003CModAct_003Eb__0(string json)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_01da: Expected Obj, but got I
			//IL_01ea: Expected Obj, but got I
			//IL_01fa: Expected Obj, but got I
			//IL_020a: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I
			//IL_0112: Expected Obj, but got I4
			//IL_02bf: Expected Obj, but got I4
			//IL_0140: Expected Obj, but got I
			//IL_015e: Expected Obj, but got I4
			//IL_006b: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got I
			//IL_018c: Expected Obj, but got I
			//IL_019c: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I
			//IL_009a: Expected Obj, but got I
			//IL_00aa: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD28]");
			object obj = 0;
			object obj2 = obj;
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(json);
			object obj6;
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (System.__Canon)+10]");
				bool flag = string.IsNullOrEmpty((string)0);
				Action<bool, string> action = done;
				if (flag)
				{
					bool flag2 = done == null;
					obj2 = 0;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+40]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+28]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+18]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (System.__Canon)+18]");
						if ((nint)0 == 0)
						{
						}
						obj6 = 1;
						goto IL_02c4;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v18+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (System.__Canon)+10]");
					string text = ModRefusal((string)0);
					bool flag4 = done == null;
					obj2 = 0;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+40]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+28]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6 (System.Action`2<System.Boolean, System.String>)+18]");
						object obj5 = 0;
						goto IL_02b6;
					}
				}
			}
			else
			{
				Action<bool, string> action2 = done;
				if (done != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD30]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7 (System.Action`2<System.Boolean, System.String>)+40]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7 (System.Action`2<System.Boolean, System.String>)+28]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7 (System.Action`2<System.Boolean, System.String>)+18]");
					object obj5 = 0;
					string text2 = (string)obj10;
					goto IL_02b6;
				}
			}
			throw new NullReferenceException();
			IL_02b6:
			obj6 = 0;
			goto IL_02c4;
			IL_02c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v146 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void _003CModAct_003Eb__1(string why)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I
			//IL_00f9: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I
			//IL_005d: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD38]");
			object value = 0;
			Action<bool, string> action = done;
			object obj;
			if (why.StartsWith((string)value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC420]");
				obj = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF60]");
				object obj2 = 0;
				bool flag = why == (string)obj2;
				bool flag2 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD40]");
				obj = 0;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3E0]");
					obj = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (System.Action`2<System.Boolean, System.String>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (System.Action`2<System.Boolean, System.String>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v3 (System.Action`2<System.Boolean, System.String>)+18]");
			object obj7 = 0;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v101 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public string function;

		public Action<Reply> done;

		public Action<string> failed;

		public GillaCloud _003C_003E4__this;

		internal void _003CCall_003Eb__0(ExecuteCloudScriptResult result)
		{
			//IL_07de: Expected Obj, but got I
			//IL_042c: Expected Obj, but got I
			//IL_0456: Expected Obj, but got I4
			//IL_0483: Expected Obj, but got I
			//IL_0493: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			//IL_0084: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I
			//IL_0180: Expected Obj, but got I
			//IL_01a7: Expected Obj, but got I
			//IL_01d1: Expected Obj, but got I4
			//IL_04e2: Expected Obj, but got I
			//IL_04ff: Expected Obj, but got I
			//IL_0207: Expected Obj, but got I
			//IL_0239: Expected Obj, but got I
			//IL_0249: Expected Obj, but got I
			//IL_085c: Expected Obj, but got I
			//IL_053a: Expected Obj, but got I
			//IL_028f: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I
			//IL_0675: Expected I, but got Obj
			//IL_067d: Expected Obj, but got I
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Expected Obj, but got Unknown
			//IL_06d9: Expected Obj, but got I
			//IL_077a: Expected Obj, but got I4
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Expected Obj, but got Unknown
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b3: Expected Obj, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected Obj, but got Unknown
			//IL_02df: Expected Obj, but got I4
			//IL_0548: Unknown result type (might be due to invalid IL or missing references)
			//IL_054d: Expected Obj, but got Unknown
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Expected Obj, but got Unknown
			//IL_05f9: Expected Obj, but got I
			//IL_0609: Expected Obj, but got I
			//IL_0619: Expected Obj, but got I
			//IL_030d: Expected Obj, but got I
			//IL_031d: Expected Obj, but got I
			//IL_032d: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_0379: Expected Obj, but got I
			//IL_03d1: Expected Obj, but got I4
			//IL_03f7: Expected Obj, but got I
			//IL_0407: Expected Obj, but got I
			//IL_0417: Expected Obj, but got I
			bool flag = result == null;
			string text = (string)(object)result;
			IntPtr intPtr = default;
			string text2 = (string)(nint)intPtr;
			ExecuteCloudScriptResult executeCloudScriptResult = result;
			object obj6;
			object obj7;
			ScriptExecutionError scriptExecutionError;
			object obj8;
			if (!flag)
			{
				ScriptExecutionError error = result.Error;
				bool flag2 = result.Error == null;
				ExecuteCloudScriptResult executeCloudScriptResult2 = result;
				if (flag2)
				{
					goto IL_041c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD20]");
				object obj = 0;
				text = (string)obj;
				bool flag3 = error.Error == (string)obj;
				bool flag4 = !flag3;
				object obj2 = !flag4;
				if (obj2 != null)
				{
					goto IL_0160;
				}
				ScriptExecutionError error2 = result.Error;
				bool flag5 = result.Error == null;
				text2 = null;
				executeCloudScriptResult = result;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj3 = 0;
					string text3 = (string)((error2.Message != null) ? error2.Message : obj3);
					bool flag6 = text3 == null;
					text2 = null;
					executeCloudScriptResult = result;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD10]");
						object obj4 = 0;
						if (text3.Contains((string)obj4))
						{
							goto IL_0160;
						}
						ScriptExecutionError error3 = result.Error;
						bool flag7 = result.Error == null;
						executeCloudScriptResult2 = (ExecuteCloudScriptResult)obj4;
						if (flag7)
						{
							goto IL_041c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
						object obj5 = 0;
						text2 = error3.Message;
						Action<string> action = failed;
						text = (string)obj5;
						string text4 = error3.Error + (string)obj5 + error3.Message;
						bool flag8 = failed == null;
						obj6 = 0;
						executeCloudScriptResult = result;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X19_v7 (System.Action`1<System.String>)+40]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X19_v7 (System.Action`1<System.String>)+28]");
							scriptExecutionError = (ScriptExecutionError)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X19_v7 (System.Action`1<System.String>)+18]");
							obj8 = 0;
							goto IL_081e;
						}
					}
				}
			}
			goto IL_074e;
			IL_057b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_084c;
			IL_041c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF28]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v15+E4]");
			bool flag9 = (nint)0 == 0;
			object obj11 = !flag9;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF20]");
			object obj13 = 0;
			object obj14 = obj12;
			text2 = (string)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3726194");
			object obj15 = default;
			object obj16 = default;
			object obj17 = default;
			object obj18 = default;
			object obj19 = default;
			if (obj15 != null)
			{
				obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF18]");
				obj17 = 0;
				executeCloudScriptResult = (ExecuteCloudScriptResult)result.FunctionResult;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v19+12E]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v19+12E]");
				if ((nint)0 == 0)
				{
					goto IL_057b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v19+98]");
				obj19 = (nint)0 + (nint)8;
				goto IL_0828;
			}
			NullReferenceException ex = new NullReferenceException();
			bool flag10 = (nint)obj12 != 1;
			NullReferenceException ex2 = ex;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ExecuteCloudScriptResult executeCloudScriptResult3 = default;
				nint num = (nint)executeCloudScriptResult3;
				text = (string)num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj21 = default;
				object obj20 = obj21 & 1;
				bool flag11 = obj20 == null;
				executeCloudScriptResult = executeCloudScriptResult3;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					goto IL_06c9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj22 = executeCloudScriptResult;
				obj14 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				text2 = null;
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0160:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD60]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD58]");
			object obj24 = 0;
			string message = (string)obj23 + function + (string)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v31+E4]");
			bool flag12 = (nint)0 == 0;
			object obj27 = !flag12;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD50]");
			object obj28 = 0;
			Action<Reply> action2 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj29 = default;
			obj29._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC750]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD18]");
			object obj31 = 0;
			text = function;
			text2 = (string)obj31;
			string text5 = (string)obj30 + function + (string)obj31;
			bool flag13 = obj29 == null;
			obj6 = 0;
			executeCloudScriptResult = (ExecuteCloudScriptResult)obj29;
			if (!flag13)
			{
				object obj32 = obj29 + 32;
				obj32 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag14 = done == null;
				obj6 = 0;
				text = text5;
				executeCloudScriptResult = (ExecuteCloudScriptResult)obj29;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (System.Action`1<GillaCloud+Reply>)+40]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (System.Action`1<GillaCloud+Reply>)+28]");
					scriptExecutionError = (ScriptExecutionError)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v8 (System.Action`1<GillaCloud+Reply>)+18]");
					obj8 = 0;
					goto IL_081e;
				}
			}
			goto IL_074e;
			IL_0828:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v12-8]");
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
				goto IL_057b;
			}
			object obj33 = obj19 + 3;
			object obj34 = obj16 + obj33;
			object obj35 = obj34 + 312;
			goto IL_084c;
			IL_084c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v31+8]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v402 @ X0_v31] (should have been resolved before IL gen)");
			string json = default;
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(json);
			if (_Canon == null)
			{
				goto IL_06c9;
			}
			Action<Reply> action3 = done;
			bool flag15 = done == null;
			text = (string)(object)_Canon;
			if (flag15)
			{
				goto IL_074e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v24 (System.Action`1<GillaCloud+Reply>)+40]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v24 (System.Action`1<GillaCloud+Reply>)+28]");
			scriptExecutionError = (ScriptExecutionError)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v24 (System.Action`1<GillaCloud+Reply>)+18]");
			obj8 = 0;
			goto IL_081e;
			IL_074e:
			throw new NullReferenceException();
			IL_081e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v422 @ X3_v4 (System.Object) (should have been resolved before IL gen)");
			goto IL_0828;
			IL_06c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD68]");
			object obj36 = 0;
			executeCloudScriptResult = (ExecuteCloudScriptResult)(object)failed;
			text = (string)obj36;
			string text6 = function + (string)obj36;
			bool flag16 = failed == null;
			text2 = null;
			if (flag16)
			{
				goto IL_074e;
			}
			obj7 = executeCloudScriptResult.FunctionResult;
			scriptExecutionError = executeCloudScriptResult.Error;
			obj8 = executeCloudScriptResult.CustomData;
			goto IL_081e;
		}

		internal void _003CCall_003Eb__1(PlayFabError error)
		{
			Action<string> action = failed;
			string text = error.GenerateErrorReport();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ X21_v2 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
			if (error.Error == (PlayFabErrorCode)1074)
			{
				_003C_003E4__this.SessionLost();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public string uid;

		internal void _003CBindPhoton_003Eb__0(string json)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0165: Expected Obj, but got I4
			//IL_01b4: Expected Obj, but got I
			//IL_01bd: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_0114: Expected Obj, but got I4
			//IL_003c: Expected Obj, but got I
			//IL_0094: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			object obj4 = (nint)0 + (nint)64;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (json != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD78]");
				object value = 0;
				if (json.Contains((string)value))
				{
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v17+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v17+A0]");
					object obj7 = (nint)0 + (nint)56;
					obj7 = uid;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD70]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj9 = 0;
			string message = (string)obj8 + json;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public GillaCloud _003C_003E4__this;

		public int route;

		public int tried;

		public Action<Reply> _003C_003E9__1;

		public Action<string> _003C_003E9__2;

		internal void _003CTryRoute_003Eb__0(string nonce)
		{
			//IL_0054: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0370: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			//IL_0139: Expected Obj, but got I4
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected Obj, but got Unknown
			//IL_01f8: Expected Obj, but got I4
			//IL_02a7: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got I
			//IL_017e: Expected Obj, but got I
			//IL_0186: Expected I, but got Obj
			//IL_0194: Expected I, but got Obj
			//IL_02ea: Expected Obj, but got I
			//IL_0216: Expected Obj, but got I
			//IL_0230: Expected Obj, but got I
			//IL_0238: Expected I, but got Obj
			//IL_0246: Expected I, but got Obj
			//IL_01b6: Expected Obj, but got I4
			//IL_0268: Expected Obj, but got I4
			if (string.IsNullOrEmpty(nonce))
			{
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE028]");
					object why = 0;
					_003C_003E4__this.Failed((string)why);
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9+A0]");
				object obj4 = 0;
				object obj5 = obj4;
				if (obj4 != null)
				{
					int num = route;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7+18]");
					bool flag2 = (nint)num < (nint)0;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_032f;
					}
					GillaCloud gillaCloud = _003C_003E4__this;
					if ((object)_003C_003E4__this != null)
					{
						object obj7 = obj4 + route;
						object obj8 = this + 32;
						Action<System.__Canon> got = (Action<System.__Canon>)obj8;
						bool flag3 = obj8 == null;
						object obj9 = !flag3;
						Action<System.__Canon> action = null;
						IntPtr intPtr = default;
						nint num2 = intPtr;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC150]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD80]");
							object obj11 = 0;
							num2 = (nint)obj11;
							Action<System.__Canon> action2 = default;
							action2._002Ector((object)this, (IntPtr)obj11);
							_003C_003E9__1 = (Action<Reply>)action2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj12 = 0;
							action = action2;
							got = action2;
						}
						object obj13 = this + 40;
						Action<System.__Canon> failed = (Action<System.__Canon>)obj13;
						bool flag4 = obj13 == null;
						object obj14 = !flag4;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD88]");
							object obj16 = 0;
							num2 = (nint)obj16;
							Action<System.__Canon> action3 = default;
							action3._002Ector((object)this, (IntPtr)obj16);
							_003C_003E9__2 = (Action<string>)action3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj12 = 0;
							failed = action3;
							action = action3;
						}
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v12+E4]");
						bool flag5 = (nint)0 == 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+20]");
						IEnumerator routine = AskSignIn((string)0, gillaCloud.metaId, nonce, (Action<Reply>)got, (Action<string>)failed);
						if ((object)_003C_003E4__this != null)
						{
							Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
							return;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_032f;
			IL_032f:
			throw new IndexOutOfRangeException();
		}

		internal void _003CTryRoute_003Eb__1(Reply reply)
		{
			//IL_0010: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I
			//IL_013f: Expected Obj, but got I4
			//IL_0081: Expected Obj, but got I
			//IL_00b8: Expected Obj, but got I4
			//IL_0112: Expected I8, but got I
			//IL_01a1: Expected Obj, but got I
			//IL_01cb: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got I
			//IL_0227: Expected Obj, but got I4
			//IL_031d: Expected Obj, but got I
			//IL_0262: Expected Obj, but got I
			//IL_0291: Expected Obj, but got I
			//IL_02ac: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC260]");
			object key = 0;
			int num = PlayerPrefs.GetInt((string)key, 0);
			if (num != route)
			{
				PlayerPrefs.SetInt((string)key, route);
				PlayerPrefs.Save();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9C8]");
			object obj = 0;
			if (reply.refused == (string)obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj2 = 0;
				string banReason = reply.banReason;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v30+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = !reply.banForever;
				bool forever = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X19_v4 (System.String)+30]");
				Ban(0L, forever, reply.banReason);
				return;
			}
			bool flag3 = string.IsNullOrEmpty(reply.ticket);
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 != null || string.IsNullOrEmpty(reply.player))
			{
				_003C_003E4__this.Failed(reply.refused);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayFabClientAPI.ForgetAllCredentials();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v19+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v10+10]");
			object obj13 = (nint)0 + (nint)16;
			obj13 = reply.ticket;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v11+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v12+10]");
			object obj16 = (nint)0 + (nint)24;
			obj16 = reply.player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_003C_003E4__this.Arrive(reply.player);
		}

		internal void _003CTryRoute_003Eb__2(string why)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0053: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_01c3: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I4
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected Obj, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected Obj, but got Unknown
			//IL_018f: Expected I4, but got Obj
			//IL_012b: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE000]");
			object value = 0;
			if (why.StartsWith((string)value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+A0]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = tried + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+18]");
				if ((nint)obj6 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v12+A0]");
						object obj9 = 0;
						obj5 = obj9;
					}
					object obj10 = route + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+18]");
					object obj11 = obj10 / 0;
					int num = tried + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+18]");
					object obj12 = obj11 * 0;
					int num2 = obj10 - obj12;
					_003C_003E4__this.TryRoute(num2, num);
					return;
				}
			}
			_003C_003E4__this.Failed(why);
		}
	}

	private sealed class _003CAskSignIn_003Ed__89 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string metaId;

		public string nonce;

		public string url;

		public Action<Reply> got;

		public Action<string> failed;

		private UnityWebRequest _003Crequest_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CAskSignIn_003Ed__89(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				object obj = _003C_003E1__state + 3;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					return;
				}
			}
			_003C_003Em__Finally1();
		}

		private unsafe bool MoveNext()
		{
			//IL_0205: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_0081: Expected Obj, but got I4
			//IL_12fe: Expected Obj, but got I4
			//IL_1303: Expected I, but got Obj
			//IL_124a: Expected Obj, but got I
			//IL_0275: Expected Obj, but got I
			//IL_027d: Expected I, but got Obj
			//IL_0285: Expected Obj, but got I
			//IL_02a4: Expected Obj, but got I
			//IL_02ac: Expected I, but got Obj
			//IL_132a: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			//IL_05c6: Expected I, but got Obj
			//IL_1282: Expected Obj, but got I
			//IL_0455: Expected I, but got Obj
			//IL_02e7: Expected Obj, but got I
			//IL_02ff: Expected I, but got Obj
			//IL_00f8: Expected Obj, but got I
			//IL_03ad: Expected Obj, but got I
			//IL_03d7: Expected Obj, but got I4
			//IL_0a0b: Expected Obj, but got I
			//IL_0a35: Expected Obj, but got I4
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e2: Expected Obj, but got Unknown
			//IL_0602: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Expected Obj, but got Unknown
			//IL_1447: Expected Obj, but got I
			//IL_144f: Expected I, but got Obj
			//IL_1465: Expected Obj, but got I
			//IL_148f: Expected Obj, but got I
			//IL_031e: Expected Obj, but got I
			//IL_0336: Expected I, but got Obj
			//IL_033b: Expected I, but got Obj
			//IL_062c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Expected Obj, but got Unknown
			//IL_0639: Expected Obj, but got I
			//IL_0653: Expected Obj, but got I
			//IL_067d: Expected Obj, but got I4
			//IL_0556: Expected Obj, but got I4
			//IL_04a4: Expected Obj, but got I
			//IL_04b4: Expected Obj, but got I
			//IL_04f6: Expected I, but got Obj
			//IL_0a9a: Expected I, but got Obj
			//IL_12c9: Expected Obj, but got I4
			//IL_0144: Expected Obj, but got I4
			//IL_042a: Expected Obj, but got I
			//IL_0437: Expected I, but got Obj
			//IL_0a6a: Expected Obj, but got I
			//IL_13ba: Expected Obj, but got I4
			//IL_15a0: Expected Obj, but got I
			//IL_15c5: Expected I, but got Obj
			//IL_0586: Expected Obj, but got I
			//IL_0596: Expected Obj, but got I
			//IL_01da: Expected Obj, but got I4
			//IL_01df: Expected I, but got Obj
			//IL_0514: Expected Obj, but got I
			//IL_0ae4: Expected Obj, but got I4
			//IL_136c: Expected Obj, but got I4
			//IL_138b: Expected I, but got Obj
			//IL_1686: Expected Obj, but got I
			//IL_1696: Expected Obj, but got I
			//IL_0174: Expected Obj, but got I
			//IL_0184: Expected Obj, but got I
			//IL_0b13: Expected I, but got Obj
			//IL_15f1: Expected Obj, but got I
			//IL_161b: Expected Obj, but got I
			//IL_162b: Expected Obj, but got I
			//IL_1641: Expected Obj, but got I
			//IL_13f1: Expected I, but got Obj
			//IL_06d8: Expected Obj, but got I4
			//IL_072e: Expected I, but got Obj
			//IL_0751: Expected Obj, but got I
			//IL_076b: Expected Obj, but got I
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0794: Expected Obj, but got Unknown
			//IL_07b6: Expected Obj, but got I
			//IL_07c8: Expected I4, but got I8
			//IL_1429: Expected Obj, but got I4
			//IL_0b6f: Expected Obj, but got I
			//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7d: Expected Obj, but got Unknown
			//IL_0b9f: Expected Obj, but got I
			//IL_080e: Expected I, but got Obj
			//IL_16cb: Expected Obj, but got I
			//IL_16db: Expected Obj, but got I
			//IL_0be1: Expected I, but got Obj
			//IL_083e: Expected Obj, but got I
			//IL_0721: Expected Obj, but got I
			//IL_0c10: Expected Obj, but got I8
			//IL_0c2c: Expected I, but got Obj
			//IL_087d: Expected I, but got Obj
			//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c48: Expected Obj, but got Unknown
			//IL_0c76: Expected Obj, but got I4
			//IL_0c86: Expected Obj, but got I4
			//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cab: Expected Obj, but got Unknown
			//IL_0cb8: Expected I, but got Obj
			//IL_08c7: Expected I, but got Obj
			//IL_0cd6: Expected Obj, but got I
			//IL_0cde: Expected I, but got Obj
			//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cec: Expected Obj, but got Unknown
			//IL_08e5: Expected Obj, but got I
			//IL_08f5: Expected Obj, but got I
			//IL_0938: Expected I, but got Obj
			//IL_0d4b: Expected Obj, but got I8
			//IL_0d67: Expected I, but got Obj
			//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d83: Expected Obj, but got Unknown
			//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b2: Expected Obj, but got Unknown
			//IL_0e64: Expected Obj, but got I
			//IL_0e6c: Expected I, but got Obj
			//IL_09ed: Expected I, but got Obj
			//IL_14e0: Expected Obj, but got I4
			//IL_14f0: Expected Obj, but got I4
			//IL_1510: Unknown result type (might be due to invalid IL or missing references)
			//IL_1515: Expected Obj, but got Unknown
			//IL_0dc2: Expected Obj, but got I
			//IL_0dec: Expected Obj, but got I4
			//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Expected Obj, but got Unknown
			//IL_0e8c: Expected Obj, but got I
			//IL_0e31: Expected Obj, but got I
			//IL_0e4f: Expected I, but got Obj
			//IL_0eb8: Expected Obj, but got I
			//IL_0ee2: Expected Obj, but got I4
			//IL_0f68: Expected I, but got Obj
			//IL_0f42: Expected Obj, but got I
			//IL_0f4a: Expected I, but got Obj
			//IL_0f98: Expected Obj, but got I
			//IL_0fa8: Expected Obj, but got I
			//IL_0fdb: Expected I, but got Obj
			//IL_0ff0: Expected Obj, but got I
			//IL_100c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1011: Expected Obj, but got Unknown
			//IL_101a: Expected Obj, but got I4
			//IL_1029: Expected I, but got Obj
			_003CAskSignIn_003Ed__89 obj18 = default;
			string text3;
			int num = default;
			nint num2 = default;
			bool flag2;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				flag2 = false;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+E4]");
					bool flag3 = (nint)0 == 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+A0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v123+58]");
					nint num4;
					if ((nint)0 > (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+E4]");
						bool flag4 = (nint)0 == 0;
						object obj6 = !flag4;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+A0]");
							obj5 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v123+50]");
						string text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v123+50]");
						if ((nint)0 == 0)
						{
							goto IL_10bf;
						}
						if (text._stringLength > 30)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+E4]");
							bool flag5 = (nint)0 == 0;
							object obj7 = !flag5;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj8 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v132+A0]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v133+50]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v133+50]");
								if ((nint)0 == 0)
								{
									goto IL_119f;
								}
							}
							string text2 = text.Substring(0, 30);
							obj3 = obj2;
							num = 0;
							text3 = (string)30;
							num2 = unchecked((nint)null);
							text = text2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+E4]");
							bool flag6 = (nint)0 == 0;
							object obj10 = !flag6;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj3 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+A0]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v130+50]");
								text = (string)0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+E4]");
						bool flag7 = (nint)0 == 0;
						object obj12 = !flag7;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj3 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v240+A0]");
						int num3 = (int)((nint)0 + (nint)88);
						string text4 = ((int*)num3)->ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDC8]");
						object obj13 = 0;
						string text5 = (string)obj13;
						string text6 = text + (string)obj13 + text4;
						num4 = (nint)text6;
						num = 0;
						text3 = text4;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj14 = 0;
						num4 = (nint)obj14;
						string text5 = (string)num2;
					}
					Encoding uTF = Encoding.UTF8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD90]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj16 = default;
					obj16._002Ector();
					bool flag8 = obj16 == null;
					num2 = unchecked((nint)null);
					if (flag8)
					{
						goto IL_104f;
					}
					object obj17 = obj16 + 16;
					obj17 = obj18.metaId;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj19 = obj16 + 24;
					obj19 = obj18.nonce;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj20 = obj16 + 32;
					obj20 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v193+E4]");
					bool flag9 = (nint)0 == 0;
					object obj23 = !flag9;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj24 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X0_v197+E4]");
					bool flag10 = (nint)0 == 0;
					object obj25 = !flag10;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj21;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X0_v197+A0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v97+30]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v97+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X0_v197+E4]");
						bool flag11 = (nint)0 == 0;
						object obj28 = !flag11;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj29 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v225+E4]");
						bool flag12 = (nint)0 == 0;
						object obj30 = !flag12;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v225+A0]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1388 @ X8_v116+30]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1388 @ X8_v116+30]");
						bool flag13 = (nint)0 == 0;
						num2 = num4;
						if (flag13)
						{
							goto IL_10cd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v117+38]");
						obj27 = 0;
					}
					string text7 = JsonUtility.ToJson(obj16);
					bool flag14 = uTF == null;
					num2 = (nint)text7;
					if (flag14)
					{
						goto IL_105d;
					}
					nint num5 = (nint)uTF;
					((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)text7, 0, num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A0]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B0]");
					object method = 0;
					UnityWebRequest unityWebRequest = default;
					unityWebRequest._002Ector(obj18.url, (string)method);
					object obj34 = obj18 + 72;
					obj34 = unityWebRequest;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A8]");
					object obj35 = 0;
					obj18._003C_003E1__state = -3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					UploadHandlerRaw uploadHandlerRaw = default;
					byte[] array = default;
					uploadHandlerRaw._002Ector(array);
					bool flag15 = obj18._003Crequest_003E5__2 == null;
					num = 0;
					text3 = null;
					num2 = (nint)array;
					if (flag15)
					{
						goto IL_106b;
					}
					obj18._003Crequest_003E5__2.uploadHandler = uploadHandlerRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF098]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					DownloadHandlerBuffer downloadHandlerBuffer = default;
					downloadHandlerBuffer._002Ector();
					bool flag16 = obj18._003Crequest_003E5__2 == null;
					num = 0;
					text3 = null;
					num2 = unchecked((nint)null);
					if (flag16)
					{
						goto IL_1079;
					}
					obj18._003Crequest_003E5__2.downloadHandler = downloadHandlerBuffer;
					bool flag17 = obj18._003Crequest_003E5__2 == null;
					num = 0;
					text3 = null;
					num2 = (nint)downloadHandlerBuffer;
					if (flag17)
					{
						goto IL_1087;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B8]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0C0]");
					object obj38 = 0;
					text3 = (string)obj38;
					obj18._003Crequest_003E5__2.SetRequestHeader((string)obj37, (string)obj38);
					bool flag18 = obj18._003Crequest_003E5__2 == null;
					num = 0;
					num2 = (nint)obj37;
					if (flag18)
					{
						goto IL_1095;
					}
					obj18._003Crequest_003E5__2.timeout = 20;
					bool flag19 = obj18._003Crequest_003E5__2 == null;
					num = 0;
					text3 = null;
					num2 = 20;
					if (flag19)
					{
						goto IL_10a3;
					}
					UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = obj18._003Crequest_003E5__2.SendWebRequest();
					object obj39 = obj18 + 24;
					obj39 = unityWebRequestAsyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj18._003C_003E1__state = 1;
					num = 0;
					text3 = null;
					num2 = (nint)unityWebRequestAsyncOperation;
					flag2 = true;
				}
				goto IL_11ec;
			}
			UnityWebRequest unityWebRequest2 = _003Crequest_003E5__2;
			_003C_003E1__state = -3;
			System.__Canon _Canon2;
			if (_003Crequest_003E5__2 != null)
			{
				string text9;
				if (unityWebRequest2.m_DownloadHandler != null)
				{
					string text8 = unityWebRequest2.m_DownloadHandler.text;
					text9 = text8;
				}
				else
				{
					text9 = null;
				}
				bool flag20 = string.IsNullOrEmpty(text9);
				bool flag21 = !flag20;
				object obj40 = !flag21;
				num2 = unchecked((nint)null);
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD48]");
					object obj41 = 0;
					num2 = (nint)obj41;
					System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(text9);
					if (_Canon != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v160 (System.__Canon)+10]");
						bool flag22 = string.IsNullOrEmpty((string)0);
						bool flag23 = !flag22;
						nint num6 = unchecked((nint)null);
						if (!flag23)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v160 (System.__Canon)+20]");
							bool flag24 = string.IsNullOrEmpty((string)0);
							bool flag25 = !flag24;
							num2 = unchecked((nint)null);
							num6 = unchecked((nint)null);
							if (!flag25)
							{
								goto IL_0349;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
						object obj42 = 0;
						object obj43 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v165+E4]");
						bool flag26 = (nint)0 == 0;
						object obj44 = !flag26;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj43 = obj42;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj45 = 0;
						num2 = (nint)obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v165+A0]");
						object obj46 = (nint)0 + (nint)80;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj47 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v84+A0]");
						object obj48 = 0;
						Action<Reply> action = obj18.got;
						_ = 0;
						if (obj18.got == null)
						{
							goto IL_1175;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v85 (System.Action`1<GillaCloud+Reply>)+28]");
						text3 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v972 @ X8_v85 (System.Action`1<GillaCloud+Reply>)+18] (should have been resolved before IL gen)");
						_Canon2 = _Canon;
						goto IL_137a;
					}
				}
				goto IL_0349;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_104f;
			IL_10b1:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_10bf;
			IL_10e9:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_10f7;
			IL_1183:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_1191;
			IL_10a3:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_10b1;
			IL_11ec:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0A24");
			OutOfMemoryException ex6 = new OutOfMemoryException();
			OutOfMemoryException ex7 = ex6;
			goto IL_1708;
			IL_104f:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_105d;
			IL_102e:
			flag2 = false;
			goto IL_11ec;
			IL_10db:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_10e9;
			IL_1121:
			IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
			goto IL_112f;
			IL_10bf:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_10cd;
			IL_10f7:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_1105;
			IL_113d:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_114b;
			IL_112f:
			IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
			goto IL_113d;
			IL_0349:
			if (obj18._003Crequest_003E5__2 == null)
			{
				goto IL_10b1;
			}
			UnityWebRequest.Result result = obj18._003Crequest_003E5__2.result;
			if (result == (UnityWebRequest.Result)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj49 = 0;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v89+E4]");
				bool flag27 = (nint)0 == 0;
				object obj51 = !flag27;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = ClockBehind();
				string text10;
				if (flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDB0]");
					object obj52 = 0;
					text10 = (string)obj52;
					nint num7 = unchecked((nint)null);
				}
				else
				{
					bool flag29 = obj18._003Crequest_003E5__2 == null;
					num2 = unchecked((nint)null);
					if (flag29)
					{
						goto IL_1183;
					}
					string error = obj18._003Crequest_003E5__2.error;
					object obj53 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v153+E4]");
					bool flag30 = (nint)0 == 0;
					object obj54 = !flag30;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text11 = ReachKind(error);
					nint num7 = unchecked((nint)null);
					text10 = text11;
				}
				object obj55 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1190 @ X0_v95+E4]");
				bool flag31 = (nint)0 == 0;
				object obj56 = !flag31;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj55 = obj49;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1190 @ X0_v95+A0]");
				object obj57 = (nint)0 + (nint)80;
				obj57 = text10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj58 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ X8_v45+A0]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v46+58]");
				object obj61 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array2 = default;
				bool flag32 = array2 == null;
				num2 = 5;
				if (flag32)
				{
					goto IL_10f7;
				}
				bool flag33 = array2.Length == 0;
				num2 = 5;
				if (flag33)
				{
					goto IL_1105;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDA0]");
				object obj62 = 0;
				object obj63 = array2 + 32;
				obj63 = obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFD98]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Uri uri = default;
				uri._002Ector(obj18.url);
				bool flag34 = (object)uri == null;
				text3 = null;
				num2 = (nint)obj18.url;
				if (flag34)
				{
					goto IL_1113;
				}
				string host = uri.Host;
				object obj65 = array2.Length & 0xFFFFFFFEL;
				bool flag35 = obj65 == null;
				text3 = null;
				num2 = (nint)host;
				if (flag35)
				{
					goto IL_1121;
				}
				object obj66 = array2 + 40;
				obj66 = host;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag36 = array2.Length < 2;
				object obj67 = !flag36;
				object obj68 = array2.Length - 2;
				bool flag37 = obj68 == null;
				object obj69 = ~obj67;
				object obj70 = obj69 | flag37;
				text3 = null;
				num2 = (nint)host;
				if (obj70 != null)
				{
					goto IL_112f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj71 = 0;
				num2 = (nint)obj71;
				object obj72 = array2 + 48;
				obj72 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag38 = obj18._003Crequest_003E5__2 == null;
				text3 = null;
				if (flag38)
				{
					goto IL_113d;
				}
				string error2 = obj18._003Crequest_003E5__2.error;
				object obj73 = array2.Length & 0xFFFFFFFCL;
				bool flag39 = obj73 == null;
				text3 = null;
				num2 = (nint)error2;
				if (flag39)
				{
					goto IL_114b;
				}
				object obj74 = array2 + 56;
				obj74 = error2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
					object obj75 = 0;
					object obj76 = obj75;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ X0_v140+E4]");
					bool flag40 = (nint)0 == 0;
					object obj77 = !flag40;
					if (obj77 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime utcNow = DateTime.UtcNow;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDC0]");
					object format = 0;
					object arg = default;
					string text12 = string.Format((string)format, arg);
					text3 = null;
					num2 = (nint)text12;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj78 = 0;
					num2 = (nint)obj78;
					text3 = null;
				}
				bool flag41 = array2.Length < 4;
				object obj79 = !flag41;
				object obj80 = array2.Length - 4;
				bool flag42 = obj80 == null;
				object obj81 = ~obj79;
				object obj82 = obj81 | flag42;
				if (obj82 != null)
				{
					goto IL_1159;
				}
				object obj83 = array2 + 64;
				obj83 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string message = string.Concat(array2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj84 = 0;
				object obj85 = obj84;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X0_v125+E4]");
				bool flag43 = (nint)0 == 0;
				object obj86 = !flag43;
				if (obj86 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				Action<string> action2 = obj18.failed;
				if (flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE030]");
					object obj87 = 0;
					num2 = (nint)obj87;
				}
				else
				{
					bool flag44 = obj18._003Crequest_003E5__2 == null;
					num2 = unchecked((nint)null);
					if (flag44)
					{
						goto IL_1191;
					}
					string error3 = obj18._003Crequest_003E5__2.error;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDB8]");
					object obj88 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
					object obj89 = 0;
					text3 = (string)obj89;
					string text13 = (string)obj88 + error3 + (string)obj89;
					num = 0;
					num2 = (nint)text13;
				}
				if (obj18.failed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X20_v39 (System.Action`1<System.String>)+28]");
					text3 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1216 @ X20_v39 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					obj18._003C_003Em__Finally1();
					object obj90 = obj18 + 72;
					obj90 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num2 = unchecked((nint)null);
					goto IL_102e;
				}
				goto IL_1167;
			}
			bool flag45 = obj18._003Crequest_003E5__2 == null;
			num2 = unchecked((nint)null);
			if (flag45)
			{
				goto IL_10db;
			}
			Action<string> action3 = obj18.failed;
			long responseCode = obj18._003Crequest_003E5__2.responseCode;
			long num8 = default;
			string text14 = num8.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDA8]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
			object obj92 = 0;
			text3 = (string)obj92;
			string text15 = (string)obj91 + text14 + (string)obj92;
			bool flag46 = obj18.failed == null;
			num = 0;
			num2 = (nint)text15;
			if (flag46)
			{
				goto IL_10e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X19_v39 (System.Action`1<System.String>)+28]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X19_v39 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
			num = 0;
			_Canon2 = (System.__Canon)(object)text15;
			goto IL_137a;
			IL_1113:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_1121;
			IL_10cd:
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_10db;
			IL_1708:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0824");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_1175:
			NullReferenceException ex17 = new NullReferenceException();
			goto IL_1183;
			IL_137a:
			obj18._003C_003Em__Finally1();
			num2 = (nint)_Canon2;
			goto IL_102e;
			IL_1167:
			NullReferenceException ex18 = new NullReferenceException();
			goto IL_1175;
			IL_119f:
			NullReferenceException ex19 = new NullReferenceException();
			bool flag47 = num2 != 1;
			ex7 = (OutOfMemoryException)(object)ex19;
			if (!flag47)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj93 = default;
				bool flag48 = obj93 == null;
				flag2 = false;
				if (flag48)
				{
					return flag2;
				}
				goto IL_11ec;
			}
			goto IL_1708;
			IL_105d:
			NullReferenceException ex20 = new NullReferenceException();
			goto IL_106b;
			IL_1079:
			NullReferenceException ex21 = new NullReferenceException();
			goto IL_1087;
			IL_1191:
			NullReferenceException ex22 = new NullReferenceException();
			goto IL_119f;
			IL_1159:
			IndexOutOfRangeException ex23 = new IndexOutOfRangeException();
			goto IL_1167;
			IL_1087:
			NullReferenceException ex24 = new NullReferenceException();
			goto IL_1095;
			IL_114b:
			IndexOutOfRangeException ex25 = new IndexOutOfRangeException();
			goto IL_1159;
			IL_106b:
			NullReferenceException ex26 = new NullReferenceException();
			goto IL_1079;
			IL_1105:
			IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
			goto IL_1113;
			IL_1095:
			NullReferenceException ex28 = new NullReferenceException();
			goto IL_10a3;
		}

		private void _003C_003Em__Finally1()
		{
			//IL_00f2: Expected I4, but got I8
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			UnityWebRequest unityWebRequest = _003Crequest_003E5__2;
			_003C_003E1__state = -1;
			if (_003Crequest_003E5__2 == null)
			{
				return;
			}
			nint num = (nint)unityWebRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<UnityEngine.Networking.UnityWebRequest>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v7-8]");
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
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_0135;
			IL_0135:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v152 @ X0_v2] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0135;
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

	private sealed class _003CFreshTicketForShiftAuth_003Ed__102 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool turnedDown;

		private float _003Cuntil_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CFreshTicketForShiftAuth_003Ed__102(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_02c7: Expected I4, but got I8
			//IL_0a3c: Expected Obj, but got I
			//IL_0a66: Expected Obj, but got I4
			//IL_0021: Expected Obj, but got I4
			//IL_085e: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_0081: Expected Obj, but got I4
			//IL_0af9: Expected Obj, but got I
			//IL_0b1b: Expected Obj, but got I4
			//IL_06db: Expected Obj, but got I
			//IL_06eb: Expected Obj, but got I
			//IL_0715: Expected Obj, but got I4
			//IL_088e: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I4
			//IL_0319: Expected Obj, but got I4
			//IL_08fe: Expected Obj, but got I4
			//IL_011d: Expected Obj, but got I4
			//IL_0b79: Expected Obj, but got I
			//IL_08c6: Expected Obj, but got I4
			//IL_0b39: Expected Obj, but got I
			//IL_0b5b: Expected Obj, but got I4
			//IL_074d: Expected Obj, but got I4
			//IL_0400: Expected Obj, but got I
			//IL_042a: Expected Obj, but got I4
			//IL_0a84: Expected Obj, but got I
			//IL_091c: Expected Obj, but got I
			//IL_092c: Expected Obj, but got I
			//IL_06a7: Expected I4, but got Obj
			//IL_0178: Expected Obj, but got I4
			//IL_045f: Expected Obj, but got I
			//IL_0489: Expected Obj, but got I4
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected Obj, but got Unknown
			//IL_039a: Expected Obj, but got I4
			//IL_0967: Expected Obj, but got I
			//IL_0977: Expected Obj, but got I
			//IL_0785: Expected Obj, but got I4
			//IL_0ab9: Expected Obj, but got I
			//IL_0adb: Expected Obj, but got I4
			//IL_01d3: Expected Obj, but got I4
			//IL_07a3: Expected Obj, but got I
			//IL_07cd: Expected Obj, but got I4
			//IL_023b: Expected VT, but got I
			//IL_0203: Expected Obj, but got I
			//IL_0271: Expected Obj, but got I
			//IL_04cc: Expected Obj, but got I
			//IL_04ee: Expected Obj, but got I4
			//IL_053e: Expected Obj, but got I4
			//IL_029a: Expected Obj, but got I
			//IL_02b3: Expected Obj, but got I4
			//IL_0996: Expected Obj, but got I
			//IL_09ab: Expected VT, but got I
			//IL_09bf: Expected Obj, but got I
			//IL_09e9: Expected Obj, but got I4
			//IL_07fc: Expected Obj, but got I
			//IL_0826: Expected Obj, but got I4
			//IL_062d: Expected Obj, but got I4
			//IL_05ab: Expected Obj, but got I
			//IL_05bb: Expected Obj, but got I
			//IL_0a07: Expected Obj, but got I
			//IL_05de: Expected Obj, but got I4
			//IL_0663: Expected Obj, but got I
			//IL_0694: Expected F4, but got I4
			bool result;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				result = false;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v58+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj3 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v58+A0]");
					object obj6 = 0;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v37+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v7+8]");
					bool flag4 = (UnityEngine.Object)0 == null;
					bool flag5 = !flag4;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						object obj10 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v62+E4]");
						bool flag6 = (nint)0 == 0;
						object obj11 = !flag6;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj12 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v66+E4]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v66+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v42+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v66+E4]");
							bool flag8 = (nint)0 == 0;
							object obj15 = !flag8;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj16 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v70+E4]");
							bool flag9 = (nint)0 == 0;
							object obj17 = !flag9;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj16 = obj2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v70+A0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v49+11]");
							bool flag10 = (nint)0 == 0;
							object obj19 = !flag10;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v70+E4]");
								bool flag11 = (nint)0 == 0;
								object obj20 = !flag11;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj21 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v72+A0]");
									obj18 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
								object obj22 = 0;
								object obj23 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v72+E4]");
								bool flag12 = (nint)0 == 0;
								object obj24 = !flag12;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								DateTime utcNow = DateTime.UtcNow;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v49+60]");
								if (TicketStale((DateTime)0, utcNow, turnedDown))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDF0]");
									object obj25 = 0;
									string text;
									float num2 = default;
									if (~(turnedDown ? 1u : 0u) == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDE8]");
										object obj26 = 0;
										text = (string)obj26;
										double num = num2;
										object obj27 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD000]");
										object obj28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v91+E4]");
										bool flag13 = (nint)0 == 0;
										object obj29 = !flag13;
										if (obj29 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										DateTime utcNow2 = DateTime.UtcNow;
										object obj30 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v61+E4]");
										bool flag14 = (nint)0 == 0;
										object obj31 = !flag14;
										if (obj31 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj30 = obj2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v61+A0]");
										object obj32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v62+60]");
										TimeSpan timeSpan = utcNow2 - (DateTime)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
										object obj33 = 0;
										object obj34 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v65+E4]");
										bool flag15 = (nint)0 == 0;
										object obj35 = !flag15;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										TimeSpan timeSpan2 = default;
										double num = timeSpan2.TotalHours;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
										int num3 = default;
										string text2 = num3.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDD8]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFDE0]");
										object obj37 = 0;
										string text3 = (string)obj36 + text2 + (string)obj37;
										object obj27 = 0;
										text = text3;
									}
									string message = (string)obj25 + text;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj38 = 0;
									object obj39 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v55+E4]");
									bool flag16 = (nint)0 == 0;
									object obj40 = !flag16;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.Log(message);
									object obj41 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v84+E4]");
									bool flag17 = (nint)0 == 0;
									object obj42 = !flag17;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj41 = obj2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v84+A0]");
									object obj43 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v57+8]");
									if ((nint)0 == 0)
									{
										goto IL_0699;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v57+8]");
									((GillaCloud)0).SessionLost();
									float realtimeSinceStartup = Time.realtimeSinceStartup;
									num2 = realtimeSinceStartup + 1.1146363E+09f;
									_003Cuntil_003E5__2 = num2;
									float num4 = 1.1146363E+09f;
									goto IL_0a2c;
								}
							}
						}
					}
					goto IL_04ae;
				}
				goto IL_06c6;
			}
			_003C_003E1__state = -1;
			goto IL_0a2c;
			IL_0699:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0a2c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj44 = 0;
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v3+E4]");
			bool flag18 = (nint)0 == 0;
			object obj46 = !flag18;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj47 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+E4]");
			bool flag19 = (nint)0 == 0;
			object obj48 = !flag19;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj44;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+A0]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9+10]");
			bool flag20 = (nint)0 == 0;
			object obj50 = !flag20;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+E4]");
				bool flag21 = (nint)0 == 0;
				object obj51 = !flag21;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj47 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+E4]");
				bool flag22 = (nint)0 == 0;
				object obj52 = !flag22;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj47 = obj44;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+A0]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v26+11]");
				bool flag23 = (nint)0 == 0;
				object obj54 = !flag23;
				if (obj54 == null)
				{
					float num2 = Time.realtimeSinceStartup;
					float num4 = _003Cuntil_003E5__2;
					if (num2 < _003Cuntil_003E5__2)
					{
						object obj55 = this + 24;
						obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						result = true;
						goto IL_06c6;
					}
					obj47 = obj44;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v8+E4]");
			bool flag24 = (nint)0 == 0;
			object obj56 = !flag24;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj57 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v12+E4]");
			bool flag25 = (nint)0 == 0;
			object obj58 = !flag25;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj57 = obj44;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v12+A0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v16+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
				object obj60 = 0;
				object obj61 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v14+E4]");
				bool flag26 = (nint)0 == 0;
				object obj62 = !flag26;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj61 = obj60;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v14+A0]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v19+10]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v19+10]");
				if ((nint)0 == 0)
				{
					goto IL_0699;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj65 = 0;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v16+E4]");
				bool flag27 = (nint)0 == 0;
				object obj67 = !flag27;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj66 = obj65;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v16+A0]");
				object obj68 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v20+10]");
				obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			goto IL_04ae;
			IL_04ae:
			result = false;
			goto IL_06c6;
			IL_06c6:
			return result;
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

	public const string TitleId = null;

	private static readonly string[] SignInUrls;

	private const string SignInRouteKey = null;

	private const int SignInTimeout = default(int);

	private const string QueueKey = null;

	private const string ProfileKey = null;

	private const float SendEvery = default(float);

	private const float SendRetry = default(float);

	private const float ProfileEvery = default(float);

	private const float SignInFirstRetry = default(float);

	private const float SignInMostRetry = default(float);

	private const float SignInGiveUpAfter = default(float);

	private static GillaCloud instance;

	private static bool SignedIn__BackingField;

	private static bool Banned__BackingField;

	private static long BanUntil__BackingField;

	private static bool BanForever__BackingField;

	private static string BanWhy__BackingField;

	private static string Problem__BackingField;

	private string metaId;

	private Action<Action<string>> askProof;

	private readonly List<string> queue;

	private int sendingCount;

	private bool signingIn;

	private bool attempting;

	private bool profileUnsaved;

	private bool applying;

	private float nextSend;

	private float nextProfile;

	private float nextState;

	private const float StateEvery = default(float);

	private static string photonBound;

	private static string photonBinding;

	private bool shiftAuthAfterTerms;

	private float nextTermsLook;

	private static int ReportsSent__BackingField;

	private static string reachKind;

	private static int reachFails;

	private bool rejoin;

	private static DateTime ticketAt;

	private const double TicketHours = default(double);

	private bool stateAsking;

	public static bool SignedIn
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static bool Banned
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+11]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static long BanUntil
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected I8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			return 0L;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static bool BanForever
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static string BanWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static string Problem
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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

	public static bool TermsHoldShiftAuth
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0103: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I
			//IL_009a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (GillaTerms.Accepted)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0B0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			UnityEngine.Object obj8 = default;
			return obj8 != null;
		}
	}

	public static int ReportsSent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
		//IL_0112: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
		object obj4 = (nint)0 + (nint)8;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+A0]");
		object obj7 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+A0]");
		object obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+A0]");
		object obj11 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+A0]");
		object obj14 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v17+A0]");
		object obj16 = (nint)0 + (nint)40;
		obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v23+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v23+A0]");
		object obj19 = (nint)0 + (nint)48;
		obj19 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v22+A0]");
		object obj21 = (nint)0 + (nint)80;
		obj21 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v23+A0]");
		object obj23 = (nint)0 + (nint)64;
		obj23 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v24+A0]");
		object obj25 = (nint)0 + (nint)56;
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
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
		bool isEditor = Application.isEditor;
		bool flag2 = !isEditor;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Make();
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v10+A0]");
			object obj11 = 0;
			obj11 = 0;
		}
	}

	private static void Make()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0491: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_04b1: Expected Obj, but got I
		//IL_04c9: Expected I, but got Obj
		//IL_04f3: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02ef: Expected I4, but got Obj
		//IL_0351: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03b4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC070]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC078]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC088]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<bool, System.__Canon> func = default;
		func._002Ector((object)null, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+A0]");
		object obj9 = (nint)0 + (nint)72;
		obj9 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj5);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC080]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC090]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object defaultValue = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v10+E4]");
			int num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v10+A0]");
			object obj16 = (nint)0 + (nint)8;
			object obj17 = default;
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text = PlayerPrefs.GetString((string)key, (string)defaultValue);
			if (text != null)
			{
				string[] array = text.Split('|', (StringSplitOptions)0);
				if (array != null)
				{
					object obj18 = array.Length;
					if (array.Length < 1)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
					object obj19 = 0;
					object obj20 = 0;
					char c = '|';
					StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
					while (true)
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
						object obj21 = !flag4;
						if (obj21 != null)
						{
							break;
						}
						object obj22 = (object)array + obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
						char c2 = '\0';
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X20_v10 (System.Char)+10]");
							if ((nint)0 < (nint)3)
							{
								goto IL_0435;
							}
							object obj23 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v31+E4]");
							bool flag5 = (nint)0 == 0;
							object obj24 = !flag5;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj23 = obj13;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v31+A0]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v19+8]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v19+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v20+30]");
								List<System.__Canon> list = (List<System.__Canon>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v20+30]");
								if ((nint)0 != 0)
								{
									System.__Canon[] items = list._items;
									num = (int)obj19;
									int version = list._version + 1;
									list._version = version;
									if (list._items != null)
									{
										bool flag6 = list._size < items.Length;
										object obj27 = !flag6;
										if (obj27 == null)
										{
											object obj28 = list._items + list._size;
											num = list._size + 1;
											list._size = num;
											object obj29 = obj28 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
											obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
											c = '\0';
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v6 (System.Int32)+20]");
											object obj30 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v22+A8]");
											object obj31 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+70]");
											stringSplitOptions = (StringSplitOptions)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v20+30]");
											nint num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
											((List<System.__Canon>)num2).AddWithResize((System.__Canon)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14+20]");
											c = '\0';
										}
										goto IL_0435;
									}
								}
							}
						}
						goto IL_046c;
						IL_0435:
						obj18 = array.Length;
						obj20++;
						if ((nint)obj20 >= array.Length)
						{
							return;
						}
					}
					goto IL_047a;
				}
			}
		}
		goto IL_046c;
		IL_046c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_047a;
		IL_047a:
		throw new IndexOutOfRangeException();
	}

	public static void MetaUser(string id, Action<Action<string>> proof)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+8]");
		if (!((UnityEngine.Object)0 == null))
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+8]");
			object obj11 = (nint)0 + (nint)32;
			obj11 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+8]");
			object obj14 = (nint)0 + (nint)40;
			obj14 = proof;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11+8]");
			((GillaCloud)0).BeginSignIn();
		}
	}

	private void BeginShiftAuth()
	{
		//IL_0010: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I
		//IL_04c9: Expected I, but got Obj
		//IL_04e7: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
		object obj10 = (nint)0 + (nint)64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkBootstrap.ShiftAuthNeeded)
		{
			return;
		}
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool hasDevKey = ShiftAuth.HasDevKey;
		bool flag5 = !hasDevKey;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v24+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+11]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (TermsHoldShiftAuth)
		{
			shiftAuthAfterTerms = true;
			return;
		}
		shiftAuthAfterTerms = false;
		string real = GillaName.Real;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A8]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v5+8]");
		Action<ShiftAuth.Outcome> done = (Action<ShiftAuth.Outcome>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v5+8]");
		bool flag11 = (nint)0 == 0;
		object obj28 = !flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+10]");
		Action<ShiftAuth.Outcome> action = (Action<ShiftAuth.Outcome>)0;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17+E4]");
			bool flag12 = (nint)0 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj30 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v26+A0]");
				obj27 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A0]");
			object obj32 = 0;
			Action<ShiftAuth.Outcome> action2 = default;
			action2._002Ector(obj27, (IntPtr)obj32);
			object obj33 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v25+A0]");
			object obj34 = (nint)0 + (nint)8;
			obj34 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			action = action2;
			done = action2;
		}
		object obj35 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v30+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ShiftAuth.Begin(metaId, real, done);
	}

	public static void BindPhoton(string uid)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0520: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I4
		//IL_07d5: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I4
		//IL_0598: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_05dd: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_062e: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I
		//IL_0661: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03cc: Expected I, but got Obj
		//IL_03dd: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I4
		//IL_06e3: Expected Obj, but got I
		//IL_06f3: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I
		//IL_0725: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_075e: Expected Obj, but got I
		//IL_0766: Expected I, but got Obj
		//IL_0777: Expected I, but got Obj
		//IL_0795: Expected Obj, but got I
		//IL_07b0: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass55_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = uid;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v9+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v2+8]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			return;
		}
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v18+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v11+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		bool flag7 = string.IsNullOrEmpty((string)obj5);
		bool flag8 = !flag7;
		object obj17 = !flag8;
		if (obj17 != null)
		{
			return;
		}
		string text = (string)obj5;
		if (text._stringLength > 64)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v22+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v15+10]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+18]");
		string b;
		if ((nint)0 == 0)
		{
			b = (string)obj23;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+18]");
			b = (string)0;
		}
		bool flag10 = string.Equals(text, b, (StringComparison)5);
		bool flag11 = !flag10;
		object obj24 = !flag11;
		if (obj24 != null)
		{
			return;
		}
		object obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v26+E4]");
		bool flag12 = (nint)0 == 0;
		object obj26 = !flag12;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v26+A0]");
		object obj27 = 0;
		object obj28 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v19+38]");
		bool flag13 = (string)obj28 == (string)0;
		bool flag14 = !flag13;
		object obj29 = !flag14;
		if (obj29 != null)
		{
			return;
		}
		object obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v30+E4]");
		bool flag15 = (nint)0 == 0;
		object obj31 = !flag15;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v30+A0]");
		object obj32 = 0;
		object obj33 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v21+40]");
		if ((string)obj33 == (string)0)
		{
			return;
		}
		object obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v34+E4]");
		bool flag16 = (nint)0 == 0;
		object obj35 = !flag16;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v34+A0]");
		object obj36 = (nint)0 + (nint)64;
		obj36 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0D0]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
		object obj38 = 0;
		dictionary.Add((System.__Canon)key, (System.__Canon)(object)obj2.uid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0C8]");
		object obj40 = 0;
		nint num = (nint)obj40;
		Action<System.__Canon> action = default;
		action._002Ector((object)obj2, (IntPtr)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A8]");
		object obj41 = 0;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v44+E4]");
		bool flag17 = (nint)0 == 0;
		object obj43 = !flag17;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj42 = obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v44+A0]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0D8]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v35+10]");
		Action<string> failed = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v35+10]");
		bool flag18 = (nint)0 == 0;
		object obj45 = !flag18;
		object obj46 = 0;
		object obj47 = obj2;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v44+E4]");
			bool flag19 = (nint)0 == 0;
			object obj48 = !flag19;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj49 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v39+A0]");
				obj44 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0C0]");
			object obj50 = 0;
			num = (nint)obj50;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj44, (IntPtr)obj50);
			object obj51 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v38+A0]");
			object obj52 = (nint)0 + (nint)16;
			obj52 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj46 = 0;
			failed = (Action<string>)action2;
			obj47 = action2;
		}
		object obj53 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v46+E4]");
		bool flag20 = (nint)0 == 0;
		object obj54 = !flag20;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Run((string)function, (Dictionary<string, object>)(object)dictionary, (Action<string>)action, failed);
	}

	public static void RetryShiftAuth()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v1+8]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v16+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v17+11]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v18+A0]");
				obj16 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v17+8]");
			((GillaCloud)0).BeginShiftAuth();
		}
	}

	public static void Earned(int bolts)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		int num = default;
		string text = num.ToString();
		string op = (string)obj + text;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void SpentBolts(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		string op = (string)obj + item;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void BoughtXp(int xp)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		int num = default;
		string text = num.ToString();
		string op = (string)obj + text;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void RedeemPurchases(string sku)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+8]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		bool flag3 = string.IsNullOrEmpty(sku);
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v11+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC100]");
		object obj13 = 0;
		string item = (string)obj13 + sku;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v8+30]");
		if (!((List<System.__Canon>)0).Contains((System.__Canon)(object)item))
		{
			string op = (string)obj13 + sku;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Enqueue(op);
		}
	}

	public static void OwnerGave(int coins, int bolts, int xp)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I8
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I8
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC108]");
			object obj2 = 0;
			object obj3 = array + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num = default;
			string text = num.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X20_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X20_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
					object obj10 = 0;
					object obj11 = array + 48;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num2 = default;
					string text2 = num2.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X20_v10-18]");
					object obj12 = 0 & 0xFFFFFFFCL;
					if (obj12 != null)
					{
						object obj13 = array + 56;
						obj13 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X20_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj14 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X20_v12-20]");
						object obj15 = -4;
						bool flag4 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag4;
						if (obj17 == null)
						{
							object obj18 = array + 64;
							obj18 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int num3 = default;
							string text3 = num3.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X20_v14-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj19 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X20_v14-28]");
							object obj20 = -5;
							bool flag6 = obj20 == null;
							object obj21 = ~obj19;
							object obj22 = obj21 | flag6;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
								object obj23 = 0;
								object obj24 = array + 72;
								obj24 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string op = string.Concat(array);
								object obj25 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v13+E4]");
								bool flag7 = (nint)0 == 0;
								object obj26 = !flag7;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Enqueue(op);
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

	public static void BoughtBundle(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		string op = (string)obj + name;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void Bought(List<string> names)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
		object separator = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC118]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		string text = string.Join((string)separator, (IEnumerable<string>)names);
		string op = (string)obj + text;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void Reported(string player, string comment)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003d: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		Encoding uTF = Encoding.UTF8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC128]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj3 = 0;
		nint num = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj4 = 0;
		int count = default;
		((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)comment, 0, count);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] inArray = default;
		string text = Convert.ToBase64String(inArray);
		string op = (string)obj2 + player + (string)obj3 + text;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void QuestClaimed(int day, int quest)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC130]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj3 = 0;
		int num = default;
		string text = num.ToString();
		int num2 = default;
		string text2 = num2.ToString();
		string op = (string)obj + text + (string)obj2 + text2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue(op);
	}

	public static void PlayedRound()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC138]");
		object op = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Enqueue((string)op);
	}

	public static void ProfileChanged()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+8]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X19_v9+3F]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v15+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
				obj12 = 0;
			}
			_ = 1;
			float unscaledTime = Time.unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC140]");
			object key = 0;
			float num = unscaledTime + 5f;
			PlayerPrefs.SetInt((string)key, 1);
			PlayerPrefs.Save();
		}
	}

	private static void Enqueue(string op)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I
		//IL_05b2: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_033b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+8]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+30]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		char c = op.get_Chars(0);
		int num = c & 0xFFFF;
		if (num == 69)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v19+8]");
			object obj16 = 0;
			int size = list._size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v20+38]");
			bool flag7 = (nint)size <= (nint)0;
			System.__Canon _Canon = null;
			if (!flag7)
			{
				int index = list._size - 1;
				System.__Canon _Canon2 = list.get_Item(index);
				char c2 = ((string)(object)_Canon2).get_Chars(0);
				int num2 = c2 & 0xFFFF;
				bool flag8 = num2 != 69;
				_Canon = null;
				if (!flag8)
				{
					int index2 = list._size - 1;
					System.__Canon _Canon3 = list.get_Item(index2);
					string s = ((string)(object)_Canon3).Substring(2);
					bool flag9 = int.TryParse(s, out var _);
					bool flag10 = !flag9;
					_Canon = null;
					if (!flag10)
					{
						string s2 = op.Substring(2);
						bool flag11 = int.TryParse(s2, out var _);
						bool flag12 = !flag11;
						_Canon = null;
						if (!flag12)
						{
							int num3 = default;
							string text = num3.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0E0]");
							object obj17 = 0;
							string text2 = (string)obj17 + text;
							int num4 = list._size - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0E8]");
							object obj18 = 0;
							list.set_Item(num4, (System.__Canon)(object)text2);
							_Canon = (System.__Canon)(object)text2;
							System.__Canon _Canon4 = (System.__Canon)num4;
							goto IL_046b;
						}
					}
				}
			}
		}
		else
		{
			System.__Canon _Canon = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj19 = 0;
		System.__Canon[] items = list._items;
		object obj20 = obj19;
		int version = list._version + 1;
		list._version = version;
		bool flag13 = list._size < items.Length;
		object obj21 = !flag13;
		if (obj21 == null)
		{
			object obj22 = items + list._size;
			int size2 = list._size + 1;
			list._size = size2;
			object obj23 = obj22 + 32;
			obj23 = op;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			System.__Canon _Canon4 = (System.__Canon)(object)op;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X9_v7+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v16+A8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v17+70]");
			System.__Canon _Canon = (System.__Canon)0;
			list.AddWithResize((System.__Canon)(object)op);
			System.__Canon _Canon4 = (System.__Canon)(object)op;
		}
		goto IL_046b;
		IL_046b:
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v16+E4]");
		bool flag14 = (nint)0 == 0;
		object obj27 = !flag14;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v16+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v13+8]");
		((GillaCloud)0).SaveQueue();
	}

	private void SaveQueue()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
		object separator = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC090]");
		object key = 0;
		string value = string.Join((string)separator, (IEnumerable<string>)queue);
		PlayerPrefs.SetString((string)key, value);
		PlayerPrefs.Save();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		if (~(shiftAuthAfterTerms ? 1u : 0u) == 0)
		{
			float unscaledTime = Time.unscaledTime;
			if (!(unscaledTime < nextTermsLook))
			{
				float unscaledTime2 = Time.unscaledTime;
				object obj7 = obj;
				float num = unscaledTime2 + 0.25f;
				nextTermsLook = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v23+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool termsHoldShiftAuth = TermsHoldShiftAuth;
				bool flag4 = !termsHoldShiftAuth;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					BeginShiftAuth();
				}
			}
		}
		bool flag5 = sendingCount == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			if (~(stateAsking ? 1u : 0u) != 0)
			{
				List<string> list = queue;
				if (list._size >= 1)
				{
					float unscaledTime3 = Time.unscaledTime;
					if (!(unscaledTime3 < nextSend))
					{
						SendNext();
					}
				}
			}
			bool flag6 = sendingCount == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				List<string> list2 = queue;
				bool flag7 = list2._size == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					float unscaledTime4 = Time.unscaledTime;
					if (!(unscaledTime4 < nextState))
					{
						float unscaledTime5 = Time.unscaledTime;
						float num2 = unscaledTime5 + 1.1555963E+09f;
						nextState = num2;
						AskForState();
					}
				}
			}
		}
		if (~(profileUnsaved ? 1u : 0u) == 0)
		{
			float unscaledTime6 = Time.unscaledTime;
			if (!(unscaledTime6 < nextProfile))
			{
				SaveProfile();
			}
		}
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I
		if (paused)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+10]");
			if ((nint)0 != 0 && ~(profileUnsaved ? 1u : 0u) == 0)
			{
				SaveProfile();
			}
		}
	}

	private void BeginSignIn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+10]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		bool flag4 = (byte)(~(signingIn ? 1u : 0u)) != 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v11+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+11]");
			if ((nint)0 == 0)
			{
				IEnumerator routine = SignIn();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
	}

	private IEnumerator SignIn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC258]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaCorpse._003CSignIn_003Ed__83 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private void Attempt()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I4, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC260]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6+18]");
		int num2 = (int)(-1);
		object obj6 = num - num2;
		bool flag2 = (nint)obj6 < 0;
		int num3 = num ^ num2;
		int num4 = num ^ obj6;
		int num5 = num3 & num4;
		bool flag3 = num5 < 0;
		bool flag4 = flag2 == flag3;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			num2 = num;
		}
		bool flag5 = num < 0;
		int num6 = num ^ num;
		int num7 = num & num6;
		bool flag6 = num7 < 0;
		bool flag7 = flag5 == flag6;
		object obj9 = !flag7;
		object obj10 = ~obj9;
		int route = ((obj10 != null) ? num2 : 0);
		TryRoute(route, 0);
	}

	private void TryRoute(int route, int tried)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0096: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC268]");
		object obj = 0;
		_003C_003Ec__DisplayClass85_0 obj2 = default;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC270]");
			object obj4 = 0;
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Action<Action<string>> action = askProof;
			obj2.route = route;
			obj2.tried = tried;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			action2._002Ector((object)obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X21_v3 (System.Action`1<System.Action`1<System.String>>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X21_v3 (System.Action`1<System.Action`1<System.String>>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X21_v3 (System.Action`1<System.Action`1<System.String>>)+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	private static IEnumerator AskSignIn(string url, string metaId, string nonce, Action<Reply> got, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC278]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CAskSignIn_003Ed__89 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 48;
			obj3 = url;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 32;
			obj4 = metaId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 40;
			obj5 = nonce;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 56;
			obj6 = got;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj2 + 64;
			obj7 = failed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static string ReachKind(string error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected I4, but got Unknown
		//IL_0358: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = default;
		if (text == null)
		{
		}
		string text3;
		object obj2;
		if (obj != null)
		{
			string text2 = ((string)obj).Trim();
			if (text2 != null)
			{
				text3 = text2.ToLowerInvariant();
				if (text3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A8]");
					object value = 0;
					if (text3.Contains((string)value))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2D0]");
						obj2 = 0;
						goto IL_03cc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC290]");
					object obj3 = 0;
					bool flag = text3.Contains((string)obj3);
					bool flag2 = !flag;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC298]");
						object value2 = 0;
						bool flag3 = text3.Contains((string)value2);
						bool flag4 = !flag3;
						object obj5 = !flag4;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2C8]");
							object value3 = 0;
							bool flag5 = text3.Contains((string)value3);
							bool flag6 = !flag5;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B0]");
								obj3 = 0;
								bool flag7 = text3.Contains((string)obj3);
								bool flag8 = !flag7;
								object obj7 = !flag8;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B8]");
									object value4 = 0;
									if (!text3.Contains((string)value4))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC288]");
										object value5 = 0;
										if (text3.Contains((string)value5))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2C0]");
											obj2 = 0;
											goto IL_03cc;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC280]");
										obj3 = 0;
										bool flag9 = text3.Contains((string)obj3);
										bool flag10 = !flag9;
										object obj8 = !flag10;
										if (obj8 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A0]");
											object obj9 = 0;
											object obj10 = text3._stringLength - 1;
											bool flag11 = (nint)obj10 < 0;
											int num = text3._stringLength ^ 1;
											int num2 = text3._stringLength ^ obj10;
											int num3 = num & num2;
											bool flag12 = num3 < 0;
											bool flag13 = flag11 == flag12;
											object obj11 = !flag13;
											object obj12 = ~obj11;
											if (obj12 == null)
											{
												text3 = (string)obj9;
											}
											goto IL_03c7;
										}
									}
								}
							}
						}
					}
					text3 = (string)obj3;
					goto IL_03c7;
				}
			}
		}
		return (string)(object)new NullReferenceException();
		IL_03cc:
		text3 = (string)obj2;
		goto IL_03c7;
		IL_03c7:
		return text3;
	}

	private static bool ClockBehind()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+30]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v3+30]");
			bool flag3 = string.IsNullOrEmpty((string)0);
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2D8]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v3+30]");
				if (DateTime.TryParseExact((string)0, (string)format, (IFormatProvider)invariantCulture, (DateTimeStyles)80, out var result))
				{
					object obj15 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v20+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime utcNow = DateTime.UtcNow;
					DateTime dateTime = result.AddHours(-2.0);
					return utcNow < dateTime;
				}
			}
		}
		return false;
	}

	private void Failed(string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		string value = default;
		bool flag = string.IsNullOrEmpty(value);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		bool flag4 = !flag;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+A0]");
		object obj9 = (nint)0 + (nint)48;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		attempting = false;
	}

	public static void Ban(long until, bool forever, string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00aa: Expected I8, but got I4
		//IL_0037: Expected I8, but got I4
		//IL_0040: Expected I8, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I8
		//IL_049a: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I4
		//IL_07c7: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I4
		//IL_06ba: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I8
		//IL_07dc: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_07f7: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I4
		//IL_0811: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I4
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_0750: Expected Obj, but got I4
		//IL_0758: Expected Obj, but got I8
		//IL_0628: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I
		//IL_078b: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I4
		//IL_0668: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		string text2 = default;
		string text = (string)((text2 != null) ? text2 : obj);
		long num;
		long num2;
		if (forever)
		{
			num = (forever ? 1 : 0);
			num2 = 0L;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v105+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num3 = Math.Max(0L, until);
			text2 = null;
			num = until;
			num2 = num3;
		}
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+11]");
		bool flag4 = (nint)0 == 0;
		string text3 = (string)num;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v41+18]");
			bool flag7 = 0 != num2;
			text3 = (string)num;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
				bool flag9 = (nint)0 == 0;
				object obj15 = !flag9;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v47+20]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				object obj18 = obj17 ^ forever;
				object obj19 = obj18 & 1;
				bool flag11 = obj19 == null;
				object obj20 = !flag11;
				text3 = (string)num;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj22 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v76+E4]");
					bool flag13 = (nint)0 == 0;
					object obj23 = !flag13;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj22 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v76+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v55+28]");
					bool flag14 = (string)0 == text;
					bool flag15 = !flag14;
					object obj25 = !flag15;
					if (obj25 != null)
					{
						return;
					}
					obj8 = obj2;
					text2 = null;
					text3 = text;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
		bool flag16 = (nint)0 == 0;
		object obj26 = !flag16;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+E4]");
		bool flag17 = (nint)0 == 0;
		object obj28 = !flag17;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+E4]");
		bool flag18 = (nint)0 == 0;
		object obj30 = !flag18;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+A0]");
		object obj31 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+E4]");
		bool flag19 = (nint)0 == 0;
		object obj32 = !flag19;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+E4]");
		bool flag20 = (nint)0 == 0;
		object obj34 = !flag20;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+E4]");
		bool flag21 = (nint)0 == 0;
		object obj37 = !flag21;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v20+A0]");
		object obj38 = (nint)0 + (nint)40;
		obj38 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj39 = obj2;
		object obj40 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v27+A0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v24+E4]");
		bool flag22 = (nint)0 == 0;
		object obj42 = !flag22;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v28+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj43 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v32+E4]");
			bool flag23 = (nint)0 == 0;
			object obj44 = !flag23;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj43 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v32+A0]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v31+8]");
			((GillaCloud)0).BeBanned();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v16+11]");
		if ((nint)0 == 0)
		{
			object obj46 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v29+E4]");
			bool flag24 = (nint)0 == 0;
			object obj47 = !flag24;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			LeaveRoom();
		}
	}

	public static void Unban()
	{
		//IL_0010: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I
		//IL_05fc: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+11]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+A0]");
		object obj10 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+A0]");
		object obj12 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+A0]");
		object obj15 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+A0]");
		object obj18 = (nint)0 + (nint)40;
		obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = obj;
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v23+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v57+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj23 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v57+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v40+8]");
			GillaCloud gillaCloud = (GillaCloud)0;
			if (gillaCloud.askProof != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v57+E4]");
				bool flag10 = (nint)0 == 0;
				object obj26 = !flag10;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj27 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v43+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v44+8]");
					gillaCloud = (GillaCloud)0;
				}
				gillaCloud.rejoin = true;
				gillaCloud.BeginSignIn();
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj29 = 0;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v28+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj32 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v32+E4]");
		bool flag12 = (nint)0 == 0;
		object obj33 = !flag12;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj29;
		}
		object obj34 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v32+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v31+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v8+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj37 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v36+E4]");
			bool flag14 = (nint)0 == 0;
			object obj38 = !flag14;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj39 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v40+E4]");
			bool flag15 = (nint)0 == 0;
			object obj40 = !flag15;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj29;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v40+A0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v36+8]");
			((NetworkBootstrap)0).JoinRoom((string)obj13);
		}
	}

	private static void LeaveRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj10 = null;
		if (!flag5)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v27+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v27+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v15+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v16+B0]");
			obj10 = (UnityEngine.Object)0;
		}
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj10 != null && ((NetworkRunner)obj10).IsRunning)
		{
			Task task = ((NetworkRunner)obj10).Shutdown(true, (ShutdownReason)0, false);
		}
	}

	private void BeBanned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_04cc: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_0172: Expected I8, but got I
		//IL_0186: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+A0]");
		object obj6 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+A0]");
		object obj10 = 0;
		attempting = false;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.ForgetAllCredentials();
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC300]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v13+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v13+20]");
		object obj17;
		string text3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2F8]");
			obj17 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v36+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v36+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v25+18]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v36+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v40+E4]");
				bool flag9 = (nint)0 == 0;
				object obj24 = !flag9;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v40+A0]");
				object obj26 = 0;
				object obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v35+E4]");
				bool flag10 = (nint)0 == 0;
				object obj28 = !flag10;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v5+18]");
				DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(0L);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0D0]");
				object obj29 = 0;
				DateTimeOffset dateTimeOffset2 = default;
				string text = dateTimeOffset2.ToString((string)obj29);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2F0]");
				object obj30 = 0;
				string text2 = (string)obj30 + text;
				text3 = text2;
				goto IL_03e6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			obj17 = 0;
		}
		text3 = (string)obj17;
		goto IL_03e6;
		IL_03e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj31 = 0;
		string message = (string)obj13 + text3;
		object obj32 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v17+E4]");
		bool flag11 = (nint)0 == 0;
		object obj33 = !flag11;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj34 = 0;
		Debug.LogWarning(message);
		object obj35 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj36 = !flag12;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ModMenuAccess.Adopt(null);
		object obj37 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v23+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NameTitles.Adopt(null);
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj40 = !flag14;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaveRoom();
	}

	private void Arrive(string player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_05c2: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I
		//IL_08ea: Expected Obj, but got I
		//IL_090c: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_094c: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_06a0: Expected Obj, but got I
		//IL_06b0: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I4
		//IL_097c: Expected Obj, but got I4
		//IL_0779: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I
		//IL_0723: Expected I, but got Obj
		//IL_0734: Expected I, but got Obj
		//IL_0752: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07f3: Expected Obj, but got I
		//IL_07fb: Expected I, but got Obj
		//IL_080c: Expected I, but got Obj
		//IL_082a: Expected Obj, but got I
		//IL_0845: Expected Obj, but got I4
		//IL_0493: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I
		//IL_0872: Expected Obj, but got I
		//IL_0894: Expected Obj, but got I4
		//IL_09a2: Expected Obj, but got I
		//IL_09c4: Expected Obj, but got I4
		//IL_04ed: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I4
		//IL_08cc: Expected Obj, but got I4
		//IL_09e2: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+A0]");
		object obj10 = 0;
		attempting = false;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC330]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+A0]");
		object obj15 = (nint)0 + (nint)48;
		obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj18 = 0;
		NetworkBootstrap.SetPlayerId(player);
		BeginShiftAuth();
		string message = (string)obj13 + player;
		object obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 1.1555963E+09f;
		nextState = num;
		AskForState();
		object obj21 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC328]");
		object obj23 = 0;
		bool isEditor = Application.isEditor;
		bool flag8 = !isEditor;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v97+E4]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaPurchases.RedeemOwned();
		}
		LoadProfile();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserTitleDisplayNameRequest updateUserTitleDisplayNameRequest = default;
		updateUserTitleDisplayNameRequest._002Ector();
		string real = GillaName.Real;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A8]");
		object obj28 = 0;
		object obj29 = updateUserTitleDisplayNameRequest + 32;
		obj29 = real;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj30 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v43+18]");
		Action<UpdateUserTitleDisplayNameResult> resultCallback = (Action<UpdateUserTitleDisplayNameResult>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v43+18]");
		bool flag11 = (nint)0 == 0;
		object obj33 = !flag11;
		nint num2 = 0;
		string text = real;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+E4]");
			bool flag12 = (nint)0 == 0;
			object obj34 = !flag12;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj35 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v47+A0]");
				obj32 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC308]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC318]");
			object obj37 = 0;
			num2 = (nint)obj37;
			Action<System.__Canon> action = default;
			action._002Ector(obj32, (IntPtr)obj37);
			object obj38 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v46+A0]");
			object obj39 = (nint)0 + (nint)24;
			obj39 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj30 = obj28;
			object obj40 = 0;
			text = (string)(object)action;
			resultCallback = (Action<UpdateUserTitleDisplayNameResult>)action;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+E4]");
		bool flag13 = (nint)0 == 0;
		object obj41 = !flag13;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+A0]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v37+20]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v37+20]");
		bool flag14 = (nint)0 == 0;
		object obj44 = !flag14;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v42+E4]");
			bool flag15 = (nint)0 == 0;
			object obj45 = !flag15;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj46 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v41+A0]");
				obj42 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC320]");
			object obj48 = 0;
			num2 = (nint)obj48;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj42, (IntPtr)obj48);
			object obj49 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v40+A0]");
			object obj50 = (nint)0 + (nint)32;
			obj50 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj40 = 0;
			text = (string)(object)action2;
			errorCallback = (Action<PlayFabError>)action2;
		}
		object obj51 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v44+E4]");
		bool flag16 = (nint)0 == 0;
		object obj52 = !flag16;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserTitleDisplayName(updateUserTitleDisplayNameRequest, resultCallback, errorCallback);
		if (~(rejoin ? 1u : 0u) != 0)
		{
			return;
		}
		object obj53 = obj11;
		rejoin = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v48+E4]");
		bool flag17 = (nint)0 == 0;
		object obj54 = !flag17;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj55 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v52+E4]");
		bool flag18 = (nint)0 == 0;
		object obj57 = !flag18;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj11;
		}
		object obj58 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v52+A0]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v29+E4]");
		bool flag19 = (nint)0 == 0;
		object obj60 = !flag19;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X9_v12+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj61 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v56+E4]");
			bool flag20 = (nint)0 == 0;
			object obj62 = !flag20;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj63 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v60+E4]");
			bool flag21 = (nint)0 == 0;
			object obj64 = !flag21;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj63 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v60+A0]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v34+8]");
			((NetworkBootstrap)0).JoinRoom((string)obj8);
		}
	}

	public static bool TicketStale(DateTime began, DateTime now, bool turnedDown)
	{
		//IL_0023: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00fc: Invalid comparison between F8 and I4
		//IL_0114: Expected Obj, but got F8
		//IL_0121: Expected Obj, but got F8
		if (turnedDown)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = now - began;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default;
		double totalHours = timeSpan2.TotalHours;
		double num = totalHours - 8.000000000931323;
		bool flag3 = num < 0.0;
		object obj7 = totalHours ^ 8.000000000931323;
		object obj8 = totalHours ^ num;
		object obj9 = obj7 & obj8;
		bool flag4 = (nint)obj9 < 0;
		return flag3 == flag4;
	}

	private static IEnumerator FreshTicketForShiftAuth(bool turnedDown)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC348]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CFreshTicketForShiftAuth_003Ed__102 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			obj2.turnedDown = turnedDown;
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private void SessionLost()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.ForgetAllCredentials();
		BeginSignIn();
	}

	private void AskForState()
	{
		//IL_0118: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		bool flag = (byte)(~(stateAsking ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null && sendingCount <= 0)
		{
			List<string> list = queue;
			if (list._size <= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC150]");
				object obj2 = 0;
				stateAsking = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC220]");
				object obj3 = 0;
				Action<System.__Canon> action = default;
				action._002Ector((object)this, (IntPtr)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC228]");
				object obj5 = 0;
				Action<System.__Canon> action2 = default;
				action2._002Ector((object)this, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC230]");
				object function = 0;
				Call((string)function, null, (Action<Reply>)action, (Action<string>)action2);
			}
		}
	}

	private void SendReport(string op)
	{
		//IL_071f: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_06c7: Expected Obj, but got I4
		//IL_0384: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_06e8: Expected I, but got Obj
		//IL_012b: Expected I4, but got Obj
		//IL_03b9: Expected I, but got Obj
		//IL_0141: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I8
		//IL_0406: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I4
		//IL_02d4: Expected I, but got Obj
		//IL_04ce: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I4
		//IL_02f1: Expected I, but got Obj
		//IL_0320: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I
		//IL_05ec: Expected Obj, but got I4
		//IL_0639: Expected I, but got Obj
		string text = default;
		bool flag = text == null;
		string[] array = (string[])109895680;
		char c;
		string text2;
		string text3;
		string text4 = default;
		int num4;
		nint num2;
		if (!flag)
		{
			string[] array2 = text.Split(':', (StringSplitOptions)0);
			Encoding uTF = Encoding.UTF8;
			if (array2 != null)
			{
				bool flag2 = array2.Length < 2;
				object obj = !flag2;
				object obj2 = array2.Length - 2;
				bool flag3 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v56+E4]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					byte[] array3 = Convert.FromBase64String(array2[2]);
					bool flag5 = uTF == null;
					c = (char)(int)array3;
					if (flag5)
					{
						goto IL_0376;
					}
					nint num = (nint)uTF;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27 (Il2CppClass<System.Text.Encoding>)+370]");
					num2 = 0;
					byte[] outputBuffer = default;
					int outputOffset = default;
					int num3 = ((HashAlgorithm)(object)uTF).TransformBlock(array3, 0, 0, outputBuffer, outputOffset);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC388]");
					object obj8 = 0;
					sendingCount = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					ReportPlayerClientRequest reportPlayerClientRequest = default;
					reportPlayerClientRequest._002Ector();
					object obj9 = array2.Length & 0xFFFFFFFEL;
					bool flag6 = obj9 == null;
					text2 = null;
					text3 = (string)(object)reportPlayerClientRequest;
					if (flag6)
					{
						goto IL_0399;
					}
					bool flag7 = reportPlayerClientRequest == null;
					text4 = (string)num3;
					num4 = 0;
					text = null;
					array = array2;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC370]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC378]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC380]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
						object obj14 = 0;
						object obj15 = reportPlayerClientRequest + 40;
						obj15 = array2[1];
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj16 = reportPlayerClientRequest + 24;
						obj16 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Action<System.__Canon> action = default;
						action._002Ector((object)this, (IntPtr)obj11);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Action<System.__Canon> action2 = default;
						action2._002Ector((object)this, (IntPtr)obj13);
						object obj17 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v74+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayFabClientAPI.ReportPlayer(reportPlayerClientRequest, (Action<ReportPlayerClientResult>)action, (Action<PlayFabError>)action2);
						return;
					}
					goto IL_067a;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			c = ':';
			goto IL_0376;
		}
		goto IL_067a;
		IL_0376:
		NullReferenceException ex3 = new NullReferenceException();
		num2 = unchecked((nint)null);
		text2 = (string)c;
		text3 = text;
		goto IL_0399;
		IL_06ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0399:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		bool flag9 = (nint)text2 != 1;
		NullReferenceException ex5 = (NullReferenceException)(object)ex4;
		num4 = 0;
		text = text2;
		string[] array4 = default;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			nint num5 = (nint)array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			bool flag10 = array4 == null;
			num4 = 0;
			text = text2;
			array = array4;
			if (!flag10)
			{
				object obj19 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v9+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v27+130]");
				bool flag11 = num6 < 0;
				object obj20 = !flag11;
				object obj21 = ~obj20;
				num4 = 0;
				text = text2;
				array = array4;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v9+B0]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v27+130]");
					object obj22 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v11-8]");
					object obj23 = default;
					bool flag12 = 0 != (nint)obj23;
					num4 = 0;
					text = text2;
					array = array4;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						object obj24 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v13+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v31+130]");
						bool flag13 = num8 < 0;
						object obj25 = !flag13;
						object obj26 = ~obj25;
						object obj28 = default;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v13+B0]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v31+130]");
							object obj27 = num9 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v19-8]");
							if (0 == (nint)obj28)
							{
								goto IL_0591;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						bool flag14 = num5 != (nint)obj28;
						num4 = 0;
						text = text2;
						array = array4;
						if (!flag14)
						{
							goto IL_0591;
						}
					}
				}
			}
			goto IL_06a6;
		}
		goto IL_06ed;
		IL_078d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_06ed;
		IL_06a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
		object obj29 = array;
		text = (string)(101789696 + 1224);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
		NullReferenceException ex6 = default;
		ex5 = ex6;
		num2 = unchecked((nint)null);
		goto IL_078d;
		IL_0591:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text5 = default;
		string message = text5 + text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v39+E4]");
		bool flag15 = (nint)0 == 0;
		object obj30 = !flag15;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		bool flag16 = (object)queue == null;
		text4 = text2;
		num4 = 0;
		num2 = unchecked((nint)null);
		text = null;
		array = array4;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			((List<System.__Canon>)(object)queue).RemoveAt(0);
			SaveQueue();
			return;
		}
		goto IL_067a;
		IL_067a:
		ex6 = new NullReferenceException();
		bool flag17 = (object)text != text4;
		ex5 = ex6;
		if (!flag17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			goto IL_06a6;
		}
		goto IL_078d;
	}

	private unsafe void SendNext()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		//IL_1939: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01a2: Expected I4, but got Obj
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I
		//IL_04a0: Expected I4, but got Obj
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04e0: Expected I4, but got Obj
		//IL_06dc: Expected Obj, but got I
		//IL_06e4: Expected I4, but got Obj
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I8
		//IL_0857: Expected Obj, but got I
		//IL_085f: Expected I4, but got Obj
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_0897: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I8
		//IL_0b4a: Expected Obj, but got I
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		//IL_0b8a: Expected Obj, but got I4
		//IL_14b0: Expected Obj, but got I4
		//IL_14b8: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I8
		//IL_075f: Expected Obj, but got I4
		//IL_1462: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0cb9: Expected Obj, but got I
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected Obj, but got Unknown
		//IL_0cf9: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I8
		//IL_08da: Expected Obj, but got I4
		//IL_1114: Expected Obj, but got I
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected Obj, but got Unknown
		//IL_1151: Expected Obj, but got I4
		//IL_0e52: Expected Obj, but got I
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e68: Expected Obj, but got Unknown
		//IL_0e92: Expected Obj, but got I4
		//IL_0bb1: Expected Obj, but got I8
		//IL_0bc9: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I4
		//IL_10c4: Expected Obj, but got I
		//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Expected Obj, but got Unknown
		//IL_10fa: Expected Obj, but got I4
		//IL_0d20: Expected Obj, but got I8
		//IL_0d38: Expected Obj, but got I4
		//IL_091c: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_1180: Expected Obj, but got I8
		//IL_1198: Expected Obj, but got I4
		//IL_1338: Expected Obj, but got I
		//IL_1361: Expected Obj, but got I
		//IL_1372: Expected I, but got Obj
		//IL_0ebf: Expected Obj, but got I4
		//IL_0bf4: Expected Obj, but got I4
		//IL_0943: Expected Obj, but got I4
		//IL_0950: Expected Obj, but got Ref
		//IL_07b5: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I
		//IL_02b9: Expected I4, but got Obj
		//IL_1387: Expected Obj, but got I
		//IL_13a1: Expected Obj, but got I
		//IL_13b2: Expected I, but got Obj
		//IL_0d72: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I
		//IL_064e: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I
		//IL_11da: Expected Obj, but got I
		//IL_0f06: Expected Obj, but got I4
		//IL_0d99: Expected Obj, but got I4
		//IL_0da6: Expected Obj, but got Ref
		//IL_0c17: Expected Obj, but got I
		//IL_0c27: Expected Obj, but got I
		//IL_096e: Expected Obj, but got I
		//IL_097e: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I4
		//IL_09cb: Expected Obj, but got I4
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected Obj, but got Unknown
		//IL_1201: Expected Obj, but got I4
		//IL_120e: Expected Obj, but got Ref
		//IL_0f36: Expected Obj, but got I4
		//IL_0dc4: Expected Obj, but got I
		//IL_0dd4: Expected Obj, but got I
		//IL_122c: Expected Obj, but got I
		//IL_123c: Expected Obj, but got I
		//IL_1271: Expected Obj, but got I4
		//IL_1281: Expected Obj, but got I4
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Expected Obj, but got Unknown
		//IL_0a3c: Expected Obj, but got I
		//IL_0a71: Expected Obj, but got I8
		//IL_0f59: Expected Obj, but got I
		//IL_0f77: Expected Obj, but got I8
		//IL_0f8f: Expected Obj, but got I4
		//IL_0f9d: Expected Obj, but got I4
		//IL_0392: Expected I4, but got Obj
		//IL_12fa: Expected Obj, but got I
		//IL_0fc3: Expected Obj, but got I4
		//IL_0fd1: Expected Obj, but got I4
		//IL_0acc: Expected Obj, but got I
		//IL_1638: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_042f: Expected Obj, but got I4
		//IL_1013: Expected Obj, but got I4
		//IL_1674: Expected Obj, but got I
		//IL_1036: Expected Obj, but got I
		//IL_1046: Expected Obj, but got I
		//IL_16de: Expected Obj, but got I4
		//IL_1771: Expected Obj, but got I4
		//IL_1712: Expected Obj, but got I
		//IL_17a5: Expected Obj, but got I
		//IL_1803: Expected Obj, but got I4
		//IL_180b: Expected Obj, but got Ref
		//IL_186b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass107_0 obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		GillaCloud gillaCloud = null;
		System.__Canon _Canon2;
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		int num3;
		StringSplitOptions stringSplitOptions;
		char c5;
		System.__Canon _Canon5;
		object obj17;
		System.__Canon _Canon;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag2 = (object)queue == null;
			gillaCloud = this;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83C0]");
				object obj4 = 0;
				_Canon = (System.__Canon)obj4;
				_Canon2 = ((List<System.__Canon>)(object)queue).get_Item(0);
				bool flag3 = _Canon2 == null;
				gillaCloud = null;
				if (!flag3)
				{
					char c = ((string)(object)_Canon2).get_Chars(0);
					int num = c & 0xFFFF;
					if (num == 82)
					{
						SendReport((string)(object)_Canon2);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					dictionary._002Ector();
					obj2.count = 1;
					string[] array = ((string)(object)_Canon2).Split(':', (StringSplitOptions)0);
					char c2 = ((string)(object)_Canon2).get_Chars(0);
					int num2 = c2 & 0xFFFF;
					bool flag4 = num2 != 69;
					string[] array2 = array;
					int num8 = default;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1C8]");
						object obj6 = 0;
						num3 = (int)obj6;
						object obj7 = obj2 + 32;
						obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag5 = array == null;
						stringSplitOptions = (StringSplitOptions)0;
						if (flag5)
						{
							goto IL_1402;
						}
						object obj8 = array.Length & 0xFFFFFFFEL;
						bool flag6 = obj8 == null;
						stringSplitOptions = (StringSplitOptions)0;
						if (flag6)
						{
							goto IL_1410;
						}
						int num4 = int.Parse(array[1]);
						List<System.__Canon> list = (List<System.__Canon>)(object)queue;
						bool flag7 = (object)queue == null;
						int num5 = num4;
						stringSplitOptions = (StringSplitOptions)0;
						array2 = (string[])num4;
						if (flag7)
						{
							goto IL_043d;
						}
						while (true)
						{
							num3 = obj2.count;
							if (obj2.count >= list._size)
							{
								break;
							}
							stringSplitOptions = (StringSplitOptions)obj4;
							System.__Canon _Canon3 = list.get_Item(obj2.count);
							if (_Canon3 != null)
							{
								char c3 = ((string)(object)_Canon3).get_Chars(0);
								int num6 = c3 & 0xFFFF;
								bool flag8 = num6 != 69;
								stringSplitOptions = (StringSplitOptions)0;
								if (flag8)
								{
									break;
								}
								num3 = obj2.count;
								int count = obj2.count + 1;
								obj2.count = count;
								bool flag9 = (object)queue == null;
								stringSplitOptions = (StringSplitOptions)0;
								if (flag9)
								{
									goto IL_13f4;
								}
								stringSplitOptions = (StringSplitOptions)obj4;
								System.__Canon _Canon4 = ((List<System.__Canon>)(object)queue).get_Item(obj2.count);
								if (_Canon4 != null)
								{
									string s = ((string)(object)_Canon4).Substring(2);
									int num7 = int.Parse(s);
									list = (List<System.__Canon>)(object)queue;
									num5 = num7 + num5;
									bool flag10 = (object)queue == null;
									object obj9 = !flag10;
									stringSplitOptions = (StringSplitOptions)0;
									array2 = (string[])num5;
									if (obj9 != null)
									{
										continue;
									}
									goto IL_043d;
								}
							}
							else
							{
								NullReferenceException ex = new NullReferenceException();
							}
							NullReferenceException ex2 = new NullReferenceException();
							goto IL_13f4;
							IL_13f4:
							NullReferenceException ex3 = new NullReferenceException();
							goto IL_1402;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						bool flag11 = dictionary == null;
						num3 = (int)(&num8);
						if (flag11)
						{
							goto IL_141e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1A0]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
						object obj12 = 0;
						_Canon5 = (System.__Canon)obj11;
						object obj13 = obj12;
						System.__Canon _Canon6 = default;
						dictionary.set_Item((System.__Canon)obj11, _Canon6);
						System.__Canon _Canon7 = _Canon6;
					}
					else
					{
						char c4 = ((string)(object)_Canon2).get_Chars(0);
						int num9 = c4 & 0xFFFF;
						if (num9 == 66)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC180]");
							object obj14 = 0;
							c5 = (char)(int)obj14;
							object obj15 = obj2 + 32;
							obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag12 = array2 == null;
							stringSplitOptions = (StringSplitOptions)0;
							num3 = (int)obj14;
							if (flag12)
							{
								goto IL_142c;
							}
							object obj16 = array2.Length & 0xFFFFFFFEL;
							bool flag13 = obj16 == null;
							stringSplitOptions = (StringSplitOptions)0;
							if (flag13)
							{
								goto IL_1442;
							}
							bool flag14 = array2[1] == null;
							stringSplitOptions = (StringSplitOptions)0;
							if (flag14)
							{
								goto IL_1450;
							}
							string[] array3 = array2[1].Split(',', (StringSplitOptions)0);
							bool flag15 = dictionary == null;
							obj17 = 0;
							stringSplitOptions = (StringSplitOptions)0;
							c5 = ',';
							if (flag15)
							{
								goto IL_1467;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1C0]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
							object obj19 = 0;
							_Canon5 = (System.__Canon)obj18;
							object obj13 = obj19;
							dictionary.set_Item((System.__Canon)obj18, (System.__Canon)(object)array3);
							System.__Canon _Canon7 = (System.__Canon)(object)array3;
						}
						else
						{
							char c6 = ((string)(object)_Canon2).get_Chars(0);
							int num10 = c6 & 0xFFFF;
							if (num10 == 85)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1F0]");
								object obj20 = 0;
								c5 = (char)(int)obj20;
								object obj21 = obj2 + 32;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag16 = array2 == null;
								obj17 = 0;
								stringSplitOptions = (StringSplitOptions)0;
								if (flag16)
								{
									goto IL_1475;
								}
								object obj22 = array2.Length & 0xFFFFFFFEL;
								bool flag17 = obj22 == null;
								obj17 = 0;
								stringSplitOptions = (StringSplitOptions)0;
								if (flag17)
								{
									goto IL_1483;
								}
								bool flag18 = dictionary == null;
								obj17 = 0;
								stringSplitOptions = (StringSplitOptions)0;
								if (flag18)
								{
									goto IL_1491;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1B0]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
								object obj24 = 0;
								System.__Canon _Canon7 = (System.__Canon)(object)array2[1];
								_Canon5 = (System.__Canon)obj23;
								object obj13 = obj24;
								dictionary.set_Item((System.__Canon)obj23, (System.__Canon)(object)array2[1]);
							}
							else
							{
								char c7 = ((string)(object)_Canon2).get_Chars(0);
								int num11 = c7 & 0xFFFF;
								if (num11 == 71)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1F8]");
									object obj25 = 0;
									c5 = (char)(int)obj25;
									object obj26 = obj2 + 32;
									obj26 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag19 = array2 == null;
									obj17 = 0;
									stringSplitOptions = (StringSplitOptions)0;
									if (flag19)
									{
										goto IL_149f;
									}
									object obj27 = array2.Length & 0xFFFFFFFEL;
									bool flag20 = obj27 == null;
									obj17 = 0;
									_Canon = null;
									_Canon5 = (System.__Canon)obj25;
									if (flag20)
									{
										goto IL_14bd;
									}
									int num12 = int.Parse(array2[1]);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									bool flag21 = dictionary == null;
									obj17 = 0;
									_Canon = null;
									_Canon5 = (System.__Canon)(&num8);
									if (flag21)
									{
										goto IL_14cb;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC178]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
									object obj30 = 0;
									_Canon5 = (System.__Canon)obj29;
									obj17 = obj30;
									System.__Canon _Canon8 = default;
									dictionary.set_Item((System.__Canon)obj29, _Canon8);
									bool flag22 = array2.Length < 2;
									object obj31 = !flag22;
									object obj32 = array2.Length - 2;
									bool flag23 = obj32 == null;
									object obj33 = ~obj31;
									object obj34 = obj33 | flag23;
									_Canon = _Canon8;
									if (obj34 != null)
									{
										goto IL_14d9;
									}
									int num13 = int.Parse(array2[2]);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC168]");
									object obj35 = 0;
									obj17 = obj30;
									_Canon5 = (System.__Canon)obj35;
									System.__Canon _Canon9 = default;
									dictionary.set_Item((System.__Canon)obj35, _Canon9);
									object obj36 = array2.Length & 0xFFFFFFFCL;
									bool flag24 = obj36 == null;
									_Canon = _Canon9;
									if (flag24)
									{
										goto IL_14e7;
									}
									int num14 = int.Parse(array2[3]);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1B8]");
									object obj37 = 0;
									object obj13 = obj30;
									_Canon5 = (System.__Canon)obj37;
									System.__Canon _Canon10 = default;
									dictionary.set_Item((System.__Canon)obj37, _Canon10);
									System.__Canon _Canon7 = _Canon10;
								}
								else
								{
									char c8 = ((string)(object)_Canon2).get_Chars(0);
									int num15 = c8 & 0xFFFF;
									if (num15 == 83)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1D8]");
										object obj38 = 0;
										_Canon5 = (System.__Canon)obj38;
										object obj39 = obj2 + 32;
										obj39 = obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag25 = array2 == null;
										obj17 = 0;
										_Canon = null;
										if (flag25)
										{
											goto IL_14f5;
										}
										object obj40 = array2.Length & 0xFFFFFFFEL;
										bool flag26 = obj40 == null;
										obj17 = 0;
										_Canon = null;
										if (flag26)
										{
											goto IL_1503;
										}
										bool flag27 = dictionary == null;
										obj17 = 0;
										_Canon = null;
										if (flag27)
										{
											goto IL_1511;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC170]");
										object obj41 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
										object obj42 = 0;
										System.__Canon _Canon7 = (System.__Canon)(object)array2[1];
										_Canon5 = (System.__Canon)obj41;
										object obj13 = obj42;
										dictionary.set_Item((System.__Canon)obj41, (System.__Canon)(object)array2[1]);
									}
									else
									{
										char c9 = ((string)(object)_Canon2).get_Chars(0);
										int num16 = c9 & 0xFFFF;
										if (num16 == 88)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC188]");
											object obj43 = 0;
											_Canon5 = (System.__Canon)obj43;
											object obj44 = obj2 + 32;
											obj44 = obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag28 = array2 == null;
											obj17 = 0;
											_Canon = null;
											if (flag28)
											{
												goto IL_151f;
											}
											object obj45 = array2.Length & 0xFFFFFFFEL;
											bool flag29 = obj45 == null;
											obj17 = 0;
											_Canon = null;
											if (flag29)
											{
												goto IL_152d;
											}
											int num17 = int.Parse(array2[1]);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
											object obj46 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											bool flag30 = dictionary == null;
											obj17 = 0;
											_Canon = null;
											_Canon5 = (System.__Canon)(&num8);
											if (flag30)
											{
												goto IL_153b;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1B8]");
											object obj47 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
											object obj48 = 0;
											_Canon5 = (System.__Canon)obj47;
											object obj13 = obj48;
											System.__Canon _Canon11 = default;
											dictionary.set_Item((System.__Canon)obj47, _Canon11);
											System.__Canon _Canon7 = _Canon11;
										}
										else
										{
											char c10 = ((string)(object)_Canon2).get_Chars(0);
											int num18 = c10 & 0xFFFF;
											if (num18 == 80)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1A8]");
												object obj49 = 0;
												_Canon5 = (System.__Canon)obj49;
												object obj50 = obj2 + 32;
												obj50 = obj49;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												bool flag31 = array2 == null;
												obj17 = 0;
												_Canon = null;
												if (flag31)
												{
													goto IL_1549;
												}
												bool flag32 = array2.Length < 2;
												object obj13 = 0;
												System.__Canon _Canon7 = null;
												if (!flag32)
												{
													string text = array2[1];
													bool flag33 = array2[1] == null;
													obj17 = 0;
													_Canon = null;
													if (flag33)
													{
														goto IL_1565;
													}
													bool flag34 = text._stringLength < 1;
													obj13 = 0;
													_Canon7 = null;
													if (!flag34)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
														object obj51 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														object obj52 = array2.Length & 0xFFFFFFFEL;
														bool flag35 = obj52 == null;
														obj17 = 0;
														_Canon = null;
														gillaCloud = (GillaCloud)1;
														if (!flag35)
														{
															System.__Canon _Canon12 = default;
															bool flag36 = _Canon12 == null;
															obj17 = 0;
															_Canon = null;
															_Canon5 = (System.__Canon)1;
															if (!flag36)
															{
																_Canon = (System.__Canon)(object)array2[1];
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
																bool flag37 = dictionary == null;
																obj17 = 0;
																_Canon5 = null;
																if (!flag37)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1D0]");
																	object obj53 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
																	object obj54 = 0;
																	_Canon5 = (System.__Canon)obj53;
																	obj13 = obj54;
																	dictionary.set_Item((System.__Canon)obj53, _Canon12);
																	_Canon7 = _Canon12;
																	goto IL_1328;
																}
															}
															goto IL_1557;
														}
														goto IL_15b3;
													}
												}
											}
											else
											{
												char c11 = ((string)(object)_Canon2).get_Chars(0);
												int num19 = c11 & 0xFFFF;
												if (num19 == 72)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1E0]");
													_Canon5 = (System.__Canon)(object)(obj2.function = (string)0);
													object obj55 = obj2 + 32;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													object obj13 = 0;
													System.__Canon _Canon7 = null;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC1E8]");
													object obj56 = (obj2.function = (string)0);
													object obj57 = obj2 + 32;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													bool flag38 = array2 == null;
													obj17 = 0;
													_Canon = null;
													_Canon5 = (System.__Canon)obj56;
													if (flag38)
													{
														goto IL_1573;
													}
													object obj58 = array2.Length & 0xFFFFFFFEL;
													bool flag39 = obj58 == null;
													obj17 = 0;
													_Canon = null;
													_Canon5 = (System.__Canon)obj56;
													if (flag39)
													{
														goto IL_1581;
													}
													int num20 = int.Parse(array2[1]);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj59 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													bool flag40 = dictionary == null;
													obj17 = 0;
													_Canon = null;
													gillaCloud = (GillaCloud)(&num8);
													if (flag40)
													{
														goto IL_1597;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC198]");
													object obj60 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
													object obj61 = 0;
													obj17 = obj61;
													System.__Canon _Canon13 = default;
													dictionary.set_Item((System.__Canon)obj60, _Canon13);
													bool flag41 = array2.Length < 2;
													object obj62 = !flag41;
													object obj63 = array2.Length - 2;
													bool flag42 = obj63 == null;
													object obj64 = ~obj62;
													object obj65 = obj64 | flag42;
													_Canon = _Canon13;
													gillaCloud = (GillaCloud)obj60;
													if (obj65 != null)
													{
														goto IL_15a5;
													}
													int num21 = int.Parse(array2[2]);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC190]");
													object obj66 = 0;
													object obj13 = obj61;
													_Canon5 = (System.__Canon)obj66;
													System.__Canon _Canon14 = default;
													dictionary.set_Item((System.__Canon)obj66, _Canon14);
													System.__Canon _Canon7 = _Canon14;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_1328;
				}
			}
		}
		goto IL_18ec;
		IL_1410:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_141e;
		IL_141e:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_142c;
		IL_142c:
		NullReferenceException ex6 = new NullReferenceException();
		c5 = (char)num3;
		goto IL_1442;
		IL_19fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_195f;
		IL_195f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_1328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC150]");
		object obj67 = 0;
		sendingCount = obj2.count;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC158]");
		object obj68 = 0;
		Action<System.__Canon> action = default;
		action._002Ector((object)obj2, (IntPtr)obj68);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC160]");
		object obj70 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)obj2, (IntPtr)obj70);
		Call(obj2.function, (Dictionary<string, object>)(object)dictionary, (Action<Reply>)action, (Action<string>)action2);
		return;
		IL_043d:
		throw new NullReferenceException();
		IL_1918:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
		object obj72 = default;
		object obj71 = obj72;
		gillaCloud = (GillaCloud)(101789696 + 1224);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
		_Canon = null;
		NullReferenceException ex8 = default;
		NullReferenceException ex7 = ex8;
		goto IL_19fd;
		IL_1450:
		NullReferenceException ex9 = new NullReferenceException();
		obj17 = 0;
		goto IL_1467;
		IL_149f:
		NullReferenceException ex10 = new NullReferenceException();
		_Canon = (System.__Canon)stringSplitOptions;
		_Canon5 = (System.__Canon)c5;
		goto IL_14bd;
		IL_14f5:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_1503;
		IL_1573:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_1581;
		IL_1581:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		gillaCloud = (GillaCloud)(object)_Canon5;
		goto IL_1597;
		IL_1597:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_15a5;
		IL_15a5:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_15b3;
		IL_15b3:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		bool flag43 = (nint)gillaCloud != 1;
		ex7 = (NullReferenceException)(object)ex16;
		object obj74 = default;
		if (!flag43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj73 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			bool flag44 = obj74 == null;
			obj72 = obj74;
			if (!flag44)
			{
				object obj75 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v16+130]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v37+130]");
				bool flag45 = num22 < 0;
				object obj76 = !flag45;
				object obj77 = ~obj76;
				obj72 = obj74;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v16+B0]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v37+130]");
					object obj78 = num23 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1687 @ X8_v18-8]");
					object obj79 = default;
					bool flag46 = 0 != (nint)obj79;
					obj72 = obj74;
					if (!flag46)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						object obj80 = obj73;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v20+130]");
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X0_v41+130]");
						bool flag47 = num24 < 0;
						object obj81 = !flag47;
						object obj82 = ~obj81;
						object obj84 = default;
						if (obj82 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ X8_v20+B0]");
							nint num25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X0_v41+130]");
							object obj83 = num25 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ X8_v33-8]");
							if (0 == (nint)obj84)
							{
								goto IL_17fa;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						object obj85 = obj73;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X8_v26+130]");
						nint num26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X0_v41+130]");
						bool flag48 = num26 < 0;
						object obj86 = !flag48;
						object obj87 = ~obj86;
						if (obj87 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ X8_v26+B0]");
							nint num27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X0_v41+130]");
							object obj88 = num27 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X8_v30-8]");
							if (0 == (nint)obj84)
							{
								goto IL_17fa;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						bool flag49 = obj73 != obj84;
						obj72 = obj74;
						if (!flag49)
						{
							goto IL_17fa;
						}
					}
				}
			}
			goto IL_1918;
		}
		goto IL_195f;
		IL_1565:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_1573;
		IL_14e7:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_14f5;
		IL_1503:
		IndexOutOfRangeException ex19 = new IndexOutOfRangeException();
		goto IL_1511;
		IL_1511:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_151f;
		IL_151f:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_152d;
		IL_152d:
		IndexOutOfRangeException ex22 = new IndexOutOfRangeException();
		goto IL_153b;
		IL_153b:
		NullReferenceException ex23 = new NullReferenceException();
		goto IL_1549;
		IL_1549:
		NullReferenceException ex24 = new NullReferenceException();
		goto IL_1557;
		IL_1557:
		NullReferenceException ex25 = new NullReferenceException();
		goto IL_1565;
		IL_1491:
		NullReferenceException ex26 = new NullReferenceException();
		goto IL_149f;
		IL_14bd:
		IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
		goto IL_14cb;
		IL_14cb:
		NullReferenceException ex28 = new NullReferenceException();
		goto IL_14d9;
		IL_14d9:
		IndexOutOfRangeException ex29 = new IndexOutOfRangeException();
		goto IL_14e7;
		IL_1442:
		IndexOutOfRangeException ex30 = new IndexOutOfRangeException();
		goto IL_1450;
		IL_1467:
		NullReferenceException ex31 = new NullReferenceException();
		goto IL_1475;
		IL_1475:
		NullReferenceException ex32 = new NullReferenceException();
		goto IL_1483;
		IL_1483:
		IndexOutOfRangeException ex33 = new IndexOutOfRangeException();
		goto IL_1491;
		IL_17fa:
		object obj89 = 0;
		object obj91 = default;
		object obj90 = (object)(&obj91);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text2 = default;
		string message = text2 + (string)(object)_Canon2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X0_v49+E4]");
		bool flag50 = (nint)0 == 0;
		object obj92 = !flag50;
		if (obj92 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		bool flag51 = (object)queue == null;
		obj72 = obj74;
		_Canon = null;
		gillaCloud = null;
		if (!flag51)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			((List<System.__Canon>)(object)queue).RemoveAt(0);
			SaveQueue();
			return;
		}
		goto IL_18ec;
		IL_18ec:
		ex8 = new NullReferenceException();
		bool flag52 = (object)gillaCloud != gillaCloud;
		ex7 = ex8;
		if (!flag52)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			goto IL_1918;
		}
		goto IL_19fd;
		IL_1402:
		NullReferenceException ex34 = new NullReferenceException();
		goto IL_1410;
	}

	private void Adopt(Reply reply)
	{
		//IL_0037: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		if (reply.day == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj5 = 0;
		ModMenuAccess.Adopt(reply.owned);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NameTitles.Adopt(reply.owned);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MonsterChoice.Adopt(reply.owned);
		List<string> list = queue;
		if (list._size > 0 || sendingCount > 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coins.Adopt(reply.coins, reply.owned, reply.bolts);
		bool flag5 = reply.dailyGiven < 1;
		int bolts = reply.bolts;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC398]");
			object format = 0;
			object arg = default;
			string message = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v27+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			bolts = 0;
		}
		GillaLevel.Adopt(reply.xp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Adopt(reply.day, reply.claimed);
	}

	private void LoadProfile()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_02cd: Expected I, but got Obj
		//IL_02db: Expected I, but got Obj
		//IL_0305: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I
		//IL_041e: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I
		//IL_049e: Expected I, but got Obj
		//IL_04af: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_04e8: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC250]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj4 = 0;
		System.__Canon[] items = list._items;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC248]");
		object obj6 = 0;
		bool flag = list._size < items.Length;
		object obj7 = !flag;
		if (obj7 == null)
		{
			object obj8 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj9 = obj8 + 32;
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v20+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+70]");
			object obj12 = 0;
			list.AddWithResize((System.__Canon)obj3);
		}
		System.__Canon[] items2 = list._items;
		object obj13 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		bool flag2 = list._size < items2.Length;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			object obj15 = items2 + list._size;
			int size2 = list._size + 1;
			list._size = size2;
			object obj16 = obj15 + 32;
			obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v6+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18+A8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+70]");
			object obj12 = 0;
			list.AddWithResize((System.__Canon)obj6);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC338]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC0A8]");
		object obj21 = 0;
		object obj22 = getUserDataRequest + 32;
		obj22 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num = (nint)obj20;
		Action<System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj20);
		object obj23 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj24 = !flag3;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v16+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v12+28]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v12+28]");
		bool flag4 = (nint)0 == 0;
		object obj27 = !flag4;
		object obj28 = 0;
		object obj29 = this;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj30 = !flag5;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v16+A0]");
				obj25 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC340]");
			object obj33 = 0;
			num = (nint)obj33;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj25, (IntPtr)obj33);
			object obj34 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v15+A0]");
			object obj35 = (nint)0 + (nint)40;
			obj35 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj28 = 0;
			obj29 = action2;
			errorCallback = (Action<PlayFabError>)action2;
		}
		object obj36 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj37 = !flag6;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserData(getUserDataRequest, (Action<GetUserDataResult>)action, errorCallback);
	}

	private void SaveProfile()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0115: Expected I4, but got I8
		//IL_012f: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		//IL_029a: Expected I, but got Obj
		//IL_02b7: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A00]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj3 = 0;
		profileUnsaved = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string wornNames = Cosmetics.WornNames;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC250]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj8 = 0;
		System.__Canon _Canon = (System.__Canon)obj6;
		object obj9 = obj7;
		dictionary.Add((System.__Canon)obj6, (System.__Canon)(object)wornNames);
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E68]");
		object obj12 = 0;
		int savedCode = GillaComputer.SavedCode;
		int num = (int)(savedCode & 0x80000000L);
		bool flag3 = num == 0;
		object obj13 = !flag3;
		System.__Canon _Canon2 = (System.__Canon)(object)wornNames;
		if (obj13 == null)
		{
			object obj14 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC248]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A30]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int savedCode2 = GillaComputer.SavedCode;
			int num2 = default;
			string text = num2.ToString();
			_Canon = (System.__Canon)obj15;
			obj9 = obj16;
			dictionary.set_Item((System.__Canon)obj15, (System.__Canon)(object)text);
			_Canon2 = (System.__Canon)(object)text;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserDataRequest updateUserDataRequest = default;
		updateUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E48]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC238]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC240]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj22 = 0;
		object obj23 = updateUserDataRequest + 32;
		obj23 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj21);
		object obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v25+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserData(updateUserDataRequest, (Action<UpdateUserDataResult>)action, (Action<PlayFabError>)action2);
	}

	public static void Run(string function, Dictionary<string, object> args, Action<string> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_0317: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF38]");
		object obj = 0;
		_003C_003Ec__DisplayClass111_0 obj2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj2 + 16;
			obj5 = failed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 24;
			obj6 = function;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj2 + 32;
			obj7 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v15+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v2+8]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				object obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v25+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v12+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
					object obj19 = 0;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v27+E4]");
					bool flag7 = (nint)0 == 0;
					object obj21 = !flag7;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj20 = obj19;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v27+A0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v15+10]");
					if (((PlayFabAuthenticationContext)0).IsClientLoggedIn())
					{
						break;
					}
				}
			}
			object obj23 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF60]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+40]");
			object obj25 = 0;
			object obj26 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+28]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+18]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v133 @ X3_v1 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF48]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ExecuteCloudScriptRequest executeCloudScriptRequest = default;
		executeCloudScriptRequest._002Ector();
		object obj30 = executeCloudScriptRequest + 32;
		obj30 = obj2.function;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj31 = executeCloudScriptRequest + 40;
		obj31 = args;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF40]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF50]");
		object obj33 = 0;
		Action<System.__Canon> action = default;
		action._002Ector((object)obj2, (IntPtr)obj33);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF58]");
		object obj35 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)obj2, (IntPtr)obj35);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v42+E4]");
		bool flag8 = (nint)0 == 0;
		object obj38 = !flag8;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.ExecuteCloudScript(executeCloudScriptRequest, (Action<ExecuteCloudScriptResult>)action, (Action<PlayFabError>)action2);
	}

	public static void ModAct(string player, string action, int minutes, string reason, string room, Action<bool, string> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_0233: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass112_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = done;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB570]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3D0]");
		object key2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3C0]");
		object key3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3B8]");
		object key4 = 0;
		dictionary.Add((System.__Canon)key, (System.__Canon)(object)player);
		dictionary.Add((System.__Canon)key2, (System.__Canon)(object)action);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon value = default;
		dictionary.Add((System.__Canon)key3, value);
		object obj7 = obj5;
		dictionary.Add((System.__Canon)key4, (System.__Canon)(object)reason);
		bool flag = string.IsNullOrEmpty(room);
		bool flag2 = !flag;
		object obj8 = !flag2;
		System.__Canon _Canon = (System.__Canon)(object)reason;
		System.__Canon _Canon2 = null;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEE8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE98]");
			object obj10 = 0;
			_Canon2 = (System.__Canon)obj9;
			obj7 = obj10;
			dictionary.set_Item((System.__Canon)obj9, (System.__Canon)(object)room);
			_Canon = (System.__Canon)(object)room;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3C8]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3A8]");
		object obj12 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3B0]");
		object obj13 = 0;
		Action<System.__Canon> action3 = default;
		action3._002Ector((object)obj2, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Run((string)function, (Dictionary<string, object>)(object)dictionary, (Action<string>)action2, (Action<string>)action3);
	}

	private static string ModRefusal(string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3D8]");
		object obj = 0;
		if (why == (string)obj)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC428]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC430]");
		object obj2 = 0;
		if (why == (string)obj2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC400]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC448]");
		object obj3 = 0;
		if (why == (string)obj3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC410]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC450]");
		object obj4 = 0;
		bool flag = why == (string)obj4;
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC468]");
			object obj6 = 0;
			if (!(why == (string)obj6))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC438]");
				object obj7 = 0;
				if (why == (string)obj7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3F0]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC418]");
				object obj8 = 0;
				if (why == (string)obj8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3E8]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC460]");
				object obj9 = 0;
				if (why == (string)obj9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAA60]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3F8]");
				object obj10 = 0;
				if (why == (string)obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC420]");
					return (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC458]");
				object obj11 = 0;
				if (why == (string)obj11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3E0]");
					return (string)0;
				}
				if (why != null)
				{
					string text = why.ToUpperInvariant();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC408]");
					object obj12 = 0;
					return (string)obj12 + text;
				}
				return (string)(object)new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC440]");
		return (string)0;
	}

	private void Call(string function, Dictionary<string, object> args, Action<Reply> done, Action<string> failed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC350]");
		object obj = 0;
		_003C_003Ec__DisplayClass115_0 obj2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
			object obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = function;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 24;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 32;
			obj6 = failed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj2 + 40;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v18+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+10]");
			if (((PlayFabAuthenticationContext)0).IsClientLoggedIn())
			{
				break;
			}
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC368]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+40]");
			object obj13 = 0;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v122 @ X3_v1 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF48]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		ExecuteCloudScriptRequest executeCloudScriptRequest = default;
		executeCloudScriptRequest._002Ector();
		object obj18 = executeCloudScriptRequest + 32;
		obj18 = obj2.function;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj19 = executeCloudScriptRequest + 40;
		obj19 = args;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF40]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC358]");
		object obj21 = 0;
		Action<System.__Canon> action = default;
		action._002Ector((object)obj2, (IntPtr)obj21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC360]");
		object obj23 = 0;
		Action<System.__Canon> action2 = default;
		action2._002Ector((object)obj2, (IntPtr)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v34+E4]");
		bool flag2 = (nint)0 == 0;
		object obj26 = !flag2;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.ExecuteCloudScript(executeCloudScriptRequest, (Action<ExecuteCloudScriptResult>)action, (Action<PlayFabError>)action2);
	}

	public GillaCloud()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = this + 48;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaCloud()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC470]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v6-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC478]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj8 = 0;
				object obj9 = obj4 + 40;
				obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v11+A0]");
				object obj11 = 0;
				obj11 = obj4;
				object obj12 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+A0]");
				object obj14 = (nint)0 + (nint)40;
				obj14 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v15+A0]");
				object obj16 = (nint)0 + (nint)48;
				obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj17 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v16+A0]");
				object obj18 = (nint)0 + (nint)80;
				obj18 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void _003CAskForState_003Eb__104_0(Reply reply)
	{
		stateAsking = false;
		Adopt(reply);
	}

	private void _003CAskForState_003Eb__104_1(string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj2 = 0;
		stateAsking = false;
		string message = (string)obj + why;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}

	private void _003CSendReport_003Eb__106_0(ReportPlayerClientResult result)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC218]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj2 = 0;
		((List<System.__Canon>)(object)queue).RemoveAt(0);
		sendingCount = 0;
		SaveQueue();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+48]");
		object obj8 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+A0]");
		object obj10 = 0;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 3f;
		nextSend = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC488]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string message = string.Format((string)format, arg);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
	}

	private void _003CSendReport_003Eb__106_1(PlayFabError error)
	{
		//IL_00b7: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		sendingCount = 0;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 20f;
		nextSend = num;
		if (error.Error == (PlayFabErrorCode)1074)
		{
			SessionLost();
			return;
		}
		if (error.HttpCode > 499 || error.Error == (PlayFabErrorCode)1123 || error.Error == (PlayFabErrorCode)2)
		{
			string text = error.GenerateErrorReport();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC490]");
			object obj = 0;
			string message = (string)obj + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			return;
		}
		string text2 = error.GenerateErrorReport();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC498]");
		object obj5 = 0;
		string message2 = (string)obj5 + text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message2);
		((List<System.__Canon>)(object)queue).RemoveAt(0);
		SaveQueue();
	}

	private void _003CLoadProfile_003Eb__109_0(GetUserDataResult result)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC140]");
		object key = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		if (num != 1 && (object)result.Data != null && ((Dictionary<System.__Canon, System.__Canon>)(object)result.Data).Count != 0)
		{
			applying = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC250]");
			object key2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E80]");
			object obj = 0;
			if (((Dictionary<System.__Canon, System.__Canon>)(object)result.Data).TryGetValue((System.__Canon)key2, out System.__Canon _))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ stack_-28_v4 (System.__Canon)+20]");
				string[] names = ((string)0).Split(',', (StringSplitOptions)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v23+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cosmetics.Adopt(names);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC248]");
			object key3 = 0;
			if (((Dictionary<System.__Canon, System.__Canon>)(object)result.Data).TryGetValue((System.__Canon)key3, out System.__Canon _))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ stack_-38_v4 (System.__Canon)+20]");
				if (int.TryParse((string)0, out var result2))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v18+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaComputer.Adopt(result2);
				}
			}
			applying = false;
		}
		else
		{
			profileUnsaved = true;
		}
	}

	private void _003CSaveProfile_003Eb__110_0(UpdateUserDataResult _)
	{
		//IL_0016: Expected Obj, but got I
		if (~(profileUnsaved ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC140]");
			object key = 0;
			PlayerPrefs.SetInt((string)key, 0);
			PlayerPrefs.Save();
		}
	}

	private void _003CSaveProfile_003Eb__110_1(PlayFabError error)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		profileUnsaved = true;
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 20f;
		nextProfile = num;
		if (error != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			string text = error.GenerateErrorReport();
			string message = (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			return;
		}
		throw new NullReferenceException();
	}
}
