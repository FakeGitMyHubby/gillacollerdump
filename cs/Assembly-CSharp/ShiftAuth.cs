using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;
using UnityEngine.Networking;

public static class ShiftAuth
{
	public struct Style
	{
		public int scale;

		public float slant;

		public bool bold;

		public Color32[] colours;

		public bool along;

		public Color32 shadow;
	}

	public enum FailKind
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		Network,
		// error: enumerator has no value
		VersionMismatch,
		// error: enumerator has no value
		SecurityViolation,
		// error: enumerator has no value
		Banned,
		// error: enumerator has no value
		AlreadyIn,
		// error: enumerator has no value
		Slow
	}

	public struct Outcome
	{
		public bool Success;

		public string Error;

		public FailKind Kind;
	}

	private sealed class PeerNote
	{
		public string sid;

		public string sig;

		public bool good;

		public float until;

		public float askedAt;
	}

	[Serializable]
	private class NonceBody
	{
		public string appId;
	}

	[Serializable]
	private class NonceReply
	{
		public bool ok;

		public string reason;

		public string category;

		public string nonce;
	}

	[Serializable]
	private class ChallengeBody
	{
		public string appId;

		public string build;

		public string version;

		public string manifestHash;

		public string nonce;

		public string devKey;
	}

	[Serializable]
	private class ChallengeReply
	{
		public bool ok;

		public string reason;

		public string category;
	}

	[Serializable]
	private class LoginBody
	{
		public string appId;

		public string clientId;

		public string metaUserId;

		public string displayName;

		public string build;

		public string platform;

		public string version;

		public string nonce;

		public string attestationToken;

		public string nativeFlags;

		public string attestError;

		public string teePub;

		public string teeSig;

		public string teeKeyId;

		public string teeHwSig;

		public string pfSessionTicket;

		public string devKey;
	}

	[Serializable]
	private class LoginReply
	{
		public bool ok;

		public string reason;

		public string category;

		public string token;

		public string sessionId;

		public string sessionSecret;

		public string challenge;

		public string playFabId;

		public string username;

		public string photonTicket;

		public string metaSig;

		public string assetKey;

		public bool hwReenroll;
	}

	[Serializable]
	private class HwEnrollBody
	{
		public string appId;

		public string nonce;

		public string metaUserId;

		public string[] chain;
	}

	[Serializable]
	private class HwEnrollReply
	{
		public bool ok;

		public string reason;

		public string keyId;

		public int securityLevel;
	}

	[Serializable]
	private class SessionBody
	{
		public string appId;

		public string token;
	}

	[Serializable]
	private class HeartbeatReply
	{
		public bool ok;

		public string reason;

		public string category;

		public string banReason;

		public bool alive;

		public bool rotated;

		public string token;

		public string sessionSecret;

		public string challenge;

		public bool requiresReAttestation;
	}

	[Serializable]
	private class TicketReply
	{
		public bool ok;

		public string reason;

		public string photonTicket;

		public string sessionId;
	}

	[Serializable]
	private class VerifyBody
	{
		public string appId;

		public string token;

		public string pfid;

		public string sid;

		public string sig;
	}

	[Serializable]
	private class VerifyReply
	{
		public bool ok;

		public bool valid;
	}

	[Serializable]
	private class ReportBody
	{
		public string appId;

		public string token;

		public string kind;

		public string reason;

		public string details;

		public string targetPlayFabId;

		public string targetName;

		public string roomName;
	}

	private sealed class Driver : MonoBehaviour
	{
	}

	private enum Beat
	{
		// error: enumerator has no value
		Transient,
		// error: enumerator has no value
		GoneSoft,
		// error: enumerator has no value
		GoneHard,
		// error: enumerator has no value
		Banned,
		// error: enumerator has no value
		UpdateRequired,
		// error: enumerator has no value
		Revoked
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool, string> _003C_003E9__138_3;

		public static Action<bool, string> _003C_003E9__159_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDC8]");
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

		internal void _003CAuthenticateOnce_003Eb__138_3(bool ok, string body)
		{
		}

		internal void _003CReportKick_003Eb__159_0(bool ok, string body)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public string userId;

		public string userName;

		internal void _003CStartup_003Eb__0(string id)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal void _003CStartup_003Eb__1(string name)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public Action<string> setId;

		public Action<string> setName;

		public bool finished;

		public Callback _003C_003E9__2;

		internal void _003CFetchMetaUser_003Eb__0()
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002f: Expected Obj, but got I
			//IL_003d: Expected I, but got Obj
			Request<User> loggedInUser = Users.GetLoggedInUser();
			object obj = this + 40;
			Callback val = (Callback)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDD0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDE0]");
				object obj4 = 0;
				Callback val2 = default;
				val2._002Ector((object)this, (IntPtr)obj4);
				_003C_003E9__2 = val2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				val = val2;
			}
			Request<System.__Canon> request = ((Request<System.__Canon>)(object)loggedInUser).OnComplete(val);
		}

		internal void _003CFetchMetaUser_003Eb__2(Message<User> msg)
		{
			//IL_0044: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I
			//IL_00ed: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I4
			//IL_013e: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			if (msg != null)
			{
				bool isError = msg.IsError;
				bool flag = !isError;
				object obj = !flag;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.User>)+40]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.User>)+40]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v4+18]");
						if ((nint)0 != 0)
						{
							Action<string> action = setId;
							ulong num = default;
							string text = num.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X21_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
							Action<string> action2 = setName;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v4+10]");
							bool flag2 = string.IsNullOrEmpty((string)0);
							bool flag3 = !flag2;
							object obj3 = !flag3;
							object obj4 = ~obj3;
							if (obj4 == null)
							{
								object obj5 = 48;
							}
							else
							{
								object obj5 = 16;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ X21_v5 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
						}
					}
				}
			}
			finished = true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_1
	{
		public Action getUser;

		public _003C_003Ec__DisplayClass134_0 CS_0024_003C_003E8__locals1;

		internal void _003CFetchMetaUser_003Eb__1(Message<PlatformInitialize> init)
		{
			//IL_011e: Expected Obj, but got I
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected Obj, but got Unknown
			//IL_0198: Expected Obj, but got I4
			Message<PlatformInitialize> message = default;
			if (message != null)
			{
				bool isError = message.IsError;
				bool flag = !isError;
				message = null;
				if (flag)
				{
					Action action = getUser;
					bool flag2 = getUser == null;
					message = null;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						return;
					}
					goto IL_00d3;
				}
			}
			goto IL_004c;
			IL_00d3:
			NullReferenceException ex = new NullReferenceException();
			bool flag3 = (nint)message != 1;
			NullReferenceException ex2 = ex;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				object obj3 = default;
				object obj2 = obj3;
				message = (Message<PlatformInitialize>)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj5 = default;
				object obj4 = obj5 & 1;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					goto IL_004c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj6 = obj3;
				message = (Message<PlatformInitialize>)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_004c:
			_003C_003Ec__DisplayClass134_0 obj7 = CS_0024_003C_003E8__locals1;
			if (CS_0024_003C_003E8__locals1 != null)
			{
				obj7.finished = true;
				return;
			}
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_00d3;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public Outcome result;

		internal void _003CConnect_003Eb__0(Outcome o)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0024: Expected VT, but got I4
			object obj = this + 24;
			_ = o.Kind;
			result = (Outcome)o.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public Outcome res;

		internal void _003CAuthenticate_003Eb__0(Outcome o)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0024: Expected VT, but got I4
			object obj = this + 24;
			_ = o.Kind;
			res = (Outcome)o.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public string error;

		public string category;

		public string nonce;

		public string attestation;

		public string attestError;

		public bool attested;

		public LoginReply login;

		internal void _003CAuthenticateOnce_003Eb__0(bool ok, string body)
		{
			//IL_0121: Expected Obj, but got I4
			//IL_0238: Expected Obj, but got I
			//IL_0241: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected Obj, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected Obj, but got Unknown
			//IL_01a3: Expected Obj, but got I
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_018e: Expected Obj, but got I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_0101: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_01e3: Expected Obj, but got I
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_01fe: Expected Obj, but got I
			object obj9;
			object obj10;
			_003C_003Ec__DisplayClass138_0 obj11;
			_003C_003Ec__DisplayClass138_0 obj13;
			object obj6;
			object obj8;
			if (ok)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDE8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj5 = default;
				object obj12;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+28]");
						if (!string.IsNullOrEmpty((string)0))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+28]");
							obj6 = 0;
							object obj7 = this + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+28]");
							obj7 = 0;
							obj8 = obj7;
							goto IL_024b;
						}
					}
					obj9 = obj5 + 24;
					obj10 = 0;
					obj11 = null;
					obj12 = obj5;
					obj13 = this;
					goto IL_013d;
				}
				obj12 = obj5;
				obj13 = null;
			}
			else
			{
				object obj12 = 0;
				obj13 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDF0]");
			obj9 = 0;
			obj10 = 1;
			obj11 = this;
			goto IL_013d;
			IL_024b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
			IL_013d:
			object obj14 = this + 16;
			obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = obj10 & 1;
			if (obj15 != null)
			{
				obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X20_v5+20]");
				obj6 = 0;
				obj11 = obj13;
			}
			object obj16 = obj11 + 24;
			obj16 = obj6;
			obj8 = obj16;
			goto IL_024b;
		}

		internal void _003CAuthenticateOnce_003Eb__1(bool ok, string body)
		{
			//IL_00c2: Expected Obj, but got I4
			//IL_01f4: Expected Obj, but got I
			//IL_01fd: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_0144: Expected Obj, but got I
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected Obj, but got Unknown
			//IL_012f: Expected Obj, but got I4
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected Obj, but got Unknown
			//IL_0197: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I4
			object obj6;
			object obj8;
			_003C_003Ec__DisplayClass138_0 obj9;
			_003C_003Ec__DisplayClass138_0 obj11;
			if (ok)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDF8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj5 = default;
				object obj10;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v13+10]");
					if ((nint)0 != 0)
					{
						return;
					}
					obj6 = obj5 + 24;
					bool flag2 = this == null;
					object obj7 = !flag2;
					obj8 = 0;
					obj9 = null;
					obj10 = obj5;
					obj11 = this;
					if (obj7 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_00de;
				}
				obj10 = obj5;
				obj11 = null;
			}
			else
			{
				object obj10 = 0;
				obj11 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE00]");
			obj6 = 0;
			obj8 = 1;
			obj9 = this;
			goto IL_00de;
			IL_00de:
			object obj12 = this + 16;
			obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = obj8 & 1;
			object obj14;
			if (obj13 != null)
			{
				obj14 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v4+20]");
				obj14 = 0;
				obj9 = obj11;
			}
			object obj15 = obj9 + 24;
			obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal void _003CAuthenticateOnce_003Eb__2(Message<string> msg)
		{
			//IL_008e: Expected Obj, but got I
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			object obj3;
			object obj;
			object obj2;
			if (msg != null)
			{
				if (!msg.IsError)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ X1 (Oculus.Platform.Message`1<System.String>)+40]");
					obj = 0;
					obj2 = this + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ X1 (Oculus.Platform.Message`1<System.String>)+40]");
					obj2 = 0;
					goto IL_0100;
				}
				NetSyncSetSessionPropertyResult netSyncSetSessionPropertyResult = ((Message<ChallengeList>)(object)msg).GetNetSyncSetSessionPropertyResult();
				if (netSyncSetSessionPropertyResult != null)
				{
					NetSyncSetSessionPropertyResult netSyncSetSessionPropertyResult2 = ((Message<ChallengeList>)(object)msg).GetNetSyncSetSessionPropertyResult();
					obj3 = netSyncSetSessionPropertyResult2 + 24;
					goto IL_0093;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE08]");
			obj3 = 0;
			goto IL_0093;
			IL_0100:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			attested = true;
			return;
			IL_0093:
			obj = obj3;
			obj2 = this + 48;
			obj2 = obj3;
			goto IL_0100;
		}

		internal void _003CAuthenticateOnce_003Eb__4(bool ok, string body)
		{
			//IL_00e9: Expected Obj, but got I4
			//IL_0228: Expected Obj, but got I
			//IL_0231: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected Obj, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_016b: Expected Obj, but got I
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected Obj, but got Unknown
			//IL_0156: Expected Obj, but got I4
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01c0: Expected Obj, but got I4
			//IL_01c9: Expected Obj, but got I4
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			object obj9;
			object obj11;
			_003C_003Ec__DisplayClass138_0 obj12;
			_003C_003Ec__DisplayClass138_0 obj14;
			object obj7;
			object obj8;
			if (ok)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE10]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj5 = default;
				object obj13;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v14+10]");
					if ((nint)0 != 0)
					{
						object obj6 = this + 64;
						obj6 = obj5;
						obj7 = obj5;
						obj8 = obj6;
						goto IL_020d;
					}
					obj9 = obj5 + 24;
					bool flag2 = this == null;
					object obj10 = !flag2;
					obj11 = 0;
					obj12 = null;
					obj13 = obj5;
					obj14 = this;
					if (obj10 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_0105;
				}
				obj13 = obj5;
				obj14 = null;
			}
			else
			{
				object obj13 = 0;
				obj14 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE18]");
			obj9 = 0;
			obj11 = 1;
			obj12 = this;
			goto IL_0105;
			IL_0105:
			object obj15 = this + 16;
			obj15 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj16 = obj11 & 1;
			if (obj16 != null)
			{
				obj7 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v6+20]");
				obj7 = 0;
				obj12 = obj14;
			}
			object obj17 = obj12 + 24;
			obj17 = obj7;
			obj8 = obj17;
			goto IL_020d;
			IL_020d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public int mine;
	}

	private sealed class _003C_003Ec__DisplayClass146_1
	{
		public long status;

		public float serverWait;

		public string reason;

		public string category;

		public string banReason;

		public bool alive;

		public bool reattest;

		public int epoch;

		public _003C_003Ec__DisplayClass146_0 CS_0024_003C_003E8__locals1;

		internal void _003CHeartbeatLoop_003Eb__0(bool ok, string body)
		{
			//IL_0010: Expected Obj, but got I
			//IL_02e6: Expected Obj, but got I
			//IL_0308: Expected Obj, but got I4
			//IL_050f: Expected Obj, but got I
			//IL_0521: Expected I8, but got I
			//IL_0533: Expected F4, but got I
			//IL_0254: Expected Obj, but got I
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected Obj, but got Unknown
			//IL_0284: Expected Obj, but got I
			//IL_02c9: Expected Obj, but got I
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Expected Obj, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Expected Obj, but got Unknown
			//IL_04c5: Expected Obj, but got I
			//IL_04df: Expected Obj, but got I
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected Obj, but got Unknown
			//IL_04fa: Expected Obj, but got I
			//IL_00d3: Expected Obj, but got I4
			//IL_0327: Expected Obj, but got I
			//IL_011a: Expected Obj, but got I4
			//IL_014a: Expected Obj, but got I
			//IL_0171: Expected Obj, but got I4
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected Obj, but got Unknown
			//IL_039a: Expected Obj, but got I
			//IL_03b5: Expected Obj, but got I
			//IL_03d3: Expected Obj, but got I4
			//IL_03dc: Expected Obj, but got I4
			//IL_021f: Expected Obj, but got I4
			//IL_01a1: Expected Obj, but got I
			//IL_0445: Expected Obj, but got I
			//IL_0455: Expected Obj, but got I
			//IL_0477: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I4
			//IL_0400: Expected Obj, but got I
			//IL_0410: Expected Obj, but got I
			//IL_042a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+130]");
			status = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+138]");
			serverWait = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+30]");
					alive = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+50]");
					reattest = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+31]");
					if ((nint)0 == 0)
					{
						return;
					}
					_003C_003Ec__DisplayClass146_0 obj7 = CS_0024_003C_003E8__locals1;
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+A0]");
					object obj10 = 0;
					int mine = obj7.mine;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v17+B4]");
					if ((nint)mine != 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+A0]");
						obj10 = 0;
					}
					int num = epoch;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v17+13C]");
					if ((nint)num != 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v24+A0]");
						obj10 = 0;
					}
					object obj14 = obj10 + 192;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+38]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+40]");
					bool flag5 = string.IsNullOrEmpty((string)0);
					bool flag6 = !flag5;
					object obj15 = !flag6;
					object obj16 = 0;
					if (obj15 == null)
					{
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v34+E4]");
						bool flag7 = (nint)0 == 0;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj17 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v34+A0]");
						object obj19 = (nint)0 + (nint)200;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+40]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+40]");
						obj16 = 0;
					}
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v27+E4]");
					bool flag8 = (nint)0 == 0;
					object obj21 = !flag8;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj20 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v27+A0]");
					object obj22 = (nint)0 + (nint)208;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+48]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v21+A0]");
					object obj24 = 0;
					_ = 0;
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE30]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
				object obj26;
				if ((nint)0 == 0)
				{
					obj26 = obj25;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
					obj26 = 0;
				}
				object obj27 = this + 32;
				obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj28 = this + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+20]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+28]");
				object obj29 = 0;
				object obj30 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+28]");
				obj30 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE28]");
				object obj31 = 0;
				object obj29 = obj31;
				object obj30 = this + 32;
				obj30 = obj31;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_2
	{
		public Outcome renew;

		internal void _003CHeartbeatLoop_003Eb__1(Outcome o)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0024: Expected VT, but got I4
			object obj = this + 24;
			_ = o.Kind;
			renew = (Outcome)o.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private sealed class _003C_003Ec__DisplayClass158_0
	{
		public float serverWait;

		public bool got;

		public string fresh;

		internal void _003CRefreshPhotonTicket_003Eb__0(bool ok, string body)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0150: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I
			//IL_0180: Expected F4, but got I
			//IL_003c: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I4
			//IL_00d8: Expected Obj, but got I
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_0115: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+138]");
			serverWait = 0f;
			if (!ok)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
			object obj7 = default;
			if (obj7 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+20]");
				if (!string.IsNullOrEmpty((string)0))
				{
					object obj8 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+20]");
					obj8 = 0;
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass160_0
	{
		public PeerNote mine;

		public Action<bool> done;

		internal void _003CVerifyPeer_003Eb__0(bool ok, string body)
		{
			//IL_01e5: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_001d: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I4
			//IL_028f: Expected Obj, but got I
			//IL_01c7: Expected F4, but got I4
			//IL_01d0: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I
			//IL_025b: Expected Obj, but got I
			//IL_026b: Expected Obj, but got I
			//IL_011c: Expected F4, but got I4
			//IL_010e: Expected F4, but got I4
			//IL_012c: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			bool flag = default;
			object obj5;
			if (flag)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj6 = default;
				obj5 = obj6;
			}
			else
			{
				obj5 = 0;
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			PeerNote peerNote = mine;
			peerNote.askedAt = realtimeSinceStartup;
			Action<bool> action;
			float until;
			float num2;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v2+10]");
				if ((nint)0 != 0)
				{
					action = done;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v2+11]");
					peerNote.good = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v2+11]");
					float num = (((nint)0 != 0) ? 1.1422925E+09f : 1.1339039E+09f);
					until = realtimeSinceStartup + num;
					peerNote.until = until;
					num2 = 1.1339039E+09f;
					goto IL_023b;
				}
			}
			peerNote.good = true;
			float until2 = realtimeSinceStartup + 1.1274813E+09f;
			peerNote.until = until2;
			float num3 = UnityEngine.Random.Range(0f, 60f);
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			goto IL_0275;
			IL_0275:
			action = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+A0]");
			object obj9 = 0;
			float num4 = realtimeSinceStartup + 1.1146363E+09f;
			until = num4 + num3;
			num2 = 1.1146363E+09f;
			object obj10 = 1;
			goto IL_023b;
			IL_023b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v2 (System.Action`1<System.Boolean>)+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v2 (System.Action`1<System.Boolean>)+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v2 (System.Action`1<System.Boolean>)+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_0275;
		}
	}

	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public string apkPath;

		public string fallback;

		internal unsafe string _003CInit_003Eb__0()
		{
			//IL_07c2: Expected Obj, but got I4
			//IL_0491: Expected Obj, but got I4
			//IL_049a: Expected Obj, but got I4
			//IL_04a2: Expected Obj, but got Ref
			//IL_04ab: Expected Obj, but got I4
			//IL_04b9: Expected Obj, but got I4
			//IL_008c: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_00f2: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I4
			//IL_010c: Expected Obj, but got Ref
			//IL_0115: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I4
			//IL_07ea: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I
			//IL_0158: Expected Obj, but got I
			//IL_0246: Expected Obj, but got I4
			//IL_01f7: Expected Obj, but got I4
			//IL_083c: Expected Obj, but got I
			//IL_0193: Expected Obj, but got I
			//IL_053a: Expected Obj, but got I4
			//IL_0543: Expected Obj, but got I4
			//IL_02ac: Expected Obj, but got Ref
			//IL_0808: Expected Obj, but got I
			//IL_058f: Expected Obj, but got I4
			//IL_0865: Expected Obj, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected Obj, but got Unknown
			//IL_02e9: Expected Obj, but got I
			//IL_02f9: Expected Obj, but got I
			//IL_01ae: Expected Obj, but got I
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected Obj, but got Unknown
			//IL_05db: Expected Obj, but got I4
			//IL_05fc: Expected Obj, but got I4
			//IL_03e7: Expected Obj, but got I4
			//IL_0398: Expected Obj, but got I4
			//IL_0670: Expected Obj, but got I4
			//IL_08ff: Expected Obj, but got I
			//IL_0334: Expected Obj, but got I
			//IL_06c4: Expected Obj, but got I
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected Obj, but got Unknown
			//IL_08cb: Expected Obj, but got I
			//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e9: Expected Obj, but got Unknown
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Expected Obj, but got Unknown
			//IL_074c: Expected Obj, but got I4
			//IL_034f: Expected Obj, but got I
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected Obj, but got Unknown
			//IL_0776: Expected Obj, but got I4
			//IL_070f: Expected Obj, but got I4
			//IL_0717: Expected Obj, but got Ref
			bool flag = string.IsNullOrEmpty(apkPath);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj != null || !File.Exists(apkPath))
			{
				goto IL_0470;
			}
			FileStream inputStream = File.OpenRead(apkPath);
			SHA256 sHA = SHA256.Create();
			object obj5;
			object obj7;
			object obj8;
			object obj9;
			object obj10 = default;
			object obj11;
			OutOfMemoryException ex;
			string result;
			object obj12;
			object obj6 = default;
			if (sHA != null)
			{
				byte[] bytes = sHA.ComputeHash(inputStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v70+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = ToHex(bytes);
				obj5 = 0;
				obj6 = 0;
				obj7 = 0;
				obj8 = 0;
				obj9 = (object)(&obj10);
				obj11 = 0;
				ex = null;
				obj12 = 0;
				result = text;
				goto IL_0913;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj7 = 0;
			obj8 = 0;
			obj9 = (object)(&obj10);
			obj11 = 0;
			ex = null;
			obj12 = 0;
			goto IL_04be;
			IL_07d0:
			bool flag4 = obj8 == null;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_04cc;
			}
			bool flag5 = obj7 == null;
			object obj14 = !flag5;
			object obj16 = default;
			object obj15 = obj16;
			object obj18 = default;
			object obj17 = obj18;
			object obj20 = default;
			object obj19 = obj20;
			object obj21 = obj6;
			object obj22 = obj7;
			object obj23 = obj8;
			object obj24 = obj11;
			OutOfMemoryException ex3 = ex;
			object obj25 = obj12;
			object obj26 = obj8;
			if (obj14 == null)
			{
				goto IL_02a4;
			}
			goto IL_04e9;
			IL_04da:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_04e9;
			IL_090e:
			return result;
			IL_02a4:
			object obj28 = default;
			object obj27 = (object)(&obj28);
			object obj29 = obj27;
			if (obj27 == null)
			{
				goto IL_084b;
			}
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v31+12E]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v31+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0385;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v31+98]");
			object obj31 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X10_v25-8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X10_v25-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v31+12E]");
				obj17 = -1;
				obj19 = obj31 + 16;
				bool flag6 = (nint)obj17 != 1;
				obj31 = obj19;
				if (flag6)
				{
					continue;
				}
				goto IL_0385;
			}
			obj17 = obj31;
			object obj32 = obj30 + obj31;
			object obj33 = obj32 + 312;
			obj19 = obj31;
			goto IL_08ef;
			IL_084b:
			bool flag7 = ex3 == null;
			object obj34 = !flag7;
			obj16 = obj15;
			obj18 = obj17;
			obj20 = obj19;
			obj6 = obj21;
			obj7 = obj22;
			obj8 = obj23;
			obj11 = obj24;
			ex = ex3;
			obj12 = obj25;
			if (obj34 != null)
			{
				goto IL_04be;
			}
			bool flag8 = obj24 == null;
			object obj35 = !flag8;
			obj16 = obj15;
			obj18 = obj17;
			obj20 = obj19;
			obj6 = obj21;
			obj7 = obj22;
			obj8 = obj23;
			obj11 = obj24;
			ex = ex3;
			obj12 = obj25;
			OutOfMemoryException ex4 = ex3;
			if (obj35 != null)
			{
				goto IL_04da;
			}
			object obj36 = obj5 & 1;
			if (obj36 != null)
			{
				goto IL_0470;
			}
			goto IL_090e;
			IL_04cc:
			ex4 = new OutOfMemoryException();
			goto IL_04da;
			IL_0913:
			object obj37 = obj9;
			if (obj9 == null)
			{
				goto IL_07d0;
			}
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+12E]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+98]");
			object obj39 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X10_v11-8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X10_v11-8]");
				if (0 == (nint)obj20)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+12E]");
				obj18 = -1;
				obj20 = obj39 + 16;
				bool flag9 = (nint)obj18 != 1;
				obj39 = obj20;
				if (flag9)
				{
					continue;
				}
				goto IL_01e4;
			}
			obj18 = obj39;
			object obj40 = obj38 + obj39;
			object obj41 = obj40 + 312;
			obj20 = obj39;
			goto IL_082c;
			IL_04be:
			OutOfMemoryException ex5 = new OutOfMemoryException();
			goto IL_04cc;
			IL_0385:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj21 = 0;
			goto IL_08ef;
			IL_04e9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj12 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj5 = 1;
				obj7 = 1;
				result = null;
			}
			else
			{
				if ((nint)obj12 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
					if ((nint)obj12 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj15 = obj16;
						obj17 = obj18;
						obj19 = obj20;
						obj5 = 1;
						obj21 = obj6;
						obj22 = obj7;
						obj23 = obj8;
						obj24 = 1;
						ex3 = ex;
						obj25 = obj12;
						result = null;
					}
					else
					{
						if ((nint)obj12 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
							bool flag10 = (nint)obj12 != 1;
							object obj43 = default;
							object obj42 = obj43;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj44 = 0;
								object obj46 = default;
								object obj45 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
								object obj48 = default;
								object obj47 = obj48 & 1;
								if (obj47 != null)
								{
									object obj49 = 0;
									object obj51 = default;
									object obj50 = (object)(&obj51);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									goto IL_0470;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
								object obj52 = obj46;
								obj12 = 101789696 + 1224;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								object obj53 = default;
								obj42 = obj53;
								obj6 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							string result2 = default;
							return result2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj15 = obj16;
						obj17 = obj18;
						obj19 = obj20;
						obj5 = 1;
						obj21 = obj6;
						obj22 = obj7;
						obj23 = obj8;
						obj24 = obj11;
						object obj54 = default;
						ex3 = (OutOfMemoryException)obj54;
						obj25 = obj12;
						result = null;
					}
					goto IL_02a4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj5 = 1;
				object obj55 = default;
				obj8 = obj55;
				result = null;
			}
			goto IL_0913;
			IL_08ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v63+8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v656 @ X0_v63] (should have been resolved before IL gen)");
			goto IL_084b;
			IL_0470:
			result = fallback;
			goto IL_090e;
			IL_01e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj6 = 0;
			goto IL_082c;
			IL_082c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v16+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v567 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_07d0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass178_0
	{
		public string hwNonce;

		public string enrolled;

		internal void _003CEnsureHwKey_003Eb__0(bool ok, string body)
		{
			//IL_00ee: Expected Obj, but got I
			//IL_014c: Expected Obj, but got I
			//IL_015c: Expected Obj, but got I
			//IL_0197: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			//IL_00d3: Expected Obj, but got I
			object obj7;
			if (ok)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDE8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj5 = default;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+10]");
					if ((nint)0 != 0)
					{
						object obj6 = this + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+28]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
					obj7 = obj5 + 24;
					goto IL_013c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
			obj7 = 0;
			goto IL_013c;
			IL_013c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE48]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj9 = 0;
			string message = (string)obj8 + (string)obj7;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
		}

		internal void _003CEnsureHwKey_003Eb__1(bool ok, string body)
		{
			//IL_00ee: Expected Obj, but got I
			//IL_014c: Expected Obj, but got I
			//IL_015c: Expected Obj, but got I
			//IL_0197: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I4
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			//IL_00d3: Expected Obj, but got I
			object obj7;
			if (ok)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE50]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376E674");
				object obj5 = default;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+10]");
					if ((nint)0 != 0)
					{
						object obj6 = this + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+20]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
					obj7 = obj5 + 24;
					goto IL_013c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
			obj7 = 0;
			goto IL_013c;
			IL_013c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE58]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj9 = 0;
			string message = (string)obj8 + (string)obj7;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
		}
	}

	private sealed class _003CAuthenticate_003Ed__136 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Outcome> done;

		public string metaUserId;

		public string displayName;

		private _003C_003Ec__DisplayClass136_0 _003C_003E8__1;

		private long _003Cnow_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CAuthenticate_003Ed__136(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_001e: Expected Obj, but got I4
			//IL_0038: Expected Obj, but got I4
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			object obj = _003C_003E1__state + 3;
			object obj2 = 1 << (int)obj;
			bool flag = (nint)obj < 5;
			object obj3 = !flag;
			object obj4 = obj - 5;
			bool flag2 = obj4 == null;
			object obj5 = obj2 & (object)typeof(_0021_00210);
			object obj6 = ~obj3;
			object obj7 = obj6 | flag2;
			object obj8 = ~obj7;
			if (obj8 == null && obj5 != null)
			{
				_003C_003Em__Finally1();
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0376: Expected I4, but got I8
			//IL_03b9: Invalid comparison between VT and I4
			//IL_02de: Expected I4, but got I8
			//IL_053a: Expected Obj, but got I
			//IL_0564: Expected Obj, but got I4
			//IL_0e0a: Expected Obj, but got I
			//IL_0e24: Expected Obj, but got I
			//IL_0e3a: Expected I, but got Obj
			//IL_0e4a: Expected Obj, but got I
			//IL_0e74: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got I4
			//IL_0592: Expected Obj, but got I
			//IL_059b: Expected I, but got Obj
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected Obj, but got Unknown
			//IL_0c8f: Expected Obj, but got I
			//IL_0cb9: Expected Obj, but got I4
			//IL_0359: Expected I, but got Obj
			//IL_0067: Expected Obj, but got I
			//IL_0076: Expected I4, but got I8
			//IL_0f1c: Expected Obj, but got I
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00be: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I4
			//IL_0bc0: Expected Obj, but got I
			//IL_0bd0: Expected Obj, but got I
			//IL_0c06: Expected Obj, but got I4
			//IL_05cd: Invalid comparison between VT and I4
			//IL_015c: Expected Obj, but got I
			//IL_0171: Expected Obj, but got I8
			//IL_08e5: Expected Obj, but got I
			//IL_0603: Expected Obj, but got I4
			//IL_0c36: Expected Obj, but got I4
			//IL_0d4b: Expected F4, but got I4
			//IL_0ee5: Expected Obj, but got I
			//IL_01bb: Expected Obj, but got I4
			//IL_0975: Expected Obj, but got I
			//IL_0633: Expected Obj, but got I
			//IL_03fd: Expected Obj, but got I4
			//IL_0ea4: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got I
			//IL_0234: Expected I, but got Obj
			//IL_024f: Expected Obj, but got Ref
			//IL_0283: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I
			//IL_09dd: Expected Obj, but got I
			//IL_0a08: Expected F4, but got I4
			//IL_06a7: Expected Obj, but got I4
			//IL_042d: Expected Obj, but got I
			//IL_0d60: Expected Obj, but got I
			//IL_0d7c: Expected I, but got Obj
			//IL_0465: Expected Obj, but got I4
			//IL_0a51: Expected F4, but got VT
			//IL_0a61: Expected Obj, but got I
			//IL_0fa6: Expected Obj, but got I4
			//IL_0cfc: Expected Obj, but got I
			//IL_0d1c: Invalid comparison between F4 and I4
			//IL_02b0: Expected Obj, but got I
			//IL_0d9a: Expected Obj, but got I
			//IL_0dc1: Expected Obj, but got I
			//IL_06dc: Expected Obj, but got I
			//IL_0706: Expected Obj, but got I4
			//IL_0733: Expected Obj, but got I
			//IL_0749: Expected I, but got Obj
			//IL_049a: Expected Obj, but got I
			//IL_04a2: Expected I, but got Obj
			//IL_04bd: Expected Obj, but got Ref
			//IL_0773: Expected VT, but got I4
			//IL_0791: Expected I4, but got I8
			//IL_07a1: Expected Obj, but got I
			//IL_07b1: Expected Obj, but got I
			//IL_0502: Expected Obj, but got I
			//IL_0800: Expected Obj, but got I4
			//IL_0875: Expected Obj, but got I
			//IL_0888: Unknown result type (might be due to invalid IL or missing references)
			//IL_088d: Expected Obj, but got Unknown
			//IL_0895: Expected Obj, but got I
			//IL_0830: Expected Obj, but got I
			//IL_0840: Expected Obj, but got I
			_003CAuthenticate_003Ed__136 obj5 = default;
			float num7 = default;
			_003CAuthenticate_003Ed__136 obj40;
			Action<Outcome> action2;
			nint num4 = default;
			bool flag2;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					flag2 = false;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE68]");
						object obj2 = 0;
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj3 = default;
						obj3._002Ector();
						object obj4 = obj5 + 56;
						obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj6 = 0;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v80+E4]");
						bool flag3 = (nint)0 == 0;
						object obj8 = !flag3;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj7 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v80+A0]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
						object obj10 = 0;
						_ = 0;
						object obj11 = obj10;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v81+E4]");
						bool flag4 = (nint)0 == 0;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTimeOffset utcNow = DateTimeOffset.UtcNow;
						DateTimeOffset dateTimeOffset = default;
						long num = dateTimeOffset.ToUnixTimeSeconds();
						object obj13 = obj6;
						obj5._003Cnow_003E5__2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v93+100]");
						object obj15 = -num;
						bool flag5 = (nint)obj15 <= 600;
						long num2 = num;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
							bool flag6 = (nint)0 == 0;
							object obj16 = !flag6;
							num2 = num;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj13 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
								obj14 = 0;
								num2 = obj5._003Cnow_003E5__2;
							}
							_ = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
						bool flag7 = (nint)0 == 0;
						object obj17 = !flag7;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
						object obj18 = 0;
						long num3 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v56+100]");
						float num5 = default;
						float num6;
						if (num3 < 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0A8]");
							object obj19 = 0;
							num4 = (nint)obj19;
							Action<Outcome> action = obj5.done;
							object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 2));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj21 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X0_v127+E4]");
							bool flag8 = (nint)0 == 0;
							object obj22 = !flag8;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (obj5.done == null)
							{
								goto IL_0ab5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X19_v33 (System.Action`1<ShiftAuth+Outcome>)+28]");
							action2 = (Action<Outcome>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v650 @ X19_v33 (System.Action`1<ShiftAuth+Outcome>)+18] (should have been resolved before IL gen)");
							num6 = num5;
							num4 = (nint)(&num7);
							goto IL_0c71;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
						bool flag9 = (nint)0 == 0;
						object obj23 = !flag9;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
							obj18 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v56+108]");
						if ((nint)0 != 0)
						{
							float realtimeSinceStartup = Time.realtimeSinceStartup;
							obj13 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
							bool flag10 = (nint)0 == 0;
							object obj24 = !flag10;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj13 = obj6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
							object obj25 = 0;
							float num8 = realtimeSinceStartup;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v78+190]");
							num6 = num8 - 0f;
							bool flag11 = !(num6 < 1.1274813E+09f);
							int num9 = 1127481344;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE040]");
								object obj26 = 0;
								num4 = (nint)obj26;
								Action<Outcome> action3 = obj5.done;
								object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 2));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag12 = obj5.done == null;
								num9 = 1127481344;
								if (flag12)
								{
									goto IL_0ad1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X19_v32 (System.Action`1<ShiftAuth+Outcome>)+28]");
								action2 = (Action<Outcome>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v759 @ X19_v32 (System.Action`1<ShiftAuth+Outcome>)+18] (should have been resolved before IL gen)");
								num9 = 1127481344;
								num6 = num5;
								num4 = (nint)(&num7);
								goto IL_0c71;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
						bool flag13 = (nint)0 == 0;
						object obj28 = !flag13;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X8_v60+108]");
						bool flag14 = (nint)0 == 0;
						num4 = unchecked((nint)null);
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj30 = 0;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v107+E4]");
							bool flag15 = (nint)0 == 0;
							object obj32 = !flag15;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE70]");
							object message = 0;
							UnityEngine.Debug.LogWarning(message);
							obj13 = obj6;
							num4 = unchecked((nint)null);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+E4]");
						bool flag16 = (nint)0 == 0;
						object obj33 = !flag16;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v94+A0]");
						object obj34 = 0;
						_ = 1;
						num6 = Time.realtimeSinceStartup;
						object obj35 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v96+A0]");
						object obj36 = 0;
						_003C_003Ec__DisplayClass136_0 obj37 = obj5._003C_003E8__1;
						if (obj5._003C_003E8__1 == null)
						{
							goto IL_0ac3;
						}
						obj37.res = (Outcome)0;
						_ = 0;
						_ = 0;
						obj5._003C_003E1__state = -3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v96+A0]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X9_v42+48]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X9_v42+48]");
						bool flag17 = (nint)0 == 0;
						obj40 = obj5;
						if (flag17)
						{
							goto IL_0dfa;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v96+E4]");
						bool flag18 = (nint)0 == 0;
						object obj41 = !flag18;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj42 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v70+A0]");
							obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X9_v42+48]");
							obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X9_v42+48]");
							if ((nint)0 == 0)
							{
								goto IL_0aed;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X8_v68+28]");
						action2 = (Action<Outcome>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1023 @ X8_v68+18] (should have been resolved before IL gen)");
						object obj43 = obj5 + 24;
						IntPtr intPtr = default;
						obj43 = (nint)intPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj5._003C_003E1__state = 1;
						num4 = intPtr;
						flag2 = true;
					}
					goto IL_0b62;
				}
				_003C_003E1__state = -3;
				obj40 = this;
				goto IL_0dfa;
			}
			_003C_003E1__state = -3;
			_003C_003Em__Finally1();
			_003C_003Ec__DisplayClass136_0 obj44 = obj5._003C_003E8__1;
			if (obj5._003C_003E8__1 != null)
			{
				if (obj44.res != (Outcome)(object)0)
				{
					bool flag19 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj45 = 0;
					object obj46 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v56+E4]");
					bool flag20 = (nint)0 == 0;
					object obj47 = !flag20;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v16 (ShiftAuth+<>c__DisplayClass136_0)+18]");
					bool flag21 = TicketRefusal((string)0);
					num4 = unchecked((nint)null);
					bool flag19 = flag21;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj48 = 0;
				object obj49 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v41+E4]");
				bool flag22 = (nint)0 == 0;
				object obj50 = !flag22;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj49 = obj48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v41+A0]");
				object obj51 = 0;
				_003C_003Ec__DisplayClass136_0 obj52 = obj5._003C_003E8__1;
				if (obj5._003C_003E8__1 != null)
				{
					float num6;
					if (obj52.res != (Outcome)(object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v41+E4]");
						bool flag23 = (nint)0 == 0;
						object obj53 = !flag23;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj54 = obj48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v34+A0]");
							obj51 = 0;
						}
						_ = 0;
						float num10 = 0f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v41+E4]");
						int num11;
						_003CAuthenticate_003Ed__136 obj55;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v24+10C]");
							num11 = (int)((nint)0 + (nint)1);
							obj55 = obj5;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj56 = obj48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v31+A0]");
							obj51 = 0;
							obj52 = obj5._003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v24+10C]");
							num11 = (int)((nint)0 + (nint)1);
							bool flag24 = obj5._003C_003E8__1 == null;
							obj55 = obj5;
							num4 = num11;
							if (flag24)
							{
								goto IL_0adf;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X10_v19 (ShiftAuth+<>c__DisplayClass136_0)+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X10_v19 (ShiftAuth+<>c__DisplayClass136_0)+20]");
						int num12 = WaitFor((FailKind)0, num11);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
						object obj58 = obj57;
						if (1133903872 < num12)
						{
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X0_v48+E4]");
						bool flag25 = (nint)0 == 0;
						object obj59 = !flag25;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						object obj60 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v29+A0]");
						obj51 = 0;
						float num10 = 1.1339039E+09f + (float)obj55._003Cnow_003E5__2;
						int num9 = num12;
						action2 = null;
						num6 = 1.1339039E+09f;
						num4 = num11;
					}
					_003C_003Ec__DisplayClass136_0 obj61 = obj5._003C_003E8__1;
					if (obj5._003C_003E8__1 == null)
					{
						goto IL_0a99;
					}
					Action<Outcome> action4 = obj5.done;
					if (obj5.done == null)
					{
						goto IL_0aa7;
					}
					num6 = (float)obj61.res;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v23 (System.Action`1<ShiftAuth+Outcome>)+28]");
					action2 = (Action<Outcome>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X8_v23 (System.Action`1<ShiftAuth+Outcome>)+18] (should have been resolved before IL gen)");
					num4 = (nint)(&num7);
					goto IL_0c71;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0a99;
			IL_0adf:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0aed;
			IL_0a99:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0aa7;
			IL_0ad1:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0adf;
			IL_0eb2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0440");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result = default;
			return result;
			IL_0ac3:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0ad1;
			IL_0b62:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0554");
			OutOfMemoryException ex7 = new OutOfMemoryException();
			OutOfMemoryException ex8 = ex7;
			goto IL_0eb2;
			IL_0dfa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE60]");
			object obj63 = 0;
			Action<Outcome> action5 = default;
			action5._002Ector((object)obj40._003C_003E8__1, (IntPtr)obj63);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj64 = 0;
			object obj65 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v64+E4]");
			bool flag26 = (nint)0 == 0;
			object obj66 = !flag26;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerator enumerator = AuthenticateOnce(obj40.metaUserId, obj40.displayName, action5);
			object obj67 = obj5 + 24;
			obj67 = enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5._003C_003E1__state = 2;
			action2 = action5;
			num4 = (nint)enumerator;
			flag2 = true;
			goto IL_0b62;
			IL_0c71:
			flag2 = false;
			goto IL_0b62;
			IL_0aa7:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_0ab5;
			IL_0aed:
			NullReferenceException ex10 = new NullReferenceException();
			bool flag27 = num4 != 1;
			ex8 = (OutOfMemoryException)(object)ex10;
			if (!flag27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj68 = default;
				bool flag28 = obj68 == null;
				flag2 = false;
				if (flag28)
				{
					return flag2;
				}
				goto IL_0b62;
			}
			goto IL_0eb2;
			IL_0ab5:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_0ac3;
		}

		private void _003C_003Em__Finally1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0043: Expected I4, but got I8
			//IL_0065: Expected Obj, but got I4
			//IL_0083: Expected Obj, but got I
			//IL_00aa: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			_003C_003E1__state = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
			object obj4 = 0;
			_ = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+A0]");
			object obj6 = 0;
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

	private sealed class _003CAuthenticateOnce_003Ed__138 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Outcome> done;

		public string metaUserId;

		public string displayName;

		private _003C_003Ec__DisplayClass138_0 _003C_003E8__1;

		private float _003Ct_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CAuthenticateOnce_003Ed__138(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_11a6: Expected Obj, but got I
			//IL_11b5: Expected I4, but got I8
			//IL_11e9: Expected Obj, but got I4
			//IL_1216: Expected Obj, but got I
			//IL_121f: Expected Obj, but got I4
			//IL_0e26: Expected I4, but got I8
			//IL_0e40: Expected Obj, but got I4
			//IL_0f29: Expected I4, but got I8
			//IL_0f43: Expected Obj, but got I4
			//IL_2f37: Expected Obj, but got I
			//IL_0c97: Expected Obj, but got I
			//IL_0ca6: Expected I4, but got I8
			//IL_34f0: Expected I, but got Obj
			//IL_0362: Expected I4, but got I8
			//IL_037c: Expected Obj, but got I4
			//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f61: Expected Obj, but got Unknown
			//IL_0f6a: Expected Obj, but got I4
			//IL_0f8a: Expected I, but got Obj
			//IL_0f93: Expected Obj, but got I4
			//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc9: Expected Obj, but got Unknown
			//IL_0ceb: Expected Obj, but got I
			//IL_0d15: Expected Obj, but got I4
			//IL_126c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1271: Expected Obj, but got Unknown
			//IL_127a: Expected Obj, but got I4
			//IL_129a: Expected I, but got Obj
			//IL_018b: Expected I4, but got I8
			//IL_01b8: Expected Obj, but got I4
			//IL_0220: Expected I4, but got I8
			//IL_023a: Expected Obj, but got I4
			//IL_1234: Expected Obj, but got I
			//IL_1244: Expected Obj, but got I
			//IL_1254: Expected Obj, but got I
			//IL_0e8d: Expected Obj, but got I
			//IL_0ece: Expected Obj, but got I4
			//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb1: Expected Obj, but got Unknown
			//IL_0fba: Expected Obj, but got I4
			//IL_0fda: Expected I, but got Obj
			//IL_0fe3: Expected Obj, but got I4
			//IL_0dd3: Expected Obj, but got I4
			//IL_007e: Expected Obj, but got I
			//IL_008d: Expected I4, but got I8
			//IL_00b7: Expected Obj, but got I4
			//IL_1875: Expected Obj, but got I4
			//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b8: Expected Obj, but got Unknown
			//IL_12c1: Expected Obj, but got I4
			//IL_12eb: Expected I, but got Obj
			//IL_1a4b: Expected I, but got Obj
			//IL_0e00: Expected Obj, but got I
			//IL_0d82: Expected Obj, but got I4
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_03c9: Expected Obj, but got I
			//IL_03f3: Expected Obj, but got I4
			//IL_141e: Expected Obj, but got I4
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1001: Expected Obj, but got Unknown
			//IL_100a: Expected Obj, but got I4
			//IL_1024: Expected Obj, but got I
			//IL_15d1: Expected Obj, but got I
			//IL_2f02: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I4
			//IL_1893: Expected Obj, but got I
			//IL_18c9: Expected I, but got Obj
			//IL_18d2: Expected Obj, but got I4
			//IL_2e52: Expected Obj, but got I
			//IL_2e91: Expected I, but got Obj
			//IL_1329: Expected Obj, but got I
			//IL_1a71: Expected Obj, but got I
			//IL_1a81: Expected Obj, but got I
			//IL_1a91: Expected Obj, but got I
			//IL_1050: Expected I, but got Obj
			//IL_15fd: Expected I, but got Obj
			//IL_0287: Expected Obj, but got I
			//IL_02c8: Expected Obj, but got I4
			//IL_24a0: Expected Obj, but got I4
			//IL_1980: Expected Obj, but got I
			//IL_1990: Expected Obj, but got I
			//IL_1352: Expected Obj, but got I
			//IL_135a: Expected I, but got Obj
			//IL_136d: Expected I, but got Obj
			//IL_1385: Expected Obj, but got I4
			//IL_1538: Expected Obj, but got I
			//IL_1550: Expected Obj, but got I
			//IL_157a: Expected Obj, but got I4
			//IL_18f0: Expected Obj, but got I
			//IL_18f8: Expected I, but got Obj
			//IL_191a: Expected Obj, but got I4
			//IL_0446: Expected I, but got Obj
			//IL_2f5b: Expected Obj, but got I
			//IL_2f6c: Expected Obj, but got I
			//IL_14bb: Expected Obj, but got I
			//IL_14e5: Expected Obj, but got I4
			//IL_1076: Expected Obj, but got I
			//IL_107f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1084: Expected Obj, but got Unknown
			//IL_1623: Expected Obj, but got I
			//IL_162c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1631: Expected Obj, but got Unknown
			//IL_1653: Expected Obj, but got I
			//IL_165c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1661: Expected Obj, but got Unknown
			//IL_3070: Expected Obj, but got I4
			//IL_1944: Expected I, but got Obj
			//IL_1954: Expected Obj, but got I
			//IL_196b: Expected I, but got Obj
			//IL_13ad: Expected Obj, but got I
			//IL_13b5: Expected I, but got Obj
			//IL_13cf: Expected Obj, but got I4
			//IL_13d7: Expected I, but got Obj
			//IL_1aae: Expected Obj, but got I
			//IL_1456: Unknown result type (might be due to invalid IL or missing references)
			//IL_145b: Expected Obj, but got Unknown
			//IL_1464: Expected Obj, but got I4
			//IL_1477: Expected Obj, but got I4
			//IL_10b8: Expected Obj, but got I
			//IL_10d2: Expected Obj, but got I
			//IL_10e5: Expected I, but got Obj
			//IL_1688: Expected Obj, but got I
			//IL_16b2: Expected Obj, but got I4
			//IL_2b0f: Expected Obj, but got I4
			//IL_2517: Expected Obj, but got I4
			//IL_0476: Expected I, but got Obj
			//IL_048c: Expected Obj, but got I
			//IL_13f8: Expected F4, but got I4
			//IL_15bc: Expected I, but got Obj
			//IL_2571: Expected I, but got Obj
			//IL_10fa: Expected Obj, but got I
			//IL_1124: Expected Obj, but got I4
			//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16e6: Expected Obj, but got Unknown
			//IL_3514: Expected Obj, but got I
			//IL_353d: Expected Obj, but got I
			//IL_355b: Expected Obj, but got I
			//IL_2aa3: Expected Obj, but got I4
			//IL_2544: Expected Obj, but got I
			//IL_1af8: Expected Obj, but got I4
			//IL_1151: Expected Obj, but got I
			//IL_116c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1171: Expected Obj, but got Unknown
			//IL_170d: Expected Obj, but got I
			//IL_1737: Expected Obj, but got I4
			//IL_2b52: Expected Obj, but got I
			//IL_2b7c: Expected Obj, but got I
			//IL_2ad0: Expected Obj, but got I
			//IL_2ae0: Expected Obj, but got I
			//IL_2c26: Expected I, but got Obj
			//IL_2c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c46: Expected Obj, but got Unknown
			//IL_258f: Expected Obj, but got I
			//IL_259f: Expected Obj, but got I
			//IL_1191: Expected Obj, but got I4
			//IL_2fbc: Expected Obj, but got I
			//IL_2fd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fda: Expected Obj, but got Unknown
			//IL_2fea: Expected Obj, but got I
			//IL_2b96: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b9b: Expected Obj, but got Unknown
			//IL_2d8f: Expected Obj, but got I4
			//IL_1b16: Expected Obj, but got I
			//IL_1b27: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b2c: Expected Obj, but got Unknown
			//IL_1b58: Expected Obj, but got I8
			//IL_1f9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa3: Expected Obj, but got Unknown
			//IL_1fac: Expected Obj, but got I4
			//IL_1fc6: Expected Obj, but got I
			//IL_052a: Expected I, but got Obj
			//IL_0540: Expected Obj, but got I
			//IL_2c73: Expected I, but got Obj
			//IL_1ff2: Expected I, but got Obj
			//IL_32b7: Expected Obj, but got I
			//IL_32e1: Expected Obj, but got I4
			//IL_1765: Unknown result type (might be due to invalid IL or missing references)
			//IL_176a: Expected Obj, but got Unknown
			//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8d: Expected Obj, but got Unknown
			//IL_1bc3: Expected Obj, but got I4
			//IL_1bd9: Expected Obj, but got I
			//IL_1bf9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfe: Expected Obj, but got Unknown
			//IL_260b: Expected Obj, but got I
			//IL_1798: Unknown result type (might be due to invalid IL or missing references)
			//IL_179d: Expected Obj, but got Unknown
			//IL_2caa: Expected Obj, but got I
			//IL_2010: Expected Obj, but got I
			//IL_2019: Unknown result type (might be due to invalid IL or missing references)
			//IL_201e: Expected Obj, but got Unknown
			//IL_205a: Expected Obj, but got I4
			//IL_2640: Expected I, but got Obj
			//IL_17d1: Expected Obj, but got I
			//IL_17eb: Expected Obj, but got I
			//IL_17fe: Expected I, but got Obj
			//IL_1c1c: Expected Obj, but got I
			//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c32: Expected Obj, but got Unknown
			//IL_1c6e: Expected Obj, but got I4
			//IL_3148: Expected Obj, but got I
			//IL_3151: Unknown result type (might be due to invalid IL or missing references)
			//IL_3156: Expected Obj, but got Unknown
			//IL_3166: Expected Obj, but got I
			//IL_3179: Unknown result type (might be due to invalid IL or missing references)
			//IL_317e: Expected Obj, but got Unknown
			//IL_1813: Expected Obj, but got I
			//IL_182e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1833: Expected Obj, but got Unknown
			//IL_05de: Expected I, but got Obj
			//IL_05f4: Expected Obj, but got I
			//IL_2cf8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cfd: Expected Obj, but got Unknown
			//IL_2d05: Expected Obj, but got I
			//IL_1c9f: Expected Obj, but got I8
			//IL_208f: Expected Obj, but got I
			//IL_2666: Expected Obj, but got I
			//IL_266f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2674: Expected Obj, but got Unknown
			//IL_26b0: Expected Obj, but got I4
			//IL_1853: Expected Obj, but got I4
			//IL_32ff: Expected Obj, but got I
			//IL_3308: Unknown result type (might be due to invalid IL or missing references)
			//IL_330d: Expected Obj, but got Unknown
			//IL_331d: Expected Obj, but got I
			//IL_3330: Unknown result type (might be due to invalid IL or missing references)
			//IL_3335: Expected Obj, but got Unknown
			//IL_3359: Expected Obj, but got I
			//IL_3362: Unknown result type (might be due to invalid IL or missing references)
			//IL_3367: Expected Obj, but got Unknown
			//IL_1cd4: Expected Obj, but got I
			//IL_1ce4: Expected Obj, but got I
			//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf2: Expected Obj, but got Unknown
			//IL_1d02: Expected Obj, but got I
			//IL_1d2e: Expected Obj, but got I4
			//IL_1d44: Expected Obj, but got I
			//IL_1d64: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d69: Expected Obj, but got Unknown
			//IL_31af: Unknown result type (might be due to invalid IL or missing references)
			//IL_31b4: Expected Obj, but got Unknown
			//IL_31d6: Expected Obj, but got I
			//IL_31df: Unknown result type (might be due to invalid IL or missing references)
			//IL_31e4: Expected Obj, but got Unknown
			//IL_3220: Expected Obj, but got I4
			//IL_26e5: Expected Obj, but got I
			//IL_26ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f3: Expected Obj, but got Unknown
			//IL_2715: Expected Obj, but got I
			//IL_271e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2723: Expected Obj, but got Unknown
			//IL_214e: Expected Obj, but got I
			//IL_2159: Expected Obj, but got I4
			//IL_20e1: Expected Obj, but got I
			//IL_274a: Expected Obj, but got I
			//IL_2774: Expected Obj, but got I4
			//IL_0692: Expected I, but got Obj
			//IL_06a8: Expected Obj, but got I
			//IL_1d7f: Expected I, but got Obj
			//IL_1d88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d8d: Expected Obj, but got Unknown
			//IL_2185: Expected Obj, but got I
			//IL_27a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_27a8: Expected Obj, but got Unknown
			//IL_3237: Unknown result type (might be due to invalid IL or missing references)
			//IL_323c: Expected Obj, but got Unknown
			//IL_325e: Expected Obj, but got I
			//IL_3288: Expected Obj, but got I4
			//IL_27eb: Expected I, but got Obj
			//IL_1de4: Expected Obj, but got I4
			//IL_1df4: Expected Obj, but got I4
			//IL_1e14: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e19: Expected Obj, but got Unknown
			//IL_21ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_21b0: Expected Obj, but got Unknown
			//IL_21ea: Expected I, but got Obj
			//IL_280a: Unknown result type (might be due to invalid IL or missing references)
			//IL_280f: Expected Obj, but got Unknown
			//IL_2836: Expected Obj, but got I
			//IL_283e: Expected I, but got Obj
			//IL_2847: Unknown result type (might be due to invalid IL or missing references)
			//IL_284c: Expected Obj, but got Unknown
			//IL_074f: Expected Obj, but got I
			//IL_0778: Expected I, but got Obj
			//IL_078e: Expected Obj, but got I
			//IL_1e38: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e3d: Expected Obj, but got Unknown
			//IL_1e93: Expected I, but got Obj
			//IL_2205: Expected I, but got Obj
			//IL_220e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2213: Expected Obj, but got Unknown
			//IL_28ad: Expected Obj, but got I
			//IL_28bd: Expected Obj, but got I
			//IL_225c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2261: Expected Obj, but got Unknown
			//IL_22a2: Expected Obj, but got I4
			//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_22d6: Expected Obj, but got Unknown
			//IL_3387: Unknown result type (might be due to invalid IL or missing references)
			//IL_338c: Expected Obj, but got Unknown
			//IL_33a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_33ac: Expected Obj, but got Unknown
			//IL_082e: Expected I, but got Obj
			//IL_0844: Expected Obj, but got I
			//IL_30b0: Expected Obj, but got I4
			//IL_22ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_2304: Expected Obj, but got Unknown
			//IL_2911: Expected Obj, but got I
			//IL_293b: Expected Obj, but got I4
			//IL_1f18: Expected Obj, but got I4
			//IL_2324: Unknown result type (might be due to invalid IL or missing references)
			//IL_2329: Expected Obj, but got Unknown
			//IL_2344: Unknown result type (might be due to invalid IL or missing references)
			//IL_2349: Expected Obj, but got Unknown
			//IL_33e0: Expected Obj, but got I
			//IL_33f0: Expected Obj, but got I
			//IL_3412: Expected Obj, but got I4
			//IL_30ff: Expected Obj, but got I4
			//IL_30d7: Expected Obj, but got I
			//IL_30e7: Expected Obj, but got I
			//IL_2369: Unknown result type (might be due to invalid IL or missing references)
			//IL_236e: Expected Obj, but got Unknown
			//IL_2389: Unknown result type (might be due to invalid IL or missing references)
			//IL_238e: Expected Obj, but got Unknown
			//IL_29e1: Expected Obj, but got I4
			//IL_23bd: Expected Obj, but got I
			//IL_23c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_23cb: Expected Obj, but got Unknown
			//IL_23db: Expected Obj, but got I
			//IL_2a19: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a1e: Expected Obj, but got Unknown
			//IL_2982: Expected Obj, but got I4
			//IL_08e2: Expected I, but got Obj
			//IL_08f8: Expected Obj, but got I
			//IL_3118: Expected Obj, but got I4
			//IL_2407: Expected Obj, but got I
			//IL_2421: Expected Obj, but got I
			//IL_2434: Expected I, but got Obj
			//IL_2a3e: Expected Obj, but got I4
			//IL_343e: Expected Obj, but got I
			//IL_3458: Expected Obj, but got I
			//IL_3460: Expected I, but got Obj
			//IL_3471: Expected I, but got Obj
			//IL_348f: Expected Obj, but got I
			//IL_34aa: Expected Obj, but got I4
			//IL_2454: Unknown result type (might be due to invalid IL or missing references)
			//IL_2459: Expected Obj, but got Unknown
			//IL_29b2: Expected Obj, but got I
			//IL_312b: Expected I, but got Obj
			//IL_2479: Expected Obj, but got I4
			//IL_099f: Expected Obj, but got I
			//IL_09d4: Expected Obj, but got I
			//IL_09dd: Expected Obj, but got I4
			//IL_09f9: Expected Obj, but got I
			//IL_0a2b: Expected Obj, but got I
			//IL_0a3c: Expected Obj, but got I
			//IL_0a5a: Expected Obj, but got I4
			//IL_0a63: Expected Obj, but got I4
			//IL_2ed6: Expected Obj, but got I4
			//IL_3582: Expected Obj, but got I
			//IL_359b: Unknown result type (might be due to invalid IL or missing references)
			//IL_35a0: Expected Obj, but got Unknown
			//IL_35a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_35ae: Expected Obj, but got Unknown
			//IL_35bc: Expected Obj, but got I4
			//IL_35f1: Expected Obj, but got I
			//IL_35fa: Expected Obj, but got I4
			//IL_0a86: Expected Obj, but got I
			//IL_0ab0: Expected Obj, but got I4
			//IL_0af1: Expected Obj, but got I4
			//IL_0af9: Expected Obj, but got I8
			//IL_0b82: Expected Obj, but got I4
			//IL_0bbc: Expected Obj, but got I
			//IL_0bf2: Expected I, but got Obj
			//IL_0c02: Expected Obj, but got I
			//IL_0c25: Expected Obj, but got I
			//IL_0c3a: Expected I, but got Obj
			//IL_0c4a: Expected Obj, but got I
			bool result;
			string text;
			Action<Outcome> action;
			string text2;
			Action<Outcome> action2;
			string category;
			string text3;
			Action<Outcome> action5;
			object error;
			object obj54;
			float num3;
			Request<string> request2;
			object obj80;
			object obj2;
			nint num2;
			nint num;
			if (_003C_003E1__state <= 3)
			{
				if (_003C_003E1__state > 1)
				{
					if (_003C_003E1__state != 2)
					{
						bool flag = _003C_003E1__state != 3;
						result = false;
						if (flag)
						{
							goto IL_2dfb;
						}
						_003C_003Ec__DisplayClass138_0 obj = _003C_003E8__1;
						_003C_003E1__state = -1;
						bool flag2 = _003C_003E8__1 == null;
						obj2 = 109895680;
						if (!flag2)
						{
							text = obj.error;
							if (obj.error != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
								object obj3 = 0;
								action = done;
								text2 = obj.category;
								object obj4 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X0_v30+E4]");
								bool flag3 = (nint)0 == 0;
								object obj5 = !flag3;
								if (obj5 == null)
								{
									action2 = done;
									category = obj.category;
									text3 = obj.error;
									goto IL_19f3;
								}
								goto IL_1a1a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE88]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj7 = default;
							obj7._002Ector();
							bool flag4 = obj7 == null;
							num = unchecked((nint)null);
							obj2 = obj7;
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
								object obj8 = 0;
								object obj9 = obj7 + 16;
								obj9 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEE8]");
								object obj10 = 0;
								object obj11 = obj7 + 24;
								obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
								object obj12 = 0;
								object obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v384+E4]");
								bool flag5 = (nint)0 == 0;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string version = UnityEngine.Application.version;
								object obj15 = obj7 + 32;
								obj15 = version;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
								object obj16 = 0;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ X0_v392+E4]");
								bool flag6 = (nint)0 == 0;
								object obj18 = !flag6;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj17 = obj16;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ X0_v392+A0]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v212+E8]");
								num = 0;
								object obj20 = obj7 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v212+E8]");
								obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_003C_003Ec__DisplayClass138_0 obj21 = _003C_003E8__1;
								bool flag7 = _003C_003E8__1 == null;
								obj2 = obj7;
								if (!flag7)
								{
									object obj22 = obj7 + 48;
									obj22 = obj21.nonce;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string devKey = DevKey;
									object obj23 = obj7 + 56;
									obj23 = devKey;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string body = JsonUtility.ToJson(obj7);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
									object obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEB8]");
									object obj25 = 0;
									Action<bool, System.__Canon> action3 = default;
									action3._002Ector((object)_003C_003E8__1, (IntPtr)obj25);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF00]");
									object path = 0;
									IEnumerator enumerator = PlainPost((string)path, body, (Action<bool, string>)action3);
									object obj26 = this + 24;
									obj26 = enumerator;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj27 = 4;
									goto IL_2e00;
								}
							}
						}
					}
					else
					{
						_003C_003E1__state = -1;
						bool flag8 = _003C_003E8__1 == null;
						obj2 = 109895680;
						if (!flag8)
						{
							object obj28 = _003C_003E8__1 + 32;
							obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag9 = _003C_003E8__1 == null;
							num = unchecked((nint)null);
							obj2 = 109895680;
							if (!flag9)
							{
								object obj29 = _003C_003E8__1 + 16;
								obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag10 = _003C_003E8__1 == null;
								num = unchecked((nint)null);
								obj2 = 109895680;
								if (!flag10)
								{
									object obj30 = _003C_003E8__1 + 24;
									obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE98]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									object obj32 = default;
									obj32._002Ector();
									bool flag11 = obj32 == null;
									num = unchecked((nint)null);
									obj2 = obj32;
									if (!flag11)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
										object obj33 = 0;
										object obj34 = obj32 + 16;
										obj34 = obj33;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string body2 = JsonUtility.ToJson(obj32);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
										object obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEB0]");
										object obj36 = 0;
										Action<bool, System.__Canon> action4 = default;
										action4._002Ector((object)_003C_003E8__1, (IntPtr)obj36);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
										object obj37 = 0;
										object obj38 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1443 @ X0_v369+E4]");
										bool flag12 = (nint)0 == 0;
										object obj39 = !flag12;
										if (obj39 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEE8]");
										object path2 = 0;
										IEnumerator enumerator2 = PlainPost((string)path2, body2, (Action<bool, string>)action4);
										object obj26 = this + 24;
										obj26 = enumerator2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj27 = 3;
										goto IL_2e00;
									}
								}
							}
						}
					}
					goto IL_2d63;
				}
				if (_003C_003E1__state == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEED0]");
					object obj40 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj41 = default;
					obj41._002Ector();
					object obj42 = this + 56;
					obj42 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj43 = 0;
					object obj44 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ X0_v421+E4]");
					bool flag13 = (nint)0 == 0;
					object obj45 = !flag13;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text4 = Server();
					object obj46 = obj43;
					if (text4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v429+E4]");
						bool flag14 = (nint)0 == 0;
						object obj47 = !flag14;
						if (obj47 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj46 = obj43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v429+A0]");
						object obj48 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v231+B0]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v429+E4]");
							bool flag15 = (nint)0 == 0;
							object obj49 = !flag15;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (Tampered())
							{
								object obj50 = obj43;
								action5 = done;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X0_v456+E4]");
								bool flag16 = (nint)0 == 0;
								object obj51 = !flag16;
								if (obj51 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE968]");
								error = 0;
								obj2 = obj41;
								goto IL_2f27;
							}
							bool flag17 = string.IsNullOrEmpty(metaUserId);
							object obj52 = obj43;
							if (flag17)
							{
								action5 = done;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ X0_v436+E4]");
								bool flag18 = (nint)0 == 0;
								object obj53 = !flag18;
								if (obj53 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0C8]");
								error = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA28]");
								obj54 = 0;
								obj2 = obj41;
								goto IL_34bf;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ X0_v436+E4]");
							bool flag19 = (nint)0 == 0;
							object obj55 = !flag19;
							if (obj55 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj52 = obj43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ X0_v436+A0]");
							object obj56 = (nint)0 + (nint)240;
							obj56 = displayName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Init();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj57 = 0;
							object obj58 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X9_v64+A0]");
							object obj59 = (nint)0 + (nint)104;
							obj59 = obj57;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj60 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X8_v237+A0]");
							object obj61 = (nint)0 + (nint)88;
							obj61 = obj57;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj62 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X8_v238+A0]");
							object obj63 = 0;
							_ = 0;
							IEnumerator enumerator3 = WaitForBuildHash();
							object obj64 = this + 24;
							obj64 = enumerator3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 1;
							result = true;
							goto IL_2dfb;
						}
					}
					action5 = done;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X0_v429+E4]");
					bool flag20 = (nint)0 == 0;
					object obj65 = !flag20;
					if (obj65 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE970]");
					error = 0;
					obj2 = obj41;
					goto IL_2f27;
				}
				bool flag21 = _003C_003E1__state != 1;
				result = false;
				if (!flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj66 = 0;
					_003C_003E1__state = -1;
					object obj67 = obj66;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v463+E4]");
					bool flag22 = (nint)0 == 0;
					object obj68 = !flag22;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					IEnumerator enumerator4 = EnsureHwKey(metaUserId);
					object obj26 = this + 24;
					obj26 = enumerator4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj27 = 2;
					goto IL_2e00;
				}
			}
			else if (_003C_003E1__state <= 5)
			{
				if (_003C_003E1__state == 4)
				{
					_003C_003Ec__DisplayClass138_0 obj69 = _003C_003E8__1;
					_003C_003E1__state = -1;
					bool flag23 = _003C_003E8__1 == null;
					obj2 = 109895680;
					if (!flag23)
					{
						obj2 = obj69.error;
						if (obj69.error != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj70 = 0;
							action = done;
							text2 = obj69.category;
							object obj71 = obj70;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v183+E4]");
							bool flag24 = (nint)0 == 0;
							object obj72 = !flag24;
							text = obj69.error;
							if (obj72 == null)
							{
								action2 = done;
								object obj4 = obj71;
								category = obj69.category;
								text3 = obj69.error;
								goto IL_19f3;
							}
							goto IL_1a1a;
						}
						object obj73 = _003C_003E8__1 + 40;
						obj73 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag25 = _003C_003E8__1 == null;
						num = unchecked((nint)null);
						if (!flag25)
						{
							object obj74 = _003C_003E8__1 + 48;
							obj74 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_003C_003Ec__DisplayClass138_0 obj75 = _003C_003E8__1;
							bool flag26 = _003C_003E8__1 == null;
							num = unchecked((nint)null);
							if (!flag26)
							{
								obj75.attested = false;
								Request<string> integrityToken = DeviceApplicationIntegrity.GetIntegrityToken(obj75.nonce);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE80]");
								object obj76 = 0;
								object obj77 = _003C_003E8__1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEC0]");
								object obj78 = 0;
								num2 = (nint)obj78;
								Callback val = default;
								val._002Ector((object)_003C_003E8__1, (IntPtr)obj78);
								bool flag27 = integrityToken == null;
								object obj79 = 0;
								obj80 = _003C_003E8__1;
								if (!flag27)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEA0]");
									object obj81 = 0;
									num2 = (nint)obj81;
									Request<System.__Canon> request = ((Request<System.__Canon>)(object)integrityToken).OnComplete(val);
									obj79 = 0;
									num = (nint)val;
									request2 = integrityToken;
									goto IL_13e4;
								}
								goto IL_2bcf;
							}
						}
					}
					goto IL_2d63;
				}
				bool flag28 = _003C_003E1__state != 5;
				result = false;
				if (!flag28)
				{
					_003C_003E1__state = -1;
					float unscaledDeltaTime = Time.unscaledDeltaTime;
					num3 = (_003Ct_003E5__2 += unscaledDeltaTime);
					obj2 = 109895680;
					goto IL_2e13;
				}
			}
			else
			{
				if (_003C_003E1__state == 6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj82 = 0;
					_003C_003E1__state = -1;
					action5 = done;
					object obj83 = obj82;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v32+E4]");
					bool flag29 = (nint)0 == 0;
					object obj84 = !flag29;
					if (obj84 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEF0]");
					error = 0;
					obj2 = 109895680;
					goto IL_2f27;
				}
				bool flag30 = _003C_003E1__state != 7;
				result = false;
				if (!flag30)
				{
					_003C_003Ec__DisplayClass138_0 obj85 = _003C_003E8__1;
					_003C_003E1__state = -1;
					bool flag31 = _003C_003E8__1 == null;
					obj2 = 109895680;
					if (!flag31)
					{
						LoginReply login = obj85.login;
						if (obj85.login != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj86 = 0;
							object obj87 = obj86;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v44+E4]");
							bool flag32 = (nint)0 == 0;
							object obj88 = !flag32;
							if (obj88 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj87 = obj86;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v44+A0]");
							object obj89 = (nint)0 + (nint)192;
							obj89 = login.token;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_003C_003Ec__DisplayClass138_0 obj90 = _003C_003E8__1;
							bool flag33 = _003C_003E8__1 == null;
							num = (nint)login.token;
							obj2 = login.token;
							if (!flag33)
							{
								LoginReply login2 = obj90.login;
								bool flag34 = obj90.login == null;
								num = (nint)login.token;
								obj2 = login.token;
								if (!flag34)
								{
									object obj91 = obj86;
									num = (nint)login2.sessionSecret;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X9_v22+A0]");
									object obj92 = (nint)0 + (nint)200;
									obj92 = login2.sessionSecret;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_003C_003Ec__DisplayClass138_0 obj93 = _003C_003E8__1;
									bool flag35 = _003C_003E8__1 == null;
									obj2 = login.token;
									if (!flag35)
									{
										LoginReply login3 = obj93.login;
										bool flag36 = obj93.login == null;
										obj2 = login.token;
										if (!flag36)
										{
											object obj94 = obj86;
											num = (nint)login3.challenge;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X9_v23+A0]");
											object obj95 = (nint)0 + (nint)208;
											obj95 = login3.challenge;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											_003C_003Ec__DisplayClass138_0 obj96 = _003C_003E8__1;
											bool flag37 = _003C_003E8__1 == null;
											obj2 = login.token;
											if (!flag37)
											{
												LoginReply login4 = obj96.login;
												bool flag38 = obj96.login == null;
												obj2 = login.token;
												if (!flag38)
												{
													object obj97 = obj86;
													num = (nint)login4.sessionId;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v24+A0]");
													object obj98 = (nint)0 + (nint)32;
													obj98 = login4.sessionId;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													_003C_003Ec__DisplayClass138_0 obj99 = _003C_003E8__1;
													bool flag39 = _003C_003E8__1 == null;
													obj2 = login.token;
													if (!flag39)
													{
														LoginReply login5 = obj99.login;
														bool flag40 = obj99.login == null;
														obj2 = login.token;
														if (!flag40)
														{
															object obj100 = obj86;
															num = (nint)login5.playFabId;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X9_v25+A0]");
															object obj101 = (nint)0 + (nint)8;
															obj101 = login5.playFabId;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															_003C_003Ec__DisplayClass138_0 obj102 = _003C_003E8__1;
															bool flag41 = _003C_003E8__1 == null;
															obj2 = login.token;
															if (!flag41)
															{
																LoginReply login6 = obj102.login;
																bool flag42 = obj102.login == null;
																obj2 = login.token;
																if (!flag42)
																{
																	object obj103 = obj86;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X9_v26+A0]");
																	object obj104 = (nint)0 + (nint)16;
																	obj104 = login6.username;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	object obj105 = obj86;
																	num = (nint)metaUserId;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X8_v44+A0]");
																	object obj106 = (nint)0 + (nint)24;
																	obj106 = metaUserId;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	_003C_003Ec__DisplayClass138_0 obj107 = _003C_003E8__1;
																	bool flag43 = _003C_003E8__1 == null;
																	obj2 = login.token;
																	if (!flag43)
																	{
																		LoginReply login7 = obj107.login;
																		bool flag44 = obj107.login == null;
																		obj2 = login.token;
																		if (!flag44)
																		{
																			object obj108 = obj86;
																			num = (nint)login7.photonTicket;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X9_v27+A0]");
																			object obj109 = (nint)0 + (nint)40;
																			obj109 = login7.photonTicket;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			_003C_003Ec__DisplayClass138_0 obj110 = _003C_003E8__1;
																			bool flag45 = _003C_003E8__1 == null;
																			obj2 = login.token;
																			if (!flag45)
																			{
																				LoginReply login8 = obj110.login;
																				bool flag46 = obj110.login == null;
																				obj2 = login.token;
																				if (!flag46)
																				{
																					object obj111 = obj86;
																					num = (nint)login8.metaSig;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v28+A0]");
																					object obj112 = (nint)0 + (nint)48;
																					obj112 = login8.metaSig;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					_003C_003Ec__DisplayClass138_0 obj113 = _003C_003E8__1;
																					bool flag47 = _003C_003E8__1 == null;
																					obj2 = login.token;
																					if (!flag47)
																					{
																						LoginReply login9 = obj113.login;
																						bool flag48 = obj113.login == null;
																						obj2 = login.token;
																						if (!flag48)
																						{
																							object obj114 = obj86;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1798 @ X9_v29+A0]");
																							object obj115 = (nint)0 + (nint)56;
																							obj115 = login9.assetKey;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj116 = obj86;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1818 @ X8_v51+A0]");
																							object obj117 = (nint)0 + (nint)136;
																							obj117 = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1821 @ X0_v76+B4]");
																							object obj118 = (nint)0 + (nint)1;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj119 = obj86;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ X8_v54+A0]");
																							object obj120 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X8_v55+28]");
																							bool flag49 = string.IsNullOrEmpty((string)0);
																							bool flag50 = !flag49;
																							object obj121 = !flag50;
																							object obj122 = 0;
																							obj2 = null;
																							if (obj121 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
																								object obj123 = 0;
																								object obj124 = obj123;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1899 @ X0_v98+E4]");
																								bool flag51 = (nint)0 == 0;
																								object obj125 = !flag51;
																								if (obj125 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								}
																								DateTimeOffset utcNow = DateTimeOffset.UtcNow;
																								DateTimeOffset dateTimeOffset = default;
																								long num4 = dateTimeOffset.ToUnixTimeSeconds();
																								obj122 = 0;
																								obj2 = num4;
																							}
																							object obj126 = obj86;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X0_v82+E4]");
																							bool flag52 = (nint)0 == 0;
																							object obj127 = !flag52;
																							if (obj127 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								obj126 = obj86;
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X0_v82+A0]");
																							object obj128 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1931 @ X8_v58+20]");
																							num = 0;
																							object obj129 = obj128 + 372;
																							object obj130 = obj128 + 384;
																							obj129 = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1931 @ X8_v58+20]");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj131 = obj86;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v85+A0]");
																							object obj132 = 0;
																							obj132 = 1;
																							_003C_003Ec__DisplayClass138_0 obj133 = _003C_003E8__1;
																							if (_003C_003E8__1 != null)
																							{
																								LoginReply login10 = obj133.login;
																								if (obj133.login != null)
																								{
																									if (~(login10.hwReenroll ? 1u : 0u) == 0)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v85+E4]");
																										bool flag53 = (nint)0 == 0;
																										object obj134 = !flag53;
																										if (obj134 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																										}
																										ForgetHwKey();
																										object obj135 = obj86;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2024 @ X8_v66+A0]");
																										object obj136 = 0;
																										_ = 0;
																										IEnumerator enumerator5 = EnsureHwKey(metaUserId);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v67+120]");
																										bool flag54 = (nint)0 == 0;
																										num = unchecked((nint)null);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v67+120]");
																										obj2 = 0;
																										if (flag54)
																										{
																											goto IL_2d63;
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v67+120]");
																										Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(enumerator5);
																										num2 = 0;
																										num = (nint)enumerator5;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v67+120]");
																										obj2 = 0;
																									}
																									Action<Outcome> action6 = done;
																									if (done != null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X8_v64 (System.Action`1<ShiftAuth+Outcome>)+18] (should have been resolved before IL gen)");
																										goto IL_2ee4;
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
									}
								}
							}
						}
						else
						{
							bool flag55 = obj85.error == null;
							obj2 = 109895680;
							if (!flag55)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEE0]");
								object obj137 = 0;
								bool flag56 = obj85.error.Contains((string)obj137);
								bool flag57 = !flag56;
								num2 = 0;
								num = (nint)obj137;
								obj2 = 109895680;
								if (!flag57)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
									obj2 = 0;
									nint num5 = (nint)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v39 (Il2CppClass<System.Object>)+E4]");
									bool flag58 = (nint)0 == 0;
									object obj138 = !flag58;
									if (obj138 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									ForgetHwKey();
									nint num6 = (nint)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X8_v31 (Il2CppClass<System.Object>)+A0]");
									object obj139 = 0;
									_ = 0;
									num2 = 0;
									num = (nint)obj137;
								}
							}
							_003C_003Ec__DisplayClass138_0 obj140 = _003C_003E8__1;
							if (_003C_003E8__1 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
								object obj141 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF08]");
								object obj142 = 0;
								action2 = done;
								object obj4 = obj141;
								category = obj140.category;
								text3 = (string)((obj140.error != null) ? obj140.error : obj142);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X0_v30+E4]");
								bool flag59 = (nint)0 == 0;
								object obj143 = !flag59;
								action = action2;
								text2 = category;
								text = text3;
								if (obj143 == null)
								{
									goto IL_19f3;
								}
								goto IL_1a1a;
							}
						}
					}
					goto IL_2d63;
				}
			}
			goto IL_2dfb;
			IL_13e4:
			_003Ct_003E5__2 = 0f;
			num3 = 0f;
			obj2 = request2;
			goto IL_2e13;
			IL_2bcf:
			NullReferenceException ex = new NullReferenceException();
			bool flag60 = (nint)obj80 != 1;
			NullReferenceException ex2 = ex;
			if (!flag60)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj144 = default;
				nint num7 = (nint)obj144;
				num = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj146 = default;
				object obj145 = obj146 & 1;
				bool flag61 = obj145 == null;
				obj2 = obj144;
				if (!flag61)
				{
					nint num8 = (nint)obj144;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					bool flag62 = obj144 == null;
					obj2 = obj144;
					if (!flag62)
					{
						object obj147 = num8;
						obj2 = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v170+190]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v684 @ X8_v170+188] (should have been resolved before IL gen)");
						if (_003C_003E8__1 != null)
						{
							request2 = (Request<string>)(_003C_003E8__1 + 48);
							IntPtr intPtr = default;
							request2 = (Request<string>)(nint)intPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_003C_003Ec__DisplayClass138_0 obj148 = _003C_003E8__1;
							bool flag63 = _003C_003E8__1 == null;
							num = intPtr;
							obj2 = request2;
							if (!flag63)
							{
								obj148.attested = true;
								num = intPtr;
								goto IL_13e4;
							}
						}
					}
					goto IL_2d63;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj149 = obj2;
				obj80 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num2 = 0;
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_19f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			text2 = category;
			text = text3;
			goto IL_1a1a;
			IL_2ee4:
			result = false;
			goto IL_2dfb;
			IL_2e13:
			_003C_003Ec__DisplayClass138_0 obj150 = _003C_003E8__1;
			object obj201;
			string text7;
			string text8;
			object obj206;
			if (_003C_003E8__1 != null)
			{
				bool flag64 = (byte)(~(obj150.attested ? 1u : 0u)) != 0;
				object obj151 = !flag64;
				if (obj151 == null && (double)num3 < 30.0)
				{
					object obj26 = this + 24;
					obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj27 = 5;
					goto IL_2e00;
				}
				if (string.IsNullOrEmpty(obj150.attestation))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj152 = 0;
					object obj153 = obj152;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X0_v245+E4]");
					bool flag65 = (nint)0 == 0;
					object obj154 = !flag65;
					if (obj154 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!HasDevKey)
					{
						_003C_003Ec__DisplayClass138_0 obj155 = _003C_003E8__1;
						bool flag66 = _003C_003E8__1 == null;
						num = unchecked((nint)null);
						if (!flag66)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A0]");
							object obj156 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF18]");
							object obj157 = 0;
							string text5 = (string)((obj155.attestError != null) ? obj155.attestError : obj156);
							string message = (string)obj157 + text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj158 = 0;
							object obj159 = obj158;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X8_v135+E4]");
							bool flag67 = (nint)0 == 0;
							object obj160 = !flag67;
							if (obj160 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Debug.LogWarning(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE90]");
							object obj161 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj162 = default;
							obj162._002Ector();
							bool flag68 = obj162 == null;
							num2 = 0;
							num = unchecked((nint)null);
							obj2 = obj162;
							if (!flag68)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
								object obj163 = 0;
								object obj164 = obj162 + 16;
								obj164 = obj163;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj165 = obj152;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X0_v259+E4]");
								bool flag69 = (nint)0 == 0;
								object obj166 = !flag69;
								if (obj166 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj165 = obj152;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X0_v259+A0]");
								object obj167 = 0;
								object obj168 = obj162 + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ X8_v141+D8]");
								obj168 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj169 = obj162 + 32;
								obj169 = metaUserId;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF10]");
								object obj170 = 0;
								object obj171 = obj162 + 40;
								obj171 = obj170;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEE8]");
								object obj172 = 0;
								object obj173 = obj162 + 48;
								obj173 = obj172;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC190]");
								object obj174 = 0;
								object obj175 = obj162 + 56;
								obj175 = obj174;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
								object obj176 = 0;
								object obj177 = obj176;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1756 @ X0_v275+E4]");
								bool flag70 = (nint)0 == 0;
								object obj178 = !flag70;
								if (obj178 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string version2 = UnityEngine.Application.version;
								object obj179 = obj162 + 64;
								obj179 = version2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_003C_003Ec__DisplayClass138_0 obj180 = _003C_003E8__1;
								bool flag71 = _003C_003E8__1 == null;
								num2 = 0;
								num = (nint)version2;
								obj2 = obj162;
								if (!flag71)
								{
									object obj181 = obj162 + 72;
									obj181 = obj180.nonce;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									object obj182 = 0;
									num = (nint)obj182;
									object obj183 = obj162 + 80;
									obj183 = obj182;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_003C_003Ec__DisplayClass138_0 obj184 = _003C_003E8__1;
									bool flag72 = _003C_003E8__1 == null;
									num2 = 0;
									obj2 = obj162;
									if (!flag72)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE08]");
										object obj185 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF28]");
										object path3 = 0;
										string text6 = (string)((obj184.attestError != null) ? obj184.attestError : obj185);
										object obj186 = obj162 + 96;
										obj186 = text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj187 = obj162 + 88;
										obj187 = obj182;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string body3 = JsonUtility.ToJson(obj162);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDC8]");
										object obj188 = 0;
										object obj189 = obj188;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1988 @ X8_v155+E4]");
										bool flag73 = (nint)0 == 0;
										object obj190 = !flag73;
										if (obj190 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj189 = obj188;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1988 @ X8_v155+A0]");
										object obj191 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X9_v51+8]");
										Action<bool, string> action7 = (Action<bool, string>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X9_v51+8]");
										bool flag74 = (nint)0 == 0;
										object obj192 = !flag74;
										nint num9 = 0;
										Action<bool, System.__Canon> action8 = null;
										if (obj192 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1988 @ X8_v155+E4]");
											bool flag75 = (nint)0 == 0;
											object obj193 = !flag75;
											if (obj193 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												object obj194 = obj188;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2031 @ X8_v165+A0]");
												obj191 = 0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
											object obj195 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEA8]");
											object obj196 = 0;
											num9 = (nint)obj196;
											Action<bool, System.__Canon> action9 = default;
											action9._002Ector(obj191, (IntPtr)obj196);
											object obj197 = obj188;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2018 @ X8_v164+A0]");
											object obj198 = (nint)0 + (nint)8;
											obj198 = action9;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj79 = 0;
											action7 = (Action<bool, string>)action9;
											action8 = action9;
										}
										object obj199 = obj152;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2019 @ X0_v298+E4]");
										bool flag76 = (nint)0 == 0;
										object obj200 = !flag76;
										if (obj200 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										IEnumerator enumerator6 = PlainPost((string)path3, body3, action7);
										object obj26 = this + 24;
										obj26 = enumerator6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj27 = 6;
										goto IL_2e00;
									}
								}
							}
						}
						goto IL_2d63;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				obj201 = 0;
				object obj202 = obj201;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj203 = 0;
				obj2 = obj203;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v112+E4]");
				bool flag77 = (nint)0 == 0;
				object obj204 = !flag77;
				if (obj204 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj202 = obj201;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v112+A0]");
				object obj205 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X8_v76+1A0]");
				if (string.IsNullOrEmpty((string)0))
				{
					text7 = (string)obj2;
					text8 = (string)obj2;
					obj206 = obj2;
					num = unchecked((nint)null);
					goto IL_2f8d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj207 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array = default;
				bool flag78 = array == null;
				num = 6;
				if (!flag78)
				{
					bool flag79 = array.Length == 0;
					obj80 = 6;
					if (!flag79)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEF8]");
						object obj208 = 0;
						obj80 = obj208;
						object obj77 = array + 32;
						obj77 = obj208;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X22_v10 (System.Object)-8]");
						object obj209 = 0 & 0xFFFFFFFEL;
						if (obj209 != null)
						{
							obj80 = metaUserId;
							obj77 = array + 40;
							obj77 = metaUserId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X22_v10 (System.Object)-10]");
							bool flag80 = (nint)0 < (nint)2;
							object obj210 = !flag80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X22_v10 (System.Object)-10]");
							object obj211 = -2;
							bool flag81 = obj211 == null;
							object obj212 = ~obj210;
							object obj213 = obj212 | flag81;
							if (obj213 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
								object obj214 = 0;
								obj80 = obj214;
								object obj215 = array + 48;
								obj215 = obj214;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj216 = obj201;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ X0_v218+E4]");
								bool flag82 = (nint)0 == 0;
								object obj217 = !flag82;
								if (obj217 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj218 = array.Length & 0xFFFFFFFCL;
								if (obj218 != null)
								{
									object obj219 = obj201;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X8_v122+A0]");
									object obj220 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v123+1A0]");
									obj80 = 0;
									obj77 = array + 56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v123+1A0]");
									obj77 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X22_v10 (System.Object)-20]");
									bool flag83 = (nint)0 < (nint)4;
									object obj221 = !flag83;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ X22_v10 (System.Object)-20]");
									object obj222 = -4;
									bool flag84 = obj222 == null;
									object obj223 = ~obj221;
									object obj224 = obj223 | flag84;
									if (obj224 == null)
									{
										num = (nint)obj214;
										object obj225 = array + 64;
										obj225 = obj214;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										_003C_003Ec__DisplayClass138_0 obj226 = _003C_003E8__1;
										if (_003C_003E8__1 != null)
										{
											bool flag85 = array.Length < 5;
											object obj227 = !flag85;
											object obj228 = array.Length - 5;
											bool flag86 = obj228 == null;
											object obj229 = ~obj227;
											object obj230 = obj229 | flag86;
											obj80 = obj214;
											if (obj230 != null)
											{
												goto IL_2bc1;
											}
											object obj231 = array + 72;
											obj231 = obj226.nonce;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string message2 = string.Concat(array);
											string text9 = HwSign(message2);
											_003C_003Ec__DisplayClass138_0 obj232 = _003C_003E8__1;
											bool flag87 = _003C_003E8__1 == null;
											num = unchecked((nint)null);
											if (!flag87)
											{
												string text10 = HwSign(obj232.nonce);
												string text11 = HwPublicKey();
												bool flag88 = text9 == null;
												obj206 = obj2;
												string text12 = (string)obj2;
												if (!flag88)
												{
													object obj233 = obj201;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X0_v238+E4]");
													bool flag89 = (nint)0 == 0;
													object obj234 = !flag89;
													if (obj234 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj233 = obj201;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X0_v238+A0]");
													object obj235 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1855 @ X8_v129+1A0]");
													obj206 = 0;
													text12 = text9;
												}
												bool flag90 = text10 == null;
												object obj236 = !flag90;
												object obj237 = ~obj236;
												bool flag91 = obj237 != null || text11 == null;
												object obj238 = !flag91;
												text8 = (string)((obj238 != null) ? text10 : obj2);
												object obj239 = !flag91;
												text7 = (string)((obj239 != null) ? text11 : obj2);
												num = unchecked((nint)null);
												obj2 = text12;
												goto IL_2f8d;
											}
										}
										goto IL_2d63;
									}
								}
							}
						}
					}
					goto IL_2bc1;
				}
			}
			goto IL_2d63;
			IL_2f8d:
			if (_003C_003E8__1 != null)
			{
				object obj240 = _003C_003E8__1 + 64;
				obj240 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE90]");
				object obj241 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj242 = default;
				obj242._002Ector();
				bool flag92 = obj242 == null;
				num = unchecked((nint)null);
				if (!flag92)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
					object obj243 = 0;
					object obj244 = obj242 + 16;
					obj244 = obj243;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj245 = obj201;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v125+E4]");
					bool flag93 = (nint)0 == 0;
					object obj246 = !flag93;
					if (obj246 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj245 = obj201;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v125+A0]");
					object obj247 = 0;
					object obj248 = obj242 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ X8_v83+D8]");
					obj248 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj249 = obj242 + 32;
					obj249 = metaUserId;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag94 = string.IsNullOrEmpty(displayName);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF28]");
					object path4 = 0;
					string text15;
					if (flag94)
					{
						int num10 = UnityEngine.Random.Range(1000, 9999);
						int num11 = default;
						string text13 = num11.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF20]");
						object obj250 = 0;
						string text14 = (string)obj250 + text13;
						num2 = 0;
						text15 = text14;
					}
					else
					{
						text15 = displayName;
					}
					object obj251 = obj242 + 40;
					obj251 = text15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDEE8]");
					object obj252 = 0;
					object obj253 = obj242 + 48;
					obj253 = obj252;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj254 = obj201;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X0_v141+E4]");
					bool flag95 = (nint)0 == 0;
					object obj255 = !flag95;
					if (obj255 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool hasDevKey = HasDevKey;
					bool flag96 = !hasDevKey;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEED8]");
					object obj256 = 0;
					object obj257 = !flag96;
					object obj258 = ~obj257;
					if (obj258 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC190]");
						obj256 = 0;
					}
					object obj259 = obj242 + 56;
					obj259 = obj256;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
					object obj260 = 0;
					object obj261 = obj260;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1812 @ X0_v148+E4]");
					bool flag97 = (nint)0 == 0;
					object obj262 = !flag97;
					if (obj262 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string version3 = UnityEngine.Application.version;
					object obj263 = obj242 + 64;
					obj263 = version3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_003C_003Ec__DisplayClass138_0 obj264 = _003C_003E8__1;
					bool flag98 = _003C_003E8__1 == null;
					num = (nint)version3;
					if (!flag98)
					{
						num = (nint)obj264.nonce;
						object obj265 = obj242 + 72;
						obj265 = obj264.nonce;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_003C_003Ec__DisplayClass138_0 obj266 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							object obj267 = obj242 + 80;
							obj267 = obj266.attestation;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj268 = obj201;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1961 @ X0_v161+E4]");
							bool flag99 = (nint)0 == 0;
							object obj269 = !flag99;
							if (obj269 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string devKey2 = DevKey;
							object obj270 = obj242 + 144;
							obj270 = devKey2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text16 = NativeSignals();
							object obj271 = obj242 + 88;
							obj271 = text16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj272 = obj242 + 104;
							obj272 = text7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj273 = obj242 + 112;
							obj273 = text8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj274 = obj242 + 120;
							obj274 = obj206;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj275 = obj242 + 128;
							obj275 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj276 = obj201;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2068 @ X8_v99+A0]");
							object obj277 = 0;
							object obj278 = obj242 + 136;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2070 @ X8_v100+40]");
							obj278 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string body4 = JsonUtility.ToJson(obj242);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
							object obj279 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEEC8]");
							object obj280 = 0;
							Action<bool, System.__Canon> action10 = default;
							action10._002Ector((object)_003C_003E8__1, (IntPtr)obj280);
							IEnumerator enumerator7 = PlainPost((string)path4, body4, (Action<bool, string>)action10);
							object obj26 = this + 24;
							obj26 = enumerator7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj27 = 7;
							goto IL_2e00;
						}
					}
				}
			}
			goto IL_2d63;
			IL_2e00:
			result = true;
			goto IL_2dfb;
			IL_1a1a:
			Outcome outcome = Failure(text, text2);
			bool flag100 = action == null;
			num2 = 0;
			num = (nint)text2;
			obj2 = text;
			if (flag100)
			{
				goto IL_2d63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X21_v11 (System.Action`1<ShiftAuth+Outcome>)+18]");
			object obj281 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X21_v11 (System.Action`1<ShiftAuth+Outcome>)+40]");
			object obj282 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X21_v11 (System.Action`1<ShiftAuth+Outcome>)+28]");
			object obj283 = 0;
			object obj285 = default;
			object obj284 = obj285;
			goto IL_2f3c;
			IL_2f3c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1177 @ X9_v3 (should have been resolved before IL gen)");
			goto IL_2ee4;
			IL_2f27:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA48]");
			obj54 = 0;
			goto IL_34bf;
			IL_34bf:
			Outcome outcome2 = Failure((string)error, (string)obj54);
			bool flag101 = action5 == null;
			num2 = 0;
			num = (nint)obj54;
			if (flag101)
			{
				goto IL_2d63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X19_v2 (System.Action`1<ShiftAuth+Outcome>)+18]");
			obj281 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X19_v2 (System.Action`1<ShiftAuth+Outcome>)+40]");
			obj282 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X19_v2 (System.Action`1<ShiftAuth+Outcome>)+28]");
			obj283 = 0;
			object obj286 = default;
			obj284 = obj286;
			goto IL_2f3c;
			IL_2dfb:
			return result;
			IL_2d63:
			throw new NullReferenceException();
			IL_2bc1:
			IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			goto IL_2bcf;
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

	private sealed class _003CCloseRoutine_003Ed__131 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float grace;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CCloseRoutine_003Ed__131(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a7: Expected Obj, but got I
			//IL_00b6: Expected I4, but got I8
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected Obj, but got Unknown
			//IL_0037: Expected Obj, but got I
			//IL_0046: Expected I4, but got I8
			//IL_0070: Expected Obj, but got I4
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
					object obj = 0;
					_003C_003E1__state = -1;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v9+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Application.Quit();
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
				object obj4 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				WaitForSecondsRealtime waitForSecondsRealtime = default;
				waitForSecondsRealtime._002Ector(grace);
				object obj5 = this + 24;
				obj5 = waitForSecondsRealtime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state == 0;
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

	private sealed class _003CConnect_003Ed__135 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string metaUserId;

		public string displayName;

		public Action<Outcome> done;

		private _003C_003Ec__DisplayClass135_0 _003C_003E8__1;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CConnect_003Ed__135(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_057c: Expected Obj, but got I
			//IL_058b: Expected I4, but got I8
			//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ae: Expected Obj, but got Unknown
			//IL_0d84: Expected I4, but got Obj
			//IL_05f9: Expected Obj, but got I
			//IL_0619: Expected Obj, but got I
			//IL_062c: Expected I, but got Obj
			//IL_0040: Expected I4, but got I8
			//IL_0641: Expected Obj, but got I
			//IL_066b: Expected Obj, but got I4
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got I
			//IL_00c2: Invalid comparison between VT and I4
			//IL_0724: Expected Obj, but got I
			//IL_072d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0732: Expected Obj, but got Unknown
			//IL_012c: Expected Obj, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected Obj, but got Unknown
			//IL_015c: Expected Obj, but got I
			//IL_0186: Expected Obj, but got I4
			//IL_0781: Expected Obj, but got I8
			//IL_01b7: Expected Obj, but got I8
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected Obj, but got Unknown
			//IL_07bc: Expected Obj, but got I
			//IL_07e8: Expected Obj, but got I4
			//IL_07fe: Expected Obj, but got I
			//IL_081e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0823: Expected Obj, but got Unknown
			//IL_01ec: Expected Obj, but got I
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected Obj, but got Unknown
			//IL_020a: Expected Obj, but got I
			//IL_0236: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected Obj, but got Unknown
			//IL_0841: Expected Obj, but got I
			//IL_084a: Unknown result type (might be due to invalid IL or missing references)
			//IL_084f: Expected Obj, but got Unknown
			//IL_028f: Expected Obj, but got I
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected Obj, but got Unknown
			//IL_02c9: Expected Obj, but got I8
			//IL_0889: Expected Obj, but got Ref
			//IL_08a1: Expected Obj, but got I8
			//IL_02fe: Expected Obj, but got I
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected Obj, but got Unknown
			//IL_031c: Expected Obj, but got I
			//IL_0348: Expected Obj, but got I4
			//IL_035e: Expected Obj, but got I
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected Obj, but got Unknown
			//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cc: Expected Obj, but got Unknown
			//IL_0900: Expected Obj, but got I4
			//IL_0916: Expected Obj, but got I
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Expected Obj, but got Unknown
			//IL_03a1: Expected Obj, but got I
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected Obj, but got Unknown
			//IL_03e3: Expected Obj, but got I
			//IL_040d: Expected Obj, but got I4
			//IL_0959: Expected Obj, but got I
			//IL_0962: Unknown result type (might be due to invalid IL or missing references)
			//IL_0967: Expected Obj, but got Unknown
			//IL_044b: Expected Obj, but got I
			//IL_045b: Expected Obj, but got I
			//IL_047b: Expected Obj, but got I4
			//IL_0e04: Expected Obj, but got I4
			//IL_09b2: Expected Obj, but got I
			//IL_09dc: Expected Obj, but got I4
			//IL_0e22: Expected Obj, but got I
			//IL_04ab: Expected Obj, but got I4
			//IL_0a0a: Expected Obj, but got I
			//IL_0a2a: Expected Obj, but got I4
			//IL_0a3a: Expected Obj, but got I4
			//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5f: Expected Obj, but got Unknown
			//IL_0520: Expected Obj, but got I
			//IL_0563: Expected Obj, but got I
			//IL_04db: Expected Obj, but got I
			//IL_04eb: Expected Obj, but got I
			//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Expected Obj, but got Unknown
			//IL_0aaf: Expected Obj, but got I
			//IL_0ad9: Expected Obj, but got I4
			//IL_0b17: Expected Obj, but got I
			//IL_0b90: Expected Obj, but got I4
			//IL_0bd0: Expected Obj, but got I4
			//IL_0c31: Expected Obj, but got I4
			//IL_0c5f: Expected Obj, but got I
			//IL_0c9d: Expected Obj, but got I
			//IL_0cad: Expected Obj, but got I
			//IL_0cf1: Expected Obj, but got I4
			//IL_0d41: Expected Obj, but got I4
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					Action<Outcome> action = done;
					_003C_003E1__state = -1;
					Outcome result = default;
					if (done != null)
					{
						_003C_003Ec__DisplayClass135_0 obj = _003C_003E8__1;
						if (_003C_003E8__1 == null)
						{
							goto IL_0d68;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X8_v15 (System.Action`1<ShiftAuth+Outcome>)+18] (should have been resolved before IL gen)");
						result = obj.result;
					}
					_003C_003Ec__DisplayClass135_0 obj2 = _003C_003E8__1;
					if (_003C_003E8__1 == null)
					{
						goto IL_0d68;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
					object obj3 = 0;
					if (obj2.result != (Outcome)(object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						string[] array = default;
						if (array == null)
						{
							goto IL_0d68;
						}
						if (array.Length != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF70]");
							object obj4 = 0;
							object obj5 = array + 32;
							obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj6 = 0;
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v79+E4]");
							bool flag = (nint)0 == 0;
							object obj8 = !flag;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj9 = array.Length & 0xFFFFFFFEL;
							if (obj9 != null)
							{
								object obj10 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v50+A0]");
								object obj11 = 0;
								object obj12 = array + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v51+8]");
								obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X20_v11-10]");
								bool flag2 = (nint)0 < (nint)2;
								object obj13 = !flag2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X20_v11-10]");
								object obj14 = -2;
								bool flag3 = obj14 == null;
								object obj15 = ~obj13;
								object obj16 = obj15 | flag3;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
									object obj17 = 0;
									object obj18 = array + 48;
									obj18 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X20_v13-18]");
									object obj19 = 0 & 0xFFFFFFFCL;
									if (obj19 != null)
									{
										object obj20 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v56+A0]");
										object obj21 = 0;
										object obj22 = array + 56;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v57+10]");
										obj22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v15-20]");
										bool flag4 = (nint)0 < (nint)4;
										object obj23 = !flag4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v15-20]");
										object obj24 = -4;
										bool flag5 = obj24 == null;
										object obj25 = ~obj23;
										object obj26 = obj25 | flag5;
										if (obj26 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF60]");
											object obj27 = 0;
											object obj28 = array + 64;
											obj28 = obj27;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string message = string.Concat(array);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
											object obj29 = 0;
											object obj30 = obj29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v63+E4]");
											bool flag6 = (nint)0 == 0;
											object obj31 = !flag6;
											if (obj31 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											UnityEngine.Debug.Log(message);
											object obj32 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v96+A0]");
											object obj33 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v64+70]");
											object obj34 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v64+70]");
											bool flag7 = (nint)0 == 0;
											object obj35 = 0;
											if (!flag7)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v96+E4]");
												bool flag8 = (nint)0 == 0;
												object obj36 = !flag8;
												if (obj36 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													object obj37 = obj6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v70+A0]");
													object obj38 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v71+70]");
													obj34 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v71+70]");
													if ((nint)0 == 0)
													{
														goto IL_0d68;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v69+28]");
												obj35 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v586 @ X8_v69+18] (should have been resolved before IL gen)");
												obj32 = obj6;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v96+E4]");
											bool flag9 = (nint)0 == 0;
											object obj39 = !flag9;
											if (obj39 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj32 = obj6;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v96+A0]");
											object obj40 = 0;
											IEnumerator routine = HeartbeatLoop();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v68+120]");
											if ((nint)0 == 0)
											{
												goto IL_0d68;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v68+120]");
											Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
											goto IL_0da3;
										}
									}
								}
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						string[] array2 = default;
						if (array2 == null)
						{
							goto IL_0d68;
						}
						if (array2.Length != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF78]");
							object obj41 = 0;
							object obj42 = array2 + 32;
							obj42 = obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_003C_003Ec__DisplayClass135_0 obj43 = _003C_003E8__1;
							if (_003C_003E8__1 == null)
							{
								goto IL_0d68;
							}
							object obj44 = array2.Length & 0xFFFFFFFEL;
							if (obj44 != null)
							{
								object obj45 = array2 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v21 (ShiftAuth+<>c__DisplayClass135_0)+18]");
								obj45 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v9-10]");
								bool flag10 = (nint)0 < (nint)2;
								object obj46 = !flag10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v9-10]");
								object obj47 = -2;
								bool flag11 = obj47 == null;
								object obj48 = ~obj46;
								object obj49 = obj48 | flag11;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
									object obj50 = 0;
									object obj51 = array2 + 48;
									obj51 = obj50;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (_003C_003E8__1 == null)
									{
										goto IL_0d68;
									}
									string text = ((Enum)(&result)).ToString();
									object obj52 = array2.Length & 0xFFFFFFFCL;
									if (obj52 != null)
									{
										object obj53 = array2 + 56;
										obj53 = text;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X21_v11-20]");
										bool flag12 = (nint)0 < (nint)4;
										object obj54 = !flag12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X21_v11-20]");
										object obj55 = -4;
										bool flag13 = obj55 == null;
										object obj56 = ~obj54;
										object obj57 = obj56 | flag13;
										if (obj57 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
											object obj58 = 0;
											object obj59 = array2 + 64;
											obj59 = obj58;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											_003C_003Ec__DisplayClass135_0 obj60 = _003C_003E8__1;
											if (_003C_003E8__1 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
												object obj61 = 0;
												object obj62 = obj61;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v39+E4]");
												bool flag14 = (nint)0 == 0;
												object obj63 = !flag14;
												if (obj63 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v31 (ShiftAuth+<>c__DisplayClass135_0)+18]");
												string text2 = HttpSaid((string)0);
												bool flag15 = array2.Length < 5;
												object obj64 = !flag15;
												object obj65 = array2.Length - 5;
												bool flag16 = obj65 == null;
												object obj66 = ~obj64;
												object obj67 = obj66 | flag16;
												if (obj67 != null)
												{
													goto IL_0d76;
												}
												object obj68 = array2 + 72;
												obj68 = text2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												string message2 = string.Concat(array2);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
												object obj69 = 0;
												object obj70 = obj69;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v33+E4]");
												bool flag17 = (nint)0 == 0;
												object obj71 = !flag17;
												if (obj71 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												UnityEngine.Debug.LogWarning(message2);
												object obj72 = obj61;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v50+A0]");
												object obj73 = 0;
												_ = 0;
												_003C_003Ec__DisplayClass135_0 obj74 = _003C_003E8__1;
												if (_003C_003E8__1 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v35 (ShiftAuth+<>c__DisplayClass135_0)+20]");
													if ((nint)0 == 3)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v50+E4]");
														bool flag18 = (nint)0 == 0;
														object obj75 = !flag18;
														if (obj75 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														bool hasDevKey = HasDevKey;
														bool flag19 = !hasDevKey;
														object obj76 = !flag19;
														if (obj76 == null)
														{
															_003C_003Ec__DisplayClass135_0 obj77 = _003C_003E8__1;
															if (_003C_003E8__1 == null)
															{
																goto IL_0d68;
															}
															object obj78 = obj61;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v54+E4]");
															bool flag20 = (nint)0 == 0;
															object obj79 = !flag20;
															if (obj79 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v38 (ShiftAuth+<>c__DisplayClass135_0)+18]");
															if (LocalTamper((string)0))
															{
																int num = default;
																string text3 = num.ToString();
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF58]");
																object obj80 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF68]");
																object obj81 = 0;
																string message3 = (string)obj80 + text3 + (string)obj81;
																object obj82 = obj69;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v43+E4]");
																bool flag21 = (nint)0 == 0;
																object obj83 = !flag21;
																if (obj83 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																UnityEngine.Debug.LogWarning(message3);
																object obj84 = obj61;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v64+E4]");
																bool flag22 = (nint)0 == 0;
																object obj85 = !flag22;
																if (obj85 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																LockAndClose();
															}
														}
													}
													goto IL_0da3;
												}
											}
											goto IL_0d68;
										}
									}
								}
							}
						}
					}
					goto IL_0d76;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF50]");
				object obj86 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj87 = default;
				obj87._002Ector();
				object obj88 = this + 56;
				obj88 = obj87;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj88 == null)
				{
					goto IL_0d68;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
				object obj89 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF48]");
				object obj90 = 0;
				Action<Outcome> action2 = default;
				action2._002Ector((object)_003C_003E8__1, (IntPtr)obj90);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj91 = 0;
				object obj92 = obj91;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v14+E4]");
				bool flag23 = (nint)0 == 0;
				object obj93 = !flag23;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator enumerator = Authenticate(metaUserId, displayName, action2);
				object obj94 = this + 24;
				obj94 = enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 1;
			}
			goto IL_0da3;
			IL_0d68:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0d76;
			IL_0d76:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
			IL_0da3:
			return _003C_003E1__state == 0;
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

	private sealed class _003CEnsureHwKey_003Ed__178 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass178_0 _003C_003E8__1;

		public string metaUserId;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CEnsureHwKey_003Ed__178(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_04c5: Expected I4, but got I8
			//IL_0a2b: Expected I4, but got Obj
			//IL_03b0: Expected I4, but got I8
			//IL_0040: Expected Obj, but got I4
			//IL_0523: Expected Obj, but got I
			//IL_054d: Expected Obj, but got I4
			//IL_08f6: Expected Obj, but got I
			//IL_0920: Expected Obj, but got I4
			//IL_005e: Expected Obj, but got I
			//IL_006d: Expected I4, but got I8
			//IL_0b48: Expected Obj, but got I
			//IL_0b5e: Expected Obj, but got I
			//IL_059a: Expected F4, but got I
			//IL_059a: Expected F4, but got I
			//IL_0424: Expected F4, but got I
			//IL_0424: Expected F4, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00b2: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I
			//IL_0b2e: Expected Obj, but got I
			//IL_0605: Expected Obj, but got I
			//IL_062f: Expected Obj, but got I4
			//IL_043d: Expected Obj, but got I
			//IL_0467: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I
			//IL_0112: Expected Obj, but got I4
			//IL_0955: Expected Obj, but got I
			//IL_0a60: Expected Obj, but got I
			//IL_0a87: Expected Obj, but got I
			//IL_0a97: Expected Obj, but got I
			//IL_09a5: Expected F4, but got I
			//IL_09a5: Expected F4, but got I
			//IL_09d8: Expected Obj, but got I4
			//IL_0ade: Expected Obj, but got I4
			//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Expected Obj, but got Unknown
			//IL_06b3: Expected Obj, but got I4
			//IL_06cd: Expected Obj, but got I
			//IL_0bb1: Expected Obj, but got I
			//IL_0be3: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I4
			//IL_0712: Expected Obj, but got I
			//IL_071b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0720: Expected Obj, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected Obj, but got Unknown
			//IL_0224: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got I
			//IL_0764: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Expected Obj, but got Unknown
			//IL_0789: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Expected Obj, but got Unknown
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b5: Expected Obj, but got Unknown
			//IL_07e9: Expected Obj, but got I
			//IL_0803: Expected Obj, but got I
			//IL_0816: Expected I, but got Obj
			//IL_0283: Expected Obj, but got I
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected Obj, but got Unknown
			//IL_0845: Expected Obj, but got I4
			//IL_02c5: Expected Obj, but got I
			//IL_02df: Expected Obj, but got I
			//IL_02f0: Expected I, but got Obj
			//IL_0872: Expected Obj, but got I
			//IL_088d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0892: Expected Obj, but got Unknown
			//IL_031f: Expected Obj, but got I4
			//IL_034c: Expected Obj, but got I
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected Obj, but got Unknown
			bool result;
			float num3;
			float num4;
			float num9;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_0971;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFA0]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj3 = default;
					obj3._002Ector();
					object obj4 = this + 32;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBF0]");
					object key = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object defaultValue = 0;
					string text = PlayerPrefs.GetString((string)key, (string)defaultValue);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v45+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v45+A0]");
					object obj8 = (nint)0 + (nint)416;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v81+A0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v47+1A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v47+1A0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v48+10]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v81+E4]");
							bool flag3 = (nint)0 == 0;
							object obj12 = !flag3;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag4 = HwKeyExists();
							bool flag5 = !flag4;
							object obj13 = !flag5;
							if (obj13 != null)
							{
								goto IL_0971;
							}
							obj9 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v81+E4]");
						bool flag6 = (nint)0 == 0;
						object obj14 = !flag6;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj9 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v81+A0]");
						object obj15 = (nint)0 + (nint)416;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag7 = HwHeldOff();
						bool flag8 = !flag7;
						object obj16 = !flag8;
						if (obj16 != null)
						{
							goto IL_0971;
						}
						if (obj4 != null)
						{
							object obj17 = obj4 + 16;
							obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEE98]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj19 = default;
							obj19._002Ector();
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
								object obj20 = 0;
								object obj21 = obj19 + 16;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string body = JsonUtility.ToJson(obj19);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF90]");
								object obj23 = 0;
								Action<bool, System.__Canon> action = default;
								action._002Ector(obj4, (IntPtr)obj23);
								object obj24 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v98+E4]");
								bool flag9 = (nint)0 == 0;
								object obj25 = !flag9;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFB0]");
								object path = 0;
								IEnumerator enumerator = PlainPost((string)path, body, (Action<bool, string>)action);
								object obj26 = this + 24;
								obj26 = enumerator;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 1;
								result = true;
								goto IL_0aec;
							}
						}
					}
				}
				else
				{
					_003C_003Ec__DisplayClass178_0 obj27 = _003C_003E8__1;
					_003C_003E1__state = -1;
					if (_003C_003E8__1 != null)
					{
						if (string.IsNullOrEmpty(obj27.hwNonce))
						{
							float realtimeSinceStartup = Time.realtimeSinceStartup;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
							float num2 = UnityEngine.Random.Range(num, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj28 = 0;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v4+E4]");
							bool flag10 = (nint)0 == 0;
							object obj30 = !flag10;
							num3 = num2;
							num4 = realtimeSinceStartup;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj29 = obj28;
								num3 = num2;
								num4 = realtimeSinceStartup;
							}
							goto IL_0af1;
						}
						_003C_003Ec__DisplayClass178_0 obj31 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj32 = 0;
							object obj33 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v29+E4]");
							bool flag11 = (nint)0 == 0;
							object obj34 = !flag11;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string[] array = MakeHwKey(obj31.hwNonce);
							if (array == null)
							{
								float realtimeSinceStartup2 = Time.realtimeSinceStartup;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
								float num6 = UnityEngine.Random.Range(num5, 0f);
								object obj29 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v4+E4]");
								bool flag12 = (nint)0 == 0;
								object obj35 = !flag12;
								num3 = num6;
								num4 = realtimeSinceStartup2;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj29 = obj32;
									num3 = num6;
									num4 = realtimeSinceStartup2;
								}
								goto IL_0af1;
							}
							if (_003C_003E8__1 != null)
							{
								object obj36 = _003C_003E8__1 + 24;
								obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF88]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								object obj38 = default;
								obj38._002Ector();
								if (obj38 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
									object obj39 = 0;
									object obj40 = obj38 + 16;
									obj40 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_003C_003Ec__DisplayClass178_0 obj41 = _003C_003E8__1;
									if (_003C_003E8__1 != null)
									{
										object obj42 = obj38 + 24;
										obj42 = obj41.hwNonce;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj43 = obj38 + 32;
										obj43 = metaUserId;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj44 = obj38 + 40;
										obj44 = array;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string body2 = JsonUtility.ToJson(obj38);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEF98]");
										object obj46 = 0;
										Action<bool, System.__Canon> action2 = default;
										action2._002Ector((object)_003C_003E8__1, (IntPtr)obj46);
										object obj47 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v57+E4]");
										bool flag13 = (nint)0 == 0;
										object obj48 = !flag13;
										if (obj48 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFA8]");
										object path2 = 0;
										IEnumerator enumerator2 = PlainPost((string)path2, body2, (Action<bool, string>)action2);
										object obj49 = this + 24;
										obj49 = enumerator2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										_ = 2;
										result = true;
										goto IL_0aec;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				_003C_003Ec__DisplayClass178_0 obj50 = _003C_003E8__1;
				_003C_003E1__state = -1;
				if (_003C_003E8__1 != null)
				{
					if (string.IsNullOrEmpty(obj50.enrolled))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj51 = 0;
						object obj52 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v18+E4]");
						bool flag14 = (nint)0 == 0;
						object obj53 = !flag14;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						ForgetHwKey();
						float realtimeSinceStartup3 = Time.realtimeSinceStartup;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						float num8 = UnityEngine.Random.Range(num7, 0f);
						object obj29 = obj51;
						num9 = num8 * 1.1339039E+09f;
						num4 = realtimeSinceStartup3;
						result = false;
						goto IL_0b0f;
					}
					_003C_003Ec__DisplayClass178_0 obj54 = _003C_003E8__1;
					if (_003C_003E8__1 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj55 = 0;
						object obj56 = obj55;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v11+E4]");
						bool flag15 = (nint)0 == 0;
						object obj57 = !flag15;
						if (obj57 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj56 = obj55;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v11+A0]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v11+A0]");
						object obj59 = (nint)0 + (nint)416;
						_ = obj54.enrolled;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_003C_003Ec__DisplayClass178_0 obj60 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBF0]");
							object key2 = 0;
							PlayerPrefs.SetString((string)key2, obj60.enrolled);
							PlayerPrefs.Save();
							goto IL_0971;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0aec:
			return result;
			IL_0b0f:
			float num10 = num4 + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v4+A0]");
			object obj61 = 0;
			goto IL_0aec;
			IL_0971:
			result = false;
			goto IL_0aec;
			IL_0af1:
			num9 = num3 * 1.1339039E+09f;
			result = false;
			goto IL_0b0f;
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

	private sealed class _003CFetchMetaUser_003Ed__134 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<string> setId;

		public Action<string> setName;

		private _003C_003Ec__DisplayClass134_0 _003C_003E8__1;

		private float _003Ct_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CFetchMetaUser_003Ed__134(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_032a: Expected I4, but got I8
			//IL_0361: Invalid comparison between F4 and I4
			//IL_037c: Expected Obj, but got I4
			//IL_0717: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got I
			//IL_004e: Expected I4, but got I8
			//IL_04ca: Expected Obj, but got I4
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e8: Expected Obj, but got Unknown
			//IL_04f1: Expected Obj, but got I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected Obj, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected Obj, but got Unknown
			//IL_0172: Expected Obj, but got I
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected Obj, but got Unknown
			//IL_01e5: Expected Obj, but got I
			//IL_0204: Expected Obj, but got I
			//IL_020c: Expected I, but got Obj
			//IL_021d: Expected I, but got Obj
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected Obj, but got Unknown
			//IL_0252: Expected Obj, but got I
			//IL_027c: Expected Obj, but got I4
			//IL_0580: Expected Obj, but got I
			//IL_0588: Expected I, but got Obj
			//IL_0590: Expected Obj, but got I
			//IL_06e6: Expected Obj, but got I4
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ad: Expected Obj, but got Unknown
			//IL_075a: Expected Obj, but got I
			//IL_0650: Expected Obj, but got I4
			//IL_03ab: Expected Obj, but got I4
			//IL_03e3: Expected Obj, but got I
			//IL_02d5: Expected Obj, but got I4
			//IL_0402: Expected Obj, but got I
			//IL_040a: Expected I, but got Obj
			//IL_041b: Expected I, but got Obj
			//IL_0433: Expected Obj, but got I4
			//IL_030e: Expected Obj, but got I4
			//IL_04a4: Expected Obj, but got I4
			//IL_0459: Expected Obj, but got I
			//IL_0461: Expected I, but got Obj
			//IL_047b: Expected Obj, but got I4
			//IL_048b: Expected I, but got Obj
			object obj4;
			nint num2 = default;
			object obj6;
			Action action2;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_04cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFE0]");
				object obj2 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj3 = default;
				obj3._002Ector();
				obj4 = this + 48;
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag2 = obj4 == null;
				object obj5 = obj3;
				obj6 = obj3;
				if (!flag2)
				{
					obj6 = setId;
					object obj7 = obj4 + 16;
					obj7 = setId;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag3 = _003C_003E8__1 == null;
					obj5 = obj3;
					if (!flag3)
					{
						obj6 = setName;
						object obj8 = _003C_003E8__1 + 24;
						obj8 = setName;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_003C_003Ec__DisplayClass134_0 obj9 = _003C_003E8__1;
						bool flag4 = _003C_003E8__1 == null;
						obj5 = obj3;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFF0]");
							object obj10 = 0;
							obj9.finished = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj11 = default;
							obj11._002Ector();
							if (obj11 != null)
							{
								object obj12 = obj11 + 24;
								obj12 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFD8]");
								object obj14 = 0;
								nint num = (nint)obj14;
								Action action = default;
								action._002Ector(obj12, (IntPtr)obj14);
								object obj15 = obj11 + 16;
								obj15 = action;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
								object obj16 = 0;
								object obj17 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v50+E4]");
								bool flag5 = (nint)0 == 0;
								object obj18 = !flag5;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj19 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v54+E4]");
								bool flag6 = (nint)0 == 0;
								object obj20 = !flag6;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj19 = obj16;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v54+A0]");
								object obj21 = 0;
								if (obj21 != null)
								{
									object obj22 = obj15;
									bool flag7 = obj15 == null;
									object obj23 = 0;
									action2 = action;
									if (flag7)
									{
										goto IL_0522;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v43+28]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ X8_v43+18] (should have been resolved before IL gen)");
									obj23 = 0;
									obj5 = obj11;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v54+E4]");
									bool flag8 = (nint)0 == 0;
									object obj24 = !flag8;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Request<PlatformInitialize> request = Core.AsyncInitialize();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC0]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFE8]");
									object obj26 = 0;
									num = (nint)obj26;
									Callback val = default;
									val._002Ector(obj11, (IntPtr)obj26);
									bool flag9 = request == null;
									object obj23 = 0;
									action2 = (Action)obj11;
									if (flag9)
									{
										goto IL_0530;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFD0]");
									object obj27 = 0;
									num = (nint)obj27;
									Request<System.__Canon> request2 = ((Request<System.__Canon>)(object)request).OnComplete(val);
									obj23 = 0;
									obj5 = obj11;
									num2 = (nint)val;
								}
								goto IL_0490;
							}
							NullReferenceException ex = new NullReferenceException();
							action2 = null;
							goto IL_0522;
						}
					}
				}
				goto IL_0624;
			}
			_003C_003E1__state = -1;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num3 = _003Ct_003E5__2 + unscaledDeltaTime;
			float num4 = num3 - 10f;
			bool flag10 = num4 < 0f;
			_003Ct_003E5__2 = num3;
			object obj28 = !flag10;
			object obj29 = obj28;
			goto IL_06f4;
			IL_0490:
			_003Ct_003E5__2 = 0f;
			obj29 = 0;
			goto IL_06f4;
			IL_06f4:
			_003C_003Ec__DisplayClass134_0 obj30 = _003C_003E8__1;
			bool flag11 = _003C_003E8__1 == null;
			obj6 = num2;
			if (!flag11)
			{
				if (obj30.finished)
				{
					obj29 = 1;
				}
				if ((nint)obj29 != 1)
				{
					object obj31 = this + 24;
					obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					return true;
				}
				goto IL_04cf;
			}
			goto IL_0624;
			IL_04cf:
			return false;
			IL_0624:
			throw new NullReferenceException();
			IL_0522:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0530;
			IL_0530:
			NullReferenceException ex3 = new NullReferenceException();
			bool flag12 = (nint)action2 != 1;
			NullReferenceException ex4 = ex3;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj32 = 0;
				object obj33 = default;
				nint num5 = (nint)obj33;
				obj6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj35 = default;
				object obj34 = obj35 & 1;
				bool flag13 = obj34 == null;
				object obj5 = obj33;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj36 = obj4;
					bool flag14 = obj4 == null;
					obj5 = obj33;
					if (!flag14)
					{
						_ = 1;
						obj5 = obj33;
						num2 = num5;
						goto IL_0490;
					}
					goto IL_0624;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj37 = obj5;
				action2 = (Action)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				nint num = 0;
				NullReferenceException ex5 = default;
				ex4 = ex5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result = default;
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

	private sealed class _003CHeartbeatLoop_003Ed__146 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass146_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass146_1 _003C_003E8__2;

		private _003C_003Ec__DisplayClass146_2 _003C_003E8__3;

		private int _003Crefusals_003E5__2;

		private int _003Cmisses_003E5__3;

		private float _003ClastBeatEnd_003E5__4;

		private float _003CnotBefore_003E5__5;

		private float _003CnextBeatAt_003E5__6;

		private bool _003CphotonSaidNo_003E5__7;

		private float _003Cuntil_003E5__8;

		private int _003Ctries_003E5__9;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CHeartbeatLoop_003Ed__146(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_265c: Expected Obj, but got I
			//IL_266c: Expected Obj, but got I
			//IL_0361: Expected Obj, but got I
			//IL_0370: Expected I4, but got I8
			//IL_0015: Expected Obj, but got I4
			//IL_002f: Expected Obj, but got I4
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected Obj, but got Unknown
			//IL_03cf: Expected Obj, but got I4
			//IL_276f: Expected Obj, but got I
			//IL_2785: Expected Obj, but got I
			//IL_092f: Expected I4, but got I8
			//IL_072f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0734: Expected Obj, but got Unknown
			//IL_264c: Expected I4, but got Obj
			//IL_04ad: Expected I4, but got I8
			//IL_21f7: Expected Obj, but got I4
			//IL_0773: Expected Obj, but got I
			//IL_0499: Expected I, but got Obj
			//IL_2de7: Expected Obj, but got I
			//IL_215a: Expected Obj, but got I4
			//IL_012f: Expected I4, but got I8
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_0192: Expected Obj, but got I4
			//IL_01bc: Expected Obj, but got I
			//IL_01c6: Expected I, but got Obj
			//IL_24a4: Expected Obj, but got I4
			//IL_19ef: Expected Obj, but got I4
			//IL_07c2: Expected Obj, but got I4
			//IL_26a3: Expected Obj, but got I
			//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c1: Expected Obj, but got Unknown
			//IL_00a7: Expected I4, but got I8
			//IL_2e70: Expected Obj, but got I
			//IL_223e: Expected Obj, but got I4
			//IL_2612: Unknown result type (might be due to invalid IL or missing references)
			//IL_2617: Expected Obj, but got Unknown
			//IL_2620: Expected Obj, but got I4
			//IL_2ba9: Expected Obj, but got I
			//IL_2899: Expected Obj, but got I
			//IL_01db: Expected Obj, but got I
			//IL_0560: Expected Obj, but got I4
			//IL_2e26: Expected Obj, but got I4
			//IL_1c5f: Expected Obj, but got I4
			//IL_27b7: Expected Obj, but got I
			//IL_24eb: Expected Obj, but got I4
			//IL_226e: Expected Obj, but got I
			//IL_2d27: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_2eaf: Expected Obj, but got I4
			//IL_251b: Expected Obj, but got I
			//IL_1ca6: Expected Obj, but got I4
			//IL_081e: Invalid comparison between VT and I4
			//IL_025f: Expected Obj, but got I4
			//IL_2d66: Expected Obj, but got I4
			//IL_26e8: Expected Obj, but got I
			//IL_1cd6: Expected Obj, but got I
			//IL_1a8e: Expected Obj, but got I4
			//IL_0898: Expected Obj, but got I4
			//IL_256b: Expected Obj, but got I4
			//IL_22ed: Expected Obj, but got I4
			//IL_1165: Expected Obj, but got I
			//IL_05e3: Expected Obj, but got I4
			//IL_1abe: Expected Obj, but got I
			//IL_0d0f: Expected Obj, but got I
			//IL_297c: Expected Obj, but got I4
			//IL_091b: Expected I, but got Obj
			//IL_287b: Expected Obj, but got I4
			//IL_0a34: Expected Obj, but got I4
			//IL_259b: Expected Obj, but got I
			//IL_231d: Expected Obj, but got I
			//IL_1ae5: Expected Obj, but got I4
			//IL_119f: Expected Obj, but got I
			//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ad: Expected Obj, but got Unknown
			//IL_11bd: Expected Obj, but got I
			//IL_3071: Expected Obj, but got I
			//IL_3081: Expected Obj, but got I
			//IL_30ab: Expected Obj, but got I4
			//IL_0c55: Expected Obj, but got I4
			//IL_02d5: Expected Obj, but got I4
			//IL_2faa: Expected Obj, but got I
			//IL_2fb9: Expected Obj, but got I4
			//IL_2fda: Expected Obj, but got I
			//IL_061e: Expected Obj, but got I4
			//IL_2087: Unknown result type (might be due to invalid IL or missing references)
			//IL_208c: Expected Obj, but got Unknown
			//IL_2344: Expected Obj, but got I4
			//IL_0c83: Expected Obj, but got I
			//IL_2727: Expected Obj, but got I
			//IL_0dac: Expected Obj, but got I4
			//IL_1d55: Expected Obj, but got I4
			//IL_1b94: Expected Obj, but got I4
			//IL_1b15: Expected Obj, but got I
			//IL_123c: Expected Obj, but got I
			//IL_1266: Expected Obj, but got I4
			//IL_11cf: Expected I, but got Obj
			//IL_095f: Expected Obj, but got I4
			//IL_0aa0: Expected Obj, but got I4
			//IL_0ac5: Expected Obj, but got I4
			//IL_0d43: Expected Obj, but got I4
			//IL_20c5: Expected I, but got Obj
			//IL_20ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_20d3: Expected Obj, but got Unknown
			//IL_238e: Expected Obj, but got I4
			//IL_2c91: Expected Obj, but got I
			//IL_1b4d: Expected Obj, but got I4
			//IL_12cc: Expected F4, but got I
			//IL_12cc: Expected F4, but got I
			//IL_0cc4: Expected I, but got Obj
			//IL_2905: Unknown result type (might be due to invalid IL or missing references)
			//IL_290a: Expected Obj, but got Unknown
			//IL_031c: Expected Obj, but got I4
			//IL_15da: Expected Obj, but got I4
			//IL_15f4: Expected Obj, but got I4
			//IL_299a: Expected Obj, but got I
			//IL_06a2: Expected Obj, but got I4
			//IL_25cf: Expected Obj, but got I4
			//IL_1d85: Expected Obj, but got I
			//IL_2c27: Expected Obj, but got I
			//IL_12fc: Expected Obj, but got I
			//IL_130c: Expected Obj, but got I
			//IL_2f37: Expected Obj, but got I
			//IL_2f51: Expected Obj, but got I
			//IL_2f62: Expected I, but got Obj
			//IL_2f8c: Expected Obj, but got I4
			//IL_098f: Expected Obj, but got I
			//IL_2755: Unknown result type (might be due to invalid IL or missing references)
			//IL_275a: Expected Obj, but got Unknown
			//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc1: Expected Obj, but got Unknown
			//IL_0e22: Invalid comparison between F4 and I4
			//IL_0e31: Invalid comparison between F4 and I4
			//IL_0e49: Expected Obj, but got F4
			//IL_0e56: Expected Obj, but got F4
			//IL_0e8b: Expected Obj, but got I4
			//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e98: Expected Obj, but got Unknown
			//IL_1628: Expected Obj, but got I4
			//IL_27f3: Expected Obj, but got I
			//IL_2803: Expected Obj, but got I
			//IL_2819: Expected Obj, but got I
			//IL_2ef6: Expected Obj, but got I
			//IL_2f14: Expected Obj, but got I
			//IL_23c6: Expected Obj, but got I4
			//IL_1dac: Expected Obj, but got I4
			//IL_1bec: Expected Obj, but got I4
			//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c1c: Expected Obj, but got Unknown
			//IL_1c25: Expected Obj, but got I4
			//IL_1c38: Expected Obj, but got I4
			//IL_2aaa: Invalid comparison between F4 and I4
			//IL_2ab9: Invalid comparison between F4 and I4
			//IL_2acf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ad4: Expected Obj, but got Unknown
			//IL_2ae1: Expected Obj, but got F4
			//IL_2b16: Expected Obj, but got I4
			//IL_2b1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b23: Expected Obj, but got Unknown
			//IL_09bc: Expected Obj, but got I
			//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cb: Expected Obj, but got Unknown
			//IL_034c: Expected Obj, but got I
			//IL_0be1: Expected Obj, but got I4
			//IL_294c: Expected Obj, but got I4
			//IL_161a: Expected Obj, but got I4
			//IL_1821: Expected Obj, but got I4
			//IL_1837: Expected Obj, but got I4
			//IL_1844: Expected I, but got Obj
			//IL_10f6: Expected Obj, but got I4
			//IL_2418: Expected Obj, but got I4
			//IL_2cc6: Expected Obj, but got I
			//IL_2ce6: Invalid comparison between F4 and I4
			//IL_2cf8: Expected F4, but got I4
			//IL_2d01: Expected F4, but got I4
			//IL_135f: Expected F4, but got I
			//IL_09eb: Expected Obj, but got I4
			//IL_2a0e: Expected Obj, but got I
			//IL_3033: Expected Obj, but got I
			//IL_0b21: Expected Obj, but got I4
			//IL_0b2e: Expected I, but got Obj
			//IL_1123: Expected Obj, but got I
			//IL_06e9: Expected Obj, but got I4
			//IL_1ddc: Expected Obj, but got I
			//IL_1870: Expected Obj, but got I4
			//IL_1894: Expected Obj, but got I4
			//IL_18b9: Expected Obj, but got I4
			//IL_18c6: Expected I, but got Obj
			//IL_2a76: Expected I, but got Obj
			//IL_0716: Expected Obj, but got I
			//IL_0724: Expected I, but got Obj
			//IL_1dec: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df1: Expected Obj, but got Unknown
			//IL_1dfa: Expected Obj, but got I4
			//IL_0ede: Expected Obj, but got I
			//IL_0b45: Expected Obj, but got I4
			//IL_1374: Expected Obj, but got I
			//IL_18fe: Expected Obj, but got I4
			//IL_1e34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e39: Expected Obj, but got Unknown
			//IL_1e42: Expected Obj, but got I4
			//IL_0f2b: Expected Obj, but got I
			//IL_13c1: Expected Obj, but got I
			//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d6: Expected Obj, but got Unknown
			//IL_1e76: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7b: Expected Obj, but got Unknown
			//IL_1e84: Expected Obj, but got I4
			//IL_2b8b: Expected Obj, but got I4
			//IL_169d: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a2: Expected Obj, but got Unknown
			//IL_1978: Expected Obj, but got I
			//IL_1988: Expected Obj, but got I
			//IL_19c0: Expected Obj, but got I4
			//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f69: Expected I8, but got Unknown
			//IL_30cf: Expected Obj, but got I
			//IL_30f1: Expected Obj, but got I
			//IL_1080: Expected Obj, but got I
			//IL_10aa: Expected Obj, but got I4
			//IL_1ecd: Expected I8, but got I4
			//IL_1eeb: Expected Obj, but got I
			//IL_1efb: Expected Obj, but got I
			//IL_13f8: Expected Obj, but got Ref
			//IL_0f95: Expected Obj, but got I
			//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0faa: Expected I4, but got Unknown
			//IL_0fd6: Expected Obj, but got I
			//IL_1702: Expected Obj, but got I
			//IL_1f55: Expected Obj, but got I
			//IL_1f5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f63: Expected Obj, but got Unknown
			//IL_1f8d: Expected Obj, but got I
			//IL_1f96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f9b: Expected Obj, but got Unknown
			//IL_1fab: Expected Obj, but got I
			//IL_1445: Expected Obj, but got I
			//IL_101b: Expected Obj, but got I
			//IL_174f: Expected Obj, but got I
			//IL_1fd7: Expected Obj, but got I
			//IL_1468: Expected Obj, but got I
			//IL_1048: Expected F4, but got I4
			//IL_1051: Expected Obj, but got I4
			//IL_1767: Expected Obj, but got Ref
			//IL_1ff6: Expected Obj, but got I
			//IL_2009: Expected I, but got Obj
			//IL_2019: Expected Obj, but got I
			//IL_178a: Expected Obj, but got I
			//IL_203e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2043: Expected Obj, but got Unknown
			//IL_14ad: Expected Obj, but got I
			//IL_17b6: Expected Obj, but got I
			//IL_17e0: Expected Obj, but got I4
			//IL_14d9: Expected Obj, but got I
			//IL_1503: Expected Obj, but got I4
			//IL_155e: Expected Obj, but got I
			//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a7: Expected Obj, but got Unknown
			//IL_15c7: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF018]");
			object obj2 = 0;
			float num3;
			string text;
			object obj16;
			object message;
			string text6;
			string text2 = default;
			object obj17 = default;
			bool result;
			object obj87 = default;
			nint num7 = default;
			float num22 = default;
			nint num6;
			float num4 = default;
			object obj96;
			object obj97;
			if (_003C_003E1__state > 2)
			{
				object obj3 = _003C_003E1__state - 4;
				bool flag = obj3 == null;
				object obj4 = !flag;
				int num5 = default;
				if (_003C_003E1__state <= 4)
				{
					if (_003C_003E1__state == 3)
					{
						_003C_003E1__state = -1;
						float realtimeSinceStartup = Time.realtimeSinceStartup;
						_003C_003Ec__DisplayClass146_1 obj5 = _003C_003E8__2;
						float num = realtimeSinceStartup + 2f;
						_003ClastBeatEnd_003E5__4 = realtimeSinceStartup;
						_003CnotBefore_003E5__5 = num;
						if (_003C_003E8__2 != null)
						{
							_003C_003Ec__DisplayClass146_0 obj6 = obj5.CS_0024_003C_003E8__locals1;
							if (obj5.CS_0024_003C_003E8__locals1 != null)
							{
								object obj7 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v246+E4]");
								bool flag2 = (nint)0 == 0;
								object obj8 = !flag2;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj7 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v246+A0]");
								object obj9 = 0;
								int mine = obj6.mine;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v155+B4]");
								if ((nint)mine != 0)
								{
									goto IL_25fe;
								}
								_003C_003Ec__DisplayClass146_1 obj10 = _003C_003E8__2;
								if (_003C_003E8__2 != null)
								{
									if (~(obj10.alive ? 1u : 0u) == 0)
									{
										bool flag3 = (byte)(~(obj10.reattest ? 1u : 0u)) != 0;
										object obj11 = !flag3;
										if (obj11 != null)
										{
											goto IL_0b4a;
										}
										_003Crefusals_003E5__2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v246+E4]");
										bool flag4 = (nint)0 == 0;
										object obj12 = !flag4;
										if (obj12 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num2 = BeatInterval();
										realtimeSinceStartup = _003ClastBeatEnd_003E5__4 + num2;
										object obj13 = obj;
										_003CnextBeatAt_003E5__6 = realtimeSinceStartup;
										if (~(_003CphotonSaidNo_003E5__7 ? 1u : 0u) != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v343+E4]");
											bool flag5 = (nint)0 == 0;
											object obj14 = !flag5;
											if (obj14 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj13 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v343+A0]");
											object obj15 = 0;
											_ = 0;
											num3 = num4;
											text = text2;
											obj16 = obj17;
											num5 = 0;
											num6 = num7;
											goto IL_247a;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v343+E4]");
										bool flag6 = (nint)0 == 0;
										object obj18 = !flag6;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj13 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v343+A0]");
										object obj19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ X8_v223+198]");
										object obj21 = (nint)0 + (nint)1;
										object obj22 = obj20;
										if ((nint)obj21 <= 2)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X0_v347+E4]");
											bool flag7 = (nint)0 == 0;
											object obj23 = !flag7;
											if (obj23 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF080]");
											object obj24 = 0;
											message = obj24;
											num5 = 0;
											goto IL_2a50;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ X0_v347+E4]");
										bool flag8 = (nint)0 == 0;
										object obj25 = !flag8;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF058]");
										object message2 = 0;
										UnityEngine.Debug.LogWarning(message2);
										num7 = unchecked((nint)null);
									}
									else
									{
										if (obj10.reason == null)
										{
											goto IL_0b4a;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v246+E4]");
										bool flag9 = (nint)0 == 0;
										object obj26 = !flag9;
										if (obj26 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Beat beat = JudgeBeat(obj10.status, obj10.reason, obj10.category);
										if (beat == 0)
										{
											object obj27 = obj;
											int num8 = _003Cmisses_003E5__3 + 1;
											_003Cmisses_003E5__3 = num8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ X0_v267+E4]");
											bool flag10 = (nint)0 == 0;
											object obj28 = !flag10;
											if (obj28 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num9 = BeatInterval();
											_003C_003Ec__DisplayClass146_1 obj29 = _003C_003E8__2;
											if (_003C_003E8__2 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
												float num10 = num9 - obj29.serverWait;
												bool flag11 = num10 < 0f;
												bool flag12 = num10 == 0f;
												object obj30 = num9 ^ obj29.serverWait;
												object obj31 = num9 ^ num10;
												object obj32 = obj30 & obj31;
												bool flag13 = (nint)obj32 < 0;
												bool flag14 = flag11 == flag13;
												obj4 = !flag12;
												object obj33 = flag14 & obj4;
												object obj34 = ~obj33;
												float num11 = ((obj34 != null) ? obj29.serverWait : num9);
												float num12 = Backoff(_003Cmisses_003E5__3, 4f, 30f);
												float num13 = num12 + num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
												object obj35 = 0;
												float num14 = _003ClastBeatEnd_003E5__4 + num13;
												_003CnextBeatAt_003E5__6 = num14;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												string[] array = default;
												if (array != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF040]");
													object obj36 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													_003C_003Ec__DisplayClass146_1 obj37 = _003C_003E8__2;
													if (_003C_003E8__2 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF068]");
														object obj38 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
														if (_003C_003E8__2 != null)
														{
															long num15 = _003C_003E8__2 + 16;
															string text3 = ((long*)num15)->ToString();
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF030]");
															object obj39 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															int num16 = this + 60;
															string text4 = ((int*)num16)->ToString();
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF078]");
															object obj40 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
															string text5 = num5.ToString();
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED58]");
															object obj41 = 0;
															text2 = (string)obj41;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
															text6 = string.Concat(array);
															num4 = 1.1146363E+09f;
															obj17 = 0;
															num = 30f;
															realtimeSinceStartup = num13;
															string text7 = null;
															goto IL_1070;
														}
													}
												}
											}
											goto IL_263e;
										}
										object obj42 = beat - 4;
										_003Cmisses_003E5__3 = 0;
										bool flag15 = (nint)obj42 < 2;
										object obj43 = !flag15;
										object obj44 = ~obj43;
										if (obj44 != null)
										{
											object obj45 = beat - 4;
											bool flag16 = obj45 == null;
											object obj46 = !flag16;
											object obj47 = ~obj46;
											if (obj47 == null)
											{
												object obj48 = 2 + 1;
											}
											else
											{
												object obj48 = 2;
											}
											goto IL_2922;
										}
										if (beat != (Beat)1)
										{
											bool flag17 = beat != (Beat)3;
											text2 = obj10.category;
											obj17 = 0;
											num7 = (nint)obj10.reason;
											if (!flag17)
											{
												object obj48 = 4;
												goto IL_2922;
											}
										}
										else
										{
											bool flag18 = (byte)(~(_003CphotonSaidNo_003E5__7 ? 1u : 0u)) != 0;
											object obj49 = !flag18;
											text2 = obj10.category;
											obj17 = 0;
											num7 = (nint)obj10.reason;
											if (obj49 == null)
											{
												int num17 = _003Crefusals_003E5__2 + 1;
												object obj50 = num17 - 1;
												bool flag19 = obj50 == null;
												_003Crefusals_003E5__2 = num17;
												obj4 = !flag19;
												bool flag20 = num17 > 1;
												text2 = obj10.category;
												obj17 = 0;
												num7 = (nint)obj10.reason;
												if (!flag20)
												{
													object obj51 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X0_v333+E4]");
													bool flag21 = (nint)0 == 0;
													object obj52 = !flag21;
													if (obj52 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													float num18 = BeatInterval();
													realtimeSinceStartup = _003ClastBeatEnd_003E5__4 + num18;
													_003C_003Ec__DisplayClass146_1 obj53 = _003C_003E8__2;
													_003CnextBeatAt_003E5__6 = realtimeSinceStartup;
													if (_003C_003E8__2 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF048]");
														object obj54 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF038]");
														object obj55 = 0;
														string text7 = obj53.reason;
														text2 = (string)obj55;
														text6 = (string)obj54 + obj53.reason + (string)obj55;
														obj17 = 0;
														goto IL_1070;
													}
													goto IL_263e;
												}
											}
										}
									}
									goto IL_2846;
								}
							}
						}
						goto IL_263e;
					}
					bool flag22 = _003C_003E1__state != 4;
					result = false;
					if (flag22)
					{
						goto IL_268e;
					}
					_003C_003E1__state = -1;
					_003Ctries_003E5__9 = 1;
				}
				else
				{
					if (_003C_003E1__state == 5)
					{
						object obj56 = this + 40;
						object obj57 = obj56;
						_ = 4294967295L;
						if (obj56 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v106+40]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v106+40]");
							if ((nint)0 != 0)
							{
								object obj59 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v177+E4]");
								bool flag23 = (nint)0 == 0;
								object obj60 = !flag23;
								if (obj60 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj59 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v177+A0]");
								object obj61 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v107+10]");
								nint num19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v108+B4]");
								if (num19 != 0)
								{
									goto IL_25fe;
								}
								_003C_003Ec__DisplayClass146_2 obj62 = _003C_003E8__3;
								if (_003C_003E8__3 != null)
								{
									if (obj62.renew != (Outcome)(object)0)
									{
										_003Cmisses_003E5__3 = 0;
										float realtimeSinceStartup2 = Time.realtimeSinceStartup;
										object obj63 = obj;
										float num20 = realtimeSinceStartup2 + 2f;
										_003ClastBeatEnd_003E5__4 = realtimeSinceStartup2;
										_003CnotBefore_003E5__5 = num20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X0_v234+E4]");
										bool flag24 = (nint)0 == 0;
										object obj64 = !flag24;
										if (obj64 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num21 = BeatInterval();
										float realtimeSinceStartup = realtimeSinceStartup2 + num21;
										_003C_003E8__2 = null;
										_003CnextBeatAt_003E5__6 = realtimeSinceStartup;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										num3 = num4;
										text = text2;
										obj16 = obj17;
										float num = num22;
										num5 = 0;
										num6 = unchecked((nint)null);
										goto IL_247a;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+20]");
									if ((nint)0 == 4)
									{
										goto IL_0cd2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+20]");
									if ((nint)0 == 3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v177+E4]");
										bool flag25 = (nint)0 == 0;
										object obj65 = !flag25;
										if (obj65 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+18]");
										if (LocalTamper((string)0))
										{
											obj62 = _003C_003E8__3;
											bool flag26 = _003C_003E8__3 == null;
											num7 = unchecked((nint)null);
											if (!flag26)
											{
												goto IL_0cd2;
											}
											goto IL_263e;
										}
										obj59 = obj;
										num7 = unchecked((nint)null);
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v177+E4]");
									bool flag27 = (nint)0 == 0;
									object obj66 = !flag27;
									if (obj66 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj59 = obj;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
									object obj67 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v177+A0]");
									object obj68 = 0;
									object obj69 = obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v117+E4]");
									bool flag28 = (nint)0 == 0;
									object obj70 = !flag28;
									if (obj70 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									DateTimeOffset utcNow = DateTimeOffset.UtcNow;
									DateTimeOffset dateTimeOffset = default;
									long num23 = dateTimeOffset.ToUnixTimeSeconds();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1299 @ X9_v53+100]");
									float num24 = 0f - (float)num23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									object obj71 = 0;
									object obj72 = obj71;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ X0_v183+E4]");
									bool flag29 = (nint)0 == 0;
									object obj73 = !flag29;
									if (obj73 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int val = _003Ctries_003E5__9 - 1;
									int num25 = Math.Min(val, 5);
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									nint num26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
									float num27 = UnityEngine.Random.Range(num26, 0f);
									object obj74 = default;
									float num28 = num27 * (float)obj74;
									object obj75 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1694 @ X8_v125+A0]");
									object obj76 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj77 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
									if (num28 < num24)
									{
										num28 = num24;
									}
									float num29 = num28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v126+138]");
									float num30 = num29 - 0f;
									bool flag30 = num30 < 0f;
									bool flag31 = num30 == 0f;
									float num31 = num28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v126+138]");
									object obj78 = num31 ^ 0;
									object obj79 = num28 ^ num30;
									object obj80 = obj78 & obj79;
									bool flag32 = (nint)obj80 < 0;
									bool flag33 = flag30 == flag32;
									object obj81 = !flag31;
									object obj82 = flag33 & obj81;
									object obj83 = ~obj82;
									float num32;
									if (obj83 == null)
									{
										num32 = num28;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1695 @ X8_v126+138]");
										num32 = 0f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									string[] array2 = default;
									if (array2 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF050]");
										object obj84 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										_003C_003Ec__DisplayClass146_2 obj85 = _003C_003E8__3;
										if (_003C_003E8__3 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
											object obj86 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
											if (_003C_003E8__3 != null)
											{
												string text8 = ((Enum)(&obj87)).ToString();
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
												_003C_003Ec__DisplayClass146_2 obj88 = _003C_003E8__3;
												if (_003C_003E8__3 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v136 (ShiftAuth+<>c__DisplayClass146_2)+18]");
													string text9 = HttpSaid((string)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF088]");
													object obj89 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
													string text10 = num5.ToString();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED58]");
													object obj90 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
													string message3 = string.Concat(array2);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
													object obj91 = 0;
													object obj92 = obj91;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X8_v143+E4]");
													bool flag34 = (nint)0 == 0;
													object obj93 = !flag34;
													if (obj93 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													UnityEngine.Debug.LogWarning(message3);
													object obj94 = obj56;
													if (obj56 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v144+40]");
														object obj95 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v144+40]");
														if ((nint)0 != 0)
														{
															float seconds = num32;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v145+10]");
															IEnumerator enumerator = WaitTrying(seconds, 0);
															obj96 = this + 24;
															obj96 = enumerator;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															obj97 = 6;
															goto IL_290f;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_263e;
					}
					bool flag35 = _003C_003E1__state != 6;
					result = false;
					if (flag35)
					{
						goto IL_268e;
					}
					object obj98 = this + 48;
					obj98 = 0;
					_ = 4294967295L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X20_v35+24]");
					object obj99 = (nint)0 + (nint)1;
					num7 = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF028]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj101 = default;
				obj101._002Ector();
				object obj102 = this + 48;
				obj102 = obj101;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X20_v29-8]");
				object obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X20_v29-8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v86+40]");
					object obj104 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v86+40]");
					if ((nint)0 != 0)
					{
						object obj105 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+E4]");
						bool flag36 = (nint)0 == 0;
						object obj106 = !flag36;
						if (obj106 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj105 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+A0]");
						object obj107 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v87+10]");
						nint num33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X8_v88+B4]");
						if (num33 != 0)
						{
							goto IL_25fe;
						}
						if (obj102 != null)
						{
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+E4]");
							bool flag37 = (nint)0 == 0;
							object obj108 = !flag37;
							if (obj108 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj105 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+A0]");
							object obj109 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X8_v98+F0]");
							object displayName;
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+E4]");
								bool flag38 = (nint)0 == 0;
								object obj110 = !flag38;
								if (obj110 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj111 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ X8_v104+A0]");
									obj109 = 0;
								}
								displayName = obj109 + 240;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X0_v148+E4]");
								bool flag39 = (nint)0 == 0;
								object obj112 = !flag39;
								if (obj112 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj113 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1592 @ X8_v100+A0]");
									obj109 = 0;
								}
								displayName = obj109 + 16;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
							object obj114 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF020]");
							object obj115 = 0;
							Action<Outcome> action = default;
							action._002Ector(obj102, (IntPtr)obj115);
							object obj116 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1731 @ X0_v152+E4]");
							bool flag40 = (nint)0 == 0;
							object obj117 = !flag40;
							if (obj117 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X8_v98+18]");
							IEnumerator enumerator2 = Authenticate((string)0, (string)displayName, action);
							obj96 = this + 24;
							obj96 = enumerator2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj97 = 5;
							goto IL_290f;
						}
					}
				}
			}
			else
			{
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						bool flag41 = _003C_003E1__state != 2;
						result = false;
						if (!flag41)
						{
							_003C_003E1__state = -1;
							goto IL_19c5;
						}
						goto IL_268e;
					}
					_003C_003E1__state = -1;
					int num5 = 0;
					goto IL_28c8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF008]");
				object obj118 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj119 = default;
				obj119._002Ector();
				object obj120 = this + 32;
				obj120 = obj119;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj121 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v136+E4]");
				bool flag42 = (nint)0 == 0;
				object obj122 = !flag42;
				if (obj122 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj121 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v136+A0]");
				object obj123 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v80+B4]");
				object obj124 = (nint)0 + (nint)1;
				if (obj120 != null)
				{
					_003Crefusals_003E5__2 = 0;
					_ = 0;
					_ = 0;
					float realtimeSinceStartup3 = Time.realtimeSinceStartup;
					float num34 = realtimeSinceStartup3 + 2f;
					_003ClastBeatEnd_003E5__4 = realtimeSinceStartup3;
					_003CnotBefore_003E5__5 = num34;
					float num35 = BeatInterval();
					float realtimeSinceStartup = realtimeSinceStartup3 + num35;
					_003CnextBeatAt_003E5__6 = realtimeSinceStartup;
					num3 = num4;
					text = text2;
					obj16 = obj17;
					float num = num22;
					int num5 = 0;
					num6 = (nint)obj119;
					goto IL_247a;
				}
			}
			goto IL_263e;
			IL_19c5:
			object obj125 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
			bool flag43 = (nint)0 == 0;
			object obj126 = !flag43;
			if (obj126 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj125 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
			object obj127 = 0;
			if (obj127 == null)
			{
				goto IL_1c3d;
			}
			_003C_003Ec__DisplayClass146_1 obj128 = _003C_003E8__2;
			float num37;
			if (_003C_003E8__2 != null)
			{
				_003C_003Ec__DisplayClass146_0 obj129 = obj128.CS_0024_003C_003E8__locals1;
				if (obj128.CS_0024_003C_003E8__locals1 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
					bool flag44 = (nint)0 == 0;
					object obj130 = !flag44;
					if (obj130 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj125 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
						obj127 = 0;
					}
					int mine2 = obj129.mine;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X8_v62+B4]");
					if ((nint)mine2 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
						bool flag45 = (nint)0 == 0;
						object obj131 = !flag45;
						if (obj131 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj125 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
							obj127 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X8_v62+114]");
						if ((nint)0 != 0)
						{
							float realtimeSinceStartup4 = Time.realtimeSinceStartup;
							obj125 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
							bool flag46 = (nint)0 == 0;
							object obj132 = !flag46;
							if (obj132 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj125 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
							object obj133 = 0;
							float num36 = realtimeSinceStartup4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v74+128]");
							num37 = num36 - 0f;
							bool flag47 = (double)num37 < 20.0;
							num22 = 20f;
							float num38 = 20f;
							float num39 = num37;
							if (flag47)
							{
								goto IL_1c11;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
						bool flag48 = (nint)0 == 0;
						object obj134 = !flag48;
						if (obj134 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj125 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
						object obj135 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ X8_v68+108]");
						if ((nint)0 != 0)
						{
							float realtimeSinceStartup5 = Time.realtimeSinceStartup;
							obj125 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
							bool flag49 = (nint)0 == 0;
							object obj136 = !flag49;
							if (obj136 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj125 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
							object obj137 = 0;
							float num40 = realtimeSinceStartup5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v71+190]");
							float num39 = num40 - 0f;
							bool flag50 = !(num39 < 1.1274813E+09f);
							float num38 = 1.1274813E+09f;
							num22 = 1.1274813E+09f;
							num37 = num39;
							if (!flag50)
							{
								goto IL_1c11;
							}
						}
					}
					goto IL_1c3d;
				}
			}
			goto IL_263e;
			IL_1070:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj138 = 0;
			object obj139 = obj138;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1678 @ X8_v171+E4]");
			bool flag51 = (nint)0 == 0;
			object obj140 = !flag51;
			if (obj140 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			message = text6;
			goto IL_2a50;
			IL_28c8:
			num37 = Time.realtimeSinceStartup;
			num22 = _003Cuntil_003E5__8;
			if (num37 < _003Cuntil_003E5__8)
			{
				object obj141 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X0_v34+E4]");
				bool flag52 = (nint)0 == 0;
				object obj142 = !flag52;
				if (obj142 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag53 = BeatDue(_003CnextBeatAt_003E5__6, _003CnotBefore_003E5__5, _003ClastBeatEnd_003E5__4);
				bool flag54 = !flag53;
				num4 = _003ClastBeatEnd_003E5__4;
				num22 = _003CnotBefore_003E5__5;
				num37 = _003CnextBeatAt_003E5__6;
				if (flag54)
				{
					object obj143 = this + 24;
					obj143 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					result = true;
					goto IL_268e;
				}
			}
			object obj144 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+E4]");
			bool flag55 = (nint)0 == 0;
			object obj145 = !flag55;
			if (obj145 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj144 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+A0]");
			object obj146 = 0;
			object obj160;
			object obj161;
			if (obj146 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+E4]");
				bool flag56 = (nint)0 == 0;
				object obj147 = !flag56;
				if (obj147 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj144 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+A0]");
					obj146 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v11+1]");
				bool flag57 = (nint)0 == 0;
				object obj148 = !flag57;
				if (obj148 == null)
				{
					_003C_003Ec__DisplayClass146_1 obj149 = _003C_003E8__2;
					if (_003C_003E8__2 != null)
					{
						_003C_003Ec__DisplayClass146_0 obj150 = obj149.CS_0024_003C_003E8__locals1;
						if (obj149.CS_0024_003C_003E8__locals1 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+E4]");
							bool flag58 = (nint)0 == 0;
							object obj151 = !flag58;
							if (obj151 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj144 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+A0]");
								obj146 = 0;
							}
							int mine3 = obj150.mine;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v11+B4]");
							if ((nint)mine3 != 0)
							{
								goto IL_25fe;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v11+E4]");
							bool flag59 = (nint)0 == 0;
							object obj152 = !flag59;
							if (obj152 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							RecheckTrust();
							bool flag60 = Tampered();
							bool flag61 = !flag60;
							object obj153 = !flag61;
							if (obj153 == null)
							{
								object obj154 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1721 @ X0_v22+E4]");
								bool flag62 = (nint)0 == 0;
								object obj155 = !flag62;
								if (obj155 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag63 = BeatDue(_003CnextBeatAt_003E5__6, _003CnotBefore_003E5__5, _003ClastBeatEnd_003E5__4);
								bool flag64 = !flag63;
								object obj156 = !flag64;
								num4 = _003ClastBeatEnd_003E5__4;
								num22 = _003CnotBefore_003E5__5;
								num37 = _003CnextBeatAt_003E5__6;
								num3 = _003ClastBeatEnd_003E5__4;
								text = text2;
								obj16 = obj17;
								float num = _003CnotBefore_003E5__5;
								float realtimeSinceStartup = _003CnextBeatAt_003E5__6;
								num6 = num7;
								if (obj156 != null)
								{
									goto IL_19c5;
								}
								goto IL_247a;
							}
							object obj157 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1749 @ X0_v17+E4]");
							bool flag65 = (nint)0 == 0;
							object obj158 = !flag65;
							if (obj158 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj157 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE968]");
							object obj159 = 0;
							obj160 = obj159;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1749 @ X0_v17+A0]");
							obj161 = (nint)0 + (nint)136;
							obj161 = obj159;
							_ = 3;
							goto IL_2a7b;
						}
					}
					goto IL_263e;
				}
			}
			goto IL_25fe;
			IL_0b4a:
			_003Cmisses_003E5__3 = 0;
			goto IL_2846;
			IL_25fe:
			result = false;
			goto IL_268e;
			IL_1c3d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
			bool flag66 = (nint)0 == 0;
			object obj162 = !flag66;
			if (obj162 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj125 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
			object obj163 = 0;
			if (obj163 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
				bool flag67 = (nint)0 == 0;
				object obj164 = !flag67;
				if (obj164 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj125 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
					obj163 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v43+1]");
				bool flag68 = (nint)0 == 0;
				object obj165 = !flag68;
				if (obj165 == null)
				{
					_003C_003Ec__DisplayClass146_1 obj166 = _003C_003E8__2;
					if (_003C_003E8__2 != null)
					{
						_003C_003Ec__DisplayClass146_0 obj167 = obj166.CS_0024_003C_003E8__locals1;
						if (obj166.CS_0024_003C_003E8__locals1 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
							bool flag69 = (nint)0 == 0;
							object obj168 = !flag69;
							if (obj168 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj125 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+A0]");
								obj163 = 0;
							}
							int mine4 = obj167.mine;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v43+B4]");
							if ((nint)mine4 != 0)
							{
								goto IL_25fe;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X0_v72+E4]");
							bool flag70 = (nint)0 == 0;
							object obj169 = !flag70;
							if (obj169 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj170 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ X8_v57+A0]");
								obj163 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v43+194]");
							_003CphotonSaidNo_003E5__7 = false;
							_ = 0;
							if (_003C_003E8__2 != null)
							{
								object obj171 = _003C_003E8__2 + 32;
								obj171 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								if (_003C_003E8__2 != null)
								{
									object obj172 = _003C_003E8__2 + 40;
									obj172 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (_003C_003E8__2 != null)
									{
										object obj173 = _003C_003E8__2 + 48;
										obj173 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										_003C_003Ec__DisplayClass146_1 obj174 = _003C_003E8__2;
										if (_003C_003E8__2 != null)
										{
											object obj175 = obj;
											obj174.status = 0L;
											obj174.serverWait = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X9_v29+A0]");
											object obj176 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF000]");
											object obj177 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ X9_v30+13C]");
											obj174.epoch = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											object obj178 = default;
											obj178._002Ector();
											if (obj178 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
												object obj179 = 0;
												object obj180 = obj178 + 16;
												obj180 = obj179;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj181 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1878 @ X8_v47+A0]");
												object obj182 = 0;
												object obj183 = obj178 + 24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1880 @ X8_v48+C0]");
												obj183 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												string body = JsonUtility.ToJson(obj178);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
												object obj184 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF010]");
												object obj185 = 0;
												Action<bool, System.__Canon> action2 = default;
												action2._002Ector((object)_003C_003E8__2, (IntPtr)obj185);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF070]");
												object path = 0;
												IEnumerator enumerator3 = SignedPost((string)path, body, (Action<bool, string>)action2, verifyReply: true);
												object obj186 = this + 24;
												obj186 = enumerator3;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												_ = 3;
												result = true;
												goto IL_268e;
											}
										}
									}
								}
							}
						}
					}
					goto IL_263e;
				}
			}
			goto IL_25fe;
			IL_2a7b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_25f4;
			IL_263e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_25f4:
			Logout();
			goto IL_25fe;
			IL_0cd2:
			object obj187 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X0_v170+E4]");
			object obj188;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X0_v170+A0]");
				obj188 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+20]");
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj189 = obj;
				_003C_003Ec__DisplayClass146_2 obj62 = _003C_003E8__3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X9_v51+A0]");
				obj188 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+20]");
				_ = 0;
				if (obj62 == null)
				{
					goto IL_263e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+18]");
			obj160 = 0;
			obj161 = obj188 + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v112 (ShiftAuth+<>c__DisplayClass146_2)+18]");
			obj161 = 0;
			goto IL_2a7b;
			IL_2a50:
			UnityEngine.Debug.LogWarning(message);
			num3 = num4;
			text = text2;
			obj16 = obj17;
			num6 = unchecked((nint)null);
			goto IL_247a;
			IL_247a:
			object obj190 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+E4]");
			bool flag71 = (nint)0 == 0;
			object obj191 = !flag71;
			if (obj191 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj190 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+A0]");
			object obj192 = 0;
			if (obj192 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+E4]");
				bool flag72 = (nint)0 == 0;
				object obj193 = !flag72;
				if (obj193 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj190 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+A0]");
					obj192 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X8_v30+1]");
				bool flag73 = (nint)0 == 0;
				object obj194 = !flag73;
				if (obj194 == null)
				{
					_003C_003Ec__DisplayClass146_0 obj195 = _003C_003E8__1;
					if (_003C_003E8__1 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v51+E4]");
						bool flag74 = (nint)0 == 0;
						object obj196 = !flag74;
						if (obj196 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj197 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ X8_v32+A0]");
							obj192 = 0;
						}
						int mine5 = obj195.mine;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ X8_v30+B4]");
						if ((nint)mine5 != 0)
						{
							goto IL_25fe;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj198 = default;
						obj198._002Ector();
						object obj199 = this + 40;
						obj199 = obj198;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (obj199 != null)
						{
							num7 = (nint)_003C_003E8__1;
							object obj200 = obj199 + 64;
							obj200 = _003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							float realtimeSinceStartup6 = Time.realtimeSinceStartup;
							float num41 = realtimeSinceStartup6 + 8f;
							_003Cuntil_003E5__8 = num41;
							num4 = num3;
							text2 = text;
							obj17 = obj16;
							goto IL_28c8;
						}
					}
					goto IL_263e;
				}
			}
			goto IL_25fe;
			IL_1c11:
			obj96 = this + 24;
			obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj97 = 2;
			goto IL_290f;
			IL_2922:
			object obj201 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X0_v302+E4]");
			bool flag75 = (nint)0 == 0;
			object obj202 = !flag75;
			if (obj202 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj201 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X0_v302+A0]");
			object obj203 = 0;
			_003C_003Ec__DisplayClass146_1 obj204 = _003C_003E8__2;
			if (_003C_003E8__2 != null)
			{
				object obj205;
				if (string.IsNullOrEmpty(obj204.banReason))
				{
					if (_003C_003E8__2 == null)
					{
						goto IL_263e;
					}
					obj205 = _003C_003E8__2 + 32;
				}
				else
				{
					if (_003C_003E8__2 == null)
					{
						goto IL_263e;
					}
					obj205 = _003C_003E8__2 + 48;
				}
				object obj206 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v306+E4]");
				bool flag76 = (nint)0 == 0;
				object obj207 = !flag76;
				if (obj207 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj206 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v306+A0]");
				object obj208 = (nint)0 + (nint)136;
				obj208 = obj205;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj209 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				string[] array3 = default;
				if (array3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF060]");
					object obj210 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
					_003C_003Ec__DisplayClass146_1 obj211 = _003C_003E8__2;
					if (_003C_003E8__2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
						object obj212 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						string text11 = ((Enum)(&obj87)).ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
						object obj213 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						string message4 = string.Concat(array3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj214 = 0;
						object obj215 = obj214;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v210+E4]");
						bool flag77 = (nint)0 == 0;
						object obj216 = !flag77;
						if (obj216 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Debug.LogWarning(message4);
						goto IL_25f4;
					}
				}
			}
			goto IL_263e;
			IL_2846:
			object obj217 = obj;
			_003Crefusals_003E5__2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X0_v250+E4]");
			bool flag78 = (nint)0 == 0;
			object obj218 = !flag78;
			if (obj218 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj217 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X0_v250+A0]");
			object obj219 = 0;
			_ = 0;
			obj219 = 0;
			float realtimeSinceStartup7 = Time.realtimeSinceStartup;
			object obj220 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ X8_v162+A0]");
			object obj221 = 0;
			float seconds2 = UnityEngine.Random.Range(1f, 20f);
			_003C_003Ec__DisplayClass146_1 obj222 = _003C_003E8__2;
			if (_003C_003E8__2 != null)
			{
				_003C_003Ec__DisplayClass146_0 obj223 = obj222.CS_0024_003C_003E8__locals1;
				if (obj222.CS_0024_003C_003E8__locals1 != null)
				{
					IEnumerator enumerator4 = WaitTrying(seconds2, obj223.mine);
					obj96 = this + 24;
					obj96 = enumerator4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj97 = 4;
					goto IL_290f;
				}
			}
			goto IL_263e;
			IL_290f:
			result = true;
			goto IL_268e;
			IL_268e:
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

	private sealed class _003CPlainPost_003Ed__188 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public string body;

		public Action<bool, string> done;

		private UnityWebRequest _003Crequest_003E5__2;

		private float _003Cbegan_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CPlainPost_003Ed__188(int _003C_003E1__state)
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

		private bool MoveNext()
		{
			//IL_03f0: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_042e: Expected Obj, but got I
			//IL_0458: Expected Obj, but got I4
			//IL_0826: Expected Obj, but got I
			//IL_0855: Expected Obj, but got I
			//IL_0873: Expected I, but got Obj
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_0081: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got I
			//IL_00ec: Expected Obj, but got I
			//IL_04db: Expected I, but got Obj
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got Unknown
			//IL_013c: Expected I4, but got I8
			//IL_04b4: Expected I, but got Obj
			//IL_016a: Expected I, but got Obj
			//IL_0509: Expected Obj, but got I8
			//IL_051d: Expected I, but got Obj
			//IL_08ab: Expected Obj, but got I4
			//IL_059c: Expected Obj, but got I4
			//IL_05a9: Expected I, but got Obj
			//IL_0180: Expected I, but got Obj
			//IL_01a9: Expected Obj, but got I
			//IL_01ef: Expected I, but got Obj
			//IL_0695: Expected Obj, but got I4
			//IL_06ac: Expected I, but got Obj
			//IL_021f: Expected Obj, but got I
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0650: Expected Obj, but got Unknown
			//IL_0659: Expected Obj, but got I4
			//IL_0621: Expected I, but got Obj
			//IL_025e: Expected I, but got Obj
			//IL_02a8: Expected I, but got Obj
			//IL_02c6: Expected Obj, but got I
			//IL_02d6: Expected Obj, but got I
			//IL_0319: Expected I, but got Obj
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Expected Obj, but got Unknown
			bool result;
			_003CPlainPost_003Ed__188 obj5 = default;
			nint num2 = default;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				result = false;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v66+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = Server();
					string url = text + obj5.path;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B0]");
					object obj7 = 0;
					string text2 = (string)obj7;
					UnityWebRequest unityWebRequest = default;
					unityWebRequest._002Ector(url, (string)obj7);
					object obj8 = obj5 + 56;
					obj8 = unityWebRequest;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5._003C_003E1__state = -3;
					Encoding uTF = Encoding.UTF8;
					bool flag3 = uTF == null;
					int num = 0;
					num2 = (nint)unityWebRequest;
					if (flag3)
					{
						goto IL_06fa;
					}
					nint num3 = (nint)uTF;
					((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)obj5.body, 0, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					UploadHandlerRaw uploadHandlerRaw = default;
					byte[] array = default;
					uploadHandlerRaw._002Ector(array);
					bool flag4 = obj5._003Crequest_003E5__2 == null;
					num = 0;
					text2 = null;
					num2 = (nint)array;
					if (flag4)
					{
						goto IL_0716;
					}
					obj5._003Crequest_003E5__2.uploadHandler = uploadHandlerRaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF098]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					DownloadHandlerBuffer downloadHandlerBuffer = default;
					downloadHandlerBuffer._002Ector();
					bool flag5 = obj5._003Crequest_003E5__2 == null;
					num = 0;
					text2 = null;
					num2 = unchecked((nint)null);
					if (flag5)
					{
						goto IL_0724;
					}
					obj5._003Crequest_003E5__2.downloadHandler = downloadHandlerBuffer;
					bool flag6 = obj5._003Crequest_003E5__2 == null;
					num = 0;
					text2 = null;
					num2 = (nint)downloadHandlerBuffer;
					if (flag6)
					{
						goto IL_0732;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0C0]");
					object obj12 = 0;
					text2 = (string)obj12;
					obj5._003Crequest_003E5__2.SetRequestHeader((string)obj11, (string)obj12);
					bool flag7 = obj5._003Crequest_003E5__2 == null;
					num = 0;
					num2 = (nint)obj11;
					if (flag7)
					{
						goto IL_0740;
					}
					obj5._003Crequest_003E5__2.timeout = 15;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					obj5._003Cbegan_003E5__3 = realtimeSinceStartup;
					bool flag8 = obj5._003Crequest_003E5__2 == null;
					num = 0;
					text2 = null;
					num2 = 15;
					if (flag8)
					{
						goto IL_074e;
					}
					UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = obj5._003Crequest_003E5__2.SendWebRequest();
					object obj13 = obj5 + 24;
					obj13 = unityWebRequestAsyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5._003C_003E1__state = 1;
					result = true;
				}
				goto IL_0811;
			}
			_003C_003E1__state = -3;
			if (_003Crequest_003E5__2 != null)
			{
				long responseCode = _003Crequest_003E5__2.responseCode;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v41+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v41+A0]");
				object obj17 = 0;
				float realtimeSinceStartup = RetryAfterOf(obj5._003Crequest_003E5__2);
				object obj18 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v19+A0]");
				object obj19 = 0;
				bool flag10 = obj5._003Crequest_003E5__2 == null;
				num2 = unchecked((nint)null);
				if (flag10)
				{
					goto IL_06ec;
				}
				UnityWebRequest.Result result2 = obj5._003Crequest_003E5__2.result;
				bool flag11;
				if (result2 == (UnityWebRequest.Result)1)
				{
					nint num4 = unchecked((nint)null);
					flag11 = true;
				}
				else
				{
					bool flag12 = obj5._003Crequest_003E5__2 == null;
					num2 = unchecked((nint)null);
					if (flag12)
					{
						goto IL_075c;
					}
					long responseCode2 = obj5._003Crequest_003E5__2.responseCode;
					object obj20 = responseCode2 - 403;
					bool flag13 = obj20 == null;
					nint num4 = unchecked((nint)null);
					flag11 = flag13;
				}
				object obj21 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v46+E4]");
				bool flag14 = (nint)0 == 0;
				object obj22 = !flag14;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NoteHttp(obj5.path, obj5._003Crequest_003E5__2, obj5._003Cbegan_003E5__3, flag11);
				UnityWebRequest unityWebRequest2 = obj5._003Crequest_003E5__2;
				bool flag15 = obj5._003Crequest_003E5__2 == null;
				realtimeSinceStartup = obj5._003Cbegan_003E5__3;
				int num = 0;
				string text2 = (string)flag11;
				num2 = (nint)obj5._003Crequest_003E5__2;
				if (flag15)
				{
					goto IL_0708;
				}
				Action<bool, string> action = obj5.done;
				if (unityWebRequest2.m_DownloadHandler != null)
				{
					string text3 = unityWebRequest2.m_DownloadHandler.text;
					bool flag16 = obj5.done == null;
					string text4 = text3;
					text2 = text3;
					num2 = unchecked((nint)null);
					if (!flag16)
					{
						goto IL_062f;
					}
				}
				else
				{
					bool flag17 = obj5.done == null;
					object obj23 = !flag17;
					string text4 = null;
					text2 = null;
					num2 = (nint)obj5._003Crequest_003E5__2;
					if (obj23 != null)
					{
						goto IL_062f;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				realtimeSinceStartup = obj5._003Cbegan_003E5__3;
				num = 0;
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_06ec;
			IL_0668:
			result = false;
			goto IL_0811;
			IL_062f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ X20_v18 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
			obj5._003C_003Em__Finally1();
			object obj24 = obj5 + 56;
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_0668;
			IL_0811:
			return result;
			IL_0716:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0724;
			IL_0724:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0732;
			IL_06ec:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_06fa;
			IL_0740:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_074e;
			IL_0732:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0740;
			IL_06fa:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0708;
			IL_074e:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_075c;
			IL_0708:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_0716;
			IL_075c:
			NullReferenceException ex11 = new NullReferenceException();
			bool flag18 = num2 != 1;
			NullReferenceException ex12 = ex11;
			if (!flag18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj25 = default;
				if (obj25 == null)
				{
					goto IL_0668;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0588");
				OutOfMemoryException ex13 = new OutOfMemoryException();
				ex12 = (NullReferenceException)(object)ex13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0460");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result3 = default;
			return result3;
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

	private sealed class _003CRefreshPhotonTicket_003Ed__158 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<bool, string> done;

		private _003C_003Ec__DisplayClass158_0 _003C_003E8__1;

		private string _003CforSession_003E5__2;

		private int _003Cepoch_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CRefreshPhotonTicket_003Ed__158(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_06c8: Expected Obj, but got I
			//IL_06d7: Expected I4, but got I8
			//IL_0f22: Expected Obj, but got I4
			//IL_03bd: Expected Obj, but got I
			//IL_03cc: Expected I4, but got I8
			//IL_10d3: Expected Obj, but got I
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected Obj, but got Unknown
			//IL_0409: Expected I, but got Obj
			//IL_0941: Expected Obj, but got I4
			//IL_06fe: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I
			//IL_00cc: Expected I4, but got I8
			//IL_00f6: Expected Obj, but got I4
			//IL_041e: Expected Obj, but got I
			//IL_0448: Expected Obj, but got I4
			//IL_072d: Expected Obj, but got I4
			//IL_0c02: Expected Obj, but got I
			//IL_0d52: Expected Obj, but got I
			//IL_005e: Expected I4, but got I8
			//IL_0969: Expected Obj, but got I
			//IL_0981: Expected Obj, but got I
			//IL_0f4a: Expected Obj, but got I
			//IL_0f76: Expected Obj, but got I4
			//IL_0bce: Expected I4, but got Obj
			//IL_0519: Expected Obj, but got I4
			//IL_099f: Expected Obj, but got I
			//IL_09c9: Expected Obj, but got I4
			//IL_0755: Expected Obj, but got I
			//IL_0dd7: Expected Obj, but got I
			//IL_0df9: Expected Obj, but got I4
			//IL_04a0: Expected Obj, but got I4
			//IL_104f: Expected Obj, but got I
			//IL_105a: Unknown result type (might be due to invalid IL or missing references)
			//IL_105f: Expected Obj, but got Unknown
			//IL_106f: Expected Obj, but got I
			//IL_1091: Expected Obj, but got I
			//IL_0d87: Expected Obj, but got I
			//IL_0da7: Invalid comparison between F4 and I4
			//IL_0db9: Expected F4, but got I4
			//IL_0159: Expected Obj, but got I4
			//IL_0560: Expected Obj, but got I4
			//IL_0a04: Expected Obj, but got I
			//IL_0a0d: Expected Obj, but got I4
			//IL_07a9: Expected Obj, but got I4
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Expected Obj, but got Unknown
			//IL_04d9: Expected Obj, but got I4
			//IL_0189: Expected Obj, but got I
			//IL_0590: Expected Obj, but got I
			//IL_0a56: Expected Obj, but got I
			//IL_07e1: Expected Obj, but got I4
			//IL_01b0: Expected Obj, but got I4
			//IL_05c8: Expected Obj, but got I4
			//IL_0fbd: Expected Obj, but got I
			//IL_0fd3: Expected Obj, but got I
			//IL_0e34: Expected Obj, but got I
			//IL_0e44: Expected F4, but got I
			//IL_0e54: Invalid comparison between F4 and I
			//IL_01e0: Expected Obj, but got I
			//IL_0aa9: Expected Obj, but got I
			//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab7: Expected Obj, but got Unknown
			//IL_0ae1: Expected Obj, but got I
			//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aef: Expected Obj, but got Unknown
			//IL_0aff: Expected Obj, but got I
			//IL_081e: Expected Obj, but got I
			//IL_0863: Invalid comparison between F4 and I4
			//IL_0872: Invalid comparison between F4 and I4
			//IL_0885: Expected Obj, but got F4
			//IL_0892: Expected Obj, but got F4
			//IL_08c6: Expected Obj, but got I
			//IL_08df: Expected Obj, but got I4
			//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ec: Expected Obj, but got Unknown
			//IL_0207: Expected Obj, but got I4
			//IL_060f: Expected Obj, but got I4
			//IL_0b2b: Expected Obj, but got I
			//IL_101d: Expected F4, but got I4
			//IL_0c8e: Expected Obj, but got I
			//IL_0e8f: Expected Obj, but got I
			//IL_0eb5: Expected Obj, but got I
			//IL_0ec5: Expected F4, but got I
			//IL_0b4a: Expected Obj, but got I
			//IL_0b5d: Expected I, but got Obj
			//IL_0b6d: Expected Obj, but got I
			//IL_0237: Expected Obj, but got I
			//IL_063f: Expected Obj, but got I
			//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b97: Expected Obj, but got Unknown
			//IL_0bb2: Expected Obj, but got I4
			//IL_0654: Expected Obj, but got I
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Expected Obj, but got Unknown
			//IL_06aa: Expected Obj, but got I4
			//IL_028f: Expected Obj, but got I4
			//IL_0cd5: Expected Obj, but got I
			//IL_0cfc: Expected Obj, but got I
			//IL_0d26: Expected Obj, but got I4
			//IL_02f6: Expected Obj, but got I
			//IL_0311: Expected Obj, but got I
			//IL_0340: Expected Obj, but got I
			bool result;
			object obj23;
			if (_003C_003E1__state <= 1)
			{
				if (_003C_003E1__state != 0)
				{
					bool flag = _003C_003E1__state != 1;
					result = false;
					if (flag)
					{
						goto IL_0bed;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0D8]");
					object obj = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj2 = default;
					obj2._002Ector();
					object obj3 = this + 40;
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					nint num = (nint)obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v79+17C]");
				if ((nint)0 != 0)
				{
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+A0]");
					object obj9 = 0;
					float num2 = realtimeSinceStartup;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v100+170]");
					float num3 = num2 - 0f;
					bool flag4 = !(num3 < 1.1093934E+09f);
					float num4 = 1.1093934E+09f;
					if (!flag4)
					{
						object obj10 = this + 24;
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						result = true;
						goto IL_0bed;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v84+1]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v93+E4]");
					bool flag7 = (nint)0 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj15 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v97+A0]");
						obj12 = 0;
					}
					if (obj12 != null)
					{
						float realtimeSinceStartup2 = Time.realtimeSinceStartup;
						object obj16 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v97+E4]");
						bool flag8 = (nint)0 == 0;
						object obj17 = !flag8;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj16 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v97+A0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v88+168]");
						float num3 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v88+168]");
						if (!(realtimeSinceStartup2 < 0f))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v97+E4]");
							bool flag9 = (nint)0 == 0;
							object obj19 = !flag9;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj20 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v95+A0]");
								obj18 = 0;
							}
							_ = 1;
							float realtimeSinceStartup3 = Time.realtimeSinceStartup;
							object obj21 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v89+A0]");
							object obj22 = 0;
							num3 = Time.realtimeSinceStartup;
							obj23 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+A0]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v91+16C]");
							float num4 = 0f;
							float num5 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v91+16C]");
							float num6 = num5 - 0f;
							if ((double)num6 < 5.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								float time = 5f - num6;
								WaitForSecondsRealtime waitForSecondsRealtime = default;
								waitForSecondsRealtime._002Ector(time);
								object obj26 = this + 24;
								obj26 = waitForSecondsRealtime;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj27 = 2;
								result = true;
								goto IL_0bed;
							}
							goto IL_0f00;
						}
					}
				}
				goto IL_0f84;
			}
			if (_003C_003E1__state != 2)
			{
				bool flag10 = _003C_003E1__state != 3;
				result = false;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj28 = 0;
					_003C_003E1__state = -1;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+E4]");
					bool flag11 = (nint)0 == 0;
					object obj30 = !flag11;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj29 = obj28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+A0]");
					object obj31 = 0;
					_003C_003Ec__DisplayClass158_0 obj32 = _003C_003E8__1;
					_ = 0;
					if (_003C_003E8__1 != null)
					{
						if (~(obj32.got ? 1u : 0u) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+E4]");
							bool flag12 = (nint)0 == 0;
							object obj33 = !flag12;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+A0]");
								obj31 = 0;
							}
							int num7 = _003Cepoch_003E5__3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v63+13C]");
							if ((nint)num7 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+E4]");
								bool flag13 = (nint)0 == 0;
								object obj34 = !flag13;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj29 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+A0]");
									obj31 = 0;
								}
								if (obj31 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v60+E4]");
									bool flag14 = (nint)0 == 0;
									object obj35 = !flag14;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj36 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v73+A0]");
										obj31 = 0;
									}
									string text = _003CforSession_003E5__2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v63+20]");
									bool flag15 = text == (string)0;
									bool flag16 = !flag15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v63+20]");
									nint num = 0;
									if (!flag16)
									{
										_003C_003Ec__DisplayClass158_0 obj37 = _003C_003E8__1;
										if (_003C_003E8__1 != null)
										{
											object obj38 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v65+E4]");
											bool flag17 = (nint)0 == 0;
											object obj39 = !flag17;
											if (obj39 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj38 = obj28;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v65+A0]");
											object obj40 = (nint)0 + (nint)40;
											obj40 = obj37.fresh;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
											object obj41 = 0;
											object obj42 = obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v69+E4]");
											bool flag18 = (nint)0 == 0;
											object obj43 = !flag18;
											if (obj43 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											DateTimeOffset utcNow = DateTimeOffset.UtcNow;
											DateTimeOffset dateTimeOffset = default;
											long num8 = dateTimeOffset.ToUnixTimeSeconds();
											object obj44 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v68+A0]");
											object obj45 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v68+A0]");
											object obj46 = (nint)0 + (nint)384;
											_ = 1;
											_ = _003CforSession_003E5__2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj47 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v70+A0]");
											object obj48 = 0;
											_003C_003Ec__DisplayClass158_0 obj49 = _003C_003E8__1;
											_ = 0;
											_ = 0;
											if (_003C_003E8__1 != null)
											{
												Action<bool, string> action = done;
												if (done != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X9_v31 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
													goto IL_0d34;
												}
											}
										}
										goto IL_0bc0;
									}
								}
							}
						}
						_003C_003Ec__DisplayClass158_0 obj50 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							bool flag19 = (byte)(~(obj50.got ? 1u : 0u)) != 0;
							object obj51 = !flag19;
							if (obj51 == null)
							{
								object obj52 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v54+E4]");
								bool flag20 = (nint)0 == 0;
								object obj53 = !flag20;
								if (obj53 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj52 = obj28;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v54+A0]");
								object obj54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v54+178]");
								object obj55 = (nint)0 + (nint)1;
								float realtimeSinceStartup4 = Time.realtimeSinceStartup;
								if (_003C_003E8__1 == null)
								{
									goto IL_0bc0;
								}
								object obj56 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X9_v22+A0]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v57+178]");
								float num9 = Backoff(0, 5f, 120f);
								float num11 = default;
								float num10 = num11 - num9;
								bool flag21 = num10 < 0f;
								bool flag22 = num10 == 0f;
								object obj58 = num11 ^ num9;
								object obj59 = num11 ^ num10;
								object obj60 = obj58 & obj59;
								bool flag23 = (nint)obj60 < 0;
								object obj61 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v59+A0]");
								object obj62 = 0;
								bool flag24 = flag21 == flag23;
								object obj63 = !flag22;
								object obj64 = flag24 & obj63;
								object obj65 = ~obj64;
								if (obj65 == null)
								{
									num9 = num11;
								}
								float num3 = realtimeSinceStartup4 + num9;
								float num4 = 1.1230249E+09f;
							}
							goto IL_0f84;
						}
					}
					goto IL_0bc0;
				}
				goto IL_0bed;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj66 = 0;
			_003C_003E1__state = -1;
			obj23 = obj66;
			goto IL_0f00;
			IL_0f84:
			Action<bool, string> action2 = done;
			if (done != null)
			{
				goto IL_0910;
			}
			goto IL_0bc0;
			IL_0f00:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+E4]");
			bool flag25 = (nint)0 == 0;
			object obj67 = !flag25;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj68 = 0;
				obj23 = obj68;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+A0]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v11+1]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+E4]");
				bool flag26 = (nint)0 == 0;
				object obj70 = !flag26;
				if (obj70 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj71 = 0;
					obj23 = obj71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+A0]");
					obj69 = 0;
				}
				if (obj69 != null)
				{
					float realtimeSinceStartup5 = Time.realtimeSinceStartup;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj72 = 0;
					object obj73 = obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v9+E4]");
					bool flag27 = (nint)0 == 0;
					object obj74 = !flag27;
					if (obj74 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj73 = obj72;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v9+A0]");
					object obj75 = 0;
					object obj76 = this + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v14+20]");
					obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj77 = obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v15+A0]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v16+13C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X20_v7-8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X20_v7-8]");
						object obj79 = (nint)0 + (nint)24;
						obj79 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_003C_003Ec__DisplayClass158_0 obj80 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF000]");
							object obj81 = 0;
							obj80.serverWait = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							object obj82 = default;
							obj82._002Ector();
							if (obj82 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
								object obj83 = 0;
								object obj84 = obj82 + 16;
								obj84 = obj83;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj85 = obj72;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v21+A0]");
								object obj86 = 0;
								object obj87 = obj82 + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v22+C0]");
								obj87 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string body = JsonUtility.ToJson(obj82);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
								object obj88 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0D0]");
								object obj89 = 0;
								Action<bool, System.__Canon> action3 = default;
								action3._002Ector((object)_003C_003E8__1, (IntPtr)obj89);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0E0]");
								object path = 0;
								IEnumerator enumerator = SignedPost((string)path, body, (Action<bool, string>)action3, verifyReply: true);
								object obj26 = this + 24;
								obj26 = enumerator;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj27 = 3;
								result = true;
								goto IL_0bed;
							}
						}
					}
					goto IL_0bc0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+E4]");
			bool flag28 = (nint)0 == 0;
			object obj90 = !flag28;
			if (obj90 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj91 = 0;
				obj23 = obj91;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+A0]");
			object obj92 = 0;
			action2 = done;
			_ = 0;
			bool flag29 = done == null;
			object obj93 = !flag29;
			if (obj93 != null)
			{
				goto IL_0910;
			}
			goto IL_0bc0;
			IL_0bed:
			return result;
			IL_0bc0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0910:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v566 @ X8_v45 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
			goto IL_0d34;
			IL_0d34:
			result = false;
			goto IL_0bed;
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

	private sealed class _003CReportKick_003Ed__159 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string targetPlayFabId;

		public string targetName;

		public string reason;

		public string details;

		public string roomName;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CReportKick_003Ed__159(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0625: Expected I4, but got I8
			//IL_05dc: Expected I4, but got I8
			//IL_05e5: Expected F4, but got I4
			//IL_1534: Expected Obj, but got I
			//IL_155e: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got I4
			//IL_103a: Expected Obj, but got I
			//IL_064c: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I
			//IL_0076: Expected I4, but got I8
			//IL_00a0: Expected Obj, but got I4
			//IL_0d4a: Expected Obj, but got I
			//IL_0d6c: Expected Obj, but got I4
			//IL_067c: Expected Obj, but got I
			//IL_0691: Expected Obj, but got I
			//IL_00e7: Expected Obj, but got I4
			//IL_0117: Expected Obj, but got I
			//IL_06db: Expected Obj, but got I
			//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e9: Expected Obj, but got Unknown
			//IL_0725: Expected Obj, but got I4
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_108c: Expected Obj, but got I
			//IL_1095: Unknown result type (might be due to invalid IL or missing references)
			//IL_109a: Expected Obj, but got Unknown
			//IL_10aa: Expected Obj, but got I
			//IL_10c4: Expected Obj, but got I
			//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d2: Expected Obj, but got Unknown
			//IL_10f4: Expected Obj, but got I
			//IL_1104: Expected Obj, but got I
			//IL_0da7: Expected Obj, but got I
			//IL_0db7: Expected Obj, but got I
			//IL_112f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1134: Expected Obj, but got Unknown
			//IL_1156: Expected Obj, but got I
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected Obj, but got Unknown
			//IL_0e20: Expected Obj, but got I4
			//IL_1181: Unknown result type (might be due to invalid IL or missing references)
			//IL_1186: Expected Obj, but got Unknown
			//IL_0e3e: Expected Obj, but got I
			//IL_0e5e: Expected Obj, but got I4
			//IL_019a: Expected Obj, but got I
			//IL_11c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c8: Expected Obj, but got Unknown
			//IL_11ea: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_0287: Expected Obj, but got I4
			//IL_1215: Unknown result type (might be due to invalid IL or missing references)
			//IL_121a: Expected Obj, but got Unknown
			//IL_0e84: Expected Obj, but got I
			//IL_0ea4: Invalid comparison between F4 and I4
			//IL_0eb3: Invalid comparison between F4 and I4
			//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ece: Expected Obj, but got Unknown
			//IL_0edb: Expected Obj, but got F4
			//IL_0f10: Expected Obj, but got I4
			//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f1d: Expected Obj, but got Unknown
			//IL_02c9: Expected F4, but got I
			//IL_1257: Unknown result type (might be due to invalid IL or missing references)
			//IL_125c: Expected Obj, but got Unknown
			//IL_128b: Expected Obj, but got I
			//IL_12b5: Expected Obj, but got I4
			//IL_0f4c: Invalid comparison between F4 and I4
			//IL_12d3: Expected Obj, but got I
			//IL_12e3: Expected Obj, but got I
			//IL_1305: Expected Obj, but got I4
			//IL_130d: Expected I, but got Obj
			//IL_086e: Expected Obj, but got I4
			//IL_02f0: Expected Obj, but got I4
			//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b0: Expected Obj, but got Unknown
			//IL_080f: Expected Obj, but got I4
			//IL_0f98: Expected Obj, but got Ref
			//IL_1330: Expected Obj, but got I
			//IL_134a: Expected Obj, but got I
			//IL_1352: Expected I, but got Obj
			//IL_1363: Expected I, but got Obj
			//IL_1381: Expected Obj, but got I
			//IL_13a4: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got I
			//IL_083f: Expected Obj, but got I
			//IL_0335: Expected Obj, but got I
			//IL_034e: Expected Obj, but got I
			//IL_0369: Expected Obj, but got Ref
			//IL_0c05: Expected Obj, but got I4
			//IL_14ff: Expected Obj, but got I
			//IL_0387: Expected Obj, but got I
			//IL_03a1: Expected Obj, but got I
			//IL_03e1: Expected Obj, but got I4
			//IL_0c3a: Expected Obj, but got I
			//IL_0c6b: Expected Obj, but got I
			//IL_0fbe: Expected Obj, but got I
			//IL_0fdd: Expected Obj, but got Ref
			//IL_0c9a: Expected Obj, but got I
			//IL_0418: Expected Obj, but got I
			//IL_042c: Expected Obj, but got I
			//IL_043c: Expected Obj, but got I
			//IL_0444: Expected Obj, but got Ref
			//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc1: Expected Obj, but got Unknown
			//IL_101c: Expected F4, but got VT
			//IL_0459: Invalid comparison between F4 and VT
			//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e6: Expected Obj, but got I
			//IL_09f6: Expected Obj, but got I
			//IL_0acf: Expected Obj, but got I4
			//IL_1465: Expected Obj, but got I
			//IL_148c: Expected VT, but got Ref
			//IL_0a25: Expected Obj, but got I4
			//IL_13e7: Expected Obj, but got I
			//IL_095d: Expected VT, but got Ref
			//IL_0965: Expected F4, but got VT
			//IL_0b0d: Expected Obj, but got I
			//IL_0b30: Expected VT, but got Ref
			//IL_0511: Expected Obj, but got I4
			//IL_0a8e: Expected VT, but got Ref
			//IL_0a67: Expected Obj, but got I
			//IL_0994: Expected F4, but got VT
			//IL_092e: Expected Obj, but got I4
			//IL_0936: Expected F4, but got VT
			//IL_0593: Expected Obj, but got I
			//IL_05a3: Expected Obj, but got I
			//IL_05b3: Expected Obj, but got I
			//IL_0b70: Expected Obj, but got I4
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Expected Obj, but got Unknown
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0564: Expected Obj, but got Unknown
			//IL_14b2: Expected Obj, but got I
			//IL_14d9: Expected VT, but got Ref
			//IL_0ba5: Expected Obj, but got I
			//IL_0bbe: Expected Obj, but got I
			//IL_0bce: Expected VT, but got Ref
			bool result;
			object obj2;
			float realtimeSinceStartup;
			string text3;
			float num5;
			float num6;
			object obj29;
			List<System.__Canon> list = default;
			System.__Canon key;
			Dictionary<System.__Canon, float>.Enumerator enumerator5 = default;
			System.__Canon _Canon = default;
			string text2 = default;
			string text;
			Dictionary<System.__Canon, float>.Enumerator enumerator3 = default;
			float num;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					result = false;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						obj2 = 0;
						_003C_003E1__state = -1;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v76+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj3 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v76+A0]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v51+1]");
						bool flag3 = (nint)0 == 0;
						object obj6 = !flag3;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v76+E4]");
							bool flag4 = (nint)0 == 0;
							object obj7 = !flag4;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj8 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v111+A0]");
								obj5 = 0;
							}
							if (obj5 != null)
							{
								realtimeSinceStartup = Time.realtimeSinceStartup;
								object obj9 = this + 32;
								if (string.IsNullOrEmpty((string)obj9))
								{
									object obj10 = this + 40;
									if (obj10 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										obj9 = 0;
									}
									else
									{
										obj9 = obj10;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF140]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
								object obj12 = 0;
								text = (string)obj12;
								text2 = (string)((reason != null) ? reason : obj11);
								text3 = (string)obj9 + text + text2;
								object obj13 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v58+E4]");
								bool flag5 = (nint)0 == 0;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj13 = obj2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v58+A0]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v59+150]");
								bool flag6 = (nint)0 == 0;
								object obj16 = 0;
								num = realtimeSinceStartup;
								if (!flag6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE48]");
									object obj17 = 0;
									obj16 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v59+150]");
									bool flag7 = ((Dictionary<System.__Canon, float>)0).TryGetValue((System.__Canon)(object)text3, out var value);
									bool flag8 = !flag7;
									float num2 = realtimeSinceStartup;
									if (!flag8)
									{
										bool flag9 = realtimeSinceStartup < value;
										num2 = value;
										if (flag9)
										{
											goto IL_0601;
										}
									}
									object obj18 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v87+E4]");
									bool flag10 = (nint)0 == 0;
									object obj19 = !flag10;
									if (obj19 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj18 = obj2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v87+A0]");
									object obj20 = 0;
									float num3 = realtimeSinceStartup;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v64+158]");
									float num4 = num3 - 0f;
									bool flag11 = num4 < 0f;
									bool flag12 = num4 == 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v64+158]");
									object obj21 = realtimeSinceStartup ^ 0;
									object obj22 = realtimeSinceStartup ^ num4;
									object obj23 = obj21 & obj22;
									bool flag13 = (nint)obj23 < 0;
									bool flag14 = flag11 == flag13;
									object obj24 = !flag12;
									object obj25 = flag14 & obj24;
									object obj26 = ~obj25;
									if (obj26 == null)
									{
										num5 = realtimeSinceStartup;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v64+158]");
										num5 = 0f;
									}
									num6 = num5 - realtimeSinceStartup;
									if (num6 > 1.1146363E+09f)
									{
										goto IL_0601;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v87+E4]");
									bool flag15 = (nint)0 == 0;
									object obj27 = !flag15;
									if (obj27 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj28 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v106+A0]");
										obj20 = 0;
									}
									num = num5 + 6f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v64+150]");
									bool flag16 = (nint)0 == 0;
									text2 = (string)(&value);
									text = text3;
									if (!flag16)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF100]");
										obj29 = 0;
										text = (string)obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v64+150]");
										int count = ((Dictionary<System.__Canon, float>)0).Count;
										bool flag17 = count < 100;
										text2 = (string)(&value);
										if (flag17)
										{
											goto IL_0bdb;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
										object obj31 = 0;
										text = (string)obj31;
										list._002Ector();
										object obj32 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X0_v106+E4]");
										bool flag18 = (nint)0 == 0;
										object obj33 = !flag18;
										if (obj33 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj32 = obj2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X0_v106+A0]");
										object obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v79+150]");
										bool flag19 = (nint)0 == 0;
										text2 = (string)(&value);
										if (!flag19)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v79+150]");
											Dictionary<System.__Canon, float>.Enumerator enumerator = ((Dictionary<System.__Canon, float>)0).GetEnumerator();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF110]");
											object obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
											object obj36 = 0;
											text2 = (string)(&value);
											Dictionary<System.__Canon, float>.Enumerator enumerator2 = enumerator3;
											Dictionary<System.__Canon, float>.Enumerator enumerator4 = default;
											while (true)
											{
												text = (string)obj35;
												bool flag20 = enumerator4.MoveNext();
												bool flag21 = !flag20;
												key = null;
												num = (float)enumerator2;
												if (flag21)
												{
													break;
												}
												bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)realtimeSinceStartup) < System.Runtime.CompilerServices.Unsafe.As<Dictionary<System.__Canon, float>.Enumerator, UIntPtr>(ref enumerator5);
												enumerator2 = enumerator5;
												if (flag22)
												{
													continue;
												}
												if (list != null)
												{
													System.__Canon[] items = list._items;
													object obj37 = obj36;
													int version = list._version + 1;
													list._version = version;
													bool flag23 = list._items == null;
													text = (string)(object)_Canon;
													if (!flag23)
													{
														bool flag24 = list._size < items.Length;
														object obj38 = !flag24;
														if (obj38 == null)
														{
															object obj39 = list._items + list._size;
															int size = list._size + 1;
															list._size = size;
															object obj40 = obj39 + 32;
															obj40 = _Canon;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															enumerator2 = enumerator5;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X9_v33+20]");
															object obj41 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X8_v104+A8]");
															object obj42 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v105+70]");
															text2 = (string)0;
															list.AddWithResize(_Canon);
															enumerator2 = enumerator5;
														}
														continue;
													}
												}
												goto IL_08de;
											}
											goto IL_0999;
										}
									}
								}
								goto IL_0cea;
							}
						}
						goto IL_0601;
					}
					goto IL_0d35;
				}
				_003C_003E1__state = -1;
				num = 0f;
				goto IL_1524;
			}
			result = false;
			int num7 = -1;
			goto IL_13b1;
			IL_13c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0480");
			System.__Canon _Canon2 = _Canon;
			goto IL_0cf8;
			IL_1524:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj43 = 0;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v7+E4]");
			bool flag25 = (nint)0 == 0;
			object obj45 = !flag25;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj44 = obj43;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v7+A0]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+1]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v7+E4]");
				bool flag26 = (nint)0 == 0;
				object obj47 = !flag26;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj48 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v42+A0]");
					obj46 = 0;
				}
				if (obj46 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF130]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj50 = default;
					obj50._002Ector();
					bool flag27 = obj50 == null;
					text = null;
					if (flag27)
					{
						goto IL_0cea;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
					object obj51 = 0;
					object obj52 = obj50 + 16;
					obj52 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj53 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v15+E4]");
					bool flag28 = (nint)0 == 0;
					object obj54 = !flag28;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj53 = obj43;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v15+A0]");
					object obj55 = 0;
					object obj56 = obj50 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v17+C0]");
					obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF148]");
					object obj57 = 0;
					object obj58 = obj50 + 32;
					obj58 = obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF140]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF150]");
					object path = 0;
					string text4 = (string)((reason != null) ? reason : obj59);
					object obj60 = obj50 + 40;
					obj60 = text4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj61 = 0;
					string text5 = (string)((details != null) ? details : obj61);
					object obj62 = obj50 + 48;
					obj62 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text6 = (string)((targetPlayFabId != null) ? targetPlayFabId : obj61);
					object obj63 = obj50 + 56;
					obj63 = text6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A0]");
					object obj64 = 0;
					string text7 = (string)((targetName != null) ? targetName : obj64);
					object obj65 = obj50 + 64;
					obj65 = text7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text8 = (string)((roomName != null) ? roomName : obj61);
					object obj66 = obj50 + 72;
					obj66 = text8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string body = JsonUtility.ToJson(obj50);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDC8]");
					object obj67 = 0;
					object obj68 = obj67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v30+E4]");
					bool flag29 = (nint)0 == 0;
					object obj69 = !flag29;
					if (obj69 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj68 = obj67;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v30+A0]");
					object obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X9_v14+10]");
					Action<bool, string> done = (Action<bool, string>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X9_v14+10]");
					bool flag30 = (nint)0 == 0;
					object obj71 = !flag30;
					nint num8 = (nint)text2;
					Action<bool, System.__Canon> action = null;
					if (obj71 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X8_v30+E4]");
						bool flag31 = (nint)0 == 0;
						object obj72 = !flag31;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj73 = obj67;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X8_v40+A0]");
							obj70 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
						object obj74 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF138]");
						object obj75 = 0;
						num8 = (nint)obj75;
						Action<bool, System.__Canon> action2 = default;
						action2._002Ector(obj70, (IntPtr)obj75);
						object obj76 = obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v39+A0]");
						object obj77 = (nint)0 + (nint)16;
						obj77 = action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						done = (Action<bool, string>)action2;
						object obj16 = 0;
						action = action2;
					}
					object obj78 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X0_v41+E4]");
					bool flag32 = (nint)0 == 0;
					object obj79 = !flag32;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					IEnumerator enumerator6 = SignedPost((string)path, body, done, verifyReply: false);
					object obj80 = this + 24;
					obj80 = enumerator6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = true;
					num7 = 2;
					goto IL_13b1;
				}
			}
			goto IL_0601;
			IL_0bdb:
			object obj81 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X0_v93+E4]");
			bool flag33 = (nint)0 == 0;
			object obj82 = !flag33;
			if (obj82 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj81 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X0_v93+A0]");
			object obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v67+150]");
			if ((nint)0 == 0)
			{
				goto IL_0cea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE60]");
			object obj84 = 0;
			num = realtimeSinceStartup + 1.1422925E+09f;
			text2 = (string)obj84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v67+150]");
			((Dictionary<System.__Canon, float>)0).set_Item((System.__Canon)(object)text3, num);
			if (num5 > realtimeSinceStartup)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				WaitForSecondsRealtime waitForSecondsRealtime = default;
				waitForSecondsRealtime._002Ector(num6);
				object obj86 = this + 24;
				obj86 = waitForSecondsRealtime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = true;
				num7 = 1;
				goto IL_13b1;
			}
			goto IL_1524;
			IL_0999:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0480");
			bool flag34 = list == null;
			_Canon2 = _Canon;
			Enumerator<, > val = default;
			float num9 = default;
			if (!flag34)
			{
				Enumerator<, > enumerator7 = list.GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
				object obj87 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0F8]");
				object obj88 = 0;
				while (true)
				{
					text = (string)obj87;
					if (!val.MoveNext())
					{
						break;
					}
					object obj89 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X0_v137+E4]");
					bool flag35 = (nint)0 == 0;
					object obj90 = !flag35;
					if (obj90 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj89 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X0_v137+A0]");
					object obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v99+150]");
					if ((nint)0 != 0)
					{
						text2 = (string)obj88;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X8_v99+150]");
						bool flag36 = ((Dictionary<System.__Canon, float>)0).Remove(key);
						continue;
					}
					goto IL_0a70;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
				object obj92 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v126+E4]");
				bool flag37 = (nint)0 == 0;
				object obj93 = !flag37;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj92 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v126+A0]");
				object obj94 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v93+150]");
				bool flag38 = (nint)0 == 0;
				_Canon2 = _Canon;
				enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&val);
				num = num9;
				if (!flag38)
				{
					text = (string)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v93+150]");
					int count2 = ((Dictionary<System.__Canon, float>)0).Count;
					bool flag39 = count2 < 100;
					_Canon2 = _Canon;
					enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&val);
					num = num9;
					if (!flag39)
					{
						object obj95 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X0_v130+E4]");
						bool flag40 = (nint)0 == 0;
						object obj96 = !flag40;
						if (obj96 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj95 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X0_v130+A0]");
						object obj97 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v95+150]");
						bool flag41 = (nint)0 == 0;
						_Canon2 = _Canon;
						enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&val);
						num = num9;
						if (flag41)
						{
							goto IL_0cea;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBDD8]");
						object obj98 = 0;
						text = (string)obj98;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v95+150]");
						((Dictionary<System.__Canon, float>)0).Clear();
						_Canon2 = _Canon;
						enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&val);
						num = num9;
					}
					goto IL_0bdb;
				}
			}
			goto IL_0cea;
			IL_0a70:
			NullReferenceException ex = new NullReferenceException();
			NullReferenceException ex2 = ex;
			enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&val);
			num = num9;
			goto IL_13c0;
			IL_0cf8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_0601:
			result = false;
			goto IL_0d35;
			IL_08de:
			NullReferenceException ex3 = new NullReferenceException();
			if ((nint)text == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				key = (System.__Canon)1;
				num = (float)enumerator5;
			}
			else
			{
				bool flag42 = (nint)text != 1;
				ex2 = ex3;
				float num10 = default;
				enumerator3 = (Dictionary<System.__Canon, float>.Enumerator)(&num10);
				num = (float)enumerator5;
				if (flag42)
				{
					goto IL_13c0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				key = null;
				num = (float)enumerator5;
			}
			goto IL_0999;
			IL_13b1:
			_003C_003E1__state = num7;
			goto IL_0d35;
			IL_0cea:
			NullReferenceException ex4 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
			ex2 = ex4;
			goto IL_0cf8;
			IL_0d35:
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

	private sealed class _003CSignedPost_003Ed__191 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<bool, string> done;

		public string body;

		public string path;

		public bool verifyReply;

		private string _003CtokenAsked_003E5__2;

		private string _003CrequestNonce_003E5__3;

		private string _003CsigningSecret_003E5__4;

		private UnityWebRequest _003Crequest_003E5__5;

		private float _003Cbegan_003E5__6;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CSignedPost_003Ed__191(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 2)
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

		private bool MoveNext()
		{
			//IL_030b: Expected Obj, but got I
			//IL_031a: Expected I4, but got I8
			//IL_0344: Expected Obj, but got I4
			//IL_1b3e: Expected Obj, but got I
			//IL_012b: Expected I4, but got I8
			//IL_03a0: Expected Obj, but got I
			//IL_199f: Expected Obj, but got I
			//IL_19c9: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got I4
			//IL_03d4: Expected Obj, but got I
			//IL_03f2: Expected I, but got Obj
			//IL_1d74: Expected Obj, but got I
			//IL_0202: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I
			//IL_0076: Expected I4, but got I8
			//IL_00a0: Expected Obj, but got I4
			//IL_1a5a: Expected Obj, but got I
			//IL_1a6b: Expected Obj, but got I
			//IL_1a89: Expected Obj, but got I4
			//IL_1a8e: Expected I, but got Obj
			//IL_017a: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_0108: Expected Obj, but got I
			//IL_045e: Expected I, but got Obj
			//IL_02a0: Expected Obj, but got I4
			//IL_19e7: Expected Obj, but got I
			//IL_0437: Expected I, but got Obj
			//IL_1af3: Expected Obj, but got I
			//IL_0251: Expected Obj, but got I4
			//IL_048c: Expected Obj, but got I8
			//IL_04a0: Expected I, but got Obj
			//IL_1b90: Expected Obj, but got I4
			//IL_1aac: Expected Obj, but got I
			//IL_1abd: Expected Obj, but got I
			//IL_1ad5: Expected I, but got Obj
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected Obj, but got Unknown
			//IL_01b6: Expected Obj, but got I4
			//IL_01d2: Expected I, but got Obj
			//IL_052c: Expected I, but got Obj
			//IL_02ed: Expected I, but got Obj
			//IL_088d: Expected Obj, but got I4
			//IL_0ac5: Expected Obj, but got I4
			//IL_1ccd: Expected Obj, but got I
			//IL_1cec: Expected Obj, but got I
			//IL_1d0c: Expected Obj, but got I
			//IL_1d33: Expected Obj, but got I4
			//IL_08ca: Expected Obj, but got I4
			//IL_0595: Expected I, but got Obj
			//IL_1c69: Expected Obj, but got I
			//IL_1c79: Expected Obj, but got I
			//IL_1c93: Expected Obj, but got I
			//IL_0573: Expected I, but got Obj
			//IL_0b39: Expected Obj, but got I
			//IL_0b49: Expected Obj, but got I
			//IL_17d7: Expected Obj, but got I
			//IL_18c7: Expected I, but got Obj
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0821: Expected Obj, but got Unknown
			//IL_082a: Expected Obj, but got I4
			//IL_0959: Expected I4, but got I8
			//IL_0973: Expected Obj, but got I4
			//IL_0841: Expected I4, but got Obj
			//IL_0853: Expected I, but got Obj
			//IL_0621: Expected I, but got Obj
			//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb4: Expected Obj, but got Unknown
			//IL_0bda: Expected Obj, but got I8
			//IL_0bf1: Expected I, but got Obj
			//IL_09bd: Expected Obj, but got I4
			//IL_0a08: Expected I, but got Obj
			//IL_0c0f: Expected Obj, but got I
			//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1d: Expected Obj, but got Unknown
			//IL_0684: Expected Obj, but got I
			//IL_06aa: Expected Obj, but got I
			//IL_06ba: Expected Obj, but got I
			//IL_0c62: Expected Obj, but got I4
			//IL_0c72: Expected Obj, but got I4
			//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c97: Expected Obj, but got Unknown
			//IL_0c9f: Expected I, but got Obj
			//IL_0a2e: Expected Obj, but got I
			//IL_0a51: Expected Obj, but got I
			//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a63: Expected Obj, but got Unknown
			//IL_1c4b: Expected Obj, but got I4
			//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Expected Obj, but got Unknown
			//IL_0ce1: Expected Obj, but got I8
			//IL_0cf8: Expected I, but got Obj
			//IL_0745: Expected Obj, but got I4
			//IL_0753: Expected I, but got Obj
			//IL_0d0e: Expected I, but got Obj
			//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1c: Expected Obj, but got Unknown
			//IL_0d4a: Expected Obj, but got I4
			//IL_0d5a: Expected Obj, but got I4
			//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7f: Expected Obj, but got Unknown
			//IL_07ca: Expected Obj, but got I
			//IL_0792: Expected I, but got Obj
			//IL_07ac: Expected I, but got Obj
			//IL_0da5: Expected Obj, but got I
			//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc3: Expected Obj, but got Unknown
			//IL_0dd3: Expected Obj, but got I
			//IL_0df9: Expected Obj, but got I4
			//IL_0e09: Expected Obj, but got I4
			//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2e: Expected Obj, but got Unknown
			//IL_0e44: Expected I, but got Obj
			//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e52: Expected Obj, but got Unknown
			//IL_0e80: Expected Obj, but got I4
			//IL_0e90: Expected Obj, but got I4
			//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb5: Expected Obj, but got Unknown
			//IL_0edb: Expected Obj, but got I
			//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee9: Expected Obj, but got Unknown
			//IL_0ef9: Expected Obj, but got I
			//IL_0f2a: Expected Obj, but got I
			//IL_0f4c: Expected Obj, but got I
			//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6b: Expected Obj, but got Unknown
			//IL_0f9a: Expected Obj, but got I
			//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa8: Expected Obj, but got Unknown
			//IL_0fb8: Expected Obj, but got I
			//IL_0fda: Expected Obj, but got I
			//IL_0ff0: Expected I8, but got I
			//IL_1029: Expected Obj, but got I
			//IL_1048: Expected Obj, but got I
			//IL_1062: Unknown result type (might be due to invalid IL or missing references)
			//IL_1067: Expected Obj, but got Unknown
			//IL_1090: Expected I4, but got I8
			//IL_10b0: Expected I4, but got Obj
			//IL_10d7: Expected I, but got Obj
			//IL_1100: Expected Obj, but got I
			//IL_117a: Expected Obj, but got I
			//IL_1229: Expected Obj, but got I
			//IL_1239: Expected Obj, but got I
			//IL_126b: Expected I4, but got Obj
			//IL_129a: Expected Obj, but got I
			//IL_12aa: Expected Obj, but got I
			//IL_12dc: Expected I4, but got Obj
			//IL_1313: Expected Obj, but got I
			//IL_1323: Expected Obj, but got I
			//IL_1341: Expected Obj, but got I
			//IL_1394: Expected Obj, but got I
			//IL_13c6: Expected I4, but got Obj
			//IL_13f5: Expected Obj, but got I
			//IL_1427: Expected I4, but got Obj
			//IL_145e: Expected Obj, but got I
			//IL_146e: Expected Obj, but got I
			//IL_148c: Expected Obj, but got I
			//IL_14e7: Expected Obj, but got I
			//IL_14f7: Expected Obj, but got I
			//IL_1515: Expected Obj, but got I
			//IL_1568: Expected Obj, but got I
			//IL_15b6: Expected I4, but got Obj
			//IL_15e2: Expected Obj, but got I
			//IL_1614: Expected I4, but got Obj
			//IL_1690: Expected Obj, but got I4
			//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16be: Expected Obj, but got Unknown
			//IL_16ef: Expected I, but got Obj
			_003CSignedPost_003Ed__191 obj8 = default;
			int num5;
			string text;
			byte[] array2;
			string text12;
			int num8;
			bool flag18;
			float num3;
			nint num = default;
			bool flag2;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					flag2 = false;
					if (obj != null)
					{
						goto IL_1941;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v268+E4]");
					bool flag3 = (nint)0 == 0;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Init();
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v153+A0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v154+C0]");
					num = 0;
					object obj7 = obj8 + 64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v154+C0]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					_003C_003E1__state = -1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v63+114]");
				if ((nint)0 != 0)
				{
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+E4]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj10 = obj9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+A0]");
					object obj14 = 0;
					float num2 = realtimeSinceStartup;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v149+128]");
					num3 = num2 - 0f;
					bool flag6 = !((double)num3 < 20.0);
					double num4 = 20.0;
					if (!flag6)
					{
						object obj15 = obj8 + 24;
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num4 = 20.0;
						num = unchecked((nint)null);
						num5 = 1;
						goto IL_1a2f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v130+A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v68+C0]");
				bool flag8 = string.IsNullOrEmpty((string)0);
				bool flag9 = !flag8;
				object obj18 = !flag9;
				num = unchecked((nint)null);
				if (obj18 == null)
				{
					object obj19 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v143+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v143+A0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v74+D0]");
					bool flag11 = string.IsNullOrEmpty((string)0);
					bool flag12 = !flag11;
					num = unchecked((nint)null);
					if (flag12)
					{
						bool flag13 = string.IsNullOrEmpty(obj8._003CtokenAsked_003E5__2);
						bool flag14 = !flag13;
						object obj22 = !flag14;
						text = null;
						if (obj22 == null)
						{
							object obj23 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v238+E4]");
							bool flag15 = (nint)0 == 0;
							object obj24 = !flag15;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj23 = obj9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v238+A0]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v143+C0]");
							text = (string)0;
							string text2 = obj8._003CtokenAsked_003E5__2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v143+C0]");
							bool flag16 = text2 != (string)0;
							bool flag17 = !flag16;
							flag18 = false;
							if (!flag17)
							{
								bool flag19 = obj8.body == null;
								flag18 = false;
								if (flag19)
								{
									goto IL_18b6;
								}
								text = obj8._003CtokenAsked_003E5__2;
								int num6 = obj8.body.IndexOf(obj8._003CtokenAsked_003E5__2, (StringComparison)4);
								int num7 = (int)(num6 & 0x80000000L);
								bool flag20 = num7 == 0;
								object obj26 = !flag20;
								flag18 = true;
								num8 = 0;
								if (obj26 == null)
								{
									object obj27 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X0_v243+E4]");
									bool flag21 = (nint)0 == 0;
									object obj28 = !flag21;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag22 = obj8.body == null;
									flag18 = true;
									num8 = 0;
									num = (nint)text;
									if (flag22)
									{
										goto IL_18cc;
									}
									object obj29 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ X8_v146+A0]");
									object obj30 = 0;
									string text3 = obj8.body;
									string oldValue = obj8._003CtokenAsked_003E5__2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v147+C0]");
									string text4 = text3.Replace(oldValue, (string)0);
									object obj31 = obj8 + 40;
									obj31 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v147+C0]");
									flag18 = false;
									num8 = 0;
									text = text4;
								}
							}
						}
						object obj32 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X0_v150+E4]");
						bool flag23 = (nint)0 == 0;
						object obj33 = !flag23;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj32 = obj9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X0_v150+A0]");
						object obj34 = 0;
						_ = 1;
						num3 = Time.realtimeSinceStartup;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
						object obj35 = 0;
						object obj36 = obj9;
						object obj37 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X9_v55+A0]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X0_v152+E4]");
						bool flag24 = (nint)0 == 0;
						object obj39 = !flag24;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTimeOffset utcNow = DateTimeOffset.UtcNow;
						DateTimeOffset dateTimeOffset = default;
						long num9 = dateTimeOffset.ToUnixTimeMilliseconds();
						long num10 = default;
						string text5 = num10.ToString();
						object obj40 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ X8_v82+A0]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						string[] array = default;
						bool flag25 = array == null;
						num = 7;
						if (flag25)
						{
							goto IL_1764;
						}
						bool flag26 = array.Length == 0;
						num = 7;
						if (flag26)
						{
							goto IL_1772;
						}
						object obj43 = array + 32;
						obj43 = text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj44 = array.Length & 0xFFFFFFFEL;
						bool flag27 = obj44 == null;
						num = (nint)text5;
						if (flag27)
						{
							goto IL_1780;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
						object obj45 = 0;
						object obj46 = array + 40;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string text6 = Hash(obj8.body);
						bool flag28 = array.Length < 2;
						object obj47 = !flag28;
						object obj48 = array.Length - 2;
						bool flag29 = obj48 == null;
						object obj49 = ~obj47;
						object obj50 = obj49 | flag29;
						num = (nint)text6;
						if (obj50 != null)
						{
							goto IL_178e;
						}
						object obj51 = array + 48;
						obj51 = text6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj52 = array.Length & 0xFFFFFFFCL;
						bool flag30 = obj52 == null;
						num = (nint)text6;
						if (flag30)
						{
							goto IL_179c;
						}
						num = (nint)obj45;
						object obj53 = array + 56;
						obj53 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag31 = array.Length < 4;
						object obj54 = !flag31;
						object obj55 = array.Length - 4;
						bool flag32 = obj55 == null;
						object obj56 = ~obj54;
						object obj57 = obj56 | flag32;
						if (obj57 != null)
						{
							goto IL_17aa;
						}
						object obj58 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2004 @ X8_v90+A0]");
						object obj59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X8_v91+20]");
						num = 0;
						object obj60 = array + 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X8_v91+20]");
						obj60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag33 = array.Length < 5;
						object obj61 = !flag33;
						object obj62 = array.Length - 5;
						bool flag34 = obj62 == null;
						object obj63 = ~obj61;
						object obj64 = obj63 | flag34;
						if (obj64 != null)
						{
							goto IL_17b8;
						}
						num = (nint)obj45;
						object obj65 = array + 72;
						obj65 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag35 = array.Length < 6;
						object obj66 = !flag35;
						object obj67 = array.Length - 6;
						bool flag36 = obj67 == null;
						object obj68 = ~obj66;
						object obj69 = obj68 | flag36;
						if (obj69 != null)
						{
							goto IL_17c6;
						}
						object obj70 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2014 @ X8_v94+A0]");
						object obj71 = 0;
						object obj72 = array + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2016 @ X8_v95+E0]");
						obj72 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string message = string.Concat(array);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v83+C8]");
						string text7 = Hmac((string)0, message);
						Guid guid = Guid.NewGuid();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1A8]");
						object obj73 = 0;
						Guid guid2 = default;
						string text8 = guid2.ToString((string)obj73);
						object obj74 = obj8 + 72;
						obj74 = text8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj75 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X8_v99+A0]");
						object obj76 = 0;
						object obj77 = obj8 + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2042 @ X8_v100+C8]");
						obj77 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj78 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2046 @ X8_v101+A0]");
						object obj79 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X8_v102+F8]");
						long num11 = (nint)0 + (nint)1;
						string text9 = Server();
						string url = text9 + obj8.path;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A0]");
						object obj80 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B0]");
						object obj81 = 0;
						UnityWebRequest unityWebRequest = default;
						unityWebRequest._002Ector(url, (string)obj81);
						object obj82 = obj8 + 88;
						obj82 = unityWebRequest;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj8._003C_003E1__state = -3;
						Encoding uTF = Encoding.UTF8;
						bool flag37 = uTF == null;
						flag18 = (byte)(int)obj81 != 0;
						num8 = 0;
						array2 = (byte[])(object)unityWebRequest;
						if (flag37)
						{
							goto IL_17dc;
						}
						nint num12 = (nint)uTF;
						((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)obj8.body, 0, 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0A8]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						UploadHandlerRaw uploadHandlerRaw = default;
						byte[] array3 = default;
						uploadHandlerRaw._002Ector(array3);
						bool flag38 = obj8._003Crequest_003E5__5 == null;
						flag18 = false;
						num8 = 0;
						array2 = array3;
						if (flag38)
						{
							goto IL_17ea;
						}
						obj8._003Crequest_003E5__5.uploadHandler = uploadHandlerRaw;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF098]");
						object obj84 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						DownloadHandlerBuffer downloadHandlerBuffer = default;
						downloadHandlerBuffer._002Ector();
						bool flag39 = obj8._003Crequest_003E5__5 == null;
						flag18 = false;
						num8 = 0;
						array2 = null;
						if (flag39)
						{
							goto IL_17f8;
						}
						obj8._003Crequest_003E5__5.downloadHandler = downloadHandlerBuffer;
						bool flag40 = obj8._003Crequest_003E5__5 == null;
						flag18 = false;
						num8 = 0;
						array2 = (byte[])(object)downloadHandlerBuffer;
						if (flag40)
						{
							goto IL_1806;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0B8]");
						object obj85 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF0C0]");
						object obj86 = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)obj85, (string)obj86);
						bool flag41 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)obj86 != 0;
						num8 = 0;
						array2 = (byte[])obj85;
						if (flag41)
						{
							goto IL_1814;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF190]");
						object obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
						object obj88 = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)obj87, (string)obj88);
						bool flag42 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)obj88 != 0;
						num8 = 0;
						array2 = (byte[])obj87;
						if (flag42)
						{
							goto IL_1822;
						}
						object obj89 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X8_v121+A0]");
						object obj90 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1A0]");
						object obj91 = 0;
						UnityWebRequest unityWebRequest2 = obj8._003Crequest_003E5__5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X8_v122+C0]");
						unityWebRequest2.SetRequestHeader((string)obj91, (string)0);
						bool flag43 = obj8._003Crequest_003E5__5 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ X8_v122+C0]");
						flag18 = false;
						num8 = 0;
						array2 = (byte[])obj91;
						if (flag43)
						{
							goto IL_1830;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF178]");
						object obj92 = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)obj92, text5);
						bool flag44 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)text5 != 0;
						num8 = 0;
						array2 = (byte[])obj92;
						if (flag44)
						{
							goto IL_183e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF170]");
						object obj93 = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)obj93, text7);
						bool flag45 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)text7 != 0;
						num8 = 0;
						array2 = (byte[])obj93;
						if (flag45)
						{
							goto IL_184c;
						}
						object obj94 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X8_v130+A0]");
						object obj95 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF188]");
						object obj96 = 0;
						UnityWebRequest unityWebRequest3 = obj8._003Crequest_003E5__5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2095 @ X8_v131+E0]");
						unityWebRequest3.SetRequestHeader((string)obj96, (string)0);
						bool flag46 = obj8._003Crequest_003E5__5 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2095 @ X8_v131+E0]");
						flag18 = false;
						num8 = 0;
						array2 = (byte[])obj96;
						if (flag46)
						{
							goto IL_185a;
						}
						object obj97 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2096 @ X8_v133+A0]");
						object obj98 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF168]");
						object obj99 = 0;
						UnityWebRequest unityWebRequest4 = obj8._003Crequest_003E5__5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2098 @ X8_v134+D0]");
						unityWebRequest4.SetRequestHeader((string)obj99, (string)0);
						bool flag47 = obj8._003Crequest_003E5__5 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2098 @ X8_v134+D0]");
						flag18 = false;
						num8 = 0;
						array2 = (byte[])obj99;
						if (flag47)
						{
							goto IL_1868;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1B0]");
						object name = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)name, obj8._003CrequestNonce_003E5__3);
						long num13 = default;
						string text10 = num13.ToString();
						bool flag48 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)obj8._003CrequestNonce_003E5__3 != 0;
						num8 = 0;
						array2 = null;
						if (flag48)
						{
							goto IL_1876;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF180]");
						object obj100 = 0;
						obj8._003Crequest_003E5__5.SetRequestHeader((string)obj100, text10);
						bool flag49 = obj8._003Crequest_003E5__5 == null;
						flag18 = (byte)(int)text10 != 0;
						num8 = 0;
						array2 = (byte[])obj100;
						if (flag49)
						{
							goto IL_1884;
						}
						obj8._003Crequest_003E5__5.timeout = 15;
						num3 = Time.realtimeSinceStartup;
						obj8._003Cbegan_003E5__6 = num3;
						bool flag50 = obj8._003Crequest_003E5__5 == null;
						flag18 = false;
						num8 = 0;
						text = (string)15;
						if (flag50)
						{
							goto IL_189a;
						}
						UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = obj8._003Crequest_003E5__5.SendWebRequest();
						object obj101 = obj8 + 24;
						obj101 = unityWebRequestAsyncOperation;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						flag18 = false;
						num8 = 0;
						num = (nint)unityWebRequestAsyncOperation;
						num5 = 2;
						goto IL_1a2f;
					}
				}
				object obj102 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v135+E4]");
				bool flag51 = (nint)0 == 0;
				object obj103 = !flag51;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj102 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v135+A0]");
				object obj104 = 0;
				Action<bool, string> action = obj8.done;
				_ = 0;
				_ = 0;
				if (obj8.done != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v72 (System.Action`2<System.Boolean, System.String>)+28]");
					num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v72 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
					flag18 = false;
					num = unchecked((nint)null);
					flag2 = false;
					goto IL_1941;
				}
				NullReferenceException ex = new NullReferenceException();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj105 = 0;
				_003C_003E1__state = -3;
				object obj106 = obj105;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v82+E4]");
				bool flag52 = (nint)0 == 0;
				object obj107 = !flag52;
				_003CSignedPost_003Ed__191 obj108 = this;
				if (obj107 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj106 = obj105;
					obj108 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v82+A0]");
				object obj109 = 0;
				_ = 0;
				if (obj108._003Crequest_003E5__5 != null)
				{
					long responseCode = obj108._003Crequest_003E5__5.responseCode;
					object obj110 = obj105;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v41+A0]");
					object obj111 = 0;
					num3 = RetryAfterOf(obj8._003Crequest_003E5__5);
					object obj112 = obj105;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v43+A0]");
					object obj113 = 0;
					bool flag53 = obj8._003Crequest_003E5__5 == null;
					num = unchecked((nint)null);
					if (flag53)
					{
						goto IL_171e;
					}
					UnityWebRequest.Result result = obj8._003Crequest_003E5__5.result;
					bool flag54;
					if (result == (UnityWebRequest.Result)1)
					{
						nint num14 = unchecked((nint)null);
						flag54 = true;
					}
					else
					{
						bool flag55 = obj8._003Crequest_003E5__5 == null;
						num = unchecked((nint)null);
						if (flag55)
						{
							goto IL_1756;
						}
						long responseCode2 = obj8._003Crequest_003E5__5.responseCode;
						object obj114 = responseCode2 - 403;
						bool flag56 = obj114 == null;
						nint num14 = unchecked((nint)null);
						flag54 = flag56;
					}
					object obj115 = obj105;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v89+E4]");
					bool flag57 = (nint)0 == 0;
					object obj116 = !flag57;
					if (obj116 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					NoteHttp(obj8.path, obj8._003Crequest_003E5__5, obj8._003Cbegan_003E5__6, flag54);
					UnityWebRequest unityWebRequest5 = obj8._003Crequest_003E5__5;
					bool flag58 = obj8._003Crequest_003E5__5 == null;
					flag18 = flag54;
					num8 = 0;
					num3 = obj8._003Cbegan_003E5__6;
					num = (nint)obj8._003Crequest_003E5__5;
					if (flag58)
					{
						goto IL_172c;
					}
					_003CSignedPost_003Ed__191 obj117;
					if (unityWebRequest5.m_DownloadHandler != null)
					{
						string text11 = unityWebRequest5.m_DownloadHandler.text;
						num = unchecked((nint)null);
						obj117 = obj8;
						text12 = text11;
					}
					else
					{
						num = (nint)obj8._003Crequest_003E5__5;
						obj117 = obj8;
						text12 = null;
					}
					bool flag59 = (byte)(~(obj117.verifyReply ? 1u : 0u)) != 0;
					flag18 = flag54;
					num8 = 0;
					if (!flag59)
					{
						bool flag60 = obj117._003Crequest_003E5__5 == null;
						flag18 = flag54;
						num8 = 0;
						num3 = obj8._003Cbegan_003E5__6;
						if (flag60)
						{
							goto IL_1748;
						}
						long responseCode3 = obj117._003Crequest_003E5__5.responseCode;
						bool flag61 = responseCode3 != 200;
						flag18 = flag54;
						num8 = 0;
						num = unchecked((nint)null);
						if (!flag61)
						{
							bool flag62 = obj8._003Crequest_003E5__5 == null;
							flag18 = flag54;
							num8 = 0;
							num3 = obj8._003Cbegan_003E5__6;
							text = null;
							if (flag62)
							{
								goto IL_18a8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF198]");
							object name2 = 0;
							string responseHeader = obj8._003Crequest_003E5__5.GetResponseHeader((string)name2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj118 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
							object obj119 = 0;
							string text13 = (string)((text12 != null) ? text12 : obj118);
							string message2 = obj8._003CrequestNonce_003E5__3 + (string)obj119 + text13;
							object obj120 = obj105;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X0_v108+E4]");
							bool flag63 = (nint)0 == 0;
							object obj121 = !flag63;
							if (obj121 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text14 = Hmac(obj8._003CsigningSecret_003E5__4, message2);
							bool flag64 = string.IsNullOrEmpty(responseHeader);
							bool flag65 = !flag64;
							object obj122 = !flag65;
							bool flag66 = false;
							nint num15 = unchecked((nint)null);
							if (obj122 == null)
							{
								bool flag67 = responseHeader != text14;
								bool flag68 = !flag67;
								flag66 = false;
								num15 = (nint)text14;
								flag18 = false;
								num8 = 0;
								num = (nint)text14;
								if (flag68)
								{
									goto IL_1bcb;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF160]");
							object obj123 = 0;
							text12 = (string)obj123;
							flag18 = flag66;
							num8 = 0;
							num = num15;
						}
					}
					goto IL_1bcb;
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_171e;
			IL_1764:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_1772;
			IL_17aa:
			IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			goto IL_17b8;
			IL_179c:
			IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
			goto IL_17aa;
			IL_17b8:
			IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
			goto IL_17c6;
			IL_17c6:
			IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
			array2 = (byte[])num;
			goto IL_17dc;
			IL_17f8:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_1806;
			IL_1806:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_1814;
			IL_17ea:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_17f8;
			IL_17dc:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_17ea;
			IL_1822:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_1830;
			IL_1814:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_1822;
			IL_1830:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_183e;
			IL_185a:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_1868;
			IL_184c:
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_185a;
			IL_183e:
			NullReferenceException ex17 = new NullReferenceException();
			goto IL_184c;
			IL_1868:
			NullReferenceException ex18 = new NullReferenceException();
			goto IL_1876;
			IL_1876:
			NullReferenceException ex19 = new NullReferenceException();
			goto IL_1884;
			IL_1884:
			NullReferenceException ex20 = new NullReferenceException();
			text = (string)(object)array2;
			goto IL_189a;
			IL_189a:
			NullReferenceException ex21 = new NullReferenceException();
			goto IL_18a8;
			IL_18cc:
			NullReferenceException ex22 = new NullReferenceException();
			bool flag69 = num != 1;
			OutOfMemoryException ex23 = (OutOfMemoryException)(object)ex22;
			if (!flag69)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj124 = default;
				bool flag70 = obj124 == null;
				flag2 = false;
				if (flag70)
				{
					return flag2;
				}
				goto IL_1941;
			}
			goto IL_1d41;
			IL_18b6:
			NullReferenceException ex24 = new NullReferenceException();
			num = (nint)text;
			goto IL_18cc;
			IL_18a8:
			NullReferenceException ex25 = new NullReferenceException();
			goto IL_18b6;
			IL_1d41:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A04BC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_1941:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A05A8");
			OutOfMemoryException ex26 = new OutOfMemoryException();
			ex23 = ex26;
			goto IL_1d41;
			IL_173a:
			NullReferenceException ex27 = new NullReferenceException();
			goto IL_1748;
			IL_1780:
			IndexOutOfRangeException ex28 = new IndexOutOfRangeException();
			goto IL_178e;
			IL_1bcb:
			Action<bool, string> action2 = obj8.done;
			bool flag71 = obj8.done == null;
			num3 = obj8._003Cbegan_003E5__6;
			if (flag71)
			{
				goto IL_173a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v51 (System.Action`2<System.Boolean, System.String>)+28]");
			num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X8_v51 (System.Action`2<System.Boolean, System.String>)+18] (should have been resolved before IL gen)");
			obj8._003C_003Em__Finally1();
			object obj125 = obj8 + 88;
			obj125 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			flag18 = (byte)(int)text12 != 0;
			num3 = obj8._003Cbegan_003E5__6;
			num = unchecked((nint)null);
			flag2 = false;
			goto IL_1941;
			IL_1a2f:
			obj8._003C_003E1__state = num5;
			flag2 = true;
			goto IL_1941;
			IL_178e:
			IndexOutOfRangeException ex29 = new IndexOutOfRangeException();
			goto IL_179c;
			IL_171e:
			NullReferenceException ex30 = new NullReferenceException();
			goto IL_172c;
			IL_172c:
			NullReferenceException ex31 = new NullReferenceException();
			goto IL_173a;
			IL_1772:
			IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
			goto IL_1780;
			IL_1748:
			NullReferenceException ex33 = new NullReferenceException();
			goto IL_1756;
			IL_1756:
			NullReferenceException ex34 = new NullReferenceException();
			goto IL_1764;
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
			UnityWebRequest unityWebRequest = _003Crequest_003E5__5;
			_003C_003E1__state = -1;
			if (_003Crequest_003E5__5 == null)
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

	private sealed class _003CStartup_003Ed__133 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass133_0 _003C_003E8__1;

		public Action<Outcome> done;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CStartup_003Ed__133(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0337: Expected I4, but got I8
			//IL_0251: Expected I4, but got I8
			//IL_034a: Expected I4, but got Obj
			//IL_0040: Expected Obj, but got I4
			//IL_0280: Expected Obj, but got I
			//IL_02aa: Expected Obj, but got I4
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected Obj, but got Unknown
			//IL_0067: Expected Obj, but got I
			//IL_0076: Expected I4, but got I8
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_00df: Expected Obj, but got I4
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected Obj, but got Unknown
			//IL_011d: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I
			//IL_0167: Expected I, but got Obj
			//IL_0186: Expected Obj, but got I
			//IL_0197: Expected I, but got Obj
			//IL_01a7: Expected Obj, but got I
			//IL_01d1: Expected Obj, but got I4
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected Obj, but got Unknown
			bool result;
			int num;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					result = false;
					if (obj != null)
					{
						goto IL_0369;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1D0]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj3 = default;
					obj3._002Ector();
					object obj4 = this + 32;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (obj4 != null)
					{
						object obj5 = obj4 + 16;
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (obj4 != null)
						{
							object obj6 = obj4 + 24;
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1C0]");
							object obj8 = 0;
							Action<System.__Canon> action = default;
							action._002Ector(obj4, (IntPtr)obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1C8]");
							object obj9 = 0;
							Action<System.__Canon> action2 = default;
							action2._002Ector(obj4, (IntPtr)obj9);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj10 = 0;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v30+E4]");
							bool flag2 = (nint)0 == 0;
							object obj12 = !flag2;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							IEnumerator enumerator = FetchMetaUser((Action<string>)action, (Action<string>)action2);
							object obj13 = this + 24;
							obj13 = enumerator;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							result = true;
							num = 1;
							goto IL_036e;
						}
					}
				}
				else
				{
					_003C_003Ec__DisplayClass133_0 obj14 = _003C_003E8__1;
					_003C_003E1__state = -1;
					if (_003C_003E8__1 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v7+E4]");
						bool flag3 = (nint)0 == 0;
						object obj17 = !flag3;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						IEnumerator enumerator2 = Connect(obj14.userId, obj14.userName, done);
						object obj18 = this + 24;
						obj18 = enumerator2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						result = true;
						num = 2;
						goto IL_036e;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			result = false;
			num = -1;
			goto IL_036e;
			IL_0369:
			return result;
			IL_036e:
			_003C_003E1__state = num;
			goto IL_0369;
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

	private sealed class _003CVerifyPeer_003Ed__160 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<bool> done;

		public string pfid;

		public string sid;

		public string sig;

		private _003C_003Ec__DisplayClass160_0 _003C_003E8__1;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CVerifyPeer_003Ed__160(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_036d: Expected I4, but got I8
			//IL_01c7: Expected I4, but got I8
			//IL_01d0: Expected F4, but got I4
			//IL_18bb: Expected Obj, but got I
			//IL_18e5: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got I4
			//IL_1379: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I
			//IL_006d: Expected I4, but got I8
			//IL_020e: Expected Obj, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00ba: Expected F4, but got I4
			//IL_13b8: Expected Obj, but got I4
			//IL_023e: Expected Obj, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I4
			//IL_0276: Expected Obj, but got I4
			//IL_133b: Expected Obj, but got I
			//IL_135b: Expected F4, but got I4
			//IL_13d6: Expected Obj, but got I
			//IL_13e6: Expected F4, but got I
			//IL_13f6: Invalid comparison between F4 and I
			//IL_039d: Expected Obj, but got I4
			//IL_07a8: Expected Obj, but got I
			//IL_1425: Expected F4, but got I4
			//IL_017d: Expected Obj, but got I4
			//IL_07df: Expected F4, but got I
			//IL_03cd: Expected Obj, but got I
			//IL_03fb: Expected Obj, but got I4
			//IL_0404: Expected F4, but got I4
			//IL_0802: Expected Obj, but got I
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Expected Obj, but got Unknown
			//IL_084c: Expected Obj, but got I4
			//IL_1494: Expected Obj, but got I
			//IL_149d: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a2: Expected Obj, but got Unknown
			//IL_14b2: Expected Obj, but got I
			//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ca: Expected Obj, but got Unknown
			//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ec: Expected Obj, but got Unknown
			//IL_0440: Expected Obj, but got I4
			//IL_0449: Expected F4, but got I4
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_087f: Expected Obj, but got Unknown
			//IL_08b5: Expected Obj, but got I
			//IL_08cf: Expected Obj, but got I
			//IL_08e2: Expected I, but got Obj
			//IL_0485: Expected Obj, but got I4
			//IL_048e: Expected F4, but got I4
			//IL_08f7: Expected Obj, but got I
			//IL_0917: Unknown result type (might be due to invalid IL or missing references)
			//IL_091c: Expected Obj, but got Unknown
			//IL_04d4: Expected Obj, but got I4
			//IL_1443: Expected Obj, but got I
			//IL_0509: Expected Obj, but got I
			//IL_052c: Expected Obj, but got I
			//IL_0547: Expected Obj, but got Ref
			//IL_0a1b: Expected Obj, but got I4
			//IL_1548: Expected Obj, but got I
			//IL_1558: Expected F4, but got I
			//IL_1568: Invalid comparison between F4 and I
			//IL_057e: Expected Obj, but got Ref
			//IL_0a62: Expected Obj, but got I4
			//IL_05b5: Expected Obj, but got I
			//IL_159c: Invalid comparison between F4 and I4
			//IL_15ab: Invalid comparison between F4 and I4
			//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c6: Expected Obj, but got Unknown
			//IL_15d3: Expected Obj, but got F4
			//IL_1608: Expected Obj, but got I4
			//IL_1610: Unknown result type (might be due to invalid IL or missing references)
			//IL_1615: Expected Obj, but got Unknown
			//IL_0ab4: Expected F4, but got I
			//IL_0a92: Expected Obj, but got I
			//IL_1644: Invalid comparison between F4 and I4
			//IL_1653: Expected F4, but got I4
			//IL_0975: Expected Obj, but got I4
			//IL_173b: Invalid comparison between F4 and I4
			//IL_174d: Expected Obj, but got I4
			//IL_0638: Expected Obj, but got I
			//IL_0adb: Expected Obj, but got I4
			//IL_099a: Expected Obj, but got I4
			//IL_0b0b: Expected Obj, but got I
			//IL_0b20: Expected Obj, but got I
			//IL_0b39: Expected Obj, but got I
			//IL_09b8: Expected Obj, but got I
			//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c6: Expected Obj, but got Unknown
			//IL_06b4: Expected F4, but got I
			//IL_06c4: Invalid comparison between F4 and I
			//IL_1093: Expected Obj, but got I
			//IL_0d30: Expected Obj, but got I4
			//IL_0d93: Expected Obj, but got I4
			//IL_0b6a: Expected Obj, but got I
			//IL_0b84: Expected Obj, but got I
			//IL_152a: Expected Obj, but got I4
			//IL_09ec: Expected Obj, but got I4
			//IL_0bc4: Expected Obj, but got I4
			//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10db: Expected Obj, but got Unknown
			//IL_1102: Unknown result type (might be due to invalid IL or missing references)
			//IL_1107: Expected Obj, but got Unknown
			//IL_16b7: Expected Obj, but got I
			//IL_0d4d: Expected Obj, but got I
			//IL_0d5d: Expected Obj, but got I
			//IL_0d6d: Expected Obj, but got I
			//IL_0d76: Expected Obj, but got I4
			//IL_071f: Expected Obj, but got I
			//IL_0bfb: Expected Obj, but got I
			//IL_0c0f: Expected Obj, but got I
			//IL_0c1f: Expected Obj, but got I
			//IL_0763: Expected Obj, but got I
			//IL_0773: Expected Obj, but got I
			//IL_0783: Expected Obj, but got I
			//IL_0793: Expected Obj, but got I
			//IL_1166: Unknown result type (might be due to invalid IL or missing references)
			//IL_116b: Expected Obj, but got Unknown
			//IL_11a7: Expected Obj, but got I4
			//IL_170d: Expected F4, but got VT
			//IL_11dc: Expected Obj, but got I
			//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9e: Expected Obj, but got I
			//IL_0eae: Expected Obj, but got I
			//IL_0db1: Expected F4, but got VT
			//IL_0c61: Expected VT, but got I
			//IL_0c71: Invalid comparison between F4 and I
			//IL_1219: Expected Obj, but got I
			//IL_124e: Expected Obj, but got I
			//IL_0f87: Expected Obj, but got I4
			//IL_1800: Expected Obj, but got I
			//IL_181f: Expected VT, but got Ref
			//IL_0edd: Expected Obj, but got I4
			//IL_0e25: Expected VT, but got Ref
			//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9a: Expected VT, but got Unknown
			//IL_0ca3: Invalid comparison between VT and I4
			//IL_0cb2: Expected Obj, but got I4
			//IL_1285: Expected Obj, but got I
			//IL_1782: Expected Obj, but got I
			//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ac: Expected Obj, but got Unknown
			//IL_0fc5: Expected Obj, but got I
			//IL_0fe0: Expected VT, but got Ref
			//IL_0e06: Expected Obj, but got I4
			//IL_0cd8: Expected Obj, but got I4
			//IL_0ce0: Expected F4, but got VT
			//IL_0f3e: Expected VT, but got Ref
			//IL_0f1f: Expected Obj, but got I
			//IL_1020: Expected Obj, but got I4
			//IL_0d09: Expected Obj, but got I4
			//IL_1845: Expected Obj, but got I
			//IL_1864: Expected VT, but got Ref
			//IL_1055: Expected Obj, but got I
			//IL_106e: Expected Obj, but got I
			//IL_1076: Expected VT, but got Ref
			object obj4;
			object obj6;
			object obj8;
			float num2;
			float realtimeSinceStartup;
			object obj22;
			System.__Canon _Canon2;
			object obj21 = default;
			System.__Canon _Canon = default;
			float num;
			object obj5;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					if (obj == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF240]");
						object obj2 = 0;
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj3 = default;
						obj3._002Ector();
						obj4 = this + 64;
						obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag2 = obj4 == null;
						num = 0f;
						obj5 = obj3;
						if (!flag2)
						{
							obj6 = done;
							object obj7 = obj4 + 24;
							obj7 = done;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							obj8 = 0;
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v68+E4]");
							bool flag3 = (nint)0 == 0;
							object obj10 = !flag3;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj9 = obj8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v68+A0]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v41+1]");
							bool flag4 = (nint)0 == 0;
							num2 = 0f;
							if (flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v68+E4]");
								bool flag5 = (nint)0 == 0;
								object obj12 = !flag5;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj13 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v103+A0]");
									obj11 = 0;
								}
								bool flag6 = obj11 == null;
								num2 = 0f;
								if (!flag6)
								{
									bool flag7 = string.IsNullOrEmpty(pfid);
									bool flag8 = !flag7;
									object obj14 = !flag8;
									num2 = 0f;
									obj6 = null;
									if (obj14 == null)
									{
										bool flag9 = string.IsNullOrEmpty(sid);
										bool flag10 = !flag9;
										object obj15 = !flag10;
										num2 = 0f;
										obj6 = null;
										if (obj15 == null)
										{
											bool flag11 = string.IsNullOrEmpty(sig);
											bool flag12 = !flag11;
											object obj16 = !flag12;
											num2 = 0f;
											obj6 = null;
											if (obj16 == null)
											{
												realtimeSinceStartup = Time.realtimeSinceStartup;
												object obj17 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v78+E4]");
												bool flag13 = (nint)0 == 0;
												object obj18 = !flag13;
												if (obj18 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj17 = obj8;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v78+A0]");
												object obj19 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v44+140]");
												bool flag14 = (nint)0 == 0;
												num = realtimeSinceStartup;
												obj5 = null;
												if (!flag14)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1F0]");
													object obj20 = 0;
													obj21 = obj20;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v44+140]");
													bool flag15 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)pfid, out var value);
													bool flag16 = !flag15;
													_Canon = (System.__Canon)(&value);
													num = realtimeSinceStartup;
													obj6 = pfid;
													if (flag16)
													{
														goto IL_09f1;
													}
													bool flag17 = value == null;
													_Canon = (System.__Canon)(&value);
													num = realtimeSinceStartup;
													obj5 = pfid;
													if (!flag17)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-68_v8 (System.__Canon)+10]");
														bool flag18 = (string)0 == sid;
														bool flag19 = !flag18;
														_Canon = null;
														obj5 = sid;
														_Canon2 = value;
														if (flag19)
														{
															goto IL_0947;
														}
														bool flag20 = value == null;
														_Canon = null;
														num = realtimeSinceStartup;
														obj5 = sid;
														if (!flag20)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-68_v8 (System.__Canon)+18]");
															bool flag21 = (string)0 == sig;
															bool flag22 = !flag21;
															_Canon = null;
															obj5 = sig;
															_Canon2 = value;
															if (flag22)
															{
																goto IL_0947;
															}
															bool flag23 = value == null;
															_Canon = null;
															num = realtimeSinceStartup;
															obj5 = sig;
															if (!flag23)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-68_v8 (System.__Canon)+24]");
																num = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-68_v8 (System.__Canon)+24]");
																if (!(realtimeSinceStartup < 0f))
																{
																	_Canon = null;
																	obj5 = sig;
																	obj22 = 0;
																	_Canon2 = value;
																	goto IL_171b;
																}
																object obj23 = obj4;
																bool flag24 = obj4 == null;
																_Canon = null;
																obj5 = sig;
																if (!flag24)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X9_v29+18]");
																	object obj24 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X9_v29+18]");
																	bool flag25 = (nint)0 == 0;
																	_Canon = null;
																	obj5 = sig;
																	if (!flag25)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-68_v8 (System.__Canon)+20]");
																		obj5 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v30+18]");
																		object obj25 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v30+40]");
																		object obj26 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v30+28]");
																		object obj27 = 0;
																		goto IL_1475;
																	}
																}
															}
														}
													}
												}
												goto IL_12d2;
											}
										}
									}
								}
							}
							goto IL_015b;
						}
						goto IL_12d2;
					}
					goto IL_131d;
				}
				_003C_003E1__state = -1;
				num2 = 0f;
				goto IL_18ab;
			}
			_003C_003E1__state = -1;
			return false;
			IL_1475:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v343 @ X8_v99 (should have been resolved before IL gen)");
			goto IL_131d;
			IL_0e0b:
			bool flag26 = (nint)obj5 != 1;
			float num3 = default;
			Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&num3);
			NullReferenceException ex2;
			NullReferenceException ex = ex2;
			System.__Canon key;
			if (!flag26)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				key = null;
				goto IL_0e59;
			}
			goto IL_1763;
			IL_02f8:
			_003C_003Ec__DisplayClass160_0 obj28;
			Action<bool> action = obj28.done;
			bool flag27 = obj28.done == null;
			object obj30;
			object obj29 = obj30;
			object obj31;
			obj21 = obj31;
			System.__Canon _Canon3;
			_Canon = _Canon3;
			num = num2;
			obj5 = obj6;
			if (flag27)
			{
				goto IL_12d2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X8_v35 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			goto IL_131d;
			IL_015b:
			obj28 = (_003C_003Ec__DisplayClass160_0)obj4;
			bool flag28 = obj4 == null;
			object obj32 = !flag28;
			obj30 = obj29;
			obj31 = obj21;
			_Canon3 = _Canon;
			if (obj32 != null)
			{
				goto IL_02f8;
			}
			num = num2;
			obj5 = obj6;
			goto IL_12d2;
			IL_131d:
			return false;
			IL_1763:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A04DC");
			goto IL_12e0;
			IL_0947:
			bool flag29 = _Canon2 == null;
			num = realtimeSinceStartup;
			if (flag29)
			{
				goto IL_12d2;
			}
			obj22 = 1;
			goto IL_171b;
			IL_0e59:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A04DC");
			List<System.__Canon> list = default;
			Enumerator<, > val = default;
			float num4 = default;
			object obj41;
			if (list != null)
			{
				Enumerator<, > enumerator2 = list.GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1E8]");
				object obj34 = 0;
				while (true)
				{
					obj5 = obj33;
					if (!val.MoveNext())
					{
						break;
					}
					object obj35 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v142+E4]");
					bool flag30 = (nint)0 == 0;
					object obj36 = !flag30;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj35 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v142+A0]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v86+140]");
					if ((nint)0 != 0)
					{
						_Canon = (System.__Canon)obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v86+140]");
						bool flag31 = ((Dictionary<System.__Canon, System.__Canon>)0).Remove(key);
						continue;
					}
					goto IL_0f28;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
				object obj38 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X0_v131+E4]");
				bool flag32 = (nint)0 == 0;
				object obj39 = !flag32;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj38 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X0_v131+A0]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v80+140]");
				bool flag33 = (nint)0 == 0;
				enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&val);
				num = num4;
				if (!flag33)
				{
					obj5 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v80+140]");
					int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
					bool flag34 = count < 200;
					enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&val);
					num = num4;
					if (!flag34)
					{
						object obj42 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X0_v135+E4]");
						bool flag35 = (nint)0 == 0;
						object obj43 = !flag35;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj42 = obj8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ X0_v135+A0]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v82+140]");
						bool flag36 = (nint)0 == 0;
						enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&val);
						num = num4;
						if (flag36)
						{
							goto IL_12d2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA0]");
						object obj45 = 0;
						obj5 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v82+140]");
						((Dictionary<System.__Canon, System.__Canon>)0).Clear();
						enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&val);
						num = num4;
					}
					goto IL_1083;
				}
			}
			goto IL_12d2;
			IL_12d2:
			NullReferenceException ex3 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
			ex = ex3;
			goto IL_12e0;
			IL_0f28:
			NullReferenceException ex4 = new NullReferenceException();
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&val);
			ex = ex4;
			num = num4;
			goto IL_1763;
			IL_12e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result = default;
			return result;
			IL_18ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+E4]");
			bool flag37 = (nint)0 == 0;
			object obj48 = !flag37;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj46;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+A0]");
			object obj49 = 0;
			if (obj49 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v6+E4]");
				bool flag38 = (nint)0 == 0;
				object obj50 = !flag38;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj51 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v29+A0]");
					obj49 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v11+1]");
				bool flag39 = (nint)0 == 0;
				object obj52 = !flag39;
				if (obj52 == null)
				{
					float realtimeSinceStartup2 = Time.realtimeSinceStartup;
					object obj53 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v11+E4]");
					bool flag40 = (nint)0 == 0;
					object obj54 = !flag40;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj53 = obj46;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v11+A0]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v14+148]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v14+148]");
					if (!(realtimeSinceStartup2 < 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF248]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj57 = default;
						obj57._002Ector();
						bool flag41 = obj57 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v14+148]");
						num = 0f;
						obj5 = null;
						if (!flag41)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
							object obj58 = 0;
							object obj59 = obj57 + 16;
							obj59 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj60 = obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v18+E4]");
							bool flag42 = (nint)0 == 0;
							object obj61 = !flag42;
							if (obj61 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj60 = obj46;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v18+A0]");
							object obj62 = 0;
							object obj63 = obj57 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v20+C0]");
							obj63 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj64 = obj57 + 32;
							obj64 = pfid;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj65 = obj57 + 40;
							obj65 = sid;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj66 = obj57 + 48;
							obj66 = sig;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string body = JsonUtility.ToJson(obj57);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
							object obj67 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF238]");
							object obj68 = 0;
							Action<bool, System.__Canon> action2 = default;
							action2._002Ector((object)_003C_003E8__1, (IntPtr)obj68);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF250]");
							object path = 0;
							IEnumerator enumerator3 = SignedPost((string)path, body, (Action<bool, string>)action2, verifyReply: false);
							object obj69 = this + 24;
							obj69 = enumerator3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 2;
							return true;
						}
						goto IL_12d2;
					}
				}
			}
			obj28 = _003C_003E8__1;
			bool flag43 = _003C_003E8__1 == null;
			obj30 = obj29;
			obj31 = obj21;
			_Canon3 = _Canon;
			obj6 = pfid;
			num = num2;
			obj5 = pfid;
			if (!flag43)
			{
				goto IL_02f8;
			}
			goto IL_12d2;
			IL_171b:
			float num5 = realtimeSinceStartup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v95 (System.__Canon)+28]");
			num = num5 - 0f;
			bool flag44 = !(num < 1.1274813E+09f);
			obj29 = 1127481344;
			obj6 = obj5;
			if (flag44)
			{
				goto IL_09f1;
			}
			object obj70 = obj4;
			bool flag45 = obj4 == null;
			obj29 = 1127481344;
			if (!flag45)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v9+18]");
				object obj71 = 0;
				object obj72 = obj22 & 1;
				if (obj72 != null)
				{
					obj5 = 1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v95 (System.__Canon)+20]");
					bool flag46 = (nint)0 == 0;
					object obj73 = !flag46;
					obj5 = obj73;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v9+18]");
				bool flag47 = (nint)0 == 0;
				obj29 = 1127481344;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v10+18]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v10+40]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v10+28]");
					object obj27 = 0;
					obj29 = 1127481344;
					goto IL_1475;
				}
			}
			goto IL_12d2;
			IL_09f1:
			object obj74 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v84+E4]");
			bool flag48 = (nint)0 == 0;
			object obj75 = !flag48;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj74 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v84+A0]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+148]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+148]");
			float num8;
			float num9;
			if (!(realtimeSinceStartup < 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v84+E4]");
				bool flag49 = (nint)0 == 0;
				object obj77 = !flag49;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj74 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v84+A0]");
					obj76 = 0;
				}
				float num6 = realtimeSinceStartup;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+14C]");
				float num7 = num6 - 0f;
				bool flag50 = num7 < 0f;
				bool flag51 = num7 == 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+14C]");
				object obj78 = realtimeSinceStartup ^ 0;
				object obj79 = realtimeSinceStartup ^ num7;
				object obj80 = obj78 & obj79;
				bool flag52 = (nint)obj80 < 0;
				bool flag53 = flag50 == flag52;
				object obj81 = !flag51;
				object obj82 = flag53 & obj81;
				object obj83 = ~obj82;
				if (obj83 == null)
				{
					num8 = realtimeSinceStartup;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+14C]");
					num8 = 0f;
				}
				num9 = num8 - realtimeSinceStartup;
				bool flag54 = num9 > 1.1204035E+09f;
				num2 = 1.1204035E+09f;
				if (!flag54)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v84+E4]");
					bool flag55 = (nint)0 == 0;
					object obj84 = !flag55;
					if (obj84 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj85 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v90+A0]");
						obj76 = 0;
					}
					num = num8 + 25f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+140]");
					bool flag56 = (nint)0 == 0;
					obj5 = obj6;
					if (!flag56)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1F8]");
						obj41 = 0;
						obj5 = obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v51+140]");
						int count2 = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
						if (count2 < 200)
						{
							goto IL_1083;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
						object obj86 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
						object obj87 = 0;
						obj5 = obj87;
						list._002Ector();
						object obj88 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v111+E4]");
						bool flag57 = (nint)0 == 0;
						object obj89 = !flag57;
						if (obj89 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj88 = obj8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v111+A0]");
						object obj90 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v66+140]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v66+140]");
							Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4 = ((Dictionary<System.__Canon, System.__Canon>)0).GetEnumerator();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF210]");
							object obj91 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
							object obj92 = 0;
							object obj93 = default;
							obj29 = obj93;
							Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5 = enumerator;
							Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator6 = default;
							object obj94 = default;
							while (true)
							{
								obj5 = obj91;
								bool flag58 = enumerator6.MoveNext();
								bool flag59 = !flag58;
								key = null;
								num = (float)enumerator5;
								if (flag59)
								{
									break;
								}
								if (obj94 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ stack_-78+24]");
									enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ stack_-78+24]");
									if (realtimeSinceStartup < 0f)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ stack_-78+28]");
									enumerator5 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(realtimeSinceStartup - 0);
									bool flag60 = enumerator5 < (object)1127481344;
									obj29 = 1127481344;
									if (flag60)
									{
										continue;
									}
									bool flag61 = list == null;
									obj29 = 1127481344;
									num = (float)enumerator5;
									if (!flag61)
									{
										_Canon = (System.__Canon)obj92;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D100");
										obj29 = 1127481344;
										continue;
									}
								}
								else
								{
									NullReferenceException ex5 = new NullReferenceException();
									num = (float)enumerator5;
								}
								ex2 = new NullReferenceException();
								if ((nint)obj5 == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									key = (System.__Canon)1;
									break;
								}
								goto IL_0e0b;
							}
							goto IL_0e59;
						}
					}
					goto IL_12d2;
				}
			}
			goto IL_015b;
			IL_1083:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF230]");
			object obj95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj96 = default;
			obj96._002Ector();
			bool flag62 = obj96 == null;
			obj5 = null;
			if (!flag62)
			{
				object obj97 = obj96 + 16;
				obj97 = sid;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj5 = sig;
				object obj98 = obj96 + 24;
				obj98 = sig;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 1;
				num = num8 + 1.1274813E+09f;
				if (obj4 != null)
				{
					object obj99 = obj4 + 16;
					obj99 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj100 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v99+E4]");
					bool flag63 = (nint)0 == 0;
					object obj101 = !flag63;
					if (obj101 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj100 = obj8;
					}
					_003C_003Ec__DisplayClass160_0 obj102 = _003C_003E8__1;
					bool flag64 = _003C_003E8__1 == null;
					obj5 = obj96;
					if (!flag64)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v99+A0]");
						object obj103 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X9_v19+140]");
						bool flag65 = (nint)0 == 0;
						obj5 = obj96;
						if (!flag65)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF200]");
							object obj104 = 0;
							_Canon = (System.__Canon)(object)obj102.mine;
							obj21 = obj104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X9_v19+140]");
							((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)pfid, (System.__Canon)(object)obj102.mine);
							bool flag66 = !(num8 > realtimeSinceStartup);
							num2 = num;
							if (!flag66)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
								object obj105 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								WaitForSecondsRealtime waitForSecondsRealtime = default;
								waitForSecondsRealtime._002Ector(num9);
								object obj106 = this + 24;
								obj106 = waitForSecondsRealtime;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 1;
								return true;
							}
							goto IL_18ab;
						}
					}
				}
			}
			goto IL_12d2;
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

	private sealed class _003CWaitForBuildHash_003Ed__173 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CWaitForBuildHash_003Ed__173(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_00bb: Expected Obj, but got I
			//IL_00ca: Expected I4, but got I8
			//IL_0700: Expected Obj, but got I4
			//IL_0021: Expected Obj, but got I4
			//IL_077b: Expected Obj, but got I
			//IL_078b: Expected Obj, but got I
			//IL_0730: Expected Obj, but got I4
			//IL_00f1: Expected Obj, but got I
			//IL_0048: Expected Obj, but got I
			//IL_0057: Expected I4, but got I8
			//IL_0081: Expected Obj, but got I4
			//IL_07c0: Expected Obj, but got I
			//IL_07d0: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I4
			//IL_06ae: Expected Obj, but got I
			//IL_06d0: Expected Obj, but got I4
			//IL_0313: Expected Obj, but got I
			//IL_033d: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got I
			//IL_0373: Expected Obj, but got I
			//IL_039d: Expected Obj, but got I4
			//IL_022a: Expected Obj, but got I4
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected Obj, but got Unknown
			//IL_02e5: Expected Obj, but got I4
			//IL_0148: Expected Obj, but got I
			//IL_0160: Expected Obj, but got I
			//IL_0170: Expected Obj, but got I
			//IL_03d0: Expected Obj, but got I4
			//IL_02af: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01dc: Expected I, but got Obj
			//IL_03e5: Expected Obj, but got I
			//IL_040f: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got I
			//IL_026a: Expected Obj, but got I
			//IL_027a: Expected Obj, but got I
			//IL_0754: Expected Obj, but got I
			//IL_04a0: Expected Obj, but got I
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected Obj, but got Unknown
			//IL_04eb: Expected Obj, but got I4
			//IL_04f3: Expected Obj, but got Ref
			//IL_0533: Expected Obj, but got I4
			//IL_058a: Expected Obj, but got I4
			//IL_05d3: Expected Obj, but got I
			//IL_05f8: Expected Obj, but got I
			bool result;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				result = false;
				if (obj != null)
				{
					goto IL_0699;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj2 = 0;
				_003C_003E1__state = -1;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v56+E8]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 != null)
				{
					goto IL_0434;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj7 = 0;
				_003C_003E1__state = -1;
				object obj3 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj9 = 0;
				object obj3 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v7+118]");
			Task task = (Task)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v7+118]");
			nint num = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj12 = 0;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v46+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v47+118]");
					task = (Task)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v47+118]");
					if ((nint)0 == 0)
					{
						NullReferenceException ex = new NullReferenceException();
						goto IL_0450;
					}
				}
				if (!task.IsCompleted)
				{
					object obj15 = this + 24;
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					result = true;
					goto IL_0699;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj16 = 0;
				object obj3 = obj16;
				num = unchecked((nint)null);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj18 = 0;
				object obj3 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v12+118]");
			Task<System.__Canon> task2 = (Task<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v12+118]");
			string text;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v5+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v25+A0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v26+118]");
					task2 = (Task<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v26+118]");
					if ((nint)0 == 0)
					{
						goto IL_0450;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE450]");
				object obj24 = 0;
				object obj25 = obj24;
				System.__Canon result2 = task2.Result;
				text = (string)(object)result2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj26 = 0;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v14+E4]");
				bool flag8 = (nint)0 == 0;
				object obj28 = !flag8;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string version = UnityEngine.Application.version;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v18+E4]");
				bool flag9 = (nint)0 == 0;
				object obj31 = !flag9;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text = Hash(version);
				object obj25 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj32 = 0;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v8+E4]");
			bool flag10 = (nint)0 == 0;
			object obj34 = !flag10;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v8+A0]");
			object obj35 = (nint)0 + (nint)232;
			obj35 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_0434;
			IL_0699:
			return result;
			IL_0450:
			NullReferenceException ex2 = new NullReferenceException();
			bool flag11 = num != 1;
			NullReferenceException ex3 = ex2;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj36 = 0;
				object obj38 = default;
				object obj37 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj40 = default;
				object obj39 = obj40 & 1;
				if (obj39 != null)
				{
					object obj41 = 0;
					object obj43 = default;
					object obj42 = (object)(&obj43);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v47+E4]");
					bool flag12 = (nint)0 == 0;
					object obj44 = !flag12;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string version2 = UnityEngine.Application.version;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v53+E4]");
					bool flag13 = (nint)0 == 0;
					object obj45 = !flag13;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text2 = Hash(version2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v58+A0]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v60+A0]");
					object obj47 = (nint)0 + (nint)232;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = false;
					goto IL_0699;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj48 = obj38;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				NullReferenceException ex4 = default;
				ex3 = ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result3 = default;
			return result3;
			IL_0434:
			result = false;
			goto IL_0699;
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

	public const string Build = null;

	private const int LockoutSeconds = default(int);

	private const string LockKey = null;

	public static bool IsLoggedIn;

	public static bool IsOffline;

	public static string PlayerId;

	public static string Username;

	public static string MetaUserId;

	public static string SessionId;

	public static string PhotonTicket;

	public static string MetaSig;

	public static string AssetKey;

	public static string PlayFabTicket;

	public static Func<bool, IEnumerator> FreshTicket;

	private static bool ticketTurnedDown;

	public static string LastHttp;

	public static long LastHttpCode;

	public static string LastHttpError;

	public const string DevKeyPref = null;

	private static Action m_OnReady;

	private static Action m_OnSessionLost;

	public static FailKind LostKind;

	public static string LostReason;

	private static readonly byte[] cipherKey;

	private static readonly byte[] hostCipher;

	private static readonly byte[] hostFingerprint;

	private static string baseUrl;

	private static bool hostBad;

	private static bool started;

	private static int heartbeats;

	private static int trustState;

	private static string token;

	private static string secret;

	private static string challenge;

	private static string deviceId;

	private static string deviceHash;

	private static string buildHash;

	private static string lastDisplayName;

	private static long sequence;

	private static long nextTry;

	private static bool authBusy;

	private static int failStreak;

	private static FailKind waitKind;

	private static bool sending;

	private static Task<string> buildHashJob;

	private static MonoBehaviour driver;

	private static float sendingSince;

	private static long lastStatus;

	private static float retryAfter;

	private static int sessionEpoch;

	private static readonly Dictionary<string, PeerNote> peerOk;

	private static float peerHoldUntil;

	private static float peerNextSlot;

	private static readonly Dictionary<string, float> reportSeen;

	private static float reportNextSlot;

	private static long ticketAt;

	private static float ticketNextTry;

	private static float ticketLastAsk;

	private static float ticketBusySince;

	private static int ticketUses;

	private static int ticketFailures;

	private static bool ticketBusy;

	private static string ticketFor;

	private static float hwRetryAt;

	private const float HeartbeatMinGap = default(float);

	private const float AskNowGap = default(float);

	private const float HeartbeatJitter = default(float);

	private const float RetryBase = default(float);

	private const float HeartbeatRetryCap = default(float);

	private const float RetryAfterMost = default(float);

	private const float LoginRetryAfterMost = default(float);

	private const float TicketFreshFor = default(float);

	private const int TicketUsesMost = default(int);

	private const float TicketMinGap = default(float);

	private const float TicketRetryBase = default(float);

	private const float TicketRetryCap = default(float);

	private const float PeerGoodFor = default(float);

	private const float PeerBadFor = default(float);

	private const float PeerMinGap = default(float);

	private const float PeerSpacing = default(float);

	private const float PeerQueueMost = default(float);

	private const float PeerHoldMin = default(float);

	private const float PeerHoldSpread = default(float);

	private const int PeerCacheMost = default(int);

	private const float ReportSpacing = default(float);

	private const float ReportQueueMost = default(float);

	private const float ReportDuplicateFor = default(float);

	private const int ReportSeenMost = default(int);

	private const float HwRetryEvery = default(float);

	private static float lastTried;

	private static float attemptSince;

	private const float AttemptMost = default(float);

	private const float StaleSeconds = default(float);

	private const float RenewSpread = default(float);

	private const float RenewFirst = default(float);

	private const float RenewMost = default(float);

	private const float TrustEvery = default(float);

	private const int HeartbeatTicks = default(int);

	public const string NoAnswer = null;

	private static bool askNow;

	private static int refusedAlive;

	private const float RenewScale = default(float);

	private const string HwAlias = null;

	private const string HwIdKey = null;

	private const int HwPurposeSign = default(int);

	private static string hwKeyId;

	public static bool HasDevKey
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_010b: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_00e1: Expected I4, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected Obj, but got Unknown
			//IL_00c1: Expected Obj, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj4 = 0;
			object obj5 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+10]");
				bool flag2 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+10]");
				bool flag3 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+10]");
				object obj6 = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+10]");
				object obj7 = 0 & obj6;
				bool flag4 = (nint)obj7 < 0;
				bool flag5 = flag2 == flag4;
				object obj8 = !flag3;
				return (byte)((flag5 & obj8) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static string DevKey
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			return (string)0;
		}
	}

	public static bool Trusted
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01ca: Expected Obj, but got I4
			//IL_0044: Expected I4, but got Obj
			//IL_007c: Expected Obj, but got I4
			//IL_01ed: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I4
			//IL_022c: Expected Obj, but got I8
			//IL_02ad: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I
			//IL_0259: Expected Obj, but got I
			//IL_026f: Expected Obj, but got I
			//IL_0128: Expected Obj, but got I4
			//IL_0161: Expected Obj, but got I4
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected Obj, but got Unknown
			//IL_017f: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Server();
			bool flag2 = text == null;
			bool result = (byte)(int)text != 0;
			if (!flag2)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+B0]");
				if ((nint)0 != 0)
				{
					result = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+A0]");
						obj6 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+B8]");
					object obj8 = 0 & 0x80000000L;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
						bool flag5 = (nint)0 == 0;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = Tampered();
						obj4 = obj;
						object obj10 = !flag6;
						object obj11 = 1 & obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+A0]");
						object obj12 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v11+B8]");
					object obj15 = -1;
					bool flag8 = obj15 == null;
					result = flag8;
				}
			}
			return result;
		}
	}

	public static event Action OnReady
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+70]");
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
				object obj11 = (nint)0 + (nint)112;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+70]");
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
				object obj11 = (nint)0 + (nint)112;
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

	public static event Action OnSessionLost
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+78]");
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
				object obj11 = (nint)0 + (nint)120;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+78]");
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
				object obj11 = (nint)0 + (nint)120;
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

	public static bool TicketRefusal(string error)
	{
		//IL_02f8: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected I4, but got Unknown
		//IL_02d1: Expected I4, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(error);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj7;
		if (obj == null)
		{
			if (error != null)
			{
				string text = error.ToLowerInvariant();
				if (text != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8D8]");
					object value = 0;
					bool flag3 = text.Contains((string)value);
					bool flag4 = !flag3;
					object obj2 = !flag4;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8F0]");
						object value2 = 0;
						bool flag5 = text.Contains((string)value2);
						bool flag6 = !flag5;
						object obj3 = !flag6;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0B0]");
							object value3 = 0;
							bool flag7 = text.Contains((string)value3);
							bool flag8 = !flag7;
							object obj4 = !flag8;
							if (obj4 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8F8]");
								object value4 = 0;
								bool flag9 = text.Contains((string)value4);
								bool flag10 = !flag9;
								object obj5 = !flag10;
								if (obj5 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8D0]");
									object value5 = 0;
									if (!text.Contains((string)value5))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8E0]");
										object value6 = 0;
										bool flag11 = text.Contains((string)value6);
										bool flag12 = !flag11;
										object obj6 = !flag12;
										if (obj6 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE900]");
											object value7 = 0;
											if (!text.Contains((string)value7))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8E8]");
												object value8 = 0;
												if (!text.Contains((string)value8))
												{
													goto IL_01ae;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF00]");
												object value9 = 0;
												bool flag13 = text.Contains((string)value9);
												obj7 = (flag13 ? 1 : 0) ^ 1;
												goto IL_0306;
											}
										}
										obj7 = 1;
										goto IL_0306;
									}
								}
							}
						}
					}
					goto IL_01ae;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_01ae;
		IL_0306:
		return (byte)(obj7 & 1) != 0;
		IL_01ae:
		obj7 = 0;
		goto IL_0306;
	}

	public static void RecheckTrust()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
		_ = 4294967295L;
	}

	public static void Begin(Action<Outcome> done = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Boot(done))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+A0]");
			object obj6 = 0;
			IEnumerator routine = Startup(done);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+120]");
			Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
		}
	}

	public static void Begin(string metaUserId, string displayName, Action<Outcome> done = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Boot(done))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+A0]");
			object obj6 = 0;
			IEnumerator routine = Connect(metaUserId, displayName, done);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+120]");
			Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
		}
	}

	private unsafe static bool Boot(Action<Outcome> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_0732: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_04ec: Expected I4, but got Obj
		//IL_0587: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0138: Expected Obj, but got Ref
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_05a5: Expected Obj, but got I
		//IL_05c5: Invalid comparison between F4 and I4
		//IL_05d7: Expected F8, but got I4
		//IL_05f5: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I
		//IL_07b1: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I4
		//IL_036c: Invalid comparison between F4 and I4
		//IL_06c5: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_0695: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj4 = 0;
		Action<Outcome> action;
		double num6;
		object obj16;
		object obj17;
		double num3;
		float num2;
		if (IsLockedOut(out var remaining))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE918]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE910]");
			object obj6 = 0;
			string text = remaining.ToString();
			string message = (string)obj5 + text + (string)obj6;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v41+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
			bool flag3 = done == null;
			action = done;
			if (flag3)
			{
				goto IL_04e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE930]");
			object obj9 = 0;
			object obj11 = default;
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj11, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+28]");
			object obj14 = 0;
			object obj15 = obj11;
			obj16 = 0;
		}
		else
		{
			obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v13+B1]");
			if ((nint)0 == 0)
			{
				goto IL_0771;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
				obj19 = 0;
			}
			bool flag6 = obj19 == null;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
				object obj23 = 0;
				float num = realtimeSinceStartup;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v21+18C]");
				num2 = num - 0f;
				bool flag8 = !(num2 < 1.1422925E+09f);
				num3 = 1142292480.0;
				if (flag8)
				{
					float realtimeSinceStartup2 = Time.realtimeSinceStartup;
					object obj24 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v28+E4]");
					bool flag9 = (nint)0 == 0;
					object obj25 = !flag9;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v28+A0]");
					object obj26 = 0;
					float num4 = realtimeSinceStartup2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v24+18C]");
					float num5 = num4 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj27 = 0;
					object obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v30+E4]");
					bool flag10 = (nint)0 == 0;
					object obj29 = !flag10;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					float num7 = default;
					if (num5 < 0f)
					{
						if ((double)num5 == -0.5)
						{
							num6 = -1.0;
							num2 = num7;
							goto IL_065e;
						}
						num2 = num5 + -0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num3 = -0.5;
					}
					else
					{
						if ((double)num5 == 0.5)
						{
							num6 = 1.0;
							num2 = num7;
							goto IL_065e;
						}
						num2 = num5 + 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num3 = 0.5;
					}
					goto IL_06a8;
				}
			}
			bool flag11 = done == null;
			action = done;
			if (flag11)
			{
				goto IL_04e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [done @ X0 (System.Action`1<ShiftAuth+Outcome>)+28]");
			object obj14 = 0;
			object obj15 = obj31;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277 @ X9_v1 (should have been resolved before IL gen)");
		action = null;
		goto IL_04e7;
		IL_06a8:
		int num8 = default;
		string text2 = num8.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE928]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE920]");
		object obj33 = 0;
		string message2 = (string)obj32 + text2 + (string)obj33;
		object obj34 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v35+E4]");
		bool flag13 = (nint)0 == 0;
		object obj35 = !flag13;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Debug.LogWarning(message2);
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
		object obj36 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v36+B4]");
		object obj37 = (nint)0 + (nint)1;
		obj16 = 0;
		goto IL_0771;
		IL_04e7:
		return (byte)(int)action != 0;
		IL_0771:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+E4]");
		bool flag14 = (nint)0 == 0;
		object obj38 = !flag14;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v19+A0]");
		object obj39 = 0;
		_ = 1;
		float realtimeSinceStartup3 = Time.realtimeSinceStartup;
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v11+A0]");
		object obj41 = 0;
		EnsureDriver();
		action = (Action<Outcome>)1;
		goto IL_04e7;
		IL_065e:
		num3 = (double)num2 + num6;
		object obj42 = num2 & 1;
		bool flag15 = obj42 == null;
		object obj43 = !flag15;
		if (obj43 != null)
		{
			num2 = (float)num3;
		}
		goto IL_06a8;
	}

	private static void EnsureDriver()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v1+120]");
		if (!((UnityEngine.Object)0 != null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE958]");
			object name = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)name);
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.hideFlags = (HideFlags)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE950]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+A0]");
			object obj14 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe static bool IsLockedOut(out int remaining)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I8
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I8, but got Unknown
		//IL_0175: Expected Obj, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected I4, but got Unknown
		//IL_007b: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE948]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
		object defaultValue = 0;
		ref int reference = ref *(int*)null;
		string s = PlayerPrefs.GetString((string)key, (string)defaultValue);
		bool flag = long.TryParse(s, out var result);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		DateTimeOffset dateTimeOffset = default;
		long num = dateTimeOffset.ToUnixTimeSeconds();
		if (result > num)
		{
			object obj4 = result - num;
			reference = ref *(int*)obj4;
		}
		object obj5 = result - num;
		bool flag3 = (nint)obj5 < 0;
		bool flag4 = obj5 == null;
		long num2 = result ^ num;
		long num3 = result ^ obj5;
		long num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag3 == flag5;
		object obj6 = !flag4;
		return (byte)((flag6 & obj6) ? 1 : 0) != 0;
	}

	private static void LockAndClose()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		DateTimeOffset dateTimeOffset = default;
		long num = dateTimeOffset.ToUnixTimeSeconds();
		long num2 = default;
		string value = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE948]");
		object key = 0;
		PlayerPrefs.SetString((string)key, value);
		PlayerPrefs.Save();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+A0]");
		object obj7 = 0;
		obj7 = 256;
		CloseGame(2f);
	}

	private static void CloseGame(float grace)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		EnsureDriver();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+A0]");
		object obj5 = 0;
		IEnumerator routine = CloseRoutine(grace);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+120]");
		Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
	}

	private static IEnumerator CloseRoutine(float grace)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE960]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CCloseRoutine_003Ed__131 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			obj2.grace = grace;
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static bool LocalTamper(string error)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE968]");
		object obj = 0;
		if (error == (string)obj)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE970]");
		object obj2 = 0;
		return error == (string)obj2;
	}

	private static IEnumerator Startup(Action<Outcome> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE938]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CStartup_003Ed__133 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static IEnumerator FetchMetaUser(Action<string> setId, Action<string> setName)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE978]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CFetchMetaUser_003Ed__134 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = setId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 40;
			obj4 = setName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static IEnumerator Connect(string metaUserId, string displayName, Action<Outcome> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE940]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CConnect_003Ed__135 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = metaUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 40;
			obj4 = displayName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 48;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static IEnumerator Authenticate(string metaUserId, string displayName, Action<Outcome> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE980]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CAuthenticate_003Ed__136 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = metaUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 48;
			obj4 = displayName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 32;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static int WaitFor(FailKind kind, int n)
	{
		//IL_0010: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_02a2: Expected F4, but got I
		//IL_02a2: Expected F4, but got I
		//IL_02ba: Expected I4, but got F4
		//IL_017a: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I4
		//IL_0277: Expected I4, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int val = n - 1;
		int num = Math.Min(val, 6);
		object obj6;
		int num2;
		if (kind > (FailKind)3)
		{
			if (kind != (FailKind)4)
			{
				if (kind != (FailKind)5)
				{
					if (kind != (FailKind)6)
					{
						goto IL_0224;
					}
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v23+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj6 = 15;
					goto IL_026a;
				}
				num2 = 60;
			}
			else
			{
				num2 = 480;
			}
			goto IL_0285;
		}
		if (kind != (FailKind)1)
		{
			if (kind != (FailKind)3)
			{
				goto IL_0224;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj6 = 30;
			goto IL_026a;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int val2 = 5 << num;
		int val3 = 120;
		goto IL_02ba;
		IL_02ba:
		num2 = Math.Min(val2, val3);
		goto IL_0285;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num4 = UnityEngine.Random.Range(num3, 0f);
		float num5 = num4 * (float)num2;
		return (int)num5;
		IL_0224:
		num2 = 0;
		goto IL_0285;
		IL_026a:
		val2 = obj6 << num;
		val3 = 300;
		goto IL_02ba;
	}

	private static IEnumerator AuthenticateOnce(string metaUserId, string displayName, Action<Outcome> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE988]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CAuthenticateOnce_003Ed__138 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = metaUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 48;
			obj4 = displayName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 32;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static Beat JudgeBeat(long status, string reason, string category)
	{
		//IL_0035: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_057e: Expected Obj, but got I4
		//IL_0536: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		Beat result;
		if (status == 403 || status == 200)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9C8]");
			object obj = 0;
			string text2;
			if (reason != null)
			{
				string text = reason.ToLowerInvariant();
				text2 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj2 = 0;
				text2 = (string)obj2;
			}
			bool flag = category == (string)obj;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				if (text2 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (Beat)ex;
				}
				if (!text2.Contains((string)obj))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9B8]");
					object obj4 = 0;
					bool flag3 = category == (string)obj4;
					bool flag4 = !flag3;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9C0]");
						object value = 0;
						if (!text2.Contains((string)value))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9B0]");
							object value2 = 0;
							if (text2.Contains((string)value2))
							{
								result = (Beat)5;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9A0]");
								object value3 = 0;
								bool flag5 = text2.Contains((string)value3);
								bool flag6 = !flag5;
								object obj6 = !flag6;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9D8]");
									object value4 = 0;
									bool flag7 = text2.Contains((string)value4);
									bool flag8 = !flag7;
									object obj7 = !flag8;
									if (obj7 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9F8]");
										object value5 = 0;
										bool flag9 = text2.Contains((string)value5);
										bool flag10 = !flag9;
										object obj8 = !flag10;
										if (obj8 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE998]");
											object value6 = 0;
											bool flag11 = text2.Contains((string)value6);
											bool flag12 = !flag11;
											object obj9 = !flag12;
											if (obj9 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9E0]");
												object value7 = 0;
												bool flag13 = text2.Contains((string)value7);
												bool flag14 = !flag13;
												object obj10 = !flag14;
												if (obj10 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9D0]");
													object value8 = 0;
													bool flag15 = text2.Contains((string)value8);
													bool flag16 = !flag15;
													object obj11 = !flag16;
													if (obj11 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE990]");
														object value9 = 0;
														bool flag17 = text2.Contains((string)value9);
														bool flag18 = !flag17;
														object obj12 = !flag18;
														if (obj12 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA00]");
															object value10 = 0;
															if (!text2.Contains((string)value10))
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9F0]");
																object value11 = 0;
																if (text2.Contains((string)value11))
																{
																	result = (Beat)2;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9E8]");
																	object value12 = 0;
																	bool flag19 = text2.Contains((string)value12);
																	bool flag20 = !flag19;
																	object obj13 = !flag20;
																	result = (Beat)2;
																	if (obj13 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9A8]");
																		object value13 = 0;
																		bool flag21 = text2.Contains((string)value13);
																		bool flag22 = !flag21;
																		object obj14 = !flag22;
																		object obj15 = ~obj14;
																		result = ((obj15 == null) ? ((Beat)2) : ((Beat)0));
																	}
																}
																goto IL_058c;
															}
														}
													}
												}
											}
										}
									}
								}
								result = (Beat)1;
							}
							goto IL_058c;
						}
					}
					result = (Beat)4;
					goto IL_058c;
				}
			}
			result = (Beat)3;
		}
		else
		{
			result = (Beat)0;
		}
		goto IL_058c;
		IL_058c:
		return result;
	}

	private static float Backoff(int failures, float baseSeconds, float capSeconds)
	{
		//IL_00c7: Expected F4, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_010b: Invalid comparison between F8 and I4
		//IL_011a: Invalid comparison between F8 and I4
		//IL_012d: Expected Obj, but got F8
		//IL_013a: Expected Obj, but got F8
		//IL_016f: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		if (failures >= 1)
		{
			object obj = failures - 17;
			bool flag = (nint)obj < 0;
			int num = failures ^ 0x11;
			int num2 = failures ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			int num4 = ((obj3 != null) ? 17 : failures);
			object obj4 = num4 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D130");
			double num5 = 1.0 * (double)baseSeconds;
			float num7 = default;
			double num6 = num5 - (double)num7;
			bool flag4 = num6 < 0.0;
			bool flag5 = num6 == 0.0;
			object obj5 = num5 ^ (double)num7;
			object obj6 = num5 ^ num6;
			object obj7 = obj5 & obj6;
			bool flag6 = (nint)obj7 < 0;
			bool flag7 = flag4 == flag6;
			object obj8 = !flag5;
			object obj9 = flag7 & obj8;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
			}
			return UnityEngine.Random.Range(0f, (float)num5);
		}
		return 0f;
	}

	private unsafe static float RetryAfterOf(UnityWebRequest request)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		//IL_005b: Expected F4, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got Ref
		//IL_0250: Expected F4, but got I4
		//IL_0138: Expected F4, but got I4
		//IL_014f: Invalid comparison between F4 and I4
		//IL_0161: Expected F4, but got I4
		//IL_0182: Expected F4, but got I4
		float result;
		nint num = default;
		if (request != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA08]");
			object name = 0;
			string responseHeader = request.GetResponseHeader((string)name);
			bool flag = string.IsNullOrEmpty(responseHeader);
			bool flag2 = !flag;
			object obj = !flag2;
			result = 0f;
			if (obj == null)
			{
				bool flag3 = responseHeader == null;
				object obj2 = 0;
				num = unchecked((nint)null);
				if (flag3)
				{
					goto IL_0195;
				}
				string s = responseHeader.Trim();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v24+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				bool flag5 = float.TryParse(s, (NumberStyles)167, (IFormatProvider)invariantCulture, out var result2);
				bool flag6 = !flag5;
				result = 0f;
				if (!flag6)
				{
					bool flag7 = !(result2 > 0f);
					result = 0f;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
						result = 0f;
					}
				}
			}
			goto IL_02e0;
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0195;
		IL_0195:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag8 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj10 = default;
			object obj9 = obj10 & 1;
			if (obj9 != null)
			{
				object obj11 = 0;
				object obj13 = default;
				object obj12 = (object)(&obj13);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				result = 0f;
				goto IL_02e0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj14 = obj8;
			num = 101790920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj2 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		float result3 = default;
		return result3;
		IL_02e0:
		return result;
	}

	private static float BeatInterval()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num2 = UnityEngine.Random.Range(num, 0f);
		return num2 * 66f;
	}

	private static bool BeatDue(float nextBeatAt, float notBefore, float lastBeatEnd)
	{
		//IL_0042: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_00bd: Invalid comparison between F4 and I4
		//IL_00d0: Expected Obj, but got F4
		//IL_00dd: Expected Obj, but got F4
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (!(realtimeSinceStartup < notBefore))
		{
			if (!(realtimeSinceStartup < nextBeatAt))
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+194]");
			if ((nint)0 != 0)
			{
				float num = lastBeatEnd + 5f;
				float num2 = realtimeSinceStartup - num;
				bool flag2 = num2 < 0f;
				object obj5 = realtimeSinceStartup ^ num;
				object obj6 = realtimeSinceStartup ^ num2;
				object obj7 = obj5 & obj6;
				bool flag3 = (nint)obj7 < 0;
				return flag2 == flag3;
			}
		}
		return false;
	}

	private static IEnumerator WaitTrying(float seconds, int mine)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		CosmeticTerminal._003CWaitTrying_003Ed__145 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			obj2.seconds = seconds;
			obj2.mine = mine;
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static IEnumerator HeartbeatLoop()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CHeartbeatLoop_003Ed__146 obj2 = default;
		obj2._002Ector(0);
		return (IEnumerator)(object)obj2;
	}

	public static void TicketRefused(string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE570]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE568]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj7 = 0;
			string message = (string)obj5 + why + (string)obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+A0]");
			object obj12 = 0;
			_ = 1;
			_ = 0;
		}
	}

	private static bool TicketFresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I8
		//IL_031a: Expected Obj, but got I4
		//IL_0323: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+28]");
		bool flag2 = string.IsNullOrEmpty((string)0);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v9+160]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v22+A0]");
					obj8 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v9+180]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v9+20]");
				bool flag6 = (string)num != (string)0;
				bool flag7 = !flag6;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v15+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v15+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v11+174]");
					if ((nint)0 <= (nint)7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v16+E4]");
						bool flag9 = (nint)0 == 0;
						object obj17 = !flag9;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTimeOffset utcNow = DateTimeOffset.UtcNow;
						DateTimeOffset dateTimeOffset = default;
						long num2 = dateTimeOffset.ToUnixTimeSeconds();
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17+E4]");
						bool flag10 = (nint)0 == 0;
						object obj19 = !flag10;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj18 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v18+160]");
						object obj21 = num2 - 0;
						bool flag11 = (nint)obj21 < 600;
						object obj22 = !flag11;
						return (byte)(int)(~obj22) != 0;
					}
				}
			}
		}
		return false;
	}

	public static IEnumerator RefreshPhotonTicket(Action<bool, string> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE370]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CRefreshPhotonTicket_003Ed__158 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static IEnumerator ReportKick(string targetPlayFabId, string targetName, string reason, string details, string roomName)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CReportKick_003Ed__159 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = targetPlayFabId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 40;
			obj4 = targetName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 48;
			obj5 = reason;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 56;
			obj6 = details;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj2 + 64;
			obj7 = roomName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static IEnumerator VerifyPeer(string pfid, string sid, string sig, Action<bool> done)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF48]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CVerifyPeer_003Ed__160 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = pfid;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 48;
			obj4 = sid;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 56;
			obj5 = sig;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj2 + 32;
			obj6 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public static FailKind Classify(string reason, string category)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_07b2: Expected I4, but got Obj
		//IL_0246: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_04f5: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I
		//IL_05b2: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got I
		//IL_05fb: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_068d: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I
		//IL_06d6: Expected Obj, but got I4
		//IL_06f4: Expected Obj, but got I
		//IL_071f: Expected Obj, but got I4
		//IL_0746: Expected Obj, but got I
		//IL_0771: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA20]");
		object obj = 0;
		FailKind result;
		if (category == (string)obj)
		{
			result = (FailKind)5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA60]");
			object obj2 = 0;
			if (!(category == (string)obj2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9C8]");
				object obj3 = 0;
				if (category == (string)obj3)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9B8]");
				object obj4 = 0;
				if (category == (string)obj4)
				{
					goto IL_00f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA48]");
				object obj5 = 0;
				if (category == (string)obj5)
				{
					goto IL_0145;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA28]");
				object obj6 = 0;
				bool flag = category == (string)obj6;
				bool flag2 = !flag;
				object obj7 = !flag2;
				if (obj7 != null || string.IsNullOrEmpty(reason))
				{
					goto IL_01c6;
				}
				if (reason != null)
				{
					string text = reason.ToLowerInvariant();
					if (text != null)
					{
						bool flag3 = text.Contains((string)obj3);
						bool flag4 = !flag3;
						object obj8 = !flag4;
						if (obj8 != null)
						{
							goto IL_00ad;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA70]");
						object value = 0;
						bool flag5 = text.Contains((string)value);
						bool flag6 = !flag5;
						object obj9 = !flag6;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA40]");
							object value2 = 0;
							bool flag7 = text.Contains((string)value2);
							bool flag8 = !flag7;
							object obj10 = !flag8;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA78]");
								object value3 = 0;
								bool flag9 = text.Contains((string)value3);
								bool flag10 = !flag9;
								object obj11 = !flag10;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE038]");
									object value4 = 0;
									bool flag11 = text.Contains((string)value4);
									bool flag12 = !flag11;
									object obj12 = !flag12;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0B0]");
										object value5 = 0;
										bool flag13 = text.Contains((string)value5);
										bool flag14 = !flag13;
										object obj13 = !flag14;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8D8]");
											object value6 = 0;
											bool flag15 = text.Contains((string)value6);
											bool flag16 = !flag15;
											object obj14 = !flag16;
											if (obj14 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B0]");
												object value7 = 0;
												bool flag17 = text.Contains((string)value7);
												bool flag18 = !flag17;
												object obj15 = !flag18;
												if (obj15 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8D0]");
													object value8 = 0;
													bool flag19 = text.Contains((string)value8);
													bool flag20 = !flag19;
													object obj16 = !flag20;
													if (obj16 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA68]");
														object value9 = 0;
														bool flag21 = text.Contains((string)value9);
														bool flag22 = !flag21;
														object obj17 = !flag22;
														if (obj17 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0D0]");
															object value10 = 0;
															bool flag23 = text.Contains((string)value10);
															bool flag24 = !flag23;
															object obj18 = !flag24;
															if (obj18 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA58]");
																object value11 = 0;
																bool flag25 = text.Contains((string)value11);
																bool flag26 = !flag25;
																object obj19 = !flag26;
																if (obj19 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA50]");
																	object value12 = 0;
																	bool flag27 = text.Contains((string)value12);
																	bool flag28 = !flag27;
																	object obj20 = !flag28;
																	if (obj20 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA30]");
																		object value13 = 0;
																		bool flag29 = text.Contains((string)value13);
																		bool flag30 = !flag29;
																		object obj21 = !flag30;
																		if (obj21 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA00]");
																			object value14 = 0;
																			bool flag31 = text.Contains((string)value14);
																			bool flag32 = !flag31;
																			object obj22 = !flag32;
																			if (obj22 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE9F0]");
																				object value15 = 0;
																				bool flag33 = text.Contains((string)value15);
																				bool flag34 = !flag33;
																				object obj23 = !flag34;
																				if (obj23 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA80]");
																					object value16 = 0;
																					bool flag35 = text.Contains((string)value16);
																					bool flag36 = !flag35;
																					object obj24 = !flag36;
																					if (obj24 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA88]");
																						object value17 = 0;
																						bool flag37 = text.Contains((string)value17);
																						bool flag38 = !flag37;
																						object obj25 = !flag38;
																						result = (FailKind)3;
																						if (obj25 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA38]");
																							object value18 = 0;
																							bool flag39 = text.Contains((string)value18);
																							bool flag40 = !flag39;
																							object obj26 = !flag40;
																							object obj27 = ~obj26;
																							result = ((obj27 != null) ? ((FailKind)1) : ((FailKind)3));
																						}
																						goto IL_07e0;
																					}
																				}
																			}
																		}
																	}
																}
																goto IL_0145;
															}
														}
													}
												}
											}
										}
										goto IL_01c6;
									}
								}
							}
						}
						goto IL_00f9;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (FailKind)ex;
			}
			result = (FailKind)6;
		}
		goto IL_07e0;
		IL_00ad:
		result = (FailKind)4;
		goto IL_07e0;
		IL_07e0:
		return result;
		IL_01c6:
		result = (FailKind)1;
		goto IL_07e0;
		IL_0145:
		result = (FailKind)3;
		goto IL_07e0;
		IL_00f9:
		result = (FailKind)2;
		goto IL_07e0;
	}

	private unsafe static Outcome Failure(string error, string category)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0063: Expected Obj, but got Ref
		//IL_0097: Expected Obj, but got I4
		//IL_0035: Expected VT, but got I4
		//IL_003e: Expected native int or pointer, but got VT
		//IL_0050: Expected I4, but got VT
		//IL_004b: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj3 = default;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Outcome outcome = (Outcome)Classify(error, category);
		Outcome outcome2 = default;
		((Outcome*)(nint)outcome2)->Success = false;
		((Outcome*)(nint)outcome2)->Kind = (FailKind)outcome;
		return outcome;
	}

	public static void SessionRefused(string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA90]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEA98]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj7 = 0;
			string message = (string)obj5 + why + (string)obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v10+B4]");
			object obj13 = (nint)0 + (nint)1;
			Logout();
		}
	}

	private static void Logout()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj5 = (nint)0 + (nint)40;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+A0]");
		object obj7 = (nint)0 + (nint)208;
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj9 = (nint)0 + (nint)200;
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)192;
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+140]");
		((Dictionary<System.__Canon, System.__Canon>)0).Clear();
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v19+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v2+78]");
		object obj17 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v2+13C]");
		object obj18 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v2+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj19 = !flag2;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v15+78]");
				obj17 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13+40]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13+28]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v13+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private unsafe static string Server()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b85: Expected Obj, but got I4
		//IL_0df6: Expected Obj, but got I
		//IL_0e16: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_0ba3: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I4
		//IL_0be8: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_0c53: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got Ref
		//IL_0490: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I
		//IL_04be: Expected I, but got Obj
		//IL_04ce: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got Ref
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I8
		//IL_0afb: Expected Obj, but got I4
		//IL_0d37: Expected Obj, but got I4
		//IL_0c8c: Expected Obj, but got I
		//IL_0cbc: Expected Obj, but got I4
		//IL_0cc9: Expected Obj, but got Ref
		//IL_0cda: Expected Obj, but got I4
		//IL_0e55: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got Ref
		//IL_05d5: Expected Obj, but got I4
		//IL_09b6: Expected Obj, but got I4
		//IL_0967: Expected Obj, but got I4
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I
		//IL_0db4: Expected Obj, but got I
		//IL_0903: Expected Obj, but got I
		//IL_060b: Expected Obj, but got I4
		//IL_0618: Expected Obj, but got Ref
		//IL_0629: Expected Obj, but got I4
		//IL_09fe: Expected Obj, but got I4
		//IL_0974: Expected I, but got Obj
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_0663: Expected Obj, but got I4
		//IL_066c: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got Ref
		//IL_068a: Expected Obj, but got I4
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_06d8: Expected Obj, but got I4
		//IL_079c: Expected Obj, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07cb: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I4
		//IL_07e1: Expected Obj, but got Ref
		//IL_07f2: Expected Obj, but got I4
		//IL_0718: Expected Obj, but got I
		//IL_0748: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got Ref
		//IL_0766: Expected Obj, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected Obj, but got Unknown
		//IL_086b: Expected Obj, but got I4
		//IL_0d54: Expected Obj, but got I4
		//IL_0d61: Expected Obj, but got Ref
		//IL_0d6a: Expected Obj, but got I4
		//IL_089b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+A8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_005c;
			}
			goto IL_006b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v53+A0]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+98]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+98]");
		byte[] array = default;
		char[] array2 = default;
		Encoding encoding;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v6+18]");
			array = (byte[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj11 = obj;
			encoding = null;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v82+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v82+A0]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+98]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+98]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v48+18]");
				obj5 = 0;
				Encoding encoding2 = encoding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v48+18]");
				if ((nint)encoding2 >= 0)
				{
					goto IL_03a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v82+E4]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v82+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				nint num2 = num;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v82+A0]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v35 (Il2CppClass<System.Text.Encoding>)+98]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v35 (Il2CppClass<System.Text.Encoding>)+98]");
					bool flag6 = (nint)0 == 0;
					num = num2;
					if (flag6)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v48+18]");
				obj5 = 0;
				Encoding encoding3 = encoding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v48+18]");
				bool flag7 = (nint)encoding3 < 0;
				object obj15 = !flag7;
				num = num2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v35 (Il2CppClass<System.Text.Encoding>)+90]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v35 (Il2CppClass<System.Text.Encoding>)+90]");
					if ((nint)0 == 0)
					{
						break;
					}
					Encoding encoding4 = encoding;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+18]");
					object obj16 = encoding4 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+18]");
					object obj17 = obj16 * 0;
					obj5 = (object)encoding - obj17;
					object obj18 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+18]");
					bool flag8 = (nint)obj18 < 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						if (array2 == null)
						{
							break;
						}
						bool flag9 = (nint)encoding < array2.Length;
						object obj20 = !flag9;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v35 (Il2CppClass<System.Text.Encoding>)+90]");
							object obj21 = 0 + obj5;
							object obj22 = obj13 + (object)encoding;
							obj5 = (object)array2 + (object)encoding;
							encoding = (Encoding)(encoding + 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X9_v37+20]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v49+20]");
							object obj23 = num3 ^ 0;
							continue;
						}
					}
				}
				goto IL_0a1f;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a1f;
		IL_005c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_006b;
		IL_0a9d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0aab;
		IL_0a6a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0a78;
		IL_0a4e:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0a5c;
		IL_0a5c:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0a6a;
		IL_0da4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v9+8]");
		array = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v847 @ X0_v9] (should have been resolved before IL gen)");
		goto IL_0e3b;
		IL_0954:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		object obj24 = 0;
		goto IL_0da4;
		IL_0a78:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		string text = (string)(object)array;
		goto IL_0a8e;
		IL_0cf0:
		object obj26 = default;
		object obj25 = obj26;
		if (obj26 != null)
		{
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v12+12E]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0954;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v12+98]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X10_v10-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v12+12E]");
				num = -1;
				obj5 = obj28 + 16;
				bool flag10 = num != 1;
				obj28 = obj5;
				if (flag10)
				{
					continue;
				}
				goto IL_0954;
			}
			num = (nint)obj28;
			object obj29 = obj27 + obj28;
			object obj30 = obj29 + 312;
			obj5 = obj28;
			goto IL_0da4;
		}
		goto IL_0e3b;
		IL_0aab:
		NullReferenceException ex7 = new NullReferenceException();
		object obj31 = default;
		OutOfMemoryException ex8 = default;
		if ((nint)text == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj31 = 1;
			array = (byte[])(object)text;
		}
		else
		{
			if ((nint)text != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				string result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj32 = default;
			ex8 = (OutOfMemoryException)obj32;
			array = (byte[])(object)text;
		}
		goto IL_0cf0;
		IL_03a6:
		string text2 = ((string)null).CreateString(array2);
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v33+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v33+E4]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v33+A0]");
		object obj35 = (nint)0 + (nint)168;
		obj35 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		SHA256 sHA = SHA256.Create();
		Encoding uTF = Encoding.UTF8;
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v63+E4]");
		bool flag12 = (nint)0 == 0;
		object obj37 = !flag12;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = uTF == null;
		obj31 = 0;
		ex8 = null;
		SHA256 sHA2 = default;
		obj26 = (object)(&sHA2);
		sHA2 = sHA;
		obj24 = 0;
		text = text2;
		encoding = uTF;
		if (flag13)
		{
			goto IL_0a9d;
		}
		object obj38 = obj;
		num = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+A0]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+260]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v37+A8]");
		int count = default;
		((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])0, 0, count);
		bool flag14 = sHA == null;
		obj31 = 0;
		ex8 = null;
		obj26 = (object)(&sHA2);
		sHA2 = sHA;
		byte[] array3 = default;
		text = (string)(object)array3;
		encoding = uTF;
		if (!flag14)
		{
			byte[] array4 = sHA.ComputeHash(array3);
			object obj40 = obj;
			encoding = (Encoding)4294967295L;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v72+E4]");
				bool flag15 = (nint)0 == 0;
				object obj41 = !flag15;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj40 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v72+A0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
				bool flag16 = (nint)0 == 0;
				obj31 = 0;
				ex8 = null;
				obj26 = (object)(&sHA2);
				sHA2 = sHA;
				obj24 = 0;
				array = array3;
				if (flag16)
				{
					break;
				}
				object obj43 = encoding + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v3 (Il2CppClass<System.Text.Encoding>)+18]");
				bool flag17 = (nint)obj43 >= 0;
				obj31 = 0;
				ex8 = null;
				obj26 = (object)(&sHA2);
				sHA2 = sHA;
				obj24 = 0;
				obj5 = obj43;
				array = array3;
				if (!flag17)
				{
					bool flag18 = array4 == null;
					obj31 = 0;
					ex8 = null;
					obj26 = (object)(&sHA2);
					sHA2 = sHA;
					obj24 = 0;
					obj5 = obj43;
					array = array3;
					if (flag18)
					{
						goto IL_0a4e;
					}
					bool flag19 = (nint)obj43 < array4.Length;
					object obj44 = !flag19;
					obj31 = 0;
					ex8 = null;
					obj26 = (object)(&sHA2);
					sHA2 = sHA;
					obj24 = 0;
					obj5 = obj43;
					array = array3;
					if (obj44 != null)
					{
						goto IL_0a40;
					}
					obj5 = (object)array4 + obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v72+E4]");
					bool flag20 = (nint)0 == 0;
					object obj45 = !flag20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
					nint num4 = 0;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj40 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v72+A0]");
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
						bool flag21 = (nint)0 == 0;
						obj31 = 0;
						ex8 = null;
						obj26 = (object)(&sHA2);
						sHA2 = sHA;
						obj24 = 0;
						array = array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v43+A0]");
						num = 0;
						if (flag21)
						{
							goto IL_0a6a;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X9_v29 (Il2CppClass<System.Text.Encoding>)+18]");
					obj5 = 0;
					encoding = (Encoding)(encoding + 1);
					Encoding encoding5 = encoding;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X9_v29 (Il2CppClass<System.Text.Encoding>)+18]");
					bool flag22 = (nint)encoding5 < 0;
					object obj46 = !flag22;
					obj31 = 0;
					ex8 = null;
					obj26 = (object)(&sHA2);
					sHA2 = sHA;
					obj24 = 0;
					array = array3;
					num = num4;
					if (obj46 != null)
					{
						goto IL_0a5c;
					}
					object obj47 = num4 + obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v3+20]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X9_v30+20]");
					if (num5 == 0)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v72+E4]");
					bool flag23 = (nint)0 == 0;
					object obj48 = !flag23;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj49 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v44+A0]");
						obj42 = 0;
					}
					_ = 1;
					obj31 = 0;
					ex8 = null;
					obj26 = (object)(&sHA2);
					obj24 = 0;
					array = array3;
					num = 1;
				}
				goto IL_0cf0;
			}
			goto IL_0a32;
		}
		goto IL_0aab;
		IL_0a40:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_0a4e;
		IL_006b:
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v56+A0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v57+A8]");
		return (string)0;
		IL_0a1f:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		sHA2 = null;
		goto IL_0a32;
		IL_0a32:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0a40;
		IL_0a8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0a9d;
		IL_0e3b:
		bool flag24 = ex8 == null;
		object obj52 = !flag24;
		if (obj52 != null)
		{
			goto IL_0a78;
		}
		bool flag25 = obj31 == null;
		object obj53 = !flag25;
		text = (string)(object)array;
		ex6 = ex8;
		if (obj53 == null)
		{
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v90+E4]");
			bool flag26 = (nint)0 == 0;
			object obj54 = !flag26;
			if (obj54 == null)
			{
				goto IL_005c;
			}
			goto IL_006b;
		}
		goto IL_0a8e;
	}

	private static bool Tampered()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isDebugBuild = UnityEngine.Debug.isDebugBuild;
		bool flag2 = !isDebugBuild;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE908]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isAttached = Debugger.IsAttached;
			bool flag4 = !isAttached;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = IsDebuggableBuild();
				bool flag7 = !flag6;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					object obj13 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v16+E4]");
					bool flag8 = (nint)0 == 0;
					object obj14 = !flag8;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!HasNativeHook())
					{
						object obj15 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v19+E4]");
						bool flag9 = (nint)0 == 0;
						object obj16 = !flag9;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return HasModLoader();
					}
				}
			}
		}
		return true;
	}

	public static string LoadedText(string maps)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_03f0: Expected I, but got Obj
		//IL_0400: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I8
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_046c: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		StringBuilder stringBuilder = default;
		if (maps != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			stringBuilder._002Ector(maps._stringLength);
			string[] array = maps.Split('\n', (StringSplitOptions)0);
			if (array != null)
			{
				object obj2 = array.Length;
				bool flag = array.Length < 1;
				object obj3 = 0;
				if (flag)
				{
					goto IL_03cb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB68]");
				object value = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB70]");
				object value2 = 0;
				object obj4 = 0;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj5 = !flag2;
					if (obj5 != null)
					{
						break;
					}
					object obj6 = (object)array + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11+20]");
						string[] array2 = ((string)0).Split('/', (StringSplitOptions)0);
						if (array2 != null)
						{
							bool flag3 = array2.Length < 1;
							obj3 = 0;
							if (!flag3)
							{
								object obj7 = array2.Length & 0xFFFFFFFFL;
								object obj8 = array2 + 32;
								object obj9 = 0;
								object obj10 = 0;
								while (true)
								{
									bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
									object obj11 = !flag4;
									if (obj11 != null)
									{
										break;
									}
									if (obj9 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v6+v70 @ X26_v8*8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v6+v70 @ X26_v8*8]");
											bool flag5 = ((string)0).StartsWith((string)value, (StringComparison)4);
											bool flag6 = !flag5;
											object obj12 = !flag6;
											obj3 = 0;
											if (obj12 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v6+v70 @ X26_v8*8]");
												bool flag7 = ((string)0).EndsWith((string)value2, (StringComparison)4);
												bool flag8 = !flag7;
												obj10 = 0;
												if (flag8)
												{
													goto IL_02a1;
												}
												obj3 = 0;
											}
											goto IL_0320;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v6+v70 @ X26_v8*8]");
										if ((nint)0 != 0)
										{
											goto IL_02a1;
										}
									}
									goto IL_041a;
									IL_0320:
									obj7 = array2.Length;
									object obj13 = obj9 + 1;
									bool flag9 = (nint)obj13 < array2.Length;
									obj9 = obj13;
									obj10 = obj3;
									if (flag9)
									{
										continue;
									}
									goto IL_0366;
									IL_02a1:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v6+v70 @ X26_v8*8]");
									string value3 = ((string)0).ToLowerInvariant();
									if (stringBuilder != null)
									{
										StringBuilder stringBuilder2 = stringBuilder.Append(value3);
										if (stringBuilder2 != null)
										{
											StringBuilder stringBuilder3 = stringBuilder2.Append('/');
											obj3 = obj10;
											goto IL_0320;
										}
									}
									goto IL_041a;
								}
								break;
							}
							goto IL_0366;
						}
					}
					goto IL_041a;
					IL_0366:
					if (stringBuilder != null)
					{
						StringBuilder stringBuilder4 = stringBuilder.Append('\n');
						obj2 = array.Length;
						obj4++;
						if ((nint)obj4 < array.Length)
						{
							continue;
						}
						goto IL_03cb;
					}
					goto IL_041a;
				}
				goto IL_0428;
			}
		}
		goto IL_041a;
		IL_041a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0428;
		IL_0428:
		return (string)(object)new IndexOutOfRangeException();
		IL_03cb:
		if (stringBuilder != null)
		{
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v255 @ X2_v6 (should have been resolved before IL gen)");
		}
		goto IL_041a;
	}

	private static bool HasNativeHook()
	{
		//IL_0010: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0570: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05f0: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_068d: Expected Obj, but got I4
		//IL_04ad: Expected I4, but got Obj
		//IL_0345: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAF0]");
		string path = (string)0;
		string maps = File.ReadAllText(path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LoadedText(maps);
		string[] array;
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB08]");
			object value = 0;
			bool flag2 = text.Contains((string)value);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB00]");
				object value2 = 0;
				bool flag4 = text.Contains((string)value2);
				bool flag5 = !flag4;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB18]");
					object value3 = 0;
					bool flag6 = text.Contains((string)value3);
					bool flag7 = !flag6;
					object obj6 = !flag7;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB28]");
						object value4 = 0;
						bool flag8 = text.Contains((string)value4);
						bool flag9 = !flag8;
						object obj7 = !flag9;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB10]");
							object value5 = 0;
							bool flag10 = text.Contains((string)value5);
							bool flag11 = !flag10;
							object obj8 = 0;
							if (flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAF8]");
								object path2 = 0;
								array = File.ReadAllLines((string)path2);
								bool flag12 = array == null;
								int num = 0;
								if (flag12)
								{
									goto IL_04b2;
								}
								object obj9 = array.Length;
								if (array.Length >= 1)
								{
									object obj10 = array + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB20]");
									object obj11 = 0;
									object obj12 = 0;
									string text2 = null;
									while (true)
									{
										bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
										object obj13 = !flag13;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X23_v7+v301 @ X21_v7*8]");
											if ((nint)0 != 0)
											{
												text2 = (string)obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X23_v7+v301 @ X21_v7*8]");
												bool flag14 = ((string)0).StartsWith((string)obj11);
												bool flag15 = !flag14;
												object obj14 = !flag15;
												if (obj14 != null)
												{
													break;
												}
												obj9 = array.Length;
												obj12++;
												bool flag16 = (nint)obj12 < array.Length;
												obj8 = 0;
												if (!flag16)
												{
													return false;
												}
												continue;
											}
										}
										else
										{
											IndexOutOfRangeException ex = new IndexOutOfRangeException();
										}
										NullReferenceException ex2 = new NullReferenceException();
										num = (int)text2;
										goto IL_04b2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X23_v7+v301 @ X21_v7*8]");
									string text3 = ((string)0).Substring(10);
									bool flag17 = text3 == null;
									obj8 = 0;
									num = 10;
									if (flag17)
									{
										goto IL_04c0;
									}
									string text4 = text3.Trim();
									bool flag18 = text4 == null;
									obj8 = 0;
									num = 0;
									if (flag18)
									{
										goto IL_04ce;
									}
									if (text4._stringLength > 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
										object obj15 = 0;
										return text4 != (string)obj15;
									}
								}
								goto IL_05c1;
							}
						}
					}
				}
			}
			return true;
		}
		NullReferenceException ex3 = new NullReferenceException();
		object obj16 = 0;
		NullReferenceException ex4 = ex3;
		NullReferenceException ex5 = default;
		object obj19 = default;
		object obj21 = default;
		NullReferenceException ex6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			bool flag19 = (nint)obj16 != 1;
			ex4 = ex5;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj17 = 0;
				object obj18 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj20 = obj21 & 1;
				if (obj20 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj22 = obj19;
				obj16 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex4 = ex6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		goto IL_05c1;
		IL_04b2:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_04c0;
		IL_04ce:
		string[] array2 = array;
		throw new NullReferenceException();
		IL_04c0:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_04ce;
		IL_05c1:
		return false;
	}

	private static string NativeSignals()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_12b7: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_1116: Expected I4, but got Obj
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_04ae: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I4
		//IL_04ea: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got I4
		//IL_06be: Expected Obj, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_05fa: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I
		//IL_068c: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I
		//IL_0ad3: Expected Obj, but got I4
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected Obj, but got Unknown
		//IL_073c: Expected Obj, but got I
		//IL_0745: Expected Obj, but got I4
		//IL_0b01: Expected Obj, but got I4
		//IL_12f5: Expected Obj, but got I4
		//IL_0b1f: Expected Obj, but got I
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_0b61: Expected Obj, but got I8
		//IL_075f: Expected Obj, but got I
		//IL_0b8e: Expected Obj, but got I
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected Obj, but got Unknown
		//IL_0bd8: Expected Obj, but got I4
		//IL_0bee: Expected Obj, but got I
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected Obj, but got Unknown
		//IL_07a1: Expected Obj, but got I
		//IL_07bf: Expected Obj, but got I4
		//IL_0830: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_0c31: Expected Obj, but got I
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected Obj, but got Unknown
		//IL_0c73: Expected Obj, but got I8
		//IL_07d7: Expected Obj, but got I4
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected Obj, but got Unknown
		//IL_07fe: Expected Obj, but got I4
		//IL_0888: Expected Obj, but got I4
		//IL_0ca0: Expected Obj, but got I
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected Obj, but got Unknown
		//IL_0cea: Expected Obj, but got I4
		//IL_0d00: Expected Obj, but got I
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected Obj, but got Unknown
		//IL_0815: Expected Obj, but got I4
		//IL_08bc: Expected Obj, but got I4
		//IL_0d43: Expected Obj, but got I
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected Obj, but got Unknown
		//IL_0d8d: Expected Obj, but got I4
		//IL_0da3: Expected Obj, but got I
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected Obj, but got Unknown
		//IL_08da: Expected Obj, but got I
		//IL_0903: Expected Obj, but got I4
		//IL_0de6: Expected Obj, but got I
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected Obj, but got Unknown
		//IL_0929: Expected Obj, but got I4
		//IL_0931: Expected I4, but got Obj
		//IL_0e43: Expected Obj, but got I
		//IL_0e53: Expected Obj, but got I
		//IL_0e6d: Expected Obj, but got I8
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected Obj, but got Unknown
		//IL_0e84: Expected Obj, but got I4
		//IL_1073: Expected Obj, but got I
		//IL_131c: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I4
		//IL_09a9: Expected I4, but got Obj
		//IL_0ea2: Expected Obj, but got I
		//IL_09e4: Expected Obj, but got I4
		//IL_0ff9: Expected Obj, but got I
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected Obj, but got Unknown
		//IL_0a67: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected Obj, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a52: Expected Obj, but got I4
		//IL_0f5d: Expected Obj, but got I4
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Expected Obj, but got Unknown
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected Obj, but got Unknown
		//IL_11fe: Expected Obj, but got I
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected Obj, but got Unknown
		//IL_1278: Expected Obj, but got I4
		//IL_128b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAF0]");
		object path = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		string maps = File.ReadAllText((string)path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = LoadedText(maps);
		bool flag2 = text2 == null;
		int num = 0;
		string text3;
		object obj6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB08]");
			text = (string)0;
			text3 = text;
			bool flag3 = text2.Contains(text);
			bool flag4 = !flag3;
			object obj5 = !flag4;
			obj6 = 0;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB00]");
				object obj7 = 0;
				text3 = (string)obj7;
				bool flag5 = text2.Contains((string)obj7);
				bool flag6 = !flag5;
				object obj8 = !flag6;
				obj6 = 0;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB18]");
					object obj9 = 0;
					text3 = (string)obj9;
					bool flag7 = text2.Contains((string)obj9);
					bool flag8 = !flag7;
					obj6 = 0;
					if (flag8)
					{
						goto IL_02d4;
					}
				}
			}
			if (list != null)
			{
				System.__Canon[] items = list._items;
				int version = list._version + 1;
				list._version = version;
				bool flag9 = list._items == null;
				text3 = text;
				if (!flag9)
				{
					version = list._size;
					bool flag10 = list._size < items.Length;
					object obj10 = !flag10;
					if (obj10 == null)
					{
						object obj11 = list._items + list._size;
						int size = list._size + 1;
						list._size = size;
						object obj12 = obj11 + 32;
						obj12 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						list.AddWithResize((System.__Canon)(object)text);
					}
					goto IL_02d4;
				}
			}
			goto IL_10cd;
		}
		goto IL_111b;
		IL_10b7:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		object obj13;
		obj6 = obj13;
		goto IL_10cd;
		IL_111b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1129;
		IL_049e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBB8]");
		text = (string)0;
		text3 = text;
		bool flag11 = text2.Contains(text);
		bool flag12 = !flag11;
		object obj14 = !flag12;
		obj6 = 0;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBC0]");
			object obj15 = 0;
			text3 = (string)obj15;
			bool flag13 = text2.Contains((string)obj15);
			bool flag14 = !flag13;
			obj6 = 0;
			obj13 = 0;
			if (flag14)
			{
				goto IL_06ae;
			}
		}
		if (list != null)
		{
			System.__Canon[] items2 = list._items;
			object obj16 = obj;
			int version = list._version + 1;
			list._version = version;
			bool flag15 = list._items == null;
			text3 = text;
			if (!flag15)
			{
				version = list._size;
				bool flag16 = list._size < items2.Length;
				object obj17 = !flag16;
				if (obj17 == null)
				{
					object obj18 = list._items + list._size;
					int size2 = list._size + 1;
					list._size = size2;
					object obj19 = obj18 + 32;
					obj19 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj13 = obj6;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X9_v26+20]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v72+A8]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v73+70]");
					obj13 = 0;
					list.AddWithResize((System.__Canon)(object)text);
				}
				goto IL_06ae;
			}
		}
		goto IL_10e9;
		IL_1137:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1145;
		IL_1145:
		throw new NullReferenceException();
		IL_10db:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_10e9;
		IL_080c:
		obj13 = 0;
		goto IL_0a99;
		IL_10e9:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_10f7;
		IL_06ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAF8]");
		object path2 = 0;
		string[] array = File.ReadAllLines((string)path2);
		bool flag17 = array == null;
		obj6 = obj13;
		text3 = null;
		if (!flag17)
		{
			object obj22 = array.Length;
			if (array.Length >= 1)
			{
				object obj23 = array + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB20]");
				object obj24 = 0;
				object obj25 = 0;
				text3 = null;
				while (true)
				{
					bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
					object obj26 = !flag18;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X25_v16+v506 @ X23_v16*8]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X25_v16+v506 @ X23_v16*8]");
						if ((nint)0 != 0)
						{
							text3 = (string)obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X25_v16+v506 @ X23_v16*8]");
							bool flag19 = ((string)0).StartsWith((string)obj24);
							bool flag20 = !flag19;
							object obj27 = !flag20;
							if (obj27 != null)
							{
								break;
							}
							obj22 = array.Length;
							obj25++;
							bool flag21 = (nint)obj25 < array.Length;
							obj13 = 0;
							if (flag21)
							{
								continue;
							}
							goto IL_080c;
						}
					}
					else
					{
						IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
					}
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_10b7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X25_v16+v506 @ X23_v16*8]");
				string text4 = ((string)0).Substring(10);
				bool flag22 = text4 == null;
				obj6 = 0;
				num = 10;
				if (flag22)
				{
					goto IL_1129;
				}
				string text5 = text4.Trim();
				bool flag23 = text5 == null;
				obj6 = 0;
				num = 0;
				if (flag23)
				{
					goto IL_1137;
				}
				bool flag24 = text5._stringLength < 1;
				obj13 = 0;
				if (!flag24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
					object obj28 = 0;
					bool flag25 = text5 != (string)obj28;
					bool flag26 = !flag25;
					obj13 = 0;
					if (!flag26)
					{
						bool flag27 = list == null;
						obj6 = 0;
						num = (int)obj28;
						if (!flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB88]");
							object obj29 = 0;
							System.__Canon[] items3 = list._items;
							object obj30 = obj;
							int version = list._version + 1;
							list._version = version;
							bool flag28 = list._items == null;
							obj6 = 0;
							num = (int)obj29;
							if (!flag28)
							{
								version = list._size;
								bool flag29 = list._size < items3.Length;
								object obj31 = !flag29;
								if (obj31 == null)
								{
									object obj32 = list._items + list._size;
									int size3 = list._size + 1;
									list._size = size3;
									object obj33 = obj32 + 32;
									obj33 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj13 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v24+20]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v67+A8]");
									object obj35 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v68+70]");
									obj13 = 0;
									list.AddWithResize((System.__Canon)obj29);
								}
								goto IL_0a99;
							}
						}
						goto IL_1145;
					}
				}
			}
			goto IL_0a99;
		}
		goto IL_1105;
		IL_0a99:
		object obj37 = default;
		NullReferenceException ex10 = default;
		object obj68 = default;
		object obj70 = default;
		NullReferenceException ex11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag30 = obj37 == null;
			obj6 = obj13;
			text3 = (string)6;
			if (flag30)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v48+18]");
			bool flag31 = (nint)0 == 0;
			text3 = (string)6;
			object obj24;
			object obj60;
			object obj25;
			if (!flag31)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB78]");
				object obj38 = 0;
				text3 = (string)obj38;
				text = (string)(obj37 + 32);
				text = (string)obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-8]");
				object obj39 = 0 & 0xFFFFFFFEL;
				if (obj39 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBB0]");
					object obj40 = 0;
					text3 = (string)obj40;
					text = (string)(obj37 + 40);
					text = (string)obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-10]");
					bool flag32 = (nint)0 < (nint)2;
					object obj41 = !flag32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-10]");
					object obj42 = -2;
					bool flag33 = obj42 == null;
					object obj43 = ~obj41;
					object obj44 = obj43 | flag33;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB80]");
						object obj45 = 0;
						text3 = (string)obj45;
						text = (string)(obj37 + 48);
						text = (string)obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-18]");
						object obj46 = 0 & 0xFFFFFFFCL;
						if (obj46 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBA0]");
							object obj47 = 0;
							text3 = (string)obj47;
							text = (string)(obj37 + 56);
							text = (string)obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-20]");
							bool flag34 = (nint)0 < (nint)4;
							object obj48 = !flag34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-20]");
							object obj49 = -4;
							bool flag35 = obj49 == null;
							object obj50 = ~obj48;
							object obj51 = obj50 | flag35;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB90]");
								object obj52 = 0;
								text3 = (string)obj52;
								text = (string)(obj37 + 64);
								text = (string)obj52;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-28]");
								bool flag36 = (nint)0 < (nint)5;
								object obj53 = !flag36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-28]");
								object obj54 = -5;
								bool flag37 = obj54 == null;
								object obj55 = ~obj53;
								object obj56 = obj55 | flag37;
								if (obj56 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB98]");
									object obj57 = 0;
									text3 = (string)obj57;
									text = (string)(obj37 + 72);
									text = (string)obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-30]");
									if ((nint)0 < (nint)1)
									{
										goto IL_103d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBA8]");
									obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X21_v39 (System.String)-30]");
									object obj58 = 0 & 0xFFFFFFFFL;
									object obj59 = obj37 + 32;
									obj60 = 0;
									string text6 = (string)obj57;
									while (true)
									{
										bool flag38 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58);
										object obj61 = !flag38;
										obj25 = obj60;
										text3 = text6;
										if (obj61 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X26_v16+v650 @ X23_v18*8]");
										if (File.Exists((string)0))
										{
											goto IL_0ec3;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v48+18]");
										obj58 = 0;
										obj25 = obj60 + 1;
										object obj62 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v48+18]");
										bool flag39 = (nint)obj62 < 0;
										text3 = null;
										obj60 = obj25;
										text6 = null;
										if (flag39)
										{
											continue;
										}
										goto IL_103d;
									}
								}
							}
						}
					}
				}
			}
			goto IL_10b7;
			IL_0ec3:
			bool flag40 = list == null;
			string text7 = null;
			if (!flag40)
			{
				System.__Canon[] items4 = list._items;
				int version = list._version + 1;
				list._version = version;
				bool flag41 = list._items == null;
				text7 = (string)obj24;
				if (!flag41)
				{
					bool flag42 = list._size < items4.Length;
					object obj63 = !flag42;
					if (obj63 == null)
					{
						object obj64 = list._items + list._size;
						int size4 = list._size + 1;
						list._size = size4;
						object obj65 = obj64 + 32;
						obj65 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						list.AddWithResize((System.__Canon)obj24);
					}
					goto IL_1062;
				}
			}
			NullReferenceException ex8 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj60;
			NullReferenceException ex9 = ex8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				bool flag43 = (nint)text7 != 1;
				ex9 = ex10;
				if (!flag43)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj66 = 0;
					object obj67 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj69 = obj70 & 1;
					if (obj69 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj71 = obj68;
					text7 = (string)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex9 = ex11;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			text = (string)(object)ex10;
			continue;
			IL_1062:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A0]");
			object separator = 0;
			System.__Canon[] value = list.ToArray();
			return string.Join((string)separator, (string[])(object)value);
			IL_103d:
			bool flag44 = list == null;
			obj6 = obj13;
			if (flag44)
			{
				break;
			}
			goto IL_1062;
		}
		goto IL_10f7;
		IL_02d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB28]");
		text = (string)0;
		text3 = text;
		bool flag45 = text2.Contains(text);
		bool flag46 = !flag45;
		object obj72 = !flag46;
		obj6 = 0;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB10]");
			object obj73 = 0;
			text3 = (string)obj73;
			bool flag47 = text2.Contains((string)obj73);
			bool flag48 = !flag47;
			obj6 = 0;
			if (flag48)
			{
				goto IL_049e;
			}
		}
		if (list != null)
		{
			System.__Canon[] items5 = list._items;
			int version = list._version + 1;
			list._version = version;
			bool flag49 = list._items == null;
			text3 = text;
			if (!flag49)
			{
				version = list._size;
				bool flag50 = list._size < items5.Length;
				object obj74 = !flag50;
				if (obj74 == null)
				{
					object obj75 = list._items + list._size;
					int size5 = list._size + 1;
					list._size = size5;
					object obj76 = obj75 + 32;
					obj76 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					list.AddWithResize((System.__Canon)(object)text);
				}
				goto IL_049e;
			}
		}
		goto IL_10db;
		IL_10cd:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_10db;
		IL_10f7:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_1105;
		IL_1105:
		NullReferenceException ex14 = new NullReferenceException();
		num = (int)text3;
		goto IL_111b;
		IL_1129:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_1137;
	}

	private unsafe static bool IsDebuggableBuild()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b77: Expected Obj, but got I
		//IL_0b9c: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_0bc9: Expected Obj, but got I
		//IL_0beb: Expected Obj, but got I4
		//IL_0f26: Expected Obj, but got I4
		//IL_0f33: Expected Obj, but got Ref
		//IL_0f43: Expected Obj, but got Ref
		//IL_00c1: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got Ref
		//IL_0188: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got Ref
		//IL_01c9: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I4, but got Unknown
		//IL_0218: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got Ref
		//IL_0237: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got Ref
		//IL_0c13: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I4
		//IL_0c65: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_0844: Expected Obj, but got I4
		//IL_0c31: Expected Obj, but got I
		//IL_0c8e: Expected Obj, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_0874: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I4
		//IL_08cb: Expected Obj, but got I4
		//IL_0d40: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		//IL_0d0c: Expected Obj, but got I
		//IL_0e9f: Expected Obj, but got Ref
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_0d69: Expected Obj, but got I4
		//IL_0462: Expected Obj, but got I
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0a8c: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0686: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I4
		//IL_0e1b: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I
		//IL_0ad7: Expected Obj, but got I4
		//IL_0adf: Expected Obj, but got Ref
		//IL_0de7: Expected Obj, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_05f6: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAD0]");
		object obj2 = 0;
		string text = (string)obj2;
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector((string)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj3 = 0;
		System.__Canon _Canon;
		object obj13 = default;
		NullReferenceException ex = default;
		object obj14 = default;
		AndroidJavaObject androidJavaObject2 = default;
		object obj15 = default;
		bool flag4;
		NullReferenceException ex2;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		OutOfMemoryException ex3 = default;
		object obj20 = default;
		bool result;
		object obj24;
		object[] array;
		if (androidJavaClass != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAE0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB8]");
			object obj5 = 0;
			text = (string)obj4;
			array = (object[])obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @357DD18");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v24+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v24+38]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v24+38]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v59+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v94+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v24+38]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v67+10]");
				obj10 = 0;
			}
			AndroidJavaObject androidJavaObject = default;
			bool flag3 = androidJavaObject == null;
			_Canon = null;
			obj13 = 0;
			ex = null;
			obj14 = (object)(&androidJavaObject2);
			androidJavaObject2 = androidJavaObject;
			obj15 = (object)(&androidJavaObject2);
			flag4 = false;
			ex2 = null;
			if (flag3)
			{
				goto IL_074e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAD8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v94+A0]");
			obj17 = 0;
			text = (string)obj16;
			array = (object[])obj17;
			obj18 = obj15;
			System.__Canon _Canon2 = androidJavaObject.Call<System.__Canon>((string)obj16, (object[])obj17);
			bool flag5 = _Canon2 == null;
			obj19 = 0;
			ex3 = null;
			obj20 = (object)(&_Canon);
			_Canon = _Canon2;
			obj13 = 0;
			ex = null;
			obj14 = (object)(&androidJavaObject2);
			androidJavaObject2 = androidJavaObject;
			flag4 = false;
			ex2 = null;
			if (flag5)
			{
				goto IL_0779;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAE8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC0]");
			obj15 = 0;
			text = (string)obj21;
			array = (object[])obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @357DAD8");
			object obj23 = default;
			object obj22 = obj23 >> 1;
			result = (byte)(obj22 & 1) != 0;
			obj24 = 2;
			obj19 = 0;
			ex3 = null;
			obj20 = (object)(&_Canon);
			obj13 = 0;
			ex = null;
			obj14 = (object)(&androidJavaObject2);
			flag4 = false;
			ex2 = null;
			goto IL_0e3e;
		}
		NullReferenceException ex4 = new NullReferenceException();
		_Canon = null;
		androidJavaObject2 = null;
		flag4 = false;
		ex2 = null;
		array = null;
		goto IL_0740;
		IL_0efb:
		result = false;
		goto IL_0e2a;
		IL_07a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj25;
		object obj26 = default;
		bool flag6;
		object obj27;
		OutOfMemoryException ex5;
		object obj28;
		object obj29;
		object obj30;
		NullReferenceException ex6;
		object obj31;
		bool flag7;
		NullReferenceException ex7;
		object[] array2;
		string text2;
		if ((nint)text == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj19 = 1;
		}
		else
		{
			if ((nint)text != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				if ((nint)text == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = 1;
				}
				else
				{
					if ((nint)text != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
						if ((nint)text == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj25 = obj26;
							flag6 = true;
							obj27 = obj19;
							ex5 = ex3;
							obj28 = obj18;
							obj29 = obj17;
							obj30 = obj13;
							ex6 = ex;
							obj31 = obj15;
							flag7 = true;
							ex7 = ex2;
							array2 = array;
							text2 = text;
							result = false;
						}
						else
						{
							if ((nint)text != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
								bool flag8 = (nint)text != 1;
								object obj33 = default;
								object obj32 = obj33;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj34 = 0;
									object obj36 = default;
									object obj35 = obj36;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
									object obj38 = default;
									object obj37 = obj38 & 1;
									if (obj37 != null)
									{
										object obj39 = 0;
										object obj41 = default;
										object obj40 = (object)(&obj41);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										goto IL_0efb;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
									object obj42 = obj36;
									text = (string)(101789696 + 1224);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									array = null;
									object obj43 = default;
									obj32 = obj43;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								bool result2 = default;
								return result2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj25 = obj26;
							flag6 = true;
							obj27 = obj19;
							ex5 = ex3;
							obj28 = obj18;
							obj29 = obj17;
							obj30 = obj13;
							ex6 = ex;
							obj31 = obj15;
							flag7 = flag4;
							object obj44 = default;
							ex7 = (NullReferenceException)obj44;
							array2 = array;
							text2 = text;
							result = false;
						}
						goto IL_0e97;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj45 = default;
					ex = (NullReferenceException)obj45;
				}
				obj25 = obj26;
				obj24 = 0;
				obj27 = obj19;
				ex5 = ex3;
				obj28 = obj18;
				obj29 = obj17;
				obj30 = obj13;
				ex6 = ex;
				obj31 = obj15;
				flag7 = flag4;
				ex7 = ex2;
				array2 = array;
				text2 = text;
				result = false;
				goto IL_03cf;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj46 = default;
			ex3 = (OutOfMemoryException)obj46;
		}
		obj24 = 0;
		result = false;
		goto IL_0e3e;
		IL_0d30:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v84+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v794 @ X0_v84] (should have been resolved before IL gen)");
		goto IL_0c74;
		IL_0498:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_0d30;
		IL_076b:
		OutOfMemoryException ex8 = new OutOfMemoryException();
		goto IL_0779;
		IL_0c74:
		bool flag9 = ex6 == null;
		object obj47 = !flag9;
		obj26 = obj25;
		obj19 = obj27;
		ex3 = ex5;
		obj18 = obj28;
		obj17 = obj29;
		obj13 = obj30;
		ex = ex6;
		obj15 = obj31;
		flag4 = flag7;
		ex2 = ex7;
		array = array2;
		text = text2;
		if (obj47 != null)
		{
			goto IL_076b;
		}
		bool flag10 = obj30 == null;
		object obj48 = !flag10;
		obj26 = obj25;
		obj19 = obj27;
		ex3 = ex5;
		obj18 = obj28;
		obj17 = obj29;
		obj13 = obj30;
		ex = ex6;
		obj15 = obj31;
		flag4 = flag7;
		ex2 = ex7;
		array = array2;
		text = text2;
		NullReferenceException ex9 = ex6;
		if (obj48 != null)
		{
			goto IL_0787;
		}
		bool flag11 = obj24 == null;
		flag6 = flag11;
		goto IL_0e97;
		IL_0e0b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X0_v8+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v954 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_0d4f;
		IL_0e97:
		object obj50 = default;
		object obj49 = (object)(&obj50);
		object obj51 = obj49;
		if (obj49 == null)
		{
			goto IL_0d4f;
		}
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v12+12E]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_062c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v12+98]");
		object obj53 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v8-8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X10_v8-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v12+12E]");
			obj31 = -1;
			obj29 = obj53 + 16;
			bool flag12 = (nint)obj31 != 1;
			obj53 = obj29;
			if (flag12)
			{
				continue;
			}
			goto IL_062c;
		}
		obj31 = obj53;
		object obj54 = obj52 + obj53;
		object obj55 = obj54 + 312;
		obj29 = obj53;
		goto IL_0e0b;
		IL_0e3e:
		object obj56 = obj20;
		if (obj20 == null)
		{
			goto IL_0bf9;
		}
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v20+12E]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v20+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02fb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v20+98]");
		object obj58 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v16-8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X10_v16-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v20+12E]");
			obj15 = -1;
			obj17 = obj58 + 16;
			bool flag13 = (nint)obj15 != 1;
			obj58 = obj17;
			if (flag13)
			{
				continue;
			}
			goto IL_02fb;
		}
		obj15 = obj58;
		object obj59 = obj57 + obj58;
		object obj60 = obj59 + 312;
		obj17 = obj58;
		goto IL_0c55;
		IL_0e2a:
		return result;
		IL_0d4f:
		bool flag14 = ex7 == null;
		object obj61 = !flag14;
		obj26 = obj25;
		obj19 = obj27;
		ex3 = ex5;
		obj18 = obj28;
		obj17 = obj29;
		obj13 = obj30;
		ex = ex6;
		obj15 = obj31;
		flag4 = flag7;
		ex2 = ex7;
		array = array2;
		text = text2;
		if (obj61 != null)
		{
			goto IL_0740;
		}
		bool flag15 = !flag7;
		object obj62 = !flag15;
		obj26 = obj25;
		obj19 = obj27;
		ex3 = ex5;
		obj18 = obj28;
		obj17 = obj29;
		obj13 = obj30;
		ex = ex6;
		obj15 = obj31;
		flag4 = flag7;
		ex2 = ex7;
		array = array2;
		text = text2;
		NullReferenceException ex10 = ex7;
		if (obj62 != null)
		{
			goto IL_075c;
		}
		if (!flag6)
		{
			goto IL_0e2a;
		}
		goto IL_0efb;
		IL_074e:
		ex10 = new NullReferenceException();
		goto IL_075c;
		IL_075c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_076b;
		IL_0740:
		OutOfMemoryException ex11 = new OutOfMemoryException();
		goto IL_074e;
		IL_02fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array = null;
		goto IL_0c55;
		IL_0c55:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v17+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ X0_v17] (should have been resolved before IL gen)");
		goto IL_0bf9;
		IL_0bf9:
		bool flag16 = ex3 == null;
		object obj63 = !flag16;
		if (obj63 != null)
		{
			goto IL_0796;
		}
		bool flag17 = obj19 == null;
		object obj64 = !flag17;
		obj25 = obj26;
		obj27 = obj19;
		ex5 = ex3;
		obj28 = obj18;
		obj29 = obj17;
		obj30 = obj13;
		ex6 = ex;
		obj31 = obj15;
		flag7 = flag4;
		ex7 = ex2;
		array2 = array;
		text2 = text;
		OutOfMemoryException ex12 = ex3;
		if (obj64 == null)
		{
			goto IL_03cf;
		}
		goto IL_07a4;
		IL_0779:
		ex9 = new NullReferenceException();
		goto IL_0787;
		IL_03cf:
		object obj65 = obj14;
		if (obj14 == null)
		{
			goto IL_0c74;
		}
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v50+12E]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v50+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0498;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v50+98]");
		object obj67 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X10_v33-8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X10_v33-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v50+12E]");
			obj31 = -1;
			obj29 = obj67 + 16;
			bool flag18 = (nint)obj31 != 1;
			obj67 = obj29;
			if (flag18)
			{
				continue;
			}
			goto IL_0498;
		}
		obj31 = obj67;
		object obj68 = obj66 + obj67;
		object obj69 = obj68 + 312;
		obj29 = obj67;
		goto IL_0d30;
		IL_0796:
		ex12 = new OutOfMemoryException();
		goto IL_07a4;
		IL_062c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_0e0b;
		IL_0787:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0796;
	}

	private static bool HasModLoader()
	{
		//IL_003e: Expected Obj, but got I4
		//IL_0445: Expected Obj, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I4
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		AppDomain currentDomain = AppDomain.CurrentDomain;
		if (currentDomain == null)
		{
			goto IL_03e7;
		}
		Assembly[] assemblies = currentDomain.GetAssemblies();
		bool flag = assemblies == null;
		string text = null;
		if (!flag)
		{
			object obj = assemblies.Length;
			if (assemblies.Length >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB58]");
				object value = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB38]");
				object value2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB60]");
				object value3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB30]");
				object value4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB50]");
				object value5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB48]");
				object value6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEB40]");
				object obj2 = 0;
				object obj3 = 0;
				text = null;
				object obj8 = default;
				do
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj4 = !flag2;
					if (obj4 == null)
					{
						object obj5 = (object)assemblies + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+20]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+20]");
						if ((nint)0 != 0)
						{
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+2B0]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X8_v17+2A8] (should have been resolved before IL gen)");
							if (obj8 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v34+10]");
								if ((nint)0 == 0)
								{
									goto IL_035d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v34+10]");
								string text2 = ((string)0).ToLowerInvariant();
								bool flag3 = text2 == null;
								text = null;
								if (!flag3)
								{
									bool flag4 = text2.Contains((string)value);
									bool flag5 = !flag4;
									object obj9 = !flag5;
									if (obj9 == null)
									{
										bool flag6 = text2.Contains((string)value2);
										bool flag7 = !flag6;
										object obj10 = !flag7;
										if (obj10 == null)
										{
											bool flag8 = text2.Contains((string)value3);
											bool flag9 = !flag8;
											object obj11 = !flag9;
											if (obj11 == null)
											{
												bool flag10 = text2.Contains((string)value4);
												bool flag11 = !flag10;
												object obj12 = !flag11;
												if (obj12 == null)
												{
													bool flag12 = text2.Contains((string)value5);
													bool flag13 = !flag12;
													object obj13 = !flag13;
													if (obj13 == null)
													{
														bool flag14 = text2.Contains((string)value6);
														bool flag15 = !flag14;
														object obj14 = !flag15;
														if (obj14 == null)
														{
															text = (string)obj2;
															bool flag16 = text2.Contains((string)obj2);
															bool flag17 = !flag16;
															object obj15 = !flag17;
															object obj16 = 0;
															if (obj15 == null)
															{
																goto IL_035d;
															}
														}
													}
												}
											}
										}
									}
									return true;
								}
								goto IL_03d9;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
						}
						NullReferenceException ex2 = new NullReferenceException();
					}
					IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
					goto IL_03d9;
					IL_035d:
					obj = assemblies.Length;
					obj3++;
					continue;
					IL_03d9:
					NullReferenceException ex4 = new NullReferenceException();
					goto IL_03e7;
				}
				while ((nint)obj3 < assemblies.Length);
			}
			goto IL_0393;
		}
		goto IL_03f5;
		IL_03f5:
		NullReferenceException ex5 = new NullReferenceException();
		bool flag18 = (nint)text != 1;
		NullReferenceException ex6 = ex5;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj17 = 0;
			object obj19 = default;
			object obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj21 = default;
			object obj20 = obj21 & 1;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				goto IL_0393;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj22 = obj19;
			text = (string)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj16 = 0;
			NullReferenceException ex7 = default;
			ex6 = ex7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
		IL_0393:
		return false;
		IL_03e7:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_03f5;
	}

	private static void Init()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I4
		//IL_03d2: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02da: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass172_0 obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+D8]");
		if (!string.IsNullOrEmpty((string)0))
		{
			return;
		}
		string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+A0]");
		object obj9 = (nint)0 + (nint)216;
		obj9 = deviceUniqueIdentifier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v8+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v9+D8]");
		string text = Hash((string)0);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10+A0]");
		object obj13 = (nint)0 + (nint)224;
		obj13 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v19+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v14+E8]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v33+A0]");
			obj15 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v14+118]");
		if ((nint)0 != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string dataPath = UnityEngine.Application.dataPath;
		object obj22 = obj3 + 16;
		obj22 = dataPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string version = UnityEngine.Application.version;
		string text2;
		if (version != null)
		{
			object obj23 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v49+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string version2 = UnityEngine.Application.version;
			text2 = version2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A0]");
			object obj25 = 0;
			text2 = (string)obj25;
		}
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v32+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = Hash(text2);
		object obj28 = obj3 + 24;
		obj28 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA850]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBD8]");
		object obj30 = 0;
		Func<System.__Canon> func = default;
		func._002Ector((object)obj3, (IntPtr)obj30);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
		object obj31 = 0;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v41+E4]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Task<System.__Canon> task = Task.Run(func);
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v28+A0]");
		object obj35 = (nint)0 + (nint)280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static IEnumerator WaitForBuildHash()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CWaitForBuildHash_003Ed__173 obj2 = default;
		obj2._002Ector(0);
		return (IEnumerator)(object)obj2;
	}

	private static IEnumerator EnsureHwKey(string metaUserId)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CEnsureHwKey_003Ed__178 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 40;
			obj3 = metaUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static bool HwHeldOff()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I
		//IL_009d: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+A0]");
		object obj4 = 0;
		float num = realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+188]");
		float num2 = num - 0f;
		return num2 < 0f;
	}

	private unsafe static void ForgetHwKey()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_00ff: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		//IL_01db: Expected Obj, but got Ref
		//IL_0368: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBF0]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
		object obj5 = (nint)0 + (nint)416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PlayerPrefs.DeleteKey((string)key);
		PlayerPrefs.Save();
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidJavaObject androidJavaObject = OpenKeyStore();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		bool flag3 = array == null;
		string text = (string)1;
		object[] array2;
		string text2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC00]");
			object obj9 = 0;
			bool flag4 = obj9 == null;
			text = (string)1;
			if (!flag4)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj10 = default;
				bool flag5 = obj10 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag5)
				{
					goto IL_033d;
				}
			}
			if (array.Length == 0)
			{
				goto IL_0318;
			}
			text = (string)obj9;
			object obj11 = array + 32;
			obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (androidJavaObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEBF8]");
				object obj12 = 0;
				text = (string)obj12;
				androidJavaObject.Call((string)obj12, array);
				object obj14 = default;
				object obj13 = (object)(&obj14);
				object obj15 = obj13;
				bool flag6 = obj13 == null;
				array2 = array;
				if (flag6)
				{
					goto IL_0568;
				}
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v29+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ac;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v29+98]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v13-8]");
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
					goto IL_02ac;
				}
				object obj20 = obj16 + obj19;
				object obj21 = obj20 + 312;
				array2 = array;
				goto IL_059a;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_030a;
		IL_033d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		object obj22 = 0;
		ArgumentNullException ex3 = ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_030a:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		goto IL_0318;
		IL_02ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_059a;
		IL_059a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v62+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X0_v62] (should have been resolved before IL gen)");
		goto IL_0568;
		IL_0568:
		object obj23 = 0;
		goto IL_030a;
		IL_0318:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		text2 = text;
		goto IL_033d;
	}

	private unsafe static AndroidJavaObject OpenKeyStore()
	{
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0095: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_0306: Expected I, but got Obj
		//IL_0327: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_05a3: Expected I, but got Obj
		//IL_037b: Expected Obj, but got Ref
		//IL_0713: Expected Obj, but got I4
		//IL_03a8: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I
		//IL_0779: Expected Obj, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_041e: Expected Obj, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC10]");
		object className = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector((string)className);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		bool flag = array == null;
		void* ptr = (void*)1;
		object obj8;
		object obj11;
		object obj13;
		object obj15;
		AndroidJavaClass androidJavaClass3;
		IntPtr intPtr2;
		object obj3;
		OutOfMemoryException ex2;
		jvalue[] array2;
		nint num3;
		object[] array4;
		object obj12 = default;
		object obj14 = default;
		object obj7;
		object obj6;
		object obj4;
		OutOfMemoryException ex3;
		object[] array3;
		AndroidJavaClass androidJavaClass2;
		nint num4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC28]");
			num = 0;
			if (((IntPtr*)num)->m_value != null)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				ArgumentNullException ex = default;
				bool flag2 = ex == null;
				obj3 = 0;
				ex2 = null;
				array2 = null;
				num3 = 109895680;
				if (flag2)
				{
					goto IL_0628;
				}
			}
			bool flag3 = array.Length == 0;
			obj4 = 0;
			ex3 = null;
			array3 = null;
			array4 = array;
			androidJavaClass2 = androidJavaClass;
			num4 = 109895680;
			if (flag3)
			{
				goto IL_057c;
			}
			ptr = ((IntPtr*)num)->m_value;
			object obj5 = array + 32;
			obj5 = (object)((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (androidJavaClass != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC20]");
				object methodName = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC18]");
				obj6 = 0;
				obj7 = obj6;
				System.__Canon _Canon = androidJavaClass.CallStatic<System.__Canon>((string)methodName, array);
				bool flag4 = _Canon == null;
				obj4 = 0;
				ex3 = null;
				array3 = array;
				array4 = array;
				androidJavaClass2 = (AndroidJavaClass)(object)_Canon;
				num4 = 109895680;
				if (flag4)
				{
					goto IL_058a;
				}
				IntPtr rawObject = ((AndroidJavaObject)(object)_Canon).GetRawObject();
				IntPtr objectClass = AndroidJNI.GetObjectClass(rawObject);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC38]");
				object name = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC30]");
				obj8 = 0;
				IntPtr methodID = AndroidJNI.GetMethodID(objectClass, (string)name, (string)obj8);
				IntPtr rawObject2 = ((AndroidJavaObject)(object)_Canon).GetRawObject();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC40]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				jvalue[] array5 = default;
				AndroidJNI.CallVoidMethod(rawObject2, methodID, array5);
				AndroidJNI.DeleteLocalRef(objectClass);
				IntPtr intPtr = AndroidJNI.ExceptionOccurred();
				bool flag5 = intPtr == (IntPtr)0;
				object obj10 = !flag5;
				obj11 = obj12;
				obj13 = obj14;
				obj15 = 0;
				obj3 = 0;
				ex2 = null;
				array2 = array5;
				ptr = (void*)unchecked((nint)null);
				androidJavaClass3 = (AndroidJavaClass)(object)_Canon;
				intPtr2 = methodID;
				num3 = rawObject2;
				obj7 = 0;
				obj6 = obj8;
				obj4 = 0;
				ex3 = null;
				array3 = (object[])(object)array5;
				array4 = (object[])(nint)intPtr;
				androidJavaClass2 = (AndroidJavaClass)(object)_Canon;
				num = methodID;
				num4 = rawObject2;
				if (obj10 == null)
				{
					object obj17 = default;
					object obj16 = (object)(&obj17);
					array4 = (object[])obj16;
					if (obj16 == null)
					{
						goto IL_06f9;
					}
					nint num5 = (nint)array4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v18 (Il2CppClass<System.Object[]>)+12E]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v18 (Il2CppClass<System.Object[]>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0454;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v18 (Il2CppClass<System.Object[]>)+98]");
					object obj18 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X10_v15-8]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X10_v15-8]");
						if (0 == (nint)obj13)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v18 (Il2CppClass<System.Object[]>)+12E]");
						obj8 = -1;
						obj13 = obj18 + 16;
						bool flag6 = (nint)obj8 != 1;
						obj18 = obj13;
						if (flag6)
						{
							continue;
						}
						goto IL_0454;
					}
					obj8 = obj18;
					object obj19 = num5 + obj18;
					object obj20 = obj19 + 312;
					obj13 = obj18;
					goto IL_079d;
				}
				AndroidJNI.ExceptionClear();
				AndroidJNI.DeleteLocalRef((IntPtr)array4);
				androidJavaClass2.Dispose();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex4 = default;
				string message = default;
				ex4._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex = new ArgumentNullException();
				obj3 = obj4;
				ex2 = ex3;
				array2 = null;
				object obj21 = default;
				object obj2 = obj21;
				num3 = num4;
				goto IL_0628;
			}
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj4 = 0;
		ex3 = null;
		array2 = null;
		array4 = array;
		androidJavaClass2 = androidJavaClass;
		num4 = 109895680;
		goto IL_0557;
		IL_0454:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_079d;
		IL_0557:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		array3 = (object[])(object)array2;
		goto IL_056d;
		IL_06f9:
		bool flag7 = ex2 == null;
		object obj22 = !flag7;
		obj12 = obj11;
		obj14 = obj13;
		obj7 = obj15;
		obj6 = obj8;
		obj4 = obj3;
		ex3 = ex2;
		androidJavaClass2 = androidJavaClass3;
		num = intPtr2;
		num4 = num3;
		if (obj22 != null)
		{
			goto IL_0557;
		}
		bool flag8 = obj3 == null;
		object obj23 = !flag8;
		obj12 = obj11;
		obj14 = obj13;
		obj7 = obj15;
		obj6 = obj8;
		obj4 = obj3;
		ex3 = ex2;
		array3 = (object[])(object)array2;
		ex6 = ex2;
		androidJavaClass2 = androidJavaClass3;
		num = intPtr2;
		num4 = num3;
		if (obj23 == null)
		{
			return androidJavaClass3;
		}
		goto IL_056d;
		IL_057c:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_058a;
		IL_0628:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex8 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		AndroidJavaObject result = default;
		return result;
		IL_056d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_057c;
		IL_058a:
		throw new NullReferenceException();
		IL_079d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v52+8]");
		ptr = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v549 @ X0_v52] (should have been resolved before IL gen)");
		goto IL_06f9;
	}

	private unsafe static bool HwKeyExists()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0532: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_05ac: Expected Obj, but got Ref
		//IL_0549: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_0582: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got Ref
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_05e1: Expected Obj, but got Ref
		//IL_05f1: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidJavaObject androidJavaObject = OpenKeyStore();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = default;
		bool flag2 = obj5 == null;
		object obj6 = 1;
		object obj7;
		object obj10;
		object obj17;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC00]");
			obj7 = 0;
			bool flag3 = obj7 == null;
			obj6 = 1;
			if (!flag3)
			{
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v34+40]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj9 = default;
				bool flag4 = obj9 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v34+40]");
				obj10 = 0;
				if (flag4)
				{
					goto IL_039d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+18]");
			if ((nint)0 == 0)
			{
				goto IL_0378;
			}
			obj6 = obj7;
			object obj11 = obj5 + 32;
			obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (androidJavaObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC60]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC58]");
				object obj13 = 0;
				obj6 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @357C0B4");
				object obj15 = default;
				object obj14 = (object)(&obj15);
				object obj16 = obj14;
				bool flag5 = obj14 == null;
				obj17 = obj5;
				if (flag5)
				{
					goto IL_0540;
				}
				object obj18 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v30+12E]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v30+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0244;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v30+98]");
				object obj21 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v15-8]");
					if (0 == (nint)obj19)
					{
						break;
					}
					obj20--;
					obj19 = obj21 + 16;
					bool flag6 = (nint)obj20 != 1;
					obj21 = obj19;
					if (flag6)
					{
						continue;
					}
					goto IL_0244;
				}
				object obj22 = obj18 + obj21;
				object obj23 = obj22 + 312;
				obj17 = obj5;
				goto IL_0572;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_036a;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj17 = 0;
		goto IL_0572;
		IL_0572:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v59+8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v392 @ X0_v59] (should have been resolved before IL gen)");
		goto IL_0540;
		IL_0540:
		obj7 = 0;
		goto IL_036a;
		IL_0378:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		obj10 = obj6;
		goto IL_039d;
		IL_036a:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0378;
		IL_039d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex4 = new ArgumentNullException();
		object obj24 = 0;
		obj6 = 0;
		object obj26 = default;
		object obj28 = default;
		object obj30 = default;
		string text = default;
		string text2 = default;
		NullReferenceException ex7 = default;
		while (true)
		{
			NullReferenceException ex5 = new NullReferenceException();
			bool flag7 = (nint)obj6 != 1;
			NullReferenceException ex6 = ex5;
			if (flag7)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj25 = obj26;
			obj6 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj27 = obj28 & 1;
			if (obj27 != null)
			{
				object obj29 = (object)(&obj30);
				object obj31 = obj24 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj32 = obj31;
				object obj33 = obj24;
				object obj34 = (object)(&obj30);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v7+v274 @ X20_v3*8]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v7+v274 @ X20_v3*8]");
				bool flag8 = (nint)0 == 0;
				obj24 = obj32;
				if (!flag8)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v468 @ X8_v8+188] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string message = text + text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v16+E4]");
					bool flag9 = (nint)0 == 0;
					object obj37 = !flag9;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Debug.LogWarning(message);
					object obj38 = 0;
					return (byte)(obj38 & 1) != 0;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj39 = obj26;
			obj6 = 101789696 + 1224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = 0;
			ex6 = ex7;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		bool result = default;
		return result;
	}

	private unsafe static string[] MakeHwKey(string nonce)
	{
		//IL_342d: Expected Obj, but got I
		//IL_3457: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got Ref
		//IL_0287: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got Ref
		//IL_03c7: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got Ref
		//IL_034b: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I
		//IL_043b: Expected Obj, but got Ref
		//IL_0514: Expected Obj, but got I8
		//IL_054a: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got Ref
		//IL_0572: Expected Obj, but got I4
		//IL_0451: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got Ref
		//IL_04d2: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got I
		//IL_0621: Expected Obj, but got Ref
		//IL_062a: Expected Obj, but got I4
		//IL_0633: Expected Obj, but got I4
		//IL_0640: Expected Obj, but got Ref
		//IL_0649: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I4
		//IL_0688: Expected Obj, but got I4
		//IL_3297: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got Ref
		//IL_079e: Expected Obj, but got I4
		//IL_07a7: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got Ref
		//IL_07bd: Expected Obj, but got I4
		//IL_32e6: Expected Obj, but got I4
		//IL_069e: Expected I, but got Obj
		//IL_06ae: Expected Obj, but got I
		//IL_06d0: Expected Obj, but got I4
		//IL_06fb: Expected Obj, but got Ref
		//IL_0704: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got Ref
		//IL_0723: Expected Obj, but got I4
		//IL_074b: Expected Obj, but got I
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_0835: Expected Obj, but got Ref
		//IL_083e: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got I4
		//IL_0854: Expected Obj, but got Ref
		//IL_085d: Expected Obj, but got I4
		//IL_334f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3354: Expected Obj, but got Unknown
		//IL_33d4: Expected Obj, but got I4
		//IL_3cd5: Expected Obj, but got I4
		//IL_089b: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I
		//IL_090a: Expected Obj, but got Ref
		//IL_0913: Expected Obj, but got I4
		//IL_091c: Expected Obj, but got I4
		//IL_0929: Expected Obj, but got Ref
		//IL_3379: Expected Obj, but got Ref
		//IL_3387: Unknown result type (might be due to invalid IL or missing references)
		//IL_338c: Expected Obj, but got Unknown
		//IL_33a6: Expected Obj, but got Ref
		//IL_2cb5: Expected Obj, but got I
		//IL_3a41: Expected Obj, but got Ref
		//IL_3a51: Expected Obj, but got I
		//IL_2d9f: Expected Obj, but got I4
		//IL_39ce: Expected Obj, but got I
		//IL_2cf0: Expected Obj, but got I
		//IL_0989: Expected Obj, but got I4
		//IL_2dd7: Expected Obj, but got I4
		//IL_2ec2: Expected Obj, but got Ref
		//IL_2ecb: Expected Obj, but got I4
		//IL_2ed4: Expected Obj, but got I4
		//IL_2ee1: Expected Obj, but got Ref
		//IL_2e66: Expected Obj, but got I4
		//IL_2d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d78: Expected Obj, but got Unknown
		//IL_313b: Expected Obj, but got I4
		//IL_09d1: Expected Obj, but got Ref
		//IL_09da: Expected Obj, but got I4
		//IL_09e3: Expected Obj, but got I4
		//IL_09f0: Expected Obj, but got Ref
		//IL_0a11: Expected Obj, but got I4
		//IL_2dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df3: Expected Obj, but got Unknown
		//IL_2d0b: Expected Obj, but got I
		//IL_2d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d19: Expected Obj, but got Unknown
		//IL_0a2f: Expected Obj, but got I
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected Obj, but got Unknown
		//IL_0a7c: Expected I, but got Obj
		//IL_0a8c: Expected Obj, but got I
		//IL_0ad0: Expected Obj, but got Ref
		//IL_0ad9: Expected Obj, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_0aef: Expected Obj, but got Ref
		//IL_0b4c: Expected Obj, but got Ref
		//IL_0b55: Expected Obj, but got I4
		//IL_0b5e: Expected Obj, but got I4
		//IL_0b6b: Expected Obj, but got Ref
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected Obj, but got Unknown
		//IL_0be6: Expected Obj, but got I
		//IL_0c45: Expected Obj, but got Ref
		//IL_0c4e: Expected Obj, but got I4
		//IL_0c57: Expected Obj, but got I4
		//IL_0c64: Expected Obj, but got Ref
		//IL_0cb2: Expected Obj, but got I
		//IL_0cdc: Expected Obj, but got I4
		//IL_0d38: Expected Obj, but got Ref
		//IL_0d41: Expected Obj, but got I4
		//IL_0d4a: Expected Obj, but got I4
		//IL_0d57: Expected Obj, but got Ref
		//IL_0d78: Expected Obj, but got I4
		//IL_0d9e: Expected Obj, but got I4
		//IL_0ea5: Expected Obj, but got Ref
		//IL_0eae: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got I4
		//IL_0ec4: Expected Obj, but got Ref
		//IL_0db4: Expected I, but got Obj
		//IL_0dc4: Expected Obj, but got I
		//IL_0de6: Expected Obj, but got I4
		//IL_0e11: Expected Obj, but got Ref
		//IL_0e1a: Expected Obj, but got I4
		//IL_0e23: Expected Obj, but got I4
		//IL_0e30: Expected Obj, but got Ref
		//IL_0e58: Expected Obj, but got I
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Expected Obj, but got Unknown
		//IL_0f3c: Expected Obj, but got Ref
		//IL_0f45: Expected Obj, but got I4
		//IL_0f4e: Expected Obj, but got I4
		//IL_0f5b: Expected Obj, but got Ref
		//IL_0f99: Expected Obj, but got I
		//IL_0ff8: Expected Obj, but got Ref
		//IL_1001: Expected Obj, but got I4
		//IL_100a: Expected Obj, but got I4
		//IL_1017: Expected Obj, but got Ref
		//IL_105e: Expected Obj, but got I
		//IL_1080: Expected Obj, but got I4
		//IL_3475: Expected Obj, but got I
		//IL_3497: Expected Obj, but got I4
		//IL_3ab8: Expected Obj, but got Ref
		//IL_3ac1: Expected Obj, but got I4
		//IL_3aca: Expected Obj, but got I4
		//IL_3ad7: Expected Obj, but got Ref
		//IL_10a8: Expected Obj, but got I
		//IL_10c7: Expected Obj, but got I
		//IL_10d7: Expected Obj, but got I
		//IL_10ec: Expected Obj, but got I
		//IL_10fc: Expected Obj, but got I
		//IL_1129: Expected Obj, but got I
		//IL_1148: Expected Obj, but got I
		//IL_11aa: Expected Obj, but got Ref
		//IL_11b2: Expected Obj, but got Ref
		//IL_11bb: Expected Obj, but got I4
		//IL_11c8: Expected Obj, but got Ref
		//IL_11e6: Expected Obj, but got I4
		//IL_1204: Expected Obj, but got I
		//IL_121c: Expected Obj, but got I4
		//IL_132c: Expected Obj, but got Ref
		//IL_1334: Expected Obj, but got Ref
		//IL_133d: Expected Obj, but got I4
		//IL_134a: Expected Obj, but got Ref
		//IL_1232: Expected I, but got Obj
		//IL_1242: Expected Obj, but got I
		//IL_1264: Expected Obj, but got I4
		//IL_129b: Expected Obj, but got Ref
		//IL_12a3: Expected Obj, but got Ref
		//IL_12ac: Expected Obj, but got I4
		//IL_12b9: Expected Obj, but got Ref
		//IL_12d6: Expected Obj, but got I
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected Obj, but got Unknown
		//IL_1395: Expected Obj, but got I
		//IL_1488: Expected Obj, but got I8
		//IL_14ce: Expected Obj, but got Ref
		//IL_14d6: Expected Obj, but got Ref
		//IL_14df: Expected Obj, but got I4
		//IL_14ec: Expected Obj, but got Ref
		//IL_13c2: Expected I, but got Obj
		//IL_13d2: Expected Obj, but got I
		//IL_13f4: Expected Obj, but got I4
		//IL_142b: Expected Obj, but got Ref
		//IL_1433: Expected Obj, but got Ref
		//IL_143c: Expected Obj, but got I4
		//IL_1449: Expected Obj, but got Ref
		//IL_1466: Expected Obj, but got I
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_151d: Expected Obj, but got Unknown
		//IL_1575: Expected Obj, but got Ref
		//IL_157d: Expected Obj, but got Ref
		//IL_1586: Expected Obj, but got I4
		//IL_1593: Expected Obj, but got Ref
		//IL_15be: Expected Obj, but got I
		//IL_15ce: Expected Obj, but got I
		//IL_1636: Expected Obj, but got Ref
		//IL_163f: Expected Obj, but got I4
		//IL_164c: Expected Obj, but got Ref
		//IL_1665: Expected Obj, but got I4
		//IL_168b: Expected Obj, but got I4
		//IL_179a: Expected Obj, but got Ref
		//IL_17a3: Expected Obj, but got I4
		//IL_17b0: Expected Obj, but got Ref
		//IL_16a1: Expected I, but got Obj
		//IL_16b1: Expected Obj, but got I
		//IL_16d3: Expected Obj, but got I4
		//IL_1708: Expected Obj, but got Ref
		//IL_1711: Expected Obj, but got I4
		//IL_171e: Expected Obj, but got Ref
		//IL_1746: Expected Obj, but got I
		//IL_17df: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e4: Expected Obj, but got Unknown
		//IL_1832: Expected Obj, but got Ref
		//IL_183b: Expected Obj, but got I4
		//IL_1848: Expected Obj, but got Ref
		//IL_1886: Expected Obj, but got I
		//IL_18b7: Expected Obj, but got I
		//IL_18d9: Expected Obj, but got I4
		//IL_34b5: Expected Obj, but got I
		//IL_34d7: Expected Obj, but got I4
		//IL_3b46: Expected Obj, but got Ref
		//IL_3b4f: Expected Obj, but got I4
		//IL_3b5c: Expected Obj, but got Ref
		//IL_3b65: Expected Obj, but got I4
		//IL_1901: Expected Obj, but got I
		//IL_1920: Expected Obj, but got I
		//IL_1930: Expected Obj, but got I
		//IL_1945: Expected Obj, but got I
		//IL_1955: Expected Obj, but got I
		//IL_19be: Expected Obj, but got Ref
		//IL_19c7: Expected Obj, but got I4
		//IL_19d4: Expected Obj, but got Ref
		//IL_1a0b: Expected Obj, but got Ref
		//IL_351a: Expected Obj, but got Ref
		//IL_3523: Expected Obj, but got I4
		//IL_3530: Expected Obj, but got Ref
		//IL_1a55: Expected Obj, but got I
		//IL_357a: Expected Obj, but got I
		//IL_1a90: Expected Obj, but got I
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Expected Obj, but got Unknown
		//IL_1aab: Expected Obj, but got I
		//IL_1ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] bytes = Convert.FromBase64String(nonce);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		bool flag2 = array == null;
		AndroidJavaObject androidJavaObject = null;
		AndroidJavaObject androidJavaObject2 = null;
		AndroidJavaObject androidJavaObject3 = null;
		AndroidJavaClass androidJavaClass = null;
		System.__Canon _Canon = null;
		AndroidJavaObject androidJavaObject4 = null;
		string text = null;
		string text2 = (string)1;
		if (flag2)
		{
			goto IL_2f77;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECD0]");
		AndroidJavaObject androidJavaObject5 = (AndroidJavaObject)0;
		bool flag3 = androidJavaObject5 == null;
		text2 = (string)1;
		object obj6;
		object[] array3 = default;
		object[] array2;
		string text3;
		if (!flag3)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v230 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj5 = default;
			bool flag4 = obj5 == null;
			obj6 = 0;
			androidJavaObject = null;
			androidJavaObject2 = null;
			androidJavaObject3 = null;
			androidJavaClass = null;
			_Canon = null;
			androidJavaObject4 = null;
			text = null;
			array2 = array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v230 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (flag4)
			{
				goto IL_315d;
			}
		}
		bool flag5 = array.Length == 0;
		androidJavaObject = null;
		androidJavaObject2 = null;
		androidJavaObject3 = null;
		androidJavaClass = null;
		_Canon = null;
		androidJavaObject4 = null;
		text = null;
		array2 = array3;
		if (flag5)
		{
			goto IL_2f8d;
		}
		object obj7 = array + 32;
		obj7 = androidJavaObject5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC80]");
		string text4 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECC8]");
		object className = 0;
		AndroidJavaObject androidJavaObject6 = default;
		androidJavaObject6._002Ector((string)className, array);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC00]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array4 = default;
		bool flag6 = array4 == null;
		androidJavaObject = null;
		androidJavaObject2 = null;
		androidJavaObject3 = null;
		androidJavaClass = null;
		_Canon = null;
		androidJavaObject4 = null;
		object obj12 = 0;
		IndexOutOfRangeException ex = null;
		object obj13 = (object)(&text);
		object obj14 = 0;
		array2 = array;
		androidJavaObject5 = androidJavaObject6;
		text2 = (string)2;
		if (flag6)
		{
			goto IL_2f9b;
		}
		bool flag7 = obj9 == null;
		text2 = (string)2;
		ArgumentNullException ex2 = default;
		string text5;
		if (!flag7)
		{
			nint num2 = (nint)array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v229 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag8 = ex2 == null;
			obj6 = 0;
			androidJavaObject = null;
			androidJavaObject2 = null;
			androidJavaObject3 = null;
			androidJavaClass = null;
			_Canon = null;
			androidJavaObject4 = null;
			obj12 = 0;
			ex = null;
			obj13 = (object)(&text);
			obj14 = 0;
			array2 = array;
			androidJavaObject5 = androidJavaObject6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v229 (Il2CppClass<System.Object[]>)+40]");
			text5 = (string)0;
			if (flag8)
			{
				goto IL_317a;
			}
		}
		bool flag9 = array4.Length == 0;
		androidJavaObject = null;
		androidJavaObject2 = null;
		androidJavaObject3 = null;
		androidJavaClass = null;
		_Canon = null;
		androidJavaObject4 = null;
		obj12 = 0;
		ex = null;
		obj13 = (object)(&text);
		obj14 = 0;
		array2 = array;
		androidJavaObject5 = androidJavaObject6;
		if (flag9)
		{
			goto IL_2fa9;
		}
		object obj15 = array4 + 32;
		obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		AndroidJavaObject androidJavaObject7 = default;
		bool flag10 = androidJavaObject7 == null;
		object obj17 = default;
		text2 = (string)(&obj17);
		ArgumentNullException ex3 = default;
		string text6;
		object obj18;
		if (!flag10)
		{
			nint num3 = (nint)array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v228 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag11 = ex3 == null;
			obj6 = 0;
			androidJavaObject = null;
			androidJavaObject2 = null;
			androidJavaObject3 = null;
			androidJavaClass = null;
			_Canon = null;
			androidJavaObject4 = null;
			obj17 = 4;
			obj18 = 4;
			obj12 = 0;
			ex = null;
			obj13 = (object)(&text);
			obj14 = 0;
			array2 = array;
			androidJavaObject5 = androidJavaObject7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v228 (Il2CppClass<System.Object[]>)+40]");
			text6 = (string)0;
			if (flag11)
			{
				goto IL_3197;
			}
		}
		object obj19 = array4.Length & 0xFFFFFFFEL;
		bool flag12 = obj19 == null;
		androidJavaObject = null;
		androidJavaObject2 = null;
		androidJavaObject3 = null;
		androidJavaClass = null;
		_Canon = null;
		androidJavaObject4 = null;
		obj17 = 4;
		obj18 = 4;
		obj12 = 0;
		ex = null;
		obj13 = (object)(&text);
		obj14 = 0;
		array2 = array;
		androidJavaObject5 = androidJavaObject7;
		AndroidJavaObject androidJavaObject8 = default;
		string text8 = default;
		System.__Canon _Canon5;
		AndroidJavaClass androidJavaClass2 = default;
		ArgumentNullException ex4 = default;
		string text7;
		ArgumentNullException ex7 = default;
		string text11;
		ArgumentNullException ex5 = default;
		string text9;
		ArgumentNullException ex6 = default;
		string text10;
		ArgumentNullException ex8 = default;
		string text12;
		if (!flag12)
		{
			object obj20 = array4 + 40;
			obj20 = androidJavaObject7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECC0]");
			object className2 = 0;
			androidJavaObject8._002Ector((string)className2, array4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object[] array5 = default;
			bool flag13 = array5 == null;
			androidJavaObject = null;
			androidJavaObject2 = null;
			androidJavaObject3 = null;
			androidJavaClass = null;
			_Canon = null;
			obj17 = (object)(&androidJavaObject4);
			obj18 = 4;
			obj12 = 0;
			ex = null;
			obj13 = (object)(&text);
			obj14 = 0;
			array3 = array4;
			androidJavaObject5 = androidJavaObject8;
			text2 = (string)1;
			if (!flag13)
			{
				bool flag14 = text == null;
				text2 = (string)1;
				if (!flag14)
				{
					nint num4 = (nint)array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v227 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag15 = ex4 == null;
					obj6 = 0;
					androidJavaObject = null;
					androidJavaObject2 = null;
					androidJavaObject3 = null;
					androidJavaClass = null;
					_Canon = null;
					androidJavaObject4 = androidJavaObject8;
					obj17 = (object)(&androidJavaObject4);
					obj18 = 4;
					obj12 = 0;
					ex = null;
					obj13 = (object)(&text);
					obj14 = 0;
					array2 = array4;
					text4 = text;
					androidJavaObject5 = androidJavaObject8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v227 (Il2CppClass<System.Object[]>)+40]");
					text7 = (string)0;
					if (flag15)
					{
						goto IL_31b4;
					}
				}
				bool flag16 = array5.Length == 0;
				androidJavaObject = null;
				androidJavaObject2 = null;
				androidJavaObject3 = null;
				androidJavaClass = null;
				_Canon = null;
				androidJavaObject4 = androidJavaObject8;
				obj17 = (object)(&androidJavaObject4);
				obj18 = 4;
				obj12 = 0;
				ex = null;
				obj13 = (object)(&text);
				obj14 = 0;
				array2 = array4;
				text4 = text;
				androidJavaObject5 = androidJavaObject8;
				if (flag16)
				{
					goto IL_2fe2;
				}
				object obj21 = array5 + 32;
				obj21 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag17 = androidJavaObject8 == null;
				androidJavaObject = null;
				androidJavaObject2 = null;
				androidJavaObject3 = null;
				androidJavaClass = null;
				_Canon = null;
				obj17 = (object)(&androidJavaObject4);
				obj18 = 4;
				obj12 = 0;
				ex = null;
				obj13 = (object)(&text);
				obj14 = 0;
				array3 = array4;
				text4 = text;
				androidJavaObject5 = androidJavaObject8;
				text2 = text;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECA8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
					object obj23 = 0;
					text2 = (string)obj22;
					obj14 = obj23;
					System.__Canon _Canon2 = androidJavaObject8.Call<System.__Canon>((string)obj22, array5);
					bool flag18 = _Canon2 == null;
					androidJavaObject = null;
					androidJavaObject2 = null;
					androidJavaObject3 = null;
					androidJavaClass = null;
					_Canon = null;
					androidJavaObject4 = androidJavaObject8;
					obj17 = (object)(&androidJavaObject4);
					obj18 = 4;
					obj12 = 0;
					ex = null;
					obj13 = (object)(&text);
					array2 = array5;
					text4 = text;
					androidJavaObject5 = androidJavaObject8;
					if (flag18)
					{
						goto IL_2ff0;
					}
					((AndroidJavaObject)(object)_Canon2).Dispose();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					bool flag19 = text8 == null;
					text2 = (string)1;
					AndroidJavaObject androidJavaObject9 = default;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2138 @ X0_v197 (System.String)+18]");
						bool flag20 = (nint)0 == 0;
						androidJavaObject = null;
						androidJavaObject2 = null;
						androidJavaObject3 = null;
						androidJavaClass = null;
						_Canon = null;
						obj17 = (object)(&androidJavaObject4);
						obj18 = 4;
						obj12 = 0;
						ex = null;
						obj13 = (object)(&text);
						array3 = array5;
						text4 = text8;
						androidJavaObject5 = androidJavaObject9;
						text2 = (string)1;
						if (flag20)
						{
							goto IL_2f3f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECB0]");
						object obj24 = 0;
						text2 = (string)obj24;
						object obj25 = text8 + 32;
						obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (androidJavaObject9 != null)
						{
							nint num5 = (nint)androidJavaObject9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X8_v102 (Il2CppClass<UnityEngine.AndroidJavaObject>)+40]");
							text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							object obj26 = default;
							bool flag21 = obj26 == null;
							androidJavaObject = null;
							androidJavaObject2 = null;
							androidJavaObject3 = null;
							androidJavaClass = null;
							_Canon = null;
							androidJavaObject4 = androidJavaObject8;
							obj17 = (object)(&androidJavaObject4);
							obj18 = 4;
							obj12 = 0;
							ex = null;
							obj13 = (object)(&text);
							array2 = array5;
							text4 = text8;
							androidJavaObject5 = androidJavaObject9;
							if (flag21)
							{
								goto IL_301b;
							}
							bool flag22 = androidJavaObject9.m_jclass == null;
							androidJavaObject = null;
							androidJavaObject2 = null;
							androidJavaObject3 = null;
							androidJavaClass = null;
							_Canon = null;
							obj17 = (object)(&androidJavaObject4);
							obj18 = 4;
							obj12 = 0;
							ex = null;
							obj13 = (object)(&text);
							array3 = array5;
							text4 = text8;
							androidJavaObject5 = androidJavaObject9;
							if (flag22)
							{
								goto IL_2f3f;
							}
							object obj27 = androidJavaObject9 + 32;
							obj27 = text8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag23 = androidJavaObject8 == null;
							text2 = text8;
							if (!flag23)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC90]");
								object obj28 = 0;
								obj14 = obj23;
								text3 = (string)obj28;
								System.__Canon _Canon3 = androidJavaObject8.Call<System.__Canon>((string)obj28, (object[])(object)androidJavaObject9);
								bool flag24 = _Canon3 == null;
								androidJavaObject = null;
								androidJavaObject2 = null;
								androidJavaObject3 = null;
								androidJavaClass = null;
								_Canon = null;
								androidJavaObject4 = androidJavaObject8;
								obj17 = (object)(&androidJavaObject4);
								obj18 = 4;
								obj12 = 0;
								ex = null;
								obj13 = (object)(&text);
								array2 = (object[])(object)androidJavaObject9;
								text4 = text8;
								androidJavaObject5 = androidJavaObject9;
								if (!flag24)
								{
									((AndroidJavaObject)(object)_Canon3).Dispose();
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
									object obj29 = 0;
									object obj30 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3902 @ X0_v218+E4]");
									bool flag25 = (nint)0 == 0;
									object obj31 = !flag25;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									sbyte[] array6 = ToJava(bytes);
									AndroidJavaObject androidJavaObject10 = default;
									bool flag26 = androidJavaObject10 == null;
									androidJavaObject = null;
									androidJavaObject2 = null;
									androidJavaObject3 = null;
									androidJavaClass = null;
									_Canon = null;
									obj17 = (object)(&androidJavaObject4);
									obj18 = 4;
									obj12 = 0;
									ex = null;
									obj13 = (object)(&text);
									array3 = (object[])(object)androidJavaObject9;
									text4 = text8;
									androidJavaObject5 = androidJavaObject10;
									text2 = (string)1;
									if (!flag26)
									{
										bool flag27 = array6 == null;
										text3 = (string)1;
										if (!flag27)
										{
											nint num6 = (nint)androidJavaObject10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v226 (Il2CppClass<UnityEngine.AndroidJavaObject>)+40]");
											text3 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag28 = ex5 == null;
											obj6 = 0;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = null;
											_Canon = null;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = 4;
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = (object[])(object)androidJavaObject9;
											text4 = text8;
											androidJavaObject5 = androidJavaObject10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v226 (Il2CppClass<UnityEngine.AndroidJavaObject>)+40]");
											text9 = (string)0;
											if (flag28)
											{
												goto IL_31d1;
											}
										}
										bool flag29 = androidJavaObject10.m_jclass == null;
										androidJavaObject = null;
										androidJavaObject2 = null;
										androidJavaObject3 = null;
										androidJavaClass = null;
										_Canon = null;
										androidJavaObject4 = androidJavaObject8;
										obj17 = (object)(&androidJavaObject4);
										obj18 = 4;
										obj12 = 0;
										ex = null;
										obj13 = (object)(&text);
										array2 = (object[])(object)androidJavaObject9;
										text4 = text8;
										androidJavaObject5 = androidJavaObject10;
										if (flag29)
										{
											goto IL_3046;
										}
										object obj32 = androidJavaObject10 + 32;
										obj32 = array6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag30 = androidJavaObject8 == null;
										androidJavaObject = null;
										androidJavaObject2 = null;
										androidJavaObject3 = null;
										androidJavaClass = null;
										_Canon = null;
										obj17 = (object)(&androidJavaObject4);
										obj18 = 4;
										obj12 = 0;
										ex = null;
										obj13 = (object)(&text);
										array3 = (object[])(object)androidJavaObject9;
										text4 = text8;
										androidJavaObject5 = androidJavaObject10;
										text2 = (string)(object)array6;
										if (!flag30)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECF0]");
											object obj33 = 0;
											obj14 = obj23;
											text3 = (string)obj33;
											System.__Canon _Canon4 = androidJavaObject8.Call<System.__Canon>((string)obj33, (object[])(object)androidJavaObject10);
											bool flag31 = _Canon4 == null;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = null;
											_Canon = null;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = 4;
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = (object[])(object)androidJavaObject10;
											text4 = text8;
											androidJavaObject5 = androidJavaObject10;
											if (flag31)
											{
												goto IL_3054;
											}
											((AndroidJavaObject)(object)_Canon4).Dispose();
											object obj34 = obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X20_v69+38]");
											object obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X20_v69+38]");
											bool flag32 = (nint)0 == 0;
											object obj36 = !flag32;
											if (obj36 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X20_v69+38]");
												obj35 = 0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3925 @ X8_v114+10]");
											object obj37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ X0_v230+E4]");
											bool flag33 = (nint)0 == 0;
											object obj38 = !flag33;
											if (obj38 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1714 @ X20_v69+38]");
												object obj39 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3933 @ X8_v224+10]");
												obj37 = 0;
											}
											bool flag34 = androidJavaObject8 == null;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = null;
											_Canon = null;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = 4;
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = (object[])(object)androidJavaObject10;
											text4 = text8;
											androidJavaObject5 = androidJavaObject10;
											text3 = null;
											if (flag34)
											{
												goto IL_3062;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF08]");
											object methodName = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ X0_v230+A0]");
											object args = 0;
											obj14 = obj23;
											_Canon5 = androidJavaObject8.Call<System.__Canon>((string)methodName, (object[])args);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA8]");
											object obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECA0]");
											object className3 = 0;
											androidJavaClass2._002Ector((string)className3);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											object[] array7 = default;
											bool flag35 = array7 == null;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = androidJavaClass2;
											_Canon = _Canon5;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = (object)(&_Canon);
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = null;
											text4 = text8;
											androidJavaObject5 = androidJavaObject10;
											text3 = (string)2;
											if (flag35)
											{
												goto IL_3070;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECE0]");
											androidJavaObject5 = (AndroidJavaObject)0;
											bool flag36 = androidJavaObject5 == null;
											text3 = (string)2;
											if (!flag36)
											{
												nint num7 = (nint)array7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v223 (Il2CppClass<System.Object[]>)+40]");
												text3 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag37 = ex6 == null;
												obj6 = 0;
												androidJavaObject = null;
												androidJavaObject2 = null;
												androidJavaObject3 = null;
												androidJavaClass = androidJavaClass2;
												_Canon = _Canon5;
												androidJavaObject4 = androidJavaObject8;
												obj17 = (object)(&androidJavaObject4);
												obj18 = (object)(&_Canon);
												obj12 = 0;
												ex = null;
												obj13 = (object)(&text);
												array2 = null;
												text4 = text8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v223 (Il2CppClass<System.Object[]>)+40]");
												text10 = (string)0;
												if (flag37)
												{
													goto IL_31ee;
												}
											}
											bool flag38 = array7.Length == 0;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = androidJavaClass2;
											_Canon = _Canon5;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = (object)(&_Canon);
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = null;
											text4 = text8;
											if (flag38)
											{
												goto IL_309b;
											}
											object obj41 = array7 + 32;
											obj41 = androidJavaObject5;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC28]");
											androidJavaObject5 = (AndroidJavaObject)0;
											bool flag39 = androidJavaObject5 == null;
											text3 = (string)(object)androidJavaObject5;
											if (!flag39)
											{
												nint num8 = (nint)array7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ X8_v222 (Il2CppClass<System.Object[]>)+40]");
												text3 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag40 = ex7 == null;
												obj6 = 0;
												androidJavaObject = null;
												androidJavaObject2 = null;
												androidJavaObject3 = null;
												androidJavaClass = androidJavaClass2;
												_Canon = _Canon5;
												androidJavaObject4 = androidJavaObject8;
												obj17 = (object)(&androidJavaObject4);
												obj18 = (object)(&_Canon);
												obj12 = 0;
												ex = null;
												obj13 = (object)(&text);
												array2 = null;
												text4 = text8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ X8_v222 (Il2CppClass<System.Object[]>)+40]");
												text11 = (string)0;
												if (flag40)
												{
													goto IL_320b;
												}
											}
											object obj42 = array7.Length & 0xFFFFFFFEL;
											bool flag41 = obj42 == null;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = androidJavaClass2;
											_Canon = _Canon5;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = (object)(&_Canon);
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = null;
											text4 = text8;
											if (flag41)
											{
												goto IL_30c6;
											}
											text3 = (string)(object)androidJavaObject5;
											object obj43 = array7 + 40;
											obj43 = androidJavaObject5;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag42 = androidJavaClass2 == null;
											androidJavaObject = null;
											androidJavaObject2 = null;
											androidJavaObject3 = null;
											androidJavaClass = androidJavaClass2;
											_Canon = _Canon5;
											androidJavaObject4 = androidJavaObject8;
											obj17 = (object)(&androidJavaObject4);
											obj18 = (object)(&_Canon);
											obj12 = 0;
											ex = null;
											obj13 = (object)(&text);
											array2 = null;
											text4 = text8;
											if (!flag42)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC20]");
												object methodName2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC18]");
												obj18 = 0;
												obj14 = obj18;
												System.__Canon _Canon6 = androidJavaClass2.CallStatic<System.__Canon>((string)methodName2, array7);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												object[] array8 = default;
												bool flag43 = array8 == null;
												androidJavaObject = null;
												androidJavaObject2 = null;
												androidJavaClass = androidJavaClass2;
												_Canon = _Canon5;
												obj17 = (object)(&androidJavaObject4);
												obj12 = 0;
												ex = null;
												obj13 = (object)(&text);
												array3 = array7;
												text4 = text8;
												text2 = (string)1;
												if (!flag43)
												{
													bool flag44 = _Canon5 == null;
													text3 = (string)1;
													if (!flag44)
													{
														nint num9 = (nint)array8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v221 (Il2CppClass<System.Object[]>)+40]");
														text3 = (string)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag45 = ex8 == null;
														obj6 = 0;
														androidJavaObject = null;
														androidJavaObject2 = null;
														androidJavaClass = androidJavaClass2;
														_Canon = _Canon5;
														androidJavaObject4 = androidJavaObject8;
														obj17 = (object)(&androidJavaObject4);
														obj12 = 0;
														ex = null;
														obj13 = (object)(&text);
														array2 = array7;
														text4 = text8;
														androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v221 (Il2CppClass<System.Object[]>)+40]");
														text12 = (string)0;
														if (flag45)
														{
															goto IL_3228;
														}
													}
													bool flag46 = array8.Length == 0;
													androidJavaObject = null;
													androidJavaObject2 = null;
													androidJavaClass = androidJavaClass2;
													_Canon = _Canon5;
													androidJavaObject4 = androidJavaObject8;
													obj17 = (object)(&androidJavaObject4);
													obj12 = 0;
													ex = null;
													obj13 = (object)(&text);
													array2 = array7;
													text4 = text8;
													androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
													if (flag46)
													{
														goto IL_30e2;
													}
													object obj44 = array8 + 32;
													obj44 = _Canon5;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													bool flag47 = _Canon6 == null;
													androidJavaObject = null;
													androidJavaObject2 = null;
													androidJavaClass = androidJavaClass2;
													_Canon = _Canon5;
													obj17 = (object)(&androidJavaObject4);
													obj12 = 0;
													ex = null;
													obj13 = (object)(&text);
													array3 = array7;
													text4 = text8;
													androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
													text2 = (string)(object)_Canon5;
													if (!flag47)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECE8]");
														object obj45 = 0;
														text3 = (string)obj45;
														((AndroidJavaObject)(object)_Canon6).Call((string)obj45, array8);
														object obj46 = obj11;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2989 @ X20_v72+38]");
														object obj47 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2989 @ X20_v72+38]");
														bool flag48 = (nint)0 == 0;
														object obj48 = !flag48;
														if (obj48 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2989 @ X20_v72+38]");
															obj47 = 0;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3988 @ X8_v136+10]");
														object obj49 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3128 @ X0_v258+E4]");
														bool flag49 = (nint)0 == 0;
														object obj50 = !flag49;
														if (obj50 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2989 @ X20_v72+38]");
															object obj51 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3996 @ X8_v219+10]");
															obj49 = 0;
														}
														bool flag50 = androidJavaObject3 == null;
														androidJavaObject = null;
														androidJavaObject2 = null;
														androidJavaClass = androidJavaClass2;
														_Canon = _Canon5;
														androidJavaObject4 = androidJavaObject8;
														obj17 = (object)(&androidJavaObject4);
														obj12 = 0;
														ex = null;
														obj13 = (object)(&text);
														obj14 = 0;
														array2 = array8;
														text4 = text8;
														androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
														if (flag50)
														{
															goto IL_310d;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC88]");
														object obj52 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3128 @ X0_v258+A0]");
														obj18 = 0;
														obj14 = obj23;
														text3 = (string)obj52;
														System.__Canon _Canon7 = androidJavaObject3.Call<System.__Canon>((string)obj52, (object[])obj18);
														bool flag51 = _Canon7 == null;
														androidJavaObject = null;
														androidJavaObject2 = null;
														androidJavaClass = androidJavaClass2;
														_Canon = _Canon5;
														androidJavaObject4 = androidJavaObject8;
														obj17 = (object)(&androidJavaObject4);
														obj12 = 0;
														ex = null;
														obj13 = (object)(&text);
														array2 = (object[])obj18;
														text4 = text8;
														androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
														if (flag51)
														{
															goto IL_311b;
														}
														((AndroidJavaObject)(object)_Canon7).Dispose();
														object obj53 = (object)(&androidJavaObject3);
														object obj54 = obj53;
														bool flag52 = obj53 == null;
														array2 = (object[])obj18;
														text3 = null;
														if (flag52)
														{
															goto IL_34e5;
														}
														object obj55 = obj54;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4002 @ X8_v215+12E]");
														obj18 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4002 @ X8_v215+12E]");
														if ((nint)0 == 0)
														{
															goto IL_1ae1;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4002 @ X8_v215+98]");
														object obj56 = (nint)0 + (nint)8;
														object obj57;
														while (true)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4061 @ X10_v105-8]");
															if (0 == (nint)obj8)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4002 @ X8_v215+12E]");
															obj18 = -1;
															obj57 = obj56 + 16;
															bool flag53 = (nint)obj18 != 1;
															obj56 = obj57;
															if (flag53)
															{
																continue;
															}
															goto IL_1ae1;
														}
														obj18 = obj56;
														object obj58 = obj55 + obj56;
														object obj59 = obj58 + 312;
														obj57 = obj56;
														array2 = (object[])obj18;
														goto IL_356a;
													}
												}
												goto IL_2f5b;
											}
											goto IL_30d4;
										}
									}
									goto IL_2f4d;
								}
								goto IL_3038;
							}
						}
					}
					NullReferenceException ex9 = new NullReferenceException();
					androidJavaObject = null;
					androidJavaObject2 = null;
					androidJavaObject3 = null;
					androidJavaClass = null;
					_Canon = null;
					obj17 = (object)(&androidJavaObject4);
					obj18 = 4;
					obj12 = 0;
					ex = null;
					obj13 = (object)(&text);
					object[] array9 = array5;
					text4 = text8;
					androidJavaObject5 = androidJavaObject9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					OutOfMemoryException ex10 = new OutOfMemoryException();
					array3 = array9;
					IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
				}
			}
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_2f3f;
		}
		goto IL_2fc5;
		IL_30d4:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_30e2;
		IL_30c6:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		goto IL_30d4;
		IL_310d:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_311b;
		IL_311b:
		NullReferenceException ex16 = new NullReferenceException();
		IndexOutOfRangeException ex17 = new IndexOutOfRangeException();
		obj6 = 0;
		goto IL_3140;
		IL_30e2:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_30f0;
		IL_3140:
		OutOfMemoryException ex19 = new OutOfMemoryException();
		goto IL_314e;
		IL_315d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex2 = new ArgumentNullException();
		text5 = null;
		goto IL_317a;
		IL_3197:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex4 = new ArgumentNullException();
		text7 = null;
		goto IL_31b4;
		IL_314e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_315d;
		IL_317a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex3 = new ArgumentNullException();
		text6 = null;
		goto IL_3197;
		IL_31ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex7 = new ArgumentNullException();
		text11 = null;
		goto IL_320b;
		IL_31b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex5 = new ArgumentNullException();
		text9 = null;
		goto IL_31d1;
		IL_31d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex6 = new ArgumentNullException();
		text10 = null;
		goto IL_31ee;
		IL_3228:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex20 = new ArgumentNullException();
		string text13 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex21 = new ArgumentNullException();
		text3 = null;
		object obj61 = default;
		object obj63 = default;
		object obj65 = default;
		NullReferenceException ex24 = default;
		string[] result = default;
		object obj70 = default;
		string text14 = default;
		string text15 = default;
		while (true)
		{
			NullReferenceException ex22 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
			object obj67;
			object obj68;
			if ((nint)text3 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj12 = 1;
			}
			else
			{
				if ((nint)text3 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
					bool flag54 = (nint)text3 != 1;
					NullReferenceException ex23 = ex22;
					if (!flag54)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						object obj60 = obj61;
						text3 = (string)obj60;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj62 = obj63 & 1;
						if (obj62 != null)
						{
							object obj64 = (object)(&obj65);
							object obj66 = obj6 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj67 = obj66;
							obj18 = (object)(&obj65);
							obj68 = obj6;
							goto IL_3a39;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj69 = obj61;
						text3 = (string)(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						array2 = null;
						ex23 = ex24;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (IndexOutOfRangeException)obj70;
			}
			object obj71 = 0;
			System.__Canon _Canon8 = (System.__Canon)(object)text4;
			androidJavaObject5 = null;
			object obj72 = obj13;
			if (obj13 != null)
			{
				object obj73 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3650 @ X8_v11+12E]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3650 @ X8_v11+12E]");
				if ((nint)0 == 0)
				{
					goto IL_2d41;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3650 @ X8_v11+98]");
				object obj74 = (nint)0 + (nint)8;
				object obj57;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3821 @ X10_v7-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3650 @ X8_v11+12E]");
					obj18 = -1;
					obj57 = obj74 + 16;
					bool flag55 = (nint)obj18 != 1;
					obj74 = obj57;
					if (flag55)
					{
						continue;
					}
					goto IL_2d41;
				}
				obj18 = obj74;
				object obj75 = obj73 + obj74;
				object obj76 = obj75 + 312;
				obj57 = obj74;
				goto IL_39be;
			}
			goto IL_3cbb;
			IL_3cbb:
			bool flag56 = ex == null;
			object obj77 = !flag56;
			text4 = (string)(object)_Canon8;
			if (obj77 != null)
			{
				break;
			}
			bool flag57 = obj12 == null;
			object obj78 = !flag57;
			text4 = (string)(object)_Canon8;
			ex19 = (OutOfMemoryException)(object)ex;
			if (obj78 != null)
			{
				goto IL_314e;
			}
			bool flag58 = obj71 == null;
			object obj79 = !flag58;
			if (obj79 != null)
			{
				goto IL_3780;
			}
			obj68 = obj6 - 1;
			obj67 = obj6;
			text4 = (string)(object)_Canon8;
			goto IL_3a39;
			IL_3a39:
			object obj80 = (object)(&obj65);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2422 @ X8_v16+v2426 @ X20_v5*8]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2422 @ X8_v16+v2426 @ X20_v5*8]");
			bool flag59 = (nint)0 == 0;
			obj6 = obj67;
			if (flag59)
			{
				continue;
			}
			object obj82 = obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3885 @ X8_v17+188] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string message = text14 + text15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3899 @ X0_v26+E4]");
			bool flag60 = (nint)0 == 0;
			object obj83 = !flag60;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Debug.LogWarning(message);
			androidJavaObject5 = null;
			goto IL_3780;
			IL_2d41:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			array2 = null;
			goto IL_39be;
			IL_3780:
			return (string[])(object)androidJavaObject5;
			IL_39be:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3851 @ X0_v11+8]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3851 @ X0_v11] (should have been resolved before IL gen)");
			goto IL_3cbb;
		}
		goto IL_3140;
		IL_34e5:
		androidJavaObject = null;
		androidJavaObject2 = null;
		androidJavaClass = androidJavaClass2;
		_Canon = _Canon5;
		androidJavaObject4 = androidJavaObject8;
		obj17 = (object)(&androidJavaObject4);
		obj12 = 0;
		ex = null;
		obj13 = (object)(&text);
		text4 = text8;
		androidJavaObject5 = (AndroidJavaObject)(object)_Canon5;
		goto IL_30f0;
		IL_1ae1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_356a;
		IL_356a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4080 @ X0_v349+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4080 @ X0_v349] (should have been resolved before IL gen)");
		goto IL_34e5;
		IL_30f0:
		OutOfMemoryException ex25 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_310d;
		IL_2f5b:
		NullReferenceException ex26 = new NullReferenceException();
		NullReferenceException ex27 = new NullReferenceException();
		goto IL_2f77;
		IL_2f8d:
		IndexOutOfRangeException ex28 = new IndexOutOfRangeException();
		goto IL_2f9b;
		IL_2f9b:
		NullReferenceException ex29 = new NullReferenceException();
		goto IL_2fa9;
		IL_2fa9:
		IndexOutOfRangeException ex30 = new IndexOutOfRangeException();
		OutOfMemoryException ex31 = new OutOfMemoryException();
		goto IL_2fc5;
		IL_2fc5:
		IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_2fe2;
		IL_2fe2:
		IndexOutOfRangeException ex33 = new IndexOutOfRangeException();
		goto IL_2ff0;
		IL_2f77:
		NullReferenceException ex34 = new NullReferenceException();
		array2 = array3;
		goto IL_2f8d;
		IL_320b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex8 = new ArgumentNullException();
		text12 = null;
		goto IL_3228;
		IL_2f3f:
		IndexOutOfRangeException ex35 = new IndexOutOfRangeException();
		goto IL_2f4d;
		IL_2ff0:
		NullReferenceException ex36 = new NullReferenceException();
		OutOfMemoryException ex37 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_301b;
		IL_301b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex38 = new ArgumentNullException();
		text3 = null;
		goto IL_3038;
		IL_3046:
		IndexOutOfRangeException ex39 = new IndexOutOfRangeException();
		goto IL_3054;
		IL_3038:
		NullReferenceException ex40 = new NullReferenceException();
		goto IL_3046;
		IL_3054:
		NullReferenceException ex41 = new NullReferenceException();
		goto IL_3062;
		IL_3070:
		NullReferenceException ex42 = new NullReferenceException();
		OutOfMemoryException ex43 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_309b;
		IL_3062:
		NullReferenceException ex44 = new NullReferenceException();
		goto IL_3070;
		IL_309b:
		IndexOutOfRangeException ex45 = new IndexOutOfRangeException();
		OutOfMemoryException ex46 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_30c6;
		IL_2f4d:
		NullReferenceException ex47 = new NullReferenceException();
		goto IL_2f5b;
	}

	private unsafe static string HwSign(string message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1d12: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_1688: Expected Obj, but got I4
		//IL_168d: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_00d7: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I
		//IL_0288: Expected I4, but got I8
		//IL_029c: Expected Obj, but got I4
		//IL_02b8: Expected I, but got Obj
		//IL_01f1: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_032f: Expected I, but got Obj
		//IL_035a: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I
		//IL_0372: Expected I4, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_1988: Unknown result type (might be due to invalid IL or missing references)
		//IL_198d: Expected Obj, but got Unknown
		//IL_1644: Expected I, but got Obj
		//IL_1656: Expected I, but got Obj
		//IL_0512: Expected Obj, but got I4
		//IL_051c: Expected I, but got Obj
		//IL_0536: Expected I, but got Obj
		//IL_055d: Expected I, but got Obj
		//IL_19fe: Expected I, but got Obj
		//IL_1a15: Expected Obj, but got I4
		//IL_0446: Expected I, but got Obj
		//IL_0456: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I4
		//IL_0482: Expected I, but got Obj
		//IL_049c: Expected I, but got Obj
		//IL_04ce: Expected Obj, but got I
		//IL_04d3: Expected I, but got Obj
		//IL_19c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_1ae8: Expected Obj, but got I4
		//IL_2170: Expected Obj, but got I
		//IL_21bc: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I
		//IL_062a: Expected I, but got Obj
		//IL_063b: Expected Obj, but got I4
		//IL_1bcb: Expected Obj, but got I4
		//IL_15d8: Expected Obj, but got I4
		//IL_0f98: Expected Obj, but got I
		//IL_0669: Expected Obj, but got I4
		//IL_1cc6: Expected Obj, but got I4
		//IL_1dd4: Expected I, but got Obj
		//IL_1de4: Expected Obj, but got I
		//IL_0e43: Expected Obj, but got I
		//IL_075b: Expected Obj, but got I4
		//IL_076d: Expected I, but got Obj
		//IL_0772: Expected I, but got Obj
		//IL_078c: Expected I, but got Obj
		//IL_07b6: Expected I, but got Obj
		//IL_1155: Expected Obj, but got I
		//IL_1da8: Expected Obj, but got I
		//IL_067f: Expected I, but got Obj
		//IL_068f: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_06c3: Expected I, but got Obj
		//IL_06c8: Expected I, but got Obj
		//IL_06e2: Expected I, but got Obj
		//IL_0717: Expected Obj, but got I
		//IL_071c: Expected I, but got Obj
		//IL_0eb0: Expected I, but got Obj
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Expected Obj, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_0812: Expected I, but got Obj
		//IL_190a: Expected Obj, but got I4
		//IL_1ed7: Expected I, but got Obj
		//IL_1ee7: Expected Obj, but got I
		//IL_1008: Expected Obj, but got I
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected Obj, but got Unknown
		//IL_1312: Expected Obj, but got I
		//IL_1eab: Expected Obj, but got I
		//IL_0859: Expected Obj, but got I
		//IL_1fda: Expected I, but got Obj
		//IL_1fea: Expected Obj, but got I
		//IL_11c5: Expected Obj, but got I
		//IL_1075: Expected I, but got Obj
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected Obj, but got Unknown
		//IL_0889: Expected Obj, but got I4
		//IL_089b: Expected I, but got Obj
		//IL_08a0: Expected I, but got Obj
		//IL_08ba: Expected I, but got Obj
		//IL_08f1: Expected Obj, but got I4
		//IL_08f6: Expected I, but got Obj
		//IL_1fae: Expected Obj, but got I
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected Obj, but got Unknown
		//IL_1232: Expected I, but got Obj
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Expected Obj, but got Unknown
		//IL_0919: Expected I, but got Obj
		//IL_0939: Expected Obj, but got I
		//IL_0987: Expected Obj, but got I4
		//IL_20e5: Expected Obj, but got I
		//IL_1382: Expected Obj, but got I
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected Obj, but got Unknown
		//IL_09d2: Expected I, but got Obj
		//IL_14e1: Expected Obj, but got I4
		//IL_20b1: Expected Obj, but got I
		//IL_13ef: Expected I, but got Obj
		//IL_1405: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected Obj, but got Unknown
		//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected Obj, but got Unknown
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ab: Expected Obj, but got Unknown
		//IL_0b03: Expected Obj, but got I4
		//IL_0b15: Expected I, but got Obj
		//IL_0b1a: Expected I, but got Obj
		//IL_0b34: Expected I, but got Obj
		//IL_0b5f: Expected I, but got Obj
		//IL_0a26: Expected I, but got Obj
		//IL_0a36: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I4
		//IL_0a6a: Expected I, but got Obj
		//IL_0a6f: Expected I, but got Obj
		//IL_0a89: Expected I, but got Obj
		//IL_0abf: Expected Obj, but got I
		//IL_0ac4: Expected I, but got Obj
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected Obj, but got Unknown
		//IL_0bbb: Expected I, but got Obj
		//IL_0bf2: Expected Obj, but got I
		//IL_0c1b: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I
		//IL_0c55: Expected Obj, but got I4
		//IL_1d30: Expected Obj, but got I
		//IL_1d62: Expected Obj, but got I4
		//IL_2232: Expected Obj, but got I4
		//IL_2244: Expected I, but got Obj
		//IL_2249: Expected I, but got Obj
		//IL_2263: Expected I, but got Obj
		//IL_2296: Expected I, but got Obj
		//IL_0c7d: Expected Obj, but got I
		//IL_0cac: Expected Obj, but got I
		//IL_0cc1: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got I
		//IL_0d28: Expected Obj, but got I
		//IL_0d52: Expected Obj, but got I4
		//IL_0d85: Expected Obj, but got I4
		//IL_0d97: Expected I, but got Obj
		//IL_0d9c: Expected I, but got Obj
		//IL_0dae: Expected I, but got Obj
		//IL_0dcc: Expected Obj, but got I4
		//IL_0dd6: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidJavaObject androidJavaObject = OpenKeyStore();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		bool flag2 = array == null;
		AndroidJavaObject androidJavaObject2 = null;
		AndroidJavaClass androidJavaClass = null;
		System.__Canon _Canon = null;
		System.__Canon _Canon2 = (System.__Canon)2;
		AndroidJavaObject androidJavaObject3 = default;
		nint num = (nint)(&androidJavaObject3);
		if (flag2)
		{
			goto IL_1668;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC00]");
		System.__Canon _Canon3 = (System.__Canon)0;
		bool flag3 = _Canon3 == null;
		string text = (string)2;
		object obj6;
		nint num2;
		OutOfMemoryException ex2;
		nint num3;
		string text2;
		NullReferenceException ex = default;
		if (!flag3)
		{
			num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			flag2 = ex == null;
			obj6 = 0;
			androidJavaObject2 = null;
			androidJavaClass = null;
			_Canon = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			num2 = unchecked((nint)null);
			ex2 = null;
			num3 = (nint)(&androidJavaObject3);
			if (flag2)
			{
				goto IL_177d;
			}
		}
		num = array.Length;
		flag2 = array.Length == 0;
		androidJavaObject2 = null;
		androidJavaClass = null;
		_Canon = null;
		_Canon2 = (System.__Canon)(object)text;
		if (flag2)
		{
			goto IL_1676;
		}
		object obj7 = array + 32;
		obj7 = _Canon3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		System.__Canon _Canon4 = default;
		bool flag4 = _Canon4 == null;
		_Canon2 = null;
		ArgumentNullException ex3 = default;
		System.__Canon _Canon5;
		if (!flag4)
		{
			num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			_Canon2 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			flag2 = ex3 == null;
			obj6 = 0;
			androidJavaObject2 = null;
			androidJavaClass = null;
			_Canon = null;
			_Canon3 = _Canon4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			_Canon5 = (System.__Canon)0;
			num2 = unchecked((nint)null);
			ex2 = null;
			num3 = (nint)(&androidJavaObject3);
			if (flag2)
			{
				goto IL_179a;
			}
		}
		num = array.Length;
		flag2 = (byte)(array.Length & 0xFFFFFFFEL) != 0;
		bool flag5 = !flag2;
		obj6 = 0;
		androidJavaObject2 = null;
		androidJavaClass = null;
		_Canon = null;
		_Canon3 = _Canon4;
		num2 = unchecked((nint)null);
		ex2 = null;
		num3 = (nint)(&androidJavaObject3);
		if (flag5)
		{
			goto IL_16bc;
		}
		object obj9 = array + 40;
		obj9 = _Canon4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		flag2 = androidJavaObject == null;
		obj6 = 0;
		androidJavaObject2 = null;
		androidJavaClass = null;
		_Canon = null;
		_Canon3 = _Canon4;
		_Canon2 = _Canon4;
		num2 = unchecked((nint)null);
		ex2 = null;
		num3 = (nint)(&androidJavaObject3);
		int num4 = default;
		nint num5 = default;
		OutOfMemoryException ex5 = default;
		nint num6 = default;
		nint num7 = default;
		OutOfMemoryException ex6 = default;
		nint num8 = default;
		object[] array3 = default;
		nint num9 = default;
		OutOfMemoryException ex7 = default;
		nint num10 = default;
		nint num11 = default;
		object obj24 = default;
		object[] array7;
		object obj28;
		string result;
		ArgumentNullException ex4 = default;
		System.__Canon _Canon7;
		ArgumentNullException ex9 = default;
		string text3;
		ArgumentNullException ex8 = default;
		System.__Canon _Canon9;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED10]");
			object methodName = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
			object obj10 = 0;
			num4 = (int)obj10;
			System.__Canon _Canon6 = androidJavaObject.Call<System.__Canon>((string)methodName, array);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED08]");
			object className = 0;
			AndroidJavaClass androidJavaClass2 = default;
			androidJavaClass2._002Ector((string)className);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object[] array2 = default;
			flag2 = array2 == null;
			_Canon3 = _Canon4;
			_Canon2 = (System.__Canon)1;
			num = (nint)(&androidJavaClass);
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED18]");
				_Canon3 = (System.__Canon)0;
				bool flag6 = _Canon3 == null;
				_Canon2 = (System.__Canon)1;
				if (!flag6)
				{
					num = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
					_Canon2 = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					flag2 = ex4 == null;
					obj6 = 0;
					androidJavaObject2 = null;
					num5 = unchecked((nint)null);
					ex5 = null;
					num6 = (nint)(&androidJavaClass);
					androidJavaClass = androidJavaClass2;
					num7 = unchecked((nint)null);
					ex6 = null;
					num8 = (nint)(&_Canon);
					_Canon = _Canon6;
					array3 = null;
					num9 = (nint)(&_Canon);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
					_Canon7 = (System.__Canon)0;
					num2 = unchecked((nint)null);
					ex2 = null;
					num3 = (nint)(&androidJavaObject3);
					if (flag2)
					{
						goto IL_17b7;
					}
				}
				num = array2.Length;
				flag2 = array2.Length == 0;
				obj6 = 0;
				androidJavaObject2 = null;
				num5 = unchecked((nint)null);
				ex5 = null;
				num6 = (nint)(&androidJavaClass);
				androidJavaClass = androidJavaClass2;
				num7 = unchecked((nint)null);
				ex6 = null;
				num8 = (nint)(&_Canon);
				_Canon = _Canon6;
				array3 = null;
				num9 = (nint)(&_Canon);
				num2 = unchecked((nint)null);
				ex2 = null;
				num3 = (nint)(&androidJavaObject3);
				if (flag2)
				{
					goto IL_16f5;
				}
				object obj12 = array2 + 32;
				obj12 = _Canon3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				flag2 = androidJavaClass2 == null;
				_Canon2 = _Canon3;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC20]");
					object methodName2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC18]");
					num9 = 0;
					num4 = (int)num9;
					System.__Canon _Canon8 = androidJavaClass2.CallStatic<System.__Canon>((string)methodName2, array2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array4 = default;
					flag2 = array4 == null;
					ex7 = null;
					num10 = (nint)(&androidJavaObject2);
					num11 = unchecked((nint)null);
					array3 = array2;
					_Canon2 = (System.__Canon)1;
					num = (nint)(&androidJavaObject2);
					if (!flag2)
					{
						bool flag7 = _Canon6 == null;
						_Canon2 = (System.__Canon)1;
						if (!flag7)
						{
							num = (nint)array4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							_Canon2 = (System.__Canon)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							flag2 = ex8 == null;
							obj6 = 0;
							ex7 = null;
							num10 = (nint)(&androidJavaObject2);
							num11 = unchecked((nint)null);
							num5 = unchecked((nint)null);
							ex5 = null;
							num6 = (nint)(&androidJavaClass);
							androidJavaClass = androidJavaClass2;
							num7 = unchecked((nint)null);
							ex6 = null;
							num8 = (nint)(&_Canon);
							_Canon = _Canon6;
							array3 = array2;
							_Canon3 = _Canon6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							_Canon9 = (System.__Canon)0;
							num2 = unchecked((nint)null);
							ex2 = null;
							num3 = (nint)(&androidJavaObject3);
							if (flag2)
							{
								goto IL_17d4;
							}
						}
						num = array4.Length;
						flag2 = array4.Length == 0;
						obj6 = 0;
						ex7 = null;
						num10 = (nint)(&androidJavaObject2);
						num11 = unchecked((nint)null);
						num5 = unchecked((nint)null);
						ex5 = null;
						num6 = (nint)(&androidJavaClass);
						androidJavaClass = androidJavaClass2;
						num7 = unchecked((nint)null);
						ex6 = null;
						num8 = (nint)(&_Canon);
						_Canon = _Canon6;
						array3 = array2;
						_Canon3 = _Canon6;
						num2 = unchecked((nint)null);
						ex2 = null;
						num3 = (nint)(&androidJavaObject3);
						if (flag2)
						{
							goto IL_1720;
						}
						object obj13 = array4 + 32;
						obj13 = _Canon6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						flag2 = _Canon8 == null;
						ex7 = null;
						num10 = (nint)(&androidJavaObject2);
						num11 = unchecked((nint)null);
						array3 = array2;
						_Canon3 = _Canon6;
						_Canon2 = _Canon6;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED00]");
							num = 0;
							((AndroidJavaObject)(object)_Canon8).Call((string)num, array4);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Encoding uTF = Encoding.UTF8;
							flag2 = uTF == null;
							obj6 = 0;
							ex7 = null;
							num10 = (nint)(&androidJavaObject2);
							num11 = unchecked((nint)null);
							num5 = unchecked((nint)null);
							ex5 = null;
							num6 = (nint)(&androidJavaClass);
							androidJavaClass = androidJavaClass2;
							num7 = unchecked((nint)null);
							ex6 = null;
							num8 = (nint)(&_Canon);
							_Canon = _Canon6;
							array3 = array4;
							num4 = 0;
							_Canon3 = _Canon6;
							_Canon2 = (System.__Canon)1;
							num2 = unchecked((nint)null);
							ex2 = null;
							num3 = (nint)(&androidJavaObject3);
							if (!flag2)
							{
								nint num12 = (nint)uTF;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1832 @ X8_v109 (Il2CppClass<System.Text.Encoding>)+258]");
								num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1832 @ X8_v109 (Il2CppClass<System.Text.Encoding>)+260]");
								array3 = (object[])0;
								((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)message, 0, 0);
								object obj14 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v202+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1834 @ X0_v202+E4]");
								bool flag8 = (nint)0 == 0;
								object obj15 = !flag8;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								byte[] bytes = default;
								sbyte[] array5 = ToJava(bytes);
								object[] array6 = default;
								flag2 = array6 == null;
								ex7 = null;
								num10 = (nint)(&androidJavaObject2);
								num11 = unchecked((nint)null);
								num4 = 0;
								_Canon3 = _Canon6;
								_Canon2 = (System.__Canon)(object)message;
								if (!flag2)
								{
									bool flag9 = array5 == null;
									text2 = message;
									if (!flag9)
									{
										num = (nint)array6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
										text2 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										flag2 = ex9 == null;
										obj6 = 0;
										ex7 = null;
										num10 = (nint)(&androidJavaObject2);
										num11 = unchecked((nint)null);
										num5 = unchecked((nint)null);
										ex5 = null;
										num6 = (nint)(&androidJavaClass);
										androidJavaClass = androidJavaClass2;
										num7 = unchecked((nint)null);
										ex6 = null;
										num8 = (nint)(&_Canon);
										_Canon = _Canon6;
										num4 = 0;
										_Canon3 = _Canon6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
										text3 = (string)0;
										num2 = unchecked((nint)null);
										ex2 = null;
										num3 = (nint)(&androidJavaObject3);
										if (flag2)
										{
											goto IL_17f1;
										}
									}
									num = array6.Length;
									flag2 = array6.Length == 0;
									obj6 = 0;
									ex7 = null;
									num10 = (nint)(&androidJavaObject2);
									num11 = unchecked((nint)null);
									num5 = unchecked((nint)null);
									ex5 = null;
									num6 = (nint)(&androidJavaClass);
									androidJavaClass = androidJavaClass2;
									num7 = unchecked((nint)null);
									ex6 = null;
									num8 = (nint)(&_Canon);
									_Canon = _Canon6;
									num4 = 0;
									_Canon3 = _Canon6;
									num2 = unchecked((nint)null);
									ex2 = null;
									num3 = (nint)(&androidJavaObject3);
									if (flag2)
									{
										goto IL_1761;
									}
									object obj16 = array6 + 32;
									obj16 = array5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									flag2 = androidJavaObject2 == null;
									ex7 = null;
									num10 = (nint)(&androidJavaObject2);
									num11 = unchecked((nint)null);
									num4 = 0;
									_Canon3 = _Canon6;
									_Canon2 = (System.__Canon)(object)array5;
									if (!flag2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE038]");
										object obj17 = 0;
										text2 = (string)obj17;
										androidJavaObject2.Call((string)obj17, array6);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
										object obj18 = 0;
										object obj19 = obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X20_v49+38]");
										object obj20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X20_v49+38]");
										bool flag10 = (nint)0 == 0;
										object obj21 = !flag10;
										if (obj21 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X20_v49+38]");
											obj20 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2220 @ X8_v118+10]");
										object obj22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v213+E4]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v213+E4]");
										bool flag11 = (nint)0 == 0;
										object obj23 = !flag11;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X20_v49+38]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X8_v20 (Il2CppClass<System.Object[]>)+10]");
											obj22 = 0;
										}
										flag2 = androidJavaObject2 == null;
										obj6 = 0;
										ex7 = null;
										num10 = (nint)(&androidJavaObject2);
										num11 = unchecked((nint)null);
										num5 = unchecked((nint)null);
										ex5 = null;
										num6 = (nint)(&androidJavaClass);
										androidJavaClass = androidJavaClass2;
										num7 = unchecked((nint)null);
										ex6 = null;
										num8 = (nint)(&_Canon);
										_Canon = _Canon6;
										array3 = array6;
										num4 = 0;
										_Canon3 = _Canon6;
										num2 = unchecked((nint)null);
										ex2 = null;
										num3 = (nint)(&androidJavaObject3);
										if (flag2)
										{
											goto IL_176f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED20]");
										object methodName3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC78]");
										num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v213+A0]");
										obj24 = 0;
										array7 = (object[])obj24;
										num4 = (int)num9;
										System.__Canon bytes2 = androidJavaObject2.Call<System.__Canon>((string)methodName3, (object[])obj24);
										byte[] inArray = FromJava((sbyte[])(object)bytes2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
										object obj25 = 0;
										object obj26 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2239 @ X0_v217+E4]");
										bool flag12 = (nint)0 == 0;
										object obj27 = !flag12;
										if (obj27 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										string text4 = Convert.ToBase64String(inArray);
										obj6 = 0;
										ex7 = null;
										num10 = (nint)(&androidJavaObject2);
										num11 = unchecked((nint)null);
										num5 = unchecked((nint)null);
										ex5 = null;
										num6 = (nint)(&androidJavaClass);
										num7 = unchecked((nint)null);
										ex6 = null;
										num8 = (nint)(&_Canon);
										_Canon3 = _Canon6;
										obj28 = 2;
										_Canon2 = null;
										num2 = unchecked((nint)null);
										ex2 = null;
										num3 = (nint)(&androidJavaObject3);
										result = text4;
										goto IL_21b4;
									}
								}
								goto IL_1636;
							}
							goto IL_174b;
						}
					}
					goto IL_1628;
				}
			}
			NullReferenceException ex10 = new NullReferenceException();
			androidJavaObject2 = null;
			array3 = null;
			num9 = (nint)(&_Canon);
			goto IL_1628;
		}
		goto IL_16ca;
		IL_16d8:
		OutOfMemoryException ex11 = new OutOfMemoryException();
		goto IL_16e6;
		IL_16ca:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_16d8;
		IL_180e:
		NullReferenceException ex13 = new NullReferenceException();
		System.__Canon _Canon10 = _Canon2;
		NullReferenceException ex14 = ex13;
		object obj30 = default;
		object obj32 = default;
		NullReferenceException ex15 = default;
		NullReferenceException ex16 = default;
		object obj34 = default;
		object obj35;
		object obj36 = default;
		object obj37;
		object obj38;
		OutOfMemoryException ex17;
		IntPtr intPtr;
		IntPtr intPtr2;
		OutOfMemoryException ex18;
		IntPtr intPtr3;
		OutOfMemoryException ex19;
		object[] array8;
		int num13;
		nint num14;
		System.__Canon _Canon11;
		System.__Canon _Canon12;
		IntPtr intPtr4;
		OutOfMemoryException ex20;
		object obj39 = default;
		object obj40 = default;
		object obj41 = default;
		while (true)
		{
			if ((nint)_Canon10 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj29 = obj30;
				_Canon2 = (System.__Canon)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj31 = obj32 & 1;
				if (obj31 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				num = (nint)obj30;
				object obj33 = obj30;
				_Canon2 = (System.__Canon)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				array3 = null;
				ex14 = ex15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if ((nint)_Canon2 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num11 = 1;
			}
			else
			{
				if ((nint)_Canon2 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
					if ((nint)_Canon2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num5 = 1;
					}
					else
					{
						if ((nint)_Canon2 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
							if ((nint)_Canon2 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								num7 = 1;
							}
							else
							{
								if ((nint)_Canon2 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
									if ((nint)_Canon2 == 2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										num2 = 1;
									}
									else
									{
										if ((nint)_Canon2 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
											_Canon10 = _Canon2;
											ex14 = ex16;
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										ex2 = (OutOfMemoryException)obj34;
									}
									obj35 = obj36;
									obj37 = obj6;
									obj38 = obj24;
									ex17 = ex7;
									intPtr = num11;
									intPtr2 = num5;
									ex18 = ex5;
									intPtr3 = num7;
									ex19 = ex6;
									array8 = array3;
									num13 = num4;
									num14 = num9;
									_Canon11 = _Canon3;
									obj28 = 0;
									_Canon12 = _Canon2;
									intPtr4 = num2;
									ex20 = ex2;
									result = null;
									goto IL_130a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								ex6 = (OutOfMemoryException)obj39;
							}
							obj35 = obj36;
							obj37 = obj6;
							obj38 = obj24;
							ex17 = ex7;
							intPtr = num11;
							intPtr2 = num5;
							ex18 = ex5;
							intPtr3 = num7;
							ex19 = ex6;
							array8 = array3;
							num13 = num4;
							num14 = num9;
							_Canon11 = _Canon3;
							obj28 = 0;
							_Canon12 = _Canon2;
							intPtr4 = num2;
							ex20 = ex2;
							result = null;
							goto IL_114d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						ex5 = (OutOfMemoryException)obj40;
					}
					obj35 = obj36;
					obj37 = obj6;
					obj38 = obj24;
					ex17 = ex7;
					intPtr = num11;
					intPtr2 = num5;
					ex18 = ex5;
					intPtr3 = num7;
					ex19 = ex6;
					array8 = array3;
					num13 = num4;
					num14 = num9;
					_Canon11 = _Canon3;
					obj28 = 0;
					_Canon12 = _Canon2;
					intPtr4 = num2;
					ex20 = ex2;
					result = null;
					goto IL_0f90;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex7 = (OutOfMemoryException)obj41;
			}
			array7 = array3;
			obj28 = 0;
			result = null;
			goto IL_21b4;
		}
		object obj42 = default;
		nint num15 = (nint)(&obj42);
		object obj43 = obj6 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		obj37 = obj43;
		num9 = (nint)(&obj42);
		object obj44 = obj6;
		goto IL_2158;
		IL_1dcc:
		object obj45 = default;
		num = (nint)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ X0_v10+8]");
		_Canon2 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1799 @ X0_v10] (should have been resolved before IL gen)");
		goto IL_1d70;
		IL_0e94:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array3 = null;
		goto IL_1dcc;
		IL_1d70:
		if (ex7 != null)
		{
			goto IL_172e;
		}
		bool flag13 = num11 == 0;
		flag2 = !flag13;
		obj35 = obj36;
		obj37 = obj6;
		obj38 = obj24;
		ex17 = ex7;
		intPtr = num11;
		intPtr2 = num5;
		ex18 = ex5;
		intPtr3 = num7;
		ex19 = ex6;
		array8 = array3;
		num13 = num4;
		num14 = num9;
		_Canon11 = _Canon3;
		_Canon12 = _Canon2;
		intPtr4 = num2;
		ex20 = ex2;
		OutOfMemoryException ex21 = ex7;
		if (!flag2)
		{
			goto IL_0f90;
		}
		goto IL_173c;
		IL_0f90:
		object obj46 = num6;
		if (num6 == 0)
		{
			goto IL_1df3;
		}
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v80+12E]");
		num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v80+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1059;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v80+98]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1928 @ X10_v54-8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1928 @ X10_v54-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v80+12E]");
			num14 = -1;
			obj38 = obj48 + 16;
			bool flag14 = num14 != 1;
			obj48 = obj38;
			if (flag14)
			{
				continue;
			}
			goto IL_1059;
		}
		num14 = (nint)obj48;
		object obj49 = obj47 + obj48;
		object obj50 = obj49 + 312;
		obj38 = obj48;
		goto IL_1ecf;
		IL_16e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_16f5;
		IL_16f5:
		IndexOutOfRangeException ex22 = new IndexOutOfRangeException();
		goto IL_1703;
		IL_1703:
		OutOfMemoryException ex23 = new OutOfMemoryException();
		goto IL_1711;
		IL_1720:
		IndexOutOfRangeException ex24 = new IndexOutOfRangeException();
		goto IL_172e;
		IL_1059:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array8 = null;
		goto IL_1ecf;
		IL_2158:
		nint num16 = (nint)(&obj42);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v14 (Il2CppClass<System.Object[]>)+v1236 @ X20_v5*8]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v14 (Il2CppClass<System.Object[]>)+v1236 @ X20_v5*8]");
		flag2 = (nint)0 == 0;
		obj6 = obj37;
		num = (nint)(&obj42);
		if (flag2)
		{
			goto IL_180e;
		}
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1585 @ X8_v15+188] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text5 = default;
		string text6 = default;
		string message2 = text5 + text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X0_v25+E4]");
		bool flag15 = (nint)0 == 0;
		object obj53 = !flag15;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Debug.LogWarning(message2);
		result = null;
		goto IL_20f4;
		IL_1ecf:
		num = (nint)obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1991 @ X0_v154+8]");
		_Canon12 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1991 @ X0_v154] (should have been resolved before IL gen)");
		goto IL_1df3;
		IL_1711:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1720;
		IL_1df3:
		bool flag16 = ex18 == null;
		flag2 = !flag16;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		if (flag2)
		{
			goto IL_1703;
		}
		bool flag17 = intPtr2 == (IntPtr)0;
		flag2 = !flag17;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		ex23 = ex18;
		if (!flag2)
		{
			goto IL_114d;
		}
		goto IL_1711;
		IL_172e:
		ex21 = new OutOfMemoryException();
		goto IL_173c;
		IL_173c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_174b;
		IL_114d:
		object obj54 = num8;
		if (num8 == 0)
		{
			goto IL_1ef6;
		}
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X8_v72+12E]");
		num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X8_v72+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1216;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X8_v72+98]");
		object obj56 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2066 @ X10_v46-8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2066 @ X10_v46-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X8_v72+12E]");
			num14 = -1;
			obj38 = obj56 + 16;
			bool flag18 = num14 != 1;
			obj56 = obj38;
			if (flag18)
			{
				continue;
			}
			goto IL_1216;
		}
		num14 = (nint)obj56;
		object obj57 = obj55 + obj56;
		object obj58 = obj57 + 312;
		obj38 = obj56;
		goto IL_1fd2;
		IL_174b:
		NullReferenceException ex25 = new NullReferenceException();
		text2 = (string)(object)_Canon2;
		goto IL_1761;
		IL_1628:
		NullReferenceException ex26 = new NullReferenceException();
		goto IL_1636;
		IL_1761:
		IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
		goto IL_176f;
		IL_176f:
		ex = new NullReferenceException();
		goto IL_177d;
		IL_1216:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array8 = null;
		goto IL_1fd2;
		IL_169f:
		OutOfMemoryException ex28 = new OutOfMemoryException();
		goto IL_16ad;
		IL_1fd2:
		num = (nint)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2124 @ X0_v145+8]");
		_Canon12 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2124 @ X0_v145] (should have been resolved before IL gen)");
		goto IL_1ef6;
		IL_177d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex3 = new ArgumentNullException();
		_Canon5 = null;
		goto IL_179a;
		IL_1ef6:
		bool flag19 = ex19 == null;
		flag2 = !flag19;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		if (flag2)
		{
			goto IL_16d8;
		}
		bool flag20 = intPtr3 == (IntPtr)0;
		flag2 = !flag20;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		ex11 = ex19;
		if (!flag2)
		{
			goto IL_130a;
		}
		goto IL_16e6;
		IL_130a:
		object obj59 = num3;
		if (num3 == 0)
		{
			goto IL_1ff9;
		}
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v64+12E]");
		num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v64+12E]");
		if ((nint)0 == 0)
		{
			goto IL_13d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v64+98]");
		object obj61 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2189 @ X10_v38-8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2189 @ X10_v38-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v64+12E]");
			num14 = -1;
			obj38 = obj61 + 16;
			bool flag21 = num14 != 1;
			obj61 = obj38;
			if (flag21)
			{
				continue;
			}
			goto IL_13d3;
		}
		num14 = (nint)obj61;
		object obj62 = obj60 + obj61;
		object obj63 = obj62 + 312;
		obj38 = obj61;
		goto IL_20d5;
		IL_1636:
		NullReferenceException ex29 = new NullReferenceException();
		num5 = unchecked((nint)null);
		ex5 = null;
		num6 = (nint)(&androidJavaClass);
		num7 = unchecked((nint)null);
		ex6 = null;
		num8 = (nint)(&_Canon);
		goto IL_1668;
		IL_1668:
		NullReferenceException ex30 = new NullReferenceException();
		goto IL_1676;
		IL_1676:
		IndexOutOfRangeException ex31 = new IndexOutOfRangeException();
		obj6 = 0;
		num2 = unchecked((nint)null);
		ex2 = null;
		num3 = (nint)(&androidJavaObject3);
		goto IL_169f;
		IL_179a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex4 = new ArgumentNullException();
		_Canon7 = null;
		goto IL_17b7;
		IL_17d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex9 = new ArgumentNullException();
		text3 = null;
		goto IL_17f1;
		IL_17b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex8 = new ArgumentNullException();
		_Canon9 = null;
		goto IL_17d4;
		IL_20f4:
		return result;
		IL_17f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex32 = new ArgumentNullException();
		_Canon2 = null;
		goto IL_180e;
		IL_13d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array8 = null;
		goto IL_20d5;
		IL_1ff9:
		bool flag22 = ex20 == null;
		flag2 = !flag22;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		if (flag2)
		{
			goto IL_169f;
		}
		bool flag23 = intPtr4 == (IntPtr)0;
		flag2 = !flag23;
		obj36 = obj35;
		obj6 = obj37;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		ex28 = ex20;
		if (flag2)
		{
			goto IL_16ad;
		}
		bool flag24 = obj28 == null;
		object obj64 = !flag24;
		if (obj64 != null)
		{
			goto IL_20f4;
		}
		obj44 = obj37 - 1;
		obj36 = obj35;
		obj24 = obj38;
		ex7 = ex17;
		num11 = intPtr;
		num5 = intPtr2;
		ex5 = ex18;
		num7 = intPtr3;
		ex6 = ex19;
		array3 = array8;
		num4 = num13;
		num9 = num14;
		_Canon3 = _Canon11;
		_Canon2 = _Canon12;
		num2 = intPtr4;
		ex2 = ex20;
		goto IL_2158;
		IL_20d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2214 @ X0_v136+8]");
		_Canon12 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2214 @ X0_v136] (should have been resolved before IL gen)");
		goto IL_1ff9;
		IL_21b4:
		object obj65 = num10;
		bool flag25 = num10 == 0;
		array3 = array7;
		if (flag25)
		{
			goto IL_1d70;
		}
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ X8_v9+12E]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e94;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ X8_v9+98]");
		object obj67 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ X10_v7-8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ X10_v7-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ X8_v9+12E]");
			num9 = -1;
			obj24 = obj67 + 16;
			bool flag26 = num9 != 1;
			obj67 = obj24;
			if (flag26)
			{
				continue;
			}
			goto IL_0e94;
		}
		num9 = (nint)obj67;
		object obj68 = obj66 + obj67;
		obj45 = obj68 + 312;
		obj24 = obj67;
		array3 = array7;
		goto IL_1dcc;
		IL_16ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_16bc;
		IL_16bc:
		IndexOutOfRangeException ex33 = new IndexOutOfRangeException();
		goto IL_16ca;
	}

	private unsafe static string HwPublicKey()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a7b: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00c0: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_0a99: Expected Obj, but got I
		//IL_0abb: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected Obj, but got Unknown
		//IL_0ad9: Expected Obj, but got I
		//IL_0afb: Expected Obj, but got I4
		//IL_0a08: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got Ref
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Obj, but got Unknown
		//IL_032e: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_0c64: Expected Obj, but got Ref
		//IL_0c74: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I4
		//IL_081d: Expected Obj, but got I4
		//IL_0c32: Expected Obj, but got Ref
		//IL_046d: Expected Obj, but got I
		//IL_0b59: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidJavaObject androidJavaObject = OpenKeyStore();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		bool flag2 = array == null;
		string text = (string)1;
		System.__Canon _Canon;
		System.__Canon _Canon3;
		System.__Canon _Canon4;
		string text2;
		object[] array2;
		System.__Canon _Canon2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC00]");
			object obj6 = 0;
			bool flag3 = obj6 == null;
			text = (string)1;
			if (!flag3)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj7 = default;
				bool flag4 = obj7 == null;
				_Canon = null;
				_Canon2 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v74 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag4)
				{
					goto IL_08ee;
				}
			}
			if (array.Length == 0)
			{
				goto IL_085b;
			}
			text = (string)obj6;
			object obj8 = array + 32;
			obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (androidJavaObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED30]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
				object obj10 = 0;
				text = (string)obj9;
				object obj11 = obj10;
				_Canon3 = androidJavaObject.Call<System.__Canon>((string)obj9, array);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
				obj6 = 0;
				object obj12 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X20_v19+38]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X20_v19+38]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X20_v19+38]");
					obj13 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v33+10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v71+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X20_v19+38]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v72+10]");
					obj15 = 0;
				}
				bool flag7 = _Canon3 == null;
				_Canon = null;
				_Canon2 = _Canon3;
				array2 = array;
				if (flag7)
				{
					goto IL_0890;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED38]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v71+A0]");
				object obj19 = 0;
				obj11 = obj10;
				text = (string)obj18;
				array2 = (object[])obj19;
				_Canon4 = ((AndroidJavaObject)(object)_Canon3).Call<System.__Canon>((string)obj18, (object[])obj19);
				object obj20 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X20_v20+38]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X20_v20+38]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X20_v20+38]");
					obj21 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v39+10]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v76+E4]");
				bool flag9 = (nint)0 == 0;
				object obj24 = !flag9;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X20_v20+38]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v70+10]");
					obj23 = 0;
				}
				bool flag10 = _Canon4 == null;
				_Canon = _Canon4;
				_Canon2 = _Canon3;
				if (flag10)
				{
					goto IL_08ac;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CECB8]");
				object methodName = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC78]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v76+A0]");
				object obj27 = 0;
				array2 = (object[])obj27;
				obj11 = obj26;
				System.__Canon bytes = ((AndroidJavaObject)(object)_Canon4).Call<System.__Canon>((string)methodName, (object[])obj27);
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v79+E4]");
				bool flag11 = (nint)0 == 0;
				object obj29 = !flag11;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				byte[] inArray = FromJava((sbyte[])(object)bytes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC120]");
				object obj30 = 0;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v83+E4]");
				bool flag12 = (nint)0 == 0;
				object obj32 = !flag12;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text3 = Convert.ToBase64String(inArray);
				object obj33 = (object)(&_Canon);
				object obj34 = obj33;
				bool flag13 = obj33 == null;
				text = null;
				if (flag13)
				{
					goto IL_0b09;
				}
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v66+12E]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v66+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04f1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X8_v66+98]");
				object obj37 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X10_v33-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj36--;
					obj27 = obj37 + 16;
					bool flag14 = (nint)obj36 != 1;
					obj37 = obj27;
					if (flag14)
					{
						continue;
					}
					goto IL_04f1;
				}
				object obj38 = obj35 + obj37;
				object obj39 = obj38 + 312;
				obj27 = obj37;
				goto IL_0b49;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_085b;
		IL_08c9:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		text2 = text;
		goto IL_08ee;
		IL_0b49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v105+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v899 @ X0_v105] (should have been resolved before IL gen)");
		goto IL_0b09;
		IL_08ac:
		NullReferenceException ex3 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_08c9;
		IL_0890:
		NullReferenceException ex4 = new NullReferenceException();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_08ac;
		IL_08ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex6 = new ArgumentNullException();
		object obj40 = 0;
		text = null;
		object obj42 = default;
		object obj44 = default;
		object obj46 = default;
		string text4 = default;
		string text5 = default;
		NullReferenceException ex9 = default;
		while (true)
		{
			NullReferenceException ex7 = new NullReferenceException();
			bool flag15 = (nint)text != 1;
			NullReferenceException ex8 = ex7;
			if (flag15)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj41 = obj42;
			text = (string)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj43 = obj44 & 1;
			if (obj43 != null)
			{
				object obj45 = (object)(&obj46);
				object obj47 = obj40 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj48 = obj47;
				object obj49 = obj40;
				object obj50 = (object)(&obj46);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v7+v402 @ X20_v2*8]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v7+v402 @ X20_v2*8]");
				bool flag16 = (nint)0 == 0;
				obj40 = obj48;
				if (!flag16)
				{
					object obj52 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ X8_v8+188] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string message = text4 + text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v16+E4]");
					bool flag17 = (nint)0 == 0;
					object obj53 = !flag17;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Debug.LogWarning(message);
					return null;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj54 = obj42;
			text = (string)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			array2 = null;
			ex8 = ex9;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		string result = default;
		return result;
		IL_04f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array2 = null;
		goto IL_0b49;
		IL_0b09:
		_Canon = _Canon4;
		_Canon2 = _Canon3;
		goto IL_08c9;
		IL_085b:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		_Canon = null;
		_Canon2 = null;
		OutOfMemoryException ex11 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0890;
	}

	private static sbyte[] ToJava(byte[] bytes)
	{
		//IL_0015: Expected Obj, but got I
		if (bytes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6750]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Array array = default;
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return (sbyte[])array;
		}
		return (sbyte[])(object)new NullReferenceException();
	}

	private static byte[] FromJava(sbyte[] bytes)
	{
		//IL_0015: Expected Obj, but got I
		if (bytes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Array array = default;
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return (byte[])array;
		}
		return (byte[])(object)new NullReferenceException();
	}

	private static IEnumerator PlainPost(string path, string body, Action<bool, string> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED48]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CPlainPost_003Ed__188 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 32;
			obj3 = path;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 40;
			obj4 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 48;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private unsafe static void NoteHttp(string path, UnityWebRequest request, float began, bool ok)
	{
		//IL_0715: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I
		//IL_07be: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I8
		//IL_0235: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected I8, but got Unknown
		//IL_07f7: Expected Obj, but got I
		//IL_0811: Expected Obj, but got I4
		//IL_06da: Expected Obj, but got I
		//IL_06eb: Expected Obj, but got I4
		//IL_08db: Expected Obj, but got I4
		//IL_08eb: Expected Obj, but got I4
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got I
		//IL_0673: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got I8
		//IL_06ac: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_052c: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected Obj, but got Unknown
		//IL_0517: Expected Obj, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_05af: Expected Obj, but got I4
		//IL_0893: Expected Obj, but got I
		string text2;
		if (request.m_DownloadHandler != null)
		{
			string text = request.m_DownloadHandler.text;
			text2 = text;
		}
		else
		{
			text2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		bool flag = default;
		if (flag)
		{
			long responseCode = request.responseCode;
			if (responseCode != 403)
			{
				return;
			}
			string text3 = (string)((text2 != null) ? text2 : obj);
			string text4 = text3.TrimStart();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED50]");
			object value = 0;
			bool flag2 = text4.StartsWith((string)value);
			bool flag3 = !flag2;
			object obj2 = !flag3;
			if (obj2 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj3 = 0;
		long responseCode2 = request.responseCode;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED68]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj7 = 0;
		string error = request.error;
		object obj8 = obj3;
		string text5 = (string)((error != null) ? error : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v14+A0]");
		object obj10 = (nint)0 + (nint)104;
		obj10 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string responseHeader = request.GetResponseHeader((string)name);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			object obj11 = array + 32;
			obj11 = path;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v10-8]");
			object obj12 = 0 & 0xFFFFFFFEL;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj13 = 0;
				object obj14 = array + 40;
				obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj15 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v59+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v33+60]");
				string text8;
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v59+E4]");
					bool flag6 = (nint)0 == 0;
					object obj17 = !flag6;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj18 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v45+A0]");
						obj16 = 0;
					}
					long num = obj16 + 96;
					string text6 = ((long*)num)->ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED78]");
					object obj19 = 0;
					string text7 = (string)obj19 + text6;
					object obj20 = 0;
					text8 = text7;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v59+E4]");
					bool flag7 = (nint)0 == 0;
					object obj21 = !flag7;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v59+A0]");
						obj16 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v33+68]");
					text8 = (string)0;
					if (text8._stringLength > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v59+E4]");
						bool flag8 = (nint)0 == 0;
						object obj22 = !flag8;
						object obj20 = 0;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj23 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v38+A0]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v39+68]");
							text8 = (string)0;
							obj20 = 0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
						object obj25 = 0;
						text8 = (string)obj25;
						object obj20 = 0;
					}
				}
				bool flag9 = array.Length < 2;
				object obj26 = !flag9;
				object obj27 = array.Length - 2;
				bool flag10 = obj27 == null;
				object obj28 = ~obj26;
				object obj29 = obj28 | flag10;
				if (obj29 == null)
				{
					object obj30 = array + 48;
					obj30 = text8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X20_v7-18]");
					object obj31 = 0 & 0xFFFFFFFCL;
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED70]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED80]");
						object obj33 = 0;
						object obj34 = array + 56;
						obj34 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						float realtimeSinceStartup = Time.realtimeSinceStartup;
						float num2 = realtimeSinceStartup - began;
						float num3 = default;
						string text9 = num3.ToString((string)obj33);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X20_v9-20]");
						bool flag11 = (nint)0 < (nint)4;
						object obj35 = !flag11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X20_v9-20]");
						object obj36 = -4;
						bool flag12 = obj36 == null;
						object obj37 = ~obj35;
						object obj38 = obj37 | flag12;
						if (obj38 == null)
						{
							object obj39 = array + 64;
							obj39 = text9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X20_v11-28]");
							bool flag13 = (nint)0 < (nint)5;
							object obj40 = !flag13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X20_v11-28]");
							object obj41 = -5;
							bool flag14 = obj41 == null;
							object obj42 = ~obj40;
							object obj43 = obj42 | flag14;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED58]");
								object obj44 = 0;
								object obj45 = array + 72;
								obj45 = obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text10;
								if (string.IsNullOrEmpty(responseHeader))
								{
									text10 = (string)obj;
									object obj46 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED60]");
									object obj47 = 0;
									string text11 = (string)obj47 + responseHeader;
									object obj46 = 0;
									text10 = text11;
								}
								bool flag15 = array.Length < 6;
								object obj48 = !flag15;
								object obj49 = array.Length - 6;
								bool flag16 = obj49 == null;
								object obj50 = ~obj48;
								object obj51 = obj50 | flag16;
								if (obj51 == null)
								{
									object obj52 = array + 80;
									obj52 = text10;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text12 = string.Concat(array);
									object obj53 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v29+E4]");
									bool flag17 = (nint)0 == 0;
									object obj54 = !flag17;
									if (obj54 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj53 = obj3;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v29+A0]");
									object obj55 = (nint)0 + (nint)88;
									obj55 = text12;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									return;
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

	private static string HttpSaid(string error)
	{
		//IL_013e: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		if (error != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0B0]");
			object value = 0;
			if (error.EndsWith((string)value))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+58]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+58]");
				if ((nint)0 == 0)
				{
					return (string)(object)new NullReferenceException();
				}
				if (text._stringLength > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj6 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v15+A0]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v16+58]");
						text = (string)0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
					object obj8 = 0;
					return (string)obj8 + text;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		return (string)0;
	}

	private static IEnumerator SignedPost(string path, string body, Action<bool, string> done, bool verifyReply = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CSignedPost_003Ed__191 obj2 = default;
		obj2._002Ector(0);
		if (obj2 != null)
		{
			object obj3 = obj2 + 48;
			obj3 = path;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 40;
			obj4 = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 32;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj2.verifyReply = verifyReply;
			return (IEnumerator)(object)obj2;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private static T FromJson<T>(string json) where T : class
	{
		//IL_003b: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(json);
		bool flag2 = !flag;
		object obj = !flag2;
		T result = null;
		if (obj == null)
		{
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(json);
			result = (T)(object)_Canon;
		}
		return result;
	}

	private unsafe static string Hash(string text)
	{
		//IL_034b: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_0388: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I
		//IL_043a: Expected Obj, but got Ref
		//IL_0459: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		SHA256 sHA = SHA256.Create();
		Encoding uTF = Encoding.UTF8;
		bool flag = uTF == null;
		object obj = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_0257;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		nint num = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X9_v2 (Il2CppClass<System.Text.Encoding>)+258]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X9_v2 (Il2CppClass<System.Text.Encoding>)+260]");
		object obj4 = 0;
		string buffer = (string)((text != null) ? text : obj2);
		int count = default;
		((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)buffer, 0, count);
		bool flag2 = sHA == null;
		byte[] array = default;
		nint num2 = (nint)array;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_0274;
		}
		byte[] bytes = sHA.ComputeHash(array);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v38+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = ToHex(bytes);
		byte[] array2 = array;
		obj4 = 0;
		obj = 0;
		ex = null;
		string result = text2;
		goto IL_0432;
		IL_0432:
		object obj9 = default;
		object obj8 = (object)(&obj9);
		object obj10 = obj8;
		bool flag4 = obj8 == null;
		num2 = (nint)array2;
		if (flag4)
		{
			goto IL_03a4;
		}
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v8+12E]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v8+98]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X10_v9-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v8+12E]");
			num = -1;
			obj3 = obj12 + 16;
			bool flag5 = num != 1;
			obj12 = obj3;
			if (flag5)
			{
				continue;
			}
			goto IL_01cc;
		}
		num = (nint)obj12;
		object obj13 = obj11 + obj12;
		object obj14 = obj13 + 312;
		obj3 = obj12;
		goto IL_03f0;
		IL_03a4:
		bool flag6 = ex == null;
		object obj15 = !flag6;
		NullReferenceException ex2;
		if (obj15 == null)
		{
			bool flag7 = obj == null;
			object obj16 = !flag7;
			ex2 = ex;
			if (obj16 == null)
			{
				return result;
			}
			goto IL_0265;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0257;
		IL_0274:
		NullReferenceException ex4 = new NullReferenceException();
		if (num2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if (num2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				string result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj17 = default;
			ex = (NullReferenceException)obj17;
		}
		array2 = (byte[])num2;
		result = null;
		goto IL_0432;
		IL_0265:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0274;
		IL_0257:
		ex2 = new NullReferenceException();
		goto IL_0265;
		IL_01cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj4 = 0;
		goto IL_03f0;
		IL_03f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v11+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X0_v11] (should have been resolved before IL gen)");
		goto IL_03a4;
	}

	private unsafe static string Hmac(string key, string message)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_002d: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_0488: Expected Obj, but got Ref
		//IL_0395: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got Ref
		//IL_01bc: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_028c: Expected I, but got Obj
		//IL_0502: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		object obj4 = default;
		NullReferenceException ex = default;
		object obj5 = default;
		HMACSHA256 hMACSHA2 = default;
		string text2;
		string text3 = default;
		byte[] array3;
		string result;
		string text;
		object obj3;
		nint num2;
		if (uTF != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED98]");
			object obj2 = 0;
			text = (string)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v18 (Il2CppClass<System.Text.Encoding>)+258]");
			obj3 = 0;
			string buffer = (string)((key != null) ? key : obj);
			int count = default;
			((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])(object)buffer, 0, count);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			HMACSHA256 hMACSHA = default;
			byte[] array = default;
			hMACSHA._002Ector(array);
			Encoding uTF2 = Encoding.UTF8;
			bool flag = uTF2 == null;
			obj4 = 0;
			ex = null;
			obj5 = (object)(&hMACSHA2);
			hMACSHA2 = hMACSHA;
			text2 = (string)(object)array;
			num2 = unchecked((nint)null);
			if (flag)
			{
				goto IL_0328;
			}
			nint num3 = (nint)uTF2;
			text = (string)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v21 (Il2CppClass<System.Text.Encoding>)+258]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v21 (Il2CppClass<System.Text.Encoding>)+260]");
			num2 = 0;
			if (text3 == null)
			{
				text3 = (string)obj;
			}
			((System.Security.Cryptography.TailStream)(object)uTF2).Write((byte[])(object)text3, 0, count);
			bool flag2 = hMACSHA == null;
			obj4 = 0;
			ex = null;
			obj5 = (object)(&hMACSHA2);
			hMACSHA2 = hMACSHA;
			byte[] array2 = default;
			text2 = (string)(object)array2;
			if (flag2)
			{
				goto IL_0345;
			}
			byte[] bytes = hMACSHA.ComputeHash(array2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v43+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text4 = ToHex(bytes);
			obj4 = 0;
			ex = null;
			obj5 = (object)(&hMACSHA2);
			array3 = array2;
			num2 = unchecked((nint)null);
			result = text4;
			goto IL_0534;
		}
		NullReferenceException ex2 = new NullReferenceException();
		hMACSHA2 = null;
		goto IL_0312;
		IL_04f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v8+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_04a6;
		IL_04a6:
		bool flag4 = ex == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_0312;
		}
		bool flag5 = obj4 == null;
		object obj10 = !flag5;
		text2 = text3;
		NullReferenceException ex3 = ex;
		if (obj10 == null)
		{
			return result;
		}
		goto IL_0336;
		IL_0345:
		NullReferenceException ex4 = new NullReferenceException();
		if ((nint)text2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
		}
		else
		{
			if ((nint)text2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				string result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj11 = default;
			ex = (NullReferenceException)obj11;
		}
		array3 = (byte[])(object)text2;
		result = null;
		goto IL_0534;
		IL_0534:
		object obj12 = obj5;
		bool flag6 = obj5 == null;
		text3 = (string)(object)array3;
		if (flag6)
		{
			goto IL_04a6;
		}
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v7+12E]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v7+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v7+98]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X10_v9-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v7+12E]");
			text = (string)(-1);
			obj3 = obj14 + 16;
			bool flag7 = (nint)text != 1;
			obj14 = obj3;
			if (flag7)
			{
				continue;
			}
			goto IL_027d;
		}
		text = (string)obj14;
		object obj15 = obj13 + obj14;
		object obj16 = obj15 + 312;
		obj3 = obj14;
		goto IL_04f2;
		IL_027d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num2 = unchecked((nint)null);
		goto IL_04f2;
		IL_0328:
		ex3 = new NullReferenceException();
		goto IL_0336;
		IL_0312:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		text2 = text3;
		goto IL_0328;
		IL_0336:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0345;
	}

	private unsafe static string ToHex(byte[] bytes)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I8
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_014c: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_00ad: Expected I4, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		StringBuilder stringBuilder = default;
		if (bytes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			int capacity = bytes.Length << 1;
			stringBuilder._002Ector(capacity);
			if (bytes.Length >= 1)
			{
				object obj2 = bytes.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED90]");
				object obj3 = 0;
				object obj4 = bytes + 32;
				object obj5 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					byte b = (byte)(int)(obj4 + obj5);
					string value = ((byte*)b)->ToString((string)obj3);
					if (stringBuilder != null)
					{
						StringBuilder stringBuilder2 = stringBuilder.Append(value);
						obj2 = bytes.Length;
						obj5++;
						if ((nint)obj5 < bytes.Length)
						{
							continue;
						}
						goto IL_0144;
					}
					goto IL_0176;
				}
				goto IL_0184;
			}
			if (stringBuilder != null)
			{
				goto IL_0144;
			}
		}
		goto IL_0176;
		IL_0144:
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+168]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+170]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v163 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_0176;
		IL_0176:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0184;
		IL_0184:
		return (string)(object)new IndexOutOfRangeException();
	}

	static ShiftAuth()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj4 = (nint)0 + (nint)88;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+A0]");
		object obj6 = (nint)0 + (nint)104;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+A0]");
		object obj8 = 0;
		_ = 0;
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDC0]");
			object buffer = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDB0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDB8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDA8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFF8]");
			object obj13 = 0;
			nint num = (nint)uTF;
			int count = default;
			((System.Security.Cryptography.TailStream)(object)uTF).Write((byte[])buffer, 0, count);
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v15+A0]");
			object obj15 = (nint)0 + (nint)144;
			object obj16 = default;
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj17 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v18+A]");
			_ = 0;
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v19+A0]");
			object obj19 = (nint)0 + (nint)152;
			object obj20 = default;
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj21 = obj11;
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v22+A0]");
			object obj23 = (nint)0 + (nint)160;
			object obj24 = default;
			obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v23+A0]");
			object obj26 = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v25+A0]");
			object obj28 = (nint)0 + (nint)320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, float> dictionary2 = default;
			dictionary2._002Ector();
			object obj29 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v27+A0]");
			object obj30 = (nint)0 + (nint)336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		throw new NullReferenceException();
	}
}
