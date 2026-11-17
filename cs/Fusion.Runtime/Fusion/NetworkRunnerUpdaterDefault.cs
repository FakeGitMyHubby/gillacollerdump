using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using NanoSockets;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.PlayerLoop;

namespace Fusion;

public sealed class NetworkRunnerUpdaterDefault : Action<UnlinkNintendoSwitchDeviceIdResult>
{
	private static class _003C_003EO
	{
		public static TimeUpdate.UpdateFunction _003C0_003E__InvokeUpdate;

		public static TimeUpdate.UpdateFunction _003C1_003E__InvokeRender;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct NetworkRunnerUpdate
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct NetworkRunnerRender
	{
	}

	private class PlayerLoopSystemRegistration : _0021_00210
	{
		public class ConnectRequest
		{
			private NetAddress RemoteAddress__BackingField;

			internal OnConnectionRequestReply? Result;

			public unsafe NetAddress RemoteAddress
			{
				get
				{
					//IL_000a: Expected native int or pointer, but got VT
					//IL_0024: Expected I8, but got I
					//IL_001f: Expected native int or pointer, but got VT
					//IL_0026: Expected VT, but got Obj
					NetAddress netAddress = default;
					((NetAddress*)(nint)netAddress)->NativeAddress = (Address)RemoteAddress__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration+ConnectRequest)+20]");
					((NetAddress*)(nint)netAddress)->Block2 = 0uL;
					return (NetAddress)this;
				}
				set
				{
					_ = value.Block2;
					RemoteAddress__BackingField = (NetAddress)value.NativeAddress;
				}
			}

			public void Accept()
			{
				//IL_001f: Expected VT, but got I4
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
				Result = (OnConnectionRequestReply?)(object)0;
			}

			public void Refuse()
			{
				//IL_001f: Expected VT, but got I4
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1;
				Result = (OnConnectionRequestReply?)(object)0;
			}

			public void Waiting()
			{
				//IL_001f: Expected VT, but got I4
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2;
				Result = (OnConnectionRequestReply?)(object)0;
			}
		}

		public NetworkRunnerUpdaterDefaultInvokeSettings UpdateSettings;

		public NetworkRunnerUpdaterDefaultInvokeSettings RenderSettings;

