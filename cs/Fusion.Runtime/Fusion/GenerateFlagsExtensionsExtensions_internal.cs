using System.Runtime.CompilerServices;

namespace Fusion;

internal static class GenerateFlagsExtensionsExtensions_internal
{
	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(BehaviourCallbackFlags flag, BehaviourCallbackFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(BehaviourCallbackFlags flag, BehaviourCallbackFlags value, BehaviourCallbackFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(BehaviourCallbackFlags flag, BehaviourCallbackFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(BehaviourCallbackFlags flag, BehaviourCallbackFlags value, BehaviourCallbackFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(BehaviourCallbackFlags flag, BehaviourCallbackFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(BehaviourCallbackFlags flag, BehaviourCallbackFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(AnimatorSyncSettings flag, AnimatorSyncSettings value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(AnimatorSyncSettings flag, AnimatorSyncSettings value, AnimatorSyncSettings mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(AnimatorSyncSettings flag, AnimatorSyncSettings value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(AnimatorSyncSettings flag, AnimatorSyncSettings value, AnimatorSyncSettings mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(AnimatorSyncSettings flag, AnimatorSyncSettings value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(AnimatorSyncSettings flag, AnimatorSyncSettings value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value, NetworkPropertyMetaFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value, NetworkPropertyMetaFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkPropertyMetaFlags flag, NetworkPropertyMetaFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value, SimulationBehaviourRuntimeFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value, SimulationBehaviourRuntimeFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(SimulationBehaviourRuntimeFlags flag, SimulationBehaviourRuntimeFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value, NetworkObjectConnectionDataFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value, NetworkObjectConnectionDataFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectConnectionDataFlags flag, NetworkObjectConnectionDataFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value, NetworkObjectDestroyFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value, NetworkObjectDestroyFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectDestroyFlags flag, NetworkObjectDestroyFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value, NetworkObjectHeaderPlayerDataFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value, NetworkObjectHeaderPlayerDataFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectHeaderPlayerDataFlags flag, NetworkObjectHeaderPlayerDataFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value, NetworkObjectMetaFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value, NetworkObjectMetaFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectMetaFlags flag, NetworkObjectMetaFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value, NetworkObjectPacketFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value, NetworkObjectPacketFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectPacketFlags flag, NetworkObjectPacketFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value, NetworkObjectRuntimeFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value, NetworkObjectRuntimeFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectRuntimeFlags flag, NetworkObjectRuntimeFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkRunnerFlags flag, NetworkRunnerFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkRunnerFlags flag, NetworkRunnerFlags value, NetworkRunnerFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkRunnerFlags flag, NetworkRunnerFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkRunnerFlags flag, NetworkRunnerFlags value, NetworkRunnerFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkRunnerFlags flag, NetworkRunnerFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkRunnerFlags flag, NetworkRunnerFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFF;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value, NetworkLoadSceneParametersFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFF;
		object obj3 = obj2 - value;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFF;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value, NetworkLoadSceneParametersFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFF;
		object obj3 = obj2 - value;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFF;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkLoadSceneParametersFlags flag, NetworkLoadSceneParametersFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFF;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFF;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value, SimulationMessageHeaderFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFF;
		object obj3 = obj2 - value;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFF;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value, SimulationMessageHeaderFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFF;
		object obj3 = obj2 - value;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFF;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(SimulationMessageHeaderFlags flag, SimulationMessageHeaderFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFF;
		return obj2 == null;
	}
}
