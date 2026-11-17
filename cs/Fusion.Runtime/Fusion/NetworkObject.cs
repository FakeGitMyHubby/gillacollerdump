using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;
using UnityEngine;

namespace Fusion;

public class NetworkObject : Behaviour
{
	public sealed class EqualityComparer : Action<RemoveMatchmakingQueueResult>
	{
		public bool Equals(NetworkId a, NetworkId b)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = a - b;
			return obj == null;
		}

		public int GetHashCode(NetworkId id)
		{
			//IL_0005: Expected I4, but got VT
			return (int)id;
		}
	}

	public delegate bool ReplicateToDelegate(NetworkObject networkObject, PlayerRef player);

	[NonSerialized]
	internal unsafe int* Ptr;

	[NonSerialized]
	public bool IsResume;

	private NetworkRunner _runner;

	internal NetworkObjectMeta Meta;

	public uint SortKey;

	public int SendPriority = 1;

	[NonSerialized]
	public NetworkObjectGuid.List.PriorityLevelDelegate SendPriorityCallback;

	public bool EnableInterpolation = true;

	public NetworkObjectFlags Flags = (NetworkObjectFlags)262144;

	[NonSerialized]
	internal NetworkObjectRuntimeFlags RuntimeFlags;

	[NonSerialized]
	public NetworkObjectTypeId NetworkTypeId;

	public NetworkObject[] NestedObjects;

	public NetworkBehaviour[] NetworkedBehaviours;

	private RenderSource _renderSource;

	public bool ForceRemoteRenderTimeframe = false;

	internal unsafe ref NetworkObjectHeader Header
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return ref *(NetworkObjectHeader*)Ptr;
		}
	}

	internal unsafe Span<int> RawWords
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0055: Expected VT, but got I
			//IL_007b: Expected VT, but got I
			//IL_001f: Expected Obj, but got I8
			Span<int> span = (Span<int>)Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X19_v2 (System.Span`1<System.Int32>)+4]");
				object obj = 0 & -9223372036854775808L;
				if (obj != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			return (Span<int>)Ptr;
		}
	}

	public unsafe NetworkId Id
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006b: Expected VT, but got I
			//IL_001f: Expected Obj, but got I8
			//IL_0054: Expected VT, but got I4
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3 (System.Int32*)+4]");
				object obj = 0 & -9223372036854775808L;
				if (obj != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Span<int> span = default;
			if (span.IsEmpty)
			{
				return (NetworkId)0;
			}
			int* ptr2 = Ptr;
			return (NetworkId)ptr2;
		}
	}

	public NetworkRunner Runner
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _runner;
		}
	}

	public Tick LastReceiveTick
	{
		get
		{
			//IL_008f: Expected VT, but got I4
			//IL_0063: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			//IL_00a2: Expected VT, but got Obj
			NetworkObjectMeta meta = Meta;
			if (Meta != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Fusion.NetworkObjectMeta)+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Fusion.NetworkObjectMeta)+50]");
					NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = new NetworkObjectHeaderSnapshotRef((NetworkObjectHeaderSnapshot)0);
					object obj = 0;
					NullReferenceException ex = new NullReferenceException();
					return (Tick)ex;
				}
			}
			return (Tick)0;
		}
	}

	public bool IsRenderInterpolationReady
	{
		get
		{
			//IL_0274: Expected Obj, but got I
			//IL_029e: Expected Obj, but got I4
			//IL_0195: Expected I4, but got Obj
			//IL_00fd: Expected F8, but got VT
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected Obj, but got Unknown
			//IL_012a: Expected Obj, but got I4
			//IL_01c9: Invalid comparison between VT and I4
			//IL_01d8: Expected F8, but got I4
			//IL_0141: Expected F8, but got I4
			//IL_020d: Invalid comparison between F4 and I4
			//IL_0220: Expected Obj, but got F8
			//IL_022d: Expected Obj, but got F4
			NetworkObjectMeta meta = Meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool result;
			if ((bool)_runner)
			{
				NetworkRunner runner = _runner;
				if ((object)_runner == null)
				{
					goto IL_0187;
				}
				bool flag2 = Meta == null;
				result = false;
				if (!flag2)
				{
					bool flag3 = (object)runner._simulation == null;
					result = false;
					if (!flag3)
					{
						if ((object)_runner == null)
						{
							goto IL_0187;
						}
						float remoteRenderTime = _runner.RemoteRenderTime;
						double num = (_003F?)meta.InitialTick >> 32;
						object obj4 = (_003F?)meta.InitialTick & 0xFF;
						bool flag4 = obj4 == null;
						object obj5 = !flag4;
						double num2 = ((obj5 != null) ? num : 0.0);
						ref SimulationRuntimeConfig runtimeConfigRef = ref runner._simulation.RuntimeConfigRef;
						bool flag5 = runtimeConfigRef == (SimulationRuntimeConfig)(object)0;
						double num3 = 0.0;
						if (!flag5)
						{
							double num4 = 1.0 / (double)runtimeConfigRef;
							num3 = num4;
						}
						double num5 = num2 * num3;
						float num6 = remoteRenderTime - (float)num5;
						bool flag6 = num6 < 0f;
						object obj6 = (double)remoteRenderTime ^ num5;
						object obj7 = remoteRenderTime ^ num6;
						object obj8 = obj6 & obj7;
						bool flag7 = (nint)obj8 < 0;
						bool flag8 = flag6 == flag7;
						result = flag8;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
			IL_0187:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public unsafe string Name
	{
		get
		{
			//IL_0158: Expected Obj, but got I
			//IL_0168: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I8
			//IL_01bc: Expected Obj, but got I4
			//IL_0084: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I4
			//IL_010d: Expected Obj, but got I
			//IL_00bc: Expected Obj, but got I
			//IL_00cc: Expected Obj, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v4 (System.Int32*)+4]");
				object obj = 0 & -9223372036854775808L;
				if (obj != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj3 = 0;
			Span<int> span = default;
			if (span.IsEmpty)
			{
			}
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkId networkId = default;
			string text = networkId.ToString();
			object obj6 = RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			string text4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7100]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
				object obj9 = 0;
				string text2 = name;
				string text3 = (string)obj8 + text2 + (string)obj9;
				text4 = text3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj10 = 0;
				text4 = (string)obj10;
			}
			return text + text4;
		}
	}

	internal Simulation Simulation
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_009e: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = _runner;
			bool flag3 = !flag2;
			Simulation result = null;
			if (!flag3)
			{
				NetworkRunner runner = _runner;
				if ((object)_runner == null)
				{
					return (Simulation)(object)new NullReferenceException();
				}
				result = runner._simulation;
			}
			return result;
		}
	}

	public bool IsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0091: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_0081: Expected I4, but got Obj
			//IL_006d: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)_runner)
			{
				if ((object)_runner != null)
				{
					ArgumentNullException ex = new ArgumentNullException();
					return (byte)(int)ex != 0;
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			return false;
		}
	}

	public bool IsInSimulation
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObject)+5A]");
			return (byte)((nuint)0u & (nuint)1u) != 0;
		}
	}

	internal unsafe Span<int> Data
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_024d: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I8
			//IL_0054: Expected VT, but got I4
			//IL_013f: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I8
			//IL_01fd: Expected Obj, but got I
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_0225: Expected Obj, but got I4
			//IL_00af: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I4
			//IL_00e7: Expected Obj, but got I
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected Obj, but got Unknown
			//IL_0173: Expected VT, but got I
			int* ptr = Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
			object obj = 0;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X21_v1 (System.Int32*)+4]");
				object obj2 = 0 & -9223372036854775808L;
				if (obj2 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Span<int> span = default;
			if (span.IsEmpty)
			{
				return (Span<int>)0;
			}
			int* ptr2 = Ptr;
			int* ptr3;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X20_v6 (System.Int32*)+4]");
				object obj3 = 0 & -9223372036854775808L;
				if (obj3 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X20_v6 (System.Int32*)+4]");
				bool flag = (nint)0 < (nint)19;
				object obj5 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X20_v6 (System.Int32*)+4]");
				object obj6 = -19;
				bool flag2 = obj6 == null;
				object obj7 = obj4;
				object obj8 = ~obj5;
				object obj9 = obj8 | flag2;
				ptr3 = ptr2;
				if (obj9 == null)
				{
					goto IL_01e7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj10 = 0;
				object obj7 = obj10;
				ptr3 = Ptr;
			}
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			ptr2 = ptr3;
			goto IL_01e7;
			IL_01e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X21_v4+20]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			return (Span<int>)(ptr2 + 20);
		}
	}

	internal unsafe ReadOnlySpan<int> BehaviourChangedTickArray
	{
		get
		{
			//IL_00a6: Expected VT, but got I4
			//IL_016a: Expected I4, but got I8
			//IL_00e9: Expected Obj, but got I
			//IL_00fb: Expected Obj, but got I4
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0133: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0069: Expected Obj, but got I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected VT, but got Unknown
			NetworkObjectMeta meta = Meta;
			Span<int> span;
			if (Meta != null)
			{
				int num = (int)(meta.WordCount & 0x80000000L);
				bool flag = num == 0;
				short wordCount = meta.WordCount;
				if (!flag)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					wordCount = meta.WordCount;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj = 0;
				object obj2 = wordCount - meta.BehaviourCount;
				object obj3 = obj;
				meta = (NetworkObjectMeta)(meta.WordCount - obj2);
				bool flag2 = meta.WordCount < (nint)obj2;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X24_v3+20]");
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag3 = obj6 == null;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				span = (Span<int>)(meta._ptr + obj2);
			}
			else
			{
				span = (Span<int>)0;
			}
			return span;
		}
	}

	public unsafe bool HasInputAuthority
	{
		get
		{
			//IL_01b2: Expected Obj, but got I
			//IL_01dc: Expected Obj, but got I4
			//IL_01a2: Expected I4, but got Obj
			//IL_01f2: Expected I, but got Obj
			//IL_0202: Expected Obj, but got I
			//IL_0216: Expected Obj, but got I
			//IL_0240: Expected Obj, but got I4
			//IL_00fa: Expected I, but got Obj
			//IL_010a: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_016a: Expected Obj, but got I
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)_runner)
				{
					NetworkRunner runner = _runner;
					if ((object)_runner == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					Simulation simulation = runner._simulation;
					if ((object)runner._simulation != null)
					{
						int* ptr = Ptr;
						nint num = (nint)simulation;
						ushort num2 = ((Enum)(object)runner._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj4 = 0;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v13+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (num2 >= 1)
						{
							nint num3 = (nint)simulation;
							ushort num4 = ((Enum)(object)runner._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
							object obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v15+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v5 (System.Int32*)+1C]");
							object obj9 = -(int)num4;
							return obj9 == null;
						}
					}
				}
			}
			return false;
		}
	}

	public unsafe bool HasStateAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_01bd: Expected Obj, but got I
			//IL_01e7: Expected Obj, but got I4
			//IL_01ad: Expected I4, but got Obj
			//IL_012e: Expected Obj, but got I
			//IL_013e: Expected Obj, but got I
			//IL_0205: Expected Obj, but got I
			//IL_020d: Expected I, but got Obj
			//IL_023e: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected Obj, but got Unknown
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)_runner)
				{
					NetworkRunner runner = _runner;
					if ((object)_runner == null)
					{
						goto IL_019f;
					}
					Simulation simulation = runner._simulation;
					if ((object)runner._simulation != null)
					{
						SimulationConfig config = simulation._config;
						if (simulation._config == null)
						{
							goto IL_019f;
						}
						if (config.Topology != (Topologies)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
							object obj4 = 0;
							ushort num = ((Enum)(object)runner._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
							bool result = default;
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
						object obj5 = 0;
						nint num2 = (nint)simulation;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X9_v4 (Il2CppClass<Fusion.Simulation>)+130]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v20+130]");
						bool flag2 = num3 < 0;
						object obj7 = !flag2;
						if (obj7 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X9_v4 (Il2CppClass<Fusion.Simulation>)+B0]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v20+130]");
							object obj8 = num4 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X9_v6-8]");
							object obj9 = 0 - obj6;
							return obj9 == null;
						}
					}
				}
			}
			return false;
			IL_019f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public unsafe bool IsProxy
	{
		get
		{
			//IL_03b7: Expected Obj, but got I
			//IL_03e1: Expected Obj, but got I4
			//IL_0214: Expected Obj, but got I4
			//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fd: Expected I4, but got Unknown
			//IL_03a7: Expected I4, but got Obj
			//IL_0079: Expected Obj, but got I
			//IL_042c: Expected Obj, but got I4
			//IL_0442: Expected I, but got Obj
			//IL_0452: Expected Obj, but got I
			//IL_0462: Expected Obj, but got I
			//IL_0476: Expected Obj, but got I
			//IL_04a0: Expected Obj, but got I4
			//IL_04d8: Expected Obj, but got I4
			//IL_0179: Expected I, but got Obj
			//IL_0189: Expected Obj, but got I
			//IL_0199: Expected Obj, but got I
			//IL_01c7: Expected Obj, but got I4
			//IL_0328: Expected Obj, but got I
			//IL_0338: Expected Obj, but got I
			//IL_054b: Expected Obj, but got I4
			//IL_04f6: Expected Obj, but got I
			//IL_04fe: Expected I, but got Obj
			//IL_052f: Expected Obj, but got I4
			//IL_0368: Expected Obj, but got I
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4;
			if ((bool)_runner)
			{
				UnityEngine.Object runner = _runner;
				if ((object)_runner != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X20_v5 (UnityEngine.Object)+58]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X20_v5 (UnityEngine.Object)+58]");
					if ((nint)0 == 0)
					{
						goto IL_03ef;
					}
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v12+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((bool)_runner)
					{
						NetworkRunner runner2 = _runner;
						if ((object)_runner != null)
						{
							Simulation simulation = runner2._simulation;
							if ((object)runner2._simulation != null)
							{
								int* ptr = Ptr;
								nint num = (nint)simulation;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v15 (Il2CppClass<Fusion.Simulation>)+2A0]");
								object obj7 = 0;
								ushort num2 = ((Enum)(object)runner2._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								object obj8 = 0;
								object obj9 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v16+E4]");
								bool flag3 = (nint)0 == 0;
								object obj10 = !flag3;
								if (obj10 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (num2 >= 1)
								{
									nint num3 = (nint)simulation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v35 (Il2CppClass<Fusion.Simulation>)+2A0]");
									obj7 = 0;
									ushort num4 = ((Enum)(object)runner2._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
									object obj11 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v36+E4]");
									bool flag4 = (nint)0 == 0;
									object obj12 = !flag4;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X24_v5 (System.Int32*)+1C]");
									if ((nint)0 == (int)num4)
									{
										goto IL_020b;
									}
								}
								object obj13 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v22+E4]");
								bool flag5 = (nint)0 == 0;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if ((bool)_runner)
								{
									NetworkRunner runner3 = _runner;
									if ((object)_runner != null)
									{
										Simulation simulation2 = runner3._simulation;
										if ((object)runner3._simulation != null)
										{
											SimulationConfig config = simulation2._config;
											if (simulation2._config != null)
											{
												bool flag7 = default;
												if (config.Topology != (Topologies)1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
													object obj15 = 0;
													ushort num5 = ((Enum)(object)runner3._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
													object obj16 = 0;
													nint num6 = (nint)simulation2;
													object obj17 = obj16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X9_v9 (Il2CppClass<Fusion.Simulation>)+130]");
													nint num7 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32+130]");
													bool flag6 = num7 < 0;
													object obj18 = !flag6;
													if (obj18 == null)
													{
														flag7 = false;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X9_v9 (Il2CppClass<Fusion.Simulation>)+B0]");
														nint num8 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v32+130]");
														object obj19 = num8 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v11-8]");
														object obj20 = 0 - obj17;
														bool flag8 = obj20 == null;
														flag7 = flag8;
													}
												}
												obj4 = (flag7 ? 1 : 0) ^ 1;
												goto IL_03ef;
											}
										}
									}
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_020b;
			IL_03ef:
			return (byte)(obj4 & 1) != 0;
			IL_020b:
			obj4 = 0;
			goto IL_03ef;
		}
	}

	public bool IsNested
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)RuntimeFlags >> 2;
			return (byte)(obj & 1) != 0;
		}
	}

	public unsafe NetworkObject NestingRoot
	{
		get
		{
			//IL_011c: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0086: Expected Obj, but got I4
			//IL_00f3: Expected VT, but got I
			object obj = RuntimeFlags & (NetworkObjectRuntimeFlags)4;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = (UnityEngine.Object)_runner == (UnityEngine.Object)null;
				bool flag3 = !flag2;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					int* ptr = Ptr;
					if (Ptr != null)
					{
						if ((object)_runner != null)
						{
							NetworkRunner runner = _runner;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8 (System.Int32*)+10]");
							return runner.FindObject((NetworkId)0);
						}
						return (NetworkObject)(object)new NullReferenceException();
					}
				}
			}
			return null;
		}
	}

	public RenderTimeframe RenderTimeframe
	{
		get
		{
			//IL_003d: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I4
			//IL_0214: Expected I4, but got Obj
			//IL_01af: Expected Obj, but got I
			//IL_01bf: Expected Obj, but got I
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_0271: Expected Obj, but got I
			//IL_0279: Expected I, but got Obj
			//IL_02aa: Expected Obj, but got I4
			//IL_0173: Expected Obj, but got I
			if (~(ForceRemoteRenderTimeframe ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObject)+5A]");
				object obj = (nint)0 & (nint)1;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_01f8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)_runner)
				{
					NetworkRunner runner = _runner;
					if ((object)_runner == null)
					{
						goto IL_0206;
					}
					Simulation simulation = runner._simulation;
					if ((object)runner._simulation != null)
					{
						SimulationConfig config = simulation._config;
						if (simulation._config == null)
						{
							goto IL_0206;
						}
						if (config.Topology != (Topologies)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
							object obj6 = 0;
							ushort num = ((Enum)(object)runner._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
							object obj8 = default;
							object obj7 = obj8 & 1;
							if (obj7 != null)
							{
								goto IL_01f8;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
							object obj9 = 0;
							nint num2 = (nint)simulation;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X9_v4 (Il2CppClass<Fusion.Simulation>)+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v20+130]");
							bool flag3 = num3 < 0;
							object obj11 = !flag3;
							object obj12 = ~obj11;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X9_v4 (Il2CppClass<Fusion.Simulation>)+B0]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v20+130]");
								object obj13 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v6-8]");
								if (0 == (nint)obj10)
								{
									goto IL_01f8;
								}
							}
						}
					}
				}
			}
			return (RenderTimeframe)1;
			IL_01f8:
			return (RenderTimeframe)0;
			IL_0206:
			NullReferenceException ex = new NullReferenceException();
			return (RenderTimeframe)ex;
		}
	}

	public RenderSource RenderSource
	{
		get
		{
			return _renderSource;
		}
		set
		{
			_renderSource = value;
		}
	}

	public float RenderTime
	{
		get
		{
			//IL_00a5: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I4
			//IL_0081: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)_runner)
			{
				if (RenderTimeframe != 0)
				{
					return _runner.RemoteRenderTime;
				}
				return _runner.LocalRenderTime;
			}
			return 0f;
		}
	}

	public unsafe PlayerRef InputAuthority
	{
		get
		{
			//IL_002a: Expected Obj, but got I
			//IL_0054: Expected Obj, but got I4
			//IL_007a: Expected VT, but got I4
			//IL_0015: Expected VT, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Int32*)+1C]");
				return (PlayerRef)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (PlayerRef)0;
		}
	}

	public unsafe PlayerRef StateAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006f: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_00bc: Expected VT, but got I4
			//IL_00ca: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				NetworkRunner runner = _runner;
				if ((object)_runner != null && (object)runner._simulation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
					PlayerRef result = default;
					return result;
				}
				NullReferenceException ex = new NullReferenceException();
				return (PlayerRef)ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (PlayerRef)0;
		}
	}

	public bool IsSpawnable
	{
		get
		{
			//IL_0016: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObject)+56]");
			object obj = (nint)0 & (nint)1;
			return obj == null;
		}
		set
		{
			//IL_001a: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I8
			//IL_006e: Expected I4, but got Obj
			//IL_003a: Expected Obj, but got I4
			bool flag = !value;
			object obj = !flag;
			object obj2 = ~obj;
			object obj3 = ((obj2 != null) ? ((object)65536) : ((object)0));
			object obj4 = (long)Flags & 0xFFFEFFFFL;
			NetworkObjectFlags flags = (NetworkObjectFlags)(obj4 | obj3);
			Flags = flags;
		}
	}

	public NetworkObjectInterestModes ObjectInterest
	{
		get
		{
			return NetworkObjectFlagsExtensions.GetInterestMode(Flags);
		}
		set
		{
			NetworkObjectFlags flags = NetworkObjectFlagsExtensions.SetInterestMode(Flags, value);
			Flags = flags;
		}
	}

	protected unsafe virtual void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I8
		//IL_00da: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7108]");
		object error = 0;
		object obj = RuntimeFlags & (NetworkObjectRuntimeFlags)1;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		NetworkObjectRuntimeFlags runtimeFlags = RuntimeFlags | (NetworkObjectRuntimeFlags)1;
		RuntimeFlags = runtimeFlags;
		DebugAwake();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObject)+59]");
		object obj2 = (nint)0 & (nint)0x20;
		if (obj2 == null)
		{
			return;
		}
		int* ptr = Ptr;
		if (Ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v7 (System.Int32*)+4]");
			object obj3 = 0 & -9223372036854775808L;
			if (obj3 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj5 = 0;
		Span<int> span = default;
		bool flag;
		if (span.IsEmpty)
		{
			flag = true;
		}
		else
		{
			int* ptr2 = Ptr;
			bool flag2 = ptr2 == null;
			flag = flag2;
		}
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			if (flag)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = !flag;
			object obj7 = !flag3;
			if (obj7 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)_runner)
		{
			_runner.AttachActivatedByUser(this);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v22+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v23+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v23+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7110]");
			object obj15 = 0;
			object obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X9_v4+188] (should have been resolved before IL gen)");
		}
	}

	public unsafe bool SetPriority(PlayerRef player, int priority)
	{
		//IL_085a: Expected Obj, but got I4
		//IL_0abe: Expected Obj, but got I
		//IL_0ae8: Expected Obj, but got I4
		//IL_0851: Expected I4, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_0961: Expected Obj, but got I4
		//IL_0889: Expected Obj, but got I4
		//IL_097f: Expected Obj, but got I
		//IL_098f: Expected I, but got Obj
		//IL_09b8: Expected Obj, but got I4
		//IL_019b: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I
		//IL_0247: Invalid comparison between I4 and VT
		//IL_04cc: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_09f0: Expected Obj, but got I4
		//IL_08c1: Expected Obj, but got I4
		//IL_090d: Expected Obj, but got I
		//IL_0580: Expected I, but got Obj
		//IL_0590: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I4
		//IL_07e1: Expected VT, but got I
		//IL_02f8: Expected Obj, but got I8
		//IL_05f3: Invalid comparison between I4 and VT
		//IL_0a76: Expected Obj, but got I
		//IL_0aa0: Expected Obj, but got I4
		//IL_07ca: Expected VT, but got I4
		//IL_0629: Expected Obj, but got I4
		//IL_0a36: Expected Obj, but got I4
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected VT, but got Unknown
		//IL_078e: Expected VT, but got I
		object obj = 109891584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)_runner)
		{
			UnityEngine.Object runner = _runner;
			if ((object)_runner != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X22_v4 (UnityEngine.Object)+58]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X22_v4 (UnityEngine.Object)+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+60]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+60]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v8+40]");
						if ((nint)0 == 2)
						{
							object obj7 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v62+E4]");
							bool flag2 = (nint)0 == 0;
							object obj8 = !flag2;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((bool)_runner)
							{
								NetworkRunner runner2 = _runner;
								if ((object)_runner != null)
								{
									Simulation simulation = runner2._simulation;
									if ((object)runner2._simulation != null)
									{
										nint num = (nint)simulation;
										ushort num2 = ((Enum)(object)runner2._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
										object obj9 = 0;
										object obj10 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v56+E4]");
										bool flag3 = (nint)0 == 0;
										object obj11 = !flag3;
										if (obj11 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj12 = num2 - player;
										bool condition = obj12 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7138]");
										object error = 0;
										Assert.Check(condition, (string)error);
										if ((object)num2 != (object)player)
										{
											goto IL_049c;
										}
										object obj13 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v71+E4]");
										bool flag4 = (nint)0 == 0;
										object obj14 = !flag4;
										if (obj14 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag5 = _runner;
										bool flag6 = !flag5;
										Simulation simulation2 = null;
										if (!flag6)
										{
											NetworkRunner runner3 = _runner;
											if ((object)_runner == null)
											{
												goto IL_0843;
											}
											simulation2 = runner3._simulation;
										}
										int* ptr = Ptr;
										if (Ptr != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X22_v18 (System.Int32*)+4]");
											object obj15 = 0 & -9223372036854775808L;
											if (obj15 != null)
											{
												System.ThrowHelper.ThrowArgumentOutOfRangeException();
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
										object obj16 = 0;
										Span<int> span = default;
										NetworkId id;
										if (span.IsEmpty)
										{
											id = (NetworkId)0;
										}
										else
										{
											int* ptr2 = Ptr;
											id = (NetworkId)ptr2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj17 = 0;
										object obj18 = obj17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v80+E4]");
										bool flag7 = (nint)0 == 0;
										object obj19 = !flag7;
										if (obj19 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int priority2 = Math.Max(0, priority);
										if ((object)simulation2 != null)
										{
											return simulation2.SetPriorityOfObjectForLocalPlayerInSharedMode(id, priority2);
										}
									}
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA41]");
							bool flag8 = (nint)0 == 0;
							object obj20 = !flag8;
							if (obj20 == null)
							{
								_ = 1;
							}
							object obj21 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v14+E4]");
							bool flag9 = (nint)0 == 0;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((bool)_runner)
							{
								NetworkRunner runner4 = _runner;
								if ((object)_runner != null)
								{
									Simulation simulation3 = runner4._simulation;
									if ((object)runner4._simulation != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
										object obj23 = 0;
										object obj24 = obj23;
										nint num3 = (nint)simulation3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v19 (Il2CppClass<Fusion.Simulation>)+130]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X22_v9+130]");
										bool flag10 = num4 < 0;
										object obj25 = !flag10;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7130]");
											object error2 = 0;
											Assert.Check(condition: false, (string)error2);
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v19 (Il2CppClass<Fusion.Simulation>)+B0]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X22_v9+130]");
											object obj26 = num5 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7130]");
											object error3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v21-8]");
											object obj27 = 0 - obj24;
											bool condition2 = obj27 == null;
											Assert.Check(condition2, (string)error3);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v21-8]");
											if (0 == (nint)obj24)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X23_v1+A41]");
												bool flag11 = (nint)0 == 0;
												object obj28 = !flag11;
												if (obj28 == null)
												{
													_ = 1;
												}
												object obj29 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v21+E4]");
												bool flag12 = (nint)0 == 0;
												object obj30 = !flag12;
												if (obj30 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												if ((bool)_runner)
												{
													NetworkRunner runner5 = _runner;
													if ((object)_runner != null)
													{
														Simulation simulation4 = runner5._simulation;
														if ((object)runner5._simulation != null)
														{
															nint num6 = (nint)simulation4;
															ushort num7 = ((Enum)(object)runner5._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
															object obj31 = 0;
															object obj32 = obj31;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v31+E4]");
															bool flag13 = (nint)0 == 0;
															object obj33 = !flag13;
															if (obj33 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															if ((object)num7 == (object)player)
															{
																goto IL_09fe;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X23_v1+A41]");
															bool flag14 = (nint)0 == 0;
															object obj34 = !flag14;
															if (obj34 == null)
															{
																_ = 1;
															}
															object obj35 = obj2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v31+E4]");
															bool flag15 = (nint)0 == 0;
															object obj36 = !flag15;
															if (obj36 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															if ((bool)_runner)
															{
																NetworkRunner runner6 = _runner;
																if ((object)_runner != null)
																{
																	Simulation simulation5 = runner6._simulation;
																	if ((object)runner6._simulation != null && (object)simulation5._playersConnections != null)
																	{
																		PlayerRef key = (PlayerRef)(player & 0xFFFFFFFFL);
																		if (!((Dictionary<PlayerRef, System.__Canon>)(object)simulation5._playersConnections).TryGetValue(key, out System.__Canon value))
																		{
																			goto IL_049c;
																		}
																		NetworkObjectMeta meta = Meta;
																		if (Meta != null && value != null)
																		{
																			int* ptr3 = meta._ptr;
																			NetworkObjectConnectionData objectData = ((SimulationConnection)(object)value).GetObjectData((NetworkId)ptr3, true, false);
																			if (objectData != null)
																			{
																				objectData.PriorityLevel = priority;
																				goto IL_09fe;
																			}
																		}
																	}
																}
															}
														}
													}
												}
												goto IL_0843;
											}
										}
										goto IL_049c;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0843;
		IL_0843:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_09fe:
		return true;
		IL_049c:
		return false;
	}

	public bool ClearPriority(PlayerRef player)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		PlayerRef player2 = (PlayerRef)(player & 0xFFFFFFFFL);
		return SetPriority(player2, 1);
	}

	protected virtual void OnDestroy()
	{
		OnDestroyInternal();
		DebugOnDestroy(wasActive: true);
	}

	internal void OnDestroyNeverActive()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected I4, but got Unknown
		//IL_0072: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7160]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7168]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7178]");
		object format2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7180]");
		object error = 0;
		object obj2 = RuntimeFlags & (NetworkObjectRuntimeFlags)1;
		bool condition = obj2 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
		DumpDeferredClass arg = default;
		Assert.Check(condition, (string)format, arg);
		object obj3 = (int)RuntimeFlags >> 13;
		bool condition2 = (byte)(obj3 & 1) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
		DumpDeferredClass arg2 = default;
		Assert.Check(condition2, (string)format2, arg2);
		OnDestroyInternal();
		object obj4 = RuntimeFlags & (NetworkObjectRuntimeFlags)0x800000;
		bool condition3 = obj4 == null;
		Assert.Check(condition3, (string)error);
		DebugOnDestroy(wasActive: false);
	}

	private unsafe void OnDestroyInternal()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I4
		//IL_0401: Expected I, but got Obj
		//IL_047e: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I8
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I4
		if ((object)this == null)
		{
			return;
		}
		object obj = RuntimeFlags & (NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		NetworkObjectRuntimeFlags runtimeFlags = RuntimeFlags | (NetworkObjectRuntimeFlags)2;
		RuntimeFlags = runtimeFlags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkObjectDestroyFlags flags;
		if ((bool)_runner)
		{
			if (Ptr != null)
			{
				NetworkRunner runner = _runner;
				if ((object)runner._simulation != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj7 = default;
					object obj6 = obj7 & 1;
					if (obj6 != null)
					{
						flags = (NetworkObjectDestroyFlags)3;
					}
					else
					{
						int* ptr = Ptr;
						bool flag4;
						if (Ptr != null)
						{
							NetworkRunner runner2 = _runner;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v42 (System.Int32*)+20]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
							object obj9 = default;
							bool flag3 = obj9 == null;
							flag4 = flag3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
							object obj10 = 0;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v41+E4]");
							bool flag5 = (nint)0 == 0;
							object obj12 = !flag5;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj8 = 0;
							flag4 = true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj13 = 0;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v36+E4]");
						bool flag6 = (nint)0 == 0;
						object obj15 = !flag6;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!flag4)
						{
							goto IL_03d7;
						}
						NetworkRunner runner3 = _runner;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D7058");
						object obj17 = default;
						object obj16 = obj17 & 1;
						bool flag7 = obj16 == null;
						object obj18 = !flag7;
						object obj19 = ~obj18;
						flags = ((obj19 != null) ? ((NetworkObjectDestroyFlags)1) : ((NetworkObjectDestroyFlags)3));
					}
					goto IL_03e5;
				}
			}
			goto IL_03d7;
		}
		if ((object)_runner != null)
		{
			int* ptr2 = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X20_v8 (System.Int32*)+4]");
				object obj20 = 0 & -9223372036854775808L;
				if (obj20 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
			object obj21 = 0;
			Span<int> span = default;
			bool flag8;
			if (span.IsEmpty)
			{
				flag8 = true;
			}
			else
			{
				int* ptr3 = Ptr;
				bool flag9 = ptr3 == null;
				flag8 = flag9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = !flag8;
			object obj25 = !flag11;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj26 = 0;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+A0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v24+10]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v24+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7140]");
					object obj30 = 0;
					object obj31 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X9_v6+188] (should have been resolved before IL gen)");
				}
			}
		}
		goto IL_03fa;
		IL_03e5:
		_runner.DestroyNetworkObjectInternal(this, flags);
		goto IL_03fa;
		IL_03fa:
		Ptr = (int*)unchecked((nint)null);
		return;
		IL_03d7:
		flags = (NetworkObjectDestroyFlags)1;
		goto IL_03e5;
	}

	public bool ResetToLatestState()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_0132: Expected I4, but got Obj
		//IL_0088: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj2 = default;
		object obj = obj2 & 1;
		bool flag = obj == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			if ((object)_runner == null)
			{
				goto IL_0124;
			}
			bool isResimulation = _runner.IsResimulation;
			bool flag2 = !isResimulation;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				NetworkObjectMeta meta = Meta;
				if (Meta == null)
				{
					goto IL_0124;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v4 (Fusion.NetworkObjectMeta)+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v4 (Fusion.NetworkObjectMeta)+50]");
					NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = new NetworkObjectHeaderSnapshotRef((NetworkObjectHeaderSnapshot)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D70FC");
					return true;
				}
			}
		}
		return false;
		IL_0124:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	internal void ResetNetworkState()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I8
		object obj = this + 48;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X19_v2+28]");
		object obj2 = 0 & 0xF000FFFFL;
	}

	internal unsafe void Defaults()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7198]");
		object error = 0;
		bool flag = Ptr == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		int* ptr = Ptr;
		_ = 0;
		int* ptr2 = Ptr;
		_ = 0;
	}

	public static int GetWordCount(NetworkObject obj)
	{
		//IL_0030: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_028a: Expected I4, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		int result;
		if ((object)obj != null)
		{
			object obj2 = obj.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				int behaviourDataOffset = GetBehaviourDataOffset(obj);
				NetworkBehaviour[] networkedBehaviours = obj.NetworkedBehaviours;
				bool flag2 = obj.NetworkedBehaviours == null;
				result = behaviourDataOffset;
				if (!flag2)
				{
					object obj4 = 0;
					int num = behaviourDataOffset;
					string text2 = default;
					string text3 = default;
					Exception ex = default;
					while ((nint)obj4 < networkedBehaviours.Length)
					{
						bool flag3 = (nint)obj4 < networkedBehaviours.Length;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							object obj6 = (object)networkedBehaviours + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
							NetworkBehaviour networkBehaviour = (NetworkBehaviour)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
							if ((nint)0 != 0)
							{
								object obj7 = networkBehaviour.Flags & (SimulationBehaviourRuntimeFlags)8;
								bool flag4 = obj7 == null;
								object obj8 = !flag4;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
									int wordCount = NetworkBehaviourUtils.GetWordCount((NetworkBehaviour)0);
									networkedBehaviours = obj.NetworkedBehaviours;
									num = wordCount + num;
									obj4++;
									bool flag5 = obj.NetworkedBehaviours == null;
									object obj9 = !flag5;
									if (obj9 == null)
									{
										throw new NullReferenceException();
									}
									continue;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
							string text = obj.Name;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							string message = text2 + text + text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							ex._002Ector(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex2 = new ArgumentNullException();
						}
						IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
						return (int)ex3;
					}
					result = num + networkedBehaviours.Length;
				}
				goto IL_028a;
			}
		}
		result = 0;
		goto IL_028a;
		IL_028a:
		return result;
	}

	internal static int GetBehaviourDataOffset(NetworkObjectFlags flags)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		object obj = flags & (NetworkObjectFlags)0x100;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			return 34;
		}
		return 20;
	}

	internal unsafe static int GetBehaviourDataOffset(NetworkObject networkObject)
	{
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_07b5: Expected I4, but got Obj
		//IL_0811: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_06b7: Expected Obj, but got I
		//IL_06bf: Expected I, but got Obj
		//IL_06f0: Expected Obj, but got I4
		//IL_0740: Expected Obj, but got I
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_029e: Expected I, but got Obj
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I8
		//IL_035e: Expected I, but got Obj
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_041b: Expected I, but got Obj
		//IL_0494: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0431: Expected I, but got Obj
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_04f5: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I8
		//IL_054b: Expected I, but got Obj
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_05fb: Expected Obj, but got I
		//IL_062b: Expected I, but got Obj
		if ((object)networkObject == null)
		{
			goto IL_077c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkObject @ X0 (Fusion.NetworkObject)+55]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		IndexOutOfRangeException ex = default;
		if (obj2 == null)
		{
			NetworkBehaviour[] networkedBehaviours = networkObject.NetworkedBehaviours;
			if (networkObject.NetworkedBehaviours == null)
			{
				goto IL_06fe;
			}
			if (networkedBehaviours.Length != 0)
			{
				if (networkedBehaviours.Length == 0)
				{
					goto IL_078a;
				}
				NetworkBehaviour networkBehaviour = networkedBehaviours[0];
				if ((object)networkedBehaviours[0] != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71C0]");
					object obj3 = 0;
					object obj4 = obj3;
					nint num = (nint)networkBehaviour;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v20 (Il2CppClass<Fusion.NetworkBehaviour>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X9_v15+130]");
					bool flag2 = num2 < 0;
					object obj5 = !flag2;
					object obj6 = ~obj5;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v20 (Il2CppClass<Fusion.NetworkBehaviour>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X9_v15+130]");
						object obj7 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v10-8]");
						if (0 == (nint)obj4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v20 (Il2CppClass<Fusion.NetworkBehaviour>)+170]");
							nint num4 = 0;
							bool flag3 = ((ValueType)(object)networkedBehaviours[0]).Equals((object)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
							object obj8 = 0;
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v23+A0]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v24+18]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v24+18]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object[] array = default;
								bool flag4 = array == null;
								object obj14 = default;
								num4 = (nint)(&obj14);
								if (flag4)
								{
									goto IL_077c;
								}
								IntPtr intPtr = default;
								bool flag5 = intPtr == (IntPtr)0;
								nint num5 = (nint)(&obj14);
								if (!flag5)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
									num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag6 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
									num4 = 0;
									if (flag6)
									{
										goto IL_0798;
									}
								}
								bool flag7 = array.Length == 0;
								num4 = num5;
								if (!flag7)
								{
									object obj15 = array + 32;
									obj15 = (nint)intPtr;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag8 = networkObject.NetworkedBehaviours == null;
									nint num7 = intPtr;
									if (!flag8)
									{
										nint num8 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
										num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag9 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
										num4 = 0;
										if (flag9)
										{
											goto IL_0798;
										}
									}
									object obj16 = array.Length & 0xFFFFFFFEL;
									bool flag10 = obj16 == null;
									num4 = num7;
									if (!flag10)
									{
										object obj17 = array + 40;
										obj17 = networkObject.NetworkedBehaviours;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag11 = !flag3;
										nint num9 = (nint)networkObject.NetworkedBehaviours;
										if (!flag11)
										{
											nint num10 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
											num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag12 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
											num4 = 0;
											if (flag12)
											{
												goto IL_0798;
											}
										}
										bool flag13 = array.Length < 2;
										object obj18 = !flag13;
										object obj19 = array.Length - 2;
										bool flag14 = obj19 == null;
										object obj20 = ~obj18;
										object obj21 = obj20 | flag14;
										num4 = num9;
										if (obj21 == null)
										{
											object obj22 = array + 48;
											obj22 = flag3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71B8]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj24 = default;
											bool flag15 = obj24 == null;
											object obj25 = default;
											nint num11 = (nint)(&obj25);
											if (!flag15)
											{
												nint num12 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
												num11 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag16 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
												num4 = 0;
												if (flag16)
												{
													goto IL_0798;
												}
											}
											object obj26 = array.Length & 0xFFFFFFFCL;
											bool flag17 = obj26 == null;
											num4 = num11;
											if (!flag17)
											{
												object obj27 = array + 56;
												obj27 = obj24;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71C8]");
												object format = 0;
												string text = string.Format((string)format, array);
												object obj28 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ X8_v41+198] (should have been resolved before IL gen)");
												num4 = (nint)text;
												goto IL_07d2;
											}
										}
									}
								}
								goto IL_078a;
							}
						}
					}
				}
			}
			goto IL_07d2;
		}
		bool condition = true;
		int result = 20;
		goto IL_0801;
		IL_0801:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71D0]");
		object error = 0;
		Assert.Check(condition, (string)error);
		return result;
		IL_0798:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
		IL_078a:
		ex = new IndexOutOfRangeException();
		goto IL_0798;
		IL_077c:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_078a;
		IL_06fe:
		condition = true;
		goto IL_0823;
		IL_07d2:
		NetworkBehaviour[] networkedBehaviours2 = networkObject.NetworkedBehaviours;
		if (networkObject.NetworkedBehaviours != null && networkedBehaviours2.Length != 0)
		{
			if (networkedBehaviours2.Length == 0)
			{
				goto IL_078a;
			}
			NetworkBehaviour networkBehaviour2 = networkedBehaviours2[0];
			if ((object)networkedBehaviours2[0] != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71C0]");
				object obj29 = 0;
				nint num13 = (nint)networkBehaviour2;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v11 (Il2CppClass<Fusion.NetworkBehaviour>)+130]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17+130]");
				bool flag18 = num14 < 0;
				object obj31 = !flag18;
				if (obj31 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v11 (Il2CppClass<Fusion.NetworkBehaviour>)+B0]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17+130]");
					object obj32 = num15 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X9_v13-8]");
					object obj33 = 0 - obj30;
					bool flag19 = obj33 == null;
					bool flag20 = !flag19;
					condition = flag20;
					goto IL_0823;
				}
			}
		}
		goto IL_06fe;
		IL_0823:
		result = 34;
		goto IL_0801;
	}

	public unsafe int GetLocalAuthorityMask()
	{
		//IL_00cc: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_00bc: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)_runner)
		{
			NetworkRunner runner = _runner;
			if ((object)_runner == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			if ((object)runner._simulation != null)
			{
				return runner._simulation.GetLocalAuthorityMask(ref *(NetworkObjectHeader*)Ptr);
			}
		}
		return 0;
	}

	public unsafe void AssignInputAuthority(PlayerRef player)
	{
		//IL_0546: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I
		//IL_0580: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_0311: Invalid comparison between VT and I4
		//IL_04f0: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_025d: Expected VT, but got I
		//IL_0278: Expected Obj, but got Ref
		//IL_0288: Expected Obj, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected VT, but got Unknown
		//IL_02bc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition = _runner;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E8]");
		object error2 = 0;
		ArgumentNullException ex = new ArgumentNullException();
		bool condition2 = (byte)(ex & 1) != 0;
		Assert.Check(condition2, (string)error2);
		object obj4 = player & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D71F4");
		object obj6 = default;
		object obj5 = obj6 & 1;
		if (obj5 != null)
		{
			int* ptr = Ptr;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = _runner;
			NetworkRunner runner = _runner;
			Simulation simulation = runner._simulation;
			SimulationConfig config = simulation._config;
			object obj9 = config.ReplicationFeatures & (NetworkProjectConfig.ReplicationFeatures)2;
			if (obj9 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v27+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BE0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v18 (System.Int32*)+1C]");
			bool flag5 = (nint)0 < (nint)1;
			object obj14 = 0;
			NetworkObjectMeta networkObjectMeta = null;
			if (!flag5)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v51+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = _runner;
				NetworkRunner runner2 = _runner;
				Simulation simulation2 = runner2._simulation;
				obj14 = obj13;
				Dictionary<PlayerRef, SimulationConnection> playersConnections = simulation2._playersConnections;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v18 (System.Int32*)+1C]");
				bool flag8 = ((Dictionary<PlayerRef, System.__Canon>)(object)playersConnections).TryGetValue((PlayerRef)0, out System.__Canon value);
				bool flag9 = !flag8;
				obj4 = (object)(&value);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v18 (System.Int32*)+1C]");
				networkObjectMeta = (NetworkObjectMeta)0;
				if (!flag9)
				{
					networkObjectMeta = Meta;
					bool flag10 = ((SimulationConnection)(object)value).RemoveAlwaysInterested(Meta);
					obj4 = 0;
				}
			}
			object obj17 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v30+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (player >= (object)1)
			{
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v33+E4]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = _runner;
				NetworkRunner runner3 = _runner;
				Simulation simulation3 = runner3._simulation;
				PlayerRef key = (PlayerRef)(player & 0xFFFFFFFFL);
				if (((Dictionary<PlayerRef, System.__Canon>)(object)simulation3._playersConnections).TryGetValue(key, out System.__Canon value2))
				{
					bool flag14 = ((SimulationConnection)(object)value2).AddAlwaysInterested(Meta);
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v10+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v11+10]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v11+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71D8]");
				object format = 0;
				object arg = default;
				string text = string.Format((string)format, arg);
				object obj26 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X8_v17+188] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe bool RequestStateAuthority()
	{
		//IL_01ce: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I4
		//IL_0169: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_0151: Expected VT, but got I
		//IL_00f7: Expected Obj, but got I8
		//IL_013a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition = _runner;
		Assert.Check(condition, (string)error);
		if ((object)_runner != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E8]");
			object error2 = 0;
			ArgumentNullException ex = new ArgumentNullException();
			bool condition2 = (byte)(ex & 1) != 0;
			Assert.Check(condition2, (string)error2);
			NetworkRunner runner = _runner;
			if ((object)_runner == null || (object)runner._simulation == null)
			{
				return false;
			}
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v8 (System.Int32*)+4]");
				object obj4 = 0 & -9223372036854775808L;
				if (obj4 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Span<int> span = default;
			NetworkId id;
			if (span.IsEmpty)
			{
				id = (NetworkId)0;
			}
			else
			{
				int* ptr2 = Ptr;
				id = (NetworkId)ptr2;
			}
			return runner._simulation.RequestStateAuthority(id, wants: true);
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public unsafe bool ReleaseStateAuthority()
	{
		//IL_01ce: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I4
		//IL_0169: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I4, but got Unknown
		//IL_0151: Expected VT, but got I
		//IL_00f7: Expected Obj, but got I8
		//IL_013a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition = _runner;
		Assert.Check(condition, (string)error);
		if ((object)_runner != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71E8]");
			object error2 = 0;
			ArgumentNullException ex = new ArgumentNullException();
			bool condition2 = (byte)(ex & 1) != 0;
			Assert.Check(condition2, (string)error2);
			NetworkRunner runner = _runner;
			if ((object)_runner == null || (object)runner._simulation == null)
			{
				return false;
			}
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v8 (System.Int32*)+4]");
				object obj4 = 0 & -9223372036854775808L;
				if (obj4 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Span<int> span = default;
			NetworkId id;
			if (span.IsEmpty)
			{
				id = (NetworkId)0;
			}
			else
			{
				int* ptr2 = Ptr;
				id = (NetworkId)ptr2;
			}
			return runner._simulation.RequestStateAuthority(id, wants: false);
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public void RemoveInputAuthority()
	{
		//IL_000b: Expected VT, but got I4
		AssignInputAuthority((PlayerRef)0);
	}

	public unsafe static implicit operator NetworkId(NetworkObject obj)
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0093: Expected VT, but got I
		//IL_0044: Expected Obj, but got I8
		//IL_0079: Expected VT, but got I4
		bool flag = (object)obj == null;
		NetworkId result = (NetworkId)obj;
		if (!flag)
		{
			int* ptr = obj.Ptr;
			if (obj.Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X20_v4 (System.Int32*)+4]");
				object obj2 = 0 & -9223372036854775808L;
				if (obj2 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Span<int> span = default;
			if (span.IsEmpty)
			{
				result = (NetworkId)0;
			}
			else
			{
				int* ptr2 = obj.Ptr;
				result = (NetworkId)ptr2;
			}
		}
		return result;
	}

	public bool SetPlayerAlwaysInterested(PlayerRef player, bool alwaysInterested)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got Unknown
		//IL_00dc: Expected I4, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj2 = default;
		object obj = obj2 & 1;
		if (obj != null)
		{
			NetworkRunner runner = _runner;
			if ((object)_runner != null)
			{
				NetworkId id = this;
				if ((object)runner._simulation != null)
				{
					PlayerRef player2 = (PlayerRef)(player & 0xFFFFFFFFL);
					runner._simulation.SetPlayerAlwaysInterested(player2, id, alwaysInterested);
					goto IL_00bb;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_00bb;
		IL_00bb:
		return (byte)(obj2 & 1) != 0;
	}

	public unsafe void CopyStateFrom(NetworkObject source)
	{
		//IL_0451: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I
		//IL_0024: Expected Obj, but got I8
		//IL_04a3: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I4
		//IL_0055: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I8
		//IL_00fa: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I
		//IL_0570: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I8
		//IL_05aa: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05d7: Expected Obj, but got I
		//IL_0164: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01e4: Expected VT, but got I
		//IL_01f9: Expected VT, but got I
		//IL_01f9: Expected Ref, but got VT
		//IL_022f: Expected VT, but got Obj
		//IL_025d: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected I4, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0381: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I4
		int* ptr = source.Ptr;
		if (source.Ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X24_v4 (System.Int32*)+4]");
			object obj = 0 & -9223372036854775808L;
			if (obj != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj3 = 0;
		Span<int> span = default;
		nint num;
		if (span.IsEmpty)
		{
			num = unchecked((nint)null);
		}
		else
		{
			int* ptr2 = source.Ptr;
			num = (nint)ptr2;
		}
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7200]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = num == 0;
		bool condition = !flag2;
		Assert.Check(condition, (string)error);
		int* ptr3 = source.Ptr;
		if (source.Ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X24_v6 (System.Int32*)+4]");
			object obj6 = 0 & -9223372036854775808L;
			if (obj6 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		nint num2;
		if (span.IsEmpty)
		{
			num2 = unchecked((nint)null);
		}
		else
		{
			int* ptr4 = source.Ptr;
			num2 = (nint)ptr4;
		}
		int* ptr5 = Ptr;
		if (Ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X22_v5 (System.Int32*)+4]");
			object obj7 = 0 & -9223372036854775808L;
			if (obj7 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7218]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7198]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7210]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj8 = 0;
		nint num3;
		if (span.IsEmpty)
		{
			num3 = unchecked((nint)null);
		}
		else
		{
			int* ptr6 = Ptr;
			num3 = (nint)ptr6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7208]");
		object error5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F0]");
		object obj10 = 0;
		object obj11 = num2 - num3;
		bool condition2 = obj11 == null;
		Assert.Check(condition2, (string)error2);
		bool flag3 = Ptr == null;
		bool condition3 = !flag3;
		Assert.Check(condition3, (string)error3);
		bool flag4 = source.Ptr == null;
		bool condition4 = !flag4;
		Assert.Check(condition4, (string)error4);
		object obj12 = obj8;
		int* ptr7 = source.Ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)(Ptr + 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v26 (System.Int32*)+8]");
		bool condition5 = ((NetworkObjectTypeId*)networkObjectTypeId)->Equals((NetworkObjectTypeId)0);
		Assert.Check(condition5, (string)error5);
		ArgumentNullException ex = new ArgumentNullException();
		ArgumentNullException ex2 = new ArgumentNullException();
		ReadOnlySpan<int> readOnlySpan = (Span<int>)ex2;
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X25_v11+38]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X25_v11+38]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		bool flag8 = 0 < 0;
		bool flag9 = 0 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D28]");
		object obj17 = 0;
		bool flag10 = flag8 == flag9;
		object obj18 = !flag10;
		bool condition6 = (byte)(obj18 | 1) != 0;
		Assert.Check(condition6, 0, 0);
		NetworkObject[] nestedObjects = NestedObjects;
		object obj19 = 4;
		while (true)
		{
			object obj20 = obj19 - 4;
			if ((nint)obj20 < nestedObjects.Length)
			{
				bool flag11 = (nint)obj20 < nestedObjects.Length;
				object obj21 = !flag11;
				if (obj21 != null)
				{
					break;
				}
				NetworkObject[] nestedObjects2 = source.NestedObjects;
				bool flag12 = (nint)obj20 < nestedObjects2.Length;
				object obj22 = !flag12;
				if (obj22 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v33 (Fusion.NetworkObject[])+v159 @ X21_v13*8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X10_v6 (Fusion.NetworkObject[])+v159 @ X21_v13*8]");
				((NetworkObject)num4).CopyStateFrom((NetworkObject)0);
				nestedObjects = NestedObjects;
				obj19++;
				bool flag13 = NestedObjects == null;
				object obj23 = !flag13;
				if (obj23 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe void CopyStateFrom(NetworkObjectHeaderPtr source)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00ac: Expected VT, but got I
		//IL_00c1: Expected VT, but got I
		//IL_00c1: Expected Ref, but got VT
		//IL_0129: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected I4, but got Unknown
		//IL_0159: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7198]");
		object error = 0;
		bool flag = Ptr == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7208]");
		object error2 = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)(Ptr + 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X1 (Fusion.NetworkObjectHeaderPtr)+8]");
		bool condition2 = ((NetworkObjectTypeId*)networkObjectTypeId)->Equals((NetworkObjectTypeId)0);
		Assert.Check(condition2, (string)error2);
		ArgumentNullException ex = new ArgumentNullException();
		NetworkObjectHeaderPtr networkObjectHeaderPtr = default;
		Span<int> span = networkObjectHeaderPtr.Data;
		ReadOnlySpan<int> readOnlySpan = span;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v3+38]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X23_v3+38]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		bool flag5 = 0 < 0;
		bool flag6 = 0 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D28]");
		object obj9 = 0;
		bool flag7 = flag5 == flag6;
		object obj10 = !flag7;
		bool condition3 = (byte)(obj10 | 1) != 0;
		Assert.Check(condition3, 0, 0);
	}

	public static NetworkId NetworkWrap(NetworkRunner runner, NetworkObject obj)
	{
		return NetworkWrap(obj);
	}

	public unsafe static NetworkId NetworkWrap(NetworkObject obj)
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0038: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_00b4: Expected VT, but got I4
		//IL_00ce: Expected VT, but got I
		//IL_007f: Expected Obj, but got I8
		bool flag = (object)obj == null;
		NetworkId result = (NetworkId)obj;
		if (!flag)
		{
			object obj2 = obj.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				int* ptr = obj.Ptr;
				if (obj.Ptr != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v7 (System.Int32*)+4]");
					object obj4 = 0 & -9223372036854775808L;
					if (obj4 != null)
					{
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
					}
				}
				Span<int> span = default;
				if (!span.IsEmpty)
				{
					int* ptr2 = obj.Ptr;
					result = (NetworkId)ptr2;
					goto IL_00d3;
				}
			}
			result = (NetworkId)0;
		}
		goto IL_00d3;
		IL_00d3:
		return result;
	}

	public unsafe static void NetworkUnwrap(NetworkRunner runner, NetworkId wrapper, ref NetworkObject result)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		//IL_003f: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId networkId = (NetworkId)(wrapper & 0xFFFFFFFFL);
		if (networkId != (NetworkId)(object)0)
		{
			if (!runner.TryFindObject(networkId, out result))
			{
				runner.InvokeFailedToResolveNetworkObject(networkId);
			}
		}
		else
		{
			ref NetworkObject reference = ref *(NetworkObject*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void MakeOwned(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7228]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7220]");
		object obj3 = 0;
		object obj4 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition = (UnityEngine.Object)obj4 == null;
		Assert.Check(condition, (string)format, (System.__Canon)obj4);
		obj4 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void MakeUnowned()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 48;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void DebugAwake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7118]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7120]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			string text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v2+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X9_v5+188] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObject)+5A]");
		object obj8 = (nint)0 & (nint)0x80;
		if (obj8 != null)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v9+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v9+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7128]");
				object obj12 = 0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X9_v3+188] (should have been resolved before IL gen)");
			}
		}
	}

	private void DebugOnDestroy(bool wasActive)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7118]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7158]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			string text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X22_v2+10]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ X9_v5+188] (should have been resolved before IL gen)");
		}
		object obj11;
		if (wasActive)
		{
			object obj8 = RuntimeFlags & (NetworkObjectRuntimeFlags)0x800000;
			if (obj8 == null)
			{
				return;
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v14+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v15+18]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v15+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7148]");
			object obj12 = 0;
		}
		else
		{
			object obj13 = RuntimeFlags & (NetworkObjectRuntimeFlags)1;
			if (obj13 == null)
			{
				return;
			}
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v11+18]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v11+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7150]");
			object obj12 = 0;
		}
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ X9_v2+188] (should have been resolved before IL gen)");
	}

	protected internal unsafe override void GetDumpString(StringBuilder builder)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I8
		//IL_02f4: Expected Obj, but got I4
		//IL_0096: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I8
		//IL_035b: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
		object value = 0;
		StringBuilder stringBuilder = builder.Append((string)value);
		string debugNameThreadSafe = DebugNameThreadSafe;
		StringBuilder stringBuilder2 = builder.Append(debugNameThreadSafe);
		int* ptr = Ptr;
		if (Ptr != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X22_v1 (System.Int32*)+4]");
			object obj = 0 & -9223372036854775808L;
			if (obj != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj3 = 0;
		Span<int> span = default;
		nint num;
		if (span.IsEmpty)
		{
			num = unchecked((nint)null);
		}
		else
		{
			int* ptr2 = Ptr;
			num = (nint)ptr2;
		}
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj6 = 0;
		bool flag2 = num == 0;
		object obj7 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
			object value2 = 0;
			StringBuilder stringBuilder3 = builder.Append((string)value2);
			int* ptr3 = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X23_v4 (System.Int32*)+4]");
				object obj8 = 0 & -9223372036854775808L;
				if (obj8 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			if (span.IsEmpty)
			{
			}
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v36+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkId networkId = default;
			string value3 = networkId.ToString();
			StringBuilder stringBuilder4 = builder.Append(value3);
			obj7 = 0;
		}
		int length = builder.Length;
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
		object value4 = 0;
		if (NetworkRunner.TryGetPrettyRunnerName(builder, _runner))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1888]");
			object value5 = 0;
			StringBuilder stringBuilder5 = builder.Insert(length, (string)value5);
		}
		StringBuilder stringBuilder6 = builder.Append((string)value4);
	}
}