		public unsafe PlayerLoopSystemRegistration(NetworkRunnerUpdaterDefaultInvokeSettings updateSettings, NetworkRunnerUpdaterDefaultInvokeSettings renderSettings)
		{
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Expected Obj, but got Unknown
			//IL_0542: Expected Obj, but got VT
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Expected Obj, but got Unknown
			//IL_055f: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0047: Expected Obj, but got I4
			//IL_008c: Expected Obj, but got I4
			//IL_04b0: Expected Obj, but got I
			//IL_04b9: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I
			//IL_00cc: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_04f4: Expected Obj, but got I
			//IL_04fd: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I
			//IL_0147: Expected Obj, but got I
			//IL_0167: Expected Obj, but got I4
			//IL_0583: Expected Obj, but got I
			//IL_0593: Expected Obj, but got I
			//IL_05ac: Expected Obj, but got I
			//IL_05ce: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got I
			//IL_0234: Expected VT, but got Obj
			//IL_0250: Expected Obj, but got I
			//IL_0272: Expected Obj, but got I4
			//IL_018a: Expected Obj, but got I
			//IL_019a: Expected Obj, but got I
			//IL_031f: Expected Obj, but got VT
			//IL_0333: Expected Obj, but got I
			//IL_0355: Expected Obj, but got I4
			//IL_01d8: Expected Obj, but got I
			//IL_037b: Expected VT, but got Obj
			//IL_0397: Expected Obj, but got I
			//IL_03a7: Expected Obj, but got I
			//IL_03c9: Expected Obj, but got I4
			//IL_0290: Expected Obj, but got I
			//IL_02aa: Expected Obj, but got I
			//IL_02b8: Expected I, but got Obj
			//IL_01f5: Expected Obj, but got I
			//IL_0474: Expected Obj, but got VT
			//IL_0481: Expected VT, but got Ref
			//IL_02d5: Expected Obj, but got I
			//IL_03e7: Expected Obj, but got I
			//IL_0401: Expected Obj, but got I
			//IL_040f: Expected I, but got Obj
			//IL_0432: Expected Obj, but got I
			object obj = this + 16;
			obj = updateSettings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj2 = this + 32;
			IntPtr intPtr = default;
			obj2 = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X24_v3+E8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ArgumentException ex;
			if ((object)((Type)obj == null) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X24_v3+E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v27+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((object)((Type)obj2 == null) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9+A0]");
					object obj7 = 0;
					object obj8 = obj7;
					bool flag = obj7 == null;
					object obj9 = 0;
					Type type = null;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BC0]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C20]");
						object format = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object arg = default;
						object arg2 = default;
						string text = string.Format((string)format, arg, arg2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v3+10]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X9_v3+1A0]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X9_v3+198] (should have been resolved before IL gen)");
						type = (Type)(object)text;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BF8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C10]");
					object obj13 = 0;
					PlayerLoopSystem currentPlayerLoop = PlayerLoop.GetCurrentPlayerLoop();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X24_v3+E8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v40+E4]");
					bool flag2 = (nint)0 == 0;
					object obj15 = !flag2;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BF0]");
					object obj16 = 0;
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj12);
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v14+A0]");
					object obj18 = 0;
					TimeUpdate.UpdateFunction updateDelegate = (TimeUpdate.UpdateFunction)obj18;
					if ((object)(obj18 != null) == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C18]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C08]");
						TimeUpdate.UpdateFunction updateFunction = default;
						updateFunction._002Ector(null, (IntPtr)(object)0);
						object obj20 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v31+A0]");
						object obj21 = 0;
						obj21 = updateFunction;
						object obj22 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						updateDelegate = updateFunction;
					}
					NetworkRunnerUpdaterDefaultInvokeSettings updateSettings2 = UpdateSettings;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration)+18]");
					PlayerLoopSystem parentSystem = default;
					FusionPlayerLoopSystemHandle fusionPlayerLoopSystemHandle = FusionPlayerLoopSystemUtils.AddToPlayerLoop(ref parentSystem, (Type)updateSettings2, (FusionPlayerLoopSystemAddMode)0, typeFromHandle, updateDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X24_v3+E8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v47+E4]");
					if ((object)((nint)0 != 0) == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj16);
					object obj24 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v18+A0]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v19+8]");
					TimeUpdate.UpdateFunction updateDelegate2 = (TimeUpdate.UpdateFunction)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v19+8]");
					if ((object)((nint)0 != 0) == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C18]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C00]");
						TimeUpdate.UpdateFunction updateFunction2 = default;
						updateFunction2._002Ector(null, (IntPtr)(object)0);
						object obj27 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v26+A0]");
						object obj28 = (nint)0 + (nint)8;
						obj28 = updateFunction2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						updateDelegate2 = updateFunction2;
					}
					NetworkRunnerUpdaterDefaultInvokeSettings renderSettings2 = RenderSettings;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration)+28]");
					FusionPlayerLoopSystemHandle fusionPlayerLoopSystemHandle2 = FusionPlayerLoopSystemUtils.AddToPlayerLoop(ref parentSystem, (Type)renderSettings2, (FusionPlayerLoopSystemAddMode)0, typeFromHandle2, updateDelegate2);
					object obj29 = default;
					PlayerLoop.SetPlayerLoop((PlayerLoopSystem)(&obj29));
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C30]");
				object obj30 = 0;
				object obj31 = 0;
				Type type2 = null;
				ArgumentException ex2 = default;
				ex = ex2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C28]");
				object obj30 = 0;
				object obj31 = 0;
				Type type2 = null;
				ArgumentException ex3 = default;
				ex = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex4 = new ArgumentNullException();
			throw new NullReferenceException();
		}

		public unsafe void Dispose()
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I
			//IL_00fd: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I
			//IL_0126: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I
			//IL_0158: Expected Obj, but got I4
			//IL_0069: Expected VT, but got Obj
			//IL_0025: Expected Obj, but got I
			//IL_008c: Expected VT, but got Obj
			//IL_003a: Expected Obj, but got I
			//IL_00af: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+A0]");
			object obj3 = 0;
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C40]");
				object obj6 = 0;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ X9_v3+198] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BF8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BF0]");
			object obj9 = 0;
			PlayerLoopSystem currentPlayerLoop = PlayerLoop.GetCurrentPlayerLoop();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9+E8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj12 = !flag;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj8);
			PlayerLoopSystem parentSystem = default;
			bool flag2 = FusionPlayerLoopSystemUtils.RemoveFromPlayerLoop(ref parentSystem, typeFromHandle);
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj9);
			bool flag3 = FusionPlayerLoopSystemUtils.RemoveFromPlayerLoop(ref parentSystem, typeFromHandle2);
			object obj13 = default;
			PlayerLoop.SetPlayerLoop((PlayerLoopSystem)(&obj13));
		}
	}

	private static List<NetworkRunner> _instances;

	private static int _instanceCount;

	private static PlayerLoopSystemRegistration _registration;

	public NetworkRunnerUpdaterDefaultInvokeSettings UpdateSettings;

	public NetworkRunnerUpdaterDefaultInvokeSettings RenderSettings;

	private static void ClearStatics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X9_v1+18]");
			Array.Clear((Array)num, 0, 0);
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6+A0]");
			obj4 = 0;
		}
		_ = 4294967295L;
	}

	public static bool RegisterInPlayerLoop(NetworkRunnerUpdaterDefaultInvokeSettings updateSettings, NetworkRunnerUpdaterDefaultInvokeSettings renderSettings)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I
		//IL_00d3: Expected VT, but got I
		//IL_0103: Expected VT, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_045c: Expected I4, but got Obj
		//IL_0260: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I
		//IL_0180: Expected VT, but got I
		//IL_018d: Expected VT, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_01bb: Expected VT, but got I
		//IL_01cb: Expected VT, but got I
		//IL_0295: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			object obj6 = 0;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v36+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v37+10]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v37+10]");
				if ((nint)0 == 0)
				{
					goto IL_044e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+10]");
			NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings = (NetworkRunnerUpdaterDefaultInvokeSettings)0;
			NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings2 = default;
			bool flag3 = networkRunnerUpdaterDefaultInvokeSettings2.Equals(updateSettings);
			bool flag4 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+10]");
			networkRunnerUpdaterDefaultInvokeSettings2 = (NetworkRunnerUpdaterDefaultInvokeSettings)0;
			NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings3 = renderSettings;
			NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings4 = updateSettings;
			if (!flag4)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v42+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v42+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v34+10]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v34+10]");
				if ((nint)0 == 0)
				{
					goto IL_044e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v35+20]");
				networkRunnerUpdaterDefaultInvokeSettings = (NetworkRunnerUpdaterDefaultInvokeSettings)0;
				IntPtr intPtr = default;
				bool flag6 = networkRunnerUpdaterDefaultInvokeSettings2.Equals((NetworkRunnerUpdaterDefaultInvokeSettings)(nint)intPtr);
				bool flag7 = !flag6;
				object obj13 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v35+20]");
				networkRunnerUpdaterDefaultInvokeSettings2 = (NetworkRunnerUpdaterDefaultInvokeSettings)0;
				NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings5 = default;
				networkRunnerUpdaterDefaultInvokeSettings3 = networkRunnerUpdaterDefaultInvokeSettings5;
				networkRunnerUpdaterDefaultInvokeSettings4 = (NetworkRunnerUpdaterDefaultInvokeSettings)(nint)intPtr;
				if (obj13 != null)
				{
					goto IL_0432;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v15+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v16+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v16+10]");
			if ((nint)0 != 0)
			{
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v22+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v22+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v18+10]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v18+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BC0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BE0]");
					object format = 0;
					object arg = default;
					object arg2 = default;
					string text = string.Format((string)format, arg, arg2);
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v23+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v24+10]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v24+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BE8]");
						object format2 = 0;
						object arg3 = default;
						object arg4 = default;
						string text2 = string.Format((string)format2, arg3, arg4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BD8]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BD0]");
						object obj27 = 0;
						string text3 = (string)obj26 + text + text2 + (string)obj27;
						object obj28 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X8_v32+198] (should have been resolved before IL gen)");
						goto IL_0432;
					}
				}
				goto IL_044e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9BC8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			PlayerLoopSystemRegistration playerLoopSystemRegistration = default;
			playerLoopSystemRegistration._002Ector(updateSettings, renderSettings);
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v9+A0]");
			object obj32 = (nint)0 + (nint)16;
			obj32 = playerLoopSystemRegistration;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		goto IL_0432;
		IL_0432:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
		return (nint)0 == 0;
		IL_044e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool UnregisterFromPlayerLoop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_0117: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
		object obj = 0;
		PlayerLoopSystemRegistration playerLoopSystemRegistration = (PlayerLoopSystemRegistration)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			playerLoopSystemRegistration = (PlayerLoopSystemRegistration)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration)+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6 (Fusion.NetworkRunnerUpdaterDefault+PlayerLoopSystemRegistration)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v9+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v10+10]");
				if ((nint)0 == 0)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			playerLoopSystemRegistration.Dispose();
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+A0]");
			object obj8 = (nint)0 + (nint)16;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		return !flag3;
	}

	private void Fusion_002EINetworkRunnerUpdater_002EInitialize(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_0077: Expected VT, but got I
		//IL_0093: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj3 = 0;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C48]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X9_v7+188] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkRunnerUpdaterDefaultInvokeSettings updateSettings = UpdateSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkRunnerUpdaterDefault)+18]");
		bool flag2 = RegisterInPlayerLoop(updateSettings, (NetworkRunnerUpdaterDefaultInvokeSettings)0);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+A0]");
		object obj12 = 0;
		List<System.__Canon> list = (List<System.__Canon>)obj12;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag3 = list._size < items.Length;
		object obj13 = !flag3;
		NetworkRunner networkRunner = default;
		if (obj13 == null)
		{
			object obj14 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj15 = obj14 + 32;
			obj15 = networkRunner;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)networkRunner);
		}
	}

	private void Fusion_002EINetworkRunnerUpdater_002EShutdown(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0067: Expected I4, but got I8
		//IL_0081: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I8
		//IL_03bc: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_044f: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C50]");
		object obj5 = 0;
		object obj6 = obj5;
		int num = ((List<System.__Canon>)obj4).IndexOf((System.__Canon)(object)runner);
		int num2 = (int)(num & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X9_v2+A0]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v15+8]");
		object obj15 = 0 & 0x80000000L;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			bool flag5 = obj13 == null;
			System.__Canon _Canon = (System.__Canon)(object)runner;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj18 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v30+A0]");
					obj12 = 0;
				}
				System.__Canon _Canon2 = ((List<System.__Canon>)obj12).get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X21_v6+10]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C70]");
				object obj20 = 0;
				object obj21 = obj19;
				obj6 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v6+190]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ X10_v6+188] (should have been resolved before IL gen)");
				obj8 = obj;
				_Canon = _Canon2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+A0]");
			object obj24 = 0;
			((List<System.__Canon>)obj24).set_Item(num, (System.__Canon)null);
			return;
		}
		bool flag8 = obj13 == null;
		System.__Canon _Canon3 = (System.__Canon)(object)runner;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v19+A0]");
				obj12 = 0;
			}
			System.__Canon _Canon4 = ((List<System.__Canon>)obj12).get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X21_v6+10]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C78]");
			object obj28 = 0;
			object obj29 = obj27;
			obj6 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X10_v4+190]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ X10_v4+188] (should have been resolved before IL gen)");
			obj8 = obj;
			_Canon3 = _Canon4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+A0]");
		object obj31 = 0;
		((List<System.__Canon>)obj31).RemoveAt(num);
	}

	private static void InvokeUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
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
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
		object obj9 = (nint)0 >> 31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v19+A0]");
		object obj11 = 0;
		object obj12 = obj11;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+18]");
			_ = 0;
			int num = 0;
			NotImplementedException ex = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v19+A0]");
				object obj16 = 0;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v11+8]");
				if ((nint)num2 >= (nint)0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj18 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v18+A0]");
					obj16 = 0;
				}
				if (obj16 == null)
				{
					break;
				}
				obj8 = obj13;
				System.__Canon _Canon = ((List<System.__Canon>)obj16).get_Item(num);
				object obj19 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v24+E4]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = (UnityEngine.Object)(object)_Canon;
				bool flag6 = !flag5;
				obj7 = 0;
				if (!flag6)
				{
					bool flag7 = _Canon == null;
					obj7 = 0;
					if (flag7)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v22 (System.__Canon)+58]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v22 (System.__Canon)+58]");
					bool flag8 = (nint)0 == 0;
					obj7 = 0;
					if (flag8)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v15+60]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v15+60]");
					bool flag9 = (nint)0 == 0;
					obj7 = 0;
					if (flag9)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v16+28]");
					float num3;
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v16+28]");
						bool flag10 = (nint)0 == 0;
						object obj23 = !flag10;
						obj7 = 0;
						if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							ex._002Ector();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							throw new ArgumentNullException();
						}
						num3 = Time.unscaledDeltaTime;
					}
					else
					{
						num3 = Time.deltaTime;
					}
					((NetworkRunner)(object)_Canon).UpdateInternal((double)num3);
					obj7 = 0;
				}
				obj10 = obj;
				num++;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static void InvokeRender()
	{
		//IL_0010: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I
		//IL_045d: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_0120: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_038b: Expected Obj, but got Ref
		//IL_0179: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_026c: Expected Obj, but got Ref
		//IL_03e0: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CB8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
		object obj6 = 0;
		string text = (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
		object obj8 = ~(nint)0;
		object obj9 = obj8 >> 31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+A0]");
		object obj11 = 0;
		object obj12 = obj11;
		if (obj11 == null)
		{
			goto IL_0271;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CB0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9C60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v1+18]");
		object obj15 = num - 0;
		bool flag2 = (nint)obj15 < 0;
		bool flag3 = obj15 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v1+18]");
		object obj16 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+8]");
		object obj17 = 0 ^ obj15;
		object obj18 = obj16 & obj17;
		bool flag4 = (nint)obj18 < 0;
		text = (string)obj13;
		bool flag5 = flag2 == flag4;
		object obj19 = !flag5;
		bool condition = (byte)((obj19 | flag3) ? 1 : 0) != 0;
		Assert.Check(condition, (string)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj20 = 0;
		object obj21 = 0;
		obj7 = 0;
		int num3 = 0;
		while (true)
		{
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v24+A0]");
			object obj24 = 0;
			int num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v19+8]");
			bool flag7 = (nint)num4 >= (nint)0;
			object obj25 = (object)(&obj21);
			if (flag7)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v24+E4]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v23+A0]");
				obj24 = 0;
			}
			if (obj24 != null)
			{
				obj7 = obj14;
				System.__Canon _Canon = ((List<System.__Canon>)obj24).get_Item(num3);
				object obj28 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v32+E4]");
				bool flag9 = (nint)0 == 0;
				object obj29 = !flag9;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(UnityEngine.Object)(object)_Canon)
				{
					obj21 = 1;
					text = null;
					goto IL_03ee;
				}
				bool flag10 = _Canon == null;
				text = null;
				if (!flag10)
				{
					((NetworkRunner)(object)_Canon).RenderInternal();
					text = null;
					goto IL_03ee;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj25 = (object)(&obj21);
			goto IL_0271;
			IL_03ee:
			num3++;
		}
		goto IL_02f6;
		IL_02f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AD714");
		return;
		IL_0271:
		NullReferenceException ex3 = new NullReferenceException();
		if ((nint)text == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		else
		{
			if ((nint)text != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AD714");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		goto IL_02f6;
	}

	public NetworkRunnerUpdaterDefault()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0068: Expected VT, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9CC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v4+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = this + 16;
		NetworkRunnerUpdaterDefaultInvokeSettings networkRunnerUpdaterDefaultInvokeSettings = default;
		UpdateSettings = networkRunnerUpdaterDefaultInvokeSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = this + 32;
		RenderSettings = networkRunnerUpdaterDefaultInvokeSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static NetworkRunnerUpdaterDefault()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D83F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7738]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+A0]");
		object obj7 = 0;
		_ = 4294967295L;
	}
}
