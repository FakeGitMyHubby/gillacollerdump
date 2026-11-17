using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;

namespace Fusion;

[Serializable]
public class NetworkProjectConfig : Action<UnlinkIOSDeviceIDResult>
{
	[Serializable]
	public class ObjectPlayerEvent : UnityEvent<NetworkRunner, NetworkObject, PlayerRef>
	{
		public ObjectPlayerEvent()
		{
			((UnityEvent<System.__Canon, System.__Canon, PlayerRef>)(object)this)._002Ector();
		}
	}

	public enum PeerModes
	{
		// error: enumerator has no value
		Single,
		// error: enumerator has no value
		Multiple
	}

	public enum ReplicationFeatures
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		InterestManagement
	}

	public enum FusionHubMode
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		Beginner,
		// error: enumerator has no value
		Advanced
	}

	public const string DefaultResourceName = null;

	public const string CurrentTypeId = null;

	public const int CurrentVersion = default(int);

	public int Version;

	public string TypeId;

	public FusionHubMode HubMode;

	public PeerModes PeerMode;

	public LagCompensationSettings LagCompensation;

	public bool PhysicsForecast;

	[NonSerialized]
	public bool DoNotSetForecastDisabledProxyRigidbodiesToKinematic;

	public bool EnqueueIncompleteSynchronousSpawns;

	public NetworkProjectConfigAsset.InvokeRenderModes InvokeRenderMode;

	public bool NetworkIdIsObjectName;

	public bool HideNetworkObjectInactivityGuard;

	public bool AllowClientServerModesInWebGL;

	public bool AllowMasterClientReassignRequest;

	public float MasterClientRequestReassignThreshold;

	public bool ClientsRecordFrameAndPacketTimingTraces;

	public bool ClientsOnlyRollbackUpdatedObjects;

	[NonSerialized]
	public NetworkPrefabTable PrefabTable;

	public SimulationConfig Simulation;

	public TimeSyncConfiguration TimeSync;

	public NetworkConfiguration Network;

	public HostMigrationConfig HostMigration;

	public EncryptionConfig EncryptionConfig;

	public NetworkSimulationConfiguration NetworkConditions;

	public HeapConfiguration Heap;

	public string[] AssembliesToWeave;

	public bool UseSerializableDictionary;

	public bool NullChecksForNetworkedProperties;

	public bool CheckRpcAttributeUsage;

	public bool CheckNetworkedPropertiesBeingEmpty;

	[NonSerialized]
	internal readonly Dictionary<Type, int> ExecutionOrderOverrides;

	public static NetworkProjectConfig Global
	{
		get
		{
			NetworkProjectConfigAsset global = NetworkProjectConfigAsset.Global;
			if ((object)global != null)
			{
				return global.Config;
			}
			return (NetworkProjectConfig)(object)new NullReferenceException();
		}
	}

	public bool InvokeRenderInBatchMode
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I4
			//IL_0033: Expected I4, but got Obj
			object obj = InvokeRenderMode - 1;
			bool flag = (nint)obj < 2;
			object obj2 = !flag;
			return (byte)(int)(~obj2) != 0;
		}
	}

	public unsafe static (NetworkRunner.BuildTypes, FileVersionInfo) FusionVersionInfo
	{
		get
		{
			//IL_023f: Expected VT, but got Obj
			//IL_0039: Expected Obj, but got I4
			//IL_0162: Expected VT, but got I4
			//IL_0174: Expected I4, but got I8
			//IL_017c: Expected VT, but got Ref
			//IL_0298: Expected native int or pointer, but got VT
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_0077: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			//IL_027e: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I
			//IL_0114: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I
			//IL_01bb: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got I4
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected Obj, but got Unknown
			//IL_021e: Expected VT, but got Ref
			AppDomain currentDomain = AppDomain.CurrentDomain;
			object obj5;
			if (currentDomain != null)
			{
				Assembly[] assemblies = currentDomain.GetAssemblies();
				if (assemblies != null)
				{
					object obj = assemblies.Length;
					if (assemblies.Length < 1)
					{
						goto IL_0158;
					}
					object obj2 = assemblies + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9940]");
					object value = 0;
					object obj3 = 0;
					string text = default;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj4 = !flag;
						if (obj4 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X24_v6+v63 @ X22_v7*8]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X24_v6+v63 @ X22_v7*8]");
						if ((nint)0 != 0)
						{
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ X8_v9+1D8] (should have been resolved before IL gen)");
							if (text != null)
							{
								bool flag2 = text.StartsWith((string)value);
								bool flag3 = !flag2;
								object obj7 = !flag3;
								if (obj7 == null)
								{
									obj = assemblies.Length;
									obj3++;
									if ((nint)obj3 < assemblies.Length)
									{
										continue;
									}
									goto IL_0158;
								}
								goto IL_0181;
							}
						}
						goto IL_0223;
					}
					goto IL_0231;
				}
			}
			goto IL_0223;
			IL_0158:
			(NetworkRunner.BuildTypes, FileVersionInfo) result = ((NetworkRunner.BuildTypes, FileVersionInfo))0;
			System.__Canon item = null;
			Unity.IL2CPP.Metadata.__Il2CppInt32Enum item2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)(-1);
			(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon))(&result);
			goto IL_028c;
			IL_0223:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0231;
			IL_0231:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return ((NetworkRunner.BuildTypes, FileVersionInfo))ex2;
			IL_0181:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkRunner.BuildTypes buildType = NetworkRunner.BuildType;
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X8_v13+1F8] (should have been resolved before IL gen)");
			string fileName = default;
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fileName);
			item = (System.__Canon)(object)versionInfo;
			item2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)buildType;
			tuple = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon))(&result);
			goto IL_028c;
			IL_028c:
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (item2, item));
			return result;
		}
	}

	public static void UnloadGlobal()
	{
		NetworkProjectConfigAsset.UnloadGlobal();
	}

	public unsafe int? GetExecutionOrder(Type type)
	{
		//IL_01b7: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got Ref
		//IL_0201: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_00b9: Expected VT, but got I
		//IL_01ec: Expected VT, but got I4
		//IL_018e: Expected VT, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0150: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		if ((object)ExecutionOrderOverrides != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9928]");
			object obj = 0;
			int value2;
			if (((Dictionary<System.__Canon, int>)(object)ExecutionOrderOverrides).TryGetValue((System.__Canon)(object)type, out int value))
			{
				value2 = value;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9920]");
				object obj3 = 0;
				System.__Canon _Canon = (System.__Canon)(object)type;
				object obj4 = (object)(&value);
				Type type2 = type;
				object obj7 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v7+E8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v7+10]");
					RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
					Type typeFromHandle = Type.GetTypeFromHandle(handle);
					if (type2 != typeFromHandle)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
						bool flag2 = obj7 == null;
						object obj8 = !flag2;
						if (obj8 != null)
						{
							break;
						}
						if ((object)type2 != null)
						{
							nint num = (nint)type2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v12 (Il2CppClass<System.Type>)+870]");
							_Canon = (System.__Canon)0;
							Type type3 = (Type)((object)type2).Equals((object)0);
							obj4 = 0;
							type2 = type3;
							continue;
						}
						goto IL_01a9;
					}
					return (int?)(object)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v19+10]");
				value2 = 0;
			}
			int? num2 = value2;
			return (int?)(object)0;
		}
		goto IL_01a9;
		IL_01a9:
		NullReferenceException ex = new NullReferenceException();
		return (int?)(object)ex;
	}

	internal NetworkProjectConfig Init(int globalSize, int? playerCountOverride, int? inputWordCount)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		NetworkProjectConfig networkProjectConfig = Copy();
		if ((object)networkProjectConfig != null)
		{
			object obj = networkProjectConfig + 128;
			if (obj != null)
			{
				HeapConfiguration heap = ((HeapConfiguration)obj).Init(globalSize);
				networkProjectConfig.Heap = heap;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj2 = networkProjectConfig + 96;
				if (obj2 != null)
				{
					NetworkConfiguration network = ((NetworkConfiguration)obj2).Init();
					networkProjectConfig.Network = network;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj3 = networkProjectConfig + 80;
					if (obj3 != null)
					{
						SimulationConfig simulation = ((SimulationConfig)obj3).Init(playerCountOverride, inputWordCount);
						networkProjectConfig.Simulation = simulation;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return networkProjectConfig;
					}
				}
			}
		}
		return (NetworkProjectConfig)(object)new NullReferenceException();
	}

	internal NetworkProjectConfig Copy()
	{
		//IL_0132: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		object obj = MemberwiseClone();
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9930]");
			object obj2 = 0;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v8 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X1_v6+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v8 (Il2CppClass<System.Object>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X1_v6+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v11-8]");
				if (0 == (nint)obj3)
				{
					if (Simulation != null)
					{
						SimulationConfig simulationConfig = Simulation.Copy();
						object obj7 = obj + 80;
						obj7 = simulationConfig;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return (NetworkProjectConfig)obj;
					}
					goto IL_0140;
				}
			}
			throw new InvalidCastException();
		}
		SimulationConfig simulationConfig2 = Simulation;
		bool flag2 = Simulation == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			goto IL_0140;
		}
		goto IL_0156;
		IL_0156:
		SimulationConfig simulationConfig3 = simulationConfig2.Copy();
		return (NetworkProjectConfig)(object)new NullReferenceException();
		IL_0140:
		NullReferenceException ex = new NullReferenceException();
		simulationConfig2 = (SimulationConfig)(object)ex;
		goto IL_0156;
	}

	public void SanityCheck()
	{
		Simulation.SanityCheck();
		TimeSync.SanityCheck();
		Network.SanityCheck();
		Heap.SanityCheck();
		NetworkConditions.SanityCheck();
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this);
	}

	public static string Serialize(NetworkProjectConfig config)
	{
		return JsonUtility.ToJson(config);
	}

	public static NetworkProjectConfig Deserialize(string data)
	{
		return (NetworkProjectConfig)(object)JsonUtility.FromJson<System.__Canon>(data);
	}

	internal static string SerializeMinimal(NetworkProjectConfig config)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4198]");
		object obj = 0;
		string baseJson = JsonUtility.ToJson(config);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Fusion.JsonUtils.RemoveExtraReferences(baseJson);
	}

	public NetworkProjectConfig()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I8
		//IL_037b: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9950]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9958]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9960]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9968]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9970]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9978]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9980]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9988]");
		object obj9 = 0;
		Version = 1;
		object obj10 = this + 24;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		HubMode = (FusionHubMode)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		LagCompensationSettings lagCompensationSettings = default;
		lagCompensationSettings._002Ector();
		object obj11 = this + 40;
		obj11 = lagCompensationSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PhysicsForecast = false;
		InvokeRenderMode = (NetworkProjectConfigAsset.InvokeRenderModes)1;
		HideNetworkObjectInactivityGuard = false;
		AllowMasterClientReassignRequest = false;
		MasterClientRequestReassignThreshold = 2f;
		ClientsRecordFrameAndPacketTimingTraces = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkPrefabTable networkPrefabTable = default;
		networkPrefabTable._002Ector();
		object obj12 = this + 72;
		obj12 = networkPrefabTable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SimulationConfig simulationConfig = default;
		simulationConfig._002Ector();
		object obj13 = this + 80;
		obj13 = simulationConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		TimeSyncConfiguration timeSyncConfiguration = default;
		timeSyncConfiguration._002Ector();
		object obj14 = this + 88;
		obj14 = timeSyncConfiguration;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkConfiguration networkConfiguration = default;
		networkConfiguration._002Ector();
		object obj15 = this + 96;
		obj15 = networkConfiguration;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HostMigrationConfig hostMigrationConfig = default;
		hostMigrationConfig._002Ector();
		object obj16 = this + 104;
		obj16 = hostMigrationConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		EncryptionConfig encryptionConfig = default;
		encryptionConfig._002Ector();
		object obj17 = this + 112;
		obj17 = encryptionConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkSimulationConfiguration networkSimulationConfiguration = default;
		networkSimulationConfiguration._002Ector();
		object obj18 = this + 120;
		obj18 = networkSimulationConfiguration;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HeapConfiguration heapConfiguration = default;
		heapConfiguration._002Ector();
		object obj20 = this + 128;
		obj20 = heapConfiguration;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v51+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99B0]");
			object obj22 = 0;
			object obj24 = default;
			object obj23 = obj24 + 32;
			obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v6-8]");
			if ((object)(0 & 0xFFFFFFFEL) != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99A8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9998]");
				object obj26 = 0;
				object obj27 = obj24 + 40;
				obj27 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj28 = this + 136;
				obj28 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BB58]");
				UseSerializableDictionary = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Dictionary<System.__Canon, int> dictionary = default;
				dictionary._002Ector();
				object obj29 = this + 152;
				obj29 = dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
