using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;

namespace Fusion.Statistics;

public class FusionStatisticsManager
{
	private readonly FusionMemoryStatisticsSnapshot _memorySnapshot;

	private HashSet<NetworkId> _monitoredIds;

	private FusionStatisticsSnapshot _currentSimulationSnapshot;

	private FusionStatisticsSnapshot _previousSimulationSnapshot;

	private NetworkObjectStatisticsSnapshot _previousObjectSnapshot;

	private NetworkObjectStatisticsSnapshot _currentObjectSnapshot;

	private Simulation _simulation;

	public FusionStatisticsSnapshot SimulationSnapshot => _previousSimulationSnapshot;

	public NetworkObjectStatisticsSnapshot ObjectSnapshot => _previousObjectSnapshot;

	public LagCompensationStatisticsSnapshot LagCompensationSnapshot
	{
		get
		{
			Simulation simulation = _simulation;
			if ((object)_simulation != null)
			{
				if ((object)simulation.Runner == null)
				{
					return (LagCompensationStatisticsSnapshot)(object)new NullReferenceException();
				}
				HitboxManager lagCompensation = simulation.Runner.LagCompensation;
				if ((object)lagCompensation != null)
				{
					return lagCompensation.LagCompensationSnapshot;
				}
			}
			return null;
		}
	}

	public FusionMemoryStatisticsSnapshot MemorySnapshot
	{
		get
		{
			if (_memorySnapshot != null)
			{
				_memorySnapshot.CollectData(_simulation);
				return _memorySnapshot;
			}
			return (FusionMemoryStatisticsSnapshot)(object)new NullReferenceException();
		}
	}

	internal FusionStatisticsManager(Simulation simulation)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6710]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6718]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6720]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6728]");
		object obj4 = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		FusionStatisticsSnapshot fusionStatisticsSnapshot = default;
		fusionStatisticsSnapshot._002Ector();
		object obj5 = this + 32;
		obj5 = fusionStatisticsSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		FusionStatisticsSnapshot fusionStatisticsSnapshot2 = default;
		fusionStatisticsSnapshot2._002Ector();
		object obj6 = this + 40;
		obj6 = fusionStatisticsSnapshot2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkObjectStatisticsSnapshot networkObjectStatisticsSnapshot = default;
		networkObjectStatisticsSnapshot._002Ector();
		object obj7 = this + 48;
		obj7 = networkObjectStatisticsSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkObjectStatisticsSnapshot networkObjectStatisticsSnapshot2 = default;
		networkObjectStatisticsSnapshot2._002Ector();
		object obj8 = this + 56;
		obj8 = networkObjectStatisticsSnapshot2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj9 = default;
		obj9._002Ector();
		object obj10 = this + 16;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<NetworkId> hashSet = default;
		hashSet._002Ector();
		object obj11 = this + 24;
		obj11 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = this + 64;
		obj12 = simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void SwapSnapshots()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I
		object obj = this + 40;
		object obj2 = obj + -8;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+10]");
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)0).Clear();
		object obj4 = this + 48;
		object obj5 = obj4 + 8;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+10]");
		((Dictionary<NetworkId, System.__Canon>)0).Clear();
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void AddStat(FusionStatType statType, float value)
	{
		FusionStatisticsSnapshot currentSimulationSnapshot = _currentSimulationSnapshot;
		bool flag = ((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)(object)currentSimulationSnapshot.Stats).TryAdd((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, 0f);
		FusionStatisticsSnapshot currentSimulationSnapshot2 = _currentSimulationSnapshot;
		float num = ((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)(object)currentSimulationSnapshot2.Stats).get_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType);
		float value2 = num + value;
		((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)(object)currentSimulationSnapshot2.Stats).set_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value2);
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void SetStat(FusionStatType statType, float value)
	{
		FusionStatisticsSnapshot currentSimulationSnapshot = _currentSimulationSnapshot;
		if (!((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)(object)currentSimulationSnapshot.Stats).TryAdd((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value))
		{
			FusionStatisticsSnapshot currentSimulationSnapshot2 = _currentSimulationSnapshot;
			((Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float>)(object)currentSimulationSnapshot2.Stats).set_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value);
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void AddObjectStat(NetworkId id, FusionObjectStatType statType, float value)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected VT, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected VT, but got Unknown
		NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
		if (_monitoredIds.Contains(item))
		{
			NetworkObjectStatisticsSnapshot currentObjectSnapshot = _currentObjectSnapshot;
			NetworkId key = (NetworkId)(id & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6790]");
			object obj = 0;
			bool flag = ((Dictionary<NetworkId, System.__Canon>)(object)currentObjectSnapshot.NetworkObjectStatistics).TryGetValue(key, out System.__Canon _);
			bool flag2 = !flag;
			object obj2 = !flag2;
			Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float> dictionary = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67B0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				dictionary._002Ector();
				NetworkObjectStatisticsSnapshot currentObjectSnapshot2 = _currentObjectSnapshot;
				NetworkId key2 = (NetworkId)(id & 0xFFFFFFFFL);
				((Dictionary<NetworkId, System.__Canon>)(object)currentObjectSnapshot2.NetworkObjectStatistics).Add(key2, (System.__Canon)(object)dictionary);
			}
			bool flag3 = dictionary.TryAdd((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, 0f);
			float num = dictionary.get_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType);
			float value3 = num + value;
			dictionary.set_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value3);
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void SetObjectStat(NetworkId id, FusionObjectStatType statType, float value)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected VT, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected VT, but got Unknown
		NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
		if (_monitoredIds.Contains(item))
		{
			NetworkObjectStatisticsSnapshot currentObjectSnapshot = _currentObjectSnapshot;
			NetworkId key = (NetworkId)(id & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6790]");
			object obj = 0;
			bool flag = ((Dictionary<NetworkId, System.__Canon>)(object)currentObjectSnapshot.NetworkObjectStatistics).TryGetValue(key, out System.__Canon _);
			bool flag2 = !flag;
			object obj2 = !flag2;
			Dictionary<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, float> dictionary = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67B0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				dictionary._002Ector();
				NetworkObjectStatisticsSnapshot currentObjectSnapshot2 = _currentObjectSnapshot;
				NetworkId key2 = (NetworkId)(id & 0xFFFFFFFFL);
				((Dictionary<NetworkId, System.__Canon>)(object)currentObjectSnapshot2.NetworkObjectStatistics).Add(key2, (System.__Canon)(object)dictionary);
			}
			bool flag3 = dictionary.TryAdd((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value);
			bool flag4 = !flag3;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				dictionary.set_Item((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)statType, value);
			}
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	private void CollectAllocatorBucketsMemorySnapshot()
	{
		_memorySnapshot.CollectData(_simulation);
	}

	[MethodImpl((MethodImplOptions)256)]
	public void MonitorNetworkObject(NetworkId id)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
		bool flag = _monitoredIds.Add(item);
	}

	[MethodImpl((MethodImplOptions)256)]
	public void StopMonitorNetworkObject(NetworkId id)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
		bool flag = _monitoredIds.Remove(item);
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool IsObjectMonitored(NetworkId id)
	{
		//IL_003e: Expected I4, but got Obj
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		if (_monitoredIds != null)
		{
			NetworkId item = (NetworkId)(id & 0xFFFFFFFFL);
			return _monitoredIds.Contains(item);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
