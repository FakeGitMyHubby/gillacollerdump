using System.Runtime.CompilerServices;

namespace Fusion;

public static class GenerateFlagsExtensionsExtensions_public
{
	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value, NetworkTransform.NetworkTransformFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value)
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
	public static bool HasNot(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value, NetworkTransform.NetworkTransformFlags mask)
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
	public static bool HasAny(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkTransform.NetworkTransformFlags flag, NetworkTransform.NetworkTransformFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value)
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
	public static bool Has(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value, NetworkRigidbodyFlags mask)
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
	public static bool HasNot(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value)
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
	public static bool HasNot(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value, NetworkRigidbodyFlags mask)
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
	public static bool HasAny(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value)
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
	public static bool HasNone(NetworkRigidbodyFlags flag, NetworkRigidbodyFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFF;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(HitOptions flag, HitOptions value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(HitOptions flag, HitOptions value, HitOptions mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(HitOptions flag, HitOptions value)
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
	public static bool HasNot(HitOptions flag, HitOptions value, HitOptions mask)
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
	public static bool HasAny(HitOptions flag, HitOptions value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(HitOptions flag, HitOptions value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value, HitboxRoot.ConfigFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value)
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
	public static bool HasNot(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value, HitboxRoot.ConfigFlags mask)
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
	public static bool HasAny(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(HitboxRoot.ConfigFlags flag, HitboxRoot.ConfigFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectFlags flag, NetworkObjectFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectFlags flag, NetworkObjectFlags value, NetworkObjectFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectFlags flag, NetworkObjectFlags value)
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
	public static bool HasNot(NetworkObjectFlags flag, NetworkObjectFlags value, NetworkObjectFlags mask)
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
	public static bool HasAny(NetworkObjectFlags flag, NetworkObjectFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectFlags flag, NetworkObjectFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value, NetworkObjectHeaderFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value)
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
	public static bool HasNot(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value, NetworkObjectHeaderFlags mask)
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
	public static bool HasAny(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkObjectHeaderFlags flag, NetworkObjectHeaderFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcLocalInvokeResult flag, RpcLocalInvokeResult value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcLocalInvokeResult flag, RpcLocalInvokeResult value, RpcLocalInvokeResult mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(RpcLocalInvokeResult flag, RpcLocalInvokeResult value)
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
	public static bool HasNot(RpcLocalInvokeResult flag, RpcLocalInvokeResult value, RpcLocalInvokeResult mask)
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
	public static bool HasAny(RpcLocalInvokeResult flag, RpcLocalInvokeResult value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(RpcLocalInvokeResult flag, RpcLocalInvokeResult value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcSendMessageResult flag, RpcSendMessageResult value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcSendMessageResult flag, RpcSendMessageResult value, RpcSendMessageResult mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(RpcSendMessageResult flag, RpcSendMessageResult value)
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
	public static bool HasNot(RpcSendMessageResult flag, RpcSendMessageResult value, RpcSendMessageResult mask)
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
	public static bool HasAny(RpcSendMessageResult flag, RpcSendMessageResult value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(RpcSendMessageResult flag, RpcSendMessageResult value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcSources flag, RpcSources value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcSources flag, RpcSources value, RpcSources mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(RpcSources flag, RpcSources value)
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
	public static bool HasNot(RpcSources flag, RpcSources value, RpcSources mask)
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
	public static bool HasAny(RpcSources flag, RpcSources value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(RpcSources flag, RpcSources value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcTargets flag, RpcTargets value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(RpcTargets flag, RpcTargets value, RpcTargets mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(RpcTargets flag, RpcTargets value)
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
	public static bool HasNot(RpcTargets flag, RpcTargets value, RpcTargets mask)
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
	public static bool HasAny(RpcTargets flag, RpcTargets value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(RpcTargets flag, RpcTargets value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSpawnFlags flag, NetworkSpawnFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFFFF;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSpawnFlags flag, NetworkSpawnFlags value, NetworkSpawnFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFFFF;
		object obj3 = obj2 - value;
		return obj3 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkSpawnFlags flag, NetworkSpawnFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = ~(int)flag;
		object obj2 = value & obj;
		object obj3 = obj2 & 0xFFFF;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkSpawnFlags flag, NetworkSpawnFlags value, NetworkSpawnFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj & 0xFFFF;
		object obj3 = obj2 - value;
		bool flag2 = obj3 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasAny(NetworkSpawnFlags flag, NetworkSpawnFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFFFF;
		bool flag2 = obj2 == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkSpawnFlags flag, NetworkSpawnFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = value & flag;
		object obj2 = obj & 0xFFFF;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value, NetworkSceneInfoDefaultFlags mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value)
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
	public static bool HasNot(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value, NetworkSceneInfoDefaultFlags mask)
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
	public static bool HasAny(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkSceneInfoDefaultFlags flag, NetworkSceneInfoDefaultFlags value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value, NetworkSceneInfoChangeSource mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value)
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
	public static bool HasNot(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value, NetworkSceneInfoChangeSource mask)
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
	public static bool HasAny(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(NetworkSceneInfoChangeSource flag, NetworkSceneInfoChangeSource value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(Topologies flag, Topologies value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(Topologies flag, Topologies value, Topologies mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(Topologies flag, Topologies value)
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
	public static bool HasNot(Topologies flag, Topologies value, Topologies mask)
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
	public static bool HasAny(Topologies flag, Topologies value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(Topologies flag, Topologies value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value, TimeSyncConfiguration.ReliableDataTransfers mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value)
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
	public static bool HasNot(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value, TimeSyncConfiguration.ReliableDataTransfers mask)
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
	public static bool HasAny(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(TimeSyncConfiguration.ReliableDataTransfers flag, TimeSyncConfiguration.ReliableDataTransfers value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationModes flag, SimulationModes value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationModes flag, SimulationModes value, SimulationModes mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationModes flag, SimulationModes value)
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
	public static bool HasNot(SimulationModes flag, SimulationModes value, SimulationModes mask)
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
	public static bool HasAny(SimulationModes flag, SimulationModes value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(SimulationModes flag, SimulationModes value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationStages flag, SimulationStages value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = ~flag;
		object obj2 = value & obj;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool Has(SimulationStages flag, SimulationStages value, SimulationStages mask)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		object obj = mask & flag;
		object obj2 = obj - value;
		return obj2 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNot(SimulationStages flag, SimulationStages value)
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
	public static bool HasNot(SimulationStages flag, SimulationStages value, SimulationStages mask)
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
	public static bool HasAny(SimulationStages flag, SimulationStages value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		bool flag2 = obj == null;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool HasNone(SimulationStages flag, SimulationStages value)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = value & flag;
		return obj == null;
	}
}
