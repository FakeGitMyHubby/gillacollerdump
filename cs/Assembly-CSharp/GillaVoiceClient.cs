using System;
using System.Collections;
using Cpp2ILInjected;
using Fusion;
using Photon.Realtime;
using Photon.Voice;
using Photon.Voice.Fusion;
using Photon.Voice.Unity;
using UnityEngine;

public class GillaVoiceClient : FusionVoiceClient
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Dismemberment.Part> _003C_003E9__36_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA158]");
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

		internal bool _003CFindBody_003Eb__36_0(Dismemberment.Part p)
		{
			//IL_00aa: Expected I4, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			if (p != null)
			{
				if (p.id != 0)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return p.renderer != null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string got;

		internal void _003CFetching_003Eb__0(bool ok, string fresh)
		{
			//IL_001a: Expected Obj, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			bool flag = !ok;
			object obj = !flag;
			object obj2 = ~obj;
			string text = ((obj2 != null) ? null : fresh);
			object obj3 = this + 16;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private const float RetryFirst = default(float);

	private const float RetryMost = default(float);

	private static GillaVoiceClient Current__BackingField;

	private string ticket;

	private bool fetching;

	private float retryWait;

	private float nextRetry;

	private NetworkRunner game;

	private bool warned;

	public static GillaVoiceClient Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA230]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			return (GillaVoiceClient)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA230]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	protected override void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected I4, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA238]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj2 = 0;
		base.Awake();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		NetworkRunner networkRunner = default;
		game = networkRunner;
		object obj3 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool shiftAuthNeeded = NetworkBootstrap.ShiftAuthNeeded;
		object obj6 = !shiftAuthNeeded;
		bool useFusionAuthValues = (byte)(1 & obj6) != 0;
		UseFusionAuthValues = useFusionAuthValues;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA230]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X9_v2+A0]");
		object obj9 = 0;
		obj9 = this;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	protected override void OnDestroy()
	{
		//IL_005b: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA230]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v10+A0]");
			object obj8 = 0;
			obj8 = 0;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		base.OnDestroy();
	}

	protected override bool ConnectVoice()
	{
		//IL_0138: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_0122: Expected I4, but got Obj
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		bool flag = (byte)(~(UseFusionAuthValues ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			if (string.IsNullOrEmpty(ticket))
			{
				Fetch();
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AuthenticationValues authenticationValues = NetworkBootstrap.TicketAuth(ticket);
			if (((VoiceConnection)this).client == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object obj5 = ((VoiceConnection)this).client + 64;
			obj5 = authenticationValues;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = this + 256;
			ticket = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		return base.ConnectVoice();
	}

	private void Fetch()
	{
		//IL_0016: Expected Obj, but got I4
		bool flag = (byte)(~(fetching ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null && isActiveAndEnabled)
		{
			IEnumerator routine = Fetching();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator Fetching()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA240]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private void Later()
	{
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + retryWait;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		nextRetry = num;
		retryWait = 60f;
	}

	protected override void Update()
	{
		//IL_023e: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		base.Update();
		bool flag = (byte)(~(UseFusionAuthValues ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		bool flag2 = (byte)(~(fetching ? 1u : 0u)) != 0;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		if (unscaledTime < nextRetry)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)game == (UnityEngine.Object)null;
		bool flag5 = !flag4;
		object obj6 = !flag5;
		if (obj6 != null || !game.IsRunning)
		{
			return;
		}
		NetworkRunner networkRunner = game;
		SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
		if (~(sessionInfo._isValid ? 1u : 0u) != 0)
		{
			return;
		}
		ClientState clientState = ClientState;
		if (clientState != (ClientState)14 && ClientState != 0)
		{
			retryWait = 5f;
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		float num = unscaledTime2 + retryWait;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		nextRetry = num;
		retryWait = 60f;
		if (string.IsNullOrEmpty(ticket))
		{
			Fetch();
		}
		else
		{
			bool flag6 = ConnectAndJoinRoom();
		}
	}

	protected override bool JoinVoiceRoom(string voiceRoomName)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_0156: Expected I4, but got Obj
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		if (string.IsNullOrEmpty(voiceRoomName))
		{
			return base.JoinVoiceRoom(voiceRoomName);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA248]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA250]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EnterRoomArgs enterRoomArgs = default;
		enterRoomArgs._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RoomOptions roomOptions = default;
		roomOptions._002Ector();
		if (roomOptions != null)
		{
			roomOptions.isVisible = false;
			roomOptions.PlayerTtl = 2000;
			roomOptions.PublishUserId__BackingField = true;
			if (enterRoomArgs != null)
			{
				object obj3 = enterRoomArgs + 24;
				obj3 = roomOptions;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = enterRoomArgs + 16;
				obj4 = voiceRoomName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (((VoiceConnection)this).client != null)
				{
					return ((VoiceConnection)this).client.OpJoinOrCreateRoom(enterRoomArgs);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	protected unsafe override Speaker InstantiateSpeakerForRemoteVoice(int playerId, byte voiceId, object userData)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_0172: Expected VT, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I4
		if (userData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj = 0;
			object obj2 = obj;
			if (userData == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [userData @ X3 (System.Object)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)game != (UnityEngine.Object)null)
					{
						if ((object)game != null)
						{
							NetworkRunner networkRunner = game;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [userData @ X3 (System.Object)+10]");
							NetworkObject networkObject = networkRunner.FindObject((NetworkId)0);
							object obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v10+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!((UnityEngine.Object)networkObject != (UnityEngine.Object)null))
							{
								goto IL_0039;
							}
							if ((object)networkObject != null)
							{
								int* ptr = networkObject.Ptr;
								PlayerRef none = default;
								if (networkObject.Ptr != null)
								{
									NetworkRunner runner = networkObject._runner;
									if ((object)networkObject._runner == null || (object)runner._simulation == null)
									{
										goto IL_0416;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj9 = 0;
									object obj10 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v34+E4]");
									bool flag4 = (nint)0 == 0;
									object obj11 = !flag4;
									if (obj11 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									none = PlayerRef.None;
								}
								if ((object)game != null)
								{
									string playerUserId = game.GetPlayerUserId(none);
									bool flag5 = VoiceFrom(playerId, playerUserId);
									bool flag6 = !flag5;
									object obj12 = !flag6;
									if (obj12 == null)
									{
										bool flag7 = (byte)(~(warned ? 1u : 0u)) != 0;
										object obj13 = !flag7;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
											object obj14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA258]");
											object format = 0;
											object arg = default;
											string message = string.Format((string)format, arg);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
											object obj15 = 0;
											object obj16 = obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v25+E4]");
											bool flag8 = (nint)0 == 0;
											object obj17 = !flag8;
											if (obj17 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Debug.LogWarning(message);
										}
										warned = true;
										return null;
									}
									goto IL_0039;
								}
							}
						}
						goto IL_0416;
					}
				}
			}
		}
		goto IL_0039;
		IL_0416:
		return (Speaker)(object)new NullReferenceException();
		IL_0039:
		return base.InstantiateSpeakerForRemoteVoice(playerId, voiceId, userData);
	}

	private bool VoiceFrom(int voicePlayer, string user)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(user);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			goto IL_00ca;
		}
		Realtime5Transport realtime5Transport = ((VoiceConnection)this).client;
		string text;
		if (((VoiceConnection)this).client != null && ((RealtimeClient)realtime5Transport).CurrentRoom__BackingField != null)
		{
			((object)((RealtimeClient)realtime5Transport).CurrentRoom__BackingField).Finalize();
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v12+28]");
				text = (string)0;
				goto IL_00eb;
			}
		}
		text = null;
		goto IL_00eb;
		IL_00eb:
		if (!string.IsNullOrEmpty(text))
		{
			return string.Equals(text, user, (StringComparison)5);
		}
		goto IL_00ca;
		IL_00ca:
		return true;
	}

	public static bool Theirs(Speaker speaker, string user)
	{
		//IL_019d: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_018d: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA230]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = speaker == null;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				if ((object)speaker == null)
				{
					goto IL_017f;
				}
				if (speaker.IsLinked)
				{
					RemoteVoiceLink remoteVoiceLink = speaker.RemoteVoice__BackingField;
					if (speaker.RemoteVoice__BackingField != null)
					{
						if (obj5 != null)
						{
							return ((GillaVoiceClient)obj5).VoiceFrom(remoteVoiceLink.PlayerId, user);
						}
						goto IL_017f;
					}
				}
			}
		}
		return true;
		IL_017f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public GillaVoiceClient()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA260]");
		object obj = 0;
		retryWait = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector();
	}
}
