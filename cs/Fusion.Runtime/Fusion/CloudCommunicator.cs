using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Fusion.Matchmaking;
using Fusion.Photon.Realtime;
using Fusion.Protocol;
using Photon.Client;
using Photon.Realtime;
using PlayFab.ClientModels;

namespace Fusion;

internal class CloudCommunicator : Fusion.Protocol.CommunicatorBase, _0021_00210, Action<GetPlayerTradesResponse>
{
	private RealtimeClient Client__BackingField;

	private bool WasExtracted__BackingField;

	private readonly byte[] _buffer;

	public RealtimeClient Client
	{
		get
		{
			return Client__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public override int CommunicatorID
	{
		get
		{
			//IL_006c: Expected I4, but got I8
			//IL_007a: Expected I4, but got Obj
			RealtimeClient realtimeClient = Client__BackingField;
			if (Client__BackingField != null)
			{
				Player localPlayer = realtimeClient.LocalPlayer;
				if (realtimeClient.LocalPlayer != null)
				{
					return localPlayer.actorNumber;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return -1;
		}
	}

	public bool WasExtracted
	{
		get
		{
			return WasExtracted__BackingField;
		}
		set
		{
			WasExtracted__BackingField = value;
		}
	}

	public CloudCommunicator(RealtimeClient realtimeClient = null, FusionAppSettings appSettings = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 72;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		object obj5 = realtimeClient != null;
		FusionAppSettings fusionAppSettings = appSettings;
		ConnectionProtocol connectionProtocol = (ConnectionProtocol)0;
		RealtimeClient client = realtimeClient;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3008]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			RealtimeClient realtimeClient2 = default;
			realtimeClient2._002Ector((ConnectionProtocol)0);
			fusionAppSettings = null;
			connectionProtocol = (ConnectionProtocol)0;
			client = realtimeClient2;
		}
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RealtimeClient realtimeClient3 = RealtimeClientExtensions.SetupForFusion(client, appSettings);
		object obj8 = this + 56;
		obj8 = realtimeClient3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((RealtimeClient)obj8).AddCallbackTarget((object)this);
	}

	public override void Service()
	{
		if (Client__BackingField != null)
		{
			Client__BackingField.Service();
			base.Service();
		}
	}

	public unsafe override bool SendPackage(byte code, int targetActor, bool reliable, byte* buffer, int bufferLength)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if (Client__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D49C0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return RealtimeClientExtensions.SendEvent(Client__BackingField, targetActor, code, buffer, bufferLength, reliable);
		}
		return false;
	}

	protected unsafe override void ConvertData(object data, out byte[] dataBuffer, out int maxLength)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I
		ref byte[] reference = ref *(byte[]*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ref int reference2 = ref *(int*)4294967295L;
		if (data == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F28]");
		object obj = 0;
		nint num = (nint)data;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v2 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v2 (Il2CppClass<System.Object>)+B0]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7+130]");
		object obj5 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v4-8]");
		if (0 == (nint)obj2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
			if ((nint)0 >= (nint)1)
			{
				byte[] buffer = _buffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F30]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F20]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
				object obj8 = -buffer.Length;
				bool flag2 = (nint)obj8 < 0;
				bool flag3 = obj8 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
				object obj9 = (nint)0 ^ (nint)buffer.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
				object obj10 = 0 ^ obj8;
				object obj11 = obj9 & obj10;
				bool flag4 = (nint)obj11 < 0;
				bool flag5 = flag2 == flag4;
				object obj12 = !flag5;
				object obj13 = obj12 | flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F5FB4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
				reference2 = ref *(int*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+10]");
				nint num4 = 0;
				byte[] buffer2 = _buffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Object)+1C]");
				Array.Copy((Array)num4, buffer2, 0);
				reference = ref *(byte[]*)_buffer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag6 = ((ByteArraySlice)data).Release();
			}
		}
	}

	public void Reset()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4116A60");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4116A60");
		((Dictionary<System.__Canon, System.__Canon>)(object)Callbacks).Clear();
	}

	public void OnEvent(EventData evt)
	{
		int sender = evt.Sender;
		object customData = evt.CustomData;
		PushPackage(sender, evt.Code, customData);
	}

	public void Dispose()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		if (~(WasExtracted__BackingField ? 1u : 0u) != 0)
		{
			object obj = this + 56;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}
}
