using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PlayFab.ProfilesModels;
using UnityEngine;

namespace Fusion;

[Serializable]
public class NetworkPrefabTable
{
	public sealed class EqualityComparer : Action<SetGlobalPolicyResponse>
	{
		public bool Equals(NetworkPrefabId x, NetworkPrefabId y)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = x - y;
			return obj == null;
		}

		public int GetHashCode(NetworkPrefabId obj)
		{
			//IL_0005: Expected I4, but got VT
			return (int)obj;
		}
	}

	private struct PrefabAcquireData
	{
		public uint RawValue;

		public int InstanceCount
		{
			get
			{
				return (int)(RawValue & 0x7FFFFFFF);
			}
			set
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
				RawValue = RawValue;
			}
		}

		public bool IsSynchronous
		{
			get
			{
				return (byte)((int)RawValue >> 31) != 0;
			}
			set
			{
				//IL_001a: Expected Obj, but got I4
				//IL_003e: Expected I4, but got I8
				bool flag = !value;
				object obj = !flag;
				object obj2 = ~obj;
				uint rawValue = (uint)((obj2 == null) ? 2147483648uL : 0u);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
				RawValue = rawValue;
			}
		}
	}

	public NetworkPrefabTableOptions Options;

	private List<INetworkPrefabSource> _sources;

	private BitSet64[] _acquireMask;

	private const int BitsPerMask = default(int);

	private PrefabAcquireData[] _acquireData;

	private Dictionary<NetworkObjectGuid, int> _guidToIndex;

	private Dictionary<string, int> _pathToIndex;

	private Dictionary<string, int> _nameToIndex;

	private int _version;

	public IReadOnlyList<INetworkPrefabSource> Prefabs => (IReadOnlyList<INetworkPrefabSource>)_sources;

	public int Version => _version;

	public IEnumerable<(NetworkPrefabId, INetworkPrefabSource)> GetEntries()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8870]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		object obj3 = obj2 + 48;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerable<(NetworkPrefabId, INetworkPrefabSource)>)obj2;
	}

	public unsafe NetworkPrefabId AddSource(INetworkPrefabSource source)
	{
		//IL_005d: Expected Obj, but got Ref
		//IL_0071: Expected VT, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		INetworkPrefabSource source2 = default;
		if (TryAddSource(source2, out var id))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			bool flag = num != 0;
			ArgumentNullException ex = null;
			string text = (string)(&id);
			if (!flag)
			{
				return (NetworkPrefabId)0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289E38C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			string text2 = string.Format(format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentException ex2 = default;
			string text3 = default;
			ex2._002Ector(text2, text3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			bool flag2 = num2 != 0;
			object obj = 0;
			source2 = (INetworkPrefabSource)(object)text2;
			string text = text3;
			if (!flag2)
			{
				ArgumentNullException ex3 = new ArgumentNullException();
				obj = 0;
				ArgumentNullException ex = default;
				source2 = (INetworkPrefabSource)ex;
				ex = ex3;
				text = text3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkPrefabId result = default;
		return result;
	}

	public unsafe bool TryAddSource(INetworkPrefabSource source, out NetworkPrefabId id)
	{
		//IL_000d: Expected I, but got Obj
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0dc4: Expected I4, but got Obj
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_025b: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0ea0: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got VT
		//IL_0483: Expected Obj, but got I
		//IL_048b: Expected I, but got Obj
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got VT
		//IL_0e5e: Expected Ref, but got VT
		//IL_03e5: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_091d: Expected Obj, but got I
		//IL_0925: Expected I, but got Obj
		//IL_094d: Expected Obj, but got I
		//IL_0977: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Ref, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_09cd: Expected Obj, but got I4
		//IL_0582: Expected Obj, but got I
		//IL_059b: Expected I4, but got Obj
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Ref, but got Unknown
		//IL_0a69: Expected Obj, but got I
		//IL_0a71: Expected I, but got Obj
		//IL_0aa7: Expected Obj, but got I4
		//IL_060d: Expected I4, but got Obj
		//IL_0ae2: Expected Obj, but got I
		//IL_0af2: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I4
		//IL_0b34: Expected I, but got Obj
		//IL_0b44: Expected Obj, but got I
		//IL_0b54: Expected Obj, but got I
		//IL_0782: Expected Ref, but got VT
		//IL_079a: Expected Obj, but got I
		//IL_07aa: Expected Obj, but got I
		//IL_0fd7: Expected Obj, but got I
		//IL_0b8f: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I
		//IL_072c: Expected Obj, but got I4
		//IL_07df: Expected Obj, but got I
		//IL_07f1: Expected I, but got Obj
		//IL_0801: Expected Obj, but got I
		//IL_0811: Expected Obj, but got I
		//IL_0c78: Expected Obj, but got I
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected Obj, but got Unknown
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected Obj, but got Unknown
		//IL_0cad: Expected Obj, but got I
		//IL_0cc7: Expected Obj, but got I
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected Obj, but got Unknown
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected Obj, but got Unknown
		//IL_0f44: Expected Obj, but got I
		//IL_0f69: Expected Obj, but got I
		//IL_0f85: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_0cf1: Expected Obj, but got I
		//IL_0d0d: Expected I, but got Obj
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected Obj, but got Unknown
		//IL_0d5a: Expected I, but got Obj
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		INetworkPrefabSource networkPrefabSource = default;
		object obj;
		ref NetworkPrefabId reference2 = default;
		ref NetworkPrefabId reference;
		if (networkPrefabSource != null)
		{
			nint num = (nint)networkPrefabSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8878]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v38-8]");
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
			reference = ref reference2;
			goto IL_0e05;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (byte)(int)ex2 != 0;
		IL_0fc7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v40+8]");
		INetworkPrefabSource networkPrefabSource2 = (INetworkPrefabSource)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v858 @ X0_v40] (should have been resolved before IL gen)");
		string fileNameWithoutExtension;
		nint num2;
		if ((object)_nameToIndex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88B8]");
			object obj6 = 0;
			int index = ((Dictionary<System.__Canon, int>)(object)_nameToIndex).get_Item((System.__Canon)(object)fileNameWithoutExtension);
			NetworkPrefabId networkPrefabId = NetworkPrefabId.FromIndex(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88E8]");
			object format = 0;
			object obj8 = default;
			object obj9 = default;
			string text = string.Format((string)format, obj8, obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X25_v5+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X25_v5+18]");
			bool flag = (nint)0 == 0;
			num2 = unchecked((nint)null);
			reference = ref *(NetworkPrefabId*)obj9;
			networkPrefabSource2 = (INetworkPrefabSource)obj8;
			if (!flag)
			{
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X9_v18+1A0]");
				reference = ref *(NetworkPrefabId*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v619 @ X9_v18+198] (should have been resolved before IL gen)");
				NetworkPrefabId networkPrefabId2 = networkPrefabId;
				num2 = unchecked((nint)null);
				networkPrefabSource2 = (INetworkPrefabSource)(object)text;
				goto IL_0335;
			}
		}
		goto IL_0d67;
		IL_0253:
		nint num3 = (nint)networkPrefabSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v13 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X10_v33-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12--;
			obj13 += 16;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_02e7;
		}
		object obj14 = obj13 + 1;
		object obj15 = num3 + obj14;
		object obj16 = obj15 + 312;
		int num4;
		reference = ref *(NetworkPrefabId*)num4;
		goto IL_0e90;
		IL_0e49:
		int index2;
		NetworkPrefabId networkPrefabId3 = NetworkPrefabId.FromIndex(index2);
		reference2 = ref *(NetworkPrefabId*)networkPrefabId3;
		return false;
		IL_0335:
		List<System.__Canon> sources = (List<System.__Canon>)(object)_sources;
		object obj28;
		if (_sources != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C8]");
			object obj17 = 0;
			System.__Canon[] items = sources._items;
			object obj18 = obj17;
			int version = sources._version + 1;
			sources._version = version;
			if (sources._items != null)
			{
				bool flag2 = sources._size < items.Length;
				object obj19 = !flag2;
				if (obj19 == null)
				{
					object obj20 = sources._items + sources._size;
					int size = sources._size + 1;
					sources._size = size;
					object obj21 = obj20 + 32;
					obj21 = networkPrefabSource;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X9_v27+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v66+A8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v67+70]");
					reference = ref *(NetworkPrefabId*)null;
					((List<System.__Canon>)(object)_sources).AddWithResize((System.__Canon)networkPrefabSource);
				}
				ref BitSet64[] reference3 = ref *(BitSet64[]*)(this + 32);
				BitSet64[] array = reference3;
				bool flag3 = reference3 == null;
				networkPrefabSource2 = networkPrefabSource;
				if (!flag3)
				{
					bool flag4 = _sources == null;
					networkPrefabSource2 = networkPrefabSource;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88D0]");
						object obj24 = 0;
						int capacity = ((List<System.__Canon>)(object)_sources).Capacity;
						int bitSetCapacity = GetBitSetCapacity((int)obj24);
						bool flag5 = bitSetCapacity <= array.Length;
						networkPrefabSource2 = (INetworkPrefabSource)obj24;
						if (!flag5)
						{
							bool flag6 = _sources == null;
							networkPrefabSource2 = (INetworkPrefabSource)obj24;
							if (flag6)
							{
								goto IL_0d67;
							}
							int capacity2 = ((List<System.__Canon>)(object)_sources).Capacity;
							int bitSetCapacity2 = GetBitSetCapacity((int)obj24);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8890]");
							object obj25 = 0;
							reference = ref *(NetworkPrefabId*)obj25;
							Array.Resize(ref reference3, bitSetCapacity2);
							networkPrefabSource2 = (INetworkPrefabSource)bitSetCapacity2;
						}
						ref PrefabAcquireData[] reference4 = ref *(PrefabAcquireData[]*)(this + 40);
						PrefabAcquireData[] array2 = reference4;
						if (reference4 != null && _sources != null)
						{
							networkPrefabSource2 = (INetworkPrefabSource)obj24;
							int capacity3 = ((List<System.__Canon>)(object)_sources).Capacity;
							if (capacity3 > array2.Length)
							{
								if (_sources == null)
								{
									goto IL_0d67;
								}
								int capacity4 = ((List<System.__Canon>)(object)_sources).Capacity;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8898]");
								object obj26 = 0;
								reference = ref *(NetworkPrefabId*)obj26;
								Array.Resize(ref reference4, capacity4);
								networkPrefabSource2 = (INetworkPrefabSource)capacity4;
							}
							List<INetworkPrefabSource> sources2 = _sources;
							if (_sources != null)
							{
								int index3 = sources2._size - 1;
								NetworkPrefabId networkPrefabId4 = NetworkPrefabId.FromIndex(index3);
								reference2 = ref *(NetworkPrefabId*)networkPrefabId4;
								object obj27 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v46+A0]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v47+48]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v47+48]");
								if ((nint)0 == 0)
								{
									goto IL_0ede;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
								object obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								nint num5 = (nint)networkPrefabSource;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C0]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v54 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v54 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_088d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v54 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
								object obj34 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X10_v28-8]");
									if (0 == (nint)obj32)
									{
										break;
									}
									obj33--;
									obj34 += 16;
									if ((nint)obj33 != 1)
									{
										continue;
									}
									goto IL_088d;
								}
								object obj35 = obj34 + 4;
								object obj36 = num5 + obj35;
								object obj37 = obj36 + 312;
								goto IL_0f2a;
							}
						}
					}
				}
			}
		}
		goto IL_0d67;
		IL_0ede:
		int version2 = _version + 1;
		_version = version2;
		return true;
		IL_0d67:
		throw new NullReferenceException();
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		reference = ref *(NetworkPrefabId*)null;
		goto IL_0e05;
		IL_0e05:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v16] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
		NetworkObjectGuid networkObjectGuid = default;
		object obj38 = networkObjectGuid | 0;
		bool flag7 = obj38 == null;
		num4 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		if (flag7)
		{
			goto IL_0253;
		}
		bool flag8 = (object)_guidToIndex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
		networkPrefabSource2 = (INetworkPrefabSource)0;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8750]");
			object obj39 = 0;
			object obj40 = obj39;
			Dictionary<NetworkObjectGuid, int> guidToIndex = _guidToIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
			int num6 = default;
			if (guidToIndex.TryGetValue(networkObjectGuid, out *(int*)null))
			{
				index2 = num6;
				goto IL_0e49;
			}
			List<INetworkPrefabSource> sources3 = _sources;
			bool flag9 = _sources == null;
			num2 = (nint)(&num6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
			reference = ref *(NetworkPrefabId*)null;
			networkPrefabSource2 = (INetworkPrefabSource)networkObjectGuid;
			if (!flag9)
			{
				bool flag10 = (object)_guidToIndex == null;
				num2 = (nint)(&num6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
				reference = ref *(NetworkPrefabId*)null;
				networkPrefabSource2 = (INetworkPrefabSource)networkObjectGuid;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88A8]");
					object obj41 = 0;
					num2 = sources3._size;
					obj40 = obj41;
					Dictionary<NetworkObjectGuid, int> guidToIndex2 = _guidToIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
					guidToIndex2.Add(networkObjectGuid, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+8]");
					num4 = 0;
					goto IL_0253;
				}
			}
		}
		goto IL_0d67;
		IL_02e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		reference = ref *(NetworkPrefabId*)1;
		goto IL_0e90;
		IL_0e90:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v507 @ X0_v26] (should have been resolved before IL gen)");
		string text2 = default;
		bool flag11 = string.IsNullOrEmpty(text2);
		bool flag12 = !flag11;
		networkPrefabSource2 = null;
		if (flag12)
		{
			bool flag13 = (object)_pathToIndex == null;
			networkPrefabSource2 = null;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6418]");
				object obj42 = 0;
				num2 = (nint)obj42;
				if (((Dictionary<System.__Canon, int>)(object)_pathToIndex).TryGetValue((System.__Canon)(object)text2, out int value))
				{
					index2 = value;
					goto IL_0e49;
				}
				List<INetworkPrefabSource> sources4 = _sources;
				bool flag14 = _sources == null;
				reference = ref *(NetworkPrefabId*)(&value);
				networkPrefabSource2 = (INetworkPrefabSource)(object)text2;
				if (!flag14)
				{
					bool flag15 = (object)_pathToIndex == null;
					reference = ref *(NetworkPrefabId*)(&value);
					networkPrefabSource2 = (INetworkPrefabSource)(object)text2;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88A0]");
						object obj43 = 0;
						num2 = (nint)obj43;
						((Dictionary<System.__Canon, int>)(object)_pathToIndex).Add((System.__Canon)(object)text2, sources4._size);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3F78]");
						object obj44 = 0;
						object obj45 = obj44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v33+E4]");
						bool flag16 = (nint)0 == 0;
						object obj46 = !flag16;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
						bool flag17 = string.IsNullOrEmpty(fileNameWithoutExtension);
						bool flag18 = !flag17;
						object obj47 = !flag18;
						reference = ref *(NetworkPrefabId*)sources4._size;
						networkPrefabSource2 = null;
						if (obj47 != null)
						{
							goto IL_0335;
						}
						List<INetworkPrefabSource> sources5 = _sources;
						bool flag19 = _sources == null;
						reference = ref *(NetworkPrefabId*)sources4._size;
						networkPrefabSource2 = null;
						if (!flag19)
						{
							bool flag20 = (object)_nameToIndex == null;
							reference = ref *(NetworkPrefabId*)sources4._size;
							networkPrefabSource2 = null;
							if (!flag20)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88B0]");
								object obj48 = 0;
								num2 = (nint)obj48;
								bool flag21 = ((Dictionary<System.__Canon, int>)(object)_nameToIndex).TryAdd((System.__Canon)(object)fileNameWithoutExtension, sources5._size);
								bool flag22 = !flag21;
								object obj49 = !flag22;
								reference = ref *(NetworkPrefabId*)sources5._size;
								networkPrefabSource2 = (INetworkPrefabSource)(object)fileNameWithoutExtension;
								if (obj49 == null)
								{
									object obj50 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v23+A0]");
									object obj51 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v24+48]");
									object obj52 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v24+48]");
									bool flag23 = (nint)0 == 0;
									reference = ref *(NetworkPrefabId*)sources5._size;
									networkPrefabSource2 = (INetworkPrefabSource)(object)fileNameWithoutExtension;
									if (!flag23)
									{
										nint num7 = (nint)networkPrefabSource;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C0]");
										object obj53 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v25 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
										object obj54 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v25 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0bd0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v25 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
										object obj55 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X10_v14-8]");
											if (0 == (nint)obj53)
											{
												break;
											}
											obj54--;
											obj55 += 16;
											if ((nint)obj54 != 1)
											{
												continue;
											}
											goto IL_0bd0;
										}
										object obj56 = obj55 + 4;
										object obj57 = num7 + obj56;
										object obj58 = obj57 + 312;
										reference = ref *(NetworkPrefabId*)sources5._size;
										goto IL_0fc7;
									}
								}
								goto IL_0335;
							}
						}
					}
				}
			}
			goto IL_0d67;
		}
		goto IL_0335;
		IL_0bd0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		reference = ref *(NetworkPrefabId*)4;
		goto IL_0fc7;
		IL_0f2a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v894 @ X0_v74] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88E0]");
		object format2 = 0;
		object obj59 = default;
		object obj60 = default;
		string text3 = string.Format((string)format2, obj59, obj60);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X22_v15+10]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X22_v15+10]");
		bool flag24 = (nint)0 == 0;
		num2 = unchecked((nint)null);
		reference = ref *(NetworkPrefabId*)obj60;
		networkPrefabSource2 = (INetworkPrefabSource)obj59;
		if (flag24)
		{
			goto IL_0d67;
		}
		object obj62 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v763 @ X9_v32+198] (should have been resolved before IL gen)");
		goto IL_0ede;
		IL_088d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		reference = ref *(NetworkPrefabId*)4;
		goto IL_0f2a;
	}

	public unsafe INetworkPrefabSource GetSource(NetworkObjectGuid guid)
	{
		if ((object)_guidToIndex != null)
		{
			IntPtr intPtr = default;
			if (!_guidToIndex.TryGetValue(guid, out *(int*)intPtr))
			{
				return null;
			}
			int index = default;
			if (_sources != null)
			{
				return (INetworkPrefabSource)((List<System.__Canon>)(object)_sources).get_Item(index);
			}
		}
		return (INetworkPrefabSource)new NullReferenceException();
	}

	public INetworkPrefabSource GetSource(NetworkPrefabId prefabId)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		if (TryDecodePrefabId(prefabId2, out var _))
		{
			if (_sources != null)
			{
				return (INetworkPrefabSource)((List<System.__Canon>)(object)_sources).get_Item(0);
			}
			return (INetworkPrefabSource)new NullReferenceException();
		}
		return null;
	}

	public unsafe NetworkPrefabId GetId(NetworkObjectGuid guid)
	{
		//IL_0067: Expected VT, but got Obj
		//IL_0054: Expected VT, but got I4
		if ((object)_guidToIndex != null)
		{
			IntPtr intPtr = default;
			int index = default;
			if (_guidToIndex.TryGetValue(guid, out *(int*)intPtr))
			{
				return NetworkPrefabId.FromIndex(index);
			}
			return (NetworkPrefabId)0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (NetworkPrefabId)ex;
	}

	public NetworkPrefabId GetId(string nameOrPath)
	{
		//IL_00c8: Expected VT, but got Obj
		//IL_0037: Expected Obj, but got I4
		//IL_00b5: Expected VT, but got I4
		if ((object)_pathToIndex != null)
		{
			bool flag = ((Dictionary<System.__Canon, int>)(object)_pathToIndex).TryGetValue((System.__Canon)(object)nameOrPath, out int value);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				if ((object)_nameToIndex == null)
				{
					goto IL_00ba;
				}
				if (!((Dictionary<System.__Canon, int>)(object)_nameToIndex).TryGetValue((System.__Canon)(object)nameOrPath, out value))
				{
					return (NetworkPrefabId)0;
				}
			}
			return NetworkPrefabId.FromIndex(value);
		}
		goto IL_00ba;
		IL_00ba:
		NullReferenceException ex = new NullReferenceException();
		return (NetworkPrefabId)ex;
	}

	public NetworkObjectGuid GetGuid(NetworkPrefabId prefabId)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected VT, but got Unknown
		//IL_0132: Expected VT, but got I4
		//IL_0165: Expected VT, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		object obj2;
		if (TryDecodePrefabId(prefabId2, out var _))
		{
			if (_sources != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88F8]");
				object obj = 0;
				obj2 = obj;
				System.__Canon _Canon = ((List<System.__Canon>)(object)_sources).get_Item(0);
				if (_Canon != null)
				{
					nint num = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8878]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<System.__Canon>)+12E]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<System.__Canon>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0111;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<System.__Canon>)+98]");
					object obj5 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v8-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj4--;
						obj5 += 16;
						if ((nint)obj4 != 1)
						{
							continue;
						}
						goto IL_0111;
					}
					object obj6 = num + obj5;
					object obj7 = obj6 + 312;
					goto IL_01ca;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkObjectGuid)ex;
		}
		return (NetworkObjectGuid)0;
		IL_01ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ X0_v10] (should have been resolved before IL gen)");
		NetworkObjectGuid result = default;
		return result;
		IL_0111:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj2 = 0;
		goto IL_01ca;
	}

	public int GetInstancesCount(NetworkPrefabId prefabId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_01b9: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		bool flag = TryDecodePrefabId(prefabId2, out var _);
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask == null)
			{
				goto IL_019d;
			}
			bool flag3 = 0 < 0;
			bool flag4 = 0 < 0;
			bool flag5 = flag3 == flag4;
			object obj = !flag5;
			object obj2 = ~obj;
			object obj3 = ((obj2 != null) ? ((object)0) : ((object)63));
			object obj4 = obj3 >> 6;
			bool flag6 = (nint)obj4 < acquireMask.Length;
			object obj5 = !flag6;
			if (obj5 != null)
			{
				goto IL_01ab;
			}
			object obj6 = (object)_acquireMask + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X9_v5+20]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 != null)
			{
				PrefabAcquireData[] acquireData = _acquireData;
				if (_acquireData == null)
				{
					goto IL_019d;
				}
				bool flag7 = 0 < acquireData.Length;
				object obj8 = !flag7;
				if (obj8 != null)
				{
					goto IL_01ab;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v8 (PrefabAcquireData[])+20]");
				result = (int)((nint)0 & (nint)0x7FFFFFFF);
			}
			else
			{
				result = 0;
			}
		}
		return result;
		IL_01ab:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_019d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01ab;
	}

	public int AddInstance(NetworkPrefabId prefabId)
	{
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected VT, but got Unknown
		//IL_02ca: Expected I4, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected I4, but got Unknown
		//IL_01b6: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		bool flag = TryDecodePrefabId(prefabId2, out var _);
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask != null)
			{
				bool flag3 = 0 < 0;
				bool flag4 = 0 < 0;
				bool flag5 = flag3 == flag4;
				object obj = !flag5;
				object obj2 = ~obj;
				object obj3 = ((obj2 != null) ? ((object)0) : ((object)63));
				object obj4 = obj3 >> 6;
				bool flag6 = (nint)obj4 < acquireMask.Length;
				object obj5 = !flag6;
				if (obj5 != null)
				{
					goto IL_02bc;
				}
				object obj6 = (object)_acquireMask + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v8+20]");
				object obj7 = (nint)0 & (nint)1;
				if (obj7 == null)
				{
					result = 0;
					goto IL_0314;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v14+48]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v14+48]");
				if ((nint)0 == 0)
				{
					goto IL_0350;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				PrefabAcquireData[] acquireData = _acquireData;
				if (_acquireData != null)
				{
					bool flag7 = 0 < acquireData.Length;
					object obj13 = !flag7;
					if (obj13 != null)
					{
						goto IL_02bc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8900]");
					object format = 0;
					object arg = default;
					object arg2 = default;
					string text = string.Format((string)format, arg, arg2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X23_v5+10]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X23_v5+10]");
					if ((nint)0 != 0)
					{
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X9_v15+198] (should have been resolved before IL gen)");
						goto IL_0350;
					}
				}
			}
			goto IL_02ae;
		}
		goto IL_0314;
		IL_02bc:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_02ae:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02bc;
		IL_0350:
		PrefabAcquireData[] acquireData2 = _acquireData;
		int version = _version + 1;
		_version = version;
		if (_acquireData == null)
		{
			goto IL_02ae;
		}
		bool flag8 = 0 < acquireData2.Length;
		object obj17 = !flag8;
		if (obj17 != null)
		{
			goto IL_02bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v16 (PrefabAcquireData[])+20]");
		object obj18 = (nint)0 & (nint)0x7FFFFFFF;
		result = obj18 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v16 (PrefabAcquireData[])+20]");
		_ = 0;
		goto IL_0314;
		IL_0314:
		return result;
	}

	public int RemoveInstance(NetworkPrefabId prefabId)
	{
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected VT, but got Unknown
		//IL_0482: Expected I4, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected I4, but got Unknown
		//IL_021f: Expected Obj, but got I4
		//IL_0372: Invalid comparison between VT and I4
		//IL_023d: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		bool flag = TryDecodePrefabId(prefabId2, out var _);
		bool flag2 = !flag;
		int result = 0;
		PrefabAcquireData[] acquireData;
		if (!flag2)
		{
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask != null)
			{
				bool flag3 = 0 < 0;
				bool flag4 = 0 < 0;
				bool flag5 = flag3 == flag4;
				object obj = !flag5;
				object obj2 = ~obj;
				int num = ((obj2 == null) ? 63 : 0);
				int num2 = num >> 6;
				bool flag6 = num2 < acquireMask.Length;
				object obj3 = !flag6;
				if (obj3 != null)
				{
					goto IL_0474;
				}
				object obj4 = _acquireMask + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v7+20]");
				if ((int)((nint)0 & (nint)1) == 0)
				{
					goto IL_0508;
				}
				acquireData = _acquireData;
				if (_acquireData != null)
				{
					bool flag7 = 0 < acquireData.Length;
					object obj5 = !flag7;
					if (obj5 != null)
					{
						goto IL_0474;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v11+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v18 (PrefabAcquireData[])+20]");
					object obj9 = (nint)0 & (nint)0x7FFFFFFF;
					bool flag8 = obj9 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v12+48]");
					object obj10 = 0;
					if (flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v12+48]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8910]");
							object format = 0;
							object arg = default;
							string text = string.Format((string)format, arg);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v6+18]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v6+18]");
							if ((nint)0 == 0)
							{
								goto IL_0466;
							}
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X9_v13+198] (should have been resolved before IL gen)");
						}
						goto IL_0508;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v12+48]");
					if ((nint)0 == 0)
					{
						goto IL_02e2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					PrefabAcquireData[] acquireData2 = _acquireData;
					if (_acquireData != null)
					{
						bool flag9 = 0 < acquireData2.Length;
						object obj15 = !flag9;
						if (obj15 != null)
						{
							goto IL_0474;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8908]");
						object format2 = 0;
						object arg2 = default;
						object arg3 = default;
						string text2 = string.Format((string)format2, arg2, arg3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v6+10]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v6+10]");
						if ((nint)0 != 0)
						{
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X9_v20+198] (should have been resolved before IL gen)");
							acquireData = _acquireData;
							if (_acquireData != null)
							{
								goto IL_02e2;
							}
						}
					}
				}
			}
			goto IL_0466;
		}
		goto IL_04cc;
		IL_0474:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_04cc:
		return result;
		IL_02e2:
		bool flag10 = 0 < acquireData.Length;
		object obj19 = !flag10;
		if (obj19 != null)
		{
			goto IL_0474;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v18 (PrefabAcquireData[])+20]");
		object obj20 = (nint)0 & (nint)0x7FFFFFFF;
		result = obj20 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v18 (PrefabAcquireData[])+20]");
		_ = 0;
		if ((nint)obj20 == 1 && Options != (NetworkPrefabTableOptions)(object)0)
		{
			UnloadInternal(0);
		}
		int version = _version + 1;
		_version = version;
		goto IL_04cc;
		IL_0466:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0474;
		IL_0508:
		result = 0;
		goto IL_04cc;
	}

	public bool Contains(NetworkPrefabId prefabId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		int index;
		return TryDecodePrefabId(prefabId2, out index);
	}

	public bool IsAcquired(NetworkPrefabId prefabId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_0125: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		bool flag = TryDecodePrefabId(prefabId2, out var _);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask != null)
			{
				bool flag3 = 0 < 0;
				bool flag4 = 0 < 0;
				bool flag5 = flag3 == flag4;
				object obj = !flag5;
				object obj2 = ~obj;
				object obj3 = ((obj2 != null) ? ((object)0) : ((object)63));
				object obj4 = obj3 >> 6;
				bool flag6 = (nint)obj4 < acquireMask.Length;
				object obj5 = !flag6;
				if (obj5 == null)
				{
					object obj6 = (object)_acquireMask + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+20]");
					result = (byte)((nuint)0u & (nuint)1u) != 0;
					goto IL_0125;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_0125;
		IL_0125:
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	private bool IsAcquired(int index)
	{
		//IL_0104: Expected I4, but got Obj
		//IL_0088: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		BitSet64[] acquireMask = _acquireMask;
		if (_acquireMask != null)
		{
			int num = index + 63;
			bool flag = index < 0;
			int num2 = index ^ index;
			int num3 = index & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj = !flag3;
			object obj2 = ~obj;
			if (obj2 != null)
			{
				num = index;
			}
			int num4 = num >> 6;
			bool flag4 = num4 < acquireMask.Length;
			object obj3 = !flag4;
			if (obj3 == null)
			{
				object obj4 = _acquireMask + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v2+20]");
				int num5 = (int)((nint)0 >> index);
				return (byte)(num5 & 1) != 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void SetAcquired(int index, bool value)
	{
		//IL_0088: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		BitSet64[] acquireMask = _acquireMask;
		if (_acquireMask != null)
		{
			int num = index + 63;
			bool flag = index < 0;
			int num2 = index ^ index;
			int num3 = index & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			object obj = !flag3;
			object obj2 = ~obj;
			if (obj2 != null)
			{
				num = index;
			}
			int num4 = num >> 6;
			bool flag4 = num4 < acquireMask.Length;
			object obj3 = !flag4;
			if (obj3 == null)
			{
				object obj4 = _acquireMask + 32;
				int num5 = index & 0x3F;
				if (value)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B40]");
					object error = 0;
					Assert.Check(condition: true, (string)error);
					int num6 = 1 << num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X21_v1+v47 @ X20_v2 (System.Int32)*8]");
					int num7 = (int)((nint)0 | (nint)num6);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B40]");
					object error2 = 0;
					Assert.Check(condition: true, (string)error2);
					int num8 = 1 << num5;
					int num9 = ~num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X21_v1+v47 @ X20_v2 (System.Int32)*8]");
					int num7 = (int)((nint)0 & (nint)num9);
				}
				int version = _version + 1;
				_version = version;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public NetworkObject Load(NetworkPrefabId prefabId, bool isSynchronous)
	{
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected VT, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_09f2: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_0406: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected Obj, but got Unknown
		//IL_0451: Expected Obj, but got I
		//IL_02d8: Expected I, but got Obj
		//IL_02e8: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_04e0: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0b00: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_0a78: Expected Obj, but got I
		//IL_0a9d: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I
		//IL_0c1b: Expected Obj, but got I4
		//IL_053b: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I8
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected VT, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_062c: Expected Obj, but got I8
		//IL_0646: Expected Obj, but got I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_065c: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_0c5f: Expected I, but got Obj
		//IL_0c6f: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected Obj, but got Unknown
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I4
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected Obj, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected Obj, but got Unknown
		//IL_0885: Expected Obj, but got I8
		//IL_0892: Expected I, but got Obj
		//IL_08a2: Expected Obj, but got I
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected Obj, but got Unknown
		//IL_0d56: Expected Obj, but got I4
		//IL_08dd: Expected Obj, but got I
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected Obj, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		int num = DecodePrefabId(prefabId2);
		System.__Canon _Canon;
		object obj6;
		bool flag;
		if (_sources != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88F8]");
			object obj = 0;
			flag = (byte)(int)obj != 0;
			_Canon = ((List<System.__Canon>)(object)_sources).get_Item(num);
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask != null)
			{
				int num2 = num + 63;
				bool flag2 = num < 0;
				int num3 = num ^ num;
				int num4 = num & num3;
				bool flag3 = num4 < 0;
				bool flag4 = flag2 == flag3;
				object obj2 = !flag4;
				object obj3 = ~obj2;
				if (obj3 != null)
				{
					num2 = num;
				}
				int num5 = num2 >> 6;
				bool flag5 = num5 < acquireMask.Length;
				object obj4 = !flag5;
				if (obj4 != null)
				{
					goto IL_097c;
				}
				object obj5 = _acquireMask + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v7+20]");
				int num6 = (int)((nint)0 >> num);
				int num7 = num6 & 1;
				bool flag6 = num7 == 0;
				object obj7 = !flag6;
				if (obj7 != null)
				{
					goto IL_0a00;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v42+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v43+48]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v43+48]");
				if ((nint)0 == 0)
				{
					goto IL_0a1d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				if (_Canon != null)
				{
					nint num8 = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v53 (Il2CppClass<System.__Canon>)+12E]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v53 (Il2CppClass<System.__Canon>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0273;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v53 (Il2CppClass<System.__Canon>)+98]");
					object obj14 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v50-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj13--;
						obj14 += 16;
						if ((nint)obj13 != 1)
						{
							continue;
						}
						goto IL_0273;
					}
					object obj15 = obj14 + 4;
					object obj16 = num8 + obj15;
					object obj17 = obj16 + 312;
					goto IL_0a5e;
				}
			}
		}
		goto IL_096e;
		IL_0964:
		return null;
		IL_0364:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0ae6;
		IL_096e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_097c;
		IL_0ae6:
		bool flag7 = !isSynchronous;
		object obj18 = !flag7;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
			object obj20 = 2147483648L;
		}
		else
		{
			object obj20 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v587 @ X0_v52] (should have been resolved before IL gen)");
		SetAcquired(num, value: true);
		PrefabAcquireData[] acquireData = _acquireData;
		if (_acquireData == null)
		{
			goto IL_096e;
		}
		bool flag8 = num < acquireData.Length;
		object obj21 = !flag8;
		if (obj21 != null)
		{
			goto IL_097c;
		}
		object obj22 = _acquireData + num;
		flag = true;
		goto IL_0a00;
		IL_0c4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v850 @ X0_v17] (should have been resolved before IL gen)");
		nint num9 = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v22 (Il2CppClass<System.__Canon>)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v22 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0804;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v22 (Il2CppClass<System.__Canon>)+98]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X10_v19-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj23--;
			obj24 += 16;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_0804;
		}
		object obj25 = num9 + obj24;
		object obj26 = obj25 + 312;
		goto IL_0cbd;
		IL_06e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag = true;
		goto IL_0c4d;
		IL_091e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag = true;
		goto IL_0d24;
		IL_097c:
		return (NetworkObject)(object)new IndexOutOfRangeException();
		IL_0a00:
		if (_Canon == null)
		{
			goto IL_096e;
		}
		nint num10 = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v11 (Il2CppClass<System.__Canon>)+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v11 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0492;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v11 (Il2CppClass<System.__Canon>)+98]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X10_v36-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj27--;
			obj28 += 16;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_0492;
		}
		object obj29 = obj28 + 3;
		object obj30 = num10 + obj29;
		object obj31 = obj30 + 312;
		goto IL_0b7d;
		IL_0bd6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8928]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v759 @ X0_v36] (should have been resolved before IL gen)");
		object obj33;
		object obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v37+E4]");
		bool flag9 = (nint)0 == 0;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj35 = default;
		bool condition = obj35;
		NetworkPrefabId arg = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		Assert.Always(condition, (string)format, arg);
		return (NetworkObject)obj35;
		IL_0804:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0cbd;
		IL_0d24:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v983 @ X0_v23] (should have been resolved before IL gen)");
		object obj37 = default;
		object obj36 = obj37 & 1;
		bool flag10 = obj36 == null;
		object obj38 = !flag10;
		if (obj38 != null)
		{
			goto IL_04d8;
		}
		goto IL_0964;
		IL_0273:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag = true;
		goto IL_0a5e;
		IL_0a5e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X0_v61] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8930]");
		object format2 = 0;
		object arg2 = default;
		object arg3 = default;
		string text = string.Format((string)format2, arg2, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v5+10]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v5+10]");
		if ((nint)0 == 0)
		{
			goto IL_096e;
		}
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X9_v63+198] (should have been resolved before IL gen)");
		goto IL_0a1d;
		IL_0cbd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v20+8]");
		flag = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v915 @ X0_v20] (should have been resolved before IL gen)");
		PrefabAcquireData[] acquireData2 = _acquireData;
		if (_acquireData == null)
		{
			goto IL_096e;
		}
		bool flag11 = num < acquireData2.Length;
		object obj41 = !flag11;
		if (obj41 != null)
		{
			goto IL_097c;
		}
		object obj42 = _acquireData + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v26+20]");
		object obj43 = 0 | 0x80000000L;
		nint num11 = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v27 (Il2CppClass<System.__Canon>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v27 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_091e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v27 (Il2CppClass<System.__Canon>)+98]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X10_v14-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj44--;
			obj45 += 16;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_091e;
		}
		object obj46 = obj45 + 3;
		object obj47 = num11 + obj46;
		object obj48 = obj47 + 312;
		goto IL_0d24;
		IL_0a1d:
		if (_Canon == null)
		{
			goto IL_096e;
		}
		nint num12 = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v45 (Il2CppClass<System.__Canon>)+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v45 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0364;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v45 (Il2CppClass<System.__Canon>)+98]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X10_v43-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj49--;
			obj50 += 16;
			if ((nint)obj49 != 1)
			{
				continue;
			}
			goto IL_0364;
		}
		object obj51 = num12 + obj50;
		object obj52 = obj51 + 312;
		goto IL_0ae6;
		IL_057c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag = true;
		goto IL_0bd6;
		IL_04d8:
		nint num13 = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v34 (Il2CppClass<System.__Canon>)+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v34 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_057c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v34 (Il2CppClass<System.__Canon>)+98]");
		object obj54 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v31-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj53--;
			obj54 += 16;
			if ((nint)obj53 != 1)
			{
				continue;
			}
			goto IL_057c;
		}
		object obj55 = obj54 + 2;
		object obj56 = num13 + obj55;
		object obj57 = obj56 + 312;
		goto IL_0bd6;
		IL_0492:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag = true;
		goto IL_0b7d;
		IL_0b7d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v549 @ X0_v11] (should have been resolved before IL gen)");
		object obj59 = default;
		object obj58 = obj59 & 1;
		if (obj58 == null)
		{
			if (isSynchronous)
			{
				PrefabAcquireData[] acquireData3 = _acquireData;
				if (_acquireData == null)
				{
					goto IL_096e;
				}
				bool flag12 = num < acquireData3.Length;
				object obj60 = !flag12;
				if (obj60 != null)
				{
					goto IL_097c;
				}
				object obj61 = _acquireData + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v17+20]");
				object obj62 = 0 & 0x80000000L;
				bool flag13 = obj62 == null;
				object obj63 = !flag13;
				if (obj63 == null)
				{
					nint num14 = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v19 (Il2CppClass<System.__Canon>)+12E]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v19 (Il2CppClass<System.__Canon>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_06e8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v19 (Il2CppClass<System.__Canon>)+98]");
					object obj65 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X10_v24-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj64--;
						obj65 += 16;
						if ((nint)obj64 != 1)
						{
							continue;
						}
						goto IL_06e8;
					}
					object obj66 = obj65 + 1;
					object obj67 = num14 + obj66;
					object obj68 = obj67 + 312;
					goto IL_0c4d;
				}
			}
			goto IL_0964;
		}
		goto IL_04d8;
	}

	public bool Unload(NetworkPrefabId prefabId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_0164: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		bool flag = TryDecodePrefabId(prefabId2, out var _);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			BitSet64[] acquireMask = _acquireMask;
			if (_acquireMask != null)
			{
				bool flag3 = 0 < 0;
				bool flag4 = 0 < 0;
				bool flag5 = flag3 == flag4;
				object obj = !flag5;
				object obj2 = ~obj;
				int num = ((obj2 == null) ? 63 : 0);
				int num2 = num >> 6;
				bool flag6 = num2 < acquireMask.Length;
				object obj3 = !flag6;
				if (obj3 == null)
				{
					object obj4 = _acquireMask + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+20]");
					if ((int)((nint)0 & (nint)1) != 0)
					{
						UnloadInternal(0);
						result = true;
					}
					else
					{
						result = false;
					}
					goto IL_0164;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_0164;
		IL_0164:
		return result;
	}

	public unsafe int UnloadUnreferenced(bool includeIncompleteLoads = default(bool))
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_005f: Expected VT, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0430: Expected Obj, but got I4
		//IL_060a: Expected VT, but got Ref
		//IL_061b: Expected Obj, but got Ref
		//IL_0454: Expected VT, but got Ref
		//IL_018d: Expected Obj, but got I4
		//IL_03a5: Expected I4, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_01b2: Expected I4, but got Obj
		//IL_047b: Expected VT, but got Ref
		//IL_0483: Expected I4, but got Obj
		//IL_01db: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0313: Expected I4, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_049e: Expected I, but got Obj
		//IL_04a6: Expected VT, but got Ref
		//IL_04ae: Expected I4, but got Obj
		List<INetworkPrefabSource> sources = _sources;
		bool flag = _sources == null;
		bool flag2 = includeIncompleteLoads;
		object obj;
		object obj2;
		object obj3;
		object format;
		BitSet64.Enumerator enumerator;
		object obj5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88F8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C0]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8950]");
			format = 0;
			enumerator = (BitSet64.Enumerator)0;
			flag2 = includeIncompleteLoads;
			obj5 = 0;
			while (true)
			{
				if ((nint)obj5 < sources._size)
				{
					BitSet64[] acquireMask = _acquireMask;
					if (_acquireMask == null)
					{
						break;
					}
					object obj6 = obj5 >> 6;
					object obj7 = acquireMask.Length;
					bool flag3 = (nint)obj6 < acquireMask.Length;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						object obj9 = (object)_acquireMask + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v12+20]");
						if ((nint)0 != 0)
						{
							goto IL_0114;
						}
						sources = _sources;
						obj5 += 64;
						bool flag4 = _sources == null;
						object obj10 = !flag4;
						if (obj10 == null)
						{
							break;
						}
						continue;
					}
					goto IL_04cf;
				}
				return 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_04cf;
		IL_04cf:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_04dd;
		IL_0114:
		BitSet64 bitSet = default;
		BitSet64.Enumerator enumerator2 = bitSet.GetEnumerator();
		object obj18 = default;
		string text;
		object arg = default;
		nint num;
		while (enumerator.MoveNext())
		{
			List<System.__Canon> sources2 = (List<System.__Canon>)(object)_sources;
			if (_sources == null)
			{
				goto IL_0443;
			}
			if ((nint)obj5 >= sources2._size)
			{
				break;
			}
			bool flag5 = !includeIncompleteLoads;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				goto IL_039b;
			}
			num = (nint)obj;
			System.__Canon _Canon = ((List<System.__Canon>)(object)_sources).get_Item((int)obj5);
			if (_Canon == null)
			{
				goto IL_046a;
			}
			nint num2 = (nint)_Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v21 (Il2CppClass<System.__Canon>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v21 (Il2CppClass<System.__Canon>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_026f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v21 (Il2CppClass<System.__Canon>)+98]");
			object obj13 = (nint)0 + (nint)8;
			object obj7;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X10_v15-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj12--;
				obj7 = obj13 + 16;
				bool flag6 = (nint)obj12 != 1;
				obj13 = obj7;
				if (flag6)
				{
					continue;
				}
				goto IL_026f;
			}
			object obj14 = obj13 + 3;
			object obj15 = num2 + obj14;
			object obj16 = obj15 + 312;
			obj7 = obj13;
			goto IL_0554;
			IL_0554:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v601 @ X0_v33] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			bool flag7 = obj17 == null;
			System.__Canon _Canon2 = _Canon;
			if (flag7)
			{
				goto IL_039b;
			}
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v24+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v25+48]");
			_Canon2 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v25+48]");
			if ((nint)0 == 0)
			{
				continue;
			}
			NetworkPrefabId networkPrefabId = NetworkPrefabId.FromIndex((int)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X22_v10 (System.__Canon)+10]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X22_v10 (System.__Canon)+10]");
			if ((nint)0 != 0)
			{
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v27+1A0]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v517 @ X8_v27+198] (should have been resolved before IL gen)");
				NetworkPrefabId networkPrefabId2 = networkPrefabId;
				continue;
			}
			goto IL_0490;
			IL_039b:
			UnloadInternal((int)obj5);
			continue;
			IL_026f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num = 3;
			goto IL_0554;
		}
		enumerator.Dispose();
		BitSet64.Enumerator enumerator3 = (BitSet64.Enumerator)(&enumerator);
		flag2 = false;
		ex2 = (IndexOutOfRangeException)(&enumerator);
		goto IL_04dd;
		IL_0443:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator3 = (BitSet64.Enumerator)(&enumerator);
		flag2 = false;
		OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
		goto IL_05df;
		IL_046a:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator3 = (BitSet64.Enumerator)(&enumerator);
		flag2 = (byte)(int)obj5 != 0;
		ex4 = (OutOfMemoryException)(object)ex5;
		goto IL_05df;
		IL_04dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		ex4 = new OutOfMemoryException();
		goto IL_05df;
		IL_05df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28ABEAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		int result = default;
		return result;
		IL_0490:
		NullReferenceException ex6 = new NullReferenceException();
		num = unchecked((nint)null);
		enumerator3 = (BitSet64.Enumerator)(&enumerator);
		flag2 = (byte)(int)text != 0;
		ex4 = (OutOfMemoryException)(object)ex6;
		goto IL_05df;
	}

	public void UnloadAll()
	{
		//IL_0067: Expected Obj, but got I4
		List<INetworkPrefabSource> sources = _sources;
		int num = 0;
		while (num < sources._size)
		{
			NetworkPrefabId prefabId = NetworkPrefabId.FromIndex(num);
			bool flag = Unload(prefabId);
			sources = _sources;
			num++;
			bool flag2 = _sources == null;
			object obj = !flag2;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	public void Clear()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		UnloadAll();
		List<INetworkPrefabSource> sources = _sources;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8958]");
		object obj = 0;
		Array.Clear(_acquireData, 0, sources._size);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v5+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v5+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v5+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v5+38]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v13+10]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v8+A0]");
		object obj8 = 0;
		object obj9 = this + 32;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X20_v7-8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+1C]");
		object obj11 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+18]");
			Array.Clear((Array)num, 0, 0);
		}
		_guidToIndex.Clear();
		((Dictionary<System.__Canon, int>)(object)_nameToIndex).Clear();
		((Dictionary<System.__Canon, int>)(object)_pathToIndex).Clear();
		_version = 0;
	}

	private void UnloadInternal(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8858]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8918]");
			object format = 0;
			NetworkPrefabId networkPrefabId = NetworkPrefabId.FromIndex(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			string text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X21_v2+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ X9_v10+198] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88F8]");
		object obj8 = 0;
		object obj9 = obj8;
		System.__Canon _Canon = ((List<System.__Canon>)(object)_sources).get_Item(index);
		nint num = (nint)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D88C0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (Il2CppClass<System.__Canon>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (Il2CppClass<System.__Canon>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0162;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8 (Il2CppClass<System.__Canon>)+98]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v8-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj11--;
			obj12 += 16;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0162;
		}
		object obj13 = obj12 + 1;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		goto IL_0219;
		IL_0219:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v5] (should have been resolved before IL gen)");
		SetAcquired(index, value: false);
		int version = _version + 1;
		_version = version;
		return;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj9 = 1;
		goto IL_0219;
	}

	private int DecodePrefabId(NetworkPrefabId prefabId)
	{
		//IL_0180: Invalid comparison between VT and I4
		//IL_0028: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got VT
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0062: Expected Obj, but got I
		//IL_0177: Expected I4, but got Obj
		NetworkPrefabId networkPrefabId = default;
		if (networkPrefabId != (NetworkPrefabId)(object)0)
		{
			List<INetworkPrefabSource> sources = _sources;
			bool flag = _sources == null;
			IntPtr intPtr = default;
			string text = (string)(nint)intPtr;
			if (!flag)
			{
				int num = networkPrefabId - 1;
				bool flag2 = num >= sources._size;
				text = (string)(nint)intPtr;
				if (!flag2)
				{
					return num;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				string message = string.Format(format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentException ex = default;
				string paramName = default;
				ex._002Ector(message, paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (int)ex2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NetworkPrefabId networkPrefabId2 = default;
			string message2 = default;
			string text2 = default;
			((ArgumentException)networkPrefabId2)._002Ector(message2, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = new ArgumentNullException();
			string text = text2;
		}
		throw new NullReferenceException();
	}

	private unsafe bool TryDecodePrefabId(NetworkPrefabId prefabId, out int index)
	{
		//IL_012a: Invalid comparison between VT and I4
		//IL_010e: Expected Obj, but got I4
		//IL_0121: Expected I4, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected I4, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		object obj6;
		bool result;
		if (prefabId != (NetworkPrefabId)(object)0)
		{
			List<INetworkPrefabSource> sources = _sources;
			if (_sources == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			object obj = prefabId - 1;
			object obj2 = obj - sources._size;
			bool flag = (nint)obj2 < 0;
			int num = obj ^ sources._size;
			object obj3 = obj ^ obj2;
			int num2 = num & obj3;
			bool flag2 = num2 < 0;
			bool flag3 = flag == flag2;
			bool flag4 = !flag3;
			bool flag5 = flag == flag2;
			object obj4 = !flag5;
			object obj5 = ~obj4;
			obj6 = ((obj5 != null) ? ((object)0) : obj);
			result = flag4;
		}
		else
		{
			result = false;
			obj6 = 0;
		}
		ref int reference = ref *(int*)obj6;
		return result;
	}

	private int GetBitSetCapacity(int length)
	{
		//IL_00b4: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00e1: Expected I4, but got Obj
		if (_sources != null)
		{
			int capacity = ((List<System.__Canon>)(object)_sources).Capacity;
			object obj = capacity + 63;
			object obj2 = capacity + 126;
			bool flag = (nint)obj < 0;
			object obj3 = obj ^ obj;
			object obj4 = obj & obj3;
			bool flag2 = (nint)obj4 < 0;
			bool flag3 = flag == flag2;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				obj = obj2;
			}
			return obj >> 6;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public NetworkPrefabTable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_0367: Expected VT, but got Obj
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I
		//IL_04d6: Expected Obj, but got I
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8970]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8958]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+A0]");
		Options = (NetworkPrefabTableOptions)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = this + 24;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v4+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v4+38]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v4+38]");
			obj7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8978]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v4+38]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v29+10]");
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+A0]");
		object obj11 = 0;
		object obj12 = this + 32;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v5+38]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v5+38]");
		bool flag = (nint)0 == 0;
		object obj15 = !flag;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v5+38]");
			obj14 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8990]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v17+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v5+38]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v27+10]");
			obj16 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v17+A0]");
		object obj20 = 0;
		object obj21 = this + 40;
		obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<NetworkObjectGuid, int> dictionary = default;
		dictionary._002Ector();
		object obj22 = this + 48;
		obj22 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v26+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6550]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8988]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v30+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v30+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v20+18]");
		Dictionary<System.__Canon, int> dictionary2 = default;
		dictionary2._002Ector((IEqualityComparer<System.__Canon>)0);
		object obj28 = this + 56;
		obj28 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj29 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v38+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v38+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v24+18]");
		Dictionary<System.__Canon, int> dictionary3 = default;
		dictionary3._002Ector((IEqualityComparer<System.__Canon>)0);
		object obj31 = this + 64;
		obj31 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
